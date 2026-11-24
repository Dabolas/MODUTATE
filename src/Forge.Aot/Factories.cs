using System;

namespace Planeswalker.ForgeAot
{
    public sealed class JRuleFactory
    {
        public readonly string Category,Name,ClassName,Constructor;
        public JRuleFactory(string category,string name,string className,string constructor){Category=category;Name=name;ClassName=className;Constructor=constructor;}
    }
    public sealed partial class JRuntime
    {
        private JObject? trueBox,falseBox;
        private void InstallFactories()
        {
            Bind("forge/game/trigger/TriggerType","findConstructor","(Ljava/lang/Class;)Ljava/lang/reflect/Constructor;",(r,s,a)=>JHostResult.Complete(JValue.R(r.Constructor(r.ClassName(a[0])))));
            Bind("java/lang/Class","getDeclaredConstructors","()[Ljava/lang/reflect/Constructor;",(r,s,a)=>
            {var result=r.NewArray("Ljava/lang/reflect/Constructor;",1);result.Items[0]=JValue.R(r.Constructor(r.ClassName(s)));return JHostResult.Complete(JValue.R(result));});
            Bind("java/lang/Class","getConstructor","([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;",(r,s,a)=>
            {
                var constructor=r.Constructor(r.ClassName(s));var supplied=r.ArrayObject(a[0]);
                var parameters=JDescriptor.Parameters(constructor.Factory!.Constructor,out _);
                if(supplied.Items.Length!=parameters.Length)throw new PortGap("Constructor parameter contract mismatch");
                for(int i=0;i<parameters.Length;i++)if(r.ClassName(supplied.Items[i])!=ElementClass(parameters[i]))throw new PortGap("Constructor parameter class mismatch");
                return JHostResult.Complete(JValue.R(constructor));
            });
            Bind("java/lang/reflect/Constructor","getParameterTypes","()[Ljava/lang/Class;",(r,s,a)=>
            {
                var parameters=JDescriptor.Parameters(r.NonNull(s).Factory!.Constructor,out _);var result=r.NewArray("Ljava/lang/Class;",parameters.Length);
                for(int i=0;i<parameters.Length;i++)result.Items[i]=JValue.R(r.ClassObject(ElementClass(parameters[i])));
                return JHostResult.Complete(JValue.R(result));
            });
            Bind("java/lang/Class","isAssignableFrom","(Ljava/lang/Class;)Z",(r,s,a)=>JHostResult.Complete(JValue.I(r.Assignable(r.ClassName(a[0]),r.ClassName(s),new System.Collections.Generic.HashSet<string>(StringComparer.Ordinal))?1:0)));
            Bind("java/lang/Class","isInstance","(Ljava/lang/Object;)Z",(r,s,a)=>JHostResult.Complete(JValue.I(r.IsInstance(a[0].Reference,r.ClassName(s))?1:0)));
            Bind("java/lang/Class","cast","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{if(a[0].Reference!=null&&!r.IsInstance(a[0].Reference,r.ClassName(s)))throw r.Fault("java/lang/ClassCastException");return JHostResult.Complete(a[0]);});
            Bind("java/lang/Class","getName","()Ljava/lang/String;",(r,s,a)=>JHostResult.Complete(JValue.R(r.String(r.ClassName(s).Replace('/','.')))));
            Bind("java/lang/reflect/Constructor","newInstance","([Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>r.ScheduleConstructor(r.NonNull(s),a[0]));
            Bind("forge/util/ReflectionUtil","makeDefaultInstanceOf","(Ljava/lang/Class;)Ljava/lang/Object;",(r,s,a)=>r.ScheduleConstructor(r.Constructor(r.ClassName(a[0])),JValue.R(r.NewArray("Ljava/lang/Object;",0))));
            Bind("java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;",(r,s,a)=>JHostResult.Complete(JValue.R(r.BooleanBox(a[0].Int!=0))));
            Bind("java/lang/Boolean","booleanValue","()Z",(r,s,a)=>JHostResult.Complete(r.NonNull(s).Boxed??throw new PortGap("Boolean is not boxed")));
        }
        private JObject BooleanBox(bool value)
        {
            if(value)return trueBox??(trueBox=new JObject("java/lang/Boolean",++identity){Boxed=JValue.I(1),HostStorage=true});
            return falseBox??(falseBox=new JObject("java/lang/Boolean",++identity){Boxed=JValue.I(0),HostStorage=true});
        }
        private string ClassName(JValue value)=>NonNull(value).RepresentedClass??throw new PortGap("A closed-world Java Class reference is required");
        private JObject Constructor(string className)
        {
            JRuleFactory? match=null;
            foreach(var factory in Program.Factories)
                if(factory.ClassName==className)
                {
                    if(match!=null&&match.Constructor!=factory.Constructor)throw new PortGap("Ambiguous closed constructor: "+className);
                    match=factory;
                }
            if(match==null&&Program.Classes.TryGetValue(className,out var cls)&&cls.Methods.TryGetValue("<init>()V",out var defaultConstructor)&&(defaultConstructor.Access&1)!=0&&defaultConstructor.Body!=null)
                match=new JRuleFactory("generated-public-constructor",className,className,"()V");
            if(match==null)throw new PortGap("No catalogued or public generated default constructor: "+className);
            if(!Class(className).Methods.ContainsKey("<init>"+match.Constructor))throw new PortGap("Generated factory has no constructor body: "+className);
            return new JObject("java/lang/reflect/Constructor",++identity){Factory=match,HostStorage=true};
        }
        private JHostResult ScheduleConstructor(JObject constructor,JValue arguments)
        {
            if(constructor.Factory==null)throw new PortGap("Closed constructor reference expected");
            var method=new JMethod(-1,"aot/constructor","construct","(Ljava/lang/reflect/Constructor;[Ljava/lang/Object;)Ljava/lang/Object;",8,3,16,Array.Empty<JHandler>(),ConstructStep);
            return JHostResult.Schedule(new JFrame(method,default,new[]{JValue.R(constructor),arguments}){ReflectiveConstructor=true});
        }
        private static JStep ConstructStep(JRuntime rt,JFrame f)
        {
            if(!rt.Tick())return JStep.Yield;
            f.LastPc=f.Pc;
            if(f.Pc==1)return JStep.Return(f.Locals[2]);
            var factory=rt.NonNull(f.Locals[0]).Factory!;
            if(!rt.EnsureInitialized(f,factory.ClassName))return JStep.Continue;
            var parameters=JDescriptor.Parameters(factory.Constructor,out _);var args=rt.ArrayObject(f.Locals[1]);
            if(args.Items.Length!=parameters.Length)throw new PortGap("Rule constructor argument count mismatch");
            var value=JValue.R(rt.Allocate(factory.ClassName));f.Locals[2]=value;f.Push(value);
            for(int i=0;i<parameters.Length;i++)
            {
                var arg=args.Items[i];
                if(parameters[i]=="Z")arg=rt.NonNull(arg).Boxed??throw new PortGap("Constructor boolean boxing mismatch");
                else if(arg.Reference!=null&&!rt.IsInstance(arg.Reference,ElementClass(parameters[i])))throw new PortGap("Constructor reference type mismatch");
                f.Push(arg);
            }
            return rt.Call(f,factory.ClassName,"<init>",factory.Constructor,"invokespecial",1);
        }
    }
}
