using Planeswalker.ForgeConsole;

public sealed partial class HeadlessMatch
{
    public static HeadlessMatch CreateLegendPractice(CardDatabase database,byte[] types,byte[] messages)
    {
        const string legend="Ajani, Nacatl Pariah";
        string[] opening={legend,"Mountain","Savannah Lions","Plains","Suntail Hawk","Grizzly Bears","Island"};
        var match=new HeadlessMatch(database,types,messages,opening,Enumerable.Repeat("Plains",20).ToArray(),446);
        match.FirstMainFixture=game=>{
            game.Card(legend,0,"Battlefield");
            game.Card(legend,1,"Battlefield");
            game.Card("Plains",0,"Battlefield");
            game.Card("Mountain",0,"Battlefield");
        };
        return match;
    }
}
