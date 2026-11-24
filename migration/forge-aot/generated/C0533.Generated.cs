// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C533{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostExile","forge/game/cost/CostPartWithList",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("from","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("zoneRestriction","I",false,JValue.Default("I"),null));
c.Add(new JField("HashLKIListKey","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Exiled"));
c.Add(new JField("HashCardListKey","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"ExiledCards"));
c.Add(new JMethod(6315,"forge/game/cost/CostExile","getFrom","()Ljava/util/List;",17,1,1,new JHandler[]{},M6315));
c.Add(new JMethod(6316,"forge/game/cost/CostExile","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;)V",1,5,7,new JHandler[]{},M6316));
c.Add(new JMethod(6317,"forge/game/cost/CostExile","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;I)V",1,6,7,new JHandler[]{},M6317));
c.Add(new JMethod(6318,"forge/game/cost/CostExile","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V",1,5,7,new JHandler[]{},M6318));
c.Add(new JMethod(6319,"forge/game/cost/CostExile","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;Ljava/util/List;I)V",1,7,4,new JHandler[]{},M6319));
c.Add(new JMethod(6320,"forge/game/cost/CostExile","getMaxAmountX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;",1,7,5,new JHandler[]{},M6320));
c.Add(new JMethod(6321,"forge/game/cost/CostExile","paymentOrder","()I",1,1,2,new JHandler[]{},M6321));
c.Add(new JMethod(6322,"forge/game/cost/CostExile","toString","()Ljava/lang/String;",17,1,2,new JHandler[]{},M6322));
c.Add(new JMethod(6323,"forge/game/cost/CostExile","toString","(I)Ljava/lang/String;",17,7,7,new JHandler[]{},M6323));
c.Add(new JMethod(6324,"forge/game/cost/CostExile","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,21,5,new JHandler[]{},M6324));
c.Add(new JMethod(6325,"forge/game/cost/CostExile","doPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Z)Lforge/game/card/Card;",4,7,4,new JHandler[]{},M6325));
c.Add(new JMethod(6326,"forge/game/cost/CostExile","exileMultiZoneCostString","(ZI)Ljava/lang/String;",1,11,3,new JHandler[]{},M6326));
c.Add(new JMethod(6327,"forge/game/cost/CostExile","getHashForLKIList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6327));
c.Add(new JMethod(6328,"forge/game/cost/CostExile","getHashForCardList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6328));
c.Add(new JMethod(6329,"forge/game/cost/CostExile","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6329));
}

internal static JStep M6315(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","from","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6316(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",9);}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/cost/CostExile","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;Ljava/util/List;I)V","invokespecial",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6317(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",9);}
case 9:{f.Push(f.Locals[5]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/cost/CostExile","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;Ljava/util/List;I)V","invokespecial",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6318(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/cost/CostExile","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;Ljava/util/List;I)V","invokespecial",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6319(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/CostPartWithList","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",11);}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostExile","from","Ljava/util/List;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Reference==null?29:19;continue;}
case 19:{f.Push(f.Locals[5]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[5]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",36);}
case 36:{f.Pc=f.Pop().Int==0?55:39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","from","Ljava/util/List;"));f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{f.Pc=67;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","from","Ljava/util/List;"));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[6]);f.Pc=70;continue;}
case 70:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostExile","zoneRestriction","I",value);f.Pc=73;continue;}
case 73:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6320(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",11);}
case 11:{f.Locals[5]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","zoneRestriction","I"));f.Pc=17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?35:21;continue;}
case 21:{f.Push(f.Locals[5]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","from","Ljava/util/List;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",30);}
case 30:{f.Locals[6]=f.Pop();f.Pc=32;continue;}
case 32:{f.Pc=45;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","from","Ljava/util/List;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",43);}
case 43:{f.Locals[6]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/cost/CostExile","getType","()Ljava/lang/String;","invokevirtual",51);}
case 51:{f.Push(JValue.R(rt.String(";")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",56);}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",63);}
case 63:{f.Locals[6]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[6]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",72);}
case 72:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",75);}
case 75:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6321(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","from","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{f.Pc=f.Pop().Int==0?18:15;continue;}
case 15:{f.Push(JValue.I(20));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 18:{f.Push(JValue.I(15));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6322(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/CostExile","toString","(I)Ljava/lang/String;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6323(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostExile","convertAmount","()Ljava/lang/Integer;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/CostExile","getDescriptiveType","()Ljava/lang/String;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","from","Ljava/util/List;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",19);}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?455:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","from","Ljava/util/List;"));f.Pc=27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/zone/ZoneType","name","()Ljava/lang/String;","invokevirtual",39);}
case 39:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Locals[4]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/cost/CostExile","payCostFromSource","()Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?100:51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.String("battlefield")));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int!=0?83:61;continue;}
case 61:{f.Push(JValue.R(rt.String("Exile %s from your %s")));f.Pc=63;continue;}
case 63:{f.Push(JValue.I(2));f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=67;continue;}
case 67:{f.StackOp("dup");f.Pc=68;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/cost/CostExile","getType","()Ljava/lang/String;","invokevirtual",73);}
case 73:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",82);}
case 82:{return JStep.Return(f.Pop());}
case 83:{f.Push(JValue.R(rt.String("Exile %s")));f.Pc=85;continue;}
case 85:{f.Push(JValue.I(1));f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=89;continue;}
case 89:{f.StackOp("dup");f.Pc=90;continue;}
case 90:{f.Push(JValue.I(0));f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/cost/CostExile","getType","()Ljava/lang/String;","invokevirtual",95);}
case 95:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",99);}
case 99:{return JStep.Return(f.Pop());}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/cost/CostExile","getType","()Ljava/lang/String;","invokevirtual",104);}
case 104:{f.Push(JValue.R(rt.String("All")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?127:112;continue;}
case 112:{f.Push(JValue.R(rt.String("Exile all cards from your %s")));f.Pc=114;continue;}
case 114:{f.Push(JValue.I(1));f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(JValue.I(0));f.Pc=120;continue;}
case 120:{f.Push(f.Locals[4]);f.Pc=122;continue;}
case 122:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",126);}
case 126:{return JStep.Return(f.Pop());}
case 127:{f.Push(f.Locals[4]);f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.String("battlefield")));f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int==0?221:137;continue;}
case 137:{f.Push(f.Locals[2]);f.Pc=138;continue;}
case 138:{f.Pc=f.Pop().Reference!=null?185:141;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/cost/CostExile","getAmount","()Ljava/lang/String;","invokevirtual",145);}
case 145:{f.Push(JValue.R(rt.String("+")));f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int==0?185:153;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/cost/CostExile","getAmount","()Ljava/lang/String;","invokevirtual",157);}
case 157:{f.Push(JValue.R(rt.String("\\+")));f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",162);}
case 162:{f.Push(JValue.I(0));f.Pc=163;continue;}
case 163:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",167);}
case 167:{f.Locals[6]=f.Pop();f.Pc=169;continue;}
case 169:{f.Push(f.Locals[6]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",174);}
case 174:{f.Push(f.Locals[3]);f.Pc=175;continue;}
case 175:{return rt.DynamicCall(f,"forge/game/cost/CostExile:6323:175:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",180);}
case 180:{f.Locals[5]=f.Pop();f.Pc=182;continue;}
case 182:{f.Pc=196;continue;}
case 185:{f.Push(f.Locals[2]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/cost/CostExile","getAmount","()Ljava/lang/String;","invokevirtual",190);}
case 190:{f.Push(f.Locals[3]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",194);}
case 194:{f.Locals[5]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[5]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[5]);f.Pc=200;continue;}
case 200:{f.Push(JValue.R(rt.String("you control")));f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",205);}
case 205:{f.Pc=f.Pop().Int==0?213:208;continue;}
case 208:{f.Push(JValue.R(rt.String("")));f.Pc=210;continue;}
case 210:{f.Pc=215;continue;}
case 213:{f.Push(JValue.R(rt.String(" you control")));f.Pc=215;continue;}
case 215:{return rt.DynamicCall(f,"forge/game/cost/CostExile:6323:215:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",220);}
case 220:{return JStep.Return(f.Pop());}
case 221:{f.Push(f.Locals[3]);f.Pc=222;continue;}
case 222:{f.Push(JValue.R(rt.String("Card")));f.Pc=224;continue;}
case 224:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",227);}
case 227:{f.Pc=f.Pop().Int!=0?343:230;continue;}
case 230:{f.Push(f.Locals[3]);f.Pc=231;continue;}
case 231:{f.Push(JValue.R(rt.String("card")));f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",236);}
case 236:{f.Pc=f.Pop().Int!=0?343:239;continue;}
case 239:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=242;continue;}
case 242:{f.StackOp("dup");f.Pc=243;continue;}
case 243:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",246);}
case 246:{f.Locals[5]=f.Pop();f.Pc=248;continue;}
case 248:{f.Push(f.Locals[5]);f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.String("Exile %s from ")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",255);}
case 255:{f.StackOp("pop");f.Pc=256;continue;}
case 256:{f.Push(f.Locals[0]);f.Pc=257;continue;}
case 257:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","zoneRestriction","I"));f.Pc=260;continue;}
case 260:{f.Pc=f.Pop().Int!=0?274:263;continue;}
case 263:{f.Push(f.Locals[5]);f.Pc=265;continue;}
case 265:{f.Push(JValue.R(rt.String("the same")));f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",270);}
case 270:{f.StackOp("pop");f.Pc=271;continue;}
case 271:{f.Pc=301;continue;}
case 274:{f.Push(f.Locals[0]);f.Pc=275;continue;}
case 275:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","zoneRestriction","I"));f.Pc=278;continue;}
case 278:{f.Push(JValue.I(-1));f.Pc=279;continue;}
case 279:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?293:282;continue;}
case 282:{f.Push(f.Locals[5]);f.Pc=284;continue;}
case 284:{f.Push(JValue.R(rt.String("a")));f.Pc=286;continue;}
case 286:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",289);}
case 289:{f.StackOp("pop");f.Pc=290;continue;}
case 290:{f.Pc=301;continue;}
case 293:{f.Push(f.Locals[5]);f.Pc=295;continue;}
case 295:{f.Push(JValue.R(rt.String("your")));f.Pc=297;continue;}
case 297:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",300);}
case 300:{f.StackOp("pop");f.Pc=301;continue;}
case 301:{f.Push(f.Locals[5]);f.Pc=303;continue;}
case 303:{f.Push(JValue.R(rt.String(" %s")));f.Pc=305;continue;}
case 305:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",308);}
case 308:{f.StackOp("pop");f.Pc=309;continue;}
case 309:{f.Push(f.Locals[5]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",314);}
case 314:{f.Push(JValue.I(2));f.Pc=315;continue;}
case 315:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=318;continue;}
case 318:{f.StackOp("dup");f.Pc=319;continue;}
case 319:{f.Push(JValue.I(0));f.Pc=320;continue;}
case 320:{f.Push(f.Locals[0]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/cost/CostExile","getAmount","()Ljava/lang/String;","invokevirtual",324);}
case 324:{f.Push(f.Locals[3]);f.Pc=325;continue;}
case 325:{return rt.DynamicCall(f,"forge/game/cost/CostExile:6323:325:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",330);}
case 330:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",333);}
case 333:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=334;continue;}
case 334:{f.StackOp("dup");f.Pc=335;continue;}
case 335:{f.Push(JValue.I(1));f.Pc=336;continue;}
case 336:{f.Push(f.Locals[4]);f.Pc=338;continue;}
case 338:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=339;continue;}
case 339:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",342);}
case 342:{return JStep.Return(f.Pop());}
case 343:{f.Push(f.Locals[0]);f.Pc=344;continue;}
case 344:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","zoneRestriction","I"));f.Pc=347;continue;}
case 347:{f.Pc=f.Pop().Int!=0?377:350;continue;}
case 350:{f.Push(JValue.R(rt.String("Exile %s from the same %s")));f.Pc=352;continue;}
case 352:{f.Push(JValue.I(2));f.Pc=353;continue;}
case 353:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=356;continue;}
case 356:{f.StackOp("dup");f.Pc=357;continue;}
case 357:{f.Push(JValue.I(0));f.Pc=358;continue;}
case 358:{f.Push(f.Locals[2]);f.Pc=359;continue;}
case 359:{f.Push(f.Locals[0]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/cost/CostExile","getAmount","()Ljava/lang/String;","invokevirtual",363);}
case 363:{f.Push(f.Locals[3]);f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",367);}
case 367:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=368;continue;}
case 368:{f.StackOp("dup");f.Pc=369;continue;}
case 369:{f.Push(JValue.I(1));f.Pc=370;continue;}
case 370:{f.Push(f.Locals[4]);f.Pc=372;continue;}
case 372:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=373;continue;}
case 373:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",376);}
case 376:{return JStep.Return(f.Pop());}
case 377:{f.Push(f.Locals[0]);f.Pc=378;continue;}
case 378:{return rt.Call(f,"forge/game/cost/CostExile","getAmount","()Ljava/lang/String;","invokevirtual",381);}
case 381:{f.Push(JValue.R(rt.String("X")));f.Pc=383;continue;}
case 383:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",386);}
case 386:{f.Pc=f.Pop().Int==0?428:389;continue;}
case 389:{f.Push(f.Locals[1]);f.Pc=390;continue;}
case 390:{f.Pc=f.Pop().Int<=0?400:393;continue;}
case 393:{f.Push(f.Locals[1]);f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",397);}
case 397:{f.Pc=402;continue;}
case 400:{f.Push(JValue.R(rt.String("any number of")));f.Pc=402;continue;}
case 402:{f.Locals[5]=f.Pop();f.Pc=404;continue;}
case 404:{f.Push(JValue.R(rt.String("Exile %s %s from your %s")));f.Pc=406;continue;}
case 406:{f.Push(JValue.I(3));f.Pc=407;continue;}
case 407:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=410;continue;}
case 410:{f.StackOp("dup");f.Pc=411;continue;}
case 411:{f.Push(JValue.I(0));f.Pc=412;continue;}
case 412:{f.Push(f.Locals[5]);f.Pc=414;continue;}
case 414:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=415;continue;}
case 415:{f.StackOp("dup");f.Pc=416;continue;}
case 416:{f.Push(JValue.I(1));f.Pc=417;continue;}
case 417:{f.Push(f.Locals[3]);f.Pc=418;continue;}
case 418:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=419;continue;}
case 419:{f.StackOp("dup");f.Pc=420;continue;}
case 420:{f.Push(JValue.I(2));f.Pc=421;continue;}
case 421:{f.Push(f.Locals[4]);f.Pc=423;continue;}
case 423:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=424;continue;}
case 424:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",427);}
case 427:{return JStep.Return(f.Pop());}
case 428:{f.Push(JValue.R(rt.String("Exile %s from your %s")));f.Pc=430;continue;}
case 430:{f.Push(JValue.I(2));f.Pc=431;continue;}
case 431:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=434;continue;}
case 434:{f.StackOp("dup");f.Pc=435;continue;}
case 435:{f.Push(JValue.I(0));f.Pc=436;continue;}
case 436:{f.Push(f.Locals[2]);f.Pc=437;continue;}
case 437:{f.Push(f.Locals[0]);f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/game/cost/CostExile","getAmount","()Ljava/lang/String;","invokevirtual",441);}
case 441:{f.Push(f.Locals[3]);f.Pc=442;continue;}
case 442:{return rt.Call(f,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",445);}
case 445:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=446;continue;}
case 446:{f.StackOp("dup");f.Pc=447;continue;}
case 447:{f.Push(JValue.I(1));f.Pc=448;continue;}
case 448:{f.Push(f.Locals[4]);f.Pc=450;continue;}
case 450:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=451;continue;}
case 451:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",454);}
case 454:{return JStep.Return(f.Pop());}
case 455:{f.Push(f.Locals[0]);f.Pc=456;continue;}
case 456:{f.Push(JValue.I(0));f.Pc=457;continue;}
case 457:{f.Push(f.Locals[1]);f.Pc=458;continue;}
case 458:{return rt.Call(f,"forge/game/cost/CostExile","exileMultiZoneCostString","(ZI)Ljava/lang/String;","invokevirtual",461);}
case 461:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6324(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",11);}
case 11:{f.Locals[5]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/cost/CostExile","getType","()Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Locals[6]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[6]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("All")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int==0?31:29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 31:{f.Push(f.Locals[6]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("FromTopGrave")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?52:41;continue;}
case 41:{f.Push(f.Locals[6]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("FromTopGrave")));f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",50);}
case 50:{f.Locals[6]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","zoneRestriction","I"));f.Pc=56;continue;}
case 56:{f.Push(JValue.I(1));f.Pc=57;continue;}
case 57:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?72:60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","from","Ljava/util/List;"));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",69);}
case 69:{f.Pc=80;continue;}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","from","Ljava/util/List;"));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",80);}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[3]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/card/CardPredicates","canExiledBy","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;","invokestatic",85);}
case 85:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",88);}
case 88:{f.Locals[7]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/cost/CostExile","payCostFromSource","()Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?105:97;continue;}
case 97:{f.Push(f.Locals[7]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[4]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",104);}
case 104:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/cost/CostExile","getType","()Ljava/lang/String;","invokevirtual",109);}
case 109:{f.Push(JValue.R(rt.String("OriginalHost")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?127:117;continue;}
case 117:{f.Push(f.Locals[7]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",123);}
case 123:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",126);}
case 126:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 127:{f.Push(JValue.I(0));f.Pc=128;continue;}
case 128:{f.Locals[8]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("")));f.Pc=132;continue;}
case 132:{f.Locals[9]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[6]);f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.String("+withTotalCMCEQ")));f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",141);}
case 141:{f.Pc=f.Pop().Int==0?184:144;continue;}
case 144:{f.Push(JValue.I(1));f.Pc=145;continue;}
case 145:{f.Locals[8]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[6]);f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String("withTotalCMCEQ")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",154);}
case 154:{f.Push(JValue.I(1));f.Pc=155;continue;}
case 155:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=156;continue;}
case 156:{f.Locals[9]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[6]);f.Pc=160;continue;}
case 160:{f.Push(JValue.I(2));f.Pc=161;continue;}
case 161:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=164;continue;}
case 164:{f.StackOp("dup");f.Pc=165;continue;}
case 165:{f.Push(JValue.I(0));f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("+withTotalCMCEQ")));f.Pc=168;continue;}
case 168:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=169;continue;}
case 169:{f.StackOp("dup");f.Pc=170;continue;}
case 170:{f.Push(JValue.I(1));f.Pc=171;continue;}
case 171:{f.Push(f.Locals[9]);f.Pc=173;continue;}
case 173:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",177);}
case 177:{f.Push(JValue.R(rt.String("")));f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",182);}
case 182:{f.Locals[6]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(JValue.I(0));f.Pc=185;continue;}
case 185:{f.Locals[10]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[6]);f.Pc=189;continue;}
case 189:{f.Push(JValue.R(rt.String("+withTotalCMCGE")));f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",195);}
case 195:{f.Pc=f.Pop().Int==0?240:198;continue;}
case 198:{f.Push(JValue.I(1));f.Pc=199;continue;}
case 199:{f.Locals[10]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[6]);f.Pc=203;continue;}
case 203:{f.Push(JValue.R(rt.String("withTotalCMCGE")));f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",209);}
case 209:{f.Push(JValue.I(1));f.Pc=210;continue;}
case 210:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=211;continue;}
case 211:{f.Locals[9]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[6]);f.Pc=215;continue;}
case 215:{f.Push(JValue.I(2));f.Pc=216;continue;}
case 216:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=219;continue;}
case 219:{f.StackOp("dup");f.Pc=220;continue;}
case 220:{f.Push(JValue.I(0));f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String("+withTotalCMCGE")));f.Pc=224;continue;}
case 224:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=225;continue;}
case 225:{f.StackOp("dup");f.Pc=226;continue;}
case 226:{f.Push(JValue.I(1));f.Pc=227;continue;}
case 227:{f.Push(f.Locals[9]);f.Pc=229;continue;}
case 229:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",233);}
case 233:{f.Push(JValue.R(rt.String("")));f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",238);}
case 238:{f.Locals[6]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(JValue.I(0));f.Pc=241;continue;}
case 241:{f.Locals[11]=f.Pop();f.Pc=243;continue;}
case 243:{f.Push(f.Locals[6]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String("+withSharedCardType")));f.Pc=248;continue;}
case 248:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",251);}
case 251:{f.Pc=f.Pop().Int==0?269:254;continue;}
case 254:{f.Push(JValue.I(1));f.Pc=255;continue;}
case 255:{f.Locals[11]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[6]);f.Pc=259;continue;}
case 259:{f.Push(JValue.R(rt.String("+withSharedCardType")));f.Pc=262;continue;}
case 262:{f.Push(JValue.R(rt.String("")));f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",267);}
case 267:{f.Locals[6]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(JValue.I(-1));f.Pc=270;continue;}
case 270:{f.Locals[12]=f.Pop();f.Pc=272;continue;}
case 272:{f.Push(f.Locals[6]);f.Pc=274;continue;}
case 274:{f.Push(JValue.R(rt.String("+withTypesGE")));f.Pc=277;continue;}
case 277:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",280);}
case 280:{f.Pc=f.Pop().Int==0?329:283;continue;}
case 283:{f.Push(f.Locals[6]);f.Pc=285;continue;}
case 285:{f.Push(JValue.R(rt.String("withTypesGE")));f.Pc=288;continue;}
case 288:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",291);}
case 291:{f.Push(JValue.I(1));f.Pc=292;continue;}
case 292:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=293;continue;}
case 293:{f.Locals[13]=f.Pop();f.Pc=295;continue;}
case 295:{f.Push(f.Locals[6]);f.Pc=297;continue;}
case 297:{f.Push(JValue.I(2));f.Pc=298;continue;}
case 298:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=301;continue;}
case 301:{f.StackOp("dup");f.Pc=302;continue;}
case 302:{f.Push(JValue.I(0));f.Pc=303;continue;}
case 303:{f.Push(JValue.R(rt.String("+withTypesGE")));f.Pc=306;continue;}
case 306:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=307;continue;}
case 307:{f.StackOp("dup");f.Pc=308;continue;}
case 308:{f.Push(JValue.I(1));f.Pc=309;continue;}
case 309:{f.Push(f.Locals[13]);f.Pc=311;continue;}
case 311:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",315);}
case 315:{f.Push(JValue.R(rt.String("")));f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",320);}
case 320:{f.Locals[6]=f.Pop();f.Pc=322;continue;}
case 322:{f.Push(f.Locals[13]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",327);}
case 327:{f.Locals[12]=f.Pop();f.Pc=329;continue;}
case 329:{f.Push(f.Locals[6]);f.Pc=331;continue;}
case 331:{f.Push(JValue.R(rt.String("X")));f.Pc=333;continue;}
case 333:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",336);}
case 336:{f.Pc=f.Pop().Int==0?346:339;continue;}
case 339:{f.Push(f.Locals[1]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/game/spellability/SpellAbility","getXManaCostPaid","()Ljava/lang/Integer;","invokevirtual",343);}
case 343:{f.Pc=f.Pop().Reference==null?364:346;continue;}
case 346:{f.Push(f.Locals[7]);f.Pc=348;continue;}
case 348:{f.Push(f.Locals[6]);f.Pc=350;continue;}
case 350:{f.Push(JValue.R(rt.String(";")));f.Pc=352;continue;}
case 352:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",355);}
case 355:{f.Push(f.Locals[2]);f.Pc=356;continue;}
case 356:{f.Push(f.Locals[4]);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[1]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",362);}
case 362:{f.Locals[7]=f.Pop();f.Pc=364;continue;}
case 364:{f.Push(f.Locals[12]);f.Pc=366;continue;}
case 366:{f.Push(JValue.I(-1));f.Pc=367;continue;}
case 367:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?383:370;continue;}
case 370:{f.Push(f.Locals[7]);f.Pc=372;continue;}
case 372:{f.Push(JValue.I(0));f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/ability/AbilityUtils","countCardTypesFromList","(Ljava/lang/Iterable;Z)I","invokestatic",376);}
case 376:{f.Push(f.Locals[12]);f.Pc=378;continue;}
case 378:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?383:381;continue;}
case 381:{f.Push(JValue.I(0));f.Pc=382;continue;}
case 382:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 383:{f.Push(f.Locals[8]);f.Pc=385;continue;}
case 385:{f.Pc=f.Pop().Int!=0?393:388;continue;}
case 388:{f.Push(f.Locals[10]);f.Pc=390;continue;}
case 390:{f.Pc=f.Pop().Int==0?453:393;continue;}
case 393:{f.Push(f.Locals[9]);f.Pc=395;continue;}
case 395:{f.Push(JValue.R(rt.String("X")));f.Pc=397;continue;}
case 397:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",400);}
case 400:{f.Pc=f.Pop().Int==0?412:403;continue;}
case 403:{f.Push(f.Locals[1]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/spellability/SpellAbility","getXManaCostPaid","()Ljava/lang/Integer;","invokevirtual",407);}
case 407:{f.Pc=f.Pop().Reference!=null?412:410;continue;}
case 410:{f.Push(JValue.I(1));f.Pc=411;continue;}
case 411:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 412:{f.Push(f.Locals[4]);f.Pc=414;continue;}
case 414:{f.Push(f.Locals[9]);f.Pc=416;continue;}
case 416:{f.Push(f.Locals[1]);f.Pc=417;continue;}
case 417:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",420);}
case 420:{f.Locals[13]=f.Pop();f.Pc=422;continue;}
case 422:{f.Push(f.Locals[10]);f.Pc=424;continue;}
case 424:{f.Pc=f.Pop().Int==0?445:427;continue;}
case 427:{f.Push(f.Locals[7]);f.Pc=429;continue;}
case 429:{return rt.Call(f,"forge/game/card/CardLists","getTotalCMC","(Ljava/lang/Iterable;)I","invokestatic",432);}
case 432:{f.Push(f.Locals[13]);f.Pc=434;continue;}
case 434:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?441:437;continue;}
case 437:{f.Push(JValue.I(1));f.Pc=438;continue;}
case 438:{f.Pc=452;continue;}
case 441:{f.Push(JValue.I(0));f.Pc=442;continue;}
case 442:{f.Pc=452;continue;}
case 445:{f.Push(f.Locals[13]);f.Pc=447;continue;}
case 447:{f.Push(f.Locals[7]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/game/card/CardLists","cmcCanSumTo","(ILjava/lang/Iterable;)Z","invokestatic",452);}
case 452:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 453:{f.Push(f.Locals[0]);f.Pc=454;continue;}
case 454:{f.Push(f.Locals[1]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/cost/CostExile","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",458);}
case 458:{f.Locals[13]=f.Pop();f.Pc=460;continue;}
case 460:{f.Push(f.Locals[11]);f.Pc=462;continue;}
case 462:{f.Pc=f.Pop().Int==0?574:465;continue;}
case 465:{f.Push(f.Locals[7]);f.Pc=467;continue;}
case 467:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",470);}
case 470:{f.Push(f.Locals[13]);f.Pc=472;continue;}
case 472:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?477:475;continue;}
case 475:{f.Push(JValue.I(0));f.Pc=476;continue;}
case 476:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 477:{return rt.Call(f,"forge/card/CardType$CoreType","values","()[Lforge/card/CardType$CoreType;","invokestatic",480);}
case 480:{f.Locals[14]=f.Pop();f.Pc=482;continue;}
case 482:{f.Push(f.Locals[14]);f.Pc=484;continue;}
case 484:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=485;continue;}
case 485:{f.Locals[15]=f.Pop();f.Pc=487;continue;}
case 487:{f.Push(JValue.I(0));f.Pc=488;continue;}
case 488:{f.Locals[16]=f.Pop();f.Pc=490;continue;}
case 490:{f.Push(f.Locals[16]);f.Pc=492;continue;}
case 492:{f.Push(f.Locals[15]);f.Pc=494;continue;}
case 494:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?572:497;continue;}
case 497:{f.Push(f.Locals[14]);f.Pc=499;continue;}
case 499:{f.Push(f.Locals[16]);f.Pc=501;continue;}
case 501:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=502;continue;}
case 502:{f.Locals[17]=f.Pop();f.Pc=504;continue;}
case 504:{f.Push(JValue.I(0));f.Pc=505;continue;}
case 505:{f.Locals[18]=f.Pop();f.Pc=507;continue;}
case 507:{f.Push(f.Locals[7]);f.Pc=509;continue;}
case 509:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",512);}
case 512:{f.Locals[19]=f.Pop();f.Pc=514;continue;}
case 514:{f.Push(f.Locals[19]);f.Pc=516;continue;}
case 516:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",521);}
case 521:{f.Pc=f.Pop().Int==0?566:524;continue;}
case 524:{f.Push(f.Locals[19]);f.Pc=526;continue;}
case 526:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",531);}
case 531:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=534;continue;}
case 534:{f.Locals[20]=f.Pop();f.Pc=536;continue;}
case 536:{f.Push(f.Locals[20]);f.Pc=538;continue;}
case 538:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",541);}
case 541:{f.Push(f.Locals[17]);f.Pc=543;continue;}
case 543:{return rt.Call(f,"forge/card/CardTypeView","hasType","(Lforge/card/CardType$CoreType;)Z","invokeinterface",548);}
case 548:{f.Pc=f.Pop().Int==0?563:551;continue;}
case 551:{f.Locals[18]=JValue.I(unchecked(f.Locals[18].Int+(1)));f.Pc=554;continue;}
case 554:{f.Push(f.Locals[18]);f.Pc=556;continue;}
case 556:{f.Push(f.Locals[13]);f.Pc=558;continue;}
case 558:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?563:561;continue;}
case 561:{f.Push(JValue.I(1));f.Pc=562;continue;}
case 562:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 563:{f.Pc=514;continue;}
case 566:{f.Locals[16]=JValue.I(unchecked(f.Locals[16].Int+(1)));f.Pc=569;continue;}
case 569:{f.Pc=490;continue;}
case 572:{f.Push(JValue.I(0));f.Pc=573;continue;}
case 573:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 574:{f.Push(f.Locals[1]);f.Pc=575;continue;}
case 575:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCraft","()Z","invokevirtual",578);}
case 578:{f.Pc=f.Pop().Int==0?618:581;continue;}
case 581:{f.Push(f.Locals[1]);f.Pc=582;continue;}
case 582:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",585);}
case 585:{f.Push(JValue.R(rt.ClassObject("forge/game/cost/CostExile")));f.Pc=587;continue;}
case 587:{return rt.Call(f,"forge/game/cost/Cost","getCostPartByType","(Ljava/lang/Class;)Lforge/game/cost/CostPart;","invokevirtual",590);}
case 590:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostExile"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=593;continue;}
case 593:{f.Locals[14]=f.Pop();f.Pc=595;continue;}
case 595:{f.Push(f.Locals[14]);f.Pc=597;continue;}
case 597:{f.Pc=f.Pop().Reference==null?618:600;continue;}
case 600:{f.Push(f.Locals[14]);f.Pc=602;continue;}
case 602:{return rt.Call(f,"forge/game/cost/CostExile","payCostFromSource","()Z","invokevirtual",605);}
case 605:{f.Pc=f.Pop().Int==0?618:608;continue;}
case 608:{f.Push(f.Locals[7]);f.Pc=610;continue;}
case 610:{f.Push(f.Locals[1]);f.Pc=611;continue;}
case 611:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",614);}
case 614:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",617);}
case 617:{f.StackOp("pop");f.Pc=618;continue;}
case 618:{f.Push(f.Locals[0]);f.Pc=619;continue;}
case 619:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","from","Ljava/util/List;"));f.Pc=622;continue;}
case 622:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",627);}
case 627:{f.Push(JValue.I(1));f.Pc=628;continue;}
case 628:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?677:631;continue;}
case 631:{f.Push(f.Locals[0]);f.Pc=632;continue;}
case 632:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","from","Ljava/util/List;"));f.Pc=635;continue;}
case 635:{f.Push(JValue.I(0));f.Pc=636;continue;}
case 636:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",641);}
case 641:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=644;continue;}
case 644:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=647;continue;}
case 647:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",650);}
case 650:{f.Pc=f.Pop().Int==0?677:653;continue;}
case 653:{f.Push(f.Locals[4]);f.Pc=655;continue;}
case 655:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=658;continue;}
case 658:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",661);}
case 661:{f.Pc=f.Pop().Int==0?677:664;continue;}
case 664:{f.Push(f.Locals[7]);f.Pc=666;continue;}
case 666:{f.Push(f.Locals[4]);f.Pc=668;continue;}
case 668:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",671);}
case 671:{f.Pc=f.Pop().Int==0?677:674;continue;}
case 674:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(1)));f.Pc=677;continue;}
case 677:{f.Push(f.Locals[7]);f.Pc=679;continue;}
case 679:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",682);}
case 682:{f.Push(f.Locals[13]);f.Pc=684;continue;}
case 684:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?689:687;continue;}
case 687:{f.Push(JValue.I(0));f.Pc=688;continue;}
case 688:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 689:{f.Push(f.Locals[0]);f.Pc=690;continue;}
case 690:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","zoneRestriction","I"));f.Pc=693;continue;}
case 693:{f.Pc=f.Pop().Int!=0?764:696;continue;}
case 696:{f.Push(JValue.I(0));f.Pc=697;continue;}
case 697:{f.Locals[14]=f.Pop();f.Pc=699;continue;}
case 699:{f.Push(f.Locals[5]);f.Pc=701;continue;}
case 701:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",704);}
case 704:{f.Locals[15]=f.Pop();f.Pc=706;continue;}
case 706:{f.Push(f.Locals[15]);f.Pc=708;continue;}
case 708:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",713);}
case 713:{f.Locals[16]=f.Pop();f.Pc=715;continue;}
case 715:{f.Push(f.Locals[16]);f.Pc=717;continue;}
case 717:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",722);}
case 722:{f.Pc=f.Pop().Int==0?761:725;continue;}
case 725:{f.Push(f.Locals[16]);f.Pc=727;continue;}
case 727:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",732);}
case 732:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=735;continue;}
case 735:{f.Locals[17]=f.Pop();f.Pc=737;continue;}
case 737:{f.Push(f.Locals[7]);f.Pc=739;continue;}
case 739:{f.Push(f.Locals[17]);f.Pc=741;continue;}
case 741:{return rt.Call(f,"forge/game/card/CardPredicates","isController","(Lforge/game/player/Player;)Ljava/util/function/Predicate;","invokestatic",744);}
case 744:{return rt.Call(f,"forge/game/card/CardLists","count","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I","invokestatic",747);}
case 747:{f.Push(f.Locals[13]);f.Pc=749;continue;}
case 749:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?758:752;continue;}
case 752:{f.Push(JValue.I(1));f.Pc=753;continue;}
case 753:{f.Locals[14]=f.Pop();f.Pc=755;continue;}
case 755:{f.Pc=761;continue;}
case 758:{f.Pc=715;continue;}
case 761:{f.Push(f.Locals[14]);f.Pc=763;continue;}
case 763:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 764:{f.Push(JValue.I(1));f.Pc=765;continue;}
case 765:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6325(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",3);}
case 3:{f.Locals[5]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[5]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","table","Lforge/game/card/CardZoneTable;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",14);}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",21);}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(null));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",28);}
case 28:{f.Locals[6]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[6]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",36);}
case 36:{f.Push(f.Locals[6]);f.Pc=38;continue;}
case 38:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6326(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Exile ")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/cost/CostExile","getAmount","()Ljava/lang/String;","invokevirtual",20);}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",27);}
case 27:{f.Pc=f.Pop().Int==0?38:30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",35);}
case 35:{f.Pc=39;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/cost/CostExile","getType","()Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Locals[6]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[6]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String(".Other")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int==0?70:58;continue;}
case 58:{f.Push(f.Locals[6]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String(".Other")));f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",68);}
case 68:{f.Locals[6]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/cost/CostExile","getTypeDescription","()Ljava/lang/String;","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Reference==null?84:77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/cost/CostExile","getTypeDescription","()Ljava/lang/String;","invokevirtual",81);}
case 81:{f.Pc=113;continue;}
case 84:{f.Push(f.Locals[6]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/card/CardType$CoreType","isValidEnum","(Ljava/lang/String;)Z","invokestatic",89);}
case 89:{f.Pc=f.Pop().Int!=0?103:92;continue;}
case 92:{f.Push(f.Locals[6]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int==0?111:103;continue;}
case 103:{f.Push(f.Locals[6]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",108);}
case 108:{f.Pc=113;continue;}
case 111:{f.Push(f.Locals[6]);f.Pc=113;continue;}
case 113:{f.Locals[7]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[7]);f.Pc=117;continue;}
case 117:{f.Push(JValue.R(rt.String(" ")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",123);}
case 123:{f.Pc=f.Pop().Int!=0?134:126;continue;}
case 126:{f.Push(f.Locals[7]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/util/Lang","getPlural","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",131);}
case 131:{f.Pc=136;continue;}
case 134:{f.Push(f.Locals[7]);f.Pc=136;continue;}
case 136:{f.Locals[8]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Pc=f.Pop().Int!=0?154:142;continue;}
case 142:{f.Push(f.Locals[5]);f.Pc=144;continue;}
case 144:{f.Pc=f.Pop().Int!=0?154:147;continue;}
case 147:{f.Push(f.Locals[2]);f.Pc=148;continue;}
case 148:{f.Pc=f.Pop().Int<=0?154:151;continue;}
case 151:{f.Push(f.Locals[2]);f.Pc=152;continue;}
case 152:{f.Locals[5]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[7]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String("permanent")));f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",162);}
case 162:{f.Locals[9]=f.Pop();f.Pc=164;continue;}
case 164:{f.Push(f.Locals[5]);f.Pc=166;continue;}
case 166:{f.Push(JValue.I(1));f.Pc=167;continue;}
case 167:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?233:170;continue;}
case 170:{f.Push(JValue.I(1));f.Pc=171;continue;}
case 171:{f.Push(f.Locals[7]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",176);}
case 176:{f.Locals[10]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[3]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[6]);f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.String("Artifact")));f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",187);}
case 187:{f.Pc=f.Pop().Int!=0?195:190;continue;}
case 190:{f.Push(f.Locals[9]);f.Pc=192;continue;}
case 192:{f.Pc=f.Pop().Int==0?205:195;continue;}
case 195:{f.Push(f.Locals[7]);f.Pc=197;continue;}
case 197:{return rt.DynamicCall(f,"forge/game/cost/CostExile:6326:197:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",202);}
case 202:{f.Pc=207;continue;}
case 205:{f.Push(f.Locals[10]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",210);}
case 210:{f.StackOp("pop");f.Pc=211;continue;}
case 211:{f.Push(f.Locals[3]);f.Pc=212;continue;}
case 212:{f.Push(JValue.R(rt.String(" you control or ")));f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",218);}
case 218:{f.Push(f.Locals[10]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",223);}
case 223:{f.Push(JValue.R(rt.String(" card from ")));f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",229);}
case 229:{f.StackOp("pop");f.Pc=230;continue;}
case 230:{f.Pc=468;continue;}
case 233:{f.Push(f.Locals[5]);f.Pc=235;continue;}
case 235:{f.Push(JValue.I(1));f.Pc=236;continue;}
case 236:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?306:239;continue;}
case 239:{f.Push(f.Locals[3]);f.Pc=240;continue;}
case 240:{f.Push(JValue.R(rt.String("the ")));f.Pc=243;continue;}
case 243:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",246);}
case 246:{f.Push(f.Locals[5]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",251);}
case 251:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",254);}
case 254:{f.Push(JValue.R(rt.String(" from among ")));f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",260);}
case 260:{f.StackOp("pop");f.Pc=261;continue;}
case 261:{f.Push(f.Locals[3]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[9]);f.Pc=264;continue;}
case 264:{f.Pc=f.Pop().Int==0?273:267;continue;}
case 267:{f.Push(JValue.R(rt.String("other ")));f.Pc=270;continue;}
case 270:{f.Pc=275;continue;}
case 273:{f.Push(JValue.R(rt.String("")));f.Pc=275;continue;}
case 275:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",278);}
case 278:{f.Push(f.Locals[8]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",283);}
case 283:{f.Push(JValue.R(rt.String(" you control and/or ")));f.Pc=286;continue;}
case 286:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",289);}
case 289:{f.Push(f.Locals[7]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",294);}
case 294:{f.StackOp("pop");f.Pc=295;continue;}
case 295:{f.Push(f.Locals[3]);f.Pc=296;continue;}
case 296:{f.Push(JValue.R(rt.String(" cards in ")));f.Pc=299;continue;}
case 299:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",302);}
case 302:{f.StackOp("pop");f.Pc=303;continue;}
case 303:{f.Pc=468;continue;}
case 306:{f.Push(f.Locals[3]);f.Pc=307;continue;}
case 307:{f.Push(f.Locals[2]);f.Pc=308;continue;}
case 308:{f.Push(JValue.I(1));f.Pc=309;continue;}
case 309:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?318:312;continue;}
case 312:{f.Push(JValue.R(rt.String("the ")));f.Pc=315;continue;}
case 315:{f.Pc=320;continue;}
case 318:{f.Push(JValue.R(rt.String("")));f.Pc=320;continue;}
case 320:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",323);}
case 323:{f.Push(f.Locals[2]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",327);}
case 327:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",330);}
case 330:{f.Push(f.Locals[1]);f.Pc=331;continue;}
case 331:{f.Pc=f.Pop().Int==0?340:334;continue;}
case 334:{f.Push(JValue.R(rt.String(" or more ")));f.Pc=337;continue;}
case 337:{f.Pc=343;continue;}
case 340:{f.Push(JValue.R(rt.String(" ")));f.Pc=343;continue;}
case 343:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",346);}
case 346:{f.StackOp("pop");f.Pc=347;continue;}
case 347:{f.Push(f.Locals[2]);f.Pc=348;continue;}
case 348:{f.Push(JValue.I(1));f.Pc=349;continue;}
case 349:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?407:352;continue;}
case 352:{f.Push(f.Locals[3]);f.Pc=353;continue;}
case 353:{f.Push(f.Locals[9]);f.Pc=355;continue;}
case 355:{f.Pc=f.Pop().Int==0?364:358;continue;}
case 358:{f.Push(JValue.R(rt.String("other ")));f.Pc=361;continue;}
case 361:{f.Pc=366;continue;}
case 364:{f.Push(JValue.R(rt.String("")));f.Pc=366;continue;}
case 366:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",369);}
case 369:{f.Push(f.Locals[8]);f.Pc=371;continue;}
case 371:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",374);}
case 374:{f.Push(JValue.R(rt.String(" you control and/or ")));f.Pc=377;continue;}
case 377:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",380);}
case 380:{f.StackOp("pop");f.Pc=381;continue;}
case 381:{f.Push(f.Locals[3]);f.Pc=382;continue;}
case 382:{f.Push(f.Locals[9]);f.Pc=384;continue;}
case 384:{f.Pc=f.Pop().Int!=0?392:387;continue;}
case 387:{f.Push(f.Locals[7]);f.Pc=389;continue;}
case 389:{f.Pc=394;continue;}
case 392:{f.Push(JValue.R(rt.String("")));f.Pc=394;continue;}
case 394:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",397);}
case 397:{f.Push(JValue.R(rt.String(" cards from ")));f.Pc=400;continue;}
case 400:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",403);}
case 403:{f.StackOp("pop");f.Pc=404;continue;}
case 404:{f.Pc=468;continue;}
case 407:{f.Push(f.Locals[0]);f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/game/cost/CostExile","getFrom","()Ljava/util/List;","invokevirtual",411);}
case 411:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",416);}
case 416:{f.Push(JValue.I(1));f.Pc=417;continue;}
case 417:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?460:420;continue;}
case 420:{f.Push(f.Locals[3]);f.Pc=421;continue;}
case 421:{f.Push(JValue.R(rt.String("from among ")));f.Pc=424;continue;}
case 424:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",427);}
case 427:{f.Push(f.Locals[9]);f.Pc=429;continue;}
case 429:{f.Pc=f.Pop().Int==0?438:432;continue;}
case 432:{f.Push(JValue.R(rt.String("other ")));f.Pc=435;continue;}
case 435:{f.Pc=440;continue;}
case 438:{f.Push(JValue.R(rt.String("")));f.Pc=440;continue;}
case 440:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",443);}
case 443:{f.Push(f.Locals[8]);f.Pc=445;continue;}
case 445:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",448);}
case 448:{f.StackOp("pop");f.Pc=449;continue;}
case 449:{f.Push(f.Locals[3]);f.Pc=450;continue;}
case 450:{f.Push(JValue.R(rt.String(" you control and/or cards from ")));f.Pc=453;continue;}
case 453:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",456);}
case 456:{f.StackOp("pop");f.Pc=457;continue;}
case 457:{f.Pc=468;continue;}
case 460:{f.Push(f.Locals[3]);f.Pc=461;continue;}
case 461:{f.Push(JValue.R(rt.String("from ")));f.Pc=464;continue;}
case 464:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",467);}
case 467:{f.StackOp("pop");f.Pc=468;continue;}
case 468:{f.Push(f.Locals[3]);f.Pc=469;continue;}
case 469:{f.Push(JValue.R(rt.String("your graveyard")));f.Pc=472;continue;}
case 472:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",475);}
case 475:{f.StackOp("pop");f.Pc=476;continue;}
case 476:{f.Push(f.Locals[3]);f.Pc=477;continue;}
case 477:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",480);}
case 480:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6327(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Exiled")));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6328(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("ExiledCards")));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6329(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostExile;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
