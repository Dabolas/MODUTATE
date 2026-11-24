// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1152{
internal static JClass Build(){var c=new JClass("forge/util/RSSReader","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11998,"forge/util/RSSReader","<init>","()V",1,1,1,new JHandler[]{},M11998));
c.Add(new JMethod(11999,"forge/util/RSSReader","getCommitLog","(Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;)Ljava/lang/String;",9,16,4,new JHandler[]{new JHandler(8,304,307,"java/lang/Exception")},M11999));
c.Add(new JMethod(12000,"forge/util/RSSReader","getLatestReleaseTag","(Ljava/lang/String;)Ljava/lang/String;",9,9,3,new JHandler[]{new JHandler(87,113,116,"java/lang/Exception"),new JHandler(3,131,134,"java/lang/Exception")},M12000));
}

internal static JStep M11998(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11999(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{f.Locals[3]=f.Pop();f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/TextUtil","getSimpleDate","()Ljava/text/SimpleDateFormat;","invokestatic",6);}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"com/apptasticsoftware/rssreader/RssReader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("com/apptasticsoftware/rssreader/RssReader")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/apptasticsoftware/rssreader/RssReader","<init>","()V","invokespecial",15);}
case 15:{f.Locals[5]=f.Pop();f.Pc=17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"java/net/URL"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/net/URL")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/net/URL","<init>","(Ljava/lang/String;)V","invokespecial",25);}
case 25:{f.Locals[6]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[6]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/net/URL","openStream","()Ljava/io/InputStream;","invokevirtual",32);}
case 32:{f.Locals[7]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[5]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[7]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"com/apptasticsoftware/rssreader/RssReader","read","(Ljava/io/InputStream;)Ljava/util/stream/Stream;","invokevirtual",41);}
case 41:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",44);}
case 44:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[8]=f.Pop();f.Pc=54;continue;}
case 54:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",61);}
case 61:{f.Locals[9]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{f.Locals[10]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[8]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",73);}
case 73:{f.Locals[11]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[11]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",82);}
case 82:{f.Pc=f.Pop().Int==0?279:85;continue;}
case 85:{f.Push(f.Locals[11]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",92);}
case 92:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/apptasticsoftware/rssreader/Item"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=95;continue;}
case 95:{f.Locals[12]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[12]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"com/apptasticsoftware/rssreader/Item","getTitle","()Ljava/util/Optional;","invokevirtual",102);}
case 102:{return rt.Call(f,"java/util/Optional","isEmpty","()Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?111:108;continue;}
case 108:{f.Pc=75;continue;}
case 111:{f.Push(f.Locals[12]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"com/apptasticsoftware/rssreader/Item","getTitle","()Ljava/util/Optional;","invokevirtual",116);}
case 116:{return rt.Call(f,"java/util/Optional","get","()Ljava/lang/Object;","invokevirtual",119);}
case 119:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/util/TextUtil","stripNonValidXMLCharacters","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",125);}
case 125:{f.Locals[13]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[13]);f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.String("Merge")));f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int==0?140:137;continue;}
case 137:{f.Pc=75;continue;}
case 140:{f.Push(f.Locals[12]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"com/apptasticsoftware/rssreader/Item","getPubDateZonedDateTime","()Ljava/util/Optional;","invokevirtual",145);}
case 145:{return rt.Call(f,"java/util/Optional","isPresent","()Z","invokevirtual",148);}
case 148:{f.Pc=f.Pop().Int==0?165:151;continue;}
case 151:{f.Push(f.Locals[12]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"com/apptasticsoftware/rssreader/Item","getPubDateZonedDateTime","()Ljava/util/Optional;","invokevirtual",156);}
case 156:{return rt.Call(f,"java/util/Optional","get","()Ljava/lang/Object;","invokevirtual",159);}
case 159:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/time/ZonedDateTime"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=162;continue;}
case 162:{f.Pc=166;continue;}
case 165:{f.Push(JValue.R(null));f.Pc=166;continue;}
case 166:{f.Locals[14]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[14]);f.Pc=170;continue;}
case 170:{f.Pc=f.Pop().Reference!=null?176:173;continue;}
case 173:{f.Pc=75;continue;}
case 176:{f.Push(f.Locals[14]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/time/ZonedDateTime","toInstant","()Ljava/time/Instant;","invokevirtual",181);}
case 181:{return rt.Call(f,"java/util/Date","from","(Ljava/time/Instant;)Ljava/util/Date;","invokestatic",184);}
case 184:{f.Locals[15]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[1]);f.Pc=187;continue;}
case 187:{f.Pc=f.Pop().Reference==null?202:190;continue;}
case 190:{f.Push(f.Locals[15]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[1]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/util/Date","before","(Ljava/util/Date;)Z","invokevirtual",196);}
case 196:{f.Pc=f.Pop().Int==0?202:199;continue;}
case 199:{f.Pc=75;continue;}
case 202:{f.Push(f.Locals[2]);f.Pc=203;continue;}
case 203:{f.Pc=f.Pop().Reference==null?218:206;continue;}
case 206:{f.Push(f.Locals[15]);f.Pc=208;continue;}
case 208:{f.Push(f.Locals[2]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/util/Date","after","(Ljava/util/Date;)Z","invokevirtual",212);}
case 212:{f.Pc=f.Pop().Int==0?218:215;continue;}
case 215:{f.Pc=75;continue;}
case 218:{f.Push(f.Locals[9]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[4]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[15]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"java/text/SimpleDateFormat","format","(Ljava/util/Date;)Ljava/lang/String;","invokevirtual",227);}
case 227:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",230);}
case 230:{f.Push(JValue.R(rt.String(" | ")));f.Pc=232;continue;}
case 232:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",235);}
case 235:{f.Push(f.Locals[13]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"org/apache/commons/text/StringEscapeUtils","unescapeXml","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",240);}
case 240:{f.Push(JValue.R(rt.String("\n")));f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.String("")));f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",247);}
case 247:{f.Push(JValue.R(rt.String("        ")));f.Pc=249;continue;}
case 249:{f.Push(JValue.R(rt.String("")));f.Pc=251;continue;}
case 251:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",254);}
case 254:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",257);}
case 257:{f.Push(JValue.R(rt.String("\n\n")));f.Pc=259;continue;}
case 259:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",262);}
case 262:{f.StackOp("pop");f.Pc=263;continue;}
case 263:{f.Push(f.Locals[10]);f.Pc=265;continue;}
case 265:{f.Push(JValue.I(15));f.Pc=267;continue;}
case 267:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?273:270;continue;}
case 270:{f.Pc=279;continue;}
case 273:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=276;continue;}
case 276:{f.Pc=75;continue;}
case 279:{f.Push(f.Locals[9]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",284);}
case 284:{f.Pc=f.Pop().Int<=0?299:287;continue;}
case 287:{f.Push(f.Locals[3]);f.Pc=288;continue;}
case 288:{f.Push(f.Locals[9]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",293);}
case 293:{return rt.DynamicCall(f,"forge/util/RSSReader:11999:293:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",298);}
case 298:{f.Locals[3]=f.Pop();f.Pc=299;continue;}
case 299:{f.Push(f.Locals[7]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"java/io/InputStream","close","()V","invokevirtual",304);}
case 304:{f.Pc=314;continue;}
case 307:{f.Locals[5]=f.Pop();f.Pc=309;continue;}
case 309:{f.Push(f.Locals[5]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"java/lang/Exception","printStackTrace","()V","invokevirtual",314);}
case 314:{f.Push(f.Locals[3]);f.Pc=315;continue;}
case 315:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12000(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{f.Locals[1]=f.Pop();f.Pc=3;continue;}
case 3:{if(!rt.EnsureInitialized(f,"com/apptasticsoftware/rssreader/RssReader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("com/apptasticsoftware/rssreader/RssReader")));f.Pc=6;continue;}
case 6:{f.StackOp("dup");f.Pc=7;continue;}
case 7:{return rt.Call(f,"com/apptasticsoftware/rssreader/RssReader","<init>","()V","invokespecial",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{if(!rt.EnsureInitialized(f,"java/net/URL"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/net/URL")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/net/URL","<init>","(Ljava/lang/String;)V","invokespecial",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/net/URL","openStream","()Ljava/io/InputStream;","invokevirtual",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"com/apptasticsoftware/rssreader/RssReader","read","(Ljava/io/InputStream;)Ljava/util/stream/Stream;","invokevirtual",32);}
case 32:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",35);}
case 35:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[5]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",52);}
case 52:{f.Locals[6]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",61);}
case 61:{f.Pc=f.Pop().Int==0?126:64;continue;}
case 64:{f.Push(f.Locals[6]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",71);}
case 71:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/apptasticsoftware/rssreader/Item"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=74;continue;}
case 74:{f.Locals[7]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[7]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"com/apptasticsoftware/rssreader/Item","getLink","()Ljava/util/Optional;","invokevirtual",81);}
case 81:{return rt.Call(f,"java/util/Optional","isPresent","()Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int==0?123:87;continue;}
case 87:{f.Push(f.Locals[7]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"com/apptasticsoftware/rssreader/Item","getLink","()Ljava/util/Optional;","invokevirtual",92);}
case 92:{return rt.Call(f,"java/util/Optional","get","()Ljava/lang/Object;","invokevirtual",95);}
case 95:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=98;continue;}
case 98:{f.Locals[8]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[8]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[8]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("forge")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/String","lastIndexOf","(Ljava/lang/String;)I","invokevirtual",109);}
case 109:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",112);}
case 112:{f.Locals[1]=f.Pop();f.Pc=113;continue;}
case 113:{f.Pc=126;continue;}
case 116:{f.Locals[8]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[8]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/Exception","printStackTrace","()V","invokevirtual",123);}
case 123:{f.Pc=54;continue;}
case 126:{f.Push(f.Locals[4]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/io/InputStream","close","()V","invokevirtual",131);}
case 131:{f.Pc=139;continue;}
case 134:{f.Locals[2]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[2]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/Exception","printStackTrace","()V","invokevirtual",139);}
case 139:{f.Push(f.Locals[1]);f.Pc=140;continue;}
case 140:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
