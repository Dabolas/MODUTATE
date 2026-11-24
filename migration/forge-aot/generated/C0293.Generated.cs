// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C293{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DraftEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3357,"forge/game/ability/effects/DraftEffect","<init>","()V",1,1,1,new JHandler[]{},M3357));
c.Add(new JMethod(3358,"forge/game/ability/effects/DraftEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,5,3,new JHandler[]{},M3358));
c.Add(new JMethod(3359,"forge/game/ability/effects/DraftEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,15,9,new JHandler[]{},M3359));
}

internal static JStep M3357(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3358(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("Defined")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",16);}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",20);}
case 20:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=23;continue;}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",39);}
case 39:{f.Push(JValue.R(rt.String(" drafts a card from ")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",44);}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",48);}
case 48:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",51);}
case 51:{f.Push(JValue.R(rt.String("'s spellbook.")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",62);}
case 62:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3359(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("Defined")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",16);}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",20);}
case 20:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=23;continue;}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",28);}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("Spellbook")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",36);}
case 36:{f.Push(JValue.R(rt.String(",")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",41);}
case 41:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",44);}
case 44:{f.Locals[5]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("DraftNum")));f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("1")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",55);}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",59);}
case 59:{f.Locals[6]=f.Pop();f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",64);}
case 64:{f.Locals[7]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[7]);f.Pc=68;continue;}
case 68:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateBattlefield","()Lforge/game/card/CardCollection;","invokevirtual",75);}
case 75:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",80);}
case 80:{f.StackOp("pop");f.Pc=81;continue;}
case 81:{f.Push(f.Locals[7]);f.Pc=83;continue;}
case 83:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateGraveyard","()Lforge/game/card/CardCollection;","invokevirtual",90);}
case 90:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",95);}
case 95:{f.StackOp("pop");f.Pc=96;continue;}
case 96:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=99;continue;}
case 99:{f.StackOp("dup");f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",103);}
case 103:{f.Locals[8]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(JValue.I(0));f.Pc=106;continue;}
case 106:{f.Locals[9]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[9]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[6]);f.Pc=112;continue;}
case 112:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?316:115;continue;}
case 115:{f.Push(f.Locals[5]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",120);}
case 120:{return rt.Call(f,"java/util/Collections","shuffle","(Ljava/util/List;Ljava/util/Random;)V","invokestatic",123);}
case 123:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=126;continue;}
case 126:{f.StackOp("dup");f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",130);}
case 130:{f.Locals[10]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[5]);f.Pc=134;continue;}
case 134:{f.Push(JValue.I(0));f.Pc=135;continue;}
case 135:{f.Push(JValue.I(3));f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/List","subList","(II)Ljava/util/List;","invokeinterface",141);}
case 141:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",146);}
case 146:{f.Locals[11]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[11]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",155);}
case 155:{f.Pc=f.Pop().Int==0?241:158;continue;}
case 158:{f.Push(f.Locals[11]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",165);}
case 165:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=168;continue;}
case 168:{f.Locals[12]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[12]);f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String(";")));f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String(",")));f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",179);}
case 179:{f.Locals[12]=f.Pop();f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",184);}
case 184:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",187);}
case 187:{f.Push(f.Locals[12]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/card/CardDb","getUniqueByName","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",192);}
case 192:{f.Locals[13]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[13]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/item/PaperCard","isUnRebalanced","()Z","invokevirtual",199);}
case 199:{f.Pc=f.Pop().Int==0?220:202;continue;}
case 202:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",205);}
case 205:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",208);}
case 208:{f.Push(f.Locals[12]);f.Pc=210;continue;}
case 210:{return rt.DynamicCall(f,"forge/game/ability/effects/DraftEffect:3359:210:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",215);}
case 215:{return rt.Call(f,"forge/card/CardDb","getUniqueByName","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",218);}
case 218:{f.Locals[13]=f.Pop();f.Pc=220;continue;}
case 220:{f.Push(f.Locals[13]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[3]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",226);}
case 226:{f.Locals[14]=f.Pop();f.Pc=228;continue;}
case 228:{f.Push(f.Locals[10]);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[14]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",237);}
case 237:{f.StackOp("pop");f.Pc=238;continue;}
case 238:{f.Pc=148;continue;}
case 241:{f.Push(f.Locals[3]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",245);}
case 245:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=248;continue;}
case 248:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=251;continue;}
case 251:{f.StackOp("dup");f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",255);}
case 255:{f.Push(f.Locals[1]);f.Pc=256;continue;}
case 256:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=259;continue;}
case 259:{f.StackOp("dup");f.Pc=260;continue;}
case 260:{f.Push(f.Locals[10]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",265);}
case 265:{f.Push(JValue.R(null));f.Pc=266;continue;}
case 266:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",269);}
case 269:{f.Push(JValue.R(rt.String("lblChooseCardDraft")));f.Pc=271;continue;}
case 271:{f.Push(JValue.I(0));f.Pc=272;continue;}
case 272:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",278);}
case 278:{f.Push(JValue.I(0));f.Pc=279;continue;}
case 279:{f.Push(f.Locals[3]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleCardForZoneChange","(Lforge/game/zone/ZoneType;Ljava/util/List;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;Lforge/game/player/DelayedReveal;Ljava/lang/String;ZLforge/game/player/Player;)Lforge/game/card/Card;","invokevirtual",283);}
case 283:{f.Locals[11]=f.Pop();f.Pc=285;continue;}
case 285:{f.Push(f.Locals[4]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",290);}
case 290:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=293;continue;}
case 293:{f.Push(f.Locals[11]);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[1]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[7]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",301);}
case 301:{f.StackOp("pop");f.Pc=302;continue;}
case 302:{f.Push(f.Locals[8]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[11]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",309);}
case 309:{f.StackOp("pop");f.Pc=310;continue;}
case 310:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=313;continue;}
case 313:{f.Pc=108;continue;}
case 316:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=319;continue;}
case 319:{f.StackOp("dup");f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",323);}
case 323:{f.Locals[9]=f.Pop();f.Pc=325;continue;}
case 325:{f.Push(f.Locals[8]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",330);}
case 330:{f.Locals[10]=f.Pop();f.Pc=332;continue;}
case 332:{f.Push(f.Locals[10]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",339);}
case 339:{f.Pc=f.Pop().Int==0?412:342;continue;}
case 342:{f.Push(f.Locals[10]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",349);}
case 349:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=352;continue;}
case 352:{f.Locals[11]=f.Pop();f.Pc=354;continue;}
case 354:{f.Push(f.Locals[4]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",359);}
case 359:{f.Push(f.Locals[11]);f.Pc=361;continue;}
case 361:{f.Push(f.Locals[1]);f.Pc=362;continue;}
case 362:{f.Push(f.Locals[7]);f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/GameAction","moveToHand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",367);}
case 367:{f.Locals[12]=f.Pop();f.Pc=369;continue;}
case 369:{f.Push(f.Locals[11]);f.Pc=371;continue;}
case 371:{f.Pc=f.Pop().Reference==null?393:374;continue;}
case 374:{f.Push(f.Locals[9]);f.Pc=376;continue;}
case 376:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=379;continue;}
case 379:{f.Push(f.Locals[12]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",384);}
case 384:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",387);}
case 387:{f.Push(f.Locals[12]);f.Pc=389;continue;}
case 389:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",392);}
case 392:{f.StackOp("pop");f.Pc=393;continue;}
case 393:{f.Push(f.Locals[1]);f.Pc=394;continue;}
case 394:{f.Push(JValue.R(rt.String("RememberDrafted")));f.Pc=397;continue;}
case 397:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",400);}
case 400:{f.Pc=f.Pop().Int==0?409:403;continue;}
case 403:{f.Push(f.Locals[2]);f.Pc=404;continue;}
case 404:{f.Push(f.Locals[12]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",409);}
case 409:{f.Pc=332;continue;}
case 412:{f.Push(f.Locals[9]);f.Pc=414;continue;}
case 414:{f.Push(f.Locals[4]);f.Pc=416;continue;}
case 416:{f.Push(f.Locals[1]);f.Pc=417;continue;}
case 417:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",420);}
case 420:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
