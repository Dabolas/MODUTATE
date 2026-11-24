// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C779{
internal static JClass Build(){var c=new JClass("forge/game/replacement/ReplacementEffect","forge/game/TriggerReplacementBase",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("maxId","I",true,JValue.Default("I"),null));
c.Add(new JField("id","I",false,JValue.Default("I"),null));
c.Add(new JField("mode","Lforge/game/replacement/ReplacementType;",false,JValue.Default("Lforge/game/replacement/ReplacementType;"),null));
c.Add(new JField("layer","Lforge/game/replacement/ReplacementLayer;",false,JValue.Default("Lforge/game/replacement/ReplacementLayer;"),null));
c.Add(new JField("hasRun","Z",false,JValue.Default("Z"),null));
c.Add(new JField("otherChoices","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("view","Lforge/game/replacement/ReplacementEffectView;",false,JValue.Default("Lforge/game/replacement/ReplacementEffectView;"),null));
c.Add(new JField("CLASS_HASH","I",true,JValue.Default("I"),null));
c.Add(new JMethod(8991,"forge/game/replacement/ReplacementEffect","nextId","()I",10,0,2,new JHandler[]{},M8991));
c.Add(new JMethod(8992,"forge/game/replacement/ReplacementEffect","getId","()I",1,1,1,new JHandler[]{},M8992));
c.Add(new JMethod(8993,"forge/game/replacement/ReplacementEffect","setId","(I)V",17,2,2,new JHandler[]{},M8993));
c.Add(new JMethod(8994,"forge/game/replacement/ReplacementEffect","hasRun","()Z",17,1,1,new JHandler[]{},M8994));
c.Add(new JMethod(8995,"forge/game/replacement/ReplacementEffect","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,3,new JHandler[]{},M8995));
c.Add(new JMethod(8996,"forge/game/replacement/ReplacementEffect","getView","()Lforge/game/replacement/ReplacementEffectView;",1,1,4,new JHandler[]{},M8996));
c.Add(new JMethod(8997,"forge/game/replacement/ReplacementEffect","setHasRun","(Z)V",17,2,2,new JHandler[]{},M8997));
c.Add(new JMethod(8998,"forge/game/replacement/ReplacementEffect","getOtherChoices","()Ljava/util/List;",1,1,1,new JHandler[]{},M8998));
c.Add(new JMethod(8999,"forge/game/replacement/ReplacementEffect","setOtherChoices","(Ljava/util/List;)V",1,2,2,new JHandler[]{},M8999));
c.Add(new JMethod(9000,"forge/game/replacement/ReplacementEffect","canReplace","(Ljava/util/Map;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(9001,"forge/game/replacement/ReplacementEffect","requirementsCheck","(Lforge/game/Game;)Z",1,3,3,new JHandler[]{},M9001));
c.Add(new JMethod(9002,"forge/game/replacement/ReplacementEffect","copy","(Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;",17,3,4,new JHandler[]{},M9002));
c.Add(new JMethod(9003,"forge/game/replacement/ReplacementEffect","copy","(Lforge/game/card/Card;ZZ)Lforge/game/replacement/ReplacementEffect;",17,7,4,new JHandler[]{},M9003));
c.Add(new JMethod(9004,"forge/game/replacement/ReplacementEffect","setReplacingObjects","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)V",1,3,0,new JHandler[]{},M9004));
c.Add(new JMethod(9005,"forge/game/replacement/ReplacementEffect","getLayer","()Lforge/game/replacement/ReplacementLayer;",1,1,1,new JHandler[]{},M9005));
c.Add(new JMethod(9006,"forge/game/replacement/ReplacementEffect","setLayer","(Lforge/game/replacement/ReplacementLayer;)V",1,2,2,new JHandler[]{},M9006));
c.Add(new JMethod(9007,"forge/game/replacement/ReplacementEffect","getDescription","()Ljava/lang/String;",1,6,4,new JHandler[]{},M9007));
c.Add(new JMethod(9008,"forge/game/replacement/ReplacementEffect","toString","()Ljava/lang/String;",1,1,2,new JHandler[]{},M9008));
c.Add(new JMethod(9009,"forge/game/replacement/ReplacementEffect","clone","()Ljava/lang/Object;",17,2,3,new JHandler[]{new JHandler(0,4,5,"java/lang/Exception")},M9009));
c.Add(new JMethod(9010,"forge/game/replacement/ReplacementEffect","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M9010));
c.Add(new JMethod(9011,"forge/game/replacement/ReplacementEffect","hashCode","()I",1,1,3,new JHandler[]{},M9011));
c.Add(new JMethod(9012,"forge/game/replacement/ReplacementEffect","getMode","()Lforge/game/replacement/ReplacementType;",1,1,1,new JHandler[]{},M9012));
c.Add(new JMethod(9013,"forge/game/replacement/ReplacementEffect","setMode","(Lforge/game/replacement/ReplacementType;)V",0,2,2,new JHandler[]{},M9013));
c.Add(new JMethod(9014,"forge/game/replacement/ReplacementEffect","ensureAbility","()Lforge/game/spellability/SpellAbility;",1,2,3,new JHandler[]{},M9014));
c.Add(new JMethod(9015,"forge/game/replacement/ReplacementEffect","canReplaceETB","(Ljava/util/Map;)Z",4,3,3,new JHandler[]{},M9015));
c.Add(new JMethod(9016,"forge/game/replacement/ReplacementEffect","modeCheck","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Z",1,3,2,new JHandler[]{},M9016));
c.Add(new JMethod(9017,"forge/game/replacement/ReplacementEffect","<clinit>","()V",8,0,1,new JHandler[]{},M9017));
}

internal static JStep M8991(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementEffect","maxId","I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementEffect","maxId","I"));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementEffect","maxId","I"))return JStep.Continue;rt.PutStatic("forge/game/replacement/ReplacementEffect","maxId","I",f.Pop());f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8992(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementEffect","id","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8993(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementEffect","id","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8994(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementEffect","hasRun","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8995(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/TriggerReplacementBase","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementEffect","layer","Lforge/game/replacement/ReplacementLayer;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementEffect","hasRun","Z",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(null));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementEffect","otherChoices","Ljava/util/List;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(null));f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementEffect","view","Lforge/game/replacement/ReplacementEffectView;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","nextId","()I","invokestatic",30);}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementEffect","id","I",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementEffect","intrinsic","Z",value);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementEffect","originalMapParams","Ljava/util/Map;"));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",48);}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementEffect","mapParams","Ljava/util/Map;"));f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",58);}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",63);}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("Layer")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",71);}
case 71:{f.Pc=f.Pop().Int==0?92:74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("Layer")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",83);}
case 83:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/replacement/ReplacementLayer","smartValueOf","(Ljava/lang/String;)Lforge/game/replacement/ReplacementLayer;","invokestatic",89);}
case 89:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setLayer","(Lforge/game/replacement/ReplacementLayer;)V","invokevirtual",92);}
case 92:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8996(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementEffect","view","Lforge/game/replacement/ReplacementEffectView;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?22:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/game/replacement/ReplacementEffectView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/replacement/ReplacementEffectView")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/replacement/ReplacementEffectView","<init>","(Lforge/game/replacement/ReplacementEffect;)V","invokespecial",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementEffect","view","Lforge/game/replacement/ReplacementEffectView;",value);f.Pc=19;continue;}
case 19:{f.Pc=38;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementEffect","view","Lforge/game/replacement/ReplacementEffectView;"));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/replacement/ReplacementEffectView","updateHostCard","(Lforge/game/replacement/ReplacementEffect;)V","invokevirtual",30);}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementEffect","view","Lforge/game/replacement/ReplacementEffectView;"));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/replacement/ReplacementEffectView","updateDescription","(Lforge/game/replacement/ReplacementEffect;)V","invokevirtual",38);}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementEffect","view","Lforge/game/replacement/ReplacementEffectView;"));f.Pc=42;continue;}
case 42:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8997(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementEffect","hasRun","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8998(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementEffect","otherChoices","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8999(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementEffect","otherChoices","Ljava/util/List;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9001(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","isSuppressed","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("PlayerTurn")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?84:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("PlayerTurn")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Push(JValue.R(rt.String("True")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?51:32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getHostCard","()Lforge/game/card/Card;","invokevirtual",40);}
case 40:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int!=0?84:49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getHostCard","()Lforge/game/card/Card;","invokevirtual",55);}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("PlayerTurn")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",61);}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",65);}
case 65:{f.Locals[2]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",71);}
case 71:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",74);}
case 74:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",79);}
case 79:{f.Pc=f.Pop().Int!=0?84:82;continue;}
case 82:{f.Push(JValue.I(0));f.Pc=83;continue;}
case 83:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("ActivePhases")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?119:93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("ActivePhases")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",99);}
case 99:{return rt.Call(f,"forge/game/phase/PhaseType","parseRange","(Ljava/lang/String;)Ljava/util/Set;","invokestatic",102);}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",106);}
case 106:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPhase","()Lforge/game/phase/PhaseType;","invokevirtual",109);}
case 109:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",114);}
case 114:{f.Pc=f.Pop().Int!=0?119:117;continue;}
case 117:{f.Push(JValue.I(0));f.Pc=118;continue;}
case 118:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getMapParams","()Ljava/util/Map;","invokevirtual",124);}
case 124:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","meetsCommonRequirements","(Ljava/util/Map;)Z","invokevirtual",127);}
case 127:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9002(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","copy","(Lforge/game/card/Card;ZZ)Lforge/game/replacement/ReplacementEffect;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9003(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","clone","()Ljava/lang/Object;","invokevirtual",4);}
case 4:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7;continue;}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Int!=0?21:17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Int==0?25:21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Pc=26;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","copyHelper","(Lforge/game/CardTraitBase;Lforge/game/card/Card;Z)V","invokevirtual",29);}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",33);}
case 33:{f.Locals[5]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{f.Pc=f.Pop().Reference==null?61:40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",47);}
case 47:{f.Locals[6]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[6]);f.Pc=51;continue;}
case 51:{f.Pc=f.Pop().Reference==null?61:54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[6]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",61);}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{f.Pc=f.Pop().Int!=0?85:65;continue;}
case 65:{f.Push(f.Locals[4]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","nextId","()I","invokestatic",70);}
case 70:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setId","(I)V","invokevirtual",73);}
case 73:{f.Push(f.Locals[4]);f.Pc=75;continue;}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setHasRun","(Z)V","invokevirtual",79);}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{f.Push(JValue.R(null));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOtherChoices","(Ljava/util/List;)V","invokevirtual",85);}
case 85:{f.Push(f.Locals[4]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementEffect","validHostZones","Ljava/util/EnumSet;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setActiveZone","(Ljava/util/EnumSet;)V","invokevirtual",94);}
case 94:{f.Push(f.Locals[4]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getLayer","()Lforge/game/replacement/ReplacementLayer;","invokevirtual",100);}
case 100:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setLayer","(Lforge/game/replacement/ReplacementLayer;)V","invokevirtual",103);}
case 103:{f.Push(f.Locals[4]);f.Pc=105;continue;}
case 105:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9004(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9005(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementEffect","layer","Lforge/game/replacement/ReplacementLayer;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9006(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementEffect","layer","Lforge/game/replacement/ReplacementLayer;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9007(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Description")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?285:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","isSuppressed","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int!=0?285:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Description")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/ability/AbilityUtils","applyDescriptionTextChangeEffects","(Ljava/lang/String;Lforge/game/CardTraitBase;)Ljava/lang/String;","invokestatic",26);}
case 26:{f.Locals[1]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getHostName","(Lforge/game/CardTraitBase;)Lforge/util/ITranslatable;","invokevirtual",32);}
case 32:{f.Locals[2]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/util/CardTranslation","translateMultipleDescriptionText","(Ljava/lang/String;Lforge/util/ITranslatable;)Ljava/lang/String;","invokestatic",38);}
case 38:{f.Locals[1]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/util/ITranslatable","getTranslatedName","()Ljava/lang/String;","invokeinterface",45);}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",53);}
case 53:{f.Locals[1]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("NICKNAME")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",60);}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/util/Lang","getNickName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",64);}
case 64:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",67);}
case 67:{f.Locals[1]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("EFFECTSOURCE")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",75);}
case 75:{f.Pc=f.Pop().Int==0?96:78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("EFFECTSOURCE")));f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getHostCard","()Lforge/game/card/Card;","invokevirtual",86);}
case 86:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",89);}
case 89:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",92);}
case 92:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",95);}
case 95:{f.Locals[1]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementEffect","mode","Lforge/game/replacement/ReplacementType;"));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","DamageDone","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","DamageDone","Lforge/game/replacement/ReplacementType;"));f.Pc=103;continue;}
case 103:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?283:106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",110);}
case 110:{f.Locals[4]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[4]);f.Pc=114;continue;}
case 114:{f.Pc=f.Pop().Reference==null?191:117;continue;}
case 117:{f.Push(f.Locals[4]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",122);}
case 122:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"));f.Pc=125;continue;}
case 125:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?191:128;continue;}
case 128:{f.Push(f.Locals[4]);f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("Amount")));f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",136);}
case 136:{f.Pc=f.Pop().Int==0?191:139;continue;}
case 139:{f.Push(f.Locals[4]);f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String("Amount")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",147);}
case 147:{f.Locals[5]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[5]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",154);}
case 154:{f.Pc=f.Pop().Int!=0?191:157;continue;}
case 157:{f.Push(f.Locals[4]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[5]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",164);}
case 164:{f.Locals[5]=f.Pop();f.Pc=166;continue;}
case 166:{f.Push(f.Locals[5]);f.Pc=168;continue;}
case 168:{f.Push(JValue.R(rt.String("Number$")));f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",174);}
case 174:{f.Pc=f.Pop().Int==0?191:177;continue;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[5]);f.Pc=180;continue;}
case 180:{f.Push(JValue.I(7));f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",185);}
case 185:{return rt.DynamicCall(f,"forge/game/replacement/ReplacementEffect:9007:185:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",190);}
case 190:{f.Locals[1]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(f.Locals[4]);f.Pc=193;continue;}
case 193:{f.Pc=f.Pop().Reference==null?283:196;continue;}
case 196:{f.Push(f.Locals[4]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",201);}
case 201:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"));f.Pc=204;continue;}
case 204:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?283:207;continue;}
case 207:{f.Push(f.Locals[4]);f.Pc=209;continue;}
case 209:{f.Push(JValue.R(rt.String("VarName")));f.Pc=212;continue;}
case 212:{f.Push(JValue.R(rt.String("1")));f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",218);}
case 218:{f.Locals[5]=f.Pop();f.Pc=220;continue;}
case 220:{f.Push(f.Locals[5]);f.Pc=222;continue;}
case 222:{f.Push(JValue.R(rt.String("1")));f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",228);}
case 228:{f.Pc=f.Pop().Int==0?241:231;continue;}
case 231:{f.Push(f.Locals[1]);f.Pc=232;continue;}
case 232:{return rt.DynamicCall(f,"forge/game/replacement/ReplacementEffect:9007:232:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",237);}
case 237:{f.Locals[1]=f.Pop();f.Pc=238;continue;}
case 238:{f.Pc=283;continue;}
case 241:{f.Push(f.Locals[5]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",246);}
case 246:{f.Pc=f.Pop().Int!=0?283:249;continue;}
case 249:{f.Push(f.Locals[4]);f.Pc=251;continue;}
case 251:{f.Push(f.Locals[5]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",256);}
case 256:{f.Locals[5]=f.Pop();f.Pc=258;continue;}
case 258:{f.Push(f.Locals[5]);f.Pc=260;continue;}
case 260:{f.Push(JValue.R(rt.String("Number$")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",266);}
case 266:{f.Pc=f.Pop().Int==0?283:269;continue;}
case 269:{f.Push(f.Locals[1]);f.Pc=270;continue;}
case 270:{f.Push(f.Locals[5]);f.Pc=272;continue;}
case 272:{f.Push(JValue.I(7));f.Pc=274;continue;}
case 274:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",277);}
case 277:{return rt.DynamicCall(f,"forge/game/replacement/ReplacementEffect:9007:277:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",282);}
case 282:{f.Locals[1]=f.Pop();f.Pc=283;continue;}
case 283:{f.Push(f.Locals[1]);f.Pc=284;continue;}
case 284:{return JStep.Return(f.Pop());}
case 285:{f.Push(JValue.R(rt.String("")));f.Pc=288;continue;}
case 288:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9008(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getDescription","()Ljava/lang/String;","invokevirtual",11);}
case 11:{return rt.DynamicCall(f,"forge/game/replacement/ReplacementEffect:9008:11:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9009(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","clone","()Ljava/lang/Object;","invokespecial",4);}
case 4:{return JStep.Return(f.Pop());}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",14);}
case 14:{return rt.DynamicCall(f,"forge/game/replacement/ReplacementEffect:9009:14:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",19);}
case 19:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",22);}
case 22:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9010(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/replacement/ReplacementEffect")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getId","()I","invokevirtual",13);}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getId","()I","invokevirtual",20);}
case 20:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?27:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Pc=28;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9011(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(31));f.Pc=2;continue;}
case 2:{f.Push(JValue.I(31));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementEffect","CLASS_HASH","I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementEffect","CLASS_HASH","I"));f.Pc=7;continue;}
case 7:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=8;continue;}
case 8:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getId","()I","invokevirtual",13);}
case 13:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9012(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementEffect","mode","Lforge/game/replacement/ReplacementType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9013(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementEffect","mode","Lforge/game/replacement/ReplacementType;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9014(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?39:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("ReplaceWith")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?39:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getHostCard","()Lforge/game/card/Card;","invokevirtual",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("ReplaceWith")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/Card;Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokestatic",33);}
case 33:{f.Locals[1]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",39);}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9015(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?26:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Push(JValue.R(rt.String("Card.Self")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?113:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getHostCard","()Lforge/game/card/Card;","invokevirtual",30);}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",39);}
case 39:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?47:45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getActiveZone","()Ljava/util/Set;","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Reference==null?113:54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getActiveZone","()Ljava/util/Set;","invokevirtual",58);}
case 58:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",66);}
case 66:{f.Pc=f.Pop().Int==0?113:69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",78);}
case 78:{f.Pc=f.Pop().Int==0?113:81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{f.Locals[2]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{f.Pc=f.Pop().Reference==null?113:98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getHostCard","()Lforge/game/card/Card;","invokevirtual",103);}
case 103:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",108);}
case 108:{f.Pc=f.Pop().Int!=0?113:111;continue;}
case 111:{f.Push(JValue.I(0));f.Pc=112;continue;}
case 112:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 113:{f.Push(JValue.I(1));f.Pc=114;continue;}
case 114:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9016(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getMode","()Lforge/game/replacement/ReplacementType;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/replacement/ReplacementType","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9017(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementEffect","maxId","I"))return JStep.Continue;rt.PutStatic("forge/game/replacement/ReplacementEffect","maxId","I",f.Pop());f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.ClassObject("forge/game/replacement/ReplacementEffect")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","hashCode","()I","invokevirtual",9);}
case 9:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementEffect","CLASS_HASH","I"))return JStep.Continue;rt.PutStatic("forge/game/replacement/ReplacementEffect","CLASS_HASH","I",f.Pop());f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
