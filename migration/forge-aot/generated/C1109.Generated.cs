// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1109{
internal static JClass Build(){var c=new JClass("forge/util/Base64Coder","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("SYSTEM_LINE_SEPARATOR","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("map1","[C",true,JValue.Default("[C"),null));
c.Add(new JField("map2","[B",true,JValue.Default("[B"),null));
c.Add(new JField("PASSWORD","[C",true,JValue.Default("[C"),null));
c.Add(new JField("SALT","[B",true,JValue.Default("[B"),null));
c.Add(new JMethod(11655,"forge/util/Base64Coder","encodeString","(Ljava/lang/String;)Ljava/lang/String;",9,1,3,new JHandler[]{},M11655));
c.Add(new JMethod(11656,"forge/util/Base64Coder","encodeString","(Ljava/lang/String;Z)Ljava/lang/String;",9,3,3,new JHandler[]{},M11656));
c.Add(new JMethod(11657,"forge/util/Base64Coder","encodeLines","([B)Ljava/lang/String;",9,1,5,new JHandler[]{},M11657));
c.Add(new JMethod(11658,"forge/util/Base64Coder","encodeLines","([BIIILjava/lang/String;)Ljava/lang/String;",9,11,4,new JHandler[]{},M11658));
c.Add(new JMethod(11659,"forge/util/Base64Coder","encode","([B)[C",9,1,3,new JHandler[]{},M11659));
c.Add(new JMethod(11660,"forge/util/Base64Coder","encode","([BI)[C",9,2,3,new JHandler[]{},M11660));
c.Add(new JMethod(11661,"forge/util/Base64Coder","encode","([BII)[C",9,16,4,new JHandler[]{},M11661));
c.Add(new JMethod(11662,"forge/util/Base64Coder","decodeString","(Ljava/lang/String;)Ljava/lang/String;",9,1,3,new JHandler[]{},M11662));
c.Add(new JMethod(11663,"forge/util/Base64Coder","decodeLines","(Ljava/lang/String;)[B",9,5,3,new JHandler[]{},M11663));
c.Add(new JMethod(11664,"forge/util/Base64Coder","decode","(Ljava/lang/String;)[B",9,1,1,new JHandler[]{},M11664));
c.Add(new JMethod(11665,"forge/util/Base64Coder","decode","([C)[B",9,1,3,new JHandler[]{},M11665));
c.Add(new JMethod(11666,"forge/util/Base64Coder","decode","([CII)[B",9,19,3,new JHandler[]{},M11666));
c.Add(new JMethod(11667,"forge/util/Base64Coder","encrypt","(Ljava/lang/String;)Ljava/lang/String;",9,4,7,new JHandler[]{},M11667));
c.Add(new JMethod(11668,"forge/util/Base64Coder","decrypt","(Ljava/lang/String;)Ljava/lang/String;",9,4,7,new JHandler[]{},M11668));
c.Add(new JMethod(11669,"forge/util/Base64Coder","<init>","()V",2,1,1,new JHandler[]{},M11669));
c.Add(new JMethod(11670,"forge/util/Base64Coder","<clinit>","()V",8,2,4,new JHandler[]{},M11670));
}

