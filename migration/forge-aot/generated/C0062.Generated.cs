// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C62{
internal static JClass Build(){var c=new JClass("forge/card/GamePieceType","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("CARD","Lforge/card/GamePieceType;",true,JValue.Default("Lforge/card/GamePieceType;"),null));
c.Add(new JField("TOKEN","Lforge/card/GamePieceType;",true,JValue.Default("Lforge/card/GamePieceType;"),null));
c.Add(new JField("EFFECT","Lforge/card/GamePieceType;",true,JValue.Default("Lforge/card/GamePieceType;"),null));
c.Add(new JField("COPIED_SPELL","Lforge/card/GamePieceType;",true,JValue.Default("Lforge/card/GamePieceType;"),null));
c.Add(new JField("ATTRACTION","Lforge/card/GamePieceType;",true,JValue.Default("Lforge/card/GamePieceType;"),null));
c.Add(new JField("CONTRAPTION","Lforge/card/GamePieceType;",true,JValue.Default("Lforge/card/GamePieceType;"),null));
c.Add(new JField("PLANAR","Lforge/card/GamePieceType;",true,JValue.Default("Lforge/card/GamePieceType;"),null));
c.Add(new JField("SCHEME","Lforge/card/GamePieceType;",true,JValue.Default("Lforge/card/GamePieceType;"),null));
c.Add(new JField("AVATAR","Lforge/card/GamePieceType;",true,JValue.Default("Lforge/card/GamePieceType;"),null));
c.Add(new JField("DUNGEON","Lforge/card/GamePieceType;",true,JValue.Default("Lforge/card/GamePieceType;"),null));
c.Add(new JField("STICKER_SHEET","Lforge/card/GamePieceType;",true,JValue.Default("Lforge/card/GamePieceType;"),null));
c.Add(new JField("$VALUES","[Lforge/card/GamePieceType;",true,JValue.Default("[Lforge/card/GamePieceType;"),null));
c.Add(new JMethod(1051,"forge/card/GamePieceType","values","()[Lforge/card/GamePieceType;",9,0,1,new JHandler[]{},M1051));
c.Add(new JMethod(1052,"forge/card/GamePieceType","valueOf","(Ljava/lang/String;)Lforge/card/GamePieceType;",9,1,2,new JHandler[]{},M1052));
c.Add(new JMethod(1053,"forge/card/GamePieceType","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M1053));
c.Add(new JMethod(1054,"forge/card/GamePieceType","$values","()[Lforge/card/GamePieceType;",4106,0,4,new JHandler[]{},M1054));
c.Add(new JMethod(1055,"forge/card/GamePieceType","<clinit>","()V",8,0,4,new JHandler[]{},M1055));
}

internal static JStep M1051(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/GamePieceType","$VALUES","[Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","$VALUES","[Lforge/card/GamePieceType;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/GamePieceType;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/GamePieceType;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1052(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/GamePieceType")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/GamePieceType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1053(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1054(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(11));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/card/GamePieceType;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/GamePieceType","CARD","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","CARD","Lforge/card/GamePieceType;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/GamePieceType","COPIED_SPELL","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","COPIED_SPELL","Lforge/card/GamePieceType;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/card/GamePieceType","ATTRACTION","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","ATTRACTION","Lforge/card/GamePieceType;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/GamePieceType","CONTRAPTION","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","CONTRAPTION","Lforge/card/GamePieceType;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/card/GamePieceType","PLANAR","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","PLANAR","Lforge/card/GamePieceType;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/card/GamePieceType","SCHEME","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","SCHEME","Lforge/card/GamePieceType;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/card/GamePieceType","AVATAR","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","AVATAR","Lforge/card/GamePieceType;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/card/GamePieceType","DUNGEON","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","DUNGEON","Lforge/card/GamePieceType;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/card/GamePieceType","STICKER_SHEET","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","STICKER_SHEET","Lforge/card/GamePieceType;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1055(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/GamePieceType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/GamePieceType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("CARD")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/GamePieceType","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/card/GamePieceType","CARD","Lforge/card/GamePieceType;"))return JStep.Continue;rt.PutStatic("forge/card/GamePieceType","CARD","Lforge/card/GamePieceType;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/card/GamePieceType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/GamePieceType")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("TOKEN")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/GamePieceType","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"))return JStep.Continue;rt.PutStatic("forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/card/GamePieceType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/GamePieceType")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("EFFECT")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/GamePieceType","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"))return JStep.Continue;rt.PutStatic("forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/card/GamePieceType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/GamePieceType")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("COPIED_SPELL")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/card/GamePieceType","<init>","(Ljava/lang/String;I)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/card/GamePieceType","COPIED_SPELL","Lforge/card/GamePieceType;"))return JStep.Continue;rt.PutStatic("forge/card/GamePieceType","COPIED_SPELL","Lforge/card/GamePieceType;",f.Pop());f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/card/GamePieceType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/GamePieceType")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("ATTRACTION")));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(4));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/card/GamePieceType","<init>","(Ljava/lang/String;I)V","invokespecial",62);}
case 62:{if(!rt.StaticReady(f,"forge/card/GamePieceType","ATTRACTION","Lforge/card/GamePieceType;"))return JStep.Continue;rt.PutStatic("forge/card/GamePieceType","ATTRACTION","Lforge/card/GamePieceType;",f.Pop());f.Pc=65;continue;}
case 65:{if(!rt.EnsureInitialized(f,"forge/card/GamePieceType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/GamePieceType")));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("CONTRAPTION")));f.Pc=71;continue;}
case 71:{f.Push(JValue.I(5));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/card/GamePieceType","<init>","(Ljava/lang/String;I)V","invokespecial",75);}
case 75:{if(!rt.StaticReady(f,"forge/card/GamePieceType","CONTRAPTION","Lforge/card/GamePieceType;"))return JStep.Continue;rt.PutStatic("forge/card/GamePieceType","CONTRAPTION","Lforge/card/GamePieceType;",f.Pop());f.Pc=78;continue;}
case 78:{if(!rt.EnsureInitialized(f,"forge/card/GamePieceType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/GamePieceType")));f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("PLANAR")));f.Pc=84;continue;}
case 84:{f.Push(JValue.I(6));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/card/GamePieceType","<init>","(Ljava/lang/String;I)V","invokespecial",89);}
case 89:{if(!rt.StaticReady(f,"forge/card/GamePieceType","PLANAR","Lforge/card/GamePieceType;"))return JStep.Continue;rt.PutStatic("forge/card/GamePieceType","PLANAR","Lforge/card/GamePieceType;",f.Pop());f.Pc=92;continue;}
case 92:{if(!rt.EnsureInitialized(f,"forge/card/GamePieceType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/GamePieceType")));f.Pc=95;continue;}
case 95:{f.StackOp("dup");f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("SCHEME")));f.Pc=98;continue;}
case 98:{f.Push(JValue.I(7));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/card/GamePieceType","<init>","(Ljava/lang/String;I)V","invokespecial",103);}
case 103:{if(!rt.StaticReady(f,"forge/card/GamePieceType","SCHEME","Lforge/card/GamePieceType;"))return JStep.Continue;rt.PutStatic("forge/card/GamePieceType","SCHEME","Lforge/card/GamePieceType;",f.Pop());f.Pc=106;continue;}
case 106:{if(!rt.EnsureInitialized(f,"forge/card/GamePieceType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/GamePieceType")));f.Pc=109;continue;}
case 109:{f.StackOp("dup");f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("AVATAR")));f.Pc=112;continue;}
case 112:{f.Push(JValue.I(8));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/card/GamePieceType","<init>","(Ljava/lang/String;I)V","invokespecial",117);}
case 117:{if(!rt.StaticReady(f,"forge/card/GamePieceType","AVATAR","Lforge/card/GamePieceType;"))return JStep.Continue;rt.PutStatic("forge/card/GamePieceType","AVATAR","Lforge/card/GamePieceType;",f.Pop());f.Pc=120;continue;}
case 120:{if(!rt.EnsureInitialized(f,"forge/card/GamePieceType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/GamePieceType")));f.Pc=123;continue;}
case 123:{f.StackOp("dup");f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("DUNGEON")));f.Pc=126;continue;}
case 126:{f.Push(JValue.I(9));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/card/GamePieceType","<init>","(Ljava/lang/String;I)V","invokespecial",131);}
case 131:{if(!rt.StaticReady(f,"forge/card/GamePieceType","DUNGEON","Lforge/card/GamePieceType;"))return JStep.Continue;rt.PutStatic("forge/card/GamePieceType","DUNGEON","Lforge/card/GamePieceType;",f.Pop());f.Pc=134;continue;}
case 134:{if(!rt.EnsureInitialized(f,"forge/card/GamePieceType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/GamePieceType")));f.Pc=137;continue;}
case 137:{f.StackOp("dup");f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("STICKER_SHEET")));f.Pc=140;continue;}
case 140:{f.Push(JValue.I(10));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/card/GamePieceType","<init>","(Ljava/lang/String;I)V","invokespecial",145);}
case 145:{if(!rt.StaticReady(f,"forge/card/GamePieceType","STICKER_SHEET","Lforge/card/GamePieceType;"))return JStep.Continue;rt.PutStatic("forge/card/GamePieceType","STICKER_SHEET","Lforge/card/GamePieceType;",f.Pop());f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/card/GamePieceType","$values","()[Lforge/card/GamePieceType;","invokestatic",151);}
case 151:{if(!rt.StaticReady(f,"forge/card/GamePieceType","$VALUES","[Lforge/card/GamePieceType;"))return JStep.Continue;rt.PutStatic("forge/card/GamePieceType","$VALUES","[Lforge/card/GamePieceType;",f.Pop());f.Pc=154;continue;}
case 154:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
