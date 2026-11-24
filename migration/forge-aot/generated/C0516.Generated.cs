// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C516{
internal static JClass Build(){var c=new JClass("forge/game/combat/CombatView","forge/trackable/TrackableObject",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(68085618912864942L),null));
c.Add(new JField("nextId","I",true,JValue.Default("I"),null));
c.Add(new JMethod(6137,"forge/game/combat/CombatView","<init>","(Lforge/trackable/Tracker;)V",1,2,4,new JHandler[]{},M6137));
c.Add(new JMethod(6138,"forge/game/combat/CombatView","getAttackersWithDefenders","()Ljava/util/Map;",2,1,2,new JHandler[]{},M6138));
c.Add(new JMethod(6139,"forge/game/combat/CombatView","getAttackersWithBlockers","()Ljava/util/Map;",2,1,2,new JHandler[]{},M6139));
c.Add(new JMethod(6140,"forge/game/combat/CombatView","getBandsWithDefenders","()Ljava/util/Map;",2,1,2,new JHandler[]{},M6140));
c.Add(new JMethod(6141,"forge/game/combat/CombatView","getBandsWithBlockers","()Ljava/util/Map;",2,1,2,new JHandler[]{},M6141));
c.Add(new JMethod(6142,"forge/game/combat/CombatView","getAttackersWithPlannedBlockers","()Ljava/util/Map;",2,1,2,new JHandler[]{},M6142));
c.Add(new JMethod(6143,"forge/game/combat/CombatView","getBandsWithPlannedBlockers","()Ljava/util/Map;",2,1,2,new JHandler[]{},M6143));
c.Add(new JMethod(6144,"forge/game/combat/CombatView","getNumAttackers","()I",1,1,1,new JHandler[]{},M6144));
c.Add(new JMethod(6145,"forge/game/combat/CombatView","isAttacking","(Lforge/game/card/CardView;)Z",1,2,2,new JHandler[]{},M6145));
c.Add(new JMethod(6146,"forge/game/combat/CombatView","getAttackers","()Ljava/lang/Iterable;",1,4,3,new JHandler[]{new JHandler(4,23,26,""),new JHandler(26,29,26,"")},M6146));
c.Add(new JMethod(6147,"forge/game/combat/CombatView","getDefenders","()Ljava/lang/Iterable;",1,4,3,new JHandler[]{new JHandler(4,23,26,""),new JHandler(26,29,26,"")},M6147));
c.Add(new JMethod(6148,"forge/game/combat/CombatView","getDefender","(Lforge/game/card/CardView;)Lforge/game/GameEntityView;",1,2,2,new JHandler[]{},M6148));
c.Add(new JMethod(6149,"forge/game/combat/CombatView","isBlocking","(Lforge/game/card/CardView;)Z",1,5,2,new JHandler[]{new JHandler(4,19,22,""),new JHandler(22,26,22,"")},M6149));
c.Add(new JMethod(6150,"forge/game/combat/CombatView","getBlockers","(Lforge/game/card/CardView;)Lforge/util/collect/FCollection;",1,2,2,new JHandler[]{},M6150));
c.Add(new JMethod(6151,"forge/game/combat/CombatView","getPlannedBlockers","(Lforge/game/card/CardView;)Lforge/util/collect/FCollection;",1,2,2,new JHandler[]{},M6151));
c.Add(new JMethod(6152,"forge/game/combat/CombatView","getBlockers","(Lforge/util/collect/FCollection;)Lforge/util/collect/FCollection;",1,2,2,new JHandler[]{},M6152));
c.Add(new JMethod(6153,"forge/game/combat/CombatView","getPlannedBlockers","(Lforge/util/collect/FCollection;)Lforge/util/collect/FCollection;",1,2,2,new JHandler[]{},M6153));
c.Add(new JMethod(6154,"forge/game/combat/CombatView","getAttackersOf","(Lforge/game/GameEntityView;)Lforge/util/collect/FCollection;",1,6,2,new JHandler[]{new JHandler(4,19,22,""),new JHandler(22,26,22,"")},M6154));
c.Add(new JMethod(6155,"forge/game/combat/CombatView","getAttackingBandsOf","(Lforge/game/GameEntityView;)Ljava/lang/Iterable;",1,6,2,new JHandler[]{new JHandler(4,19,22,""),new JHandler(22,26,22,"")},M6155));
c.Add(new JMethod(6156,"forge/game/combat/CombatView","addAttackingBand","(Ljava/lang/Iterable;Lforge/game/GameEntityView;Ljava/lang/Iterable;Ljava/lang/Iterable;)V",1,10,3,new JHandler[]{},M6156));
c.Add(new JMethod(6157,"forge/game/combat/CombatView","<clinit>","()V",8,0,1,new JHandler[]{},M6157));
}