internal static JStep M11655(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/String"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/String")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","getBytes","()[B","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/util/Base64Coder","encode","([B)[C","invokestatic",11);}
case 11:{return rt.Call(f,"java/lang/String","<init>","([C)V","invokespecial",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11656(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/String"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/String")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","getBytes","()[B","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/util/Base64Coder","encode","([B)[C","invokestatic",11);}
case 11:{return rt.Call(f,"java/lang/String","<init>","([C)V","invokespecial",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Int==0?28:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("=")));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",27);}
case 27:{f.Locals[2]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11657(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(76));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/util/Base64Coder","SYSTEM_LINE_SEPARATOR","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","SYSTEM_LINE_SEPARATOR","Ljava/lang/String;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Base64Coder","encodeLines","([BIIILjava/lang/String;)Ljava/lang/String;","invokestatic",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11658(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(3));f.Pc=2;continue;}
case 2:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(4));f.Pc=4;continue;}
case 4:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=5;continue;}
case 5:{f.Locals[5]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[5]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Int>0?20:12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","()V","invokespecial",19);}
case 19:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[5]);f.Pc=23;continue;}
case 23:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=29;continue;}
case 29:{f.Locals[6]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=34;continue;}
case 34:{f.Push(JValue.I(3));f.Pc=35;continue;}
case 35:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=36;continue;}
case 36:{f.Push(JValue.I(4));f.Pc=37;continue;}
case 37:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[6]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",45);}
case 45:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=46;continue;}
case 46:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=47;continue;}
case 47:{f.Locals[7]=f.Pop();f.Pc=49;continue;}
case 49:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=52;continue;}
case 52:{f.StackOp("dup");f.Pc=53;continue;}
case 53:{f.Push(f.Locals[7]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/StringBuilder","<init>","(I)V","invokespecial",58);}
case 58:{f.Locals[8]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(JValue.I(0));f.Pc=61;continue;}
case 61:{f.Locals[9]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[9]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?114:69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[9]);f.Pc=72;continue;}
case 72:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=73;continue;}
case 73:{f.Push(f.Locals[5]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",78);}
case 78:{f.Locals[10]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[8]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[9]);f.Pc=86;continue;}
case 86:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[10]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/util/Base64Coder","encode","([BII)[C","invokestatic",92);}
case 92:{return rt.Call(f,"java/lang/StringBuilder","append","([C)Ljava/lang/StringBuilder;","invokevirtual",95);}
case 95:{f.StackOp("pop");f.Pc=96;continue;}
case 96:{f.Push(f.Locals[8]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",103);}
case 103:{f.StackOp("pop");f.Pc=104;continue;}
case 104:{f.Push(f.Locals[9]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[10]);f.Pc=108;continue;}
case 108:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=109;continue;}
case 109:{f.Locals[9]=f.Pop();f.Pc=111;continue;}
case 111:{f.Pc=63;continue;}
case 114:{f.Push(f.Locals[8]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",119);}
case 119:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11659(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/Base64Coder","encode","([BII)[C","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11660(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/Base64Coder","encode","([BII)[C","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11661(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(4));f.Pc=2;continue;}
case 2:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(2));f.Pc=4;continue;}
case 4:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(3));f.Pc=6;continue;}
case 6:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=7;continue;}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.I(2));f.Pc=10;continue;}
case 10:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=11;continue;}
case 11:{f.Push(JValue.I(3));f.Pc=12;continue;}
case 12:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=13;continue;}
case 13:{f.Push(JValue.I(4));f.Pc=14;continue;}
case 14:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=15;continue;}
case 15:{f.Locals[4]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.NewArray("C",f.Pop().Int)));f.Pc=21;continue;}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Locals[6]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=29;continue;}
case 29:{f.Locals[7]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{f.Locals[8]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[6]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[7]);f.Pc=38;continue;}
case 38:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?224:41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[6]);f.Pc=44;continue;}
case 44:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=47;continue;}
case 47:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=48;continue;}
case 48:{f.Push(JValue.I(255));f.Pc=51;continue;}
case 51:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=52;continue;}
case 52:{f.Locals[9]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[7]);f.Pc=58;continue;}
case 58:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?75:61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=67;continue;}
case 67:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=68;continue;}
case 68:{f.Push(JValue.I(255));f.Pc=71;continue;}
case 71:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=72;continue;}
case 72:{f.Pc=76;continue;}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{f.Locals[10]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[6]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[7]);f.Pc=82;continue;}
case 82:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?99:85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=91;continue;}
case 91:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=92;continue;}
case 92:{f.Push(JValue.I(255));f.Pc=95;continue;}
case 95:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=96;continue;}
case 96:{f.Pc=100;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{f.Locals[11]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[9]);f.Pc=104;continue;}
case 104:{f.Push(JValue.I(2));f.Pc=105;continue;}
case 105:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iushr",a,b));f.Pc=106;continue;}
case 106:{f.Locals[12]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[9]);f.Pc=110;continue;}
case 110:{f.Push(JValue.I(3));f.Pc=111;continue;}
case 111:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=112;continue;}
case 112:{f.Push(JValue.I(4));f.Pc=113;continue;}
case 113:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[10]);f.Pc=116;continue;}
case 116:{f.Push(JValue.I(4));f.Pc=117;continue;}
case 117:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iushr",a,b));f.Pc=118;continue;}
case 118:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=119;continue;}
case 119:{f.Locals[13]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[10]);f.Pc=123;continue;}
case 123:{f.Push(JValue.I(15));f.Pc=125;continue;}
case 125:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=126;continue;}
case 126:{f.Push(JValue.I(2));f.Pc=127;continue;}
case 127:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=128;continue;}
case 128:{f.Push(f.Locals[11]);f.Pc=130;continue;}
case 130:{f.Push(JValue.I(6));f.Pc=132;continue;}
case 132:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iushr",a,b));f.Pc=133;continue;}
case 133:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=134;continue;}
case 134:{f.Locals[14]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[11]);f.Pc=138;continue;}
case 138:{f.Push(JValue.I(63));f.Pc=140;continue;}
case 140:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=141;continue;}
case 141:{f.Locals[15]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[8]);f.Pc=147;continue;}
case 147:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=150;continue;}
case 150:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map1","[C"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","map1","[C"));f.Pc=153;continue;}
case 153:{f.Push(f.Locals[12]);f.Pc=155;continue;}
case 155:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=156;continue;}
case 156:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[5]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[8]);f.Pc=161;continue;}
case 161:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=164;continue;}
case 164:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map1","[C"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","map1","[C"));f.Pc=167;continue;}
case 167:{f.Push(f.Locals[13]);f.Pc=169;continue;}
case 169:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=170;continue;}
case 170:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[5]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[8]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[8]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[3]);f.Pc=178;continue;}
case 178:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?190:181;continue;}
case 181:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map1","[C"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","map1","[C"));f.Pc=184;continue;}
case 184:{f.Push(f.Locals[14]);f.Pc=186;continue;}
case 186:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=187;continue;}
case 187:{f.Pc=192;continue;}
case 190:{f.Push(JValue.I(61));f.Pc=192;continue;}
case 192:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=193;continue;}
case 193:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=196;continue;}
case 196:{f.Push(f.Locals[5]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[8]);f.Pc=200;continue;}
case 200:{f.Push(f.Locals[8]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[3]);f.Pc=203;continue;}
case 203:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?215:206;continue;}
case 206:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map1","[C"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","map1","[C"));f.Pc=209;continue;}
case 209:{f.Push(f.Locals[15]);f.Pc=211;continue;}
case 211:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=212;continue;}
case 212:{f.Pc=217;continue;}
case 215:{f.Push(JValue.I(61));f.Pc=217;continue;}
case 217:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=218;continue;}
case 218:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=221;continue;}
case 221:{f.Pc=34;continue;}
case 224:{f.Push(f.Locals[5]);f.Pc=226;continue;}
case 226:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11662(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/String"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/String")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/Base64Coder","decode","(Ljava/lang/String;)[B","invokestatic",8);}
case 8:{return rt.Call(f,"java/lang/String","<init>","([B)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11663(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.NewArray("C",f.Pop().Int)));f.Pc=6;continue;}
case 6:{f.Locals[1]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",16);}
case 16:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?68:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{f.Push(JValue.I(32));f.Pc=30;continue;}
case 30:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?62:33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{f.Push(JValue.I(13));f.Pc=37;continue;}
case 37:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?62:40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(10));f.Pc=44;continue;}
case 44:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?62:47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(9));f.Pc=51;continue;}
case 51:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?62:54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=65;continue;}
case 65:{f.Pc=11;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/util/Base64Coder","decode","([CII)[B","invokestatic",74);}
case 74:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11664(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","toCharArray","()[C","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/util/Base64Coder","decode","([C)[B","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11665(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/Base64Coder","decode","([CII)[B","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11666(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(4));f.Pc=2;continue;}
case 2:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Int==0?16:6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("Length of Base64 encoded input string is not a multiple of 4.")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",15);}
case 15:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Int<=0?38:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=26;continue;}
case 26:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=27;continue;}
case 27:{f.Push(JValue.I(61));f.Pc=29;continue;}
case 29:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?38:32;continue;}
case 32:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(-1)));f.Pc=35;continue;}
case 35:{f.Pc=16;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(JValue.I(3));f.Pc=40;continue;}
case 40:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=41;continue;}
case 41:{f.Push(JValue.I(4));f.Pc=42;continue;}
case 42:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=43;continue;}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.NewArray("B",f.Pop().Int)));f.Pc=47;continue;}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Locals[5]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=55;continue;}
case 55:{f.Locals[6]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{f.Locals[7]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?312:67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=73;continue;}
case 73:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=74;continue;}
case 74:{f.Locals[8]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=82;continue;}
case 82:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=83;continue;}
case 83:{f.Locals[9]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[5]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[6]);f.Pc=89;continue;}
case 89:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?102:92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[5]);f.Pc=95;continue;}
case 95:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=98;continue;}
case 98:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=99;continue;}
case 99:{f.Pc=104;continue;}
case 102:{f.Push(JValue.I(65));f.Pc=104;continue;}
case 104:{f.Locals[10]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[5]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[6]);f.Pc=110;continue;}
case 110:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?123:113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[5]);f.Pc=116;continue;}
case 116:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=119;continue;}
case 119:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=120;continue;}
case 120:{f.Pc=125;continue;}
case 123:{f.Push(JValue.I(65));f.Pc=125;continue;}
case 125:{f.Locals[11]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[8]);f.Pc=129;continue;}
case 129:{f.Push(JValue.I(127));f.Pc=131;continue;}
case 131:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?155:134;continue;}
case 134:{f.Push(f.Locals[9]);f.Pc=136;continue;}
case 136:{f.Push(JValue.I(127));f.Pc=138;continue;}
case 138:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?155:141;continue;}
case 141:{f.Push(f.Locals[10]);f.Pc=143;continue;}
case 143:{f.Push(JValue.I(127));f.Pc=145;continue;}
case 145:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?155:148;continue;}
case 148:{f.Push(f.Locals[11]);f.Pc=150;continue;}
case 150:{f.Push(JValue.I(127));f.Pc=152;continue;}
case 152:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?165:155;continue;}
case 155:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=158;continue;}
case 158:{f.StackOp("dup");f.Pc=159;continue;}
case 159:{f.Push(JValue.R(rt.String("Illegal character in Base64 encoded data.")));f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",164);}
case 164:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 165:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map2","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","map2","[B"));f.Pc=168;continue;}
case 168:{f.Push(f.Locals[8]);f.Pc=170;continue;}
case 170:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=171;continue;}
case 171:{f.Locals[12]=f.Pop();f.Pc=173;continue;}
case 173:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map2","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","map2","[B"));f.Pc=176;continue;}
case 176:{f.Push(f.Locals[9]);f.Pc=178;continue;}
case 178:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=179;continue;}
case 179:{f.Locals[13]=f.Pop();f.Pc=181;continue;}
case 181:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map2","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","map2","[B"));f.Pc=184;continue;}
case 184:{f.Push(f.Locals[10]);f.Pc=186;continue;}
case 186:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=187;continue;}
case 187:{f.Locals[14]=f.Pop();f.Pc=189;continue;}
case 189:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map2","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","map2","[B"));f.Pc=192;continue;}
case 192:{f.Push(f.Locals[11]);f.Pc=194;continue;}
case 194:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=195;continue;}
case 195:{f.Locals[15]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[12]);f.Pc=199;continue;}
case 199:{f.Pc=f.Pop().Int<0?217:202;continue;}
case 202:{f.Push(f.Locals[13]);f.Pc=204;continue;}
case 204:{f.Pc=f.Pop().Int<0?217:207;continue;}
case 207:{f.Push(f.Locals[14]);f.Pc=209;continue;}
case 209:{f.Pc=f.Pop().Int<0?217:212;continue;}
case 212:{f.Push(f.Locals[15]);f.Pc=214;continue;}
case 214:{f.Pc=f.Pop().Int>=0?227:217;continue;}
case 217:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=220;continue;}
case 220:{f.StackOp("dup");f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String("Illegal character in Base64 encoded data.")));f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",226);}
case 226:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 227:{f.Push(f.Locals[12]);f.Pc=229;continue;}
case 229:{f.Push(JValue.I(2));f.Pc=230;continue;}
case 230:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=231;continue;}
case 231:{f.Push(f.Locals[13]);f.Pc=233;continue;}
case 233:{f.Push(JValue.I(4));f.Pc=234;continue;}
case 234:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iushr",a,b));f.Pc=235;continue;}
case 235:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=236;continue;}
case 236:{f.Locals[16]=f.Pop();f.Pc=238;continue;}
case 238:{f.Push(f.Locals[13]);f.Pc=240;continue;}
case 240:{f.Push(JValue.I(15));f.Pc=242;continue;}
case 242:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=243;continue;}
case 243:{f.Push(JValue.I(4));f.Pc=244;continue;}
case 244:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=245;continue;}
case 245:{f.Push(f.Locals[14]);f.Pc=247;continue;}
case 247:{f.Push(JValue.I(2));f.Pc=248;continue;}
case 248:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iushr",a,b));f.Pc=249;continue;}
case 249:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=250;continue;}
case 250:{f.Locals[17]=f.Pop();f.Pc=252;continue;}
case 252:{f.Push(f.Locals[14]);f.Pc=254;continue;}
case 254:{f.Push(JValue.I(3));f.Pc=255;continue;}
case 255:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=256;continue;}
case 256:{f.Push(JValue.I(6));f.Pc=258;continue;}
case 258:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=259;continue;}
case 259:{f.Push(f.Locals[15]);f.Pc=261;continue;}
case 261:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=262;continue;}
case 262:{f.Locals[18]=f.Pop();f.Pc=264;continue;}
case 264:{f.Push(f.Locals[4]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[7]);f.Pc=268;continue;}
case 268:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=271;continue;}
case 271:{f.Push(f.Locals[16]);f.Pc=273;continue;}
case 273:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=274;continue;}
case 274:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=275;continue;}
case 275:{f.Push(f.Locals[7]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[3]);f.Pc=278;continue;}
case 278:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?292:281;continue;}
case 281:{f.Push(f.Locals[4]);f.Pc=283;continue;}
case 283:{f.Push(f.Locals[7]);f.Pc=285;continue;}
case 285:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=288;continue;}
case 288:{f.Push(f.Locals[17]);f.Pc=290;continue;}
case 290:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=291;continue;}
case 291:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=292;continue;}
case 292:{f.Push(f.Locals[7]);f.Pc=294;continue;}
case 294:{f.Push(f.Locals[3]);f.Pc=295;continue;}
case 295:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?309:298;continue;}
case 298:{f.Push(f.Locals[4]);f.Pc=300;continue;}
case 300:{f.Push(f.Locals[7]);f.Pc=302;continue;}
case 302:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=305;continue;}
case 305:{f.Push(f.Locals[18]);f.Pc=307;continue;}
case 307:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=308;continue;}
case 308:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=309;continue;}
case 309:{f.Pc=60;continue;}
case 312:{f.Push(f.Locals[4]);f.Pc=314;continue;}
case 314:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11667(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("PBEWithMD5AndDES")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"javax/crypto/SecretKeyFactory","getInstance","(Ljava/lang/String;)Ljavax/crypto/SecretKeyFactory;","invokestatic",5);}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"javax/crypto/spec/PBEKeySpec"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("javax/crypto/spec/PBEKeySpec")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/util/Base64Coder","PASSWORD","[C"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","PASSWORD","[C"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"javax/crypto/spec/PBEKeySpec","<init>","([C)V","invokespecial",17);}
case 17:{return rt.Call(f,"javax/crypto/SecretKeyFactory","generateSecret","(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;","invokevirtual",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("PBEWithMD5AndDES")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"javax/crypto/Cipher","getInstance","(Ljava/lang/String;)Ljavax/crypto/Cipher;","invokestatic",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"javax/crypto/spec/PBEParameterSpec"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("javax/crypto/spec/PBEParameterSpec")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/util/Base64Coder","SALT","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","SALT","[B"));f.Pc=37;continue;}
case 37:{f.Push(JValue.I(20));f.Pc=39;continue;}
case 39:{return rt.Call(f,"javax/crypto/spec/PBEParameterSpec","<init>","([BI)V","invokespecial",42);}
case 42:{return rt.Call(f,"javax/crypto/Cipher","init","(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V","invokevirtual",45);}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"java/nio/charset/StandardCharsets","UTF_8","Ljava/nio/charset/Charset;"))return JStep.Continue;f.Push(rt.GetStatic("java/nio/charset/StandardCharsets","UTF_8","Ljava/nio/charset/Charset;"));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/String","getBytes","(Ljava/nio/charset/Charset;)[B","invokevirtual",53);}
case 53:{return rt.Call(f,"javax/crypto/Cipher","doFinal","([B)[B","invokevirtual",56);}
case 56:{return rt.Call(f,"forge/util/Base64Coder","encode","([B)[C","invokestatic",59);}
case 59:{return rt.Call(f,"java/lang/String","valueOf","([C)Ljava/lang/String;","invokestatic",62);}
case 62:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11668(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("PBEWithMD5AndDES")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"javax/crypto/SecretKeyFactory","getInstance","(Ljava/lang/String;)Ljavax/crypto/SecretKeyFactory;","invokestatic",5);}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"javax/crypto/spec/PBEKeySpec"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("javax/crypto/spec/PBEKeySpec")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/util/Base64Coder","PASSWORD","[C"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","PASSWORD","[C"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"javax/crypto/spec/PBEKeySpec","<init>","([C)V","invokespecial",17);}
case 17:{return rt.Call(f,"javax/crypto/SecretKeyFactory","generateSecret","(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;","invokevirtual",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("PBEWithMD5AndDES")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"javax/crypto/Cipher","getInstance","(Ljava/lang/String;)Ljavax/crypto/Cipher;","invokestatic",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{f.Push(JValue.I(2));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"javax/crypto/spec/PBEParameterSpec"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("javax/crypto/spec/PBEParameterSpec")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/util/Base64Coder","SALT","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","SALT","[B"));f.Pc=37;continue;}
case 37:{f.Push(JValue.I(20));f.Pc=39;continue;}
case 39:{return rt.Call(f,"javax/crypto/spec/PBEParameterSpec","<init>","([BI)V","invokespecial",42);}
case 42:{return rt.Call(f,"javax/crypto/Cipher","init","(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V","invokevirtual",45);}
case 45:{if(!rt.EnsureInitialized(f,"java/lang/String"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/String")));f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/util/Base64Coder","decode","(Ljava/lang/String;)[B","invokestatic",54);}
case 54:{return rt.Call(f,"javax/crypto/Cipher","doFinal","([B)[B","invokevirtual",57);}
case 57:{if(!rt.StaticReady(f,"java/nio/charset/StandardCharsets","UTF_8","Ljava/nio/charset/Charset;"))return JStep.Continue;f.Push(rt.GetStatic("java/nio/charset/StandardCharsets","UTF_8","Ljava/nio/charset/Charset;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/String","<init>","([BLjava/nio/charset/Charset;)V","invokespecial",63);}
case 63:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11669(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11670(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"java/lang/System","lineSeparator","()Ljava/lang/String;","invokestatic",3);}
case 3:{if(!rt.StaticReady(f,"forge/util/Base64Coder","SYSTEM_LINE_SEPARATOR","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/util/Base64Coder","SYSTEM_LINE_SEPARATOR","Ljava/lang/String;",f.Pop());f.Pc=6;continue;}
case 6:{f.Push(JValue.I(64));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.NewArray("C",f.Pop().Int)));f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map1","[C"))return JStep.Continue;rt.PutStatic("forge/util/Base64Coder","map1","[C",f.Pop());f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{f.Locals[0]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(JValue.I(65));f.Pc=17;continue;}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(90));f.Pc=21;continue;}
case 21:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?41:24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map1","[C"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","map1","[C"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Locals[0]=JValue.I(unchecked(f.Locals[0].Int+(1)));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=36;continue;}
case 36:{f.Push(JNumbers.Unary("i2c",f.Pop()));f.Pc=37;continue;}
case 37:{f.Locals[1]=f.Pop();f.Pc=38;continue;}
case 38:{f.Pc=18;continue;}
case 41:{f.Push(JValue.I(97));f.Pc=43;continue;}
case 43:{f.Locals[1]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(JValue.I(122));f.Pc=47;continue;}
case 47:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?67:50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map1","[C"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","map1","[C"));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Locals[0]=JValue.I(unchecked(f.Locals[0].Int+(1)));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=62;continue;}
case 62:{f.Push(JNumbers.Unary("i2c",f.Pop()));f.Pc=63;continue;}
case 63:{f.Locals[1]=f.Pop();f.Pc=64;continue;}
case 64:{f.Pc=44;continue;}
case 67:{f.Push(JValue.I(48));f.Pc=69;continue;}
case 69:{f.Locals[1]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(JValue.I(57));f.Pc=73;continue;}
case 73:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?93:76;continue;}
case 76:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map1","[C"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","map1","[C"));f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Locals[0]=JValue.I(unchecked(f.Locals[0].Int+(1)));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(JValue.I(1));f.Pc=87;continue;}
case 87:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=88;continue;}
case 88:{f.Push(JNumbers.Unary("i2c",f.Pop()));f.Pc=89;continue;}
case 89:{f.Locals[1]=f.Pop();f.Pc=90;continue;}
case 90:{f.Pc=70;continue;}
case 93:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map1","[C"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","map1","[C"));f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Locals[0]=JValue.I(unchecked(f.Locals[0].Int+(1)));f.Pc=100;continue;}
case 100:{f.Push(JValue.I(43));f.Pc=102;continue;}
case 102:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=103;continue;}
case 103:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map1","[C"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","map1","[C"));f.Pc=106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{f.Locals[0]=JValue.I(unchecked(f.Locals[0].Int+(1)));f.Pc=110;continue;}
case 110:{f.Push(JValue.I(47));f.Pc=112;continue;}
case 112:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=113;continue;}
case 113:{f.Push(JValue.I(128));f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.NewArray("B",f.Pop().Int)));f.Pc=118;continue;}
case 118:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map2","[B"))return JStep.Continue;rt.PutStatic("forge/util/Base64Coder","map2","[B",f.Pop());f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map2","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","map2","[B"));f.Pc=124;continue;}
case 124:{f.Push(JValue.I(-1));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/util/Arrays","fill","([BB)V","invokestatic",128);}
case 128:{f.Push(JValue.I(0));f.Pc=129;continue;}
case 129:{f.Locals[0]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{f.Push(JValue.I(64));f.Pc=133;continue;}
case 133:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?153:136;continue;}
case 136:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map2","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","map2","[B"));f.Pc=139;continue;}
case 139:{if(!rt.StaticReady(f,"forge/util/Base64Coder","map1","[C"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Base64Coder","map1","[C"));f.Pc=142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=144;continue;}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=146;continue;}
case 146:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=147;continue;}
case 147:{f.Locals[0]=JValue.I(unchecked(f.Locals[0].Int+(1)));f.Pc=150;continue;}
case 150:{f.Pc=130;continue;}
case 153:{f.Push(JValue.R(rt.String("enfldsgbnlsngdlksdsgm")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/lang/String","toCharArray","()[C","invokevirtual",158);}
case 158:{if(!rt.StaticReady(f,"forge/util/Base64Coder","PASSWORD","[C"))return JStep.Continue;rt.PutStatic("forge/util/Base64Coder","PASSWORD","[C",f.Pop());f.Pc=161;continue;}
case 161:{f.Push(JValue.I(8));f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.NewArray("B",f.Pop().Int)));f.Pc=165;continue;}
case 165:{f.StackOp("dup");f.Pc=166;continue;}
case 166:{f.Push(JValue.I(0));f.Pc=167;continue;}
case 167:{f.Push(JValue.I(-34));f.Pc=169;continue;}
case 169:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=170;continue;}
case 170:{f.StackOp("dup");f.Pc=171;continue;}
case 171:{f.Push(JValue.I(1));f.Pc=172;continue;}
case 172:{f.Push(JValue.I(51));f.Pc=174;continue;}
case 174:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=175;continue;}
case 175:{f.StackOp("dup");f.Pc=176;continue;}
case 176:{f.Push(JValue.I(2));f.Pc=177;continue;}
case 177:{f.Push(JValue.I(16));f.Pc=179;continue;}
case 179:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=180;continue;}
case 180:{f.StackOp("dup");f.Pc=181;continue;}
case 181:{f.Push(JValue.I(3));f.Pc=182;continue;}
case 182:{f.Push(JValue.I(18));f.Pc=184;continue;}
case 184:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=185;continue;}
case 185:{f.StackOp("dup");f.Pc=186;continue;}
case 186:{f.Push(JValue.I(4));f.Pc=187;continue;}
case 187:{f.Push(JValue.I(-34));f.Pc=189;continue;}
case 189:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=190;continue;}
case 190:{f.StackOp("dup");f.Pc=191;continue;}
case 191:{f.Push(JValue.I(5));f.Pc=192;continue;}
case 192:{f.Push(JValue.I(51));f.Pc=194;continue;}
case 194:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=195;continue;}
case 195:{f.StackOp("dup");f.Pc=196;continue;}
case 196:{f.Push(JValue.I(6));f.Pc=198;continue;}
case 198:{f.Push(JValue.I(16));f.Pc=200;continue;}
case 200:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=201;continue;}
case 201:{f.StackOp("dup");f.Pc=202;continue;}
case 202:{f.Push(JValue.I(7));f.Pc=204;continue;}
case 204:{f.Push(JValue.I(18));f.Pc=206;continue;}
case 206:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=207;continue;}
case 207:{if(!rt.StaticReady(f,"forge/util/Base64Coder","SALT","[B"))return JStep.Continue;rt.PutStatic("forge/util/Base64Coder","SALT","[B",f.Pop());f.Pc=210;continue;}
case 210:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
