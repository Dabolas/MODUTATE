using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    void InstallDamageDecisions()
    {
        g.SetDecision("divideShield",(ctrl,args)=>{
            var entries=Items(C(args[1],"entrySet","()Ljava/util/Set;"));
            var maximum=entries.Select(e=>g.Rt.UnboxInt(C(e,"getValue","()Ljava/lang/Object;"))).ToArray();
            long capacity=maximum.Sum(n=>(long)n);
            int left=(int)Math.Min(capacity,args[2].Int);
            var chosen=new List<KeyValuePair<JValue,JValue>>();
            for(int i=0;i<entries.Length;i++){
                var target=C(entries[i],"getKey","()Ljava/lang/Object;");capacity-=maximum[i];
                int min=(int)Math.Max(0,left-capacity),max=Math.Min(left,maximum[i]);
                int amount=ControllerSeat(ctrl)!=0||checkingActions?max:TableNumber("分配给 "+Describe(target)+" 的伤害防止量",min,max);
                if(amount>0)chosen.Add(new(target,g.Rt.BoxInt(amount)));
                left-=amount;
            }
            return JHostResult.Complete(g.Rt.MapOf(chosen));
        });
        Human("assignCombatDamage",a=>{
            var source=a[0];var blockers=Items(a[1]);var defender=a[4];int left=a[3].Int;
            bool K(string keyword)=>C(source,"hasKeyword","(Ljava/lang/String;)Z",g.S(keyword)).Int!=0;
            bool freely=K("You may assign CARDNAME's combat damage divided as you choose among defending player and/or any number of creatures they control.")&&a[5].Int!=0;
            bool toDefender=defender.Reference!=null&&(blockers.Length==0||freely||K("Trample")||K("Trample:Planeswalker")&&g.Rt.IsInstance(defender.Reference,"forge/game/card/Card"));
            var result=new List<KeyValuePair<JValue,JValue>>();
            bool earlierLethal=true,deathtouch=K("Deathtouch"),ordered=a[5].Int==0;
            for(int i=0;i<blockers.Length&&left>0;i++){
                var recipient=blockers[i];
                int lethal=Math.Max(0,C(recipient,"getExcessDamageValue","(Z)I",JValue.I(deathtouch?1:0)).Int);
                bool last=i==blockers.Length-1;
                int min=last&&!toDefender?left:ordered||last&&!freely?Math.Min(left,lethal):0;
                if(last&&!earlierLethal&&!freely)min=left;
                int amount=TableNumber(Name(source)+" · 分配给 "+Name(recipient)+" 的战斗伤害",min,left);
                if(amount>0)result.Add(new(recipient,g.Rt.BoxInt(amount)));
                earlierLethal&=amount>=lethal;left-=amount;
            }
            if(left>0&&toDefender)result.Add(new(default,g.Rt.BoxInt(left)));
            return JHostResult.Complete(g.Rt.MapOf(result));
        });
    }
}
