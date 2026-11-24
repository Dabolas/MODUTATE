// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C784{
internal static JClass Build(){var c=new JClass("forge/game/replacement/ReplacementLayer","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("CantHappen","Lforge/game/replacement/ReplacementLayer;",true,JValue.Default("Lforge/game/replacement/ReplacementLayer;"),null));
c.Add(new JField("Control","Lforge/game/replacement/ReplacementLayer;",true,JValue.Default("Lforge/game/replacement/ReplacementLayer;"),null));
c.Add(new JField("Copy","Lforge/game/replacement/ReplacementLayer;",true,JValue.Default("Lforge/game/replacement/ReplacementLayer;"),null));
c.Add(new JField("Transform","Lforge/game/replacement/ReplacementLayer;",true,JValue.Default("Lforge/game/replacement/ReplacementLayer;"),null));
c.Add(new JField("Other","Lforge/game/replacement/ReplacementLayer;",true,JValue.Default("Lforge/game/replacement/ReplacementLayer;"),null));
c.Add(new JField("$VALUES","[Lforge/game/replacement/ReplacementLayer;",true,JValue.Default("[Lforge/game/replacement/ReplacementLayer;"),null));
c.Add(new JMethod(9050,"forge/game/replacement/ReplacementLayer","values","()[Lforge/game/replacement/ReplacementLayer;",9,0,1,new JHandler[]{},M9050));
c.Add(new JMethod(9051,"forge/game/replacement/ReplacementLayer","valueOf","(Ljava/lang/String;)Lforge/game/replacement/ReplacementLayer;",9,1,2,new JHandler[]{},M9051));
c.Add(new JMethod(9052,"forge/game/replacement/ReplacementLayer","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M9052));
c.Add(new JMethod(9053,"forge/game/replacement/ReplacementLayer","smartValueOf","(Ljava/lang/String;)Lforge/game/replacement/ReplacementLayer;",9,6,3,new JHandler[]{},M9053));
c.Add(new JMethod(9054,"forge/game/replacement/ReplacementLayer","$values","()[Lforge/game/replacement/ReplacementLayer;",4106,0,4,new JHandler[]{},M9054));
c.Add(new JMethod(9055,"forge/game/replacement/ReplacementLayer","<clinit>","()V",8,0,4,new JHandler[]{},M9055));
}

internal static JStep M9050(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","$VALUES","[Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","$VALUES","[Lforge/game/replacement/ReplacementLayer;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/replacement/ReplacementLayer;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/replacement/ReplacementLayer;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9051(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/replacement/ReplacementLayer")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementLayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9052(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9053(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/replacement/ReplacementLayer","values","()[Lforge/game/replacement/ReplacementLayer;","invokestatic",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=17;continue;}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?54:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=31;continue;}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/replacement/ReplacementLayer","name","()Ljava/lang/String;","invokevirtual",38);}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","compareToIgnoreCase","(Ljava/lang/String;)I","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int!=0?48:45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{return JStep.Return(f.Pop());}
case 48:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=51;continue;}
case 51:{f.Pc=21;continue;}
case 54:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{return rt.DynamicCall(f,"forge/game/replacement/ReplacementLayer:9053:59:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",64);}
case 64:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",67);}
case 67:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9054(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(5));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Lforge/game/replacement/ReplacementLayer;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","CantHappen","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","CantHappen","Lforge/game/replacement/ReplacementLayer;"));f.Pc=9;continue;}
case 9:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Control","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Control","Lforge/game/replacement/ReplacementLayer;"));f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Copy","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Copy","Lforge/game/replacement/ReplacementLayer;"));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.I(3));f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Transform","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Transform","Lforge/game/replacement/ReplacementLayer;"));f.Pc=27;continue;}
case 27:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{f.Push(JValue.I(4));f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=33;continue;}
case 33:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=34;continue;}
case 34:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9055(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/replacement/ReplacementLayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/replacement/ReplacementLayer")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("CantHappen")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/replacement/ReplacementLayer","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","CantHappen","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;rt.PutStatic("forge/game/replacement/ReplacementLayer","CantHappen","Lforge/game/replacement/ReplacementLayer;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/game/replacement/ReplacementLayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/replacement/ReplacementLayer")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Control")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/replacement/ReplacementLayer","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Control","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;rt.PutStatic("forge/game/replacement/ReplacementLayer","Control","Lforge/game/replacement/ReplacementLayer;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/game/replacement/ReplacementLayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/replacement/ReplacementLayer")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("Copy")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/replacement/ReplacementLayer","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Copy","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;rt.PutStatic("forge/game/replacement/ReplacementLayer","Copy","Lforge/game/replacement/ReplacementLayer;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/game/replacement/ReplacementLayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/replacement/ReplacementLayer")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("Transform")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/replacement/ReplacementLayer","<init>","(Ljava/lang/String;I)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Transform","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;rt.PutStatic("forge/game/replacement/ReplacementLayer","Transform","Lforge/game/replacement/ReplacementLayer;",f.Pop());f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/game/replacement/ReplacementLayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/replacement/ReplacementLayer")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("Other")));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(4));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/replacement/ReplacementLayer","<init>","(Ljava/lang/String;I)V","invokespecial",62);}
case 62:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;rt.PutStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;",f.Pop());f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/replacement/ReplacementLayer","$values","()[Lforge/game/replacement/ReplacementLayer;","invokestatic",68);}
case 68:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","$VALUES","[Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;rt.PutStatic("forge/game/replacement/ReplacementLayer","$VALUES","[Lforge/game/replacement/ReplacementLayer;",f.Pop());f.Pc=71;continue;}
case 71:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
