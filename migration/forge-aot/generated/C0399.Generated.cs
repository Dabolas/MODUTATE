// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C399{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/SetStateEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3720,"forge/game/ability/effects/SetStateEffect","<init>","()V",1,1,1,new JHandler[]{},M3720));
c.Add(new JMethod(3721,"forge/game/ability/effects/SetStateEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,5,3,new JHandler[]{},M3721));
c.Add(new JMethod(3722,"forge/game/ability/effects/SetStateEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,17,8,new JHandler[]{},M3722));
}

internal static JStep M3720(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3721(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("Specialize")));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Mode")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Flip")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?45:35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("Flip ")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Pc=60;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Pc=f.Pop().Int==0?53:50;continue;}
case 50:{f.Pc=60;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("Transform ")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/ability/effects/SetStateEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",65);}
case 65:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",68);}
case 68:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Push(f.Locals[4]);f.Pc=74;continue;}
case 74:{f.Pc=f.Pop().Int==0?105:77;continue;}
case 77:{f.Push(f.Locals[3]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String(" perpetually specializes into ")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","()Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int==0?99:92;continue;}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/Card","getChosenColor","()Ljava/lang/String;","invokevirtual",96);}
case 96:{f.Pc=101;continue;}
case 99:{f.Push(JValue.R(rt.String("the chosen color")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",104);}
case 104:{f.StackOp("pop");f.Pc=105;continue;}
case 105:{f.Push(f.Locals[3]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String(".")));f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",111);}
case 111:{f.StackOp("pop");f.Pc=112;continue;}
case 112:{f.Push(f.Locals[3]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",116);}
case 116:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3722(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Mode")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",16);}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",23);}
case 23:{f.Locals[5]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("RememberChanged")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",31);}
case 31:{f.Locals[6]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("Optional")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",39);}
case 39:{f.Locals[7]=f.Pop();f.Pc=41;continue;}
case 41:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",48);}
case 48:{f.Locals[8]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("Choices")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?202:59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",67);}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("Choices")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[4]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",80);}
case 80:{f.Locals[10]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("Amount")));f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("1")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",92);}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",96);}
case 96:{f.Locals[11]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("MinAmount")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int==0?119:107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("MinAmount")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",113);}
case 113:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",116);}
case 116:{f.Pc=121;continue;}
case 119:{f.Push(f.Locals[11]);f.Pc=121;continue;}
case 121:{f.Locals[12]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[11]);f.Pc=125;continue;}
case 125:{f.Pc=f.Pop().Int>0?129:128;continue;}
case 128:{return JStep.ReturnVoid;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",135);}
case 135:{f.Pc=f.Pop().Int==0?147:138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",144);}
case 144:{f.Pc=164;continue;}
case 147:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",150);}
case 150:{f.Push(JValue.R(rt.String("lblChooseaCard")));f.Pc=152;continue;}
case 152:{f.Push(JValue.I(0));f.Pc=153;continue;}
case 153:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",159);}
case 159:{return rt.DynamicCall(f,"forge/game/ability/effects/SetStateEffect:3722:159:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",164);}
case 164:{f.Locals[13]=f.Pop();f.Pc=166;continue;}
case 166:{f.Push(f.Locals[2]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",170);}
case 170:{f.Push(f.Locals[10]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[1]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[13]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[12]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[11]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[1]);f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("Mandatory")));f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",185);}
case 185:{f.Pc=f.Pop().Int!=0?192:188;continue;}
case 188:{f.Push(JValue.I(1));f.Pc=189;continue;}
case 189:{f.Pc=193;continue;}
case 192:{f.Push(JValue.I(0));f.Pc=193;continue;}
case 193:{f.Push(JValue.R(null));f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",197);}
case 197:{f.Locals[9]=f.Pop();f.Pc=199;continue;}
case 199:{f.Pc=208;continue;}
case 202:{f.Push(f.Locals[1]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/ability/effects/SetStateEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",206);}
case 206:{f.Locals[9]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[9]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",215);}
case 215:{f.Locals[10]=f.Pop();f.Pc=217;continue;}
case 217:{f.Push(f.Locals[10]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",224);}
case 224:{f.Pc=f.Pop().Int==0?1390:227;continue;}
case 227:{f.Push(f.Locals[10]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",234);}
case 234:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=237;continue;}
case 237:{f.Locals[11]=f.Pop();f.Pc=239;continue;}
case 239:{f.Push(f.Locals[5]);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[11]);f.Pc=243;continue;}
case 243:{f.Push(JValue.R(null));f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",247);}
case 247:{f.Locals[12]=f.Pop();f.Pc=249;continue;}
case 249:{f.Push(f.Locals[12]);f.Pc=251;continue;}
case 251:{f.Pc=f.Pop().Reference==null?217:254;continue;}
case 254:{f.Push(f.Locals[11]);f.Pc=256;continue;}
case 256:{f.Push(f.Locals[12]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",261);}
case 261:{f.Pc=f.Pop().Int!=0?267:264;continue;}
case 264:{f.Pc=217;continue;}
case 267:{f.Push(JValue.R(rt.String("TurnFaceUp")));f.Pc=269;continue;}
case 269:{f.Push(f.Locals[3]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",273);}
case 273:{f.Pc=f.Pop().Int!=0?323:276;continue;}
case 276:{f.Push(JValue.R(rt.String("TurnFaceDown")));f.Pc=278;continue;}
case 278:{f.Push(f.Locals[3]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",282);}
case 282:{f.Pc=f.Pop().Int!=0?323:285;continue;}
case 285:{f.Push(JValue.R(rt.String("Unspecialize")));f.Pc=287;continue;}
case 287:{f.Push(f.Locals[3]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",291);}
case 291:{f.Pc=f.Pop().Int!=0?323:294;continue;}
case 294:{f.Push(JValue.R(rt.String("Specialize")));f.Pc=296;continue;}
case 296:{f.Push(f.Locals[3]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",300);}
case 300:{f.Pc=f.Pop().Int!=0?323:303;continue;}
case 303:{f.Push(f.Locals[12]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",308);}
case 308:{f.Pc=f.Pop().Int!=0?323:311;continue;}
case 311:{f.Push(f.Locals[1]);f.Pc=312;continue;}
case 312:{f.Push(JValue.R(rt.String("ETB")));f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",317);}
case 317:{f.Pc=f.Pop().Int!=0?323:320;continue;}
case 320:{f.Pc=217;continue;}
case 323:{f.Push(f.Locals[1]);f.Pc=324;continue;}
case 324:{f.Push(JValue.R(rt.String("RevealFirst")));f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",329);}
case 329:{f.Pc=f.Pop().Int==0?414:332;continue;}
case 332:{f.Push(f.Locals[11]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",337);}
case 337:{f.Locals[13]=f.Pop();f.Pc=339;continue;}
case 339:{f.Push(f.Locals[13]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"forge/game/card/Card","forceTurnFaceUp","()V","invokevirtual",344);}
case 344:{f.Push(f.Locals[5]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",349);}
case 349:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=352;continue;}
case 352:{f.StackOp("dup");f.Pc=353;continue;}
case 353:{f.Push(f.Locals[13]);f.Pc=355;continue;}
case 355:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",358);}
case 358:{f.Push(f.Locals[13]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",363);}
case 363:{f.Push(JValue.I(1));f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",367);}
case 367:{f.Push(JValue.R(rt.String("lblRevealFaceDownCards")));f.Pc=369;continue;}
case 369:{f.Push(JValue.I(0));f.Pc=370;continue;}
case 370:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",376);}
case 376:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;)V","invokevirtual",379);}
case 379:{f.Push(f.Locals[1]);f.Pc=380;continue;}
case 380:{f.Push(JValue.R(rt.String("ValidNewFace")));f.Pc=382;continue;}
case 382:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",385);}
case 385:{f.Pc=f.Pop().Int==0?414:388;continue;}
case 388:{f.Push(f.Locals[13]);f.Pc=390;continue;}
case 390:{f.Push(f.Locals[1]);f.Pc=391;continue;}
case 391:{f.Push(JValue.R(rt.String("ValidNewFace")));f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",396);}
case 396:{f.Push(JValue.R(rt.String(",")));f.Pc=398;continue;}
case 398:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",401);}
case 401:{f.Push(f.Locals[2]);f.Pc=402;continue;}
case 402:{f.Push(f.Locals[4]);f.Pc=404;continue;}
case 404:{f.Push(f.Locals[1]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/game/card/Card","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",408);}
case 408:{f.Pc=f.Pop().Int!=0?414:411;continue;}
case 411:{f.Pc=217;continue;}
case 414:{f.Push(JValue.R(rt.String("TurnFaceUp")));f.Pc=416;continue;}
case 416:{f.Push(f.Locals[3]);f.Pc=417;continue;}
case 417:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",420);}
case 420:{f.Pc=f.Pop().Int==0?643:423;continue;}
case 423:{f.Push(f.Locals[12]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",428);}
case 428:{f.Pc=f.Pop().Int==0?643:431;continue;}
case 431:{f.Push(f.Locals[12]);f.Pc=433;continue;}
case 433:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",436);}
case 436:{f.Pc=f.Pop().Int==0?643:439;continue;}
case 439:{f.Push(f.Locals[12]);f.Pc=441;continue;}
case 441:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",444);}
case 444:{f.Pc=f.Pop().Int==0?578:447;continue;}
case 447:{f.Push(JValue.I(0));f.Pc=448;continue;}
case 448:{f.Locals[13]=f.Pop();f.Pc=450;continue;}
case 450:{f.Push(JValue.R(null));f.Pc=451;continue;}
case 451:{f.Locals[14]=f.Pop();f.Pc=453;continue;}
case 453:{f.Push(f.Locals[12]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/card/Card","getMergedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",458);}
case 458:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",463);}
case 463:{f.Locals[15]=f.Pop();f.Pc=465;continue;}
case 465:{f.Push(f.Locals[15]);f.Pc=467;continue;}
case 467:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",472);}
case 472:{f.Pc=f.Pop().Int==0?519:475;continue;}
case 475:{f.Push(f.Locals[15]);f.Pc=477;continue;}
case 477:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",482);}
case 482:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=485;continue;}
case 485:{f.Locals[16]=f.Pop();f.Pc=487;continue;}
case 487:{f.Push(f.Locals[16]);f.Pc=489;continue;}
case 489:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=492;continue;}
case 492:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",495);}
case 495:{return rt.Call(f,"forge/game/card/CardState","getType","()Lforge/card/CardTypeView;","invokevirtual",498);}
case 498:{return rt.Call(f,"forge/card/CardTypeView","isPermanent","()Z","invokeinterface",503);}
case 503:{f.Pc=f.Pop().Int!=0?516:506;continue;}
case 506:{f.Push(JValue.I(1));f.Pc=507;continue;}
case 507:{f.Locals[13]=f.Pop();f.Pc=509;continue;}
case 509:{f.Push(f.Locals[16]);f.Pc=511;continue;}
case 511:{f.Locals[14]=f.Pop();f.Pc=513;continue;}
case 513:{f.Pc=519;continue;}
case 516:{f.Pc=465;continue;}
case 519:{f.Push(f.Locals[13]);f.Pc=521;continue;}
case 521:{f.Pc=f.Pop().Int==0?575:524;continue;}
case 524:{f.Push(f.Locals[14]);f.Pc=526;continue;}
case 526:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",529);}
case 529:{f.Locals[15]=f.Pop();f.Pc=531;continue;}
case 531:{f.Push(f.Locals[15]);f.Pc=533;continue;}
case 533:{return rt.Call(f,"forge/game/card/Card","forceTurnFaceUp","()V","invokevirtual",536);}
case 536:{f.Push(f.Locals[5]);f.Pc=538;continue;}
case 538:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",541);}
case 541:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=544;continue;}
case 544:{f.StackOp("dup");f.Pc=545;continue;}
case 545:{f.Push(f.Locals[15]);f.Pc=547;continue;}
case 547:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",550);}
case 550:{f.Push(f.Locals[15]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",555);}
case 555:{f.Push(JValue.I(1));f.Pc=556;continue;}
case 556:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",559);}
case 559:{f.Push(JValue.R(rt.String("lblFaceDownCardCantTurnFaceUp")));f.Pc=562;continue;}
case 562:{f.Push(JValue.I(0));f.Pc=563;continue;}
case 563:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=566;continue;}
case 566:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",569);}
case 569:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;)V","invokevirtual",572);}
case 572:{f.Pc=217;continue;}
case 575:{f.Pc=643;continue;}
case 578:{f.Push(f.Locals[12]);f.Pc=580;continue;}
case 580:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",583);}
case 583:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",586);}
case 586:{return rt.Call(f,"forge/card/CardType","isPermanent","()Z","invokevirtual",589);}
case 589:{f.Pc=f.Pop().Int!=0?643:592;continue;}
case 592:{f.Push(f.Locals[12]);f.Pc=594;continue;}
case 594:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",597);}
case 597:{f.Locals[13]=f.Pop();f.Pc=599;continue;}
case 599:{f.Push(f.Locals[13]);f.Pc=601;continue;}
case 601:{return rt.Call(f,"forge/game/card/Card","forceTurnFaceUp","()V","invokevirtual",604);}
case 604:{f.Push(f.Locals[5]);f.Pc=606;continue;}
case 606:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",609);}
case 609:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=612;continue;}
case 612:{f.StackOp("dup");f.Pc=613;continue;}
case 613:{f.Push(f.Locals[13]);f.Pc=615;continue;}
case 615:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",618);}
case 618:{f.Push(f.Locals[13]);f.Pc=620;continue;}
case 620:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",623);}
case 623:{f.Push(JValue.I(1));f.Pc=624;continue;}
case 624:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",627);}
case 627:{f.Push(JValue.R(rt.String("lblFaceDownCardCantTurnFaceUp")));f.Pc=630;continue;}
case 630:{f.Push(JValue.I(0));f.Pc=631;continue;}
case 631:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=634;continue;}
case 634:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",637);}
case 637:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;)V","invokevirtual",640);}
case 640:{f.Pc=217;continue;}
case 643:{f.Push(JValue.R(rt.String("TurnFaceDown")));f.Pc=645;continue;}
case 645:{f.Push(f.Locals[3]);f.Pc=646;continue;}
case 646:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",649);}
case 649:{f.Pc=f.Pop().Int==0?738:652;continue;}
case 652:{f.Push(f.Locals[12]);f.Pc=654;continue;}
case 654:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",657);}
case 657:{f.Pc=f.Pop().Int!=0?738:660;continue;}
case 660:{f.Push(f.Locals[12]);f.Pc=662;continue;}
case 662:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",665);}
case 665:{f.Pc=f.Pop().Int==0?738:668;continue;}
case 668:{f.Push(f.Locals[12]);f.Pc=670;continue;}
case 670:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",673);}
case 673:{f.Pc=f.Pop().Int==0?738:676;continue;}
case 676:{f.Push(JValue.I(0));f.Pc=677;continue;}
case 677:{f.Locals[13]=f.Pop();f.Pc=679;continue;}
case 679:{f.Push(f.Locals[12]);f.Pc=681;continue;}
case 681:{return rt.Call(f,"forge/game/card/Card","getMergedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",684);}
case 684:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",689);}
case 689:{f.Locals[14]=f.Pop();f.Pc=691;continue;}
case 691:{f.Push(f.Locals[14]);f.Pc=693;continue;}
case 693:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",698);}
case 698:{f.Pc=f.Pop().Int==0?730:701;continue;}
case 701:{f.Push(f.Locals[14]);f.Pc=703;continue;}
case 703:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",708);}
case 708:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=711;continue;}
case 711:{f.Locals[15]=f.Pop();f.Pc=713;continue;}
case 713:{f.Push(f.Locals[15]);f.Pc=715;continue;}
case 715:{return rt.Call(f,"forge/game/card/Card","isDoubleFaced","()Z","invokevirtual",718);}
case 718:{f.Pc=f.Pop().Int==0?727:721;continue;}
case 721:{f.Push(JValue.I(1));f.Pc=722;continue;}
case 722:{f.Locals[13]=f.Pop();f.Pc=724;continue;}
case 724:{f.Pc=730;continue;}
case 727:{f.Pc=691;continue;}
case 730:{f.Push(f.Locals[13]);f.Pc=732;continue;}
case 732:{f.Pc=f.Pop().Int==0?738:735;continue;}
case 735:{f.Pc=217;continue;}
case 738:{f.Push(JValue.R(rt.String("Transform")));f.Pc=741;continue;}
case 741:{f.Push(f.Locals[3]);f.Pc=742;continue;}
case 742:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",745);}
case 745:{f.Pc=f.Pop().Int==0?760:748;continue;}
case 748:{f.Push(f.Locals[12]);f.Pc=750;continue;}
case 750:{f.Push(f.Locals[1]);f.Pc=751;continue;}
case 751:{return rt.Call(f,"forge/game/card/Card","canTransform","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",754);}
case 754:{f.Pc=f.Pop().Int!=0?760:757;continue;}
case 757:{f.Pc=217;continue;}
case 760:{f.Push(JValue.R(rt.String("Transform")));f.Pc=763;continue;}
case 763:{f.Push(f.Locals[3]);f.Pc=764;continue;}
case 764:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",767);}
case 767:{f.Pc=f.Pop().Int==0?831:770;continue;}
case 770:{f.Push(f.Locals[12]);f.Pc=772;continue;}
case 772:{f.Push(f.Locals[4]);f.Pc=774;continue;}
case 774:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",777);}
case 777:{f.Pc=f.Pop().Int==0?831:780;continue;}
case 780:{f.Push(f.Locals[1]);f.Pc=781;continue;}
case 781:{f.Push(JValue.R(rt.String("StoredTransform")));f.Pc=784;continue;}
case 784:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasSVar","(Ljava/lang/String;)Z","invokevirtual",787);}
case 787:{f.Pc=f.Pop().Int==0?831:790;continue;}
case 790:{f.Push(f.Locals[12]);f.Pc=792;continue;}
case 792:{return rt.Call(f,"forge/game/card/Card","getTransformedTimestamp","()J","invokevirtual",795);}
case 795:{f.Push(f.Locals[1]);f.Pc=796;continue;}
case 796:{f.Push(JValue.R(rt.String("StoredTransform")));f.Pc=799;continue;}
case 799:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",802);}
case 802:{return rt.Call(f,"java/lang/Long","parseLong","(Ljava/lang/String;)J","invokestatic",805);}
case 805:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=806;continue;}
case 806:{f.Pc=f.Pop().Int==0?813:809;continue;}
case 809:{f.Push(JValue.I(1));f.Pc=810;continue;}
case 810:{f.Pc=814;continue;}
case 813:{f.Push(JValue.I(0));f.Pc=814;continue;}
case 814:{f.Locals[13]=f.Pop();f.Pc=816;continue;}
case 816:{f.Push(f.Locals[1]);f.Pc=817;continue;}
case 817:{f.Push(JValue.R(rt.String("StoredTransform")));f.Pc=820;continue;}
case 820:{return rt.Call(f,"forge/game/spellability/SpellAbility","removeSVar","(Ljava/lang/String;)V","invokevirtual",823);}
case 823:{f.Push(f.Locals[13]);f.Pc=825;continue;}
case 825:{f.Pc=f.Pop().Int==0?831:828;continue;}
case 828:{f.Pc=217;continue;}
case 831:{f.Push(f.Locals[7]);f.Pc=833;continue;}
case 833:{f.Pc=f.Pop().Int==0?885:836;continue;}
case 836:{f.Push(JValue.I(3));f.Pc=837;continue;}
case 837:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=840;continue;}
case 840:{f.StackOp("dup");f.Pc=841;continue;}
case 841:{f.Push(JValue.I(0));f.Pc=842;continue;}
case 842:{f.Push(JValue.R(rt.String("Transform")));f.Pc=845;continue;}
case 845:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=846;continue;}
case 846:{f.StackOp("dup");f.Pc=847;continue;}
case 847:{f.Push(JValue.I(1));f.Pc=848;continue;}
case 848:{f.Push(f.Locals[12]);f.Pc=850;continue;}
case 850:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",853);}
case 853:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=854;continue;}
case 854:{f.StackOp("dup");f.Pc=855;continue;}
case 855:{f.Push(JValue.I(2));f.Pc=856;continue;}
case 856:{f.Push(JValue.R(rt.String("?")));f.Pc=859;continue;}
case 859:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=860;continue;}
case 860:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",863);}
case 863:{f.Locals[13]=f.Pop();f.Pc=865;continue;}
case 865:{f.Push(f.Locals[2]);f.Pc=866;continue;}
case 866:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",869);}
case 869:{f.Push(f.Locals[1]);f.Pc=870;continue;}
case 870:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","Random","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","Random","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=873;continue;}
case 873:{f.Push(f.Locals[13]);f.Pc=875;continue;}
case 875:{f.Push(f.Locals[12]);f.Pc=877;continue;}
case 877:{f.Push(JValue.R(null));f.Pc=878;continue;}
case 878:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",881);}
case 881:{f.Pc=f.Pop().Int!=0?885:884;continue;}
case 884:{return JStep.ReturnVoid;}
case 885:{f.Push(f.Locals[1]);f.Pc=886;continue;}
case 886:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTurnFaceUp","()Z","invokevirtual",889);}
case 889:{f.Pc=f.Pop().Int==0?903:892;continue;}
case 892:{f.Push(f.Locals[12]);f.Pc=894;continue;}
case 894:{f.Push(f.Locals[1]);f.Pc=895;continue;}
case 895:{return rt.Call(f,"forge/game/card/Card","turnFaceUp","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",898);}
case 898:{f.Locals[13]=f.Pop();f.Pc=900;continue;}
case 900:{f.Pc=992;continue;}
case 903:{f.Push(JValue.R(rt.String("Specialize")));f.Pc=905;continue;}
case 905:{f.Push(f.Locals[3]);f.Pc=906;continue;}
case 906:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",909);}
case 909:{f.Pc=f.Pop().Int==0?935:912;continue;}
case 912:{f.Push(f.Locals[12]);f.Pc=914;continue;}
case 914:{f.Push(f.Locals[3]);f.Pc=915;continue;}
case 915:{f.Push(f.Locals[4]);f.Pc=917;continue;}
case 917:{return rt.Call(f,"forge/game/card/Card","getChosenColor","()Ljava/lang/String;","invokevirtual",920);}
case 920:{f.Push(f.Locals[1]);f.Pc=921;continue;}
case 921:{return rt.Call(f,"forge/game/card/Card","changeCardState","(Ljava/lang/String;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",924);}
case 924:{f.Locals[13]=f.Pop();f.Pc=926;continue;}
case 926:{f.Push(f.Locals[4]);f.Pc=928;continue;}
case 928:{f.Push(JValue.R(null));f.Pc=929;continue;}
case 929:{return rt.Call(f,"forge/game/card/Card","setChosenColors","(Ljava/util/List;)V","invokevirtual",932);}
case 932:{f.Pc=992;continue;}
case 935:{f.Push(f.Locals[12]);f.Pc=937;continue;}
case 937:{f.Push(f.Locals[3]);f.Pc=938;continue;}
case 938:{f.Push(f.Locals[1]);f.Pc=939;continue;}
case 939:{f.Push(JValue.R(rt.String("NewState")));f.Pc=942;continue;}
case 942:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",945);}
case 945:{f.Push(f.Locals[1]);f.Pc=946;continue;}
case 946:{return rt.Call(f,"forge/game/card/Card","changeCardState","(Ljava/lang/String;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",949);}
case 949:{f.Locals[13]=f.Pop();f.Pc=951;continue;}
case 951:{f.Push(f.Locals[13]);f.Pc=953;continue;}
case 953:{f.Pc=f.Pop().Int==0?992:956;continue;}
case 956:{f.Push(f.Locals[1]);f.Pc=957;continue;}
case 957:{f.Push(JValue.R(rt.String("FaceDownPower")));f.Pc=960;continue;}
case 960:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",963);}
case 963:{f.Pc=f.Pop().Int!=0?986:966;continue;}
case 966:{f.Push(f.Locals[1]);f.Pc=967;continue;}
case 967:{f.Push(JValue.R(rt.String("FaceDownToughness")));f.Pc=970;continue;}
case 970:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",973);}
case 973:{f.Pc=f.Pop().Int!=0?986:976;continue;}
case 976:{f.Push(f.Locals[1]);f.Pc=977;continue;}
case 977:{f.Push(JValue.R(rt.String("FaceDownSetType")));f.Pc=980;continue;}
case 980:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",983);}
case 983:{f.Pc=f.Pop().Int==0?992:986;continue;}
case 986:{f.Push(f.Locals[12]);f.Pc=988;continue;}
case 988:{f.Push(f.Locals[1]);f.Pc=989;continue;}
case 989:{return rt.Call(f,"forge/game/card/CardFactoryUtil","setFaceDownState","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",992);}
case 992:{f.Push(f.Locals[13]);f.Pc=994;continue;}
case 994:{f.Pc=f.Pop().Int==0?1387:997;continue;}
case 997:{f.Push(f.Locals[1]);f.Pc=998;continue;}
case 998:{return rt.Call(f,"forge/game/spellability/SpellAbility","isMorphUp","()Z","invokevirtual",1001);}
case 1001:{f.Pc=f.Pop().Int==0?1040:1004;continue;}
case 1004:{f.Push(f.Locals[2]);f.Pc=1005;continue;}
case 1005:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1008);}
case 1008:{f.Push(f.Locals[12]);f.Pc=1010;continue;}
case 1010:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",1013);}
case 1013:{return rt.DynamicCall(f,"forge/game/ability/effects/SetStateEffect:3722:1013:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1018);}
case 1018:{f.Locals[14]=f.Pop();f.Pc=1020;continue;}
case 1020:{f.Push(f.Locals[5]);f.Pc=1022;continue;}
case 1022:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=1025;continue;}
case 1025:{f.StackOp("dup");f.Pc=1026;continue;}
case 1026:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=1029;continue;}
case 1029:{f.Push(f.Locals[14]);f.Pc=1031;continue;}
case 1031:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",1034);}
case 1034:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1037);}
case 1037:{f.Pc=1271;continue;}
case 1040:{f.Push(f.Locals[1]);f.Pc=1041;continue;}
case 1041:{return rt.Call(f,"forge/game/spellability/SpellAbility","isManifestUp","()Z","invokevirtual",1044);}
case 1044:{f.Pc=f.Pop().Int==0?1083:1047;continue;}
case 1047:{f.Push(f.Locals[2]);f.Pc=1048;continue;}
case 1048:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1051);}
case 1051:{f.Push(f.Locals[12]);f.Pc=1053;continue;}
case 1053:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",1056);}
case 1056:{return rt.DynamicCall(f,"forge/game/ability/effects/SetStateEffect:3722:1056:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1061);}
case 1061:{f.Locals[14]=f.Pop();f.Pc=1063;continue;}
case 1063:{f.Push(f.Locals[5]);f.Pc=1065;continue;}
case 1065:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=1068;continue;}
case 1068:{f.StackOp("dup");f.Pc=1069;continue;}
case 1069:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=1072;continue;}
case 1072:{f.Push(f.Locals[14]);f.Pc=1074;continue;}
case 1074:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",1077);}
case 1077:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1080);}
case 1080:{f.Pc=1271;continue;}
case 1083:{f.Push(f.Locals[1]);f.Pc=1084;continue;}
case 1084:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDisguiseUp","()Z","invokevirtual",1087);}
case 1087:{f.Pc=f.Pop().Int==0?1126:1090;continue;}
case 1090:{f.Push(f.Locals[2]);f.Pc=1091;continue;}
case 1091:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1094);}
case 1094:{f.Push(f.Locals[12]);f.Pc=1096;continue;}
case 1096:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",1099);}
case 1099:{return rt.DynamicCall(f,"forge/game/ability/effects/SetStateEffect:3722:1099:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1104);}
case 1104:{f.Locals[14]=f.Pop();f.Pc=1106;continue;}
case 1106:{f.Push(f.Locals[5]);f.Pc=1108;continue;}
case 1108:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=1111;continue;}
case 1111:{f.StackOp("dup");f.Pc=1112;continue;}
case 1112:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=1115;continue;}
case 1115:{f.Push(f.Locals[14]);f.Pc=1117;continue;}
case 1117:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",1120);}
case 1120:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1123);}
case 1123:{f.Pc=1271;continue;}
case 1126:{f.Push(f.Locals[1]);f.Pc=1127;continue;}
case 1127:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCloakUp","()Z","invokevirtual",1130);}
case 1130:{f.Pc=f.Pop().Int==0?1169:1133;continue;}
case 1133:{f.Push(f.Locals[2]);f.Pc=1134;continue;}
case 1134:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1137);}
case 1137:{f.Push(f.Locals[12]);f.Pc=1139;continue;}
case 1139:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",1142);}
case 1142:{return rt.DynamicCall(f,"forge/game/ability/effects/SetStateEffect:3722:1142:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1147);}
case 1147:{f.Locals[14]=f.Pop();f.Pc=1149;continue;}
case 1149:{f.Push(f.Locals[5]);f.Pc=1151;continue;}
case 1151:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=1154;continue;}
case 1154:{f.StackOp("dup");f.Pc=1155;continue;}
case 1155:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=1158;continue;}
case 1158:{f.Push(f.Locals[14]);f.Pc=1160;continue;}
case 1160:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",1163);}
case 1163:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1166);}
case 1166:{f.Pc=1271;continue;}
case 1169:{f.Push(f.Locals[1]);f.Pc=1170;continue;}
case 1170:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","DOUBLE_AGENDA","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","DOUBLE_AGENDA","Lforge/game/keyword/Keyword;"));f.Pc=1173;continue;}
case 1173:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",1176);}
case 1176:{f.Pc=f.Pop().Int==0?1223:1179;continue;}
case 1179:{f.Push(f.Locals[2]);f.Pc=1180;continue;}
case 1180:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1183);}
case 1183:{f.Push(f.Locals[12]);f.Pc=1185;continue;}
case 1185:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",1188);}
case 1188:{f.Push(f.Locals[12]);f.Pc=1190;continue;}
case 1190:{return rt.Call(f,"forge/game/card/Card","getNamedCards","()Ljava/util/List;","invokevirtual",1193);}
case 1193:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1196);}
case 1196:{return rt.DynamicCall(f,"forge/game/ability/effects/SetStateEffect:3722:1196:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1201);}
case 1201:{f.Locals[14]=f.Pop();f.Pc=1203;continue;}
case 1203:{f.Push(f.Locals[5]);f.Pc=1205;continue;}
case 1205:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=1208;continue;}
case 1208:{f.StackOp("dup");f.Pc=1209;continue;}
case 1209:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=1212;continue;}
case 1212:{f.Push(f.Locals[14]);f.Pc=1214;continue;}
case 1214:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",1217);}
case 1217:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1220);}
case 1220:{f.Pc=1271;continue;}
case 1223:{f.Push(f.Locals[1]);f.Pc=1224;continue;}
case 1224:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","HIDDEN_AGENDA","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","HIDDEN_AGENDA","Lforge/game/keyword/Keyword;"));f.Pc=1227;continue;}
case 1227:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",1230);}
case 1230:{f.Pc=f.Pop().Int==0?1271:1233;continue;}
case 1233:{f.Push(f.Locals[2]);f.Pc=1234;continue;}
case 1234:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1237);}
case 1237:{f.Push(f.Locals[12]);f.Pc=1239;continue;}
case 1239:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",1242);}
case 1242:{f.Push(f.Locals[12]);f.Pc=1244;continue;}
case 1244:{return rt.Call(f,"forge/game/card/Card","getNamedCard","()Ljava/lang/String;","invokevirtual",1247);}
case 1247:{return rt.DynamicCall(f,"forge/game/ability/effects/SetStateEffect:3722:1247:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1252);}
case 1252:{f.Locals[14]=f.Pop();f.Pc=1254;continue;}
case 1254:{f.Push(f.Locals[5]);f.Pc=1256;continue;}
case 1256:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=1259;continue;}
case 1259:{f.StackOp("dup");f.Pc=1260;continue;}
case 1260:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=1263;continue;}
case 1263:{f.Push(f.Locals[14]);f.Pc=1265;continue;}
case 1265:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",1268);}
case 1268:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1271);}
case 1271:{f.Push(f.Locals[5]);f.Pc=1273;continue;}
case 1273:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=1276;continue;}
case 1276:{f.StackOp("dup");f.Pc=1277;continue;}
case 1277:{f.Push(f.Locals[12]);f.Pc=1279;continue;}
case 1279:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",1282);}
case 1282:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1285);}
case 1285:{f.Push(f.Locals[6]);f.Pc=1287;continue;}
case 1287:{f.Pc=f.Pop().Int==0?1297:1290;continue;}
case 1290:{f.Push(f.Locals[4]);f.Pc=1292;continue;}
case 1292:{f.Push(f.Locals[12]);f.Pc=1294;continue;}
case 1294:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1297);}
case 1297:{f.Push(f.Locals[12]);f.Pc=1299;continue;}
case 1299:{return rt.Call(f,"forge/game/card/Card","isTransformable","()Z","invokevirtual",1302);}
case 1302:{f.Pc=f.Pop().Int!=0?1313:1305;continue;}
case 1305:{f.Push(f.Locals[8]);f.Pc=1307;continue;}
case 1307:{f.Push(f.Locals[12]);f.Pc=1309;continue;}
case 1309:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",1312);}
case 1312:{f.StackOp("pop");f.Pc=1313;continue;}
case 1313:{f.Push(JValue.R(rt.String("Specialize")));f.Pc=1315;continue;}
case 1315:{f.Push(f.Locals[3]);f.Pc=1316;continue;}
case 1316:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1319);}
case 1319:{f.Pc=f.Pop().Int==0?1372:1322;continue;}
case 1322:{f.Push(f.Locals[12]);f.Pc=1324;continue;}
case 1324:{f.Push(JValue.I(1));f.Pc=1325;continue;}
case 1325:{return rt.Call(f,"forge/game/card/Card","setSpecialized","(Z)V","invokevirtual",1328);}
case 1328:{f.Push(f.Locals[5]);f.Pc=1330;continue;}
case 1330:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1333);}
case 1333:{f.Locals[14]=f.Pop();f.Pc=1335;continue;}
case 1335:{f.Push(f.Locals[14]);f.Pc=1337;continue;}
case 1337:{f.Push(f.Locals[12]);f.Pc=1339;continue;}
case 1339:{f.Push(JValue.R(null));f.Pc=1340;continue;}
case 1340:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearActiveTriggers","(Lforge/game/card/Card;Lforge/game/zone/Zone;)V","invokevirtual",1343);}
case 1343:{f.Push(f.Locals[14]);f.Pc=1345;continue;}
case 1345:{f.Push(f.Locals[12]);f.Pc=1347;continue;}
case 1347:{f.Push(JValue.I(0));f.Pc=1348;continue;}
case 1348:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerActiveTrigger","(Lforge/game/card/Card;Z)V","invokevirtual",1351);}
case 1351:{f.Push(f.Locals[12]);f.Pc=1353;continue;}
case 1353:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",1356);}
case 1356:{f.Locals[15]=f.Pop();f.Pc=1358;continue;}
case 1358:{f.Push(f.Locals[14]);f.Pc=1360;continue;}
case 1360:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Specializes","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Specializes","Lforge/game/trigger/TriggerType;"));f.Pc=1363;continue;}
case 1363:{f.Push(f.Locals[15]);f.Pc=1365;continue;}
case 1365:{f.Push(JValue.I(0));f.Pc=1366;continue;}
case 1366:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1369);}
case 1369:{f.Pc=1387;continue;}
case 1372:{f.Push(JValue.R(rt.String("Unspecialize")));f.Pc=1374;continue;}
case 1374:{f.Push(f.Locals[3]);f.Pc=1375;continue;}
case 1375:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1378);}
case 1378:{f.Pc=f.Pop().Int==0?1387:1381;continue;}
case 1381:{f.Push(f.Locals[12]);f.Pc=1383;continue;}
case 1383:{f.Push(JValue.I(0));f.Pc=1384;continue;}
case 1384:{return rt.Call(f,"forge/game/card/Card","setSpecialized","(Z)V","invokevirtual",1387);}
case 1387:{f.Pc=217;continue;}
case 1390:{f.Push(f.Locals[8]);f.Pc=1392;continue;}
case 1392:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1395);}
case 1395:{f.Pc=f.Pop().Int!=0?1413:1398;continue;}
case 1398:{f.Push(f.Locals[5]);f.Pc=1400;continue;}
case 1400:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1403);}
case 1403:{f.Push(f.Locals[8]);f.Pc=1405;continue;}
case 1405:{f.Push(f.Locals[2]);f.Pc=1406;continue;}
case 1406:{f.Push(JValue.I(1));f.Pc=1407;continue;}
case 1407:{f.Push(JValue.R(rt.String("Transformed cards in ")));f.Pc=1410;continue;}
case 1410:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;)V","invokevirtual",1413);}
case 1413:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
