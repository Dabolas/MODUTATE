using Planeswalker.ForgeAot;
using Planeswalker.ForgeConsole;
using Planeswalker.TableHost;

public sealed partial class HeadlessMatch
{
    public static HeadlessMatch CreateRestrictedUntapPractice(CardDatabase db,byte[] types,byte[] messages,
        DuelDeck human,DuelDeck bot,long seed,Action<string> recordDecision)
    {
        var match=new HeadlessMatch(db,types,messages,human,bot,seed,recordDecision);
        match.FirstMainFixture=game=>{
            game.Card("Winter Orb",0,"Battlefield");
            game.Card("Chaos Orb",0,"Battlefield");
            game.Card("Mountain",0,"Battlefield");
            PutTapped("Island",0);
            PutTapped("Forest",0);
            PutTapped("Llanowar Elves",0);
            PutTapped("Plains",1);
            PutTapped("Plains",1);
            PutTapped("Savannah Lions",1);
            game.Call(game.Action,"checkStateEffects","(Z)Z",JValue.I(1));

            void PutTapped(string name,int seat)=>
                game.Call(game.Card(name,seat,"Battlefield"),"setTapped","(Z)V",JValue.I(1));
        };
        return match;
    }
}
