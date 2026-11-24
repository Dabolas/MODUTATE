// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C567{
internal static JClass Build(){var c=new JClass("forge/game/cost/ICostVisitor","java/lang/Object",new string[]{},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(6649,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostBehold;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6650,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostBeholdExile;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6651,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostGainControl;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6652,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostChooseColor;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6653,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostChooseCreatureType;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6654,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostCollectEvidence;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6655,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostDiscard;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6656,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostDamage;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6657,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostDraw;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6658,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostExile;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6659,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostExileFromStack;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6660,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostExiledMoveToGrave;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6661,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostExert;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6662,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostEnlist;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6663,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostFlipCoin;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6664,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostForage;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6665,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostRollDice;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6666,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostMill;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6667,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostAddMana;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6668,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostPayLife;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6669,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostPayEnergy;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6670,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostGainLife;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6671,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostPartMana;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6672,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostPromiseGift;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6673,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostPutCardToLib;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6674,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostTap;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6675,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostSacrifice;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6676,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostReturn;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6677,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostReveal;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6678,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostRevealChosen;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6679,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostRemoveAnyCounter;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6680,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostRemoveCounter;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6681,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostPutCounter;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6682,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostPutCounterYou;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6683,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostUntapType;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6684,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostUntap;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6685,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostUnattach;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6686,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostTapType;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6687,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostPayShards;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6688,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostBlight;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
}
}}
