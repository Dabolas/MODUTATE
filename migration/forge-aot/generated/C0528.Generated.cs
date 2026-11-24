// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C528{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostDecisionMakerBase","java/lang/Object",new string[]{"forge/game/cost/ICostVisitor"},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("player","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("ability","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("source","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("effect","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(6277,"forge/game/cost/CostDecisionMakerBase","<init>","(Lforge/game/player/Player;ZLforge/game/spellability/SpellAbility;Lforge/game/card/Card;)V",1,5,2,new JHandler[]{},M6277));
c.Add(new JMethod(6278,"forge/game/cost/CostDecisionMakerBase","getPlayer","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M6278));
c.Add(new JMethod(6279,"forge/game/cost/CostDecisionMakerBase","paysRightAfterDecision","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6280,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z",1,1,1,new JHandler[]{},M6280));
}

internal static JStep M6277(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostDecisionMakerBase","player","Lforge/game/player/Player;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostDecisionMakerBase","effect","Z",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostDecisionMakerBase","ability","Lforge/game/spellability/SpellAbility;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostDecisionMakerBase","source","Lforge/game/card/Card;",value);f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6278(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostDecisionMakerBase","player","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6280(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostDecisionMakerBase","effect","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
