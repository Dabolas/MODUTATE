// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1089{
internal static JClass Build(){var c=new JClass("forge/token/ITokenDatabase","java/lang/Object",new string[]{"java/lang/Iterable"},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11491,"forge/token/ITokenDatabase","getToken","(Ljava/lang/String;)Lforge/item/PaperToken;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11492,"forge/token/ITokenDatabase","getToken","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperToken;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11493,"forge/token/ITokenDatabase","getToken","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperToken;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11494,"forge/token/ITokenDatabase","getTokenFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;)Lforge/item/PaperToken;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11495,"forge/token/ITokenDatabase","getTokenFromEditions","(Ljava/lang/String;Ljava/util/Date;Lforge/card/CardDb$CardArtPreference;)Lforge/item/PaperToken;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11496,"forge/token/ITokenDatabase","getTokenFromEditions","(Ljava/lang/String;Ljava/util/Date;Lforge/card/CardDb$CardArtPreference;I)Lforge/item/PaperToken;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11497,"forge/token/ITokenDatabase","getFoiled","(Lforge/item/PaperToken;)Lforge/item/PaperToken;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11498,"forge/token/ITokenDatabase","getPrintCount","(Ljava/lang/String;Ljava/lang/String;)I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11499,"forge/token/ITokenDatabase","getMaxPrintCount","(Ljava/lang/String;)I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11500,"forge/token/ITokenDatabase","getArtCount","(Ljava/lang/String;Ljava/lang/String;)I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11501,"forge/token/ITokenDatabase","getUniqueTokens","()Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11502,"forge/token/ITokenDatabase","getAllTokens","()Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11503,"forge/token/ITokenDatabase","getAllTokens","(Ljava/lang/String;)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11504,"forge/token/ITokenDatabase","getAllTokens","(Ljava/util/function/Predicate;)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11505,"forge/token/ITokenDatabase","wasPrintedInSets","(Ljava/util/List;)Ljava/util/function/Predicate;",1025,0,0,new JHandler[]{},null));
}
}}
