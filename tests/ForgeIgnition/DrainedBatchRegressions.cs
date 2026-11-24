using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public static void DrainedBatchRegressions(string root,Action<bool,string> check)
    {
        HostCases(root,"drained-costs",check,(d,v,variant,scenario)=>{
            var g=d.g;var payer=g.Players[0];
            (JValue Sa,JValue Part) FindCost(JValue source,string name){
                foreach(var sa in d.Items(d.C(source,"getSpellAbilities","()Lforge/util/collect/FCollectionView;"))){
                    var cost=d.C(sa,"getPayCosts","()Lforge/game/cost/Cost;");
                    if(cost.Reference==null)continue;
                    foreach(var part in d.Items(d.C(cost,"getCostParts","()Ljava/util/List;")))
                        if(g.Rt.IsInstance(part.Reference!,"forge/game/cost/"+name)){
                            d.C(sa,"setActivatingPlayer","(Lforge/game/player/Player;)V",payer);return (sa,part);
                        }
                }
                throw new InvalidOperationException("Missing card cost "+name);
            }
            bool Pay(JValue sa,JValue part){
                try{
                    var decision=d.C(part,"accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",d.CostVisitor(payer,sa,false));
                    return decision.Reference!=null&&d.C(part,"payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",payer,decision,sa,JValue.I(0)).Int!=0;
                }
                catch(Exception error){throw new InvalidOperationException(part.Reference!.ClassName+" payment: "+error.Data["Forge.JavaStack"],error);}
            }
            if(scenario==1){
                var card=g.Card(variant==0?"Ambergris, Citadel Agent":"Lukamina, Moon Druid",0,"Battlefield");
                g.Card("Mountain",0,"Hand");
                var (sa,color)=FindCost(card,"CostChooseColor");
                v(Pay(sa,color)&&d.C(card,"hasChosenColor","(Ljava/lang/String;)Z",g.S("red")).Int!=0,"Specialize chooses the color supported by the basic land in hand");
                var (_,discard)=FindCost(card,"CostDiscard");
                v(Pay(sa,discard)&&g.Count(0,"Hand")==0,"Associated basic land pays the subsequent discard");
            }else if(scenario==2){
                var card=g.Card(variant==0?"Hope Tender":"Fervent Paincaster",0,"Battlefield");
                var (sa,part)=FindCost(card,"CostExert");
                v(Pay(sa,part)&&d.C(card,"isExertedBy","(Lforge/game/player/Player;)Z",payer).Int!=0,"Engine exerts the correct permanent for its controller");
            }else if(scenario==3){
                var card=g.Card(variant==0?"Iron Spider, Stark Upgrade":"Brambleback Brute",0,"Battlefield");
                var (sa,part)=FindCost(card,"CostRemoveAnyCounter");
                var other=g.Card("Ornithopter",0,"Battlefield");
                var type=d.S("forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;",g.S("P1P1"));
                foreach(var permanent in new[]{card,other}){
                    var table=g.New("forge/game/GameEntityCounterTable","()V");
                    d.C(permanent,"addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V",type,JValue.I(1),payer,table);
                    d.C(table,"replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V",g.Game,default);
                }
                v(Pay(sa,part),"Engine accepts distributed or source-only counter removal");
                v(d.C(other,"getCounters","(Lforge/game/card/CounterType;)I",type).Int==(variant==0?0:1),"Distributed cost can span artifacts while a source restriction preserves the other card");
            }else{
                var source=g.Card(variant==0?"Numa, Joraga Chieftain":"The Disciple of Nissa",0,"Battlefield");
                var sa=d.ScriptAbility(source,variant==0?"TrigPayCost":"TrigImmediateTrig");
                g.Fund(0,"GGCCCC");int before=g.ManaCount(0);
                var chosen=d.C(d.C(payer,"getController","()Lforge/game/player/PlayerController;"),"announceRequirements","(Lforge/game/spellability/SpellAbility;IILjava/lang/String;)Ljava/lang/Integer;",sa,JValue.I(0),JValue.I(int.MaxValue),g.S("X"));
                int x=g.Rt.UnboxInt(chosen);
                v(x>=0&&(variant==0?2*x:3*x+2)<=before&&g.ManaCount(0)==before,"Every proposed X fits its repeated symbols and fixed pips, without spending mana during the probe");
            }
        });
        HostCases(root,"drained-casting",check,(d,v,allowed,scenario)=>{
            var g=d.g;
            if(scenario<=2){
                bool mind=scenario==1;
                var card=g.Card(mind?"Keeper of the Mind":"Keeper of the Dead",0,"Battlefield");
                d.C(card,"setSickness","(Z)V",JValue.I(0));g.Fund(0,mind?"U":"B");
                g.Card("Grizzly Bears",1,"Battlefield");
                if(allowed==1)for(int i=0;i<2;i++)g.Card("Grizzly Bears",mind?1:0,mind?"Hand":"Graveyard");
                v(d.CanOfferAction(card,d.ActivatedAbility(card),0)==(allowed==1),"Keeper only offered when its selected opponent satisfies ValidAfterStack");
            }else{
                var card=g.Card(scenario==3?"Silvergill Adept":"Squeaking Pie Sneak",0,"Hand");
                g.Fund(0,scenario==3?"UC":"BC");
                if(allowed==1)g.Card(scenario==3?"Merfolk of the Pearl Trident":"Raging Goblin",0,"Hand");
                var sa=g.Ability(card,0);
                var variants=d.Items(d.S("forge/game/GameActionUtil","getAdditionalCostSpell","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",sa));
                v(variants.Count(x=>d.CanFundVariant(x,0))==allowed,"Revealing another matching creature is payable, the extra three mana are unavailable");
                if(allowed==1)v(d.Play(sa,0)&&g.In(card,"Stack")&&g.Count(0,"Hand")==1,"Only the payable alternative is chosen and reveal leaves its card in hand");
            }
        });
        HostCases(root,"drained-controller",check,(d,v,variant,scenario)=>{
            var g=d.g;var player=g.Players[0];
            if(scenario==1){
                var card=g.Card(variant==0?"Caller of the Untamed":"Volatile Chimera",0,"Library");
                var sa=d.ScriptAbility(card,variant==0?"DBExile":"DBChoose");
                var formats=d.C(sa,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S("ConditionGameTypes"));
                var parsed=d.Items(d.S("forge/game/GameType","listValueOf","(Ljava/lang/String;)Ljava/util/Set;",formats));
                v(parsed.Select(g.Rt.InspectEnumName).ToHashSet().SetEquals(new[]{"Draft","QuestDraft"}),"Both draft-only setup conditions resolve their actual format names");
                v(d.S("forge/game/GameType","smartValueOf","(Ljava/lang/String;)Lforge/game/GameType;",g.S("draft")).Reference==null,"Unknown case-sensitive enum value is absent");
            }else if(scenario==2){
                var victim=g.Card("Grizzly Bears",1,"Battlefield");
                var source=g.Card(variant==0?"Chaos Orb":"Falling Star",0,variant==0?"Battlefield":"Hand");
                var sa=variant==0?d.ActivatedAbility(source):g.Ability(source,0);
                g.Fund(0,variant==0?"C":"RCC");
                v(d.Play(sa,0),"Flip effect put on the stack");g.ResolveOne();g.Sba();
                v(g.Rt.ExecutedMethods.Any(s=>s.Contains("FlipOntoBattlefieldEffect.resolve")),"Original flip effect ran through hit selection and interaction with the card-view list");
            }else if(scenario==3){
                var source=g.Card(variant==0?"Retraced Image":"Rofellos's Gift",0,"Hand");
                var other=g.Card(variant==0?"Forest":"Grizzly Bears",0,"Hand");g.Card("Forest",0,"Battlefield");
                if(variant==1)g.Card("Rancor",0,"Graveyard");
                g.Fund(0,variant==0?"U":"G");var sa=g.Ability(source,0);
                v(d.Play(sa,0),"Real reveal spell casts");g.ResolveOne();
                v(g.In(source,"Graveyard")&&g.Rt.ExecutedBindings.Any(s=>s.Contains("chooseCardsToRevealFromHand")),"Reveal used the controller's offered hand and cardinality");
                v(g.In(other,variant==0?"Battlefield":"Hand"),"Retraced Image puts the matching revealed card onto the battlefield and Rofellos's Gift keeps its green card in hand");
            }else{
                var spell=g.Card(variant==0?"Shock":"Lightning Bolt",0,"Hand");
                var sa=g.Ability(spell,0);g.Target(sa,player);
                var targetBefore=d.C(sa,"getTargets","()Lforge/game/spellability/TargetChoices;");
                var newTargets=d.C(d.C(player,"getController","()Lforge/game/player/PlayerController;"),"chooseNewTargetsFor","(Lforge/game/spellability/SpellAbility;Ljava/util/function/Predicate;Z)Lforge/game/spellability/TargetChoices;",sa,default,JValue.I(variant));
                var chosen=d.C(sa,"getTargets","()Lforge/game/spellability/TargetChoices;");
                v(d.C(chosen,"size","()I").Int==1&&d.B(sa,"isTargetNumberValid"),"Changing targets preserves the original target count");
                v(newTargets.Reference==null?ReferenceEquals(chosen.Reference,targetBefore.Reference):ReferenceEquals(chosen.Reference,newTargets.Reference),"Optional refusal retains previous targets, success installs the new choices");
            }
        });
        HostCases(root,"drained-origins",check,(d,v,variant,scenario)=>{
            var g=d.g;
            if(scenario<=2){
                var source=g.Card(scenario==1?"Rubble Rouser":"Reckless Racer",0,"Battlefield");
                var sa=d.ScriptAbility(source,"TrigDiscard");
                var part=d.Items(d.C(d.C(sa,"getPayCosts","()Lforge/game/cost/Cost;"),"getCostParts","()Ljava/util/List;")).Single(p=>g.Rt.IsInstance(p.Reference!,"forge/game/cost/CostDiscard"));
                if(variant==1)g.Card("Forest",0,"Hand");
                var decision=d.C(part,"accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",d.CostVisitor(g.Players[0],sa,true));
                v((decision.Reference!=null)==(variant==1),"Empty hand declines the discard payment");
                if(variant==1)v(d.C(part,"payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",g.Players[0],decision,sa,JValue.I(1)).Int!=0&&g.Count(0,"Hand")==0,"Accepted discard moves the actual card");
            }else{
                bool haakon=scenario==3;
                if(variant==0&&!haakon)g.Card("Iona, Shield of Emeria",1,"Battlefield");
                var card=g.Card(haakon?"Haakon, Stromgald Scourge":"Encampment Keeper",0,haakon&&variant==1?"Graveyard":"Hand");
                if(!haakon&&variant==0){
                    var iona=d.Zone(1,"Battlefield").Single();
                    d.C(iona,"setChosenColors","(Ljava/util/List;)V",g.Rt.ListOf([g.S("white")]));
                }
                g.Fund(0,haakon?"BBC":"W");d.C(g.Action,"checkStaticAbilities","()V");
                var offered=d.Items(d.C(card,"getAllPossibleAbilities","(Lforge/game/player/Player;Z)Ljava/util/List;",g.Players[0],JValue.I(1))).Where(sa=>d.B(sa,"isSpell")).Any(sa=>d.CanOfferAction(card,sa,0));
                v(offered==(variant==1),"Casting offer observes origin and opposing continuous restrictions");
                v(d.C(card,"getCastFrom","()Lforge/game/zone/Zone;").Reference==null,"Preflight restores the card's casting origin");
            }
        });
    }
}
