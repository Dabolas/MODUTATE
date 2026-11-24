using System.Globalization;

namespace Planeswalker.ForgeConsole;

public sealed class RuleGapException : Exception
{
    public string Code { get; }
    public RuleGapException(string code,string message):base(message){Code=code;}
}
public sealed record FixtureRule(bool Land,char ManaColor,int Generic,IReadOnlyDictionary<char,int> Colors,int Damage,IReadOnlyDictionary<string,string> Parameters);
public static class FixtureCompiler
{
    // A declared, deliberately narrow vertical slice. This is not the all-rules support table.
    public static FixtureRule Compile(CardDefinition definition)
    {
        var fields=definition.Fields;
        if(fields.Count(f=>f.Key=="Name")!=1)throw new RuleGapException("multiface","Multiple faces require full game-state support.");
        foreach(string key in new[]{"K","T","R","S","SVar","DeckRules","AlternateMode","Specialize","MeldPair"})
            if(fields.Any(f=>f.Key==key))throw new RuleGapException("rule-family:"+key,"The controlled empty-board fixture does not implement "+key+".");
        string types=definition.Value("Types");
        var names=new Dictionary<string,char>(StringComparer.Ordinal){{"Plains",'W'},{"Island",'U'},{"Swamp",'B'},{"Mountain",'R'},{"Forest",'G'},{"Wastes",'C'}};
        if(types.Split(' ').Contains("Basic")&&types.Split(' ').Contains("Land")&&names.TryGetValue(definition.Name,out char color)&&!fields.Any(f=>f.Key=="A"))
            return new FixtureRule(true,color,0,new Dictionary<char,int>(),0,new Dictionary<string,string>());
        if(types!="Instant"&&types!="Sorcery")throw new RuleGapException("card-type","This fixture executes simple damage spells and basic lands only.");
        var abilities=fields.Where(f=>f.Key=="A").ToArray();
        if(abilities.Length!=1)throw new RuleGapException("ability-count","A single damage spell ability is required.");
        var map=new Dictionary<string,string>(StringComparer.Ordinal);
        foreach(string part in abilities[0].Value.Split('|'))
        {int at=part.IndexOf('$');if(at<1||!map.TryAdd(part[..at].Trim(),part[(at+1)..].Trim()))throw new RuleGapException("ability-syntax","Unknown or repeated ability parameter.");}
        foreach(string key in map.Keys)if(!new[]{"SP","ValidTgts","NumDmg","SpellDescription","TgtPrompt"}.Contains(key))throw new RuleGapException("parameter:"+key,"No fixture adapter for "+key+".");
        if(!map.TryGetValue("SP",out var op)||op!="DealDamage"||map.GetValueOrDefault("ValidTgts")!="Any")throw new RuleGapException("effect","Not an unconditional, any-target damage spell.");
        if(!int.TryParse(map.GetValueOrDefault("NumDmg"),NumberStyles.None,CultureInfo.InvariantCulture,out int damage)||damage<0||damage>1000000)throw new RuleGapException("damage-expression","Dynamic damage amount requires the full expression runtime.");
        int generic=0;var colors=new Dictionary<char,int>();
        foreach(string item in definition.Value("ManaCost").Split(' ',StringSplitOptions.RemoveEmptyEntries))
        {
            if(int.TryParse(item,NumberStyles.None,CultureInfo.InvariantCulture,out int n)&&n<=1000000)generic=checked(generic+n);
            else if(item.Length==1&&"WUBRGC".Contains(item[0]))colors[item[0]]=colors.GetValueOrDefault(item[0])+1;
            else throw new RuleGapException("mana-symbol","Variable, hybrid or special mana is outside this ignition fixture.");
        }
        foreach(var field in fields)
            if(!new[]{"Name","Types","ManaCost","A","Oracle","DeckHints","DeckHas","DeckNeeds","AI"}.Contains(field.Key)&&field.Key.Length!=0&&!field.Key.StartsWith('#'))throw new RuleGapException("field:"+field.Key,"Unreviewed gameplay field.");
        return new FixtureRule(false,'\0',generic,colors,damage,map);
    }
}
