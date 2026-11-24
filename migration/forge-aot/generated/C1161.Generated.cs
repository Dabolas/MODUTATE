// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1161{
internal static JClass Build(){var c=new JClass("forge/util/TextUtil","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("changes","Ljava/lang/StringBuilder;",true,JValue.Default("Ljava/lang/StringBuilder;"),null));
c.Add(new JField("simpleDate","Ljava/text/SimpleDateFormat;",true,JValue.Default("Ljava/text/SimpleDateFormat;"),null));
c.Add(new JField("romanMap","Lcom/google/common/collect/ImmutableSortedMap;",true,JValue.Default("Lcom/google/common/collect/ImmutableSortedMap;"),null));
c.Add(new JField("df","Ljava/text/DecimalFormat;",true,JValue.Default("Ljava/text/DecimalFormat;"),null));
c.Add(new JField("CHAR_UNDEFINED","C",true,JValue.I(65535),null));
c.Add(new JField("ARTICLE_WORDS","[Ljava/lang/String;",true,JValue.Default("[Ljava/lang/String;"),null));
c.Add(new JMethod(12039,"forge/util/TextUtil","<init>","()V",1,1,1,new JHandler[]{},M12039));
c.Add(new JMethod(12040,"forge/util/TextUtil","toRoman","(I)Ljava/lang/String;",9,2,3,new JHandler[]{},M12040));
c.Add(new JMethod(12041,"forge/util/TextUtil","normalizeText","(Ljava/lang/String;)Ljava/lang/String;",9,1,2,new JHandler[]{},M12041));
c.Add(new JMethod(12042,"forge/util/TextUtil","decimalFormat","(F)Ljava/lang/String;",9,1,3,new JHandler[]{},M12042));
c.Add(new JMethod(12043,"forge/util/TextUtil","safeToString","(Ljava/lang/Object;)Ljava/lang/String;",9,1,1,new JHandler[]{},M12043));
c.Add(new JMethod(12044,"forge/util/TextUtil","mapToString","(Ljava/util/Map;)Ljava/lang/String;",9,5,2,new JHandler[]{},M12044));
c.Add(new JMethod(12045,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;C)[Ljava/lang/String;",9,2,6,new JHandler[]{},M12045));
c.Add(new JMethod(12046,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;CI)[Ljava/lang/String;",9,3,6,new JHandler[]{},M12046));
c.Add(new JMethod(12047,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;C)[Ljava/lang/String;",9,2,6,new JHandler[]{},M12047));
c.Add(new JMethod(12048,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;CCC)[Ljava/lang/String;",9,4,6,new JHandler[]{},M12048));
c.Add(new JMethod(12049,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;CI)[Ljava/lang/String;",9,3,6,new JHandler[]{},M12049));
c.Add(new JMethod(12050,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;CCCI)[Ljava/lang/String;",9,5,6,new JHandler[]{},M12050));
c.Add(new JMethod(12051,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;CICCZ)[Ljava/lang/String;",9,14,4,new JHandler[]{},M12051));
c.Add(new JMethod(12052,"forge/util/TextUtil","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;",9,5,2,new JHandler[]{},M12052));
c.Add(new JMethod(12053,"forge/util/TextUtil","enumToLabel","(Ljava/lang/Enum;)Ljava/lang/String;",9,1,3,new JHandler[]{},M12053));
c.Add(new JMethod(12054,"forge/util/TextUtil","buildFourColumnList","(Ljava/lang/String;Ljava/lang/Iterable;)Ljava/lang/String;",9,6,3,new JHandler[]{},M12054));
c.Add(new JMethod(12055,"forge/util/TextUtil","isPrintableChar","(C)Z",9,2,2,new JHandler[]{},M12055));
c.Add(new JMethod(12056,"forge/util/TextUtil","splitCompoundWord","(Ljava/lang/String;Lforge/util/TextUtil$PhraseCase;)Ljava/lang/String;",9,5,2,new JHandler[]{},M12056));
c.Add(new JMethod(12057,"forge/util/TextUtil","capitalize","(Ljava/lang/String;)Ljava/lang/String;",9,1,3,new JHandler[]{},M12057));
c.Add(new JMethod(12058,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;",137,3,3,new JHandler[]{},M12058));
c.Add(new JMethod(12059,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;",137,6,2,new JHandler[]{},M12059));
c.Add(new JMethod(12060,"forge/util/TextUtil","enclosedParen","(Ljava/lang/String;)Ljava/lang/String;",9,2,2,new JHandler[]{},M12060));
c.Add(new JMethod(12061,"forge/util/TextUtil","enclosedBracket","(Ljava/lang/String;)Ljava/lang/String;",9,2,2,new JHandler[]{},M12061));
c.Add(new JMethod(12062,"forge/util/TextUtil","enclosedSingleQuote","(Ljava/lang/String;)Ljava/lang/String;",9,2,2,new JHandler[]{},M12062));
c.Add(new JMethod(12063,"forge/util/TextUtil","enclosedDoubleQuote","(Ljava/lang/String;)Ljava/lang/String;",9,2,2,new JHandler[]{},M12063));
c.Add(new JMethod(12064,"forge/util/TextUtil","addSuffix","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,3,2,new JHandler[]{},M12064));
c.Add(new JMethod(12065,"forge/util/TextUtil","addPrefix","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,3,2,new JHandler[]{},M12065));
c.Add(new JMethod(12066,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,7,4,new JHandler[]{},M12066));
c.Add(new JMethod(12067,"forge/util/TextUtil","toManaString","(Ljava/lang/String;)Ljava/lang/String;",9,1,3,new JHandler[]{},M12067));
c.Add(new JMethod(12068,"forge/util/TextUtil","toSortableName","(Ljava/lang/String;)Ljava/lang/String;",9,1,3,new JHandler[]{},M12068));
c.Add(new JMethod(12069,"forge/util/TextUtil","moveArticleToEnd","(Ljava/lang/String;)Ljava/lang/String;",9,5,3,new JHandler[]{},M12069));
c.Add(new JMethod(12070,"forge/util/TextUtil","stripNonValidXMLCharacters","(Ljava/lang/String;)Ljava/lang/String;",9,4,2,new JHandler[]{},M12070));
c.Add(new JMethod(12071,"forge/util/TextUtil","getSimpleDate","()Ljava/text/SimpleDateFormat;",9,0,3,new JHandler[]{},M12071));
c.Add(new JMethod(12072,"forge/util/TextUtil","getFormattedChangelog","(Ljava/io/File;Ljava/lang/String;)Ljava/lang/String;",9,13,3,new JHandler[]{new JHandler(204,269,272,"java/lang/Exception"),new JHandler(27,362,365,"java/lang/Exception")},M12072));
c.Add(new JMethod(12073,"forge/util/TextUtil","<clinit>","()V",8,0,4,new JHandler[]{},M12073));
}

internal static JStep M12039(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12040(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int>0?7:4;continue;}
case 4:{f.Push(JValue.R(rt.String("")));f.Pc=6;continue;}
case 6:{return JStep.Return(f.Pop());}
case 7:{if(!rt.StaticReady(f,"forge/util/TextUtil","romanMap","Lcom/google/common/collect/ImmutableSortedMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil","romanMap","Lcom/google/common/collect/ImmutableSortedMap;"));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",14);}
case 14:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap","floorKey","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",23);}
case 23:{f.Locals[1]=f.Pop();f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/util/TextUtil","romanMap","Lcom/google/common/collect/ImmutableSortedMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil","romanMap","Lcom/google/common/collect/ImmutableSortedMap;"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",31);}
case 31:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/util/TextUtil","toRoman","(I)Ljava/lang/String;","invokestatic",43);}
case 43:{return rt.DynamicCall(f,"forge/util/TextUtil:12040:43:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",48);}
case 48:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12041(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?7:4;continue;}
case 4:{f.Push(JValue.R(rt.String("")));f.Pc=6;continue;}
case 6:{return JStep.Return(f.Pop());}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"java/text/Normalizer$Form","NFD","Ljava/text/Normalizer$Form;"))return JStep.Continue;f.Push(rt.GetStatic("java/text/Normalizer$Form","NFD","Ljava/text/Normalizer$Form;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/text/Normalizer","normalize","(Ljava/lang/CharSequence;Ljava/text/Normalizer$Form;)Ljava/lang/String;","invokestatic",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12042(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/TextUtil","df","Ljava/text/DecimalFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil","df","Ljava/text/DecimalFormat;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(JNumbers.Unary("f2d",f.Pop()));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/text/DecimalFormat","format","(D)Ljava/lang/String;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12043(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?9:4;continue;}
case 4:{f.Push(JValue.R(rt.String("null")));f.Pc=6;continue;}
case 6:{f.Pc=13;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12044(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",16);}
case 16:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?109:31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[4]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Pc=f.Pop().Int==0?51:46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{f.Locals[2]=f.Pop();f.Pc=48;continue;}
case 48:{f.Pc=58;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("; ")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",57);}
case 57:{f.StackOp("pop");f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",66);}
case 66:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",72);}
case 72:{f.Push(JValue.R(rt.String(" => ")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",77);}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",84);}
case 84:{f.Pc=f.Pop().Reference!=null?92:87;continue;}
case 87:{f.Push(JValue.R(rt.String("(null)")));f.Pc=89;continue;}
case 89:{f.Pc=102;continue;}
case 92:{f.Push(f.Locals[4]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",99);}
case 99:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",102);}
case 102:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",105);}
case 105:{f.StackOp("pop");f.Pc=106;continue;}
case 106:{f.Pc=22;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",113);}
case 113:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12045(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(2147483647));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;CICCZ)[Ljava/lang/String;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12046(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;CICCZ)[Ljava/lang/String;","invokestatic",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12047(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(2147483647));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(40));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(41));f.Pc=8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;CICCZ)[Ljava/lang/String;","invokestatic",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12048(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(2147483647));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;CICCZ)[Ljava/lang/String;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12049(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(40));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(41));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;CICCZ)[Ljava/lang/String;","invokestatic",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12050(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[4]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;CICCZ)[Ljava/lang/String;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12051(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[6]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?23:15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Int<=0?23:19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Locals[7]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{f.Locals[8]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/CharSequence","length","()I","invokeinterface",35);}
case 35:{f.Locals[9]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{f.Locals[10]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{f.Locals[11]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{f.Locals[12]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[12]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[9]);f.Pc=50;continue;}
case 50:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?166:53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[12]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/CharSequence","charAt","(I)C","invokeinterface",61);}
case 61:{f.Locals[13]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{f.Pc=f.Pop().Int<=0?86:68;continue;}
case 68:{f.Push(f.Locals[13]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?86:75;continue;}
case 75:{f.Push(f.Locals[8]);f.Pc=77;continue;}
case 77:{f.Pc=f.Pop().Int<=0?86:80;continue;}
case 80:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(-1)));f.Pc=83;continue;}
case 83:{f.Pc=99;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{f.Pc=f.Pop().Int<=0?99:90;continue;}
case 90:{f.Push(f.Locals[13]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[3]);f.Pc=93;continue;}
case 93:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?99:96;continue;}
case 96:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=99;continue;}
case 99:{f.Push(f.Locals[13]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?160:105;continue;}
case 105:{f.Push(f.Locals[8]);f.Pc=107;continue;}
case 107:{f.Pc=f.Pop().Int!=0?160:110;continue;}
case 110:{f.Push(f.Locals[11]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?160:116;continue;}
case 116:{f.Push(f.Locals[12]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[10]);f.Pc=120;continue;}
case 120:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?128:123;continue;}
case 123:{f.Push(f.Locals[5]);f.Pc=125;continue;}
case 125:{f.Pc=f.Pop().Int!=0?154:128;continue;}
case 128:{f.Push(f.Locals[6]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[10]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[12]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/lang/CharSequence","subSequence","(II)Ljava/lang/CharSequence;","invokeinterface",140);}
case 140:{return rt.Call(f,"java/lang/CharSequence","toString","()Ljava/lang/String;","invokeinterface",145);}
case 145:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",150);}
case 150:{f.StackOp("pop");f.Pc=151;continue;}
case 151:{f.Locals[11]=JValue.I(unchecked(f.Locals[11].Int+(1)));f.Pc=154;continue;}
case 154:{f.Push(f.Locals[12]);f.Pc=156;continue;}
case 156:{f.Push(JValue.I(1));f.Pc=157;continue;}
case 157:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=158;continue;}
case 158:{f.Locals[10]=f.Pop();f.Pc=160;continue;}
case 160:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=163;continue;}
case 163:{f.Pc=46;continue;}
case 166:{f.Push(f.Locals[9]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[10]);f.Pc=170;continue;}
case 170:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?178:173;continue;}
case 173:{f.Push(f.Locals[5]);f.Pc=175;continue;}
case 175:{f.Pc=f.Pop().Int!=0?201:178;continue;}
case 178:{f.Push(f.Locals[6]);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[0]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[10]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[9]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/lang/CharSequence","subSequence","(II)Ljava/lang/CharSequence;","invokeinterface",190);}
case 190:{return rt.Call(f,"java/lang/CharSequence","toString","()Ljava/lang/String;","invokeinterface",195);}
case 195:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",200);}
case 200:{f.StackOp("pop");f.Pc=201;continue;}
case 201:{f.Push(f.Locals[6]);f.Pc=203;continue;}
case 203:{if(!rt.StaticReady(f,"org/apache/commons/lang3/ArrayUtils","EMPTY_STRING_ARRAY","[Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("org/apache/commons/lang3/ArrayUtils","EMPTY_STRING_ARRAY","[Ljava/lang/String;"));f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/util/List","toArray","([Ljava/lang/Object;)[Ljava/lang/Object;","invokeinterface",211);}
case 211:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/lang/String;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=214;continue;}
case 214:{f.Locals[12]=f.Pop();f.Pc=216;continue;}
case 216:{f.Push(f.Locals[7]);f.Pc=218;continue;}
case 218:{f.Pc=f.Pop().Int==0?233:221;continue;}
case 221:{f.Push(f.Locals[12]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[3]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"java/lang/String","valueOf","(C)Ljava/lang/String;","invokestatic",227);}
case 227:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","stripAll","([Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;","invokestatic",230);}
case 230:{f.Pc=235;continue;}
case 233:{f.Push(f.Locals[12]);f.Pc=235;continue;}
case 235:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12052(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?58:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int<=0?48:42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{f.Pc=15;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",62);}
case 62:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12053(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Enum","toString","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",9);}
case 9:{if(!rt.StaticReady(f,"java/util/Locale","ENGLISH","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ENGLISH","Ljava/util/Locale;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","toUpperCase","(Ljava/util/Locale;)Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/Enum","toString","()Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",23);}
case 23:{if(!rt.StaticReady(f,"java/util/Locale","ENGLISH","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ENGLISH","Ljava/util/Locale;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/String","toLowerCase","(Ljava/util/Locale;)Ljava/lang/String;","invokevirtual",29);}
case 29:{return rt.DynamicCall(f,"forge/util/TextUtil:12053:29:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",34);}
case 34:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12054(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?78:29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Int==0?52:45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String(", ")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{f.Push(JValue.I(4));f.Pc=54;continue;}
case 54:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=55;continue;}
case 55:{f.Pc=f.Pop().Int!=0?65:58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("\n")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=75;continue;}
case 75:{f.Pc=19;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",82);}
case 82:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12055(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Character$UnicodeBlock","of","(C)Ljava/lang/Character$UnicodeBlock;","invokestatic",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Character","isISOControl","(C)Z","invokestatic",9);}
case 9:{f.Pc=f.Pop().Int!=0?33:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(65535));f.Pc=15;continue;}
case 15:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?33:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Reference==null?33:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{if(!rt.StaticReady(f,"java/lang/Character$UnicodeBlock","SPECIALS","Ljava/lang/Character$UnicodeBlock;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Character$UnicodeBlock","SPECIALS","Ljava/lang/Character$UnicodeBlock;"));f.Pc=26;continue;}
case 26:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?33:29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{f.Pc=34;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12056(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",15);}
case 15:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?146:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/Character","isUpperCase","(C)Z","invokestatic",30);}
case 30:{f.Pc=f.Pop().Int==0?133:33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Pc=f.Pop().Int<=0?44:37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String(" ")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",43);}
case 43:{f.StackOp("pop");f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/util/TextUtil$1","$SwitchMap$forge$util$TextUtil$PhraseCase","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil$1","$SwitchMap$forge$util$TextUtil$PhraseCase","[I"));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/util/TextUtil$PhraseCase","ordinal","()I","invokevirtual",51);}
case 51:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=52;continue;}
case 52:{switch(f.Pop().Int){case 1:f.Pc=80;break;case 2:f.Pc=90;break;case 3:f.Pc=117;break;default:f.Pc=130;break;}continue;}
case 80:{f.Push(f.Locals[2]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[4]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",86);}
case 86:{f.StackOp("pop");f.Pc=87;continue;}
case 87:{f.Pc=130;continue;}
case 90:{f.Push(f.Locals[3]);f.Pc=91;continue;}
case 91:{f.Pc=f.Pop().Int<=0?104:94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[4]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",100);}
case 100:{f.StackOp("pop");f.Pc=101;continue;}
case 101:{f.Pc=130;continue;}
case 104:{f.Push(f.Locals[2]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[4]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/Character","toLowerCase","(C)C","invokestatic",110);}
case 110:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",113);}
case 113:{f.StackOp("pop");f.Pc=114;continue;}
case 114:{f.Pc=130;continue;}
case 117:{f.Push(f.Locals[2]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[4]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/Character","toLowerCase","(C)C","invokestatic",123);}
case 123:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",126);}
case 126:{f.StackOp("pop");f.Pc=127;continue;}
case 127:{f.Pc=140;continue;}
case 130:{f.Pc=140;continue;}
case 133:{f.Push(f.Locals[2]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[4]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",139);}
case 139:{f.StackOp("pop");f.Pc=140;continue;}
case 140:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=143;continue;}
case 143:{f.Pc=10;continue;}
case 146:{f.Push(f.Locals[2]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",150);}
case 150:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12057(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",6);}
case 6:{return rt.Call(f,"java/lang/String","toUpperCase","()Ljava/lang/String;","invokevirtual",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",14);}
case 14:{return rt.DynamicCall(f,"forge/util/TextUtil:12057:14:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12058(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=13;continue;}
case 13:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?45:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=29;continue;}
case 29:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?39:32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String(" ")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",38);}
case 38:{f.StackOp("pop");f.Pc=39;continue;}
case 39:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=42;continue;}
case 42:{f.Pc=10;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",49);}
case 49:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12059(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=12;continue;}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?41:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=26;continue;}
case 26:{f.Locals[5]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[5]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",34);}
case 34:{f.StackOp("pop");f.Pc=35;continue;}
case 35:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=38;continue;}
case 38:{f.Pc=16;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",45);}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12060(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("(")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",20);}
case 20:{f.StackOp("pop");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String(")")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",32);}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12061(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("[")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",20);}
case 20:{f.StackOp("pop");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("]")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",32);}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12062(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("'")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",20);}
case 20:{f.StackOp("pop");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("'")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",32);}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12063(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("\"")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("\"")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",34);}
case 34:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12064(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",13);}
case 13:{f.StackOp("pop");f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",24);}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12065(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",13);}
case 13:{f.StackOp("pop");f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",24);}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12066(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",10);}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Int!=0?17:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",22);}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{f.Pc=f.Pop().Int>=0?31:29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return JStep.Return(f.Pop());}
case 31:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",40);}
case 40:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?50:43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",47);}
case 47:{f.Pc=56;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",54);}
case 54:{f.Push(JValue.I(2));f.Pc=55;continue;}
case 55:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/StringBuilder","<init>","(I)V","invokespecial",59);}
case 59:{f.Locals[5]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{f.Locals[6]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;","invokevirtual",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Push(f.Locals[5]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",81);}
case 81:{f.StackOp("pop");f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=86;continue;}
case 86:{f.Locals[6]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;I)I","invokevirtual",95);}
case 95:{f.Locals[4]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{f.Pc=f.Pop().Int>0?64:102;continue;}
case 102:{f.Push(f.Locals[5]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[6]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",111);}
case 111:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;","invokevirtual",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Push(f.Locals[5]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",120);}
case 120:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12067(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("mana")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?30:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Combo")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int!=0?30:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("Any")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?34:30;continue;}
case 30:{f.Push(JValue.R(rt.String("mana")));f.Pc=33;continue;}
case 33:{return JStep.Return(f.Pop());}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String(" ")));f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("}{")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",43);}
case 43:{return rt.DynamicCall(f,"forge/util/TextUtil:12067:43:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",48);}
case 48:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12068(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("\"")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?16:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Locals[0]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/util/TextUtil","moveArticleToEnd","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",20);}
case 20:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",23);}
case 23:{f.Push(JValue.R(rt.String("[^\\s'0-9a-z]")));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12069(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/TextUtil","ARTICLE_WORDS","[Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil","ARTICLE_WORDS","[Ljava/lang/String;"));f.Pc=3;continue;}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?60:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=17;continue;}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{return rt.DynamicCall(f,"forge/util/TextUtil:12069:22:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",27);}
case 27:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?54:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",39);}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{return rt.DynamicCall(f,"forge/util/TextUtil:12069:46:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",51);}
case 51:{f.Locals[0]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{return JStep.Return(f.Pop());}
case 54:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=57;continue;}
case 57:{f.Pc=9;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12070(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuffer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuffer")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuffer","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?21:12;continue;}
case 12:{f.Push(JValue.R(rt.String("")));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?24:21;continue;}
case 21:{f.Push(JValue.R(rt.String("")));f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",31);}
case 31:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?111:34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",39);}
case 39:{f.Locals[2]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(9));f.Pc=43;continue;}
case 43:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?99:46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(10));f.Pc=49;continue;}
case 49:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?99:52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{f.Push(JValue.I(13));f.Pc=55;continue;}
case 55:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?99:58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{f.Push(JValue.I(32));f.Pc=61;continue;}
case 61:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?71:64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(JValue.I(55295));f.Pc=68;continue;}
case 68:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?99:71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{f.Push(JValue.I(57344));f.Pc=75;continue;}
case 75:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?85:78;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{f.Push(JValue.I(65533));f.Pc=82;continue;}
case 82:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?99:85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(JValue.I(65536));f.Pc=89;continue;}
case 89:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?105:92;continue;}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{f.Push(JValue.I(1114111));f.Pc=96;continue;}
case 96:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?105:99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/StringBuffer","append","(C)Ljava/lang/StringBuffer;","invokevirtual",104);}
case 104:{f.StackOp("pop");f.Pc=105;continue;}
case 105:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=108;continue;}
case 108:{f.Pc=26;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/StringBuffer","toString","()Ljava/lang/String;","invokevirtual",115);}
case 115:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12071(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/TextUtil","simpleDate","Ljava/text/SimpleDateFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil","simpleDate","Ljava/text/SimpleDateFormat;"));f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference!=null?19:6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/text/SimpleDateFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/text/SimpleDateFormat")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("E, MMM dd, yyyy - hh:mm:ss a")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/text/SimpleDateFormat","<init>","(Ljava/lang/String;)V","invokespecial",16);}
case 16:{if(!rt.StaticReady(f,"forge/util/TextUtil","simpleDate","Ljava/text/SimpleDateFormat;"))return JStep.Continue;rt.PutStatic("forge/util/TextUtil","simpleDate","Ljava/text/SimpleDateFormat;",f.Pop());f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/util/TextUtil","simpleDate","Ljava/text/SimpleDateFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil","simpleDate","Ljava/text/SimpleDateFormat;"));f.Pc=22;continue;}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12072(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/io/File","exists","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{if(!rt.StaticReady(f,"forge/util/TextUtil","changes","Ljava/lang/StringBuilder;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil","changes","Ljava/lang/StringBuilder;"));f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference==null?27:15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/util/TextUtil","changes","Ljava/lang/StringBuilder;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil","changes","Ljava/lang/StringBuilder;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?368:27;continue;}
case 27:{return rt.Call(f,"java/util/Calendar","getInstance","()Ljava/util/Calendar;","invokestatic",30);}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{if(!rt.EnsureInitialized(f,"java/text/SimpleDateFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/text/SimpleDateFormat")));f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("yyyy-MM-dd HH:mm:ss")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/text/SimpleDateFormat","<init>","(Ljava/lang/String;)V","invokespecial",41);}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/util/TextUtil","getSimpleDate","()Ljava/text/SimpleDateFormat;","invokestatic",45);}
case 45:{f.Locals[4]=f.Pop();f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/time/OffsetDateTime","now","()Ljava/time/OffsetDateTime;","invokestatic",50);}
case 50:{return rt.Call(f,"java/time/OffsetDateTime","getOffset","()Ljava/time/ZoneOffset;","invokevirtual",53);}
case 53:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",56);}
case 56:{return rt.DynamicCall(f,"forge/util/TextUtil:12072:56:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",61);}
case 61:{f.Locals[5]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/util/FileUtil","readAllLines","(Ljava/io/File;Z)Ljava/util/List;","invokestatic",68);}
case 68:{f.Locals[6]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(JValue.I(0));f.Pc=71;continue;}
case 71:{f.Locals[7]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(JValue.I(0));f.Pc=74;continue;}
case 74:{f.Locals[8]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[6]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",83);}
case 83:{f.Locals[9]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[9]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",92);}
case 92:{f.Pc=f.Pop().Int==0?362:95;continue;}
case 95:{f.Push(f.Locals[9]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",102);}
case 102:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=105;continue;}
case 105:{f.Locals[10]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[10]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Int!=0?85:115;continue;}
case 115:{f.Push(f.Locals[10]);f.Pc=117;continue;}
case 117:{f.Push(JValue.R(rt.String("#")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",123);}
case 123:{f.Pc=f.Pop().Int!=0?85:126;continue;}
case 126:{f.Push(f.Locals[10]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",131);}
case 131:{f.Push(JValue.I(4));f.Pc=132;continue;}
case 132:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?138:135;continue;}
case 135:{f.Pc=85;continue;}
case 138:{f.Push(f.Locals[10]);f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.String("**Merge")));f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",146);}
case 146:{f.Pc=f.Pop().Int==0?155:149;continue;}
case 149:{f.Push(JValue.I(1));f.Pc=150;continue;}
case 150:{f.Locals[7]=f.Pop();f.Pc=152;continue;}
case 152:{f.Pc=85;continue;}
case 155:{f.Push(f.Locals[10]);f.Pc=157;continue;}
case 157:{f.Push(JValue.R(rt.String("[")));f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",162);}
case 162:{f.Pc=f.Pop().Int==0?308:165;continue;}
case 165:{f.Push(f.Locals[7]);f.Pc=167;continue;}
case 167:{f.Pc=f.Pop().Int==0?176:170;continue;}
case 170:{f.Push(JValue.I(0));f.Pc=171;continue;}
case 171:{f.Locals[7]=f.Pop();f.Pc=173;continue;}
case 173:{f.Pc=85;continue;}
case 176:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=179;continue;}
case 179:{f.Push(f.Locals[10]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[10]);f.Pc=183;continue;}
case 183:{f.Push(JValue.R(rt.String(" *")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/lang/String","lastIndexOf","(Ljava/lang/String;)I","invokevirtual",189);}
case 189:{f.Push(JValue.I(1));f.Pc=190;continue;}
case 190:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",194);}
case 194:{f.Push(JValue.R(rt.String("*")));f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.String("")));f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",202);}
case 202:{f.Locals[11]=f.Pop();f.Pc=204;continue;}
case 204:{f.Push(f.Locals[3]);f.Pc=205;continue;}
case 205:{f.Push(JValue.R(rt.String("UTC")));f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/util/TimeZone","getTimeZone","(Ljava/lang/String;)Ljava/util/TimeZone;","invokestatic",211);}
case 211:{return rt.Call(f,"java/text/SimpleDateFormat","setTimeZone","(Ljava/util/TimeZone;)V","invokevirtual",214);}
case 214:{f.Push(f.Locals[3]);f.Pc=215;continue;}
case 215:{f.Push(f.Locals[11]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"java/text/SimpleDateFormat","parse","(Ljava/lang/String;)Ljava/util/Date;","invokevirtual",220);}
case 220:{f.Locals[12]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(f.Locals[2]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[12]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/util/Calendar","setTime","(Ljava/util/Date;)V","invokevirtual",228);}
case 228:{f.Push(f.Locals[4]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"java/util/TimeZone","getDefault","()Ljava/util/TimeZone;","invokestatic",233);}
case 233:{return rt.Call(f,"java/text/SimpleDateFormat","setTimeZone","(Ljava/util/TimeZone;)V","invokevirtual",236);}
case 236:{if(!rt.StaticReady(f,"forge/util/TextUtil","changes","Ljava/lang/StringBuilder;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil","changes","Ljava/lang/StringBuilder;"));f.Pc=239;continue;}
case 239:{f.Push(JValue.R(rt.String("\n(")));f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",245);}
case 245:{f.Push(f.Locals[4]);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[2]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"java/util/Calendar","getTime","()Ljava/util/Date;","invokevirtual",251);}
case 251:{return rt.Call(f,"java/text/SimpleDateFormat","format","(Ljava/util/Date;)Ljava/lang/String;","invokevirtual",254);}
case 254:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",257);}
case 257:{f.Push(f.Locals[5]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",262);}
case 262:{f.Push(JValue.R(rt.String(")\n\n")));f.Pc=265;continue;}
case 265:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",268);}
case 268:{f.StackOp("pop");f.Pc=269;continue;}
case 269:{f.Pc=295;continue;}
case 272:{f.Locals[12]=f.Pop();f.Pc=274;continue;}
case 274:{if(!rt.StaticReady(f,"forge/util/TextUtil","changes","Ljava/lang/StringBuilder;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil","changes","Ljava/lang/StringBuilder;"));f.Pc=277;continue;}
case 277:{f.Push(JValue.R(rt.String("\n(")));f.Pc=280;continue;}
case 280:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",283);}
case 283:{f.Push(f.Locals[11]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",288);}
case 288:{f.Push(JValue.R(rt.String(")\n\n")));f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",294);}
case 294:{f.StackOp("pop");f.Pc=295;continue;}
case 295:{f.Push(f.Locals[8]);f.Pc=297;continue;}
case 297:{f.Push(JValue.I(20));f.Pc=299;continue;}
case 299:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?305:302;continue;}
case 302:{f.Pc=362;continue;}
case 305:{f.Pc=359;continue;}
case 308:{f.Push(f.Locals[7]);f.Pc=310;continue;}
case 310:{f.Pc=f.Pop().Int==0?316:313;continue;}
case 313:{f.Pc=85;continue;}
case 316:{f.Push(f.Locals[10]);f.Pc=318;continue;}
case 318:{f.Push(JValue.R(rt.String(" * ")));f.Pc=321;continue;}
case 321:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",324);}
case 324:{f.Pc=f.Pop().Int==0?347:327;continue;}
case 327:{if(!rt.StaticReady(f,"forge/util/TextUtil","changes","Ljava/lang/StringBuilder;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil","changes","Ljava/lang/StringBuilder;"));f.Pc=330;continue;}
case 330:{f.Push(JValue.R(rt.String("\n")));f.Pc=332;continue;}
case 332:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",335);}
case 335:{f.Push(f.Locals[10]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"org/apache/commons/text/StringEscapeUtils","unescapeXml","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",340);}
case 340:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",343);}
case 343:{f.StackOp("pop");f.Pc=344;continue;}
case 344:{f.Pc=359;continue;}
case 347:{if(!rt.StaticReady(f,"forge/util/TextUtil","changes","Ljava/lang/StringBuilder;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil","changes","Ljava/lang/StringBuilder;"));f.Pc=350;continue;}
case 350:{f.Push(f.Locals[10]);f.Pc=352;continue;}
case 352:{return rt.Call(f,"org/apache/commons/text/StringEscapeUtils","unescapeXml","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",355);}
case 355:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",358);}
case 358:{f.StackOp("pop");f.Pc=359;continue;}
case 359:{f.Pc=85;continue;}
case 362:{f.Pc=368;continue;}
case 365:{f.Locals[2]=f.Pop();f.Pc=366;continue;}
case 366:{f.Push(f.Locals[1]);f.Pc=367;continue;}
case 367:{return JStep.Return(f.Pop());}
case 368:{if(!rt.StaticReady(f,"forge/util/TextUtil","changes","Ljava/lang/StringBuilder;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil","changes","Ljava/lang/StringBuilder;"));f.Pc=371;continue;}
case 371:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",374);}
case 374:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12073(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{if(!rt.StaticReady(f,"forge/util/TextUtil","changes","Ljava/lang/StringBuilder;"))return JStep.Continue;rt.PutStatic("forge/util/TextUtil","changes","Ljava/lang/StringBuilder;",f.Pop());f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap","naturalOrder","()Lcom/google/common/collect/ImmutableSortedMap$Builder;","invokestatic",13);}
case 13:{f.Push(JValue.I(1000));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",19);}
case 19:{f.Push(JValue.R(rt.String("M")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap$Builder","put","(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSortedMap$Builder;","invokevirtual",25);}
case 25:{f.Push(JValue.I(900));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",31);}
case 31:{f.Push(JValue.R(rt.String("CM")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap$Builder","put","(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSortedMap$Builder;","invokevirtual",37);}
case 37:{f.Push(JValue.I(500));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",43);}
case 43:{f.Push(JValue.R(rt.String("D")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap$Builder","put","(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSortedMap$Builder;","invokevirtual",49);}
case 49:{f.Push(JValue.I(400));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",55);}
case 55:{f.Push(JValue.R(rt.String("CD")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap$Builder","put","(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSortedMap$Builder;","invokevirtual",61);}
case 61:{f.Push(JValue.I(100));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",66);}
case 66:{f.Push(JValue.R(rt.String("C")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap$Builder","put","(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSortedMap$Builder;","invokevirtual",72);}
case 72:{f.Push(JValue.I(90));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",77);}
case 77:{f.Push(JValue.R(rt.String("XC")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap$Builder","put","(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSortedMap$Builder;","invokevirtual",83);}
case 83:{f.Push(JValue.I(50));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",88);}
case 88:{f.Push(JValue.R(rt.String("L")));f.Pc=91;continue;}
case 91:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap$Builder","put","(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSortedMap$Builder;","invokevirtual",94);}
case 94:{f.Push(JValue.I(40));f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",99);}
case 99:{f.Push(JValue.R(rt.String("XL")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap$Builder","put","(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSortedMap$Builder;","invokevirtual",105);}
case 105:{f.Push(JValue.I(10));f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",110);}
case 110:{f.Push(JValue.R(rt.String("X")));f.Pc=113;continue;}
case 113:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap$Builder","put","(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSortedMap$Builder;","invokevirtual",116);}
case 116:{f.Push(JValue.I(9));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",121);}
case 121:{f.Push(JValue.R(rt.String("IX")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap$Builder","put","(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSortedMap$Builder;","invokevirtual",127);}
case 127:{f.Push(JValue.I(5));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",131);}
case 131:{f.Push(JValue.R(rt.String("V")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap$Builder","put","(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSortedMap$Builder;","invokevirtual",137);}
case 137:{f.Push(JValue.I(4));f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",141);}
case 141:{f.Push(JValue.R(rt.String("IV")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap$Builder","put","(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSortedMap$Builder;","invokevirtual",147);}
case 147:{f.Push(JValue.I(1));f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",151);}
case 151:{f.Push(JValue.R(rt.String("I")));f.Pc=154;continue;}
case 154:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap$Builder","put","(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSortedMap$Builder;","invokevirtual",157);}
case 157:{return rt.Call(f,"com/google/common/collect/ImmutableSortedMap$Builder","build","()Lcom/google/common/collect/ImmutableSortedMap;","invokevirtual",160);}
case 160:{if(!rt.StaticReady(f,"forge/util/TextUtil","romanMap","Lcom/google/common/collect/ImmutableSortedMap;"))return JStep.Continue;rt.PutStatic("forge/util/TextUtil","romanMap","Lcom/google/common/collect/ImmutableSortedMap;",f.Pop());f.Pc=163;continue;}
case 163:{if(!rt.EnsureInitialized(f,"java/text/DecimalFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/text/DecimalFormat")));f.Pc=166;continue;}
case 166:{f.StackOp("dup");f.Pc=167;continue;}
case 167:{f.Push(JValue.R(rt.String("#.##")));f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/text/DecimalFormat","<init>","(Ljava/lang/String;)V","invokespecial",173);}
case 173:{if(!rt.StaticReady(f,"forge/util/TextUtil","df","Ljava/text/DecimalFormat;"))return JStep.Continue;rt.PutStatic("forge/util/TextUtil","df","Ljava/text/DecimalFormat;",f.Pop());f.Pc=176;continue;}
case 176:{f.Push(JValue.I(3));f.Pc=177;continue;}
case 177:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=180;continue;}
case 180:{f.StackOp("dup");f.Pc=181;continue;}
case 181:{f.Push(JValue.I(0));f.Pc=182;continue;}
case 182:{f.Push(JValue.R(rt.String("A")));f.Pc=185;continue;}
case 185:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=186;continue;}
case 186:{f.StackOp("dup");f.Pc=187;continue;}
case 187:{f.Push(JValue.I(1));f.Pc=188;continue;}
case 188:{f.Push(JValue.R(rt.String("An")));f.Pc=191;continue;}
case 191:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=192;continue;}
case 192:{f.StackOp("dup");f.Pc=193;continue;}
case 193:{f.Push(JValue.I(2));f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("The")));f.Pc=197;continue;}
case 197:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=198;continue;}
case 198:{if(!rt.StaticReady(f,"forge/util/TextUtil","ARTICLE_WORDS","[Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/util/TextUtil","ARTICLE_WORDS","[Ljava/lang/String;",f.Pop());f.Pc=201;continue;}
case 201:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
