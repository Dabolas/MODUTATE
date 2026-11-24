using Planeswalker.ForgeConsole;
using Planeswalker.TableHost;

public sealed partial class HeadlessMatch
{
    public static HeadlessMatch CreateExileSpellPractice(CardDatabase db,byte[] types,byte[] messages)
    {
        var opening=new[]{"March of Otherworldly Light","Savannah Lions","Suntail Hawk","Shock","Plains","Forest","Island"};
        var match=new HeadlessMatch(db,types,messages,new DuelDeck(opening),new DuelDeck(PracticeDecks.Build(false)),448);
        match.FirstMainFixture=game=>{
            game.Card("Plains",0,"Battlefield");
            game.Card("Forest",0,"Library");
            game.Card("Grizzly Bears",1,"Battlefield");
            game.Card("Plains",1,"Battlefield");
            game.Card("Plains",1,"Battlefield");
        };
        return match;
    }
}
