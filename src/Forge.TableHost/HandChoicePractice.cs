using Planeswalker.ForgeConsole;

public sealed partial class HeadlessMatch
{
    public static HeadlessMatch CreateHandChoicePractice(CardDatabase db,byte[] types,byte[] messages)
    {
        string[] opening={"Endurance","Grizzly Bears","Shardless Agent","Wistfulness","Faithless Looting","Cavern of Souls","Preordain"};
        var match=new HeadlessMatch(db,types,messages,opening,Enumerable.Repeat("Plains",20).ToArray(),445);
        match.FirstMainFixture=game=>{
            foreach(string name in new[]{"Wood Elves","Memnite","Forest","Island","Mountain","Plains"})
                game.Card(name,0,"Library");
            game.Fund(0,"RUUU");
        };
        return match;
    }
}
