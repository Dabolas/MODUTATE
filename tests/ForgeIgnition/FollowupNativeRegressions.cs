using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public static void PrintfRegression(string root,Action<bool,string> check)=>HostCases(root,"printf",check,(d,v,resources,seed)=>{
        var g=d.g;
        if(resources==0&&seed==1)
        {
            var output=g.Rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;");var args=g.Rt.NewArray("Ljava/lang/Object;",2);args.Items[0]=g.Rt.BoxInt(7);args.Items[1]=g.S("mana");
            var returned=d.C(output,"printf","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;",g.S("%2$s:%1$03d:%<x%n"),JValue.R(args));
            v(ReferenceEquals(returned.Reference,output.Reference),"printf returns its original PrintStream for chaining");
            v(g.Trace.Last(s=>s.StartsWith("output ")).TrimEnd()=="output mana:007:7","printf shares Java indexed/previous argument and width formatting");
            try {d.C(output,"printf","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;",default,JValue.R(args));v(false,"Null format must throw");}
            catch(JavaFault ex){v(ex.Value.ClassName=="java/lang/NullPointerException","printf rejects a null format");}
        }
        var victim=g.Card("Raging Goblin",1,"Battlefield");var card=g.Card("Goblin Negotiation",0,"Hand");var sa=g.Ability(card,0);
        int amount=d.S("forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I",card,g.S("Excess"),sa).Int;
        v(amount==0&&g.Trace.Any(s=>s.Contains("SVar 'Excess' not defined in Card (Goblin Negotiation)")),"Real Negotiation's initially unset Excess logs through printf and returns zero");
        d.C(sa,"setXManaCostPaid","(Ljava/lang/Integer;)V",g.Rt.BoxInt(4));g.Fund(0,resources==1?"R R R R R R":"R");
        var ctrl=d.C(g.Players[0],"getController","()Lforge/game/player/PlayerController;");
        bool cast=d.S("forge/game/player/PlaySpellAbility","playSpellAbility","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Z",ctrl,g.Players[0],sa).Int!=0;
        v(cast==(resources==1),"Negotiation requires actual X=4 plus RR payment");
        if(cast){g.ResolveOne();g.Sba();var tokens=d.Zone(0,"Battlefield").Where(c=>d.B(c,"isToken")).ToArray();v(g.In(victim,"Graveyard")&&g.In(card,"Graveyard")&&g.ManaCount(0)==0&&tokens.Length==3&&tokens.All(c=>d.C(c,"getNetPower","()I").Int==1&&d.C(c,"getNetToughness","()I").Int==1),"Four damage to a 1/1 creates exactly three real 1/1 Goblins from excess damage");}
        else v(g.In(victim,"Battlefield")&&g.In(card,"Hand")&&g.ManaCount(0)==1&&!d.Zone(0,"Battlefield").Any(c=>d.B(c,"isToken")),"Unpayable Negotiation rolls back without damage, tokens or spent mana");
    });
    public static void PossessiveRegexRegression(string root,Action<bool,string> check)=>HostCases(root,"possessive-regex",check,(d,v,resources,seed)=>{
        var g=d.g;
        if(resources==0&&seed==1)
        {
            bool Matches(string pattern,string input){var p=d.S("java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;",g.S(pattern));return d.B(d.C(p,"matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;",g.S(input)),"matches");}
            foreach(var row in new[]{("a++a","aa",false),("a+a","aa",true),("(?:ab)++ab","abab",false),("a{1,3}+a","aaa",false),("a{1,3}+a","aaaa",true),("a?+a","a",false),("a*+b","aaab",true),(@"\++","++",true),("[ab]++c","ababc",true),("(?:a|b)++c","abc",true)})
                v(Matches(row.Item1,row.Item2)==row.Item3,"Java possessive semantics: "+row.Item1+" / "+row.Item2);
            var p=d.S("java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;",g.S(@"(?:\\.|[^_\\]++)+"));
            var m=d.C(p,"matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;",g.S(@"Forest\_Snow_GE1"));var parts=new List<string>();
            while(d.B(m,"find"))parts.Add(g.Rt.StringValue(d.C(m,"group","()Ljava/lang/String;")));
            v(parts.SequenceEqual(new[]{@"Forest\_Snow","GE1"}),"PlayerProperty delimiter parser preserves escaped underscore");
        }
        var dog=g.Card("Zodiac Dog",0,"Battlefield");var blocker=g.Card("Hill Giant",1,"Battlefield");
        if(resources==1)g.Card("Mountain",1,"Battlefield");
        bool canBlock=d.S("forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",dog,blocker).Int!=0;
        v(canBlock==(resources==0),"Real Zodiac Dog mountainwalk prevents blocking exactly when defender controls a Mountain");
        v(g.Rt.ExecutedMethods.Any(s=>s.StartsWith("forge/game/player/PlayerProperty.playerHasProperty")),"Real combat legality reaches PlayerProperty's regex path");
    });
}
