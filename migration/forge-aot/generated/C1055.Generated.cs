// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1055{
internal static JClass Build(){var c=new JClass("forge/item/BoosterSlot","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("slotName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("baseRarity","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("startRange","F",false,JValue.Default("F"),null));
c.Add(new JField("slotPercentages","Ljava/util/TreeMap;",false,JValue.Default("Ljava/util/TreeMap;"),null));
c.Add(new JMethod(11192,"forge/item/BoosterSlot","<init>","(Ljava/lang/String;Ljava/util/List;)V",1,3,3,new JHandler[]{},M11192));
c.Add(new JMethod(11193,"forge/item/BoosterSlot","getSlotName","()Ljava/lang/String;",17,1,1,new JHandler[]{},M11193));
c.Add(new JMethod(11194,"forge/item/BoosterSlot","parseSlot","(Ljava/lang/String;Ljava/util/List;)Lforge/item/BoosterSlot;",9,2,4,new JHandler[]{},M11194));
c.Add(new JMethod(11195,"forge/item/BoosterSlot","parseContents","(Ljava/util/List;)V",2,9,4,new JHandler[]{},M11195));
c.Add(new JMethod(11196,"forge/item/BoosterSlot","replaceSlot","()Ljava/lang/String;",1,4,4,new JHandler[]{},M11196));
}

internal static JStep M11192(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.F(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/BoosterSlot","startRange","F",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/TreeMap","<init>","()V","invokespecial",17);}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/BoosterSlot","slotPercentages","Ljava/util/TreeMap;",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/BoosterSlot","slotName","Ljava/lang/String;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(null));f.Pc=27;continue;}
case 27:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/BoosterSlot","baseRarity","Ljava/lang/String;",value);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/item/BoosterSlot","parseContents","(Ljava/util/List;)V","invokevirtual",35);}
case 35:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11193(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterSlot","slotName","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11194(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/item/BoosterSlot"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/BoosterSlot")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/item/BoosterSlot","<init>","(Ljava/lang/String;Ljava/util/List;)V","invokespecial",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11195(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?140:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("#")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?38:35;continue;}
case 35:{f.Pc=7;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("=")));f.Pc=41;continue;}
case 41:{f.Push(JValue.I(2));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Locals[4]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=51;continue;}
case 51:{f.Locals[5]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[4]);f.Pc=55;continue;}
case 55:{f.Push(JValue.I(1));f.Pc=56;continue;}
case 56:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=57;continue;}
case 57:{f.Locals[6]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Base")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?78:69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[6]);f.Pc=72;continue;}
case 72:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/BoosterSlot","baseRarity","Ljava/lang/String;",value);f.Pc=75;continue;}
case 75:{f.Pc=137;continue;}
case 78:{f.Push(f.Locals[5]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("Replace")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?137:88;continue;}
case 88:{f.Push(f.Locals[6]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String(" ")));f.Pc=92;continue;}
case 92:{f.Push(JValue.I(2));f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",96);}
case 96:{f.Locals[7]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[7]);f.Pc=100;continue;}
case 100:{f.Push(JValue.I(0));f.Pc=101;continue;}
case 101:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/Float","parseFloat","(Ljava/lang/String;)F","invokestatic",105);}
case 105:{f.Locals[8]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.StackOp("dup");f.Pc=109;continue;}
case 109:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterSlot","startRange","F"));f.Pc=112;continue;}
case 112:{f.Push(f.Locals[8]);f.Pc=114;continue;}
case 114:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fadd",a,b));f.Pc=115;continue;}
case 115:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/BoosterSlot","startRange","F",value);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterSlot","slotPercentages","Ljava/util/TreeMap;"));f.Pc=122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterSlot","startRange","F"));f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/lang/Float","valueOf","(F)Ljava/lang/Float;","invokestatic",129);}
case 129:{f.Push(f.Locals[7]);f.Pc=131;continue;}
case 131:{f.Push(JValue.I(1));f.Pc=132;continue;}
case 132:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/TreeMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",136);}
case 136:{f.StackOp("pop");f.Pc=137;continue;}
case 137:{f.Pc=7;continue;}
case 140:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11196(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",3);}
case 3:{return rt.Call(f,"java/util/Random","nextFloat","()F","invokevirtual",6);}
case 6:{f.Locals[1]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterSlot","slotPercentages","Ljava/util/TreeMap;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/TreeMap","keySet","()Ljava/util/Set;","invokevirtual",14);}
case 14:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?89:29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Float"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/Float","floatValue","()F","invokevirtual",44);}
case 44:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fcmpg",a,b));f.Pc=45;continue;}
case 45:{f.Pc=f.Pop().Int>=0?86:48;continue;}
case 48:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterSlot","slotName","Ljava/lang/String;"));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterSlot","slotPercentages","Ljava/util/TreeMap;"));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/TreeMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{return rt.DynamicCall(f,"forge/item/BoosterSlot:11196:66:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",71);}
case 71:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",74);}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterSlot","slotPercentages","Ljava/util/TreeMap;"));f.Pc=78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/TreeMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",82);}
case 82:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=85;continue;}
case 85:{return JStep.Return(f.Pop());}
case 86:{f.Pc=20;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterSlot","baseRarity","Ljava/lang/String;"));f.Pc=93;continue;}
case 93:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
