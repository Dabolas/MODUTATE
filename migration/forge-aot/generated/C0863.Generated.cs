// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C863{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityLayer","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("COPY","Lforge/game/staticability/StaticAbilityLayer;",true,JValue.Default("Lforge/game/staticability/StaticAbilityLayer;"),null));
c.Add(new JField("CONTROL","Lforge/game/staticability/StaticAbilityLayer;",true,JValue.Default("Lforge/game/staticability/StaticAbilityLayer;"),null));
c.Add(new JField("TEXT","Lforge/game/staticability/StaticAbilityLayer;",true,JValue.Default("Lforge/game/staticability/StaticAbilityLayer;"),null));
c.Add(new JField("TYPE","Lforge/game/staticability/StaticAbilityLayer;",true,JValue.Default("Lforge/game/staticability/StaticAbilityLayer;"),null));
c.Add(new JField("COLOR","Lforge/game/staticability/StaticAbilityLayer;",true,JValue.Default("Lforge/game/staticability/StaticAbilityLayer;"),null));
c.Add(new JField("ABILITIES","Lforge/game/staticability/StaticAbilityLayer;",true,JValue.Default("Lforge/game/staticability/StaticAbilityLayer;"),null));
c.Add(new JField("CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;",true,JValue.Default("Lforge/game/staticability/StaticAbilityLayer;"),null));
c.Add(new JField("SETPT","Lforge/game/staticability/StaticAbilityLayer;",true,JValue.Default("Lforge/game/staticability/StaticAbilityLayer;"),null));
c.Add(new JField("MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;",true,JValue.Default("Lforge/game/staticability/StaticAbilityLayer;"),null));
c.Add(new JField("RULES","Lforge/game/staticability/StaticAbilityLayer;",true,JValue.Default("Lforge/game/staticability/StaticAbilityLayer;"),null));
c.Add(new JField("num","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("CONTINUOUS_LAYERS","Lcom/google/common/collect/ImmutableList;",true,JValue.Default("Lcom/google/common/collect/ImmutableList;"),null));
c.Add(new JField("CONTINUOUS_LAYERS_WITH_DEPENDENCY","Lcom/google/common/collect/ImmutableList;",true,JValue.Default("Lcom/google/common/collect/ImmutableList;"),null));
c.Add(new JField("$VALUES","[Lforge/game/staticability/StaticAbilityLayer;",true,JValue.Default("[Lforge/game/staticability/StaticAbilityLayer;"),null));
c.Add(new JMethod(10042,"forge/game/staticability/StaticAbilityLayer","values","()[Lforge/game/staticability/StaticAbilityLayer;",9,0,1,new JHandler[]{},M10042));
c.Add(new JMethod(10043,"forge/game/staticability/StaticAbilityLayer","valueOf","(Ljava/lang/String;)Lforge/game/staticability/StaticAbilityLayer;",9,1,2,new JHandler[]{},M10043));
c.Add(new JMethod(10044,"forge/game/staticability/StaticAbilityLayer","<init>","(Ljava/lang/String;ILjava/lang/String;)V",2,4,3,new JHandler[]{},M10044));
c.Add(new JMethod(10045,"forge/game/staticability/StaticAbilityLayer","$values","()[Lforge/game/staticability/StaticAbilityLayer;",4106,0,4,new JHandler[]{},M10045));
c.Add(new JMethod(10046,"forge/game/staticability/StaticAbilityLayer","<clinit>","()V",8,0,10,new JHandler[]{},M10046));
}

internal static JStep M10042(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","$VALUES","[Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","$VALUES","[Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/staticability/StaticAbilityLayer;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/staticability/StaticAbilityLayer;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10043(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/staticability/StaticAbilityLayer")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbilityLayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10044(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbilityLayer","num","Ljava/lang/String;",value);f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10045(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(10));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/game/staticability/StaticAbilityLayer;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","COPY","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","COPY","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CONTROL","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CONTROL","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","COLOR","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","COLOR","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10046(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityLayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityLayer")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("COPY")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("1")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/staticability/StaticAbilityLayer","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",12);}
case 12:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","COPY","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityLayer","COPY","Lforge/game/staticability/StaticAbilityLayer;",f.Pop());f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityLayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityLayer")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("CONTROL")));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("2")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/staticability/StaticAbilityLayer","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",27);}
case 27:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CONTROL","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityLayer","CONTROL","Lforge/game/staticability/StaticAbilityLayer;",f.Pop());f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityLayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityLayer")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("TEXT")));f.Pc=36;continue;}
case 36:{f.Push(JValue.I(2));f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("3")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/staticability/StaticAbilityLayer","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",42);}
case 42:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;",f.Pop());f.Pc=45;continue;}
case 45:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityLayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityLayer")));f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("TYPE")));f.Pc=51;continue;}
case 51:{f.Push(JValue.I(3));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("4")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/staticability/StaticAbilityLayer","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",57);}
case 57:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;",f.Pop());f.Pc=60;continue;}
case 60:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityLayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityLayer")));f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("COLOR")));f.Pc=66;continue;}
case 66:{f.Push(JValue.I(4));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("5")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/staticability/StaticAbilityLayer","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",72);}
case 72:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","COLOR","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityLayer","COLOR","Lforge/game/staticability/StaticAbilityLayer;",f.Pop());f.Pc=75;continue;}
case 75:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityLayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityLayer")));f.Pc=78;continue;}
case 78:{f.StackOp("dup");f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("ABILITIES")));f.Pc=81;continue;}
case 81:{f.Push(JValue.I(5));f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("6")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/staticability/StaticAbilityLayer","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",87);}
case 87:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;",f.Pop());f.Pc=90;continue;}
case 90:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityLayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityLayer")));f.Pc=93;continue;}
case 93:{f.StackOp("dup");f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("CHARACTERISTIC")));f.Pc=96;continue;}
case 96:{f.Push(JValue.I(6));f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("7a")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/staticability/StaticAbilityLayer","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",103);}
case 103:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;",f.Pop());f.Pc=106;continue;}
case 106:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityLayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityLayer")));f.Pc=109;continue;}
case 109:{f.StackOp("dup");f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("SETPT")));f.Pc=112;continue;}
case 112:{f.Push(JValue.I(7));f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("7b")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/staticability/StaticAbilityLayer","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",119);}
case 119:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;",f.Pop());f.Pc=122;continue;}
case 122:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityLayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityLayer")));f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("MODIFYPT")));f.Pc=128;continue;}
case 128:{f.Push(JValue.I(8));f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("7c")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/staticability/StaticAbilityLayer","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",135);}
case 135:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;",f.Pop());f.Pc=138;continue;}
case 138:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityLayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityLayer")));f.Pc=141;continue;}
case 141:{f.StackOp("dup");f.Pc=142;continue;}
case 142:{f.Push(JValue.R(rt.String("RULES")));f.Pc=144;continue;}
case 144:{f.Push(JValue.I(9));f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.String("8")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/staticability/StaticAbilityLayer","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",151);}
case 151:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;",f.Pop());f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/staticability/StaticAbilityLayer","$values","()[Lforge/game/staticability/StaticAbilityLayer;","invokestatic",157);}
case 157:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","$VALUES","[Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityLayer","$VALUES","[Lforge/game/staticability/StaticAbilityLayer;",f.Pop());f.Pc=160;continue;}
case 160:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","COPY","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","COPY","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=163;continue;}
case 163:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CONTROL","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CONTROL","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=166;continue;}
case 166:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=169;continue;}
case 169:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=172;continue;}
case 172:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","COLOR","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","COLOR","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=175;continue;}
case 175:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=178;continue;}
case 178:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=181;continue;}
case 181:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=184;continue;}
case 184:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=187;continue;}
case 187:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=190;continue;}
case 190:{return rt.Call(f,"com/google/common/collect/ImmutableList","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList;","invokestatic",193);}
case 193:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CONTINUOUS_LAYERS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityLayer","CONTINUOUS_LAYERS","Lcom/google/common/collect/ImmutableList;",f.Pop());f.Pc=196;continue;}
case 196:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","COPY","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","COPY","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=199;continue;}
case 199:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CONTROL","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CONTROL","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=202;continue;}
case 202:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=205;continue;}
case 205:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=208;continue;}
case 208:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=211;continue;}
case 211:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=214;continue;}
case 214:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=217;continue;}
case 217:{return rt.Call(f,"com/google/common/collect/ImmutableList","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList;","invokestatic",220);}
case 220:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CONTINUOUS_LAYERS_WITH_DEPENDENCY","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityLayer","CONTINUOUS_LAYERS_WITH_DEPENDENCY","Lcom/google/common/collect/ImmutableList;",f.Pop());f.Pc=223;continue;}
case 223:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
