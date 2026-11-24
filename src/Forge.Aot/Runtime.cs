using System;
using System.Linq;
using System.Collections.Generic;

namespace Planeswalker.ForgeAot
{
    public enum JRunState { Idle,Running,Yielded,Waiting,Completed,Failed }
    public sealed class JHostRequest
    {
        public readonly long Id;
        public readonly string Method,ReturnType;
        public readonly JValue Receiver;
        public readonly JValue[] Arguments;
        internal JHostRequest(long id,string method,string returns,JValue receiver,JValue[] arguments){Id=id;Method=method;ReturnType=returns;Receiver=receiver;Arguments=arguments;}
    }
    public readonly struct JHostResult
    {
        public readonly bool Wait;
        public readonly JValue Value;
        public readonly JFrame? Frame;
        private JHostResult(bool wait,JValue value,JFrame? frame=null){Wait=wait;Value=value;Frame=frame;}
        public static JHostResult Complete(JValue value=default)=>new JHostResult(false,value);
        public static JHostResult Suspend=>new JHostResult(true,default);
        public static JHostResult Schedule(JFrame frame)=>new JHostResult(false,default,frame);
    }
    public sealed partial class JRuntime
    {
        public JProgram Program { get; }
        private readonly List<JFrame> frames=new List<JFrame>();
        private readonly Dictionary<string,JObject> strings=new Dictionary<string,JObject>(StringComparer.Ordinal);
        private readonly Dictionary<string,JObject> classObjects=new Dictionary<string,JObject>(StringComparer.Ordinal);
        private readonly Dictionary<string,JValue> statics=new Dictionary<string,JValue>(StringComparer.Ordinal);
        private readonly Dictionary<string,int> initialized=new Dictionary<string,int>(StringComparer.Ordinal);
        private readonly Dictionary<string,JFrame> initializingOwner=new Dictionary<string,JFrame>(StringComparer.Ordinal);
        private readonly Dictionary<int,int> monitors=new Dictionary<int,int>();
        private readonly Dictionary<string,Func<JRuntime,JValue,JValue[],JHostResult>> bindings=new Dictionary<string,Func<JRuntime,JValue,JValue[],JHostResult>>(StringComparer.Ordinal);
        private readonly Dictionary<string,(int Count,string Returns)> callDescriptors=new Dictionary<string,(int,string)>(StringComparer.Ordinal);
        private readonly HashSet<(string Owner,string Name,string Descriptor)> interfaceDefaults=new HashSet<(string,string,string)>();
        private int identity,instructions;
        private long nextRequest;
        private JFrame? waitingFrame;
        public JHostRequest? Pending { get; private set; }
        public JRunState State { get; private set; }
        public JValue Result { get; private set; }
        public string Error { get; private set; }="";
        public JRuntime(JProgram program){Program=program;InstallIntrinsics();InstallFactories();InstallStandardLibrary();InstallRegex();InstallStreams();InstallRanges();InstallCoreLibrary();InstallAdvancedLibrary();InstallTeamDayNightAdapter();}
        // Optional ordered entry trace. Distinct-method coverage is not an execution trace.
        public Action<string>? Trace { get; set; }
        public Action<JFrame>? MethodEntered { get; set; }
        public Action<JFrame,JValue>? MethodReturned { get; set; }
        // The in-game host uses a fixed generated program and append-only native
        // adapters. Inspection and migration tests may mutate metadata directly.
        public bool CacheLinkedMembers { get; set; }
        public bool CollectCoverage { get; set; }=true;
        public string? InspectEnumName(JValue value)=>value.Reference!=null&&value.Reference.Fields.TryGetValue("java/lang/Enum.name:Ljava/lang/String;",out var name)?name.Reference?.Text:null;
        private readonly HashSet<JFrame> tracedFrames=new HashSet<JFrame>();
        public readonly HashSet<string> ExecutedMethods=new HashSet<string>(StringComparer.Ordinal);
        public readonly HashSet<string> ExecutedBindings=new HashSet<string>(StringComparer.Ordinal);
        public IReadOnlyCollection<string> BindingNames=>bindings.Keys;
        private readonly Dictionary<string,Func<JValue>> staticBindings=new Dictionary<string,Func<JValue>>(StringComparer.Ordinal);
        public JObject HostObject(string type,object payload)=>new JObject(type,++identity){HostStorage=true,Payload=payload};
        public T HostPayload<T>(JValue value)=>NonNull(value).Payload is T result?result:throw new PortGap("Host storage mismatch: "+NonNull(value).ClassName+" -> "+typeof(T).Name);
        public string StringValue(JValue value)=>Text(value);
        public IReadOnlyDictionary<string,JValue> InspectFields(JObject value)=>new System.Collections.ObjectModel.ReadOnlyDictionary<string,JValue>(value.Fields);
        public JValue BoxInt(int value)
        {
            if(value>=-128&&value<=127){if(!integerCache.TryGetValue(value,out var box)){box=new JObject("java/lang/Integer",++identity){HostStorage=true,Boxed=JValue.I(value)};integerCache.Add(value,box);}return JValue.R(box);}
            return JValue.R(new JObject("java/lang/Integer",++identity){HostStorage=true,Boxed=JValue.I(value)});
        }
        public int UnboxInt(JValue value)=>NonNull(value).Boxed?.Int??throw new PortGap("Integer box required");
        public void BindStatic(string owner,string name,string descriptor,Func<JValue> getter)=>staticBindings.Add(owner+"."+name+":"+descriptor,getter);
        private long sliceDeadline;
        public bool SliceExpired=>sliceDeadline!=0 && inlineDepth==0 && System.Diagnostics.Stopwatch.GetTimestamp()>=sliceDeadline;
        public bool Tick()
        {
            if(instructions<=0)return false;
            if(sliceDeadline!=0 && inlineDepth==0 && (instructions&255)==0 && System.Diagnostics.Stopwatch.GetTimestamp()>=sliceDeadline)return false;
            instructions--;return true;
        }
        public void Bind(string owner,string name,string descriptor,Func<JRuntime,JValue,JValue[],JHostResult> implementation)=>bindings.Add(owner+"."+name+descriptor,implementation);
        public JObject String(string value)
        {
            if(!strings.TryGetValue(value,out var text)){text=new JObject("java/lang/String",++identity){Text=value,HostStorage=true};strings.Add(value,text);}return text;
        }
        public JObject ClassObject(string name)
        {
            if(!classObjects.TryGetValue(name,out var value)){value=new JObject("java/lang/Class",++identity){RepresentedClass=name,HostStorage=true};classObjects.Add(name,value);}return value;
        }
        public JObject Allocate(string name)
        {
            var value=new JObject(name,++identity);
            AddFields(value,name,new HashSet<string>(StringComparer.Ordinal));return value;
        }
        private void AddFields(JObject value,string name,HashSet<string> visited)
        {
            if(!visited.Add(name))throw new PortGap("Cyclic class hierarchy: "+name);
            if(!Program.Classes.TryGetValue(name,out var cls))
            {if(name=="java/lang/Object")return;throw new PortGap("Unlinked class: "+name);}
            if(cls.Super.Length!=0)AddFields(value,cls.Super,visited);
            foreach(var field in cls.Fields.Values)if(!field.Static)value.Fields.Add(field.StorageKey,JValue.Default(field.Descriptor));
        }
        public JavaFault Fault(string type,string message="")=>new JavaFault(new JObject(type,++identity){Text=message,HostStorage=true},message);
        public JObject NonNull(JValue value)=>value.Reference??throw Fault("java/lang/NullPointerException");
        public bool IsInstance(JObject? value,string target)
        {
            if(value==null)return false;
            string source=value.ClassName;
            if(source==target||target=="java/lang/Object")return true;
            if(!CacheLinkedMembers)return Assignable(source,target,new HashSet<string>(StringComparer.Ordinal));
            CheckLinkCaches();
            if(!typeTests.TryGetValue((source,target),out bool result)){
                result=Assignable(source,target,new HashSet<string>(StringComparer.Ordinal));
                typeTests.Add((source,target),result);
            }
            return result;
        }
        private bool Assignable(string source,string target,HashSet<string> visited)
        {
            if(source==target||target=="java/lang/Object")return true;
            if(!visited.Add(source))return false;
            if(source.StartsWith("[",StringComparison.Ordinal))
            {
                if(target=="java/lang/Cloneable"||target=="java/io/Serializable")return true;
                if(!target.StartsWith("[",StringComparison.Ordinal))return false;
                string a=source.Substring(1),b=target.Substring(1);
                if(a==b)return true;
                bool ar=a.StartsWith("L",StringComparison.Ordinal)||a.StartsWith("[",StringComparison.Ordinal);
                bool br=b.StartsWith("L",StringComparison.Ordinal)||b.StartsWith("[",StringComparison.Ordinal);
                return ar&&br&&Assignable(ElementClass(a),ElementClass(b),visited);
            }
            if(Program.Classes.TryGetValue(source,out var cls))
            {
                foreach(string iface in cls.Interfaces)if(Assignable(iface,target,new HashSet<string>(visited,StringComparer.Ordinal)))return true;
                return cls.Super.Length!=0&&Assignable(cls.Super,target,visited);
            }
            if(BuiltinParents.TryGetValue(source,out string parent))return Assignable(parent,target,visited);
            throw new PortGap("Missing assignability metadata: "+source+" -> "+target);
        }
        private static readonly Dictionary<string,string> BuiltinParents=new Dictionary<string,string>(StringComparer.Ordinal)
        {
            ["java/lang/String"]="java/lang/Object",["java/lang/Class"]="java/lang/Object",
            ["java/lang/Throwable"]="java/lang/Object",["java/lang/Exception"]="java/lang/Throwable",["java/lang/Error"]="java/lang/Throwable",
            ["java/lang/RuntimeException"]="java/lang/Exception",["java/lang/ArithmeticException"]="java/lang/RuntimeException",
            ["java/lang/NullPointerException"]="java/lang/RuntimeException",["java/lang/ClassCastException"]="java/lang/RuntimeException",
            ["java/lang/IndexOutOfBoundsException"]="java/lang/RuntimeException",["java/lang/ArrayIndexOutOfBoundsException"]="java/lang/IndexOutOfBoundsException",
            ["java/lang/StringIndexOutOfBoundsException"]="java/lang/IndexOutOfBoundsException",["java/lang/NegativeArraySizeException"]="java/lang/RuntimeException",
            ["java/lang/ArrayStoreException"]="java/lang/RuntimeException",["java/lang/IllegalMonitorStateException"]="java/lang/RuntimeException",
            ["java/lang/IllegalArgumentException"]="java/lang/RuntimeException",["java/lang/NumberFormatException"]="java/lang/IllegalArgumentException",
            ["java/lang/IllegalStateException"]="java/lang/RuntimeException",["java/lang/UnsupportedOperationException"]="java/lang/RuntimeException",
            ["java/lang/CloneNotSupportedException"]="java/lang/Exception",
            ["java/util/NoSuchElementException"]="java/lang/RuntimeException",["java/util/ConcurrentModificationException"]="java/lang/RuntimeException",
            ["java/util/EmptyStackException"]="java/lang/RuntimeException"
        };
        private static string ElementClass(string descriptor)=>descriptor[0]=='L'?descriptor.Substring(1,descriptor.Length-2):descriptor;
        public JArray NewArray(string component,int length)
        {if(length<0)throw Fault("java/lang/NegativeArraySizeException");return new JArray(component,length,++identity);}
        public JArray MultiArray(string descriptor,int[] lengths,int depth=0)
        {
            foreach(int length in lengths)if(length<0)throw Fault("java/lang/NegativeArraySizeException");
            var array=NewArray(descriptor.Substring(1),lengths[depth]);
            if(depth+1<lengths.Length)for(int i=0;i<array.Items.Length;i++)array.Items[i]=JValue.R(MultiArray(descriptor.Substring(1),lengths,depth+1));
            return array;
        }
        private JArray ArrayObject(JValue value)=>NonNull(value) is JArray a?a:throw new PortGap("Verified array reference expected");
        public JValue ArrayLoad(JValue value,int index)
        {
            var array=ArrayObject(value);if(index<0||index>=array.Items.Length)throw Fault("java/lang/ArrayIndexOutOfBoundsException");return array.Items[index];
        }
        public void ArrayStore(JValue value,int index,JValue item)
        {
            var array=ArrayObject(value);if(index<0||index>=array.Items.Length)throw Fault("java/lang/ArrayIndexOutOfBoundsException");
            unchecked
            {
                switch(array.Component)
                {
                    case "Z":item=JValue.I(item.Int&1);break;case "B":item=JValue.I((sbyte)item.Int);break;
                    case "C":item=JValue.I((char)item.Int);break;case "S":item=JValue.I((short)item.Int);break;
                    default:if((array.Component[0]=='L'||array.Component[0]=='[')&&item.Reference!=null&&!IsInstance(item.Reference,ElementClass(array.Component)))throw Fault("java/lang/ArrayStoreException");break;
                }
            }
            array.Items[index]=item;
        }
        public int ArrayLength(JValue value)=>ArrayObject(value).Items.Length;
        public void EnterMonitor(JObject value){monitors.TryGetValue(value.Identity,out int count);monitors[value.Identity]=count+1;}
        public void ExitMonitor(JObject value)
        {if(!monitors.TryGetValue(value.Identity,out int count)||count==0)throw Fault("java/lang/IllegalMonitorStateException");if(count==1)monitors.Remove(value.Identity);else monitors[value.Identity]=count-1;}
        private JClass Class(string name)=>Program.Classes.TryGetValue(name,out var cls)?cls:throw new PortGap("Unlinked class: "+name);
        private (JClass,JField) FindField(string owner,string name,string descriptor,HashSet<string>? visited=null)
        {
            if(CacheLinkedMembers && visited==null){
                CheckLinkCaches();
                var key=(owner,name,descriptor);
                if(!fieldLinks.TryGetValue(key,out var linked)){
                    linked=FindField(owner,name,descriptor,new HashSet<string>(StringComparer.Ordinal));
                    fieldLinks.Add(key,linked);
                }
                return linked;
            }
            visited=visited??new HashSet<string>(StringComparer.Ordinal);if(!visited.Add(owner))throw new PortGap("Unresolved field: "+owner+"."+name);
            var cls=Class(owner);if(cls.Fields.TryGetValue(name+":"+descriptor,out var field))return (cls,field);
            foreach(string iface in cls.Interfaces)
            {
                var found=TryField(iface,name,descriptor,new HashSet<string>(visited,StringComparer.Ordinal));if(found.HasValue)return found.Value;
            }
            if(cls.Super.Length!=0)return FindField(cls.Super,name,descriptor,visited);
            throw new PortGap("Unlinked field: "+owner+"."+name+":"+descriptor);
        }
        private (JClass,JField)? TryField(string owner,string name,string descriptor,HashSet<string> visited)
        {
            if(!visited.Add(owner))return null;var cls=Class(owner);
            if(cls.Fields.TryGetValue(name+":"+descriptor,out var field))return (cls,field);
            foreach(string iface in cls.Interfaces){var result=TryField(iface,name,descriptor,new HashSet<string>(visited,StringComparer.Ordinal));if(result.HasValue)return result;}
            return cls.Super.Length==0?null:TryField(cls.Super,name,descriptor,visited);
        }
        public JValue GetField(JValue receiver,string owner,string name,string descriptor)
        {var value=NonNull(receiver);if(value.HostStorage)throw new PortGap("Host object field ABI is not adapted: "+value.ClassName+"."+name);var field=FindField(owner,name,descriptor);return value.Fields[field.Item2.StorageKey];}
        public void PutField(JValue receiver,string owner,string name,string descriptor,JValue value)
        {var target=NonNull(receiver);if(target.HostStorage)throw new PortGap("Host object field ABI is not adapted: "+target.ClassName+"."+name);var field=FindField(owner,name,descriptor);target.Fields[field.Item2.StorageKey]=JNumbers.Narrow(descriptor,value);}
        public bool StaticReady(JFrame frame,string owner,string name,string descriptor)=>staticBindings.ContainsKey(owner+"."+name+":"+descriptor)||EnsureInitialized(frame,FindField(owner,name,descriptor).Item1.Name);
        public JValue GetStatic(string owner,string name,string descriptor)
        {
            if(staticBindings.TryGetValue(owner+"."+name+":"+descriptor,out var getter))return getter();
            var field=FindField(owner,name,descriptor);string key=field.Item2.StorageKey;
            if(!statics.TryGetValue(key,out var value)){value=field.Item2.ConstantString==null?field.Item2.Initial:JValue.R(String(field.Item2.ConstantString));statics.Add(key,value);}return value;
        }
        public void PutStatic(string owner,string name,string descriptor,JValue value)
        {var field=FindField(owner,name,descriptor);statics[field.Item2.StorageKey]=JNumbers.Narrow(descriptor,value);}
        public bool EnsureInitialized(JFrame requester,string name)
        {
            if(name=="java/lang/Object"||name.StartsWith("[",StringComparison.Ordinal))return true;
            initialized.TryGetValue(name,out int state);
            if(state==3)return true;if(state==4)throw new PortGap("Failed initializer: "+name);
            if(state==2||state==1&&initializingOwner[name]!=requester)return true;
            var cls=Class(name);
            if(state==0){initialized[name]=1;initializingOwner[name]=requester;}
            if((cls.Access&0x200)==0&&cls.Super.Length!=0&&!EnsureInitialized(requester,cls.Super))return false;
            // Default-method interface initialization needs a complete link graph before use.
            if((cls.Access&0x200)==0)
                foreach(string iface in DefaultInterfaces(cls.Interfaces))if(!EnsureInitialized(requester,iface))return false;
            if(cls.Methods.TryGetValue("<clinit>()V",out var method))
            {
                if(method.Body==null)throw new PortGap("Missing class initializer: "+name);
                initialized[name]=2;var frame=new JFrame(method,default,Array.Empty<JValue>()){InitializingClass=name};frames.Add(frame);return false;
            }
            initialized[name]=3;return true;
        }
        private IEnumerable<string> DefaultInterfaces(string[] interfaces)
        {
            var result=new List<string>();var visited=new HashSet<string>(StringComparer.Ordinal);
            void Visit(string name)
            {
                if(!visited.Add(name))return;var cls=Class(name);foreach(string parent in cls.Interfaces)Visit(parent);
                foreach(var method in cls.Methods.Values)if((method.Access&(8|0x400|2))==0&&method.Name!="<clinit>"){result.Add(name);break;}
            }
            foreach(string name in interfaces)Visit(name);return result;
        }
        private JMethod? Resolve(string owner,string name,string descriptor,HashSet<string>? visited=null)
        {
            if(visited!=null&&visited.Contains(owner))return null;
            if(!Program.Classes.TryGetValue(owner,out var cls))return null;
            if(cls.Methods.TryGetValue(name+descriptor,out var method))return method;
            if(name=="<init>")return null;
            // The common direct-method path does not walk a hierarchy. Allocate
            // cycle-detection storage only when a parent/interface search is needed.
            visited=visited??new HashSet<string>(StringComparer.Ordinal);visited.Add(owner);
            if(cls.Super.Length!=0){var parent=Resolve(cls.Super,name,descriptor,visited);if(parent!=null)return parent;}
            JMethod? found=null;
            foreach(string iface in cls.Interfaces)
            {
                var candidate=Resolve(iface,name,descriptor,new HashSet<string>(visited,StringComparer.Ordinal));
                if(candidate==null||(candidate.Access&0x400)!=0)continue;
                if(found!=null&&found.Owner!=candidate.Owner)throw new PortGap("Interface default-method specificity requires full linker: "+owner+"."+name+descriptor);
                found=candidate;
            }
            return found;
        }
        private bool FindVirtualBinding(string type,string name,string descriptor,out string bindingOwner,out Func<JRuntime,JValue,JValue[],JHostResult>? binding)
        {
            string receiverType=type;
            var visited=new HashSet<string>(StringComparer.Ordinal);
            while(type.Length!=0&&visited.Add(type))
            {
                if(bindings.TryGetValue(type+"."+name+descriptor,out binding)){bindingOwner=type;return true;}
                if(type.StartsWith("[",StringComparison.Ordinal)){type="java/lang/Object";continue;}
                if(Program.Classes.TryGetValue(type,out var cls)){type=cls.Super;continue;}
                if(BuiltinParents.TryGetValue(type,out string parent)){type=parent;continue;}
                if(type=="java/lang/Object")break;
                // An opaque host object must not silently inherit the wrong Object implementation.
                throw new PortGap("Receiver hierarchy/API is not adapted: "+type+"."+name+descriptor);
            }
            string selected="";
            foreach(var item in interfaceDefaults)
            {
                if(item.Name!=name||item.Descriptor!=descriptor||!Assignable(receiverType,item.Owner,new HashSet<string>(StringComparer.Ordinal)))continue;
                if(selected.Length==0||Assignable(item.Owner,selected,new HashSet<string>(StringComparer.Ordinal)))selected=item.Owner;
                else if(!Assignable(selected,item.Owner,new HashSet<string>(StringComparer.Ordinal)))throw new PortGap("Ambiguous native interface defaults: "+receiverType+"."+name+descriptor);
            }
            bindingOwner=selected;binding=null;
            return selected.Length!=0&&bindings.TryGetValue(selected+"."+name+descriptor,out binding);
        }
        private readonly Dictionary<(string,string),bool> typeTests=new();
        private readonly Dictionary<(string,string,string),(JClass,JField)> fieldLinks=new();
        private readonly Dictionary<(string,string,string,string,string),CallLink> callLinks=new();
        private int linkedClasses,linkedBindings,linkedDefaults;
        private void CheckLinkCaches()
        {
            if(linkedClasses==Program.Classes.Count && linkedBindings==bindings.Count && linkedDefaults==interfaceDefaults.Count)return;
            linkedClasses=Program.Classes.Count;linkedBindings=bindings.Count;linkedDefaults=interfaceDefaults.Count;
            typeTests.Clear();fieldLinks.Clear();callLinks.Clear();
        }
        private readonly struct CallLink
        {
            public readonly JMethod? Method;
            public readonly Func<JRuntime,JValue,JValue[],JHostResult>? Binding;
            public readonly string NativeKey,DeclaredKey;
            public CallLink(JMethod? method,Func<JRuntime,JValue,JValue[],JHostResult>? binding,string nativeKey,string declaredKey)
            {Method=method;Binding=binding;NativeKey=nativeKey;DeclaredKey=declaredKey;}
        }
        public JStep Call(JFrame caller,string owner,string name,string descriptor,string kind,int next)
        {
            if(!callDescriptors.TryGetValue(descriptor,out var shape))
            {var parsed=JDescriptor.Parameters(descriptor,out string resultType);shape=(parsed.Length,resultType);callDescriptors.Add(descriptor,shape);}
            string returns=shape.Returns;
            bool isStatic=kind=="invokestatic";JValue receiver=isStatic?default:caller.Peek(shape.Count);
            if(!isStatic)NonNull(receiver);
            string dispatch=kind=="invokevirtual"||kind=="invokeinterface"?NonNull(receiver).ClassName:owner;
            CallLink link;
            if(CacheLinkedMembers){
                CheckLinkCaches();
                var key=(owner,name,descriptor,kind,dispatch);
                if(!callLinks.TryGetValue(key,out link)){
                    link=LinkCall(owner,name,descriptor,kind,dispatch);
                    callLinks.Add(key,link);
                }
            }else link=LinkCall(owner,name,descriptor,kind,dispatch);
            if(isStatic && link.Binding==null && !EnsureInitialized(caller,link.Method!.Owner))return JStep.Continue;
            caller.Pc=next;
            if(link.Binding!=null)
            {
                var args=caller.Arguments(shape.Count);if(!isStatic)caller.Pop();
                if(CollectCoverage)ExecutedBindings.Add(link.NativeKey);
                Trace?.Invoke("native " + link.NativeKey);
                var result=link.Binding(this,receiver,args);
                if(result.Frame!=null)frames.Add(result.Frame);
                else if(result.Wait){Pending=new JHostRequest(++nextRequest,link.DeclaredKey,returns,receiver,args);waitingFrame=caller;State=JRunState.Waiting;}
                else if(returns!="V")caller.Push(result.Value);
                return JStep.Continue;
            }
            var method=link.Method!;
            var callee=new JFrame(method,caller,shape.Count,isStatic);
            if((method.Access&0x20)!=0){callee.Monitor=isStatic?ClassObject(method.Owner):NonNull(receiver);EnterMonitor(callee.Monitor);}
            frames.Add(callee);return JStep.Continue;
        }
        private CallLink LinkCall(string owner,string name,string descriptor,string kind,string dispatch)
        {
            var declared=Resolve(owner,name,descriptor);
            if(declared!=null&&(declared.Access&2)!=0)dispatch=declared.Owner;
            string bindingKey=owner+"."+name+descriptor;
            var method=dispatch==owner?declared:Resolve(dispatch,name,descriptor);
            string bindingOwner=owner;Func<JRuntime,JValue,JValue[],JHostResult>? binding;
            bool virtualCall=kind=="invokevirtual"||kind=="invokeinterface";
            bool bound;
            if(virtualCall&&method?.Body!=null)
            {bindingOwner=method.Owner;bound=bindings.TryGetValue(method.Owner+"."+name+descriptor,out binding);}
            else if(virtualCall)bound=FindVirtualBinding(dispatch,name,descriptor,out bindingOwner,out binding);
            else bound=bindings.TryGetValue(bindingKey,out binding);
            if(!bound&&virtualCall&&method?.Body==null)
            {bindingOwner=owner;bound=bindings.TryGetValue(bindingKey,out binding);}
            if(!bound&&!virtualCall&&method!=null)
            {bindingOwner=method.Owner;bound=bindings.TryGetValue(method.Owner+"."+name+descriptor,out binding);}
            if(kind=="invokestatic"&&!bound&&method==null)throw new PortGap("Unlinked call: "+bindingKey);
            // A binding on a declared ancestor must not hide an actual Java override.
            if(bound&&method?.Body!=null&&method.Owner!=bindingOwner)bound=false;
            if(!bound&&(method==null||method.Body==null))throw new PortGap("Unlinked runtime call: "+bindingKey+" dispatched as "+dispatch);
            return new CallLink(method,bound?binding:null,bound?bindingOwner+"."+name+descriptor:"",bindingKey);
        }
        public void Start(JMethod method,JValue receiver,params JValue[] args)
        {
            if(frames.Count!=0||Pending!=null)throw new PortGap("An execution is already active");
            if(method.Body==null)throw new PortGap("Entry has no generated body: "+method.Key);
            frames.Add(new JFrame(method,receiver,args){InitializeOnEntry=method.Static});State=JRunState.Running;Error="";Result=default;
        }
        public JRunState Run(int instructionBudget)=>RunScoped(instructionBudget,0);
        public JRunState RunSlice(int instructionBudget,int milliseconds)
        {
            if(milliseconds<=0)throw new ArgumentOutOfRangeException(nameof(milliseconds));
            sliceDeadline=System.Diagnostics.Stopwatch.GetTimestamp()+milliseconds*System.Diagnostics.Stopwatch.Frequency/1000;
            try{return Run(instructionBudget);}
            finally{sliceDeadline=0;}
        }
        private JRunState RunScoped(int instructionBudget,int boundary)
        {
            if(instructionBudget<=0)throw new ArgumentOutOfRangeException(nameof(instructionBudget));
            if(Pending!=null)return State=JRunState.Waiting;
            if(State==JRunState.Completed||State==JRunState.Failed)return State;
            instructions=instructionBudget;State=JRunState.Running;
            try
            {
                while(frames.Count>boundary&&instructions>0&&Pending==null)
                {
                    var frame=frames[frames.Count-1];
                    try
                    {
                        if(frame.InitializeOnEntry){if(!EnsureInitialized(frame,frame.Method.Owner))continue;frame.InitializeOnEntry=false;}
                        if(CollectCoverage)ExecutedMethods.Add(frame.Method.Key);
                        if((Trace!=null||MethodEntered!=null)&&tracedFrames.Add(frame)){Trace?.Invoke("enter " + frame.Method.Key);MethodEntered?.Invoke(frame);}
                        var step=frame.Method.Body!(this,frame);
                        if(step.Kind==JStepKind.Yield)break;
                        if(step.Kind!=JStepKind.Return)continue;
                        Trace?.Invoke("return "+frame.Method.Key);
                        MethodReturned?.Invoke(frame,step.Value);
                        frames.RemoveAt(frames.Count-1);tracedFrames.Remove(frame);
                        if(frame.Monitor!=null)ExitMonitor(frame.Monitor);
                        if(frame.InitializingClass!=null)initialized[frame.InitializingClass]=3;
                        if(frames.Count==boundary){Result=step.Value;State=JRunState.Completed;break;}
                        if(step.HasValue)frames[frames.Count-1].Push(step.Value);
                    }
                    catch(JavaFault fault){CaptureFailureOrigin(fault);Trace?.Invoke("throw "+fault.Value.ClassName+": "+fault.Message+"\nJAVA STACK\n"+string.Join("\n",frames.AsEnumerable().Reverse().Select(f=>f.Method.Key+" pc="+f.LastPc)));Unwind(fault,boundary);}
                }
                if(Pending!=null)State=JRunState.Waiting;
                else if(frames.Count>boundary)State=JRunState.Yielded;
                return State;
            }
            catch(Exception error){CaptureFailureOrigin(error);Trace?.Invoke("RUNTIME FAILURE "+error+"\nJAVA STACK\n"+string.Join("\n",frames.AsEnumerable().Reverse().Select(f=>f.Method.Key+" pc="+f.LastPc)));State=JRunState.Failed;Error=error.Message;throw;}
        }
        private void CaptureFailureOrigin(Exception error)
        {
            if(error.Data.Contains("Forge.JavaStack"))return;
            error.Data["Forge.JavaStack"]=string.Join("\n",frames.AsEnumerable().Reverse().Select(f=>f.Method.Key+" pc="+f.LastPc));
            // Capture references before unwinding; diagnostics must not invoke
            // further Java methods on an already failed execution.
            error.Data["Forge.FailureLocals"]=frames.AsEnumerable().Reverse().SelectMany(f=>f.Locals).Where(v=>v.Reference!=null).ToArray();
        }
        private void Unwind(JavaFault fault,int boundary=0)
        {
            while(frames.Count>boundary)
            {
                var frame=frames[frames.Count-1];
                foreach(var handler in frame.Method.Handlers)
                    if(frame.LastPc>=handler.Start&&frame.LastPc<handler.End&&(handler.Type.Length==0||IsInstance(fault.Value,handler.Type)))
                    {frame.Clear();frame.Push(JValue.R(fault.Value));frame.Pc=handler.Target;return;}
                frames.RemoveAt(frames.Count-1);tracedFrames.Remove(frame);if(frame.Monitor!=null)ExitMonitor(frame.Monitor);
                if(frame.ReflectiveConstructor)throw new PortGap("Reflective constructor exception wrapping remains unported: "+fault.Message);
                if(frame.InitializingClass!=null)
                {initialized[frame.InitializingClass]=4;throw new PortGap("Initializer error wrapping remains unported: "+frame.InitializingClass+": "+fault.Message);}
            }
            throw fault;
        }
        public void Resume(long requestId,JValue answer)
        {
            if(Pending==null||Pending.Id!=requestId||waitingFrame==null)throw new PortGap("Stale host decision");
            string expected=Pending.ReturnType;
            if(expected!="V")
            {
                bool ok=expected=="J"?answer.Kind==JKind.Long:expected=="F"?answer.Kind==JKind.Float:expected=="D"?answer.Kind==JKind.Double:
                    expected[0]=='L'||expected[0]=='['?answer.Kind==JKind.Reference&&(answer.Reference==null||IsInstance(answer.Reference,ElementClass(expected))):answer.Kind==JKind.Int;
                if(!ok||expected=="Z"&&answer.Int!=0&&answer.Int!=1)throw new PortGap("Host decision type mismatch");waitingFrame.Push(JNumbers.Narrow(expected,answer));
            }
            Pending=null;waitingFrame=null;State=JRunState.Running;
        }
    }
}
