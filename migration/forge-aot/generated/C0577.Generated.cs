// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C577{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventBlockersDeclared","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("defendingPlayer","Lforge/game/player/PlayerView;",false,JValue.Default("Lforge/game/player/PlayerView;"),null));
c.Add(new JField("blockers","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(6792,"forge/game/event/GameEventBlockersDeclared","<init>","(Lforge/game/player/Player;Ljava/util/Map;)V",1,3,3,new JHandler[]{},M6792));
c.Add(new JMethod(6793,"forge/game/event/GameEventBlockersDeclared","<init>","(Lforge/game/player/PlayerView;Ljava/util/Map;)V",1,3,2,new JHandler[]{},M6793));
c.Add(new JMethod(6794,"forge/game/event/GameEventBlockersDeclared","convertMap","(Ljava/util/Map;)Ljava/util/Map;",10,7,3,new JHandler[]{},M6794));
c.Add(new JMethod(6795,"forge/game/event/GameEventBlockersDeclared","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6795));
c.Add(new JMethod(6796,"forge/game/event/GameEventBlockersDeclared","toString","()Ljava/lang/String;",1,4,4,new JHandler[]{},M6796));
c.Add(new JMethod(6797,"forge/game/event/GameEventBlockersDeclared","hashCode","()I",17,1,1,new JHandler[]{},M6797));
c.Add(new JMethod(6798,"forge/game/event/GameEventBlockersDeclared","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M6798));
c.Add(new JMethod(6799,"forge/game/event/GameEventBlockersDeclared","defendingPlayer","()Lforge/game/player/PlayerView;",1,1,1,new JHandler[]{},M6799));
c.Add(new JMethod(6800,"forge/game/event/GameEventBlockersDeclared","blockers","()Ljava/util/Map;",1,1,1,new JHandler[]{},M6800));
}

internal static JStep M6792(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/event/GameEventBlockersDeclared","convertMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",9);}
case 9:{return rt.Call(f,"forge/game/event/GameEventBlockersDeclared","<init>","(Lforge/game/player/PlayerView;Ljava/util/Map;)V","invokespecial",12);}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6793(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventBlockersDeclared","defendingPlayer","Lforge/game/player/PlayerView;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventBlockersDeclared","blockers","Ljava/util/Map;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6794(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",14);}
case 14:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?148:29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{return rt.Call(f,"com/google/common/collect/HashMultimap","create","()Lcom/google/common/collect/HashMultimap;","invokestatic",42);}
case 42:{f.Locals[4]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{return rt.Call(f,"com/google/common/collect/Multimap","entries","()Ljava/util/Collection;","invokeinterface",58);}
case 58:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",63);}
case 63:{f.Locals[5]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",72);}
case 72:{f.Pc=f.Pop().Int==0?124:75;continue;}
case 75:{f.Push(f.Locals[5]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",82);}
case 82:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=85;continue;}
case 85:{f.Locals[6]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[6]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",96);}
case 96:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",102);}
case 102:{f.Push(f.Locals[6]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",109);}
case 109:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",115);}
case 115:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",120);}
case 120:{f.StackOp("pop");f.Pc=121;continue;}
case 121:{f.Pc=65;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[3]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",131);}
case 131:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/GameEntityView","get","(Lforge/game/GameEntity;)Lforge/game/GameEntityView;","invokestatic",137);}
case 137:{f.Push(f.Locals[4]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",144);}
case 144:{f.StackOp("pop");f.Pc=145;continue;}
case 145:{f.Pc=20;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6795(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventBlockersDeclared;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6796(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventBlockersDeclared","blockers","Ljava/util/Map;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",17);}
case 17:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?58:32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",49);}
case 49:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{f.Pc=23;continue;}
case 58:{f.Push(JValue.I(5));f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventBlockersDeclared","defendingPlayer","Lforge/game/player/PlayerView;"));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/player/PlayerView","getName","()Ljava/lang/String;","invokevirtual",71);}
case 71:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=72;continue;}
case 72:{f.StackOp("dup");f.Pc=73;continue;}
case 73:{f.Push(JValue.I(1));f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("declared")));f.Pc=76;continue;}
case 76:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=77;continue;}
case 77:{f.StackOp("dup");f.Pc=78;continue;}
case 78:{f.Push(JValue.I(2));f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",85);}
case 85:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",88);}
case 88:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=89;continue;}
case 89:{f.StackOp("dup");f.Pc=90;continue;}
case 90:{f.Push(JValue.I(3));f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("blockers:")));f.Pc=93;continue;}
case 93:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=94;continue;}
case 94:{f.StackOp("dup");f.Pc=95;continue;}
case 95:{f.Push(JValue.I(4));f.Pc=96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",100);}
case 100:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",104);}
case 104:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6797(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventBlockersDeclared:6797:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventBlockersDeclared;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6798(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventBlockersDeclared:6798:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventBlockersDeclared;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6799(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventBlockersDeclared","defendingPlayer","Lforge/game/player/PlayerView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6800(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventBlockersDeclared","blockers","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
