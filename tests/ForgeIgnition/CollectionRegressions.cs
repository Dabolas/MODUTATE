using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public static void CollectionRegressions(string root,Action<bool,string> check)
    {
        bool accepted=false,refused=false;
        HostCases(root,"collection-draw",check,(d,v,blocked,seed)=>{
            var g=d.g;
            bool celestus=seed<=2;
            var source=g.Card(celestus?"The Celestus":"Jeskai Elder",0,"Battlefield");
            var sa=d.ScriptAbility(source,celestus?"DBDiscard":"TrigLoot");
            var cost=celestus
                ?g.New("forge/game/cost/Cost","(Ljava/lang/String;Z)V",d.C(sa,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S("UnlessCost")),JValue.I(1))
                :d.C(sa,"getPayCosts","()Lforge/game/cost/Cost;");
            var part=d.Items(d.C(cost,"getCostParts","()Ljava/util/List;")).Single(c=>g.Rt.IsInstance(c.Reference!,"forge/game/cost/CostDraw"));
            var top=g.Card("Forest",0,"Library");
            if(blocked==1)g.Card("Maralen of the Mornsong",1,"Battlefield");
            var decision=d.C(part,"accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",d.CostVisitor(g.Players[0],sa,celestus));
            v(g.In(top,"Library"),"Choosing a draw cost does not itself draw");
            if(decision.Reference==null){
                v(blocked==1||celestus,"Only an unpayable or optional draw can be refused");
                if(blocked==0)refused=true;
            }else{
                v(blocked==0,"Original static draw prohibition prevents payment");
                v(d.C(part,"payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",g.Players[0],decision,sa,JValue.I(celestus?1:0)).Int==1&&g.In(top,"Hand")&&d.Zone(1,"Hand").Length==0,"Original CostDraw draws into the selected player's hand");
                if(celestus)accepted=true;
            }
        });
        check(accepted&&refused,"The Celestus covers both optional draw choices");
        HostCases(root,"collection-static",check,(d,v,variant,seed)=>{
            var g=d.g;
            string playerName=seed%2==0?@"A$\B":"Plain";
            d.C(g.Players[1],"setName","(Ljava/lang/String;)V",g.S(playerName));
            var source=g.Card(variant==0?"True-Name Nemesis":"Triarch Stalker",0,"Battlefield");
            var attacker=g.Card("Raging Goblin",0,"Battlefield");
            d.C(source,"setChosenPlayer","(Lforge/game/player/Player;)V",g.Players[1]);
            var combat=g.New("forge/game/combat/Combat","(Lforge/game/player/Player;)V",g.Players[0]);
            d.C(g.Phase,"setCombat","(Lforge/game/combat/Combat;)V",combat);
            d.C(combat,"addAttacker","(Lforge/game/card/Card;Lforge/game/GameEntity;)V",attacker,g.Players[1]);
            d.C(g.Action,"checkStaticAbilities","()V");
            var keywords=d.Items(d.C(variant==0?source:attacker,"getKeywords","()Ljava/util/List;")).Select(k=>g.Rt.StringValue(d.C(k,"getOriginal","()Ljava/lang/String;"))).ToArray();
            v(variant==0?keywords.Any(k=>k.StartsWith("Protection:Player.")&&k.EndsWith(":"+playerName,StringComparison.Ordinal)):keywords.Contains("Menace"),"Chosen player name is literal in protection, and Triarch grants menace to an attacker");
            v(g.Rt.ExecutedBindings.Any(k=>k.Contains("Matcher.quoteReplacement")),"Real continuous effect calls the replacement binding");
        });
        HostCases(root,"collection-copy",check,(d,v,variant,seed)=>{
            var g=d.g;var source=g.Card(variant==0?"Mysterio, Master of Illusion":"Clone",0,"Battlefield");
            var copy=d.S("forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;",source);
            var original=g.Rt.InspectFields(source.Reference!);var copied=g.Rt.InspectFields(copy.Reference!);
            var keys=new HashSet<string>(original.Keys,ReferenceEqualityComparer.Instance);
            v(copied.Count>0&&copied.Keys.All(keys.Contains),"Last-known card copy shares immutable field names");
            v(!ReferenceEquals(source.Reference,copy.Reference)&&d.B(copy,"isLKI")&&d.C(copy,"getId","()I").Int==d.C(source,"getId","()I").Int,"Last-known information retains its card identity and independent storage");
        });
        HostCases(root,"collection-combat",check,(d,v,variant,seed)=>{
            var g=d.g;
            var flyer=g.Card(variant==0?"Sleep-Cursed Faerie":"Welkin Tern",0,"Battlefield");
            g.Card("Risen Riptide",1,"Battlefield");
            d.C(flyer,"setSickness","(Z)V",JValue.I(0));
            d.C(g.Phase,"devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;)V",g.Enum("forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS"),g.Players[0]);
            var combat=g.New("forge/game/combat/Combat","(Lforge/game/player/Player;)V",g.Players[0]);
            d.C(g.Phase,"setCombat","(Lforge/game/combat/Combat;)V",combat);
            d.Attack(0,combat);
            v(d.B(flyer,"isAttacking") && ReferenceEquals(d.C(combat,"getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;",flyer).Reference,g.Players[1].Reference),"Flying attacker attacks the opponent past a ground blocker");
        });
    }
}
