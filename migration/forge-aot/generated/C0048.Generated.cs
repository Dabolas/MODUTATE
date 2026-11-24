// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C48{
internal static JClass Build(){var c=new JClass("forge/card/CardStateName","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("Original","Lforge/card/CardStateName;",true,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("FaceDown","Lforge/card/CardStateName;",true,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("Flipped","Lforge/card/CardStateName;",true,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("Backside","Lforge/card/CardStateName;",true,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("Meld","Lforge/card/CardStateName;",true,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("LeftSplit","Lforge/card/CardStateName;",true,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("RightSplit","Lforge/card/CardStateName;",true,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("Secondary","Lforge/card/CardStateName;",true,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("PreparedSpell","Lforge/card/CardStateName;",true,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("EmptyRoom","Lforge/card/CardStateName;",true,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("SpecializeW","Lforge/card/CardStateName;",true,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("SpecializeU","Lforge/card/CardStateName;",true,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("SpecializeB","Lforge/card/CardStateName;",true,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("SpecializeR","Lforge/card/CardStateName;",true,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("SpecializeG","Lforge/card/CardStateName;",true,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("$VALUES","[Lforge/card/CardStateName;",true,JValue.Default("[Lforge/card/CardStateName;"),null));
c.Add(new JMethod(781,"forge/card/CardStateName","values","()[Lforge/card/CardStateName;",9,0,1,new JHandler[]{},M781));
c.Add(new JMethod(782,"forge/card/CardStateName","valueOf","(Ljava/lang/String;)Lforge/card/CardStateName;",9,1,2,new JHandler[]{},M782));
c.Add(new JMethod(783,"forge/card/CardStateName","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M783));
c.Add(new JMethod(784,"forge/card/CardStateName","smartValueOf","(Ljava/lang/String;)Lforge/card/CardStateName;",9,6,3,new JHandler[]{},M784));
c.Add(new JMethod(785,"forge/card/CardStateName","$values","()[Lforge/card/CardStateName;",4106,0,4,new JHandler[]{},M785));
c.Add(new JMethod(786,"forge/card/CardStateName","<clinit>","()V",8,0,4,new JHandler[]{},M786));
}

internal static JStep M781(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardStateName","$VALUES","[Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","$VALUES","[Lforge/card/CardStateName;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/CardStateName;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/CardStateName;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M782(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/CardStateName")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardStateName"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M783(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M784(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(JValue.R(rt.String("All")));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?17:15;continue;}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Locals[1]=f.Pop();f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/card/CardStateName","values","()[Lforge/card/CardStateName;","invokestatic",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?65:38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=42;continue;}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/card/CardStateName","name","()Ljava/lang/String;","invokevirtual",49);}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/String","compareToIgnoreCase","(Ljava/lang/String;)I","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int!=0?59:56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{return JStep.Return(f.Pop());}
case 59:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=62;continue;}
case 62:{f.Pc=32;continue;}
case 65:{f.Push(JValue.R(rt.String("Flip")));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int==0?78:74;continue;}
case 74:{if(!rt.StaticReady(f,"forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"));f.Pc=77;continue;}
case 77:{return JStep.Return(f.Pop());}
case 78:{f.Push(JValue.R(rt.String("DoubleFaced")));f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int==0?91:87;continue;}
case 87:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=90;continue;}
case 90:{return JStep.Return(f.Pop());}
case 91:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=94;continue;}
case 94:{f.StackOp("dup");f.Pc=95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{return rt.DynamicCall(f,"forge/card/CardStateName:784:96:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",101);}
case 101:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",104);}
case 104:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M785(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(15));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/card/CardStateName;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/card/CardStateName","Meld","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Meld","Lforge/card/CardStateName;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/card/CardStateName","EmptyRoom","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","EmptyRoom","Lforge/card/CardStateName;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeW","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeW","Lforge/card/CardStateName;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(11));f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeU","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeU","Lforge/card/CardStateName;"));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(12));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeB","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeB","Lforge/card/CardStateName;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(13));f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeR","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeR","Lforge/card/CardStateName;"));f.Pc=96;continue;}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(14));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeG","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeG","Lforge/card/CardStateName;"));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M786(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardStateName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardStateName")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Original")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardStateName","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;rt.PutStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/card/CardStateName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardStateName")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("FaceDown")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardStateName","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"))return JStep.Continue;rt.PutStatic("forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/card/CardStateName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardStateName")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("Flipped")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/CardStateName","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"))return JStep.Continue;rt.PutStatic("forge/card/CardStateName","Flipped","Lforge/card/CardStateName;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/card/CardStateName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardStateName")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("Backside")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/card/CardStateName","<init>","(Ljava/lang/String;I)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;rt.PutStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;",f.Pop());f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/card/CardStateName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardStateName")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("Meld")));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(4));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/card/CardStateName","<init>","(Ljava/lang/String;I)V","invokespecial",62);}
case 62:{if(!rt.StaticReady(f,"forge/card/CardStateName","Meld","Lforge/card/CardStateName;"))return JStep.Continue;rt.PutStatic("forge/card/CardStateName","Meld","Lforge/card/CardStateName;",f.Pop());f.Pc=65;continue;}
case 65:{if(!rt.EnsureInitialized(f,"forge/card/CardStateName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardStateName")));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("LeftSplit")));f.Pc=71;continue;}
case 71:{f.Push(JValue.I(5));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/card/CardStateName","<init>","(Ljava/lang/String;I)V","invokespecial",75);}
case 75:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;rt.PutStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;",f.Pop());f.Pc=78;continue;}
case 78:{if(!rt.EnsureInitialized(f,"forge/card/CardStateName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardStateName")));f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("RightSplit")));f.Pc=84;continue;}
case 84:{f.Push(JValue.I(6));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/card/CardStateName","<init>","(Ljava/lang/String;I)V","invokespecial",89);}
case 89:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;rt.PutStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;",f.Pop());f.Pc=92;continue;}
case 92:{if(!rt.EnsureInitialized(f,"forge/card/CardStateName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardStateName")));f.Pc=95;continue;}
case 95:{f.StackOp("dup");f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("Secondary")));f.Pc=98;continue;}
case 98:{f.Push(JValue.I(7));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/card/CardStateName","<init>","(Ljava/lang/String;I)V","invokespecial",103);}
case 103:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;rt.PutStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;",f.Pop());f.Pc=106;continue;}
case 106:{if(!rt.EnsureInitialized(f,"forge/card/CardStateName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardStateName")));f.Pc=109;continue;}
case 109:{f.StackOp("dup");f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("PreparedSpell")));f.Pc=112;continue;}
case 112:{f.Push(JValue.I(8));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/card/CardStateName","<init>","(Ljava/lang/String;I)V","invokespecial",117);}
case 117:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;rt.PutStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;",f.Pop());f.Pc=120;continue;}
case 120:{if(!rt.EnsureInitialized(f,"forge/card/CardStateName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardStateName")));f.Pc=123;continue;}
case 123:{f.StackOp("dup");f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("EmptyRoom")));f.Pc=126;continue;}
case 126:{f.Push(JValue.I(9));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/card/CardStateName","<init>","(Ljava/lang/String;I)V","invokespecial",131);}
case 131:{if(!rt.StaticReady(f,"forge/card/CardStateName","EmptyRoom","Lforge/card/CardStateName;"))return JStep.Continue;rt.PutStatic("forge/card/CardStateName","EmptyRoom","Lforge/card/CardStateName;",f.Pop());f.Pc=134;continue;}
case 134:{if(!rt.EnsureInitialized(f,"forge/card/CardStateName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardStateName")));f.Pc=137;continue;}
case 137:{f.StackOp("dup");f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("SpecializeW")));f.Pc=140;continue;}
case 140:{f.Push(JValue.I(10));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/card/CardStateName","<init>","(Ljava/lang/String;I)V","invokespecial",145);}
case 145:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeW","Lforge/card/CardStateName;"))return JStep.Continue;rt.PutStatic("forge/card/CardStateName","SpecializeW","Lforge/card/CardStateName;",f.Pop());f.Pc=148;continue;}
case 148:{if(!rt.EnsureInitialized(f,"forge/card/CardStateName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardStateName")));f.Pc=151;continue;}
case 151:{f.StackOp("dup");f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("SpecializeU")));f.Pc=154;continue;}
case 154:{f.Push(JValue.I(11));f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/card/CardStateName","<init>","(Ljava/lang/String;I)V","invokespecial",159);}
case 159:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeU","Lforge/card/CardStateName;"))return JStep.Continue;rt.PutStatic("forge/card/CardStateName","SpecializeU","Lforge/card/CardStateName;",f.Pop());f.Pc=162;continue;}
case 162:{if(!rt.EnsureInitialized(f,"forge/card/CardStateName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardStateName")));f.Pc=165;continue;}
case 165:{f.StackOp("dup");f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("SpecializeB")));f.Pc=168;continue;}
case 168:{f.Push(JValue.I(12));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/card/CardStateName","<init>","(Ljava/lang/String;I)V","invokespecial",173);}
case 173:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeB","Lforge/card/CardStateName;"))return JStep.Continue;rt.PutStatic("forge/card/CardStateName","SpecializeB","Lforge/card/CardStateName;",f.Pop());f.Pc=176;continue;}
case 176:{if(!rt.EnsureInitialized(f,"forge/card/CardStateName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardStateName")));f.Pc=179;continue;}
case 179:{f.StackOp("dup");f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("SpecializeR")));f.Pc=182;continue;}
case 182:{f.Push(JValue.I(13));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/card/CardStateName","<init>","(Ljava/lang/String;I)V","invokespecial",187);}
case 187:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeR","Lforge/card/CardStateName;"))return JStep.Continue;rt.PutStatic("forge/card/CardStateName","SpecializeR","Lforge/card/CardStateName;",f.Pop());f.Pc=190;continue;}
case 190:{if(!rt.EnsureInitialized(f,"forge/card/CardStateName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardStateName")));f.Pc=193;continue;}
case 193:{f.StackOp("dup");f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("SpecializeG")));f.Pc=196;continue;}
case 196:{f.Push(JValue.I(14));f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/card/CardStateName","<init>","(Ljava/lang/String;I)V","invokespecial",201);}
case 201:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeG","Lforge/card/CardStateName;"))return JStep.Continue;rt.PutStatic("forge/card/CardStateName","SpecializeG","Lforge/card/CardStateName;",f.Pop());f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/card/CardStateName","$values","()[Lforge/card/CardStateName;","invokestatic",207);}
case 207:{if(!rt.StaticReady(f,"forge/card/CardStateName","$VALUES","[Lforge/card/CardStateName;"))return JStep.Continue;rt.PutStatic("forge/card/CardStateName","$VALUES","[Lforge/card/CardStateName;",f.Pop());f.Pc=210;continue;}
case 210:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
