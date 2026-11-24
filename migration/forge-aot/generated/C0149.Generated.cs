// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C149{
internal static JClass Build(){var c=new JClass("forge/game/GameFormat$Reader","forge/util/storage/StorageReaderRecursiveFolderWithUserFolder",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("naturallyOrdered","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("includeArchived","Z",false,JValue.Default("Z"),null));
c.Add(new JField("coreFormats","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("cardPoolFormats","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("TXT_FILE_FILTER","Ljava/io/FilenameFilter;",true,JValue.Default("Ljava/io/FilenameFilter;"),null));
c.Add(new JMethod(2357,"forge/game/GameFormat$Reader","<init>","(Ljava/io/File;Ljava/io/File;Z)V",1,4,4,new JHandler[]{},M2357));
c.Add(new JMethod(2358,"forge/game/GameFormat$Reader","read","(Ljava/io/File;)Lforge/game/GameFormat;",4,25,15,new JHandler[]{new JHandler(92,107,110,"java/lang/Exception"),new JHandler(158,173,176,"java/lang/Exception")},M2358));
c.Add(new JMethod(2359,"forge/game/GameFormat$Reader","listOrEmpty","(Ljava/util/List;)Ljava/util/List;",10,1,1,new JHandler[]{},M2359));
c.Add(new JMethod(2360,"forge/game/GameFormat$Reader","readDeckRules","(Lforge/util/FileSection;Ljava/lang/String;)Lforge/game/GameFormat$DeckRules;",10,10,6,new JHandler[]{new JHandler(59,95,98,"java/lang/RuntimeException")},M2360));
c.Add(new JMethod(2361,"forge/game/GameFormat$Reader","readAll","()Ljava/util/Map;",1,8,3,new JHandler[]{},M2361));
c.Add(new JMethod(2362,"forge/game/GameFormat$Reader","withCardPool","(Lforge/game/GameFormat$Reader$CardPoolFormat;Lforge/game/GameFormat;)Lforge/game/GameFormat;",10,5,14,new JHandler[]{},M2362));
c.Add(new JMethod(2363,"forge/game/GameFormat$Reader","getFileFilter","()Ljava/io/FilenameFilter;",4,1,1,new JHandler[]{},M2363));
c.Add(new JMethod(2364,"forge/game/GameFormat$Reader","read","(Ljava/io/File;)Ljava/lang/Object;",4164,2,2,new JHandler[]{},M2364));
c.Add(new JMethod(2365,"forge/game/GameFormat$Reader","lambda$static$0","(Ljava/io/File;Ljava/lang/String;)Z",4106,2,2,new JHandler[]{},M2365));
c.Add(new JMethod(2366,"forge/game/GameFormat$Reader","<clinit>","()V",8,0,1,new JHandler[]{},M2366));
}

internal static JStep M2357(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.DynamicCall(f,"forge/game/GameFormat$Reader:2357:3:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",8);}
case 8:{return rt.Call(f,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","<init>","(Ljava/io/File;Ljava/io/File;Ljava/util/function/Function;)V","invokespecial",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Reader","naturallyOrdered","Ljava/util/List;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",30);}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Reader","coreFormats","Ljava/util/List;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","coreFormats","Ljava/util/List;"));f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("Standard.txt")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",44);}
case 44:{f.StackOp("pop");f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","coreFormats","Ljava/util/List;"));f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("Pioneer.txt")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","coreFormats","Ljava/util/List;"));f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Historic.txt")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",68);}
case 68:{f.StackOp("pop");f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","coreFormats","Ljava/util/List;"));f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("Modern.txt")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",80);}
case 80:{f.StackOp("pop");f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","coreFormats","Ljava/util/List;"));f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("Legacy.txt")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",92);}
case 92:{f.StackOp("pop");f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","coreFormats","Ljava/util/List;"));f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.String("Vintage.txt")));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",104);}
case 104:{f.StackOp("pop");f.Pc=105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","coreFormats","Ljava/util/List;"));f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("Commander.txt")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",116);}
case 116:{f.StackOp("pop");f.Pc=117;continue;}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","coreFormats","Ljava/util/List;"));f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("Extended.txt")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",128);}
case 128:{f.StackOp("pop");f.Pc=129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","coreFormats","Ljava/util/List;"));f.Pc=133;continue;}
case 133:{f.Push(JValue.R(rt.String("Brawl.txt")));f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",140);}
case 140:{f.StackOp("pop");f.Pc=141;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","coreFormats","Ljava/util/List;"));f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.String("Oathbreaker.txt")));f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",152);}
case 152:{f.StackOp("pop");f.Pc=153;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","coreFormats","Ljava/util/List;"));f.Pc=157;continue;}
case 157:{f.Push(JValue.R(rt.String("Premodern.txt")));f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",164);}
case 164:{f.StackOp("pop");f.Pc=165;continue;}
case 165:{f.Push(f.Locals[0]);f.Pc=166;continue;}
case 166:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","coreFormats","Ljava/util/List;"));f.Pc=169;continue;}
case 169:{f.Push(JValue.R(rt.String("Pauper.txt")));f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",176);}
case 176:{f.StackOp("pop");f.Pc=177;continue;}
case 177:{f.Push(f.Locals[0]);f.Pc=178;continue;}
case 178:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","coreFormats","Ljava/util/List;"));f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.String("PreDH.txt")));f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",188);}
case 188:{f.StackOp("pop");f.Pc=189;continue;}
case 189:{f.Push(f.Locals[0]);f.Pc=190;continue;}
case 190:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","coreFormats","Ljava/util/List;"));f.Pc=193;continue;}
case 193:{f.Push(JValue.R(rt.String("Canadian Highlander.txt")));f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",200);}
case 200:{f.StackOp("pop");f.Pc=201;continue;}
case 201:{f.Push(f.Locals[0]);f.Pc=202;continue;}
case 202:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=205;continue;}
case 205:{f.StackOp("dup");f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",209);}
case 209:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Reader","cardPoolFormats","Ljava/util/List;",value);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[3]);f.Pc=214;continue;}
case 214:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Reader","includeArchived","Z",value);f.Pc=217;continue;}
case 217:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2358(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","includeArchived","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?25:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","coreFormats","Ljava/util/List;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/io/File","getName","()Ljava/lang/String;","invokevirtual",15);}
case 15:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int!=0?25:23;continue;}
case 23:{f.Push(JValue.R(null));f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/util/FileUtil","readFile","(Ljava/io/File;)Ljava/util/List;","invokestatic",29);}
case 29:{return rt.Call(f,"forge/util/FileSection","parseSections","(Ljava/util/List;)Ljava/util/Map;","invokestatic",32);}
case 32:{f.Locals[2]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(JValue.R(null));f.Pc=34;continue;}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(JValue.R(null));f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(JValue.R(null));f.Pc=39;continue;}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",45);}
case 45:{f.Locals[6]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(JValue.R(null));f.Pc=48;continue;}
case 48:{f.Locals[7]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(JValue.R(null));f.Pc=51;continue;}
case 51:{f.Locals[8]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("format")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{f.Locals[9]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[9]);f.Pc=68;continue;}
case 68:{f.Pc=f.Pop().Reference!=null?73:71;continue;}
case 71:{f.Push(JValue.R(null));f.Pc=72;continue;}
case 72:{return JStep.Return(f.Pop());}
case 73:{f.Push(f.Locals[9]);f.Pc=75;continue;}
case 75:{if(!rt.StaticReady(f,"forge/util/FileSection","COLON_KV_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/FileSection","COLON_KV_SEPARATOR","Ljava/util/regex/Pattern;"));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/util/FileSection","parse","(Ljava/lang/Iterable;Ljava/util/regex/Pattern;)Lforge/util/FileSection;","invokestatic",81);}
case 81:{f.Locals[10]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[10]);f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("name")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",90);}
case 90:{f.Locals[11]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[10]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("type")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",99);}
case 99:{return rt.Call(f,"java/lang/String","toUpperCase","()Ljava/lang/String;","invokevirtual",102);}
case 102:{return rt.Call(f,"forge/game/GameFormat$FormatType","valueOf","(Ljava/lang/String;)Lforge/game/GameFormat$FormatType;","invokestatic",105);}
case 105:{f.Locals[12]=f.Pop();f.Pc=107;continue;}
case 107:{f.Pc=158;continue;}
case 110:{f.Locals[13]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("HISTORIC")));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[10]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("type")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",121);}
case 121:{return rt.Call(f,"java/lang/String","toUpperCase","()Ljava/lang/String;","invokevirtual",124);}
case 124:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int==0?153:130;continue;}
case 130:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/io/File","getAbsolutePath","()Ljava/lang/String;","invokevirtual",137);}
case 137:{return rt.DynamicCall(f,"forge/game/GameFormat$Reader:2358:137:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",142);}
case 142:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",145);}
case 145:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatType","ARCHIVED","Lforge/game/GameFormat$FormatType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatType","ARCHIVED","Lforge/game/GameFormat$FormatType;"));f.Pc=148;continue;}
case 148:{f.Locals[12]=f.Pop();f.Pc=150;continue;}
case 150:{f.Pc=158;continue;}
case 153:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatType","CUSTOM","Lforge/game/GameFormat$FormatType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatType","CUSTOM","Lforge/game/GameFormat$FormatType;"));f.Pc=156;continue;}
case 156:{f.Locals[12]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[10]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("subtype")));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",165);}
case 165:{return rt.Call(f,"java/lang/String","toUpperCase","()Ljava/lang/String;","invokevirtual",168);}
case 168:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","valueOf","(Ljava/lang/String;)Lforge/game/GameFormat$FormatSubType;","invokestatic",171);}
case 171:{f.Locals[13]=f.Pop();f.Pc=173;continue;}
case 173:{f.Pc=183;continue;}
case 176:{f.Locals[14]=f.Pop();f.Pc=178;continue;}
case 178:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","CUSTOM","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","CUSTOM","Lforge/game/GameFormat$FormatSubType;"));f.Pc=181;continue;}
case 181:{f.Locals[13]=f.Pop();f.Pc=183;continue;}
case 183:{f.Push(f.Locals[10]);f.Pc=185;continue;}
case 185:{f.Push(JValue.R(rt.String("order")));f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/util/FileSection","getInt","(Ljava/lang/String;)I","invokevirtual",190);}
case 190:{f.Locals[14]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[10]);f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("effective")));f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",199);}
case 199:{f.Locals[15]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[15]);f.Pc=203;continue;}
case 203:{f.Pc=f.Pop().Reference!=null?210:206;continue;}
case 206:{f.Push(JValue.R(rt.String("1990-01-01")));f.Pc=208;continue;}
case 208:{f.Locals[15]=f.Pop();f.Pc=210;continue;}
case 210:{f.Push(f.Locals[15]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/GameFormat","parseDate","(Ljava/lang/String;)Ljava/util/Date;","invokestatic",215);}
case 215:{f.Locals[16]=f.Pop();f.Pc=217;continue;}
case 217:{f.Push(f.Locals[10]);f.Pc=219;continue;}
case 219:{f.Push(JValue.R(rt.String("sets")));f.Pc=221;continue;}
case 221:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",224);}
case 224:{f.Locals[17]=f.Pop();f.Pc=226;continue;}
case 226:{f.Push(JValue.R(null));f.Pc=227;continue;}
case 227:{f.Push(f.Locals[17]);f.Pc=229;continue;}
case 229:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?243:232;continue;}
case 232:{f.Push(f.Locals[17]);f.Pc=234;continue;}
case 234:{f.Push(JValue.R(rt.String(", ")));f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",239);}
case 239:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",242);}
case 242:{f.Locals[3]=f.Pop();f.Pc=243;continue;}
case 243:{f.Push(f.Locals[10]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String("banned")));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",250);}
case 250:{f.Locals[18]=f.Pop();f.Pc=252;continue;}
case 252:{f.Push(f.Locals[18]);f.Pc=254;continue;}
case 254:{f.Pc=f.Pop().Reference==null?269:257;continue;}
case 257:{f.Push(f.Locals[18]);f.Pc=259;continue;}
case 259:{f.Push(JValue.R(rt.String("; ")));f.Pc=261;continue;}
case 261:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",264);}
case 264:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",267);}
case 267:{f.Locals[4]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(f.Locals[10]);f.Pc=271;continue;}
case 271:{f.Push(JValue.R(rt.String("restricted")));f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",276);}
case 276:{f.Locals[18]=f.Pop();f.Pc=278;continue;}
case 278:{f.Push(f.Locals[18]);f.Pc=280;continue;}
case 280:{f.Pc=f.Pop().Reference==null?295:283;continue;}
case 283:{f.Push(f.Locals[18]);f.Pc=285;continue;}
case 285:{f.Push(JValue.R(rt.String("; ")));f.Pc=287;continue;}
case 287:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",290);}
case 290:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",293);}
case 293:{f.Locals[5]=f.Pop();f.Pc=295;continue;}
case 295:{f.Push(f.Locals[10]);f.Pc=297;continue;}
case 297:{f.Push(JValue.R(rt.String("restrictedlegendary")));f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/util/FileSection","getBoolean","(Ljava/lang/String;)Z","invokevirtual",302);}
case 302:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",305);}
case 305:{f.Locals[19]=f.Pop();f.Pc=307;continue;}
case 307:{f.Push(f.Locals[19]);f.Pc=309;continue;}
case 309:{f.Pc=f.Pop().Reference==null?316:312;continue;}
case 312:{f.Push(f.Locals[19]);f.Pc=314;continue;}
case 314:{f.Locals[6]=f.Pop();f.Pc=316;continue;}
case 316:{f.Push(f.Locals[10]);f.Pc=318;continue;}
case 318:{f.Push(JValue.R(rt.String("additional")));f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",323);}
case 323:{f.Locals[18]=f.Pop();f.Pc=325;continue;}
case 325:{f.Push(f.Locals[18]);f.Pc=327;continue;}
case 327:{f.Pc=f.Pop().Reference==null?342:330;continue;}
case 330:{f.Push(f.Locals[18]);f.Pc=332;continue;}
case 332:{f.Push(JValue.R(rt.String("; ")));f.Pc=334;continue;}
case 334:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",337);}
case 337:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",340);}
case 340:{f.Locals[7]=f.Pop();f.Pc=342;continue;}
case 342:{f.Push(f.Locals[10]);f.Pc=344;continue;}
case 344:{f.Push(JValue.R(rt.String("rarities")));f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",349);}
case 349:{f.Locals[18]=f.Pop();f.Pc=351;continue;}
case 351:{f.Push(f.Locals[18]);f.Pc=353;continue;}
case 353:{f.Pc=f.Pop().Reference==null?428:356;continue;}
case 356:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",359);}
case 359:{f.Locals[8]=f.Pop();f.Pc=361;continue;}
case 361:{f.Push(f.Locals[18]);f.Pc=363;continue;}
case 363:{f.Push(JValue.R(rt.String(", ")));f.Pc=365;continue;}
case 365:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",368);}
case 368:{f.Locals[21]=f.Pop();f.Pc=370;continue;}
case 370:{f.Push(f.Locals[21]);f.Pc=372;continue;}
case 372:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=373;continue;}
case 373:{f.Locals[22]=f.Pop();f.Pc=375;continue;}
case 375:{f.Push(JValue.I(0));f.Pc=376;continue;}
case 376:{f.Locals[23]=f.Pop();f.Pc=378;continue;}
case 378:{f.Push(f.Locals[23]);f.Pc=380;continue;}
case 380:{f.Push(f.Locals[22]);f.Pc=382;continue;}
case 382:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?428:385;continue;}
case 385:{f.Push(f.Locals[21]);f.Pc=387;continue;}
case 387:{f.Push(f.Locals[23]);f.Pc=389;continue;}
case 389:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=390;continue;}
case 390:{f.Locals[24]=f.Pop();f.Pc=392;continue;}
case 392:{f.Push(f.Locals[24]);f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/card/CardRarity","smartValueOf","(Ljava/lang/String;)Lforge/card/CardRarity;","invokestatic",397);}
case 397:{f.Locals[20]=f.Pop();f.Pc=399;continue;}
case 399:{f.Push(f.Locals[20]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/card/CardRarity","name","()Ljava/lang/String;","invokevirtual",404);}
case 404:{f.Push(JValue.R(rt.String("Unknown")));f.Pc=406;continue;}
case 406:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",409);}
case 409:{f.Pc=f.Pop().Int!=0?422:412;continue;}
case 412:{f.Push(f.Locals[8]);f.Pc=414;continue;}
case 414:{f.Push(f.Locals[20]);f.Pc=416;continue;}
case 416:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",421);}
case 421:{f.StackOp("pop");f.Pc=422;continue;}
case 422:{f.Locals[23]=JValue.I(unchecked(f.Locals[23].Int+(1)));f.Pc=425;continue;}
case 425:{f.Pc=378;continue;}
case 428:{f.Push(f.Locals[10]);f.Pc=430;continue;}
case 430:{f.Push(f.Locals[11]);f.Pc=432;continue;}
case 432:{return rt.Call(f,"forge/game/GameFormat$Reader","readDeckRules","(Lforge/util/FileSection;Ljava/lang/String;)Lforge/game/GameFormat$DeckRules;","invokestatic",435);}
case 435:{f.Locals[20]=f.Pop();f.Pc=437;continue;}
case 437:{f.Push(f.Locals[1]);f.Pc=438;continue;}
case 438:{return rt.Call(f,"java/io/File","toPath","()Ljava/nio/file/Path;","invokevirtual",441);}
case 441:{f.Push(f.Locals[0]);f.Pc=442;continue;}
case 442:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","directory","Ljava/io/File;"));f.Pc=445;continue;}
case 445:{return rt.Call(f,"java/io/File","toPath","()Ljava/nio/file/Path;","invokevirtual",448);}
case 448:{return rt.Call(f,"java/nio/file/Path","startsWith","(Ljava/nio/file/Path;)Z","invokeinterface",453);}
case 453:{f.Pc=f.Pop().Int==0?463:456;continue;}
case 456:{f.Push(f.Locals[0]);f.Pc=457;continue;}
case 457:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","directory","Ljava/io/File;"));f.Pc=460;continue;}
case 460:{f.Pc=467;continue;}
case 463:{f.Push(f.Locals[0]);f.Pc=464;continue;}
case 464:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","userDirectory","Ljava/io/File;"));f.Pc=467;continue;}
case 467:{f.Locals[21]=f.Pop();f.Pc=469;continue;}
case 469:{f.Push(f.Locals[21]);f.Pc=471;continue;}
case 471:{return rt.Call(f,"java/io/File","toPath","()Ljava/nio/file/Path;","invokevirtual",474);}
case 474:{f.Push(f.Locals[1]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"java/io/File","getParentFile","()Ljava/io/File;","invokevirtual",478);}
case 478:{return rt.Call(f,"java/io/File","toPath","()Ljava/nio/file/Path;","invokevirtual",481);}
case 481:{return rt.Call(f,"java/nio/file/Path","relativize","(Ljava/nio/file/Path;)Ljava/nio/file/Path;","invokeinterface",486);}
case 486:{return rt.Call(f,"java/nio/file/Path","toString","()Ljava/lang/String;","invokeinterface",491);}
case 491:{if(!rt.StaticReady(f,"java/io/File","separatorChar","C"))return JStep.Continue;f.Push(rt.GetStatic("java/io/File","separatorChar","C"));f.Pc=494;continue;}
case 494:{f.Push(JValue.I(47));f.Pc=496;continue;}
case 496:{return rt.Call(f,"java/lang/String","replace","(CC)Ljava/lang/String;","invokevirtual",499);}
case 499:{f.Locals[22]=f.Pop();f.Pc=501;continue;}
case 501:{f.Push(f.Locals[10]);f.Pc=503;continue;}
case 503:{f.Push(JValue.R(rt.String("cardpool")));f.Pc=506;continue;}
case 506:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",509);}
case 509:{f.Locals[23]=f.Pop();f.Pc=511;continue;}
case 511:{f.Push(f.Locals[23]);f.Pc=513;continue;}
case 513:{f.Pc=f.Pop().Reference==null?568:516;continue;}
case 516:{f.Push(f.Locals[0]);f.Pc=517;continue;}
case 517:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","cardPoolFormats","Ljava/util/List;"));f.Pc=520;continue;}
case 520:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$Reader$CardPoolFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$Reader$CardPoolFormat")));f.Pc=523;continue;}
case 523:{f.StackOp("dup");f.Pc=524;continue;}
case 524:{f.Push(f.Locals[23]);f.Pc=526;continue;}
case 526:{f.Push(f.Locals[11]);f.Pc=528;continue;}
case 528:{f.Push(f.Locals[16]);f.Pc=530;continue;}
case 530:{f.Push(f.Locals[4]);f.Pc=532;continue;}
case 532:{return rt.Call(f,"forge/game/GameFormat$Reader","listOrEmpty","(Ljava/util/List;)Ljava/util/List;","invokestatic",535);}
case 535:{f.Push(f.Locals[5]);f.Pc=537;continue;}
case 537:{f.Push(f.Locals[6]);f.Pc=539;continue;}
case 539:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",542);}
case 542:{f.Push(f.Locals[7]);f.Pc=544;continue;}
case 544:{return rt.Call(f,"forge/game/GameFormat$Reader","listOrEmpty","(Ljava/util/List;)Ljava/util/List;","invokestatic",547);}
case 547:{f.Push(f.Locals[14]);f.Pc=549;continue;}
case 549:{f.Push(f.Locals[12]);f.Pc=551;continue;}
case 551:{f.Push(f.Locals[13]);f.Pc=553;continue;}
case 553:{f.Push(f.Locals[20]);f.Pc=555;continue;}
case 555:{f.Push(f.Locals[22]);f.Pc=557;continue;}
case 557:{return rt.Call(f,"forge/game/GameFormat$Reader$CardPoolFormat","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;Ljava/util/List;Ljava/util/List;ZLjava/util/List;ILforge/game/GameFormat$FormatType;Lforge/game/GameFormat$FormatSubType;Lforge/game/GameFormat$DeckRules;Ljava/lang/String;)V","invokespecial",560);}
case 560:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",565);}
case 565:{f.StackOp("pop");f.Pc=566;continue;}
case 566:{f.Push(JValue.R(null));f.Pc=567;continue;}
case 567:{return JStep.Return(f.Pop());}
case 568:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat")));f.Pc=571;continue;}
case 571:{f.StackOp("dup");f.Pc=572;continue;}
case 572:{f.Push(f.Locals[11]);f.Pc=574;continue;}
case 574:{f.Push(f.Locals[16]);f.Pc=576;continue;}
case 576:{f.Push(f.Locals[3]);f.Pc=577;continue;}
case 577:{f.Push(f.Locals[4]);f.Pc=579;continue;}
case 579:{f.Push(f.Locals[5]);f.Pc=581;continue;}
case 581:{f.Push(f.Locals[6]);f.Pc=583;continue;}
case 583:{f.Push(f.Locals[7]);f.Pc=585;continue;}
case 585:{f.Push(f.Locals[8]);f.Pc=587;continue;}
case 587:{f.Push(f.Locals[14]);f.Pc=589;continue;}
case 589:{f.Push(f.Locals[12]);f.Pc=591;continue;}
case 591:{f.Push(f.Locals[13]);f.Pc=593;continue;}
case 593:{f.Push(f.Locals[20]);f.Pc=595;continue;}
case 595:{return rt.Call(f,"forge/game/GameFormat","<init>","(Ljava/lang/String;Ljava/util/Date;Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/lang/Boolean;Ljava/util/List;Ljava/util/List;ILforge/game/GameFormat$FormatType;Lforge/game/GameFormat$FormatSubType;Lforge/game/GameFormat$DeckRules;)V","invokespecial",598);}
case 598:{f.Locals[24]=f.Pop();f.Pc=600;continue;}
case 600:{f.Push(f.Locals[24]);f.Pc=602;continue;}
case 602:{f.Push(f.Locals[22]);f.Pc=604;continue;}
case 604:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","folder","Ljava/lang/String;",value);f.Pc=607;continue;}
case 607:{f.Push(f.Locals[0]);f.Pc=608;continue;}
case 608:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","naturallyOrdered","Ljava/util/List;"));f.Pc=611;continue;}
case 611:{f.Push(f.Locals[24]);f.Pc=613;continue;}
case 613:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",618);}
case 618:{f.StackOp("pop");f.Pc=619;continue;}
case 619:{f.Push(f.Locals[24]);f.Pc=621;continue;}
case 621:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2359(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?10:4;continue;}
case 4:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",7);}
case 7:{f.Pc=11;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2360(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("points")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Reference==null?120:20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("; ")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=31;continue;}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{f.Locals[6]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[6]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?120:43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=48;continue;}
case 48:{f.Locals[7]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[7]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(61));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","lastIndexOf","(I)I","invokevirtual",57);}
case 57:{f.Locals[8]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[7]);f.Pc=62;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[8]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",68);}
case 68:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",71);}
case 71:{f.Push(f.Locals[7]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[8]);f.Pc=75;continue;}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",80);}
case 80:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",83);}
case 83:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",86);}
case 86:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",89);}
case 89:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",94);}
case 94:{f.StackOp("pop");f.Pc=95;continue;}
case 95:{f.Pc=114;continue;}
case 98:{f.Locals[9]=f.Pop();f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=103;continue;}
case 103:{f.Push(f.Locals[7]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{return rt.DynamicCall(f,"forge/game/GameFormat$Reader:2360:106:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",111);}
case 111:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",114);}
case 114:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=117;continue;}
case 117:{f.Pc=36;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("singleton")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/util/FileSection","getBoolean","(Ljava/lang/String;)Z","invokevirtual",127);}
case 127:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",130);}
case 130:{f.Locals[4]=f.Pop();f.Pc=132;continue;}
case 132:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$DeckRules"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$DeckRules")));f.Pc=135;continue;}
case 135:{f.StackOp("dup");f.Pc=136;continue;}
case 136:{f.Push(f.Locals[4]);f.Pc=138;continue;}
case 138:{f.Pc=f.Pop().Reference==null?153:141;continue;}
case 141:{f.Push(f.Locals[4]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",146);}
case 146:{f.Pc=f.Pop().Int==0?153:149;continue;}
case 149:{f.Push(JValue.I(1));f.Pc=150;continue;}
case 150:{f.Pc=154;continue;}
case 153:{f.Push(JValue.I(0));f.Pc=154;continue;}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.String("mindecksize")));f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/util/FileSection","getInt","(Ljava/lang/String;)I","invokevirtual",161);}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{f.Push(JValue.R(rt.String("maxpoints")));f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/util/FileSection","getInt","(Ljava/lang/String;)I","invokevirtual",168);}
case 168:{f.Push(f.Locals[2]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/util/Map","copyOf","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",172);}
case 172:{return rt.Call(f,"forge/game/GameFormat$DeckRules","<init>","(ZIILjava/util/Map;)V","invokespecial",175);}
case 175:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2361(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","readAll","()Ljava/util/Map;","invokespecial",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","cardPoolFormats","Ljava/util/List;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Int==0?126:23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int==0?123:43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat$Reader$CardPoolFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[5]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/GameFormat$Reader$CardPoolFormat","cardPool","()Ljava/lang/String;","invokevirtual",61);}
case 61:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",66);}
case 66:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=69;continue;}
case 69:{f.Locals[6]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[6]);f.Pc=73;continue;}
case 73:{f.Pc=f.Pop().Reference==null?120:76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[6]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/GameFormat$Reader","withCardPool","(Lforge/game/GameFormat$Reader$CardPoolFormat;Lforge/game/GameFormat;)Lforge/game/GameFormat;","invokestatic",83);}
case 83:{f.Locals[7]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[7]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/GameFormat","getName","()Ljava/lang/String;","invokevirtual",91);}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",98);}
case 98:{f.StackOp("pop");f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","naturallyOrdered","Ljava/util/List;"));f.Pc=103;continue;}
case 103:{f.Push(f.Locals[7]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",110);}
case 110:{f.StackOp("pop");f.Pc=111;continue;}
case 111:{f.Push(f.Locals[4]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/util/Iterator","remove","()V","invokeinterface",118);}
case 118:{f.Push(JValue.I(1));f.Pc=119;continue;}
case 119:{f.Locals[3]=f.Pop();f.Pc=120;continue;}
case 120:{f.Pc=33;continue;}
case 123:{f.Pc=19;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",132);}
case 132:{f.Locals[4]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[4]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",141);}
case 141:{f.Pc=f.Pop().Int==0?180:144;continue;}
case 144:{f.Push(f.Locals[4]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",151);}
case 151:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat$Reader$CardPoolFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=154;continue;}
case 154:{f.Locals[5]=f.Pop();f.Pc=156;continue;}
case 156:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=159;continue;}
case 159:{f.Push(f.Locals[5]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/GameFormat$Reader$CardPoolFormat","title","()Ljava/lang/String;","invokevirtual",164);}
case 164:{f.Push(f.Locals[5]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/game/GameFormat$Reader$CardPoolFormat","cardPool","()Ljava/lang/String;","invokevirtual",169);}
case 169:{return rt.DynamicCall(f,"forge/game/GameFormat$Reader:2361:169:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",174);}
case 174:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",177);}
case 177:{f.Pc=134;continue;}
case 180:{f.Push(f.Locals[1]);f.Pc=181;continue;}
case 181:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2362(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameFormat","getBannedCardNames","()Ljava/util/List;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/GameFormat$Reader$CardPoolFormat","bannedCards","()Ljava/util/List;","invokevirtual",17);}
case 17:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",22);}
case 22:{f.StackOp("pop");f.Pc=23;continue;}
case 23:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/GameFormat","getAdditionalCards","()Ljava/util/List;","invokevirtual",31);}
case 31:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",34);}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/GameFormat$Reader$CardPoolFormat","additionalCards","()Ljava/util/List;","invokevirtual",40);}
case 40:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",45);}
case 45:{f.StackOp("pop");f.Pc=46;continue;}
case 46:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat")));f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/GameFormat$Reader$CardPoolFormat","title","()Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/GameFormat$Reader$CardPoolFormat","date","()Ljava/util/Date;","invokevirtual",58);}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/GameFormat","getAllowedSetCodes","()Ljava/util/List;","invokevirtual",62);}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/GameFormat$Reader$CardPoolFormat","restrictedCards","()Ljava/util/List;","invokevirtual",67);}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/GameFormat$Reader$CardPoolFormat","restrictedLegendary","()Z","invokevirtual",71);}
case 71:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",74);}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/GameFormat","getAllowedRarities","()Ljava/util/List;","invokevirtual",79);}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/GameFormat$Reader$CardPoolFormat","index","()I","invokevirtual",83);}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/GameFormat$Reader$CardPoolFormat","formatType","()Lforge/game/GameFormat$FormatType;","invokevirtual",87);}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/GameFormat$Reader$CardPoolFormat","formatSubType","()Lforge/game/GameFormat$FormatSubType;","invokevirtual",91);}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/GameFormat$Reader$CardPoolFormat","deckRules","()Lforge/game/GameFormat$DeckRules;","invokevirtual",95);}
case 95:{return rt.Call(f,"forge/game/GameFormat","<init>","(Ljava/lang/String;Ljava/util/Date;Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/lang/Boolean;Ljava/util/List;Ljava/util/List;ILforge/game/GameFormat$FormatType;Lforge/game/GameFormat$FormatSubType;Lforge/game/GameFormat$DeckRules;)V","invokespecial",98);}
case 98:{f.Locals[4]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[4]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/GameFormat$Reader$CardPoolFormat","folder","()Ljava/lang/String;","invokevirtual",106);}
case 106:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","folder","Ljava/lang/String;",value);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[4]);f.Pc=111;continue;}
case 111:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2363(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/GameFormat$Reader","TXT_FILE_FILTER","Ljava/io/FilenameFilter;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$Reader","TXT_FILE_FILTER","Ljava/io/FilenameFilter;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2364(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameFormat$Reader","read","(Ljava/io/File;)Lforge/game/GameFormat;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2365(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(".txt")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?17:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/io/File","isDirectory","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2366(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/GameFormat$Reader:2366:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/io/FilenameFilter;",5);}
case 5:{if(!rt.StaticReady(f,"forge/game/GameFormat$Reader","TXT_FILE_FILTER","Ljava/io/FilenameFilter;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$Reader","TXT_FILE_FILTER","Ljava/io/FilenameFilter;",f.Pop());f.Pc=8;continue;}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
