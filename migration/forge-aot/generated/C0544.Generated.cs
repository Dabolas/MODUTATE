// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C544{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostPartWithTrigger","forge/game/cost/CostPartWithList",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("payTrig","Lforge/game/trigger/Trigger;",false,JValue.Default("Lforge/game/trigger/Trigger;"),null));
c.Add(new JMethod(6445,"forge/game/cost/CostPartWithTrigger","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",1,4,4,new JHandler[]{},M6445));
c.Add(new JMethod(6446,"forge/game/cost/CostPartWithTrigger","handleBeforePayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;)V",20,7,5,new JHandler[]{},M6446));
}

internal static JStep M6445(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/CostPartWithList","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6446(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithTrigger","payingTrigSA","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?125:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithTrigger","payingTrigSA","Lforge/game/spellability/SpellAbility;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",19);}
case 19:{f.Locals[5]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[5]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("TriggerDescription")));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithTrigger","payingTrigSA","Lforge/game/spellability/SpellAbility;"));f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",34);}
case 34:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("Mode")));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Immediate","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Immediate","Lforge/game/trigger/TriggerType;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/trigger/TriggerType","name","()Ljava/lang/String;","invokevirtual",50);}
case 50:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithTrigger","payingTrigSA","Lforge/game/spellability/SpellAbility;"));f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",66);}
case 66:{f.Push(JValue.I(0));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",70);}
case 70:{f.Locals[6]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/spellability/SpellAbility","changeText","()V","invokevirtual",77);}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[5]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[4]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[6]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",87);}
case 87:{f.Push(JValue.R(null));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/util/Map;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/trigger/Trigger;","invokestatic",91);}
case 91:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartWithTrigger","payTrig","Lforge/game/trigger/Trigger;",value);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithTrigger","payTrig","Lforge/game/trigger/Trigger;"));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/trigger/Trigger","setSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",102);}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithTrigger","payTrig","Lforge/game/trigger/Trigger;"));f.Pc=106;continue;}
case 106:{f.Push(f.Locals[6]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",111);}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",115);}
case 115:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",118);}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithTrigger","payTrig","Lforge/game/trigger/Trigger;"));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerDelayedTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",125);}
case 125:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
