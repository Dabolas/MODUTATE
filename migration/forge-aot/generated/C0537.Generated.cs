// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C537{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostForage","forge/game/cost/CostPartWithList",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("HashLKIListKey","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Foraged"));
c.Add(new JField("HashCardListKey","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"ForagedCards"));
c.Add(new JMethod(6352,"forge/game/cost/CostForage","<init>","()V",1,1,1,new JHandler[]{},M6352));
c.Add(new JMethod(6353,"forge/game/cost/CostForage","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",1,6,4,new JHandler[]{},M6353));
c.Add(new JMethod(6354,"forge/game/cost/CostForage","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6354));
c.Add(new JMethod(6355,"forge/game/cost/CostForage","doPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Z)Lforge/game/card/Card;",4,5,1,new JHandler[]{},M6355));
c.Add(new JMethod(6356,"forge/game/cost/CostForage","canPayListAtOnce","()Z",4,1,1,new JHandler[]{},M6356));
c.Add(new JMethod(6357,"forge/game/cost/CostForage","doListPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;Z)Lforge/game/card/CardCollectionView;",4,11,5,new JHandler[]{},M6357));
c.Add(new JMethod(6358,"forge/game/cost/CostForage","triggerForage","(Lforge/game/player/Player;)V",4,3,4,new JHandler[]{},M6358));
c.Add(new JMethod(6359,"forge/game/cost/CostForage","getHashForLKIList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6359));
c.Add(new JMethod(6360,"forge/game/cost/CostForage","getHashForCardList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6360));
c.Add(new JMethod(6361,"forge/game/cost/CostForage","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6361));
}

internal static JStep M6352(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostPartWithList","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6353(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",7);}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardPredicates","canExiledBy","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;","invokestatic",12);}
case 12:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",15);}
case 15:{f.Locals[4]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",22);}
case 22:{f.Push(JValue.I(3));f.Pc=23;continue;}
case 23:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?28:26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",35);}
case 35:{f.Push(JValue.R(rt.String("Food")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/CardPredicates","isType","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",40);}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/CardPredicates","canBeSacrificedBy","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;","invokestatic",45);}
case 45:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",48);}
case 48:{f.Locals[5]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int!=0?60:58;continue;}
case 58:{f.Push(JValue.I(1));f.Pc=59;continue;}
case 59:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 60:{f.Push(JValue.I(0));f.Pc=61;continue;}
case 61:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6354(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Forage")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6355(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6356(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6357(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",12);}
case 12:{f.Push(JValue.I(3));f.Pc=13;continue;}
case 13:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?109:16;continue;}
case 16:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",19);}
case 19:{f.Locals[6]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[6]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostForage","table","Lforge/game/card/CardZoneTable;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",30);}
case 30:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",37);}
case 37:{f.Locals[7]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",45);}
case 45:{f.Locals[8]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[8]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Int==0?101:57;continue;}
case 57:{f.Push(f.Locals[8]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",64);}
case 64:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=67;continue;}
case 67:{f.Locals[9]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",74);}
case 74:{f.Push(f.Locals[9]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(null));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[6]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",82);}
case 82:{f.Locals[10]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[7]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[10]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",91);}
case 91:{f.StackOp("pop");f.Pc=92;continue;}
case 92:{f.Push(f.Locals[10]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",98);}
case 98:{f.Pc=47;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/cost/CostForage","triggerForage","(Lforge/game/player/Player;)V","invokevirtual",106);}
case 106:{f.Push(f.Locals[7]);f.Pc=108;continue;}
case 108:{return JStep.Return(f.Pop());}
case 109:{f.Push(f.Locals[3]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",115);}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?157:119;continue;}
case 119:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",122);}
case 122:{f.Locals[6]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[6]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostForage","table","Lforge/game/card/CardZoneTable;"));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",133);}
case 133:{f.Push(f.Locals[5]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",138);}
case 138:{f.Push(f.Locals[3]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[4]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[6]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/GameAction","sacrifice","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/CardCollection;","invokevirtual",147);}
case 147:{f.Locals[7]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[1]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/cost/CostForage","triggerForage","(Lforge/game/player/Player;)V","invokevirtual",154);}
case 154:{f.Push(f.Locals[7]);f.Pc=156;continue;}
case 156:{return JStep.Return(f.Pop());}
case 157:{f.Push(JValue.R(null));f.Pc=158;continue;}
case 158:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6358(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",12);}
case 12:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Forage","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Forage","Lforge/game/trigger/TriggerType;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6359(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Foraged")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6360(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("ForagedCards")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6361(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostForage;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
