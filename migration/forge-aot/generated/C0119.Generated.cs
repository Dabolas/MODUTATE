// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C119{
internal static JClass Build(){var c=new JClass("forge/deck/io/DeckFileHeader","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("NAME","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Name"));
c.Add(new JField("DECK_TYPE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Deck Type"));
c.Add(new JField("SOURCE_URL","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Source URL"));
c.Add(new JField("TAGS","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Tags"));
c.Add(new JField("TAGS_SEPARATOR","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),","));
c.Add(new JField("DRAFT_NOTES","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"DraftNotes"));
c.Add(new JField("KEY_CARDS","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"KeyCards"));
c.Add(new JField("ALT_COMMANDERS","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"AltCommanders"));
c.Add(new JField("SLEEVE_ART","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"SleeveArt"));
c.Add(new JField("SLEEVE_OFFSET","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"SleeveOffset"));
c.Add(new JField("COMMENT","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Comment"));
c.Add(new JField("PLAYER","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Player"));
c.Add(new JField("CSTM_POOL","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Custom Pool"));
c.Add(new JField("PLAYER_TYPE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"PlayerType"));
c.Add(new JField("AI_HINTS","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"AiHints"));
c.Add(new JField("deckType","Lforge/deck/DeckFormat;",false,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("sourceUrl","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("customPool","Z",false,JValue.Default("Z"),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("comment","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("tags","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("draftNotes","Ljava/util/HashMap;",false,JValue.Default("Ljava/util/HashMap;"),null));
c.Add(new JField("keyCards","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("altCommanders","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("intendedForAi","Z",false,JValue.Default("Z"),null));
c.Add(new JField("aiHints","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sleeveArtKey","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sleeveArtOffset","I",false,JValue.Default("I"),null));
c.Add(new JMethod(1731,"forge/deck/io/DeckFileHeader","isIntendedForAi","()Z",1,1,1,new JHandler[]{},M1731));
c.Add(new JMethod(1732,"forge/deck/io/DeckFileHeader","getAiHints","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1732));
c.Add(new JMethod(1733,"forge/deck/io/DeckFileHeader","<init>","(Lforge/util/FileSection;)V",1,9,4,new JHandler[]{},M1733));
c.Add(new JMethod(1734,"forge/deck/io/DeckFileHeader","extractDraftNotes","(Ljava/lang/String;)V",2,7,4,new JHandler[]{},M1734));
c.Add(new JMethod(1735,"forge/deck/io/DeckFileHeader","isCustomPool","()Z",17,1,1,new JHandler[]{},M1735));
c.Add(new JMethod(1736,"forge/deck/io/DeckFileHeader","getName","()Ljava/lang/String;",17,1,1,new JHandler[]{},M1736));
c.Add(new JMethod(1737,"forge/deck/io/DeckFileHeader","getComment","()Ljava/lang/String;",17,1,1,new JHandler[]{},M1737));
c.Add(new JMethod(1738,"forge/deck/io/DeckFileHeader","getDeckType","()Lforge/deck/DeckFormat;",17,1,1,new JHandler[]{},M1738));
c.Add(new JMethod(1739,"forge/deck/io/DeckFileHeader","getSourceUrl","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1739));
c.Add(new JMethod(1740,"forge/deck/io/DeckFileHeader","getTags","()Ljava/util/Set;",17,1,1,new JHandler[]{},M1740));
c.Add(new JMethod(1741,"forge/deck/io/DeckFileHeader","getDraftNotes","()Ljava/util/HashMap;",17,1,1,new JHandler[]{},M1741));
c.Add(new JMethod(1742,"forge/deck/io/DeckFileHeader","getKeyCards","()Ljava/util/List;",17,1,1,new JHandler[]{},M1742));
c.Add(new JMethod(1743,"forge/deck/io/DeckFileHeader","getAltCommanders","()Ljava/util/List;",17,1,1,new JHandler[]{},M1743));
c.Add(new JMethod(1744,"forge/deck/io/DeckFileHeader","getSleeveArtKey","()Ljava/lang/String;",17,1,1,new JHandler[]{},M1744));
c.Add(new JMethod(1745,"forge/deck/io/DeckFileHeader","getSleeveArtOffset","()I",17,1,1,new JHandler[]{},M1745));
}

internal static JStep M1731(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","intendedForAi","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1732(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","aiHints","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1733(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Name")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",11);}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/io/DeckFileHeader","name","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Comment")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",21);}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/io/DeckFileHeader","comment","Ljava/lang/String;",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("Deck Type")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",31);}
case 31:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/deck/DeckFormat","smartValueOf","(Ljava/lang/String;Lforge/deck/DeckFormat;)Lforge/deck/DeckFormat;","invokestatic",37);}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/io/DeckFileHeader","deckType","Lforge/deck/DeckFormat;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("Source URL")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",47);}
case 47:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/io/DeckFileHeader","sourceUrl","Ljava/lang/String;",value);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("Custom Pool")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/util/FileSection","getBoolean","(Ljava/lang/String;)Z","invokevirtual",57);}
case 57:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/io/DeckFileHeader","customPool","Z",value);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("computer")));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("Player")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",69);}
case 69:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int!=0?89:75;continue;}
case 75:{f.Push(JValue.R(rt.String("ai")));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("PlayerType")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",83);}
case 83:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int==0?93:89;continue;}
case 89:{f.Push(JValue.I(1));f.Pc=90;continue;}
case 90:{f.Pc=94;continue;}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/io/DeckFileHeader","intendedForAi","Z",value);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("AiHints")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",104);}
case 104:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/io/DeckFileHeader","aiHints","Ljava/lang/String;",value);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("SleeveArt")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",114);}
case 114:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/io/DeckFileHeader","sleeveArtKey","Ljava/lang/String;",value);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("SleeveOffset")));f.Pc=121;continue;}
case 121:{f.Push(JValue.I(500));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/util/FileSection","getInt","(Ljava/lang/String;I)I","invokevirtual",127);}
case 127:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/io/DeckFileHeader","sleeveArtOffset","I",value);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{if(!rt.EnsureInitialized(f,"java/util/TreeSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeSet")));f.Pc=134;continue;}
case 134:{f.StackOp("dup");f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/TreeSet","<init>","()V","invokespecial",138);}
case 138:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/io/DeckFileHeader","tags","Ljava/util/Set;",value);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[1]);f.Pc=142;continue;}
case 142:{f.Push(JValue.R(rt.String("Tags")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",147);}
case 147:{f.Locals[2]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[2]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotBlank","(Ljava/lang/CharSequence;)Z","invokestatic",152);}
case 152:{f.Pc=f.Pop().Int==0?211:155;continue;}
case 155:{f.Push(f.Locals[2]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String(",")));f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",161);}
case 161:{f.Locals[3]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[3]);f.Pc=163;continue;}
case 163:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=164;continue;}
case 164:{f.Locals[4]=f.Pop();f.Pc=166;continue;}
case 166:{f.Push(JValue.I(0));f.Pc=167;continue;}
case 167:{f.Locals[5]=f.Pop();f.Pc=169;continue;}
case 169:{f.Push(f.Locals[5]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[4]);f.Pc=173;continue;}
case 173:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?211:176;continue;}
case 176:{f.Push(f.Locals[3]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[5]);f.Pc=179;continue;}
case 179:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=180;continue;}
case 180:{f.Locals[6]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(f.Locals[6]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotBlank","(Ljava/lang/CharSequence;)Z","invokestatic",187);}
case 187:{f.Pc=f.Pop().Int==0?205:190;continue;}
case 190:{f.Push(f.Locals[0]);f.Pc=191;continue;}
case 191:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","tags","Ljava/util/Set;"));f.Pc=194;continue;}
case 194:{f.Push(f.Locals[6]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",199);}
case 199:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",204);}
case 204:{f.StackOp("pop");f.Pc=205;continue;}
case 205:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=208;continue;}
case 208:{f.Pc=169;continue;}
case 211:{f.Push(f.Locals[0]);f.Pc=212;continue;}
case 212:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=215;continue;}
case 215:{f.StackOp("dup");f.Pc=216;continue;}
case 216:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",219);}
case 219:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/io/DeckFileHeader","draftNotes","Ljava/util/HashMap;",value);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[0]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[1]);f.Pc=224;continue;}
case 224:{f.Push(JValue.R(rt.String("DraftNotes")));f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",229);}
case 229:{return rt.Call(f,"forge/deck/io/DeckFileHeader","extractDraftNotes","(Ljava/lang/String;)V","invokevirtual",232);}
case 232:{f.Push(f.Locals[0]);f.Pc=233;continue;}
case 233:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=236;continue;}
case 236:{f.StackOp("dup");f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",240);}
case 240:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/io/DeckFileHeader","keyCards","Ljava/util/List;",value);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[1]);f.Pc=244;continue;}
case 244:{f.Push(JValue.R(rt.String("KeyCards")));f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",249);}
case 249:{f.Locals[3]=f.Pop();f.Pc=250;continue;}
case 250:{f.Push(f.Locals[3]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotBlank","(Ljava/lang/CharSequence;)Z","invokestatic",254);}
case 254:{f.Pc=f.Pop().Int==0?316:257;continue;}
case 257:{f.Push(f.Locals[3]);f.Pc=258;continue;}
case 258:{f.Push(JValue.R(rt.String(";")));f.Pc=260;continue;}
case 260:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",263);}
case 263:{f.Locals[4]=f.Pop();f.Pc=265;continue;}
case 265:{f.Push(f.Locals[4]);f.Pc=267;continue;}
case 267:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=268;continue;}
case 268:{f.Locals[5]=f.Pop();f.Pc=270;continue;}
case 270:{f.Push(JValue.I(0));f.Pc=271;continue;}
case 271:{f.Locals[6]=f.Pop();f.Pc=273;continue;}
case 273:{f.Push(f.Locals[6]);f.Pc=275;continue;}
case 275:{f.Push(f.Locals[5]);f.Pc=277;continue;}
case 277:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?316:280;continue;}
case 280:{f.Push(f.Locals[4]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[6]);f.Pc=284;continue;}
case 284:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=285;continue;}
case 285:{f.Locals[7]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[7]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotBlank","(Ljava/lang/CharSequence;)Z","invokestatic",292);}
case 292:{f.Pc=f.Pop().Int==0?310:295;continue;}
case 295:{f.Push(f.Locals[0]);f.Pc=296;continue;}
case 296:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","keyCards","Ljava/util/List;"));f.Pc=299;continue;}
case 299:{f.Push(f.Locals[7]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",304);}
case 304:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",309);}
case 309:{f.StackOp("pop");f.Pc=310;continue;}
case 310:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=313;continue;}
case 313:{f.Pc=273;continue;}
case 316:{f.Push(f.Locals[0]);f.Pc=317;continue;}
case 317:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=320;continue;}
case 320:{f.StackOp("dup");f.Pc=321;continue;}
case 321:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",324);}
case 324:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/io/DeckFileHeader","altCommanders","Ljava/util/List;",value);f.Pc=327;continue;}
case 327:{f.Push(f.Locals[1]);f.Pc=328;continue;}
case 328:{f.Push(JValue.R(rt.String("AltCommanders")));f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",333);}
case 333:{f.Locals[4]=f.Pop();f.Pc=335;continue;}
case 335:{f.Push(f.Locals[4]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotBlank","(Ljava/lang/CharSequence;)Z","invokestatic",340);}
case 340:{f.Pc=f.Pop().Int==0?403:343;continue;}
case 343:{f.Push(f.Locals[4]);f.Pc=345;continue;}
case 345:{f.Push(JValue.R(rt.String(";")));f.Pc=347;continue;}
case 347:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",350);}
case 350:{f.Locals[5]=f.Pop();f.Pc=352;continue;}
case 352:{f.Push(f.Locals[5]);f.Pc=354;continue;}
case 354:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=355;continue;}
case 355:{f.Locals[6]=f.Pop();f.Pc=357;continue;}
case 357:{f.Push(JValue.I(0));f.Pc=358;continue;}
case 358:{f.Locals[7]=f.Pop();f.Pc=360;continue;}
case 360:{f.Push(f.Locals[7]);f.Pc=362;continue;}
case 362:{f.Push(f.Locals[6]);f.Pc=364;continue;}
case 364:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?403:367;continue;}
case 367:{f.Push(f.Locals[5]);f.Pc=369;continue;}
case 369:{f.Push(f.Locals[7]);f.Pc=371;continue;}
case 371:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=372;continue;}
case 372:{f.Locals[8]=f.Pop();f.Pc=374;continue;}
case 374:{f.Push(f.Locals[8]);f.Pc=376;continue;}
case 376:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotBlank","(Ljava/lang/CharSequence;)Z","invokestatic",379);}
case 379:{f.Pc=f.Pop().Int==0?397:382;continue;}
case 382:{f.Push(f.Locals[0]);f.Pc=383;continue;}
case 383:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","altCommanders","Ljava/util/List;"));f.Pc=386;continue;}
case 386:{f.Push(f.Locals[8]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",391);}
case 391:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",396);}
case 396:{f.StackOp("pop");f.Pc=397;continue;}
case 397:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=400;continue;}
case 400:{f.Pc=360;continue;}
case 403:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1734(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int==0?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("\\|")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=17;continue;}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?114:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=31;continue;}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",38);}
case 38:{f.Pc=f.Pop().Int==0?44:41;continue;}
case 41:{f.Pc=108;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",49);}
case 49:{f.Push(JValue.R(rt.String(":")));f.Pc=51;continue;}
case 51:{f.Push(JValue.I(2));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",55);}
case 55:{f.Locals[6]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",64);}
case 64:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int!=0?108:70;continue;}
case 70:{f.Push(f.Locals[6]);f.Pc=72;continue;}
case 72:{f.Push(JValue.I(1));f.Pc=73;continue;}
case 73:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",77);}
case 77:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int==0?86:83;continue;}
case 83:{f.Pc=108;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","draftNotes","Ljava/util/HashMap;"));f.Pc=90;continue;}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{f.Push(JValue.I(0));f.Pc=93;continue;}
case 93:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",97);}
case 97:{f.Push(f.Locals[6]);f.Pc=99;continue;}
case 99:{f.Push(JValue.I(1));f.Pc=100;continue;}
case 100:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",104);}
case 104:{return rt.Call(f,"java/util/HashMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",107);}
case 107:{f.StackOp("pop");f.Pc=108;continue;}
case 108:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=111;continue;}
case 111:{f.Pc=21;continue;}
case 114:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1735(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","customPool","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1736(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1737(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","comment","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1738(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","deckType","Lforge/deck/DeckFormat;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1739(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","sourceUrl","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1740(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","tags","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1741(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","draftNotes","Ljava/util/HashMap;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1742(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","keyCards","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1743(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","altCommanders","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1744(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","sleeveArtKey","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1745(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckFileHeader","sleeveArtOffset","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
