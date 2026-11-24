using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public static void SelfUntapChoiceRegression(string root,Action<bool,string> check)=>
        HostCases(root,"self-untap-choice",check,(match,verify,variant,seed)=>{
            var game=match.g;
            var card=game.Card(variant==0?"Sleep-Cursed Faerie":"Horseshoe Crab",0,"Battlefield");
            var other=game.Card(variant==0?"Horseshoe Crab":"Sleep-Cursed Faerie",0,"Battlefield");
            var ability=match.ActivatedAbility(card);
            var otherAbility=match.ActivatedAbility(other);
            game.Fund(0,"UUUUCC");
            verify(match.B(ability,"canPlay"),"The ability remains legally activatable while untapped");
            verify(!match.ShouldUseUntap(card,ability)&&match.ChooseAction(0).Reference==null,
                "The bot yields priority when its only offered moves would untap already untapped creatures");
            foreach(var creature in new[]{card,other})match.C(creature,"setTapped","(Z)V",JValue.I(1));
            verify(match.ShouldUseUntap(card,ability),"Tap the source and the bot can use its self-untap");
            verify(match.Play(ability,0),"The real self-untap ability reaches the stack");
            verify(!match.ShouldUseUntap(card,ability)&&match.ShouldUseUntap(other,otherAbility),
                "Only the same source's redundant activation is omitted while its untap is pending");
            game.ResolveOne();
            verify(!match.B(card,"isTapped")&&!match.ShouldUseUntap(card,ability),"Normal resolution untaps the source");
            match.C(card,"setTapped","(Z)V",JValue.I(1));
            verify(match.ShouldUseUntap(card,ability),"A later tap restores the useful activation");
        });
}
