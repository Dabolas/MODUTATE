// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C464{
internal static JClass Build(){var c=new JClass("forge/game/card/CardPlayOption$PayManaCost","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("YES","Lforge/game/card/CardPlayOption$PayManaCost;",true,JValue.Default("Lforge/game/card/CardPlayOption$PayManaCost;"),null));
c.Add(new JField("NO","Lforge/game/card/CardPlayOption$PayManaCost;",true,JValue.Default("Lforge/game/card/CardPlayOption$PayManaCost;"),null));
c.Add(new JField("$VALUES","[Lforge/game/card/CardPlayOption$PayManaCost;",true,JValue.Default("[Lforge/game/card/CardPlayOption$PayManaCost;"),null));
c.Add(new JMethod(5131,"forge/game/card/CardPlayOption$PayManaCost","values","()[Lforge/game/card/CardPlayOption$PayManaCost;",9,0,1,new JHandler[]{},M5131));
c.Add(new JMethod(5132,"forge/game/card/CardPlayOption$PayManaCost","valueOf","(Ljava/lang/String;)Lforge/game/card/CardPlayOption$PayManaCost;",9,1,2,new JHandler[]{},M5132));
c.Add(new JMethod(5133,"forge/game/card/CardPlayOption$PayManaCost","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M5133));
c.Add(new JMethod(5134,"forge/game/card/CardPlayOption$PayManaCost","$values","()[Lforge/game/card/CardPlayOption$PayManaCost;",4106,0,4,new JHandler[]{},M5134));
c.Add(new JMethod(5135,"forge/game/card/CardPlayOption$PayManaCost","<clinit>","()V",8,0,4,new JHandler[]{},M5135));
}

internal static JStep M5131(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/card/CardPlayOption$PayManaCost","$VALUES","[Lforge/game/card/CardPlayOption$PayManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPlayOption$PayManaCost","$VALUES","[Lforge/game/card/CardPlayOption$PayManaCost;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/card/CardPlayOption$PayManaCost;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/card/CardPlayOption$PayManaCost;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5132(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/card/CardPlayOption$PayManaCost")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardPlayOption$PayManaCost"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5133(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5134(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(2));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/CardPlayOption$PayManaCost;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/card/CardPlayOption$PayManaCost","YES","Lforge/game/card/CardPlayOption$PayManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPlayOption$PayManaCost","YES","Lforge/game/card/CardPlayOption$PayManaCost;"));f.Pc=9;continue;}
case 9:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/card/CardPlayOption$PayManaCost","NO","Lforge/game/card/CardPlayOption$PayManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPlayOption$PayManaCost","NO","Lforge/game/card/CardPlayOption$PayManaCost;"));f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5135(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardPlayOption$PayManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardPlayOption$PayManaCost")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("YES")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/CardPlayOption$PayManaCost","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/game/card/CardPlayOption$PayManaCost","YES","Lforge/game/card/CardPlayOption$PayManaCost;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPlayOption$PayManaCost","YES","Lforge/game/card/CardPlayOption$PayManaCost;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/game/card/CardPlayOption$PayManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardPlayOption$PayManaCost")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("NO")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardPlayOption$PayManaCost","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/game/card/CardPlayOption$PayManaCost","NO","Lforge/game/card/CardPlayOption$PayManaCost;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPlayOption$PayManaCost","NO","Lforge/game/card/CardPlayOption$PayManaCost;",f.Pop());f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/CardPlayOption$PayManaCost","$values","()[Lforge/game/card/CardPlayOption$PayManaCost;","invokestatic",29);}
case 29:{if(!rt.StaticReady(f,"forge/game/card/CardPlayOption$PayManaCost","$VALUES","[Lforge/game/card/CardPlayOption$PayManaCost;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPlayOption$PayManaCost","$VALUES","[Lforge/game/card/CardPlayOption$PayManaCost;",f.Pop());f.Pc=32;continue;}
case 32:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
