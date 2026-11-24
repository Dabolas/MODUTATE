// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C49{
internal static JClass Build(){var c=new JClass("forge/card/CardType","java/lang/Object",new string[]{"java/lang/Comparable","forge/card/CardTypeView"},49);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(4629853583167022151L),null));
c.Add(new JField("EMPTY","Lforge/card/CardTypeView;",true,JValue.Default("Lforge/card/CardTypeView;"),null));
c.Add(new JField("coreTypes","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("supertypes","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("subtypes","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("allCreatureTypes","Z",false,JValue.Default("Z"),null));
c.Add(new JField("excludedCreatureSubtypes","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("incomplete","Z",false,JValue.Default("Z"),null));
c.Add(new JField("calculatedType","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sortedSubTypes","Ljava/util/List;",true,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(787,"forge/card/CardType","<init>","(Z)V",1,2,2,new JHandler[]{},M787));
c.Add(new JMethod(788,"forge/card/CardType","<init>","(Ljava/lang/Iterable;Z)V",1,3,2,new JHandler[]{},M788));
c.Add(new JMethod(789,"forge/card/CardType","<init>","(Lforge/card/CardType;)V",1,2,2,new JHandler[]{},M789));
c.Add(new JMethod(790,"forge/card/CardType","<init>","(Lforge/card/CardTypeView;)V",1,2,2,new JHandler[]{},M790));
c.Add(new JMethod(791,"forge/card/CardType","add","(Ljava/lang/String;)Z",1,5,2,new JHandler[]{},M791));
c.Add(new JMethod(792,"forge/card/CardType","addAll","(Ljava/lang/Iterable;)Z",1,5,2,new JHandler[]{},M792));
c.Add(new JMethod(793,"forge/card/CardType","addAll","(Lforge/card/CardType;)Z",1,3,2,new JHandler[]{},M793));
c.Add(new JMethod(794,"forge/card/CardType","addAll","(Lforge/card/CardTypeView;)Z",1,3,2,new JHandler[]{},M794));
c.Add(new JMethod(795,"forge/card/CardType","removeAll","(Lforge/card/CardTypeView;)Z",1,3,2,new JHandler[]{},M795));
c.Add(new JMethod(796,"forge/card/CardType","clear","()V",1,1,2,new JHandler[]{},M796));
c.Add(new JMethod(797,"forge/card/CardType","removeCardTypes","()V",1,1,1,new JHandler[]{},M797));
c.Add(new JMethod(798,"forge/card/CardType","remove","(Lforge/card/CardType$Supertype;)Z",1,2,2,new JHandler[]{},M798));
c.Add(new JMethod(799,"forge/card/CardType","remove","(Ljava/lang/String;)Z",1,5,2,new JHandler[]{},M799));
c.Add(new JMethod(800,"forge/card/CardType","setCreatureTypes","(Ljava/util/Collection;)Z",1,3,2,new JHandler[]{},M800));
c.Add(new JMethod(801,"forge/card/CardType","isEmpty","()Z",1,1,1,new JHandler[]{},M801));
c.Add(new JMethod(802,"forge/card/CardType","getCoreTypes","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M802));
c.Add(new JMethod(803,"forge/card/CardType","getSupertypes","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M803));
c.Add(new JMethod(804,"forge/card/CardType","getSubtypes","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M804));
c.Add(new JMethod(805,"forge/card/CardType","getExcludedCreatureSubTypes","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M805));
c.Add(new JMethod(806,"forge/card/CardType","getCreatureTypes","()Ljava/util/Set;",1,2,3,new JHandler[]{},M806));
c.Add(new JMethod(807,"forge/card/CardType","getPlaneswalkerTypes","()Ljava/util/Set;",1,4,2,new JHandler[]{},M807));
c.Add(new JMethod(808,"forge/card/CardType","getLandTypes","()Ljava/util/Set;",1,4,2,new JHandler[]{},M808));
c.Add(new JMethod(809,"forge/card/CardType","getBattleTypes","()Ljava/util/Set;",1,1,2,new JHandler[]{},M809));
c.Add(new JMethod(810,"forge/card/CardType","hasStringType","(Ljava/lang/String;)Z",1,4,2,new JHandler[]{},M810));
c.Add(new JMethod(811,"forge/card/CardType","hasType","(Lforge/card/CardType$CoreType;)Z",1,2,2,new JHandler[]{},M811));
c.Add(new JMethod(812,"forge/card/CardType","hasSupertype","(Lforge/card/CardType$Supertype;)Z",1,2,2,new JHandler[]{},M812));
c.Add(new JMethod(813,"forge/card/CardType","hasAllCreatureTypes","()Z",1,1,1,new JHandler[]{},M813));
c.Add(new JMethod(814,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M814));
c.Add(new JMethod(815,"forge/card/CardType","hasCreatureType","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M815));
c.Add(new JMethod(816,"forge/card/CardType","toMixedCase","(Ljava/lang/String;)Ljava/lang/String;",10,5,3,new JHandler[]{},M816));
c.Add(new JMethod(817,"forge/card/CardType","hasABasicLandType","()Z",1,1,2,new JHandler[]{},M817));
c.Add(new JMethod(818,"forge/card/CardType","hasANonBasicLandType","()Z",1,1,2,new JHandler[]{},M818));
c.Add(new JMethod(819,"forge/card/CardType","isPermanent","()Z",1,3,1,new JHandler[]{},M819));
c.Add(new JMethod(820,"forge/card/CardType","isCreature","()Z",1,1,2,new JHandler[]{},M820));
c.Add(new JMethod(821,"forge/card/CardType","isPlaneswalker","()Z",1,1,2,new JHandler[]{},M821));
c.Add(new JMethod(822,"forge/card/CardType","isBattle","()Z",1,1,2,new JHandler[]{},M822));
c.Add(new JMethod(823,"forge/card/CardType","isLand","()Z",1,1,2,new JHandler[]{},M823));
c.Add(new JMethod(824,"forge/card/CardType","isArtifact","()Z",1,1,2,new JHandler[]{},M824));
c.Add(new JMethod(825,"forge/card/CardType","isInstant","()Z",1,1,2,new JHandler[]{},M825));
c.Add(new JMethod(826,"forge/card/CardType","isSorcery","()Z",1,1,2,new JHandler[]{},M826));
c.Add(new JMethod(827,"forge/card/CardType","isConspiracy","()Z",1,1,2,new JHandler[]{},M827));
c.Add(new JMethod(828,"forge/card/CardType","isVanguard","()Z",1,1,2,new JHandler[]{},M828));
c.Add(new JMethod(829,"forge/card/CardType","isScheme","()Z",1,1,2,new JHandler[]{},M829));
c.Add(new JMethod(830,"forge/card/CardType","isEnchantment","()Z",1,1,2,new JHandler[]{},M830));
c.Add(new JMethod(831,"forge/card/CardType","isBasic","()Z",1,1,2,new JHandler[]{},M831));
c.Add(new JMethod(832,"forge/card/CardType","isLegendary","()Z",1,1,2,new JHandler[]{},M832));
c.Add(new JMethod(833,"forge/card/CardType","isSnow","()Z",1,1,2,new JHandler[]{},M833));
c.Add(new JMethod(834,"forge/card/CardType","isBasicLand","()Z",1,1,1,new JHandler[]{},M834));
c.Add(new JMethod(835,"forge/card/CardType","isPlane","()Z",1,1,2,new JHandler[]{},M835));
c.Add(new JMethod(836,"forge/card/CardType","isPhenomenon","()Z",1,1,2,new JHandler[]{},M836));
c.Add(new JMethod(837,"forge/card/CardType","isKindred","()Z",1,1,2,new JHandler[]{},M837));
c.Add(new JMethod(838,"forge/card/CardType","isDungeon","()Z",1,1,2,new JHandler[]{},M838));
c.Add(new JMethod(839,"forge/card/CardType","isStickers","()Z",1,1,2,new JHandler[]{},M839));
c.Add(new JMethod(840,"forge/card/CardType","isAttachment","()Z",1,1,1,new JHandler[]{},M840));
}

private static void Add1(JClass c){
c.Add(new JMethod(841,"forge/card/CardType","isAura","()Z",1,1,2,new JHandler[]{},M841));
c.Add(new JMethod(842,"forge/card/CardType","isEquipment","()Z",1,1,2,new JHandler[]{},M842));
c.Add(new JMethod(843,"forge/card/CardType","isFortification","()Z",1,1,2,new JHandler[]{},M843));
c.Add(new JMethod(844,"forge/card/CardType","isAttraction","()Z",1,1,2,new JHandler[]{},M844));
c.Add(new JMethod(845,"forge/card/CardType","isContraption","()Z",1,1,2,new JHandler[]{},M845));
c.Add(new JMethod(846,"forge/card/CardType","isVehicle","()Z",1,1,2,new JHandler[]{},M846));
c.Add(new JMethod(847,"forge/card/CardType","isSpacecraft","()Z",1,1,2,new JHandler[]{},M847));
c.Add(new JMethod(848,"forge/card/CardType","isSaga","()Z",1,1,2,new JHandler[]{},M848));
c.Add(new JMethod(849,"forge/card/CardType","isHistoric","()Z",1,1,1,new JHandler[]{},M849));
c.Add(new JMethod(850,"forge/card/CardType","isOutlaw","()Z",1,1,2,new JHandler[]{},M850));
c.Add(new JMethod(851,"forge/card/CardType","isParty","()Z",1,1,2,new JHandler[]{},M851));
c.Add(new JMethod(852,"forge/card/CardType","toString","()Ljava/lang/String;",1,2,4,new JHandler[]{},M852));
c.Add(new JMethod(853,"forge/card/CardType","getTypesBeforeDash","()Ljava/util/Set;",2,4,2,new JHandler[]{},M853));
c.Add(new JMethod(854,"forge/card/CardType","getTypeWithChanges","(Ljava/lang/Iterable;)Lforge/card/CardTypeView;",1,5,3,new JHandler[]{},M854));
c.Add(new JMethod(855,"forge/card/CardType","sanisfySubtypes","()V",1,2,2,new JHandler[]{},M855));
c.Add(new JMethod(856,"forge/card/CardType","compareTo","(Lforge/card/CardType;)I",1,2,2,new JHandler[]{},M856));
c.Add(new JMethod(857,"forge/card/CardType","sharesCreaturetypeWith","(Lforge/card/CardTypeView;)Z",1,4,2,new JHandler[]{},M857));
c.Add(new JMethod(858,"forge/card/CardType","sharesLandTypeWith","(Lforge/card/CardTypeView;)Z",1,4,2,new JHandler[]{},M858));
c.Add(new JMethod(859,"forge/card/CardType","sharesPermanentTypeWith","(Lforge/card/CardTypeView;)Z",1,4,2,new JHandler[]{},M859));
c.Add(new JMethod(860,"forge/card/CardType","sharesCardTypeWith","(Lforge/card/CardTypeView;)Z",1,4,2,new JHandler[]{},M860));
c.Add(new JMethod(861,"forge/card/CardType","sharesAllCardTypesWith","(Lforge/card/CardTypeView;)Z",1,4,2,new JHandler[]{},M861));
c.Add(new JMethod(862,"forge/card/CardType","sharesSubtypeWith","(Lforge/card/CardTypeView;)Z",1,4,2,new JHandler[]{},M862));
c.Add(new JMethod(863,"forge/card/CardType","getGamePieceType","()Lforge/card/GamePieceType;",1,4,2,new JHandler[]{},M863));
c.Add(new JMethod(864,"forge/card/CardType","parse","(Ljava/lang/String;Z)Lforge/card/CardType;",9,10,4,new JHandler[]{},M864));
c.Add(new JMethod(865,"forge/card/CardType","combine","(Lforge/card/CardType;Lforge/card/CardType;)Lforge/card/CardType;",9,3,3,new JHandler[]{},M865));
c.Add(new JMethod(866,"forge/card/CardType","getMultiwordType","(Ljava/lang/String;)Ljava/lang/String;",10,3,2,new JHandler[]{},M866));
c.Add(new JMethod(867,"forge/card/CardType","isACardType","(Ljava/lang/String;)Z",9,1,1,new JHandler[]{},M867));
c.Add(new JMethod(868,"forge/card/CardType","getAllCardTypes","()Ljava/util/Set;",9,0,1,new JHandler[]{},M868));
c.Add(new JMethod(869,"forge/card/CardType","getSortedSubTypes","()Ljava/util/List;",9,1,2,new JHandler[]{},M869));
c.Add(new JMethod(870,"forge/card/CardType","getBasicTypes","()Ljava/util/Collection;",9,0,1,new JHandler[]{},M870));
c.Add(new JMethod(871,"forge/card/CardType","getNonBasicTypes","()Ljava/util/Collection;",9,0,1,new JHandler[]{},M871));
c.Add(new JMethod(872,"forge/card/CardType","getAllCreatureTypes","()Ljava/util/Collection;",9,0,1,new JHandler[]{},M872));
c.Add(new JMethod(873,"forge/card/CardType","getAllWalkerTypes","()Ljava/util/Collection;",9,0,1,new JHandler[]{},M873));
c.Add(new JMethod(874,"forge/card/CardType","getAllLandTypes","()Ljava/util/List;",9,0,2,new JHandler[]{},M874));
c.Add(new JMethod(875,"forge/card/CardType","isASupertype","(Ljava/lang/String;)Z",9,1,1,new JHandler[]{},M875));
c.Add(new JMethod(876,"forge/card/CardType","isASubType","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M876));
c.Add(new JMethod(877,"forge/card/CardType","isAnArtifactType","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M877));
c.Add(new JMethod(878,"forge/card/CardType","isACreatureType","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M878));
c.Add(new JMethod(879,"forge/card/CardType","isALandType","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M879));
c.Add(new JMethod(880,"forge/card/CardType","isAPlaneswalkerType","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M880));
c.Add(new JMethod(881,"forge/card/CardType","isABasicLandType","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M881));
c.Add(new JMethod(882,"forge/card/CardType","isAnEnchantmentType","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M882));
c.Add(new JMethod(883,"forge/card/CardType","isASpellType","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M883));
c.Add(new JMethod(884,"forge/card/CardType","isADungeonType","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M884));
c.Add(new JMethod(885,"forge/card/CardType","isABattleType","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M885));
c.Add(new JMethod(886,"forge/card/CardType","isAPlanarType","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M886));
c.Add(new JMethod(887,"forge/card/CardType","getSingularType","(Ljava/lang/String;)Ljava/lang/String;",9,1,2,new JHandler[]{},M887));
c.Add(new JMethod(888,"forge/card/CardType","getPluralType","(Ljava/lang/String;)Ljava/lang/String;",9,1,2,new JHandler[]{},M888));
c.Add(new JMethod(889,"forge/card/CardType","compareTo","(Ljava/lang/Object;)I",4161,2,2,new JHandler[]{},M889));
c.Add(new JMethod(890,"forge/card/CardType","lambda$sanisfySubtypes$2","(Ljava/lang/String;)Z",4106,1,1,new JHandler[]{},M890));
c.Add(new JMethod(891,"forge/card/CardType","lambda$isParty$1","(Ljava/lang/String;)Z",4098,2,2,new JHandler[]{},M891));
c.Add(new JMethod(892,"forge/card/CardType","lambda$isOutlaw$0","(Ljava/lang/String;)Z",4098,2,2,new JHandler[]{},M892));
c.Add(new JMethod(893,"forge/card/CardType","<clinit>","()V",8,0,3,new JHandler[]{},M893));
}

internal static JStep M787(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.ClassObject("forge/card/CardType$CoreType")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",10);}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;",value);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.ClassObject("forge/card/CardType$Supertype")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"com/google/common/collect/Sets","newLinkedHashSet","()Ljava/util/LinkedHashSet;","invokestatic",26);}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","allCreatureTypes","Z",value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"com/google/common/collect/Sets","newLinkedHashSet","()Ljava/util/LinkedHashSet;","invokestatic",38);}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","excludedCreatureSubtypes","Ljava/util/Set;",value);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","incomplete","Z",value);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(null));f.Pc=48;continue;}
case 48:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","calculatedType","Ljava/lang/String;",value);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","incomplete","Z",value);f.Pc=56;continue;}
case 56:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M788(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.ClassObject("forge/card/CardType$CoreType")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",10);}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;",value);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.ClassObject("forge/card/CardType$Supertype")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"com/google/common/collect/Sets","newLinkedHashSet","()Ljava/util/LinkedHashSet;","invokestatic",26);}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","allCreatureTypes","Z",value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"com/google/common/collect/Sets","newLinkedHashSet","()Ljava/util/LinkedHashSet;","invokestatic",38);}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","excludedCreatureSubtypes","Ljava/util/Set;",value);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","incomplete","Z",value);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(null));f.Pc=48;continue;}
case 48:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","calculatedType","Ljava/lang/String;",value);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","incomplete","Z",value);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/card/CardType","addAll","(Ljava/lang/Iterable;)Z","invokevirtual",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M789(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.ClassObject("forge/card/CardType$CoreType")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",10);}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;",value);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.ClassObject("forge/card/CardType$Supertype")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"com/google/common/collect/Sets","newLinkedHashSet","()Ljava/util/LinkedHashSet;","invokestatic",26);}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","allCreatureTypes","Z",value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"com/google/common/collect/Sets","newLinkedHashSet","()Ljava/util/LinkedHashSet;","invokestatic",38);}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","excludedCreatureSubtypes","Ljava/util/Set;",value);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","incomplete","Z",value);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(null));f.Pc=48;continue;}
case 48:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","calculatedType","Ljava/lang/String;",value);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/card/CardType","addAll","(Lforge/card/CardType;)Z","invokevirtual",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","allCreatureTypes","Z"));f.Pc=62;continue;}
case 62:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","allCreatureTypes","Z",value);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","excludedCreatureSubtypes","Ljava/util/Set;"));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","excludedCreatureSubtypes","Ljava/util/Set;"));f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M790(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.ClassObject("forge/card/CardType$CoreType")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",10);}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;",value);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.ClassObject("forge/card/CardType$Supertype")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"com/google/common/collect/Sets","newLinkedHashSet","()Ljava/util/LinkedHashSet;","invokestatic",26);}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","allCreatureTypes","Z",value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"com/google/common/collect/Sets","newLinkedHashSet","()Ljava/util/LinkedHashSet;","invokestatic",38);}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","excludedCreatureSubtypes","Ljava/util/Set;",value);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","incomplete","Z",value);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(null));f.Pc=48;continue;}
case 48:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","calculatedType","Ljava/lang/String;",value);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/card/CardType","addAll","(Lforge/card/CardTypeView;)Z","invokevirtual",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M791(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType$CoreType","getEnum","(Ljava/lang/String;)Lforge/card/CardType$CoreType;","invokestatic",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?23:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Pc=60;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/card/CardType$Supertype","getEnum","(Ljava/lang/String;)Lforge/card/CardType$Supertype;","invokestatic",27);}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{f.Pc=f.Pop().Reference==null?49:34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",45);}
case 45:{f.Locals[2]=f.Pop();f.Pc=46;continue;}
case 46:{f.Pc=60;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",59);}
case 59:{f.Locals[2]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Int==0?71:64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(null));f.Pc=66;continue;}
case 66:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","calculatedType","Ljava/lang/String;",value);f.Pc=69;continue;}
case 69:{f.Push(JValue.I(1));f.Pc=70;continue;}
case 70:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M792(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?49:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/card/CardType","add","(Ljava/lang/String;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?46:44;continue;}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{f.Locals[2]=f.Pop();f.Pc=46;continue;}
case 46:{f.Pc=15;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/card/CardType","sanisfySubtypes","()V","invokevirtual",53);}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M793(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?20:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?38:36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",51);}
case 51:{f.Pc=f.Pop().Int==0?56:54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{f.Locals[2]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/card/CardType","sanisfySubtypes","()V","invokevirtual",60);}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M794(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardTypeView","getCoreTypes","()Ljava/util/Collection;","invokeinterface",12);}
case 12:{return rt.Call(f,"com/google/common/collect/Iterables","addAll","(Ljava/util/Collection;Ljava/lang/Iterable;)Z","invokestatic",15);}
case 15:{f.Pc=f.Pop().Int==0?20:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/card/CardTypeView","getSupertypes","()Ljava/util/Collection;","invokeinterface",30);}
case 30:{return rt.Call(f,"com/google/common/collect/Iterables","addAll","(Ljava/util/Collection;Ljava/lang/Iterable;)Z","invokestatic",33);}
case 33:{f.Pc=f.Pop().Int==0?38:36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/card/CardTypeView","getSubtypes","()Ljava/util/Collection;","invokeinterface",48);}
case 48:{return rt.Call(f,"com/google/common/collect/Iterables","addAll","(Ljava/util/Collection;Ljava/lang/Iterable;)Z","invokestatic",51);}
case 51:{f.Pc=f.Pop().Int==0?56:54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{f.Locals[2]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/card/CardType","sanisfySubtypes","()V","invokevirtual",60);}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M795(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardTypeView","getCoreTypes","()Ljava/util/Collection;","invokeinterface",12);}
case 12:{return rt.Call(f,"java/util/Set","removeAll","(Ljava/util/Collection;)Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?22:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/card/CardTypeView","getSupertypes","()Ljava/util/Collection;","invokeinterface",32);}
case 32:{return rt.Call(f,"java/util/Set","removeAll","(Ljava/util/Collection;)Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?42:40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{f.Locals[2]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/card/CardTypeView","getSubtypes","()Ljava/util/Collection;","invokeinterface",52);}
case 52:{return rt.Call(f,"java/util/Set","removeAll","(Ljava/util/Collection;)Z","invokeinterface",57);}
case 57:{f.Pc=f.Pop().Int==0?62:60;continue;}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{f.Locals[2]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{f.Pc=f.Pop().Int==0?77:66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/card/CardType","sanisfySubtypes","()V","invokevirtual",70);}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(null));f.Pc=72;continue;}
case 72:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","calculatedType","Ljava/lang/String;",value);f.Pc=75;continue;}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M796(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType","isEmpty","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Set","clear","()V","invokeinterface",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Set","clear","()V","invokeinterface",26);}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Set","clear","()V","invokeinterface",35);}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(null));f.Pc=37;continue;}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","calculatedType","Ljava/lang/String;",value);f.Pc=40;continue;}
case 40:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M797(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","clear","()V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M798(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M799(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{f.Pc=f.Pop().Int==0?20:15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Pc=71;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/card/CardType$Supertype","getEnum","(Ljava/lang/String;)Lforge/card/CardType$Supertype;","invokestatic",24);}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Pc=f.Pop().Reference==null?44:29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",39);}
case 39:{f.Pc=f.Pop().Int==0?44:42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{f.Locals[2]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/card/CardType$CoreType","getEnum","(Ljava/lang/String;)Lforge/card/CardType$CoreType;","invokestatic",48);}
case 48:{f.Locals[4]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Pc=f.Pop().Reference==null?71:55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",66);}
case 66:{f.Pc=f.Pop().Int==0?71:69;continue;}
case 69:{f.Push(JValue.I(1));f.Pc=70;continue;}
case 70:{f.Locals[2]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{f.Pc=f.Pop().Int==0?84:75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/card/CardType","sanisfySubtypes","()V","invokevirtual",79);}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(null));f.Pc=81;continue;}
case 81:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","calculatedType","Ljava/lang/String;",value);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M800(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType","isCreature","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?16:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardType","isKindred","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=20;continue;}
case 20:{return rt.DynamicCall(f,"forge/card/CardType:800:20:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",25);}
case 25:{return rt.Call(f,"java/util/Set","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",30);}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","allCreatureTypes","Z"));f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Int==0?40:38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{f.Locals[2]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","allCreatureTypes","Z",value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M801(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int==0?52:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?52:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?52:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","excludedCreatureSubtypes","Ljava/util/Set;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",45);}
case 45:{f.Pc=f.Pop().Int==0?52:48;continue;}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{f.Pc=53;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M802(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M803(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M804(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M805(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","excludedCreatureSubtypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M806(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Sets","newLinkedHashSet","()Ljava/util/LinkedHashSet;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","isCreature","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int!=0?20:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/card/CardType","isKindred","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?20:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/card/CardType","hasAllCreatureTypes","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?51:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/card/CardType","getAllCreatureTypes","()Ljava/util/Collection;","invokestatic",31);}
case 31:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","excludedCreatureSubtypes","Ljava/util/Set;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Set","removeAll","(Ljava/util/Collection;)Z","invokeinterface",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Pc=86;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",60);}
case 60:{return rt.DynamicCall(f,"forge/card/CardType:806:60:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",65);}
case 65:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",70);}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.StackOp("dup");f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{return rt.DynamicCall(f,"forge/card/CardType:806:76:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Set;)Ljava/util/function/Consumer;",81);}
case 81:{return rt.Call(f,"java/util/stream/Stream","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",86);}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M807(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Sets","newLinkedHashSet","()Ljava/util/LinkedHashSet;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","isPlaneswalker","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?58:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?58:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[3]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/card/CardType","isAPlaneswalkerType","(Ljava/lang/String;)Z","invokestatic",44);}
case 44:{f.Pc=f.Pop().Int==0?55:47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{f.Pc=21;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M808(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Sets","newLinkedHashSet","()Ljava/util/LinkedHashSet;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","isLand","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?58:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?58:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[3]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/card/CardType","isALandType","(Ljava/lang/String;)Z","invokestatic",44);}
case 44:{f.Pc=f.Pop().Int==0?55:47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{f.Pc=21;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M809(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType","isBattle","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{return rt.Call(f,"java/util/Set","of","()Ljava/util/Set;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",20);}
case 20:{return rt.DynamicCall(f,"forge/card/CardType:809:20:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",25);}
case 25:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",30);}
case 30:{return rt.Call(f,"java/util/stream/Collectors","toSet","()Ljava/util/stream/Collector;","invokestatic",33);}
case 33:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M810(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?19:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",23);}
case 23:{f.Locals[1]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/card/CardType$CoreType","getEnum","(Ljava/lang/String;)Lforge/card/CardType$CoreType;","invokestatic",28);}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference==null?39:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/card/CardType","hasType","(Lforge/card/CardType$CoreType;)Z","invokevirtual",38);}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/card/CardType$Supertype","getEnum","(Ljava/lang/String;)Lforge/card/CardType$Supertype;","invokestatic",43);}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{f.Pc=f.Pop().Reference==null?54:48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/card/CardType","hasSupertype","(Lforge/card/CardType$Supertype;)Z","invokevirtual",53);}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M811(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M812(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M813(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType","isCreature","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?16:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardType","isKindred","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","allCreatureTypes","Z"));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M814(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardType","hasCreatureType","(Ljava/lang/String;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?10:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",20);}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M815(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType","isCreature","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?16:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardType","isKindred","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/card/CardType","toMixedCase","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",20);}
case 20:{f.Locals[1]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/card/CardType","isACreatureType","(Ljava/lang/String;)Z","invokestatic",25);}
case 25:{f.Pc=f.Pop().Int!=0?30:28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","excludedCreatureSubtypes","Ljava/util/Set;"));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int==0?45:43;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","allCreatureTypes","Z"));f.Pc=49;continue;}
case 49:{f.Pc=f.Pop().Int==0?54:52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",64);}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M816(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","codePointAt","(I)I","invokevirtual",14);}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(45));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int>=0?34:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/Character","toTitleCase","(I)I","invokestatic",28);}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?34:32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return JStep.Return(f.Pop());}
case 34:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",41);}
case 41:{f.Locals[2]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("-")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Locals[3]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{f.Locals[4]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=56;continue;}
case 56:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?89:59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Int==0?71:64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("-")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[4]);f.Pc=75;continue;}
case 75:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=76;continue;}
case 76:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",79);}
case 79:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=86;continue;}
case 86:{f.Pc=52;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",93);}
case 93:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M817(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",9);}
case 9:{return rt.DynamicCall(f,"forge/card/CardType:817:9:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",14);}
case 14:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",19);}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M818(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardType","getNonBasicTypes","()Ljava/util/Collection;","invokestatic",7);}
case 7:{return rt.Call(f,"java/util/Collections","disjoint","(Ljava/util/Collection;Ljava/util/Collection;)Z","invokestatic",10);}
case 10:{f.Pc=f.Pop().Int!=0?17:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M819(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?41:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$CoreType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType$CoreType","isPermanent","Z"));f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Int==0?38:36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 38:{f.Pc=10;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M820(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Creature","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Creature","Lforge/card/CardType$CoreType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M821(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Planeswalker","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Planeswalker","Lforge/card/CardType$CoreType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M822(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Battle","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Battle","Lforge/card/CardType$CoreType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M823(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Land","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Land","Lforge/card/CardType$CoreType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M824(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Artifact","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Artifact","Lforge/card/CardType$CoreType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M825(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Instant","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Instant","Lforge/card/CardType$CoreType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M826(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Sorcery","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Sorcery","Lforge/card/CardType$CoreType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M827(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Conspiracy","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Conspiracy","Lforge/card/CardType$CoreType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M828(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Vanguard","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Vanguard","Lforge/card/CardType$CoreType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M829(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Scheme","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Scheme","Lforge/card/CardType$CoreType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M830(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Enchantment","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Enchantment","Lforge/card/CardType$CoreType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M831(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Basic","Lforge/card/CardType$Supertype;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","Basic","Lforge/card/CardType$Supertype;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M832(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Legendary","Lforge/card/CardType$Supertype;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","Legendary","Lforge/card/CardType$Supertype;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M833(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Snow","Lforge/card/CardType$Supertype;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","Snow","Lforge/card/CardType$Supertype;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M834(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType","isBasic","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardType","isLand","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M835(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Plane","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Plane","Lforge/card/CardType$CoreType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M836(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Phenomenon","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Phenomenon","Lforge/card/CardType$CoreType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M837(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Kindred","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Kindred","Lforge/card/CardType$CoreType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M838(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Dungeon","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Dungeon","Lforge/card/CardType$CoreType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M839(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Stickers","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Stickers","Lforge/card/CardType$CoreType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M840(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType","isAura","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardType","isEquipment","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?21:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardType","isFortification","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?25:21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Pc=26;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M841(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Aura")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M842(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Equipment")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M843(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Fortification")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M844(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Attraction")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M845(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Contraption")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M846(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Vehicle")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M847(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Spacecraft")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M848(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Saga")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M849(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType","isLegendary","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardType","isArtifact","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?21:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardType","isSaga","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?25:21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Pc=26;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M850(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType","isCreature","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?16:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardType","isKindred","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","OUTLAW_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","OUTLAW_TYPES","Ljava/util/Set;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",24);}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.DynamicCall(f,"forge/card/CardType:850:25:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardType;)Ljava/util/function/Predicate;",30);}
case 30:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",35);}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M851(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType","isCreature","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?16:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardType","isKindred","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","PARTY_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","PARTY_TYPES","Ljava/util/Set;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",24);}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.DynamicCall(f,"forge/card/CardType:851:25:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardType;)Ljava/util/function/Predicate;",30);}
case 30:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",35);}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M852(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","calculatedType","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?162:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/card/CardType","getTypesBeforeDash","()Ljava/util/Set;","invokevirtual",15);}
case 15:{f.Push(JValue.I(32));f.Pc=17;continue;}
case 17:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;C)Ljava/lang/String;","invokestatic",20);}
case 20:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",23);}
case 23:{f.Locals[1]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?43:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/CardType","hasAllCreatureTypes","()Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?51:43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String(" - ")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",50);}
case 50:{f.StackOp("pop");f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",60);}
case 60:{f.Pc=f.Pop().Int!=0?78:63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String(" ")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",74);}
case 74:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",77);}
case 77:{f.StackOp("pop");f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/card/CardType","hasAllCreatureTypes","()Z","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Int==0?154:85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",94);}
case 94:{f.Pc=f.Pop().Int!=0?105:97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String(" ")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",104);}
case 104:{f.StackOp("pop");f.Pc=105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("(All")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",112);}
case 112:{f.StackOp("pop");f.Pc=113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","excludedCreatureSubtypes","Ljava/util/Set;"));f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",122);}
case 122:{f.Pc=f.Pop().Int!=0?146:125;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String(" except ")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",132);}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","excludedCreatureSubtypes","Ljava/util/Set;"));f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.String(" ")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",142);}
case 142:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",145);}
case 145:{f.StackOp("pop");f.Pc=146;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{f.Push(JValue.R(rt.String(")")));f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",153);}
case 153:{f.StackOp("pop");f.Pc=154;continue;}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",159);}
case 159:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","calculatedType","Ljava/lang/String;",value);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[0]);f.Pc=163;continue;}
case 163:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","calculatedType","Ljava/lang/String;"));f.Pc=166;continue;}
case 166:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M853(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Sets","newLinkedHashSet","()Ljava/util/LinkedHashSet;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?47:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$Supertype"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/card/CardType$Supertype","name","()Ljava/lang/String;","invokevirtual",38);}
case 38:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",43);}
case 43:{f.StackOp("pop");f.Pc=44;continue;}
case 44:{f.Pc=14;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",56);}
case 56:{f.Locals[2]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",63);}
case 63:{f.Pc=f.Pop().Int==0?90:66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$CoreType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{f.Locals[3]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[3]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/card/CardType$CoreType","name","()Ljava/lang/String;","invokevirtual",81);}
case 81:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",86);}
case 86:{f.StackOp("pop");f.Pc=87;continue;}
case 87:{f.Pc=57;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M854(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/Iterables","isEmpty","(Ljava/lang/Iterable;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardType","<init>","(Lforge/card/CardType;)V","invokespecial",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",24);}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",31);}
case 31:{f.Pc=f.Pop().Int==0?57:34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardChangedType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[4]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/card/ICardChangedType","applyChanges","(Lforge/card/CardType;)Lforge/card/CardType;","invokeinterface",53);}
case 53:{f.Locals[2]=f.Pop();f.Pc=54;continue;}
case 54:{f.Pc=25;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",66);}
case 66:{f.Pc=f.Pop().Int!=0?73:69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/card/CardType","sanisfySubtypes","()V","invokevirtual",73);}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M855(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","incomplete","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardType","isCreature","()Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int!=0?27:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/CardType","isKindred","()Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int!=0?27:22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","allCreatureTypes","Z",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",36);}
case 36:{f.Pc=f.Pop().Int==0?40:39;continue;}
case 39:{return JStep.ReturnVoid;}
case 40:{return rt.DynamicCall(f,"forge/card/CardType:855:40:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",45);}
case 45:{f.Locals[1]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/card/CardType","isCreature","()Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int!=0?60:53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/card/CardType","isKindred","()Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?72:60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{return rt.DynamicCall(f,"forge/card/CardType:855:61:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",66);}
case 66:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",71);}
case 71:{f.Locals[1]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/card/CardType","isLand","()Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int==0?91:79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{return rt.DynamicCall(f,"forge/card/CardType:855:80:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",85);}
case 85:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",90);}
case 90:{f.Locals[1]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/card/CardType","isArtifact","()Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int==0?110:98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{return rt.DynamicCall(f,"forge/card/CardType:855:99:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",104);}
case 104:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",109);}
case 109:{f.Locals[1]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/card/CardType","isEnchantment","()Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?129:117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{return rt.DynamicCall(f,"forge/card/CardType:855:118:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",123);}
case 123:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",128);}
case 128:{f.Locals[1]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/card/CardType","isInstant","()Z","invokevirtual",133);}
case 133:{f.Pc=f.Pop().Int!=0?143:136;continue;}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/card/CardType","isSorcery","()Z","invokevirtual",140);}
case 140:{f.Pc=f.Pop().Int==0?155:143;continue;}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{return rt.DynamicCall(f,"forge/card/CardType:855:144:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",149);}
case 149:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",154);}
case 154:{f.Locals[1]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/card/CardType","isPlaneswalker","()Z","invokevirtual",159);}
case 159:{f.Pc=f.Pop().Int==0?174:162;continue;}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{return rt.DynamicCall(f,"forge/card/CardType:855:163:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",168);}
case 168:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",173);}
case 173:{f.Locals[1]=f.Pop();f.Pc=174;continue;}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/card/CardType","isDungeon","()Z","invokevirtual",178);}
case 178:{f.Pc=f.Pop().Int==0?193:181;continue;}
case 181:{f.Push(f.Locals[1]);f.Pc=182;continue;}
case 182:{return rt.DynamicCall(f,"forge/card/CardType:855:182:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",187);}
case 187:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",192);}
case 192:{f.Locals[1]=f.Pop();f.Pc=193;continue;}
case 193:{f.Push(f.Locals[0]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/card/CardType","isBattle","()Z","invokevirtual",197);}
case 197:{f.Pc=f.Pop().Int==0?212:200;continue;}
case 200:{f.Push(f.Locals[1]);f.Pc=201;continue;}
case 201:{return rt.DynamicCall(f,"forge/card/CardType:855:201:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",206);}
case 206:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",211);}
case 211:{f.Locals[1]=f.Pop();f.Pc=212;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/card/CardType","isPlane","()Z","invokevirtual",216);}
case 216:{f.Pc=f.Pop().Int==0?231:219;continue;}
case 219:{f.Push(f.Locals[1]);f.Pc=220;continue;}
case 220:{return rt.DynamicCall(f,"forge/card/CardType:855:220:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",225);}
case 225:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",230);}
case 230:{f.Locals[1]=f.Pop();f.Pc=231;continue;}
case 231:{f.Push(f.Locals[0]);f.Pc=232;continue;}
case 232:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=235;continue;}
case 235:{f.Push(f.Locals[1]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/util/function/Predicate","negate","()Ljava/util/function/Predicate;","invokeinterface",241);}
case 241:{return rt.Call(f,"java/util/Set","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",246);}
case 246:{f.StackOp("pop");f.Pc=247;continue;}
case 247:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M856(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType","toString","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","toString","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/String","compareTo","(Ljava/lang/String;)I","invokevirtual",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M857(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardType","isCreature","()Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int!=0?22:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardType","isKindred","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int!=0?22:20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/card/CardTypeView","isCreature","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int!=0?42:31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/card/CardTypeView","isKindred","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int!=0?42:40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","allCreatureTypes","Z"));f.Pc=46;continue;}
case 46:{f.Pc=f.Pop().Int==0?84:49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/card/CardTypeView","hasAllCreatureTypes","()Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?84:58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","excludedCreatureSubtypes","Ljava/util/Set;"));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",67);}
case 67:{f.Pc=f.Pop().Int==0?84:70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/card/CardTypeView","getExcludedCreatureSubTypes","()Ljava/lang/Iterable;","invokeinterface",76);}
case 76:{return rt.Call(f,"com/google/common/collect/Iterables","isEmpty","(Ljava/lang/Iterable;)Z","invokestatic",79);}
case 79:{f.Pc=f.Pop().Int==0?84:82;continue;}
case 82:{f.Push(JValue.I(1));f.Pc=83;continue;}
case 83:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/card/CardType","getCreatureTypes","()Ljava/util/Set;","invokevirtual",88);}
case 88:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",93);}
case 93:{f.Locals[2]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",100);}
case 100:{f.Pc=f.Pop().Int==0?128:103;continue;}
case 103:{f.Push(f.Locals[2]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",109);}
case 109:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=112;continue;}
case 112:{f.Locals[3]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[3]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/card/CardTypeView","hasCreatureType","(Ljava/lang/String;)Z","invokeinterface",120);}
case 120:{f.Pc=f.Pop().Int==0?125:123;continue;}
case 123:{f.Push(JValue.I(1));f.Pc=124;continue;}
case 124:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 125:{f.Pc=94;continue;}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/card/CardTypeView","getCreatureTypes","()Ljava/util/Set;","invokeinterface",134);}
case 134:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",139);}
case 139:{f.Locals[2]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[2]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",146);}
case 146:{f.Pc=f.Pop().Int==0?172:149;continue;}
case 149:{f.Push(f.Locals[2]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",155);}
case 155:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=158;continue;}
case 158:{f.Locals[3]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[3]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/card/CardType","hasCreatureType","(Ljava/lang/String;)Z","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Int==0?169:167;continue;}
case 167:{f.Push(JValue.I(1));f.Pc=168;continue;}
case 168:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 169:{f.Pc=140;continue;}
case 172:{f.Push(JValue.I(0));f.Pc=173;continue;}
case 173:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M858(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardType","getLandTypes","()Ljava/util/Set;","invokevirtual",10);}
case 10:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?50:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?47:45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 47:{f.Pc=16;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M859(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardType","getCoreTypes","()Ljava/util/Collection;","invokevirtual",10);}
case 10:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?57:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$CoreType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType$CoreType","isPermanent","Z"));f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Int==0?54:42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/card/CardTypeView","hasType","(Lforge/card/CardType$CoreType;)Z","invokeinterface",49);}
case 49:{f.Pc=f.Pop().Int==0?54:52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 54:{f.Pc=16;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M860(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardType","getCoreTypes","()Ljava/util/Collection;","invokevirtual",10);}
case 10:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?50:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$CoreType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/CardTypeView","hasType","(Lforge/card/CardType$CoreType;)Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?47:45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 47:{f.Pc=16;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M861(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardType","getCoreTypes","()Ljava/util/Collection;","invokevirtual",10);}
case 10:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?50:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$CoreType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/CardTypeView","hasType","(Lforge/card/CardType$CoreType;)Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int!=0?47:45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 47:{f.Pc=16;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/card/CardTypeView","getCoreTypes","()Ljava/util/Collection;","invokeinterface",56);}
case 56:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",61);}
case 61:{f.Locals[2]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",68);}
case 68:{f.Pc=f.Pop().Int==0?94:71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",77);}
case 77:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$CoreType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=80;continue;}
case 80:{f.Locals[3]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/card/CardType","hasType","(Lforge/card/CardType$CoreType;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int!=0?91:89;continue;}
case 89:{f.Push(JValue.I(0));f.Pc=90;continue;}
case 90:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 91:{f.Pc=62;continue;}
case 94:{f.Push(JValue.I(1));f.Pc=95;continue;}
case 95:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M862(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardType","sharesCreaturetypeWith","(Lforge/card/CardTypeView;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?16:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/card/CardTypeView","getSubtypes","()Ljava/util/Collection;","invokeinterface",22);}
case 22:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",27);}
case 27:{f.Locals[2]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",34);}
case 34:{f.Pc=f.Pop().Int==0?60:37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{f.Locals[3]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int==0?57:55;continue;}
case 55:{f.Push(JValue.I(1));f.Pc=56;continue;}
case 56:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 57:{f.Pc=28;continue;}
case 60:{f.Push(JValue.I(0));f.Pc=61;continue;}
case 61:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M863(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType","isAttraction","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?11:7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/GamePieceType","ATTRACTION","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","ATTRACTION","Lforge/card/GamePieceType;"));f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/card/CardType","isContraption","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?22:18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/card/GamePieceType","CONTRAPTION","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","CONTRAPTION","Lforge/card/GamePieceType;"));f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",31);}
case 31:{f.Locals[1]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int==0?68:41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$CoreType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{f.Locals[2]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/card/CardType$CoreType","toGamePieceType","()Lforge/card/GamePieceType;","invokevirtual",55);}
case 55:{f.Locals[3]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"forge/card/GamePieceType","CARD","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","CARD","Lforge/card/GamePieceType;"));f.Pc=60;continue;}
case 60:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?65:63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{return JStep.Return(f.Pop());}
case 65:{f.Pc=32;continue;}
case 68:{if(!rt.StaticReady(f,"forge/card/GamePieceType","CARD","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","CARD","Lforge/card/GamePieceType;"));f.Pc=71;continue;}
case 71:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M864(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(32));f.Pc=2;continue;}
case 2:{f.Locals[2]=f.Pop();f.Pc=3;continue;}
case 3:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=6;continue;}
case 6:{f.StackOp("dup");f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardType","<init>","(Z)V","invokespecial",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",19);}
case 19:{f.Locals[5]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[5]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Int<=0?30:26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{f.Pc=31;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{f.Locals[6]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[6]);f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Int==0?125:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Locals[7]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[7]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/card/CardType","getMultiwordType","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",51);}
case 51:{f.Locals[8]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[8]);f.Pc=55;continue;}
case 55:{f.Pc=f.Pop().Reference!=null?89:58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(JValue.I(32));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[4]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","indexOf","(II)I","invokevirtual",66);}
case 66:{f.Locals[9]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[9]);f.Pc=73;continue;}
case 73:{f.Push(JValue.I(-1));f.Pc=74;continue;}
case 74:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?82:77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{f.Pc=84;continue;}
case 82:{f.Push(f.Locals[9]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",87);}
case 87:{f.Locals[8]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[8]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/card/CardType","add","(Ljava/lang/String;)Z","invokevirtual",95);}
case 95:{f.StackOp("pop");f.Pc=96;continue;}
case 96:{f.Push(f.Locals[4]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[8]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",103);}
case 103:{f.Push(JValue.I(1));f.Pc=104;continue;}
case 104:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=105;continue;}
case 105:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=106;continue;}
case 106:{f.Locals[4]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[5]);f.Pc=112;continue;}
case 112:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?119:115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{f.Pc=120;continue;}
case 119:{f.Push(JValue.I(0));f.Pc=120;continue;}
case 120:{f.Locals[6]=f.Pop();f.Pc=122;continue;}
case 122:{f.Pc=33;continue;}
case 125:{f.Push(f.Locals[3]);f.Pc=126;continue;}
case 126:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M865(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","<init>","(Z)V","invokespecial",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",22);}
case 22:{f.StackOp("pop");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",50);}
case 50:{f.StackOp("pop");f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",92);}
case 92:{f.StackOp("pop");f.Pc=93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M866(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","MultiwordTypes","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","MultiwordTypes","Ljava/util/Set;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",8);}
case 8:{f.Locals[1]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?41:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[2]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?38:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return JStep.Return(f.Pop());}
case 38:{f.Pc=9;continue;}
case 41:{f.Push(JValue.R(null));f.Pc=42;continue;}
case 42:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M867(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType$CoreType","isValidEnum","(Ljava/lang/String;)Z","invokestatic",4);}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M868(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","allCoreTypeNames","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","allCoreTypeNames","Ljava/util/Set;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M869(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType","sortedSubTypes","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType","sortedSubTypes","Ljava/util/List;"));f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference!=null?121:6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/util/TreeSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeSet")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/TreeSet","<init>","()V","invokespecial",13);}
case 13:{f.Locals[0]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","BASIC_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","BASIC_TYPES","Ljava/util/Set;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","LAND_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","LAND_TYPES","Ljava/util/Set;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","CREATURE_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","CREATURE_TYPES","Ljava/util/Set;"));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",43);}
case 43:{f.StackOp("pop");f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","SPELL_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","SPELL_TYPES","Ljava/util/Set;"));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","ENCHANTMENT_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","ENCHANTMENT_TYPES","Ljava/util/Set;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","ARTIFACT_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","ARTIFACT_TYPES","Ljava/util/Set;"));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",73);}
case 73:{f.StackOp("pop");f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","WALKER_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","WALKER_TYPES","Ljava/util/Set;"));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","DUNGEON_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","DUNGEON_TYPES","Ljava/util/Set;"));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",93);}
case 93:{f.StackOp("pop");f.Pc=94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","BATTLE_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","BATTLE_TYPES","Ljava/util/Set;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",103);}
case 103:{f.StackOp("pop");f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","PLANAR_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","PLANAR_TYPES","Ljava/util/Set;"));f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",113);}
case 113:{f.StackOp("pop");f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"com/google/common/collect/ImmutableList","copyOf","(Ljava/util/Collection;)Lcom/google/common/collect/ImmutableList;","invokestatic",118);}
case 118:{if(!rt.StaticReady(f,"forge/card/CardType","sortedSubTypes","Ljava/util/List;"))return JStep.Continue;rt.PutStatic("forge/card/CardType","sortedSubTypes","Ljava/util/List;",f.Pop());f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/card/CardType","sortedSubTypes","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType","sortedSubTypes","Ljava/util/List;"));f.Pc=124;continue;}
case 124:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M870(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","BASIC_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","BASIC_TYPES","Ljava/util/Set;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Collections","unmodifiableCollection","(Ljava/util/Collection;)Ljava/util/Collection;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M871(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","LAND_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","LAND_TYPES","Ljava/util/Set;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Collections","unmodifiableCollection","(Ljava/util/Collection;)Ljava/util/Collection;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M872(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","CREATURE_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","CREATURE_TYPES","Ljava/util/Set;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Collections","unmodifiableCollection","(Ljava/util/Collection;)Ljava/util/Collection;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M873(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","WALKER_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","WALKER_TYPES","Ljava/util/Set;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Collections","unmodifiableCollection","(Ljava/util/Collection;)Ljava/util/Collection;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M874(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/ImmutableList","builder","()Lcom/google/common/collect/ImmutableList$Builder;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/card/CardType","getBasicTypes","()Ljava/util/Collection;","invokestatic",6);}
case 6:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","addAll","(Ljava/lang/Iterable;)Lcom/google/common/collect/ImmutableList$Builder;","invokevirtual",9);}
case 9:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","LAND_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","LAND_TYPES","Ljava/util/Set;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","addAll","(Ljava/lang/Iterable;)Lcom/google/common/collect/ImmutableList$Builder;","invokevirtual",15);}
case 15:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","build","()Lcom/google/common/collect/ImmutableList;","invokevirtual",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M875(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType$Supertype","isValidEnum","(Ljava/lang/String;)Z","invokestatic",4);}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M876(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/card/CardType","getSortedSubTypes","()Ljava/util/List;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M877(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","ARTIFACT_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","ARTIFACT_TYPES","Ljava/util/Set;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M878(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","CREATURE_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","CREATURE_TYPES","Ljava/util/Set;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M879(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","LAND_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","LAND_TYPES","Ljava/util/Set;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int!=0?19:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/CardType","isABasicLandType","(Ljava/lang/String;)Z","invokestatic",16);}
case 16:{f.Pc=f.Pop().Int==0?23:19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M880(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","WALKER_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","WALKER_TYPES","Ljava/util/Set;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M881(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","BASIC_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","BASIC_TYPES","Ljava/util/Set;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M882(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","ENCHANTMENT_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","ENCHANTMENT_TYPES","Ljava/util/Set;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M883(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","SPELL_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","SPELL_TYPES","Ljava/util/Set;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M884(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","DUNGEON_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","DUNGEON_TYPES","Ljava/util/Set;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M885(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","BATTLE_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","BATTLE_TYPES","Ljava/util/Set;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M886(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","PLANAR_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","PLANAR_TYPES","Ljava/util/Set;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M887(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","singularTypes","Lcom/google/common/collect/BiMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","singularTypes","Lcom/google/common/collect/BiMap;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/BiMap","containsKey","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int==0?25:12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","singularTypes","Lcom/google/common/collect/BiMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","singularTypes","Lcom/google/common/collect/BiMap;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"com/google/common/collect/BiMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",21);}
case 21:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M888(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","pluralTypes","Lcom/google/common/collect/BiMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","pluralTypes","Lcom/google/common/collect/BiMap;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/BiMap","containsKey","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int==0?25:12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","pluralTypes","Lcom/google/common/collect/BiMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","pluralTypes","Lcom/google/common/collect/BiMap;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"com/google/common/collect/BiMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",21);}
case 21:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M889(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","compareTo","(Lforge/card/CardType;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M890(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M891(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardType","hasCreatureType","(Ljava/lang/String;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M892(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardType","hasCreatureType","(Ljava/lang/String;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M893(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","<init>","(Z)V","invokespecial",8);}
case 8:{if(!rt.StaticReady(f,"forge/card/CardType","EMPTY","Lforge/card/CardTypeView;"))return JStep.Continue;rt.PutStatic("forge/card/CardType","EMPTY","Lforge/card/CardTypeView;",f.Pop());f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
