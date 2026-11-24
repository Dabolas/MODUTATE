// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C27{
internal static JClass Build(){var c=new JClass("forge/card/CardEdition$Reader","forge/util/storage/StorageReaderFolder",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("CARD_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("TOKEN_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("EXTRA_PARAMS_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("isCustomEditions","Z",false,JValue.Default("Z"),null));
c.Add(new JField("TXT_FILE_FILTER","Ljava/io/FilenameFilter;",true,JValue.Default("Ljava/io/FilenameFilter;"),null));
c.Add(new JMethod(494,"forge/card/CardEdition$Reader","<init>","(Ljava/io/File;)V",1,2,3,new JHandler[]{},M494));
c.Add(new JMethod(495,"forge/card/CardEdition$Reader","<init>","(Ljava/io/File;Z)V",1,3,3,new JHandler[]{},M495));
c.Add(new JMethod(496,"forge/card/CardEdition$Reader","createMap","()Ljava/util/Map;",4,1,3,new JHandler[]{},M496));
c.Add(new JMethod(497,"forge/card/CardEdition$Reader","read","(Ljava/io/File;)Lforge/card/CardEdition;",4,23,10,new JHandler[]{new JHandler(1226,1239,1242,"java/lang/IllegalArgumentException")},M497));
c.Add(new JMethod(498,"forge/card/CardEdition$Reader","getFileFilter","()Ljava/io/FilenameFilter;",4,1,1,new JHandler[]{},M498));
c.Add(new JMethod(499,"forge/card/CardEdition$Reader","read","(Ljava/io/File;)Ljava/lang/Object;",4164,2,2,new JHandler[]{},M499));
c.Add(new JMethod(500,"forge/card/CardEdition$Reader","lambda$static$0","(Ljava/io/File;Ljava/lang/String;)Z",4106,2,2,new JHandler[]{},M500));
c.Add(new JMethod(501,"forge/card/CardEdition$Reader","<clinit>","()V",8,0,1,new JHandler[]{},M501));
}

internal static JStep M494(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardEdition$Reader","<init>","(Ljava/io/File;Z)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M495(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/card/CardEdition$Reader:495:2:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",7);}
case 7:{return rt.Call(f,"forge/util/storage/StorageReaderFolder","<init>","(Ljava/io/File;Ljava/util/function/Function;)V","invokespecial",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition$Reader","isCustomEditions","Z",value);f.Pc=15;continue;}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M496(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/TreeMap","<init>","(Ljava/util/Comparator;)V","invokespecial",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M497(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","getNames","()Ljava/util/List;","invokestatic",15);}
case 15:{f.Locals[4]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/FileUtil","readFile","(Ljava/io/File;)Ljava/util/List;","invokestatic",21);}
case 21:{return rt.Call(f,"forge/util/FileSection","parseSections","(Ljava/util/List;)Ljava/util/Map;","invokestatic",24);}
case 24:{f.Locals[5]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("metadata")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/util/FileSection","EQUALS_KV_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/FileSection","EQUALS_KV_SEPARATOR","Ljava/util/regex/Pattern;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/util/FileSection","parse","(Ljava/lang/Iterable;Ljava/util/regex/Pattern;)Lforge/util/FileSection;","invokestatic",44);}
case 44:{f.Locals[6]=f.Pop();f.Pc=46;continue;}
case 46:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",49);}
case 49:{f.Locals[7]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(JValue.R(null));f.Pc=52;continue;}
case 52:{f.Locals[8]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("BoosterSlots")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/util/FileSection","contains","(Ljava/lang/String;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int==0?86:64;continue;}
case 64:{f.Push(f.Locals[6]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("BoosterSlots")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",71);}
case 71:{f.Push(JValue.R(rt.String(",")));f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",76);}
case 76:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",79);}
case 79:{f.Locals[7]=f.Pop();f.Pc=81;continue;}
case 81:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",84);}
case 84:{f.Locals[8]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[5]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",93);}
case 93:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",98);}
case 98:{f.Locals[9]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[9]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",107);}
case 107:{f.Pc=f.Pop().Int==0?506:110;continue;}
case 110:{f.Push(f.Locals[9]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",117);}
case 117:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=120;continue;}
case 120:{f.Locals[10]=f.Pop();f.Pc=122;continue;}
case 122:{if(!rt.StaticReady(f,"forge/card/CardEdition","reservedSectionNames","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition","reservedSectionNames","Ljava/util/List;"));f.Pc=125;continue;}
case 125:{f.Push(f.Locals[10]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",132);}
case 132:{f.Pc=f.Pop().Int==0?138:135;continue;}
case 135:{f.Pc=100;continue;}
case 138:{f.Push(f.Locals[10]);f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.String("Types")));f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",145);}
case 145:{f.Pc=f.Pop().Int==0?168:148;continue;}
case 148:{f.Push(f.Locals[10]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[5]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[10]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",159);}
case 159:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/card/CardType$Helper","parseTypes","(Ljava/lang/String;Ljava/util/List;)V","invokestatic",165);}
case 165:{f.Pc=503;continue;}
case 168:{f.Push(f.Locals[4]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[10]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",177);}
case 177:{f.Pc=f.Pop().Int==0?442:180;continue;}
case 180:{f.Push(f.Locals[5]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[10]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",189);}
case 189:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",197);}
case 197:{f.Locals[11]=f.Pop();f.Pc=199;continue;}
case 199:{f.Push(f.Locals[11]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",206);}
case 206:{f.Pc=f.Pop().Int==0?439:209;continue;}
case 209:{f.Push(f.Locals[11]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",216);}
case 216:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=219;continue;}
case 219:{f.Locals[12]=f.Pop();f.Pc=221;continue;}
case 221:{if(!rt.StaticReady(f,"forge/card/CardEdition$Reader","CARD_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Reader","CARD_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=224;continue;}
case 224:{f.Push(f.Locals[12]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",229);}
case 229:{f.Locals[13]=f.Pop();f.Pc=231;continue;}
case 231:{f.Push(f.Locals[13]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",236);}
case 236:{f.Pc=f.Pop().Int!=0?242:239;continue;}
case 239:{f.Pc=199;continue;}
case 242:{f.Push(f.Locals[13]);f.Pc=244;continue;}
case 244:{f.Push(JValue.I(2));f.Pc=245;continue;}
case 245:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",248);}
case 248:{f.Locals[14]=f.Pop();f.Pc=250;continue;}
case 250:{f.Push(f.Locals[13]);f.Pc=252;continue;}
case 252:{f.Push(JValue.I(4));f.Pc=253;continue;}
case 253:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",256);}
case 256:{return rt.Call(f,"forge/card/CardRarity","smartValueOf","(Ljava/lang/String;)Lforge/card/CardRarity;","invokestatic",259);}
case 259:{f.Locals[15]=f.Pop();f.Pc=261;continue;}
case 261:{f.Push(f.Locals[13]);f.Pc=263;continue;}
case 263:{f.Push(JValue.I(5));f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",267);}
case 267:{f.Locals[16]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(f.Locals[13]);f.Pc=271;continue;}
case 271:{f.Push(JValue.I(7));f.Pc=273;continue;}
case 273:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",276);}
case 276:{f.Locals[17]=f.Pop();f.Pc=278;continue;}
case 278:{f.Push(f.Locals[13]);f.Pc=280;continue;}
case 280:{f.Push(JValue.I(9));f.Pc=282;continue;}
case 282:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",285);}
case 285:{f.Locals[18]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(JValue.R(null));f.Pc=288;continue;}
case 288:{f.Locals[19]=f.Pop();f.Pc=290;continue;}
case 290:{f.Push(f.Locals[18]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",295);}
case 295:{f.Pc=f.Pop().Int!=0?406:298;continue;}
case 298:{if(!rt.StaticReady(f,"forge/card/CardEdition$Reader","EXTRA_PARAMS_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Reader","EXTRA_PARAMS_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=301;continue;}
case 301:{f.Push(f.Locals[18]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",306);}
case 306:{f.Locals[20]=f.Pop();f.Pc=308;continue;}
case 308:{f.Push(f.Locals[20]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"java/util/regex/Matcher","lookingAt","()Z","invokevirtual",313);}
case 313:{f.Pc=f.Pop().Int!=0?332:316;continue;}
case 316:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=319;continue;}
case 319:{f.Push(f.Locals[18]);f.Pc=321;continue;}
case 321:{return rt.DynamicCall(f,"forge/card/CardEdition$Reader:497:321:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",326);}
case 326:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",329);}
case 329:{f.Pc=406;continue;}
case 332:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=335;continue;}
case 335:{f.StackOp("dup");f.Pc=336;continue;}
case 336:{f.Push(JValue.I(2));f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/util/HashMap","<init>","(I)V","invokespecial",340);}
case 340:{f.Locals[19]=f.Pop();f.Pc=342;continue;}
case 342:{f.Push(f.Locals[20]);f.Pc=344;continue;}
case 344:{f.Push(JValue.I(1));f.Pc=345;continue;}
case 345:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",348);}
case 348:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",351);}
case 351:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",354);}
case 354:{f.Locals[21]=f.Pop();f.Pc=356;continue;}
case 356:{f.Push(f.Locals[20]);f.Pc=358;continue;}
case 358:{f.Push(JValue.I(2));f.Pc=359;continue;}
case 359:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",362);}
case 362:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",365);}
case 365:{f.Locals[22]=f.Pop();f.Pc=367;continue;}
case 367:{f.Push(f.Locals[21]);f.Pc=369;continue;}
case 369:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",372);}
case 372:{f.Pc=f.Pop().Int!=0?398:375;continue;}
case 375:{f.Push(f.Locals[22]);f.Pc=377;continue;}
case 377:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",380);}
case 380:{f.Pc=f.Pop().Int==0?386:383;continue;}
case 383:{f.Pc=398;continue;}
case 386:{f.Push(f.Locals[19]);f.Pc=388;continue;}
case 388:{f.Push(f.Locals[21]);f.Pc=390;continue;}
case 390:{f.Push(f.Locals[22]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",397);}
case 397:{f.StackOp("pop");f.Pc=398;continue;}
case 398:{f.Push(f.Locals[20]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",403);}
case 403:{f.Pc=f.Pop().Int!=0?342:406;continue;}
case 406:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionEntry")));f.Pc=409;continue;}
case 409:{f.StackOp("dup");f.Pc=410;continue;}
case 410:{f.Push(f.Locals[16]);f.Pc=412;continue;}
case 412:{f.Push(f.Locals[14]);f.Pc=414;continue;}
case 414:{f.Push(f.Locals[15]);f.Pc=416;continue;}
case 416:{f.Push(f.Locals[17]);f.Pc=418;continue;}
case 418:{f.Push(f.Locals[19]);f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","<init>","(Ljava/lang/String;Ljava/lang/String;Lforge/card/CardRarity;Ljava/lang/String;Ljava/util/Map;)V","invokespecial",423);}
case 423:{f.Locals[20]=f.Pop();f.Pc=425;continue;}
case 425:{f.Push(f.Locals[2]);f.Pc=426;continue;}
case 426:{f.Push(f.Locals[10]);f.Pc=428;continue;}
case 428:{f.Push(f.Locals[20]);f.Pc=430;continue;}
case 430:{return rt.Call(f,"com/google/common/collect/ListMultimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",435);}
case 435:{f.StackOp("pop");f.Pc=436;continue;}
case 436:{f.Pc=199;continue;}
case 439:{f.Pc=503;continue;}
case 442:{f.Push(f.Locals[7]);f.Pc=444;continue;}
case 444:{f.Push(f.Locals[10]);f.Pc=446;continue;}
case 446:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",451);}
case 451:{f.Pc=f.Pop().Int==0?482:454;continue;}
case 454:{f.Push(f.Locals[8]);f.Pc=456;continue;}
case 456:{f.Push(f.Locals[10]);f.Pc=458;continue;}
case 458:{f.Push(f.Locals[5]);f.Pc=460;continue;}
case 460:{f.Push(f.Locals[10]);f.Pc=462;continue;}
case 462:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",467);}
case 467:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=470;continue;}
case 470:{return rt.Call(f,"forge/item/BoosterSlot","parseSlot","(Ljava/lang/String;Ljava/util/List;)Lforge/item/BoosterSlot;","invokestatic",473);}
case 473:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",478);}
case 478:{f.StackOp("pop");f.Pc=479;continue;}
case 479:{f.Pc=503;continue;}
case 482:{f.Push(f.Locals[3]);f.Pc=483;continue;}
case 483:{f.Push(f.Locals[10]);f.Pc=485;continue;}
case 485:{f.Push(f.Locals[5]);f.Pc=487;continue;}
case 487:{f.Push(f.Locals[10]);f.Pc=489;continue;}
case 489:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",494);}
case 494:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=497;continue;}
case 497:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",502);}
case 502:{f.StackOp("pop");f.Pc=503;continue;}
case 503:{f.Pc=100;continue;}
case 506:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",509);}
case 509:{f.Locals[9]=f.Pop();f.Pc=511;continue;}
case 511:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",514);}
case 514:{f.Locals[10]=f.Pop();f.Pc=516;continue;}
case 516:{f.Push(f.Locals[5]);f.Pc=518;continue;}
case 518:{f.Push(JValue.R(rt.String("tokens")));f.Pc=520;continue;}
case 520:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",525);}
case 525:{f.Pc=f.Pop().Int==0?659:528;continue;}
case 528:{f.Push(f.Locals[5]);f.Pc=530;continue;}
case 530:{f.Push(JValue.R(rt.String("tokens")));f.Pc=532;continue;}
case 532:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",537);}
case 537:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=540;continue;}
case 540:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",545);}
case 545:{f.Locals[11]=f.Pop();f.Pc=547;continue;}
case 547:{f.Push(f.Locals[11]);f.Pc=549;continue;}
case 549:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",554);}
case 554:{f.Pc=f.Pop().Int==0?659:557;continue;}
case 557:{f.Push(f.Locals[11]);f.Pc=559;continue;}
case 559:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",564);}
case 564:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=567;continue;}
case 567:{f.Locals[12]=f.Pop();f.Pc=569;continue;}
case 569:{f.Push(f.Locals[12]);f.Pc=571;continue;}
case 571:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",574);}
case 574:{f.Pc=f.Pop().Int==0?580:577;continue;}
case 577:{f.Pc=547;continue;}
case 580:{if(!rt.StaticReady(f,"forge/card/CardEdition$Reader","TOKEN_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Reader","TOKEN_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=583;continue;}
case 583:{f.Push(f.Locals[12]);f.Pc=585;continue;}
case 585:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",588);}
case 588:{f.Locals[13]=f.Pop();f.Pc=590;continue;}
case 590:{f.Push(f.Locals[13]);f.Pc=592;continue;}
case 592:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",595);}
case 595:{f.Pc=f.Pop().Int!=0?601:598;continue;}
case 598:{f.Pc=547;continue;}
case 601:{f.Push(f.Locals[13]);f.Pc=603;continue;}
case 603:{f.Push(JValue.I(2));f.Pc=604;continue;}
case 604:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",607);}
case 607:{f.Locals[14]=f.Pop();f.Pc=609;continue;}
case 609:{f.Push(f.Locals[13]);f.Pc=611;continue;}
case 611:{f.Push(JValue.I(3));f.Pc=612;continue;}
case 612:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",615);}
case 615:{f.Locals[15]=f.Pop();f.Pc=617;continue;}
case 617:{f.Push(f.Locals[13]);f.Pc=619;continue;}
case 619:{f.Push(JValue.I(5));f.Pc=620;continue;}
case 620:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",623);}
case 623:{f.Locals[16]=f.Pop();f.Pc=625;continue;}
case 625:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionEntry")));f.Pc=628;continue;}
case 628:{f.StackOp("dup");f.Pc=629;continue;}
case 629:{f.Push(f.Locals[15]);f.Pc=631;continue;}
case 631:{f.Push(f.Locals[14]);f.Pc=633;continue;}
case 633:{if(!rt.StaticReady(f,"forge/card/CardRarity","Token","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Token","Lforge/card/CardRarity;"));f.Pc=636;continue;}
case 636:{f.Push(f.Locals[16]);f.Pc=638;continue;}
case 638:{f.Push(JValue.R(null));f.Pc=639;continue;}
case 639:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","<init>","(Ljava/lang/String;Ljava/lang/String;Lforge/card/CardRarity;Ljava/lang/String;Ljava/util/Map;)V","invokespecial",642);}
case 642:{f.Locals[17]=f.Pop();f.Pc=644;continue;}
case 644:{f.Push(f.Locals[9]);f.Pc=646;continue;}
case 646:{f.Push(f.Locals[15]);f.Pc=648;continue;}
case 648:{f.Push(f.Locals[17]);f.Pc=650;continue;}
case 650:{return rt.Call(f,"com/google/common/collect/ListMultimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",655);}
case 655:{f.StackOp("pop");f.Pc=656;continue;}
case 656:{f.Pc=547;continue;}
case 659:{f.Push(f.Locals[5]);f.Pc=661;continue;}
case 661:{f.Push(JValue.R(rt.String("other")));f.Pc=663;continue;}
case 663:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",668);}
case 668:{f.Pc=f.Pop().Int==0?802:671;continue;}
case 671:{f.Push(f.Locals[5]);f.Pc=673;continue;}
case 673:{f.Push(JValue.R(rt.String("other")));f.Pc=675;continue;}
case 675:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",680);}
case 680:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=683;continue;}
case 683:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",688);}
case 688:{f.Locals[11]=f.Pop();f.Pc=690;continue;}
case 690:{f.Push(f.Locals[11]);f.Pc=692;continue;}
case 692:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",697);}
case 697:{f.Pc=f.Pop().Int==0?802:700;continue;}
case 700:{f.Push(f.Locals[11]);f.Pc=702;continue;}
case 702:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",707);}
case 707:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=710;continue;}
case 710:{f.Locals[12]=f.Pop();f.Pc=712;continue;}
case 712:{f.Push(f.Locals[12]);f.Pc=714;continue;}
case 714:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",717);}
case 717:{f.Pc=f.Pop().Int==0?723:720;continue;}
case 720:{f.Pc=690;continue;}
case 723:{if(!rt.StaticReady(f,"forge/card/CardEdition$Reader","TOKEN_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Reader","TOKEN_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=726;continue;}
case 726:{f.Push(f.Locals[12]);f.Pc=728;continue;}
case 728:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",731);}
case 731:{f.Locals[13]=f.Pop();f.Pc=733;continue;}
case 733:{f.Push(f.Locals[13]);f.Pc=735;continue;}
case 735:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",738);}
case 738:{f.Pc=f.Pop().Int!=0?744:741;continue;}
case 741:{f.Pc=690;continue;}
case 744:{f.Push(f.Locals[13]);f.Pc=746;continue;}
case 746:{f.Push(JValue.I(2));f.Pc=747;continue;}
case 747:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",750);}
case 750:{f.Locals[14]=f.Pop();f.Pc=752;continue;}
case 752:{f.Push(f.Locals[13]);f.Pc=754;continue;}
case 754:{f.Push(JValue.I(3));f.Pc=755;continue;}
case 755:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",758);}
case 758:{f.Locals[15]=f.Pop();f.Pc=760;continue;}
case 760:{f.Push(f.Locals[13]);f.Pc=762;continue;}
case 762:{f.Push(JValue.I(5));f.Pc=763;continue;}
case 763:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",766);}
case 766:{f.Locals[16]=f.Pop();f.Pc=768;continue;}
case 768:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$EditionEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$EditionEntry")));f.Pc=771;continue;}
case 771:{f.StackOp("dup");f.Pc=772;continue;}
case 772:{f.Push(f.Locals[15]);f.Pc=774;continue;}
case 774:{f.Push(f.Locals[14]);f.Pc=776;continue;}
case 776:{if(!rt.StaticReady(f,"forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"));f.Pc=779;continue;}
case 779:{f.Push(f.Locals[16]);f.Pc=781;continue;}
case 781:{f.Push(JValue.R(null));f.Pc=782;continue;}
case 782:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","<init>","(Ljava/lang/String;Ljava/lang/String;Lforge/card/CardRarity;Ljava/lang/String;Ljava/util/Map;)V","invokespecial",785);}
case 785:{f.Locals[17]=f.Pop();f.Pc=787;continue;}
case 787:{f.Push(f.Locals[10]);f.Pc=789;continue;}
case 789:{f.Push(f.Locals[15]);f.Pc=791;continue;}
case 791:{f.Push(f.Locals[17]);f.Pc=793;continue;}
case 793:{return rt.Call(f,"com/google/common/collect/ListMultimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",798);}
case 798:{f.StackOp("pop");f.Pc=799;continue;}
case 799:{f.Pc=690;continue;}
case 802:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition")));f.Pc=805;continue;}
case 805:{f.StackOp("dup");f.Pc=806;continue;}
case 806:{f.Push(f.Locals[2]);f.Pc=807;continue;}
case 807:{f.Push(f.Locals[9]);f.Pc=809;continue;}
case 809:{f.Push(f.Locals[3]);f.Pc=810;continue;}
case 810:{return rt.Call(f,"forge/card/CardEdition","<init>","(Lcom/google/common/collect/ListMultimap;Lcom/google/common/collect/ListMultimap;Ljava/util/Map;)V","invokespecial",813);}
case 813:{f.Locals[11]=f.Pop();f.Pc=815;continue;}
case 815:{f.Push(f.Locals[11]);f.Pc=817;continue;}
case 817:{f.Push(f.Locals[6]);f.Pc=819;continue;}
case 819:{f.Push(JValue.R(rt.String("name")));f.Pc=821;continue;}
case 821:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",824);}
case 824:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","name","Ljava/lang/String;",value);f.Pc=827;continue;}
case 827:{f.Push(f.Locals[11]);f.Pc=829;continue;}
case 829:{f.Push(f.Locals[6]);f.Pc=831;continue;}
case 831:{f.Push(JValue.R(rt.String("date")));f.Pc=834;continue;}
case 834:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",837);}
case 837:{return rt.Call(f,"forge/card/CardEdition","parseDate","(Ljava/lang/String;)Ljava/util/Date;","invokestatic",840);}
case 840:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","date","Ljava/util/Date;",value);f.Pc=843;continue;}
case 843:{f.Push(f.Locals[11]);f.Pc=845;continue;}
case 845:{f.Push(f.Locals[6]);f.Pc=847;continue;}
case 847:{f.Push(JValue.R(rt.String("code")));f.Pc=850;continue;}
case 850:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",853);}
case 853:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","code","Ljava/lang/String;",value);f.Pc=856;continue;}
case 856:{f.Push(f.Locals[11]);f.Pc=858;continue;}
case 858:{f.Push(f.Locals[6]);f.Pc=860;continue;}
case 860:{f.Push(JValue.R(rt.String("code2")));f.Pc=863;continue;}
case 863:{f.Push(f.Locals[11]);f.Pc=865;continue;}
case 865:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","code","Ljava/lang/String;"));f.Pc=868;continue;}
case 868:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",871);}
case 871:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","code2","Ljava/lang/String;",value);f.Pc=874;continue;}
case 874:{f.Push(f.Locals[11]);f.Pc=876;continue;}
case 876:{f.Push(f.Locals[6]);f.Pc=878;continue;}
case 878:{f.Push(JValue.R(rt.String("ScryfallCode")));f.Pc=881;continue;}
case 881:{f.Push(f.Locals[11]);f.Pc=883;continue;}
case 883:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","code","Ljava/lang/String;"));f.Pc=886;continue;}
case 886:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",889);}
case 889:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","scryfallCode","Ljava/lang/String;",value);f.Pc=892;continue;}
case 892:{f.Push(f.Locals[11]);f.Pc=894;continue;}
case 894:{f.Push(f.Locals[6]);f.Pc=896;continue;}
case 896:{f.Push(JValue.R(rt.String("TokensCode")));f.Pc=899;continue;}
case 899:{f.Push(f.Locals[11]);f.Pc=901;continue;}
case 901:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","scryfallCode","Ljava/lang/String;"));f.Pc=904;continue;}
case 904:{return rt.DynamicCall(f,"forge/card/CardEdition$Reader:497:904:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",909);}
case 909:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",912);}
case 912:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","tokensCode","Ljava/lang/String;",value);f.Pc=915;continue;}
case 915:{f.Push(f.Locals[11]);f.Pc=917;continue;}
case 917:{f.Push(f.Locals[6]);f.Pc=919;continue;}
case 919:{f.Push(JValue.R(rt.String("TokenFallbackCode")));f.Pc=922;continue;}
case 922:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",925);}
case 925:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","tokenFallbackCode","Ljava/lang/String;",value);f.Pc=928;continue;}
case 928:{f.Push(f.Locals[11]);f.Pc=930;continue;}
case 930:{f.Push(f.Locals[6]);f.Pc=932;continue;}
case 932:{f.Push(JValue.R(rt.String("CardLang")));f.Pc=935;continue;}
case 935:{f.Push(JValue.R(rt.String("en")));f.Pc=938;continue;}
case 938:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",941);}
case 941:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","cardsLanguage","Ljava/lang/String;",value);f.Pc=944;continue;}
case 944:{f.Push(f.Locals[11]);f.Pc=946;continue;}
case 946:{f.Push(f.Locals[6]);f.Pc=948;continue;}
case 948:{f.Push(JValue.R(rt.String("BoosterCovers")));f.Pc=951;continue;}
case 951:{f.Push(JValue.I(1));f.Pc=952;continue;}
case 952:{return rt.Call(f,"forge/util/FileSection","getInt","(Ljava/lang/String;I)I","invokevirtual",955);}
case 955:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","boosterArts","I",value);f.Pc=958;continue;}
case 958:{f.Push(f.Locals[11]);f.Pc=960;continue;}
case 960:{f.Push(f.Locals[10]);f.Pc=962;continue;}
case 962:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","otherMap","Lcom/google/common/collect/ListMultimap;",value);f.Pc=965;continue;}
case 965:{f.Push(f.Locals[11]);f.Pc=967;continue;}
case 967:{f.Push(f.Locals[8]);f.Pc=969;continue;}
case 969:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","boosterSlots","Ljava/util/List;",value);f.Pc=972;continue;}
case 972:{f.Push(f.Locals[6]);f.Pc=974;continue;}
case 974:{f.Push(JValue.R(rt.String("Booster")));f.Pc=977;continue;}
case 977:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",980);}
case 980:{f.Locals[12]=f.Pop();f.Pc=982;continue;}
case 982:{f.Push(f.Locals[6]);f.Pc=984;continue;}
case 984:{f.Push(JValue.R(rt.String("Booster")));f.Pc=987;continue;}
case 987:{return rt.Call(f,"forge/util/FileSection","contains","(Ljava/lang/String;)Z","invokevirtual",990);}
case 990:{f.Pc=f.Pop().Int==0?1072:993;continue;}
case 993:{f.Push(f.Locals[11]);f.Pc=995;continue;}
case 995:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","boosterSlots","Ljava/util/List;"));f.Pc=998;continue;}
case 998:{f.Pc=f.Pop().Reference==null?1031:1001;continue;}
case 1001:{f.Push(f.Locals[11]);f.Pc=1003;continue;}
case 1003:{if(!rt.EnsureInitialized(f,"forge/item/SealedTemplateWithSlots"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/SealedTemplateWithSlots")));f.Pc=1006;continue;}
case 1006:{f.StackOp("dup");f.Pc=1007;continue;}
case 1007:{f.Push(f.Locals[11]);f.Pc=1009;continue;}
case 1009:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","code","Ljava/lang/String;"));f.Pc=1012;continue;}
case 1012:{f.Push(f.Locals[12]);f.Pc=1014;continue;}
case 1014:{return rt.Call(f,"forge/item/SealedTemplate$Reader","parseSlots","(Ljava/lang/String;)Ljava/util/List;","invokestatic",1017);}
case 1017:{f.Push(f.Locals[11]);f.Pc=1019;continue;}
case 1019:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","boosterSlots","Ljava/util/List;"));f.Pc=1022;continue;}
case 1022:{return rt.Call(f,"forge/item/SealedTemplateWithSlots","<init>","(Ljava/lang/String;Ljava/lang/Iterable;Ljava/util/List;)V","invokespecial",1025);}
case 1025:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","boosterTpl","Lforge/item/SealedTemplate;",value);f.Pc=1028;continue;}
case 1028:{f.Pc=1053;continue;}
case 1031:{f.Push(f.Locals[11]);f.Pc=1033;continue;}
case 1033:{if(!rt.EnsureInitialized(f,"forge/item/SealedTemplate"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/SealedTemplate")));f.Pc=1036;continue;}
case 1036:{f.StackOp("dup");f.Pc=1037;continue;}
case 1037:{f.Push(f.Locals[11]);f.Pc=1039;continue;}
case 1039:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","code","Ljava/lang/String;"));f.Pc=1042;continue;}
case 1042:{f.Push(f.Locals[12]);f.Pc=1044;continue;}
case 1044:{return rt.Call(f,"forge/item/SealedTemplate$Reader","parseSlots","(Ljava/lang/String;)Ljava/util/List;","invokestatic",1047);}
case 1047:{return rt.Call(f,"forge/item/SealedTemplate","<init>","(Ljava/lang/String;Ljava/lang/Iterable;)V","invokespecial",1050);}
case 1050:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","boosterTpl","Lforge/item/SealedTemplate;",value);f.Pc=1053;continue;}
case 1053:{f.Push(f.Locals[11]);f.Pc=1055;continue;}
case 1055:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","boosterTemplates","Ljava/util/Map;"));f.Pc=1058;continue;}
case 1058:{f.Push(JValue.R(rt.String("Draft")));f.Pc=1061;continue;}
case 1061:{f.Push(f.Locals[11]);f.Pc=1063;continue;}
case 1063:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","boosterTpl","Lforge/item/SealedTemplate;"));f.Pc=1066;continue;}
case 1066:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1071);}
case 1071:{f.StackOp("pop");f.Pc=1072;continue;}
case 1072:{f.Push(JValue.I(3));f.Pc=1073;continue;}
case 1073:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=1076;continue;}
case 1076:{f.StackOp("dup");f.Pc=1077;continue;}
case 1077:{f.Push(JValue.I(0));f.Pc=1078;continue;}
case 1078:{f.Push(JValue.R(rt.String("Draft")));f.Pc=1081;continue;}
case 1081:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1082;continue;}
case 1082:{f.StackOp("dup");f.Pc=1083;continue;}
case 1083:{f.Push(JValue.I(1));f.Pc=1084;continue;}
case 1084:{f.Push(JValue.R(rt.String("Collector")));f.Pc=1087;continue;}
case 1087:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1088;continue;}
case 1088:{f.StackOp("dup");f.Pc=1089;continue;}
case 1089:{f.Push(JValue.I(2));f.Pc=1090;continue;}
case 1090:{f.Push(JValue.R(rt.String("Set")));f.Pc=1093;continue;}
case 1093:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1094;continue;}
case 1094:{f.Locals[13]=f.Pop();f.Pc=1096;continue;}
case 1096:{f.Push(f.Locals[13]);f.Pc=1098;continue;}
case 1098:{f.Locals[14]=f.Pop();f.Pc=1100;continue;}
case 1100:{f.Push(f.Locals[14]);f.Pc=1102;continue;}
case 1102:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1103;continue;}
case 1103:{f.Locals[15]=f.Pop();f.Pc=1105;continue;}
case 1105:{f.Push(JValue.I(0));f.Pc=1106;continue;}
case 1106:{f.Locals[16]=f.Pop();f.Pc=1108;continue;}
case 1108:{f.Push(f.Locals[16]);f.Pc=1110;continue;}
case 1110:{f.Push(f.Locals[15]);f.Pc=1112;continue;}
case 1112:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1182:1115;continue;}
case 1115:{f.Push(f.Locals[14]);f.Pc=1117;continue;}
case 1117:{f.Push(f.Locals[16]);f.Pc=1119;continue;}
case 1119:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1120;continue;}
case 1120:{f.Locals[17]=f.Pop();f.Pc=1122;continue;}
case 1122:{f.Push(f.Locals[17]);f.Pc=1124;continue;}
case 1124:{return rt.DynamicCall(f,"forge/card/CardEdition$Reader:497:1124:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1129);}
case 1129:{f.Locals[18]=f.Pop();f.Pc=1131;continue;}
case 1131:{f.Push(f.Locals[6]);f.Pc=1133;continue;}
case 1133:{f.Push(f.Locals[18]);f.Pc=1135;continue;}
case 1135:{return rt.Call(f,"forge/util/FileSection","contains","(Ljava/lang/String;)Z","invokevirtual",1138);}
case 1138:{f.Pc=f.Pop().Int==0?1176:1141;continue;}
case 1141:{f.Push(f.Locals[11]);f.Pc=1143;continue;}
case 1143:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","boosterTemplates","Ljava/util/Map;"));f.Pc=1146;continue;}
case 1146:{f.Push(f.Locals[17]);f.Pc=1148;continue;}
case 1148:{if(!rt.EnsureInitialized(f,"forge/item/SealedTemplate"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/SealedTemplate")));f.Pc=1151;continue;}
case 1151:{f.StackOp("dup");f.Pc=1152;continue;}
case 1152:{f.Push(f.Locals[11]);f.Pc=1154;continue;}
case 1154:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","code","Ljava/lang/String;"));f.Pc=1157;continue;}
case 1157:{f.Push(f.Locals[6]);f.Pc=1159;continue;}
case 1159:{f.Push(f.Locals[18]);f.Pc=1161;continue;}
case 1161:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1164);}
case 1164:{return rt.Call(f,"forge/item/SealedTemplate$Reader","parseSlots","(Ljava/lang/String;)Ljava/util/List;","invokestatic",1167);}
case 1167:{return rt.Call(f,"forge/item/SealedTemplate","<init>","(Ljava/lang/String;Ljava/lang/Iterable;)V","invokespecial",1170);}
case 1170:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1175);}
case 1175:{f.StackOp("pop");f.Pc=1176;continue;}
case 1176:{f.Locals[16]=JValue.I(unchecked(f.Locals[16].Int+(1)));f.Pc=1179;continue;}
case 1179:{f.Pc=1108;continue;}
case 1182:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","UNKNOWN","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","UNKNOWN","Lforge/card/CardEdition$Type;"));f.Pc=1185;continue;}
case 1185:{f.Locals[14]=f.Pop();f.Pc=1187;continue;}
case 1187:{f.Push(f.Locals[0]);f.Pc=1188;continue;}
case 1188:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$Reader","isCustomEditions","Z"));f.Pc=1191;continue;}
case 1191:{f.Pc=f.Pop().Int==0?1202:1194;continue;}
case 1194:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","CUSTOM_SET","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","CUSTOM_SET","Lforge/card/CardEdition$Type;"));f.Pc=1197;continue;}
case 1197:{f.Locals[14]=f.Pop();f.Pc=1199;continue;}
case 1199:{f.Pc=1262;continue;}
case 1202:{f.Push(f.Locals[6]);f.Pc=1204;continue;}
case 1204:{f.Push(JValue.R(rt.String("type")));f.Pc=1207;continue;}
case 1207:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1210);}
case 1210:{f.Locals[15]=f.Pop();f.Pc=1212;continue;}
case 1212:{f.Push(JValue.R(null));f.Pc=1213;continue;}
case 1213:{f.Push(f.Locals[15]);f.Pc=1215;continue;}
case 1215:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1262:1218;continue;}
case 1218:{f.Push(f.Locals[15]);f.Pc=1220;continue;}
case 1220:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1223);}
case 1223:{f.Pc=f.Pop().Int!=0?1262:1226;continue;}
case 1226:{f.Push(f.Locals[15]);f.Pc=1228;continue;}
case 1228:{if(!rt.StaticReady(f,"java/util/Locale","ENGLISH","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ENGLISH","Ljava/util/Locale;"));f.Pc=1231;continue;}
case 1231:{return rt.Call(f,"java/lang/String","toUpperCase","(Ljava/util/Locale;)Ljava/lang/String;","invokevirtual",1234);}
case 1234:{return rt.Call(f,"forge/card/CardEdition$Type","valueOf","(Ljava/lang/String;)Lforge/card/CardEdition$Type;","invokestatic",1237);}
case 1237:{f.Locals[14]=f.Pop();f.Pc=1239;continue;}
case 1239:{f.Pc=1262;continue;}
case 1242:{f.Locals[16]=f.Pop();f.Pc=1244;continue;}
case 1244:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=1247;continue;}
case 1247:{f.Push(f.Locals[11]);f.Pc=1249;continue;}
case 1249:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","name","Ljava/lang/String;"));f.Pc=1252;continue;}
case 1252:{f.Push(f.Locals[15]);f.Pc=1254;continue;}
case 1254:{return rt.DynamicCall(f,"forge/card/CardEdition$Reader:497:1254:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1259);}
case 1259:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",1262);}
case 1262:{f.Push(f.Locals[11]);f.Pc=1264;continue;}
case 1264:{f.Push(f.Locals[14]);f.Pc=1266;continue;}
case 1266:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","type","Lforge/card/CardEdition$Type;",value);f.Pc=1269;continue;}
case 1269:{f.Push(f.Locals[11]);f.Pc=1271;continue;}
case 1271:{return rt.Call(f,"forge/card/CardEdition","hasBoosterTemplate","()Z","invokevirtual",1274);}
case 1274:{f.Pc=f.Pop().Int==0?1335:1277;continue;}
case 1277:{f.Push(f.Locals[11]);f.Pc=1279;continue;}
case 1279:{f.Push(f.Locals[6]);f.Pc=1281;continue;}
case 1281:{f.Push(JValue.R(rt.String("BoosterBox")));f.Pc=1284;continue;}
case 1284:{f.Push(f.Locals[14]);f.Pc=1286;continue;}
case 1286:{return rt.Call(f,"forge/card/CardEdition$Type","getBoosterBoxDefault","()Ljava/lang/String;","invokevirtual",1289);}
case 1289:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1292);}
case 1292:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",1295);}
case 1295:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","boosterBoxCount","I",value);f.Pc=1298;continue;}
case 1298:{f.Push(f.Locals[11]);f.Pc=1300;continue;}
case 1300:{f.Push(f.Locals[6]);f.Pc=1302;continue;}
case 1302:{f.Push(JValue.R(rt.String("FatPack")));f.Pc=1305;continue;}
case 1305:{f.Push(f.Locals[14]);f.Pc=1307;continue;}
case 1307:{return rt.Call(f,"forge/card/CardEdition$Type","getFatPackDefault","()Ljava/lang/String;","invokevirtual",1310);}
case 1310:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1313);}
case 1313:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",1316);}
case 1316:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","fatPackCount","I",value);f.Pc=1319;continue;}
case 1319:{f.Push(f.Locals[11]);f.Pc=1321;continue;}
case 1321:{f.Push(f.Locals[6]);f.Pc=1323;continue;}
case 1323:{f.Push(JValue.R(rt.String("FatPackExtraSlots")));f.Pc=1326;continue;}
case 1326:{f.Push(JValue.R(rt.String("")));f.Pc=1329;continue;}
case 1329:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1332);}
case 1332:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","fatPackExtraSlots","Ljava/lang/String;",value);f.Pc=1335;continue;}
case 1335:{f.Push(f.Locals[6]);f.Pc=1337;continue;}
case 1337:{f.Push(JValue.R(rt.String("foil")));f.Pc=1340;continue;}
case 1340:{f.Push(JValue.R(rt.String("newstyle")));f.Pc=1343;continue;}
case 1343:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1346);}
case 1346:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",1349);}
case 1349:{f.Locals[15]=f.Pop();f.Pc=1351;continue;}
case 1351:{f.Push(JValue.I(-1));f.Pc=1352;continue;}
case 1352:{f.Locals[16]=f.Pop();f.Pc=1354;continue;}
case 1354:{f.Push(f.Locals[15]);f.Pc=1356;continue;}
case 1356:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",1359);}
case 1359:{switch(f.Pop().Int){case -1919441093:f.Pc=1476;break;case -1068799201:f.Pc=1459;break;case 217264106:f.Pc=1408;break;case 853620882:f.Pc=1425;break;case 1395816465:f.Pc=1442;break;default:f.Pc=1490;break;}continue;}
case 1408:{f.Push(f.Locals[15]);f.Pc=1410;continue;}
case 1410:{f.Push(JValue.R(rt.String("oldstyle")));f.Pc=1413;continue;}
case 1413:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1416);}
case 1416:{f.Pc=f.Pop().Int==0?1490:1419;continue;}
case 1419:{f.Push(JValue.I(0));f.Pc=1420;continue;}
case 1420:{f.Locals[16]=f.Pop();f.Pc=1422;continue;}
case 1422:{f.Pc=1490;continue;}
case 1425:{f.Push(f.Locals[15]);f.Pc=1427;continue;}
case 1427:{f.Push(JValue.R(rt.String("classic")));f.Pc=1430;continue;}
case 1430:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1433);}
case 1433:{f.Pc=f.Pop().Int==0?1490:1436;continue;}
case 1436:{f.Push(JValue.I(1));f.Pc=1437;continue;}
case 1437:{f.Locals[16]=f.Pop();f.Pc=1439;continue;}
case 1439:{f.Pc=1490;continue;}
case 1442:{f.Push(f.Locals[15]);f.Pc=1444;continue;}
case 1444:{f.Push(JValue.R(rt.String("newstyle")));f.Pc=1447;continue;}
case 1447:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1450);}
case 1450:{f.Pc=f.Pop().Int==0?1490:1453;continue;}
case 1453:{f.Push(JValue.I(2));f.Pc=1454;continue;}
case 1454:{f.Locals[16]=f.Pop();f.Pc=1456;continue;}
case 1456:{f.Pc=1490;continue;}
case 1459:{f.Push(f.Locals[15]);f.Pc=1461;continue;}
case 1461:{f.Push(JValue.R(rt.String("modern")));f.Pc=1464;continue;}
case 1464:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1467);}
case 1467:{f.Pc=f.Pop().Int==0?1490:1470;continue;}
case 1470:{f.Push(JValue.I(3));f.Pc=1471;continue;}
case 1471:{f.Locals[16]=f.Pop();f.Pc=1473;continue;}
case 1473:{f.Pc=1490;continue;}
case 1476:{f.Push(f.Locals[15]);f.Pc=1478;continue;}
case 1478:{f.Push(JValue.R(rt.String("notsupported")));f.Pc=1481;continue;}
case 1481:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1484);}
case 1484:{f.Pc=f.Pop().Int==0?1490:1487;continue;}
case 1487:{f.Push(JValue.I(4));f.Pc=1488;continue;}
case 1488:{f.Locals[16]=f.Pop();f.Pc=1490;continue;}
case 1490:{f.Push(f.Locals[16]);f.Pc=1492;continue;}
case 1492:{switch(f.Pop().Int){case 0:f.Pc=1528;break;case 1:f.Pc=1528;break;case 2:f.Pc=1539;break;case 3:f.Pc=1539;break;case 4:f.Pc=1550;break;default:f.Pc=1550;break;}continue;}
case 1528:{f.Push(f.Locals[11]);f.Pc=1530;continue;}
case 1530:{if(!rt.StaticReady(f,"forge/card/CardEdition$FoilType","OLD_STYLE","Lforge/card/CardEdition$FoilType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$FoilType","OLD_STYLE","Lforge/card/CardEdition$FoilType;"));f.Pc=1533;continue;}
case 1533:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","foilType","Lforge/card/CardEdition$FoilType;",value);f.Pc=1536;continue;}
case 1536:{f.Pc=1558;continue;}
case 1539:{f.Push(f.Locals[11]);f.Pc=1541;continue;}
case 1541:{if(!rt.StaticReady(f,"forge/card/CardEdition$FoilType","MODERN","Lforge/card/CardEdition$FoilType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$FoilType","MODERN","Lforge/card/CardEdition$FoilType;"));f.Pc=1544;continue;}
case 1544:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","foilType","Lforge/card/CardEdition$FoilType;",value);f.Pc=1547;continue;}
case 1547:{f.Pc=1558;continue;}
case 1550:{f.Push(f.Locals[11]);f.Pc=1552;continue;}
case 1552:{if(!rt.StaticReady(f,"forge/card/CardEdition$FoilType","NOT_SUPPORTED","Lforge/card/CardEdition$FoilType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$FoilType","NOT_SUPPORTED","Lforge/card/CardEdition$FoilType;"));f.Pc=1555;continue;}
case 1555:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","foilType","Lforge/card/CardEdition$FoilType;",value);f.Pc=1558;continue;}
case 1558:{f.Push(f.Locals[6]);f.Pc=1560;continue;}
case 1560:{f.Push(JValue.R(rt.String("ChanceReplaceCommonWith")));f.Pc=1563;continue;}
case 1563:{f.Push(JValue.R(rt.String("0F Common")));f.Pc=1566;continue;}
case 1566:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1569);}
case 1569:{f.Push(JValue.R(rt.String(" ")));f.Pc=1572;continue;}
case 1572:{f.Push(JValue.I(2));f.Pc=1573;continue;}
case 1573:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",1576);}
case 1576:{f.Locals[15]=f.Pop();f.Pc=1578;continue;}
case 1578:{f.Push(f.Locals[11]);f.Pc=1580;continue;}
case 1580:{f.Push(f.Locals[15]);f.Pc=1582;continue;}
case 1582:{f.Push(JValue.I(0));f.Pc=1583;continue;}
case 1583:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1584;continue;}
case 1584:{return rt.Call(f,"java/lang/Double","parseDouble","(Ljava/lang/String;)D","invokestatic",1587);}
case 1587:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","chanceReplaceCommonWith","D",value);f.Pc=1590;continue;}
case 1590:{f.Push(f.Locals[11]);f.Pc=1592;continue;}
case 1592:{f.Push(f.Locals[15]);f.Pc=1594;continue;}
case 1594:{f.Push(JValue.I(1));f.Pc=1595;continue;}
case 1595:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1596;continue;}
case 1596:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","slotReplaceCommonWith","Ljava/lang/String;",value);f.Pc=1599;continue;}
case 1599:{f.Push(f.Locals[11]);f.Pc=1601;continue;}
case 1601:{f.Push(f.Locals[6]);f.Pc=1603;continue;}
case 1603:{f.Push(JValue.R(rt.String("FoilChanceInBooster")));f.Pc=1606;continue;}
case 1606:{f.Push(JValue.D(21.43000030517578d));f.Pc=1609;continue;}
case 1609:{return rt.Call(f,"forge/util/FileSection","getDouble","(Ljava/lang/String;D)D","invokevirtual",1612);}
case 1612:{f.Push(JValue.D(100.0d));f.Pc=1615;continue;}
case 1615:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ddiv",a,b));f.Pc=1616;continue;}
case 1616:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","foilChanceInBooster","D",value);f.Pc=1619;continue;}
case 1619:{f.Push(f.Locals[11]);f.Pc=1621;continue;}
case 1621:{f.Push(f.Locals[6]);f.Pc=1623;continue;}
case 1623:{f.Push(JValue.R(rt.String("FoilAlwaysInCommonSlot")));f.Pc=1626;continue;}
case 1626:{f.Push(JValue.I(1));f.Pc=1627;continue;}
case 1627:{return rt.Call(f,"forge/util/FileSection","getBoolean","(Ljava/lang/String;Z)Z","invokevirtual",1630);}
case 1630:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","foilAlwaysInCommonSlot","Z",value);f.Pc=1633;continue;}
case 1633:{f.Push(f.Locals[11]);f.Pc=1635;continue;}
case 1635:{f.Push(f.Locals[6]);f.Pc=1637;continue;}
case 1637:{f.Push(JValue.R(rt.String("AdditionalSheetForFoils")));f.Pc=1640;continue;}
case 1640:{f.Push(JValue.R(rt.String("")));f.Pc=1643;continue;}
case 1643:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1646);}
case 1646:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","additionalSheetForFoils","Ljava/lang/String;",value);f.Pc=1649;continue;}
case 1649:{f.Push(f.Locals[11]);f.Pc=1651;continue;}
case 1651:{f.Push(f.Locals[6]);f.Pc=1653;continue;}
case 1653:{f.Push(JValue.R(rt.String("AdditionalSetUnlockedInQuest")));f.Pc=1656;continue;}
case 1656:{f.Push(JValue.R(rt.String("")));f.Pc=1659;continue;}
case 1659:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1662);}
case 1662:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","additionalUnlockSet","Ljava/lang/String;",value);f.Pc=1665;continue;}
case 1665:{f.Push(f.Locals[11]);f.Pc=1667;continue;}
case 1667:{f.Push(f.Locals[6]);f.Pc=1669;continue;}
case 1669:{f.Push(JValue.R(rt.String("TreatAsSmallSet")));f.Pc=1672;continue;}
case 1672:{f.Push(JValue.I(0));f.Pc=1673;continue;}
case 1673:{return rt.Call(f,"forge/util/FileSection","getBoolean","(Ljava/lang/String;Z)Z","invokevirtual",1676);}
case 1676:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","smallSetOverride","Z",value);f.Pc=1679;continue;}
case 1679:{f.Push(f.Locals[11]);f.Pc=1681;continue;}
case 1681:{f.Push(f.Locals[6]);f.Pc=1683;continue;}
case 1683:{f.Push(JValue.R(rt.String("BoosterMustContain")));f.Pc=1686;continue;}
case 1686:{f.Push(JValue.R(rt.String("")));f.Pc=1689;continue;}
case 1689:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1692);}
case 1692:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","boosterMustContain","Ljava/lang/String;",value);f.Pc=1695;continue;}
case 1695:{f.Push(f.Locals[11]);f.Pc=1697;continue;}
case 1697:{f.Push(f.Locals[6]);f.Pc=1699;continue;}
case 1699:{f.Push(JValue.R(rt.String("BoosterReplaceSlotFromPrintSheet")));f.Pc=1702;continue;}
case 1702:{f.Push(JValue.R(rt.String("")));f.Pc=1705;continue;}
case 1705:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1708);}
case 1708:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","boosterReplaceSlotFromPrintSheet","Ljava/lang/String;",value);f.Pc=1711;continue;}
case 1711:{f.Push(f.Locals[11]);f.Pc=1713;continue;}
case 1713:{f.Push(f.Locals[6]);f.Pc=1715;continue;}
case 1715:{f.Push(JValue.R(rt.String("SheetReplaceCardFromSheet")));f.Pc=1718;continue;}
case 1718:{f.Push(JValue.R(rt.String("")));f.Pc=1721;continue;}
case 1721:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1724);}
case 1724:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","sheetReplaceCardFromSheet","Ljava/lang/String;",value);f.Pc=1727;continue;}
case 1727:{f.Push(f.Locals[11]);f.Pc=1729;continue;}
case 1729:{f.Push(f.Locals[6]);f.Pc=1731;continue;}
case 1731:{f.Push(JValue.R(rt.String("SheetReplaceCardFromSheet2")));f.Pc=1734;continue;}
case 1734:{f.Push(JValue.R(rt.String("")));f.Pc=1737;continue;}
case 1737:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1740);}
case 1740:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","sheetReplaceCardFromSheet2","Ljava/lang/String;",value);f.Pc=1743;continue;}
case 1743:{f.Push(f.Locals[11]);f.Pc=1745;continue;}
case 1745:{f.Push(f.Locals[6]);f.Pc=1747;continue;}
case 1747:{f.Push(JValue.R(rt.String("ChaosDraftThemes")));f.Pc=1750;continue;}
case 1750:{f.Push(JValue.R(rt.String("")));f.Pc=1753;continue;}
case 1753:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1756);}
case 1756:{f.Push(JValue.R(rt.String(";")));f.Pc=1759;continue;}
case 1759:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1762);}
case 1762:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","chaosDraftThemes","[Ljava/lang/String;",value);f.Pc=1765;continue;}
case 1765:{f.Push(f.Locals[11]);f.Pc=1767;continue;}
case 1767:{f.Push(f.Locals[6]);f.Pc=1769;continue;}
case 1769:{f.Push(JValue.R(rt.String("alias")));f.Pc=1772;continue;}
case 1772:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1775);}
case 1775:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","alias","Ljava/lang/String;",value);f.Pc=1778;continue;}
case 1778:{f.Push(f.Locals[11]);f.Pc=1780;continue;}
case 1780:{f.Push(f.Locals[6]);f.Pc=1782;continue;}
case 1782:{f.Push(JValue.R(rt.String("border")));f.Pc=1785;continue;}
case 1785:{f.Push(JValue.R(rt.String("Black")));f.Pc=1788;continue;}
case 1788:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1791);}
case 1791:{if(!rt.StaticReady(f,"java/util/Locale","ENGLISH","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ENGLISH","Ljava/util/Locale;"));f.Pc=1794;continue;}
case 1794:{return rt.Call(f,"java/lang/String","toUpperCase","(Ljava/util/Locale;)Ljava/lang/String;","invokevirtual",1797);}
case 1797:{return rt.Call(f,"forge/card/CardEdition$BorderColor","valueOf","(Ljava/lang/String;)Lforge/card/CardEdition$BorderColor;","invokestatic",1800);}
case 1800:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","borderColor","Lforge/card/CardEdition$BorderColor;",value);f.Pc=1803;continue;}
case 1803:{f.Push(f.Locals[11]);f.Pc=1805;continue;}
case 1805:{f.Push(f.Locals[6]);f.Pc=1807;continue;}
case 1807:{f.Push(JValue.R(rt.String("Prerelease")));f.Pc=1810;continue;}
case 1810:{f.Push(JValue.R(null));f.Pc=1811;continue;}
case 1811:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1814);}
case 1814:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","prerelease","Ljava/lang/String;",value);f.Pc=1817;continue;}
case 1817:{f.Push(f.Locals[11]);f.Pc=1819;continue;}
case 1819:{f.Push(f.Locals[6]);f.Pc=1821;continue;}
case 1821:{f.Push(JValue.R(rt.String("DraftType")));f.Pc=1824;continue;}
case 1824:{f.Push(JValue.R(rt.String("Normal")));f.Pc=1827;continue;}
case 1827:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1830);}
case 1830:{return rt.Call(f,"forge/card/CardEdition$DraftType","fromString","(Ljava/lang/String;)Lforge/card/CardEdition$DraftType;","invokestatic",1833);}
case 1833:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","draftType","Lforge/card/CardEdition$DraftType;",value);f.Pc=1836;continue;}
case 1836:{f.Push(f.Locals[6]);f.Pc=1838;continue;}
case 1838:{f.Push(JValue.R(rt.String("DoublePick")));f.Pc=1841;continue;}
case 1841:{f.Push(JValue.R(rt.String("Never")));f.Pc=1844;continue;}
case 1844:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1847);}
case 1847:{f.Locals[16]=f.Pop();f.Pc=1849;continue;}
case 1849:{f.Push(f.Locals[6]);f.Pc=1851;continue;}
case 1851:{f.Push(JValue.R(rt.String("MaxPodSize")));f.Pc=1854;continue;}
case 1854:{f.Push(JValue.I(8));f.Pc=1856;continue;}
case 1856:{return rt.Call(f,"forge/util/FileSection","getInt","(Ljava/lang/String;I)I","invokevirtual",1859);}
case 1859:{f.Locals[17]=f.Pop();f.Pc=1861;continue;}
case 1861:{f.Push(f.Locals[6]);f.Pc=1863;continue;}
case 1863:{f.Push(JValue.R(rt.String("RecommendedPodSize")));f.Pc=1866;continue;}
case 1866:{f.Push(JValue.I(8));f.Pc=1868;continue;}
case 1868:{return rt.Call(f,"forge/util/FileSection","getInt","(Ljava/lang/String;I)I","invokevirtual",1871);}
case 1871:{f.Locals[18]=f.Pop();f.Pc=1873;continue;}
case 1873:{f.Push(f.Locals[6]);f.Pc=1875;continue;}
case 1875:{f.Push(JValue.R(rt.String("MaxMatchPlayers")));f.Pc=1878;continue;}
case 1878:{f.Push(JValue.I(2));f.Pc=1879;continue;}
case 1879:{return rt.Call(f,"forge/util/FileSection","getInt","(Ljava/lang/String;I)I","invokevirtual",1882);}
case 1882:{f.Locals[19]=f.Pop();f.Pc=1884;continue;}
case 1884:{f.Push(f.Locals[6]);f.Pc=1886;continue;}
case 1886:{f.Push(JValue.R(rt.String("DraftFreeCommander")));f.Pc=1889;continue;}
case 1889:{f.Push(JValue.R(rt.String("")));f.Pc=1892;continue;}
case 1892:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1895);}
case 1895:{f.Locals[20]=f.Pop();f.Pc=1897;continue;}
case 1897:{f.Push(f.Locals[6]);f.Pc=1899;continue;}
case 1899:{f.Push(JValue.R(rt.String("DraftImpliedPartnership")));f.Pc=1902;continue;}
case 1902:{f.Push(JValue.R(rt.String("")));f.Pc=1905;continue;}
case 1905:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1908);}
case 1908:{f.Locals[21]=f.Pop();f.Pc=1910;continue;}
case 1910:{f.Push(f.Locals[11]);f.Pc=1912;continue;}
case 1912:{if(!rt.EnsureInitialized(f,"forge/card/DraftOptions"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/DraftOptions")));f.Pc=1915;continue;}
case 1915:{f.StackOp("dup");f.Pc=1916;continue;}
case 1916:{f.Push(f.Locals[16]);f.Pc=1918;continue;}
case 1918:{f.Push(f.Locals[17]);f.Pc=1920;continue;}
case 1920:{f.Push(f.Locals[18]);f.Pc=1922;continue;}
case 1922:{f.Push(f.Locals[19]);f.Pc=1924;continue;}
case 1924:{f.Push(f.Locals[11]);f.Pc=1926;continue;}
case 1926:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","draftType","Lforge/card/CardEdition$DraftType;"));f.Pc=1929;continue;}
case 1929:{f.Push(f.Locals[20]);f.Pc=1931;continue;}
case 1931:{f.Push(f.Locals[21]);f.Pc=1933;continue;}
case 1933:{return rt.Call(f,"forge/card/DraftOptions","<init>","(Ljava/lang/String;IIILforge/card/CardEdition$DraftType;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",1936);}
case 1936:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","draftOptions","Lforge/card/DraftOptions;",value);f.Pc=1939;continue;}
case 1939:{f.Push(f.Locals[11]);f.Pc=1941;continue;}
case 1941:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M498(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardEdition$Reader","TXT_FILE_FILTER","Ljava/io/FilenameFilter;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Reader","TXT_FILE_FILTER","Ljava/io/FilenameFilter;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M499(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardEdition$Reader","read","(Ljava/io/File;)Lforge/card/CardEdition;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M500(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(".txt")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M501(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("(^(.?[0-9A-Z-]+\\S*[A-Z]*)\\s)?(([SCURML])\\s)?([^@$]+)( @([^$]*))?( \\$\\{(.+)\\})?$")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",6);}
case 6:{if(!rt.StaticReady(f,"forge/card/CardEdition$Reader","CARD_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Reader","CARD_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("(^(.?[0-9A-Z-]+\\S?[A-Z\u2607]*)\\s)?([^@]+)( @(.*))?$")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",15);}
case 15:{if(!rt.StaticReady(f,"forge/card/CardEdition$Reader","TOKEN_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Reader","TOKEN_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("\"([^\"]+)\"\\s*:\\s*\"([^\"]+)\",?")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",24);}
case 24:{if(!rt.StaticReady(f,"forge/card/CardEdition$Reader","EXTRA_PARAMS_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Reader","EXTRA_PARAMS_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=27;continue;}
case 27:{return rt.DynamicCall(f,"forge/card/CardEdition$Reader:501:27:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/io/FilenameFilter;",32);}
case 32:{if(!rt.StaticReady(f,"forge/card/CardEdition$Reader","TXT_FILE_FILTER","Ljava/io/FilenameFilter;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Reader","TXT_FILE_FILTER","Ljava/io/FilenameFilter;",f.Pop());f.Pc=35;continue;}
case 35:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
