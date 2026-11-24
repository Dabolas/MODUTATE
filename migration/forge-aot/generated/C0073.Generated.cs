// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C73{
internal static JClass Build(){var c=new JClass("forge/card/RemoveType","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("SuperTypes","Lforge/card/RemoveType;",true,JValue.Default("Lforge/card/RemoveType;"),null));
c.Add(new JField("CardTypes","Lforge/card/RemoveType;",true,JValue.Default("Lforge/card/RemoveType;"),null));
c.Add(new JField("SubTypes","Lforge/card/RemoveType;",true,JValue.Default("Lforge/card/RemoveType;"),null));
c.Add(new JField("LandTypes","Lforge/card/RemoveType;",true,JValue.Default("Lforge/card/RemoveType;"),null));
c.Add(new JField("CreatureTypes","Lforge/card/RemoveType;",true,JValue.Default("Lforge/card/RemoveType;"),null));
c.Add(new JField("ArtifactTypes","Lforge/card/RemoveType;",true,JValue.Default("Lforge/card/RemoveType;"),null));
c.Add(new JField("EnchantmentTypes","Lforge/card/RemoveType;",true,JValue.Default("Lforge/card/RemoveType;"),null));
c.Add(new JField("$VALUES","[Lforge/card/RemoveType;",true,JValue.Default("[Lforge/card/RemoveType;"),null));
c.Add(new JMethod(1175,"forge/card/RemoveType","values","()[Lforge/card/RemoveType;",9,0,1,new JHandler[]{},M1175));
c.Add(new JMethod(1176,"forge/card/RemoveType","valueOf","(Ljava/lang/String;)Lforge/card/RemoveType;",9,1,2,new JHandler[]{},M1176));
c.Add(new JMethod(1177,"forge/card/RemoveType","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M1177));
c.Add(new JMethod(1178,"forge/card/RemoveType","$values","()[Lforge/card/RemoveType;",4106,0,4,new JHandler[]{},M1178));
c.Add(new JMethod(1179,"forge/card/RemoveType","<clinit>","()V",8,0,4,new JHandler[]{},M1179));
}

internal static JStep M1175(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/RemoveType","$VALUES","[Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","$VALUES","[Lforge/card/RemoveType;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/RemoveType;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/RemoveType;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1176(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/RemoveType")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/RemoveType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1177(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1178(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(7));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/card/RemoveType;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/RemoveType","SuperTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","SuperTypes","Lforge/card/RemoveType;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/RemoveType","CardTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","CardTypes","Lforge/card/RemoveType;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/RemoveType","SubTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","SubTypes","Lforge/card/RemoveType;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/RemoveType","LandTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","LandTypes","Lforge/card/RemoveType;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/card/RemoveType","CreatureTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","CreatureTypes","Lforge/card/RemoveType;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/RemoveType","ArtifactTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","ArtifactTypes","Lforge/card/RemoveType;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/card/RemoveType","EnchantmentTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","EnchantmentTypes","Lforge/card/RemoveType;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1179(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/RemoveType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/RemoveType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("SuperTypes")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/RemoveType","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/card/RemoveType","SuperTypes","Lforge/card/RemoveType;"))return JStep.Continue;rt.PutStatic("forge/card/RemoveType","SuperTypes","Lforge/card/RemoveType;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/card/RemoveType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/RemoveType")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("CardTypes")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/RemoveType","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/card/RemoveType","CardTypes","Lforge/card/RemoveType;"))return JStep.Continue;rt.PutStatic("forge/card/RemoveType","CardTypes","Lforge/card/RemoveType;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/card/RemoveType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/RemoveType")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("SubTypes")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/RemoveType","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/card/RemoveType","SubTypes","Lforge/card/RemoveType;"))return JStep.Continue;rt.PutStatic("forge/card/RemoveType","SubTypes","Lforge/card/RemoveType;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/card/RemoveType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/RemoveType")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("LandTypes")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/card/RemoveType","<init>","(Ljava/lang/String;I)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/card/RemoveType","LandTypes","Lforge/card/RemoveType;"))return JStep.Continue;rt.PutStatic("forge/card/RemoveType","LandTypes","Lforge/card/RemoveType;",f.Pop());f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/card/RemoveType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/RemoveType")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("CreatureTypes")));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(4));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/card/RemoveType","<init>","(Ljava/lang/String;I)V","invokespecial",62);}
case 62:{if(!rt.StaticReady(f,"forge/card/RemoveType","CreatureTypes","Lforge/card/RemoveType;"))return JStep.Continue;rt.PutStatic("forge/card/RemoveType","CreatureTypes","Lforge/card/RemoveType;",f.Pop());f.Pc=65;continue;}
case 65:{if(!rt.EnsureInitialized(f,"forge/card/RemoveType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/RemoveType")));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("ArtifactTypes")));f.Pc=71;continue;}
case 71:{f.Push(JValue.I(5));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/card/RemoveType","<init>","(Ljava/lang/String;I)V","invokespecial",75);}
case 75:{if(!rt.StaticReady(f,"forge/card/RemoveType","ArtifactTypes","Lforge/card/RemoveType;"))return JStep.Continue;rt.PutStatic("forge/card/RemoveType","ArtifactTypes","Lforge/card/RemoveType;",f.Pop());f.Pc=78;continue;}
case 78:{if(!rt.EnsureInitialized(f,"forge/card/RemoveType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/RemoveType")));f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("EnchantmentTypes")));f.Pc=84;continue;}
case 84:{f.Push(JValue.I(6));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/card/RemoveType","<init>","(Ljava/lang/String;I)V","invokespecial",89);}
case 89:{if(!rt.StaticReady(f,"forge/card/RemoveType","EnchantmentTypes","Lforge/card/RemoveType;"))return JStep.Continue;rt.PutStatic("forge/card/RemoveType","EnchantmentTypes","Lforge/card/RemoveType;",f.Pop());f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/card/RemoveType","$values","()[Lforge/card/RemoveType;","invokestatic",95);}
case 95:{if(!rt.StaticReady(f,"forge/card/RemoveType","$VALUES","[Lforge/card/RemoveType;"))return JStep.Continue;rt.PutStatic("forge/card/RemoveType","$VALUES","[Lforge/card/RemoveType;",f.Pop());f.Pc=98;continue;}
case 98:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
