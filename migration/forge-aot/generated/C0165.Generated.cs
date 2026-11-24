// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C165{
internal static JClass Build(){var c=new JClass("forge/game/GameState","java/lang/Object",new string[]{},33);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("ZONES","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("playerStates","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("puzzleCreatorState","Z",false,JValue.Default("Z"),null));
c.Add(new JField("idToCard","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cardToAttachId","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cardToEnchantPlayerId","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("markedDamage","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cardToChosenClrs","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cardToChosenCards","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cardToChosenType","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cardToChosenType2","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cardToRememberedId","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cardToImprintedId","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cardToMergedCards","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cardToNamedCard","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cardToExiledWithId","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cardAttackMap","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cardToScript","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("abilityString","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cardsReferencedByID","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("cardsWithoutETBTrigs","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("tChangePlayer","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("tChangePhase","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("tAdvancePhase","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("turn","I",false,JValue.Default("I"),null));
c.Add(new JField("removeSummoningSickness","Z",false,JValue.Default("Z"),null));
c.Add(new JField("TARGET_NONE","I",false,JValue.I(-1),null));
c.Add(new JField("TARGET_HUMAN","I",false,JValue.I(-2),null));
c.Add(new JField("TARGET_AI","I",false,JValue.I(-3),null));
c.Add(new JField("TOKEN_PIPE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"%7C"));
c.Add(new JField("LEGACY_TOKEN_IMAGE","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JMethod(2581,"forge/game/GameState","<init>","()V",1,1,3,new JHandler[]{},M2581));
c.Add(new JMethod(2582,"forge/game/GameState","toString","()Ljava/lang/String;",1,6,5,new JHandler[]{},M2582));
c.Add(new JMethod(2583,"forge/game/GameState","appendCards","(Ljava/util/Map;Ljava/lang/String;Ljava/lang/StringBuilder;)V",2,6,6,new JHandler[]{},M2583));
c.Add(new JMethod(2584,"forge/game/GameState","initFromGame","(Lforge/game/Game;)V",1,8,4,new JHandler[]{},M2584));
c.Add(new JMethod(2585,"forge/game/GameState","getPlayerString","(Lforge/game/player/Player;)Ljava/lang/String;",2,2,2,new JHandler[]{},M2585));
c.Add(new JMethod(2586,"forge/game/GameState","parsePlayerString","(Lforge/game/Game;Ljava/lang/String;)Lforge/game/player/Player;",2,3,3,new JHandler[]{},M2586));
c.Add(new JMethod(2587,"forge/game/GameState","protectTokenImageKey","(Ljava/lang/String;)Ljava/lang/String;",10,3,4,new JHandler[]{},M2587));
c.Add(new JMethod(2588,"forge/game/GameState","addCard","(Lforge/game/zone/ZoneType;Ljava/util/Map;Lforge/game/card/Card;)V",2,11,4,new JHandler[]{},M2588));
c.Add(new JMethod(2589,"forge/game/GameState","countersToString","(Lcom/google/common/collect/Multiset;)Ljava/lang/String;",2,6,5,new JHandler[]{},M2589));
c.Add(new JMethod(2590,"forge/game/GameState","splitLine","(Ljava/lang/String;)[Ljava/lang/String;",2,3,5,new JHandler[]{},M2590));
c.Add(new JMethod(2591,"forge/game/GameState","parse","(Ljava/io/InputStream;)V",1,3,5,new JHandler[]{},M2591));
c.Add(new JMethod(2592,"forge/game/GameState","parse","(Ljava/util/List;)V",1,2,2,new JHandler[]{},M2592));
c.Add(new JMethod(2593,"forge/game/GameState","parse","(Ljava/util/stream/Stream;)V",1,2,2,new JHandler[]{},M2593));
c.Add(new JMethod(2594,"forge/game/GameState","getPlayerState","(I)Lforge/game/GameState$PlayerState;",2,2,3,new JHandler[]{},M2594));
c.Add(new JMethod(2595,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;",2,2,3,new JHandler[]{},M2595));
c.Add(new JMethod(2596,"forge/game/GameState","parseLine","(Ljava/lang/String;)V",4,5,3,new JHandler[]{},M2596));
c.Add(new JMethod(2597,"forge/game/GameState","applyToGame","(Lforge/game/Game;)V",1,2,3,new JHandler[]{},M2597));
c.Add(new JMethod(2598,"forge/game/GameState","applyGameOnThread","(Lforge/game/Game;)V",4,8,5,new JHandler[]{},M2598));
c.Add(new JMethod(2599,"forge/game/GameState","processManaPool","(Lforge/game/mana/ManaPool;)Ljava/lang/String;",2,9,2,new JHandler[]{},M2599));
c.Add(new JMethod(2600,"forge/game/GameState","updateManaPool","(Lforge/game/player/Player;Ljava/lang/String;ZZ)V",2,9,4,new JHandler[]{},M2600));
c.Add(new JMethod(2601,"forge/game/GameState","handleCombat","(Lforge/game/Game;Lforge/game/player/Player;Lforge/game/player/Player;Z)V",2,10,5,new JHandler[]{},M2601));
c.Add(new JMethod(2602,"forge/game/GameState","handleRememberedEntities","()V",2,8,2,new JHandler[]{},M2602));
c.Add(new JMethod(2603,"forge/game/GameState","parseTargetInScript","(Ljava/lang/String;)I",2,3,2,new JHandler[]{},M2603));
c.Add(new JMethod(2604,"forge/game/GameState","handleScriptedTargetingForSA","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;I)V",2,6,3,new JHandler[]{},M2604));
c.Add(new JMethod(2605,"forge/game/GameState","handleScriptExecution","(Lforge/game/Game;)V",2,6,4,new JHandler[]{},M2605));
c.Add(new JMethod(2606,"forge/game/GameState","executeScript","(Lforge/game/Game;Lforge/game/card/Card;Ljava/lang/String;)V",2,4,5,new JHandler[]{},M2606));
c.Add(new JMethod(2607,"forge/game/GameState","executeScript","(Lforge/game/Game;Lforge/game/card/Card;Ljava/lang/String;Z)V",2,11,4,new JHandler[]{},M2607));
c.Add(new JMethod(2608,"forge/game/GameState","handlePrecastSpells","(Lforge/game/Game;)V",2,8,4,new JHandler[]{},M2608));
c.Add(new JMethod(2609,"forge/game/GameState","handleAddSAsToStack","(Lforge/game/Game;)V",2,9,5,new JHandler[]{},M2609));
c.Add(new JMethod(2610,"forge/game/GameState","precastSpellFromCard","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/Game;)V",2,4,5,new JHandler[]{},M2610));
c.Add(new JMethod(2611,"forge/game/GameState","precastSpellFromCard","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/Game;Z)V",2,9,5,new JHandler[]{},M2611));
c.Add(new JMethod(2612,"forge/game/GameState","handleMarkedDamage","()V",2,5,2,new JHandler[]{},M2612));
c.Add(new JMethod(2613,"forge/game/GameState","handleChosenEntities","()V",2,6,2,new JHandler[]{},M2613));
}

private static void Add1(JClass c){
c.Add(new JMethod(2614,"forge/game/GameState","handleCardAttachments","()V",2,5,4,new JHandler[]{},M2614));
c.Add(new JMethod(2615,"forge/game/GameState","handleMergedCards","()V",2,8,4,new JHandler[]{},M2615));
c.Add(new JMethod(2616,"forge/game/GameState","emulateMergeViaMutate","(Lforge/game/card/Card;Lforge/game/card/Card;)V",2,7,4,new JHandler[]{},M2616));
c.Add(new JMethod(2617,"forge/game/GameState","applyCountersToGameEntity","(Lforge/game/GameEntity;Ljava/lang/String;)V",2,9,7,new JHandler[]{},M2617));
c.Add(new JMethod(2618,"forge/game/GameState","setupPlayerState","(Lforge/game/player/Player;Lforge/game/GameState$PlayerState;)V",2,13,5,new JHandler[]{},M2618));
c.Add(new JMethod(2619,"forge/game/GameState","processCardsForZone","([Ljava/lang/String;Lforge/game/player/Player;)Lforge/game/card/CardCollectionView;",2,23,5,new JHandler[]{new JHandler(154,173,176,"java/lang/Exception")},M2619));
c.Add(new JMethod(2620,"forge/game/GameState","lambda$updateManaPool$1","(Lforge/game/spellability/AbilityManaPart;)V",4106,1,2,new JHandler[]{},M2620));
c.Add(new JMethod(2621,"forge/game/GameState","lambda$applyToGame$0","(Lforge/game/Game;)V",4098,2,2,new JHandler[]{},M2621));
c.Add(new JMethod(2622,"forge/game/GameState","<clinit>","()V",8,0,3,new JHandler[]{},M2622));
}

internal static JStep M2581(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","puzzleCreatorState","Z",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",28);}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","idToCard","Ljava/util/Map;",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",39);}
case 39:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","cardToAttachId","Ljava/util/Map;",value);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=46;continue;}
case 46:{f.StackOp("dup");f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",50);}
case 50:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","cardToEnchantPlayerId","Ljava/util/Map;",value);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",61);}
case 61:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","markedDamage","Ljava/util/Map;",value);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",72);}
case 72:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","cardToChosenClrs","Ljava/util/Map;",value);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=79;continue;}
case 79:{f.StackOp("dup");f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",83);}
case 83:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","cardToChosenCards","Ljava/util/Map;",value);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",94);}
case 94:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","cardToChosenType","Ljava/util/Map;",value);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=101;continue;}
case 101:{f.StackOp("dup");f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",105);}
case 105:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","cardToChosenType2","Ljava/util/Map;",value);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=112;continue;}
case 112:{f.StackOp("dup");f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",116);}
case 116:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","cardToRememberedId","Ljava/util/Map;",value);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=123;continue;}
case 123:{f.StackOp("dup");f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",127);}
case 127:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","cardToImprintedId","Ljava/util/Map;",value);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=134;continue;}
case 134:{f.StackOp("dup");f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",138);}
case 138:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","cardToMergedCards","Ljava/util/Map;",value);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=145;continue;}
case 145:{f.StackOp("dup");f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",149);}
case 149:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","cardToNamedCard","Ljava/util/Map;",value);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[0]);f.Pc=153;continue;}
case 153:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=156;continue;}
case 156:{f.StackOp("dup");f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",160);}
case 160:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","cardToExiledWithId","Ljava/util/Map;",value);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=167;continue;}
case 167:{f.StackOp("dup");f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",171);}
case 171:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","cardAttackMap","Ljava/util/Map;",value);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=178;continue;}
case 178:{f.StackOp("dup");f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",182);}
case 182:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","cardToScript","Ljava/util/Map;",value);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=189;continue;}
case 189:{f.StackOp("dup");f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",193);}
case 193:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","abilityString","Ljava/util/Map;",value);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=200;continue;}
case 200:{f.StackOp("dup");f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",204);}
case 204:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","cardsReferencedByID","Ljava/util/Set;",value);f.Pc=207;continue;}
case 207:{f.Push(f.Locals[0]);f.Pc=208;continue;}
case 208:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=211;continue;}
case 211:{f.StackOp("dup");f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",215);}
case 215:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","cardsWithoutETBTrigs","Ljava/util/Set;",value);f.Pc=218;continue;}
case 218:{f.Push(f.Locals[0]);f.Pc=219;continue;}
case 219:{f.Push(JValue.R(rt.String("NONE")));f.Pc=221;continue;}
case 221:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","tChangePlayer","Ljava/lang/String;",value);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[0]);f.Pc=225;continue;}
case 225:{f.Push(JValue.R(rt.String("NONE")));f.Pc=227;continue;}
case 227:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","tChangePhase","Ljava/lang/String;",value);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[0]);f.Pc=231;continue;}
case 231:{f.Push(JValue.R(rt.String("NONE")));f.Pc=233;continue;}
case 233:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","tAdvancePhase","Ljava/lang/String;",value);f.Pc=236;continue;}
case 236:{f.Push(f.Locals[0]);f.Pc=237;continue;}
case 237:{f.Push(JValue.I(1));f.Pc=238;continue;}
case 238:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","turn","I",value);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[0]);f.Pc=242;continue;}
case 242:{f.Push(JValue.I(0));f.Pc=243;continue;}
case 243:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","removeSummoningSickness","Z",value);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[0]);f.Pc=247;continue;}
case 247:{f.Push(JValue.I(-1));f.Pc=248;continue;}
case 248:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","TARGET_NONE","I",value);f.Pc=251;continue;}
case 251:{f.Push(f.Locals[0]);f.Pc=252;continue;}
case 252:{f.Push(JValue.I(-2));f.Pc=254;continue;}
case 254:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","TARGET_HUMAN","I",value);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[0]);f.Pc=258;continue;}
case 258:{f.Push(JValue.I(-3));f.Pc=260;continue;}
case 260:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","TARGET_AI","I",value);f.Pc=263;continue;}
case 263:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2582(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","puzzleCreatorState","Z"));f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Int==0?71:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("[metadata]\n")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Name:New Puzzle\n")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("URL:https://www.cardforge.org\n")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("Goal:Win\n")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("Turns:1\n")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("Difficulty:Common\n")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("Description:Win this turn.\n")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("[state]\n")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(JValue.I(3));f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("turn=")));f.Pc=80;continue;}
case 80:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(JValue.I(1));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","turn","I"));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",90);}
case 90:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=91;continue;}
case 91:{f.StackOp("dup");f.Pc=92;continue;}
case 92:{f.Push(JValue.I(2));f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("\n")));f.Pc=95;continue;}
case 95:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",99);}
case 99:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",102);}
case 102:{f.StackOp("pop");f.Pc=103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{f.Push(JValue.I(3));f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=108;continue;}
case 108:{f.StackOp("dup");f.Pc=109;continue;}
case 109:{f.Push(JValue.I(0));f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("activeplayer=")));f.Pc=112;continue;}
case 112:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=113;continue;}
case 113:{f.StackOp("dup");f.Pc=114;continue;}
case 114:{f.Push(JValue.I(1));f.Pc=115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","tChangePlayer","Ljava/lang/String;"));f.Pc=119;continue;}
case 119:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=120;continue;}
case 120:{f.StackOp("dup");f.Pc=121;continue;}
case 121:{f.Push(JValue.I(2));f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("\n")));f.Pc=124;continue;}
case 124:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",128);}
case 128:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",131);}
case 131:{f.StackOp("pop");f.Pc=132;continue;}
case 132:{f.Push(f.Locals[1]);f.Pc=133;continue;}
case 133:{f.Push(JValue.I(3));f.Pc=134;continue;}
case 134:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=137;continue;}
case 137:{f.StackOp("dup");f.Pc=138;continue;}
case 138:{f.Push(JValue.I(0));f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("activephase=")));f.Pc=141;continue;}
case 141:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=142;continue;}
case 142:{f.StackOp("dup");f.Pc=143;continue;}
case 143:{f.Push(JValue.I(1));f.Pc=144;continue;}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","tChangePhase","Ljava/lang/String;"));f.Pc=148;continue;}
case 148:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=149;continue;}
case 149:{f.StackOp("dup");f.Pc=150;continue;}
case 150:{f.Push(JValue.I(2));f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("\n")));f.Pc=153;continue;}
case 153:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",157);}
case 157:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",160);}
case 160:{f.StackOp("pop");f.Pc=161;continue;}
case 161:{f.Push(JValue.I(0));f.Pc=162;continue;}
case 162:{f.Locals[2]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",172);}
case 172:{f.Locals[3]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[3]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",179);}
case 179:{f.Pc=f.Pop().Int==0?509:182;continue;}
case 182:{f.Push(f.Locals[3]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",188);}
case 188:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameState$PlayerState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=191;continue;}
case 191:{f.Locals[4]=f.Pop();f.Pc=193;continue;}
case 193:{f.Push(f.Locals[2]);f.Pc=194;continue;}
case 194:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=197;continue;}
case 197:{return rt.DynamicCall(f,"forge/game/GameState:2582:197:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",202);}
case 202:{f.Locals[5]=f.Pop();f.Pc=204;continue;}
case 204:{f.Push(f.Locals[1]);f.Pc=205;continue;}
case 205:{f.Push(JValue.I(3));f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=209;continue;}
case 209:{f.StackOp("dup");f.Pc=210;continue;}
case 210:{f.Push(JValue.I(0));f.Pc=211;continue;}
case 211:{f.Push(f.Locals[5]);f.Pc=213;continue;}
case 213:{return rt.DynamicCall(f,"forge/game/GameState:2582:213:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",218);}
case 218:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=219;continue;}
case 219:{f.StackOp("dup");f.Pc=220;continue;}
case 220:{f.Push(JValue.I(1));f.Pc=221;continue;}
case 221:{f.Push(f.Locals[4]);f.Pc=223;continue;}
case 223:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","life","I"));f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",229);}
case 229:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=230;continue;}
case 230:{f.StackOp("dup");f.Pc=231;continue;}
case 231:{f.Push(JValue.I(2));f.Pc=232;continue;}
case 232:{f.Push(JValue.R(rt.String("\n")));f.Pc=234;continue;}
case 234:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",238);}
case 238:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",241);}
case 241:{f.StackOp("pop");f.Pc=242;continue;}
case 242:{f.Push(f.Locals[1]);f.Pc=243;continue;}
case 243:{f.Push(JValue.I(3));f.Pc=244;continue;}
case 244:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=247;continue;}
case 247:{f.StackOp("dup");f.Pc=248;continue;}
case 248:{f.Push(JValue.I(0));f.Pc=249;continue;}
case 249:{f.Push(f.Locals[5]);f.Pc=251;continue;}
case 251:{return rt.DynamicCall(f,"forge/game/GameState:2582:251:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",256);}
case 256:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=257;continue;}
case 257:{f.StackOp("dup");f.Pc=258;continue;}
case 258:{f.Push(JValue.I(1));f.Pc=259;continue;}
case 259:{f.Push(f.Locals[4]);f.Pc=261;continue;}
case 261:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","landsPlayed","I"));f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",267);}
case 267:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=268;continue;}
case 268:{f.StackOp("dup");f.Pc=269;continue;}
case 269:{f.Push(JValue.I(2));f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("\n")));f.Pc=272;continue;}
case 272:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",276);}
case 276:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",279);}
case 279:{f.StackOp("pop");f.Pc=280;continue;}
case 280:{f.Push(f.Locals[1]);f.Pc=281;continue;}
case 281:{f.Push(JValue.I(3));f.Pc=282;continue;}
case 282:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=285;continue;}
case 285:{f.StackOp("dup");f.Pc=286;continue;}
case 286:{f.Push(JValue.I(0));f.Pc=287;continue;}
case 287:{f.Push(f.Locals[5]);f.Pc=289;continue;}
case 289:{return rt.DynamicCall(f,"forge/game/GameState:2582:289:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",294);}
case 294:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=295;continue;}
case 295:{f.StackOp("dup");f.Pc=296;continue;}
case 296:{f.Push(JValue.I(1));f.Pc=297;continue;}
case 297:{f.Push(f.Locals[4]);f.Pc=299;continue;}
case 299:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","numRingTemptedYou","I"));f.Pc=302;continue;}
case 302:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",305);}
case 305:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=306;continue;}
case 306:{f.StackOp("dup");f.Pc=307;continue;}
case 307:{f.Push(JValue.I(2));f.Pc=308;continue;}
case 308:{f.Push(JValue.R(rt.String("\n")));f.Pc=310;continue;}
case 310:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",314);}
case 314:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",317);}
case 317:{f.StackOp("pop");f.Pc=318;continue;}
case 318:{f.Push(f.Locals[1]);f.Pc=319;continue;}
case 319:{f.Push(JValue.I(3));f.Pc=320;continue;}
case 320:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=323;continue;}
case 323:{f.StackOp("dup");f.Pc=324;continue;}
case 324:{f.Push(JValue.I(0));f.Pc=325;continue;}
case 325:{f.Push(f.Locals[5]);f.Pc=327;continue;}
case 327:{return rt.DynamicCall(f,"forge/game/GameState:2582:327:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",332);}
case 332:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=333;continue;}
case 333:{f.StackOp("dup");f.Pc=334;continue;}
case 334:{f.Push(JValue.I(1));f.Pc=335;continue;}
case 335:{f.Push(f.Locals[4]);f.Pc=337;continue;}
case 337:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","speed","I"));f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",343);}
case 343:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=344;continue;}
case 344:{f.StackOp("dup");f.Pc=345;continue;}
case 345:{f.Push(JValue.I(2));f.Pc=346;continue;}
case 346:{f.Push(JValue.R(rt.String("\n")));f.Pc=348;continue;}
case 348:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",352);}
case 352:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",355);}
case 355:{f.StackOp("pop");f.Pc=356;continue;}
case 356:{f.Push(f.Locals[4]);f.Pc=358;continue;}
case 358:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","counters","Ljava/lang/String;"));f.Pc=361;continue;}
case 361:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",364);}
case 364:{f.Pc=f.Pop().Int!=0?402:367;continue;}
case 367:{f.Push(f.Locals[1]);f.Pc=368;continue;}
case 368:{f.Push(JValue.I(3));f.Pc=369;continue;}
case 369:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=372;continue;}
case 372:{f.StackOp("dup");f.Pc=373;continue;}
case 373:{f.Push(JValue.I(0));f.Pc=374;continue;}
case 374:{f.Push(f.Locals[5]);f.Pc=376;continue;}
case 376:{return rt.DynamicCall(f,"forge/game/GameState:2582:376:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",381);}
case 381:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=382;continue;}
case 382:{f.StackOp("dup");f.Pc=383;continue;}
case 383:{f.Push(JValue.I(1));f.Pc=384;continue;}
case 384:{f.Push(f.Locals[4]);f.Pc=386;continue;}
case 386:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","counters","Ljava/lang/String;"));f.Pc=389;continue;}
case 389:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=390;continue;}
case 390:{f.StackOp("dup");f.Pc=391;continue;}
case 391:{f.Push(JValue.I(2));f.Pc=392;continue;}
case 392:{f.Push(JValue.R(rt.String("\n")));f.Pc=394;continue;}
case 394:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",398);}
case 398:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",401);}
case 401:{f.StackOp("pop");f.Pc=402;continue;}
case 402:{f.Push(f.Locals[4]);f.Pc=404;continue;}
case 404:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","manaPool","Ljava/lang/String;"));f.Pc=407;continue;}
case 407:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",410);}
case 410:{f.Pc=f.Pop().Int!=0?448:413;continue;}
case 413:{f.Push(f.Locals[1]);f.Pc=414;continue;}
case 414:{f.Push(JValue.I(3));f.Pc=415;continue;}
case 415:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=418;continue;}
case 418:{f.StackOp("dup");f.Pc=419;continue;}
case 419:{f.Push(JValue.I(0));f.Pc=420;continue;}
case 420:{f.Push(f.Locals[5]);f.Pc=422;continue;}
case 422:{return rt.DynamicCall(f,"forge/game/GameState:2582:422:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",427);}
case 427:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=428;continue;}
case 428:{f.StackOp("dup");f.Pc=429;continue;}
case 429:{f.Push(JValue.I(1));f.Pc=430;continue;}
case 430:{f.Push(f.Locals[4]);f.Pc=432;continue;}
case 432:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","manaPool","Ljava/lang/String;"));f.Pc=435;continue;}
case 435:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=436;continue;}
case 436:{f.StackOp("dup");f.Pc=437;continue;}
case 437:{f.Push(JValue.I(2));f.Pc=438;continue;}
case 438:{f.Push(JValue.R(rt.String("\n")));f.Pc=440;continue;}
case 440:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=441;continue;}
case 441:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",444);}
case 444:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",447);}
case 447:{f.StackOp("pop");f.Pc=448;continue;}
case 448:{f.Push(f.Locals[4]);f.Pc=450;continue;}
case 450:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","persistentMana","Ljava/lang/String;"));f.Pc=453;continue;}
case 453:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",456);}
case 456:{f.Pc=f.Pop().Int!=0?494:459;continue;}
case 459:{f.Push(f.Locals[1]);f.Pc=460;continue;}
case 460:{f.Push(JValue.I(3));f.Pc=461;continue;}
case 461:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=464;continue;}
case 464:{f.StackOp("dup");f.Pc=465;continue;}
case 465:{f.Push(JValue.I(0));f.Pc=466;continue;}
case 466:{f.Push(f.Locals[5]);f.Pc=468;continue;}
case 468:{return rt.DynamicCall(f,"forge/game/GameState:2582:468:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",473);}
case 473:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=474;continue;}
case 474:{f.StackOp("dup");f.Pc=475;continue;}
case 475:{f.Push(JValue.I(1));f.Pc=476;continue;}
case 476:{f.Push(f.Locals[4]);f.Pc=478;continue;}
case 478:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","persistentMana","Ljava/lang/String;"));f.Pc=481;continue;}
case 481:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=482;continue;}
case 482:{f.StackOp("dup");f.Pc=483;continue;}
case 483:{f.Push(JValue.I(2));f.Pc=484;continue;}
case 484:{f.Push(JValue.R(rt.String("\n")));f.Pc=486;continue;}
case 486:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=487;continue;}
case 487:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",490);}
case 490:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",493);}
case 493:{f.StackOp("pop");f.Pc=494;continue;}
case 494:{f.Push(f.Locals[0]);f.Pc=495;continue;}
case 495:{f.Push(f.Locals[4]);f.Pc=497;continue;}
case 497:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","cardTexts","Ljava/util/Map;"));f.Pc=500;continue;}
case 500:{f.Push(f.Locals[5]);f.Pc=502;continue;}
case 502:{f.Push(f.Locals[1]);f.Pc=503;continue;}
case 503:{return rt.Call(f,"forge/game/GameState","appendCards","(Ljava/util/Map;Ljava/lang/String;Ljava/lang/StringBuilder;)V","invokevirtual",506);}
case 506:{f.Pc=173;continue;}
case 509:{f.Push(f.Locals[1]);f.Pc=510;continue;}
case 510:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",513);}
case 513:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2583(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",6);}
case 6:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?98:23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[5]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=40;continue;}
case 40:{f.StackOp("dup");f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{if(!rt.StaticReady(f,"forge/game/GameState","ZONES","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameState","ZONES","Ljava/util/Map;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",56);}
case 56:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=65;continue;}
case 65:{f.StackOp("dup");f.Pc=66;continue;}
case 66:{f.Push(JValue.I(2));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("=")));f.Pc=69;continue;}
case 69:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=70;continue;}
case 70:{f.StackOp("dup");f.Pc=71;continue;}
case 71:{f.Push(JValue.I(3));f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",79);}
case 79:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(4));f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("\n")));f.Pc=87;continue;}
case 87:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",91);}
case 91:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",94);}
case 94:{f.StackOp("pop");f.Pc=95;continue;}
case 95:{f.Pc=13;continue;}
case 98:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2584(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?122:26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{if(!rt.EnsureInitialized(f,"forge/game/GameState$PlayerState"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameState$PlayerState")));f.Pc=39;continue;}
case 39:{f.StackOp("dup");f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/GameState$PlayerState","<init>","()V","invokespecial",43);}
case 43:{f.Locals[4]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",51);}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","life","I",value);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/player/Player","getLandsPlayedThisTurn","()I","invokevirtual",60);}
case 60:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","landsPlayed","I",value);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/player/Player","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",70);}
case 70:{return rt.Call(f,"forge/game/GameState","countersToString","(Lcom/google/common/collect/Multiset;)Ljava/lang/String;","invokevirtual",73);}
case 73:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","counters","Ljava/lang/String;",value);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",83);}
case 83:{return rt.Call(f,"forge/game/GameState","processManaPool","(Lforge/game/mana/ManaPool;)Ljava/lang/String;","invokevirtual",86);}
case 86:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","manaPool","Ljava/lang/String;",value);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/player/Player","getNumRingTemptedYou","()I","invokevirtual",95);}
case 95:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","numRingTemptedYou","I",value);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[3]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/player/Player","getSpeed","()I","invokevirtual",104);}
case 104:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","speed","I",value);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=111;continue;}
case 111:{f.Push(f.Locals[4]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",118);}
case 118:{f.StackOp("pop");f.Pc=119;continue;}
case 119:{f.Pc=17;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",127);}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",131);}
case 131:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",134);}
case 134:{return rt.Call(f,"forge/game/player/PlayerCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",137);}
case 137:{return rt.DynamicCall(f,"forge/game/GameState:2584:137:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",142);}
case 142:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","tChangePlayer","Ljava/lang/String;",value);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",150);}
case 150:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPhase","()Lforge/game/phase/PhaseType;","invokevirtual",153);}
case 153:{return rt.Call(f,"forge/game/phase/PhaseType","toString","()Ljava/lang/String;","invokevirtual",156);}
case 156:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","tChangePhase","Ljava/lang/String;",value);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",164);}
case 164:{return rt.Call(f,"forge/game/phase/PhaseHandler","getTurn","()I","invokevirtual",167);}
case 167:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","turn","I",value);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardsReferencedByID","Ljava/util/Set;"));f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/Set","clear","()V","invokeinterface",179);}
case 179:{if(!rt.StaticReady(f,"forge/game/GameState","ZONES","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameState","ZONES","Ljava/util/Map;"));f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",187);}
case 187:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",192);}
case 192:{f.Locals[2]=f.Pop();f.Pc=193;continue;}
case 193:{f.Push(f.Locals[2]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",199);}
case 199:{f.Pc=f.Pop().Int==0?515:202;continue;}
case 202:{f.Push(f.Locals[2]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",208);}
case 208:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=211;continue;}
case 211:{f.Locals[3]=f.Pop();f.Pc=212;continue;}
case 212:{f.Push(f.Locals[1]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[3]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/Game","getCardsIncludePhasingIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",217);}
case 217:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",222);}
case 222:{f.Locals[4]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(f.Locals[4]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",231);}
case 231:{f.Pc=f.Pop().Int==0?512:234;continue;}
case 234:{f.Push(f.Locals[4]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",241);}
case 241:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=244;continue;}
case 244:{f.Locals[5]=f.Pop();f.Pc=246;continue;}
case 246:{f.Push(f.Locals[5]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/card/Card","getExiledWith","()Lforge/game/card/Card;","invokevirtual",251);}
case 251:{f.Pc=f.Pop().Reference==null?269:254;continue;}
case 254:{f.Push(f.Locals[0]);f.Pc=255;continue;}
case 255:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardsReferencedByID","Ljava/util/Set;"));f.Pc=258;continue;}
case 258:{f.Push(f.Locals[5]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/card/Card","getExiledWith","()Lforge/game/card/Card;","invokevirtual",263);}
case 263:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",268);}
case 268:{f.StackOp("pop");f.Pc=269;continue;}
case 269:{f.Push(f.Locals[3]);f.Pc=270;continue;}
case 270:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=273;continue;}
case 273:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?301:276;continue;}
case 276:{f.Push(f.Locals[5]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/game/card/Card","getAllAttachedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",281);}
case 281:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",286);}
case 286:{f.Pc=f.Pop().Int!=0?301:289;continue;}
case 289:{f.Push(f.Locals[0]);f.Pc=290;continue;}
case 290:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardsReferencedByID","Ljava/util/Set;"));f.Pc=293;continue;}
case 293:{f.Push(f.Locals[5]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",300);}
case 300:{f.StackOp("pop");f.Pc=301;continue;}
case 301:{f.Push(f.Locals[5]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",306);}
case 306:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",311);}
case 311:{f.Locals[6]=f.Pop();f.Pc=313;continue;}
case 313:{f.Push(f.Locals[6]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",320);}
case 320:{f.Pc=f.Pop().Int==0?358:323;continue;}
case 323:{f.Push(f.Locals[6]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",330);}
case 330:{f.Locals[7]=f.Pop();f.Pc=332;continue;}
case 332:{f.Push(f.Locals[7]);f.Pc=334;continue;}
case 334:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=337;continue;}
case 337:{f.Pc=f.Pop().Int==0?355:340;continue;}
case 340:{f.Push(f.Locals[0]);f.Pc=341;continue;}
case 341:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardsReferencedByID","Ljava/util/Set;"));f.Pc=344;continue;}
case 344:{f.Push(f.Locals[7]);f.Pc=346;continue;}
case 346:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=349;continue;}
case 349:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",354);}
case 354:{f.StackOp("pop");f.Pc=355;continue;}
case 355:{f.Pc=313;continue;}
case 358:{f.Push(f.Locals[5]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/card/Card","getImprintedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",363);}
case 363:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",368);}
case 368:{f.Locals[6]=f.Pop();f.Pc=370;continue;}
case 370:{f.Push(f.Locals[6]);f.Pc=372;continue;}
case 372:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",377);}
case 377:{f.Pc=f.Pop().Int==0?407:380;continue;}
case 380:{f.Push(f.Locals[6]);f.Pc=382;continue;}
case 382:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",387);}
case 387:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=390;continue;}
case 390:{f.Locals[7]=f.Pop();f.Pc=392;continue;}
case 392:{f.Push(f.Locals[0]);f.Pc=393;continue;}
case 393:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardsReferencedByID","Ljava/util/Set;"));f.Pc=396;continue;}
case 396:{f.Push(f.Locals[7]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",403);}
case 403:{f.StackOp("pop");f.Pc=404;continue;}
case 404:{f.Pc=370;continue;}
case 407:{f.Push(f.Locals[5]);f.Pc=409;continue;}
case 409:{return rt.Call(f,"forge/game/card/Card","getChosenCards","()Lforge/game/card/CardCollectionView;","invokevirtual",412);}
case 412:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",417);}
case 417:{f.Locals[6]=f.Pop();f.Pc=419;continue;}
case 419:{f.Push(f.Locals[6]);f.Pc=421;continue;}
case 421:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",426);}
case 426:{f.Pc=f.Pop().Int==0?456:429;continue;}
case 429:{f.Push(f.Locals[6]);f.Pc=431;continue;}
case 431:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",436);}
case 436:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=439;continue;}
case 439:{f.Locals[7]=f.Pop();f.Pc=441;continue;}
case 441:{f.Push(f.Locals[0]);f.Pc=442;continue;}
case 442:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardsReferencedByID","Ljava/util/Set;"));f.Pc=445;continue;}
case 445:{f.Push(f.Locals[7]);f.Pc=447;continue;}
case 447:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",452);}
case 452:{f.StackOp("pop");f.Pc=453;continue;}
case 453:{f.Pc=419;continue;}
case 456:{f.Push(f.Locals[1]);f.Pc=457;continue;}
case 457:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",460);}
case 460:{f.Pc=f.Pop().Reference==null?509:463;continue;}
case 463:{f.Push(f.Locals[1]);f.Pc=464;continue;}
case 464:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",467);}
case 467:{f.Push(f.Locals[5]);f.Pc=469;continue;}
case 469:{return rt.Call(f,"forge/game/combat/Combat","isAttacking","(Lforge/game/card/Card;)Z","invokevirtual",472);}
case 472:{f.Pc=f.Pop().Int==0?509:475;continue;}
case 475:{f.Push(f.Locals[1]);f.Pc=476;continue;}
case 476:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",479);}
case 479:{f.Push(f.Locals[5]);f.Pc=481;continue;}
case 481:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",484);}
case 484:{f.Locals[6]=f.Pop();f.Pc=486;continue;}
case 486:{f.Push(f.Locals[6]);f.Pc=488;continue;}
case 488:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=491;continue;}
case 491:{f.Pc=f.Pop().Int==0?509:494;continue;}
case 494:{f.Push(f.Locals[0]);f.Pc=495;continue;}
case 495:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardsReferencedByID","Ljava/util/Set;"));f.Pc=498;continue;}
case 498:{f.Push(f.Locals[6]);f.Pc=500;continue;}
case 500:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=503;continue;}
case 503:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",508);}
case 508:{f.StackOp("pop");f.Pc=509;continue;}
case 509:{f.Pc=224;continue;}
case 512:{f.Pc=193;continue;}
case 515:{if(!rt.StaticReady(f,"forge/game/GameState","ZONES","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameState","ZONES","Ljava/util/Map;"));f.Pc=518;continue;}
case 518:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",523);}
case 523:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",528);}
case 528:{f.Locals[2]=f.Pop();f.Pc=529;continue;}
case 529:{f.Push(f.Locals[2]);f.Pc=530;continue;}
case 530:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",535);}
case 535:{f.Pc=f.Pop().Int==0?724:538;continue;}
case 538:{f.Push(f.Locals[2]);f.Pc=539;continue;}
case 539:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",544);}
case 544:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=547;continue;}
case 547:{f.Locals[3]=f.Pop();f.Pc=548;continue;}
case 548:{f.Push(f.Locals[0]);f.Pc=549;continue;}
case 549:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",557);}
case 557:{f.Locals[4]=f.Pop();f.Pc=559;continue;}
case 559:{f.Push(f.Locals[4]);f.Pc=561;continue;}
case 561:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",566);}
case 566:{f.Pc=f.Pop().Int==0?599:569;continue;}
case 569:{f.Push(f.Locals[4]);f.Pc=571;continue;}
case 571:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",576);}
case 576:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameState$PlayerState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=579;continue;}
case 579:{f.Locals[5]=f.Pop();f.Pc=581;continue;}
case 581:{f.Push(f.Locals[5]);f.Pc=583;continue;}
case 583:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","cardTexts","Ljava/util/Map;"));f.Pc=586;continue;}
case 586:{f.Push(f.Locals[3]);f.Pc=587;continue;}
case 587:{f.Push(JValue.R(rt.String("")));f.Pc=590;continue;}
case 590:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",595);}
case 595:{f.StackOp("pop");f.Pc=596;continue;}
case 596:{f.Pc=559;continue;}
case 599:{f.Push(f.Locals[1]);f.Pc=600;continue;}
case 600:{f.Push(f.Locals[3]);f.Pc=601;continue;}
case 601:{return rt.Call(f,"forge/game/Game","getCardsIncludePhasingIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",604);}
case 604:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",609);}
case 609:{f.Locals[4]=f.Pop();f.Pc=611;continue;}
case 611:{f.Push(f.Locals[4]);f.Pc=613;continue;}
case 613:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",618);}
case 618:{f.Pc=f.Pop().Int==0?721:621;continue;}
case 621:{f.Push(f.Locals[4]);f.Pc=623;continue;}
case 623:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",628);}
case 628:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=631;continue;}
case 631:{f.Locals[5]=f.Pop();f.Pc=633;continue;}
case 633:{f.Push(f.Locals[5]);f.Pc=635;continue;}
case 635:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",638);}
case 638:{f.Push(JValue.R(rt.String("Puzzle Goal")));f.Pc=641;continue;}
case 641:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",644);}
case 644:{f.Pc=f.Pop().Int==0?666:647;continue;}
case 647:{f.Push(f.Locals[5]);f.Pc=649;continue;}
case 649:{return rt.Call(f,"forge/game/card/Card","getOracleText","()Ljava/lang/String;","invokevirtual",652);}
case 652:{f.Push(JValue.R(rt.String("New Puzzle")));f.Pc=655;continue;}
case 655:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",658);}
case 658:{f.Pc=f.Pop().Int==0?666:661;continue;}
case 661:{f.Push(f.Locals[0]);f.Pc=662;continue;}
case 662:{f.Push(JValue.I(1));f.Pc=663;continue;}
case 663:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","puzzleCreatorState","Z",value);f.Pc=666;continue;}
case 666:{f.Push(f.Locals[5]);f.Pc=668;continue;}
case 668:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/ability/effects/DetachedCardEffect")?1:0));f.Pc=671;continue;}
case 671:{f.Pc=f.Pop().Int==0?677:674;continue;}
case 674:{f.Pc=611;continue;}
case 677:{f.Push(f.Locals[1]);f.Pc=678;continue;}
case 678:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",681);}
case 681:{f.Push(f.Locals[5]);f.Pc=683;continue;}
case 683:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",686);}
case 686:{return rt.Call(f,"forge/game/zone/Zone","getPlayer","()Lforge/game/player/Player;","invokevirtual",689);}
case 689:{return rt.Call(f,"forge/game/player/PlayerCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",692);}
case 692:{f.Locals[6]=f.Pop();f.Pc=694;continue;}
case 694:{f.Push(f.Locals[0]);f.Pc=695;continue;}
case 695:{f.Push(f.Locals[3]);f.Pc=696;continue;}
case 696:{f.Push(f.Locals[0]);f.Pc=697;continue;}
case 697:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=700;continue;}
case 700:{f.Push(f.Locals[6]);f.Pc=702;continue;}
case 702:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",707);}
case 707:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameState$PlayerState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=710;continue;}
case 710:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","cardTexts","Ljava/util/Map;"));f.Pc=713;continue;}
case 713:{f.Push(f.Locals[5]);f.Pc=715;continue;}
case 715:{return rt.Call(f,"forge/game/GameState","addCard","(Lforge/game/zone/ZoneType;Ljava/util/Map;Lforge/game/card/Card;)V","invokevirtual",718);}
case 718:{f.Pc=611;continue;}
case 721:{f.Pc=529;continue;}
case 724:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2585(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",7);}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/player/PlayerCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",11);}
case 11:{return rt.DynamicCall(f,"forge/game/GameState:2585:11:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2586(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("HUMAN")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?22:10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",14);}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",18);}
case 18:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("AI")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?44:32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",36);}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("P")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?87:54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(JValue.I(1));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",59);}
case 59:{return rt.Call(f,"java/lang/Character","isDigit","(C)Z","invokestatic",62);}
case 62:{f.Pc=f.Pop().Int==0?87:65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",69);}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{f.Push(JValue.I(1));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",74);}
case 74:{return rt.Call(f,"java/lang/String","valueOf","(C)Ljava/lang/String;","invokestatic",77);}
case 77:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",80);}
case 80:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",83);}
case 83:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=86;continue;}
case 86:{return JStep.Return(f.Pop());}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",91);}
case 91:{f.Push(JValue.I(0));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",95);}
case 95:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=98;continue;}
case 98:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2587(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("t:")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{if(!rt.StaticReady(f,"forge/game/GameState","LEGACY_TOKEN_IMAGE","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameState","LEGACY_TOKEN_IMAGE","Ljava/util/regex/Pattern;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",19);}
case 19:{f.Locals[1]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?29:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
case 29:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",37);}
case 37:{f.Push(JValue.I(8));f.Pc=39;continue;}
case 39:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/StringBuilder","<init>","(I)V","invokespecial",43);}
case 43:{f.Locals[2]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/regex/Matcher","start","()I","invokevirtual",51);}
case 51:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;","invokevirtual",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",61);}
case 61:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",64);}
case 64:{f.Push(JValue.R(rt.String("%7C")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",70);}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(JValue.I(2));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",75);}
case 75:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",78);}
case 78:{f.Push(JValue.R(rt.String("%7C")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",84);}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{f.Push(JValue.I(3));f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",89);}
case 89:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",92);}
case 92:{f.StackOp("pop");f.Pc=93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{f.Push(JValue.I(4));f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Reference==null?117:101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("%7C")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",108);}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(JValue.I(4));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",113);}
case 113:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",116);}
case 116:{f.StackOp("pop");f.Pc=117;continue;}
case 117:{f.Push(f.Locals[2]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/regex/Matcher","end","()I","invokevirtual",123);}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",127);}
case 127:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;","invokevirtual",130);}
case 130:{f.StackOp("pop");f.Pc=131;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",135);}
case 135:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2588(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int<=0?36:27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String(";")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?78:43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("t:")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",51);}
case 51:{if(!rt.EnsureInitialized(f,"forge/game/card/token/TokenInfo"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/token/TokenInfo")));f.Pc=54;continue;}
case 54:{f.StackOp("dup");f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/card/token/TokenInfo","<init>","(Lforge/game/card/Card;)V","invokespecial",59);}
case 59:{return rt.Call(f,"forge/game/card/token/TokenInfo","toString","()Ljava/lang/String;","invokevirtual",62);}
case 62:{f.Push(JValue.R(rt.String("|")));f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("%7C")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",71);}
case 71:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Pc=256;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Reference!=null?86:85;continue;}
case 85:{return JStep.ReturnVoid;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?182:93;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/card/Card","getTopMergedCard","()Lforge/game/card/Card;","invokevirtual",97);}
case 97:{return rt.Call(f,"forge/game/card/Card","hasPaperFoil","()Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int==0?109:103;continue;}
case 103:{f.Push(JValue.R(rt.String("+")));f.Pc=106;continue;}
case 106:{f.Pc=112;continue;}
case 109:{f.Push(JValue.R(rt.String("")));f.Pc=112;continue;}
case 112:{f.Locals[5]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/card/Card","getTopMergedCard","()Lforge/game/card/Card;","invokevirtual",120);}
case 120:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",123);}
case 123:{return rt.Call(f,"forge/item/IPaperCard","getName","()Ljava/lang/String;","invokeinterface",128);}
case 128:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",131);}
case 131:{f.Push(f.Locals[5]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",136);}
case 136:{f.Push(JValue.R(rt.String("|Set:")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",142);}
case 142:{f.Push(f.Locals[3]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/card/Card","getTopMergedCard","()Lforge/game/card/Card;","invokevirtual",146);}
case 146:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",149);}
case 149:{return rt.Call(f,"forge/item/IPaperCard","getEdition","()Ljava/lang/String;","invokeinterface",154);}
case 154:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",157);}
case 157:{f.Push(JValue.R(rt.String("|Art:")));f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",163);}
case 163:{f.Push(f.Locals[3]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/card/Card","getTopMergedCard","()Lforge/game/card/Card;","invokevirtual",167);}
case 167:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",170);}
case 170:{return rt.Call(f,"forge/item/IPaperCard","getArtIndex","()I","invokeinterface",175);}
case 175:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",178);}
case 178:{f.StackOp("pop");f.Pc=179;continue;}
case 179:{f.Pc=256;continue;}
case 182:{f.Push(f.Locals[3]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/card/Card","hasPaperFoil","()Z","invokevirtual",186);}
case 186:{f.Pc=f.Pop().Int==0?195:189;continue;}
case 189:{f.Push(JValue.R(rt.String("+")));f.Pc=192;continue;}
case 192:{f.Pc=198;continue;}
case 195:{f.Push(JValue.R(rt.String("")));f.Pc=198;continue;}
case 198:{f.Locals[5]=f.Pop();f.Pc=200;continue;}
case 200:{f.Push(f.Locals[4]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[3]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",206);}
case 206:{return rt.Call(f,"forge/item/IPaperCard","getName","()Ljava/lang/String;","invokeinterface",211);}
case 211:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",214);}
case 214:{f.Push(f.Locals[5]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",219);}
case 219:{f.Push(JValue.R(rt.String("|Set:")));f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",225);}
case 225:{f.Push(f.Locals[3]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",229);}
case 229:{return rt.Call(f,"forge/item/IPaperCard","getEdition","()Ljava/lang/String;","invokeinterface",234);}
case 234:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",237);}
case 237:{f.Push(JValue.R(rt.String("|Art:")));f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",243);}
case 243:{f.Push(f.Locals[3]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",247);}
case 247:{return rt.Call(f,"forge/item/IPaperCard","getArtIndex","()I","invokeinterface",252);}
case 252:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",255);}
case 255:{f.StackOp("pop");f.Pc=256;continue;}
case 256:{f.Push(f.Locals[3]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/card/Card","isCommander","()Z","invokevirtual",260);}
case 260:{f.Pc=f.Pop().Int==0?272:263;continue;}
case 263:{f.Push(f.Locals[4]);f.Pc=265;continue;}
case 265:{f.Push(JValue.R(rt.String("|IsCommander")));f.Pc=268;continue;}
case 268:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",271);}
case 271:{f.StackOp("pop");f.Pc=272;continue;}
case 272:{f.Push(f.Locals[3]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/card/Card","isRingBearer","()Z","invokevirtual",276);}
case 276:{f.Pc=f.Pop().Int==0?288:279;continue;}
case 279:{f.Push(f.Locals[4]);f.Pc=281;continue;}
case 281:{f.Push(JValue.R(rt.String("|IsRingBearer")));f.Pc=284;continue;}
case 284:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",287);}
case 287:{f.StackOp("pop");f.Pc=288;continue;}
case 288:{f.Push(f.Locals[0]);f.Pc=289;continue;}
case 289:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardsReferencedByID","Ljava/util/Set;"));f.Pc=292;continue;}
case 292:{f.Push(f.Locals[3]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",298);}
case 298:{f.Pc=f.Pop().Int==0?317:301;continue;}
case 301:{f.Push(f.Locals[4]);f.Pc=303;continue;}
case 303:{f.Push(JValue.R(rt.String("|Id:")));f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",309);}
case 309:{f.Push(f.Locals[3]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",313);}
case 313:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",316);}
case 316:{f.StackOp("pop");f.Pc=317;continue;}
case 317:{f.Push(f.Locals[1]);f.Pc=318;continue;}
case 318:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=321;continue;}
case 321:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1270:324;continue;}
case 324:{f.Push(f.Locals[3]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",328);}
case 328:{f.Push(f.Locals[3]);f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",332);}
case 332:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?355:335;continue;}
case 335:{f.Push(f.Locals[4]);f.Pc=337;continue;}
case 337:{f.Push(JValue.R(rt.String("|Owner:")));f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",343);}
case 343:{f.Push(f.Locals[0]);f.Pc=344;continue;}
case 344:{f.Push(f.Locals[3]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",348);}
case 348:{return rt.Call(f,"forge/game/GameState","getPlayerString","(Lforge/game/player/Player;)Ljava/lang/String;","invokevirtual",351);}
case 351:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",354);}
case 354:{f.StackOp("pop");f.Pc=355;continue;}
case 355:{f.Push(f.Locals[3]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"forge/game/card/Card","isTapped","()Z","invokevirtual",359);}
case 359:{f.Pc=f.Pop().Int==0?371:362;continue;}
case 362:{f.Push(f.Locals[4]);f.Pc=364;continue;}
case 364:{f.Push(JValue.R(rt.String("|Tapped")));f.Pc=367;continue;}
case 367:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",370);}
case 370:{f.StackOp("pop");f.Pc=371;continue;}
case 371:{f.Push(f.Locals[3]);f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/game/card/Card","isSick","()Z","invokevirtual",375);}
case 375:{f.Pc=f.Pop().Int==0?387:378;continue;}
case 378:{f.Push(f.Locals[4]);f.Pc=380;continue;}
case 380:{f.Push(JValue.R(rt.String("|SummonSick")));f.Pc=383;continue;}
case 383:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",386);}
case 386:{f.StackOp("pop");f.Pc=387;continue;}
case 387:{f.Push(f.Locals[3]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"forge/game/card/Card","isRenowned","()Z","invokevirtual",391);}
case 391:{f.Pc=f.Pop().Int==0?403:394;continue;}
case 394:{f.Push(f.Locals[4]);f.Pc=396;continue;}
case 396:{f.Push(JValue.R(rt.String("|Renowned")));f.Pc=399;continue;}
case 399:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",402);}
case 402:{f.StackOp("pop");f.Pc=403;continue;}
case 403:{f.Push(f.Locals[3]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/card/Card","isSolved","()Z","invokevirtual",407);}
case 407:{f.Pc=f.Pop().Int==0?419:410;continue;}
case 410:{f.Push(f.Locals[4]);f.Pc=412;continue;}
case 412:{f.Push(JValue.R(rt.String("|Solved")));f.Pc=415;continue;}
case 415:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",418);}
case 418:{f.StackOp("pop");f.Pc=419;continue;}
case 419:{f.Push(f.Locals[3]);f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/game/card/Card","isSuspected","()Z","invokevirtual",423);}
case 423:{f.Pc=f.Pop().Int==0?435:426;continue;}
case 426:{f.Push(f.Locals[4]);f.Pc=428;continue;}
case 428:{f.Push(JValue.R(rt.String("|Suspected")));f.Pc=431;continue;}
case 431:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",434);}
case 434:{f.StackOp("pop");f.Pc=435;continue;}
case 435:{f.Push(f.Locals[3]);f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/card/Card","isMonstrous","()Z","invokevirtual",439);}
case 439:{f.Pc=f.Pop().Int==0?451:442;continue;}
case 442:{f.Push(f.Locals[4]);f.Pc=444;continue;}
case 444:{f.Push(JValue.R(rt.String("|Monstrous")));f.Pc=447;continue;}
case 447:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",450);}
case 450:{f.StackOp("pop");f.Pc=451;continue;}
case 451:{f.Push(f.Locals[3]);f.Pc=452;continue;}
case 452:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",455);}
case 455:{f.Pc=f.Pop().Int==0?481:458;continue;}
case 458:{f.Push(f.Locals[4]);f.Pc=460;continue;}
case 460:{f.Push(JValue.R(rt.String("|PhasedOut:")));f.Pc=463;continue;}
case 463:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",466);}
case 466:{f.StackOp("pop");f.Pc=467;continue;}
case 467:{f.Push(f.Locals[4]);f.Pc=469;continue;}
case 469:{f.Push(f.Locals[0]);f.Pc=470;continue;}
case 470:{f.Push(f.Locals[3]);f.Pc=471;continue;}
case 471:{return rt.Call(f,"forge/game/card/Card","getPhasedOut","()Lforge/game/player/Player;","invokevirtual",474);}
case 474:{return rt.Call(f,"forge/game/GameState","getPlayerString","(Lforge/game/player/Player;)Ljava/lang/String;","invokevirtual",477);}
case 477:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",480);}
case 480:{f.StackOp("pop");f.Pc=481;continue;}
case 481:{f.Push(f.Locals[3]);f.Pc=482;continue;}
case 482:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",485);}
case 485:{f.Pc=f.Pop().Int==0?529:488;continue;}
case 488:{f.Push(f.Locals[4]);f.Pc=490;continue;}
case 490:{f.Push(JValue.R(rt.String("|FaceDown")));f.Pc=493;continue;}
case 493:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",496);}
case 496:{f.StackOp("pop");f.Pc=497;continue;}
case 497:{f.Push(f.Locals[3]);f.Pc=498;continue;}
case 498:{return rt.Call(f,"forge/game/card/Card","isManifested","()Z","invokevirtual",501);}
case 501:{f.Pc=f.Pop().Int==0?513:504;continue;}
case 504:{f.Push(f.Locals[4]);f.Pc=506;continue;}
case 506:{f.Push(JValue.R(rt.String(":Manifested")));f.Pc=509;continue;}
case 509:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",512);}
case 512:{f.StackOp("pop");f.Pc=513;continue;}
case 513:{f.Push(f.Locals[3]);f.Pc=514;continue;}
case 514:{return rt.Call(f,"forge/game/card/Card","isCloaked","()Z","invokevirtual",517);}
case 517:{f.Pc=f.Pop().Int==0?529:520;continue;}
case 520:{f.Push(f.Locals[4]);f.Pc=522;continue;}
case 522:{f.Push(JValue.R(rt.String(":Cloaked")));f.Pc=525;continue;}
case 525:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",528);}
case 528:{f.StackOp("pop");f.Pc=529;continue;}
case 529:{f.Push(f.Locals[3]);f.Pc=530;continue;}
case 530:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",533);}
case 533:{if(!rt.StaticReady(f,"forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"));f.Pc=536;continue;}
case 536:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",539);}
case 539:{f.Pc=f.Pop().Int==0?554:542;continue;}
case 542:{f.Push(f.Locals[4]);f.Pc=544;continue;}
case 544:{f.Push(JValue.R(rt.String("|Flipped")));f.Pc=547;continue;}
case 547:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",550);}
case 550:{f.StackOp("pop");f.Pc=551;continue;}
case 551:{f.Pc=675;continue;}
case 554:{f.Push(f.Locals[3]);f.Pc=555;continue;}
case 555:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",558);}
case 558:{if(!rt.StaticReady(f,"forge/card/CardStateName","Meld","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Meld","Lforge/card/CardStateName;"));f.Pc=561;continue;}
case 561:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",564);}
case 564:{f.Pc=f.Pop().Int==0?634:567;continue;}
case 567:{f.Push(f.Locals[4]);f.Pc=569;continue;}
case 569:{f.Push(JValue.R(rt.String("|Meld")));f.Pc=572;continue;}
case 572:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",575);}
case 575:{f.StackOp("pop");f.Pc=576;continue;}
case 576:{f.Push(f.Locals[3]);f.Pc=577;continue;}
case 577:{return rt.Call(f,"forge/game/card/Card","getMeldedWith","()Lforge/game/card/Card;","invokevirtual",580);}
case 580:{f.Pc=f.Pop().Reference==null?675:583;continue;}
case 583:{f.Push(f.Locals[3]);f.Pc=584;continue;}
case 584:{return rt.Call(f,"forge/game/card/Card","getMeldedWith","()Lforge/game/card/Card;","invokevirtual",587);}
case 587:{return rt.Call(f,"forge/game/card/Card","hasPaperFoil","()Z","invokevirtual",590);}
case 590:{f.Pc=f.Pop().Int==0?599:593;continue;}
case 593:{f.Push(JValue.R(rt.String("+")));f.Pc=596;continue;}
case 596:{f.Pc=602;continue;}
case 599:{f.Push(JValue.R(rt.String("")));f.Pc=602;continue;}
case 602:{f.Locals[5]=f.Pop();f.Pc=604;continue;}
case 604:{f.Push(f.Locals[4]);f.Pc=606;continue;}
case 606:{f.Push(JValue.R(rt.String(":")));f.Pc=609;continue;}
case 609:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",612);}
case 612:{f.StackOp("pop");f.Pc=613;continue;}
case 613:{f.Push(f.Locals[4]);f.Pc=615;continue;}
case 615:{f.Push(f.Locals[3]);f.Pc=616;continue;}
case 616:{return rt.Call(f,"forge/game/card/Card","getMeldedWith","()Lforge/game/card/Card;","invokevirtual",619);}
case 619:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",622);}
case 622:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",625);}
case 625:{f.Push(f.Locals[5]);f.Pc=627;continue;}
case 627:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",630);}
case 630:{f.StackOp("pop");f.Pc=631;continue;}
case 631:{f.Pc=675;continue;}
case 634:{f.Push(f.Locals[3]);f.Pc=635;continue;}
case 635:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",638);}
case 638:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=641;continue;}
case 641:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",644);}
case 644:{f.Pc=f.Pop().Int==0?675:647;continue;}
case 647:{f.Push(f.Locals[3]);f.Pc=648;continue;}
case 648:{return rt.Call(f,"forge/game/card/Card","isModal","()Z","invokevirtual",651);}
case 651:{f.Pc=f.Pop().Int==0?666:654;continue;}
case 654:{f.Push(f.Locals[4]);f.Pc=656;continue;}
case 656:{f.Push(JValue.R(rt.String("|Modal")));f.Pc=659;continue;}
case 659:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",662);}
case 662:{f.StackOp("pop");f.Pc=663;continue;}
case 663:{f.Pc=675;continue;}
case 666:{f.Push(f.Locals[4]);f.Pc=668;continue;}
case 668:{f.Push(JValue.R(rt.String("|Transformed")));f.Pc=671;continue;}
case 671:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",674);}
case 674:{f.StackOp("pop");f.Pc=675;continue;}
case 675:{f.Push(f.Locals[3]);f.Pc=676;continue;}
case 676:{return rt.Call(f,"forge/game/card/Card","getPlayerAttachedTo","()Lforge/game/player/Player;","invokevirtual",679);}
case 679:{f.Pc=f.Pop().Reference==null?708:682;continue;}
case 682:{f.Push(f.Locals[4]);f.Pc=684;continue;}
case 684:{f.Push(JValue.R(rt.String("|EnchantingPlayer:")));f.Pc=687;continue;}
case 687:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",690);}
case 690:{f.StackOp("pop");f.Pc=691;continue;}
case 691:{f.Push(f.Locals[4]);f.Pc=693;continue;}
case 693:{f.Push(f.Locals[0]);f.Pc=694;continue;}
case 694:{f.Push(f.Locals[3]);f.Pc=695;continue;}
case 695:{return rt.Call(f,"forge/game/card/Card","getPlayerAttachedTo","()Lforge/game/player/Player;","invokevirtual",698);}
case 698:{return rt.Call(f,"forge/game/GameState","getPlayerString","(Lforge/game/player/Player;)Ljava/lang/String;","invokevirtual",701);}
case 701:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",704);}
case 704:{f.StackOp("pop");f.Pc=705;continue;}
case 705:{f.Pc=734;continue;}
case 708:{f.Push(f.Locals[3]);f.Pc=709;continue;}
case 709:{return rt.Call(f,"forge/game/card/Card","isAttachedToEntity","()Z","invokevirtual",712);}
case 712:{f.Pc=f.Pop().Int==0?734:715;continue;}
case 715:{f.Push(f.Locals[4]);f.Pc=717;continue;}
case 717:{f.Push(JValue.R(rt.String("|AttachedTo:")));f.Pc=720;continue;}
case 720:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",723);}
case 723:{f.Push(f.Locals[3]);f.Pc=724;continue;}
case 724:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",727);}
case 727:{return rt.Call(f,"forge/game/GameEntity","getId","()I","invokevirtual",730);}
case 730:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",733);}
case 733:{f.StackOp("pop");f.Pc=734;continue;}
case 734:{f.Push(f.Locals[3]);f.Pc=735;continue;}
case 735:{return rt.Call(f,"forge/game/card/Card","getDamage","()I","invokevirtual",738);}
case 738:{f.Pc=f.Pop().Int<=0?757:741;continue;}
case 741:{f.Push(f.Locals[4]);f.Pc=743;continue;}
case 743:{f.Push(JValue.R(rt.String("|Damage:")));f.Pc=746;continue;}
case 746:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",749);}
case 749:{f.Push(f.Locals[3]);f.Pc=750;continue;}
case 750:{return rt.Call(f,"forge/game/card/Card","getDamage","()I","invokevirtual",753);}
case 753:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",756);}
case 756:{f.StackOp("pop");f.Pc=757;continue;}
case 757:{f.Push(f.Locals[3]);f.Pc=758;continue;}
case 758:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","()Z","invokevirtual",761);}
case 761:{f.Pc=f.Pop().Int==0?786:764;continue;}
case 764:{f.Push(f.Locals[4]);f.Pc=766;continue;}
case 766:{f.Push(JValue.R(rt.String("|ChosenColor:")));f.Pc=769;continue;}
case 769:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",772);}
case 772:{f.Push(f.Locals[3]);f.Pc=773;continue;}
case 773:{return rt.Call(f,"forge/game/card/Card","getChosenColors","()Ljava/lang/Iterable;","invokevirtual",776);}
case 776:{f.Push(JValue.R(rt.String(",")));f.Pc=779;continue;}
case 779:{return rt.Call(f,"forge/util/TextUtil","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",782);}
case 782:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",785);}
case 785:{f.StackOp("pop");f.Pc=786;continue;}
case 786:{f.Push(f.Locals[3]);f.Pc=787;continue;}
case 787:{return rt.Call(f,"forge/game/card/Card","hasChosenType","()Z","invokevirtual",790);}
case 790:{f.Pc=f.Pop().Int==0?809:793;continue;}
case 793:{f.Push(f.Locals[4]);f.Pc=795;continue;}
case 795:{f.Push(JValue.R(rt.String("|ChosenType:")));f.Pc=798;continue;}
case 798:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",801);}
case 801:{f.Push(f.Locals[3]);f.Pc=802;continue;}
case 802:{return rt.Call(f,"forge/game/card/Card","getChosenType","()Ljava/lang/String;","invokevirtual",805);}
case 805:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",808);}
case 808:{f.StackOp("pop");f.Pc=809;continue;}
case 809:{f.Push(f.Locals[3]);f.Pc=810;continue;}
case 810:{return rt.Call(f,"forge/game/card/Card","hasChosenType2","()Z","invokevirtual",813);}
case 813:{f.Pc=f.Pop().Int==0?832:816;continue;}
case 816:{f.Push(f.Locals[4]);f.Pc=818;continue;}
case 818:{f.Push(JValue.R(rt.String("|ChosenType2:")));f.Pc=821;continue;}
case 821:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",824);}
case 824:{f.Push(f.Locals[3]);f.Pc=825;continue;}
case 825:{return rt.Call(f,"forge/game/card/Card","getChosenType2","()Ljava/lang/String;","invokevirtual",828);}
case 828:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",831);}
case 831:{f.StackOp("pop");f.Pc=832;continue;}
case 832:{f.Push(f.Locals[3]);f.Pc=833;continue;}
case 833:{return rt.Call(f,"forge/game/card/Card","getNamedCard","()Ljava/lang/String;","invokevirtual",836);}
case 836:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",839);}
case 839:{f.Pc=f.Pop().Int!=0?858:842;continue;}
case 842:{f.Push(f.Locals[4]);f.Pc=844;continue;}
case 844:{f.Push(JValue.R(rt.String("|NamedCard:")));f.Pc=847;continue;}
case 847:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",850);}
case 850:{f.Push(f.Locals[3]);f.Pc=851;continue;}
case 851:{return rt.Call(f,"forge/game/card/Card","getNamedCard","()Ljava/lang/String;","invokevirtual",854);}
case 854:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",857);}
case 857:{f.StackOp("pop");f.Pc=858;continue;}
case 858:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",861);}
case 861:{f.Locals[5]=f.Pop();f.Pc=863;continue;}
case 863:{f.Push(f.Locals[3]);f.Pc=864;continue;}
case 864:{return rt.Call(f,"forge/game/card/Card","getChosenCards","()Lforge/game/card/CardCollectionView;","invokevirtual",867);}
case 867:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",872);}
case 872:{f.Locals[6]=f.Pop();f.Pc=874;continue;}
case 874:{f.Push(f.Locals[6]);f.Pc=876;continue;}
case 876:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",881);}
case 881:{f.Pc=f.Pop().Int==0?915:884;continue;}
case 884:{f.Push(f.Locals[6]);f.Pc=886;continue;}
case 886:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",891);}
case 891:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=894;continue;}
case 894:{f.Locals[7]=f.Pop();f.Pc=896;continue;}
case 896:{f.Push(f.Locals[5]);f.Pc=898;continue;}
case 898:{f.Push(f.Locals[7]);f.Pc=900;continue;}
case 900:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",903);}
case 903:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",906);}
case 906:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",911);}
case 911:{f.StackOp("pop");f.Pc=912;continue;}
case 912:{f.Pc=874;continue;}
case 915:{f.Push(f.Locals[5]);f.Pc=917;continue;}
case 917:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",922);}
case 922:{f.Pc=f.Pop().Int!=0?945:925;continue;}
case 925:{f.Push(f.Locals[4]);f.Pc=927;continue;}
case 927:{f.Push(JValue.R(rt.String("|ChosenCards:")));f.Pc=930;continue;}
case 930:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",933);}
case 933:{f.Push(f.Locals[5]);f.Pc=935;continue;}
case 935:{f.Push(JValue.R(rt.String(",")));f.Pc=938;continue;}
case 938:{return rt.Call(f,"forge/util/TextUtil","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",941);}
case 941:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",944);}
case 944:{f.StackOp("pop");f.Pc=945;continue;}
case 945:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",948);}
case 948:{f.Locals[6]=f.Pop();f.Pc=950;continue;}
case 950:{f.Push(f.Locals[3]);f.Pc=951;continue;}
case 951:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",954);}
case 954:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",959);}
case 959:{f.Locals[7]=f.Pop();f.Pc=961;continue;}
case 961:{f.Push(f.Locals[7]);f.Pc=963;continue;}
case 963:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",968);}
case 968:{f.Pc=f.Pop().Int==0?1014:971;continue;}
case 971:{f.Push(f.Locals[7]);f.Pc=973;continue;}
case 973:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",978);}
case 978:{f.Locals[8]=f.Pop();f.Pc=980;continue;}
case 980:{f.Push(f.Locals[8]);f.Pc=982;continue;}
case 982:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=985;continue;}
case 985:{f.Pc=f.Pop().Int==0?1011:988;continue;}
case 988:{f.Push(f.Locals[8]);f.Pc=990;continue;}
case 990:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=993;continue;}
case 993:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",996);}
case 996:{f.Locals[9]=f.Pop();f.Pc=998;continue;}
case 998:{f.Push(f.Locals[6]);f.Pc=1000;continue;}
case 1000:{f.Push(f.Locals[9]);f.Pc=1002;continue;}
case 1002:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",1005);}
case 1005:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1010);}
case 1010:{f.StackOp("pop");f.Pc=1011;continue;}
case 1011:{f.Pc=961;continue;}
case 1014:{f.Push(f.Locals[6]);f.Pc=1016;continue;}
case 1016:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1021);}
case 1021:{f.Pc=f.Pop().Int!=0?1044:1024;continue;}
case 1024:{f.Push(f.Locals[4]);f.Pc=1026;continue;}
case 1026:{f.Push(JValue.R(rt.String("|RememberedCards:")));f.Pc=1029;continue;}
case 1029:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1032);}
case 1032:{f.Push(f.Locals[6]);f.Pc=1034;continue;}
case 1034:{f.Push(JValue.R(rt.String(",")));f.Pc=1037;continue;}
case 1037:{return rt.Call(f,"forge/util/TextUtil","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1040);}
case 1040:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1043);}
case 1043:{f.StackOp("pop");f.Pc=1044;continue;}
case 1044:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",1047);}
case 1047:{f.Locals[7]=f.Pop();f.Pc=1049;continue;}
case 1049:{f.Push(f.Locals[3]);f.Pc=1050;continue;}
case 1050:{return rt.Call(f,"forge/game/card/Card","getImprintedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",1053);}
case 1053:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1058);}
case 1058:{f.Locals[8]=f.Pop();f.Pc=1060;continue;}
case 1060:{f.Push(f.Locals[8]);f.Pc=1062;continue;}
case 1062:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1067);}
case 1067:{f.Pc=f.Pop().Int==0?1105:1070;continue;}
case 1070:{f.Push(f.Locals[8]);f.Pc=1072;continue;}
case 1072:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1077);}
case 1077:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1080;continue;}
case 1080:{f.Locals[9]=f.Pop();f.Pc=1082;continue;}
case 1082:{f.Push(f.Locals[9]);f.Pc=1084;continue;}
case 1084:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",1087);}
case 1087:{f.Locals[10]=f.Pop();f.Pc=1089;continue;}
case 1089:{f.Push(f.Locals[7]);f.Pc=1091;continue;}
case 1091:{f.Push(f.Locals[10]);f.Pc=1093;continue;}
case 1093:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",1096);}
case 1096:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1101);}
case 1101:{f.StackOp("pop");f.Pc=1102;continue;}
case 1102:{f.Pc=1060;continue;}
case 1105:{f.Push(f.Locals[7]);f.Pc=1107;continue;}
case 1107:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1112);}
case 1112:{f.Pc=f.Pop().Int!=0?1135:1115;continue;}
case 1115:{f.Push(f.Locals[4]);f.Pc=1117;continue;}
case 1117:{f.Push(JValue.R(rt.String("|Imprinting:")));f.Pc=1120;continue;}
case 1120:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1123);}
case 1123:{f.Push(f.Locals[7]);f.Pc=1125;continue;}
case 1125:{f.Push(JValue.R(rt.String(",")));f.Pc=1128;continue;}
case 1128:{return rt.Call(f,"forge/util/TextUtil","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1131);}
case 1131:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1134);}
case 1134:{f.StackOp("pop");f.Pc=1135;continue;}
case 1135:{f.Push(f.Locals[3]);f.Pc=1136;continue;}
case 1136:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",1139);}
case 1139:{f.Pc=f.Pop().Int==0?1246:1142;continue;}
case 1142:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=1145;continue;}
case 1145:{f.StackOp("dup");f.Pc=1146;continue;}
case 1146:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",1149);}
case 1149:{f.Locals[8]=f.Pop();f.Pc=1151;continue;}
case 1151:{f.Push(f.Locals[3]);f.Pc=1152;continue;}
case 1152:{return rt.Call(f,"forge/game/card/Card","getMergedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",1155);}
case 1155:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1160);}
case 1160:{f.Locals[9]=f.Pop();f.Pc=1162;continue;}
case 1162:{f.Push(f.Locals[9]);f.Pc=1164;continue;}
case 1164:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1169);}
case 1169:{f.Pc=f.Pop().Int==0?1226:1172;continue;}
case 1172:{f.Push(f.Locals[9]);f.Pc=1174;continue;}
case 1174:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1179);}
case 1179:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1182;continue;}
case 1182:{f.Locals[10]=f.Pop();f.Pc=1184;continue;}
case 1184:{f.Push(f.Locals[3]);f.Pc=1185;continue;}
case 1185:{return rt.Call(f,"forge/game/card/Card","getTopMergedCard","()Lforge/game/card/Card;","invokevirtual",1188);}
case 1188:{f.Push(f.Locals[10]);f.Pc=1190;continue;}
case 1190:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1196:1193;continue;}
case 1193:{f.Pc=1162;continue;}
case 1196:{f.Push(f.Locals[8]);f.Pc=1198;continue;}
case 1198:{f.Push(f.Locals[10]);f.Pc=1200;continue;}
case 1200:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",1203);}
case 1203:{return rt.Call(f,"forge/item/IPaperCard","getName","()Ljava/lang/String;","invokeinterface",1208);}
case 1208:{f.Push(JValue.R(rt.String(",")));f.Pc=1211;continue;}
case 1211:{f.Push(JValue.R(rt.String("^")));f.Pc=1214;continue;}
case 1214:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",1217);}
case 1217:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1222);}
case 1222:{f.StackOp("pop");f.Pc=1223;continue;}
case 1223:{f.Pc=1162;continue;}
case 1226:{f.Push(f.Locals[4]);f.Pc=1228;continue;}
case 1228:{f.Push(JValue.R(rt.String("|MergedCards:")));f.Pc=1231;continue;}
case 1231:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1234);}
case 1234:{f.Push(f.Locals[8]);f.Pc=1236;continue;}
case 1236:{f.Push(JValue.R(rt.String(",")));f.Pc=1239;continue;}
case 1239:{return rt.Call(f,"forge/util/TextUtil","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1242);}
case 1242:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1245);}
case 1245:{f.StackOp("pop");f.Pc=1246;continue;}
case 1246:{f.Push(f.Locals[3]);f.Pc=1247;continue;}
case 1247:{return rt.Call(f,"forge/game/card/Card","getClassLevel","()I","invokevirtual",1250);}
case 1250:{f.Push(JValue.I(1));f.Pc=1251;continue;}
case 1251:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1270:1254;continue;}
case 1254:{f.Push(f.Locals[4]);f.Pc=1256;continue;}
case 1256:{f.Push(JValue.R(rt.String("|ClassLevel:")));f.Pc=1259;continue;}
case 1259:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1262);}
case 1262:{f.Push(f.Locals[3]);f.Pc=1263;continue;}
case 1263:{return rt.Call(f,"forge/game/card/Card","getClassLevel","()I","invokevirtual",1266);}
case 1266:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",1269);}
case 1269:{f.StackOp("pop");f.Pc=1270;continue;}
case 1270:{f.Push(f.Locals[1]);f.Pc=1271;continue;}
case 1271:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=1274;continue;}
case 1274:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1380:1277;continue;}
case 1277:{f.Push(f.Locals[3]);f.Pc=1278;continue;}
case 1278:{return rt.Call(f,"forge/game/card/Card","getExiledWith","()Lforge/game/card/Card;","invokevirtual",1281);}
case 1281:{f.Pc=f.Pop().Reference==null?1303:1284;continue;}
case 1284:{f.Push(f.Locals[4]);f.Pc=1286;continue;}
case 1286:{f.Push(JValue.R(rt.String("|ExiledWith:")));f.Pc=1289;continue;}
case 1289:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1292);}
case 1292:{f.Push(f.Locals[3]);f.Pc=1293;continue;}
case 1293:{return rt.Call(f,"forge/game/card/Card","getExiledWith","()Lforge/game/card/Card;","invokevirtual",1296);}
case 1296:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",1299);}
case 1299:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",1302);}
case 1302:{f.StackOp("pop");f.Pc=1303;continue;}
case 1303:{f.Push(f.Locals[3]);f.Pc=1304;continue;}
case 1304:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",1307);}
case 1307:{f.Pc=f.Pop().Int==0?1319:1310;continue;}
case 1310:{f.Push(f.Locals[4]);f.Pc=1312;continue;}
case 1312:{f.Push(JValue.R(rt.String("|FaceDown")));f.Pc=1315;continue;}
case 1315:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1318);}
case 1318:{f.StackOp("pop");f.Pc=1319;continue;}
case 1319:{f.Push(f.Locals[3]);f.Pc=1320;continue;}
case 1320:{return rt.Call(f,"forge/game/card/Card","isAdventureCard","()Z","invokevirtual",1323);}
case 1323:{f.Pc=f.Pop().Int==0?1348:1326;continue;}
case 1326:{f.Push(f.Locals[3]);f.Pc=1327;continue;}
case 1327:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",1330);}
case 1330:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=1333;continue;}
case 1333:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",1336);}
case 1336:{f.Pc=f.Pop().Int==0?1348:1339;continue;}
case 1339:{f.Push(f.Locals[4]);f.Pc=1341;continue;}
case 1341:{f.Push(JValue.R(rt.String("|OnAdventure")));f.Pc=1344;continue;}
case 1344:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1347);}
case 1347:{f.StackOp("pop");f.Pc=1348;continue;}
case 1348:{f.Push(f.Locals[3]);f.Pc=1349;continue;}
case 1349:{return rt.Call(f,"forge/game/card/Card","isForetold","()Z","invokevirtual",1352);}
case 1352:{f.Pc=f.Pop().Int==0?1380:1355;continue;}
case 1355:{f.Push(f.Locals[4]);f.Pc=1357;continue;}
case 1357:{f.Push(JValue.R(rt.String("|Foretold")));f.Pc=1360;continue;}
case 1360:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1363);}
case 1363:{f.StackOp("pop");f.Pc=1364;continue;}
case 1364:{f.Push(f.Locals[3]);f.Pc=1365;continue;}
case 1365:{return rt.Call(f,"forge/game/card/Card","enteredThisTurn","()Z","invokevirtual",1368);}
case 1368:{f.Pc=f.Pop().Int==0?1380:1371;continue;}
case 1371:{f.Push(f.Locals[4]);f.Pc=1373;continue;}
case 1373:{f.Push(JValue.R(rt.String("|ForetoldThisTurn")));f.Pc=1376;continue;}
case 1376:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1379);}
case 1379:{f.StackOp("pop");f.Pc=1380;continue;}
case 1380:{f.Push(f.Locals[1]);f.Pc=1381;continue;}
case 1381:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1384;continue;}
case 1384:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1394:1387;continue;}
case 1387:{f.Push(f.Locals[1]);f.Pc=1388;continue;}
case 1388:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=1391;continue;}
case 1391:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1429:1394;continue;}
case 1394:{f.Push(f.Locals[3]);f.Pc=1395;continue;}
case 1395:{return rt.Call(f,"forge/game/card/Card","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",1398);}
case 1398:{return rt.Call(f,"com/google/common/collect/Multiset","isEmpty","()Z","invokeinterface",1403);}
case 1403:{f.Pc=f.Pop().Int!=0?1429:1406;continue;}
case 1406:{f.Push(f.Locals[4]);f.Pc=1408;continue;}
case 1408:{f.Push(JValue.R(rt.String("|Counters:")));f.Pc=1411;continue;}
case 1411:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1414);}
case 1414:{f.StackOp("pop");f.Pc=1415;continue;}
case 1415:{f.Push(f.Locals[4]);f.Pc=1417;continue;}
case 1417:{f.Push(f.Locals[0]);f.Pc=1418;continue;}
case 1418:{f.Push(f.Locals[3]);f.Pc=1419;continue;}
case 1419:{return rt.Call(f,"forge/game/card/Card","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",1422);}
case 1422:{return rt.Call(f,"forge/game/GameState","countersToString","(Lcom/google/common/collect/Multiset;)Ljava/lang/String;","invokevirtual",1425);}
case 1425:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1428);}
case 1428:{f.StackOp("pop");f.Pc=1429;continue;}
case 1429:{f.Push(f.Locals[3]);f.Pc=1430;continue;}
case 1430:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",1433);}
case 1433:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",1436);}
case 1436:{f.Pc=f.Pop().Reference==null?1500:1439;continue;}
case 1439:{f.Push(f.Locals[3]);f.Pc=1440;continue;}
case 1440:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",1443);}
case 1443:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",1446);}
case 1446:{f.Push(f.Locals[3]);f.Pc=1447;continue;}
case 1447:{return rt.Call(f,"forge/game/combat/Combat","isAttacking","(Lforge/game/card/Card;)Z","invokevirtual",1450);}
case 1450:{f.Pc=f.Pop().Int==0?1500:1453;continue;}
case 1453:{f.Push(f.Locals[4]);f.Pc=1455;continue;}
case 1455:{f.Push(JValue.R(rt.String("|Attacking")));f.Pc=1458;continue;}
case 1458:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1461);}
case 1461:{f.StackOp("pop");f.Pc=1462;continue;}
case 1462:{f.Push(f.Locals[3]);f.Pc=1463;continue;}
case 1463:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",1466);}
case 1466:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",1469);}
case 1469:{f.Push(f.Locals[3]);f.Pc=1470;continue;}
case 1470:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",1473);}
case 1473:{f.Locals[5]=f.Pop();f.Pc=1475;continue;}
case 1475:{f.Push(f.Locals[5]);f.Pc=1477;continue;}
case 1477:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=1480;continue;}
case 1480:{f.Pc=f.Pop().Int==0?1500:1483;continue;}
case 1483:{f.Push(f.Locals[4]);f.Pc=1485;continue;}
case 1485:{f.Push(JValue.R(rt.String(":")));f.Pc=1488;continue;}
case 1488:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1491);}
case 1491:{f.Push(f.Locals[5]);f.Pc=1493;continue;}
case 1493:{return rt.Call(f,"forge/game/GameEntity","getId","()I","invokevirtual",1496);}
case 1496:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",1499);}
case 1499:{f.StackOp("pop");f.Pc=1500;continue;}
case 1500:{f.Push(f.Locals[3]);f.Pc=1501;continue;}
case 1501:{return rt.Call(f,"forge/game/card/Card","getUnlockedRooms","()Ljava/util/Set;","invokevirtual",1504);}
case 1504:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",1509);}
case 1509:{f.Pc=f.Pop().Int!=0?1568:1512;continue;}
case 1512:{f.Push(f.Locals[3]);f.Pc=1513;continue;}
case 1513:{return rt.Call(f,"forge/game/card/Card","getUnlockedRooms","()Ljava/util/Set;","invokevirtual",1516);}
case 1516:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",1521);}
case 1521:{f.Locals[5]=f.Pop();f.Pc=1523;continue;}
case 1523:{f.Push(f.Locals[5]);f.Pc=1525;continue;}
case 1525:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1530);}
case 1530:{f.Pc=f.Pop().Int==0?1568:1533;continue;}
case 1533:{f.Push(f.Locals[5]);f.Pc=1535;continue;}
case 1535:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1540);}
case 1540:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardStateName"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1543;continue;}
case 1543:{f.Locals[6]=f.Pop();f.Pc=1545;continue;}
case 1545:{f.Push(f.Locals[4]);f.Pc=1547;continue;}
case 1547:{f.Push(JValue.R(rt.String("|UnlockedRoom:")));f.Pc=1550;continue;}
case 1550:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1553);}
case 1553:{f.StackOp("pop");f.Pc=1554;continue;}
case 1554:{f.Push(f.Locals[4]);f.Pc=1556;continue;}
case 1556:{f.Push(f.Locals[6]);f.Pc=1558;continue;}
case 1558:{return rt.Call(f,"forge/card/CardStateName","name","()Ljava/lang/String;","invokevirtual",1561);}
case 1561:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1564);}
case 1564:{f.StackOp("pop");f.Pc=1565;continue;}
case 1565:{f.Pc=1523;continue;}
case 1568:{f.Push(f.Locals[2]);f.Pc=1569;continue;}
case 1569:{f.Push(f.Locals[1]);f.Pc=1570;continue;}
case 1570:{f.Push(f.Locals[4]);f.Pc=1572;continue;}
case 1572:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1575);}
case 1575:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1580);}
case 1580:{f.StackOp("pop");f.Pc=1581;continue;}
case 1581:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2589(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"com/google/common/collect/Multiset","entrySet","()Ljava/util/Set;","invokeinterface",16);}
case 16:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?108:33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[5]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Pc=f.Pop().Int!=0?57:49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String(",")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{f.Locals[2]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{f.Push(JValue.I(3));f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=64;continue;}
case 64:{f.StackOp("dup");f.Pc=65;continue;}
case 65:{f.Push(JValue.I(0));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",73);}
case 73:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",79);}
case 79:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=80;continue;}
case 80:{f.StackOp("dup");f.Pc=81;continue;}
case 81:{f.Push(JValue.I(1));f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("=")));f.Pc=84;continue;}
case 84:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=85;continue;}
case 85:{f.StackOp("dup");f.Pc=86;continue;}
case 86:{f.Push(JValue.I(2));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",94);}
case 94:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",97);}
case 97:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",101);}
case 101:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",104);}
case 104:{f.StackOp("pop");f.Pc=105;continue;}
case 105:{f.Pc=23;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",112);}
case 112:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2590(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",5);}
case 5:{f.Push(JValue.I(35));f.Pc=7;continue;}
case 7:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?12:10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("=")));f.Pc=15;continue;}
case 15:{f.Push(JValue.I(2));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=22;continue;}
case 22:{f.Push(JValue.I(2));f.Pc=23;continue;}
case 23:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?28:26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return JStep.Return(f.Pop());}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=30;continue;}
case 30:{f.Push(JValue.I(1));f.Pc=31;continue;}
case 31:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?60:34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("=")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?60:43;continue;}
case 43:{f.Push(JValue.I(2));f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=47;continue;}
case 47:{f.StackOp("dup");f.Pc=48;continue;}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=52;continue;}
case 52:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=53;continue;}
case 53:{f.StackOp("dup");f.Pc=54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("")));f.Pc=58;continue;}
case 58:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=59;continue;}
case 59:{return JStep.Return(f.Pop());}
case 60:{f.Push(JValue.R(null));f.Pc=61;continue;}
case 61:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2591(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/BufferedReader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/BufferedReader")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"java/io/InputStreamReader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/InputStreamReader")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/io/InputStreamReader","<init>","(Ljava/io/InputStream;)V","invokespecial",12);}
case 12:{return rt.Call(f,"java/io/BufferedReader","<init>","(Ljava/io/Reader;)V","invokespecial",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/io/BufferedReader","lines","()Ljava/util/stream/Stream;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/game/GameState","parse","(Ljava/util/stream/Stream;)V","invokevirtual",24);}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2592(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",7);}
case 7:{return rt.Call(f,"forge/game/GameState","parse","(Ljava/util/stream/Stream;)V","invokevirtual",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2593(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.DynamicCall(f,"forge/game/GameState:2593:11:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/GameState;)Ljava/util/function/Consumer;",16);}
case 16:{return rt.Call(f,"java/util/stream/Stream","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",21);}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2594(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",10);}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?33:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"forge/game/GameState$PlayerState"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameState$PlayerState")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/GameState$PlayerState","<init>","()V","invokespecial",24);}
case 24:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{f.Pc=0;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameState$PlayerState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2595(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("human")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?16:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/GameState","getPlayerState","(I)Lforge/game/GameState$PlayerState;","invokevirtual",15);}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("ai")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?32:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/GameState","getPlayerState","(I)Lforge/game/GameState$PlayerState;","invokevirtual",31);}
case 31:{return JStep.Return(f.Pop());}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("p")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int==0?69:42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",47);}
case 47:{return rt.Call(f,"java/lang/Character","isDigit","(C)Z","invokestatic",50);}
case 50:{f.Pc=f.Pop().Int==0?69:53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(JValue.I(1));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",59);}
case 59:{return rt.Call(f,"java/lang/String","valueOf","(C)Ljava/lang/String;","invokestatic",62);}
case 62:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",65);}
case 65:{return rt.Call(f,"forge/game/GameState","getPlayerState","(I)Lforge/game/GameState$PlayerState;","invokevirtual",68);}
case 68:{return JStep.Return(f.Pop());}
case 69:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return rt.DynamicCall(f,"forge/game/GameState:2595:73:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",78);}
case 78:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",81);}
case 81:{if(!rt.EnsureInitialized(f,"forge/game/GameState$PlayerState"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameState$PlayerState")));f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/GameState$PlayerState","<init>","()V","invokespecial",88);}
case 88:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2596(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameState","splitLine","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference!=null?11:10;continue;}
case 10:{return JStep.ReturnVoid;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=21;continue;}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("active")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?106:33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("player")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?58:43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",49);}
case 49:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",52);}
case 52:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","tChangePlayer","Ljava/lang/String;",value);f.Pc=55;continue;}
case 55:{f.Pc=105;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("phase")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?83:68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",74);}
case 74:{return rt.Call(f,"java/lang/String","toUpperCase","()Ljava/lang/String;","invokevirtual",77);}
case 77:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","tChangePhase","Ljava/lang/String;",value);f.Pc=80;continue;}
case 80:{f.Pc=105;continue;}
case 83:{f.Push(f.Locals[3]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("phaseadvance")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?105:93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[4]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",99);}
case 99:{return rt.Call(f,"java/lang/String","toUpperCase","()Ljava/lang/String;","invokevirtual",102);}
case 102:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","tAdvancePhase","Ljava/lang/String;",value);f.Pc=105;continue;}
case 105:{return JStep.ReturnVoid;}
case 106:{f.Push(f.Locals[3]);f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("turn")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int==0?128:116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[4]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",122);}
case 122:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","turn","I",value);f.Pc=125;continue;}
case 125:{f.Pc=653;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.String("removesummoningsickness")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",135);}
case 135:{f.Pc=f.Pop().Int==0?153:138;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[4]);f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String("true")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",147);}
case 147:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState","removeSummoningSickness","Z",value);f.Pc=150;continue;}
case 150:{f.Pc=653;continue;}
case 153:{f.Push(f.Locals[3]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("life")));f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",160);}
case 160:{f.Pc=f.Pop().Int==0?179:163;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[3]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",168);}
case 168:{f.Push(f.Locals[4]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",173);}
case 173:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","life","I",value);f.Pc=176;continue;}
case 176:{f.Pc=653;continue;}
case 179:{f.Push(f.Locals[3]);f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("counters")));f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",186);}
case 186:{f.Pc=f.Pop().Int==0?202:189;continue;}
case 189:{f.Push(f.Locals[0]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[3]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",194);}
case 194:{f.Push(f.Locals[4]);f.Pc=196;continue;}
case 196:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","counters","Ljava/lang/String;",value);f.Pc=199;continue;}
case 199:{f.Pc=653;continue;}
case 202:{f.Push(f.Locals[3]);f.Pc=203;continue;}
case 203:{f.Push(JValue.R(rt.String("landsplayed")));f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",209);}
case 209:{f.Pc=f.Pop().Int==0?228:212;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[3]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",217);}
case 217:{f.Push(f.Locals[4]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",222);}
case 222:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","landsPlayed","I",value);f.Pc=225;continue;}
case 225:{f.Pc=653;continue;}
case 228:{f.Push(f.Locals[3]);f.Pc=229;continue;}
case 229:{f.Push(JValue.R(rt.String("numringtemptedyou")));f.Pc=232;continue;}
case 232:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",235);}
case 235:{f.Pc=f.Pop().Int==0?254:238;continue;}
case 238:{f.Push(f.Locals[0]);f.Pc=239;continue;}
case 239:{f.Push(f.Locals[3]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",243);}
case 243:{f.Push(f.Locals[4]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",248);}
case 248:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","numRingTemptedYou","I",value);f.Pc=251;continue;}
case 251:{f.Pc=653;continue;}
case 254:{f.Push(f.Locals[3]);f.Pc=255;continue;}
case 255:{f.Push(JValue.R(rt.String("speed")));f.Pc=258;continue;}
case 258:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",261);}
case 261:{f.Pc=f.Pop().Int==0?280:264;continue;}
case 264:{f.Push(f.Locals[0]);f.Pc=265;continue;}
case 265:{f.Push(f.Locals[3]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",269);}
case 269:{f.Push(f.Locals[4]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",274);}
case 274:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","speed","I",value);f.Pc=277;continue;}
case 277:{f.Pc=653;continue;}
case 280:{f.Push(f.Locals[3]);f.Pc=281;continue;}
case 281:{f.Push(JValue.R(rt.String("play")));f.Pc=284;continue;}
case 284:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",287);}
case 287:{f.Pc=f.Pop().Int!=0?300:290;continue;}
case 290:{f.Push(f.Locals[3]);f.Pc=291;continue;}
case 291:{f.Push(JValue.R(rt.String("battlefield")));f.Pc=294;continue;}
case 294:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",297);}
case 297:{f.Pc=f.Pop().Int==0?322:300;continue;}
case 300:{f.Push(f.Locals[0]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[3]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",305);}
case 305:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","cardTexts","Ljava/util/Map;"));f.Pc=308;continue;}
case 308:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=311;continue;}
case 311:{f.Push(f.Locals[4]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",318);}
case 318:{f.StackOp("pop");f.Pc=319;continue;}
case 319:{f.Pc=653;continue;}
case 322:{f.Push(f.Locals[3]);f.Pc=323;continue;}
case 323:{f.Push(JValue.R(rt.String("hand")));f.Pc=326;continue;}
case 326:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",329);}
case 329:{f.Pc=f.Pop().Int==0?354:332;continue;}
case 332:{f.Push(f.Locals[0]);f.Pc=333;continue;}
case 333:{f.Push(f.Locals[3]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",337);}
case 337:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","cardTexts","Ljava/util/Map;"));f.Pc=340;continue;}
case 340:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=343;continue;}
case 343:{f.Push(f.Locals[4]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",350);}
case 350:{f.StackOp("pop");f.Pc=351;continue;}
case 351:{f.Pc=653;continue;}
case 354:{f.Push(f.Locals[3]);f.Pc=355;continue;}
case 355:{f.Push(JValue.R(rt.String("graveyard")));f.Pc=358;continue;}
case 358:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",361);}
case 361:{f.Pc=f.Pop().Int==0?386:364;continue;}
case 364:{f.Push(f.Locals[0]);f.Pc=365;continue;}
case 365:{f.Push(f.Locals[3]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",369);}
case 369:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","cardTexts","Ljava/util/Map;"));f.Pc=372;continue;}
case 372:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=375;continue;}
case 375:{f.Push(f.Locals[4]);f.Pc=377;continue;}
case 377:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",382);}
case 382:{f.StackOp("pop");f.Pc=383;continue;}
case 383:{f.Pc=653;continue;}
case 386:{f.Push(f.Locals[3]);f.Pc=387;continue;}
case 387:{f.Push(JValue.R(rt.String("library")));f.Pc=390;continue;}
case 390:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",393);}
case 393:{f.Pc=f.Pop().Int==0?418:396;continue;}
case 396:{f.Push(f.Locals[0]);f.Pc=397;continue;}
case 397:{f.Push(f.Locals[3]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",401);}
case 401:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","cardTexts","Ljava/util/Map;"));f.Pc=404;continue;}
case 404:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=407;continue;}
case 407:{f.Push(f.Locals[4]);f.Pc=409;continue;}
case 409:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",414);}
case 414:{f.StackOp("pop");f.Pc=415;continue;}
case 415:{f.Pc=653;continue;}
case 418:{f.Push(f.Locals[3]);f.Pc=419;continue;}
case 419:{f.Push(JValue.R(rt.String("exile")));f.Pc=422;continue;}
case 422:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",425);}
case 425:{f.Pc=f.Pop().Int==0?450:428;continue;}
case 428:{f.Push(f.Locals[0]);f.Pc=429;continue;}
case 429:{f.Push(f.Locals[3]);f.Pc=430;continue;}
case 430:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",433);}
case 433:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","cardTexts","Ljava/util/Map;"));f.Pc=436;continue;}
case 436:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=439;continue;}
case 439:{f.Push(f.Locals[4]);f.Pc=441;continue;}
case 441:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",446);}
case 446:{f.StackOp("pop");f.Pc=447;continue;}
case 447:{f.Pc=653;continue;}
case 450:{f.Push(f.Locals[3]);f.Pc=451;continue;}
case 451:{f.Push(JValue.R(rt.String("command")));f.Pc=454;continue;}
case 454:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",457);}
case 457:{f.Pc=f.Pop().Int==0?482:460;continue;}
case 460:{f.Push(f.Locals[0]);f.Pc=461;continue;}
case 461:{f.Push(f.Locals[3]);f.Pc=462;continue;}
case 462:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",465);}
case 465:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","cardTexts","Ljava/util/Map;"));f.Pc=468;continue;}
case 468:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=471;continue;}
case 471:{f.Push(f.Locals[4]);f.Pc=473;continue;}
case 473:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",478);}
case 478:{f.StackOp("pop");f.Pc=479;continue;}
case 479:{f.Pc=653;continue;}
case 482:{f.Push(f.Locals[3]);f.Pc=483;continue;}
case 483:{f.Push(JValue.R(rt.String("sideboard")));f.Pc=486;continue;}
case 486:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",489);}
case 489:{f.Pc=f.Pop().Int==0?514:492;continue;}
case 492:{f.Push(f.Locals[0]);f.Pc=493;continue;}
case 493:{f.Push(f.Locals[3]);f.Pc=494;continue;}
case 494:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",497);}
case 497:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","cardTexts","Ljava/util/Map;"));f.Pc=500;continue;}
case 500:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"));f.Pc=503;continue;}
case 503:{f.Push(f.Locals[4]);f.Pc=505;continue;}
case 505:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",510);}
case 510:{f.StackOp("pop");f.Pc=511;continue;}
case 511:{f.Pc=653;continue;}
case 514:{f.Push(f.Locals[3]);f.Pc=515;continue;}
case 515:{f.Push(JValue.R(rt.String("ability")));f.Pc=518;continue;}
case 518:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",521);}
case 521:{f.Pc=f.Pop().Int==0?549:524;continue;}
case 524:{f.Push(f.Locals[0]);f.Pc=525;continue;}
case 525:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","abilityString","Ljava/util/Map;"));f.Pc=528;continue;}
case 528:{f.Push(f.Locals[3]);f.Pc=529;continue;}
case 529:{f.Push(JValue.R(rt.String("ability")));f.Pc=532;continue;}
case 532:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",535);}
case 535:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",538);}
case 538:{f.Push(f.Locals[4]);f.Pc=540;continue;}
case 540:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",545);}
case 545:{f.StackOp("pop");f.Pc=546;continue;}
case 546:{f.Pc=653;continue;}
case 549:{f.Push(f.Locals[3]);f.Pc=550;continue;}
case 550:{f.Push(JValue.R(rt.String("precast")));f.Pc=553;continue;}
case 553:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",556);}
case 556:{f.Pc=f.Pop().Int==0?572:559;continue;}
case 559:{f.Push(f.Locals[0]);f.Pc=560;continue;}
case 560:{f.Push(f.Locals[3]);f.Pc=561;continue;}
case 561:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",564);}
case 564:{f.Push(f.Locals[4]);f.Pc=566;continue;}
case 566:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","precast","Ljava/lang/String;",value);f.Pc=569;continue;}
case 569:{f.Pc=653;continue;}
case 572:{f.Push(f.Locals[3]);f.Pc=573;continue;}
case 573:{f.Push(JValue.R(rt.String("putonstack")));f.Pc=576;continue;}
case 576:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",579);}
case 579:{f.Pc=f.Pop().Int==0?595:582;continue;}
case 582:{f.Push(f.Locals[0]);f.Pc=583;continue;}
case 583:{f.Push(f.Locals[3]);f.Pc=584;continue;}
case 584:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",587);}
case 587:{f.Push(f.Locals[4]);f.Pc=589;continue;}
case 589:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","putOnStack","Ljava/lang/String;",value);f.Pc=592;continue;}
case 592:{f.Pc=653;continue;}
case 595:{f.Push(f.Locals[3]);f.Pc=596;continue;}
case 596:{f.Push(JValue.R(rt.String("manapool")));f.Pc=599;continue;}
case 599:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",602);}
case 602:{f.Pc=f.Pop().Int==0?618:605;continue;}
case 605:{f.Push(f.Locals[0]);f.Pc=606;continue;}
case 606:{f.Push(f.Locals[3]);f.Pc=607;continue;}
case 607:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",610);}
case 610:{f.Push(f.Locals[4]);f.Pc=612;continue;}
case 612:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","manaPool","Ljava/lang/String;",value);f.Pc=615;continue;}
case 615:{f.Pc=653;continue;}
case 618:{f.Push(f.Locals[3]);f.Pc=619;continue;}
case 619:{f.Push(JValue.R(rt.String("persistentmana")));f.Pc=622;continue;}
case 622:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",625);}
case 625:{f.Pc=f.Pop().Int==0?641:628;continue;}
case 628:{f.Push(f.Locals[0]);f.Pc=629;continue;}
case 629:{f.Push(f.Locals[3]);f.Pc=630;continue;}
case 630:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",633);}
case 633:{f.Push(f.Locals[4]);f.Pc=635;continue;}
case 635:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameState$PlayerState","persistentMana","Ljava/lang/String;",value);f.Pc=638;continue;}
case 638:{f.Pc=653;continue;}
case 641:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=644;continue;}
case 644:{f.Push(f.Locals[3]);f.Pc=645;continue;}
case 645:{return rt.DynamicCall(f,"forge/game/GameState:2596:645:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",650);}
case 650:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",653);}
case 653:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2597(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.DynamicCall(f,"forge/game/GameState:2597:6:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/GameState;Lforge/game/Game;)Ljava/lang/Runnable;",11);}
case 11:{return rt.Call(f,"forge/game/GameAction","invoke","(Ljava/lang/Runnable;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2598(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",16);}
case 16:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?48:19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",30);}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",39);}
case 39:{return rt.DynamicCall(f,"forge/game/GameState:2598:39:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(II)Ljava/lang/String;",44);}
case 44:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",47);}
case 47:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","idToCard","Ljava/util/Map;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",57);}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToAttachId","Ljava/util/Map;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",66);}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToEnchantPlayerId","Ljava/util/Map;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",75);}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToRememberedId","Ljava/util/Map;"));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",84);}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToExiledWithId","Ljava/util/Map;"));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",93);}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToImprintedId","Ljava/util/Map;"));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",102);}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","markedDamage","Ljava/util/Map;"));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",111);}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToChosenClrs","Ljava/util/Map;"));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",120);}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToChosenCards","Ljava/util/Map;"));f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",129);}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToChosenType","Ljava/util/Map;"));f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",138);}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToChosenType2","Ljava/util/Map;"));f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",147);}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToMergedCards","Ljava/util/Map;"));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",156);}
case 156:{f.Push(f.Locals[0]);f.Pc=157;continue;}
case 157:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToScript","Ljava/util/Map;"));f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",165);}
case 165:{f.Push(f.Locals[0]);f.Pc=166;continue;}
case 166:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardAttackMap","Ljava/util/Map;"));f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",174);}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=178;continue;}
case 178:{f.Push(f.Locals[0]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[0]);f.Pc=180;continue;}
case 180:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","tChangePlayer","Ljava/lang/String;"));f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/GameState","getPlayerState","(Ljava/lang/String;)Lforge/game/GameState$PlayerState;","invokevirtual",186);}
case 186:{return rt.Call(f,"java/util/List","indexOf","(Ljava/lang/Object;)I","invokeinterface",191);}
case 191:{f.Locals[2]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[1]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",196);}
case 196:{f.Push(f.Locals[2]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",200);}
case 200:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=203;continue;}
case 203:{f.Locals[3]=f.Pop();f.Pc=204;continue;}
case 204:{f.Push(f.Locals[0]);f.Pc=205;continue;}
case 205:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","tChangePhase","Ljava/lang/String;"));f.Pc=208;continue;}
case 208:{f.Push(JValue.R(rt.String("none")));f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",214);}
case 214:{f.Pc=f.Pop().Int==0?221:217;continue;}
case 217:{f.Push(JValue.R(null));f.Pc=218;continue;}
case 218:{f.Pc=228;continue;}
case 221:{f.Push(f.Locals[0]);f.Pc=222;continue;}
case 222:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","tChangePhase","Ljava/lang/String;"));f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/game/phase/PhaseType","smartValueOf","(Ljava/lang/String;)Lforge/game/phase/PhaseType;","invokestatic",228);}
case 228:{f.Locals[4]=f.Pop();f.Pc=230;continue;}
case 230:{f.Push(f.Locals[0]);f.Pc=231;continue;}
case 231:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","tAdvancePhase","Ljava/lang/String;"));f.Pc=234;continue;}
case 234:{f.Push(JValue.R(rt.String("none")));f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",240);}
case 240:{f.Pc=f.Pop().Int==0?247:243;continue;}
case 243:{f.Push(JValue.R(null));f.Pc=244;continue;}
case 244:{f.Pc=254;continue;}
case 247:{f.Push(f.Locals[0]);f.Pc=248;continue;}
case 248:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","tAdvancePhase","Ljava/lang/String;"));f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/phase/PhaseType","smartValueOf","(Ljava/lang/String;)Lforge/game/phase/PhaseType;","invokestatic",254);}
case 254:{f.Locals[5]=f.Pop();f.Pc=256;continue;}
case 256:{f.Push(f.Locals[1]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",260);}
case 260:{f.Push(JValue.I(1));f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/zone/MagicStack","setFrozen","(Z)V","invokevirtual",264);}
case 264:{f.Push(f.Locals[1]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",268);}
case 268:{f.Push(JValue.I(1));f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/trigger/TriggerHandler","setSuppressAllTriggers","(Z)V","invokevirtual",272);}
case 272:{f.Push(f.Locals[1]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",276);}
case 276:{f.Push(f.Locals[4]);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[3]);f.Pc=279;continue;}
case 279:{f.Push(f.Locals[0]);f.Pc=280;continue;}
case 280:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","turn","I"));f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/phase/PhaseHandler","devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;I)V","invokevirtual",286);}
case 286:{f.Push(JValue.I(0));f.Pc=287;continue;}
case 287:{f.Locals[6]=f.Pop();f.Pc=289;continue;}
case 289:{f.Push(f.Locals[6]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[0]);f.Pc=292;continue;}
case 292:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=295;continue;}
case 295:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",300);}
case 300:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?339:303;continue;}
case 303:{f.Push(f.Locals[0]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[1]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",308);}
case 308:{f.Push(f.Locals[6]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",313);}
case 313:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=316;continue;}
case 316:{f.Push(f.Locals[0]);f.Pc=317;continue;}
case 317:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=320;continue;}
case 320:{f.Push(f.Locals[6]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",327);}
case 327:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameState$PlayerState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/GameState","setupPlayerState","(Lforge/game/player/Player;Lforge/game/GameState$PlayerState;)V","invokevirtual",333);}
case 333:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=336;continue;}
case 336:{f.Pc=289;continue;}
case 339:{f.Push(f.Locals[0]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/game/GameState","handleCardAttachments","()V","invokevirtual",343);}
case 343:{f.Push(f.Locals[0]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/GameState","handleChosenEntities","()V","invokevirtual",347);}
case 347:{f.Push(f.Locals[0]);f.Pc=348;continue;}
case 348:{return rt.Call(f,"forge/game/GameState","handleRememberedEntities","()V","invokevirtual",351);}
case 351:{f.Push(f.Locals[0]);f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/game/GameState","handleMergedCards","()V","invokevirtual",355);}
case 355:{f.Push(f.Locals[0]);f.Pc=356;continue;}
case 356:{f.Push(f.Locals[1]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/GameState","handleScriptExecution","(Lforge/game/Game;)V","invokevirtual",360);}
case 360:{f.Push(f.Locals[0]);f.Pc=361;continue;}
case 361:{f.Push(f.Locals[1]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/GameState","handlePrecastSpells","(Lforge/game/Game;)V","invokevirtual",365);}
case 365:{f.Push(f.Locals[0]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/GameState","handleMarkedDamage","()V","invokevirtual",369);}
case 369:{f.Push(f.Locals[1]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",373);}
case 373:{f.Push(JValue.I(0));f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/game/trigger/TriggerHandler","setSuppressAllTriggers","(Z)V","invokevirtual",377);}
case 377:{f.Push(f.Locals[0]);f.Pc=378;continue;}
case 378:{f.Push(f.Locals[1]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/game/GameState","handleAddSAsToStack","(Lforge/game/Game;)V","invokevirtual",382);}
case 382:{f.Push(f.Locals[4]);f.Pc=384;continue;}
case 384:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;"));f.Pc=387;continue;}
case 387:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?398:390;continue;}
case 390:{f.Push(f.Locals[4]);f.Pc=392;continue;}
case 392:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"));f.Pc=395;continue;}
case 395:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?429:398;continue;}
case 398:{f.Push(f.Locals[4]);f.Pc=400;continue;}
case 400:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"));f.Pc=403;continue;}
case 403:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?410:406;continue;}
case 406:{f.Push(JValue.I(1));f.Pc=407;continue;}
case 407:{f.Pc=411;continue;}
case 410:{f.Push(JValue.I(0));f.Pc=411;continue;}
case 411:{f.Locals[6]=f.Pop();f.Pc=413;continue;}
case 413:{f.Push(f.Locals[3]);f.Pc=414;continue;}
case 414:{f.Pc=f.Pop().Reference==null?429:417;continue;}
case 417:{f.Push(f.Locals[0]);f.Pc=418;continue;}
case 418:{f.Push(f.Locals[1]);f.Pc=419;continue;}
case 419:{f.Push(f.Locals[3]);f.Pc=420;continue;}
case 420:{f.Push(f.Locals[3]);f.Pc=421;continue;}
case 421:{return rt.Call(f,"forge/game/player/Player","getSingleOpponent","()Lforge/game/player/Player;","invokevirtual",424);}
case 424:{f.Push(f.Locals[6]);f.Pc=426;continue;}
case 426:{return rt.Call(f,"forge/game/GameState","handleCombat","(Lforge/game/Game;Lforge/game/player/Player;Lforge/game/player/Player;Z)V","invokevirtual",429);}
case 429:{f.Push(f.Locals[1]);f.Pc=430;continue;}
case 430:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",433);}
case 433:{return rt.Call(f,"forge/game/zone/MagicStack","unfreezeStack","()V","invokevirtual",436);}
case 436:{f.Push(f.Locals[5]);f.Pc=438;continue;}
case 438:{f.Pc=f.Pop().Reference==null?451:441;continue;}
case 441:{f.Push(f.Locals[1]);f.Pc=442;continue;}
case 442:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",445);}
case 445:{f.Push(f.Locals[5]);f.Pc=447;continue;}
case 447:{return rt.Call(f,"forge/game/phase/PhaseHandler","devAdvanceToPhase","(Lforge/game/phase/PhaseType;)Z","invokevirtual",450);}
case 450:{f.StackOp("pop");f.Pc=451;continue;}
case 451:{f.Push(f.Locals[0]);f.Pc=452;continue;}
case 452:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","removeSummoningSickness","Z"));f.Pc=455;continue;}
case 455:{f.Pc=f.Pop().Int==0?500:458;continue;}
case 458:{f.Push(f.Locals[1]);f.Pc=459;continue;}
case 459:{return rt.Call(f,"forge/game/Game","getCardsInGame","()Lforge/game/card/CardCollectionView;","invokevirtual",462);}
case 462:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",467);}
case 467:{f.Locals[6]=f.Pop();f.Pc=469;continue;}
case 469:{f.Push(f.Locals[6]);f.Pc=471;continue;}
case 471:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",476);}
case 476:{f.Pc=f.Pop().Int==0?500:479;continue;}
case 479:{f.Push(f.Locals[6]);f.Pc=481;continue;}
case 481:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",486);}
case 486:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=489;continue;}
case 489:{f.Locals[7]=f.Pop();f.Pc=491;continue;}
case 491:{f.Push(f.Locals[7]);f.Pc=493;continue;}
case 493:{f.Push(JValue.I(0));f.Pc=494;continue;}
case 494:{return rt.Call(f,"forge/game/card/Card","setSickness","(Z)V","invokevirtual",497);}
case 497:{f.Pc=469;continue;}
case 500:{f.Push(f.Locals[1]);f.Pc=501;continue;}
case 501:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",504);}
case 504:{f.Push(JValue.I(1));f.Pc=505;continue;}
case 505:{return rt.Call(f,"forge/game/GameAction","checkStateEffects","(Z)Z","invokevirtual",508);}
case 508:{f.StackOp("pop");f.Pc=509;continue;}
case 509:{f.Push(f.Locals[1]);f.Pc=510;continue;}
case 510:{return rt.Call(f,"forge/game/Game","copyLastState","()V","invokevirtual",513);}
case 513:{f.Push(f.Locals[1]);f.Pc=514;continue;}
case 514:{return rt.Call(f,"forge/game/Game","stashGameState","()V","invokevirtual",517);}
case 517:{f.Push(JValue.I(0));f.Pc=518;continue;}
case 518:{f.Locals[6]=f.Pop();f.Pc=520;continue;}
case 520:{f.Push(f.Locals[6]);f.Pc=522;continue;}
case 522:{f.Push(f.Locals[0]);f.Pc=523;continue;}
case 523:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=526;continue;}
case 526:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",531);}
case 531:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?583:534;continue;}
case 534:{f.Push(f.Locals[0]);f.Pc=535;continue;}
case 535:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=538;continue;}
case 538:{f.Push(f.Locals[6]);f.Pc=540;continue;}
case 540:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",545);}
case 545:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameState$PlayerState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=548;continue;}
case 548:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","life","I"));f.Pc=551;continue;}
case 551:{f.Locals[7]=f.Pop();f.Pc=553;continue;}
case 553:{f.Push(f.Locals[7]);f.Pc=555;continue;}
case 555:{f.Pc=f.Pop().Int>0?577:558;continue;}
case 558:{f.Push(f.Locals[1]);f.Pc=559;continue;}
case 559:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",562);}
case 562:{f.Push(f.Locals[6]);f.Pc=564;continue;}
case 564:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",567);}
case 567:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=570;continue;}
case 570:{f.Push(f.Locals[7]);f.Pc=572;continue;}
case 572:{f.Push(JValue.R(null));f.Pc=573;continue;}
case 573:{return rt.Call(f,"forge/game/player/Player","setLife","(ILforge/game/spellability/SpellAbility;)Z","invokevirtual",576);}
case 576:{f.StackOp("pop");f.Pc=577;continue;}
case 577:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=580;continue;}
case 580:{f.Pc=520;continue;}
case 583:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2599(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/card/mana/ManaAtom","MANATYPES","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaAtom","MANATYPES","[B"));f.Pc=11;continue;}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=14;continue;}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{f.Locals[5]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[5]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?78:26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[5]);f.Pc=29;continue;}
case 29:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=30;continue;}
case 30:{f.Locals[6]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[6]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/mana/ManaPool","getAmountOfColor","(B)I","invokevirtual",38);}
case 38:{f.Locals[7]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{f.Locals[8]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[8]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[7]);f.Pc=47;continue;}
case 47:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?72:50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[6]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",56);}
case 56:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",59);}
case 59:{f.Push(JValue.R(rt.String(" ")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=69;continue;}
case 69:{f.Pc=43;continue;}
case 72:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=75;continue;}
case 75:{f.Pc=19;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",82);}
case 82:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",85);}
case 85:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2600(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Int==0?19:10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",14);}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/mana/ManaPool","clearPool","(Z)Ljava/util/List;","invokevirtual",18);}
case 18:{f.StackOp("pop");f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?110:26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(-777777));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/game/Game;)V","invokespecial",38);}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","setOwner","(Lforge/game/player/Player;)V","invokevirtual",46);}
case 46:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",49);}
case 49:{f.Locals[7]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[7]);f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.String("Produced")));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{f.Pc=f.Pop().Int==0?82:68;continue;}
case 68:{f.Push(f.Locals[7]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("PersistentMana")));f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("True")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",81);}
case 81:{f.StackOp("pop");f.Pc=82;continue;}
case 82:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AbilityManaPart"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AbilityManaPart")));f.Pc=85;continue;}
case 85:{f.StackOp("dup");f.Pc=86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[7]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","<init>","(Lforge/game/card/Card;Ljava/util/Map;)V","invokespecial",93);}
case 93:{f.Locals[8]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[5]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",100);}
case 100:{f.Push(f.Locals[8]);f.Pc=102;continue;}
case 102:{return rt.DynamicCall(f,"forge/game/GameState:2600:102:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/spellability/AbilityManaPart;)Ljava/lang/Runnable;",107);}
case 107:{return rt.Call(f,"forge/game/GameAction","invoke","(Ljava/lang/Runnable;)V","invokevirtual",110);}
case 110:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2601(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","turn","I"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/phase/PhaseHandler","devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;I)V","invokevirtual",15);}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",19);}
case 19:{return rt.Call(f,"forge/game/phase/PhaseHandler","getCombat","()Lforge/game/combat/Combat;","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Reference!=null?44:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",29);}
case 29:{if(!rt.EnsureInitialized(f,"forge/game/combat/Combat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/Combat")));f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/combat/Combat","<init>","(Lforge/game/player/Player;)V","invokespecial",37);}
case 37:{return rt.Call(f,"forge/game/phase/PhaseHandler","setCombat","(Lforge/game/combat/Combat;)V","invokevirtual",40);}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",44);}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",48);}
case 48:{return rt.Call(f,"forge/game/phase/PhaseHandler","getCombat","()Lforge/game/combat/Combat;","invokevirtual",51);}
case 51:{f.Locals[5]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardAttackMap","Ljava/util/Map;"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",62);}
case 62:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",67);}
case 67:{f.Locals[6]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[6]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",76);}
case 76:{f.Pc=f.Pop().Int==0?136:79;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",86);}
case 86:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=89;continue;}
case 89:{f.Locals[7]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",98);}
case 98:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=101;continue;}
case 101:{f.Locals[8]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[7]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",110);}
case 110:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=113;continue;}
case 113:{f.Locals[9]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[5]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[8]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[9]);f.Pc=121;continue;}
case 121:{f.Pc=f.Pop().Reference!=null?128:124;continue;}
case 124:{f.Push(f.Locals[3]);f.Pc=125;continue;}
case 125:{f.Pc=130;continue;}
case 128:{f.Push(f.Locals[9]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/combat/Combat","addAttacker","(Lforge/game/card/Card;Lforge/game/GameEntity;)V","invokevirtual",133);}
case 133:{f.Pc=69;continue;}
case 136:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",139);}
case 139:{f.Locals[6]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[5]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/combat/Combat","getDefenders","()Lforge/util/collect/FCollectionView;","invokevirtual",146);}
case 146:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",151);}
case 151:{f.Locals[7]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[7]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",160);}
case 160:{f.Pc=f.Pop().Int==0?195:163;continue;}
case 163:{f.Push(f.Locals[7]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",170);}
case 170:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=173;continue;}
case 173:{f.Locals[8]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[6]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[8]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[5]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[8]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/combat/Combat","getAttackersOf","(Lforge/game/GameEntity;)Lforge/game/card/CardCollection;","invokevirtual",186);}
case 186:{return rt.Call(f,"com/google/common/collect/Multimap","putAll","(Ljava/lang/Object;Ljava/lang/Iterable;)Z","invokeinterface",191);}
case 191:{f.StackOp("pop");f.Pc=192;continue;}
case 192:{f.Pc=153;continue;}
case 195:{f.Push(f.Locals[1]);f.Pc=196;continue;}
case 196:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAttackersDeclared"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAttackersDeclared")));f.Pc=199;continue;}
case 199:{f.StackOp("dup");f.Pc=200;continue;}
case 200:{f.Push(f.Locals[2]);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[6]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/event/GameEventAttackersDeclared","<init>","(Lforge/game/player/Player;Lcom/google/common/collect/Multimap;)V","invokespecial",206);}
case 206:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",209);}
case 209:{f.Push(f.Locals[5]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",214);}
case 214:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",217);}
case 217:{f.Locals[7]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[7]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",226);}
case 226:{f.Pc=f.Pop().Int==0?253:229;continue;}
case 229:{f.Push(f.Locals[7]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",236);}
case 236:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=239;continue;}
case 239:{f.Locals[8]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[1]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[8]);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[5]);f.Pc=246;continue;}
case 246:{f.Push(JValue.I(0));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/combat/CombatUtil","checkDeclaredAttacker","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/combat/Combat;Z)V","invokestatic",250);}
case 250:{f.Pc=219;continue;}
case 253:{f.Push(f.Locals[1]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",257);}
case 257:{f.Push(f.Locals[1]);f.Pc=258;continue;}
case 258:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=261;continue;}
case 261:{f.StackOp("dup");f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",265);}
case 265:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",268);}
case 268:{f.Push(f.Locals[1]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",272);}
case 272:{return rt.Call(f,"forge/game/zone/MagicStack","addAllTriggeredAbilitiesToStack","()Z","invokevirtual",275);}
case 275:{f.StackOp("pop");f.Pc=276;continue;}
case 276:{f.Push(f.Locals[4]);f.Pc=278;continue;}
case 278:{f.Pc=f.Pop().Int==0?302:281;continue;}
case 281:{f.Push(f.Locals[1]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",285);}
case 285:{return rt.Call(f,"forge/game/zone/MagicStack","isEmpty","()Z","invokevirtual",288);}
case 288:{f.Pc=f.Pop().Int==0?302:291;continue;}
case 291:{f.Push(f.Locals[1]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",295);}
case 295:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"));f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/game/phase/PhaseHandler","devAdvanceToPhase","(Lforge/game/phase/PhaseType;)Z","invokevirtual",301);}
case 301:{f.StackOp("pop");f.Pc=302;continue;}
case 302:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2602(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToRememberedId","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?120:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",62);}
case 62:{f.Locals[5]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",71);}
case 71:{f.Pc=f.Pop().Int==0?117:74;continue;}
case 74:{f.Push(f.Locals[5]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",81);}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{f.Locals[6]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","idToCard","Ljava/util/Map;"));f.Pc=90;continue;}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",95);}
case 95:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",98);}
case 98:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",103);}
case 103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=106;continue;}
case 106:{f.Locals[7]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[7]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",114);}
case 114:{f.Pc=64;continue;}
case 117:{f.Pc=15;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToImprintedId","Ljava/util/Map;"));f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",129);}
case 129:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",134);}
case 134:{f.Locals[1]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",141);}
case 141:{f.Pc=f.Pop().Int==0?240:144;continue;}
case 144:{f.Push(f.Locals[1]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",150);}
case 150:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=153;continue;}
case 153:{f.Locals[2]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[2]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",160);}
case 160:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=163;continue;}
case 163:{f.Locals[3]=f.Pop();f.Pc=164;continue;}
case 164:{f.Push(f.Locals[2]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",170);}
case 170:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=173;continue;}
case 173:{f.Locals[4]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[4]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",182);}
case 182:{f.Locals[5]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(f.Locals[5]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",191);}
case 191:{f.Pc=f.Pop().Int==0?237:194;continue;}
case 194:{f.Push(f.Locals[5]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",201);}
case 201:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=204;continue;}
case 204:{f.Locals[6]=f.Pop();f.Pc=206;continue;}
case 206:{f.Push(f.Locals[0]);f.Pc=207;continue;}
case 207:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","idToCard","Ljava/util/Map;"));f.Pc=210;continue;}
case 210:{f.Push(f.Locals[6]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",215);}
case 215:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",218);}
case 218:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",223);}
case 223:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=226;continue;}
case 226:{f.Locals[7]=f.Pop();f.Pc=228;continue;}
case 228:{f.Push(f.Locals[3]);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[7]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",234);}
case 234:{f.Pc=184;continue;}
case 237:{f.Pc=135;continue;}
case 240:{f.Push(f.Locals[0]);f.Pc=241;continue;}
case 241:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToExiledWithId","Ljava/util/Map;"));f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",249);}
case 249:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",254);}
case 254:{f.Locals[1]=f.Pop();f.Pc=255;continue;}
case 255:{f.Push(f.Locals[1]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",261);}
case 261:{f.Pc=f.Pop().Int==0?346:264;continue;}
case 264:{f.Push(f.Locals[1]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",270);}
case 270:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=273;continue;}
case 273:{f.Locals[2]=f.Pop();f.Pc=274;continue;}
case 274:{f.Push(f.Locals[2]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",280);}
case 280:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=283;continue;}
case 283:{f.Locals[3]=f.Pop();f.Pc=284;continue;}
case 284:{f.Push(f.Locals[2]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",290);}
case 290:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=293;continue;}
case 293:{f.Locals[4]=f.Pop();f.Pc=295;continue;}
case 295:{f.Push(f.Locals[0]);f.Pc=296;continue;}
case 296:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","idToCard","Ljava/util/Map;"));f.Pc=299;continue;}
case 299:{f.Push(f.Locals[4]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",304);}
case 304:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",307);}
case 307:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",312);}
case 312:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=315;continue;}
case 315:{f.Locals[5]=f.Pop();f.Pc=317;continue;}
case 317:{f.Push(f.Locals[5]);f.Pc=319;continue;}
case 319:{f.Pc=f.Pop().Reference==null?343:322;continue;}
case 322:{f.Push(f.Locals[5]);f.Pc=324;continue;}
case 324:{f.Push(f.Locals[3]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/game/card/Card","addExiledCard","(Lforge/game/card/Card;)V","invokevirtual",328);}
case 328:{f.Push(f.Locals[3]);f.Pc=329;continue;}
case 329:{f.Push(f.Locals[5]);f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/game/card/Card","setExiledWith","(Lforge/game/card/Card;)V","invokevirtual",334);}
case 334:{f.Push(f.Locals[3]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[5]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",340);}
case 340:{return rt.Call(f,"forge/game/card/Card","setExiledBy","(Lforge/game/player/Player;)V","invokevirtual",343);}
case 343:{f.Pc=255;continue;}
case 346:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2603(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("human")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?16:10;continue;}
case 10:{f.Push(JValue.I(-2));f.Pc=12;continue;}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Pc=37;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("ai")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?32:26;continue;}
case 26:{f.Push(JValue.I(-3));f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Pc=37;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",36);}
case 36:{f.Locals[2]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2604(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",4);}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",17);}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",21);}
case 21:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=24;continue;}
case 24:{f.Locals[5]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(JValue.I(-1));f.Pc=28;continue;}
case 28:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?110:31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{switch(f.Pop().Int){case -3:f.Pc=73;break;case -2:f.Pc=60;break;default:f.Pc=86;break;}continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",64);}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/spellability/TargetChoices","add","(Lforge/game/GameObject;)Z","invokevirtual",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Pc=110;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",77);}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/spellability/TargetChoices","add","(Lforge/game/GameObject;)Z","invokevirtual",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Pc=110;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",90);}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","idToCard","Ljava/util/Map;"));f.Pc=94;continue;}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",98);}
case 98:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",103);}
case 103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/spellability/TargetChoices","add","(Lforge/game/GameObject;)Z","invokevirtual",109);}
case 109:{f.StackOp("pop");f.Pc=110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String("RememberTargets")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",117);}
case 117:{f.Pc=f.Pop().Int==0?131:120;continue;}
case 120:{f.Push(f.Locals[2]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",124);}
case 124:{f.Push(f.Locals[2]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",128);}
case 128:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",131);}
case 131:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2605(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToScript","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?68:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[4]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[5]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/GameState","executeScript","(Lforge/game/Game;Lforge/game/card/Card;Ljava/lang/String;)V","invokevirtual",65);}
case 65:{f.Pc=15;continue;}
case 68:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2606(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameState","executeScript","(Lforge/game/Game;Lforge/game/card/Card;Ljava/lang/String;Z)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2607(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(-1));f.Pc=1;continue;}
case 1:{f.Locals[5]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("->")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?49:13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("->")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","lastIndexOf","(Ljava/lang/String;)I","invokevirtual",21);}
case 21:{f.Push(JValue.I(2));f.Pc=22;continue;}
case 22:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Locals[6]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[6]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/GameState","parseTargetInScript","(Ljava/lang/String;)I","invokevirtual",34);}
case 34:{f.Locals[5]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("->")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","lastIndexOf","(Ljava/lang/String;)I","invokevirtual",45);}
case 45:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Locals[3]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(JValue.R(null));f.Pc=50;continue;}
case 50:{f.Locals[6]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",56);}
case 56:{f.Pc=f.Pop().Int==0?118:59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",63);}
case 63:{f.Locals[7]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/Card","getSpellAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",69);}
case 69:{return rt.Call(f,"forge/util/collect/FCollectionView","size","()I","invokeinterface",74);}
case 74:{f.Push(f.Locals[7]);f.Pc=76;continue;}
case 76:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?98:79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/card/Card","getSpellAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",83);}
case 83:{f.Push(f.Locals[7]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/util/collect/FCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{f.Locals[6]=f.Pop();f.Pc=95;continue;}
case 95:{f.Pc=115;continue;}
case 98:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=101;continue;}
case 101:{f.Push(f.Locals[7]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[2]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",107);}
case 107:{return rt.DynamicCall(f,"forge/game/GameState:2607:107:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(ILjava/lang/String;)Ljava/lang/String;",112);}
case 112:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",115);}
case 115:{f.Pc=435;continue;}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("KW#")));f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",125);}
case 125:{f.Pc=f.Pop().Int==0?279:128;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{f.Push(JValue.I(3));f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",133);}
case 133:{f.Locals[7]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[2]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/card/Card","getSpellAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",139);}
case 139:{f.Locals[8]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[7]);f.Pc=143;continue;}
case 143:{f.Push(JValue.R(rt.String("Awaken")));f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",149);}
case 149:{f.Pc=f.Pop().Int!=0?163:152;continue;}
case 152:{f.Push(f.Locals[7]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("AwakenOnly")));f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",160);}
case 160:{f.Pc=f.Pop().Int==0?276:163;continue;}
case 163:{f.Push(f.Locals[8]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",170);}
case 170:{f.Locals[9]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[9]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",179);}
case 179:{f.Pc=f.Pop().Int==0?255:182;continue;}
case 182:{f.Push(f.Locals[9]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",189);}
case 189:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=192;continue;}
case 192:{f.Locals[10]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[10]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",199);}
case 199:{f.Push(JValue.R(rt.String("Awaken")));f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",205);}
case 205:{f.Pc=f.Pop().Int==0?252:208;continue;}
case 208:{f.Push(f.Locals[10]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[2]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",214);}
case 214:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",217);}
case 217:{f.Push(f.Locals[0]);f.Pc=218;continue;}
case 218:{f.Push(f.Locals[1]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[10]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",224);}
case 224:{f.Push(f.Locals[5]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/GameState","handleScriptedTargetingForSA","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;I)V","invokevirtual",229);}
case 229:{f.Push(f.Locals[7]);f.Pc=231;continue;}
case 231:{f.Push(JValue.R(rt.String("AwakenOnly")));f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",237);}
case 237:{f.Pc=f.Pop().Int==0?248:240;continue;}
case 240:{f.Push(f.Locals[10]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",245);}
case 245:{f.Pc=250;continue;}
case 248:{f.Push(f.Locals[10]);f.Pc=250;continue;}
case 250:{f.Locals[6]=f.Pop();f.Pc=252;continue;}
case 252:{f.Pc=172;continue;}
case 255:{f.Push(f.Locals[6]);f.Pc=257;continue;}
case 257:{f.Pc=f.Pop().Reference!=null?276:260;continue;}
case 260:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=263;continue;}
case 263:{f.Push(f.Locals[2]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",267);}
case 267:{return rt.DynamicCall(f,"forge/game/GameState:2607:267:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",272);}
case 272:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",275);}
case 275:{return JStep.ReturnVoid;}
case 276:{f.Pc=435;continue;}
case 279:{f.Push(JValue.R(rt.String("")));f.Pc=282;continue;}
case 282:{f.Locals[7]=f.Pop();f.Pc=284;continue;}
case 284:{f.Push(f.Locals[3]);f.Pc=285;continue;}
case 285:{f.Push(JValue.R(rt.String("CustomScript:")));f.Pc=288;continue;}
case 288:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",291);}
case 291:{f.Pc=f.Pop().Int==0?312:294;continue;}
case 294:{f.Push(f.Locals[3]);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[3]);f.Pc=296;continue;}
case 296:{f.Push(JValue.R(rt.String(":")));f.Pc=299;continue;}
case 299:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",302);}
case 302:{f.Push(JValue.I(1));f.Pc=303;continue;}
case 303:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",307);}
case 307:{f.Locals[7]=f.Pop();f.Pc=309;continue;}
case 309:{f.Pc=409;continue;}
case 312:{f.Push(f.Locals[2]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[3]);f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/card/Card","hasSVar","(Ljava/lang/String;)Z","invokevirtual",317);}
case 317:{f.Pc=f.Pop().Int!=0?337:320;continue;}
case 320:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=323;continue;}
case 323:{f.Push(f.Locals[3]);f.Pc=324;continue;}
case 324:{f.Push(f.Locals[2]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",328);}
case 328:{return rt.DynamicCall(f,"forge/game/GameState:2607:328:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",333);}
case 333:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",336);}
case 336:{return JStep.ReturnVoid;}
case 337:{f.Push(f.Locals[2]);f.Pc=338;continue;}
case 338:{f.Push(f.Locals[3]);f.Pc=339;continue;}
case 339:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",342);}
case 342:{f.Locals[7]=f.Pop();f.Pc=344;continue;}
case 344:{f.Push(f.Locals[5]);f.Pc=346;continue;}
case 346:{f.Push(JValue.I(-1));f.Pc=347;continue;}
case 347:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?409:350;continue;}
case 350:{f.Push(f.Locals[7]);f.Pc=352;continue;}
case 352:{f.Push(JValue.R(rt.String("| Defined$")));f.Pc=355;continue;}
case 355:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",358);}
case 358:{f.Pc=f.Pop().Int==0?409:361;continue;}
case 361:{f.Push(f.Locals[7]);f.Pc=363;continue;}
case 363:{f.Push(JValue.R(rt.String("| Defined$")));f.Pc=366;continue;}
case 366:{f.Push(JValue.R(rt.String("| Undefined$")));f.Pc=369;continue;}
case 369:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",372);}
case 372:{f.Locals[7]=f.Pop();f.Pc=374;continue;}
case 374:{f.Push(f.Locals[5]);f.Pc=376;continue;}
case 376:{f.Push(JValue.I(-2));f.Pc=378;continue;}
case 378:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?388:381;continue;}
case 381:{f.Push(f.Locals[5]);f.Pc=383;continue;}
case 383:{f.Push(JValue.I(-3));f.Pc=385;continue;}
case 385:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?400:388;continue;}
case 388:{f.Push(f.Locals[7]);f.Pc=390;continue;}
case 390:{return rt.DynamicCall(f,"forge/game/GameState:2607:390:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",395);}
case 395:{f.Locals[7]=f.Pop();f.Pc=397;continue;}
case 397:{f.Pc=409;continue;}
case 400:{f.Push(f.Locals[7]);f.Pc=402;continue;}
case 402:{return rt.DynamicCall(f,"forge/game/GameState:2607:402:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",407);}
case 407:{f.Locals[7]=f.Pop();f.Pc=409;continue;}
case 409:{f.Push(f.Locals[7]);f.Pc=411;continue;}
case 411:{f.Push(f.Locals[2]);f.Pc=412;continue;}
case 412:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",415);}
case 415:{f.Locals[6]=f.Pop();f.Pc=417;continue;}
case 417:{f.Push(f.Locals[6]);f.Pc=419;continue;}
case 419:{f.Pc=f.Pop().Reference!=null?435:422;continue;}
case 422:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=425;continue;}
case 425:{f.Push(f.Locals[7]);f.Pc=427;continue;}
case 427:{return rt.DynamicCall(f,"forge/game/GameState:2607:427:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",432);}
case 432:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",435);}
case 435:{f.Push(f.Locals[6]);f.Pc=437;continue;}
case 437:{f.Pc=f.Pop().Reference==null?449:440;continue;}
case 440:{f.Push(f.Locals[6]);f.Pc=442;continue;}
case 442:{f.Push(f.Locals[2]);f.Pc=443;continue;}
case 443:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",446);}
case 446:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",449);}
case 449:{f.Push(f.Locals[0]);f.Pc=450;continue;}
case 450:{f.Push(f.Locals[1]);f.Pc=451;continue;}
case 451:{f.Push(f.Locals[6]);f.Pc=453;continue;}
case 453:{f.Push(f.Locals[5]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/GameState","handleScriptedTargetingForSA","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;I)V","invokevirtual",458);}
case 458:{f.Push(f.Locals[4]);f.Pc=460;continue;}
case 460:{f.Pc=f.Pop().Int==0?475:463;continue;}
case 463:{f.Push(f.Locals[1]);f.Pc=464;continue;}
case 464:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",467);}
case 467:{f.Push(f.Locals[6]);f.Pc=469;continue;}
case 469:{return rt.Call(f,"forge/game/zone/MagicStack","addAndUnfreeze","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",472);}
case 472:{f.Pc=507;continue;}
case 475:{f.Push(f.Locals[6]);f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/game/spellability/SpellAbility","resolve","()V","invokevirtual",480);}
case 480:{f.Push(f.Locals[6]);f.Pc=482;continue;}
case 482:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",485);}
case 485:{f.Locals[7]=f.Pop();f.Pc=487;continue;}
case 487:{f.Push(f.Locals[7]);f.Pc=489;continue;}
case 489:{f.Pc=f.Pop().Reference==null?507:492;continue;}
case 492:{f.Push(f.Locals[7]);f.Pc=494;continue;}
case 494:{return rt.Call(f,"forge/game/spellability/SpellAbility","resolve","()V","invokevirtual",497);}
case 497:{f.Push(f.Locals[7]);f.Pc=499;continue;}
case 499:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",502);}
case 502:{f.Locals[7]=f.Pop();f.Pc=504;continue;}
case 504:{f.Pc=487;continue;}
case 507:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2608(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",12);}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?111:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameState$PlayerState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","precast","Ljava/lang/String;"));f.Pc=31;continue;}
case 31:{f.Pc=f.Pop().Reference==null?105:34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameState$PlayerState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","precast","Ljava/lang/String;"));f.Pc=50;continue;}
case 50:{f.Push(JValue.I(59));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",55);}
case 55:{f.Locals[3]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{f.Locals[4]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=62;continue;}
case 62:{f.Locals[5]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{f.Locals[6]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?105:74;continue;}
case 74:{f.Push(f.Locals[4]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[6]);f.Pc=78;continue;}
case 78:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=79;continue;}
case 79:{f.Locals[7]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[7]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",88);}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",92);}
case 92:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/GameState","precastSpellFromCard","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/Game;)V","invokevirtual",99);}
case 99:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=102;continue;}
case 102:{f.Pc=67;continue;}
case 105:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=108;continue;}
case 108:{f.Pc=2;continue;}
case 111:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2609(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",14);}
case 14:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?128:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameState$PlayerState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","putOnStack","Ljava/lang/String;"));f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Reference==null?122:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","playerStates","Ljava/util/List;"));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameState$PlayerState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","putOnStack","Ljava/lang/String;"));f.Pc=52;continue;}
case 52:{f.Push(JValue.I(59));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",57);}
case 57:{f.Locals[4]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{f.Locals[5]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=66;continue;}
case 66:{f.Locals[6]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{f.Locals[7]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[7]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?122:78;continue;}
case 78:{f.Push(f.Locals[5]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[7]);f.Pc=82;continue;}
case 82:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=83;continue;}
case 83:{f.Locals[8]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[8]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",92);}
case 92:{f.Push(f.Locals[3]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",96);}
case 96:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{f.Push(JValue.I(1));f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/GameState","precastSpellFromCard","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/Game;Z)V","invokevirtual",104);}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",108);}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",112);}
case 112:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=115;continue;}
case 115:{f.Locals[2]=f.Pop();f.Pc=116;continue;}
case 116:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=119;continue;}
case 119:{f.Pc=71;continue;}
case 122:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=125;continue;}
case 125:{f.Pc=4;continue;}
case 128:{f.Push(f.Locals[2]);f.Pc=129;continue;}
case 129:{f.Pc=f.Pop().Reference==null?140:132;continue;}
case 132:{f.Push(f.Locals[1]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",136);}
case 136:{f.Push(f.Locals[2]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPriority","(Lforge/game/player/Player;)V","invokevirtual",140);}
case 140:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2610(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameState","precastSpellFromCard","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/Game;Z)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2611(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(-1));f.Pc=1;continue;}
case 1:{f.Locals[5]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("")));f.Pc=6;continue;}
case 6:{f.Locals[6]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String(":")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?55:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String(":")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",26);}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",31);}
case 31:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Locals[6]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String(":")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",45);}
case 45:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",48);}
case 48:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",51);}
case 51:{f.Locals[1]=f.Pop();f.Pc=52;continue;}
case 52:{f.Pc=107;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("->")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int==0?107:65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("->")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",73);}
case 73:{f.Push(JValue.I(2));f.Pc=74;continue;}
case 74:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",78);}
case 78:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",81);}
case 81:{f.Locals[7]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[7]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/GameState","parseTargetInScript","(Ljava/lang/String;)I","invokevirtual",89);}
case 89:{f.Locals[5]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{f.Push(JValue.I(0));f.Pc=93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("->")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",100);}
case 100:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",103);}
case 103:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",106);}
case 106:{f.Locals[1]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("^")));f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String(":")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",117);}
case 117:{f.Locals[1]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(JValue.R(null));f.Pc=119;continue;}
case 119:{f.Locals[7]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",125);}
case 125:{f.Pc=f.Pop().Int==0?167:128;continue;}
case 128:{f.Push(f.Locals[0]);f.Pc=129;continue;}
case 129:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","idToCard","Ljava/util/Map;"));f.Pc=132;continue;}
case 132:{f.Push(f.Locals[1]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",136);}
case 136:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",139);}
case 139:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",144);}
case 144:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=147;continue;}
case 147:{f.Locals[7]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[7]);f.Pc=151;continue;}
case 151:{f.Pc=f.Pop().Reference!=null?205:154;continue;}
case 154:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=157;continue;}
case 157:{f.Push(f.Locals[1]);f.Pc=158;continue;}
case 158:{return rt.DynamicCall(f,"forge/game/GameState:2611:158:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",163);}
case 163:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",166);}
case 166:{return JStep.ReturnVoid;}
case 167:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",170);}
case 170:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",173);}
case 173:{f.Push(f.Locals[1]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",177);}
case 177:{f.Locals[8]=f.Pop();f.Pc=179;continue;}
case 179:{f.Push(f.Locals[8]);f.Pc=181;continue;}
case 181:{f.Pc=f.Pop().Reference!=null?197:184;continue;}
case 184:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=187;continue;}
case 187:{f.Push(f.Locals[1]);f.Pc=188;continue;}
case 188:{return rt.DynamicCall(f,"forge/game/GameState:2611:188:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",193);}
case 193:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",196);}
case 196:{return JStep.ReturnVoid;}
case 197:{f.Push(f.Locals[8]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[2]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",203);}
case 203:{f.Locals[7]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[6]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",210);}
case 210:{f.Pc=f.Pop().Int!=0?225:213;continue;}
case 213:{f.Push(f.Locals[0]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[3]);f.Pc=215;continue;}
case 215:{f.Push(f.Locals[7]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[6]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[4]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"forge/game/GameState","executeScript","(Lforge/game/Game;Lforge/game/card/Card;Ljava/lang/String;Z)V","invokevirtual",224);}
case 224:{return JStep.ReturnVoid;}
case 225:{f.Push(f.Locals[7]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",230);}
case 230:{f.Push(f.Locals[1]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",234);}
case 234:{f.Pc=f.Pop().Int!=0?273:237;continue;}
case 237:{f.Push(f.Locals[7]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/game/card/Card","hasAlternateState","()Z","invokevirtual",242);}
case 242:{f.Pc=f.Pop().Int==0?273:245;continue;}
case 245:{f.Push(f.Locals[1]);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[7]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/card/Card","getAlternateState","()Lforge/game/card/CardState;","invokevirtual",251);}
case 251:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",254);}
case 254:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",257);}
case 257:{f.Pc=f.Pop().Int==0?273:260;continue;}
case 260:{f.Push(f.Locals[7]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/card/Card","getAlternateState","()Lforge/game/card/CardState;","invokevirtual",265);}
case 265:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",268);}
case 268:{f.Locals[8]=f.Pop();f.Pc=270;continue;}
case 270:{f.Pc=280;continue;}
case 273:{f.Push(f.Locals[7]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/card/Card","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",278);}
case 278:{f.Locals[8]=f.Pop();f.Pc=280;continue;}
case 280:{f.Push(f.Locals[8]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[2]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",286);}
case 286:{f.Push(f.Locals[0]);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[3]);f.Pc=288;continue;}
case 288:{f.Push(f.Locals[8]);f.Pc=290;continue;}
case 290:{f.Push(f.Locals[5]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/GameState","handleScriptedTargetingForSA","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;I)V","invokevirtual",295);}
case 295:{f.Push(f.Locals[4]);f.Pc=297;continue;}
case 297:{f.Pc=f.Pop().Int==0?312:300;continue;}
case 300:{f.Push(f.Locals[3]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",304);}
case 304:{f.Push(f.Locals[8]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/zone/MagicStack","addAndUnfreeze","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",309);}
case 309:{f.Pc=317;continue;}
case 312:{f.Push(f.Locals[8]);f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/spellability/SpellAbility","resolve","()V","invokevirtual",317);}
case 317:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2612(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","markedDamage","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?67:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",61);}
case 61:{return rt.Call(f,"forge/game/card/Card","setDamage","(I)V","invokevirtual",64);}
case 64:{f.Pc=15;continue;}
case 67:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2613(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToChosenClrs","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?64:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","setChosenColors","(Ljava/util/List;)V","invokevirtual",61);}
case 61:{f.Pc=15;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToChosenType","Ljava/util/Map;"));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",73);}
case 73:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",78);}
case 78:{f.Locals[1]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",85);}
case 85:{f.Pc=f.Pop().Int==0?124:88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",94);}
case 94:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=97;continue;}
case 97:{f.Locals[2]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Locals[3]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",115);}
case 115:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/card/Card","setChosenType","(Ljava/lang/String;)V","invokevirtual",121);}
case 121:{f.Pc=79;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToChosenType2","Ljava/util/Map;"));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",133);}
case 133:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",138);}
case 138:{f.Locals[1]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[1]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",145);}
case 145:{f.Pc=f.Pop().Int==0?184:148;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",154);}
case 154:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=157;continue;}
case 157:{f.Locals[2]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[2]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",164);}
case 164:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=167;continue;}
case 167:{f.Locals[3]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[3]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[2]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",175);}
case 175:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/card/Card","setChosenType2","(Ljava/lang/String;)V","invokevirtual",181);}
case 181:{f.Pc=139;continue;}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToNamedCard","Ljava/util/Map;"));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",193);}
case 193:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",198);}
case 198:{f.Locals[1]=f.Pop();f.Pc=199;continue;}
case 199:{f.Push(f.Locals[1]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",205);}
case 205:{f.Pc=f.Pop().Int==0?278:208;continue;}
case 208:{f.Push(f.Locals[1]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",214);}
case 214:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=217;continue;}
case 217:{f.Locals[2]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[2]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",224);}
case 224:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=227;continue;}
case 227:{f.Locals[3]=f.Pop();f.Pc=228;continue;}
case 228:{f.Push(f.Locals[2]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",234);}
case 234:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",242);}
case 242:{f.Locals[4]=f.Pop();f.Pc=244;continue;}
case 244:{f.Push(f.Locals[4]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",251);}
case 251:{f.Pc=f.Pop().Int==0?275:254;continue;}
case 254:{f.Push(f.Locals[4]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",261);}
case 261:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=264;continue;}
case 264:{f.Locals[5]=f.Pop();f.Pc=266;continue;}
case 266:{f.Push(f.Locals[3]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[5]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/card/Card","addNamedCard","(Ljava/lang/String;)V","invokevirtual",272);}
case 272:{f.Pc=244;continue;}
case 275:{f.Pc=199;continue;}
case 278:{f.Push(f.Locals[0]);f.Pc=279;continue;}
case 279:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToChosenCards","Ljava/util/Map;"));f.Pc=282;continue;}
case 282:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",287);}
case 287:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",292);}
case 292:{f.Locals[1]=f.Pop();f.Pc=293;continue;}
case 293:{f.Push(f.Locals[1]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",299);}
case 299:{f.Pc=f.Pop().Int==0?338:302;continue;}
case 302:{f.Push(f.Locals[1]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",308);}
case 308:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=311;continue;}
case 311:{f.Locals[2]=f.Pop();f.Pc=312;continue;}
case 312:{f.Push(f.Locals[2]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",318);}
case 318:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=321;continue;}
case 321:{f.Locals[3]=f.Pop();f.Pc=322;continue;}
case 322:{f.Push(f.Locals[3]);f.Pc=323;continue;}
case 323:{f.Push(f.Locals[2]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",329);}
case 329:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/game/card/Card","setChosenCards","(Ljava/lang/Iterable;)V","invokevirtual",335);}
case 335:{f.Pc=293;continue;}
case 338:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2614(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToAttachId","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?61:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","idToCard","Ljava/util/Map;"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",44);}
case 44:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[3]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/card/Card","unAttachAllCards","(Lforge/game/card/Card;)V","invokevirtual",58);}
case 58:{f.Pc=15;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToAttachId","Ljava/util/Map;"));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",70);}
case 70:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",75);}
case 75:{f.Locals[1]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",82);}
case 82:{f.Pc=f.Pop().Int==0?144:85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",91);}
case 91:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=94;continue;}
case 94:{f.Locals[2]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","idToCard","Ljava/util/Map;"));f.Pc=99;continue;}
case 99:{f.Push(f.Locals[2]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",105);}
case 105:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",110);}
case 110:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=113;continue;}
case 113:{f.Locals[3]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",120);}
case 120:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=123;continue;}
case 123:{f.Locals[4]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[4]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/card/Card","isAttachment","()Z","invokevirtual",130);}
case 130:{f.Pc=f.Pop().Int==0?141:133;continue;}
case 133:{f.Push(f.Locals[4]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[3]);f.Pc=136;continue;}
case 136:{f.Push(JValue.R(null));f.Pc=137;continue;}
case 137:{f.Push(JValue.I(1));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/card/Card","attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;Z)V","invokevirtual",141);}
case 141:{f.Pc=76;continue;}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToEnchantPlayerId","Ljava/util/Map;"));f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",153);}
case 153:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",158);}
case 158:{f.Locals[1]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",165);}
case 165:{f.Pc=f.Pop().Int==0?203:168;continue;}
case 168:{f.Push(f.Locals[1]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",174);}
case 174:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=177;continue;}
case 177:{f.Locals[2]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[2]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",184);}
case 184:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[2]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",193);}
case 193:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=196;continue;}
case 196:{f.Push(JValue.R(null));f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/card/Card","attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)V","invokevirtual",200);}
case 200:{f.Pc=159;continue;}
case 203:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2615(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToMergedCards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?149:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",58);}
case 58:{f.Locals[4]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",67);}
case 67:{f.Pc=f.Pop().Int==0?146:70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",77);}
case 77:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=80;continue;}
case 80:{f.Locals[5]=f.Pop();f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",85);}
case 85:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",88);}
case 88:{f.Push(f.Locals[5]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("^")));f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String(",")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",99);}
case 99:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",102);}
case 102:{f.Locals[7]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{f.Pc=f.Pop().Reference!=null?125:109;continue;}
case 109:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=112;continue;}
case 112:{f.Push(f.Locals[5]);f.Pc=114;continue;}
case 114:{return rt.DynamicCall(f,"forge/game/GameState:2615:114:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",119);}
case 119:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",122);}
case 122:{f.Pc=60;continue;}
case 125:{f.Push(f.Locals[7]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[3]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",131);}
case 131:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",134);}
case 134:{f.Locals[6]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[3]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[6]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/GameState","emulateMergeViaMutate","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",143);}
case 143:{f.Pc=60;continue;}
case 146:{f.Pc=15;continue;}
case 149:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2616(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?8:4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference!=null?18:8;continue;}
case 8:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("ERROR: Tried to call emulateMergeViaMutate with a null card!")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",17);}
case 17:{return JStep.ReturnVoid;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/Card","setMergedToCard","(Lforge/game/card/Card;)V","invokevirtual",28);}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int!=0?40:35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","addMergedCard","(Lforge/game/card/Card;)V","invokevirtual",40);}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/Card","addMergedCard","(Lforge/game/card/Card;)V","invokevirtual",45);}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/Card","removeMutatedStates","()V","invokevirtual",49);}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",53);}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","setMutatedTimestamp","(J)V","invokevirtual",61);}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",65);}
case 65:{if(!rt.StaticReady(f,"forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"));f.Pc=68;continue;}
case 68:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?86:71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(null));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/card/CardFactory","getMutatedCloneStates","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCloneStates;","invokestatic",76);}
case 76:{f.Locals[6]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[4]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/card/Card","addCloneState","(Lforge/game/card/CardCloneStates;J)V","invokevirtual",86);}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/card/Card","isTapped","()Z","invokevirtual",91);}
case 91:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",94);}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/card/Card","isFlipped","()Z","invokevirtual",99);}
case 99:{return rt.Call(f,"forge/game/card/Card","setFlipped","(Z)V","invokevirtual",102);}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/card/Card","getTimesMutated","()I","invokevirtual",107);}
case 107:{f.Push(JValue.I(1));f.Pc=108;continue;}
case 108:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/card/Card","setTimesMutated","(I)V","invokevirtual",112);}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/card/Card","updateTokenView","()V","invokevirtual",116);}
case 116:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2617(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","()Lcom/google/common/collect/HashMultiset;","invokestatic",4);}
case 4:{return rt.Call(f,"forge/game/GameEntity","setCounters","(Lcom/google/common/collect/Multiset;)V","invokevirtual",7);}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String(",")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=21;continue;}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Locals[6]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[6]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[5]);f.Pc=30;continue;}
case 30:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?78:33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=38;continue;}
case 38:{f.Locals[7]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[7]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("=")));f.Pc=44;continue;}
case 44:{f.Push(JValue.I(2));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Locals[8]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[8]);f.Pc=53;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",58);}
case 58:{f.Push(f.Locals[8]);f.Pc=60;continue;}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",65);}
case 65:{f.Push(JValue.R(null));f.Pc=66;continue;}
case 66:{f.Push(JValue.I(0));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(null));f.Pc=68;continue;}
case 68:{f.Push(JValue.R(null));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/GameEntity","addCounterInternal","(Lforge/game/card/CounterType;ILforge/game/player/Player;ZLforge/game/GameEntityCounterTable;Ljava/util/Map;)V","invokevirtual",72);}
case 72:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=75;continue;}
case 75:{f.Pc=26;continue;}
case 78:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2618(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/GameState","ZONES","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameState","ZONES","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",8);}
case 8:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?47:23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[4]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",40);}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/zone/PlayerZone","removeAllCards","(Z)V","invokevirtual",44);}
case 44:{f.Pc=14;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/player/Player","getCommanders","()Ljava/util/List;","invokevirtual",51);}
case 51:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",56);}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/player/Player","clearTheRing","()V","invokevirtual",60);}
case 60:{if(!rt.EnsureInitialized(f,"java/util/EnumMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/EnumMap")));f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.ClassObject("forge/game/zone/ZoneType")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/EnumMap","<init>","(Ljava/lang/Class;)V","invokespecial",70);}
case 70:{f.Locals[3]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","cardTexts","Ljava/util/Map;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",80);}
case 80:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",85);}
case 85:{f.Locals[4]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",94);}
case 94:{f.Pc=f.Pop().Int==0?169:97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Locals[5]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[5]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",116);}
case 116:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=119;continue;}
case 119:{f.Locals[6]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[3]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[5]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",129);}
case 129:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[6]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",138);}
case 138:{f.Pc=f.Pop().Int==0?148:141;continue;}
case 141:{f.Push(JValue.I(0));f.Pc=142;continue;}
case 142:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=145;continue;}
case 145:{f.Pc=156;continue;}
case 148:{f.Push(f.Locals[6]);f.Pc=150;continue;}
case 150:{f.Push(JValue.R(rt.String(";")));f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",156);}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/GameState","processCardsForZone","([Ljava/lang/String;Lforge/game/player/Player;)Lforge/game/card/CardCollectionView;","invokevirtual",160);}
case 160:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",165);}
case 165:{f.StackOp("pop");f.Pc=166;continue;}
case 166:{f.Pc=87;continue;}
case 169:{f.Push(f.Locals[2]);f.Pc=170;continue;}
case 170:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","life","I"));f.Pc=173;continue;}
case 173:{f.Pc=f.Pop().Int<0?186:176;continue;}
case 176:{f.Push(f.Locals[1]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[2]);f.Pc=178;continue;}
case 178:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","life","I"));f.Pc=181;continue;}
case 181:{f.Push(JValue.R(null));f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/player/Player","setLife","(ILforge/game/spellability/SpellAbility;)Z","invokevirtual",185);}
case 185:{f.StackOp("pop");f.Pc=186;continue;}
case 186:{f.Push(f.Locals[1]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[2]);f.Pc=188;continue;}
case 188:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","landsPlayed","I"));f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/player/Player","setLandsPlayedThisTurn","(I)V","invokevirtual",194);}
case 194:{f.Push(f.Locals[1]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","numRingTemptedYou","I"));f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/player/Player","setNumRingTemptedYou","(I)V","invokevirtual",202);}
case 202:{f.Push(f.Locals[1]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[2]);f.Pc=204;continue;}
case 204:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","speed","I"));f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/player/Player","setSpeed","(I)V","invokevirtual",210);}
case 210:{f.Push(f.Locals[1]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/player/Player","clearPaidForSA","()V","invokevirtual",214);}
case 214:{f.Push(f.Locals[3]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",220);}
case 220:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",225);}
case 225:{f.Locals[4]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[4]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",234);}
case 234:{f.Pc=f.Pop().Int==0?566:237;continue;}
case 237:{f.Push(f.Locals[4]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",244);}
case 244:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=247;continue;}
case 247:{f.Locals[5]=f.Pop();f.Pc=249;continue;}
case 249:{f.Push(f.Locals[1]);f.Pc=250;continue;}
case 250:{f.Push(f.Locals[5]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",257);}
case 257:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",263);}
case 263:{f.Locals[6]=f.Pop();f.Pc=265;continue;}
case 265:{f.Push(f.Locals[5]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",272);}
case 272:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=275;continue;}
case 275:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?548:278;continue;}
case 278:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=281;continue;}
case 281:{f.StackOp("dup");f.Pc=282;continue;}
case 282:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",285);}
case 285:{f.Locals[7]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[5]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",294);}
case 294:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",302);}
case 302:{f.Locals[8]=f.Pop();f.Pc=304;continue;}
case 304:{f.Push(f.Locals[8]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",311);}
case 311:{f.Pc=f.Pop().Int==0?347:314;continue;}
case 314:{f.Push(f.Locals[8]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",321);}
case 321:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=324;continue;}
case 324:{f.Locals[9]=f.Pop();f.Pc=326;continue;}
case 326:{f.Push(f.Locals[9]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",331);}
case 331:{f.Pc=f.Pop().Int==0?344:334;continue;}
case 334:{f.Push(f.Locals[7]);f.Pc=336;continue;}
case 336:{f.Push(f.Locals[9]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",343);}
case 343:{f.StackOp("pop");f.Pc=344;continue;}
case 344:{f.Pc=304;continue;}
case 347:{f.Push(f.Locals[6]);f.Pc=349;continue;}
case 349:{f.Push(f.Locals[7]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/zone/PlayerZone","setCards","(Ljava/lang/Iterable;)V","invokevirtual",354);}
case 354:{f.Push(f.Locals[5]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",361);}
case 361:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",369);}
case 369:{f.Locals[8]=f.Pop();f.Pc=371;continue;}
case 371:{f.Push(f.Locals[8]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",378);}
case 378:{f.Pc=f.Pop().Int==0?545:381;continue;}
case 381:{f.Push(f.Locals[8]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",388);}
case 388:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=391;continue;}
case 391:{f.Locals[9]=f.Pop();f.Pc=393;continue;}
case 393:{f.Push(f.Locals[9]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",398);}
case 398:{f.Pc=f.Pop().Int==0?404:401;continue;}
case 401:{f.Pc=371;continue;}
case 404:{f.Push(f.Locals[9]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/card/Card","isTapped","()Z","invokevirtual",409);}
case 409:{f.Locals[10]=f.Pop();f.Pc=411;continue;}
case 411:{f.Push(f.Locals[9]);f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/game/card/Card","hasSickness","()Z","invokevirtual",416);}
case 416:{f.Locals[11]=f.Pop();f.Pc=418;continue;}
case 418:{f.Push(f.Locals[9]);f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/game/card/Card","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",423);}
case 423:{f.Locals[12]=f.Pop();f.Pc=425;continue;}
case 425:{f.Push(f.Locals[9]);f.Pc=427;continue;}
case 427:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","()Lcom/google/common/collect/HashMultiset;","invokestatic",430);}
case 430:{return rt.Call(f,"forge/game/card/Card","setCounters","(Lcom/google/common/collect/Multiset;)V","invokevirtual",433);}
case 433:{f.Push(f.Locals[9]);f.Pc=435;continue;}
case 435:{return rt.Call(f,"forge/game/card/Card","isAura","()Z","invokevirtual",438);}
case 438:{f.Pc=f.Pop().Int==0?459:441;continue;}
case 441:{f.Push(f.Locals[9]);f.Pc=443;continue;}
case 443:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCopyService"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCopyService")));f.Pc=446;continue;}
case 446:{f.StackOp("dup");f.Pc=447;continue;}
case 447:{f.Push(f.Locals[9]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/game/card/CardCopyService","<init>","(Lforge/game/card/Card;)V","invokespecial",452);}
case 452:{f.Push(JValue.I(1));f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/game/card/CardCopyService","copyCard","(Z)Lforge/game/card/Card;","invokevirtual",456);}
case 456:{return rt.Call(f,"forge/game/card/Card","setEntityAttachedTo","(Lforge/game/GameEntity;)V","invokevirtual",459);}
case 459:{f.Push(f.Locals[0]);f.Pc=460;continue;}
case 460:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardsWithoutETBTrigs","Ljava/util/Set;"));f.Pc=463;continue;}
case 463:{f.Push(f.Locals[9]);f.Pc=465;continue;}
case 465:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",470);}
case 470:{f.Pc=f.Pop().Int==0?494:473;continue;}
case 473:{f.Push(f.Locals[1]);f.Pc=474;continue;}
case 474:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",477);}
case 477:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",480);}
case 480:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=483;continue;}
case 483:{f.Push(f.Locals[9]);f.Pc=485;continue;}
case 485:{f.Push(JValue.R(null));f.Pc=486;continue;}
case 486:{f.Push(JValue.R(null));f.Pc=487;continue;}
case 487:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",490);}
case 490:{f.StackOp("pop");f.Pc=491;continue;}
case 491:{f.Pc=521;continue;}
case 494:{f.Push(f.Locals[1]);f.Pc=495;continue;}
case 495:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=498;continue;}
case 498:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",501);}
case 501:{f.Push(f.Locals[9]);f.Pc=503;continue;}
case 503:{return rt.Call(f,"forge/game/zone/PlayerZone","add","(Lforge/game/card/Card;)V","invokevirtual",506);}
case 506:{f.Push(f.Locals[1]);f.Pc=507;continue;}
case 507:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",510);}
case 510:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",513);}
case 513:{f.Push(f.Locals[9]);f.Pc=515;continue;}
case 515:{f.Push(JValue.R(null));f.Pc=516;continue;}
case 516:{f.Push(JValue.R(null));f.Pc=517;continue;}
case 517:{return rt.Call(f,"forge/game/GameAction","moveToPlay","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",520);}
case 520:{f.StackOp("pop");f.Pc=521;continue;}
case 521:{f.Push(f.Locals[9]);f.Pc=523;continue;}
case 523:{f.Push(f.Locals[10]);f.Pc=525;continue;}
case 525:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",528);}
case 528:{f.Push(f.Locals[9]);f.Pc=530;continue;}
case 530:{f.Push(f.Locals[11]);f.Pc=532;continue;}
case 532:{return rt.Call(f,"forge/game/card/Card","setSickness","(Z)V","invokevirtual",535);}
case 535:{f.Push(f.Locals[9]);f.Pc=537;continue;}
case 537:{f.Push(f.Locals[12]);f.Pc=539;continue;}
case 539:{return rt.Call(f,"forge/game/card/Card","setCounters","(Lcom/google/common/collect/Multiset;)V","invokevirtual",542);}
case 542:{f.Pc=371;continue;}
case 545:{f.Pc=563;continue;}
case 548:{f.Push(f.Locals[6]);f.Pc=550;continue;}
case 550:{f.Push(f.Locals[5]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",557);}
case 557:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=560;continue;}
case 560:{return rt.Call(f,"forge/game/zone/PlayerZone","setCards","(Ljava/lang/Iterable;)V","invokevirtual",563);}
case 563:{f.Pc=227;continue;}
case 566:{f.Push(f.Locals[1]);f.Pc=567;continue;}
case 567:{return rt.Call(f,"forge/game/player/Player","getCommanders","()Ljava/util/List;","invokevirtual",570);}
case 570:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",575);}
case 575:{f.Pc=f.Pop().Int!=0?582:578;continue;}
case 578:{f.Push(f.Locals[1]);f.Pc=579;continue;}
case 579:{return rt.Call(f,"forge/game/player/Player","createCommanderEffect","()V","invokevirtual",582);}
case 582:{f.Push(f.Locals[0]);f.Pc=583;continue;}
case 583:{f.Push(f.Locals[1]);f.Pc=584;continue;}
case 584:{f.Push(f.Locals[2]);f.Pc=585;continue;}
case 585:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","manaPool","Ljava/lang/String;"));f.Pc=588;continue;}
case 588:{f.Push(JValue.I(1));f.Pc=589;continue;}
case 589:{f.Push(JValue.I(0));f.Pc=590;continue;}
case 590:{return rt.Call(f,"forge/game/GameState","updateManaPool","(Lforge/game/player/Player;Ljava/lang/String;ZZ)V","invokevirtual",593);}
case 593:{f.Push(f.Locals[0]);f.Pc=594;continue;}
case 594:{f.Push(f.Locals[1]);f.Pc=595;continue;}
case 595:{f.Push(f.Locals[2]);f.Pc=596;continue;}
case 596:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","persistentMana","Ljava/lang/String;"));f.Pc=599;continue;}
case 599:{f.Push(JValue.I(0));f.Pc=600;continue;}
case 600:{f.Push(JValue.I(1));f.Pc=601;continue;}
case 601:{return rt.Call(f,"forge/game/GameState","updateManaPool","(Lforge/game/player/Player;Ljava/lang/String;ZZ)V","invokevirtual",604);}
case 604:{f.Push(f.Locals[2]);f.Pc=605;continue;}
case 605:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","counters","Ljava/lang/String;"));f.Pc=608;continue;}
case 608:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",611);}
case 611:{f.Pc=f.Pop().Int==0?621:614;continue;}
case 614:{f.Push(f.Locals[1]);f.Pc=615;continue;}
case 615:{return rt.Call(f,"forge/game/player/Player","clearCounters","()V","invokevirtual",618);}
case 618:{f.Pc=630;continue;}
case 621:{f.Push(f.Locals[0]);f.Pc=622;continue;}
case 622:{f.Push(f.Locals[1]);f.Pc=623;continue;}
case 623:{f.Push(f.Locals[2]);f.Pc=624;continue;}
case 624:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","counters","Ljava/lang/String;"));f.Pc=627;continue;}
case 627:{return rt.Call(f,"forge/game/GameState","applyCountersToGameEntity","(Lforge/game/GameEntity;Ljava/lang/String;)V","invokevirtual",630);}
case 630:{f.Push(f.Locals[2]);f.Pc=631;continue;}
case 631:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","numRingTemptedYou","I"));f.Pc=634;continue;}
case 634:{f.Pc=f.Pop().Int<=0?670:637;continue;}
case 637:{f.Push(JValue.I(1));f.Pc=638;continue;}
case 638:{f.Locals[4]=f.Pop();f.Pc=640;continue;}
case 640:{f.Push(f.Locals[4]);f.Pc=642;continue;}
case 642:{f.Push(f.Locals[2]);f.Pc=643;continue;}
case 643:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","numRingTemptedYou","I"));f.Pc=646;continue;}
case 646:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?670:649;continue;}
case 649:{f.Push(f.Locals[4]);f.Pc=651;continue;}
case 651:{f.Push(JValue.I(4));f.Pc=652;continue;}
case 652:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?658:655;continue;}
case 655:{f.Pc=670;continue;}
case 658:{f.Push(f.Locals[1]);f.Pc=659;continue;}
case 659:{f.Push(f.Locals[4]);f.Pc=661;continue;}
case 661:{return rt.Call(f,"forge/game/player/Player","setRingLevel","(I)V","invokevirtual",664);}
case 664:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=667;continue;}
case 667:{f.Pc=640;continue;}
case 670:{f.Push(f.Locals[2]);f.Pc=671;continue;}
case 671:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState$PlayerState","speed","I"));f.Pc=674;continue;}
case 674:{f.Pc=f.Pop().Int<=0?681:677;continue;}
case 677:{f.Push(f.Locals[1]);f.Pc=678;continue;}
case 678:{return rt.Call(f,"forge/game/player/Player","createSpeedEffect","()V","invokevirtual",681);}
case 681:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2619(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=14;continue;}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{f.Locals[6]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[6]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[5]);f.Pc=23;continue;}
case 23:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?2233:26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[6]);f.Pc=30;continue;}
case 30:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=31;continue;}
case 31:{f.Locals[7]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[7]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",38);}
case 38:{return rt.Call(f,"forge/game/GameState","protectTokenImageKey","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",41);}
case 41:{f.Push(JValue.R(rt.String("\\|")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",47);}
case 47:{f.Locals[8]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(JValue.R(null));f.Pc=50;continue;}
case 50:{f.Locals[9]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[8]);f.Pc=54;continue;}
case 54:{f.Locals[10]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[10]);f.Pc=58;continue;}
case 58:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=59;continue;}
case 59:{f.Locals[11]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{f.Locals[12]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[12]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[11]);f.Pc=68;continue;}
case 68:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?114:71;continue;}
case 71:{f.Push(f.Locals[10]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[12]);f.Pc=75;continue;}
case 75:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=76;continue;}
case 76:{f.Locals[13]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[13]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("Set:")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int==0?108:89;continue;}
case 89:{f.Push(f.Locals[13]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[13]);f.Pc=93;continue;}
case 93:{f.Push(JValue.I(58));f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",98);}
case 98:{f.Push(JValue.I(1));f.Pc=99;continue;}
case 99:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",103);}
case 103:{f.Locals[9]=f.Pop();f.Pc=105;continue;}
case 105:{f.Pc=114;continue;}
case 108:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=111;continue;}
case 111:{f.Pc=64;continue;}
case 114:{f.Push(JValue.I(-1));f.Pc=115;continue;}
case 115:{f.Locals[10]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[8]);f.Pc=119;continue;}
case 119:{f.Locals[11]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[11]);f.Pc=123;continue;}
case 123:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=124;continue;}
case 124:{f.Locals[12]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(JValue.I(0));f.Pc=127;continue;}
case 127:{f.Locals[13]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[13]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[12]);f.Pc=133;continue;}
case 133:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?187:136;continue;}
case 136:{f.Push(f.Locals[11]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[13]);f.Pc=140;continue;}
case 140:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=141;continue;}
case 141:{f.Locals[14]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(f.Locals[14]);f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.String("Art:")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",151);}
case 151:{f.Pc=f.Pop().Int==0?181:154;continue;}
case 154:{f.Push(f.Locals[14]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[14]);f.Pc=158;continue;}
case 158:{f.Push(JValue.I(58));f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",163);}
case 163:{f.Push(JValue.I(1));f.Pc=164;continue;}
case 164:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",168);}
case 168:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",171);}
case 171:{f.Locals[10]=f.Pop();f.Pc=173;continue;}
case 173:{f.Pc=187;continue;}
case 176:{f.Locals[15]=f.Pop();f.Pc=178;continue;}
case 178:{f.Pc=187;continue;}
case 181:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(1)));f.Pc=184;continue;}
case 184:{f.Pc=129;continue;}
case 187:{f.Push(JValue.I(0));f.Pc=188;continue;}
case 188:{f.Locals[12]=f.Pop();f.Pc=190;continue;}
case 190:{f.Push(f.Locals[8]);f.Pc=192;continue;}
case 192:{f.Push(JValue.I(0));f.Pc=193;continue;}
case 193:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("t:")));f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",200);}
case 200:{f.Pc=f.Pop().Int==0?240:203;continue;}
case 203:{f.Push(f.Locals[8]);f.Pc=205;continue;}
case 205:{f.Push(JValue.I(0));f.Pc=206;continue;}
case 206:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=207;continue;}
case 207:{f.Push(JValue.I(2));f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",211);}
case 211:{f.Push(JValue.R(rt.String("%7C")));f.Pc=214;continue;}
case 214:{f.Push(JValue.R(rt.String("|")));f.Pc=217;continue;}
case 217:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",220);}
case 220:{f.Locals[13]=f.Pop();f.Pc=222;continue;}
case 222:{if(!rt.EnsureInitialized(f,"forge/game/card/token/TokenInfo"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/token/TokenInfo")));f.Pc=225;continue;}
case 225:{f.StackOp("dup");f.Pc=226;continue;}
case 226:{f.Push(f.Locals[13]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/card/token/TokenInfo","<init>","(Ljava/lang/String;)V","invokespecial",231);}
case 231:{f.Push(f.Locals[2]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/card/token/TokenInfo","makeOneToken","(Lforge/game/player/Player;)Lforge/game/card/Card;","invokevirtual",235);}
case 235:{f.Locals[11]=f.Pop();f.Pc=237;continue;}
case 237:{f.Pc=398;continue;}
case 240:{f.Push(f.Locals[8]);f.Pc=242;continue;}
case 242:{f.Push(JValue.I(0));f.Pc=243;continue;}
case 243:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=244;continue;}
case 244:{f.Push(JValue.R(rt.String("T:")));f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",250);}
case 250:{f.Pc=f.Pop().Int==0?327:253;continue;}
case 253:{f.Push(f.Locals[8]);f.Pc=255;continue;}
case 255:{f.Push(JValue.I(0));f.Pc=256;continue;}
case 256:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=257;continue;}
case 257:{f.Push(JValue.I(2));f.Pc=258;continue;}
case 258:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",261);}
case 261:{f.Locals[13]=f.Pop();f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",266);}
case 266:{return rt.Call(f,"forge/StaticData","getAllTokens","()Lforge/token/TokenDb;","invokevirtual",269);}
case 269:{f.Push(f.Locals[13]);f.Pc=271;continue;}
case 271:{f.Push(f.Locals[9]);f.Pc=273;continue;}
case 273:{f.Pc=f.Pop().Reference==null?281:276;continue;}
case 276:{f.Push(f.Locals[9]);f.Pc=278;continue;}
case 278:{f.Pc=284;continue;}
case 281:{f.Push(JValue.R(rt.String("???")));f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/token/TokenDb","getToken","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperToken;","invokevirtual",287);}
case 287:{f.Locals[14]=f.Pop();f.Pc=289;continue;}
case 289:{f.Push(f.Locals[14]);f.Pc=291;continue;}
case 291:{f.Pc=f.Pop().Reference!=null?312:294;continue;}
case 294:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=297;continue;}
case 297:{f.Push(f.Locals[8]);f.Pc=299;continue;}
case 299:{f.Push(JValue.I(0));f.Pc=300;continue;}
case 300:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=301;continue;}
case 301:{return rt.DynamicCall(f,"forge/game/GameState:2619:301:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",306);}
case 306:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",309);}
case 309:{f.Pc=2227;continue;}
case 312:{f.Push(f.Locals[14]);f.Pc=314;continue;}
case 314:{f.Push(f.Locals[2]);f.Pc=315;continue;}
case 315:{f.Push(f.Locals[2]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",319);}
case 319:{return rt.Call(f,"forge/game/card/CardFactory","getCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;Lforge/game/Game;)Lforge/game/card/Card;","invokestatic",322);}
case 322:{f.Locals[11]=f.Pop();f.Pc=324;continue;}
case 324:{f.Pc=398;continue;}
case 327:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",330);}
case 330:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",333);}
case 333:{f.Push(f.Locals[8]);f.Pc=335;continue;}
case 335:{f.Push(JValue.I(0));f.Pc=336;continue;}
case 336:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=337;continue;}
case 337:{f.Push(f.Locals[9]);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[10]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperCard;","invokevirtual",344);}
case 344:{f.Locals[13]=f.Pop();f.Pc=346;continue;}
case 346:{f.Push(f.Locals[13]);f.Pc=348;continue;}
case 348:{f.Pc=f.Pop().Reference!=null?382:351;continue;}
case 351:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=354;continue;}
case 354:{f.Push(f.Locals[8]);f.Pc=356;continue;}
case 356:{f.Push(JValue.I(0));f.Pc=357;continue;}
case 357:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=358;continue;}
case 358:{f.Push(f.Locals[9]);f.Pc=360;continue;}
case 360:{f.Pc=f.Pop().Reference!=null?369:363;continue;}
case 363:{f.Push(JValue.R(rt.String("any")));f.Pc=366;continue;}
case 366:{f.Pc=371;continue;}
case 369:{f.Push(f.Locals[9]);f.Pc=371;continue;}
case 371:{return rt.DynamicCall(f,"forge/game/GameState:2619:371:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",376);}
case 376:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",379);}
case 379:{f.Pc=2227;continue;}
case 382:{f.Push(f.Locals[13]);f.Pc=384;continue;}
case 384:{f.Push(f.Locals[2]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",388);}
case 388:{f.Locals[11]=f.Pop();f.Pc=390;continue;}
case 390:{f.Push(f.Locals[9]);f.Pc=392;continue;}
case 392:{f.Pc=f.Pop().Reference==null?398:395;continue;}
case 395:{f.Push(JValue.I(1));f.Pc=396;continue;}
case 396:{f.Locals[12]=f.Pop();f.Pc=398;continue;}
case 398:{f.Push(f.Locals[11]);f.Pc=400;continue;}
case 400:{f.Push(JValue.I(0));f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/card/Card","setSickness","(Z)V","invokevirtual",404);}
case 404:{f.Push(f.Locals[8]);f.Pc=406;continue;}
case 406:{f.Locals[13]=f.Pop();f.Pc=408;continue;}
case 408:{f.Push(f.Locals[13]);f.Pc=410;continue;}
case 410:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=411;continue;}
case 411:{f.Locals[14]=f.Pop();f.Pc=413;continue;}
case 413:{f.Push(JValue.I(0));f.Pc=414;continue;}
case 414:{f.Locals[15]=f.Pop();f.Pc=416;continue;}
case 416:{f.Push(f.Locals[15]);f.Pc=418;continue;}
case 418:{f.Push(f.Locals[14]);f.Pc=420;continue;}
case 420:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?2197:423;continue;}
case 423:{f.Push(f.Locals[13]);f.Pc=425;continue;}
case 425:{f.Push(f.Locals[15]);f.Pc=427;continue;}
case 427:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=428;continue;}
case 428:{f.Locals[16]=f.Pop();f.Pc=430;continue;}
case 430:{f.Push(f.Locals[16]);f.Pc=432;continue;}
case 432:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=435;continue;}
case 435:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",438);}
case 438:{f.Pc=f.Pop().Int==0?452:441;continue;}
case 441:{f.Push(f.Locals[11]);f.Pc=443;continue;}
case 443:{f.Push(JValue.R(null));f.Pc=444;continue;}
case 444:{f.Push(JValue.R(null));f.Pc=445;continue;}
case 445:{return rt.Call(f,"forge/game/card/Card","tap","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z","invokevirtual",448);}
case 448:{f.StackOp("pop");f.Pc=449;continue;}
case 449:{f.Pc=2191;continue;}
case 452:{f.Push(f.Locals[16]);f.Pc=454;continue;}
case 454:{f.Push(JValue.R(rt.String("Renowned")));f.Pc=457;continue;}
case 457:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",460);}
case 460:{f.Pc=f.Pop().Int==0?472:463;continue;}
case 463:{f.Push(f.Locals[11]);f.Pc=465;continue;}
case 465:{f.Push(JValue.I(1));f.Pc=466;continue;}
case 466:{return rt.Call(f,"forge/game/card/Card","setRenowned","(Z)V","invokevirtual",469);}
case 469:{f.Pc=2191;continue;}
case 472:{f.Push(f.Locals[16]);f.Pc=474;continue;}
case 474:{f.Push(JValue.R(rt.String("Solved")));f.Pc=477;continue;}
case 477:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",480);}
case 480:{f.Pc=f.Pop().Int==0?493:483;continue;}
case 483:{f.Push(f.Locals[11]);f.Pc=485;continue;}
case 485:{f.Push(JValue.I(1));f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/card/Card","setSolved","(Z)Z","invokevirtual",489);}
case 489:{f.StackOp("pop");f.Pc=490;continue;}
case 490:{f.Pc=2191;continue;}
case 493:{f.Push(f.Locals[16]);f.Pc=495;continue;}
case 495:{f.Push(JValue.R(rt.String("Saddled")));f.Pc=498;continue;}
case 498:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",501);}
case 501:{f.Pc=f.Pop().Int==0?514:504;continue;}
case 504:{f.Push(f.Locals[11]);f.Pc=506;continue;}
case 506:{f.Push(JValue.I(1));f.Pc=507;continue;}
case 507:{return rt.Call(f,"forge/game/card/Card","setSaddled","(Z)Z","invokevirtual",510);}
case 510:{f.StackOp("pop");f.Pc=511;continue;}
case 511:{f.Pc=2191;continue;}
case 514:{f.Push(f.Locals[16]);f.Pc=516;continue;}
case 516:{f.Push(JValue.R(rt.String("Suspected")));f.Pc=519;continue;}
case 519:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",522);}
case 522:{f.Pc=f.Pop().Int==0?535:525;continue;}
case 525:{f.Push(f.Locals[11]);f.Pc=527;continue;}
case 527:{f.Push(JValue.I(1));f.Pc=528;continue;}
case 528:{return rt.Call(f,"forge/game/card/Card","setSuspected","(Z)Z","invokevirtual",531);}
case 531:{f.StackOp("pop");f.Pc=532;continue;}
case 532:{f.Pc=2191;continue;}
case 535:{f.Push(f.Locals[16]);f.Pc=537;continue;}
case 537:{f.Push(JValue.R(rt.String("Monstrous")));f.Pc=540;continue;}
case 540:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",543);}
case 543:{f.Pc=f.Pop().Int==0?555:546;continue;}
case 546:{f.Push(f.Locals[11]);f.Pc=548;continue;}
case 548:{f.Push(JValue.I(1));f.Pc=549;continue;}
case 549:{return rt.Call(f,"forge/game/card/Card","setMonstrous","(Z)V","invokevirtual",552);}
case 552:{f.Pc=2191;continue;}
case 555:{f.Push(f.Locals[16]);f.Pc=557;continue;}
case 557:{f.Push(JValue.R(rt.String("PhasedOut")));f.Pc=560;continue;}
case 560:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",563);}
case 563:{f.Pc=f.Pop().Int==0?600:566;continue;}
case 566:{f.Push(f.Locals[16]);f.Pc=568;continue;}
case 568:{f.Push(f.Locals[16]);f.Pc=570;continue;}
case 570:{f.Push(JValue.I(58));f.Pc=572;continue;}
case 572:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",575);}
case 575:{f.Push(JValue.I(1));f.Pc=576;continue;}
case 576:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=577;continue;}
case 577:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",580);}
case 580:{f.Locals[17]=f.Pop();f.Pc=582;continue;}
case 582:{f.Push(f.Locals[11]);f.Pc=584;continue;}
case 584:{f.Push(f.Locals[0]);f.Pc=585;continue;}
case 585:{f.Push(f.Locals[2]);f.Pc=586;continue;}
case 586:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",589);}
case 589:{f.Push(f.Locals[17]);f.Pc=591;continue;}
case 591:{return rt.Call(f,"forge/game/GameState","parsePlayerString","(Lforge/game/Game;Ljava/lang/String;)Lforge/game/player/Player;","invokevirtual",594);}
case 594:{return rt.Call(f,"forge/game/card/Card","setPhasedOut","(Lforge/game/player/Player;)V","invokevirtual",597);}
case 597:{f.Pc=2191;continue;}
case 600:{f.Push(f.Locals[16]);f.Pc=602;continue;}
case 602:{f.Push(JValue.R(rt.String("Counters:")));f.Pc=605;continue;}
case 605:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",608);}
case 608:{f.Pc=f.Pop().Int==0?634:611;continue;}
case 611:{f.Push(f.Locals[0]);f.Pc=612;continue;}
case 612:{f.Push(f.Locals[11]);f.Pc=614;continue;}
case 614:{f.Push(f.Locals[16]);f.Pc=616;continue;}
case 616:{f.Push(f.Locals[16]);f.Pc=618;continue;}
case 618:{f.Push(JValue.I(58));f.Pc=620;continue;}
case 620:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",623);}
case 623:{f.Push(JValue.I(1));f.Pc=624;continue;}
case 624:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=625;continue;}
case 625:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",628);}
case 628:{return rt.Call(f,"forge/game/GameState","applyCountersToGameEntity","(Lforge/game/GameEntity;Ljava/lang/String;)V","invokevirtual",631);}
case 631:{f.Pc=2191;continue;}
case 634:{f.Push(f.Locals[16]);f.Pc=636;continue;}
case 636:{f.Push(JValue.R(rt.String("SummonSick")));f.Pc=639;continue;}
case 639:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",642);}
case 642:{f.Pc=f.Pop().Int==0?654:645;continue;}
case 645:{f.Push(f.Locals[11]);f.Pc=647;continue;}
case 647:{f.Push(JValue.I(1));f.Pc=648;continue;}
case 648:{return rt.Call(f,"forge/game/card/Card","setSickness","(Z)V","invokevirtual",651);}
case 651:{f.Pc=2191;continue;}
case 654:{f.Push(f.Locals[16]);f.Pc=656;continue;}
case 656:{f.Push(JValue.R(rt.String("FaceDown")));f.Pc=659;continue;}
case 659:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",662);}
case 662:{f.Pc=f.Pop().Int==0?731:665;continue;}
case 665:{f.Push(f.Locals[11]);f.Pc=667;continue;}
case 667:{f.Push(JValue.I(1));f.Pc=668;continue;}
case 668:{return rt.Call(f,"forge/game/card/Card","turnFaceDown","(Z)Z","invokevirtual",671);}
case 671:{f.StackOp("pop");f.Pc=672;continue;}
case 672:{f.Push(f.Locals[16]);f.Pc=674;continue;}
case 674:{f.Push(JValue.R(rt.String("Manifested")));f.Pc=677;continue;}
case 677:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",680);}
case 680:{f.Pc=f.Pop().Int==0?700:683;continue;}
case 683:{f.Push(f.Locals[11]);f.Pc=685;continue;}
case 685:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbility$EmptySa"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbility$EmptySa")));f.Pc=688;continue;}
case 688:{f.StackOp("dup");f.Pc=689;continue;}
case 689:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Manifest","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Manifest","Lforge/game/ability/ApiType;"));f.Pc=692;continue;}
case 692:{f.Push(f.Locals[11]);f.Pc=694;continue;}
case 694:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;)V","invokespecial",697);}
case 697:{return rt.Call(f,"forge/game/card/Card","setManifested","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",700);}
case 700:{f.Push(f.Locals[16]);f.Pc=702;continue;}
case 702:{f.Push(JValue.R(rt.String("Cloaked")));f.Pc=705;continue;}
case 705:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",708);}
case 708:{f.Pc=f.Pop().Int==0?2191:711;continue;}
case 711:{f.Push(f.Locals[11]);f.Pc=713;continue;}
case 713:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbility$EmptySa"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbility$EmptySa")));f.Pc=716;continue;}
case 716:{f.StackOp("dup");f.Pc=717;continue;}
case 717:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Cloak","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Cloak","Lforge/game/ability/ApiType;"));f.Pc=720;continue;}
case 720:{f.Push(f.Locals[11]);f.Pc=722;continue;}
case 722:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;)V","invokespecial",725);}
case 725:{return rt.Call(f,"forge/game/card/Card","setCloaked","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",728);}
case 728:{f.Pc=2191;continue;}
case 731:{f.Push(f.Locals[16]);f.Pc=733;continue;}
case 733:{f.Push(JValue.R(rt.String("Transformed")));f.Pc=736;continue;}
case 736:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",739);}
case 739:{f.Pc=f.Pop().Int!=0?753:742;continue;}
case 742:{f.Push(f.Locals[16]);f.Pc=744;continue;}
case 744:{f.Push(JValue.R(rt.String("Modal")));f.Pc=747;continue;}
case 747:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",750);}
case 750:{f.Pc=f.Pop().Int==0?772:753;continue;}
case 753:{f.Push(f.Locals[11]);f.Pc=755;continue;}
case 755:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=758;continue;}
case 758:{f.Push(JValue.I(1));f.Pc=759;continue;}
case 759:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",762);}
case 762:{f.StackOp("pop");f.Pc=763;continue;}
case 763:{f.Push(f.Locals[11]);f.Pc=765;continue;}
case 765:{f.Push(JValue.I(1));f.Pc=766;continue;}
case 766:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",769);}
case 769:{f.Pc=2191;continue;}
case 772:{f.Push(f.Locals[16]);f.Pc=774;continue;}
case 774:{f.Push(JValue.R(rt.String("Flipped")));f.Pc=777;continue;}
case 777:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",780);}
case 780:{f.Pc=f.Pop().Int==0?796:783;continue;}
case 783:{f.Push(f.Locals[11]);f.Pc=785;continue;}
case 785:{if(!rt.StaticReady(f,"forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"));f.Pc=788;continue;}
case 788:{f.Push(JValue.I(1));f.Pc=789;continue;}
case 789:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",792);}
case 792:{f.StackOp("pop");f.Pc=793;continue;}
case 793:{f.Pc=2191;continue;}
case 796:{f.Push(f.Locals[16]);f.Pc=798;continue;}
case 798:{f.Push(JValue.R(rt.String("Meld")));f.Pc=801;continue;}
case 801:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",804);}
case 804:{f.Pc=f.Pop().Int==0?914:807;continue;}
case 807:{f.Push(f.Locals[16]);f.Pc=809;continue;}
case 809:{f.Push(JValue.I(58));f.Pc=811;continue;}
case 811:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",814);}
case 814:{f.Pc=f.Pop().Int<=0?895:817;continue;}
case 817:{f.Push(f.Locals[16]);f.Pc=819;continue;}
case 819:{f.Push(f.Locals[16]);f.Pc=821;continue;}
case 821:{f.Push(JValue.I(58));f.Pc=823;continue;}
case 823:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",826);}
case 826:{f.Push(JValue.I(1));f.Pc=827;continue;}
case 827:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=828;continue;}
case 828:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",831);}
case 831:{f.Push(JValue.R(rt.String("^")));f.Pc=834;continue;}
case 834:{f.Push(JValue.R(rt.String(",")));f.Pc=837;continue;}
case 837:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",840);}
case 840:{f.Locals[17]=f.Pop();f.Pc=842;continue;}
case 842:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",845);}
case 845:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",848);}
case 848:{f.Push(f.Locals[17]);f.Pc=850;continue;}
case 850:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",853);}
case 853:{f.Locals[19]=f.Pop();f.Pc=855;continue;}
case 855:{f.Push(f.Locals[19]);f.Pc=857;continue;}
case 857:{f.Pc=f.Pop().Reference!=null?876:860;continue;}
case 860:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=863;continue;}
case 863:{f.Push(f.Locals[17]);f.Pc=865;continue;}
case 865:{return rt.DynamicCall(f,"forge/game/GameState:2619:865:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",870);}
case 870:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",873);}
case 873:{f.Pc=2191;continue;}
case 876:{f.Push(f.Locals[19]);f.Pc=878;continue;}
case 878:{f.Push(f.Locals[11]);f.Pc=880;continue;}
case 880:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",883);}
case 883:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",886);}
case 886:{f.Locals[18]=f.Pop();f.Pc=888;continue;}
case 888:{f.Push(f.Locals[11]);f.Pc=890;continue;}
case 890:{f.Push(f.Locals[18]);f.Pc=892;continue;}
case 892:{return rt.Call(f,"forge/game/card/Card","setMeldedWith","(Lforge/game/card/Card;)V","invokevirtual",895);}
case 895:{f.Push(f.Locals[11]);f.Pc=897;continue;}
case 897:{if(!rt.StaticReady(f,"forge/card/CardStateName","Meld","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Meld","Lforge/card/CardStateName;"));f.Pc=900;continue;}
case 900:{f.Push(JValue.I(1));f.Pc=901;continue;}
case 901:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",904);}
case 904:{f.StackOp("pop");f.Pc=905;continue;}
case 905:{f.Push(f.Locals[11]);f.Pc=907;continue;}
case 907:{f.Push(JValue.I(1));f.Pc=908;continue;}
case 908:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",911);}
case 911:{f.Pc=2191;continue;}
case 914:{f.Push(f.Locals[16]);f.Pc=916;continue;}
case 916:{f.Push(JValue.R(rt.String("OnAdventure")));f.Pc=919;continue;}
case 919:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",922);}
case 922:{f.Pc=f.Pop().Int==0?1014:925;continue;}
case 925:{f.Push(JValue.R(rt.String("DB$ Effect | RememberObjects$ Self | StaticAbilities$ Play | ForgetOnMoved$ Exile | Duration$ Permanent | ConditionDefined$ Self | ConditionPresent$ Card.!copiedSpell")));f.Pc=928;continue;}
case 928:{f.Locals[17]=f.Pop();f.Pc=930;continue;}
case 930:{f.Push(f.Locals[17]);f.Pc=932;continue;}
case 932:{f.Push(f.Locals[11]);f.Pc=934;continue;}
case 934:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",937);}
case 937:{f.Locals[18]=f.Pop();f.Pc=939;continue;}
case 939:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=942;continue;}
case 942:{f.StackOp("dup");f.Pc=943;continue;}
case 943:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",946);}
case 946:{f.Locals[19]=f.Pop();f.Pc=948;continue;}
case 948:{f.Push(f.Locals[19]);f.Pc=950;continue;}
case 950:{f.Push(JValue.R(rt.String("Mode$ Continuous | MayPlay$ True | EffectZone$ Command | Affected$ Card.IsRemembered+nonAdventure")));f.Pc=953;continue;}
case 953:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",956);}
case 956:{f.StackOp("pop");f.Pc=957;continue;}
case 957:{f.Push(f.Locals[19]);f.Pc=959;continue;}
case 959:{f.Push(JValue.R(rt.String(" | AffectedZone$ Exile | Description$ You may cast the card.")));f.Pc=962;continue;}
case 962:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",965);}
case 965:{f.StackOp("pop");f.Pc=966;continue;}
case 966:{f.Push(f.Locals[18]);f.Pc=968;continue;}
case 968:{f.Push(JValue.R(rt.String("Play")));f.Pc=971;continue;}
case 971:{f.Push(f.Locals[19]);f.Pc=973;continue;}
case 973:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",976);}
case 976:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",979);}
case 979:{f.Push(f.Locals[18]);f.Pc=981;continue;}
case 981:{f.Push(f.Locals[11]);f.Pc=983;continue;}
case 983:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",986);}
case 986:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",989);}
case 989:{f.Push(f.Locals[18]);f.Pc=991;continue;}
case 991:{return rt.Call(f,"forge/game/spellability/SpellAbility","resolve","()V","invokevirtual",994);}
case 994:{f.Push(f.Locals[11]);f.Pc=996;continue;}
case 996:{f.Push(f.Locals[11]);f.Pc=998;continue;}
case 998:{return rt.Call(f,"forge/game/card/Card","setExiledWith","(Lforge/game/card/Card;)V","invokevirtual",1001);}
case 1001:{f.Push(f.Locals[11]);f.Pc=1003;continue;}
case 1003:{f.Push(f.Locals[11]);f.Pc=1005;continue;}
case 1005:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1008);}
case 1008:{return rt.Call(f,"forge/game/card/Card","setExiledBy","(Lforge/game/player/Player;)V","invokevirtual",1011);}
case 1011:{f.Pc=2191;continue;}
case 1014:{f.Push(f.Locals[16]);f.Pc=1016;continue;}
case 1016:{f.Push(JValue.R(rt.String("IsCommander")));f.Pc=1019;continue;}
case 1019:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1022);}
case 1022:{f.Pc=f.Pop().Int==0?1034:1025;continue;}
case 1025:{f.Push(f.Locals[2]);f.Pc=1026;continue;}
case 1026:{f.Push(f.Locals[11]);f.Pc=1028;continue;}
case 1028:{return rt.Call(f,"forge/game/player/Player","addCommander","(Lforge/game/card/Card;)V","invokevirtual",1031);}
case 1031:{f.Pc=2191;continue;}
case 1034:{f.Push(f.Locals[16]);f.Pc=1036;continue;}
case 1036:{f.Push(JValue.R(rt.String("IsRingBearer")));f.Pc=1039;continue;}
case 1039:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1042);}
case 1042:{f.Pc=f.Pop().Int==0?1060:1045;continue;}
case 1045:{f.Push(f.Locals[11]);f.Pc=1047;continue;}
case 1047:{f.Push(JValue.I(1));f.Pc=1048;continue;}
case 1048:{return rt.Call(f,"forge/game/card/Card","setRingBearer","(Z)V","invokevirtual",1051);}
case 1051:{f.Push(f.Locals[2]);f.Pc=1052;continue;}
case 1052:{f.Push(f.Locals[11]);f.Pc=1054;continue;}
case 1054:{return rt.Call(f,"forge/game/player/Player","setRingBearer","(Lforge/game/card/Card;)V","invokevirtual",1057);}
case 1057:{f.Pc=2191;continue;}
case 1060:{f.Push(f.Locals[16]);f.Pc=1062;continue;}
case 1062:{f.Push(JValue.R(rt.String("Id:")));f.Pc=1065;continue;}
case 1065:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1068);}
case 1068:{f.Pc=f.Pop().Int==0?1102:1071;continue;}
case 1071:{f.Push(f.Locals[16]);f.Pc=1073;continue;}
case 1073:{f.Push(JValue.I(3));f.Pc=1074;continue;}
case 1074:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1077);}
case 1077:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",1080);}
case 1080:{f.Locals[17]=f.Pop();f.Pc=1082;continue;}
case 1082:{f.Push(f.Locals[0]);f.Pc=1083;continue;}
case 1083:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","idToCard","Ljava/util/Map;"));f.Pc=1086;continue;}
case 1086:{f.Push(f.Locals[17]);f.Pc=1088;continue;}
case 1088:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1091);}
case 1091:{f.Push(f.Locals[11]);f.Pc=1093;continue;}
case 1093:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1098);}
case 1098:{f.StackOp("pop");f.Pc=1099;continue;}
case 1099:{f.Pc=2191;continue;}
case 1102:{f.Push(f.Locals[16]);f.Pc=1104;continue;}
case 1104:{f.Push(JValue.R(rt.String("Attaching:")));f.Pc=1107;continue;}
case 1107:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1110);}
case 1110:{f.Pc=f.Pop().Int!=0?1124:1113;continue;}
case 1113:{f.Push(f.Locals[16]);f.Pc=1115;continue;}
case 1115:{f.Push(JValue.R(rt.String("AttachedTo:")));f.Pc=1118;continue;}
case 1118:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1121);}
case 1121:{f.Pc=f.Pop().Int==0?1163:1124;continue;}
case 1124:{f.Push(f.Locals[16]);f.Pc=1126;continue;}
case 1126:{f.Push(f.Locals[16]);f.Pc=1128;continue;}
case 1128:{f.Push(JValue.I(58));f.Pc=1130;continue;}
case 1130:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1133);}
case 1133:{f.Push(JValue.I(1));f.Pc=1134;continue;}
case 1134:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1135;continue;}
case 1135:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1138);}
case 1138:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",1141);}
case 1141:{f.Locals[17]=f.Pop();f.Pc=1143;continue;}
case 1143:{f.Push(f.Locals[0]);f.Pc=1144;continue;}
case 1144:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToAttachId","Ljava/util/Map;"));f.Pc=1147;continue;}
case 1147:{f.Push(f.Locals[11]);f.Pc=1149;continue;}
case 1149:{f.Push(f.Locals[17]);f.Pc=1151;continue;}
case 1151:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1154);}
case 1154:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1159);}
case 1159:{f.StackOp("pop");f.Pc=1160;continue;}
case 1160:{f.Pc=2191;continue;}
case 1163:{f.Push(f.Locals[16]);f.Pc=1165;continue;}
case 1165:{f.Push(JValue.R(rt.String("EnchantingPlayer:")));f.Pc=1168;continue;}
case 1168:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1171);}
case 1171:{f.Pc=f.Pop().Int==0?1215:1174;continue;}
case 1174:{f.Push(f.Locals[16]);f.Pc=1176;continue;}
case 1176:{f.Push(f.Locals[16]);f.Pc=1178;continue;}
case 1178:{f.Push(JValue.I(58));f.Pc=1180;continue;}
case 1180:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1183);}
case 1183:{f.Push(JValue.I(1));f.Pc=1184;continue;}
case 1184:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1185;continue;}
case 1185:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1188);}
case 1188:{f.Locals[17]=f.Pop();f.Pc=1190;continue;}
case 1190:{f.Push(f.Locals[0]);f.Pc=1191;continue;}
case 1191:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToEnchantPlayerId","Ljava/util/Map;"));f.Pc=1194;continue;}
case 1194:{f.Push(f.Locals[11]);f.Pc=1196;continue;}
case 1196:{f.Push(f.Locals[0]);f.Pc=1197;continue;}
case 1197:{f.Push(f.Locals[2]);f.Pc=1198;continue;}
case 1198:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",1201);}
case 1201:{f.Push(f.Locals[17]);f.Pc=1203;continue;}
case 1203:{return rt.Call(f,"forge/game/GameState","parsePlayerString","(Lforge/game/Game;Ljava/lang/String;)Lforge/game/player/Player;","invokevirtual",1206);}
case 1206:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1211);}
case 1211:{f.StackOp("pop");f.Pc=1212;continue;}
case 1212:{f.Pc=2191;continue;}
case 1215:{f.Push(f.Locals[16]);f.Pc=1217;continue;}
case 1217:{f.Push(JValue.R(rt.String("Owner:")));f.Pc=1220;continue;}
case 1220:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1223);}
case 1223:{f.Pc=f.Pop().Int==0?1282:1226;continue;}
case 1226:{f.Push(f.Locals[16]);f.Pc=1228;continue;}
case 1228:{f.Push(f.Locals[16]);f.Pc=1230;continue;}
case 1230:{f.Push(JValue.I(58));f.Pc=1232;continue;}
case 1232:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1235);}
case 1235:{f.Push(JValue.I(1));f.Pc=1236;continue;}
case 1236:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1237;continue;}
case 1237:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1240);}
case 1240:{f.Locals[17]=f.Pop();f.Pc=1242;continue;}
case 1242:{f.Push(f.Locals[11]);f.Pc=1244;continue;}
case 1244:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1247);}
case 1247:{f.Locals[18]=f.Pop();f.Pc=1249;continue;}
case 1249:{f.Push(f.Locals[11]);f.Pc=1251;continue;}
case 1251:{f.Push(f.Locals[0]);f.Pc=1252;continue;}
case 1252:{f.Push(f.Locals[2]);f.Pc=1253;continue;}
case 1253:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",1256);}
case 1256:{f.Push(f.Locals[17]);f.Pc=1258;continue;}
case 1258:{return rt.Call(f,"forge/game/GameState","parsePlayerString","(Lforge/game/Game;Ljava/lang/String;)Lforge/game/player/Player;","invokevirtual",1261);}
case 1261:{return rt.Call(f,"forge/game/card/Card","setOwner","(Lforge/game/player/Player;)V","invokevirtual",1264);}
case 1264:{f.Push(f.Locals[11]);f.Pc=1266;continue;}
case 1266:{f.Push(f.Locals[18]);f.Pc=1268;continue;}
case 1268:{f.Push(f.Locals[11]);f.Pc=1270;continue;}
case 1270:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",1273);}
case 1273:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",1276);}
case 1276:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",1279);}
case 1279:{f.Pc=2191;continue;}
case 1282:{f.Push(f.Locals[16]);f.Pc=1284;continue;}
case 1284:{f.Push(JValue.R(rt.String("Ability:")));f.Pc=1287;continue;}
case 1287:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1290);}
case 1290:{f.Pc=f.Pop().Int==0?1339:1293;continue;}
case 1293:{f.Push(f.Locals[16]);f.Pc=1295;continue;}
case 1295:{f.Push(f.Locals[16]);f.Pc=1297;continue;}
case 1297:{f.Push(JValue.I(58));f.Pc=1299;continue;}
case 1299:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1302);}
case 1302:{f.Push(JValue.I(1));f.Pc=1303;continue;}
case 1303:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1304;continue;}
case 1304:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1307);}
case 1307:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",1310);}
case 1310:{f.Locals[17]=f.Pop();f.Pc=1312;continue;}
case 1312:{f.Push(f.Locals[11]);f.Pc=1314;continue;}
case 1314:{f.Push(f.Locals[0]);f.Pc=1315;continue;}
case 1315:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","abilityString","Ljava/util/Map;"));f.Pc=1318;continue;}
case 1318:{f.Push(f.Locals[17]);f.Pc=1320;continue;}
case 1320:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1325);}
case 1325:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1328;continue;}
case 1328:{f.Push(f.Locals[11]);f.Pc=1330;continue;}
case 1330:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",1333);}
case 1333:{return rt.Call(f,"forge/game/card/Card","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1336);}
case 1336:{f.Pc=2191;continue;}
case 1339:{f.Push(f.Locals[16]);f.Pc=1341;continue;}
case 1341:{f.Push(JValue.R(rt.String("Damage:")));f.Pc=1344;continue;}
case 1344:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1347);}
case 1347:{f.Pc=f.Pop().Int==0?1389:1350;continue;}
case 1350:{f.Push(f.Locals[16]);f.Pc=1352;continue;}
case 1352:{f.Push(f.Locals[16]);f.Pc=1354;continue;}
case 1354:{f.Push(JValue.I(58));f.Pc=1356;continue;}
case 1356:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1359);}
case 1359:{f.Push(JValue.I(1));f.Pc=1360;continue;}
case 1360:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1361;continue;}
case 1361:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1364);}
case 1364:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",1367);}
case 1367:{f.Locals[17]=f.Pop();f.Pc=1369;continue;}
case 1369:{f.Push(f.Locals[0]);f.Pc=1370;continue;}
case 1370:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","markedDamage","Ljava/util/Map;"));f.Pc=1373;continue;}
case 1373:{f.Push(f.Locals[11]);f.Pc=1375;continue;}
case 1375:{f.Push(f.Locals[17]);f.Pc=1377;continue;}
case 1377:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1380);}
case 1380:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1385);}
case 1385:{f.StackOp("pop");f.Pc=1386;continue;}
case 1386:{f.Pc=2191;continue;}
case 1389:{f.Push(f.Locals[16]);f.Pc=1391;continue;}
case 1391:{f.Push(JValue.R(rt.String("ChosenColor:")));f.Pc=1394;continue;}
case 1394:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1397);}
case 1397:{f.Pc=f.Pop().Int==0?1438:1400;continue;}
case 1400:{f.Push(f.Locals[0]);f.Pc=1401;continue;}
case 1401:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToChosenClrs","Ljava/util/Map;"));f.Pc=1404;continue;}
case 1404:{f.Push(f.Locals[11]);f.Pc=1406;continue;}
case 1406:{f.Push(f.Locals[16]);f.Pc=1408;continue;}
case 1408:{f.Push(f.Locals[16]);f.Pc=1410;continue;}
case 1410:{f.Push(JValue.I(58));f.Pc=1412;continue;}
case 1412:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1415);}
case 1415:{f.Push(JValue.I(1));f.Pc=1416;continue;}
case 1416:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1417;continue;}
case 1417:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1420);}
case 1420:{f.Push(JValue.R(rt.String(",")));f.Pc=1423;continue;}
case 1423:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1426);}
case 1426:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",1429);}
case 1429:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1434);}
case 1434:{f.StackOp("pop");f.Pc=1435;continue;}
case 1435:{f.Pc=2191;continue;}
case 1438:{f.Push(f.Locals[16]);f.Pc=1440;continue;}
case 1440:{f.Push(JValue.R(rt.String("ChosenType:")));f.Pc=1443;continue;}
case 1443:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1446);}
case 1446:{f.Pc=f.Pop().Int==0?1478:1449;continue;}
case 1449:{f.Push(f.Locals[0]);f.Pc=1450;continue;}
case 1450:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToChosenType","Ljava/util/Map;"));f.Pc=1453;continue;}
case 1453:{f.Push(f.Locals[11]);f.Pc=1455;continue;}
case 1455:{f.Push(f.Locals[16]);f.Pc=1457;continue;}
case 1457:{f.Push(f.Locals[16]);f.Pc=1459;continue;}
case 1459:{f.Push(JValue.I(58));f.Pc=1461;continue;}
case 1461:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1464);}
case 1464:{f.Push(JValue.I(1));f.Pc=1465;continue;}
case 1465:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1466;continue;}
case 1466:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1469);}
case 1469:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1474);}
case 1474:{f.StackOp("pop");f.Pc=1475;continue;}
case 1475:{f.Pc=2191;continue;}
case 1478:{f.Push(f.Locals[16]);f.Pc=1480;continue;}
case 1480:{f.Push(JValue.R(rt.String("ChosenType2:")));f.Pc=1483;continue;}
case 1483:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1486);}
case 1486:{f.Pc=f.Pop().Int==0?1518:1489;continue;}
case 1489:{f.Push(f.Locals[0]);f.Pc=1490;continue;}
case 1490:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToChosenType2","Ljava/util/Map;"));f.Pc=1493;continue;}
case 1493:{f.Push(f.Locals[11]);f.Pc=1495;continue;}
case 1495:{f.Push(f.Locals[16]);f.Pc=1497;continue;}
case 1497:{f.Push(f.Locals[16]);f.Pc=1499;continue;}
case 1499:{f.Push(JValue.I(58));f.Pc=1501;continue;}
case 1501:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1504);}
case 1504:{f.Push(JValue.I(1));f.Pc=1505;continue;}
case 1505:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1506;continue;}
case 1506:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1509);}
case 1509:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1514);}
case 1514:{f.StackOp("pop");f.Pc=1515;continue;}
case 1515:{f.Pc=2191;continue;}
case 1518:{f.Push(f.Locals[16]);f.Pc=1520;continue;}
case 1520:{f.Push(JValue.R(rt.String("ChosenCards:")));f.Pc=1523;continue;}
case 1523:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1526);}
case 1526:{f.Pc=f.Pop().Int==0?1635:1529;continue;}
case 1529:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1532;continue;}
case 1532:{f.StackOp("dup");f.Pc=1533;continue;}
case 1533:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",1536);}
case 1536:{f.Locals[17]=f.Pop();f.Pc=1538;continue;}
case 1538:{f.Push(f.Locals[16]);f.Pc=1540;continue;}
case 1540:{f.Push(f.Locals[16]);f.Pc=1542;continue;}
case 1542:{f.Push(JValue.I(58));f.Pc=1544;continue;}
case 1544:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1547);}
case 1547:{f.Push(JValue.I(1));f.Pc=1548;continue;}
case 1548:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1549;continue;}
case 1549:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1552);}
case 1552:{f.Push(JValue.R(rt.String(",")));f.Pc=1555;continue;}
case 1555:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1558);}
case 1558:{f.Locals[18]=f.Pop();f.Pc=1560;continue;}
case 1560:{f.Push(f.Locals[18]);f.Pc=1562;continue;}
case 1562:{f.Locals[19]=f.Pop();f.Pc=1564;continue;}
case 1564:{f.Push(f.Locals[19]);f.Pc=1566;continue;}
case 1566:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1567;continue;}
case 1567:{f.Locals[20]=f.Pop();f.Pc=1569;continue;}
case 1569:{f.Push(JValue.I(0));f.Pc=1570;continue;}
case 1570:{f.Locals[21]=f.Pop();f.Pc=1572;continue;}
case 1572:{f.Push(f.Locals[21]);f.Pc=1574;continue;}
case 1574:{f.Push(f.Locals[20]);f.Pc=1576;continue;}
case 1576:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1618:1579;continue;}
case 1579:{f.Push(f.Locals[19]);f.Pc=1581;continue;}
case 1581:{f.Push(f.Locals[21]);f.Pc=1583;continue;}
case 1583:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1584;continue;}
case 1584:{f.Locals[22]=f.Pop();f.Pc=1586;continue;}
case 1586:{f.Push(f.Locals[17]);f.Pc=1588;continue;}
case 1588:{f.Push(f.Locals[0]);f.Pc=1589;continue;}
case 1589:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","idToCard","Ljava/util/Map;"));f.Pc=1592;continue;}
case 1592:{f.Push(f.Locals[22]);f.Pc=1594;continue;}
case 1594:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",1597);}
case 1597:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1600);}
case 1600:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1605);}
case 1605:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1608;continue;}
case 1608:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",1611);}
case 1611:{f.StackOp("pop");f.Pc=1612;continue;}
case 1612:{f.Locals[21]=JValue.I(unchecked(f.Locals[21].Int+(1)));f.Pc=1615;continue;}
case 1615:{f.Pc=1572;continue;}
case 1618:{f.Push(f.Locals[0]);f.Pc=1619;continue;}
case 1619:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToChosenCards","Ljava/util/Map;"));f.Pc=1622;continue;}
case 1622:{f.Push(f.Locals[11]);f.Pc=1624;continue;}
case 1624:{f.Push(f.Locals[17]);f.Pc=1626;continue;}
case 1626:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1631);}
case 1631:{f.StackOp("pop");f.Pc=1632;continue;}
case 1632:{f.Pc=2191;continue;}
case 1635:{f.Push(f.Locals[16]);f.Pc=1637;continue;}
case 1637:{f.Push(JValue.R(rt.String("MergedCards:")));f.Pc=1640;continue;}
case 1640:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1643);}
case 1643:{f.Pc=f.Pop().Int==0?1688:1646;continue;}
case 1646:{f.Push(f.Locals[16]);f.Pc=1648;continue;}
case 1648:{f.Push(f.Locals[16]);f.Pc=1650;continue;}
case 1650:{f.Push(JValue.I(58));f.Pc=1652;continue;}
case 1652:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1655);}
case 1655:{f.Push(JValue.I(1));f.Pc=1656;continue;}
case 1656:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1657;continue;}
case 1657:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1660);}
case 1660:{f.Push(JValue.R(rt.String(",")));f.Pc=1663;continue;}
case 1663:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1666);}
case 1666:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",1669);}
case 1669:{f.Locals[17]=f.Pop();f.Pc=1671;continue;}
case 1671:{f.Push(f.Locals[0]);f.Pc=1672;continue;}
case 1672:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToMergedCards","Ljava/util/Map;"));f.Pc=1675;continue;}
case 1675:{f.Push(f.Locals[11]);f.Pc=1677;continue;}
case 1677:{f.Push(f.Locals[17]);f.Pc=1679;continue;}
case 1679:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1684);}
case 1684:{f.StackOp("pop");f.Pc=1685;continue;}
case 1685:{f.Pc=2191;continue;}
case 1688:{f.Push(f.Locals[16]);f.Pc=1690;continue;}
case 1690:{f.Push(JValue.R(rt.String("NamedCard:")));f.Pc=1693;continue;}
case 1693:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1696);}
case 1696:{f.Pc=f.Pop().Int==0?1741:1699;continue;}
case 1699:{f.Push(f.Locals[16]);f.Pc=1701;continue;}
case 1701:{f.Push(f.Locals[16]);f.Pc=1703;continue;}
case 1703:{f.Push(JValue.I(58));f.Pc=1705;continue;}
case 1705:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1708);}
case 1708:{f.Push(JValue.I(1));f.Pc=1709;continue;}
case 1709:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1710;continue;}
case 1710:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1713);}
case 1713:{f.Push(JValue.R(rt.String(",")));f.Pc=1716;continue;}
case 1716:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1719);}
case 1719:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",1722);}
case 1722:{f.Locals[17]=f.Pop();f.Pc=1724;continue;}
case 1724:{f.Push(f.Locals[0]);f.Pc=1725;continue;}
case 1725:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToNamedCard","Ljava/util/Map;"));f.Pc=1728;continue;}
case 1728:{f.Push(f.Locals[11]);f.Pc=1730;continue;}
case 1730:{f.Push(f.Locals[17]);f.Pc=1732;continue;}
case 1732:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1737);}
case 1737:{f.StackOp("pop");f.Pc=1738;continue;}
case 1738:{f.Pc=2191;continue;}
case 1741:{f.Push(f.Locals[16]);f.Pc=1743;continue;}
case 1743:{f.Push(JValue.R(rt.String("ExecuteScript:")));f.Pc=1746;continue;}
case 1746:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1749);}
case 1749:{f.Pc=f.Pop().Int==0?1781:1752;continue;}
case 1752:{f.Push(f.Locals[0]);f.Pc=1753;continue;}
case 1753:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToScript","Ljava/util/Map;"));f.Pc=1756;continue;}
case 1756:{f.Push(f.Locals[11]);f.Pc=1758;continue;}
case 1758:{f.Push(f.Locals[16]);f.Pc=1760;continue;}
case 1760:{f.Push(f.Locals[16]);f.Pc=1762;continue;}
case 1762:{f.Push(JValue.I(58));f.Pc=1764;continue;}
case 1764:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1767);}
case 1767:{f.Push(JValue.I(1));f.Pc=1768;continue;}
case 1768:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1769;continue;}
case 1769:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1772);}
case 1772:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1777);}
case 1777:{f.StackOp("pop");f.Pc=1778;continue;}
case 1778:{f.Pc=2191;continue;}
case 1781:{f.Push(f.Locals[16]);f.Pc=1783;continue;}
case 1783:{f.Push(JValue.R(rt.String("RememberedCards:")));f.Pc=1786;continue;}
case 1786:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1789);}
case 1789:{f.Pc=f.Pop().Int==0?1830:1792;continue;}
case 1792:{f.Push(f.Locals[0]);f.Pc=1793;continue;}
case 1793:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToRememberedId","Ljava/util/Map;"));f.Pc=1796;continue;}
case 1796:{f.Push(f.Locals[11]);f.Pc=1798;continue;}
case 1798:{f.Push(f.Locals[16]);f.Pc=1800;continue;}
case 1800:{f.Push(f.Locals[16]);f.Pc=1802;continue;}
case 1802:{f.Push(JValue.I(58));f.Pc=1804;continue;}
case 1804:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1807);}
case 1807:{f.Push(JValue.I(1));f.Pc=1808;continue;}
case 1808:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1809;continue;}
case 1809:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1812);}
case 1812:{f.Push(JValue.R(rt.String(",")));f.Pc=1815;continue;}
case 1815:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1818);}
case 1818:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",1821);}
case 1821:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1826);}
case 1826:{f.StackOp("pop");f.Pc=1827;continue;}
case 1827:{f.Pc=2191;continue;}
case 1830:{f.Push(f.Locals[16]);f.Pc=1832;continue;}
case 1832:{f.Push(JValue.R(rt.String("Imprinting:")));f.Pc=1835;continue;}
case 1835:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1838);}
case 1838:{f.Pc=f.Pop().Int==0?1879:1841;continue;}
case 1841:{f.Push(f.Locals[0]);f.Pc=1842;continue;}
case 1842:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToImprintedId","Ljava/util/Map;"));f.Pc=1845;continue;}
case 1845:{f.Push(f.Locals[11]);f.Pc=1847;continue;}
case 1847:{f.Push(f.Locals[16]);f.Pc=1849;continue;}
case 1849:{f.Push(f.Locals[16]);f.Pc=1851;continue;}
case 1851:{f.Push(JValue.I(58));f.Pc=1853;continue;}
case 1853:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1856);}
case 1856:{f.Push(JValue.I(1));f.Pc=1857;continue;}
case 1857:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1858;continue;}
case 1858:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1861);}
case 1861:{f.Push(JValue.R(rt.String(",")));f.Pc=1864;continue;}
case 1864:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1867);}
case 1867:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",1870);}
case 1870:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1875);}
case 1875:{f.StackOp("pop");f.Pc=1876;continue;}
case 1876:{f.Pc=2191;continue;}
case 1879:{f.Push(f.Locals[16]);f.Pc=1881;continue;}
case 1881:{f.Push(JValue.R(rt.String("ExiledWith:")));f.Pc=1884;continue;}
case 1884:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1887);}
case 1887:{f.Pc=f.Pop().Int==0?1919:1890;continue;}
case 1890:{f.Push(f.Locals[0]);f.Pc=1891;continue;}
case 1891:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardToExiledWithId","Ljava/util/Map;"));f.Pc=1894;continue;}
case 1894:{f.Push(f.Locals[11]);f.Pc=1896;continue;}
case 1896:{f.Push(f.Locals[16]);f.Pc=1898;continue;}
case 1898:{f.Push(f.Locals[16]);f.Pc=1900;continue;}
case 1900:{f.Push(JValue.I(58));f.Pc=1902;continue;}
case 1902:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1905);}
case 1905:{f.Push(JValue.I(1));f.Pc=1906;continue;}
case 1906:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1907;continue;}
case 1907:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1910);}
case 1910:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1915);}
case 1915:{f.StackOp("pop");f.Pc=1916;continue;}
case 1916:{f.Pc=2191;continue;}
case 1919:{f.Push(f.Locals[16]);f.Pc=1921;continue;}
case 1921:{f.Push(JValue.R(rt.String("Attacking")));f.Pc=1924;continue;}
case 1924:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1927);}
case 1927:{f.Pc=f.Pop().Int==0?2008:1930;continue;}
case 1930:{f.Push(f.Locals[16]);f.Pc=1932;continue;}
case 1932:{f.Push(JValue.R(rt.String(":")));f.Pc=1935;continue;}
case 1935:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",1938);}
case 1938:{f.Pc=f.Pop().Int==0?1992:1941;continue;}
case 1941:{f.Push(f.Locals[16]);f.Pc=1943;continue;}
case 1943:{f.Push(f.Locals[16]);f.Pc=1945;continue;}
case 1945:{f.Push(JValue.I(58));f.Pc=1947;continue;}
case 1947:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1950);}
case 1950:{f.Push(JValue.I(1));f.Pc=1951;continue;}
case 1951:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1952;continue;}
case 1952:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1955);}
case 1955:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",1958);}
case 1958:{f.Locals[17]=f.Pop();f.Pc=1960;continue;}
case 1960:{f.Push(f.Locals[0]);f.Pc=1961;continue;}
case 1961:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardAttackMap","Ljava/util/Map;"));f.Pc=1964;continue;}
case 1964:{f.Push(f.Locals[11]);f.Pc=1966;continue;}
case 1966:{f.Push(f.Locals[0]);f.Pc=1967;continue;}
case 1967:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","idToCard","Ljava/util/Map;"));f.Pc=1970;continue;}
case 1970:{f.Push(f.Locals[17]);f.Pc=1972;continue;}
case 1972:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1975);}
case 1975:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1980);}
case 1980:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1983;continue;}
case 1983:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1988);}
case 1988:{f.StackOp("pop");f.Pc=1989;continue;}
case 1989:{f.Pc=2191;continue;}
case 1992:{f.Push(f.Locals[0]);f.Pc=1993;continue;}
case 1993:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardAttackMap","Ljava/util/Map;"));f.Pc=1996;continue;}
case 1996:{f.Push(f.Locals[11]);f.Pc=1998;continue;}
case 1998:{f.Push(JValue.R(null));f.Pc=1999;continue;}
case 1999:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2004);}
case 2004:{f.StackOp("pop");f.Pc=2005;continue;}
case 2005:{f.Pc=2191;continue;}
case 2008:{f.Push(f.Locals[16]);f.Pc=2010;continue;}
case 2010:{f.Push(JValue.R(rt.String("NoETBTrigs")));f.Pc=2013;continue;}
case 2013:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2016);}
case 2016:{f.Pc=f.Pop().Int==0?2034:2019;continue;}
case 2019:{f.Push(f.Locals[0]);f.Pc=2020;continue;}
case 2020:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","cardsWithoutETBTrigs","Ljava/util/Set;"));f.Pc=2023;continue;}
case 2023:{f.Push(f.Locals[11]);f.Pc=2025;continue;}
case 2025:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",2030);}
case 2030:{f.StackOp("pop");f.Pc=2031;continue;}
case 2031:{f.Pc=2191;continue;}
case 2034:{f.Push(f.Locals[16]);f.Pc=2036;continue;}
case 2036:{f.Push(JValue.R(rt.String("Foretold")));f.Pc=2039;continue;}
case 2039:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2042);}
case 2042:{f.Pc=f.Pop().Int==0?2071:2045;continue;}
case 2045:{f.Push(f.Locals[11]);f.Pc=2047;continue;}
case 2047:{f.Push(JValue.I(1));f.Pc=2048;continue;}
case 2048:{return rt.Call(f,"forge/game/card/Card","setForetold","(Z)V","invokevirtual",2051);}
case 2051:{f.Push(f.Locals[11]);f.Pc=2053;continue;}
case 2053:{f.Push(JValue.I(1));f.Pc=2054;continue;}
case 2054:{return rt.Call(f,"forge/game/card/Card","turnFaceDown","(Z)Z","invokevirtual",2057);}
case 2057:{f.StackOp("pop");f.Pc=2058;continue;}
case 2058:{f.Push(f.Locals[11]);f.Pc=2060;continue;}
case 2060:{f.Push(f.Locals[11]);f.Pc=2062;continue;}
case 2062:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",2065);}
case 2065:{return rt.Call(f,"forge/game/card/Card","addMayLookFaceDownExile","(Lforge/game/player/Player;)V","invokevirtual",2068);}
case 2068:{f.Pc=2191;continue;}
case 2071:{f.Push(f.Locals[16]);f.Pc=2073;continue;}
case 2073:{f.Push(JValue.R(rt.String("ForetoldThisTurn")));f.Pc=2076;continue;}
case 2076:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2079);}
case 2079:{f.Pc=f.Pop().Int==0?2094:2082;continue;}
case 2082:{f.Push(f.Locals[11]);f.Pc=2084;continue;}
case 2084:{f.Push(f.Locals[0]);f.Pc=2085;continue;}
case 2085:{f.Push(rt.GetField(f.Pop(),"forge/game/GameState","turn","I"));f.Pc=2088;continue;}
case 2088:{return rt.Call(f,"forge/game/card/Card","setTurnInZone","(I)V","invokevirtual",2091);}
case 2091:{f.Pc=2191;continue;}
case 2094:{f.Push(f.Locals[16]);f.Pc=2096;continue;}
case 2096:{f.Push(JValue.R(rt.String("IsToken")));f.Pc=2099;continue;}
case 2099:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2102);}
case 2102:{f.Pc=f.Pop().Int==0?2116:2105;continue;}
case 2105:{f.Push(f.Locals[11]);f.Pc=2107;continue;}
case 2107:{if(!rt.StaticReady(f,"forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"));f.Pc=2110;continue;}
case 2110:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",2113);}
case 2113:{f.Pc=2191;continue;}
case 2116:{f.Push(f.Locals[16]);f.Pc=2118;continue;}
case 2118:{f.Push(JValue.R(rt.String("ClassLevel:")));f.Pc=2121;continue;}
case 2121:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2124);}
case 2124:{f.Pc=f.Pop().Int==0?2152:2127;continue;}
case 2127:{f.Push(f.Locals[11]);f.Pc=2129;continue;}
case 2129:{f.Push(f.Locals[16]);f.Pc=2131;continue;}
case 2131:{f.Push(f.Locals[16]);f.Pc=2133;continue;}
case 2133:{f.Push(JValue.I(58));f.Pc=2135;continue;}
case 2135:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",2138);}
case 2138:{f.Push(JValue.I(1));f.Pc=2139;continue;}
case 2139:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=2140;continue;}
case 2140:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",2143);}
case 2143:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",2146);}
case 2146:{return rt.Call(f,"forge/game/card/Card","setClassLevel","(I)V","invokevirtual",2149);}
case 2149:{f.Pc=2191;continue;}
case 2152:{f.Push(f.Locals[16]);f.Pc=2154;continue;}
case 2154:{f.Push(JValue.R(rt.String("UnlockedRoom:")));f.Pc=2157;continue;}
case 2157:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2160);}
case 2160:{f.Pc=f.Pop().Int==0?2191:2163;continue;}
case 2163:{f.Push(f.Locals[11]);f.Pc=2165;continue;}
case 2165:{f.Push(f.Locals[11]);f.Pc=2167;continue;}
case 2167:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",2170);}
case 2170:{f.Push(f.Locals[16]);f.Pc=2172;continue;}
case 2172:{f.Push(f.Locals[16]);f.Pc=2174;continue;}
case 2174:{f.Push(JValue.I(58));f.Pc=2176;continue;}
case 2176:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",2179);}
case 2179:{f.Push(JValue.I(1));f.Pc=2180;continue;}
case 2180:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=2181;continue;}
case 2181:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",2184);}
case 2184:{return rt.Call(f,"forge/card/CardStateName","smartValueOf","(Ljava/lang/String;)Lforge/card/CardStateName;","invokestatic",2187);}
case 2187:{return rt.Call(f,"forge/game/card/Card","unlockRoom","(Lforge/game/player/Player;Lforge/card/CardStateName;)Z","invokevirtual",2190);}
case 2190:{f.StackOp("pop");f.Pc=2191;continue;}
case 2191:{f.Locals[15]=JValue.I(unchecked(f.Locals[15].Int+(1)));f.Pc=2194;continue;}
case 2194:{f.Pc=416;continue;}
case 2197:{f.Push(f.Locals[12]);f.Pc=2199;continue;}
case 2199:{f.Pc=f.Pop().Int!=0?2220:2202;continue;}
case 2202:{f.Push(f.Locals[11]);f.Pc=2204;continue;}
case 2204:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",2207);}
case 2207:{f.Pc=f.Pop().Int!=0?2220:2210;continue;}
case 2210:{f.Push(f.Locals[11]);f.Pc=2212;continue;}
case 2212:{f.Push(f.Locals[11]);f.Pc=2214;continue;}
case 2214:{return rt.Call(f,"forge/game/card/Card","getMostRecentSet","()Ljava/lang/String;","invokevirtual",2217);}
case 2217:{return rt.Call(f,"forge/game/card/Card","setSetCode","(Ljava/lang/String;)V","invokevirtual",2220);}
case 2220:{f.Push(f.Locals[3]);f.Pc=2221;continue;}
case 2221:{f.Push(f.Locals[11]);f.Pc=2223;continue;}
case 2223:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",2226);}
case 2226:{f.StackOp("pop");f.Pc=2227;continue;}
case 2227:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=2230;continue;}
case 2230:{f.Pc=19;continue;}
case 2233:{f.Push(f.Locals[3]);f.Pc=2234;continue;}
case 2234:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2620(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","produceMana","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2621(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameState","applyGameOnThread","(Lforge/game/Game;)V","invokevirtual",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2622(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",7);}
case 7:{if(!rt.StaticReady(f,"forge/game/GameState","ZONES","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/game/GameState","ZONES","Ljava/util/Map;",f.Pop());f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/game/GameState","ZONES","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameState","ZONES","Ljava/util/Map;"));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("battlefield")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/GameState","ZONES","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameState","ZONES","Ljava/util/Map;"));f.Pc=28;continue;}
case 28:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("hand")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{if(!rt.StaticReady(f,"forge/game/GameState","ZONES","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameState","ZONES","Ljava/util/Map;"));f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("graveyard")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{if(!rt.StaticReady(f,"forge/game/GameState","ZONES","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameState","ZONES","Ljava/util/Map;"));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("library")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{if(!rt.StaticReady(f,"forge/game/GameState","ZONES","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameState","ZONES","Ljava/util/Map;"));f.Pc=73;continue;}
case 73:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("exile")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{if(!rt.StaticReady(f,"forge/game/GameState","ZONES","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameState","ZONES","Ljava/util/Map;"));f.Pc=88;continue;}
case 88:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("command")));f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",99);}
case 99:{f.StackOp("pop");f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/GameState","ZONES","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameState","ZONES","Ljava/util/Map;"));f.Pc=103;continue;}
case 103:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"));f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("sideboard")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("(Image:[^|;,]*)\\|([A-Za-z0-9]{2,5})\\|((?=[A-Za-z0-9]*\\d)[A-Za-z0-9]{1,6})(?:\\|(\\d+))?(?=[|,]|$)")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",121);}
case 121:{if(!rt.StaticReady(f,"forge/game/GameState","LEGACY_TOKEN_IMAGE","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/game/GameState","LEGACY_TOKEN_IMAGE","Ljava/util/regex/Pattern;",f.Pop());f.Pc=124;continue;}
case 124:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
