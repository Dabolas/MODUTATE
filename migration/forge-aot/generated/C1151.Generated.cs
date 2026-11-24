// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1151{
internal static JClass Build(){var c=new JClass("forge/util/PredicateString$StringOp","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("CONTAINS","Lforge/util/PredicateString$StringOp;",true,JValue.Default("Lforge/util/PredicateString$StringOp;"),null));
c.Add(new JField("CONTAINS_IC","Lforge/util/PredicateString$StringOp;",true,JValue.Default("Lforge/util/PredicateString$StringOp;"),null));
c.Add(new JField("EQUALS","Lforge/util/PredicateString$StringOp;",true,JValue.Default("Lforge/util/PredicateString$StringOp;"),null));
c.Add(new JField("EQUALS_IC","Lforge/util/PredicateString$StringOp;",true,JValue.Default("Lforge/util/PredicateString$StringOp;"),null));
c.Add(new JField("$VALUES","[Lforge/util/PredicateString$StringOp;",true,JValue.Default("[Lforge/util/PredicateString$StringOp;"),null));
c.Add(new JMethod(11993,"forge/util/PredicateString$StringOp","values","()[Lforge/util/PredicateString$StringOp;",9,0,1,new JHandler[]{},M11993));
c.Add(new JMethod(11994,"forge/util/PredicateString$StringOp","valueOf","(Ljava/lang/String;)Lforge/util/PredicateString$StringOp;",9,1,2,new JHandler[]{},M11994));
c.Add(new JMethod(11995,"forge/util/PredicateString$StringOp","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M11995));
c.Add(new JMethod(11996,"forge/util/PredicateString$StringOp","$values","()[Lforge/util/PredicateString$StringOp;",4106,0,4,new JHandler[]{},M11996));
c.Add(new JMethod(11997,"forge/util/PredicateString$StringOp","<clinit>","()V",8,0,4,new JHandler[]{},M11997));
}

internal static JStep M11993(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","$VALUES","[Lforge/util/PredicateString$StringOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/PredicateString$StringOp","$VALUES","[Lforge/util/PredicateString$StringOp;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/util/PredicateString$StringOp;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/util/PredicateString$StringOp;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11994(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/util/PredicateString$StringOp")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/PredicateString$StringOp"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11995(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11996(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(4));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Lforge/util/PredicateString$StringOp;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","CONTAINS","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/PredicateString$StringOp","CONTAINS","Lforge/util/PredicateString$StringOp;"));f.Pc=9;continue;}
case 9:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","CONTAINS_IC","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/PredicateString$StringOp","CONTAINS_IC","Lforge/util/PredicateString$StringOp;"));f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","EQUALS","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/PredicateString$StringOp","EQUALS","Lforge/util/PredicateString$StringOp;"));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.I(3));f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","EQUALS_IC","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/PredicateString$StringOp","EQUALS_IC","Lforge/util/PredicateString$StringOp;"));f.Pc=27;continue;}
case 27:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11997(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/PredicateString$StringOp"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/PredicateString$StringOp")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("CONTAINS")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/util/PredicateString$StringOp","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","CONTAINS","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;rt.PutStatic("forge/util/PredicateString$StringOp","CONTAINS","Lforge/util/PredicateString$StringOp;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/util/PredicateString$StringOp"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/PredicateString$StringOp")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("CONTAINS_IC")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/util/PredicateString$StringOp","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","CONTAINS_IC","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;rt.PutStatic("forge/util/PredicateString$StringOp","CONTAINS_IC","Lforge/util/PredicateString$StringOp;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/util/PredicateString$StringOp"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/PredicateString$StringOp")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("EQUALS")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/util/PredicateString$StringOp","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","EQUALS","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;rt.PutStatic("forge/util/PredicateString$StringOp","EQUALS","Lforge/util/PredicateString$StringOp;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/util/PredicateString$StringOp"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/PredicateString$StringOp")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("EQUALS_IC")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/util/PredicateString$StringOp","<init>","(Ljava/lang/String;I)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","EQUALS_IC","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;rt.PutStatic("forge/util/PredicateString$StringOp","EQUALS_IC","Lforge/util/PredicateString$StringOp;",f.Pop());f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/util/PredicateString$StringOp","$values","()[Lforge/util/PredicateString$StringOp;","invokestatic",55);}
case 55:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","$VALUES","[Lforge/util/PredicateString$StringOp;"))return JStep.Continue;rt.PutStatic("forge/util/PredicateString$StringOp","$VALUES","[Lforge/util/PredicateString$StringOp;",f.Pop());f.Pc=58;continue;}
case 58:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