internal static JStep M6137(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/combat/CombatView","nextId","I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/CombatView","nextId","I"));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/combat/CombatView","nextId","I"))return JStep.Continue;rt.PutStatic("forge/game/combat/CombatView","nextId","I",f.Pop());f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/trackable/TrackableObject","<init>","(ILforge/trackable/Tracker;)V","invokespecial",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttackersWithDefenders","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttackersWithDefenders","Lforge/trackable/TrackableProperty;"));f.Pc=18;continue;}
case 18:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",25);}
case 25:{return rt.Call(f,"forge/game/combat/CombatView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttackersWithBlockers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttackersWithBlockers","Lforge/trackable/TrackableProperty;"));f.Pc=32;continue;}
case 32:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",39);}
case 39:{return rt.Call(f,"forge/game/combat/CombatView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",42);}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BandsWithDefenders","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","BandsWithDefenders","Lforge/trackable/TrackableProperty;"));f.Pc=46;continue;}
case 46:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",53);}
case 53:{return rt.Call(f,"forge/game/combat/CombatView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",56);}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BandsWithBlockers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","BandsWithBlockers","Lforge/trackable/TrackableProperty;"));f.Pc=60;continue;}
case 60:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",67);}
case 67:{return rt.Call(f,"forge/game/combat/CombatView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",70);}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttackersWithPlannedBlockers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttackersWithPlannedBlockers","Lforge/trackable/TrackableProperty;"));f.Pc=74;continue;}
case 74:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=77;continue;}
case 77:{f.StackOp("dup");f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",81);}
case 81:{return rt.Call(f,"forge/game/combat/CombatView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",84);}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BandsWithPlannedBlockers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","BandsWithPlannedBlockers","Lforge/trackable/TrackableProperty;"));f.Pc=88;continue;}
case 88:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=91;continue;}
case 91:{f.StackOp("dup");f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",95);}
case 95:{return rt.Call(f,"forge/game/combat/CombatView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",98);}
case 98:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6138(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttackersWithDefenders","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttackersWithDefenders","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/combat/CombatView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6139(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttackersWithBlockers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttackersWithBlockers","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/combat/CombatView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6140(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BandsWithDefenders","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","BandsWithDefenders","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/combat/CombatView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6141(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BandsWithBlockers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","BandsWithBlockers","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/combat/CombatView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6142(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttackersWithPlannedBlockers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttackersWithPlannedBlockers","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/combat/CombatView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6143(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BandsWithPlannedBlockers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","BandsWithPlannedBlockers","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/combat/CombatView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6144(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/CombatView","getAttackersWithDefenders","()Ljava/util/Map;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Map","size","()I","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6145(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/CombatView","getAttackersWithDefenders","()Ljava/util/Map;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6146(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{f.Locals[2]=f.Pop();f.Pc=3;continue;}
case 3:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/combat/CombatView","getAttackersWithDefenders","()Ljava/util/Map;","invokevirtual",12);}
case 12:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",17);}
case 17:{return rt.Call(f,"java/util/HashSet","<init>","(Ljava/util/Collection;)V","invokespecial",20);}
case 20:{f.Locals[1]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=23;continue;}
case 23:{f.Pc=31;continue;}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6147(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{f.Locals[2]=f.Pop();f.Pc=3;continue;}
case 3:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/combat/CombatView","getAttackersWithDefenders","()Ljava/util/Map;","invokevirtual",12);}
case 12:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",17);}
case 17:{return rt.Call(f,"java/util/HashSet","<init>","(Ljava/util/Collection;)V","invokespecial",20);}
case 20:{f.Locals[1]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=23;continue;}
case 23:{f.Pc=31;continue;}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6148(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/CombatView","getAttackersWithDefenders","()Ljava/util/Map;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntityView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6149(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{f.Locals[3]=f.Pop();f.Pc=3;continue;}
case 3:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/combat/CombatView","getAttackersWithBlockers","()Ljava/util/Map;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",13);}
case 13:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=19;continue;}
case 19:{f.Pc=29;continue;}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",35);}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?78:45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[4]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{f.Pc=f.Pop().Reference!=null?64:61;continue;}
case 61:{f.Pc=36;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/util/collect/FCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int==0?75:73;continue;}
case 73:{f.Push(JValue.I(1));f.Pc=74;continue;}
case 74:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 75:{f.Pc=36;continue;}
case 78:{f.Push(JValue.I(0));f.Pc=79;continue;}
case 79:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6150(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/CombatView","getAttackersWithBlockers","()Ljava/util/Map;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6151(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/CombatView","getAttackersWithPlannedBlockers","()Ljava/util/Map;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6152(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/CombatView","getBandsWithBlockers","()Ljava/util/Map;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6153(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/CombatView","getBandsWithPlannedBlockers","()Ljava/util/Map;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6154(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{f.Locals[3]=f.Pop();f.Pc=3;continue;}
case 3:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/combat/CombatView","getAttackersWithDefenders","()Ljava/util/Map;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",13);}
case 13:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=19;continue;}
case 19:{f.Pc=29;continue;}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 29:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",36);}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",43);}
case 43:{f.Locals[4]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",52);}
case 52:{f.Pc=f.Pop().Int==0?103:55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",62);}
case 62:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=65;continue;}
case 65:{f.Locals[5]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Pc=f.Pop().Reference==null?100:71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",79);}
case 79:{return rt.Call(f,"forge/game/GameEntityView","equals","(Ljava/lang/Object;)Z","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Int==0?100:85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[5]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",93);}
case 93:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",99);}
case 99:{f.StackOp("pop");f.Pc=100;continue;}
case 100:{f.Pc=45;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6155(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{f.Locals[3]=f.Pop();f.Pc=3;continue;}
case 3:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/combat/CombatView","getBandsWithDefenders","()Ljava/util/Map;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",13);}
case 13:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=19;continue;}
case 19:{f.Pc=29;continue;}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 29:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",36);}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",43);}
case 43:{f.Locals[4]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",52);}
case 52:{f.Pc=f.Pop().Int==0?104:55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",62);}
case 62:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=65;continue;}
case 65:{f.Locals[5]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[5]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",74);}
case 74:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntityView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/GameEntityView","equals","(Ljava/lang/Object;)Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int==0?101:84;continue;}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[5]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",92);}
case 92:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",100);}
case 100:{f.StackOp("pop");f.Pc=101;continue;}
case 101:{f.Pc=45;continue;}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6156(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?5:4;continue;}
case 4:{return JStep.ReturnVoid;}
case 5:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",12);}
case 12:{f.Locals[5]=f.Pop();f.Pc=14;continue;}
case 14:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",21);}
case 21:{f.Locals[6]=f.Pop();f.Pc=23;continue;}
case 23:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",30);}
case 30:{f.Locals[7]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/lang/Iterable;)Z","invokevirtual",38);}
case 38:{f.StackOp("pop");f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Reference==null?50:43;continue;}
case 43:{f.Push(f.Locals[6]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/lang/Iterable;)Z","invokevirtual",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Pc=f.Pop().Reference==null?63:55;continue;}
case 55:{f.Push(f.Locals[7]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/lang/Iterable;)Z","invokevirtual",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",68);}
case 68:{f.Locals[8]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[8]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",77);}
case 77:{f.Pc=f.Pop().Int==0?136:80;continue;}
case 80:{f.Push(f.Locals[8]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",87);}
case 87:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=90;continue;}
case 90:{f.Locals[9]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/combat/CombatView","getAttackersWithDefenders","()Ljava/util/Map;","invokevirtual",96);}
case 96:{f.Push(f.Locals[9]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",104);}
case 104:{f.StackOp("pop");f.Pc=105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/combat/CombatView","getAttackersWithBlockers","()Ljava/util/Map;","invokevirtual",109);}
case 109:{f.Push(f.Locals[9]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[6]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",118);}
case 118:{f.StackOp("pop");f.Pc=119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/combat/CombatView","getAttackersWithPlannedBlockers","()Ljava/util/Map;","invokevirtual",123);}
case 123:{f.Push(f.Locals[9]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[7]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",132);}
case 132:{f.StackOp("pop");f.Pc=133;continue;}
case 133:{f.Pc=70;continue;}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/combat/CombatView","getBandsWithDefenders","()Ljava/util/Map;","invokevirtual",140);}
case 140:{f.Push(f.Locals[5]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[2]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",148);}
case 148:{f.StackOp("pop");f.Pc=149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/combat/CombatView","getBandsWithBlockers","()Ljava/util/Map;","invokevirtual",153);}
case 153:{f.Push(f.Locals[5]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[6]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",162);}
case 162:{f.StackOp("pop");f.Pc=163;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/combat/CombatView","getBandsWithPlannedBlockers","()Ljava/util/Map;","invokevirtual",167);}
case 167:{f.Push(f.Locals[5]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[7]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",176);}
case 176:{f.StackOp("pop");f.Pc=177;continue;}
case 177:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6157(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(-2));f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/combat/CombatView","nextId","I"))return JStep.Continue;rt.PutStatic("forge/game/combat/CombatView","nextId","I",f.Pop());f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
