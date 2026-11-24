// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C64{
internal static JClass Build(){var c=new JClass("forge/card/ICardCharacteristics","java/lang/Object",new string[]{"forge/util/IHasName"},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(1058,"forge/card/ICardCharacteristics","getType","()Lforge/card/CardType;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1059,"forge/card/ICardCharacteristics","getManaCost","()Lforge/card/mana/ManaCost;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1060,"forge/card/ICardCharacteristics","getColor","()Lforge/card/ColorSet;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1061,"forge/card/ICardCharacteristics","getIntPower","()I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1062,"forge/card/ICardCharacteristics","getIntToughness","()I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1063,"forge/card/ICardCharacteristics","getPower","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1064,"forge/card/ICardCharacteristics","getToughness","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1065,"forge/card/ICardCharacteristics","getInitialLoyalty","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1066,"forge/card/ICardCharacteristics","getDefense","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1067,"forge/card/ICardCharacteristics","getAttractionLights","()Ljava/util/Set;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1068,"forge/card/ICardCharacteristics","getOracleText","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
}
}}
