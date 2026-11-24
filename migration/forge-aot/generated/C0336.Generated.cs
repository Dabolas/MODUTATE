// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C336{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/MillEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3507,"forge/game/ability/effects/MillEffect","<init>","()V",1,1,1,new JHandler[]{},M3507));
c.Add(new JMethod(3508,"forge/game/ability/effects/MillEffect","movesCardToOrFromLibrary","(Lforge/game/spellability/SpellAbility;)Z",1,2,1,new JHandler[]{},M3508));
c.Add(new JMethod(3509,"forge/game/ability/effects/MillEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,10,new JHandler[]{},M3509));
c.Add(new JMethod(3510,"forge/game/ability/effects/MillEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,10,5,new JHandler[]{},M3510));
}

internal static JStep M3507(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3508(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3509(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?33:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",30);}
case 30:{f.Pc=34;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{f.Pc=f.Pop().Int>0?42:41;continue;}
case 41:{return JStep.ReturnVoid;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("ForgetOtherRemembered")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?55:51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",55);}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("Destination")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",61);}
case 61:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",64);}
case 64:{f.Locals[5]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{f.Pc=f.Pop().Reference!=null?76:71;continue;}
case 71:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=74;continue;}
case 74:{f.Locals[5]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/ability/effects/MillEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",80);}
case 80:{f.Locals[6]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("Optional")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int==0?247:91;continue;}
case 91:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=94;continue;}
case 94:{f.StackOp("dup");f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",98);}
case 98:{f.Locals[7]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",105);}
case 105:{f.Locals[8]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[8]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",114);}
case 114:{f.Pc=f.Pop().Int==0?239:117;continue;}
case 117:{f.Push(f.Locals[8]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",124);}
case 124:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=127;continue;}
case 127:{f.Locals[9]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[5]);f.Pc=131;continue;}
case 131:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",137);}
case 137:{f.Pc=f.Pop().Int==0?145:140;continue;}
case 140:{f.Push(JValue.R(rt.String("")));f.Pc=142;continue;}
case 142:{f.Pc=155;continue;}
case 145:{f.Push(f.Locals[5]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/zone/ZoneType","getTranslatedName","()Ljava/lang/String;","invokevirtual",150);}
case 150:{return rt.DynamicCall(f,"forge/game/ability/effects/MillEffect:3509:150:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",155);}
case 155:{f.Locals[10]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(JValue.I(1));f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=161;continue;}
case 161:{f.StackOp("dup");f.Pc=162;continue;}
case 162:{f.Push(JValue.I(0));f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",166);}
case 166:{f.Push(JValue.R(rt.String("lblDoYouWantToMill")));f.Pc=168;continue;}
case 168:{f.Push(JValue.I(2));f.Pc=169;continue;}
case 169:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=172;continue;}
case 172:{f.StackOp("dup");f.Pc=173;continue;}
case 173:{f.Push(JValue.I(0));f.Pc=174;continue;}
case 174:{f.Push(f.Locals[4]);f.Pc=176;continue;}
case 176:{f.Push(JValue.R(rt.String("card")));f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/util/Lang","nounWithNumeral","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",181);}
case 181:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=182;continue;}
case 182:{f.StackOp("dup");f.Pc=183;continue;}
case 183:{f.Push(JValue.I(1));f.Pc=184;continue;}
case 184:{f.Push(f.Locals[10]);f.Pc=186;continue;}
case 186:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",190);}
case 190:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",194);}
case 194:{f.Locals[11]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[4]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[9]);f.Pc=200;continue;}
case 200:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",206);}
case 206:{return rt.Call(f,"forge/game/zone/PlayerZone","size","()I","invokevirtual",209);}
case 209:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?228:212;continue;}
case 212:{f.Push(f.Locals[9]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",217);}
case 217:{f.Push(f.Locals[1]);f.Pc=218;continue;}
case 218:{f.Push(JValue.R(null));f.Pc=219;continue;}
case 219:{f.Push(f.Locals[11]);f.Pc=221;continue;}
case 221:{f.Push(JValue.R(null));f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",225);}
case 225:{f.Pc=f.Pop().Int!=0?236:228;continue;}
case 228:{f.Push(f.Locals[7]);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[9]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/player/PlayerCollection","add","(Ljava/lang/Object;)Z","invokevirtual",235);}
case 235:{f.StackOp("pop");f.Pc=236;continue;}
case 236:{f.Pc=107;continue;}
case 239:{f.Push(f.Locals[6]);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[7]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/player/PlayerCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",246);}
case 246:{f.StackOp("pop");f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",250);}
case 250:{f.Locals[7]=f.Pop();f.Pc=252;continue;}
case 252:{f.Push(f.Locals[7]);f.Pc=254;continue;}
case 254:{f.Push(f.Locals[1]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",258);}
case 258:{f.Locals[8]=f.Pop();f.Pc=260;continue;}
case 260:{f.Push(f.Locals[3]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",264);}
case 264:{f.Push(f.Locals[6]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[4]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[5]);f.Pc=270;continue;}
case 270:{f.Push(f.Locals[1]);f.Pc=271;continue;}
case 271:{f.Push(f.Locals[7]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/GameAction","mill","(Lforge/game/player/PlayerCollection;ILforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/CardCollection;","invokevirtual",276);}
case 276:{f.Locals[9]=f.Pop();f.Pc=278;continue;}
case 278:{f.Push(f.Locals[1]);f.Pc=279;continue;}
case 279:{f.Push(JValue.R(rt.String("RememberMilled")));f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",284);}
case 284:{f.Pc=f.Pop().Int==0?296:287;continue;}
case 287:{f.Push(f.Locals[1]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",291);}
case 291:{f.Push(f.Locals[9]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",296);}
case 296:{f.Push(f.Locals[1]);f.Pc=297;continue;}
case 297:{f.Push(JValue.R(rt.String("Imprint")));f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",302);}
case 302:{f.Pc=f.Pop().Int==0?314:305;continue;}
case 305:{f.Push(f.Locals[1]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",309);}
case 309:{f.Push(f.Locals[9]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/card/Card","addImprintedCards","(Ljava/lang/Iterable;)V","invokevirtual",314);}
case 314:{f.Push(f.Locals[8]);f.Pc=316;continue;}
case 316:{f.Push(f.Locals[3]);f.Pc=317;continue;}
case 317:{f.Push(f.Locals[1]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",321);}
case 321:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3510(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?34:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",21);}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",31);}
case 31:{f.Pc=35;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("Optional")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",42);}
case 42:{f.Locals[4]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("Defined")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?71:53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("Defined")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",59);}
case 59:{f.Push(JValue.R(rt.String("Player")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int==0?71:67;continue;}
case 67:{f.Push(JValue.I(1));f.Pc=68;continue;}
case 68:{f.Pc=72;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{f.Locals[5]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("Each player")));f.Pc=76;continue;}
case 76:{f.Locals[6]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/ability/effects/MillEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",82);}
case 82:{f.Locals[7]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("IfDesc")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?178:93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("IfDesc")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",99);}
case 99:{f.Locals[8]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[8]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("True")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int==0?157:111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",115);}
case 115:{f.Locals[9]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[9]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String(",")));f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",124);}
case 124:{f.Pc=f.Pop().Int==0?147:127;continue;}
case 127:{f.Push(f.Locals[2]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[9]);f.Pc=130;continue;}
case 130:{f.Push(JValue.I(0));f.Pc=131;continue;}
case 131:{f.Push(f.Locals[9]);f.Pc=133;continue;}
case 133:{f.Push(JValue.R(rt.String(",")));f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",138);}
case 138:{f.Push(JValue.I(1));f.Pc=139;continue;}
case 139:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;","invokevirtual",143);}
case 143:{f.StackOp("pop");f.Pc=144;continue;}
case 144:{f.Pc=154;continue;}
case 147:{f.Push(f.Locals[2]);f.Pc=148;continue;}
case 148:{f.Push(JValue.R(rt.String("[MillEffect IfDesc parsing error]")));f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",153);}
case 153:{f.StackOp("pop");f.Pc=154;continue;}
case 154:{f.Pc=164;continue;}
case 157:{f.Push(f.Locals[2]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[8]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",163);}
case 163:{f.StackOp("pop");f.Pc=164;continue;}
case 164:{f.Push(f.Locals[2]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String(" ")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",170);}
case 170:{f.StackOp("pop");f.Pc=171;continue;}
case 171:{f.Push(f.Locals[6]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",176);}
case 176:{f.Locals[6]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[2]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[5]);f.Pc=181;continue;}
case 181:{f.Pc=f.Pop().Int==0?189:184;continue;}
case 184:{f.Push(f.Locals[6]);f.Pc=186;continue;}
case 186:{f.Pc=194;continue;}
case 189:{f.Push(f.Locals[7]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",194);}
case 194:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",197);}
case 197:{f.StackOp("pop");f.Pc=198;continue;}
case 198:{f.Push(f.Locals[2]);f.Pc=199;continue;}
case 199:{f.Push(JValue.R(rt.String(" ")));f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",204);}
case 204:{f.StackOp("pop");f.Pc=205;continue;}
case 205:{f.Push(f.Locals[1]);f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.String("Destination")));f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",211);}
case 211:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",214);}
case 214:{f.Locals[8]=f.Pop();f.Pc=216;continue;}
case 216:{f.Push(f.Locals[2]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[4]);f.Pc=219;continue;}
case 219:{f.Pc=f.Pop().Int==0?227:222;continue;}
case 222:{f.Push(JValue.R(rt.String("may ")));f.Pc=224;continue;}
case 224:{f.Pc=229;continue;}
case 227:{f.Push(JValue.R(rt.String("")));f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",232);}
case 232:{f.StackOp("pop");f.Pc=233;continue;}
case 233:{f.Push(f.Locals[8]);f.Pc=235;continue;}
case 235:{f.Pc=f.Pop().Reference==null?249:238;continue;}
case 238:{f.Push(f.Locals[8]);f.Pc=240;continue;}
case 240:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",246);}
case 246:{f.Pc=f.Pop().Int==0?259:249;continue;}
case 249:{f.Push(f.Locals[2]);f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.String("mill")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",255);}
case 255:{f.StackOp("pop");f.Pc=256;continue;}
case 256:{f.Pc=277;continue;}
case 259:{f.Push(f.Locals[8]);f.Pc=261;continue;}
case 261:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"));f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",267);}
case 267:{f.Pc=f.Pop().Int==0?277:270;continue;}
case 270:{f.Push(f.Locals[2]);f.Pc=271;continue;}
case 271:{f.Push(JValue.R(rt.String("ante")));f.Pc=273;continue;}
case 273:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",276);}
case 276:{f.StackOp("pop");f.Pc=277;continue;}
case 277:{f.Push(f.Locals[2]);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[4]);f.Pc=280;continue;}
case 280:{f.Pc=f.Pop().Int!=0?292:283;continue;}
case 283:{f.Push(f.Locals[7]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",288);}
case 288:{f.Push(JValue.I(1));f.Pc=289;continue;}
case 289:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?302:292;continue;}
case 292:{f.Push(f.Locals[5]);f.Pc=294;continue;}
case 294:{f.Pc=f.Pop().Int!=0?302:297;continue;}
case 297:{f.Push(JValue.R(rt.String(" ")));f.Pc=299;continue;}
case 299:{f.Pc=304;continue;}
case 302:{f.Push(JValue.R(rt.String("s ")));f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",307);}
case 307:{f.StackOp("pop");f.Pc=308;continue;}
case 308:{f.Push(f.Locals[2]);f.Pc=309;continue;}
case 309:{f.Push(f.Locals[3]);f.Pc=310;continue;}
case 310:{f.Push(JValue.R(rt.String("card")));f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",315);}
case 315:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",318);}
case 318:{f.Push(JValue.R(rt.String(".")));f.Pc=320;continue;}
case 320:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",323);}
case 323:{f.StackOp("pop");f.Pc=324;continue;}
case 324:{f.Push(f.Locals[2]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",328);}
case 328:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
