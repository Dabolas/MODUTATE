// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C556{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostReveal","forge/game/cost/CostPartWithList",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("revealFrom","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(6551,"forge/game/cost/CostReveal","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",1,4,5,new JHandler[]{},M6551));
c.Add(new JMethod(6552,"forge/game/cost/CostReveal","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",1,5,5,new JHandler[]{},M6552));
c.Add(new JMethod(6553,"forge/game/cost/CostReveal","isReusable","()Z",1,1,1,new JHandler[]{},M6553));
c.Add(new JMethod(6554,"forge/game/cost/CostReveal","isRenewable","()Z",1,1,1,new JHandler[]{},M6554));
c.Add(new JMethod(6555,"forge/game/cost/CostReveal","getRevealFrom","()Ljava/util/List;",1,1,1,new JHandler[]{},M6555));
c.Add(new JMethod(6556,"forge/game/cost/CostReveal","getMaxAmountX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;",1,7,5,new JHandler[]{},M6556));
c.Add(new JMethod(6557,"forge/game/cost/CostReveal","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",1,9,5,new JHandler[]{},M6557));
c.Add(new JMethod(6558,"forge/game/cost/CostReveal","toString","()Ljava/lang/String;",1,4,4,new JHandler[]{},M6558));
c.Add(new JMethod(6559,"forge/game/cost/CostReveal","doPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Z)Lforge/game/card/Card;",4,6,5,new JHandler[]{},M6559));
c.Add(new JMethod(6560,"forge/game/cost/CostReveal","canPayListAtOnce","()Z",4,1,1,new JHandler[]{},M6560));
c.Add(new JMethod(6561,"forge/game/cost/CostReveal","doListPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;Z)Lforge/game/card/CardCollectionView;",4,5,3,new JHandler[]{},M6561));
c.Add(new JMethod(6562,"forge/game/cost/CostReveal","getHashForLKIList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6562));
c.Add(new JMethod(6563,"forge/game/cost/CostReveal","getHashForCardList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6563));
c.Add(new JMethod(6564,"forge/game/cost/CostReveal","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6564));
c.Add(new JMethod(6565,"forge/game/cost/CostReveal","paymentOrder","()I",1,1,2,new JHandler[]{},M6565));
}

internal static JStep M6551(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/CostPartWithList","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.NewArray("Lforge/game/zone/ZoneType;",f.Pop().Int)));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=17;continue;}
case 17:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",21);}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostReveal","revealFrom","Ljava/util/List;",value);f.Pc=24;continue;}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6552(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/CostPartWithList","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.NewArray("Lforge/game/zone/ZoneType;",f.Pop().Int)));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=17;continue;}
case 17:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",21);}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostReveal","revealFrom","Ljava/util/List;",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",30);}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostReveal","revealFrom","Ljava/util/List;",value);f.Pc=33;continue;}
case 33:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6553(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6554(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6555(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostReveal","revealFrom","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6556(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostReveal","revealFrom","Ljava/util/List;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",14);}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?46:23;continue;}
case 23:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[5]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",32);}
case 32:{f.Locals[6]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[6]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[6]);f.Pc=44;continue;}
case 44:{f.Locals[5]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/cost/CostReveal","getType","()Ljava/lang/String;","invokevirtual",52);}
case 52:{f.Push(JValue.R(rt.String(";")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",57);}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",64);}
case 64:{f.Locals[5]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",73);}
case 73:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",76);}
case 76:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6557(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostReveal","revealFrom","Ljava/util/List;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",14);}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/cost/CostReveal","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",21);}
case 21:{f.Locals[6]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/cost/CostReveal","payCostFromSource","()Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?48:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostReveal","revealFrom","Ljava/util/List;"));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","getLastKnownZone","()Lforge/game/zone/Zone;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",42);}
case 42:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",47);}
case 47:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/cost/CostReveal","getType","()Ljava/lang/String;","invokevirtual",52);}
case 52:{f.Push(JValue.R(rt.String("Hand")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?62:60;continue;}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/cost/CostReveal","getType","()Ljava/lang/String;","invokevirtual",66);}
case 66:{f.Push(JValue.R(rt.String("SameColor")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int==0?127:74;continue;}
case 74:{f.Push(f.Locals[5]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",81);}
case 81:{f.Locals[7]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[7]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",90);}
case 90:{f.Pc=f.Pop().Int==0?125:93;continue;}
case 93:{f.Push(f.Locals[7]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",100);}
case 100:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=103;continue;}
case 103:{f.Locals[8]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[5]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[8]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/card/CardPredicates","sharesColorWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",112);}
case 112:{return rt.Call(f,"forge/game/card/CardLists","count","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I","invokestatic",115);}
case 115:{f.Push(f.Locals[6]);f.Pc=117;continue;}
case 117:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?122:120;continue;}
case 120:{f.Push(JValue.I(1));f.Pc=121;continue;}
case 121:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 122:{f.Pc=83;continue;}
case 125:{f.Push(JValue.I(0));f.Pc=126;continue;}
case 126:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 127:{f.Push(f.Locals[6]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[3]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/cost/CostReveal","getMaxAmountX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;","invokevirtual",136);}
case 136:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",139);}
case 139:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?146:142;continue;}
case 142:{f.Push(JValue.I(1));f.Pc=143;continue;}
case 143:{f.Pc=147;continue;}
case 146:{f.Push(JValue.I(0));f.Pc=147;continue;}
case 147:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6558(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Reveal ")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/cost/CostReveal","convertAmount","()Ljava/lang/Integer;","invokevirtual",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/cost/CostReveal","payCostFromSource","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?39:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/cost/CostReveal","getType","()Ljava/lang/String;","invokevirtual",32);}
case 32:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Pc=148;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/cost/CostReveal","getType","()Ljava/lang/String;","invokevirtual",43);}
case 43:{f.Push(JValue.R(rt.String("Hand")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?54:51;continue;}
case 51:{f.Push(JValue.R(rt.String("Reveal your hand")));f.Pc=53;continue;}
case 53:{return JStep.Return(f.Pop());}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/cost/CostReveal","getType","()Ljava/lang/String;","invokevirtual",58);}
case 58:{f.Push(JValue.R(rt.String("SameColor")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?73:66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{return rt.DynamicCall(f,"forge/game/cost/CostReveal:6558:67:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/Integer;)Ljava/lang/String;",72);}
case 72:{return JStep.Return(f.Pop());}
case 73:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",80);}
case 80:{f.Locals[3]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/cost/CostReveal","getType","()Ljava/lang/String;","invokevirtual",85);}
case 85:{f.Push(JValue.R(rt.String("Card")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?103:93;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("Card")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",99);}
case 99:{f.StackOp("pop");f.Pc=100;continue;}
case 100:{f.Pc=131;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/cost/CostReveal","getTypeDescription","()Ljava/lang/String;","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Reference!=null?118:111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/cost/CostReveal","getType","()Ljava/lang/String;","invokevirtual",115);}
case 115:{f.Pc=122;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/cost/CostReveal","getTypeDescription","()Ljava/lang/String;","invokevirtual",122);}
case 122:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",125);}
case 125:{f.Push(JValue.R(rt.String(" card")));f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",130);}
case 130:{f.StackOp("pop");f.Pc=131;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[2]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/cost/CostReveal","getAmount","()Ljava/lang/String;","invokevirtual",137);}
case 137:{f.Push(f.Locals[3]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",141);}
case 141:{return rt.Call(f,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",144);}
case 144:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",147);}
case 147:{f.StackOp("pop");f.Pc=148;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String(" from your ")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",154);}
case 154:{f.StackOp("pop");f.Pc=155;continue;}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[0]);f.Pc=157;continue;}
case 157:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostReveal","revealFrom","Ljava/util/List;"));f.Pc=160;continue;}
case 160:{f.Push(JValue.I(0));f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",166);}
case 166:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/zone/ZoneType","getTranslatedName","()Ljava/lang/String;","invokevirtual",172);}
case 172:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",175);}
case 175:{f.StackOp("pop");f.Pc=176;continue;}
case 176:{f.Push(f.Locals[0]);f.Pc=177;continue;}
case 177:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostReveal","revealFrom","Ljava/util/List;"));f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",185);}
case 185:{f.Push(JValue.I(1));f.Pc=186;continue;}
case 186:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?251:189;continue;}
case 189:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=192;continue;}
case 192:{f.StackOp("dup");f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",196);}
case 196:{f.Locals[3]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[3]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[0]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/cost/CostReveal","getTypeDescription","()Ljava/lang/String;","invokevirtual",202);}
case 202:{f.Pc=f.Pop().Reference!=null?212:205;continue;}
case 205:{f.Push(f.Locals[0]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/cost/CostReveal","getType","()Ljava/lang/String;","invokevirtual",209);}
case 209:{f.Pc=216;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/cost/CostReveal","getTypeDescription","()Ljava/lang/String;","invokevirtual",216);}
case 216:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",219);}
case 219:{f.StackOp("pop");f.Pc=220;continue;}
case 220:{f.Push(f.Locals[1]);f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String(" or choose ")));f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",226);}
case 226:{f.StackOp("pop");f.Pc=227;continue;}
case 227:{f.Push(f.Locals[1]);f.Pc=228;continue;}
case 228:{f.Push(f.Locals[2]);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[0]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/cost/CostReveal","getAmount","()Ljava/lang/String;","invokevirtual",233);}
case 233:{f.Push(f.Locals[3]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",237);}
case 237:{return rt.Call(f,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",240);}
case 240:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",243);}
case 243:{f.StackOp("pop");f.Pc=244;continue;}
case 244:{f.Push(f.Locals[1]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String(" you control")));f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",250);}
case 250:{f.StackOp("pop");f.Pc=251;continue;}
case 251:{f.Push(f.Locals[1]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",255);}
case 255:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6559(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",7);}
case 7:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",15);}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;)V","invokevirtual",19);}
case 19:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",26);}
case 26:{f.Locals[5]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[5]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",34);}
case 34:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?59:48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String(" reveals ")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Pc=67;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String(" chooses ")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{f.Push(f.Locals[5]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",73);}
case 73:{f.Push(JValue.R(rt.String(" to pay a cost for ")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",85);}
case 85:{f.StackOp("pop");f.Pc=86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",90);}
case 90:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=93;continue;}
case 93:{f.StackOp("dup");f.Pc=94;continue;}
case 94:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","INFORMATION","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","INFORMATION","Lforge/game/GameLogEntryType;"));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[5]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",102);}
case 102:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",105);}
case 105:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",108);}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6560(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6561(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",10);}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;)V","invokevirtual",15);}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6562(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Revealed")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6563(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("RevealedCards")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6564(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostReveal;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6565(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostReveal","revealFrom","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int!=0?24:22;continue;}
case 22:{f.Push(JValue.I(-1));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 24:{f.Push(JValue.I(5));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
