// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C46{
internal static JClass Build(){var c=new JClass("forge/card/CardSplitType","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("None","Lforge/card/CardSplitType;",true,JValue.Default("Lforge/card/CardSplitType;"),null));
c.Add(new JField("Transform","Lforge/card/CardSplitType;",true,JValue.Default("Lforge/card/CardSplitType;"),null));
c.Add(new JField("Meld","Lforge/card/CardSplitType;",true,JValue.Default("Lforge/card/CardSplitType;"),null));
c.Add(new JField("Split","Lforge/card/CardSplitType;",true,JValue.Default("Lforge/card/CardSplitType;"),null));
c.Add(new JField("Flip","Lforge/card/CardSplitType;",true,JValue.Default("Lforge/card/CardSplitType;"),null));
c.Add(new JField("Adventure","Lforge/card/CardSplitType;",true,JValue.Default("Lforge/card/CardSplitType;"),null));
c.Add(new JField("Omen","Lforge/card/CardSplitType;",true,JValue.Default("Lforge/card/CardSplitType;"),null));
c.Add(new JField("Vengeance","Lforge/card/CardSplitType;",true,JValue.Default("Lforge/card/CardSplitType;"),null));
c.Add(new JField("Modal","Lforge/card/CardSplitType;",true,JValue.Default("Lforge/card/CardSplitType;"),null));
c.Add(new JField("Prepare","Lforge/card/CardSplitType;",true,JValue.Default("Lforge/card/CardSplitType;"),null));
c.Add(new JField("Specialize","Lforge/card/CardSplitType;",true,JValue.Default("Lforge/card/CardSplitType;"),null));
c.Add(new JField("DUAL_FACED_CARDS","Ljava/util/EnumSet;",true,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JField("method","Lforge/card/CardSplitType$FaceSelectionMethod;",false,JValue.Default("Lforge/card/CardSplitType$FaceSelectionMethod;"),null));
c.Add(new JField("changedStateName","Lforge/card/CardStateName;",false,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("$VALUES","[Lforge/card/CardSplitType;",true,JValue.Default("[Lforge/card/CardSplitType;"),null));
c.Add(new JMethod(768,"forge/card/CardSplitType","values","()[Lforge/card/CardSplitType;",9,0,1,new JHandler[]{},M768));
c.Add(new JMethod(769,"forge/card/CardSplitType","valueOf","(Ljava/lang/String;)Lforge/card/CardSplitType;",9,1,2,new JHandler[]{},M769));
c.Add(new JMethod(770,"forge/card/CardSplitType","<init>","(Ljava/lang/String;ILforge/card/CardSplitType$FaceSelectionMethod;Lforge/card/CardStateName;)V",2,5,3,new JHandler[]{},M770));
c.Add(new JMethod(771,"forge/card/CardSplitType","getAggregationMethod","()Lforge/card/CardSplitType$FaceSelectionMethod;",1,1,1,new JHandler[]{},M771));
c.Add(new JMethod(772,"forge/card/CardSplitType","smartValueOf","(Ljava/lang/String;)Lforge/card/CardSplitType;",9,2,2,new JHandler[]{},M772));
c.Add(new JMethod(773,"forge/card/CardSplitType","getChangedStateName","()Lforge/card/CardStateName;",1,1,1,new JHandler[]{},M773));
c.Add(new JMethod(774,"forge/card/CardSplitType","$values","()[Lforge/card/CardSplitType;",4106,0,4,new JHandler[]{},M774));
c.Add(new JMethod(775,"forge/card/CardSplitType","<clinit>","()V",8,0,6,new JHandler[]{},M775));
}

internal static JStep M768(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardSplitType","$VALUES","[Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","$VALUES","[Lforge/card/CardSplitType;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/CardSplitType;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/CardSplitType;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M769(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/CardSplitType")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardSplitType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M770(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardSplitType","method","Lforge/card/CardSplitType$FaceSelectionMethod;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardSplitType","changedStateName","Lforge/card/CardStateName;",value);f.Pc=17;continue;}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M771(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardSplitType","method","Lforge/card/CardSplitType$FaceSelectionMethod;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M772(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("DoubleFaced")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?13:9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Transform","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Transform","Lforge/card/CardSplitType;"));f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardSplitType","valueOf","(Ljava/lang/String;)Lforge/card/CardSplitType;","invokestatic",17);}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M773(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardSplitType","changedStateName","Lforge/card/CardStateName;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M774(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(11));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/card/CardSplitType;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/CardSplitType","None","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","None","Lforge/card/CardSplitType;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Transform","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Transform","Lforge/card/CardSplitType;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Meld","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Meld","Lforge/card/CardSplitType;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Split","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Split","Lforge/card/CardSplitType;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Flip","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Flip","Lforge/card/CardSplitType;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Adventure","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Adventure","Lforge/card/CardSplitType;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Omen","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Omen","Lforge/card/CardSplitType;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Vengeance","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Vengeance","Lforge/card/CardSplitType;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Modal","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Modal","Lforge/card/CardSplitType;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Prepare","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Prepare","Lforge/card/CardSplitType;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Specialize","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Specialize","Lforge/card/CardSplitType;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M775(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardSplitType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardSplitType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("None")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/CardSplitType$FaceSelectionMethod","USE_PRIMARY_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType$FaceSelectionMethod","USE_PRIMARY_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"));f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardSplitType","<init>","(Ljava/lang/String;ILforge/card/CardSplitType$FaceSelectionMethod;Lforge/card/CardStateName;)V","invokespecial",14);}
case 14:{if(!rt.StaticReady(f,"forge/card/CardSplitType","None","Lforge/card/CardSplitType;"))return JStep.Continue;rt.PutStatic("forge/card/CardSplitType","None","Lforge/card/CardSplitType;",f.Pop());f.Pc=17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"forge/card/CardSplitType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardSplitType")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("Transform")));f.Pc=23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/card/CardSplitType$FaceSelectionMethod","USE_ACTIVE_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType$FaceSelectionMethod","USE_ACTIVE_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"));f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardSplitType","<init>","(Ljava/lang/String;ILforge/card/CardSplitType$FaceSelectionMethod;Lforge/card/CardStateName;)V","invokespecial",33);}
case 33:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Transform","Lforge/card/CardSplitType;"))return JStep.Continue;rt.PutStatic("forge/card/CardSplitType","Transform","Lforge/card/CardSplitType;",f.Pop());f.Pc=36;continue;}
case 36:{if(!rt.EnsureInitialized(f,"forge/card/CardSplitType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardSplitType")));f.Pc=39;continue;}
case 39:{f.StackOp("dup");f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("Meld")));f.Pc=42;continue;}
case 42:{f.Push(JValue.I(2));f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/card/CardSplitType$FaceSelectionMethod","USE_ACTIVE_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType$FaceSelectionMethod","USE_ACTIVE_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"));f.Pc=46;continue;}
case 46:{if(!rt.StaticReady(f,"forge/card/CardStateName","Meld","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Meld","Lforge/card/CardStateName;"));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/card/CardSplitType","<init>","(Ljava/lang/String;ILforge/card/CardSplitType$FaceSelectionMethod;Lforge/card/CardStateName;)V","invokespecial",52);}
case 52:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Meld","Lforge/card/CardSplitType;"))return JStep.Continue;rt.PutStatic("forge/card/CardSplitType","Meld","Lforge/card/CardSplitType;",f.Pop());f.Pc=55;continue;}
case 55:{if(!rt.EnsureInitialized(f,"forge/card/CardSplitType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardSplitType")));f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("Split")));f.Pc=61;continue;}
case 61:{f.Push(JValue.I(3));f.Pc=62;continue;}
case 62:{if(!rt.StaticReady(f,"forge/card/CardSplitType$FaceSelectionMethod","COMBINE","Lforge/card/CardSplitType$FaceSelectionMethod;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType$FaceSelectionMethod","COMBINE","Lforge/card/CardSplitType$FaceSelectionMethod;"));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/card/CardSplitType","<init>","(Ljava/lang/String;ILforge/card/CardSplitType$FaceSelectionMethod;Lforge/card/CardStateName;)V","invokespecial",71);}
case 71:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Split","Lforge/card/CardSplitType;"))return JStep.Continue;rt.PutStatic("forge/card/CardSplitType","Split","Lforge/card/CardSplitType;",f.Pop());f.Pc=74;continue;}
case 74:{if(!rt.EnsureInitialized(f,"forge/card/CardSplitType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardSplitType")));f.Pc=77;continue;}
case 77:{f.StackOp("dup");f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("Flip")));f.Pc=80;continue;}
case 80:{f.Push(JValue.I(4));f.Pc=81;continue;}
case 81:{if(!rt.StaticReady(f,"forge/card/CardSplitType$FaceSelectionMethod","USE_PRIMARY_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType$FaceSelectionMethod","USE_PRIMARY_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"));f.Pc=84;continue;}
case 84:{if(!rt.StaticReady(f,"forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/card/CardSplitType","<init>","(Ljava/lang/String;ILforge/card/CardSplitType$FaceSelectionMethod;Lforge/card/CardStateName;)V","invokespecial",90);}
case 90:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Flip","Lforge/card/CardSplitType;"))return JStep.Continue;rt.PutStatic("forge/card/CardSplitType","Flip","Lforge/card/CardSplitType;",f.Pop());f.Pc=93;continue;}
case 93:{if(!rt.EnsureInitialized(f,"forge/card/CardSplitType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardSplitType")));f.Pc=96;continue;}
case 96:{f.StackOp("dup");f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.String("Adventure")));f.Pc=99;continue;}
case 99:{f.Push(JValue.I(5));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/card/CardSplitType$FaceSelectionMethod","USE_PRIMARY_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType$FaceSelectionMethod","USE_PRIMARY_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"));f.Pc=103;continue;}
case 103:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/card/CardSplitType","<init>","(Ljava/lang/String;ILforge/card/CardSplitType$FaceSelectionMethod;Lforge/card/CardStateName;)V","invokespecial",109);}
case 109:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Adventure","Lforge/card/CardSplitType;"))return JStep.Continue;rt.PutStatic("forge/card/CardSplitType","Adventure","Lforge/card/CardSplitType;",f.Pop());f.Pc=112;continue;}
case 112:{if(!rt.EnsureInitialized(f,"forge/card/CardSplitType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardSplitType")));f.Pc=115;continue;}
case 115:{f.StackOp("dup");f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("Omen")));f.Pc=118;continue;}
case 118:{f.Push(JValue.I(6));f.Pc=120;continue;}
case 120:{if(!rt.StaticReady(f,"forge/card/CardSplitType$FaceSelectionMethod","USE_PRIMARY_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType$FaceSelectionMethod","USE_PRIMARY_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"));f.Pc=123;continue;}
case 123:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/card/CardSplitType","<init>","(Ljava/lang/String;ILforge/card/CardSplitType$FaceSelectionMethod;Lforge/card/CardStateName;)V","invokespecial",129);}
case 129:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Omen","Lforge/card/CardSplitType;"))return JStep.Continue;rt.PutStatic("forge/card/CardSplitType","Omen","Lforge/card/CardSplitType;",f.Pop());f.Pc=132;continue;}
case 132:{if(!rt.EnsureInitialized(f,"forge/card/CardSplitType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardSplitType")));f.Pc=135;continue;}
case 135:{f.StackOp("dup");f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.String("Vengeance")));f.Pc=138;continue;}
case 138:{f.Push(JValue.I(7));f.Pc=140;continue;}
case 140:{if(!rt.StaticReady(f,"forge/card/CardSplitType$FaceSelectionMethod","USE_PRIMARY_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType$FaceSelectionMethod","USE_PRIMARY_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"));f.Pc=143;continue;}
case 143:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/card/CardSplitType","<init>","(Ljava/lang/String;ILforge/card/CardSplitType$FaceSelectionMethod;Lforge/card/CardStateName;)V","invokespecial",149);}
case 149:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Vengeance","Lforge/card/CardSplitType;"))return JStep.Continue;rt.PutStatic("forge/card/CardSplitType","Vengeance","Lforge/card/CardSplitType;",f.Pop());f.Pc=152;continue;}
case 152:{if(!rt.EnsureInitialized(f,"forge/card/CardSplitType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardSplitType")));f.Pc=155;continue;}
case 155:{f.StackOp("dup");f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String("Modal")));f.Pc=158;continue;}
case 158:{f.Push(JValue.I(8));f.Pc=160;continue;}
case 160:{if(!rt.StaticReady(f,"forge/card/CardSplitType$FaceSelectionMethod","USE_ACTIVE_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType$FaceSelectionMethod","USE_ACTIVE_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"));f.Pc=163;continue;}
case 163:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/card/CardSplitType","<init>","(Ljava/lang/String;ILforge/card/CardSplitType$FaceSelectionMethod;Lforge/card/CardStateName;)V","invokespecial",169);}
case 169:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Modal","Lforge/card/CardSplitType;"))return JStep.Continue;rt.PutStatic("forge/card/CardSplitType","Modal","Lforge/card/CardSplitType;",f.Pop());f.Pc=172;continue;}
case 172:{if(!rt.EnsureInitialized(f,"forge/card/CardSplitType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardSplitType")));f.Pc=175;continue;}
case 175:{f.StackOp("dup");f.Pc=176;continue;}
case 176:{f.Push(JValue.R(rt.String("Prepare")));f.Pc=178;continue;}
case 178:{f.Push(JValue.I(9));f.Pc=180;continue;}
case 180:{if(!rt.StaticReady(f,"forge/card/CardSplitType$FaceSelectionMethod","USE_ACTIVE_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType$FaceSelectionMethod","USE_ACTIVE_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"));f.Pc=183;continue;}
case 183:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/card/CardSplitType","<init>","(Ljava/lang/String;ILforge/card/CardSplitType$FaceSelectionMethod;Lforge/card/CardStateName;)V","invokespecial",189);}
case 189:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Prepare","Lforge/card/CardSplitType;"))return JStep.Continue;rt.PutStatic("forge/card/CardSplitType","Prepare","Lforge/card/CardSplitType;",f.Pop());f.Pc=192;continue;}
case 192:{if(!rt.EnsureInitialized(f,"forge/card/CardSplitType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardSplitType")));f.Pc=195;continue;}
case 195:{f.StackOp("dup");f.Pc=196;continue;}
case 196:{f.Push(JValue.R(rt.String("Specialize")));f.Pc=198;continue;}
case 198:{f.Push(JValue.I(10));f.Pc=200;continue;}
case 200:{if(!rt.StaticReady(f,"forge/card/CardSplitType$FaceSelectionMethod","USE_ACTIVE_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType$FaceSelectionMethod","USE_ACTIVE_FACE","Lforge/card/CardSplitType$FaceSelectionMethod;"));f.Pc=203;continue;}
case 203:{f.Push(JValue.R(null));f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/card/CardSplitType","<init>","(Ljava/lang/String;ILforge/card/CardSplitType$FaceSelectionMethod;Lforge/card/CardStateName;)V","invokespecial",207);}
case 207:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Specialize","Lforge/card/CardSplitType;"))return JStep.Continue;rt.PutStatic("forge/card/CardSplitType","Specialize","Lforge/card/CardSplitType;",f.Pop());f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/card/CardSplitType","$values","()[Lforge/card/CardSplitType;","invokestatic",213);}
case 213:{if(!rt.StaticReady(f,"forge/card/CardSplitType","$VALUES","[Lforge/card/CardSplitType;"))return JStep.Continue;rt.PutStatic("forge/card/CardSplitType","$VALUES","[Lforge/card/CardSplitType;",f.Pop());f.Pc=216;continue;}
case 216:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Transform","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Transform","Lforge/card/CardSplitType;"));f.Pc=219;continue;}
case 219:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Meld","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Meld","Lforge/card/CardSplitType;"));f.Pc=222;continue;}
case 222:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Modal","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Modal","Lforge/card/CardSplitType;"));f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",228);}
case 228:{if(!rt.StaticReady(f,"forge/card/CardSplitType","DUAL_FACED_CARDS","Ljava/util/EnumSet;"))return JStep.Continue;rt.PutStatic("forge/card/CardSplitType","DUAL_FACED_CARDS","Ljava/util/EnumSet;",f.Pop());f.Pc=231;continue;}
case 231:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
