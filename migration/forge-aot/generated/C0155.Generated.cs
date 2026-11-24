// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C155{
internal static JClass Build(){var c=new JClass("forge/game/GameLogVerbosity","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("LOW","Lforge/game/GameLogVerbosity;",true,JValue.Default("Lforge/game/GameLogVerbosity;"),null));
c.Add(new JField("MEDIUM","Lforge/game/GameLogVerbosity;",true,JValue.Default("Lforge/game/GameLogVerbosity;"),null));
c.Add(new JField("HIGH","Lforge/game/GameLogVerbosity;",true,JValue.Default("Lforge/game/GameLogVerbosity;"),null));
c.Add(new JField("CUSTOM","Lforge/game/GameLogVerbosity;",true,JValue.Default("Lforge/game/GameLogVerbosity;"),null));
c.Add(new JField("caption","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("includedTypes","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("$VALUES","[Lforge/game/GameLogVerbosity;",true,JValue.Default("[Lforge/game/GameLogVerbosity;"),null));
c.Add(new JMethod(2462,"forge/game/GameLogVerbosity","values","()[Lforge/game/GameLogVerbosity;",9,0,1,new JHandler[]{},M2462));
c.Add(new JMethod(2463,"forge/game/GameLogVerbosity","valueOf","(Ljava/lang/String;)Lforge/game/GameLogVerbosity;",9,1,2,new JHandler[]{},M2463));
c.Add(new JMethod(2464,"forge/game/GameLogVerbosity","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/Set;)V",2,5,3,new JHandler[]{},M2464));
c.Add(new JMethod(2465,"forge/game/GameLogVerbosity","getIncludedTypes","()Ljava/util/Set;",1,1,1,new JHandler[]{},M2465));
c.Add(new JMethod(2466,"forge/game/GameLogVerbosity","fromString","(Ljava/lang/String;)Lforge/game/GameLogVerbosity;",9,5,2,new JHandler[]{},M2466));
c.Add(new JMethod(2467,"forge/game/GameLogVerbosity","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M2467));
c.Add(new JMethod(2468,"forge/game/GameLogVerbosity","$values","()[Lforge/game/GameLogVerbosity;",4106,0,4,new JHandler[]{},M2468));
c.Add(new JMethod(2469,"forge/game/GameLogVerbosity","<clinit>","()V",8,0,10,new JHandler[]{},M2469));
}

internal static JStep M2462(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/GameLogVerbosity","$VALUES","[Lforge/game/GameLogVerbosity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogVerbosity","$VALUES","[Lforge/game/GameLogVerbosity;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/GameLogVerbosity;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/GameLogVerbosity;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2463(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/GameLogVerbosity")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameLogVerbosity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2464(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameLogVerbosity","caption","Ljava/lang/String;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameLogVerbosity","includedTypes","Ljava/util/Set;",value);f.Pc=17;continue;}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2465(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogVerbosity","includedTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2466(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/GameLogVerbosity","values","()[Lforge/game/GameLogVerbosity;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?52:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=17;continue;}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/GameLogVerbosity","name","()Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int!=0?43:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogVerbosity","caption","Ljava/lang/String;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?46:43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{return JStep.Return(f.Pop());}
case 46:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=49;continue;}
case 49:{f.Pc=9;continue;}
case 52:{if(!rt.StaticReady(f,"forge/game/GameLogVerbosity","MEDIUM","Lforge/game/GameLogVerbosity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogVerbosity","MEDIUM","Lforge/game/GameLogVerbosity;"));f.Pc=55;continue;}
case 55:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2467(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogVerbosity","caption","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2468(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(4));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Lforge/game/GameLogVerbosity;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/GameLogVerbosity","LOW","Lforge/game/GameLogVerbosity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogVerbosity","LOW","Lforge/game/GameLogVerbosity;"));f.Pc=9;continue;}
case 9:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/GameLogVerbosity","MEDIUM","Lforge/game/GameLogVerbosity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogVerbosity","MEDIUM","Lforge/game/GameLogVerbosity;"));f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/game/GameLogVerbosity","HIGH","Lforge/game/GameLogVerbosity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogVerbosity","HIGH","Lforge/game/GameLogVerbosity;"));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.I(3));f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/GameLogVerbosity","CUSTOM","Lforge/game/GameLogVerbosity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogVerbosity","CUSTOM","Lforge/game/GameLogVerbosity;"));f.Pc=27;continue;}
case 27:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2469(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/GameLogVerbosity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogVerbosity")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("LOW")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("Low")));f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","GAME_OUTCOME","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","GAME_OUTCOME","Lforge/game/GameLogEntryType;"));f.Pc=12;continue;}
case 12:{f.Push(JValue.I(6));f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.NewArray("Lforge/game/GameLogEntryType;",f.Pop().Int)));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","MATCH_RESULTS","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","MATCH_RESULTS","Lforge/game/GameLogEntryType;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","SIDEBOARD","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","SIDEBOARD","Lforge/game/GameLogEntryType;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(2));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","TURN","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","TURN","Lforge/game/GameLogEntryType;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(3));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","MULLIGAN","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","MULLIGAN","Lforge/game/GameLogEntryType;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(4));f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","ANTE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","ANTE","Lforge/game/GameLogEntryType;"));f.Pc=46;continue;}
case 46:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=47;continue;}
case 47:{f.StackOp("dup");f.Pc=48;continue;}
case 48:{f.Push(JValue.I(5));f.Pc=49;continue;}
case 49:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","DAMAGE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","DAMAGE","Lforge/game/GameLogEntryType;"));f.Pc=52;continue;}
case 52:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;[Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",56);}
case 56:{return rt.Call(f,"forge/game/GameLogVerbosity","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/Set;)V","invokespecial",59);}
case 59:{if(!rt.StaticReady(f,"forge/game/GameLogVerbosity","LOW","Lforge/game/GameLogVerbosity;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogVerbosity","LOW","Lforge/game/GameLogVerbosity;",f.Pop());f.Pc=62;continue;}
case 62:{if(!rt.EnsureInitialized(f,"forge/game/GameLogVerbosity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogVerbosity")));f.Pc=65;continue;}
case 65:{f.StackOp("dup");f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("MEDIUM")));f.Pc=68;continue;}
case 68:{f.Push(JValue.I(1));f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("Medium")));f.Pc=71;continue;}
case 71:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","GAME_OUTCOME","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","GAME_OUTCOME","Lforge/game/GameLogEntryType;"));f.Pc=74;continue;}
case 74:{f.Push(JValue.I(13));f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.NewArray("Lforge/game/GameLogEntryType;",f.Pop().Int)));f.Pc=79;continue;}
case 79:{f.StackOp("dup");f.Pc=80;continue;}
case 80:{f.Push(JValue.I(0));f.Pc=81;continue;}
case 81:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","MATCH_RESULTS","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","MATCH_RESULTS","Lforge/game/GameLogEntryType;"));f.Pc=84;continue;}
case 84:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=85;continue;}
case 85:{f.StackOp("dup");f.Pc=86;continue;}
case 86:{f.Push(JValue.I(1));f.Pc=87;continue;}
case 87:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","SIDEBOARD","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","SIDEBOARD","Lforge/game/GameLogEntryType;"));f.Pc=90;continue;}
case 90:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=91;continue;}
case 91:{f.StackOp("dup");f.Pc=92;continue;}
case 92:{f.Push(JValue.I(2));f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","TURN","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","TURN","Lforge/game/GameLogEntryType;"));f.Pc=96;continue;}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(3));f.Pc=99;continue;}
case 99:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","MULLIGAN","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","MULLIGAN","Lforge/game/GameLogEntryType;"));f.Pc=102;continue;}
case 102:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=103;continue;}
case 103:{f.StackOp("dup");f.Pc=104;continue;}
case 104:{f.Push(JValue.I(4));f.Pc=105;continue;}
case 105:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","ANTE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","ANTE","Lforge/game/GameLogEntryType;"));f.Pc=108;continue;}
case 108:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=109;continue;}
case 109:{f.StackOp("dup");f.Pc=110;continue;}
case 110:{f.Push(JValue.I(5));f.Pc=111;continue;}
case 111:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","DAMAGE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","DAMAGE","Lforge/game/GameLogEntryType;"));f.Pc=114;continue;}
case 114:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=115;continue;}
case 115:{f.StackOp("dup");f.Pc=116;continue;}
case 116:{f.Push(JValue.I(6));f.Pc=118;continue;}
case 118:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","ZONE_CHANGE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","ZONE_CHANGE","Lforge/game/GameLogEntryType;"));f.Pc=121;continue;}
case 121:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=122;continue;}
case 122:{f.StackOp("dup");f.Pc=123;continue;}
case 123:{f.Push(JValue.I(7));f.Pc=125;continue;}
case 125:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","LAND","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","LAND","Lforge/game/GameLogEntryType;"));f.Pc=128;continue;}
case 128:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=129;continue;}
case 129:{f.StackOp("dup");f.Pc=130;continue;}
case 130:{f.Push(JValue.I(8));f.Pc=132;continue;}
case 132:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","DISCARD","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","DISCARD","Lforge/game/GameLogEntryType;"));f.Pc=135;continue;}
case 135:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=136;continue;}
case 136:{f.StackOp("dup");f.Pc=137;continue;}
case 137:{f.Push(JValue.I(9));f.Pc=139;continue;}
case 139:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","COMBAT","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","COMBAT","Lforge/game/GameLogEntryType;"));f.Pc=142;continue;}
case 142:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=143;continue;}
case 143:{f.StackOp("dup");f.Pc=144;continue;}
case 144:{f.Push(JValue.I(10));f.Pc=146;continue;}
case 146:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_ADD","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_ADD","Lforge/game/GameLogEntryType;"));f.Pc=149;continue;}
case 149:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=150;continue;}
case 150:{f.StackOp("dup");f.Pc=151;continue;}
case 151:{f.Push(JValue.I(11));f.Pc=153;continue;}
case 153:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=156;continue;}
case 156:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=157;continue;}
case 157:{f.StackOp("dup");f.Pc=158;continue;}
case 158:{f.Push(JValue.I(12));f.Pc=160;continue;}
case 160:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","LIFE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","LIFE","Lforge/game/GameLogEntryType;"));f.Pc=163;continue;}
case 163:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;[Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",167);}
case 167:{return rt.Call(f,"forge/game/GameLogVerbosity","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/Set;)V","invokespecial",170);}
case 170:{if(!rt.StaticReady(f,"forge/game/GameLogVerbosity","MEDIUM","Lforge/game/GameLogVerbosity;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogVerbosity","MEDIUM","Lforge/game/GameLogVerbosity;",f.Pop());f.Pc=173;continue;}
case 173:{if(!rt.EnsureInitialized(f,"forge/game/GameLogVerbosity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogVerbosity")));f.Pc=176;continue;}
case 176:{f.StackOp("dup");f.Pc=177;continue;}
case 177:{f.Push(JValue.R(rt.String("HIGH")));f.Pc=179;continue;}
case 179:{f.Push(JValue.I(2));f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("High")));f.Pc=182;continue;}
case 182:{f.Push(JValue.R(rt.ClassObject("forge/game/GameLogEntryType")));f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/util/EnumSet","allOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",187);}
case 187:{return rt.Call(f,"forge/game/GameLogVerbosity","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/Set;)V","invokespecial",190);}
case 190:{if(!rt.StaticReady(f,"forge/game/GameLogVerbosity","HIGH","Lforge/game/GameLogVerbosity;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogVerbosity","HIGH","Lforge/game/GameLogVerbosity;",f.Pop());f.Pc=193;continue;}
case 193:{if(!rt.EnsureInitialized(f,"forge/game/GameLogVerbosity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogVerbosity")));f.Pc=196;continue;}
case 196:{f.StackOp("dup");f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.String("CUSTOM")));f.Pc=199;continue;}
case 199:{f.Push(JValue.I(3));f.Pc=200;continue;}
case 200:{f.Push(JValue.R(rt.String("Custom")));f.Pc=202;continue;}
case 202:{f.Push(JValue.R(rt.ClassObject("forge/game/GameLogEntryType")));f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",207);}
case 207:{return rt.Call(f,"forge/game/GameLogVerbosity","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/Set;)V","invokespecial",210);}
case 210:{if(!rt.StaticReady(f,"forge/game/GameLogVerbosity","CUSTOM","Lforge/game/GameLogVerbosity;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogVerbosity","CUSTOM","Lforge/game/GameLogVerbosity;",f.Pop());f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/GameLogVerbosity","$values","()[Lforge/game/GameLogVerbosity;","invokestatic",216);}
case 216:{if(!rt.StaticReady(f,"forge/game/GameLogVerbosity","$VALUES","[Lforge/game/GameLogVerbosity;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogVerbosity","$VALUES","[Lforge/game/GameLogVerbosity;",f.Pop());f.Pc=219;continue;}
case 219:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
