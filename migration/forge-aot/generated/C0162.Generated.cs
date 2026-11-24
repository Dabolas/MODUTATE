// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C162{
internal static JClass Build(){var c=new JClass("forge/game/GameSnapshot$SnapshotEntityMap","java/lang/Object",new string[]{"forge/game/IEntityMap"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("this$0","Lforge/game/GameSnapshot;",false,JValue.Default("Lforge/game/GameSnapshot;"),null));
c.Add(new JMethod(2560,"forge/game/GameSnapshot$SnapshotEntityMap","<init>","(Lforge/game/GameSnapshot;)V",1,2,2,new JHandler[]{},M2560));
c.Add(new JMethod(2561,"forge/game/GameSnapshot$SnapshotEntityMap","getGame","()Lforge/game/Game;",1,1,1,new JHandler[]{},M2561));
c.Add(new JMethod(2562,"forge/game/GameSnapshot$SnapshotEntityMap","map","(Lforge/game/GameObject;)Lforge/game/GameObject;",1,2,3,new JHandler[]{},M2562));
c.Add(new JMethod(2563,"forge/game/GameSnapshot$SnapshotEntityMap","map","(Lforge/game/card/Card;)Lforge/game/card/Card;",1,2,3,new JHandler[]{},M2563));
c.Add(new JMethod(2564,"forge/game/GameSnapshot$SnapshotEntityMap","map","(Lforge/game/player/Player;)Lforge/game/player/Player;",1,2,3,new JHandler[]{},M2564));
}

internal static JStep M2560(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameSnapshot$SnapshotEntityMap","this$0","Lforge/game/GameSnapshot;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2561(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$SnapshotEntityMap","this$0","Lforge/game/GameSnapshot;"));f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","restore","Z"));f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Int==0?18:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$SnapshotEntityMap","this$0","Lforge/game/GameSnapshot;"));f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","origGame","Lforge/game/Game;"));f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$SnapshotEntityMap","this$0","Lforge/game/GameSnapshot;"));f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","newGame","Lforge/game/Game;"));f.Pc=25;continue;}
case 25:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2562(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?23:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$SnapshotEntityMap","this$0","Lforge/game/GameSnapshot;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/GameSnapshot$SnapshotEntityMap","getGame","()Lforge/game/Game;","invokevirtual",15);}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",22);}
case 22:{return JStep.Return(f.Pop());}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Int==0?46:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$SnapshotEntityMap","this$0","Lforge/game/GameSnapshot;"));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/GameSnapshot$SnapshotEntityMap","getGame","()Lforge/game/Game;","invokevirtual",38);}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",45);}
case 45:{return JStep.Return(f.Pop());}
case 46:{f.Push(JValue.R(null));f.Pc=47;continue;}
case 47:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2563(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$SnapshotEntityMap","this$0","Lforge/game/GameSnapshot;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameSnapshot$SnapshotEntityMap","getGame","()Lforge/game/Game;","invokevirtual",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2564(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$SnapshotEntityMap","this$0","Lforge/game/GameSnapshot;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameSnapshot$SnapshotEntityMap","getGame","()Lforge/game/Game;","invokevirtual",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
