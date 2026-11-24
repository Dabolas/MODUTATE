// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C454{
internal static JClass Build(){var c=new JClass("forge/game/card/CardFactoryUtil$1","forge/game/spellability/Spell",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-1438810964807867610L),null));
c.Add(new JMethod(5036,"forge/game/card/CardFactoryUtil$1","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;)V",0,3,3,new JHandler[]{},M5036));
c.Add(new JMethod(5037,"forge/game/card/CardFactoryUtil$1","resolve","()V",1,4,4,new JHandler[]{},M5037));
c.Add(new JMethod(5038,"forge/game/card/CardFactoryUtil$1","canPlay","()Z",1,4,3,new JHandler[]{},M5038));
}

internal static JStep M5036(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/Spell","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5037(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardFactoryUtil$1","hostCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","isCopiedSpell","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?27:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardFactoryUtil$1","hostCard","Lforge/game/card/Card;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int!=0?27:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardFactoryUtil$1","hostCard","Lforge/game/card/Card;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","setOriginalStateAsFaceDown","()V","invokevirtual",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardFactoryUtil$1","hostCard","Lforge/game/card/Card;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",34);}
case 34:{f.Locals[1]=f.Pop();f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",38);}
case 38:{f.Locals[2]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",44);}
case 44:{f.Locals[3]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardFactoryUtil$1","hostCard","Lforge/game/card/Card;"));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",52);}
case 52:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",55);}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardFactoryUtil$1","hostCard","Lforge/game/card/Card;"));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/GameAction","moveToPlay","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",71);}
case 71:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5038(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardFactoryUtil$1","hostCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardFactoryUtil$1","hostCard","Lforge/game/card/Card;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",19);}
case 19:{f.Locals[1]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardFactoryUtil$1","hostCard","Lforge/game/card/Card;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",27);}
case 27:{f.Locals[2]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardFactoryUtil$1","hostCard","Lforge/game/card/Card;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","turnFaceDownNoUpdate","()Z","invokevirtual",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/Spell","canPlay","()Z","invokespecial",40);}
case 40:{f.Locals[3]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardFactoryUtil$1","hostCard","Lforge/game/card/Card;"));f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",50);}
case 50:{f.StackOp("pop");f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardFactoryUtil$1","hostCard","Lforge/game/card/Card;"));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/card/Card","setFaceDown","(Z)V","invokevirtual",59);}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
