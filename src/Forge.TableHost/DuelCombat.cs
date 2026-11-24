using Planeswalker.Core;
using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    JHostResult CombatChoice(int seat,JValue combat,bool attacking)
    {
        if(phaseLesson!=null&&lessonStep==6)return PhaseLessonCombat(seat,combat,attacking);
        if(seat!=0){
            if(TacticalBot&&(attacking?BotAttack(combat):BotBlock(combat)))return JHostResult.Complete();
            if(attacking)Attack(seat,combat);else Block(seat,combat);
            return JHostResult.Complete();
        }
        var candidates=Zone(0,"Battlefield").Where(card=>B(card,"isCreature")).ToArray();
        if(skippingTurn==C(g.Phase,"getTurn","()I").Int){
            bool mayPass=attacking?S("forge/game/combat/CombatUtil","validateAttackers","(Lforge/game/combat/Combat;)Z",combat).Int!=0:
                S("forge/game/combat/CombatUtil","validateBlocks","(Lforge/game/combat/Combat;Lforge/game/player/Player;)Ljava/lang/String;",combat,g.Players[0]).Reference==null;
            if(mayPass)return JHostResult.Complete();
        }
        if(!attacking)return ChooseBlockers(combat,candidates);
        var pairs=new List<(JValue Card,JValue Target)>();
        var defenders=Items(C(combat,"getDefenders","()Lforge/util/collect/FCollectionView;"));
        foreach(var card in candidates)
            foreach(var target in defenders)
                if(S("forge/game/combat/CombatUtil","canAttack","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z",card,target).Int!=0)
                    pairs.Add((card,target));
        return pairs.Count==0?JHostResult.Complete():ChooseAttackers(combat,pairs);
    }
    void ProjectCombat(MatchView view,JValue combat)
    {
        var board=view.players.SelectMany(p=>p.cards).Where(c=>c.zone=="Battlefield").ToDictionary(c=>c.id);
        var blocking=new Dictionary<int,List<int>>();
        foreach(var attacker in Items(C(combat,"getAttackers","()Lforge/game/card/CardCollection;"))){
            int id=C(attacker,"getId","()I").Int;
            if(!board.TryGetValue(id,out var row))continue;
            row.attacking=true;
            row.attackTarget=Target(C(combat,"getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;",attacker));
            foreach(var blocker in Items(C(combat,"getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;",attacker))){
                int blockerId=C(blocker,"getId","()I").Int;
                if(!blocking.TryGetValue(blockerId,out var defended))blocking.Add(blockerId,defended=new List<int>());
                defended.Add(id);
            }
        }
        foreach(var row in board.Values){
            row.blockingAttackerIds=blocking.TryGetValue(row.id,out var defended)?defended.ToArray():Array.Empty<int>();
            row.blockingAttackerId=row.blockingAttackerIds.FirstOrDefault();
        }
    }
    sealed class BotDecisions(long seed)
    {
        readonly Random random=new(unchecked((int)(seed^(seed>>32))));
        public int ChooseInteger(string kind,int minimum,int maximum)=>(int)(minimum+Math.Floor(random.NextDouble()*((long)maximum-minimum+1)));
        public int Choose(string kind,IEnumerable<string> offered,int? preferred=null){
            int count=offered.Count();
            if(count==0)throw new HostDecisionGap(kind+": no legal options");
            return preferred??random.Next(count);
        }
        public T Pick<T>(string kind,T[] values,Func<T,string> label)=>values[Choose(kind,values.Select(label))];
        public T[] Shuffle<T>(string kind,IEnumerable<T> values,Func<T,string> label){
            var list=values.ToArray();
            for(int i=list.Length-1;i>0;i--){int j=random.Next(i+1);(list[i],list[j])=(list[j],list[i]);}
            return list;
        }
    }
}
