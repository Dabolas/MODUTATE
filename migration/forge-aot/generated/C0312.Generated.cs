// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C312{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/GoadEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3429,"forge/game/ability/effects/GoadEffect","<init>","()V",1,1,1,new JHandler[]{},M3429));
c.Add(new JMethod(3430,"forge/game/ability/effects/GoadEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,3,new JHandler[]{},M3430));
c.Add(new JMethod(3431,"forge/game/ability/effects/GoadEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,4,new JHandler[]{},M3431));
c.Add(new JMethod(3432,"forge/game/ability/effects/GoadEffect","$deserializeLambda$","(Ljava/lang/invoke/SerializedLambda;)Ljava/lang/Object;",4106,3,3,new JHandler[]{},M3432));
c.Add(new JMethod(3433,"forge/game/ability/effects/GoadEffect","lambda$resolve$a97c48ea$1","(Lforge/game/card/Card;J)V",4106,3,3,new JHandler[]{},M3433));
}

internal static JStep M3429(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3430(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Defined")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/ability/effects/GoadEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("DefinedDesc")));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",19);}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?35:32;continue;}
case 32:{f.Push(JValue.R(rt.String("")));f.Pc=34;continue;}
case 34:{return JStep.Return(f.Pop());}
case 35:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",42);}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",50);}
case 50:{f.Push(JValue.R(rt.String(" goads ")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",55);}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",60);}
case 60:{f.Push(JValue.R(rt.String(".")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",71);}
case 71:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3431(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("RememberGoaded")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Locals[6]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("NoLonger")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",30);}
case 30:{f.Locals[7]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("Duration")));f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("UntilYourNextTurn")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",40);}
case 40:{f.Locals[8]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/ability/effects/GoadEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",46);}
case 46:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",49);}
case 49:{f.Locals[9]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[9]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",58);}
case 58:{f.Pc=f.Pop().Int==0?186:61;continue;}
case 61:{f.Push(f.Locals[9]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",68);}
case 68:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=71;continue;}
case 71:{f.Locals[10]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[10]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int!=0?84:81;continue;}
case 81:{f.Pc=51;continue;}
case 84:{f.Push(f.Locals[7]);f.Pc=86;continue;}
case 86:{f.Pc=f.Pop().Int==0?97:89;continue;}
case 89:{f.Push(f.Locals[10]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/Card","unGoad","()V","invokevirtual",94);}
case 94:{f.Pc=51;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[10]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(null));f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",104);}
case 104:{f.Locals[11]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[11]);f.Pc=108;continue;}
case 108:{f.Pc=f.Pop().Reference==null?51:111;continue;}
case 111:{f.Push(f.Locals[10]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[11]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int!=0?124:121;continue;}
case 121:{f.Pc=51;continue;}
case 124:{f.Push(f.Locals[11]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[4]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",131);}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/card/Card","addGoad","(Ljava/lang/Long;Lforge/game/player/Player;)V","invokevirtual",135);}
case 135:{f.Push(f.Locals[8]);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",142);}
case 142:{f.Pc=f.Pop().Int!=0?161:145;continue;}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[11]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[4]);f.Pc=150;continue;}
case 150:{return rt.DynamicCall(f,"forge/game/ability/effects/GoadEffect:3431:150:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/card/Card;J)Lforge/GameCommand;",155);}
case 155:{f.Push(f.Locals[8]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[2]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/ability/effects/GoadEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;Ljava/lang/String;Lforge/game/player/Player;)V","invokestatic",161);}
case 161:{f.Push(f.Locals[6]);f.Pc=163;continue;}
case 163:{f.Pc=f.Pop().Int==0?183:166;continue;}
case 166:{f.Push(f.Locals[11]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/card/Card","isGoaded","()Z","invokevirtual",171);}
case 171:{f.Pc=f.Pop().Int==0?183:174;continue;}
case 174:{f.Push(f.Locals[1]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",178);}
case 178:{f.Push(f.Locals[11]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",183);}
case 183:{f.Pc=51;continue;}
case 186:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3432(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(-1));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",11);}
case 11:{switch(f.Pop().Int){case -2103163290:f.Pc=28;break;default:f.Pc=39;break;}continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("lambda$resolve$a97c48ea$1")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?39:37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{f.Locals[2]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{switch(f.Pop().Int){case 0:f.Pc=60;break;default:f.Pc=154;break;}continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodKind","()I","invokevirtual",64);}
case 64:{f.Push(JValue.I(6));f.Pc=66;continue;}
case 66:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?154:69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceClass","()Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Push(JValue.R(rt.String("forge/GameCommand")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int==0?154:81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodName","()Ljava/lang/String;","invokevirtual",85);}
case 85:{f.Push(JValue.R(rt.String("run")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?154:93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodSignature","()Ljava/lang/String;","invokevirtual",97);}
case 97:{f.Push(JValue.R(rt.String("()V")));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int==0?154:105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplClass","()Ljava/lang/String;","invokevirtual",109);}
case 109:{f.Push(JValue.R(rt.String("forge/game/ability/effects/GoadEffect")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?154:117;continue;}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodSignature","()Ljava/lang/String;","invokevirtual",121);}
case 121:{f.Push(JValue.R(rt.String("(Lforge/game/card/Card;J)V")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int==0?154:129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(JValue.I(0));f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",134);}
case 134:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{f.Push(JValue.I(1));f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",142);}
case 142:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Long"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/lang/Long","longValue","()J","invokevirtual",148);}
case 148:{return rt.DynamicCall(f,"forge/game/ability/effects/GoadEffect:3432:148:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/card/Card;J)Lforge/GameCommand;",153);}
case 153:{return JStep.Return(f.Pop());}
case 154:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=157;continue;}
case 157:{f.StackOp("dup");f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("Invalid lambda deserialization")));f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",163);}
case 163:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3433(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/card/Card","removeGoad","(Ljava/lang/Long;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
