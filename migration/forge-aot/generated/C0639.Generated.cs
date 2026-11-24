// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C639{
internal static JClass Build(){var c=new JClass("forge/game/keyword/Affinity","forge/game/keyword/KeywordWithType",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(7387,"forge/game/keyword/Affinity","<init>","()V",1,1,1,new JHandler[]{},M7387));
c.Add(new JMethod(7388,"forge/game/keyword/Affinity","getTitle","()Ljava/lang/String;",1,2,2,new JHandler[]{},M7388));
c.Add(new JMethod(7389,"forge/game/keyword/Affinity","parse","(Ljava/lang/String;)V",4,3,4,new JHandler[]{},M7389));
}

internal static JStep M7387(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithType","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7388(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Affinity for ")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Affinity","descType","Ljava/lang/String;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",26);}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7389(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Affinity")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?30:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("Permanent.withAffinity")));f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Affinity","type","Ljava/lang/String;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Affinity")));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Affinity","descType","Ljava/lang/String;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("permanent with affinity")));f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Affinity","reminderType","Ljava/lang/String;",value);f.Pc=27;continue;}
case 27:{f.Pc=180;continue;}
case 30:{f.Push(JValue.R(rt.String("Outlaw")));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int==0?68:39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("Permanent.Outlaw")));f.Pc=42;continue;}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Affinity","type","Ljava/lang/String;",value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("outlaws")));f.Pc=48;continue;}
case 48:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Affinity","descType","Ljava/lang/String;",value);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",55);}
case 55:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","OUTLAW_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","OUTLAW_TYPES","Ljava/util/Set;"));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(1));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/util/Lang","buildValidDesc","(Ljava/util/Collection;Z)Ljava/lang/String;","invokevirtual",62);}
case 62:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Affinity","reminderType","Ljava/lang/String;",value);f.Pc=65;continue;}
case 65:{f.Pc=180;continue;}
case 68:{f.Push(JValue.R(rt.String("Historic")));f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int==0?98:77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("Permanent.Historic")));f.Pc=80;continue;}
case 80:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Affinity","type","Ljava/lang/String;",value);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("historic permanents")));f.Pc=86;continue;}
case 86:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Affinity","descType","Ljava/lang/String;",value);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("artifact, legendary, and/or Saga permanent")));f.Pc=92;continue;}
case 92:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Affinity","reminderType","Ljava/lang/String;",value);f.Pc=95;continue;}
case 95:{f.Pc=180;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String(":")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int==0?141:107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String(":")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",113);}
case 113:{f.Locals[2]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[2]);f.Pc=116;continue;}
case 116:{f.Push(JValue.I(0));f.Pc=117;continue;}
case 117:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=118;continue;}
case 118:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Affinity","type","Ljava/lang/String;",value);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[2]);f.Pc=123;continue;}
case 123:{f.Push(JValue.I(1));f.Pc=124;continue;}
case 124:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/util/Lang","getPlural","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",128);}
case 128:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Affinity","descType","Ljava/lang/String;",value);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[2]);f.Pc=133;continue;}
case 133:{f.Push(JValue.I(1));f.Pc=134;continue;}
case 134:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=135;continue;}
case 135:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Affinity","reminderType","Ljava/lang/String;",value);f.Pc=138;continue;}
case 138:{f.Pc=180;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[1]);f.Pc=143;continue;}
case 143:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Affinity","type","Ljava/lang/String;",value);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Affinity","type","Ljava/lang/String;"));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/card/CardType","getPluralType","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",154);}
case 154:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Affinity","descType","Ljava/lang/String;",value);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",161);}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Affinity","type","Ljava/lang/String;"));f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String(",")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",170);}
case 170:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",173);}
case 173:{f.Push(JValue.I(1));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/util/Lang","buildValidDesc","(Ljava/util/Collection;Z)Ljava/lang/String;","invokevirtual",177);}
case 177:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Affinity","reminderType","Ljava/lang/String;",value);f.Pc=180;continue;}
case 180:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
