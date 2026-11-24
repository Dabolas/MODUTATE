// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C187{
internal static JClass Build(){var c=new JClass("forge/game/ability/SpellAbilityEffect","java/lang/Object",new string[]{},1057);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("IF_CONDITION_SENTENCE","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("EMPTY_SPELL_DESCRIPTION","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("REMOVE_REMINDER_TEXT","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("CONDITION_CONTINUATION","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("STACK_CARD_PRELUDE","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("CONTINUING_VERB","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("TIDY_COMMA_RUN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("TIDY_OPTIONAL_PLURAL","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("TIDY_DOUBLE_PERIOD","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("TIDY_SENTENCE_SPACE","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("TIDY_NEWLINES","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("TIDY_DOUBLE_SPACES","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("TIDY_PUNCTUATION_SPACE","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("TIDY_DUPLICATE_CONJUNCTION","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JMethod(2902,"forge/game/ability/SpellAbilityEffect","<init>","()V",1,1,1,new JHandler[]{},M2902));
c.Add(new JMethod(2903,"forge/game/ability/SpellAbilityEffect","isAmountDeferred","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z",12,3,2,new JHandler[]{},M2903));
c.Add(new JMethod(2904,"forge/game/ability/SpellAbilityEffect","amountTextFromCard","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/lang/String;",12,4,3,new JHandler[]{},M2904));
c.Add(new JMethod(2905,"forge/game/ability/SpellAbilityEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,2,0,new JHandler[]{},M2905));
c.Add(new JMethod(2906,"forge/game/ability/SpellAbilityEffect","movesCardToOrFromLibrary","(Lforge/game/spellability/SpellAbility;)Z",1,2,1,new JHandler[]{},M2906));
c.Add(new JMethod(2907,"forge/game/ability/SpellAbilityEffect","zoneParamIsLibrary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z",12,2,2,new JHandler[]{},M2907));
c.Add(new JMethod(2908,"forge/game/ability/SpellAbilityEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,1,new JHandler[]{},M2908));
c.Add(new JMethod(2909,"forge/game/ability/SpellAbilityEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V",1,2,3,new JHandler[]{},M2909));
c.Add(new JMethod(2910,"forge/game/ability/SpellAbilityEffect","getStackDescriptionWithSubs","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",17,15,5,new JHandler[]{},M2910));
c.Add(new JMethod(2911,"forge/game/ability/SpellAbilityEffect","endsWithComma","(Ljava/lang/StringBuilder;)Z",10,3,2,new JHandler[]{},M2911));
c.Add(new JMethod(2912,"forge/game/ability/SpellAbilityEffect","endsWithSentence","(Ljava/lang/StringBuilder;)Z",10,3,2,new JHandler[]{},M2912));
c.Add(new JMethod(2913,"forge/game/ability/SpellAbilityEffect","conditionPrefix","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/lang/String;",10,5,4,new JHandler[]{},M2913));
c.Add(new JMethod(2914,"forge/game/ability/SpellAbilityEffect","tidyDescription","(Ljava/lang/String;Z)Ljava/lang/String;",9,4,5,new JHandler[]{},M2914));
c.Add(new JMethod(2915,"forge/game/ability/SpellAbilityEffect","extractAmount","(Lforge/game/spellability/SpellAbility;)I",20,2,4,new JHandler[]{},M2915));
c.Add(new JMethod(2916,"forge/game/ability/SpellAbilityEffect","tokenizeString","(Lforge/game/spellability/SpellAbility;Ljava/lang/StringBuilder;Ljava/lang/String;)V",9,8,5,new JHandler[]{},M2916));
c.Add(new JMethod(2917,"forge/game/ability/SpellAbilityEffect","playersOrDescribed","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;",12,4,3,new JHandler[]{},M2917));
c.Add(new JMethod(2918,"forge/game/ability/SpellAbilityEffect","joinNamed","(Ljava/lang/Iterable;)Ljava/lang/String;",12,4,2,new JHandler[]{},M2918));
c.Add(new JMethod(2919,"forge/game/ability/SpellAbilityEffect","appendNamed","(Ljava/lang/StringBuilder;Ljava/lang/Object;)V",10,3,2,new JHandler[]{},M2919));
c.Add(new JMethod(2920,"forge/game/ability/SpellAbilityEffect","undefinedObjectText","(Ljava/lang/String;)Ljava/lang/String;",10,3,3,new JHandler[]{},M2920));
c.Add(new JMethod(2921,"forge/game/ability/SpellAbilityEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;",28,1,3,new JHandler[]{},M2921));
c.Add(new JMethod(2922,"forge/game/ability/SpellAbilityEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/card/CardCollection;",28,2,3,new JHandler[]{},M2922));
c.Add(new JMethod(2923,"forge/game/ability/SpellAbilityEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;",28,1,3,new JHandler[]{},M2923));
c.Add(new JMethod(2924,"forge/game/ability/SpellAbilityEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/card/CardCollection;",28,2,3,new JHandler[]{},M2924));
c.Add(new JMethod(2925,"forge/game/ability/SpellAbilityEffect","getTargetCardsWithDuplicates","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;",12,4,4,new JHandler[]{},M2925));
c.Add(new JMethod(2926,"forge/game/ability/SpellAbilityEffect","getCards","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;",10,3,4,new JHandler[]{},M2926));
c.Add(new JMethod(2927,"forge/game/ability/SpellAbilityEffect","getCards","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/List;)Lforge/game/card/CardCollection;",10,12,3,new JHandler[]{},M2927));
c.Add(new JMethod(2928,"forge/game/ability/SpellAbilityEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;",28,1,3,new JHandler[]{},M2928));
c.Add(new JMethod(2929,"forge/game/ability/SpellAbilityEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;",28,2,3,new JHandler[]{},M2929));
c.Add(new JMethod(2930,"forge/game/ability/SpellAbilityEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;",28,1,3,new JHandler[]{},M2930));
c.Add(new JMethod(2931,"forge/game/ability/SpellAbilityEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;",28,2,3,new JHandler[]{},M2931));
c.Add(new JMethod(2932,"forge/game/ability/SpellAbilityEffect","getTargetPlayersOnePerTeam","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;",28,4,3,new JHandler[]{},M2932));
c.Add(new JMethod(2933,"forge/game/ability/SpellAbilityEffect","getTargetPlayersWithDuplicates","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;",12,4,4,new JHandler[]{},M2933));
c.Add(new JMethod(2934,"forge/game/ability/SpellAbilityEffect","getPlayers","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;",10,3,4,new JHandler[]{},M2934));
c.Add(new JMethod(2935,"forge/game/ability/SpellAbilityEffect","getPlayers","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/List;)Lforge/game/player/PlayerCollection;",10,12,3,new JHandler[]{},M2935));
c.Add(new JMethod(2936,"forge/game/ability/SpellAbilityEffect","sortAPNAP","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)V",12,5,3,new JHandler[]{},M2936));
c.Add(new JMethod(2937,"forge/game/ability/SpellAbilityEffect","getTargetSpells","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",28,1,3,new JHandler[]{},M2937));
c.Add(new JMethod(2938,"forge/game/ability/SpellAbilityEffect","getTargetSpells","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/util/List;",28,2,3,new JHandler[]{},M2938));
c.Add(new JMethod(2939,"forge/game/ability/SpellAbilityEffect","getDefinedSpellsOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/util/List;",28,2,3,new JHandler[]{},M2939));
c.Add(new JMethod(2940,"forge/game/ability/SpellAbilityEffect","getSpells","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;",10,4,3,new JHandler[]{},M2940));
c.Add(new JMethod(2941,"forge/game/ability/SpellAbilityEffect","getTargetEntities","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",28,1,3,new JHandler[]{},M2941));
c.Add(new JMethod(2942,"forge/game/ability/SpellAbilityEffect","getTargetEntities","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/util/List;",28,2,3,new JHandler[]{},M2942));
c.Add(new JMethod(2943,"forge/game/ability/SpellAbilityEffect","getDefinedEntitiesOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/util/List;",28,2,3,new JHandler[]{},M2943));
c.Add(new JMethod(2944,"forge/game/ability/SpellAbilityEffect","getEntities","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;",10,5,3,new JHandler[]{},M2944));
c.Add(new JMethod(2945,"forge/game/ability/SpellAbilityEffect","getTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",28,1,3,new JHandler[]{},M2945));
c.Add(new JMethod(2946,"forge/game/ability/SpellAbilityEffect","getTargets","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/util/List;",28,2,3,new JHandler[]{},M2946));
c.Add(new JMethod(2947,"forge/game/ability/SpellAbilityEffect","getDefinedOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/util/List;",28,2,3,new JHandler[]{},M2947));
c.Add(new JMethod(2948,"forge/game/ability/SpellAbilityEffect","getTargetables","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;",10,4,3,new JHandler[]{},M2948));
c.Add(new JMethod(2949,"forge/game/ability/SpellAbilityEffect","getCardsfromTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",28,4,2,new JHandler[]{},M2949));
c.Add(new JMethod(2950,"forge/game/ability/SpellAbilityEffect","registerDelayedTrigger","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/Iterable;)V",12,14,6,new JHandler[]{},M2950));
c.Add(new JMethod(2951,"forge/game/ability/SpellAbilityEffect","addSelfTrigger","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/card/Card;)V",12,8,6,new JHandler[]{},M2951));
}

private static void Add1(JClass c){
c.Add(new JMethod(2952,"forge/game/ability/SpellAbilityEffect","getExileSpellAbility","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;",12,2,2,new JHandler[]{},M2952));
c.Add(new JMethod(2953,"forge/game/ability/SpellAbilityEffect","getForgetSpellAbility","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;",12,5,2,new JHandler[]{},M2953));
c.Add(new JMethod(2954,"forge/game/ability/SpellAbilityEffect","addForgetOnMovedTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V",9,7,3,new JHandler[]{},M2954));
c.Add(new JMethod(2955,"forge/game/ability/SpellAbilityEffect","addForgetOnCastTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V",12,4,3,new JHandler[]{},M2955));
c.Add(new JMethod(2956,"forge/game/ability/SpellAbilityEffect","addExileOnMovedTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V",12,4,3,new JHandler[]{},M2956));
c.Add(new JMethod(2957,"forge/game/ability/SpellAbilityEffect","addExileOnCounteredTrigger","(Lforge/game/card/Card;)V",12,3,3,new JHandler[]{},M2957));
c.Add(new JMethod(2958,"forge/game/ability/SpellAbilityEffect","addForgetOnPhasedInTrigger","(Lforge/game/card/Card;)V",12,3,3,new JHandler[]{},M2958));
c.Add(new JMethod(2959,"forge/game/ability/SpellAbilityEffect","addExileCounterTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V",12,4,3,new JHandler[]{},M2959));
c.Add(new JMethod(2960,"forge/game/ability/SpellAbilityEffect","addForgetCounterTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V",12,7,3,new JHandler[]{},M2960));
c.Add(new JMethod(2961,"forge/game/ability/SpellAbilityEffect","addExileOnLostTrigger","(Lforge/game/card/Card;)V",12,3,3,new JHandler[]{},M2961));
c.Add(new JMethod(2962,"forge/game/ability/SpellAbilityEffect","addLeaveBattlefieldReplacement","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/String;)V",12,6,4,new JHandler[]{},M2962));
c.Add(new JMethod(2963,"forge/game/ability/SpellAbilityEffect","addLeaveBattlefieldReplacement","(Lforge/game/card/Card;Ljava/lang/String;)V",12,5,3,new JHandler[]{},M2963));
c.Add(new JMethod(2964,"forge/game/ability/SpellAbilityEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;",9,4,7,new JHandler[]{},M2964));
c.Add(new JMethod(2965,"forge/game/ability/SpellAbilityEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;J)Lforge/game/card/Card;",9,9,4,new JHandler[]{},M2965));
c.Add(new JMethod(2966,"forge/game/ability/SpellAbilityEffect","replaceDying","(Lforge/game/spellability/SpellAbility;)V",12,12,4,new JHandler[]{},M2966));
c.Add(new JMethod(2967,"forge/game/ability/SpellAbilityEffect","addToCombat","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/String;)Z",12,12,9,new JHandler[]{},M2967));
c.Add(new JMethod(2968,"forge/game/ability/SpellAbilityEffect","changeZoneUntilCommand","(Lforge/game/card/CardZoneTable;Lforge/game/spellability/SpellAbility;)V",12,7,8,new JHandler[]{},M2968));
c.Add(new JMethod(2969,"forge/game/ability/SpellAbilityEffect","discard","(Lforge/game/spellability/SpellAbility;ZLjava/util/Map;Ljava/util/Map;)V",12,12,5,new JHandler[]{},M2969));
c.Add(new JMethod(2970,"forge/game/ability/SpellAbilityEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;)V",12,2,3,new JHandler[]{},M2970));
c.Add(new JMethod(2971,"forge/game/ability/SpellAbilityEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;Lforge/game/player/Player;)V",12,3,4,new JHandler[]{},M2971));
c.Add(new JMethod(2972,"forge/game/ability/SpellAbilityEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;Ljava/lang/String;Lforge/game/player/Player;)V",12,7,3,new JHandler[]{},M2972));
c.Add(new JMethod(2973,"forge/game/ability/SpellAbilityEffect","checkValidDuration","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z",12,4,3,new JHandler[]{},M2973));
c.Add(new JMethod(2974,"forge/game/ability/SpellAbilityEffect","getNewChooser","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/player/Player;",9,4,6,new JHandler[]{},M2974));
c.Add(new JMethod(2975,"forge/game/ability/SpellAbilityEffect","handleExiledWith","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;)V",9,4,2,new JHandler[]{},M2975));
c.Add(new JMethod(2976,"forge/game/ability/SpellAbilityEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V",9,2,3,new JHandler[]{},M2976));
c.Add(new JMethod(2977,"forge/game/ability/SpellAbilityEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;)V",9,4,2,new JHandler[]{},M2977));
c.Add(new JMethod(2978,"forge/game/ability/SpellAbilityEffect","$deserializeLambda$","(Ljava/lang/invoke/SerializedLambda;)Ljava/lang/Object;",4106,3,3,new JHandler[]{},M2978));
c.Add(new JMethod(2979,"forge/game/ability/SpellAbilityEffect","lambda$addUntilCommand$9c2e65b8$1","(Lforge/game/Game;Lforge/GameCommand;)V",4106,2,2,new JHandler[]{},M2979));
c.Add(new JMethod(2980,"forge/game/ability/SpellAbilityEffect","lambda$replaceDying$f894d637$1","(Lforge/game/Game;Lforge/game/card/Card;)V",4106,2,2,new JHandler[]{},M2980));
c.Add(new JMethod(2981,"forge/game/ability/SpellAbilityEffect","<clinit>","()V",8,0,2,new JHandler[]{},M2981));
}

internal static JStep M2902(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2903(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?11:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",8);}
case 8:{f.Pc=f.Pop().Int==0?13:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilitySub")?1:0));f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Int==0?22:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Locals[2]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("Remembered")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int!=0?46:37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("Imprinted")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int==0?50:46;continue;}
case 46:{f.Push(JValue.I(1));f.Pc=47;continue;}
case 47:{f.Pc=51;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2904(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?21:19;continue;}
case 19:{f.Push(JValue.R(null));f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",31);}
case 31:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Locals[2]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",39);}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",43);}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?59:51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",56);}
case 56:{f.Pc=60;continue;}
case 59:{f.Push(JValue.R(null));f.Pc=60;continue;}
case 60:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2905(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2906(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2907(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int!=0?10:8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",18);}
case 18:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",26);}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2908(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2909(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Forecast")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?54:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("ActivationZone")));f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("Hand")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",17);}
case 17:{f.StackOp("pop");f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("ActivationLimit")));f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("1")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("ActivationPhases")));f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("Upkeep")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("PlayerTurn")));f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("True")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.StackOp("pop");f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("PrecostDesc")));f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("Forecast \u2014 ")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBoast","()Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?88:61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.String("PresentDefined")));f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("Self")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("IsPresent")));f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("Card.attackedThisTurn")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("PrecostDesc")));f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("Boast \u2014 ")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",87);}
case 87:{f.StackOp("pop");f.Pc=88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/spellability/SpellAbility","isExhaust","()Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int==0?104:95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("PrecostDesc")));f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("Exhaust \u2014 ")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",103);}
case 103:{f.StackOp("pop");f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/spellability/SpellAbility","isPowerUp","()Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int==0?120:111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("PrecostDesc")));f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("Power-Up \u2014 ")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",119);}
case 119:{f.StackOp("pop");f.Pc=120;continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("Named")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int==0?139:129;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.String("Named")));f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",136);}
case 136:{return rt.Call(f,"forge/game/spellability/SpellAbility","setName","(Ljava/lang/String;)V","invokevirtual",139);}
case 139:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2910(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",12);}
case 12:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","PermanentCreature","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","PermanentCreature","Lforge/game/ability/ApiType;"));f.Pc=15;continue;}
case 15:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?116:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",22);}
case 22:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","PermanentNoncreature","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","PermanentNoncreature","Lforge/game/ability/ApiType;"));f.Pc=25;continue;}
case 25:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?116:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilitySub")?1:0));f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Int!=0?109:35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",40);}
case 40:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",43);}
case 43:{f.Push(JValue.R(rt.String(" -")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",53);}
case 53:{return rt.Call(f,"forge/game/card/Card","hasPromisedGift","()Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?109:59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("GiftAbility")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasAdditionalAbility","(Ljava/lang/String;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?109:68;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String(" Gift ")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",74);}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("GiftAbility")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",80);}
case 80:{f.Push(JValue.R(rt.String("GiftDescription")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",85);}
case 85:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",88);}
case 88:{f.Push(JValue.R(rt.String(" to ")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",93);}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",97);}
case 97:{return rt.Call(f,"forge/game/card/Card","getPromisedGift","()Lforge/game/player/Player;","invokevirtual",100);}
case 100:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",103);}
case 103:{f.Push(JValue.R(rt.String(". ")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",108);}
case 108:{f.StackOp("pop");f.Pc=109;continue;}
case 109:{f.Push(f.Locals[3]);f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String(" ")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",115);}
case 115:{f.StackOp("pop");f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{f.Push(JValue.R(rt.String("StackDescription")));f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",124);}
case 124:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=127;continue;}
case 127:{f.Locals[4]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[4]);f.Pc=131;continue;}
case 131:{f.Pc=f.Pop().Reference==null?462:134;continue;}
case 134:{f.Push(JValue.R(null));f.Pc=135;continue;}
case 135:{f.Locals[5]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[4]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("REP")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Int==0?164:147;continue;}
case 147:{f.Push(f.Locals[4]);f.Pc=149;continue;}
case 149:{f.Push(JValue.I(4));f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",153);}
case 153:{f.Push(JValue.R(rt.String(" & ")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",158);}
case 158:{f.Locals[5]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=162;continue;}
case 162:{f.Locals[4]=f.Pop();f.Pc=164;continue;}
case 164:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=166;continue;}
case 166:{f.Push(f.Locals[4]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",171);}
case 171:{f.Pc=f.Pop().Int==0?441:174;continue;}
case 174:{f.Push(f.Locals[1]);f.Pc=175;continue;}
case 175:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",182);}
case 182:{f.Pc=f.Pop().Int==0?393:185;continue;}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",193);}
case 193:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=196;continue;}
case 196:{f.Locals[6]=f.Pop();f.Pc=198;continue;}
case 198:{f.Push(f.Locals[6]);f.Pc=200;continue;}
case 200:{f.Push(JValue.R(rt.String(",,,,,,")));f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",205);}
case 205:{f.Pc=f.Pop().Int==0?219:208;continue;}
case 208:{f.Push(f.Locals[6]);f.Pc=210;continue;}
case 210:{f.Push(JValue.R(rt.String(",,,,,,")));f.Pc=212;continue;}
case 212:{f.Push(JValue.R(rt.String(" ")));f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",217);}
case 217:{f.Locals[6]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[6]);f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String(",,,")));f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",226);}
case 226:{f.Pc=f.Pop().Int==0?240:229;continue;}
case 229:{f.Push(f.Locals[6]);f.Pc=231;continue;}
case 231:{f.Push(JValue.R(rt.String(",,,")));f.Pc=233;continue;}
case 233:{f.Push(JValue.R(rt.String(" ")));f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",238);}
case 238:{f.Locals[6]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(f.Locals[6]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[2]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",246);}
case 246:{return rt.Call(f,"forge/util/CardTranslation","translateSingleDescriptionText","(Ljava/lang/String;Lforge/util/ITranslatable;)Ljava/lang/String;","invokestatic",249);}
case 249:{f.Locals[7]=f.Pop();f.Pc=251;continue;}
case 251:{f.Push(f.Locals[7]);f.Pc=253;continue;}
case 253:{f.Push(JValue.R(rt.String(" (")));f.Pc=255;continue;}
case 255:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",258);}
case 258:{f.Locals[8]=f.Pop();f.Pc=260;continue;}
case 260:{f.Push(f.Locals[7]);f.Pc=262;continue;}
case 262:{f.Push(JValue.R(rt.String(")")));f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",267);}
case 267:{f.Locals[9]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(f.Locals[8]);f.Pc=271;continue;}
case 271:{f.Pc=f.Pop().Int<=0?301:274;continue;}
case 274:{f.Push(f.Locals[9]);f.Pc=276;continue;}
case 276:{f.Push(f.Locals[8]);f.Pc=278;continue;}
case 278:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?301:281;continue;}
case 281:{f.Push(f.Locals[7]);f.Pc=283;continue;}
case 283:{f.Push(f.Locals[7]);f.Pc=285;continue;}
case 285:{f.Push(f.Locals[8]);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[9]);f.Pc=289;continue;}
case 289:{f.Push(JValue.I(1));f.Pc=290;continue;}
case 290:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",294);}
case 294:{f.Push(JValue.R(rt.String("")));f.Pc=296;continue;}
case 296:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",299);}
case 299:{f.Locals[7]=f.Pop();f.Pc=301;continue;}
case 301:{f.Push(f.Locals[5]);f.Pc=303;continue;}
case 303:{f.Pc=f.Pop().Reference==null?386:306;continue;}
case 306:{f.Push(f.Locals[5]);f.Pc=308;continue;}
case 308:{f.Locals[10]=f.Pop();f.Pc=310;continue;}
case 310:{f.Push(f.Locals[10]);f.Pc=312;continue;}
case 312:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=313;continue;}
case 313:{f.Locals[11]=f.Pop();f.Pc=315;continue;}
case 315:{f.Push(JValue.I(0));f.Pc=316;continue;}
case 316:{f.Locals[12]=f.Pop();f.Pc=318;continue;}
case 318:{f.Push(f.Locals[12]);f.Pc=320;continue;}
case 320:{f.Push(f.Locals[11]);f.Pc=322;continue;}
case 322:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?376:325;continue;}
case 325:{f.Push(f.Locals[10]);f.Pc=327;continue;}
case 327:{f.Push(f.Locals[12]);f.Pc=329;continue;}
case 329:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=330;continue;}
case 330:{f.Locals[13]=f.Pop();f.Pc=332;continue;}
case 332:{f.Push(f.Locals[13]);f.Pc=334;continue;}
case 334:{f.Push(JValue.R(rt.String("_")));f.Pc=337;continue;}
case 337:{f.Push(JValue.I(2));f.Pc=338;continue;}
case 338:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",341);}
case 341:{f.Locals[14]=f.Pop();f.Pc=343;continue;}
case 343:{f.Push(f.Locals[7]);f.Pc=345;continue;}
case 345:{f.Push(f.Locals[14]);f.Pc=347;continue;}
case 347:{f.Push(JValue.I(0));f.Pc=348;continue;}
case 348:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=349;continue;}
case 349:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",352);}
case 352:{f.Pc=f.Pop().Int==0?370:355;continue;}
case 355:{f.Push(f.Locals[7]);f.Pc=357;continue;}
case 357:{f.Push(f.Locals[14]);f.Pc=359;continue;}
case 359:{f.Push(JValue.I(0));f.Pc=360;continue;}
case 360:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=361;continue;}
case 361:{f.Push(f.Locals[14]);f.Pc=363;continue;}
case 363:{f.Push(JValue.I(1));f.Pc=364;continue;}
case 364:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=365;continue;}
case 365:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",368);}
case 368:{f.Locals[7]=f.Pop();f.Pc=370;continue;}
case 370:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=373;continue;}
case 373:{f.Pc=318;continue;}
case 376:{f.Push(f.Locals[2]);f.Pc=377;continue;}
case 377:{f.Push(f.Locals[3]);f.Pc=378;continue;}
case 378:{f.Push(f.Locals[7]);f.Pc=380;continue;}
case 380:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","tokenizeString","(Lforge/game/spellability/SpellAbility;Ljava/lang/StringBuilder;Ljava/lang/String;)V","invokestatic",383);}
case 383:{f.Pc=393;continue;}
case 386:{f.Push(f.Locals[3]);f.Pc=387;continue;}
case 387:{f.Push(f.Locals[7]);f.Pc=389;continue;}
case 389:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",392);}
case 392:{f.StackOp("pop");f.Pc=393;continue;}
case 393:{f.Push(f.Locals[2]);f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",397);}
case 397:{f.Pc=f.Pop().Reference==null?459:400;continue;}
case 400:{f.Push(f.Locals[2]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",404);}
case 404:{return rt.Call(f,"forge/game/spellability/TargetChoices","isEmpty","()Z","invokevirtual",407);}
case 407:{f.Pc=f.Pop().Int!=0?459:410;continue;}
case 410:{f.Push(f.Locals[5]);f.Pc=412;continue;}
case 412:{f.Pc=f.Pop().Reference!=null?459:415;continue;}
case 415:{f.Push(f.Locals[3]);f.Pc=416;continue;}
case 416:{f.Push(JValue.R(rt.String(" (Targeting: ")));f.Pc=419;continue;}
case 419:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",422);}
case 422:{f.Push(f.Locals[2]);f.Pc=423;continue;}
case 423:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",426);}
case 426:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","joinNamed","(Ljava/lang/Iterable;)Ljava/lang/String;","invokestatic",429);}
case 429:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",432);}
case 432:{f.Push(JValue.R(rt.String(")")));f.Pc=434;continue;}
case 434:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",437);}
case 437:{f.StackOp("pop");f.Pc=438;continue;}
case 438:{f.Pc=459;continue;}
case 441:{f.Push(JValue.R(rt.String("None")));f.Pc=444;continue;}
case 444:{f.Push(f.Locals[4]);f.Pc=446;continue;}
case 446:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",449);}
case 449:{f.Pc=f.Pop().Int!=0?459:452;continue;}
case 452:{f.Push(f.Locals[2]);f.Pc=453;continue;}
case 453:{f.Push(f.Locals[3]);f.Pc=454;continue;}
case 454:{f.Push(f.Locals[4]);f.Pc=456;continue;}
case 456:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","tokenizeString","(Lforge/game/spellability/SpellAbility;Ljava/lang/StringBuilder;Ljava/lang/String;)V","invokestatic",459);}
case 459:{f.Pc=665;continue;}
case 462:{f.Push(f.Locals[2]);f.Pc=463;continue;}
case 463:{f.Push(JValue.R(rt.String("ConditionDescription")));f.Pc=466;continue;}
case 466:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",469);}
case 469:{f.Locals[5]=f.Pop();f.Pc=471;continue;}
case 471:{f.Push(f.Locals[5]);f.Pc=473;continue;}
case 473:{f.Pc=f.Pop().Reference==null?510:476;continue;}
case 476:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","IF_CONDITION_SENTENCE","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/SpellAbilityEffect","IF_CONDITION_SENTENCE","Ljava/util/regex/Pattern;"));f.Pc=479;continue;}
case 479:{f.Push(f.Locals[5]);f.Pc=481;continue;}
case 481:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",484);}
case 484:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",487);}
case 487:{f.Pc=f.Pop().Int==0?510:490;continue;}
case 490:{f.Push(f.Locals[5]);f.Pc=492;continue;}
case 492:{f.Push(JValue.I(0));f.Pc=493;continue;}
case 493:{f.Push(f.Locals[5]);f.Pc=495;continue;}
case 495:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",498);}
case 498:{f.Push(JValue.I(1));f.Pc=499;continue;}
case 499:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=500;continue;}
case 500:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",503);}
case 503:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2910:503:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",508);}
case 508:{f.Locals[5]=f.Pop();f.Pc=510;continue;}
case 510:{f.Push(f.Locals[2]);f.Pc=511;continue;}
case 511:{f.Push(JValue.R(rt.String("AfterDescription")));f.Pc=514;continue;}
case 514:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",517);}
case 517:{f.Locals[6]=f.Pop();f.Pc=519;continue;}
case 519:{f.Push(f.Locals[0]);f.Pc=520;continue;}
case 520:{f.Push(f.Locals[2]);f.Pc=521;continue;}
case 521:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",524);}
case 524:{f.Locals[7]=f.Pop();f.Pc=526;continue;}
case 526:{f.Push(f.Locals[7]);f.Pc=528;continue;}
case 528:{f.Pc=f.Pop().Reference==null?539:531;continue;}
case 531:{f.Push(f.Locals[7]);f.Pc=533;continue;}
case 533:{return rt.Call(f,"java/lang/String","isBlank","()Z","invokevirtual",536);}
case 536:{f.Pc=f.Pop().Int==0?585:539;continue;}
case 539:{f.Push(f.Locals[2]);f.Pc=540;continue;}
case 540:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=542;continue;}
case 542:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",545);}
case 545:{f.Pc=f.Pop().Int==0?585:548;continue;}
case 548:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","EMPTY_SPELL_DESCRIPTION","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/SpellAbilityEffect","EMPTY_SPELL_DESCRIPTION","Ljava/util/regex/Pattern;"));f.Pc=551;continue;}
case 551:{f.Push(f.Locals[2]);f.Pc=552;continue;}
case 552:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=554;continue;}
case 554:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",557);}
case 557:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",560);}
case 560:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",563);}
case 563:{f.Pc=f.Pop().Int!=0?585:566;continue;}
case 566:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","REMOVE_REMINDER_TEXT","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/SpellAbilityEffect","REMOVE_REMINDER_TEXT","Ljava/util/regex/Pattern;"));f.Pc=569;continue;}
case 569:{f.Push(f.Locals[2]);f.Pc=570;continue;}
case 570:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=572;continue;}
case 572:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",575);}
case 575:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",578);}
case 578:{f.Push(JValue.R(rt.String("")));f.Pc=580;continue;}
case 580:{return rt.Call(f,"java/util/regex/Matcher","replaceAll","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",583);}
case 583:{f.Locals[7]=f.Pop();f.Pc=585;continue;}
case 585:{f.Push(f.Locals[7]);f.Pc=587;continue;}
case 587:{f.Push(f.Locals[2]);f.Pc=588;continue;}
case 588:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",591);}
case 591:{return rt.Call(f,"forge/util/CardTranslation","translateSingleDescriptionText","(Ljava/lang/String;Lforge/util/ITranslatable;)Ljava/lang/String;","invokestatic",594);}
case 594:{f.Locals[8]=f.Pop();f.Pc=596;continue;}
case 596:{f.Push(f.Locals[5]);f.Pc=598;continue;}
case 598:{f.Pc=f.Pop().Reference==null?617:601;continue;}
case 601:{f.Push(f.Locals[3]);f.Pc=602;continue;}
case 602:{f.Push(f.Locals[2]);f.Pc=603;continue;}
case 603:{f.Push(f.Locals[5]);f.Pc=605;continue;}
case 605:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","conditionPrefix","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/lang/String;","invokestatic",608);}
case 608:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",611);}
case 611:{f.Push(JValue.R(rt.String(" ")));f.Pc=613;continue;}
case 613:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",616);}
case 616:{f.StackOp("pop");f.Pc=617;continue;}
case 617:{f.Push(f.Locals[3]);f.Pc=618;continue;}
case 618:{f.Push(f.Locals[5]);f.Pc=620;continue;}
case 620:{f.Pc=f.Pop().Reference==null?642:623;continue;}
case 623:{f.Push(f.Locals[5]);f.Pc=625;continue;}
case 625:{f.Push(JValue.R(rt.String(",")));f.Pc=628;continue;}
case 628:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",631);}
case 631:{f.Pc=f.Pop().Int==0?642:634;continue;}
case 634:{f.Push(f.Locals[8]);f.Pc=636;continue;}
case 636:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","uncapitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",639);}
case 639:{f.Pc=644;continue;}
case 642:{f.Push(f.Locals[8]);f.Pc=644;continue;}
case 644:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",647);}
case 647:{f.StackOp("pop");f.Pc=648;continue;}
case 648:{f.Push(f.Locals[6]);f.Pc=650;continue;}
case 650:{f.Pc=f.Pop().Reference==null?665:653;continue;}
case 653:{f.Push(f.Locals[3]);f.Pc=654;continue;}
case 654:{f.Push(JValue.R(rt.String(" ")));f.Pc=656;continue;}
case 656:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",659);}
case 659:{f.Push(f.Locals[6]);f.Pc=661;continue;}
case 661:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",664);}
case 664:{f.StackOp("pop");f.Pc=665;continue;}
case 665:{f.Push(f.Locals[2]);f.Pc=666;continue;}
case 666:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",669);}
case 669:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","PermanentCreature","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","PermanentCreature","Lforge/game/ability/ApiType;"));f.Pc=672;continue;}
case 672:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?910:675;continue;}
case 675:{f.Push(f.Locals[2]);f.Pc=676;continue;}
case 676:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",679);}
case 679:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","PermanentNoncreature","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","PermanentNoncreature","Lforge/game/ability/ApiType;"));f.Pc=682;continue;}
case 682:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?910:685;continue;}
case 685:{f.Push(f.Locals[2]);f.Pc=686;continue;}
case 686:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",689);}
case 689:{f.Locals[5]=f.Pop();f.Pc=691;continue;}
case 691:{f.Push(f.Locals[5]);f.Pc=693;continue;}
case 693:{f.Pc=f.Pop().Reference==null?910:696;continue;}
case 696:{f.Push(f.Locals[5]);f.Pc=698;continue;}
case 698:{return rt.Call(f,"forge/game/spellability/AbilitySub","getStackDescription","()Ljava/lang/String;","invokevirtual",701);}
case 701:{f.Locals[6]=f.Pop();f.Pc=703;continue;}
case 703:{f.Push(f.Locals[6]);f.Pc=705;continue;}
case 705:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",708);}
case 708:{f.Push(f.Locals[6]);f.Pc=710;continue;}
case 710:{return rt.Call(f,"java/lang/String","stripLeading","()Ljava/lang/String;","invokevirtual",713);}
case 713:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",716);}
case 716:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=717;continue;}
case 717:{f.Locals[7]=f.Pop();f.Pc=719;continue;}
case 719:{f.Push(f.Locals[7]);f.Pc=721;continue;}
case 721:{f.Push(f.Locals[6]);f.Pc=723;continue;}
case 723:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",726);}
case 726:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?783:729;continue;}
case 729:{f.Push(f.Locals[6]);f.Pc=731;continue;}
case 731:{f.Push(f.Locals[7]);f.Pc=733;continue;}
case 733:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",736);}
case 736:{return rt.Call(f,"java/lang/Character","isLowerCase","(C)Z","invokestatic",739);}
case 739:{f.Pc=f.Pop().Int==0?783:742;continue;}
case 742:{f.Push(f.Locals[3]);f.Pc=743;continue;}
case 743:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","endsWithSentence","(Ljava/lang/StringBuilder;)Z","invokestatic",746);}
case 746:{f.Pc=f.Pop().Int==0?783:749;continue;}
case 749:{f.Push(f.Locals[6]);f.Pc=751;continue;}
case 751:{f.Push(JValue.I(0));f.Pc=752;continue;}
case 752:{f.Push(f.Locals[7]);f.Pc=754;continue;}
case 754:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",757);}
case 757:{f.Push(f.Locals[6]);f.Pc=759;continue;}
case 759:{f.Push(f.Locals[7]);f.Pc=761;continue;}
case 761:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",764);}
case 764:{return rt.Call(f,"java/lang/Character","toUpperCase","(C)C","invokestatic",767);}
case 767:{f.Push(f.Locals[6]);f.Pc=769;continue;}
case 769:{f.Push(f.Locals[7]);f.Pc=771;continue;}
case 771:{f.Push(JValue.I(1));f.Pc=772;continue;}
case 772:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=773;continue;}
case 773:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",776);}
case 776:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2910:776:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;CLjava/lang/String;)Ljava/lang/String;",781);}
case 781:{f.Locals[6]=f.Pop();f.Pc=783;continue;}
case 783:{f.Push(f.Locals[3]);f.Pc=784;continue;}
case 784:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",787);}
case 787:{return rt.Call(f,"java/lang/String","stripTrailing","()Ljava/lang/String;","invokevirtual",790);}
case 790:{f.Push(JValue.R(rt.String(",")));f.Pc=793;continue;}
case 793:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",796);}
case 796:{f.Pc=f.Pop().Int==0?850:799;continue;}
case 799:{f.Push(JValue.R(rt.String("^(\\s*)([A-Z])((?:oll|raw|reate|ut|ap|ntap|estroy|xile|eturn|acrifice|iscard|ain|ose|cry|urveil|ill|eveal|earch|huffle|dd|hoose|ook|ttach|ight|nvestigate|roliferate|xplore|onnive|oad|egenerate|ounter|opy|eal)\\b.*)$")));f.Pc=802;continue;}
case 802:{f.Push(JValue.I(32));f.Pc=804;continue;}
case 804:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",807);}
case 807:{f.Push(f.Locals[6]);f.Pc=809;continue;}
case 809:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",812);}
case 812:{f.Locals[8]=f.Pop();f.Pc=814;continue;}
case 814:{f.Push(f.Locals[8]);f.Pc=816;continue;}
case 816:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",819);}
case 819:{f.Pc=f.Pop().Int==0?850:822;continue;}
case 822:{f.Push(f.Locals[8]);f.Pc=824;continue;}
case 824:{f.Push(JValue.I(1));f.Pc=825;continue;}
case 825:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",828);}
case 828:{f.Push(f.Locals[8]);f.Pc=830;continue;}
case 830:{f.Push(JValue.I(2));f.Pc=831;continue;}
case 831:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",834);}
case 834:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",837);}
case 837:{f.Push(f.Locals[8]);f.Pc=839;continue;}
case 839:{f.Push(JValue.I(3));f.Pc=840;continue;}
case 840:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",843);}
case 843:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2910:843:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",848);}
case 848:{f.Locals[6]=f.Pop();f.Pc=850;continue;}
case 850:{f.Push(f.Locals[3]);f.Pc=851;continue;}
case 851:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","endsWithComma","(Ljava/lang/StringBuilder;)Z","invokestatic",854);}
case 854:{f.Pc=f.Pop().Int==0?903:857;continue;}
case 857:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","CONTINUING_VERB","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/SpellAbilityEffect","CONTINUING_VERB","Ljava/util/regex/Pattern;"));f.Pc=860;continue;}
case 860:{f.Push(f.Locals[6]);f.Pc=862;continue;}
case 862:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",865);}
case 865:{f.Locals[8]=f.Pop();f.Pc=867;continue;}
case 867:{f.Push(f.Locals[8]);f.Pc=869;continue;}
case 869:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",872);}
case 872:{f.Pc=f.Pop().Int==0?903:875;continue;}
case 875:{f.Push(f.Locals[8]);f.Pc=877;continue;}
case 877:{f.Push(JValue.I(1));f.Pc=878;continue;}
case 878:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",881);}
case 881:{f.Push(f.Locals[8]);f.Pc=883;continue;}
case 883:{f.Push(JValue.I(2));f.Pc=884;continue;}
case 884:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",887);}
case 887:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",890);}
case 890:{f.Push(f.Locals[8]);f.Pc=892;continue;}
case 892:{f.Push(JValue.I(3));f.Pc=893;continue;}
case 893:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",896);}
case 896:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2910:896:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",901);}
case 901:{f.Locals[6]=f.Pop();f.Pc=903;continue;}
case 903:{f.Push(f.Locals[3]);f.Pc=904;continue;}
case 904:{f.Push(f.Locals[6]);f.Pc=906;continue;}
case 906:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",909);}
case 909:{f.StackOp("pop");f.Pc=910;continue;}
case 910:{f.Push(f.Locals[2]);f.Pc=911;continue;}
case 911:{f.Push(JValue.R(rt.String("Announce")));f.Pc=914;continue;}
case 914:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",917);}
case 917:{f.Pc=f.Pop().Int==0?985:920;continue;}
case 920:{f.Push(f.Locals[2]);f.Pc=921;continue;}
case 921:{f.Push(JValue.R(rt.String("Announce")));f.Pc=924;continue;}
case 924:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",927);}
case 927:{f.Locals[5]=f.Pop();f.Pc=929;continue;}
case 929:{f.Push(f.Locals[2]);f.Pc=930;continue;}
case 930:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",933);}
case 933:{f.Push(f.Locals[5]);f.Pc=935;continue;}
case 935:{f.Push(f.Locals[2]);f.Pc=936;continue;}
case 936:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",939);}
case 939:{f.Locals[6]=f.Pop();f.Pc=941;continue;}
case 941:{f.Push(f.Locals[3]);f.Pc=942;continue;}
case 942:{f.Push(JValue.R(rt.String(" ")));f.Pc=944;continue;}
case 944:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",947);}
case 947:{f.StackOp("pop");f.Pc=948;continue;}
case 948:{f.Push(f.Locals[3]);f.Pc=949;continue;}
case 949:{f.Push(JValue.I(3));f.Pc=950;continue;}
case 950:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=953;continue;}
case 953:{f.StackOp("dup");f.Pc=954;continue;}
case 954:{f.Push(JValue.I(0));f.Pc=955;continue;}
case 955:{f.Push(f.Locals[5]);f.Pc=957;continue;}
case 957:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=958;continue;}
case 958:{f.StackOp("dup");f.Pc=959;continue;}
case 959:{f.Push(JValue.I(1));f.Pc=960;continue;}
case 960:{f.Push(JValue.R(rt.String("=")));f.Pc=963;continue;}
case 963:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=964;continue;}
case 964:{f.StackOp("dup");f.Pc=965;continue;}
case 965:{f.Push(JValue.I(2));f.Pc=966;continue;}
case 966:{f.Push(f.Locals[6]);f.Pc=968;continue;}
case 968:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",971);}
case 971:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=972;continue;}
case 972:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",975);}
case 975:{return rt.Call(f,"forge/util/TextUtil","enclosedParen","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",978);}
case 978:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",981);}
case 981:{f.StackOp("pop");f.Pc=982;continue;}
case 982:{f.Pc=1054;continue;}
case 985:{f.Push(f.Locals[2]);f.Pc=986;continue;}
case 986:{return rt.Call(f,"forge/game/spellability/SpellAbility","costHasManaX","()Z","invokevirtual",989);}
case 989:{f.Pc=f.Pop().Int==0?1054:992;continue;}
case 992:{f.Push(f.Locals[2]);f.Pc=993;continue;}
case 993:{return rt.Call(f,"forge/game/spellability/SpellAbility","getXManaCostPaid","()Ljava/lang/Integer;","invokevirtual",996);}
case 996:{f.Pc=f.Pop().Reference!=null?1003:999;continue;}
case 999:{f.Push(JValue.I(0));f.Pc=1000;continue;}
case 1000:{f.Pc=1010;continue;}
case 1003:{f.Push(f.Locals[2]);f.Pc=1004;continue;}
case 1004:{return rt.Call(f,"forge/game/spellability/SpellAbility","getXManaCostPaid","()Ljava/lang/Integer;","invokevirtual",1007);}
case 1007:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",1010);}
case 1010:{f.Locals[5]=f.Pop();f.Pc=1012;continue;}
case 1012:{f.Push(f.Locals[3]);f.Pc=1013;continue;}
case 1013:{f.Push(JValue.R(rt.String(" ")));f.Pc=1015;continue;}
case 1015:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1018);}
case 1018:{f.StackOp("pop");f.Pc=1019;continue;}
case 1019:{f.Push(f.Locals[3]);f.Pc=1020;continue;}
case 1020:{f.Push(JValue.I(3));f.Pc=1021;continue;}
case 1021:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=1024;continue;}
case 1024:{f.StackOp("dup");f.Pc=1025;continue;}
case 1025:{f.Push(JValue.I(0));f.Pc=1026;continue;}
case 1026:{f.Push(JValue.R(rt.String("X")));f.Pc=1029;continue;}
case 1029:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1030;continue;}
case 1030:{f.StackOp("dup");f.Pc=1031;continue;}
case 1031:{f.Push(JValue.I(1));f.Pc=1032;continue;}
case 1032:{f.Push(JValue.R(rt.String("=")));f.Pc=1035;continue;}
case 1035:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1036;continue;}
case 1036:{f.StackOp("dup");f.Pc=1037;continue;}
case 1037:{f.Push(JValue.I(2));f.Pc=1038;continue;}
case 1038:{f.Push(f.Locals[5]);f.Pc=1040;continue;}
case 1040:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",1043);}
case 1043:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1044;continue;}
case 1044:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",1047);}
case 1047:{return rt.Call(f,"forge/util/TextUtil","enclosedParen","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",1050);}
case 1050:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1053);}
case 1053:{f.StackOp("pop");f.Pc=1054;continue;}
case 1054:{f.Push(f.Locals[2]);f.Pc=1055;continue;}
case 1055:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1058);}
case 1058:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",1061);}
case 1061:{f.Locals[5]=f.Pop();f.Pc=1063;continue;}
case 1063:{f.Push(f.Locals[3]);f.Pc=1064;continue;}
case 1064:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1067);}
case 1067:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=1069;continue;}
case 1069:{f.Push(f.Locals[5]);f.Pc=1071;continue;}
case 1071:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1074);}
case 1074:{f.Locals[6]=f.Pop();f.Pc=1076;continue;}
case 1076:{f.Push(f.Locals[6]);f.Pc=1078;continue;}
case 1078:{f.Push(JValue.R(rt.String("NICKNAME")));f.Pc=1081;continue;}
case 1081:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",1084);}
case 1084:{f.Push(f.Locals[5]);f.Pc=1086;continue;}
case 1086:{return rt.Call(f,"forge/util/Lang","getNickName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1089);}
case 1089:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1092);}
case 1092:{f.Locals[6]=f.Pop();f.Pc=1094;continue;}
case 1094:{f.Push(f.Locals[6]);f.Pc=1096;continue;}
case 1096:{f.Push(f.Locals[2]);f.Pc=1097;continue;}
case 1097:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilitySub")?1:0));f.Pc=1100;continue;}
case 1100:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","tidyDescription","(Ljava/lang/String;Z)Ljava/lang/String;","invokestatic",1103);}
case 1103:{f.Locals[7]=f.Pop();f.Pc=1105;continue;}
case 1105:{f.Push(f.Locals[2]);f.Pc=1106;continue;}
case 1106:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilitySub")?1:0));f.Pc=1109;continue;}
case 1109:{f.Pc=f.Pop().Int!=0?1162:1112;continue;}
case 1112:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","STACK_CARD_PRELUDE","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/SpellAbilityEffect","STACK_CARD_PRELUDE","Ljava/util/regex/Pattern;"));f.Pc=1115;continue;}
case 1115:{f.Push(f.Locals[7]);f.Pc=1117;continue;}
case 1117:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",1120);}
case 1120:{f.Locals[8]=f.Pop();f.Pc=1122;continue;}
case 1122:{f.Push(f.Locals[8]);f.Pc=1124;continue;}
case 1124:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",1127);}
case 1127:{f.Pc=f.Pop().Int==0?1162:1130;continue;}
case 1130:{f.Push(f.Locals[8]);f.Pc=1132;continue;}
case 1132:{f.Push(JValue.I(1));f.Pc=1133;continue;}
case 1133:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",1136);}
case 1136:{f.Push(f.Locals[8]);f.Pc=1138;continue;}
case 1138:{f.Push(JValue.I(2));f.Pc=1139;continue;}
case 1139:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",1142);}
case 1142:{return rt.Call(f,"java/lang/String","toUpperCase","()Ljava/lang/String;","invokevirtual",1145);}
case 1145:{f.Push(f.Locals[7]);f.Pc=1147;continue;}
case 1147:{f.Push(f.Locals[8]);f.Pc=1149;continue;}
case 1149:{return rt.Call(f,"java/util/regex/Matcher","end","()I","invokevirtual",1152);}
case 1152:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1155);}
case 1155:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2910:1155:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1160);}
case 1160:{f.Locals[7]=f.Pop();f.Pc=1162;continue;}
case 1162:{f.Push(f.Locals[7]);f.Pc=1164;continue;}
case 1164:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2911(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",4);}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=6;continue;}
case 6:{f.Locals[1]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int<0?42:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/StringBuilder","charAt","(I)C","invokevirtual",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/Character","isWhitespace","(C)Z","invokestatic",21);}
case 21:{f.Pc=f.Pop().Int!=0?36:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(JValue.I(44));f.Pc=27;continue;}
case 27:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?34:30;continue;}
case 30:{f.Push(JValue.I(1));f.Pc=31;continue;}
case 31:{f.Pc=35;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 36:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(-1)));f.Pc=39;continue;}
case 39:{f.Pc=7;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2912(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",4);}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=6;continue;}
case 6:{f.Locals[1]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int<0?88:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/StringBuilder","charAt","(I)C","invokevirtual",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/Character","isWhitespace","(C)Z","invokestatic",21);}
case 21:{f.Pc=f.Pop().Int==0?27:24;continue;}
case 24:{f.Pc=82;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(JValue.I(46));f.Pc=30;continue;}
case 30:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?76:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{f.Push(JValue.I(33));f.Pc=36;continue;}
case 36:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?76:39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(JValue.I(63));f.Pc=42;continue;}
case 42:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?76:45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(58));f.Pc=48;continue;}
case 48:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?76:51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(34));f.Pc=54;continue;}
case 54:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?76:57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(JValue.I(8221));f.Pc=61;continue;}
case 61:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?76:64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(JValue.I(41));f.Pc=67;continue;}
case 67:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?76:70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{f.Push(JValue.I(10));f.Pc=73;continue;}
case 73:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?80:76;continue;}
case 76:{f.Push(JValue.I(1));f.Pc=77;continue;}
case 77:{f.Pc=81;continue;}
case 80:{f.Push(JValue.I(0));f.Pc=81;continue;}
case 81:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 82:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(-1)));f.Pc=85;continue;}
case 85:{f.Pc=7;continue;}
case 88:{f.Push(JValue.I(1));f.Pc=89;continue;}
case 89:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2913(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?41:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",12);}
case 12:{return rt.Call(f,"java/lang/Character","isLowerCase","(C)Z","invokestatic",15);}
case 15:{f.Pc=f.Pop().Int==0?41:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String(",")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?41:28;continue;}
case 28:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","CONDITION_CONTINUATION","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/SpellAbilityEffect","CONDITION_CONTINUATION","Ljava/util/regex/Pattern;"));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",35);}
case 35:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?43:41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return JStep.Return(f.Pop());}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",47);}
case 47:{f.Locals[2]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(JValue.R(null));f.Pc=49;continue;}
case 49:{f.Locals[3]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Pc=f.Pop().Reference==null?177:54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Reference==null?177:61;continue;}
case 61:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect$2","$SwitchMap$forge$game$ability$ApiType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/SpellAbilityEffect$2","$SwitchMap$forge$game$ability$ApiType","[I"));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",68);}
case 68:{return rt.Call(f,"forge/game/ability/ApiType","ordinal","()I","invokevirtual",71);}
case 71:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=72;continue;}
case 72:{switch(f.Pop().Int){case 1:f.Pc=120;break;case 2:f.Pc=120;break;case 3:f.Pc=127;break;case 4:f.Pc=127;break;case 5:f.Pc=134;break;case 6:f.Pc=141;break;case 7:f.Pc=148;break;case 8:f.Pc=148;break;default:f.Pc=177;break;}continue;}
case 120:{f.Push(JValue.R(rt.String("was destroyed this way")));f.Pc=123;continue;}
case 123:{f.Locals[3]=f.Pop();f.Pc=124;continue;}
case 124:{f.Pc=177;continue;}
case 127:{f.Push(JValue.R(rt.String("was sacrificed this way")));f.Pc=130;continue;}
case 130:{f.Locals[3]=f.Pop();f.Pc=131;continue;}
case 131:{f.Pc=177;continue;}
case 134:{f.Push(JValue.R(rt.String("was discarded this way")));f.Pc=137;continue;}
case 137:{f.Locals[3]=f.Pop();f.Pc=138;continue;}
case 138:{f.Pc=177;continue;}
case 141:{f.Push(JValue.R(rt.String("was milled this way")));f.Pc=144;continue;}
case 144:{f.Locals[3]=f.Pop();f.Pc=145;continue;}
case 145:{f.Pc=177;continue;}
case 148:{f.Push(JValue.R(rt.String("Exile")));f.Pc=151;continue;}
case 151:{f.Push(f.Locals[2]);f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("Destination")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",158);}
case 158:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",161);}
case 161:{f.Pc=f.Pop().Int==0?170:164;continue;}
case 164:{f.Push(JValue.R(rt.String("was exiled this way")));f.Pc=167;continue;}
case 167:{f.Pc=173;continue;}
case 170:{f.Push(JValue.R(rt.String("was put there this way")));f.Pc=173;continue;}
case 173:{f.Locals[3]=f.Pop();f.Pc=174;continue;}
case 174:{f.Pc=177;continue;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(JValue.I(0));f.Pc=179;continue;}
case 179:{f.Push(f.Locals[1]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",183);}
case 183:{f.Push(JValue.I(1));f.Pc=184;continue;}
case 184:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",188);}
case 188:{f.Locals[4]=f.Pop();f.Pc=190;continue;}
case 190:{f.Push(f.Locals[4]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[3]);f.Pc=193;continue;}
case 193:{f.Pc=f.Pop().Reference!=null?202:196;continue;}
case 196:{f.Push(JValue.R(rt.String(",")));f.Pc=199;continue;}
case 199:{f.Pc=208;continue;}
case 202:{f.Push(f.Locals[3]);f.Pc=203;continue;}
case 203:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2913:203:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",208);}
case 208:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2913:208:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",213);}
case 213:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2914(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","TIDY_COMMA_RUN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/SpellAbilityEffect","TIDY_COMMA_RUN","Ljava/util/regex/Pattern;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",7);}
case 7:{f.Push(JValue.R(rt.String(" ")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/regex/Matcher","replaceAll","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","TIDY_OPTIONAL_PLURAL","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/SpellAbilityEffect","TIDY_OPTIONAL_PLURAL","Ljava/util/regex/Pattern;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",20);}
case 20:{f.Push(JValue.R(rt.String("$1")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/regex/Matcher","replaceAll","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","TIDY_DOUBLE_PERIOD","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/SpellAbilityEffect","TIDY_DOUBLE_PERIOD","Ljava/util/regex/Pattern;"));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",34);}
case 34:{f.Push(JValue.R(rt.String(".")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/regex/Matcher","replaceAll","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",40);}
case 40:{f.Locals[2]=f.Pop();f.Pc=41;continue;}
case 41:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","TIDY_SENTENCE_SPACE","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/SpellAbilityEffect","TIDY_SENTENCE_SPACE","Ljava/util/regex/Pattern;"));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",48);}
case 48:{f.Push(JValue.R(rt.String(" ")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/regex/Matcher","replaceAll","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",53);}
case 53:{f.Locals[2]=f.Pop();f.Pc=54;continue;}
case 54:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","TIDY_NEWLINES","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/SpellAbilityEffect","TIDY_NEWLINES","Ljava/util/regex/Pattern;"));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",61);}
case 61:{f.Push(JValue.R(rt.String("\n")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/regex/Matcher","replaceAll","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",67);}
case 67:{f.Locals[2]=f.Pop();f.Pc=68;continue;}
case 68:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","TIDY_DOUBLE_SPACES","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/SpellAbilityEffect","TIDY_DOUBLE_SPACES","Ljava/util/regex/Pattern;"));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",75);}
case 75:{f.Push(JValue.R(rt.String(" ")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/regex/Matcher","replaceAll","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",80);}
case 80:{f.Locals[2]=f.Pop();f.Pc=81;continue;}
case 81:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","TIDY_PUNCTUATION_SPACE","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/SpellAbilityEffect","TIDY_PUNCTUATION_SPACE","Ljava/util/regex/Pattern;"));f.Pc=84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",88);}
case 88:{f.Push(JValue.R(rt.String("$1")));f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/regex/Matcher","replaceAll","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",94);}
case 94:{f.Locals[2]=f.Pop();f.Pc=95;continue;}
case 95:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","TIDY_DUPLICATE_CONJUNCTION","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/SpellAbilityEffect","TIDY_DUPLICATE_CONJUNCTION","Ljava/util/regex/Pattern;"));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",102);}
case 102:{f.Push(JValue.R(rt.String("$1")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/regex/Matcher","replaceAll","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",108);}
case 108:{f.Locals[2]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",113);}
case 113:{f.Push(f.Locals[2]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/String","stripLeading","()Ljava/lang/String;","invokevirtual",117);}
case 117:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",120);}
case 120:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=121;continue;}
case 121:{f.Locals[3]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{f.Pc=f.Pop().Int!=0?172:126;continue;}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[2]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",131);}
case 131:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?172:134;continue;}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[3]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",139);}
case 139:{return rt.Call(f,"java/lang/Character","isLowerCase","(C)Z","invokestatic",142);}
case 142:{f.Pc=f.Pop().Int==0?172:145;continue;}
case 145:{f.Push(f.Locals[2]);f.Pc=146;continue;}
case 146:{f.Push(JValue.I(0));f.Pc=147;continue;}
case 147:{f.Push(f.Locals[3]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",151);}
case 151:{f.Push(f.Locals[2]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[3]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",156);}
case 156:{return rt.Call(f,"java/lang/Character","toUpperCase","(C)C","invokestatic",159);}
case 159:{f.Push(f.Locals[2]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[3]);f.Pc=161;continue;}
case 161:{f.Push(JValue.I(1));f.Pc=162;continue;}
case 162:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",166);}
case 166:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2914:166:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;CLjava/lang/String;)Ljava/lang/String;",171);}
case 171:{f.Locals[2]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[1]);f.Pc=173;continue;}
case 173:{f.Pc=f.Pop().Int==0?180:176;continue;}
case 176:{f.Push(f.Locals[2]);f.Pc=177;continue;}
case 177:{f.Pc=184;continue;}
case 180:{f.Push(f.Locals[2]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/lang/String","stripTrailing","()Ljava/lang/String;","invokevirtual",184);}
case 184:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2915(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("Amount")));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("1")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",13);}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",17);}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2916(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/StringTokenizer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/StringTokenizer")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("{}")));f.Pc=8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/StringTokenizer","<init>","(Ljava/lang/String;Ljava/lang/String;Z)V","invokespecial",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/StringTokenizer","hasMoreTokens","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?344:23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/StringTokenizer","nextToken","()Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Locals[5]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("{")));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?46:40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Pc=16;continue;}
case 46:{f.Push(JValue.R(rt.String("}")));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?63:57;continue;}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{f.Locals[4]=f.Pop();f.Pc=60;continue;}
case 60:{f.Pc=16;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{f.Pc=f.Pop().Int!=0?334:68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",73);}
case 73:{f.Push(JValue.I(2));f.Pc=74;continue;}
case 74:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?99:77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("{")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",84);}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",89);}
case 89:{f.Push(JValue.R(rt.String("}")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",95);}
case 95:{f.StackOp("pop");f.Pc=96;continue;}
case 96:{f.Pc=341;continue;}
case 99:{f.Push(f.Locals[5]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("n:")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int==0?170:110;continue;}
case 110:{f.Push(f.Locals[5]);f.Pc=112;continue;}
case 112:{f.Push(JValue.I(2));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",116);}
case 116:{f.Push(JValue.R(rt.String(" ")));f.Pc=118;continue;}
case 118:{f.Push(JValue.I(2));f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",122);}
case 122:{f.Locals[6]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",128);}
case 128:{f.Push(f.Locals[6]);f.Pc=130;continue;}
case 130:{f.Push(JValue.I(0));f.Pc=131;continue;}
case 131:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",136);}
case 136:{f.Locals[7]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[6]);f.Pc=141;continue;}
case 141:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=142;continue;}
case 142:{f.Push(JValue.I(1));f.Pc=143;continue;}
case 143:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?154:146;continue;}
case 146:{f.Push(f.Locals[7]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",151);}
case 151:{f.Pc=163;continue;}
case 154:{f.Push(f.Locals[7]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[6]);f.Pc=158;continue;}
case 158:{f.Push(JValue.I(1));f.Pc=159;continue;}
case 159:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/util/Lang","nounWithNumeral","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",163);}
case 163:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",166);}
case 166:{f.StackOp("pop");f.Pc=167;continue;}
case 167:{f.Pc=341;continue;}
case 170:{f.Push(f.Locals[5]);f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String("p:")));f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",178);}
case 178:{f.Pc=f.Pop().Int==0?200:181;continue;}
case 181:{f.Push(f.Locals[0]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",185);}
case 185:{f.Push(f.Locals[5]);f.Pc=187;continue;}
case 187:{f.Push(JValue.I(2));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",191);}
case 191:{f.Push(f.Locals[0]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",195);}
case 195:{f.Locals[6]=f.Pop();f.Pc=197;continue;}
case 197:{f.Pc=303;continue;}
case 200:{f.Push(f.Locals[5]);f.Pc=202;continue;}
case 202:{f.Push(JValue.R(rt.String("s:")));f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",208);}
case 208:{f.Pc=f.Pop().Int==0?230:211;continue;}
case 211:{f.Push(f.Locals[0]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",215);}
case 215:{f.Push(f.Locals[5]);f.Pc=217;continue;}
case 217:{f.Push(JValue.I(2));f.Pc=218;continue;}
case 218:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",221);}
case 221:{f.Push(f.Locals[0]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedSpellAbilities","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",225);}
case 225:{f.Locals[6]=f.Pop();f.Pc=227;continue;}
case 227:{f.Pc=303;continue;}
case 230:{f.Push(f.Locals[5]);f.Pc=232;continue;}
case 232:{f.Push(JValue.R(rt.String("c:")));f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",238);}
case 238:{f.Pc=f.Pop().Int==0?291:241;continue;}
case 241:{f.Push(f.Locals[0]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",245);}
case 245:{f.Push(f.Locals[5]);f.Pc=247;continue;}
case 247:{f.Push(JValue.I(2));f.Pc=248;continue;}
case 248:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",251);}
case 251:{f.Push(f.Locals[0]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",255);}
case 255:{f.Locals[7]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[7]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",264);}
case 264:{f.Pc=f.Pop().Int==0?284:267;continue;}
case 267:{f.Push(f.Locals[0]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",271);}
case 271:{f.Push(f.Locals[5]);f.Pc=273;continue;}
case 273:{f.Push(JValue.I(2));f.Pc=274;continue;}
case 274:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",277);}
case 277:{f.Push(f.Locals[0]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",281);}
case 281:{f.Pc=286;continue;}
case 284:{f.Push(f.Locals[7]);f.Pc=286;continue;}
case 286:{f.Locals[6]=f.Pop();f.Pc=288;continue;}
case 288:{f.Pc=303;continue;}
case 291:{f.Push(f.Locals[0]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",295);}
case 295:{f.Push(f.Locals[5]);f.Pc=297;continue;}
case 297:{f.Push(f.Locals[0]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedObjects","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",301);}
case 301:{f.Locals[6]=f.Pop();f.Pc=303;continue;}
case 303:{f.Push(f.Locals[1]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[6]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",311);}
case 311:{f.Pc=f.Pop().Int==0?322:314;continue;}
case 314:{f.Push(f.Locals[5]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","undefinedObjectText","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",319);}
case 319:{f.Pc=327;continue;}
case 322:{f.Push(f.Locals[6]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","joinNamed","(Ljava/lang/Iterable;)Ljava/lang/String;","invokestatic",327);}
case 327:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",330);}
case 330:{f.StackOp("pop");f.Pc=331;continue;}
case 331:{f.Pc=341;continue;}
case 334:{f.Push(f.Locals[1]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[5]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",340);}
case 340:{f.StackOp("pop");f.Pc=341;continue;}
case 341:{f.Pc=16;continue;}
case 344:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2917(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?18:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int!=0?18:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",17);}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Opponent")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?40:36;continue;}
case 36:{f.Push(JValue.R(rt.String("each opponent")));f.Pc=39;continue;}
case 39:{return JStep.Return(f.Pop());}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("Player")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int!=0?70:50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("Player.")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int!=0?70:60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("EachPlayer")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int==0?74:70;continue;}
case 70:{f.Push(JValue.R(rt.String("each player")));f.Pc=73;continue;}
case 73:{return JStep.Return(f.Pop());}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("Chosen")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int==0?88:84;continue;}
case 84:{f.Push(JValue.R(rt.String("the chosen player")));f.Pc=87;continue;}
case 87:{return JStep.Return(f.Pop());}
case 88:{f.Push(JValue.R(rt.String("that player")));f.Pc=91;continue;}
case 91:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2918(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",6);}
case 6:{f.Locals[1]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int!=0?19:16;continue;}
case 16:{f.Push(JValue.R(rt.String("")));f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
case 19:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","appendNamed","(Ljava/lang/StringBuilder;Ljava/lang/Object;)V","invokestatic",37);}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",43);}
case 43:{f.Pc=f.Pop().Int==0?84:46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",52);}
case 52:{f.Locals[3]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",60);}
case 60:{f.Pc=f.Pop().Int==0?69:63;continue;}
case 63:{f.Push(JValue.R(rt.String(", ")));f.Pc=66;continue;}
case 66:{f.Pc=72;continue;}
case 69:{f.Push(JValue.R(rt.String(" and ")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[3]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","appendNamed","(Ljava/lang/StringBuilder;Ljava/lang/Object;)V","invokestatic",81);}
case 81:{f.Pc=37;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",88);}
case 88:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2919(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?55:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Reference!=null?28:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{f.Pc=52;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",33);}
case 33:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?52:44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("'s ability")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{f.Pc=64;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",60);}
case 60:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2920(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("p:")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("^[pcs]:")));f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Int==0?26:22;continue;}
case 22:{f.Push(JValue.R(rt.String("that player")));f.Pc=25;continue;}
case 25:{return JStep.Return(f.Pop());}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Equipped")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?40:36;continue;}
case 36:{f.Push(JValue.R(rt.String("equipped creature")));f.Pc=39;continue;}
case 39:{return JStep.Return(f.Pop());}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("Enchanted")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?54:50;continue;}
case 50:{f.Push(JValue.R(rt.String("enchanted permanent")));f.Pc=53;continue;}
case 53:{return JStep.Return(f.Pop());}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("s:")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int==0?70:64;continue;}
case 64:{f.Push(JValue.R(rt.String("spell")));f.Pc=67;continue;}
case 67:{f.Pc=73;continue;}
case 70:{f.Push(JValue.R(rt.String("card")));f.Pc=73;continue;}
case 73:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2920:73:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",78);}
case 78:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2921(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Defined")));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getCards","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2922(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getCards","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2923(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Defined")));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getCards","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2924(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getCards","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2925(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getCards","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/List;)Lforge/game/card/CardCollection;","invokestatic",11);}
case 11:{f.StackOp("pop");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2926(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getCards","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/List;)Lforge/game/card/CardCollection;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2927(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ThisDefinedAndTgts")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?43:10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",14);}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("ThisDefinedAndTgts")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",25);}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",36);}
case 36:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return JStep.Return(f.Pop());}
case 43:{f.Push(JValue.R(null));f.Pc=44;continue;}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?69:53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Pc=f.Pop().Int==0?65:57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int!=0?69:65;continue;}
case 65:{f.Push(JValue.I(1));f.Pc=66;continue;}
case 66:{f.Pc=70;continue;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{f.Locals[5]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{f.Pc=f.Pop().Int==0?119:77;continue;}
case 77:{f.Push(f.Locals[3]);f.Pc=78;continue;}
case 78:{f.Pc=f.Pop().Reference!=null?93:81;continue;}
case 81:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",88);}
case 88:{f.Locals[4]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{f.Locals[3]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",97);}
case 97:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",100);}
case 100:{f.Push(f.Locals[3]);f.Pc=101;continue;}
case 101:{f.StackOp("dup");f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",105);}
case 105:{f.StackOp("pop");f.Pc=106;continue;}
case 106:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2927:106:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;)Ljava/util/function/Consumer;",111);}
case 111:{return rt.Call(f,"forge/game/card/CardCollectionView","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",116);}
case 116:{f.Pc=200;continue;}
case 119:{f.Push(f.Locals[2]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("Self")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",126);}
case 126:{f.Push(JValue.R(rt.String(" & ")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",131);}
case 131:{f.Locals[6]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[6]);f.Pc=135;continue;}
case 135:{f.Locals[7]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[7]);f.Pc=139;continue;}
case 139:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=140;continue;}
case 140:{f.Locals[8]=f.Pop();f.Pc=142;continue;}
case 142:{f.Push(JValue.I(0));f.Pc=143;continue;}
case 143:{f.Locals[9]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[9]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[8]);f.Pc=149;continue;}
case 149:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?200:152;continue;}
case 152:{f.Push(f.Locals[7]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[9]);f.Pc=156;continue;}
case 156:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=157;continue;}
case 157:{f.Locals[10]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[2]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",163);}
case 163:{f.Push(f.Locals[10]);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[2]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",169);}
case 169:{f.Locals[11]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[3]);f.Pc=172;continue;}
case 172:{f.Pc=f.Pop().Reference!=null?185:175;continue;}
case 175:{f.Push(f.Locals[11]);f.Pc=177;continue;}
case 177:{f.Locals[4]=f.Pop();f.Pc=179;continue;}
case 179:{f.Push(f.Locals[4]);f.Pc=181;continue;}
case 181:{f.Locals[3]=f.Pop();f.Pc=182;continue;}
case 182:{f.Pc=194;continue;}
case 185:{f.Push(f.Locals[3]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[11]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",193);}
case 193:{f.StackOp("pop");f.Pc=194;continue;}
case 194:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=197;continue;}
case 197:{f.Pc=145;continue;}
case 200:{f.Push(f.Locals[4]);f.Pc=202;continue;}
case 202:{f.Pc=f.Pop().Reference!=null?207:205;continue;}
case 205:{f.Push(JValue.R(null));f.Pc=206;continue;}
case 206:{return JStep.Return(f.Pop());}
case 207:{f.Push(f.Locals[2]);f.Pc=208;continue;}
case 208:{f.Push(JValue.R(rt.String("IncludeAllComponentCards")));f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",214);}
case 214:{f.Pc=f.Pop().Int==0?261:217;continue;}
case 217:{f.Push(f.Locals[4]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",222);}
case 222:{f.Locals[6]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(f.Locals[6]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",231);}
case 231:{f.Pc=f.Pop().Int==0?261:234;continue;}
case 234:{f.Push(f.Locals[6]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",241);}
case 241:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=244;continue;}
case 244:{f.Locals[7]=f.Pop();f.Pc=246;continue;}
case 246:{f.Push(f.Locals[4]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[7]);f.Pc=250;continue;}
case 250:{f.Push(JValue.I(0));f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/card/Card","getAllComponentCards","(Z)Lforge/game/card/CardCollection;","invokevirtual",254);}
case 254:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",257);}
case 257:{f.StackOp("pop");f.Pc=258;continue;}
case 258:{f.Pc=224;continue;}
case 261:{f.Push(f.Locals[4]);f.Pc=263;continue;}
case 263:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2928(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Defined")));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getPlayers","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2929(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getPlayers","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2930(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Defined")));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getPlayers","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2931(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getPlayers","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2932(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",12);}
case 12:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?62:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2932:42:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",47);}
case 47:{return rt.Call(f,"forge/game/player/PlayerCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int!=0?59:53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/player/PlayerCollection","add","(Ljava/lang/Object;)Z","invokevirtual",58);}
case 58:{f.StackOp("pop");f.Pc=59;continue;}
case 59:{f.Pc=16;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2933(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getPlayers","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/List;)Lforge/game/player/PlayerCollection;","invokestatic",11);}
case 11:{f.StackOp("pop");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2934(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getPlayers","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/List;)Lforge/game/player/PlayerCollection;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2935(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?26:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int==0?22:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int!=0?26:22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{f.Pc=27;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{f.Locals[5]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[5]);f.Pc=31;continue;}
case 31:{f.Pc=f.Pop().Int==0?76:34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Reference!=null?50:38;continue;}
case 38:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",45);}
case 45:{f.Locals[4]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{f.Locals[3]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",54);}
case 54:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetPlayers","()Ljava/lang/Iterable;","invokevirtual",57);}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2935:63:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;)Ljava/util/function/Consumer;",68);}
case 68:{return rt.Call(f,"java/lang/Iterable","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",73);}
case 73:{f.Pc=158;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("You")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",84);}
case 84:{f.Push(JValue.R(rt.String(" & ")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",89);}
case 89:{f.Locals[6]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[6]);f.Pc=93;continue;}
case 93:{f.Locals[7]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=98;continue;}
case 98:{f.Locals[8]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(JValue.I(0));f.Pc=101;continue;}
case 101:{f.Locals[9]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[9]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[8]);f.Pc=107;continue;}
case 107:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?158:110;continue;}
case 110:{f.Push(f.Locals[7]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[9]);f.Pc=114;continue;}
case 114:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=115;continue;}
case 115:{f.Locals[10]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[2]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",121);}
case 121:{f.Push(f.Locals[10]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",127);}
case 127:{f.Locals[11]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[3]);f.Pc=130;continue;}
case 130:{f.Pc=f.Pop().Reference!=null?143:133;continue;}
case 133:{f.Push(f.Locals[11]);f.Pc=135;continue;}
case 135:{f.Locals[4]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[4]);f.Pc=139;continue;}
case 139:{f.Locals[3]=f.Pop();f.Pc=140;continue;}
case 140:{f.Pc=152;continue;}
case 143:{f.Push(f.Locals[3]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[11]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",151);}
case 151:{f.StackOp("pop");f.Pc=152;continue;}
case 152:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=155;continue;}
case 155:{f.Pc=103;continue;}
case 158:{f.Push(f.Locals[2]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[3]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","sortAPNAP","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)V","invokestatic",163);}
case 163:{f.Push(f.Locals[4]);f.Pc=165;continue;}
case 165:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2936(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("StartingWith")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?48:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",30);}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("StartingWith")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",41);}
case 41:{return rt.Call(f,"forge/game/player/PlayerCollection","getFirst","()Ljava/lang/Object;","invokevirtual",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{f.Locals[3]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/Game","getPlayersInTurnOrder","(Lforge/game/player/Player;)Lforge/game/player/PlayerCollection;","invokevirtual",53);}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2936:63:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/PlayerCollection;)Ljava/util/function/ToIntFunction;",68);}
case 68:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",71);}
case 71:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",76);}
case 76:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2937(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Defined")));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getSpells","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2938(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getSpells","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2939(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getSpells","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2940(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?23:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int==0?19:11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int!=0?23:19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Pc=f.Pop().Int==0?42:29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetSpells","()Ljava/lang/Iterable;","invokevirtual",36);}
case 36:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",39);}
case 39:{f.Pc=55;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",46);}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",51);}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedSpellAbilities","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",55);}
case 55:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2941(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Defined")));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getEntities","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2942(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getEntities","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2943(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getEntities","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2944(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?23:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int==0?19:11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int!=0?23:19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Self")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Push(JValue.R(rt.String(" & ")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Locals[4]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Int==0?56:43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetEntities","()Ljava/lang/Iterable;","invokevirtual",50);}
case 50:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",53);}
case 53:{f.Pc=66;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",60);}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;[Ljava/lang/String;Lforge/game/CardTraitBase;)Ljava/util/List;","invokestatic",66);}
case 66:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2945(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Defined")));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getTargetables","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2946(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getTargetables","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2947(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getTargetables","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2948(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?23:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int==0?19:11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int!=0?23:19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Pc=f.Pop().Int==0?39:29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",33);}
case 33:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",36);}
case 36:{f.Pc=52;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",43);}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedObjects","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",52);}
case 52:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2949(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetSpells","()Ljava/lang/Iterable;","invokevirtual",12);}
case 12:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?51:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",42);}
case 42:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Pc=18;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2950(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Your")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",12);}
case 12:{f.Locals[4]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("Combat")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",21);}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Upkeep")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",29);}
case 29:{f.Locals[6]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("AtEOTDesc")));f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",40);}
case 40:{f.Locals[7]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Int==0?58:47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("Your")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",54);}
case 54:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",57);}
case 57:{f.Locals[1]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{f.Pc=f.Pop().Int==0?80:63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",69);}
case 69:{f.Push(JValue.R(rt.String("Combat")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",75);}
case 75:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",79);}
case 79:{f.Locals[1]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[6]);f.Pc=82;continue;}
case 82:{f.Pc=f.Pop().Int==0?101:85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(JValue.I(0));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",91);}
case 91:{f.Push(JValue.R(rt.String("Upkeep")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",96);}
case 96:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",100);}
case 100:{f.Locals[1]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[7]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?333:109;continue;}
case 109:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=112;continue;}
case 112:{f.StackOp("dup");f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",116);}
case 116:{f.Locals[8]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("Hand")));f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",124);}
case 124:{f.Pc=f.Pop().Int==0?139:127;continue;}
case 127:{f.Push(f.Locals[8]);f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.String("Return ")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",135);}
case 135:{f.StackOp("pop");f.Pc=136;continue;}
case 136:{f.Pc=195;continue;}
case 139:{f.Push(f.Locals[1]);f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.String("Library")));f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",146);}
case 146:{f.Pc=f.Pop().Int==0?161:149;continue;}
case 149:{f.Push(f.Locals[8]);f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("Shuffle ")));f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",157);}
case 157:{f.StackOp("pop");f.Pc=158;continue;}
case 158:{f.Pc=195;continue;}
case 161:{f.Push(f.Locals[1]);f.Pc=162;continue;}
case 162:{f.Push(JValue.R(rt.String("SacrificeCtrl")));f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",168);}
case 168:{f.Pc=f.Pop().Int==0?183:171;continue;}
case 171:{f.Push(f.Locals[8]);f.Pc=173;continue;}
case 173:{f.Push(JValue.R(rt.String("Its controller sacrifices ")));f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",179);}
case 179:{f.StackOp("pop");f.Pc=180;continue;}
case 180:{f.Pc=195;continue;}
case 183:{f.Push(f.Locals[8]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",189);}
case 189:{f.Push(JValue.R(rt.String(" ")));f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",194);}
case 194:{f.StackOp("pop");f.Pc=195;continue;}
case 195:{f.Push(f.Locals[8]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[2]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/lang/Iterable;)Ljava/lang/String;","invokestatic",201);}
case 201:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",204);}
case 204:{f.StackOp("pop");f.Pc=205;continue;}
case 205:{f.Push(f.Locals[1]);f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.String("Hand")));f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",211);}
case 211:{f.Pc=f.Pop().Int==0?226:214;continue;}
case 214:{f.Push(f.Locals[8]);f.Pc=216;continue;}
case 216:{f.Push(JValue.R(rt.String(" to your hand")));f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",222);}
case 222:{f.StackOp("pop");f.Pc=223;continue;}
case 223:{f.Pc=245;continue;}
case 226:{f.Push(f.Locals[1]);f.Pc=227;continue;}
case 227:{f.Push(JValue.R(rt.String("Library")));f.Pc=230;continue;}
case 230:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",233);}
case 233:{f.Pc=f.Pop().Int==0?245:236;continue;}
case 236:{f.Push(f.Locals[8]);f.Pc=238;continue;}
case 238:{f.Push(JValue.R(rt.String(" into your library")));f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",244);}
case 244:{f.StackOp("pop");f.Pc=245;continue;}
case 245:{f.Push(f.Locals[8]);f.Pc=247;continue;}
case 247:{f.Push(JValue.R(rt.String(" at the ")));f.Pc=250;continue;}
case 250:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",253);}
case 253:{f.StackOp("pop");f.Pc=254;continue;}
case 254:{f.Push(f.Locals[5]);f.Pc=256;continue;}
case 256:{f.Pc=f.Pop().Int==0?271:259;continue;}
case 259:{f.Push(f.Locals[8]);f.Pc=261;continue;}
case 261:{f.Push(JValue.R(rt.String("end of combat.")));f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",267);}
case 267:{f.StackOp("pop");f.Pc=268;continue;}
case 268:{f.Pc=326;continue;}
case 271:{f.Push(f.Locals[8]);f.Pc=273;continue;}
case 273:{f.Push(JValue.R(rt.String("beginning of ")));f.Pc=276;continue;}
case 276:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",279);}
case 279:{f.StackOp("pop");f.Pc=280;continue;}
case 280:{f.Push(f.Locals[8]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[4]);f.Pc=284;continue;}
case 284:{f.Pc=f.Pop().Int==0?293:287;continue;}
case 287:{f.Push(JValue.R(rt.String("your")));f.Pc=290;continue;}
case 290:{f.Pc=296;continue;}
case 293:{f.Push(JValue.R(rt.String("the")));f.Pc=296;continue;}
case 296:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",299);}
case 299:{f.StackOp("pop");f.Pc=300;continue;}
case 300:{f.Push(f.Locals[6]);f.Pc=302;continue;}
case 302:{f.Pc=f.Pop().Int==0?317:305;continue;}
case 305:{f.Push(f.Locals[8]);f.Pc=307;continue;}
case 307:{f.Push(JValue.R(rt.String(" next upkeep.")));f.Pc=310;continue;}
case 310:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",313);}
case 313:{f.StackOp("pop");f.Pc=314;continue;}
case 314:{f.Pc=326;continue;}
case 317:{f.Push(f.Locals[8]);f.Pc=319;continue;}
case 319:{f.Push(JValue.R(rt.String(" next end step.")));f.Pc=322;continue;}
case 322:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",325);}
case 325:{f.StackOp("pop");f.Pc=326;continue;}
case 326:{f.Push(f.Locals[8]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",331);}
case 331:{f.Locals[7]=f.Pop();f.Pc=333;continue;}
case 333:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=336;continue;}
case 336:{f.StackOp("dup");f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",340);}
case 340:{f.Locals[8]=f.Pop();f.Pc=342;continue;}
case 342:{f.Push(f.Locals[8]);f.Pc=344;continue;}
case 344:{f.Push(JValue.R(rt.String("Mode$ Phase | Phase$ ")));f.Pc=347;continue;}
case 347:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",350);}
case 350:{f.StackOp("pop");f.Pc=351;continue;}
case 351:{f.Push(f.Locals[8]);f.Pc=353;continue;}
case 353:{f.Push(f.Locals[5]);f.Pc=355;continue;}
case 355:{f.Pc=f.Pop().Int==0?364:358;continue;}
case 358:{f.Push(JValue.R(rt.String("EndCombat ")));f.Pc=361;continue;}
case 361:{f.Pc=377;continue;}
case 364:{f.Push(f.Locals[6]);f.Pc=366;continue;}
case 366:{f.Pc=f.Pop().Int==0?374:369;continue;}
case 369:{f.Push(JValue.R(rt.String("Upkeep")));f.Pc=371;continue;}
case 371:{f.Pc=377;continue;}
case 374:{f.Push(JValue.R(rt.String("End Of Turn ")));f.Pc=377;continue;}
case 377:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",380);}
case 380:{f.StackOp("pop");f.Pc=381;continue;}
case 381:{f.Push(f.Locals[4]);f.Pc=383;continue;}
case 383:{f.Pc=f.Pop().Int==0?395:386;continue;}
case 386:{f.Push(f.Locals[8]);f.Pc=388;continue;}
case 388:{f.Push(JValue.R(rt.String("| ValidPlayer$ You ")));f.Pc=391;continue;}
case 391:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",394);}
case 394:{f.StackOp("pop");f.Pc=395;continue;}
case 395:{f.Push(f.Locals[8]);f.Pc=397;continue;}
case 397:{f.Push(JValue.R(rt.String("| TriggerDescription$ ")));f.Pc=400;continue;}
case 400:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",403);}
case 403:{f.Push(f.Locals[7]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",408);}
case 408:{f.StackOp("pop");f.Pc=409;continue;}
case 409:{f.Push(f.Locals[8]);f.Pc=411;continue;}
case 411:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",414);}
case 414:{f.Push(f.Locals[0]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",418);}
case 418:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",421);}
case 421:{f.Push(f.Locals[3]);f.Pc=422;continue;}
case 422:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",425);}
case 425:{f.Locals[9]=f.Pop();f.Pc=427;continue;}
case 427:{f.Push(f.Locals[0]);f.Pc=428;continue;}
case 428:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",431);}
case 431:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",434);}
case 434:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",437);}
case 437:{f.Locals[10]=f.Pop();f.Pc=439;continue;}
case 439:{f.Push(f.Locals[2]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",445);}
case 445:{f.Locals[12]=f.Pop();f.Pc=447;continue;}
case 447:{f.Push(f.Locals[12]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",454);}
case 454:{f.Pc=f.Pop().Int==0?496:457;continue;}
case 457:{f.Push(f.Locals[12]);f.Pc=459;continue;}
case 459:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",464);}
case 464:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=467;continue;}
case 467:{f.Locals[13]=f.Pop();f.Pc=469;continue;}
case 469:{f.Push(f.Locals[9]);f.Pc=471;continue;}
case 471:{f.Push(f.Locals[13]);f.Pc=473;continue;}
case 473:{return rt.Call(f,"forge/game/trigger/Trigger","addRemembered","(Ljava/lang/Object;)V","invokevirtual",476);}
case 476:{f.Push(f.Locals[13]);f.Pc=478;continue;}
case 478:{f.Push(JValue.R(rt.String("EndOfTurnLeavePlay")));f.Pc=481;continue;}
case 481:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=484;continue;}
case 484:{return rt.Call(f,"java/util/Collections","singletonMap","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;","invokestatic",487);}
case 487:{f.Push(f.Locals[10]);f.Pc=489;continue;}
case 489:{f.Push(JValue.L(0));f.Pc=490;continue;}
case 490:{return rt.Call(f,"forge/game/card/Card","addChangedSVars","(Ljava/util/Map;JJ)V","invokevirtual",493);}
case 493:{f.Pc=447;continue;}
case 496:{f.Push(JValue.R(rt.String("")));f.Pc=498;continue;}
case 498:{f.Locals[12]=f.Pop();f.Pc=500;continue;}
case 500:{f.Push(f.Locals[1]);f.Pc=501;continue;}
case 501:{f.Push(JValue.R(rt.String("Hand")));f.Pc=503;continue;}
case 503:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",506);}
case 506:{f.Pc=f.Pop().Int==0?517:509;continue;}
case 509:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ DelayTriggerRememberedLKI | Origin$ Battlefield | Destination$ Hand")));f.Pc=512;continue;}
case 512:{f.Locals[12]=f.Pop();f.Pc=514;continue;}
case 514:{f.Pc=604;continue;}
case 517:{f.Push(f.Locals[1]);f.Pc=518;continue;}
case 518:{f.Push(JValue.R(rt.String("Library")));f.Pc=521;continue;}
case 521:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",524);}
case 524:{f.Pc=f.Pop().Int==0?535:527;continue;}
case 527:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ DelayTriggerRememberedLKI | Origin$ Battlefield | Destination$ Library | Shuffle$ True")));f.Pc=530;continue;}
case 530:{f.Locals[12]=f.Pop();f.Pc=532;continue;}
case 532:{f.Pc=604;continue;}
case 535:{f.Push(f.Locals[1]);f.Pc=536;continue;}
case 536:{f.Push(JValue.R(rt.String("SacrificeCtrl")));f.Pc=539;continue;}
case 539:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",542);}
case 542:{f.Pc=f.Pop().Int==0?553:545;continue;}
case 545:{f.Push(JValue.R(rt.String("DB$ SacrificeAll | Defined$ DelayTriggerRememberedLKI")));f.Pc=548;continue;}
case 548:{f.Locals[12]=f.Pop();f.Pc=550;continue;}
case 550:{f.Pc=604;continue;}
case 553:{f.Push(f.Locals[1]);f.Pc=554;continue;}
case 554:{f.Push(JValue.R(rt.String("Sacrifice")));f.Pc=557;continue;}
case 557:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",560);}
case 560:{f.Pc=f.Pop().Int==0?571:563;continue;}
case 563:{f.Push(JValue.R(rt.String("DB$ SacrificeAll | Defined$ DelayTriggerRememberedLKI | Controller$ You")));f.Pc=566;continue;}
case 566:{f.Locals[12]=f.Pop();f.Pc=568;continue;}
case 568:{f.Pc=604;continue;}
case 571:{f.Push(f.Locals[1]);f.Pc=572;continue;}
case 572:{f.Push(JValue.R(rt.String("Exile")));f.Pc=575;continue;}
case 575:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",578);}
case 578:{f.Pc=f.Pop().Int==0?589:581;continue;}
case 581:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ DelayTriggerRememberedLKI | Origin$ Battlefield | Destination$ Exile")));f.Pc=584;continue;}
case 584:{f.Locals[12]=f.Pop();f.Pc=586;continue;}
case 586:{f.Pc=604;continue;}
case 589:{f.Push(f.Locals[1]);f.Pc=590;continue;}
case 590:{f.Push(JValue.R(rt.String("Destroy")));f.Pc=593;continue;}
case 593:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",596);}
case 596:{f.Pc=f.Pop().Int==0?604:599;continue;}
case 599:{f.Push(JValue.R(rt.String("DB$ Destroy | Defined$ DelayTriggerRememberedLKI")));f.Pc=602;continue;}
case 602:{f.Locals[12]=f.Pop();f.Pc=604;continue;}
case 604:{f.Push(f.Locals[0]);f.Pc=605;continue;}
case 605:{f.Push(JValue.R(rt.String("AtEOTCondition")));f.Pc=608;continue;}
case 608:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",611);}
case 611:{f.Pc=f.Pop().Int==0?634:614;continue;}
case 614:{f.Push(f.Locals[0]);f.Pc=615;continue;}
case 615:{f.Push(JValue.R(rt.String("AtEOTCondition")));f.Pc=618;continue;}
case 618:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",621);}
case 621:{f.Locals[13]=f.Pop();f.Pc=623;continue;}
case 623:{f.Push(f.Locals[12]);f.Pc=625;continue;}
case 625:{f.Push(f.Locals[13]);f.Pc=627;continue;}
case 627:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2950:627:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",632);}
case 632:{f.Locals[12]=f.Pop();f.Pc=634;continue;}
case 634:{f.Push(f.Locals[12]);f.Pc=636;continue;}
case 636:{f.Push(f.Locals[0]);f.Pc=637;continue;}
case 637:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",640);}
case 640:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",643);}
case 643:{f.Locals[13]=f.Pop();f.Pc=645;continue;}
case 645:{f.Push(f.Locals[13]);f.Pc=647;continue;}
case 647:{f.Push(f.Locals[3]);f.Pc=648;continue;}
case 648:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",651);}
case 651:{f.Push(f.Locals[9]);f.Pc=653;continue;}
case 653:{f.Push(f.Locals[13]);f.Pc=655;continue;}
case 655:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",658);}
case 658:{f.Push(f.Locals[9]);f.Pc=660;continue;}
case 660:{f.Push(f.Locals[0]);f.Pc=661;continue;}
case 661:{f.Push(f.Locals[0]);f.Pc=662;continue;}
case 662:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",665);}
case 665:{f.Push(JValue.I(1));f.Pc=666;continue;}
case 666:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",669);}
case 669:{return rt.Call(f,"forge/game/trigger/Trigger","setSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",672);}
case 672:{f.Push(f.Locals[9]);f.Pc=674;continue;}
case 674:{f.Push(f.Locals[9]);f.Pc=676;continue;}
case 676:{return rt.Call(f,"forge/game/trigger/Trigger","getSpawningAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",679);}
case 679:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",682);}
case 682:{return rt.Call(f,"forge/game/trigger/Trigger","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",685);}
case 685:{f.Push(f.Locals[0]);f.Pc=686;continue;}
case 686:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",689);}
case 689:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",692);}
case 692:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",695);}
case 695:{f.Push(f.Locals[9]);f.Pc=697;continue;}
case 697:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerDelayedTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",700);}
case 700:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2951(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{f.Locals[3]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String(" the ")));f.Pc=6;continue;}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("_")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?52:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("_")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[5]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=31;continue;}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=36;continue;}
case 36:{f.Locals[1]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("You")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?52:47;continue;}
case 47:{f.Push(JValue.R(rt.String(" your next ")));f.Pc=50;continue;}
case 50:{f.Locals[4]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",58);}
case 58:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2951:58:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",63);}
case 63:{f.Locals[5]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int!=0?82:72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2951:75:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",80);}
case 80:{f.Locals[5]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{f.Push(JValue.I(1));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",89);}
case 89:{f.Locals[6]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("")));f.Pc=93;continue;}
case 93:{f.Locals[7]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("Sacrifice")));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int==0?113:105;continue;}
case 105:{f.Push(JValue.R(rt.String("DB$ Sacrifice | SacValid$ Self")));f.Pc=108;continue;}
case 108:{f.Locals[7]=f.Pop();f.Pc=110;continue;}
case 110:{f.Pc=128;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("Exile")));f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int==0?128:123;continue;}
case 123:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Origin$ Battlefield | Destination$ Exile | Defined$ Self")));f.Pc=126;continue;}
case 126:{f.Locals[7]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[6]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[7]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[2]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",136);}
case 136:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",139);}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[6]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/card/Card","addTrigger","(Lforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;","invokevirtual",145);}
case 145:{f.StackOp("pop");f.Pc=146;continue;}
case 146:{f.Push(f.Locals[2]);f.Pc=147;continue;}
case 147:{f.Push(JValue.R(rt.String("EndOfTurnLeavePlay")));f.Pc=150;continue;}
case 150:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/util/Collections","singletonMap","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;","invokestatic",156);}
case 156:{f.Push(f.Locals[2]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",160);}
case 160:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",163);}
case 163:{f.Push(JValue.L(0));f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/card/Card","addChangedSVars","(Ljava/util/Map;JJ)V","invokevirtual",167);}
case 167:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2952(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self | Origin$ Command | Destination$ Exile")));f.Pc=3;continue;}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2953(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("DB$ Bookkeeping | ForgetObjects$ TriggeredCard")));f.Pc=3;continue;}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self | Origin$ Command | Destination$ Exile | ConditionDefined$ Remembered | ConditionPresent$ Card | ConditionCompare$ EQ0")));f.Pc=7;continue;}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",19);}
case 19:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=22;continue;}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",30);}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2954(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2954:1:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("Mode$ Exiled | ValidCard$ Card.IsRemembered | ValidCause$ SpellAbility.!EffectSourceAbility | TriggerZones$ Command | Static$ True")));f.Pc=10;continue;}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",25);}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getForgetSpellAbility","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",31);}
case 31:{f.Locals[6]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",40);}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[6]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",47);}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/card/Card","addTrigger","(Lforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;","invokevirtual",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/Card","addTrigger","(Lforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;","invokevirtual",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2955(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2955:1:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getForgetSpellAbility","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",19);}
case 19:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","addTrigger","(Lforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;","invokevirtual",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2956(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2956:1:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getExileSpellAbility","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",19);}
case 19:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","addTrigger","(Lforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;","invokevirtual",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2957(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Mode$ Countered | ValidCard$ Card.IsRemembered | TriggerZones$ Command | Static$ True")));f.Pc=3;continue;}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getExileSpellAbility","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",16);}
case 16:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","addTrigger","(Lforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;","invokevirtual",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2958(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Mode$ PhaseIn | ValidCard$ Card.IsRemembered | TriggerZones$ Command | Static$ True")));f.Pc=3;continue;}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getForgetSpellAbility","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",16);}
case 16:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","addTrigger","(Lforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;","invokevirtual",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2959(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2959:1:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getExileSpellAbility","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",19);}
case 19:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","addTrigger","(Lforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;","invokevirtual",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2960(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2960:1:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("Mode$ PhaseOut | TriggerZones$ Command | ValidCard$ Card.phasedOutIsRemembered | Static$ True")));f.Pc=10;continue;}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getForgetSpellAbility","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",15);}
case 15:{f.Locals[4]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",23);}
case 23:{f.Locals[5]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",31);}
case 31:{f.Locals[6]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",40);}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",47);}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/card/Card","addTrigger","(Lforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;","invokevirtual",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[6]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/Card","addTrigger","(Lforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;","invokevirtual",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2961(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Mode$ LosesGame | ValidPlayer$ You | TriggerController$ Player | TriggerZones$ Command | Static$ True")));f.Pc=3;continue;}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getExileSpellAbility","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",16);}
case 16:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","addTrigger","(Lforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;","invokevirtual",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2962(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",16);}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",20);}
case 20:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2962:20:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",25);}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;","invokestatic",32);}
case 32:{f.Locals[5]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[5]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","addLeaveBattlefieldReplacement","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",40);}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",46);}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","addExileOnMovedTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",54);}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?67:61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/Card","copyChangedTextFrom","(Lforge/game/card/Card;)V","invokevirtual",67);}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",72);}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",78);}
case 78:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2963(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2963:1:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2963:8:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",20);}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setLayer","(Lforge/game/replacement/ReplacementLayer;)V","invokevirtual",30);}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",37);}
case 37:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",40);}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","addReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2964(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;J)Lforge/game/card/Card;","invokestatic",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2965(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[7]=f.Pop();f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(f.Locals[7]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/Game","nextCardId","()I","invokevirtual",15);}
case 15:{f.Push(f.Locals[7]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/game/Game;)V","invokespecial",20);}
case 20:{f.Locals[8]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[8]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","setGameTimestamp","(J)V","invokevirtual",29);}
case 29:{f.Push(f.Locals[8]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","setName","(Ljava/lang/String;)V","invokevirtual",35);}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("Emblem")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?70:45;continue;}
case 45:{f.Push(f.Locals[8]);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(1));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/Card","setEmblem","(Z)V","invokevirtual",51);}
case 51:{f.Push(f.Locals[8]);f.Pc=53;continue;}
case 53:{if(!rt.StaticReady(f,"forge/card/ColorSet","C","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","C","Lforge/card/ColorSet;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/card/Card","setColor","(Lforge/card/ColorSet;)V","invokevirtual",59);}
case 59:{f.Push(f.Locals[8]);f.Pc=61;continue;}
case 61:{if(!rt.StaticReady(f,"forge/card/CardRarity","Common","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Common","Lforge/card/CardRarity;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/Card","setRarity","(Lforge/card/CardRarity;)V","invokevirtual",67);}
case 67:{f.Pc=88;continue;}
case 70:{f.Push(f.Locals[8]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",76);}
case 76:{return rt.Call(f,"forge/game/card/Card","setColor","(Lforge/card/ColorSet;)V","invokevirtual",79);}
case 79:{f.Push(f.Locals[8]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/card/Card","getRarity","()Lforge/card/CardRarity;","invokevirtual",85);}
case 85:{return rt.Call(f,"forge/game/card/Card","setRarity","(Lforge/card/CardRarity;)V","invokevirtual",88);}
case 88:{f.Push(f.Locals[8]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/Card","setOwner","(Lforge/game/player/Player;)V","invokevirtual",94);}
case 94:{f.Push(f.Locals[8]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",100);}
case 100:{return rt.Call(f,"forge/game/card/Card","setSetCode","(Ljava/lang/String;)V","invokevirtual",103);}
case 103:{f.Push(f.Locals[4]);f.Pc=105;continue;}
case 105:{f.Pc=f.Pop().Reference==null?115:108;continue;}
case 108:{f.Push(f.Locals[8]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[4]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/Card","setImageKey","(Ljava/lang/String;)V","invokevirtual",115);}
case 115:{f.Push(f.Locals[8]);f.Pc=117;continue;}
case 117:{if(!rt.StaticReady(f,"forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"));f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",123);}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{f.Pc=f.Pop().Reference==null?145:127;continue;}
case 127:{f.Push(f.Locals[8]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/card/Card","setEffectSource","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",133);}
case 133:{f.Push(f.Locals[8]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVars","()Ljava/util/Map;","invokevirtual",139);}
case 139:{return rt.Call(f,"forge/game/card/Card","setSVars","(Ljava/util/Map;)V","invokevirtual",142);}
case 142:{f.Pc=151;continue;}
case 145:{f.Push(f.Locals[8]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/card/Card","setEffectSource","(Lforge/game/card/Card;)V","invokevirtual",151);}
case 151:{f.Push(f.Locals[8]);f.Pc=153;continue;}
case 153:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2966(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ReplaceDyingDefined")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?20:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("ReplaceDyingValid")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?293:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("ReplaceDyingCondition")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?56:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("ReplaceDyingCondition")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Locals[1]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("Kicked")));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?56:48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKicked","()Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int!=0?56:55;continue;}
case 55:{return JStep.ReturnVoid;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",60);}
case 60:{f.Locals[1]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",65);}
case 65:{f.Locals[2]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",70);}
case 70:{f.Locals[3]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("ReplaceDyingZone")));f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("Exile")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",81);}
case 81:{f.Locals[4]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(JValue.R(null));f.Pc=84;continue;}
case 84:{f.Locals[5]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("ReplaceDyingDefined")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int==0?119:96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("ReplaceDyingDefined")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",104);}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",108);}
case 108:{f.Locals[5]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[5]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",115);}
case 115:{f.Pc=f.Pop().Int==0?119:118;continue;}
case 118:{return JStep.ReturnVoid;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",123);}
case 123:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2966:123:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",128);}
case 128:{f.Locals[6]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[6]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",138);}
case 138:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;","invokestatic",141);}
case 141:{f.Locals[7]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{f.Pc=f.Pop().Reference==null?155:148;continue;}
case 148:{f.Push(f.Locals[7]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[5]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",155);}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String("ReplaceDyingValid")));f.Pc=159;continue;}
case 159:{f.Push(JValue.R(rt.String("Card.IsRemembered")));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",165);}
case 165:{f.Locals[8]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[8]);f.Pc=169;continue;}
case 169:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2966:169:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",174);}
case 174:{f.Locals[9]=f.Pop();f.Pc=176;continue;}
case 176:{f.Push(f.Locals[4]);f.Pc=178;continue;}
case 178:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2966:178:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",183);}
case 183:{f.Locals[10]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String("ReplaceDyingExiledWith")));f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",192);}
case 192:{f.Pc=f.Pop().Int==0?204:195;continue;}
case 195:{f.Push(f.Locals[10]);f.Pc=197;continue;}
case 197:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2966:197:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",202);}
case 202:{f.Locals[10]=f.Pop();f.Pc=204;continue;}
case 204:{f.Push(f.Locals[9]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[7]);f.Pc=208;continue;}
case 208:{f.Push(JValue.I(1));f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",212);}
case 212:{f.Locals[11]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(f.Locals[11]);f.Pc=216;continue;}
case 216:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setLayer","(Lforge/game/replacement/ReplacementLayer;)V","invokevirtual",222);}
case 222:{f.Push(f.Locals[11]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[10]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[7]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",231);}
case 231:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",234);}
case 234:{f.Push(f.Locals[7]);f.Pc=236;continue;}
case 236:{f.Push(f.Locals[11]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/card/Card","addReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",241);}
case 241:{f.StackOp("pop");f.Pc=242;continue;}
case 242:{f.Push(f.Locals[5]);f.Pc=244;continue;}
case 244:{f.Pc=f.Pop().Reference==null?255:247;continue;}
case 247:{f.Push(f.Locals[7]);f.Pc=249;continue;}
case 249:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","addForgetOnMovedTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",255);}
case 255:{f.Push(f.Locals[0]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",259);}
case 259:{f.Pc=f.Pop().Int==0?268:262;continue;}
case 262:{f.Push(f.Locals[7]);f.Pc=264;continue;}
case 264:{f.Push(f.Locals[1]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/card/Card","copyChangedTextFrom","(Lforge/game/card/Card;)V","invokevirtual",268);}
case 268:{f.Push(f.Locals[3]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",272);}
case 272:{f.Push(f.Locals[3]);f.Pc=273;continue;}
case 273:{f.Push(f.Locals[7]);f.Pc=275;continue;}
case 275:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2966:275:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/GameCommand;",280);}
case 280:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",283);}
case 283:{f.Push(f.Locals[3]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",287);}
case 287:{f.Push(f.Locals[7]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[0]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",293);}
case 293:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2967(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",11);}
case 11:{f.Locals[5]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?31:20;continue;}
case 20:{f.Push(f.Locals[5]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",25);}
case 25:{return rt.Call(f,"forge/game/phase/PhaseHandler","inCombat","()Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int!=0?33:31;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{f.Locals[6]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[5]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",41);}
case 41:{f.Locals[7]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?248:51;continue;}
case 51:{f.Push(f.Locals[7]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/combat/Combat","getAttackingPlayer","()Lforge/game/player/Player;","invokevirtual",56);}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",60);}
case 60:{return rt.Call(f,"forge/game/player/Player","sharesTeamWith","(Lforge/game/player/Player;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?248:66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",71);}
case 71:{f.Locals[8]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(JValue.R(null));f.Pc=74;continue;}
case 74:{f.Locals[9]=f.Pop();f.Pc=76;continue;}
case 76:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=79;continue;}
case 79:{f.StackOp("dup");f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",83);}
case 83:{f.Locals[10]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[7]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/combat/Combat","initConstraints","()V","invokevirtual",90);}
case 90:{f.Push(JValue.R(rt.String("True")));f.Pc=92;continue;}
case 92:{f.Push(f.Locals[8]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",97);}
case 97:{f.Pc=f.Pop().Int==0?114:100;continue;}
case 100:{f.Push(f.Locals[10]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[7]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/combat/Combat","getDefenders","()Lforge/util/collect/FCollectionView;","invokevirtual",107);}
case 107:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",110);}
case 110:{f.StackOp("pop");f.Pc=111;continue;}
case 111:{f.Pc=147;continue;}
case 114:{f.Push(f.Locals[10]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{f.Push(JValue.R(rt.String("ForEach")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",123);}
case 123:{f.Pc=f.Pop().Int==0?130:126;continue;}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Pc=132;continue;}
case 130:{f.Push(f.Locals[4]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[8]);f.Pc=134;continue;}
case 134:{f.Push(JValue.R(rt.String(" & ")));f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",139);}
case 139:{f.Push(f.Locals[1]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;[Ljava/lang/String;Lforge/game/CardTraitBase;)Ljava/util/List;","invokestatic",143);}
case 143:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",146);}
case 146:{f.StackOp("pop");f.Pc=147;continue;}
case 147:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",150);}
case 150:{f.Locals[11]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[11]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("Attacker")));f.Pc=157;continue;}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",163);}
case 163:{f.StackOp("pop");f.Pc=164;continue;}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",168);}
case 168:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",171);}
case 171:{f.Push(f.Locals[10]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[1]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",177);}
case 177:{f.Push(JValue.R(rt.String("lblChooseDefenderToAttackWithCard")));f.Pc=180;continue;}
case 180:{f.Push(JValue.I(1));f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=184;continue;}
case 184:{f.StackOp("dup");f.Pc=185;continue;}
case 185:{f.Push(JValue.I(0));f.Pc=186;continue;}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",190);}
case 190:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",194);}
case 194:{f.Push(JValue.I(0));f.Pc=195;continue;}
case 195:{f.Push(f.Locals[11]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",200);}
case 200:{f.Locals[9]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[9]);f.Pc=204;continue;}
case 204:{f.Pc=f.Pop().Reference==null?248:207;continue;}
case 207:{f.Push(f.Locals[7]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[9]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/combat/Combat","getAttackersOf","(Lforge/game/GameEntity;)Lforge/game/card/CardCollection;","invokevirtual",214);}
case 214:{f.Push(f.Locals[0]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",218);}
case 218:{f.Pc=f.Pop().Int!=0?248:221;continue;}
case 221:{f.Push(f.Locals[7]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[0]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/combat/Combat","removeFromCombat","(Lforge/game/card/Card;)V","invokevirtual",227);}
case 227:{f.Push(f.Locals[7]);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[0]);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[9]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/combat/Combat","addAttacker","(Lforge/game/card/Card;Lforge/game/GameEntity;)V","invokevirtual",235);}
case 235:{f.Push(f.Locals[7]);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[0]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",241);}
case 241:{f.Push(JValue.I(0));f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/combat/AttackingBand","setBlocked","(Z)V","invokevirtual",245);}
case 245:{f.Push(JValue.I(1));f.Pc=246;continue;}
case 246:{f.Locals[6]=f.Pop();f.Pc=248;continue;}
case 248:{f.Push(f.Locals[1]);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[3]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",253);}
case 253:{f.Pc=f.Pop().Int==0?511:256;continue;}
case 256:{f.Push(f.Locals[4]);f.Pc=258;continue;}
case 258:{f.Push(f.Locals[1]);f.Pc=259;continue;}
case 259:{f.Push(f.Locals[3]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",263);}
case 263:{f.Push(f.Locals[1]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",267);}
case 267:{f.Push(JValue.R(null));f.Pc=268;continue;}
case 268:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",271);}
case 271:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=274;continue;}
case 274:{f.Locals[8]=f.Pop();f.Pc=276;continue;}
case 276:{f.Push(f.Locals[8]);f.Pc=278;continue;}
case 278:{f.Pc=f.Pop().Reference==null?511:281;continue;}
case 281:{f.Push(f.Locals[7]);f.Pc=283;continue;}
case 283:{f.Push(f.Locals[8]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/combat/Combat","getDefenderPlayerByAttacker","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",288);}
case 288:{f.Push(f.Locals[0]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",292);}
case 292:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",295);}
case 295:{f.Pc=f.Pop().Int==0?511:298;continue;}
case 298:{f.Push(f.Locals[7]);f.Pc=300;continue;}
case 300:{f.Push(f.Locals[8]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/combat/Combat","isBlocked","(Lforge/game/card/Card;)Z","invokevirtual",305);}
case 305:{f.Locals[9]=f.Pop();f.Pc=307;continue;}
case 307:{f.Push(f.Locals[7]);f.Pc=309;continue;}
case 309:{f.Push(f.Locals[8]);f.Pc=311;continue;}
case 311:{f.Push(f.Locals[0]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/combat/Combat","addBlocker","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",315);}
case 315:{f.Push(f.Locals[7]);f.Pc=317;continue;}
case 317:{f.Push(f.Locals[0]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/combat/Combat","orderAttackersForDamageAssignment","(Lforge/game/card/Card;)V","invokevirtual",321);}
case 321:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",324);}
case 324:{f.Locals[10]=f.Pop();f.Pc=326;continue;}
case 326:{f.Push(f.Locals[10]);f.Pc=328;continue;}
case 328:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=331;continue;}
case 331:{f.Push(f.Locals[8]);f.Pc=333;continue;}
case 333:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",338);}
case 338:{f.StackOp("pop");f.Pc=339;continue;}
case 339:{f.Push(f.Locals[10]);f.Pc=341;continue;}
case 341:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"));f.Pc=344;continue;}
case 344:{f.Push(f.Locals[0]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",350);}
case 350:{f.StackOp("pop");f.Pc=351;continue;}
case 351:{f.Push(f.Locals[5]);f.Pc=353;continue;}
case 353:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",356);}
case 356:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AttackerBlockedByCreature","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AttackerBlockedByCreature","Lforge/game/trigger/TriggerType;"));f.Pc=359;continue;}
case 359:{f.Push(f.Locals[10]);f.Pc=361;continue;}
case 361:{f.Push(JValue.I(0));f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",365);}
case 365:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",368);}
case 368:{f.Locals[10]=f.Pop();f.Pc=370;continue;}
case 370:{f.Push(f.Locals[10]);f.Pc=372;continue;}
case 372:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"));f.Pc=375;continue;}
case 375:{f.Push(f.Locals[8]);f.Pc=377;continue;}
case 377:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",382);}
case 382:{f.StackOp("pop");f.Pc=383;continue;}
case 383:{f.Push(f.Locals[5]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",388);}
case 388:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AttackerBlockedOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AttackerBlockedOnce","Lforge/game/trigger/TriggerType;"));f.Pc=391;continue;}
case 391:{f.Push(f.Locals[10]);f.Pc=393;continue;}
case 393:{f.Push(JValue.I(0));f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",397);}
case 397:{f.Push(f.Locals[9]);f.Pc=399;continue;}
case 399:{f.Pc=f.Pop().Int!=0?508:402;continue;}
case 402:{f.Push(f.Locals[7]);f.Pc=404;continue;}
case 404:{f.Push(f.Locals[8]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",409);}
case 409:{f.Locals[10]=f.Pop();f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",414);}
case 414:{f.Locals[11]=f.Pop();f.Pc=416;continue;}
case 416:{f.Push(f.Locals[11]);f.Pc=418;continue;}
case 418:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=421;continue;}
case 421:{f.Push(f.Locals[8]);f.Pc=423;continue;}
case 423:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",428);}
case 428:{f.StackOp("pop");f.Pc=429;continue;}
case 429:{f.Push(f.Locals[11]);f.Pc=431;continue;}
case 431:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Blockers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Blockers","Lforge/game/ability/AbilityKey;"));f.Pc=434;continue;}
case 434:{f.Push(f.Locals[10]);f.Pc=436;continue;}
case 436:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",441);}
case 441:{f.StackOp("pop");f.Pc=442;continue;}
case 442:{f.Push(f.Locals[11]);f.Pc=444;continue;}
case 444:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Defender","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Defender","Lforge/game/ability/AbilityKey;"));f.Pc=447;continue;}
case 447:{f.Push(f.Locals[7]);f.Pc=449;continue;}
case 449:{f.Push(f.Locals[8]);f.Pc=451;continue;}
case 451:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",454);}
case 454:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",459);}
case 459:{f.StackOp("pop");f.Pc=460;continue;}
case 460:{f.Push(f.Locals[11]);f.Pc=462;continue;}
case 462:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=465;continue;}
case 465:{f.Push(f.Locals[7]);f.Pc=467;continue;}
case 467:{f.Push(f.Locals[8]);f.Pc=469;continue;}
case 469:{return rt.Call(f,"forge/game/combat/Combat","getDefenderPlayerByAttacker","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",472);}
case 472:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",477);}
case 477:{f.StackOp("pop");f.Pc=478;continue;}
case 478:{f.Push(f.Locals[5]);f.Pc=480;continue;}
case 480:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",483);}
case 483:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AttackerBlocked","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AttackerBlocked","Lforge/game/trigger/TriggerType;"));f.Pc=486;continue;}
case 486:{f.Push(f.Locals[11]);f.Pc=488;continue;}
case 488:{f.Push(JValue.I(0));f.Pc=489;continue;}
case 489:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",492);}
case 492:{f.Push(f.Locals[7]);f.Pc=494;continue;}
case 494:{f.Push(f.Locals[8]);f.Pc=496;continue;}
case 496:{f.Push(JValue.I(1));f.Pc=497;continue;}
case 497:{return rt.Call(f,"forge/game/combat/Combat","setBlocked","(Lforge/game/card/Card;Z)V","invokevirtual",500);}
case 500:{f.Push(f.Locals[7]);f.Pc=502;continue;}
case 502:{f.Push(f.Locals[8]);f.Pc=504;continue;}
case 504:{f.Push(f.Locals[0]);f.Pc=505;continue;}
case 505:{return rt.Call(f,"forge/game/combat/Combat","addBlockerToDamageAssignmentOrder","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",508);}
case 508:{f.Push(JValue.I(1));f.Pc=509;continue;}
case 509:{f.Locals[6]=f.Pop();f.Pc=511;continue;}
case 511:{f.Push(f.Locals[6]);f.Pc=513;continue;}
case 513:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2968(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Duration")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?11:10;continue;}
case 10:{return JStep.ReturnVoid;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",20);}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/CardZoneTable","allCards","()Ljava/lang/Iterable;","invokevirtual",26);}
case 26:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","NON_TOKEN","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","NON_TOKEN","Ljava/util/function/Predicate;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",32);}
case 32:{return rt.Call(f,"forge/game/card/Card","addUntilLeavesBattlefield","(Ljava/lang/Iterable;)V","invokevirtual",35);}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",39);}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("ReturnAbility")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?74:51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",55);}
case 55:{f.Locals[5]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/Card","clearControllers","()V","invokevirtual",62);}
case 62:{f.Push(f.Locals[5]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",68);}
case 68:{return rt.Call(f,"forge/game/card/Card","setOwner","(Lforge/game/player/Player;)V","invokevirtual",71);}
case 71:{f.Pc=77;continue;}
case 74:{f.Push(JValue.R(null));f.Pc=75;continue;}
case 75:{f.Locals[5]=f.Pop();f.Pc=77;continue;}
case 77:{if(!rt.EnsureInitialized(f,"forge/game/ability/SpellAbilityEffect$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/SpellAbilityEffect$1")));f.Pc=80;continue;}
case 80:{f.StackOp("dup");f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[5]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect$1","<init>","(Lforge/game/card/Card;Lforge/game/Game;Lforge/game/card/CardZoneTable;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/trigger/TriggerHandler;)V","invokespecial",92);}
case 92:{f.Locals[6]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("Duration")));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",101);}
case 101:{f.Push(JValue.R(rt.String("UntilHostLeavesPlay")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int==0?127:110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int!=0?127:117;continue;}
case 117:{f.Push(f.Locals[6]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/GameCommand","run","()V","invokeinterface",124);}
case 124:{f.Pc=133;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[6]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;)V","invokestatic",133);}
case 133:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2969(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",3);}
case 3:{f.Locals[4]=f.Pop();f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Maps","newLinkedHashMap","()Ljava/util/LinkedHashMap;","invokestatic",8);}
case 8:{f.Locals[5]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",16);}
case 16:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",21);}
case 21:{f.Locals[6]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[6]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?199:33;continue;}
case 33:{f.Push(f.Locals[6]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[7]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[7]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[7]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",64);}
case 64:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/player/Player","getDiscardedThisTurn","()Ljava/util/List;","invokevirtual",70);}
case 70:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",73);}
case 73:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=82;continue;}
case 82:{f.StackOp("dup");f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",86);}
case 86:{f.Locals[8]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[7]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",95);}
case 95:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/card/CardCollectionView","threadSafeIterable","()Ljava/lang/Iterable;","invokeinterface",103);}
case 103:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",108);}
case 108:{f.Locals[9]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[9]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",117);}
case 117:{f.Pc=f.Pop().Int==0?176:120;continue;}
case 120:{f.Push(f.Locals[9]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",127);}
case 127:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=130;continue;}
case 130:{f.Locals[10]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[10]);f.Pc=134;continue;}
case 134:{f.Pc=f.Pop().Reference!=null?140:137;continue;}
case 137:{f.Pc=110;continue;}
case 140:{f.Push(f.Locals[7]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",147);}
case 147:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[10]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[0]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[3]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/player/Player","discard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/Card;","invokevirtual",158);}
case 158:{f.Locals[11]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[11]);f.Pc=162;continue;}
case 162:{f.Pc=f.Pop().Reference==null?173:165;continue;}
case 165:{f.Push(f.Locals[8]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[11]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",172);}
case 172:{f.StackOp("pop");f.Pc=173;continue;}
case 173:{f.Pc=110;continue;}
case 176:{f.Push(f.Locals[5]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[7]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",185);}
case 185:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[8]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",195);}
case 195:{f.StackOp("pop");f.Pc=196;continue;}
case 196:{f.Pc=23;continue;}
case 199:{f.Push(f.Locals[5]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",206);}
case 206:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",211);}
case 211:{f.Locals[6]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[6]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",220);}
case 220:{f.Pc=f.Pop().Int==0?383:223;continue;}
case 223:{f.Push(f.Locals[6]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",230);}
case 230:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=233;continue;}
case 233:{f.Locals[7]=f.Pop();f.Pc=235;continue;}
case 235:{f.Push(f.Locals[7]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",242);}
case 242:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",250);}
case 250:{f.Pc=f.Pop().Int!=0?380:253;continue;}
case 253:{f.Push(f.Locals[7]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",260);}
case 260:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",266);}
case 266:{f.Locals[8]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[8]);f.Pc=270;continue;}
case 270:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=273;continue;}
case 273:{f.Push(f.Locals[7]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",280);}
case 280:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",285);}
case 285:{f.StackOp("pop");f.Pc=286;continue;}
case 286:{f.Push(f.Locals[8]);f.Pc=288;continue;}
case 288:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=291;continue;}
case 291:{f.Push(f.Locals[0]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",297);}
case 297:{f.StackOp("pop");f.Pc=298;continue;}
case 298:{f.Push(f.Locals[8]);f.Pc=300;continue;}
case 300:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DiscardedBefore","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DiscardedBefore","Lforge/game/ability/AbilityKey;"));f.Pc=303;continue;}
case 303:{f.Push(f.Locals[4]);f.Pc=305;continue;}
case 305:{f.Push(f.Locals[7]);f.Pc=307;continue;}
case 307:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",312);}
case 312:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",317);}
case 317:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",322);}
case 322:{f.StackOp("pop");f.Pc=323;continue;}
case 323:{f.Push(f.Locals[3]);f.Pc=324;continue;}
case 324:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Random","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Random","Lforge/game/ability/AbilityKey;"));f.Pc=327;continue;}
case 327:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",332);}
case 332:{f.Pc=f.Pop().Int==0?355:335;continue;}
case 335:{f.Push(f.Locals[8]);f.Pc=337;continue;}
case 337:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Random","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Random","Lforge/game/ability/AbilityKey;"));f.Pc=340;continue;}
case 340:{f.Push(f.Locals[3]);f.Pc=341;continue;}
case 341:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Random","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Random","Lforge/game/ability/AbilityKey;"));f.Pc=344;continue;}
case 344:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",349);}
case 349:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",354);}
case 354:{f.StackOp("pop");f.Pc=355;continue;}
case 355:{f.Push(f.Locals[7]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",362);}
case 362:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=365;continue;}
case 365:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",368);}
case 368:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",371);}
case 371:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DiscardedAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DiscardedAll","Lforge/game/trigger/TriggerType;"));f.Pc=374;continue;}
case 374:{f.Push(f.Locals[8]);f.Pc=376;continue;}
case 376:{f.Push(JValue.I(0));f.Pc=377;continue;}
case 377:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",380);}
case 380:{f.Pc=213;continue;}
case 383:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2970(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;Lforge/game/player/Player;)V","invokestatic",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2971(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("Duration")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",9);}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;Ljava/lang/String;Lforge/game/player/Player;)V","invokestatic",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2972(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",11);}
case 11:{f.Locals[5]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","isLKI","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int!=0?43:21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Reference==null?43:29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",34);}
case 34:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?52:43;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",50);}
case 50:{f.Locals[4]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("UntilEndOfCombat")));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int==0?74:62;continue;}
case 62:{f.Push(f.Locals[5]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/Game","getEndOfCombat","()Lforge/game/phase/Phase;","invokevirtual",67);}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",71);}
case 71:{f.Pc=697;continue;}
case 74:{f.Push(JValue.R(rt.String("UntilEndOfCombatYourNextTurn")));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int==0?97:84;continue;}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/Game","getEndOfCombat","()Lforge/game/phase/Phase;","invokevirtual",89);}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/phase/Phase","registerUntilEnd","(Lforge/game/player/Player;Lforge/GameCommand;)V","invokevirtual",94);}
case 94:{f.Pc=697;continue;}
case 97:{f.Push(JValue.R(rt.String("UntilYourNextUpkeep")));f.Pc=100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int==0?120:107;continue;}
case 107:{f.Push(f.Locals[5]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/Game","getUpkeep","()Lforge/game/phase/Phase;","invokevirtual",112);}
case 112:{f.Push(f.Locals[3]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/game/player/Player;Lforge/GameCommand;)V","invokevirtual",117);}
case 117:{f.Pc=697;continue;}
case 120:{f.Push(JValue.R(rt.String("UntilTheEndOfYourNextUpkeep")));f.Pc=123;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int==0?170:130;continue;}
case 130:{f.Push(f.Locals[5]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",135);}
case 135:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/phase/PhaseHandler","is","(Lforge/game/phase/PhaseType;)Z","invokevirtual",141);}
case 141:{f.Pc=f.Pop().Int==0?157:144;continue;}
case 144:{f.Push(f.Locals[5]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/Game","getUpkeep","()Lforge/game/phase/Phase;","invokevirtual",149);}
case 149:{f.Push(f.Locals[3]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[1]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/phase/Phase","registerUntilEnd","(Lforge/game/player/Player;Lforge/GameCommand;)V","invokevirtual",154);}
case 154:{f.Pc=697;continue;}
case 157:{f.Push(f.Locals[5]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/Game","getUpkeep","()Lforge/game/phase/Phase;","invokevirtual",162);}
case 162:{f.Push(f.Locals[3]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[1]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/phase/Phase","addUntilEnd","(Lforge/game/player/Player;Lforge/GameCommand;)V","invokevirtual",167);}
case 167:{f.Pc=697;continue;}
case 170:{f.Push(JValue.R(rt.String("UntilTheEndOfYourNextUntap")));f.Pc=173;continue;}
case 173:{f.Push(f.Locals[2]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int==0?193:180;continue;}
case 180:{f.Push(f.Locals[5]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/Game","getUntap","()Lforge/game/phase/Untap;","invokevirtual",185);}
case 185:{f.Push(f.Locals[3]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[1]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/phase/Untap","addUntilEnd","(Lforge/game/player/Player;Lforge/GameCommand;)V","invokevirtual",190);}
case 190:{f.Pc=697;continue;}
case 193:{f.Push(JValue.R(rt.String("UntilNextEndStep")));f.Pc=196;continue;}
case 196:{f.Push(f.Locals[2]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",200);}
case 200:{f.Pc=f.Pop().Int==0?215:203;continue;}
case 203:{f.Push(f.Locals[5]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",208);}
case 208:{f.Push(f.Locals[1]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/phase/Phase","addAt","(Lforge/GameCommand;)V","invokevirtual",212);}
case 212:{f.Pc=697;continue;}
case 215:{f.Push(JValue.R(rt.String("UntilYourNextEndStep")));f.Pc=218;continue;}
case 218:{f.Push(f.Locals[2]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",222);}
case 222:{f.Pc=f.Pop().Int==0?238:225;continue;}
case 225:{f.Push(f.Locals[5]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",230);}
case 230:{f.Push(f.Locals[3]);f.Pc=231;continue;}
case 231:{f.Push(f.Locals[1]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/game/player/Player;Lforge/GameCommand;)V","invokevirtual",235);}
case 235:{f.Pc=697;continue;}
case 238:{f.Push(JValue.R(rt.String("UntilYourNextTurn")));f.Pc=241;continue;}
case 241:{f.Push(f.Locals[2]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",245);}
case 245:{f.Pc=f.Pop().Int==0?261:248;continue;}
case 248:{f.Push(f.Locals[5]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/Game","getCleanup","()Lforge/game/phase/Phase;","invokevirtual",253);}
case 253:{f.Push(f.Locals[3]);f.Pc=254;continue;}
case 254:{f.Push(f.Locals[1]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/game/player/Player;Lforge/GameCommand;)V","invokevirtual",258);}
case 258:{f.Pc=697;continue;}
case 261:{f.Push(JValue.R(rt.String("UntilTheEndOfYourNextTurn")));f.Pc=264;continue;}
case 264:{f.Push(f.Locals[2]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",268);}
case 268:{f.Pc=f.Pop().Int==0?309:271;continue;}
case 271:{f.Push(f.Locals[5]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",276);}
case 276:{f.Push(f.Locals[3]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",280);}
case 280:{f.Pc=f.Pop().Int==0?296:283;continue;}
case 283:{f.Push(f.Locals[5]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",288);}
case 288:{f.Push(f.Locals[3]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[1]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/phase/Phase","registerUntilEnd","(Lforge/game/player/Player;Lforge/GameCommand;)V","invokevirtual",293);}
case 293:{f.Pc=697;continue;}
case 296:{f.Push(f.Locals[5]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",301);}
case 301:{f.Push(f.Locals[3]);f.Pc=302;continue;}
case 302:{f.Push(f.Locals[1]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/phase/Phase","addUntilEnd","(Lforge/game/player/Player;Lforge/GameCommand;)V","invokevirtual",306);}
case 306:{f.Pc=697;continue;}
case 309:{f.Push(JValue.R(rt.String("UntilTheEndOfTargetedNextTurn")));f.Pc=312;continue;}
case 312:{f.Push(f.Locals[2]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",316);}
case 316:{f.Pc=f.Pop().Int==0?369:319;continue;}
case 319:{f.Push(f.Locals[0]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",323);}
case 323:{return rt.Call(f,"forge/game/spellability/TargetChoices","getFirstTargetedPlayer","()Lforge/game/player/Player;","invokevirtual",326);}
case 326:{f.Locals[6]=f.Pop();f.Pc=328;continue;}
case 328:{f.Push(f.Locals[5]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",333);}
case 333:{f.Push(f.Locals[6]);f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",338);}
case 338:{f.Pc=f.Pop().Int==0?355:341;continue;}
case 341:{f.Push(f.Locals[5]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",346);}
case 346:{f.Push(f.Locals[6]);f.Pc=348;continue;}
case 348:{f.Push(f.Locals[1]);f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/phase/Phase","registerUntilEnd","(Lforge/game/player/Player;Lforge/GameCommand;)V","invokevirtual",352);}
case 352:{f.Pc=366;continue;}
case 355:{f.Push(f.Locals[5]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",360);}
case 360:{f.Push(f.Locals[6]);f.Pc=362;continue;}
case 362:{f.Push(f.Locals[1]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/phase/Phase","addUntilEnd","(Lforge/game/player/Player;Lforge/GameCommand;)V","invokevirtual",366);}
case 366:{f.Pc=697;continue;}
case 369:{f.Push(JValue.R(rt.String("ThisTurnAndNextTurn")));f.Pc=372;continue;}
case 372:{f.Push(f.Locals[2]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",376);}
case 376:{f.Pc=f.Pop().Int==0?398:379;continue;}
case 379:{f.Push(f.Locals[5]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",384);}
case 384:{f.Push(f.Locals[5]);f.Pc=386;continue;}
case 386:{f.Push(f.Locals[1]);f.Pc=387;continue;}
case 387:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2972:387:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/GameCommand;)Lforge/GameCommand;",392);}
case 392:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",395);}
case 395:{f.Pc=697;continue;}
case 398:{f.Push(JValue.R(rt.String("UntilStateBasedActionChecked")));f.Pc=401;continue;}
case 401:{f.Push(f.Locals[2]);f.Pc=402;continue;}
case 402:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",405);}
case 405:{f.Pc=f.Pop().Int==0?417:408;continue;}
case 408:{f.Push(f.Locals[5]);f.Pc=410;continue;}
case 410:{f.Push(f.Locals[1]);f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/game/Game","addSBACheckedCommand","(Lforge/GameCommand;)V","invokevirtual",414);}
case 414:{f.Pc=697;continue;}
case 417:{f.Push(JValue.R(rt.String("UntilHostLeavesPlay")));f.Pc=420;continue;}
case 420:{f.Push(f.Locals[2]);f.Pc=421;continue;}
case 421:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",424);}
case 424:{f.Pc=f.Pop().Int==0?436:427;continue;}
case 427:{f.Push(f.Locals[4]);f.Pc=429;continue;}
case 429:{f.Push(f.Locals[1]);f.Pc=430;continue;}
case 430:{return rt.Call(f,"forge/game/card/Card","addLeavesPlayCommand","(Lforge/GameCommand;)V","invokevirtual",433);}
case 433:{f.Pc=697;continue;}
case 436:{f.Push(JValue.R(rt.String("UntilHostLeavesPlayOrEOT")));f.Pc=439;continue;}
case 439:{f.Push(f.Locals[2]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",443);}
case 443:{f.Pc=f.Pop().Int==0?464:446;continue;}
case 446:{f.Push(f.Locals[4]);f.Pc=448;continue;}
case 448:{f.Push(f.Locals[1]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/game/card/Card","addLeavesPlayCommand","(Lforge/GameCommand;)V","invokevirtual",452);}
case 452:{f.Push(f.Locals[5]);f.Pc=454;continue;}
case 454:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",457);}
case 457:{f.Push(f.Locals[1]);f.Pc=458;continue;}
case 458:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",461);}
case 461:{f.Pc=697;continue;}
case 464:{f.Push(JValue.R(rt.String("UntilHostLeavesPlayOrEndOfCombat")));f.Pc=467;continue;}
case 467:{f.Push(f.Locals[2]);f.Pc=468;continue;}
case 468:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",471);}
case 471:{f.Pc=f.Pop().Int==0?492:474;continue;}
case 474:{f.Push(f.Locals[4]);f.Pc=476;continue;}
case 476:{f.Push(f.Locals[1]);f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/game/card/Card","addLeavesPlayCommand","(Lforge/GameCommand;)V","invokevirtual",480);}
case 480:{f.Push(f.Locals[5]);f.Pc=482;continue;}
case 482:{return rt.Call(f,"forge/game/Game","getEndOfCombat","()Lforge/game/phase/Phase;","invokevirtual",485);}
case 485:{f.Push(f.Locals[1]);f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",489);}
case 489:{f.Pc=697;continue;}
case 492:{f.Push(JValue.R(rt.String("UntilLoseControlOfHost")));f.Pc=495;continue;}
case 495:{f.Push(f.Locals[2]);f.Pc=496;continue;}
case 496:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",499);}
case 499:{f.Pc=f.Pop().Int==0?517:502;continue;}
case 502:{f.Push(f.Locals[4]);f.Pc=504;continue;}
case 504:{f.Push(f.Locals[1]);f.Pc=505;continue;}
case 505:{return rt.Call(f,"forge/game/card/Card","addLeavesPlayCommand","(Lforge/GameCommand;)V","invokevirtual",508);}
case 508:{f.Push(f.Locals[4]);f.Pc=510;continue;}
case 510:{f.Push(f.Locals[1]);f.Pc=511;continue;}
case 511:{return rt.Call(f,"forge/game/card/Card","addChangeControllerCommand","(Lforge/GameCommand;)V","invokevirtual",514);}
case 514:{f.Pc=697;continue;}
case 517:{f.Push(JValue.R(rt.String("AsLongAsControl")));f.Pc=520;continue;}
case 520:{f.Push(f.Locals[2]);f.Pc=521;continue;}
case 521:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",524);}
case 524:{f.Pc=f.Pop().Int==0?548:527;continue;}
case 527:{f.Push(f.Locals[4]);f.Pc=529;continue;}
case 529:{f.Push(f.Locals[1]);f.Pc=530;continue;}
case 530:{return rt.Call(f,"forge/game/card/Card","addLeavesPlayCommand","(Lforge/GameCommand;)V","invokevirtual",533);}
case 533:{f.Push(f.Locals[4]);f.Pc=535;continue;}
case 535:{f.Push(f.Locals[1]);f.Pc=536;continue;}
case 536:{return rt.Call(f,"forge/game/card/Card","addChangeControllerCommand","(Lforge/GameCommand;)V","invokevirtual",539);}
case 539:{f.Push(f.Locals[4]);f.Pc=541;continue;}
case 541:{f.Push(f.Locals[1]);f.Pc=542;continue;}
case 542:{return rt.Call(f,"forge/game/card/Card","addPhaseOutCommand","(Lforge/GameCommand;)V","invokevirtual",545);}
case 545:{f.Pc=697;continue;}
case 548:{f.Push(JValue.R(rt.String("AsLongAsInPlay")));f.Pc=551;continue;}
case 551:{f.Push(f.Locals[2]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",555);}
case 555:{f.Pc=f.Pop().Int==0?573:558;continue;}
case 558:{f.Push(f.Locals[4]);f.Pc=560;continue;}
case 560:{f.Push(f.Locals[1]);f.Pc=561;continue;}
case 561:{return rt.Call(f,"forge/game/card/Card","addLeavesPlayCommand","(Lforge/GameCommand;)V","invokevirtual",564);}
case 564:{f.Push(f.Locals[4]);f.Pc=566;continue;}
case 566:{f.Push(f.Locals[1]);f.Pc=567;continue;}
case 567:{return rt.Call(f,"forge/game/card/Card","addPhaseOutCommand","(Lforge/GameCommand;)V","invokevirtual",570);}
case 570:{f.Pc=697;continue;}
case 573:{f.Push(JValue.R(rt.String("UntilUntaps")));f.Pc=576;continue;}
case 576:{f.Push(f.Locals[2]);f.Pc=577;continue;}
case 577:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",580);}
case 580:{f.Pc=f.Pop().Int==0?604:583;continue;}
case 583:{f.Push(f.Locals[4]);f.Pc=585;continue;}
case 585:{f.Push(f.Locals[1]);f.Pc=586;continue;}
case 586:{return rt.Call(f,"forge/game/card/Card","addLeavesPlayCommand","(Lforge/GameCommand;)V","invokevirtual",589);}
case 589:{f.Push(f.Locals[4]);f.Pc=591;continue;}
case 591:{f.Push(f.Locals[1]);f.Pc=592;continue;}
case 592:{return rt.Call(f,"forge/game/card/Card","addUntapCommand","(Lforge/GameCommand;)V","invokevirtual",595);}
case 595:{f.Push(f.Locals[4]);f.Pc=597;continue;}
case 597:{f.Push(f.Locals[1]);f.Pc=598;continue;}
case 598:{return rt.Call(f,"forge/game/card/Card","addPhaseOutCommand","(Lforge/GameCommand;)V","invokevirtual",601);}
case 601:{f.Pc=697;continue;}
case 604:{f.Push(JValue.R(rt.String("UntilTargetedUntaps")));f.Pc=607;continue;}
case 607:{f.Push(f.Locals[2]);f.Pc=608;continue;}
case 608:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",611);}
case 611:{f.Pc=f.Pop().Int==0?638:614;continue;}
case 614:{f.Push(f.Locals[0]);f.Pc=615;continue;}
case 615:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSATargetingCard","()Lforge/game/spellability/SpellAbility;","invokevirtual",618);}
case 618:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetCard","()Lforge/game/card/Card;","invokevirtual",621);}
case 621:{f.Locals[6]=f.Pop();f.Pc=623;continue;}
case 623:{f.Push(f.Locals[6]);f.Pc=625;continue;}
case 625:{f.Push(f.Locals[1]);f.Pc=626;continue;}
case 626:{return rt.Call(f,"forge/game/card/Card","addLeavesPlayCommand","(Lforge/GameCommand;)V","invokevirtual",629);}
case 629:{f.Push(f.Locals[6]);f.Pc=631;continue;}
case 631:{f.Push(f.Locals[1]);f.Pc=632;continue;}
case 632:{return rt.Call(f,"forge/game/card/Card","addUntapCommand","(Lforge/GameCommand;)V","invokevirtual",635);}
case 635:{f.Pc=697;continue;}
case 638:{f.Push(JValue.R(rt.String("UntilUnattached")));f.Pc=641;continue;}
case 641:{f.Push(f.Locals[2]);f.Pc=642;continue;}
case 642:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",645);}
case 645:{f.Pc=f.Pop().Int==0?669:648;continue;}
case 648:{f.Push(f.Locals[4]);f.Pc=650;continue;}
case 650:{f.Push(f.Locals[1]);f.Pc=651;continue;}
case 651:{return rt.Call(f,"forge/game/card/Card","addLeavesPlayCommand","(Lforge/GameCommand;)V","invokevirtual",654);}
case 654:{f.Push(f.Locals[4]);f.Pc=656;continue;}
case 656:{f.Push(f.Locals[1]);f.Pc=657;continue;}
case 657:{return rt.Call(f,"forge/game/card/Card","addUnattachCommand","(Lforge/GameCommand;)V","invokevirtual",660);}
case 660:{f.Push(f.Locals[4]);f.Pc=662;continue;}
case 662:{f.Push(f.Locals[1]);f.Pc=663;continue;}
case 663:{return rt.Call(f,"forge/game/card/Card","addPhaseOutCommand","(Lforge/GameCommand;)V","invokevirtual",666);}
case 666:{f.Pc=697;continue;}
case 669:{f.Push(JValue.R(rt.String("UntilFacedown")));f.Pc=672;continue;}
case 672:{f.Push(f.Locals[2]);f.Pc=673;continue;}
case 673:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",676);}
case 676:{f.Pc=f.Pop().Int==0?688:679;continue;}
case 679:{f.Push(f.Locals[4]);f.Pc=681;continue;}
case 681:{f.Push(f.Locals[1]);f.Pc=682;continue;}
case 682:{return rt.Call(f,"forge/game/card/Card","addFacedownCommand","(Lforge/GameCommand;)V","invokevirtual",685);}
case 685:{f.Pc=697;continue;}
case 688:{f.Push(f.Locals[5]);f.Pc=690;continue;}
case 690:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",693);}
case 693:{f.Push(f.Locals[1]);f.Pc=694;continue;}
case 694:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",697);}
case 697:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2973(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("UntilHostLeavesPlay")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int!=0?61:21;continue;}
case 21:{f.Push(JValue.R(rt.String("UntilLoseControlOfHost")));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int!=0?61:31;continue;}
case 31:{f.Push(JValue.R(rt.String("UntilUntaps")));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int!=0?61:41;continue;}
case 41:{f.Push(JValue.R(rt.String("AsLongAsControl")));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int!=0?61:51;continue;}
case 51:{f.Push(JValue.R(rt.String("AsLongAsInPlay")));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?80:61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int!=0?80:68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",75);}
case 75:{f.Pc=f.Pop().Int!=0?80:78;continue;}
case 78:{f.Push(JValue.I(0));f.Pc=79;continue;}
case 79:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 80:{f.Push(JValue.R(rt.String("AsLongAsControl")));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int!=0?100:90;continue;}
case 90:{f.Push(JValue.R(rt.String("AsLongAsInPlay")));f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",97);}
case 97:{f.Pc=f.Pop().Int==0?109:100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int==0?109:107;continue;}
case 107:{f.Push(JValue.I(0));f.Pc=108;continue;}
case 108:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 109:{f.Push(JValue.R(rt.String("UntilLoseControlOfHost")));f.Pc=112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",116);}
case 116:{f.Pc=f.Pop().Int!=0?129:119;continue;}
case 119:{f.Push(JValue.R(rt.String("AsLongAsControl")));f.Pc=122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int==0?142:129;continue;}
case 129:{f.Push(f.Locals[2]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",133);}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",137);}
case 137:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?142:140;continue;}
case 140:{f.Push(JValue.I(0));f.Pc=141;continue;}
case 141:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 142:{f.Push(JValue.R(rt.String("UntilUntaps")));f.Pc=145;continue;}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",149);}
case 149:{f.Pc=f.Pop().Int==0?161:152;continue;}
case 152:{f.Push(f.Locals[2]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/card/Card","isTapped","()Z","invokevirtual",156);}
case 156:{f.Pc=f.Pop().Int!=0?161:159;continue;}
case 159:{f.Push(JValue.I(0));f.Pc=160;continue;}
case 160:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 161:{f.Push(JValue.R(rt.String("UntilTargetedUntaps")));f.Pc=164;continue;}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("Duration")));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",171);}
case 171:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",174);}
case 174:{f.Pc=f.Pop().Int==0?201:177;continue;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSATargetingCard","()Lforge/game/spellability/SpellAbility;","invokevirtual",181);}
case 181:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetCard","()Lforge/game/card/Card;","invokevirtual",184);}
case 184:{f.Locals[3]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[3]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/card/Card","isTapped","()Z","invokevirtual",189);}
case 189:{f.Pc=f.Pop().Int==0?199:192;continue;}
case 192:{f.Push(f.Locals[3]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",196);}
case 196:{f.Pc=f.Pop().Int==0?201:199;continue;}
case 199:{f.Push(JValue.I(0));f.Pc=200;continue;}
case 200:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 201:{f.Push(JValue.I(1));f.Pc=202;continue;}
case 202:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2974(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/player/Player","isOpponentOf","(Lforge/game/player/Player;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?21:13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/player/Player","getOpponents","()Lforge/game/player/PlayerCollection;","invokevirtual",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Pc=26;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/player/Player","getAllOtherPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",30);}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",35);}
case 35:{f.Push(JValue.R(rt.String("lblChoosePlayer")));f.Pc=38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Push(JValue.R(null));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2975(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?34:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",31);}
case 31:{f.Pc=7;continue;}
case 34:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2976(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;)V","invokestatic",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2977(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("ExiledWithEffectSource")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?23:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?46:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","isLKI","()Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?46:37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",41);}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",45);}
case 45:{f.Locals[2]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int!=0?80:53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int!=0?80:60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int!=0?80:70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int==0?90:80;continue;}
case 80:{f.Push(f.Locals[2]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/card/Card","removeExiledCard","(Lforge/game/card/Card;)V","invokevirtual",85);}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/card/Card","addExiledCard","(Lforge/game/card/Card;)V","invokevirtual",90);}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCopiedTrait","()Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?105:97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",101);}
case 101:{f.Locals[2]=f.Pop();f.Pc=102;continue;}
case 102:{f.Pc=144;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int!=0?144:112;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",116);}
case 116:{f.Pc=f.Pop().Reference==null?144:119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",123);}
case 123:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",128);}
case 128:{f.Pc=f.Pop().Reference==null?144:131;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",135);}
case 135:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",140);}
case 140:{return rt.Call(f,"forge/game/staticability/StaticAbility","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",143);}
case 143:{f.Locals[2]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[2]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/card/Card","setExiledWith","(Lforge/game/card/Card;)V","invokevirtual",149);}
case 149:{f.Push(f.Locals[1]);f.Pc=150;continue;}
case 150:{f.Push(JValue.R(rt.String("DefinedExiler")));f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",156);}
case 156:{f.Pc=f.Pop().Int==0?176:159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("DefinedExiler")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;","invokestatic",166);}
case 166:{f.Push(JValue.I(0));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",170);}
case 170:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=173;continue;}
case 173:{f.Pc=180;continue;}
case 176:{f.Push(f.Locals[1]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",180);}
case 180:{f.Locals[3]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[0]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[3]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/card/Card","setExiledBy","(Lforge/game/player/Player;)V","invokevirtual",186);}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[1]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/card/Card","setExiledSA","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",191);}
case 191:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2978(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(-1));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",11);}
case 11:{switch(f.Pop().Int){case -1530111618:f.Pc=36;break;case -54261774:f.Pc=51;break;default:f.Pc=63;break;}continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("lambda$replaceDying$f894d637$1")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int==0?63:46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{f.Locals[2]=f.Pop();f.Pc=48;continue;}
case 48:{f.Pc=63;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("lambda$addUntilCommand$9c2e65b8$1")));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?63:61;continue;}
case 61:{f.Push(JValue.I(1));f.Pc=62;continue;}
case 62:{f.Locals[2]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{switch(f.Pop().Int){case 0:f.Pc=92;break;case 1:f.Pc=188;break;default:f.Pc=284;break;}continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodKind","()I","invokevirtual",96);}
case 96:{f.Push(JValue.I(6));f.Pc=98;continue;}
case 98:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?284:101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceClass","()Ljava/lang/String;","invokevirtual",105);}
case 105:{f.Push(JValue.R(rt.String("forge/GameCommand")));f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",111);}
case 111:{f.Pc=f.Pop().Int==0?284:114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodName","()Ljava/lang/String;","invokevirtual",118);}
case 118:{f.Push(JValue.R(rt.String("run")));f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",124);}
case 124:{f.Pc=f.Pop().Int==0?284:127;continue;}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodSignature","()Ljava/lang/String;","invokevirtual",131);}
case 131:{f.Push(JValue.R(rt.String("()V")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",137);}
case 137:{f.Pc=f.Pop().Int==0?284:140;continue;}
case 140:{f.Push(f.Locals[0]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplClass","()Ljava/lang/String;","invokevirtual",144);}
case 144:{f.Push(JValue.R(rt.String("forge/game/ability/SpellAbilityEffect")));f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int==0?284:153;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodSignature","()Ljava/lang/String;","invokevirtual",157);}
case 157:{f.Push(JValue.R(rt.String("(Lforge/game/Game;Lforge/game/card/Card;)V")));f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",163);}
case 163:{f.Pc=f.Pop().Int==0?284:166;continue;}
case 166:{f.Push(f.Locals[0]);f.Pc=167;continue;}
case 167:{f.Push(JValue.I(0));f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",171);}
case 171:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/Game"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{f.Push(JValue.I(1));f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",179);}
case 179:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=182;continue;}
case 182:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2978:182:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/GameCommand;",187);}
case 187:{return JStep.Return(f.Pop());}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodKind","()I","invokevirtual",192);}
case 192:{f.Push(JValue.I(6));f.Pc=194;continue;}
case 194:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?284:197;continue;}
case 197:{f.Push(f.Locals[0]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceClass","()Ljava/lang/String;","invokevirtual",201);}
case 201:{f.Push(JValue.R(rt.String("forge/GameCommand")));f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",207);}
case 207:{f.Pc=f.Pop().Int==0?284:210;continue;}
case 210:{f.Push(f.Locals[0]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodName","()Ljava/lang/String;","invokevirtual",214);}
case 214:{f.Push(JValue.R(rt.String("run")));f.Pc=217;continue;}
case 217:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",220);}
case 220:{f.Pc=f.Pop().Int==0?284:223;continue;}
case 223:{f.Push(f.Locals[0]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodSignature","()Ljava/lang/String;","invokevirtual",227);}
case 227:{f.Push(JValue.R(rt.String("()V")));f.Pc=230;continue;}
case 230:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",233);}
case 233:{f.Pc=f.Pop().Int==0?284:236;continue;}
case 236:{f.Push(f.Locals[0]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplClass","()Ljava/lang/String;","invokevirtual",240);}
case 240:{f.Push(JValue.R(rt.String("forge/game/ability/SpellAbilityEffect")));f.Pc=243;continue;}
case 243:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",246);}
case 246:{f.Pc=f.Pop().Int==0?284:249;continue;}
case 249:{f.Push(f.Locals[0]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodSignature","()Ljava/lang/String;","invokevirtual",253);}
case 253:{f.Push(JValue.R(rt.String("(Lforge/game/Game;Lforge/GameCommand;)V")));f.Pc=256;continue;}
case 256:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",259);}
case 259:{f.Pc=f.Pop().Int==0?284:262;continue;}
case 262:{f.Push(f.Locals[0]);f.Pc=263;continue;}
case 263:{f.Push(JValue.I(0));f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",267);}
case 267:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/Game"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=270;continue;}
case 270:{f.Push(f.Locals[0]);f.Pc=271;continue;}
case 271:{f.Push(JValue.I(1));f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",275);}
case 275:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/GameCommand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=278;continue;}
case 278:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect:2978:278:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/GameCommand;)Lforge/GameCommand;",283);}
case 283:{return JStep.Return(f.Pop());}
case 284:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=287;continue;}
case 287:{f.StackOp("dup");f.Pc=288;continue;}
case 288:{f.Push(JValue.R(rt.String("Invalid lambda deserialization")));f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",294);}
case 294:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2979(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2980(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameAction","exileEffect","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",8);}
case 8:{f.StackOp("pop");f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2981(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("(?s)If [^.]*\\.")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",6);}
case 6:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","IF_CONDITION_SENTENCE","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/game/ability/SpellAbilityEffect","IF_CONDITION_SENTENCE","Ljava/util/regex/Pattern;",f.Pop());f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("[,\\s]*")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",15);}
case 15:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","EMPTY_SPELL_DESCRIPTION","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/game/ability/SpellAbilityEffect","EMPTY_SPELL_DESCRIPTION","Ljava/util/regex/Pattern;",f.Pop());f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("\\s*\\([^)]*\\)")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",24);}
case 24:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","REMOVE_REMINDER_TEXT","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/game/ability/SpellAbilityEffect","REMOVE_REMINDER_TEXT","Ljava/util/regex/Pattern;",f.Pop());f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("(?s)(?:then|otherwise|instead|and|or|if|unless|when|whenever|as|until|for|at|during|while|after|before)\\b.*")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",33);}
case 33:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","CONDITION_CONTINUATION","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/game/ability/SpellAbilityEffect","CONDITION_CONTINUATION","Ljava/util/regex/Pattern;",f.Pop());f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("^(.*? \\(\\d+\\) - )([a-z])")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",42);}
case 42:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","STACK_CARD_PRELUDE","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/game/ability/SpellAbilityEffect","STACK_CARD_PRELUDE","Ljava/util/regex/Pattern;",f.Pop());f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("^(\\s*)([A-Z])((?:oll|raw|reate|ut|ap|ntap|estroy|xile|eturn|acrifice|iscard|ain|ose|cry|urveil|ill|eveal|earch|huffle|dd|hoose|ook|ttach|ight|nvestigate|roliferate|xplore|onnive|oad|egenerate|ounter|opy|eal)\\b.*)$")));f.Pc=48;continue;}
case 48:{f.Push(JValue.I(32));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",53);}
case 53:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","CONTINUING_VERB","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/game/ability/SpellAbilityEffect","CONTINUING_VERB","Ljava/util/regex/Pattern;",f.Pop());f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String(",{3,}")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",62);}
case 62:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","TIDY_COMMA_RUN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/game/ability/SpellAbilityEffect","TIDY_COMMA_RUN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("(\\w)\\(s\\)")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",71);}
case 71:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","TIDY_OPTIONAL_PLURAL","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/game/ability/SpellAbilityEffect","TIDY_OPTIONAL_PLURAL","Ljava/util/regex/Pattern;",f.Pop());f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("(?<!\\.)\\.\\.(?!\\.)")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",80);}
case 80:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","TIDY_DOUBLE_PERIOD","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/game/ability/SpellAbilityEffect","TIDY_DOUBLE_PERIOD","Ljava/util/regex/Pattern;",f.Pop());f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("(?<=[a-z]{2}[.!?])(?=[A-Z][a-z]+ [a-z])")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",89);}
case 89:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","TIDY_SENTENCE_SPACE","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/game/ability/SpellAbilityEffect","TIDY_SENTENCE_SPACE","Ljava/util/regex/Pattern;",f.Pop());f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String("[ \\t]*\\r?\\n[ \\t]*")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",98);}
case 98:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","TIDY_NEWLINES","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/game/ability/SpellAbilityEffect","TIDY_NEWLINES","Ljava/util/regex/Pattern;",f.Pop());f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("[ \\t]{2,}")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",107);}
case 107:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","TIDY_DOUBLE_SPACES","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/game/ability/SpellAbilityEffect","TIDY_DOUBLE_SPACES","Ljava/util/regex/Pattern;",f.Pop());f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String(" +([.,;:!?])")));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",116);}
case 116:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","TIDY_PUNCTUATION_SPACE","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/game/ability/SpellAbilityEffect","TIDY_PUNCTUATION_SPACE","Ljava/util/regex/Pattern;",f.Pop());f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("\\b([Tt]hen|[Aa]nd) \\1\\b")));f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",125);}
case 125:{if(!rt.StaticReady(f,"forge/game/ability/SpellAbilityEffect","TIDY_DUPLICATE_CONJUNCTION","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/game/ability/SpellAbilityEffect","TIDY_DUPLICATE_CONJUNCTION","Ljava/util/regex/Pattern;",f.Pop());f.Pc=128;continue;}
case 128:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
