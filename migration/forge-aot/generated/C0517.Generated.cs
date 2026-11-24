// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C517{
internal static JClass Build(){var c=new JClass("forge/game/combat/GlobalAttackRestrictions","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("max","Ljava/lang/Integer;",false,JValue.Default("Ljava/lang/Integer;"),null));
c.Add(new JField("defenderMax","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(6158,"forge/game/combat/GlobalAttackRestrictions","<init>","(Ljava/lang/Integer;Ljava/util/Map;)V",2,3,2,new JHandler[]{},M6158));
c.Add(new JMethod(6159,"forge/game/combat/GlobalAttackRestrictions","getMax","()Ljava/lang/Integer;",1,1,1,new JHandler[]{},M6159));
c.Add(new JMethod(6160,"forge/game/combat/GlobalAttackRestrictions","getDefenderMax","()Ljava/util/Map;",1,1,1,new JHandler[]{},M6160));
c.Add(new JMethod(6161,"forge/game/combat/GlobalAttackRestrictions","isLegal","(Ljava/util/Map;)Z",1,2,3,new JHandler[]{},M6161));
c.Add(new JMethod(6162,"forge/game/combat/GlobalAttackRestrictions","getGlobalRestrictions","(Lforge/game/player/Player;Lforge/util/collect/FCollectionView;)Lforge/game/combat/GlobalAttackRestrictions;",9,8,4,new JHandler[]{},M6162));
c.Add(new JMethod(6163,"forge/game/combat/GlobalAttackRestrictions","lambda$isLegal$1","(Ljava/util/Map;Lforge/game/GameEntity;)Z",4098,4,4,new JHandler[]{},M6163));
c.Add(new JMethod(6164,"forge/game/combat/GlobalAttackRestrictions","lambda$isLegal$0","(Lforge/game/GameEntity;Lforge/game/GameEntity;)Z",4106,2,2,new JHandler[]{},M6164));
}

internal static JStep M6158(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/GlobalAttackRestrictions","max","Ljava/lang/Integer;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/GlobalAttackRestrictions","defenderMax","Ljava/util/Map;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6159(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/GlobalAttackRestrictions","max","Ljava/lang/Integer;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6160(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/GlobalAttackRestrictions","defenderMax","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6161(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/GlobalAttackRestrictions","max","Ljava/lang/Integer;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?25:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Map","size","()I","invokeinterface",13);}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/GlobalAttackRestrictions","max","Ljava/lang/Integer;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",20);}
case 20:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?25:23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",31);}
case 31:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",36);}
case 36:{return rt.Call(f,"java/util/stream/Stream","distinct","()Ljava/util/stream/Stream;","invokeinterface",41);}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.DynamicCall(f,"forge/game/combat/GlobalAttackRestrictions:6161:43:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/combat/GlobalAttackRestrictions;Ljava/util/Map;)Ljava/util/function/Predicate;",48);}
case 48:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",53);}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6162(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FCollectionView","size","()I","invokeinterface",6);}
case 6:{return rt.Call(f,"com/google/common/collect/Maps","newHashMapWithExpectedSize","(I)Ljava/util/HashMap;","invokestatic",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/staticability/StaticAbilityAttackRestrict","globalAttackRestrict","(Lforge/game/Game;)Ljava/lang/Integer;","invokestatic",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",27);}
case 27:{f.Locals[5]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[5]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",36);}
case 36:{f.Pc=f.Pop().Int==0?77:39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[6]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[6]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/staticability/StaticAbilityAttackRestrict","attackRestrictNum","(Lforge/game/GameEntity;)Ljava/lang/Integer;","invokestatic",56);}
case 56:{f.Locals[7]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[7]);f.Pc=60;continue;}
case 60:{f.Pc=f.Pop().Reference==null?74:63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[6]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[7]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",73);}
case 73:{f.StackOp("pop");f.Pc=74;continue;}
case 74:{f.Pc=29;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Map","size","()I","invokeinterface",83);}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/util/collect/FCollectionView","size","()I","invokeinterface",89);}
case 89:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?142:92;continue;}
case 92:{f.Push(f.Locals[4]);f.Pc=94;continue;}
case 94:{f.Push(JValue.I(2147483647));f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",99);}
case 99:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",102);}
case 102:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",108);}
case 108:{f.Push(f.Locals[2]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",114);}
case 114:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",119);}
case 119:{return rt.DynamicCall(f,"forge/game/combat/GlobalAttackRestrictions:6162:119:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",124);}
case 124:{return rt.Call(f,"java/util/stream/Stream","mapToInt","(Ljava/util/function/ToIntFunction;)Ljava/util/stream/IntStream;","invokeinterface",129);}
case 129:{return rt.Call(f,"java/util/stream/IntStream","sum","()I","invokeinterface",134);}
case 134:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",137);}
case 137:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",140);}
case 140:{f.Locals[4]=f.Pop();f.Pc=142;continue;}
case 142:{if(!rt.EnsureInitialized(f,"forge/game/combat/GlobalAttackRestrictions"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/GlobalAttackRestrictions")));f.Pc=145;continue;}
case 145:{f.StackOp("dup");f.Pc=146;continue;}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[2]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/combat/GlobalAttackRestrictions","<init>","(Ljava/lang/Integer;Ljava/util/Map;)V","invokespecial",152);}
case 152:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6163(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/GlobalAttackRestrictions","defenderMax","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference!=null?20:18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?29:27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",35);}
case 35:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",40);}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.DynamicCall(f,"forge/game/combat/GlobalAttackRestrictions:6163:41:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/GameEntity;)Ljava/util/function/Predicate;",46);}
case 46:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",51);}
case 51:{return rt.Call(f,"java/util/stream/Stream","count","()J","invokeinterface",56);}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",60);}
case 60:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=61;continue;}
case 61:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=62;continue;}
case 62:{f.Pc=f.Pop().Int<=0?69:65;continue;}
case 65:{f.Push(JValue.I(1));f.Pc=66;continue;}
case 66:{f.Pc=70;continue;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6164(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?9:5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{f.Pc=10;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
