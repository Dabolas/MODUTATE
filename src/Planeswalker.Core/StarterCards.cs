#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;

namespace Planeswalker.Core
{
    public sealed class StarterCard
    {
        public string Name { get; }
        public int Generic { get; }
        public int SnowCost { get; }
        public int XSymbols { get; }
        public ManaSymbol[] AlternativeCosts { get; }
        public int Colorless { get; }
        public bool Snow { get; }
        public bool NoMaximumHandSize { get; }
        public string TypeLine { get; }
        public int ColorMask { get; }
        public int White { get; }
        public int Red { get; }
        public int Blue { get; }
        public int Black { get; }
        public int Green { get; }
        public int[] ColoredCost => new[]{White,Blue,Black,Red,Green,Colorless};
        public int Power { get; }
        public int Toughness { get; }
        public string Kind { get; }
        public RuleEffect[] Effects { get; }
        public RuleTrigger[] Triggers { get; }
        public RuleTarget Target { get; }
        public bool Artifact => TypeLine.Split(' ').Contains("Artifact")||Kind=="EnergyArtifact"||Kind=="RingArtifact"||Kind=="Artifact";
        public bool Enchantment => TypeLine.Split(' ').Contains("Enchantment")||Kind=="Aura"||Kind=="Enchantment";
        public bool Permanent => Creature||Kind=="Artifact"||Kind=="RingArtifact"||Kind=="Enchantment";
        public string Text { get; }
        public bool Flying { get; }
        public bool Haste { get; }
        public bool Vigilance { get; }
        public bool CannotBlock { get; }
        public RuleKeyword Keywords { get; }
        public int ToxicValue { get; }
        public bool Has(RuleKeyword keyword) => (Keywords & keyword)!=0;
        public int Damage { get; }
        public int LandColor => Kind=="Wastes"?5: Kind=="Plains"?0:Kind=="Island"?1:Kind=="Swamp"?2:Kind=="Mountain"?3:Kind=="Forest"?4:-1;
        public bool Land => LandColor>=0;
        public bool Creature => Kind == "Creature";
        public bool Instant => Has(RuleKeyword.Flash) || Kind == "Instant" || Kind == "Salve" || Kind=="Exile" || Kind=="Poison";
        internal StarterCard(string name, string kind, int generic=0, int white=0, int red=0, int power=0, int toughness=0,
            bool flying=false, bool haste=false, bool vigilance=false, bool cannotBlock=false, int damage=0, string text="",int blue=0,int black=0,int green=0,int snowCost=0,bool snow=false,string typeLine="",int colorless=0,RuleKeyword keywords=RuleKeyword.None,RuleTarget target=RuleTarget.None,RuleEffect[]? effects=null,RuleTrigger[]? triggers=null,string[]? alternativeCosts=null,int xSymbols=0,int colorMask=-1,int toxicValue=0,bool noMaximumHandSize=false)
        { NoMaximumHandSize=noMaximumHandSize;ColorMask=colorMask>=0?colorMask:Enumerable.Range(0,5).Where(i=>new[]{white,blue,black,red,green}[i]>0||(alternativeCosts??Array.Empty<string>()).Any(s=>s.Split('/').Contains("WUBRG"[i].ToString()))).Aggregate(0,(mask,i)=>mask|(1<<i));
          XSymbols=xSymbols;AlternativeCosts=(alternativeCosts??Array.Empty<string>()).Select(s=>new ManaSymbol(s)).ToArray(); Name=name; Kind=kind; Target=target;Effects=effects??Array.Empty<RuleEffect>();Triggers=triggers??Array.Empty<RuleTrigger>(); Generic=generic; White=white; Red=red; Power=power; Toughness=toughness;
          if(toxicValue<0)throw new ArgumentOutOfRangeException(nameof(toxicValue));ToxicValue=toxicValue;
          Keywords=keywords|(flying?RuleKeyword.Flying:0)|(haste?RuleKeyword.Haste:0)|(vigilance?RuleKeyword.Vigilance:0);
          Flying=flying||Has(RuleKeyword.Flying); Haste=haste||Has(RuleKeyword.Haste); Vigilance=vigilance||Has(RuleKeyword.Vigilance); CannotBlock=cannotBlock; Damage=damage; Text=text; Blue=blue; Black=black; Green=green; Colorless=colorless; SnowCost=snowCost; Snow=snow; TypeLine=typeLine; }
    }

