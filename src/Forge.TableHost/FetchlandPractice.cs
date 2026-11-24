using Planeswalker.ForgeConsole;

public sealed partial class HeadlessMatch
{
    public static HeadlessMatch CreateFetchlandPractice(CardDatabase db,byte[] types,byte[] messages)
    {
        var match=new HeadlessMatch(db,types,messages,Enumerable.Repeat("Forest",20).ToArray(),
            Enumerable.Repeat("Plains",20).ToArray(),444);
        match.FirstMainFixture=game=>{
            for(int i=0;i<4;i++)game.Card("Scalding Tarn",0,"Battlefield");
            foreach(string land in new[]{"Steam Vents","Steam Vents","Island","Thundering Falls"})
                game.Card(land,0,"Library");
        };
        return match;
    }
}
