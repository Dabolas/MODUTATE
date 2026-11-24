using Planeswalker.ForgeConsole;
using Planeswalker.TableHost;

public sealed partial class HeadlessMatch
{
    public const long PreparePracticeSeed=452;

    public static HeadlessMatch CreatePreparePractice(CardDatabase db,byte[] types,byte[] messages,Action<string> recordDecision)
    {
        var human=new DuelDeck(new[]{"Emeritus of Ideation","Goblin Glasswright","Island","Island","Mountain","Mountain","Island"});
        var bot=new DuelDeck(Enumerable.Repeat("Island",20).ToArray());
        var match=new HeadlessMatch(db,types,messages,human,bot,PreparePracticeSeed,recordDecision);
        match.FirstMainFixture=game=>{
            foreach(string land in new[]{"Island","Island","Island","Island","Mountain","Mountain"})
                game.Card(land,0,"Battlefield");
            for(int i=0;i<12;i++)game.Card("Island",0,"Library");
        };
        return match;
    }
}
