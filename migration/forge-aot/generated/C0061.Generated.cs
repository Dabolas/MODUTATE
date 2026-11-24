// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C61{
internal static JClass Build(){var c=new JClass("forge/card/DraftOptions$DoublePick","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("NEVER","Lforge/card/DraftOptions$DoublePick;",true,JValue.Default("Lforge/card/DraftOptions$DoublePick;"),null));
c.Add(new JField("FIRST_PICK","Lforge/card/DraftOptions$DoublePick;",true,JValue.Default("Lforge/card/DraftOptions$DoublePick;"),null));
c.Add(new JField("WHEN_POD_SIZE_IS_4","Lforge/card/DraftOptions$DoublePick;",true,JValue.Default("Lforge/card/DraftOptions$DoublePick;"),null));
c.Add(new JField("ALWAYS","Lforge/card/DraftOptions$DoublePick;",true,JValue.Default("Lforge/card/DraftOptions$DoublePick;"),null));
c.Add(new JField("$VALUES","[Lforge/card/DraftOptions$DoublePick;",true,JValue.Default("[Lforge/card/DraftOptions$DoublePick;"),null));
c.Add(new JMethod(1045,"forge/card/DraftOptions$DoublePick","values","()[Lforge/card/DraftOptions$DoublePick;",9,0,1,new JHandler[]{},M1045));
c.Add(new JMethod(1046,"forge/card/DraftOptions$DoublePick","valueOf","(Ljava/lang/String;)Lforge/card/DraftOptions$DoublePick;",9,1,2,new JHandler[]{},M1046));
c.Add(new JMethod(1047,"forge/card/DraftOptions$DoublePick","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M1047));
c.Add(new JMethod(1048,"forge/card/DraftOptions$DoublePick","resolve","(I)Lforge/card/DraftOptions$DoublePick;",1,2,2,new JHandler[]{},M1048));
c.Add(new JMethod(1049,"forge/card/DraftOptions$DoublePick","$values","()[Lforge/card/DraftOptions$DoublePick;",4106,0,4,new JHandler[]{},M1049));
c.Add(new JMethod(1050,"forge/card/DraftOptions$DoublePick","<clinit>","()V",8,0,4,new JHandler[]{},M1050));
}

internal static JStep M1045(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","$VALUES","[Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DraftOptions$DoublePick","$VALUES","[Lforge/card/DraftOptions$DoublePick;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/DraftOptions$DoublePick;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/DraftOptions$DoublePick;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1046(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/DraftOptions$DoublePick")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/DraftOptions$DoublePick"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1047(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1048(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","WHEN_POD_SIZE_IS_4","Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DraftOptions$DoublePick","WHEN_POD_SIZE_IS_4","Lforge/card/DraftOptions$DoublePick;"));f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?24:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(4));f.Pc=9;continue;}
case 9:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?18:12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","ALWAYS","Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DraftOptions$DoublePick","ALWAYS","Lforge/card/DraftOptions$DoublePick;"));f.Pc=15;continue;}
case 15:{f.Pc=25;continue;}
case 18:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","NEVER","Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DraftOptions$DoublePick","NEVER","Lforge/card/DraftOptions$DoublePick;"));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1049(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(4));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Lforge/card/DraftOptions$DoublePick;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","NEVER","Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DraftOptions$DoublePick","NEVER","Lforge/card/DraftOptions$DoublePick;"));f.Pc=9;continue;}
case 9:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","FIRST_PICK","Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DraftOptions$DoublePick","FIRST_PICK","Lforge/card/DraftOptions$DoublePick;"));f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","WHEN_POD_SIZE_IS_4","Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DraftOptions$DoublePick","WHEN_POD_SIZE_IS_4","Lforge/card/DraftOptions$DoublePick;"));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.I(3));f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","ALWAYS","Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DraftOptions$DoublePick","ALWAYS","Lforge/card/DraftOptions$DoublePick;"));f.Pc=27;continue;}
case 27:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1050(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/DraftOptions$DoublePick"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/DraftOptions$DoublePick")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("NEVER")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/DraftOptions$DoublePick","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","NEVER","Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;rt.PutStatic("forge/card/DraftOptions$DoublePick","NEVER","Lforge/card/DraftOptions$DoublePick;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/card/DraftOptions$DoublePick"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/DraftOptions$DoublePick")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("FIRST_PICK")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/DraftOptions$DoublePick","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","FIRST_PICK","Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;rt.PutStatic("forge/card/DraftOptions$DoublePick","FIRST_PICK","Lforge/card/DraftOptions$DoublePick;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/card/DraftOptions$DoublePick"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/DraftOptions$DoublePick")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("WHEN_POD_SIZE_IS_4")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/DraftOptions$DoublePick","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","WHEN_POD_SIZE_IS_4","Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;rt.PutStatic("forge/card/DraftOptions$DoublePick","WHEN_POD_SIZE_IS_4","Lforge/card/DraftOptions$DoublePick;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/card/DraftOptions$DoublePick"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/DraftOptions$DoublePick")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("ALWAYS")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/card/DraftOptions$DoublePick","<init>","(Ljava/lang/String;I)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","ALWAYS","Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;rt.PutStatic("forge/card/DraftOptions$DoublePick","ALWAYS","Lforge/card/DraftOptions$DoublePick;",f.Pop());f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/card/DraftOptions$DoublePick","$values","()[Lforge/card/DraftOptions$DoublePick;","invokestatic",55);}
case 55:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","$VALUES","[Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;rt.PutStatic("forge/card/DraftOptions$DoublePick","$VALUES","[Lforge/card/DraftOptions$DoublePick;",f.Pop());f.Pc=58;continue;}
case 58:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
