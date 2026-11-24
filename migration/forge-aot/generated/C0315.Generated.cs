// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C315{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/HeistEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3438,"forge/game/ability/effects/HeistEffect","<init>","()V",1,1,1,new JHandler[]{},M3438));
c.Add(new JMethod(3439,"forge/game/ability/effects/HeistEffect","movesCardToOrFromLibrary","(Lforge/game/spellability/SpellAbility;)Z",1,2,1,new JHandler[]{},M3439));
c.Add(new JMethod(3440,"forge/game/ability/effects/HeistEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,14,9,new JHandler[]{},M3440));
}

internal static JStep M3438(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3439(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3440(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateBattlefield","()Lforge/game/card/CardCollection;","invokevirtual",12);}
case 12:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",17);}
case 17:{f.StackOp("pop");f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateGraveyard","()Lforge/game/card/CardCollection;","invokevirtual",26);}
case 26:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",31);}
case 31:{f.StackOp("pop");f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",36);}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("Defined")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",48);}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Locals[4]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",62);}
case 62:{f.Locals[5]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/ability/effects/HeistEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",68);}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{f.Locals[6]=f.Pop();f.Pc=77;continue;}
case 77:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=80;continue;}
case 80:{f.StackOp("dup");f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",84);}
case 84:{f.Locals[7]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("Num")));f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("1")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",95);}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",99);}
case 99:{f.Locals[8]=f.Pop();f.Pc=101;continue;}
case 101:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=104;continue;}
case 104:{f.StackOp("dup");f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",108);}
case 108:{f.Locals[9]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(JValue.I(0));f.Pc=111;continue;}
case 111:{f.Locals[10]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[10]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[8]);f.Pc=117;continue;}
case 117:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?280:120;continue;}
case 120:{f.Push(f.Locals[6]);f.Pc=122;continue;}
case 122:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",128);}
case 128:{f.Push(JValue.R(rt.String("Land")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/card/CardLists","getNotType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",133);}
case 133:{f.Push(JValue.I(3));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",137);}
case 137:{f.Locals[11]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[11]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",146);}
case 146:{f.Pc=f.Pop().Int==0?152:149;continue;}
case 149:{f.Pc=274;continue;}
case 152:{f.Push(f.Locals[4]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",157);}
case 157:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=160;continue;}
case 160:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",166);}
case 166:{f.Push(f.Locals[1]);f.Pc=167;continue;}
case 167:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=170;continue;}
case 170:{f.StackOp("dup");f.Pc=171;continue;}
case 171:{f.Push(f.Locals[11]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",176);}
case 176:{f.Push(JValue.R(null));f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",180);}
case 180:{f.Push(JValue.R(rt.String("lblChooseCardHeist")));f.Pc=182;continue;}
case 182:{f.Push(JValue.I(0));f.Pc=183;continue;}
case 183:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",189);}
case 189:{f.Push(JValue.I(0));f.Pc=190;continue;}
case 190:{f.Push(f.Locals[4]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleCardForZoneChange","(Lforge/game/zone/ZoneType;Ljava/util/List;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;Lforge/game/player/DelayedReveal;Ljava/lang/String;ZLforge/game/player/Player;)Lforge/game/card/Card;","invokevirtual",195);}
case 195:{f.Locals[12]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[12]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[1]);f.Pc=200;continue;}
case 200:{f.Push(JValue.I(1));f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/card/Card","canExiledBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",204);}
case 204:{f.Pc=f.Pop().Int!=0?210:207;continue;}
case 207:{f.Pc=274;continue;}
case 210:{f.Push(f.Locals[5]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",215);}
case 215:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=218;continue;}
case 218:{f.Push(f.Locals[12]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[1]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[2]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",225);}
case 225:{f.Locals[13]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[13]);f.Pc=229;continue;}
case 229:{f.Push(JValue.I(1));f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/card/Card","turnFaceDown","(Z)Z","invokevirtual",233);}
case 233:{f.StackOp("pop");f.Pc=234;continue;}
case 234:{f.Push(f.Locals[13]);f.Pc=236;continue;}
case 236:{f.Push(f.Locals[4]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/card/Card","addMayLookFaceDownExile","(Lforge/game/player/Player;)V","invokevirtual",241);}
case 241:{f.Push(f.Locals[13]);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[1]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/ability/effects/HeistEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",247);}
case 247:{f.Push(f.Locals[9]);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[13]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",254);}
case 254:{f.StackOp("pop");f.Pc=255;continue;}
case 255:{f.Push(f.Locals[7]);f.Pc=257;continue;}
case 257:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=260;continue;}
case 260:{f.Push(f.Locals[13]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",265);}
case 265:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",268);}
case 268:{f.Push(f.Locals[13]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",273);}
case 273:{f.StackOp("pop");f.Pc=274;continue;}
case 274:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=277;continue;}
case 277:{f.Pc=113;continue;}
case 280:{f.Push(f.Locals[9]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",285);}
case 285:{f.Pc=f.Pop().Int!=0?353:288;continue;}
case 288:{f.Push(f.Locals[1]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[4]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[3]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",295);}
case 295:{return rt.DynamicCall(f,"forge/game/ability/effects/HeistEffect:3440:295:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",300);}
case 300:{f.Push(f.Locals[3]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",304);}
case 304:{return rt.Call(f,"forge/game/ability/effects/HeistEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;","invokestatic",307);}
case 307:{f.Locals[10]=f.Pop();f.Pc=309;continue;}
case 309:{f.Push(f.Locals[10]);f.Pc=311;continue;}
case 311:{f.Push(f.Locals[9]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",316);}
case 316:{f.Push(JValue.R(rt.String("Mode$ Continuous | MayPlay$ True | MayPlayIgnoreType$ True | EffectZone$ Command | Affected$ Card.IsRemembered | AffectedZone$ Exile | Description$ You may play the heisted card for as long as it remains exiled, and mana of any type can be spent to cast it.")));f.Pc=318;continue;}
case 318:{f.Locals[11]=f.Pop();f.Pc=320;continue;}
case 320:{f.Push(f.Locals[10]);f.Pc=322;continue;}
case 322:{f.Push(f.Locals[11]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/card/Card","addStaticAbility","(Ljava/lang/String;)Lforge/game/staticability/StaticAbility;","invokevirtual",327);}
case 327:{f.StackOp("pop");f.Pc=328;continue;}
case 328:{f.Push(f.Locals[10]);f.Pc=330;continue;}
case 330:{f.Push(JValue.R(rt.String("Exile")));f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/game/ability/effects/HeistEffect","addForgetOnMovedTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",335);}
case 335:{f.Push(f.Locals[10]);f.Pc=337;continue;}
case 337:{f.Push(JValue.R(rt.String("Card.IsRemembered")));f.Pc=339;continue;}
case 339:{return rt.Call(f,"forge/game/ability/effects/HeistEffect","addForgetOnCastTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",342);}
case 342:{f.Push(f.Locals[5]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",347);}
case 347:{f.Push(f.Locals[10]);f.Pc=349;continue;}
case 349:{f.Push(f.Locals[1]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",353);}
case 353:{f.Push(f.Locals[7]);f.Pc=355;continue;}
case 355:{f.Push(f.Locals[5]);f.Pc=357;continue;}
case 357:{f.Push(f.Locals[1]);f.Pc=358;continue;}
case 358:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",361);}
case 361:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
