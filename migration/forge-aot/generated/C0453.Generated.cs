// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C453{
internal static JClass Build(){var c=new JClass("forge/game/card/CardFactoryUtil","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(5006,"forge/game/card/CardFactoryUtil","<init>","()V",1,1,1,new JHandler[]{},M5006));
c.Add(new JMethod(5007,"forge/game/card/CardFactoryUtil","abilityCastFaceDown","(Lforge/game/card/CardState;ZLjava/lang/String;)Lforge/game/spellability/SpellAbility;",9,4,7,new JHandler[]{},M5007));
c.Add(new JMethod(5008,"forge/game/card/CardFactoryUtil","abilityUnlockRoom","(Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;",9,2,2,new JHandler[]{},M5008));
c.Add(new JMethod(5009,"forge/game/card/CardFactoryUtil","abilityTurnFaceUp","(Lforge/game/card/CardState;Lforge/game/cost/Cost;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lforge/game/spellability/SpellAbility;",9,9,4,new JHandler[]{},M5009));
c.Add(new JMethod(5010,"forge/game/card/CardFactoryUtil","handleHiddenAgenda","(Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/keyword/KeywordInterface;)Z",9,7,5,new JHandler[]{},M5010));
c.Add(new JMethod(5011,"forge/game/card/CardFactoryUtil","abilityRevealHiddenAgenda","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;",10,2,2,new JHandler[]{},M5011));
c.Add(new JMethod(5012,"forge/game/card/CardFactoryUtil","extractOperators","(Ljava/lang/String;)Ljava/lang/String;",9,2,2,new JHandler[]{},M5012));
c.Add(new JMethod(5013,"forge/game/card/CardFactoryUtil","getMostProminentColors","(Ljava/lang/Iterable;)B",9,9,4,new JHandler[]{},M5013));
c.Add(new JMethod(5014,"forge/game/card/CardFactoryUtil","SortColorsFromList","(Lforge/game/card/CardCollection;)[I",9,7,4,new JHandler[]{},M5014));
c.Add(new JMethod(5015,"forge/game/card/CardFactoryUtil","getMostProminentColorsFromList","(Lforge/game/card/CardCollectionView;Ljava/lang/Iterable;)B",9,9,4,new JHandler[]{},M5015));
c.Add(new JMethod(5016,"forge/game/card/CardFactoryUtil","getMostProminentCreatureTypeSize","(Lforge/game/card/CardCollection;)I",9,8,4,new JHandler[]{},M5016));
c.Add(new JMethod(5017,"forge/game/card/CardFactoryUtil","getMostProminentCreatureType","(Lforge/game/card/CardCollectionView;)Ljava/lang/Iterable;",9,6,4,new JHandler[]{},M5017));
c.Add(new JMethod(5018,"forge/game/card/CardFactoryUtil","sharedKeywords","(Ljava/lang/Iterable;[Ljava/lang/String;Ljava/lang/Iterable;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/List;",9,7,6,new JHandler[]{},M5018));
c.Add(new JMethod(5019,"forge/game/card/CardFactoryUtil","getSharedKeywords","(Ljava/lang/Iterable;Lforge/game/card/CardCollection;)Ljava/util/List;",9,20,3,new JHandler[]{},M5019));
c.Add(new JMethod(5020,"forge/game/card/CardFactoryUtil","addAbilityFactoryAbilities","(Lforge/game/card/Card;Ljava/lang/Iterable;)V",25,7,5,new JHandler[]{new JHandler(26,54,57,"java/lang/Exception")},M5020));
c.Add(new JMethod(5021,"forge/game/card/CardFactoryUtil","setupKeywordedAbilities","(Lforge/game/card/Card;)V",9,3,3,new JHandler[]{},M5021));
c.Add(new JMethod(5022,"forge/game/card/CardFactoryUtil","createETBReplacement","(Lforge/game/card/CardState;Lforge/game/replacement/ReplacementLayer;Ljava/lang/String;ZZZLjava/lang/String;Ljava/lang/String;)Lforge/game/replacement/ReplacementEffect;",10,9,8,new JHandler[]{},M5022));
c.Add(new JMethod(5023,"forge/game/card/CardFactoryUtil","createETBReplacement","(Lforge/game/card/CardState;Lforge/game/replacement/ReplacementLayer;Lforge/game/spellability/SpellAbility;ZZZLjava/lang/String;Ljava/lang/String;)Lforge/game/replacement/ReplacementEffect;",10,12,4,new JHandler[]{},M5023));
c.Add(new JMethod(5024,"forge/game/card/CardFactoryUtil","makeEtbCounter","(Ljava/lang/String;Lforge/game/card/CardState;Z)Lforge/game/replacement/ReplacementEffect;",9,12,4,new JHandler[]{},M5024));
c.Add(new JMethod(5025,"forge/game/card/CardFactoryUtil","addTriggerAbility","(Lforge/game/keyword/KeywordInterface;Lforge/game/card/Card;Z)V",9,23,5,new JHandler[]{},M5025));
c.Add(new JMethod(5026,"forge/game/card/CardFactoryUtil","addReplacementEffect","(Lforge/game/keyword/KeywordInterface;Lforge/game/card/CardState;Z)V",9,19,8,new JHandler[]{},M5026));
c.Add(new JMethod(5027,"forge/game/card/CardFactoryUtil","addSpellAbility","(Lforge/game/keyword/KeywordInterface;Lforge/game/card/CardState;Z)V",9,26,7,new JHandler[]{},M5027));
c.Add(new JMethod(5028,"forge/game/card/CardFactoryUtil","addStaticAbility","(Lforge/game/keyword/KeywordInterface;Lforge/game/card/CardState;Z)V",9,17,5,new JHandler[]{},M5028));
c.Add(new JMethod(5029,"forge/game/card/CardFactoryUtil","setupSiegeAbilities","(Lforge/game/card/Card;)V",9,10,3,new JHandler[]{},M5029));
c.Add(new JMethod(5030,"forge/game/card/CardFactoryUtil","setupAdventureAbility","(Lforge/game/card/CardState;)Lforge/game/replacement/ReplacementEffect;",9,9,3,new JHandler[]{},M5030));
c.Add(new JMethod(5031,"forge/game/card/CardFactoryUtil","setupOmenAbility","(Lforge/game/card/CardState;)Lforge/game/replacement/ReplacementEffect;",9,6,3,new JHandler[]{},M5031));
c.Add(new JMethod(5032,"forge/game/card/CardFactoryUtil","setupVengeanceAbility","(Lforge/game/card/CardState;)Lforge/game/replacement/ReplacementEffect;",9,4,3,new JHandler[]{},M5032));
c.Add(new JMethod(5033,"forge/game/card/CardFactoryUtil","setFaceDownState","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V",9,5,5,new JHandler[]{},M5033));
c.Add(new JMethod(5034,"forge/game/card/CardFactoryUtil","lambda$addTriggerAbility$1","([Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/String;",4106,2,3,new JHandler[]{},M5034));
c.Add(new JMethod(5035,"forge/game/card/CardFactoryUtil","lambda$handleHiddenAgenda$0","(Lforge/card/ICardFace;)Z",4106,1,1,new JHandler[]{},M5035));
}

internal static JStep M5006(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5007(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardFactoryUtil$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardFactoryUtil$1")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",8);}
case 8:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","THREE","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","THREE","Lforge/card/mana/ManaCost;"));f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",19);}
case 19:{return rt.Call(f,"forge/game/card/CardFactoryUtil$1","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;)V","invokespecial",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/Spell","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",28);}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("(You may cast this card face down as a 2/2 creature for {3}.)")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/Spell","setDescription","(Ljava/lang/String;)V","invokevirtual",34);}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5007:36:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",41);}
case 41:{return rt.Call(f,"forge/game/spellability/Spell","setStackDescription","(Ljava/lang/String;)V","invokevirtual",44);}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/spellability/Spell","setCastFaceDown","(Z)V","invokevirtual",49);}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/Spell","setIntrinsic","(Z)V","invokevirtual",54);}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5008(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/mana/ManaCost","getShortString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",11);}
case 11:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5008:11:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",16);}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",22);}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5009(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int!=0?24:16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String(" \u2014 ")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",38);}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("ST$ SetState | Cost$ 0 | PrecostDesc$ ")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",47);}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",51);}
case 51:{f.Push(JValue.R(rt.String(" | CostDesc$ ")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",56);}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/CharSequence;)Ljava/lang/StringBuilder;","invokevirtual",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String(" | ")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",69);}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",73);}
case 73:{f.Push(JValue.R(rt.String("$ True | Secondary$ True | IsPresent$ Card.Self+faceDown | Mode$ TurnFaceUp | SpellDescription$ (Turn this face up any time for its ")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",78);}
case 78:{f.Push(f.Locals[4]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",83);}
case 83:{f.Push(JValue.R(rt.String(" cost.)")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",88);}
case 88:{f.StackOp("pop");f.Pc=89;continue;}
case 89:{f.Push(f.Locals[6]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",94);}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",98);}
case 98:{f.Locals[7]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/cost/Cost","hasXInAnyCostPart","()Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int==0?129:107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("X")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/card/CardState","hasSVar","(Ljava/lang/String;)Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int==0?129:116;continue;}
case 116:{f.Push(f.Locals[7]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("X")));f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("X")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/card/CardState","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",126);}
case 126:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",129);}
case 129:{f.Push(f.Locals[7]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPayCosts","(Lforge/game/cost/Cost;)V","invokevirtual",135);}
case 135:{f.Push(f.Locals[7]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/spellability/SpellAbility","rebuiltDescription","()V","invokevirtual",140);}
case 140:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=143;continue;}
case 143:{f.StackOp("dup");f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",147);}
case 147:{f.Locals[8]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[8]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[0]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",155);}
case 155:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",158);}
case 158:{f.Push(JValue.R(rt.String(" - turn this card face up.")));f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",163);}
case 163:{f.StackOp("pop");f.Pc=164;continue;}
case 164:{f.Push(f.Locals[7]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[8]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",171);}
case 171:{return rt.Call(f,"forge/game/spellability/SpellAbility","setStackDescription","(Ljava/lang/String;)V","invokevirtual",174);}
case 174:{f.Push(f.Locals[7]);f.Pc=176;continue;}
case 176:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5010(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbility$EmptySa"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbility$EmptySa")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/card/Card;)V","invokespecial",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("AILogic")));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("AgendaLogic")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5010:22:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",27);}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",33);}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("Card")));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",42);}
case 42:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5010:42:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",47);}
case 47:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardName","(Lforge/game/spellability/SpellAbility;Ljava/util/function/Predicate;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",50);}
case 50:{f.Locals[5]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{f.Pc=f.Pop().Reference==null?65:57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int==0?67:65;continue;}
case 65:{f.Push(JValue.I(0));f.Pc=66;continue;}
case 66:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/card/Card","addNamedCard","(Ljava/lang/String;)V","invokevirtual",73);}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getKeyword","()Lforge/game/keyword/Keyword;","invokeinterface",79);}
case 79:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","DOUBLE_AGENDA","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","DOUBLE_AGENDA","Lforge/game/keyword/Keyword;"));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/keyword/Keyword","equals","(Ljava/lang/Object;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?132:88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",92);}
case 92:{f.Push(f.Locals[3]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("Card.!NamedCard")));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",101);}
case 101:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5010:101:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",106);}
case 106:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardName","(Lforge/game/spellability/SpellAbility;Ljava/util/function/Predicate;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",109);}
case 109:{f.Locals[6]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[6]);f.Pc=113;continue;}
case 113:{f.Pc=f.Pop().Reference==null?124:116;continue;}
case 116:{f.Push(f.Locals[6]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int==0?126:124;continue;}
case 124:{f.Push(JValue.I(0));f.Pc=125;continue;}
case 125:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 126:{f.Push(f.Locals[1]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[6]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/card/Card","addNamedCard","(Ljava/lang/String;)V","invokevirtual",132);}
case 132:{f.Push(f.Locals[1]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/card/Card","turnFaceDown","()Z","invokevirtual",136);}
case 136:{f.StackOp("pop");f.Pc=137;continue;}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",142);}
case 142:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",145);}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",149);}
case 149:{return rt.Call(f,"forge/game/card/Card","addMayLookAt","(JLjava/lang/Iterable;)V","invokevirtual",152);}
case 152:{f.Push(f.Locals[2]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/card/CardFactoryUtil","abilityRevealHiddenAgenda","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",157);}
case 157:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",162);}
case 162:{f.Push(JValue.I(1));f.Pc=163;continue;}
case 163:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5011(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("ST$ SetState | Cost$ 0 | PresentDefined$ Self | IsPresent$ Card.faceDown+inZoneCommand | ActivationZone$ Command | Secondary$ True | Mode$ TurnFaceUp | SpellDescription$ Reveal this Hidden Agenda at any time.")));f.Pc=2;continue;}
case 2:{f.Locals[1]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5012(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("/")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[1]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?19:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=16;continue;}
case 16:{f.Pc=20;continue;}
case 19:{f.Push(JValue.R(null));f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5013(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Integer;",f.Pop().Int)));f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",15);}
case 15:{return rt.Call(f,"java/util/Arrays","fill","([Ljava/lang/Object;Ljava/lang/Object;)V","invokestatic",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",24);}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",31);}
case 31:{f.Pc=f.Pop().Int==0?113:34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[4]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",50);}
case 50:{f.Locals[5]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{f.Locals[6]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[6]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?110:61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[6]);f.Pc=68;continue;}
case 68:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?104:75;continue;}
case 75:{f.Push(f.Locals[6]);f.Pc=77;continue;}
case 77:{f.Locals[7]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[7]);f.Pc=82;continue;}
case 82:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=83;continue;}
case 83:{f.Locals[8]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[7]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",95);}
case 95:{f.Push(JValue.I(1));f.Pc=96;continue;}
case 96:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",100);}
case 100:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[8]);f.Pc=103;continue;}
case 103:{f.StackOp("pop");f.Pc=104;continue;}
case 104:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=107;continue;}
case 107:{f.Pc=55;continue;}
case 110:{f.Pc=25;continue;}
case 113:{f.Push(JValue.I(0));f.Pc=114;continue;}
case 114:{f.Locals[3]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(JValue.I(-1));f.Pc=116;continue;}
case 116:{f.Locals[4]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(JValue.I(0));f.Pc=119;continue;}
case 119:{f.Locals[5]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[5]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?186:127;continue;}
case 127:{f.Push(f.Locals[2]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[5]);f.Pc=130;continue;}
case 130:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",134);}
case 134:{f.Push(f.Locals[4]);f.Pc=136;continue;}
case 136:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?149:139;continue;}
case 139:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=142;continue;}
case 142:{f.Push(f.Locals[5]);f.Pc=144;continue;}
case 144:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=145;continue;}
case 145:{f.Locals[3]=f.Pop();f.Pc=146;continue;}
case 146:{f.Pc=171;continue;}
case 149:{f.Push(f.Locals[2]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[5]);f.Pc=152;continue;}
case 152:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",156);}
case 156:{f.Push(f.Locals[4]);f.Pc=158;continue;}
case 158:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?180:161;continue;}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=165;continue;}
case 165:{f.Push(f.Locals[5]);f.Pc=167;continue;}
case 167:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=168;continue;}
case 168:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=169;continue;}
case 169:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=170;continue;}
case 170:{f.Locals[3]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[2]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[5]);f.Pc=174;continue;}
case 174:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",178);}
case 178:{f.Locals[4]=f.Pop();f.Pc=180;continue;}
case 180:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=183;continue;}
case 183:{f.Pc=121;continue;}
case 186:{f.Push(f.Locals[3]);f.Pc=187;continue;}
case 187:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5014(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=8;continue;}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?81:23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[4]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",39);}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{f.Locals[6]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[6]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?78:50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[6]);f.Pc=57;continue;}
case 57:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int==0?72:64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[6]);f.Pc=67;continue;}
case 67:{f.StackOp("dup2");f.Pc=68;continue;}
case 68:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=69;continue;}
case 69:{f.Push(JValue.I(1));f.Pc=70;continue;}
case 70:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=71;continue;}
case 71:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=72;continue;}
case 72:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=75;continue;}
case 75:{f.Pc=44;continue;}
case 78:{f.Pc=14;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Arrays","sort","([I)V","invokestatic",85);}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5015(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",10);}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?49:20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",37);}
case 37:{return rt.Call(f,"java/lang/Byte","valueOf","(B)Ljava/lang/Byte;","invokestatic",40);}
case 40:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",45);}
case 45:{f.StackOp("pop");f.Pc=46;continue;}
case 46:{f.Pc=11;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",55);}
case 55:{f.Locals[3]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=59;continue;}
case 59:{f.Locals[4]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",67);}
case 67:{f.Locals[5]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",76);}
case 76:{f.Pc=f.Pop().Int==0?147:79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",86);}
case 86:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=89;continue;}
case 89:{f.Locals[6]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[6]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",96);}
case 96:{f.Locals[7]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{f.Locals[8]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[8]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?144:107;continue;}
case 107:{f.Push(f.Locals[7]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[8]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",117);}
case 117:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Byte"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/Byte","byteValue","()B","invokevirtual",123);}
case 123:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int==0?138:129;continue;}
case 129:{f.Push(f.Locals[4]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[8]);f.Pc=133;continue;}
case 133:{f.StackOp("dup2");f.Pc=134;continue;}
case 134:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=135;continue;}
case 135:{f.Push(JValue.I(1));f.Pc=136;continue;}
case 136:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=137;continue;}
case 137:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=138;continue;}
case 138:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=141;continue;}
case 141:{f.Pc=101;continue;}
case 144:{f.Pc=69;continue;}
case 147:{f.Push(JValue.I(0));f.Pc=148;continue;}
case 148:{f.Locals[5]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(JValue.I(-1));f.Pc=151;continue;}
case 151:{f.Locals[6]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(JValue.I(0));f.Pc=154;continue;}
case 154:{f.Locals[7]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[7]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[3]);f.Pc=159;continue;}
case 159:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?234:162;continue;}
case 162:{f.Push(f.Locals[4]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[7]);f.Pc=166;continue;}
case 166:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=167;continue;}
case 167:{f.Push(f.Locals[6]);f.Pc=169;continue;}
case 169:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?191:172;continue;}
case 172:{f.Push(f.Locals[2]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[7]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",180);}
case 180:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Byte"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/lang/Byte","byteValue","()B","invokevirtual",186);}
case 186:{f.Locals[5]=f.Pop();f.Pc=188;continue;}
case 188:{f.Pc=221;continue;}
case 191:{f.Push(f.Locals[4]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[7]);f.Pc=195;continue;}
case 195:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=196;continue;}
case 196:{f.Push(f.Locals[6]);f.Pc=198;continue;}
case 198:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?228:201;continue;}
case 201:{f.Push(f.Locals[5]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[2]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[7]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",211);}
case 211:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Byte"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/lang/Byte","byteValue","()B","invokevirtual",217);}
case 217:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=218;continue;}
case 218:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=219;continue;}
case 219:{f.Locals[5]=f.Pop();f.Pc=221;continue;}
case 221:{f.Push(f.Locals[4]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[7]);f.Pc=225;continue;}
case 225:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=226;continue;}
case 226:{f.Locals[6]=f.Pop();f.Pc=228;continue;}
case 228:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=231;continue;}
case 231:{f.Pc=156;continue;}
case 234:{f.Push(f.Locals[5]);f.Pc=236;continue;}
case 236:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5016(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?136:29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",45);}
case 45:{f.Locals[5]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/card/CardTypeView","hasAllCreatureTypes","()Z","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Int==0?76:57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/card/CardTypeView","getExcludedCreatureSubTypes","()Ljava/lang/Iterable;","invokeinterface",64);}
case 64:{return rt.Call(f,"com/google/common/collect/Iterables","isEmpty","(Ljava/lang/Iterable;)Z","invokestatic",67);}
case 67:{f.Pc=f.Pop().Int==0?76:70;continue;}
case 70:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=73;continue;}
case 73:{f.Pc=20;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/card/CardTypeView","getCreatureTypes","()Ljava/util/Set;","invokeinterface",83);}
case 83:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",88);}
case 88:{f.Locals[6]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",97);}
case 97:{f.Pc=f.Pop().Int==0?133:100;continue;}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",107);}
case 107:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=110;continue;}
case 110:{f.Locals[7]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[7]);f.Pc=115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",119);}
case 119:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5016:119:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BiFunction;",124);}
case 124:{return rt.Call(f,"java/util/Map","merge","(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;","invokeinterface",129);}
case 129:{f.StackOp("pop");f.Pc=130;continue;}
case 130:{f.Pc=90;continue;}
case 133:{f.Pc=20;continue;}
case 136:{f.Push(JValue.I(0));f.Pc=137;continue;}
case 137:{f.Locals[3]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[2]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",144);}
case 144:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",149);}
case 149:{f.Locals[4]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[4]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",158);}
case 158:{f.Pc=f.Pop().Int==0?207:161;continue;}
case 161:{f.Push(f.Locals[4]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",168);}
case 168:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=171;continue;}
case 171:{f.Locals[5]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[3]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[5]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",181);}
case 181:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",187);}
case 187:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?204:190;continue;}
case 190:{f.Push(f.Locals[5]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",197);}
case 197:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",203);}
case 203:{f.Locals[3]=f.Pop();f.Pc=204;continue;}
case 204:{f.Pc=151;continue;}
case 207:{f.Push(f.Locals[3]);f.Pc=208;continue;}
case 208:{f.Push(f.Locals[1]);f.Pc=209;continue;}
case 209:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=210;continue;}
case 210:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5017(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",6);}
case 6:{f.Pc=f.Pop().Int==0?13:9;continue;}
case 9:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",12);}
case 12:{return JStep.Return(f.Pop());}
case 13:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",16);}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?105:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[3]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/card/CardTypeView","getCreatureTypes","()Ljava/util/Set;","invokeinterface",52);}
case 52:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",57);}
case 57:{f.Locals[4]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",66);}
case 66:{f.Pc=f.Pop().Int==0?102:69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",76);}
case 76:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=79;continue;}
case 79:{f.Locals[5]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{f.Push(JValue.I(1));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",88);}
case 88:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5017:88:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BiFunction;",93);}
case 93:{return rt.Call(f,"java/util/Map","merge","(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;","invokeinterface",98);}
case 98:{f.StackOp("pop");f.Pc=99;continue;}
case 99:{f.Pc=59;continue;}
case 102:{f.Pc=24;continue;}
case 105:{f.Push(JValue.I(0));f.Pc=106;continue;}
case 106:{f.Locals[2]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",113);}
case 113:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",118);}
case 118:{f.Locals[3]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[3]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",125);}
case 125:{f.Pc=f.Pop().Int==0?173:128;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",134);}
case 134:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=137;continue;}
case 137:{f.Locals[4]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[4]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",147);}
case 147:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",153);}
case 153:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?170:156;continue;}
case 156:{f.Push(f.Locals[4]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",163);}
case 163:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",169);}
case 169:{f.Locals[2]=f.Pop();f.Pc=170;continue;}
case 170:{f.Pc=119;continue;}
case 173:{f.Push(f.Locals[2]);f.Pc=174;continue;}
case 174:{f.Pc=f.Pop().Int!=0?181:177;continue;}
case 177:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",180);}
case 180:{return JStep.Return(f.Pop());}
case 181:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",184);}
case 184:{f.Locals[3]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",191);}
case 191:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",196);}
case 196:{f.Locals[4]=f.Pop();f.Pc=198;continue;}
case 198:{f.Push(f.Locals[4]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",205);}
case 205:{f.Pc=f.Pop().Int==0?257:208;continue;}
case 208:{f.Push(f.Locals[4]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",215);}
case 215:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=218;continue;}
case 218:{f.Locals[5]=f.Pop();f.Pc=220;continue;}
case 220:{f.Push(f.Locals[2]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[5]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",228);}
case 228:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",234);}
case 234:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?254:237;continue;}
case 237:{f.Push(f.Locals[3]);f.Pc=238;continue;}
case 238:{f.Push(f.Locals[5]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",245);}
case 245:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=248;continue;}
case 248:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",253);}
case 253:{f.StackOp("pop");f.Pc=254;continue;}
case 254:{f.Pc=198;continue;}
case 257:{f.Push(f.Locals[3]);f.Pc=258;continue;}
case 258:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5018(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[5]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[4]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int==0?21:11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",19);}
case 19:{f.Locals[5]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[5]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Reference!=null?32:26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",30);}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",37);}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",41);}
case 41:{f.Locals[6]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[6]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",55);}
case 55:{return rt.Call(f,"forge/game/card/CardFactoryUtil","getSharedKeywords","(Ljava/lang/Iterable;Lforge/game/card/CardCollection;)Ljava/util/List;","invokestatic",58);}
case 58:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5019(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",16);}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",21);}
case 21:{f.Locals[6]=f.Pop();f.Pc=23;continue;}
case 23:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",26);}
case 26:{f.Locals[7]=f.Pop();f.Pc=28;continue;}
case 28:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",31);}
case 31:{f.Locals[8]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",37);}
case 37:{f.Locals[9]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[9]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",46);}
case 46:{f.Pc=f.Pop().Int==0?327:49;continue;}
case 49:{f.Push(f.Locals[9]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{f.Locals[10]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[10]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/Card","getKeywords","()Ljava/util/List;","invokevirtual",66);}
case 66:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",71);}
case 71:{f.Locals[11]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[11]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",80);}
case 80:{f.Pc=f.Pop().Int==0?324:83;continue;}
case 83:{f.Push(f.Locals[11]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{f.Locals[12]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[12]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",102);}
case 102:{f.Locals[13]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[12]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getKeyword","()Lforge/game/keyword/Keyword;","invokeinterface",111);}
case 111:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","LANDWALK","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","LANDWALK","Lforge/game/keyword/Keyword;"));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/keyword/Keyword","equals","(Ljava/lang/Object;)Z","invokevirtual",117);}
case 117:{f.Pc=f.Pop().Int==0?132:120;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[13]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",128);}
case 128:{f.StackOp("pop");f.Pc=129;continue;}
case 129:{f.Pc=321;continue;}
case 132:{f.Push(f.Locals[12]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getKeyword","()Lforge/game/keyword/Keyword;","invokeinterface",139);}
case 139:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","PROTECTION","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","PROTECTION","Lforge/game/keyword/Keyword;"));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/keyword/Keyword","equals","(Ljava/lang/Object;)Z","invokevirtual",145);}
case 145:{f.Pc=f.Pop().Int==0?250:148;continue;}
case 148:{f.Push(f.Locals[4]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[13]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",157);}
case 157:{f.StackOp("pop");f.Pc=158;continue;}
case 158:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=161;continue;}
case 161:{f.Locals[14]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[14]);f.Pc=165;continue;}
case 165:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=166;continue;}
case 166:{f.Locals[15]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(JValue.I(0));f.Pc=169;continue;}
case 169:{f.Locals[16]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[16]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[15]);f.Pc=175;continue;}
case 175:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?247:178;continue;}
case 178:{f.Push(f.Locals[14]);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[16]);f.Pc=182;continue;}
case 182:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=183;continue;}
case 183:{f.Locals[17]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[17]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/card/MagicColor","toLongString","(B)Ljava/lang/String;","invokestatic",190);}
case 190:{f.Locals[18]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[18]);f.Pc=194;continue;}
case 194:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5019:194:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",199);}
case 199:{f.Locals[19]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[13]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[19]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",208);}
case 208:{f.Pc=f.Pop().Int!=0?231:211;continue;}
case 211:{f.Push(f.Locals[13]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[18]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",218);}
case 218:{f.Push(f.Locals[18]);f.Pc=220;continue;}
case 220:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5019:220:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",225);}
case 225:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",228);}
case 228:{f.Pc=f.Pop().Int==0?241:231;continue;}
case 231:{f.Push(f.Locals[5]);f.Pc=233;continue;}
case 233:{f.Push(f.Locals[19]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",240);}
case 240:{f.StackOp("pop");f.Pc=241;continue;}
case 241:{f.Locals[16]=JValue.I(unchecked(f.Locals[16].Int+(1)));f.Pc=244;continue;}
case 244:{f.Pc=171;continue;}
case 247:{f.Pc=321;continue;}
case 250:{f.Push(f.Locals[12]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getKeyword","()Lforge/game/keyword/Keyword;","invokeinterface",257);}
case 257:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","HEXPROOF","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","HEXPROOF","Lforge/game/keyword/Keyword;"));f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/keyword/Keyword","equals","(Ljava/lang/Object;)Z","invokevirtual",263);}
case 263:{f.Pc=f.Pop().Int==0?279:266;continue;}
case 266:{f.Push(f.Locals[6]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[13]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",275);}
case 275:{f.StackOp("pop");f.Pc=276;continue;}
case 276:{f.Pc=321;continue;}
case 279:{f.Push(f.Locals[12]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getKeyword","()Lforge/game/keyword/Keyword;","invokeinterface",286);}
case 286:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","TRAMPLE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","TRAMPLE","Lforge/game/keyword/Keyword;"));f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/game/keyword/Keyword","equals","(Ljava/lang/Object;)Z","invokevirtual",292);}
case 292:{f.Pc=f.Pop().Int==0?308:295;continue;}
case 295:{f.Push(f.Locals[7]);f.Pc=297;continue;}
case 297:{f.Push(f.Locals[13]);f.Pc=299;continue;}
case 299:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",304);}
case 304:{f.StackOp("pop");f.Pc=305;continue;}
case 305:{f.Pc=321;continue;}
case 308:{f.Push(f.Locals[8]);f.Pc=310;continue;}
case 310:{f.Push(f.Locals[13]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",315);}
case 315:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",320);}
case 320:{f.StackOp("pop");f.Pc=321;continue;}
case 321:{f.Pc=73;continue;}
case 324:{f.Pc=39;continue;}
case 327:{f.Push(f.Locals[0]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",333);}
case 333:{f.Locals[9]=f.Pop();f.Pc=335;continue;}
case 335:{f.Push(f.Locals[9]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",342);}
case 342:{f.Pc=f.Pop().Int==0?498:345;continue;}
case 345:{f.Push(f.Locals[9]);f.Pc=347;continue;}
case 347:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",352);}
case 352:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=355;continue;}
case 355:{f.Locals[10]=f.Pop();f.Pc=357;continue;}
case 357:{f.Push(f.Locals[10]);f.Pc=359;continue;}
case 359:{f.Push(JValue.R(rt.String("Protection")));f.Pc=362;continue;}
case 362:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",365);}
case 365:{f.Pc=f.Pop().Int==0?380:368;continue;}
case 368:{f.Push(f.Locals[2]);f.Pc=369;continue;}
case 369:{f.Push(f.Locals[4]);f.Pc=371;continue;}
case 371:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",376);}
case 376:{f.StackOp("pop");f.Pc=377;continue;}
case 377:{f.Pc=495;continue;}
case 380:{f.Push(f.Locals[10]);f.Pc=382;continue;}
case 382:{f.Push(JValue.R(rt.String("ProtectionColor")));f.Pc=385;continue;}
case 385:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",388);}
case 388:{f.Pc=f.Pop().Int==0?403:391;continue;}
case 391:{f.Push(f.Locals[2]);f.Pc=392;continue;}
case 392:{f.Push(f.Locals[5]);f.Pc=394;continue;}
case 394:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",399);}
case 399:{f.StackOp("pop");f.Pc=400;continue;}
case 400:{f.Pc=495;continue;}
case 403:{f.Push(f.Locals[10]);f.Pc=405;continue;}
case 405:{f.Push(JValue.R(rt.String("Landwalk")));f.Pc=408;continue;}
case 408:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",411);}
case 411:{f.Pc=f.Pop().Int==0?425:414;continue;}
case 414:{f.Push(f.Locals[2]);f.Pc=415;continue;}
case 415:{f.Push(f.Locals[3]);f.Pc=416;continue;}
case 416:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",421);}
case 421:{f.StackOp("pop");f.Pc=422;continue;}
case 422:{f.Pc=495;continue;}
case 425:{f.Push(f.Locals[10]);f.Pc=427;continue;}
case 427:{f.Push(JValue.R(rt.String("Hexproof")));f.Pc=430;continue;}
case 430:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",433);}
case 433:{f.Pc=f.Pop().Int==0?448:436;continue;}
case 436:{f.Push(f.Locals[2]);f.Pc=437;continue;}
case 437:{f.Push(f.Locals[6]);f.Pc=439;continue;}
case 439:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",444);}
case 444:{f.StackOp("pop");f.Pc=445;continue;}
case 445:{f.Pc=495;continue;}
case 448:{f.Push(f.Locals[10]);f.Pc=450;continue;}
case 450:{f.Push(JValue.R(rt.String("Trample")));f.Pc=453;continue;}
case 453:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",456);}
case 456:{f.Pc=f.Pop().Int==0?471:459;continue;}
case 459:{f.Push(f.Locals[2]);f.Pc=460;continue;}
case 460:{f.Push(f.Locals[7]);f.Pc=462;continue;}
case 462:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",467);}
case 467:{f.StackOp("pop");f.Pc=468;continue;}
case 468:{f.Pc=495;continue;}
case 471:{f.Push(f.Locals[8]);f.Pc=473;continue;}
case 473:{f.Push(f.Locals[10]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",478);}
case 478:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",483);}
case 483:{f.Pc=f.Pop().Int==0?495:486;continue;}
case 486:{f.Push(f.Locals[2]);f.Pc=487;continue;}
case 487:{f.Push(f.Locals[10]);f.Pc=489;continue;}
case 489:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",494);}
case 494:{f.StackOp("pop");f.Pc=495;continue;}
case 495:{f.Pc=335;continue;}
case 498:{f.Push(f.Locals[2]);f.Pc=499;continue;}
case 499:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5020(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?144:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",39);}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",45);}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",54);}
case 54:{f.Pc=141;continue;}
case 57:{f.Locals[4]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("CardFactoryUtil:addAbilityFactoryAbilities: crash in raw Ability")));f.Pc=62;continue;}
case 62:{f.Locals[5]=f.Pop();f.Pc=64;continue;}
case 64:{if(!rt.EnsureInitialized(f,"io/sentry/Breadcrumb"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("io/sentry/Breadcrumb")));f.Pc=67;continue;}
case 67:{f.StackOp("dup");f.Pc=68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"io/sentry/Breadcrumb","<init>","(Ljava/lang/String;)V","invokespecial",73);}
case 73:{f.Locals[6]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[6]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("Card")));f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",83);}
case 83:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",86);}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("Ability")));f.Pc=91;continue;}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",95);}
case 95:{f.Push(f.Locals[6]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"io/sentry/Sentry","addBreadcrumb","(Lio/sentry/Breadcrumb;)V","invokestatic",100);}
case 100:{if(!rt.EnsureInitialized(f,"forge/game/ability/IllegalAbilityException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/IllegalAbilityException")));f.Pc=103;continue;}
case 103:{f.StackOp("dup");f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",108);}
case 108:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5020:108:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",113);}
case 113:{f.Push(f.Locals[4]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",119);}
case 119:{f.Pc=f.Pop().Reference==null?136:122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",126);}
case 126:{return rt.Call(f,"forge/card/CardRules","isCustom","()Z","invokevirtual",129);}
case 129:{f.Pc=f.Pop().Int==0?136:132;continue;}
case 132:{f.Push(JValue.I(1));f.Pc=133;continue;}
case 133:{f.Pc=137;continue;}
case 136:{f.Push(JValue.I(0));f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/ability/IllegalAbilityException","<init>","(Ljava/lang/String;Ljava/lang/Throwable;Z)V","invokespecial",140);}
case 140:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 141:{f.Pc=7;continue;}
case 144:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5021(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getKeywords","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?40:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/keyword/KeywordInterface","createTraits","(Lforge/game/card/Card;Z)V","invokeinterface",37);}
case 37:{f.Pc=10;continue;}
case 40:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5022(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",5);}
case 5:{f.Locals[8]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[8]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[5]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[6]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[7]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardFactoryUtil","createETBReplacement","(Lforge/game/card/CardState;Lforge/game/replacement/ReplacementLayer;Lforge/game/spellability/SpellAbility;ZZZLjava/lang/String;Ljava/lang/String;)Lforge/game/replacement/ReplacementEffect;","invokestatic",23);}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5023(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[8]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[9]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[5]);f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Int!=0?22:17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",22);}
case 22:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",29);}
case 29:{f.Locals[10]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[10]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("Event$ Moved | ValidCard$ ")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",39);}
case 39:{f.Push(f.Locals[6]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",44);}
case 44:{f.StackOp("pop");f.Pc=45;continue;}
case 45:{f.Push(f.Locals[10]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String(" | Destination$ Battlefield | ReplacementResult$ Updated | Description$ ")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",53);}
case 53:{f.Push(f.Locals[9]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",58);}
case 58:{f.StackOp("pop");f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{f.Pc=f.Pop().Int==0?72:63;continue;}
case 63:{f.Push(f.Locals[10]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String(" | Optional$ True")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Push(f.Locals[4]);f.Pc=74;continue;}
case 74:{f.Pc=f.Pop().Int==0?86:77;continue;}
case 77:{f.Push(f.Locals[10]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String(" | Secondary$ True")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",85);}
case 85:{f.StackOp("pop");f.Pc=86;continue;}
case 86:{f.Push(f.Locals[7]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int!=0?108:94;continue;}
case 94:{f.Push(f.Locals[10]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String(" | ActiveZones$ ")));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",102);}
case 102:{f.Push(f.Locals[7]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",107);}
case 107:{f.StackOp("pop");f.Pc=108;continue;}
case 108:{f.Push(f.Locals[10]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",113);}
case 113:{f.Push(f.Locals[8]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[5]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",121);}
case 121:{f.Locals[11]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[11]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setLayer","(Lforge/game/replacement/ReplacementLayer;)V","invokevirtual",129);}
case 129:{f.Push(f.Locals[11]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",135);}
case 135:{f.Push(f.Locals[11]);f.Pc=137;continue;}
case 137:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5024(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String(":")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("CARDNAME enters with ")));f.Pc=14;continue;}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(2));f.Pc=21;continue;}
case 21:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",29);}
case 29:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",34);}
case 34:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",37);}
case 37:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5024:37:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",42);}
case 42:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",45);}
case 45:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5024:45:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",50);}
case 50:{f.Locals[5]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5024:54:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",59);}
case 59:{f.Locals[5]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("")));f.Pc=64;continue;}
case 64:{f.Locals[6]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{f.Push(JValue.I(2));f.Pc=69;continue;}
case 69:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=70;continue;}
case 70:{f.Locals[7]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[4]);f.Pc=74;continue;}
case 74:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=75;continue;}
case 75:{f.Push(JValue.I(3));f.Pc=76;continue;}
case 76:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?98:79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{f.Push(JValue.I(3));f.Pc=82;continue;}
case 82:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("no Condition")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int!=0?98:92;continue;}
case 92:{f.Push(f.Locals[4]);f.Pc=94;continue;}
case 94:{f.Push(JValue.I(3));f.Pc=95;continue;}
case 95:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=96;continue;}
case 96:{f.Locals[6]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=101;continue;}
case 101:{f.Push(JValue.I(4));f.Pc=102;continue;}
case 102:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?130:105;continue;}
case 105:{f.Push(f.Locals[4]);f.Pc=107;continue;}
case 107:{f.Push(JValue.I(4));f.Pc=108;continue;}
case 108:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("no desc")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",115);}
case 115:{f.Pc=f.Pop().Int!=0?125:118;continue;}
case 118:{f.Push(f.Locals[4]);f.Pc=120;continue;}
case 120:{f.Push(JValue.I(4));f.Pc=121;continue;}
case 121:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=122;continue;}
case 122:{f.Pc=128;continue;}
case 125:{f.Push(JValue.R(rt.String("")));f.Pc=128;continue;}
case 128:{f.Locals[5]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[4]);f.Pc=132;continue;}
case 132:{f.Push(JValue.I(1));f.Pc=133;continue;}
case 133:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=134;continue;}
case 134:{f.Push(f.Locals[7]);f.Pc=136;continue;}
case 136:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5024:136:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",141);}
case 141:{f.Locals[8]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(f.Locals[4]);f.Pc=145;continue;}
case 145:{f.Push(JValue.I(1));f.Pc=146;continue;}
case 146:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=147;continue;}
case 147:{f.Push(JValue.R(rt.String("EACH")));f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int==0?169:156;continue;}
case 156:{f.Push(f.Locals[8]);f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("CounterType$ EACH ")));f.Pc=161;continue;}
case 161:{f.Push(JValue.R(rt.String("CounterTypes$ ")));f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",167);}
case 167:{f.Locals[8]=f.Pop();f.Pc=169;continue;}
case 169:{f.Push(f.Locals[8]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[1]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",175);}
case 175:{f.Locals[9]=f.Pop();f.Pc=177;continue;}
case 177:{f.Push(f.Locals[2]);f.Pc=178;continue;}
case 178:{f.Pc=f.Pop().Int!=0?187:181;continue;}
case 181:{f.Push(f.Locals[9]);f.Pc=183;continue;}
case 183:{f.Push(JValue.I(0));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",187);}
case 187:{f.Push(f.Locals[5]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[6]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",194);}
case 194:{f.Pc=f.Pop().Int!=0?207:197;continue;}
case 197:{f.Push(f.Locals[6]);f.Pc=199;continue;}
case 199:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5024:199:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",204);}
case 204:{f.Pc=210;continue;}
case 207:{f.Push(JValue.R(rt.String("")));f.Pc=210;continue;}
case 210:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5024:210:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",215);}
case 215:{f.Locals[10]=f.Pop();f.Pc=217;continue;}
case 217:{f.Push(f.Locals[10]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[1]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",223);}
case 223:{f.Push(f.Locals[2]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[1]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",228);}
case 228:{f.Locals[11]=f.Pop();f.Pc=230;continue;}
case 230:{f.Push(f.Locals[11]);f.Pc=232;continue;}
case 232:{f.Push(f.Locals[9]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",237);}
case 237:{f.Push(f.Locals[11]);f.Pc=239;continue;}
case 239:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5025(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("Afflict")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?88:17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String(":")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Locals[5]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=30;continue;}
case 30:{f.Locals[6]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[6]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",40);}
case 40:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:40:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",45);}
case 45:{f.Locals[7]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[6]);f.Pc=49;continue;}
case 49:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:49:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",54);}
case 54:{f.Locals[8]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[7]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(null));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/trigger/Trigger;","invokestatic",64);}
case 64:{f.Locals[9]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[9]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[8]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",74);}
case 74:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",77);}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[9]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",85);}
case 85:{f.Pc=9090;continue;}
case 88:{f.Push(f.Locals[3]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("Afterlife")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int==0?218:98;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String(":")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",105);}
case 105:{f.Locals[5]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[5]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String(" ")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","([Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;","invokestatic",115);}
case 115:{f.Locals[6]=f.Pop();f.Pc=117;continue;}
case 117:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=120;continue;}
case 120:{f.StackOp("dup");f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",124);}
case 124:{f.Locals[7]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[7]);f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Origin$ Battlefield | Destination$ Graveyard | ValidCard$ Card.Self ")));f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",134);}
case 134:{f.StackOp("pop");f.Pc=135;continue;}
case 135:{f.Push(f.Locals[7]);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String("| Secondary$ True | TriggerDescription$ ")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",143);}
case 143:{f.Push(f.Locals[6]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",148);}
case 148:{f.StackOp("pop");f.Pc=149;continue;}
case 149:{f.Push(f.Locals[7]);f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String(" (")));f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",157);}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",163);}
case 163:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",166);}
case 166:{f.Push(JValue.R(rt.String(")")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",172);}
case 172:{f.StackOp("pop");f.Pc=173;continue;}
case 173:{f.Push(f.Locals[5]);f.Pc=175;continue;}
case 175:{f.Push(JValue.I(1));f.Pc=176;continue;}
case 176:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=177;continue;}
case 177:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:177:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",182);}
case 182:{f.Locals[8]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(f.Locals[7]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",189);}
case 189:{f.Push(f.Locals[1]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[2]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",194);}
case 194:{f.Locals[9]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[9]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[8]);f.Pc=200;continue;}
case 200:{f.Push(f.Locals[1]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",204);}
case 204:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",207);}
case 207:{f.Push(f.Locals[0]);f.Pc=208;continue;}
case 208:{f.Push(f.Locals[9]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",215);}
case 215:{f.Pc=9090;continue;}
case 218:{f.Push(f.Locals[3]);f.Pc=219;continue;}
case 219:{f.Push(JValue.R(rt.String("Annihilator")));f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",225);}
case 225:{f.Pc=f.Pop().Int==0?300:228;continue;}
case 228:{f.Push(f.Locals[3]);f.Pc=229;continue;}
case 229:{f.Push(JValue.R(rt.String(":")));f.Pc=232;continue;}
case 232:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",235);}
case 235:{f.Locals[5]=f.Pop();f.Pc=237;continue;}
case 237:{f.Push(f.Locals[5]);f.Pc=239;continue;}
case 239:{f.Push(JValue.I(1));f.Pc=240;continue;}
case 240:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=241;continue;}
case 241:{f.Locals[6]=f.Pop();f.Pc=243;continue;}
case 243:{f.Push(f.Locals[6]);f.Pc=245;continue;}
case 245:{f.Push(f.Locals[0]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",251);}
case 251:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:251:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",256);}
case 256:{f.Locals[7]=f.Pop();f.Pc=258;continue;}
case 258:{f.Push(f.Locals[5]);f.Pc=260;continue;}
case 260:{f.Push(JValue.I(1));f.Pc=261;continue;}
case 261:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=262;continue;}
case 262:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:262:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",267);}
case 267:{f.Locals[8]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(f.Locals[7]);f.Pc=271;continue;}
case 271:{f.Push(f.Locals[1]);f.Pc=272;continue;}
case 272:{f.Push(f.Locals[2]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",276);}
case 276:{f.Locals[9]=f.Pop();f.Pc=278;continue;}
case 278:{f.Push(f.Locals[9]);f.Pc=280;continue;}
case 280:{f.Push(f.Locals[8]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[1]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",286);}
case 286:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",289);}
case 289:{f.Push(f.Locals[0]);f.Pc=290;continue;}
case 290:{f.Push(f.Locals[9]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",297);}
case 297:{f.Pc=9090;continue;}
case 300:{f.Push(f.Locals[3]);f.Pc=301;continue;}
case 301:{f.Push(JValue.R(rt.String("Ascend")));f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",307);}
case 307:{f.Pc=f.Pop().Int==0?403:310;continue;}
case 310:{f.Push(f.Locals[1]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/card/Card","isPermanent","()Z","invokevirtual",314);}
case 314:{f.Pc=f.Pop().Int!=0?324:317;continue;}
case 317:{f.Push(f.Locals[1]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/card/Card","isPlane","()Z","invokevirtual",321);}
case 321:{f.Pc=f.Pop().Int==0?9090:324;continue;}
case 324:{f.Push(f.Locals[1]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/game/card/Card","isPlane","()Z","invokevirtual",328);}
case 328:{f.Pc=f.Pop().Int==0?337:331;continue;}
case 331:{f.Push(JValue.R(rt.String("Command")));f.Pc=334;continue;}
case 334:{f.Pc=340;continue;}
case 337:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=340;continue;}
case 340:{f.Push(f.Locals[0]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",346);}
case 346:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:346:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",351);}
case 351:{f.Locals[5]=f.Pop();f.Pc=353;continue;}
case 353:{f.Push(f.Locals[5]);f.Pc=355;continue;}
case 355:{f.Push(f.Locals[1]);f.Pc=356;continue;}
case 356:{f.Push(f.Locals[2]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",360);}
case 360:{f.Locals[6]=f.Pop();f.Pc=362;continue;}
case 362:{if(!rt.EnsureInitialized(f,"forge/game/card/CardFactoryUtil$2"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardFactoryUtil$2")));f.Pc=365;continue;}
case 365:{f.StackOp("dup");f.Pc=366;continue;}
case 366:{f.Push(f.Locals[1]);f.Pc=367;continue;}
case 367:{if(!rt.StaticReady(f,"forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"));f.Pc=370;continue;}
case 370:{f.Push(JValue.R(null));f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/card/CardFactoryUtil$2","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;)V","invokespecial",374);}
case 374:{f.Locals[7]=f.Pop();f.Pc=376;continue;}
case 376:{f.Push(f.Locals[7]);f.Pc=378;continue;}
case 378:{f.Push(f.Locals[1]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",382);}
case 382:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",385);}
case 385:{f.Push(f.Locals[6]);f.Pc=387;continue;}
case 387:{f.Push(f.Locals[7]);f.Pc=389;continue;}
case 389:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",392);}
case 392:{f.Push(f.Locals[0]);f.Pc=393;continue;}
case 393:{f.Push(f.Locals[6]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",400);}
case 400:{f.Pc=9090;continue;}
case 403:{f.Push(f.Locals[3]);f.Pc=404;continue;}
case 404:{f.Push(JValue.R(rt.String("Backup")));f.Pc=407;continue;}
case 407:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",410);}
case 410:{f.Pc=f.Pop().Int==0?533:413;continue;}
case 413:{f.Push(f.Locals[3]);f.Pc=414;continue;}
case 414:{f.Push(JValue.R(rt.String(":")));f.Pc=417;continue;}
case 417:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",420);}
case 420:{f.Locals[5]=f.Pop();f.Pc=422;continue;}
case 422:{f.Push(f.Locals[5]);f.Pc=424;continue;}
case 424:{f.Push(JValue.I(1));f.Pc=425;continue;}
case 425:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=426;continue;}
case 426:{f.Locals[6]=f.Pop();f.Pc=428;continue;}
case 428:{f.Push(f.Locals[1]);f.Pc=429;continue;}
case 429:{f.Push(f.Locals[5]);f.Pc=431;continue;}
case 431:{f.Push(JValue.I(2));f.Pc=432;continue;}
case 432:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=433;continue;}
case 433:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",436);}
case 436:{f.Locals[7]=f.Pop();f.Pc=438;continue;}
case 438:{f.Push(f.Locals[6]);f.Pc=440;continue;}
case 440:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:440:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",445);}
case 445:{f.Locals[8]=f.Pop();f.Pc=447;continue;}
case 447:{f.Push(f.Locals[8]);f.Pc=449;continue;}
case 449:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:449:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",454);}
case 454:{f.Locals[9]=f.Pop();f.Pc=456;continue;}
case 456:{f.Push(f.Locals[6]);f.Pc=458;continue;}
case 458:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:458:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",463);}
case 463:{f.Locals[10]=f.Pop();f.Pc=465;continue;}
case 465:{f.Push(f.Locals[7]);f.Pc=467;continue;}
case 467:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:467:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",472);}
case 472:{f.Locals[11]=f.Pop();f.Pc=474;continue;}
case 474:{f.Push(f.Locals[10]);f.Pc=476;continue;}
case 476:{f.Push(f.Locals[1]);f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",480);}
case 480:{f.Locals[12]=f.Pop();f.Pc=482;continue;}
case 482:{f.Push(f.Locals[11]);f.Pc=484;continue;}
case 484:{f.Push(f.Locals[1]);f.Pc=485;continue;}
case 485:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",488);}
case 488:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=491;continue;}
case 491:{f.Locals[13]=f.Pop();f.Pc=493;continue;}
case 493:{f.Push(f.Locals[12]);f.Pc=495;continue;}
case 495:{f.Push(f.Locals[13]);f.Pc=497;continue;}
case 497:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",500);}
case 500:{f.Push(f.Locals[9]);f.Pc=502;continue;}
case 502:{f.Push(f.Locals[1]);f.Pc=503;continue;}
case 503:{f.Push(f.Locals[2]);f.Pc=504;continue;}
case 504:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",507);}
case 507:{f.Locals[14]=f.Pop();f.Pc=509;continue;}
case 509:{f.Push(f.Locals[12]);f.Pc=511;continue;}
case 511:{f.Push(f.Locals[2]);f.Pc=512;continue;}
case 512:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",515);}
case 515:{f.Push(f.Locals[14]);f.Pc=517;continue;}
case 517:{f.Push(f.Locals[12]);f.Pc=519;continue;}
case 519:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",522);}
case 522:{f.Push(f.Locals[0]);f.Pc=523;continue;}
case 523:{f.Push(f.Locals[14]);f.Pc=525;continue;}
case 525:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",530);}
case 530:{f.Pc=9090;continue;}
case 533:{f.Push(f.Locals[3]);f.Pc=534;continue;}
case 534:{f.Push(JValue.R(rt.String("Battle cry")));f.Pc=537;continue;}
case 537:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",540);}
case 540:{f.Pc=f.Pop().Int==0?603:543;continue;}
case 543:{f.Push(f.Locals[3]);f.Pc=544;continue;}
case 544:{f.Push(f.Locals[0]);f.Pc=545;continue;}
case 545:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",550);}
case 550:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:550:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",555);}
case 555:{f.Locals[5]=f.Pop();f.Pc=557;continue;}
case 557:{f.Push(JValue.R(rt.String("DB$ PumpAll | ValidCards$ Creature.attacking+Other | NumAtt$ 1")));f.Pc=560;continue;}
case 560:{f.Locals[6]=f.Pop();f.Pc=562;continue;}
case 562:{f.Push(f.Locals[6]);f.Pc=564;continue;}
case 564:{f.Push(f.Locals[1]);f.Pc=565;continue;}
case 565:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",568);}
case 568:{f.Locals[7]=f.Pop();f.Pc=570;continue;}
case 570:{f.Push(f.Locals[7]);f.Pc=572;continue;}
case 572:{f.Push(f.Locals[2]);f.Pc=573;continue;}
case 573:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",576);}
case 576:{f.Push(f.Locals[5]);f.Pc=578;continue;}
case 578:{f.Push(f.Locals[1]);f.Pc=579;continue;}
case 579:{f.Push(f.Locals[2]);f.Pc=580;continue;}
case 580:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",583);}
case 583:{f.Locals[8]=f.Pop();f.Pc=585;continue;}
case 585:{f.Push(f.Locals[8]);f.Pc=587;continue;}
case 587:{f.Push(f.Locals[7]);f.Pc=589;continue;}
case 589:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",592);}
case 592:{f.Push(f.Locals[0]);f.Pc=593;continue;}
case 593:{f.Push(f.Locals[8]);f.Pc=595;continue;}
case 595:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",600);}
case 600:{f.Pc=9090;continue;}
case 603:{f.Push(f.Locals[3]);f.Pc=604;continue;}
case 604:{f.Push(JValue.R(rt.String("Bushido")));f.Pc=607;continue;}
case 607:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",610);}
case 610:{f.Pc=f.Pop().Int==0?728:613;continue;}
case 613:{f.Push(f.Locals[3]);f.Pc=614;continue;}
case 614:{f.Push(JValue.R(rt.String(":")));f.Pc=617;continue;}
case 617:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",620);}
case 620:{f.Locals[5]=f.Pop();f.Pc=622;continue;}
case 622:{f.Push(f.Locals[5]);f.Pc=624;continue;}
case 624:{f.Push(JValue.I(1));f.Pc=625;continue;}
case 625:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=626;continue;}
case 626:{f.Locals[6]=f.Pop();f.Pc=628;continue;}
case 628:{f.Push(f.Locals[6]);f.Pc=630;continue;}
case 630:{f.Push(f.Locals[0]);f.Pc=631;continue;}
case 631:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",636);}
case 636:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:636:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",641);}
case 641:{f.Locals[7]=f.Pop();f.Pc=643;continue;}
case 643:{f.Push(f.Locals[6]);f.Pc=645;continue;}
case 645:{f.Push(f.Locals[0]);f.Pc=646;continue;}
case 646:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",651);}
case 651:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:651:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",656);}
case 656:{f.Locals[8]=f.Pop();f.Pc=658;continue;}
case 658:{f.Push(f.Locals[6]);f.Pc=660;continue;}
case 660:{f.Push(f.Locals[6]);f.Pc=662;continue;}
case 662:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:662:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",667);}
case 667:{f.Locals[9]=f.Pop();f.Pc=669;continue;}
case 669:{f.Push(f.Locals[9]);f.Pc=671;continue;}
case 671:{f.Push(f.Locals[1]);f.Pc=672;continue;}
case 672:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",675);}
case 675:{f.Locals[10]=f.Pop();f.Pc=677;continue;}
case 677:{f.Push(f.Locals[7]);f.Pc=679;continue;}
case 679:{f.Push(f.Locals[1]);f.Pc=680;continue;}
case 680:{f.Push(f.Locals[2]);f.Pc=681;continue;}
case 681:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",684);}
case 684:{f.Locals[11]=f.Pop();f.Pc=686;continue;}
case 686:{f.Push(f.Locals[8]);f.Pc=688;continue;}
case 688:{f.Push(f.Locals[1]);f.Pc=689;continue;}
case 689:{f.Push(f.Locals[2]);f.Pc=690;continue;}
case 690:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",693);}
case 693:{f.Locals[12]=f.Pop();f.Pc=695;continue;}
case 695:{f.Push(f.Locals[11]);f.Pc=697;continue;}
case 697:{f.Push(f.Locals[10]);f.Pc=699;continue;}
case 699:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",702);}
case 702:{f.Push(f.Locals[12]);f.Pc=704;continue;}
case 704:{f.Push(f.Locals[10]);f.Pc=706;continue;}
case 706:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",709);}
case 709:{f.Push(f.Locals[0]);f.Pc=710;continue;}
case 710:{f.Push(f.Locals[11]);f.Pc=712;continue;}
case 712:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",717);}
case 717:{f.Push(f.Locals[0]);f.Pc=718;continue;}
case 718:{f.Push(f.Locals[12]);f.Pc=720;continue;}
case 720:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",725);}
case 725:{f.Pc=9090;continue;}
case 728:{f.Push(f.Locals[3]);f.Pc=729;continue;}
case 729:{f.Push(JValue.R(rt.String("Cascade")));f.Pc=732;continue;}
case 732:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",735);}
case 735:{f.Pc=f.Pop().Int==0?894:738;continue;}
case 738:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=741;continue;}
case 741:{f.StackOp("dup");f.Pc=742;continue;}
case 742:{f.Push(JValue.R(rt.String("Mode$ SpellCast | ValidCard$ Card.Self | TriggerZones$ Stack | Secondary$ True | TriggerDescription$ Cascade - CARDNAME")));f.Pc=745;continue;}
case 745:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",748);}
case 748:{f.Locals[5]=f.Pop();f.Pc=750;continue;}
case 750:{f.Push(JValue.R(rt.String("DB$ DigUntil | Defined$ You | Amount$ 1 | Valid$ Card.nonLand+cmcLTCascadeX | FoundDestination$ Exile | RevealedDestination$ Exile | ImprintFound$ True | RememberRevealed$ True")));f.Pc=753;continue;}
case 753:{f.Locals[6]=f.Pop();f.Pc=755;continue;}
case 755:{f.Push(JValue.R(rt.String("DB$ DigUntil | Defined$ You | Amount$ 1 | Valid$ Card.nonLand+cmcLTCascadeX | FoundDestination$ Exile | RevealedDestination$ Exile | ImprintFound$ True | RememberRevealed$ True")));f.Pc=758;continue;}
case 758:{f.Push(f.Locals[1]);f.Pc=759;continue;}
case 759:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",762);}
case 762:{f.Locals[7]=f.Pop();f.Pc=764;continue;}
case 764:{f.Push(f.Locals[7]);f.Pc=766;continue;}
case 766:{f.Push(JValue.R(rt.String("CascadeX")));f.Pc=769;continue;}
case 769:{f.Push(JValue.R(rt.String("Count$CardManaCost")));f.Pc=772;continue;}
case 772:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",775);}
case 775:{f.Push(JValue.R(rt.String("DB$ Play | Defined$ Imprinted | WithoutManaCost$ True | Optional$ True | ValidSA$ Spell.cmcLTCascadeX")));f.Pc=778;continue;}
case 778:{f.Locals[8]=f.Pop();f.Pc=780;continue;}
case 780:{f.Push(JValue.R(rt.String("DB$ Play | Defined$ Imprinted | WithoutManaCost$ True | Optional$ True | ValidSA$ Spell.cmcLTCascadeX")));f.Pc=783;continue;}
case 783:{f.Push(f.Locals[1]);f.Pc=784;continue;}
case 784:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",787);}
case 787:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=790;continue;}
case 790:{f.Locals[9]=f.Pop();f.Pc=792;continue;}
case 792:{f.Push(f.Locals[9]);f.Pc=794;continue;}
case 794:{f.Push(JValue.R(rt.String("CascadeX")));f.Pc=797;continue;}
case 797:{f.Push(JValue.R(rt.String("Count$CardManaCost")));f.Pc=800;continue;}
case 800:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",803);}
case 803:{f.Push(f.Locals[7]);f.Pc=805;continue;}
case 805:{f.Push(f.Locals[9]);f.Pc=807;continue;}
case 807:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",810);}
case 810:{f.Push(JValue.R(rt.String("DB$ ChangeZoneAll | ChangeType$ Card.IsRemembered,Card.IsImprinted | Origin$ Exile | Destination$ Library | RandomOrder$ True | LibraryPosition$ -1")));f.Pc=813;continue;}
case 813:{f.Locals[10]=f.Pop();f.Pc=815;continue;}
case 815:{f.Push(JValue.R(rt.String("DB$ ChangeZoneAll | ChangeType$ Card.IsRemembered,Card.IsImprinted | Origin$ Exile | Destination$ Library | RandomOrder$ True | LibraryPosition$ -1")));f.Pc=818;continue;}
case 818:{f.Push(f.Locals[1]);f.Pc=819;continue;}
case 819:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",822);}
case 822:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=825;continue;}
case 825:{f.Locals[11]=f.Pop();f.Pc=827;continue;}
case 827:{f.Push(f.Locals[9]);f.Pc=829;continue;}
case 829:{f.Push(f.Locals[11]);f.Pc=831;continue;}
case 831:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",834);}
case 834:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True | ClearImprinted$ True")));f.Pc=837;continue;}
case 837:{f.Locals[12]=f.Pop();f.Pc=839;continue;}
case 839:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True | ClearImprinted$ True")));f.Pc=842;continue;}
case 842:{f.Push(f.Locals[1]);f.Pc=843;continue;}
case 843:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",846);}
case 846:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=849;continue;}
case 849:{f.Locals[13]=f.Pop();f.Pc=851;continue;}
case 851:{f.Push(f.Locals[11]);f.Pc=853;continue;}
case 853:{f.Push(f.Locals[13]);f.Pc=855;continue;}
case 855:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",858);}
case 858:{f.Push(f.Locals[7]);f.Pc=860;continue;}
case 860:{f.Push(f.Locals[2]);f.Pc=861;continue;}
case 861:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",864);}
case 864:{f.Push(f.Locals[5]);f.Pc=866;continue;}
case 866:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",869);}
case 869:{f.Push(f.Locals[1]);f.Pc=870;continue;}
case 870:{f.Push(f.Locals[2]);f.Pc=871;continue;}
case 871:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",874);}
case 874:{f.Locals[14]=f.Pop();f.Pc=876;continue;}
case 876:{f.Push(f.Locals[14]);f.Pc=878;continue;}
case 878:{f.Push(f.Locals[7]);f.Pc=880;continue;}
case 880:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",883);}
case 883:{f.Push(f.Locals[0]);f.Pc=884;continue;}
case 884:{f.Push(f.Locals[14]);f.Pc=886;continue;}
case 886:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",891);}
case 891:{f.Pc=9090;continue;}
case 894:{f.Push(f.Locals[3]);f.Pc=895;continue;}
case 895:{f.Push(JValue.R(rt.String("Champion")));f.Pc=898;continue;}
case 898:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",901);}
case 901:{f.Pc=f.Pop().Int==0?1332:904;continue;}
case 904:{f.Push(f.Locals[3]);f.Pc=905;continue;}
case 905:{f.Push(JValue.R(rt.String(":")));f.Pc=908;continue;}
case 908:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",911);}
case 911:{f.Locals[5]=f.Pop();f.Pc=913;continue;}
case 913:{f.Push(f.Locals[5]);f.Pc=915;continue;}
case 915:{f.Push(JValue.I(1));f.Pc=916;continue;}
case 916:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=917;continue;}
case 917:{f.Push(JValue.R(rt.String(",")));f.Pc=920;continue;}
case 920:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",923);}
case 923:{f.Locals[6]=f.Pop();f.Pc=925;continue;}
case 925:{f.Push(f.Locals[6]);f.Pc=927;continue;}
case 927:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",930);}
case 930:{f.Push(JValue.R(null));f.Pc=931;continue;}
case 931:{f.Push(JValue.R(rt.String("or")));f.Pc=934;continue;}
case 934:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",937);}
case 937:{f.Locals[7]=f.Pop();f.Pc=939;continue;}
case 939:{f.Push(f.Locals[7]);f.Pc=941;continue;}
case 941:{return rt.Call(f,"forge/util/Lang","startsWithVowel","(Ljava/lang/String;)Z","invokestatic",944);}
case 944:{f.Pc=f.Pop().Int==0?953:947;continue;}
case 947:{f.Push(JValue.R(rt.String("an")));f.Pc=950;continue;}
case 950:{f.Pc=956;continue;}
case 953:{f.Push(JValue.R(rt.String("a")));f.Pc=956;continue;}
case 956:{f.Locals[8]=f.Pop();f.Pc=958;continue;}
case 958:{f.Push(f.Locals[7]);f.Pc=960;continue;}
case 960:{f.Push(JValue.R(rt.String("Creature")));f.Pc=963;continue;}
case 963:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",966);}
case 966:{f.Pc=f.Pop().Int==0?974:969;continue;}
case 969:{f.Push(JValue.R(rt.String("creature")));f.Pc=972;continue;}
case 972:{f.Locals[7]=f.Pop();f.Pc=974;continue;}
case 974:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=977;continue;}
case 977:{f.StackOp("dup");f.Pc=978;continue;}
case 978:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",981);}
case 981:{f.Locals[9]=f.Pop();f.Pc=983;continue;}
case 983:{f.Push(f.Locals[6]);f.Pc=985;continue;}
case 985:{f.Locals[10]=f.Pop();f.Pc=987;continue;}
case 987:{f.Push(f.Locals[10]);f.Pc=989;continue;}
case 989:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=990;continue;}
case 990:{f.Locals[11]=f.Pop();f.Pc=992;continue;}
case 992:{f.Push(JValue.I(0));f.Pc=993;continue;}
case 993:{f.Locals[12]=f.Pop();f.Pc=995;continue;}
case 995:{f.Push(f.Locals[12]);f.Pc=997;continue;}
case 997:{f.Push(f.Locals[11]);f.Pc=999;continue;}
case 999:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1046:1002;continue;}
case 1002:{f.Push(f.Locals[10]);f.Pc=1004;continue;}
case 1004:{f.Push(f.Locals[12]);f.Pc=1006;continue;}
case 1006:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1007;continue;}
case 1007:{f.Locals[13]=f.Pop();f.Pc=1009;continue;}
case 1009:{f.Push(f.Locals[9]);f.Pc=1011;continue;}
case 1011:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",1014);}
case 1014:{f.Pc=f.Pop().Int==0?1026:1017;continue;}
case 1017:{f.Push(f.Locals[9]);f.Pc=1019;continue;}
case 1019:{f.Push(JValue.R(rt.String(",")));f.Pc=1022;continue;}
case 1022:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1025);}
case 1025:{f.StackOp("pop");f.Pc=1026;continue;}
case 1026:{f.Push(f.Locals[9]);f.Pc=1028;continue;}
case 1028:{f.Push(f.Locals[13]);f.Pc=1030;continue;}
case 1030:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1033);}
case 1033:{f.Push(JValue.R(rt.String(".YouCtrl+Other")));f.Pc=1036;continue;}
case 1036:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1039);}
case 1039:{f.StackOp("pop");f.Pc=1040;continue;}
case 1040:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=1043;continue;}
case 1043:{f.Pc=995;continue;}
case 1046:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1049;continue;}
case 1049:{f.StackOp("dup");f.Pc=1050;continue;}
case 1050:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",1053);}
case 1053:{f.Locals[10]=f.Pop();f.Pc=1055;continue;}
case 1055:{f.Push(f.Locals[10]);f.Pc=1057;continue;}
case 1057:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Destination$ Battlefield | ValidCard$ Card.Self")));f.Pc=1060;continue;}
case 1060:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1063);}
case 1063:{f.StackOp("pop");f.Pc=1064;continue;}
case 1064:{f.Push(f.Locals[10]);f.Pc=1066;continue;}
case 1066:{f.Push(JValue.R(rt.String(" | TriggerDescription$ Champion ")));f.Pc=1069;continue;}
case 1069:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1072);}
case 1072:{f.Push(f.Locals[8]);f.Pc=1074;continue;}
case 1074:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1077);}
case 1077:{f.Push(JValue.R(rt.String(" ")));f.Pc=1080;continue;}
case 1080:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1083);}
case 1083:{f.Push(f.Locals[7]);f.Pc=1085;continue;}
case 1085:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1088);}
case 1088:{f.StackOp("pop");f.Pc=1089;continue;}
case 1089:{f.Push(f.Locals[10]);f.Pc=1091;continue;}
case 1091:{f.Push(JValue.R(rt.String(" (")));f.Pc=1094;continue;}
case 1094:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1097);}
case 1097:{f.Push(f.Locals[7]);f.Pc=1099;continue;}
case 1099:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:1099:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1104);}
case 1104:{return rt.Call(f,"forge/game/keyword/Keyword","getInstance","(Ljava/lang/String;)Lforge/game/keyword/KeywordInterface;","invokestatic",1107);}
case 1107:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1112);}
case 1112:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1115);}
case 1115:{f.Push(JValue.R(rt.String(")")));f.Pc=1118;continue;}
case 1118:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1121);}
case 1121:{f.StackOp("pop");f.Pc=1122;continue;}
case 1122:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1125;continue;}
case 1125:{f.StackOp("dup");f.Pc=1126;continue;}
case 1126:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",1129);}
case 1129:{f.Locals[11]=f.Pop();f.Pc=1131;continue;}
case 1131:{f.Push(f.Locals[11]);f.Pc=1133;continue;}
case 1133:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Origin$ Battlefield | ValidCard$ Card.Self")));f.Pc=1136;continue;}
case 1136:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1139);}
case 1139:{f.StackOp("pop");f.Pc=1140;continue;}
case 1140:{f.Push(f.Locals[11]);f.Pc=1142;continue;}
case 1142:{f.Push(JValue.R(rt.String(" | Secondary$ True | TriggerDescription$ When this permanent leaves the battlefield, return the exiled card to the battlefield under its owner's control.")));f.Pc=1145;continue;}
case 1145:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1148);}
case 1148:{f.StackOp("pop");f.Pc=1149;continue;}
case 1149:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1152;continue;}
case 1152:{f.StackOp("dup");f.Pc=1153;continue;}
case 1153:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",1156);}
case 1156:{f.Locals[12]=f.Pop();f.Pc=1158;continue;}
case 1158:{f.Push(f.Locals[12]);f.Pc=1160;continue;}
case 1160:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Origin$ Battlefield | Destination$ Exile | RememberChanged$ True ")));f.Pc=1163;continue;}
case 1163:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1166);}
case 1166:{f.StackOp("pop");f.Pc=1167;continue;}
case 1167:{f.Push(f.Locals[12]);f.Pc=1169;continue;}
case 1169:{f.Push(JValue.R(rt.String(" | Champion$ True | Hidden$ True | Optional$ True | ChangeType$ ")));f.Pc=1172;continue;}
case 1172:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1175);}
case 1175:{f.Push(f.Locals[9]);f.Pc=1177;continue;}
case 1177:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/CharSequence;)Ljava/lang/StringBuilder;","invokevirtual",1180);}
case 1180:{f.StackOp("pop");f.Pc=1181;continue;}
case 1181:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1184;continue;}
case 1184:{f.StackOp("dup");f.Pc=1185;continue;}
case 1185:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",1188);}
case 1188:{f.Locals[13]=f.Pop();f.Pc=1190;continue;}
case 1190:{f.Push(f.Locals[13]);f.Pc=1192;continue;}
case 1192:{f.Push(JValue.R(rt.String("DB$ Sacrifice | ConditionDefined$ Remembered | ConditionPresent$ Card | ConditionCompare$ EQ0")));f.Pc=1195;continue;}
case 1195:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1198);}
case 1198:{f.StackOp("pop");f.Pc=1199;continue;}
case 1199:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Remembered | Origin$ Exile | Destination$ Battlefield")));f.Pc=1202;continue;}
case 1202:{f.Locals[14]=f.Pop();f.Pc=1204;continue;}
case 1204:{f.Push(f.Locals[10]);f.Pc=1206;continue;}
case 1206:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1209);}
case 1209:{f.Push(f.Locals[1]);f.Pc=1210;continue;}
case 1210:{f.Push(f.Locals[2]);f.Pc=1211;continue;}
case 1211:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",1214);}
case 1214:{f.Locals[15]=f.Pop();f.Pc=1216;continue;}
case 1216:{f.Push(f.Locals[11]);f.Pc=1218;continue;}
case 1218:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1221);}
case 1221:{f.Push(f.Locals[1]);f.Pc=1222;continue;}
case 1222:{f.Push(f.Locals[2]);f.Pc=1223;continue;}
case 1223:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",1226);}
case 1226:{f.Locals[16]=f.Pop();f.Pc=1228;continue;}
case 1228:{f.Push(f.Locals[12]);f.Pc=1230;continue;}
case 1230:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1233);}
case 1233:{f.Push(f.Locals[1]);f.Pc=1234;continue;}
case 1234:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",1237);}
case 1237:{f.Locals[17]=f.Pop();f.Pc=1239;continue;}
case 1239:{f.Push(f.Locals[13]);f.Pc=1241;continue;}
case 1241:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1244);}
case 1244:{f.Push(f.Locals[1]);f.Pc=1245;continue;}
case 1245:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",1248);}
case 1248:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1251;continue;}
case 1251:{f.Locals[18]=f.Pop();f.Pc=1253;continue;}
case 1253:{f.Push(f.Locals[17]);f.Pc=1255;continue;}
case 1255:{f.Push(f.Locals[18]);f.Pc=1257;continue;}
case 1257:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",1260);}
case 1260:{f.Push(f.Locals[17]);f.Pc=1262;continue;}
case 1262:{f.Push(f.Locals[2]);f.Pc=1263;continue;}
case 1263:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",1266);}
case 1266:{f.Push(f.Locals[15]);f.Pc=1268;continue;}
case 1268:{f.Push(f.Locals[17]);f.Pc=1270;continue;}
case 1270:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1273);}
case 1273:{f.Push(f.Locals[14]);f.Pc=1275;continue;}
case 1275:{f.Push(f.Locals[1]);f.Pc=1276;continue;}
case 1276:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",1279);}
case 1279:{f.Locals[19]=f.Pop();f.Pc=1281;continue;}
case 1281:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=1284;continue;}
case 1284:{f.Push(f.Locals[1]);f.Pc=1285;continue;}
case 1285:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",1288);}
case 1288:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1291;continue;}
case 1291:{f.Locals[18]=f.Pop();f.Pc=1293;continue;}
case 1293:{f.Push(f.Locals[19]);f.Pc=1295;continue;}
case 1295:{f.Push(f.Locals[18]);f.Pc=1297;continue;}
case 1297:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",1300);}
case 1300:{f.Push(f.Locals[19]);f.Pc=1302;continue;}
case 1302:{f.Push(f.Locals[2]);f.Pc=1303;continue;}
case 1303:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",1306);}
case 1306:{f.Push(f.Locals[16]);f.Pc=1308;continue;}
case 1308:{f.Push(f.Locals[19]);f.Pc=1310;continue;}
case 1310:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1313);}
case 1313:{f.Push(f.Locals[0]);f.Pc=1314;continue;}
case 1314:{f.Push(f.Locals[15]);f.Pc=1316;continue;}
case 1316:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",1321);}
case 1321:{f.Push(f.Locals[0]);f.Pc=1322;continue;}
case 1322:{f.Push(f.Locals[16]);f.Pc=1324;continue;}
case 1324:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",1329);}
case 1329:{f.Pc=9090;continue;}
case 1332:{f.Push(f.Locals[3]);f.Pc=1333;continue;}
case 1333:{f.Push(JValue.R(rt.String("Casualty")));f.Pc=1336;continue;}
case 1336:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1339);}
case 1339:{f.Pc=f.Pop().Int==0?1461:1342;continue;}
case 1342:{f.Push(JValue.R(rt.String("Mode$ SpellCast | ValidCard$ Card.Self | TriggerZones$ Stack | CheckSVar$ CasualtyPaid | Secondary$ True")));f.Pc=1345;continue;}
case 1345:{f.Locals[5]=f.Pop();f.Pc=1347;continue;}
case 1347:{f.Push(JValue.R(rt.String("DB$ CopySpellAbility | Defined$ TriggeredSpellAbility | MayChooseTarget$ True")));f.Pc=1350;continue;}
case 1350:{f.Locals[6]=f.Pop();f.Pc=1352;continue;}
case 1352:{f.Push(f.Locals[3]);f.Pc=1353;continue;}
case 1353:{f.Push(JValue.R(rt.String(":")));f.Pc=1356;continue;}
case 1356:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1359);}
case 1359:{f.Locals[7]=f.Pop();f.Pc=1361;continue;}
case 1361:{f.Push(f.Locals[7]);f.Pc=1363;continue;}
case 1363:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1364;continue;}
case 1364:{f.Push(JValue.I(2));f.Pc=1365;continue;}
case 1365:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1381:1368;continue;}
case 1368:{f.Push(f.Locals[6]);f.Pc=1370;continue;}
case 1370:{f.Push(f.Locals[7]);f.Pc=1372;continue;}
case 1372:{f.Push(JValue.I(2));f.Pc=1373;continue;}
case 1373:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1374;continue;}
case 1374:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:1374:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1379);}
case 1379:{f.Locals[6]=f.Pop();f.Pc=1381;continue;}
case 1381:{f.Push(JValue.R(rt.String("Mode$ SpellCast | ValidCard$ Card.Self | TriggerZones$ Stack | CheckSVar$ CasualtyPaid | Secondary$ True")));f.Pc=1384;continue;}
case 1384:{f.Push(f.Locals[1]);f.Pc=1385;continue;}
case 1385:{f.Push(f.Locals[2]);f.Pc=1386;continue;}
case 1386:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",1389);}
case 1389:{f.Locals[8]=f.Pop();f.Pc=1391;continue;}
case 1391:{f.Push(f.Locals[6]);f.Pc=1393;continue;}
case 1393:{f.Push(f.Locals[1]);f.Pc=1394;continue;}
case 1394:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",1397);}
case 1397:{f.Locals[9]=f.Pop();f.Pc=1399;continue;}
case 1399:{f.Push(f.Locals[9]);f.Pc=1401;continue;}
case 1401:{f.Push(JValue.R(rt.String("CasualtyPaid")));f.Pc=1404;continue;}
case 1404:{f.Push(JValue.R(rt.String("Count$hasOptionalKeywordAmount")));f.Pc=1407;continue;}
case 1407:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1410);}
case 1410:{f.Push(f.Locals[9]);f.Pc=1412;continue;}
case 1412:{f.Push(JValue.R(rt.String("Casualty")));f.Pc=1415;continue;}
case 1415:{f.Push(JValue.R(rt.String("Count$OptionalKeywordAmount")));f.Pc=1418;continue;}
case 1418:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1421);}
case 1421:{f.Push(f.Locals[8]);f.Pc=1423;continue;}
case 1423:{f.Push(f.Locals[9]);f.Pc=1425;continue;}
case 1425:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1428);}
case 1428:{f.Push(f.Locals[8]);f.Pc=1430;continue;}
case 1430:{f.Push(JValue.R(rt.String("CasualtyPaid")));f.Pc=1433;continue;}
case 1433:{f.Push(JValue.R(rt.String("Count$hasOptionalKeywordAmount")));f.Pc=1436;continue;}
case 1436:{return rt.Call(f,"forge/game/trigger/Trigger","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1439);}
case 1439:{f.Push(f.Locals[8]);f.Pc=1441;continue;}
case 1441:{f.Push(JValue.R(rt.String("Casualty")));f.Pc=1444;continue;}
case 1444:{f.Push(JValue.R(rt.String("Count$OptionalKeywordAmount")));f.Pc=1447;continue;}
case 1447:{return rt.Call(f,"forge/game/trigger/Trigger","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1450);}
case 1450:{f.Push(f.Locals[0]);f.Pc=1451;continue;}
case 1451:{f.Push(f.Locals[8]);f.Pc=1453;continue;}
case 1453:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",1458);}
case 1458:{f.Pc=9090;continue;}
case 1461:{f.Push(f.Locals[3]);f.Pc=1462;continue;}
case 1462:{f.Push(JValue.R(rt.String("Chapter")));f.Pc=1465;continue;}
case 1465:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1468);}
case 1468:{f.Pc=f.Pop().Int==0?1811:1471;continue;}
case 1471:{f.Push(f.Locals[3]);f.Pc=1472;continue;}
case 1472:{f.Push(JValue.R(rt.String(":")));f.Pc=1475;continue;}
case 1475:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1478);}
case 1478:{f.Locals[5]=f.Pop();f.Pc=1480;continue;}
case 1480:{f.Push(f.Locals[5]);f.Pc=1482;continue;}
case 1482:{f.Push(JValue.I(2));f.Pc=1483;continue;}
case 1483:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1484;continue;}
case 1484:{f.Push(JValue.R(rt.String(",")));f.Pc=1487;continue;}
case 1487:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1490);}
case 1490:{f.Locals[6]=f.Pop();f.Pc=1492;continue;}
case 1492:{f.Push(f.Locals[6]);f.Pc=1494;continue;}
case 1494:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1495;continue;}
case 1495:{f.Push(f.Locals[5]);f.Pc=1497;continue;}
case 1497:{f.Push(JValue.I(1));f.Pc=1498;continue;}
case 1498:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1499;continue;}
case 1499:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",1502);}
case 1502:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?1516:1505;continue;}
case 1505:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=1508;continue;}
case 1508:{f.StackOp("dup");f.Pc=1509;continue;}
case 1509:{f.Push(JValue.R(rt.String("Saga max differ from Ability amount")));f.Pc=1512;continue;}
case 1512:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",1515);}
case 1515:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 1516:{f.Push(JValue.I(1));f.Pc=1517;continue;}
case 1517:{f.Push(f.Locals[6]);f.Pc=1519;continue;}
case 1519:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1520;continue;}
case 1520:{return rt.Call(f,"java/util/stream/IntStream","rangeClosed","(II)Ljava/util/stream/IntStream;","invokestatic",1523);}
case 1523:{return rt.Call(f,"java/util/stream/IntStream","boxed","()Ljava/util/stream/Stream;","invokeinterface",1528);}
case 1528:{f.Push(f.Locals[6]);f.Pc=1530;continue;}
case 1530:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:1530:java/lang/invoke/LambdaMetafactory.metafactory","([Ljava/lang/String;)Ljava/util/function/Function;",1535);}
case 1535:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:1535:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Supplier;",1540);}
case 1540:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",1543);}
case 1543:{return rt.Call(f,"java/util/stream/Collectors","groupingBy","(Ljava/util/function/Function;Ljava/util/function/Supplier;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;","invokestatic",1546);}
case 1546:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",1551);}
case 1551:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1554;continue;}
case 1554:{f.Locals[7]=f.Pop();f.Pc=1556;continue;}
case 1556:{f.Push(f.Locals[7]);f.Pc=1558;continue;}
case 1558:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",1563);}
case 1563:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",1568);}
case 1568:{f.Locals[8]=f.Pop();f.Pc=1570;continue;}
case 1570:{f.Push(f.Locals[8]);f.Pc=1572;continue;}
case 1572:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1577);}
case 1577:{f.Pc=f.Pop().Int==0?1808:1580;continue;}
case 1580:{f.Push(f.Locals[8]);f.Pc=1582;continue;}
case 1582:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1587);}
case 1587:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1590;continue;}
case 1590:{f.Locals[9]=f.Pop();f.Pc=1592;continue;}
case 1592:{f.Push(f.Locals[9]);f.Pc=1594;continue;}
case 1594:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",1599);}
case 1599:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1602;continue;}
case 1602:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",1607);}
case 1607:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:1607:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",1612);}
case 1612:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",1617);}
case 1617:{f.Push(JValue.R(rt.String(", ")));f.Pc=1620;continue;}
case 1620:{return rt.Call(f,"java/util/stream/Collectors","joining","(Ljava/lang/CharSequence;)Ljava/util/stream/Collector;","invokestatic",1623);}
case 1623:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",1628);}
case 1628:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1631;continue;}
case 1631:{f.Locals[10]=f.Pop();f.Pc=1633;continue;}
case 1633:{f.Push(JValue.I(0));f.Pc=1634;continue;}
case 1634:{f.Locals[11]=f.Pop();f.Pc=1636;continue;}
case 1636:{f.Push(f.Locals[9]);f.Pc=1638;continue;}
case 1638:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",1643);}
case 1643:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1646;continue;}
case 1646:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1651);}
case 1651:{f.Locals[12]=f.Pop();f.Pc=1653;continue;}
case 1653:{f.Push(f.Locals[12]);f.Pc=1655;continue;}
case 1655:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1660);}
case 1660:{f.Pc=f.Pop().Int==0?1805:1663;continue;}
case 1663:{f.Push(f.Locals[12]);f.Pc=1665;continue;}
case 1665:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1670);}
case 1670:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1673;continue;}
case 1673:{f.Locals[13]=f.Pop();f.Pc=1675;continue;}
case 1675:{f.Push(f.Locals[1]);f.Pc=1676;continue;}
case 1676:{f.Push(f.Locals[9]);f.Pc=1678;continue;}
case 1678:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",1683);}
case 1683:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1686;continue;}
case 1686:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/Card;Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokestatic",1689);}
case 1689:{f.Locals[14]=f.Pop();f.Pc=1691;continue;}
case 1691:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1694;continue;}
case 1694:{f.StackOp("dup");f.Pc=1695;continue;}
case 1695:{f.Push(JValue.R(rt.String("Mode$ CounterAdded | ValidCard$ Card.Self | TriggerZones$ Battlefield")));f.Pc=1698;continue;}
case 1698:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",1701);}
case 1701:{f.Locals[15]=f.Pop();f.Pc=1703;continue;}
case 1703:{f.Push(f.Locals[15]);f.Pc=1705;continue;}
case 1705:{f.Push(JValue.R(rt.String("| Chapter$ ")));f.Pc=1708;continue;}
case 1708:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1711);}
case 1711:{f.Push(f.Locals[13]);f.Pc=1713;continue;}
case 1713:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",1716);}
case 1716:{f.Push(JValue.R(rt.String(" | CounterType$ LORE | CounterAmount$ EQ")));f.Pc=1719;continue;}
case 1719:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1722);}
case 1722:{f.Push(f.Locals[13]);f.Pc=1724;continue;}
case 1724:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",1727);}
case 1727:{f.StackOp("pop");f.Pc=1728;continue;}
case 1728:{f.Push(f.Locals[11]);f.Pc=1730;continue;}
case 1730:{f.Pc=f.Pop().Int==0?1742:1733;continue;}
case 1733:{f.Push(f.Locals[15]);f.Pc=1735;continue;}
case 1735:{f.Push(JValue.R(rt.String(" | Secondary$ True")));f.Pc=1738;continue;}
case 1738:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1741);}
case 1741:{f.StackOp("pop");f.Pc=1742;continue;}
case 1742:{f.Push(f.Locals[15]);f.Pc=1744;continue;}
case 1744:{f.Push(JValue.R(rt.String("| TriggerDescription$ ")));f.Pc=1747;continue;}
case 1747:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1750);}
case 1750:{f.Push(f.Locals[10]);f.Pc=1752;continue;}
case 1752:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1755);}
case 1755:{f.Push(JValue.R(rt.String(" \u2014 ")));f.Pc=1757;continue;}
case 1757:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1760);}
case 1760:{f.Push(f.Locals[14]);f.Pc=1762;continue;}
case 1762:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",1765);}
case 1765:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",1768);}
case 1768:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1771);}
case 1771:{f.StackOp("pop");f.Pc=1772;continue;}
case 1772:{f.Push(f.Locals[15]);f.Pc=1774;continue;}
case 1774:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1777);}
case 1777:{f.Push(f.Locals[1]);f.Pc=1778;continue;}
case 1778:{f.Push(f.Locals[2]);f.Pc=1779;continue;}
case 1779:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",1782);}
case 1782:{f.Locals[16]=f.Pop();f.Pc=1784;continue;}
case 1784:{f.Push(f.Locals[16]);f.Pc=1786;continue;}
case 1786:{f.Push(f.Locals[14]);f.Pc=1788;continue;}
case 1788:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1791);}
case 1791:{f.Push(f.Locals[0]);f.Pc=1792;continue;}
case 1792:{f.Push(f.Locals[16]);f.Pc=1794;continue;}
case 1794:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",1799);}
case 1799:{f.Push(JValue.I(1));f.Pc=1800;continue;}
case 1800:{f.Locals[11]=f.Pop();f.Pc=1802;continue;}
case 1802:{f.Pc=1653;continue;}
case 1805:{f.Pc=1570;continue;}
case 1808:{f.Pc=9090;continue;}
case 1811:{f.Push(f.Locals[3]);f.Pc=1812;continue;}
case 1812:{f.Push(JValue.R(rt.String("Conspire")));f.Pc=1815;continue;}
case 1815:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1818);}
case 1818:{f.Pc=f.Pop().Int==0?1875:1821;continue;}
case 1821:{f.Push(JValue.R(rt.String("Mode$ SpellCast | ValidCard$ Card.Self | CheckSVar$ Conspire | TriggerZones$ Stack | Secondary$ True | TriggerDescription$ Copy CARDNAME if its conspire cost was paid")));f.Pc=1824;continue;}
case 1824:{f.Locals[5]=f.Pop();f.Pc=1826;continue;}
case 1826:{f.Push(JValue.R(rt.String("DB$ CopySpellAbility | Defined$ TriggeredSpellAbility | MayChooseTarget$ True")));f.Pc=1829;continue;}
case 1829:{f.Locals[6]=f.Pop();f.Pc=1831;continue;}
case 1831:{f.Push(JValue.R(rt.String("Mode$ SpellCast | ValidCard$ Card.Self | CheckSVar$ Conspire | TriggerZones$ Stack | Secondary$ True | TriggerDescription$ Copy CARDNAME if its conspire cost was paid")));f.Pc=1834;continue;}
case 1834:{f.Push(f.Locals[1]);f.Pc=1835;continue;}
case 1835:{f.Push(f.Locals[2]);f.Pc=1836;continue;}
case 1836:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",1839);}
case 1839:{f.Locals[7]=f.Pop();f.Pc=1841;continue;}
case 1841:{f.Push(f.Locals[7]);f.Pc=1843;continue;}
case 1843:{f.Push(JValue.R(rt.String("DB$ CopySpellAbility | Defined$ TriggeredSpellAbility | MayChooseTarget$ True")));f.Pc=1846;continue;}
case 1846:{f.Push(f.Locals[1]);f.Pc=1847;continue;}
case 1847:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",1850);}
case 1850:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1853);}
case 1853:{f.Push(f.Locals[7]);f.Pc=1855;continue;}
case 1855:{f.Push(JValue.R(rt.String("Conspire")));f.Pc=1858;continue;}
case 1858:{f.Push(JValue.R(rt.String("Count$OptionalKeywordAmount")));f.Pc=1861;continue;}
case 1861:{return rt.Call(f,"forge/game/trigger/Trigger","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1864);}
case 1864:{f.Push(f.Locals[0]);f.Pc=1865;continue;}
case 1865:{f.Push(f.Locals[7]);f.Pc=1867;continue;}
case 1867:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",1872);}
case 1872:{f.Pc=9090;continue;}
case 1875:{f.Push(f.Locals[3]);f.Pc=1876;continue;}
case 1876:{f.Push(JValue.R(rt.String("Cumulative upkeep")));f.Pc=1879;continue;}
case 1879:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1882);}
case 1882:{f.Pc=f.Pop().Int==0?1993:1885;continue;}
case 1885:{f.Push(f.Locals[3]);f.Pc=1886;continue;}
case 1886:{f.Push(JValue.R(rt.String(":")));f.Pc=1889;continue;}
case 1889:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1892);}
case 1892:{f.Locals[5]=f.Pop();f.Pc=1894;continue;}
case 1894:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=1897;continue;}
case 1897:{f.StackOp("dup");f.Pc=1898;continue;}
case 1898:{f.Push(f.Locals[5]);f.Pc=1900;continue;}
case 1900:{f.Push(JValue.I(1));f.Pc=1901;continue;}
case 1901:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1902;continue;}
case 1902:{f.Push(JValue.I(0));f.Pc=1903;continue;}
case 1903:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",1906);}
case 1906:{f.Locals[6]=f.Pop();f.Pc=1908;continue;}
case 1908:{f.Push(f.Locals[6]);f.Pc=1910;continue;}
case 1910:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",1913);}
case 1913:{f.Locals[7]=f.Pop();f.Pc=1915;continue;}
case 1915:{f.Push(f.Locals[6]);f.Pc=1917;continue;}
case 1917:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",1920);}
case 1920:{f.Pc=f.Pop().Int!=0?1932:1923;continue;}
case 1923:{f.Push(f.Locals[7]);f.Pc=1925;continue;}
case 1925:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:1925:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1930);}
case 1930:{f.Locals[7]=f.Pop();f.Pc=1932;continue;}
case 1932:{f.Push(f.Locals[5]);f.Pc=1934;continue;}
case 1934:{f.Push(JValue.I(0));f.Pc=1935;continue;}
case 1935:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1936;continue;}
case 1936:{f.Push(f.Locals[7]);f.Pc=1938;continue;}
case 1938:{f.Push(f.Locals[0]);f.Pc=1939;continue;}
case 1939:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1944);}
case 1944:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:1944:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1949);}
case 1949:{f.Locals[8]=f.Pop();f.Pc=1951;continue;}
case 1951:{f.Push(f.Locals[5]);f.Pc=1953;continue;}
case 1953:{f.Push(JValue.I(1));f.Pc=1954;continue;}
case 1954:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1955;continue;}
case 1955:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:1955:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1960);}
case 1960:{f.Locals[9]=f.Pop();f.Pc=1962;continue;}
case 1962:{f.Push(f.Locals[8]);f.Pc=1964;continue;}
case 1964:{f.Push(f.Locals[1]);f.Pc=1965;continue;}
case 1965:{f.Push(f.Locals[2]);f.Pc=1966;continue;}
case 1966:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",1969);}
case 1969:{f.Locals[10]=f.Pop();f.Pc=1971;continue;}
case 1971:{f.Push(f.Locals[10]);f.Pc=1973;continue;}
case 1973:{f.Push(f.Locals[9]);f.Pc=1975;continue;}
case 1975:{f.Push(f.Locals[1]);f.Pc=1976;continue;}
case 1976:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",1979);}
case 1979:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1982);}
case 1982:{f.Push(f.Locals[0]);f.Pc=1983;continue;}
case 1983:{f.Push(f.Locals[10]);f.Pc=1985;continue;}
case 1985:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",1990);}
case 1990:{f.Pc=9090;continue;}
case 1993:{f.Push(f.Locals[3]);f.Pc=1994;continue;}
case 1994:{f.Push(JValue.R(rt.String("Daybound")));f.Pc=1997;continue;}
case 1997:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2000);}
case 2000:{f.Pc=f.Pop().Int==0?2084:2003;continue;}
case 2003:{f.Push(JValue.R(rt.String("Mode$ Always | TriggerZones$ Battlefield | Static$ True | DayTime$ Neither | Secondary$ True | TriggerDescription$ Any time a player controls a permanent with daybound, if it's neither day nor night, it becomes day.")));f.Pc=2006;continue;}
case 2006:{f.Locals[5]=f.Pop();f.Pc=2008;continue;}
case 2008:{f.Push(JValue.R(rt.String("DB$ DayTime | Value$ Day")));f.Pc=2011;continue;}
case 2011:{f.Locals[6]=f.Pop();f.Pc=2013;continue;}
case 2013:{f.Push(JValue.R(rt.String("Mode$ Always | TriggerZones$ Battlefield | Static$ True | DayTime$ Neither | Secondary$ True | TriggerDescription$ Any time a player controls a permanent with daybound, if it's neither day nor night, it becomes day.")));f.Pc=2016;continue;}
case 2016:{f.Push(f.Locals[1]);f.Pc=2017;continue;}
case 2017:{f.Push(f.Locals[2]);f.Pc=2018;continue;}
case 2018:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",2021);}
case 2021:{f.Locals[7]=f.Pop();f.Pc=2023;continue;}
case 2023:{f.Push(f.Locals[7]);f.Pc=2025;continue;}
case 2025:{f.Push(f.Locals[6]);f.Pc=2027;continue;}
case 2027:{f.Push(f.Locals[1]);f.Pc=2028;continue;}
case 2028:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2031);}
case 2031:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2034);}
case 2034:{f.Push(f.Locals[0]);f.Pc=2035;continue;}
case 2035:{f.Push(f.Locals[7]);f.Pc=2037;continue;}
case 2037:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",2042);}
case 2042:{f.Push(JValue.R(rt.String("Mode$ Always | TriggerZones$ Battlefield | Static$ True | DayTime$ Night | IsPresent$ Card.Self+FrontSide | Secondary$ True | TriggerDescription$ As it becomes night, if this permanent is front face up, transform it.")));f.Pc=2045;continue;}
case 2045:{f.Locals[8]=f.Pop();f.Pc=2047;continue;}
case 2047:{f.Push(JValue.R(rt.String("DB$ SetState | Mode$ Transform")));f.Pc=2050;continue;}
case 2050:{f.Locals[9]=f.Pop();f.Pc=2052;continue;}
case 2052:{f.Push(JValue.R(rt.String("Mode$ Always | TriggerZones$ Battlefield | Static$ True | DayTime$ Night | IsPresent$ Card.Self+FrontSide | Secondary$ True | TriggerDescription$ As it becomes night, if this permanent is front face up, transform it.")));f.Pc=2055;continue;}
case 2055:{f.Push(f.Locals[1]);f.Pc=2056;continue;}
case 2056:{f.Push(f.Locals[2]);f.Pc=2057;continue;}
case 2057:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",2060);}
case 2060:{f.Locals[7]=f.Pop();f.Pc=2062;continue;}
case 2062:{f.Push(f.Locals[7]);f.Pc=2064;continue;}
case 2064:{f.Push(f.Locals[9]);f.Pc=2066;continue;}
case 2066:{f.Push(f.Locals[1]);f.Pc=2067;continue;}
case 2067:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2070);}
case 2070:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2073);}
case 2073:{f.Push(f.Locals[0]);f.Pc=2074;continue;}
case 2074:{f.Push(f.Locals[7]);f.Pc=2076;continue;}
case 2076:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",2081);}
case 2081:{f.Pc=9090;continue;}
case 2084:{f.Push(f.Locals[3]);f.Pc=2085;continue;}
case 2085:{f.Push(JValue.R(rt.String("Decayed")));f.Pc=2088;continue;}
case 2088:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2091);}
case 2091:{f.Pc=f.Pop().Int==0?2174:2094;continue;}
case 2094:{f.Push(JValue.R(rt.String("Mode$ Attacks | ValidCard$ Card.Self | Secondary$ True | TriggerDescription$ When a creature with decayed attacks, sacrifice it at end of combat.")));f.Pc=2097;continue;}
case 2097:{f.Locals[5]=f.Pop();f.Pc=2099;continue;}
case 2099:{f.Push(JValue.R(rt.String("DB$ DelayedTrigger | Mode$ Phase | Phase$ EndCombat | TriggerDescription$ At end of combat, sacrifice CARDNAME.")));f.Pc=2102;continue;}
case 2102:{f.Locals[6]=f.Pop();f.Pc=2104;continue;}
case 2104:{f.Push(JValue.R(rt.String("DB$ Sacrifice")));f.Pc=2107;continue;}
case 2107:{f.Locals[7]=f.Pop();f.Pc=2109;continue;}
case 2109:{f.Push(JValue.R(rt.String("DB$ DelayedTrigger | Mode$ Phase | Phase$ EndCombat | TriggerDescription$ At end of combat, sacrifice CARDNAME.")));f.Pc=2112;continue;}
case 2112:{f.Push(f.Locals[1]);f.Pc=2113;continue;}
case 2113:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2116);}
case 2116:{f.Locals[8]=f.Pop();f.Pc=2118;continue;}
case 2118:{f.Push(JValue.R(rt.String("DB$ Sacrifice")));f.Pc=2121;continue;}
case 2121:{f.Push(f.Locals[1]);f.Pc=2122;continue;}
case 2122:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2125);}
case 2125:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2128;continue;}
case 2128:{f.Locals[9]=f.Pop();f.Pc=2130;continue;}
case 2130:{f.Push(f.Locals[8]);f.Pc=2132;continue;}
case 2132:{f.Push(JValue.R(rt.String("Execute")));f.Pc=2135;continue;}
case 2135:{f.Push(f.Locals[9]);f.Pc=2137;continue;}
case 2137:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAdditionalAbility","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)V","invokevirtual",2140);}
case 2140:{f.Push(JValue.R(rt.String("Mode$ Attacks | ValidCard$ Card.Self | Secondary$ True | TriggerDescription$ When a creature with decayed attacks, sacrifice it at end of combat.")));f.Pc=2143;continue;}
case 2143:{f.Push(f.Locals[1]);f.Pc=2144;continue;}
case 2144:{f.Push(f.Locals[2]);f.Pc=2145;continue;}
case 2145:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",2148);}
case 2148:{f.Locals[10]=f.Pop();f.Pc=2150;continue;}
case 2150:{f.Push(f.Locals[8]);f.Pc=2152;continue;}
case 2152:{f.Push(f.Locals[2]);f.Pc=2153;continue;}
case 2153:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",2156);}
case 2156:{f.Push(f.Locals[10]);f.Pc=2158;continue;}
case 2158:{f.Push(f.Locals[8]);f.Pc=2160;continue;}
case 2160:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2163);}
case 2163:{f.Push(f.Locals[0]);f.Pc=2164;continue;}
case 2164:{f.Push(f.Locals[10]);f.Pc=2166;continue;}
case 2166:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",2171);}
case 2171:{f.Pc=9090;continue;}
case 2174:{f.Push(f.Locals[3]);f.Pc=2175;continue;}
case 2175:{f.Push(JValue.R(rt.String("Demonstrate")));f.Pc=2178;continue;}
case 2178:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2181);}
case 2181:{f.Pc=f.Pop().Int==0?2310:2184;continue;}
case 2184:{f.Push(f.Locals[0]);f.Pc=2185;continue;}
case 2185:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2190);}
case 2190:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:2190:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2195);}
case 2195:{f.Locals[5]=f.Pop();f.Pc=2197;continue;}
case 2197:{f.Push(JValue.R(rt.String("DB$ CopySpellAbility | Defined$ TriggeredSpellAbility | MayChooseTarget$ True | Optional$ True | RememberCopies$ True")));f.Pc=2200;continue;}
case 2200:{f.Locals[6]=f.Pop();f.Pc=2202;continue;}
case 2202:{f.Push(JValue.R(rt.String("DB$ ChoosePlayer | Defined$ You | Choices$ Player.Opponent | ConditionDefined$ Remembered | ConditionPresent$ Spell")));f.Pc=2205;continue;}
case 2205:{f.Locals[7]=f.Pop();f.Pc=2207;continue;}
case 2207:{f.Push(JValue.R(rt.String("DB$ CopySpellAbility | Controller$ ChosenPlayer | Defined$ TriggeredSpellAbility | MayChooseTarget$ True | ConditionDefined$ Remembered | ConditionPresent$ Spell")));f.Pc=2210;continue;}
case 2210:{f.Locals[8]=f.Pop();f.Pc=2212;continue;}
case 2212:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True | ClearChosenPlayer$ True")));f.Pc=2215;continue;}
case 2215:{f.Locals[9]=f.Pop();f.Pc=2217;continue;}
case 2217:{f.Push(f.Locals[5]);f.Pc=2219;continue;}
case 2219:{f.Push(f.Locals[1]);f.Pc=2220;continue;}
case 2220:{f.Push(f.Locals[2]);f.Pc=2221;continue;}
case 2221:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",2224);}
case 2224:{f.Locals[10]=f.Pop();f.Pc=2226;continue;}
case 2226:{f.Push(JValue.R(rt.String("DB$ CopySpellAbility | Defined$ TriggeredSpellAbility | MayChooseTarget$ True | Optional$ True | RememberCopies$ True")));f.Pc=2229;continue;}
case 2229:{f.Push(f.Locals[1]);f.Pc=2230;continue;}
case 2230:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2233);}
case 2233:{f.Locals[11]=f.Pop();f.Pc=2235;continue;}
case 2235:{f.Push(JValue.R(rt.String("DB$ ChoosePlayer | Defined$ You | Choices$ Player.Opponent | ConditionDefined$ Remembered | ConditionPresent$ Spell")));f.Pc=2238;continue;}
case 2238:{f.Push(f.Locals[1]);f.Pc=2239;continue;}
case 2239:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2242);}
case 2242:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2245;continue;}
case 2245:{f.Locals[12]=f.Pop();f.Pc=2247;continue;}
case 2247:{f.Push(JValue.R(rt.String("DB$ CopySpellAbility | Controller$ ChosenPlayer | Defined$ TriggeredSpellAbility | MayChooseTarget$ True | ConditionDefined$ Remembered | ConditionPresent$ Spell")));f.Pc=2250;continue;}
case 2250:{f.Push(f.Locals[1]);f.Pc=2251;continue;}
case 2251:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2254);}
case 2254:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2257;continue;}
case 2257:{f.Locals[13]=f.Pop();f.Pc=2259;continue;}
case 2259:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True | ClearChosenPlayer$ True")));f.Pc=2262;continue;}
case 2262:{f.Push(f.Locals[1]);f.Pc=2263;continue;}
case 2263:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2266);}
case 2266:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2269;continue;}
case 2269:{f.Locals[14]=f.Pop();f.Pc=2271;continue;}
case 2271:{f.Push(f.Locals[13]);f.Pc=2273;continue;}
case 2273:{f.Push(f.Locals[14]);f.Pc=2275;continue;}
case 2275:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",2278);}
case 2278:{f.Push(f.Locals[12]);f.Pc=2280;continue;}
case 2280:{f.Push(f.Locals[13]);f.Pc=2282;continue;}
case 2282:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",2285);}
case 2285:{f.Push(f.Locals[11]);f.Pc=2287;continue;}
case 2287:{f.Push(f.Locals[12]);f.Pc=2289;continue;}
case 2289:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",2292);}
case 2292:{f.Push(f.Locals[10]);f.Pc=2294;continue;}
case 2294:{f.Push(f.Locals[11]);f.Pc=2296;continue;}
case 2296:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2299);}
case 2299:{f.Push(f.Locals[0]);f.Pc=2300;continue;}
case 2300:{f.Push(f.Locals[10]);f.Pc=2302;continue;}
case 2302:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",2307);}
case 2307:{f.Pc=9090;continue;}
case 2310:{f.Push(f.Locals[3]);f.Pc=2311;continue;}
case 2311:{f.Push(JValue.R(rt.String("Dethrone")));f.Pc=2314;continue;}
case 2314:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2317);}
case 2317:{f.Pc=f.Pop().Int==0?2380:2320;continue;}
case 2320:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=2323;continue;}
case 2323:{f.StackOp("dup");f.Pc=2324;continue;}
case 2324:{f.Push(f.Locals[0]);f.Pc=2325;continue;}
case 2325:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2330);}
case 2330:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:2330:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2335);}
case 2335:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",2338);}
case 2338:{f.Locals[5]=f.Pop();f.Pc=2340;continue;}
case 2340:{f.Push(JValue.R(rt.String("DB$ PutCounter | Defined$ Self | CounterType$ P1P1 | CounterNum$ 1")));f.Pc=2343;continue;}
case 2343:{f.Locals[6]=f.Pop();f.Pc=2345;continue;}
case 2345:{f.Push(f.Locals[5]);f.Pc=2347;continue;}
case 2347:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",2350);}
case 2350:{f.Push(f.Locals[1]);f.Pc=2351;continue;}
case 2351:{f.Push(f.Locals[2]);f.Pc=2352;continue;}
case 2352:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",2355);}
case 2355:{f.Locals[7]=f.Pop();f.Pc=2357;continue;}
case 2357:{f.Push(f.Locals[7]);f.Pc=2359;continue;}
case 2359:{f.Push(JValue.R(rt.String("DB$ PutCounter | Defined$ Self | CounterType$ P1P1 | CounterNum$ 1")));f.Pc=2362;continue;}
case 2362:{f.Push(f.Locals[1]);f.Pc=2363;continue;}
case 2363:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2366);}
case 2366:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2369);}
case 2369:{f.Push(f.Locals[0]);f.Pc=2370;continue;}
case 2370:{f.Push(f.Locals[7]);f.Pc=2372;continue;}
case 2372:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",2377);}
case 2377:{f.Pc=9090;continue;}
case 2380:{f.Push(f.Locals[3]);f.Pc=2381;continue;}
case 2381:{f.Push(JValue.R(rt.String("Double team")));f.Pc=2384;continue;}
case 2384:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2387);}
case 2387:{f.Pc=f.Pop().Int==0?2516:2390;continue;}
case 2390:{f.Push(f.Locals[0]);f.Pc=2391;continue;}
case 2391:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2396);}
case 2396:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:2396:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2401);}
case 2401:{f.Locals[5]=f.Pop();f.Pc=2403;continue;}
case 2403:{f.Push(JValue.R(rt.String("DB$ MakeCard | DefinedName$ Self | Zone$ Hand | RememberMade$ True | Conjure$ True")));f.Pc=2406;continue;}
case 2406:{f.Locals[6]=f.Pop();f.Pc=2408;continue;}
case 2408:{f.Push(JValue.R(rt.String("DB$ Bookkeeping | RememberObjects$ Self")));f.Pc=2411;continue;}
case 2411:{f.Locals[7]=f.Pop();f.Pc=2413;continue;}
case 2413:{f.Push(JValue.R(rt.String("DB$ Animate | Duration$ Perpetual | Defined$ Remembered | RemoveKeywords$ Double team")));f.Pc=2416;continue;}
case 2416:{f.Locals[8]=f.Pop();f.Pc=2418;continue;}
case 2418:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=2421;continue;}
case 2421:{f.Locals[9]=f.Pop();f.Pc=2423;continue;}
case 2423:{f.Push(f.Locals[5]);f.Pc=2425;continue;}
case 2425:{f.Push(f.Locals[1]);f.Pc=2426;continue;}
case 2426:{f.Push(f.Locals[2]);f.Pc=2427;continue;}
case 2427:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",2430);}
case 2430:{f.Locals[10]=f.Pop();f.Pc=2432;continue;}
case 2432:{f.Push(JValue.R(rt.String("DB$ MakeCard | DefinedName$ Self | Zone$ Hand | RememberMade$ True | Conjure$ True")));f.Pc=2435;continue;}
case 2435:{f.Push(f.Locals[1]);f.Pc=2436;continue;}
case 2436:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2439);}
case 2439:{f.Locals[11]=f.Pop();f.Pc=2441;continue;}
case 2441:{f.Push(JValue.R(rt.String("DB$ Bookkeeping | RememberObjects$ Self")));f.Pc=2444;continue;}
case 2444:{f.Push(f.Locals[1]);f.Pc=2445;continue;}
case 2445:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2448);}
case 2448:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2451;continue;}
case 2451:{f.Locals[12]=f.Pop();f.Pc=2453;continue;}
case 2453:{f.Push(JValue.R(rt.String("DB$ Animate | Duration$ Perpetual | Defined$ Remembered | RemoveKeywords$ Double team")));f.Pc=2456;continue;}
case 2456:{f.Push(f.Locals[1]);f.Pc=2457;continue;}
case 2457:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2460);}
case 2460:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2463;continue;}
case 2463:{f.Locals[13]=f.Pop();f.Pc=2465;continue;}
case 2465:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=2468;continue;}
case 2468:{f.Push(f.Locals[1]);f.Pc=2469;continue;}
case 2469:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2472);}
case 2472:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2475;continue;}
case 2475:{f.Locals[14]=f.Pop();f.Pc=2477;continue;}
case 2477:{f.Push(f.Locals[11]);f.Pc=2479;continue;}
case 2479:{f.Push(f.Locals[12]);f.Pc=2481;continue;}
case 2481:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",2484);}
case 2484:{f.Push(f.Locals[12]);f.Pc=2486;continue;}
case 2486:{f.Push(f.Locals[13]);f.Pc=2488;continue;}
case 2488:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",2491);}
case 2491:{f.Push(f.Locals[13]);f.Pc=2493;continue;}
case 2493:{f.Push(f.Locals[14]);f.Pc=2495;continue;}
case 2495:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",2498);}
case 2498:{f.Push(f.Locals[10]);f.Pc=2500;continue;}
case 2500:{f.Push(f.Locals[11]);f.Pc=2502;continue;}
case 2502:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2505);}
case 2505:{f.Push(f.Locals[0]);f.Pc=2506;continue;}
case 2506:{f.Push(f.Locals[10]);f.Pc=2508;continue;}
case 2508:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",2513);}
case 2513:{f.Pc=9090;continue;}
case 2516:{f.Push(f.Locals[3]);f.Pc=2517;continue;}
case 2517:{f.Push(JValue.R(rt.String("Echo")));f.Pc=2520;continue;}
case 2520:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2523);}
case 2523:{f.Pc=f.Pop().Int==0?2594:2526;continue;}
case 2526:{f.Push(f.Locals[3]);f.Pc=2527;continue;}
case 2527:{f.Push(JValue.R(rt.String(":")));f.Pc=2530;continue;}
case 2530:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2533);}
case 2533:{f.Locals[5]=f.Pop();f.Pc=2535;continue;}
case 2535:{f.Push(f.Locals[5]);f.Pc=2537;continue;}
case 2537:{f.Push(JValue.I(1));f.Pc=2538;continue;}
case 2538:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2539;continue;}
case 2539:{f.Locals[6]=f.Pop();f.Pc=2541;continue;}
case 2541:{f.Push(f.Locals[0]);f.Pc=2542;continue;}
case 2542:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2547);}
case 2547:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:2547:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2552);}
case 2552:{f.Locals[7]=f.Pop();f.Pc=2554;continue;}
case 2554:{f.Push(f.Locals[6]);f.Pc=2556;continue;}
case 2556:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:2556:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2561);}
case 2561:{f.Locals[8]=f.Pop();f.Pc=2563;continue;}
case 2563:{f.Push(f.Locals[7]);f.Pc=2565;continue;}
case 2565:{f.Push(f.Locals[1]);f.Pc=2566;continue;}
case 2566:{f.Push(f.Locals[2]);f.Pc=2567;continue;}
case 2567:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",2570);}
case 2570:{f.Locals[9]=f.Pop();f.Pc=2572;continue;}
case 2572:{f.Push(f.Locals[9]);f.Pc=2574;continue;}
case 2574:{f.Push(f.Locals[8]);f.Pc=2576;continue;}
case 2576:{f.Push(f.Locals[1]);f.Pc=2577;continue;}
case 2577:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2580);}
case 2580:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2583);}
case 2583:{f.Push(f.Locals[0]);f.Pc=2584;continue;}
case 2584:{f.Push(f.Locals[9]);f.Pc=2586;continue;}
case 2586:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",2591);}
case 2591:{f.Pc=9090;continue;}
case 2594:{f.Push(f.Locals[3]);f.Pc=2595;continue;}
case 2595:{f.Push(JValue.R(rt.String("Evoke")));f.Pc=2598;continue;}
case 2598:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2601);}
case 2601:{f.Pc=f.Pop().Int==0?2664:2604;continue;}
case 2604:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=2607;continue;}
case 2607:{f.StackOp("dup");f.Pc=2608;continue;}
case 2608:{f.Push(f.Locals[0]);f.Pc=2609;continue;}
case 2609:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2614);}
case 2614:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:2614:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2619);}
case 2619:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",2622);}
case 2622:{f.Locals[5]=f.Pop();f.Pc=2624;continue;}
case 2624:{f.Push(JValue.R(rt.String("DB$ Sacrifice")));f.Pc=2627;continue;}
case 2627:{f.Locals[6]=f.Pop();f.Pc=2629;continue;}
case 2629:{f.Push(f.Locals[5]);f.Pc=2631;continue;}
case 2631:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",2634);}
case 2634:{f.Push(f.Locals[1]);f.Pc=2635;continue;}
case 2635:{f.Push(f.Locals[2]);f.Pc=2636;continue;}
case 2636:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",2639);}
case 2639:{f.Locals[7]=f.Pop();f.Pc=2641;continue;}
case 2641:{f.Push(f.Locals[7]);f.Pc=2643;continue;}
case 2643:{f.Push(JValue.R(rt.String("DB$ Sacrifice")));f.Pc=2646;continue;}
case 2646:{f.Push(f.Locals[1]);f.Pc=2647;continue;}
case 2647:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2650);}
case 2650:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2653);}
case 2653:{f.Push(f.Locals[0]);f.Pc=2654;continue;}
case 2654:{f.Push(f.Locals[7]);f.Pc=2656;continue;}
case 2656:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",2661);}
case 2661:{f.Pc=9090;continue;}
case 2664:{f.Push(f.Locals[3]);f.Pc=2665;continue;}
case 2665:{f.Push(JValue.R(rt.String("Evolve")));f.Pc=2668;continue;}
case 2668:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2671);}
case 2671:{f.Pc=f.Pop().Int==0?2724:2674;continue;}
case 2674:{f.Push(f.Locals[0]);f.Pc=2675;continue;}
case 2675:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2680);}
case 2680:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:2680:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2685);}
case 2685:{f.Locals[5]=f.Pop();f.Pc=2687;continue;}
case 2687:{f.Push(JValue.R(rt.String("DB$ PutCounter | Defined$ Self | CounterType$ P1P1 | CounterNum$ 1")));f.Pc=2690;continue;}
case 2690:{f.Locals[6]=f.Pop();f.Pc=2692;continue;}
case 2692:{f.Push(f.Locals[5]);f.Pc=2694;continue;}
case 2694:{f.Push(f.Locals[1]);f.Pc=2695;continue;}
case 2695:{f.Push(f.Locals[2]);f.Pc=2696;continue;}
case 2696:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",2699);}
case 2699:{f.Locals[7]=f.Pop();f.Pc=2701;continue;}
case 2701:{f.Push(f.Locals[7]);f.Pc=2703;continue;}
case 2703:{f.Push(JValue.R(rt.String("DB$ PutCounter | Defined$ Self | CounterType$ P1P1 | CounterNum$ 1")));f.Pc=2706;continue;}
case 2706:{f.Push(f.Locals[1]);f.Pc=2707;continue;}
case 2707:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2710);}
case 2710:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2713);}
case 2713:{f.Push(f.Locals[0]);f.Pc=2714;continue;}
case 2714:{f.Push(f.Locals[7]);f.Pc=2716;continue;}
case 2716:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",2721);}
case 2721:{f.Pc=9090;continue;}
case 2724:{f.Push(f.Locals[3]);f.Pc=2725;continue;}
case 2725:{f.Push(JValue.R(rt.String("Exalted")));f.Pc=2728;continue;}
case 2728:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2731);}
case 2731:{f.Pc=f.Pop().Int==0?2784:2734;continue;}
case 2734:{f.Push(f.Locals[0]);f.Pc=2735;continue;}
case 2735:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2740);}
case 2740:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:2740:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2745);}
case 2745:{f.Locals[5]=f.Pop();f.Pc=2747;continue;}
case 2747:{f.Push(JValue.R(rt.String("DB$ Pump | Defined$ TriggeredAttackerLKICopy | NumAtt$ +1 | NumDef$ +1")));f.Pc=2750;continue;}
case 2750:{f.Locals[6]=f.Pop();f.Pc=2752;continue;}
case 2752:{f.Push(f.Locals[5]);f.Pc=2754;continue;}
case 2754:{f.Push(f.Locals[1]);f.Pc=2755;continue;}
case 2755:{f.Push(f.Locals[2]);f.Pc=2756;continue;}
case 2756:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",2759);}
case 2759:{f.Locals[7]=f.Pop();f.Pc=2761;continue;}
case 2761:{f.Push(f.Locals[7]);f.Pc=2763;continue;}
case 2763:{f.Push(JValue.R(rt.String("DB$ Pump | Defined$ TriggeredAttackerLKICopy | NumAtt$ +1 | NumDef$ +1")));f.Pc=2766;continue;}
case 2766:{f.Push(f.Locals[1]);f.Pc=2767;continue;}
case 2767:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2770);}
case 2770:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2773);}
case 2773:{f.Push(f.Locals[0]);f.Pc=2774;continue;}
case 2774:{f.Push(f.Locals[7]);f.Pc=2776;continue;}
case 2776:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",2781);}
case 2781:{f.Pc=9090;continue;}
case 2784:{f.Push(f.Locals[3]);f.Pc=2785;continue;}
case 2785:{f.Push(JValue.R(rt.String("Exploit")));f.Pc=2788;continue;}
case 2788:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2791);}
case 2791:{f.Pc=f.Pop().Int==0?2844:2794;continue;}
case 2794:{f.Push(f.Locals[0]);f.Pc=2795;continue;}
case 2795:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2800);}
case 2800:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:2800:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2805);}
case 2805:{f.Locals[5]=f.Pop();f.Pc=2807;continue;}
case 2807:{f.Push(JValue.R(rt.String("DB$ Sacrifice | SacValid$ Creature | SacMessage$ creature | Optional$ True")));f.Pc=2810;continue;}
case 2810:{f.Locals[6]=f.Pop();f.Pc=2812;continue;}
case 2812:{f.Push(f.Locals[5]);f.Pc=2814;continue;}
case 2814:{f.Push(f.Locals[1]);f.Pc=2815;continue;}
case 2815:{f.Push(f.Locals[2]);f.Pc=2816;continue;}
case 2816:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",2819);}
case 2819:{f.Locals[7]=f.Pop();f.Pc=2821;continue;}
case 2821:{f.Push(f.Locals[7]);f.Pc=2823;continue;}
case 2823:{f.Push(JValue.R(rt.String("DB$ Sacrifice | SacValid$ Creature | SacMessage$ creature | Optional$ True")));f.Pc=2826;continue;}
case 2826:{f.Push(f.Locals[1]);f.Pc=2827;continue;}
case 2827:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2830);}
case 2830:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2833);}
case 2833:{f.Push(f.Locals[0]);f.Pc=2834;continue;}
case 2834:{f.Push(f.Locals[7]);f.Pc=2836;continue;}
case 2836:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",2841);}
case 2841:{f.Pc=9090;continue;}
case 2844:{f.Push(f.Locals[3]);f.Pc=2845;continue;}
case 2845:{f.Push(JValue.R(rt.String("Extort")));f.Pc=2848;continue;}
case 2848:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2851);}
case 2851:{f.Pc=f.Pop().Int==0?2949:2854;continue;}
case 2854:{f.Push(f.Locals[0]);f.Pc=2855;continue;}
case 2855:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2860);}
case 2860:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:2860:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2865);}
case 2865:{f.Locals[5]=f.Pop();f.Pc=2867;continue;}
case 2867:{f.Push(JValue.R(rt.String("AB$ LoseLife | Cost$ WB | Defined$ Player.Opponent | LifeAmount$ 1")));f.Pc=2870;continue;}
case 2870:{f.Locals[6]=f.Pop();f.Pc=2872;continue;}
case 2872:{f.Push(JValue.R(rt.String("DB$ GainLife | Defined$ You | LifeAmount$ AFLifeLost")));f.Pc=2875;continue;}
case 2875:{f.Locals[7]=f.Pop();f.Pc=2877;continue;}
case 2877:{f.Push(JValue.R(rt.String("AB$ LoseLife | Cost$ WB | Defined$ Player.Opponent | LifeAmount$ 1")));f.Pc=2880;continue;}
case 2880:{f.Push(f.Locals[1]);f.Pc=2881;continue;}
case 2881:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2884);}
case 2884:{f.Locals[8]=f.Pop();f.Pc=2886;continue;}
case 2886:{f.Push(JValue.R(rt.String("DB$ GainLife | Defined$ You | LifeAmount$ AFLifeLost")));f.Pc=2889;continue;}
case 2889:{f.Push(f.Locals[1]);f.Pc=2890;continue;}
case 2890:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",2893);}
case 2893:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2896;continue;}
case 2896:{f.Locals[9]=f.Pop();f.Pc=2898;continue;}
case 2898:{f.Push(f.Locals[8]);f.Pc=2900;continue;}
case 2900:{f.Push(JValue.R(rt.String("AFLifeLost")));f.Pc=2903;continue;}
case 2903:{f.Push(JValue.R(rt.String("Number$0")));f.Pc=2906;continue;}
case 2906:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",2909);}
case 2909:{f.Push(f.Locals[8]);f.Pc=2911;continue;}
case 2911:{f.Push(f.Locals[9]);f.Pc=2913;continue;}
case 2913:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",2916);}
case 2916:{f.Push(f.Locals[8]);f.Pc=2918;continue;}
case 2918:{f.Push(f.Locals[2]);f.Pc=2919;continue;}
case 2919:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",2922);}
case 2922:{f.Push(f.Locals[5]);f.Pc=2924;continue;}
case 2924:{f.Push(f.Locals[1]);f.Pc=2925;continue;}
case 2925:{f.Push(f.Locals[2]);f.Pc=2926;continue;}
case 2926:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",2929);}
case 2929:{f.Locals[10]=f.Pop();f.Pc=2931;continue;}
case 2931:{f.Push(f.Locals[10]);f.Pc=2933;continue;}
case 2933:{f.Push(f.Locals[8]);f.Pc=2935;continue;}
case 2935:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2938);}
case 2938:{f.Push(f.Locals[0]);f.Pc=2939;continue;}
case 2939:{f.Push(f.Locals[10]);f.Pc=2941;continue;}
case 2941:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",2946);}
case 2946:{f.Pc=9090;continue;}
case 2949:{f.Push(f.Locals[3]);f.Pc=2950;continue;}
case 2950:{f.Push(JValue.R(rt.String("Fabricate")));f.Pc=2953;continue;}
case 2953:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2956);}
case 2956:{f.Pc=f.Pop().Int==0?3049:2959;continue;}
case 2959:{f.Push(f.Locals[3]);f.Pc=2960;continue;}
case 2960:{f.Push(JValue.R(rt.String(":")));f.Pc=2963;continue;}
case 2963:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2966);}
case 2966:{f.Locals[5]=f.Pop();f.Pc=2968;continue;}
case 2968:{f.Push(f.Locals[5]);f.Pc=2970;continue;}
case 2970:{f.Push(JValue.I(1));f.Pc=2971;continue;}
case 2971:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2972;continue;}
case 2972:{f.Locals[6]=f.Pop();f.Pc=2974;continue;}
case 2974:{f.Push(f.Locals[6]);f.Pc=2976;continue;}
case 2976:{f.Push(f.Locals[0]);f.Pc=2977;continue;}
case 2977:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2982);}
case 2982:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:2982:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2987);}
case 2987:{f.Locals[7]=f.Pop();f.Pc=2989;continue;}
case 2989:{f.Push(f.Locals[6]);f.Pc=2991;continue;}
case 2991:{f.Push(f.Locals[6]);f.Pc=2993;continue;}
case 2993:{f.Push(f.Locals[6]);f.Pc=2995;continue;}
case 2995:{f.Push(JValue.R(rt.String("1/1 colorless Servo artifact creature token")));f.Pc=2998;continue;}
case 2998:{return rt.Call(f,"forge/util/Lang","nounWithNumeral","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",3001);}
case 3001:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:3001:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",3006);}
case 3006:{f.Locals[8]=f.Pop();f.Pc=3008;continue;}
case 3008:{f.Push(f.Locals[7]);f.Pc=3010;continue;}
case 3010:{f.Push(f.Locals[1]);f.Pc=3011;continue;}
case 3011:{f.Push(f.Locals[2]);f.Pc=3012;continue;}
case 3012:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",3015);}
case 3015:{f.Locals[9]=f.Pop();f.Pc=3017;continue;}
case 3017:{f.Push(f.Locals[8]);f.Pc=3019;continue;}
case 3019:{f.Push(f.Locals[1]);f.Pc=3020;continue;}
case 3020:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",3023);}
case 3023:{f.Locals[10]=f.Pop();f.Pc=3025;continue;}
case 3025:{f.Push(f.Locals[10]);f.Pc=3027;continue;}
case 3027:{f.Push(f.Locals[2]);f.Pc=3028;continue;}
case 3028:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",3031);}
case 3031:{f.Push(f.Locals[9]);f.Pc=3033;continue;}
case 3033:{f.Push(f.Locals[10]);f.Pc=3035;continue;}
case 3035:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",3038);}
case 3038:{f.Push(f.Locals[0]);f.Pc=3039;continue;}
case 3039:{f.Push(f.Locals[9]);f.Pc=3041;continue;}
case 3041:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",3046);}
case 3046:{f.Pc=9090;continue;}
case 3049:{f.Push(f.Locals[3]);f.Pc=3050;continue;}
case 3050:{f.Push(JValue.R(rt.String("Fading")));f.Pc=3053;continue;}
case 3053:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3056);}
case 3056:{f.Pc=f.Pop().Int==0?3170:3059;continue;}
case 3059:{f.Push(JValue.R(rt.String("Mode$ Phase | Phase$ Upkeep | ValidPlayer$ You | TriggerZones$ Battlefield | Secondary$ True | TriggerDescription$ At the beginning of your upkeep, remove a fade counter from CARDNAME. If you can't, sacrifice CARDNAME.")));f.Pc=3062;continue;}
case 3062:{f.Locals[5]=f.Pop();f.Pc=3064;continue;}
case 3064:{f.Push(JValue.R(rt.String("DB$ RemoveCounter | Defined$ Self | CounterType$ FADE | CounterNum$ 1 | RememberRemoved$ True")));f.Pc=3067;continue;}
case 3067:{f.Locals[6]=f.Pop();f.Pc=3069;continue;}
case 3069:{f.Push(JValue.R(rt.String("DB$ Sacrifice | SacValid$ Self | ConditionCheckSVar$ FadingCheckSVar | ConditionSVarCompare$ EQ0")));f.Pc=3072;continue;}
case 3072:{f.Locals[7]=f.Pop();f.Pc=3074;continue;}
case 3074:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=3077;continue;}
case 3077:{f.Locals[8]=f.Pop();f.Pc=3079;continue;}
case 3079:{f.Push(JValue.R(rt.String("DB$ RemoveCounter | Defined$ Self | CounterType$ FADE | CounterNum$ 1 | RememberRemoved$ True")));f.Pc=3082;continue;}
case 3082:{f.Push(f.Locals[1]);f.Pc=3083;continue;}
case 3083:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",3086);}
case 3086:{f.Locals[9]=f.Pop();f.Pc=3088;continue;}
case 3088:{f.Push(JValue.R(rt.String("DB$ Sacrifice | SacValid$ Self | ConditionCheckSVar$ FadingCheckSVar | ConditionSVarCompare$ EQ0")));f.Pc=3091;continue;}
case 3091:{f.Push(f.Locals[1]);f.Pc=3092;continue;}
case 3092:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",3095);}
case 3095:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3098;continue;}
case 3098:{f.Locals[10]=f.Pop();f.Pc=3100;continue;}
case 3100:{f.Push(f.Locals[10]);f.Pc=3102;continue;}
case 3102:{f.Push(JValue.R(rt.String("FadingCheckSVar")));f.Pc=3105;continue;}
case 3105:{f.Push(JValue.R(rt.String("Count$RememberedSize")));f.Pc=3108;continue;}
case 3108:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",3111);}
case 3111:{f.Push(f.Locals[9]);f.Pc=3113;continue;}
case 3113:{f.Push(f.Locals[10]);f.Pc=3115;continue;}
case 3115:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",3118);}
case 3118:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=3121;continue;}
case 3121:{f.Push(f.Locals[1]);f.Pc=3122;continue;}
case 3122:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",3125);}
case 3125:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3128;continue;}
case 3128:{f.Locals[11]=f.Pop();f.Pc=3130;continue;}
case 3130:{f.Push(f.Locals[10]);f.Pc=3132;continue;}
case 3132:{f.Push(f.Locals[11]);f.Pc=3134;continue;}
case 3134:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",3137);}
case 3137:{f.Push(f.Locals[5]);f.Pc=3139;continue;}
case 3139:{f.Push(f.Locals[1]);f.Pc=3140;continue;}
case 3140:{f.Push(f.Locals[2]);f.Pc=3141;continue;}
case 3141:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",3144);}
case 3144:{f.Locals[12]=f.Pop();f.Pc=3146;continue;}
case 3146:{f.Push(f.Locals[9]);f.Pc=3148;continue;}
case 3148:{f.Push(f.Locals[2]);f.Pc=3149;continue;}
case 3149:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",3152);}
case 3152:{f.Push(f.Locals[12]);f.Pc=3154;continue;}
case 3154:{f.Push(f.Locals[9]);f.Pc=3156;continue;}
case 3156:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",3159);}
case 3159:{f.Push(f.Locals[0]);f.Pc=3160;continue;}
case 3160:{f.Push(f.Locals[12]);f.Pc=3162;continue;}
case 3162:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",3167);}
case 3167:{f.Pc=9090;continue;}
case 3170:{f.Push(f.Locals[3]);f.Pc=3171;continue;}
case 3171:{f.Push(JValue.R(rt.String("Firebending")));f.Pc=3174;continue;}
case 3174:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3177);}
case 3177:{f.Pc=f.Pop().Int==0?3318:3180;continue;}
case 3180:{f.Push(f.Locals[3]);f.Pc=3181;continue;}
case 3181:{f.Push(JValue.R(rt.String(":")));f.Pc=3184;continue;}
case 3184:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",3187);}
case 3187:{f.Locals[5]=f.Pop();f.Pc=3189;continue;}
case 3189:{f.Push(f.Locals[5]);f.Pc=3191;continue;}
case 3191:{f.Push(JValue.I(1));f.Pc=3192;continue;}
case 3192:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3193;continue;}
case 3193:{f.Locals[6]=f.Pop();f.Pc=3195;continue;}
case 3195:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3198;continue;}
case 3198:{f.StackOp("dup");f.Pc=3199;continue;}
case 3199:{f.Push(JValue.R(rt.String("Firebending ")));f.Pc=3202;continue;}
case 3202:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",3205);}
case 3205:{f.Locals[7]=f.Pop();f.Pc=3207;continue;}
case 3207:{f.Push(f.Locals[7]);f.Pc=3209;continue;}
case 3209:{f.Push(f.Locals[6]);f.Pc=3211;continue;}
case 3211:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3214);}
case 3214:{f.StackOp("pop");f.Pc=3215;continue;}
case 3215:{f.Push(f.Locals[5]);f.Pc=3217;continue;}
case 3217:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=3218;continue;}
case 3218:{f.Push(JValue.I(2));f.Pc=3219;continue;}
case 3219:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?3232:3222;continue;}
case 3222:{f.Push(f.Locals[7]);f.Pc=3224;continue;}
case 3224:{f.Push(f.Locals[5]);f.Pc=3226;continue;}
case 3226:{f.Push(JValue.I(2));f.Pc=3227;continue;}
case 3227:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3228;continue;}
case 3228:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3231);}
case 3231:{f.StackOp("pop");f.Pc=3232;continue;}
case 3232:{f.Push(f.Locals[7]);f.Pc=3234;continue;}
case 3234:{f.Push(JValue.R(rt.String(" (")));f.Pc=3237;continue;}
case 3237:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3240);}
case 3240:{f.Push(f.Locals[0]);f.Pc=3241;continue;}
case 3241:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",3246);}
case 3246:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3249);}
case 3249:{f.Push(JValue.R(rt.String(")")));f.Pc=3252;continue;}
case 3252:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3255);}
case 3255:{f.StackOp("pop");f.Pc=3256;continue;}
case 3256:{f.Push(f.Locals[7]);f.Pc=3258;continue;}
case 3258:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",3261);}
case 3261:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:3261:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",3266);}
case 3266:{f.Locals[8]=f.Pop();f.Pc=3268;continue;}
case 3268:{f.Push(f.Locals[6]);f.Pc=3270;continue;}
case 3270:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:3270:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",3275);}
case 3275:{f.Locals[9]=f.Pop();f.Pc=3277;continue;}
case 3277:{f.Push(f.Locals[8]);f.Pc=3279;continue;}
case 3279:{f.Push(f.Locals[1]);f.Pc=3280;continue;}
case 3280:{f.Push(f.Locals[2]);f.Pc=3281;continue;}
case 3281:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",3284);}
case 3284:{f.Locals[10]=f.Pop();f.Pc=3286;continue;}
case 3286:{f.Push(f.Locals[9]);f.Pc=3288;continue;}
case 3288:{f.Push(f.Locals[1]);f.Pc=3289;continue;}
case 3289:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",3292);}
case 3292:{f.Locals[11]=f.Pop();f.Pc=3294;continue;}
case 3294:{f.Push(f.Locals[11]);f.Pc=3296;continue;}
case 3296:{f.Push(f.Locals[2]);f.Pc=3297;continue;}
case 3297:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",3300);}
case 3300:{f.Push(f.Locals[10]);f.Pc=3302;continue;}
case 3302:{f.Push(f.Locals[11]);f.Pc=3304;continue;}
case 3304:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",3307);}
case 3307:{f.Push(f.Locals[0]);f.Pc=3308;continue;}
case 3308:{f.Push(f.Locals[10]);f.Pc=3310;continue;}
case 3310:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",3315);}
case 3315:{f.Pc=9090;continue;}
case 3318:{f.Push(f.Locals[3]);f.Pc=3319;continue;}
case 3319:{f.Push(JValue.R(rt.String("Flanking")));f.Pc=3322;continue;}
case 3322:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3325);}
case 3325:{f.Pc=f.Pop().Int==0?3388:3328;continue;}
case 3328:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3331;continue;}
case 3331:{f.StackOp("dup");f.Pc=3332;continue;}
case 3332:{f.Push(f.Locals[0]);f.Pc=3333;continue;}
case 3333:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",3338);}
case 3338:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:3338:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",3343);}
case 3343:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",3346);}
case 3346:{f.Locals[5]=f.Pop();f.Pc=3348;continue;}
case 3348:{f.Push(JValue.R(rt.String("DB$ Pump | Defined$ TriggeredBlockerLKICopy | NumAtt$ -1 | NumDef$ -1")));f.Pc=3351;continue;}
case 3351:{f.Locals[6]=f.Pop();f.Pc=3353;continue;}
case 3353:{f.Push(f.Locals[5]);f.Pc=3355;continue;}
case 3355:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",3358);}
case 3358:{f.Push(f.Locals[1]);f.Pc=3359;continue;}
case 3359:{f.Push(f.Locals[2]);f.Pc=3360;continue;}
case 3360:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",3363);}
case 3363:{f.Locals[7]=f.Pop();f.Pc=3365;continue;}
case 3365:{f.Push(f.Locals[7]);f.Pc=3367;continue;}
case 3367:{f.Push(JValue.R(rt.String("DB$ Pump | Defined$ TriggeredBlockerLKICopy | NumAtt$ -1 | NumDef$ -1")));f.Pc=3370;continue;}
case 3370:{f.Push(f.Locals[1]);f.Pc=3371;continue;}
case 3371:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",3374);}
case 3374:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",3377);}
case 3377:{f.Push(f.Locals[0]);f.Pc=3378;continue;}
case 3378:{f.Push(f.Locals[7]);f.Pc=3380;continue;}
case 3380:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",3385);}
case 3385:{f.Pc=9090;continue;}
case 3388:{f.Push(f.Locals[3]);f.Pc=3389;continue;}
case 3389:{f.Push(JValue.R(rt.String("For Mirrodin")));f.Pc=3392;continue;}
case 3392:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3395);}
case 3395:{f.Pc=f.Pop().Int==0?3547:3398;continue;}
case 3398:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3401;continue;}
case 3401:{f.StackOp("dup");f.Pc=3402;continue;}
case 3402:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",3405);}
case 3405:{f.Locals[5]=f.Pop();f.Pc=3407;continue;}
case 3407:{f.Push(f.Locals[5]);f.Pc=3409;continue;}
case 3409:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Destination$ Battlefield | ")));f.Pc=3412;continue;}
case 3412:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3415);}
case 3415:{f.StackOp("pop");f.Pc=3416;continue;}
case 3416:{f.Push(f.Locals[5]);f.Pc=3418;continue;}
case 3418:{f.Push(JValue.R(rt.String("ValidCard$ Card.Self | TriggerDescription$ ")));f.Pc=3421;continue;}
case 3421:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3424);}
case 3424:{f.StackOp("pop");f.Pc=3425;continue;}
case 3425:{f.Push(f.Locals[5]);f.Pc=3427;continue;}
case 3427:{f.Push(JValue.R(rt.String("For Mirrodin! (")));f.Pc=3430;continue;}
case 3430:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3433);}
case 3433:{f.Push(f.Locals[0]);f.Pc=3434;continue;}
case 3434:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",3439);}
case 3439:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3442);}
case 3442:{f.Push(JValue.R(rt.String(")")));f.Pc=3445;continue;}
case 3445:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3448);}
case 3448:{f.StackOp("pop");f.Pc=3449;continue;}
case 3449:{f.Push(JValue.R(rt.String("DB$ Token | TokenScript$ r_2_2_rebel | TokenOwner$ You | RememberTokens$ True")));f.Pc=3452;continue;}
case 3452:{f.Locals[6]=f.Pop();f.Pc=3454;continue;}
case 3454:{f.Push(JValue.R(rt.String("DB$ Token | TokenScript$ r_2_2_rebel | TokenOwner$ You | RememberTokens$ True")));f.Pc=3457;continue;}
case 3457:{f.Push(f.Locals[1]);f.Pc=3458;continue;}
case 3458:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",3461);}
case 3461:{f.Locals[7]=f.Pop();f.Pc=3463;continue;}
case 3463:{f.Push(JValue.R(rt.String("DB$ Attach | Defined$ Remembered")));f.Pc=3466;continue;}
case 3466:{f.Locals[8]=f.Pop();f.Pc=3468;continue;}
case 3468:{f.Push(JValue.R(rt.String("DB$ Attach | Defined$ Remembered")));f.Pc=3471;continue;}
case 3471:{f.Push(f.Locals[1]);f.Pc=3472;continue;}
case 3472:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",3475);}
case 3475:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3478;continue;}
case 3478:{f.Locals[9]=f.Pop();f.Pc=3480;continue;}
case 3480:{f.Push(f.Locals[7]);f.Pc=3482;continue;}
case 3482:{f.Push(f.Locals[9]);f.Pc=3484;continue;}
case 3484:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",3487);}
case 3487:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=3490;continue;}
case 3490:{f.Locals[10]=f.Pop();f.Pc=3492;continue;}
case 3492:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=3495;continue;}
case 3495:{f.Push(f.Locals[1]);f.Pc=3496;continue;}
case 3496:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",3499);}
case 3499:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3502;continue;}
case 3502:{f.Locals[11]=f.Pop();f.Pc=3504;continue;}
case 3504:{f.Push(f.Locals[9]);f.Pc=3506;continue;}
case 3506:{f.Push(f.Locals[11]);f.Pc=3508;continue;}
case 3508:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",3511);}
case 3511:{f.Push(f.Locals[5]);f.Pc=3513;continue;}
case 3513:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",3516);}
case 3516:{f.Push(f.Locals[1]);f.Pc=3517;continue;}
case 3517:{f.Push(f.Locals[2]);f.Pc=3518;continue;}
case 3518:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",3521);}
case 3521:{f.Locals[12]=f.Pop();f.Pc=3523;continue;}
case 3523:{f.Push(f.Locals[12]);f.Pc=3525;continue;}
case 3525:{f.Push(f.Locals[7]);f.Pc=3527;continue;}
case 3527:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",3530);}
case 3530:{f.Push(f.Locals[7]);f.Pc=3532;continue;}
case 3532:{f.Push(f.Locals[2]);f.Pc=3533;continue;}
case 3533:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",3536);}
case 3536:{f.Push(f.Locals[0]);f.Pc=3537;continue;}
case 3537:{f.Push(f.Locals[12]);f.Pc=3539;continue;}
case 3539:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",3544);}
case 3544:{f.Pc=9090;continue;}
case 3547:{f.Push(f.Locals[3]);f.Pc=3548;continue;}
case 3548:{f.Push(JValue.R(rt.String("Gift")));f.Pc=3551;continue;}
case 3551:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3554);}
case 3554:{f.Pc=f.Pop().Int==0?3735:3557;continue;}
case 3557:{f.Push(f.Locals[1]);f.Pc=3558;continue;}
case 3558:{f.Push(JValue.R(rt.String("GiftAbility")));f.Pc=3561;continue;}
case 3561:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3564);}
case 3564:{f.Push(f.Locals[1]);f.Pc=3565;continue;}
case 3565:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",3568);}
case 3568:{f.Locals[5]=f.Pop();f.Pc=3570;continue;}
case 3570:{f.Push(f.Locals[1]);f.Pc=3571;continue;}
case 3571:{return rt.Call(f,"forge/game/card/Card","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",3574);}
case 3574:{f.Push(JValue.R(rt.String("GiftAbility")));f.Pc=3577;continue;}
case 3577:{f.Push(f.Locals[5]);f.Pc=3579;continue;}
case 3579:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAdditionalAbility","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)V","invokevirtual",3582);}
case 3582:{f.Push(f.Locals[1]);f.Pc=3583;continue;}
case 3583:{return rt.Call(f,"forge/game/card/Card","isPermanent","()Z","invokevirtual",3586);}
case 3586:{f.Pc=f.Pop().Int!=0?3596:3589;continue;}
case 3589:{f.Push(f.Locals[5]);f.Pc=3591;continue;}
case 3591:{f.Push(f.Locals[0]);f.Pc=3592;continue;}
case 3592:{return rt.Call(f,"forge/game/spellability/SpellAbility","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",3595);}
case 3595:{return JStep.ReturnVoid;}
case 3596:{f.Push(f.Locals[5]);f.Pc=3598;continue;}
case 3598:{f.Push(JValue.R(rt.String("GiftDescription")));f.Pc=3601;continue;}
case 3601:{f.Push(JValue.R(rt.String("<missing description>")));f.Pc=3604;continue;}
case 3604:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3607);}
case 3607:{f.Locals[6]=f.Pop();f.Pc=3609;continue;}
case 3609:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3612;continue;}
case 3612:{f.StackOp("dup");f.Pc=3613;continue;}
case 3613:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",3616);}
case 3616:{f.Locals[7]=f.Pop();f.Pc=3618;continue;}
case 3618:{f.Push(f.Locals[7]);f.Pc=3620;continue;}
case 3620:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Destination$ Battlefield | ")));f.Pc=3623;continue;}
case 3623:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3626);}
case 3626:{f.StackOp("pop");f.Pc=3627;continue;}
case 3627:{f.Push(f.Locals[7]);f.Pc=3629;continue;}
case 3629:{f.Push(JValue.R(rt.String("ValidCard$ Card.Self+PromisedGift | Secondary$ True | TriggerDescription$ ")));f.Pc=3632;continue;}
case 3632:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3635);}
case 3635:{f.StackOp("pop");f.Pc=3636;continue;}
case 3636:{f.Push(f.Locals[7]);f.Pc=3638;continue;}
case 3638:{f.Push(JValue.R(rt.String("Gift ")));f.Pc=3641;continue;}
case 3641:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3644);}
case 3644:{f.Push(f.Locals[6]);f.Pc=3646;continue;}
case 3646:{f.Push(JValue.R(rt.String("(?i)an? .*")));f.Pc=3649;continue;}
case 3649:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",3652);}
case 3652:{f.Pc=f.Pop().Int==0?3661:3655;continue;}
case 3655:{f.Push(JValue.R(rt.String("")));f.Pc=3658;continue;}
case 3658:{f.Pc=3664;continue;}
case 3661:{f.Push(JValue.R(rt.String("a ")));f.Pc=3664;continue;}
case 3664:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3667);}
case 3667:{f.Push(f.Locals[6]);f.Pc=3669;continue;}
case 3669:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3672);}
case 3672:{f.Push(JValue.R(rt.String(" to ")));f.Pc=3675;continue;}
case 3675:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3678);}
case 3678:{f.Push(f.Locals[1]);f.Pc=3679;continue;}
case 3679:{return rt.Call(f,"forge/game/card/Card","getPromisedGift","()Lforge/game/player/Player;","invokevirtual",3682);}
case 3682:{f.Pc=f.Pop().Reference!=null?3691:3685;continue;}
case 3685:{f.Push(JValue.R(rt.String("an opponent")));f.Pc=3688;continue;}
case 3688:{f.Pc=3695;continue;}
case 3691:{f.Push(f.Locals[1]);f.Pc=3692;continue;}
case 3692:{return rt.Call(f,"forge/game/card/Card","getPromisedGift","()Lforge/game/player/Player;","invokevirtual",3695);}
case 3695:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",3698);}
case 3698:{f.StackOp("pop");f.Pc=3699;continue;}
case 3699:{f.Push(f.Locals[7]);f.Pc=3701;continue;}
case 3701:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",3704);}
case 3704:{f.Push(f.Locals[1]);f.Pc=3705;continue;}
case 3705:{f.Push(f.Locals[2]);f.Pc=3706;continue;}
case 3706:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",3709);}
case 3709:{f.Locals[8]=f.Pop();f.Pc=3711;continue;}
case 3711:{f.Push(f.Locals[8]);f.Pc=3713;continue;}
case 3713:{f.Push(f.Locals[5]);f.Pc=3715;continue;}
case 3715:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",3718);}
case 3718:{f.Push(f.Locals[5]);f.Pc=3720;continue;}
case 3720:{f.Push(f.Locals[2]);f.Pc=3721;continue;}
case 3721:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",3724);}
case 3724:{f.Push(f.Locals[0]);f.Pc=3725;continue;}
case 3725:{f.Push(f.Locals[8]);f.Pc=3727;continue;}
case 3727:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",3732);}
case 3732:{f.Pc=9090;continue;}
case 3735:{f.Push(f.Locals[3]);f.Pc=3736;continue;}
case 3736:{f.Push(JValue.R(rt.String("Graft")));f.Pc=3739;continue;}
case 3739:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3742);}
case 3742:{f.Pc=f.Pop().Int==0?3840:3745;continue;}
case 3745:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3748;continue;}
case 3748:{f.StackOp("dup");f.Pc=3749;continue;}
case 3749:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",3752);}
case 3752:{f.Locals[5]=f.Pop();f.Pc=3754;continue;}
case 3754:{f.Push(f.Locals[5]);f.Pc=3756;continue;}
case 3756:{f.Push(JValue.R(rt.String("DB$ MoveCounter | Source$ Self | Defined$ TriggeredCardLKICopy")));f.Pc=3759;continue;}
case 3759:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3762);}
case 3762:{f.StackOp("pop");f.Pc=3763;continue;}
case 3763:{f.Push(f.Locals[5]);f.Pc=3765;continue;}
case 3765:{f.Push(JValue.R(rt.String(" | CounterType$ P1P1 | CounterNum$ 1")));f.Pc=3768;continue;}
case 3768:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3771);}
case 3771:{f.StackOp("pop");f.Pc=3772;continue;}
case 3772:{f.Push(f.Locals[1]);f.Pc=3773;continue;}
case 3773:{f.Push(JValue.R(rt.String("AIGraftPreference")));f.Pc=3776;continue;}
case 3776:{return rt.Call(f,"forge/game/card/Card","hasSVar","(Ljava/lang/String;)Z","invokevirtual",3779);}
case 3779:{f.Pc=f.Pop().Int==0?3801:3782;continue;}
case 3782:{f.Push(f.Locals[5]);f.Pc=3784;continue;}
case 3784:{f.Push(JValue.R(rt.String(" | AILogic$ ")));f.Pc=3787;continue;}
case 3787:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3790);}
case 3790:{f.Push(f.Locals[1]);f.Pc=3791;continue;}
case 3791:{f.Push(JValue.R(rt.String("AIGraftPreference")));f.Pc=3794;continue;}
case 3794:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3797);}
case 3797:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3800);}
case 3800:{f.StackOp("pop");f.Pc=3801;continue;}
case 3801:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | ValidCard$ Creature.Other| Origin$ Any | Destination$ Battlefield | TriggerZones$ Battlefield | OptionalDecider$ You | IsPresent$ Card.Self+counters_GE1_P1P1| Secondary$ True | TriggerDescription$ Whenever another creature enters, you may move a +1/+1 counter from this creature onto it.")));f.Pc=3804;continue;}
case 3804:{f.Locals[6]=f.Pop();f.Pc=3806;continue;}
case 3806:{f.Push(f.Locals[6]);f.Pc=3808;continue;}
case 3808:{f.Push(f.Locals[1]);f.Pc=3809;continue;}
case 3809:{f.Push(f.Locals[2]);f.Pc=3810;continue;}
case 3810:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",3813);}
case 3813:{f.Locals[7]=f.Pop();f.Pc=3815;continue;}
case 3815:{f.Push(f.Locals[7]);f.Pc=3817;continue;}
case 3817:{f.Push(f.Locals[5]);f.Pc=3819;continue;}
case 3819:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",3822);}
case 3822:{f.Push(f.Locals[1]);f.Pc=3823;continue;}
case 3823:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",3826);}
case 3826:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",3829);}
case 3829:{f.Push(f.Locals[0]);f.Pc=3830;continue;}
case 3830:{f.Push(f.Locals[7]);f.Pc=3832;continue;}
case 3832:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",3837);}
case 3837:{f.Pc=9090;continue;}
case 3840:{f.Push(f.Locals[3]);f.Pc=3841;continue;}
case 3841:{f.Push(JValue.R(rt.String("Gravestorm")));f.Pc=3844;continue;}
case 3844:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3847);}
case 3847:{f.Pc=f.Pop().Int==0?3914:3850;continue;}
case 3850:{f.Push(f.Locals[0]);f.Pc=3851;continue;}
case 3851:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",3856);}
case 3856:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:3856:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",3861);}
case 3861:{f.Locals[5]=f.Pop();f.Pc=3863;continue;}
case 3863:{f.Push(JValue.R(rt.String("DB$ CopySpellAbility | Defined$ TriggeredSpellAbility | Amount$ GravestormCount | MayChooseTarget$ True")));f.Pc=3866;continue;}
case 3866:{f.Locals[6]=f.Pop();f.Pc=3868;continue;}
case 3868:{f.Push(f.Locals[6]);f.Pc=3870;continue;}
case 3870:{f.Push(f.Locals[1]);f.Pc=3871;continue;}
case 3871:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",3874);}
case 3874:{f.Locals[7]=f.Pop();f.Pc=3876;continue;}
case 3876:{f.Push(f.Locals[7]);f.Pc=3878;continue;}
case 3878:{f.Push(JValue.R(rt.String("GravestormCount")));f.Pc=3881;continue;}
case 3881:{f.Push(JValue.R(rt.String("Count$ThisTurnEntered_Graveyard_from_Battlefield_Permanent")));f.Pc=3884;continue;}
case 3884:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",3887);}
case 3887:{f.Push(f.Locals[5]);f.Pc=3889;continue;}
case 3889:{f.Push(f.Locals[1]);f.Pc=3890;continue;}
case 3890:{f.Push(f.Locals[2]);f.Pc=3891;continue;}
case 3891:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",3894);}
case 3894:{f.Locals[8]=f.Pop();f.Pc=3896;continue;}
case 3896:{f.Push(f.Locals[8]);f.Pc=3898;continue;}
case 3898:{f.Push(f.Locals[7]);f.Pc=3900;continue;}
case 3900:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",3903);}
case 3903:{f.Push(f.Locals[0]);f.Pc=3904;continue;}
case 3904:{f.Push(f.Locals[8]);f.Pc=3906;continue;}
case 3906:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",3911);}
case 3911:{f.Pc=9090;continue;}
case 3914:{f.Push(f.Locals[3]);f.Pc=3915;continue;}
case 3915:{f.Push(JValue.R(rt.String("Haunt")));f.Pc=3918;continue;}
case 3918:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3921);}
case 3921:{f.Pc=f.Pop().Int==0?4466:3924;continue;}
case 3924:{f.Push(f.Locals[3]);f.Pc=3925;continue;}
case 3925:{f.Push(JValue.R(rt.String(":")));f.Pc=3928;continue;}
case 3928:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",3931);}
case 3931:{f.Locals[5]=f.Pop();f.Pc=3933;continue;}
case 3933:{f.Push(f.Locals[5]);f.Pc=3935;continue;}
case 3935:{f.Push(JValue.I(1));f.Pc=3936;continue;}
case 3936:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3937;continue;}
case 3937:{f.Locals[6]=f.Pop();f.Pc=3939;continue;}
case 3939:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3942);}
case 3942:{f.Locals[7]=f.Pop();f.Pc=3944;continue;}
case 3944:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3947;continue;}
case 3947:{f.StackOp("dup");f.Pc=3948;continue;}
case 3948:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",3951);}
case 3951:{f.Locals[8]=f.Pop();f.Pc=3953;continue;}
case 3953:{f.Push(f.Locals[1]);f.Pc=3954;continue;}
case 3954:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",3957);}
case 3957:{f.Pc=f.Pop().Int==0?3988:3960;continue;}
case 3960:{f.Push(f.Locals[8]);f.Pc=3962;continue;}
case 3962:{f.Push(JValue.R(rt.String("When ")));f.Pc=3965;continue;}
case 3965:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3968);}
case 3968:{f.Push(f.Locals[1]);f.Pc=3969;continue;}
case 3969:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",3972);}
case 3972:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3975);}
case 3975:{f.StackOp("pop");f.Pc=3976;continue;}
case 3976:{f.Push(f.Locals[8]);f.Pc=3978;continue;}
case 3978:{f.Push(JValue.R(rt.String(" enters or the creature it haunts dies, ")));f.Pc=3981;continue;}
case 3981:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3984);}
case 3984:{f.StackOp("pop");f.Pc=3985;continue;}
case 3985:{f.Pc=4013;continue;}
case 3988:{f.Push(f.Locals[8]);f.Pc=3990;continue;}
case 3990:{f.Push(JValue.R(rt.String("When the creature ")));f.Pc=3993;continue;}
case 3993:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3996);}
case 3996:{f.Push(f.Locals[1]);f.Pc=3997;continue;}
case 3997:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",4000);}
case 4000:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4003);}
case 4003:{f.StackOp("pop");f.Pc=4004;continue;}
case 4004:{f.Push(f.Locals[8]);f.Pc=4006;continue;}
case 4006:{f.Push(JValue.R(rt.String(" haunts dies, ")));f.Pc=4009;continue;}
case 4009:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4012);}
case 4012:{f.StackOp("pop");f.Pc=4013;continue;}
case 4013:{f.Push(f.Locals[8]);f.Pc=4015;continue;}
case 4015:{f.Push(JValue.R(rt.String("ABILITY")));f.Pc=4018;continue;}
case 4018:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4021);}
case 4021:{f.StackOp("pop");f.Pc=4022;continue;}
case 4022:{f.Push(f.Locals[8]);f.Pc=4024;continue;}
case 4024:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",4027);}
case 4027:{f.Locals[9]=f.Pop();f.Pc=4029;continue;}
case 4029:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=4032;continue;}
case 4032:{f.StackOp("dup");f.Pc=4033;continue;}
case 4033:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",4036);}
case 4036:{f.Locals[10]=f.Pop();f.Pc=4038;continue;}
case 4038:{f.Push(f.Locals[10]);f.Pc=4040;continue;}
case 4040:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Origin$ Battlefield | Destination$ Graveyard | TriggerZones$ Exile")));f.Pc=4043;continue;}
case 4043:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4046);}
case 4046:{f.StackOp("pop");f.Pc=4047;continue;}
case 4047:{f.Push(f.Locals[10]);f.Pc=4049;continue;}
case 4049:{f.Push(JValue.R(rt.String(" | ValidCard$ Creature.HauntedBy | Execute$ ")));f.Pc=4052;continue;}
case 4052:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4055);}
case 4055:{f.Push(f.Locals[6]);f.Pc=4057;continue;}
case 4057:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4060);}
case 4060:{f.StackOp("pop");f.Pc=4061;continue;}
case 4061:{f.Push(f.Locals[10]);f.Pc=4063;continue;}
case 4063:{f.Push(JValue.R(rt.String(" | TriggerDescription$ ")));f.Pc=4066;continue;}
case 4066:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4069);}
case 4069:{f.Push(f.Locals[9]);f.Pc=4071;continue;}
case 4071:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4074);}
case 4074:{f.StackOp("pop");f.Pc=4075;continue;}
case 4075:{f.Push(f.Locals[10]);f.Pc=4077;continue;}
case 4077:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",4080);}
case 4080:{f.Push(f.Locals[1]);f.Pc=4081;continue;}
case 4081:{f.Push(f.Locals[2]);f.Pc=4082;continue;}
case 4082:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",4085);}
case 4085:{f.Locals[11]=f.Pop();f.Pc=4087;continue;}
case 4087:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=4090;continue;}
case 4090:{f.StackOp("dup");f.Pc=4091;continue;}
case 4091:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",4094);}
case 4094:{f.Locals[12]=f.Pop();f.Pc=4096;continue;}
case 4096:{f.Push(f.Locals[12]);f.Pc=4098;continue;}
case 4098:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Origin$ Exile | ")));f.Pc=4101;continue;}
case 4101:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4104);}
case 4104:{f.StackOp("pop");f.Pc=4105;continue;}
case 4105:{f.Push(f.Locals[12]);f.Pc=4107;continue;}
case 4107:{f.Push(JValue.R(rt.String("ValidCard$ Card.Self | Static$ True | Secondary$ True | ")));f.Pc=4110;continue;}
case 4110:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4113);}
case 4113:{f.StackOp("pop");f.Pc=4114;continue;}
case 4114:{f.Push(f.Locals[12]);f.Pc=4116;continue;}
case 4116:{f.Push(JValue.R(rt.String("TriggerDescription$ Blank")));f.Pc=4119;continue;}
case 4119:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4122);}
case 4122:{f.StackOp("pop");f.Pc=4123;continue;}
case 4123:{f.Push(f.Locals[12]);f.Pc=4125;continue;}
case 4125:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",4128);}
case 4128:{f.Push(f.Locals[1]);f.Pc=4129;continue;}
case 4129:{f.Push(f.Locals[2]);f.Pc=4130;continue;}
case 4130:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",4133);}
case 4133:{f.Locals[13]=f.Pop();f.Pc=4135;continue;}
case 4135:{f.Push(JValue.R(rt.String("DB$ Haunt")));f.Pc=4138;continue;}
case 4138:{f.Push(f.Locals[1]);f.Pc=4139;continue;}
case 4139:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",4142);}
case 4142:{f.Locals[14]=f.Pop();f.Pc=4144;continue;}
case 4144:{f.Push(f.Locals[13]);f.Pc=4146;continue;}
case 4146:{f.Push(f.Locals[14]);f.Pc=4148;continue;}
case 4148:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",4151);}
case 4151:{f.Push(f.Locals[7]);f.Pc=4153;continue;}
case 4153:{f.Push(f.Locals[13]);f.Pc=4155;continue;}
case 4155:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",4160);}
case 4160:{f.StackOp("pop");f.Pc=4161;continue;}
case 4161:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=4164;continue;}
case 4164:{f.StackOp("dup");f.Pc=4165;continue;}
case 4165:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",4168);}
case 4168:{f.Locals[15]=f.Pop();f.Pc=4170;continue;}
case 4170:{f.Push(f.Locals[15]);f.Pc=4172;continue;}
case 4172:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Origin$ Battlefield | ")));f.Pc=4175;continue;}
case 4175:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4178);}
case 4178:{f.StackOp("pop");f.Pc=4179;continue;}
case 4179:{f.Push(f.Locals[15]);f.Pc=4181;continue;}
case 4181:{f.Push(JValue.R(rt.String("ValidCard$ Creature.HauntedBy | Static$ True | Secondary$ True | ")));f.Pc=4184;continue;}
case 4184:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4187);}
case 4187:{f.StackOp("pop");f.Pc=4188;continue;}
case 4188:{f.Push(f.Locals[15]);f.Pc=4190;continue;}
case 4190:{f.Push(JValue.R(rt.String("TriggerDescription$ Blank")));f.Pc=4193;continue;}
case 4193:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4196);}
case 4196:{f.StackOp("pop");f.Pc=4197;continue;}
case 4197:{f.Push(f.Locals[15]);f.Pc=4199;continue;}
case 4199:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",4202);}
case 4202:{f.Push(f.Locals[1]);f.Pc=4203;continue;}
case 4203:{f.Push(f.Locals[2]);f.Pc=4204;continue;}
case 4204:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",4207);}
case 4207:{f.Locals[16]=f.Pop();f.Pc=4209;continue;}
case 4209:{f.Push(f.Locals[16]);f.Pc=4211;continue;}
case 4211:{f.Push(f.Locals[14]);f.Pc=4213;continue;}
case 4213:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",4216);}
case 4216:{f.Push(f.Locals[7]);f.Pc=4218;continue;}
case 4218:{f.Push(f.Locals[16]);f.Pc=4220;continue;}
case 4220:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",4225);}
case 4225:{f.StackOp("pop");f.Pc=4226;continue;}
case 4226:{f.Push(f.Locals[1]);f.Pc=4227;continue;}
case 4227:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",4230);}
case 4230:{f.Pc=f.Pop().Int==0?4295:4233;continue;}
case 4233:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=4236;continue;}
case 4236:{f.StackOp("dup");f.Pc=4237;continue;}
case 4237:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",4240);}
case 4240:{f.Locals[17]=f.Pop();f.Pc=4242;continue;}
case 4242:{f.Push(f.Locals[17]);f.Pc=4244;continue;}
case 4244:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Destination$ Battlefield | ValidCard$ Card.Self | Execute$ ")));f.Pc=4247;continue;}
case 4247:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4250);}
case 4250:{f.StackOp("pop");f.Pc=4251;continue;}
case 4251:{f.Push(f.Locals[17]);f.Pc=4253;continue;}
case 4253:{f.Push(f.Locals[6]);f.Pc=4255;continue;}
case 4255:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4258);}
case 4258:{f.Push(JValue.R(rt.String(" | Secondary$ True | TriggerDescription$ ")));f.Pc=4261;continue;}
case 4261:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4264);}
case 4264:{f.StackOp("pop");f.Pc=4265;continue;}
case 4265:{f.Push(f.Locals[17]);f.Pc=4267;continue;}
case 4267:{f.Push(f.Locals[9]);f.Pc=4269;continue;}
case 4269:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4272);}
case 4272:{f.StackOp("pop");f.Pc=4273;continue;}
case 4273:{f.Push(f.Locals[17]);f.Pc=4275;continue;}
case 4275:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",4278);}
case 4278:{f.Push(f.Locals[1]);f.Pc=4279;continue;}
case 4279:{f.Push(f.Locals[2]);f.Pc=4280;continue;}
case 4280:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",4283);}
case 4283:{f.Locals[18]=f.Pop();f.Pc=4285;continue;}
case 4285:{f.Push(f.Locals[7]);f.Pc=4287;continue;}
case 4287:{f.Push(f.Locals[18]);f.Pc=4289;continue;}
case 4289:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",4294);}
case 4294:{f.StackOp("pop");f.Pc=4295;continue;}
case 4295:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=4298;continue;}
case 4298:{f.StackOp("dup");f.Pc=4299;continue;}
case 4299:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",4302);}
case 4302:{f.Locals[17]=f.Pop();f.Pc=4304;continue;}
case 4304:{f.Push(f.Locals[17]);f.Pc=4306;continue;}
case 4306:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Origin$ ")));f.Pc=4309;continue;}
case 4309:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4312);}
case 4312:{f.StackOp("pop");f.Pc=4313;continue;}
case 4313:{f.Push(f.Locals[17]);f.Pc=4315;continue;}
case 4315:{f.Push(f.Locals[1]);f.Pc=4316;continue;}
case 4316:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",4319);}
case 4319:{f.Pc=f.Pop().Int==0?4328:4322;continue;}
case 4322:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=4325;continue;}
case 4325:{f.Pc=4331;continue;}
case 4328:{f.Push(JValue.R(rt.String("Stack | Fizzle$ False")));f.Pc=4331;continue;}
case 4331:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4334);}
case 4334:{f.StackOp("pop");f.Pc=4335;continue;}
case 4335:{f.Push(f.Locals[17]);f.Pc=4337;continue;}
case 4337:{f.Push(JValue.R(rt.String(" | Destination$ Graveyard | ValidCard$ Card.Self")));f.Pc=4340;continue;}
case 4340:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4343);}
case 4343:{f.StackOp("pop");f.Pc=4344;continue;}
case 4344:{f.Push(f.Locals[17]);f.Pc=4346;continue;}
case 4346:{f.Push(JValue.R(rt.String(" | Secondary$ True | TriggerDescription$ Haunt (")));f.Pc=4349;continue;}
case 4349:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4352);}
case 4352:{f.Push(f.Locals[0]);f.Pc=4353;continue;}
case 4353:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",4358);}
case 4358:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4361);}
case 4361:{f.Push(JValue.R(rt.String(")")));f.Pc=4364;continue;}
case 4364:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4367);}
case 4367:{f.StackOp("pop");f.Pc=4368;continue;}
case 4368:{f.Push(f.Locals[17]);f.Pc=4370;continue;}
case 4370:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",4373);}
case 4373:{f.Push(f.Locals[1]);f.Pc=4374;continue;}
case 4374:{f.Push(f.Locals[2]);f.Pc=4375;continue;}
case 4375:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",4378);}
case 4378:{f.Locals[18]=f.Pop();f.Pc=4380;continue;}
case 4380:{f.Push(JValue.R(rt.String("DB$ Haunt | ValidTgts$ Creature | TgtPrompt$ Choose target creature to haunt")));f.Pc=4383;continue;}
case 4383:{f.Locals[19]=f.Pop();f.Pc=4385;continue;}
case 4385:{f.Push(JValue.R(rt.String("DB$ Haunt | ValidTgts$ Creature | TgtPrompt$ Choose target creature to haunt")));f.Pc=4388;continue;}
case 4388:{f.Push(f.Locals[1]);f.Pc=4389;continue;}
case 4389:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",4392);}
case 4392:{f.Locals[20]=f.Pop();f.Pc=4394;continue;}
case 4394:{f.Push(f.Locals[18]);f.Pc=4396;continue;}
case 4396:{f.Push(f.Locals[20]);f.Pc=4398;continue;}
case 4398:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",4401);}
case 4401:{f.Push(f.Locals[7]);f.Pc=4403;continue;}
case 4403:{f.Push(f.Locals[18]);f.Pc=4405;continue;}
case 4405:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",4410);}
case 4410:{f.StackOp("pop");f.Pc=4411;continue;}
case 4411:{f.Push(f.Locals[7]);f.Pc=4413;continue;}
case 4413:{f.Push(f.Locals[11]);f.Pc=4415;continue;}
case 4415:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",4420);}
case 4420:{f.StackOp("pop");f.Pc=4421;continue;}
case 4421:{f.Push(f.Locals[7]);f.Pc=4423;continue;}
case 4423:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",4428);}
case 4428:{f.Locals[21]=f.Pop();f.Pc=4430;continue;}
case 4430:{f.Push(f.Locals[21]);f.Pc=4432;continue;}
case 4432:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",4437);}
case 4437:{f.Pc=f.Pop().Int==0?4463:4440;continue;}
case 4440:{f.Push(f.Locals[21]);f.Pc=4442;continue;}
case 4442:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",4447);}
case 4447:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4450;continue;}
case 4450:{f.Locals[22]=f.Pop();f.Pc=4452;continue;}
case 4452:{f.Push(f.Locals[0]);f.Pc=4453;continue;}
case 4453:{f.Push(f.Locals[22]);f.Pc=4455;continue;}
case 4455:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",4460);}
case 4460:{f.Pc=4430;continue;}
case 4463:{f.Pc=9090;continue;}
case 4466:{f.Push(f.Locals[3]);f.Pc=4467;continue;}
case 4467:{f.Push(JValue.R(rt.String("Hideaway")));f.Pc=4470;continue;}
case 4470:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",4473);}
case 4473:{f.Pc=f.Pop().Int==0?4701:4476;continue;}
case 4476:{f.Push(f.Locals[3]);f.Pc=4477;continue;}
case 4477:{f.Push(JValue.R(rt.String(":")));f.Pc=4480;continue;}
case 4480:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",4483);}
case 4483:{f.Locals[5]=f.Pop();f.Pc=4485;continue;}
case 4485:{f.Push(f.Locals[5]);f.Pc=4487;continue;}
case 4487:{f.Push(JValue.I(1));f.Pc=4488;continue;}
case 4488:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4489;continue;}
case 4489:{f.Locals[6]=f.Pop();f.Pc=4491;continue;}
case 4491:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",4494);}
case 4494:{f.Locals[7]=f.Pop();f.Pc=4496;continue;}
case 4496:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=4499;continue;}
case 4499:{f.StackOp("dup");f.Pc=4500;continue;}
case 4500:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",4503);}
case 4503:{f.Locals[8]=f.Pop();f.Pc=4505;continue;}
case 4505:{f.Push(f.Locals[8]);f.Pc=4507;continue;}
case 4507:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Destination$ Battlefield | ValidCard$ Card.Self | Secondary$ True | ")));f.Pc=4510;continue;}
case 4510:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4513);}
case 4513:{f.StackOp("pop");f.Pc=4514;continue;}
case 4514:{f.Push(f.Locals[8]);f.Pc=4516;continue;}
case 4516:{f.Push(JValue.R(rt.String("TriggerDescription$ Hideaway ")));f.Pc=4519;continue;}
case 4519:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4522);}
case 4522:{f.Push(f.Locals[6]);f.Pc=4524;continue;}
case 4524:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4527);}
case 4527:{f.Push(JValue.R(rt.String(" (")));f.Pc=4530;continue;}
case 4530:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4533);}
case 4533:{f.Push(f.Locals[0]);f.Pc=4534;continue;}
case 4534:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",4539);}
case 4539:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4542);}
case 4542:{f.Push(JValue.R(rt.String(")")));f.Pc=4545;continue;}
case 4545:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4548);}
case 4548:{f.StackOp("pop");f.Pc=4549;continue;}
case 4549:{f.Push(f.Locals[8]);f.Pc=4551;continue;}
case 4551:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",4554);}
case 4554:{f.Push(f.Locals[1]);f.Pc=4555;continue;}
case 4555:{f.Push(f.Locals[2]);f.Pc=4556;continue;}
case 4556:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",4559);}
case 4559:{f.Locals[9]=f.Pop();f.Pc=4561;continue;}
case 4561:{f.Push(f.Locals[6]);f.Pc=4563;continue;}
case 4563:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:4563:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",4568);}
case 4568:{f.Locals[10]=f.Pop();f.Pc=4570;continue;}
case 4570:{f.Push(JValue.R(rt.String("DB$ Effect | StaticAbilities$ STHideawayEffectLookAtCard | ForgetOnMoved$ Exile | RememberObjects$ Remembered | Duration$ Permanent")));f.Pc=4573;continue;}
case 4573:{f.Locals[11]=f.Pop();f.Pc=4575;continue;}
case 4575:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=4578;continue;}
case 4578:{f.Locals[12]=f.Pop();f.Pc=4580;continue;}
case 4580:{f.Push(JValue.R(rt.String("Mode$ Continuous | Affected$ Card.IsRemembered | MayLookAt$ EffectSourceController | EffectZone$ Command | AffectedZone$ Exile | Description$ Any player who has controlled the permanent that exiled this card may look at this card in the exile zone.")));f.Pc=4583;continue;}
case 4583:{f.Locals[13]=f.Pop();f.Pc=4585;continue;}
case 4585:{f.Push(f.Locals[10]);f.Pc=4587;continue;}
case 4587:{f.Push(f.Locals[1]);f.Pc=4588;continue;}
case 4588:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",4591);}
case 4591:{f.Locals[14]=f.Pop();f.Pc=4593;continue;}
case 4593:{f.Push(f.Locals[11]);f.Pc=4595;continue;}
case 4595:{f.Push(f.Locals[1]);f.Pc=4596;continue;}
case 4596:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",4599);}
case 4599:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4602;continue;}
case 4602:{f.Locals[15]=f.Pop();f.Pc=4604;continue;}
case 4604:{f.Push(f.Locals[15]);f.Pc=4606;continue;}
case 4606:{f.Push(JValue.R(rt.String("STHideawayEffectLookAtCard")));f.Pc=4609;continue;}
case 4609:{f.Push(f.Locals[13]);f.Pc=4611;continue;}
case 4611:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",4614);}
case 4614:{f.Push(f.Locals[12]);f.Pc=4616;continue;}
case 4616:{f.Push(f.Locals[1]);f.Pc=4617;continue;}
case 4617:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",4620);}
case 4620:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4623;continue;}
case 4623:{f.Locals[16]=f.Pop();f.Pc=4625;continue;}
case 4625:{f.Push(f.Locals[14]);f.Pc=4627;continue;}
case 4627:{f.Push(f.Locals[15]);f.Pc=4629;continue;}
case 4629:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",4632);}
case 4632:{f.Push(f.Locals[15]);f.Pc=4634;continue;}
case 4634:{f.Push(f.Locals[16]);f.Pc=4636;continue;}
case 4636:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",4639);}
case 4639:{f.Push(f.Locals[9]);f.Pc=4641;continue;}
case 4641:{f.Push(f.Locals[14]);f.Pc=4643;continue;}
case 4643:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",4646);}
case 4646:{f.Push(f.Locals[7]);f.Pc=4648;continue;}
case 4648:{f.Push(f.Locals[9]);f.Pc=4650;continue;}
case 4650:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",4655);}
case 4655:{f.StackOp("pop");f.Pc=4656;continue;}
case 4656:{f.Push(f.Locals[7]);f.Pc=4658;continue;}
case 4658:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",4663);}
case 4663:{f.Locals[17]=f.Pop();f.Pc=4665;continue;}
case 4665:{f.Push(f.Locals[17]);f.Pc=4667;continue;}
case 4667:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",4672);}
case 4672:{f.Pc=f.Pop().Int==0?4698:4675;continue;}
case 4675:{f.Push(f.Locals[17]);f.Pc=4677;continue;}
case 4677:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",4682);}
case 4682:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4685;continue;}
case 4685:{f.Locals[18]=f.Pop();f.Pc=4687;continue;}
case 4687:{f.Push(f.Locals[0]);f.Pc=4688;continue;}
case 4688:{f.Push(f.Locals[18]);f.Pc=4690;continue;}
case 4690:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",4695);}
case 4695:{f.Pc=4665;continue;}
case 4698:{f.Pc=9090;continue;}
case 4701:{f.Push(f.Locals[3]);f.Pc=4702;continue;}
case 4702:{f.Push(JValue.R(rt.String("Increment")));f.Pc=4705;continue;}
case 4705:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",4708);}
case 4708:{f.Pc=f.Pop().Int==0?4761:4711;continue;}
case 4711:{f.Push(f.Locals[0]);f.Pc=4712;continue;}
case 4712:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",4717);}
case 4717:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:4717:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",4722);}
case 4722:{f.Locals[5]=f.Pop();f.Pc=4724;continue;}
case 4724:{f.Push(JValue.R(rt.String("DB$ PutCounter | CounterType$ P1P1 | CounterNum$ 1")));f.Pc=4727;continue;}
case 4727:{f.Locals[6]=f.Pop();f.Pc=4729;continue;}
case 4729:{f.Push(f.Locals[5]);f.Pc=4731;continue;}
case 4731:{f.Push(f.Locals[1]);f.Pc=4732;continue;}
case 4732:{f.Push(f.Locals[2]);f.Pc=4733;continue;}
case 4733:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",4736);}
case 4736:{f.Locals[7]=f.Pop();f.Pc=4738;continue;}
case 4738:{f.Push(f.Locals[7]);f.Pc=4740;continue;}
case 4740:{f.Push(JValue.R(rt.String("DB$ PutCounter | CounterType$ P1P1 | CounterNum$ 1")));f.Pc=4743;continue;}
case 4743:{f.Push(f.Locals[1]);f.Pc=4744;continue;}
case 4744:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",4747);}
case 4747:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",4750);}
case 4750:{f.Push(f.Locals[0]);f.Pc=4751;continue;}
case 4751:{f.Push(f.Locals[7]);f.Pc=4753;continue;}
case 4753:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",4758);}
case 4758:{f.Pc=9090;continue;}
case 4761:{f.Push(f.Locals[3]);f.Pc=4762;continue;}
case 4762:{f.Push(JValue.R(rt.String("Ingest")));f.Pc=4765;continue;}
case 4765:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",4768);}
case 4768:{f.Pc=f.Pop().Int==0?4821:4771;continue;}
case 4771:{f.Push(f.Locals[0]);f.Pc=4772;continue;}
case 4772:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",4777);}
case 4777:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:4777:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",4782);}
case 4782:{f.Locals[5]=f.Pop();f.Pc=4784;continue;}
case 4784:{f.Push(JValue.R(rt.String("DB$ Dig | DigNum$ 1 | ChangeNum$ All | DestinationZone$ Exile | Defined$ TriggeredTarget")));f.Pc=4787;continue;}
case 4787:{f.Locals[6]=f.Pop();f.Pc=4789;continue;}
case 4789:{f.Push(f.Locals[5]);f.Pc=4791;continue;}
case 4791:{f.Push(f.Locals[1]);f.Pc=4792;continue;}
case 4792:{f.Push(f.Locals[2]);f.Pc=4793;continue;}
case 4793:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",4796);}
case 4796:{f.Locals[7]=f.Pop();f.Pc=4798;continue;}
case 4798:{f.Push(f.Locals[7]);f.Pc=4800;continue;}
case 4800:{f.Push(JValue.R(rt.String("DB$ Dig | DigNum$ 1 | ChangeNum$ All | DestinationZone$ Exile | Defined$ TriggeredTarget")));f.Pc=4803;continue;}
case 4803:{f.Push(f.Locals[1]);f.Pc=4804;continue;}
case 4804:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",4807);}
case 4807:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",4810);}
case 4810:{f.Push(f.Locals[0]);f.Pc=4811;continue;}
case 4811:{f.Push(f.Locals[7]);f.Pc=4813;continue;}
case 4813:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",4818);}
case 4818:{f.Pc=9090;continue;}
case 4821:{f.Push(f.Locals[3]);f.Pc=4822;continue;}
case 4822:{f.Push(JValue.R(rt.String("Impending")));f.Pc=4825;continue;}
case 4825:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",4828);}
case 4828:{f.Pc=f.Pop().Int==0?4874:4831;continue;}
case 4831:{f.Push(JValue.R(rt.String("Mode$ Phase | Phase$ End of Turn | ValidPlayer$ You | TriggerZones$ Battlefield | IsPresent$ Card.Self+impended+counters_GE1_TIME | Secondary$ True | TriggerDescription$ At the beginning of your end step, remove a time counter from it.")));f.Pc=4834;continue;}
case 4834:{f.Locals[5]=f.Pop();f.Pc=4836;continue;}
case 4836:{f.Push(JValue.R(rt.String("DB$ RemoveCounter | Defined$ Self | CounterType$ TIME | CounterNum$ 1")));f.Pc=4839;continue;}
case 4839:{f.Locals[6]=f.Pop();f.Pc=4841;continue;}
case 4841:{f.Push(JValue.R(rt.String("Mode$ Phase | Phase$ End of Turn | ValidPlayer$ You | TriggerZones$ Battlefield | IsPresent$ Card.Self+impended+counters_GE1_TIME | Secondary$ True | TriggerDescription$ At the beginning of your end step, remove a time counter from it.")));f.Pc=4844;continue;}
case 4844:{f.Push(f.Locals[1]);f.Pc=4845;continue;}
case 4845:{f.Push(f.Locals[2]);f.Pc=4846;continue;}
case 4846:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",4849);}
case 4849:{f.Locals[7]=f.Pop();f.Pc=4851;continue;}
case 4851:{f.Push(f.Locals[7]);f.Pc=4853;continue;}
case 4853:{f.Push(JValue.R(rt.String("DB$ RemoveCounter | Defined$ Self | CounterType$ TIME | CounterNum$ 1")));f.Pc=4856;continue;}
case 4856:{f.Push(f.Locals[1]);f.Pc=4857;continue;}
case 4857:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",4860);}
case 4860:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",4863);}
case 4863:{f.Push(f.Locals[0]);f.Pc=4864;continue;}
case 4864:{f.Push(f.Locals[7]);f.Pc=4866;continue;}
case 4866:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",4871);}
case 4871:{f.Pc=9090;continue;}
case 4874:{f.Push(f.Locals[3]);f.Pc=4875;continue;}
case 4875:{f.Push(JValue.R(rt.String("Job select")));f.Pc=4878;continue;}
case 4878:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",4881);}
case 4881:{f.Pc=f.Pop().Int==0?5033:4884;continue;}
case 4884:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=4887;continue;}
case 4887:{f.StackOp("dup");f.Pc=4888;continue;}
case 4888:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",4891);}
case 4891:{f.Locals[5]=f.Pop();f.Pc=4893;continue;}
case 4893:{f.Push(f.Locals[5]);f.Pc=4895;continue;}
case 4895:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Destination$ Battlefield | ")));f.Pc=4898;continue;}
case 4898:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4901);}
case 4901:{f.StackOp("pop");f.Pc=4902;continue;}
case 4902:{f.Push(f.Locals[5]);f.Pc=4904;continue;}
case 4904:{f.Push(JValue.R(rt.String("ValidCard$ Card.Self | TriggerDescription$ ")));f.Pc=4907;continue;}
case 4907:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4910);}
case 4910:{f.StackOp("pop");f.Pc=4911;continue;}
case 4911:{f.Push(f.Locals[5]);f.Pc=4913;continue;}
case 4913:{f.Push(JValue.R(rt.String("Job select (")));f.Pc=4916;continue;}
case 4916:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4919);}
case 4919:{f.Push(f.Locals[0]);f.Pc=4920;continue;}
case 4920:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",4925);}
case 4925:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4928);}
case 4928:{f.Push(JValue.R(rt.String(")")));f.Pc=4931;continue;}
case 4931:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4934);}
case 4934:{f.StackOp("pop");f.Pc=4935;continue;}
case 4935:{f.Push(JValue.R(rt.String("DB$ Token | TokenScript$ c_1_1_hero | TokenOwner$ You | RememberTokens$ True")));f.Pc=4938;continue;}
case 4938:{f.Locals[6]=f.Pop();f.Pc=4940;continue;}
case 4940:{f.Push(JValue.R(rt.String("DB$ Token | TokenScript$ c_1_1_hero | TokenOwner$ You | RememberTokens$ True")));f.Pc=4943;continue;}
case 4943:{f.Push(f.Locals[1]);f.Pc=4944;continue;}
case 4944:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",4947);}
case 4947:{f.Locals[7]=f.Pop();f.Pc=4949;continue;}
case 4949:{f.Push(JValue.R(rt.String("DB$ Attach | Defined$ Remembered")));f.Pc=4952;continue;}
case 4952:{f.Locals[8]=f.Pop();f.Pc=4954;continue;}
case 4954:{f.Push(JValue.R(rt.String("DB$ Attach | Defined$ Remembered")));f.Pc=4957;continue;}
case 4957:{f.Push(f.Locals[1]);f.Pc=4958;continue;}
case 4958:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",4961);}
case 4961:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4964;continue;}
case 4964:{f.Locals[9]=f.Pop();f.Pc=4966;continue;}
case 4966:{f.Push(f.Locals[7]);f.Pc=4968;continue;}
case 4968:{f.Push(f.Locals[9]);f.Pc=4970;continue;}
case 4970:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",4973);}
case 4973:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=4976;continue;}
case 4976:{f.Locals[10]=f.Pop();f.Pc=4978;continue;}
case 4978:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=4981;continue;}
case 4981:{f.Push(f.Locals[1]);f.Pc=4982;continue;}
case 4982:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",4985);}
case 4985:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4988;continue;}
case 4988:{f.Locals[11]=f.Pop();f.Pc=4990;continue;}
case 4990:{f.Push(f.Locals[9]);f.Pc=4992;continue;}
case 4992:{f.Push(f.Locals[11]);f.Pc=4994;continue;}
case 4994:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",4997);}
case 4997:{f.Push(f.Locals[5]);f.Pc=4999;continue;}
case 4999:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",5002);}
case 5002:{f.Push(f.Locals[1]);f.Pc=5003;continue;}
case 5003:{f.Push(f.Locals[2]);f.Pc=5004;continue;}
case 5004:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",5007);}
case 5007:{f.Locals[12]=f.Pop();f.Pc=5009;continue;}
case 5009:{f.Push(f.Locals[12]);f.Pc=5011;continue;}
case 5011:{f.Push(f.Locals[7]);f.Pc=5013;continue;}
case 5013:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",5016);}
case 5016:{f.Push(f.Locals[7]);f.Pc=5018;continue;}
case 5018:{f.Push(f.Locals[2]);f.Pc=5019;continue;}
case 5019:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",5022);}
case 5022:{f.Push(f.Locals[0]);f.Pc=5023;continue;}
case 5023:{f.Push(f.Locals[12]);f.Pc=5025;continue;}
case 5025:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",5030);}
case 5030:{f.Pc=9090;continue;}
case 5033:{f.Push(f.Locals[3]);f.Pc=5034;continue;}
case 5034:{f.Push(JValue.R(rt.String("Living Weapon")));f.Pc=5037;continue;}
case 5037:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5040);}
case 5040:{f.Pc=f.Pop().Int==0?5207:5043;continue;}
case 5043:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=5046;continue;}
case 5046:{f.StackOp("dup");f.Pc=5047;continue;}
case 5047:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",5050);}
case 5050:{f.Locals[5]=f.Pop();f.Pc=5052;continue;}
case 5052:{f.Push(f.Locals[5]);f.Pc=5054;continue;}
case 5054:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Destination$ Battlefield | ")));f.Pc=5057;continue;}
case 5057:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5060);}
case 5060:{f.StackOp("pop");f.Pc=5061;continue;}
case 5061:{f.Push(f.Locals[5]);f.Pc=5063;continue;}
case 5063:{f.Push(JValue.R(rt.String("ValidCard$ Card.Self | Secondary$ True | TriggerDescription$ ")));f.Pc=5066;continue;}
case 5066:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5069);}
case 5069:{f.StackOp("pop");f.Pc=5070;continue;}
case 5070:{f.Push(f.Locals[5]);f.Pc=5072;continue;}
case 5072:{f.Push(JValue.R(rt.String("Living Weapon (")));f.Pc=5075;continue;}
case 5075:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5078);}
case 5078:{f.Push(f.Locals[0]);f.Pc=5079;continue;}
case 5079:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",5084);}
case 5084:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5087);}
case 5087:{f.Push(JValue.R(rt.String(")")));f.Pc=5090;continue;}
case 5090:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5093);}
case 5093:{f.StackOp("pop");f.Pc=5094;continue;}
case 5094:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=5097;continue;}
case 5097:{f.StackOp("dup");f.Pc=5098;continue;}
case 5098:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",5101);}
case 5101:{f.Locals[6]=f.Pop();f.Pc=5103;continue;}
case 5103:{f.Push(f.Locals[6]);f.Pc=5105;continue;}
case 5105:{f.Push(JValue.R(rt.String("DB$ Token | TokenScript$ b_0_0_phyrexian_germ | TokenOwner$ You | RememberTokens$ True")));f.Pc=5108;continue;}
case 5108:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5111);}
case 5111:{f.StackOp("pop");f.Pc=5112;continue;}
case 5112:{f.Push(f.Locals[6]);f.Pc=5114;continue;}
case 5114:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",5117);}
case 5117:{f.Push(f.Locals[1]);f.Pc=5118;continue;}
case 5118:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",5121);}
case 5121:{f.Locals[7]=f.Pop();f.Pc=5123;continue;}
case 5123:{f.Push(JValue.R(rt.String("DB$ Attach | Defined$ Remembered")));f.Pc=5126;continue;}
case 5126:{f.Locals[8]=f.Pop();f.Pc=5128;continue;}
case 5128:{f.Push(JValue.R(rt.String("DB$ Attach | Defined$ Remembered")));f.Pc=5131;continue;}
case 5131:{f.Push(f.Locals[1]);f.Pc=5132;continue;}
case 5132:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",5135);}
case 5135:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5138;continue;}
case 5138:{f.Locals[9]=f.Pop();f.Pc=5140;continue;}
case 5140:{f.Push(f.Locals[7]);f.Pc=5142;continue;}
case 5142:{f.Push(f.Locals[9]);f.Pc=5144;continue;}
case 5144:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",5147);}
case 5147:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=5150;continue;}
case 5150:{f.Locals[10]=f.Pop();f.Pc=5152;continue;}
case 5152:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=5155;continue;}
case 5155:{f.Push(f.Locals[1]);f.Pc=5156;continue;}
case 5156:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",5159);}
case 5159:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5162;continue;}
case 5162:{f.Locals[11]=f.Pop();f.Pc=5164;continue;}
case 5164:{f.Push(f.Locals[9]);f.Pc=5166;continue;}
case 5166:{f.Push(f.Locals[11]);f.Pc=5168;continue;}
case 5168:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",5171);}
case 5171:{f.Push(f.Locals[5]);f.Pc=5173;continue;}
case 5173:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",5176);}
case 5176:{f.Push(f.Locals[1]);f.Pc=5177;continue;}
case 5177:{f.Push(f.Locals[2]);f.Pc=5178;continue;}
case 5178:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",5181);}
case 5181:{f.Locals[12]=f.Pop();f.Pc=5183;continue;}
case 5183:{f.Push(f.Locals[12]);f.Pc=5185;continue;}
case 5185:{f.Push(f.Locals[7]);f.Pc=5187;continue;}
case 5187:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",5190);}
case 5190:{f.Push(f.Locals[7]);f.Pc=5192;continue;}
case 5192:{f.Push(f.Locals[2]);f.Pc=5193;continue;}
case 5193:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",5196);}
case 5196:{f.Push(f.Locals[0]);f.Pc=5197;continue;}
case 5197:{f.Push(f.Locals[12]);f.Pc=5199;continue;}
case 5199:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",5204);}
case 5204:{f.Pc=9090;continue;}
case 5207:{f.Push(f.Locals[3]);f.Pc=5208;continue;}
case 5208:{f.Push(JValue.R(rt.String("Madness")));f.Pc=5211;continue;}
case 5211:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",5214);}
case 5214:{f.Pc=f.Pop().Int==0?5397:5217;continue;}
case 5217:{f.Push(f.Locals[3]);f.Pc=5218;continue;}
case 5218:{f.Push(JValue.R(rt.String(":")));f.Pc=5221;continue;}
case 5221:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",5224);}
case 5224:{f.Locals[5]=f.Pop();f.Pc=5226;continue;}
case 5226:{f.Push(f.Locals[5]);f.Pc=5228;continue;}
case 5228:{f.Push(JValue.I(1));f.Pc=5229;continue;}
case 5229:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5230;continue;}
case 5230:{f.Locals[6]=f.Pop();f.Pc=5232;continue;}
case 5232:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=5235;continue;}
case 5235:{f.StackOp("dup");f.Pc=5236;continue;}
case 5236:{f.Push(JValue.R(rt.String("Play Madness")));f.Pc=5239;continue;}
case 5239:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",5242);}
case 5242:{f.Locals[7]=f.Pop();f.Pc=5244;continue;}
case 5244:{f.Push(JValue.R(rt.String("ManaCost")));f.Pc=5247;continue;}
case 5247:{f.Push(f.Locals[6]);f.Pc=5249;continue;}
case 5249:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5252);}
case 5252:{f.Pc=f.Pop().Int!=0?5272:5255;continue;}
case 5255:{f.Push(f.Locals[7]);f.Pc=5257;continue;}
case 5257:{f.Push(JValue.R(rt.String(" ")));f.Pc=5260;continue;}
case 5260:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5263);}
case 5263:{f.Push(f.Locals[6]);f.Pc=5265;continue;}
case 5265:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",5268);}
case 5268:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5271);}
case 5271:{f.StackOp("pop");f.Pc=5272;continue;}
case 5272:{f.Push(f.Locals[7]);f.Pc=5274;continue;}
case 5274:{f.Push(f.Locals[1]);f.Pc=5275;continue;}
case 5275:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",5278);}
case 5278:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:5278:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",5283);}
case 5283:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5286);}
case 5286:{f.StackOp("pop");f.Pc=5287;continue;}
case 5287:{f.Push(f.Locals[7]);f.Pc=5289;continue;}
case 5289:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",5292);}
case 5292:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:5292:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",5297);}
case 5297:{f.Locals[8]=f.Pop();f.Pc=5299;continue;}
case 5299:{f.Push(f.Locals[6]);f.Pc=5301;continue;}
case 5301:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:5301:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",5306);}
case 5306:{f.Locals[9]=f.Pop();f.Pc=5308;continue;}
case 5308:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self.StrictlySelf | Origin$ Exile | Destination$ Graveyard | TrackDiscarded$ True | ConditionDefined$ Remembered | ConditionPresent$ Card Card | ConditionCompare$ EQ0")));f.Pc=5311;continue;}
case 5311:{f.Locals[10]=f.Pop();f.Pc=5313;continue;}
case 5313:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=5316;continue;}
case 5316:{f.Locals[11]=f.Pop();f.Pc=5318;continue;}
case 5318:{f.Push(f.Locals[8]);f.Pc=5320;continue;}
case 5320:{f.Push(f.Locals[1]);f.Pc=5321;continue;}
case 5321:{f.Push(f.Locals[2]);f.Pc=5322;continue;}
case 5322:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",5325);}
case 5325:{f.Locals[12]=f.Pop();f.Pc=5327;continue;}
case 5327:{f.Push(f.Locals[9]);f.Pc=5329;continue;}
case 5329:{f.Push(f.Locals[1]);f.Pc=5330;continue;}
case 5330:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",5333);}
case 5333:{f.Locals[13]=f.Pop();f.Pc=5335;continue;}
case 5335:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self.StrictlySelf | Origin$ Exile | Destination$ Graveyard | TrackDiscarded$ True | ConditionDefined$ Remembered | ConditionPresent$ Card Card | ConditionCompare$ EQ0")));f.Pc=5338;continue;}
case 5338:{f.Push(f.Locals[1]);f.Pc=5339;continue;}
case 5339:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",5342);}
case 5342:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5345;continue;}
case 5345:{f.Locals[14]=f.Pop();f.Pc=5347;continue;}
case 5347:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=5350;continue;}
case 5350:{f.Push(f.Locals[1]);f.Pc=5351;continue;}
case 5351:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",5354);}
case 5354:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5357;continue;}
case 5357:{f.Locals[15]=f.Pop();f.Pc=5359;continue;}
case 5359:{f.Push(f.Locals[14]);f.Pc=5361;continue;}
case 5361:{f.Push(f.Locals[15]);f.Pc=5363;continue;}
case 5363:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",5366);}
case 5366:{f.Push(f.Locals[13]);f.Pc=5368;continue;}
case 5368:{f.Push(f.Locals[14]);f.Pc=5370;continue;}
case 5370:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",5373);}
case 5373:{f.Push(f.Locals[13]);f.Pc=5375;continue;}
case 5375:{f.Push(f.Locals[2]);f.Pc=5376;continue;}
case 5376:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",5379);}
case 5379:{f.Push(f.Locals[12]);f.Pc=5381;continue;}
case 5381:{f.Push(f.Locals[13]);f.Pc=5383;continue;}
case 5383:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",5386);}
case 5386:{f.Push(f.Locals[0]);f.Pc=5387;continue;}
case 5387:{f.Push(f.Locals[12]);f.Pc=5389;continue;}
case 5389:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",5394);}
case 5394:{f.Pc=9090;continue;}
case 5397:{f.Push(f.Locals[3]);f.Pc=5398;continue;}
case 5398:{f.Push(JValue.R(rt.String("Melee")));f.Pc=5401;continue;}
case 5401:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5404);}
case 5404:{f.Pc=f.Pop().Int==0?5478:5407;continue;}
case 5407:{f.Push(f.Locals[0]);f.Pc=5408;continue;}
case 5408:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",5413);}
case 5413:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:5413:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",5418);}
case 5418:{f.Locals[5]=f.Pop();f.Pc=5420;continue;}
case 5420:{f.Push(JValue.R(rt.String("DB$ Pump | Defined$ TriggeredAttackerLKICopy | NumAtt$ MeleeX | NumDef$ MeleeX")));f.Pc=5423;continue;}
case 5423:{f.Locals[6]=f.Pop();f.Pc=5425;continue;}
case 5425:{f.Push(f.Locals[5]);f.Pc=5427;continue;}
case 5427:{f.Push(f.Locals[1]);f.Pc=5428;continue;}
case 5428:{f.Push(f.Locals[2]);f.Pc=5429;continue;}
case 5429:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",5432);}
case 5432:{f.Locals[7]=f.Pop();f.Pc=5434;continue;}
case 5434:{f.Push(JValue.R(rt.String("DB$ Pump | Defined$ TriggeredAttackerLKICopy | NumAtt$ MeleeX | NumDef$ MeleeX")));f.Pc=5437;continue;}
case 5437:{f.Push(f.Locals[1]);f.Pc=5438;continue;}
case 5438:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",5441);}
case 5441:{f.Locals[8]=f.Pop();f.Pc=5443;continue;}
case 5443:{f.Push(f.Locals[8]);f.Pc=5445;continue;}
case 5445:{f.Push(JValue.R(rt.String("MeleeX")));f.Pc=5448;continue;}
case 5448:{f.Push(JValue.R(rt.String("TriggeredPlayersDefenders$Amount")));f.Pc=5451;continue;}
case 5451:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",5454);}
case 5454:{f.Push(f.Locals[8]);f.Pc=5456;continue;}
case 5456:{f.Push(f.Locals[2]);f.Pc=5457;continue;}
case 5457:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",5460);}
case 5460:{f.Push(f.Locals[7]);f.Pc=5462;continue;}
case 5462:{f.Push(f.Locals[8]);f.Pc=5464;continue;}
case 5464:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",5467);}
case 5467:{f.Push(f.Locals[0]);f.Pc=5468;continue;}
case 5468:{f.Push(f.Locals[7]);f.Pc=5470;continue;}
case 5470:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",5475);}
case 5475:{f.Pc=9090;continue;}
case 5478:{f.Push(f.Locals[3]);f.Pc=5479;continue;}
case 5479:{f.Push(JValue.R(rt.String("Mentor")));f.Pc=5482;continue;}
case 5482:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5485);}
case 5485:{f.Pc=f.Pop().Int==0?5558:5488;continue;}
case 5488:{f.Push(f.Locals[0]);f.Pc=5489;continue;}
case 5489:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",5494);}
case 5494:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:5494:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",5499);}
case 5499:{f.Locals[5]=f.Pop();f.Pc=5501;continue;}
case 5501:{f.Push(JValue.R(rt.String("DB$ PutCounter | CounterType$ P1P1 | CounterNum$ 1 | ValidTgts$ Creature.attacking+powerLTX | TgtPrompt$ Select target attacking creature with less power")));f.Pc=5504;continue;}
case 5504:{f.Locals[6]=f.Pop();f.Pc=5506;continue;}
case 5506:{f.Push(f.Locals[5]);f.Pc=5508;continue;}
case 5508:{f.Push(f.Locals[1]);f.Pc=5509;continue;}
case 5509:{f.Push(f.Locals[2]);f.Pc=5510;continue;}
case 5510:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",5513);}
case 5513:{f.Locals[7]=f.Pop();f.Pc=5515;continue;}
case 5515:{f.Push(JValue.R(rt.String("DB$ PutCounter | CounterType$ P1P1 | CounterNum$ 1 | ValidTgts$ Creature.attacking+powerLTX | TgtPrompt$ Select target attacking creature with less power")));f.Pc=5518;continue;}
case 5518:{f.Push(f.Locals[1]);f.Pc=5519;continue;}
case 5519:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",5522);}
case 5522:{f.Locals[8]=f.Pop();f.Pc=5524;continue;}
case 5524:{f.Push(f.Locals[8]);f.Pc=5526;continue;}
case 5526:{f.Push(JValue.R(rt.String("X")));f.Pc=5528;continue;}
case 5528:{f.Push(JValue.R(rt.String("Count$CardPower")));f.Pc=5531;continue;}
case 5531:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",5534);}
case 5534:{f.Push(f.Locals[8]);f.Pc=5536;continue;}
case 5536:{f.Push(f.Locals[2]);f.Pc=5537;continue;}
case 5537:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",5540);}
case 5540:{f.Push(f.Locals[7]);f.Pc=5542;continue;}
case 5542:{f.Push(f.Locals[8]);f.Pc=5544;continue;}
case 5544:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",5547);}
case 5547:{f.Push(f.Locals[0]);f.Pc=5548;continue;}
case 5548:{f.Push(f.Locals[7]);f.Pc=5550;continue;}
case 5550:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",5555);}
case 5555:{f.Pc=9090;continue;}
case 5558:{f.Push(f.Locals[3]);f.Pc=5559;continue;}
case 5559:{f.Push(JValue.R(rt.String("Miracle")));f.Pc=5562;continue;}
case 5562:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",5565);}
case 5565:{f.Pc=f.Pop().Int==0?5699:5568;continue;}
case 5568:{f.Push(f.Locals[3]);f.Pc=5569;continue;}
case 5569:{f.Push(JValue.R(rt.String(":")));f.Pc=5572;continue;}
case 5572:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",5575);}
case 5575:{f.Locals[5]=f.Pop();f.Pc=5577;continue;}
case 5577:{f.Push(f.Locals[5]);f.Pc=5579;continue;}
case 5579:{f.Push(JValue.I(1));f.Pc=5580;continue;}
case 5580:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5581;continue;}
case 5581:{f.Locals[6]=f.Pop();f.Pc=5583;continue;}
case 5583:{f.Push(JValue.R(rt.String("DB$ Reveal | Defined$ You | RevealDefined$ Self")));f.Pc=5586;continue;}
case 5586:{f.Locals[7]=f.Pop();f.Pc=5588;continue;}
case 5588:{f.Push(f.Locals[6]);f.Pc=5590;continue;}
case 5590:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:5590:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",5595);}
case 5595:{f.Locals[8]=f.Pop();f.Pc=5597;continue;}
case 5597:{f.Push(f.Locals[5]);f.Pc=5599;continue;}
case 5599:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=5600;continue;}
case 5600:{f.Push(JValue.I(2));f.Pc=5601;continue;}
case 5601:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?5617:5604;continue;}
case 5604:{f.Push(f.Locals[8]);f.Pc=5606;continue;}
case 5606:{f.Push(f.Locals[5]);f.Pc=5608;continue;}
case 5608:{f.Push(JValue.I(2));f.Pc=5609;continue;}
case 5609:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5610;continue;}
case 5610:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:5610:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",5615);}
case 5615:{f.Locals[8]=f.Pop();f.Pc=5617;continue;}
case 5617:{f.Push(JValue.R(rt.String("DB$ ImmediateTrigger | TriggerDescription$ CARDNAME - Miracle")));f.Pc=5620;continue;}
case 5620:{f.Locals[9]=f.Pop();f.Pc=5622;continue;}
case 5622:{f.Push(JValue.R(rt.String("Mode$ Drawn | ValidCard$ Card.Self | Number$ 1 | Secondary$ True | OptionalDecider$ You | Static$ True | TriggerDescription$ CARDNAME - Miracle")));f.Pc=5625;continue;}
case 5625:{f.Locals[10]=f.Pop();f.Pc=5627;continue;}
case 5627:{f.Push(JValue.R(rt.String("Mode$ Drawn | ValidCard$ Card.Self | Number$ 1 | Secondary$ True | OptionalDecider$ You | Static$ True | TriggerDescription$ CARDNAME - Miracle")));f.Pc=5630;continue;}
case 5630:{f.Push(f.Locals[1]);f.Pc=5631;continue;}
case 5631:{f.Push(f.Locals[2]);f.Pc=5632;continue;}
case 5632:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",5635);}
case 5635:{f.Locals[11]=f.Pop();f.Pc=5637;continue;}
case 5637:{f.Push(JValue.R(rt.String("DB$ Reveal | Defined$ You | RevealDefined$ Self")));f.Pc=5640;continue;}
case 5640:{f.Push(f.Locals[1]);f.Pc=5641;continue;}
case 5641:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",5644);}
case 5644:{f.Locals[12]=f.Pop();f.Pc=5646;continue;}
case 5646:{f.Push(f.Locals[9]);f.Pc=5648;continue;}
case 5648:{f.Push(f.Locals[1]);f.Pc=5649;continue;}
case 5649:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",5652);}
case 5652:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5655;continue;}
case 5655:{f.Locals[13]=f.Pop();f.Pc=5657;continue;}
case 5657:{f.Push(f.Locals[13]);f.Pc=5659;continue;}
case 5659:{f.Push(JValue.R(rt.String("Execute")));f.Pc=5662;continue;}
case 5662:{f.Push(f.Locals[8]);f.Pc=5664;continue;}
case 5664:{f.Push(f.Locals[1]);f.Pc=5665;continue;}
case 5665:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",5668);}
case 5668:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5671;continue;}
case 5671:{return rt.Call(f,"forge/game/spellability/AbilitySub","setAdditionalAbility","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)V","invokevirtual",5674);}
case 5674:{f.Push(f.Locals[12]);f.Pc=5676;continue;}
case 5676:{f.Push(f.Locals[13]);f.Pc=5678;continue;}
case 5678:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",5681);}
case 5681:{f.Push(f.Locals[11]);f.Pc=5683;continue;}
case 5683:{f.Push(f.Locals[12]);f.Pc=5685;continue;}
case 5685:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",5688);}
case 5688:{f.Push(f.Locals[0]);f.Pc=5689;continue;}
case 5689:{f.Push(f.Locals[11]);f.Pc=5691;continue;}
case 5691:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",5696);}
case 5696:{f.Pc=9090;continue;}
case 5699:{f.Push(f.Locals[3]);f.Pc=5700;continue;}
case 5700:{f.Push(JValue.R(rt.String("Mobilize")));f.Pc=5703;continue;}
case 5703:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",5706);}
case 5706:{f.Pc=f.Pop().Int==0?5779:5709;continue;}
case 5709:{f.Push(f.Locals[3]);f.Pc=5710;continue;}
case 5710:{f.Push(JValue.R(rt.String(":")));f.Pc=5713;continue;}
case 5713:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",5716);}
case 5716:{f.Locals[5]=f.Pop();f.Pc=5718;continue;}
case 5718:{f.Push(f.Locals[5]);f.Pc=5720;continue;}
case 5720:{f.Push(JValue.I(1));f.Pc=5721;continue;}
case 5721:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5722;continue;}
case 5722:{f.Locals[6]=f.Pop();f.Pc=5724;continue;}
case 5724:{f.Push(f.Locals[6]);f.Pc=5726;continue;}
case 5726:{f.Push(f.Locals[0]);f.Pc=5727;continue;}
case 5727:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",5732);}
case 5732:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:5732:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",5737);}
case 5737:{f.Locals[7]=f.Pop();f.Pc=5739;continue;}
case 5739:{f.Push(f.Locals[6]);f.Pc=5741;continue;}
case 5741:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:5741:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",5746);}
case 5746:{f.Locals[8]=f.Pop();f.Pc=5748;continue;}
case 5748:{f.Push(f.Locals[7]);f.Pc=5750;continue;}
case 5750:{f.Push(f.Locals[1]);f.Pc=5751;continue;}
case 5751:{f.Push(f.Locals[2]);f.Pc=5752;continue;}
case 5752:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",5755);}
case 5755:{f.Locals[9]=f.Pop();f.Pc=5757;continue;}
case 5757:{f.Push(f.Locals[9]);f.Pc=5759;continue;}
case 5759:{f.Push(f.Locals[8]);f.Pc=5761;continue;}
case 5761:{f.Push(f.Locals[1]);f.Pc=5762;continue;}
case 5762:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",5765);}
case 5765:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",5768);}
case 5768:{f.Push(f.Locals[0]);f.Pc=5769;continue;}
case 5769:{f.Push(f.Locals[9]);f.Pc=5771;continue;}
case 5771:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",5776);}
case 5776:{f.Pc=9090;continue;}
case 5779:{f.Push(f.Locals[3]);f.Pc=5780;continue;}
case 5780:{f.Push(JValue.R(rt.String("Modular")));f.Pc=5783;continue;}
case 5783:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",5786);}
case 5786:{f.Pc=f.Pop().Int==0?5846:5789;continue;}
case 5789:{f.Push(JValue.R(rt.String("DB$ PutCounter | ValidTgts$ Artifact.Creature | TgtPrompt$ Select target artifact creature | CounterType$ P1P1 | CounterNum$ ModularX")));f.Pc=5792;continue;}
case 5792:{f.Locals[5]=f.Pop();f.Pc=5794;continue;}
case 5794:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | ValidCard$ Card.Self | Origin$ Battlefield | Destination$ Graveyard | OptionalDecider$ TriggeredCardController | Secondary$ True | TriggerDescription$ When CARDNAME dies, you may put a +1/+1 counter on target artifact creature for each +1/+1 counter on CARDNAME")));f.Pc=5797;continue;}
case 5797:{f.Locals[6]=f.Pop();f.Pc=5799;continue;}
case 5799:{f.Push(f.Locals[6]);f.Pc=5801;continue;}
case 5801:{f.Push(f.Locals[1]);f.Pc=5802;continue;}
case 5802:{f.Push(f.Locals[2]);f.Pc=5803;continue;}
case 5803:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",5806);}
case 5806:{f.Locals[7]=f.Pop();f.Pc=5808;continue;}
case 5808:{f.Push(JValue.R(rt.String("DB$ PutCounter | ValidTgts$ Artifact.Creature | TgtPrompt$ Select target artifact creature | CounterType$ P1P1 | CounterNum$ ModularX")));f.Pc=5811;continue;}
case 5811:{f.Push(f.Locals[1]);f.Pc=5812;continue;}
case 5812:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",5815);}
case 5815:{f.Locals[8]=f.Pop();f.Pc=5817;continue;}
case 5817:{f.Push(f.Locals[8]);f.Pc=5819;continue;}
case 5819:{f.Push(JValue.R(rt.String("ModularX")));f.Pc=5822;continue;}
case 5822:{f.Push(JValue.R(rt.String("TriggeredCard$CardCounters.P1P1")));f.Pc=5825;continue;}
case 5825:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",5828);}
case 5828:{f.Push(f.Locals[7]);f.Pc=5830;continue;}
case 5830:{f.Push(f.Locals[8]);f.Pc=5832;continue;}
case 5832:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",5835);}
case 5835:{f.Push(f.Locals[0]);f.Pc=5836;continue;}
case 5836:{f.Push(f.Locals[7]);f.Pc=5838;continue;}
case 5838:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",5843);}
case 5843:{f.Pc=9090;continue;}
case 5846:{f.Push(f.Locals[3]);f.Pc=5847;continue;}
case 5847:{f.Push(JValue.R(rt.String("Myriad")));f.Pc=5850;continue;}
case 5850:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5853);}
case 5853:{f.Pc=f.Pop().Int==0?5916:5856;continue;}
case 5856:{f.Push(f.Locals[0]);f.Pc=5857;continue;}
case 5857:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",5862);}
case 5862:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:5862:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",5867);}
case 5867:{f.Locals[5]=f.Pop();f.Pc=5869;continue;}
case 5869:{f.Push(JValue.R(rt.String("DB$ CopyPermanent | Defined$ Self | TokenTapped$ True | OptionalForEach$ True | TokenAttacking$ RememberedPlayer & Valid Planeswalker.ControlledBy Remembered| ForEach$ OppNonDefendingPlayer | AtEOT$ ExileCombat | CleanupForEach$ True")));f.Pc=5872;continue;}
case 5872:{f.Locals[6]=f.Pop();f.Pc=5874;continue;}
case 5874:{f.Push(JValue.R(rt.String("DB$ CopyPermanent | Defined$ Self | TokenTapped$ True | OptionalForEach$ True | TokenAttacking$ RememberedPlayer & Valid Planeswalker.ControlledBy Remembered| ForEach$ OppNonDefendingPlayer | AtEOT$ ExileCombat | CleanupForEach$ True")));f.Pc=5877;continue;}
case 5877:{f.Push(f.Locals[1]);f.Pc=5878;continue;}
case 5878:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",5881);}
case 5881:{f.Locals[7]=f.Pop();f.Pc=5883;continue;}
case 5883:{f.Push(f.Locals[7]);f.Pc=5885;continue;}
case 5885:{f.Push(f.Locals[2]);f.Pc=5886;continue;}
case 5886:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",5889);}
case 5889:{f.Push(f.Locals[5]);f.Pc=5891;continue;}
case 5891:{f.Push(f.Locals[1]);f.Pc=5892;continue;}
case 5892:{f.Push(f.Locals[2]);f.Pc=5893;continue;}
case 5893:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",5896);}
case 5896:{f.Locals[8]=f.Pop();f.Pc=5898;continue;}
case 5898:{f.Push(f.Locals[8]);f.Pc=5900;continue;}
case 5900:{f.Push(f.Locals[7]);f.Pc=5902;continue;}
case 5902:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",5905);}
case 5905:{f.Push(f.Locals[0]);f.Pc=5906;continue;}
case 5906:{f.Push(f.Locals[8]);f.Pc=5908;continue;}
case 5908:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",5913);}
case 5913:{f.Pc=9090;continue;}
case 5916:{f.Push(f.Locals[3]);f.Pc=5917;continue;}
case 5917:{f.Push(JValue.R(rt.String("Nightbound")));f.Pc=5920;continue;}
case 5920:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5923);}
case 5923:{f.Pc=f.Pop().Int==0?6007:5926;continue;}
case 5926:{f.Push(JValue.R(rt.String("Mode$ Always | TriggerZones$ Battlefield | Static$ True | DayTime$ Neither | IsPresent$ Card.Daybound | PresentCompare$ EQ0 | Secondary$ True | TriggerDescription$ Any time a player controls a permanent with nightbound, if it's neither day nor night and there are no permanents with daybound on the battlefield, it becomes night.")));f.Pc=5929;continue;}
case 5929:{f.Locals[5]=f.Pop();f.Pc=5931;continue;}
case 5931:{f.Push(JValue.R(rt.String("DB$ DayTime | Value$ Night")));f.Pc=5934;continue;}
case 5934:{f.Locals[6]=f.Pop();f.Pc=5936;continue;}
case 5936:{f.Push(JValue.R(rt.String("Mode$ Always | TriggerZones$ Battlefield | Static$ True | DayTime$ Neither | IsPresent$ Card.Daybound | PresentCompare$ EQ0 | Secondary$ True | TriggerDescription$ Any time a player controls a permanent with nightbound, if it's neither day nor night and there are no permanents with daybound on the battlefield, it becomes night.")));f.Pc=5939;continue;}
case 5939:{f.Push(f.Locals[1]);f.Pc=5940;continue;}
case 5940:{f.Push(f.Locals[2]);f.Pc=5941;continue;}
case 5941:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",5944);}
case 5944:{f.Locals[7]=f.Pop();f.Pc=5946;continue;}
case 5946:{f.Push(f.Locals[7]);f.Pc=5948;continue;}
case 5948:{f.Push(f.Locals[6]);f.Pc=5950;continue;}
case 5950:{f.Push(f.Locals[1]);f.Pc=5951;continue;}
case 5951:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",5954);}
case 5954:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",5957);}
case 5957:{f.Push(f.Locals[0]);f.Pc=5958;continue;}
case 5958:{f.Push(f.Locals[7]);f.Pc=5960;continue;}
case 5960:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",5965);}
case 5965:{f.Push(JValue.R(rt.String("Mode$ Always | TriggerZones$ Battlefield | Static$ True | DayTime$ Day | IsPresent$ Card.Self+BackSide | Secondary$ True | TriggerDescription$ As it becomes day, if this permanent is back face up, transform it")));f.Pc=5968;continue;}
case 5968:{f.Locals[8]=f.Pop();f.Pc=5970;continue;}
case 5970:{f.Push(JValue.R(rt.String("DB$ SetState | Mode$ Transform")));f.Pc=5973;continue;}
case 5973:{f.Locals[9]=f.Pop();f.Pc=5975;continue;}
case 5975:{f.Push(JValue.R(rt.String("Mode$ Always | TriggerZones$ Battlefield | Static$ True | DayTime$ Day | IsPresent$ Card.Self+BackSide | Secondary$ True | TriggerDescription$ As it becomes day, if this permanent is back face up, transform it")));f.Pc=5978;continue;}
case 5978:{f.Push(f.Locals[1]);f.Pc=5979;continue;}
case 5979:{f.Push(f.Locals[2]);f.Pc=5980;continue;}
case 5980:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",5983);}
case 5983:{f.Locals[7]=f.Pop();f.Pc=5985;continue;}
case 5985:{f.Push(f.Locals[7]);f.Pc=5987;continue;}
case 5987:{f.Push(f.Locals[9]);f.Pc=5989;continue;}
case 5989:{f.Push(f.Locals[1]);f.Pc=5990;continue;}
case 5990:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",5993);}
case 5993:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",5996);}
case 5996:{f.Push(f.Locals[0]);f.Pc=5997;continue;}
case 5997:{f.Push(f.Locals[7]);f.Pc=5999;continue;}
case 5999:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",6004);}
case 6004:{f.Pc=9090;continue;}
case 6007:{f.Push(f.Locals[3]);f.Pc=6008;continue;}
case 6008:{f.Push(JValue.R(rt.String("Offspring")));f.Pc=6011;continue;}
case 6011:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6014);}
case 6014:{f.Pc=f.Pop().Int==0?6127:6017;continue;}
case 6017:{f.Push(f.Locals[3]);f.Pc=6018;continue;}
case 6018:{f.Push(JValue.R(rt.String(":")));f.Pc=6021;continue;}
case 6021:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6024);}
case 6024:{f.Locals[5]=f.Pop();f.Pc=6026;continue;}
case 6026:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=6029;continue;}
case 6029:{f.StackOp("dup");f.Pc=6030;continue;}
case 6030:{f.Push(f.Locals[5]);f.Pc=6032;continue;}
case 6032:{f.Push(JValue.I(1));f.Pc=6033;continue;}
case 6033:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6034;continue;}
case 6034:{f.Push(JValue.I(0));f.Pc=6035;continue;}
case 6035:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",6038);}
case 6038:{f.Locals[6]=f.Pop();f.Pc=6040;continue;}
case 6040:{f.Push(f.Locals[6]);f.Pc=6042;continue;}
case 6042:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",6045);}
case 6045:{f.Locals[7]=f.Pop();f.Pc=6047;continue;}
case 6047:{f.Push(f.Locals[6]);f.Pc=6049;continue;}
case 6049:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",6052);}
case 6052:{f.Pc=f.Pop().Int!=0?6064:6055;continue;}
case 6055:{f.Push(f.Locals[7]);f.Pc=6057;continue;}
case 6057:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6057:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6062);}
case 6062:{f.Locals[7]=f.Pop();f.Pc=6064;continue;}
case 6064:{f.Push(f.Locals[7]);f.Pc=6066;continue;}
case 6066:{f.Push(f.Locals[0]);f.Pc=6067;continue;}
case 6067:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",6072);}
case 6072:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6072:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",6077);}
case 6077:{f.Locals[8]=f.Pop();f.Pc=6079;continue;}
case 6079:{f.Push(JValue.R(rt.String("DB$ CopyPermanent | Defined$ TriggeredCardLKICopy | SetPower$ 1 | SetToughness$ 1")));f.Pc=6082;continue;}
case 6082:{f.Locals[9]=f.Pop();f.Pc=6084;continue;}
case 6084:{f.Push(f.Locals[8]);f.Pc=6086;continue;}
case 6086:{f.Push(f.Locals[1]);f.Pc=6087;continue;}
case 6087:{f.Push(f.Locals[2]);f.Pc=6088;continue;}
case 6088:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",6091);}
case 6091:{f.Locals[10]=f.Pop();f.Pc=6093;continue;}
case 6093:{f.Push(f.Locals[10]);f.Pc=6095;continue;}
case 6095:{f.Push(JValue.R(rt.String("DB$ CopyPermanent | Defined$ TriggeredCardLKICopy | SetPower$ 1 | SetToughness$ 1")));f.Pc=6098;continue;}
case 6098:{f.Push(f.Locals[1]);f.Pc=6099;continue;}
case 6099:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",6102);}
case 6102:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",6105);}
case 6105:{f.Push(f.Locals[10]);f.Pc=6107;continue;}
case 6107:{f.Push(JValue.R(rt.String("Offspring")));f.Pc=6110;continue;}
case 6110:{f.Push(JValue.R(rt.String("Count$OptionalKeywordAmount")));f.Pc=6113;continue;}
case 6113:{return rt.Call(f,"forge/game/trigger/Trigger","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",6116);}
case 6116:{f.Push(f.Locals[0]);f.Pc=6117;continue;}
case 6117:{f.Push(f.Locals[10]);f.Pc=6119;continue;}
case 6119:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",6124);}
case 6124:{f.Pc=9090;continue;}
case 6127:{f.Push(f.Locals[3]);f.Pc=6128;continue;}
case 6128:{f.Push(JValue.R(rt.String("Partner with:")));f.Pc=6131;continue;}
case 6131:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6134);}
case 6134:{f.Pc=f.Pop().Int==0?6222:6137;continue;}
case 6137:{f.Push(f.Locals[3]);f.Pc=6138;continue;}
case 6138:{f.Push(JValue.R(rt.String(":")));f.Pc=6141;continue;}
case 6141:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6144);}
case 6144:{f.Locals[5]=f.Pop();f.Pc=6146;continue;}
case 6146:{f.Push(f.Locals[5]);f.Pc=6148;continue;}
case 6148:{f.Push(JValue.I(1));f.Pc=6149;continue;}
case 6149:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6150;continue;}
case 6150:{f.Push(f.Locals[0]);f.Pc=6151;continue;}
case 6151:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",6156);}
case 6156:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6156:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",6161);}
case 6161:{f.Locals[6]=f.Pop();f.Pc=6163;continue;}
case 6163:{f.Push(f.Locals[5]);f.Pc=6165;continue;}
case 6165:{f.Push(JValue.I(1));f.Pc=6166;continue;}
case 6166:{f.Push(f.Locals[5]);f.Pc=6168;continue;}
case 6168:{f.Push(JValue.I(1));f.Pc=6169;continue;}
case 6169:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6170;continue;}
case 6170:{f.Push(JValue.R(rt.String(",")));f.Pc=6173;continue;}
case 6173:{f.Push(JValue.R(rt.String(";")));f.Pc=6176;continue;}
case 6176:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",6179);}
case 6179:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=6180;continue;}
case 6180:{f.Push(f.Locals[5]);f.Pc=6182;continue;}
case 6182:{f.Push(JValue.I(1));f.Pc=6183;continue;}
case 6183:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6184;continue;}
case 6184:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6184:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6189);}
case 6189:{f.Locals[7]=f.Pop();f.Pc=6191;continue;}
case 6191:{f.Push(f.Locals[6]);f.Pc=6193;continue;}
case 6193:{f.Push(f.Locals[1]);f.Pc=6194;continue;}
case 6194:{f.Push(f.Locals[2]);f.Pc=6195;continue;}
case 6195:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",6198);}
case 6198:{f.Locals[8]=f.Pop();f.Pc=6200;continue;}
case 6200:{f.Push(f.Locals[8]);f.Pc=6202;continue;}
case 6202:{f.Push(f.Locals[7]);f.Pc=6204;continue;}
case 6204:{f.Push(f.Locals[1]);f.Pc=6205;continue;}
case 6205:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",6208);}
case 6208:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",6211);}
case 6211:{f.Push(f.Locals[0]);f.Pc=6212;continue;}
case 6212:{f.Push(f.Locals[8]);f.Pc=6214;continue;}
case 6214:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",6219);}
case 6219:{f.Pc=9090;continue;}
case 6222:{f.Push(f.Locals[3]);f.Pc=6223;continue;}
case 6223:{f.Push(JValue.R(rt.String("Persist")));f.Pc=6226;continue;}
case 6226:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6229);}
case 6229:{f.Pc=f.Pop().Int==0?6282:6232;continue;}
case 6232:{f.Push(f.Locals[0]);f.Pc=6233;continue;}
case 6233:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",6238);}
case 6238:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6238:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6243);}
case 6243:{f.Locals[5]=f.Pop();f.Pc=6245;continue;}
case 6245:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ TriggeredNewCardLKICopy | Origin$ Graveyard | Destination$ Battlefield | WithCountersType$ M1M1")));f.Pc=6248;continue;}
case 6248:{f.Locals[6]=f.Pop();f.Pc=6250;continue;}
case 6250:{f.Push(f.Locals[5]);f.Pc=6252;continue;}
case 6252:{f.Push(f.Locals[1]);f.Pc=6253;continue;}
case 6253:{f.Push(f.Locals[2]);f.Pc=6254;continue;}
case 6254:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",6257);}
case 6257:{f.Locals[7]=f.Pop();f.Pc=6259;continue;}
case 6259:{f.Push(f.Locals[7]);f.Pc=6261;continue;}
case 6261:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ TriggeredNewCardLKICopy | Origin$ Graveyard | Destination$ Battlefield | WithCountersType$ M1M1")));f.Pc=6264;continue;}
case 6264:{f.Push(f.Locals[1]);f.Pc=6265;continue;}
case 6265:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",6268);}
case 6268:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",6271);}
case 6271:{f.Push(f.Locals[0]);f.Pc=6272;continue;}
case 6272:{f.Push(f.Locals[7]);f.Pc=6274;continue;}
case 6274:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",6279);}
case 6279:{f.Pc=9090;continue;}
case 6282:{f.Push(f.Locals[3]);f.Pc=6283;continue;}
case 6283:{f.Push(JValue.R(rt.String("Poisonous")));f.Pc=6286;continue;}
case 6286:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6289);}
case 6289:{f.Pc=f.Pop().Int==0?6362:6292;continue;}
case 6292:{f.Push(f.Locals[3]);f.Pc=6293;continue;}
case 6293:{f.Push(JValue.R(rt.String(":")));f.Pc=6296;continue;}
case 6296:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6299);}
case 6299:{f.Locals[5]=f.Pop();f.Pc=6301;continue;}
case 6301:{f.Push(f.Locals[5]);f.Pc=6303;continue;}
case 6303:{f.Push(JValue.I(1));f.Pc=6304;continue;}
case 6304:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6305;continue;}
case 6305:{f.Locals[6]=f.Pop();f.Pc=6307;continue;}
case 6307:{f.Push(f.Locals[6]);f.Pc=6309;continue;}
case 6309:{f.Push(f.Locals[0]);f.Pc=6310;continue;}
case 6310:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",6315);}
case 6315:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6315:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",6320);}
case 6320:{f.Locals[7]=f.Pop();f.Pc=6322;continue;}
case 6322:{f.Push(f.Locals[7]);f.Pc=6324;continue;}
case 6324:{f.Push(f.Locals[1]);f.Pc=6325;continue;}
case 6325:{f.Push(f.Locals[2]);f.Pc=6326;continue;}
case 6326:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",6329);}
case 6329:{f.Locals[8]=f.Pop();f.Pc=6331;continue;}
case 6331:{f.Push(f.Locals[6]);f.Pc=6333;continue;}
case 6333:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6333:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6338);}
case 6338:{f.Locals[9]=f.Pop();f.Pc=6340;continue;}
case 6340:{f.Push(f.Locals[8]);f.Pc=6342;continue;}
case 6342:{f.Push(f.Locals[9]);f.Pc=6344;continue;}
case 6344:{f.Push(f.Locals[1]);f.Pc=6345;continue;}
case 6345:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",6348);}
case 6348:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",6351);}
case 6351:{f.Push(f.Locals[0]);f.Pc=6352;continue;}
case 6352:{f.Push(f.Locals[8]);f.Pc=6354;continue;}
case 6354:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",6359);}
case 6359:{f.Pc=9090;continue;}
case 6362:{f.Push(f.Locals[3]);f.Pc=6363;continue;}
case 6363:{f.Push(JValue.R(rt.String("Provoke")));f.Pc=6366;continue;}
case 6366:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6369);}
case 6369:{f.Pc=f.Pop().Int==0?6456:6372;continue;}
case 6372:{f.Push(f.Locals[0]);f.Pc=6373;continue;}
case 6373:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",6378);}
case 6378:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6378:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6383);}
case 6383:{f.Locals[5]=f.Pop();f.Pc=6385;continue;}
case 6385:{f.Push(JValue.R(rt.String("DB$ MustBlock | Duration$ UntilEndOfCombat | ValidTgts$ Creature.ControlledBy TriggeredDefendingPlayer | TgtPrompt$ Select target creature defending player controls")));f.Pc=6388;continue;}
case 6388:{f.Locals[6]=f.Pop();f.Pc=6390;continue;}
case 6390:{f.Push(JValue.R(rt.String("DB$ Untap | Defined$ Targeted")));f.Pc=6393;continue;}
case 6393:{f.Locals[7]=f.Pop();f.Pc=6395;continue;}
case 6395:{f.Push(JValue.R(rt.String("DB$ MustBlock | Duration$ UntilEndOfCombat | ValidTgts$ Creature.ControlledBy TriggeredDefendingPlayer | TgtPrompt$ Select target creature defending player controls")));f.Pc=6398;continue;}
case 6398:{f.Push(f.Locals[1]);f.Pc=6399;continue;}
case 6399:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",6402);}
case 6402:{f.Locals[8]=f.Pop();f.Pc=6404;continue;}
case 6404:{f.Push(JValue.R(rt.String("DB$ Untap | Defined$ Targeted")));f.Pc=6407;continue;}
case 6407:{f.Push(f.Locals[1]);f.Pc=6408;continue;}
case 6408:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",6411);}
case 6411:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=6414;continue;}
case 6414:{f.Locals[9]=f.Pop();f.Pc=6416;continue;}
case 6416:{f.Push(f.Locals[8]);f.Pc=6418;continue;}
case 6418:{f.Push(f.Locals[9]);f.Pc=6420;continue;}
case 6420:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",6423);}
case 6423:{f.Push(f.Locals[5]);f.Pc=6425;continue;}
case 6425:{f.Push(f.Locals[1]);f.Pc=6426;continue;}
case 6426:{f.Push(f.Locals[2]);f.Pc=6427;continue;}
case 6427:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",6430);}
case 6430:{f.Locals[10]=f.Pop();f.Pc=6432;continue;}
case 6432:{f.Push(f.Locals[8]);f.Pc=6434;continue;}
case 6434:{f.Push(f.Locals[2]);f.Pc=6435;continue;}
case 6435:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",6438);}
case 6438:{f.Push(f.Locals[10]);f.Pc=6440;continue;}
case 6440:{f.Push(f.Locals[8]);f.Pc=6442;continue;}
case 6442:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",6445);}
case 6445:{f.Push(f.Locals[0]);f.Pc=6446;continue;}
case 6446:{f.Push(f.Locals[10]);f.Pc=6448;continue;}
case 6448:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",6453);}
case 6453:{f.Pc=9090;continue;}
case 6456:{f.Push(f.Locals[3]);f.Pc=6457;continue;}
case 6457:{f.Push(JValue.R(rt.String("Prowess")));f.Pc=6460;continue;}
case 6460:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6463);}
case 6463:{f.Pc=f.Pop().Int==0?6516:6466;continue;}
case 6466:{f.Push(f.Locals[0]);f.Pc=6467;continue;}
case 6467:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",6472);}
case 6472:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6472:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6477);}
case 6477:{f.Locals[5]=f.Pop();f.Pc=6479;continue;}
case 6479:{f.Push(JValue.R(rt.String("DB$ Pump | Defined$ Self | NumAtt$ +1 | NumDef$ +1")));f.Pc=6482;continue;}
case 6482:{f.Locals[6]=f.Pop();f.Pc=6484;continue;}
case 6484:{f.Push(f.Locals[5]);f.Pc=6486;continue;}
case 6486:{f.Push(f.Locals[1]);f.Pc=6487;continue;}
case 6487:{f.Push(f.Locals[2]);f.Pc=6488;continue;}
case 6488:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",6491);}
case 6491:{f.Locals[7]=f.Pop();f.Pc=6493;continue;}
case 6493:{f.Push(f.Locals[7]);f.Pc=6495;continue;}
case 6495:{f.Push(JValue.R(rt.String("DB$ Pump | Defined$ Self | NumAtt$ +1 | NumDef$ +1")));f.Pc=6498;continue;}
case 6498:{f.Push(f.Locals[1]);f.Pc=6499;continue;}
case 6499:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",6502);}
case 6502:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",6505);}
case 6505:{f.Push(f.Locals[0]);f.Pc=6506;continue;}
case 6506:{f.Push(f.Locals[7]);f.Pc=6508;continue;}
case 6508:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",6513);}
case 6513:{f.Pc=9090;continue;}
case 6516:{f.Push(f.Locals[3]);f.Pc=6517;continue;}
case 6517:{f.Push(JValue.R(rt.String("Rampage")));f.Pc=6520;continue;}
case 6520:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6523);}
case 6523:{f.Pc=f.Pop().Int==0?6638:6526;continue;}
case 6526:{f.Push(f.Locals[3]);f.Pc=6527;continue;}
case 6527:{f.Push(JValue.R(rt.String(":")));f.Pc=6530;continue;}
case 6530:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6533);}
case 6533:{f.Locals[5]=f.Pop();f.Pc=6535;continue;}
case 6535:{f.Push(f.Locals[5]);f.Pc=6537;continue;}
case 6537:{f.Push(JValue.I(1));f.Pc=6538;continue;}
case 6538:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6539;continue;}
case 6539:{f.Locals[6]=f.Pop();f.Pc=6541;continue;}
case 6541:{f.Push(f.Locals[6]);f.Pc=6543;continue;}
case 6543:{f.Push(f.Locals[0]);f.Pc=6544;continue;}
case 6544:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",6549);}
case 6549:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6549:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",6554);}
case 6554:{f.Locals[7]=f.Pop();f.Pc=6556;continue;}
case 6556:{f.Push(f.Locals[6]);f.Pc=6558;continue;}
case 6558:{f.Push(f.Locals[6]);f.Pc=6560;continue;}
case 6560:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6560:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",6565);}
case 6565:{f.Locals[8]=f.Pop();f.Pc=6567;continue;}
case 6567:{f.Push(f.Locals[7]);f.Pc=6569;continue;}
case 6569:{f.Push(f.Locals[1]);f.Pc=6570;continue;}
case 6570:{f.Push(f.Locals[2]);f.Pc=6571;continue;}
case 6571:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",6574);}
case 6574:{f.Locals[9]=f.Pop();f.Pc=6576;continue;}
case 6576:{f.Push(f.Locals[8]);f.Pc=6578;continue;}
case 6578:{f.Push(f.Locals[1]);f.Pc=6579;continue;}
case 6579:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",6582);}
case 6582:{f.Locals[10]=f.Pop();f.Pc=6584;continue;}
case 6584:{f.Push(f.Locals[10]);f.Pc=6586;continue;}
case 6586:{f.Push(f.Locals[6]);f.Pc=6588;continue;}
case 6588:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6588:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6593);}
case 6593:{f.Push(f.Locals[6]);f.Pc=6595;continue;}
case 6595:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6595:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6600);}
case 6600:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",6603);}
case 6603:{f.Push(f.Locals[10]);f.Pc=6605;continue;}
case 6605:{f.Push(JValue.R(rt.String("RampageCount")));f.Pc=6608;continue;}
case 6608:{f.Push(JValue.R(rt.String("Count$Valid Creature.blockingTriggeredAttacker/Minus.1")));f.Pc=6611;continue;}
case 6611:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",6614);}
case 6614:{f.Push(f.Locals[10]);f.Pc=6616;continue;}
case 6616:{f.Push(f.Locals[2]);f.Pc=6617;continue;}
case 6617:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",6620);}
case 6620:{f.Push(f.Locals[9]);f.Pc=6622;continue;}
case 6622:{f.Push(f.Locals[10]);f.Pc=6624;continue;}
case 6624:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",6627);}
case 6627:{f.Push(f.Locals[0]);f.Pc=6628;continue;}
case 6628:{f.Push(f.Locals[9]);f.Pc=6630;continue;}
case 6630:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",6635);}
case 6635:{f.Pc=9090;continue;}
case 6638:{f.Push(f.Locals[3]);f.Pc=6639;continue;}
case 6639:{f.Push(JValue.R(rt.String("Ravenous")));f.Pc=6642;continue;}
case 6642:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6645);}
case 6645:{f.Pc=f.Pop().Int==0?6701:6648;continue;}
case 6648:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | ValidCard$ Card.Self | Origin$ Any | Destination$ Battlefield | CheckSVar$ Count$xPaid | SVarCompare$ GE5 | Secondary$ True | TriggerDescription$ If X is 5 or more, draw a card when it enters.")));f.Pc=6651;continue;}
case 6651:{f.Locals[5]=f.Pop();f.Pc=6653;continue;}
case 6653:{f.Push(JValue.R(rt.String("DB$ Draw")));f.Pc=6656;continue;}
case 6656:{f.Locals[6]=f.Pop();f.Pc=6658;continue;}
case 6658:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | ValidCard$ Card.Self | Origin$ Any | Destination$ Battlefield | CheckSVar$ Count$xPaid | SVarCompare$ GE5 | Secondary$ True | TriggerDescription$ If X is 5 or more, draw a card when it enters.")));f.Pc=6661;continue;}
case 6661:{f.Push(f.Locals[1]);f.Pc=6662;continue;}
case 6662:{f.Push(f.Locals[2]);f.Pc=6663;continue;}
case 6663:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",6666);}
case 6666:{f.Locals[7]=f.Pop();f.Pc=6668;continue;}
case 6668:{f.Push(JValue.R(rt.String("DB$ Draw")));f.Pc=6671;continue;}
case 6671:{f.Push(f.Locals[1]);f.Pc=6672;continue;}
case 6672:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",6675);}
case 6675:{f.Locals[8]=f.Pop();f.Pc=6677;continue;}
case 6677:{f.Push(f.Locals[8]);f.Pc=6679;continue;}
case 6679:{f.Push(f.Locals[2]);f.Pc=6680;continue;}
case 6680:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",6683);}
case 6683:{f.Push(f.Locals[7]);f.Pc=6685;continue;}
case 6685:{f.Push(f.Locals[8]);f.Pc=6687;continue;}
case 6687:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",6690);}
case 6690:{f.Push(f.Locals[0]);f.Pc=6691;continue;}
case 6691:{f.Push(f.Locals[7]);f.Pc=6693;continue;}
case 6693:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",6698);}
case 6698:{f.Pc=9090;continue;}
case 6701:{f.Push(f.Locals[3]);f.Pc=6702;continue;}
case 6702:{f.Push(JValue.R(rt.String("Renown")));f.Pc=6705;continue;}
case 6705:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6708);}
case 6708:{f.Pc=f.Pop().Int==0?6779:6711;continue;}
case 6711:{f.Push(f.Locals[3]);f.Pc=6712;continue;}
case 6712:{f.Push(JValue.R(rt.String(":")));f.Pc=6715;continue;}
case 6715:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6718);}
case 6718:{f.Locals[5]=f.Pop();f.Pc=6720;continue;}
case 6720:{f.Push(f.Locals[5]);f.Pc=6722;continue;}
case 6722:{f.Push(JValue.I(1));f.Pc=6723;continue;}
case 6723:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6724;continue;}
case 6724:{f.Push(f.Locals[0]);f.Pc=6725;continue;}
case 6725:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",6730);}
case 6730:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6730:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",6735);}
case 6735:{f.Locals[6]=f.Pop();f.Pc=6737;continue;}
case 6737:{f.Push(f.Locals[5]);f.Pc=6739;continue;}
case 6739:{f.Push(JValue.I(1));f.Pc=6740;continue;}
case 6740:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6741;continue;}
case 6741:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6741:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6746);}
case 6746:{f.Locals[7]=f.Pop();f.Pc=6748;continue;}
case 6748:{f.Push(f.Locals[6]);f.Pc=6750;continue;}
case 6750:{f.Push(f.Locals[1]);f.Pc=6751;continue;}
case 6751:{f.Push(f.Locals[2]);f.Pc=6752;continue;}
case 6752:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",6755);}
case 6755:{f.Locals[8]=f.Pop();f.Pc=6757;continue;}
case 6757:{f.Push(f.Locals[8]);f.Pc=6759;continue;}
case 6759:{f.Push(f.Locals[7]);f.Pc=6761;continue;}
case 6761:{f.Push(f.Locals[1]);f.Pc=6762;continue;}
case 6762:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",6765);}
case 6765:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",6768);}
case 6768:{f.Push(f.Locals[0]);f.Pc=6769;continue;}
case 6769:{f.Push(f.Locals[8]);f.Pc=6771;continue;}
case 6771:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",6776);}
case 6776:{f.Pc=9090;continue;}
case 6779:{f.Push(f.Locals[3]);f.Pc=6780;continue;}
case 6780:{f.Push(JValue.R(rt.String("Recover")));f.Pc=6783;continue;}
case 6783:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6786);}
case 6786:{f.Pc=f.Pop().Int==0?6961:6789;continue;}
case 6789:{f.Push(f.Locals[3]);f.Pc=6790;continue;}
case 6790:{f.Push(JValue.R(rt.String(":")));f.Pc=6793;continue;}
case 6793:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6796);}
case 6796:{f.Push(JValue.I(1));f.Pc=6797;continue;}
case 6797:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6798;continue;}
case 6798:{f.Locals[5]=f.Pop();f.Pc=6800;continue;}
case 6800:{f.Push(f.Locals[5]);f.Pc=6802;continue;}
case 6802:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6802:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6807);}
case 6807:{f.Locals[6]=f.Pop();f.Pc=6809;continue;}
case 6809:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self | Origin$ Graveyard | Destination$ Exile")));f.Pc=6812;continue;}
case 6812:{f.Locals[7]=f.Pop();f.Pc=6814;continue;}
case 6814:{f.Push(f.Locals[6]);f.Pc=6816;continue;}
case 6816:{f.Push(f.Locals[1]);f.Pc=6817;continue;}
case 6817:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",6820);}
case 6820:{f.Locals[8]=f.Pop();f.Pc=6822;continue;}
case 6822:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self | Origin$ Graveyard | Destination$ Exile")));f.Pc=6825;continue;}
case 6825:{f.Push(f.Locals[1]);f.Pc=6826;continue;}
case 6826:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",6829);}
case 6829:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=6832;continue;}
case 6832:{f.Locals[9]=f.Pop();f.Pc=6834;continue;}
case 6834:{f.Push(f.Locals[8]);f.Pc=6836;continue;}
case 6836:{f.Push(f.Locals[9]);f.Pc=6838;continue;}
case 6838:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",6841);}
case 6841:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=6844;continue;}
case 6844:{f.StackOp("dup");f.Pc=6845;continue;}
case 6845:{f.Push(f.Locals[5]);f.Pc=6847;continue;}
case 6847:{f.Push(JValue.I(0));f.Pc=6848;continue;}
case 6848:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",6851);}
case 6851:{f.Locals[10]=f.Pop();f.Pc=6853;continue;}
case 6853:{f.Push(f.Locals[10]);f.Pc=6855;continue;}
case 6855:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",6858);}
case 6858:{f.Locals[11]=f.Pop();f.Pc=6860;continue;}
case 6860:{f.Push(f.Locals[10]);f.Pc=6862;continue;}
case 6862:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",6865);}
case 6865:{f.Pc=f.Pop().Int!=0?6877:6868;continue;}
case 6868:{f.Push(f.Locals[11]);f.Pc=6870;continue;}
case 6870:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6870:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6875);}
case 6875:{f.Locals[11]=f.Pop();f.Pc=6877;continue;}
case 6877:{f.Push(f.Locals[1]);f.Pc=6878;continue;}
case 6878:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",6881);}
case 6881:{f.Pc=f.Pop().Int==0?6890:6884;continue;}
case 6884:{f.Push(JValue.R(rt.String("Creature.Other+YouOwn")));f.Pc=6887;continue;}
case 6887:{f.Pc=6893;continue;}
case 6890:{f.Push(JValue.R(rt.String("Creature.YouOwn")));f.Pc=6893;continue;}
case 6893:{f.Locals[12]=f.Pop();f.Pc=6895;continue;}
case 6895:{f.Push(f.Locals[1]);f.Pc=6896;continue;}
case 6896:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",6899);}
case 6899:{f.Pc=f.Pop().Int==0?6908:6902;continue;}
case 6902:{f.Push(JValue.R(rt.String("another")));f.Pc=6905;continue;}
case 6905:{f.Pc=6911;continue;}
case 6908:{f.Push(JValue.R(rt.String("a")));f.Pc=6911;continue;}
case 6911:{f.Locals[13]=f.Pop();f.Pc=6913;continue;}
case 6913:{f.Push(f.Locals[12]);f.Pc=6915;continue;}
case 6915:{f.Push(f.Locals[11]);f.Pc=6917;continue;}
case 6917:{f.Push(f.Locals[13]);f.Pc=6919;continue;}
case 6919:{f.Push(f.Locals[11]);f.Pc=6921;continue;}
case 6921:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:6921:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",6926);}
case 6926:{f.Locals[14]=f.Pop();f.Pc=6928;continue;}
case 6928:{f.Push(f.Locals[14]);f.Pc=6930;continue;}
case 6930:{f.Push(f.Locals[1]);f.Pc=6931;continue;}
case 6931:{f.Push(f.Locals[2]);f.Pc=6932;continue;}
case 6932:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",6935);}
case 6935:{f.Locals[15]=f.Pop();f.Pc=6937;continue;}
case 6937:{f.Push(f.Locals[8]);f.Pc=6939;continue;}
case 6939:{f.Push(f.Locals[2]);f.Pc=6940;continue;}
case 6940:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",6943);}
case 6943:{f.Push(f.Locals[15]);f.Pc=6945;continue;}
case 6945:{f.Push(f.Locals[8]);f.Pc=6947;continue;}
case 6947:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",6950);}
case 6950:{f.Push(f.Locals[0]);f.Pc=6951;continue;}
case 6951:{f.Push(f.Locals[15]);f.Pc=6953;continue;}
case 6953:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",6958);}
case 6958:{f.Pc=9090;continue;}
case 6961:{f.Push(f.Locals[3]);f.Pc=6962;continue;}
case 6962:{f.Push(JValue.R(rt.String("Replicate")));f.Pc=6965;continue;}
case 6965:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6968);}
case 6968:{f.Pc=f.Pop().Int==0?7040:6971;continue;}
case 6971:{f.Push(JValue.R(rt.String("Mode$ SpellCast | ValidCard$ Card.Self | CheckSVar$ ReplicateAmount | Secondary$ True | TriggerDescription$ Copy CARDNAME for each time you paid its replicate cost.")));f.Pc=6974;continue;}
case 6974:{f.Locals[5]=f.Pop();f.Pc=6976;continue;}
case 6976:{f.Push(JValue.R(rt.String("DB$ CopySpellAbility | Defined$ TriggeredSpellAbility | Amount$ ReplicateAmount | MayChooseTarget$ True")));f.Pc=6979;continue;}
case 6979:{f.Locals[6]=f.Pop();f.Pc=6981;continue;}
case 6981:{f.Push(JValue.R(rt.String("Mode$ SpellCast | ValidCard$ Card.Self | CheckSVar$ ReplicateAmount | Secondary$ True | TriggerDescription$ Copy CARDNAME for each time you paid its replicate cost.")));f.Pc=6984;continue;}
case 6984:{f.Push(f.Locals[1]);f.Pc=6985;continue;}
case 6985:{f.Push(f.Locals[2]);f.Pc=6986;continue;}
case 6986:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",6989);}
case 6989:{f.Locals[7]=f.Pop();f.Pc=6991;continue;}
case 6991:{f.Push(JValue.R(rt.String("DB$ CopySpellAbility | Defined$ TriggeredSpellAbility | Amount$ ReplicateAmount | MayChooseTarget$ True")));f.Pc=6994;continue;}
case 6994:{f.Push(f.Locals[1]);f.Pc=6995;continue;}
case 6995:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",6998);}
case 6998:{f.Locals[8]=f.Pop();f.Pc=7000;continue;}
case 7000:{f.Push(f.Locals[8]);f.Pc=7002;continue;}
case 7002:{f.Push(JValue.R(rt.String("ReplicateAmount")));f.Pc=7005;continue;}
case 7005:{f.Push(JValue.R(rt.String("Count$OptionalKeywordAmount")));f.Pc=7008;continue;}
case 7008:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",7011);}
case 7011:{f.Push(f.Locals[7]);f.Pc=7013;continue;}
case 7013:{f.Push(f.Locals[8]);f.Pc=7015;continue;}
case 7015:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",7018);}
case 7018:{f.Push(f.Locals[7]);f.Pc=7020;continue;}
case 7020:{f.Push(JValue.R(rt.String("ReplicateAmount")));f.Pc=7023;continue;}
case 7023:{f.Push(JValue.R(rt.String("Count$OptionalKeywordAmount")));f.Pc=7026;continue;}
case 7026:{return rt.Call(f,"forge/game/trigger/Trigger","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",7029);}
case 7029:{f.Push(f.Locals[0]);f.Pc=7030;continue;}
case 7030:{f.Push(f.Locals[7]);f.Pc=7032;continue;}
case 7032:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",7037);}
case 7037:{f.Pc=9090;continue;}
case 7040:{f.Push(f.Locals[3]);f.Pc=7041;continue;}
case 7041:{f.Push(JValue.R(rt.String("Ripple")));f.Pc=7044;continue;}
case 7044:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7047);}
case 7047:{f.Pc=f.Pop().Int==0?7196:7050;continue;}
case 7050:{f.Push(f.Locals[3]);f.Pc=7051;continue;}
case 7051:{f.Push(JValue.R(rt.String(":")));f.Pc=7054;continue;}
case 7054:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",7057);}
case 7057:{f.Locals[5]=f.Pop();f.Pc=7059;continue;}
case 7059:{f.Push(f.Locals[5]);f.Pc=7061;continue;}
case 7061:{f.Push(JValue.I(1));f.Pc=7062;continue;}
case 7062:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=7063;continue;}
case 7063:{f.Locals[6]=f.Pop();f.Pc=7065;continue;}
case 7065:{f.Push(f.Locals[6]);f.Pc=7067;continue;}
case 7067:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:7067:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",7072);}
case 7072:{f.Locals[7]=f.Pop();f.Pc=7074;continue;}
case 7074:{f.Push(f.Locals[6]);f.Pc=7076;continue;}
case 7076:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:7076:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",7081);}
case 7081:{f.Locals[8]=f.Pop();f.Pc=7083;continue;}
case 7083:{f.Push(JValue.R(rt.String("DB$ Play | Valid$ Card.IsRemembered+sameName | ValidSA$ Spell | ValidZone$ Library | WithoutManaCost$ True | Optional$ True | Amount$ All")));f.Pc=7086;continue;}
case 7086:{f.Locals[9]=f.Pop();f.Pc=7088;continue;}
case 7088:{f.Push(JValue.R(rt.String("DB$ ChangeZoneAll | ChangeType$ Card.IsRemembered | Origin$ Library | Destination$ Library | LibraryPosition$ -1")));f.Pc=7091;continue;}
case 7091:{f.Locals[10]=f.Pop();f.Pc=7093;continue;}
case 7093:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=7096;continue;}
case 7096:{f.Locals[11]=f.Pop();f.Pc=7098;continue;}
case 7098:{f.Push(f.Locals[8]);f.Pc=7100;continue;}
case 7100:{f.Push(f.Locals[1]);f.Pc=7101;continue;}
case 7101:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",7104);}
case 7104:{f.Locals[12]=f.Pop();f.Pc=7106;continue;}
case 7106:{f.Push(JValue.R(rt.String("DB$ Play | Valid$ Card.IsRemembered+sameName | ValidSA$ Spell | ValidZone$ Library | WithoutManaCost$ True | Optional$ True | Amount$ All")));f.Pc=7109;continue;}
case 7109:{f.Push(f.Locals[1]);f.Pc=7110;continue;}
case 7110:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",7113);}
case 7113:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7116;continue;}
case 7116:{f.Locals[13]=f.Pop();f.Pc=7118;continue;}
case 7118:{f.Push(JValue.R(rt.String("DB$ ChangeZoneAll | ChangeType$ Card.IsRemembered | Origin$ Library | Destination$ Library | LibraryPosition$ -1")));f.Pc=7121;continue;}
case 7121:{f.Push(f.Locals[1]);f.Pc=7122;continue;}
case 7122:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",7125);}
case 7125:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7128;continue;}
case 7128:{f.Locals[14]=f.Pop();f.Pc=7130;continue;}
case 7130:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=7133;continue;}
case 7133:{f.Push(f.Locals[1]);f.Pc=7134;continue;}
case 7134:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",7137);}
case 7137:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7140;continue;}
case 7140:{f.Locals[15]=f.Pop();f.Pc=7142;continue;}
case 7142:{f.Push(f.Locals[14]);f.Pc=7144;continue;}
case 7144:{f.Push(f.Locals[15]);f.Pc=7146;continue;}
case 7146:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",7149);}
case 7149:{f.Push(f.Locals[13]);f.Pc=7151;continue;}
case 7151:{f.Push(f.Locals[14]);f.Pc=7153;continue;}
case 7153:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",7156);}
case 7156:{f.Push(f.Locals[12]);f.Pc=7158;continue;}
case 7158:{f.Push(f.Locals[13]);f.Pc=7160;continue;}
case 7160:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",7163);}
case 7163:{f.Push(f.Locals[12]);f.Pc=7165;continue;}
case 7165:{f.Push(f.Locals[2]);f.Pc=7166;continue;}
case 7166:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",7169);}
case 7169:{f.Push(f.Locals[7]);f.Pc=7171;continue;}
case 7171:{f.Push(f.Locals[1]);f.Pc=7172;continue;}
case 7172:{f.Push(f.Locals[2]);f.Pc=7173;continue;}
case 7173:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",7176);}
case 7176:{f.Locals[16]=f.Pop();f.Pc=7178;continue;}
case 7178:{f.Push(f.Locals[16]);f.Pc=7180;continue;}
case 7180:{f.Push(f.Locals[12]);f.Pc=7182;continue;}
case 7182:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",7185);}
case 7185:{f.Push(f.Locals[0]);f.Pc=7186;continue;}
case 7186:{f.Push(f.Locals[16]);f.Pc=7188;continue;}
case 7188:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",7193);}
case 7193:{f.Pc=9090;continue;}
case 7196:{f.Push(f.Locals[3]);f.Pc=7197;continue;}
case 7197:{f.Push(JValue.R(rt.String("Soulbond")));f.Pc=7200;continue;}
case 7200:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7203);}
case 7203:{f.Pc=f.Pop().Int==0?7289:7206;continue;}
case 7206:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Destination$ Battlefield | ValidCard$ Card.Self | IsPresent$ Creature.Other+YouCtrl+!Paired | Secondary$ True | TriggerDescription$ When CARDNAME enters, you may pair CARDNAME with another unpaired creature you control")));f.Pc=7209;continue;}
case 7209:{f.Locals[5]=f.Pop();f.Pc=7211;continue;}
case 7211:{f.Push(JValue.R(rt.String("DB$ Bond | Defined$ TriggeredCardLKICopy | ValidCards$ Creature.Other+YouCtrl+!Paired")));f.Pc=7214;continue;}
case 7214:{f.Locals[6]=f.Pop();f.Pc=7216;continue;}
case 7216:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Destination$ Battlefield | ValidCard$ Card.Self | IsPresent$ Creature.Other+YouCtrl+!Paired | Secondary$ True | TriggerDescription$ When CARDNAME enters, you may pair CARDNAME with another unpaired creature you control")));f.Pc=7219;continue;}
case 7219:{f.Push(f.Locals[1]);f.Pc=7220;continue;}
case 7220:{f.Push(f.Locals[2]);f.Pc=7221;continue;}
case 7221:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",7224);}
case 7224:{f.Locals[7]=f.Pop();f.Pc=7226;continue;}
case 7226:{f.Push(f.Locals[7]);f.Pc=7228;continue;}
case 7228:{f.Push(JValue.R(rt.String("DB$ Bond | Defined$ TriggeredCardLKICopy | ValidCards$ Creature.Other+YouCtrl+!Paired")));f.Pc=7231;continue;}
case 7231:{f.Push(f.Locals[1]);f.Pc=7232;continue;}
case 7232:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",7235);}
case 7235:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",7238);}
case 7238:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Destination$ Battlefield | ValidCard$ Creature.Other+YouCtrl | TriggerZones$ Battlefield |  IsPresent$ Creature.Self+!Paired | Secondary$ True |  TriggerDescription$ When another unpaired creature you control enters, you may pair it with CARDNAME")));f.Pc=7241;continue;}
case 7241:{f.Locals[8]=f.Pop();f.Pc=7243;continue;}
case 7243:{f.Push(JValue.R(rt.String("DB$ Bond | Defined$ TriggeredCardLKICopy | ValidCards$ Creature.Self+!Paired")));f.Pc=7246;continue;}
case 7246:{f.Locals[9]=f.Pop();f.Pc=7248;continue;}
case 7248:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Destination$ Battlefield | ValidCard$ Creature.Other+YouCtrl | TriggerZones$ Battlefield |  IsPresent$ Creature.Self+!Paired | Secondary$ True |  TriggerDescription$ When another unpaired creature you control enters, you may pair it with CARDNAME")));f.Pc=7251;continue;}
case 7251:{f.Push(f.Locals[1]);f.Pc=7252;continue;}
case 7252:{f.Push(f.Locals[2]);f.Pc=7253;continue;}
case 7253:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",7256);}
case 7256:{f.Locals[10]=f.Pop();f.Pc=7258;continue;}
case 7258:{f.Push(f.Locals[10]);f.Pc=7260;continue;}
case 7260:{f.Push(JValue.R(rt.String("DB$ Bond | Defined$ TriggeredCardLKICopy | ValidCards$ Creature.Self+!Paired")));f.Pc=7263;continue;}
case 7263:{f.Push(f.Locals[1]);f.Pc=7264;continue;}
case 7264:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",7267);}
case 7267:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",7270);}
case 7270:{f.Push(f.Locals[0]);f.Pc=7271;continue;}
case 7271:{f.Push(f.Locals[7]);f.Pc=7273;continue;}
case 7273:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",7278);}
case 7278:{f.Push(f.Locals[0]);f.Pc=7279;continue;}
case 7279:{f.Push(f.Locals[10]);f.Pc=7281;continue;}
case 7281:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",7286);}
case 7286:{f.Pc=9090;continue;}
case 7289:{f.Push(f.Locals[3]);f.Pc=7290;continue;}
case 7290:{f.Push(JValue.R(rt.String("Soulshift")));f.Pc=7293;continue;}
case 7293:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7296);}
case 7296:{f.Pc=f.Pop().Int==0?7375:7299;continue;}
case 7299:{f.Push(f.Locals[3]);f.Pc=7300;continue;}
case 7300:{f.Push(JValue.R(rt.String(":")));f.Pc=7303;continue;}
case 7303:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",7306);}
case 7306:{f.Locals[5]=f.Pop();f.Pc=7308;continue;}
case 7308:{f.Push(f.Locals[5]);f.Pc=7310;continue;}
case 7310:{f.Push(JValue.I(0));f.Pc=7311;continue;}
case 7311:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=7312;continue;}
case 7312:{f.Push(f.Locals[5]);f.Pc=7314;continue;}
case 7314:{f.Push(JValue.I(1));f.Pc=7315;continue;}
case 7315:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=7316;continue;}
case 7316:{f.Push(f.Locals[0]);f.Pc=7317;continue;}
case 7317:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",7322);}
case 7322:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:7322:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",7327);}
case 7327:{f.Locals[6]=f.Pop();f.Pc=7329;continue;}
case 7329:{f.Push(f.Locals[5]);f.Pc=7331;continue;}
case 7331:{f.Push(JValue.I(1));f.Pc=7332;continue;}
case 7332:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=7333;continue;}
case 7333:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:7333:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",7338);}
case 7338:{f.Locals[7]=f.Pop();f.Pc=7340;continue;}
case 7340:{f.Push(f.Locals[6]);f.Pc=7342;continue;}
case 7342:{f.Push(f.Locals[1]);f.Pc=7343;continue;}
case 7343:{f.Push(f.Locals[2]);f.Pc=7344;continue;}
case 7344:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",7347);}
case 7347:{f.Locals[8]=f.Pop();f.Pc=7349;continue;}
case 7349:{f.Push(f.Locals[7]);f.Pc=7351;continue;}
case 7351:{f.Push(f.Locals[1]);f.Pc=7352;continue;}
case 7352:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",7355);}
case 7355:{f.Locals[9]=f.Pop();f.Pc=7357;continue;}
case 7357:{f.Push(f.Locals[8]);f.Pc=7359;continue;}
case 7359:{f.Push(f.Locals[9]);f.Pc=7361;continue;}
case 7361:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",7364);}
case 7364:{f.Push(f.Locals[0]);f.Pc=7365;continue;}
case 7365:{f.Push(f.Locals[8]);f.Pc=7367;continue;}
case 7367:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",7372);}
case 7372:{f.Pc=9090;continue;}
case 7375:{f.Push(f.Locals[3]);f.Pc=7376;continue;}
case 7376:{f.Push(JValue.R(rt.String("Squad")));f.Pc=7379;continue;}
case 7379:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7382);}
case 7382:{f.Pc=f.Pop().Int==0?7454:7385;continue;}
case 7385:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Origin$ Any | Destination$ Battlefield | ValidCard$ Card.Self+linkedCastSA | CheckSVar$ SquadAmount | Secondary$ True | TriggerDescription$ When this creature enters, create that many tokens that are copies of it.")));f.Pc=7388;continue;}
case 7388:{f.Locals[5]=f.Pop();f.Pc=7390;continue;}
case 7390:{f.Push(JValue.R(rt.String("DB$ CopyPermanent | Defined$ TriggeredCardLKICopy | NumCopies$ SquadAmount")));f.Pc=7393;continue;}
case 7393:{f.Locals[6]=f.Pop();f.Pc=7395;continue;}
case 7395:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Origin$ Any | Destination$ Battlefield | ValidCard$ Card.Self+linkedCastSA | CheckSVar$ SquadAmount | Secondary$ True | TriggerDescription$ When this creature enters, create that many tokens that are copies of it.")));f.Pc=7398;continue;}
case 7398:{f.Push(f.Locals[1]);f.Pc=7399;continue;}
case 7399:{f.Push(f.Locals[2]);f.Pc=7400;continue;}
case 7400:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",7403);}
case 7403:{f.Locals[7]=f.Pop();f.Pc=7405;continue;}
case 7405:{f.Push(JValue.R(rt.String("DB$ CopyPermanent | Defined$ TriggeredCardLKICopy | NumCopies$ SquadAmount")));f.Pc=7408;continue;}
case 7408:{f.Push(f.Locals[1]);f.Pc=7409;continue;}
case 7409:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",7412);}
case 7412:{f.Locals[8]=f.Pop();f.Pc=7414;continue;}
case 7414:{f.Push(f.Locals[8]);f.Pc=7416;continue;}
case 7416:{f.Push(JValue.R(rt.String("SquadAmount")));f.Pc=7419;continue;}
case 7419:{f.Push(JValue.R(rt.String("Count$OptionalKeywordAmount")));f.Pc=7422;continue;}
case 7422:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",7425);}
case 7425:{f.Push(f.Locals[7]);f.Pc=7427;continue;}
case 7427:{f.Push(f.Locals[8]);f.Pc=7429;continue;}
case 7429:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",7432);}
case 7432:{f.Push(f.Locals[7]);f.Pc=7434;continue;}
case 7434:{f.Push(JValue.R(rt.String("SquadAmount")));f.Pc=7437;continue;}
case 7437:{f.Push(JValue.R(rt.String("Count$OptionalKeywordAmount")));f.Pc=7440;continue;}
case 7440:{return rt.Call(f,"forge/game/trigger/Trigger","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",7443);}
case 7443:{f.Push(f.Locals[0]);f.Pc=7444;continue;}
case 7444:{f.Push(f.Locals[7]);f.Pc=7446;continue;}
case 7446:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",7451);}
case 7451:{f.Pc=9090;continue;}
case 7454:{f.Push(f.Locals[3]);f.Pc=7455;continue;}
case 7455:{f.Push(JValue.R(rt.String("Storied")));f.Pc=7458;continue;}
case 7458:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7461);}
case 7461:{f.Pc=f.Pop().Int==0?7534:7464;continue;}
case 7464:{f.Push(f.Locals[1]);f.Pc=7465;continue;}
case 7465:{return rt.Call(f,"forge/game/card/Card","isPermanent","()Z","invokevirtual",7468);}
case 7468:{f.Pc=f.Pop().Int==0?9090:7471;continue;}
case 7471:{f.Push(f.Locals[0]);f.Pc=7472;continue;}
case 7472:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",7477);}
case 7477:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:7477:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",7482);}
case 7482:{f.Locals[5]=f.Pop();f.Pc=7484;continue;}
case 7484:{f.Push(f.Locals[5]);f.Pc=7486;continue;}
case 7486:{f.Push(f.Locals[1]);f.Pc=7487;continue;}
case 7487:{f.Push(f.Locals[2]);f.Pc=7488;continue;}
case 7488:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",7491);}
case 7491:{f.Locals[6]=f.Pop();f.Pc=7493;continue;}
case 7493:{if(!rt.EnsureInitialized(f,"forge/game/card/CardFactoryUtil$3"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardFactoryUtil$3")));f.Pc=7496;continue;}
case 7496:{f.StackOp("dup");f.Pc=7497;continue;}
case 7497:{f.Push(f.Locals[1]);f.Pc=7498;continue;}
case 7498:{if(!rt.StaticReady(f,"forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"));f.Pc=7501;continue;}
case 7501:{f.Push(JValue.R(null));f.Pc=7502;continue;}
case 7502:{return rt.Call(f,"forge/game/card/CardFactoryUtil$3","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;)V","invokespecial",7505);}
case 7505:{f.Locals[7]=f.Pop();f.Pc=7507;continue;}
case 7507:{f.Push(f.Locals[7]);f.Pc=7509;continue;}
case 7509:{f.Push(f.Locals[1]);f.Pc=7510;continue;}
case 7510:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",7513);}
case 7513:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",7516);}
case 7516:{f.Push(f.Locals[6]);f.Pc=7518;continue;}
case 7518:{f.Push(f.Locals[7]);f.Pc=7520;continue;}
case 7520:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",7523);}
case 7523:{f.Push(f.Locals[0]);f.Pc=7524;continue;}
case 7524:{f.Push(f.Locals[6]);f.Pc=7526;continue;}
case 7526:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",7531);}
case 7531:{f.Pc=9090;continue;}
case 7534:{f.Push(f.Locals[3]);f.Pc=7535;continue;}
case 7535:{f.Push(JValue.R(rt.String("Storm")));f.Pc=7538;continue;}
case 7538:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7541);}
case 7541:{f.Pc=f.Pop().Int==0?7608:7544;continue;}
case 7544:{f.Push(f.Locals[0]);f.Pc=7545;continue;}
case 7545:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",7550);}
case 7550:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:7550:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",7555);}
case 7555:{f.Locals[5]=f.Pop();f.Pc=7557;continue;}
case 7557:{f.Push(JValue.R(rt.String("DB$ CopySpellAbility | Defined$ TriggeredSpellAbility | Amount$ StormCount | MayChooseTarget$ True")));f.Pc=7560;continue;}
case 7560:{f.Locals[6]=f.Pop();f.Pc=7562;continue;}
case 7562:{f.Push(f.Locals[5]);f.Pc=7564;continue;}
case 7564:{f.Push(f.Locals[1]);f.Pc=7565;continue;}
case 7565:{f.Push(f.Locals[2]);f.Pc=7566;continue;}
case 7566:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",7569);}
case 7569:{f.Locals[7]=f.Pop();f.Pc=7571;continue;}
case 7571:{f.Push(f.Locals[6]);f.Pc=7573;continue;}
case 7573:{f.Push(f.Locals[1]);f.Pc=7574;continue;}
case 7574:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",7577);}
case 7577:{f.Locals[8]=f.Pop();f.Pc=7579;continue;}
case 7579:{f.Push(f.Locals[8]);f.Pc=7581;continue;}
case 7581:{f.Push(JValue.R(rt.String("StormCount")));f.Pc=7584;continue;}
case 7584:{f.Push(JValue.R(rt.String("TriggerCount$CurrentStormCount/Minus.1")));f.Pc=7587;continue;}
case 7587:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",7590);}
case 7590:{f.Push(f.Locals[7]);f.Pc=7592;continue;}
case 7592:{f.Push(f.Locals[8]);f.Pc=7594;continue;}
case 7594:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",7597);}
case 7597:{f.Push(f.Locals[0]);f.Pc=7598;continue;}
case 7598:{f.Push(f.Locals[7]);f.Pc=7600;continue;}
case 7600:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",7605);}
case 7605:{f.Pc=9090;continue;}
case 7608:{f.Push(f.Locals[3]);f.Pc=7609;continue;}
case 7609:{f.Push(JValue.R(rt.String("Suspend")));f.Pc=7612;continue;}
case 7612:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7615);}
case 7615:{f.Pc=f.Pop().Int==0?7840:7618;continue;}
case 7618:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=7621;continue;}
case 7621:{f.StackOp("dup");f.Pc=7622;continue;}
case 7622:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7625);}
case 7625:{f.Locals[5]=f.Pop();f.Pc=7627;continue;}
case 7627:{f.Push(f.Locals[5]);f.Pc=7629;continue;}
case 7629:{f.Push(JValue.R(rt.String("Mode$ Phase | Phase$ Upkeep | ValidPlayer$ You | TriggerZones$ Exile")));f.Pc=7632;continue;}
case 7632:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7635);}
case 7635:{f.StackOp("pop");f.Pc=7636;continue;}
case 7636:{f.Push(f.Locals[5]);f.Pc=7638;continue;}
case 7638:{f.Push(JValue.R(rt.String(" | IsPresent$ Card.Self+suspended | PresentZone$ Exile")));f.Pc=7641;continue;}
case 7641:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7644);}
case 7644:{f.StackOp("pop");f.Pc=7645;continue;}
case 7645:{f.Push(f.Locals[5]);f.Pc=7647;continue;}
case 7647:{f.Push(JValue.R(rt.String(" | Secondary$ True | TriggerDescription$ At the beginning of your upkeep, if this card is suspended, remove a time counter from it")));f.Pc=7650;continue;}
case 7650:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7653);}
case 7653:{f.StackOp("pop");f.Pc=7654;continue;}
case 7654:{f.Push(JValue.R(rt.String("DB$ RemoveCounter | Defined$ Self | CounterType$ TIME | CounterNum$ 1")));f.Pc=7657;continue;}
case 7657:{f.Locals[6]=f.Pop();f.Pc=7659;continue;}
case 7659:{f.Push(f.Locals[5]);f.Pc=7661;continue;}
case 7661:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",7664);}
case 7664:{f.Push(f.Locals[1]);f.Pc=7665;continue;}
case 7665:{f.Push(f.Locals[2]);f.Pc=7666;continue;}
case 7666:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",7669);}
case 7669:{f.Locals[7]=f.Pop();f.Pc=7671;continue;}
case 7671:{f.Push(f.Locals[7]);f.Pc=7673;continue;}
case 7673:{f.Push(JValue.R(rt.String("DB$ RemoveCounter | Defined$ Self | CounterType$ TIME | CounterNum$ 1")));f.Pc=7676;continue;}
case 7676:{f.Push(f.Locals[1]);f.Pc=7677;continue;}
case 7677:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",7680);}
case 7680:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",7683);}
case 7683:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=7686;continue;}
case 7686:{f.StackOp("dup");f.Pc=7687;continue;}
case 7687:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7690);}
case 7690:{f.Locals[8]=f.Pop();f.Pc=7692;continue;}
case 7692:{f.Push(f.Locals[8]);f.Pc=7694;continue;}
case 7694:{f.Push(JValue.R(rt.String("Mode$ CounterRemoved | TriggerZones$ Exile | ValidCard$ Card.Self | CounterType$ TIME | NewCounterAmount$ 0 | Secondary$ True")));f.Pc=7697;continue;}
case 7697:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7700);}
case 7700:{f.StackOp("pop");f.Pc=7701;continue;}
case 7701:{f.Push(f.Locals[8]);f.Pc=7703;continue;}
case 7703:{f.Push(JValue.R(rt.String(" | TriggerDescription$ When the last time counter is removed from this card, if it's exiled, you may play it without paying its mana cost if able. ")));f.Pc=7706;continue;}
case 7706:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7709);}
case 7709:{f.StackOp("pop");f.Pc=7710;continue;}
case 7710:{f.Push(f.Locals[8]);f.Pc=7712;continue;}
case 7712:{f.Push(JValue.R(rt.String("If you can't, it remains exiled. If you cast a creature spell this way, it gains haste until you lose control of the spell or the permanent it becomes.")));f.Pc=7715;continue;}
case 7715:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7718);}
case 7718:{f.StackOp("pop");f.Pc=7719;continue;}
case 7719:{f.Push(JValue.R(rt.String("DB$ Play | Defined$ Self | WithoutManaCost$ True | Optional$ True")));f.Pc=7722;continue;}
case 7722:{f.Locals[9]=f.Pop();f.Pc=7724;continue;}
case 7724:{f.Push(f.Locals[1]);f.Pc=7725;continue;}
case 7725:{return rt.Call(f,"forge/game/card/Card","isPermanent","()Z","invokevirtual",7728);}
case 7728:{f.Pc=f.Pop().Int==0?7740:7731;continue;}
case 7731:{f.Push(f.Locals[9]);f.Pc=7733;continue;}
case 7733:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:7733:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",7738);}
case 7738:{f.Locals[9]=f.Pop();f.Pc=7740;continue;}
case 7740:{f.Push(f.Locals[9]);f.Pc=7742;continue;}
case 7742:{f.Push(f.Locals[1]);f.Pc=7743;continue;}
case 7743:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",7746);}
case 7746:{f.Locals[10]=f.Pop();f.Pc=7748;continue;}
case 7748:{f.Push(f.Locals[1]);f.Pc=7749;continue;}
case 7749:{return rt.Call(f,"forge/game/card/Card","isPermanent","()Z","invokevirtual",7752);}
case 7752:{f.Pc=f.Pop().Int==0?7802:7755;continue;}
case 7755:{f.Push(JValue.R(rt.String("DB$ Pump | Defined$ Remembered | KW$ Haste | PumpZone$ Stack | ConditionDefined$ Remembered | ConditionPresent$ Creature | Duration$ UntilLoseControlOfHost")));f.Pc=7758;continue;}
case 7758:{f.Locals[11]=f.Pop();f.Pc=7760;continue;}
case 7760:{f.Push(JValue.R(rt.String("DB$ Pump | Defined$ Remembered | KW$ Haste | PumpZone$ Stack | ConditionDefined$ Remembered | ConditionPresent$ Creature | Duration$ UntilLoseControlOfHost")));f.Pc=7763;continue;}
case 7763:{f.Push(f.Locals[1]);f.Pc=7764;continue;}
case 7764:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",7767);}
case 7767:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7770;continue;}
case 7770:{f.Locals[12]=f.Pop();f.Pc=7772;continue;}
case 7772:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=7775;continue;}
case 7775:{f.Locals[13]=f.Pop();f.Pc=7777;continue;}
case 7777:{f.Push(f.Locals[13]);f.Pc=7779;continue;}
case 7779:{f.Push(f.Locals[1]);f.Pc=7780;continue;}
case 7780:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",7783);}
case 7783:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7786;continue;}
case 7786:{f.Locals[14]=f.Pop();f.Pc=7788;continue;}
case 7788:{f.Push(f.Locals[12]);f.Pc=7790;continue;}
case 7790:{f.Push(f.Locals[14]);f.Pc=7792;continue;}
case 7792:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",7795);}
case 7795:{f.Push(f.Locals[10]);f.Pc=7797;continue;}
case 7797:{f.Push(f.Locals[12]);f.Pc=7799;continue;}
case 7799:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",7802);}
case 7802:{f.Push(f.Locals[8]);f.Pc=7804;continue;}
case 7804:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",7807);}
case 7807:{f.Push(f.Locals[1]);f.Pc=7808;continue;}
case 7808:{f.Push(f.Locals[2]);f.Pc=7809;continue;}
case 7809:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",7812);}
case 7812:{f.Locals[11]=f.Pop();f.Pc=7814;continue;}
case 7814:{f.Push(f.Locals[11]);f.Pc=7816;continue;}
case 7816:{f.Push(f.Locals[10]);f.Pc=7818;continue;}
case 7818:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",7821);}
case 7821:{f.Push(f.Locals[0]);f.Pc=7822;continue;}
case 7822:{f.Push(f.Locals[7]);f.Pc=7824;continue;}
case 7824:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",7829);}
case 7829:{f.Push(f.Locals[0]);f.Pc=7830;continue;}
case 7830:{f.Push(f.Locals[11]);f.Pc=7832;continue;}
case 7832:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",7837);}
case 7837:{f.Pc=9090;continue;}
case 7840:{f.Push(f.Locals[3]);f.Pc=7841;continue;}
case 7841:{f.Push(JValue.R(rt.String("Training")));f.Pc=7844;continue;}
case 7844:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7847);}
case 7847:{f.Pc=f.Pop().Int==0?7920:7850;continue;}
case 7850:{f.Push(f.Locals[0]);f.Pc=7851;continue;}
case 7851:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",7856);}
case 7856:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:7856:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",7861);}
case 7861:{f.Locals[5]=f.Pop();f.Pc=7863;continue;}
case 7863:{f.Push(JValue.R(rt.String("DB$ PutCounter | CounterType$ P1P1 | CounterNum$ 1 | Defined$ Self | Training$ True")));f.Pc=7866;continue;}
case 7866:{f.Locals[6]=f.Pop();f.Pc=7868;continue;}
case 7868:{f.Push(f.Locals[5]);f.Pc=7870;continue;}
case 7870:{f.Push(f.Locals[1]);f.Pc=7871;continue;}
case 7871:{f.Push(f.Locals[2]);f.Pc=7872;continue;}
case 7872:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",7875);}
case 7875:{f.Locals[7]=f.Pop();f.Pc=7877;continue;}
case 7877:{f.Push(JValue.R(rt.String("DB$ PutCounter | CounterType$ P1P1 | CounterNum$ 1 | Defined$ Self | Training$ True")));f.Pc=7880;continue;}
case 7880:{f.Push(f.Locals[1]);f.Pc=7881;continue;}
case 7881:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",7884);}
case 7884:{f.Locals[8]=f.Pop();f.Pc=7886;continue;}
case 7886:{f.Push(f.Locals[7]);f.Pc=7888;continue;}
case 7888:{f.Push(JValue.R(rt.String("X")));f.Pc=7890;continue;}
case 7890:{f.Push(JValue.R(rt.String("Count$CardPower")));f.Pc=7893;continue;}
case 7893:{return rt.Call(f,"forge/game/trigger/Trigger","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",7896);}
case 7896:{f.Push(f.Locals[8]);f.Pc=7898;continue;}
case 7898:{f.Push(f.Locals[2]);f.Pc=7899;continue;}
case 7899:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",7902);}
case 7902:{f.Push(f.Locals[7]);f.Pc=7904;continue;}
case 7904:{f.Push(f.Locals[8]);f.Pc=7906;continue;}
case 7906:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",7909);}
case 7909:{f.Push(f.Locals[0]);f.Pc=7910;continue;}
case 7910:{f.Push(f.Locals[7]);f.Pc=7912;continue;}
case 7912:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",7917);}
case 7917:{f.Pc=9090;continue;}
case 7920:{f.Push(f.Locals[3]);f.Pc=7921;continue;}
case 7921:{f.Push(JValue.R(rt.String("Tribute")));f.Pc=7924;continue;}
case 7924:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7927);}
case 7927:{f.Pc=f.Pop().Int==0?7987:7930;continue;}
case 7930:{f.Push(JValue.R(rt.String("TrigNotTribute")));f.Pc=7933;continue;}
case 7933:{f.Locals[5]=f.Pop();f.Pc=7935;continue;}
case 7935:{f.Push(f.Locals[1]);f.Pc=7936;continue;}
case 7936:{f.Push(JValue.R(rt.String("TrigNotTribute")));f.Pc=7939;continue;}
case 7939:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",7942);}
case 7942:{return rt.Call(f,"forge/game/ability/AbilityFactory","getMapParams","(Ljava/lang/String;)Ljava/util/Map;","invokestatic",7945);}
case 7945:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=7948;continue;}
case 7948:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",7953);}
case 7953:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7956;continue;}
case 7956:{f.Locals[6]=f.Pop();f.Pc=7958;continue;}
case 7958:{f.Push(f.Locals[6]);f.Pc=7960;continue;}
case 7960:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:7960:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",7965);}
case 7965:{f.Locals[7]=f.Pop();f.Pc=7967;continue;}
case 7967:{f.Push(f.Locals[7]);f.Pc=7969;continue;}
case 7969:{f.Push(f.Locals[1]);f.Pc=7970;continue;}
case 7970:{f.Push(f.Locals[2]);f.Pc=7971;continue;}
case 7971:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",7974);}
case 7974:{f.Locals[8]=f.Pop();f.Pc=7976;continue;}
case 7976:{f.Push(f.Locals[0]);f.Pc=7977;continue;}
case 7977:{f.Push(f.Locals[8]);f.Pc=7979;continue;}
case 7979:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",7984);}
case 7984:{f.Pc=9090;continue;}
case 7987:{f.Push(f.Locals[3]);f.Pc=7988;continue;}
case 7988:{f.Push(JValue.R(rt.String("Undying")));f.Pc=7991;continue;}
case 7991:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7994);}
case 7994:{f.Pc=f.Pop().Int==0?8047:7997;continue;}
case 7997:{f.Push(f.Locals[0]);f.Pc=7998;continue;}
case 7998:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",8003);}
case 8003:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:8003:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",8008);}
case 8008:{f.Locals[5]=f.Pop();f.Pc=8010;continue;}
case 8010:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ TriggeredNewCardLKICopy | Origin$ Graveyard | Destination$ Battlefield | WithCountersType$ P1P1")));f.Pc=8013;continue;}
case 8013:{f.Locals[6]=f.Pop();f.Pc=8015;continue;}
case 8015:{f.Push(f.Locals[5]);f.Pc=8017;continue;}
case 8017:{f.Push(f.Locals[1]);f.Pc=8018;continue;}
case 8018:{f.Push(f.Locals[2]);f.Pc=8019;continue;}
case 8019:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",8022);}
case 8022:{f.Locals[7]=f.Pop();f.Pc=8024;continue;}
case 8024:{f.Push(f.Locals[7]);f.Pc=8026;continue;}
case 8026:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ TriggeredNewCardLKICopy | Origin$ Graveyard | Destination$ Battlefield | WithCountersType$ P1P1")));f.Pc=8029;continue;}
case 8029:{f.Push(f.Locals[1]);f.Pc=8030;continue;}
case 8030:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",8033);}
case 8033:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",8036);}
case 8036:{f.Push(f.Locals[0]);f.Pc=8037;continue;}
case 8037:{f.Push(f.Locals[7]);f.Pc=8039;continue;}
case 8039:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",8044);}
case 8044:{f.Pc=9090;continue;}
case 8047:{f.Push(f.Locals[3]);f.Pc=8048;continue;}
case 8048:{f.Push(JValue.R(rt.String("Vanishing")));f.Pc=8051;continue;}
case 8051:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8054);}
case 8054:{f.Pc=f.Pop().Int==0?8188:8057;continue;}
case 8057:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=8060;continue;}
case 8060:{f.StackOp("dup");f.Pc=8061;continue;}
case 8061:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",8064);}
case 8064:{f.Locals[5]=f.Pop();f.Pc=8066;continue;}
case 8066:{f.Push(f.Locals[5]);f.Pc=8068;continue;}
case 8068:{f.Push(JValue.R(rt.String("Mode$ Phase | Phase$ Upkeep | ValidPlayer$ You | TriggerZones$ Battlefield | IsPresent$ Card.Self+counters_GE1_TIME")));f.Pc=8071;continue;}
case 8071:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8074);}
case 8074:{f.StackOp("pop");f.Pc=8075;continue;}
case 8075:{f.Push(f.Locals[5]);f.Pc=8077;continue;}
case 8077:{f.Push(JValue.R(rt.String(" | Secondary$ True | TriggerDescription$ At the beginning of your upkeep, if CARDNAME has a time counter on it, remove a time counter from it.")));f.Pc=8080;continue;}
case 8080:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8083);}
case 8083:{f.StackOp("pop");f.Pc=8084;continue;}
case 8084:{f.Push(JValue.R(rt.String("DB$ RemoveCounter | Defined$ Self | CounterType$ TIME | CounterNum$ 1")));f.Pc=8087;continue;}
case 8087:{f.Locals[6]=f.Pop();f.Pc=8089;continue;}
case 8089:{f.Push(f.Locals[5]);f.Pc=8091;continue;}
case 8091:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",8094);}
case 8094:{f.Push(f.Locals[1]);f.Pc=8095;continue;}
case 8095:{f.Push(f.Locals[2]);f.Pc=8096;continue;}
case 8096:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",8099);}
case 8099:{f.Locals[7]=f.Pop();f.Pc=8101;continue;}
case 8101:{f.Push(f.Locals[7]);f.Pc=8103;continue;}
case 8103:{f.Push(JValue.R(rt.String("DB$ RemoveCounter | Defined$ Self | CounterType$ TIME | CounterNum$ 1")));f.Pc=8106;continue;}
case 8106:{f.Push(f.Locals[1]);f.Pc=8107;continue;}
case 8107:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",8110);}
case 8110:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",8113);}
case 8113:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=8116;continue;}
case 8116:{f.StackOp("dup");f.Pc=8117;continue;}
case 8117:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",8120);}
case 8120:{f.Locals[8]=f.Pop();f.Pc=8122;continue;}
case 8122:{f.Push(f.Locals[8]);f.Pc=8124;continue;}
case 8124:{f.Push(JValue.R(rt.String("Mode$ CounterRemoved | TriggerZones$ Battlefield | ValidCard$ Card.Self | NewCounterAmount$ 0 | CounterType$ TIME | Secondary$ True")));f.Pc=8127;continue;}
case 8127:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8130);}
case 8130:{f.StackOp("pop");f.Pc=8131;continue;}
case 8131:{f.Push(f.Locals[8]);f.Pc=8133;continue;}
case 8133:{f.Push(JValue.R(rt.String("| TriggerDescription$ When the last time counter is removed from CARDNAME, sacrifice it.")));f.Pc=8136;continue;}
case 8136:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8139);}
case 8139:{f.StackOp("pop");f.Pc=8140;continue;}
case 8140:{f.Push(JValue.R(rt.String("DB$ Sacrifice | SacValid$ Self")));f.Pc=8143;continue;}
case 8143:{f.Locals[9]=f.Pop();f.Pc=8145;continue;}
case 8145:{f.Push(f.Locals[8]);f.Pc=8147;continue;}
case 8147:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",8150);}
case 8150:{f.Push(f.Locals[1]);f.Pc=8151;continue;}
case 8151:{f.Push(f.Locals[2]);f.Pc=8152;continue;}
case 8152:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",8155);}
case 8155:{f.Locals[10]=f.Pop();f.Pc=8157;continue;}
case 8157:{f.Push(f.Locals[10]);f.Pc=8159;continue;}
case 8159:{f.Push(JValue.R(rt.String("DB$ Sacrifice | SacValid$ Self")));f.Pc=8162;continue;}
case 8162:{f.Push(f.Locals[1]);f.Pc=8163;continue;}
case 8163:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",8166);}
case 8166:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",8169);}
case 8169:{f.Push(f.Locals[0]);f.Pc=8170;continue;}
case 8170:{f.Push(f.Locals[7]);f.Pc=8172;continue;}
case 8172:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",8177);}
case 8177:{f.Push(f.Locals[0]);f.Pc=8178;continue;}
case 8178:{f.Push(f.Locals[10]);f.Pc=8180;continue;}
case 8180:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",8185);}
case 8185:{f.Pc=9090;continue;}
case 8188:{f.Push(f.Locals[3]);f.Pc=8189;continue;}
case 8189:{f.Push(JValue.R(rt.String("Visit")));f.Pc=8192;continue;}
case 8192:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8195);}
case 8195:{f.Pc=f.Pop().Int==0?8268:8198;continue;}
case 8198:{f.Push(f.Locals[3]);f.Pc=8199;continue;}
case 8199:{f.Push(JValue.R(rt.String(":")));f.Pc=8202;continue;}
case 8202:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",8205);}
case 8205:{f.Locals[5]=f.Pop();f.Pc=8207;continue;}
case 8207:{f.Push(f.Locals[1]);f.Pc=8208;continue;}
case 8208:{f.Push(f.Locals[5]);f.Pc=8210;continue;}
case 8210:{f.Push(JValue.I(1));f.Pc=8211;continue;}
case 8211:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8212;continue;}
case 8212:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/Card;Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokestatic",8215);}
case 8215:{f.Locals[6]=f.Pop();f.Pc=8217;continue;}
case 8217:{f.Push(f.Locals[6]);f.Pc=8219;continue;}
case 8219:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",8222);}
case 8222:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",8225);}
case 8225:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:8225:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",8230);}
case 8230:{f.Locals[7]=f.Pop();f.Pc=8232;continue;}
case 8232:{f.Push(f.Locals[7]);f.Pc=8234;continue;}
case 8234:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:8234:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",8239);}
case 8239:{f.Locals[8]=f.Pop();f.Pc=8241;continue;}
case 8241:{f.Push(f.Locals[8]);f.Pc=8243;continue;}
case 8243:{f.Push(f.Locals[1]);f.Pc=8244;continue;}
case 8244:{f.Push(f.Locals[2]);f.Pc=8245;continue;}
case 8245:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",8248);}
case 8248:{f.Locals[9]=f.Pop();f.Pc=8250;continue;}
case 8250:{f.Push(f.Locals[9]);f.Pc=8252;continue;}
case 8252:{f.Push(f.Locals[6]);f.Pc=8254;continue;}
case 8254:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",8257);}
case 8257:{f.Push(f.Locals[0]);f.Pc=8258;continue;}
case 8258:{f.Push(f.Locals[9]);f.Pc=8260;continue;}
case 8260:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",8265);}
case 8265:{f.Pc=9090;continue;}
case 8268:{f.Push(f.Locals[3]);f.Pc=8269;continue;}
case 8269:{f.Push(JValue.R(rt.String("Prize")));f.Pc=8272;continue;}
case 8272:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8275);}
case 8275:{f.Pc=f.Pop().Int==0?8348:8278;continue;}
case 8278:{f.Push(f.Locals[3]);f.Pc=8279;continue;}
case 8279:{f.Push(JValue.R(rt.String(":")));f.Pc=8282;continue;}
case 8282:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",8285);}
case 8285:{f.Locals[5]=f.Pop();f.Pc=8287;continue;}
case 8287:{f.Push(f.Locals[1]);f.Pc=8288;continue;}
case 8288:{f.Push(f.Locals[5]);f.Pc=8290;continue;}
case 8290:{f.Push(JValue.I(1));f.Pc=8291;continue;}
case 8291:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8292;continue;}
case 8292:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/Card;Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokestatic",8295);}
case 8295:{f.Locals[6]=f.Pop();f.Pc=8297;continue;}
case 8297:{f.Push(f.Locals[6]);f.Pc=8299;continue;}
case 8299:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",8302);}
case 8302:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",8305);}
case 8305:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:8305:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",8310);}
case 8310:{f.Locals[7]=f.Pop();f.Pc=8312;continue;}
case 8312:{f.Push(f.Locals[7]);f.Pc=8314;continue;}
case 8314:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:8314:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",8319);}
case 8319:{f.Locals[8]=f.Pop();f.Pc=8321;continue;}
case 8321:{f.Push(f.Locals[8]);f.Pc=8323;continue;}
case 8323:{f.Push(f.Locals[1]);f.Pc=8324;continue;}
case 8324:{f.Push(f.Locals[2]);f.Pc=8325;continue;}
case 8325:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",8328);}
case 8328:{f.Locals[9]=f.Pop();f.Pc=8330;continue;}
case 8330:{f.Push(f.Locals[9]);f.Pc=8332;continue;}
case 8332:{f.Push(f.Locals[6]);f.Pc=8334;continue;}
case 8334:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",8337);}
case 8337:{f.Push(f.Locals[0]);f.Pc=8338;continue;}
case 8338:{f.Push(f.Locals[9]);f.Pc=8340;continue;}
case 8340:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",8345);}
case 8345:{f.Pc=9090;continue;}
case 8348:{f.Push(f.Locals[3]);f.Pc=8349;continue;}
case 8349:{f.Push(JValue.R(rt.String("Dungeon")));f.Pc=8352;continue;}
case 8352:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8355);}
case 8355:{f.Pc=f.Pop().Int==0?8734:8358;continue;}
case 8358:{f.Push(f.Locals[3]);f.Pc=8359;continue;}
case 8359:{f.Push(JValue.R(rt.String("Dungeon:")));f.Pc=8362;continue;}
case 8362:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",8365);}
case 8365:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",8368);}
case 8368:{f.Push(JValue.R(rt.String(",")));f.Pc=8371;continue;}
case 8371:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",8374);}
case 8374:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",8377);}
case 8377:{f.Locals[5]=f.Pop();f.Pc=8379;continue;}
case 8379:{if(!rt.EnsureInitialized(f,"java/util/LinkedHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/LinkedHashMap")));f.Pc=8382;continue;}
case 8382:{f.StackOp("dup");f.Pc=8383;continue;}
case 8383:{return rt.Call(f,"java/util/LinkedHashMap","<init>","()V","invokespecial",8386);}
case 8386:{f.Locals[6]=f.Pop();f.Pc=8388;continue;}
case 8388:{f.Push(f.Locals[5]);f.Pc=8390;continue;}
case 8390:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",8395);}
case 8395:{f.Locals[7]=f.Pop();f.Pc=8397;continue;}
case 8397:{f.Push(f.Locals[7]);f.Pc=8399;continue;}
case 8399:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",8404);}
case 8404:{f.Pc=f.Pop().Int==0?8438:8407;continue;}
case 8407:{f.Push(f.Locals[7]);f.Pc=8409;continue;}
case 8409:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",8414);}
case 8414:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8417;continue;}
case 8417:{f.Locals[8]=f.Pop();f.Pc=8419;continue;}
case 8419:{f.Push(f.Locals[6]);f.Pc=8421;continue;}
case 8421:{f.Push(f.Locals[8]);f.Pc=8423;continue;}
case 8423:{f.Push(f.Locals[1]);f.Pc=8424;continue;}
case 8424:{f.Push(f.Locals[8]);f.Pc=8426;continue;}
case 8426:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/Card;Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokestatic",8429);}
case 8429:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",8434);}
case 8434:{f.StackOp("pop");f.Pc=8435;continue;}
case 8435:{f.Pc=8397;continue;}
case 8438:{f.Push(f.Locals[6]);f.Pc=8440;continue;}
case 8440:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",8445);}
case 8445:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",8450);}
case 8450:{f.Locals[7]=f.Pop();f.Pc=8452;continue;}
case 8452:{f.Push(f.Locals[7]);f.Pc=8454;continue;}
case 8454:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",8459);}
case 8459:{f.Pc=f.Pop().Int==0?8731:8462;continue;}
case 8462:{f.Push(f.Locals[7]);f.Pc=8464;continue;}
case 8464:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",8469);}
case 8469:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8472;continue;}
case 8472:{f.Locals[8]=f.Pop();f.Pc=8474;continue;}
case 8474:{f.Push(f.Locals[8]);f.Pc=8476;continue;}
case 8476:{f.Push(JValue.R(rt.String("RoomName")));f.Pc=8479;continue;}
case 8479:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",8482);}
case 8482:{f.Locals[9]=f.Pop();f.Pc=8484;continue;}
case 8484:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=8487;continue;}
case 8487:{f.StackOp("dup");f.Pc=8488;continue;}
case 8488:{f.Push(JValue.R(rt.String("Mode$ RoomEntered | TriggerZones$ Command")));f.Pc=8491;continue;}
case 8491:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",8494);}
case 8494:{f.Locals[10]=f.Pop();f.Pc=8496;continue;}
case 8496:{f.Push(f.Locals[10]);f.Pc=8498;continue;}
case 8498:{f.Push(JValue.R(rt.String(" | ValidCard$ Card.Self | ValidRoom$ ")));f.Pc=8501;continue;}
case 8501:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8504);}
case 8504:{f.Push(f.Locals[9]);f.Pc=8506;continue;}
case 8506:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8509);}
case 8509:{f.StackOp("pop");f.Pc=8510;continue;}
case 8510:{f.Push(f.Locals[10]);f.Pc=8512;continue;}
case 8512:{f.Push(JValue.R(rt.String(" | TriggerDescription$ ")));f.Pc=8515;continue;}
case 8515:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8518);}
case 8518:{f.Push(f.Locals[9]);f.Pc=8520;continue;}
case 8520:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8523);}
case 8523:{f.Push(JValue.R(rt.String(" \u2014 ")));f.Pc=8525;continue;}
case 8525:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8528);}
case 8528:{f.Push(f.Locals[8]);f.Pc=8530;continue;}
case 8530:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",8533);}
case 8533:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",8536);}
case 8536:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8539);}
case 8539:{f.StackOp("pop");f.Pc=8540;continue;}
case 8540:{f.Push(f.Locals[8]);f.Pc=8542;continue;}
case 8542:{f.Push(JValue.R(rt.String("NextRoom")));f.Pc=8545;continue;}
case 8545:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",8548);}
case 8548:{f.Pc=f.Pop().Int==0?8701:8551;continue;}
case 8551:{f.Push(JValue.I(1));f.Pc=8552;continue;}
case 8552:{f.Locals[11]=f.Pop();f.Pc=8554;continue;}
case 8554:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=8557;continue;}
case 8557:{f.StackOp("dup");f.Pc=8558;continue;}
case 8558:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",8561);}
case 8561:{f.Locals[12]=f.Pop();f.Pc=8563;continue;}
case 8563:{f.Push(f.Locals[10]);f.Pc=8565;continue;}
case 8565:{f.Push(JValue.R(rt.String("  (Leads to: ")));f.Pc=8568;continue;}
case 8568:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8571);}
case 8571:{f.StackOp("pop");f.Pc=8572;continue;}
case 8572:{f.Push(f.Locals[8]);f.Pc=8574;continue;}
case 8574:{f.Push(JValue.R(rt.String("NextRoom")));f.Pc=8577;continue;}
case 8577:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",8580);}
case 8580:{f.Push(JValue.R(rt.String(",")));f.Pc=8583;continue;}
case 8583:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",8586);}
case 8586:{f.Locals[13]=f.Pop();f.Pc=8588;continue;}
case 8588:{f.Push(f.Locals[13]);f.Pc=8590;continue;}
case 8590:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=8591;continue;}
case 8591:{f.Locals[14]=f.Pop();f.Pc=8593;continue;}
case 8593:{f.Push(JValue.I(0));f.Pc=8594;continue;}
case 8594:{f.Locals[15]=f.Pop();f.Pc=8596;continue;}
case 8596:{f.Push(f.Locals[15]);f.Pc=8598;continue;}
case 8598:{f.Push(f.Locals[14]);f.Pc=8600;continue;}
case 8600:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?8678:8603;continue;}
case 8603:{f.Push(f.Locals[13]);f.Pc=8605;continue;}
case 8605:{f.Push(f.Locals[15]);f.Pc=8607;continue;}
case 8607:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8608;continue;}
case 8608:{f.Locals[16]=f.Pop();f.Pc=8610;continue;}
case 8610:{f.Push(f.Locals[11]);f.Pc=8612;continue;}
case 8612:{f.Pc=f.Pop().Int!=0?8633:8615;continue;}
case 8615:{f.Push(f.Locals[10]);f.Pc=8617;continue;}
case 8617:{f.Push(JValue.R(rt.String(", ")));f.Pc=8620;continue;}
case 8620:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8623);}
case 8623:{f.StackOp("pop");f.Pc=8624;continue;}
case 8624:{f.Push(f.Locals[12]);f.Pc=8626;continue;}
case 8626:{f.Push(JValue.R(rt.String(",")));f.Pc=8629;continue;}
case 8629:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8632);}
case 8632:{f.StackOp("pop");f.Pc=8633;continue;}
case 8633:{f.Push(f.Locals[6]);f.Pc=8635;continue;}
case 8635:{f.Push(f.Locals[16]);f.Pc=8637;continue;}
case 8637:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",8642);}
case 8642:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8645;continue;}
case 8645:{f.Push(JValue.R(rt.String("RoomName")));f.Pc=8648;continue;}
case 8648:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",8651);}
case 8651:{f.Locals[17]=f.Pop();f.Pc=8653;continue;}
case 8653:{f.Push(f.Locals[10]);f.Pc=8655;continue;}
case 8655:{f.Push(f.Locals[17]);f.Pc=8657;continue;}
case 8657:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8660);}
case 8660:{f.StackOp("pop");f.Pc=8661;continue;}
case 8661:{f.Push(f.Locals[12]);f.Pc=8663;continue;}
case 8663:{f.Push(f.Locals[17]);f.Pc=8665;continue;}
case 8665:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8668);}
case 8668:{f.StackOp("pop");f.Pc=8669;continue;}
case 8669:{f.Push(JValue.I(0));f.Pc=8670;continue;}
case 8670:{f.Locals[11]=f.Pop();f.Pc=8672;continue;}
case 8672:{f.Locals[15]=JValue.I(unchecked(f.Locals[15].Int+(1)));f.Pc=8675;continue;}
case 8675:{f.Pc=8596;continue;}
case 8678:{f.Push(f.Locals[10]);f.Pc=8680;continue;}
case 8680:{f.Push(JValue.R(rt.String(")")));f.Pc=8683;continue;}
case 8683:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8686);}
case 8686:{f.StackOp("pop");f.Pc=8687;continue;}
case 8687:{f.Push(f.Locals[8]);f.Pc=8689;continue;}
case 8689:{f.Push(JValue.R(rt.String("NextRoomName")));f.Pc=8692;continue;}
case 8692:{f.Push(f.Locals[12]);f.Pc=8694;continue;}
case 8694:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",8697);}
case 8697:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",8700);}
case 8700:{f.StackOp("pop");f.Pc=8701;continue;}
case 8701:{f.Push(f.Locals[10]);f.Pc=8703;continue;}
case 8703:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",8706);}
case 8706:{f.Push(f.Locals[1]);f.Pc=8707;continue;}
case 8707:{f.Push(JValue.I(0));f.Pc=8708;continue;}
case 8708:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",8711);}
case 8711:{f.Locals[11]=f.Pop();f.Pc=8713;continue;}
case 8713:{f.Push(f.Locals[11]);f.Pc=8715;continue;}
case 8715:{f.Push(f.Locals[8]);f.Pc=8717;continue;}
case 8717:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",8720);}
case 8720:{f.Push(f.Locals[0]);f.Pc=8721;continue;}
case 8721:{f.Push(f.Locals[11]);f.Pc=8723;continue;}
case 8723:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",8728);}
case 8728:{f.Pc=8452;continue;}
case 8731:{f.Pc=9090;continue;}
case 8734:{f.Push(f.Locals[3]);f.Pc=8735;continue;}
case 8735:{f.Push(JValue.R(rt.String("Ward")));f.Pc=8738;continue;}
case 8738:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8741);}
case 8741:{f.Pc=f.Pop().Int==0?9014:8744;continue;}
case 8744:{f.Push(f.Locals[0]);f.Pc=8745;continue;}
case 8745:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/Ward")?1:0));f.Pc=8748;continue;}
case 8748:{f.Pc=f.Pop().Int==0?9014:8751;continue;}
case 8751:{f.Push(f.Locals[0]);f.Pc=8752;continue;}
case 8752:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/Ward"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8755;continue;}
case 8755:{f.Locals[4]=f.Pop();f.Pc=8757;continue;}
case 8757:{f.Push(f.Locals[0]);f.Pc=8758;continue;}
case 8758:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getTitle","()Ljava/lang/String;","invokeinterface",8763);}
case 8763:{f.Push(f.Locals[0]);f.Pc=8764;continue;}
case 8764:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",8769);}
case 8769:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:8769:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",8774);}
case 8774:{f.Locals[5]=f.Pop();f.Pc=8776;continue;}
case 8776:{f.Push(f.Locals[5]);f.Pc=8778;continue;}
case 8778:{f.Push(f.Locals[1]);f.Pc=8779;continue;}
case 8779:{f.Push(f.Locals[2]);f.Pc=8780;continue;}
case 8780:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",8783);}
case 8783:{f.Locals[6]=f.Pop();f.Pc=8785;continue;}
case 8785:{f.Push(f.Locals[4]);f.Pc=8787;continue;}
case 8787:{return rt.Call(f,"forge/game/keyword/Ward","getCostString","()Ljava/lang/String;","invokevirtual",8790);}
case 8790:{f.Pc=f.Pop().Reference==null?8819:8793;continue;}
case 8793:{f.Push(f.Locals[4]);f.Pc=8795;continue;}
case 8795:{return rt.Call(f,"forge/game/keyword/Ward","getCostString","()Ljava/lang/String;","invokevirtual",8798);}
case 8798:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:8798:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",8803);}
case 8803:{f.Locals[7]=f.Pop();f.Pc=8805;continue;}
case 8805:{f.Push(f.Locals[6]);f.Pc=8807;continue;}
case 8807:{f.Push(f.Locals[7]);f.Pc=8809;continue;}
case 8809:{f.Push(f.Locals[1]);f.Pc=8810;continue;}
case 8810:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",8813);}
case 8813:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",8816);}
case 8816:{f.Pc=9003;continue;}
case 8819:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",8822);}
case 8822:{f.Locals[7]=f.Pop();f.Pc=8824;continue;}
case 8824:{f.Push(f.Locals[4]);f.Pc=8826;continue;}
case 8826:{return rt.Call(f,"forge/game/keyword/Ward","getCosts","()Ljava/util/Map;","invokevirtual",8829);}
case 8829:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",8834);}
case 8834:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",8839);}
case 8839:{f.Locals[8]=f.Pop();f.Pc=8841;continue;}
case 8841:{f.Push(f.Locals[8]);f.Pc=8843;continue;}
case 8843:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",8848);}
case 8848:{f.Pc=f.Pop().Int==0?8958:8851;continue;}
case 8851:{f.Push(f.Locals[8]);f.Pc=8853;continue;}
case 8853:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",8858);}
case 8858:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8861;continue;}
case 8861:{f.Locals[9]=f.Pop();f.Pc=8863;continue;}
case 8863:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=8866;continue;}
case 8866:{f.StackOp("dup");f.Pc=8867;continue;}
case 8867:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",8870);}
case 8870:{f.Locals[10]=f.Pop();f.Pc=8872;continue;}
case 8872:{f.Push(f.Locals[9]);f.Pc=8874;continue;}
case 8874:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",8879);}
case 8879:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/Cost"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8882;continue;}
case 8882:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",8885);}
case 8885:{f.Pc=f.Pop().Int==0?8897:8888;continue;}
case 8888:{f.Push(f.Locals[10]);f.Pc=8890;continue;}
case 8890:{f.Push(JValue.R(rt.String("Pay ")));f.Pc=8893;continue;}
case 8893:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8896);}
case 8896:{f.StackOp("pop");f.Pc=8897;continue;}
case 8897:{f.Push(f.Locals[10]);f.Pc=8899;continue;}
case 8899:{f.Push(f.Locals[9]);f.Pc=8901;continue;}
case 8901:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",8906);}
case 8906:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/Cost"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8909;continue;}
case 8909:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",8912);}
case 8912:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8915);}
case 8915:{f.StackOp("pop");f.Pc=8916;continue;}
case 8916:{f.Push(f.Locals[9]);f.Pc=8918;continue;}
case 8918:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",8923);}
case 8923:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8926;continue;}
case 8926:{f.Push(f.Locals[10]);f.Pc=8928;continue;}
case 8928:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",8931);}
case 8931:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5025:8931:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",8936);}
case 8936:{f.Locals[11]=f.Pop();f.Pc=8938;continue;}
case 8938:{f.Push(f.Locals[7]);f.Pc=8940;continue;}
case 8940:{f.Push(f.Locals[11]);f.Pc=8942;continue;}
case 8942:{f.Push(f.Locals[1]);f.Pc=8943;continue;}
case 8943:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",8946);}
case 8946:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8949;continue;}
case 8949:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",8954);}
case 8954:{f.StackOp("pop");f.Pc=8955;continue;}
case 8955:{f.Pc=8841;continue;}
case 8958:{f.Push(JValue.R(rt.String("DB$ GenericChoice | Defined$ TriggeredSourceSAController | AILogic$ PayUnlessCost")));f.Pc=8961;continue;}
case 8961:{f.Locals[8]=f.Pop();f.Pc=8963;continue;}
case 8963:{f.Push(f.Locals[8]);f.Pc=8965;continue;}
case 8965:{f.Push(f.Locals[1]);f.Pc=8966;continue;}
case 8966:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",8969);}
case 8969:{f.Locals[9]=f.Pop();f.Pc=8971;continue;}
case 8971:{f.Push(f.Locals[9]);f.Pc=8973;continue;}
case 8973:{f.Push(JValue.R(rt.String("Choices")));f.Pc=8976;continue;}
case 8976:{f.Push(f.Locals[7]);f.Pc=8978;continue;}
case 8978:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAdditionalAbilityList","(Ljava/lang/String;Ljava/util/List;)V","invokevirtual",8981);}
case 8981:{f.Push(f.Locals[9]);f.Pc=8983;continue;}
case 8983:{f.Push(JValue.R(rt.String("FallbackAbility")));f.Pc=8986;continue;}
case 8986:{f.Push(JValue.R(rt.String("DB$ Counter | Defined$ TriggeredSourceSA")));f.Pc=8989;continue;}
case 8989:{f.Push(f.Locals[1]);f.Pc=8990;continue;}
case 8990:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",8993);}
case 8993:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAdditionalAbility","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)V","invokevirtual",8996);}
case 8996:{f.Push(f.Locals[6]);f.Pc=8998;continue;}
case 8998:{f.Push(f.Locals[9]);f.Pc=9000;continue;}
case 9000:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",9003);}
case 9003:{f.Push(f.Locals[0]);f.Pc=9004;continue;}
case 9004:{f.Push(f.Locals[6]);f.Pc=9006;continue;}
case 9006:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",9011);}
case 9011:{f.Pc=9090;continue;}
case 9014:{f.Push(f.Locals[3]);f.Pc=9015;continue;}
case 9015:{f.Push(JValue.R(rt.String("MayFlashSac")));f.Pc=9018;continue;}
case 9018:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",9021);}
case 9021:{f.Pc=f.Pop().Int==0?9090:9024;continue;}
case 9024:{f.Push(JValue.R(rt.String("Mode$ SpellCast | ValidCard$ Card.Self | ValidSA$ Spell.MayPlaySource | Static$ True | Secondary$ True  | TriggerDescription$ If you cast it any time a sorcery couldn't have been cast, the controller of the permanent it becomes sacrifices it at the beginning of the next cleanup step.")));f.Pc=9027;continue;}
case 9027:{f.Locals[5]=f.Pop();f.Pc=9029;continue;}
case 9029:{f.Push(JValue.R(rt.String("DB$ DelayedTrigger | Mode$ Phase | Phase$ Cleanup | RememberObjects$ Self | TriggerDescription$ At the beginning of the next cleanup step, sacrifice CARDNAME.")));f.Pc=9032;continue;}
case 9032:{f.Locals[6]=f.Pop();f.Pc=9034;continue;}
case 9034:{f.Push(JValue.R(rt.String("DB$ SacrificeAll | Defined$ DelayTriggerRememberedLKI")));f.Pc=9037;continue;}
case 9037:{f.Locals[7]=f.Pop();f.Pc=9039;continue;}
case 9039:{f.Push(JValue.R(rt.String("DB$ DelayedTrigger | Mode$ Phase | Phase$ Cleanup | RememberObjects$ Self | TriggerDescription$ At the beginning of the next cleanup step, sacrifice CARDNAME.")));f.Pc=9042;continue;}
case 9042:{f.Push(f.Locals[1]);f.Pc=9043;continue;}
case 9043:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",9046);}
case 9046:{f.Locals[8]=f.Pop();f.Pc=9048;continue;}
case 9048:{f.Push(f.Locals[8]);f.Pc=9050;continue;}
case 9050:{f.Push(JValue.R(rt.String("Execute")));f.Pc=9053;continue;}
case 9053:{f.Push(JValue.R(rt.String("DB$ SacrificeAll | Defined$ DelayTriggerRememberedLKI")));f.Pc=9056;continue;}
case 9056:{f.Push(f.Locals[1]);f.Pc=9057;continue;}
case 9057:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",9060);}
case 9060:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9063;continue;}
case 9063:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAdditionalAbility","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)V","invokevirtual",9066);}
case 9066:{f.Push(f.Locals[5]);f.Pc=9068;continue;}
case 9068:{f.Push(f.Locals[1]);f.Pc=9069;continue;}
case 9069:{f.Push(f.Locals[2]);f.Pc=9070;continue;}
case 9070:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",9073);}
case 9073:{f.Locals[9]=f.Pop();f.Pc=9075;continue;}
case 9075:{f.Push(f.Locals[9]);f.Pc=9077;continue;}
case 9077:{f.Push(f.Locals[8]);f.Pc=9079;continue;}
case 9079:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",9082);}
case 9082:{f.Push(f.Locals[0]);f.Pc=9083;continue;}
case 9083:{f.Push(f.Locals[9]);f.Pc=9085;continue;}
case 9085:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V","invokeinterface",9090);}
case 9090:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5026(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("Absorb")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?154:24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String(":")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Locals[9]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[9]);f.Pc=36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=38;continue;}
case 38:{f.Locals[10]=f.Pop();f.Pc=40;continue;}
case 40:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=43;continue;}
case 43:{f.StackOp("dup");f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",47);}
case 47:{f.Locals[11]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[11]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("Event$ DamageDone | ActiveZones$ Battlefield | ValidTarget$ Card.Self")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",57);}
case 57:{f.StackOp("pop");f.Pc=58;continue;}
case 58:{f.Push(f.Locals[11]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String(" | PreventionEffect$ True | Secondary$ True | Description$ Absorb ")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",66);}
case 66:{f.Push(f.Locals[10]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Push(f.Locals[11]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String(" (")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",80);}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",86);}
case 86:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",89);}
case 89:{f.Push(JValue.R(rt.String(")")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",95);}
case 95:{f.StackOp("pop");f.Pc=96;continue;}
case 96:{f.Push(f.Locals[11]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",101);}
case 101:{f.Locals[12]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[10]);f.Pc=105;continue;}
case 105:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:105:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",110);}
case 110:{f.Locals[13]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[13]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",118);}
case 118:{f.Locals[14]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[14]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[2]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",126);}
case 126:{f.Push(f.Locals[12]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[2]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",134);}
case 134:{f.Locals[15]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[15]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[14]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",143);}
case 143:{f.Push(f.Locals[0]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[15]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",151);}
case 151:{f.Pc=3217;continue;}
case 154:{f.Push(f.Locals[4]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String("Aftermath")));f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",162);}
case 162:{f.Pc=f.Pop().Int==0?289:165;continue;}
case 165:{f.Push(f.Locals[1]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",169);}
case 169:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",175);}
case 175:{f.Pc=f.Pop().Int==0?289:178;continue;}
case 178:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=181;continue;}
case 181:{f.StackOp("dup");f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",185);}
case 185:{f.Locals[9]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[9]);f.Pc=189;continue;}
case 189:{f.Push(JValue.R(rt.String("Event$ Moved | ValidCard$ Card.Self | Origin$ Stack | ExcludeDestination$ Exile ")));f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",195);}
case 195:{f.StackOp("pop");f.Pc=196;continue;}
case 196:{f.Push(f.Locals[9]);f.Pc=198;continue;}
case 198:{f.Push(JValue.R(rt.String("| ValidStackSa$ Spell.Aftermath | Description$ Aftermath")));f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",204);}
case 204:{f.StackOp("pop");f.Pc=205;continue;}
case 205:{f.Push(f.Locals[9]);f.Pc=207;continue;}
case 207:{f.Push(JValue.R(rt.String(" (")));f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",213);}
case 213:{f.StackOp("pop");f.Pc=214;continue;}
case 214:{f.Push(f.Locals[9]);f.Pc=216;continue;}
case 216:{f.Push(f.Locals[0]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",222);}
case 222:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",225);}
case 225:{f.StackOp("pop");f.Pc=226;continue;}
case 226:{f.Push(f.Locals[9]);f.Pc=228;continue;}
case 228:{f.Push(JValue.R(rt.String(")")));f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",234);}
case 234:{f.StackOp("pop");f.Pc=235;continue;}
case 235:{f.Push(f.Locals[9]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",240);}
case 240:{f.Locals[10]=f.Pop();f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self | Origin$ Stack | Destination$ Exile")));f.Pc=245;continue;}
case 245:{f.Locals[11]=f.Pop();f.Pc=247;continue;}
case 247:{f.Push(f.Locals[11]);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[1]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",253);}
case 253:{f.Locals[12]=f.Pop();f.Pc=255;continue;}
case 255:{f.Push(f.Locals[12]);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[2]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",261);}
case 261:{f.Push(f.Locals[10]);f.Pc=263;continue;}
case 263:{f.Push(f.Locals[3]);f.Pc=264;continue;}
case 264:{f.Push(f.Locals[2]);f.Pc=265;continue;}
case 265:{f.Push(f.Locals[1]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",269);}
case 269:{f.Locals[13]=f.Pop();f.Pc=271;continue;}
case 271:{f.Push(f.Locals[13]);f.Pc=273;continue;}
case 273:{f.Push(f.Locals[12]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",278);}
case 278:{f.Push(f.Locals[0]);f.Pc=279;continue;}
case 279:{f.Push(f.Locals[13]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",286);}
case 286:{f.Pc=3217;continue;}
case 289:{f.Push(f.Locals[4]);f.Pc=291;continue;}
case 291:{f.Push(JValue.R(rt.String("Amplify")));f.Pc=294;continue;}
case 294:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",297);}
case 297:{f.Pc=f.Pop().Int==0?452:300;continue;}
case 300:{f.Push(f.Locals[4]);f.Pc=302;continue;}
case 302:{f.Push(JValue.R(rt.String(":")));f.Pc=305;continue;}
case 305:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",308);}
case 308:{f.Locals[9]=f.Pop();f.Pc=310;continue;}
case 310:{f.Push(f.Locals[9]);f.Pc=312;continue;}
case 312:{f.Push(JValue.I(1));f.Pc=313;continue;}
case 313:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=314;continue;}
case 314:{f.Locals[10]=f.Pop();f.Pc=316;continue;}
case 316:{f.Push(f.Locals[10]);f.Pc=318;continue;}
case 318:{f.Push(f.Locals[0]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",324);}
case 324:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:324:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",329);}
case 329:{f.Locals[11]=f.Pop();f.Pc=331;continue;}
case 331:{f.Push(JValue.R(rt.String("DB$ Reveal | AnyNumber$ True | RevealValid$ Card.YouOwn+sharesCreatureTypeWith+Other+NotDefinedReplacedSimultaneousETB | RememberRevealed$ True")));f.Pc=334;continue;}
case 334:{f.Locals[12]=f.Pop();f.Pc=336;continue;}
case 336:{f.Push(JValue.R(rt.String("DB$ Reveal | AnyNumber$ True | RevealValid$ Card.YouOwn+sharesCreatureTypeWith+Other+NotDefinedReplacedSimultaneousETB | RememberRevealed$ True")));f.Pc=339;continue;}
case 339:{f.Push(f.Locals[1]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",343);}
case 343:{f.Locals[13]=f.Pop();f.Pc=345;continue;}
case 345:{f.Push(JValue.R(rt.String("DB$ PutCounter | Defined$ ReplacedCard | CounterType$ P1P1 | CounterNum$ AmpMagnitude | ETB$ True")));f.Pc=348;continue;}
case 348:{f.Locals[14]=f.Pop();f.Pc=350;continue;}
case 350:{f.Push(JValue.R(rt.String("DB$ PutCounter | Defined$ ReplacedCard | CounterType$ P1P1 | CounterNum$ AmpMagnitude | ETB$ True")));f.Pc=353;continue;}
case 353:{f.Push(f.Locals[1]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",357);}
case 357:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=360;continue;}
case 360:{f.Locals[15]=f.Pop();f.Pc=362;continue;}
case 362:{f.Push(f.Locals[15]);f.Pc=364;continue;}
case 364:{f.Push(JValue.R(rt.String("AmpMagnitude")));f.Pc=367;continue;}
case 367:{f.Push(f.Locals[10]);f.Pc=369;continue;}
case 369:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:369:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",374);}
case 374:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",377);}
case 377:{f.Push(f.Locals[15]);f.Pc=379;continue;}
case 379:{f.Push(JValue.R(rt.String("Revealed")));f.Pc=382;continue;}
case 382:{f.Push(JValue.R(rt.String("Remembered$Amount")));f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",388);}
case 388:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=391;continue;}
case 391:{f.Locals[16]=f.Pop();f.Pc=393;continue;}
case 393:{f.Push(f.Locals[16]);f.Pc=395;continue;}
case 395:{f.Push(f.Locals[1]);f.Pc=396;continue;}
case 396:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",399);}
case 399:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=402;continue;}
case 402:{f.Locals[17]=f.Pop();f.Pc=404;continue;}
case 404:{f.Push(f.Locals[15]);f.Pc=406;continue;}
case 406:{f.Push(f.Locals[17]);f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",411);}
case 411:{f.Push(f.Locals[13]);f.Pc=413;continue;}
case 413:{f.Push(f.Locals[15]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",418);}
case 418:{f.Push(f.Locals[13]);f.Pc=420;continue;}
case 420:{f.Push(f.Locals[2]);f.Pc=421;continue;}
case 421:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",424);}
case 424:{f.Push(f.Locals[11]);f.Pc=426;continue;}
case 426:{f.Push(f.Locals[3]);f.Pc=427;continue;}
case 427:{f.Push(f.Locals[2]);f.Pc=428;continue;}
case 428:{f.Push(f.Locals[1]);f.Pc=429;continue;}
case 429:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",432);}
case 432:{f.Locals[18]=f.Pop();f.Pc=434;continue;}
case 434:{f.Push(f.Locals[18]);f.Pc=436;continue;}
case 436:{f.Push(f.Locals[13]);f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",441);}
case 441:{f.Push(f.Locals[0]);f.Pc=442;continue;}
case 442:{f.Push(f.Locals[18]);f.Pc=444;continue;}
case 444:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",449);}
case 449:{f.Pc=3217;continue;}
case 452:{f.Push(f.Locals[4]);f.Pc=454;continue;}
case 454:{f.Push(JValue.R(rt.String("Bloodthirst")));f.Pc=457;continue;}
case 457:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",460);}
case 460:{f.Pc=f.Pop().Int==0?562:463;continue;}
case 463:{f.Push(f.Locals[4]);f.Pc=465;continue;}
case 465:{f.Push(JValue.R(rt.String(":")));f.Pc=468;continue;}
case 468:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",471);}
case 471:{f.Push(JValue.I(1));f.Pc=472;continue;}
case 472:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=473;continue;}
case 473:{f.Locals[9]=f.Pop();f.Pc=475;continue;}
case 475:{f.Push(f.Locals[9]);f.Pc=477;continue;}
case 477:{f.Push(JValue.R(rt.String("X")));f.Pc=479;continue;}
case 479:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",482);}
case 482:{f.Pc=f.Pop().Int==0?493:485;continue;}
case 485:{f.Push(JValue.R(rt.String("Bloodthirst X (This creature enters with X +1/+1 counters on it, where X is the damage dealt to your opponents this turn.)")));f.Pc=488;continue;}
case 488:{f.Locals[10]=f.Pop();f.Pc=490;continue;}
case 490:{f.Pc=508;continue;}
case 493:{f.Push(f.Locals[9]);f.Pc=495;continue;}
case 495:{f.Push(f.Locals[0]);f.Pc=496;continue;}
case 496:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",501);}
case 501:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:501:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",506);}
case 506:{f.Locals[10]=f.Pop();f.Pc=508;continue;}
case 508:{f.Push(f.Locals[9]);f.Pc=510;continue;}
case 510:{f.Push(f.Locals[10]);f.Pc=512;continue;}
case 512:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:512:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",517);}
case 517:{f.Locals[11]=f.Pop();f.Pc=519;continue;}
case 519:{f.Push(f.Locals[11]);f.Pc=521;continue;}
case 521:{f.Push(f.Locals[1]);f.Pc=522;continue;}
case 522:{f.Push(f.Locals[2]);f.Pc=523;continue;}
case 523:{return rt.Call(f,"forge/game/card/CardFactoryUtil","makeEtbCounter","(Ljava/lang/String;Lforge/game/card/CardState;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",526);}
case 526:{f.Locals[12]=f.Pop();f.Pc=528;continue;}
case 528:{f.Push(f.Locals[9]);f.Pc=530;continue;}
case 530:{f.Push(JValue.R(rt.String("X")));f.Pc=532;continue;}
case 532:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",535);}
case 535:{f.Pc=f.Pop().Int==0?551:538;continue;}
case 538:{f.Push(f.Locals[12]);f.Pc=540;continue;}
case 540:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",543);}
case 543:{f.Push(JValue.R(rt.String("X")));f.Pc=545;continue;}
case 545:{f.Push(JValue.R(rt.String("Count$BloodthirstAmount")));f.Pc=548;continue;}
case 548:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",551);}
case 551:{f.Push(f.Locals[0]);f.Pc=552;continue;}
case 552:{f.Push(f.Locals[12]);f.Pc=554;continue;}
case 554:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",559);}
case 559:{f.Pc=3217;continue;}
case 562:{f.Push(f.Locals[4]);f.Pc=564;continue;}
case 564:{f.Push(JValue.R(rt.String("Buyback")));f.Pc=567;continue;}
case 567:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",570);}
case 570:{f.Pc=f.Pop().Int==0?759:573;continue;}
case 573:{f.Push(f.Locals[4]);f.Pc=575;continue;}
case 575:{f.Push(JValue.R(rt.String(":")));f.Pc=578;continue;}
case 578:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",581);}
case 581:{f.Locals[9]=f.Pop();f.Pc=583;continue;}
case 583:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=586;continue;}
case 586:{f.StackOp("dup");f.Pc=587;continue;}
case 587:{f.Push(f.Locals[9]);f.Pc=589;continue;}
case 589:{f.Push(JValue.I(1));f.Pc=590;continue;}
case 590:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=591;continue;}
case 591:{f.Push(JValue.I(0));f.Pc=592;continue;}
case 592:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",595);}
case 595:{f.Locals[10]=f.Pop();f.Pc=597;continue;}
case 597:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=600;continue;}
case 600:{f.StackOp("dup");f.Pc=601;continue;}
case 601:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",604);}
case 604:{f.Locals[11]=f.Pop();f.Pc=606;continue;}
case 606:{f.Push(f.Locals[11]);f.Pc=608;continue;}
case 608:{f.Push(JValue.R(rt.String("Event$ Moved | ValidCard$ Card.Self | Origin$ Stack | Destination$ Graveyard | Fizzle$ False ")));f.Pc=611;continue;}
case 611:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",614);}
case 614:{f.StackOp("pop");f.Pc=615;continue;}
case 615:{f.Push(f.Locals[11]);f.Pc=617;continue;}
case 617:{f.Push(JValue.R(rt.String("| Secondary$ True | ValidStackSa$ Spell.Buyback | Description$ Buyback")));f.Pc=620;continue;}
case 620:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",623);}
case 623:{f.StackOp("pop");f.Pc=624;continue;}
case 624:{f.Push(f.Locals[11]);f.Pc=626;continue;}
case 626:{f.Push(f.Locals[10]);f.Pc=628;continue;}
case 628:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",631);}
case 631:{f.Pc=f.Pop().Int==0?640:634;continue;}
case 634:{f.Push(JValue.R(rt.String(" ")));f.Pc=637;continue;}
case 637:{f.Pc=643;continue;}
case 640:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=643;continue;}
case 643:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",646);}
case 646:{f.StackOp("pop");f.Pc=647;continue;}
case 647:{f.Push(f.Locals[11]);f.Pc=649;continue;}
case 649:{f.Push(f.Locals[10]);f.Pc=651;continue;}
case 651:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",654);}
case 654:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",657);}
case 657:{f.StackOp("pop");f.Pc=658;continue;}
case 658:{f.Push(f.Locals[10]);f.Pc=660;continue;}
case 660:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",663);}
case 663:{f.Pc=f.Pop().Int!=0?675:666;continue;}
case 666:{f.Push(f.Locals[11]);f.Pc=668;continue;}
case 668:{f.Push(JValue.R(rt.String(".")));f.Pc=671;continue;}
case 671:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",674);}
case 674:{f.StackOp("pop");f.Pc=675;continue;}
case 675:{f.Push(f.Locals[11]);f.Pc=677;continue;}
case 677:{f.Push(JValue.R(rt.String(" (")));f.Pc=680;continue;}
case 680:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",683);}
case 683:{f.StackOp("pop");f.Pc=684;continue;}
case 684:{f.Push(f.Locals[11]);f.Pc=686;continue;}
case 686:{f.Push(f.Locals[0]);f.Pc=687;continue;}
case 687:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",692);}
case 692:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",695);}
case 695:{f.StackOp("pop");f.Pc=696;continue;}
case 696:{f.Push(f.Locals[11]);f.Pc=698;continue;}
case 698:{f.Push(JValue.R(rt.String(")")));f.Pc=701;continue;}
case 701:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",704);}
case 704:{f.StackOp("pop");f.Pc=705;continue;}
case 705:{f.Push(f.Locals[11]);f.Pc=707;continue;}
case 707:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",710);}
case 710:{f.Locals[12]=f.Pop();f.Pc=712;continue;}
case 712:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self | Origin$ Stack | Destination$ Hand")));f.Pc=715;continue;}
case 715:{f.Locals[13]=f.Pop();f.Pc=717;continue;}
case 717:{f.Push(f.Locals[13]);f.Pc=719;continue;}
case 719:{f.Push(f.Locals[1]);f.Pc=720;continue;}
case 720:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",723);}
case 723:{f.Locals[14]=f.Pop();f.Pc=725;continue;}
case 725:{f.Push(f.Locals[14]);f.Pc=727;continue;}
case 727:{f.Push(f.Locals[2]);f.Pc=728;continue;}
case 728:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",731);}
case 731:{f.Push(f.Locals[12]);f.Pc=733;continue;}
case 733:{f.Push(f.Locals[3]);f.Pc=734;continue;}
case 734:{f.Push(f.Locals[2]);f.Pc=735;continue;}
case 735:{f.Push(f.Locals[1]);f.Pc=736;continue;}
case 736:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",739);}
case 739:{f.Locals[15]=f.Pop();f.Pc=741;continue;}
case 741:{f.Push(f.Locals[15]);f.Pc=743;continue;}
case 743:{f.Push(f.Locals[14]);f.Pc=745;continue;}
case 745:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",748);}
case 748:{f.Push(f.Locals[0]);f.Pc=749;continue;}
case 749:{f.Push(f.Locals[15]);f.Pc=751;continue;}
case 751:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",756);}
case 756:{f.Pc=3217;continue;}
case 759:{f.Push(f.Locals[4]);f.Pc=761;continue;}
case 761:{f.Push(JValue.R(rt.String("Compleated")));f.Pc=764;continue;}
case 764:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",767);}
case 767:{f.Pc=f.Pop().Int==0?813:770;continue;}
case 770:{f.Push(f.Locals[0]);f.Pc=771;continue;}
case 771:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",776);}
case 776:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:776:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",781);}
case 781:{f.Locals[9]=f.Pop();f.Pc=783;continue;}
case 783:{f.Push(f.Locals[9]);f.Pc=785;continue;}
case 785:{f.Push(f.Locals[1]);f.Pc=786;continue;}
case 786:{f.Push(f.Locals[2]);f.Pc=787;continue;}
case 787:{return rt.Call(f,"forge/game/card/CardFactoryUtil","makeEtbCounter","(Ljava/lang/String;Lforge/game/card/CardState;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",790);}
case 790:{f.Locals[10]=f.Pop();f.Pc=792;continue;}
case 792:{f.Push(f.Locals[1]);f.Pc=793;continue;}
case 793:{f.Push(JValue.R(rt.String("PhySpent")));f.Pc=796;continue;}
case 796:{f.Push(JValue.R(rt.String("Count$EachPhyrexianPaidWithLife/Negative")));f.Pc=799;continue;}
case 799:{return rt.Call(f,"forge/game/card/CardState","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",802);}
case 802:{f.Push(f.Locals[0]);f.Pc=803;continue;}
case 803:{f.Push(f.Locals[10]);f.Pc=805;continue;}
case 805:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",810);}
case 810:{f.Pc=3217;continue;}
case 813:{f.Push(f.Locals[4]);f.Pc=815;continue;}
case 815:{f.Push(JValue.R(rt.String("Dredge")));f.Pc=818;continue;}
case 818:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",821);}
case 821:{f.Pc=f.Pop().Int==0?933:824;continue;}
case 824:{f.Push(f.Locals[4]);f.Pc=826;continue;}
case 826:{f.Push(JValue.R(rt.String(":")));f.Pc=829;continue;}
case 829:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",832);}
case 832:{f.Push(JValue.I(1));f.Pc=833;continue;}
case 833:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=834;continue;}
case 834:{f.Locals[9]=f.Pop();f.Pc=836;continue;}
case 836:{f.Push(f.Locals[9]);f.Pc=838;continue;}
case 838:{f.Push(f.Locals[9]);f.Pc=840;continue;}
case 840:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:840:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",845);}
case 845:{f.Locals[10]=f.Pop();f.Pc=847;continue;}
case 847:{f.Push(f.Locals[9]);f.Pc=849;continue;}
case 849:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:849:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",854);}
case 854:{f.Locals[11]=f.Pop();f.Pc=856;continue;}
case 856:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Origin$ Graveyard | Destination$ Hand | Defined$ Self")));f.Pc=859;continue;}
case 859:{f.Locals[12]=f.Pop();f.Pc=861;continue;}
case 861:{f.Push(f.Locals[11]);f.Pc=863;continue;}
case 863:{f.Push(f.Locals[1]);f.Pc=864;continue;}
case 864:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",867);}
case 867:{f.Locals[13]=f.Pop();f.Pc=869;continue;}
case 869:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Origin$ Graveyard | Destination$ Hand | Defined$ Self")));f.Pc=872;continue;}
case 872:{f.Push(f.Locals[1]);f.Pc=873;continue;}
case 873:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",876);}
case 876:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=879;continue;}
case 879:{f.Locals[14]=f.Pop();f.Pc=881;continue;}
case 881:{f.Push(f.Locals[13]);f.Pc=883;continue;}
case 883:{f.Push(f.Locals[14]);f.Pc=885;continue;}
case 885:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",888);}
case 888:{f.Push(f.Locals[13]);f.Pc=890;continue;}
case 890:{f.Push(f.Locals[2]);f.Pc=891;continue;}
case 891:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",894);}
case 894:{f.Push(f.Locals[10]);f.Pc=896;continue;}
case 896:{f.Push(f.Locals[3]);f.Pc=897;continue;}
case 897:{f.Push(f.Locals[2]);f.Pc=898;continue;}
case 898:{f.Push(f.Locals[1]);f.Pc=899;continue;}
case 899:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",902);}
case 902:{f.Locals[15]=f.Pop();f.Pc=904;continue;}
case 904:{f.Push(f.Locals[15]);f.Pc=906;continue;}
case 906:{f.Push(f.Locals[13]);f.Pc=908;continue;}
case 908:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",911);}
case 911:{f.Push(f.Locals[15]);f.Pc=913;continue;}
case 913:{f.Push(JValue.R(rt.String("DredgeCheckLib")));f.Pc=916;continue;}
case 916:{f.Push(JValue.R(rt.String("Count$ValidLibrary Card.YouOwn")));f.Pc=919;continue;}
case 919:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",922);}
case 922:{f.Push(f.Locals[0]);f.Pc=923;continue;}
case 923:{f.Push(f.Locals[15]);f.Pc=925;continue;}
case 925:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",930);}
case 930:{f.Pc=3217;continue;}
case 933:{f.Push(f.Locals[4]);f.Pc=935;continue;}
case 935:{f.Push(JValue.R(rt.String("Daybound")));f.Pc=938;continue;}
case 938:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",941);}
case 941:{f.Pc=f.Pop().Int==0?992:944;continue;}
case 944:{f.Push(JValue.R(rt.String("Event$ Moved | ValidCard$ Card.Self | Destination$ Battlefield | DayTime$ Night | Secondary$ True | Layer$ Transform | ReplacementResult$ Updated | Description$ If it is night, this permanent enters transformed.")));f.Pc=947;continue;}
case 947:{f.Locals[9]=f.Pop();f.Pc=949;continue;}
case 949:{f.Push(JValue.R(rt.String("DB$ SetState | Defined$ ReplacedCard | Mode$ Transform | ETB$ True")));f.Pc=952;continue;}
case 952:{f.Locals[10]=f.Pop();f.Pc=954;continue;}
case 954:{f.Push(JValue.R(rt.String("Event$ Moved | ValidCard$ Card.Self | Destination$ Battlefield | DayTime$ Night | Secondary$ True | Layer$ Transform | ReplacementResult$ Updated | Description$ If it is night, this permanent enters transformed.")));f.Pc=957;continue;}
case 957:{f.Push(f.Locals[3]);f.Pc=958;continue;}
case 958:{f.Push(f.Locals[2]);f.Pc=959;continue;}
case 959:{f.Push(f.Locals[1]);f.Pc=960;continue;}
case 960:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",963);}
case 963:{f.Locals[11]=f.Pop();f.Pc=965;continue;}
case 965:{f.Push(JValue.R(rt.String("DB$ SetState | Defined$ ReplacedCard | Mode$ Transform | ETB$ True")));f.Pc=968;continue;}
case 968:{f.Push(f.Locals[1]);f.Pc=969;continue;}
case 969:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",972);}
case 972:{f.Locals[12]=f.Pop();f.Pc=974;continue;}
case 974:{f.Push(f.Locals[11]);f.Pc=976;continue;}
case 976:{f.Push(f.Locals[12]);f.Pc=978;continue;}
case 978:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",981);}
case 981:{f.Push(f.Locals[0]);f.Pc=982;continue;}
case 982:{f.Push(f.Locals[11]);f.Pc=984;continue;}
case 984:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",989);}
case 989:{f.Pc=3217;continue;}
case 992:{f.Push(f.Locals[4]);f.Pc=994;continue;}
case 994:{f.Push(JValue.R(rt.String("Devour")));f.Pc=997;continue;}
case 997:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1000);}
case 1000:{f.Pc=f.Pop().Int==0?1173:1003;continue;}
case 1003:{f.Push(f.Locals[0]);f.Pc=1004;continue;}
case 1004:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/Devour")?1:0));f.Pc=1007;continue;}
case 1007:{f.Pc=f.Pop().Int==0?1173:1010;continue;}
case 1010:{f.Push(f.Locals[0]);f.Pc=1011;continue;}
case 1011:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/Devour"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1014;continue;}
case 1014:{f.Locals[5]=f.Pop();f.Pc=1016;continue;}
case 1016:{f.Push(f.Locals[5]);f.Pc=1018;continue;}
case 1018:{return rt.Call(f,"forge/game/keyword/Devour","getValidType","()Ljava/lang/String;","invokevirtual",1021);}
case 1021:{f.Locals[9]=f.Pop();f.Pc=1023;continue;}
case 1023:{f.Push(f.Locals[9]);f.Pc=1025;continue;}
case 1025:{f.Push(f.Locals[5]);f.Pc=1027;continue;}
case 1027:{return rt.Call(f,"forge/game/keyword/Devour","getTypeDescription","()Ljava/lang/String;","invokevirtual",1030);}
case 1030:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:1030:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1035);}
case 1035:{f.Locals[10]=f.Pop();f.Pc=1037;continue;}
case 1037:{f.Push(JValue.R(rt.String("DB$ PutCounter | ETB$ True | Defined$ Self | CounterType$ P1P1 | CounterNum$ DevourX")));f.Pc=1040;continue;}
case 1040:{f.Locals[11]=f.Pop();f.Pc=1042;continue;}
case 1042:{f.Push(JValue.R(rt.String("DB$ Cleanup | ClearRemembered$ True")));f.Pc=1045;continue;}
case 1045:{f.Locals[12]=f.Pop();f.Pc=1047;continue;}
case 1047:{f.Push(f.Locals[10]);f.Pc=1049;continue;}
case 1049:{f.Push(f.Locals[1]);f.Pc=1050;continue;}
case 1050:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",1053);}
case 1053:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1056;continue;}
case 1056:{f.Locals[13]=f.Pop();f.Pc=1058;continue;}
case 1058:{f.Push(f.Locals[13]);f.Pc=1060;continue;}
case 1060:{f.Push(JValue.R(rt.String("DevourSacX")));f.Pc=1063;continue;}
case 1063:{f.Push(f.Locals[9]);f.Pc=1065;continue;}
case 1065:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:1065:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1070);}
case 1070:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1073);}
case 1073:{f.Push(f.Locals[11]);f.Pc=1075;continue;}
case 1075:{f.Push(f.Locals[1]);f.Pc=1076;continue;}
case 1076:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",1079);}
case 1079:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1082;continue;}
case 1082:{f.Locals[14]=f.Pop();f.Pc=1084;continue;}
case 1084:{f.Push(f.Locals[14]);f.Pc=1086;continue;}
case 1086:{f.Push(JValue.R(rt.String("DevourX")));f.Pc=1089;continue;}
case 1089:{f.Push(f.Locals[5]);f.Pc=1091;continue;}
case 1091:{return rt.Call(f,"forge/game/keyword/Devour","getAmountString","()Ljava/lang/String;","invokevirtual",1094);}
case 1094:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:1094:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1099);}
case 1099:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1102);}
case 1102:{f.Push(f.Locals[13]);f.Pc=1104;continue;}
case 1104:{f.Push(f.Locals[14]);f.Pc=1106;continue;}
case 1106:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",1109);}
case 1109:{f.Push(f.Locals[12]);f.Pc=1111;continue;}
case 1111:{f.Push(f.Locals[1]);f.Pc=1112;continue;}
case 1112:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",1115);}
case 1115:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1118;continue;}
case 1118:{f.Locals[15]=f.Pop();f.Pc=1120;continue;}
case 1120:{f.Push(f.Locals[14]);f.Pc=1122;continue;}
case 1122:{f.Push(f.Locals[15]);f.Pc=1124;continue;}
case 1124:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",1127);}
case 1127:{f.Push(f.Locals[5]);f.Pc=1129;continue;}
case 1129:{return rt.Call(f,"forge/game/keyword/Devour","getTitle","()Ljava/lang/String;","invokevirtual",1132);}
case 1132:{f.Push(f.Locals[0]);f.Pc=1133;continue;}
case 1133:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1138);}
case 1138:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:1138:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1143);}
case 1143:{f.Locals[16]=f.Pop();f.Pc=1145;continue;}
case 1145:{f.Push(f.Locals[16]);f.Pc=1147;continue;}
case 1147:{f.Push(f.Locals[3]);f.Pc=1148;continue;}
case 1148:{f.Push(f.Locals[2]);f.Pc=1149;continue;}
case 1149:{f.Push(f.Locals[1]);f.Pc=1150;continue;}
case 1150:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",1153);}
case 1153:{f.Locals[17]=f.Pop();f.Pc=1155;continue;}
case 1155:{f.Push(f.Locals[17]);f.Pc=1157;continue;}
case 1157:{f.Push(f.Locals[13]);f.Pc=1159;continue;}
case 1159:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1162);}
case 1162:{f.Push(f.Locals[0]);f.Pc=1163;continue;}
case 1163:{f.Push(f.Locals[17]);f.Pc=1165;continue;}
case 1165:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",1170);}
case 1170:{f.Pc=3217;continue;}
case 1173:{f.Push(f.Locals[4]);f.Pc=1175;continue;}
case 1175:{f.Push(JValue.R(rt.String("Fading")));f.Pc=1178;continue;}
case 1178:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1181);}
case 1181:{f.Pc=f.Pop().Int==0?1290:1184;continue;}
case 1184:{f.Push(f.Locals[4]);f.Pc=1186;continue;}
case 1186:{f.Push(JValue.R(rt.String(":")));f.Pc=1189;continue;}
case 1189:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1192);}
case 1192:{f.Locals[9]=f.Pop();f.Pc=1194;continue;}
case 1194:{f.Push(f.Locals[9]);f.Pc=1196;continue;}
case 1196:{f.Push(JValue.I(1));f.Pc=1197;continue;}
case 1197:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1198;continue;}
case 1198:{f.Locals[10]=f.Pop();f.Pc=1200;continue;}
case 1200:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1203;continue;}
case 1203:{f.StackOp("dup");f.Pc=1204;continue;}
case 1204:{f.Push(JValue.R(rt.String("etbCounter:FADE:")));f.Pc=1207;continue;}
case 1207:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",1210);}
case 1210:{f.Locals[11]=f.Pop();f.Pc=1212;continue;}
case 1212:{f.Push(f.Locals[11]);f.Pc=1214;continue;}
case 1214:{f.Push(f.Locals[10]);f.Pc=1216;continue;}
case 1216:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1219);}
case 1219:{f.Push(JValue.R(rt.String(":no Condition:")));f.Pc=1222;continue;}
case 1222:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1225);}
case 1225:{f.StackOp("pop");f.Pc=1226;continue;}
case 1226:{f.Push(f.Locals[11]);f.Pc=1228;continue;}
case 1228:{f.Push(JValue.R(rt.String("Fading ")));f.Pc=1231;continue;}
case 1231:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1234);}
case 1234:{f.StackOp("pop");f.Pc=1235;continue;}
case 1235:{f.Push(f.Locals[11]);f.Pc=1237;continue;}
case 1237:{f.Push(f.Locals[10]);f.Pc=1239;continue;}
case 1239:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1242);}
case 1242:{f.StackOp("pop");f.Pc=1243;continue;}
case 1243:{f.Push(f.Locals[11]);f.Pc=1245;continue;}
case 1245:{f.Push(JValue.R(rt.String(" (")));f.Pc=1248;continue;}
case 1248:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1251);}
case 1251:{f.Push(f.Locals[0]);f.Pc=1252;continue;}
case 1252:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1257);}
case 1257:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1260);}
case 1260:{f.Push(JValue.R(rt.String(")")));f.Pc=1263;continue;}
case 1263:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1266);}
case 1266:{f.StackOp("pop");f.Pc=1267;continue;}
case 1267:{f.Push(f.Locals[11]);f.Pc=1269;continue;}
case 1269:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1272);}
case 1272:{f.Push(f.Locals[1]);f.Pc=1273;continue;}
case 1273:{f.Push(f.Locals[2]);f.Pc=1274;continue;}
case 1274:{return rt.Call(f,"forge/game/card/CardFactoryUtil","makeEtbCounter","(Ljava/lang/String;Lforge/game/card/CardState;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",1277);}
case 1277:{f.Locals[12]=f.Pop();f.Pc=1279;continue;}
case 1279:{f.Push(f.Locals[0]);f.Pc=1280;continue;}
case 1280:{f.Push(f.Locals[12]);f.Pc=1282;continue;}
case 1282:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",1287);}
case 1287:{f.Pc=3217;continue;}
case 1290:{f.Push(f.Locals[4]);f.Pc=1292;continue;}
case 1292:{f.Push(JValue.R(rt.String("Beam me up")));f.Pc=1295;continue;}
case 1295:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1298);}
case 1298:{f.Pc=f.Pop().Int!=0?1323:1301;continue;}
case 1301:{f.Push(f.Locals[4]);f.Pc=1303;continue;}
case 1303:{f.Push(JValue.R(rt.String("Flashback")));f.Pc=1306;continue;}
case 1306:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1309);}
case 1309:{f.Pc=f.Pop().Int!=0?1323:1312;continue;}
case 1312:{f.Push(f.Locals[4]);f.Pc=1314;continue;}
case 1314:{f.Push(JValue.R(rt.String("Harmonize")));f.Pc=1317;continue;}
case 1317:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1320);}
case 1320:{f.Pc=f.Pop().Int==0?1659:1323;continue;}
case 1323:{f.Push(f.Locals[4]);f.Pc=1325;continue;}
case 1325:{f.Push(JValue.R(rt.String("Beam me up")));f.Pc=1328;continue;}
case 1328:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1331);}
case 1331:{f.Pc=f.Pop().Int==0?1347:1334;continue;}
case 1334:{f.Push(JValue.R(rt.String("Beam me up")));f.Pc=1337;continue;}
case 1337:{f.Locals[9]=f.Pop();f.Pc=1339;continue;}
case 1339:{f.Push(JValue.R(rt.String("BeamMeUp")));f.Pc=1342;continue;}
case 1342:{f.Locals[10]=f.Pop();f.Pc=1344;continue;}
case 1344:{f.Pc=1381;continue;}
case 1347:{f.Push(f.Locals[4]);f.Pc=1349;continue;}
case 1349:{f.Push(JValue.R(rt.String("Flashback")));f.Pc=1352;continue;}
case 1352:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1355);}
case 1355:{f.Pc=f.Pop().Int==0?1371:1358;continue;}
case 1358:{f.Push(JValue.R(rt.String("Flashback")));f.Pc=1361;continue;}
case 1361:{f.Locals[9]=f.Pop();f.Pc=1363;continue;}
case 1363:{f.Push(JValue.R(rt.String("Flashback")));f.Pc=1366;continue;}
case 1366:{f.Locals[10]=f.Pop();f.Pc=1368;continue;}
case 1368:{f.Pc=1381;continue;}
case 1371:{f.Push(JValue.R(rt.String("Harmonize")));f.Pc=1374;continue;}
case 1374:{f.Locals[9]=f.Pop();f.Pc=1376;continue;}
case 1376:{f.Push(JValue.R(rt.String("Harmonize")));f.Pc=1379;continue;}
case 1379:{f.Locals[10]=f.Pop();f.Pc=1381;continue;}
case 1381:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1384;continue;}
case 1384:{f.StackOp("dup");f.Pc=1385;continue;}
case 1385:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",1388);}
case 1388:{f.Locals[11]=f.Pop();f.Pc=1390;continue;}
case 1390:{f.Push(f.Locals[11]);f.Pc=1392;continue;}
case 1392:{f.Push(JValue.R(rt.String("Event$ Moved | ValidCard$ Card.Self | Origin$ Stack | ExcludeDestination$ Exile ")));f.Pc=1395;continue;}
case 1395:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1398);}
case 1398:{f.StackOp("pop");f.Pc=1399;continue;}
case 1399:{f.Push(f.Locals[11]);f.Pc=1401;continue;}
case 1401:{f.Push(JValue.R(rt.String("| ValidStackSa$ Spell.")));f.Pc=1404;continue;}
case 1404:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1407);}
case 1407:{f.Push(f.Locals[10]);f.Pc=1409;continue;}
case 1409:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1412);}
case 1412:{f.Push(JValue.R(rt.String("+castKeyword")));f.Pc=1415;continue;}
case 1415:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1418);}
case 1418:{f.StackOp("pop");f.Pc=1419;continue;}
case 1419:{f.Push(f.Locals[11]);f.Pc=1421;continue;}
case 1421:{f.Push(JValue.R(rt.String(" | Description$ ")));f.Pc=1424;continue;}
case 1424:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1427);}
case 1427:{f.Push(f.Locals[9]);f.Pc=1429;continue;}
case 1429:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1432);}
case 1432:{f.StackOp("pop");f.Pc=1433;continue;}
case 1433:{f.Push(f.Locals[4]);f.Pc=1435;continue;}
case 1435:{f.Push(JValue.R(rt.String(":")));f.Pc=1438;continue;}
case 1438:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",1441);}
case 1441:{f.Pc=f.Pop().Int==0?1577:1444;continue;}
case 1444:{f.Push(f.Locals[4]);f.Pc=1446;continue;}
case 1446:{f.Push(JValue.R(rt.String(":")));f.Pc=1449;continue;}
case 1449:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1452);}
case 1452:{f.Locals[12]=f.Pop();f.Pc=1454;continue;}
case 1454:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=1457;continue;}
case 1457:{f.StackOp("dup");f.Pc=1458;continue;}
case 1458:{f.Push(f.Locals[12]);f.Pc=1460;continue;}
case 1460:{f.Push(JValue.I(1));f.Pc=1461;continue;}
case 1461:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1462;continue;}
case 1462:{f.Push(JValue.I(0));f.Pc=1463;continue;}
case 1463:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",1466);}
case 1466:{f.Locals[13]=f.Pop();f.Pc=1468;continue;}
case 1468:{f.Push(f.Locals[11]);f.Pc=1470;continue;}
case 1470:{f.Push(f.Locals[13]);f.Pc=1472;continue;}
case 1472:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",1475);}
case 1475:{f.Pc=f.Pop().Int==0?1484:1478;continue;}
case 1478:{f.Push(JValue.R(rt.String(" ")));f.Pc=1481;continue;}
case 1481:{f.Pc=1487;continue;}
case 1484:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=1487;continue;}
case 1487:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1490);}
case 1490:{f.Push(f.Locals[13]);f.Pc=1492;continue;}
case 1492:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",1495);}
case 1495:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1498);}
case 1498:{f.StackOp("pop");f.Pc=1499;continue;}
case 1499:{f.Push(f.Locals[11]);f.Pc=1501;continue;}
case 1501:{f.Push(f.Locals[13]);f.Pc=1503;continue;}
case 1503:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",1506);}
case 1506:{f.Pc=f.Pop().Int==0?1515:1509;continue;}
case 1509:{f.Push(JValue.R(rt.String("")));f.Pc=1512;continue;}
case 1512:{f.Pc=1518;continue;}
case 1515:{f.Push(JValue.R(rt.String(".")));f.Pc=1518;continue;}
case 1518:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1521);}
case 1521:{f.StackOp("pop");f.Pc=1522;continue;}
case 1522:{f.Push(f.Locals[12]);f.Pc=1524;continue;}
case 1524:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1525;continue;}
case 1525:{f.Push(JValue.I(3));f.Pc=1526;continue;}
case 1526:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1536:1529;continue;}
case 1529:{f.Push(f.Locals[12]);f.Pc=1531;continue;}
case 1531:{f.Push(JValue.I(3));f.Pc=1532;continue;}
case 1532:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1533;continue;}
case 1533:{f.Pc=1539;continue;}
case 1536:{f.Push(JValue.R(rt.String("")));f.Pc=1539;continue;}
case 1539:{f.Locals[14]=f.Pop();f.Pc=1541;continue;}
case 1541:{f.Push(f.Locals[14]);f.Pc=1543;continue;}
case 1543:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1546);}
case 1546:{f.Pc=f.Pop().Int!=0?1577:1549;continue;}
case 1549:{f.Push(f.Locals[11]);f.Pc=1551;continue;}
case 1551:{f.Push(f.Locals[13]);f.Pc=1553;continue;}
case 1553:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",1556);}
case 1556:{f.Pc=f.Pop().Int==0?1565:1559;continue;}
case 1559:{f.Push(JValue.R(rt.String(". ")));f.Pc=1562;continue;}
case 1562:{f.Pc=1568;continue;}
case 1565:{f.Push(JValue.R(rt.String(" ")));f.Pc=1568;continue;}
case 1568:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1571);}
case 1571:{f.Push(f.Locals[14]);f.Pc=1573;continue;}
case 1573:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1576);}
case 1576:{f.StackOp("pop");f.Pc=1577;continue;}
case 1577:{f.Push(f.Locals[11]);f.Pc=1579;continue;}
case 1579:{f.Push(JValue.R(rt.String(" (")));f.Pc=1582;continue;}
case 1582:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1585);}
case 1585:{f.Push(f.Locals[0]);f.Pc=1586;continue;}
case 1586:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1591);}
case 1591:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1594);}
case 1594:{f.Push(JValue.R(rt.String(")")));f.Pc=1597;continue;}
case 1597:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1600);}
case 1600:{f.StackOp("pop");f.Pc=1601;continue;}
case 1601:{f.Push(f.Locals[11]);f.Pc=1603;continue;}
case 1603:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1606);}
case 1606:{f.Locals[12]=f.Pop();f.Pc=1608;continue;}
case 1608:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self | Origin$ Stack | Destination$ Exile")));f.Pc=1611;continue;}
case 1611:{f.Locals[13]=f.Pop();f.Pc=1613;continue;}
case 1613:{f.Push(f.Locals[13]);f.Pc=1615;continue;}
case 1615:{f.Push(f.Locals[1]);f.Pc=1616;continue;}
case 1616:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",1619);}
case 1619:{f.Locals[14]=f.Pop();f.Pc=1621;continue;}
case 1621:{f.Push(f.Locals[2]);f.Pc=1622;continue;}
case 1622:{f.Pc=f.Pop().Int!=0?1631:1625;continue;}
case 1625:{f.Push(f.Locals[14]);f.Pc=1627;continue;}
case 1627:{f.Push(JValue.I(0));f.Pc=1628;continue;}
case 1628:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",1631);}
case 1631:{f.Push(f.Locals[12]);f.Pc=1633;continue;}
case 1633:{f.Push(f.Locals[3]);f.Pc=1634;continue;}
case 1634:{f.Push(f.Locals[2]);f.Pc=1635;continue;}
case 1635:{f.Push(f.Locals[1]);f.Pc=1636;continue;}
case 1636:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",1639);}
case 1639:{f.Locals[15]=f.Pop();f.Pc=1641;continue;}
case 1641:{f.Push(f.Locals[15]);f.Pc=1643;continue;}
case 1643:{f.Push(f.Locals[14]);f.Pc=1645;continue;}
case 1645:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1648);}
case 1648:{f.Push(f.Locals[0]);f.Pc=1649;continue;}
case 1649:{f.Push(f.Locals[15]);f.Pc=1651;continue;}
case 1651:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",1656);}
case 1656:{f.Pc=3217;continue;}
case 1659:{f.Push(f.Locals[4]);f.Pc=1661;continue;}
case 1661:{f.Push(JValue.R(rt.String("Graft")));f.Pc=1664;continue;}
case 1664:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1667);}
case 1667:{f.Pc=f.Pop().Int==0?1776:1670;continue;}
case 1670:{f.Push(f.Locals[4]);f.Pc=1672;continue;}
case 1672:{f.Push(JValue.R(rt.String(":")));f.Pc=1675;continue;}
case 1675:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1678);}
case 1678:{f.Locals[9]=f.Pop();f.Pc=1680;continue;}
case 1680:{f.Push(f.Locals[9]);f.Pc=1682;continue;}
case 1682:{f.Push(JValue.I(1));f.Pc=1683;continue;}
case 1683:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1684;continue;}
case 1684:{f.Locals[10]=f.Pop();f.Pc=1686;continue;}
case 1686:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1689;continue;}
case 1689:{f.StackOp("dup");f.Pc=1690;continue;}
case 1690:{f.Push(JValue.R(rt.String("etbCounter:P1P1:")));f.Pc=1693;continue;}
case 1693:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",1696);}
case 1696:{f.Locals[11]=f.Pop();f.Pc=1698;continue;}
case 1698:{f.Push(f.Locals[11]);f.Pc=1700;continue;}
case 1700:{f.Push(f.Locals[10]);f.Pc=1702;continue;}
case 1702:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1705);}
case 1705:{f.Push(JValue.R(rt.String(":no Condition:")));f.Pc=1708;continue;}
case 1708:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1711);}
case 1711:{f.StackOp("pop");f.Pc=1712;continue;}
case 1712:{f.Push(f.Locals[11]);f.Pc=1714;continue;}
case 1714:{f.Push(JValue.R(rt.String("Graft ")));f.Pc=1717;continue;}
case 1717:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1720);}
case 1720:{f.StackOp("pop");f.Pc=1721;continue;}
case 1721:{f.Push(f.Locals[11]);f.Pc=1723;continue;}
case 1723:{f.Push(f.Locals[10]);f.Pc=1725;continue;}
case 1725:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1728);}
case 1728:{f.StackOp("pop");f.Pc=1729;continue;}
case 1729:{f.Push(f.Locals[11]);f.Pc=1731;continue;}
case 1731:{f.Push(JValue.R(rt.String(" (")));f.Pc=1734;continue;}
case 1734:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1737);}
case 1737:{f.Push(f.Locals[0]);f.Pc=1738;continue;}
case 1738:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1743);}
case 1743:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1746);}
case 1746:{f.Push(JValue.R(rt.String(")")));f.Pc=1749;continue;}
case 1749:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1752);}
case 1752:{f.StackOp("pop");f.Pc=1753;continue;}
case 1753:{f.Push(f.Locals[11]);f.Pc=1755;continue;}
case 1755:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1758);}
case 1758:{f.Push(f.Locals[1]);f.Pc=1759;continue;}
case 1759:{f.Push(f.Locals[2]);f.Pc=1760;continue;}
case 1760:{return rt.Call(f,"forge/game/card/CardFactoryUtil","makeEtbCounter","(Ljava/lang/String;Lforge/game/card/CardState;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",1763);}
case 1763:{f.Locals[12]=f.Pop();f.Pc=1765;continue;}
case 1765:{f.Push(f.Locals[0]);f.Pc=1766;continue;}
case 1766:{f.Push(f.Locals[12]);f.Pc=1768;continue;}
case 1768:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",1773);}
case 1773:{f.Pc=3217;continue;}
case 1776:{f.Push(f.Locals[4]);f.Pc=1778;continue;}
case 1778:{f.Push(JValue.R(rt.String("Impending")));f.Pc=1781;continue;}
case 1781:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1784);}
case 1784:{f.Pc=f.Pop().Int==0?1848:1787;continue;}
case 1787:{f.Push(f.Locals[0]);f.Pc=1788;continue;}
case 1788:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/KeywordWithCostAndAmount")?1:0));f.Pc=1791;continue;}
case 1791:{f.Pc=f.Pop().Int==0?1848:1794;continue;}
case 1794:{f.Push(f.Locals[0]);f.Pc=1795;continue;}
case 1795:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordWithCostAndAmount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1798;continue;}
case 1798:{f.Locals[6]=f.Pop();f.Pc=1800;continue;}
case 1800:{f.Push(f.Locals[6]);f.Pc=1802;continue;}
case 1802:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndAmount","getAmountString","()Ljava/lang/String;","invokevirtual",1805);}
case 1805:{f.Push(f.Locals[6]);f.Pc=1807;continue;}
case 1807:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndAmount","getTitle","()Ljava/lang/String;","invokevirtual",1810);}
case 1810:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:1810:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1815);}
case 1815:{f.Locals[9]=f.Pop();f.Pc=1817;continue;}
case 1817:{f.Push(f.Locals[1]);f.Pc=1818;continue;}
case 1818:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=1821;continue;}
case 1821:{f.Push(f.Locals[9]);f.Pc=1823;continue;}
case 1823:{f.Push(JValue.I(0));f.Pc=1824;continue;}
case 1824:{f.Push(JValue.I(1));f.Pc=1825;continue;}
case 1825:{f.Push(f.Locals[2]);f.Pc=1826;continue;}
case 1826:{f.Push(JValue.R(rt.String("Card.Self+impended")));f.Pc=1829;continue;}
case 1829:{f.Push(JValue.R(rt.String("")));f.Pc=1832;continue;}
case 1832:{return rt.Call(f,"forge/game/card/CardFactoryUtil","createETBReplacement","(Lforge/game/card/CardState;Lforge/game/replacement/ReplacementLayer;Ljava/lang/String;ZZZLjava/lang/String;Ljava/lang/String;)Lforge/game/replacement/ReplacementEffect;","invokestatic",1835);}
case 1835:{f.Locals[10]=f.Pop();f.Pc=1837;continue;}
case 1837:{f.Push(f.Locals[0]);f.Pc=1838;continue;}
case 1838:{f.Push(f.Locals[10]);f.Pc=1840;continue;}
case 1840:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",1845);}
case 1845:{f.Pc=3217;continue;}
case 1848:{f.Push(f.Locals[4]);f.Pc=1850;continue;}
case 1850:{f.Push(JValue.R(rt.String("Jump-start")));f.Pc=1853;continue;}
case 1853:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1856);}
case 1856:{f.Pc=f.Pop().Int==0?1965:1859;continue;}
case 1859:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1862;continue;}
case 1862:{f.StackOp("dup");f.Pc=1863;continue;}
case 1863:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",1866);}
case 1866:{f.Locals[9]=f.Pop();f.Pc=1868;continue;}
case 1868:{f.Push(f.Locals[9]);f.Pc=1870;continue;}
case 1870:{f.Push(JValue.R(rt.String("Event$ Moved | ValidCard$ Card.Self | Origin$ Stack | ExcludeDestination$ Exile ")));f.Pc=1873;continue;}
case 1873:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1876);}
case 1876:{f.StackOp("pop");f.Pc=1877;continue;}
case 1877:{f.Push(f.Locals[9]);f.Pc=1879;continue;}
case 1879:{f.Push(JValue.R(rt.String("| Secondary$ True | ValidStackSa$ Spell.Jumpstart | Description$ Jump-start (")));f.Pc=1882;continue;}
case 1882:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1885);}
case 1885:{f.StackOp("pop");f.Pc=1886;continue;}
case 1886:{f.Push(f.Locals[9]);f.Pc=1888;continue;}
case 1888:{f.Push(f.Locals[0]);f.Pc=1889;continue;}
case 1889:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1894);}
case 1894:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1897);}
case 1897:{f.StackOp("pop");f.Pc=1898;continue;}
case 1898:{f.Push(f.Locals[9]);f.Pc=1900;continue;}
case 1900:{f.Push(JValue.R(rt.String(")")));f.Pc=1903;continue;}
case 1903:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1906);}
case 1906:{f.StackOp("pop");f.Pc=1907;continue;}
case 1907:{f.Push(f.Locals[9]);f.Pc=1909;continue;}
case 1909:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1912);}
case 1912:{f.Locals[10]=f.Pop();f.Pc=1914;continue;}
case 1914:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self | Origin$ Stack | Destination$ Exile")));f.Pc=1917;continue;}
case 1917:{f.Locals[11]=f.Pop();f.Pc=1919;continue;}
case 1919:{f.Push(f.Locals[11]);f.Pc=1921;continue;}
case 1921:{f.Push(f.Locals[1]);f.Pc=1922;continue;}
case 1922:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",1925);}
case 1925:{f.Locals[12]=f.Pop();f.Pc=1927;continue;}
case 1927:{f.Push(f.Locals[2]);f.Pc=1928;continue;}
case 1928:{f.Pc=f.Pop().Int!=0?1937:1931;continue;}
case 1931:{f.Push(f.Locals[12]);f.Pc=1933;continue;}
case 1933:{f.Push(JValue.I(0));f.Pc=1934;continue;}
case 1934:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",1937);}
case 1937:{f.Push(f.Locals[10]);f.Pc=1939;continue;}
case 1939:{f.Push(f.Locals[3]);f.Pc=1940;continue;}
case 1940:{f.Push(f.Locals[2]);f.Pc=1941;continue;}
case 1941:{f.Push(f.Locals[1]);f.Pc=1942;continue;}
case 1942:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",1945);}
case 1945:{f.Locals[13]=f.Pop();f.Pc=1947;continue;}
case 1947:{f.Push(f.Locals[13]);f.Pc=1949;continue;}
case 1949:{f.Push(f.Locals[12]);f.Pc=1951;continue;}
case 1951:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1954);}
case 1954:{f.Push(f.Locals[0]);f.Pc=1955;continue;}
case 1955:{f.Push(f.Locals[13]);f.Pc=1957;continue;}
case 1957:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",1962);}
case 1962:{f.Pc=3217;continue;}
case 1965:{f.Push(f.Locals[4]);f.Pc=1967;continue;}
case 1967:{f.Push(JValue.R(rt.String("Madness")));f.Pc=1970;continue;}
case 1970:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1973);}
case 1973:{f.Pc=f.Pop().Int==0?2090:1976;continue;}
case 1976:{f.Push(f.Locals[4]);f.Pc=1978;continue;}
case 1978:{f.Push(JValue.R(rt.String(":")));f.Pc=1981;continue;}
case 1981:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1984);}
case 1984:{f.Locals[9]=f.Pop();f.Pc=1986;continue;}
case 1986:{f.Push(f.Locals[9]);f.Pc=1988;continue;}
case 1988:{f.Push(JValue.I(1));f.Pc=1989;continue;}
case 1989:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1990;continue;}
case 1990:{f.Locals[10]=f.Pop();f.Pc=1992;continue;}
case 1992:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1995;continue;}
case 1995:{f.StackOp("dup");f.Pc=1996;continue;}
case 1996:{f.Push(JValue.R(rt.String("Madness")));f.Pc=1999;continue;}
case 1999:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",2002);}
case 2002:{f.Locals[11]=f.Pop();f.Pc=2004;continue;}
case 2004:{f.Push(JValue.R(rt.String("ManaCost")));f.Pc=2007;continue;}
case 2007:{f.Push(f.Locals[10]);f.Pc=2009;continue;}
case 2009:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2012);}
case 2012:{f.Pc=f.Pop().Int!=0?2032:2015;continue;}
case 2015:{f.Push(f.Locals[11]);f.Pc=2017;continue;}
case 2017:{f.Push(JValue.R(rt.String(" ")));f.Pc=2020;continue;}
case 2020:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2023);}
case 2023:{f.Push(f.Locals[10]);f.Pc=2025;continue;}
case 2025:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",2028);}
case 2028:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2031);}
case 2031:{f.StackOp("pop");f.Pc=2032;continue;}
case 2032:{f.Push(f.Locals[11]);f.Pc=2034;continue;}
case 2034:{f.Push(JValue.R(rt.String(": If you discard this card, discard it into exile.")));f.Pc=2037;continue;}
case 2037:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2040);}
case 2040:{f.StackOp("pop");f.Pc=2041;continue;}
case 2041:{f.Push(f.Locals[11]);f.Pc=2043;continue;}
case 2043:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",2046);}
case 2046:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:2046:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2051);}
case 2051:{f.Locals[12]=f.Pop();f.Pc=2053;continue;}
case 2053:{f.Push(f.Locals[12]);f.Pc=2055;continue;}
case 2055:{f.Push(f.Locals[3]);f.Pc=2056;continue;}
case 2056:{f.Push(f.Locals[2]);f.Pc=2057;continue;}
case 2057:{f.Push(f.Locals[1]);f.Pc=2058;continue;}
case 2058:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",2061);}
case 2061:{f.Locals[13]=f.Pop();f.Pc=2063;continue;}
case 2063:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Hidden$ True | Origin$ All | Destination$ Exile | Defined$ ReplacedCard")));f.Pc=2066;continue;}
case 2066:{f.Locals[14]=f.Pop();f.Pc=2068;continue;}
case 2068:{f.Push(f.Locals[13]);f.Pc=2070;continue;}
case 2070:{f.Push(f.Locals[14]);f.Pc=2072;continue;}
case 2072:{f.Push(f.Locals[1]);f.Pc=2073;continue;}
case 2073:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",2076);}
case 2076:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2079);}
case 2079:{f.Push(f.Locals[0]);f.Pc=2080;continue;}
case 2080:{f.Push(f.Locals[13]);f.Pc=2082;continue;}
case 2082:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",2087);}
case 2087:{f.Pc=3217;continue;}
case 2090:{f.Push(f.Locals[4]);f.Pc=2092;continue;}
case 2092:{f.Push(JValue.R(rt.String("Megamorph")));f.Pc=2095;continue;}
case 2095:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2098);}
case 2098:{f.Pc=f.Pop().Int==0?2157:2101;continue;}
case 2101:{f.Push(JValue.R(rt.String("Event$ TurnFaceUp | ValidCard$ Card.Self | ValidCause$ SpellAbility.SameKeyword | Decription$ Megamorph")));f.Pc=2104;continue;}
case 2104:{f.Locals[9]=f.Pop();f.Pc=2106;continue;}
case 2106:{f.Push(JValue.R(rt.String("DB$ PutCounter | CounterType$ P1P1 | CounterNum$ 1")));f.Pc=2109;continue;}
case 2109:{f.Locals[10]=f.Pop();f.Pc=2111;continue;}
case 2111:{f.Push(f.Locals[10]);f.Pc=2113;continue;}
case 2113:{f.Push(f.Locals[1]);f.Pc=2114;continue;}
case 2114:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",2117);}
case 2117:{f.Locals[11]=f.Pop();f.Pc=2119;continue;}
case 2119:{f.Push(f.Locals[2]);f.Pc=2120;continue;}
case 2120:{f.Pc=f.Pop().Int!=0?2129:2123;continue;}
case 2123:{f.Push(f.Locals[11]);f.Pc=2125;continue;}
case 2125:{f.Push(JValue.I(0));f.Pc=2126;continue;}
case 2126:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",2129);}
case 2129:{f.Push(f.Locals[9]);f.Pc=2131;continue;}
case 2131:{f.Push(f.Locals[3]);f.Pc=2132;continue;}
case 2132:{f.Push(f.Locals[2]);f.Pc=2133;continue;}
case 2133:{f.Push(f.Locals[1]);f.Pc=2134;continue;}
case 2134:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",2137);}
case 2137:{f.Locals[12]=f.Pop();f.Pc=2139;continue;}
case 2139:{f.Push(f.Locals[12]);f.Pc=2141;continue;}
case 2141:{f.Push(f.Locals[11]);f.Pc=2143;continue;}
case 2143:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2146);}
case 2146:{f.Push(f.Locals[0]);f.Pc=2147;continue;}
case 2147:{f.Push(f.Locals[12]);f.Pc=2149;continue;}
case 2149:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",2154);}
case 2154:{f.Pc=3217;continue;}
case 2157:{f.Push(f.Locals[4]);f.Pc=2159;continue;}
case 2159:{f.Push(JValue.R(rt.String("Modular")));f.Pc=2162;continue;}
case 2162:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2165);}
case 2165:{f.Pc=f.Pop().Int==0?2294:2168;continue;}
case 2168:{f.Push(f.Locals[0]);f.Pc=2169;continue;}
case 2169:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/Modular")?1:0));f.Pc=2172;continue;}
case 2172:{f.Pc=f.Pop().Int==0?2294:2175;continue;}
case 2175:{f.Push(f.Locals[0]);f.Pc=2176;continue;}
case 2176:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/Modular"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2179;continue;}
case 2179:{f.Locals[7]=f.Pop();f.Pc=2181;continue;}
case 2181:{f.Push(f.Locals[7]);f.Pc=2183;continue;}
case 2183:{return rt.Call(f,"forge/game/keyword/Modular","getAmountString","()Ljava/lang/String;","invokevirtual",2186);}
case 2186:{f.Locals[9]=f.Pop();f.Pc=2188;continue;}
case 2188:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=2191;continue;}
case 2191:{f.StackOp("dup");f.Pc=2192;continue;}
case 2192:{f.Push(JValue.R(rt.String("etbCounter:P1P1:")));f.Pc=2195;continue;}
case 2195:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",2198);}
case 2198:{f.Locals[10]=f.Pop();f.Pc=2200;continue;}
case 2200:{f.Push(f.Locals[10]);f.Pc=2202;continue;}
case 2202:{f.Push(f.Locals[9]);f.Pc=2204;continue;}
case 2204:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2207);}
case 2207:{f.Push(JValue.R(rt.String(":no Condition:")));f.Pc=2210;continue;}
case 2210:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2213);}
case 2213:{f.StackOp("pop");f.Pc=2214;continue;}
case 2214:{f.Push(f.Locals[10]);f.Pc=2216;continue;}
case 2216:{f.Push(f.Locals[7]);f.Pc=2218;continue;}
case 2218:{return rt.Call(f,"forge/game/keyword/Modular","getTitle","()Ljava/lang/String;","invokevirtual",2221);}
case 2221:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2224);}
case 2224:{f.Push(JValue.R(rt.String(" (")));f.Pc=2227;continue;}
case 2227:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2230);}
case 2230:{f.Push(f.Locals[0]);f.Pc=2231;continue;}
case 2231:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2236);}
case 2236:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2239);}
case 2239:{f.Push(JValue.R(rt.String(")")));f.Pc=2242;continue;}
case 2242:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2245);}
case 2245:{f.StackOp("pop");f.Pc=2246;continue;}
case 2246:{f.Push(f.Locals[10]);f.Pc=2248;continue;}
case 2248:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",2251);}
case 2251:{f.Push(f.Locals[1]);f.Pc=2252;continue;}
case 2252:{f.Push(f.Locals[2]);f.Pc=2253;continue;}
case 2253:{return rt.Call(f,"forge/game/card/CardFactoryUtil","makeEtbCounter","(Ljava/lang/String;Lforge/game/card/CardState;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",2256);}
case 2256:{f.Locals[11]=f.Pop();f.Pc=2258;continue;}
case 2258:{f.Push(JValue.R(rt.String("Sunburst")));f.Pc=2261;continue;}
case 2261:{f.Push(f.Locals[9]);f.Pc=2263;continue;}
case 2263:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2266);}
case 2266:{f.Pc=f.Pop().Int==0?2283:2269;continue;}
case 2269:{f.Push(f.Locals[11]);f.Pc=2271;continue;}
case 2271:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",2274);}
case 2274:{f.Push(JValue.R(rt.String("Sunburst")));f.Pc=2277;continue;}
case 2277:{f.Push(JValue.R(rt.String("Count$Converge")));f.Pc=2280;continue;}
case 2280:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",2283);}
case 2283:{f.Push(f.Locals[0]);f.Pc=2284;continue;}
case 2284:{f.Push(f.Locals[11]);f.Pc=2286;continue;}
case 2286:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",2291);}
case 2291:{f.Pc=3217;continue;}
case 2294:{f.Push(f.Locals[4]);f.Pc=2296;continue;}
case 2296:{f.Push(JValue.R(rt.String("Ravenous")));f.Pc=2299;continue;}
case 2299:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2302);}
case 2302:{f.Pc=f.Pop().Int==0?2379:2305;continue;}
case 2305:{f.Push(f.Locals[0]);f.Pc=2306;continue;}
case 2306:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2311);}
case 2311:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:2311:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2316);}
case 2316:{f.Locals[9]=f.Pop();f.Pc=2318;continue;}
case 2318:{f.Push(JValue.R(rt.String("DB$ PutCounter | CounterType$ P1P1 | ETB$ True | CounterNum$ X")));f.Pc=2321;continue;}
case 2321:{f.Locals[10]=f.Pop();f.Pc=2323;continue;}
case 2323:{f.Push(f.Locals[10]);f.Pc=2325;continue;}
case 2325:{f.Push(f.Locals[1]);f.Pc=2326;continue;}
case 2326:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",2329);}
case 2329:{f.Locals[11]=f.Pop();f.Pc=2331;continue;}
case 2331:{f.Push(f.Locals[2]);f.Pc=2332;continue;}
case 2332:{f.Pc=f.Pop().Int!=0?2341:2335;continue;}
case 2335:{f.Push(f.Locals[11]);f.Pc=2337;continue;}
case 2337:{f.Push(JValue.I(0));f.Pc=2338;continue;}
case 2338:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",2341);}
case 2341:{f.Push(f.Locals[9]);f.Pc=2343;continue;}
case 2343:{f.Push(f.Locals[3]);f.Pc=2344;continue;}
case 2344:{f.Push(f.Locals[2]);f.Pc=2345;continue;}
case 2345:{f.Push(f.Locals[1]);f.Pc=2346;continue;}
case 2346:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",2349);}
case 2349:{f.Locals[12]=f.Pop();f.Pc=2351;continue;}
case 2351:{f.Push(f.Locals[12]);f.Pc=2353;continue;}
case 2353:{f.Push(f.Locals[11]);f.Pc=2355;continue;}
case 2355:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2358);}
case 2358:{f.Push(f.Locals[11]);f.Pc=2360;continue;}
case 2360:{f.Push(JValue.R(rt.String("X")));f.Pc=2362;continue;}
case 2362:{f.Push(JValue.R(rt.String("Count$xPaid")));f.Pc=2365;continue;}
case 2365:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",2368);}
case 2368:{f.Push(f.Locals[0]);f.Pc=2369;continue;}
case 2369:{f.Push(f.Locals[12]);f.Pc=2371;continue;}
case 2371:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",2376);}
case 2376:{f.Pc=3217;continue;}
case 2379:{f.Push(f.Locals[4]);f.Pc=2381;continue;}
case 2381:{f.Push(JValue.R(rt.String("Read ahead")));f.Pc=2384;continue;}
case 2384:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2387);}
case 2387:{f.Pc=f.Pop().Int==0?2457:2390;continue;}
case 2390:{f.Push(JValue.R(rt.String("Event$ Moved | ValidCard$ Card.Self | Destination$ Battlefield | Secondary$ True | ReplacementResult$ Updated | Description$ Choose a chapter and start with that many lore counters.")));f.Pc=2393;continue;}
case 2393:{f.Locals[9]=f.Pop();f.Pc=2395;continue;}
case 2395:{f.Push(JValue.R(rt.String("DB$ PutCounter | Defined$ Self | CounterType$ LORE | ETB$ True | UpTo$ True | UpToMin$ 1 | CounterNum$ FinalChapterNr")));f.Pc=2398;continue;}
case 2398:{f.Locals[10]=f.Pop();f.Pc=2400;continue;}
case 2400:{f.Push(f.Locals[10]);f.Pc=2402;continue;}
case 2402:{f.Push(f.Locals[1]);f.Pc=2403;continue;}
case 2403:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",2406);}
case 2406:{f.Locals[11]=f.Pop();f.Pc=2408;continue;}
case 2408:{f.Push(f.Locals[11]);f.Pc=2410;continue;}
case 2410:{f.Push(JValue.R(rt.String("FinalChapterNr")));f.Pc=2413;continue;}
case 2413:{f.Push(JValue.R(rt.String("Count$FinalChapterNr")));f.Pc=2416;continue;}
case 2416:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",2419);}
case 2419:{f.Push(f.Locals[2]);f.Pc=2420;continue;}
case 2420:{f.Pc=f.Pop().Int!=0?2429:2423;continue;}
case 2423:{f.Push(f.Locals[11]);f.Pc=2425;continue;}
case 2425:{f.Push(JValue.I(0));f.Pc=2426;continue;}
case 2426:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",2429);}
case 2429:{f.Push(f.Locals[9]);f.Pc=2431;continue;}
case 2431:{f.Push(f.Locals[3]);f.Pc=2432;continue;}
case 2432:{f.Push(f.Locals[2]);f.Pc=2433;continue;}
case 2433:{f.Push(f.Locals[1]);f.Pc=2434;continue;}
case 2434:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",2437);}
case 2437:{f.Locals[12]=f.Pop();f.Pc=2439;continue;}
case 2439:{f.Push(f.Locals[12]);f.Pc=2441;continue;}
case 2441:{f.Push(f.Locals[11]);f.Pc=2443;continue;}
case 2443:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2446);}
case 2446:{f.Push(f.Locals[0]);f.Pc=2447;continue;}
case 2447:{f.Push(f.Locals[12]);f.Pc=2449;continue;}
case 2449:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",2454);}
case 2454:{f.Pc=3217;continue;}
case 2457:{f.Push(f.Locals[4]);f.Pc=2459;continue;}
case 2459:{f.Push(JValue.R(rt.String("Rebound")));f.Pc=2462;continue;}
case 2462:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2465);}
case 2465:{f.Pc=f.Pop().Int==0?2587:2468;continue;}
case 2468:{f.Push(f.Locals[0]);f.Pc=2469;continue;}
case 2469:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2474);}
case 2474:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:2474:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2479);}
case 2479:{f.Locals[9]=f.Pop();f.Pc=2481;continue;}
case 2481:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ ReplacedCard | Origin$ Stack | Destination$ Exile | RememberChanged$ True")));f.Pc=2484;continue;}
case 2484:{f.Locals[10]=f.Pop();f.Pc=2486;continue;}
case 2486:{f.Push(f.Locals[1]);f.Pc=2487;continue;}
case 2487:{return rt.Call(f,"forge/game/card/CardState","toString","()Ljava/lang/String;","invokevirtual",2490);}
case 2490:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:2490:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2495);}
case 2495:{f.Locals[11]=f.Pop();f.Pc=2497;continue;}
case 2497:{f.Push(JValue.R(rt.String("DB$ Play | Defined$ DelayTriggerRememberedLKI | WithoutManaCost$ True | Optional$ True")));f.Pc=2500;continue;}
case 2500:{f.Locals[12]=f.Pop();f.Pc=2502;continue;}
case 2502:{f.Push(f.Locals[10]);f.Pc=2504;continue;}
case 2504:{f.Push(f.Locals[1]);f.Pc=2505;continue;}
case 2505:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",2508);}
case 2508:{f.Locals[13]=f.Pop();f.Pc=2510;continue;}
case 2510:{f.Push(f.Locals[11]);f.Pc=2512;continue;}
case 2512:{f.Push(f.Locals[1]);f.Pc=2513;continue;}
case 2513:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",2516);}
case 2516:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2519;continue;}
case 2519:{f.Locals[14]=f.Pop();f.Pc=2521;continue;}
case 2521:{f.Push(f.Locals[12]);f.Pc=2523;continue;}
case 2523:{f.Push(f.Locals[1]);f.Pc=2524;continue;}
case 2524:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",2527);}
case 2527:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2530;continue;}
case 2530:{f.Locals[15]=f.Pop();f.Pc=2532;continue;}
case 2532:{f.Push(f.Locals[14]);f.Pc=2534;continue;}
case 2534:{f.Push(JValue.R(rt.String("Execute")));f.Pc=2537;continue;}
case 2537:{f.Push(f.Locals[15]);f.Pc=2539;continue;}
case 2539:{return rt.Call(f,"forge/game/spellability/AbilitySub","setAdditionalAbility","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)V","invokevirtual",2542);}
case 2542:{f.Push(f.Locals[13]);f.Pc=2544;continue;}
case 2544:{f.Push(f.Locals[14]);f.Pc=2546;continue;}
case 2546:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",2549);}
case 2549:{f.Push(f.Locals[2]);f.Pc=2550;continue;}
case 2550:{f.Pc=f.Pop().Int!=0?2559:2553;continue;}
case 2553:{f.Push(f.Locals[13]);f.Pc=2555;continue;}
case 2555:{f.Push(JValue.I(0));f.Pc=2556;continue;}
case 2556:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",2559);}
case 2559:{f.Push(f.Locals[9]);f.Pc=2561;continue;}
case 2561:{f.Push(f.Locals[3]);f.Pc=2562;continue;}
case 2562:{f.Push(f.Locals[2]);f.Pc=2563;continue;}
case 2563:{f.Push(f.Locals[1]);f.Pc=2564;continue;}
case 2564:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",2567);}
case 2567:{f.Locals[16]=f.Pop();f.Pc=2569;continue;}
case 2569:{f.Push(f.Locals[16]);f.Pc=2571;continue;}
case 2571:{f.Push(f.Locals[13]);f.Pc=2573;continue;}
case 2573:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2576);}
case 2576:{f.Push(f.Locals[0]);f.Pc=2577;continue;}
case 2577:{f.Push(f.Locals[16]);f.Pc=2579;continue;}
case 2579:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",2584);}
case 2584:{f.Pc=3217;continue;}
case 2587:{f.Push(f.Locals[4]);f.Pc=2589;continue;}
case 2589:{f.Push(JValue.R(rt.String("Reflect:")));f.Pc=2592;continue;}
case 2592:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2595);}
case 2595:{f.Pc=f.Pop().Int==0?2712:2598;continue;}
case 2598:{f.Push(f.Locals[4]);f.Pc=2600;continue;}
case 2600:{f.Push(JValue.R(rt.String(":")));f.Pc=2603;continue;}
case 2603:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2606);}
case 2606:{f.Locals[9]=f.Pop();f.Pc=2608;continue;}
case 2608:{f.Push(JValue.R(rt.String("DB$ RepeatEach | RepeatPlayers$ Opponent")));f.Pc=2611;continue;}
case 2611:{f.Locals[10]=f.Pop();f.Pc=2613;continue;}
case 2613:{f.Push(f.Locals[9]);f.Pc=2615;continue;}
case 2615:{f.Push(JValue.I(1));f.Pc=2616;continue;}
case 2616:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2617;continue;}
case 2617:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:2617:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2622);}
case 2622:{f.Locals[11]=f.Pop();f.Pc=2624;continue;}
case 2624:{f.Push(JValue.R(rt.String("DB$ CopyPermanent | Defined$ Self | Controller$ Player.IsTriggerRemembered | RemoveKeywords$ Reflect")));f.Pc=2627;continue;}
case 2627:{f.Locals[12]=f.Pop();f.Pc=2629;continue;}
case 2629:{f.Push(JValue.R(rt.String("DB$ RepeatEach | RepeatPlayers$ Opponent")));f.Pc=2632;continue;}
case 2632:{f.Push(f.Locals[1]);f.Pc=2633;continue;}
case 2633:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",2636);}
case 2636:{f.Locals[13]=f.Pop();f.Pc=2638;continue;}
case 2638:{f.Push(f.Locals[11]);f.Pc=2640;continue;}
case 2640:{f.Push(f.Locals[1]);f.Pc=2641;continue;}
case 2641:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",2644);}
case 2644:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2647;continue;}
case 2647:{f.Locals[14]=f.Pop();f.Pc=2649;continue;}
case 2649:{f.Push(JValue.R(rt.String("DB$ CopyPermanent | Defined$ Self | Controller$ Player.IsTriggerRemembered | RemoveKeywords$ Reflect")));f.Pc=2652;continue;}
case 2652:{f.Push(f.Locals[1]);f.Pc=2653;continue;}
case 2653:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",2656);}
case 2656:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2659;continue;}
case 2659:{f.Locals[15]=f.Pop();f.Pc=2661;continue;}
case 2661:{f.Push(f.Locals[13]);f.Pc=2663;continue;}
case 2663:{f.Push(JValue.R(rt.String("RepeatSubAbility")));f.Pc=2666;continue;}
case 2666:{f.Push(f.Locals[14]);f.Pc=2668;continue;}
case 2668:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAdditionalAbility","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)V","invokevirtual",2671);}
case 2671:{f.Push(f.Locals[14]);f.Pc=2673;continue;}
case 2673:{f.Push(JValue.R(rt.String("Execute")));f.Pc=2676;continue;}
case 2676:{f.Push(f.Locals[15]);f.Pc=2678;continue;}
case 2678:{return rt.Call(f,"forge/game/spellability/AbilitySub","setAdditionalAbility","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)V","invokevirtual",2681);}
case 2681:{f.Push(f.Locals[1]);f.Pc=2682;continue;}
case 2682:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=2685;continue;}
case 2685:{f.Push(f.Locals[13]);f.Pc=2687;continue;}
case 2687:{f.Push(JValue.I(0));f.Pc=2688;continue;}
case 2688:{f.Push(JValue.I(1));f.Pc=2689;continue;}
case 2689:{f.Push(f.Locals[2]);f.Pc=2690;continue;}
case 2690:{f.Push(JValue.R(rt.String("Card.Self")));f.Pc=2693;continue;}
case 2693:{f.Push(JValue.R(rt.String("")));f.Pc=2696;continue;}
case 2696:{return rt.Call(f,"forge/game/card/CardFactoryUtil","createETBReplacement","(Lforge/game/card/CardState;Lforge/game/replacement/ReplacementLayer;Lforge/game/spellability/SpellAbility;ZZZLjava/lang/String;Ljava/lang/String;)Lforge/game/replacement/ReplacementEffect;","invokestatic",2699);}
case 2699:{f.Locals[16]=f.Pop();f.Pc=2701;continue;}
case 2701:{f.Push(f.Locals[0]);f.Pc=2702;continue;}
case 2702:{f.Push(f.Locals[16]);f.Pc=2704;continue;}
case 2704:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",2709);}
case 2709:{f.Pc=3217;continue;}
case 2712:{f.Push(f.Locals[4]);f.Pc=2714;continue;}
case 2714:{f.Push(JValue.R(rt.String("Riot")));f.Pc=2717;continue;}
case 2717:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2720);}
case 2720:{f.Pc=f.Pop().Int==0?2768:2723;continue;}
case 2723:{f.Push(JValue.R(rt.String("DB$ Animate | Defined$ Self | Keywords$ Haste | Duration$ Permanent | UnlessCost$ AddCounter<1/P1P1> | UnlessPayer$ You | SpellDescription$ Riot")));f.Pc=2726;continue;}
case 2726:{f.Locals[9]=f.Pop();f.Pc=2728;continue;}
case 2728:{f.Push(JValue.R(rt.String("DB$ Animate | Defined$ Self | Keywords$ Haste | Duration$ Permanent | UnlessCost$ AddCounter<1/P1P1> | UnlessPayer$ You | SpellDescription$ Riot")));f.Pc=2731;continue;}
case 2731:{f.Push(f.Locals[1]);f.Pc=2732;continue;}
case 2732:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",2735);}
case 2735:{f.Locals[10]=f.Pop();f.Pc=2737;continue;}
case 2737:{f.Push(f.Locals[1]);f.Pc=2738;continue;}
case 2738:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=2741;continue;}
case 2741:{f.Push(f.Locals[10]);f.Pc=2743;continue;}
case 2743:{f.Push(JValue.I(0));f.Pc=2744;continue;}
case 2744:{f.Push(JValue.I(1));f.Pc=2745;continue;}
case 2745:{f.Push(f.Locals[2]);f.Pc=2746;continue;}
case 2746:{f.Push(JValue.R(rt.String("Card.Self")));f.Pc=2749;continue;}
case 2749:{f.Push(JValue.R(rt.String("")));f.Pc=2752;continue;}
case 2752:{return rt.Call(f,"forge/game/card/CardFactoryUtil","createETBReplacement","(Lforge/game/card/CardState;Lforge/game/replacement/ReplacementLayer;Lforge/game/spellability/SpellAbility;ZZZLjava/lang/String;Ljava/lang/String;)Lforge/game/replacement/ReplacementEffect;","invokestatic",2755);}
case 2755:{f.Locals[11]=f.Pop();f.Pc=2757;continue;}
case 2757:{f.Push(f.Locals[0]);f.Pc=2758;continue;}
case 2758:{f.Push(f.Locals[11]);f.Pc=2760;continue;}
case 2760:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",2765);}
case 2765:{f.Pc=3217;continue;}
case 2768:{f.Push(f.Locals[4]);f.Pc=2770;continue;}
case 2770:{f.Push(JValue.R(rt.String("Sunburst")));f.Pc=2773;continue;}
case 2773:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2776);}
case 2776:{f.Pc=f.Pop().Int==0?2884:2779;continue;}
case 2779:{f.Push(f.Locals[3]);f.Pc=2780;continue;}
case 2780:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",2783);}
case 2783:{f.Pc=f.Pop().Int==0?2792:2786;continue;}
case 2786:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"));f.Pc=2789;continue;}
case 2789:{f.Pc=2795;continue;}
case 2792:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","CHARGE","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","CHARGE","Lforge/game/card/CounterEnumType;"));f.Pc=2795;continue;}
case 2795:{f.Locals[9]=f.Pop();f.Pc=2797;continue;}
case 2797:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=2800;continue;}
case 2800:{f.StackOp("dup");f.Pc=2801;continue;}
case 2801:{f.Push(JValue.R(rt.String("etbCounter:")));f.Pc=2804;continue;}
case 2804:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",2807);}
case 2807:{f.Locals[10]=f.Pop();f.Pc=2809;continue;}
case 2809:{f.Push(f.Locals[10]);f.Pc=2811;continue;}
case 2811:{f.Push(f.Locals[9]);f.Pc=2813;continue;}
case 2813:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",2816);}
case 2816:{f.Push(JValue.R(rt.String(":Sunburst:no Condition:")));f.Pc=2819;continue;}
case 2819:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2822);}
case 2822:{f.StackOp("pop");f.Pc=2823;continue;}
case 2823:{f.Push(f.Locals[10]);f.Pc=2825;continue;}
case 2825:{f.Push(JValue.R(rt.String("Sunburst (")));f.Pc=2828;continue;}
case 2828:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2831);}
case 2831:{f.Push(f.Locals[0]);f.Pc=2832;continue;}
case 2832:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2837);}
case 2837:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2840);}
case 2840:{f.Push(JValue.R(rt.String(")")));f.Pc=2843;continue;}
case 2843:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2846);}
case 2846:{f.StackOp("pop");f.Pc=2847;continue;}
case 2847:{f.Push(f.Locals[10]);f.Pc=2849;continue;}
case 2849:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",2852);}
case 2852:{f.Push(f.Locals[1]);f.Pc=2853;continue;}
case 2853:{f.Push(f.Locals[2]);f.Pc=2854;continue;}
case 2854:{return rt.Call(f,"forge/game/card/CardFactoryUtil","makeEtbCounter","(Ljava/lang/String;Lforge/game/card/CardState;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",2857);}
case 2857:{f.Locals[11]=f.Pop();f.Pc=2859;continue;}
case 2859:{f.Push(f.Locals[11]);f.Pc=2861;continue;}
case 2861:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",2864);}
case 2864:{f.Push(JValue.R(rt.String("Sunburst")));f.Pc=2867;continue;}
case 2867:{f.Push(JValue.R(rt.String("Count$Converge")));f.Pc=2870;continue;}
case 2870:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",2873);}
case 2873:{f.Push(f.Locals[0]);f.Pc=2874;continue;}
case 2874:{f.Push(f.Locals[11]);f.Pc=2876;continue;}
case 2876:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",2881);}
case 2881:{f.Pc=3217;continue;}
case 2884:{f.Push(f.Locals[4]);f.Pc=2886;continue;}
case 2886:{f.Push(JValue.R(rt.String("Tribute")));f.Pc=2889;continue;}
case 2889:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2892);}
case 2892:{f.Pc=f.Pop().Int==0?2959:2895;continue;}
case 2895:{f.Push(f.Locals[4]);f.Pc=2897;continue;}
case 2897:{f.Push(JValue.R(rt.String(":")));f.Pc=2900;continue;}
case 2900:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2903);}
case 2903:{f.Locals[9]=f.Pop();f.Pc=2905;continue;}
case 2905:{f.Push(f.Locals[9]);f.Pc=2907;continue;}
case 2907:{f.Push(JValue.I(1));f.Pc=2908;continue;}
case 2908:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2909;continue;}
case 2909:{f.Locals[10]=f.Pop();f.Pc=2911;continue;}
case 2911:{f.Push(f.Locals[10]);f.Pc=2913;continue;}
case 2913:{f.Push(f.Locals[10]);f.Pc=2915;continue;}
case 2915:{f.Push(f.Locals[0]);f.Pc=2916;continue;}
case 2916:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2921);}
case 2921:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:2921:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2926);}
case 2926:{f.Locals[11]=f.Pop();f.Pc=2928;continue;}
case 2928:{f.Push(f.Locals[1]);f.Pc=2929;continue;}
case 2929:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=2932;continue;}
case 2932:{f.Push(f.Locals[11]);f.Pc=2934;continue;}
case 2934:{f.Push(JValue.I(0));f.Pc=2935;continue;}
case 2935:{f.Push(JValue.I(1));f.Pc=2936;continue;}
case 2936:{f.Push(f.Locals[2]);f.Pc=2937;continue;}
case 2937:{f.Push(JValue.R(rt.String("Card.Self")));f.Pc=2940;continue;}
case 2940:{f.Push(JValue.R(rt.String("")));f.Pc=2943;continue;}
case 2943:{return rt.Call(f,"forge/game/card/CardFactoryUtil","createETBReplacement","(Lforge/game/card/CardState;Lforge/game/replacement/ReplacementLayer;Ljava/lang/String;ZZZLjava/lang/String;Ljava/lang/String;)Lforge/game/replacement/ReplacementEffect;","invokestatic",2946);}
case 2946:{f.Locals[12]=f.Pop();f.Pc=2948;continue;}
case 2948:{f.Push(f.Locals[0]);f.Pc=2949;continue;}
case 2949:{f.Push(f.Locals[12]);f.Pc=2951;continue;}
case 2951:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",2956);}
case 2956:{f.Pc=3217;continue;}
case 2959:{f.Push(f.Locals[4]);f.Pc=2961;continue;}
case 2961:{f.Push(JValue.R(rt.String("Umbra armor")));f.Pc=2964;continue;}
case 2964:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2967);}
case 2967:{f.Pc=f.Pop().Int==0?3057:2970;continue;}
case 2970:{f.Push(f.Locals[0]);f.Pc=2971;continue;}
case 2971:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2976);}
case 2976:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:2976:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2981);}
case 2981:{f.Locals[9]=f.Pop();f.Pc=2983;continue;}
case 2983:{f.Push(JValue.R(rt.String("DB$ HealDamage | Defined$ ReplacedCard")));f.Pc=2986;continue;}
case 2986:{f.Locals[10]=f.Pop();f.Pc=2988;continue;}
case 2988:{f.Push(JValue.R(rt.String("DB$ Destroy | Defined$ Self")));f.Pc=2991;continue;}
case 2991:{f.Locals[11]=f.Pop();f.Pc=2993;continue;}
case 2993:{f.Push(f.Locals[10]);f.Pc=2995;continue;}
case 2995:{f.Push(f.Locals[1]);f.Pc=2996;continue;}
case 2996:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",2999);}
case 2999:{f.Locals[12]=f.Pop();f.Pc=3001;continue;}
case 3001:{f.Push(f.Locals[11]);f.Pc=3003;continue;}
case 3003:{f.Push(f.Locals[1]);f.Pc=3004;continue;}
case 3004:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",3007);}
case 3007:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3010;continue;}
case 3010:{f.Locals[13]=f.Pop();f.Pc=3012;continue;}
case 3012:{f.Push(f.Locals[12]);f.Pc=3014;continue;}
case 3014:{f.Push(f.Locals[13]);f.Pc=3016;continue;}
case 3016:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",3019);}
case 3019:{f.Push(f.Locals[2]);f.Pc=3020;continue;}
case 3020:{f.Pc=f.Pop().Int!=0?3029:3023;continue;}
case 3023:{f.Push(f.Locals[12]);f.Pc=3025;continue;}
case 3025:{f.Push(JValue.I(0));f.Pc=3026;continue;}
case 3026:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",3029);}
case 3029:{f.Push(f.Locals[9]);f.Pc=3031;continue;}
case 3031:{f.Push(f.Locals[3]);f.Pc=3032;continue;}
case 3032:{f.Push(f.Locals[2]);f.Pc=3033;continue;}
case 3033:{f.Push(f.Locals[1]);f.Pc=3034;continue;}
case 3034:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",3037);}
case 3037:{f.Locals[14]=f.Pop();f.Pc=3039;continue;}
case 3039:{f.Push(f.Locals[14]);f.Pc=3041;continue;}
case 3041:{f.Push(f.Locals[12]);f.Pc=3043;continue;}
case 3043:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",3046);}
case 3046:{f.Push(f.Locals[0]);f.Pc=3047;continue;}
case 3047:{f.Push(f.Locals[14]);f.Pc=3049;continue;}
case 3049:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",3054);}
case 3054:{f.Pc=3217;continue;}
case 3057:{f.Push(f.Locals[4]);f.Pc=3059;continue;}
case 3059:{f.Push(JValue.R(rt.String("Unleash")));f.Pc=3062;continue;}
case 3062:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3065);}
case 3065:{f.Pc=f.Pop().Int==0?3112:3068;continue;}
case 3068:{f.Push(f.Locals[0]);f.Pc=3069;continue;}
case 3069:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",3074);}
case 3074:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:3074:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",3079);}
case 3079:{f.Locals[9]=f.Pop();f.Pc=3081;continue;}
case 3081:{f.Push(f.Locals[1]);f.Pc=3082;continue;}
case 3082:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=3085;continue;}
case 3085:{f.Push(f.Locals[9]);f.Pc=3087;continue;}
case 3087:{f.Push(JValue.I(1));f.Pc=3088;continue;}
case 3088:{f.Push(JValue.I(1));f.Pc=3089;continue;}
case 3089:{f.Push(f.Locals[2]);f.Pc=3090;continue;}
case 3090:{f.Push(JValue.R(rt.String("Card.Self")));f.Pc=3093;continue;}
case 3093:{f.Push(JValue.R(rt.String("")));f.Pc=3096;continue;}
case 3096:{return rt.Call(f,"forge/game/card/CardFactoryUtil","createETBReplacement","(Lforge/game/card/CardState;Lforge/game/replacement/ReplacementLayer;Ljava/lang/String;ZZZLjava/lang/String;Ljava/lang/String;)Lforge/game/replacement/ReplacementEffect;","invokestatic",3099);}
case 3099:{f.Locals[10]=f.Pop();f.Pc=3101;continue;}
case 3101:{f.Push(f.Locals[0]);f.Pc=3102;continue;}
case 3102:{f.Push(f.Locals[10]);f.Pc=3104;continue;}
case 3104:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",3109);}
case 3109:{f.Pc=3217;continue;}
case 3112:{f.Push(f.Locals[4]);f.Pc=3114;continue;}
case 3114:{f.Push(JValue.R(rt.String("Vanishing:")));f.Pc=3117;continue;}
case 3117:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3120);}
case 3120:{f.Pc=f.Pop().Int==0?3217:3123;continue;}
case 3123:{f.Push(f.Locals[0]);f.Pc=3124;continue;}
case 3124:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/Vanishing")?1:0));f.Pc=3127;continue;}
case 3127:{f.Pc=f.Pop().Int==0?3217:3130;continue;}
case 3130:{f.Push(f.Locals[0]);f.Pc=3131;continue;}
case 3131:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/Vanishing"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3134;continue;}
case 3134:{f.Locals[8]=f.Pop();f.Pc=3136;continue;}
case 3136:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3139;continue;}
case 3139:{f.StackOp("dup");f.Pc=3140;continue;}
case 3140:{f.Push(JValue.R(rt.String("etbCounter:TIME:")));f.Pc=3143;continue;}
case 3143:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",3146);}
case 3146:{f.Locals[9]=f.Pop();f.Pc=3148;continue;}
case 3148:{f.Push(f.Locals[9]);f.Pc=3150;continue;}
case 3150:{f.Push(f.Locals[8]);f.Pc=3152;continue;}
case 3152:{return rt.Call(f,"forge/game/keyword/Vanishing","getAmount","()I","invokevirtual",3155);}
case 3155:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",3158);}
case 3158:{f.Push(JValue.R(rt.String(":no Condition:")));f.Pc=3161;continue;}
case 3161:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3164);}
case 3164:{f.StackOp("pop");f.Pc=3165;continue;}
case 3165:{f.Push(f.Locals[9]);f.Pc=3167;continue;}
case 3167:{f.Push(f.Locals[8]);f.Pc=3169;continue;}
case 3169:{return rt.Call(f,"forge/game/keyword/Vanishing","getTitle","()Ljava/lang/String;","invokevirtual",3172);}
case 3172:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3175);}
case 3175:{f.Push(JValue.R(rt.String(" (")));f.Pc=3178;continue;}
case 3178:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3181);}
case 3181:{f.Push(f.Locals[0]);f.Pc=3182;continue;}
case 3182:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",3187);}
case 3187:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3190);}
case 3190:{f.Push(JValue.R(rt.String(")")));f.Pc=3193;continue;}
case 3193:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3196);}
case 3196:{f.StackOp("pop");f.Pc=3197;continue;}
case 3197:{f.Push(f.Locals[9]);f.Pc=3199;continue;}
case 3199:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",3202);}
case 3202:{f.Push(f.Locals[1]);f.Pc=3203;continue;}
case 3203:{f.Push(f.Locals[2]);f.Pc=3204;continue;}
case 3204:{return rt.Call(f,"forge/game/card/CardFactoryUtil","makeEtbCounter","(Ljava/lang/String;Lforge/game/card/CardState;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",3207);}
case 3207:{f.Locals[10]=f.Pop();f.Pc=3209;continue;}
case 3209:{f.Push(f.Locals[0]);f.Pc=3210;continue;}
case 3210:{f.Push(f.Locals[10]);f.Pc=3212;continue;}
case 3212:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",3217);}
case 3217:{f.Push(f.Locals[4]);f.Pc=3219;continue;}
case 3219:{f.Push(JValue.R(rt.String("Prevent all ")));f.Pc=3222;continue;}
case 3222:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3225);}
case 3225:{f.Pc=f.Pop().Int==0?3448:3228;continue;}
case 3228:{f.Push(JValue.I(0));f.Pc=3229;continue;}
case 3229:{f.Locals[5]=f.Pop();f.Pc=3231;continue;}
case 3231:{f.Push(JValue.I(0));f.Pc=3232;continue;}
case 3232:{f.Locals[6]=f.Pop();f.Pc=3234;continue;}
case 3234:{f.Push(JValue.I(0));f.Pc=3235;continue;}
case 3235:{f.Locals[7]=f.Pop();f.Pc=3237;continue;}
case 3237:{f.Push(f.Locals[4]);f.Pc=3239;continue;}
case 3239:{f.Push(JValue.R(rt.String("Prevent all combat damage that would be dealt to and dealt by CARDNAME.")));f.Pc=3242;continue;}
case 3242:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3245);}
case 3245:{f.Pc=f.Pop().Int==0?3260:3248;continue;}
case 3248:{f.Push(JValue.I(1));f.Pc=3249;continue;}
case 3249:{f.StackOp("dup");f.Pc=3250;continue;}
case 3250:{f.Locals[7]=f.Pop();f.Pc=3252;continue;}
case 3252:{f.StackOp("dup");f.Pc=3253;continue;}
case 3253:{f.Locals[6]=f.Pop();f.Pc=3255;continue;}
case 3255:{f.Locals[5]=f.Pop();f.Pc=3257;continue;}
case 3257:{f.Pc=3351;continue;}
case 3260:{f.Push(f.Locals[4]);f.Pc=3262;continue;}
case 3262:{f.Push(JValue.R(rt.String("Prevent all combat damage that would be dealt by CARDNAME.")));f.Pc=3265;continue;}
case 3265:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3268);}
case 3268:{f.Pc=f.Pop().Int==0?3280:3271;continue;}
case 3271:{f.Push(JValue.I(1));f.Pc=3272;continue;}
case 3272:{f.StackOp("dup");f.Pc=3273;continue;}
case 3273:{f.Locals[6]=f.Pop();f.Pc=3275;continue;}
case 3275:{f.Locals[5]=f.Pop();f.Pc=3277;continue;}
case 3277:{f.Pc=3351;continue;}
case 3280:{f.Push(f.Locals[4]);f.Pc=3282;continue;}
case 3282:{f.Push(JValue.R(rt.String("Prevent all combat damage that would be dealt to CARDNAME.")));f.Pc=3285;continue;}
case 3285:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3288);}
case 3288:{f.Pc=f.Pop().Int==0?3300:3291;continue;}
case 3291:{f.Push(JValue.I(1));f.Pc=3292;continue;}
case 3292:{f.StackOp("dup");f.Pc=3293;continue;}
case 3293:{f.Locals[7]=f.Pop();f.Pc=3295;continue;}
case 3295:{f.Locals[5]=f.Pop();f.Pc=3297;continue;}
case 3297:{f.Pc=3351;continue;}
case 3300:{f.Push(f.Locals[4]);f.Pc=3302;continue;}
case 3302:{f.Push(JValue.R(rt.String("Prevent all damage that would be dealt to and dealt by CARDNAME.")));f.Pc=3305;continue;}
case 3305:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3308);}
case 3308:{f.Pc=f.Pop().Int==0?3320:3311;continue;}
case 3311:{f.Push(JValue.I(1));f.Pc=3312;continue;}
case 3312:{f.StackOp("dup");f.Pc=3313;continue;}
case 3313:{f.Locals[7]=f.Pop();f.Pc=3315;continue;}
case 3315:{f.Locals[6]=f.Pop();f.Pc=3317;continue;}
case 3317:{f.Pc=3351;continue;}
case 3320:{f.Push(f.Locals[4]);f.Pc=3322;continue;}
case 3322:{f.Push(JValue.R(rt.String("Prevent all damage that would be dealt by CARDNAME.")));f.Pc=3325;continue;}
case 3325:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3328);}
case 3328:{f.Pc=f.Pop().Int==0?3337:3331;continue;}
case 3331:{f.Push(JValue.I(1));f.Pc=3332;continue;}
case 3332:{f.Locals[6]=f.Pop();f.Pc=3334;continue;}
case 3334:{f.Pc=3351;continue;}
case 3337:{f.Push(f.Locals[4]);f.Pc=3339;continue;}
case 3339:{f.Push(JValue.R(rt.String("Prevent all damage that would be dealt to CARDNAME.")));f.Pc=3342;continue;}
case 3342:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3345);}
case 3345:{f.Pc=f.Pop().Int==0?3351:3348;continue;}
case 3348:{f.Push(JValue.I(1));f.Pc=3349;continue;}
case 3349:{f.Locals[7]=f.Pop();f.Pc=3351;continue;}
case 3351:{f.Push(JValue.R(rt.String("Event$ DamageDone | Prevent$ True")));f.Pc=3354;continue;}
case 3354:{f.Locals[8]=f.Pop();f.Pc=3356;continue;}
case 3356:{f.Push(f.Locals[5]);f.Pc=3358;continue;}
case 3358:{f.Pc=f.Pop().Int==0?3370:3361;continue;}
case 3361:{f.Push(f.Locals[8]);f.Pc=3363;continue;}
case 3363:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:3363:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",3368);}
case 3368:{f.Locals[8]=f.Pop();f.Pc=3370;continue;}
case 3370:{f.Push(f.Locals[8]);f.Pc=3372;continue;}
case 3372:{f.Push(f.Locals[4]);f.Pc=3374;continue;}
case 3374:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:3374:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",3379);}
case 3379:{f.Locals[8]=f.Pop();f.Pc=3381;continue;}
case 3381:{f.Push(f.Locals[6]);f.Pc=3383;continue;}
case 3383:{f.Pc=f.Pop().Int==0?3413:3386;continue;}
case 3386:{f.Push(f.Locals[8]);f.Pc=3388;continue;}
case 3388:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:3388:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",3393);}
case 3393:{f.Locals[9]=f.Pop();f.Pc=3395;continue;}
case 3395:{f.Push(f.Locals[9]);f.Pc=3397;continue;}
case 3397:{f.Push(f.Locals[3]);f.Pc=3398;continue;}
case 3398:{f.Push(f.Locals[2]);f.Pc=3399;continue;}
case 3399:{f.Push(f.Locals[1]);f.Pc=3400;continue;}
case 3400:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",3403);}
case 3403:{f.Locals[10]=f.Pop();f.Pc=3405;continue;}
case 3405:{f.Push(f.Locals[0]);f.Pc=3406;continue;}
case 3406:{f.Push(f.Locals[10]);f.Pc=3408;continue;}
case 3408:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",3413);}
case 3413:{f.Push(f.Locals[7]);f.Pc=3415;continue;}
case 3415:{f.Pc=f.Pop().Int==0?3445:3418;continue;}
case 3418:{f.Push(f.Locals[8]);f.Pc=3420;continue;}
case 3420:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:3420:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",3425);}
case 3425:{f.Locals[9]=f.Pop();f.Pc=3427;continue;}
case 3427:{f.Push(f.Locals[9]);f.Pc=3429;continue;}
case 3429:{f.Push(f.Locals[3]);f.Pc=3430;continue;}
case 3430:{f.Push(f.Locals[2]);f.Pc=3431;continue;}
case 3431:{f.Push(f.Locals[1]);f.Pc=3432;continue;}
case 3432:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",3435);}
case 3435:{f.Locals[10]=f.Pop();f.Pc=3437;continue;}
case 3437:{f.Push(f.Locals[0]);f.Pc=3438;continue;}
case 3438:{f.Push(f.Locals[10]);f.Pc=3440;continue;}
case 3440:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",3445);}
case 3445:{f.Pc=3520;continue;}
case 3448:{f.Push(f.Locals[4]);f.Pc=3450;continue;}
case 3450:{f.Push(JValue.R(rt.String("Protection")));f.Pc=3453;continue;}
case 3453:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3456);}
case 3456:{f.Pc=f.Pop().Int==0?3520:3459;continue;}
case 3459:{f.Push(f.Locals[4]);f.Pc=3461;continue;}
case 3461:{f.Push(JValue.I(1));f.Pc=3462;continue;}
case 3462:{return rt.Call(f,"forge/game/keyword/Protection","getProtectionValid","(Ljava/lang/String;Z)Ljava/lang/String;","invokestatic",3465);}
case 3465:{f.Locals[5]=f.Pop();f.Pc=3467;continue;}
case 3467:{f.Push(JValue.R(rt.String("Event$ DamageDone | Prevent$ True | ActiveZones$ Battlefield | ValidTarget$ Card.Self")));f.Pc=3470;continue;}
case 3470:{f.Locals[6]=f.Pop();f.Pc=3472;continue;}
case 3472:{f.Push(f.Locals[5]);f.Pc=3474;continue;}
case 3474:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",3477);}
case 3477:{f.Pc=f.Pop().Int!=0?3491:3480;continue;}
case 3480:{f.Push(f.Locals[6]);f.Pc=3482;continue;}
case 3482:{f.Push(f.Locals[5]);f.Pc=3484;continue;}
case 3484:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:3484:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",3489);}
case 3489:{f.Locals[6]=f.Pop();f.Pc=3491;continue;}
case 3491:{f.Push(f.Locals[6]);f.Pc=3493;continue;}
case 3493:{f.Push(f.Locals[4]);f.Pc=3495;continue;}
case 3495:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5026:3495:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",3500);}
case 3500:{f.Locals[6]=f.Pop();f.Pc=3502;continue;}
case 3502:{f.Push(f.Locals[6]);f.Pc=3504;continue;}
case 3504:{f.Push(f.Locals[3]);f.Pc=3505;continue;}
case 3505:{f.Push(f.Locals[2]);f.Pc=3506;continue;}
case 3506:{f.Push(f.Locals[1]);f.Pc=3507;continue;}
case 3507:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",3510);}
case 3510:{f.Locals[7]=f.Pop();f.Pc=3512;continue;}
case 3512:{f.Push(f.Locals[0]);f.Pc=3513;continue;}
case 3513:{f.Push(f.Locals[7]);f.Pc=3515;continue;}
case 3515:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",3520);}
case 3520:{f.Push(f.Locals[4]);f.Pc=3522;continue;}
case 3522:{f.Push(JValue.R(rt.String("ETBReplacement")));f.Pc=3525;continue;}
case 3525:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3528);}
case 3528:{f.Pc=f.Pop().Int==0?3651:3531;continue;}
case 3531:{f.Push(f.Locals[4]);f.Pc=3533;continue;}
case 3533:{f.Push(JValue.R(rt.String(":")));f.Pc=3536;continue;}
case 3536:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",3539);}
case 3539:{f.Locals[5]=f.Pop();f.Pc=3541;continue;}
case 3541:{f.Push(f.Locals[5]);f.Pc=3543;continue;}
case 3543:{f.Push(JValue.I(1));f.Pc=3544;continue;}
case 3544:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3545;continue;}
case 3545:{return rt.Call(f,"forge/game/replacement/ReplacementLayer","smartValueOf","(Ljava/lang/String;)Lforge/game/replacement/ReplacementLayer;","invokestatic",3548);}
case 3548:{f.Locals[6]=f.Pop();f.Pc=3550;continue;}
case 3550:{f.Push(f.Locals[5]);f.Pc=3552;continue;}
case 3552:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=3553;continue;}
case 3553:{f.Push(JValue.I(4));f.Pc=3554;continue;}
case 3554:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?3574:3557;continue;}
case 3557:{f.Push(f.Locals[5]);f.Pc=3559;continue;}
case 3559:{f.Push(JValue.I(3));f.Pc=3560;continue;}
case 3560:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3561;continue;}
case 3561:{f.Push(JValue.R(rt.String("Optional")));f.Pc=3564;continue;}
case 3564:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",3567);}
case 3567:{f.Pc=f.Pop().Int==0?3574:3570;continue;}
case 3570:{f.Push(JValue.I(1));f.Pc=3571;continue;}
case 3571:{f.Pc=3575;continue;}
case 3574:{f.Push(JValue.I(0));f.Pc=3575;continue;}
case 3575:{f.Locals[7]=f.Pop();f.Pc=3577;continue;}
case 3577:{f.Push(f.Locals[5]);f.Pc=3579;continue;}
case 3579:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=3580;continue;}
case 3580:{f.Push(JValue.I(6));f.Pc=3582;continue;}
case 3582:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?3592:3585;continue;}
case 3585:{f.Push(f.Locals[5]);f.Pc=3587;continue;}
case 3587:{f.Push(JValue.I(5));f.Pc=3588;continue;}
case 3588:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3589;continue;}
case 3589:{f.Pc=3595;continue;}
case 3592:{f.Push(JValue.R(rt.String("Card.Self")));f.Pc=3595;continue;}
case 3595:{f.Locals[8]=f.Pop();f.Pc=3597;continue;}
case 3597:{f.Push(f.Locals[5]);f.Pc=3599;continue;}
case 3599:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=3600;continue;}
case 3600:{f.Push(JValue.I(5));f.Pc=3601;continue;}
case 3601:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?3611:3604;continue;}
case 3604:{f.Push(f.Locals[5]);f.Pc=3606;continue;}
case 3606:{f.Push(JValue.I(4));f.Pc=3607;continue;}
case 3607:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3608;continue;}
case 3608:{f.Pc=3614;continue;}
case 3611:{f.Push(JValue.R(rt.String("")));f.Pc=3614;continue;}
case 3614:{f.Locals[9]=f.Pop();f.Pc=3616;continue;}
case 3616:{f.Push(f.Locals[1]);f.Pc=3617;continue;}
case 3617:{f.Push(f.Locals[6]);f.Pc=3619;continue;}
case 3619:{f.Push(f.Locals[1]);f.Pc=3620;continue;}
case 3620:{f.Push(f.Locals[5]);f.Pc=3622;continue;}
case 3622:{f.Push(JValue.I(2));f.Pc=3623;continue;}
case 3623:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3624;continue;}
case 3624:{return rt.Call(f,"forge/game/card/CardState","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3627);}
case 3627:{f.Push(f.Locals[7]);f.Pc=3629;continue;}
case 3629:{f.Push(JValue.I(0));f.Pc=3630;continue;}
case 3630:{f.Push(f.Locals[2]);f.Pc=3631;continue;}
case 3631:{f.Push(f.Locals[8]);f.Pc=3633;continue;}
case 3633:{f.Push(f.Locals[9]);f.Pc=3635;continue;}
case 3635:{return rt.Call(f,"forge/game/card/CardFactoryUtil","createETBReplacement","(Lforge/game/card/CardState;Lforge/game/replacement/ReplacementLayer;Ljava/lang/String;ZZZLjava/lang/String;Ljava/lang/String;)Lforge/game/replacement/ReplacementEffect;","invokestatic",3638);}
case 3638:{f.Locals[10]=f.Pop();f.Pc=3640;continue;}
case 3640:{f.Push(f.Locals[0]);f.Pc=3641;continue;}
case 3641:{f.Push(f.Locals[10]);f.Pc=3643;continue;}
case 3643:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",3648);}
case 3648:{f.Pc=3679;continue;}
case 3651:{f.Push(f.Locals[4]);f.Pc=3653;continue;}
case 3653:{f.Push(JValue.R(rt.String("etbCounter")));f.Pc=3656;continue;}
case 3656:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3659);}
case 3659:{f.Pc=f.Pop().Int==0?3679:3662;continue;}
case 3662:{f.Push(f.Locals[4]);f.Pc=3664;continue;}
case 3664:{f.Push(f.Locals[1]);f.Pc=3665;continue;}
case 3665:{f.Push(f.Locals[2]);f.Pc=3666;continue;}
case 3666:{return rt.Call(f,"forge/game/card/CardFactoryUtil","makeEtbCounter","(Ljava/lang/String;Lforge/game/card/CardState;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",3669);}
case 3669:{f.Locals[5]=f.Pop();f.Pc=3671;continue;}
case 3671:{f.Push(f.Locals[0]);f.Pc=3672;continue;}
case 3672:{f.Push(f.Locals[5]);f.Pc=3674;continue;}
case 3674:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",3679);}
case 3679:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5027(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Aftermath")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?62:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",27);}
case 27:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?62:36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",40);}
case 40:{f.Locals[14]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[14]);f.Pc=44;continue;}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAftermath","(Z)V","invokevirtual",48);}
case 48:{f.Push(f.Locals[14]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",53);}
case 53:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",59);}
case 59:{f.Pc=8390;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("Aura swap")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?132:72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String(":")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",79);}
case 79:{f.Locals[14]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[14]);f.Pc=83;continue;}
case 83:{f.Push(JValue.I(1));f.Pc=84;continue;}
case 84:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=85;continue;}
case 85:{f.Locals[15]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[15]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[15]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",94);}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",100);}
case 100:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:100:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",105);}
case 105:{f.Locals[16]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[16]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",113);}
case 113:{f.Locals[17]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[17]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[2]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",121);}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[17]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",129);}
case 129:{f.Pc=8390;continue;}
case 132:{f.Push(f.Locals[3]);f.Pc=133;continue;}
case 133:{f.Push(JValue.R(rt.String("Awaken")));f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",139);}
case 139:{f.Pc=f.Pop().Int==0?269:142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/KeywordWithCostAndAmount")?1:0));f.Pc=146;continue;}
case 146:{f.Pc=f.Pop().Int==0?269:149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordWithCostAndAmount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=153;continue;}
case 153:{f.Locals[5]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",159);}
case 159:{f.Push(f.Locals[5]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndAmount","getCost","()Lforge/game/cost/Cost;","invokevirtual",164);}
case 164:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithDefinedCost","(Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",167);}
case 167:{f.Locals[14]=f.Pop();f.Pc=169;continue;}
case 169:{f.Push(f.Locals[5]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndAmount","getAmount","()I","invokevirtual",174);}
case 174:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:174:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",179);}
case 179:{f.Locals[15]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.String("DB$ Animate | Defined$ ParentTarget | Power$ 0 | Toughness$ 0 | Types$ Creature,Elemental | Duration$ Permanent | Keywords$ Haste")));f.Pc=184;continue;}
case 184:{f.Locals[16]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[15]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[1]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",192);}
case 192:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=195;continue;}
case 195:{f.Locals[17]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.String("DB$ Animate | Defined$ ParentTarget | Power$ 0 | Toughness$ 0 | Types$ Creature,Elemental | Duration$ Permanent | Keywords$ Haste")));f.Pc=200;continue;}
case 200:{f.Push(f.Locals[1]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",204);}
case 204:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=207;continue;}
case 207:{f.Locals[18]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[17]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[18]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",216);}
case 216:{f.Push(f.Locals[14]);f.Pc=218;continue;}
case 218:{f.Push(f.Locals[17]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/spellability/SpellAbility","appendSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",223);}
case 223:{f.Push(f.Locals[14]);f.Pc=225;continue;}
case 225:{f.Push(f.Locals[5]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndAmount","getTitle","()Ljava/lang/String;","invokevirtual",230);}
case 230:{f.Push(f.Locals[0]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",236);}
case 236:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:236:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",241);}
case 241:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",244);}
case 244:{f.Push(f.Locals[14]);f.Pc=246;continue;}
case 246:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Awaken","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Awaken","Lforge/game/spellability/AlternativeCost;"));f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",252);}
case 252:{f.Push(f.Locals[14]);f.Pc=254;continue;}
case 254:{f.Push(f.Locals[2]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",258);}
case 258:{f.Push(f.Locals[0]);f.Pc=259;continue;}
case 259:{f.Push(f.Locals[14]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",266);}
case 266:{f.Pc=8390;continue;}
case 269:{f.Push(f.Locals[3]);f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("Bestow")));f.Pc=273;continue;}
case 273:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",276);}
case 276:{f.Pc=f.Pop().Int==0?694:279;continue;}
case 279:{f.Push(f.Locals[3]);f.Pc=280;continue;}
case 280:{f.Push(JValue.R(rt.String(":")));f.Pc=283;continue;}
case 283:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",286);}
case 286:{f.Locals[14]=f.Pop();f.Pc=288;continue;}
case 288:{f.Push(f.Locals[14]);f.Pc=290;continue;}
case 290:{f.Push(JValue.I(1));f.Pc=291;continue;}
case 291:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=292;continue;}
case 292:{f.Locals[15]=f.Pop();f.Pc=294;continue;}
case 294:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=297;continue;}
case 297:{f.StackOp("dup");f.Pc=298;continue;}
case 298:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",301);}
case 301:{f.Locals[16]=f.Pop();f.Pc=303;continue;}
case 303:{f.Push(f.Locals[16]);f.Pc=305;continue;}
case 305:{f.Push(JValue.R(rt.String("SP$ Attach | ValidTgts$ Creature | Cost$ ")));f.Pc=308;continue;}
case 308:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",311);}
case 311:{f.StackOp("pop");f.Pc=312;continue;}
case 312:{f.Push(f.Locals[16]);f.Pc=314;continue;}
case 314:{f.Push(f.Locals[15]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",319);}
case 319:{f.StackOp("pop");f.Pc=320;continue;}
case 320:{f.Push(f.Locals[16]);f.Pc=322;continue;}
case 322:{f.Push(JValue.R(rt.String(" | AILogic$ ")));f.Pc=325;continue;}
case 325:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",328);}
case 328:{f.Push(f.Locals[14]);f.Pc=330;continue;}
case 330:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=331;continue;}
case 331:{f.Push(JValue.I(2));f.Pc=332;continue;}
case 332:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?342:335;continue;}
case 335:{f.Push(f.Locals[14]);f.Pc=337;continue;}
case 337:{f.Push(JValue.I(2));f.Pc=338;continue;}
case 338:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=339;continue;}
case 339:{f.Pc=345;continue;}
case 342:{f.Push(JValue.R(rt.String("Pump")));f.Pc=345;continue;}
case 345:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",348);}
case 348:{f.StackOp("pop");f.Pc=349;continue;}
case 349:{f.Push(f.Locals[16]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",354);}
case 354:{f.Push(f.Locals[1]);f.Pc=355;continue;}
case 355:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",358);}
case 358:{f.Locals[17]=f.Pop();f.Pc=360;continue;}
case 360:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=363;continue;}
case 363:{f.StackOp("dup");f.Pc=364;continue;}
case 364:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",367);}
case 367:{f.Locals[18]=f.Pop();f.Pc=369;continue;}
case 369:{f.Push(f.Locals[18]);f.Pc=371;continue;}
case 371:{f.Push(JValue.R(rt.String("Bestow")));f.Pc=374;continue;}
case 374:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",377);}
case 377:{f.StackOp("pop");f.Pc=378;continue;}
case 378:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=381;continue;}
case 381:{f.StackOp("dup");f.Pc=382;continue;}
case 382:{f.Push(f.Locals[15]);f.Pc=384;continue;}
case 384:{f.Push(JValue.I(0));f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",388);}
case 388:{f.Locals[19]=f.Pop();f.Pc=390;continue;}
case 390:{f.Push(f.Locals[19]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",395);}
case 395:{f.Locals[20]=f.Pop();f.Pc=397;continue;}
case 397:{f.Push(f.Locals[0]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",403);}
case 403:{f.Locals[21]=f.Pop();f.Pc=405;continue;}
case 405:{f.Push(f.Locals[20]);f.Pc=407;continue;}
case 407:{f.Pc=f.Pop().Int!=0?580:410;continue;}
case 410:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=413;continue;}
case 413:{f.StackOp("dup");f.Pc=414;continue;}
case 414:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",417);}
case 417:{f.Locals[22]=f.Pop();f.Pc=419;continue;}
case 419:{f.Push(f.Locals[22]);f.Pc=421;continue;}
case 421:{f.Push(JValue.R(rt.String("To pay this bestow cost, ")));f.Pc=424;continue;}
case 424:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",427);}
case 427:{f.StackOp("pop");f.Pc=428;continue;}
case 428:{f.Push(JValue.I(0));f.Pc=429;continue;}
case 429:{f.Locals[23]=f.Pop();f.Pc=431;continue;}
case 431:{f.Push(f.Locals[19]);f.Pc=433;continue;}
case 433:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",436);}
case 436:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",441);}
case 441:{f.Locals[24]=f.Pop();f.Pc=443;continue;}
case 443:{f.Push(f.Locals[24]);f.Pc=445;continue;}
case 445:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",450);}
case 450:{f.Pc=f.Pop().Int==0?573:453;continue;}
case 453:{f.Push(f.Locals[24]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",460);}
case 460:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=463;continue;}
case 463:{f.Locals[25]=f.Pop();f.Pc=465;continue;}
case 465:{f.Push(f.Locals[25]);f.Pc=467;continue;}
case 467:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartMana")?1:0));f.Pc=470;continue;}
case 470:{f.Pc=f.Pop().Int==0?490:473;continue;}
case 473:{f.Push(f.Locals[22]);f.Pc=475;continue;}
case 475:{f.Push(JValue.R(rt.String("pay ")));f.Pc=478;continue;}
case 478:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",481);}
case 481:{f.Push(f.Locals[25]);f.Pc=483;continue;}
case 483:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",486);}
case 486:{f.StackOp("pop");f.Pc=487;continue;}
case 487:{f.Pc=535;continue;}
case 490:{f.Push(f.Locals[25]);f.Pc=492;continue;}
case 492:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostCollectEvidence")?1:0));f.Pc=495;continue;}
case 495:{f.Pc=f.Pop().Int==0?527:498;continue;}
case 498:{f.Push(f.Locals[22]);f.Pc=500;continue;}
case 500:{f.Push(JValue.R(rt.String("exile cards with total mana value ")));f.Pc=503;continue;}
case 503:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",506);}
case 506:{f.Push(f.Locals[25]);f.Pc=508;continue;}
case 508:{return rt.Call(f,"forge/game/cost/CostPart","getAmount","()Ljava/lang/String;","invokevirtual",511);}
case 511:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",514);}
case 514:{f.StackOp("pop");f.Pc=515;continue;}
case 515:{f.Push(f.Locals[22]);f.Pc=517;continue;}
case 517:{f.Push(JValue.R(rt.String(" or greater from your graveyard")));f.Pc=520;continue;}
case 520:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",523);}
case 523:{f.StackOp("pop");f.Pc=524;continue;}
case 524:{f.Pc=535;continue;}
case 527:{f.Push(f.Locals[22]);f.Pc=529;continue;}
case 529:{f.Push(f.Locals[25]);f.Pc=531;continue;}
case 531:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",534);}
case 534:{f.StackOp("pop");f.Pc=535;continue;}
case 535:{f.Push(f.Locals[22]);f.Pc=537;continue;}
case 537:{f.Push(f.Locals[23]);f.Pc=539;continue;}
case 539:{f.Push(JValue.I(1));f.Pc=540;continue;}
case 540:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=541;continue;}
case 541:{f.Push(f.Locals[19]);f.Pc=543;continue;}
case 543:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",546);}
case 546:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",551);}
case 551:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?560:554;continue;}
case 554:{f.Push(JValue.R(rt.String(".")));f.Pc=557;continue;}
case 557:{f.Pc=563;continue;}
case 560:{f.Push(JValue.R(rt.String(" and ")));f.Pc=563;continue;}
case 563:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",566);}
case 566:{f.StackOp("pop");f.Pc=567;continue;}
case 567:{f.Locals[23]=JValue.I(unchecked(f.Locals[23].Int+(1)));f.Pc=570;continue;}
case 570:{f.Pc=443;continue;}
case 573:{f.Push(f.Locals[22]);f.Pc=575;continue;}
case 575:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",578);}
case 578:{f.Locals[21]=f.Pop();f.Pc=580;continue;}
case 580:{f.Push(f.Locals[18]);f.Pc=582;continue;}
case 582:{f.Push(f.Locals[20]);f.Pc=584;continue;}
case 584:{f.Pc=f.Pop().Int==0?593:587;continue;}
case 587:{f.Push(JValue.R(rt.String(" ")));f.Pc=590;continue;}
case 590:{f.Pc=596;continue;}
case 593:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=596;continue;}
case 596:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",599);}
case 599:{f.Push(f.Locals[19]);f.Pc=601;continue;}
case 601:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",604);}
case 604:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",607);}
case 607:{f.Push(f.Locals[20]);f.Pc=609;continue;}
case 609:{f.Pc=f.Pop().Int!=0?618:612;continue;}
case 612:{f.Push(JValue.R(rt.String(".")));f.Pc=615;continue;}
case 615:{f.Pc=621;continue;}
case 618:{f.Push(JValue.R(rt.String("")));f.Pc=621;continue;}
case 621:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",624);}
case 624:{f.StackOp("pop");f.Pc=625;continue;}
case 625:{f.Push(f.Locals[18]);f.Pc=627;continue;}
case 627:{f.Push(JValue.R(rt.String(" (")));f.Pc=630;continue;}
case 630:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",633);}
case 633:{f.Push(f.Locals[21]);f.Pc=635;continue;}
case 635:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",638);}
case 638:{f.Push(JValue.R(rt.String(")")));f.Pc=641;continue;}
case 641:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",644);}
case 644:{f.StackOp("pop");f.Pc=645;continue;}
case 645:{f.Push(f.Locals[17]);f.Pc=647;continue;}
case 647:{f.Push(f.Locals[18]);f.Pc=649;continue;}
case 649:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",652);}
case 652:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",655);}
case 655:{f.Push(f.Locals[17]);f.Pc=657;continue;}
case 657:{f.Push(f.Locals[1]);f.Pc=658;continue;}
case 658:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",661);}
case 661:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:661:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",666);}
case 666:{return rt.Call(f,"forge/game/spellability/SpellAbility","setStackDescription","(Ljava/lang/String;)V","invokevirtual",669);}
case 669:{f.Push(f.Locals[17]);f.Pc=671;continue;}
case 671:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Bestow","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Bestow","Lforge/game/spellability/AlternativeCost;"));f.Pc=674;continue;}
case 674:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",677);}
case 677:{f.Push(f.Locals[17]);f.Pc=679;continue;}
case 679:{f.Push(f.Locals[2]);f.Pc=680;continue;}
case 680:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",683);}
case 683:{f.Push(f.Locals[0]);f.Pc=684;continue;}
case 684:{f.Push(f.Locals[17]);f.Pc=686;continue;}
case 686:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",691);}
case 691:{f.Pc=8390;continue;}
case 694:{f.Push(f.Locals[3]);f.Pc=695;continue;}
case 695:{f.Push(JValue.R(rt.String("Blitz")));f.Pc=698;continue;}
case 698:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",701);}
case 701:{f.Pc=f.Pop().Int==0?891:704;continue;}
case 704:{f.Push(f.Locals[3]);f.Pc=705;continue;}
case 705:{f.Push(JValue.R(rt.String(":")));f.Pc=708;continue;}
case 708:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",711);}
case 711:{f.Locals[14]=f.Pop();f.Pc=713;continue;}
case 713:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=716;continue;}
case 716:{f.StackOp("dup");f.Pc=717;continue;}
case 717:{f.Push(f.Locals[14]);f.Pc=719;continue;}
case 719:{f.Push(JValue.I(1));f.Pc=720;continue;}
case 720:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=721;continue;}
case 721:{f.Push(JValue.I(0));f.Pc=722;continue;}
case 722:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",725);}
case 725:{f.Locals[15]=f.Pop();f.Pc=727;continue;}
case 727:{f.Push(f.Locals[1]);f.Pc=728;continue;}
case 728:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbilityWithFallback","()Lforge/game/spellability/SpellAbility;","invokevirtual",731);}
case 731:{f.Push(f.Locals[4]);f.Pc=733;continue;}
case 733:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",736);}
case 736:{f.Push(f.Locals[15]);f.Pc=738;continue;}
case 738:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithManaCostReplaced","(Lforge/game/player/Player;Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",741);}
case 741:{f.Locals[16]=f.Pop();f.Pc=743;continue;}
case 743:{f.Push(f.Locals[14]);f.Pc=745;continue;}
case 745:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=746;continue;}
case 746:{f.Push(JValue.I(2));f.Pc=747;continue;}
case 747:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?768:750;continue;}
case 750:{f.Push(f.Locals[16]);f.Pc=752;continue;}
case 752:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",755);}
case 755:{f.Push(JValue.R(rt.String("ValidAfterStack")));f.Pc=758;continue;}
case 758:{f.Push(f.Locals[14]);f.Pc=760;continue;}
case 760:{f.Push(JValue.I(2));f.Pc=761;continue;}
case 761:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=762;continue;}
case 762:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",767);}
case 767:{f.StackOp("pop");f.Pc=768;continue;}
case 768:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=771;continue;}
case 771:{f.StackOp("dup");f.Pc=772;continue;}
case 772:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",775);}
case 775:{f.Locals[17]=f.Pop();f.Pc=777;continue;}
case 777:{f.Push(f.Locals[17]);f.Pc=779;continue;}
case 779:{f.Push(JValue.R(rt.String("Blitz ")));f.Pc=782;continue;}
case 782:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",785);}
case 785:{f.Push(f.Locals[15]);f.Pc=787;continue;}
case 787:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",790);}
case 790:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",793);}
case 793:{f.Push(JValue.R(rt.String(" (")));f.Pc=796;continue;}
case 796:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",799);}
case 799:{f.StackOp("pop");f.Pc=800;continue;}
case 800:{f.Push(f.Locals[17]);f.Pc=802;continue;}
case 802:{f.Push(f.Locals[0]);f.Pc=803;continue;}
case 803:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",808);}
case 808:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",811);}
case 811:{f.StackOp("pop");f.Pc=812;continue;}
case 812:{f.Push(f.Locals[17]);f.Pc=814;continue;}
case 814:{f.Push(JValue.R(rt.String(")")));f.Pc=817;continue;}
case 817:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",820);}
case 820:{f.StackOp("pop");f.Pc=821;continue;}
case 821:{f.Push(f.Locals[16]);f.Pc=823;continue;}
case 823:{f.Push(f.Locals[17]);f.Pc=825;continue;}
case 825:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",828);}
case 828:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",831);}
case 831:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=834;continue;}
case 834:{f.StackOp("dup");f.Pc=835;continue;}
case 835:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",838);}
case 838:{f.Locals[18]=f.Pop();f.Pc=840;continue;}
case 840:{f.Push(f.Locals[18]);f.Pc=842;continue;}
case 842:{f.Push(f.Locals[1]);f.Pc=843;continue;}
case 843:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",846);}
case 846:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",849);}
case 849:{f.Push(JValue.R(rt.String(" (Blitz)")));f.Pc=852;continue;}
case 852:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",855);}
case 855:{f.StackOp("pop");f.Pc=856;continue;}
case 856:{f.Push(f.Locals[16]);f.Pc=858;continue;}
case 858:{f.Push(f.Locals[18]);f.Pc=860;continue;}
case 860:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",863);}
case 863:{return rt.Call(f,"forge/game/spellability/SpellAbility","setStackDescription","(Ljava/lang/String;)V","invokevirtual",866);}
case 866:{f.Push(f.Locals[16]);f.Pc=868;continue;}
case 868:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Blitz","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Blitz","Lforge/game/spellability/AlternativeCost;"));f.Pc=871;continue;}
case 871:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",874);}
case 874:{f.Push(f.Locals[16]);f.Pc=876;continue;}
case 876:{f.Push(f.Locals[2]);f.Pc=877;continue;}
case 877:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",880);}
case 880:{f.Push(f.Locals[0]);f.Pc=881;continue;}
case 881:{f.Push(f.Locals[16]);f.Pc=883;continue;}
case 883:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",888);}
case 888:{f.Pc=8390;continue;}
case 891:{f.Push(f.Locals[3]);f.Pc=892;continue;}
case 892:{f.Push(JValue.R(rt.String("Cipher")));f.Pc=895;continue;}
case 895:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",898);}
case 898:{f.Pc=f.Pop().Int==0?933:901;continue;}
case 901:{f.Push(JValue.R(rt.String("DB$ Encode")));f.Pc=904;continue;}
case 904:{f.Locals[14]=f.Pop();f.Pc=906;continue;}
case 906:{f.Push(f.Locals[14]);f.Pc=908;continue;}
case 908:{f.Push(f.Locals[1]);f.Pc=909;continue;}
case 909:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",912);}
case 912:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=915;continue;}
case 915:{f.Locals[15]=f.Pop();f.Pc=917;continue;}
case 917:{f.Push(f.Locals[1]);f.Pc=918;continue;}
case 918:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",921);}
case 921:{f.Locals[16]=f.Pop();f.Pc=923;continue;}
case 923:{f.Push(f.Locals[16]);f.Pc=925;continue;}
case 925:{f.Push(f.Locals[15]);f.Pc=927;continue;}
case 927:{return rt.Call(f,"forge/game/spellability/SpellAbility","appendSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",930);}
case 930:{f.Pc=8390;continue;}
case 933:{f.Push(f.Locals[3]);f.Pc=934;continue;}
case 934:{f.Push(JValue.R(rt.String("Class")));f.Pc=937;continue;}
case 937:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",940);}
case 940:{f.Pc=f.Pop().Int==0?1053:943;continue;}
case 943:{f.Push(f.Locals[3]);f.Pc=944;continue;}
case 944:{f.Push(JValue.R(rt.String(":")));f.Pc=947;continue;}
case 947:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",950);}
case 950:{f.Locals[14]=f.Pop();f.Pc=952;continue;}
case 952:{f.Push(f.Locals[14]);f.Pc=954;continue;}
case 954:{f.Push(JValue.I(1));f.Pc=955;continue;}
case 955:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=956;continue;}
case 956:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",959);}
case 959:{f.Locals[15]=f.Pop();f.Pc=961;continue;}
case 961:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=964;continue;}
case 964:{f.StackOp("dup");f.Pc=965;continue;}
case 965:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",968);}
case 968:{f.Locals[16]=f.Pop();f.Pc=970;continue;}
case 970:{f.Push(f.Locals[16]);f.Pc=972;continue;}
case 972:{f.Push(JValue.R(rt.String("AB$ ClassLevelUp | Cost$ ")));f.Pc=975;continue;}
case 975:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",978);}
case 978:{f.Push(f.Locals[14]);f.Pc=980;continue;}
case 980:{f.Push(JValue.I(2));f.Pc=981;continue;}
case 981:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=982;continue;}
case 982:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",985);}
case 985:{f.StackOp("pop");f.Pc=986;continue;}
case 986:{f.Push(f.Locals[16]);f.Pc=988;continue;}
case 988:{f.Push(JValue.R(rt.String(" | ClassLevel$ EQ")));f.Pc=991;continue;}
case 991:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",994);}
case 994:{f.Push(f.Locals[15]);f.Pc=996;continue;}
case 996:{f.Push(JValue.I(1));f.Pc=997;continue;}
case 997:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=998;continue;}
case 998:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",1001);}
case 1001:{f.StackOp("pop");f.Pc=1002;continue;}
case 1002:{f.Push(f.Locals[16]);f.Pc=1004;continue;}
case 1004:{f.Push(JValue.R(rt.String(" | SorcerySpeed$ True")));f.Pc=1007;continue;}
case 1007:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1010);}
case 1010:{f.StackOp("pop");f.Pc=1011;continue;}
case 1011:{f.Push(f.Locals[16]);f.Pc=1013;continue;}
case 1013:{f.Push(JValue.R(rt.String(" | StackDescription$ SpellDescription | SpellDescription$ Level ")));f.Pc=1016;continue;}
case 1016:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1019);}
case 1019:{f.Push(f.Locals[15]);f.Pc=1021;continue;}
case 1021:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",1024);}
case 1024:{f.StackOp("pop");f.Pc=1025;continue;}
case 1025:{f.Push(f.Locals[16]);f.Pc=1027;continue;}
case 1027:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1030);}
case 1030:{f.Push(f.Locals[1]);f.Pc=1031;continue;}
case 1031:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",1034);}
case 1034:{f.Locals[17]=f.Pop();f.Pc=1036;continue;}
case 1036:{f.Push(f.Locals[17]);f.Pc=1038;continue;}
case 1038:{f.Push(f.Locals[2]);f.Pc=1039;continue;}
case 1039:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",1042);}
case 1042:{f.Push(f.Locals[0]);f.Pc=1043;continue;}
case 1043:{f.Push(f.Locals[17]);f.Pc=1045;continue;}
case 1045:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",1050);}
case 1050:{f.Pc=8390;continue;}
case 1053:{f.Push(f.Locals[0]);f.Pc=1054;continue;}
case 1054:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/Craft")?1:0));f.Pc=1057;continue;}
case 1057:{f.Pc=f.Pop().Int==0?1127:1060;continue;}
case 1060:{f.Push(f.Locals[0]);f.Pc=1061;continue;}
case 1061:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/Craft"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1064;continue;}
case 1064:{f.Locals[6]=f.Pop();f.Pc=1066;continue;}
case 1066:{f.Push(f.Locals[6]);f.Pc=1068;continue;}
case 1068:{return rt.Call(f,"forge/game/keyword/Craft","getTitle","()Ljava/lang/String;","invokevirtual",1071);}
case 1071:{f.Push(f.Locals[6]);f.Pc=1073;continue;}
case 1073:{return rt.Call(f,"forge/game/keyword/Craft","getCostString","()Ljava/lang/String;","invokevirtual",1076);}
case 1076:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1079);}
case 1079:{f.Push(JValue.R(rt.String("lblCraft")));f.Pc=1082;continue;}
case 1082:{f.Push(JValue.I(0));f.Pc=1083;continue;}
case 1083:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1086;continue;}
case 1086:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1089);}
case 1089:{f.Push(f.Locals[0]);f.Pc=1090;continue;}
case 1090:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1095);}
case 1095:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:1095:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1100);}
case 1100:{f.Locals[14]=f.Pop();f.Pc=1102;continue;}
case 1102:{f.Push(f.Locals[14]);f.Pc=1104;continue;}
case 1104:{f.Push(f.Locals[1]);f.Pc=1105;continue;}
case 1105:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",1108);}
case 1108:{f.Locals[15]=f.Pop();f.Pc=1110;continue;}
case 1110:{f.Push(f.Locals[15]);f.Pc=1112;continue;}
case 1112:{f.Push(f.Locals[2]);f.Pc=1113;continue;}
case 1113:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",1116);}
case 1116:{f.Push(f.Locals[0]);f.Pc=1117;continue;}
case 1117:{f.Push(f.Locals[15]);f.Pc=1119;continue;}
case 1119:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",1124);}
case 1124:{f.Pc=8390;continue;}
case 1127:{f.Push(f.Locals[3]);f.Pc=1128;continue;}
case 1128:{f.Push(JValue.R(rt.String("Dash")));f.Pc=1131;continue;}
case 1131:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1134);}
case 1134:{f.Pc=f.Pop().Int==0?1294:1137;continue;}
case 1137:{f.Push(f.Locals[3]);f.Pc=1138;continue;}
case 1138:{f.Push(JValue.R(rt.String(":")));f.Pc=1141;continue;}
case 1141:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1144);}
case 1144:{f.Locals[14]=f.Pop();f.Pc=1146;continue;}
case 1146:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=1149;continue;}
case 1149:{f.StackOp("dup");f.Pc=1150;continue;}
case 1150:{f.Push(f.Locals[14]);f.Pc=1152;continue;}
case 1152:{f.Push(JValue.I(1));f.Pc=1153;continue;}
case 1153:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1154;continue;}
case 1154:{f.Push(JValue.I(0));f.Pc=1155;continue;}
case 1155:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",1158);}
case 1158:{f.Locals[15]=f.Pop();f.Pc=1160;continue;}
case 1160:{f.Push(f.Locals[1]);f.Pc=1161;continue;}
case 1161:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1164);}
case 1164:{f.Push(f.Locals[15]);f.Pc=1166;continue;}
case 1166:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithDefinedCost","(Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",1169);}
case 1169:{f.Locals[16]=f.Pop();f.Pc=1171;continue;}
case 1171:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1174;continue;}
case 1174:{f.StackOp("dup");f.Pc=1175;continue;}
case 1175:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",1178);}
case 1178:{f.Locals[17]=f.Pop();f.Pc=1180;continue;}
case 1180:{f.Push(f.Locals[17]);f.Pc=1182;continue;}
case 1182:{f.Push(JValue.R(rt.String("Dash ")));f.Pc=1185;continue;}
case 1185:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1188);}
case 1188:{f.Push(f.Locals[15]);f.Pc=1190;continue;}
case 1190:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",1193);}
case 1193:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1196);}
case 1196:{f.Push(JValue.R(rt.String(" (")));f.Pc=1199;continue;}
case 1199:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1202);}
case 1202:{f.StackOp("pop");f.Pc=1203;continue;}
case 1203:{f.Push(f.Locals[17]);f.Pc=1205;continue;}
case 1205:{f.Push(f.Locals[0]);f.Pc=1206;continue;}
case 1206:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1211);}
case 1211:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1214);}
case 1214:{f.StackOp("pop");f.Pc=1215;continue;}
case 1215:{f.Push(f.Locals[17]);f.Pc=1217;continue;}
case 1217:{f.Push(JValue.R(rt.String(")")));f.Pc=1220;continue;}
case 1220:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1223);}
case 1223:{f.StackOp("pop");f.Pc=1224;continue;}
case 1224:{f.Push(f.Locals[16]);f.Pc=1226;continue;}
case 1226:{f.Push(f.Locals[17]);f.Pc=1228;continue;}
case 1228:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1231);}
case 1231:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",1234);}
case 1234:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1237;continue;}
case 1237:{f.StackOp("dup");f.Pc=1238;continue;}
case 1238:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",1241);}
case 1241:{f.Locals[18]=f.Pop();f.Pc=1243;continue;}
case 1243:{f.Push(f.Locals[18]);f.Pc=1245;continue;}
case 1245:{f.Push(f.Locals[1]);f.Pc=1246;continue;}
case 1246:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",1249);}
case 1249:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1252);}
case 1252:{f.Push(JValue.R(rt.String(" (Dash)")));f.Pc=1255;continue;}
case 1255:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1258);}
case 1258:{f.StackOp("pop");f.Pc=1259;continue;}
case 1259:{f.Push(f.Locals[16]);f.Pc=1261;continue;}
case 1261:{f.Push(f.Locals[18]);f.Pc=1263;continue;}
case 1263:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1266);}
case 1266:{return rt.Call(f,"forge/game/spellability/SpellAbility","setStackDescription","(Ljava/lang/String;)V","invokevirtual",1269);}
case 1269:{f.Push(f.Locals[16]);f.Pc=1271;continue;}
case 1271:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Dash","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Dash","Lforge/game/spellability/AlternativeCost;"));f.Pc=1274;continue;}
case 1274:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",1277);}
case 1277:{f.Push(f.Locals[16]);f.Pc=1279;continue;}
case 1279:{f.Push(f.Locals[2]);f.Pc=1280;continue;}
case 1280:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",1283);}
case 1283:{f.Push(f.Locals[0]);f.Pc=1284;continue;}
case 1284:{f.Push(f.Locals[16]);f.Pc=1286;continue;}
case 1286:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",1291);}
case 1291:{f.Pc=8390;continue;}
case 1294:{f.Push(f.Locals[3]);f.Pc=1295;continue;}
case 1295:{f.Push(JValue.R(rt.String("Disguise")));f.Pc=1298;continue;}
case 1298:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1301);}
case 1301:{f.Pc=f.Pop().Int==0?1439:1304;continue;}
case 1304:{f.Push(f.Locals[0]);f.Pc=1305;continue;}
case 1305:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/KeywordWithCost")?1:0));f.Pc=1308;continue;}
case 1308:{f.Pc=f.Pop().Int==0?1439:1311;continue;}
case 1311:{f.Push(f.Locals[0]);f.Pc=1312;continue;}
case 1312:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordWithCost"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1315;continue;}
case 1315:{f.Locals[7]=f.Pop();f.Pc=1317;continue;}
case 1317:{f.Push(f.Locals[3]);f.Pc=1318;continue;}
case 1318:{f.Push(JValue.R(rt.String(":")));f.Pc=1321;continue;}
case 1321:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1324);}
case 1324:{f.Locals[14]=f.Pop();f.Pc=1326;continue;}
case 1326:{f.Push(f.Locals[14]);f.Pc=1328;continue;}
case 1328:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1329;continue;}
case 1329:{f.Push(JValue.I(2));f.Pc=1330;continue;}
case 1330:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1340:1333;continue;}
case 1333:{f.Push(f.Locals[14]);f.Pc=1335;continue;}
case 1335:{f.Push(JValue.I(2));f.Pc=1336;continue;}
case 1336:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1337;continue;}
case 1337:{f.Pc=1341;continue;}
case 1340:{f.Push(JValue.R(null));f.Pc=1341;continue;}
case 1341:{f.Locals[15]=f.Pop();f.Pc=1343;continue;}
case 1343:{f.Push(f.Locals[1]);f.Pc=1344;continue;}
case 1344:{f.Push(f.Locals[2]);f.Pc=1345;continue;}
case 1345:{f.Push(JValue.R(rt.String("Disguise")));f.Pc=1348;continue;}
case 1348:{return rt.Call(f,"forge/game/card/CardFactoryUtil","abilityCastFaceDown","(Lforge/game/card/CardState;ZLjava/lang/String;)Lforge/game/spellability/SpellAbility;","invokestatic",1351);}
case 1351:{f.Locals[16]=f.Pop();f.Pc=1353;continue;}
case 1353:{f.Push(f.Locals[16]);f.Pc=1355;continue;}
case 1355:{f.Push(JValue.R(rt.String("FaceDownKeyword")));f.Pc=1358;continue;}
case 1358:{f.Push(JValue.R(rt.String("Ward:2")));f.Pc=1361;continue;}
case 1361:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1364);}
case 1364:{f.StackOp("pop");f.Pc=1365;continue;}
case 1365:{f.Push(f.Locals[1]);f.Pc=1366;continue;}
case 1366:{f.Push(f.Locals[7]);f.Pc=1368;continue;}
case 1368:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","getCost","()Lforge/game/cost/Cost;","invokevirtual",1371);}
case 1371:{f.Push(JValue.R(rt.String("DisguiseUp")));f.Pc=1374;continue;}
case 1374:{f.Push(JValue.R(rt.String("Disguise")));f.Pc=1377;continue;}
case 1377:{f.Push(JValue.R(rt.String("disguise")));f.Pc=1380;continue;}
case 1380:{return rt.Call(f,"forge/game/card/CardFactoryUtil","abilityTurnFaceUp","(Lforge/game/card/CardState;Lforge/game/cost/Cost;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokestatic",1383);}
case 1383:{f.Locals[17]=f.Pop();f.Pc=1385;continue;}
case 1385:{f.Push(f.Locals[17]);f.Pc=1387;continue;}
case 1387:{f.Push(f.Locals[2]);f.Pc=1388;continue;}
case 1388:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",1391);}
case 1391:{f.Push(f.Locals[15]);f.Pc=1393;continue;}
case 1393:{f.Pc=f.Pop().Reference==null?1420:1396;continue;}
case 1396:{f.Push(f.Locals[17]);f.Pc=1398;continue;}
case 1398:{f.Push(JValue.R(rt.String("ReduceCost")));f.Pc=1401;continue;}
case 1401:{f.Push(f.Locals[15]);f.Pc=1403;continue;}
case 1403:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1406);}
case 1406:{f.StackOp("pop");f.Pc=1407;continue;}
case 1407:{f.Push(f.Locals[17]);f.Pc=1409;continue;}
case 1409:{f.Push(f.Locals[15]);f.Pc=1411;continue;}
case 1411:{f.Push(f.Locals[1]);f.Pc=1412;continue;}
case 1412:{f.Push(f.Locals[15]);f.Pc=1414;continue;}
case 1414:{return rt.Call(f,"forge/game/card/CardState","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1417);}
case 1417:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1420);}
case 1420:{f.Push(f.Locals[0]);f.Pc=1421;continue;}
case 1421:{f.Push(f.Locals[16]);f.Pc=1423;continue;}
case 1423:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",1428);}
case 1428:{f.Push(f.Locals[0]);f.Pc=1429;continue;}
case 1429:{f.Push(f.Locals[17]);f.Pc=1431;continue;}
case 1431:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",1436);}
case 1436:{f.Pc=8390;continue;}
case 1439:{f.Push(f.Locals[3]);f.Pc=1440;continue;}
case 1440:{f.Push(JValue.R(rt.String("Disturb")));f.Pc=1443;continue;}
case 1443:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1446);}
case 1446:{f.Pc=f.Pop().Int==0?1668:1449;continue;}
case 1449:{f.Push(f.Locals[3]);f.Pc=1450;continue;}
case 1450:{f.Push(JValue.R(rt.String(":")));f.Pc=1453;continue;}
case 1453:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1456);}
case 1456:{f.Locals[14]=f.Pop();f.Pc=1458;continue;}
case 1458:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=1461;continue;}
case 1461:{f.StackOp("dup");f.Pc=1462;continue;}
case 1462:{f.Push(f.Locals[14]);f.Pc=1464;continue;}
case 1464:{f.Push(JValue.I(1));f.Pc=1465;continue;}
case 1465:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1466;continue;}
case 1466:{f.Push(JValue.I(1));f.Pc=1467;continue;}
case 1467:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",1470);}
case 1470:{f.Locals[15]=f.Pop();f.Pc=1472;continue;}
case 1472:{f.Push(f.Locals[4]);f.Pc=1474;continue;}
case 1474:{return rt.Call(f,"forge/game/card/Card","getAlternateState","()Lforge/game/card/CardState;","invokevirtual",1477);}
case 1477:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbilityWithFallback","()Lforge/game/spellability/SpellAbility;","invokevirtual",1480);}
case 1480:{f.Push(f.Locals[15]);f.Pc=1482;continue;}
case 1482:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithDefinedCost","(Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",1485);}
case 1485:{f.Locals[16]=f.Pop();f.Pc=1487;continue;}
case 1487:{f.Push(f.Locals[16]);f.Pc=1489;continue;}
case 1489:{f.Push(f.Locals[4]);f.Pc=1491;continue;}
case 1491:{return rt.Call(f,"forge/game/card/Card","getAlternateState","()Lforge/game/card/CardState;","invokevirtual",1494);}
case 1494:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",1497);}
case 1497:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1500;continue;}
case 1500:{f.StackOp("dup");f.Pc=1501;continue;}
case 1501:{f.Push(JValue.R(rt.String("Disturb")));f.Pc=1504;continue;}
case 1504:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",1507);}
case 1507:{f.Locals[17]=f.Pop();f.Pc=1509;continue;}
case 1509:{f.Push(f.Locals[15]);f.Pc=1511;continue;}
case 1511:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",1514);}
case 1514:{f.Pc=f.Pop().Int!=0?1529:1517;continue;}
case 1517:{f.Push(f.Locals[17]);f.Pc=1519;continue;}
case 1519:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=1522;continue;}
case 1522:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1525);}
case 1525:{f.StackOp("pop");f.Pc=1526;continue;}
case 1526:{f.Pc=1538;continue;}
case 1529:{f.Push(f.Locals[17]);f.Pc=1531;continue;}
case 1531:{f.Push(JValue.R(rt.String(" ")));f.Pc=1534;continue;}
case 1534:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1537);}
case 1537:{f.StackOp("pop");f.Pc=1538;continue;}
case 1538:{f.Push(f.Locals[16]);f.Pc=1540;continue;}
case 1540:{f.Push(JValue.R(rt.String("PrecostDesc")));f.Pc=1543;continue;}
case 1543:{f.Push(f.Locals[17]);f.Pc=1545;continue;}
case 1545:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1548);}
case 1548:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1551);}
case 1551:{f.StackOp("pop");f.Pc=1552;continue;}
case 1552:{f.Push(f.Locals[16]);f.Pc=1554;continue;}
case 1554:{f.Push(JValue.R(rt.String("CostDesc")));f.Pc=1557;continue;}
case 1557:{f.Push(f.Locals[15]);f.Pc=1559;continue;}
case 1559:{return rt.Call(f,"forge/game/cost/Cost","toString","()Ljava/lang/String;","invokevirtual",1562);}
case 1562:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1565);}
case 1565:{f.StackOp("pop");f.Pc=1566;continue;}
case 1566:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1569;continue;}
case 1569:{f.StackOp("dup");f.Pc=1570;continue;}
case 1570:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",1573);}
case 1573:{f.Locals[18]=f.Pop();f.Pc=1575;continue;}
case 1575:{f.Push(f.Locals[18]);f.Pc=1577;continue;}
case 1577:{f.Push(f.Locals[16]);f.Pc=1579;continue;}
case 1579:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCostDescription","()Ljava/lang/String;","invokevirtual",1582);}
case 1582:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1585);}
case 1585:{f.StackOp("pop");f.Pc=1586;continue;}
case 1586:{f.Push(f.Locals[18]);f.Pc=1588;continue;}
case 1588:{f.Push(JValue.R(rt.String("(")));f.Pc=1591;continue;}
case 1591:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1594);}
case 1594:{f.Push(f.Locals[0]);f.Pc=1595;continue;}
case 1595:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1600);}
case 1600:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1603);}
case 1603:{f.Push(JValue.R(rt.String(")")));f.Pc=1606;continue;}
case 1606:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1609);}
case 1609:{f.StackOp("pop");f.Pc=1610;continue;}
case 1610:{f.Push(f.Locals[16]);f.Pc=1612;continue;}
case 1612:{f.Push(f.Locals[18]);f.Pc=1614;continue;}
case 1614:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1617);}
case 1617:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",1620);}
case 1620:{f.Push(f.Locals[16]);f.Pc=1622;continue;}
case 1622:{f.Push(JValue.R(rt.String("AfterDescription")));f.Pc=1625;continue;}
case 1625:{f.Push(JValue.R(rt.String("(Disturbed)")));f.Pc=1628;continue;}
case 1628:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1631);}
case 1631:{f.StackOp("pop");f.Pc=1632;continue;}
case 1632:{f.Push(f.Locals[16]);f.Pc=1634;continue;}
case 1634:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Disturb","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Disturb","Lforge/game/spellability/AlternativeCost;"));f.Pc=1637;continue;}
case 1637:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",1640);}
case 1640:{f.Push(f.Locals[16]);f.Pc=1642;continue;}
case 1642:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",1645);}
case 1645:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=1648;continue;}
case 1648:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",1651);}
case 1651:{f.Push(f.Locals[16]);f.Pc=1653;continue;}
case 1653:{f.Push(f.Locals[2]);f.Pc=1654;continue;}
case 1654:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",1657);}
case 1657:{f.Push(f.Locals[0]);f.Pc=1658;continue;}
case 1658:{f.Push(f.Locals[16]);f.Pc=1660;continue;}
case 1660:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",1665);}
case 1665:{f.Pc=8390;continue;}
case 1668:{f.Push(f.Locals[0]);f.Pc=1669;continue;}
case 1669:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/Emerge")?1:0));f.Pc=1672;continue;}
case 1672:{f.Pc=f.Pop().Int==0?1794:1675;continue;}
case 1675:{f.Push(f.Locals[0]);f.Pc=1676;continue;}
case 1676:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/Emerge"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1679;continue;}
case 1679:{f.Locals[8]=f.Pop();f.Pc=1681;continue;}
case 1681:{f.Push(f.Locals[8]);f.Pc=1683;continue;}
case 1683:{return rt.Call(f,"forge/game/keyword/Emerge","getTitleWithoutCost","()Ljava/lang/String;","invokevirtual",1686);}
case 1686:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:1686:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1691);}
case 1691:{f.Locals[14]=f.Pop();f.Pc=1693;continue;}
case 1693:{f.Push(f.Locals[1]);f.Pc=1694;continue;}
case 1694:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbilityWithFallback","()Lforge/game/spellability/SpellAbility;","invokevirtual",1697);}
case 1697:{f.Locals[15]=f.Pop();f.Pc=1699;continue;}
case 1699:{f.Push(f.Locals[15]);f.Pc=1701;continue;}
case 1701:{f.Push(f.Locals[8]);f.Pc=1703;continue;}
case 1703:{return rt.Call(f,"forge/game/keyword/Emerge","getCost","()Lforge/game/cost/Cost;","invokevirtual",1706);}
case 1706:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithDefinedCost","(Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",1709);}
case 1709:{f.Locals[16]=f.Pop();f.Pc=1711;continue;}
case 1711:{f.Push(f.Locals[16]);f.Pc=1713;continue;}
case 1713:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",1716);}
case 1716:{f.Push(f.Locals[8]);f.Pc=1718;continue;}
case 1718:{return rt.Call(f,"forge/game/keyword/Emerge","getValidType","()Ljava/lang/String;","invokevirtual",1721);}
case 1721:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:1721:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1726);}
case 1726:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setIsPresent","(Ljava/lang/String;)V","invokevirtual",1729);}
case 1729:{f.Push(f.Locals[16]);f.Pc=1731;continue;}
case 1731:{f.Push(JValue.R(rt.String("Secondary")));f.Pc=1734;continue;}
case 1734:{f.Push(JValue.R(rt.String("True")));f.Pc=1737;continue;}
case 1737:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1740);}
case 1740:{f.StackOp("pop");f.Pc=1741;continue;}
case 1741:{f.Push(f.Locals[16]);f.Pc=1743;continue;}
case 1743:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Emerge","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Emerge","Lforge/game/spellability/AlternativeCost;"));f.Pc=1746;continue;}
case 1746:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",1749);}
case 1749:{f.Push(f.Locals[16]);f.Pc=1751;continue;}
case 1751:{f.Push(f.Locals[15]);f.Pc=1753;continue;}
case 1753:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",1756);}
case 1756:{f.Push(f.Locals[14]);f.Pc=1758;continue;}
case 1758:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:1758:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1763);}
case 1763:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",1766);}
case 1766:{f.Push(f.Locals[16]);f.Pc=1768;continue;}
case 1768:{f.Push(JValue.R(rt.String("AfterDescription")));f.Pc=1771;continue;}
case 1771:{f.Push(f.Locals[14]);f.Pc=1773;continue;}
case 1773:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1776);}
case 1776:{f.StackOp("pop");f.Pc=1777;continue;}
case 1777:{f.Push(f.Locals[16]);f.Pc=1779;continue;}
case 1779:{f.Push(f.Locals[2]);f.Pc=1780;continue;}
case 1780:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",1783);}
case 1783:{f.Push(f.Locals[0]);f.Pc=1784;continue;}
case 1784:{f.Push(f.Locals[16]);f.Pc=1786;continue;}
case 1786:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",1791);}
case 1791:{f.Pc=8390;continue;}
case 1794:{f.Push(f.Locals[3]);f.Pc=1795;continue;}
case 1795:{f.Push(JValue.R(rt.String("Embalm")));f.Pc=1798;continue;}
case 1798:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1801);}
case 1801:{f.Pc=f.Pop().Int==0?1864:1804;continue;}
case 1804:{f.Push(f.Locals[3]);f.Pc=1805;continue;}
case 1805:{f.Push(JValue.R(rt.String(":")));f.Pc=1808;continue;}
case 1808:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1811);}
case 1811:{f.Locals[14]=f.Pop();f.Pc=1813;continue;}
case 1813:{f.Push(f.Locals[14]);f.Pc=1815;continue;}
case 1815:{f.Push(JValue.I(1));f.Pc=1816;continue;}
case 1816:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1817;continue;}
case 1817:{f.Locals[15]=f.Pop();f.Pc=1819;continue;}
case 1819:{f.Push(f.Locals[15]);f.Pc=1821;continue;}
case 1821:{f.Push(f.Locals[15]);f.Pc=1823;continue;}
case 1823:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",1826);}
case 1826:{f.Push(f.Locals[0]);f.Pc=1827;continue;}
case 1827:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1832);}
case 1832:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:1832:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1837);}
case 1837:{f.Locals[16]=f.Pop();f.Pc=1839;continue;}
case 1839:{f.Push(f.Locals[16]);f.Pc=1841;continue;}
case 1841:{f.Push(f.Locals[1]);f.Pc=1842;continue;}
case 1842:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",1845);}
case 1845:{f.Locals[17]=f.Pop();f.Pc=1847;continue;}
case 1847:{f.Push(f.Locals[17]);f.Pc=1849;continue;}
case 1849:{f.Push(f.Locals[2]);f.Pc=1850;continue;}
case 1850:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",1853);}
case 1853:{f.Push(f.Locals[0]);f.Pc=1854;continue;}
case 1854:{f.Push(f.Locals[17]);f.Pc=1856;continue;}
case 1856:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",1861);}
case 1861:{f.Pc=8390;continue;}
case 1864:{f.Push(f.Locals[3]);f.Pc=1865;continue;}
case 1865:{f.Push(JValue.R(rt.String("Epic")));f.Pc=1868;continue;}
case 1868:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1871);}
case 1871:{f.Pc=f.Pop().Int==0?1945:1874;continue;}
case 1874:{f.Push(JValue.R(rt.String("DB$ Effect | Triggers$ EpicTrigger | StaticAbilities$ EpicCantBeCast | Duration$ Permanent | ConditionDefined$ Self | ConditionPresent$ Card.hasKeywordEpic")));f.Pc=1877;continue;}
case 1877:{f.Locals[14]=f.Pop();f.Pc=1879;continue;}
case 1879:{f.Push(f.Locals[14]);f.Pc=1881;continue;}
case 1881:{f.Push(f.Locals[1]);f.Pc=1882;continue;}
case 1882:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",1885);}
case 1885:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1888;continue;}
case 1888:{f.Locals[15]=f.Pop();f.Pc=1890;continue;}
case 1890:{f.Push(f.Locals[15]);f.Pc=1892;continue;}
case 1892:{f.Push(JValue.R(rt.String("EpicCantBeCast")));f.Pc=1895;continue;}
case 1895:{f.Push(JValue.R(rt.String("Mode$ CantBeCast | Caster$ You | EffectZone$ Command | Description$ For the rest of the game, you can't cast spells.")));f.Pc=1898;continue;}
case 1898:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1901);}
case 1901:{f.Push(f.Locals[15]);f.Pc=1903;continue;}
case 1903:{f.Push(JValue.R(rt.String("EpicTrigger")));f.Pc=1906;continue;}
case 1906:{f.Push(f.Locals[1]);f.Pc=1907;continue;}
case 1907:{return rt.Call(f,"forge/game/card/CardState","toString","()Ljava/lang/String;","invokevirtual",1910);}
case 1910:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:1910:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1915);}
case 1915:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1918);}
case 1918:{f.Push(f.Locals[15]);f.Pc=1920;continue;}
case 1920:{f.Push(JValue.R(rt.String("EpicCopy")));f.Pc=1923;continue;}
case 1923:{f.Push(JValue.R(rt.String("DB$ CopySpellAbility | Defined$ EffectSource | Epic$ True | MayChooseTarget$ True")));f.Pc=1926;continue;}
case 1926:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1929);}
case 1929:{f.Push(f.Locals[1]);f.Pc=1930;continue;}
case 1930:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1933);}
case 1933:{f.Locals[16]=f.Pop();f.Pc=1935;continue;}
case 1935:{f.Push(f.Locals[16]);f.Pc=1937;continue;}
case 1937:{f.Push(f.Locals[15]);f.Pc=1939;continue;}
case 1939:{return rt.Call(f,"forge/game/spellability/SpellAbility","appendSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",1942);}
case 1942:{f.Pc=8390;continue;}
case 1945:{f.Push(f.Locals[3]);f.Pc=1946;continue;}
case 1946:{f.Push(JValue.R(rt.String("Equip")));f.Pc=1949;continue;}
case 1949:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1952);}
case 1952:{f.Pc=f.Pop().Int==0?2518:1955;continue;}
case 1955:{f.Push(f.Locals[3]);f.Pc=1956;continue;}
case 1956:{f.Push(JValue.R(rt.String(":")));f.Pc=1959;continue;}
case 1959:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",1962);}
case 1962:{f.Pc=f.Pop().Int!=0?1981:1965;continue;}
case 1965:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=1968;continue;}
case 1968:{f.Push(f.Locals[1]);f.Pc=1969;continue;}
case 1969:{return rt.Call(f,"forge/game/card/CardState","toString","()Ljava/lang/String;","invokevirtual",1972);}
case 1972:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:1972:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1977);}
case 1977:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",1980);}
case 1980:{return JStep.ReturnVoid;}
case 1981:{f.Push(JValue.I(0));f.Pc=1982;continue;}
case 1982:{f.Locals[14]=f.Pop();f.Pc=1984;continue;}
case 1984:{f.Push(JValue.R(rt.String("")));f.Pc=1987;continue;}
case 1987:{f.Locals[15]=f.Pop();f.Pc=1989;continue;}
case 1989:{f.Push(f.Locals[3]);f.Pc=1990;continue;}
case 1990:{f.Push(JValue.R(rt.String(":Flavor ")));f.Pc=1993;continue;}
case 1993:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",1996);}
case 1996:{f.Pc=f.Pop().Int==0?2032:1999;continue;}
case 1999:{f.Push(f.Locals[3]);f.Pc=2000;continue;}
case 2000:{f.Push(JValue.R(rt.String(":Flavor ")));f.Pc=2003;continue;}
case 2003:{f.Push(JValue.I(2));f.Pc=2004;continue;}
case 2004:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",2007);}
case 2007:{f.Push(JValue.I(1));f.Pc=2008;continue;}
case 2008:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2009;continue;}
case 2009:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:2009:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2014);}
case 2014:{f.Locals[15]=f.Pop();f.Pc=2016;continue;}
case 2016:{f.Push(f.Locals[3]);f.Pc=2017;continue;}
case 2017:{f.Push(JValue.I(0));f.Pc=2018;continue;}
case 2018:{f.Push(f.Locals[3]);f.Pc=2019;continue;}
case 2019:{f.Push(JValue.R(rt.String(":Flavor ")));f.Pc=2022;continue;}
case 2022:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",2025);}
case 2025:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",2028);}
case 2028:{f.Locals[3]=f.Pop();f.Pc=2029;continue;}
case 2029:{f.Push(JValue.I(1));f.Pc=2030;continue;}
case 2030:{f.Locals[14]=f.Pop();f.Pc=2032;continue;}
case 2032:{f.Push(f.Locals[3]);f.Pc=2033;continue;}
case 2033:{f.Push(JValue.R(rt.String(":")));f.Pc=2036;continue;}
case 2036:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2039);}
case 2039:{f.Locals[16]=f.Pop();f.Pc=2041;continue;}
case 2041:{f.Push(f.Locals[16]);f.Pc=2043;continue;}
case 2043:{f.Push(JValue.I(1));f.Pc=2044;continue;}
case 2044:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2045;continue;}
case 2045:{f.Locals[17]=f.Pop();f.Pc=2047;continue;}
case 2047:{f.Push(f.Locals[16]);f.Pc=2049;continue;}
case 2049:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2050;continue;}
case 2050:{f.Push(JValue.I(2));f.Pc=2051;continue;}
case 2051:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2071:2054;continue;}
case 2054:{f.Push(f.Locals[16]);f.Pc=2056;continue;}
case 2056:{f.Push(JValue.I(2));f.Pc=2057;continue;}
case 2057:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2058;continue;}
case 2058:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",2061);}
case 2061:{f.Pc=f.Pop().Int!=0?2071:2064;continue;}
case 2064:{f.Push(f.Locals[16]);f.Pc=2066;continue;}
case 2066:{f.Push(JValue.I(2));f.Pc=2067;continue;}
case 2067:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2068;continue;}
case 2068:{f.Pc=2074;continue;}
case 2071:{f.Push(JValue.R(rt.String("Creature.YouCtrl")));f.Pc=2074;continue;}
case 2074:{f.Locals[18]=f.Pop();f.Pc=2076;continue;}
case 2076:{f.Push(f.Locals[16]);f.Pc=2078;continue;}
case 2078:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2079;continue;}
case 2079:{f.Push(JValue.I(3));f.Pc=2080;continue;}
case 2080:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2100:2083;continue;}
case 2083:{f.Push(f.Locals[16]);f.Pc=2085;continue;}
case 2085:{f.Push(JValue.I(3));f.Pc=2086;continue;}
case 2086:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2087;continue;}
case 2087:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",2090);}
case 2090:{f.Pc=f.Pop().Int!=0?2100:2093;continue;}
case 2093:{f.Push(f.Locals[16]);f.Pc=2095;continue;}
case 2095:{f.Push(JValue.I(3));f.Pc=2096;continue;}
case 2096:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2097;continue;}
case 2097:{f.Pc=2103;continue;}
case 2100:{f.Push(JValue.R(rt.String("creature")));f.Pc=2103;continue;}
case 2103:{f.Locals[19]=f.Pop();f.Pc=2105;continue;}
case 2105:{f.Push(f.Locals[16]);f.Pc=2107;continue;}
case 2107:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2108;continue;}
case 2108:{f.Push(JValue.I(4));f.Pc=2109;continue;}
case 2109:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2119:2112;continue;}
case 2112:{f.Push(f.Locals[16]);f.Pc=2114;continue;}
case 2114:{f.Push(JValue.I(4));f.Pc=2115;continue;}
case 2115:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2116;continue;}
case 2116:{f.Pc=2122;continue;}
case 2119:{f.Push(JValue.R(rt.String("")));f.Pc=2122;continue;}
case 2122:{f.Locals[20]=f.Pop();f.Pc=2124;continue;}
case 2124:{f.Push(f.Locals[20]);f.Pc=2126;continue;}
case 2126:{f.Push(JValue.R(rt.String("AlternateCost")));f.Pc=2129;continue;}
case 2129:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",2132);}
case 2132:{f.Locals[21]=f.Pop();f.Pc=2134;continue;}
case 2134:{f.Push(f.Locals[16]);f.Pc=2136;continue;}
case 2136:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2137;continue;}
case 2137:{f.Push(JValue.I(5));f.Pc=2138;continue;}
case 2138:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2148:2141;continue;}
case 2141:{f.Push(f.Locals[16]);f.Pc=2143;continue;}
case 2143:{f.Push(JValue.I(5));f.Pc=2144;continue;}
case 2144:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2145;continue;}
case 2145:{f.Pc=2151;continue;}
case 2148:{f.Push(JValue.R(rt.String("")));f.Pc=2151;continue;}
case 2151:{f.Locals[22]=f.Pop();f.Pc=2153;continue;}
case 2153:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=2156;continue;}
case 2156:{f.StackOp("dup");f.Pc=2157;continue;}
case 2157:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",2160);}
case 2160:{f.Locals[23]=f.Pop();f.Pc=2162;continue;}
case 2162:{f.Push(f.Locals[23]);f.Pc=2164;continue;}
case 2164:{f.Push(JValue.R(rt.String("AB$ Attach | Cost$ ")));f.Pc=2167;continue;}
case 2167:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2170);}
case 2170:{f.StackOp("pop");f.Pc=2171;continue;}
case 2171:{f.Push(f.Locals[23]);f.Pc=2173;continue;}
case 2173:{f.Push(f.Locals[17]);f.Pc=2175;continue;}
case 2175:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2178);}
case 2178:{f.StackOp("pop");f.Pc=2179;continue;}
case 2179:{f.Push(f.Locals[23]);f.Pc=2181;continue;}
case 2181:{f.Push(JValue.R(rt.String(" | ValidTgts$ ")));f.Pc=2184;continue;}
case 2184:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2187);}
case 2187:{f.Push(f.Locals[18]);f.Pc=2189;continue;}
case 2189:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2192);}
case 2192:{f.StackOp("pop");f.Pc=2193;continue;}
case 2193:{f.Push(f.Locals[23]);f.Pc=2195;continue;}
case 2195:{f.Push(JValue.R(rt.String(" | TgtPrompt$ Select target ")));f.Pc=2198;continue;}
case 2198:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2201);}
case 2201:{f.Push(f.Locals[19]);f.Pc=2203;continue;}
case 2203:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2206);}
case 2206:{f.Push(JValue.R(rt.String(" you control")));f.Pc=2209;continue;}
case 2209:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2212);}
case 2212:{f.StackOp("pop");f.Pc=2213;continue;}
case 2213:{f.Push(f.Locals[23]);f.Pc=2215;continue;}
case 2215:{f.Push(JValue.R(rt.String(" | SorcerySpeed$ True | AILogic$ Pump")));f.Pc=2218;continue;}
case 2218:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2221);}
case 2221:{f.StackOp("pop");f.Pc=2222;continue;}
case 2222:{f.Push(f.Locals[1]);f.Pc=2223;continue;}
case 2223:{f.Push(JValue.R(rt.String("AttachAi")));f.Pc=2226;continue;}
case 2226:{return rt.Call(f,"forge/game/card/CardState","hasSVar","(Ljava/lang/String;)Z","invokevirtual",2229);}
case 2229:{f.Pc=f.Pop().Int==0?2251:2232;continue;}
case 2232:{f.Push(f.Locals[23]);f.Pc=2234;continue;}
case 2234:{f.Push(JValue.R(rt.String("| ")));f.Pc=2237;continue;}
case 2237:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2240);}
case 2240:{f.Push(f.Locals[1]);f.Pc=2241;continue;}
case 2241:{f.Push(JValue.R(rt.String("AttachAi")));f.Pc=2244;continue;}
case 2244:{return rt.Call(f,"forge/game/card/CardState","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2247);}
case 2247:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2250);}
case 2250:{f.StackOp("pop");f.Pc=2251;continue;}
case 2251:{f.Push(f.Locals[23]);f.Pc=2253;continue;}
case 2253:{f.Push(JValue.R(rt.String(" | PrecostDesc$ ")));f.Pc=2256;continue;}
case 2256:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2259);}
case 2259:{f.StackOp("pop");f.Pc=2260;continue;}
case 2260:{f.Push(f.Locals[14]);f.Pc=2262;continue;}
case 2262:{f.Pc=f.Pop().Int==0?2273:2265;continue;}
case 2265:{f.Push(f.Locals[23]);f.Pc=2267;continue;}
case 2267:{f.Push(f.Locals[15]);f.Pc=2269;continue;}
case 2269:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2272);}
case 2272:{f.StackOp("pop");f.Pc=2273;continue;}
case 2273:{f.Push(f.Locals[23]);f.Pc=2275;continue;}
case 2275:{f.Push(JValue.R(rt.String("Equip")));f.Pc=2278;continue;}
case 2278:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2281);}
case 2281:{f.StackOp("pop");f.Pc=2282;continue;}
case 2282:{f.Push(f.Locals[16]);f.Pc=2284;continue;}
case 2284:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2285;continue;}
case 2285:{f.Push(JValue.I(3));f.Pc=2286;continue;}
case 2286:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2313:2289;continue;}
case 2289:{f.Push(f.Locals[16]);f.Pc=2291;continue;}
case 2291:{f.Push(JValue.I(3));f.Pc=2292;continue;}
case 2292:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2293;continue;}
case 2293:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",2296);}
case 2296:{f.Pc=f.Pop().Int!=0?2313:2299;continue;}
case 2299:{f.Push(f.Locals[23]);f.Pc=2301;continue;}
case 2301:{f.Push(JValue.R(rt.String(" ")));f.Pc=2304;continue;}
case 2304:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2307);}
case 2307:{f.Push(f.Locals[19]);f.Pc=2309;continue;}
case 2309:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2312);}
case 2312:{f.StackOp("pop");f.Pc=2313;continue;}
case 2313:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=2316;continue;}
case 2316:{f.StackOp("dup");f.Pc=2317;continue;}
case 2317:{f.Push(f.Locals[17]);f.Pc=2319;continue;}
case 2319:{f.Push(JValue.I(1));f.Pc=2320;continue;}
case 2320:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",2323);}
case 2323:{f.Locals[24]=f.Pop();f.Pc=2325;continue;}
case 2325:{f.Push(f.Locals[24]);f.Pc=2327;continue;}
case 2327:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",2330);}
case 2330:{f.Pc=f.Pop().Int==0?2349:2333;continue;}
case 2333:{f.Push(f.Locals[21]);f.Pc=2335;continue;}
case 2335:{f.Pc=f.Pop().Int==0?2361:2338;continue;}
case 2338:{f.Push(f.Locals[20]);f.Pc=2340;continue;}
case 2340:{f.Push(JValue.R(rt.String("<")));f.Pc=2343;continue;}
case 2343:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",2346);}
case 2346:{f.Pc=f.Pop().Int==0?2361:2349;continue;}
case 2349:{f.Push(f.Locals[23]);f.Pc=2351;continue;}
case 2351:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=2354;continue;}
case 2354:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2357);}
case 2357:{f.StackOp("pop");f.Pc=2358;continue;}
case 2358:{f.Pc=2370;continue;}
case 2361:{f.Push(f.Locals[23]);f.Pc=2363;continue;}
case 2363:{f.Push(JValue.R(rt.String(" ")));f.Pc=2366;continue;}
case 2366:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2369);}
case 2369:{f.StackOp("pop");f.Pc=2370;continue;}
case 2370:{f.Push(f.Locals[21]);f.Pc=2372;continue;}
case 2372:{f.Pc=f.Pop().Int!=0?2398:2375;continue;}
case 2375:{f.Push(f.Locals[23]);f.Pc=2377;continue;}
case 2377:{f.Push(JValue.R(rt.String("| CostDesc$ ")));f.Pc=2380;continue;}
case 2380:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2383);}
case 2383:{f.Push(f.Locals[24]);f.Pc=2385;continue;}
case 2385:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",2388);}
case 2388:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2391);}
case 2391:{f.Push(JValue.R(rt.String(" ")));f.Pc=2394;continue;}
case 2394:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2397);}
case 2397:{f.StackOp("pop");f.Pc=2398;continue;}
case 2398:{f.Push(f.Locals[23]);f.Pc=2400;continue;}
case 2400:{f.Push(JValue.R(rt.String(" | SpellDescription$ ")));f.Pc=2403;continue;}
case 2403:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2406);}
case 2406:{f.StackOp("pop");f.Pc=2407;continue;}
case 2407:{f.Push(f.Locals[22]);f.Pc=2409;continue;}
case 2409:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",2412);}
case 2412:{f.Pc=f.Pop().Int!=0?2435:2415;continue;}
case 2415:{f.Push(f.Locals[23]);f.Pc=2417;continue;}
case 2417:{f.Push(JValue.R(rt.String(". ")));f.Pc=2420;continue;}
case 2420:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2423);}
case 2423:{f.Push(f.Locals[22]);f.Pc=2425;continue;}
case 2425:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2428);}
case 2428:{f.Push(JValue.R(rt.String(". ")));f.Pc=2431;continue;}
case 2431:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2434);}
case 2434:{f.StackOp("pop");f.Pc=2435;continue;}
case 2435:{f.Push(f.Locals[21]);f.Pc=2437;continue;}
case 2437:{f.Pc=f.Pop().Int!=0?2469:2440;continue;}
case 2440:{f.Push(f.Locals[14]);f.Pc=2442;continue;}
case 2442:{f.Pc=f.Pop().Int!=0?2469:2445;continue;}
case 2445:{f.Push(f.Locals[23]);f.Pc=2447;continue;}
case 2447:{f.Push(JValue.R(rt.String("(")));f.Pc=2450;continue;}
case 2450:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2453);}
case 2453:{f.Push(f.Locals[0]);f.Pc=2454;continue;}
case 2454:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2459);}
case 2459:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2462);}
case 2462:{f.Push(JValue.R(rt.String(")")));f.Pc=2465;continue;}
case 2465:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2468);}
case 2468:{f.StackOp("pop");f.Pc=2469;continue;}
case 2469:{f.Push(f.Locals[20]);f.Pc=2471;continue;}
case 2471:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",2474);}
case 2474:{f.Pc=f.Pop().Int!=0?2490:2477;continue;}
case 2477:{f.Push(f.Locals[23]);f.Pc=2479;continue;}
case 2479:{f.Push(JValue.R(rt.String(" | ")));f.Pc=2481;continue;}
case 2481:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2484);}
case 2484:{f.Push(f.Locals[20]);f.Pc=2486;continue;}
case 2486:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2489);}
case 2489:{f.StackOp("pop");f.Pc=2490;continue;}
case 2490:{f.Push(f.Locals[23]);f.Pc=2492;continue;}
case 2492:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",2495);}
case 2495:{f.Push(f.Locals[1]);f.Pc=2496;continue;}
case 2496:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",2499);}
case 2499:{f.Locals[25]=f.Pop();f.Pc=2501;continue;}
case 2501:{f.Push(f.Locals[25]);f.Pc=2503;continue;}
case 2503:{f.Push(f.Locals[2]);f.Pc=2504;continue;}
case 2504:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",2507);}
case 2507:{f.Push(f.Locals[0]);f.Pc=2508;continue;}
case 2508:{f.Push(f.Locals[25]);f.Pc=2510;continue;}
case 2510:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",2515);}
case 2515:{f.Pc=8390;continue;}
case 2518:{f.Push(f.Locals[3]);f.Pc=2519;continue;}
case 2519:{f.Push(JValue.R(rt.String("Eternalize")));f.Pc=2522;continue;}
case 2522:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2525);}
case 2525:{f.Pc=f.Pop().Int==0?2723:2528;continue;}
case 2528:{f.Push(f.Locals[3]);f.Pc=2529;continue;}
case 2529:{f.Push(JValue.R(rt.String(":")));f.Pc=2532;continue;}
case 2532:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2535);}
case 2535:{f.Locals[14]=f.Pop();f.Pc=2537;continue;}
case 2537:{f.Push(f.Locals[14]);f.Pc=2539;continue;}
case 2539:{f.Push(JValue.I(1));f.Pc=2540;continue;}
case 2540:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2541;continue;}
case 2541:{f.Locals[15]=f.Pop();f.Pc=2543;continue;}
case 2543:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=2546;continue;}
case 2546:{f.StackOp("dup");f.Pc=2547;continue;}
case 2547:{f.Push(f.Locals[15]);f.Pc=2549;continue;}
case 2549:{f.Push(JValue.I(1));f.Pc=2550;continue;}
case 2550:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",2553);}
case 2553:{f.Locals[16]=f.Pop();f.Pc=2555;continue;}
case 2555:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=2558;continue;}
case 2558:{f.StackOp("dup");f.Pc=2559;continue;}
case 2559:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",2562);}
case 2562:{f.Locals[17]=f.Pop();f.Pc=2564;continue;}
case 2564:{f.Push(f.Locals[17]);f.Pc=2566;continue;}
case 2566:{f.Push(JValue.R(rt.String("AB$ CopyPermanent | Cost$ ")));f.Pc=2569;continue;}
case 2569:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2572);}
case 2572:{f.Push(f.Locals[15]);f.Pc=2574;continue;}
case 2574:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2577);}
case 2577:{f.Push(JValue.R(rt.String(" ExileFromGrave<1/CARDNAME>")));f.Pc=2580;continue;}
case 2580:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2583);}
case 2583:{f.Push(JValue.R(rt.String(" | Defined$ Self | ActivationZone$ Graveyard | SorcerySpeed$ True")));f.Pc=2586;continue;}
case 2586:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2589);}
case 2589:{f.Push(JValue.R(rt.String(" | RemoveCost$ True | SetColor$ Black | AddTypes$ Zombie | SetPower$ 4 | SetToughness$ 4")));f.Pc=2592;continue;}
case 2592:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2595);}
case 2595:{f.StackOp("pop");f.Pc=2596;continue;}
case 2596:{f.Push(f.Locals[17]);f.Pc=2598;continue;}
case 2598:{f.Push(JValue.R(rt.String(" | PrecostDesc$ Eternalize")));f.Pc=2601;continue;}
case 2601:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2604);}
case 2604:{f.StackOp("pop");f.Pc=2605;continue;}
case 2605:{f.Push(f.Locals[16]);f.Pc=2607;continue;}
case 2607:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",2610);}
case 2610:{f.Pc=f.Pop().Int!=0?2625:2613;continue;}
case 2613:{f.Push(f.Locals[17]);f.Pc=2615;continue;}
case 2615:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=2618;continue;}
case 2618:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2621);}
case 2621:{f.StackOp("pop");f.Pc=2622;continue;}
case 2622:{f.Pc=2634;continue;}
case 2625:{f.Push(f.Locals[17]);f.Pc=2627;continue;}
case 2627:{f.Push(JValue.R(rt.String(" ")));f.Pc=2630;continue;}
case 2630:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2633);}
case 2633:{f.StackOp("pop");f.Pc=2634;continue;}
case 2634:{f.Push(f.Locals[17]);f.Pc=2636;continue;}
case 2636:{f.Push(JValue.R(rt.String("| CostDesc$ ")));f.Pc=2639;continue;}
case 2639:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2642);}
case 2642:{f.Push(f.Locals[16]);f.Pc=2644;continue;}
case 2644:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",2647);}
case 2647:{f.StackOp("pop");f.Pc=2648;continue;}
case 2648:{f.Push(f.Locals[16]);f.Pc=2650;continue;}
case 2650:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",2653);}
case 2653:{f.Pc=f.Pop().Int!=0?2665:2656;continue;}
case 2656:{f.Push(f.Locals[17]);f.Pc=2658;continue;}
case 2658:{f.Push(JValue.R(rt.String(".")));f.Pc=2661;continue;}
case 2661:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2664);}
case 2664:{f.StackOp("pop");f.Pc=2665;continue;}
case 2665:{f.Push(f.Locals[17]);f.Pc=2667;continue;}
case 2667:{f.Push(JValue.R(rt.String(" | StackDescription$ Eternalize - CARDNAME ")));f.Pc=2670;continue;}
case 2670:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2673);}
case 2673:{f.Push(JValue.R(rt.String("| SpellDescription$ (")));f.Pc=2676;continue;}
case 2676:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2679);}
case 2679:{f.Push(f.Locals[0]);f.Pc=2680;continue;}
case 2680:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2685);}
case 2685:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2688);}
case 2688:{f.Push(JValue.R(rt.String(")")));f.Pc=2691;continue;}
case 2691:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2694);}
case 2694:{f.StackOp("pop");f.Pc=2695;continue;}
case 2695:{f.Push(f.Locals[17]);f.Pc=2697;continue;}
case 2697:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",2700);}
case 2700:{f.Push(f.Locals[1]);f.Pc=2701;continue;}
case 2701:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",2704);}
case 2704:{f.Locals[18]=f.Pop();f.Pc=2706;continue;}
case 2706:{f.Push(f.Locals[18]);f.Pc=2708;continue;}
case 2708:{f.Push(f.Locals[2]);f.Pc=2709;continue;}
case 2709:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",2712);}
case 2712:{f.Push(f.Locals[0]);f.Pc=2713;continue;}
case 2713:{f.Push(f.Locals[18]);f.Pc=2715;continue;}
case 2715:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",2720);}
case 2720:{f.Pc=8390;continue;}
case 2723:{f.Push(f.Locals[3]);f.Pc=2724;continue;}
case 2724:{f.Push(JValue.R(rt.String("Evoke")));f.Pc=2727;continue;}
case 2727:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2730);}
case 2730:{f.Pc=f.Pop().Int==0?2932:2733;continue;}
case 2733:{f.Push(f.Locals[3]);f.Pc=2734;continue;}
case 2734:{f.Push(JValue.R(rt.String(":")));f.Pc=2737;continue;}
case 2737:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2740);}
case 2740:{f.Locals[14]=f.Pop();f.Pc=2742;continue;}
case 2742:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=2745;continue;}
case 2745:{f.StackOp("dup");f.Pc=2746;continue;}
case 2746:{f.Push(f.Locals[14]);f.Pc=2748;continue;}
case 2748:{f.Push(JValue.I(1));f.Pc=2749;continue;}
case 2749:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2750;continue;}
case 2750:{f.Push(JValue.I(0));f.Pc=2751;continue;}
case 2751:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",2754);}
case 2754:{f.Locals[15]=f.Pop();f.Pc=2756;continue;}
case 2756:{f.Push(f.Locals[1]);f.Pc=2757;continue;}
case 2757:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",2760);}
case 2760:{f.Locals[16]=f.Pop();f.Pc=2762;continue;}
case 2762:{f.Push(f.Locals[16]);f.Pc=2764;continue;}
case 2764:{f.Push(f.Locals[15]);f.Pc=2766;continue;}
case 2766:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithDefinedCost","(Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",2769);}
case 2769:{f.Locals[17]=f.Pop();f.Pc=2771;continue;}
case 2771:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=2774;continue;}
case 2774:{f.StackOp("dup");f.Pc=2775;continue;}
case 2775:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",2778);}
case 2778:{f.Locals[18]=f.Pop();f.Pc=2780;continue;}
case 2780:{f.Push(f.Locals[15]);f.Pc=2782;continue;}
case 2782:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",2785);}
case 2785:{f.Locals[19]=f.Pop();f.Pc=2787;continue;}
case 2787:{f.Push(f.Locals[18]);f.Pc=2789;continue;}
case 2789:{f.Push(JValue.R(rt.String("Evoke")));f.Pc=2792;continue;}
case 2792:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2795);}
case 2795:{f.Push(f.Locals[19]);f.Pc=2797;continue;}
case 2797:{f.Pc=f.Pop().Int==0?2806:2800;continue;}
case 2800:{f.Push(JValue.R(rt.String(" ")));f.Pc=2803;continue;}
case 2803:{f.Pc=2809;continue;}
case 2806:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=2809;continue;}
case 2809:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2812);}
case 2812:{f.Push(f.Locals[15]);f.Pc=2814;continue;}
case 2814:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",2817);}
case 2817:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2820);}
case 2820:{f.StackOp("pop");f.Pc=2821;continue;}
case 2821:{f.Push(f.Locals[18]);f.Pc=2823;continue;}
case 2823:{f.Push(f.Locals[19]);f.Pc=2825;continue;}
case 2825:{f.Pc=f.Pop().Int==0?2834:2828;continue;}
case 2828:{f.Push(JValue.R(rt.String("")));f.Pc=2831;continue;}
case 2831:{f.Pc=2837;continue;}
case 2834:{f.Push(JValue.R(rt.String(".")));f.Pc=2837;continue;}
case 2837:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2840);}
case 2840:{f.Push(JValue.R(rt.String(" (")));f.Pc=2843;continue;}
case 2843:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2846);}
case 2846:{f.Push(f.Locals[0]);f.Pc=2847;continue;}
case 2847:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2852);}
case 2852:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2855);}
case 2855:{f.Push(JValue.R(rt.String(")")));f.Pc=2858;continue;}
case 2858:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2861);}
case 2861:{f.StackOp("pop");f.Pc=2862;continue;}
case 2862:{f.Push(f.Locals[17]);f.Pc=2864;continue;}
case 2864:{f.Push(f.Locals[18]);f.Pc=2866;continue;}
case 2866:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",2869);}
case 2869:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",2872);}
case 2872:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=2875;continue;}
case 2875:{f.StackOp("dup");f.Pc=2876;continue;}
case 2876:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",2879);}
case 2879:{f.Locals[20]=f.Pop();f.Pc=2881;continue;}
case 2881:{f.Push(f.Locals[20]);f.Pc=2883;continue;}
case 2883:{f.Push(f.Locals[1]);f.Pc=2884;continue;}
case 2884:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",2887);}
case 2887:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2890);}
case 2890:{f.Push(JValue.R(rt.String(" (Evoked)")));f.Pc=2893;continue;}
case 2893:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2896);}
case 2896:{f.StackOp("pop");f.Pc=2897;continue;}
case 2897:{f.Push(f.Locals[17]);f.Pc=2899;continue;}
case 2899:{f.Push(f.Locals[20]);f.Pc=2901;continue;}
case 2901:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",2904);}
case 2904:{return rt.Call(f,"forge/game/spellability/SpellAbility","setStackDescription","(Ljava/lang/String;)V","invokevirtual",2907);}
case 2907:{f.Push(f.Locals[17]);f.Pc=2909;continue;}
case 2909:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Evoke","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Evoke","Lforge/game/spellability/AlternativeCost;"));f.Pc=2912;continue;}
case 2912:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",2915);}
case 2915:{f.Push(f.Locals[17]);f.Pc=2917;continue;}
case 2917:{f.Push(f.Locals[2]);f.Pc=2918;continue;}
case 2918:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",2921);}
case 2921:{f.Push(f.Locals[0]);f.Pc=2922;continue;}
case 2922:{f.Push(f.Locals[17]);f.Pc=2924;continue;}
case 2924:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",2929);}
case 2929:{f.Pc=8390;continue;}
case 2932:{f.Push(f.Locals[3]);f.Pc=2933;continue;}
case 2933:{f.Push(JValue.R(rt.String("Foretell")));f.Pc=2936;continue;}
case 2936:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2939);}
case 2939:{f.Pc=f.Pop().Int==0?3056:2942;continue;}
case 2942:{if(!rt.EnsureInitialized(f,"forge/game/card/CardFactoryUtil$4"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardFactoryUtil$4")));f.Pc=2945;continue;}
case 2945:{f.StackOp("dup");f.Pc=2946;continue;}
case 2946:{f.Push(f.Locals[1]);f.Pc=2947;continue;}
case 2947:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",2950);}
case 2950:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=2953;continue;}
case 2953:{f.StackOp("dup");f.Pc=2954;continue;}
case 2954:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","TWO","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","TWO","Lforge/card/mana/ManaCost;"));f.Pc=2957;continue;}
case 2957:{f.Push(JValue.I(0));f.Pc=2958;continue;}
case 2958:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",2961);}
case 2961:{f.Push(JValue.R(null));f.Pc=2962;continue;}
case 2962:{return rt.Call(f,"forge/game/card/CardFactoryUtil$4","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;)V","invokespecial",2965);}
case 2965:{f.Locals[14]=f.Pop();f.Pc=2967;continue;}
case 2967:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=2970;continue;}
case 2970:{f.StackOp("dup");f.Pc=2971;continue;}
case 2971:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",2974);}
case 2974:{f.Locals[15]=f.Pop();f.Pc=2976;continue;}
case 2976:{f.Push(f.Locals[15]);f.Pc=2978;continue;}
case 2978:{f.Push(JValue.R(rt.String("Foretell (")));f.Pc=2981;continue;}
case 2981:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2984);}
case 2984:{f.Push(f.Locals[0]);f.Pc=2985;continue;}
case 2985:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2990);}
case 2990:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2993);}
case 2993:{f.Push(JValue.R(rt.String(")")));f.Pc=2996;continue;}
case 2996:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2999);}
case 2999:{f.StackOp("pop");f.Pc=3000;continue;}
case 3000:{f.Push(f.Locals[14]);f.Pc=3002;continue;}
case 3002:{f.Push(f.Locals[15]);f.Pc=3004;continue;}
case 3004:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",3007);}
case 3007:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",3010);}
case 3010:{f.Push(f.Locals[14]);f.Pc=3012;continue;}
case 3012:{f.Push(JValue.R(rt.String("Secondary")));f.Pc=3015;continue;}
case 3015:{f.Push(JValue.R(rt.String("True")));f.Pc=3018;continue;}
case 3018:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3021);}
case 3021:{f.StackOp("pop");f.Pc=3022;continue;}
case 3022:{f.Push(f.Locals[14]);f.Pc=3024;continue;}
case 3024:{f.Push(f.Locals[1]);f.Pc=3025;continue;}
case 3025:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",3028);}
case 3028:{f.Push(f.Locals[14]);f.Pc=3030;continue;}
case 3030:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",3033);}
case 3033:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=3036;continue;}
case 3036:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",3039);}
case 3039:{f.Push(f.Locals[14]);f.Pc=3041;continue;}
case 3041:{f.Push(f.Locals[2]);f.Pc=3042;continue;}
case 3042:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",3045);}
case 3045:{f.Push(f.Locals[0]);f.Pc=3046;continue;}
case 3046:{f.Push(f.Locals[14]);f.Pc=3048;continue;}
case 3048:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",3053);}
case 3053:{f.Pc=8390;continue;}
case 3056:{f.Push(f.Locals[3]);f.Pc=3057;continue;}
case 3057:{f.Push(JValue.R(rt.String("Fortify")));f.Pc=3060;continue;}
case 3060:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3063);}
case 3063:{f.Pc=f.Pop().Int==0?3235:3066;continue;}
case 3066:{f.Push(f.Locals[3]);f.Pc=3067;continue;}
case 3067:{f.Push(JValue.R(rt.String(":")));f.Pc=3070;continue;}
case 3070:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",3073);}
case 3073:{f.Locals[14]=f.Pop();f.Pc=3075;continue;}
case 3075:{f.Push(f.Locals[14]);f.Pc=3077;continue;}
case 3077:{f.Push(JValue.I(1));f.Pc=3078;continue;}
case 3078:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3079;continue;}
case 3079:{f.Locals[15]=f.Pop();f.Pc=3081;continue;}
case 3081:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3084;continue;}
case 3084:{f.StackOp("dup");f.Pc=3085;continue;}
case 3085:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",3088);}
case 3088:{f.Locals[16]=f.Pop();f.Pc=3090;continue;}
case 3090:{f.Push(f.Locals[16]);f.Pc=3092;continue;}
case 3092:{f.Push(JValue.R(rt.String("AB$ Attach | Cost$ ")));f.Pc=3095;continue;}
case 3095:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3098);}
case 3098:{f.StackOp("pop");f.Pc=3099;continue;}
case 3099:{f.Push(f.Locals[16]);f.Pc=3101;continue;}
case 3101:{f.Push(f.Locals[15]);f.Pc=3103;continue;}
case 3103:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3106);}
case 3106:{f.StackOp("pop");f.Pc=3107;continue;}
case 3107:{f.Push(f.Locals[16]);f.Pc=3109;continue;}
case 3109:{f.Push(JValue.R(rt.String(" | ValidTgts$ Land.YouCtrl | TgtPrompt$ Select target land you control ")));f.Pc=3112;continue;}
case 3112:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3115);}
case 3115:{f.StackOp("pop");f.Pc=3116;continue;}
case 3116:{f.Push(f.Locals[16]);f.Pc=3118;continue;}
case 3118:{f.Push(JValue.R(rt.String("| SorcerySpeed$ True | AILogic$ Pump | IsPresent$ Fortification.Self+nonCreature ")));f.Pc=3121;continue;}
case 3121:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3124);}
case 3124:{f.StackOp("pop");f.Pc=3125;continue;}
case 3125:{f.Push(f.Locals[16]);f.Pc=3127;continue;}
case 3127:{f.Push(JValue.R(rt.String("| PrecostDesc$ Fortify")));f.Pc=3130;continue;}
case 3130:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3133);}
case 3133:{f.StackOp("pop");f.Pc=3134;continue;}
case 3134:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=3137;continue;}
case 3137:{f.StackOp("dup");f.Pc=3138;continue;}
case 3138:{f.Push(f.Locals[15]);f.Pc=3140;continue;}
case 3140:{f.Push(JValue.I(1));f.Pc=3141;continue;}
case 3141:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",3144);}
case 3144:{f.Locals[17]=f.Pop();f.Pc=3146;continue;}
case 3146:{f.Push(f.Locals[16]);f.Pc=3148;continue;}
case 3148:{f.Push(f.Locals[17]);f.Pc=3150;continue;}
case 3150:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",3153);}
case 3153:{f.Pc=f.Pop().Int==0?3162:3156;continue;}
case 3156:{f.Push(JValue.R(rt.String(" ")));f.Pc=3159;continue;}
case 3159:{f.Pc=3165;continue;}
case 3162:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=3165;continue;}
case 3165:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3168);}
case 3168:{f.StackOp("pop");f.Pc=3169;continue;}
case 3169:{f.Push(f.Locals[16]);f.Pc=3171;continue;}
case 3171:{f.Push(JValue.R(rt.String("| CostDesc$ ")));f.Pc=3174;continue;}
case 3174:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3177);}
case 3177:{f.Push(f.Locals[17]);f.Pc=3179;continue;}
case 3179:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",3182);}
case 3182:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3185);}
case 3185:{f.StackOp("pop");f.Pc=3186;continue;}
case 3186:{f.Push(f.Locals[16]);f.Pc=3188;continue;}
case 3188:{f.Push(JValue.R(rt.String(" | SpellDescription$ (")));f.Pc=3191;continue;}
case 3191:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3194);}
case 3194:{f.StackOp("pop");f.Pc=3195;continue;}
case 3195:{f.Push(f.Locals[16]);f.Pc=3197;continue;}
case 3197:{f.Push(f.Locals[0]);f.Pc=3198;continue;}
case 3198:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",3203);}
case 3203:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3206);}
case 3206:{f.Push(JValue.R(rt.String(")")));f.Pc=3209;continue;}
case 3209:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3212);}
case 3212:{f.StackOp("pop");f.Pc=3213;continue;}
case 3213:{f.Push(f.Locals[16]);f.Pc=3215;continue;}
case 3215:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",3218);}
case 3218:{f.Push(f.Locals[1]);f.Pc=3219;continue;}
case 3219:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",3222);}
case 3222:{f.Locals[18]=f.Pop();f.Pc=3224;continue;}
case 3224:{f.Push(f.Locals[0]);f.Pc=3225;continue;}
case 3225:{f.Push(f.Locals[18]);f.Pc=3227;continue;}
case 3227:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",3232);}
case 3232:{f.Pc=8390;continue;}
case 3235:{f.Push(f.Locals[3]);f.Pc=3236;continue;}
case 3236:{f.Push(JValue.R(rt.String("Freerunning")));f.Pc=3239;continue;}
case 3239:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3242);}
case 3242:{f.Pc=f.Pop().Int==0?3461:3245;continue;}
case 3245:{f.Push(f.Locals[3]);f.Pc=3246;continue;}
case 3246:{f.Push(JValue.R(rt.String(":")));f.Pc=3249;continue;}
case 3249:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",3252);}
case 3252:{f.Locals[14]=f.Pop();f.Pc=3254;continue;}
case 3254:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=3257;continue;}
case 3257:{f.StackOp("dup");f.Pc=3258;continue;}
case 3258:{f.Push(f.Locals[14]);f.Pc=3260;continue;}
case 3260:{f.Push(JValue.I(1));f.Pc=3261;continue;}
case 3261:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3262;continue;}
case 3262:{f.Push(JValue.I(0));f.Pc=3263;continue;}
case 3263:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",3266);}
case 3266:{f.Locals[15]=f.Pop();f.Pc=3268;continue;}
case 3268:{f.Push(f.Locals[1]);f.Pc=3269;continue;}
case 3269:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbilityWithFallback","()Lforge/game/spellability/SpellAbility;","invokevirtual",3272);}
case 3272:{f.Push(f.Locals[15]);f.Pc=3274;continue;}
case 3274:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithDefinedCost","(Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",3277);}
case 3277:{f.Locals[16]=f.Pop();f.Pc=3279;continue;}
case 3279:{f.Push(f.Locals[4]);f.Pc=3281;continue;}
case 3281:{return rt.Call(f,"forge/game/card/Card","isInstant","()Z","invokevirtual",3284);}
case 3284:{f.Pc=f.Pop().Int!=0?3295:3287;continue;}
case 3287:{f.Push(f.Locals[4]);f.Pc=3289;continue;}
case 3289:{return rt.Call(f,"forge/game/card/Card","isSorcery","()Z","invokevirtual",3292);}
case 3292:{f.Pc=f.Pop().Int==0?3307:3295;continue;}
case 3295:{f.Push(f.Locals[16]);f.Pc=3297;continue;}
case 3297:{f.Push(JValue.R(rt.String("Secondary")));f.Pc=3300;continue;}
case 3300:{f.Push(JValue.R(rt.String("True")));f.Pc=3303;continue;}
case 3303:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3306);}
case 3306:{f.StackOp("pop");f.Pc=3307;continue;}
case 3307:{f.Push(f.Locals[16]);f.Pc=3309;continue;}
case 3309:{f.Push(JValue.R(rt.String("PrecostDesc")));f.Pc=3312;continue;}
case 3312:{f.Push(JValue.R(rt.String("Freerunning")));f.Pc=3315;continue;}
case 3315:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3318);}
case 3318:{f.StackOp("pop");f.Pc=3319;continue;}
case 3319:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3322;continue;}
case 3322:{f.StackOp("dup");f.Pc=3323;continue;}
case 3323:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",3326);}
case 3326:{f.Locals[17]=f.Pop();f.Pc=3328;continue;}
case 3328:{f.Push(f.Locals[15]);f.Pc=3330;continue;}
case 3330:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",3333);}
case 3333:{f.Pc=f.Pop().Int!=0?3348:3336;continue;}
case 3336:{f.Push(f.Locals[17]);f.Pc=3338;continue;}
case 3338:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=3341;continue;}
case 3341:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3344);}
case 3344:{f.StackOp("pop");f.Pc=3345;continue;}
case 3345:{f.Pc=3357;continue;}
case 3348:{f.Push(f.Locals[17]);f.Pc=3350;continue;}
case 3350:{f.Push(JValue.R(rt.String(" ")));f.Pc=3353;continue;}
case 3353:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3356);}
case 3356:{f.StackOp("pop");f.Pc=3357;continue;}
case 3357:{f.Push(f.Locals[17]);f.Pc=3359;continue;}
case 3359:{f.Push(f.Locals[15]);f.Pc=3361;continue;}
case 3361:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",3364);}
case 3364:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3367);}
case 3367:{f.StackOp("pop");f.Pc=3368;continue;}
case 3368:{f.Push(f.Locals[16]);f.Pc=3370;continue;}
case 3370:{f.Push(JValue.R(rt.String("CostDesc")));f.Pc=3373;continue;}
case 3373:{f.Push(f.Locals[17]);f.Pc=3375;continue;}
case 3375:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",3378);}
case 3378:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3381);}
case 3381:{f.StackOp("pop");f.Pc=3382;continue;}
case 3382:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3385;continue;}
case 3385:{f.StackOp("dup");f.Pc=3386;continue;}
case 3386:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",3389);}
case 3389:{f.Locals[18]=f.Pop();f.Pc=3391;continue;}
case 3391:{f.Push(f.Locals[18]);f.Pc=3393;continue;}
case 3393:{f.Push(f.Locals[16]);f.Pc=3395;continue;}
case 3395:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCostDescription","()Ljava/lang/String;","invokevirtual",3398);}
case 3398:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3401);}
case 3401:{f.StackOp("pop");f.Pc=3402;continue;}
case 3402:{f.Push(f.Locals[18]);f.Pc=3404;continue;}
case 3404:{f.Push(JValue.R(rt.String("(")));f.Pc=3407;continue;}
case 3407:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3410);}
case 3410:{f.Push(f.Locals[0]);f.Pc=3411;continue;}
case 3411:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",3416);}
case 3416:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3419);}
case 3419:{f.Push(JValue.R(rt.String(")")));f.Pc=3422;continue;}
case 3422:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3425);}
case 3425:{f.StackOp("pop");f.Pc=3426;continue;}
case 3426:{f.Push(f.Locals[16]);f.Pc=3428;continue;}
case 3428:{f.Push(f.Locals[18]);f.Pc=3430;continue;}
case 3430:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",3433);}
case 3433:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",3436);}
case 3436:{f.Push(f.Locals[16]);f.Pc=3438;continue;}
case 3438:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Freerunning","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Freerunning","Lforge/game/spellability/AlternativeCost;"));f.Pc=3441;continue;}
case 3441:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",3444);}
case 3444:{f.Push(f.Locals[16]);f.Pc=3446;continue;}
case 3446:{f.Push(f.Locals[2]);f.Pc=3447;continue;}
case 3447:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",3450);}
case 3450:{f.Push(f.Locals[0]);f.Pc=3451;continue;}
case 3451:{f.Push(f.Locals[16]);f.Pc=3453;continue;}
case 3453:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",3458);}
case 3458:{f.Pc=8390;continue;}
case 3461:{f.Push(f.Locals[3]);f.Pc=3462;continue;}
case 3462:{f.Push(JValue.R(rt.String("Fuse")));f.Pc=3465;continue;}
case 3465:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3468);}
case 3468:{f.Pc=f.Pop().Int==0?3504:3471;continue;}
case 3471:{f.Push(f.Locals[1]);f.Pc=3472;continue;}
case 3472:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",3475);}
case 3475:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=3478;continue;}
case 3478:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",3481);}
case 3481:{f.Pc=f.Pop().Int==0?3504:3484;continue;}
case 3484:{f.Push(f.Locals[1]);f.Pc=3485;continue;}
case 3485:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",3488);}
case 3488:{return rt.Call(f,"forge/game/ability/AbilityFactory","buildFusedAbility","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",3491);}
case 3491:{f.Locals[14]=f.Pop();f.Pc=3493;continue;}
case 3493:{f.Push(f.Locals[0]);f.Pc=3494;continue;}
case 3494:{f.Push(f.Locals[14]);f.Pc=3496;continue;}
case 3496:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",3501);}
case 3501:{f.Pc=8390;continue;}
case 3504:{f.Push(f.Locals[3]);f.Pc=3505;continue;}
case 3505:{f.Push(JValue.R(rt.String("Haunt")));f.Pc=3508;continue;}
case 3508:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3511);}
case 3511:{f.Pc=f.Pop().Int==0?3616:3514;continue;}
case 3514:{f.Push(f.Locals[4]);f.Pc=3516;continue;}
case 3516:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",3519);}
case 3519:{f.Pc=f.Pop().Int!=0?8390:3522;continue;}
case 3522:{f.Push(f.Locals[2]);f.Pc=3523;continue;}
case 3523:{f.Pc=f.Pop().Int==0?8390:3526;continue;}
case 3526:{f.Push(f.Locals[3]);f.Pc=3527;continue;}
case 3527:{f.Push(JValue.R(rt.String(":")));f.Pc=3530;continue;}
case 3530:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",3533);}
case 3533:{f.Locals[14]=f.Pop();f.Pc=3535;continue;}
case 3535:{f.Push(f.Locals[14]);f.Pc=3537;continue;}
case 3537:{f.Push(JValue.I(1));f.Pc=3538;continue;}
case 3538:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3539;continue;}
case 3539:{f.Locals[15]=f.Pop();f.Pc=3541;continue;}
case 3541:{f.Push(JValue.I(2));f.Pc=3542;continue;}
case 3542:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=3545;continue;}
case 3545:{f.StackOp("dup");f.Pc=3546;continue;}
case 3546:{f.Push(JValue.I(0));f.Pc=3547;continue;}
case 3547:{f.Push(f.Locals[1]);f.Pc=3548;continue;}
case 3548:{f.Push(f.Locals[15]);f.Pc=3550;continue;}
case 3550:{return rt.Call(f,"forge/game/card/CardState","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3553);}
case 3553:{f.Push(JValue.R(rt.String("DB$")));f.Pc=3556;continue;}
case 3556:{f.Push(JValue.R(rt.String("SP$")));f.Pc=3559;continue;}
case 3559:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",3562);}
case 3562:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=3563;continue;}
case 3563:{f.StackOp("dup");f.Pc=3564;continue;}
case 3564:{f.Push(JValue.I(1));f.Pc=3565;continue;}
case 3565:{f.Push(JValue.R(rt.String(" | Cost$ 0 | StackDescription$ SpellDescription")));f.Pc=3568;continue;}
case 3568:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=3569;continue;}
case 3569:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",3572);}
case 3572:{f.Locals[16]=f.Pop();f.Pc=3574;continue;}
case 3574:{f.Push(f.Locals[16]);f.Pc=3576;continue;}
case 3576:{f.Push(f.Locals[1]);f.Pc=3577;continue;}
case 3577:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",3580);}
case 3580:{f.Locals[17]=f.Pop();f.Pc=3582;continue;}
case 3582:{f.Push(f.Locals[17]);f.Pc=3584;continue;}
case 3584:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=3587;continue;}
case 3587:{f.StackOp("dup");f.Pc=3588;continue;}
case 3588:{f.Push(f.Locals[1]);f.Pc=3589;continue;}
case 3589:{return rt.Call(f,"forge/game/card/CardState","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",3592);}
case 3592:{f.Push(JValue.I(0));f.Pc=3593;continue;}
case 3593:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",3596);}
case 3596:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPayCosts","(Lforge/game/cost/Cost;)V","invokevirtual",3599);}
case 3599:{f.Push(f.Locals[17]);f.Pc=3601;continue;}
case 3601:{f.Push(f.Locals[2]);f.Pc=3602;continue;}
case 3602:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",3605);}
case 3605:{f.Push(f.Locals[0]);f.Pc=3606;continue;}
case 3606:{f.Push(f.Locals[17]);f.Pc=3608;continue;}
case 3608:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",3613);}
case 3613:{f.Pc=8390;continue;}
case 3616:{f.Push(f.Locals[3]);f.Pc=3617;continue;}
case 3617:{f.Push(JValue.R(rt.String("Impending")));f.Pc=3620;continue;}
case 3620:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3623);}
case 3623:{f.Pc=f.Pop().Int==0?3811:3626;continue;}
case 3626:{f.Push(f.Locals[0]);f.Pc=3627;continue;}
case 3627:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/KeywordWithCostAndAmount")?1:0));f.Pc=3630;continue;}
case 3630:{f.Pc=f.Pop().Int==0?3811:3633;continue;}
case 3633:{f.Push(f.Locals[0]);f.Pc=3634;continue;}
case 3634:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordWithCostAndAmount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3637;continue;}
case 3637:{f.Locals[9]=f.Pop();f.Pc=3639;continue;}
case 3639:{f.Push(f.Locals[9]);f.Pc=3641;continue;}
case 3641:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndAmount","getCost","()Lforge/game/cost/Cost;","invokevirtual",3644);}
case 3644:{f.Locals[14]=f.Pop();f.Pc=3646;continue;}
case 3646:{f.Push(f.Locals[1]);f.Pc=3647;continue;}
case 3647:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",3650);}
case 3650:{f.Push(f.Locals[14]);f.Pc=3652;continue;}
case 3652:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithDefinedCost","(Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",3655);}
case 3655:{f.Locals[15]=f.Pop();f.Pc=3657;continue;}
case 3657:{f.Push(f.Locals[15]);f.Pc=3659;continue;}
case 3659:{f.Push(JValue.R(rt.String("PrecostDesc")));f.Pc=3662;continue;}
case 3662:{f.Push(f.Locals[9]);f.Pc=3664;continue;}
case 3664:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndAmount","getTitleWithoutCost","()Ljava/lang/String;","invokevirtual",3667);}
case 3667:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3670);}
case 3670:{f.StackOp("pop");f.Pc=3671;continue;}
case 3671:{f.Push(f.Locals[15]);f.Pc=3673;continue;}
case 3673:{f.Push(JValue.R(rt.String("CostDesc")));f.Pc=3676;continue;}
case 3676:{f.Push(f.Locals[14]);f.Pc=3678;continue;}
case 3678:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",3681);}
case 3681:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3684);}
case 3684:{f.StackOp("pop");f.Pc=3685;continue;}
case 3685:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3688;continue;}
case 3688:{f.StackOp("dup");f.Pc=3689;continue;}
case 3689:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",3692);}
case 3692:{f.Locals[16]=f.Pop();f.Pc=3694;continue;}
case 3694:{f.Push(f.Locals[16]);f.Pc=3696;continue;}
case 3696:{f.Push(f.Locals[15]);f.Pc=3698;continue;}
case 3698:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCostDescription","()Ljava/lang/String;","invokevirtual",3701);}
case 3701:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3704);}
case 3704:{f.StackOp("pop");f.Pc=3705;continue;}
case 3705:{f.Push(f.Locals[16]);f.Pc=3707;continue;}
case 3707:{f.Push(JValue.R(rt.String("(")));f.Pc=3710;continue;}
case 3710:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3713);}
case 3713:{f.Push(f.Locals[0]);f.Pc=3714;continue;}
case 3714:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",3719);}
case 3719:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3722);}
case 3722:{f.Push(JValue.R(rt.String(")")));f.Pc=3725;continue;}
case 3725:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3728);}
case 3728:{f.StackOp("pop");f.Pc=3729;continue;}
case 3729:{f.Push(f.Locals[15]);f.Pc=3731;continue;}
case 3731:{f.Push(f.Locals[16]);f.Pc=3733;continue;}
case 3733:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",3736);}
case 3736:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",3739);}
case 3739:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3742;continue;}
case 3742:{f.StackOp("dup");f.Pc=3743;continue;}
case 3743:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",3746);}
case 3746:{f.Locals[17]=f.Pop();f.Pc=3748;continue;}
case 3748:{f.Push(f.Locals[17]);f.Pc=3750;continue;}
case 3750:{f.Push(f.Locals[1]);f.Pc=3751;continue;}
case 3751:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",3754);}
case 3754:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3757);}
case 3757:{f.Push(JValue.R(rt.String(" (Impending)")));f.Pc=3760;continue;}
case 3760:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3763);}
case 3763:{f.StackOp("pop");f.Pc=3764;continue;}
case 3764:{f.Push(f.Locals[15]);f.Pc=3766;continue;}
case 3766:{f.Push(f.Locals[17]);f.Pc=3768;continue;}
case 3768:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",3771);}
case 3771:{return rt.Call(f,"forge/game/spellability/SpellAbility","setStackDescription","(Ljava/lang/String;)V","invokevirtual",3774);}
case 3774:{f.Push(f.Locals[15]);f.Pc=3776;continue;}
case 3776:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Impending","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Impending","Lforge/game/spellability/AlternativeCost;"));f.Pc=3779;continue;}
case 3779:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",3782);}
case 3782:{f.Push(f.Locals[15]);f.Pc=3784;continue;}
case 3784:{f.Push(JValue.R(rt.String("Secondary")));f.Pc=3787;continue;}
case 3787:{f.Push(JValue.R(rt.String("True")));f.Pc=3790;continue;}
case 3790:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3793);}
case 3793:{f.StackOp("pop");f.Pc=3794;continue;}
case 3794:{f.Push(f.Locals[15]);f.Pc=3796;continue;}
case 3796:{f.Push(f.Locals[2]);f.Pc=3797;continue;}
case 3797:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",3800);}
case 3800:{f.Push(f.Locals[0]);f.Pc=3801;continue;}
case 3801:{f.Push(f.Locals[15]);f.Pc=3803;continue;}
case 3803:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",3808);}
case 3808:{f.Pc=8390;continue;}
case 3811:{f.Push(f.Locals[3]);f.Pc=3812;continue;}
case 3812:{f.Push(JValue.R(rt.String("Level up")));f.Pc=3815;continue;}
case 3815:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3818);}
case 3818:{f.Pc=f.Pop().Int==0?3943:3821;continue;}
case 3821:{f.Push(f.Locals[3]);f.Pc=3822;continue;}
case 3822:{f.Push(JValue.R(rt.String(":")));f.Pc=3825;continue;}
case 3825:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",3828);}
case 3828:{f.Locals[14]=f.Pop();f.Pc=3830;continue;}
case 3830:{f.Push(f.Locals[14]);f.Pc=3832;continue;}
case 3832:{f.Push(JValue.I(1));f.Pc=3833;continue;}
case 3833:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3834;continue;}
case 3834:{f.Locals[15]=f.Pop();f.Pc=3836;continue;}
case 3836:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3839;continue;}
case 3839:{f.StackOp("dup");f.Pc=3840;continue;}
case 3840:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",3843);}
case 3843:{f.Locals[16]=f.Pop();f.Pc=3845;continue;}
case 3845:{f.Push(f.Locals[16]);f.Pc=3847;continue;}
case 3847:{f.Push(JValue.R(rt.String("AB$ PutCounter | Cost$ ")));f.Pc=3850;continue;}
case 3850:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3853);}
case 3853:{f.Push(f.Locals[15]);f.Pc=3855;continue;}
case 3855:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3858);}
case 3858:{f.Push(JValue.R(rt.String(" | PrecostDesc$ Level up | CostDesc$ ")));f.Pc=3861;continue;}
case 3861:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3864);}
case 3864:{f.StackOp("pop");f.Pc=3865;continue;}
case 3865:{f.Push(f.Locals[16]);f.Pc=3867;continue;}
case 3867:{f.Push(f.Locals[15]);f.Pc=3869;continue;}
case 3869:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",3872);}
case 3872:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3875);}
case 3875:{f.Push(JValue.R(rt.String(" | SorcerySpeed$ True | Secondary$ True")));f.Pc=3878;continue;}
case 3878:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3881);}
case 3881:{f.StackOp("pop");f.Pc=3882;continue;}
case 3882:{f.Push(f.Locals[16]);f.Pc=3884;continue;}
case 3884:{f.Push(JValue.R(rt.String("| CounterType$ LEVEL | StackDescription$ {p:You} levels up {c:Self}.")));f.Pc=3887;continue;}
case 3887:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3890);}
case 3890:{f.StackOp("pop");f.Pc=3891;continue;}
case 3891:{f.Push(f.Locals[16]);f.Pc=3893;continue;}
case 3893:{f.Push(JValue.R(rt.String(" | SpellDescription$ (")));f.Pc=3896;continue;}
case 3896:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3899);}
case 3899:{f.Push(f.Locals[0]);f.Pc=3900;continue;}
case 3900:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",3905);}
case 3905:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3908);}
case 3908:{f.Push(JValue.R(rt.String(")")));f.Pc=3911;continue;}
case 3911:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",3914);}
case 3914:{f.StackOp("pop");f.Pc=3915;continue;}
case 3915:{f.Push(f.Locals[16]);f.Pc=3917;continue;}
case 3917:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",3920);}
case 3920:{f.Push(f.Locals[1]);f.Pc=3921;continue;}
case 3921:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",3924);}
case 3924:{f.Locals[17]=f.Pop();f.Pc=3926;continue;}
case 3926:{f.Push(f.Locals[17]);f.Pc=3928;continue;}
case 3928:{f.Push(f.Locals[2]);f.Pc=3929;continue;}
case 3929:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",3932);}
case 3932:{f.Push(f.Locals[0]);f.Pc=3933;continue;}
case 3933:{f.Push(f.Locals[17]);f.Pc=3935;continue;}
case 3935:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",3940);}
case 3940:{f.Pc=8390;continue;}
case 3943:{f.Push(f.Locals[3]);f.Pc=3944;continue;}
case 3944:{f.Push(JValue.R(rt.String("Morph")));f.Pc=3947;continue;}
case 3947:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3950);}
case 3950:{f.Pc=f.Pop().Int==0?4017:3953;continue;}
case 3953:{f.Push(f.Locals[0]);f.Pc=3954;continue;}
case 3954:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/KeywordWithCost")?1:0));f.Pc=3957;continue;}
case 3957:{f.Pc=f.Pop().Int==0?4017:3960;continue;}
case 3960:{f.Push(f.Locals[0]);f.Pc=3961;continue;}
case 3961:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordWithCost"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3964;continue;}
case 3964:{f.Locals[10]=f.Pop();f.Pc=3966;continue;}
case 3966:{f.Push(f.Locals[0]);f.Pc=3967;continue;}
case 3967:{f.Push(f.Locals[1]);f.Pc=3968;continue;}
case 3968:{f.Push(f.Locals[2]);f.Pc=3969;continue;}
case 3969:{f.Push(JValue.R(rt.String("Morph")));f.Pc=3972;continue;}
case 3972:{return rt.Call(f,"forge/game/card/CardFactoryUtil","abilityCastFaceDown","(Lforge/game/card/CardState;ZLjava/lang/String;)Lforge/game/spellability/SpellAbility;","invokestatic",3975);}
case 3975:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",3980);}
case 3980:{f.Push(f.Locals[1]);f.Pc=3981;continue;}
case 3981:{f.Push(f.Locals[10]);f.Pc=3983;continue;}
case 3983:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","getCost","()Lforge/game/cost/Cost;","invokevirtual",3986);}
case 3986:{f.Push(JValue.R(rt.String("MorphUp")));f.Pc=3989;continue;}
case 3989:{f.Push(JValue.R(rt.String("Morph")));f.Pc=3992;continue;}
case 3992:{f.Push(JValue.R(rt.String("morph")));f.Pc=3995;continue;}
case 3995:{return rt.Call(f,"forge/game/card/CardFactoryUtil","abilityTurnFaceUp","(Lforge/game/card/CardState;Lforge/game/cost/Cost;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokestatic",3998);}
case 3998:{f.Locals[14]=f.Pop();f.Pc=4000;continue;}
case 4000:{f.Push(f.Locals[14]);f.Pc=4002;continue;}
case 4002:{f.Push(f.Locals[2]);f.Pc=4003;continue;}
case 4003:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",4006);}
case 4006:{f.Push(f.Locals[0]);f.Pc=4007;continue;}
case 4007:{f.Push(f.Locals[14]);f.Pc=4009;continue;}
case 4009:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",4014);}
case 4014:{f.Pc=8390;continue;}
case 4017:{f.Push(f.Locals[3]);f.Pc=4018;continue;}
case 4018:{f.Push(JValue.R(rt.String("Megamorph")));f.Pc=4021;continue;}
case 4021:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",4024);}
case 4024:{f.Pc=f.Pop().Int==0?4091:4027;continue;}
case 4027:{f.Push(f.Locals[0]);f.Pc=4028;continue;}
case 4028:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/KeywordWithCost")?1:0));f.Pc=4031;continue;}
case 4031:{f.Pc=f.Pop().Int==0?4091:4034;continue;}
case 4034:{f.Push(f.Locals[0]);f.Pc=4035;continue;}
case 4035:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordWithCost"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4038;continue;}
case 4038:{f.Locals[11]=f.Pop();f.Pc=4040;continue;}
case 4040:{f.Push(f.Locals[0]);f.Pc=4041;continue;}
case 4041:{f.Push(f.Locals[1]);f.Pc=4042;continue;}
case 4042:{f.Push(f.Locals[2]);f.Pc=4043;continue;}
case 4043:{f.Push(JValue.R(rt.String("Morph")));f.Pc=4046;continue;}
case 4046:{return rt.Call(f,"forge/game/card/CardFactoryUtil","abilityCastFaceDown","(Lforge/game/card/CardState;ZLjava/lang/String;)Lforge/game/spellability/SpellAbility;","invokestatic",4049);}
case 4049:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",4054);}
case 4054:{f.Push(f.Locals[1]);f.Pc=4055;continue;}
case 4055:{f.Push(f.Locals[11]);f.Pc=4057;continue;}
case 4057:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","getCost","()Lforge/game/cost/Cost;","invokevirtual",4060);}
case 4060:{f.Push(JValue.R(rt.String("MorphUp")));f.Pc=4063;continue;}
case 4063:{f.Push(JValue.R(rt.String("Megamorph")));f.Pc=4066;continue;}
case 4066:{f.Push(JValue.R(rt.String("morph")));f.Pc=4069;continue;}
case 4069:{return rt.Call(f,"forge/game/card/CardFactoryUtil","abilityTurnFaceUp","(Lforge/game/card/CardState;Lforge/game/cost/Cost;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokestatic",4072);}
case 4072:{f.Locals[14]=f.Pop();f.Pc=4074;continue;}
case 4074:{f.Push(f.Locals[14]);f.Pc=4076;continue;}
case 4076:{f.Push(f.Locals[2]);f.Pc=4077;continue;}
case 4077:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",4080);}
case 4080:{f.Push(f.Locals[0]);f.Pc=4081;continue;}
case 4081:{f.Push(f.Locals[14]);f.Pc=4083;continue;}
case 4083:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",4088);}
case 4088:{f.Pc=8390;continue;}
case 4091:{f.Push(f.Locals[3]);f.Pc=4092;continue;}
case 4092:{f.Push(JValue.R(rt.String("More Than Meets the Eye")));f.Pc=4095;continue;}
case 4095:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",4098);}
case 4098:{f.Pc=f.Pop().Int==0?4257:4101;continue;}
case 4101:{f.Push(f.Locals[3]);f.Pc=4102;continue;}
case 4102:{f.Push(JValue.R(rt.String(":")));f.Pc=4105;continue;}
case 4105:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",4108);}
case 4108:{f.Locals[14]=f.Pop();f.Pc=4110;continue;}
case 4110:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=4113;continue;}
case 4113:{f.StackOp("dup");f.Pc=4114;continue;}
case 4114:{f.Push(f.Locals[14]);f.Pc=4116;continue;}
case 4116:{f.Push(JValue.I(1));f.Pc=4117;continue;}
case 4117:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4118;continue;}
case 4118:{f.Push(JValue.I(0));f.Pc=4119;continue;}
case 4119:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",4122);}
case 4122:{f.Locals[15]=f.Pop();f.Pc=4124;continue;}
case 4124:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellPermanent"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellPermanent")));f.Pc=4127;continue;}
case 4127:{f.StackOp("dup");f.Pc=4128;continue;}
case 4128:{f.Push(f.Locals[4]);f.Pc=4130;continue;}
case 4130:{f.Push(f.Locals[4]);f.Pc=4132;continue;}
case 4132:{return rt.Call(f,"forge/game/card/Card","getAlternateState","()Lforge/game/card/CardState;","invokevirtual",4135);}
case 4135:{f.Push(f.Locals[15]);f.Pc=4137;continue;}
case 4137:{return rt.Call(f,"forge/game/spellability/SpellPermanent","<init>","(Lforge/game/card/Card;Lforge/game/card/CardState;Lforge/game/cost/Cost;)V","invokespecial",4140);}
case 4140:{f.Locals[16]=f.Pop();f.Pc=4142;continue;}
case 4142:{f.Push(f.Locals[16]);f.Pc=4144;continue;}
case 4144:{f.Push(f.Locals[4]);f.Pc=4146;continue;}
case 4146:{return rt.Call(f,"forge/game/card/Card","getAlternateState","()Lforge/game/card/CardState;","invokevirtual",4149);}
case 4149:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",4152);}
case 4152:{f.Push(f.Locals[0]);f.Pc=4153;continue;}
case 4153:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",4158);}
case 4158:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:4158:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",4163);}
case 4163:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",4166);}
case 4166:{f.Push(f.Locals[16]);f.Pc=4168;continue;}
case 4168:{f.Push(f.Locals[4]);f.Pc=4170;continue;}
case 4170:{return rt.Call(f,"forge/game/card/Card","getAlternateState","()Lforge/game/card/CardState;","invokevirtual",4173);}
case 4173:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",4176);}
case 4176:{f.Push(f.Locals[16]);f.Pc=4178;continue;}
case 4178:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","MTMtE","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","MTMtE","Lforge/game/spellability/AlternativeCost;"));f.Pc=4181;continue;}
case 4181:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",4184);}
case 4184:{f.Push(f.Locals[16]);f.Pc=4186;continue;}
case 4186:{f.Push(JValue.R(rt.String("Secondary")));f.Pc=4189;continue;}
case 4189:{f.Push(JValue.R(rt.String("True")));f.Pc=4192;continue;}
case 4192:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4195);}
case 4195:{f.StackOp("pop");f.Pc=4196;continue;}
case 4196:{f.Push(f.Locals[16]);f.Pc=4198;continue;}
case 4198:{f.Push(JValue.R(rt.String("PrecostDesc")));f.Pc=4201;continue;}
case 4201:{f.Push(f.Locals[14]);f.Pc=4203;continue;}
case 4203:{f.Push(JValue.I(0));f.Pc=4204;continue;}
case 4204:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4205;continue;}
case 4205:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:4205:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",4210);}
case 4210:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4213);}
case 4213:{f.StackOp("pop");f.Pc=4214;continue;}
case 4214:{f.Push(f.Locals[16]);f.Pc=4216;continue;}
case 4216:{f.Push(JValue.R(rt.String("CostDesc")));f.Pc=4219;continue;}
case 4219:{f.Push(f.Locals[15]);f.Pc=4221;continue;}
case 4221:{return rt.Call(f,"forge/game/cost/Cost","toString","()Ljava/lang/String;","invokevirtual",4224);}
case 4224:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4227);}
case 4227:{f.StackOp("pop");f.Pc=4228;continue;}
case 4228:{f.Push(f.Locals[16]);f.Pc=4230;continue;}
case 4230:{f.Push(JValue.R(rt.String("AfterDescription")));f.Pc=4233;continue;}
case 4233:{f.Push(JValue.R(rt.String("(Converted)")));f.Pc=4236;continue;}
case 4236:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4239);}
case 4239:{f.StackOp("pop");f.Pc=4240;continue;}
case 4240:{f.Push(f.Locals[16]);f.Pc=4242;continue;}
case 4242:{f.Push(f.Locals[2]);f.Pc=4243;continue;}
case 4243:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",4246);}
case 4246:{f.Push(f.Locals[0]);f.Pc=4247;continue;}
case 4247:{f.Push(f.Locals[16]);f.Pc=4249;continue;}
case 4249:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",4254);}
case 4254:{f.Pc=8390;continue;}
case 4257:{f.Push(f.Locals[3]);f.Pc=4258;continue;}
case 4258:{f.Push(JValue.R(rt.String("Mutate")));f.Pc=4261;continue;}
case 4261:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",4264);}
case 4264:{f.Pc=f.Pop().Int==0?4388:4267;continue;}
case 4267:{f.Push(f.Locals[3]);f.Pc=4268;continue;}
case 4268:{f.Push(JValue.R(rt.String(":")));f.Pc=4271;continue;}
case 4271:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",4274);}
case 4274:{f.Locals[14]=f.Pop();f.Pc=4276;continue;}
case 4276:{f.Push(f.Locals[14]);f.Pc=4278;continue;}
case 4278:{f.Push(JValue.I(1));f.Pc=4279;continue;}
case 4279:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4280;continue;}
case 4280:{f.Locals[15]=f.Pop();f.Pc=4282;continue;}
case 4282:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=4285;continue;}
case 4285:{f.StackOp("dup");f.Pc=4286;continue;}
case 4286:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",4289);}
case 4289:{f.Locals[16]=f.Pop();f.Pc=4291;continue;}
case 4291:{f.Push(f.Locals[16]);f.Pc=4293;continue;}
case 4293:{f.Push(JValue.R(rt.String("SP$ Mutate | Cost$ ")));f.Pc=4296;continue;}
case 4296:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4299);}
case 4299:{f.StackOp("pop");f.Pc=4300;continue;}
case 4300:{f.Push(f.Locals[16]);f.Pc=4302;continue;}
case 4302:{f.Push(f.Locals[15]);f.Pc=4304;continue;}
case 4304:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4307);}
case 4307:{f.StackOp("pop");f.Pc=4308;continue;}
case 4308:{f.Push(f.Locals[16]);f.Pc=4310;continue;}
case 4310:{f.Push(JValue.R(rt.String(" | ValidTgts$ Creature.sharesOwnerWith+nonHuman")));f.Pc=4313;continue;}
case 4313:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4316);}
case 4316:{f.StackOp("pop");f.Pc=4317;continue;}
case 4317:{f.Push(f.Locals[16]);f.Pc=4319;continue;}
case 4319:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",4322);}
case 4322:{f.Push(f.Locals[1]);f.Pc=4323;continue;}
case 4323:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",4326);}
case 4326:{f.Locals[17]=f.Pop();f.Pc=4328;continue;}
case 4328:{f.Push(f.Locals[17]);f.Pc=4330;continue;}
case 4330:{f.Push(f.Locals[15]);f.Pc=4332;continue;}
case 4332:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",4335);}
case 4335:{f.Push(f.Locals[0]);f.Pc=4336;continue;}
case 4336:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",4341);}
case 4341:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:4341:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",4346);}
case 4346:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",4349);}
case 4349:{f.Push(f.Locals[17]);f.Pc=4351;continue;}
case 4351:{f.Push(f.Locals[1]);f.Pc=4352;continue;}
case 4352:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",4355);}
case 4355:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:4355:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",4360);}
case 4360:{return rt.Call(f,"forge/game/spellability/SpellAbility","setStackDescription","(Ljava/lang/String;)V","invokevirtual",4363);}
case 4363:{f.Push(f.Locals[17]);f.Pc=4365;continue;}
case 4365:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Mutate","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Mutate","Lforge/game/spellability/AlternativeCost;"));f.Pc=4368;continue;}
case 4368:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",4371);}
case 4371:{f.Push(f.Locals[17]);f.Pc=4373;continue;}
case 4373:{f.Push(f.Locals[2]);f.Pc=4374;continue;}
case 4374:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",4377);}
case 4377:{f.Push(f.Locals[0]);f.Pc=4378;continue;}
case 4378:{f.Push(f.Locals[17]);f.Pc=4380;continue;}
case 4380:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",4385);}
case 4385:{f.Pc=8390;continue;}
case 4388:{f.Push(f.Locals[3]);f.Pc=4389;continue;}
case 4389:{f.Push(JValue.R(rt.String("Ninjutsu")));f.Pc=4392;continue;}
case 4392:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",4395);}
case 4395:{f.Pc=f.Pop().Int==0?4549:4398;continue;}
case 4398:{f.Push(f.Locals[3]);f.Pc=4399;continue;}
case 4399:{f.Push(JValue.R(rt.String(":")));f.Pc=4402;continue;}
case 4402:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",4405);}
case 4405:{f.Locals[14]=f.Pop();f.Pc=4407;continue;}
case 4407:{f.Push(f.Locals[14]);f.Pc=4409;continue;}
case 4409:{f.Push(JValue.I(1));f.Pc=4410;continue;}
case 4410:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4411;continue;}
case 4411:{f.Locals[15]=f.Pop();f.Pc=4413;continue;}
case 4413:{f.Push(JValue.R(rt.String("Ninjutsu")));f.Pc=4416;continue;}
case 4416:{f.Locals[16]=f.Pop();f.Pc=4418;continue;}
case 4418:{f.Push(JValue.I(0));f.Pc=4419;continue;}
case 4419:{f.Locals[17]=f.Pop();f.Pc=4421;continue;}
case 4421:{f.Push(f.Locals[14]);f.Pc=4423;continue;}
case 4423:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4424;continue;}
case 4424:{f.Push(JValue.I(2));f.Pc=4425;continue;}
case 4425:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?4453:4428;continue;}
case 4428:{f.Push(f.Locals[14]);f.Pc=4430;continue;}
case 4430:{f.Push(JValue.I(2));f.Pc=4431;continue;}
case 4431:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4432;continue;}
case 4432:{f.Push(JValue.R(rt.String("Commander")));f.Pc=4435;continue;}
case 4435:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",4438);}
case 4438:{f.Pc=f.Pop().Int==0?4453:4441;continue;}
case 4441:{f.Push(f.Locals[16]);f.Pc=4443;continue;}
case 4443:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:4443:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",4448);}
case 4448:{f.Locals[16]=f.Pop();f.Pc=4450;continue;}
case 4450:{f.Push(JValue.I(1));f.Pc=4451;continue;}
case 4451:{f.Locals[17]=f.Pop();f.Pc=4453;continue;}
case 4453:{f.Push(f.Locals[15]);f.Pc=4455;continue;}
case 4455:{f.Push(f.Locals[16]);f.Pc=4457;continue;}
case 4457:{f.Push(f.Locals[15]);f.Pc=4459;continue;}
case 4459:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",4462);}
case 4462:{f.Push(f.Locals[0]);f.Pc=4463;continue;}
case 4463:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",4468);}
case 4468:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:4468:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",4473);}
case 4473:{f.Locals[18]=f.Pop();f.Pc=4475;continue;}
case 4475:{f.Push(f.Locals[18]);f.Pc=4477;continue;}
case 4477:{f.Push(f.Locals[1]);f.Pc=4478;continue;}
case 4478:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",4481);}
case 4481:{f.Locals[19]=f.Pop();f.Pc=4483;continue;}
case 4483:{f.Push(f.Locals[19]);f.Pc=4485;continue;}
case 4485:{f.Push(f.Locals[2]);f.Pc=4486;continue;}
case 4486:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",4489);}
case 4489:{f.Push(f.Locals[0]);f.Pc=4490;continue;}
case 4490:{f.Push(f.Locals[19]);f.Pc=4492;continue;}
case 4492:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",4497);}
case 4497:{f.Push(f.Locals[17]);f.Pc=4499;continue;}
case 4499:{f.Pc=f.Pop().Int==0?4546:4502;continue;}
case 4502:{f.Push(f.Locals[15]);f.Pc=4504;continue;}
case 4504:{f.Push(f.Locals[16]);f.Pc=4506;continue;}
case 4506:{f.Push(f.Locals[15]);f.Pc=4508;continue;}
case 4508:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",4511);}
case 4511:{f.Push(f.Locals[0]);f.Pc=4512;continue;}
case 4512:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",4517);}
case 4517:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:4517:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",4522);}
case 4522:{f.Locals[18]=f.Pop();f.Pc=4524;continue;}
case 4524:{f.Push(f.Locals[18]);f.Pc=4526;continue;}
case 4526:{f.Push(f.Locals[1]);f.Pc=4527;continue;}
case 4527:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",4530);}
case 4530:{f.Locals[19]=f.Pop();f.Pc=4532;continue;}
case 4532:{f.Push(f.Locals[19]);f.Pc=4534;continue;}
case 4534:{f.Push(f.Locals[2]);f.Pc=4535;continue;}
case 4535:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",4538);}
case 4538:{f.Push(f.Locals[0]);f.Pc=4539;continue;}
case 4539:{f.Push(f.Locals[19]);f.Pc=4541;continue;}
case 4541:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",4546);}
case 4546:{f.Pc=8390;continue;}
case 4549:{f.Push(f.Locals[3]);f.Pc=4550;continue;}
case 4550:{f.Push(JValue.R(rt.String("Outlast")));f.Pc=4553;continue;}
case 4553:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",4556);}
case 4556:{f.Pc=f.Pop().Int==0?4728:4559;continue;}
case 4559:{f.Push(f.Locals[3]);f.Pc=4560;continue;}
case 4560:{f.Push(JValue.R(rt.String(":")));f.Pc=4563;continue;}
case 4563:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",4566);}
case 4566:{f.Locals[14]=f.Pop();f.Pc=4568;continue;}
case 4568:{f.Push(f.Locals[14]);f.Pc=4570;continue;}
case 4570:{f.Push(JValue.I(1));f.Pc=4571;continue;}
case 4571:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4572;continue;}
case 4572:{f.Locals[15]=f.Pop();f.Pc=4574;continue;}
case 4574:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=4577;continue;}
case 4577:{f.StackOp("dup");f.Pc=4578;continue;}
case 4578:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",4581);}
case 4581:{f.Locals[16]=f.Pop();f.Pc=4583;continue;}
case 4583:{f.Push(f.Locals[16]);f.Pc=4585;continue;}
case 4585:{f.Push(JValue.R(rt.String("AB$ PutCounter | Cost$ ")));f.Pc=4588;continue;}
case 4588:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4591);}
case 4591:{f.StackOp("pop");f.Pc=4592;continue;}
case 4592:{f.Push(f.Locals[16]);f.Pc=4594;continue;}
case 4594:{f.Push(f.Locals[15]);f.Pc=4596;continue;}
case 4596:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4599);}
case 4599:{f.StackOp("pop");f.Pc=4600;continue;}
case 4600:{f.Push(f.Locals[16]);f.Pc=4602;continue;}
case 4602:{f.Push(JValue.R(rt.String(" T | Defined$ Self | CounterType$ P1P1 | CounterNum$ 1 ")));f.Pc=4605;continue;}
case 4605:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4608);}
case 4608:{f.StackOp("pop");f.Pc=4609;continue;}
case 4609:{f.Push(f.Locals[16]);f.Pc=4611;continue;}
case 4611:{f.Push(JValue.R(rt.String("| SorcerySpeed$ True | PrecostDesc$ Outlast")));f.Pc=4614;continue;}
case 4614:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4617);}
case 4617:{f.StackOp("pop");f.Pc=4618;continue;}
case 4618:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=4621;continue;}
case 4621:{f.StackOp("dup");f.Pc=4622;continue;}
case 4622:{f.Push(f.Locals[15]);f.Pc=4624;continue;}
case 4624:{f.Push(JValue.I(1));f.Pc=4625;continue;}
case 4625:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",4628);}
case 4628:{f.Locals[17]=f.Pop();f.Pc=4630;continue;}
case 4630:{f.Push(f.Locals[17]);f.Pc=4632;continue;}
case 4632:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",4635);}
case 4635:{f.Pc=f.Pop().Int!=0?4650:4638;continue;}
case 4638:{f.Push(f.Locals[16]);f.Pc=4640;continue;}
case 4640:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=4643;continue;}
case 4643:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4646);}
case 4646:{f.StackOp("pop");f.Pc=4647;continue;}
case 4647:{f.Pc=4659;continue;}
case 4650:{f.Push(f.Locals[16]);f.Pc=4652;continue;}
case 4652:{f.Push(JValue.R(rt.String(" ")));f.Pc=4655;continue;}
case 4655:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4658);}
case 4658:{f.StackOp("pop");f.Pc=4659;continue;}
case 4659:{f.Push(f.Locals[16]);f.Pc=4661;continue;}
case 4661:{f.Push(JValue.R(rt.String("| CostDesc$ ")));f.Pc=4664;continue;}
case 4664:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4667);}
case 4667:{f.Push(f.Locals[17]);f.Pc=4669;continue;}
case 4669:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",4672);}
case 4672:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4675);}
case 4675:{f.StackOp("pop");f.Pc=4676;continue;}
case 4676:{f.Push(f.Locals[16]);f.Pc=4678;continue;}
case 4678:{f.Push(JValue.R(rt.String(" | SpellDescription$ (")));f.Pc=4681;continue;}
case 4681:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4684);}
case 4684:{f.Push(f.Locals[0]);f.Pc=4685;continue;}
case 4685:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",4690);}
case 4690:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4693);}
case 4693:{f.Push(JValue.R(rt.String(")")));f.Pc=4696;continue;}
case 4696:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",4699);}
case 4699:{f.StackOp("pop");f.Pc=4700;continue;}
case 4700:{f.Push(f.Locals[16]);f.Pc=4702;continue;}
case 4702:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",4705);}
case 4705:{f.Push(f.Locals[1]);f.Pc=4706;continue;}
case 4706:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",4709);}
case 4709:{f.Locals[18]=f.Pop();f.Pc=4711;continue;}
case 4711:{f.Push(f.Locals[18]);f.Pc=4713;continue;}
case 4713:{f.Push(f.Locals[2]);f.Pc=4714;continue;}
case 4714:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",4717);}
case 4717:{f.Push(f.Locals[0]);f.Pc=4718;continue;}
case 4718:{f.Push(f.Locals[18]);f.Pc=4720;continue;}
case 4720:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",4725);}
case 4725:{f.Pc=8390;continue;}
case 4728:{f.Push(f.Locals[3]);f.Pc=4729;continue;}
case 4729:{f.Push(JValue.R(rt.String("Overload")));f.Pc=4732;continue;}
case 4732:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",4735);}
case 4735:{f.Pc=f.Pop().Int==0?5086:4738;continue;}
case 4738:{f.Push(f.Locals[3]);f.Pc=4739;continue;}
case 4739:{f.Push(JValue.R(rt.String(":")));f.Pc=4742;continue;}
case 4742:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",4745);}
case 4745:{f.Locals[14]=f.Pop();f.Pc=4747;continue;}
case 4747:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=4750;continue;}
case 4750:{f.StackOp("dup");f.Pc=4751;continue;}
case 4751:{f.Push(f.Locals[14]);f.Pc=4753;continue;}
case 4753:{f.Push(JValue.I(1));f.Pc=4754;continue;}
case 4754:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4755;continue;}
case 4755:{f.Push(JValue.I(0));f.Pc=4756;continue;}
case 4756:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",4759);}
case 4759:{f.Locals[15]=f.Pop();f.Pc=4761;continue;}
case 4761:{f.Push(f.Locals[1]);f.Pc=4762;continue;}
case 4762:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",4765);}
case 4765:{f.Push(f.Locals[15]);f.Pc=4767;continue;}
case 4767:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithDefinedCost","(Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",4770);}
case 4770:{f.Locals[16]=f.Pop();f.Pc=4772;continue;}
case 4772:{f.Push(f.Locals[16]);f.Pc=4774;continue;}
case 4774:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",4777);}
case 4777:{f.Locals[17]=f.Pop();f.Pc=4779;continue;}
case 4779:{f.Push(JValue.R(rt.String(",")));f.Pc=4782;continue;}
case 4782:{f.Push(f.Locals[17]);f.Pc=4784;continue;}
case 4784:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getValidTgts","()[Ljava/lang/String;","invokevirtual",4787);}
case 4787:{return rt.Call(f,"java/lang/String","join","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;","invokestatic",4790);}
case 4790:{f.Locals[18]=f.Pop();f.Pc=4792;continue;}
case 4792:{f.Push(f.Locals[17]);f.Pc=4794;continue;}
case 4794:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","canTgtPlayer","()Z","invokevirtual",4797);}
case 4797:{f.Pc=f.Pop().Int==0?4814:4800;continue;}
case 4800:{f.Push(f.Locals[16]);f.Pc=4802;continue;}
case 4802:{f.Push(JValue.R(rt.String("Defined")));f.Pc=4805;continue;}
case 4805:{f.Push(f.Locals[18]);f.Pc=4807;continue;}
case 4807:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4810);}
case 4810:{f.StackOp("pop");f.Pc=4811;continue;}
case 4811:{f.Pc=4894;continue;}
case 4814:{f.Push(JValue.R(rt.String("")));f.Pc=4817;continue;}
case 4817:{f.Locals[19]=f.Pop();f.Pc=4819;continue;}
case 4819:{f.Push(f.Locals[17]);f.Pc=4821;continue;}
case 4821:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getZone","()Ljava/util/List;","invokevirtual",4824);}
case 4824:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=4827;continue;}
case 4827:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",4832);}
case 4832:{f.Pc=f.Pop().Int!=0?4848:4835;continue;}
case 4835:{f.Push(f.Locals[17]);f.Pc=4837;continue;}
case 4837:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getZone","()Ljava/util/List;","invokevirtual",4840);}
case 4840:{f.Push(JValue.R(rt.String(",")));f.Pc=4843;continue;}
case 4843:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",4846);}
case 4846:{f.Locals[19]=f.Pop();f.Pc=4848;continue;}
case 4848:{f.Push(f.Locals[16]);f.Pc=4850;continue;}
case 4850:{f.Push(JValue.R(rt.String("TargetType")));f.Pc=4853;continue;}
case 4853:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",4856);}
case 4856:{f.Pc=f.Pop().Int==0?4876:4859;continue;}
case 4859:{f.Push(f.Locals[18]);f.Pc=4861;continue;}
case 4861:{f.Push(JValue.R(rt.String("Card")));f.Pc=4863;continue;}
case 4863:{f.Push(f.Locals[16]);f.Pc=4865;continue;}
case 4865:{f.Push(JValue.R(rt.String("TargetType")));f.Pc=4868;continue;}
case 4868:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4871);}
case 4871:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4874);}
case 4874:{f.Locals[18]=f.Pop();f.Pc=4876;continue;}
case 4876:{f.Push(f.Locals[16]);f.Pc=4878;continue;}
case 4878:{f.Push(JValue.R(rt.String("Defined")));f.Pc=4881;continue;}
case 4881:{f.Push(f.Locals[19]);f.Pc=4883;continue;}
case 4883:{f.Push(f.Locals[18]);f.Pc=4885;continue;}
case 4885:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:4885:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",4890);}
case 4890:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4893);}
case 4893:{f.StackOp("pop");f.Pc=4894;continue;}
case 4894:{f.Push(f.Locals[16]);f.Pc=4896;continue;}
case 4896:{f.Push(JValue.R(null));f.Pc=4897;continue;}
case 4897:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTargetRestrictions","(Lforge/game/spellability/TargetRestrictions;)V","invokevirtual",4900);}
case 4900:{f.Push(f.Locals[4]);f.Pc=4902;continue;}
case 4902:{return rt.Call(f,"forge/game/card/Card","isInstant","()Z","invokevirtual",4905);}
case 4905:{f.Pc=f.Pop().Int!=0?4916:4908;continue;}
case 4908:{f.Push(f.Locals[4]);f.Pc=4910;continue;}
case 4910:{return rt.Call(f,"forge/game/card/Card","isSorcery","()Z","invokevirtual",4913);}
case 4913:{f.Pc=f.Pop().Int==0?4928:4916;continue;}
case 4916:{f.Push(f.Locals[16]);f.Pc=4918;continue;}
case 4918:{f.Push(JValue.R(rt.String("Secondary")));f.Pc=4921;continue;}
case 4921:{f.Push(JValue.R(rt.String("True")));f.Pc=4924;continue;}
case 4924:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4927);}
case 4927:{f.StackOp("pop");f.Pc=4928;continue;}
case 4928:{f.Push(f.Locals[16]);f.Pc=4930;continue;}
case 4930:{f.Push(JValue.R(rt.String("PrecostDesc")));f.Pc=4933;continue;}
case 4933:{f.Push(JValue.R(rt.String("Overload")));f.Pc=4936;continue;}
case 4936:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4939);}
case 4939:{f.StackOp("pop");f.Pc=4940;continue;}
case 4940:{f.Push(f.Locals[16]);f.Pc=4942;continue;}
case 4942:{f.Push(JValue.R(rt.String("CostDesc")));f.Pc=4945;continue;}
case 4945:{f.Push(f.Locals[14]);f.Pc=4947;continue;}
case 4947:{f.Push(JValue.I(1));f.Pc=4948;continue;}
case 4948:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4949;continue;}
case 4949:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",4952);}
case 4952:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4955);}
case 4955:{f.StackOp("pop");f.Pc=4956;continue;}
case 4956:{f.Push(f.Locals[16]);f.Pc=4958;continue;}
case 4958:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",4961);}
case 4961:{f.Push(JValue.R(rt.String("Target")));f.Pc=4964;continue;}
case 4964:{f.Push(JValue.R(rt.String("Each")));f.Pc=4967;continue;}
case 4967:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4970);}
case 4970:{f.Push(JValue.R(rt.String("target")));f.Pc=4973;continue;}
case 4973:{f.Push(JValue.R(rt.String("each")));f.Pc=4976;continue;}
case 4976:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4979);}
case 4979:{f.Locals[19]=f.Pop();f.Pc=4981;continue;}
case 4981:{f.Push(f.Locals[16]);f.Pc=4983;continue;}
case 4983:{f.Push(JValue.R(rt.String("StackDescription")));f.Pc=4986;continue;}
case 4986:{f.Push(f.Locals[19]);f.Pc=4988;continue;}
case 4988:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4991);}
case 4991:{f.StackOp("pop");f.Pc=4992;continue;}
case 4992:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=4995;continue;}
case 4995:{f.StackOp("dup");f.Pc=4996;continue;}
case 4996:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",4999);}
case 4999:{f.Locals[20]=f.Pop();f.Pc=5001;continue;}
case 5001:{f.Push(f.Locals[20]);f.Pc=5003;continue;}
case 5003:{f.Push(f.Locals[16]);f.Pc=5005;continue;}
case 5005:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCostDescription","()Ljava/lang/String;","invokevirtual",5008);}
case 5008:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5011);}
case 5011:{f.StackOp("pop");f.Pc=5012;continue;}
case 5012:{f.Push(f.Locals[20]);f.Pc=5014;continue;}
case 5014:{f.Push(JValue.R(rt.String("(")));f.Pc=5017;continue;}
case 5017:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5020);}
case 5020:{f.Push(f.Locals[0]);f.Pc=5021;continue;}
case 5021:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",5026);}
case 5026:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5029);}
case 5029:{f.Push(JValue.R(rt.String(")")));f.Pc=5032;continue;}
case 5032:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5035);}
case 5035:{f.StackOp("pop");f.Pc=5036;continue;}
case 5036:{f.Push(f.Locals[16]);f.Pc=5038;continue;}
case 5038:{f.Push(f.Locals[20]);f.Pc=5040;continue;}
case 5040:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",5043);}
case 5043:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",5046);}
case 5046:{f.Push(f.Locals[16]);f.Pc=5048;continue;}
case 5048:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalMapParams","()Ljava/util/Map;","invokevirtual",5051);}
case 5051:{f.Push(f.Locals[16]);f.Pc=5053;continue;}
case 5053:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",5056);}
case 5056:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",5061);}
case 5061:{f.Push(f.Locals[16]);f.Pc=5063;continue;}
case 5063:{f.Push(f.Locals[2]);f.Pc=5064;continue;}
case 5064:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",5067);}
case 5067:{f.Push(f.Locals[16]);f.Pc=5069;continue;}
case 5069:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Overload","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Overload","Lforge/game/spellability/AlternativeCost;"));f.Pc=5072;continue;}
case 5072:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",5075);}
case 5075:{f.Push(f.Locals[0]);f.Pc=5076;continue;}
case 5076:{f.Push(f.Locals[16]);f.Pc=5078;continue;}
case 5078:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",5083);}
case 5083:{f.Pc=8390;continue;}
case 5086:{f.Push(f.Locals[3]);f.Pc=5087;continue;}
case 5087:{f.Push(JValue.R(rt.String("Paradigm")));f.Pc=5090;continue;}
case 5090:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5093);}
case 5093:{f.Pc=f.Pop().Int==0?5187:5096;continue;}
case 5096:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self | Origin$ Stack | Destination$ Exile")));f.Pc=5099;continue;}
case 5099:{f.Locals[14]=f.Pop();f.Pc=5101;continue;}
case 5101:{f.Push(f.Locals[14]);f.Pc=5103;continue;}
case 5103:{f.Push(f.Locals[1]);f.Pc=5104;continue;}
case 5104:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",5107);}
case 5107:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5110;continue;}
case 5110:{f.Locals[15]=f.Pop();f.Pc=5112;continue;}
case 5112:{f.Push(f.Locals[1]);f.Pc=5113;continue;}
case 5113:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",5116);}
case 5116:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:5116:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",5121);}
case 5121:{f.Locals[16]=f.Pop();f.Pc=5123;continue;}
case 5123:{f.Push(f.Locals[16]);f.Pc=5125;continue;}
case 5125:{f.Push(f.Locals[1]);f.Pc=5126;continue;}
case 5126:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",5129);}
case 5129:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5132;continue;}
case 5132:{f.Locals[17]=f.Pop();f.Pc=5134;continue;}
case 5134:{f.Push(f.Locals[17]);f.Pc=5136;continue;}
case 5136:{f.Push(JValue.R(rt.String("ParadigmTrigger")));f.Pc=5139;continue;}
case 5139:{f.Push(f.Locals[0]);f.Pc=5140;continue;}
case 5140:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",5145);}
case 5145:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:5145:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",5150);}
case 5150:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",5153);}
case 5153:{f.Push(f.Locals[17]);f.Pc=5155;continue;}
case 5155:{f.Push(JValue.R(rt.String("ParadigmCopy")));f.Pc=5158;continue;}
case 5158:{f.Push(JValue.R(rt.String("DB$ Play | Defined$ EffectSource | ValidSA$ Spell | ZoneRegardless$ True | WithoutManaCost$ True | Optional$ True | CopyCard$ True")));f.Pc=5161;continue;}
case 5161:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",5164);}
case 5164:{f.Push(f.Locals[15]);f.Pc=5166;continue;}
case 5166:{f.Push(f.Locals[17]);f.Pc=5168;continue;}
case 5168:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",5171);}
case 5171:{f.Push(f.Locals[1]);f.Pc=5172;continue;}
case 5172:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",5175);}
case 5175:{f.Locals[18]=f.Pop();f.Pc=5177;continue;}
case 5177:{f.Push(f.Locals[18]);f.Pc=5179;continue;}
case 5179:{f.Push(f.Locals[15]);f.Pc=5181;continue;}
case 5181:{return rt.Call(f,"forge/game/spellability/SpellAbility","appendSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",5184);}
case 5184:{f.Pc=8390;continue;}
case 5187:{f.Push(f.Locals[3]);f.Pc=5188;continue;}
case 5188:{f.Push(JValue.R(rt.String("Plot")));f.Pc=5191;continue;}
case 5191:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",5194);}
case 5194:{f.Pc=f.Pop().Int==0?5323:5197;continue;}
case 5197:{f.Push(f.Locals[3]);f.Pc=5198;continue;}
case 5198:{f.Push(JValue.R(rt.String(":")));f.Pc=5201;continue;}
case 5201:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",5204);}
case 5204:{f.Locals[14]=f.Pop();f.Pc=5206;continue;}
case 5206:{f.Push(f.Locals[14]);f.Pc=5208;continue;}
case 5208:{f.Push(JValue.I(1));f.Pc=5209;continue;}
case 5209:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5210;continue;}
case 5210:{f.Locals[15]=f.Pop();f.Pc=5212;continue;}
case 5212:{if(!rt.EnsureInitialized(f,"forge/game/card/CardFactoryUtil$5"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardFactoryUtil$5")));f.Pc=5215;continue;}
case 5215:{f.StackOp("dup");f.Pc=5216;continue;}
case 5216:{f.Push(f.Locals[1]);f.Pc=5217;continue;}
case 5217:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",5220);}
case 5220:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=5223;continue;}
case 5223:{f.StackOp("dup");f.Pc=5224;continue;}
case 5224:{f.Push(f.Locals[15]);f.Pc=5226;continue;}
case 5226:{f.Push(JValue.I(0));f.Pc=5227;continue;}
case 5227:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",5230);}
case 5230:{f.Push(JValue.R(null));f.Pc=5231;continue;}
case 5231:{return rt.Call(f,"forge/game/card/CardFactoryUtil$5","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;)V","invokespecial",5234);}
case 5234:{f.Locals[16]=f.Pop();f.Pc=5236;continue;}
case 5236:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=5239;continue;}
case 5239:{f.StackOp("dup");f.Pc=5240;continue;}
case 5240:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",5243);}
case 5243:{f.Locals[17]=f.Pop();f.Pc=5245;continue;}
case 5245:{f.Push(f.Locals[17]);f.Pc=5247;continue;}
case 5247:{f.Push(JValue.R(rt.String("Plot (")));f.Pc=5250;continue;}
case 5250:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5253);}
case 5253:{f.Push(f.Locals[0]);f.Pc=5254;continue;}
case 5254:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",5259);}
case 5259:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5262);}
case 5262:{f.Push(JValue.R(rt.String(")")));f.Pc=5265;continue;}
case 5265:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5268);}
case 5268:{f.StackOp("pop");f.Pc=5269;continue;}
case 5269:{f.Push(f.Locals[16]);f.Pc=5271;continue;}
case 5271:{f.Push(f.Locals[17]);f.Pc=5273;continue;}
case 5273:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",5276);}
case 5276:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",5279);}
case 5279:{f.Push(f.Locals[16]);f.Pc=5281;continue;}
case 5281:{f.Push(JValue.R(rt.String("Secondary")));f.Pc=5284;continue;}
case 5284:{f.Push(JValue.R(rt.String("True")));f.Pc=5287;continue;}
case 5287:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5290);}
case 5290:{f.StackOp("pop");f.Pc=5291;continue;}
case 5291:{f.Push(f.Locals[16]);f.Pc=5293;continue;}
case 5293:{f.Push(f.Locals[1]);f.Pc=5294;continue;}
case 5294:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",5297);}
case 5297:{f.Push(f.Locals[16]);f.Pc=5299;continue;}
case 5299:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",5302);}
case 5302:{f.Push(JValue.I(1));f.Pc=5303;continue;}
case 5303:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setSorcerySpeed","(Z)V","invokevirtual",5306);}
case 5306:{f.Push(f.Locals[16]);f.Pc=5308;continue;}
case 5308:{f.Push(f.Locals[2]);f.Pc=5309;continue;}
case 5309:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",5312);}
case 5312:{f.Push(f.Locals[0]);f.Pc=5313;continue;}
case 5313:{f.Push(f.Locals[16]);f.Pc=5315;continue;}
case 5315:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",5320);}
case 5320:{f.Pc=8390;continue;}
case 5323:{f.Push(f.Locals[3]);f.Pc=5324;continue;}
case 5324:{f.Push(JValue.R(rt.String("Prototype")));f.Pc=5327;continue;}
case 5327:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",5330);}
case 5330:{f.Pc=f.Pop().Int==0?5514:5333;continue;}
case 5333:{f.Push(f.Locals[3]);f.Pc=5334;continue;}
case 5334:{f.Push(JValue.R(rt.String(":")));f.Pc=5337;continue;}
case 5337:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",5340);}
case 5340:{f.Locals[14]=f.Pop();f.Pc=5342;continue;}
case 5342:{f.Push(f.Locals[14]);f.Pc=5344;continue;}
case 5344:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=5345;continue;}
case 5345:{f.Push(JValue.I(4));f.Pc=5346;continue;}
case 5346:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?5365:5349;continue;}
case 5349:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=5352;continue;}
case 5352:{f.Push(f.Locals[1]);f.Pc=5353;continue;}
case 5353:{return rt.Call(f,"forge/game/card/CardState","toString","()Ljava/lang/String;","invokevirtual",5356);}
case 5356:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:5356:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",5361);}
case 5361:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",5364);}
case 5364:{return JStep.ReturnVoid;}
case 5365:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=5368;continue;}
case 5368:{f.StackOp("dup");f.Pc=5369;continue;}
case 5369:{f.Push(f.Locals[14]);f.Pc=5371;continue;}
case 5371:{f.Push(JValue.I(1));f.Pc=5372;continue;}
case 5372:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5373;continue;}
case 5373:{f.Push(JValue.I(0));f.Pc=5374;continue;}
case 5374:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",5377);}
case 5377:{f.Locals[15]=f.Pop();f.Pc=5379;continue;}
case 5379:{f.Push(f.Locals[1]);f.Pc=5380;continue;}
case 5380:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",5383);}
case 5383:{f.Push(f.Locals[15]);f.Pc=5385;continue;}
case 5385:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithDefinedCost","(Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",5388);}
case 5388:{f.Locals[16]=f.Pop();f.Pc=5390;continue;}
case 5390:{f.Push(f.Locals[16]);f.Pc=5392;continue;}
case 5392:{f.Push(JValue.R(rt.String("SetManaCost")));f.Pc=5395;continue;}
case 5395:{f.Push(f.Locals[14]);f.Pc=5397;continue;}
case 5397:{f.Push(JValue.I(1));f.Pc=5398;continue;}
case 5398:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5399;continue;}
case 5399:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5402);}
case 5402:{f.StackOp("pop");f.Pc=5403;continue;}
case 5403:{f.Push(f.Locals[16]);f.Pc=5405;continue;}
case 5405:{f.Push(JValue.R(rt.String("SetColorByManaCost")));f.Pc=5408;continue;}
case 5408:{f.Push(JValue.R(rt.String("True")));f.Pc=5411;continue;}
case 5411:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5414);}
case 5414:{f.StackOp("pop");f.Pc=5415;continue;}
case 5415:{f.Push(f.Locals[16]);f.Pc=5417;continue;}
case 5417:{f.Push(JValue.R(rt.String("SetPower")));f.Pc=5420;continue;}
case 5420:{f.Push(f.Locals[14]);f.Pc=5422;continue;}
case 5422:{f.Push(JValue.I(2));f.Pc=5423;continue;}
case 5423:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5424;continue;}
case 5424:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5427);}
case 5427:{f.StackOp("pop");f.Pc=5428;continue;}
case 5428:{f.Push(f.Locals[16]);f.Pc=5430;continue;}
case 5430:{f.Push(JValue.R(rt.String("SetToughness")));f.Pc=5433;continue;}
case 5433:{f.Push(f.Locals[14]);f.Pc=5435;continue;}
case 5435:{f.Push(JValue.I(3));f.Pc=5436;continue;}
case 5436:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5437;continue;}
case 5437:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5440);}
case 5440:{f.StackOp("pop");f.Pc=5441;continue;}
case 5441:{f.Push(f.Locals[16]);f.Pc=5443;continue;}
case 5443:{f.Push(JValue.R(rt.String("Prototype")));f.Pc=5446;continue;}
case 5446:{f.Push(JValue.R(rt.String("True")));f.Pc=5449;continue;}
case 5449:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5452);}
case 5452:{f.StackOp("pop");f.Pc=5453;continue;}
case 5453:{f.Push(f.Locals[16]);f.Pc=5455;continue;}
case 5455:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalMapParams","()Ljava/util/Map;","invokevirtual",5458);}
case 5458:{f.Push(f.Locals[16]);f.Pc=5460;continue;}
case 5460:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",5463);}
case 5463:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",5468);}
case 5468:{f.Push(f.Locals[16]);f.Pc=5470;continue;}
case 5470:{f.Push(f.Locals[14]);f.Pc=5472;continue;}
case 5472:{f.Push(JValue.I(0));f.Pc=5473;continue;}
case 5473:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5474;continue;}
case 5474:{f.Push(f.Locals[14]);f.Pc=5476;continue;}
case 5476:{f.Push(JValue.I(1));f.Pc=5477;continue;}
case 5477:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5478;continue;}
case 5478:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",5481);}
case 5481:{f.Push(f.Locals[14]);f.Pc=5483;continue;}
case 5483:{f.Push(JValue.I(2));f.Pc=5484;continue;}
case 5484:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5485;continue;}
case 5485:{f.Push(f.Locals[14]);f.Pc=5487;continue;}
case 5487:{f.Push(JValue.I(3));f.Pc=5488;continue;}
case 5488:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5489;continue;}
case 5489:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:5489:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",5494);}
case 5494:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",5497);}
case 5497:{f.Push(f.Locals[16]);f.Pc=5499;continue;}
case 5499:{f.Push(f.Locals[2]);f.Pc=5500;continue;}
case 5500:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",5503);}
case 5503:{f.Push(f.Locals[0]);f.Pc=5504;continue;}
case 5504:{f.Push(f.Locals[16]);f.Pc=5506;continue;}
case 5506:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",5511);}
case 5511:{f.Pc=8390;continue;}
case 5514:{f.Push(f.Locals[3]);f.Pc=5515;continue;}
case 5515:{f.Push(JValue.R(rt.String("Prowl")));f.Pc=5518;continue;}
case 5518:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",5521);}
case 5521:{f.Pc=f.Pop().Int==0?5693:5524;continue;}
case 5524:{f.Push(f.Locals[3]);f.Pc=5525;continue;}
case 5525:{f.Push(JValue.R(rt.String(":")));f.Pc=5528;continue;}
case 5528:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",5531);}
case 5531:{f.Locals[14]=f.Pop();f.Pc=5533;continue;}
case 5533:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=5536;continue;}
case 5536:{f.StackOp("dup");f.Pc=5537;continue;}
case 5537:{f.Push(f.Locals[14]);f.Pc=5539;continue;}
case 5539:{f.Push(JValue.I(1));f.Pc=5540;continue;}
case 5540:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5541;continue;}
case 5541:{f.Push(JValue.I(0));f.Pc=5542;continue;}
case 5542:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",5545);}
case 5545:{f.Locals[15]=f.Pop();f.Pc=5547;continue;}
case 5547:{f.Push(f.Locals[1]);f.Pc=5548;continue;}
case 5548:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbilityWithFallback","()Lforge/game/spellability/SpellAbility;","invokevirtual",5551);}
case 5551:{f.Push(f.Locals[15]);f.Pc=5553;continue;}
case 5553:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithDefinedCost","(Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",5556);}
case 5556:{f.Locals[16]=f.Pop();f.Pc=5558;continue;}
case 5558:{f.Push(f.Locals[4]);f.Pc=5560;continue;}
case 5560:{return rt.Call(f,"forge/game/card/Card","isInstant","()Z","invokevirtual",5563);}
case 5563:{f.Pc=f.Pop().Int!=0?5574:5566;continue;}
case 5566:{f.Push(f.Locals[4]);f.Pc=5568;continue;}
case 5568:{return rt.Call(f,"forge/game/card/Card","isSorcery","()Z","invokevirtual",5571);}
case 5571:{f.Pc=f.Pop().Int==0?5586:5574;continue;}
case 5574:{f.Push(f.Locals[16]);f.Pc=5576;continue;}
case 5576:{f.Push(JValue.R(rt.String("Secondary")));f.Pc=5579;continue;}
case 5579:{f.Push(JValue.R(rt.String("True")));f.Pc=5582;continue;}
case 5582:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5585);}
case 5585:{f.StackOp("pop");f.Pc=5586;continue;}
case 5586:{f.Push(f.Locals[16]);f.Pc=5588;continue;}
case 5588:{f.Push(JValue.R(rt.String("PrecostDesc")));f.Pc=5591;continue;}
case 5591:{f.Push(JValue.R(rt.String("Prowl")));f.Pc=5594;continue;}
case 5594:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5597);}
case 5597:{f.StackOp("pop");f.Pc=5598;continue;}
case 5598:{f.Push(f.Locals[16]);f.Pc=5600;continue;}
case 5600:{f.Push(JValue.R(rt.String("CostDesc")));f.Pc=5603;continue;}
case 5603:{f.Push(f.Locals[14]);f.Pc=5605;continue;}
case 5605:{f.Push(JValue.I(1));f.Pc=5606;continue;}
case 5606:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5607;continue;}
case 5607:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",5610);}
case 5610:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5613);}
case 5613:{f.StackOp("pop");f.Pc=5614;continue;}
case 5614:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=5617;continue;}
case 5617:{f.StackOp("dup");f.Pc=5618;continue;}
case 5618:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",5621);}
case 5621:{f.Locals[17]=f.Pop();f.Pc=5623;continue;}
case 5623:{f.Push(f.Locals[17]);f.Pc=5625;continue;}
case 5625:{f.Push(f.Locals[16]);f.Pc=5627;continue;}
case 5627:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCostDescription","()Ljava/lang/String;","invokevirtual",5630);}
case 5630:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5633);}
case 5633:{f.StackOp("pop");f.Pc=5634;continue;}
case 5634:{f.Push(f.Locals[17]);f.Pc=5636;continue;}
case 5636:{f.Push(JValue.R(rt.String("(")));f.Pc=5639;continue;}
case 5639:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5642);}
case 5642:{f.Push(f.Locals[0]);f.Pc=5643;continue;}
case 5643:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",5648);}
case 5648:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5651);}
case 5651:{f.Push(JValue.R(rt.String(")")));f.Pc=5654;continue;}
case 5654:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5657);}
case 5657:{f.StackOp("pop");f.Pc=5658;continue;}
case 5658:{f.Push(f.Locals[16]);f.Pc=5660;continue;}
case 5660:{f.Push(f.Locals[17]);f.Pc=5662;continue;}
case 5662:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",5665);}
case 5665:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",5668);}
case 5668:{f.Push(f.Locals[16]);f.Pc=5670;continue;}
case 5670:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Prowl","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Prowl","Lforge/game/spellability/AlternativeCost;"));f.Pc=5673;continue;}
case 5673:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",5676);}
case 5676:{f.Push(f.Locals[16]);f.Pc=5678;continue;}
case 5678:{f.Push(f.Locals[2]);f.Pc=5679;continue;}
case 5679:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",5682);}
case 5682:{f.Push(f.Locals[0]);f.Pc=5683;continue;}
case 5683:{f.Push(f.Locals[16]);f.Pc=5685;continue;}
case 5685:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",5690);}
case 5690:{f.Pc=8390;continue;}
case 5693:{f.Push(f.Locals[3]);f.Pc=5694;continue;}
case 5694:{f.Push(JValue.R(rt.String("Reconfigure")));f.Pc=5697;continue;}
case 5697:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",5700);}
case 5700:{f.Pc=f.Pop().Int==0?5886:5703;continue;}
case 5703:{f.Push(f.Locals[3]);f.Pc=5704;continue;}
case 5704:{f.Push(JValue.R(rt.String(":")));f.Pc=5707;continue;}
case 5707:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",5710);}
case 5710:{f.Pc=f.Pop().Int!=0?5729:5713;continue;}
case 5713:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=5716;continue;}
case 5716:{f.Push(f.Locals[1]);f.Pc=5717;continue;}
case 5717:{return rt.Call(f,"forge/game/card/CardState","toString","()Ljava/lang/String;","invokevirtual",5720);}
case 5720:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:5720:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",5725);}
case 5725:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",5728);}
case 5728:{return JStep.ReturnVoid;}
case 5729:{f.Push(f.Locals[3]);f.Pc=5730;continue;}
case 5730:{f.Push(JValue.R(rt.String(":")));f.Pc=5733;continue;}
case 5733:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",5736);}
case 5736:{f.Locals[14]=f.Pop();f.Pc=5738;continue;}
case 5738:{f.Push(f.Locals[14]);f.Pc=5740;continue;}
case 5740:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=5741;continue;}
case 5741:{f.Push(JValue.I(2));f.Pc=5742;continue;}
case 5742:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?5757:5745;continue;}
case 5745:{f.Push(f.Locals[14]);f.Pc=5747;continue;}
case 5747:{f.Push(JValue.I(2));f.Pc=5748;continue;}
case 5748:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5749;continue;}
case 5749:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:5749:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",5754);}
case 5754:{f.Pc=5760;continue;}
case 5757:{f.Push(JValue.R(rt.String("")));f.Pc=5760;continue;}
case 5760:{f.Locals[15]=f.Pop();f.Pc=5762;continue;}
case 5762:{f.Push(f.Locals[14]);f.Pc=5764;continue;}
case 5764:{f.Push(JValue.I(1));f.Pc=5765;continue;}
case 5765:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5766;continue;}
case 5766:{f.Push(f.Locals[15]);f.Pc=5768;continue;}
case 5768:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:5768:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",5773);}
case 5773:{f.Locals[16]=f.Pop();f.Pc=5775;continue;}
case 5775:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=5778;continue;}
case 5778:{f.StackOp("dup");f.Pc=5779;continue;}
case 5779:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",5782);}
case 5782:{f.Locals[17]=f.Pop();f.Pc=5784;continue;}
case 5784:{f.Push(f.Locals[17]);f.Pc=5786;continue;}
case 5786:{f.Push(JValue.R(rt.String("AB$ Attach | ValidTgts$ Creature.YouCtrl+Other | TgtPrompt$ Select target creature you control ")));f.Pc=5789;continue;}
case 5789:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5792);}
case 5792:{f.StackOp("pop");f.Pc=5793;continue;}
case 5793:{f.Push(f.Locals[17]);f.Pc=5795;continue;}
case 5795:{f.Push(JValue.R(rt.String("| AILogic$ Pump | SpellDescription$ Attach ")));f.Pc=5798;continue;}
case 5798:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5801);}
case 5801:{f.Push(f.Locals[16]);f.Pc=5803;continue;}
case 5803:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5806);}
case 5806:{f.StackOp("pop");f.Pc=5807;continue;}
case 5807:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=5810;continue;}
case 5810:{f.StackOp("dup");f.Pc=5811;continue;}
case 5811:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",5814);}
case 5814:{f.Locals[18]=f.Pop();f.Pc=5816;continue;}
case 5816:{f.Push(f.Locals[18]);f.Pc=5818;continue;}
case 5818:{f.Push(JValue.R(rt.String("AB$ Unattach | Defined$ Self | SpellDescription$ Unattach | IsPresent$ Card.Self+AttachedTo Creature")));f.Pc=5821;continue;}
case 5821:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5824);}
case 5824:{f.StackOp("pop");f.Pc=5825;continue;}
case 5825:{f.Push(f.Locals[18]);f.Pc=5827;continue;}
case 5827:{f.Push(f.Locals[16]);f.Pc=5829;continue;}
case 5829:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5832);}
case 5832:{f.StackOp("pop");f.Pc=5833;continue;}
case 5833:{f.Push(f.Locals[17]);f.Pc=5835;continue;}
case 5835:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",5838);}
case 5838:{f.Push(f.Locals[1]);f.Pc=5839;continue;}
case 5839:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",5842);}
case 5842:{f.Locals[19]=f.Pop();f.Pc=5844;continue;}
case 5844:{f.Push(f.Locals[19]);f.Pc=5846;continue;}
case 5846:{f.Push(f.Locals[2]);f.Pc=5847;continue;}
case 5847:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",5850);}
case 5850:{f.Push(f.Locals[0]);f.Pc=5851;continue;}
case 5851:{f.Push(f.Locals[19]);f.Pc=5853;continue;}
case 5853:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",5858);}
case 5858:{f.Push(f.Locals[18]);f.Pc=5860;continue;}
case 5860:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",5863);}
case 5863:{f.Push(f.Locals[1]);f.Pc=5864;continue;}
case 5864:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",5867);}
case 5867:{f.Locals[20]=f.Pop();f.Pc=5869;continue;}
case 5869:{f.Push(f.Locals[20]);f.Pc=5871;continue;}
case 5871:{f.Push(f.Locals[2]);f.Pc=5872;continue;}
case 5872:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",5875);}
case 5875:{f.Push(f.Locals[0]);f.Pc=5876;continue;}
case 5876:{f.Push(f.Locals[20]);f.Pc=5878;continue;}
case 5878:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",5883);}
case 5883:{f.Pc=8390;continue;}
case 5886:{f.Push(f.Locals[3]);f.Pc=5887;continue;}
case 5887:{f.Push(JValue.R(rt.String("Reinforce")));f.Pc=5890;continue;}
case 5890:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",5893);}
case 5893:{f.Pc=f.Pop().Int==0?6081:5896;continue;}
case 5896:{f.Push(f.Locals[0]);f.Pc=5897;continue;}
case 5897:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/KeywordWithCostAndAmount")?1:0));f.Pc=5900;continue;}
case 5900:{f.Pc=f.Pop().Int==0?6081:5903;continue;}
case 5903:{f.Push(f.Locals[0]);f.Pc=5904;continue;}
case 5904:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordWithCostAndAmount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5907;continue;}
case 5907:{f.Locals[12]=f.Pop();f.Pc=5909;continue;}
case 5909:{f.Push(f.Locals[12]);f.Pc=5911;continue;}
case 5911:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndAmount","getAmountString","()Ljava/lang/String;","invokevirtual",5914);}
case 5914:{f.Locals[14]=f.Pop();f.Pc=5916;continue;}
case 5916:{f.Push(f.Locals[12]);f.Pc=5918;continue;}
case 5918:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndAmount","getCostString","()Ljava/lang/String;","invokevirtual",5921);}
case 5921:{f.Locals[15]=f.Pop();f.Pc=5923;continue;}
case 5923:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=5926;continue;}
case 5926:{f.StackOp("dup");f.Pc=5927;continue;}
case 5927:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",5930);}
case 5930:{f.Locals[16]=f.Pop();f.Pc=5932;continue;}
case 5932:{f.Push(f.Locals[16]);f.Pc=5934;continue;}
case 5934:{f.Push(JValue.R(rt.String("AB$ PutCounter | CounterType$ P1P1 | ActivationZone$ Hand | ValidTgts$ Creature ")));f.Pc=5937;continue;}
case 5937:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5940);}
case 5940:{f.StackOp("pop");f.Pc=5941;continue;}
case 5941:{f.Push(f.Locals[16]);f.Pc=5943;continue;}
case 5943:{f.Push(JValue.R(rt.String("| Cost$ ")));f.Pc=5946;continue;}
case 5946:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5949);}
case 5949:{f.Push(f.Locals[15]);f.Pc=5951;continue;}
case 5951:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5954);}
case 5954:{f.Push(JValue.R(rt.String(" Discard<1/CARDNAME>")));f.Pc=5957;continue;}
case 5957:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5960);}
case 5960:{f.StackOp("pop");f.Pc=5961;continue;}
case 5961:{f.Push(f.Locals[16]);f.Pc=5963;continue;}
case 5963:{f.Push(JValue.R(rt.String("| CounterNum$ ")));f.Pc=5966;continue;}
case 5966:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5969);}
case 5969:{f.Push(f.Locals[14]);f.Pc=5971;continue;}
case 5971:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5974);}
case 5974:{f.StackOp("pop");f.Pc=5975;continue;}
case 5975:{f.Push(f.Locals[16]);f.Pc=5977;continue;}
case 5977:{f.Push(JValue.R(rt.String("| CostDesc$ ")));f.Pc=5980;continue;}
case 5980:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5983);}
case 5983:{f.Push(f.Locals[15]);f.Pc=5985;continue;}
case 5985:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",5988);}
case 5988:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",5991);}
case 5991:{f.StackOp("pop");f.Pc=5992;continue;}
case 5992:{f.Push(f.Locals[16]);f.Pc=5994;continue;}
case 5994:{f.Push(JValue.R(rt.String("| PrecostDesc$ ")));f.Pc=5997;continue;}
case 5997:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",6000);}
case 6000:{f.Push(f.Locals[12]);f.Pc=6002;continue;}
case 6002:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndAmount","getTitleWithoutCost","()Ljava/lang/String;","invokevirtual",6005);}
case 6005:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",6008);}
case 6008:{f.StackOp("pop");f.Pc=6009;continue;}
case 6009:{f.Push(f.Locals[16]);f.Pc=6011;continue;}
case 6011:{f.Push(JValue.R(rt.String("| SpellDescription$ (")));f.Pc=6014;continue;}
case 6014:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",6017);}
case 6017:{f.Push(f.Locals[0]);f.Pc=6018;continue;}
case 6018:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",6023);}
case 6023:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",6026);}
case 6026:{f.Push(JValue.R(rt.String(")")));f.Pc=6029;continue;}
case 6029:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",6032);}
case 6032:{f.StackOp("pop");f.Pc=6033;continue;}
case 6033:{f.Push(f.Locals[16]);f.Pc=6035;continue;}
case 6035:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",6038);}
case 6038:{f.Push(f.Locals[1]);f.Pc=6039;continue;}
case 6039:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",6042);}
case 6042:{f.Locals[17]=f.Pop();f.Pc=6044;continue;}
case 6044:{f.Push(f.Locals[17]);f.Pc=6046;continue;}
case 6046:{f.Push(f.Locals[2]);f.Pc=6047;continue;}
case 6047:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",6050);}
case 6050:{f.Push(f.Locals[14]);f.Pc=6052;continue;}
case 6052:{f.Push(JValue.R(rt.String("X")));f.Pc=6054;continue;}
case 6054:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6057);}
case 6057:{f.Pc=f.Pop().Int==0?6070:6060;continue;}
case 6060:{f.Push(f.Locals[17]);f.Pc=6062;continue;}
case 6062:{f.Push(JValue.R(rt.String("X")));f.Pc=6064;continue;}
case 6064:{f.Push(JValue.R(rt.String("Count$xPaid")));f.Pc=6067;continue;}
case 6067:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",6070);}
case 6070:{f.Push(f.Locals[0]);f.Pc=6071;continue;}
case 6071:{f.Push(f.Locals[17]);f.Pc=6073;continue;}
case 6073:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",6078);}
case 6078:{f.Pc=8390;continue;}
case 6081:{f.Push(f.Locals[3]);f.Pc=6082;continue;}
case 6082:{f.Push(JValue.R(rt.String("Saddle")));f.Pc=6085;continue;}
case 6085:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6088);}
case 6088:{f.Pc=f.Pop().Int==0?6148:6091;continue;}
case 6091:{f.Push(f.Locals[3]);f.Pc=6092;continue;}
case 6092:{f.Push(JValue.R(rt.String(":")));f.Pc=6095;continue;}
case 6095:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6098);}
case 6098:{f.Locals[14]=f.Pop();f.Pc=6100;continue;}
case 6100:{f.Push(f.Locals[14]);f.Pc=6102;continue;}
case 6102:{f.Push(JValue.I(1));f.Pc=6103;continue;}
case 6103:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6104;continue;}
case 6104:{f.Locals[15]=f.Pop();f.Pc=6106;continue;}
case 6106:{f.Push(f.Locals[15]);f.Pc=6108;continue;}
case 6108:{f.Push(f.Locals[15]);f.Pc=6110;continue;}
case 6110:{f.Push(f.Locals[0]);f.Pc=6111;continue;}
case 6111:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",6116);}
case 6116:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:6116:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",6121);}
case 6121:{f.Locals[16]=f.Pop();f.Pc=6123;continue;}
case 6123:{f.Push(f.Locals[16]);f.Pc=6125;continue;}
case 6125:{f.Push(f.Locals[1]);f.Pc=6126;continue;}
case 6126:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",6129);}
case 6129:{f.Locals[17]=f.Pop();f.Pc=6131;continue;}
case 6131:{f.Push(f.Locals[17]);f.Pc=6133;continue;}
case 6133:{f.Push(f.Locals[2]);f.Pc=6134;continue;}
case 6134:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",6137);}
case 6137:{f.Push(f.Locals[0]);f.Pc=6138;continue;}
case 6138:{f.Push(f.Locals[17]);f.Pc=6140;continue;}
case 6140:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",6145);}
case 6145:{f.Pc=8390;continue;}
case 6148:{f.Push(f.Locals[3]);f.Pc=6149;continue;}
case 6149:{f.Push(JValue.R(rt.String("Scavenge")));f.Pc=6152;continue;}
case 6152:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6155);}
case 6155:{f.Pc=f.Pop().Int==0?6229:6158;continue;}
case 6158:{f.Push(f.Locals[3]);f.Pc=6159;continue;}
case 6159:{f.Push(JValue.R(rt.String(":")));f.Pc=6162;continue;}
case 6162:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6165);}
case 6165:{f.Locals[14]=f.Pop();f.Pc=6167;continue;}
case 6167:{f.Push(f.Locals[14]);f.Pc=6169;continue;}
case 6169:{f.Push(JValue.I(1));f.Pc=6170;continue;}
case 6170:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6171;continue;}
case 6171:{f.Locals[15]=f.Pop();f.Pc=6173;continue;}
case 6173:{f.Push(f.Locals[15]);f.Pc=6175;continue;}
case 6175:{f.Push(f.Locals[15]);f.Pc=6177;continue;}
case 6177:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",6180);}
case 6180:{f.Push(f.Locals[0]);f.Pc=6181;continue;}
case 6181:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",6186);}
case 6186:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:6186:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",6191);}
case 6191:{f.Locals[16]=f.Pop();f.Pc=6193;continue;}
case 6193:{f.Push(f.Locals[16]);f.Pc=6195;continue;}
case 6195:{f.Push(f.Locals[1]);f.Pc=6196;continue;}
case 6196:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",6199);}
case 6199:{f.Locals[17]=f.Pop();f.Pc=6201;continue;}
case 6201:{f.Push(f.Locals[17]);f.Pc=6203;continue;}
case 6203:{f.Push(JValue.R(rt.String("ScavengeX")));f.Pc=6206;continue;}
case 6206:{f.Push(JValue.R(rt.String("Exiled$CardPower")));f.Pc=6209;continue;}
case 6209:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",6212);}
case 6212:{f.Push(f.Locals[17]);f.Pc=6214;continue;}
case 6214:{f.Push(f.Locals[2]);f.Pc=6215;continue;}
case 6215:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",6218);}
case 6218:{f.Push(f.Locals[0]);f.Pc=6219;continue;}
case 6219:{f.Push(f.Locals[17]);f.Pc=6221;continue;}
case 6221:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",6226);}
case 6226:{f.Pc=8390;continue;}
case 6229:{f.Push(f.Locals[3]);f.Pc=6230;continue;}
case 6230:{f.Push(JValue.R(rt.String("Sneak")));f.Pc=6233;continue;}
case 6233:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6236);}
case 6236:{f.Pc=f.Pop().Int==0?6456:6239;continue;}
case 6239:{f.Push(f.Locals[3]);f.Pc=6240;continue;}
case 6240:{f.Push(JValue.R(rt.String(":")));f.Pc=6243;continue;}
case 6243:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6246);}
case 6246:{f.Locals[14]=f.Pop();f.Pc=6248;continue;}
case 6248:{f.Push(f.Locals[14]);f.Pc=6250;continue;}
case 6250:{f.Push(JValue.I(1));f.Pc=6251;continue;}
case 6251:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6252;continue;}
case 6252:{f.Locals[15]=f.Pop();f.Pc=6254;continue;}
case 6254:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=6257;continue;}
case 6257:{f.StackOp("dup");f.Pc=6258;continue;}
case 6258:{f.Push(f.Locals[15]);f.Pc=6260;continue;}
case 6260:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:6260:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6265);}
case 6265:{f.Push(JValue.I(0));f.Pc=6266;continue;}
case 6266:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",6269);}
case 6269:{f.Locals[16]=f.Pop();f.Pc=6271;continue;}
case 6271:{f.Push(f.Locals[1]);f.Pc=6272;continue;}
case 6272:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbilityWithFallback","()Lforge/game/spellability/SpellAbility;","invokevirtual",6275);}
case 6275:{f.Push(f.Locals[4]);f.Pc=6277;continue;}
case 6277:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",6280);}
case 6280:{f.Push(f.Locals[16]);f.Pc=6282;continue;}
case 6282:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithManaCostReplaced","(Lforge/game/player/Player;Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",6285);}
case 6285:{f.Locals[17]=f.Pop();f.Pc=6287;continue;}
case 6287:{f.Push(f.Locals[14]);f.Pc=6289;continue;}
case 6289:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=6290;continue;}
case 6290:{f.Push(JValue.I(2));f.Pc=6291;continue;}
case 6291:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?6312:6294;continue;}
case 6294:{f.Push(f.Locals[17]);f.Pc=6296;continue;}
case 6296:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",6299);}
case 6299:{f.Push(JValue.R(rt.String("ValidAfterStack")));f.Pc=6302;continue;}
case 6302:{f.Push(f.Locals[14]);f.Pc=6304;continue;}
case 6304:{f.Push(JValue.I(2));f.Pc=6305;continue;}
case 6305:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6306;continue;}
case 6306:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",6311);}
case 6311:{f.StackOp("pop");f.Pc=6312;continue;}
case 6312:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=6315;continue;}
case 6315:{f.StackOp("dup");f.Pc=6316;continue;}
case 6316:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",6319);}
case 6319:{f.Locals[18]=f.Pop();f.Pc=6321;continue;}
case 6321:{f.Push(f.Locals[18]);f.Pc=6323;continue;}
case 6323:{f.Push(JValue.R(rt.String("Sneak ")));f.Pc=6326;continue;}
case 6326:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",6329);}
case 6329:{f.Push(f.Locals[15]);f.Pc=6331;continue;}
case 6331:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",6334);}
case 6334:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",6337);}
case 6337:{f.Push(JValue.R(rt.String(" (")));f.Pc=6340;continue;}
case 6340:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",6343);}
case 6343:{f.StackOp("pop");f.Pc=6344;continue;}
case 6344:{f.Push(f.Locals[18]);f.Pc=6346;continue;}
case 6346:{f.Push(f.Locals[0]);f.Pc=6347;continue;}
case 6347:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",6352);}
case 6352:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",6355);}
case 6355:{f.StackOp("pop");f.Pc=6356;continue;}
case 6356:{f.Push(f.Locals[18]);f.Pc=6358;continue;}
case 6358:{f.Push(JValue.R(rt.String(")")));f.Pc=6361;continue;}
case 6361:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",6364);}
case 6364:{f.StackOp("pop");f.Pc=6365;continue;}
case 6365:{f.Push(f.Locals[17]);f.Pc=6367;continue;}
case 6367:{f.Push(f.Locals[18]);f.Pc=6369;continue;}
case 6369:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",6372);}
case 6372:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",6375);}
case 6375:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=6378;continue;}
case 6378:{f.StackOp("dup");f.Pc=6379;continue;}
case 6379:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",6382);}
case 6382:{f.Locals[19]=f.Pop();f.Pc=6384;continue;}
case 6384:{f.Push(f.Locals[19]);f.Pc=6386;continue;}
case 6386:{f.Push(f.Locals[1]);f.Pc=6387;continue;}
case 6387:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",6390);}
case 6390:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",6393);}
case 6393:{f.Push(JValue.R(rt.String(" (Sneak)")));f.Pc=6396;continue;}
case 6396:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",6399);}
case 6399:{f.StackOp("pop");f.Pc=6400;continue;}
case 6400:{f.Push(f.Locals[17]);f.Pc=6402;continue;}
case 6402:{f.Push(f.Locals[19]);f.Pc=6404;continue;}
case 6404:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",6407);}
case 6407:{return rt.Call(f,"forge/game/spellability/SpellAbility","setStackDescription","(Ljava/lang/String;)V","invokevirtual",6410);}
case 6410:{f.Push(f.Locals[17]);f.Pc=6412;continue;}
case 6412:{f.Push(JValue.R(rt.String("Secondary")));f.Pc=6415;continue;}
case 6415:{f.Push(JValue.R(rt.String("True")));f.Pc=6418;continue;}
case 6418:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",6421);}
case 6421:{f.StackOp("pop");f.Pc=6422;continue;}
case 6422:{f.Push(f.Locals[17]);f.Pc=6424;continue;}
case 6424:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Sneak","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Sneak","Lforge/game/spellability/AlternativeCost;"));f.Pc=6427;continue;}
case 6427:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",6430);}
case 6430:{f.Push(f.Locals[17]);f.Pc=6432;continue;}
case 6432:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",6435);}
case 6435:{f.Push(JValue.I(1));f.Pc=6436;continue;}
case 6436:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setInstantSpeed","(Z)V","invokevirtual",6439);}
case 6439:{f.Push(f.Locals[17]);f.Pc=6441;continue;}
case 6441:{f.Push(f.Locals[2]);f.Pc=6442;continue;}
case 6442:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",6445);}
case 6445:{f.Push(f.Locals[0]);f.Pc=6446;continue;}
case 6446:{f.Push(f.Locals[17]);f.Pc=6448;continue;}
case 6448:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",6453);}
case 6453:{f.Pc=8390;continue;}
case 6456:{f.Push(f.Locals[3]);f.Pc=6457;continue;}
case 6457:{f.Push(JValue.R(rt.String("Station")));f.Pc=6460;continue;}
case 6460:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6463);}
case 6463:{f.Pc=f.Pop().Int==0?6515:6466;continue;}
case 6466:{f.Push(f.Locals[0]);f.Pc=6467;continue;}
case 6467:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",6472);}
case 6472:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:6472:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6477);}
case 6477:{f.Locals[14]=f.Pop();f.Pc=6479;continue;}
case 6479:{f.Push(f.Locals[14]);f.Pc=6481;continue;}
case 6481:{f.Push(f.Locals[1]);f.Pc=6482;continue;}
case 6482:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",6485);}
case 6485:{f.Locals[15]=f.Pop();f.Pc=6487;continue;}
case 6487:{f.Push(f.Locals[15]);f.Pc=6489;continue;}
case 6489:{f.Push(JValue.R(rt.String("StationX")));f.Pc=6492;continue;}
case 6492:{f.Push(JValue.R(rt.String("TappedCards$TapPowerValue")));f.Pc=6495;continue;}
case 6495:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",6498);}
case 6498:{f.Push(f.Locals[15]);f.Pc=6500;continue;}
case 6500:{f.Push(f.Locals[2]);f.Pc=6501;continue;}
case 6501:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",6504);}
case 6504:{f.Push(f.Locals[0]);f.Pc=6505;continue;}
case 6505:{f.Push(f.Locals[15]);f.Pc=6507;continue;}
case 6507:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",6512);}
case 6512:{f.Pc=8390;continue;}
case 6515:{f.Push(f.Locals[3]);f.Pc=6516;continue;}
case 6516:{f.Push(JValue.R(rt.String("Encore")));f.Pc=6519;continue;}
case 6519:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6522);}
case 6522:{f.Pc=f.Pop().Int==0?6702:6525;continue;}
case 6525:{f.Push(f.Locals[3]);f.Pc=6526;continue;}
case 6526:{f.Push(JValue.R(rt.String(":")));f.Pc=6529;continue;}
case 6529:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6532);}
case 6532:{f.Locals[14]=f.Pop();f.Pc=6534;continue;}
case 6534:{f.Push(f.Locals[14]);f.Pc=6536;continue;}
case 6536:{f.Push(JValue.I(1));f.Pc=6537;continue;}
case 6537:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6538;continue;}
case 6538:{f.Locals[15]=f.Pop();f.Pc=6540;continue;}
case 6540:{f.Push(f.Locals[14]);f.Pc=6542;continue;}
case 6542:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=6543;continue;}
case 6543:{f.Push(JValue.I(2));f.Pc=6544;continue;}
case 6544:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?6559:6547;continue;}
case 6547:{f.Push(f.Locals[14]);f.Pc=6549;continue;}
case 6549:{f.Push(JValue.I(2));f.Pc=6550;continue;}
case 6550:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6551;continue;}
case 6551:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:6551:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6556);}
case 6556:{f.Pc=6562;continue;}
case 6559:{f.Push(JValue.R(rt.String("")));f.Pc=6562;continue;}
case 6562:{f.Locals[16]=f.Pop();f.Pc=6564;continue;}
case 6564:{f.Push(f.Locals[15]);f.Pc=6566;continue;}
case 6566:{f.Push(f.Locals[15]);f.Pc=6568;continue;}
case 6568:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",6571);}
case 6571:{f.Push(f.Locals[0]);f.Pc=6572;continue;}
case 6572:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",6577);}
case 6577:{f.Push(f.Locals[16]);f.Pc=6579;continue;}
case 6579:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:6579:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",6584);}
case 6584:{f.Locals[17]=f.Pop();f.Pc=6586;continue;}
case 6586:{f.Push(f.Locals[17]);f.Pc=6588;continue;}
case 6588:{f.Push(f.Locals[1]);f.Pc=6589;continue;}
case 6589:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",6592);}
case 6592:{f.Locals[18]=f.Pop();f.Pc=6594;continue;}
case 6594:{f.Push(JValue.R(rt.String("DB$ RepeatEach | DefinedCards$ Remembered | UseImprinted$ True")));f.Pc=6597;continue;}
case 6597:{f.Locals[19]=f.Pop();f.Pc=6599;continue;}
case 6599:{f.Push(JValue.R(rt.String("DB$ RepeatEach | DefinedCards$ Remembered | UseImprinted$ True")));f.Pc=6602;continue;}
case 6602:{f.Push(f.Locals[1]);f.Pc=6603;continue;}
case 6603:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",6606);}
case 6606:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=6609;continue;}
case 6609:{f.Locals[20]=f.Pop();f.Pc=6611;continue;}
case 6611:{f.Push(f.Locals[18]);f.Pc=6613;continue;}
case 6613:{f.Push(f.Locals[20]);f.Pc=6615;continue;}
case 6615:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",6618);}
case 6618:{f.Push(JValue.R(rt.String("DB$ Effect | RememberObjects$ Imprinted & ImprintedRemembered | ExileOnMoved$ Battlefield | StaticAbilities$ AttackChosen")));f.Pc=6621;continue;}
case 6621:{f.Locals[21]=f.Pop();f.Pc=6623;continue;}
case 6623:{f.Push(JValue.R(rt.String("DB$ Effect | RememberObjects$ Imprinted & ImprintedRemembered | ExileOnMoved$ Battlefield | StaticAbilities$ AttackChosen")));f.Pc=6626;continue;}
case 6626:{f.Push(f.Locals[1]);f.Pc=6627;continue;}
case 6627:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",6630);}
case 6630:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=6633;continue;}
case 6633:{f.Locals[22]=f.Pop();f.Pc=6635;continue;}
case 6635:{f.Push(f.Locals[20]);f.Pc=6637;continue;}
case 6637:{f.Push(JValue.R(rt.String("RepeatSubAbility")));f.Pc=6640;continue;}
case 6640:{f.Push(f.Locals[22]);f.Pc=6642;continue;}
case 6642:{return rt.Call(f,"forge/game/spellability/AbilitySub","setAdditionalAbility","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)V","invokevirtual",6645);}
case 6645:{f.Push(JValue.R(rt.String("Mode$ MustAttack | ValidCreature$ Card.IsRemembered | MustAttack$ RememberedPlayer | Description$ This token copy attacks that opponent this turn if able.")));f.Pc=6648;continue;}
case 6648:{f.Locals[23]=f.Pop();f.Pc=6650;continue;}
case 6650:{f.Push(f.Locals[22]);f.Pc=6652;continue;}
case 6652:{f.Push(JValue.R(rt.String("AttackChosen")));f.Pc=6655;continue;}
case 6655:{f.Push(JValue.R(rt.String("Mode$ MustAttack | ValidCreature$ Card.IsRemembered | MustAttack$ RememberedPlayer | Description$ This token copy attacks that opponent this turn if able.")));f.Pc=6658;continue;}
case 6658:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",6661);}
case 6661:{f.Push(JValue.R(rt.String("DB$ Cleanup | Defined$ Imprinted | ForgetDefined$ Remembered")));f.Pc=6664;continue;}
case 6664:{f.Locals[24]=f.Pop();f.Pc=6666;continue;}
case 6666:{f.Push(JValue.R(rt.String("DB$ Cleanup | Defined$ Imprinted | ForgetDefined$ Remembered")));f.Pc=6669;continue;}
case 6669:{f.Push(f.Locals[1]);f.Pc=6670;continue;}
case 6670:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",6673);}
case 6673:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=6676;continue;}
case 6676:{f.Locals[25]=f.Pop();f.Pc=6678;continue;}
case 6678:{f.Push(f.Locals[22]);f.Pc=6680;continue;}
case 6680:{f.Push(f.Locals[25]);f.Pc=6682;continue;}
case 6682:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",6685);}
case 6685:{f.Push(f.Locals[18]);f.Pc=6687;continue;}
case 6687:{f.Push(f.Locals[2]);f.Pc=6688;continue;}
case 6688:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",6691);}
case 6691:{f.Push(f.Locals[0]);f.Pc=6692;continue;}
case 6692:{f.Push(f.Locals[18]);f.Pc=6694;continue;}
case 6694:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",6699);}
case 6699:{f.Pc=8390;continue;}
case 6702:{f.Push(f.Locals[3]);f.Pc=6703;continue;}
case 6703:{f.Push(JValue.R(rt.String("Specialize")));f.Pc=6706;continue;}
case 6706:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6709);}
case 6709:{f.Pc=f.Pop().Int==0?6880:6712;continue;}
case 6712:{f.Push(f.Locals[3]);f.Pc=6713;continue;}
case 6713:{f.Push(JValue.R(rt.String(":")));f.Pc=6716;continue;}
case 6716:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6719);}
case 6719:{f.Locals[14]=f.Pop();f.Pc=6721;continue;}
case 6721:{f.Push(f.Locals[14]);f.Pc=6723;continue;}
case 6723:{f.Push(JValue.I(1));f.Pc=6724;continue;}
case 6724:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6725;continue;}
case 6725:{f.Locals[15]=f.Pop();f.Pc=6727;continue;}
case 6727:{f.Push(f.Locals[14]);f.Pc=6729;continue;}
case 6729:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=6730;continue;}
case 6730:{f.Push(JValue.I(2));f.Pc=6731;continue;}
case 6731:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?6756:6734;continue;}
case 6734:{f.Push(f.Locals[14]);f.Pc=6736;continue;}
case 6736:{f.Push(JValue.I(2));f.Pc=6737;continue;}
case 6737:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6738;continue;}
case 6738:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",6741);}
case 6741:{f.Pc=f.Pop().Int!=0?6756:6744;continue;}
case 6744:{f.Push(f.Locals[14]);f.Pc=6746;continue;}
case 6746:{f.Push(JValue.I(2));f.Pc=6747;continue;}
case 6747:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6748;continue;}
case 6748:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:6748:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6753);}
case 6753:{f.Pc=6759;continue;}
case 6756:{f.Push(JValue.R(rt.String("")));f.Pc=6759;continue;}
case 6759:{f.Locals[16]=f.Pop();f.Pc=6761;continue;}
case 6761:{f.Push(f.Locals[14]);f.Pc=6763;continue;}
case 6763:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=6764;continue;}
case 6764:{f.Push(JValue.I(3));f.Pc=6765;continue;}
case 6765:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?6790:6768;continue;}
case 6768:{f.Push(f.Locals[14]);f.Pc=6770;continue;}
case 6770:{f.Push(JValue.I(3));f.Pc=6771;continue;}
case 6771:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6772;continue;}
case 6772:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",6775);}
case 6775:{f.Pc=f.Pop().Int!=0?6790:6778;continue;}
case 6778:{f.Push(f.Locals[14]);f.Pc=6780;continue;}
case 6780:{f.Push(JValue.I(3));f.Pc=6781;continue;}
case 6781:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6782;continue;}
case 6782:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:6782:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6787);}
case 6787:{f.Pc=6793;continue;}
case 6790:{f.Push(JValue.R(rt.String("")));f.Pc=6793;continue;}
case 6793:{f.Locals[17]=f.Pop();f.Pc=6795;continue;}
case 6795:{f.Push(f.Locals[14]);f.Pc=6797;continue;}
case 6797:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=6798;continue;}
case 6798:{f.Push(JValue.I(4));f.Pc=6799;continue;}
case 6799:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?6824:6802;continue;}
case 6802:{f.Push(f.Locals[14]);f.Pc=6804;continue;}
case 6804:{f.Push(JValue.I(4));f.Pc=6805;continue;}
case 6805:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6806;continue;}
case 6806:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",6809);}
case 6809:{f.Pc=f.Pop().Int!=0?6824:6812;continue;}
case 6812:{f.Push(f.Locals[14]);f.Pc=6814;continue;}
case 6814:{f.Push(JValue.I(4));f.Pc=6815;continue;}
case 6815:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6816;continue;}
case 6816:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:6816:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6821);}
case 6821:{f.Pc=6827;continue;}
case 6824:{f.Push(JValue.R(rt.String("")));f.Pc=6827;continue;}
case 6827:{f.Locals[18]=f.Pop();f.Pc=6829;continue;}
case 6829:{f.Push(f.Locals[15]);f.Pc=6831;continue;}
case 6831:{f.Push(f.Locals[18]);f.Pc=6833;continue;}
case 6833:{f.Push(f.Locals[16]);f.Pc=6835;continue;}
case 6835:{f.Push(f.Locals[15]);f.Pc=6837;continue;}
case 6837:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",6840);}
case 6840:{f.Push(f.Locals[17]);f.Pc=6842;continue;}
case 6842:{f.Push(f.Locals[0]);f.Pc=6843;continue;}
case 6843:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",6848);}
case 6848:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:6848:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",6853);}
case 6853:{f.Locals[19]=f.Pop();f.Pc=6855;continue;}
case 6855:{f.Push(f.Locals[19]);f.Pc=6857;continue;}
case 6857:{f.Push(f.Locals[1]);f.Pc=6858;continue;}
case 6858:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",6861);}
case 6861:{f.Locals[20]=f.Pop();f.Pc=6863;continue;}
case 6863:{f.Push(f.Locals[20]);f.Pc=6865;continue;}
case 6865:{f.Push(f.Locals[2]);f.Pc=6866;continue;}
case 6866:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",6869);}
case 6869:{f.Push(f.Locals[0]);f.Pc=6870;continue;}
case 6870:{f.Push(f.Locals[20]);f.Pc=6872;continue;}
case 6872:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",6877);}
case 6877:{f.Pc=8390;continue;}
case 6880:{f.Push(f.Locals[3]);f.Pc=6881;continue;}
case 6881:{f.Push(JValue.R(rt.String("Spectacle")));f.Pc=6884;continue;}
case 6884:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6887);}
case 6887:{f.Pc=f.Pop().Int==0?6974:6890;continue;}
case 6890:{f.Push(f.Locals[3]);f.Pc=6891;continue;}
case 6891:{f.Push(JValue.R(rt.String(":")));f.Pc=6894;continue;}
case 6894:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6897);}
case 6897:{f.Locals[14]=f.Pop();f.Pc=6899;continue;}
case 6899:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=6902;continue;}
case 6902:{f.StackOp("dup");f.Pc=6903;continue;}
case 6903:{f.Push(f.Locals[14]);f.Pc=6905;continue;}
case 6905:{f.Push(JValue.I(1));f.Pc=6906;continue;}
case 6906:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6907;continue;}
case 6907:{f.Push(JValue.I(0));f.Pc=6908;continue;}
case 6908:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",6911);}
case 6911:{f.Locals[15]=f.Pop();f.Pc=6913;continue;}
case 6913:{f.Push(f.Locals[1]);f.Pc=6914;continue;}
case 6914:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",6917);}
case 6917:{f.Push(f.Locals[15]);f.Pc=6919;continue;}
case 6919:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithDefinedCost","(Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",6922);}
case 6922:{f.Locals[16]=f.Pop();f.Pc=6924;continue;}
case 6924:{f.Push(f.Locals[16]);f.Pc=6926;continue;}
case 6926:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Spectacle","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Spectacle","Lforge/game/spellability/AlternativeCost;"));f.Pc=6929;continue;}
case 6929:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",6932);}
case 6932:{f.Push(f.Locals[15]);f.Pc=6934;continue;}
case 6934:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",6937);}
case 6937:{f.Push(f.Locals[0]);f.Pc=6938;continue;}
case 6938:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",6943);}
case 6943:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:6943:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",6948);}
case 6948:{f.Locals[17]=f.Pop();f.Pc=6950;continue;}
case 6950:{f.Push(f.Locals[16]);f.Pc=6952;continue;}
case 6952:{f.Push(f.Locals[17]);f.Pc=6954;continue;}
case 6954:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",6957);}
case 6957:{f.Push(f.Locals[16]);f.Pc=6959;continue;}
case 6959:{f.Push(f.Locals[2]);f.Pc=6960;continue;}
case 6960:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",6963);}
case 6963:{f.Push(f.Locals[0]);f.Pc=6964;continue;}
case 6964:{f.Push(f.Locals[16]);f.Pc=6966;continue;}
case 6966:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",6971);}
case 6971:{f.Pc=8390;continue;}
case 6974:{f.Push(f.Locals[3]);f.Pc=6975;continue;}
case 6975:{f.Push(JValue.R(rt.String("Surge")));f.Pc=6978;continue;}
case 6978:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6981);}
case 6981:{f.Pc=f.Pop().Int==0?7068:6984;continue;}
case 6984:{f.Push(f.Locals[3]);f.Pc=6985;continue;}
case 6985:{f.Push(JValue.R(rt.String(":")));f.Pc=6988;continue;}
case 6988:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6991);}
case 6991:{f.Locals[14]=f.Pop();f.Pc=6993;continue;}
case 6993:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=6996;continue;}
case 6996:{f.StackOp("dup");f.Pc=6997;continue;}
case 6997:{f.Push(f.Locals[14]);f.Pc=6999;continue;}
case 6999:{f.Push(JValue.I(1));f.Pc=7000;continue;}
case 7000:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=7001;continue;}
case 7001:{f.Push(JValue.I(0));f.Pc=7002;continue;}
case 7002:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",7005);}
case 7005:{f.Locals[15]=f.Pop();f.Pc=7007;continue;}
case 7007:{f.Push(f.Locals[1]);f.Pc=7008;continue;}
case 7008:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",7011);}
case 7011:{f.Push(f.Locals[15]);f.Pc=7013;continue;}
case 7013:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithDefinedCost","(Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",7016);}
case 7016:{f.Locals[16]=f.Pop();f.Pc=7018;continue;}
case 7018:{f.Push(f.Locals[16]);f.Pc=7020;continue;}
case 7020:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Surge","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Surge","Lforge/game/spellability/AlternativeCost;"));f.Pc=7023;continue;}
case 7023:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",7026);}
case 7026:{f.Push(f.Locals[15]);f.Pc=7028;continue;}
case 7028:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",7031);}
case 7031:{f.Push(f.Locals[0]);f.Pc=7032;continue;}
case 7032:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",7037);}
case 7037:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:7037:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",7042);}
case 7042:{f.Locals[17]=f.Pop();f.Pc=7044;continue;}
case 7044:{f.Push(f.Locals[16]);f.Pc=7046;continue;}
case 7046:{f.Push(f.Locals[17]);f.Pc=7048;continue;}
case 7048:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",7051);}
case 7051:{f.Push(f.Locals[16]);f.Pc=7053;continue;}
case 7053:{f.Push(f.Locals[2]);f.Pc=7054;continue;}
case 7054:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",7057);}
case 7057:{f.Push(f.Locals[0]);f.Pc=7058;continue;}
case 7058:{f.Push(f.Locals[16]);f.Pc=7060;continue;}
case 7060:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",7065);}
case 7065:{f.Pc=8390;continue;}
case 7068:{f.Push(f.Locals[3]);f.Pc=7069;continue;}
case 7069:{f.Push(JValue.R(rt.String("Suspend")));f.Pc=7072;continue;}
case 7072:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7075);}
case 7075:{f.Pc=f.Pop().Int==0?7330:7078;continue;}
case 7078:{f.Push(f.Locals[3]);f.Pc=7079;continue;}
case 7079:{f.Push(JValue.R(rt.String("Suspend")));f.Pc=7082;continue;}
case 7082:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7085);}
case 7085:{f.Pc=f.Pop().Int!=0?7330:7088;continue;}
case 7088:{f.Push(f.Locals[3]);f.Pc=7089;continue;}
case 7089:{f.Push(JValue.R(rt.String(":")));f.Pc=7092;continue;}
case 7092:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",7095);}
case 7095:{f.Locals[14]=f.Pop();f.Pc=7097;continue;}
case 7097:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=7100;continue;}
case 7100:{f.StackOp("dup");f.Pc=7101;continue;}
case 7101:{f.Push(f.Locals[14]);f.Pc=7103;continue;}
case 7103:{f.Push(JValue.I(2));f.Pc=7104;continue;}
case 7104:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=7105;continue;}
case 7105:{f.Push(JValue.I(1));f.Pc=7106;continue;}
case 7106:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",7109);}
case 7109:{f.Locals[15]=f.Pop();f.Pc=7111;continue;}
case 7111:{if(!rt.EnsureInitialized(f,"forge/game/card/CardFactoryUtil$6"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardFactoryUtil$6")));f.Pc=7114;continue;}
case 7114:{f.StackOp("dup");f.Pc=7115;continue;}
case 7115:{f.Push(f.Locals[4]);f.Pc=7117;continue;}
case 7117:{f.Push(f.Locals[15]);f.Pc=7119;continue;}
case 7119:{f.Push(JValue.R(null));f.Pc=7120;continue;}
case 7120:{f.Push(f.Locals[14]);f.Pc=7122;continue;}
case 7122:{return rt.Call(f,"forge/game/card/CardFactoryUtil$6","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;[Ljava/lang/String;)V","invokespecial",7125);}
case 7125:{f.Locals[16]=f.Pop();f.Pc=7127;continue;}
case 7127:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=7130;continue;}
case 7130:{f.StackOp("dup");f.Pc=7131;continue;}
case 7131:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7134);}
case 7134:{f.Locals[17]=f.Pop();f.Pc=7136;continue;}
case 7136:{f.Push(f.Locals[17]);f.Pc=7138;continue;}
case 7138:{f.Push(JValue.R(rt.String("Suspend ")));f.Pc=7141;continue;}
case 7141:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7144);}
case 7144:{f.Push(f.Locals[14]);f.Pc=7146;continue;}
case 7146:{f.Push(JValue.I(1));f.Pc=7147;continue;}
case 7147:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=7148;continue;}
case 7148:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7151);}
case 7151:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=7154;continue;}
case 7154:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7157);}
case 7157:{f.Push(f.Locals[15]);f.Pc=7159;continue;}
case 7159:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",7162);}
case 7162:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7165);}
case 7165:{f.StackOp("pop");f.Pc=7166;continue;}
case 7166:{f.Push(f.Locals[17]);f.Pc=7168;continue;}
case 7168:{f.Push(f.Locals[14]);f.Pc=7170;continue;}
case 7170:{f.Push(JValue.I(2));f.Pc=7171;continue;}
case 7171:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=7172;continue;}
case 7172:{f.Push(JValue.R(rt.String("XMin1")));f.Pc=7175;continue;}
case 7175:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",7178);}
case 7178:{f.Pc=f.Pop().Int==0?7187:7181;continue;}
case 7181:{f.Push(JValue.R(rt.String(". X can't be 0.")));f.Pc=7184;continue;}
case 7184:{f.Pc=7190;continue;}
case 7187:{f.Push(JValue.R(rt.String("")));f.Pc=7190;continue;}
case 7190:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7193);}
case 7193:{f.StackOp("pop");f.Pc=7194;continue;}
case 7194:{f.Push(f.Locals[17]);f.Pc=7196;continue;}
case 7196:{f.Push(JValue.R(rt.String(" (")));f.Pc=7199;continue;}
case 7199:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7202);}
case 7202:{f.Push(f.Locals[0]);f.Pc=7203;continue;}
case 7203:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",7208);}
case 7208:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7211);}
case 7211:{f.Push(JValue.R(rt.String(")")));f.Pc=7214;continue;}
case 7214:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7217);}
case 7217:{f.StackOp("pop");f.Pc=7218;continue;}
case 7218:{f.Push(f.Locals[16]);f.Pc=7220;continue;}
case 7220:{f.Push(f.Locals[17]);f.Pc=7222;continue;}
case 7222:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",7225);}
case 7225:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",7228);}
case 7228:{f.Push(JValue.R(rt.String("X")));f.Pc=7230;continue;}
case 7230:{f.Locals[18]=f.Pop();f.Pc=7232;continue;}
case 7232:{f.Push(f.Locals[16]);f.Pc=7234;continue;}
case 7234:{f.Push(f.Locals[18]);f.Pc=7236;continue;}
case 7236:{f.Push(f.Locals[1]);f.Pc=7237;continue;}
case 7237:{f.Push(f.Locals[18]);f.Pc=7239;continue;}
case 7239:{return rt.Call(f,"forge/game/card/CardState","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",7242);}
case 7242:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",7245);}
case 7245:{f.Push(f.Locals[16]);f.Pc=7247;continue;}
case 7247:{f.Push(f.Locals[1]);f.Pc=7248;continue;}
case 7248:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",7251);}
case 7251:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=7254;continue;}
case 7254:{f.StackOp("dup");f.Pc=7255;continue;}
case 7255:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7258);}
case 7258:{f.Locals[19]=f.Pop();f.Pc=7260;continue;}
case 7260:{f.Push(f.Locals[19]);f.Pc=7262;continue;}
case 7262:{f.Push(f.Locals[1]);f.Pc=7263;continue;}
case 7263:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",7266);}
case 7266:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7269);}
case 7269:{f.Push(JValue.R(rt.String(" suspending for ")));f.Pc=7272;continue;}
case 7272:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7275);}
case 7275:{f.StackOp("pop");f.Pc=7276;continue;}
case 7276:{f.Push(f.Locals[19]);f.Pc=7278;continue;}
case 7278:{f.Push(f.Locals[14]);f.Pc=7280;continue;}
case 7280:{f.Push(JValue.I(1));f.Pc=7281;continue;}
case 7281:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=7282;continue;}
case 7282:{f.Push(JValue.R(rt.String("turn")));f.Pc=7285;continue;}
case 7285:{return rt.Call(f,"forge/util/Lang","nounWithNumeral","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",7288);}
case 7288:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7291);}
case 7291:{f.Push(JValue.R(rt.String(".")));f.Pc=7294;continue;}
case 7294:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7297);}
case 7297:{f.StackOp("pop");f.Pc=7298;continue;}
case 7298:{f.Push(f.Locals[16]);f.Pc=7300;continue;}
case 7300:{f.Push(f.Locals[19]);f.Pc=7302;continue;}
case 7302:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",7305);}
case 7305:{return rt.Call(f,"forge/game/spellability/SpellAbility","setStackDescription","(Ljava/lang/String;)V","invokevirtual",7308);}
case 7308:{f.Push(f.Locals[16]);f.Pc=7310;continue;}
case 7310:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",7313);}
case 7313:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=7316;continue;}
case 7316:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",7319);}
case 7319:{f.Push(f.Locals[0]);f.Pc=7320;continue;}
case 7320:{f.Push(f.Locals[16]);f.Pc=7322;continue;}
case 7322:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",7327);}
case 7327:{f.Pc=8390;continue;}
case 7330:{f.Push(f.Locals[3]);f.Pc=7331;continue;}
case 7331:{f.Push(JValue.R(rt.String("Transfigure")));f.Pc=7334;continue;}
case 7334:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7337);}
case 7337:{f.Pc=f.Pop().Int==0?7411:7340;continue;}
case 7340:{f.Push(f.Locals[3]);f.Pc=7341;continue;}
case 7341:{f.Push(JValue.R(rt.String(":")));f.Pc=7344;continue;}
case 7344:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",7347);}
case 7347:{f.Locals[14]=f.Pop();f.Pc=7349;continue;}
case 7349:{f.Push(f.Locals[14]);f.Pc=7351;continue;}
case 7351:{f.Push(JValue.I(1));f.Pc=7352;continue;}
case 7352:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=7353;continue;}
case 7353:{f.Locals[15]=f.Pop();f.Pc=7355;continue;}
case 7355:{f.Push(f.Locals[15]);f.Pc=7357;continue;}
case 7357:{f.Push(f.Locals[15]);f.Pc=7359;continue;}
case 7359:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",7362);}
case 7362:{f.Push(f.Locals[0]);f.Pc=7363;continue;}
case 7363:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",7368);}
case 7368:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:7368:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",7373);}
case 7373:{f.Locals[16]=f.Pop();f.Pc=7375;continue;}
case 7375:{f.Push(f.Locals[16]);f.Pc=7377;continue;}
case 7377:{f.Push(f.Locals[1]);f.Pc=7378;continue;}
case 7378:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",7381);}
case 7381:{f.Locals[17]=f.Pop();f.Pc=7383;continue;}
case 7383:{f.Push(f.Locals[17]);f.Pc=7385;continue;}
case 7385:{f.Push(JValue.R(rt.String("TransfigureX")));f.Pc=7388;continue;}
case 7388:{f.Push(JValue.R(rt.String("Count$CardManaCost")));f.Pc=7391;continue;}
case 7391:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",7394);}
case 7394:{f.Push(f.Locals[17]);f.Pc=7396;continue;}
case 7396:{f.Push(f.Locals[2]);f.Pc=7397;continue;}
case 7397:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",7400);}
case 7400:{f.Push(f.Locals[0]);f.Pc=7401;continue;}
case 7401:{f.Push(f.Locals[17]);f.Pc=7403;continue;}
case 7403:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",7408);}
case 7408:{f.Pc=8390;continue;}
case 7411:{f.Push(f.Locals[3]);f.Pc=7412;continue;}
case 7412:{f.Push(JValue.R(rt.String("Transmute")));f.Pc=7415;continue;}
case 7415:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7418);}
case 7418:{f.Pc=f.Pop().Int==0?7492:7421;continue;}
case 7421:{f.Push(f.Locals[3]);f.Pc=7422;continue;}
case 7422:{f.Push(JValue.R(rt.String(":")));f.Pc=7425;continue;}
case 7425:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",7428);}
case 7428:{f.Locals[14]=f.Pop();f.Pc=7430;continue;}
case 7430:{f.Push(f.Locals[14]);f.Pc=7432;continue;}
case 7432:{f.Push(JValue.I(1));f.Pc=7433;continue;}
case 7433:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=7434;continue;}
case 7434:{f.Locals[15]=f.Pop();f.Pc=7436;continue;}
case 7436:{f.Push(f.Locals[15]);f.Pc=7438;continue;}
case 7438:{f.Push(f.Locals[15]);f.Pc=7440;continue;}
case 7440:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",7443);}
case 7443:{f.Push(f.Locals[0]);f.Pc=7444;continue;}
case 7444:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",7449);}
case 7449:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:7449:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",7454);}
case 7454:{f.Locals[16]=f.Pop();f.Pc=7456;continue;}
case 7456:{f.Push(f.Locals[16]);f.Pc=7458;continue;}
case 7458:{f.Push(f.Locals[1]);f.Pc=7459;continue;}
case 7459:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",7462);}
case 7462:{f.Locals[17]=f.Pop();f.Pc=7464;continue;}
case 7464:{f.Push(f.Locals[17]);f.Pc=7466;continue;}
case 7466:{f.Push(JValue.R(rt.String("TransmuteX")));f.Pc=7469;continue;}
case 7469:{f.Push(JValue.R(rt.String("Count$CardManaCost")));f.Pc=7472;continue;}
case 7472:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",7475);}
case 7475:{f.Push(f.Locals[17]);f.Pc=7477;continue;}
case 7477:{f.Push(f.Locals[2]);f.Pc=7478;continue;}
case 7478:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",7481);}
case 7481:{f.Push(f.Locals[0]);f.Pc=7482;continue;}
case 7482:{f.Push(f.Locals[17]);f.Pc=7484;continue;}
case 7484:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",7489);}
case 7489:{f.Pc=8390;continue;}
case 7492:{f.Push(f.Locals[3]);f.Pc=7493;continue;}
case 7493:{f.Push(JValue.R(rt.String("Unearth")));f.Pc=7496;continue;}
case 7496:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7499);}
case 7499:{f.Pc=f.Pop().Int==0?7562:7502;continue;}
case 7502:{f.Push(f.Locals[3]);f.Pc=7503;continue;}
case 7503:{f.Push(JValue.R(rt.String(":")));f.Pc=7506;continue;}
case 7506:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",7509);}
case 7509:{f.Locals[14]=f.Pop();f.Pc=7511;continue;}
case 7511:{f.Push(f.Locals[14]);f.Pc=7513;continue;}
case 7513:{f.Push(JValue.I(1));f.Pc=7514;continue;}
case 7514:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=7515;continue;}
case 7515:{f.Locals[15]=f.Pop();f.Pc=7517;continue;}
case 7517:{f.Push(f.Locals[15]);f.Pc=7519;continue;}
case 7519:{f.Push(f.Locals[15]);f.Pc=7521;continue;}
case 7521:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",7524);}
case 7524:{f.Push(f.Locals[0]);f.Pc=7525;continue;}
case 7525:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",7530);}
case 7530:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:7530:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",7535);}
case 7535:{f.Locals[16]=f.Pop();f.Pc=7537;continue;}
case 7537:{f.Push(f.Locals[16]);f.Pc=7539;continue;}
case 7539:{f.Push(f.Locals[1]);f.Pc=7540;continue;}
case 7540:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",7543);}
case 7543:{f.Locals[17]=f.Pop();f.Pc=7545;continue;}
case 7545:{f.Push(f.Locals[17]);f.Pc=7547;continue;}
case 7547:{f.Push(f.Locals[2]);f.Pc=7548;continue;}
case 7548:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",7551);}
case 7551:{f.Push(f.Locals[0]);f.Pc=7552;continue;}
case 7552:{f.Push(f.Locals[17]);f.Pc=7554;continue;}
case 7554:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",7559);}
case 7559:{f.Pc=8390;continue;}
case 7562:{f.Push(f.Locals[3]);f.Pc=7563;continue;}
case 7563:{f.Push(JValue.R(rt.String("Warp")));f.Pc=7566;continue;}
case 7566:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7569);}
case 7569:{f.Pc=f.Pop().Int==0?7777:7572;continue;}
case 7572:{f.Push(f.Locals[3]);f.Pc=7573;continue;}
case 7573:{f.Push(JValue.R(rt.String(":")));f.Pc=7576;continue;}
case 7576:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",7579);}
case 7579:{f.Locals[14]=f.Pop();f.Pc=7581;continue;}
case 7581:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=7584;continue;}
case 7584:{f.StackOp("dup");f.Pc=7585;continue;}
case 7585:{f.Push(f.Locals[14]);f.Pc=7587;continue;}
case 7587:{f.Push(JValue.I(1));f.Pc=7588;continue;}
case 7588:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=7589;continue;}
case 7589:{f.Push(JValue.I(1));f.Pc=7590;continue;}
case 7590:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",7593);}
case 7593:{f.Locals[15]=f.Pop();f.Pc=7595;continue;}
case 7595:{f.Push(f.Locals[1]);f.Pc=7596;continue;}
case 7596:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",7599);}
case 7599:{f.Push(f.Locals[15]);f.Pc=7601;continue;}
case 7601:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithDefinedCost","(Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",7604);}
case 7604:{f.Locals[16]=f.Pop();f.Pc=7606;continue;}
case 7606:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=7609;continue;}
case 7609:{f.StackOp("dup");f.Pc=7610;continue;}
case 7610:{f.Push(JValue.R(rt.String("Warp")));f.Pc=7613;continue;}
case 7613:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",7616);}
case 7616:{f.Locals[17]=f.Pop();f.Pc=7618;continue;}
case 7618:{f.Push(f.Locals[15]);f.Pc=7620;continue;}
case 7620:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",7623);}
case 7623:{f.Pc=f.Pop().Int!=0?7638:7626;continue;}
case 7626:{f.Push(f.Locals[17]);f.Pc=7628;continue;}
case 7628:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=7631;continue;}
case 7631:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7634);}
case 7634:{f.StackOp("pop");f.Pc=7635;continue;}
case 7635:{f.Pc=7647;continue;}
case 7638:{f.Push(f.Locals[17]);f.Pc=7640;continue;}
case 7640:{f.Push(JValue.R(rt.String(" ")));f.Pc=7643;continue;}
case 7643:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7646);}
case 7646:{f.StackOp("pop");f.Pc=7647;continue;}
case 7647:{f.Push(f.Locals[16]);f.Pc=7649;continue;}
case 7649:{f.Push(JValue.R(rt.String("PrecostDesc")));f.Pc=7652;continue;}
case 7652:{f.Push(f.Locals[17]);f.Pc=7654;continue;}
case 7654:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",7657);}
case 7657:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",7660);}
case 7660:{f.StackOp("pop");f.Pc=7661;continue;}
case 7661:{f.Push(f.Locals[16]);f.Pc=7663;continue;}
case 7663:{f.Push(JValue.R(rt.String("CostDesc")));f.Pc=7666;continue;}
case 7666:{f.Push(f.Locals[15]);f.Pc=7668;continue;}
case 7668:{return rt.Call(f,"forge/game/cost/Cost","toString","()Ljava/lang/String;","invokevirtual",7671);}
case 7671:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",7674);}
case 7674:{f.StackOp("pop");f.Pc=7675;continue;}
case 7675:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=7678;continue;}
case 7678:{f.StackOp("dup");f.Pc=7679;continue;}
case 7679:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7682);}
case 7682:{f.Locals[18]=f.Pop();f.Pc=7684;continue;}
case 7684:{f.Push(f.Locals[18]);f.Pc=7686;continue;}
case 7686:{f.Push(f.Locals[16]);f.Pc=7688;continue;}
case 7688:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCostDescription","()Ljava/lang/String;","invokevirtual",7691);}
case 7691:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7694);}
case 7694:{f.StackOp("pop");f.Pc=7695;continue;}
case 7695:{f.Push(f.Locals[18]);f.Pc=7697;continue;}
case 7697:{f.Push(JValue.R(rt.String("(")));f.Pc=7700;continue;}
case 7700:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7703);}
case 7703:{f.Push(f.Locals[0]);f.Pc=7704;continue;}
case 7704:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",7709);}
case 7709:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7712);}
case 7712:{f.Push(JValue.R(rt.String(")")));f.Pc=7715;continue;}
case 7715:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7718);}
case 7718:{f.StackOp("pop");f.Pc=7719;continue;}
case 7719:{f.Push(f.Locals[16]);f.Pc=7721;continue;}
case 7721:{f.Push(f.Locals[18]);f.Pc=7723;continue;}
case 7723:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",7726);}
case 7726:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",7729);}
case 7729:{f.Push(f.Locals[16]);f.Pc=7731;continue;}
case 7731:{f.Push(JValue.R(rt.String("AfterDescription")));f.Pc=7734;continue;}
case 7734:{f.Push(JValue.R(rt.String("(Warped)")));f.Pc=7737;continue;}
case 7737:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",7740);}
case 7740:{f.StackOp("pop");f.Pc=7741;continue;}
case 7741:{f.Push(f.Locals[16]);f.Pc=7743;continue;}
case 7743:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",7746);}
case 7746:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=7749;continue;}
case 7749:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",7752);}
case 7752:{f.Push(f.Locals[16]);f.Pc=7754;continue;}
case 7754:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Warp","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Warp","Lforge/game/spellability/AlternativeCost;"));f.Pc=7757;continue;}
case 7757:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",7760);}
case 7760:{f.Push(f.Locals[16]);f.Pc=7762;continue;}
case 7762:{f.Push(f.Locals[2]);f.Pc=7763;continue;}
case 7763:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",7766);}
case 7766:{f.Push(f.Locals[0]);f.Pc=7767;continue;}
case 7767:{f.Push(f.Locals[16]);f.Pc=7769;continue;}
case 7769:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",7774);}
case 7774:{f.Pc=8390;continue;}
case 7777:{f.Push(f.Locals[3]);f.Pc=7778;continue;}
case 7778:{f.Push(JValue.R(rt.String("Web-slinging")));f.Pc=7781;continue;}
case 7781:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7784);}
case 7784:{f.Pc=f.Pop().Int==0?7983:7787;continue;}
case 7787:{f.Push(f.Locals[3]);f.Pc=7788;continue;}
case 7788:{f.Push(JValue.R(rt.String(":")));f.Pc=7791;continue;}
case 7791:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",7794);}
case 7794:{f.Locals[14]=f.Pop();f.Pc=7796;continue;}
case 7796:{f.Push(f.Locals[14]);f.Pc=7798;continue;}
case 7798:{f.Push(JValue.I(1));f.Pc=7799;continue;}
case 7799:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=7800;continue;}
case 7800:{f.Locals[15]=f.Pop();f.Pc=7802;continue;}
case 7802:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=7805;continue;}
case 7805:{f.StackOp("dup");f.Pc=7806;continue;}
case 7806:{f.Push(f.Locals[15]);f.Pc=7808;continue;}
case 7808:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:7808:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",7813);}
case 7813:{f.Push(JValue.I(0));f.Pc=7814;continue;}
case 7814:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",7817);}
case 7817:{f.Locals[16]=f.Pop();f.Pc=7819;continue;}
case 7819:{f.Push(f.Locals[1]);f.Pc=7820;continue;}
case 7820:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbilityWithFallback","()Lforge/game/spellability/SpellAbility;","invokevirtual",7823);}
case 7823:{f.Push(f.Locals[4]);f.Pc=7825;continue;}
case 7825:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",7828);}
case 7828:{f.Push(f.Locals[16]);f.Pc=7830;continue;}
case 7830:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithManaCostReplaced","(Lforge/game/player/Player;Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",7833);}
case 7833:{f.Locals[17]=f.Pop();f.Pc=7835;continue;}
case 7835:{f.Push(f.Locals[14]);f.Pc=7837;continue;}
case 7837:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=7838;continue;}
case 7838:{f.Push(JValue.I(2));f.Pc=7839;continue;}
case 7839:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?7860:7842;continue;}
case 7842:{f.Push(f.Locals[17]);f.Pc=7844;continue;}
case 7844:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",7847);}
case 7847:{f.Push(JValue.R(rt.String("ValidAfterStack")));f.Pc=7850;continue;}
case 7850:{f.Push(f.Locals[14]);f.Pc=7852;continue;}
case 7852:{f.Push(JValue.I(2));f.Pc=7853;continue;}
case 7853:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=7854;continue;}
case 7854:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",7859);}
case 7859:{f.StackOp("pop");f.Pc=7860;continue;}
case 7860:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=7863;continue;}
case 7863:{f.StackOp("dup");f.Pc=7864;continue;}
case 7864:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7867);}
case 7867:{f.Locals[18]=f.Pop();f.Pc=7869;continue;}
case 7869:{f.Push(f.Locals[18]);f.Pc=7871;continue;}
case 7871:{f.Push(JValue.R(rt.String("Web-Slinging ")));f.Pc=7874;continue;}
case 7874:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7877);}
case 7877:{f.Push(f.Locals[15]);f.Pc=7879;continue;}
case 7879:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",7882);}
case 7882:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7885);}
case 7885:{f.Push(JValue.R(rt.String(" (")));f.Pc=7888;continue;}
case 7888:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7891);}
case 7891:{f.StackOp("pop");f.Pc=7892;continue;}
case 7892:{f.Push(f.Locals[18]);f.Pc=7894;continue;}
case 7894:{f.Push(f.Locals[0]);f.Pc=7895;continue;}
case 7895:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",7900);}
case 7900:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7903);}
case 7903:{f.StackOp("pop");f.Pc=7904;continue;}
case 7904:{f.Push(f.Locals[18]);f.Pc=7906;continue;}
case 7906:{f.Push(JValue.R(rt.String(")")));f.Pc=7909;continue;}
case 7909:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7912);}
case 7912:{f.StackOp("pop");f.Pc=7913;continue;}
case 7913:{f.Push(f.Locals[17]);f.Pc=7915;continue;}
case 7915:{f.Push(f.Locals[18]);f.Pc=7917;continue;}
case 7917:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",7920);}
case 7920:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",7923);}
case 7923:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=7926;continue;}
case 7926:{f.StackOp("dup");f.Pc=7927;continue;}
case 7927:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7930);}
case 7930:{f.Locals[19]=f.Pop();f.Pc=7932;continue;}
case 7932:{f.Push(f.Locals[19]);f.Pc=7934;continue;}
case 7934:{f.Push(f.Locals[1]);f.Pc=7935;continue;}
case 7935:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",7938);}
case 7938:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7941);}
case 7941:{f.Push(JValue.R(rt.String(" (Web-Slinging)")));f.Pc=7944;continue;}
case 7944:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",7947);}
case 7947:{f.StackOp("pop");f.Pc=7948;continue;}
case 7948:{f.Push(f.Locals[17]);f.Pc=7950;continue;}
case 7950:{f.Push(f.Locals[19]);f.Pc=7952;continue;}
case 7952:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",7955);}
case 7955:{return rt.Call(f,"forge/game/spellability/SpellAbility","setStackDescription","(Ljava/lang/String;)V","invokevirtual",7958);}
case 7958:{f.Push(f.Locals[17]);f.Pc=7960;continue;}
case 7960:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","WebSlinging","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","WebSlinging","Lforge/game/spellability/AlternativeCost;"));f.Pc=7963;continue;}
case 7963:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",7966);}
case 7966:{f.Push(f.Locals[17]);f.Pc=7968;continue;}
case 7968:{f.Push(f.Locals[2]);f.Pc=7969;continue;}
case 7969:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",7972);}
case 7972:{f.Push(f.Locals[0]);f.Pc=7973;continue;}
case 7973:{f.Push(f.Locals[17]);f.Pc=7975;continue;}
case 7975:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",7980);}
case 7980:{f.Pc=8390;continue;}
case 7983:{f.Push(f.Locals[3]);f.Pc=7984;continue;}
case 7984:{f.Push(JValue.R(rt.String("Crew")));f.Pc=7987;continue;}
case 7987:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7990);}
case 7990:{f.Pc=f.Pop().Int==0?8066:7993;continue;}
case 7993:{f.Push(f.Locals[3]);f.Pc=7994;continue;}
case 7994:{f.Push(JValue.R(rt.String(":")));f.Pc=7997;continue;}
case 7997:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",8000);}
case 8000:{f.Locals[14]=f.Pop();f.Pc=8002;continue;}
case 8002:{f.Push(f.Locals[14]);f.Pc=8004;continue;}
case 8004:{f.Push(JValue.I(1));f.Pc=8005;continue;}
case 8005:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8006;continue;}
case 8006:{f.Locals[15]=f.Pop();f.Pc=8008;continue;}
case 8008:{f.Push(f.Locals[15]);f.Pc=8010;continue;}
case 8010:{f.Push(f.Locals[15]);f.Pc=8012;continue;}
case 8012:{f.Push(f.Locals[15]);f.Pc=8014;continue;}
case 8014:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:8014:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",8019);}
case 8019:{f.Locals[16]=f.Pop();f.Pc=8021;continue;}
case 8021:{f.Push(f.Locals[14]);f.Pc=8023;continue;}
case 8023:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=8024;continue;}
case 8024:{f.Push(JValue.I(2));f.Pc=8025;continue;}
case 8025:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?8041:8028;continue;}
case 8028:{f.Push(f.Locals[16]);f.Pc=8030;continue;}
case 8030:{f.Push(f.Locals[14]);f.Pc=8032;continue;}
case 8032:{f.Push(JValue.I(2));f.Pc=8033;continue;}
case 8033:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8034;continue;}
case 8034:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5027:8034:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",8039);}
case 8039:{f.Locals[16]=f.Pop();f.Pc=8041;continue;}
case 8041:{f.Push(f.Locals[16]);f.Pc=8043;continue;}
case 8043:{f.Push(f.Locals[1]);f.Pc=8044;continue;}
case 8044:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",8047);}
case 8047:{f.Locals[17]=f.Pop();f.Pc=8049;continue;}
case 8049:{f.Push(f.Locals[17]);f.Pc=8051;continue;}
case 8051:{f.Push(f.Locals[2]);f.Pc=8052;continue;}
case 8052:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",8055);}
case 8055:{f.Push(f.Locals[0]);f.Pc=8056;continue;}
case 8056:{f.Push(f.Locals[17]);f.Pc=8058;continue;}
case 8058:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",8063);}
case 8063:{f.Pc=8390;continue;}
case 8066:{f.Push(f.Locals[3]);f.Pc=8067;continue;}
case 8067:{f.Push(JValue.R(rt.String("Cycling")));f.Pc=8070;continue;}
case 8070:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8073);}
case 8073:{f.Pc=f.Pop().Int==0?8230:8076;continue;}
case 8076:{f.Push(f.Locals[3]);f.Pc=8077;continue;}
case 8077:{f.Push(JValue.R(rt.String(":")));f.Pc=8080;continue;}
case 8080:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",8083);}
case 8083:{f.Locals[14]=f.Pop();f.Pc=8085;continue;}
case 8085:{f.Push(f.Locals[14]);f.Pc=8087;continue;}
case 8087:{f.Push(JValue.I(1));f.Pc=8088;continue;}
case 8088:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8089;continue;}
case 8089:{f.Locals[15]=f.Pop();f.Pc=8091;continue;}
case 8091:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=8094;continue;}
case 8094:{f.StackOp("dup");f.Pc=8095;continue;}
case 8095:{f.Push(f.Locals[15]);f.Pc=8097;continue;}
case 8097:{f.Push(JValue.I(1));f.Pc=8098;continue;}
case 8098:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",8101);}
case 8101:{f.Locals[16]=f.Pop();f.Pc=8103;continue;}
case 8103:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=8106;continue;}
case 8106:{f.StackOp("dup");f.Pc=8107;continue;}
case 8107:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",8110);}
case 8110:{f.Locals[17]=f.Pop();f.Pc=8112;continue;}
case 8112:{f.Push(f.Locals[17]);f.Pc=8114;continue;}
case 8114:{f.Push(JValue.R(rt.String("AB$ Draw | Cost$ ")));f.Pc=8117;continue;}
case 8117:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8120);}
case 8120:{f.StackOp("pop");f.Pc=8121;continue;}
case 8121:{f.Push(f.Locals[17]);f.Pc=8123;continue;}
case 8123:{f.Push(f.Locals[15]);f.Pc=8125;continue;}
case 8125:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8128);}
case 8128:{f.StackOp("pop");f.Pc=8129;continue;}
case 8129:{f.Push(f.Locals[17]);f.Pc=8131;continue;}
case 8131:{f.Push(JValue.R(rt.String(" Discard<1/CARDNAME> | ActivationZone$ Hand | PrecostDesc$ Cycling")));f.Pc=8134;continue;}
case 8134:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8137);}
case 8137:{f.StackOp("pop");f.Pc=8138;continue;}
case 8138:{f.Push(f.Locals[17]);f.Pc=8140;continue;}
case 8140:{f.Push(f.Locals[16]);f.Pc=8142;continue;}
case 8142:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",8145);}
case 8145:{f.Pc=f.Pop().Int==0?8154:8148;continue;}
case 8148:{f.Push(JValue.R(rt.String(" ")));f.Pc=8151;continue;}
case 8151:{f.Pc=8157;continue;}
case 8154:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=8157;continue;}
case 8157:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8160);}
case 8160:{f.StackOp("pop");f.Pc=8161;continue;}
case 8161:{f.Push(f.Locals[17]);f.Pc=8163;continue;}
case 8163:{f.Push(JValue.R(rt.String("| CostDesc$ ")));f.Pc=8166;continue;}
case 8166:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8169);}
case 8169:{f.Push(f.Locals[16]);f.Pc=8171;continue;}
case 8171:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",8174);}
case 8174:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8177);}
case 8177:{f.StackOp("pop");f.Pc=8178;continue;}
case 8178:{f.Push(f.Locals[17]);f.Pc=8180;continue;}
case 8180:{f.Push(JValue.R(rt.String(" | SpellDescription$ (")));f.Pc=8183;continue;}
case 8183:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8186);}
case 8186:{f.Push(f.Locals[0]);f.Pc=8187;continue;}
case 8187:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",8192);}
case 8192:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8195);}
case 8195:{f.Push(JValue.R(rt.String(")")));f.Pc=8198;continue;}
case 8198:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8201);}
case 8201:{f.StackOp("pop");f.Pc=8202;continue;}
case 8202:{f.Push(f.Locals[17]);f.Pc=8204;continue;}
case 8204:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",8207);}
case 8207:{f.Push(f.Locals[1]);f.Pc=8208;continue;}
case 8208:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",8211);}
case 8211:{f.Locals[18]=f.Pop();f.Pc=8213;continue;}
case 8213:{f.Push(f.Locals[18]);f.Pc=8215;continue;}
case 8215:{f.Push(f.Locals[2]);f.Pc=8216;continue;}
case 8216:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",8219);}
case 8219:{f.Push(f.Locals[0]);f.Pc=8220;continue;}
case 8220:{f.Push(f.Locals[18]);f.Pc=8222;continue;}
case 8222:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",8227);}
case 8227:{f.Pc=8390;continue;}
case 8230:{f.Push(f.Locals[3]);f.Pc=8231;continue;}
case 8231:{f.Push(JValue.R(rt.String("TypeCycling")));f.Pc=8234;continue;}
case 8234:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8237);}
case 8237:{f.Pc=f.Pop().Int==0?8390:8240;continue;}
case 8240:{f.Push(f.Locals[0]);f.Pc=8241;continue;}
case 8241:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/KeywordWithCostAndType")?1:0));f.Pc=8244;continue;}
case 8244:{f.Pc=f.Pop().Int==0?8390:8247;continue;}
case 8247:{f.Push(f.Locals[0]);f.Pc=8248;continue;}
case 8248:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordWithCostAndType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8251;continue;}
case 8251:{f.Locals[13]=f.Pop();f.Pc=8253;continue;}
case 8253:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=8256;continue;}
case 8256:{f.StackOp("dup");f.Pc=8257;continue;}
case 8257:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",8260);}
case 8260:{f.Locals[14]=f.Pop();f.Pc=8262;continue;}
case 8262:{f.Push(f.Locals[14]);f.Pc=8264;continue;}
case 8264:{f.Push(JValue.R(rt.String("AB$ ChangeZone | Cost$ ")));f.Pc=8267;continue;}
case 8267:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8270);}
case 8270:{f.Push(f.Locals[13]);f.Pc=8272;continue;}
case 8272:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndType","getCostString","()Ljava/lang/String;","invokevirtual",8275);}
case 8275:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8278);}
case 8278:{f.StackOp("pop");f.Pc=8279;continue;}
case 8279:{f.Push(f.Locals[14]);f.Pc=8281;continue;}
case 8281:{f.Push(JValue.R(rt.String(" Discard<1/CARDNAME> | ActivationZone$ Hand | PrecostDesc$ ")));f.Pc=8284;continue;}
case 8284:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8287);}
case 8287:{f.Push(f.Locals[13]);f.Pc=8289;continue;}
case 8289:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndType","getTitleWithoutCost","()Ljava/lang/String;","invokevirtual",8292);}
case 8292:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8295);}
case 8295:{f.StackOp("pop");f.Pc=8296;continue;}
case 8296:{f.Push(f.Locals[14]);f.Pc=8298;continue;}
case 8298:{f.Push(JValue.R(rt.String(" | CostDesc$ ")));f.Pc=8300;continue;}
case 8300:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8303);}
case 8303:{f.Push(f.Locals[13]);f.Pc=8305;continue;}
case 8305:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndType","getCost","()Lforge/game/cost/Cost;","invokevirtual",8308);}
case 8308:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",8311);}
case 8311:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8314);}
case 8314:{f.StackOp("pop");f.Pc=8315;continue;}
case 8315:{f.Push(f.Locals[14]);f.Pc=8317;continue;}
case 8317:{f.Push(JValue.R(rt.String(" | Origin$ Library | Destination$ Hand")));f.Pc=8320;continue;}
case 8320:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8323);}
case 8323:{f.StackOp("pop");f.Pc=8324;continue;}
case 8324:{f.Push(f.Locals[14]);f.Pc=8326;continue;}
case 8326:{f.Push(JValue.R(rt.String(" | ChangeType$ ")));f.Pc=8329;continue;}
case 8329:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8332);}
case 8332:{f.Push(f.Locals[13]);f.Pc=8334;continue;}
case 8334:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndType","getValidType","()Ljava/lang/String;","invokevirtual",8337);}
case 8337:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8340);}
case 8340:{f.StackOp("pop");f.Pc=8341;continue;}
case 8341:{f.Push(f.Locals[14]);f.Pc=8343;continue;}
case 8343:{f.Push(JValue.R(rt.String(" | SpellDescription$ (")));f.Pc=8346;continue;}
case 8346:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8349);}
case 8349:{f.Push(f.Locals[0]);f.Pc=8350;continue;}
case 8350:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",8355);}
case 8355:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8358);}
case 8358:{f.Push(JValue.R(rt.String(")")));f.Pc=8361;continue;}
case 8361:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",8364);}
case 8364:{f.StackOp("pop");f.Pc=8365;continue;}
case 8365:{f.Push(f.Locals[14]);f.Pc=8367;continue;}
case 8367:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",8370);}
case 8370:{f.Push(f.Locals[1]);f.Pc=8371;continue;}
case 8371:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",8374);}
case 8374:{f.Locals[15]=f.Pop();f.Pc=8376;continue;}
case 8376:{f.Push(f.Locals[15]);f.Pc=8378;continue;}
case 8378:{f.Push(f.Locals[2]);f.Pc=8379;continue;}
case 8379:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",8382);}
case 8382:{f.Push(f.Locals[0]);f.Pc=8383;continue;}
case 8383:{f.Push(f.Locals[15]);f.Pc=8385;continue;}
case 8385:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokeinterface",8390);}
case 8390:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5028(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/Affinity")?1:0));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int==0?182:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/Affinity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/keyword/Affinity","getValidType","()Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Locals[7]=f.Pop();f.Pc=27;continue;}
case 27:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",34);}
case 34:{f.Locals[8]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[8]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("Mode$ ReduceCost | ValidCard$ Card.Self | Type$ Spell | Amount$ AffinityX | EffectZone$ All")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",44);}
case 44:{f.StackOp("pop");f.Pc=45;continue;}
case 45:{f.Push(f.Locals[8]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("| Description$ ")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",53);}
case 53:{f.Push(f.Locals[4]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/keyword/Affinity","getTitle","()Ljava/lang/String;","invokevirtual",58);}
case 58:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Push(f.Locals[8]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String(" (")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",70);}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",76);}
case 76:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",79);}
case 79:{f.Push(JValue.R(rt.String(")")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",85);}
case 85:{f.StackOp("pop");f.Pc=86;continue;}
case 86:{f.Push(f.Locals[8]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",91);}
case 91:{f.Locals[9]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[9]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",99);}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",104);}
case 104:{f.Locals[10]=f.Pop();f.Pc=106;continue;}
case 106:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=109;continue;}
case 109:{f.StackOp("dup");f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",113);}
case 113:{f.Locals[11]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[11]);f.Pc=117;continue;}
case 117:{f.Push(JValue.R(rt.String("Count$Valid ")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",123);}
case 123:{f.Push(f.Locals[7]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",128);}
case 128:{f.Push(f.Locals[7]);f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String(".")));f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",136);}
case 136:{f.Pc=f.Pop().Int==0?145:139;continue;}
case 139:{f.Push(JValue.R(rt.String("+")));f.Pc=142;continue;}
case 142:{f.Pc=148;continue;}
case 145:{f.Push(JValue.R(rt.String(".")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",151);}
case 151:{f.Push(JValue.R(rt.String("YouCtrl")));f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",157);}
case 157:{f.StackOp("pop");f.Pc=158;continue;}
case 158:{f.Push(f.Locals[10]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("AffinityX")));f.Pc=163;continue;}
case 163:{f.Push(f.Locals[11]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",168);}
case 168:{return rt.Call(f,"forge/game/staticability/StaticAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",171);}
case 171:{f.Push(f.Locals[0]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[10]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",179);}
case 179:{f.Pc=2675;continue;}
case 182:{f.Push(f.Locals[3]);f.Pc=183;continue;}
case 183:{f.Push(JValue.R(rt.String("Blitz")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",189);}
case 189:{f.Pc=f.Pop().Int==0?343:192;continue;}
case 192:{f.Push(f.Locals[3]);f.Pc=193;continue;}
case 193:{f.Push(JValue.R(rt.String(":")));f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",199);}
case 199:{f.Locals[7]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[7]);f.Pc=203;continue;}
case 203:{f.Push(JValue.I(1));f.Pc=204;continue;}
case 204:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=205;continue;}
case 205:{f.Locals[8]=f.Pop();f.Pc=207;continue;}
case 207:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=210;continue;}
case 210:{f.StackOp("dup");f.Pc=211;continue;}
case 211:{f.Push(f.Locals[8]);f.Pc=213;continue;}
case 213:{f.Push(JValue.I(0));f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",217);}
case 217:{f.Locals[9]=f.Pop();f.Pc=219;continue;}
case 219:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=222;continue;}
case 222:{f.StackOp("dup");f.Pc=223;continue;}
case 223:{f.Push(JValue.R(rt.String("Blitz")));f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",229);}
case 229:{f.Locals[10]=f.Pop();f.Pc=231;continue;}
case 231:{f.Push(f.Locals[9]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",236);}
case 236:{f.Pc=f.Pop().Int!=0?251:239;continue;}
case 239:{f.Push(f.Locals[10]);f.Pc=241;continue;}
case 241:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",247);}
case 247:{f.StackOp("pop");f.Pc=248;continue;}
case 248:{f.Pc=260;continue;}
case 251:{f.Push(f.Locals[10]);f.Pc=253;continue;}
case 253:{f.Push(JValue.R(rt.String(" ")));f.Pc=256;continue;}
case 256:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",259);}
case 259:{f.StackOp("pop");f.Pc=260;continue;}
case 260:{f.Push(f.Locals[10]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[9]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",267);}
case 267:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",270);}
case 270:{f.StackOp("pop");f.Pc=271;continue;}
case 271:{f.Push(f.Locals[10]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",276);}
case 276:{f.Push(f.Locals[0]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",282);}
case 282:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:282:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",287);}
case 287:{f.Locals[11]=f.Pop();f.Pc=289;continue;}
case 289:{f.Push(JValue.R(rt.String("Mode$ ChangesZone | Origin$ Battlefield | Destination$ Graveyard | ValidCard$ Card.Self | Execute$ TrigDraw | Secondary$ True | TriggerDescription$ When this creature dies, draw a card.")));f.Pc=292;continue;}
case 292:{f.Locals[12]=f.Pop();f.Pc=294;continue;}
case 294:{f.Push(JValue.R(rt.String("DB$ Draw")));f.Pc=297;continue;}
case 297:{f.Locals[13]=f.Pop();f.Pc=299;continue;}
case 299:{f.Push(f.Locals[11]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[1]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",305);}
case 305:{f.Push(f.Locals[1]);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[2]);f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",310);}
case 310:{f.Locals[14]=f.Pop();f.Pc=312;continue;}
case 312:{f.Push(f.Locals[14]);f.Pc=314;continue;}
case 314:{f.Push(JValue.R(rt.String("Dies")));f.Pc=317;continue;}
case 317:{f.Push(f.Locals[12]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/staticability/StaticAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",322);}
case 322:{f.Push(f.Locals[14]);f.Pc=324;continue;}
case 324:{f.Push(JValue.R(rt.String("TrigDraw")));f.Pc=327;continue;}
case 327:{f.Push(f.Locals[13]);f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/staticability/StaticAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",332);}
case 332:{f.Push(f.Locals[0]);f.Pc=333;continue;}
case 333:{f.Push(f.Locals[14]);f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",340);}
case 340:{f.Pc=2675;continue;}
case 343:{f.Push(f.Locals[3]);f.Pc=344;continue;}
case 344:{f.Push(JValue.R(rt.String("Changeling")));f.Pc=347;continue;}
case 347:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",350);}
case 350:{f.Pc=f.Pop().Int==0?386:353;continue;}
case 353:{f.Push(f.Locals[0]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",359);}
case 359:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:359:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",364);}
case 364:{f.Locals[7]=f.Pop();f.Pc=366;continue;}
case 366:{f.Push(f.Locals[0]);f.Pc=367;continue;}
case 367:{f.Push(f.Locals[7]);f.Pc=369;continue;}
case 369:{f.Push(f.Locals[1]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",373);}
case 373:{f.Push(f.Locals[1]);f.Pc=374;continue;}
case 374:{f.Push(f.Locals[2]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",378);}
case 378:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",383);}
case 383:{f.Pc=2675;continue;}
case 386:{f.Push(f.Locals[3]);f.Pc=387;continue;}
case 387:{f.Push(JValue.R(rt.String("Cipher")));f.Pc=390;continue;}
case 390:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",393);}
case 393:{f.Pc=f.Pop().Int==0?562:396;continue;}
case 396:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=399;continue;}
case 399:{f.StackOp("dup");f.Pc=400;continue;}
case 400:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",403);}
case 403:{f.Locals[7]=f.Pop();f.Pc=405;continue;}
case 405:{f.Push(f.Locals[7]);f.Pc=407;continue;}
case 407:{f.Push(JValue.R(rt.String("Mode$ Continuous | EffectZone$ Exile | Affected$ Card.EncodedWithSource")));f.Pc=410;continue;}
case 410:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",413);}
case 413:{f.StackOp("pop");f.Pc=414;continue;}
case 414:{f.Push(f.Locals[7]);f.Pc=416;continue;}
case 416:{f.Push(JValue.R(rt.String(" | AddTrigger$ CipherTrigger")));f.Pc=419;continue;}
case 419:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",422);}
case 422:{f.StackOp("pop");f.Pc=423;continue;}
case 423:{f.Push(f.Locals[7]);f.Pc=425;continue;}
case 425:{f.Push(JValue.R(rt.String(" | Description$ Cipher (")));f.Pc=428;continue;}
case 428:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",431);}
case 431:{f.Push(f.Locals[0]);f.Pc=432;continue;}
case 432:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",437);}
case 437:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",440);}
case 440:{f.Push(JValue.R(rt.String(")")));f.Pc=443;continue;}
case 443:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",446);}
case 446:{f.StackOp("pop");f.Pc=447;continue;}
case 447:{f.Push(f.Locals[7]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",452);}
case 452:{f.Locals[8]=f.Pop();f.Pc=454;continue;}
case 454:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=457;continue;}
case 457:{f.StackOp("dup");f.Pc=458;continue;}
case 458:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",461);}
case 461:{f.Locals[7]=f.Pop();f.Pc=463;continue;}
case 463:{f.Push(f.Locals[7]);f.Pc=465;continue;}
case 465:{f.Push(JValue.R(rt.String("Mode$ DamageDone | ValidSource$ Card.Self | ValidTarget$ Player | Execute$ PlayEncoded")));f.Pc=468;continue;}
case 468:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",471);}
case 471:{f.StackOp("pop");f.Pc=472;continue;}
case 472:{f.Push(f.Locals[7]);f.Pc=474;continue;}
case 474:{f.Push(JValue.R(rt.String(" | CombatDamage$ True | OptionalDecider$ You | TriggerDescription$ ")));f.Pc=477;continue;}
case 477:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",480);}
case 480:{f.StackOp("pop");f.Pc=481;continue;}
case 481:{f.Push(f.Locals[7]);f.Pc=483;continue;}
case 483:{f.Push(JValue.R(rt.String("Whenever CARDNAME deals combat damage to a player, its controller may cast a copy of ")));f.Pc=486;continue;}
case 486:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",489);}
case 489:{f.StackOp("pop");f.Pc=490;continue;}
case 490:{f.Push(f.Locals[7]);f.Pc=492;continue;}
case 492:{f.Push(f.Locals[1]);f.Pc=493;continue;}
case 493:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",496);}
case 496:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",499);}
case 499:{f.Push(JValue.R(rt.String(" without paying its mana cost.")));f.Pc=502;continue;}
case 502:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",505);}
case 505:{f.StackOp("pop");f.Pc=506;continue;}
case 506:{f.Push(f.Locals[7]);f.Pc=508;continue;}
case 508:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",511);}
case 511:{f.Locals[9]=f.Pop();f.Pc=513;continue;}
case 513:{f.Push(JValue.R(rt.String("DB$ Play | Defined$ OriginalHost | WithoutManaCost$ True | CopyCard$ True")));f.Pc=516;continue;}
case 516:{f.Locals[10]=f.Pop();f.Pc=518;continue;}
case 518:{f.Push(f.Locals[8]);f.Pc=520;continue;}
case 520:{f.Push(f.Locals[1]);f.Pc=521;continue;}
case 521:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",524);}
case 524:{f.Push(f.Locals[1]);f.Pc=525;continue;}
case 525:{f.Push(f.Locals[2]);f.Pc=526;continue;}
case 526:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",529);}
case 529:{f.Locals[11]=f.Pop();f.Pc=531;continue;}
case 531:{f.Push(f.Locals[11]);f.Pc=533;continue;}
case 533:{f.Push(JValue.R(rt.String("CipherTrigger")));f.Pc=536;continue;}
case 536:{f.Push(f.Locals[9]);f.Pc=538;continue;}
case 538:{return rt.Call(f,"forge/game/staticability/StaticAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",541);}
case 541:{f.Push(f.Locals[11]);f.Pc=543;continue;}
case 543:{f.Push(JValue.R(rt.String("PlayEncoded")));f.Pc=546;continue;}
case 546:{f.Push(f.Locals[10]);f.Pc=548;continue;}
case 548:{return rt.Call(f,"forge/game/staticability/StaticAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",551);}
case 551:{f.Push(f.Locals[0]);f.Pc=552;continue;}
case 552:{f.Push(f.Locals[11]);f.Pc=554;continue;}
case 554:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",559);}
case 559:{f.Pc=2675;continue;}
case 562:{f.Push(f.Locals[3]);f.Pc=563;continue;}
case 563:{f.Push(JValue.R(rt.String("Class")));f.Pc=566;continue;}
case 566:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",569);}
case 569:{f.Pc=f.Pop().Int==0?977:572;continue;}
case 572:{f.Push(f.Locals[3]);f.Pc=573;continue;}
case 573:{f.Push(JValue.R(rt.String(":")));f.Pc=576;continue;}
case 576:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",579);}
case 579:{f.Locals[7]=f.Pop();f.Pc=581;continue;}
case 581:{f.Push(f.Locals[7]);f.Pc=583;continue;}
case 583:{f.Push(JValue.I(1));f.Pc=584;continue;}
case 584:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=585;continue;}
case 585:{f.Locals[8]=f.Pop();f.Pc=587;continue;}
case 587:{f.Push(f.Locals[7]);f.Pc=589;continue;}
case 589:{f.Push(JValue.I(3));f.Pc=590;continue;}
case 590:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=591;continue;}
case 591:{f.Locals[9]=f.Pop();f.Pc=593;continue;}
case 593:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=596;continue;}
case 596:{f.StackOp("dup");f.Pc=597;continue;}
case 597:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",600);}
case 600:{f.Locals[10]=f.Pop();f.Pc=602;continue;}
case 602:{f.Push(JValue.I(0));f.Pc=603;continue;}
case 603:{f.Locals[11]=f.Pop();f.Pc=605;continue;}
case 605:{f.Push(f.Locals[9]);f.Pc=607;continue;}
case 607:{return rt.Call(f,"forge/game/ability/AbilityFactory","getMapParams","(Ljava/lang/String;)Ljava/util/Map;","invokestatic",610);}
case 610:{f.Locals[12]=f.Pop();f.Pc=612;continue;}
case 612:{f.Push(f.Locals[12]);f.Pc=614;continue;}
case 614:{f.Push(JValue.R(rt.String("AddTrigger")));f.Pc=617;continue;}
case 617:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",622);}
case 622:{f.Pc=f.Pop().Int==0?717:625;continue;}
case 625:{f.Push(f.Locals[12]);f.Pc=627;continue;}
case 627:{f.Push(JValue.R(rt.String("AddTrigger")));f.Pc=630;continue;}
case 630:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",635);}
case 635:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=638;continue;}
case 638:{f.Push(JValue.R(rt.String(" & ")));f.Pc=641;continue;}
case 641:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",644);}
case 644:{f.Locals[13]=f.Pop();f.Pc=646;continue;}
case 646:{f.Push(f.Locals[13]);f.Pc=648;continue;}
case 648:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=649;continue;}
case 649:{f.Locals[14]=f.Pop();f.Pc=651;continue;}
case 651:{f.Push(JValue.I(0));f.Pc=652;continue;}
case 652:{f.Locals[15]=f.Pop();f.Pc=654;continue;}
case 654:{f.Push(f.Locals[15]);f.Pc=656;continue;}
case 656:{f.Push(f.Locals[14]);f.Pc=658;continue;}
case 658:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?717:661;continue;}
case 661:{f.Push(f.Locals[13]);f.Pc=663;continue;}
case 663:{f.Push(f.Locals[15]);f.Pc=665;continue;}
case 665:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=666;continue;}
case 666:{f.Locals[16]=f.Pop();f.Pc=668;continue;}
case 668:{f.Push(f.Locals[11]);f.Pc=670;continue;}
case 670:{f.Pc=f.Pop().Int==0?682:673;continue;}
case 673:{f.Push(f.Locals[10]);f.Pc=675;continue;}
case 675:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=678;continue;}
case 678:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",681);}
case 681:{f.StackOp("pop");f.Pc=682;continue;}
case 682:{f.Push(f.Locals[10]);f.Pc=684;continue;}
case 684:{f.Push(f.Locals[1]);f.Pc=685;continue;}
case 685:{f.Push(f.Locals[16]);f.Pc=687;continue;}
case 687:{return rt.Call(f,"forge/game/card/CardState","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",690);}
case 690:{return rt.Call(f,"forge/game/ability/AbilityFactory","getMapParams","(Ljava/lang/String;)Ljava/util/Map;","invokestatic",693);}
case 693:{f.Push(JValue.R(rt.String("TriggerDescription")));f.Pc=696;continue;}
case 696:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",701);}
case 701:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=704;continue;}
case 704:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",707);}
case 707:{f.StackOp("pop");f.Pc=708;continue;}
case 708:{f.Push(JValue.I(1));f.Pc=709;continue;}
case 709:{f.Locals[11]=f.Pop();f.Pc=711;continue;}
case 711:{f.Locals[15]=JValue.I(unchecked(f.Locals[15].Int+(1)));f.Pc=714;continue;}
case 714:{f.Pc=654;continue;}
case 717:{f.Push(f.Locals[12]);f.Pc=719;continue;}
case 719:{f.Push(JValue.R(rt.String("AddStaticAbility")));f.Pc=722;continue;}
case 722:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",727);}
case 727:{f.Pc=f.Pop().Int==0?822:730;continue;}
case 730:{f.Push(f.Locals[12]);f.Pc=732;continue;}
case 732:{f.Push(JValue.R(rt.String("AddStaticAbility")));f.Pc=735;continue;}
case 735:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",740);}
case 740:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=743;continue;}
case 743:{f.Push(JValue.R(rt.String(" & ")));f.Pc=746;continue;}
case 746:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",749);}
case 749:{f.Locals[13]=f.Pop();f.Pc=751;continue;}
case 751:{f.Push(f.Locals[13]);f.Pc=753;continue;}
case 753:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=754;continue;}
case 754:{f.Locals[14]=f.Pop();f.Pc=756;continue;}
case 756:{f.Push(JValue.I(0));f.Pc=757;continue;}
case 757:{f.Locals[15]=f.Pop();f.Pc=759;continue;}
case 759:{f.Push(f.Locals[15]);f.Pc=761;continue;}
case 761:{f.Push(f.Locals[14]);f.Pc=763;continue;}
case 763:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?822:766;continue;}
case 766:{f.Push(f.Locals[13]);f.Pc=768;continue;}
case 768:{f.Push(f.Locals[15]);f.Pc=770;continue;}
case 770:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=771;continue;}
case 771:{f.Locals[16]=f.Pop();f.Pc=773;continue;}
case 773:{f.Push(f.Locals[11]);f.Pc=775;continue;}
case 775:{f.Pc=f.Pop().Int==0?787:778;continue;}
case 778:{f.Push(f.Locals[10]);f.Pc=780;continue;}
case 780:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=783;continue;}
case 783:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",786);}
case 786:{f.StackOp("pop");f.Pc=787;continue;}
case 787:{f.Push(f.Locals[10]);f.Pc=789;continue;}
case 789:{f.Push(f.Locals[1]);f.Pc=790;continue;}
case 790:{f.Push(f.Locals[16]);f.Pc=792;continue;}
case 792:{return rt.Call(f,"forge/game/card/CardState","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",795);}
case 795:{return rt.Call(f,"forge/game/ability/AbilityFactory","getMapParams","(Ljava/lang/String;)Ljava/util/Map;","invokestatic",798);}
case 798:{f.Push(JValue.R(rt.String("Description")));f.Pc=801;continue;}
case 801:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",806);}
case 806:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=809;continue;}
case 809:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",812);}
case 812:{f.StackOp("pop");f.Pc=813;continue;}
case 813:{f.Push(JValue.I(1));f.Pc=814;continue;}
case 814:{f.Locals[11]=f.Pop();f.Pc=816;continue;}
case 816:{f.Locals[15]=JValue.I(unchecked(f.Locals[15].Int+(1)));f.Pc=819;continue;}
case 819:{f.Pc=759;continue;}
case 822:{f.Push(f.Locals[12]);f.Pc=824;continue;}
case 824:{f.Push(JValue.R(rt.String("AddReplacementEffect")));f.Pc=827;continue;}
case 827:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",832);}
case 832:{f.Pc=f.Pop().Int==0?927:835;continue;}
case 835:{f.Push(f.Locals[12]);f.Pc=837;continue;}
case 837:{f.Push(JValue.R(rt.String("AddReplacementEffect")));f.Pc=840;continue;}
case 840:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",845);}
case 845:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=848;continue;}
case 848:{f.Push(JValue.R(rt.String(" & ")));f.Pc=851;continue;}
case 851:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",854);}
case 854:{f.Locals[13]=f.Pop();f.Pc=856;continue;}
case 856:{f.Push(f.Locals[13]);f.Pc=858;continue;}
case 858:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=859;continue;}
case 859:{f.Locals[14]=f.Pop();f.Pc=861;continue;}
case 861:{f.Push(JValue.I(0));f.Pc=862;continue;}
case 862:{f.Locals[15]=f.Pop();f.Pc=864;continue;}
case 864:{f.Push(f.Locals[15]);f.Pc=866;continue;}
case 866:{f.Push(f.Locals[14]);f.Pc=868;continue;}
case 868:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?927:871;continue;}
case 871:{f.Push(f.Locals[13]);f.Pc=873;continue;}
case 873:{f.Push(f.Locals[15]);f.Pc=875;continue;}
case 875:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=876;continue;}
case 876:{f.Locals[16]=f.Pop();f.Pc=878;continue;}
case 878:{f.Push(f.Locals[11]);f.Pc=880;continue;}
case 880:{f.Pc=f.Pop().Int==0?892:883;continue;}
case 883:{f.Push(f.Locals[10]);f.Pc=885;continue;}
case 885:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=888;continue;}
case 888:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",891);}
case 891:{f.StackOp("pop");f.Pc=892;continue;}
case 892:{f.Push(f.Locals[10]);f.Pc=894;continue;}
case 894:{f.Push(f.Locals[1]);f.Pc=895;continue;}
case 895:{f.Push(f.Locals[16]);f.Pc=897;continue;}
case 897:{return rt.Call(f,"forge/game/card/CardState","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",900);}
case 900:{return rt.Call(f,"forge/game/ability/AbilityFactory","getMapParams","(Ljava/lang/String;)Ljava/util/Map;","invokestatic",903);}
case 903:{f.Push(JValue.R(rt.String("Description")));f.Pc=906;continue;}
case 906:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",911);}
case 911:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=914;continue;}
case 914:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",917);}
case 917:{f.StackOp("pop");f.Pc=918;continue;}
case 918:{f.Push(JValue.I(1));f.Pc=919;continue;}
case 919:{f.Locals[11]=f.Pop();f.Pc=921;continue;}
case 921:{f.Locals[15]=JValue.I(unchecked(f.Locals[15].Int+(1)));f.Pc=924;continue;}
case 924:{f.Pc=864;continue;}
case 927:{f.Push(f.Locals[8]);f.Pc=929;continue;}
case 929:{f.Push(f.Locals[9]);f.Pc=931;continue;}
case 931:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:931:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",936);}
case 936:{f.Locals[13]=f.Pop();f.Pc=938;continue;}
case 938:{f.Push(f.Locals[11]);f.Pc=940;continue;}
case 940:{f.Pc=f.Pop().Int==0?957:943;continue;}
case 943:{f.Push(f.Locals[13]);f.Pc=945;continue;}
case 945:{f.Push(f.Locals[10]);f.Pc=947;continue;}
case 947:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",950);}
case 950:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:950:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",955);}
case 955:{f.Locals[13]=f.Pop();f.Pc=957;continue;}
case 957:{f.Push(f.Locals[0]);f.Pc=958;continue;}
case 958:{f.Push(f.Locals[13]);f.Pc=960;continue;}
case 960:{f.Push(f.Locals[1]);f.Pc=961;continue;}
case 961:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",964);}
case 964:{f.Push(f.Locals[1]);f.Pc=965;continue;}
case 965:{f.Push(f.Locals[2]);f.Pc=966;continue;}
case 966:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",969);}
case 969:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",974);}
case 974:{f.Pc=2675;continue;}
case 977:{f.Push(f.Locals[3]);f.Pc=978;continue;}
case 978:{f.Push(JValue.R(rt.String("Dash")));f.Pc=981;continue;}
case 981:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",984);}
case 984:{f.Pc=f.Pop().Int==0?1012:987;continue;}
case 987:{f.Push(JValue.R(rt.String("Mode$ Continuous | Affected$ Card.Self+dashed+castKeyword | AddKeyword$ Haste")));f.Pc=990;continue;}
case 990:{f.Locals[7]=f.Pop();f.Pc=992;continue;}
case 992:{f.Push(f.Locals[0]);f.Pc=993;continue;}
case 993:{f.Push(f.Locals[7]);f.Pc=995;continue;}
case 995:{f.Push(f.Locals[1]);f.Pc=996;continue;}
case 996:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",999);}
case 999:{f.Push(f.Locals[1]);f.Pc=1000;continue;}
case 1000:{f.Push(f.Locals[2]);f.Pc=1001;continue;}
case 1001:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1004);}
case 1004:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1009);}
case 1009:{f.Pc=2675;continue;}
case 1012:{f.Push(f.Locals[3]);f.Pc=1013;continue;}
case 1013:{f.Push(JValue.R(rt.String("Daybound")));f.Pc=1016;continue;}
case 1016:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1019);}
case 1019:{f.Pc=f.Pop().Int==0?1047:1022;continue;}
case 1022:{f.Push(JValue.R(rt.String("Mode$ CantTransform | ValidCard$ Creature.Self | ExceptCause$ SpellAbility.Daybound | Secondary$ True | Description$ This permanent can't be transformed except by its daybound ability.")));f.Pc=1025;continue;}
case 1025:{f.Locals[7]=f.Pop();f.Pc=1027;continue;}
case 1027:{f.Push(f.Locals[0]);f.Pc=1028;continue;}
case 1028:{f.Push(f.Locals[7]);f.Pc=1030;continue;}
case 1030:{f.Push(f.Locals[1]);f.Pc=1031;continue;}
case 1031:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1034);}
case 1034:{f.Push(f.Locals[1]);f.Pc=1035;continue;}
case 1035:{f.Push(f.Locals[2]);f.Pc=1036;continue;}
case 1036:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1039);}
case 1039:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1044);}
case 1044:{f.Pc=2675;continue;}
case 1047:{f.Push(f.Locals[3]);f.Pc=1048;continue;}
case 1048:{f.Push(JValue.R(rt.String("Decayed")));f.Pc=1051;continue;}
case 1051:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1054);}
case 1054:{f.Pc=f.Pop().Int==0?1086:1057;continue;}
case 1057:{f.Push(JValue.R(rt.String("Mode$ CantBlock | ValidCard$ Creature.Self | Secondary$ True | Description$ CARDNAME can't block.")));f.Pc=1060;continue;}
case 1060:{f.Locals[7]=f.Pop();f.Pc=1062;continue;}
case 1062:{f.Push(f.Locals[7]);f.Pc=1064;continue;}
case 1064:{f.Push(f.Locals[1]);f.Pc=1065;continue;}
case 1065:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1068);}
case 1068:{f.Push(f.Locals[1]);f.Pc=1069;continue;}
case 1069:{f.Push(f.Locals[2]);f.Pc=1070;continue;}
case 1070:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1073);}
case 1073:{f.Locals[8]=f.Pop();f.Pc=1075;continue;}
case 1075:{f.Push(f.Locals[0]);f.Pc=1076;continue;}
case 1076:{f.Push(f.Locals[8]);f.Pc=1078;continue;}
case 1078:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1083);}
case 1083:{f.Pc=2675;continue;}
case 1086:{f.Push(f.Locals[3]);f.Pc=1087;continue;}
case 1087:{f.Push(JValue.R(rt.String("Defender")));f.Pc=1090;continue;}
case 1090:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1093);}
case 1093:{f.Pc=f.Pop().Int==0?1121:1096;continue;}
case 1096:{f.Push(JValue.R(rt.String("Mode$ CantAttack | ValidCard$ Card.Self | Secondary$ True")));f.Pc=1099;continue;}
case 1099:{f.Locals[7]=f.Pop();f.Pc=1101;continue;}
case 1101:{f.Push(f.Locals[0]);f.Pc=1102;continue;}
case 1102:{f.Push(f.Locals[7]);f.Pc=1104;continue;}
case 1104:{f.Push(f.Locals[1]);f.Pc=1105;continue;}
case 1105:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1108);}
case 1108:{f.Push(f.Locals[1]);f.Pc=1109;continue;}
case 1109:{f.Push(f.Locals[2]);f.Pc=1110;continue;}
case 1110:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1113);}
case 1113:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1118);}
case 1118:{f.Pc=2675;continue;}
case 1121:{f.Push(f.Locals[3]);f.Pc=1122;continue;}
case 1122:{f.Push(JValue.R(rt.String("Devoid")));f.Pc=1125;continue;}
case 1125:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1128);}
case 1128:{f.Pc=f.Pop().Int==0?1164:1131;continue;}
case 1131:{f.Push(f.Locals[0]);f.Pc=1132;continue;}
case 1132:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1137);}
case 1137:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:1137:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1142);}
case 1142:{f.Locals[7]=f.Pop();f.Pc=1144;continue;}
case 1144:{f.Push(f.Locals[0]);f.Pc=1145;continue;}
case 1145:{f.Push(f.Locals[7]);f.Pc=1147;continue;}
case 1147:{f.Push(f.Locals[1]);f.Pc=1148;continue;}
case 1148:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1151);}
case 1151:{f.Push(f.Locals[1]);f.Pc=1152;continue;}
case 1152:{f.Push(f.Locals[2]);f.Pc=1153;continue;}
case 1153:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1156);}
case 1156:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1161);}
case 1161:{f.Pc=2675;continue;}
case 1164:{f.Push(f.Locals[3]);f.Pc=1165;continue;}
case 1165:{f.Push(JValue.R(rt.String("Escalate")));f.Pc=1168;continue;}
case 1168:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1171);}
case 1171:{f.Pc=f.Pop().Int==0?1293:1174;continue;}
case 1174:{f.Push(f.Locals[3]);f.Pc=1175;continue;}
case 1175:{f.Push(JValue.R(rt.String(":")));f.Pc=1178;continue;}
case 1178:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1181);}
case 1181:{f.Locals[7]=f.Pop();f.Pc=1183;continue;}
case 1183:{f.Push(f.Locals[7]);f.Pc=1185;continue;}
case 1185:{f.Push(JValue.I(1));f.Pc=1186;continue;}
case 1186:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1187;continue;}
case 1187:{f.Locals[8]=f.Pop();f.Pc=1189;continue;}
case 1189:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=1192;continue;}
case 1192:{f.StackOp("dup");f.Pc=1193;continue;}
case 1193:{f.Push(f.Locals[8]);f.Pc=1195;continue;}
case 1195:{f.Push(JValue.I(0));f.Pc=1196;continue;}
case 1196:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",1199);}
case 1199:{f.Locals[9]=f.Pop();f.Pc=1201;continue;}
case 1201:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1204;continue;}
case 1204:{f.StackOp("dup");f.Pc=1205;continue;}
case 1205:{f.Push(JValue.R(rt.String("Escalate")));f.Pc=1208;continue;}
case 1208:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",1211);}
case 1211:{f.Locals[10]=f.Pop();f.Pc=1213;continue;}
case 1213:{f.Push(f.Locals[9]);f.Pc=1215;continue;}
case 1215:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",1218);}
case 1218:{f.Pc=f.Pop().Int!=0?1233:1221;continue;}
case 1221:{f.Push(f.Locals[10]);f.Pc=1223;continue;}
case 1223:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=1226;continue;}
case 1226:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1229);}
case 1229:{f.StackOp("pop");f.Pc=1230;continue;}
case 1230:{f.Pc=1242;continue;}
case 1233:{f.Push(f.Locals[10]);f.Pc=1235;continue;}
case 1235:{f.Push(JValue.R(rt.String(" ")));f.Pc=1238;continue;}
case 1238:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1241);}
case 1241:{f.StackOp("pop");f.Pc=1242;continue;}
case 1242:{f.Push(f.Locals[10]);f.Pc=1244;continue;}
case 1244:{f.Push(f.Locals[9]);f.Pc=1246;continue;}
case 1246:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",1249);}
case 1249:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1252);}
case 1252:{f.StackOp("pop");f.Pc=1253;continue;}
case 1253:{f.Push(f.Locals[8]);f.Pc=1255;continue;}
case 1255:{f.Push(f.Locals[10]);f.Pc=1257;continue;}
case 1257:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1260);}
case 1260:{f.Push(f.Locals[0]);f.Pc=1261;continue;}
case 1261:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1266);}
case 1266:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:1266:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1271);}
case 1271:{f.Locals[11]=f.Pop();f.Pc=1273;continue;}
case 1273:{f.Push(f.Locals[0]);f.Pc=1274;continue;}
case 1274:{f.Push(f.Locals[11]);f.Pc=1276;continue;}
case 1276:{f.Push(f.Locals[1]);f.Pc=1277;continue;}
case 1277:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1280);}
case 1280:{f.Push(f.Locals[1]);f.Pc=1281;continue;}
case 1281:{f.Push(f.Locals[2]);f.Pc=1282;continue;}
case 1282:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1285);}
case 1285:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1290);}
case 1290:{f.Pc=2675;continue;}
case 1293:{f.Push(f.Locals[3]);f.Pc=1294;continue;}
case 1294:{f.Push(JValue.R(rt.String("Enlist")));f.Pc=1297;continue;}
case 1297:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1300);}
case 1300:{f.Pc=f.Pop().Int==0?1351:1303;continue;}
case 1303:{f.Push(f.Locals[0]);f.Pc=1304;continue;}
case 1304:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1309);}
case 1309:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:1309:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1314);}
case 1314:{f.Locals[7]=f.Pop();f.Pc=1316;continue;}
case 1316:{f.Push(f.Locals[7]);f.Pc=1318;continue;}
case 1318:{f.Push(f.Locals[1]);f.Pc=1319;continue;}
case 1319:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1322);}
case 1322:{f.Push(f.Locals[1]);f.Pc=1323;continue;}
case 1323:{f.Push(f.Locals[2]);f.Pc=1324;continue;}
case 1324:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1327);}
case 1327:{f.Locals[8]=f.Pop();f.Pc=1329;continue;}
case 1329:{f.Push(f.Locals[8]);f.Pc=1331;continue;}
case 1331:{f.Push(JValue.R(rt.String("TrigEnlist")));f.Pc=1334;continue;}
case 1334:{f.Push(JValue.R(rt.String("DB$ Pump | NumAtt$ TriggerRemembered$CardPower | SpellDescription$ When you do, add its power to this creature's until end of turn.")));f.Pc=1337;continue;}
case 1337:{return rt.Call(f,"forge/game/staticability/StaticAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1340);}
case 1340:{f.Push(f.Locals[0]);f.Pc=1341;continue;}
case 1341:{f.Push(f.Locals[8]);f.Pc=1343;continue;}
case 1343:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1348);}
case 1348:{f.Pc=2675;continue;}
case 1351:{f.Push(f.Locals[3]);f.Pc=1352;continue;}
case 1352:{f.Push(JValue.R(rt.String("Fear")));f.Pc=1355;continue;}
case 1355:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1358);}
case 1358:{f.Pc=f.Pop().Int==0?1394:1361;continue;}
case 1361:{f.Push(f.Locals[0]);f.Pc=1362;continue;}
case 1362:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1367);}
case 1367:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:1367:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1372);}
case 1372:{f.Locals[7]=f.Pop();f.Pc=1374;continue;}
case 1374:{f.Push(f.Locals[0]);f.Pc=1375;continue;}
case 1375:{f.Push(f.Locals[7]);f.Pc=1377;continue;}
case 1377:{f.Push(f.Locals[1]);f.Pc=1378;continue;}
case 1378:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1381);}
case 1381:{f.Push(f.Locals[1]);f.Pc=1382;continue;}
case 1382:{f.Push(f.Locals[2]);f.Pc=1383;continue;}
case 1383:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1386);}
case 1386:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1391);}
case 1391:{f.Pc=2675;continue;}
case 1394:{f.Push(f.Locals[3]);f.Pc=1395;continue;}
case 1395:{f.Push(JValue.R(rt.String("Flying")));f.Pc=1398;continue;}
case 1398:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1401);}
case 1401:{f.Pc=f.Pop().Int==0?1437:1404;continue;}
case 1404:{f.Push(f.Locals[0]);f.Pc=1405;continue;}
case 1405:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1410);}
case 1410:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:1410:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1415);}
case 1415:{f.Locals[7]=f.Pop();f.Pc=1417;continue;}
case 1417:{f.Push(f.Locals[0]);f.Pc=1418;continue;}
case 1418:{f.Push(f.Locals[7]);f.Pc=1420;continue;}
case 1420:{f.Push(f.Locals[1]);f.Pc=1421;continue;}
case 1421:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1424);}
case 1424:{f.Push(f.Locals[1]);f.Pc=1425;continue;}
case 1425:{f.Push(f.Locals[2]);f.Pc=1426;continue;}
case 1426:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1429);}
case 1429:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1434);}
case 1434:{f.Pc=2675;continue;}
case 1437:{f.Push(f.Locals[3]);f.Pc=1438;continue;}
case 1438:{f.Push(JValue.R(rt.String("Harmonize")));f.Pc=1441;continue;}
case 1441:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1444);}
case 1444:{f.Pc=f.Pop().Int==0?1495:1447;continue;}
case 1447:{f.Push(f.Locals[0]);f.Pc=1448;continue;}
case 1448:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1453);}
case 1453:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:1453:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1458);}
case 1458:{f.Locals[7]=f.Pop();f.Pc=1460;continue;}
case 1460:{f.Push(f.Locals[7]);f.Pc=1462;continue;}
case 1462:{f.Push(f.Locals[1]);f.Pc=1463;continue;}
case 1463:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1466);}
case 1466:{f.Push(f.Locals[1]);f.Pc=1467;continue;}
case 1467:{f.Push(f.Locals[2]);f.Pc=1468;continue;}
case 1468:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1471);}
case 1471:{f.Locals[8]=f.Pop();f.Pc=1473;continue;}
case 1473:{f.Push(f.Locals[8]);f.Pc=1475;continue;}
case 1475:{f.Push(JValue.R(rt.String("AffectedX")));f.Pc=1478;continue;}
case 1478:{f.Push(JValue.R(rt.String("Count$OptionalKeywordAmount")));f.Pc=1481;continue;}
case 1481:{return rt.Call(f,"forge/game/staticability/StaticAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1484);}
case 1484:{f.Push(f.Locals[0]);f.Pc=1485;continue;}
case 1485:{f.Push(f.Locals[8]);f.Pc=1487;continue;}
case 1487:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1492);}
case 1492:{f.Pc=2675;continue;}
case 1495:{f.Push(f.Locals[3]);f.Pc=1496;continue;}
case 1496:{f.Push(JValue.R(rt.String("Hexproof")));f.Pc=1499;continue;}
case 1499:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1502);}
case 1502:{f.Pc=f.Pop().Int==0?1629:1505;continue;}
case 1505:{f.Push(f.Locals[0]);f.Pc=1506;continue;}
case 1506:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/Hexproof")?1:0));f.Pc=1509;continue;}
case 1509:{f.Pc=f.Pop().Int==0?1629:1512;continue;}
case 1512:{f.Push(f.Locals[0]);f.Pc=1513;continue;}
case 1513:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/Hexproof"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1516;continue;}
case 1516:{f.Locals[5]=f.Pop();f.Pc=1518;continue;}
case 1518:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1521;continue;}
case 1521:{f.StackOp("dup");f.Pc=1522;continue;}
case 1522:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",1525);}
case 1525:{f.Locals[7]=f.Pop();f.Pc=1527;continue;}
case 1527:{f.Push(f.Locals[5]);f.Pc=1529;continue;}
case 1529:{return rt.Call(f,"forge/game/keyword/Hexproof","getValidType","()Ljava/lang/String;","invokevirtual",1532);}
case 1532:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1535);}
case 1535:{f.Pc=f.Pop().Int!=0?1585:1538;continue;}
case 1538:{f.Push(f.Locals[5]);f.Pc=1540;continue;}
case 1540:{return rt.Call(f,"forge/game/keyword/Hexproof","getTypeDescription","()Ljava/lang/String;","invokevirtual",1543);}
case 1543:{f.Push(JValue.R(rt.String("abilities")));f.Pc=1546;continue;}
case 1546:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",1549);}
case 1549:{f.Pc=f.Pop().Int==0?1558:1552;continue;}
case 1552:{f.Push(JValue.R(rt.String("ValidSA$ ")));f.Pc=1555;continue;}
case 1555:{f.Pc=1561;continue;}
case 1558:{f.Push(JValue.R(rt.String("ValidSource$ ")));f.Pc=1561;continue;}
case 1561:{f.Locals[8]=f.Pop();f.Pc=1563;continue;}
case 1563:{f.Push(f.Locals[7]);f.Pc=1565;continue;}
case 1565:{f.Push(JValue.R(rt.String("| ")));f.Pc=1568;continue;}
case 1568:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1571);}
case 1571:{f.Push(f.Locals[8]);f.Pc=1573;continue;}
case 1573:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1576);}
case 1576:{f.Push(f.Locals[5]);f.Pc=1578;continue;}
case 1578:{return rt.Call(f,"forge/game/keyword/Hexproof","getValidType","()Ljava/lang/String;","invokevirtual",1581);}
case 1581:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1584);}
case 1584:{f.StackOp("pop");f.Pc=1585;continue;}
case 1585:{f.Push(f.Locals[7]);f.Pc=1587;continue;}
case 1587:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1590);}
case 1590:{f.Push(f.Locals[0]);f.Pc=1591;continue;}
case 1591:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getTitle","()Ljava/lang/String;","invokeinterface",1596);}
case 1596:{f.Push(f.Locals[0]);f.Pc=1597;continue;}
case 1597:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1602);}
case 1602:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:1602:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1607);}
case 1607:{f.Locals[8]=f.Pop();f.Pc=1609;continue;}
case 1609:{f.Push(f.Locals[0]);f.Pc=1610;continue;}
case 1610:{f.Push(f.Locals[8]);f.Pc=1612;continue;}
case 1612:{f.Push(f.Locals[1]);f.Pc=1613;continue;}
case 1613:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1616);}
case 1616:{f.Push(f.Locals[1]);f.Pc=1617;continue;}
case 1617:{f.Push(f.Locals[2]);f.Pc=1618;continue;}
case 1618:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1621);}
case 1621:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1626);}
case 1626:{f.Pc=2675;continue;}
case 1629:{f.Push(f.Locals[3]);f.Pc=1630;continue;}
case 1630:{f.Push(JValue.R(rt.String("Horsemanship")));f.Pc=1633;continue;}
case 1633:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1636);}
case 1636:{f.Pc=f.Pop().Int==0?1672:1639;continue;}
case 1639:{f.Push(f.Locals[0]);f.Pc=1640;continue;}
case 1640:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1645);}
case 1645:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:1645:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1650);}
case 1650:{f.Locals[7]=f.Pop();f.Pc=1652;continue;}
case 1652:{f.Push(f.Locals[0]);f.Pc=1653;continue;}
case 1653:{f.Push(f.Locals[7]);f.Pc=1655;continue;}
case 1655:{f.Push(f.Locals[1]);f.Pc=1656;continue;}
case 1656:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1659);}
case 1659:{f.Push(f.Locals[1]);f.Pc=1660;continue;}
case 1660:{f.Push(f.Locals[2]);f.Pc=1661;continue;}
case 1661:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1664);}
case 1664:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1669);}
case 1669:{f.Pc=2675;continue;}
case 1672:{f.Push(f.Locals[3]);f.Pc=1673;continue;}
case 1673:{f.Push(JValue.R(rt.String("Impending")));f.Pc=1676;continue;}
case 1676:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1679);}
case 1679:{f.Pc=f.Pop().Int==0?1707:1682;continue;}
case 1682:{f.Push(JValue.R(rt.String("Mode$ Continuous | Affected$ Card.Self+impended+counters_GE1_TIME | RemoveType$ Creature | Secondary$ True")));f.Pc=1685;continue;}
case 1685:{f.Locals[7]=f.Pop();f.Pc=1687;continue;}
case 1687:{f.Push(f.Locals[0]);f.Pc=1688;continue;}
case 1688:{f.Push(f.Locals[7]);f.Pc=1690;continue;}
case 1690:{f.Push(f.Locals[1]);f.Pc=1691;continue;}
case 1691:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1694);}
case 1694:{f.Push(f.Locals[1]);f.Pc=1695;continue;}
case 1695:{f.Push(f.Locals[2]);f.Pc=1696;continue;}
case 1696:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1699);}
case 1699:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1704);}
case 1704:{f.Pc=2675;continue;}
case 1707:{f.Push(f.Locals[3]);f.Pc=1708;continue;}
case 1708:{f.Push(JValue.R(rt.String("Intimidate")));f.Pc=1711;continue;}
case 1711:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1714);}
case 1714:{f.Pc=f.Pop().Int==0?1750:1717;continue;}
case 1717:{f.Push(f.Locals[0]);f.Pc=1718;continue;}
case 1718:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1723);}
case 1723:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:1723:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1728);}
case 1728:{f.Locals[7]=f.Pop();f.Pc=1730;continue;}
case 1730:{f.Push(f.Locals[0]);f.Pc=1731;continue;}
case 1731:{f.Push(f.Locals[7]);f.Pc=1733;continue;}
case 1733:{f.Push(f.Locals[1]);f.Pc=1734;continue;}
case 1734:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1737);}
case 1737:{f.Push(f.Locals[1]);f.Pc=1738;continue;}
case 1738:{f.Push(f.Locals[2]);f.Pc=1739;continue;}
case 1739:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1742);}
case 1742:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1747);}
case 1747:{f.Pc=2675;continue;}
case 1750:{f.Push(f.Locals[0]);f.Pc=1751;continue;}
case 1751:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/Landwalk")?1:0));f.Pc=1754;continue;}
case 1754:{f.Pc=f.Pop().Int==0?1806:1757;continue;}
case 1757:{f.Push(f.Locals[0]);f.Pc=1758;continue;}
case 1758:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/Landwalk"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1761;continue;}
case 1761:{f.Locals[6]=f.Pop();f.Pc=1763;continue;}
case 1763:{f.Push(f.Locals[6]);f.Pc=1765;continue;}
case 1765:{return rt.Call(f,"forge/game/keyword/Landwalk","getValidType","()Ljava/lang/String;","invokevirtual",1768);}
case 1768:{f.Push(f.Locals[6]);f.Pc=1770;continue;}
case 1770:{return rt.Call(f,"forge/game/keyword/Landwalk","getTitle","()Ljava/lang/String;","invokevirtual",1773);}
case 1773:{f.Push(f.Locals[0]);f.Pc=1774;continue;}
case 1774:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1779);}
case 1779:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:1779:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1784);}
case 1784:{f.Locals[7]=f.Pop();f.Pc=1786;continue;}
case 1786:{f.Push(f.Locals[0]);f.Pc=1787;continue;}
case 1787:{f.Push(f.Locals[7]);f.Pc=1789;continue;}
case 1789:{f.Push(f.Locals[1]);f.Pc=1790;continue;}
case 1790:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1793);}
case 1793:{f.Push(f.Locals[1]);f.Pc=1794;continue;}
case 1794:{f.Push(f.Locals[2]);f.Pc=1795;continue;}
case 1795:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1798);}
case 1798:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1803);}
case 1803:{f.Pc=2675;continue;}
case 1806:{f.Push(f.Locals[3]);f.Pc=1807;continue;}
case 1807:{f.Push(JValue.R(rt.String("Living metal")));f.Pc=1810;continue;}
case 1810:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1813);}
case 1813:{f.Pc=f.Pop().Int==0?1841:1816;continue;}
case 1816:{f.Push(JValue.R(rt.String("Mode$ Continuous | Affected$ Card.Self | AddType$ Creature | Condition$ PlayerTurn | Secondary$ True")));f.Pc=1819;continue;}
case 1819:{f.Locals[7]=f.Pop();f.Pc=1821;continue;}
case 1821:{f.Push(f.Locals[0]);f.Pc=1822;continue;}
case 1822:{f.Push(f.Locals[7]);f.Pc=1824;continue;}
case 1824:{f.Push(f.Locals[1]);f.Pc=1825;continue;}
case 1825:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1828);}
case 1828:{f.Push(f.Locals[1]);f.Pc=1829;continue;}
case 1829:{f.Push(f.Locals[2]);f.Pc=1830;continue;}
case 1830:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1833);}
case 1833:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1838);}
case 1838:{f.Pc=2675;continue;}
case 1841:{f.Push(f.Locals[3]);f.Pc=1842;continue;}
case 1842:{f.Push(JValue.R(rt.String("Nightbound")));f.Pc=1845;continue;}
case 1845:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1848);}
case 1848:{f.Pc=f.Pop().Int==0?1876:1851;continue;}
case 1851:{f.Push(JValue.R(rt.String("Mode$ CantTransform | ValidCard$ Creature.Self | ExceptCause$ SpellAbility.Nightbound | Secondary$ True | Description$ This permanent can't be transformed except by its nightbound ability.")));f.Pc=1854;continue;}
case 1854:{f.Locals[7]=f.Pop();f.Pc=1856;continue;}
case 1856:{f.Push(f.Locals[0]);f.Pc=1857;continue;}
case 1857:{f.Push(f.Locals[7]);f.Pc=1859;continue;}
case 1859:{f.Push(f.Locals[1]);f.Pc=1860;continue;}
case 1860:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1863);}
case 1863:{f.Push(f.Locals[1]);f.Pc=1864;continue;}
case 1864:{f.Push(f.Locals[2]);f.Pc=1865;continue;}
case 1865:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1868);}
case 1868:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1873);}
case 1873:{f.Pc=2675;continue;}
case 1876:{f.Push(f.Locals[3]);f.Pc=1877;continue;}
case 1877:{f.Push(JValue.R(rt.String("Prismatic")));f.Pc=1880;continue;}
case 1880:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1883);}
case 1883:{f.Pc=f.Pop().Int==0?1911:1886;continue;}
case 1886:{f.Push(JValue.R(rt.String("Mode$ ManaConvert | EffectZone$ Stack | ValidPlayer$ You | ValidCard$ Card.Self | ValidSA$ Spell | ManaConversion$ AnyType->AnyColor")));f.Pc=1889;continue;}
case 1889:{f.Locals[7]=f.Pop();f.Pc=1891;continue;}
case 1891:{f.Push(f.Locals[0]);f.Pc=1892;continue;}
case 1892:{f.Push(f.Locals[7]);f.Pc=1894;continue;}
case 1894:{f.Push(f.Locals[1]);f.Pc=1895;continue;}
case 1895:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1898);}
case 1898:{f.Push(f.Locals[1]);f.Pc=1899;continue;}
case 1899:{f.Push(f.Locals[2]);f.Pc=1900;continue;}
case 1900:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1903);}
case 1903:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1908);}
case 1908:{f.Pc=2675;continue;}
case 1911:{f.Push(f.Locals[3]);f.Pc=1912;continue;}
case 1912:{f.Push(JValue.R(rt.String("Protection")));f.Pc=1915;continue;}
case 1915:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1918);}
case 1918:{f.Pc=f.Pop().Int==0?2155:1921;continue;}
case 1921:{f.Push(f.Locals[3]);f.Pc=1922;continue;}
case 1922:{f.Push(JValue.I(0));f.Pc=1923;continue;}
case 1923:{return rt.Call(f,"forge/game/keyword/Protection","getProtectionValid","(Ljava/lang/String;Z)Ljava/lang/String;","invokestatic",1926);}
case 1926:{f.Locals[7]=f.Pop();f.Pc=1928;continue;}
case 1928:{f.Push(JValue.R(rt.String("Mode$ CantBlockBy | ValidAttacker$ Creature.Self | Secondary$ True ")));f.Pc=1931;continue;}
case 1931:{f.Locals[8]=f.Pop();f.Pc=1933;continue;}
case 1933:{f.Push(f.Locals[0]);f.Pc=1934;continue;}
case 1934:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",1939);}
case 1939:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:1939:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1944);}
case 1944:{f.Locals[9]=f.Pop();f.Pc=1946;continue;}
case 1946:{f.Push(f.Locals[7]);f.Pc=1948;continue;}
case 1948:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1951);}
case 1951:{f.Pc=f.Pop().Int!=0?1965:1954;continue;}
case 1954:{f.Push(f.Locals[8]);f.Pc=1956;continue;}
case 1956:{f.Push(f.Locals[7]);f.Pc=1958;continue;}
case 1958:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:1958:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1963);}
case 1963:{f.Locals[8]=f.Pop();f.Pc=1965;continue;}
case 1965:{f.Push(f.Locals[8]);f.Pc=1967;continue;}
case 1967:{f.Push(f.Locals[9]);f.Pc=1969;continue;}
case 1969:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:1969:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1974);}
case 1974:{f.Locals[8]=f.Pop();f.Pc=1976;continue;}
case 1976:{f.Push(f.Locals[0]);f.Pc=1977;continue;}
case 1977:{f.Push(f.Locals[8]);f.Pc=1979;continue;}
case 1979:{f.Push(f.Locals[1]);f.Pc=1980;continue;}
case 1980:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",1983);}
case 1983:{f.Push(f.Locals[1]);f.Pc=1984;continue;}
case 1984:{f.Push(f.Locals[2]);f.Pc=1985;continue;}
case 1985:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1988);}
case 1988:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",1993);}
case 1993:{f.Push(JValue.R(rt.String("Mode$ CantTarget | ValidTarget$ Card.Self | Secondary$ True ")));f.Pc=1996;continue;}
case 1996:{f.Locals[8]=f.Pop();f.Pc=1998;continue;}
case 1998:{f.Push(f.Locals[7]);f.Pc=2000;continue;}
case 2000:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",2003);}
case 2003:{f.Pc=f.Pop().Int!=0?2017:2006;continue;}
case 2006:{f.Push(f.Locals[8]);f.Pc=2008;continue;}
case 2008:{f.Push(f.Locals[7]);f.Pc=2010;continue;}
case 2010:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2010:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2015);}
case 2015:{f.Locals[8]=f.Pop();f.Pc=2017;continue;}
case 2017:{f.Push(f.Locals[8]);f.Pc=2019;continue;}
case 2019:{f.Push(f.Locals[9]);f.Pc=2021;continue;}
case 2021:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2021:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2026);}
case 2026:{f.Locals[8]=f.Pop();f.Pc=2028;continue;}
case 2028:{f.Push(f.Locals[0]);f.Pc=2029;continue;}
case 2029:{f.Push(f.Locals[8]);f.Pc=2031;continue;}
case 2031:{f.Push(f.Locals[1]);f.Pc=2032;continue;}
case 2032:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",2035);}
case 2035:{f.Push(f.Locals[1]);f.Pc=2036;continue;}
case 2036:{f.Push(f.Locals[2]);f.Pc=2037;continue;}
case 2037:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",2040);}
case 2040:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",2045);}
case 2045:{f.Push(JValue.R(rt.String("Mode$ CantAttach | Target$ Card.Self | Secondary$ True ")));f.Pc=2048;continue;}
case 2048:{f.Locals[8]=f.Pop();f.Pc=2050;continue;}
case 2050:{f.Push(f.Locals[7]);f.Pc=2052;continue;}
case 2052:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",2055);}
case 2055:{f.Pc=f.Pop().Int!=0?2069:2058;continue;}
case 2058:{f.Push(f.Locals[8]);f.Pc=2060;continue;}
case 2060:{f.Push(f.Locals[7]);f.Pc=2062;continue;}
case 2062:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2062:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2067);}
case 2067:{f.Locals[8]=f.Pop();f.Pc=2069;continue;}
case 2069:{f.Push(f.Locals[3]);f.Pc=2070;continue;}
case 2070:{f.Push(JValue.R(rt.String("Protection:")));f.Pc=2073;continue;}
case 2073:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2076);}
case 2076:{f.Pc=f.Pop().Int==0?2124:2079;continue;}
case 2079:{f.Push(f.Locals[3]);f.Pc=2080;continue;}
case 2080:{f.Push(JValue.R(rt.String(":")));f.Pc=2083;continue;}
case 2083:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2086);}
case 2086:{f.Locals[10]=f.Pop();f.Pc=2088;continue;}
case 2088:{f.Push(f.Locals[10]);f.Pc=2090;continue;}
case 2090:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2091;continue;}
case 2091:{f.Push(JValue.I(3));f.Pc=2092;continue;}
case 2092:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2108:2095;continue;}
case 2095:{f.Push(f.Locals[8]);f.Pc=2097;continue;}
case 2097:{f.Push(f.Locals[10]);f.Pc=2099;continue;}
case 2099:{f.Push(JValue.I(3));f.Pc=2100;continue;}
case 2100:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2101;continue;}
case 2101:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2101:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2106);}
case 2106:{f.Locals[8]=f.Pop();f.Pc=2108;continue;}
case 2108:{f.Push(f.Locals[10]);f.Pc=2110;continue;}
case 2110:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2111;continue;}
case 2111:{f.Push(JValue.I(4));f.Pc=2112;continue;}
case 2112:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2124:2115;continue;}
case 2115:{f.Push(f.Locals[8]);f.Pc=2117;continue;}
case 2117:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2117:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2122);}
case 2122:{f.Locals[8]=f.Pop();f.Pc=2124;continue;}
case 2124:{f.Push(f.Locals[8]);f.Pc=2126;continue;}
case 2126:{f.Push(f.Locals[9]);f.Pc=2128;continue;}
case 2128:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2128:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2133);}
case 2133:{f.Locals[8]=f.Pop();f.Pc=2135;continue;}
case 2135:{f.Push(f.Locals[0]);f.Pc=2136;continue;}
case 2136:{f.Push(f.Locals[8]);f.Pc=2138;continue;}
case 2138:{f.Push(f.Locals[1]);f.Pc=2139;continue;}
case 2139:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",2142);}
case 2142:{f.Push(f.Locals[1]);f.Pc=2143;continue;}
case 2143:{f.Push(f.Locals[2]);f.Pc=2144;continue;}
case 2144:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",2147);}
case 2147:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",2152);}
case 2152:{f.Pc=2675;continue;}
case 2155:{f.Push(f.Locals[3]);f.Pc=2156;continue;}
case 2156:{f.Push(JValue.R(rt.String("Read ahead")));f.Pc=2159;continue;}
case 2159:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2162);}
case 2162:{f.Pc=f.Pop().Int==0?2190:2165;continue;}
case 2165:{f.Push(JValue.R(rt.String("Mode$ DisableTriggers | ValidCard$ Card.Self+ThisTurnEntered | ValidTrigger$ Triggered.ChapterNotLore | Secondary$ True | Description$ Chapter abilities of this Saga can't trigger the turn it entered the battlefield unless it has exactly the number of lore counters on it specified in the chapter symbol of that ability.")));f.Pc=2168;continue;}
case 2168:{f.Locals[7]=f.Pop();f.Pc=2170;continue;}
case 2170:{f.Push(f.Locals[0]);f.Pc=2171;continue;}
case 2171:{f.Push(f.Locals[7]);f.Pc=2173;continue;}
case 2173:{f.Push(f.Locals[1]);f.Pc=2174;continue;}
case 2174:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",2177);}
case 2177:{f.Push(f.Locals[1]);f.Pc=2178;continue;}
case 2178:{f.Push(f.Locals[2]);f.Pc=2179;continue;}
case 2179:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",2182);}
case 2182:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",2187);}
case 2187:{f.Pc=2675;continue;}
case 2190:{f.Push(f.Locals[3]);f.Pc=2191;continue;}
case 2191:{f.Push(JValue.R(rt.String("Shadow")));f.Pc=2194;continue;}
case 2194:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2197);}
case 2197:{f.Pc=f.Pop().Int==0?2268:2200;continue;}
case 2200:{f.Push(f.Locals[0]);f.Pc=2201;continue;}
case 2201:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2206);}
case 2206:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2206:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2211);}
case 2211:{f.Locals[7]=f.Pop();f.Pc=2213;continue;}
case 2213:{f.Push(f.Locals[7]);f.Pc=2215;continue;}
case 2215:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2215:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2220);}
case 2220:{f.Locals[8]=f.Pop();f.Pc=2222;continue;}
case 2222:{f.Push(f.Locals[7]);f.Pc=2224;continue;}
case 2224:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2224:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2229);}
case 2229:{f.Locals[9]=f.Pop();f.Pc=2231;continue;}
case 2231:{f.Push(f.Locals[0]);f.Pc=2232;continue;}
case 2232:{f.Push(f.Locals[8]);f.Pc=2234;continue;}
case 2234:{f.Push(f.Locals[1]);f.Pc=2235;continue;}
case 2235:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",2238);}
case 2238:{f.Push(f.Locals[1]);f.Pc=2239;continue;}
case 2239:{f.Push(f.Locals[2]);f.Pc=2240;continue;}
case 2240:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",2243);}
case 2243:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",2248);}
case 2248:{f.Push(f.Locals[0]);f.Pc=2249;continue;}
case 2249:{f.Push(f.Locals[9]);f.Pc=2251;continue;}
case 2251:{f.Push(f.Locals[1]);f.Pc=2252;continue;}
case 2252:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",2255);}
case 2255:{f.Push(f.Locals[1]);f.Pc=2256;continue;}
case 2256:{f.Push(f.Locals[2]);f.Pc=2257;continue;}
case 2257:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",2260);}
case 2260:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",2265);}
case 2265:{f.Pc=2675;continue;}
case 2268:{f.Push(f.Locals[3]);f.Pc=2269;continue;}
case 2269:{f.Push(JValue.R(rt.String("Shroud")));f.Pc=2272;continue;}
case 2272:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2275);}
case 2275:{f.Pc=f.Pop().Int==0?2311:2278;continue;}
case 2278:{f.Push(f.Locals[0]);f.Pc=2279;continue;}
case 2279:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2284);}
case 2284:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2284:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2289);}
case 2289:{f.Locals[7]=f.Pop();f.Pc=2291;continue;}
case 2291:{f.Push(f.Locals[0]);f.Pc=2292;continue;}
case 2292:{f.Push(f.Locals[7]);f.Pc=2294;continue;}
case 2294:{f.Push(f.Locals[1]);f.Pc=2295;continue;}
case 2295:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",2298);}
case 2298:{f.Push(f.Locals[1]);f.Pc=2299;continue;}
case 2299:{f.Push(f.Locals[2]);f.Pc=2300;continue;}
case 2300:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",2303);}
case 2303:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",2308);}
case 2308:{f.Pc=2675;continue;}
case 2311:{f.Push(f.Locals[3]);f.Pc=2312;continue;}
case 2312:{f.Push(JValue.R(rt.String("Skulk")));f.Pc=2315;continue;}
case 2315:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2318);}
case 2318:{f.Pc=f.Pop().Int==0?2368:2321;continue;}
case 2321:{f.Push(f.Locals[0]);f.Pc=2322;continue;}
case 2322:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2327);}
case 2327:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2327:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2332);}
case 2332:{f.Locals[7]=f.Pop();f.Pc=2334;continue;}
case 2334:{f.Push(f.Locals[7]);f.Pc=2336;continue;}
case 2336:{f.Push(f.Locals[1]);f.Pc=2337;continue;}
case 2337:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",2340);}
case 2340:{f.Push(f.Locals[1]);f.Pc=2341;continue;}
case 2341:{f.Push(f.Locals[2]);f.Pc=2342;continue;}
case 2342:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",2345);}
case 2345:{f.Locals[8]=f.Pop();f.Pc=2347;continue;}
case 2347:{f.Push(f.Locals[8]);f.Pc=2349;continue;}
case 2349:{f.Push(JValue.R(rt.String("X")));f.Pc=2351;continue;}
case 2351:{f.Push(JValue.R(rt.String("Count$CardPower")));f.Pc=2354;continue;}
case 2354:{return rt.Call(f,"forge/game/staticability/StaticAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",2357);}
case 2357:{f.Push(f.Locals[0]);f.Pc=2358;continue;}
case 2358:{f.Push(f.Locals[8]);f.Pc=2360;continue;}
case 2360:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",2365);}
case 2365:{f.Pc=2675;continue;}
case 2368:{f.Push(f.Locals[3]);f.Pc=2369;continue;}
case 2369:{f.Push(JValue.R(rt.String("Spree")));f.Pc=2372;continue;}
case 2372:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2375);}
case 2375:{f.Pc=f.Pop().Int==0?2411:2378;continue;}
case 2378:{f.Push(f.Locals[0]);f.Pc=2379;continue;}
case 2379:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2384);}
case 2384:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2384:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2389);}
case 2389:{f.Locals[7]=f.Pop();f.Pc=2391;continue;}
case 2391:{f.Push(f.Locals[0]);f.Pc=2392;continue;}
case 2392:{f.Push(f.Locals[7]);f.Pc=2394;continue;}
case 2394:{f.Push(f.Locals[1]);f.Pc=2395;continue;}
case 2395:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",2398);}
case 2398:{f.Push(f.Locals[1]);f.Pc=2399;continue;}
case 2399:{f.Push(f.Locals[2]);f.Pc=2400;continue;}
case 2400:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",2403);}
case 2403:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",2408);}
case 2408:{f.Pc=2675;continue;}
case 2411:{f.Push(f.Locals[3]);f.Pc=2412;continue;}
case 2412:{f.Push(JValue.R(rt.String("Strive")));f.Pc=2415;continue;}
case 2415:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2418);}
case 2418:{f.Pc=f.Pop().Int==0?2471:2421;continue;}
case 2421:{f.Push(f.Locals[3]);f.Pc=2422;continue;}
case 2422:{f.Push(JValue.R(rt.String(":")));f.Pc=2425;continue;}
case 2425:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2428);}
case 2428:{f.Locals[7]=f.Pop();f.Pc=2430;continue;}
case 2430:{f.Push(f.Locals[7]);f.Pc=2432;continue;}
case 2432:{f.Push(JValue.I(1));f.Pc=2433;continue;}
case 2433:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2434;continue;}
case 2434:{f.Locals[8]=f.Pop();f.Pc=2436;continue;}
case 2436:{f.Push(f.Locals[8]);f.Pc=2438;continue;}
case 2438:{f.Push(f.Locals[0]);f.Pc=2439;continue;}
case 2439:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2444);}
case 2444:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2444:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2449);}
case 2449:{f.Locals[9]=f.Pop();f.Pc=2451;continue;}
case 2451:{f.Push(f.Locals[0]);f.Pc=2452;continue;}
case 2452:{f.Push(f.Locals[9]);f.Pc=2454;continue;}
case 2454:{f.Push(f.Locals[1]);f.Pc=2455;continue;}
case 2455:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",2458);}
case 2458:{f.Push(f.Locals[1]);f.Pc=2459;continue;}
case 2459:{f.Push(f.Locals[2]);f.Pc=2460;continue;}
case 2460:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",2463);}
case 2463:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",2468);}
case 2468:{f.Pc=2675;continue;}
case 2471:{f.Push(f.Locals[3]);f.Pc=2472;continue;}
case 2472:{f.Push(JValue.R(rt.String("Tiered")));f.Pc=2475;continue;}
case 2475:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2478);}
case 2478:{f.Pc=f.Pop().Int==0?2514:2481;continue;}
case 2481:{f.Push(f.Locals[0]);f.Pc=2482;continue;}
case 2482:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2487);}
case 2487:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2487:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2492);}
case 2492:{f.Locals[7]=f.Pop();f.Pc=2494;continue;}
case 2494:{f.Push(f.Locals[0]);f.Pc=2495;continue;}
case 2495:{f.Push(f.Locals[7]);f.Pc=2497;continue;}
case 2497:{f.Push(f.Locals[1]);f.Pc=2498;continue;}
case 2498:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",2501);}
case 2501:{f.Push(f.Locals[1]);f.Pc=2502;continue;}
case 2502:{f.Push(f.Locals[2]);f.Pc=2503;continue;}
case 2503:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",2506);}
case 2506:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",2511);}
case 2511:{f.Pc=2675;continue;}
case 2514:{f.Push(f.Locals[3]);f.Pc=2515;continue;}
case 2515:{f.Push(JValue.R(rt.String("Unleash")));f.Pc=2518;continue;}
case 2518:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2521);}
case 2521:{f.Pc=f.Pop().Int==0?2549:2524;continue;}
case 2524:{f.Push(JValue.R(rt.String("Mode$ CantBlock | ValidCard$ Creature.Self+counters_GE1_P1P1 | Secondary$ True | Description$ CARDNAME can't block.")));f.Pc=2527;continue;}
case 2527:{f.Locals[7]=f.Pop();f.Pc=2529;continue;}
case 2529:{f.Push(f.Locals[0]);f.Pc=2530;continue;}
case 2530:{f.Push(f.Locals[7]);f.Pc=2532;continue;}
case 2532:{f.Push(f.Locals[1]);f.Pc=2533;continue;}
case 2533:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",2536);}
case 2536:{f.Push(f.Locals[1]);f.Pc=2537;continue;}
case 2537:{f.Push(f.Locals[2]);f.Pc=2538;continue;}
case 2538:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",2541);}
case 2541:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",2546);}
case 2546:{f.Pc=2675;continue;}
case 2549:{f.Push(f.Locals[3]);f.Pc=2550;continue;}
case 2550:{f.Push(JValue.R(rt.String("Undaunted")));f.Pc=2553;continue;}
case 2553:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2556);}
case 2556:{f.Pc=f.Pop().Int==0?2592:2559;continue;}
case 2559:{f.Push(f.Locals[0]);f.Pc=2560;continue;}
case 2560:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2565);}
case 2565:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2565:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2570);}
case 2570:{f.Locals[7]=f.Pop();f.Pc=2572;continue;}
case 2572:{f.Push(f.Locals[0]);f.Pc=2573;continue;}
case 2573:{f.Push(f.Locals[7]);f.Pc=2575;continue;}
case 2575:{f.Push(f.Locals[1]);f.Pc=2576;continue;}
case 2576:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",2579);}
case 2579:{f.Push(f.Locals[1]);f.Pc=2580;continue;}
case 2580:{f.Push(f.Locals[2]);f.Pc=2581;continue;}
case 2581:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",2584);}
case 2584:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",2589);}
case 2589:{f.Pc=2675;continue;}
case 2592:{f.Push(f.Locals[3]);f.Pc=2593;continue;}
case 2593:{f.Push(JValue.R(rt.String("Vigilance")));f.Pc=2596;continue;}
case 2596:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2599);}
case 2599:{f.Pc=f.Pop().Int==0?2635:2602;continue;}
case 2602:{f.Push(f.Locals[0]);f.Pc=2603;continue;}
case 2603:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2608);}
case 2608:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2608:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2613);}
case 2613:{f.Locals[7]=f.Pop();f.Pc=2615;continue;}
case 2615:{f.Push(f.Locals[0]);f.Pc=2616;continue;}
case 2616:{f.Push(f.Locals[7]);f.Pc=2618;continue;}
case 2618:{f.Push(f.Locals[1]);f.Pc=2619;continue;}
case 2619:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",2622);}
case 2622:{f.Push(f.Locals[1]);f.Pc=2623;continue;}
case 2623:{f.Push(f.Locals[2]);f.Pc=2624;continue;}
case 2624:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",2627);}
case 2627:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",2632);}
case 2632:{f.Pc=2675;continue;}
case 2635:{f.Push(f.Locals[3]);f.Pc=2636;continue;}
case 2636:{f.Push(JValue.R(rt.String("MayFlashSac")));f.Pc=2639;continue;}
case 2639:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2642);}
case 2642:{f.Pc=f.Pop().Int==0?2675:2645;continue;}
case 2645:{f.Push(f.Locals[0]);f.Pc=2646;continue;}
case 2646:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",2651);}
case 2651:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil:5028:2651:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2656);}
case 2656:{f.Locals[7]=f.Pop();f.Pc=2658;continue;}
case 2658:{f.Push(f.Locals[0]);f.Pc=2659;continue;}
case 2659:{f.Push(f.Locals[7]);f.Pc=2661;continue;}
case 2661:{f.Push(f.Locals[1]);f.Pc=2662;continue;}
case 2662:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",2665);}
case 2665:{f.Push(f.Locals[1]);f.Pc=2666;continue;}
case 2666:{f.Push(f.Locals[2]);f.Pc=2667;continue;}
case 2667:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",2670);}
case 2670:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",2675);}
case 2675:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5029(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Event$ Moved | ValidCard$ Card.Self | Destination$ Battlefield | ReplacementResult$ Updated | BattleProtector$ True")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String(" | Description$ (As a Siege enters, choose an opponent to protect it. You and others can attack it. When it's defeated, exile it, then cast it transformed.)")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("DB$ ChoosePlayer | Defined$ You | Choices$ Opponent | Protect$ True | ChoiceTitle$ Choose an opponent to protect this battle")));f.Pc=27;continue;}
case 27:{f.Locals[2]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",37);}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",44);}
case 44:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",47);}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/Card","addReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",60);}
case 60:{f.Locals[4]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("Mode$ CounterRemovedOnce | ValidCard$ Card.Self | Secondary$ True | CounterType$ DEFENSE | Remaining$ 0 | TriggerZones$ Battlefield |")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String(" TriggerDescription$ When CARDNAME is defeated, exile it, then cast it transformed.")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self | Origin$ Battlefield | Destination$ Exile | RememberChanged$ True")));f.Pc=83;continue;}
case 83:{f.Locals[5]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("DB$ Play | Defined$ Remembered | WithoutManaCost$ True | Optional$ True | CastTransformed$ True")));f.Pc=88;continue;}
case 88:{f.Locals[6]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",95);}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(JValue.I(1));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",100);}
case 100:{f.Locals[7]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[5]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",108);}
case 108:{f.Locals[8]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[6]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",116);}
case 116:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=119;continue;}
case 119:{f.Locals[9]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[8]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[9]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",128);}
case 128:{f.Push(f.Locals[7]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[8]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",135);}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[7]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/card/Card","addTrigger","(Lforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;","invokevirtual",141);}
case 141:{f.StackOp("pop");f.Pc=142;continue;}
case 142:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5030(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Event$ Moved | ValidCard$ Card.Self | Origin$ Stack | ExcludeDestination$ Exile ")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("| ValidStackSa$ Spell.Adventure | Fizzle$ False | Secondary$ True | Description$ Adventure")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",28);}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self | Origin$ Stack | Destination$ Exile | StackDescription$ None")));f.Pc=32;continue;}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",38);}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("DB$ Effect | RememberObjects$ Self | StaticAbilities$ Play | ForgetOnMoved$ Exile | Duration$ Permanent | ConditionDefined$ Self | ConditionPresent$ Card.!copiedSpell+!token | Adventure$ True")));f.Pc=43;continue;}
case 43:{f.Locals[5]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[6]=f.Pop();f.Pc=56;continue;}
case 56:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=59;continue;}
case 59:{f.StackOp("dup");f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",63);}
case 63:{f.Locals[7]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[7]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("Mode$ Continuous | MayPlay$ True | EffectZone$ Command | Affected$ Card.IsRemembered+!Adventure")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",73);}
case 73:{f.StackOp("pop");f.Pc=74;continue;}
case 74:{f.Push(f.Locals[7]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String(" | AffectedZone$ Exile | Description$ You may cast EFFECTSOURCE.")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("Play")));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[7]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",93);}
case 93:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",96);}
case 96:{f.Push(f.Locals[4]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[6]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",103);}
case 103:{f.Push(f.Locals[2]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",108);}
case 108:{f.Push(JValue.I(1));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",112);}
case 112:{f.Locals[8]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[8]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[4]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",121);}
case 121:{f.Push(f.Locals[8]);f.Pc=123;continue;}
case 123:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5031(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Event$ Moved | ValidCard$ Card.Self | Origin$ Stack ")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("| ValidStackSa$ Spell.Omen | Fizzle$ False | Secondary$ True | Description$ Omen")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",28);}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self | Origin$ Stack | Destination$ Library | Shuffle$ True | StackDescription$ None")));f.Pc=32;continue;}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",48);}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",52);}
case 52:{f.Locals[5]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[5]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",61);}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5032(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Event$ Moved | ValidCard$ Card.Self | Origin$ Stack | ExcludeDestination$ Exile | ValidStackSa$ Spell.Vengeance | Secondary$ True | Description$ Vengeance")));f.Pc=3;continue;}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self | Origin$ Stack | Destination$ Exile | StackDescription$ None")));f.Pc=7;continue;}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",13);}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",24);}
case 24:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",27);}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5033(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getFaceDownState","()Lforge/game/card/CardState;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("FaceDownPower")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?36:20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("FaceDownPower")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",33);}
case 33:{return rt.Call(f,"forge/game/card/CardState","setBasePower","(I)V","invokevirtual",36);}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("FaceDownToughness")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int==0?62:46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("FaceDownToughness")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",55);}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",59);}
case 59:{return rt.Call(f,"forge/game/card/CardState","setBaseToughness","(I)V","invokevirtual",62);}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("FaceDownSetType")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?100:72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("FaceDownSetType")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",84);}
case 84:{f.Push(JValue.R(rt.String(" & ")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",90);}
case 90:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",93);}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/card/CardType","<init>","(Ljava/lang/Iterable;Z)V","invokespecial",97);}
case 97:{return rt.Call(f,"forge/game/card/CardState","setType","(Lforge/card/CardType;)V","invokevirtual",100);}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("FaceDownKeyword")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int==0?139:110;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",114);}
case 114:{f.Push(JValue.I(0));f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/card/CardState","setIntrinsicKeywords","(Ljava/lang/Iterable;Z)V","invokevirtual",118);}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{f.Push(JValue.R(rt.String("FaceDownKeyword")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",126);}
case 126:{f.Push(JValue.R(rt.String(" & ")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",132);}
case 132:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",135);}
case 135:{return rt.Call(f,"forge/game/card/CardState","addIntrinsicKeywords","(Ljava/lang/Iterable;)Z","invokevirtual",138);}
case 138:{f.StackOp("pop");f.Pc=139;continue;}
case 139:{f.Push(f.Locals[1]);f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.String("FaceDownPower")));f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",146);}
case 146:{f.Pc=f.Pop().Int!=0?179:149;continue;}
case 149:{f.Push(f.Locals[1]);f.Pc=150;continue;}
case 150:{f.Push(JValue.R(rt.String("FaceDownToughness")));f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",156);}
case 156:{f.Pc=f.Pop().Int!=0?179:159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("FaceDownSetType")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",166);}
case 166:{f.Pc=f.Pop().Int!=0?179:169;continue;}
case 169:{f.Push(f.Locals[1]);f.Pc=170;continue;}
case 170:{f.Push(JValue.R(rt.String("FaceDownKeyword")));f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",176);}
case 176:{f.Pc=f.Pop().Int==0?195:179;continue;}
case 179:{if(!rt.EnsureInitialized(f,"forge/game/card/CardFactoryUtil$7"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardFactoryUtil$7")));f.Pc=182;continue;}
case 182:{f.StackOp("dup");f.Pc=183;continue;}
case 183:{f.Push(f.Locals[0]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/card/CardFactoryUtil$7","<init>","(Lforge/game/card/Card;)V","invokespecial",187);}
case 187:{f.Locals[4]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[0]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[4]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/card/Card","addFaceupCommand","(Lforge/GameCommand;)V","invokevirtual",195);}
case 195:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5034(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",5);}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=7;continue;}
case 7:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5035(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
