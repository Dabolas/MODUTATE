using System;

namespace Planeswalker.ForgeAot
{
    public readonly struct JRecordField
    {
        public readonly string Owner,Name,Descriptor;
        public JRecordField(string owner,string name,string descriptor){Owner=owner;Name=name;Descriptor=descriptor;}
    }
    public sealed class JRecordSite
    {
        public readonly string Id,Descriptor,ClassName,Operation,ConcatId;
        public readonly JRecordField[] Fields;
        public JRecordSite(string id,string descriptor,string className,string operation,string concatId,JRecordField[] fields)
        {Id=id;Descriptor=descriptor;ClassName=className;Operation=operation;ConcatId=concatId;Fields=fields;}
    }
    internal sealed class JRecordState
    {
        internal readonly JRecordSite Site;
        internal readonly JValue[] Arguments;
        internal int At,Hash;
        internal JRecordState(JRecordSite site,JValue[] arguments){Site=site;Arguments=arguments;At=site.Operation=="equals"?site.Fields.Length-1:0;}
    }
    public sealed partial class JRuntime
    {
        private static readonly JMethod RecordMethod=new JMethod(-4,"aot/record","record","()Ljava/lang/Object;",8,0,8,Array.Empty<JHandler>(),RecordStep);
        private JStep RecordCall(JFrame caller,JRecordSite site,int next)
        {
            var parameters=JDescriptor.Parameters(site.Descriptor,out _);var args=caller.Arguments(parameters.Length);
            NonNull(args[0]);caller.Pc=next;
            if(site.Operation=="toString")
            {
                var values=new JValue[site.Fields.Length];
                for(int i=0;i<values.Length;i++){var field=site.Fields[i];values[i]=GetField(args[0],field.Owner,field.Name,field.Descriptor);}
                frames.Add(new JFrame(ConcatMethod,default,Array.Empty<JValue>()){Concat=new JConcatState(Program.ConcatSites[site.ConcatId],values)});
            }
            else frames.Add(new JFrame(RecordMethod,default,Array.Empty<JValue>()){Record=new JRecordState(site,args)});
            return JStep.Continue;
        }
        private static long CanonicalDouble(JValue value)=>double.IsNaN(value.Double)?unchecked((long)0x7ff8000000000000UL):value.Bits;
        private static int CanonicalFloat(JValue value)=>float.IsNaN(value.Float)?unchecked((int)0x7fc00000):value.Int;
        private static bool RecordPrimitiveEquals(string type,JValue a,JValue b)
        {
            switch(type)
            {
                case "J":return a.Long==b.Long;case "D":return CanonicalDouble(a)==CanonicalDouble(b);case "F":return CanonicalFloat(a)==CanonicalFloat(b);
                default:return a.Int==b.Int;
            }
        }
        private static int RecordPrimitiveHash(string type,JValue value)
        {
            unchecked
            {
                switch(type)
                {
                    case "Z":return value.Int==0?1237:1231;
                    case "J":return (int)((ulong)value.Long^((ulong)value.Long>>32));
                    case "D":long bits=CanonicalDouble(value);return (int)((ulong)bits^((ulong)bits>>32));
                    case "F":return CanonicalFloat(value);default:return value.Int;
                }
            }
        }
        private static JStep RecordStep(JRuntime rt,JFrame f)
        {
            var state=f.Record??throw new PortGap("Missing record continuation");var site=state.Site;
            while(rt.Tick())
            {
                f.LastPc=f.Pc;
                if(f.Pc==2)return rt.Call(f,"java/lang/Object",site.Operation=="equals"?"equals":"hashCode",site.Operation=="equals"?"(Ljava/lang/Object;)Z":"()I","invokevirtual",1);
                if(f.Pc==0&&site.Operation=="equals")
                {
                    if(ReferenceEquals(state.Arguments[0].Reference,state.Arguments[1].Reference))return JStep.Return(JValue.I(1));
                    if(state.Arguments[1].Reference==null||state.Arguments[1].Reference!.ClassName!=site.ClassName)return JStep.Return(JValue.I(0));
                }
                if(f.Pc==1)
                {
                    int value=f.Pop().Int;
                    if(site.Operation=="equals"){if(value==0)return JStep.Return(JValue.I(0));state.At--;}
                    else{state.Hash=unchecked(state.Hash*31+value);state.At++;}
                    f.Pc=0;
                }
                if(site.Operation=="equals"?state.At<0:state.At==site.Fields.Length)return JStep.Return(JValue.I(site.Operation=="equals"?1:state.Hash));
                var field=site.Fields[state.At];var a=rt.GetField(state.Arguments[0],field.Owner,field.Name,field.Descriptor);
                bool reference=field.Descriptor[0]=='L'||field.Descriptor[0]=='[';
                if(site.Operation=="equals")
                {
                    var b=rt.GetField(state.Arguments[1],field.Owner,field.Name,field.Descriptor);
                    if(!reference){if(!RecordPrimitiveEquals(field.Descriptor,a,b))return JStep.Return(JValue.I(0));state.At--;continue;}
                    if(ReferenceEquals(a.Reference,b.Reference)){state.At--;continue;}
                    if(a.Reference==null)return JStep.Return(JValue.I(0));
                    f.Push(a);f.Push(b);f.Pc=2;
                }
                else
                {
                    if(!reference||a.Reference==null)
                    {state.Hash=unchecked(state.Hash*31+(reference?0:RecordPrimitiveHash(field.Descriptor,a)));state.At++;continue;}
                    f.Push(a);f.Pc=2;
                }
                if(f.Pc==2)return rt.Call(f,"java/lang/Object",site.Operation=="equals"?"equals":"hashCode",site.Operation=="equals"?"(Ljava/lang/Object;)Z":"()I","invokevirtual",1);
            }
            return JStep.Yield;
        }
    }
}
