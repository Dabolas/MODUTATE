// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C24{
internal static JClass Build(){var c=new JClass("forge/card/CardEdition$EditionSectionWithCollectorNumbers","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("CARDS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("SPECIAL_SLOT","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("PRECON_PRODUCT","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("BORDERLESS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("ETCHED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("SHOWCASE","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("FULL_ART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("EXTENDED_ART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("ALTERNATE_ART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("RETRO_FRAME","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("BUY_A_BOX","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("PROMO","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("PRERELEASE_PROMO","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("BUNDLE","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("BOX_TOPPER","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("JUMPSTART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("REBALANCED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("ETERNAL","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("CONJURED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("SCHEME","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("PRINTSHEETS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("$VALUES","[Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",true,JValue.Default("[Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"),null));
c.Add(new JMethod(474,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","values","()[Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",9,0,1,new JHandler[]{},M474));
c.Add(new JMethod(475,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","valueOf","(Ljava/lang/String;)Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",9,1,2,new JHandler[]{},M475));
c.Add(new JMethod(476,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V",2,4,3,new JHandler[]{},M476));
c.Add(new JMethod(477,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M477));
c.Add(new JMethod(478,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","getNames","()Ljava/util/List;",9,6,2,new JHandler[]{},M478));
c.Add(new JMethod(479,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","$values","()[Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",4106,0,4,new JHandler[]{},M479));
c.Add(new JMethod(480,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<clinit>","()V",8,0,5,new JHandler[]{},M480));
}

internal static JStep M474(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","$VALUES","[Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","$VALUES","[Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M475(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M476(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition$EditionSectionWithCollectorNumbers","name","Ljava/lang/String;",value);f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M477(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionSectionWithCollectorNumbers","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M478(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[0]=f.Pop();f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","values","()[Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;","invokestatic",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=14;continue;}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?49:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=25;continue;}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","getName","()Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Locals[5]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=46;continue;}
case 46:{f.Pc=17;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M479(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(21));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","CARDS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","CARDS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","SPECIAL_SLOT","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","SPECIAL_SLOT","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","PRECON_PRODUCT","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","PRECON_PRODUCT","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","BORDERLESS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","BORDERLESS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","ETCHED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","ETCHED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","SHOWCASE","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","SHOWCASE","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","FULL_ART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","FULL_ART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","EXTENDED_ART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","EXTENDED_ART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","ALTERNATE_ART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","ALTERNATE_ART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","RETRO_FRAME","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","RETRO_FRAME","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","BUY_A_BOX","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","BUY_A_BOX","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(11));f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","PROMO","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","PROMO","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(12));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","PRERELEASE_PROMO","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","PRERELEASE_PROMO","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(13));f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","BUNDLE","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","BUNDLE","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=96;continue;}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(14));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","BOX_TOPPER","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","BOX_TOPPER","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{f.StackOp("dup");f.Pc=105;continue;}
case 105:{f.Push(JValue.I(15));f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","JUMPSTART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","JUMPSTART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=110;continue;}
case 110:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{f.Push(JValue.I(16));f.Pc=114;continue;}
case 114:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","REBALANCED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","REBALANCED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=117;continue;}
case 117:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(JValue.I(17));f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","ETERNAL","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","ETERNAL","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=124;continue;}
case 124:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{f.Push(JValue.I(18));f.Pc=128;continue;}
case 128:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","CONJURED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","CONJURED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=131;continue;}
case 131:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=132;continue;}
case 132:{f.StackOp("dup");f.Pc=133;continue;}
case 133:{f.Push(JValue.I(19));f.Pc=135;continue;}
case 135:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","SCHEME","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","SCHEME","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=138;continue;}
case 138:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=139;continue;}
case 139:{f.StackOp("dup");f.Pc=140;continue;}
case 140:{f.Push(JValue.I(20));f.Pc=142;continue;}
case 142:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","PRINTSHEETS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","PRINTSHEETS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=145;continue;}
case 145:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=146;continue;}
case 146:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M480(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("CARDS")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("cards")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",12);}
case 12:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","CARDS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","CARDS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("SPECIAL_SLOT")));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("special slot")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",27);}
case 27:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","SPECIAL_SLOT","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","SPECIAL_SLOT","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("PRECON_PRODUCT")));f.Pc=36;continue;}
case 36:{f.Push(JValue.I(2));f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("precon product")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",42);}
case 42:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","PRECON_PRODUCT","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","PRECON_PRODUCT","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=45;continue;}
case 45:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("BORDERLESS")));f.Pc=51;continue;}
case 51:{f.Push(JValue.I(3));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("borderless")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",57);}
case 57:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","BORDERLESS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","BORDERLESS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=60;continue;}
case 60:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("ETCHED")));f.Pc=66;continue;}
case 66:{f.Push(JValue.I(4));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("etched")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",72);}
case 72:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","ETCHED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","ETCHED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=75;continue;}
case 75:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=78;continue;}
case 78:{f.StackOp("dup");f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("SHOWCASE")));f.Pc=81;continue;}
case 81:{f.Push(JValue.I(5));f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("showcase")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",87);}
case 87:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","SHOWCASE","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","SHOWCASE","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=90;continue;}
case 90:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=93;continue;}
case 93:{f.StackOp("dup");f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("FULL_ART")));f.Pc=96;continue;}
case 96:{f.Push(JValue.I(6));f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("full art")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",103);}
case 103:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","FULL_ART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","FULL_ART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=106;continue;}
case 106:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=109;continue;}
case 109:{f.StackOp("dup");f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("EXTENDED_ART")));f.Pc=112;continue;}
case 112:{f.Push(JValue.I(7));f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("extended art")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",119);}
case 119:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","EXTENDED_ART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","EXTENDED_ART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=122;continue;}
case 122:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("ALTERNATE_ART")));f.Pc=128;continue;}
case 128:{f.Push(JValue.I(8));f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("alternate art")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",135);}
case 135:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","ALTERNATE_ART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","ALTERNATE_ART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=138;continue;}
case 138:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=141;continue;}
case 141:{f.StackOp("dup");f.Pc=142;continue;}
case 142:{f.Push(JValue.R(rt.String("RETRO_FRAME")));f.Pc=144;continue;}
case 144:{f.Push(JValue.I(9));f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.String("retro frame")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",151);}
case 151:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","RETRO_FRAME","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","RETRO_FRAME","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=154;continue;}
case 154:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=157;continue;}
case 157:{f.StackOp("dup");f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("BUY_A_BOX")));f.Pc=160;continue;}
case 160:{f.Push(JValue.I(10));f.Pc=162;continue;}
case 162:{f.Push(JValue.R(rt.String("buy a box")));f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",167);}
case 167:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","BUY_A_BOX","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","BUY_A_BOX","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=170;continue;}
case 170:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=173;continue;}
case 173:{f.StackOp("dup");f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("PROMO")));f.Pc=176;continue;}
case 176:{f.Push(JValue.I(11));f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("promo")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",183);}
case 183:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","PROMO","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","PROMO","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=186;continue;}
case 186:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=189;continue;}
case 189:{f.StackOp("dup");f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.String("PRERELEASE_PROMO")));f.Pc=192;continue;}
case 192:{f.Push(JValue.I(12));f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("prerelease promo")));f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",199);}
case 199:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","PRERELEASE_PROMO","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","PRERELEASE_PROMO","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=202;continue;}
case 202:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=205;continue;}
case 205:{f.StackOp("dup");f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.String("BUNDLE")));f.Pc=208;continue;}
case 208:{f.Push(JValue.I(13));f.Pc=210;continue;}
case 210:{f.Push(JValue.R(rt.String("bundle")));f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",215);}
case 215:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","BUNDLE","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","BUNDLE","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=218;continue;}
case 218:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=221;continue;}
case 221:{f.StackOp("dup");f.Pc=222;continue;}
case 222:{f.Push(JValue.R(rt.String("BOX_TOPPER")));f.Pc=224;continue;}
case 224:{f.Push(JValue.I(14));f.Pc=226;continue;}
case 226:{f.Push(JValue.R(rt.String("box topper")));f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",231);}
case 231:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","BOX_TOPPER","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","BOX_TOPPER","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=234;continue;}
case 234:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=237;continue;}
case 237:{f.StackOp("dup");f.Pc=238;continue;}
case 238:{f.Push(JValue.R(rt.String("JUMPSTART")));f.Pc=240;continue;}
case 240:{f.Push(JValue.I(15));f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.String("jumpstart")));f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",247);}
case 247:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","JUMPSTART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","JUMPSTART","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=250;continue;}
case 250:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=253;continue;}
case 253:{f.StackOp("dup");f.Pc=254;continue;}
case 254:{f.Push(JValue.R(rt.String("REBALANCED")));f.Pc=256;continue;}
case 256:{f.Push(JValue.I(16));f.Pc=258;continue;}
case 258:{f.Push(JValue.R(rt.String("rebalanced")));f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",263);}
case 263:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","REBALANCED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","REBALANCED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=266;continue;}
case 266:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=269;continue;}
case 269:{f.StackOp("dup");f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("ETERNAL")));f.Pc=272;continue;}
case 272:{f.Push(JValue.I(17));f.Pc=274;continue;}
case 274:{f.Push(JValue.R(rt.String("eternal")));f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",279);}
case 279:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","ETERNAL","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","ETERNAL","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=282;continue;}
case 282:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=285;continue;}
case 285:{f.StackOp("dup");f.Pc=286;continue;}
case 286:{f.Push(JValue.R(rt.String("CONJURED")));f.Pc=288;continue;}
case 288:{f.Push(JValue.I(18));f.Pc=290;continue;}
case 290:{f.Push(JValue.R(rt.String("conjured")));f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",295);}
case 295:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","CONJURED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","CONJURED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=298;continue;}
case 298:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=301;continue;}
case 301:{f.StackOp("dup");f.Pc=302;continue;}
case 302:{f.Push(JValue.R(rt.String("SCHEME")));f.Pc=304;continue;}
case 304:{f.Push(JValue.I(19));f.Pc=306;continue;}
case 306:{f.Push(JValue.R(rt.String("scheme")));f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",311);}
case 311:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","SCHEME","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","SCHEME","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=314;continue;}
case 314:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionSectionWithCollectorNumbers")));f.Pc=317;continue;}
case 317:{f.StackOp("dup");f.Pc=318;continue;}
case 318:{f.Push(JValue.R(rt.String("PRINTSHEETS")));f.Pc=320;continue;}
case 320:{f.Push(JValue.I(20));f.Pc=322;continue;}
case 322:{f.Push(JValue.R(rt.String("printsheets")));f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",327);}
case 327:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","PRINTSHEETS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","PRINTSHEETS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","$values","()[Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;","invokestatic",333);}
case 333:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","$VALUES","[Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","$VALUES","[Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;",f.Pop());f.Pc=336;continue;}
case 336:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
