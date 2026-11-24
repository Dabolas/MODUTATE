// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C566{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostWaterbend","forge/game/cost/CostPartMana",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(6647,"forge/game/cost/CostWaterbend","<init>","(Ljava/lang/String;)V",1,2,4,new JHandler[]{},M6647));
c.Add(new JMethod(6648,"forge/game/cost/CostWaterbend","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M6648));
}

internal static JStep M6647(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Ljava/lang/String;)V","invokespecial",9);}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/cost/CostPartMana","<init>","(Lforge/card/mana/ManaCost;Ljava/lang/String;)V","invokespecial",13);}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostWaterbend","maxWaterbend","Ljava/lang/String;",value);f.Pc=18;continue;}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6648(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostWaterbend","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/mana/ManaCost","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return rt.DynamicCall(f,"forge/game/cost/CostWaterbend:6648:7:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
