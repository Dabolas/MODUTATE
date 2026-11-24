using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
using System.Text.Json;

public sealed partial class HeadlessMatch
{
    public static void RepresentativeMatrix(string root,Action<bool,string> check)
    {
        (string card,string[] branches)[] cards=[
            ("Llanowar Visionary",["draw-and-tap"]), ("Rest in Peace",["graveyards","discard","sacrifice","lethal","token"]),
            ("Arc Lightning",["3","1+2","1+1+1"]), ("Fireball",["five-two","short","zero-x","zero-targets"]),
            ("Divination",["draw"]), ("Healing Salve",["gain","shield","expire"]), ("Giant Growth",["cleanup"]),
            ("Unsummon",["borrowed"]), ("Raise the Alarm",["soldiers"]), ("Counterspell",["counter","target-gone"])];
        var folder=BatchPaths.Output(root,"release/forge-headless/fixed-ten");
        Directory.CreateDirectory(folder);
        var db=CardDatabase.Load(Path.Combine(root,"data/forge"));
        var program=ForgeProgram.BuildForDevelopment();
        var results=new List<object>();
        int failed=0;
        foreach(var (card,branches) in cards)
        foreach(string branch in branches)
        {
            long seed=44000+results.Count/2;
            for(int repeat=1;repeat<=2;repeat++)
            {
                string dir=Path.Combine(folder,$"{seed}-{repeat}");
                Directory.CreateDirectory(dir);
                var definition=db.Create(card).Definition;
                string[] deck=Enumerable.Repeat(card,4).Concat(Enumerable.Repeat("Island",28)).Concat(Enumerable.Repeat("Forest",28)).ToArray();
                var input=new MatchInput(4,seed,60,[deck,deck],"directed");
                File.WriteAllText(Path.Combine(dir,"input.json"),JsonSerializer.Serialize(new{input,card,branch,repeat,definition.Sha256,oracle=definition.Value("Oracle")}));
                using var trace=new TraceJournal(dir);
                using var states=new StreamWriter(Path.Combine(dir,"snapshots.jsonl"));
                using var decisions=new StreamWriter(Path.Combine(dir,"decisions.jsonl"));
                var assertions=new List<string>();
                string? error=null;
                try{
                    var d=new HeadlessMatch(root,program,db,input,trace,states,new(seed,decisions));
                    d.g.Initialize(0,seed,input.Decks);
                    d.Snapshot("registered decks");
                    d.FixedBranch(card,branch,(ok,label)=>{
                        if(!ok)throw new InvalidOperationException(label);
                        assertions.Add(label);
                    });
                    d.Snapshot("after resolution");
                }catch(Exception ex){error=ex.Message;trace.WriteLine(ex.ToString());failed++;}
                var row=new{card,branch,seed,repeat,passed=error==null,error,assertions};
                results.Add(row);
                File.WriteAllText(Path.Combine(dir,"result.json"),JsonSerializer.Serialize(row));
                string matrix=Path.Combine(folder,"matrix.json");
                File.WriteAllText(matrix+".tmp",JsonSerializer.Serialize(results));
                File.Move(matrix+".tmp",matrix,true);
            }
        }
        check(failed==0,$"Fixed ten cards: {results.Count-failed}/{results.Count} repeatable branch runs passed");
    }

