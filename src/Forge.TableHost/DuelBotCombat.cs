using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    const string CombatObject="Lforge/game/combat/Combat;";
    const string CombatUtil="forge/game/combat/CombatUtil";
    sealed record BotFighter(JValue Card,int Power,int Health,int Value,bool First,bool Double,bool Deadly,bool Trample,bool Vigilance,bool Indestructible)
    {
        public int Damage=>Double?Power*2:Power;
    }
    BotFighter Fighter(JValue card)=>new(card,BotPower(card),BotHealth(card),BotPermanentValue(card),
        B(card,"hasFirstStrike"),B(card,"hasDoubleStrike"),BotKeyword(card,"Deathtouch"),BotKeyword(card,"Trample"),
        BotKeyword(card,"Vigilance"),BotKeyword(card,"Indestructible"));
    int BotMinimumBlockers(JValue attacker,JValue defender)=>
        Math.Max(1,S(CombatUtil,"getMinNumBlockersForAttacker","("+BotCard+BotPlayer+")I",attacker,defender).Int);

    static bool Kills(BotFighter attacker,BotFighter defender)
    {
        if(attacker.Power==0||defender.Indestructible)return false;
        if((attacker.First||attacker.Double)&&(attacker.Power>=defender.Health||attacker.Deadly))return true;
        if((defender.First||defender.Double)&&!attacker.Indestructible&&defender.Power>0&&
           (defender.Power>=attacker.Health||defender.Deadly))return false;
        return attacker.Damage>=defender.Health||attacker.Deadly;
    }

    bool BotAttack(JValue combat)
    {
        var defenders=Items(C(combat,"getDefenders","()Lforge/util/collect/FCollectionView;"));
        var enemy=g.Players[0];
        var opponent=Zone(0,"Battlefield").Where(card=>B(card,"isCreature")).Select(Fighter).ToArray();
        var blockers=opponent.Where(body=>!B(body.Card,"isTapped")).ToList();
        var creatures=Zone(1,"Battlefield").Where(card=>B(card,"isCreature")).Select(Fighter)
            .OrderByDescending(body=>body.Damage).ToArray();
        int enemyAttack=opponent.Sum(body=>body.Damage);
        int defense=creatures.Count(body=>!B(body.Card,"isTapped"));
        int predictedDamage=0;
        int enemyLife=g.Life(0);
        foreach(var body in creatures){
            if(body.Power<=0)continue;
            bool CanAttack(JValue target)=>S(CombatUtil,"canAttack","("+BotCard+"Lforge/game/GameEntity;)Z",body.Card,target).Int!=0&&
                S(CombatUtil,"getAttackCost","(Lforge/game/Game;"+BotCard+"Lforge/game/GameEntity;)Lforge/game/cost/Cost;",g.Game,body.Card,target).Reference==null;
            var target=defenders.FirstOrDefault(d=>ReferenceEquals(d.Reference,enemy.Reference)&&CanAttack(d));
            if(target.Reference==null)target=defenders.FirstOrDefault(CanAttack);
            if(target.Reference==null)continue;

            BotFighter? worst=null;
            int worstTrade=int.MaxValue;
            int blockable=0,minimum=BotMinimumBlockers(body.Card,enemy);
            foreach(var blocker in blockers){
                if(S(CombatUtil,"canBlock","("+BotCard+BotCard+")Z",body.Card,blocker.Card).Int==0)continue;
                blockable++;
                int trade=(Kills(body,blocker)?blocker.Value:0)-(Kills(blocker,body)?body.Value:0);
                if(trade<worstTrade){worst=blocker;worstTrade=trade;}
                if(worstTrade<=-body.Value&&blockable>=minimum)break;
            }
            if(blockable<minimum)worst=null;
            int damage=worst==null?body.Damage:body.Trample?Math.Max(0,body.Damage-worst.Health):0;
            bool towardPlayer=ReferenceEquals(target.Reference,enemy.Reference);
            bool lethal=towardPlayer&&predictedDamage+damage>=enemyLife;
            bool exposed=!body.Vigilance&&defense<=1&&enemyAttack>=g.Life(1);
            int value=worst==null?damage:(worstTrade+damage);
            if(!lethal&&(exposed||value<0||value==0&&!AggressiveBot))continue;
            C(combat,"addAttacker","("+BotCard+"Lforge/game/GameEntity;)V",body.Card,target);
            if(!body.Vigilance)defense--;
            if(worst!=null)blockers.Remove(worst);
            if(towardPlayer)predictedDamage+=damage;
        }
        return S(CombatUtil,"validateAttackers","("+CombatObject+")Z",combat).Int!=0;
    }

    bool BotBlock(JValue combat)
    {
        var attackers=Items(C(combat,"getAttackers","()Lforge/game/card/CardCollection;")).Select(Fighter)
            .OrderByDescending(body=>body.Damage).ToArray();
        var blockers=Zone(1,"Battlefield").Where(card=>B(card,"isCreature")&&!B(card,"isTapped")).Select(Fighter).ToList();
        bool AtPlayer(BotFighter body)=>ReferenceEquals(C(combat,"getDefenderByAttacker","("+BotCard+")Lforge/game/GameEntity;",body.Card).Reference,g.Players[1].Reference);
        int incoming=attackers.Where(AtPlayer).Sum(body=>body.Damage);
        foreach(var attacker in attackers){
            if(attacker.Damage<=0)continue;
            bool direct=AtPlayer(attacker);
            bool emergency=direct&&incoming>=g.Life(1);
            int minimum=BotMinimumBlockers(attacker.Card,g.Players[1]);
            bool Legal(BotFighter blocker)=>S(CombatUtil,"canBlock","("+BotCard+BotCard+CombatObject+")Z",attacker.Card,blocker.Card,combat).Int!=0;
            if(minimum>1){
                var group=blockers.Where(Legal).OrderBy(body=>body.Value).ThenByDescending(body=>body.Power).Take(minimum).ToArray();
                if(group.Length<minimum)continue;
                bool tradesWell=!attacker.Indestructible&&group.Sum(body=>body.Damage)>=attacker.Health&&group.Sum(body=>body.Value)<=attacker.Value;
                if(!emergency&&!tradesWell)continue;
                foreach(var body in group){
                    C(combat,"addBlocker","("+BotCard+BotCard+")V",attacker.Card,body.Card);
                    blockers.Remove(body);
                }
                if(direct)incoming-=attacker.Trample?Math.Min(attacker.Damage,group.Sum(body=>body.Health)):attacker.Damage;
                continue;
            }
            BotFighter? best=null;
            int bestScore=0;
            foreach(var blocker in blockers){
                if(!Legal(blocker))continue;
                int prevented=attacker.Trample?Math.Min(attacker.Damage,blocker.Health):attacker.Damage;
                bool dies=Kills(attacker,blocker),kill=Kills(blocker,attacker);
                int score=(kill?attacker.Value:0)-(dies?blocker.Value*2:0)+prevented*(emergency?20:direct?2:1);
                if(score<=bestScore)continue;
                best=blocker;bestScore=score;
            }
            if(best==null)continue;
            blockers.Remove(best);
            C(combat,"addBlocker","("+BotCard+BotCard+")V",attacker.Card,best.Card);
            if(direct)incoming-=attacker.Trample?Math.Min(attacker.Damage,best.Health):attacker.Damage;
        }
        return S(CombatUtil,"validateBlocks","("+CombatObject+BotPlayer+")Ljava/lang/String;",combat,g.Players[1]).Reference==null;
    }
}
