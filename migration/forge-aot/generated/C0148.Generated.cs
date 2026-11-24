// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C148{
internal static JClass Build(){var c=new JClass("forge/game/GameFormat$InverseDateComparator","java/lang/Object",new string[]{"java/util/Comparator"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(2354,"forge/game/GameFormat$InverseDateComparator","<init>","()V",1,1,1,new JHandler[]{},M2354));
c.Add(new JMethod(2355,"forge/game/GameFormat$InverseDateComparator","compare","(Lforge/game/GameFormat;Lforge/game/GameFormat;)I",1,3,2,new JHandler[]{},M2355));
c.Add(new JMethod(2356,"forge/game/GameFormat$InverseDateComparator","compare","(Ljava/lang/Object;Ljava/lang/Object;)I",4161,3,3,new JHandler[]{},M2356));
}

internal static JStep M2354(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2355(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?10:5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?12:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatType","Lforge/game/GameFormat$FormatType;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatType","Lforge/game/GameFormat$FormatType;"));f.Pc=20;continue;}
case 20:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?35:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatType","Lforge/game/GameFormat$FormatType;"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatType","Lforge/game/GameFormat$FormatType;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/GameFormat$FormatType","compareTo","(Ljava/lang/Enum;)I","invokevirtual",34);}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatSubType","Lforge/game/GameFormat$FormatSubType;"));f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatSubType","Lforge/game/GameFormat$FormatSubType;"));f.Pc=43;continue;}
case 43:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?58:46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatSubType","Lforge/game/GameFormat$FormatSubType;"));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatSubType","Lforge/game/GameFormat$FormatSubType;"));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","compareTo","(Ljava/lang/Enum;)I","invokevirtual",57);}
case 57:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatType","Lforge/game/GameFormat$FormatType;"));f.Pc=62;continue;}
case 62:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatType","ARCHIVED","Lforge/game/GameFormat$FormatType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatType","ARCHIVED","Lforge/game/GameFormat$FormatType;"));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/GameFormat$FormatType","equals","(Ljava/lang/Object;)Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int==0?94:71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","effectiveDate","Ljava/util/Date;"));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","effectiveDate","Ljava/util/Date;"));f.Pc=79;continue;}
case 79:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?94:82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","effectiveDate","Ljava/util/Date;"));f.Pc=86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","effectiveDate","Ljava/util/Date;"));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Date","compareTo","(Ljava/util/Date;)I","invokevirtual",93);}
case 93:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","name","Ljava/lang/String;"));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","name","Ljava/lang/String;"));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/String","compareTo","(Ljava/lang/String;)I","invokevirtual",105);}
case 105:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2356(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/GameFormat$InverseDateComparator","compare","(Lforge/game/GameFormat;Lforge/game/GameFormat;)I","invokevirtual",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
