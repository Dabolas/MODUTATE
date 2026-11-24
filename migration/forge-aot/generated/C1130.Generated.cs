// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1130{
internal static JClass Build(){var c=new JClass("forge/util/ImageUtil","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11789,"forge/util/ImageUtil","<init>","()V",1,1,1,new JHandler[]{},M11789));
c.Add(new JMethod(11790,"forge/util/ImageUtil","getNearestHQSize","(FF)F",9,2,7,new JHandler[]{},M11790));
c.Add(new JMethod(11791,"forge/util/ImageUtil","getPaperCardFromImageKey","(Ljava/lang/String;)Lforge/item/PaperCard;",9,4,2,new JHandler[]{},M11791));
c.Add(new JMethod(11792,"forge/util/ImageUtil","getPaperTokenFromImageKey","(Ljava/lang/String;)Lforge/item/PaperToken;",9,5,5,new JHandler[]{},M11792));
c.Add(new JMethod(11793,"forge/util/ImageUtil","transformKey","(Ljava/lang/String;)Ljava/lang/String;",9,5,4,new JHandler[]{},M11793));
c.Add(new JMethod(11794,"forge/util/ImageUtil","getImageRelativePath","(Lforge/item/IPaperCard;Ljava/lang/String;ZZ)Ljava/lang/String;",9,14,4,new JHandler[]{},M11794));
c.Add(new JMethod(11795,"forge/util/ImageUtil","getNameToUse","(Lforge/item/IPaperCard;Ljava/lang/String;)Ljava/lang/String;",9,4,2,new JHandler[]{},M11795));
c.Add(new JMethod(11796,"forge/util/ImageUtil","getImageKey","(Lforge/item/IPaperCard;Ljava/lang/String;Z)Ljava/lang/String;",9,3,4,new JHandler[]{},M11796));
c.Add(new JMethod(11797,"forge/util/ImageUtil","getDownloadUrl","(Lforge/item/PaperCard;Ljava/lang/String;)Ljava/lang/String;",9,2,4,new JHandler[]{},M11797));
c.Add(new JMethod(11798,"forge/util/ImageUtil","getScryfallDownloadUrl","(Lforge/item/PaperCard;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;",9,11,5,new JHandler[]{},M11798));
c.Add(new JMethod(11799,"forge/util/ImageUtil","getScryfallTokenDownloadUrl","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,5,5,new JHandler[]{},M11799));
c.Add(new JMethod(11800,"forge/util/ImageUtil","specFaceToCollectorSuffix","(Ljava/lang/String;)Ljava/lang/String;",10,2,1,new JHandler[]{},M11800));
c.Add(new JMethod(11801,"forge/util/ImageUtil","encodeUtf8","(Ljava/lang/String;)Ljava/lang/String;",10,2,2,new JHandler[]{new JHandler(0,7,8,"java/lang/Exception")},M11801));
c.Add(new JMethod(11802,"forge/util/ImageUtil","toMWSFilename","(Ljava/lang/String;)Ljava/lang/String;",9,4,2,new JHandler[]{},M11802));
}

internal static JStep M11789(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11790(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Math","round","(F)I","invokestatic",4);}
case 4:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=5;continue;}
case 5:{f.Push(JValue.D(2.0d));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fdiv",a,b));f.Pc=11;continue;}
case 11:{f.Push(JNumbers.Unary("f2d",f.Pop()));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Math","log","(D)D","invokestatic",15);}
case 15:{f.Push(JValue.D(2.0d));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/Math","log","(D)D","invokestatic",21);}
case 21:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ddiv",a,b));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/Math","round","(D)J","invokestatic",25);}
case 25:{f.Push(JNumbers.Unary("l2d",f.Pop()));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/Math","pow","(DD)D","invokestatic",29);}
case 29:{f.Push(JNumbers.Unary("d2f",f.Pop()));f.Pc=30;continue;}
case 30:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fmul",a,b));f.Pc=31;continue;}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11791(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?12:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",8);}
case 8:{f.Push(JValue.I(2));f.Pc=9;continue;}
case 9:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?14:12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("c:")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?36:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("c:")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",29);}
case 29:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Locals[1]=f.Pop();f.Pc=33;continue;}
case 33:{f.Pc=38;continue;}
case 36:{f.Push(JValue.R(null));f.Pc=37;continue;}
case 37:{return JStep.Return(f.Pop());}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?47:45;continue;}
case 45:{f.Push(JValue.R(null));f.Pc=46;continue;}
case 46:{return JStep.Return(f.Pop());}
case 47:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",50);}
case 50:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",53);}
case 53:{f.Locals[2]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(JValue.R(null));f.Pc=55;continue;}
case 55:{f.Locals[3]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{f.Pc=f.Pop().Reference==null?87:60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",65);}
case 65:{f.Locals[3]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{f.Pc=f.Pop().Reference!=null?87:70;continue;}
case 70:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",73);}
case 73:{return rt.Call(f,"forge/StaticData","getVariantCards","()Lforge/card/CardDb;","invokevirtual",76);}
case 76:{f.Locals[2]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{f.Pc=f.Pop().Reference==null?87:81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",86);}
case 86:{f.Locals[3]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[3]);f.Pc=88;continue;}
case 88:{f.Pc=f.Pop().Reference!=null?103:91;continue;}
case 91:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{return rt.DynamicCall(f,"forge/util/ImageUtil:11791:95:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",100);}
case 100:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",103);}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11792(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?13:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("t:")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int!=0?15:13;continue;}
case 13:{f.Push(JValue.R(null));f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("t:")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Locals[1]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?34:32;continue;}
case 32:{f.Push(JValue.R(null));f.Pc=33;continue;}
case 33:{return JStep.Return(f.Pop());}
case 34:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",37);}
case 37:{return rt.Call(f,"forge/StaticData","getAllTokens","()Lforge/token/TokenDb;","invokevirtual",40);}
case 40:{f.Locals[2]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Reference!=null?47:45;continue;}
case 45:{f.Push(JValue.R(null));f.Pc=46;continue;}
case 46:{return JStep.Return(f.Pop());}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("\\|")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",53);}
case 53:{f.Locals[3]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/token/TokenDb","containsRule","(Ljava/lang/String;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?66:64;continue;}
case 64:{f.Push(JValue.R(null));f.Pc=65;continue;}
case 65:{return JStep.Return(f.Pop());}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=68;continue;}
case 68:{switch(f.Pop().Int){case 1:f.Pc=96;break;case 2:f.Pc=106;break;case 3:f.Pc=106;break;default:f.Pc=119;break;}continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/token/TokenDb","getToken","(Ljava/lang/String;)Lforge/item/PaperToken;","invokevirtual",103);}
case 103:{f.Pc=135;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{f.Push(JValue.I(0));f.Pc=109;continue;}
case 109:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=110;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{f.Push(JValue.I(1));f.Pc=112;continue;}
case 112:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/token/TokenDb","getToken","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperToken;","invokevirtual",116);}
case 116:{f.Pc=135;continue;}
case 119:{f.Push(f.Locals[2]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{f.Push(JValue.I(0));f.Pc=122;continue;}
case 122:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=123;continue;}
case 123:{f.Push(f.Locals[3]);f.Pc=124;continue;}
case 124:{f.Push(JValue.I(1));f.Pc=125;continue;}
case 125:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=126;continue;}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{f.Push(JValue.I(3));f.Pc=128;continue;}
case 128:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",132);}
case 132:{return rt.Call(f,"forge/token/TokenDb","getToken","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperToken;","invokevirtual",135);}
case 135:{f.Locals[4]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[4]);f.Pc=139;continue;}
case 139:{f.Pc=f.Pop().Reference!=null?154:142;continue;}
case 142:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=145;continue;}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{return rt.DynamicCall(f,"forge/util/ImageUtil:11792:146:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",151);}
case 151:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",154);}
case 154:{f.Push(f.Locals[4]);f.Pc=156;continue;}
case 156:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11793(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("/")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("/")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",19);}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String(".")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",27);}
case 27:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",30);}
case 30:{f.Push(JValue.R(rt.String("[^0-9]")));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?66:45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("/")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",52);}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String(".")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",60);}
case 60:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",63);}
case 63:{f.Pc=83;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("/")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",73);}
case 73:{f.Push(JValue.I(1));f.Pc=74;continue;}
case 74:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",80);}
case 80:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",83);}
case 83:{f.Locals[4]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[4]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{return rt.DynamicCall(f,"forge/util/ImageUtil:11793:88:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",93);}
case 93:{f.Locals[1]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int!=0?109:101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{return rt.DynamicCall(f,"forge/util/ImageUtil:11793:103:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",108);}
case 108:{f.Locals[1]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11794(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?8:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Pc=13;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/ImageUtil","getNameToUse","(Lforge/item/IPaperCard;Ljava/lang/String;)Ljava/lang/String;","invokestatic",13);}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Reference!=null?22:20;continue;}
case 20:{f.Push(JValue.R(null));f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
case 22:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",29);}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/item/IPaperCard","getRules","()Lforge/card/CardRules;","invokeinterface",37);}
case 37:{f.Locals[6]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/item/IPaperCard","getEdition","()Ljava/lang/String;","invokeinterface",45);}
case 45:{f.Push(JValue.R(rt.String("???")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?58:53;continue;}
case 53:{f.Push(JValue.R(rt.String("UNKNOWN")));f.Pc=55;continue;}
case 55:{f.Pc=64;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/item/IPaperCard","getEdition","()Ljava/lang/String;","invokeinterface",64);}
case 64:{f.Locals[7]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/util/ImageUtil","toMWSFilename","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",73);}
case 73:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",76);}
case 76:{f.StackOp("pop");f.Pc=77;continue;}
case 77:{f.Push(f.Locals[6]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/card/CardRules","isVariant","()Z","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Int!=0?94:85;continue;}
case 85:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",88);}
case 88:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",91);}
case 91:{f.Pc=100;continue;}
case 94:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",97);}
case 97:{return rt.Call(f,"forge/StaticData","getVariantCards","()Lforge/card/CardDb;","invokevirtual",100);}
case 100:{f.Locals[10]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{f.Pc=f.Pop().Int==0?142:106;continue;}
case 106:{f.Push(f.Locals[10]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[6]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",113);}
case 113:{f.Push(f.Locals[7]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/item/IPaperCard","getFunctionalVariant","()Ljava/lang/String;","invokeinterface",121);}
case 121:{return rt.Call(f,"forge/card/CardDb","getArtCount","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I","invokevirtual",124);}
case 124:{f.Locals[8]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[8]);f.Pc=128;continue;}
case 128:{f.Push(JValue.I(1));f.Pc=129;continue;}
case 129:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?136:132;continue;}
case 132:{f.Push(JValue.I(1));f.Pc=133;continue;}
case 133:{f.Pc=137;continue;}
case 136:{f.Push(JValue.I(0));f.Pc=137;continue;}
case 137:{f.Locals[9]=f.Pop();f.Pc=139;continue;}
case 139:{f.Pc=170;continue;}
case 142:{f.Push(JValue.I(1));f.Pc=143;continue;}
case 143:{f.Locals[8]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[10]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[6]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",152);}
case 152:{return rt.Call(f,"forge/card/CardDb","getMaxArtIndex","(Ljava/lang/String;)I","invokevirtual",155);}
case 155:{f.Locals[11]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[11]);f.Pc=159;continue;}
case 159:{f.Push(JValue.I(1));f.Pc=160;continue;}
case 160:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?167:163;continue;}
case 163:{f.Push(JValue.I(1));f.Pc=164;continue;}
case 164:{f.Pc=168;continue;}
case 167:{f.Push(JValue.I(0));f.Pc=168;continue;}
case 168:{f.Locals[9]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/item/IPaperCard","getArtIndex","()I","invokeinterface",176);}
case 176:{f.Push(JValue.I(1));f.Pc=177;continue;}
case 177:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=178;continue;}
case 178:{f.Locals[11]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[9]);f.Pc=182;continue;}
case 182:{f.Pc=f.Pop().Int==0?209:185;continue;}
case 185:{f.Push(f.Locals[8]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[11]);f.Pc=189;continue;}
case 189:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?199:192;continue;}
case 192:{f.Push(f.Locals[11]);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[8]);f.Pc=196;continue;}
case 196:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=197;continue;}
case 197:{f.Locals[11]=f.Pop();f.Pc=199;continue;}
case 199:{f.Push(f.Locals[5]);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[11]);f.Pc=203;continue;}
case 203:{f.Push(JValue.I(1));f.Pc=204;continue;}
case 204:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",208);}
case 208:{f.StackOp("pop");f.Pc=209;continue;}
case 209:{f.Push(f.Locals[6]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",214);}
case 214:{return rt.Call(f,"forge/card/CardType","isPlane","()Z","invokevirtual",217);}
case 217:{f.Pc=f.Pop().Int!=0?239:220;continue;}
case 220:{f.Push(f.Locals[6]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",225);}
case 225:{return rt.Call(f,"forge/card/CardType","isPhenomenon","()Z","invokevirtual",228);}
case 228:{f.Pc=f.Pop().Int!=0?239:231;continue;}
case 231:{f.Push(f.Locals[5]);f.Pc=233;continue;}
case 233:{f.Push(JValue.R(rt.String(".full")));f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",238);}
case 238:{f.StackOp("pop");f.Pc=239;continue;}
case 239:{f.Push(f.Locals[3]);f.Pc=240;continue;}
case 240:{f.Pc=f.Pop().Int==0?268:243;continue;}
case 243:{f.Push(f.Locals[5]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String(".jpg")));f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",250);}
case 250:{f.StackOp("pop");f.Pc=251;continue;}
case 251:{f.Push(f.Locals[5]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",256);}
case 256:{f.Push(JValue.R(rt.String("\\s")));f.Pc=258;continue;}
case 258:{f.Push(JValue.R(rt.String("%20")));f.Pc=260;continue;}
case 260:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",263);}
case 263:{f.Locals[12]=f.Pop();f.Pc=265;continue;}
case 265:{f.Pc=275;continue;}
case 268:{f.Push(f.Locals[5]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",273);}
case 273:{f.Locals[12]=f.Pop();f.Pc=275;continue;}
case 275:{f.Push(f.Locals[2]);f.Pc=276;continue;}
case 276:{f.Pc=f.Pop().Int==0?339:279;continue;}
case 279:{f.Push(f.Locals[3]);f.Pc=280;continue;}
case 280:{f.Pc=f.Pop().Int==0?297:283;continue;}
case 283:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",286);}
case 286:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",289);}
case 289:{f.Push(f.Locals[7]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/card/CardEdition$Collection","getCode2ByCode","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",294);}
case 294:{f.Pc=302;continue;}
case 297:{f.Push(f.Locals[7]);f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/ImageKeys","getSetFolder","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",302);}
case 302:{f.Locals[13]=f.Pop();f.Pc=304;continue;}
case 304:{f.Push(f.Locals[13]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",309);}
case 309:{f.Pc=f.Pop().Int==0?316:312;continue;}
case 312:{f.Push(f.Locals[7]);f.Pc=314;continue;}
case 314:{f.Locals[13]=f.Pop();f.Pc=316;continue;}
case 316:{f.Push(JValue.I(3));f.Pc=317;continue;}
case 317:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=320;continue;}
case 320:{f.StackOp("dup");f.Pc=321;continue;}
case 321:{f.Push(JValue.I(0));f.Pc=322;continue;}
case 322:{f.Push(f.Locals[13]);f.Pc=324;continue;}
case 324:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=325;continue;}
case 325:{f.StackOp("dup");f.Pc=326;continue;}
case 326:{f.Push(JValue.I(1));f.Pc=327;continue;}
case 327:{f.Push(JValue.R(rt.String("/")));f.Pc=329;continue;}
case 329:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=330;continue;}
case 330:{f.StackOp("dup");f.Pc=331;continue;}
case 331:{f.Push(JValue.I(2));f.Pc=332;continue;}
case 332:{f.Push(f.Locals[12]);f.Pc=334;continue;}
case 334:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",338);}
case 338:{return JStep.Return(f.Pop());}
case 339:{f.Push(f.Locals[12]);f.Pc=341;continue;}
case 341:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11795(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/IPaperCard","getRules","()Lforge/card/CardRules;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("back")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?80:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/item/IPaperCard","hasBackFace","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?78:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Reference==null?42:32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",36);}
case 36:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",41);}
case 41:{return JStep.Return(f.Pop());}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/card/CardRules","getMeldWith","()Ljava/lang/String;","invokevirtual",46);}
case 46:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int!=0?76:52;continue;}
case 52:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",55);}
case 55:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",58);}
case 58:{f.Locals[3]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/card/CardRules","getMeldWith","()Ljava/lang/String;","invokevirtual",64);}
case 64:{return rt.Call(f,"forge/card/CardDb","getRulesOrElseUnsupported","(Ljava/lang/String;)Lforge/card/CardRules;","invokevirtual",67);}
case 67:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",70);}
case 70:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",75);}
case 75:{return JStep.Return(f.Pop());}
case 76:{f.Push(JValue.R(null));f.Pc=77;continue;}
case 77:{return JStep.Return(f.Pop());}
case 78:{f.Push(JValue.R(null));f.Pc=79;continue;}
case 79:{return JStep.Return(f.Pop());}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.String("white")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int==0?107:90;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/card/CardRules","getWSpecialize","()Lforge/card/ICardFace;","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Reference==null?302:97;continue;}
case 97:{f.Push(f.Locals[2]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/card/CardRules","getWSpecialize","()Lforge/card/ICardFace;","invokevirtual",101);}
case 101:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",106);}
case 106:{return JStep.Return(f.Pop());}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("blue")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?134:117;continue;}
case 117:{f.Push(f.Locals[2]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/card/CardRules","getUSpecialize","()Lforge/card/ICardFace;","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Reference==null?302:124;continue;}
case 124:{f.Push(f.Locals[2]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/card/CardRules","getUSpecialize","()Lforge/card/ICardFace;","invokevirtual",128);}
case 128:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",133);}
case 133:{return JStep.Return(f.Pop());}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.String("black")));f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",141);}
case 141:{f.Pc=f.Pop().Int==0?161:144;continue;}
case 144:{f.Push(f.Locals[2]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/card/CardRules","getBSpecialize","()Lforge/card/ICardFace;","invokevirtual",148);}
case 148:{f.Pc=f.Pop().Reference==null?302:151;continue;}
case 151:{f.Push(f.Locals[2]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/card/CardRules","getBSpecialize","()Lforge/card/ICardFace;","invokevirtual",155);}
case 155:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",160);}
case 160:{return JStep.Return(f.Pop());}
case 161:{f.Push(f.Locals[1]);f.Pc=162;continue;}
case 162:{f.Push(JValue.R(rt.String("red")));f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",168);}
case 168:{f.Pc=f.Pop().Int==0?188:171;continue;}
case 171:{f.Push(f.Locals[2]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/card/CardRules","getRSpecialize","()Lforge/card/ICardFace;","invokevirtual",175);}
case 175:{f.Pc=f.Pop().Reference==null?302:178;continue;}
case 178:{f.Push(f.Locals[2]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/card/CardRules","getRSpecialize","()Lforge/card/ICardFace;","invokevirtual",182);}
case 182:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",187);}
case 187:{return JStep.Return(f.Pop());}
case 188:{f.Push(f.Locals[1]);f.Pc=189;continue;}
case 189:{f.Push(JValue.R(rt.String("green")));f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",195);}
case 195:{f.Pc=f.Pop().Int==0?215:198;continue;}
case 198:{f.Push(f.Locals[2]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/card/CardRules","getGSpecialize","()Lforge/card/ICardFace;","invokevirtual",202);}
case 202:{f.Pc=f.Pop().Reference==null?302:205;continue;}
case 205:{f.Push(f.Locals[2]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/card/CardRules","getGSpecialize","()Lforge/card/ICardFace;","invokevirtual",209);}
case 209:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",214);}
case 214:{return JStep.Return(f.Pop());}
case 215:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Split","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Split","Lforge/card/CardSplitType;"));f.Pc=218;continue;}
case 218:{f.Push(f.Locals[0]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/item/IPaperCard","getRules","()Lforge/card/CardRules;","invokeinterface",224);}
case 224:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",227);}
case 227:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?254:230;continue;}
case 230:{f.Push(f.Locals[2]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",234);}
case 234:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",239);}
case 239:{f.Push(f.Locals[2]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",243);}
case 243:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",248);}
case 248:{return rt.DynamicCall(f,"forge/util/ImageUtil:11795:248:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",253);}
case 253:{return JStep.Return(f.Pop());}
case 254:{f.Push(f.Locals[0]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/item/IPaperCard","hasFlavorName","()Z","invokeinterface",260);}
case 260:{f.Pc=f.Pop().Int==0?270:263;continue;}
case 263:{f.Push(f.Locals[0]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/item/IPaperCard","getDisplayName","()Ljava/lang/String;","invokeinterface",269);}
case 269:{return JStep.Return(f.Pop());}
case 270:{f.Push(JValue.R(rt.String("")));f.Pc=272;continue;}
case 272:{f.Push(f.Locals[0]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/item/IPaperCard","getFunctionalVariant","()Ljava/lang/String;","invokeinterface",278);}
case 278:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",281);}
case 281:{f.Pc=f.Pop().Int!=0?302:284;continue;}
case 284:{f.Push(f.Locals[0]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/item/IPaperCard","getName","()Ljava/lang/String;","invokeinterface",290);}
case 290:{f.Push(f.Locals[0]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/item/IPaperCard","getFunctionalVariant","()Ljava/lang/String;","invokeinterface",296);}
case 296:{return rt.DynamicCall(f,"forge/util/ImageUtil:11795:296:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",301);}
case 301:{return JStep.Return(f.Pop());}
case 302:{f.Push(f.Locals[0]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/item/IPaperCard","getName","()Ljava/lang/String;","invokeinterface",308);}
case 308:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11796(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/ImageUtil","getImageRelativePath","(Lforge/item/IPaperCard;Ljava/lang/String;ZZ)Ljava/lang/String;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11797(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/ImageUtil","getImageRelativePath","(Lforge/item/IPaperCard;Ljava/lang/String;ZZ)Ljava/lang/String;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11798(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("^F\\d+[a-z]?")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",6);}
case 6:{f.Locals[5]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?25:12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int!=0?25:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Locals[6]=f.Pop();f.Pc=22;continue;}
case 22:{f.Pc=34;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",29);}
case 29:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Locals[6]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",38);}
case 38:{f.Locals[7]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[7]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("OHOP")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?72:51;continue;}
case 51:{f.Push(JValue.R(rt.String("ohop")));f.Pc=54;continue;}
case 54:{f.Locals[6]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[7]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("OHOP")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",64);}
case 64:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",67);}
case 67:{f.Locals[7]=f.Pop();f.Pc=69;continue;}
case 69:{f.Pc=133;continue;}
case 72:{f.Push(f.Locals[7]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("OPCA")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int==0?104:83;continue;}
case 83:{f.Push(JValue.R(rt.String("opca")));f.Pc=86;continue;}
case 86:{f.Locals[6]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[7]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("OPCA")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",96);}
case 96:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",99);}
case 99:{f.Locals[7]=f.Pop();f.Pc=101;continue;}
case 101:{f.Pc=133;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("OPC2")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Int==0?133:115;continue;}
case 115:{f.Push(JValue.R(rt.String("opc2")));f.Pc=118;continue;}
case 118:{f.Locals[6]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[7]);f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("OPC2")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",128);}
case 128:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",131);}
case 131:{f.Locals[7]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[5]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[7]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",140);}
case 140:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",143);}
case 143:{f.Pc=f.Pop().Int==0?154:146;continue;}
case 146:{f.Push(f.Locals[7]);f.Pc=148;continue;}
case 148:{f.Push(JValue.I(1));f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",152);}
case 152:{f.Locals[7]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[4]);f.Pc=156;continue;}
case 156:{f.Pc=f.Pop().Int==0?165:159;continue;}
case 159:{f.Push(JValue.R(rt.String("art_crop")));f.Pc=162;continue;}
case 162:{f.Pc=168;continue;}
case 165:{f.Push(JValue.R(rt.String("normal")));f.Pc=168;continue;}
case 168:{f.Locals[8]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(JValue.R(rt.String("")));f.Pc=172;continue;}
case 172:{f.Locals[9]=f.Pop();f.Pc=174;continue;}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",178);}
case 178:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",181);}
case 181:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Meld","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Meld","Lforge/card/CardSplitType;"));f.Pc=184;continue;}
case 184:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?222:187;continue;}
case 187:{f.Push(f.Locals[1]);f.Pc=188;continue;}
case 188:{f.Push(JValue.R(rt.String("back")));f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",193);}
case 193:{f.Pc=f.Pop().Int==0?214:196;continue;}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/item/PaperCard","getMeldBaseCard","()Lforge/item/PaperCard;","invokevirtual",200);}
case 200:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",203);}
case 203:{f.Push(JValue.R(rt.String("(\\d+)([sp]?)")));f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.String("$1b$2")));f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",212);}
case 212:{f.Locals[7]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(JValue.R(rt.String("&face=front")));f.Pc=217;continue;}
case 217:{f.Locals[9]=f.Pop();f.Pc=219;continue;}
case 219:{f.Pc=303;continue;}
case 222:{f.Push(f.Locals[0]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",226);}
case 226:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",229);}
case 229:{f.Pc=f.Pop().Reference==null?268:232;continue;}
case 232:{f.Push(f.Locals[1]);f.Pc=233;continue;}
case 233:{f.Push(JValue.R(rt.String("back")));f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",238);}
case 238:{f.Pc=f.Pop().Int==0?260:241;continue;}
case 241:{f.Push(f.Locals[0]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",245);}
case 245:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",248);}
case 248:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Flip","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Flip","Lforge/card/CardSplitType;"));f.Pc=251;continue;}
case 251:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?260:254;continue;}
case 254:{f.Push(JValue.R(rt.String("&face=back")));f.Pc=257;continue;}
case 257:{f.Pc=263;continue;}
case 260:{f.Push(JValue.R(rt.String("&face=front")));f.Pc=263;continue;}
case 263:{f.Locals[9]=f.Pop();f.Pc=265;continue;}
case 265:{f.Pc=303;continue;}
case 268:{f.Push(f.Locals[0]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",272);}
case 272:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",275);}
case 275:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Specialize","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Specialize","Lforge/card/CardSplitType;"));f.Pc=278;continue;}
case 278:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?303:281;continue;}
case 281:{f.Push(f.Locals[1]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/util/ImageUtil","specFaceToCollectorSuffix","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",285);}
case 285:{f.Locals[10]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[10]);f.Pc=289;continue;}
case 289:{f.Pc=f.Pop().Reference==null?303:292;continue;}
case 292:{f.Push(f.Locals[7]);f.Pc=294;continue;}
case 294:{f.Push(f.Locals[10]);f.Pc=296;continue;}
case 296:{return rt.DynamicCall(f,"forge/util/ImageUtil:11798:296:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",301);}
case 301:{f.Locals[7]=f.Pop();f.Pc=303;continue;}
case 303:{f.Push(f.Locals[7]);f.Pc=305;continue;}
case 305:{f.Push(JValue.R(rt.String("\u2607")));f.Pc=308;continue;}
case 308:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",311);}
case 311:{f.Pc=f.Pop().Int==0?334:314;continue;}
case 314:{f.Push(JValue.R(rt.String("&face=back")));f.Pc=317;continue;}
case 317:{f.Locals[9]=f.Pop();f.Pc=319;continue;}
case 319:{f.Push(f.Locals[7]);f.Pc=321;continue;}
case 321:{f.Push(JValue.I(0));f.Pc=322;continue;}
case 322:{f.Push(f.Locals[7]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",327);}
case 327:{f.Push(JValue.I(1));f.Pc=328;continue;}
case 328:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=329;continue;}
case 329:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",332);}
case 332:{f.Locals[7]=f.Pop();f.Pc=334;continue;}
case 334:{f.Push(JValue.R(rt.String("%s/%s/%s?format=image&version=%s%s")));f.Pc=337;continue;}
case 337:{f.Push(JValue.I(5));f.Pc=338;continue;}
case 338:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=341;continue;}
case 341:{f.StackOp("dup");f.Pc=342;continue;}
case 342:{f.Push(JValue.I(0));f.Pc=343;continue;}
case 343:{f.Push(f.Locals[6]);f.Pc=345;continue;}
case 345:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=346;continue;}
case 346:{f.StackOp("dup");f.Pc=347;continue;}
case 347:{f.Push(JValue.I(1));f.Pc=348;continue;}
case 348:{f.Push(f.Locals[7]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/util/ImageUtil","encodeUtf8","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",353);}
case 353:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=354;continue;}
case 354:{f.StackOp("dup");f.Pc=355;continue;}
case 355:{f.Push(JValue.I(2));f.Pc=356;continue;}
case 356:{f.Push(f.Locals[3]);f.Pc=357;continue;}
case 357:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=358;continue;}
case 358:{f.StackOp("dup");f.Pc=359;continue;}
case 359:{f.Push(JValue.I(3));f.Pc=360;continue;}
case 360:{f.Push(f.Locals[8]);f.Pc=362;continue;}
case 362:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=363;continue;}
case 363:{f.StackOp("dup");f.Pc=364;continue;}
case 364:{f.Push(JValue.I(4));f.Pc=365;continue;}
case 365:{f.Push(f.Locals[9]);f.Pc=367;continue;}
case 367:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=368;continue;}
case 368:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",371);}
case 371:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11799(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("normal")));f.Pc=3;continue;}
case 3:{f.Locals[4]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int!=0?31:12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("back")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?27:21;continue;}
case 21:{f.Push(JValue.R(rt.String("&face=back")));f.Pc=24;continue;}
case 24:{f.Pc=30;continue;}
case 27:{f.Push(JValue.R(rt.String("&face=front")));f.Pc=30;continue;}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("\u2607")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?57:41;continue;}
case 41:{f.Push(JValue.R(rt.String("&face=back")));f.Pc=44;continue;}
case 44:{f.Locals[3]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",51);}
case 51:{f.Push(JValue.I(1));f.Pc=52;continue;}
case 52:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",56);}
case 56:{f.Locals[0]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("%s/%s/%s?format=image&version=%s%s")));f.Pc=60;continue;}
case 60:{f.Push(JValue.I(5));f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=64;continue;}
case 64:{f.StackOp("dup");f.Pc=65;continue;}
case 65:{f.Push(JValue.I(0));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.I(1));f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/util/ImageUtil","encodeUtf8","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",74);}
case 74:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{f.Push(JValue.I(2));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=79;continue;}
case 79:{f.StackOp("dup");f.Pc=80;continue;}
case 80:{f.Push(JValue.I(3));f.Pc=81;continue;}
case 81:{f.Push(f.Locals[4]);f.Pc=83;continue;}
case 83:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{f.Push(JValue.I(4));f.Pc=86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",91);}
case 91:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11800(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/MagicColor$Color","fromName","(Ljava/lang/String;)Lforge/card/MagicColor$Color;","invokestatic",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?11:9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/card/MagicColor$Color","getShortName","()Ljava/lang/String;","invokevirtual",15);}
case 15:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11801(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("UTF-8")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/net/URLEncoder","encode","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
case 8:{f.Locals[1]=f.Pop();f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("UTF-8 encoding not supported on this device.")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11802(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","stripAccents","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",4);}
case 4:{f.Locals[0]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",20);}
case 20:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?65:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",28);}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(34));f.Pc=32;continue;}
case 32:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?59:35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(JValue.I(47));f.Pc=38;continue;}
case 38:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?59:41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(58));f.Pc=44;continue;}
case 44:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?59:47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(JValue.I(63));f.Pc=50;continue;}
case 50:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?59:53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",58);}
case 58:{f.StackOp("pop");f.Pc=59;continue;}
case 59:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=62;continue;}
case 62:{f.Pc=15;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",69);}
case 69:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
