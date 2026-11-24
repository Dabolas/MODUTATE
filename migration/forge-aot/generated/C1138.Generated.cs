// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1138{
internal static JClass Build(){var c=new JClass("forge/util/Localizer","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("instance","Lforge/util/Localizer;",true,JValue.Default("Lforge/util/Localizer;"),null));
c.Add(new JField("observers","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("locale","Ljava/util/Locale;",false,JValue.Default("Ljava/util/Locale;"),null));
c.Add(new JField("resourceBundle","Ljava/util/ResourceBundle;",false,JValue.Default("Ljava/util/ResourceBundle;"),null));
c.Add(new JField("englishBundle","Ljava/util/ResourceBundle;",false,JValue.Default("Ljava/util/ResourceBundle;"),null));
c.Add(new JField("adventureBundle","Ljava/util/ResourceBundle;",false,JValue.Default("Ljava/util/ResourceBundle;"),null));
c.Add(new JField("currentLanguageRegionID","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("silent","Z",false,JValue.Default("Z"),null));
c.Add(new JField("english","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(11923,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;",9,2,2,new JHandler[]{new JHandler(11,23,26,""),new JHandler(26,29,26,"")},M11923));
c.Add(new JMethod(11924,"forge/util/Localizer","setEnglish","(Z)V",1,2,2,new JHandler[]{},M11924));
c.Add(new JMethod(11925,"forge/util/Localizer","<init>","()V",2,1,3,new JHandler[]{},M11925));
c.Add(new JMethod(11926,"forge/util/Localizer","initialize","(Ljava/lang/String;Ljava/lang/String;)V",1,3,3,new JHandler[]{},M11926));
c.Add(new JMethod(11927,"forge/util/Localizer","convert","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1,4,4,new JHandler[]{},M11927));
c.Add(new JMethod(11928,"forge/util/Localizer","charset","(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;",1,10,6,new JHandler[]{new JHandler(44,74,78,"java/io/UnsupportedEncodingException")},M11928));
c.Add(new JMethod(11929,"forge/util/Localizer","getMessageorUseDefault","(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;",129,5,3,new JHandler[]{new JHandler(0,24,28,"java/lang/Exception"),new JHandler(25,27,28,"java/lang/Exception")},M11929));
c.Add(new JMethod(11930,"forge/util/Localizer","getEnglishMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;",129,3,4,new JHandler[]{},M11930));
c.Add(new JMethod(11931,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;",129,3,4,new JHandler[]{},M11931));
c.Add(new JMethod(11932,"forge/util/Localizer","getMessage","(ZLjava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;",129,14,6,new JHandler[]{new JHandler(6,61,64,"java/lang/IllegalArgumentException"),new JHandler(6,61,64,"java/util/MissingResourceException"),new JHandler(127,159,162,"java/lang/IllegalArgumentException"),new JHandler(127,159,162,"java/util/MissingResourceException"),new JHandler(280,300,303,"java/io/UnsupportedEncodingException"),new JHandler(340,364,367,"java/io/UnsupportedEncodingException")},M11932));
c.Add(new JMethod(11933,"forge/util/Localizer","setLanguage","(Ljava/lang/String;Ljava/lang/String;)V",1,9,7,new JHandler[]{new JHandler(60,77,80,"java/net/MalformedURLException"),new JHandler(103,148,151,"java/lang/NullPointerException"),new JHandler(103,148,151,"java/util/MissingResourceException")},M11933));
c.Add(new JMethod(11934,"forge/util/Localizer","loadAdventureBundle","(Ljava/lang/String;)V",1,4,6,new JHandler[]{new JHandler(24,76,79,"java/net/MalformedURLException"),new JHandler(24,76,79,"java/lang/NullPointerException"),new JHandler(24,76,79,"java/util/MissingResourceException")},M11934));
c.Add(new JMethod(11935,"forge/util/Localizer","lookup","(Ljava/lang/String;Z)Ljava/lang/String;",2,4,2,new JHandler[]{new JHandler(11,19,20,"java/util/MissingResourceException")},M11935));
c.Add(new JMethod(11936,"forge/util/Localizer","registerObserver","(Lforge/util/LocalizationChangeObserver;)V",1,2,2,new JHandler[]{},M11936));
c.Add(new JMethod(11937,"forge/util/Localizer","notifyObservers","()V",2,3,1,new JHandler[]{},M11937));
}

internal static JStep M11923(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/Localizer","instance","Lforge/util/Localizer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Localizer","instance","Lforge/util/Localizer;"));f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference!=null?31:6;continue;}
case 6:{f.Push(JValue.R(rt.ClassObject("forge/util/Localizer")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Locals[0]=f.Pop();f.Pc=10;continue;}
case 10:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=11;continue;}
case 11:{if(!rt.EnsureInitialized(f,"forge/util/Localizer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/Localizer")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/util/Localizer","<init>","()V","invokespecial",18);}
case 18:{if(!rt.StaticReady(f,"forge/util/Localizer","instance","Lforge/util/Localizer;"))return JStep.Continue;rt.PutStatic("forge/util/Localizer","instance","Lforge/util/Localizer;",f.Pop());f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=23;continue;}
case 23:{f.Pc=31;continue;}
case 26:{f.Locals[1]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 31:{if(!rt.StaticReady(f,"forge/util/Localizer","instance","Lforge/util/Localizer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Localizer","instance","Lforge/util/Localizer;"));f.Pc=34;continue;}
case 34:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11924(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/Localizer","english","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11925(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/Localizer","observers","Ljava/util/List;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/Localizer","silent","Z",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/Localizer","english","Z",value);f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11926(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/Localizer","setLanguage","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11927(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/String"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/String")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","getBytes","(Ljava/lang/String;)[B","invokevirtual",9);}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/String","<init>","([BLjava/lang/String;)V","invokespecial",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11928(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"java/nio/charset/StandardCharsets","UTF_8","Ljava/nio/charset/Charset;"))return JStep.Continue;f.Push(rt.GetStatic("java/nio/charset/StandardCharsets","UTF_8","Ljava/nio/charset/Charset;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/nio/charset/Charset","name","()Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=13;continue;}
case 13:{f.Locals[5]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Locals[6]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[6]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[5]);f.Pc=22;continue;}
case 22:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?86:25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[6]);f.Pc=29;continue;}
case 29:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=30;continue;}
case 30:{f.Locals[7]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[7]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/nio/charset/Charset","forName","(Ljava/lang/String;)Ljava/nio/charset/Charset;","invokestatic",37);}
case 37:{f.Locals[8]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[8]);f.Pc=41;continue;}
case 41:{f.Pc=f.Pop().Reference==null?80:44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[8]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/nio/charset/Charset","name","()Ljava/lang/String;","invokevirtual",53);}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/util/Localizer","convert","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",57);}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[8]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/nio/charset/Charset","name","()Ljava/lang/String;","invokevirtual",63);}
case 63:{return rt.Call(f,"forge/util/Localizer","convert","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",66);}
case 66:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?75:72;continue;}
case 72:{f.Push(f.Locals[7]);f.Pc=74;continue;}
case 74:{return JStep.Return(f.Pop());}
case 75:{f.Pc=80;continue;}
case 78:{f.Locals[9]=f.Pop();f.Pc=80;continue;}
case 80:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=83;continue;}
case 83:{f.Pc=18;continue;}
case 86:{if(!rt.StaticReady(f,"java/nio/charset/StandardCharsets","UTF_8","Ljava/nio/charset/Charset;"))return JStep.Continue;f.Push(rt.GetStatic("java/nio/charset/StandardCharsets","UTF_8","Ljava/nio/charset/Charset;"));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/nio/charset/Charset","name","()Ljava/lang/String;","invokevirtual",92);}
case 92:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11929(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/Localizer","silent","Z",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("INVALID PROPERTY:")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?25:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{return JStep.Return(f.Pop());}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11930(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/Localizer","getMessage","(ZLjava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11931(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/Localizer","getMessage","(ZLjava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11932(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","english","Z"));f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Int!=0?19:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Int==0?23:19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/util/Localizer","lookup","(Ljava/lang/String;Z)Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Locals[5]=f.Pop();f.Pc=29;continue;}
case 29:{if(!rt.EnsureInitialized(f,"java/text/MessageFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/text/MessageFormat")));f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","english","Z"));f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Int!=0?46:42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Pc=f.Pop().Int==0?52:46;continue;}
case 46:{if(!rt.StaticReady(f,"java/util/Locale","ENGLISH","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ENGLISH","Ljava/util/Locale;"));f.Pc=49;continue;}
case 49:{f.Pc=56;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","locale","Ljava/util/Locale;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/text/MessageFormat","<init>","(Ljava/lang/String;Ljava/util/Locale;)V","invokespecial",59);}
case 59:{f.Locals[4]=f.Pop();f.Pc=61;continue;}
case 61:{f.Pc=78;continue;}
case 64:{f.Locals[6]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","silent","Z"));f.Pc=70;continue;}
case 70:{f.Pc=f.Pop().Int!=0?78:73;continue;}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/RuntimeException","printStackTrace","()V","invokevirtual",78);}
case 78:{f.Push(f.Locals[4]);f.Pc=80;continue;}
case 80:{f.Pc=f.Pop().Reference!=null?183:83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","silent","Z"));f.Pc=87;continue;}
case 87:{f.Pc=f.Pop().Int!=0?109:90;continue;}
case 90:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","locale","Ljava/util/Locale;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",101);}
case 101:{return rt.DynamicCall(f,"forge/util/Localizer:11932:101:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",106);}
case 106:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",109);}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","english","Z"));f.Pc=113;continue;}
case 113:{f.Pc=f.Pop().Int!=0?120:116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{f.Pc=f.Pop().Int==0?127:120;continue;}
case 120:{f.Push(f.Locals[2]);f.Pc=121;continue;}
case 121:{return rt.DynamicCall(f,"forge/util/Localizer:11932:121:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",126);}
case 126:{return JStep.Return(f.Pop());}
case 127:{if(!rt.EnsureInitialized(f,"java/text/MessageFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/text/MessageFormat")));f.Pc=130;continue;}
case 130:{f.StackOp("dup");f.Pc=131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","englishBundle","Ljava/util/ResourceBundle;"));f.Pc=135;continue;}
case 135:{f.Push(f.Locals[2]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/ResourceBundle","getString","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",139);}
case 139:{if(!rt.StaticReady(f,"java/util/Locale","ENGLISH","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ENGLISH","Ljava/util/Locale;"));f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/text/MessageFormat","<init>","(Ljava/lang/String;Ljava/util/Locale;)V","invokespecial",145);}
case 145:{f.Locals[4]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(JValue.I(1));f.Pc=148;continue;}
case 148:{f.Locals[1]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","englishBundle","Ljava/util/ResourceBundle;"));f.Pc=153;continue;}
case 153:{f.Push(f.Locals[2]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/util/ResourceBundle","getString","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",157);}
case 157:{f.Locals[5]=f.Pop();f.Pc=159;continue;}
case 159:{f.Pc=183;continue;}
case 162:{f.Locals[6]=f.Pop();f.Pc=164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","silent","Z"));f.Pc=168;continue;}
case 168:{f.Pc=f.Pop().Int!=0?176:171;continue;}
case 171:{f.Push(f.Locals[6]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/lang/RuntimeException","printStackTrace","()V","invokevirtual",176);}
case 176:{f.Push(f.Locals[2]);f.Pc=177;continue;}
case 177:{return rt.DynamicCall(f,"forge/util/Localizer:11932:177:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",182);}
case 182:{return JStep.Return(f.Pop());}
case 183:{f.Push(f.Locals[0]);f.Pc=184;continue;}
case 184:{f.Push(JValue.I(0));f.Pc=185;continue;}
case 185:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/Localizer","silent","Z",value);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[4]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[0]);f.Pc=191;continue;}
case 191:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","english","Z"));f.Pc=194;continue;}
case 194:{f.Pc=f.Pop().Int!=0?201:197;continue;}
case 197:{f.Push(f.Locals[1]);f.Pc=198;continue;}
case 198:{f.Pc=f.Pop().Int==0?207:201;continue;}
case 201:{if(!rt.StaticReady(f,"java/util/Locale","ENGLISH","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ENGLISH","Ljava/util/Locale;"));f.Pc=204;continue;}
case 204:{f.Pc=211;continue;}
case 207:{f.Push(f.Locals[0]);f.Pc=208;continue;}
case 208:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","locale","Ljava/util/Locale;"));f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/text/MessageFormat","setLocale","(Ljava/util/Locale;)V","invokevirtual",214);}
case 214:{f.Push(JValue.R(rt.String("CHAR ENCODING ERROR")));f.Pc=216;continue;}
case 216:{f.Locals[6]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(JValue.I(2));f.Pc=219;continue;}
case 219:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=222;continue;}
case 222:{f.StackOp("dup");f.Pc=223;continue;}
case 223:{f.Push(JValue.I(0));f.Pc=224;continue;}
case 224:{f.Push(JValue.R(rt.String("ISO-8859-1")));f.Pc=226;continue;}
case 226:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=227;continue;}
case 227:{f.StackOp("dup");f.Pc=228;continue;}
case 228:{f.Push(JValue.I(1));f.Pc=229;continue;}
case 229:{f.Push(JValue.R(rt.String("UTF-8")));f.Pc=231;continue;}
case 231:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=232;continue;}
case 232:{f.Locals[7]=f.Pop();f.Pc=234;continue;}
case 234:{f.Push(f.Locals[0]);f.Pc=235;continue;}
case 235:{f.Push(f.Locals[5]);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[7]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/util/Localizer","charset","(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;","invokevirtual",242);}
case 242:{f.Locals[8]=f.Pop();f.Pc=244;continue;}
case 244:{f.Push(f.Locals[3]);f.Pc=245;continue;}
case 245:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=246;continue;}
case 246:{f.Locals[9]=f.Pop();f.Pc=248;continue;}
case 248:{f.Push(f.Locals[9]);f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=253;continue;}
case 253:{f.Locals[10]=f.Pop();f.Pc=255;continue;}
case 255:{f.Push(JValue.I(0));f.Pc=256;continue;}
case 256:{f.Locals[11]=f.Pop();f.Pc=258;continue;}
case 258:{f.Push(f.Locals[11]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[9]);f.Pc=262;continue;}
case 262:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?340:265;continue;}
case 265:{f.Push(f.Locals[0]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[3]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[11]);f.Pc=269;continue;}
case 269:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",273);}
case 273:{f.Push(f.Locals[7]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/util/Localizer","charset","(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;","invokevirtual",278);}
case 278:{f.Locals[12]=f.Pop();f.Pc=280;continue;}
case 280:{f.Push(f.Locals[10]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[11]);f.Pc=284;continue;}
case 284:{f.Push(f.Locals[0]);f.Pc=285;continue;}
case 285:{f.Push(f.Locals[3]);f.Pc=286;continue;}
case 286:{f.Push(f.Locals[11]);f.Pc=288;continue;}
case 288:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=289;continue;}
case 289:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",292);}
case 292:{f.Push(f.Locals[12]);f.Pc=294;continue;}
case 294:{f.Push(f.Locals[8]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"forge/util/Localizer","convert","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",299);}
case 299:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=300;continue;}
case 300:{f.Pc=334;continue;}
case 303:{f.Locals[13]=f.Pop();f.Pc=305;continue;}
case 305:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=308;continue;}
case 308:{f.Push(f.Locals[3]);f.Pc=309;continue;}
case 309:{f.Push(f.Locals[11]);f.Pc=311;continue;}
case 311:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=312;continue;}
case 312:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",315);}
case 315:{f.Push(f.Locals[12]);f.Pc=317;continue;}
case 317:{f.Push(f.Locals[8]);f.Pc=319;continue;}
case 319:{return rt.DynamicCall(f,"forge/util/Localizer:11932:319:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",324);}
case 324:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",327);}
case 327:{f.Push(f.Locals[2]);f.Pc=328;continue;}
case 328:{return rt.DynamicCall(f,"forge/util/Localizer:11932:328:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",333);}
case 333:{return JStep.Return(f.Pop());}
case 334:{f.Locals[11]=JValue.I(unchecked(f.Locals[11].Int+(1)));f.Pc=337;continue;}
case 337:{f.Pc=258;continue;}
case 340:{if(!rt.EnsureInitialized(f,"java/lang/String"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/String")));f.Pc=343;continue;}
case 343:{f.StackOp("dup");f.Pc=344;continue;}
case 344:{f.Push(f.Locals[4]);f.Pc=346;continue;}
case 346:{f.Push(f.Locals[10]);f.Pc=348;continue;}
case 348:{return rt.Call(f,"java/text/MessageFormat","format","(Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",351);}
case 351:{f.Push(f.Locals[8]);f.Pc=353;continue;}
case 353:{return rt.Call(f,"java/lang/String","getBytes","(Ljava/lang/String;)[B","invokevirtual",356);}
case 356:{if(!rt.StaticReady(f,"java/nio/charset/StandardCharsets","UTF_8","Ljava/nio/charset/Charset;"))return JStep.Continue;f.Push(rt.GetStatic("java/nio/charset/StandardCharsets","UTF_8","Ljava/nio/charset/Charset;"));f.Pc=359;continue;}
case 359:{return rt.Call(f,"java/lang/String","<init>","([BLjava/nio/charset/Charset;)V","invokespecial",362);}
case 362:{f.Locals[6]=f.Pop();f.Pc=364;continue;}
case 364:{f.Pc=369;continue;}
case 367:{f.Locals[11]=f.Pop();f.Pc=369;continue;}
case 369:{f.Push(f.Locals[6]);f.Pc=371;continue;}
case 371:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11933(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("-")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","locale","Ljava/util/Locale;"));f.Pc=11;continue;}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{if(!rt.EnsureInitialized(f,"java/util/Locale"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Locale")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Locale","<init>","(Ljava/lang/String;Ljava/lang/String;)V","invokespecial",27);}
case 27:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/Localizer","locale","Ljava/util/Locale;",value);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Reference==null?47:35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","locale","Ljava/util/Locale;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Locale","equals","(Ljava/lang/Object;)Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int!=0?193:47;continue;}
case 47:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=50;continue;}
case 50:{f.StackOp("dup");f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",55);}
case 55:{f.Locals[5]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(JValue.R(null));f.Pc=58;continue;}
case 58:{f.Locals[6]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.NewArray("Ljava/net/URL;",f.Pop().Int)));f.Pc=64;continue;}
case 64:{f.StackOp("dup");f.Pc=65;continue;}
case 65:{f.Push(JValue.I(0));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/io/File","toURI","()Ljava/net/URI;","invokevirtual",71);}
case 71:{return rt.Call(f,"java/net/URI","toURL","()Ljava/net/URL;","invokevirtual",74);}
case 74:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=75;continue;}
case 75:{f.Locals[6]=f.Pop();f.Pc=77;continue;}
case 77:{f.Pc=87;continue;}
case 80:{f.Locals[7]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[7]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/net/MalformedURLException","printStackTrace","()V","invokevirtual",87);}
case 87:{if(!rt.EnsureInitialized(f,"java/net/URLClassLoader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/net/URLClassLoader")));f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(f.Locals[6]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/net/URLClassLoader","<init>","([Ljava/net/URL;)V","invokespecial",96);}
case 96:{f.Locals[7]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/Localizer","currentLanguageRegionID","Ljava/lang/String;",value);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("en-US")));f.Pc=106;continue;}
case 106:{if(!rt.EnsureInitialized(f,"java/util/Locale"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Locale")));f.Pc=109;continue;}
case 109:{f.StackOp("dup");f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("en")));f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("US")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/Locale","<init>","(Ljava/lang/String;Ljava/lang/String;)V","invokespecial",117);}
case 117:{f.Push(f.Locals[7]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/ResourceBundle","getBundle","(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/ClassLoader;)Ljava/util/ResourceBundle;","invokestatic",122);}
case 122:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/Localizer","englishBundle","Ljava/util/ResourceBundle;",value);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[1]);f.Pc=127;continue;}
case 127:{if(!rt.EnsureInitialized(f,"java/util/Locale"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Locale")));f.Pc=130;continue;}
case 130:{f.StackOp("dup");f.Pc=131;continue;}
case 131:{f.Push(f.Locals[3]);f.Pc=132;continue;}
case 132:{f.Push(JValue.I(0));f.Pc=133;continue;}
case 133:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=134;continue;}
case 134:{f.Push(f.Locals[3]);f.Pc=135;continue;}
case 135:{f.Push(JValue.I(1));f.Pc=136;continue;}
case 136:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/Locale","<init>","(Ljava/lang/String;Ljava/lang/String;)V","invokespecial",140);}
case 140:{f.Push(f.Locals[7]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/ResourceBundle","getBundle","(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/ClassLoader;)Ljava/util/ResourceBundle;","invokestatic",145);}
case 145:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/Localizer","resourceBundle","Ljava/util/ResourceBundle;",value);f.Pc=148;continue;}
case 148:{f.Pc=166;continue;}
case 151:{f.Locals[8]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","englishBundle","Ljava/util/ResourceBundle;"));f.Pc=158;continue;}
case 158:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/Localizer","resourceBundle","Ljava/util/ResourceBundle;",value);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[8]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/RuntimeException","printStackTrace","()V","invokevirtual",166);}
case 166:{f.Push(f.Locals[0]);f.Pc=167;continue;}
case 167:{f.Push(JValue.R(null));f.Pc=168;continue;}
case 168:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/Localizer","adventureBundle","Ljava/util/ResourceBundle;",value);f.Pc=171;continue;}
case 171:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=174;continue;}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","resourceBundle","Ljava/util/ResourceBundle;"));f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/util/ResourceBundle","getBaseBundleName","()Ljava/lang/String;","invokevirtual",181);}
case 181:{return rt.DynamicCall(f,"forge/util/Localizer:11933:181:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",186);}
case 186:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",189);}
case 189:{f.Push(f.Locals[0]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/util/Localizer","notifyObservers","()V","invokevirtual",193);}
case 193:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11934(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","currentLanguageRegionID","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?18:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference==null?18:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?24:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(null));f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/Localizer","adventureBundle","Ljava/util/ResourceBundle;",value);f.Pc=23;continue;}
case 23:{return JStep.ReturnVoid;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.NewArray("Ljava/net/URL;",f.Pop().Int)));f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",38);}
case 38:{return rt.Call(f,"java/io/File","toURI","()Ljava/net/URI;","invokevirtual",41);}
case 41:{return rt.Call(f,"java/net/URI","toURL","()Ljava/net/URL;","invokevirtual",44);}
case 44:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=45;continue;}
case 45:{f.Locals[2]=f.Pop();f.Pc=46;continue;}
case 46:{if(!rt.EnsureInitialized(f,"java/net/URLClassLoader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/net/URLClassLoader")));f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/net/URLClassLoader","<init>","([Ljava/net/URL;)V","invokespecial",54);}
case 54:{f.Locals[3]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","currentLanguageRegionID","Ljava/lang/String;"));f.Pc=60;continue;}
case 60:{return rt.DynamicCall(f,"forge/util/Localizer:11934:60:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",65);}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","locale","Ljava/util/Locale;"));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/ResourceBundle","getBundle","(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/ClassLoader;)Ljava/util/ResourceBundle;","invokestatic",73);}
case 73:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/Localizer","adventureBundle","Ljava/util/ResourceBundle;",value);f.Pc=76;continue;}
case 76:{f.Pc=85;continue;}
case 79:{f.Locals[2]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(JValue.R(null));f.Pc=82;continue;}
case 82:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/Localizer","adventureBundle","Ljava/util/ResourceBundle;",value);f.Pc=85;continue;}
case 85:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11935(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int!=0?21:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","adventureBundle","Ljava/util/ResourceBundle;"));f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference==null?21:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","adventureBundle","Ljava/util/ResourceBundle;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/ResourceBundle","getString","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",19);}
case 19:{return JStep.Return(f.Pop());}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Int==0?32:25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","englishBundle","Ljava/util/ResourceBundle;"));f.Pc=29;continue;}
case 29:{f.Pc=36;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","resourceBundle","Ljava/util/ResourceBundle;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/ResourceBundle","getString","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",40);}
case 40:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11936(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","observers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11937(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/Localizer","observers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?38:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/LocalizationChangeObserver"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/util/LocalizationChangeObserver","localizationChanged","()V","invokeinterface",35);}
case 35:{f.Pc=10;continue;}
case 38:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
