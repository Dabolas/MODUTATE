// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C153{
internal static JClass Build(){var c=new JClass("forge/game/GameLogEntryType","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("GAME_OUTCOME","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("MATCH_RESULTS","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("SIDEBOARD","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("TURN","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("MULLIGAN","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("ANTE","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("DRAFT","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("ZONE_CHANGE","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("PLAYER_CONTROL","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("DAMAGE","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("LIFE","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("LAND","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("DISCARD","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("COMBAT","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("INFORMATION","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("STACK_RESOLVE","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("STACK_ADD","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("EFFECT_REPLACED","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("MANA","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("PHASE","Lforge/game/GameLogEntryType;",true,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("caption","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("$VALUES","[Lforge/game/GameLogEntryType;",true,JValue.Default("[Lforge/game/GameLogEntryType;"),null));
c.Add(new JMethod(2405,"forge/game/GameLogEntryType","values","()[Lforge/game/GameLogEntryType;",9,0,1,new JHandler[]{},M2405));
c.Add(new JMethod(2406,"forge/game/GameLogEntryType","valueOf","(Ljava/lang/String;)Lforge/game/GameLogEntryType;",9,1,2,new JHandler[]{},M2406));
c.Add(new JMethod(2407,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V",2,4,3,new JHandler[]{},M2407));
c.Add(new JMethod(2408,"forge/game/GameLogEntryType","getCaption","()Ljava/lang/String;",1,1,1,new JHandler[]{},M2408));
c.Add(new JMethod(2409,"forge/game/GameLogEntryType","$values","()[Lforge/game/GameLogEntryType;",4106,0,4,new JHandler[]{},M2409));
c.Add(new JMethod(2410,"forge/game/GameLogEntryType","<clinit>","()V",8,0,5,new JHandler[]{},M2410));
}

internal static JStep M2405(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","$VALUES","[Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","$VALUES","[Lforge/game/GameLogEntryType;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/GameLogEntryType;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/GameLogEntryType;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2406(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/GameLogEntryType")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameLogEntryType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2407(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameLogEntryType","caption","Ljava/lang/String;",value);f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2408(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogEntryType","caption","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2409(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(20));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/game/GameLogEntryType;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","GAME_OUTCOME","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","GAME_OUTCOME","Lforge/game/GameLogEntryType;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","MATCH_RESULTS","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","MATCH_RESULTS","Lforge/game/GameLogEntryType;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","SIDEBOARD","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","SIDEBOARD","Lforge/game/GameLogEntryType;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","TURN","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","TURN","Lforge/game/GameLogEntryType;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","MULLIGAN","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","MULLIGAN","Lforge/game/GameLogEntryType;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","ANTE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","ANTE","Lforge/game/GameLogEntryType;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","DRAFT","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","DRAFT","Lforge/game/GameLogEntryType;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","ZONE_CHANGE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","ZONE_CHANGE","Lforge/game/GameLogEntryType;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","PLAYER_CONTROL","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","PLAYER_CONTROL","Lforge/game/GameLogEntryType;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","DAMAGE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","DAMAGE","Lforge/game/GameLogEntryType;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","LIFE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","LIFE","Lforge/game/GameLogEntryType;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(11));f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","LAND","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","LAND","Lforge/game/GameLogEntryType;"));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(12));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","DISCARD","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","DISCARD","Lforge/game/GameLogEntryType;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(13));f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","COMBAT","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","COMBAT","Lforge/game/GameLogEntryType;"));f.Pc=96;continue;}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(14));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","INFORMATION","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","INFORMATION","Lforge/game/GameLogEntryType;"));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{f.StackOp("dup");f.Pc=105;continue;}
case 105:{f.Push(JValue.I(15));f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=110;continue;}
case 110:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{f.Push(JValue.I(16));f.Pc=114;continue;}
case 114:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_ADD","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_ADD","Lforge/game/GameLogEntryType;"));f.Pc=117;continue;}
case 117:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(JValue.I(17));f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","EFFECT_REPLACED","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","EFFECT_REPLACED","Lforge/game/GameLogEntryType;"));f.Pc=124;continue;}
case 124:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{f.Push(JValue.I(18));f.Pc=128;continue;}
case 128:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","MANA","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","MANA","Lforge/game/GameLogEntryType;"));f.Pc=131;continue;}
case 131:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=132;continue;}
case 132:{f.StackOp("dup");f.Pc=133;continue;}
case 133:{f.Push(JValue.I(19));f.Pc=135;continue;}
case 135:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","PHASE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","PHASE","Lforge/game/GameLogEntryType;"));f.Pc=138;continue;}
case 138:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=139;continue;}
case 139:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2410(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("GAME_OUTCOME")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("Game Outcome")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",12);}
case 12:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","GAME_OUTCOME","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","GAME_OUTCOME","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("MATCH_RESULTS")));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Match Result")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",27);}
case 27:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","MATCH_RESULTS","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","MATCH_RESULTS","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("SIDEBOARD")));f.Pc=36;continue;}
case 36:{f.Push(JValue.I(2));f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("Sideboard")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",42);}
case 42:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","SIDEBOARD","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","SIDEBOARD","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=45;continue;}
case 45:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("TURN")));f.Pc=51;continue;}
case 51:{f.Push(JValue.I(3));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("Turn")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",57);}
case 57:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","TURN","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","TURN","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=60;continue;}
case 60:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("MULLIGAN")));f.Pc=66;continue;}
case 66:{f.Push(JValue.I(4));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("Mulligan")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",72);}
case 72:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","MULLIGAN","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","MULLIGAN","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=75;continue;}
case 75:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=78;continue;}
case 78:{f.StackOp("dup");f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("ANTE")));f.Pc=81;continue;}
case 81:{f.Push(JValue.I(5));f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("Ante")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",87);}
case 87:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","ANTE","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","ANTE","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=90;continue;}
case 90:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=93;continue;}
case 93:{f.StackOp("dup");f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("DRAFT")));f.Pc=96;continue;}
case 96:{f.Push(JValue.I(6));f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("Draft")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",103);}
case 103:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","DRAFT","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","DRAFT","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=106;continue;}
case 106:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=109;continue;}
case 109:{f.StackOp("dup");f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("ZONE_CHANGE")));f.Pc=112;continue;}
case 112:{f.Push(JValue.I(7));f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("Zone Change")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",119);}
case 119:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","ZONE_CHANGE","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","ZONE_CHANGE","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=122;continue;}
case 122:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("PLAYER_CONTROL")));f.Pc=128;continue;}
case 128:{f.Push(JValue.I(8));f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("Player Control")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",135);}
case 135:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","PLAYER_CONTROL","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","PLAYER_CONTROL","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=138;continue;}
case 138:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=141;continue;}
case 141:{f.StackOp("dup");f.Pc=142;continue;}
case 142:{f.Push(JValue.R(rt.String("DAMAGE")));f.Pc=144;continue;}
case 144:{f.Push(JValue.I(9));f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.String("Damage")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",151);}
case 151:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","DAMAGE","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","DAMAGE","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=154;continue;}
case 154:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=157;continue;}
case 157:{f.StackOp("dup");f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("LIFE")));f.Pc=160;continue;}
case 160:{f.Push(JValue.I(10));f.Pc=162;continue;}
case 162:{f.Push(JValue.R(rt.String("Life")));f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",167);}
case 167:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","LIFE","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","LIFE","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=170;continue;}
case 170:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=173;continue;}
case 173:{f.StackOp("dup");f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("LAND")));f.Pc=176;continue;}
case 176:{f.Push(JValue.I(11));f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("Land")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",183);}
case 183:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","LAND","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","LAND","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=186;continue;}
case 186:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=189;continue;}
case 189:{f.StackOp("dup");f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.String("DISCARD")));f.Pc=192;continue;}
case 192:{f.Push(JValue.I(12));f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("Discard")));f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",199);}
case 199:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","DISCARD","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","DISCARD","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=202;continue;}
case 202:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=205;continue;}
case 205:{f.StackOp("dup");f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.String("COMBAT")));f.Pc=208;continue;}
case 208:{f.Push(JValue.I(13));f.Pc=210;continue;}
case 210:{f.Push(JValue.R(rt.String("Combat")));f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",215);}
case 215:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","COMBAT","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","COMBAT","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=218;continue;}
case 218:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=221;continue;}
case 221:{f.StackOp("dup");f.Pc=222;continue;}
case 222:{f.Push(JValue.R(rt.String("INFORMATION")));f.Pc=224;continue;}
case 224:{f.Push(JValue.I(14));f.Pc=226;continue;}
case 226:{f.Push(JValue.R(rt.String("Information")));f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",231);}
case 231:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","INFORMATION","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","INFORMATION","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=234;continue;}
case 234:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=237;continue;}
case 237:{f.StackOp("dup");f.Pc=238;continue;}
case 238:{f.Push(JValue.R(rt.String("STACK_RESOLVE")));f.Pc=240;continue;}
case 240:{f.Push(JValue.I(15));f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.String("Resolve Stack")));f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",247);}
case 247:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=250;continue;}
case 250:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=253;continue;}
case 253:{f.StackOp("dup");f.Pc=254;continue;}
case 254:{f.Push(JValue.R(rt.String("STACK_ADD")));f.Pc=256;continue;}
case 256:{f.Push(JValue.I(16));f.Pc=258;continue;}
case 258:{f.Push(JValue.R(rt.String("Add To Stack")));f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",263);}
case 263:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_ADD","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","STACK_ADD","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=266;continue;}
case 266:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=269;continue;}
case 269:{f.StackOp("dup");f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("EFFECT_REPLACED")));f.Pc=272;continue;}
case 272:{f.Push(JValue.I(17));f.Pc=274;continue;}
case 274:{f.Push(JValue.R(rt.String("Replacement Effect")));f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",279);}
case 279:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","EFFECT_REPLACED","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","EFFECT_REPLACED","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=282;continue;}
case 282:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=285;continue;}
case 285:{f.StackOp("dup");f.Pc=286;continue;}
case 286:{f.Push(JValue.R(rt.String("MANA")));f.Pc=288;continue;}
case 288:{f.Push(JValue.I(18));f.Pc=290;continue;}
case 290:{f.Push(JValue.R(rt.String("Mana")));f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",295);}
case 295:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","MANA","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","MANA","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=298;continue;}
case 298:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntryType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntryType")));f.Pc=301;continue;}
case 301:{f.StackOp("dup");f.Pc=302;continue;}
case 302:{f.Push(JValue.R(rt.String("PHASE")));f.Pc=304;continue;}
case 304:{f.Push(JValue.I(19));f.Pc=306;continue;}
case 306:{f.Push(JValue.R(rt.String("Phase")));f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/GameLogEntryType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",311);}
case 311:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","PHASE","Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","PHASE","Lforge/game/GameLogEntryType;",f.Pop());f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/GameLogEntryType","$values","()[Lforge/game/GameLogEntryType;","invokestatic",317);}
case 317:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","$VALUES","[Lforge/game/GameLogEntryType;"))return JStep.Continue;rt.PutStatic("forge/game/GameLogEntryType","$VALUES","[Lforge/game/GameLogEntryType;",f.Pop());f.Pc=320;continue;}
case 320:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
