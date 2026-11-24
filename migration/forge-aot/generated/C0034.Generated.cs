// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C34{
internal static JClass Build(){var c=new JClass("forge/card/CardRarity","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("BasicLand","Lforge/card/CardRarity;",true,JValue.Default("Lforge/card/CardRarity;"),null));
c.Add(new JField("Common","Lforge/card/CardRarity;",true,JValue.Default("Lforge/card/CardRarity;"),null));
c.Add(new JField("Uncommon","Lforge/card/CardRarity;",true,JValue.Default("Lforge/card/CardRarity;"),null));
c.Add(new JField("Rare","Lforge/card/CardRarity;",true,JValue.Default("Lforge/card/CardRarity;"),null));
c.Add(new JField("MythicRare","Lforge/card/CardRarity;",true,JValue.Default("Lforge/card/CardRarity;"),null));
c.Add(new JField("Special","Lforge/card/CardRarity;",true,JValue.Default("Lforge/card/CardRarity;"),null));
c.Add(new JField("Token","Lforge/card/CardRarity;",true,JValue.Default("Lforge/card/CardRarity;"),null));
c.Add(new JField("Unknown","Lforge/card/CardRarity;",true,JValue.Default("Lforge/card/CardRarity;"),null));
c.Add(new JField("FILTER_OPTIONS","[Lforge/card/CardRarity;",true,JValue.Default("[Lforge/card/CardRarity;"),null));
c.Add(new JField("shortName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("longName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("$VALUES","[Lforge/card/CardRarity;",true,JValue.Default("[Lforge/card/CardRarity;"),null));
c.Add(new JMethod(587,"forge/card/CardRarity","values","()[Lforge/card/CardRarity;",9,0,1,new JHandler[]{},M587));
c.Add(new JMethod(588,"forge/card/CardRarity","valueOf","(Ljava/lang/String;)Lforge/card/CardRarity;",9,1,2,new JHandler[]{},M588));
c.Add(new JMethod(589,"forge/card/CardRarity","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V",2,5,3,new JHandler[]{},M589));
c.Add(new JMethod(590,"forge/card/CardRarity","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M590));
c.Add(new JMethod(591,"forge/card/CardRarity","getLongName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M591));
c.Add(new JMethod(592,"forge/card/CardRarity","smartValueOf","(Ljava/lang/String;)Lforge/card/CardRarity;",9,5,2,new JHandler[]{},M592));
c.Add(new JMethod(593,"forge/card/CardRarity","$values","()[Lforge/card/CardRarity;",4106,0,4,new JHandler[]{},M593));
c.Add(new JMethod(594,"forge/card/CardRarity","<clinit>","()V",8,0,6,new JHandler[]{},M594));
}

internal static JStep M587(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardRarity","$VALUES","[Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","$VALUES","[Lforge/card/CardRarity;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/CardRarity;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/CardRarity;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M588(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/CardRarity")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRarity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M589(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRarity","shortName","Ljava/lang/String;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRarity","longName","Ljava/lang/String;",value);f.Pc=17;continue;}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M590(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRarity","shortName","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M591(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRarity","longName","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M592(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/card/CardRarity","values","()[Lforge/card/CardRarity;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?64:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=17;continue;}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/card/CardRarity","name","()Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int!=0?55:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRarity","shortName","Ljava/lang/String;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int!=0?55:43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRarity","longName","Ljava/lang/String;"));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int==0?58:55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{return JStep.Return(f.Pop());}
case 58:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=61;continue;}
case 61:{f.Pc=9;continue;}
case 64:{if(!rt.StaticReady(f,"forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"));f.Pc=67;continue;}
case 67:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M593(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(8));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/card/CardRarity;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/CardRarity","BasicLand","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","BasicLand","Lforge/card/CardRarity;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/CardRarity","Common","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Common","Lforge/card/CardRarity;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/CardRarity","Uncommon","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Uncommon","Lforge/card/CardRarity;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/CardRarity","Rare","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Rare","Lforge/card/CardRarity;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/card/CardRarity","MythicRare","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","MythicRare","Lforge/card/CardRarity;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/CardRarity","Special","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Special","Lforge/card/CardRarity;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/card/CardRarity","Token","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Token","Lforge/card/CardRarity;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M594(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRarity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRarity")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("BasicLand")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("L")));f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Basic Land")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardRarity","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",14);}
case 14:{if(!rt.StaticReady(f,"forge/card/CardRarity","BasicLand","Lforge/card/CardRarity;"))return JStep.Continue;rt.PutStatic("forge/card/CardRarity","BasicLand","Lforge/card/CardRarity;",f.Pop());f.Pc=17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"forge/card/CardRarity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRarity")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("Common")));f.Pc=23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("C")));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("Common")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/card/CardRarity","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",31);}
case 31:{if(!rt.StaticReady(f,"forge/card/CardRarity","Common","Lforge/card/CardRarity;"))return JStep.Continue;rt.PutStatic("forge/card/CardRarity","Common","Lforge/card/CardRarity;",f.Pop());f.Pc=34;continue;}
case 34:{if(!rt.EnsureInitialized(f,"forge/card/CardRarity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRarity")));f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("Uncommon")));f.Pc=40;continue;}
case 40:{f.Push(JValue.I(2));f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("U")));f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("Uncommon")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/card/CardRarity","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",48);}
case 48:{if(!rt.StaticReady(f,"forge/card/CardRarity","Uncommon","Lforge/card/CardRarity;"))return JStep.Continue;rt.PutStatic("forge/card/CardRarity","Uncommon","Lforge/card/CardRarity;",f.Pop());f.Pc=51;continue;}
case 51:{if(!rt.EnsureInitialized(f,"forge/card/CardRarity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRarity")));f.Pc=54;continue;}
case 54:{f.StackOp("dup");f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("Rare")));f.Pc=57;continue;}
case 57:{f.Push(JValue.I(3));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("R")));f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("Rare")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/card/CardRarity","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",65);}
case 65:{if(!rt.StaticReady(f,"forge/card/CardRarity","Rare","Lforge/card/CardRarity;"))return JStep.Continue;rt.PutStatic("forge/card/CardRarity","Rare","Lforge/card/CardRarity;",f.Pop());f.Pc=68;continue;}
case 68:{if(!rt.EnsureInitialized(f,"forge/card/CardRarity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRarity")));f.Pc=71;continue;}
case 71:{f.StackOp("dup");f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("MythicRare")));f.Pc=74;continue;}
case 74:{f.Push(JValue.I(4));f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("M")));f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("Mythic Rare")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/card/CardRarity","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",82);}
case 82:{if(!rt.StaticReady(f,"forge/card/CardRarity","MythicRare","Lforge/card/CardRarity;"))return JStep.Continue;rt.PutStatic("forge/card/CardRarity","MythicRare","Lforge/card/CardRarity;",f.Pop());f.Pc=85;continue;}
case 85:{if(!rt.EnsureInitialized(f,"forge/card/CardRarity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRarity")));f.Pc=88;continue;}
case 88:{f.StackOp("dup");f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("Special")));f.Pc=91;continue;}
case 91:{f.Push(JValue.I(5));f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String("S")));f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("Special")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/card/CardRarity","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",99);}
case 99:{if(!rt.StaticReady(f,"forge/card/CardRarity","Special","Lforge/card/CardRarity;"))return JStep.Continue;rt.PutStatic("forge/card/CardRarity","Special","Lforge/card/CardRarity;",f.Pop());f.Pc=102;continue;}
case 102:{if(!rt.EnsureInitialized(f,"forge/card/CardRarity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRarity")));f.Pc=105;continue;}
case 105:{f.StackOp("dup");f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("Token")));f.Pc=108;continue;}
case 108:{f.Push(JValue.I(6));f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("T")));f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("Token")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/card/CardRarity","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",117);}
case 117:{if(!rt.StaticReady(f,"forge/card/CardRarity","Token","Lforge/card/CardRarity;"))return JStep.Continue;rt.PutStatic("forge/card/CardRarity","Token","Lforge/card/CardRarity;",f.Pop());f.Pc=120;continue;}
case 120:{if(!rt.EnsureInitialized(f,"forge/card/CardRarity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRarity")));f.Pc=123;continue;}
case 123:{f.StackOp("dup");f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("Unknown")));f.Pc=126;continue;}
case 126:{f.Push(JValue.I(7));f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("?")));f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("Unknown")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/card/CardRarity","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",135);}
case 135:{if(!rt.StaticReady(f,"forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"))return JStep.Continue;rt.PutStatic("forge/card/CardRarity","Unknown","Lforge/card/CardRarity;",f.Pop());f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/card/CardRarity","$values","()[Lforge/card/CardRarity;","invokestatic",141);}
case 141:{if(!rt.StaticReady(f,"forge/card/CardRarity","$VALUES","[Lforge/card/CardRarity;"))return JStep.Continue;rt.PutStatic("forge/card/CardRarity","$VALUES","[Lforge/card/CardRarity;",f.Pop());f.Pc=144;continue;}
case 144:{f.Push(JValue.I(5));f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.NewArray("Lforge/card/CardRarity;",f.Pop().Int)));f.Pc=148;continue;}
case 148:{f.StackOp("dup");f.Pc=149;continue;}
case 149:{f.Push(JValue.I(0));f.Pc=150;continue;}
case 150:{if(!rt.StaticReady(f,"forge/card/CardRarity","Common","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Common","Lforge/card/CardRarity;"));f.Pc=153;continue;}
case 153:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=154;continue;}
case 154:{f.StackOp("dup");f.Pc=155;continue;}
case 155:{f.Push(JValue.I(1));f.Pc=156;continue;}
case 156:{if(!rt.StaticReady(f,"forge/card/CardRarity","Uncommon","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Uncommon","Lforge/card/CardRarity;"));f.Pc=159;continue;}
case 159:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=160;continue;}
case 160:{f.StackOp("dup");f.Pc=161;continue;}
case 161:{f.Push(JValue.I(2));f.Pc=162;continue;}
case 162:{if(!rt.StaticReady(f,"forge/card/CardRarity","Rare","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Rare","Lforge/card/CardRarity;"));f.Pc=165;continue;}
case 165:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=166;continue;}
case 166:{f.StackOp("dup");f.Pc=167;continue;}
case 167:{f.Push(JValue.I(3));f.Pc=168;continue;}
case 168:{if(!rt.StaticReady(f,"forge/card/CardRarity","MythicRare","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","MythicRare","Lforge/card/CardRarity;"));f.Pc=171;continue;}
case 171:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=172;continue;}
case 172:{f.StackOp("dup");f.Pc=173;continue;}
case 173:{f.Push(JValue.I(4));f.Pc=174;continue;}
case 174:{if(!rt.StaticReady(f,"forge/card/CardRarity","Special","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Special","Lforge/card/CardRarity;"));f.Pc=177;continue;}
case 177:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=178;continue;}
case 178:{if(!rt.StaticReady(f,"forge/card/CardRarity","FILTER_OPTIONS","[Lforge/card/CardRarity;"))return JStep.Continue;rt.PutStatic("forge/card/CardRarity","FILTER_OPTIONS","[Lforge/card/CardRarity;",f.Pop());f.Pc=181;continue;}
case 181:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
