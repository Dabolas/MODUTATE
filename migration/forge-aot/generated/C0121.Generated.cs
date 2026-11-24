// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C121{
internal static JClass Build(){var c=new JClass("forge/deck/io/DeckSerializer","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(1757,"forge/deck/io/DeckSerializer","<init>","()V",1,1,1,new JHandler[]{},M1757));
c.Add(new JMethod(1758,"forge/deck/io/DeckSerializer","writeDeck","(Lforge/deck/Deck;Ljava/io/File;)V",9,2,2,new JHandler[]{},M1758));
c.Add(new JMethod(1759,"forge/deck/io/DeckSerializer","readDeckMetadata","(Ljava/util/Map;)Lforge/deck/io/DeckFileHeader;",8,4,4,new JHandler[]{},M1759));
c.Add(new JMethod(1760,"forge/deck/io/DeckSerializer","serializeDeck","(Lforge/deck/Deck;)Ljava/util/List;",10,4,7,new JHandler[]{},M1760));
c.Add(new JMethod(1761,"forge/deck/io/DeckSerializer","serializeDraftNotes","(Ljava/util/Map;)Ljava/lang/String;",9,4,3,new JHandler[]{},M1761));
c.Add(new JMethod(1762,"forge/deck/io/DeckSerializer","fromFile","(Ljava/io/File;)Lforge/deck/Deck;",9,1,1,new JHandler[]{},M1762));
c.Add(new JMethod(1763,"forge/deck/io/DeckSerializer","fromSections","(Ljava/util/Map;)Lforge/deck/Deck;",9,5,3,new JHandler[]{},M1763));
}

internal static JStep M1757(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1758(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/io/DeckSerializer","serializeDeck","(Lforge/deck/Deck;)Ljava/util/List;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/util/FileUtil","writeFile","(Ljava/io/File;Ljava/util/Collection;)V","invokestatic",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1759(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("metadata")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",14);}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Reference==null?37:22;continue;}
case 22:{if(!rt.EnsureInitialized(f,"forge/deck/io/DeckFileHeader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/io/DeckFileHeader")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/util/FileSection","EQUALS_KV_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/FileSection","EQUALS_KV_SEPARATOR","Ljava/util/regex/Pattern;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/util/FileSection","parse","(Ljava/lang/Iterable;Ljava/util/regex/Pattern;)Lforge/util/FileSection;","invokestatic",33);}
case 33:{return rt.Call(f,"forge/deck/io/DeckFileHeader","<init>","(Lforge/util/FileSection;)V","invokespecial",36);}
case 36:{return JStep.Return(f.Pop());}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("general")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",45);}
case 45:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=48;continue;}
case 48:{f.Locals[2]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Pc=f.Pop().Reference==null?104:53;continue;}
case 53:{if(!rt.EnsureInitialized(f,"forge/util/FileSectionManual"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/FileSectionManual")));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/util/FileSectionManual","<init>","()V","invokespecial",60);}
case 60:{f.Locals[3]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.String("Name")));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String(" ")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",80);}
case 80:{return rt.Call(f,"forge/util/FileSectionManual","put","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",83);}
case 83:{f.Push(f.Locals[3]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("Deck Type")));f.Pc=86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String(" ")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",92);}
case 92:{return rt.Call(f,"forge/util/FileSectionManual","put","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",95);}
case 95:{if(!rt.EnsureInitialized(f,"forge/deck/io/DeckFileHeader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/io/DeckFileHeader")));f.Pc=98;continue;}
case 98:{f.StackOp("dup");f.Pc=99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/deck/io/DeckFileHeader","<init>","(Lforge/util/FileSection;)V","invokespecial",103);}
case 103:{return JStep.Return(f.Pop());}
case 104:{f.Push(JValue.R(null));f.Pc=105;continue;}
case 105:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1760(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("metadata")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/util/TextUtil","enclosedBracket","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",14);}
case 14:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(3));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Name")));f.Pc=29;continue;}
case 29:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("=")));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(2));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/deck/Deck","getName","()Ljava/lang/String;","invokevirtual",41);}
case 41:{f.Push(JValue.R(rt.String("\n")));f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",48);}
case 48:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",52);}
case 52:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",57);}
case 57:{f.StackOp("pop");f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/deck/Deck","getDeckFormat","()Lforge/deck/DeckFormat;","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Reference==null?99:65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(JValue.I(3));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=70;continue;}
case 70:{f.StackOp("dup");f.Pc=71;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("Deck Type")));f.Pc=74;continue;}
case 74:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{f.Push(JValue.I(1));f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("=")));f.Pc=79;continue;}
case 79:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=80;continue;}
case 80:{f.StackOp("dup");f.Pc=81;continue;}
case 81:{f.Push(JValue.I(2));f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/deck/Deck","getDeckFormat","()Lforge/deck/DeckFormat;","invokevirtual",86);}
case 86:{return rt.Call(f,"forge/deck/DeckFormat","name","()Ljava/lang/String;","invokevirtual",89);}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",93);}
case 93:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",98);}
case 98:{f.StackOp("pop");f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/deck/Deck","getSourceUrl","()Ljava/lang/String;","invokevirtual",103);}
case 103:{f.Pc=f.Pop().Reference==null?144:106;continue;}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{f.Push(JValue.I(3));f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{f.Push(JValue.I(0));f.Pc=113;continue;}
case 113:{f.Push(JValue.R(rt.String("Source URL")));f.Pc=115;continue;}
case 115:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=116;continue;}
case 116:{f.StackOp("dup");f.Pc=117;continue;}
case 117:{f.Push(JValue.I(1));f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("=")));f.Pc=120;continue;}
case 120:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=121;continue;}
case 121:{f.StackOp("dup");f.Pc=122;continue;}
case 122:{f.Push(JValue.I(2));f.Pc=123;continue;}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/deck/Deck","getSourceUrl","()Ljava/lang/String;","invokevirtual",127);}
case 127:{f.Push(JValue.R(rt.String("\n")));f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.String("")));f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",134);}
case 134:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",138);}
case 138:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",143);}
case 143:{f.StackOp("pop");f.Pc=144;continue;}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/deck/Deck","getComment","()Ljava/lang/String;","invokevirtual",148);}
case 148:{f.Pc=f.Pop().Reference==null?189:151;continue;}
case 151:{f.Push(f.Locals[1]);f.Pc=152;continue;}
case 152:{f.Push(JValue.I(3));f.Pc=153;continue;}
case 153:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=156;continue;}
case 156:{f.StackOp("dup");f.Pc=157;continue;}
case 157:{f.Push(JValue.I(0));f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("Comment")));f.Pc=160;continue;}
case 160:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=161;continue;}
case 161:{f.StackOp("dup");f.Pc=162;continue;}
case 162:{f.Push(JValue.I(1));f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.String("=")));f.Pc=165;continue;}
case 165:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=166;continue;}
case 166:{f.StackOp("dup");f.Pc=167;continue;}
case 167:{f.Push(JValue.I(2));f.Pc=168;continue;}
case 168:{f.Push(f.Locals[0]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/deck/Deck","getComment","()Ljava/lang/String;","invokevirtual",172);}
case 172:{f.Push(JValue.R(rt.String("\n")));f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("")));f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",179);}
case 179:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",183);}
case 183:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",188);}
case 188:{f.StackOp("pop");f.Pc=189;continue;}
case 189:{f.Push(f.Locals[0]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/deck/Deck","getTags","()Ljava/util/Set;","invokevirtual",193);}
case 193:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",198);}
case 198:{f.Pc=f.Pop().Int!=0?237:201;continue;}
case 201:{f.Push(f.Locals[1]);f.Pc=202;continue;}
case 202:{f.Push(JValue.I(3));f.Pc=203;continue;}
case 203:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=206;continue;}
case 206:{f.StackOp("dup");f.Pc=207;continue;}
case 207:{f.Push(JValue.I(0));f.Pc=208;continue;}
case 208:{f.Push(JValue.R(rt.String("Tags")));f.Pc=210;continue;}
case 210:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=211;continue;}
case 211:{f.StackOp("dup");f.Pc=212;continue;}
case 212:{f.Push(JValue.I(1));f.Pc=213;continue;}
case 213:{f.Push(JValue.R(rt.String("=")));f.Pc=215;continue;}
case 215:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=216;continue;}
case 216:{f.StackOp("dup");f.Pc=217;continue;}
case 217:{f.Push(JValue.I(2));f.Pc=218;continue;}
case 218:{f.Push(f.Locals[0]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/deck/Deck","getTags","()Ljava/util/Set;","invokevirtual",222);}
case 222:{f.Push(JValue.R(rt.String(",")));f.Pc=224;continue;}
case 224:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",227);}
case 227:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",231);}
case 231:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",236);}
case 236:{f.StackOp("pop");f.Pc=237;continue;}
case 237:{f.Push(f.Locals[0]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/deck/Deck","getAiHints","()Ljava/util/Set;","invokevirtual",241);}
case 241:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",246);}
case 246:{f.Pc=f.Pop().Int!=0?285:249;continue;}
case 249:{f.Push(f.Locals[1]);f.Pc=250;continue;}
case 250:{f.Push(JValue.I(3));f.Pc=251;continue;}
case 251:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=254;continue;}
case 254:{f.StackOp("dup");f.Pc=255;continue;}
case 255:{f.Push(JValue.I(0));f.Pc=256;continue;}
case 256:{f.Push(JValue.R(rt.String("AiHints")));f.Pc=258;continue;}
case 258:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=259;continue;}
case 259:{f.StackOp("dup");f.Pc=260;continue;}
case 260:{f.Push(JValue.I(1));f.Pc=261;continue;}
case 261:{f.Push(JValue.R(rt.String("=")));f.Pc=263;continue;}
case 263:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=264;continue;}
case 264:{f.StackOp("dup");f.Pc=265;continue;}
case 265:{f.Push(JValue.I(2));f.Pc=266;continue;}
case 266:{f.Push(f.Locals[0]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/deck/Deck","getAiHints","()Ljava/util/Set;","invokevirtual",270);}
case 270:{f.Push(JValue.R(rt.String(" | ")));f.Pc=272;continue;}
case 272:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",275);}
case 275:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",279);}
case 279:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",284);}
case 284:{f.StackOp("pop");f.Pc=285;continue;}
case 285:{f.Push(f.Locals[0]);f.Pc=286;continue;}
case 286:{return rt.Call(f,"forge/deck/Deck","getDraftNotes","()Ljava/util/Map;","invokevirtual",289);}
case 289:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",294);}
case 294:{f.Pc=f.Pop().Int!=0?333:297;continue;}
case 297:{f.Push(f.Locals[0]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/deck/Deck","getDraftNotes","()Ljava/util/Map;","invokevirtual",301);}
case 301:{return rt.Call(f,"forge/deck/io/DeckSerializer","serializeDraftNotes","(Ljava/util/Map;)Ljava/lang/String;","invokestatic",304);}
case 304:{f.Locals[2]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(f.Locals[1]);f.Pc=306;continue;}
case 306:{f.Push(JValue.I(3));f.Pc=307;continue;}
case 307:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=310;continue;}
case 310:{f.StackOp("dup");f.Pc=311;continue;}
case 311:{f.Push(JValue.I(0));f.Pc=312;continue;}
case 312:{f.Push(JValue.R(rt.String("DraftNotes")));f.Pc=314;continue;}
case 314:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=315;continue;}
case 315:{f.StackOp("dup");f.Pc=316;continue;}
case 316:{f.Push(JValue.I(1));f.Pc=317;continue;}
case 317:{f.Push(JValue.R(rt.String("=")));f.Pc=319;continue;}
case 319:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=320;continue;}
case 320:{f.StackOp("dup");f.Pc=321;continue;}
case 321:{f.Push(JValue.I(2));f.Pc=322;continue;}
case 322:{f.Push(f.Locals[2]);f.Pc=323;continue;}
case 323:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",327);}
case 327:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",332);}
case 332:{f.StackOp("pop");f.Pc=333;continue;}
case 333:{f.Push(f.Locals[0]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/deck/Deck","getKeyCards","()Ljava/util/List;","invokevirtual",337);}
case 337:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",342);}
case 342:{f.Pc=f.Pop().Int!=0?381:345;continue;}
case 345:{f.Push(f.Locals[1]);f.Pc=346;continue;}
case 346:{f.Push(JValue.I(3));f.Pc=347;continue;}
case 347:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=350;continue;}
case 350:{f.StackOp("dup");f.Pc=351;continue;}
case 351:{f.Push(JValue.I(0));f.Pc=352;continue;}
case 352:{f.Push(JValue.R(rt.String("KeyCards")));f.Pc=354;continue;}
case 354:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=355;continue;}
case 355:{f.StackOp("dup");f.Pc=356;continue;}
case 356:{f.Push(JValue.I(1));f.Pc=357;continue;}
case 357:{f.Push(JValue.R(rt.String("=")));f.Pc=359;continue;}
case 359:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=360;continue;}
case 360:{f.StackOp("dup");f.Pc=361;continue;}
case 361:{f.Push(JValue.I(2));f.Pc=362;continue;}
case 362:{f.Push(f.Locals[0]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/deck/Deck","getKeyCards","()Ljava/util/List;","invokevirtual",366);}
case 366:{f.Push(JValue.R(rt.String(";")));f.Pc=368;continue;}
case 368:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",371);}
case 371:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",375);}
case 375:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",380);}
case 380:{f.StackOp("pop");f.Pc=381;continue;}
case 381:{f.Push(f.Locals[0]);f.Pc=382;continue;}
case 382:{return rt.Call(f,"forge/deck/Deck","getAltCommanders","()Ljava/util/List;","invokevirtual",385);}
case 385:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",390);}
case 390:{f.Pc=f.Pop().Int!=0?429:393;continue;}
case 393:{f.Push(f.Locals[1]);f.Pc=394;continue;}
case 394:{f.Push(JValue.I(3));f.Pc=395;continue;}
case 395:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=398;continue;}
case 398:{f.StackOp("dup");f.Pc=399;continue;}
case 399:{f.Push(JValue.I(0));f.Pc=400;continue;}
case 400:{f.Push(JValue.R(rt.String("AltCommanders")));f.Pc=402;continue;}
case 402:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=403;continue;}
case 403:{f.StackOp("dup");f.Pc=404;continue;}
case 404:{f.Push(JValue.I(1));f.Pc=405;continue;}
case 405:{f.Push(JValue.R(rt.String("=")));f.Pc=407;continue;}
case 407:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=408;continue;}
case 408:{f.StackOp("dup");f.Pc=409;continue;}
case 409:{f.Push(JValue.I(2));f.Pc=410;continue;}
case 410:{f.Push(f.Locals[0]);f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/deck/Deck","getAltCommanders","()Ljava/util/List;","invokevirtual",414);}
case 414:{f.Push(JValue.R(rt.String(";")));f.Pc=416;continue;}
case 416:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",419);}
case 419:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",423);}
case 423:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",428);}
case 428:{f.StackOp("pop");f.Pc=429;continue;}
case 429:{f.Push(f.Locals[0]);f.Pc=430;continue;}
case 430:{return rt.Call(f,"forge/deck/Deck","getSleeveArtKey","()Ljava/lang/String;","invokevirtual",433);}
case 433:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",436);}
case 436:{f.Pc=f.Pop().Int!=0?514:439;continue;}
case 439:{f.Push(f.Locals[1]);f.Pc=440;continue;}
case 440:{f.Push(JValue.I(3));f.Pc=441;continue;}
case 441:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=444;continue;}
case 444:{f.StackOp("dup");f.Pc=445;continue;}
case 445:{f.Push(JValue.I(0));f.Pc=446;continue;}
case 446:{f.Push(JValue.R(rt.String("SleeveArt")));f.Pc=448;continue;}
case 448:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=449;continue;}
case 449:{f.StackOp("dup");f.Pc=450;continue;}
case 450:{f.Push(JValue.I(1));f.Pc=451;continue;}
case 451:{f.Push(JValue.R(rt.String("=")));f.Pc=453;continue;}
case 453:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=454;continue;}
case 454:{f.StackOp("dup");f.Pc=455;continue;}
case 455:{f.Push(JValue.I(2));f.Pc=456;continue;}
case 456:{f.Push(f.Locals[0]);f.Pc=457;continue;}
case 457:{return rt.Call(f,"forge/deck/Deck","getSleeveArtKey","()Ljava/lang/String;","invokevirtual",460);}
case 460:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=461;continue;}
case 461:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",464);}
case 464:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",469);}
case 469:{f.StackOp("pop");f.Pc=470;continue;}
case 470:{f.Push(f.Locals[0]);f.Pc=471;continue;}
case 471:{return rt.Call(f,"forge/deck/Deck","getSleeveArtOffset","()I","invokevirtual",474);}
case 474:{f.Push(JValue.I(500));f.Pc=477;continue;}
case 477:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?514:480;continue;}
case 480:{f.Push(f.Locals[1]);f.Pc=481;continue;}
case 481:{f.Push(JValue.I(3));f.Pc=482;continue;}
case 482:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=485;continue;}
case 485:{f.StackOp("dup");f.Pc=486;continue;}
case 486:{f.Push(JValue.I(0));f.Pc=487;continue;}
case 487:{f.Push(JValue.R(rt.String("SleeveOffset")));f.Pc=489;continue;}
case 489:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=490;continue;}
case 490:{f.StackOp("dup");f.Pc=491;continue;}
case 491:{f.Push(JValue.I(1));f.Pc=492;continue;}
case 492:{f.Push(JValue.R(rt.String("=")));f.Pc=494;continue;}
case 494:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=495;continue;}
case 495:{f.StackOp("dup");f.Pc=496;continue;}
case 496:{f.Push(JValue.I(2));f.Pc=497;continue;}
case 497:{f.Push(f.Locals[0]);f.Pc=498;continue;}
case 498:{return rt.Call(f,"forge/deck/Deck","getSleeveArtOffset","()I","invokevirtual",501);}
case 501:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",504);}
case 504:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=505;continue;}
case 505:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",508);}
case 508:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",513);}
case 513:{f.StackOp("pop");f.Pc=514;continue;}
case 514:{f.Push(f.Locals[0]);f.Pc=515;continue;}
case 515:{return rt.Call(f,"forge/deck/Deck","iterator","()Ljava/util/Iterator;","invokevirtual",518);}
case 518:{f.Locals[2]=f.Pop();f.Pc=519;continue;}
case 519:{f.Push(f.Locals[2]);f.Pc=520;continue;}
case 520:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",525);}
case 525:{f.Pc=f.Pop().Int==0?603:528;continue;}
case 528:{f.Push(f.Locals[2]);f.Pc=529;continue;}
case 529:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",534);}
case 534:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=537;continue;}
case 537:{f.Locals[3]=f.Pop();f.Pc=538;continue;}
case 538:{f.Push(f.Locals[3]);f.Pc=539;continue;}
case 539:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",544);}
case 544:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=547;continue;}
case 547:{return rt.Call(f,"forge/deck/CardPool","isEmpty","()Z","invokevirtual",550);}
case 550:{f.Pc=f.Pop().Int==0?556:553;continue;}
case 553:{f.Pc=519;continue;}
case 556:{f.Push(f.Locals[1]);f.Pc=557;continue;}
case 557:{f.Push(f.Locals[3]);f.Pc=558;continue;}
case 558:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",563);}
case 563:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckSection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=566;continue;}
case 566:{return rt.Call(f,"forge/deck/DeckSection","toString","()Ljava/lang/String;","invokevirtual",569);}
case 569:{return rt.Call(f,"forge/util/TextUtil","enclosedBracket","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",572);}
case 572:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",577);}
case 577:{f.StackOp("pop");f.Pc=578;continue;}
case 578:{f.Push(f.Locals[1]);f.Pc=579;continue;}
case 579:{f.Push(f.Locals[3]);f.Pc=580;continue;}
case 580:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",585);}
case 585:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=588;continue;}
case 588:{return rt.Call(f,"java/lang/System","lineSeparator","()Ljava/lang/String;","invokestatic",591);}
case 591:{return rt.Call(f,"forge/deck/CardPool","toCardList","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",594);}
case 594:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",599);}
case 599:{f.StackOp("pop");f.Pc=600;continue;}
case 600:{f.Pc=519;continue;}
case 603:{f.Push(f.Locals[1]);f.Pc=604;continue;}
case 604:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1761(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",14);}
case 14:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?80:29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int<=0?53:46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String(" | ")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",58);}
case 58:{f.Push(JValue.R(rt.String(":")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",63);}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",76);}
case 76:{f.StackOp("pop");f.Pc=77;continue;}
case 77:{f.Pc=20;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",84);}
case 84:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1762(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/FileUtil","readFile","(Ljava/io/File;)Ljava/util/List;","invokestatic",4);}
case 4:{return rt.Call(f,"forge/util/FileSection","parseSections","(Ljava/util/List;)Ljava/util/Map;","invokestatic",7);}
case 7:{return rt.Call(f,"forge/deck/io/DeckSerializer","fromSections","(Ljava/util/Map;)Lforge/deck/Deck;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1763(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?13:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?15:13;continue;}
case 13:{f.Push(JValue.R(null));f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/deck/io/DeckSerializer","readDeckMetadata","(Ljava/util/Map;)Lforge/deck/io/DeckFileHeader;","invokestatic",19);}
case 19:{f.Locals[1]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Reference!=null?26:24;continue;}
case 24:{f.Push(JValue.R(null));f.Pc=25;continue;}
case 25:{return JStep.Return(f.Pop());}
case 26:{if(!rt.EnsureInitialized(f,"forge/deck/Deck"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/Deck")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/deck/io/DeckFileHeader","getName","()Ljava/lang/String;","invokevirtual",34);}
case 34:{return rt.Call(f,"forge/deck/Deck","<init>","(Ljava/lang/String;)V","invokespecial",37);}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/deck/io/DeckFileHeader","getComment","()Ljava/lang/String;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/deck/Deck","setComment","(Ljava/lang/String;)V","invokevirtual",46);}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/deck/io/DeckFileHeader","getDeckType","()Lforge/deck/DeckFormat;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/deck/Deck","setDeckFormat","(Lforge/deck/DeckFormat;)V","invokevirtual",54);}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/deck/io/DeckFileHeader","getSourceUrl","()Ljava/lang/String;","invokevirtual",59);}
case 59:{return rt.Call(f,"forge/deck/Deck","setSourceUrl","(Ljava/lang/String;)V","invokevirtual",62);}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/deck/io/DeckFileHeader","getAiHints","()Ljava/lang/String;","invokevirtual",67);}
case 67:{return rt.Call(f,"forge/deck/Deck","setAiHints","(Ljava/lang/String;)V","invokevirtual",70);}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/deck/Deck","getTags","()Ljava/util/Set;","invokevirtual",74);}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/deck/io/DeckFileHeader","getTags","()Ljava/util/Set;","invokevirtual",78);}
case 78:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/deck/io/DeckFileHeader","getDraftNotes","()Ljava/util/HashMap;","invokevirtual",89);}
case 89:{return rt.Call(f,"forge/deck/Deck","setDraftNotes","(Ljava/util/Map;)V","invokevirtual",92);}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/deck/io/DeckFileHeader","getKeyCards","()Ljava/util/List;","invokevirtual",96);}
case 96:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",101);}
case 101:{f.Locals[3]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",108);}
case 108:{f.Pc=f.Pop().Int==0?131:111;continue;}
case 111:{f.Push(f.Locals[3]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",117);}
case 117:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=120;continue;}
case 120:{f.Locals[4]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[2]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[4]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/deck/Deck","addKeyCard","(Ljava/lang/String;)V","invokevirtual",128);}
case 128:{f.Pc=102;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/deck/io/DeckFileHeader","getAltCommanders","()Ljava/util/List;","invokevirtual",135);}
case 135:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",140);}
case 140:{f.Locals[3]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[3]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",147);}
case 147:{f.Pc=f.Pop().Int==0?170:150;continue;}
case 150:{f.Push(f.Locals[3]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",156);}
case 156:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=159;continue;}
case 159:{f.Locals[4]=f.Pop();f.Pc=161;continue;}
case 161:{f.Push(f.Locals[2]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[4]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/deck/Deck","addAltCommander","(Ljava/lang/String;)V","invokevirtual",167);}
case 167:{f.Pc=141;continue;}
case 170:{f.Push(f.Locals[2]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[1]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/deck/io/DeckFileHeader","getSleeveArtKey","()Ljava/lang/String;","invokevirtual",175);}
case 175:{return rt.Call(f,"forge/deck/Deck","setSleeveArtKey","(Ljava/lang/String;)V","invokevirtual",178);}
case 178:{f.Push(f.Locals[2]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[1]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/deck/io/DeckFileHeader","getSleeveArtOffset","()I","invokevirtual",183);}
case 183:{return rt.Call(f,"forge/deck/Deck","setSleeveArtOffset","(I)V","invokevirtual",186);}
case 186:{f.Push(f.Locals[2]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[0]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/deck/Deck","setDeferredSections","(Ljava/util/Map;)V","invokevirtual",191);}
case 191:{f.Push(f.Locals[2]);f.Pc=192;continue;}
case 192:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
