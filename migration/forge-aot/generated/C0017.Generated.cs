// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C17{
internal static JClass Build(){var c=new JClass("forge/card/CardEdition","java/lang/Object",new string[]{"java/lang/Comparable"},49);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("reservedSectionNames","Ljava/util/List;",true,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("sortableCollNumberLookup","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("formatter","Ljava/text/SimpleDateFormat;",true,JValue.Default("Ljava/text/SimpleDateFormat;"),null));
c.Add(new JField("UNKNOWN_CODE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"???"));
c.Add(new JField("UNKNOWN_SET_NAME","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"UNKNOWN"));
c.Add(new JField("UNKNOWN","Lforge/card/CardEdition;",true,JValue.Default("Lforge/card/CardEdition;"),null));
c.Add(new JField("date","Ljava/util/Date;",false,JValue.Default("Ljava/util/Date;"),null));
c.Add(new JField("code","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("code2","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("scryfallCode","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("tokensCode","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("tokenFallbackCode","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("cardsLanguage","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("type","Lforge/card/CardEdition$Type;",false,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("alias","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("borderColor","Lforge/card/CardEdition$BorderColor;",false,JValue.Default("Lforge/card/CardEdition$BorderColor;"),null));
c.Add(new JField("prerelease","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("boosterBoxCount","I",false,JValue.Default("I"),null));
c.Add(new JField("fatPackCount","I",false,JValue.Default("I"),null));
c.Add(new JField("fatPackExtraSlots","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("boosterSlots","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("smallSetOverride","Z",false,JValue.Default("Z"),null));
c.Add(new JField("additionalUnlockSet","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("foilType","Lforge/card/CardEdition$FoilType;",false,JValue.Default("Lforge/card/CardEdition$FoilType;"),null));
c.Add(new JField("foilAlwaysInCommonSlot","Z",false,JValue.Default("Z"),null));
c.Add(new JField("foilChanceInBooster","D",false,JValue.Default("D"),null));
c.Add(new JField("chanceReplaceCommonWith","D",false,JValue.Default("D"),null));
c.Add(new JField("slotReplaceCommonWith","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("additionalSheetForFoils","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("boosterMustContain","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("boosterReplaceSlotFromPrintSheet","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sheetReplaceCardFromSheet","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sheetReplaceCardFromSheet2","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("draftOptions","Lforge/card/DraftOptions;",false,JValue.Default("Lforge/card/DraftOptions;"),null));
c.Add(new JField("draftType","Lforge/card/CardEdition$DraftType;",false,JValue.Default("Lforge/card/CardEdition$DraftType;"),null));
c.Add(new JField("chaosDraftThemes","[Ljava/lang/String;",false,JValue.Default("[Ljava/lang/String;"),null));
c.Add(new JField("cardMap","Lcom/google/common/collect/ListMultimap;",false,JValue.Default("Lcom/google/common/collect/ListMultimap;"),null));
c.Add(new JField("cardsInSet","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("tokenMap","Lcom/google/common/collect/ListMultimap;",false,JValue.Default("Lcom/google/common/collect/ListMultimap;"),null));
c.Add(new JField("customPrintSheetsToParse","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("otherMap","Lcom/google/common/collect/ListMultimap;",false,JValue.Default("Lcom/google/common/collect/ListMultimap;"),null));
c.Add(new JField("boosterArts","I",false,JValue.Default("I"),null));
c.Add(new JField("boosterTpl","Lforge/item/SealedTemplate;",false,JValue.Default("Lforge/item/SealedTemplate;"),null));
c.Add(new JField("boosterTemplates","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cardsInSetLookupMap","Lcom/google/common/collect/ListMultimap;",false,JValue.Default("Lcom/google/common/collect/ListMultimap;"),null));
c.Add(new JField("traditionalCollectorNumbers","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JMethod(362,"forge/card/CardEdition","getDraftOptions","()Lforge/card/DraftOptions;",1,1,1,new JHandler[]{},M362));
c.Add(new JMethod(363,"forge/card/CardEdition","getSortableCollectorNumber","(Ljava/lang/String;)Ljava/lang/String;",9,9,6,new JHandler[]{new JHandler(36,59,62,"java/lang/NumberFormatException"),new JHandler(84,90,93,"java/lang/NumberFormatException")},M363));
c.Add(new JMethod(364,"forge/card/CardEdition","<init>","(Lcom/google/common/collect/ListMultimap;Lcom/google/common/collect/ListMultimap;Ljava/util/Map;)V",2,4,6,new JHandler[]{},M364));
c.Add(new JMethod(365,"forge/card/CardEdition","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/card/CardEdition$Type;Ljava/lang/String;Lforge/card/CardEdition$FoilType;)V",2,7,5,new JHandler[]{},M365));
c.Add(new JMethod(366,"forge/card/CardEdition","parseDate","(Ljava/lang/String;)Ljava/util/Date;",10,2,2,new JHandler[]{new JHandler(16,23,24,"java/lang/Exception")},M366));
c.Add(new JMethod(367,"forge/card/CardEdition","getDate","()Ljava/util/Date;",1,1,1,new JHandler[]{},M367));
c.Add(new JMethod(368,"forge/card/CardEdition","getCode","()Ljava/lang/String;",1,1,1,new JHandler[]{},M368));
c.Add(new JMethod(369,"forge/card/CardEdition","getCode2","()Ljava/lang/String;",1,1,1,new JHandler[]{},M369));
c.Add(new JMethod(370,"forge/card/CardEdition","getScryfallCode","()Ljava/lang/String;",1,1,1,new JHandler[]{},M370));
c.Add(new JMethod(371,"forge/card/CardEdition","getTokensCode","()Ljava/lang/String;",1,1,1,new JHandler[]{},M371));
c.Add(new JMethod(372,"forge/card/CardEdition","getCardsLangCode","()Ljava/lang/String;",1,1,1,new JHandler[]{},M372));
c.Add(new JMethod(373,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;",1,1,1,new JHandler[]{},M373));
c.Add(new JMethod(374,"forge/card/CardEdition","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M374));
c.Add(new JMethod(375,"forge/card/CardEdition","getAlias","()Ljava/lang/String;",1,1,1,new JHandler[]{},M375));
c.Add(new JMethod(376,"forge/card/CardEdition","getPrerelease","()Ljava/lang/String;",1,1,1,new JHandler[]{},M376));
c.Add(new JMethod(377,"forge/card/CardEdition","getBoosterBoxCount","()I",1,1,1,new JHandler[]{},M377));
c.Add(new JMethod(378,"forge/card/CardEdition","getFatPackCount","()I",1,1,1,new JHandler[]{},M378));
}

private static void Add1(JClass c){
c.Add(new JMethod(379,"forge/card/CardEdition","getFatPackExtraSlots","()Ljava/lang/String;",1,1,1,new JHandler[]{},M379));
c.Add(new JMethod(380,"forge/card/CardEdition","getFoilType","()Lforge/card/CardEdition$FoilType;",1,1,1,new JHandler[]{},M380));
c.Add(new JMethod(381,"forge/card/CardEdition","getFoilChanceInBooster","()D",1,1,2,new JHandler[]{},M381));
c.Add(new JMethod(382,"forge/card/CardEdition","getFoilAlwaysInCommonSlot","()Z",1,1,1,new JHandler[]{},M382));
c.Add(new JMethod(383,"forge/card/CardEdition","getChanceReplaceCommonWith","()D",1,1,2,new JHandler[]{},M383));
c.Add(new JMethod(384,"forge/card/CardEdition","getSlotReplaceCommonWith","()Ljava/lang/String;",1,1,1,new JHandler[]{},M384));
c.Add(new JMethod(385,"forge/card/CardEdition","getAdditionalSheetForFoils","()Ljava/lang/String;",1,1,1,new JHandler[]{},M385));
c.Add(new JMethod(386,"forge/card/CardEdition","getAdditionalUnlockSet","()Ljava/lang/String;",1,1,1,new JHandler[]{},M386));
c.Add(new JMethod(387,"forge/card/CardEdition","getBoosterMustContain","()Ljava/lang/String;",1,1,1,new JHandler[]{},M387));
c.Add(new JMethod(388,"forge/card/CardEdition","getBoosterReplaceSlotFromPrintSheet","()Ljava/lang/String;",1,1,1,new JHandler[]{},M388));
c.Add(new JMethod(389,"forge/card/CardEdition","getSheetReplaceCardFromSheet","()Ljava/lang/String;",1,1,1,new JHandler[]{},M389));
c.Add(new JMethod(390,"forge/card/CardEdition","getSheetReplaceCardFromSheet2","()Ljava/lang/String;",1,1,1,new JHandler[]{},M390));
c.Add(new JMethod(391,"forge/card/CardEdition","getChaosDraftThemes","()[Ljava/lang/String;",1,1,1,new JHandler[]{},M391));
c.Add(new JMethod(392,"forge/card/CardEdition","getDraftType","()Lforge/card/CardEdition$DraftType;",1,1,1,new JHandler[]{},M392));
c.Add(new JMethod(393,"forge/card/CardEdition","getCards","()Ljava/util/List;",1,1,2,new JHandler[]{},M393));
c.Add(new JMethod(394,"forge/card/CardEdition","getRebalancedCards","()Ljava/util/List;",1,1,2,new JHandler[]{},M394));
c.Add(new JMethod(395,"forge/card/CardEdition","getFunnyEternalCards","()Ljava/util/List;",1,1,2,new JHandler[]{},M395));
c.Add(new JMethod(396,"forge/card/CardEdition","getObtainableCards","()Ljava/util/List;",1,3,3,new JHandler[]{},M396));
c.Add(new JMethod(397,"forge/card/CardEdition","getAllCardsInSet","()Ljava/util/List;",1,1,1,new JHandler[]{},M397));
c.Add(new JMethod(398,"forge/card/CardEdition","getCardInSet","(Ljava/lang/String;)Ljava/util/List;",1,2,2,new JHandler[]{},M398));
c.Add(new JMethod(399,"forge/card/CardEdition","getCardFromCollectorNumber","(Ljava/lang/String;)Lforge/card/CardEdition$EditionEntry;",1,4,2,new JHandler[]{},M399));
c.Add(new JMethod(400,"forge/card/CardEdition","getSectionForCollectorNumber","(Ljava/lang/String;)Ljava/lang/String;",1,6,2,new JHandler[]{},M400));
c.Add(new JMethod(401,"forge/card/CardEdition","isRebalanced","(Ljava/lang/String;)Z",1,4,2,new JHandler[]{},M401));
c.Add(new JMethod(402,"forge/card/CardEdition","isCardObtainable","(Ljava/lang/String;)Z",1,4,2,new JHandler[]{},M402));
c.Add(new JMethod(403,"forge/card/CardEdition","isModern","()Z",1,1,2,new JHandler[]{},M403));
c.Add(new JMethod(404,"forge/card/CardEdition","isTraditionalFrame","(Ljava/lang/String;)Z",1,5,3,new JHandler[]{},M404));
c.Add(new JMethod(405,"forge/card/CardEdition","getTokens","()Lcom/google/common/collect/Multimap;",1,1,1,new JHandler[]{},M405));
c.Add(new JMethod(406,"forge/card/CardEdition","getTokenSet","(Ljava/lang/String;)Ljava/lang/String;",1,2,2,new JHandler[]{},M406));
c.Add(new JMethod(407,"forge/card/CardEdition","getOtherSet","(Ljava/lang/String;)Ljava/lang/String;",1,2,2,new JHandler[]{},M407));
c.Add(new JMethod(408,"forge/card/CardEdition","findOther","(Ljava/lang/String;)Lforge/card/CardEdition$EditionEntry;",1,2,2,new JHandler[]{},M408));
c.Add(new JMethod(409,"forge/card/CardEdition","compareTo","(Lforge/card/CardEdition;)I",1,3,2,new JHandler[]{},M409));
c.Add(new JMethod(410,"forge/card/CardEdition","hashCode","()I",1,1,2,new JHandler[]{},M410));
c.Add(new JMethod(411,"forge/card/CardEdition","equals","(Ljava/lang/Object;)Z",1,3,2,new JHandler[]{},M411));
c.Add(new JMethod(412,"forge/card/CardEdition","toString","()Ljava/lang/String;",1,1,2,new JHandler[]{},M412));
c.Add(new JMethod(413,"forge/card/CardEdition","getBorderColor","()Lforge/card/CardEdition$BorderColor;",1,1,1,new JHandler[]{},M413));
c.Add(new JMethod(414,"forge/card/CardEdition","isLargeSet","()Z",1,1,2,new JHandler[]{},M414));
c.Add(new JMethod(415,"forge/card/CardEdition","getCntBoosterPictures","()I",1,1,1,new JHandler[]{},M415));
c.Add(new JMethod(416,"forge/card/CardEdition","getBoosterTemplate","()Lforge/item/SealedTemplate;",1,1,2,new JHandler[]{},M416));
c.Add(new JMethod(417,"forge/card/CardEdition","getBoosterTemplate","(Ljava/lang/String;)Lforge/item/SealedTemplate;",1,2,2,new JHandler[]{},M417));
c.Add(new JMethod(418,"forge/card/CardEdition","getRandomBoosterKind","()Ljava/lang/String;",1,1,1,new JHandler[]{},M418));
c.Add(new JMethod(419,"forge/card/CardEdition","getAvailableBoosterTypes","()Ljava/util/Set;",1,1,1,new JHandler[]{},M419));
c.Add(new JMethod(420,"forge/card/CardEdition","hasBoosterTemplate","()Z",1,1,2,new JHandler[]{},M420));
c.Add(new JMethod(421,"forge/card/CardEdition","getPrintSheetsBySection","()Ljava/util/List;",1,8,7,new JHandler[]{},M421));
c.Add(new JMethod(422,"forge/card/CardEdition","getRandomFoil","(Ljava/lang/String;)I",9,2,2,new JHandler[]{},M422));
c.Add(new JMethod(423,"forge/card/CardEdition","hasBasicLands","()Z",1,3,2,new JHandler[]{},M423));
c.Add(new JMethod(424,"forge/card/CardEdition","compareTo","(Ljava/lang/Object;)I",4161,2,2,new JHandler[]{},M424));
c.Add(new JMethod(425,"forge/card/CardEdition","lambda$new$1","(Lforge/card/CardEdition$EditionEntry;)Lforge/card/CardEdition$EditionEntry;",4106,1,1,new JHandler[]{},M425));
c.Add(new JMethod(426,"forge/card/CardEdition","lambda$new$0","(Lforge/card/CardEdition$EditionEntry;)Ljava/lang/String;",4106,1,1,new JHandler[]{},M426));
c.Add(new JMethod(427,"forge/card/CardEdition","<clinit>","()V",8,0,8,new JHandler[]{},M427));
}

internal static JStep M362(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","draftOptions","Lforge/card/DraftOptions;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M363(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference==null?13:6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?16:13;continue;}
case 13:{f.Push(JValue.R(rt.String("50000")));f.Pc=15;continue;}
case 15:{f.Locals[1]=f.Pop();f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/card/CardEdition","sortableCollNumberLookup","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition","sortableCollNumberLookup","Ljava/util/Map;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(null));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{f.Locals[2]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Pc=f.Pop().Reference==null?36:34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return JStep.Return(f.Pop());}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",40);}
case 40:{f.Locals[3]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("%05d")));f.Pc=43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=47;continue;}
case 47:{f.StackOp("dup");f.Pc=48;continue;}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",53);}
case 53:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",57);}
case 57:{f.Locals[4]=f.Pop();f.Pc=59;continue;}
case 59:{f.Pc=163;continue;}
case 62:{f.Locals[5]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("[0-9]")));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",72);}
case 72:{f.Locals[6]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("[^0-9]")));f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",82);}
case 82:{f.Locals[7]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[7]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",89);}
case 89:{f.Locals[3]=f.Pop();f.Pc=90;continue;}
case 90:{f.Pc=97;continue;}
case 93:{f.Locals[8]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(JValue.I(0));f.Pc=96;continue;}
case 96:{f.Locals[3]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{f.Pc=f.Pop().Int<=0?138:101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[7]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int==0?138:110;continue;}
case 110:{f.Push(JValue.R(rt.String("%05d")));f.Pc=112;continue;}
case 112:{f.Push(JValue.I(1));f.Pc=113;continue;}
case 113:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=116;continue;}
case 116:{f.StackOp("dup");f.Pc=117;continue;}
case 117:{f.Push(JValue.I(0));f.Pc=118;continue;}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",122);}
case 122:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",126);}
case 126:{f.Push(f.Locals[6]);f.Pc=128;continue;}
case 128:{return rt.DynamicCall(f,"forge/card/CardEdition:363:128:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",133);}
case 133:{f.Locals[4]=f.Pop();f.Pc=135;continue;}
case 135:{f.Pc=163;continue;}
case 138:{f.Push(f.Locals[6]);f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.String("%05d")));f.Pc=142;continue;}
case 142:{f.Push(JValue.I(1));f.Pc=143;continue;}
case 143:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=146;continue;}
case 146:{f.StackOp("dup");f.Pc=147;continue;}
case 147:{f.Push(JValue.I(0));f.Pc=148;continue;}
case 148:{f.Push(f.Locals[3]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",152);}
case 152:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",156);}
case 156:{return rt.DynamicCall(f,"forge/card/CardEdition:363:156:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",161);}
case 161:{f.Locals[4]=f.Pop();f.Pc=163;continue;}
case 163:{if(!rt.StaticReady(f,"forge/card/CardEdition","sortableCollNumberLookup","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition","sortableCollNumberLookup","Ljava/util/Map;"));f.Pc=166;continue;}
case 166:{f.Push(f.Locals[1]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[4]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",174);}
case 174:{f.StackOp("pop");f.Pc=175;continue;}
case 175:{f.Push(f.Locals[4]);f.Pc=177;continue;}
case 177:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M364(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","alias","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"));f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","borderColor","Lforge/card/CardEdition$BorderColor;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(null));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","prerelease","Ljava/lang/String;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("")));f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","fatPackExtraSlots","Ljava/lang/String;",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(null));f.Pc=29;continue;}
case 29:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","boosterSlots","Ljava/util/List;",value);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","smallSetOverride","Z",value);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("")));f.Pc=40;continue;}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","additionalUnlockSet","Ljava/lang/String;",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/card/CardEdition$FoilType","NOT_SUPPORTED","Lforge/card/CardEdition$FoilType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$FoilType","NOT_SUPPORTED","Lforge/card/CardEdition$FoilType;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","foilType","Lforge/card/CardEdition$FoilType;",value);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","foilAlwaysInCommonSlot","Z",value);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(JValue.D(0));f.Pc=57;continue;}
case 57:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","foilChanceInBooster","D",value);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.D(0));f.Pc=62;continue;}
case 62:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","chanceReplaceCommonWith","D",value);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("Common")));f.Pc=68;continue;}
case 68:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","slotReplaceCommonWith","Ljava/lang/String;",value);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("")));f.Pc=74;continue;}
case 74:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","additionalSheetForFoils","Ljava/lang/String;",value);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("")));f.Pc=80;continue;}
case 80:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","boosterMustContain","Ljava/lang/String;",value);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("")));f.Pc=86;continue;}
case 86:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","boosterReplaceSlotFromPrintSheet","Ljava/lang/String;",value);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("")));f.Pc=92;continue;}
case 92:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","sheetReplaceCardFromSheet","Ljava/lang/String;",value);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("")));f.Pc=98;continue;}
case 98:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","sheetReplaceCardFromSheet2","Ljava/lang/String;",value);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(null));f.Pc=103;continue;}
case 103:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","draftOptions","Lforge/card/DraftOptions;",value);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/card/CardEdition$DraftType","Normal","Lforge/card/CardEdition$DraftType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$DraftType","Normal","Lforge/card/CardEdition$DraftType;"));f.Pc=110;continue;}
case 110:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","draftType","Lforge/card/CardEdition$DraftType;",value);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(JValue.I(0));f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=118;continue;}
case 118:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","chaosDraftThemes","[Ljava/lang/String;",value);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",125);}
case 125:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","otherMap","Lcom/google/common/collect/ListMultimap;",value);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[0]);f.Pc=129;continue;}
case 129:{f.Push(JValue.I(1));f.Pc=130;continue;}
case 130:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","boosterArts","I",value);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{f.Push(JValue.R(null));f.Pc=135;continue;}
case 135:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","boosterTpl","Lforge/item/SealedTemplate;",value);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=142;continue;}
case 142:{f.StackOp("dup");f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",146);}
case 146:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","boosterTemplates","Ljava/util/Map;",value);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[1]);f.Pc=151;continue;}
case 151:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","cardMap","Lcom/google/common/collect/ListMultimap;",value);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=158;continue;}
case 158:{f.StackOp("dup");f.Pc=159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"com/google/common/collect/ListMultimap","values","()Ljava/util/Collection;","invokeinterface",165);}
case 165:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",168);}
case 168:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","cardsInSet","Ljava/util/List;",value);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[0]);f.Pc=172;continue;}
case 172:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","cardsInSet","Ljava/util/List;"));f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/Collections","sort","(Ljava/util/List;)V","invokestatic",178);}
case 178:{f.Push(f.Locals[0]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[0]);f.Pc=180;continue;}
case 180:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","cardsInSet","Ljava/util/List;"));f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",188);}
case 188:{return rt.DynamicCall(f,"forge/card/CardEdition:364:188:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",193);}
case 193:{return rt.DynamicCall(f,"forge/card/CardEdition:364:193:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",198);}
case 198:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=201;continue;}
case 201:{return rt.Call(f,"com/google/common/collect/MultimapBuilder","treeKeys","(Ljava/util/Comparator;)Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys;","invokestatic",204);}
case 204:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys","arrayListValues","()Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder;","invokevirtual",207);}
case 207:{f.StackOp("dup");f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",211);}
case 211:{f.StackOp("pop");f.Pc=212;continue;}
case 212:{return rt.DynamicCall(f,"forge/card/CardEdition:364:212:java/lang/invoke/LambdaMetafactory.metafactory","(Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder;)Ljava/util/function/Supplier;",217);}
case 217:{return rt.Call(f,"com/google/common/collect/Multimaps","toMultimap","(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/Supplier;)Ljava/util/stream/Collector;","invokestatic",220);}
case 220:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",225);}
case 225:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/ListMultimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=228;continue;}
case 228:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","cardsInSetLookupMap","Lcom/google/common/collect/ListMultimap;",value);f.Pc=231;continue;}
case 231:{f.Push(f.Locals[0]);f.Pc=232;continue;}
case 232:{f.Push(f.Locals[2]);f.Pc=233;continue;}
case 233:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","tokenMap","Lcom/google/common/collect/ListMultimap;",value);f.Pc=236;continue;}
case 236:{f.Push(f.Locals[0]);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[3]);f.Pc=238;continue;}
case 238:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","customPrintSheetsToParse","Ljava/util/Map;",value);f.Pc=241;continue;}
case 241:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M365(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",4);}
case 4:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",7);}
case 7:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",14);}
case 14:{return rt.Call(f,"forge/card/CardEdition","<init>","(Lcom/google/common/collect/ListMultimap;Lcom/google/common/collect/ListMultimap;Ljava/util/Map;)V","invokespecial",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","code","Ljava/lang/String;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","code2","Ljava/lang/String;",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","type","Lforge/card/CardEdition$Type;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[5]);f.Pc=36;continue;}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","name","Ljava/lang/String;",value);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/card/CardEdition","parseDate","(Ljava/lang/String;)Ljava/util/Date;","invokestatic",44);}
case 44:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","date","Ljava/util/Date;",value);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","foilType","Lforge/card/CardEdition$FoilType;",value);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","scryfallCode","Ljava/lang/String;",value);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{return rt.DynamicCall(f,"forge/card/CardEdition:365:60:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",65);}
case 65:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","tokensCode","Ljava/lang/String;",value);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("en")));f.Pc=72;continue;}
case 72:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","cardsLanguage","Ljava/lang/String;",value);f.Pc=75;continue;}
case 75:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M366(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",4);}
case 4:{f.Push(JValue.I(7));f.Pc=6;continue;}
case 6:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?16:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.DynamicCall(f,"forge/card/CardEdition:366:10:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",15);}
case 15:{f.Locals[0]=f.Pop();f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/card/CardEdition","formatter","Ljava/text/SimpleDateFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition","formatter","Ljava/text/SimpleDateFormat;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/text/SimpleDateFormat","parse","(Ljava/lang/String;)Ljava/util/Date;","invokevirtual",23);}
case 23:{return JStep.Return(f.Pop());}
case 24:{f.Locals[1]=f.Pop();f.Pc=25;continue;}
case 25:{if(!rt.EnsureInitialized(f,"java/util/Date"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Date")));f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Date","<init>","()V","invokespecial",32);}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M367(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","date","Ljava/util/Date;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M368(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","code","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M369(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","code2","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M370(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","scryfallCode","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M371(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","tokensCode","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M372(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","cardsLanguage","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M373(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","type","Lforge/card/CardEdition$Type;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M374(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M375(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","alias","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M376(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","prerelease","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M377(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","boosterBoxCount","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M378(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","fatPackCount","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M379(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","fatPackExtraSlots","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M380(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","foilType","Lforge/card/CardEdition$FoilType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M381(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","foilChanceInBooster","D"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M382(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","foilAlwaysInCommonSlot","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M383(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","chanceReplaceCommonWith","D"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M384(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","slotReplaceCommonWith","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M385(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","additionalSheetForFoils","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M386(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","additionalUnlockSet","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M387(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","boosterMustContain","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M388(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","boosterReplaceSlotFromPrintSheet","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M389(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","sheetReplaceCardFromSheet","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M390(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","sheetReplaceCardFromSheet2","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M391(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","chaosDraftThemes","[Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M392(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","draftType","Lforge/card/CardEdition$DraftType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M393(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","cardMap","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","CARDS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","CARDS","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","getName","()Ljava/lang/String;","invokevirtual",10);}
case 10:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M394(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","cardMap","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","REBALANCED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","REBALANCED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","getName","()Ljava/lang/String;","invokevirtual",10);}
case 10:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M395(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","cardMap","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","ETERNAL","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","ETERNAL","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","getName","()Ljava/lang/String;","invokevirtual",10);}
case 10:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M396(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardEdition","getAllCardsInSet","()Ljava/util/List;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","cardMap","Lcom/google/common/collect/ListMultimap;"));f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","CONJURED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","CONJURED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","getName","()Ljava/lang/String;","invokevirtual",22);}
case 22:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",27);}
case 27:{f.Locals[2]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Pc=f.Pop().Reference==null?40:32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/List","removeAll","(Ljava/util/Collection;)Z","invokeinterface",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M397(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","cardsInSet","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M398(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","cardsInSetLookupMap","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M399(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?11:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?13:11;continue;}
case 11:{f.Push(JValue.R(null));f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","cardsInSet","Ljava/util/List;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?58:32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","collectorNumber","Ljava/lang/String;"));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?55:53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{return JStep.Return(f.Pop());}
case 55:{f.Pc=23;continue;}
case 58:{f.Push(JValue.R(null));f.Pc=59;continue;}
case 59:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M400(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?11:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?13:11;continue;}
case 11:{f.Push(JValue.R(null));f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","cardMap","Lcom/google/common/collect/ListMultimap;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"com/google/common/collect/ListMultimap","asMap","()Ljava/util/Map;","invokeinterface",22);}
case 22:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",27);}
case 27:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",32);}
case 32:{f.Locals[2]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",39);}
case 39:{f.Pc=f.Pop().Int==0?118:42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Locals[3]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",66);}
case 66:{f.Locals[4]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",75);}
case 75:{f.Pc=f.Pop().Int==0?115:78;continue;}
case 78:{f.Push(f.Locals[4]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",85);}
case 85:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=88;continue;}
case 88:{f.Locals[5]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[5]);f.Pc=93;continue;}
case 93:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","collectorNumber","Ljava/lang/String;"));f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int==0?112:102;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",108);}
case 108:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=111;continue;}
case 111:{return JStep.Return(f.Pop());}
case 112:{f.Pc=68;continue;}
case 115:{f.Pc=33;continue;}
case 118:{f.Push(JValue.R(null));f.Pc=119;continue;}
case 119:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M401(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardEdition","getRebalancedCards","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?45:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","name","Ljava/lang/String;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?42:40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 42:{f.Pc=10;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M402(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","cardMap","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","CONJURED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","CONJURED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","getName","()Ljava/lang/String;","invokevirtual",10);}
case 10:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",15);}
case 15:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?56:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[3]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","name","Ljava/lang/String;"));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?53:51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 53:{f.Pc=21;continue;}
case 56:{f.Push(JValue.I(1));f.Pc=57;continue;}
case 57:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M403(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("2003-07-27")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardEdition","parseDate","(Ljava/lang/String;)Ljava/util/Date;","invokestatic",10);}
case 10:{return rt.Call(f,"java/util/Date","after","(Ljava/util/Date;)Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M404(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?11:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?13:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","traditionalCollectorNumbers","Ljava/util/Set;"));f.Pc=17;continue;}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Reference!=null?94:22;continue;}
case 22:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",29);}
case 29:{f.Locals[2]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/card/CardEdition","getCards","()Ljava/util/List;","invokevirtual",34);}
case 34:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",39);}
case 39:{f.Locals[3]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",46);}
case 46:{f.Pc=f.Pop().Int==0?89:49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",55);}
case 55:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=58;continue;}
case 58:{f.Locals[4]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","collectorNumber","()Ljava/lang/String;","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Reference==null?86:68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","collectorNumber","()Ljava/lang/String;","invokevirtual",74);}
case 74:{if(!rt.StaticReady(f,"java/util/Locale","ROOT","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ROOT","Ljava/util/Locale;"));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/String","toLowerCase","(Ljava/util/Locale;)Ljava/lang/String;","invokevirtual",80);}
case 80:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",85);}
case 85:{f.StackOp("pop");f.Pc=86;continue;}
case 86:{f.Pc=40;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition","traditionalCollectorNumbers","Ljava/util/Set;",value);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"java/util/Locale","ROOT","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ROOT","Ljava/util/Locale;"));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/String","toLowerCase","(Ljava/util/Locale;)Ljava/lang/String;","invokevirtual",102);}
case 102:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",107);}
case 107:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M405(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","tokenMap","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M406(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","tokenMap","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/ListMultimap","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?18:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",17);}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","tokenFallbackCode","Ljava/lang/String;"));f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Reference==null?40:25;continue;}
case 25:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","tokenFallbackCode","Ljava/lang/String;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",35);}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/card/CardEdition","getTokenSet","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",39);}
case 39:{return JStep.Return(f.Pop());}
case 40:{f.Push(JValue.R(null));f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M407(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","otherMap","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/ListMultimap","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?18:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",17);}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","tokenFallbackCode","Ljava/lang/String;"));f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Reference==null?40:25;continue;}
case 25:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","tokenFallbackCode","Ljava/lang/String;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",35);}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/card/CardEdition","getOtherSet","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",39);}
case 39:{return JStep.Return(f.Pop());}
case 40:{f.Push(JValue.R(null));f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M408(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","otherMap","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/ListMultimap","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?30:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","otherMap","Lcom/google/common/collect/ListMultimap;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",23);}
case 23:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
case 30:{f.Push(JValue.R(null));f.Pc=31;continue;}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M409(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","date","Ljava/util/Date;"));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","date","Ljava/util/Date;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Date","compareTo","(Ljava/util/Date;)I","invokevirtual",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?25:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","name","Ljava/lang/String;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","name","Ljava/lang/String;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/String","compareTo","(Ljava/lang/String;)I","invokevirtual",36);}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M410(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","code","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",7);}
case 7:{f.Push(JValue.I(17));f.Pc=9;continue;}
case 9:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","name","Ljava/lang/String;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",17);}
case 17:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M411(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?7:5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference!=null?13:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",17);}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",21);}
case 21:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?26:24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","name","Ljava/lang/String;"));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","name","Ljava/lang/String;"));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?63:45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","code","Ljava/lang/String;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","code","Ljava/lang/String;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?63:59;continue;}
case 59:{f.Push(JValue.I(1));f.Pc=60;continue;}
case 60:{f.Pc=64;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M412(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","code","Ljava/lang/String;"));f.Pc=8;continue;}
case 8:{return rt.DynamicCall(f,"forge/card/CardEdition:412:8:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M413(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","borderColor","Lforge/card/CardEdition$BorderColor;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M414(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","cardsInSet","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",9);}
case 9:{f.Push(JValue.I(200));f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?26:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","smallSetOverride","Z"));f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Int!=0?26:22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{f.Pc=27;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M415(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","boosterArts","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M416(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Draft")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardEdition","getBoosterTemplate","(Ljava/lang/String;)Lforge/item/SealedTemplate;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M417(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","boosterTemplates","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/SealedTemplate"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M418(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","boosterTemplates","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",12);}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M419(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","boosterTemplates","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M420(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","boosterTemplates","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Draft")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M421(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",6);}
case 6:{f.Locals[1]=f.Pop();f.Pc=7;continue;}
case 7:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","cardMap","Lcom/google/common/collect/ListMultimap;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"com/google/common/collect/ListMultimap","asMap","()Ljava/util/Map;","invokeinterface",20);}
case 20:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",25);}
case 25:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?189:40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[4]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{if(!rt.StaticReady(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","CONJURED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$EditionSectionWithCollectorNumbers","CONJURED","Lforge/card/CardEdition$EditionSectionWithCollectorNumbers;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/card/CardEdition$EditionSectionWithCollectorNumbers","getName","()Ljava/lang/String;","invokevirtual",67);}
case 67:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int==0?76:73;continue;}
case 73:{f.Pc=31;continue;}
case 76:{if(!rt.EnsureInitialized(f,"forge/card/PrintSheet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/PrintSheet")));f.Pc=79;continue;}
case 79:{f.StackOp("dup");f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("%s %s")));f.Pc=83;continue;}
case 83:{f.Push(JValue.I(2));f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=87;continue;}
case 87:{f.StackOp("dup");f.Pc=88;continue;}
case 88:{f.Push(JValue.I(0));f.Pc=89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",93);}
case 93:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=94;continue;}
case 94:{f.StackOp("dup");f.Pc=95;continue;}
case 95:{f.Push(JValue.I(1));f.Pc=96;continue;}
case 96:{f.Push(f.Locals[4]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",103);}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",107);}
case 107:{return rt.Call(f,"forge/card/PrintSheet","<init>","(Ljava/lang/String;)V","invokespecial",110);}
case 110:{f.Locals[5]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[4]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",119);}
case 119:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",127);}
case 127:{f.Locals[6]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[6]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",136);}
case 136:{f.Pc=f.Pop().Int==0?177:139;continue;}
case 139:{f.Push(f.Locals[6]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",146);}
case 146:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=149;continue;}
case 149:{f.Locals[7]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[5]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[7]);f.Pc=156;continue;}
case 156:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","name","Ljava/lang/String;"));f.Pc=159;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",163);}
case 163:{f.Push(f.Locals[7]);f.Pc=165;continue;}
case 165:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","collectorNumber","Ljava/lang/String;"));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",171);}
case 171:{return rt.Call(f,"forge/card/PrintSheet","add","(Lforge/item/PaperCard;)V","invokevirtual",174);}
case 174:{f.Pc=129;continue;}
case 177:{f.Push(f.Locals[2]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[5]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",185);}
case 185:{f.StackOp("pop");f.Pc=186;continue;}
case 186:{f.Pc=31;continue;}
case 189:{f.Push(f.Locals[0]);f.Pc=190;continue;}
case 190:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","customPrintSheetsToParse","Ljava/util/Map;"));f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",198);}
case 198:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",203);}
case 203:{f.Locals[3]=f.Pop();f.Pc=204;continue;}
case 204:{f.Push(f.Locals[3]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",210);}
case 210:{f.Pc=f.Pop().Int==0?292:213;continue;}
case 213:{f.Push(f.Locals[3]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",219);}
case 219:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=222;continue;}
case 222:{f.Locals[4]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(f.Locals[0]);f.Pc=225;continue;}
case 225:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition","customPrintSheetsToParse","Ljava/util/Map;"));f.Pc=228;continue;}
case 228:{f.Push(f.Locals[4]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",235);}
case 235:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=238;continue;}
case 238:{f.Locals[5]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(f.Locals[5]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/deck/CardPool","fromCardList","(Ljava/lang/Iterable;)Lforge/deck/CardPool;","invokestatic",245);}
case 245:{f.Locals[6]=f.Pop();f.Pc=247;continue;}
case 247:{if(!rt.EnsureInitialized(f,"forge/card/PrintSheet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/PrintSheet")));f.Pc=250;continue;}
case 250:{f.StackOp("dup");f.Pc=251;continue;}
case 251:{f.Push(JValue.R(rt.String("%s %s")));f.Pc=254;continue;}
case 254:{f.Push(JValue.I(2));f.Pc=255;continue;}
case 255:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=258;continue;}
case 258:{f.StackOp("dup");f.Pc=259;continue;}
case 259:{f.Push(JValue.I(0));f.Pc=260;continue;}
case 260:{f.Push(f.Locals[0]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",264);}
case 264:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=265;continue;}
case 265:{f.StackOp("dup");f.Pc=266;continue;}
case 266:{f.Push(JValue.I(1));f.Pc=267;continue;}
case 267:{f.Push(f.Locals[4]);f.Pc=269;continue;}
case 269:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",273);}
case 273:{f.Push(f.Locals[6]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/card/PrintSheet","<init>","(Ljava/lang/String;Lforge/util/ItemPool;)V","invokespecial",278);}
case 278:{f.Locals[7]=f.Pop();f.Pc=280;continue;}
case 280:{f.Push(f.Locals[2]);f.Pc=281;continue;}
case 281:{f.Push(f.Locals[7]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",288);}
case 288:{f.StackOp("pop");f.Pc=289;continue;}
case 289:{f.Pc=204;continue;}
case 292:{f.Push(f.Locals[2]);f.Pc=293;continue;}
case 293:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M422(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardEdition$FoilType","NOT_SUPPORTED","Lforge/card/CardEdition$FoilType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$FoilType","NOT_SUPPORTED","Lforge/card/CardEdition$FoilType;"));f.Pc=3;continue;}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference==null?35:8;continue;}
case 8:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Reference==null?35:21;continue;}
case 21:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",24);}
case 24:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/card/CardEdition","getFoilType","()Lforge/card/CardEdition$FoilType;","invokevirtual",34);}
case 34:{f.Locals[1]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{if(!rt.StaticReady(f,"forge/card/CardEdition$FoilType","NOT_SUPPORTED","Lforge/card/CardEdition$FoilType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$FoilType","NOT_SUPPORTED","Lforge/card/CardEdition$FoilType;"));f.Pc=39;continue;}
case 39:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?74:42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/card/CardEdition$FoilType","MODERN","Lforge/card/CardEdition$FoilType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$FoilType","MODERN","Lforge/card/CardEdition$FoilType;"));f.Pc=46;continue;}
case 46:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?62:49;continue;}
case 49:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",52);}
case 52:{f.Push(JValue.I(9));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",57);}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=59;continue;}
case 59:{f.Pc=73;continue;}
case 62:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",65);}
case 65:{f.Push(JValue.I(9));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",70);}
case 70:{f.Push(JValue.I(11));f.Pc=72;continue;}
case 72:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=73;continue;}
case 73:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 74:{f.Push(JValue.I(0));f.Pc=75;continue;}
case 75:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M423(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"com/google/common/collect/ImmutableList","iterator","()Lcom/google/common/collect/UnmodifiableIterator;","invokevirtual",6);}
case 6:{f.Locals[1]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?44:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/card/CardEdition","getCardInSet","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",31);}
case 31:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",36);}
case 36:{f.Pc=f.Pop().Int==0?41:39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 41:{f.Pc=7;continue;}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M424(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardEdition","compareTo","(Lforge/card/CardEdition;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M425(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M426(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M427(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("metadata")));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("tokens")));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("other")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"com/google/common/collect/ImmutableList","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList;","invokestatic",12);}
case 12:{if(!rt.StaticReady(f,"forge/card/CardEdition","reservedSectionNames","Ljava/util/List;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition","reservedSectionNames","Ljava/util/List;",f.Pop());f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",22);}
case 22:{if(!rt.StaticReady(f,"forge/card/CardEdition","sortableCollNumberLookup","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition","sortableCollNumberLookup","Ljava/util/Map;",f.Pop());f.Pc=25;continue;}
case 25:{if(!rt.EnsureInitialized(f,"java/text/SimpleDateFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/text/SimpleDateFormat")));f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("yyyy-MM-dd")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/text/SimpleDateFormat","<init>","(Ljava/lang/String;)V","invokespecial",35);}
case 35:{if(!rt.StaticReady(f,"forge/card/CardEdition","formatter","Ljava/text/SimpleDateFormat;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition","formatter","Ljava/text/SimpleDateFormat;",f.Pop());f.Pc=38;continue;}
case 38:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition")));f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("1990-01-01")));f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("???")));f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("??")));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","UNKNOWN","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","UNKNOWN","Lforge/card/CardEdition$Type;"));f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("UNKNOWN")));f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"forge/card/CardEdition$FoilType","NOT_SUPPORTED","Lforge/card/CardEdition$FoilType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$FoilType","NOT_SUPPORTED","Lforge/card/CardEdition$FoilType;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/card/CardEdition","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/card/CardEdition$Type;Ljava/lang/String;Lforge/card/CardEdition$FoilType;)V","invokespecial",63);}
case 63:{if(!rt.StaticReady(f,"forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;",f.Pop());f.Pc=66;continue;}
case 66:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
