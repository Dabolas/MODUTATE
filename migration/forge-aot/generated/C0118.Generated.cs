// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C118{
internal static JClass Build(){var c=new JClass("forge/deck/generation/IDeckGenPool","java/lang/Object",new string[]{},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(1725,"forge/deck/generation/IDeckGenPool","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1726,"forge/deck/generation/IDeckGenPool","getCard","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1727,"forge/deck/generation/IDeckGenPool","getCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperCard;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1728,"forge/deck/generation/IDeckGenPool","getAllCards","()Ljava/lang/Iterable;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1729,"forge/deck/generation/IDeckGenPool","getAllCards","(Ljava/util/function/Predicate;)Ljava/lang/Iterable;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1730,"forge/deck/generation/IDeckGenPool","contains","(Ljava/lang/String;)Z",1025,0,0,new JHandler[]{},null));
}
}}
