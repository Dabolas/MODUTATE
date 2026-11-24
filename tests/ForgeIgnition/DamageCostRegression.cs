using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public static void DamageCostRegression(string root,Action<bool,string> check)=>
        HostCases(root,"damage-cost",check,(d,verify,accept,scenario)=>{
            var g=d.g;
            bool devil=scenario%2==1,prevent=scenario>2;
            string name=devil?"Vexing Devil":"Longhorn Firebeast";
            int damage=devil?4:5;
            if(prevent)g.Card("Glacial Chasm",1,"Battlefield");
            int asks=0;
            g.SetDecision("confirmPayment",(ctrl,args)=>{
                verify(d.ControllerSeat(ctrl)==1&&g.Rt.IsInstance(args[0].Reference!,"forge/game/cost/CostDamage"),"Opponent receives the damage-cost choice");
                verify(d.C(args[0],"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",args[2]).Int==damage,"Offered damage matches the printed cost");
                asks++;
                return JHostResult.Complete(JValue.I(accept));
            });
            var creature=g.Card(name,0,"Hand");
            g.Fund(0,devil?"R":"CCR");
            verify(d.Play(g.Ability(creature,0),0),"Cast "+name);
            g.ResolveOne();g.Sba();
            verify(g.In(creature,"Battlefield")&&g.Life(1)==20&&d.C(g.Stack,"size","()I").Int==1,"Creature enters and its trigger waits on the stack");
            g.Drain();
            verify(asks==1,"Exactly one optional payment decision");
            verify(g.Life(1)==20-(accept==1&&!prevent?damage:0)&&g.Life(0)==20,"Engine applies damage and prevention to the payer");
            verify(g.In(creature,accept==1?"Graveyard":"Battlefield"),"Accepting causes sacrifice even when all damage was prevented");
        });
}
