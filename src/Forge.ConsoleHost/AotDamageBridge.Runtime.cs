using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeConsole;
public sealed partial class AotDamageBridge
{
    private static JMethod Find(JProgram program,string owner,string name,string descriptor)
    {
        for(string type=owner;type.Length!=0;)
        {if(!program.Classes.TryGetValue(type,out var cls))break;if(cls.Methods.TryGetValue(name+descriptor,out var method))return method;type=cls.Super;}
        throw new PortGap("Method not generated: "+owner+"."+name+descriptor);
    }
    public static JValue Run(JRuntime rt,JMethod method,JValue receiver,JValue[] args,int limit=2000000)
    {
        rt.Start(method,receiver,args);
        for(int work=0;work<limit;work+=10000)
        {var state=rt.Run(10000);if(state==JRunState.Completed)return rt.Result;if(state==JRunState.Waiting)throw new PortGap("Unexpected unhandled host decision: "+rt.Pending?.Method);}
        throw new TimeoutException("Instruction budget exceeded in "+method.Key);
    }
    public static JValue Construct(JRuntime rt,string type)
        =>Construct(rt,type,"()V",Array.Empty<JValue>());
    public static JValue Construct(JRuntime rt,string type,string descriptor,JValue[] arguments)
    {
        var constructor=Find(rt.Program,type,"<init>",descriptor);
        var entry=new JMethod(-50,type,"<console-new>","()Ljava/lang/Object;",8,1,arguments.Length+4,Array.Empty<JHandler>(),(r,f)=>
        {
            if(!r.Tick())return JStep.Yield;
            if(f.Pc==1)return JStep.Return(f.Locals[0]);
            if(f.Pc==0){f.Locals[0]=JValue.R(r.Allocate(type));f.Push(f.Locals[0]);foreach(var arg in arguments)f.Push(arg);f.Pc=2;}
            return r.Call(f,type,"<init>",descriptor,"invokespecial",1);
        });
        return Run(rt,entry,default,Array.Empty<JValue>());
    }
}
