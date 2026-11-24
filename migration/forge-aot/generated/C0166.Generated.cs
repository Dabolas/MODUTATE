// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C166{
internal static JClass Build(){var c=new JClass("forge/game/GameState$PlayerState","java/lang/Object",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("life","I",false,JValue.Default("I"),null));
c.Add(new JField("counters","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("manaPool","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("persistentMana","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("landsPlayed","I",false,JValue.Default("I"),null));
c.Add(new JField("numRingTemptedYou","I",false,JValue.Default("I"),null));
c.Add(new JField("speed","I",false,JValue.Default("I"),null));
c.Add(new JField("precast","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("putOnStack","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("cardTexts","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(2623,"forge/game/GameState$PlayerState","<init>","()V",0,1,4,new JHandler[]{},M2623));
}

internal static JStep M2623(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(-1));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","life","I",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("")));f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","counters","Ljava/lang/String;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("")));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","manaPool","Ljava/lang/String;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("")));f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","persistentMana","Ljava/lang/String;",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","landsPlayed","I",value);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","numRingTemptedYou","I",value);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","speed","I",value);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(null));f.Pc=44;continue;}
case 44:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","precast","Ljava/lang/String;",value);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(null));f.Pc=49;continue;}
case 49:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","putOnStack","Ljava/lang/String;",value);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{if(!rt.EnsureInitialized(f,"java/util/EnumMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/EnumMap")));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.ClassObject("forge/game/zone/ZoneType")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/EnumMap","<init>","(Ljava/lang/Class;)V","invokespecial",62);}
case 62:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","cardTexts","Ljava/util/Map;",value);f.Pc=65;continue;}
case 65:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