    private void FixedBranch(string name,string branch,Action<bool,string> verify)
    {
        var spell=g.Card(name,0,"Hand");
        var sa=g.Ability(spell,0);
        void Cast(string mana,params JValue[] targets){
            g.Fund(0,mana);
            if(targets.Length>0)g.Target(sa,targets);
            Snapshot("before casting "+name);
            verify(g.Cast(spell,sa,0)&&g.In(spell,"Stack")&&g.ManaCount(0)==0,"Printed cost paid and spell on stack");
        }
        void EndTurn()=>C(C(g.Game,"getEndOfTurn","()Lforge/game/phase/Phase;"),"executeUntil","()V");
        int Damage(JValue target)=>C(g.Current(target),"getDamage","()I").Int;
        void Deal(JValue target,int amount){
            var damage=g.New("forge/game/card/CardDamageTable","()V");
            var source=g.Card("Hill Giant",1,"Battlefield");
            C(damage,"put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;",source,target,g.Rt.BoxInt(amount));
            C(g.Action,"dealDamage","(ZLforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;Lforge/game/GameEntityCounterTable;Lforge/game/spellability/SpellAbility;)V",
                JValue.I(0),damage,g.New("forge/game/card/CardDamageTable","()V"),g.New("forge/game/GameEntityCounterTable","()V"),default(JValue));
        }
        void FullTargets(params JValue[] selected)=>g.SetDecision("chooseTargetsFor",(_,a)=>{
            for(var part=a[0];part.Reference!=null;part=C(part,"getSubAbility","()Lforge/game/spellability/AbilitySub;")){
                if(!B(part,"usesTargeting"))continue;
                C(part,"clearTargets","()V");
                g.Target(part,selected);
            }
            return JHostResult.Complete(JValue.I(1));
        });
        switch(name){
        case "Llanowar Visionary":{
            int hand=g.Count(0,"Hand"),library=g.Count(0,"Library");
            Cast("CCG");g.ResolveOne();g.Sba();
            verify(Items(g.Stack).Length==1&&g.Count(0,"Library")==library,"ETB draw is waiting on stack");
            g.Drain();
            verify(g.Count(0,"Hand")==hand&&g.Count(0,"Library")==library-1,"Trigger draws exactly one");
            var current=g.Current(spell);
            C(current,"setSickness","(Z)V",JValue.I(0));
            var mana=Items(C(current,"getManaAbilities","()Lforge/util/collect/FCollectionView;")).Single();
            C(mana,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
            verify(Play(mana,0)&&B(current,"isTapped")&&C(g.ManaPool(0),"getAmountOfColor","(B)I",JValue.I(16)).Int==1,"Tap cost produces one green mana");
            break;}
        case "Rest in Peace":{
            var first=g.Card("Forest",0,"Graveyard");var second=g.Card("Island",1,"Graveyard");
            Cast("CW");g.Drain();
            verify(g.In(first,"Exile")&&g.In(second,"Exile")&&g.Count(0,"Graveyard")+g.Count(1,"Graveyard")==0,"Both players' graveyards exiled");
            if(branch=="graveyards")break;
            var victim=g.Card("Grizzly Bears",0,branch=="discard"?"Hand":"Battlefield");
            if(branch=="token"){
                var alarm=g.Card("Raise the Alarm",0,"Hand");g.Fund(0,"CW");
                verify(g.Cast(alarm,g.Ability(alarm,0),0),"Cast real token maker");g.Drain();
                victim=Zone(0,"Battlefield").First(c=>B(c,"isToken"));
            }
            var parameters=S("forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;");
            if(branch=="discard")C(g.Players[0],"discard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/Card;",victim,sa,JValue.I(1),parameters);
            else if(branch=="lethal"){Deal(victim,2);g.Sba();}
            else C(g.Action,"sacrifice","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/CardCollection;",Cards([victim]),sa,JValue.I(1),parameters);
            int id=C(victim,"getId","()I").Int;
            bool Exists(string zone)=>Zone(0,zone).Any(c=>C(c,"getId","()I").Int==id);
            verify(Exists("Exile")&&!Exists("Graveyard"),branch+" moved object to exile");
            if(branch=="token"){g.Sba();verify(!Exists("Exile")&&!Exists("Graveyard"),"Exiled token ceased to exist at SBA");}
            break;}
        case "Arc Lightning":{
            int[] amounts=branch.Split('+').Select(int.Parse).ToArray();
            var victims=amounts.Select(n=>g.Card(n==3?"Hill Giant":"Rumbling Baloth",1,"Battlefield")).ToArray();
            g.Target(sa,victims);
            for(int i=0;i<amounts.Length;i++)C(sa,"addDividedAllocation","(Lforge/game/GameObject;Ljava/lang/Integer;)V",victims[i],g.Rt.BoxInt(amounts[i]));
            Cast("CCR");g.ResolveOne();
            verify(victims.Select(Damage).SequenceEqual(amounts),"Damage on each target equals allocation "+branch);
            g.Sba();verify(victims.All(v=>g.In(v,amounts.Length==1?"Graveyard":"Battlefield")),"Lethal state action matches damage");break;}
        case "Fireball":{
            int x=branch=="zero-x"?0:5;
            var victim=g.Card("Rumbling Baloth",1,"Battlefield");
            JValue[] targets=branch=="zero-targets"?[]:branch=="zero-x"?[g.Players[1]]:[g.Players[1],victim];
            C(sa,"setXManaCostPaid","(Ljava/lang/Integer;)V",g.Rt.BoxInt(x));
            string mana="R"+new string('C',x+(targets.Length==2&&branch!="short"?1:0));
            g.Fund(0,mana);FullTargets(targets);Snapshot("before Fireball");
            var controller=C(g.Players[0],"getController","()Lforge/game/player/PlayerController;");
            bool accepted=S("forge/game/player/PlaySpellAbility","playSpellAbility","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Z",controller,g.Players[0],sa).Int!=0;
            if(branch=="short"){verify(!accepted&&g.ManaCount(0)==mana.Length&&g.In(spell,"Hand")&&Items(g.Stack).Length==0,"Unpaid additional target rejected with costs refunded");break;}
            verify(accepted&&g.ManaCount(0)==0&&g.In(spell,"Stack"),"X and additional target costs paid");
            g.Drain();verify(g.In(spell,"Graveyard")&&g.Life(1)==(targets.Length==2?18:20)&&Damage(victim)==(targets.Length==2?2:0),"Damage divided with rounding down, zero boundaries respected");break;}
        case "Divination":{
            int hand=g.Count(0,"Hand"),library=g.Count(0,"Library");
            Cast("CCU");g.Drain();verify(g.Count(0,"Hand")==hand+1&&g.Count(0,"Library")==library-2&&g.In(spell,"Graveyard"),"Draw two, net hand +1, spell in graveyard");break;}
        case "Healing Salve":{
            bool gain=branch=="gain";
            g.SetDecision("chooseModeForAbility",(_,a)=>JHostResult.Complete(g.Rt.ListOf([Items(a[1]).Single(m=>g.Rt.InspectEnumName(C(m,"getApi","()Lforge/game/ability/ApiType;"))==(gain?"GainLife":"PreventDamage"))])));
            FullTargets(g.Players[0]);g.Fund(0,"W");Snapshot("before Healing Salve");
            verify(Play(sa,0)&&g.ManaCount(0)==0,"Mode and legal target paid");g.Drain();
            if(gain){verify(g.Life(0)==23,"Gain exactly three life");break;}
            Deal(g.Players[0],1);verify(g.Life(0)==20,"First point prevented");
            if(branch=="expire")EndTurn();
            Deal(g.Players[0],3);verify(g.Life(0)==(branch=="expire"?17:19),"Remaining shield expires or prevents exactly two");
            Deal(g.Players[0],1);verify(g.Life(0)==(branch=="expire"?16:18),"No shield remains");break;}
        case "Giant Growth":{
            var bear=g.Card("Grizzly Bears",0,"Battlefield");
            bool Stats(int n)=>C(bear,"getNetPower","()I").Int==n&&C(bear,"getNetToughness","()I").Int==n;
            verify(Stats(2),"Unmodified 2/2");Cast("G",bear);g.Drain();verify(Stats(5),"Resolved 5/5");EndTurn();verify(Stats(2),"Cleanup restores 2/2");break;}
        case "Unsummon":{
            var bear=g.Card("Grizzly Bears",1,"Battlefield");C(bear,"setController","(Lforge/game/player/Player;J)V",g.Players[0],C(g.Game,"getNextTimestamp","()J"));
            C(g.Action,"controllerChangeZoneCorrection","(Lforge/game/card/Card;)V",bear);
            verify(Seat(C(bear,"getController","()Lforge/game/player/Player;"))==0&&Seat(C(bear,"getOwner","()Lforge/game/player/Player;"))==1,"Different owner and controller");
            Cast("U",bear);g.Drain();verify(Zone(1,"Hand").Any(c=>Label(c)==Label(bear))&&!Zone(0,"Hand").Any(c=>Label(c)==Label(bear)),"Returned to owner's hand");break;}
        case "Raise the Alarm":{
            Cast("CW");g.Drain();var tokens=Zone(0,"Battlefield").Where(c=>B(c,"isToken")).ToArray();
            verify(tokens.Length==2&&g.In(spell,"Graveyard"),"Two tokens, spell in graveyard");
            foreach(var t in tokens)verify(C(t,"getNetPower","()I").Int==1&&C(t,"getNetToughness","()I").Int==1&&Seat(C(t,"getController","()Lforge/game/player/Player;"))==0&&C(C(t,"getColor","()Lforge/card/ColorSet;"),"getColor","()B").Int==1&&C(C(t,"getType","()Lforge/card/CardTypeView;"),"hasSubtype","(Ljava/lang/String;)Z",g.S("Soldier")).Int!=0,"White 1/1 Soldier controlled by caster");break;}
        case "Counterspell":{
            g.SetMain(1);g.Fund(1,"CCU");var draw=g.Card("Divination",1,"Hand");var pending=g.Ability(draw,1);
            verify(g.Cast(draw,pending,1),"Opponent casts Divination");g.SetMain(0);Cast("UU",pending);
            if(branch=="target-gone"){
                var extra=g.Card("Counterspell",0,"Hand");var counter=g.Ability(extra,0);g.Target(counter,pending);g.Fund(0,"UU");
                verify(g.Cast(extra,counter,0),"Second counter targets original spell");g.ResolveOne();g.Sba();
                verify(g.In(draw,"Graveyard")&&g.In(spell,"Stack"),"First counter remains with missing target");
            }
            int library=g.Count(1,"Library");g.Drain();
            verify(g.In(draw,"Graveyard")&&g.In(spell,"Graveyard")&&g.Count(1,"Library")==library&&Items(g.Stack).Length==0,"Spells in graveyard, no draw, stack empty");break;}
        default:throw new ArgumentException(name);
        }
    }
}