    public static partial class StarterCards
    {
        private static readonly Dictionary<string, StarterCard> cards = new Dictionary<string, StarterCard>(StringComparer.Ordinal)
        {
            ["The One Ring"]=new StarterCard("The One Ring","RingArtifact",generic:4,typeLine:"Legendary Artifact",keywords:RuleKeyword.Indestructible,text:"施放后进场触发：直到你的下个回合获得反任何保护。维持时按负担数失去生命。横置：放一个负担，再按负担数抓牌。"),
            ["Plains"]=new StarterCard("Plains","Plains",text:"横置：加一点白色法术力。"),
            ["Mountain"]=new StarterCard("Mountain","Mountain",text:"横置：加一点红色法术力。"),
            ["Savannah Lions"]=new StarterCard("Savannah Lions","Creature",white:1,power:2,toughness:1),
            ["Suntail Hawk"]=new StarterCard("Suntail Hawk","Creature",white:1,power:1,toughness:1,flying:true,text:"飞行"),
            ["Leonin Skyhunter"]=new StarterCard("Leonin Skyhunter","Creature",white:2,power:2,toughness:2,flying:true,text:"飞行"),
            ["Silvercoat Lion"]=new StarterCard("Silvercoat Lion","Creature",generic:1,white:1,power:2,toughness:2),
            ["Glory Seeker"]=new StarterCard("Glory Seeker","Creature",generic:1,white:1,power:2,toughness:2),
            ["Elite Vanguard"]=new StarterCard("Elite Vanguard","Creature",white:1,power:2,toughness:1),
            ["Serra Angel"]=new StarterCard("Serra Angel","Creature",generic:3,white:2,power:4,toughness:4,flying:true,vigilance:true,text:"飞行，警戒"),
            ["Pacifism"]=new StarterCard("Pacifism","Aura",generic:1,white:1,text:"结附于生物。所结附的生物不能攻击或阻挡。"),
            ["Healing Salve"]=new StarterCard("Healing Salve","Salve",white:1,text:"选择一项：目标牌手获得3点生命；或防止本回合接下来将对任意一个目标造成的3点伤害。"),
            ["Raging Goblin"]=new StarterCard("Raging Goblin","Creature",red:1,power:1,toughness:1,haste:true,text:"敏捷"),
            ["Goblin Piker"]=new StarterCard("Goblin Piker","Creature",generic:1,red:1,power:2,toughness:1),
            ["Goblin Raider"]=new StarterCard("Goblin Raider","Creature",generic:1,red:1,power:2,toughness:2,cannotBlock:true,text:"不能阻挡"),
            ["Hill Giant"]=new StarterCard("Hill Giant","Creature",generic:3,red:1,power:3,toughness:3),
            ["Lightning Bolt"]=new StarterCard("Lightning Bolt","Instant",red:1,damage:3,text:"对任意一个目标造成3点伤害。"),
            ["Shock"]=new StarterCard("Shock","Instant",red:1,damage:2,text:"对任意一个目标造成2点伤害。"),
            ["Volcanic Hammer"]=new StarterCard("Volcanic Hammer","Sorcery",generic:1,red:1,damage:3,text:"对任意一个目标造成3点伤害。"),
            ["Canyon Minotaur"]=new StarterCard("Canyon Minotaur","Creature",generic:3,red:1,power:3,toughness:3),
            ["Fire Elemental"]=new StarterCard("Fire Elemental","Creature",generic:3,red:2,power:5,toughness:4),
            ["Wastes"]=new StarterCard("Wastes","Wastes",typeLine:"Basic Land",text:"横置：加一点无色法术力。"),
            ["Snow-Covered Plains"]=new StarterCard("Snow-Covered Plains","Plains",snow:true,text:"横置：加一点白色法术力；保留雪境来源记录。"),
            ["Snow-Covered Island"]=new StarterCard("Snow-Covered Island","Island",snow:true,text:"横置：加一点蓝色法术力；保留雪境来源记录。"),
            ["Snow-Covered Swamp"]=new StarterCard("Snow-Covered Swamp","Swamp",snow:true,text:"横置：加一点黑色法术力；保留雪境来源记录。"),
            ["Snow-Covered Mountain"]=new StarterCard("Snow-Covered Mountain","Mountain",snow:true,text:"横置：加一点红色法术力；保留雪境来源记录。"),
            ["Snow-Covered Forest"]=new StarterCard("Snow-Covered Forest","Forest",snow:true,text:"横置：加一点绿色法术力；保留雪境来源记录。"),
            ["Snow-Covered Wastes"]=new StarterCard("Snow-Covered Wastes","Wastes",snow:true,typeLine:"Basic Snow Land",text:"横置：加一点无色法术力；保留雪境来源记录。"),
            ["Icehide Golem"]=new StarterCard("Icehide Golem","Creature",snow:true,snowCost:1,power:2,toughness:2,typeLine:"Snow Artifact Creature — Golem",text:"{S}：只能用由雪境来源产生的法术力支付。"),
            ["Island"]=new StarterCard("Island","Island",text:"横置：加一点蓝色法术力。"),
            ["Swamp"]=new StarterCard("Swamp","Swamp",text:"横置：加一点黑色法术力。"),
            ["Forest"]=new StarterCard("Forest","Forest",text:"横置：加一点绿色法术力。"),
            ["Swords to Plowshares"]=new StarterCard("Swords to Plowshares","Exile",white:1,text:"放逐目标生物。其操控者获得等同于其力量的生命。"),
            ["Prologue to Phyresis"]=new StarterCard("Prologue to Phyresis","Poison",generic:1,blue:1,text:"每位对手各获得一个中毒指示物。抓一张牌。"),
            ["Contentious Plan"]=new StarterCard("Contentious Plan","Proliferate",generic:1,blue:1,text:"增殖，然后抓一张牌。"),
            ["Volt Charge"]=new StarterCard("Volt Charge","Instant",generic:2,red:1,damage:3,text:"对任意一个目标造成3点伤害，然后增殖。"),
            ["Woodweaver's Puzzleknot"]=new StarterCard("Woodweaver's Puzzleknot","EnergyArtifact",generic:2,text:"进场时，你获得3点生命与3个能量指示物。{2}{G}，牺牲：你获得3点生命与3个能量指示物。")
        };
        static StarterCards() { AddMigratedCards(); }
        static partial void AddMigratedCards();
        private static readonly IReadOnlyDictionary<string,StarterCard> readOnlyCards=new System.Collections.ObjectModel.ReadOnlyDictionary<string,StarterCard>(cards);
        public static IReadOnlyDictionary<string, StarterCard> All => readOnlyCards;
        public static StarterCard Get(string name) => cards.TryGetValue(name, out var card) ? card : throw new ArgumentException("尚未实现此卡牌："+name);
        #if !SHIPPING_MOD
        public static string[] Deck(string id)
        {
            if(id=="combat") return Enumerable.Repeat("Mountain",12).Concat(Enumerable.Repeat("Swamp",12)).Concat(new[]{"Bilious Skulldweller","Flensermite","Sickle Ripper","Borderland Marauder","Audacious Thief","Markov Blademaster","Phyrexian Digester","Shock","Murder"}.SelectMany(n=>Enumerable.Repeat(n,4))).ToArray();
            if(id=="tokens") return Enumerable.Repeat("Plains",24).Concat(new[]{"Raise the Alarm","Secure the Wastes","Midnight Haunting","Doomed Traveler","Soul Warden","Lone Missionary","Suntail Hawk","Pacifism","Swords to Plowshares"}.SelectMany(n=>Enumerable.Repeat(n,4))).ToArray();
            if(id=="rules") return Enumerable.Repeat("Island",12).Concat(Enumerable.Repeat("Swamp",12)).Concat(new[]{"Counterspell","Unsummon","Divination","Murder","Child of Night","Typhoid Rats","Walking Corpse","Wind Drake","Snapping Drake"}.SelectMany(n=>Enumerable.Repeat(n,4))).ToArray();
            if(id=="triggers") return Enumerable.Repeat("Plains",12).Concat(Enumerable.Repeat("Forest",12)).Concat(new[]{"Soul Warden","Elvish Visionary","Lone Missionary","Giant Growth","Garruk's Companion","Serra Angel","Grizzly Bears","Pacifism","Suntail Hawk"}.SelectMany(n=>Enumerable.Repeat(n,4))).ToArray();
            if(id=="snow") return Enumerable.Repeat("Snow-Covered Plains",12).Concat(Enumerable.Repeat("Snow-Covered Forest",12)).Concat(new[]{"Icehide Golem","Savannah Lions","Suntail Hawk","Silvercoat Lion","Serra Angel","Woodweaver's Puzzleknot","Healing Salve","Pacifism","Elite Vanguard"}.SelectMany(n=>Enumerable.Repeat(n,4))).ToArray();
            if(id=="counters") return Enumerable.Repeat("Plains",8).Concat(Enumerable.Repeat("Island",8)).Concat(Enumerable.Repeat("Forest",8))
                .Concat(new[]{"Swords to Plowshares","Prologue to Phyresis","Contentious Plan","Woodweaver's Puzzleknot","Elite Vanguard","Suntail Hawk","Glory Seeker","Pacifism","Healing Salve"}.SelectMany(n=>Enumerable.Repeat(n,4))).ToArray();
            string[] names = id == "white" ? new[]{"Savannah Lions","Suntail Hawk","Leonin Skyhunter","Silvercoat Lion","Glory Seeker","Elite Vanguard","Serra Angel","Pacifism","Healing Salve"} :
                id == "red" ? new[]{"Raging Goblin","Goblin Piker","Goblin Raider","Hill Giant","Lightning Bolt","Shock","Volcanic Hammer","Canyon Minotaur","Fire Elemental"} : throw new ArgumentException("当前支持 white / red / counters / snow / rules / triggers / tokens / combat 预设卡组。");
            return Enumerable.Repeat(id=="white"?"Plains":"Mountain",24).Concat(names.SelectMany(n=>Enumerable.Repeat(n,4))).ToArray();
        }
        #endif
    }
}
