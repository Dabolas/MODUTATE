// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C281{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DebuffEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3308,"forge/game/ability/effects/DebuffEffect","<init>","()V",1,1,1,new JHandler[]{},M3308));
c.Add(new JMethod(3309,"forge/game/ability/effects/DebuffEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,7,3,new JHandler[]{},M3309));
c.Add(new JMethod(3310,"forge/game/ability/effects/DebuffEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,23,7,new JHandler[]{},M3310));
}

internal static JStep M3308(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3309(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("Keywords")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?34:13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("Keywords")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",20);}
case 20:{f.Push(JValue.R(rt.String(" & ")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",25);}
case 25:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",28);}
case 28:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",41);}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/ability/effects/DebuffEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",46);}
case 46:{f.Locals[4]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int<=0?175:58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",65);}
case 65:{f.Locals[5]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[5]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",74);}
case 74:{f.Pc=f.Pop().Int==0?134:77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",84);}
case 84:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=87;continue;}
case 87:{f.Locals[6]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[6]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?107:97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("Morph")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",103);}
case 103:{f.StackOp("pop");f.Pc=104;continue;}
case 104:{f.Pc=114;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[6]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",113);}
case 113:{f.StackOp("pop");f.Pc=114;continue;}
case 114:{f.Push(f.Locals[5]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",121);}
case 121:{f.Pc=f.Pop().Int==0?131:124;continue;}
case 124:{f.Push(f.Locals[3]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String(" ")));f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",130);}
case 130:{f.StackOp("pop");f.Pc=131;continue;}
case 131:{f.Pc=67;continue;}
case 134:{f.Push(f.Locals[3]);f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.String(" loses ")));f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",140);}
case 140:{f.StackOp("pop");f.Pc=141;continue;}
case 141:{f.Push(f.Locals[3]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[2]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",146);}
case 146:{f.StackOp("pop");f.Pc=147;continue;}
case 147:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=149;continue;}
case 149:{f.Push(f.Locals[1]);f.Pc=150;continue;}
case 150:{f.Push(JValue.R(rt.String("Duration")));f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",155);}
case 155:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",158);}
case 158:{f.Pc=f.Pop().Int!=0?168:161;continue;}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{f.Push(JValue.R(rt.String(" until end of turn")));f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",167);}
case 167:{f.StackOp("pop");f.Pc=168;continue;}
case 168:{f.Push(f.Locals[3]);f.Pc=169;continue;}
case 169:{f.Push(JValue.R(rt.String(".")));f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",174);}
case 174:{f.StackOp("pop");f.Pc=175;continue;}
case 175:{f.Push(f.Locals[3]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",179);}
case 179:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3310(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("Keywords")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?34:13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("Keywords")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",20);}
case 20:{f.Push(JValue.R(rt.String(" & ")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",25);}
case 25:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",28);}
case 28:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",38);}
case 38:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",41);}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",46);}
case 46:{f.Locals[4]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/ability/effects/DebuffEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",52);}
case 52:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",55);}
case 55:{f.Locals[6]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",64);}
case 64:{f.Pc=f.Pop().Int==0?692:67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",74);}
case 74:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=77;continue;}
case 77:{f.Locals[7]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[7]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int!=0?90:87;continue;}
case 87:{f.Pc=57;continue;}
case 90:{f.Push(f.Locals[7]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int==0?101:98;continue;}
case 98:{f.Pc=57;continue;}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[7]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(null));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",108);}
case 108:{f.Locals[8]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[8]);f.Pc=112;continue;}
case 112:{f.Pc=f.Pop().Reference==null?57:115;continue;}
case 115:{f.Push(f.Locals[7]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[8]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",122);}
case 122:{f.Pc=f.Pop().Int!=0?128:125;continue;}
case 125:{f.Pc=57;continue;}
case 128:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",131);}
case 131:{f.Locals[9]=f.Pop();f.Pc=133;continue;}
case 133:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",136);}
case 136:{f.Locals[10]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("AllSuffixKeywords")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Int==0?216:147;continue;}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{f.Push(JValue.R(rt.String("AllSuffixKeywords")));f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",153);}
case 153:{f.Push(JValue.R(rt.String("walk")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",158);}
case 158:{f.Pc=f.Pop().Int==0?216:161;continue;}
case 161:{f.Push(f.Locals[8]);f.Pc=163;continue;}
case 163:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","LANDWALK","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","LANDWALK","Lforge/game/keyword/Keyword;"));f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/game/card/Card","getKeywords","(Lforge/game/keyword/Keyword;)Ljava/util/Collection;","invokevirtual",169);}
case 169:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",174);}
case 174:{f.Locals[11]=f.Pop();f.Pc=176;continue;}
case 176:{f.Push(f.Locals[11]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",183);}
case 183:{f.Pc=f.Pop().Int==0?216:186;continue;}
case 186:{f.Push(f.Locals[11]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",193);}
case 193:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=196;continue;}
case 196:{f.Locals[12]=f.Pop();f.Pc=198;continue;}
case 198:{f.Push(f.Locals[10]);f.Pc=200;continue;}
case 200:{f.Push(f.Locals[12]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",207);}
case 207:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",212);}
case 212:{f.StackOp("pop");f.Pc=213;continue;}
case 213:{f.Pc=176;continue;}
case 216:{f.Push(JValue.I(0));f.Pc=217;continue;}
case 217:{f.Locals[11]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[2]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",225);}
case 225:{f.Locals[12]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[12]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",234);}
case 234:{f.Pc=f.Pop().Int==0?414:237;continue;}
case 237:{f.Push(f.Locals[12]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",244);}
case 244:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=247;continue;}
case 247:{f.Locals[13]=f.Pop();f.Pc=249;continue;}
case 249:{f.Push(f.Locals[13]);f.Pc=251;continue;}
case 251:{f.Push(JValue.R(rt.String("Protection from ")));f.Pc=253;continue;}
case 253:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",256);}
case 256:{f.Pc=f.Pop().Int!=0?262:259;continue;}
case 259:{f.Pc=227;continue;}
case 262:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=265;continue;}
case 265:{f.Locals[14]=f.Pop();f.Pc=267;continue;}
case 267:{f.Push(f.Locals[14]);f.Pc=269;continue;}
case 269:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=270;continue;}
case 270:{f.Locals[15]=f.Pop();f.Pc=272;continue;}
case 272:{f.Push(JValue.I(0));f.Pc=273;continue;}
case 273:{f.Locals[16]=f.Pop();f.Pc=275;continue;}
case 275:{f.Push(f.Locals[16]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[15]);f.Pc=279;continue;}
case 279:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?408:282;continue;}
case 282:{f.Push(f.Locals[14]);f.Pc=284;continue;}
case 284:{f.Push(f.Locals[16]);f.Pc=286;continue;}
case 286:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=287;continue;}
case 287:{f.Locals[17]=f.Pop();f.Pc=289;continue;}
case 289:{f.Push(f.Locals[17]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/card/MagicColor","toLongString","(B)Ljava/lang/String;","invokestatic",294);}
case 294:{f.Locals[18]=f.Pop();f.Pc=296;continue;}
case 296:{f.Push(f.Locals[13]);f.Pc=298;continue;}
case 298:{f.Push(f.Locals[18]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",303);}
case 303:{f.Pc=f.Pop().Int!=0?309:306;continue;}
case 306:{f.Pc=402;continue;}
case 309:{f.Push(f.Locals[18]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",314);}
case 314:{f.Push(f.Locals[18]);f.Pc=316;continue;}
case 316:{return rt.DynamicCall(f,"forge/game/ability/effects/DebuffEffect:3310:316:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",321);}
case 321:{f.Locals[19]=f.Pop();f.Pc=323;continue;}
case 323:{f.Push(f.Locals[8]);f.Pc=325;continue;}
case 325:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","PROTECTION","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","PROTECTION","Lforge/game/keyword/Keyword;"));f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/game/card/Card","getKeywords","(Lforge/game/keyword/Keyword;)Ljava/util/Collection;","invokevirtual",331);}
case 331:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",336);}
case 336:{f.Locals[20]=f.Pop();f.Pc=338;continue;}
case 338:{f.Push(f.Locals[20]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",345);}
case 345:{f.Pc=f.Pop().Int==0?402:348;continue;}
case 348:{f.Push(f.Locals[20]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",355);}
case 355:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=358;continue;}
case 358:{f.Locals[21]=f.Pop();f.Pc=360;continue;}
case 360:{f.Push(f.Locals[21]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",367);}
case 367:{f.Locals[22]=f.Pop();f.Pc=369;continue;}
case 369:{f.Push(f.Locals[22]);f.Pc=371;continue;}
case 371:{f.Push(JValue.R(rt.String("Protection:")));f.Pc=373;continue;}
case 373:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",376);}
case 376:{f.Pc=f.Pop().Int==0?399:379;continue;}
case 379:{f.Push(f.Locals[22]);f.Pc=381;continue;}
case 381:{f.Push(f.Locals[19]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",386);}
case 386:{f.Pc=f.Pop().Int==0?399:389;continue;}
case 389:{f.Push(f.Locals[10]);f.Pc=391;continue;}
case 391:{f.Push(f.Locals[22]);f.Pc=393;continue;}
case 393:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",398);}
case 398:{f.StackOp("pop");f.Pc=399;continue;}
case 399:{f.Pc=338;continue;}
case 402:{f.Locals[16]=JValue.I(unchecked(f.Locals[16].Int+(1)));f.Pc=405;continue;}
case 405:{f.Pc=275;continue;}
case 408:{f.Push(JValue.I(1));f.Pc=409;continue;}
case 409:{f.Locals[11]=f.Pop();f.Pc=411;continue;}
case 411:{f.Pc=227;continue;}
case 414:{f.Push(f.Locals[11]);f.Pc=416;continue;}
case 416:{f.Pc=f.Pop().Int==0?633:419;continue;}
case 419:{f.Push(JValue.R(rt.String("Protection from each color")));f.Pc=421;continue;}
case 421:{f.Locals[12]=f.Pop();f.Pc=423;continue;}
case 423:{f.Push(f.Locals[8]);f.Pc=425;continue;}
case 425:{f.Push(f.Locals[12]);f.Pc=427;continue;}
case 427:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",430);}
case 430:{f.Pc=f.Pop().Int==0?518:433;continue;}
case 433:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",436);}
case 436:{f.Locals[13]=f.Pop();f.Pc=438;continue;}
case 438:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=441;continue;}
case 441:{f.Locals[14]=f.Pop();f.Pc=443;continue;}
case 443:{f.Push(f.Locals[14]);f.Pc=445;continue;}
case 445:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=446;continue;}
case 446:{f.Locals[15]=f.Pop();f.Pc=448;continue;}
case 448:{f.Push(JValue.I(0));f.Pc=449;continue;}
case 449:{f.Locals[16]=f.Pop();f.Pc=451;continue;}
case 451:{f.Push(f.Locals[16]);f.Pc=453;continue;}
case 453:{f.Push(f.Locals[15]);f.Pc=455;continue;}
case 455:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?489:458;continue;}
case 458:{f.Push(f.Locals[14]);f.Pc=460;continue;}
case 460:{f.Push(f.Locals[16]);f.Pc=462;continue;}
case 462:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=463;continue;}
case 463:{f.Locals[17]=f.Pop();f.Pc=465;continue;}
case 465:{f.Push(f.Locals[13]);f.Pc=467;continue;}
case 467:{f.Push(f.Locals[17]);f.Pc=469;continue;}
case 469:{return rt.Call(f,"forge/card/MagicColor","toLongString","(B)Ljava/lang/String;","invokestatic",472);}
case 472:{return rt.DynamicCall(f,"forge/game/ability/effects/DebuffEffect:3310:472:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",477);}
case 477:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",482);}
case 482:{f.StackOp("pop");f.Pc=483;continue;}
case 483:{f.Locals[16]=JValue.I(unchecked(f.Locals[16].Int+(1)));f.Pc=486;continue;}
case 486:{f.Pc=451;continue;}
case 489:{f.Push(f.Locals[13]);f.Pc=491;continue;}
case 491:{f.Push(f.Locals[2]);f.Pc=492;continue;}
case 492:{return rt.Call(f,"java/util/List","removeAll","(Ljava/util/Collection;)Z","invokeinterface",497);}
case 497:{f.StackOp("pop");f.Pc=498;continue;}
case 498:{f.Push(f.Locals[9]);f.Pc=500;continue;}
case 500:{f.Push(f.Locals[13]);f.Pc=502;continue;}
case 502:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",507);}
case 507:{f.StackOp("pop");f.Pc=508;continue;}
case 508:{f.Push(f.Locals[10]);f.Pc=510;continue;}
case 510:{f.Push(f.Locals[12]);f.Pc=512;continue;}
case 512:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",517);}
case 517:{f.StackOp("pop");f.Pc=518;continue;}
case 518:{f.Push(JValue.R(rt.String("Protection:Card.nonColorless:each color:Aura")));f.Pc=520;continue;}
case 520:{f.Locals[12]=f.Pop();f.Pc=522;continue;}
case 522:{f.Push(f.Locals[8]);f.Pc=524;continue;}
case 524:{f.Push(f.Locals[12]);f.Pc=526;continue;}
case 526:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",529);}
case 529:{f.Pc=f.Pop().Int==0?633:532;continue;}
case 532:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",535);}
case 535:{f.Locals[13]=f.Pop();f.Pc=537;continue;}
case 537:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=540;continue;}
case 540:{f.Locals[14]=f.Pop();f.Pc=542;continue;}
case 542:{f.Push(f.Locals[14]);f.Pc=544;continue;}
case 544:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=545;continue;}
case 545:{f.Locals[15]=f.Pop();f.Pc=547;continue;}
case 547:{f.Push(JValue.I(0));f.Pc=548;continue;}
case 548:{f.Locals[16]=f.Pop();f.Pc=550;continue;}
case 550:{f.Push(f.Locals[16]);f.Pc=552;continue;}
case 552:{f.Push(f.Locals[15]);f.Pc=554;continue;}
case 554:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?613:557;continue;}
case 557:{f.Push(f.Locals[14]);f.Pc=559;continue;}
case 559:{f.Push(f.Locals[16]);f.Pc=561;continue;}
case 561:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=562;continue;}
case 562:{f.Locals[17]=f.Pop();f.Pc=564;continue;}
case 564:{f.Push(f.Locals[17]);f.Pc=566;continue;}
case 566:{return rt.Call(f,"forge/card/MagicColor","toLongString","(B)Ljava/lang/String;","invokestatic",569);}
case 569:{f.Locals[18]=f.Pop();f.Pc=571;continue;}
case 571:{f.Push(f.Locals[2]);f.Pc=572;continue;}
case 572:{f.Push(f.Locals[18]);f.Pc=574;continue;}
case 574:{return rt.DynamicCall(f,"forge/game/ability/effects/DebuffEffect:3310:574:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",579);}
case 579:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",584);}
case 584:{f.Pc=f.Pop().Int!=0?607:587;continue;}
case 587:{f.Push(f.Locals[13]);f.Pc=589;continue;}
case 589:{f.Push(f.Locals[18]);f.Pc=591;continue;}
case 591:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",594);}
case 594:{f.Push(f.Locals[18]);f.Pc=596;continue;}
case 596:{return rt.DynamicCall(f,"forge/game/ability/effects/DebuffEffect:3310:596:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",601);}
case 601:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",606);}
case 606:{f.StackOp("pop");f.Pc=607;continue;}
case 607:{f.Locals[16]=JValue.I(unchecked(f.Locals[16].Int+(1)));f.Pc=610;continue;}
case 610:{f.Pc=550;continue;}
case 613:{f.Push(f.Locals[9]);f.Pc=615;continue;}
case 615:{f.Push(f.Locals[13]);f.Pc=617;continue;}
case 617:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",622);}
case 622:{f.StackOp("pop");f.Pc=623;continue;}
case 623:{f.Push(f.Locals[10]);f.Pc=625;continue;}
case 625:{f.Push(f.Locals[12]);f.Pc=627;continue;}
case 627:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",632);}
case 632:{f.StackOp("pop");f.Pc=633;continue;}
case 633:{f.Push(f.Locals[10]);f.Pc=635;continue;}
case 635:{f.Push(f.Locals[2]);f.Pc=636;continue;}
case 636:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",641);}
case 641:{f.StackOp("pop");f.Pc=642;continue;}
case 642:{f.Push(f.Locals[8]);f.Pc=644;continue;}
case 644:{f.Push(f.Locals[9]);f.Pc=646;continue;}
case 646:{f.Push(f.Locals[10]);f.Pc=648;continue;}
case 648:{f.Push(JValue.I(0));f.Pc=649;continue;}
case 649:{f.Push(f.Locals[4]);f.Pc=651;continue;}
case 651:{f.Push(JValue.R(null));f.Pc=652;continue;}
case 652:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywords","(Ljava/util/List;Ljava/util/List;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",655);}
case 655:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=657;continue;}
case 657:{f.Push(f.Locals[1]);f.Pc=658;continue;}
case 658:{f.Push(JValue.R(rt.String("Duration")));f.Pc=660;continue;}
case 660:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",663);}
case 663:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",666);}
case 666:{f.Pc=f.Pop().Int!=0?689:669;continue;}
case 669:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/DebuffEffect$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/DebuffEffect$1")));f.Pc=672;continue;}
case 672:{f.StackOp("dup");f.Pc=673;continue;}
case 673:{f.Push(f.Locals[0]);f.Pc=674;continue;}
case 674:{f.Push(f.Locals[8]);f.Pc=676;continue;}
case 676:{f.Push(f.Locals[4]);f.Pc=678;continue;}
case 678:{return rt.Call(f,"forge/game/ability/effects/DebuffEffect$1","<init>","(Lforge/game/ability/effects/DebuffEffect;Lforge/game/card/Card;J)V","invokespecial",681);}
case 681:{f.Locals[12]=f.Pop();f.Pc=683;continue;}
case 683:{f.Push(f.Locals[1]);f.Pc=684;continue;}
case 684:{f.Push(f.Locals[12]);f.Pc=686;continue;}
case 686:{return rt.Call(f,"forge/game/ability/effects/DebuffEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;)V","invokestatic",689);}
case 689:{f.Pc=57;continue;}
case 692:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
