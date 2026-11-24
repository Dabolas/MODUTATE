// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C429{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ZoneExchangeEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3830,"forge/game/ability/effects/ZoneExchangeEffect","<init>","()V",1,1,1,new JHandler[]{},M3830));
c.Add(new JMethod(3831,"forge/game/ability/effects/ZoneExchangeEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,3,new JHandler[]{},M3831));
c.Add(new JMethod(3832,"forge/game/ability/effects/ZoneExchangeEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,18,6,new JHandler[]{},M3832));
}

internal static JStep M3830(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3831(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Object")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?34:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",13);}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Object")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",23);}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Pc=39;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",38);}
case 38:{f.Locals[2]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("Type")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("Zone2")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",51);}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",55);}
case 55:{return rt.DynamicCall(f,"forge/game/ability/effects/ZoneExchangeEffect:3831:55:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",60);}
case 60:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3832(JRuntime rt,JFrame f)
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
case 17:{f.Push(JValue.R(rt.String("Type")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Locals[5]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("ValidExchange")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",30);}
case 30:{f.Locals[6]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("Zone1")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?53:41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("Zone1")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",50);}
case 50:{f.Pc=56;continue;}
case 53:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=56;continue;}
case 56:{f.Locals[7]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("Zone2")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int==0?79:67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("Zone2")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",73);}
case 73:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",76);}
case 76:{f.Pc=82;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=82;continue;}
case 82:{f.Locals[8]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(JValue.R(null));f.Pc=85;continue;}
case 85:{f.Locals[9]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("Object")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int==0?119:96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("Object")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",103);}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",107);}
case 107:{f.Push(JValue.I(0));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",111);}
case 111:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=114;continue;}
case 114:{f.Locals[9]=f.Pop();f.Pc=116;continue;}
case 116:{f.Pc=122;continue;}
case 119:{f.Push(f.Locals[2]);f.Pc=120;continue;}
case 120:{f.Locals[9]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[9]);f.Pc=124;continue;}
case 124:{f.Pc=f.Pop().Reference==null?149:127;continue;}
case 127:{f.Push(f.Locals[9]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[7]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int==0?149:137;continue;}
case 137:{f.Push(f.Locals[9]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",142);}
case 142:{f.Push(f.Locals[3]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",146);}
case 146:{f.Pc=f.Pop().Int!=0?150:149;continue;}
case 149:{return JStep.ReturnVoid;}
case 150:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=153;continue;}
case 153:{f.StackOp("dup");f.Pc=154;continue;}
case 154:{f.Push(f.Locals[3]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[8]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",160);}
case 160:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",163);}
case 163:{f.Locals[10]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[5]);f.Pc=167;continue;}
case 167:{f.Pc=f.Pop().Reference==null?193:170;continue;}
case 170:{f.Push(f.Locals[9]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",175);}
case 175:{f.Push(f.Locals[5]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z","invokeinterface",182);}
case 182:{f.Pc=f.Pop().Int!=0?186:185;continue;}
case 185:{return JStep.ReturnVoid;}
case 186:{f.Push(f.Locals[5]);f.Pc=188;continue;}
case 188:{f.Locals[11]=f.Pop();f.Pc=190;continue;}
case 190:{f.Pc=209;continue;}
case 193:{f.Push(f.Locals[6]);f.Pc=195;continue;}
case 195:{f.Pc=f.Pop().Reference==null?205:198;continue;}
case 198:{f.Push(f.Locals[6]);f.Pc=200;continue;}
case 200:{f.Locals[11]=f.Pop();f.Pc=202;continue;}
case 202:{f.Pc=209;continue;}
case 205:{f.Push(JValue.R(rt.String("Card")));f.Pc=207;continue;}
case 207:{f.Locals[11]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[10]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[11]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[3]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[2]);f.Pc=215;continue;}
case 215:{f.Push(f.Locals[1]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",219);}
case 219:{f.Locals[10]=f.Pop();f.Pc=221;continue;}
case 221:{f.Push(f.Locals[10]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",226);}
case 226:{f.Pc=f.Pop().Int==0?230:229;continue;}
case 229:{return JStep.ReturnVoid;}
case 230:{f.Push(f.Locals[3]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",234);}
case 234:{f.Push(f.Locals[10]);f.Pc=236;continue;}
case 236:{f.Push(f.Locals[1]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",240);}
case 240:{f.Push(JValue.R(rt.String("lblChooseaCard")));f.Pc=242;continue;}
case 242:{f.Push(JValue.I(0));f.Pc=243;continue;}
case 243:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",249);}
case 249:{f.Push(f.Locals[1]);f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.String("Mandatory")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",255);}
case 255:{f.Pc=f.Pop().Int!=0?262:258;continue;}
case 258:{f.Push(JValue.I(1));f.Pc=259;continue;}
case 259:{f.Pc=263;continue;}
case 262:{f.Push(JValue.I(0));f.Pc=263;continue;}
case 263:{f.Push(JValue.R(null));f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",267);}
case 267:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=270;continue;}
case 270:{f.Locals[12]=f.Pop();f.Pc=272;continue;}
case 272:{f.Push(f.Locals[12]);f.Pc=274;continue;}
case 274:{f.Pc=f.Pop().Reference==null?307:277;continue;}
case 277:{f.Push(f.Locals[12]);f.Pc=279;continue;}
case 279:{f.Push(f.Locals[8]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",284);}
case 284:{f.Pc=f.Pop().Int==0?307:287;continue;}
case 287:{f.Push(f.Locals[5]);f.Pc=289;continue;}
case 289:{f.Pc=f.Pop().Reference==null?308:292;continue;}
case 292:{f.Push(f.Locals[12]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",297);}
case 297:{f.Push(f.Locals[5]);f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z","invokeinterface",304);}
case 304:{f.Pc=f.Pop().Int!=0?308:307;continue;}
case 307:{return JStep.ReturnVoid;}
case 308:{f.Push(JValue.R(null));f.Pc=309;continue;}
case 309:{f.Locals[13]=f.Pop();f.Pc=311;continue;}
case 311:{f.Push(f.Locals[5]);f.Pc=313;continue;}
case 313:{f.Pc=f.Pop().Reference==null?353:316;continue;}
case 316:{f.Push(f.Locals[5]);f.Pc=318;continue;}
case 318:{f.Push(JValue.R(rt.String("Aura")));f.Pc=320;continue;}
case 320:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",323);}
case 323:{f.Pc=f.Pop().Int==0?353:326;continue;}
case 326:{f.Push(f.Locals[9]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/game/card/Card","getEnchantingCard","()Lforge/game/card/Card;","invokevirtual",331);}
case 331:{f.Pc=f.Pop().Reference==null?353:334;continue;}
case 334:{f.Push(f.Locals[9]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/card/Card","getEnchantingCard","()Lforge/game/card/Card;","invokevirtual",339);}
case 339:{f.Locals[13]=f.Pop();f.Pc=341;continue;}
case 341:{f.Push(f.Locals[13]);f.Pc=343;continue;}
case 343:{f.Push(f.Locals[12]);f.Pc=345;continue;}
case 345:{f.Push(f.Locals[1]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/card/Card","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",349);}
case 349:{f.Pc=f.Pop().Int!=0?353:352;continue;}
case 352:{return JStep.ReturnVoid;}
case 353:{f.Push(f.Locals[13]);f.Pc=355;continue;}
case 355:{f.Pc=f.Pop().Reference==null?373:358;continue;}
case 358:{f.Push(f.Locals[9]);f.Pc=360;continue;}
case 360:{f.Push(f.Locals[13]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/card/Card","unattachFromEntity","(Lforge/game/GameEntity;)V","invokevirtual",365);}
case 365:{f.Push(f.Locals[12]);f.Pc=367;continue;}
case 367:{f.Push(f.Locals[13]);f.Pc=369;continue;}
case 369:{f.Push(f.Locals[1]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/card/Card","attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)V","invokevirtual",373);}
case 373:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",376);}
case 376:{f.Locals[14]=f.Pop();f.Pc=378;continue;}
case 378:{f.Push(f.Locals[14]);f.Pc=380;continue;}
case 380:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=383;continue;}
case 383:{f.Push(f.Locals[1]);f.Pc=384;continue;}
case 384:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateBattlefield","()Lforge/game/card/CardCollection;","invokevirtual",387);}
case 387:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",392);}
case 392:{f.StackOp("pop");f.Pc=393;continue;}
case 393:{f.Push(f.Locals[14]);f.Pc=395;continue;}
case 395:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=398;continue;}
case 398:{f.Push(f.Locals[1]);f.Pc=399;continue;}
case 399:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateGraveyard","()Lforge/game/card/CardCollection;","invokevirtual",402);}
case 402:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",407);}
case 407:{f.StackOp("pop");f.Pc=408;continue;}
case 408:{f.Push(f.Locals[4]);f.Pc=410;continue;}
case 410:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",413);}
case 413:{f.Push(f.Locals[8]);f.Pc=415;continue;}
case 415:{f.Push(f.Locals[9]);f.Pc=417;continue;}
case 417:{f.Push(f.Locals[1]);f.Pc=418;continue;}
case 418:{f.Push(f.Locals[14]);f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",423);}
case 423:{f.Locals[15]=f.Pop();f.Pc=425;continue;}
case 425:{f.Push(f.Locals[4]);f.Pc=427;continue;}
case 427:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",430);}
case 430:{f.Push(f.Locals[7]);f.Pc=432;continue;}
case 432:{f.Push(f.Locals[12]);f.Pc=434;continue;}
case 434:{f.Push(f.Locals[1]);f.Pc=435;continue;}
case 435:{f.Push(f.Locals[14]);f.Pc=437;continue;}
case 437:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",440);}
case 440:{f.Locals[16]=f.Pop();f.Pc=442;continue;}
case 442:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=445;continue;}
case 445:{f.StackOp("dup");f.Pc=446;continue;}
case 446:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",449);}
case 449:{f.Locals[17]=f.Pop();f.Pc=451;continue;}
case 451:{f.Push(f.Locals[17]);f.Pc=453;continue;}
case 453:{f.Push(f.Locals[7]);f.Pc=455;continue;}
case 455:{f.Push(f.Locals[15]);f.Pc=457;continue;}
case 457:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",460);}
case 460:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",463);}
case 463:{f.Push(f.Locals[15]);f.Pc=465;continue;}
case 465:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",468);}
case 468:{f.StackOp("pop");f.Pc=469;continue;}
case 469:{f.Push(f.Locals[17]);f.Pc=471;continue;}
case 471:{f.Push(f.Locals[8]);f.Pc=473;continue;}
case 473:{f.Push(f.Locals[16]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",478);}
case 478:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",481);}
case 481:{f.Push(f.Locals[16]);f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",486);}
case 486:{f.StackOp("pop");f.Pc=487;continue;}
case 487:{f.Push(f.Locals[17]);f.Pc=489;continue;}
case 489:{f.Push(f.Locals[4]);f.Pc=491;continue;}
case 491:{f.Push(f.Locals[1]);f.Pc=492;continue;}
case 492:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",495);}
case 495:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
