// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C224{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChangeTextEffect$1","java/lang/Object",new string[]{"forge/GameCommand"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-7802388880114360593L),null));
c.Add(new JField("val$changedColorWordNew","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("val$c","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("val$timestamp","Ljava/lang/Long;",false,JValue.Default("Ljava/lang/Long;"),null));
c.Add(new JField("val$changedTypeWordNew","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("this$0","Lforge/game/ability/effects/ChangeTextEffect;",false,JValue.Default("Lforge/game/ability/effects/ChangeTextEffect;"),null));
c.Add(new JMethod(3093,"forge/game/ability/effects/ChangeTextEffect$1","<init>","(Lforge/game/ability/effects/ChangeTextEffect;Ljava/lang/String;Lforge/game/card/Card;Ljava/lang/Long;Ljava/lang/String;)V",0,6,2,new JHandler[]{},M3093));
c.Add(new JMethod(3094,"forge/game/ability/effects/ChangeTextEffect$1","run","()V",1,1,4,new JHandler[]{},M3094));
}

internal static JStep M3093(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ChangeTextEffect$1","this$0","Lforge/game/ability/effects/ChangeTextEffect;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ChangeTextEffect$1","val$changedColorWordNew","Ljava/lang/String;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ChangeTextEffect$1","val$c","Lforge/game/card/Card;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ChangeTextEffect$1","val$timestamp","Ljava/lang/Long;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[5]);f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ChangeTextEffect$1","val$changedTypeWordNew","Ljava/lang/String;",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",31);}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3094(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ChangeTextEffect$1","val$changedColorWordNew","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?19:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ChangeTextEffect$1","val$c","Lforge/game/card/Card;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ChangeTextEffect$1","val$timestamp","Ljava/lang/Long;"));f.Pc=15;continue;}
case 15:{f.Push(JValue.L(0));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/Card","removeChangedTextColorWord","(Ljava/lang/Long;J)V","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ChangeTextEffect$1","val$changedTypeWordNew","Ljava/lang/String;"));f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Reference==null?38:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ChangeTextEffect$1","val$c","Lforge/game/card/Card;"));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ChangeTextEffect$1","val$timestamp","Ljava/lang/Long;"));f.Pc=34;continue;}
case 34:{f.Push(JValue.L(0));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/Card","removeChangedTextTypeWord","(Ljava/lang/Long;J)V","invokevirtual",38);}
case 38:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
