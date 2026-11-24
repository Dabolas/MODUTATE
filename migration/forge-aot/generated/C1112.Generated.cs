// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1112{
internal static JClass Build(){var c=new JClass("forge/util/CardTranslation","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("translatednames","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("translatedtypes","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("translatedoracles","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("oracleMappings","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("translatedCaches","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("sharedCache","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("translatedEffectNames","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("translatedTokenNames","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("knownEffectNames","Ljava/util/List;",true,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("TRANSLATION_INVARIANT","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("languageSelected","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(11683,"forge/util/CardTranslation","<init>","()V",1,1,1,new JHandler[]{},M11683));
c.Add(new JMethod(11684,"forge/util/CardTranslation","readTranslationFile","(Ljava/lang/String;Ljava/lang/String;)V",10,8,5,new JHandler[]{new JHandler(39,261,268,"java/lang/Throwable"),new JHandler(270,274,277,"java/lang/Throwable"),new JHandler(7,289,292,"java/io/IOException")},M11684));
c.Add(new JMethod(11685,"forge/util/CardTranslation","getTranslatedName","(Ljava/lang/String;)Ljava/lang/String;",9,4,4,new JHandler[]{new JHandler(69,82,162,"java/lang/Exception"),new JHandler(83,114,162,"java/lang/Exception"),new JHandler(115,131,162,"java/lang/Exception"),new JHandler(132,161,162,"java/lang/Exception")},M11685));
c.Add(new JMethod(11686,"forge/util/CardTranslation","getTranslatedName","(Lforge/util/ITranslatable;)Ljava/lang/String;",9,1,1,new JHandler[]{},M11686));
c.Add(new JMethod(11687,"forge/util/CardTranslation","translateTokenName","(Ljava/lang/String;)Ljava/lang/String;",10,3,4,new JHandler[]{},M11687));
c.Add(new JMethod(11688,"forge/util/CardTranslation","translateKnownEffectNames","(Ljava/lang/String;)Ljava/lang/String;",10,4,3,new JHandler[]{},M11688));
c.Add(new JMethod(11689,"forge/util/CardTranslation","translateEffectNames","(Ljava/lang/String;)Ljava/lang/String;",10,5,5,new JHandler[]{new JHandler(384,478,479,"java/lang/Exception")},M11689));
c.Add(new JMethod(11690,"forge/util/CardTranslation","getTranslatedType","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,3,2,new JHandler[]{},M11690));
c.Add(new JMethod(11691,"forge/util/CardTranslation","getTranslatedType","(Lforge/util/ITranslatable;)Ljava/lang/String;",9,1,3,new JHandler[]{},M11691));
c.Add(new JMethod(11692,"forge/util/CardTranslation","getTranslatedOracle","(Ljava/lang/String;)Ljava/lang/String;",9,2,2,new JHandler[]{},M11692));
c.Add(new JMethod(11693,"forge/util/CardTranslation","getTranslatedOracle","(Lforge/util/ITranslatable;)Ljava/lang/String;",9,1,3,new JHandler[]{},M11693));
c.Add(new JMethod(11694,"forge/util/CardTranslation","getTranslationTexts","(Lforge/util/ITranslatable;)Ljava/util/HashMap;",9,1,2,new JHandler[]{},M11694));
c.Add(new JMethod(11695,"forge/util/CardTranslation","getTranslationTexts","(Lforge/util/ITranslatable;Lforge/util/ITranslatable;)Ljava/util/HashMap;",9,3,3,new JHandler[]{},M11695));
c.Add(new JMethod(11696,"forge/util/CardTranslation","getLanguageSelected","()Ljava/lang/String;",9,0,1,new JHandler[]{},M11696));
c.Add(new JMethod(11697,"forge/util/CardTranslation","needsTranslation","()Z",10,0,2,new JHandler[]{},M11697));
c.Add(new JMethod(11698,"forge/util/CardTranslation","preloadTranslation","(Ljava/lang/String;Ljava/lang/String;)V",9,2,2,new JHandler[]{},M11698));
c.Add(new JMethod(11699,"forge/util/CardTranslation","replaceCardName","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",10,5,3,new JHandler[]{},M11699));
c.Add(new JMethod(11700,"forge/util/CardTranslation","buildOracleMapping","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",9,14,4,new JHandler[]{},M11700));
c.Add(new JMethod(11701,"forge/util/CardTranslation","leadingLineOffset","([Ljava/lang/String;[Ljava/lang/String;)I",10,6,4,new JHandler[]{},M11701));
c.Add(new JMethod(11702,"forge/util/CardTranslation","agreement","(Ljava/lang/String;Ljava/util/List;)I",10,3,2,new JHandler[]{},M11702));
c.Add(new JMethod(11703,"forge/util/CardTranslation","isKeywordLine","(Ljava/lang/String;)Z",10,2,3,new JHandler[]{},M11703));
c.Add(new JMethod(11704,"forge/util/CardTranslation","translationInvariants","(Ljava/lang/String;)Ljava/util/List;",10,3,2,new JHandler[]{},M11704));
c.Add(new JMethod(11705,"forge/util/CardTranslation","translateMultipleDescriptionText","(Ljava/lang/String;Lforge/util/ITranslatable;)Ljava/lang/String;",9,14,3,new JHandler[]{},M11705));
c.Add(new JMethod(11706,"forge/util/CardTranslation","translateSingleDescriptionText","(Ljava/lang/String;Lforge/util/ITranslatable;)Ljava/lang/String;",9,6,3,new JHandler[]{},M11706));
c.Add(new JMethod(11707,"forge/util/CardTranslation","translateSingleIngameText","(Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;",10,9,3,new JHandler[]{},M11707));
c.Add(new JMethod(11708,"forge/util/CardTranslation","lambda$translateSingleDescriptionText$0","(Ljava/lang/String;)Ljava/util/Map;",4106,1,2,new JHandler[]{},M11708));
c.Add(new JMethod(11709,"forge/util/CardTranslation","<clinit>","()V",8,0,4,new JHandler[]{},M11709));
}

internal static JStep M11683(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11684(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/util/CardTranslation:11684:1:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"forge/util/LineReader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/LineReader")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.DynamicCall(f,"forge/util/CardTranslation:11684:13:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",18);}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/nio/file/Paths","get","(Ljava/lang/String;[Ljava/lang/String;)Ljava/nio/file/Path;","invokestatic",25);}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.NewArray("Ljava/nio/file/OpenOption;",f.Pop().Int)));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/nio/file/Files","newInputStream","(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/InputStream;","invokestatic",32);}
case 32:{if(!rt.StaticReady(f,"java/nio/charset/StandardCharsets","UTF_8","Ljava/nio/charset/Charset;"))return JStep.Continue;f.Push(rt.GetStatic("java/nio/charset/StandardCharsets","UTF_8","Ljava/nio/charset/Charset;"));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/util/LineReader","<init>","(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V","invokespecial",38);}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/util/LineReader","readLines","()Ljava/util/Collection;","invokevirtual",43);}
case 43:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",48);}
case 48:{f.Locals[4]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",57);}
case 57:{f.Pc=f.Pop().Int==0?261:60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",67);}
case 67:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=70;continue;}
case 70:{f.Locals[5]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("\\|")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",79);}
case 79:{f.Locals[6]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[6]);f.Pc=83;continue;}
case 83:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=84;continue;}
case 84:{f.Push(JValue.I(2));f.Pc=85;continue;}
case 85:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?170:88;continue;}
case 88:{f.Push(f.Locals[6]);f.Pc=90;continue;}
case 90:{f.Push(JValue.I(0));f.Pc=91;continue;}
case 91:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=92;continue;}
case 92:{f.Push(JValue.I(36));f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",97);}
case 97:{f.Pc=f.Pop().Int<=0?153:100;continue;}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{f.Push(JValue.I(0));f.Pc=103;continue;}
case 103:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("\\s*\\$")));f.Pc=106;continue;}
case 106:{f.Push(JValue.I(2));f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",110);}
case 110:{f.Locals[7]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[7]);f.Pc=114;continue;}
case 114:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?153:119;continue;}
case 119:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatednames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatednames","Ljava/util/Map;"));f.Pc=122;continue;}
case 122:{f.Push(f.Locals[7]);f.Pc=124;continue;}
case 124:{f.Push(JValue.I(0));f.Pc=125;continue;}
case 125:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=126;continue;}
case 126:{f.Push(f.Locals[6]);f.Pc=128;continue;}
case 128:{f.Push(JValue.I(1));f.Pc=129;continue;}
case 129:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",135);}
case 135:{f.StackOp("pop");f.Pc=136;continue;}
case 136:{f.Push(f.Locals[6]);f.Pc=138;continue;}
case 138:{f.Push(JValue.I(0));f.Pc=139;continue;}
case 139:{f.Push(f.Locals[7]);f.Pc=141;continue;}
case 141:{f.Push(JValue.I(0));f.Pc=142;continue;}
case 142:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=143;continue;}
case 143:{f.Push(f.Locals[7]);f.Pc=145;continue;}
case 145:{f.Push(JValue.I(1));f.Pc=146;continue;}
case 146:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=147;continue;}
case 147:{return rt.DynamicCall(f,"forge/util/CardTranslation:11684:147:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",152);}
case 152:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=153;continue;}
case 153:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatednames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatednames","Ljava/util/Map;"));f.Pc=156;continue;}
case 156:{f.Push(f.Locals[6]);f.Pc=158;continue;}
case 158:{f.Push(JValue.I(0));f.Pc=159;continue;}
case 159:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=160;continue;}
case 160:{f.Push(f.Locals[6]);f.Pc=162;continue;}
case 162:{f.Push(JValue.I(1));f.Pc=163;continue;}
case 163:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",169);}
case 169:{f.StackOp("pop");f.Pc=170;continue;}
case 170:{f.Push(f.Locals[6]);f.Pc=172;continue;}
case 172:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=173;continue;}
case 173:{f.Push(JValue.I(3));f.Pc=174;continue;}
case 174:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?194:177;continue;}
case 177:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedtypes","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedtypes","Ljava/util/Map;"));f.Pc=180;continue;}
case 180:{f.Push(f.Locals[6]);f.Pc=182;continue;}
case 182:{f.Push(JValue.I(0));f.Pc=183;continue;}
case 183:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=184;continue;}
case 184:{f.Push(f.Locals[6]);f.Pc=186;continue;}
case 186:{f.Push(JValue.I(2));f.Pc=187;continue;}
case 187:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",193);}
case 193:{f.StackOp("pop");f.Pc=194;continue;}
case 194:{f.Push(f.Locals[6]);f.Pc=196;continue;}
case 196:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=197;continue;}
case 197:{f.Push(JValue.I(4));f.Pc=198;continue;}
case 198:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?258:201;continue;}
case 201:{f.Push(f.Locals[6]);f.Pc=203;continue;}
case 203:{f.Push(JValue.I(3));f.Pc=204;continue;}
case 204:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=205;continue;}
case 205:{f.Locals[7]=f.Pop();f.Pc=207;continue;}
case 207:{f.Push(f.Locals[7]);f.Pc=209;continue;}
case 209:{f.Push(JValue.R(rt.String("//Level_2//\\n")));f.Pc=211;continue;}
case 211:{f.Push(JValue.R(rt.String("")));f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",216);}
case 216:{f.Push(JValue.R(rt.String("//Level_3//\\n")));f.Pc=218;continue;}
case 218:{f.Push(JValue.R(rt.String("")));f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",223);}
case 223:{f.Locals[7]=f.Pop();f.Pc=225;continue;}
case 225:{f.Push(f.Locals[7]);f.Pc=227;continue;}
case 227:{f.Push(JValue.R(rt.String("\\n")));f.Pc=229;continue;}
case 229:{f.Push(JValue.R(rt.String("\r\n\r\n")));f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",234);}
case 234:{f.Push(JValue.R(rt.String("VERT")));f.Pc=236;continue;}
case 236:{f.Push(JValue.R(rt.String("|")));f.Pc=238;continue;}
case 238:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",241);}
case 241:{f.Locals[7]=f.Pop();f.Pc=243;continue;}
case 243:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedoracles","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedoracles","Ljava/util/Map;"));f.Pc=246;continue;}
case 246:{f.Push(f.Locals[6]);f.Pc=248;continue;}
case 248:{f.Push(JValue.I(0));f.Pc=249;continue;}
case 249:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=250;continue;}
case 250:{f.Push(f.Locals[7]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",257);}
case 257:{f.StackOp("pop");f.Pc=258;continue;}
case 258:{f.Pc=50;continue;}
case 261:{f.Push(f.Locals[3]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/util/LineReader","close","()V","invokevirtual",265);}
case 265:{f.Pc=289;continue;}
case 268:{f.Locals[4]=f.Pop();f.Pc=270;continue;}
case 270:{f.Push(f.Locals[3]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/util/LineReader","close","()V","invokevirtual",274);}
case 274:{f.Pc=286;continue;}
case 277:{f.Locals[5]=f.Pop();f.Pc=279;continue;}
case 279:{f.Push(f.Locals[4]);f.Pc=281;continue;}
case 281:{f.Push(f.Locals[5]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"java/lang/Throwable","addSuppressed","(Ljava/lang/Throwable;)V","invokevirtual",286);}
case 286:{f.Push(f.Locals[4]);f.Pc=288;continue;}
case 288:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 289:{f.Pc=314;continue;}
case 292:{f.Locals[3]=f.Pop();f.Pc=293;continue;}
case 293:{f.Push(JValue.R(rt.String("en-US")));f.Pc=295;continue;}
case 295:{f.Push(f.Locals[0]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",299);}
case 299:{f.Pc=f.Pop().Int!=0?314:302;continue;}
case 302:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=305;continue;}
case 305:{f.Push(f.Locals[0]);f.Pc=306;continue;}
case 306:{return rt.DynamicCall(f,"forge/util/CardTranslation:11684:306:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",311);}
case 311:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",314);}
case 314:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11685(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/CardTranslation","needsTranslation","()Z","invokestatic",3);}
case 3:{f.Pc=f.Pop().Int==0?165:6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String(" // ")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?69:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String(" // ")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",21);}
case 21:{f.Locals[1]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",28);}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(4));f.Pc=32;continue;}
case 32:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",36);}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatednames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatednames","Ljava/util/Map;"));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatednames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatednames","Ljava/util/Map;"));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",60);}
case 60:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=63;continue;}
case 63:{return rt.DynamicCall(f,"forge/util/CardTranslation:11685:63:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",68);}
case 68:{return JStep.Return(f.Pop());}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String(" Token")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",75);}
case 75:{f.Pc=f.Pop().Int==0?83:78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/util/CardTranslation","translateTokenName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",82);}
case 82:{return JStep.Return(f.Pop());}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("Emblem \u2014 ")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int!=0?110:92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("'s Effect")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int!=0?110:101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("'s Boon")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int==0?115:110;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/util/CardTranslation","translateEffectNames","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",114);}
case 114:{return JStep.Return(f.Pop());}
case 115:{if(!rt.StaticReady(f,"forge/util/CardTranslation","knownEffectNames","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","knownEffectNames","Ljava/util/List;"));f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",124);}
case 124:{f.Pc=f.Pop().Int==0?132:127;continue;}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/util/CardTranslation","translateKnownEffectNames","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",131);}
case 131:{return JStep.Return(f.Pop());}
case 132:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatednames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatednames","Ljava/util/Map;"));f.Pc=135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",141);}
case 141:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=144;continue;}
case 144:{f.Locals[1]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{f.Pc=f.Pop().Reference==null?156:149;continue;}
case 149:{f.Push(f.Locals[1]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int==0?160:156;continue;}
case 156:{f.Push(f.Locals[0]);f.Pc=157;continue;}
case 157:{f.Pc=161;continue;}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{return JStep.Return(f.Pop());}
case 162:{f.Locals[1]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{return JStep.Return(f.Pop());}
case 165:{f.Push(f.Locals[0]);f.Pc=166;continue;}
case 166:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11686(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/ITranslatable","getUntranslatedName","()Ljava/lang/String;","invokeinterface",6);}
case 6:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11687(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedTokenNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedTokenNames","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference!=null?16:6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",13);}
case 13:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedTokenNames","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/util/CardTranslation","translatedTokenNames","Ljava/util/Map;",f.Pop());f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedTokenNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedTokenNames","Ljava/util/Map;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[1]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference!=null?109:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String(" Token")));f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",41);}
case 41:{f.Locals[2]=f.Pop();f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",45);}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.DynamicCall(f,"forge/util/CardTranslation:11687:46:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",51);}
case 51:{f.Push(JValue.R(rt.String("")));f.Pc=53;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/util/Localizer","getMessageorUseDefault","(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",60);}
case 60:{f.Locals[1]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.Pc=f.Pop().Reference==null?72:65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?77:72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Locals[1]=f.Pop();f.Pc=74;continue;}
case 74:{f.Pc=96;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",81);}
case 81:{f.Push(JValue.R(rt.String("lblToken")));f.Pc=83;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",90);}
case 90:{return rt.DynamicCall(f,"forge/util/CardTranslation:11687:90:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",95);}
case 95:{f.Locals[1]=f.Pop();f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedTokenNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedTokenNames","Ljava/util/Map;"));f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",106);}
case 106:{f.StackOp("pop");f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{return JStep.Return(f.Pop());}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11688(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference!=null?16:6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",13);}
case 13:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;",f.Pop());f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[1]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference!=null?333:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Locals[2]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(JValue.I(-1));f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",41);}
case 41:{switch(f.Pop().Int){case -1624244432:f.Pc=134;break;case -202208885:f.Pc=148;break;case 1089186931:f.Pc=106;break;case 1101926591:f.Pc=92;break;case 1382985051:f.Pc=120;break;default:f.Pc=160;break;}continue;}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("The Ring")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?160:101;continue;}
case 101:{f.Push(JValue.I(0));f.Pc=102;continue;}
case 102:{f.Locals[3]=f.Pop();f.Pc=103;continue;}
case 103:{f.Pc=160;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("The Monarch")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Int==0?160:115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{f.Locals[3]=f.Pop();f.Pc=117;continue;}
case 117:{f.Pc=160;continue;}
case 120:{f.Push(f.Locals[2]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("The Initiative")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int==0?160:129;continue;}
case 129:{f.Push(JValue.I(2));f.Pc=130;continue;}
case 130:{f.Locals[3]=f.Pop();f.Pc=131;continue;}
case 131:{f.Pc=160;continue;}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.String("City's Blessing")));f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",140);}
case 140:{f.Pc=f.Pop().Int==0?160:143;continue;}
case 143:{f.Push(JValue.I(3));f.Pc=144;continue;}
case 144:{f.Locals[3]=f.Pop();f.Pc=145;continue;}
case 145:{f.Pc=160;continue;}
case 148:{f.Push(f.Locals[2]);f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String("Keyword Effects")));f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",155);}
case 155:{f.Pc=f.Pop().Int==0?160:158;continue;}
case 158:{f.Push(JValue.I(4));f.Pc=159;continue;}
case 159:{f.Locals[3]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[3]);f.Pc=161;continue;}
case 161:{switch(f.Pop().Int){case 0:f.Pc=196;break;case 1:f.Pc=223;break;case 2:f.Pc=250;break;case 3:f.Pc=277;break;case 4:f.Pc=304;break;default:f.Pc=331;break;}continue;}
case 196:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",199);}
case 199:{f.Push(JValue.R(rt.String("lblTheRing")));f.Pc=202;continue;}
case 202:{f.Push(JValue.I(0));f.Pc=203;continue;}
case 203:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",209);}
case 209:{f.Locals[1]=f.Pop();f.Pc=210;continue;}
case 210:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"));f.Pc=213;continue;}
case 213:{f.Push(f.Locals[0]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[1]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",220);}
case 220:{f.StackOp("pop");f.Pc=221;continue;}
case 221:{f.Push(f.Locals[1]);f.Pc=222;continue;}
case 222:{return JStep.Return(f.Pop());}
case 223:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",226);}
case 226:{f.Push(JValue.R(rt.String("lblTheMonarch")));f.Pc=229;continue;}
case 229:{f.Push(JValue.I(0));f.Pc=230;continue;}
case 230:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",236);}
case 236:{f.Locals[1]=f.Pop();f.Pc=237;continue;}
case 237:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"));f.Pc=240;continue;}
case 240:{f.Push(f.Locals[0]);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[1]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",247);}
case 247:{f.StackOp("pop");f.Pc=248;continue;}
case 248:{f.Push(f.Locals[1]);f.Pc=249;continue;}
case 249:{return JStep.Return(f.Pop());}
case 250:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",253);}
case 253:{f.Push(JValue.R(rt.String("lblTheInitiative")));f.Pc=256;continue;}
case 256:{f.Push(JValue.I(0));f.Pc=257;continue;}
case 257:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",263);}
case 263:{f.Locals[1]=f.Pop();f.Pc=264;continue;}
case 264:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"));f.Pc=267;continue;}
case 267:{f.Push(f.Locals[0]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[1]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",274);}
case 274:{f.StackOp("pop");f.Pc=275;continue;}
case 275:{f.Push(f.Locals[1]);f.Pc=276;continue;}
case 276:{return JStep.Return(f.Pop());}
case 277:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",280);}
case 280:{f.Push(JValue.R(rt.String("lblCityBlessing")));f.Pc=283;continue;}
case 283:{f.Push(JValue.I(0));f.Pc=284;continue;}
case 284:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",290);}
case 290:{f.Locals[1]=f.Pop();f.Pc=291;continue;}
case 291:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"));f.Pc=294;continue;}
case 294:{f.Push(f.Locals[0]);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[1]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",301);}
case 301:{f.StackOp("pop");f.Pc=302;continue;}
case 302:{f.Push(f.Locals[1]);f.Pc=303;continue;}
case 303:{return JStep.Return(f.Pop());}
case 304:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",307);}
case 307:{f.Push(JValue.R(rt.String("lblKeywordEffects")));f.Pc=310;continue;}
case 310:{f.Push(JValue.I(0));f.Pc=311;continue;}
case 311:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",317);}
case 317:{f.Locals[1]=f.Pop();f.Pc=318;continue;}
case 318:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"));f.Pc=321;continue;}
case 321:{f.Push(f.Locals[0]);f.Pc=322;continue;}
case 322:{f.Push(f.Locals[1]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",328);}
case 328:{f.StackOp("pop");f.Pc=329;continue;}
case 329:{f.Push(f.Locals[1]);f.Pc=330;continue;}
case 330:{return JStep.Return(f.Pop());}
case 331:{f.Push(f.Locals[0]);f.Pc=332;continue;}
case 332:{return JStep.Return(f.Pop());}
case 333:{f.Push(f.Locals[1]);f.Pc=334;continue;}
case 334:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11689(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference!=null?16:6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",13);}
case 13:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;",f.Pop());f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[1]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference!=null?483:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("\\([^()]*\\)")));f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Locals[2]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String(" 's Effect")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?125:53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String(" 's Effect")));f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",62);}
case 62:{f.Locals[2]=f.Pop();f.Pc=63;continue;}
case 63:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatednames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatednames","Ljava/util/Map;"));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{f.Locals[1]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{f.Pc=f.Pop().Reference==null?87:80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int==0?92:87;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{f.Locals[1]=f.Pop();f.Pc=89;continue;}
case 89:{f.Pc=112;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",96);}
case 96:{f.Push(JValue.R(rt.String("lblEffect")));f.Pc=99;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",106);}
case 106:{return rt.DynamicCall(f,"forge/util/CardTranslation:11689:106:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",111);}
case 111:{f.Locals[1]=f.Pop();f.Pc=112;continue;}
case 112:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"));f.Pc=115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",122);}
case 122:{f.StackOp("pop");f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return JStep.Return(f.Pop());}
case 125:{f.Push(f.Locals[2]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("'s Effect")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int==0?205:134;continue;}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.String("'s Effect")));f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String("")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",142);}
case 142:{f.Locals[2]=f.Pop();f.Pc=143;continue;}
case 143:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatednames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatednames","Ljava/util/Map;"));f.Pc=146;continue;}
case 146:{f.Push(f.Locals[2]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",152);}
case 152:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=155;continue;}
case 155:{f.Locals[1]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{f.Pc=f.Pop().Reference==null?167:160;continue;}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Int==0?172:167;continue;}
case 167:{f.Push(f.Locals[2]);f.Pc=168;continue;}
case 168:{f.Locals[1]=f.Pop();f.Pc=169;continue;}
case 169:{f.Pc=192;continue;}
case 172:{f.Push(f.Locals[1]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",176);}
case 176:{f.Push(JValue.R(rt.String("lblEffect")));f.Pc=179;continue;}
case 179:{f.Push(JValue.I(0));f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",186);}
case 186:{return rt.DynamicCall(f,"forge/util/CardTranslation:11689:186:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",191);}
case 191:{f.Locals[1]=f.Pop();f.Pc=192;continue;}
case 192:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"));f.Pc=195;continue;}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[1]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",202);}
case 202:{f.StackOp("pop");f.Pc=203;continue;}
case 203:{f.Push(f.Locals[1]);f.Pc=204;continue;}
case 204:{return JStep.Return(f.Pop());}
case 205:{f.Push(f.Locals[2]);f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.String(" 's Boon")));f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",212);}
case 212:{f.Pc=f.Pop().Int==0?287:215;continue;}
case 215:{f.Push(f.Locals[2]);f.Pc=216;continue;}
case 216:{f.Push(JValue.R(rt.String(" 's Boon")));f.Pc=219;continue;}
case 219:{f.Push(JValue.R(rt.String("")));f.Pc=221;continue;}
case 221:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",224);}
case 224:{f.Locals[2]=f.Pop();f.Pc=225;continue;}
case 225:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatednames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatednames","Ljava/util/Map;"));f.Pc=228;continue;}
case 228:{f.Push(f.Locals[2]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",234);}
case 234:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=237;continue;}
case 237:{f.Locals[1]=f.Pop();f.Pc=238;continue;}
case 238:{f.Push(f.Locals[1]);f.Pc=239;continue;}
case 239:{f.Pc=f.Pop().Reference==null?249:242;continue;}
case 242:{f.Push(f.Locals[1]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",246);}
case 246:{f.Pc=f.Pop().Int==0?254:249;continue;}
case 249:{f.Push(f.Locals[2]);f.Pc=250;continue;}
case 250:{f.Locals[1]=f.Pop();f.Pc=251;continue;}
case 251:{f.Pc=274;continue;}
case 254:{f.Push(f.Locals[1]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",258);}
case 258:{f.Push(JValue.R(rt.String("lblBoon")));f.Pc=261;continue;}
case 261:{f.Push(JValue.I(0));f.Pc=262;continue;}
case 262:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",268);}
case 268:{return rt.DynamicCall(f,"forge/util/CardTranslation:11689:268:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",273);}
case 273:{f.Locals[1]=f.Pop();f.Pc=274;continue;}
case 274:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"));f.Pc=277;continue;}
case 277:{f.Push(f.Locals[0]);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[1]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",284);}
case 284:{f.StackOp("pop");f.Pc=285;continue;}
case 285:{f.Push(f.Locals[1]);f.Pc=286;continue;}
case 286:{return JStep.Return(f.Pop());}
case 287:{f.Push(f.Locals[2]);f.Pc=288;continue;}
case 288:{f.Push(JValue.R(rt.String("'s Boon")));f.Pc=290;continue;}
case 290:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",293);}
case 293:{f.Pc=f.Pop().Int==0?367:296;continue;}
case 296:{f.Push(f.Locals[2]);f.Pc=297;continue;}
case 297:{f.Push(JValue.R(rt.String("'s Boon")));f.Pc=299;continue;}
case 299:{f.Push(JValue.R(rt.String("")));f.Pc=301;continue;}
case 301:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",304);}
case 304:{f.Locals[2]=f.Pop();f.Pc=305;continue;}
case 305:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatednames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatednames","Ljava/util/Map;"));f.Pc=308;continue;}
case 308:{f.Push(f.Locals[2]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",314);}
case 314:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=317;continue;}
case 317:{f.Locals[1]=f.Pop();f.Pc=318;continue;}
case 318:{f.Push(f.Locals[1]);f.Pc=319;continue;}
case 319:{f.Pc=f.Pop().Reference==null?329:322;continue;}
case 322:{f.Push(f.Locals[1]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",326);}
case 326:{f.Pc=f.Pop().Int==0?334:329;continue;}
case 329:{f.Push(f.Locals[2]);f.Pc=330;continue;}
case 330:{f.Locals[1]=f.Pop();f.Pc=331;continue;}
case 331:{f.Pc=354;continue;}
case 334:{f.Push(f.Locals[1]);f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",338);}
case 338:{f.Push(JValue.R(rt.String("lblBoon")));f.Pc=341;continue;}
case 341:{f.Push(JValue.I(0));f.Pc=342;continue;}
case 342:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",348);}
case 348:{return rt.DynamicCall(f,"forge/util/CardTranslation:11689:348:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",353);}
case 353:{f.Locals[1]=f.Pop();f.Pc=354;continue;}
case 354:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"));f.Pc=357;continue;}
case 357:{f.Push(f.Locals[0]);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[1]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",364);}
case 364:{f.StackOp("pop");f.Pc=365;continue;}
case 365:{f.Push(f.Locals[1]);f.Pc=366;continue;}
case 366:{return JStep.Return(f.Pop());}
case 367:{f.Push(f.Locals[2]);f.Pc=368;continue;}
case 368:{f.Push(JValue.R(rt.String("Emblem \u2014 ")));f.Pc=370;continue;}
case 370:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",373);}
case 373:{f.Pc=f.Pop().Int==0?481:376;continue;}
case 376:{f.Push(f.Locals[2]);f.Pc=377;continue;}
case 377:{f.Push(JValue.R(rt.String(" \u2014 ")));f.Pc=380;continue;}
case 380:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",383);}
case 383:{f.Locals[3]=f.Pop();f.Pc=384;continue;}
case 384:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatednames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatednames","Ljava/util/Map;"));f.Pc=387;continue;}
case 387:{f.Push(f.Locals[3]);f.Pc=388;continue;}
case 388:{f.Push(JValue.I(1));f.Pc=389;continue;}
case 389:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=390;continue;}
case 390:{f.Push(JValue.R(rt.String(" ")));f.Pc=393;continue;}
case 393:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",396);}
case 396:{f.Pc=f.Pop().Int==0?418:399;continue;}
case 399:{f.Push(f.Locals[3]);f.Pc=400;continue;}
case 400:{f.Push(JValue.I(1));f.Pc=401;continue;}
case 401:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=402;continue;}
case 402:{f.Push(JValue.I(0));f.Pc=403;continue;}
case 403:{f.Push(f.Locals[3]);f.Pc=404;continue;}
case 404:{f.Push(JValue.I(1));f.Pc=405;continue;}
case 405:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=406;continue;}
case 406:{f.Push(JValue.R(rt.String(" ")));f.Pc=409;continue;}
case 409:{return rt.Call(f,"java/lang/String","lastIndexOf","(Ljava/lang/String;)I","invokevirtual",412);}
case 412:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",415);}
case 415:{f.Pc=421;continue;}
case 418:{f.Push(f.Locals[3]);f.Pc=419;continue;}
case 419:{f.Push(JValue.I(1));f.Pc=420;continue;}
case 420:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=421;continue;}
case 421:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",426);}
case 426:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=429;continue;}
case 429:{f.Locals[1]=f.Pop();f.Pc=430;continue;}
case 430:{f.Push(f.Locals[1]);f.Pc=431;continue;}
case 431:{f.Pc=f.Pop().Reference==null?441:434;continue;}
case 434:{f.Push(f.Locals[1]);f.Pc=435;continue;}
case 435:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",438);}
case 438:{f.Pc=f.Pop().Int==0?446:441;continue;}
case 441:{f.Push(f.Locals[2]);f.Pc=442;continue;}
case 442:{f.Locals[1]=f.Pop();f.Pc=443;continue;}
case 443:{f.Pc=466;continue;}
case 446:{f.Push(f.Locals[1]);f.Pc=447;continue;}
case 447:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",450);}
case 450:{f.Push(JValue.R(rt.String("lblEmblem")));f.Pc=453;continue;}
case 453:{f.Push(JValue.I(0));f.Pc=454;continue;}
case 454:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=457;continue;}
case 457:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",460);}
case 460:{return rt.DynamicCall(f,"forge/util/CardTranslation:11689:460:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",465);}
case 465:{f.Locals[1]=f.Pop();f.Pc=466;continue;}
case 466:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedEffectNames","Ljava/util/Map;"));f.Pc=469;continue;}
case 469:{f.Push(f.Locals[0]);f.Pc=470;continue;}
case 470:{f.Push(f.Locals[1]);f.Pc=471;continue;}
case 471:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",476);}
case 476:{f.StackOp("pop");f.Pc=477;continue;}
case 477:{f.Push(f.Locals[1]);f.Pc=478;continue;}
case 478:{return JStep.Return(f.Pop());}
case 479:{f.Locals[4]=f.Pop();f.Pc=481;continue;}
case 481:{f.Push(f.Locals[0]);f.Pc=482;continue;}
case 482:{return JStep.Return(f.Pop());}
case 483:{f.Push(f.Locals[1]);f.Pc=484;continue;}
case 484:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11690(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/CardTranslation","needsTranslation","()Z","invokestatic",3);}
case 3:{f.Pc=f.Pop().Int==0?29:6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedtypes","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedtypes","Ljava/util/Map;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference!=null?27:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Pc=28;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11691(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/CardTranslation","needsTranslation","()Z","invokestatic",3);}
case 3:{f.Pc=f.Pop().Int!=0?13:6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/util/ITranslatable","getUntranslatedType","()Ljava/lang/String;","invokeinterface",12);}
case 12:{return JStep.Return(f.Pop());}
case 13:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedtypes","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedtypes","Ljava/util/Map;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/util/ITranslatable","getTranslationKey","()Ljava/lang/String;","invokeinterface",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/util/ITranslatable","getUntranslatedType","()Ljava/lang/String;","invokeinterface",28);}
case 28:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11692(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/CardTranslation","needsTranslation","()Z","invokestatic",3);}
case 3:{f.Pc=f.Pop().Int==0?30:6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedoracles","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedoracles","Ljava/util/Map;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{f.Locals[1]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference!=null?28:23;continue;}
case 23:{f.Push(JValue.R(rt.String("")));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
case 30:{f.Push(JValue.R(rt.String("")));f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11693(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/CardTranslation","needsTranslation","()Z","invokestatic",3);}
case 3:{f.Pc=f.Pop().Int!=0?9:6;continue;}
case 6:{f.Push(JValue.R(rt.String("")));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedoracles","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedoracles","Ljava/util/Map;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/util/ITranslatable","getTranslationKey","()Ljava/lang/String;","invokeinterface",18);}
case 18:{f.Push(JValue.R(rt.String("")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11694(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/CardTranslation","getTranslationTexts","(Lforge/util/ITranslatable;Lforge/util/ITranslatable;)Ljava/util/HashMap;","invokestatic",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11695(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/CardTranslation","needsTranslation","()Z","invokestatic",3);}
case 3:{f.Pc=f.Pop().Int!=0?8:6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{return JStep.Return(f.Pop());}
case 8:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("name")));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedName","(Lforge/util/ITranslatable;)Ljava/lang/String;","invokestatic",24);}
case 24:{return rt.Call(f,"java/util/HashMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("oracle")));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedOracle","(Lforge/util/ITranslatable;)Ljava/lang/String;","invokestatic",36);}
case 36:{return rt.Call(f,"java/util/HashMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Pc=f.Pop().Reference!=null?67:44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("altname")));f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/HashMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("altoracle")));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/HashMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{f.Pc=91;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("altname")));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedName","(Lforge/util/ITranslatable;)Ljava/lang/String;","invokestatic",75);}
case 75:{return rt.Call(f,"java/util/HashMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("altoracle")));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedOracle","(Lforge/util/ITranslatable;)Ljava/lang/String;","invokestatic",87);}
case 87:{return rt.Call(f,"java/util/HashMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",90);}
case 90:{f.StackOp("pop");f.Pc=91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11696(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/CardTranslation","languageSelected","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","languageSelected","Ljava/lang/String;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11697(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/CardTranslation","languageSelected","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","languageSelected","Ljava/lang/String;"));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("en-US")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int!=0?15:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{f.Pc=16;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11698(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/util/CardTranslation","languageSelected","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/util/CardTranslation","languageSelected","Ljava/lang/String;",f.Pop());f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/CardTranslation","needsTranslation","()Z","invokestatic",7);}
case 7:{f.Pc=f.Pop().Int==0?77:10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",17);}
case 17:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatednames","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/util/CardTranslation","translatednames","Ljava/util/Map;",f.Pop());f.Pc=20;continue;}
case 20:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",27);}
case 27:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedtypes","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/util/CardTranslation","translatedtypes","Ljava/util/Map;",f.Pop());f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",37);}
case 37:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedoracles","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/util/CardTranslation","translatedoracles","Ljava/util/Map;",f.Pop());f.Pc=40;continue;}
case 40:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=43;continue;}
case 43:{f.StackOp("dup");f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",47);}
case 47:{if(!rt.StaticReady(f,"forge/util/CardTranslation","oracleMappings","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/util/CardTranslation","oracleMappings","Ljava/util/Map;",f.Pop());f.Pc=50;continue;}
case 50:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=53;continue;}
case 53:{f.StackOp("dup");f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",57);}
case 57:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedCaches","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/util/CardTranslation","translatedCaches","Ljava/util/Map;",f.Pop());f.Pc=60;continue;}
case 60:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",67);}
case 67:{if(!rt.StaticReady(f,"forge/util/CardTranslation","sharedCache","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/util/CardTranslation","sharedCache","Ljava/util/Map;",f.Pop());f.Pc=70;continue;}
case 70:{if(!rt.StaticReady(f,"forge/util/CardTranslation","languageSelected","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","languageSelected","Ljava/lang/String;"));f.Pc=73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/util/CardTranslation","readTranslationFile","(Ljava/lang/String;Ljava/lang/String;)V","invokestatic",77);}
case 77:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11699(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("en-US")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?19:9;continue;}
case 9:{return rt.Call(f,"forge/util/Lang","getEnglishInstance","()Lforge/util/Lang;","invokestatic",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/util/Lang","getNickName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",16);}
case 16:{f.Pc=26;continue;}
case 19:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",22);}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/util/Lang","getNickName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",35);}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int!=0?56:45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("NICKNAME")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",54);}
case 54:{f.Locals[4]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11700(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference==null?14:6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.DynamicCall(f,"forge/util/CardTranslation:11700:8:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/util/CardTranslation","needsTranslation","()Z","invokestatic",17);}
case 17:{f.Pc=f.Pop().Int==0?32:20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/util/CardTranslation","oracleMappings","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","oracleMappings","Ljava/util/Map;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?33:32;continue;}
case 32:{return JStep.ReturnVoid;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedOracle","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",37);}
case 37:{f.Locals[4]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?48:47;continue;}
case 47:{return JStep.ReturnVoid;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",52);}
case 52:{f.Locals[5]=f.Pop();f.Pc=54;continue;}
case 54:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",61);}
case 61:{f.Locals[6]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("\\\\n")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",70);}
case 70:{f.Locals[7]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[4]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("\r\n\r\n")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",79);}
case 79:{f.Locals[8]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[7]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[8]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/util/CardTranslation","leadingLineOffset","([Ljava/lang/String;[Ljava/lang/String;)I","invokestatic",88);}
case 88:{f.Locals[9]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(JValue.I(0));f.Pc=91;continue;}
case 91:{f.Locals[10]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[10]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=98;continue;}
case 98:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?197:101;continue;}
case 101:{f.Push(JValue.R(rt.String("en-US")));f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[10]);f.Pc=108;continue;}
case 108:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/util/CardTranslation","replaceCardName","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",112);}
case 112:{f.Locals[11]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[11]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("(")));f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",122);}
case 122:{f.Pc=f.Pop().Int!=0?137:125;continue;}
case 125:{f.Push(f.Locals[11]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("\\(.*\\)")));f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",135);}
case 135:{f.Locals[11]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[10]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[9]);f.Pc=141;continue;}
case 141:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=142;continue;}
case 142:{f.Locals[12]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[12]);f.Pc=146;continue;}
case 146:{f.Pc=f.Pop().Int<0?173:149;continue;}
case 149:{f.Push(f.Locals[12]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[8]);f.Pc=153;continue;}
case 153:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=154;continue;}
case 154:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?173:157;continue;}
case 157:{if(!rt.StaticReady(f,"forge/util/CardTranslation","languageSelected","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","languageSelected","Ljava/lang/String;"));f.Pc=160;continue;}
case 160:{f.Push(f.Locals[5]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[8]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[12]);f.Pc=166;continue;}
case 166:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/util/CardTranslation","replaceCardName","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",170);}
case 170:{f.Pc=174;continue;}
case 173:{f.Push(JValue.R(null));f.Pc=174;continue;}
case 174:{f.Locals[13]=f.Pop();f.Pc=176;continue;}
case 176:{f.Push(f.Locals[6]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[11]);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[13]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",185);}
case 185:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",190);}
case 190:{f.StackOp("pop");f.Pc=191;continue;}
case 191:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=194;continue;}
case 194:{f.Pc=93;continue;}
case 197:{if(!rt.StaticReady(f,"forge/util/CardTranslation","oracleMappings","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","oracleMappings","Ljava/util/Map;"));f.Pc=200;continue;}
case 200:{f.Push(f.Locals[3]);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[6]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",208);}
case 208:{f.StackOp("pop");f.Pc=209;continue;}
case 209:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11701(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4;continue;}
case 4:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?30:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("Enchant ")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int!=0?32:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/util/CardTranslation","isKeywordLine","(Ljava/lang/String;)Z","invokestatic",27);}
case 27:{f.Pc=f.Pop().Int!=0?32:30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{f.Locals[4]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=43;continue;}
case 43:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?100:46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/util/CardTranslation","translationInvariants","(Ljava/lang/String;)Ljava/util/List;","invokestatic",53);}
case 53:{f.Locals[5]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",62);}
case 62:{f.Pc=f.Pop().Int==0?68:65;continue;}
case 65:{f.Pc=94;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=73;continue;}
case 73:{f.Push(f.Locals[5]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/util/CardTranslation","agreement","(Ljava/lang/String;Ljava/util/List;)I","invokestatic",78);}
case 78:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=79;continue;}
case 79:{f.Locals[2]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{f.Push(JValue.I(1));f.Pc=85;continue;}
case 85:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=86;continue;}
case 86:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/util/CardTranslation","agreement","(Ljava/lang/String;Ljava/util/List;)I","invokestatic",92);}
case 92:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=93;continue;}
case 93:{f.Locals[3]=f.Pop();f.Pc=94;continue;}
case 94:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=97;continue;}
case 97:{f.Pc=39;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?109:105;continue;}
case 105:{f.Push(JValue.I(0));f.Pc=106;continue;}
case 106:{f.Pc=110;continue;}
case 109:{f.Push(JValue.I(1));f.Pc=110;continue;}
case 110:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11702(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/CardTranslation","translationInvariants","(Ljava/lang/String;)Ljava/util/List;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",11);}
case 11:{f.Pc=f.Pop().Int==0?18:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Pc=33;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/List","equals","(Ljava/lang/Object;)Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?32:28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Pc=33;continue;}
case 32:{f.Push(JValue.I(-1));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11703(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("\\([^()]*\\)")));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",9);}
case 9:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int!=0?42:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String(".")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int!=0?46:30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("\\s+")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=38;continue;}
case 38:{f.Push(JValue.I(5));f.Pc=39;continue;}
case 39:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?46:42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{f.Pc=47;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11704(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/util/CardTranslation","TRANSLATION_INVARIANT","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","TRANSLATION_INVARIANT","Ljava/util/regex/Pattern;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?37:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/regex/Matcher","group","()Ljava/lang/String;","invokevirtual",28);}
case 28:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{f.Pc=16;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11705(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/CardTranslation","needsTranslation","()Z","invokestatic",3);}
case 3:{f.Pc=f.Pop().Int!=0?8:6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return JStep.Return(f.Pop());}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("\n")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=24;continue;}
case 24:{f.Locals[5]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{f.Locals[6]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[6]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?190:36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[6]);f.Pc=40;continue;}
case 40:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=41;continue;}
case 41:{f.Locals[7]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[7]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Locals[7]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[7]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int==0?61:58;continue;}
case 58:{f.Pc=184;continue;}
case 61:{f.Push(f.Locals[7]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/util/CardTranslation","translateSingleDescriptionText","(Ljava/lang/String;Lforge/util/ITranslatable;)Ljava/lang/String;","invokestatic",67);}
case 67:{f.Locals[8]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[7]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[8]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int!=0?91:79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[7]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[8]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",87);}
case 87:{f.Locals[3]=f.Pop();f.Pc=88;continue;}
case 88:{f.Pc=184;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String(", ")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",99);}
case 99:{f.Locals[9]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[9]);f.Pc=103;continue;}
case 103:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=104;continue;}
case 104:{f.Push(JValue.I(1));f.Pc=105;continue;}
case 105:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?111:108;continue;}
case 108:{f.Pc=184;continue;}
case 111:{f.Push(f.Locals[9]);f.Pc=113;continue;}
case 113:{f.Locals[10]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[10]);f.Pc=117;continue;}
case 117:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=118;continue;}
case 118:{f.Locals[11]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(JValue.I(0));f.Pc=121;continue;}
case 121:{f.Locals[12]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[12]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[11]);f.Pc=127;continue;}
case 127:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?184:130;continue;}
case 130:{f.Push(f.Locals[10]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[12]);f.Pc=134;continue;}
case 134:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=135;continue;}
case 135:{f.Locals[13]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[13]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String(" ")));f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",145);}
case 145:{f.Pc=f.Pop().Int==0?151:148;continue;}
case 148:{f.Pc=178;continue;}
case 151:{f.Push(f.Locals[13]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/util/CardTranslation","translateSingleDescriptionText","(Ljava/lang/String;Lforge/util/ITranslatable;)Ljava/lang/String;","invokestatic",157);}
case 157:{f.Locals[8]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[13]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[8]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",166);}
case 166:{f.Pc=f.Pop().Int!=0?178:169;continue;}
case 169:{f.Push(f.Locals[3]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[13]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[8]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",177);}
case 177:{f.Locals[3]=f.Pop();f.Pc=178;continue;}
case 178:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=181;continue;}
case 181:{f.Pc=123;continue;}
case 184:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=187;continue;}
case 187:{f.Pc=29;continue;}
case 190:{f.Push(f.Locals[3]);f.Pc=191;continue;}
case 191:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11706(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?7:4;continue;}
case 4:{f.Push(JValue.R(rt.String("")));f.Pc=6;continue;}
case 6:{return JStep.Return(f.Pop());}
case 7:{return rt.Call(f,"forge/util/CardTranslation","needsTranslation","()Z","invokestatic",10);}
case 10:{f.Pc=f.Pop().Int!=0?15:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/util/ITranslatable","getTranslationKey","()Ljava/lang/String;","invokeinterface",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{if(!rt.StaticReady(f,"forge/util/CardTranslation","translatedCaches","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","translatedCaches","Ljava/util/Map;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.DynamicCall(f,"forge/util/CardTranslation:11706:26:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",31);}
case 31:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[3]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",47);}
case 47:{f.Pc=f.Pop().Int==0?61:50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{return JStep.Return(f.Pop());}
case 61:{if(!rt.StaticReady(f,"forge/util/CardTranslation","oracleMappings","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","oracleMappings","Ljava/util/Map;"));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{f.Locals[4]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{f.Pc=f.Pop().Reference!=null?94:80;continue;}
case 80:{if(!rt.StaticReady(f,"forge/util/CardTranslation","sharedCache","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","sharedCache","Ljava/util/Map;"));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{return JStep.Return(f.Pop());}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Locals[5]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",104);}
case 104:{f.Pc=f.Pop().Int!=0?115:107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/util/CardTranslation","translateSingleIngameText","(Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;","invokestatic",113);}
case 113:{f.Locals[5]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[3]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[5]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",124);}
case 124:{f.StackOp("pop");f.Pc=125;continue;}
case 125:{f.Push(f.Locals[5]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int!=0?146:134;continue;}
case 134:{if(!rt.StaticReady(f,"forge/util/CardTranslation","sharedCache","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/CardTranslation","sharedCache","Ljava/util/Map;"));f.Pc=137;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[5]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/Map","putIfAbsent","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",145);}
case 145:{f.StackOp("pop");f.Pc=146;continue;}
case 146:{f.Push(f.Locals[5]);f.Pc=148;continue;}
case 148:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11707(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("(")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?14:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Pc=23;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("\\(.*\\)")));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",35);}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{f.Locals[5]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",48);}
case 48:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?122:51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",59);}
case 59:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=62;continue;}
case 62:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Locals[6]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[6]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",75);}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",79);}
case 79:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",82);}
case 82:{f.Push(JValue.I(3));f.Pc=83;continue;}
case 83:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=84;continue;}
case 84:{f.Locals[7]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","getLevenshteinDistance","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I","invokestatic",94);}
case 94:{f.Locals[8]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[8]);f.Pc=98;continue;}
case 98:{f.Push(JValue.I(-1));f.Pc=99;continue;}
case 99:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?116:102;continue;}
case 102:{f.Push(f.Locals[8]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[4]);f.Pc=106;continue;}
case 106:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?116:109;continue;}
case 109:{f.Push(f.Locals[8]);f.Pc=111;continue;}
case 111:{f.Locals[4]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[5]);f.Pc=115;continue;}
case 115:{f.Locals[3]=f.Pop();f.Pc=116;continue;}
case 116:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=119;continue;}
case 119:{f.Pc=40;continue;}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",129);}
case 129:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?162:132;continue;}
case 132:{f.Push(f.Locals[1]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[3]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",139);}
case 139:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=142;continue;}
case 142:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",145);}
case 145:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=148;continue;}
case 148:{f.Locals[5]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[5]);f.Pc=152;continue;}
case 152:{f.Pc=f.Pop().Reference!=null?159:155;continue;}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{f.Pc=161;continue;}
case 159:{f.Push(f.Locals[5]);f.Pc=161;continue;}
case 161:{return JStep.Return(f.Pop());}
case 162:{f.Push(f.Locals[0]);f.Pc=163;continue;}
case 163:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11708(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11709(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(5));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("The Ring")));f.Pc=8;continue;}
case 8:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("The Monarch")));f.Pc=13;continue;}
case 13:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(JValue.I(2));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("The Initiative")));f.Pc=18;continue;}
case 18:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{f.Push(JValue.I(3));f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("City's Blessing")));f.Pc=23;continue;}
case 23:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{f.Push(JValue.I(4));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("Keyword Effects")));f.Pc=29;continue;}
case 29:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",33);}
case 33:{if(!rt.StaticReady(f,"forge/util/CardTranslation","knownEffectNames","Ljava/util/List;"))return JStep.Continue;rt.PutStatic("forge/util/CardTranslation","knownEffectNames","Ljava/util/List;",f.Pop());f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("\\{[^}]{1,6}\\}|[+-]\\d+/[+-]\\d+")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",42);}
case 42:{if(!rt.StaticReady(f,"forge/util/CardTranslation","TRANSLATION_INVARIANT","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/CardTranslation","TRANSLATION_INVARIANT","Ljava/util/regex/Pattern;",f.Pop());f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("en-US")));f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"forge/util/CardTranslation","languageSelected","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/util/CardTranslation","languageSelected","Ljava/lang/String;",f.Pop());f.Pc=50;continue;}
case 50:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
