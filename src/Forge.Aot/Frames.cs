using System;
using System.Collections.Generic;

namespace Planeswalker.ForgeAot
{
    public sealed class JFrame
    {
        public JMethod Method { get; }
        public JValue[] Locals { get; }
        private JValue[] stack;
        private int depth;
        public int Pc,LastPc;
        internal string? InitializingClass;
        internal JObject? Monitor;
        internal bool InitializeOnEntry,ReflectiveConstructor;
        internal JConcatState? Concat;
        internal JLambdaInvocation? LambdaInvocation;
        internal JRecordState? Record;
        private JFrame(JMethod method)
        {
            Method=method;Locals=method.MaxLocals==0?Array.Empty<JValue>():new JValue[method.MaxLocals];
            stack=method.MaxStack==0?Array.Empty<JValue>():new JValue[method.MaxStack];
        }
        public JFrame(JMethod method,JValue receiver,JValue[] arguments):this(method)
        {
            int local=0;if(!method.Static)Locals[local++]=receiver;
            if(arguments.Length!=method.Parameters.Length)throw new PortGap("Argument arity: "+method.Key);
            for(int i=0;i<arguments.Length;i++){Locals[local]=arguments[i];local+=method.Parameters[i]=="J"||method.Parameters[i]=="D"?2:1;}
        }
        internal JFrame(JMethod method,JFrame caller,int count,bool isStatic):this(method)
        {
            if(count!=method.Parameters.Length)throw new PortGap("Argument arity: "+method.Key);
            int start=caller.depth-count;
            int local=0;
            if(!isStatic)Locals[local++]=caller.stack[start-1];
            for(int i=0;i<count;i++){
                Locals[local]=caller.stack[start+i];
                local+=method.Parameters[i]=="J"||method.Parameters[i]=="D"?2:1;
            }
            int consumed=count+(isStatic?0:1);
            caller.depth-=consumed;
            Array.Clear(caller.stack,caller.depth,consumed);
        }
        public void Push(JValue value){
            if(depth==stack.Length)Array.Resize(ref stack,Math.Max(4,depth*2));
            stack[depth++]=value;
        }
        public JValue Pop(){
            if(depth==0)throw new PortGap("Operand underflow: "+Method.Key);
            var value=stack[--depth];stack[depth]=default;return value;
        }
        public JValue Peek(int below=0)=>stack[depth-1-below];
        public void Clear(){Array.Clear(stack,0,depth);depth=0;}
        public JValue[] Arguments(int count){if(count==0)return Array.Empty<JValue>();var values=new JValue[count];for(int i=count-1;i>=0;i--)values[i]=Pop();return values;}
        public void StackOp(string op)
        {
            var a=Pop();
            if(op=="pop")return;
            if(op=="pop2"){if(!a.Wide)Pop();return;}
            if(op=="dup"){Push(a);Push(a);return;}
            if(op=="dup2"&&a.Wide){Push(a);Push(a);return;}
            var b=Pop();
            if(op=="swap"){Push(a);Push(b);return;}
            if(op=="dup_x1"){Push(a);Push(b);Push(a);return;}
            if(op=="dup_x2")
            {if(b.Wide){Push(a);Push(b);Push(a);}else{var c=Pop();Push(a);Push(c);Push(b);Push(a);}return;}
            if(op=="dup2"){Push(b);Push(a);Push(b);Push(a);return;}
            if(op=="dup2_x1")
            {if(a.Wide){Push(a);Push(b);Push(a);}else{var c=Pop();Push(b);Push(a);Push(c);Push(b);Push(a);}return;}
            if(op=="dup2_x2")
            {
                if(a.Wide)
                {if(b.Wide){Push(a);Push(b);Push(a);}else{var c=Pop();Push(a);Push(c);Push(b);Push(a);}}
                else
                {var c=Pop();if(c.Wide){Push(b);Push(a);Push(c);Push(b);Push(a);}else{var d=Pop();Push(b);Push(a);Push(d);Push(c);Push(b);Push(a);}}
                return;
            }
            throw new PortGap("Unknown stack operation: "+op);
        }
    }
    public enum JStepKind { Continue,Yield,Return }
    public readonly struct JStep
    {
        public readonly JStepKind Kind;
        public readonly JValue Value;
        public readonly bool HasValue;
        private JStep(JStepKind kind,JValue value=default,bool hasValue=false){Kind=kind;Value=value;HasValue=hasValue;}
        public static JStep Continue=>new JStep(JStepKind.Continue);
        public static JStep Yield=>new JStep(JStepKind.Yield);
        public static JStep Return(JValue value)=>new JStep(JStepKind.Return,value,true);
        public static JStep ReturnVoid=>new JStep(JStepKind.Return);
    }
    public readonly struct JHandler
    {
        public readonly int Start,End,Target;
        public readonly string Type;
        public JHandler(int start,int end,int target,string type){Start=start;End=end;Target=target;Type=type;}
    }
    public sealed class JMethod
    {
        public readonly int Id,Access,MaxLocals,MaxStack;
        public readonly string Owner,Name,Descriptor,Key,ReturnType;
        public readonly string[] Parameters;
        public readonly JHandler[] Handlers;
        public readonly Func<JRuntime,JFrame,JStep>? Body;
        public bool Static=>(Access&8)!=0;
        public JMethod(int id,string owner,string name,string descriptor,int access,int maxLocals,int maxStack,JHandler[] handlers,Func<JRuntime,JFrame,JStep>? body)
        {Id=id;Owner=owner;Name=name;Descriptor=descriptor;Key=owner+"."+name+descriptor;Access=access;MaxLocals=maxLocals;MaxStack=maxStack;Handlers=handlers;Body=body;Parameters=JDescriptor.Parameters(descriptor,out ReturnType);}
    }
    public sealed class JField
    {
        internal string StorageKey { get; set; } = "";
        public readonly string Name,Descriptor;
        public readonly bool Static;
        public readonly JValue Initial;
        public readonly string? ConstantString;
        public JField(string name,string descriptor,bool isStatic,JValue initial,string? constantString=null){Name=name;Descriptor=descriptor;Static=isStatic;Initial=initial;ConstantString=constantString;}
    }
    public sealed class JClass
    {
        public readonly string Name,Super;
        public readonly string[] Interfaces;
        public readonly int Access;
        public readonly Dictionary<string,JMethod> Methods=new Dictionary<string,JMethod>(StringComparer.Ordinal);
        public readonly Dictionary<string,JField> Fields=new Dictionary<string,JField>(StringComparer.Ordinal);
        public JClass(string name,string parent,string[] interfaces,int access){Name=name;Super=parent;Interfaces=interfaces;Access=access;}
        public void Add(JMethod method)=>Methods.Add(method.Name+method.Descriptor,method);
        public void Add(JField field)
        {
            string member=field.Name+":"+field.Descriptor;
            Fields.Add(member,field);
            field.StorageKey=Name+"."+member;
        }
    }
    public sealed class JProgram
    {
        public readonly Dictionary<string,JClass> Classes=new Dictionary<string,JClass>(StringComparer.Ordinal);
        public readonly List<JRuleFactory> Factories=new List<JRuleFactory>();
        public readonly Dictionary<string,JConcatSite> ConcatSites=new Dictionary<string,JConcatSite>(StringComparer.Ordinal);
        public readonly Dictionary<string,JLambdaSite> LambdaSites=new Dictionary<string,JLambdaSite>(StringComparer.Ordinal);
        public readonly Dictionary<string,JRecordSite> RecordSites=new Dictionary<string,JRecordSite>(StringComparer.Ordinal);
        // Generated method bodies and call-site metadata are immutable. Give each
        // runtime its own registries for host classes installed during play.
        public JProgram Fork()
        {
            var copy=new JProgram();
            foreach(var cls in Classes.Values)copy.Add(cls);
            copy.Factories.AddRange(Factories);
            foreach(var site in ConcatSites)copy.ConcatSites.Add(site.Key,site.Value);
            foreach(var site in LambdaSites)copy.LambdaSites.Add(site.Key,site.Value);
            foreach(var site in RecordSites)copy.RecordSites.Add(site.Key,site.Value);
            return copy;
        }
        public void Add(JClass type)=>Classes.Add(type.Name,type);
    }
    public static class JDescriptor
    {
        public static string[] Parameters(string descriptor,out string returns)
        {
            var result=new List<string>();int at=1;
            while(descriptor[at]!=')')result.Add(One(descriptor,ref at));
            at++;returns=One(descriptor,ref at);return result.ToArray();
        }
        private static string One(string descriptor,ref int at)
        {int start=at;while(descriptor[at]=='[')at++;if(descriptor[at]=='L'){at=descriptor.IndexOf(';',at)+1;}else at++;return descriptor.Substring(start,at-start);}
    }
}
