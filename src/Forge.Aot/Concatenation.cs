using System;
using System.Globalization;
using System.Text;

namespace Planeswalker.ForgeAot
{
    public readonly struct JConcatConstant
    {
        public readonly string? Text;
        public readonly JValue Value;
        public readonly string Type;
        public JConcatConstant(string text){Text=text;Value=default;Type="Ljava/lang/String;";}
        public JConcatConstant(JValue value,string type){Text=null;Value=value;Type=type;}
    }
    public sealed class JConcatSite
    {
        public readonly string Id,Descriptor,Recipe;
        public readonly string[] Parameters;
        public readonly JConcatConstant[] Constants;
        public JConcatSite(string id,string descriptor,string recipe,JConcatConstant[] constants)
        {Id=id;Descriptor=descriptor;Recipe=recipe;Constants=constants;Parameters=JDescriptor.Parameters(descriptor,out _);}
    }
    internal sealed class JConcatState
    {
        internal readonly JConcatSite Site;
        internal readonly JValue[] Arguments;
        internal readonly StringBuilder Text=new StringBuilder();
        internal int At,Argument,Constant;
        internal string PendingOwner="",PendingName="",PendingDescriptor="",PendingKind="";
        internal JConcatState(JConcatSite site,JValue[] arguments){Site=site;Arguments=arguments;}
    }
    public sealed partial class JRuntime
    {
        private JObject NewString(string text)=>new JObject("java/lang/String",++identity){Text=text,HostStorage=true};
        private static readonly JMethod ConcatMethod=new JMethod(-2,"aot/concat","concat","()Ljava/lang/String;",8,0,8,Array.Empty<JHandler>(),ConcatStep);
        public JStep DynamicCall(JFrame caller,string site,string descriptor,int next)
        {
            if(Program.LambdaSites.TryGetValue(site,out var lambda))
            {if(lambda.Descriptor!=descriptor)throw new PortGap("Lambda descriptor mismatch");return MakeLambda(caller,lambda,next);}
            if(Program.RecordSites.TryGetValue(site,out var record))
            {if(record.Descriptor!=descriptor)throw new PortGap("Record descriptor mismatch");return RecordCall(caller,record,next);}
            if(!Program.ConcatSites.TryGetValue(site,out var plan))throw new PortGap("Unlinked invokedynamic bootstrap: "+site+descriptor);
            if(plan.Descriptor!=descriptor)throw new PortGap("Concat descriptor mismatch");
            var values=caller.Arguments(plan.Parameters.Length);caller.Pc=next;
            frames.Add(new JFrame(ConcatMethod,default,Array.Empty<JValue>()){Concat=new JConcatState(plan,values)});
            return JStep.Continue;
        }
        private static JStep ConcatStep(JRuntime rt,JFrame frame)
        {
            var state=frame.Concat??throw new PortGap("Missing concat continuation");
            while(rt.Tick())
            {
                frame.LastPc=frame.Pc;
                if(frame.Pc==2)return rt.Call(frame,state.PendingOwner,state.PendingName,state.PendingDescriptor,state.PendingKind,1);
                if(frame.Pc==1)
                {
                    var value=frame.Pop();state.Text.Append(value.Reference==null?"null":rt.Text(value));frame.Pc=0;
                }
                if(state.At==state.Site.Recipe.Length)
                {
                    if(state.Argument!=state.Arguments.Length||state.Constant!=state.Site.Constants.Length)throw new PortGap("Concat recipe/arguments disagree");
                    return JStep.Return(JValue.R(rt.NewString(state.Text.ToString())));
                }
                char part=state.Site.Recipe[state.At++];
                if(part!='\u0001'&&part!='\u0002'){state.Text.Append(part);continue;}
                JValue argument;string type;
                if(part=='\u0001')
                {int at=state.Argument++;argument=state.Arguments[at];type=state.Site.Parameters[at];}
                else
                {
                    var constant=state.Site.Constants[state.Constant++];
                    if(constant.Text!=null){state.Text.Append(constant.Text);continue;}
                    argument=constant.Value;type=constant.Type;
                }
                switch(type)
                {
                    case "Z":state.Text.Append(argument.Int==0?"false":"true");break;
                    case "C":state.Text.Append(unchecked((char)argument.Int));break;
                    case "B":case "S":case "I":state.Text.Append(argument.Int.ToString(CultureInfo.InvariantCulture));break;
                    case "J":state.Text.Append(argument.Long.ToString(CultureInfo.InvariantCulture));break;
                    case "F":case "D":
                        frame.Push(argument);state.PendingOwner=type=="F"?"java/lang/Float":"java/lang/Double";
                        state.PendingName="toString";state.PendingDescriptor="("+type+")Ljava/lang/String;";state.PendingKind="invokestatic";frame.Pc=2;break;
                    default:
                        if(argument.Reference==null){state.Text.Append("null");break;}
                        if(argument.Reference.ClassName=="java/lang/String"){state.Text.Append(rt.Text(argument));break;}
                        frame.Push(argument);state.PendingOwner="java/lang/Object";state.PendingName="toString";state.PendingDescriptor="()Ljava/lang/String;";state.PendingKind="invokevirtual";frame.Pc=2;break;
                }
            }
            return JStep.Yield;
        }
    }
}
