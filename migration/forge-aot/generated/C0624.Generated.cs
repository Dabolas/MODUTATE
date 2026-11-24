// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C624{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventSpellAbilityCast","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("sa","Lforge/game/spellability/SpellAbilityView;",false,JValue.Default("Lforge/game/spellability/SpellAbilityView;"),null));
c.Add(new JField("si","Lforge/game/spellability/StackItemView;",false,JValue.Default("Lforge/game/spellability/StackItemView;"),null));
c.Add(new JField("stackIndex","I",false,JValue.Default("I"),null));
c.Add(new JField("targetDescription","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(7167,"forge/game/event/GameEventSpellAbilityCast","<init>","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbilityStackInstance;I)V",1,4,5,new JHandler[]{},M7167));
c.Add(new JMethod(7168,"forge/game/event/GameEventSpellAbilityCast","<init>","(Lforge/game/spellability/SpellAbilityView;Lforge/game/spellability/StackItemView;ILjava/lang/String;)V",1,5,2,new JHandler[]{},M7168));
c.Add(new JMethod(7169,"forge/game/event/GameEventSpellAbilityCast","computeTargetDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",10,4,2,new JHandler[]{},M7169));
c.Add(new JMethod(7170,"forge/game/event/GameEventSpellAbilityCast","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M7170));
c.Add(new JMethod(7171,"forge/game/event/GameEventSpellAbilityCast","toString","()Ljava/lang/String;",1,1,3,new JHandler[]{},M7171));
c.Add(new JMethod(7172,"forge/game/event/GameEventSpellAbilityCast","hashCode","()I",17,1,1,new JHandler[]{},M7172));
c.Add(new JMethod(7173,"forge/game/event/GameEventSpellAbilityCast","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M7173));
c.Add(new JMethod(7174,"forge/game/event/GameEventSpellAbilityCast","sa","()Lforge/game/spellability/SpellAbilityView;",1,1,1,new JHandler[]{},M7174));
c.Add(new JMethod(7175,"forge/game/event/GameEventSpellAbilityCast","si","()Lforge/game/spellability/StackItemView;",1,1,1,new JHandler[]{},M7175));
c.Add(new JMethod(7176,"forge/game/event/GameEventSpellAbilityCast","stackIndex","()I",1,1,1,new JHandler[]{},M7176));
c.Add(new JMethod(7177,"forge/game/event/GameEventSpellAbilityCast","targetDescription","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7177));
}

internal static JStep M7167(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","get","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityView;","invokestatic",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/StackItemView","get","(Lforge/game/spellability/SpellAbilityStackInstance;)Lforge/game/spellability/StackItemView;","invokestatic",9);}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/event/GameEventSpellAbilityCast","computeTargetDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokestatic",14);}
case 14:{return rt.Call(f,"forge/game/event/GameEventSpellAbilityCast","<init>","(Lforge/game/spellability/SpellAbilityView;Lforge/game/spellability/StackItemView;ILjava/lang/String;)V","invokespecial",17);}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7168(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventSpellAbilityCast","sa","Lforge/game/spellability/SpellAbilityView;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventSpellAbilityCast","si","Lforge/game/spellability/StackItemView;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventSpellAbilityCast","stackIndex","I",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventSpellAbilityCast","targetDescription","Ljava/lang/String;",value);f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7169(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",16);}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAllTargetChoices","()Ljava/util/List;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?73:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/TargetChoices"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Pc=f.Pop().Reference==null?70:50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int<=0?64:57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String(" ")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Pc=27;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int!=0?84:80;continue;}
case 80:{f.Push(JValue.R(null));f.Pc=81;continue;}
case 81:{f.Pc=88;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",88);}
case 88:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7170(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventSpellAbilityCast;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7171(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSpellAbilityCast","si","Lforge/game/spellability/StackItemView;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/StackItemView","getActivatingPlayer","()Lforge/game/player/PlayerView;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSpellAbilityCast","sa","Lforge/game/spellability/SpellAbilityView;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","isSpell","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?25:20;continue;}
case 20:{f.Push(JValue.R(rt.String(" cast ")));f.Pc=22;continue;}
case 22:{f.Pc=42;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSpellAbilityCast","si","Lforge/game/spellability/StackItemView;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/StackItemView","isTrigger","()Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?40:35;continue;}
case 35:{f.Push(JValue.R(rt.String(" triggered ")));f.Pc=37;continue;}
case 37:{f.Pc=42;continue;}
case 40:{f.Push(JValue.R(rt.String(" activated ")));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSpellAbilityCast","sa","Lforge/game/spellability/SpellAbilityView;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",49);}
case 49:{return rt.DynamicCall(f,"forge/game/event/GameEventSpellAbilityCast:7171:49:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",54);}
case 54:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7172(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventSpellAbilityCast:7172:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventSpellAbilityCast;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7173(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventSpellAbilityCast:7173:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventSpellAbilityCast;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7174(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSpellAbilityCast","sa","Lforge/game/spellability/SpellAbilityView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7175(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSpellAbilityCast","si","Lforge/game/spellability/StackItemView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7176(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSpellAbilityCast","stackIndex","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7177(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSpellAbilityCast","targetDescription","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
