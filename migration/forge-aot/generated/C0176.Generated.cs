// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C176{
internal static JClass Build(){var c=new JClass("forge/game/StaticEffect","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("source","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("ability","Lforge/game/staticability/StaticAbility;",false,JValue.Default("Lforge/game/staticability/StaticAbility;"),null));
c.Add(new JField("affectedCards","Lforge/game/card/CardCollectionView;",false,JValue.Default("Lforge/game/card/CardCollectionView;"),null));
c.Add(new JField("affectedPlayers","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("timestamp","J",false,JValue.Default("J"),null));
c.Add(new JField("mapParams","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(2740,"forge/game/StaticEffect","<init>","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M2740));
c.Add(new JMethod(2741,"forge/game/StaticEffect","<init>","(Lforge/game/staticability/StaticAbility;)V",0,2,2,new JHandler[]{},M2741));
c.Add(new JMethod(2742,"forge/game/StaticEffect","makeMappedCopy","(Lforge/game/IEntityMap;)Lforge/game/StaticEffect;",2,3,4,new JHandler[]{},M2742));
c.Add(new JMethod(2743,"forge/game/StaticEffect","setTimestamp","(J)V",17,3,3,new JHandler[]{},M2743));
c.Add(new JMethod(2744,"forge/game/StaticEffect","getTimestamp","()J",17,1,2,new JHandler[]{},M2744));
c.Add(new JMethod(2745,"forge/game/StaticEffect","getSource","()Lforge/game/card/Card;",17,1,1,new JHandler[]{},M2745));
c.Add(new JMethod(2746,"forge/game/StaticEffect","getAffectedCards","()Lforge/game/card/CardCollectionView;",17,1,1,new JHandler[]{},M2746));
c.Add(new JMethod(2747,"forge/game/StaticEffect","setAffectedCards","(Lforge/game/card/CardCollectionView;)V",17,2,2,new JHandler[]{},M2747));
c.Add(new JMethod(2748,"forge/game/StaticEffect","getAffectedPlayers","()Ljava/util/List;",17,1,1,new JHandler[]{},M2748));
c.Add(new JMethod(2749,"forge/game/StaticEffect","setAffectedPlayers","(Ljava/util/List;)V",17,2,2,new JHandler[]{},M2749));
c.Add(new JMethod(2750,"forge/game/StaticEffect","setParams","(Ljava/util/Map;)V",17,2,2,new JHandler[]{},M2750));
c.Add(new JMethod(2751,"forge/game/StaticEffect","getParams","()Ljava/util/Map;",17,1,1,new JHandler[]{},M2751));
c.Add(new JMethod(2752,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M2752));
c.Add(new JMethod(2753,"forge/game/StaticEffect","getParam","(Ljava/lang/String;)Ljava/lang/String;",1,2,2,new JHandler[]{},M2753));
c.Add(new JMethod(2754,"forge/game/StaticEffect","remove","(Ljava/util/Map;)Lforge/game/card/CardCollectionView;",16,2,3,new JHandler[]{},M2754));
c.Add(new JMethod(2755,"forge/game/StaticEffect","remove","(Ljava/util/Map;Ljava/util/List;)Lforge/game/card/CardCollectionView;",16,8,7,new JHandler[]{},M2755));
c.Add(new JMethod(2756,"forge/game/StaticEffect","addCard","(Ljava/util/Map;Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/Card;)V",12,3,3,new JHandler[]{},M2756));
c.Add(new JMethod(2757,"forge/game/StaticEffect","removeMapped","(Lforge/game/IEntityMap;)V",1,2,2,new JHandler[]{},M2757));
c.Add(new JMethod(2758,"forge/game/StaticEffect","lambda$addCard$0","(Lforge/game/staticability/StaticAbilityLayer;)Ljava/util/Set;",4106,1,1,new JHandler[]{},M2758));
}

internal static JStep M2740(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/StaticEffect","affectedCards","Lforge/game/card/CardCollectionView;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/StaticEffect","affectedPlayers","Ljava/util/List;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.L(-1L));f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/StaticEffect","timestamp","J",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"com/google/common/collect/Maps","newTreeMap","()Ljava/util/TreeMap;","invokestatic",33);}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/StaticEffect","mapParams","Ljava/util/Map;",value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/StaticEffect","source","Lforge/game/card/Card;",value);f.Pc=41;continue;}
case 41:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2741(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/StaticEffect","<init>","(Lforge/game/card/Card;)V","invokespecial",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;",value);f.Pc=13;continue;}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2742(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/StaticEffect"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/StaticEffect")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","source","Lforge/game/card/Card;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/IEntityMap","map","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokeinterface",14);}
case 14:{return rt.Call(f,"forge/game/StaticEffect","<init>","(Lforge/game/card/Card;)V","invokespecial",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","affectedCards","Lforge/game/card/CardCollectionView;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/IEntityMap","mapCollection","(Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollection;","invokeinterface",37);}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/StaticEffect","affectedCards","Lforge/game/card/CardCollectionView;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","affectedPlayers","Ljava/util/List;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/IEntityMap","mapList","(Ljava/util/List;)Ljava/util/List;","invokeinterface",51);}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/StaticEffect","affectedPlayers","Ljava/util/List;",value);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","timestamp","J"));f.Pc=59;continue;}
case 59:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/StaticEffect","timestamp","J",value);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","mapParams","Ljava/util/Map;"));f.Pc=67;continue;}
case 67:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/StaticEffect","mapParams","Ljava/util/Map;",value);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2743(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/StaticEffect","timestamp","J",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2744(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","timestamp","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2745(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","source","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2746(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","affectedCards","Lforge/game/card/CardCollectionView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2747(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/StaticEffect","affectedCards","Lforge/game/card/CardCollectionView;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2748(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","affectedPlayers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2749(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/StaticEffect","affectedPlayers","Ljava/util/List;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2750(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/StaticEffect","mapParams","Ljava/util/Map;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2751(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","mapParams","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2752(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","mapParams","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2753(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","mapParams","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2754(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CONTINUOUS_LAYERS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CONTINUOUS_LAYERS","Lcom/google/common/collect/ImmutableList;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/StaticEffect","remove","(Ljava/util/Map;Ljava/util/List;)Lforge/game/card/CardCollectionView;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2755(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/StaticEffect","getAffectedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/StaticEffect","getAffectedPlayers","()Ljava/util/List;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?52:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("IgnoreEffectCost")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?52:32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/StaticEffect","getSource","()Lforge/game/card/Card;","invokevirtual",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",40);}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",47);}
case 47:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/Card","removeChangedCardTraits","(JJ)Z","invokevirtual",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",59);}
case 59:{f.Locals[5]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",68);}
case 68:{f.Pc=f.Pop().Int==0?231:71;continue;}
case 71:{f.Push(f.Locals[5]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",78);}
case 78:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=81;continue;}
case 81:{f.Locals[6]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",92);}
case 92:{f.Pc=f.Pop().Int==0?195:95;continue;}
case 95:{f.Push(f.Locals[6]);f.Pc=97;continue;}
case 97:{f.Push(JValue.I(0));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/player/Player","setUnlimitedHandSize","(Z)V","invokevirtual",101);}
case 101:{f.Push(f.Locals[6]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[6]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/player/Player","getStartingHandSize","()I","invokevirtual",108);}
case 108:{return rt.Call(f,"forge/game/player/Player","setMaxHandSize","(I)V","invokevirtual",111);}
case 111:{f.Push(f.Locals[6]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",117);}
case 117:{return rt.Call(f,"forge/game/player/Player","removeMaxLandPlays","(J)Z","invokevirtual",120);}
case 120:{f.StackOp("pop");f.Pc=121;continue;}
case 121:{f.Push(f.Locals[6]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",127);}
case 127:{return rt.Call(f,"forge/game/player/Player","removeMaxLandPlaysInfinite","(J)Z","invokevirtual",130);}
case 130:{f.StackOp("pop");f.Pc=131;continue;}
case 131:{f.Push(f.Locals[6]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",137);}
case 137:{return rt.Call(f,"forge/game/player/Player","removeControlledWhileSearching","(J)V","invokevirtual",140);}
case 140:{f.Push(f.Locals[6]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",146);}
case 146:{return rt.Call(f,"forge/game/player/Player","removeControlVote","(J)Z","invokevirtual",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{f.Push(f.Locals[6]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[0]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",156);}
case 156:{return rt.Call(f,"forge/game/player/Player","removeAdditionalVote","(J)V","invokevirtual",159);}
case 159:{f.Push(f.Locals[6]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",165);}
case 165:{return rt.Call(f,"forge/game/player/Player","removeAdditionalOptionalVote","(J)V","invokevirtual",168);}
case 168:{f.Push(f.Locals[6]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",174);}
case 174:{return rt.Call(f,"forge/game/player/Player","removeAdditionalVillainousChoices","(J)V","invokevirtual",177);}
case 177:{f.Push(f.Locals[6]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[0]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",183);}
case 183:{return rt.Call(f,"forge/game/player/Player","removeDeclaresAttackers","(J)V","invokevirtual",186);}
case 186:{f.Push(f.Locals[6]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",192);}
case 192:{return rt.Call(f,"forge/game/player/Player","removeDeclaresBlockers","(J)V","invokevirtual",195);}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",204);}
case 204:{f.Pc=f.Pop().Int==0?228:207;continue;}
case 207:{f.Push(f.Locals[6]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[0]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",213);}
case 213:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",216);}
case 216:{f.Push(f.Locals[0]);f.Pc=217;continue;}
case 217:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",223);}
case 223:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/player/Player","removeChangedKeywords","(Ljava/lang/Long;J)Lforge/game/keyword/IKeywordsChange;","invokevirtual",227);}
case 227:{f.StackOp("pop");f.Pc=228;continue;}
case 228:{f.Pc=61;continue;}
case 231:{f.Push(f.Locals[3]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",237);}
case 237:{f.Locals[5]=f.Pop();f.Pc=239;continue;}
case 239:{f.Push(f.Locals[5]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",246);}
case 246:{f.Pc=f.Pop().Int==0?1228:249;continue;}
case 249:{f.Push(f.Locals[5]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",256);}
case 256:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=259;continue;}
case 259:{f.Locals[6]=f.Pop();f.Pc=261;continue;}
case 261:{f.Push(f.Locals[2]);f.Pc=262;continue;}
case 262:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CONTROL","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CONTROL","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=265;continue;}
case 265:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",270);}
case 270:{f.Pc=f.Pop().Int==0?291:273;continue;}
case 273:{f.Push(f.Locals[0]);f.Pc=274;continue;}
case 274:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",279);}
case 279:{f.Pc=f.Pop().Int==0?291:282;continue;}
case 282:{f.Push(f.Locals[6]);f.Pc=284;continue;}
case 284:{f.Push(f.Locals[0]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",288);}
case 288:{return rt.Call(f,"forge/game/card/Card","removeTempController","(J)V","invokevirtual",291);}
case 291:{f.Push(f.Locals[2]);f.Pc=292;continue;}
case 292:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=295;continue;}
case 295:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",300);}
case 300:{f.Pc=f.Pop().Int==0?538:303;continue;}
case 303:{f.Push(f.Locals[0]);f.Pc=304;continue;}
case 304:{f.Push(JValue.R(rt.String("ChangeColorWordsTo")));f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",309);}
case 309:{f.Pc=f.Pop().Int==0?341:312;continue;}
case 312:{f.Push(f.Locals[6]);f.Pc=314;continue;}
case 314:{f.Push(f.Locals[0]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",318);}
case 318:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",321);}
case 321:{f.Push(f.Locals[0]);f.Pc=322;continue;}
case 322:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",328);}
case 328:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/card/Card","removeChangedTextColorWord","(Ljava/lang/Long;J)V","invokevirtual",332);}
case 332:{f.Push(f.Locals[1]);f.Pc=333;continue;}
case 333:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=336;continue;}
case 336:{f.Push(f.Locals[6]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"forge/game/StaticEffect","addCard","(Ljava/util/Map;Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/Card;)V","invokestatic",341);}
case 341:{f.Push(f.Locals[0]);f.Pc=342;continue;}
case 342:{f.Push(JValue.R(rt.String("SetName")));f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",347);}
case 347:{f.Pc=f.Pop().Int!=0?359:350;continue;}
case 350:{f.Push(f.Locals[0]);f.Pc=351;continue;}
case 351:{f.Push(JValue.R(rt.String("AddNames")));f.Pc=353;continue;}
case 353:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",356);}
case 356:{f.Pc=f.Pop().Int==0?389:359;continue;}
case 359:{f.Push(f.Locals[6]);f.Pc=361;continue;}
case 361:{f.Push(f.Locals[0]);f.Pc=362;continue;}
case 362:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","timestamp","J"));f.Pc=365;continue;}
case 365:{f.Push(f.Locals[0]);f.Pc=366;continue;}
case 366:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=369;continue;}
case 369:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",372);}
case 372:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=373;continue;}
case 373:{f.Push(JValue.I(0));f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/game/card/Card","removeChangedName","(JJZ)Z","invokevirtual",377);}
case 377:{f.Pc=f.Pop().Int==0?389:380;continue;}
case 380:{f.Push(f.Locals[1]);f.Pc=381;continue;}
case 381:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=384;continue;}
case 384:{f.Push(f.Locals[6]);f.Pc=386;continue;}
case 386:{return rt.Call(f,"forge/game/StaticEffect","addCard","(Ljava/util/Map;Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/Card;)V","invokestatic",389);}
case 389:{f.Push(f.Locals[0]);f.Pc=390;continue;}
case 390:{f.Push(JValue.R(rt.String("GainTextOf")));f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",395);}
case 395:{f.Pc=f.Pop().Int==0?538:398;continue;}
case 398:{f.Push(f.Locals[6]);f.Pc=400;continue;}
case 400:{f.Push(f.Locals[0]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",404);}
case 404:{f.Push(f.Locals[0]);f.Pc=405;continue;}
case 405:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",411);}
case 411:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=412;continue;}
case 412:{f.Push(JValue.I(0));f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/game/card/Card","removeChangedName","(JJZ)Z","invokevirtual",416);}
case 416:{f.StackOp("pop");f.Pc=417;continue;}
case 417:{f.Push(f.Locals[6]);f.Pc=419;continue;}
case 419:{f.Push(f.Locals[0]);f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",423);}
case 423:{f.Push(f.Locals[0]);f.Pc=424;continue;}
case 424:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=427;continue;}
case 427:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",430);}
case 430:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/game/card/Card","removeChangedManaCost","(JJ)Z","invokevirtual",434);}
case 434:{f.StackOp("pop");f.Pc=435;continue;}
case 435:{f.Push(f.Locals[6]);f.Pc=437;continue;}
case 437:{f.Push(f.Locals[0]);f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",441);}
case 441:{f.Push(f.Locals[0]);f.Pc=442;continue;}
case 442:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=445;continue;}
case 445:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",448);}
case 448:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/game/card/Card","removeColorByText","(JJ)V","invokevirtual",452);}
case 452:{f.Push(f.Locals[6]);f.Pc=454;continue;}
case 454:{f.Push(f.Locals[0]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",458);}
case 458:{f.Push(f.Locals[0]);f.Pc=459;continue;}
case 459:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=462;continue;}
case 462:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",465);}
case 465:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=466;continue;}
case 466:{return rt.Call(f,"forge/game/card/Card","removeChangedCardTypesByText","(JJ)Z","invokevirtual",469);}
case 469:{f.StackOp("pop");f.Pc=470;continue;}
case 470:{f.Push(f.Locals[6]);f.Pc=472;continue;}
case 472:{f.Push(f.Locals[0]);f.Pc=473;continue;}
case 473:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",476);}
case 476:{f.Push(f.Locals[0]);f.Pc=477;continue;}
case 477:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=480;continue;}
case 480:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",483);}
case 483:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=484;continue;}
case 484:{return rt.Call(f,"forge/game/card/Card","removeChangedCardTraitsByText","(JJ)Z","invokevirtual",487);}
case 487:{f.StackOp("pop");f.Pc=488;continue;}
case 488:{f.Push(f.Locals[6]);f.Pc=490;continue;}
case 490:{f.Push(f.Locals[0]);f.Pc=491;continue;}
case 491:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",494);}
case 494:{f.Push(f.Locals[0]);f.Pc=495;continue;}
case 495:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=498;continue;}
case 498:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",501);}
case 501:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/game/card/Card","removeChangedCardKeywordsByText","(JJ)Z","invokevirtual",505);}
case 505:{f.StackOp("pop");f.Pc=506;continue;}
case 506:{f.Push(f.Locals[6]);f.Pc=508;continue;}
case 508:{f.Push(f.Locals[0]);f.Pc=509;continue;}
case 509:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",512);}
case 512:{f.Push(f.Locals[0]);f.Pc=513;continue;}
case 513:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=516;continue;}
case 516:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",519);}
case 519:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=520;continue;}
case 520:{return rt.Call(f,"forge/game/card/Card","removeNewPTbyText","(JJ)Z","invokevirtual",523);}
case 523:{f.StackOp("pop");f.Pc=524;continue;}
case 524:{f.Push(f.Locals[6]);f.Pc=526;continue;}
case 526:{return rt.Call(f,"forge/game/card/Card","updateChangedText","()V","invokevirtual",529);}
case 529:{f.Push(f.Locals[1]);f.Pc=530;continue;}
case 530:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=533;continue;}
case 533:{f.Push(f.Locals[6]);f.Pc=535;continue;}
case 535:{return rt.Call(f,"forge/game/StaticEffect","addCard","(Ljava/util/Map;Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/Card;)V","invokestatic",538);}
case 538:{f.Push(f.Locals[2]);f.Pc=539;continue;}
case 539:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=542;continue;}
case 542:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",547);}
case 547:{f.Pc=f.Pop().Int==0?620:550;continue;}
case 550:{f.Push(f.Locals[0]);f.Pc=551;continue;}
case 551:{f.Push(JValue.R(rt.String("AddType")));f.Pc=554;continue;}
case 554:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",557);}
case 557:{f.Pc=f.Pop().Int!=0?590:560;continue;}
case 560:{f.Push(f.Locals[0]);f.Pc=561;continue;}
case 561:{f.Push(JValue.R(rt.String("AddAllCreatureTypes")));f.Pc=564;continue;}
case 564:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",567);}
case 567:{f.Pc=f.Pop().Int!=0?590:570;continue;}
case 570:{f.Push(f.Locals[0]);f.Pc=571;continue;}
case 571:{f.Push(JValue.R(rt.String("RemoveType")));f.Pc=574;continue;}
case 574:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",577);}
case 577:{f.Pc=f.Pop().Int!=0?590:580;continue;}
case 580:{f.Push(f.Locals[0]);f.Pc=581;continue;}
case 581:{f.Push(JValue.R(rt.String("RemoveLandTypes")));f.Pc=584;continue;}
case 584:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",587);}
case 587:{f.Pc=f.Pop().Int==0?620:590;continue;}
case 590:{f.Push(f.Locals[6]);f.Pc=592;continue;}
case 592:{f.Push(f.Locals[0]);f.Pc=593;continue;}
case 593:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",596);}
case 596:{f.Push(f.Locals[0]);f.Pc=597;continue;}
case 597:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=600;continue;}
case 600:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",603);}
case 603:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=604;continue;}
case 604:{f.Push(JValue.I(0));f.Pc=605;continue;}
case 605:{return rt.Call(f,"forge/game/card/Card","removeChangedCardTypes","(JJZ)Z","invokevirtual",608);}
case 608:{f.Pc=f.Pop().Int==0?620:611;continue;}
case 611:{f.Push(f.Locals[1]);f.Pc=612;continue;}
case 612:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=615;continue;}
case 615:{f.Push(f.Locals[6]);f.Pc=617;continue;}
case 617:{return rt.Call(f,"forge/game/StaticEffect","addCard","(Ljava/util/Map;Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/Card;)V","invokestatic",620);}
case 620:{f.Push(f.Locals[2]);f.Pc=621;continue;}
case 621:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","COLOR","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","COLOR","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=624;continue;}
case 624:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",629);}
case 629:{f.Pc=f.Pop().Int==0?669:632;continue;}
case 632:{f.Push(f.Locals[0]);f.Pc=633;continue;}
case 633:{f.Push(JValue.R(rt.String("AddColor")));f.Pc=636;continue;}
case 636:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",639);}
case 639:{f.Pc=f.Pop().Int!=0?652:642;continue;}
case 642:{f.Push(f.Locals[0]);f.Pc=643;continue;}
case 643:{f.Push(JValue.R(rt.String("SetColor")));f.Pc=646;continue;}
case 646:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",649);}
case 649:{f.Pc=f.Pop().Int==0?669:652;continue;}
case 652:{f.Push(f.Locals[6]);f.Pc=654;continue;}
case 654:{f.Push(f.Locals[0]);f.Pc=655;continue;}
case 655:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",658);}
case 658:{f.Push(f.Locals[0]);f.Pc=659;continue;}
case 659:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=662;continue;}
case 662:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",665);}
case 665:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=666;continue;}
case 666:{return rt.Call(f,"forge/game/card/Card","removeColor","(JJ)V","invokevirtual",669);}
case 669:{f.Push(f.Locals[2]);f.Pc=670;continue;}
case 670:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=673;continue;}
case 673:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",678);}
case 678:{f.Pc=f.Pop().Int==0?927:681;continue;}
case 681:{f.Push(JValue.I(0));f.Pc=682;continue;}
case 682:{f.Locals[7]=f.Pop();f.Pc=684;continue;}
case 684:{f.Push(f.Locals[0]);f.Pc=685;continue;}
case 685:{f.Push(JValue.R(rt.String("AddKeyword")));f.Pc=688;continue;}
case 688:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",691);}
case 691:{f.Pc=f.Pop().Int!=0?734:694;continue;}
case 694:{f.Push(f.Locals[0]);f.Pc=695;continue;}
case 695:{f.Push(JValue.R(rt.String("RemoveKeyword")));f.Pc=698;continue;}
case 698:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",701);}
case 701:{f.Pc=f.Pop().Int!=0?734:704;continue;}
case 704:{f.Push(f.Locals[0]);f.Pc=705;continue;}
case 705:{f.Push(JValue.R(rt.String("ShareRememberedKeywords")));f.Pc=708;continue;}
case 708:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",711);}
case 711:{f.Pc=f.Pop().Int!=0?734:714;continue;}
case 714:{f.Push(f.Locals[0]);f.Pc=715;continue;}
case 715:{f.Push(JValue.R(rt.String("RemoveAllAbilities")));f.Pc=718;continue;}
case 718:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",721);}
case 721:{f.Pc=f.Pop().Int!=0?734:724;continue;}
case 724:{f.Push(f.Locals[0]);f.Pc=725;continue;}
case 725:{f.Push(JValue.R(rt.String("RemoveNonManaAbilities")));f.Pc=728;continue;}
case 728:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",731);}
case 731:{f.Pc=f.Pop().Int==0?757:734;continue;}
case 734:{f.Push(f.Locals[7]);f.Pc=736;continue;}
case 736:{f.Push(f.Locals[6]);f.Pc=738;continue;}
case 738:{f.Push(f.Locals[0]);f.Pc=739;continue;}
case 739:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",742);}
case 742:{f.Push(f.Locals[0]);f.Pc=743;continue;}
case 743:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=746;continue;}
case 746:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",749);}
case 749:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=750;continue;}
case 750:{f.Push(JValue.I(0));f.Pc=751;continue;}
case 751:{return rt.Call(f,"forge/game/card/Card","removeChangedCardKeywords","(JJZ)Z","invokevirtual",754);}
case 754:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=755;continue;}
case 755:{f.Locals[7]=f.Pop();f.Pc=757;continue;}
case 757:{f.Push(f.Locals[0]);f.Pc=758;continue;}
case 758:{f.Push(JValue.R(rt.String("AddAbility")));f.Pc=761;continue;}
case 761:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",764);}
case 764:{f.Pc=f.Pop().Int!=0?847:767;continue;}
case 767:{f.Push(f.Locals[0]);f.Pc=768;continue;}
case 768:{f.Push(JValue.R(rt.String("GainsAbilitiesOf")));f.Pc=771;continue;}
case 771:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",774);}
case 774:{f.Pc=f.Pop().Int!=0?847:777;continue;}
case 777:{f.Push(f.Locals[0]);f.Pc=778;continue;}
case 778:{f.Push(JValue.R(rt.String("GainsAbilitiesOfDefined")));f.Pc=781;continue;}
case 781:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",784);}
case 784:{f.Pc=f.Pop().Int!=0?847:787;continue;}
case 787:{f.Push(f.Locals[0]);f.Pc=788;continue;}
case 788:{f.Push(JValue.R(rt.String("GainsTriggerAbsOf")));f.Pc=791;continue;}
case 791:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",794);}
case 794:{f.Pc=f.Pop().Int!=0?847:797;continue;}
case 797:{f.Push(f.Locals[0]);f.Pc=798;continue;}
case 798:{f.Push(JValue.R(rt.String("AddTrigger")));f.Pc=801;continue;}
case 801:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",804);}
case 804:{f.Pc=f.Pop().Int!=0?847:807;continue;}
case 807:{f.Push(f.Locals[0]);f.Pc=808;continue;}
case 808:{f.Push(JValue.R(rt.String("AddStaticAbility")));f.Pc=811;continue;}
case 811:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",814);}
case 814:{f.Pc=f.Pop().Int!=0?847:817;continue;}
case 817:{f.Push(f.Locals[0]);f.Pc=818;continue;}
case 818:{f.Push(JValue.R(rt.String("AddReplacementEffect")));f.Pc=821;continue;}
case 821:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",824);}
case 824:{f.Pc=f.Pop().Int!=0?847:827;continue;}
case 827:{f.Push(f.Locals[0]);f.Pc=828;continue;}
case 828:{f.Push(JValue.R(rt.String("RemoveAllAbilities")));f.Pc=831;continue;}
case 831:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",834);}
case 834:{f.Pc=f.Pop().Int!=0?847:837;continue;}
case 837:{f.Push(f.Locals[0]);f.Pc=838;continue;}
case 838:{f.Push(JValue.R(rt.String("RemoveNonManaAbilities")));f.Pc=841;continue;}
case 841:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",844);}
case 844:{f.Pc=f.Pop().Int==0?869:847;continue;}
case 847:{f.Push(f.Locals[7]);f.Pc=849;continue;}
case 849:{f.Push(f.Locals[6]);f.Pc=851;continue;}
case 851:{f.Push(f.Locals[0]);f.Pc=852;continue;}
case 852:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",855);}
case 855:{f.Push(f.Locals[0]);f.Pc=856;continue;}
case 856:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=859;continue;}
case 859:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",862);}
case 862:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=863;continue;}
case 863:{return rt.Call(f,"forge/game/card/Card","removeChangedCardTraits","(JJ)Z","invokevirtual",866);}
case 866:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=867;continue;}
case 867:{f.Locals[7]=f.Pop();f.Pc=869;continue;}
case 869:{f.Push(f.Locals[0]);f.Pc=870;continue;}
case 870:{f.Push(JValue.R(rt.String("CantHaveKeyword")));f.Pc=873;continue;}
case 873:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",876);}
case 876:{f.Pc=f.Pop().Int==0?896:879;continue;}
case 879:{f.Push(f.Locals[7]);f.Pc=881;continue;}
case 881:{f.Push(f.Locals[6]);f.Pc=883;continue;}
case 883:{f.Push(f.Locals[0]);f.Pc=884;continue;}
case 884:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",887);}
case 887:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",890);}
case 890:{return rt.Call(f,"forge/game/card/Card","removeCantHaveKeyword","(Ljava/lang/Long;)Z","invokevirtual",893);}
case 893:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=894;continue;}
case 894:{f.Locals[7]=f.Pop();f.Pc=896;continue;}
case 896:{f.Push(f.Locals[6]);f.Pc=898;continue;}
case 898:{f.Push(f.Locals[0]);f.Pc=899;continue;}
case 899:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",902);}
case 902:{f.Push(f.Locals[0]);f.Pc=903;continue;}
case 903:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=906;continue;}
case 906:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",909);}
case 909:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=910;continue;}
case 910:{return rt.Call(f,"forge/game/card/Card","removeChangedSVars","(JJ)V","invokevirtual",913);}
case 913:{f.Push(f.Locals[7]);f.Pc=915;continue;}
case 915:{f.Pc=f.Pop().Int==0?927:918;continue;}
case 918:{f.Push(f.Locals[1]);f.Pc=919;continue;}
case 919:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=922;continue;}
case 922:{f.Push(f.Locals[6]);f.Pc=924;continue;}
case 924:{return rt.Call(f,"forge/game/StaticEffect","addCard","(Ljava/util/Map;Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/Card;)V","invokestatic",927);}
case 927:{f.Push(f.Locals[2]);f.Pc=928;continue;}
case 928:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=931;continue;}
case 931:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",936);}
case 936:{f.Pc=f.Pop().Int!=0?951:939;continue;}
case 939:{f.Push(f.Locals[2]);f.Pc=940;continue;}
case 940:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=943;continue;}
case 943:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",948);}
case 948:{f.Pc=f.Pop().Int==0?1017:951;continue;}
case 951:{f.Push(f.Locals[0]);f.Pc=952;continue;}
case 952:{f.Push(JValue.R(rt.String("SetPower")));f.Pc=955;continue;}
case 955:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",958);}
case 958:{f.Pc=f.Pop().Int!=0?971:961;continue;}
case 961:{f.Push(f.Locals[0]);f.Pc=962;continue;}
case 962:{f.Push(JValue.R(rt.String("SetToughness")));f.Pc=965;continue;}
case 965:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",968);}
case 968:{f.Pc=f.Pop().Int==0?1017:971;continue;}
case 971:{f.Push(f.Locals[6]);f.Pc=973;continue;}
case 973:{f.Push(f.Locals[0]);f.Pc=974;continue;}
case 974:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",977);}
case 977:{f.Push(f.Locals[0]);f.Pc=978;continue;}
case 978:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=981;continue;}
case 981:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",984);}
case 984:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=985;continue;}
case 985:{f.Push(JValue.I(0));f.Pc=986;continue;}
case 986:{return rt.Call(f,"forge/game/card/Card","removeNewPT","(JJZ)Z","invokevirtual",989);}
case 989:{f.Pc=f.Pop().Int==0?1017:992;continue;}
case 992:{f.Push(f.Locals[1]);f.Pc=993;continue;}
case 993:{f.Push(f.Locals[0]);f.Pc=994;continue;}
case 994:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=997;continue;}
case 997:{return rt.Call(f,"forge/game/staticability/StaticAbility","isCharacteristicDefining","()Z","invokevirtual",1000);}
case 1000:{f.Pc=f.Pop().Int==0?1009:1003;continue;}
case 1003:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1006;continue;}
case 1006:{f.Pc=1012;continue;}
case 1009:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1012;continue;}
case 1012:{f.Push(f.Locals[6]);f.Pc=1014;continue;}
case 1014:{return rt.Call(f,"forge/game/StaticEffect","addCard","(Ljava/util/Map;Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/Card;)V","invokestatic",1017);}
case 1017:{f.Push(f.Locals[2]);f.Pc=1018;continue;}
case 1018:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1021;continue;}
case 1021:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",1026);}
case 1026:{f.Pc=f.Pop().Int==0?1058:1029;continue;}
case 1029:{f.Push(f.Locals[6]);f.Pc=1031;continue;}
case 1031:{f.Push(f.Locals[0]);f.Pc=1032;continue;}
case 1032:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",1035);}
case 1035:{f.Push(f.Locals[0]);f.Pc=1036;continue;}
case 1036:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=1039;continue;}
case 1039:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",1042);}
case 1042:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=1043;continue;}
case 1043:{return rt.Call(f,"forge/game/card/Card","removePTBoost","(JJ)Z","invokevirtual",1046);}
case 1046:{f.Pc=f.Pop().Int==0?1058:1049;continue;}
case 1049:{f.Push(f.Locals[1]);f.Pc=1050;continue;}
case 1050:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1053;continue;}
case 1053:{f.Push(f.Locals[6]);f.Pc=1055;continue;}
case 1055:{return rt.Call(f,"forge/game/StaticEffect","addCard","(Ljava/util/Map;Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/Card;)V","invokestatic",1058);}
case 1058:{f.Push(f.Locals[2]);f.Pc=1059;continue;}
case 1059:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1062;continue;}
case 1062:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",1067);}
case 1067:{f.Pc=f.Pop().Int==0?1225:1070;continue;}
case 1070:{f.Push(f.Locals[0]);f.Pc=1071;continue;}
case 1071:{f.Push(JValue.R(rt.String("AddHiddenKeyword")));f.Pc=1074;continue;}
case 1074:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",1077);}
case 1077:{f.Pc=f.Pop().Int==0?1097:1080;continue;}
case 1080:{f.Push(f.Locals[6]);f.Pc=1082;continue;}
case 1082:{f.Push(f.Locals[0]);f.Pc=1083;continue;}
case 1083:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","timestamp","J"));f.Pc=1086;continue;}
case 1086:{f.Push(f.Locals[0]);f.Pc=1087;continue;}
case 1087:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=1090;continue;}
case 1090:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",1093);}
case 1093:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=1094;continue;}
case 1094:{return rt.Call(f,"forge/game/card/Card","removeHiddenExtrinsicKeywords","(JJ)V","invokevirtual",1097);}
case 1097:{f.Push(f.Locals[0]);f.Pc=1098;continue;}
case 1098:{f.Push(JValue.R(rt.String("MayLookAt")));f.Pc=1101;continue;}
case 1101:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",1104);}
case 1104:{f.Pc=f.Pop().Int==0?1116:1107;continue;}
case 1107:{f.Push(f.Locals[6]);f.Pc=1109;continue;}
case 1109:{f.Push(f.Locals[0]);f.Pc=1110;continue;}
case 1110:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",1113);}
case 1113:{return rt.Call(f,"forge/game/card/Card","removeMayLookAt","(J)V","invokevirtual",1116);}
case 1116:{f.Push(f.Locals[0]);f.Pc=1117;continue;}
case 1117:{f.Push(JValue.R(rt.String("MayPlay")));f.Pc=1120;continue;}
case 1120:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",1123);}
case 1123:{f.Pc=f.Pop().Int==0?1135:1126;continue;}
case 1126:{f.Push(f.Locals[6]);f.Pc=1128;continue;}
case 1128:{f.Push(f.Locals[0]);f.Pc=1129;continue;}
case 1129:{f.Push(rt.GetField(f.Pop(),"forge/game/StaticEffect","ability","Lforge/game/staticability/StaticAbility;"));f.Pc=1132;continue;}
case 1132:{return rt.Call(f,"forge/game/card/Card","removeMayPlay","(Lforge/game/staticability/StaticAbility;)V","invokevirtual",1135);}
case 1135:{f.Push(f.Locals[0]);f.Pc=1136;continue;}
case 1136:{f.Push(JValue.R(rt.String("Goad")));f.Pc=1139;continue;}
case 1139:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",1142);}
case 1142:{f.Pc=f.Pop().Int==0?1157:1145;continue;}
case 1145:{f.Push(f.Locals[6]);f.Pc=1147;continue;}
case 1147:{f.Push(f.Locals[0]);f.Pc=1148;continue;}
case 1148:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",1151);}
case 1151:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",1154);}
case 1154:{return rt.Call(f,"forge/game/card/Card","removeGoad","(Ljava/lang/Long;)V","invokevirtual",1157);}
case 1157:{f.Push(f.Locals[0]);f.Pc=1158;continue;}
case 1158:{f.Push(JValue.R(rt.String("CanBlockAny")));f.Pc=1161;continue;}
case 1161:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",1164);}
case 1164:{f.Pc=f.Pop().Int==0?1177:1167;continue;}
case 1167:{f.Push(f.Locals[6]);f.Pc=1169;continue;}
case 1169:{f.Push(f.Locals[0]);f.Pc=1170;continue;}
case 1170:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",1173);}
case 1173:{return rt.Call(f,"forge/game/card/Card","removeCanBlockAny","(J)Z","invokevirtual",1176);}
case 1176:{f.StackOp("pop");f.Pc=1177;continue;}
case 1177:{f.Push(f.Locals[0]);f.Pc=1178;continue;}
case 1178:{f.Push(JValue.R(rt.String("CanBlockAmount")));f.Pc=1181;continue;}
case 1181:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",1184);}
case 1184:{f.Pc=f.Pop().Int==0?1197:1187;continue;}
case 1187:{f.Push(f.Locals[6]);f.Pc=1189;continue;}
case 1189:{f.Push(f.Locals[0]);f.Pc=1190;continue;}
case 1190:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",1193);}
case 1193:{return rt.Call(f,"forge/game/card/Card","removeCanBlockAdditional","(J)Z","invokevirtual",1196);}
case 1196:{f.StackOp("pop");f.Pc=1197;continue;}
case 1197:{f.Push(f.Locals[0]);f.Pc=1198;continue;}
case 1198:{f.Push(JValue.R(rt.String("LethalDamageByPower")));f.Pc=1201;continue;}
case 1201:{return rt.Call(f,"forge/game/StaticEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",1204);}
case 1204:{f.Pc=f.Pop().Int==0?1216:1207;continue;}
case 1207:{f.Push(f.Locals[6]);f.Pc=1209;continue;}
case 1209:{f.Push(f.Locals[0]);f.Pc=1210;continue;}
case 1210:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",1213);}
case 1213:{return rt.Call(f,"forge/game/card/Card","removeLethalDamageByPower","(J)V","invokevirtual",1216);}
case 1216:{f.Push(f.Locals[1]);f.Pc=1217;continue;}
case 1217:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1220;continue;}
case 1220:{f.Push(f.Locals[6]);f.Pc=1222;continue;}
case 1222:{return rt.Call(f,"forge/game/StaticEffect","addCard","(Ljava/util/Map;Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/Card;)V","invokestatic",1225);}
case 1225:{f.Pc=239;continue;}
case 1228:{f.Push(f.Locals[3]);f.Pc=1229;continue;}
case 1229:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2756(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/StaticEffect:2756:2:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",7);}
case 7:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2757(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/StaticEffect","makeMappedCopy","(Lforge/game/IEntityMap;)Lforge/game/StaticEffect;","invokevirtual",5);}
case 5:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/game/StaticEffect","remove","(Ljava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",11);}
case 11:{f.StackOp("pop");f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2758(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",3);}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
