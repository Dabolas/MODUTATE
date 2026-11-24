// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1119{
internal static JClass Build(){var c=new JClass("forge/util/Expressions","java/lang/Object",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11729,"forge/util/Expressions","<init>","()V",1,1,1,new JHandler[]{},M11729));
c.Add(new JMethod(11730,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z",9,3,3,new JHandler[]{},M11730));
c.Add(new JMethod(11731,"forge/util/Expressions","operatorName","(Ljava/lang/String;)Ljava/lang/String;",9,1,2,new JHandler[]{},M11731));
}

internal static JStep M11729(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11730(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("LT")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?20:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("LE")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int==0?40:29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?38:34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{f.Pc=39;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("EQ")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?60:49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?58:54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{f.Pc=59;continue;}
case 58:{f.Push(JValue.I(0));f.Pc=59;continue;}
case 59:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("GE")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?80:69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?78:74;continue;}
case 74:{f.Push(JValue.I(1));f.Pc=75;continue;}
case 75:{f.Pc=79;continue;}
case 78:{f.Push(JValue.I(0));f.Pc=79;continue;}
case 79:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.String("GT")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int==0?100:89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?98:94;continue;}
case 94:{f.Push(JValue.I(1));f.Pc=95;continue;}
case 95:{f.Pc=99;continue;}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("NE")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?120:109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?118:114;continue;}
case 114:{f.Push(JValue.I(1));f.Pc=115;continue;}
case 115:{f.Pc=119;continue;}
case 118:{f.Push(JValue.I(0));f.Pc=119;continue;}
case 119:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("M2")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int==0?144:129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(JValue.I(2));f.Pc=131;continue;}
case 131:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=132;continue;}
case 132:{f.Push(f.Locals[2]);f.Pc=133;continue;}
case 133:{f.Push(JValue.I(2));f.Pc=134;continue;}
case 134:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=135;continue;}
case 135:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?142:138;continue;}
case 138:{f.Push(JValue.I(1));f.Pc=139;continue;}
case 139:{f.Pc=143;continue;}
case 142:{f.Push(JValue.I(0));f.Pc=143;continue;}
case 143:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 144:{f.Push(JValue.I(0));f.Pc=145;continue;}
case 145:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11731(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("LT")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?12:9;continue;}
case 9:{f.Push(JValue.R(rt.String(" less than ")));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("LE")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?24:21;continue;}
case 21:{f.Push(JValue.R(rt.String(" less or equal to ")));f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("EQ")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?36:33;continue;}
case 33:{f.Push(JValue.R(rt.String(" equal to ")));f.Pc=35;continue;}
case 35:{return JStep.Return(f.Pop());}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("GT")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?48:45;continue;}
case 45:{f.Push(JValue.R(rt.String(" greater than ")));f.Pc=47;continue;}
case 47:{return JStep.Return(f.Pop());}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("GE")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?60:57;continue;}
case 57:{f.Push(JValue.R(rt.String(" greater or equal to ")));f.Pc=59;continue;}
case 59:{return JStep.Return(f.Pop());}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("NE")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?72:69;continue;}
case 69:{f.Push(JValue.R(rt.String(" not equal to ")));f.Pc=71;continue;}
case 71:{return JStep.Return(f.Pop());}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("M2")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int==0?84:81;continue;}
case 81:{f.Push(JValue.R(rt.String(" is modulo 2 equal to")));f.Pc=83;continue;}
case 83:{return JStep.Return(f.Pop());}
case 84:{f.Push(JValue.R(rt.String(" ? ")));f.Pc=86;continue;}
case 86:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
