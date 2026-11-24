// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C561{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostTapType","forge/game/cost/CostPartWithList",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("canTapSource","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(6599,"forge/game/cost/CostTapType","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V",1,5,4,new JHandler[]{},M6599));
c.Add(new JMethod(6600,"forge/game/cost/CostTapType","getMaxAmountX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;",1,6,5,new JHandler[]{},M6600));
c.Add(new JMethod(6601,"forge/game/cost/CostTapType","isReusable","()Z",1,1,1,new JHandler[]{},M6601));
c.Add(new JMethod(6602,"forge/game/cost/CostTapType","isRenewable","()Z",1,1,1,new JHandler[]{},M6602));
c.Add(new JMethod(6603,"forge/game/cost/CostTapType","toString","()Ljava/lang/String;",17,7,3,new JHandler[]{},M6603));
c.Add(new JMethod(6604,"forge/game/cost/CostTapType","refund","(Lforge/game/card/Card;)V",17,4,2,new JHandler[]{},M6604));
c.Add(new JMethod(6605,"forge/game/cost/CostTapType","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,12,5,new JHandler[]{},M6605));
c.Add(new JMethod(6606,"forge/game/cost/CostTapType","doPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Z)Lforge/game/card/Card;",4,5,3,new JHandler[]{},M6606));
c.Add(new JMethod(6607,"forge/game/cost/CostTapType","canPayListAtOnce","()Z",4,1,1,new JHandler[]{},M6607));
c.Add(new JMethod(6608,"forge/game/cost/CostTapType","doListPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;Z)Lforge/game/card/CardCollectionView;",4,8,4,new JHandler[]{},M6608));
c.Add(new JMethod(6609,"forge/game/cost/CostTapType","getHashForLKIList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6609));
c.Add(new JMethod(6610,"forge/game/cost/CostTapType","getHashForCardList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6610));
c.Add(new JMethod(6611,"forge/game/cost/CostTapType","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6611));
}

internal static JStep M6599(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/CostPartWithList","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[4]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Int!=0?17:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostTapType","canTapSource","Z",value);f.Pc=21;continue;}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6600(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",13);}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/cost/CostTapType","getType","()Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Push(JValue.R(rt.String(";")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",29);}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostTapType","canTapSource","Z"));f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Int!=0?46:38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",45);}
case 45:{f.StackOp("pop");f.Pc=46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCrew","()Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int==0?61:55;continue;}
case 55:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CAN_CREW","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","CAN_CREW","Ljava/util/function/Predicate;"));f.Pc=58;continue;}
case 58:{f.Pc=64;continue;}
case 61:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CAN_TAP","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","CAN_TAP","Ljava/util/function/Predicate;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",67);}
case 67:{f.Locals[5]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",74);}
case 74:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",77);}
case 77:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6601(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6602(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6603(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/CostTapType","getDescriptiveType","()Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/cost/CostTapType","getType","()Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/cost/CostTapType","getAmount","()Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("+withTotalPowerGE")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?67:33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("\\+withTotalPowerGE")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",39);}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=41;continue;}
case 41:{f.Locals[5]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("Tap any number of untapped creatures you control other than CARDNAME with total power ")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",56);}
case 56:{f.Push(JValue.R(rt.String(" or greater")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",66);}
case 66:{return JStep.Return(f.Pop());}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("Tap ")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",73);}
case 73:{f.StackOp("pop");f.Pc=74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("Other")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int==0?183:83;continue;}
case 83:{f.Push(f.Locals[3]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String(".Other")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int==0?97:92;continue;}
case 92:{f.Push(JValue.R(rt.String(".Other")));f.Pc=94;continue;}
case 94:{f.Pc=99;continue;}
case 97:{f.Push(JValue.R(rt.String("+Other")));f.Pc=99;continue;}
case 99:{f.Locals[5]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[5]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",109);}
case 109:{f.Locals[6]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[6]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/card/CardType$CoreType","isValidEnum","(Ljava/lang/String;)Z","invokestatic",116);}
case 116:{f.Pc=f.Pop().Int==0?126:119;continue;}
case 119:{f.Push(f.Locals[6]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",124);}
case 124:{f.Locals[6]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[1]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[4]);f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.String("1")));f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int==0?147:137;continue;}
case 137:{f.Push(f.Locals[6]);f.Pc=139;continue;}
case 139:{return rt.DynamicCall(f,"forge/game/cost/CostTapType:6603:139:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",144);}
case 144:{f.Pc=159;continue;}
case 147:{f.Push(f.Locals[4]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[6]);f.Pc=151;continue;}
case 151:{return rt.DynamicCall(f,"forge/game/cost/CostTapType:6603:151:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",156);}
case 156:{return rt.Call(f,"forge/util/Lang","nounWithNumeral","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",159);}
case 159:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",162);}
case 162:{f.StackOp("pop");f.Pc=163;continue;}
case 163:{f.Push(f.Locals[6]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("you control")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",170);}
case 170:{f.Pc=f.Pop().Int!=0?180:173;continue;}
case 173:{f.Push(f.Locals[1]);f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String(" you control")));f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",179);}
case 179:{f.StackOp("pop");f.Pc=180;continue;}
case 180:{f.Pc=233;continue;}
case 183:{f.Push(f.Locals[4]);f.Pc=185;continue;}
case 185:{f.Push(JValue.R(rt.String("X")));f.Pc=187;continue;}
case 187:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",190);}
case 190:{f.Pc=f.Pop().Int==0?212:193;continue;}
case 193:{f.Push(f.Locals[1]);f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("any number of untapped ")));f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",199);}
case 199:{f.Push(f.Locals[2]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",203);}
case 203:{f.Push(JValue.R(rt.String("s you control")));f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",208);}
case 208:{f.StackOp("pop");f.Pc=209;continue;}
case 209:{f.Pc=233;continue;}
case 212:{f.Push(f.Locals[1]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[4]);f.Pc=215;continue;}
case 215:{f.Push(f.Locals[2]);f.Pc=216;continue;}
case 216:{return rt.DynamicCall(f,"forge/game/cost/CostTapType:6603:216:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",221);}
case 221:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",224);}
case 224:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",227);}
case 227:{f.Push(JValue.R(rt.String(" you control")));f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",232);}
case 232:{f.StackOp("pop");f.Pc=233;continue;}
case 233:{f.Push(f.Locals[3]);f.Pc=234;continue;}
case 234:{f.Push(JValue.R(rt.String("sharesCreatureTypeWith")));f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",239);}
case 239:{f.Pc=f.Pop().Int==0?249:242;continue;}
case 242:{f.Push(f.Locals[1]);f.Pc=243;continue;}
case 243:{f.Push(JValue.R(rt.String(" that share a creature type")));f.Pc=245;continue;}
case 245:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",248);}
case 248:{f.StackOp("pop");f.Pc=249;continue;}
case 249:{f.Push(f.Locals[1]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",253);}
case 253:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6604(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostTapType","cardList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int==0?35:17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",32);}
case 32:{f.Pc=8;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostTapType","cardList","Lforge/game/card/CardCollection;"));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",42);}
case 42:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6605(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/cost/CostTapType","getType","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[5]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Locals[6]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[5]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("OriginalHost")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?33:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/game/card/Card","canTap","()Z","invokevirtual",32);}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String(".sharesCreatureTypeWith")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?57:43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{f.Locals[6]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String(".sharesCreatureTypeWith")));f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",55);}
case 55:{f.Locals[5]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{f.Locals[7]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("")));f.Pc=62;continue;}
case 62:{f.Locals[8]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("+withTotalPowerGE")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int==0?114:74;continue;}
case 74:{f.Push(JValue.I(1));f.Pc=75;continue;}
case 75:{f.Locals[7]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("withTotalPowerGE")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",84);}
case 84:{f.Push(JValue.I(1));f.Pc=85;continue;}
case 85:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=86;continue;}
case 86:{f.Locals[8]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[5]);f.Pc=90;continue;}
case 90:{f.Push(JValue.I(2));f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=94;continue;}
case 94:{f.StackOp("dup");f.Pc=95;continue;}
case 95:{f.Push(JValue.I(0));f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("+withTotalPowerGE")));f.Pc=98;continue;}
case 98:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=99;continue;}
case 99:{f.StackOp("dup");f.Pc=100;continue;}
case 100:{f.Push(JValue.I(1));f.Pc=101;continue;}
case 101:{f.Push(f.Locals[8]);f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",107);}
case 107:{f.Push(JValue.R(rt.String("")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",112);}
case 112:{f.Locals[5]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",121);}
case 121:{f.Push(f.Locals[5]);f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.String(";")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",128);}
case 128:{f.Push(f.Locals[2]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[4]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",135);}
case 135:{f.Locals[9]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostTapType","canTapSource","Z"));f.Pc=141;continue;}
case 141:{f.Pc=f.Pop().Int!=0?152:144;continue;}
case 144:{f.Push(f.Locals[9]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",151);}
case 151:{f.StackOp("pop");f.Pc=152;continue;}
case 152:{f.Push(f.Locals[9]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[1]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCrew","()Z","invokevirtual",158);}
case 158:{f.Pc=f.Pop().Int==0?167:161;continue;}
case 161:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CAN_CREW","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","CAN_CREW","Ljava/util/function/Predicate;"));f.Pc=164;continue;}
case 164:{f.Pc=170;continue;}
case 167:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CAN_TAP","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","CAN_TAP","Ljava/util/function/Predicate;"));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",173);}
case 173:{f.Locals[9]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[6]);f.Pc=177;continue;}
case 177:{f.Pc=f.Pop().Int==0?230:180;continue;}
case 180:{f.Push(f.Locals[9]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",185);}
case 185:{f.Locals[10]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[10]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",194);}
case 194:{f.Pc=f.Pop().Int==0?228:197;continue;}
case 197:{f.Push(f.Locals[10]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",204);}
case 204:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=207;continue;}
case 207:{f.Locals[11]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[9]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[11]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/card/CardPredicates","sharesCreatureTypeWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",216);}
case 216:{return rt.Call(f,"forge/game/card/CardLists","count","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I","invokestatic",219);}
case 219:{f.Push(JValue.I(1));f.Pc=220;continue;}
case 220:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?225:223;continue;}
case 223:{f.Push(JValue.I(1));f.Pc=224;continue;}
case 224:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 225:{f.Pc=187;continue;}
case 228:{f.Push(JValue.I(0));f.Pc=229;continue;}
case 229:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 230:{f.Push(f.Locals[7]);f.Pc=232;continue;}
case 232:{f.Pc=f.Pop().Int==0?259:235;continue;}
case 235:{f.Push(f.Locals[8]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",240);}
case 240:{f.Locals[10]=f.Pop();f.Pc=242;continue;}
case 242:{f.Push(f.Locals[9]);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[1]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/card/CardLists","getTotalPower","(Ljava/lang/Iterable;Lforge/game/CardTraitBase;)I","invokestatic",248);}
case 248:{f.Push(f.Locals[10]);f.Pc=250;continue;}
case 250:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?257:253;continue;}
case 253:{f.Push(JValue.I(1));f.Pc=254;continue;}
case 254:{f.Pc=258;continue;}
case 257:{f.Push(JValue.I(0));f.Pc=258;continue;}
case 258:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 259:{f.Push(f.Locals[0]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[1]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/cost/CostTapType","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",264);}
case 264:{f.Locals[10]=f.Pop();f.Pc=266;continue;}
case 266:{f.Push(f.Locals[9]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",271);}
case 271:{f.Push(f.Locals[10]);f.Pc=273;continue;}
case 273:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?280:276;continue;}
case 276:{f.Push(JValue.I(1));f.Pc=277;continue;}
case 277:{f.Pc=281;continue;}
case 280:{f.Push(JValue.I(0));f.Pc=281;continue;}
case 281:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6606(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","tap","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z","invokevirtual",6);}
case 6:{f.StackOp("pop");f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6607(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6608(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[6]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[6]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?60:27;continue;}
case 27:{f.Push(f.Locals[6]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[7]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[7]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","tap","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?57:49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[7]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{f.Pc=17;continue;}
case 60:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",63);}
case 63:{f.Locals[6]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[6]);f.Pc=67;continue;}
case 67:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=70;continue;}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",77);}
case 77:{f.StackOp("pop");f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",82);}
case 82:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",85);}
case 85:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[6]);f.Pc=90;continue;}
case 90:{f.Push(JValue.I(0));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",94);}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6609(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6610(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("TappedCards")));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6611(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostTapType;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
