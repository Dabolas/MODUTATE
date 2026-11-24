// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C65{
internal static JClass Build(){var c=new JClass("forge/card/ICardDatabase","java/lang/Object",new string[]{"java/lang/Iterable"},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(1069,"forge/card/ICardDatabase","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1070,"forge/card/ICardDatabase","getCard","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1071,"forge/card/ICardDatabase","getCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperCard;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1072,"forge/card/ICardDatabase","getCard","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1073,"forge/card/ICardDatabase","getCard","(Ljava/lang/String;Ljava/lang/String;ILjava/util/Map;)Lforge/item/PaperCard;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1074,"forge/card/ICardDatabase","getCard","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Lforge/item/PaperCard;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1075,"forge/card/ICardDatabase","getCardFromSet","(Ljava/lang/String;Lforge/card/CardEdition;Z)Lforge/item/PaperCard;",1,4,6,new JHandler[]{},M1075));
c.Add(new JMethod(1076,"forge/card/ICardDatabase","getCardFromSet","(Ljava/lang/String;Lforge/card/CardEdition;Ljava/lang/String;Z)Lforge/item/PaperCard;",1,5,6,new JHandler[]{},M1076));
c.Add(new JMethod(1077,"forge/card/ICardDatabase","getCardFromSet","(Ljava/lang/String;Lforge/card/CardEdition;IZ)Lforge/item/PaperCard;",1,5,6,new JHandler[]{},M1077));
c.Add(new JMethod(1078,"forge/card/ICardDatabase","getCardFromSet","(Ljava/lang/String;Lforge/card/CardEdition;ILjava/lang/String;Z)Lforge/item/PaperCard;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1079,"forge/card/ICardDatabase","getCardFromEditions","(Ljava/lang/String;)Lforge/item/PaperCard;",1,2,5,new JHandler[]{},M1079));
c.Add(new JMethod(1080,"forge/card/ICardDatabase","getCardFromEditions","(Ljava/lang/String;Ljava/util/function/Predicate;)Lforge/item/PaperCard;",1,3,5,new JHandler[]{},M1080));
c.Add(new JMethod(1081,"forge/card/ICardDatabase","getCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;)Lforge/item/PaperCard;",1,3,5,new JHandler[]{},M1081));
c.Add(new JMethod(1082,"forge/card/ICardDatabase","getCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;Ljava/util/function/Predicate;)Lforge/item/PaperCard;",1,4,5,new JHandler[]{},M1082));
c.Add(new JMethod(1083,"forge/card/ICardDatabase","getCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;I)Lforge/item/PaperCard;",1,4,5,new JHandler[]{},M1083));
c.Add(new JMethod(1084,"forge/card/ICardDatabase","getCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/function/Predicate;)Lforge/item/PaperCard;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1085,"forge/card/ICardDatabase","getCardFromEditionsReleasedBefore","(Ljava/lang/String;Ljava/util/Date;)Lforge/item/PaperCard;",1,3,6,new JHandler[]{},M1085));
c.Add(new JMethod(1086,"forge/card/ICardDatabase","getCardFromEditionsReleasedBefore","(Ljava/lang/String;ILjava/util/Date;)Lforge/item/PaperCard;",1,4,6,new JHandler[]{},M1086));
c.Add(new JMethod(1087,"forge/card/ICardDatabase","getCardFromEditionsReleasedBefore","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;Ljava/util/Date;)Lforge/item/PaperCard;",1,4,6,new JHandler[]{},M1087));
c.Add(new JMethod(1088,"forge/card/ICardDatabase","getCardFromEditionsReleasedBefore","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;Ljava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;",1,5,6,new JHandler[]{},M1088));
c.Add(new JMethod(1089,"forge/card/ICardDatabase","getCardFromEditionsReleasedBefore","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;)Lforge/item/PaperCard;",1,5,6,new JHandler[]{},M1089));
c.Add(new JMethod(1090,"forge/card/ICardDatabase","getCardFromEditionsReleasedBefore","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1091,"forge/card/ICardDatabase","getCardFromEditionsReleasedAfter","(Ljava/lang/String;Ljava/util/Date;)Lforge/item/PaperCard;",1,3,6,new JHandler[]{},M1091));
c.Add(new JMethod(1092,"forge/card/ICardDatabase","getCardFromEditionsReleasedAfter","(Ljava/lang/String;ILjava/util/Date;)Lforge/item/PaperCard;",1,4,6,new JHandler[]{},M1092));
c.Add(new JMethod(1093,"forge/card/ICardDatabase","getCardFromEditionsReleasedAfter","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;Ljava/util/Date;)Lforge/item/PaperCard;",1,4,6,new JHandler[]{},M1093));
c.Add(new JMethod(1094,"forge/card/ICardDatabase","getCardFromEditionsReleasedAfter","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;Ljava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;",1,5,6,new JHandler[]{},M1094));
c.Add(new JMethod(1095,"forge/card/ICardDatabase","getCardFromEditionsReleasedAfter","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;)Lforge/item/PaperCard;",1,5,6,new JHandler[]{},M1095));
c.Add(new JMethod(1096,"forge/card/ICardDatabase","getCardFromEditionsReleasedAfter","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1097,"forge/card/ICardDatabase","getAllCards","()Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1098,"forge/card/ICardDatabase","getAllCards","(Ljava/lang/String;)Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1099,"forge/card/ICardDatabase","getAllCards","(Ljava/util/function/Predicate;)Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1100,"forge/card/ICardDatabase","getAllCards","(Ljava/lang/String;Ljava/util/function/Predicate;)Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1101,"forge/card/ICardDatabase","getAllCards","(Lforge/card/CardEdition;)Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1102,"forge/card/ICardDatabase","getAllCardsNoAlt","(Ljava/lang/String;Ljava/util/function/Predicate;)Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1103,"forge/card/ICardDatabase","getUniqueCards","()Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1104,"forge/card/ICardDatabase","getUniqueByName","(Ljava/lang/String;)Lforge/item/PaperCard;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1105,"forge/card/ICardDatabase","getUniqueByNameNoAlt","(Ljava/lang/String;)Lforge/item/PaperCard;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1106,"forge/card/ICardDatabase","getAllFaces","()Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1107,"forge/card/ICardDatabase","getFaceByName","(Ljava/lang/String;)Lforge/card/ICardFace;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1108,"forge/card/ICardDatabase","streamAllCards","()Ljava/util/stream/Stream;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1109,"forge/card/ICardDatabase","streamUniqueCards","()Ljava/util/stream/Stream;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1110,"forge/card/ICardDatabase","streamAllFaces","()Ljava/util/stream/Stream;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1111,"forge/card/ICardDatabase","getMaxArtIndex","(Ljava/lang/String;)I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1112,"forge/card/ICardDatabase","getArtCount","(Ljava/lang/String;Ljava/lang/String;)I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1113,"forge/card/ICardDatabase","wasPrintedInSets","(Ljava/util/Collection;)Ljava/util/function/Predicate;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1114,"forge/card/ICardDatabase","isLegal","(Ljava/util/Collection;)Ljava/util/function/Predicate;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1115,"forge/card/ICardDatabase","wasPrintedAtRarity","(Lforge/card/CardRarity;)Ljava/util/function/Predicate;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1116,"forge/card/ICardDatabase","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;",1025,0,0,new JHandler[]{},null));
}

internal static JStep M1075(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(-1));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("N.A.")));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromSet","(Ljava/lang/String;Lforge/card/CardEdition;ILjava/lang/String;Z)Lforge/item/PaperCard;","invokeinterface",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1076(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(-1));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromSet","(Ljava/lang/String;Lforge/card/CardEdition;ILjava/lang/String;Z)Lforge/item/PaperCard;","invokeinterface",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1077(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("N.A.")));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromSet","(Ljava/lang/String;Lforge/card/CardEdition;ILjava/lang/String;Z)Lforge/item/PaperCard;","invokeinterface",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1079(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/ICardDatabase","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokeinterface",8);}
case 8:{f.Push(JValue.I(-1));f.Pc=9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/function/Predicate;)Lforge/item/PaperCard;","invokeinterface",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1080(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/ICardDatabase","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokeinterface",8);}
case 8:{f.Push(JValue.I(-1));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/function/Predicate;)Lforge/item/PaperCard;","invokeinterface",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1081(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(-1));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/function/Predicate;)Lforge/item/PaperCard;","invokeinterface",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1082(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(-1));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/function/Predicate;)Lforge/item/PaperCard;","invokeinterface",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1083(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/function/Predicate;)Lforge/item/PaperCard;","invokeinterface",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1085(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/ICardDatabase","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokeinterface",8);}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromEditionsReleasedBefore","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokeinterface",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1086(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/ICardDatabase","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokeinterface",8);}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromEditionsReleasedBefore","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokeinterface",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1087(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromEditionsReleasedBefore","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokeinterface",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1088(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromEditionsReleasedBefore","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokeinterface",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1089(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromEditionsReleasedBefore","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokeinterface",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1091(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/ICardDatabase","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokeinterface",8);}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromEditionsReleasedAfter","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokeinterface",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1092(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/ICardDatabase","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokeinterface",8);}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromEditionsReleasedAfter","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokeinterface",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1093(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromEditionsReleasedAfter","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokeinterface",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1094(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromEditionsReleasedAfter","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokeinterface",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1095(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/ICardDatabase","getCardFromEditionsReleasedAfter","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokeinterface",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
