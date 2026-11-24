// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C383{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RestartGameEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3657,"forge/game/ability/effects/RestartGameEffect","<init>","()V",1,1,1,new JHandler[]{},M3657));
c.Add(new JMethod(3658,"forge/game/ability/effects/RestartGameEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,16,6,new JHandler[]{},M3658));
c.Add(new JMethod(3659,"forge/game/ability/effects/RestartGameEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,3,2,new JHandler[]{},M3659));
}

internal static JStep M3657(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3658(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{f.Push(JValue.I(5));f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.NewArray("Lforge/game/zone/ZoneType;",f.Pop().Int)));f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=29;continue;}
case 29:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=35;continue;}
case 35:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(JValue.I(2));f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=41;continue;}
case 41:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.I(3));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(4));f.Pc=50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=53;continue;}
case 53:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",57);}
case 57:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",60);}
case 60:{f.Locals[5]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("RestrictFromZone")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",68);}
case 68:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",71);}
case 71:{f.Locals[6]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[5]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[6]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("RestrictFromValid")));f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("Card")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",91);}
case 91:{f.Locals[7]=f.Pop();f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/trigger/Trigger","resetIDs","()V","invokestatic",96);}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",100);}
case 100:{f.Locals[8]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[8]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearDelayedTrigger","()V","invokevirtual",107);}
case 107:{f.Push(f.Locals[8]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearPlayerDefinedDelayedTrigger","()V","invokevirtual",112);}
case 112:{f.Push(f.Locals[8]);f.Pc=114;continue;}
case 114:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"));f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/trigger/TriggerHandler","suppressMode","(Lforge/game/trigger/TriggerType;)V","invokevirtual",120);}
case 120:{f.Push(f.Locals[8]);f.Pc=122;continue;}
case 122:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Shuffled","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Shuffled","Lforge/game/trigger/TriggerType;"));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/trigger/TriggerHandler","suppressMode","(Lforge/game/trigger/TriggerType;)V","invokevirtual",128);}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",132);}
case 132:{return rt.Call(f,"forge/game/phase/PhaseHandler","restart","()V","invokevirtual",135);}
case 135:{f.Push(f.Locals[3]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/Game","getUntap","()Lforge/game/phase/Untap;","invokevirtual",139);}
case 139:{return rt.Call(f,"forge/game/phase/Untap","clearCommands","()V","invokevirtual",142);}
case 142:{f.Push(f.Locals[3]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/Game","getBeginOfCombat","()Lforge/game/phase/Phase;","invokevirtual",146);}
case 146:{return rt.Call(f,"forge/game/phase/Phase","clearCommands","()V","invokevirtual",149);}
case 149:{f.Push(f.Locals[3]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/Game","getUpkeep","()Lforge/game/phase/Phase;","invokevirtual",153);}
case 153:{return rt.Call(f,"forge/game/phase/Phase","clearCommands","()V","invokevirtual",156);}
case 156:{f.Push(f.Locals[3]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/Game","getEndOfCombat","()Lforge/game/phase/Phase;","invokevirtual",160);}
case 160:{return rt.Call(f,"forge/game/phase/Phase","clearCommands","()V","invokevirtual",163);}
case 163:{f.Push(f.Locals[3]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",167);}
case 167:{return rt.Call(f,"forge/game/phase/Phase","clearCommands","()V","invokevirtual",170);}
case 170:{f.Push(f.Locals[3]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/Game","getCleanup","()Lforge/game/phase/Phase;","invokevirtual",174);}
case 174:{return rt.Call(f,"forge/game/phase/Phase","clearCommands","()V","invokevirtual",177);}
case 177:{f.Push(f.Locals[3]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",181);}
case 181:{return rt.Call(f,"forge/game/zone/MagicStack","reset","()V","invokevirtual",184);}
case 184:{f.Push(f.Locals[3]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/Game","clearCountersThisTurn","()V","invokevirtual",188);}
case 188:{f.Push(f.Locals[3]);f.Pc=189;continue;}
case 189:{f.Push(JValue.R(null));f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/Game","setMonarch","(Lforge/game/player/Player;)V","invokevirtual",193);}
case 193:{f.Push(f.Locals[3]);f.Pc=194;continue;}
case 194:{f.Push(JValue.R(null));f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/Game","setHasInitiative","(Lforge/game/player/Player;)V","invokevirtual",198);}
case 198:{f.Push(f.Locals[3]);f.Pc=199;continue;}
case 199:{f.Push(JValue.R(null));f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/Game","setDayTime","(Ljava/lang/Boolean;)V","invokevirtual",203);}
case 203:{f.Push(f.Locals[3]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",207);}
case 207:{f.Locals[9]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[4]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",216);}
case 216:{f.Locals[10]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[10]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",225);}
case 225:{f.Pc=f.Pop().Int==0?475:228;continue;}
case 228:{f.Push(f.Locals[10]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",235);}
case 235:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=238;continue;}
case 238:{f.Locals[11]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(f.Locals[11]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[11]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/player/Player","getStartingLife","()I","invokevirtual",247);}
case 247:{return rt.Call(f,"forge/game/player/Player","setStartingLife","(I)V","invokevirtual",250);}
case 250:{f.Push(f.Locals[11]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/player/Player","clearCounters","()V","invokevirtual",255);}
case 255:{f.Push(f.Locals[11]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/player/Player","resetSpellCastThisGame","()V","invokevirtual",260);}
case 260:{f.Push(f.Locals[11]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/player/Player","onCleanupPhase","()V","invokevirtual",265);}
case 265:{f.Push(f.Locals[11]);f.Pc=267;continue;}
case 267:{f.Push(JValue.I(0));f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/player/Player","setLandsPlayedMyLastTurn","(I)V","invokevirtual",271);}
case 271:{f.Push(f.Locals[11]);f.Pc=273;continue;}
case 273:{f.Push(JValue.I(0));f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/player/Player","setSpellsCastLastTurn","(I)V","invokevirtual",277);}
case 277:{f.Push(f.Locals[11]);f.Pc=279;continue;}
case 279:{f.Push(JValue.I(0));f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/player/Player","setLifeLostLastTurn","(I)V","invokevirtual",283);}
case 283:{f.Push(f.Locals[11]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/player/Player","resetCommanderStats","()V","invokevirtual",288);}
case 288:{f.Push(f.Locals[11]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/player/Player","resetCompletedDungeons","()V","invokevirtual",293);}
case 293:{f.Push(f.Locals[11]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/player/Player","resetRingTemptedYou","()V","invokevirtual",298);}
case 298:{f.Push(f.Locals[11]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/player/Player","clearRingBearer","()V","invokevirtual",303);}
case 303:{f.Push(f.Locals[11]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/player/Player","clearTheRing","()V","invokevirtual",308);}
case 308:{f.Push(f.Locals[11]);f.Pc=310;continue;}
case 310:{f.Push(JValue.I(0));f.Pc=311;continue;}
case 311:{f.Push(JValue.R(null));f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/player/Player","setBlessing","(ZLjava/lang/String;)V","invokevirtual",315);}
case 315:{f.Push(f.Locals[11]);f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/game/player/Player","clearController","()V","invokevirtual",320);}
case 320:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=323;continue;}
case 323:{f.StackOp("dup");f.Pc=324;continue;}
case 324:{f.Push(f.Locals[11]);f.Pc=326;continue;}
case 326:{f.Push(f.Locals[5]);f.Pc=328;continue;}
case 328:{f.Push(JValue.I(0));f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Ljava/lang/Iterable;Z)Lforge/game/card/CardCollectionView;","invokevirtual",332);}
case 332:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",335);}
case 335:{f.Locals[12]=f.Pop();f.Pc=337;continue;}
case 337:{f.Push(f.Locals[6]);f.Pc=339;continue;}
case 339:{f.Pc=f.Pop().Reference==null?371:342;continue;}
case 342:{f.Push(f.Locals[11]);f.Pc=344;continue;}
case 344:{f.Push(f.Locals[6]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",349);}
case 349:{f.Push(f.Locals[7]);f.Pc=351;continue;}
case 351:{f.Push(f.Locals[11]);f.Pc=353;continue;}
case 353:{f.Push(f.Locals[1]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",357);}
case 357:{f.Push(f.Locals[1]);f.Pc=358;continue;}
case 358:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",361);}
case 361:{f.Locals[13]=f.Pop();f.Pc=363;continue;}
case 363:{f.Push(f.Locals[12]);f.Pc=365;continue;}
case 365:{f.Push(f.Locals[13]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",370);}
case 370:{f.StackOp("pop");f.Pc=371;continue;}
case 371:{f.Push(f.Locals[11]);f.Pc=373;continue;}
case 373:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=376;continue;}
case 376:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",379);}
case 379:{f.Locals[13]=f.Pop();f.Pc=381;continue;}
case 381:{f.Push(f.Locals[13]);f.Pc=383;continue;}
case 383:{f.Push(f.Locals[13]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",388);}
case 388:{return rt.DynamicCall(f,"forge/game/ability/effects/RestartGameEffect:3658:388:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",393);}
case 393:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",396);}
case 396:{return rt.Call(f,"forge/game/zone/PlayerZone","setCards","(Ljava/lang/Iterable;)V","invokevirtual",399);}
case 399:{f.Push(f.Locals[12]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",404);}
case 404:{f.Locals[14]=f.Pop();f.Pc=406;continue;}
case 406:{f.Push(f.Locals[14]);f.Pc=408;continue;}
case 408:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",413);}
case 413:{f.Pc=f.Pop().Int==0?456:416;continue;}
case 416:{f.Push(f.Locals[14]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",423);}
case 423:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=426;continue;}
case 426:{f.Locals[15]=f.Pop();f.Pc=428;continue;}
case 428:{f.Push(f.Locals[15]);f.Pc=430;continue;}
case 430:{f.Push(JValue.I(0));f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/game/card/Card","getIntensity","(Z)I","invokevirtual",434);}
case 434:{f.Pc=f.Pop().Int<=0?443:437;continue;}
case 437:{f.Push(f.Locals[15]);f.Pc=439;continue;}
case 439:{f.Push(JValue.I(0));f.Pc=440;continue;}
case 440:{return rt.Call(f,"forge/game/card/Card","setIntensity","(I)V","invokevirtual",443);}
case 443:{f.Push(f.Locals[9]);f.Pc=445;continue;}
case 445:{f.Push(f.Locals[15]);f.Pc=447;continue;}
case 447:{f.Push(JValue.I(0));f.Pc=448;continue;}
case 448:{f.Push(f.Locals[1]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",452);}
case 452:{f.StackOp("pop");f.Pc=453;continue;}
case 453:{f.Pc=406;continue;}
case 456:{f.Push(f.Locals[11]);f.Pc=458;continue;}
case 458:{f.Push(f.Locals[11]);f.Pc=460;continue;}
case 460:{return rt.Call(f,"forge/game/player/Player","getRegisteredPlayer","()Lforge/game/player/RegisteredPlayer;","invokevirtual",463);}
case 463:{return rt.Call(f,"forge/game/player/Player","initVariantsZones","(Lforge/game/player/RegisteredPlayer;)V","invokevirtual",466);}
case 466:{f.Push(f.Locals[11]);f.Pc=468;continue;}
case 468:{f.Push(JValue.R(null));f.Pc=469;continue;}
case 469:{return rt.Call(f,"forge/game/player/Player","shuffle","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",472);}
case 472:{f.Pc=218;continue;}
case 475:{f.Push(f.Locals[4]);f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",482);}
case 482:{f.Locals[10]=f.Pop();f.Pc=484;continue;}
case 484:{f.Push(f.Locals[10]);f.Pc=486;continue;}
case 486:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",491);}
case 491:{f.Pc=f.Pop().Int==0?588:494;continue;}
case 494:{f.Push(f.Locals[10]);f.Pc=496;continue;}
case 496:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",501);}
case 501:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=504;continue;}
case 504:{f.Locals[11]=f.Pop();f.Pc=506;continue;}
case 506:{f.Push(f.Locals[11]);f.Pc=508;continue;}
case 508:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=511;continue;}
case 511:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",514);}
case 514:{return rt.DynamicCall(f,"forge/game/ability/effects/RestartGameEffect:3658:514:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",519);}
case 519:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",522);}
case 522:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",525);}
case 525:{f.Locals[12]=f.Pop();f.Pc=527;continue;}
case 527:{f.Push(f.Locals[12]);f.Pc=529;continue;}
case 529:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",534);}
case 534:{f.Pc=f.Pop().Int==0?567:537;continue;}
case 537:{f.Push(f.Locals[12]);f.Pc=539;continue;}
case 539:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",544);}
case 544:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=547;continue;}
case 547:{f.Locals[13]=f.Pop();f.Pc=549;continue;}
case 549:{f.Push(f.Locals[9]);f.Pc=551;continue;}
case 551:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=554;continue;}
case 554:{f.Push(f.Locals[13]);f.Pc=556;continue;}
case 556:{f.Push(f.Locals[1]);f.Pc=557;continue;}
case 557:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",560);}
case 560:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",563);}
case 563:{f.StackOp("pop");f.Pc=564;continue;}
case 564:{f.Pc=527;continue;}
case 567:{f.Push(f.Locals[11]);f.Pc=569;continue;}
case 569:{return rt.Call(f,"forge/game/player/Player","getCommanders","()Ljava/util/List;","invokevirtual",572);}
case 572:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",577);}
case 577:{f.Pc=f.Pop().Int!=0?585:580;continue;}
case 580:{f.Push(f.Locals[11]);f.Pc=582;continue;}
case 582:{return rt.Call(f,"forge/game/player/Player","createCommanderEffect","()V","invokevirtual",585);}
case 585:{f.Pc=484;continue;}
case 588:{f.Push(f.Locals[8]);f.Pc=590;continue;}
case 590:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Shuffled","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Shuffled","Lforge/game/trigger/TriggerType;"));f.Pc=593;continue;}
case 593:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearSuppression","(Lforge/game/trigger/TriggerType;)V","invokevirtual",596);}
case 596:{f.Push(f.Locals[8]);f.Pc=598;continue;}
case 598:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"));f.Pc=601;continue;}
case 601:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearSuppression","(Lforge/game/trigger/TriggerType;)V","invokevirtual",604);}
case 604:{f.Push(f.Locals[3]);f.Pc=605;continue;}
case 605:{return rt.Call(f,"forge/game/Game","resetTurnOrder","()V","invokevirtual",608);}
case 608:{f.Push(f.Locals[3]);f.Pc=609;continue;}
case 609:{if(!rt.StaticReady(f,"forge/game/GameStage","RestartedByKarn","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","RestartedByKarn","Lforge/game/GameStage;"));f.Pc=612;continue;}
case 612:{return rt.Call(f,"forge/game/Game","setAge","(Lforge/game/GameStage;)V","invokevirtual",615);}
case 615:{f.Push(f.Locals[3]);f.Pc=616;continue;}
case 616:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",619);}
case 619:{f.Push(f.Locals[2]);f.Pc=620;continue;}
case 620:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPlayerTurn","(Lforge/game/player/Player;)V","invokevirtual",623);}
case 623:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3659(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference!=null?16:12;continue;}
case 12:{f.Push(JValue.R(rt.String("Restart the game.")));f.Pc=15;continue;}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
