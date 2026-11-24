// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C553{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostRemoveAnyCounter","forge/game/cost/CostPart",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("counter","Lforge/game/card/CounterType;",false,JValue.Default("Lforge/game/card/CounterType;"),null));
c.Add(new JField("oneOrMore","Ljava/lang/Boolean;",false,JValue.Default("Ljava/lang/Boolean;"),null));
c.Add(new JMethod(6523,"forge/game/cost/CostRemoveAnyCounter","<init>","(Ljava/lang/String;Lforge/game/card/CounterType;Ljava/lang/String;Ljava/lang/String;Z)V",1,6,4,new JHandler[]{},M6523));
c.Add(new JMethod(6524,"forge/game/cost/CostRemoveAnyCounter","paymentOrder","()I",1,1,1,new JHandler[]{},M6524));
c.Add(new JMethod(6525,"forge/game/cost/CostRemoveAnyCounter","getMaxAmountX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;",1,6,5,new JHandler[]{},M6525));
c.Add(new JMethod(6526,"forge/game/cost/CostRemoveAnyCounter","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,4,5,new JHandler[]{},M6526));
c.Add(new JMethod(6527,"forge/game/cost/CostRemoveAnyCounter","toString","()Ljava/lang/String;",17,4,4,new JHandler[]{},M6527));
c.Add(new JMethod(6528,"forge/game/cost/CostRemoveAnyCounter","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",1,10,4,new JHandler[]{},M6528));
c.Add(new JMethod(6529,"forge/game/cost/CostRemoveAnyCounter","getDescriptiveType","(Z)Ljava/lang/String;",1,4,3,new JHandler[]{},M6529));
c.Add(new JMethod(6530,"forge/game/cost/CostRemoveAnyCounter","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6530));
c.Add(new JMethod(6531,"forge/game/cost/CostRemoveAnyCounter","lambda$getMaxAmountX$3","(Lcom/google/common/collect/Multiset$Entry;)I",4106,1,1,new JHandler[]{},M6531));
c.Add(new JMethod(6532,"forge/game/cost/CostRemoveAnyCounter","lambda$getMaxAmountX$2","(Lforge/game/card/Card;)Ljava/util/stream/Stream;",4106,1,2,new JHandler[]{},M6532));
c.Add(new JMethod(6533,"forge/game/cost/CostRemoveAnyCounter","lambda$getMaxAmountX$1","(Lforge/game/card/Card;Lcom/google/common/collect/Multiset$Entry;)Z",4106,2,2,new JHandler[]{},M6533));
c.Add(new JMethod(6534,"forge/game/cost/CostRemoveAnyCounter","lambda$getMaxAmountX$0","(Lforge/game/card/Card;)I",4098,2,2,new JHandler[]{},M6534));
}

internal static JStep M6523(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[4]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/CostPart","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostRemoveAnyCounter","counter","Lforge/game/card/CounterType;",value);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[5]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostRemoveAnyCounter","oneOrMore","Ljava/lang/Boolean;",value);f.Pc=22;continue;}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6524(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(8));f.Pc=2;continue;}
case 2:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6525(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/cost/CostRemoveAnyCounter","payCostFromSource","()Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?27:13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",22);}
case 22:{f.Locals[5]=f.Pop();f.Pc=24;continue;}
case 24:{f.Pc=52;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",34);}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/cost/CostRemoveAnyCounter","getType","()Ljava/lang/String;","invokevirtual",38);}
case 38:{f.Push(JValue.R(rt.String(";")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",43);}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",50);}
case 50:{f.Locals[5]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveAnyCounter","counter","Lforge/game/card/CounterType;"));f.Pc=56;continue;}
case 56:{f.Pc=f.Pop().Reference==null?86:59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/CardCollectionView","stream","()Ljava/util/stream/Stream;","invokeinterface",66);}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{return rt.DynamicCall(f,"forge/game/cost/CostRemoveAnyCounter:6525:67:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/cost/CostRemoveAnyCounter;)Ljava/util/function/ToIntFunction;",72);}
case 72:{return rt.Call(f,"java/util/stream/Stream","mapToInt","(Ljava/util/function/ToIntFunction;)Ljava/util/stream/IntStream;","invokeinterface",77);}
case 77:{return rt.Call(f,"java/util/stream/IntStream","sum","()I","invokeinterface",82);}
case 82:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",85);}
case 85:{return JStep.Return(f.Pop());}
case 86:{f.Push(f.Locals[5]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/card/CardCollectionView","stream","()Ljava/util/stream/Stream;","invokeinterface",93);}
case 93:{return rt.DynamicCall(f,"forge/game/cost/CostRemoveAnyCounter:6525:93:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",98);}
case 98:{return rt.Call(f,"java/util/stream/Stream","flatMap","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",103);}
case 103:{return rt.DynamicCall(f,"forge/game/cost/CostRemoveAnyCounter:6525:103:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",108);}
case 108:{return rt.Call(f,"java/util/stream/Collectors","summingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;","invokestatic",111);}
case 111:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",116);}
case 116:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=119;continue;}
case 119:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6526(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/CostRemoveAnyCounter","getAmount","()Ljava/lang/String;","invokevirtual",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",12);}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/cost/CostRemoveAnyCounter","getMaxAmountX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;","invokevirtual",19);}
case 19:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",22);}
case 22:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?29:25;continue;}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{f.Pc=30;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6527(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveAnyCounter","counter","Lforge/game/card/CounterType;"));f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference!=null?20:15;continue;}
case 15:{f.Push(JValue.R(rt.String("counter")));f.Pc=17;continue;}
case 17:{f.Pc=37;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveAnyCounter","counter","Lforge/game/card/CounterType;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",29);}
case 29:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",32);}
case 32:{return rt.DynamicCall(f,"forge/game/cost/CostRemoveAnyCounter:6527:32:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",37);}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("1")));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/cost/CostRemoveAnyCounter","getAmount","()Ljava/lang/String;","invokevirtual",44);}
case 44:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int!=0?54:50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{f.Pc=55;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{f.Locals[3]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("Remove ")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveAnyCounter","oneOrMore","Ljava/lang/Boolean;"));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int==0?90:73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("one or more ")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",79);}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/util/Lang","getPlural","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",83);}
case 83:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",86);}
case 86:{f.StackOp("pop");f.Pc=87;continue;}
case 87:{f.Pc=107;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/cost/CostRemoveAnyCounter","convertAmount","()Ljava/lang/Integer;","invokevirtual",95);}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/cost/CostRemoveAnyCounter","getAmount","()Ljava/lang/String;","invokevirtual",99);}
case 99:{f.Push(f.Locals[2]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",103);}
case 103:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",106);}
case 106:{f.StackOp("pop");f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String(" from ")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",113);}
case 113:{f.StackOp("pop");f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/cost/CostRemoveAnyCounter","payCostFromSource","()Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int==0?134:121;continue;}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[3]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/cost/CostRemoveAnyCounter","getDescriptiveType","(Z)Ljava/lang/String;","invokevirtual",127);}
case 127:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",130);}
case 130:{f.StackOp("pop");f.Pc=131;continue;}
case 131:{f.Pc=162;continue;}
case 134:{f.Push(f.Locals[3]);f.Pc=135;continue;}
case 135:{f.Pc=f.Pop().Int==0?145:138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String(" among ")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",144);}
case 144:{f.StackOp("pop");f.Pc=145;continue;}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[3]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/cost/CostRemoveAnyCounter","getDescriptiveType","(Z)Ljava/lang/String;","invokevirtual",151);}
case 151:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",154);}
case 154:{f.StackOp("pop");f.Pc=155;continue;}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String(" you control")));f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",161);}
case 161:{f.StackOp("pop");f.Pc=162;continue;}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",166);}
case 166:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6528(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[5]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","counterTable","Lforge/game/GameEntityCounterTable;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Optional","empty","()Ljava/util/Optional;","invokestatic",10);}
case 10:{return rt.Call(f,"forge/game/GameEntityCounterTable","row","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",18);}
case 18:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",23);}
case 23:{f.Locals[6]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[6]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?183:35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[7]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[7]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{return rt.Call(f,"com/google/common/collect/Multiset","entrySet","()Ljava/util/Set;","invokeinterface",62);}
case 62:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",67);}
case 67:{f.Locals[8]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[8]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",76);}
case 76:{f.Pc=f.Pop().Int==0?138:79;continue;}
case 79:{f.Push(f.Locals[8]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",86);}
case 86:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=89;continue;}
case 89:{f.Locals[9]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[5]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[9]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",100);}
case 100:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=101;continue;}
case 101:{f.Locals[5]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[7]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",110);}
case 110:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[9]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",120);}
case 120:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[9]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",130);}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/GameEntity","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",134);}
case 134:{f.StackOp("pop");f.Pc=135;continue;}
case 135:{f.Pc=69;continue;}
case 138:{f.Push(f.Locals[7]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",145);}
case 145:{f.Locals[9]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[9]);f.Pc=149;continue;}
case 149:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=152;continue;}
case 152:{f.Pc=f.Pop().Int==0?180:155;continue;}
case 155:{f.Push(f.Locals[9]);f.Pc=157;continue;}
case 157:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=160;continue;}
case 160:{f.Locals[8]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[7]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",169);}
case 169:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/GameEntity","getGame","()Lforge/game/Game;","invokevirtual",175);}
case 175:{f.Push(f.Locals[8]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/Game","updateLastStateForCard","(Lforge/game/card/Card;)V","invokevirtual",180);}
case 180:{f.Pc=25;continue;}
case 183:{f.Push(f.Locals[3]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("CostCountersRemoved")));f.Pc=187;continue;}
case 187:{f.Push(f.Locals[5]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",192);}
case 192:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",195);}
case 195:{f.Push(JValue.I(1));f.Pc=196;continue;}
case 196:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6529(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostRemoveAnyCounter","getTypeDescription","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?75:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/cost/CostRemoveAnyCounter","payCostFromSource","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?21:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/cost/CostRemoveAnyCounter","getType","()Ljava/lang/String;","invokevirtual",20);}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/cost/CostRemoveAnyCounter","getType","()Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Push(JValue.R(rt.String(";")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",30);}
case 30:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",33);}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Int==0?66:38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",44);}
case 44:{return rt.DynamicCall(f,"forge/game/cost/CostRemoveAnyCounter:6529:44:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",49);}
case 49:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",54);}
case 54:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",57);}
case 57:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",62);}
case 62:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=65;continue;}
case 65:{f.Locals[3]=f.Pop();f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",69);}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/util/Lang","buildValidDesc","(Ljava/util/Collection;Z)Ljava/lang/String;","invokevirtual",74);}
case 74:{f.Locals[2]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Pc=f.Pop().Int!=0?112:79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("an")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int!=0?112:89;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/util/Lang","startsWithVowel","(Ljava/lang/String;)Z","invokestatic",93);}
case 93:{f.Pc=f.Pop().Int==0?102:96;continue;}
case 96:{f.Push(JValue.R(rt.String("an ")));f.Pc=99;continue;}
case 99:{f.Pc=105;continue;}
case 102:{f.Push(JValue.R(rt.String("a ")));f.Pc=105;continue;}
case 105:{f.Push(f.Locals[2]);f.Pc=106;continue;}
case 106:{return rt.DynamicCall(f,"forge/game/cost/CostRemoveAnyCounter:6529:106:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",111);}
case 111:{f.Locals[2]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6530(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostRemoveAnyCounter;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6531(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6532(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",4);}
case 4:{return rt.Call(f,"com/google/common/collect/Multiset","entrySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.DynamicCall(f,"forge/game/cost/CostRemoveAnyCounter:6532:15:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",20);}
case 20:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",25);}
case 25:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6533(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/Card","canRemoveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6534(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveAnyCounter","counter","Lforge/game/card/CounterType;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","canRemoveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?22:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveAnyCounter","counter","Lforge/game/card/CounterType;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",19);}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
