// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C6{
internal static JClass Build(){var c=new JClass("forge/ImageKeys","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("CARD_PREFIX","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"c:"));
c.Add(new JField("TOKEN_PREFIX","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"t:"));
c.Add(new JField("ICON_PREFIX","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"i:"));
c.Add(new JField("BOOSTER_PREFIX","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"b:"));
c.Add(new JField("FATPACK_PREFIX","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"f:"));
c.Add(new JField("BOOSTERBOX_PREFIX","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"x:"));
c.Add(new JField("PRECON_PREFIX","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"p:"));
c.Add(new JField("TOURNAMENTPACK_PREFIX","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"o:"));
c.Add(new JField("ADVENTURECARD_PREFIX","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"a:"));
c.Add(new JField("HIDDEN_CARD","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"hidden"));
c.Add(new JField("MORPH_IMAGE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"morph"));
c.Add(new JField("MANIFEST_IMAGE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"manifest"));
c.Add(new JField("CLOAKED_IMAGE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"cloaked"));
c.Add(new JField("FORETELL_IMAGE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"foretell"));
c.Add(new JField("BLESSING_IMAGE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"blessing"));
c.Add(new JField("ENDURING_STORY_IMAGE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"enduring_story"));
c.Add(new JField("INITIATIVE_IMAGE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"initiative"));
c.Add(new JField("MONARCH_IMAGE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"monarch"));
c.Add(new JField("THE_RING_IMAGE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"the_ring"));
c.Add(new JField("RADIATION_IMAGE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"radiation"));
c.Add(new JField("SPEED_IMAGE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"speed"));
c.Add(new JField("MAX_SPEED_IMAGE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"max_speed"));
c.Add(new JField("ADVENTURE_IMAGE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"adventure"));
c.Add(new JField("BACKFACE_POSTFIX","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"$alt"));
c.Add(new JField("SPECFACE_W","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"$wspec"));
c.Add(new JField("SPECFACE_U","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"$uspec"));
c.Add(new JField("SPECFACE_B","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"$bspec"));
c.Add(new JField("SPECFACE_R","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"$rspec"));
c.Add(new JField("SPECFACE_G","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"$gspec"));
c.Add(new JField("CACHE_CARD_PICS_DIR","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("CACHE_TOKEN_PICS_DIR","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("CACHE_ICON_PICS_DIR","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("CACHE_BOOSTER_PICS_DIR","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("CACHE_FATPACK_PICS_DIR","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("CACHE_BOOSTERBOX_PICS_DIR","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("CACHE_PRECON_PICS_DIR","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("CACHE_TOURNAMENTPACK_PICS_DIR","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("ADVENTURE_CARD_PICS_DIR","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("CACHE_CARD_PICS_SUBDIR","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("editionImageLookup","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("editionAlias","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("toFind","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("isLibGDXPort","Z",true,JValue.Default("Z"),null));
c.Add(new JField("FILE_EXTENSIONS","[Ljava/lang/String;",true,JValue.Default("[Ljava/lang/String;"),null));
c.Add(new JField("cachedCards","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("missingCards","Ljava/util/HashSet;",true,JValue.Default("Ljava/util/HashSet;"),null));
c.Add(new JField("cachedContent","Ljava/util/HashMap;",true,JValue.Default("Ljava/util/HashMap;"),null));
c.Add(new JMethod(38,"forge/ImageKeys","<init>","()V",2,1,1,new JHandler[]{},M38));
c.Add(new JMethod(39,"forge/ImageKeys","setIsLibGDXPort","(Z)V",9,1,1,new JHandler[]{},M39));
c.Add(new JMethod(40,"forge/ImageKeys","initializeDirs","(Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",9,9,1,new JHandler[]{},M40));
c.Add(new JMethod(41,"forge/ImageKeys","getTokenKey","(Ljava/lang/String;)Ljava/lang/String;",9,1,1,new JHandler[]{},M41));
c.Add(new JMethod(42,"forge/ImageKeys","getTokenImageName","(Ljava/lang/String;)Ljava/lang/String;",9,1,2,new JHandler[]{},M42));
c.Add(new JMethod(43,"forge/ImageKeys","clearMissingCards","()V",9,0,1,new JHandler[]{},M43));
c.Add(new JMethod(44,"forge/ImageKeys","getCachedCardsFile","(Ljava/lang/String;)Ljava/io/File;",9,1,2,new JHandler[]{},M44));
c.Add(new JMethod(45,"forge/ImageKeys","getImageFile","(Ljava/lang/String;)Ljava/io/File;",9,12,4,new JHandler[]{new JHandler(731,748,751,"java/lang/Exception")},M45));
c.Add(new JMethod(46,"forge/ImageKeys","getSetFolder","(Ljava/lang/String;)Ljava/lang/String;",9,1,2,new JHandler[]{},M46));
c.Add(new JMethod(47,"forge/ImageKeys","hasSetLookup","(Ljava/lang/String;)Z",9,1,3,new JHandler[]{},M47));
c.Add(new JMethod(48,"forge/ImageKeys","setLookUpFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;",9,17,4,new JHandler[]{},M48));
c.Add(new JMethod(49,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;",10,7,5,new JHandler[]{},M49));
c.Add(new JMethod(50,"forge/ImageKeys","hasImage","(Lforge/item/PaperCard;)Z",9,1,2,new JHandler[]{},M50));
c.Add(new JMethod(51,"forge/ImageKeys","hasImage","(Lforge/item/PaperCard;Z)Z",9,11,5,new JHandler[]{new JHandler(401,425,428,"java/lang/Exception")},M51));
c.Add(new JMethod(52,"forge/ImageKeys","hitCache","(Ljava/util/HashSet;Ljava/lang/String;)Z",10,3,2,new JHandler[]{},M52));
c.Add(new JMethod(53,"forge/ImageKeys","lambda$getImageFile$0","(Ljava/lang/String;Ljava/lang/String;)V",4106,3,3,new JHandler[]{},M53));
c.Add(new JMethod(54,"forge/ImageKeys","<clinit>","()V",8,0,4,new JHandler[]{},M54));
}

internal static JStep M38(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M39(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/ImageKeys","isLibGDXPort","Z"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","isLibGDXPort","Z",f.Pop());f.Pc=4;continue;}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M40(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_CARD_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","CACHE_CARD_PICS_DIR","Ljava/lang/String;",f.Pop());f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_CARD_PICS_SUBDIR","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","CACHE_CARD_PICS_SUBDIR","Ljava/util/Map;",f.Pop());f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_TOKEN_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","CACHE_TOKEN_PICS_DIR","Ljava/lang/String;",f.Pop());f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_ICON_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","CACHE_ICON_PICS_DIR","Ljava/lang/String;",f.Pop());f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_BOOSTER_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","CACHE_BOOSTER_PICS_DIR","Ljava/lang/String;",f.Pop());f.Pc=21;continue;}
case 21:{f.Push(f.Locals[5]);f.Pc=23;continue;}
case 23:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_FATPACK_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","CACHE_FATPACK_PICS_DIR","Ljava/lang/String;",f.Pop());f.Pc=26;continue;}
case 26:{f.Push(f.Locals[6]);f.Pc=28;continue;}
case 28:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_BOOSTERBOX_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","CACHE_BOOSTERBOX_PICS_DIR","Ljava/lang/String;",f.Pop());f.Pc=31;continue;}
case 31:{f.Push(f.Locals[7]);f.Pc=33;continue;}
case 33:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_PRECON_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","CACHE_PRECON_PICS_DIR","Ljava/lang/String;",f.Pop());f.Pc=36;continue;}
case 36:{f.Push(f.Locals[8]);f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_TOURNAMENTPACK_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","CACHE_TOURNAMENTPACK_PICS_DIR","Ljava/lang/String;",f.Pop());f.Pc=41;continue;}
case 41:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M41(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/ImageKeys:41:1:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M42(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("t:")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int!=0?11:9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("t:")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",17);}
case 17:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",20);}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M43(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/ImageKeys","missingCards","Ljava/util/HashSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","missingCards","Ljava/util/HashSet;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/HashSet","clear","()V","invokevirtual",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M44(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/io/File"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M45(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("t:")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?86:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("t:")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",26);}
case 26:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",29);}
case 29:{f.Push(JValue.R(rt.String("\\|")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=38;continue;}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?58:46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=51;continue;}
case 51:{return rt.DynamicCall(f,"forge/ImageKeys:45:51:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",56);}
case 56:{f.Locals[4]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=60;continue;}
case 60:{f.Push(JValue.I(2));f.Pc=61;continue;}
case 61:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?76:64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{f.Push(JValue.I(2));f.Pc=68;continue;}
case 68:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=69;continue;}
case 69:{return rt.DynamicCall(f,"forge/ImageKeys:45:69:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",74);}
case 74:{f.Locals[4]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{f.Locals[2]=f.Pop();f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_TOKEN_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","CACHE_TOKEN_PICS_DIR","Ljava/lang/String;"));f.Pc=82;continue;}
case 82:{f.Locals[1]=f.Pop();f.Pc=83;continue;}
case 83:{f.Pc=274;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("i:")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int==0?112:95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("i:")));f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",101);}
case 101:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",104);}
case 104:{f.Locals[2]=f.Pop();f.Pc=105;continue;}
case 105:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_ICON_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","CACHE_ICON_PICS_DIR","Ljava/lang/String;"));f.Pc=108;continue;}
case 108:{f.Locals[1]=f.Pop();f.Pc=109;continue;}
case 109:{f.Pc=274;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(JValue.R(rt.String("b:")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int==0?138:121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("b:")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",127);}
case 127:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",130);}
case 130:{f.Locals[2]=f.Pop();f.Pc=131;continue;}
case 131:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_BOOSTER_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","CACHE_BOOSTER_PICS_DIR","Ljava/lang/String;"));f.Pc=134;continue;}
case 134:{f.Locals[1]=f.Pop();f.Pc=135;continue;}
case 135:{f.Pc=274;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("f:")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Int==0?164:147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(JValue.R(rt.String("f:")));f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",153);}
case 153:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",156);}
case 156:{f.Locals[2]=f.Pop();f.Pc=157;continue;}
case 157:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_FATPACK_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","CACHE_FATPACK_PICS_DIR","Ljava/lang/String;"));f.Pc=160;continue;}
case 160:{f.Locals[1]=f.Pop();f.Pc=161;continue;}
case 161:{f.Pc=274;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("x:")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",170);}
case 170:{f.Pc=f.Pop().Int==0?190:173;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("x:")));f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",179);}
case 179:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",182);}
case 182:{f.Locals[2]=f.Pop();f.Pc=183;continue;}
case 183:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_BOOSTERBOX_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","CACHE_BOOSTERBOX_PICS_DIR","Ljava/lang/String;"));f.Pc=186;continue;}
case 186:{f.Locals[1]=f.Pop();f.Pc=187;continue;}
case 187:{f.Pc=274;continue;}
case 190:{f.Push(f.Locals[0]);f.Pc=191;continue;}
case 191:{f.Push(JValue.R(rt.String("p:")));f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",196);}
case 196:{f.Pc=f.Pop().Int==0?216:199;continue;}
case 199:{f.Push(f.Locals[0]);f.Pc=200;continue;}
case 200:{f.Push(JValue.R(rt.String("p:")));f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",205);}
case 205:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",208);}
case 208:{f.Locals[2]=f.Pop();f.Pc=209;continue;}
case 209:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_PRECON_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","CACHE_PRECON_PICS_DIR","Ljava/lang/String;"));f.Pc=212;continue;}
case 212:{f.Locals[1]=f.Pop();f.Pc=213;continue;}
case 213:{f.Pc=274;continue;}
case 216:{f.Push(f.Locals[0]);f.Pc=217;continue;}
case 217:{f.Push(JValue.R(rt.String("o:")));f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",222);}
case 222:{f.Pc=f.Pop().Int==0?242:225;continue;}
case 225:{f.Push(f.Locals[0]);f.Pc=226;continue;}
case 226:{f.Push(JValue.R(rt.String("o:")));f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",231);}
case 231:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",234);}
case 234:{f.Locals[2]=f.Pop();f.Pc=235;continue;}
case 235:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_TOURNAMENTPACK_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","CACHE_TOURNAMENTPACK_PICS_DIR","Ljava/lang/String;"));f.Pc=238;continue;}
case 238:{f.Locals[1]=f.Pop();f.Pc=239;continue;}
case 239:{f.Pc=274;continue;}
case 242:{f.Push(f.Locals[0]);f.Pc=243;continue;}
case 243:{f.Push(JValue.R(rt.String("a:")));f.Pc=245;continue;}
case 245:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",248);}
case 248:{f.Pc=f.Pop().Int==0?268:251;continue;}
case 251:{f.Push(f.Locals[0]);f.Pc=252;continue;}
case 252:{f.Push(JValue.R(rt.String("a:")));f.Pc=254;continue;}
case 254:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",257);}
case 257:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",260);}
case 260:{f.Locals[2]=f.Pop();f.Pc=261;continue;}
case 261:{if(!rt.StaticReady(f,"forge/ImageKeys","ADVENTURE_CARD_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","ADVENTURE_CARD_PICS_DIR","Ljava/lang/String;"));f.Pc=264;continue;}
case 264:{f.Locals[1]=f.Pop();f.Pc=265;continue;}
case 265:{f.Pc=274;continue;}
case 268:{f.Push(f.Locals[0]);f.Pc=269;continue;}
case 269:{f.Locals[2]=f.Pop();f.Pc=270;continue;}
case 270:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_CARD_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","CACHE_CARD_PICS_DIR","Ljava/lang/String;"));f.Pc=273;continue;}
case 273:{f.Locals[1]=f.Pop();f.Pc=274;continue;}
case 274:{if(!rt.StaticReady(f,"forge/ImageKeys","toFind","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","toFind","Ljava/util/Set;"));f.Pc=277;continue;}
case 277:{f.Push(f.Locals[2]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",283);}
case 283:{f.Pc=f.Pop().Int==0?288:286;continue;}
case 286:{f.Push(JValue.R(null));f.Pc=287;continue;}
case 287:{return JStep.Return(f.Pop());}
case 288:{if(!rt.StaticReady(f,"forge/ImageKeys","missingCards","Ljava/util/HashSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","missingCards","Ljava/util/HashSet;"));f.Pc=291;continue;}
case 291:{f.Push(f.Locals[2]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"java/util/HashSet","contains","(Ljava/lang/Object;)Z","invokevirtual",295);}
case 295:{f.Pc=f.Pop().Int==0?300:298;continue;}
case 298:{f.Push(JValue.R(null));f.Pc=299;continue;}
case 299:{return JStep.Return(f.Pop());}
case 300:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=303;continue;}
case 303:{f.Push(f.Locals[2]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",309);}
case 309:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/io/File"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=312;continue;}
case 312:{f.Locals[4]=f.Pop();f.Pc=314;continue;}
case 314:{f.Push(f.Locals[4]);f.Pc=316;continue;}
case 316:{f.Pc=f.Pop().Reference==null?322:319;continue;}
case 319:{f.Push(f.Locals[4]);f.Pc=321;continue;}
case 321:{return JStep.Return(f.Pop());}
case 322:{f.Push(f.Locals[1]);f.Pc=323;continue;}
case 323:{f.Push(f.Locals[2]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",327);}
case 327:{f.Locals[5]=f.Pop();f.Pc=329;continue;}
case 329:{f.Push(f.Locals[5]);f.Pc=331;continue;}
case 331:{f.Pc=f.Pop().Reference==null?349:334;continue;}
case 334:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=337;continue;}
case 337:{f.Push(f.Locals[2]);f.Pc=338;continue;}
case 338:{f.Push(f.Locals[5]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",345);}
case 345:{f.StackOp("pop");f.Pc=346;continue;}
case 346:{f.Push(f.Locals[5]);f.Pc=348;continue;}
case 348:{return JStep.Return(f.Pop());}
case 349:{f.Push(f.Locals[1]);f.Pc=350;continue;}
case 350:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_TOKEN_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","CACHE_TOKEN_PICS_DIR","Ljava/lang/String;"));f.Pc=353;continue;}
case 353:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",356);}
case 356:{f.Pc=f.Pop().Int==0?512:359;continue;}
case 359:{f.Push(f.Locals[3]);f.Pc=360;continue;}
case 360:{f.Push(JValue.I(0));f.Pc=361;continue;}
case 361:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=362;continue;}
case 362:{f.Locals[6]=f.Pop();f.Pc=364;continue;}
case 364:{f.Push(f.Locals[3]);f.Pc=365;continue;}
case 365:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=366;continue;}
case 366:{f.Push(JValue.I(1));f.Pc=367;continue;}
case 367:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?376:370;continue;}
case 370:{f.Push(f.Locals[3]);f.Pc=371;continue;}
case 371:{f.Push(JValue.I(1));f.Pc=372;continue;}
case 372:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=373;continue;}
case 373:{f.Pc=378;continue;}
case 376:{f.Push(JValue.R(rt.String("")));f.Pc=378;continue;}
case 378:{f.Locals[7]=f.Pop();f.Pc=380;continue;}
case 380:{f.Push(f.Locals[3]);f.Pc=381;continue;}
case 381:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=382;continue;}
case 382:{f.Push(JValue.I(2));f.Pc=383;continue;}
case 383:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?392:386;continue;}
case 386:{f.Push(f.Locals[3]);f.Pc=387;continue;}
case 387:{f.Push(JValue.I(2));f.Pc=388;continue;}
case 388:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=389;continue;}
case 389:{f.Pc=394;continue;}
case 392:{f.Push(JValue.R(rt.String("")));f.Pc=394;continue;}
case 394:{f.Locals[8]=f.Pop();f.Pc=396;continue;}
case 396:{f.Push(f.Locals[7]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",401);}
case 401:{f.Pc=f.Pop().Int!=0?484:404;continue;}
case 404:{f.Push(f.Locals[8]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",409);}
case 409:{f.Pc=f.Pop().Int!=0?449:412;continue;}
case 412:{f.Push(f.Locals[1]);f.Pc=413;continue;}
case 413:{f.Push(f.Locals[7]);f.Pc=415;continue;}
case 415:{f.Push(f.Locals[8]);f.Pc=417;continue;}
case 417:{f.Push(f.Locals[6]);f.Pc=419;continue;}
case 419:{return rt.DynamicCall(f,"forge/ImageKeys:45:419:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",424);}
case 424:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",427);}
case 427:{f.Locals[5]=f.Pop();f.Pc=429;continue;}
case 429:{f.Push(f.Locals[5]);f.Pc=431;continue;}
case 431:{f.Pc=f.Pop().Reference==null?449:434;continue;}
case 434:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=437;continue;}
case 437:{f.Push(f.Locals[2]);f.Pc=438;continue;}
case 438:{f.Push(f.Locals[5]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",445);}
case 445:{f.StackOp("pop");f.Pc=446;continue;}
case 446:{f.Push(f.Locals[5]);f.Pc=448;continue;}
case 448:{return JStep.Return(f.Pop());}
case 449:{f.Push(f.Locals[1]);f.Pc=450;continue;}
case 450:{f.Push(f.Locals[7]);f.Pc=452;continue;}
case 452:{f.Push(f.Locals[6]);f.Pc=454;continue;}
case 454:{return rt.DynamicCall(f,"forge/ImageKeys:45:454:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",459);}
case 459:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",462);}
case 462:{f.Locals[5]=f.Pop();f.Pc=464;continue;}
case 464:{f.Push(f.Locals[5]);f.Pc=466;continue;}
case 466:{f.Pc=f.Pop().Reference==null?484:469;continue;}
case 469:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=472;continue;}
case 472:{f.Push(f.Locals[2]);f.Pc=473;continue;}
case 473:{f.Push(f.Locals[5]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",480);}
case 480:{f.StackOp("pop");f.Pc=481;continue;}
case 481:{f.Push(f.Locals[5]);f.Pc=483;continue;}
case 483:{return JStep.Return(f.Pop());}
case 484:{f.Push(f.Locals[1]);f.Pc=485;continue;}
case 485:{f.Push(f.Locals[6]);f.Pc=487;continue;}
case 487:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",490);}
case 490:{f.Locals[5]=f.Pop();f.Pc=492;continue;}
case 492:{f.Push(f.Locals[5]);f.Pc=494;continue;}
case 494:{f.Pc=f.Pop().Reference==null?512:497;continue;}
case 497:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=500;continue;}
case 500:{f.Push(f.Locals[2]);f.Pc=501;continue;}
case 501:{f.Push(f.Locals[5]);f.Pc=503;continue;}
case 503:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",508);}
case 508:{f.StackOp("pop");f.Pc=509;continue;}
case 509:{f.Push(f.Locals[5]);f.Pc=511;continue;}
case 511:{return JStep.Return(f.Pop());}
case 512:{f.Push(f.Locals[2]);f.Pc=513;continue;}
case 513:{f.Push(JValue.R(rt.String("Ae")));f.Pc=515;continue;}
case 515:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",518);}
case 518:{f.Pc=f.Pop().Int==0?555:521;continue;}
case 521:{f.Push(f.Locals[1]);f.Pc=522;continue;}
case 522:{f.Push(f.Locals[2]);f.Pc=523;continue;}
case 523:{f.Push(JValue.R(rt.String("Ae")));f.Pc=525;continue;}
case 525:{f.Push(JValue.R(rt.String("AE")));f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",530);}
case 530:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",533);}
case 533:{f.Locals[5]=f.Pop();f.Pc=535;continue;}
case 535:{f.Push(f.Locals[5]);f.Pc=537;continue;}
case 537:{f.Pc=f.Pop().Reference==null?598:540;continue;}
case 540:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=543;continue;}
case 543:{f.Push(f.Locals[2]);f.Pc=544;continue;}
case 544:{f.Push(f.Locals[5]);f.Pc=546;continue;}
case 546:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",551);}
case 551:{f.StackOp("pop");f.Pc=552;continue;}
case 552:{f.Push(f.Locals[5]);f.Pc=554;continue;}
case 554:{return JStep.Return(f.Pop());}
case 555:{f.Push(f.Locals[2]);f.Pc=556;continue;}
case 556:{f.Push(JValue.R(rt.String("AE")));f.Pc=558;continue;}
case 558:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",561);}
case 561:{f.Pc=f.Pop().Int==0?598:564;continue;}
case 564:{f.Push(f.Locals[1]);f.Pc=565;continue;}
case 565:{f.Push(f.Locals[2]);f.Pc=566;continue;}
case 566:{f.Push(JValue.R(rt.String("AE")));f.Pc=568;continue;}
case 568:{f.Push(JValue.R(rt.String("Ae")));f.Pc=570;continue;}
case 570:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",573);}
case 573:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",576);}
case 576:{f.Locals[5]=f.Pop();f.Pc=578;continue;}
case 578:{f.Push(f.Locals[5]);f.Pc=580;continue;}
case 580:{f.Pc=f.Pop().Reference==null?598:583;continue;}
case 583:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=586;continue;}
case 586:{f.Push(f.Locals[2]);f.Pc=587;continue;}
case 587:{f.Push(f.Locals[5]);f.Pc=589;continue;}
case 589:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",594);}
case 594:{f.StackOp("pop");f.Pc=595;continue;}
case 595:{f.Push(f.Locals[5]);f.Pc=597;continue;}
case 597:{return JStep.Return(f.Pop());}
case 598:{f.Push(f.Locals[2]);f.Pc=599;continue;}
case 599:{f.Push(JValue.R(rt.String(".full")));f.Pc=601;continue;}
case 601:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",604);}
case 604:{f.Pc=f.Pop().Int==0?945:607;continue;}
case 607:{f.Push(f.Locals[2]);f.Pc=608;continue;}
case 608:{f.Push(JValue.R(rt.String(".full")));f.Pc=610;continue;}
case 610:{f.Push(JValue.R(rt.String(".fullborder")));f.Pc=612;continue;}
case 612:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",615);}
case 615:{f.Locals[6]=f.Pop();f.Pc=617;continue;}
case 617:{f.Push(f.Locals[1]);f.Pc=618;continue;}
case 618:{f.Push(f.Locals[6]);f.Pc=620;continue;}
case 620:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",623);}
case 623:{f.Locals[5]=f.Pop();f.Pc=625;continue;}
case 625:{f.Push(f.Locals[5]);f.Pc=627;continue;}
case 627:{f.Pc=f.Pop().Reference==null?645:630;continue;}
case 630:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=633;continue;}
case 633:{f.Push(f.Locals[2]);f.Pc=634;continue;}
case 634:{f.Push(f.Locals[5]);f.Pc=636;continue;}
case 636:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",641);}
case 641:{f.StackOp("pop");f.Pc=642;continue;}
case 642:{f.Push(f.Locals[5]);f.Pc=644;continue;}
case 644:{return JStep.Return(f.Pop());}
case 645:{f.Push(f.Locals[1]);f.Pc=646;continue;}
case 646:{f.Push(f.Locals[6]);f.Pc=648;continue;}
case 648:{f.Push(JValue.R(rt.String("1.fullborder")));f.Pc=650;continue;}
case 650:{f.Push(JValue.R(rt.String(".fullborder")));f.Pc=652;continue;}
case 652:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",655);}
case 655:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",658);}
case 658:{f.Locals[5]=f.Pop();f.Pc=660;continue;}
case 660:{f.Push(f.Locals[5]);f.Pc=662;continue;}
case 662:{f.Pc=f.Pop().Reference==null?680:665;continue;}
case 665:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=668;continue;}
case 668:{f.Push(f.Locals[2]);f.Pc=669;continue;}
case 669:{f.Push(f.Locals[5]);f.Pc=671;continue;}
case 671:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",676);}
case 676:{f.StackOp("pop");f.Pc=677;continue;}
case 677:{f.Push(f.Locals[5]);f.Pc=679;continue;}
case 679:{return JStep.Return(f.Pop());}
case 680:{f.Push(f.Locals[1]);f.Pc=681;continue;}
case 681:{f.Push(f.Locals[2]);f.Pc=682;continue;}
case 682:{f.Push(JValue.R(rt.String("[0-9].full")));f.Pc=684;continue;}
case 684:{f.Push(JValue.R(rt.String(".full")));f.Pc=686;continue;}
case 686:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",689);}
case 689:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",692);}
case 692:{f.Locals[5]=f.Pop();f.Pc=694;continue;}
case 694:{f.Push(f.Locals[5]);f.Pc=696;continue;}
case 696:{f.Pc=f.Pop().Reference==null?714:699;continue;}
case 699:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=702;continue;}
case 702:{f.Push(f.Locals[2]);f.Pc=703;continue;}
case 703:{f.Push(f.Locals[5]);f.Pc=705;continue;}
case 705:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",710);}
case 710:{f.StackOp("pop");f.Pc=711;continue;}
case 711:{f.Push(f.Locals[5]);f.Pc=713;continue;}
case 713:{return JStep.Return(f.Pop());}
case 714:{f.Push(f.Locals[2]);f.Pc=715;continue;}
case 715:{return rt.Call(f,"forge/ImageKeys","hasSetLookup","(Ljava/lang/String;)Z","invokestatic",718);}
case 718:{f.Pc=f.Pop().Int==0?763:721;continue;}
case 721:{if(!rt.StaticReady(f,"forge/ImageKeys","toFind","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","toFind","Ljava/util/Set;"));f.Pc=724;continue;}
case 724:{f.Push(f.Locals[2]);f.Pc=725;continue;}
case 725:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",730);}
case 730:{f.StackOp("pop");f.Pc=731;continue;}
case 731:{return rt.Call(f,"forge/util/ThreadUtil","getServicePool","()Ljava/util/concurrent/ExecutorService;","invokestatic",734);}
case 734:{f.Push(f.Locals[2]);f.Pc=735;continue;}
case 735:{f.Push(f.Locals[6]);f.Pc=737;continue;}
case 737:{return rt.DynamicCall(f,"forge/ImageKeys:45:737:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Runnable;",742);}
case 742:{return rt.Call(f,"java/util/concurrent/ExecutorService","submit","(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;","invokeinterface",747);}
case 747:{f.StackOp("pop");f.Pc=748;continue;}
case 748:{f.Pc=763;continue;}
case 751:{f.Locals[7]=f.Pop();f.Pc=753;continue;}
case 753:{if(!rt.StaticReady(f,"forge/ImageKeys","toFind","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","toFind","Ljava/util/Set;"));f.Pc=756;continue;}
case 756:{f.Push(f.Locals[2]);f.Pc=757;continue;}
case 757:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",762);}
case 762:{f.StackOp("pop");f.Pc=763;continue;}
case 763:{f.Push(f.Locals[2]);f.Pc=764;continue;}
case 764:{f.Push(JValue.R(rt.String("/")));f.Pc=766;continue;}
case 766:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",769);}
case 769:{f.Pc=f.Pop().Int==0?786:772;continue;}
case 772:{f.Push(f.Locals[2]);f.Pc=773;continue;}
case 773:{f.Push(JValue.I(0));f.Pc=774;continue;}
case 774:{f.Push(f.Locals[2]);f.Pc=775;continue;}
case 775:{f.Push(JValue.R(rt.String("/")));f.Pc=777;continue;}
case 777:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",780);}
case 780:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",783);}
case 783:{f.Pc=788;continue;}
case 786:{f.Push(JValue.R(rt.String("")));f.Pc=788;continue;}
case 788:{f.Locals[7]=f.Pop();f.Pc=790;continue;}
case 790:{f.Push(f.Locals[7]);f.Pc=792;continue;}
case 792:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",795);}
case 795:{f.Pc=f.Pop().Int!=0?945:798;continue;}
case 798:{if(!rt.StaticReady(f,"forge/ImageKeys","editionAlias","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","editionAlias","Ljava/util/Map;"));f.Pc=801;continue;}
case 801:{f.Push(f.Locals[7]);f.Pc=803;continue;}
case 803:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",808);}
case 808:{f.Pc=f.Pop().Int==0?945:811;continue;}
case 811:{if(!rt.StaticReady(f,"forge/ImageKeys","editionAlias","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","editionAlias","Ljava/util/Map;"));f.Pc=814;continue;}
case 814:{f.Push(f.Locals[7]);f.Pc=816;continue;}
case 816:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",821);}
case 821:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=824;continue;}
case 824:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",829);}
case 829:{f.Locals[8]=f.Pop();f.Pc=831;continue;}
case 831:{f.Push(f.Locals[8]);f.Pc=833;continue;}
case 833:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",838);}
case 838:{f.Pc=f.Pop().Int==0?945:841;continue;}
case 841:{f.Push(f.Locals[8]);f.Pc=843;continue;}
case 843:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",848);}
case 848:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=851;continue;}
case 851:{f.Locals[9]=f.Pop();f.Pc=853;continue;}
case 853:{f.Push(f.Locals[1]);f.Pc=854;continue;}
case 854:{f.Push(f.Locals[2]);f.Pc=855;continue;}
case 855:{f.Push(f.Locals[7]);f.Pc=857;continue;}
case 857:{return rt.DynamicCall(f,"forge/ImageKeys:45:857:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",862);}
case 862:{f.Push(f.Locals[9]);f.Pc=864;continue;}
case 864:{return rt.DynamicCall(f,"forge/ImageKeys:45:864:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",869);}
case 869:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",872);}
case 872:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",875);}
case 875:{f.Locals[5]=f.Pop();f.Pc=877;continue;}
case 877:{f.Push(f.Locals[5]);f.Pc=879;continue;}
case 879:{f.Pc=f.Pop().Reference==null?897:882;continue;}
case 882:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=885;continue;}
case 885:{f.Push(f.Locals[2]);f.Pc=886;continue;}
case 886:{f.Push(f.Locals[5]);f.Pc=888;continue;}
case 888:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",893);}
case 893:{f.StackOp("pop");f.Pc=894;continue;}
case 894:{f.Push(f.Locals[5]);f.Pc=896;continue;}
case 896:{return JStep.Return(f.Pop());}
case 897:{f.Push(f.Locals[1]);f.Pc=898;continue;}
case 898:{f.Push(f.Locals[6]);f.Pc=900;continue;}
case 900:{f.Push(f.Locals[7]);f.Pc=902;continue;}
case 902:{return rt.DynamicCall(f,"forge/ImageKeys:45:902:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",907);}
case 907:{f.Push(f.Locals[9]);f.Pc=909;continue;}
case 909:{return rt.DynamicCall(f,"forge/ImageKeys:45:909:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",914);}
case 914:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",917);}
case 917:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",920);}
case 920:{f.Locals[5]=f.Pop();f.Pc=922;continue;}
case 922:{f.Push(f.Locals[5]);f.Pc=924;continue;}
case 924:{f.Pc=f.Pop().Reference==null?942:927;continue;}
case 927:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=930;continue;}
case 930:{f.Push(f.Locals[2]);f.Pc=931;continue;}
case 931:{f.Push(f.Locals[5]);f.Pc=933;continue;}
case 933:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",938);}
case 938:{f.StackOp("pop");f.Pc=939;continue;}
case 939:{f.Push(f.Locals[5]);f.Pc=941;continue;}
case 941:{return JStep.Return(f.Pop());}
case 942:{f.Pc=831;continue;}
case 945:{f.Push(f.Locals[2]);f.Pc=946;continue;}
case 946:{f.Push(JValue.R(rt.String(".full")));f.Pc=948;continue;}
case 948:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",951);}
case 951:{f.Pc=f.Pop().Int!=0?1018:954;continue;}
case 954:{f.Push(f.Locals[1]);f.Pc=955;continue;}
case 955:{f.Push(f.Locals[2]);f.Pc=956;continue;}
case 956:{f.Push(JValue.R(rt.String(".full")));f.Pc=958;continue;}
case 958:{return rt.Call(f,"forge/util/TextUtil","addSuffix","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",961);}
case 961:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",964);}
case 964:{f.Locals[5]=f.Pop();f.Pc=966;continue;}
case 966:{f.Push(f.Locals[5]);f.Pc=968;continue;}
case 968:{f.Pc=f.Pop().Reference==null?986:971;continue;}
case 971:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=974;continue;}
case 974:{f.Push(f.Locals[2]);f.Pc=975;continue;}
case 975:{f.Push(f.Locals[5]);f.Pc=977;continue;}
case 977:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",982);}
case 982:{f.StackOp("pop");f.Pc=983;continue;}
case 983:{f.Push(f.Locals[5]);f.Pc=985;continue;}
case 985:{return JStep.Return(f.Pop());}
case 986:{f.Push(f.Locals[1]);f.Pc=987;continue;}
case 987:{f.Push(f.Locals[2]);f.Pc=988;continue;}
case 988:{f.Push(JValue.R(rt.String(".fullborder")));f.Pc=990;continue;}
case 990:{return rt.Call(f,"forge/util/TextUtil","addSuffix","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",993);}
case 993:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",996);}
case 996:{f.Locals[5]=f.Pop();f.Pc=998;continue;}
case 998:{f.Push(f.Locals[5]);f.Pc=1000;continue;}
case 1000:{f.Pc=f.Pop().Reference==null?1018:1003;continue;}
case 1003:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=1006;continue;}
case 1006:{f.Push(f.Locals[2]);f.Pc=1007;continue;}
case 1007:{f.Push(f.Locals[5]);f.Pc=1009;continue;}
case 1009:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1014);}
case 1014:{f.StackOp("pop");f.Pc=1015;continue;}
case 1015:{f.Push(f.Locals[5]);f.Pc=1017;continue;}
case 1017:{return JStep.Return(f.Pop());}
case 1018:{f.Push(f.Locals[2]);f.Pc=1019;continue;}
case 1019:{f.Push(JValue.R(rt.String("/")));f.Pc=1021;continue;}
case 1021:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",1024);}
case 1024:{f.Pc=f.Pop().Int==0?1403:1027;continue;}
case 1027:{f.Push(f.Locals[2]);f.Pc=1028;continue;}
case 1028:{f.Push(f.Locals[2]);f.Pc=1029;continue;}
case 1029:{f.Push(JValue.I(47));f.Pc=1031;continue;}
case 1031:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1034);}
case 1034:{f.Push(JValue.I(1));f.Pc=1035;continue;}
case 1035:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1036;continue;}
case 1036:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1039);}
case 1039:{f.Locals[6]=f.Pop();f.Pc=1041;continue;}
case 1041:{f.Push(f.Locals[1]);f.Pc=1042;continue;}
case 1042:{f.Push(f.Locals[6]);f.Pc=1044;continue;}
case 1044:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",1047);}
case 1047:{f.Locals[5]=f.Pop();f.Pc=1049;continue;}
case 1049:{f.Push(f.Locals[5]);f.Pc=1051;continue;}
case 1051:{f.Pc=f.Pop().Reference==null?1069:1054;continue;}
case 1054:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=1057;continue;}
case 1057:{f.Push(f.Locals[2]);f.Pc=1058;continue;}
case 1058:{f.Push(f.Locals[5]);f.Pc=1060;continue;}
case 1060:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1065);}
case 1065:{f.StackOp("pop");f.Pc=1066;continue;}
case 1066:{f.Push(f.Locals[5]);f.Pc=1068;continue;}
case 1068:{return JStep.Return(f.Pop());}
case 1069:{f.Push(f.Locals[6]);f.Pc=1071;continue;}
case 1071:{f.Push(JValue.R(rt.String(".full")));f.Pc=1073;continue;}
case 1073:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",1076);}
case 1076:{f.Pc=f.Pop().Int==0?1153:1079;continue;}
case 1079:{f.Push(f.Locals[6]);f.Pc=1081;continue;}
case 1081:{f.Push(JValue.R(rt.String(".full")));f.Pc=1083;continue;}
case 1083:{f.Push(JValue.R(rt.String(".fullborder")));f.Pc=1085;continue;}
case 1085:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1088);}
case 1088:{f.Locals[7]=f.Pop();f.Pc=1090;continue;}
case 1090:{f.Push(f.Locals[1]);f.Pc=1091;continue;}
case 1091:{f.Push(f.Locals[7]);f.Pc=1093;continue;}
case 1093:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",1096);}
case 1096:{f.Locals[5]=f.Pop();f.Pc=1098;continue;}
case 1098:{f.Push(f.Locals[5]);f.Pc=1100;continue;}
case 1100:{f.Pc=f.Pop().Reference==null?1118:1103;continue;}
case 1103:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=1106;continue;}
case 1106:{f.Push(f.Locals[2]);f.Pc=1107;continue;}
case 1107:{f.Push(f.Locals[5]);f.Pc=1109;continue;}
case 1109:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1114);}
case 1114:{f.StackOp("pop");f.Pc=1115;continue;}
case 1115:{f.Push(f.Locals[5]);f.Pc=1117;continue;}
case 1117:{return JStep.Return(f.Pop());}
case 1118:{f.Push(f.Locals[1]);f.Pc=1119;continue;}
case 1119:{f.Push(f.Locals[6]);f.Pc=1121;continue;}
case 1121:{f.Push(JValue.R(rt.String("[0-9]*[.]full")));f.Pc=1123;continue;}
case 1123:{f.Push(JValue.R(rt.String("1.full")));f.Pc=1125;continue;}
case 1125:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1128);}
case 1128:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",1131);}
case 1131:{f.Locals[5]=f.Pop();f.Pc=1133;continue;}
case 1133:{f.Push(f.Locals[5]);f.Pc=1135;continue;}
case 1135:{f.Pc=f.Pop().Reference==null?1153:1138;continue;}
case 1138:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=1141;continue;}
case 1141:{f.Push(f.Locals[2]);f.Pc=1142;continue;}
case 1142:{f.Push(f.Locals[5]);f.Pc=1144;continue;}
case 1144:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1149);}
case 1149:{f.StackOp("pop");f.Pc=1150;continue;}
case 1150:{f.Push(f.Locals[5]);f.Pc=1152;continue;}
case 1152:{return JStep.Return(f.Pop());}
case 1153:{f.Push(f.Locals[2]);f.Pc=1154;continue;}
case 1154:{f.Push(JValue.R(rt.String(".full")));f.Pc=1156;continue;}
case 1156:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",1159);}
case 1159:{f.Pc=f.Pop().Int!=0?1403:1162;continue;}
case 1162:{f.Push(f.Locals[2]);f.Pc=1163;continue;}
case 1163:{f.Push(JValue.R(rt.String(".full")));f.Pc=1165;continue;}
case 1165:{return rt.Call(f,"forge/util/TextUtil","addSuffix","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1168);}
case 1168:{f.Locals[7]=f.Pop();f.Pc=1170;continue;}
case 1170:{f.Push(f.Locals[1]);f.Pc=1171;continue;}
case 1171:{f.Push(f.Locals[7]);f.Pc=1173;continue;}
case 1173:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",1176);}
case 1176:{f.Locals[5]=f.Pop();f.Pc=1178;continue;}
case 1178:{f.Push(f.Locals[5]);f.Pc=1180;continue;}
case 1180:{f.Pc=f.Pop().Reference==null?1198:1183;continue;}
case 1183:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=1186;continue;}
case 1186:{f.Push(f.Locals[2]);f.Pc=1187;continue;}
case 1187:{f.Push(f.Locals[5]);f.Pc=1189;continue;}
case 1189:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1194);}
case 1194:{f.StackOp("pop");f.Pc=1195;continue;}
case 1195:{f.Push(f.Locals[5]);f.Pc=1197;continue;}
case 1197:{return JStep.Return(f.Pop());}
case 1198:{f.Push(f.Locals[2]);f.Pc=1199;continue;}
case 1199:{f.Push(JValue.R(rt.String(".fullborder")));f.Pc=1201;continue;}
case 1201:{return rt.Call(f,"forge/util/TextUtil","addSuffix","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1204);}
case 1204:{f.Locals[8]=f.Pop();f.Pc=1206;continue;}
case 1206:{f.Push(f.Locals[1]);f.Pc=1207;continue;}
case 1207:{f.Push(f.Locals[8]);f.Pc=1209;continue;}
case 1209:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",1212);}
case 1212:{f.Locals[5]=f.Pop();f.Pc=1214;continue;}
case 1214:{f.Push(f.Locals[5]);f.Pc=1216;continue;}
case 1216:{f.Pc=f.Pop().Reference==null?1234:1219;continue;}
case 1219:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=1222;continue;}
case 1222:{f.Push(f.Locals[2]);f.Pc=1223;continue;}
case 1223:{f.Push(f.Locals[5]);f.Pc=1225;continue;}
case 1225:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1230);}
case 1230:{f.StackOp("pop");f.Pc=1231;continue;}
case 1231:{f.Push(f.Locals[5]);f.Pc=1233;continue;}
case 1233:{return JStep.Return(f.Pop());}
case 1234:{f.Push(f.Locals[2]);f.Pc=1235;continue;}
case 1235:{f.Push(JValue.I(0));f.Pc=1236;continue;}
case 1236:{f.Push(f.Locals[2]);f.Pc=1237;continue;}
case 1237:{f.Push(JValue.R(rt.String("/")));f.Pc=1239;continue;}
case 1239:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",1242);}
case 1242:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",1245);}
case 1245:{f.Locals[9]=f.Pop();f.Pc=1247;continue;}
case 1247:{f.Push(f.Locals[9]);f.Pc=1249;continue;}
case 1249:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1252);}
case 1252:{f.Pc=f.Pop().Int!=0?1403:1255;continue;}
case 1255:{if(!rt.StaticReady(f,"forge/ImageKeys","editionAlias","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","editionAlias","Ljava/util/Map;"));f.Pc=1258;continue;}
case 1258:{f.Push(f.Locals[9]);f.Pc=1260;continue;}
case 1260:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1265);}
case 1265:{f.Pc=f.Pop().Int==0?1403:1268;continue;}
case 1268:{if(!rt.StaticReady(f,"forge/ImageKeys","editionAlias","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","editionAlias","Ljava/util/Map;"));f.Pc=1271;continue;}
case 1271:{f.Push(f.Locals[9]);f.Pc=1273;continue;}
case 1273:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1278);}
case 1278:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1281;continue;}
case 1281:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",1286);}
case 1286:{f.Locals[10]=f.Pop();f.Pc=1288;continue;}
case 1288:{f.Push(f.Locals[10]);f.Pc=1290;continue;}
case 1290:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1295);}
case 1295:{f.Pc=f.Pop().Int==0?1403:1298;continue;}
case 1298:{f.Push(f.Locals[10]);f.Pc=1300;continue;}
case 1300:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1305);}
case 1305:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1308;continue;}
case 1308:{f.Locals[11]=f.Pop();f.Pc=1310;continue;}
case 1310:{f.Push(f.Locals[1]);f.Pc=1311;continue;}
case 1311:{f.Push(f.Locals[7]);f.Pc=1313;continue;}
case 1313:{f.Push(f.Locals[9]);f.Pc=1315;continue;}
case 1315:{return rt.DynamicCall(f,"forge/ImageKeys:45:1315:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1320);}
case 1320:{f.Push(f.Locals[11]);f.Pc=1322;continue;}
case 1322:{return rt.DynamicCall(f,"forge/ImageKeys:45:1322:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1327);}
case 1327:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1330);}
case 1330:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",1333);}
case 1333:{f.Locals[5]=f.Pop();f.Pc=1335;continue;}
case 1335:{f.Push(f.Locals[5]);f.Pc=1337;continue;}
case 1337:{f.Pc=f.Pop().Reference==null?1355:1340;continue;}
case 1340:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=1343;continue;}
case 1343:{f.Push(f.Locals[2]);f.Pc=1344;continue;}
case 1344:{f.Push(f.Locals[5]);f.Pc=1346;continue;}
case 1346:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1351);}
case 1351:{f.StackOp("pop");f.Pc=1352;continue;}
case 1352:{f.Push(f.Locals[5]);f.Pc=1354;continue;}
case 1354:{return JStep.Return(f.Pop());}
case 1355:{f.Push(f.Locals[1]);f.Pc=1356;continue;}
case 1356:{f.Push(f.Locals[8]);f.Pc=1358;continue;}
case 1358:{f.Push(f.Locals[9]);f.Pc=1360;continue;}
case 1360:{return rt.DynamicCall(f,"forge/ImageKeys:45:1360:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1365);}
case 1365:{f.Push(f.Locals[11]);f.Pc=1367;continue;}
case 1367:{return rt.DynamicCall(f,"forge/ImageKeys:45:1367:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1372);}
case 1372:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1375);}
case 1375:{return rt.Call(f,"forge/ImageKeys","findFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",1378);}
case 1378:{f.Locals[5]=f.Pop();f.Pc=1380;continue;}
case 1380:{f.Push(f.Locals[5]);f.Pc=1382;continue;}
case 1382:{f.Pc=f.Pop().Reference==null?1400:1385;continue;}
case 1385:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=1388;continue;}
case 1388:{f.Push(f.Locals[2]);f.Pc=1389;continue;}
case 1389:{f.Push(f.Locals[5]);f.Pc=1391;continue;}
case 1391:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1396);}
case 1396:{f.StackOp("pop");f.Pc=1397;continue;}
case 1397:{f.Push(f.Locals[5]);f.Pc=1399;continue;}
case 1399:{return JStep.Return(f.Pop());}
case 1400:{f.Pc=1288;continue;}
case 1403:{if(!rt.StaticReady(f,"forge/ImageKeys","isLibGDXPort","Z"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","isLibGDXPort","Z"));f.Pc=1406;continue;}
case 1406:{f.Pc=f.Pop().Int==0?1424:1409;continue;}
case 1409:{f.Push(f.Locals[2]);f.Pc=1410;continue;}
case 1410:{return rt.Call(f,"forge/ImageKeys","hasSetLookup","(Ljava/lang/String;)Z","invokestatic",1413);}
case 1413:{f.Pc=f.Pop().Int!=0?1424:1416;continue;}
case 1416:{if(!rt.StaticReady(f,"forge/ImageKeys","missingCards","Ljava/util/HashSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","missingCards","Ljava/util/HashSet;"));f.Pc=1419;continue;}
case 1419:{f.Push(f.Locals[2]);f.Pc=1420;continue;}
case 1420:{return rt.Call(f,"java/util/HashSet","add","(Ljava/lang/Object;)Z","invokevirtual",1423);}
case 1423:{f.StackOp("pop");f.Pc=1424;continue;}
case 1424:{f.Push(JValue.R(null));f.Pc=1425;continue;}
case 1425:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M46(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_CARD_PICS_SUBDIR","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","CACHE_CARD_PICS_SUBDIR","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int!=0?25:12;continue;}
case 12:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",15);}
case 15:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/CardEdition$Collection","getCode2ByCode","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Pc=37;continue;}
case 25:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_CARD_PICS_SUBDIR","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","CACHE_CARD_PICS_SUBDIR","Ljava/util/Map;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M47(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",9);}
case 9:{return rt.Call(f,"forge/StaticData","getSetLookup","()Ljava/util/Map;","invokevirtual",12);}
case 12:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int!=0?53:20;continue;}
case 20:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",23);}
case 23:{return rt.Call(f,"forge/StaticData","getSetLookup","()Ljava/util/Map;","invokevirtual",26);}
case 26:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",31);}
case 31:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{return rt.DynamicCall(f,"forge/ImageKeys:47:42:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",47);}
case 47:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",52);}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M48(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getSetLookup","()Ljava/util/Map;","invokevirtual",6);}
case 6:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",11);}
case 11:{f.Pc=f.Pop().Int!=0?407:14;continue;}
case 14:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",17);}
case 17:{return rt.Call(f,"forge/StaticData","getSetLookup","()Ljava/util/Map;","invokevirtual",20);}
case 20:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",25);}
case 25:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",30);}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?407:40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[3]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int==0?404:58;continue;}
case 58:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",61);}
case 61:{return rt.Call(f,"forge/StaticData","getSetLookup","()Ljava/util/Map;","invokevirtual",64);}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",78);}
case 78:{f.Locals[4]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[4]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",87);}
case 87:{f.Pc=f.Pop().Int==0?404:90;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",97);}
case 97:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=100;continue;}
case 100:{f.Locals[5]=f.Pop();f.Pc=102;continue;}
case 102:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_CARD_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","CACHE_CARD_PICS_DIR","Ljava/lang/String;"));f.Pc=105;continue;}
case 105:{f.Push(f.Locals[5]);f.Pc=107;continue;}
case 107:{return rt.DynamicCall(f,"forge/ImageKeys:48:107:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",112);}
case 112:{f.Locals[6]=f.Pop();f.Pc=114;continue;}
case 114:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=117;continue;}
case 117:{f.StackOp("dup");f.Pc=118;continue;}
case 118:{f.Push(f.Locals[6]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",123);}
case 123:{f.Locals[7]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[7]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/io/File","exists","()Z","invokevirtual",130);}
case 130:{f.Pc=f.Pop().Int==0?401:133;continue;}
case 133:{f.Push(f.Locals[7]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/io/File","isDirectory","()Z","invokevirtual",138);}
case 138:{f.Pc=f.Pop().Int==0?401:141;continue;}
case 141:{if(!rt.StaticReady(f,"forge/ImageKeys","FILE_EXTENSIONS","[Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","FILE_EXTENSIONS","[Ljava/lang/String;"));f.Pc=144;continue;}
case 144:{f.Locals[8]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[8]);f.Pc=148;continue;}
case 148:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=149;continue;}
case 149:{f.Locals[9]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(JValue.I(0));f.Pc=152;continue;}
case 152:{f.Locals[10]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[10]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[9]);f.Pc=158;continue;}
case 158:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?401:161;continue;}
case 161:{f.Push(f.Locals[8]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[10]);f.Pc=165;continue;}
case 165:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=166;continue;}
case 166:{f.Locals[11]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[11]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",173);}
case 173:{f.Pc=f.Pop().Int==0?179:176;continue;}
case 176:{f.Pc=395;continue;}
case 179:{f.Push(f.Locals[1]);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[3]);f.Pc=181;continue;}
case 181:{return rt.DynamicCall(f,"forge/ImageKeys:48:181:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",186);}
case 186:{f.Push(JValue.R(rt.String("")));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",191);}
case 191:{f.Push(f.Locals[11]);f.Pc=193;continue;}
case 193:{return rt.DynamicCall(f,"forge/ImageKeys:48:193:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",198);}
case 198:{f.Locals[13]=f.Pop();f.Pc=200;continue;}
case 200:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=203;continue;}
case 203:{f.StackOp("dup");f.Pc=204;continue;}
case 204:{f.Push(f.Locals[6]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[13]);f.Pc=208;continue;}
case 208:{return rt.DynamicCall(f,"forge/ImageKeys:48:208:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",213);}
case 213:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",216);}
case 216:{f.Locals[12]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[12]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/io/File","exists","()Z","invokevirtual",223);}
case 223:{f.Pc=f.Pop().Int==0?229:226;continue;}
case 226:{f.Push(f.Locals[12]);f.Pc=228;continue;}
case 228:{return JStep.Return(f.Pop());}
case 229:{f.Push(f.Locals[1]);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[3]);f.Pc=231;continue;}
case 231:{return rt.DynamicCall(f,"forge/ImageKeys:48:231:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",236);}
case 236:{f.Push(JValue.R(rt.String("")));f.Pc=238;continue;}
case 238:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",241);}
case 241:{f.Push(JValue.R(rt.String("[0-9]*.fullborder")));f.Pc=244;continue;}
case 244:{f.Push(JValue.R(rt.String("1.fullborder")));f.Pc=246;continue;}
case 246:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",249);}
case 249:{f.Push(f.Locals[11]);f.Pc=251;continue;}
case 251:{return rt.DynamicCall(f,"forge/ImageKeys:48:251:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",256);}
case 256:{f.Locals[14]=f.Pop();f.Pc=258;continue;}
case 258:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=261;continue;}
case 261:{f.StackOp("dup");f.Pc=262;continue;}
case 262:{f.Push(f.Locals[6]);f.Pc=264;continue;}
case 264:{f.Push(f.Locals[14]);f.Pc=266;continue;}
case 266:{return rt.DynamicCall(f,"forge/ImageKeys:48:266:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",271);}
case 271:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",274);}
case 274:{f.Locals[12]=f.Pop();f.Pc=276;continue;}
case 276:{f.Push(f.Locals[12]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"java/io/File","exists","()Z","invokevirtual",281);}
case 281:{f.Pc=f.Pop().Int==0?287:284;continue;}
case 284:{f.Push(f.Locals[12]);f.Pc=286;continue;}
case 286:{return JStep.Return(f.Pop());}
case 287:{f.Push(f.Locals[0]);f.Pc=288;continue;}
case 288:{f.Push(f.Locals[3]);f.Pc=289;continue;}
case 289:{return rt.DynamicCall(f,"forge/ImageKeys:48:289:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",294);}
case 294:{f.Push(JValue.R(rt.String("")));f.Pc=296;continue;}
case 296:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",299);}
case 299:{f.Push(f.Locals[11]);f.Pc=301;continue;}
case 301:{return rt.DynamicCall(f,"forge/ImageKeys:48:301:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",306);}
case 306:{f.Locals[15]=f.Pop();f.Pc=308;continue;}
case 308:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=311;continue;}
case 311:{f.StackOp("dup");f.Pc=312;continue;}
case 312:{f.Push(f.Locals[6]);f.Pc=314;continue;}
case 314:{f.Push(f.Locals[15]);f.Pc=316;continue;}
case 316:{return rt.DynamicCall(f,"forge/ImageKeys:48:316:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",321);}
case 321:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",324);}
case 324:{f.Locals[12]=f.Pop();f.Pc=326;continue;}
case 326:{f.Push(f.Locals[12]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"java/io/File","exists","()Z","invokevirtual",331);}
case 331:{f.Pc=f.Pop().Int==0?337:334;continue;}
case 334:{f.Push(f.Locals[12]);f.Pc=336;continue;}
case 336:{return JStep.Return(f.Pop());}
case 337:{f.Push(f.Locals[0]);f.Pc=338;continue;}
case 338:{f.Push(f.Locals[3]);f.Pc=339;continue;}
case 339:{return rt.DynamicCall(f,"forge/ImageKeys:48:339:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",344);}
case 344:{f.Push(JValue.R(rt.String("")));f.Pc=346;continue;}
case 346:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",349);}
case 349:{f.Push(JValue.R(rt.String("[0-9]*.full")));f.Pc=352;continue;}
case 352:{f.Push(JValue.R(rt.String("1.full")));f.Pc=354;continue;}
case 354:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",357);}
case 357:{f.Push(f.Locals[11]);f.Pc=359;continue;}
case 359:{return rt.DynamicCall(f,"forge/ImageKeys:48:359:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",364);}
case 364:{f.Locals[16]=f.Pop();f.Pc=366;continue;}
case 366:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=369;continue;}
case 369:{f.StackOp("dup");f.Pc=370;continue;}
case 370:{f.Push(f.Locals[6]);f.Pc=372;continue;}
case 372:{f.Push(f.Locals[16]);f.Pc=374;continue;}
case 374:{return rt.DynamicCall(f,"forge/ImageKeys:48:374:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",379);}
case 379:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",382);}
case 382:{f.Locals[12]=f.Pop();f.Pc=384;continue;}
case 384:{f.Push(f.Locals[12]);f.Pc=386;continue;}
case 386:{return rt.Call(f,"java/io/File","exists","()Z","invokevirtual",389);}
case 389:{f.Pc=f.Pop().Int==0?395:392;continue;}
case 392:{f.Push(f.Locals[12]);f.Pc=394;continue;}
case 394:{return JStep.Return(f.Pop());}
case 395:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=398;continue;}
case 398:{f.Pc=154;continue;}
case 401:{f.Pc=80;continue;}
case 404:{f.Pc=31;continue;}
case 407:{f.Push(JValue.R(null));f.Pc=408;continue;}
case 408:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M49(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_CARD_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","CACHE_CARD_PICS_DIR","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?81:10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/ImageKeys","FILE_EXTENSIONS","[Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","FILE_EXTENSIONS","[Ljava/lang/String;"));f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=16;continue;}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?78:26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=30;continue;}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?43:40;continue;}
case 40:{f.Pc=72;continue;}
case 43:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=46;continue;}
case 46:{f.StackOp("dup");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{return rt.DynamicCall(f,"forge/ImageKeys:49:51:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",56);}
case 56:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;Ljava/lang/String;)V","invokespecial",59);}
case 59:{f.Locals[6]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[6]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/io/File","exists","()Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?72:69;continue;}
case 69:{f.Push(f.Locals[6]);f.Pc=71;continue;}
case 71:{return JStep.Return(f.Pop());}
case 72:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=75;continue;}
case 75:{f.Pc=20;continue;}
case 78:{f.Pc=155;continue;}
case 81:{if(!rt.StaticReady(f,"forge/ImageKeys","FILE_EXTENSIONS","[Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","FILE_EXTENSIONS","[Ljava/lang/String;"));f.Pc=84;continue;}
case 84:{f.Locals[2]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=87;continue;}
case 87:{f.Locals[3]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(JValue.I(0));f.Pc=89;continue;}
case 89:{f.Locals[4]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[4]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?155:97;continue;}
case 97:{f.Push(f.Locals[2]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=101;continue;}
case 101:{f.Locals[5]=f.Pop();f.Pc=103;continue;}
case 103:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=106;continue;}
case 106:{f.StackOp("dup");f.Pc=107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[5]);f.Pc=111;continue;}
case 111:{return rt.DynamicCall(f,"forge/ImageKeys:49:111:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",116);}
case 116:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;Ljava/lang/String;)V","invokespecial",119);}
case 119:{f.Locals[6]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[6]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/io/File","exists","()Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int==0?149:129;continue;}
case 129:{f.Push(f.Locals[6]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/io/File","isDirectory","()Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int==0?146:137;continue;}
case 137:{f.Push(f.Locals[6]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/io/File","delete","()Z","invokevirtual",142);}
case 142:{f.StackOp("pop");f.Pc=143;continue;}
case 143:{f.Pc=149;continue;}
case 146:{f.Push(f.Locals[6]);f.Pc=148;continue;}
case 148:{return JStep.Return(f.Pop());}
case 149:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=152;continue;}
case 152:{f.Pc=91;continue;}
case 155:{f.Push(JValue.R(null));f.Pc=156;continue;}
case 156:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M50(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/ImageKeys","hasImage","(Lforge/item/PaperCard;Z)Z","invokestatic",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M51(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/ImageKeys","editionImageLookup","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","editionImageLookup","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Reference!=null?371:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/ImageKeys","getSetFolder","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",27);}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",31);}
case 31:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",34);}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",38);}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Reference==null?150:45;continue;}
case 45:{if(!rt.StaticReady(f,"forge/ImageKeys","editionAlias","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","editionAlias","Ljava/util/Map;"));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Int!=0?150:57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/card/CardEdition","getAlias","()Ljava/lang/String;","invokevirtual",62);}
case 62:{f.Locals[5]=f.Pop();f.Pc=64;continue;}
case 64:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=67;continue;}
case 67:{f.StackOp("dup");f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",71);}
case 71:{f.Locals[6]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[5]);f.Pc=75;continue;}
case 75:{f.Pc=f.Pop().Reference==null?97:78;continue;}
case 78:{f.Push(f.Locals[5]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int!=0?97:87;continue;}
case 87:{f.Push(f.Locals[6]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[5]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",96);}
case 96:{f.StackOp("pop");f.Pc=97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",102);}
case 102:{f.Locals[7]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{f.Pc=f.Pop().Reference==null?128:109;continue;}
case 109:{f.Push(f.Locals[7]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[3]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",115);}
case 115:{f.Pc=f.Pop().Int!=0?128:118;continue;}
case 118:{f.Push(f.Locals[6]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[7]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",127);}
case 127:{f.StackOp("pop");f.Pc=128;continue;}
case 128:{f.Push(f.Locals[6]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",135);}
case 135:{f.Pc=f.Pop().Int!=0?150:138;continue;}
case 138:{if(!rt.StaticReady(f,"forge/ImageKeys","editionAlias","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","editionAlias","Ljava/util/Map;"));f.Pc=141;continue;}
case 141:{f.Push(f.Locals[3]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[6]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_CARD_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","CACHE_CARD_PICS_DIR","Ljava/lang/String;"));f.Pc=153;continue;}
case 153:{f.Push(f.Locals[3]);f.Pc=154;continue;}
case 154:{return rt.DynamicCall(f,"forge/ImageKeys:51:154:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",159);}
case 159:{return rt.Call(f,"forge/util/FileUtil","isDirectoryWithFiles","(Ljava/lang/String;)Z","invokestatic",162);}
case 162:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",165);}
case 165:{f.Locals[2]=f.Pop();f.Pc=166;continue;}
case 166:{if(!rt.StaticReady(f,"forge/ImageKeys","editionImageLookup","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","editionImageLookup","Ljava/util/Map;"));f.Pc=169;continue;}
case 169:{f.Push(f.Locals[0]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",173);}
case 173:{f.Push(f.Locals[2]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",179);}
case 179:{f.StackOp("pop");f.Pc=180;continue;}
case 180:{f.Push(f.Locals[2]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",184);}
case 184:{f.Pc=f.Pop().Int==0?371:187;continue;}
case 187:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=190;continue;}
case 190:{f.StackOp("dup");f.Pc=191;continue;}
case 191:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_CARD_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","CACHE_CARD_PICS_DIR","Ljava/lang/String;"));f.Pc=194;continue;}
case 194:{f.Push(f.Locals[3]);f.Pc=195;continue;}
case 195:{return rt.DynamicCall(f,"forge/ImageKeys:51:195:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",200);}
case 200:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",203);}
case 203:{f.Locals[5]=f.Pop();f.Pc=205;continue;}
case 205:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=208;continue;}
case 208:{f.StackOp("dup");f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",212);}
case 212:{f.Locals[6]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(f.Locals[5]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"java/io/File","list","()[Ljava/lang/String;","invokevirtual",219);}
case 219:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",222);}
case 222:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",227);}
case 227:{f.Locals[7]=f.Pop();f.Pc=229;continue;}
case 229:{f.Push(f.Locals[7]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",236);}
case 236:{f.Pc=f.Pop().Int==0?361:239;continue;}
case 239:{f.Push(f.Locals[7]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",246);}
case 246:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=249;continue;}
case 249:{f.Locals[8]=f.Pop();f.Pc=251;continue;}
case 251:{f.Push(f.Locals[8]);f.Pc=253;continue;}
case 253:{f.Push(JValue.R(rt.String(".jpg")));f.Pc=256;continue;}
case 256:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",259);}
case 259:{f.Pc=f.Pop().Int!=0?276:262;continue;}
case 262:{f.Push(f.Locals[8]);f.Pc=264;continue;}
case 264:{f.Push(JValue.R(rt.String(".png")));f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",270);}
case 270:{f.Pc=f.Pop().Int!=0?276:273;continue;}
case 273:{f.Pc=229;continue;}
case 276:{f.Push(f.Locals[6]);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[8]);f.Pc=280;continue;}
case 280:{f.Push(JValue.R(rt.String("\\.")));f.Pc=283;continue;}
case 283:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",286);}
case 286:{f.Push(JValue.I(0));f.Pc=287;continue;}
case 287:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=288;continue;}
case 288:{return rt.Call(f,"java/util/HashSet","add","(Ljava/lang/Object;)Z","invokevirtual",291);}
case 291:{f.StackOp("pop");f.Pc=292;continue;}
case 292:{f.Push(f.Locals[3]);f.Pc=293;continue;}
case 293:{f.Push(f.Locals[8]);f.Pc=295;continue;}
case 295:{f.Push(JValue.R(rt.String(".fullborder")));f.Pc=297;continue;}
case 297:{f.Push(JValue.R(rt.String(".full")));f.Pc=299;continue;}
case 299:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",302);}
case 302:{f.Push(JValue.R(rt.String(".jpg")));f.Pc=305;continue;}
case 305:{f.Push(JValue.R(rt.String("")));f.Pc=307;continue;}
case 307:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",310);}
case 310:{f.Push(JValue.R(rt.String(".png")));f.Pc=313;continue;}
case 313:{f.Push(JValue.R(rt.String("")));f.Pc=315;continue;}
case 315:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",318);}
case 318:{return rt.DynamicCall(f,"forge/ImageKeys:51:318:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",323);}
case 323:{f.Locals[9]=f.Pop();f.Pc=325;continue;}
case 325:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=328;continue;}
case 328:{f.StackOp("dup");f.Pc=329;continue;}
case 329:{if(!rt.StaticReady(f,"forge/ImageKeys","CACHE_CARD_PICS_DIR","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","CACHE_CARD_PICS_DIR","Ljava/lang/String;"));f.Pc=332;continue;}
case 332:{f.Push(f.Locals[3]);f.Pc=333;continue;}
case 333:{f.Push(f.Locals[8]);f.Pc=335;continue;}
case 335:{return rt.DynamicCall(f,"forge/ImageKeys:51:335:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",340);}
case 340:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",343);}
case 343:{f.Locals[10]=f.Pop();f.Pc=345;continue;}
case 345:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=348;continue;}
case 348:{f.Push(f.Locals[9]);f.Pc=350;continue;}
case 350:{f.Push(f.Locals[10]);f.Pc=352;continue;}
case 352:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",357);}
case 357:{f.StackOp("pop");f.Pc=358;continue;}
case 358:{f.Pc=229;continue;}
case 361:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedContent","Ljava/util/HashMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedContent","Ljava/util/HashMap;"));f.Pc=364;continue;}
case 364:{f.Push(f.Locals[3]);f.Pc=365;continue;}
case 365:{f.Push(f.Locals[6]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"java/util/HashMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",370);}
case 370:{f.StackOp("pop");f.Pc=371;continue;}
case 371:{f.Push(f.Locals[0]);f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/item/PaperCard","getCardImageKey","()Ljava/lang/String;","invokevirtual",375);}
case 375:{f.Push(JValue.R(rt.String("//")));f.Pc=378;continue;}
case 378:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","split","(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;","invokestatic",381);}
case 381:{f.Locals[3]=f.Pop();f.Pc=382;continue;}
case 382:{f.Push(f.Locals[3]);f.Pc=383;continue;}
case 383:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=384;continue;}
case 384:{f.Push(JValue.I(2));f.Pc=385;continue;}
case 385:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?390:388;continue;}
case 388:{f.Push(JValue.I(0));f.Pc=389;continue;}
case 389:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 390:{f.Push(f.Locals[1]);f.Pc=391;continue;}
case 391:{f.Pc=f.Pop().Int==0?438:394;continue;}
case 394:{f.Push(f.Locals[2]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",398);}
case 398:{f.Pc=f.Pop().Int==0?438:401;continue;}
case 401:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedContent","Ljava/util/HashMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedContent","Ljava/util/HashMap;"));f.Pc=404;continue;}
case 404:{f.Push(f.Locals[0]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",408);}
case 408:{return rt.Call(f,"forge/ImageKeys","getSetFolder","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",411);}
case 411:{return rt.Call(f,"java/util/HashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",414);}
case 414:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/HashSet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=417;continue;}
case 417:{f.Push(f.Locals[0]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",421);}
case 421:{return rt.Call(f,"java/util/HashSet","add","(Ljava/lang/Object;)Z","invokevirtual",424);}
case 424:{f.StackOp("pop");f.Pc=425;continue;}
case 425:{f.Pc=438;continue;}
case 428:{f.Locals[4]=f.Pop();f.Pc=430;continue;}
case 430:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=433;continue;}
case 433:{f.Push(f.Locals[4]);f.Pc=435;continue;}
case 435:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/Object;)V","invokevirtual",438);}
case 438:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedContent","Ljava/util/HashMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedContent","Ljava/util/HashMap;"));f.Pc=441;continue;}
case 441:{f.Push(f.Locals[3]);f.Pc=442;continue;}
case 442:{f.Push(JValue.I(0));f.Pc=443;continue;}
case 443:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=444;continue;}
case 444:{f.Push(JValue.R(null));f.Pc=445;continue;}
case 445:{return rt.Call(f,"java/util/HashMap","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",448);}
case 448:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/HashSet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=451;continue;}
case 451:{f.Locals[4]=f.Pop();f.Pc=453;continue;}
case 453:{f.Push(f.Locals[2]);f.Pc=454;continue;}
case 454:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",457);}
case 457:{f.Pc=f.Pop().Int==0?475:460;continue;}
case 460:{f.Push(f.Locals[4]);f.Pc=462;continue;}
case 462:{f.Push(f.Locals[3]);f.Pc=463;continue;}
case 463:{f.Push(JValue.I(1));f.Pc=464;continue;}
case 464:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=465;continue;}
case 465:{return rt.Call(f,"forge/ImageKeys","hitCache","(Ljava/util/HashSet;Ljava/lang/String;)Z","invokestatic",468);}
case 468:{f.Pc=f.Pop().Int==0?475:471;continue;}
case 471:{f.Push(JValue.I(1));f.Pc=472;continue;}
case 472:{f.Pc=476;continue;}
case 475:{f.Push(JValue.I(0));f.Pc=476;continue;}
case 476:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M52(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?11:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/HashSet","isEmpty","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?13:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("\\.")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",20);}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=22;continue;}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/HashSet","contains","(Ljava/lang/Object;)Z","invokevirtual",28);}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M53(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/ImageKeys","setLookUpFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference==null?24:10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",20);}
case 20:{f.StackOp("pop");f.Pc=21;continue;}
case 21:{f.Pc=32;continue;}
case 24:{if(!rt.StaticReady(f,"forge/ImageKeys","missingCards","Ljava/util/HashSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","missingCards","Ljava/util/HashSet;"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/HashSet","add","(Ljava/lang/Object;)Z","invokevirtual",31);}
case 31:{f.StackOp("pop");f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/ImageKeys","toFind","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/ImageKeys","toFind","Ljava/util/Set;"));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M54(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",7);}
case 7:{if(!rt.StaticReady(f,"forge/ImageKeys","editionImageLookup","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","editionImageLookup","Ljava/util/Map;",f.Pop());f.Pc=10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",17);}
case 17:{if(!rt.StaticReady(f,"forge/ImageKeys","editionAlias","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","editionAlias","Ljava/util/Map;",f.Pop());f.Pc=20;continue;}
case 20:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",27);}
case 27:{if(!rt.StaticReady(f,"forge/ImageKeys","toFind","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","toFind","Ljava/util/Set;",f.Pop());f.Pc=30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/ImageKeys","isLibGDXPort","Z"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","isLibGDXPort","Z",f.Pop());f.Pc=34;continue;}
case 34:{f.Push(JValue.I(3));f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String(".jpg")));f.Pc=43;continue;}
case 43:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String(".png")));f.Pc=49;continue;}
case 49:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=50;continue;}
case 50:{f.StackOp("dup");f.Pc=51;continue;}
case 51:{f.Push(JValue.I(2));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("")));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{if(!rt.StaticReady(f,"forge/ImageKeys","FILE_EXTENSIONS","[Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","FILE_EXTENSIONS","[Ljava/lang/String;",f.Pop());f.Pc=58;continue;}
case 58:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=61;continue;}
case 61:{f.StackOp("dup");f.Pc=62;continue;}
case 62:{f.Push(JValue.I(50000));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/HashMap","<init>","(I)V","invokespecial",68);}
case 68:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedCards","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","cachedCards","Ljava/util/Map;",f.Pop());f.Pc=71;continue;}
case 71:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",78);}
case 78:{if(!rt.StaticReady(f,"forge/ImageKeys","missingCards","Ljava/util/HashSet;"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","missingCards","Ljava/util/HashSet;",f.Pop());f.Pc=81;continue;}
case 81:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{f.Push(JValue.I(50000));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/HashMap","<init>","(I)V","invokespecial",91);}
case 91:{if(!rt.StaticReady(f,"forge/ImageKeys","cachedContent","Ljava/util/HashMap;"))return JStep.Continue;rt.PutStatic("forge/ImageKeys","cachedContent","Ljava/util/HashMap;",f.Pop());f.Pc=94;continue;}
case 94:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
