// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C557{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostRevealChosen","forge/game/cost/CostPart",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JMethod(6566,"forge/game/cost/CostRevealChosen","<init>","(Ljava/lang/String;Ljava/lang/String;)V",1,3,4,new JHandler[]{},M6566));
c.Add(new JMethod(6567,"forge/game/cost/CostRevealChosen","paymentOrder","()I",1,1,1,new JHandler[]{},M6567));
c.Add(new JMethod(6568,"forge/game/cost/CostRevealChosen","toString","()Ljava/lang/String;",17,1,2,new JHandler[]{},M6568));
c.Add(new JMethod(6569,"forge/game/cost/CostRevealChosen","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,5,2,new JHandler[]{},M6569));
c.Add(new JMethod(6570,"forge/game/cost/CostRevealChosen","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",1,8,6,new JHandler[]{},M6570));
c.Add(new JMethod(6571,"forge/game/cost/CostRevealChosen","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6571));
}

internal static JStep M6566(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("1")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/CostPart","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6567(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(20));f.Pc=2;continue;}
case 2:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6568(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostRevealChosen","getType","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("Player")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?15:12;continue;}
case 12:{f.Push(JValue.R(rt.String("Reveal the player you chose")));f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/cost/CostRevealChosen","getType","()Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(JValue.R(rt.String("Type")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?40:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/cost/CostRevealChosen","getDescriptiveType","()Ljava/lang/String;","invokevirtual",31);}
case 31:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",34);}
case 34:{return rt.DynamicCall(f,"forge/game/cost/CostRevealChosen:6568:34:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",39);}
case 39:{return JStep.Return(f.Pop());}
case 40:{f.Push(JValue.R(rt.String("Update CostRevealChosen.java")));f.Pc=42;continue;}
case 42:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6569(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/cost/CostRevealChosen","getType","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Push(JValue.R(rt.String("Player")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?44:18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/Card","hasChosenPlayer","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?42:26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","getTurnInController","()Lforge/game/player/Player;","invokevirtual",31);}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?42:38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{f.Pc=43;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/cost/CostRevealChosen","getType","()Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Push(JValue.R(rt.String("Type")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?82:56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","hasChosenType","()Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int==0?80:64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/Card","getTurnInController","()Lforge/game/player/Player;","invokevirtual",69);}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int==0?80:76;continue;}
case 76:{f.Push(JValue.I(1));f.Pc=77;continue;}
case 77:{f.Pc=81;continue;}
case 80:{f.Push(JValue.I(0));f.Pc=81;continue;}
case 81:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 82:{f.Push(JValue.I(0));f.Pc=83;continue;}
case 83:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6570(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("")));f.Pc=8;continue;}
case 8:{f.Locals[6]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/cost/CostRevealChosen","getType","()Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Push(JValue.R(rt.String("Player")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?40:22;continue;}
case 22:{f.Push(f.Locals[5]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","getChosenPlayer","()Lforge/game/player/Player;","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/game/player/Player","toString","()Ljava/lang/String;","invokevirtual",30);}
case 30:{f.Locals[6]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/Card","revealChosenPlayer","()V","invokevirtual",37);}
case 37:{f.Pc=64;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/cost/CostRevealChosen","getType","()Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Push(JValue.R(rt.String("Type")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int==0?64:52;continue;}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/Card","getChosenType","()Ljava/lang/String;","invokevirtual",57);}
case 57:{f.Locals[6]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/Card","revealChosenType","()V","invokevirtual",64);}
case 64:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",67);}
case 67:{f.Push(JValue.R(rt.String("lblPlayerReveals")));f.Pc=69;continue;}
case 69:{f.Push(JValue.I(2));f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=73;continue;}
case 73:{f.StackOp("dup");f.Pc=74;continue;}
case 74:{f.Push(JValue.I(0));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=77;continue;}
case 77:{f.StackOp("dup");f.Pc=78;continue;}
case 78:{f.Push(JValue.I(1));f.Pc=79;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",85);}
case 85:{f.Locals[7]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",91);}
case 91:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",94);}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[5]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[7]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",103);}
case 103:{f.Push(JValue.I(1));f.Pc=104;continue;}
case 104:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6571(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostRevealChosen;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
