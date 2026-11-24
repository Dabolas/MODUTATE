// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C338{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/MustBlockEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3514,"forge/game/ability/effects/MustBlockEffect","<init>","()V",1,1,1,new JHandler[]{},M3514));
c.Add(new JMethod(3515,"forge/game/ability/effects/MustBlockEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,14,6,new JHandler[]{},M3515));
c.Add(new JMethod(3516,"forge/game/ability/effects/MustBlockEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,7,3,new JHandler[]{},M3516));
}

internal static JStep M3514(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3515(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("DefinedAttacker")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?49:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("DefinedAttacker")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",36);}
case 36:{f.Locals[5]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",45);}
case 45:{f.Pc=f.Pop().Int==0?62:48;continue;}
case 48:{return JStep.ReturnVoid;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=53;continue;}
case 53:{f.StackOp("dup");f.Pc=54;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=57;continue;}
case 57:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",60);}
case 60:{f.Locals[5]=f.Pop();f.Pc=62;continue;}
case 62:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",65);}
case 65:{f.Locals[6]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("Choices")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int==0?241:76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{f.Locals[7]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?112:88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",94);}
case 94:{f.Locals[8]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[8]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",103);}
case 103:{f.Push(JValue.I(0));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",107);}
case 107:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=110;continue;}
case 110:{f.Locals[7]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[4]);f.Pc=114;continue;}
case 114:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",120);}
case 120:{f.Locals[8]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[8]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("Choices")));f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",130);}
case 130:{f.Push(f.Locals[3]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[1]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",136);}
case 136:{f.Locals[8]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[8]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",145);}
case 145:{f.Pc=f.Pop().Int!=0?238:148;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",154);}
case 154:{f.Pc=f.Pop().Int==0?166:157;continue;}
case 157:{f.Push(f.Locals[1]);f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",163);}
case 163:{f.Pc=183;continue;}
case 166:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",169);}
case 169:{f.Push(JValue.R(rt.String("lblChooseaCard")));f.Pc=171;continue;}
case 171:{f.Push(JValue.I(0));f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",178);}
case 178:{return rt.DynamicCall(f,"forge/game/ability/effects/MustBlockEffect:3515:178:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",183);}
case 183:{f.Locals[9]=f.Pop();f.Pc=185;continue;}
case 185:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",188);}
case 188:{f.Locals[10]=f.Pop();f.Pc=190;continue;}
case 190:{f.Push(f.Locals[10]);f.Pc=192;continue;}
case 192:{f.Push(JValue.R(rt.String("Attackers")));f.Pc=194;continue;}
case 194:{f.Push(f.Locals[5]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",201);}
case 201:{f.StackOp("pop");f.Pc=202;continue;}
case 202:{f.Push(f.Locals[7]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",207);}
case 207:{f.Push(f.Locals[8]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[1]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[9]);f.Pc=212;continue;}
case 212:{f.Push(JValue.I(0));f.Pc=213;continue;}
case 213:{f.Push(f.Locals[10]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",218);}
case 218:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=221;continue;}
case 221:{f.Locals[11]=f.Pop();f.Pc=223;continue;}
case 223:{f.Push(f.Locals[11]);f.Pc=225;continue;}
case 225:{f.Pc=f.Pop().Reference==null?238:228;continue;}
case 228:{f.Push(f.Locals[6]);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[11]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",237);}
case 237:{f.StackOp("pop");f.Pc=238;continue;}
case 238:{f.Pc=253;continue;}
case 241:{f.Push(f.Locals[6]);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[1]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/ability/effects/MustBlockEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",247);}
case 247:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",252);}
case 252:{f.StackOp("pop");f.Pc=253;continue;}
case 253:{f.Push(f.Locals[1]);f.Pc=254;continue;}
case 254:{f.Push(JValue.R(rt.String("BlockAllDefined")));f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",259);}
case 259:{f.Locals[7]=f.Pop();f.Pc=261;continue;}
case 261:{f.Push(f.Locals[4]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",266);}
case 266:{f.Locals[8]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[6]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",275);}
case 275:{f.Locals[10]=f.Pop();f.Pc=277;continue;}
case 277:{f.Push(f.Locals[10]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",284);}
case 284:{f.Pc=f.Pop().Int==0?377:287;continue;}
case 287:{f.Push(f.Locals[10]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",294);}
case 294:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=297;continue;}
case 297:{f.Locals[11]=f.Pop();f.Pc=299;continue;}
case 299:{f.Push(f.Locals[4]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[11]);f.Pc=303;continue;}
case 303:{f.Push(JValue.R(null));f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",307);}
case 307:{f.Locals[12]=f.Pop();f.Pc=309;continue;}
case 309:{f.Push(f.Locals[12]);f.Pc=311;continue;}
case 311:{f.Pc=f.Pop().Reference==null?277:314;continue;}
case 314:{f.Push(f.Locals[11]);f.Pc=316;continue;}
case 316:{f.Push(f.Locals[12]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",321);}
case 321:{f.Pc=f.Pop().Int==0?277:324;continue;}
case 324:{f.Push(f.Locals[12]);f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",329);}
case 329:{f.Pc=f.Pop().Int==0?335:332;continue;}
case 332:{f.Pc=277;continue;}
case 335:{f.Push(f.Locals[7]);f.Pc=337;continue;}
case 337:{f.Pc=f.Pop().Int==0?352:340;continue;}
case 340:{f.Push(f.Locals[12]);f.Pc=342;continue;}
case 342:{f.Push(f.Locals[8]);f.Pc=344;continue;}
case 344:{f.Push(f.Locals[5]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/card/Card","addMustBlockCards","(JLjava/lang/Iterable;)V","invokevirtual",349);}
case 349:{f.Pc=374;continue;}
case 352:{f.Push(f.Locals[5]);f.Pc=354;continue;}
case 354:{f.Push(JValue.I(0));f.Pc=355;continue;}
case 355:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",360);}
case 360:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=363;continue;}
case 363:{f.Locals[13]=f.Pop();f.Pc=365;continue;}
case 365:{f.Push(f.Locals[12]);f.Pc=367;continue;}
case 367:{f.Push(f.Locals[8]);f.Pc=369;continue;}
case 369:{f.Push(f.Locals[13]);f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/card/Card","addMustBlockCard","(JLforge/game/card/Card;)V","invokevirtual",374);}
case 374:{f.Pc=277;continue;}
case 377:{f.Push(f.Locals[1]);f.Pc=378;continue;}
case 378:{f.Push(JValue.R(rt.String("Duration")));f.Pc=380;continue;}
case 380:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",383);}
case 383:{f.Pc=f.Pop().Int==0?406:386;continue;}
case 386:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/MustBlockEffect$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/MustBlockEffect$1")));f.Pc=389;continue;}
case 389:{f.StackOp("dup");f.Pc=390;continue;}
case 390:{f.Push(f.Locals[0]);f.Pc=391;continue;}
case 391:{f.Push(f.Locals[6]);f.Pc=393;continue;}
case 393:{f.Push(f.Locals[8]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/ability/effects/MustBlockEffect$1","<init>","(Lforge/game/ability/effects/MustBlockEffect;Ljava/util/List;J)V","invokespecial",398);}
case 398:{f.Locals[10]=f.Pop();f.Pc=400;continue;}
case 400:{f.Push(f.Locals[1]);f.Pc=401;continue;}
case 401:{f.Push(f.Locals[10]);f.Pc=403;continue;}
case 403:{return rt.Call(f,"forge/game/ability/effects/MustBlockEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;)V","invokestatic",406);}
case 406:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3516(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.R(null));f.Pc=14;continue;}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("DefinedAttacker")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?57:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("DefinedAttacker")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",36);}
case 36:{f.Locals[5]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",52);}
case 52:{f.Locals[4]=f.Pop();f.Pc=54;continue;}
case 54:{f.Pc=63;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",61);}
case 61:{f.Locals[4]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("Choices")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?97:72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("Choosen creature ")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",78);}
case 78:{f.Push(JValue.R(rt.String(" must block ")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",83);}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",88);}
case 88:{f.Push(JValue.R(rt.String(" if able.")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",93);}
case 93:{f.StackOp("pop");f.Pc=94;continue;}
case 94:{f.Pc=153;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/ability/effects/MustBlockEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",101);}
case 101:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",104);}
case 104:{f.Locals[5]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[5]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",113);}
case 113:{f.Pc=f.Pop().Int==0?153:116;continue;}
case 116:{f.Push(f.Locals[5]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",123);}
case 123:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=126;continue;}
case 126:{f.Locals[6]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[6]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",134);}
case 134:{f.Push(JValue.R(rt.String(" must block ")));f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",139);}
case 139:{f.Push(f.Locals[4]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",144);}
case 144:{f.Push(JValue.R(rt.String(" if able.")));f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{f.Pc=106;continue;}
case 153:{f.Push(f.Locals[3]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",157);}
case 157:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
