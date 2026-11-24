using Planeswalker.ForgeConsole;
using Planeswalker.TableHost;

public sealed partial class HeadlessMatch
{
    public const long LandAbilityPracticeSeed=518;

    public static HeadlessMatch CreateLandAbilityPractice(CardDatabase db,byte[] types,byte[] messages)
    {
        var human=new DuelDeck(new[]{"Chromatic Star","Soul-Guide Lantern","Wastes","Wastes","Wastes","Wastes","Wastes"});
        var bot=new DuelDeck(Enumerable.Repeat("Plains",20).ToArray());
        var match=new HeadlessMatch(db,types,messages,human,bot,LandAbilityPracticeSeed);
        match.FirstMainFixture=game=>{
            game.Card("Crawling Barrens",0,"Battlefield");
            game.Card("Field of Ruin",0,"Battlefield");
            for(int i=0;i<4;i++)game.Card("Wastes",0,"Battlefield");
            game.Card("Temple Garden",1,"Battlefield");
            for(int i=0;i<12;i++)game.Card("Wastes",0,"Library");
        };
        return match;
    }
}
