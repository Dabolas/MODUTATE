// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C796{
internal static JClass Build(){var c=new JClass("forge/game/spellability/OptionalCost","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("Bargain","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("Buyback","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("Entwine","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("Kicker1","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("Kicker2","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("PromiseGift","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("Retrace","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("Jumpstart","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("Offering","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("Teamwork","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("ReduceW","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("ReduceU","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("ReduceB","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("ReduceR","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("ReduceG","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("AltCost","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("Flash","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("Generic","Lforge/game/spellability/OptionalCost;",true,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("pip","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("$VALUES","[Lforge/game/spellability/OptionalCost;",true,JValue.Default("[Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JMethod(9157,"forge/game/spellability/OptionalCost","values","()[Lforge/game/spellability/OptionalCost;",9,0,1,new JHandler[]{},M9157));
c.Add(new JMethod(9158,"forge/game/spellability/OptionalCost","valueOf","(Ljava/lang/String;)Lforge/game/spellability/OptionalCost;",9,1,2,new JHandler[]{},M9158));
c.Add(new JMethod(9159,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V",2,5,3,new JHandler[]{},M9159));
c.Add(new JMethod(9160,"forge/game/spellability/OptionalCost","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9160));
c.Add(new JMethod(9161,"forge/game/spellability/OptionalCost","getPip","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9161));
c.Add(new JMethod(9162,"forge/game/spellability/OptionalCost","$values","()[Lforge/game/spellability/OptionalCost;",4106,0,4,new JHandler[]{},M9162));
c.Add(new JMethod(9163,"forge/game/spellability/OptionalCost","<clinit>","()V",8,0,6,new JHandler[]{},M9163));
}

internal static JStep M9157(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","$VALUES","[Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","$VALUES","[Lforge/game/spellability/OptionalCost;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/spellability/OptionalCost;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/spellability/OptionalCost;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9158(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/spellability/OptionalCost")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/OptionalCost"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9159(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/OptionalCost","name","Ljava/lang/String;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/OptionalCost","pip","Ljava/lang/String;",value);f.Pc=17;continue;}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9160(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/OptionalCost","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9161(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/OptionalCost","pip","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9162(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(18));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/game/spellability/OptionalCost;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Bargain","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Bargain","Lforge/game/spellability/OptionalCost;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Buyback","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Buyback","Lforge/game/spellability/OptionalCost;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Entwine","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Entwine","Lforge/game/spellability/OptionalCost;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Kicker1","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Kicker1","Lforge/game/spellability/OptionalCost;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Kicker2","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Kicker2","Lforge/game/spellability/OptionalCost;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","PromiseGift","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","PromiseGift","Lforge/game/spellability/OptionalCost;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Retrace","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Retrace","Lforge/game/spellability/OptionalCost;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Jumpstart","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Jumpstart","Lforge/game/spellability/OptionalCost;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Offering","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Offering","Lforge/game/spellability/OptionalCost;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Teamwork","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Teamwork","Lforge/game/spellability/OptionalCost;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","ReduceW","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","ReduceW","Lforge/game/spellability/OptionalCost;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(11));f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","ReduceU","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","ReduceU","Lforge/game/spellability/OptionalCost;"));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(12));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","ReduceB","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","ReduceB","Lforge/game/spellability/OptionalCost;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(13));f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","ReduceR","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","ReduceR","Lforge/game/spellability/OptionalCost;"));f.Pc=96;continue;}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(14));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","ReduceG","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","ReduceG","Lforge/game/spellability/OptionalCost;"));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{f.StackOp("dup");f.Pc=105;continue;}
case 105:{f.Push(JValue.I(15));f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","AltCost","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","AltCost","Lforge/game/spellability/OptionalCost;"));f.Pc=110;continue;}
case 110:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{f.Push(JValue.I(16));f.Pc=114;continue;}
case 114:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Flash","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Flash","Lforge/game/spellability/OptionalCost;"));f.Pc=117;continue;}
case 117:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(JValue.I(17));f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Generic","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Generic","Lforge/game/spellability/OptionalCost;"));f.Pc=124;continue;}
case 124:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=125;continue;}
case 125:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9163(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Bargain")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("Bargain")));f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",14);}
case 14:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Bargain","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","Bargain","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("Buyback")));f.Pc=23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Buyback")));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",31);}
case 31:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Buyback","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","Buyback","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=34;continue;}
case 34:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("Entwine")));f.Pc=40;continue;}
case 40:{f.Push(JValue.I(2));f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("Entwine")));f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",48);}
case 48:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Entwine","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","Entwine","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=51;continue;}
case 51:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=54;continue;}
case 54:{f.StackOp("dup");f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("Kicker1")));f.Pc=57;continue;}
case 57:{f.Push(JValue.I(3));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("Kicker")));f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",65);}
case 65:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Kicker1","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","Kicker1","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=68;continue;}
case 68:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=71;continue;}
case 71:{f.StackOp("dup");f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("Kicker2")));f.Pc=74;continue;}
case 74:{f.Push(JValue.I(4));f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("Kicker")));f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",82);}
case 82:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Kicker2","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","Kicker2","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=85;continue;}
case 85:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=88;continue;}
case 88:{f.StackOp("dup");f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("PromiseGift")));f.Pc=91;continue;}
case 91:{f.Push(JValue.I(5));f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String("Promise Gift")));f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",99);}
case 99:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","PromiseGift","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","PromiseGift","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=102;continue;}
case 102:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=105;continue;}
case 105:{f.StackOp("dup");f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("Retrace")));f.Pc=108;continue;}
case 108:{f.Push(JValue.I(6));f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("Retrace")));f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",117);}
case 117:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Retrace","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","Retrace","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=120;continue;}
case 120:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=123;continue;}
case 123:{f.StackOp("dup");f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("Jumpstart")));f.Pc=126;continue;}
case 126:{f.Push(JValue.I(7));f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("Jump-start")));f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",135);}
case 135:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Jumpstart","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","Jumpstart","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=138;continue;}
case 138:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=141;continue;}
case 141:{f.StackOp("dup");f.Pc=142;continue;}
case 142:{f.Push(JValue.R(rt.String("Offering")));f.Pc=144;continue;}
case 144:{f.Push(JValue.I(8));f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.String("Offering")));f.Pc=148;continue;}
case 148:{f.Push(JValue.R(rt.String("")));f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",153);}
case 153:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Offering","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","Offering","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=156;continue;}
case 156:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=159;continue;}
case 159:{f.StackOp("dup");f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("Teamwork")));f.Pc=162;continue;}
case 162:{f.Push(JValue.I(9));f.Pc=164;continue;}
case 164:{f.Push(JValue.R(rt.String("Teamwork")));f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("")));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",171);}
case 171:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Teamwork","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","Teamwork","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=174;continue;}
case 174:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=177;continue;}
case 177:{f.StackOp("dup");f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("ReduceW")));f.Pc=180;continue;}
case 180:{f.Push(JValue.I(10));f.Pc=182;continue;}
case 182:{f.Push(JValue.R(rt.String("(to reduce white mana)")));f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("W")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",189);}
case 189:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","ReduceW","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","ReduceW","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=192;continue;}
case 192:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=195;continue;}
case 195:{f.StackOp("dup");f.Pc=196;continue;}
case 196:{f.Push(JValue.R(rt.String("ReduceU")));f.Pc=198;continue;}
case 198:{f.Push(JValue.I(11));f.Pc=200;continue;}
case 200:{f.Push(JValue.R(rt.String("(to reduce blue mana)")));f.Pc=202;continue;}
case 202:{f.Push(JValue.R(rt.String("U")));f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",207);}
case 207:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","ReduceU","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","ReduceU","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=210;continue;}
case 210:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=213;continue;}
case 213:{f.StackOp("dup");f.Pc=214;continue;}
case 214:{f.Push(JValue.R(rt.String("ReduceB")));f.Pc=216;continue;}
case 216:{f.Push(JValue.I(12));f.Pc=218;continue;}
case 218:{f.Push(JValue.R(rt.String("(to reduce black mana)")));f.Pc=220;continue;}
case 220:{f.Push(JValue.R(rt.String("B")));f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",225);}
case 225:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","ReduceB","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","ReduceB","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=228;continue;}
case 228:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=231;continue;}
case 231:{f.StackOp("dup");f.Pc=232;continue;}
case 232:{f.Push(JValue.R(rt.String("ReduceR")));f.Pc=234;continue;}
case 234:{f.Push(JValue.I(13));f.Pc=236;continue;}
case 236:{f.Push(JValue.R(rt.String("(to reduce red mana)")));f.Pc=238;continue;}
case 238:{f.Push(JValue.R(rt.String("R")));f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",243);}
case 243:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","ReduceR","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","ReduceR","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=246;continue;}
case 246:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=249;continue;}
case 249:{f.StackOp("dup");f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.String("ReduceG")));f.Pc=252;continue;}
case 252:{f.Push(JValue.I(14));f.Pc=254;continue;}
case 254:{f.Push(JValue.R(rt.String("(to reduce green mana)")));f.Pc=256;continue;}
case 256:{f.Push(JValue.R(rt.String("G")));f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",261);}
case 261:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","ReduceG","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","ReduceG","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=264;continue;}
case 264:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=267;continue;}
case 267:{f.StackOp("dup");f.Pc=268;continue;}
case 268:{f.Push(JValue.R(rt.String("AltCost")));f.Pc=270;continue;}
case 270:{f.Push(JValue.I(15));f.Pc=272;continue;}
case 272:{f.Push(JValue.R(rt.String("")));f.Pc=274;continue;}
case 274:{f.Push(JValue.R(rt.String("")));f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",279);}
case 279:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","AltCost","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","AltCost","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=282;continue;}
case 282:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=285;continue;}
case 285:{f.StackOp("dup");f.Pc=286;continue;}
case 286:{f.Push(JValue.R(rt.String("Flash")));f.Pc=288;continue;}
case 288:{f.Push(JValue.I(16));f.Pc=290;continue;}
case 290:{f.Push(JValue.R(rt.String("Flash")));f.Pc=292;continue;}
case 292:{f.Push(JValue.R(rt.String("")));f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",297);}
case 297:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Flash","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","Flash","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=300;continue;}
case 300:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCost")));f.Pc=303;continue;}
case 303:{f.StackOp("dup");f.Pc=304;continue;}
case 304:{f.Push(JValue.R(rt.String("Generic")));f.Pc=306;continue;}
case 306:{f.Push(JValue.I(17));f.Pc=308;continue;}
case 308:{f.Push(JValue.R(rt.String("Generic")));f.Pc=310;continue;}
case 310:{f.Push(JValue.R(rt.String("")));f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/spellability/OptionalCost","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",315);}
case 315:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Generic","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","Generic","Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/spellability/OptionalCost","$values","()[Lforge/game/spellability/OptionalCost;","invokestatic",321);}
case 321:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","$VALUES","[Lforge/game/spellability/OptionalCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/OptionalCost","$VALUES","[Lforge/game/spellability/OptionalCost;",f.Pop());f.Pc=324;continue;}
case 324:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
