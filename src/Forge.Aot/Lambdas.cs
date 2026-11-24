using System;
using System.Collections.Generic;

namespace Planeswalker.ForgeAot
{
    public sealed class JLambdaSite
    {
        public readonly string Id,Descriptor,ClassName,Interface,SamName,SamDescriptor,InstantiatedDescriptor,Owner,Method,ImplementationDescriptor;
        public readonly string[] Markers,Bridges,CaptureTypes;
        public readonly int ReferenceKind;
        public JLambdaSite(string id,string descriptor,string className,string iface,string samName,string samDescriptor,string instantiatedDescriptor,string owner,string method,string implementationDescriptor,int referenceKind,string[] markers,string[] bridges)
        {
            Id=id;Descriptor=descriptor;ClassName=className;Interface=iface;SamName=samName;SamDescriptor=samDescriptor;InstantiatedDescriptor=instantiatedDescriptor;
            Owner=owner;Method=method;ImplementationDescriptor=implementationDescriptor;ReferenceKind=referenceKind;Markers=markers;Bridges=bridges;CaptureTypes=JDescriptor.Parameters(descriptor,out _);
        }
    }
    internal sealed class JLambdaValue
    {
        internal readonly JLambdaSite Site;
        internal readonly JValue[] Captures;
        internal JLambdaValue(JLambdaSite site,JValue[] captures){Site=site;Captures=captures;}
    }
    internal sealed class JLambdaInvocation
    {
        internal readonly JLambdaSite Site;
        internal string Kind="",Owner="",Name="",Descriptor="",ResultType="";
        internal JValue Created;
        internal JLambdaInvocation(JLambdaSite site){Site=site;}
    }
    public sealed partial class JRuntime
    {
        public static JClass LambdaClass(JLambdaSite site)
        {
            var interfaces=new List<string>{site.Interface};interfaces.AddRange(site.Markers);
            var cls=new JClass(site.ClassName,"java/lang/Object",interfaces.ToArray(),0x1010);
            var descriptors=new HashSet<string>(site.Bridges,StringComparer.Ordinal){site.SamDescriptor};
            foreach(string signature in descriptors)
            {
                var parameters=JDescriptor.Parameters(signature,out _);int locals=1;
                foreach(string parameter in parameters)locals+=parameter=="J"||parameter=="D"?2:1;
                cls.Add(new JMethod(-3,site.ClassName,site.SamName,signature,1,locals,32,Array.Empty<JHandler>(),LambdaStep));
            }
            return cls;
        }
        private JStep MakeLambda(JFrame caller,JLambdaSite site,int next)
        {
            if(!EnsureInitialized(caller,site.ClassName))return JStep.Continue;
            var captures=caller.Arguments(site.CaptureTypes.Length);caller.Pc=next;
            caller.Push(JValue.R(new JObject(site.ClassName,++identity){Lambda=new JLambdaValue(site,captures)}));
            return JStep.Continue;
        }
        private JValue AdaptLambda(JValue value,string source,string target)
        {
            if(source==target)return value;
            bool sr=source[0]=='L'||source[0]=='[',tr=target[0]=='L'||target[0]=='[';
            if(sr&&tr)
            {
                if(value.Reference!=null&&!IsInstance(value.Reference,ElementClass(target)))throw Fault("java/lang/ClassCastException");
                return value;
            }
            if(tr&&source=="I")
            {var box=BoxInt(value.Int);if(!IsInstance(box.Reference,ElementClass(target)))throw Fault("java/lang/ClassCastException");return box;}
            if(tr&&source=="Z"){var box=JValue.R(BooleanBox(value.Int!=0));if(!IsInstance(box.Reference,ElementClass(target)))throw Fault("java/lang/ClassCastException");return box;}
            if(tr&&source=="J"){var box=BoxLong(value.Long);if(!IsInstance(box.Reference,ElementClass(target)))throw Fault("java/lang/ClassCastException");return box;}
            if(sr&&target=="J"){if(NonNull(value).ClassName!="java/lang/Long")throw Fault("java/lang/ClassCastException");return NonNull(value).Boxed!.Value;}
            if(sr&&target=="Z"){if(NonNull(value).ClassName!="java/lang/Boolean")throw Fault("java/lang/ClassCastException");return NonNull(value).Boxed!.Value;}
            if(sr&&target=="I")
            {if(NonNull(value).ClassName!="java/lang/Integer")throw Fault("java/lang/ClassCastException");return JValue.I(UnboxInt(value));}
            if(sr||tr)throw new PortGap("Lambda boxing/unboxing adapter is not linked: "+source+" -> "+target);
            // Java erased byte/short/char/boolean values are represented as int on the operand stack.
            if("ZBCSI".IndexOf(source[0])>=0&&"ZBCSI".IndexOf(target[0])>=0)return value;
            string origin="ZBCSI".IndexOf(source[0])>=0?"i":source.ToLowerInvariant();
            string destination="ZBCSI".IndexOf(target[0])>=0?"i":target.ToLowerInvariant();
            return JNumbers.Unary(origin+"2"+destination,value);
        }
        private static JStep LambdaStep(JRuntime rt,JFrame f)
        {
            if(!rt.Tick())return JStep.Yield;f.LastPc=f.Pc;
            var lambda=rt.NonNull(f.Locals[0]).Lambda??throw new PortGap("Lambda receiver has no captures");
            var site=lambda.Site;
            if(f.Pc==2)
            {
                var call=f.LambdaInvocation!;
                return rt.Call(f,call.Owner,call.Name,call.Descriptor,call.Kind,1);
            }
            if(f.Pc==1)
            {
                var call=f.LambdaInvocation!;
                string wanted=f.Method.ReturnType;
                JValue result=site.ReferenceKind==8?call.Created:call.ResultType=="V"?default:f.Pop();
                if(wanted=="V")return JStep.ReturnVoid;
                string actual=site.ReferenceKind==8?"L"+site.Owner+";":call.ResultType;
                if(actual=="V")throw new PortGap("Void lambda result cannot satisfy a value-returning SAM");
                return JStep.Return(JNumbers.Narrow(wanted,rt.AdaptLambda(result,actual,wanted)));
            }
            if(site.ReferenceKind==8&&!rt.EnsureInitialized(f,site.Owner))return JStep.Continue;
            var instanceTypes=JDescriptor.Parameters(site.InstantiatedDescriptor,out _);
            var erased=f.Method.Parameters;
            if(instanceTypes.Length!=erased.Length)throw new PortGap("Lambda SAM bridge arity mismatch");
            var values=new List<JValue>(lambda.Captures);var types=new List<string>(site.CaptureTypes);int local=1;
            for(int i=0;i<erased.Length;i++)
            {
                values.Add(rt.AdaptLambda(f.Locals[local],erased[i],instanceTypes[i]));types.Add(instanceTypes[i]);
                local+=erased[i]=="J"||erased[i]=="D"?2:1;
            }
            var parameters=JDescriptor.Parameters(site.ImplementationDescriptor,out string returns);
            var state=new JLambdaInvocation(site){Owner=site.Owner,Name=site.Method,Descriptor=site.ImplementationDescriptor,ResultType=returns};
            int first=0;
            if(site.ReferenceKind==8)
            {state.Created=JValue.R(rt.Allocate(site.Owner));f.Push(state.Created);state.Kind="invokespecial";}
            else if(site.ReferenceKind==6)state.Kind="invokestatic";
            else if(site.ReferenceKind==5||site.ReferenceKind==7||site.ReferenceKind==9)
            {
                if(values.Count==0)throw new PortGap("Lambda implementation receiver missing");
                f.Push(rt.AdaptLambda(values[0],types[0],"L"+site.Owner+";"));first=1;
                state.Kind=site.ReferenceKind==5?"invokevirtual":site.ReferenceKind==9?"invokeinterface":"invokespecial";
            }
            else throw new PortGap("Unsupported lambda method-handle reference kind");
            if(values.Count-first!=parameters.Length)throw new PortGap("Lambda captured/implementation argument arity mismatch");
            for(int i=0;i<parameters.Length;i++)f.Push(rt.AdaptLambda(values[i+first],types[i+first],parameters[i]));
            f.LambdaInvocation=state;f.Pc=2;return JStep.Continue;
        }
    }
}
