// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1166{
internal static JClass Build(){var c=new JClass("forge/util/Visitor","java/lang/Object",new string[]{},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(12097,"forge/util/Visitor","visit","(Ljava/lang/Object;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(12098,"forge/util/Visitor","visitAll","(Ljava/lang/Iterable;)Z",1,4,3,new JHandler[]{},M12098));
}

internal static JStep M12098(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/util/collect/FCollection")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?50:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",21);}
case 21:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?48:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",32);}
case 32:{return rt.Call(f,"forge/util/Visitor","visit","(Ljava/lang/Object;)Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int!=0?42:40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 42:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=45;continue;}
case 45:{f.Pc=14;continue;}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",56);}
case 56:{f.Locals[2]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",63);}
case 63:{f.Pc=f.Pop().Int==0?88:66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",72);}
case 72:{f.Locals[3]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/util/Visitor","visit","(Ljava/lang/Object;)Z","invokeinterface",80);}
case 80:{f.Pc=f.Pop().Int!=0?85:83;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 85:{f.Pc=57;continue;}
case 88:{f.Push(JValue.I(1));f.Pc=89;continue;}
case 89:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
