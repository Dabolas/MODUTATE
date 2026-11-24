// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C97{
internal static JClass Build(){var c=new JClass("forge/deck/DeckRecognizer","java/lang/Object",new string[]{},33);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("PORTABLE_PATTERN_GROUPS","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("SEARCH_SINGLE_SLASH","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("DOUBLE_SLASH","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"//"));
c.Add(new JField("LINE_COMMENT_DELIMITER_OR_MD_HEADER","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"#"));
c.Add(new JField("ASTERISK","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"* "));
c.Add(new JField("REGRP_DECKNAME","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"deckName"));
c.Add(new JField("REX_DECK_NAME","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("DECK_NAME_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("REGRP_TOKEN","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"token"));
c.Add(new JField("REGRP_COLR1","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"colr1"));
c.Add(new JField("REGRP_COLR2","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"colr2"));
c.Add(new JField("REGRP_MANA","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"mana"));
c.Add(new JField("REX_NOCARD","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("REX_CMC","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("REX_RARITY","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("MANA_SYMBOLS","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"w|u|b|r|g|c|m|wu|ub|br|rg|gw|wb|ur|bg|rw|gu"));
c.Add(new JField("REX_MANA_SYMBOLS","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("REX_MANA_COLOURS","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("REX_MANA","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("NONCARD_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("CMC_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("CARD_RARITY_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("MANA_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("MANA_SYMBOL_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("REGRP_SET","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"setcode"));
c.Add(new JField("REGRP_COLLNR","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"collnr"));
c.Add(new JField("REGRP_CARD","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"cardname"));
c.Add(new JField("REGRP_CARDNO","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"count"));
c.Add(new JField("REX_CARD_NAME","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("REX_SET_CODE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("REX_COLLNR_SEGMENT","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"(?:[0-9A-Za-z]*[0-9][0-9A-Za-z]*|[0-9A-Z]+[a-z]?)"));
c.Add(new JField("REX_COLL_NUMBER","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("REX_CARD_COUNT","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("REGRP_FOIL_GFISH","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"foil"));
c.Add(new JField("REX_FOIL_MTGGOLDFISH","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("REGRP_DECK_SEC_XMAGE_STYLE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"decsec"));
c.Add(new JField("REX_DECKSEC_XMAGE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("REX_CARD_SET_REQUEST","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("CARD_SET_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("REX_SET_CARD_REQUEST","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("SET_CARD_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("REX_FULL_REQUEST_CARD_SET","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("CARD_SET_COLLNO_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("REX_FULL_REQUEST_SET_CARD","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("SET_CARD_COLLNO_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("REX_FULL_REQUEST_CARD_COLLNO_SET","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("CARD_COLLNO_SET_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("REX_FULL_REQUEST_XMAGE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("SET_COLLNO_CARD_XMAGE_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("REX_CARDONLY","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("CARD_ONLY_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("CARD_TYPES","[Ljava/lang/CharSequence;",true,JValue.Default("[Ljava/lang/CharSequence;"),null));
c.Add(new JField("DECK_SECTION_NAMES","[Ljava/lang/CharSequence;",true,JValue.Default("[Ljava/lang/CharSequence;"),null));
c.Add(new JField("releaseDateConstraint","Ljava/util/Date;",false,JValue.Default("Ljava/util/Date;"),null));
c.Add(new JField("allowedSetCodes","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("gameFormatBannedCards","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("gameFormatRestrictedCards","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("allowedDeckSections","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("includeBannedAndRestricted","Z",false,JValue.Default("Z"),null));
c.Add(new JField("deckFormat","Lforge/deck/DeckFormat;",false,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("artPreference","Lforge/card/CardDb$CardArtPreference;",false,JValue.Default("Lforge/card/CardDb$CardArtPreference;"),null));
c.Add(new JMethod(1516,"forge/deck/DeckRecognizer","<init>","()V",1,1,2,new JHandler[]{},M1516));
c.Add(new JMethod(1517,"forge/deck/DeckRecognizer","compilePattern","(Ljava/lang/String;I)Ljava/util/regex/Pattern;",10,3,2,new JHandler[]{new JHandler(0,5,6,"java/util/regex/PatternSyntaxException")},M1517));
c.Add(new JMethod(1518,"forge/deck/DeckRecognizer","compilePortablePattern","(Ljava/lang/String;I)Ljava/util/regex/Pattern;",8,4,3,new JHandler[]{},M1518));
}

private static void Add1(JClass c){
c.Add(new JMethod(1519,"forge/deck/DeckRecognizer","makePortablePattern","(Ljava/lang/String;)Lforge/deck/DeckRecognizer$PortablePattern;",10,10,5,new JHandler[]{},M1519));
c.Add(new JMethod(1520,"forge/deck/DeckRecognizer","allCardTypes","()[Ljava/lang/CharSequence;",10,4,2,new JHandler[]{},M1520));
c.Add(new JMethod(1521,"forge/deck/DeckRecognizer","parseCardList","([Ljava/lang/String;)Ljava/util/List;",1,13,3,new JHandler[]{},M1521));
c.Add(new JMethod(1522,"forge/deck/DeckRecognizer","isAllowed","(Lforge/deck/DeckSection;)Z",2,2,2,new JHandler[]{},M1522));
c.Add(new JMethod(1523,"forge/deck/DeckRecognizer","recognizeLine","(Ljava/lang/String;Lforge/deck/DeckSection;)Lforge/deck/DeckRecognizer$Token;",1,7,5,new JHandler[]{},M1523));
c.Add(new JMethod(1524,"forge/deck/DeckRecognizer","purgeAllLinks","(Ljava/lang/String;)Ljava/lang/String;",9,4,4,new JHandler[]{},M1524));
c.Add(new JMethod(1525,"forge/deck/DeckRecognizer","recogniseCardToken","(Ljava/lang/String;Lforge/deck/DeckSection;)Lforge/deck/DeckRecognizer$Token;",1,21,7,new JHandler[]{new JHandler(208,215,218,"java/lang/NumberFormatException")},M1525));
c.Add(new JMethod(1526,"forge/deck/DeckRecognizer","checkDoubleSidedCard","(Ljava/lang/String;)Ljava/lang/String;",2,7,2,new JHandler[]{},M1526));
c.Add(new JMethod(1527,"forge/deck/DeckRecognizer","checkAndSetCardToken","(Lforge/item/PaperCard;Lforge/card/CardEdition;ILjava/lang/String;Lforge/deck/DeckSection;Z)Lforge/deck/DeckRecognizer$Token;",2,8,5,new JHandler[]{},M1527));
c.Add(new JMethod(1528,"forge/deck/DeckRecognizer","getTokenSection","(Ljava/lang/String;Lforge/deck/DeckSection;Lforge/item/PaperCard;)Lforge/deck/DeckSection;",2,7,2,new JHandler[]{},M1528));
c.Add(new JMethod(1529,"forge/deck/DeckRecognizer","hasGameFormatConstraints","()Z",2,1,1,new JHandler[]{},M1529));
c.Add(new JMethod(1530,"forge/deck/DeckRecognizer","getRexGroup","(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;",8,4,2,new JHandler[]{new JHandler(48,53,54,"java/lang/IllegalArgumentException")},M1530));
c.Add(new JMethod(1531,"forge/deck/DeckRecognizer","isBannedInFormat","(Lforge/item/PaperCard;)Z",2,2,2,new JHandler[]{},M1531));
c.Add(new JMethod(1532,"forge/deck/DeckRecognizer","isRestrictedInFormat","(Lforge/item/PaperCard;I)Z",2,3,2,new JHandler[]{},M1532));
c.Add(new JMethod(1533,"forge/deck/DeckRecognizer","IsIllegalInFormat","(Ljava/lang/String;)Z",2,2,2,new JHandler[]{},M1533));
c.Add(new JMethod(1534,"forge/deck/DeckRecognizer","isNotCompliantWithReleaseDateRestrictions","(Lforge/card/CardEdition;)Z",2,2,2,new JHandler[]{},M1534));
c.Add(new JMethod(1535,"forge/deck/DeckRecognizer","getRegExMatchers","(Ljava/lang/String;)Ljava/util/List;",2,10,4,new JHandler[]{},M1535));
c.Add(new JMethod(1536,"forge/deck/DeckRecognizer","recogniseNonCardToken","(Ljava/lang/String;)Lforge/deck/DeckRecognizer$Token;",1,3,4,new JHandler[]{},M1536));
c.Add(new JMethod(1537,"forge/deck/DeckRecognizer","isCardType","(Ljava/lang/String;)Z",9,2,2,new JHandler[]{},M1537));
c.Add(new JMethod(1538,"forge/deck/DeckRecognizer","isCardRarity","(Ljava/lang/String;)Z",9,1,1,new JHandler[]{},M1538));
c.Add(new JMethod(1539,"forge/deck/DeckRecognizer","isCardCMC","(Ljava/lang/String;)Z",9,1,1,new JHandler[]{},M1539));
c.Add(new JMethod(1540,"forge/deck/DeckRecognizer","isManaToken","(Ljava/lang/String;)Z",9,1,1,new JHandler[]{},M1540));
c.Add(new JMethod(1541,"forge/deck/DeckRecognizer","isDeckSectionName","(Ljava/lang/String;)Z",9,2,2,new JHandler[]{},M1541));
c.Add(new JMethod(1542,"forge/deck/DeckRecognizer","nonCardTokenMatch","(Ljava/lang/String;)Ljava/lang/String;",10,3,2,new JHandler[]{},M1542));
c.Add(new JMethod(1543,"forge/deck/DeckRecognizer","cardRarityTokenMatch","(Ljava/lang/String;)Ljava/lang/String;",10,3,2,new JHandler[]{},M1543));
c.Add(new JMethod(1544,"forge/deck/DeckRecognizer","cardCMCTokenMatch","(Ljava/lang/String;)Ljava/lang/String;",10,3,2,new JHandler[]{},M1544));
c.Add(new JMethod(1545,"forge/deck/DeckRecognizer","getCardCMCMatch","(Ljava/lang/String;)Ljava/lang/String;",2,3,5,new JHandler[]{},M1545));
c.Add(new JMethod(1546,"forge/deck/DeckRecognizer","manaTokenMatch","(Ljava/lang/String;)Lorg/apache/commons/lang3/tuple/Pair;",10,5,2,new JHandler[]{},M1546));
c.Add(new JMethod(1547,"forge/deck/DeckRecognizer","matchAnyManaSymbolIn","(Ljava/lang/String;)Ljava/lang/String;",10,2,2,new JHandler[]{},M1547));
c.Add(new JMethod(1548,"forge/deck/DeckRecognizer","getManaTokenMatch","(Ljava/lang/String;)Ljava/lang/String;",10,6,3,new JHandler[]{},M1548));
c.Add(new JMethod(1549,"forge/deck/DeckRecognizer","getMagicColourLabel","(Lforge/card/MagicColor$Color;)Ljava/lang/String;",10,1,7,new JHandler[]{},M1549));
c.Add(new JMethod(1550,"forge/deck/DeckRecognizer","getMagicColourLabel","(Lforge/card/MagicColor$Color;Lforge/card/MagicColor$Color;)Ljava/lang/String;",10,4,8,new JHandler[]{},M1550));
c.Add(new JMethod(1551,"forge/deck/DeckRecognizer","getMagicColor","(Ljava/lang/String;)Lforge/card/MagicColor$Color;",10,1,2,new JHandler[]{},M1551));
c.Add(new JMethod(1552,"forge/deck/DeckRecognizer","toLongColourName","(Ljava/lang/String;)Ljava/lang/String;",10,4,2,new JHandler[]{},M1552));
c.Add(new JMethod(1553,"forge/deck/DeckRecognizer","isDeckName","(Ljava/lang/String;)Z",9,3,2,new JHandler[]{},M1553));
c.Add(new JMethod(1554,"forge/deck/DeckRecognizer","deckNameMatch","(Ljava/lang/String;)Ljava/lang/String;",9,3,2,new JHandler[]{},M1554));
c.Add(new JMethod(1555,"forge/deck/DeckRecognizer","setDateConstraint","(II)V",1,4,4,new JHandler[]{},M1555));
c.Add(new JMethod(1556,"forge/deck/DeckRecognizer","setGameFormatConstraint","(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V",1,4,2,new JHandler[]{},M1556));
c.Add(new JMethod(1557,"forge/deck/DeckRecognizer","setDeckFormatConstraint","(Lforge/deck/DeckFormat;)V",1,2,2,new JHandler[]{},M1557));
c.Add(new JMethod(1558,"forge/deck/DeckRecognizer","setArtPreference","(Lforge/card/CardDb$CardArtPreference;)V",1,2,2,new JHandler[]{},M1558));
c.Add(new JMethod(1559,"forge/deck/DeckRecognizer","setAllowedDeckSections","(Ljava/util/List;)V",1,2,2,new JHandler[]{},M1559));
c.Add(new JMethod(1560,"forge/deck/DeckRecognizer","forceImportBannedAndRestrictedCards","()V",1,1,2,new JHandler[]{},M1560));
c.Add(new JMethod(1561,"forge/deck/DeckRecognizer","<clinit>","()V",8,0,5,new JHandler[]{},M1561));
}

internal static JStep M1516(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","releaseDateConstraint","Ljava/util/Date;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","allowedSetCodes","Ljava/util/List;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","gameFormatBannedCards","Ljava/util/List;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(null));f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","gameFormatRestrictedCards","Ljava/util/List;",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(null));f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","allowedDeckSections","Ljava/util/List;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","includeBannedAndRestricted","Z",value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(null));f.Pc=36;continue;}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","deckFormat","Lforge/deck/DeckFormat;",value);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",43);}
case 43:{return rt.Call(f,"forge/StaticData","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokevirtual",46);}
case 46:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","artPreference","Lforge/card/CardDb$CardArtPreference;",value);f.Pc=49;continue;}
case 49:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1517(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",5);}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/deck/DeckRecognizer","compilePortablePattern","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1518(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckRecognizer","makePortablePattern","(Ljava/lang/String;)Lforge/deck/DeckRecognizer$PortablePattern;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$PortablePattern","regex","Ljava/lang/String;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","PORTABLE_PATTERN_GROUPS","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","PORTABLE_PATTERN_GROUPS","Ljava/util/Map;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$PortablePattern","groupIndexes","Ljava/util/Map;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1519(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/StringBuilder","<init>","(I)V","invokespecial",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{f.Locals[5]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[5]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",34);}
case 34:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?310:37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",43);}
case 43:{f.Locals[6]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(92));f.Pc=49;continue;}
case 49:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?85:52;continue;}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",60);}
case 60:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?85:63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[6]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",69);}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=73;continue;}
case 73:{f.Push(f.Locals[5]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",78);}
case 78:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",81);}
case 81:{f.StackOp("pop");f.Pc=82;continue;}
case 82:{f.Pc=304;continue;}
case 85:{f.Push(f.Locals[6]);f.Pc=87;continue;}
case 87:{f.Push(JValue.I(91));f.Pc=89;continue;}
case 89:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?98:92;continue;}
case 92:{f.Push(JValue.I(1));f.Pc=93;continue;}
case 93:{f.Locals[4]=f.Pop();f.Pc=95;continue;}
case 95:{f.Pc=297;continue;}
case 98:{f.Push(f.Locals[6]);f.Pc=100;continue;}
case 100:{f.Push(JValue.I(93));f.Pc=102;continue;}
case 102:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?111:105;continue;}
case 105:{f.Push(JValue.I(0));f.Pc=106;continue;}
case 106:{f.Locals[4]=f.Pop();f.Pc=108;continue;}
case 108:{f.Pc=297;continue;}
case 111:{f.Push(f.Locals[6]);f.Pc=113;continue;}
case 113:{f.Push(JValue.I(40));f.Pc=115;continue;}
case 115:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?297:118;continue;}
case 118:{f.Push(f.Locals[4]);f.Pc=120;continue;}
case 120:{f.Pc=f.Pop().Int!=0?297:123;continue;}
case 123:{f.Push(f.Locals[5]);f.Pc=125;continue;}
case 125:{f.Push(JValue.I(1));f.Pc=126;continue;}
case 126:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=127;continue;}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",131);}
case 131:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?151:134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[5]);f.Pc=137;continue;}
case 137:{f.Push(JValue.I(1));f.Pc=138;continue;}
case 138:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",142);}
case 142:{f.Push(JValue.I(63));f.Pc=144;continue;}
case 144:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?151:147;continue;}
case 147:{f.Push(JValue.I(1));f.Pc=148;continue;}
case 148:{f.Pc=152;continue;}
case 151:{f.Push(JValue.I(0));f.Pc=152;continue;}
case 152:{f.Locals[7]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[7]);f.Pc=156;continue;}
case 156:{f.Pc=f.Pop().Int==0?213:159;continue;}
case 159:{f.Push(f.Locals[5]);f.Pc=161;continue;}
case 161:{f.Push(JValue.I(3));f.Pc=162;continue;}
case 162:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=163;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",167);}
case 167:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?213:170;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[5]);f.Pc=173;continue;}
case 173:{f.Push(JValue.I(2));f.Pc=174;continue;}
case 174:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",178);}
case 178:{f.Push(JValue.I(60));f.Pc=180;continue;}
case 180:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?213:183;continue;}
case 183:{f.Push(f.Locals[0]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[5]);f.Pc=186;continue;}
case 186:{f.Push(JValue.I(3));f.Pc=187;continue;}
case 187:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",191);}
case 191:{f.Push(JValue.I(61));f.Pc=193;continue;}
case 193:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?213:196;continue;}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[5]);f.Pc=199;continue;}
case 199:{f.Push(JValue.I(3));f.Pc=200;continue;}
case 200:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",204);}
case 204:{f.Push(JValue.I(33));f.Pc=206;continue;}
case 206:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?213:209;continue;}
case 209:{f.Push(JValue.I(1));f.Pc=210;continue;}
case 210:{f.Pc=214;continue;}
case 213:{f.Push(JValue.I(0));f.Pc=214;continue;}
case 214:{f.Locals[8]=f.Pop();f.Pc=216;continue;}
case 216:{f.Push(f.Locals[8]);f.Pc=218;continue;}
case 218:{f.Pc=f.Pop().Int==0?289:221;continue;}
case 221:{f.Push(f.Locals[0]);f.Pc=222;continue;}
case 222:{f.Push(JValue.I(62));f.Pc=224;continue;}
case 224:{f.Push(f.Locals[5]);f.Pc=226;continue;}
case 226:{f.Push(JValue.I(3));f.Pc=227;continue;}
case 227:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/lang/String","indexOf","(II)I","invokevirtual",231);}
case 231:{f.Locals[9]=f.Pop();f.Pc=233;continue;}
case 233:{f.Push(f.Locals[9]);f.Pc=235;continue;}
case 235:{f.Pc=f.Pop().Int>=0?251:238;continue;}
case 238:{if(!rt.EnsureInitialized(f,"java/util/regex/PatternSyntaxException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/regex/PatternSyntaxException")));f.Pc=241;continue;}
case 241:{f.StackOp("dup");f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.String("Unclosed named capture group")));f.Pc=244;continue;}
case 244:{f.Push(f.Locals[0]);f.Pc=245;continue;}
case 245:{f.Push(f.Locals[5]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/util/regex/PatternSyntaxException","<init>","(Ljava/lang/String;Ljava/lang/String;I)V","invokespecial",250);}
case 250:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 251:{f.Push(f.Locals[2]);f.Pc=252;continue;}
case 252:{f.Push(f.Locals[0]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[5]);f.Pc=255;continue;}
case 255:{f.Push(JValue.I(3));f.Pc=256;continue;}
case 256:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=257;continue;}
case 257:{f.Push(f.Locals[9]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",262);}
case 262:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=265;continue;}
case 265:{f.Push(f.Locals[3]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",269);}
case 269:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",274);}
case 274:{f.StackOp("pop");f.Pc=275;continue;}
case 275:{f.Push(f.Locals[1]);f.Pc=276;continue;}
case 276:{f.Push(JValue.I(40));f.Pc=278;continue;}
case 278:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",281);}
case 281:{f.StackOp("pop");f.Pc=282;continue;}
case 282:{f.Push(f.Locals[9]);f.Pc=284;continue;}
case 284:{f.Locals[5]=f.Pop();f.Pc=286;continue;}
case 286:{f.Pc=304;continue;}
case 289:{f.Push(f.Locals[7]);f.Pc=291;continue;}
case 291:{f.Pc=f.Pop().Int!=0?297:294;continue;}
case 294:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=297;continue;}
case 297:{f.Push(f.Locals[1]);f.Pc=298;continue;}
case 298:{f.Push(f.Locals[6]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",303);}
case 303:{f.StackOp("pop");f.Pc=304;continue;}
case 304:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=307;continue;}
case 307:{f.Pc=28;continue;}
case 310:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$PortablePattern"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$PortablePattern")));f.Pc=313;continue;}
case 313:{f.StackOp("dup");f.Pc=314;continue;}
case 314:{f.Push(f.Locals[1]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",318);}
case 318:{f.Push(f.Locals[2]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/deck/DeckRecognizer$PortablePattern","<init>","(Ljava/lang/String;Ljava/util/Map;)V","invokespecial",322);}
case 322:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1520(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[0]=f.Pop();f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardType$CoreType","values","()[Lforge/card/CardType$CoreType;","invokestatic",11);}
case 11:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",14);}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?58:31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$CoreType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[3]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/card/CardType$CoreType","name","()Ljava/lang/String;","invokevirtual",46);}
case 46:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",49);}
case 49:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{f.Pc=22;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("sorceries")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("aura")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("mana")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("spell")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",93);}
case 93:{f.StackOp("pop");f.Pc=94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("other spell")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",102);}
case 102:{f.StackOp("pop");f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("planeswalker")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",111);}
case 111:{f.StackOp("pop");f.Pc=112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(JValue.I(0));f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.NewArray("Ljava/lang/CharSequence;",f.Pop().Int)));f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/List","toArray","([Ljava/lang/Object;)[Ljava/lang/Object;","invokeinterface",122);}
case 122:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/lang/CharSequence;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=125;continue;}
case 125:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1521(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=16;continue;}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Locals[6]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[6]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?310:28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[6]);f.Pc=32;continue;}
case 32:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=33;continue;}
case 33:{f.Locals[7]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[7]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/deck/DeckRecognizer","recognizeLine","(Ljava/lang/String;Lforge/deck/DeckSection;)Lforge/deck/DeckRecognizer$Token;","invokevirtual",42);}
case 42:{f.Locals[8]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[8]);f.Pc=46;continue;}
case 46:{f.Pc=f.Pop().Reference!=null?52:49;continue;}
case 49:{f.Pc=304;continue;}
case 52:{f.Push(f.Locals[8]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","getType","()Lforge/deck/DeckRecognizer$TokenType;","invokevirtual",57);}
case 57:{f.Locals[9]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[8]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","isTokenForDeck","()Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int!=0?75:67;continue;}
case 67:{f.Push(f.Locals[9]);f.Pc=69;continue;}
case 69:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","DECK_SECTION_NAME","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","DECK_SECTION_NAME","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=72;continue;}
case 72:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?90:75;continue;}
case 75:{f.Push(f.Locals[9]);f.Pc=77;continue;}
case 77:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","LIMITED_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","LIMITED_CARD","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=80;continue;}
case 80:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?102:83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","includeBannedAndRestricted","Z"));f.Pc=87;continue;}
case 87:{f.Pc=f.Pop().Int!=0?102:90;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[8]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",98);}
case 98:{f.StackOp("pop");f.Pc=99;continue;}
case 99:{f.Pc=304;continue;}
case 102:{f.Push(f.Locals[8]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","getType","()Lforge/deck/DeckRecognizer$TokenType;","invokevirtual",107);}
case 107:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","DECK_NAME","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","DECK_NAME","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=110;continue;}
case 110:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?125:113;continue;}
case 113:{f.Push(f.Locals[2]);f.Pc=114;continue;}
case 114:{f.Push(JValue.I(0));f.Pc=115;continue;}
case 115:{f.Push(f.Locals[8]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/List","add","(ILjava/lang/Object;)V","invokeinterface",122);}
case 122:{f.Pc=304;continue;}
case 125:{f.Push(f.Locals[8]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","getType","()Lforge/deck/DeckRecognizer$TokenType;","invokevirtual",130);}
case 130:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","DECK_SECTION_NAME","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","DECK_SECTION_NAME","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=133;continue;}
case 133:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?157:136;continue;}
case 136:{f.Push(f.Locals[8]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","getText","()Ljava/lang/String;","invokevirtual",141);}
case 141:{return rt.Call(f,"forge/deck/DeckSection","valueOf","(Ljava/lang/String;)Lforge/deck/DeckSection;","invokestatic",144);}
case 144:{f.Locals[3]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[2]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[8]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",153);}
case 153:{f.StackOp("pop");f.Pc=154;continue;}
case 154:{f.Pc=304;continue;}
case 157:{f.Push(f.Locals[8]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","getTokenSection","()Lforge/deck/DeckSection;","invokevirtual",162);}
case 162:{f.Locals[10]=f.Pop();f.Pc=164;continue;}
case 164:{f.Push(f.Locals[8]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","getCard","()Lforge/item/PaperCard;","invokevirtual",169);}
case 169:{f.Locals[11]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[0]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[10]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/deck/DeckRecognizer","isAllowed","(Lforge/deck/DeckSection;)Z","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int==0?275:180;continue;}
case 180:{f.Push(f.Locals[10]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[3]);f.Pc=183;continue;}
case 183:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?263:186;continue;}
case 186:{f.Push(f.Locals[10]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/deck/DeckSection","name","()Ljava/lang/String;","invokevirtual",191);}
case 191:{f.Push(f.Locals[0]);f.Pc=192;continue;}
case 192:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","allowedDeckSections","Ljava/util/List;"));f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","DeckSection","(Ljava/lang/String;Ljava/util/List;)Lforge/deck/DeckRecognizer$Token;","invokestatic",198);}
case 198:{f.Locals[12]=f.Pop();f.Pc=200;continue;}
case 200:{f.Push(f.Locals[2]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",206);}
case 206:{f.Pc=f.Pop().Int!=0?251:209;continue;}
case 209:{f.Push(f.Locals[2]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[2]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",216);}
case 216:{f.Push(JValue.I(1));f.Pc=217;continue;}
case 217:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=218;continue;}
case 218:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",223);}
case 223:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckRecognizer$Token"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","isCardPlaceholder","()Z","invokevirtual",229);}
case 229:{f.Pc=f.Pop().Int==0?251:232;continue;}
case 232:{f.Push(f.Locals[2]);f.Pc=233;continue;}
case 233:{f.Push(f.Locals[2]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",239);}
case 239:{f.Push(JValue.I(1));f.Pc=240;continue;}
case 240:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=241;continue;}
case 241:{f.Push(f.Locals[12]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"java/util/List","add","(ILjava/lang/Object;)V","invokeinterface",248);}
case 248:{f.Pc=260;continue;}
case 251:{f.Push(f.Locals[2]);f.Pc=252;continue;}
case 252:{f.Push(f.Locals[12]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",259);}
case 259:{f.StackOp("pop");f.Pc=260;continue;}
case 260:{f.Push(f.Locals[10]);f.Pc=262;continue;}
case 262:{f.Locals[3]=f.Pop();f.Pc=263;continue;}
case 263:{f.Push(f.Locals[2]);f.Pc=264;continue;}
case 264:{f.Push(f.Locals[8]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",271);}
case 271:{f.StackOp("pop");f.Pc=272;continue;}
case 272:{f.Pc=304;continue;}
case 275:{f.Push(f.Locals[11]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",280);}
case 280:{f.Push(f.Locals[11]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",285);}
case 285:{f.Push(f.Locals[8]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","getQuantity","()I","invokevirtual",290);}
case 290:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","UnsupportedCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/deck/DeckRecognizer$Token;","invokestatic",293);}
case 293:{f.Locals[12]=f.Pop();f.Pc=295;continue;}
case 295:{f.Push(f.Locals[2]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[12]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",303);}
case 303:{f.StackOp("pop");f.Pc=304;continue;}
case 304:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=307;continue;}
case 307:{f.Pc=21;continue;}
case 310:{f.Push(f.Locals[2]);f.Pc=311;continue;}
case 311:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1522(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","allowedDeckSections","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?20:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","allowedDeckSections","Ljava/util/List;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1523(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",10);}
case 10:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",13);}
case 13:{f.Pc=f.Pop().Int==0?18:16;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Push(JValue.I(8217));f.Pc=21;continue;}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Push(JValue.I(8217));f.Pc=29;continue;}
case 29:{f.Push(JValue.I(39));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","replace","(CC)Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/deck/DeckRecognizer","purgeAllLinks","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",41);}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("#")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?70:54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("#")));f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",65);}
case 65:{f.Locals[5]=f.Pop();f.Pc=67;continue;}
case 67:{f.Pc=77;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",75);}
case 75:{f.Locals[5]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("Summon:")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int!=0?104:88;continue;}
case 88:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","SEARCH_SINGLE_SLASH","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","SEARCH_SINGLE_SLASH","Ljava/util/regex/Pattern;"));f.Pc=91;continue;}
case 91:{f.Push(f.Locals[5]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",96);}
case 96:{f.Push(JValue.R(rt.String(" // ")));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/regex/Matcher","replaceFirst","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",102);}
case 102:{f.Locals[5]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[5]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("* ")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Int==0?123:115;continue;}
case 115:{f.Push(f.Locals[5]);f.Pc=117;continue;}
case 117:{f.Push(JValue.I(2));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",121);}
case 121:{f.Locals[5]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[5]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("#!Commander")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int==0?170:134;continue;}
case 134:{f.Push(f.Locals[5]);f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.String("#!Commander")));f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("")));f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",145);}
case 145:{f.Locals[5]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(JValue.R(rt.String("CM:%s")));f.Pc=150;continue;}
case 150:{f.Push(JValue.I(1));f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=154;continue;}
case 154:{f.StackOp("dup");f.Pc=155;continue;}
case 155:{f.Push(JValue.I(0));f.Pc=156;continue;}
case 156:{f.Push(f.Locals[5]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",161);}
case 161:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",165);}
case 165:{f.Locals[5]=f.Pop();f.Pc=167;continue;}
case 167:{f.Pc=201;continue;}
case 170:{f.Push(f.Locals[5]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",175);}
case 175:{f.Push(JValue.R(rt.String("[Conspiracy]")));f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",181);}
case 181:{f.Pc=f.Pop().Int==0?201:184;continue;}
case 184:{f.Push(JValue.R(rt.String("/ %s")));f.Pc=187;continue;}
case 187:{f.Push(JValue.I(1));f.Pc=188;continue;}
case 188:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=191;continue;}
case 191:{f.StackOp("dup");f.Pc=192;continue;}
case 192:{f.Push(JValue.I(0));f.Pc=193;continue;}
case 193:{f.Push(f.Locals[5]);f.Pc=195;continue;}
case 195:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",199);}
case 199:{f.Locals[5]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[0]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[5]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[2]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/deck/DeckRecognizer","recogniseCardToken","(Ljava/lang/String;Lforge/deck/DeckSection;)Lforge/deck/DeckRecognizer$Token;","invokevirtual",208);}
case 208:{f.Locals[6]=f.Pop();f.Pc=210;continue;}
case 210:{f.Push(f.Locals[6]);f.Pc=212;continue;}
case 212:{f.Pc=f.Pop().Reference!=null?223:215;continue;}
case 215:{f.Push(f.Locals[0]);f.Pc=216;continue;}
case 216:{f.Push(f.Locals[5]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/deck/DeckRecognizer","recogniseNonCardToken","(Ljava/lang/String;)Lforge/deck/DeckRecognizer$Token;","invokevirtual",221);}
case 221:{f.Locals[6]=f.Pop();f.Pc=223;continue;}
case 223:{f.Push(f.Locals[6]);f.Pc=225;continue;}
case 225:{f.Pc=f.Pop().Reference==null?233:228;continue;}
case 228:{f.Push(f.Locals[6]);f.Pc=230;continue;}
case 230:{f.Pc=284;continue;}
case 233:{f.Push(f.Locals[4]);f.Pc=235;continue;}
case 235:{f.Push(JValue.R(rt.String("//")));f.Pc=238;continue;}
case 238:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",241);}
case 241:{f.Pc=f.Pop().Int!=0?255:244;continue;}
case 244:{f.Push(f.Locals[4]);f.Pc=246;continue;}
case 246:{f.Push(JValue.R(rt.String("#")));f.Pc=249;continue;}
case 249:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",252);}
case 252:{f.Pc=f.Pop().Int==0?271:255;continue;}
case 255:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=258;continue;}
case 258:{f.StackOp("dup");f.Pc=259;continue;}
case 259:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","COMMENT","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","COMMENT","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=262;continue;}
case 262:{f.Push(JValue.I(0));f.Pc=263;continue;}
case 263:{f.Push(f.Locals[4]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILjava/lang/String;)V","invokespecial",268);}
case 268:{f.Pc=284;continue;}
case 271:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=274;continue;}
case 274:{f.StackOp("dup");f.Pc=275;continue;}
case 275:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","UNKNOWN_TEXT","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","UNKNOWN_TEXT","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=278;continue;}
case 278:{f.Push(JValue.I(0));f.Pc=279;continue;}
case 279:{f.Push(f.Locals[4]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILjava/lang/String;)V","invokespecial",284);}
case 284:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1524(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("(?:(?:https|ftp|file|http):)(?:(?://|\\\\)+)(?:[\\w\\d:#@%/;$~_?+-=\\\\.&]*)")));f.Pc=3;continue;}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(2));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?41:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/regex/Matcher","group","()Ljava/lang/String;","invokevirtual",28);}
case 28:{f.Push(JValue.R(rt.String("")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",34);}
case 34:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Locals[0]=f.Pop();f.Pc=38;continue;}
case 38:{f.Pc=16;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("()")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?63:51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",57);}
case 57:{f.Push(JValue.I(2));f.Pc=58;continue;}
case 58:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",62);}
case 62:{return JStep.Return(f.Pop());}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1525(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",11);}
case 11:{f.Locals[5]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/deck/DeckRecognizer","getRegExMatchers","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",18);}
case 18:{f.Locals[6]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[6]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",27);}
case 27:{f.Locals[7]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[7]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",36);}
case 36:{f.Pc=f.Pop().Int==0?405:39;continue;}
case 39:{f.Push(f.Locals[7]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/regex/Matcher"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[8]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[8]);f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.String("cardname")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/deck/DeckRecognizer","getRexGroup","(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;","invokestatic",59);}
case 59:{f.Locals[9]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[9]);f.Pc=63;continue;}
case 63:{f.Pc=f.Pop().Reference!=null?69:66;continue;}
case 66:{f.Pc=29;continue;}
case 69:{f.Push(f.Locals[9]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",74);}
case 74:{f.Locals[9]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[9]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/StaticData","isMTGCard","(Ljava/lang/String;)Z","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Int!=0?94:86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[9]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/deck/DeckRecognizer","checkDoubleSidedCard","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",92);}
case 92:{f.Locals[9]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[8]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("count")));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/deck/DeckRecognizer","getRexGroup","(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;","invokestatic",102);}
case 102:{f.Locals[10]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[8]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("setcode")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/deck/DeckRecognizer","getRexGroup","(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;","invokestatic",112);}
case 112:{f.Locals[11]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[8]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("collnr")));f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/deck/DeckRecognizer","getRexGroup","(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;","invokestatic",122);}
case 122:{f.Locals[12]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[8]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("foil")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/deck/DeckRecognizer","getRexGroup","(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;","invokestatic",132);}
case 132:{f.Locals[13]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[8]);f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.String("decsec")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/deck/DeckRecognizer","getRexGroup","(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;","invokestatic",142);}
case 142:{f.Locals[14]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[13]);f.Pc=146;continue;}
case 146:{f.Pc=f.Pop().Reference==null?153:149;continue;}
case 149:{f.Push(JValue.I(1));f.Pc=150;continue;}
case 150:{f.Pc=154;continue;}
case 153:{f.Push(JValue.I(0));f.Pc=154;continue;}
case 154:{f.Locals[15]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[10]);f.Pc=158;continue;}
case 158:{f.Pc=f.Pop().Reference==null?169:161;continue;}
case 161:{f.Push(f.Locals[10]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",166);}
case 166:{f.Pc=170;continue;}
case 169:{f.Push(JValue.I(1));f.Pc=170;continue;}
case 170:{f.Locals[16]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[9]);f.Pc=174;continue;}
case 174:{f.Pc=f.Pop().Reference!=null?193:177;continue;}
case 177:{f.Push(f.Locals[10]);f.Pc=179;continue;}
case 179:{f.Pc=f.Pop().Reference==null?29:182;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{f.Push(JValue.R(null));f.Pc=184;continue;}
case 184:{f.Push(JValue.I(0));f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","UnknownCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/deck/DeckRecognizer$Token;","invokestatic",188);}
case 188:{f.Locals[4]=f.Pop();f.Pc=190;continue;}
case 190:{f.Pc=29;continue;}
case 193:{f.Push(f.Locals[12]);f.Pc=195;continue;}
case 195:{f.Pc=f.Pop().Reference==null?203:198;continue;}
case 198:{f.Push(f.Locals[12]);f.Pc=200;continue;}
case 200:{f.Pc=206;continue;}
case 203:{f.Push(JValue.R(rt.String("N.A.")));f.Pc=206;continue;}
case 206:{f.Locals[17]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[17]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",213);}
case 213:{f.Locals[18]=f.Pop();f.Pc=215;continue;}
case 215:{f.Pc=223;continue;}
case 218:{f.Locals[19]=f.Pop();f.Pc=220;continue;}
case 220:{f.Push(JValue.I(-1));f.Pc=221;continue;}
case 221:{f.Locals[18]=f.Pop();f.Pc=223;continue;}
case 223:{f.Push(f.Locals[11]);f.Pc=225;continue;}
case 225:{f.Pc=f.Pop().Reference==null?311:228;continue;}
case 228:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",231);}
case 231:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",234);}
case 234:{f.Push(f.Locals[11]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",239);}
case 239:{f.Locals[19]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[19]);f.Pc=243;continue;}
case 243:{f.Pc=f.Pop().Reference!=null?260:246;continue;}
case 246:{f.Push(f.Locals[9]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[11]);f.Pc=250;continue;}
case 250:{f.Push(f.Locals[16]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","UnknownCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/deck/DeckRecognizer$Token;","invokestatic",255);}
case 255:{f.Locals[4]=f.Pop();f.Pc=257;continue;}
case 257:{f.Pc=29;continue;}
case 260:{f.Push(f.Locals[5]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[9]);f.Pc=264;continue;}
case 264:{f.Push(f.Locals[19]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[17]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[18]);f.Pc=270;continue;}
case 270:{f.Push(f.Locals[15]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/StaticData","getCardFromSet","(Ljava/lang/String;Lforge/card/CardEdition;Ljava/lang/String;IZ)Lforge/item/PaperCard;","invokevirtual",275);}
case 275:{f.Locals[20]=f.Pop();f.Pc=277;continue;}
case 277:{f.Push(f.Locals[20]);f.Pc=279;continue;}
case 279:{f.Pc=f.Pop().Reference==null?297:282;continue;}
case 282:{f.Push(f.Locals[0]);f.Pc=283;continue;}
case 283:{f.Push(f.Locals[20]);f.Pc=285;continue;}
case 285:{f.Push(f.Locals[19]);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[16]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[14]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[2]);f.Pc=292;continue;}
case 292:{f.Push(JValue.I(1));f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/deck/DeckRecognizer","checkAndSetCardToken","(Lforge/item/PaperCard;Lforge/card/CardEdition;ILjava/lang/String;Lforge/deck/DeckSection;Z)Lforge/deck/DeckRecognizer$Token;","invokevirtual",296);}
case 296:{return JStep.Return(f.Pop());}
case 297:{f.Push(f.Locals[9]);f.Pc=299;continue;}
case 299:{f.Push(f.Locals[11]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[16]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","UnknownCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/deck/DeckRecognizer$Token;","invokestatic",306);}
case 306:{f.Locals[4]=f.Pop();f.Pc=308;continue;}
case 308:{f.Pc=29;continue;}
case 311:{f.Push(JValue.R(null));f.Pc=312;continue;}
case 312:{f.Locals[19]=f.Pop();f.Pc=314;continue;}
case 314:{f.Push(f.Locals[0]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/deck/DeckRecognizer","hasGameFormatConstraints","()Z","invokevirtual",318);}
case 318:{f.Pc=f.Pop().Int==0?344:321;continue;}
case 321:{f.Push(f.Locals[5]);f.Pc=323;continue;}
case 323:{f.Push(f.Locals[9]);f.Pc=325;continue;}
case 325:{f.Push(f.Locals[15]);f.Pc=327;continue;}
case 327:{f.Push(f.Locals[0]);f.Pc=328;continue;}
case 328:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","artPreference","Lforge/card/CardDb$CardArtPreference;"));f.Pc=331;continue;}
case 331:{f.Push(f.Locals[0]);f.Pc=332;continue;}
case 332:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","allowedSetCodes","Ljava/util/List;"));f.Pc=335;continue;}
case 335:{f.Push(f.Locals[0]);f.Pc=336;continue;}
case 336:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","releaseDateConstraint","Ljava/util/Date;"));f.Pc=339;continue;}
case 339:{return rt.Call(f,"forge/StaticData","getCardFromSupportedEditions","(Ljava/lang/String;ZLforge/card/CardDb$CardArtPreference;Ljava/util/List;Ljava/util/Date;)Lforge/item/PaperCard;","invokevirtual",342);}
case 342:{f.Locals[19]=f.Pop();f.Pc=344;continue;}
case 344:{f.Push(f.Locals[19]);f.Pc=346;continue;}
case 346:{f.Pc=f.Pop().Reference!=null?369:349;continue;}
case 349:{f.Push(f.Locals[5]);f.Pc=351;continue;}
case 351:{f.Push(f.Locals[9]);f.Pc=353;continue;}
case 353:{f.Push(f.Locals[15]);f.Pc=355;continue;}
case 355:{f.Push(f.Locals[0]);f.Pc=356;continue;}
case 356:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","artPreference","Lforge/card/CardDb$CardArtPreference;"));f.Pc=359;continue;}
case 359:{f.Push(JValue.R(null));f.Pc=360;continue;}
case 360:{f.Push(f.Locals[0]);f.Pc=361;continue;}
case 361:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","releaseDateConstraint","Ljava/util/Date;"));f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/StaticData","getCardFromSupportedEditions","(Ljava/lang/String;ZLforge/card/CardDb$CardArtPreference;Ljava/util/List;Ljava/util/Date;)Lforge/item/PaperCard;","invokevirtual",367);}
case 367:{f.Locals[19]=f.Pop();f.Pc=369;continue;}
case 369:{f.Push(f.Locals[19]);f.Pc=371;continue;}
case 371:{f.Pc=f.Pop().Reference==null?402:374;continue;}
case 374:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",377);}
case 377:{f.Push(f.Locals[19]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",382);}
case 382:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",385);}
case 385:{f.Locals[20]=f.Pop();f.Pc=387;continue;}
case 387:{f.Push(f.Locals[0]);f.Pc=388;continue;}
case 388:{f.Push(f.Locals[19]);f.Pc=390;continue;}
case 390:{f.Push(f.Locals[20]);f.Pc=392;continue;}
case 392:{f.Push(f.Locals[16]);f.Pc=394;continue;}
case 394:{f.Push(f.Locals[14]);f.Pc=396;continue;}
case 396:{f.Push(f.Locals[2]);f.Pc=397;continue;}
case 397:{f.Push(JValue.I(0));f.Pc=398;continue;}
case 398:{return rt.Call(f,"forge/deck/DeckRecognizer","checkAndSetCardToken","(Lforge/item/PaperCard;Lforge/card/CardEdition;ILjava/lang/String;Lforge/deck/DeckSection;Z)Lforge/deck/DeckRecognizer$Token;","invokevirtual",401);}
case 401:{return JStep.Return(f.Pop());}
case 402:{f.Pc=29;continue;}
case 405:{f.Push(f.Locals[4]);f.Pc=407;continue;}
case 407:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1526(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("//")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("//")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=27;continue;}
case 27:{f.Push(JValue.I(2));f.Pc=28;continue;}
case 28:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?33:31;continue;}
case 31:{f.Push(JValue.R(null));f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",39);}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",47);}
case 47:{f.Locals[5]=f.Pop();f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",52);}
case 52:{f.Locals[6]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/StaticData","isMTGCard","(Ljava/lang/String;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int==0?67:64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{return JStep.Return(f.Pop());}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/StaticData","isMTGCard","(Ljava/lang/String;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int==0?80:77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{return JStep.Return(f.Pop());}
case 80:{f.Push(JValue.R(null));f.Pc=81;continue;}
case 81:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1527(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/deck/DeckRecognizer","IsIllegalInFormat","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?19:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[6]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","NotAllowedCard","(Lforge/item/PaperCard;IZ)Lforge/deck/DeckRecognizer$Token;","invokestatic",18);}
case 18:{return JStep.Return(f.Pop());}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/deck/DeckRecognizer","isNotCompliantWithReleaseDateRestrictions","(Lforge/card/CardEdition;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?35:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[6]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","CardInInvalidSet","(Lforge/item/PaperCard;IZ)Lforge/deck/DeckRecognizer$Token;","invokestatic",34);}
case 34:{return JStep.Return(f.Pop());}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/deck/DeckRecognizer","getTokenSection","(Ljava/lang/String;Lforge/deck/DeckSection;Lforge/item/PaperCard;)Lforge/deck/DeckSection;","invokevirtual",44);}
case 44:{f.Locals[7]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/deck/DeckRecognizer","isBannedInFormat","(Lforge/item/PaperCard;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?67:54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[7]);f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$LimitedCardType","BANNED","Lforge/deck/DeckRecognizer$LimitedCardType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$LimitedCardType","BANNED","Lforge/deck/DeckRecognizer$LimitedCardType;"));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[6]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","LimitedCard","(Lforge/item/PaperCard;ILforge/deck/DeckSection;Lforge/deck/DeckRecognizer$LimitedCardType;Z)Lforge/deck/DeckRecognizer$Token;","invokestatic",66);}
case 66:{return JStep.Return(f.Pop());}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/deck/DeckRecognizer","isRestrictedInFormat","(Lforge/item/PaperCard;I)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int==0?89:76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[3]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[7]);f.Pc=80;continue;}
case 80:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$LimitedCardType","RESTRICTED","Lforge/deck/DeckRecognizer$LimitedCardType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$LimitedCardType","RESTRICTED","Lforge/deck/DeckRecognizer$LimitedCardType;"));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","LimitedCard","(Lforge/item/PaperCard;ILforge/deck/DeckSection;Lforge/deck/DeckRecognizer$LimitedCardType;Z)Lforge/deck/DeckRecognizer$Token;","invokestatic",88);}
case 88:{return JStep.Return(f.Pop());}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[3]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[6]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","LegalCard","(Lforge/item/PaperCard;ILforge/deck/DeckSection;Z)Lforge/deck/DeckRecognizer$Token;","invokestatic",98);}
case 98:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1528(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?168:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","toUpperCase","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[5]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.I(-1));f.Pc=14;continue;}
case 14:{f.Locals[6]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",21);}
case 21:{switch(f.Pop().Int){case 2154:f.Pc=90;break;case 2453:f.Pc=56;break;case 2639:f.Pc=73;break;default:f.Pc=104;break;}continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("MB")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int==0?104:67;continue;}
case 67:{f.Push(JValue.I(0));f.Pc=68;continue;}
case 68:{f.Locals[6]=f.Pop();f.Pc=70;continue;}
case 70:{f.Pc=104;continue;}
case 73:{f.Push(f.Locals[5]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("SB")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int==0?104:84;continue;}
case 84:{f.Push(JValue.I(1));f.Pc=85;continue;}
case 85:{f.Locals[6]=f.Pop();f.Pc=87;continue;}
case 87:{f.Pc=104;continue;}
case 90:{f.Push(f.Locals[5]);f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String("CM")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?104:101;continue;}
case 101:{f.Push(JValue.I(2));f.Pc=102;continue;}
case 102:{f.Locals[6]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[6]);f.Pc=106;continue;}
case 106:{switch(f.Pop().Int){case 0:f.Pc=132;break;case 1:f.Pc=138;break;case 2:f.Pc=144;break;default:f.Pc=150;break;}continue;}
case 132:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=135;continue;}
case 135:{f.Pc=154;continue;}
case 138:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=141;continue;}
case 141:{f.Pc=154;continue;}
case 144:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=147;continue;}
case 147:{f.Pc=154;continue;}
case 150:{f.Push(f.Locals[3]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/deck/DeckSection","matchingSection","(Lforge/item/PaperCard;)Lforge/deck/DeckSection;","invokestatic",154);}
case 154:{f.Locals[4]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[4]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[3]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/deck/DeckSection","validate","(Lforge/item/PaperCard;)Z","invokevirtual",162);}
case 162:{f.Pc=f.Pop().Int==0?168:165;continue;}
case 165:{f.Push(f.Locals[4]);f.Pc=167;continue;}
case 167:{return JStep.Return(f.Pop());}
case 168:{f.Push(f.Locals[2]);f.Pc=169;continue;}
case 169:{f.Pc=f.Pop().Reference==null?187:172;continue;}
case 172:{f.Push(f.Locals[2]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[3]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/deck/DeckSection","validate","(Lforge/item/PaperCard;)Z","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int==0?182:180;continue;}
case 180:{f.Push(f.Locals[2]);f.Pc=181;continue;}
case 181:{return JStep.Return(f.Pop());}
case 182:{f.Push(f.Locals[3]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/deck/DeckSection","matchingSection","(Lforge/item/PaperCard;)Lforge/deck/DeckSection;","invokestatic",186);}
case 186:{return JStep.Return(f.Pop());}
case 187:{f.Push(f.Locals[3]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/deck/DeckSection","matchingSection","(Lforge/item/PaperCard;)Lforge/deck/DeckSection;","invokestatic",191);}
case 191:{f.Locals[4]=f.Pop();f.Pc=193;continue;}
case 193:{f.Push(f.Locals[4]);f.Pc=195;continue;}
case 195:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=198;continue;}
case 198:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?225:201;continue;}
case 201:{f.Push(f.Locals[0]);f.Pc=202;continue;}
case 202:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/deck/DeckRecognizer","isAllowed","(Lforge/deck/DeckSection;)Z","invokevirtual",208);}
case 208:{f.Pc=f.Pop().Int==0?225:211;continue;}
case 211:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=214;continue;}
case 214:{f.Push(f.Locals[3]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/deck/DeckSection","validate","(Lforge/item/PaperCard;)Z","invokevirtual",218);}
case 218:{f.Pc=f.Pop().Int==0?225:221;continue;}
case 221:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=224;continue;}
case 224:{return JStep.Return(f.Pop());}
case 225:{f.Push(f.Locals[0]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[4]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/deck/DeckRecognizer","isAllowed","(Lforge/deck/DeckSection;)Z","invokevirtual",231);}
case 231:{f.Pc=f.Pop().Int==0?237:234;continue;}
case 234:{f.Push(f.Locals[4]);f.Pc=236;continue;}
case 236:{return JStep.Return(f.Pop());}
case 237:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=240;continue;}
case 240:{f.Push(f.Locals[3]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/deck/DeckSection","validate","(Lforge/item/PaperCard;)Z","invokevirtual",244);}
case 244:{f.Pc=f.Pop().Int==0?253:247;continue;}
case 247:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=250;continue;}
case 250:{f.Pc=255;continue;}
case 253:{f.Push(f.Locals[4]);f.Pc=255;continue;}
case 255:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1529(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","allowedSetCodes","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?19:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","allowedSetCodes","Ljava/util/List;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?57:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","gameFormatBannedCards","Ljava/util/List;"));f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Reference==null?38:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","gameFormatBannedCards","Ljava/util/List;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?57:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","gameFormatRestrictedCards","Ljava/util/List;"));f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Reference==null?61:45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","gameFormatRestrictedCards","Ljava/util/List;"));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Int!=0?61:57;continue;}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{f.Pc=62;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1530(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","PORTABLE_PATTERN_GROUPS","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","PORTABLE_PATTERN_GROUPS","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/regex/Matcher","pattern","()Ljava/util/regex/Pattern;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Reference==null?48:20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Reference!=null?39:35;continue;}
case 35:{f.Push(JValue.R(null));f.Pc=36;continue;}
case 36:{f.Pc=47;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",44);}
case 44:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",47);}
case 47:{return JStep.Return(f.Pop());}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/regex/Matcher","group","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",53);}
case 53:{return JStep.Return(f.Pop());}
case 54:{f.Locals[3]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(JValue.R(null));f.Pc=56;continue;}
case 56:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1531(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","gameFormatBannedCards","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?23:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","gameFormatBannedCards","Ljava/util/List;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",15);}
case 15:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int!=0?41:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","deckFormat","Lforge/deck/DeckFormat;"));f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Reference==null?45:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","deckFormat","Lforge/deck/DeckFormat;"));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/deck/DeckFormat","isLegalCard","(Lforge/item/PaperCard;)Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int!=0?45:41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{f.Pc=46;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1532(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","gameFormatRestrictedCards","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?32:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","gameFormatRestrictedCards","Ljava/util/List;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",15);}
case 15:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?32:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?32:28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Pc=33;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1533(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","allowedSetCodes","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?24:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","allowedSetCodes","Ljava/util/List;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int!=0?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1534(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","releaseDateConstraint","Ljava/util/Date;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?25:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","releaseDateConstraint","Ljava/util/Date;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Date","compareTo","(Ljava/util/Date;)I","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int<0?25:21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Pc=26;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1535(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(4));f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.NewArray("Ljava/util/regex/Pattern;",f.Pop().Int)));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","CARD_SET_COLLNO_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","CARD_SET_COLLNO_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=17;continue;}
case 17:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","SET_CARD_COLLNO_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","SET_CARD_COLLNO_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=23;continue;}
case 23:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{f.Push(JValue.I(2));f.Pc=26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","CARD_COLLNO_SET_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","CARD_COLLNO_SET_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=29;continue;}
case 29:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(JValue.I(3));f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","SET_COLLNO_CARD_XMAGE_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","SET_COLLNO_CARD_XMAGE_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=35;continue;}
case 35:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=43;continue;}
case 43:{f.Locals[5]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{f.Locals[6]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?115:55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=60;continue;}
case 60:{f.Locals[7]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[7]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",68);}
case 68:{f.Locals[8]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[8]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",75);}
case 75:{f.Pc=f.Pop().Int==0?109:78;continue;}
case 78:{f.Push(f.Locals[8]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("setcode")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/deck/DeckRecognizer","getRexGroup","(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;","invokestatic",86);}
case 86:{f.Pc=f.Pop().Reference==null?109:89;continue;}
case 89:{f.Push(f.Locals[8]);f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("collnr")));f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/deck/DeckRecognizer","getRexGroup","(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;","invokestatic",97);}
case 97:{f.Pc=f.Pop().Reference==null?109:100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[8]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",108);}
case 108:{f.StackOp("pop");f.Pc=109;continue;}
case 109:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=112;continue;}
case 112:{f.Pc=48;continue;}
case 115:{f.Push(JValue.I(3));f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.NewArray("Ljava/util/regex/Pattern;",f.Pop().Int)));f.Pc=119;continue;}
case 119:{f.StackOp("dup");f.Pc=120;continue;}
case 120:{f.Push(JValue.I(0));f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","CARD_SET_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","CARD_SET_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=124;continue;}
case 124:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{f.Push(JValue.I(1));f.Pc=127;continue;}
case 127:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","SET_CARD_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","SET_CARD_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=130;continue;}
case 130:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=131;continue;}
case 131:{f.StackOp("dup");f.Pc=132;continue;}
case 132:{f.Push(JValue.I(2));f.Pc=133;continue;}
case 133:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","CARD_ONLY_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","CARD_ONLY_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=136;continue;}
case 136:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=137;continue;}
case 137:{f.Locals[4]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[4]);f.Pc=141;continue;}
case 141:{f.Locals[5]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=146;continue;}
case 146:{f.Locals[6]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(JValue.I(0));f.Pc=149;continue;}
case 149:{f.Locals[7]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[7]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[6]);f.Pc=155;continue;}
case 155:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?196:158;continue;}
case 158:{f.Push(f.Locals[5]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[7]);f.Pc=162;continue;}
case 162:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=163;continue;}
case 163:{f.Locals[8]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[8]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[1]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",171);}
case 171:{f.Locals[9]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[9]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",178);}
case 178:{f.Pc=f.Pop().Int==0?190:181;continue;}
case 181:{f.Push(f.Locals[2]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[9]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",189);}
case 189:{f.StackOp("pop");f.Pc=190;continue;}
case 190:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=193;continue;}
case 193:{f.Pc=151;continue;}
case 196:{f.Push(f.Locals[2]);f.Pc=197;continue;}
case 197:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1536(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckRecognizer","isDeckSectionName","(Ljava/lang/String;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int==0?21:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/deck/DeckRecognizer","nonCardTokenMatch","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer","allowedDeckSections","Ljava/util/List;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","DeckSection","(Ljava/lang/String;Ljava/util/List;)Lforge/deck/DeckRecognizer$Token;","invokestatic",20);}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/deck/DeckRecognizer","isCardCMC","(Ljava/lang/String;)Z","invokestatic",25);}
case 25:{f.Pc=f.Pop().Int==0?46:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/deck/DeckRecognizer","getCardCMCMatch","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",33);}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_CMC","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_CMC","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;Ljava/lang/String;)V","invokespecial",45);}
case 45:{return JStep.Return(f.Pop());}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/deck/DeckRecognizer","isCardRarity","(Ljava/lang/String;)Z","invokestatic",50);}
case 50:{f.Pc=f.Pop().Int==0?86:53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/deck/DeckRecognizer","cardRarityTokenMatch","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",57);}
case 57:{f.Locals[2]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{f.Pc=f.Pop().Reference==null?84:62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",66);}
case 66:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int!=0?84:72;continue;}
case 72:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_RARITY","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_RARITY","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;Ljava/lang/String;)V","invokespecial",83);}
case 83:{return JStep.Return(f.Pop());}
case 84:{f.Push(JValue.R(null));f.Pc=85;continue;}
case 85:{return JStep.Return(f.Pop());}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/deck/DeckRecognizer","isCardType","(Ljava/lang/String;)Z","invokestatic",90);}
case 90:{f.Pc=f.Pop().Int==0?110:93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/deck/DeckRecognizer","nonCardTokenMatch","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",97);}
case 97:{f.Locals[2]=f.Pop();f.Pc=98;continue;}
case 98:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=101;continue;}
case 101:{f.StackOp("dup");f.Pc=102;continue;}
case 102:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_TYPE","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_TYPE","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=105;continue;}
case 105:{f.Push(f.Locals[2]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;Ljava/lang/String;)V","invokespecial",109);}
case 109:{return JStep.Return(f.Pop());}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/deck/DeckRecognizer","isManaToken","(Ljava/lang/String;)Z","invokestatic",114);}
case 114:{f.Pc=f.Pop().Int==0?134:117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/deck/DeckRecognizer","getManaTokenMatch","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",121);}
case 121:{f.Locals[2]=f.Pop();f.Pc=122;continue;}
case 122:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","MANA_COLOUR","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","MANA_COLOUR","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=129;continue;}
case 129:{f.Push(f.Locals[2]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;Ljava/lang/String;)V","invokespecial",133);}
case 133:{return JStep.Return(f.Pop());}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/deck/DeckRecognizer","isDeckName","(Ljava/lang/String;)Z","invokestatic",138);}
case 138:{f.Pc=f.Pop().Int==0?161:141;continue;}
case 141:{f.Push(f.Locals[1]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/deck/DeckRecognizer","deckNameMatch","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",145);}
case 145:{f.Locals[2]=f.Pop();f.Pc=146;continue;}
case 146:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=149;continue;}
case 149:{f.StackOp("dup");f.Pc=150;continue;}
case 150:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","DECK_NAME","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","DECK_NAME","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=153;continue;}
case 153:{f.Push(f.Locals[2]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",157);}
case 157:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;Ljava/lang/String;)V","invokespecial",160);}
case 160:{return JStep.Return(f.Pop());}
case 161:{f.Push(JValue.R(null));f.Pc=162;continue;}
case 162:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1537(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckRecognizer","nonCardTokenMatch","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?11:9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",15);}
case 15:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","CARD_TYPES","[Ljava/lang/CharSequence;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","CARD_TYPES","[Ljava/lang/CharSequence;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","startsWithAny","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z","invokestatic",21);}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1538(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckRecognizer","cardRarityTokenMatch","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",4);}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1539(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckRecognizer","cardCMCTokenMatch","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",4);}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1540(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckRecognizer","manaTokenMatch","(Ljava/lang/String;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",4);}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1541(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckRecognizer","nonCardTokenMatch","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?11:9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","DECK_SECTION_NAMES","[Ljava/lang/CharSequence;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","DECK_SECTION_NAMES","[Ljava/lang/CharSequence;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","equalsAnyIgnoreCase","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z","invokestatic",18);}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1542(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","NONCARD_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","NONCARD_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?28:26;continue;}
case 26:{f.Push(JValue.R(null));f.Pc=27;continue;}
case 27:{return JStep.Return(f.Pop());}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("token")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/deck/DeckRecognizer","getRexGroup","(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;","invokestatic",35);}
case 35:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1543(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","CARD_RARITY_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","CARD_RARITY_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?28:26;continue;}
case 26:{f.Push(JValue.R(null));f.Pc=27;continue;}
case 27:{return JStep.Return(f.Pop());}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("token")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/deck/DeckRecognizer","getRexGroup","(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;","invokestatic",35);}
case 35:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1544(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","CMC_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","CMC_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?28:26;continue;}
case 26:{f.Push(JValue.R(null));f.Pc=27;continue;}
case 27:{return JStep.Return(f.Pop());}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("token")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/deck/DeckRecognizer","getRexGroup","(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;","invokestatic",35);}
case 35:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1545(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckRecognizer","cardCMCTokenMatch","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","toUpperCase","()Ljava/lang/String;","invokevirtual",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("CC")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?37:20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("CC")));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",30);}
case 30:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",33);}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Pc=51;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("CMC")));f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",47);}
case 47:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",50);}
case 50:{f.Locals[2]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("CMC: %s")));f.Pc=54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",65);}
case 65:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1546(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","MANA_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","MANA_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?28:26;continue;}
case 26:{f.Push(JValue.R(null));f.Pc=27;continue;}
case 27:{return JStep.Return(f.Pop());}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("colr1")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/deck/DeckRecognizer","getRexGroup","(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;","invokestatic",35);}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("colr2")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/deck/DeckRecognizer","getRexGroup","(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;","invokestatic",43);}
case 43:{f.Locals[4]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/deck/DeckRecognizer","matchAnyManaSymbolIn","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",49);}
case 49:{f.Locals[3]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/deck/DeckRecognizer","matchAnyManaSymbolIn","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",55);}
case 55:{f.Locals[4]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",63);}
case 63:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1547(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","MANA_SYMBOL_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","MANA_SYMBOL_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",13);}
case 13:{f.Locals[1]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?28:21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("mana")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/deck/DeckRecognizer","getRexGroup","(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;","invokestatic",27);}
case 27:{return JStep.Return(f.Pop());}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1548(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckRecognizer","manaTokenMatch","(Ljava/lang/String;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",25);}
case 25:{f.Push(JValue.I(2));f.Pc=26;continue;}
case 26:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?58:29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",35);}
case 35:{return rt.Call(f,"forge/deck/DeckRecognizer","getMagicColor","(Ljava/lang/String;)Lforge/card/MagicColor$Color;","invokestatic",38);}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/deck/DeckRecognizer","getMagicColor","(Ljava/lang/String;)Lforge/card/MagicColor$Color;","invokestatic",48);}
case 48:{f.Locals[5]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/deck/DeckRecognizer","getMagicColourLabel","(Lforge/card/MagicColor$Color;Lforge/card/MagicColor$Color;)Ljava/lang/String;","invokestatic",57);}
case 57:{return JStep.Return(f.Pop());}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/deck/DeckRecognizer","getMagicColor","(Ljava/lang/String;)Lforge/card/MagicColor$Color;","invokestatic",62);}
case 62:{f.Locals[4]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{f.Pc=f.Pop().Reference!=null?74:68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/deck/DeckRecognizer","getMagicColourLabel","(Lforge/card/MagicColor$Color;)Ljava/lang/String;","invokestatic",73);}
case 73:{return JStep.Return(f.Pop());}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/deck/DeckRecognizer","getMagicColor","(Ljava/lang/String;)Lforge/card/MagicColor$Color;","invokestatic",78);}
case 78:{f.Locals[5]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?93:87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/deck/DeckRecognizer","getMagicColourLabel","(Lforge/card/MagicColor$Color;)Ljava/lang/String;","invokestatic",92);}
case 92:{return JStep.Return(f.Pop());}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[5]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/deck/DeckRecognizer","getMagicColourLabel","(Lforge/card/MagicColor$Color;Lforge/card/MagicColor$Color;)Ljava/lang/String;","invokestatic",100);}
case 100:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1549(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?31:4;continue;}
case 4:{f.Push(JValue.R(rt.String("%s {W}{U}{B}{R}{G}")));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",16);}
case 16:{f.Push(JValue.R(rt.String("lblMulticolor")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",26);}
case 26:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",30);}
case 30:{return JStep.Return(f.Pop());}
case 31:{f.Push(JValue.R(rt.String("%s %s")));f.Pc=34;continue;}
case 34:{f.Push(JValue.I(2));f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/card/MagicColor$Color","getTranslatedName","()Ljava/lang/String;","invokevirtual",44);}
case 44:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=45;continue;}
case 45:{f.StackOp("dup");f.Pc=46;continue;}
case 46:{f.Push(JValue.I(1));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/card/MagicColor$Color","getSymbol","()Ljava/lang/String;","invokevirtual",51);}
case 51:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",55);}
case 55:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1550(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?18:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","COLORLESS","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","COLORLESS","Lforge/card/MagicColor$Color;"));f.Pc=8;continue;}
case 8:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?18:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","COLORLESS","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","COLORLESS","Lforge/card/MagicColor$Color;"));f.Pc=15;continue;}
case 15:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?43:18;continue;}
case 18:{f.Push(JValue.R(rt.String("%s // %s")));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(2));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/deck/DeckRecognizer","getMagicColourLabel","(Lforge/card/MagicColor$Color;)Ljava/lang/String;","invokestatic",31);}
case 31:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/deck/DeckRecognizer","getMagicColourLabel","(Lforge/card/MagicColor$Color;)Ljava/lang/String;","invokestatic",38);}
case 38:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",42);}
case 42:{return JStep.Return(f.Pop());}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/card/MagicColor$Color","getTranslatedName","()Ljava/lang/String;","invokevirtual",47);}
case 47:{f.Locals[2]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/card/MagicColor$Color","getTranslatedName","()Ljava/lang/String;","invokevirtual",52);}
case 52:{f.Locals[3]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.String("%s/%s {%s}")));f.Pc=56;continue;}
case 56:{f.Push(JValue.I(3));f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=60;continue;}
case 60:{f.StackOp("dup");f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=64;continue;}
case 64:{f.StackOp("dup");f.Pc=65;continue;}
case 65:{f.Push(JValue.I(1));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.I(2));f.Pc=70;continue;}
case 70:{f.Push(JValue.I(2));f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=78;continue;}
case 78:{f.StackOp("dup");f.Pc=79;continue;}
case 79:{f.Push(JValue.I(1));f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/card/ColorSet","fromEnums","([Lforge/card/MagicColor$Color;)Lforge/card/ColorSet;","invokestatic",85);}
case 85:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",89);}
case 89:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1551(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("multi")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int!=0?23:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("m")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?25:23;continue;}
case 23:{f.Push(JValue.R(null));f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/deck/DeckRecognizer","toLongColourName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",29);}
case 29:{return rt.Call(f,"forge/card/MagicColor$Color","fromName","(Ljava/lang/String;)Lforge/card/MagicColor$Color;","invokestatic",32);}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1552(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"java/util/Locale","ROOT","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ROOT","Ljava/util/Locale;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","toLowerCase","(Ljava/util/Locale;)Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.I(-1));f.Pc=11;continue;}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",16);}
case 16:{switch(f.Pop().Int){case 98:f.Pc=114;break;case 99:f.Pc=159;break;case 103:f.Pc=144;break;case 114:f.Pc=129;break;case 117:f.Pc=99;break;case 119:f.Pc=84;break;case 1392875877:f.Pc=174;break;default:f.Pc=187;break;}continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("w")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?187:94;continue;}
case 94:{f.Push(JValue.I(0));f.Pc=95;continue;}
case 95:{f.Locals[3]=f.Pop();f.Pc=96;continue;}
case 96:{f.Pc=187;continue;}
case 99:{f.Push(f.Locals[2]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.String("u")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?187:109;continue;}
case 109:{f.Push(JValue.I(1));f.Pc=110;continue;}
case 110:{f.Locals[3]=f.Pop();f.Pc=111;continue;}
case 111:{f.Pc=187;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("b")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int==0?187:124;continue;}
case 124:{f.Push(JValue.I(2));f.Pc=125;continue;}
case 125:{f.Locals[3]=f.Pop();f.Pc=126;continue;}
case 126:{f.Pc=187;continue;}
case 129:{f.Push(f.Locals[2]);f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("r")));f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",136);}
case 136:{f.Pc=f.Pop().Int==0?187:139;continue;}
case 139:{f.Push(JValue.I(3));f.Pc=140;continue;}
case 140:{f.Locals[3]=f.Pop();f.Pc=141;continue;}
case 141:{f.Pc=187;continue;}
case 144:{f.Push(f.Locals[2]);f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.String("g")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",151);}
case 151:{f.Pc=f.Pop().Int==0?187:154;continue;}
case 154:{f.Push(JValue.I(4));f.Pc=155;continue;}
case 155:{f.Locals[3]=f.Pop();f.Pc=156;continue;}
case 156:{f.Pc=187;continue;}
case 159:{f.Push(f.Locals[2]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("c")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",166);}
case 166:{f.Pc=f.Pop().Int==0?187:169;continue;}
case 169:{f.Push(JValue.I(5));f.Pc=170;continue;}
case 170:{f.Locals[3]=f.Pop();f.Pc=171;continue;}
case 171:{f.Pc=187;continue;}
case 174:{f.Push(f.Locals[2]);f.Pc=175;continue;}
case 175:{f.Push(JValue.R(rt.String("colourless")));f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",181);}
case 181:{f.Pc=f.Pop().Int==0?187:184;continue;}
case 184:{f.Push(JValue.I(6));f.Pc=186;continue;}
case 186:{f.Locals[3]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[3]);f.Pc=188;continue;}
case 188:{switch(f.Pop().Int){case 0:f.Pc=232;break;case 1:f.Pc=238;break;case 2:f.Pc=244;break;case 3:f.Pc=250;break;case 4:f.Pc=256;break;case 5:f.Pc=262;break;case 6:f.Pc=262;break;default:f.Pc=268;break;}continue;}
case 232:{f.Push(JValue.R(rt.String("white")));f.Pc=235;continue;}
case 235:{f.Pc=269;continue;}
case 238:{f.Push(JValue.R(rt.String("blue")));f.Pc=241;continue;}
case 241:{f.Pc=269;continue;}
case 244:{f.Push(JValue.R(rt.String("black")));f.Pc=247;continue;}
case 247:{f.Pc=269;continue;}
case 250:{f.Push(JValue.R(rt.String("red")));f.Pc=253;continue;}
case 253:{f.Pc=269;continue;}
case 256:{f.Push(JValue.R(rt.String("green")));f.Pc=259;continue;}
case 259:{f.Pc=269;continue;}
case 262:{f.Push(JValue.R(rt.String("colorless")));f.Pc=265;continue;}
case 265:{f.Pc=269;continue;}
case 268:{f.Push(f.Locals[1]);f.Pc=269;continue;}
case 269:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1553(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","DECK_NAME_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","DECK_NAME_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",23);}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1554(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?8:4;continue;}
case 4:{f.Push(JValue.R(rt.String("")));f.Pc=7;continue;}
case 7:{return JStep.Return(f.Pop());}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","DECK_NAME_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","DECK_NAME_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?36:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("deckName")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/deck/DeckRecognizer","getRexGroup","(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;","invokestatic",35);}
case 35:{return JStep.Return(f.Pop());}
case 36:{f.Push(JValue.R(rt.String("")));f.Pc=39;continue;}
case 39:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1555(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"java/util/Calendar","getInstance","()Ljava/util/Calendar;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Calendar","set","(III)V","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Calendar","getTime","()Ljava/util/Date;","invokevirtual",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","releaseDateConstraint","Ljava/util/Date;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1556(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?21:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int!=0?21:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","allowedSetCodes","Ljava/util/List;",value);f.Pc=18;continue;}
case 18:{f.Pc=26;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(null));f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","allowedSetCodes","Ljava/util/List;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Reference==null?47:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",36);}
case 36:{f.Pc=f.Pop().Int!=0?47:39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","gameFormatBannedCards","Ljava/util/List;",value);f.Pc=44;continue;}
case 44:{f.Pc=52;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(null));f.Pc=49;continue;}
case 49:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","gameFormatBannedCards","Ljava/util/List;",value);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{f.Pc=f.Pop().Reference==null?73:56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",62);}
case 62:{f.Pc=f.Pop().Int!=0?73:65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","gameFormatRestrictedCards","Ljava/util/List;",value);f.Pc=70;continue;}
case 70:{f.Pc=78;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(null));f.Pc=75;continue;}
case 75:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","gameFormatRestrictedCards","Ljava/util/List;",value);f.Pc=78;continue;}
case 78:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1557(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","deckFormat","Lforge/deck/DeckFormat;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1558(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","artPreference","Lforge/card/CardDb$CardArtPreference;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1559(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","allowedDeckSections","Ljava/util/List;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1560(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer","includeBannedAndRestricted","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1561(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/IdentityHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/IdentityHashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/IdentityHashMap","<init>","()V","invokespecial",7);}
case 7:{return rt.Call(f,"java/util/Collections","synchronizedMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",10);}
case 10:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","PORTABLE_PATTERN_GROUPS","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","PORTABLE_PATTERN_GROUPS","Ljava/util/Map;",f.Pop());f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("(?<=[^/])\\s*/\\s*(?=[^/])")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",19);}
case 19:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","SEARCH_SINGLE_SLASH","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","SEARCH_SINGLE_SLASH","Ljava/util/regex/Pattern;",f.Pop());f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("^(\\/\\/\\s*)?(?<pre>(deck|name(\\s)?))(\\:|=)\\s*(?<%s>([a-zA-Z0-9',\\/\\-\\s\\)\\]\\(\\[\\#]+))\\s*(.*)$")));f.Pc=25;continue;}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("deckName")));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",38);}
case 38:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_DECK_NAME","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_DECK_NAME","Ljava/lang/String;",f.Pop());f.Pc=41;continue;}
case 41:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_DECK_NAME","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_DECK_NAME","Ljava/lang/String;"));f.Pc=44;continue;}
case 44:{f.Push(JValue.I(2));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/deck/DeckRecognizer","compilePattern","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",48);}
case 48:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","DECK_NAME_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","DECK_NAME_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("^(?<pre>[^a-zA-Z]*)\\s*(?<title>(\\w+[:]\\s*))?(?<%s>[a-zA-Z]+)(?<post>[^a-zA-Z]*)?$")));f.Pc=54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("token")));f.Pc=63;continue;}
case 63:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",67);}
case 67:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_NOCARD","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_NOCARD","Ljava/lang/String;",f.Pop());f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("^(?<pre>[^a-zA-Z]*)\\s*(?<%s>(C(M)?C(\\s)?\\d{1,2}))(?<post>[^\\d]*)?$")));f.Pc=73;continue;}
case 73:{f.Push(JValue.I(1));f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=77;continue;}
case 77:{f.StackOp("dup");f.Pc=78;continue;}
case 78:{f.Push(JValue.I(0));f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("token")));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",86);}
case 86:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CMC","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_CMC","Ljava/lang/String;",f.Pop());f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("^(?<pre>[^a-zA-Z]*)\\s*(?<%s>((un)?common|(mythic)?\\s*(rare)?|land|special))(?<post>[^a-zA-Z]*)?$")));f.Pc=92;continue;}
case 92:{f.Push(JValue.I(1));f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=96;continue;}
case 96:{f.StackOp("dup");f.Pc=97;continue;}
case 97:{f.Push(JValue.I(0));f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("token")));f.Pc=101;continue;}
case 101:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",105);}
case 105:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_RARITY","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_RARITY","Ljava/lang/String;",f.Pop());f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("\\{(?<%s>(%s))\\}")));f.Pc=111;continue;}
case 111:{f.Push(JValue.I(2));f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=115;continue;}
case 115:{f.StackOp("dup");f.Pc=116;continue;}
case 116:{f.Push(JValue.I(0));f.Pc=117;continue;}
case 117:{f.Push(JValue.R(rt.String("mana")));f.Pc=119;continue;}
case 119:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=120;continue;}
case 120:{f.StackOp("dup");f.Pc=121;continue;}
case 121:{f.Push(JValue.I(1));f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("w|u|b|r|g|c|m|wu|ub|br|rg|gw|wb|ur|bg|rw|gu")));f.Pc=125;continue;}
case 125:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",129);}
case 129:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_MANA_SYMBOLS","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_MANA_SYMBOLS","Ljava/lang/String;",f.Pop());f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.String("(\\{(%s)\\})|(white|blue|black|red|green|colo(u)?rless|multicolo(u)?r)")));f.Pc=135;continue;}
case 135:{f.Push(JValue.I(1));f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=139;continue;}
case 139:{f.StackOp("dup");f.Pc=140;continue;}
case 140:{f.Push(JValue.I(0));f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String("w|u|b|r|g|c|m|wu|ub|br|rg|gw|wb|ur|bg|rw|gu")));f.Pc=144;continue;}
case 144:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",148);}
case 148:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_MANA_COLOURS","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_MANA_COLOURS","Ljava/lang/String;",f.Pop());f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("^(?<pre>[^a-zA-Z]*)\\s*(?<%s>(%s))((\\s|-|\\|)(?<%s>(%s)))?(?<post>[^a-zA-Z]*)?$")));f.Pc=154;continue;}
case 154:{f.Push(JValue.I(4));f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=158;continue;}
case 158:{f.StackOp("dup");f.Pc=159;continue;}
case 159:{f.Push(JValue.I(0));f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("colr1")));f.Pc=163;continue;}
case 163:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=164;continue;}
case 164:{f.StackOp("dup");f.Pc=165;continue;}
case 165:{f.Push(JValue.I(1));f.Pc=166;continue;}
case 166:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_MANA_COLOURS","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_MANA_COLOURS","Ljava/lang/String;"));f.Pc=169;continue;}
case 169:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=170;continue;}
case 170:{f.StackOp("dup");f.Pc=171;continue;}
case 171:{f.Push(JValue.I(2));f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String("colr2")));f.Pc=175;continue;}
case 175:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=176;continue;}
case 176:{f.StackOp("dup");f.Pc=177;continue;}
case 177:{f.Push(JValue.I(3));f.Pc=178;continue;}
case 178:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_MANA_COLOURS","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_MANA_COLOURS","Ljava/lang/String;"));f.Pc=181;continue;}
case 181:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",185);}
case 185:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_MANA","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_MANA","Ljava/lang/String;",f.Pop());f.Pc=188;continue;}
case 188:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_NOCARD","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_NOCARD","Ljava/lang/String;"));f.Pc=191;continue;}
case 191:{f.Push(JValue.I(2));f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/deck/DeckRecognizer","compilePattern","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",195);}
case 195:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","NONCARD_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","NONCARD_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=198;continue;}
case 198:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CMC","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CMC","Ljava/lang/String;"));f.Pc=201;continue;}
case 201:{f.Push(JValue.I(2));f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/deck/DeckRecognizer","compilePattern","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",205);}
case 205:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","CMC_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","CMC_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=208;continue;}
case 208:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_RARITY","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_RARITY","Ljava/lang/String;"));f.Pc=211;continue;}
case 211:{f.Push(JValue.I(2));f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/deck/DeckRecognizer","compilePattern","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",215);}
case 215:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","CARD_RARITY_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","CARD_RARITY_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=218;continue;}
case 218:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_MANA","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_MANA","Ljava/lang/String;"));f.Pc=221;continue;}
case 221:{f.Push(JValue.I(2));f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/deck/DeckRecognizer","compilePattern","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",225);}
case 225:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","MANA_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","MANA_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=228;continue;}
case 228:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_MANA_SYMBOLS","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_MANA_SYMBOLS","Ljava/lang/String;"));f.Pc=231;continue;}
case 231:{f.Push(JValue.I(2));f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/deck/DeckRecognizer","compilePattern","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",235);}
case 235:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","MANA_SYMBOL_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","MANA_SYMBOL_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=238;continue;}
case 238:{f.Push(JValue.R(rt.String("(\\[)?(?<%s>[_a-zA-Z0-9\u00e0-\u00ff\u00c0-\u0178&',\\.:!\\?\\+\\\"\\/\\-\\s]+)(\\])?")));f.Pc=241;continue;}
case 241:{f.Push(JValue.I(1));f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=245;continue;}
case 245:{f.StackOp("dup");f.Pc=246;continue;}
case 246:{f.Push(JValue.I(0));f.Pc=247;continue;}
case 247:{f.Push(JValue.R(rt.String("cardname")));f.Pc=250;continue;}
case 250:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=251;continue;}
case 251:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",254);}
case 254:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_NAME","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_CARD_NAME","Ljava/lang/String;",f.Pop());f.Pc=257;continue;}
case 257:{f.Push(JValue.R(rt.String("(?<%s>[a-zA-Z0-9_]{2,7})")));f.Pc=260;continue;}
case 260:{f.Push(JValue.I(1));f.Pc=261;continue;}
case 261:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=264;continue;}
case 264:{f.StackOp("dup");f.Pc=265;continue;}
case 265:{f.Push(JValue.I(0));f.Pc=266;continue;}
case 266:{f.Push(JValue.R(rt.String("setcode")));f.Pc=269;continue;}
case 269:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",273);}
case 273:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_SET_CODE","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_SET_CODE","Ljava/lang/String;",f.Pop());f.Pc=276;continue;}
case 276:{f.Push(JValue.R(rt.String("(?<%s>\\*?%s(?:[-_\u2605\u2607\u2020\u03a6][0-9A-Za-z]*)*)")));f.Pc=279;continue;}
case 279:{f.Push(JValue.I(2));f.Pc=280;continue;}
case 280:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=283;continue;}
case 283:{f.StackOp("dup");f.Pc=284;continue;}
case 284:{f.Push(JValue.I(0));f.Pc=285;continue;}
case 285:{f.Push(JValue.R(rt.String("collnr")));f.Pc=288;continue;}
case 288:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=289;continue;}
case 289:{f.StackOp("dup");f.Pc=290;continue;}
case 290:{f.Push(JValue.I(1));f.Pc=291;continue;}
case 291:{f.Push(JValue.R(rt.String("(?:[0-9A-Za-z]*[0-9][0-9A-Za-z]*|[0-9A-Z]+[a-z]?)")));f.Pc=294;continue;}
case 294:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=295;continue;}
case 295:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",298);}
case 298:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_COLL_NUMBER","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_COLL_NUMBER","Ljava/lang/String;",f.Pop());f.Pc=301;continue;}
case 301:{f.Push(JValue.R(rt.String("(?<%s>[\\d]{1,2})(?<mult>x)?")));f.Pc=304;continue;}
case 304:{f.Push(JValue.I(1));f.Pc=305;continue;}
case 305:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=308;continue;}
case 308:{f.StackOp("dup");f.Pc=309;continue;}
case 309:{f.Push(JValue.I(0));f.Pc=310;continue;}
case 310:{f.Push(JValue.R(rt.String("count")));f.Pc=313;continue;}
case 313:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=314;continue;}
case 314:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",317);}
case 317:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_COUNT","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_CARD_COUNT","Ljava/lang/String;",f.Pop());f.Pc=320;continue;}
case 320:{f.Push(JValue.R(rt.String("(?<%s>\\(F\\)|\\*[FE]\\*)?")));f.Pc=323;continue;}
case 323:{f.Push(JValue.I(1));f.Pc=324;continue;}
case 324:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=327;continue;}
case 327:{f.StackOp("dup");f.Pc=328;continue;}
case 328:{f.Push(JValue.I(0));f.Pc=329;continue;}
case 329:{f.Push(JValue.R(rt.String("foil")));f.Pc=332;continue;}
case 332:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=333;continue;}
case 333:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",336);}
case 336:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_FOIL_MTGGOLDFISH","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_FOIL_MTGGOLDFISH","Ljava/lang/String;",f.Pop());f.Pc=339;continue;}
case 339:{f.Push(JValue.R(rt.String("(?<%s>(MB|SB|CM))")));f.Pc=342;continue;}
case 342:{f.Push(JValue.I(1));f.Pc=343;continue;}
case 343:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=346;continue;}
case 346:{f.StackOp("dup");f.Pc=347;continue;}
case 347:{f.Push(JValue.I(0));f.Pc=348;continue;}
case 348:{f.Push(JValue.R(rt.String("decsec")));f.Pc=351;continue;}
case 351:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=352;continue;}
case 352:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",355);}
case 355:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_DECKSEC_XMAGE","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_DECKSEC_XMAGE","Ljava/lang/String;",f.Pop());f.Pc=358;continue;}
case 358:{f.Push(JValue.R(rt.String("(%s\\s*:\\s*)?(%s\\s)?\\s*%s\\s*(\\s|\\||\\(|\\[|\\{)\\s?%s(\\s|\\)|\\]|\\})?\\s*%s")));f.Pc=361;continue;}
case 361:{f.Push(JValue.I(5));f.Pc=362;continue;}
case 362:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=365;continue;}
case 365:{f.StackOp("dup");f.Pc=366;continue;}
case 366:{f.Push(JValue.I(0));f.Pc=367;continue;}
case 367:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_DECKSEC_XMAGE","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_DECKSEC_XMAGE","Ljava/lang/String;"));f.Pc=370;continue;}
case 370:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=371;continue;}
case 371:{f.StackOp("dup");f.Pc=372;continue;}
case 372:{f.Push(JValue.I(1));f.Pc=373;continue;}
case 373:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_COUNT","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CARD_COUNT","Ljava/lang/String;"));f.Pc=376;continue;}
case 376:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=377;continue;}
case 377:{f.StackOp("dup");f.Pc=378;continue;}
case 378:{f.Push(JValue.I(2));f.Pc=379;continue;}
case 379:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_NAME","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CARD_NAME","Ljava/lang/String;"));f.Pc=382;continue;}
case 382:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=383;continue;}
case 383:{f.StackOp("dup");f.Pc=384;continue;}
case 384:{f.Push(JValue.I(3));f.Pc=385;continue;}
case 385:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_SET_CODE","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_SET_CODE","Ljava/lang/String;"));f.Pc=388;continue;}
case 388:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=389;continue;}
case 389:{f.StackOp("dup");f.Pc=390;continue;}
case 390:{f.Push(JValue.I(4));f.Pc=391;continue;}
case 391:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_FOIL_MTGGOLDFISH","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_FOIL_MTGGOLDFISH","Ljava/lang/String;"));f.Pc=394;continue;}
case 394:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=395;continue;}
case 395:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",398);}
case 398:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_SET_REQUEST","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_CARD_SET_REQUEST","Ljava/lang/String;",f.Pop());f.Pc=401;continue;}
case 401:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_SET_REQUEST","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CARD_SET_REQUEST","Ljava/lang/String;"));f.Pc=404;continue;}
case 404:{f.Push(JValue.I(0));f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/deck/DeckRecognizer","compilePattern","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",408);}
case 408:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","CARD_SET_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","CARD_SET_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=411;continue;}
case 411:{f.Push(JValue.R(rt.String("(%s\\s*:\\s*)?(%s\\s)?\\s*(\\(|\\[|\\{)?%s(\\s+|\\)|\\]|\\}|\\|)\\s*%s\\s*%s\\s*")));f.Pc=414;continue;}
case 414:{f.Push(JValue.I(5));f.Pc=415;continue;}
case 415:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=418;continue;}
case 418:{f.StackOp("dup");f.Pc=419;continue;}
case 419:{f.Push(JValue.I(0));f.Pc=420;continue;}
case 420:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_DECKSEC_XMAGE","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_DECKSEC_XMAGE","Ljava/lang/String;"));f.Pc=423;continue;}
case 423:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=424;continue;}
case 424:{f.StackOp("dup");f.Pc=425;continue;}
case 425:{f.Push(JValue.I(1));f.Pc=426;continue;}
case 426:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_COUNT","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CARD_COUNT","Ljava/lang/String;"));f.Pc=429;continue;}
case 429:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=430;continue;}
case 430:{f.StackOp("dup");f.Pc=431;continue;}
case 431:{f.Push(JValue.I(2));f.Pc=432;continue;}
case 432:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_SET_CODE","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_SET_CODE","Ljava/lang/String;"));f.Pc=435;continue;}
case 435:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=436;continue;}
case 436:{f.StackOp("dup");f.Pc=437;continue;}
case 437:{f.Push(JValue.I(3));f.Pc=438;continue;}
case 438:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_NAME","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CARD_NAME","Ljava/lang/String;"));f.Pc=441;continue;}
case 441:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=442;continue;}
case 442:{f.StackOp("dup");f.Pc=443;continue;}
case 443:{f.Push(JValue.I(4));f.Pc=444;continue;}
case 444:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_FOIL_MTGGOLDFISH","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_FOIL_MTGGOLDFISH","Ljava/lang/String;"));f.Pc=447;continue;}
case 447:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=448;continue;}
case 448:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",451);}
case 451:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_SET_CARD_REQUEST","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_SET_CARD_REQUEST","Ljava/lang/String;",f.Pop());f.Pc=454;continue;}
case 454:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_SET_CARD_REQUEST","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_SET_CARD_REQUEST","Ljava/lang/String;"));f.Pc=457;continue;}
case 457:{f.Push(JValue.I(0));f.Pc=458;continue;}
case 458:{return rt.Call(f,"forge/deck/DeckRecognizer","compilePattern","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",461);}
case 461:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","SET_CARD_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","SET_CARD_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=464;continue;}
case 464:{f.Push(JValue.R(rt.String("(%s\\s*:\\s*)?(%s\\s)?\\s*%s\\s*(\\||\\(|\\[|\\{|\\s)%s(\\s|\\)|\\]|\\})?(\\s+|\\|\\s*)%s\\s*%s\\s*")));f.Pc=467;continue;}
case 467:{f.Push(JValue.I(6));f.Pc=469;continue;}
case 469:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=472;continue;}
case 472:{f.StackOp("dup");f.Pc=473;continue;}
case 473:{f.Push(JValue.I(0));f.Pc=474;continue;}
case 474:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_DECKSEC_XMAGE","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_DECKSEC_XMAGE","Ljava/lang/String;"));f.Pc=477;continue;}
case 477:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=478;continue;}
case 478:{f.StackOp("dup");f.Pc=479;continue;}
case 479:{f.Push(JValue.I(1));f.Pc=480;continue;}
case 480:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_COUNT","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CARD_COUNT","Ljava/lang/String;"));f.Pc=483;continue;}
case 483:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=484;continue;}
case 484:{f.StackOp("dup");f.Pc=485;continue;}
case 485:{f.Push(JValue.I(2));f.Pc=486;continue;}
case 486:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_NAME","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CARD_NAME","Ljava/lang/String;"));f.Pc=489;continue;}
case 489:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=490;continue;}
case 490:{f.StackOp("dup");f.Pc=491;continue;}
case 491:{f.Push(JValue.I(3));f.Pc=492;continue;}
case 492:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_SET_CODE","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_SET_CODE","Ljava/lang/String;"));f.Pc=495;continue;}
case 495:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=496;continue;}
case 496:{f.StackOp("dup");f.Pc=497;continue;}
case 497:{f.Push(JValue.I(4));f.Pc=498;continue;}
case 498:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_COLL_NUMBER","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_COLL_NUMBER","Ljava/lang/String;"));f.Pc=501;continue;}
case 501:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=502;continue;}
case 502:{f.StackOp("dup");f.Pc=503;continue;}
case 503:{f.Push(JValue.I(5));f.Pc=504;continue;}
case 504:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_FOIL_MTGGOLDFISH","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_FOIL_MTGGOLDFISH","Ljava/lang/String;"));f.Pc=507;continue;}
case 507:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=508;continue;}
case 508:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",511);}
case 511:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_FULL_REQUEST_CARD_SET","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_FULL_REQUEST_CARD_SET","Ljava/lang/String;",f.Pop());f.Pc=514;continue;}
case 514:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_FULL_REQUEST_CARD_SET","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_FULL_REQUEST_CARD_SET","Ljava/lang/String;"));f.Pc=517;continue;}
case 517:{f.Push(JValue.I(0));f.Pc=518;continue;}
case 518:{return rt.Call(f,"forge/deck/DeckRecognizer","compilePattern","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",521);}
case 521:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","CARD_SET_COLLNO_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","CARD_SET_COLLNO_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=524;continue;}
case 524:{f.Push(JValue.R(rt.String("^(%s\\s*:\\s*)?(%s\\s)?\\s*(\\(|\\[|\\{)?%s(\\s+|\\)|\\]|\\}|\\|)\\s*%s(\\s+|\\|\\s*)%s\\s*%s$")));f.Pc=527;continue;}
case 527:{f.Push(JValue.I(6));f.Pc=529;continue;}
case 529:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=532;continue;}
case 532:{f.StackOp("dup");f.Pc=533;continue;}
case 533:{f.Push(JValue.I(0));f.Pc=534;continue;}
case 534:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_DECKSEC_XMAGE","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_DECKSEC_XMAGE","Ljava/lang/String;"));f.Pc=537;continue;}
case 537:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=538;continue;}
case 538:{f.StackOp("dup");f.Pc=539;continue;}
case 539:{f.Push(JValue.I(1));f.Pc=540;continue;}
case 540:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_COUNT","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CARD_COUNT","Ljava/lang/String;"));f.Pc=543;continue;}
case 543:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=544;continue;}
case 544:{f.StackOp("dup");f.Pc=545;continue;}
case 545:{f.Push(JValue.I(2));f.Pc=546;continue;}
case 546:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_SET_CODE","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_SET_CODE","Ljava/lang/String;"));f.Pc=549;continue;}
case 549:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=550;continue;}
case 550:{f.StackOp("dup");f.Pc=551;continue;}
case 551:{f.Push(JValue.I(3));f.Pc=552;continue;}
case 552:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_NAME","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CARD_NAME","Ljava/lang/String;"));f.Pc=555;continue;}
case 555:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=556;continue;}
case 556:{f.StackOp("dup");f.Pc=557;continue;}
case 557:{f.Push(JValue.I(4));f.Pc=558;continue;}
case 558:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_COLL_NUMBER","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_COLL_NUMBER","Ljava/lang/String;"));f.Pc=561;continue;}
case 561:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=562;continue;}
case 562:{f.StackOp("dup");f.Pc=563;continue;}
case 563:{f.Push(JValue.I(5));f.Pc=564;continue;}
case 564:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_FOIL_MTGGOLDFISH","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_FOIL_MTGGOLDFISH","Ljava/lang/String;"));f.Pc=567;continue;}
case 567:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=568;continue;}
case 568:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",571);}
case 571:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_FULL_REQUEST_SET_CARD","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_FULL_REQUEST_SET_CARD","Ljava/lang/String;",f.Pop());f.Pc=574;continue;}
case 574:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_FULL_REQUEST_SET_CARD","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_FULL_REQUEST_SET_CARD","Ljava/lang/String;"));f.Pc=577;continue;}
case 577:{f.Push(JValue.I(0));f.Pc=578;continue;}
case 578:{return rt.Call(f,"forge/deck/DeckRecognizer","compilePattern","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",581);}
case 581:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","SET_CARD_COLLNO_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","SET_CARD_COLLNO_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=584;continue;}
case 584:{f.Push(JValue.R(rt.String("^(%s\\s*:\\s*)?(%s\\s)?\\s*%s\\s+(\\<%s\\>)\\s*(\\(|\\[|\\{)?%s(\\s+|\\)|\\]|\\}|\\|)\\s*%s$")));f.Pc=587;continue;}
case 587:{f.Push(JValue.I(6));f.Pc=589;continue;}
case 589:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=592;continue;}
case 592:{f.StackOp("dup");f.Pc=593;continue;}
case 593:{f.Push(JValue.I(0));f.Pc=594;continue;}
case 594:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_DECKSEC_XMAGE","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_DECKSEC_XMAGE","Ljava/lang/String;"));f.Pc=597;continue;}
case 597:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=598;continue;}
case 598:{f.StackOp("dup");f.Pc=599;continue;}
case 599:{f.Push(JValue.I(1));f.Pc=600;continue;}
case 600:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_COUNT","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CARD_COUNT","Ljava/lang/String;"));f.Pc=603;continue;}
case 603:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=604;continue;}
case 604:{f.StackOp("dup");f.Pc=605;continue;}
case 605:{f.Push(JValue.I(2));f.Pc=606;continue;}
case 606:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_NAME","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CARD_NAME","Ljava/lang/String;"));f.Pc=609;continue;}
case 609:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=610;continue;}
case 610:{f.StackOp("dup");f.Pc=611;continue;}
case 611:{f.Push(JValue.I(3));f.Pc=612;continue;}
case 612:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_COLL_NUMBER","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_COLL_NUMBER","Ljava/lang/String;"));f.Pc=615;continue;}
case 615:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=616;continue;}
case 616:{f.StackOp("dup");f.Pc=617;continue;}
case 617:{f.Push(JValue.I(4));f.Pc=618;continue;}
case 618:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_SET_CODE","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_SET_CODE","Ljava/lang/String;"));f.Pc=621;continue;}
case 621:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=622;continue;}
case 622:{f.StackOp("dup");f.Pc=623;continue;}
case 623:{f.Push(JValue.I(5));f.Pc=624;continue;}
case 624:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_FOIL_MTGGOLDFISH","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_FOIL_MTGGOLDFISH","Ljava/lang/String;"));f.Pc=627;continue;}
case 627:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=628;continue;}
case 628:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",631);}
case 631:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_FULL_REQUEST_CARD_COLLNO_SET","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_FULL_REQUEST_CARD_COLLNO_SET","Ljava/lang/String;",f.Pop());f.Pc=634;continue;}
case 634:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_FULL_REQUEST_CARD_COLLNO_SET","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_FULL_REQUEST_CARD_COLLNO_SET","Ljava/lang/String;"));f.Pc=637;continue;}
case 637:{f.Push(JValue.I(0));f.Pc=638;continue;}
case 638:{return rt.Call(f,"forge/deck/DeckRecognizer","compilePattern","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",641);}
case 641:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","CARD_COLLNO_SET_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","CARD_COLLNO_SET_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=644;continue;}
case 644:{f.Push(JValue.R(rt.String("^(%s\\s*:\\s*)?(%s\\s)?\\s*(\\[)?%s:%s(\\])\\s+%s\\s*%s$")));f.Pc=647;continue;}
case 647:{f.Push(JValue.I(6));f.Pc=649;continue;}
case 649:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=652;continue;}
case 652:{f.StackOp("dup");f.Pc=653;continue;}
case 653:{f.Push(JValue.I(0));f.Pc=654;continue;}
case 654:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_DECKSEC_XMAGE","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_DECKSEC_XMAGE","Ljava/lang/String;"));f.Pc=657;continue;}
case 657:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=658;continue;}
case 658:{f.StackOp("dup");f.Pc=659;continue;}
case 659:{f.Push(JValue.I(1));f.Pc=660;continue;}
case 660:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_COUNT","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CARD_COUNT","Ljava/lang/String;"));f.Pc=663;continue;}
case 663:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=664;continue;}
case 664:{f.StackOp("dup");f.Pc=665;continue;}
case 665:{f.Push(JValue.I(2));f.Pc=666;continue;}
case 666:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_SET_CODE","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_SET_CODE","Ljava/lang/String;"));f.Pc=669;continue;}
case 669:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=670;continue;}
case 670:{f.StackOp("dup");f.Pc=671;continue;}
case 671:{f.Push(JValue.I(3));f.Pc=672;continue;}
case 672:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_COLL_NUMBER","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_COLL_NUMBER","Ljava/lang/String;"));f.Pc=675;continue;}
case 675:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=676;continue;}
case 676:{f.StackOp("dup");f.Pc=677;continue;}
case 677:{f.Push(JValue.I(4));f.Pc=678;continue;}
case 678:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_NAME","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CARD_NAME","Ljava/lang/String;"));f.Pc=681;continue;}
case 681:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=682;continue;}
case 682:{f.StackOp("dup");f.Pc=683;continue;}
case 683:{f.Push(JValue.I(5));f.Pc=684;continue;}
case 684:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_FOIL_MTGGOLDFISH","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_FOIL_MTGGOLDFISH","Ljava/lang/String;"));f.Pc=687;continue;}
case 687:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=688;continue;}
case 688:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",691);}
case 691:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_FULL_REQUEST_XMAGE","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_FULL_REQUEST_XMAGE","Ljava/lang/String;",f.Pop());f.Pc=694;continue;}
case 694:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_FULL_REQUEST_XMAGE","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_FULL_REQUEST_XMAGE","Ljava/lang/String;"));f.Pc=697;continue;}
case 697:{f.Push(JValue.I(0));f.Pc=698;continue;}
case 698:{return rt.Call(f,"forge/deck/DeckRecognizer","compilePattern","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",701);}
case 701:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","SET_COLLNO_CARD_XMAGE_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","SET_COLLNO_CARD_XMAGE_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=704;continue;}
case 704:{f.Push(JValue.R(rt.String("(%s\\s*:\\s*)?(%s\\s)?\\s*%s\\s*%s")));f.Pc=707;continue;}
case 707:{f.Push(JValue.I(4));f.Pc=708;continue;}
case 708:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=711;continue;}
case 711:{f.StackOp("dup");f.Pc=712;continue;}
case 712:{f.Push(JValue.I(0));f.Pc=713;continue;}
case 713:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_DECKSEC_XMAGE","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_DECKSEC_XMAGE","Ljava/lang/String;"));f.Pc=716;continue;}
case 716:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=717;continue;}
case 717:{f.StackOp("dup");f.Pc=718;continue;}
case 718:{f.Push(JValue.I(1));f.Pc=719;continue;}
case 719:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_COUNT","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CARD_COUNT","Ljava/lang/String;"));f.Pc=722;continue;}
case 722:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=723;continue;}
case 723:{f.StackOp("dup");f.Pc=724;continue;}
case 724:{f.Push(JValue.I(2));f.Pc=725;continue;}
case 725:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARD_NAME","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CARD_NAME","Ljava/lang/String;"));f.Pc=728;continue;}
case 728:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=729;continue;}
case 729:{f.StackOp("dup");f.Pc=730;continue;}
case 730:{f.Push(JValue.I(3));f.Pc=731;continue;}
case 731:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_FOIL_MTGGOLDFISH","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_FOIL_MTGGOLDFISH","Ljava/lang/String;"));f.Pc=734;continue;}
case 734:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=735;continue;}
case 735:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",738);}
case 738:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARDONLY","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","REX_CARDONLY","Ljava/lang/String;",f.Pop());f.Pc=741;continue;}
case 741:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","REX_CARDONLY","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer","REX_CARDONLY","Ljava/lang/String;"));f.Pc=744;continue;}
case 744:{f.Push(JValue.I(0));f.Pc=745;continue;}
case 745:{return rt.Call(f,"forge/deck/DeckRecognizer","compilePattern","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",748);}
case 748:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","CARD_ONLY_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","CARD_ONLY_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=751;continue;}
case 751:{return rt.Call(f,"forge/deck/DeckRecognizer","allCardTypes","()[Ljava/lang/CharSequence;","invokestatic",754);}
case 754:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","CARD_TYPES","[Ljava/lang/CharSequence;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","CARD_TYPES","[Ljava/lang/CharSequence;",f.Pop());f.Pc=757;continue;}
case 757:{f.Push(JValue.I(15));f.Pc=759;continue;}
case 759:{f.Push(JValue.R(rt.NewArray("Ljava/lang/CharSequence;",f.Pop().Int)));f.Pc=762;continue;}
case 762:{f.StackOp("dup");f.Pc=763;continue;}
case 763:{f.Push(JValue.I(0));f.Pc=764;continue;}
case 764:{f.Push(JValue.R(rt.String("side")));f.Pc=767;continue;}
case 767:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=768;continue;}
case 768:{f.StackOp("dup");f.Pc=769;continue;}
case 769:{f.Push(JValue.I(1));f.Pc=770;continue;}
case 770:{f.Push(JValue.R(rt.String("sideboard")));f.Pc=773;continue;}
case 773:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=774;continue;}
case 774:{f.StackOp("dup");f.Pc=775;continue;}
case 775:{f.Push(JValue.I(2));f.Pc=776;continue;}
case 776:{f.Push(JValue.R(rt.String("sb")));f.Pc=779;continue;}
case 779:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=780;continue;}
case 780:{f.StackOp("dup");f.Pc=781;continue;}
case 781:{f.Push(JValue.I(3));f.Pc=782;continue;}
case 782:{f.Push(JValue.R(rt.String("main")));f.Pc=785;continue;}
case 785:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=786;continue;}
case 786:{f.StackOp("dup");f.Pc=787;continue;}
case 787:{f.Push(JValue.I(4));f.Pc=788;continue;}
case 788:{f.Push(JValue.R(rt.String("card")));f.Pc=791;continue;}
case 791:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=792;continue;}
case 792:{f.StackOp("dup");f.Pc=793;continue;}
case 793:{f.Push(JValue.I(5));f.Pc=794;continue;}
case 794:{f.Push(JValue.R(rt.String("mainboard")));f.Pc=797;continue;}
case 797:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=798;continue;}
case 798:{f.StackOp("dup");f.Pc=799;continue;}
case 799:{f.Push(JValue.I(6));f.Pc=801;continue;}
case 801:{f.Push(JValue.R(rt.String("avatar")));f.Pc=804;continue;}
case 804:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=805;continue;}
case 805:{f.StackOp("dup");f.Pc=806;continue;}
case 806:{f.Push(JValue.I(7));f.Pc=808;continue;}
case 808:{f.Push(JValue.R(rt.String("commander")));f.Pc=811;continue;}
case 811:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=812;continue;}
case 812:{f.StackOp("dup");f.Pc=813;continue;}
case 813:{f.Push(JValue.I(8));f.Pc=815;continue;}
case 815:{f.Push(JValue.R(rt.String("schemes")));f.Pc=818;continue;}
case 818:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=819;continue;}
case 819:{f.StackOp("dup");f.Pc=820;continue;}
case 820:{f.Push(JValue.I(9));f.Pc=822;continue;}
case 822:{f.Push(JValue.R(rt.String("conspiracy")));f.Pc=825;continue;}
case 825:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=826;continue;}
case 826:{f.StackOp("dup");f.Pc=827;continue;}
case 827:{f.Push(JValue.I(10));f.Pc=829;continue;}
case 829:{f.Push(JValue.R(rt.String("planes")));f.Pc=832;continue;}
case 832:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=833;continue;}
case 833:{f.StackOp("dup");f.Pc=834;continue;}
case 834:{f.Push(JValue.I(11));f.Pc=836;continue;}
case 836:{f.Push(JValue.R(rt.String("deck")));f.Pc=839;continue;}
case 839:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=840;continue;}
case 840:{f.StackOp("dup");f.Pc=841;continue;}
case 841:{f.Push(JValue.I(12));f.Pc=843;continue;}
case 843:{f.Push(JValue.R(rt.String("dungeon")));f.Pc=846;continue;}
case 846:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=847;continue;}
case 847:{f.StackOp("dup");f.Pc=848;continue;}
case 848:{f.Push(JValue.I(13));f.Pc=850;continue;}
case 850:{f.Push(JValue.R(rt.String("attractions")));f.Pc=853;continue;}
case 853:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=854;continue;}
case 854:{f.StackOp("dup");f.Pc=855;continue;}
case 855:{f.Push(JValue.I(14));f.Pc=857;continue;}
case 857:{f.Push(JValue.R(rt.String("contraptions")));f.Pc=860;continue;}
case 860:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=861;continue;}
case 861:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer","DECK_SECTION_NAMES","[Ljava/lang/CharSequence;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer","DECK_SECTION_NAMES","[Ljava/lang/CharSequence;",f.Pop());f.Pc=864;continue;}
case 864:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
