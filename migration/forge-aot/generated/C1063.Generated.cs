// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1063{
internal static JClass Build(){var c=new JClass("forge/item/PaperCard","java/lang/Object",new string[]{"java/lang/Comparable","forge/item/InventoryItemFromSet","forge/item/IPaperCard"},33);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(2942081982620691205L),null));
c.Add(new JField("rules","Lforge/card/CardRules;",false,JValue.Default("Lforge/card/CardRules;"),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("edition","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("collectorNumber","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("artist","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("artIndex","I",false,JValue.Default("I"),null));
c.Add(new JField("foil","Z",false,JValue.Default("Z"),null));
c.Add(new JField("flags","Lforge/item/PaperCard$PaperCardFlags;",false,JValue.Default("Lforge/item/PaperCard$PaperCardFlags;"),null));
c.Add(new JField("functionalVariant","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("rarity","Lforge/card/CardRarity;",false,JValue.Default("Lforge/card/CardRarity;"),null));
c.Add(new JField("foiledVersion","Lforge/item/PaperCard;",false,JValue.Default("Lforge/item/PaperCard;"),null));
c.Add(new JField("noSellVersion","Lforge/item/PaperCard;",false,JValue.Default("Lforge/item/PaperCard;"),null));
c.Add(new JField("flaglessVersion","Lforge/item/PaperCard;",false,JValue.Default("Lforge/item/PaperCard;"),null));
c.Add(new JField("hasImage","Ljava/lang/Boolean;",false,JValue.Default("Ljava/lang/Boolean;"),null));
c.Add(new JField("displayName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sortableName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("hasFlavorName","Z",false,JValue.Default("Z"),null));
c.Add(new JField("FAKE_CARD","Lforge/item/PaperCard;",true,JValue.Default("Lforge/item/PaperCard;"),null));
c.Add(new JField("searchableNames","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("searchableNameLang","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sortableCNKey","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("cardImageKey","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("cardAltImageKey","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(11246,"forge/item/PaperCard","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11246));
c.Add(new JMethod(11247,"forge/item/PaperCard","getEdition","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11247));
c.Add(new JMethod(11248,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;",1,1,2,new JHandler[]{},M11248));
c.Add(new JMethod(11249,"forge/item/PaperCard","getFunctionalVariant","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11249));
c.Add(new JMethod(11250,"forge/item/PaperCard","getMarkedColors","()Lforge/card/ColorSet;",1,1,1,new JHandler[]{},M11250));
c.Add(new JMethod(11251,"forge/item/PaperCard","getArtIndex","()I",1,1,1,new JHandler[]{},M11251));
c.Add(new JMethod(11252,"forge/item/PaperCard","isFoil","()Z",1,1,1,new JHandler[]{},M11252));
c.Add(new JMethod(11253,"forge/item/PaperCard","isToken","()Z",1,1,1,new JHandler[]{},M11253));
c.Add(new JMethod(11254,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;",1,1,1,new JHandler[]{},M11254));
c.Add(new JMethod(11255,"forge/item/PaperCard","getRarity","()Lforge/card/CardRarity;",1,1,1,new JHandler[]{},M11255));
c.Add(new JMethod(11256,"forge/item/PaperCard","getArtist","()Ljava/lang/String;",1,1,2,new JHandler[]{},M11256));
c.Add(new JMethod(11257,"forge/item/PaperCard","getFoiled","()Lforge/item/PaperCard;",1,1,11,new JHandler[]{},M11257));
c.Add(new JMethod(11258,"forge/item/PaperCard","getUnFoiled","()Lforge/item/PaperCard;",1,2,10,new JHandler[]{},M11258));
c.Add(new JMethod(11259,"forge/item/PaperCard","getNoSellVersion","()Lforge/item/PaperCard;",1,1,6,new JHandler[]{},M11259));
c.Add(new JMethod(11260,"forge/item/PaperCard","getMeldBaseCard","()Lforge/item/PaperCard;",1,5,2,new JHandler[]{},M11260));
c.Add(new JMethod(11261,"forge/item/PaperCard","copyWithoutFlags","()Lforge/item/PaperCard;",1,1,5,new JHandler[]{},M11261));
c.Add(new JMethod(11262,"forge/item/PaperCard","copyWithFlags","(Ljava/util/Map;)Lforge/item/PaperCard;",1,2,6,new JHandler[]{},M11262));
c.Add(new JMethod(11263,"forge/item/PaperCard","copyWithMarkedColors","(Lforge/card/ColorSet;)Lforge/item/PaperCard;",1,2,5,new JHandler[]{},M11263));
c.Add(new JMethod(11264,"forge/item/PaperCard","getItemType","()Ljava/lang/String;",1,2,3,new JHandler[]{},M11264));
c.Add(new JMethod(11265,"forge/item/PaperCard","getMarkedFlags","()Lforge/item/PaperCard$PaperCardFlags;",1,1,1,new JHandler[]{},M11265));
c.Add(new JMethod(11266,"forge/item/PaperCard","hasNoSellValue","()Z",1,1,1,new JHandler[]{},M11266));
c.Add(new JMethod(11267,"forge/item/PaperCard","hasImage","()Z",1,1,2,new JHandler[]{},M11267));
c.Add(new JMethod(11268,"forge/item/PaperCard","hasImage","(Z)Z",1,2,3,new JHandler[]{},M11268));
c.Add(new JMethod(11269,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;)V",1,4,9,new JHandler[]{},M11269));
c.Add(new JMethod(11270,"forge/item/PaperCard","<init>","(Lforge/item/PaperCard;Lforge/item/PaperCard$PaperCardFlags;)V",1,3,10,new JHandler[]{},M11270));
c.Add(new JMethod(11271,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;IZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",1,9,10,new JHandler[]{},M11271));
c.Add(new JMethod(11272,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;IZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/item/PaperCard$PaperCardFlags;)V",4,10,3,new JHandler[]{},M11272));
c.Add(new JMethod(11273,"forge/item/PaperCard","equals","(Ljava/lang/Object;)Z",1,3,2,new JHandler[]{},M11273));
c.Add(new JMethod(11274,"forge/item/PaperCard","hashCode","()I",1,1,4,new JHandler[]{},M11274));
c.Add(new JMethod(11275,"forge/item/PaperCard","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11275));
c.Add(new JMethod(11276,"forge/item/PaperCard","getCardName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11276));
c.Add(new JMethod(11277,"forge/item/PaperCard","getDisplayName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11277));
c.Add(new JMethod(11278,"forge/item/PaperCard","hasFlavorName","()Z",1,1,1,new JHandler[]{},M11278));
c.Add(new JMethod(11279,"forge/item/PaperCard","getAllSearchableNames","()Ljava/util/Set;",1,1,3,new JHandler[]{},M11279));
c.Add(new JMethod(11280,"forge/item/PaperCard","computeSearchableNames","(Ljava/lang/String;)Ljava/util/Set;",2,7,4,new JHandler[]{},M11280));
c.Add(new JMethod(11281,"forge/item/PaperCard","makeCollectorNumberSortingKey","(Ljava/lang/String;)Ljava/lang/String;",10,2,2,new JHandler[]{},M11281));
c.Add(new JMethod(11282,"forge/item/PaperCard","getCollectorNumberSortingKey","()Ljava/lang/String;",1,1,2,new JHandler[]{},M11282));
c.Add(new JMethod(11283,"forge/item/PaperCard","compareTo","(Lforge/item/IPaperCard;)I",1,7,2,new JHandler[]{},M11283));
c.Add(new JMethod(11284,"forge/item/PaperCard","readObject","(Ljava/io/ObjectInputStream;)V",2,3,4,new JHandler[]{},M11284));
c.Add(new JMethod(11285,"forge/item/PaperCard","readObjectAlternate","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/IPaperCard;",2,4,3,new JHandler[]{},M11285));
}

private static void Add1(JClass c){
c.Add(new JMethod(11286,"forge/item/PaperCard","readResolve","()Ljava/lang/Object;",2,1,4,new JHandler[]{},M11286));
c.Add(new JMethod(11287,"forge/item/PaperCard","getImageKey","(Z)Ljava/lang/String;",1,4,3,new JHandler[]{},M11287));
c.Add(new JMethod(11288,"forge/item/PaperCard","getCardImageKey","()Ljava/lang/String;",1,1,4,new JHandler[]{},M11288));
c.Add(new JMethod(11289,"forge/item/PaperCard","getCardAltImageKey","()Ljava/lang/String;",1,1,4,new JHandler[]{},M11289));
c.Add(new JMethod(11290,"forge/item/PaperCard","hasBackFace","()Z",1,2,2,new JHandler[]{},M11290));
c.Add(new JMethod(11291,"forge/item/PaperCard","getMainFace","()Lforge/card/ICardFace;",1,2,2,new JHandler[]{},M11291));
c.Add(new JMethod(11292,"forge/item/PaperCard","getOtherFace","()Lforge/card/ICardFace;",1,2,2,new JHandler[]{},M11292));
c.Add(new JMethod(11293,"forge/item/PaperCard","getAllFaces","()Ljava/util/List;",1,1,2,new JHandler[]{},M11293));
c.Add(new JMethod(11294,"forge/item/PaperCard","getVariantForFace","(Lforge/card/ICardFace;)Lforge/card/ICardFace;",2,3,6,new JHandler[]{},M11294));
c.Add(new JMethod(11295,"forge/item/PaperCard","isVeryBasicLand","()Z",1,1,2,new JHandler[]{},M11295));
c.Add(new JMethod(11296,"forge/item/PaperCard","getSortableName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11296));
c.Add(new JMethod(11297,"forge/item/PaperCard","isUnRebalanced","()Z",1,1,2,new JHandler[]{},M11297));
c.Add(new JMethod(11298,"forge/item/PaperCard","isRebalanced","()Z",1,1,2,new JHandler[]{},M11298));
c.Add(new JMethod(11299,"forge/item/PaperCard","compareTo","(Ljava/lang/Object;)I",4161,2,2,new JHandler[]{},M11299));
c.Add(new JMethod(11300,"forge/item/PaperCard","<clinit>","()V",8,0,5,new JHandler[]{},M11300));
}

internal static JStep M11246(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11247(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","edition","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11248(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","collectorNumber","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?13:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("N.A.")));f.Pc=10;continue;}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","collectorNumber","Ljava/lang/String;",value);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","collectorNumber","Ljava/lang/String;"));f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11249(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","functionalVariant","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11250(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","flags","Lforge/item/PaperCard$PaperCardFlags;"));f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","markedColors","Lforge/card/ColorSet;"));f.Pc=7;continue;}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11251(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artIndex","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11252(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","foil","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11253(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11254(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","rules","Lforge/card/CardRules;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11255(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","rarity","Lforge/card/CardRarity;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11256(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artist","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?13:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("")));f.Pc=10;continue;}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","artist","Ljava/lang/String;",value);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artist","Ljava/lang/String;"));f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11257(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","foil","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","foiledVersion","Lforge/item/PaperCard;"));f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference!=null?59:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","rules","Lforge/card/CardRules;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","edition","Ljava/lang/String;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","rarity","Lforge/card/CardRarity;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artIndex","I"));f.Pc=37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","collectorNumber","Ljava/lang/String;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",45);}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artist","Ljava/lang/String;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","functionalVariant","Ljava/lang/String;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;IZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",56);}
case 56:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","foiledVersion","Lforge/item/PaperCard;",value);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","foiledVersion","Lforge/item/PaperCard;"));f.Pc=63;continue;}
case 63:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11258(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","foil","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","rules","Lforge/card/CardRules;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","edition","Ljava/lang/String;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","rarity","Lforge/card/CardRarity;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artIndex","I"));f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","collectorNumber","Ljava/lang/String;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",37);}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artist","Ljava/lang/String;"));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","functionalVariant","Ljava/lang/String;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;IZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",48);}
case 48:{f.Locals[1]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11259(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","flags","Lforge/item/PaperCard$PaperCardFlags;"));f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","noSellValue","Z"));f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Int==0?12:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","noSellVersion","Lforge/item/PaperCard;"));f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Reference!=null?39:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","flags","Lforge/item/PaperCard$PaperCardFlags;"));f.Pc=29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/item/PaperCard$PaperCardFlags","withNoSellValueFlag","(Z)Lforge/item/PaperCard$PaperCardFlags;","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/item/PaperCard;Lforge/item/PaperCard$PaperCardFlags;)V","invokespecial",36);}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","noSellVersion","Lforge/item/PaperCard;",value);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","noSellVersion","Lforge/item/PaperCard;"));f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11260(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",7);}
case 7:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Meld","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Meld","Lforge/card/CardSplitType;"));f.Pc=10;continue;}
case 10:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?15:13;continue;}
case 13:{f.Push(JValue.R(null));f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",19);}
case 19:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Reference!=null?27:25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return JStep.Return(f.Pop());}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/card/CardRules","getMeldWith","()Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Locals[1]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Pc=f.Pop().Reference!=null?41:39;continue;}
case 39:{f.Push(JValue.R(null));f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
case 41:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",44);}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","edition","Ljava/lang/String;"));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/card/CardEdition","getPrintSheetsBySection","()Ljava/util/List;","invokevirtual",54);}
case 54:{f.Locals[2]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",61);}
case 61:{f.Locals[3]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",68);}
case 68:{f.Pc=f.Pop().Int==0?104:71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",77);}
case 77:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/PrintSheet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=80;continue;}
case 80:{f.Locals[4]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/card/PrintSheet","contains","(Lforge/item/PaperCard;)Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int==0?101:91;continue;}
case 91:{f.Push(f.Locals[4]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/item/PaperCardPredicates","name","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",97);}
case 97:{return rt.Call(f,"forge/card/PrintSheet","find","(Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokevirtual",100);}
case 100:{return JStep.Return(f.Pop());}
case 101:{f.Pc=62;continue;}
case 104:{f.Push(JValue.R(null));f.Pc=105;continue;}
case 105:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11261(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","flaglessVersion","Lforge/item/PaperCard;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?38:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","flags","Lforge/item/PaperCard$PaperCardFlags;"));f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/item/PaperCard$PaperCardFlags","IDENTITY_FLAGS","Lforge/item/PaperCard$PaperCardFlags;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCard$PaperCardFlags","IDENTITY_FLAGS","Lforge/item/PaperCard$PaperCardFlags;"));f.Pc=14;continue;}
case 14:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?25:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","flaglessVersion","Lforge/item/PaperCard;",value);f.Pc=22;continue;}
case 22:{f.Pc=38;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(null));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/item/PaperCard;Lforge/item/PaperCard$PaperCardFlags;)V","invokespecial",35);}
case 35:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","flaglessVersion","Lforge/item/PaperCard;",value);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","flaglessVersion","Lforge/item/PaperCard;"));f.Pc=42;continue;}
case 42:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11262(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?13:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?18:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/item/PaperCard","copyWithoutFlags","()Lforge/item/PaperCard;","invokevirtual",17);}
case 17:{return JStep.Return(f.Pop());}
case 18:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard")));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard$PaperCardFlags"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard$PaperCardFlags")));f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/item/PaperCard$PaperCardFlags","<init>","(Ljava/util/Map;)V","invokespecial",31);}
case 31:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/item/PaperCard;Lforge/item/PaperCard$PaperCardFlags;)V","invokespecial",34);}
case 34:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11263(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","flags","Lforge/item/PaperCard$PaperCardFlags;"));f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","markedColors","Lforge/card/ColorSet;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Objects","equals","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",11);}
case 11:{f.Pc=f.Pop().Int==0?16:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
case 16:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","flags","Lforge/item/PaperCard$PaperCardFlags;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/item/PaperCard$PaperCardFlags","withMarkedColors","(Lforge/card/ColorSet;)Lforge/item/PaperCard$PaperCardFlags;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/item/PaperCard;Lforge/item/PaperCard$PaperCardFlags;)V","invokespecial",32);}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11264(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("lblCard")));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11265(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","flags","Lforge/item/PaperCard$PaperCardFlags;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11266(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","flags","Lforge/item/PaperCard$PaperCardFlags;"));f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","noSellValue","Z"));f.Pc=7;continue;}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11267(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/PaperCard","hasImage","(Z)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11268(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","hasImage","Ljava/lang/Boolean;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int==0?23:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/ImageKeys","hasImage","(Lforge/item/PaperCard;Z)Z","invokestatic",17);}
case 17:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",20);}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","hasImage","Ljava/lang/Boolean;",value);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","hasImage","Ljava/lang/Boolean;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",30);}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11269(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("N.A.")));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("")));f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;IZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",15);}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11270(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","rules","Lforge/card/CardRules;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","edition","Ljava/lang/String;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","rarity","Lforge/card/CardRarity;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artIndex","I"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","foil","Z"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","collectorNumber","Ljava/lang/String;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artist","Ljava/lang/String;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","functionalVariant","Ljava/lang/String;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;IZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/item/PaperCard$PaperCardFlags;)V","invokespecial",37);}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","flaglessVersion","Lforge/item/PaperCard;"));f.Pc=42;continue;}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","flaglessVersion","Lforge/item/PaperCard;",value);f.Pc=45;continue;}
case 45:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11271(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[6]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[7]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[8]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(null));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;IZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/item/PaperCard$PaperCardFlags;)V","invokespecial",18);}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11272(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","searchableNames","Ljava/util/Set;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","searchableNameLang","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","sortableCNKey","Ljava/lang/String;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(null));f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","cardImageKey","Ljava/lang/String;",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(null));f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","cardAltImageKey","Ljava/lang/String;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference==null?41:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{f.Pc=f.Pop().Reference==null?41:37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Pc=f.Pop().Reference!=null?51:41;continue;}
case 41:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("Cannot create card without rules, edition or rarity")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",50);}
case 50:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","rules","Lforge/card/CardRules;",value);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",61);}
case 61:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;",value);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","edition","Ljava/lang/String;",value);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{f.Push(JValue.I(1));f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",76);}
case 76:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","artIndex","I",value);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","foil","Z",value);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","rarity","Lforge/card/CardRarity;",value);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","artist","Ljava/lang/String;",value);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[6]);f.Pc=99;continue;}
case 99:{f.Pc=f.Pop().Reference==null?115:102;continue;}
case 102:{f.Push(f.Locals[6]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int!=0?115:110;continue;}
case 110:{f.Push(f.Locals[6]);f.Pc=112;continue;}
case 112:{f.Pc=117;continue;}
case 115:{f.Push(JValue.R(rt.String("N.A.")));f.Pc=117;continue;}
case 117:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","collectorNumber","Ljava/lang/String;",value);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[8]);f.Pc=123;continue;}
case 123:{f.Pc=f.Pop().Reference==null?131:126;continue;}
case 126:{f.Push(f.Locals[8]);f.Pc=128;continue;}
case 128:{f.Pc=133;continue;}
case 131:{f.Push(JValue.R(rt.String("")));f.Pc=133;continue;}
case 133:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","functionalVariant","Ljava/lang/String;",value);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[8]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/card/CardRules","getDisplayNameForVariant","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",143);}
case 143:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","displayName","Ljava/lang/String;",value);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=151;continue;}
case 151:{f.Push(f.Locals[0]);f.Pc=152;continue;}
case 152:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","displayName","Ljava/lang/String;"));f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",158);}
case 158:{f.Pc=f.Pop().Int!=0?165:161;continue;}
case 161:{f.Push(JValue.I(1));f.Pc=162;continue;}
case 162:{f.Pc=166;continue;}
case 165:{f.Push(JValue.I(0));f.Pc=166;continue;}
case 166:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","hasFlavorName","Z",value);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[0]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","displayName","Ljava/lang/String;"));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",177);}
case 177:{return rt.Call(f,"forge/util/TextUtil","toSortableName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",180);}
case 180:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","sortableName","Ljava/lang/String;",value);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[9]);f.Pc=185;continue;}
case 185:{f.Pc=f.Pop().Reference==null?199:188;continue;}
case 188:{f.Push(f.Locals[9]);f.Pc=190;continue;}
case 190:{if(!rt.StaticReady(f,"forge/item/PaperCard$PaperCardFlags","IDENTITY_FLAGS","Lforge/item/PaperCard$PaperCardFlags;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCard$PaperCardFlags","IDENTITY_FLAGS","Lforge/item/PaperCard$PaperCardFlags;"));f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/item/PaperCard$PaperCardFlags","equals","(Ljava/lang/Object;)Z","invokevirtual",196);}
case 196:{f.Pc=f.Pop().Int==0?209:199;continue;}
case 199:{f.Push(f.Locals[0]);f.Pc=200;continue;}
case 200:{if(!rt.StaticReady(f,"forge/item/PaperCard$PaperCardFlags","IDENTITY_FLAGS","Lforge/item/PaperCard$PaperCardFlags;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCard$PaperCardFlags","IDENTITY_FLAGS","Lforge/item/PaperCard$PaperCardFlags;"));f.Pc=203;continue;}
case 203:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","flags","Lforge/item/PaperCard$PaperCardFlags;",value);f.Pc=206;continue;}
case 206:{f.Pc=215;continue;}
case 209:{f.Push(f.Locals[0]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[9]);f.Pc=212;continue;}
case 212:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","flags","Lforge/item/PaperCard$PaperCardFlags;",value);f.Pc=215;continue;}
case 215:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11273(JRuntime rt,JFrame f)
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
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int!=0?47:45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","edition","Ljava/lang/String;"));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","edition","Ljava/lang/String;"));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int!=0?63:61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",67);}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",71);}
case 71:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int!=0?79:77;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","flags","Lforge/item/PaperCard$PaperCardFlags;"));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","flags","Lforge/item/PaperCard$PaperCardFlags;"));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Objects","equals","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",90);}
case 90:{f.Pc=f.Pop().Int!=0?95:93;continue;}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","foil","Z"));f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","foil","Z"));f.Pc=103;continue;}
case 103:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?121:106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artIndex","I"));f.Pc=110;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artIndex","I"));f.Pc=114;continue;}
case 114:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?121:117;continue;}
case 117:{f.Push(JValue.I(1));f.Pc=118;continue;}
case 118:{f.Pc=122;continue;}
case 121:{f.Push(JValue.I(0));f.Pc=122;continue;}
case 122:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11274(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(6));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=11;continue;}
case 11:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","edition","Ljava/lang/String;"));f.Pc=18;continue;}
case 18:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{f.Push(JValue.I(2));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","collectorNumber","Ljava/lang/String;"));f.Pc=25;continue;}
case 25:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{f.Push(JValue.I(3));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artIndex","I"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",35);}
case 35:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(JValue.I(4));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","foil","Z"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",45);}
case 45:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=46;continue;}
case 46:{f.StackOp("dup");f.Pc=47;continue;}
case 47:{f.Push(JValue.I(5));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","flags","Lforge/item/PaperCard$PaperCardFlags;"));f.Pc=52;continue;}
case 52:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Objects","hash","([Ljava/lang/Object;)I","invokestatic",56);}
case 56:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11275(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11276(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11277(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","displayName","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11278(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","hasFlavorName","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11279(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","searchableNames","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?25:7;continue;}
case 7:{return rt.Call(f,"forge/util/CardTranslation","getLanguageSelected","()Ljava/lang/String;","invokestatic",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","searchableNameLang","Ljava/lang/String;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?25:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","searchableNames","Ljava/util/Set;"));f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","searchableNameLang","Ljava/lang/String;"));f.Pc=29;continue;}
case 29:{f.Pc=f.Pop().Reference==null?46:32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","displayName","Ljava/lang/String;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",40);}
case 40:{return rt.Call(f,"forge/util/TextUtil","toSortableName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",43);}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","sortableName","Ljava/lang/String;",value);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/util/CardTranslation","getLanguageSelected","()Ljava/lang/String;","invokestatic",50);}
case 50:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","searchableNameLang","Ljava/lang/String;",value);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","searchableNameLang","Ljava/lang/String;"));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/item/PaperCard","computeSearchableNames","(Ljava/lang/String;)Ljava/util/Set;","invokevirtual",62);}
case 62:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","searchableNames","Ljava/util/Set;",value);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","searchableNames","Ljava/util/Set;"));f.Pc=69;continue;}
case 69:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11280(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getOtherFace","()Lforge/card/ICardFace;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?94:9;continue;}
case 9:{f.Push(JValue.R(rt.String("")));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","functionalVariant","Ljava/lang/String;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?94:21;continue;}
case 21:{f.Push(JValue.R(rt.String("en-US")));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?39:31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Set","of","(Ljava/lang/Object;)Ljava/util/Set;","invokestatic",38);}
case 38:{return JStep.Return(f.Pop());}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",46);}
case 46:{f.Locals[3]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(JValue.I(3));f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=51;continue;}
case 51:{f.StackOp("dup");f.Pc=52;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=57;continue;}
case 57:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{f.Push(JValue.I(1));f.Pc=60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(2));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","stripAccents","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",68);}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/stream/Stream","of","([Ljava/lang/Object;)Ljava/util/stream/Stream;","invokestatic",72);}
case 72:{return rt.DynamicCall(f,"forge/item/PaperCard:11280:72:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",77);}
case 77:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",82);}
case 82:{return rt.Call(f,"java/util/stream/Collectors","toSet","()Ljava/util/stream/Collector;","invokestatic",85);}
case 85:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{return JStep.Return(f.Pop());}
case 94:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",101);}
case 101:{f.Locals[3]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/item/PaperCard","getMainFace","()Lforge/card/ICardFace;","invokevirtual",106);}
case 106:{f.Locals[4]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[4]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",116);}
case 116:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",121);}
case 121:{f.StackOp("pop");f.Pc=122;continue;}
case 122:{f.Push(f.Locals[4]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/card/ICardFace","getFlavorName","()Ljava/lang/String;","invokeinterface",129);}
case 129:{f.Locals[5]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[5]);f.Pc=133;continue;}
case 133:{f.Pc=f.Pop().Reference==null?145:136;continue;}
case 136:{f.Push(f.Locals[3]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[5]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",144);}
case 144:{f.StackOp("pop");f.Pc=145;continue;}
case 145:{f.Push(f.Locals[2]);f.Pc=146;continue;}
case 146:{f.Pc=f.Pop().Reference==null?235:149;continue;}
case 149:{f.Push(f.Locals[3]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[2]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",156);}
case 156:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",161);}
case 161:{f.StackOp("pop");f.Pc=162;continue;}
case 162:{f.Push(f.Locals[2]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/card/ICardFace","getFlavorName","()Ljava/lang/String;","invokeinterface",168);}
case 168:{f.Locals[6]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[6]);f.Pc=172;continue;}
case 172:{f.Pc=f.Pop().Reference==null?184:175;continue;}
case 175:{f.Push(f.Locals[3]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[6]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",183);}
case 183:{f.StackOp("pop");f.Pc=184;continue;}
case 184:{f.Push(f.Locals[3]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[4]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",192);}
case 192:{f.Push(f.Locals[2]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",198);}
case 198:{return rt.DynamicCall(f,"forge/item/PaperCard:11280:198:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",203);}
case 203:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",208);}
case 208:{f.StackOp("pop");f.Pc=209;continue;}
case 209:{f.Push(f.Locals[5]);f.Pc=211;continue;}
case 211:{f.Pc=f.Pop().Reference==null?235:214;continue;}
case 214:{f.Push(f.Locals[6]);f.Pc=216;continue;}
case 216:{f.Pc=f.Pop().Reference==null?235:219;continue;}
case 219:{f.Push(f.Locals[3]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[5]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[6]);f.Pc=224;continue;}
case 224:{return rt.DynamicCall(f,"forge/item/PaperCard:11280:224:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",229);}
case 229:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",234);}
case 234:{f.StackOp("pop");f.Pc=235;continue;}
case 235:{f.Push(JValue.R(rt.String("en-US")));f.Pc=238;continue;}
case 238:{f.Push(f.Locals[1]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",242);}
case 242:{f.Pc=f.Pop().Int!=0?293:245;continue;}
case 245:{f.Push(f.Locals[3]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",251);}
case 251:{return rt.DynamicCall(f,"forge/item/PaperCard:11280:251:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",256);}
case 256:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",261);}
case 261:{return rt.DynamicCall(f,"forge/item/PaperCard:11280:261:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",266);}
case 266:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",271);}
case 271:{return rt.Call(f,"java/util/stream/Collectors","toSet","()Ljava/util/stream/Collector;","invokestatic",274);}
case 274:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",279);}
case 279:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=282;continue;}
case 282:{f.Locals[6]=f.Pop();f.Pc=284;continue;}
case 284:{f.Push(f.Locals[3]);f.Pc=285;continue;}
case 285:{f.Push(f.Locals[6]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",292);}
case 292:{f.StackOp("pop");f.Pc=293;continue;}
case 293:{f.Push(f.Locals[3]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",299);}
case 299:{return rt.DynamicCall(f,"forge/item/PaperCard:11280:299:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",304);}
case 304:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",309);}
case 309:{return rt.Call(f,"java/util/stream/Collectors","toSet","()Ljava/util/stream/Collector;","invokestatic",312);}
case 312:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",317);}
case 317:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=320;continue;}
case 320:{f.Locals[6]=f.Pop();f.Pc=322;continue;}
case 322:{f.Push(f.Locals[3]);f.Pc=323;continue;}
case 323:{f.Push(f.Locals[6]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",330);}
case 330:{f.StackOp("pop");f.Pc=331;continue;}
case 331:{f.Push(f.Locals[3]);f.Pc=332;continue;}
case 332:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11281(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("N.A.")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?13:11;continue;}
case 11:{f.Push(JValue.R(null));f.Pc=12;continue;}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardEdition","getSortableCollectorNumber","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11282(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","sortableCNKey","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/item/PaperCard","makeCollectorNumberSortingKey","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","sortableCNKey","Ljava/lang/String;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","sortableCNKey","Ljava/lang/String;"));f.Pc=22;continue;}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11283(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/IPaperCard","getName","()Ljava/lang/String;","invokeinterface",10);}
case 10:{return rt.Call(f,"java/lang/String","compareToIgnoreCase","(Ljava/lang/String;)I","invokevirtual",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?21:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","edition","Ljava/lang/String;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/item/IPaperCard","getEdition","()Ljava/lang/String;","invokeinterface",31);}
case 31:{return rt.Call(f,"java/lang/String","compareTo","(Ljava/lang/String;)I","invokevirtual",34);}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?42:40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumberSortingKey","()Ljava/lang/String;","invokevirtual",46);}
case 46:{f.Locals[4]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/item/IPaperCard","getCollectorNumber","()Ljava/lang/String;","invokeinterface",54);}
case 54:{return rt.Call(f,"forge/item/PaperCard","makeCollectorNumberSortingKey","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",57);}
case 57:{f.Locals[5]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","compareTo","(Ljava/lang/String;)I","invokevirtual",66);}
case 66:{f.Locals[6]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[6]);f.Pc=71;continue;}
case 71:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?77:74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artIndex","I"));f.Pc=81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/item/IPaperCard","getArtIndex","()I","invokeinterface",87);}
case 87:{return rt.Call(f,"java/lang/Integer","compare","(II)I","invokestatic",90);}
case 90:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11284(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/io/ObjectInputStream","defaultReadObject","()V","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",7);}
case 7:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","edition","Ljava/lang/String;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artIndex","I"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperCard;","invokevirtual",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Reference!=null?139:30;continue;}
case 30:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",33);}
case 33:{return rt.Call(f,"forge/StaticData","getVariantCards","()Lforge/card/CardDb;","invokevirtual",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","edition","Ljava/lang/String;"));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artIndex","I"));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperCard;","invokevirtual",51);}
case 51:{f.Locals[2]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{f.Pc=f.Pop().Reference!=null?139:56;continue;}
case 56:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","edition","Ljava/lang/String;"));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artIndex","I"));f.Pc=71;continue;}
case 71:{return rt.DynamicCall(f,"forge/item/PaperCard:11284:71:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;",76);}
case 76:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",79);}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","edition","Ljava/lang/String;"));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/item/PaperCard","readObjectAlternate","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/IPaperCard;","invokevirtual",91);}
case 91:{f.Locals[2]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{f.Pc=f.Pop().Reference!=null?110:96;continue;}
case 96:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",99);}
case 99:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",102);}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/card/CardDb","createUnsupportedCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",109);}
case 109:{f.Locals[2]=f.Pop();f.Pc=110;continue;}
case 110:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=113;continue;}
case 113:{f.Push(f.Locals[2]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/item/IPaperCard","getName","()Ljava/lang/String;","invokeinterface",119);}
case 119:{f.Push(f.Locals[2]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/item/IPaperCard","getEdition","()Ljava/lang/String;","invokeinterface",125);}
case 125:{f.Push(f.Locals[2]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/item/IPaperCard","getArtIndex","()I","invokeinterface",131);}
case 131:{return rt.DynamicCall(f,"forge/item/PaperCard:11284:131:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;",136);}
case 136:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",139);}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[2]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/item/IPaperCard","getRules","()Lforge/card/CardRules;","invokeinterface",146);}
case 146:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","rules","Lforge/card/CardRules;",value);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[2]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/item/IPaperCard","getRarity","()Lforge/card/CardRarity;","invokeinterface",156);}
case 156:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","rarity","Lforge/card/CardRarity;",value);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[2]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/item/IPaperCard","getDisplayName","()Ljava/lang/String;","invokeinterface",166);}
case 166:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","displayName","Ljava/lang/String;",value);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[0]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[2]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/item/IPaperCard","hasFlavorName","()Z","invokeinterface",176);}
case 176:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","hasFlavorName","Z",value);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[0]);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[0]);f.Pc=181;continue;}
case 181:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","displayName","Ljava/lang/String;"));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",187);}
case 187:{return rt.Call(f,"forge/util/TextUtil","toSortableName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",190);}
case 190:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","sortableName","Ljava/lang/String;",value);f.Pc=193;continue;}
case 193:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11285(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference!=null?28:16;continue;}
case 16:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",19);}
case 19:{return rt.Call(f,"forge/StaticData","getVariantCards","()Lforge/card/CardDb;","invokevirtual",22);}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",27);}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Pc=f.Pop().Reference!=null?58:32;continue;}
case 32:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",35);}
case 35:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",38);}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",42);}
case 42:{f.Locals[3]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Reference!=null?58:47;continue;}
case 47:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",50);}
case 50:{return rt.Call(f,"forge/StaticData","getVariantCards","()Lforge/card/CardDb;","invokevirtual",53);}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",57);}
case 57:{f.Locals[3]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11286(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","flags","Lforge/item/PaperCard$PaperCardFlags;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?17:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/item/PaperCard;Lforge/item/PaperCard$PaperCardFlags;)V","invokespecial",16);}
case 16:{return JStep.Return(f.Pop());}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11287(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","stripAccents","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","edition","Ljava/lang/String;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","artIndex","I"));f.Pc=17;continue;}
case 17:{return rt.DynamicCall(f,"forge/item/PaperCard:11287:17:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Int==0?34:27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.DynamicCall(f,"forge/item/PaperCard:11287:28:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",33);}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11288(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","cardImageKey","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("")));f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/util/ImageUtil","getImageKey","(Lforge/item/IPaperCard;Ljava/lang/String;Z)Ljava/lang/String;","invokestatic",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","cardImageKey","Ljava/lang/String;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","cardImageKey","Ljava/lang/String;"));f.Pc=22;continue;}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11289(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","cardAltImageKey","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?40:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/item/PaperCard","hasBackFace","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?29:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("back")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/util/ImageUtil","getImageKey","(Lforge/item/IPaperCard;Ljava/lang/String;Z)Ljava/lang/String;","invokestatic",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","cardAltImageKey","Ljava/lang/String;",value);f.Pc=26;continue;}
case 26:{f.Pc=40;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("")));f.Pc=33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/util/ImageUtil","getImageKey","(Lforge/item/IPaperCard;Ljava/lang/String;Z)Ljava/lang/String;","invokestatic",37);}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard","cardAltImageKey","Ljava/lang/String;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","cardAltImageKey","Ljava/lang/String;"));f.Pc=44;continue;}
case 44:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11290(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","rules","Lforge/card/CardRules;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Transform","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Transform","Lforge/card/CardSplitType;"));f.Pc=12;continue;}
case 12:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?36:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Flip","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Flip","Lforge/card/CardSplitType;"));f.Pc=19;continue;}
case 19:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?36:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Meld","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Meld","Lforge/card/CardSplitType;"));f.Pc=26;continue;}
case 26:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?36:29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Modal","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Modal","Lforge/card/CardSplitType;"));f.Pc=33;continue;}
case 33:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?40:36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{f.Pc=41;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11291(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","rules","Lforge/card/CardRules;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/item/PaperCard","getVariantForFace","(Lforge/card/ICardFace;)Lforge/card/ICardFace;","invokevirtual",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11292(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","rules","Lforge/card/CardRules;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference!=null?14:12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/item/PaperCard","getVariantForFace","(Lforge/card/ICardFace;)Lforge/card/ICardFace;","invokevirtual",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11293(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","rules","Lforge/card/CardRules;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardRules","getAllFaces","()Ljava/util/List;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",12);}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.DynamicCall(f,"forge/item/PaperCard:11293:13:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/item/PaperCard;)Ljava/util/function/Function;",18);}
case 18:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",23);}
case 23:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",26);}
case 26:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11294(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ICardFace","hasFunctionalVariants","()Z","invokeinterface",6);}
case 6:{f.Pc=f.Pop().Int==0?21:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","functionalVariant","Ljava/lang/String;"));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?23:21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return JStep.Return(f.Pop());}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","functionalVariant","Ljava/lang/String;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/card/ICardFace","getFunctionalVariant","(Ljava/lang/String;)Lforge/card/ICardFace;","invokeinterface",33);}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Reference!=null?70:38;continue;}
case 38:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("Tried to apply unknown or unsupported variant - Card: \"%s\"; Variant: %s\n")));f.Pc=44;continue;}
case 44:{f.Push(JValue.I(2));f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",56);}
case 56:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{f.Push(JValue.I(1));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","functionalVariant","Ljava/lang/String;"));f.Pc=63;continue;}
case 63:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/io/PrintStream","printf","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;","invokevirtual",67);}
case 67:{f.StackOp("pop");f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{return JStep.Return(f.Pop());}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11295(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("Swamp")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int!=0?65:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Push(JValue.R(rt.String("Plains")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?65:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",30);}
case 30:{f.Push(JValue.R(rt.String("Island")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int!=0?65:39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",43);}
case 43:{f.Push(JValue.R(rt.String("Forest")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int!=0?65:52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",56);}
case 56:{f.Push(JValue.R(rt.String("Mountain")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int==0?69:65;continue;}
case 65:{f.Push(JValue.I(1));f.Pc=66;continue;}
case 66:{f.Pc=70;continue;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11296(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","sortableName","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11297(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=7;continue;}
case 7:{return rt.DynamicCall(f,"forge/item/PaperCard:11297:7:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",12);}
case 12:{return rt.Call(f,"forge/StaticData","isRebalanced","(Ljava/lang/String;)Z","invokevirtual",15);}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11298(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard","name","Ljava/lang/String;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/StaticData","isRebalanced","(Ljava/lang/String;)Z","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11299(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/IPaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCard","compareTo","(Lforge/item/IPaperCard;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11300(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Fake Card")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardRules","getUnsupportedCardNamed","(Ljava/lang/String;)Lforge/card/CardRules;","invokestatic",10);}
case 10:{f.Push(JValue.R(rt.String("Fake Edition")));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/CardRarity","Common","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Common","Lforge/card/CardRarity;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;)V","invokespecial",19);}
case 19:{if(!rt.StaticReady(f,"forge/item/PaperCard","FAKE_CARD","Lforge/item/PaperCard;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCard","FAKE_CARD","Lforge/item/PaperCard;",f.Pop());f.Pc=22;continue;}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
