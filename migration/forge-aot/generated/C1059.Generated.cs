// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1059{
internal static JClass Build(){var c=new JClass("forge/item/IPaperCard","java/lang/Object",new string[]{"forge/item/InventoryItem","java/io/Serializable"},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("NO_COLLECTOR_NUMBER","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"N.A."));
c.Add(new JField("DEFAULT_ART_INDEX","I",true,JValue.I(1),null));
c.Add(new JField("NO_ART_INDEX","I",true,JValue.I(-1),null));
c.Add(new JField("NO_ARTIST_NAME","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),""));
c.Add(new JField("NO_FUNCTIONAL_VARIANT","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),""));
c.Add(new JMethod(11214,"forge/item/IPaperCard","getName","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11215,"forge/item/IPaperCard","getEdition","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11216,"forge/item/IPaperCard","getCollectorNumber","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11217,"forge/item/IPaperCard","getFunctionalVariant","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11218,"forge/item/IPaperCard","getMarkedColors","()Lforge/card/ColorSet;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11219,"forge/item/IPaperCard","getArtIndex","()I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11220,"forge/item/IPaperCard","isFoil","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11221,"forge/item/IPaperCard","isToken","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11222,"forge/item/IPaperCard","getRules","()Lforge/card/CardRules;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11223,"forge/item/IPaperCard","getRarity","()Lforge/card/CardRarity;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11224,"forge/item/IPaperCard","getArtist","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11225,"forge/item/IPaperCard","getItemType","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11226,"forge/item/IPaperCard","hasBackFace","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11227,"forge/item/IPaperCard","getMainFace","()Lforge/card/ICardFace;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11228,"forge/item/IPaperCard","getOtherFace","()Lforge/card/ICardFace;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11229,"forge/item/IPaperCard","getAllFaces","()Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11230,"forge/item/IPaperCard","getCardImageKey","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11231,"forge/item/IPaperCard","getCardAltImageKey","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11232,"forge/item/IPaperCard","isRebalanced","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11233,"forge/item/IPaperCard","getTranslationKey","()Ljava/lang/String;",1,1,2,new JHandler[]{},M11233));
c.Add(new JMethod(11234,"forge/item/IPaperCard","getUntranslatedType","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11234));
c.Add(new JMethod(11235,"forge/item/IPaperCard","lambda$getTranslationKey$0","(Lforge/card/ICardFace;)Z",4106,1,1,new JHandler[]{},M11235));
}

internal static JStep M11233(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/item/IPaperCard","getFunctionalVariant","()Ljava/lang/String;","invokeinterface",8);}
case 8:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?56:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/item/IPaperCard","getAllFaces","()Ljava/util/List;","invokeinterface",20);}
case 20:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",25);}
case 25:{return rt.DynamicCall(f,"forge/item/IPaperCard:11233:25:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",30);}
case 30:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?56:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/item/IPaperCard","getName","()Ljava/lang/String;","invokeinterface",44);}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/item/IPaperCard","getFunctionalVariant","()Ljava/lang/String;","invokeinterface",50);}
case 50:{return rt.DynamicCall(f,"forge/item/IPaperCard:11233:50:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",55);}
case 55:{return JStep.Return(f.Pop());}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/item/IPaperCard","getDisplayName","()Ljava/lang/String;","invokeinterface",62);}
case 62:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11234(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/IPaperCard","getRules","()Lforge/card/CardRules;","invokeinterface",6);}
case 6:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/card/CardType","toString","()Ljava/lang/String;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11235(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ICardFace","getFlavorName","()Ljava/lang/String;","invokeinterface",6);}
case 6:{f.Pc=f.Pop().Reference==null?13:9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{f.Pc=14;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
