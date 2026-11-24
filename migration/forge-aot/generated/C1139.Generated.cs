// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1139{
internal static JClass Build(){var c=new JClass("forge/util/LogSafe","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("DEFAULT_MAX_LENGTH","I",true,JValue.I(512),null));
c.Add(new JField("TRUNCATED","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"\u2026[truncated]"));
c.Add(new JMethod(11938,"forge/util/LogSafe","<init>","()V",2,1,1,new JHandler[]{},M11938));
c.Add(new JMethod(11939,"forge/util/LogSafe","forLog","(Ljava/lang/String;)Ljava/lang/String;",9,1,3,new JHandler[]{},M11939));
c.Add(new JMethod(11940,"forge/util/LogSafe","forLog","(Ljava/lang/String;I)Ljava/lang/String;",9,2,3,new JHandler[]{},M11940));
c.Add(new JMethod(11941,"forge/util/LogSafe","forDisplay","(Ljava/lang/String;)Ljava/lang/String;",9,1,3,new JHandler[]{},M11941));
c.Add(new JMethod(11942,"forge/util/LogSafe","forDisplay","(Ljava/lang/String;I)Ljava/lang/String;",9,2,3,new JHandler[]{},M11942));
c.Add(new JMethod(11943,"forge/util/LogSafe","scrub","(Ljava/lang/String;IZ)Ljava/lang/String;",10,7,6,new JHandler[]{},M11943));
c.Add(new JMethod(11944,"forge/util/LogSafe","isControl","(C)Z",10,1,2,new JHandler[]{},M11944));
}

internal static JStep M11938(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11939(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(512));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/LogSafe","scrub","(Ljava/lang/String;IZ)Ljava/lang/String;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11940(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/LogSafe","scrub","(Ljava/lang/String;IZ)Ljava/lang/String;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11941(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(512));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/LogSafe","scrub","(Ljava/lang/String;IZ)Ljava/lang/String;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11942(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/LogSafe","scrub","(Ljava/lang/String;IZ)Ljava/lang/String;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11943(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","truncate","(Ljava/lang/String;I)Ljava/lang/String;","invokestatic",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",20);}
case 20:{f.Push(JValue.I(8));f.Pc=22;continue;}
case 22:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","<init>","(I)V","invokespecial",26);}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",37);}
case 37:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?170:40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",46);}
case 46:{f.Locals[6]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/util/LogSafe","isControl","(C)Z","invokestatic",53);}
case 53:{f.Pc=f.Pop().Int!=0?67:56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[6]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{f.Pc=164;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{f.Pc=f.Pop().Int==0?164:71;continue;}
case 71:{f.Push(f.Locals[6]);f.Pc=73;continue;}
case 73:{switch(f.Pop().Int){case 9:f.Pc=130;break;case 10:f.Pc=108;break;case 11:f.Pc=141;break;case 12:f.Pc=141;break;case 13:f.Pc=119;break;default:f.Pc=141;break;}continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("\\n")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",115);}
case 115:{f.StackOp("pop");f.Pc=116;continue;}
case 116:{f.Pc=164;continue;}
case 119:{f.Push(f.Locals[4]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("\\r")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",126);}
case 126:{f.StackOp("pop");f.Pc=127;continue;}
case 127:{f.Pc=164;continue;}
case 130:{f.Push(f.Locals[4]);f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.String("\\t")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",137);}
case 137:{f.StackOp("pop");f.Pc=138;continue;}
case 138:{f.Pc=164;continue;}
case 141:{f.Push(f.Locals[4]);f.Pc=143;continue;}
case 143:{f.Push(JValue.R(rt.String("\\u%04x")));f.Pc=145;continue;}
case 145:{f.Push(JValue.I(1));f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=149;continue;}
case 149:{f.StackOp("dup");f.Pc=150;continue;}
case 150:{f.Push(JValue.I(0));f.Pc=151;continue;}
case 151:{f.Push(f.Locals[6]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",156);}
case 156:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",160);}
case 160:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",163);}
case 163:{f.StackOp("pop");f.Pc=164;continue;}
case 164:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=167;continue;}
case 167:{f.Pc=31;continue;}
case 170:{f.Push(f.Locals[3]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",174);}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",178);}
case 178:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?189:181;continue;}
case 181:{f.Push(f.Locals[4]);f.Pc=183;continue;}
case 183:{f.Push(JValue.R(rt.String("\u2026[truncated]")));f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",188);}
case 188:{f.StackOp("pop");f.Pc=189;continue;}
case 189:{f.Push(f.Locals[4]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",194);}
case 194:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11944(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(32));f.Pc=3;continue;}
case 3:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?19:6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(127));f.Pc=9;continue;}
case 9:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?23:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(159));f.Pc=16;continue;}
case 16:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?23:19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
