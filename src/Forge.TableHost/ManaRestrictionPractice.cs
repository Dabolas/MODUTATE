using Planeswalker.ForgeConsole;
using Planeswalker.TableHost;

public sealed partial class HeadlessMatch
{
    public const long ManaRestrictionPracticeSeed=517;

    public static HeadlessMatch CreateManaRestrictionPractice(CardDatabase db,byte[] types,byte[] messages)
    {
        var human=new DuelDeck(new[]{"Golem Artisan","Kozilek's Channeler","Wastes","Wastes","Wastes","Wastes","Wastes"});
        var bot=new DuelDeck(Enumerable.Repeat("Plains",20).ToArray());
        var match=new HeadlessMatch(db,types,messages,human,bot,ManaRestrictionPracticeSeed);
        match.FirstMainFixture=game=>{
            game.Card("Mishra's Workshop",0,"Battlefield");
            game.Card("Wastes",0,"Battlefield");
            game.Card("Wastes",0,"Battlefield");
            for(int i=0;i<12;i++)game.Card("Wastes",0,"Library");
        };
        return match;
    }
}
