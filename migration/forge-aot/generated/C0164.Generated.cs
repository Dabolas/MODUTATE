// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C164{
internal static JClass Build(){var c=new JClass("forge/game/GameStage","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("BeforeMulligan","Lforge/game/GameStage;",true,JValue.Default("Lforge/game/GameStage;"),null));
c.Add(new JField("Mulligan","Lforge/game/GameStage;",true,JValue.Default("Lforge/game/GameStage;"),null));
c.Add(new JField("Play","Lforge/game/GameStage;",true,JValue.Default("Lforge/game/GameStage;"),null));
c.Add(new JField("RestartedByKarn","Lforge/game/GameStage;",true,JValue.Default("Lforge/game/GameStage;"),null));
c.Add(new JField("GameOver","Lforge/game/GameStage;",true,JValue.Default("Lforge/game/GameStage;"),null));
c.Add(new JField("$VALUES","[Lforge/game/GameStage;",true,JValue.Default("[Lforge/game/GameStage;"),null));
c.Add(new JMethod(2576,"forge/game/GameStage","values","()[Lforge/game/GameStage;",9,0,1,new JHandler[]{},M2576));
c.Add(new JMethod(2577,"forge/game/GameStage","valueOf","(Ljava/lang/String;)Lforge/game/GameStage;",9,1,2,new JHandler[]{},M2577));
c.Add(new JMethod(2578,"forge/game/GameStage","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M2578));
c.Add(new JMethod(2579,"forge/game/GameStage","$values","()[Lforge/game/GameStage;",4106,0,4,new JHandler[]{},M2579));
c.Add(new JMethod(2580,"forge/game/GameStage","<clinit>","()V",8,0,4,new JHandler[]{},M2580));
}

internal static JStep M2576(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/GameStage","$VALUES","[Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","$VALUES","[Lforge/game/GameStage;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/GameStage;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/GameStage;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2577(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/GameStage")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameStage"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2578(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2579(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(5));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Lforge/game/GameStage;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/GameStage","BeforeMulligan","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","BeforeMulligan","Lforge/game/GameStage;"));f.Pc=9;continue;}
case 9:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/GameStage","Mulligan","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","Mulligan","Lforge/game/GameStage;"));f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/game/GameStage","Play","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","Play","Lforge/game/GameStage;"));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.I(3));f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/GameStage","RestartedByKarn","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","RestartedByKarn","Lforge/game/GameStage;"));f.Pc=27;continue;}
case 27:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{f.Push(JValue.I(4));f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/GameStage","GameOver","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","GameOver","Lforge/game/GameStage;"));f.Pc=33;continue;}
case 33:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=34;continue;}
case 34:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2580(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/GameStage"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameStage")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("BeforeMulligan")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/GameStage","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/game/GameStage","BeforeMulligan","Lforge/game/GameStage;"))return JStep.Continue;rt.PutStatic("forge/game/GameStage","BeforeMulligan","Lforge/game/GameStage;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/game/GameStage"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameStage")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Mulligan")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/GameStage","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/game/GameStage","Mulligan","Lforge/game/GameStage;"))return JStep.Continue;rt.PutStatic("forge/game/GameStage","Mulligan","Lforge/game/GameStage;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/game/GameStage"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameStage")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("Play")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/GameStage","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/game/GameStage","Play","Lforge/game/GameStage;"))return JStep.Continue;rt.PutStatic("forge/game/GameStage","Play","Lforge/game/GameStage;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/game/GameStage"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameStage")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("RestartedByKarn")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/GameStage","<init>","(Ljava/lang/String;I)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/game/GameStage","RestartedByKarn","Lforge/game/GameStage;"))return JStep.Continue;rt.PutStatic("forge/game/GameStage","RestartedByKarn","Lforge/game/GameStage;",f.Pop());f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/game/GameStage"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameStage")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("GameOver")));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(4));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/GameStage","<init>","(Ljava/lang/String;I)V","invokespecial",62);}
case 62:{if(!rt.StaticReady(f,"forge/game/GameStage","GameOver","Lforge/game/GameStage;"))return JStep.Continue;rt.PutStatic("forge/game/GameStage","GameOver","Lforge/game/GameStage;",f.Pop());f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/GameStage","$values","()[Lforge/game/GameStage;","invokestatic",68);}
case 68:{if(!rt.StaticReady(f,"forge/game/GameStage","$VALUES","[Lforge/game/GameStage;"))return JStep.Continue;rt.PutStatic("forge/game/GameStage","$VALUES","[Lforge/game/GameStage;",f.Pop());f.Pc=71;continue;}
case 71:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
