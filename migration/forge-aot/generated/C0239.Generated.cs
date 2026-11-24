// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C239{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChoosePlayerEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3159,"forge/game/ability/effects/ChoosePlayerEffect","<init>","()V",1,1,1,new JHandler[]{},M3159));
c.Add(new JMethod(3160,"forge/game/ability/effects/ChoosePlayerEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,2,new JHandler[]{},M3160));
c.Add(new JMethod(3161,"forge/game/ability/effects/ChoosePlayerEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,10,new JHandler[]{},M3161));
}

internal static JStep M3159(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3160(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/effects/ChoosePlayerEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",16);}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String(" chooses a player.")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3161(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Choices")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?33:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("Choices")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",30);}
case 30:{f.Pc=37;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/Game","getPlayersInTurnOrder","()Lforge/game/player/PlayerCollection;","invokevirtual",37);}
case 37:{f.Locals[4]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?57:48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Pc=69;continue;}
case 57:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",60);}
case 60:{f.Push(JValue.R(rt.String("lblChoosePlayer")));f.Pc=62;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",69);}
case 69:{f.Locals[5]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("Random")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",77);}
case 77:{f.Locals[6]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("Secretly")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",85);}
case 85:{f.Locals[7]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/ability/effects/ChoosePlayerEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",91);}
case 91:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",94);}
case 94:{f.Locals[8]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[8]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",103);}
case 103:{f.Pc=f.Pop().Int==0?468:106;continue;}
case 106:{f.Push(f.Locals[8]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",113);}
case 113:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=116;continue;}
case 116:{f.Locals[9]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[9]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",123);}
case 123:{f.Pc=f.Pop().Int!=0?129:126;continue;}
case 126:{f.Pc=96;continue;}
case 129:{f.Push(f.Locals[6]);f.Pc=131;continue;}
case 131:{f.Pc=f.Pop().Int==0?161:134;continue;}
case 134:{f.Push(f.Locals[4]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/util/collect/FCollectionView","isEmpty","()Z","invokeinterface",141);}
case 141:{f.Pc=f.Pop().Int==0?148:144;continue;}
case 144:{f.Push(JValue.R(null));f.Pc=145;continue;}
case 145:{f.Pc=156;continue;}
case 148:{f.Push(f.Locals[4]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",153);}
case 153:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=156;continue;}
case 156:{f.Locals[10]=f.Pop();f.Pc=158;continue;}
case 158:{f.Pc=200;continue;}
case 161:{f.Push(f.Locals[4]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/util/collect/FCollectionView","isEmpty","()Z","invokeinterface",168);}
case 168:{f.Pc=f.Pop().Int==0?175:171;continue;}
case 171:{f.Push(JValue.R(null));f.Pc=172;continue;}
case 172:{f.Pc=198;continue;}
case 175:{f.Push(f.Locals[9]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",180);}
case 180:{f.Push(f.Locals[4]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[5]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String("Optional")));f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",191);}
case 191:{f.Push(JValue.R(null));f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",195);}
case 195:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=198;continue;}
case 198:{f.Locals[10]=f.Pop();f.Pc=200;continue;}
case 200:{f.Push(JValue.R(null));f.Pc=201;continue;}
case 201:{f.Push(f.Locals[10]);f.Pc=203;continue;}
case 203:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?415:206;continue;}
case 206:{f.Push(f.Locals[7]);f.Pc=208;continue;}
case 208:{f.Pc=f.Pop().Int==0?220:211;continue;}
case 211:{f.Push(f.Locals[2]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[10]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/card/Card","setSecretChosenPlayer","(Lforge/game/player/Player;)V","invokevirtual",217);}
case 217:{f.Pc=244;continue;}
case 220:{f.Push(f.Locals[1]);f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String("Protect")));f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",226);}
case 226:{f.Pc=f.Pop().Int==0?238:229;continue;}
case 229:{f.Push(f.Locals[2]);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[10]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/card/Card","setProtectingPlayer","(Lforge/game/player/Player;)V","invokevirtual",235);}
case 235:{f.Pc=244;continue;}
case 238:{f.Push(f.Locals[2]);f.Pc=239;continue;}
case 239:{f.Push(f.Locals[10]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/card/Card","setChosenPlayer","(Lforge/game/player/Player;)V","invokevirtual",244);}
case 244:{f.Push(f.Locals[1]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String("ForgetOtherRemembered")));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",250);}
case 250:{f.Pc=f.Pop().Int==0?257:253;continue;}
case 253:{f.Push(f.Locals[2]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",257);}
case 257:{f.Push(f.Locals[1]);f.Pc=258;continue;}
case 258:{f.Push(JValue.R(rt.String("RememberChosen")));f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",263);}
case 263:{f.Pc=f.Pop().Int==0?272:266;continue;}
case 266:{f.Push(f.Locals[2]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[10]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",272);}
case 272:{f.Push(f.Locals[7]);f.Pc=274;continue;}
case 274:{f.Pc=f.Pop().Int!=0?362:277;continue;}
case 277:{f.Push(f.Locals[1]);f.Pc=278;continue;}
case 278:{f.Push(JValue.R(rt.String("DontNotify")));f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",283);}
case 283:{f.Pc=f.Pop().Int==0?327:286;continue;}
case 286:{f.Push(f.Locals[3]);f.Pc=287;continue;}
case 287:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=290;continue;}
case 290:{f.StackOp("dup");f.Pc=291;continue;}
case 291:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","INFORMATION","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","INFORMATION","Lforge/game/GameLogEntryType;"));f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",297);}
case 297:{f.Push(JValue.R(rt.String("lblPlayerPickedChosen")));f.Pc=299;continue;}
case 299:{f.Push(JValue.I(2));f.Pc=300;continue;}
case 300:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=303;continue;}
case 303:{f.StackOp("dup");f.Pc=304;continue;}
case 304:{f.Push(JValue.I(0));f.Pc=305;continue;}
case 305:{f.Push(f.Locals[1]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",309);}
case 309:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=310;continue;}
case 310:{f.StackOp("dup");f.Pc=311;continue;}
case 311:{f.Push(JValue.I(1));f.Pc=312;continue;}
case 312:{f.Push(f.Locals[10]);f.Pc=314;continue;}
case 314:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",318);}
case 318:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",321);}
case 321:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",324);}
case 324:{f.Pc=362;continue;}
case 327:{f.Push(f.Locals[3]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",331);}
case 331:{f.Push(f.Locals[1]);f.Pc=332;continue;}
case 332:{f.Push(f.Locals[9]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",337);}
case 337:{f.Push(JValue.R(rt.String("lblPlayerPickedChosen")));f.Pc=339;continue;}
case 339:{f.Push(JValue.I(2));f.Pc=340;continue;}
case 340:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=343;continue;}
case 343:{f.StackOp("dup");f.Pc=344;continue;}
case 344:{f.Push(JValue.I(0));f.Pc=345;continue;}
case 345:{f.Push(f.Locals[1]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",349);}
case 349:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=350;continue;}
case 350:{f.StackOp("dup");f.Pc=351;continue;}
case 351:{f.Push(JValue.I(1));f.Pc=352;continue;}
case 352:{f.Push(f.Locals[10]);f.Pc=354;continue;}
case 354:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=355;continue;}
case 355:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",358);}
case 358:{f.Push(JValue.R(null));f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",362);}
case 362:{f.Push(f.Locals[1]);f.Pc=363;continue;}
case 363:{f.Push(JValue.R(rt.String("ChooseSubAbility")));f.Pc=365;continue;}
case 365:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",368);}
case 368:{f.Locals[11]=f.Pop();f.Pc=370;continue;}
case 370:{f.Push(f.Locals[11]);f.Pc=372;continue;}
case 372:{f.Pc=f.Pop().Reference==null?412:375;continue;}
case 375:{f.Push(f.Locals[11]);f.Pc=377;continue;}
case 377:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",380);}
case 380:{f.Push(f.Locals[1]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",384);}
case 384:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",387);}
case 387:{f.Pc=f.Pop().Int!=0?407:390;continue;}
case 390:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=393;continue;}
case 393:{f.Push(JValue.R(rt.String("Warning: ChooseSubAbility had the wrong host set (potentially after cloning the root SA), attempting to correct...")));f.Pc=395;continue;}
case 395:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",398);}
case 398:{f.Push(f.Locals[11]);f.Pc=400;continue;}
case 400:{f.Push(f.Locals[1]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",404);}
case 404:{return rt.Call(f,"forge/game/spellability/SpellAbility","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",407);}
case 407:{f.Push(f.Locals[11]);f.Pc=409;continue;}
case 409:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",412);}
case 412:{f.Pc=465;continue;}
case 415:{f.Push(f.Locals[1]);f.Pc=416;continue;}
case 416:{f.Push(JValue.R(rt.String("CantChooseSubAbility")));f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",421);}
case 421:{f.Locals[11]=f.Pop();f.Pc=423;continue;}
case 423:{f.Push(f.Locals[11]);f.Pc=425;continue;}
case 425:{f.Pc=f.Pop().Reference==null?465:428;continue;}
case 428:{f.Push(f.Locals[11]);f.Pc=430;continue;}
case 430:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",433);}
case 433:{f.Push(f.Locals[1]);f.Pc=434;continue;}
case 434:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",437);}
case 437:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",440);}
case 440:{f.Pc=f.Pop().Int!=0?460:443;continue;}
case 443:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=446;continue;}
case 446:{f.Push(JValue.R(rt.String("Warning: CantChooseSubAbility had the wrong host set (potentially after cloning the root SA), attempting to correct...")));f.Pc=448;continue;}
case 448:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",451);}
case 451:{f.Push(f.Locals[11]);f.Pc=453;continue;}
case 453:{f.Push(f.Locals[1]);f.Pc=454;continue;}
case 454:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",457);}
case 457:{return rt.Call(f,"forge/game/spellability/SpellAbility","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",460);}
case 460:{f.Push(f.Locals[11]);f.Pc=462;continue;}
case 462:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",465);}
case 465:{f.Pc=96;continue;}
case 468:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
