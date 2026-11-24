using Planeswalker.ForgeConsole;
using Planeswalker.TableHost;

public sealed partial class HeadlessMatch
{
    public const long ChannelPracticeSeed=449;

    public static HeadlessMatch CreateChannelPractice(CardDatabase db,byte[] types,byte[] messages)
    {
        var human=new DuelDeck(new[]{"Otawara, Soaring City","Boseiju, Who Endures","Island","Island","Forest","Forest","Plains"});
        var bot=new DuelDeck(Enumerable.Repeat("Mountain",20).ToArray());
        var match=new HeadlessMatch(db,types,messages,human,bot,ChannelPracticeSeed);
        match.FirstMainFixture=game=>{
            foreach(string land in new[]{"Island","Island","Island","Forest","Forest"})
                game.Card(land,0,"Battlefield");
            game.Card("Isamaru, Hound of Konda",0,"Battlefield");
            for(int i=0;i<3;i++)game.Card("Forest",0,"Library");
            game.Card("Steam Vents",1,"Battlefield");
            game.Card("Mountain",1,"Battlefield");
            game.Card("Grizzly Bears",1,"Battlefield");
        };
        return match;
    }
}
