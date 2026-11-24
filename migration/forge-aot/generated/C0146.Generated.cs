// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C146{
internal static JClass Build(){var c=new JClass("forge/game/GameFormat$FormatSubType","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("BLOCK","Lforge/game/GameFormat$FormatSubType;",true,JValue.Default("Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JField("STANDARD","Lforge/game/GameFormat$FormatSubType;",true,JValue.Default("Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JField("EXTENDED","Lforge/game/GameFormat$FormatSubType;",true,JValue.Default("Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JField("PAUPER","Lforge/game/GameFormat$FormatSubType;",true,JValue.Default("Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JField("PIONEER","Lforge/game/GameFormat$FormatSubType;",true,JValue.Default("Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JField("MODERN","Lforge/game/GameFormat$FormatSubType;",true,JValue.Default("Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JField("LEGACY","Lforge/game/GameFormat$FormatSubType;",true,JValue.Default("Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JField("VINTAGE","Lforge/game/GameFormat$FormatSubType;",true,JValue.Default("Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JField("COMMANDER","Lforge/game/GameFormat$FormatSubType;",true,JValue.Default("Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JField("PLANECHASE","Lforge/game/GameFormat$FormatSubType;",true,JValue.Default("Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JField("VIDEOGAME","Lforge/game/GameFormat$FormatSubType;",true,JValue.Default("Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JField("MTGO","Lforge/game/GameFormat$FormatSubType;",true,JValue.Default("Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JField("ARENA","Lforge/game/GameFormat$FormatSubType;",true,JValue.Default("Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JField("CUSTOM","Lforge/game/GameFormat$FormatSubType;",true,JValue.Default("Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JField("$VALUES","[Lforge/game/GameFormat$FormatSubType;",true,JValue.Default("[Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JMethod(2344,"forge/game/GameFormat$FormatSubType","values","()[Lforge/game/GameFormat$FormatSubType;",9,0,1,new JHandler[]{},M2344));
c.Add(new JMethod(2345,"forge/game/GameFormat$FormatSubType","valueOf","(Ljava/lang/String;)Lforge/game/GameFormat$FormatSubType;",9,1,2,new JHandler[]{},M2345));
c.Add(new JMethod(2346,"forge/game/GameFormat$FormatSubType","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M2346));
c.Add(new JMethod(2347,"forge/game/GameFormat$FormatSubType","$values","()[Lforge/game/GameFormat$FormatSubType;",4106,0,4,new JHandler[]{},M2347));
c.Add(new JMethod(2348,"forge/game/GameFormat$FormatSubType","<clinit>","()V",8,0,4,new JHandler[]{},M2348));
}

internal static JStep M2344(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","$VALUES","[Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","$VALUES","[Lforge/game/GameFormat$FormatSubType;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/GameFormat$FormatSubType;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/GameFormat$FormatSubType;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2345(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/GameFormat$FormatSubType")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat$FormatSubType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2346(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2347(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(14));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/game/GameFormat$FormatSubType;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","BLOCK","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","BLOCK","Lforge/game/GameFormat$FormatSubType;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","STANDARD","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","STANDARD","Lforge/game/GameFormat$FormatSubType;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","EXTENDED","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","EXTENDED","Lforge/game/GameFormat$FormatSubType;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","PAUPER","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","PAUPER","Lforge/game/GameFormat$FormatSubType;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","PIONEER","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","PIONEER","Lforge/game/GameFormat$FormatSubType;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","MODERN","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","MODERN","Lforge/game/GameFormat$FormatSubType;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","LEGACY","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","LEGACY","Lforge/game/GameFormat$FormatSubType;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","VINTAGE","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","VINTAGE","Lforge/game/GameFormat$FormatSubType;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","COMMANDER","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","COMMANDER","Lforge/game/GameFormat$FormatSubType;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","PLANECHASE","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","PLANECHASE","Lforge/game/GameFormat$FormatSubType;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","VIDEOGAME","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","VIDEOGAME","Lforge/game/GameFormat$FormatSubType;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(11));f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","MTGO","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","MTGO","Lforge/game/GameFormat$FormatSubType;"));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(12));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","ARENA","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","ARENA","Lforge/game/GameFormat$FormatSubType;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(13));f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","CUSTOM","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","CUSTOM","Lforge/game/GameFormat$FormatSubType;"));f.Pc=96;continue;}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2348(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$FormatSubType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$FormatSubType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("BLOCK")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","BLOCK","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$FormatSubType","BLOCK","Lforge/game/GameFormat$FormatSubType;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$FormatSubType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$FormatSubType")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("STANDARD")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","STANDARD","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$FormatSubType","STANDARD","Lforge/game/GameFormat$FormatSubType;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$FormatSubType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$FormatSubType")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("EXTENDED")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","EXTENDED","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$FormatSubType","EXTENDED","Lforge/game/GameFormat$FormatSubType;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$FormatSubType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$FormatSubType")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("PAUPER")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","<init>","(Ljava/lang/String;I)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","PAUPER","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$FormatSubType","PAUPER","Lforge/game/GameFormat$FormatSubType;",f.Pop());f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$FormatSubType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$FormatSubType")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("PIONEER")));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(4));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","<init>","(Ljava/lang/String;I)V","invokespecial",62);}
case 62:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","PIONEER","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$FormatSubType","PIONEER","Lforge/game/GameFormat$FormatSubType;",f.Pop());f.Pc=65;continue;}
case 65:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$FormatSubType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$FormatSubType")));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("MODERN")));f.Pc=71;continue;}
case 71:{f.Push(JValue.I(5));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","<init>","(Ljava/lang/String;I)V","invokespecial",75);}
case 75:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","MODERN","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$FormatSubType","MODERN","Lforge/game/GameFormat$FormatSubType;",f.Pop());f.Pc=78;continue;}
case 78:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$FormatSubType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$FormatSubType")));f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("LEGACY")));f.Pc=84;continue;}
case 84:{f.Push(JValue.I(6));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","<init>","(Ljava/lang/String;I)V","invokespecial",89);}
case 89:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","LEGACY","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$FormatSubType","LEGACY","Lforge/game/GameFormat$FormatSubType;",f.Pop());f.Pc=92;continue;}
case 92:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$FormatSubType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$FormatSubType")));f.Pc=95;continue;}
case 95:{f.StackOp("dup");f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("VINTAGE")));f.Pc=98;continue;}
case 98:{f.Push(JValue.I(7));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","<init>","(Ljava/lang/String;I)V","invokespecial",103);}
case 103:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","VINTAGE","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$FormatSubType","VINTAGE","Lforge/game/GameFormat$FormatSubType;",f.Pop());f.Pc=106;continue;}
case 106:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$FormatSubType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$FormatSubType")));f.Pc=109;continue;}
case 109:{f.StackOp("dup");f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("COMMANDER")));f.Pc=112;continue;}
case 112:{f.Push(JValue.I(8));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","<init>","(Ljava/lang/String;I)V","invokespecial",117);}
case 117:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","COMMANDER","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$FormatSubType","COMMANDER","Lforge/game/GameFormat$FormatSubType;",f.Pop());f.Pc=120;continue;}
case 120:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$FormatSubType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$FormatSubType")));f.Pc=123;continue;}
case 123:{f.StackOp("dup");f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("PLANECHASE")));f.Pc=126;continue;}
case 126:{f.Push(JValue.I(9));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","<init>","(Ljava/lang/String;I)V","invokespecial",131);}
case 131:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","PLANECHASE","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$FormatSubType","PLANECHASE","Lforge/game/GameFormat$FormatSubType;",f.Pop());f.Pc=134;continue;}
case 134:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$FormatSubType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$FormatSubType")));f.Pc=137;continue;}
case 137:{f.StackOp("dup");f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("VIDEOGAME")));f.Pc=140;continue;}
case 140:{f.Push(JValue.I(10));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","<init>","(Ljava/lang/String;I)V","invokespecial",145);}
case 145:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","VIDEOGAME","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$FormatSubType","VIDEOGAME","Lforge/game/GameFormat$FormatSubType;",f.Pop());f.Pc=148;continue;}
case 148:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$FormatSubType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$FormatSubType")));f.Pc=151;continue;}
case 151:{f.StackOp("dup");f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("MTGO")));f.Pc=154;continue;}
case 154:{f.Push(JValue.I(11));f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","<init>","(Ljava/lang/String;I)V","invokespecial",159);}
case 159:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","MTGO","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$FormatSubType","MTGO","Lforge/game/GameFormat$FormatSubType;",f.Pop());f.Pc=162;continue;}
case 162:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$FormatSubType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$FormatSubType")));f.Pc=165;continue;}
case 165:{f.StackOp("dup");f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("ARENA")));f.Pc=168;continue;}
case 168:{f.Push(JValue.I(12));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","<init>","(Ljava/lang/String;I)V","invokespecial",173);}
case 173:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","ARENA","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$FormatSubType","ARENA","Lforge/game/GameFormat$FormatSubType;",f.Pop());f.Pc=176;continue;}
case 176:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$FormatSubType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$FormatSubType")));f.Pc=179;continue;}
case 179:{f.StackOp("dup");f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("CUSTOM")));f.Pc=182;continue;}
case 182:{f.Push(JValue.I(13));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","<init>","(Ljava/lang/String;I)V","invokespecial",187);}
case 187:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","CUSTOM","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$FormatSubType","CUSTOM","Lforge/game/GameFormat$FormatSubType;",f.Pop());f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","$values","()[Lforge/game/GameFormat$FormatSubType;","invokestatic",193);}
case 193:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","$VALUES","[Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$FormatSubType","$VALUES","[Lforge/game/GameFormat$FormatSubType;",f.Pop());f.Pc=196;continue;}
case 196:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
