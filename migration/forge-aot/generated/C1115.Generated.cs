// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1115{
internal static JClass Build(){var c=new JClass("forge/util/ComparatorUtil","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11718,"forge/util/ComparatorUtil","safeSort","(Ljava/util/List;Ljava/util/Comparator;)Z",9,7,5,new JHandler[]{new JHandler(19,27,28,"java/lang/IllegalArgumentException")},M11718));
c.Add(new JMethod(11719,"forge/util/ComparatorUtil","mergeSort","([Ljava/lang/Object;[Ljava/lang/Object;IILjava/util/Comparator;)V",10,9,5,new JHandler[]{},M11719));
c.Add(new JMethod(11720,"forge/util/ComparatorUtil","verifyTransitivity","(Ljava/util/Comparator;Ljava/util/Collection;)Ljava/lang/String;",9,12,7,new JHandler[]{},M11720));
c.Add(new JMethod(11721,"forge/util/ComparatorUtil","<init>","()V",2,1,1,new JHandler[]{},M11721));
}

internal static JStep M11718(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",6);}
case 6:{f.Push(JValue.I(2));f.Pc=7;continue;}
case 7:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/List","toArray","()[Ljava/lang/Object;","invokeinterface",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",26);}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"[Ljava/lang/Object;","clone","()Ljava/lang/Object;","invokevirtual",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/lang/Object;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"[Ljava/lang/Object;","clone","()Ljava/lang/Object;","invokevirtual",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/lang/Object;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/util/ComparatorUtil","mergeSort","([Ljava/lang/Object;[Ljava/lang/Object;IILjava/util/Comparator;)V","invokestatic",55);}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{f.Locals[5]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=63;continue;}
case 63:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?90:66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=71;continue;}
case 71:{f.Locals[6]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[5]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[6]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/List","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokeinterface",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=87;continue;}
case 87:{f.Pc=58;continue;}
case 90:{f.Push(JValue.I(1));f.Pc=91;continue;}
case 91:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11719(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(2));f.Pc=4;continue;}
case 4:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iushr",a,b));f.Pc=13;continue;}
case 13:{f.Locals[5]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/util/ComparatorUtil","mergeSort","([Ljava/lang/Object;[Ljava/lang/Object;IILjava/util/Comparator;)V","invokestatic",25);}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[5]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/util/ComparatorUtil","mergeSort","([Ljava/lang/Object;[Ljava/lang/Object;IILjava/util/Comparator;)V","invokestatic",35);}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Locals[6]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{f.Locals[7]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Locals[8]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[8]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?113:51;continue;}
case 51:{f.Push(f.Locals[7]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?82:57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?96:64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[7]);f.Pc=73;continue;}
case 73:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Comparator","compare","(Ljava/lang/Object;Ljava/lang/Object;)I","invokeinterface",79);}
case 79:{f.Pc=f.Pop().Int>0?96:82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[8]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=91;continue;}
case 91:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=92;continue;}
case 92:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=93;continue;}
case 93:{f.Pc=107;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[8]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[7]);f.Pc=102;continue;}
case 102:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=105;continue;}
case 105:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=106;continue;}
case 106:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=107;continue;}
case 107:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=110;continue;}
case 110:{f.Pc=45;continue;}
case 113:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11720(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{f.Locals[2]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?121:19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",33);}
case 33:{f.Locals[5]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?118:45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",52);}
case 52:{f.Locals[6]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Comparator","compare","(Ljava/lang/Object;Ljava/lang/Object;)I","invokeinterface",64);}
case 64:{f.Locals[7]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Comparator","compare","(Ljava/lang/Object;Ljava/lang/Object;)I","invokeinterface",76);}
case 76:{f.Locals[8]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[7]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[8]);f.Pc=82;continue;}
case 82:{f.Push(JNumbers.Unary("ineg",f.Pop()));f.Pc=83;continue;}
case 83:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?115:86;continue;}
case 86:{f.Push(f.Locals[4]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",91);}
case 91:{f.Push(f.Locals[6]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",96);}
case 96:{f.Push(f.Locals[7]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[8]);f.Pc=100;continue;}
case 100:{return rt.DynamicCall(f,"forge/util/ComparatorUtil:11720:100:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;II)Ljava/lang/String;",105);}
case 105:{f.Locals[2]=f.Pop();f.Pc=106;continue;}
case 106:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",113);}
case 113:{f.Push(f.Locals[2]);f.Pc=114;continue;}
case 114:{return JStep.Return(f.Pop());}
case 115:{f.Pc=35;continue;}
case 118:{f.Pc=10;continue;}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",127);}
case 127:{f.Locals[3]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",134);}
case 134:{f.Pc=f.Pop().Int==0?312:137;continue;}
case 137:{f.Push(f.Locals[3]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",143);}
case 143:{f.Locals[4]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",151);}
case 151:{f.Locals[5]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[5]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",160);}
case 160:{f.Pc=f.Pop().Int==0?309:163;continue;}
case 163:{f.Push(f.Locals[5]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",170);}
case 170:{f.Locals[6]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[4]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[6]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/Comparator","compare","(Ljava/lang/Object;Ljava/lang/Object;)I","invokeinterface",182);}
case 182:{f.Locals[7]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(f.Locals[7]);f.Pc=186;continue;}
case 186:{f.Pc=f.Pop().Int>0?192:189;continue;}
case 189:{f.Pc=153;continue;}
case 192:{f.Push(f.Locals[1]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",198);}
case 198:{f.Locals[8]=f.Pop();f.Pc=200;continue;}
case 200:{f.Push(f.Locals[8]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",207);}
case 207:{f.Pc=f.Pop().Int==0?306:210;continue;}
case 210:{f.Push(f.Locals[8]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",217);}
case 217:{f.Locals[9]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[0]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[6]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[9]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"java/util/Comparator","compare","(Ljava/lang/Object;Ljava/lang/Object;)I","invokeinterface",229);}
case 229:{f.Locals[10]=f.Pop();f.Pc=231;continue;}
case 231:{f.Push(f.Locals[10]);f.Pc=233;continue;}
case 233:{f.Pc=f.Pop().Int>0?239:236;continue;}
case 236:{f.Pc=200;continue;}
case 239:{f.Push(f.Locals[0]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[4]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[9]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/util/Comparator","compare","(Ljava/lang/Object;Ljava/lang/Object;)I","invokeinterface",249);}
case 249:{f.Locals[11]=f.Pop();f.Pc=251;continue;}
case 251:{f.Push(f.Locals[11]);f.Pc=253;continue;}
case 253:{f.Pc=f.Pop().Int>0?303:256;continue;}
case 256:{f.Push(f.Locals[4]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",261);}
case 261:{f.Push(f.Locals[6]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",266);}
case 266:{f.Push(f.Locals[6]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",271);}
case 271:{f.Push(f.Locals[9]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",276);}
case 276:{f.Push(f.Locals[4]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",281);}
case 281:{f.Push(f.Locals[9]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",286);}
case 286:{f.Push(f.Locals[11]);f.Pc=288;continue;}
case 288:{return rt.DynamicCall(f,"forge/util/ComparatorUtil:11720:288:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;",293);}
case 293:{f.Locals[2]=f.Pop();f.Pc=294;continue;}
case 294:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=297;continue;}
case 297:{f.Push(f.Locals[2]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",301);}
case 301:{f.Push(f.Locals[2]);f.Pc=302;continue;}
case 302:{return JStep.Return(f.Pop());}
case 303:{f.Pc=200;continue;}
case 306:{f.Pc=153;continue;}
case 309:{f.Pc=128;continue;}
case 312:{f.Push(f.Locals[2]);f.Pc=313;continue;}
case 313:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11721(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
