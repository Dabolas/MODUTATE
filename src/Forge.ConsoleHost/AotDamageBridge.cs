using System.Globalization;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;

namespace Planeswalker.ForgeConsole;

public sealed record DamageExecution(int Damage,IReadOnlyList<string> Methods,IReadOnlyList<string> Bindings);
public sealed partial class AotDamageBridge
{
    private const string Effect="forge/game/ability/effects/DamageDealEffect";
    public JProgram Program { get; }
    public AotDamageBridge(JProgram program){Program=program;}
    private sealed record SpellContext(CardInstance Card,FixtureRule Rule,JValue Source,JValue Game,JValue Target,JValue DamageMap,JValue PreventionMap,JValue Counters);
    private sealed record EmptyGame(int ReplacementCount=0,int TriggerCount=0);
    private static void BindDeclared(JRuntime rt,string owner,string name,string descriptor,Func<JRuntime,JValue,JValue[],JHostResult> handler)
    {var declaration=Find(rt.Program,owner,name,descriptor);rt.Bind(declaration.Owner,name,descriptor,handler);}
    public DamageExecution Execute(CardInstance card,FixtureRule rule,int targetSeat)
    {
        if(rule.Land)throw new ArgumentException("A spell is required.");
        var rt=new JRuntime(Program);rt.InstallFixtureListAdapters();var game=JValue.R(rt.HostObject("forge/game/Game",new EmptyGame()));
        var source=JValue.R(rt.HostObject("forge/game/card/Card",card));
        var target=JValue.R(rt.HostObject("forge/game/player/Player",new TargetPlayer(targetSeat)));
        var table=Construct(rt,"forge/game/card/CardDamageTable");
        var prevention=Construct(rt,"forge/game/card/CardDamageTable");
        var counters=Construct(rt,"forge/game/GameEntityCounterTable");
        var spell=new SpellContext(card,rule,source,game,target,table,prevention,counters);
        var sa=JValue.R(rt.HostObject("forge/game/spellability/SpellAbility",spell));
        JHostResult Value(JValue value)=>JHostResult.Complete(value);
        BindDeclared(rt,"forge/game/card/Card","getGame","()Lforge/game/Game;",(r,s,a)=>Value(game));
        BindDeclared(rt,"forge/game/Game","getChangeZoneLKIInfo","(Lforge/game/card/Card;)Lforge/game/card/Card;",(r,s,a)=>Value(a[0]));
        var replacements=JValue.R(rt.HostObject("forge/game/replacement/ReplacementHandler",new EmptyGame()));
        BindDeclared(rt,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;",(r,s,a)=>Value(replacements));
        var assignment=JValue.R(rt.HostObject("forge/game/replacement/ReplacementType",new object()));
        var notReplaced=JValue.R(rt.HostObject("forge/game/replacement/ReplacementResult",new object()));
        rt.BindStatic("forge/game/replacement/ReplacementType","AssignDealDamage","Lforge/game/replacement/ReplacementType;",()=>assignment);
        BindDeclared(rt,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;",(r,s,a)=>
        {var env=r.HostPayload<EmptyGame>(s);if(env.ReplacementCount!=0||env.TriggerCount!=0)throw new PortGap("Empty-board replacement adapter cannot run a populated rule environment.");return Value(notReplaced);});
        BindDeclared(rt,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;",(r,s,a)=>Value(r.MapOf(new[]{new KeyValuePair<JValue,JValue>(JValue.R(r.String("Affected")),a[0])})));
        BindDeclared(rt,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;",(r,s,a)=>
        {if(a[1].Reference!=null&&r.StringValue(a[1])!="Self")throw new PortGap("Defined source expression not supported by ignition fixture.");return Value(r.ListOf(new[]{a[0]},"forge/game/card/CardCollection"));});
        BindDeclared(rt,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I",(r,s,a)=>
        {if(!int.TryParse(r.StringValue(a[1]),NumberStyles.None,CultureInfo.InvariantCulture,out int n))throw new PortGap("Nonconstant amount in ignition fixture.");return Value(JValue.I(n));});
        BindDeclared(rt,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;",(r,s,a)=>Value(r.HostPayload<SpellContext>(s).Source));
        BindDeclared(rt,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;",(r,s,a)=>Value(r.HostPayload<SpellContext>(s).Rule.Parameters.TryGetValue(r.StringValue(a[0]),out var text)?JValue.R(r.String(text)):JValue.R(null)));
        BindDeclared(rt,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z",(r,s,a)=>Value(JValue.I(r.HostPayload<SpellContext>(s).Rule.Parameters.ContainsKey(r.StringValue(a[0]))?1:0)));
        BindDeclared(rt,"forge/game/spellability/SpellAbility","usesTargeting","()Z",(r,s,a)=>Value(JValue.I(1)));
        BindDeclared(rt,"forge/game/spellability/SpellAbility","isDividedAsYouChoose","()Z",(r,s,a)=>Value(JValue.I(0)));
        BindDeclared(rt,"forge/game/spellability/SpellAbility","getDamageMap","()Lforge/game/card/CardDamageTable;",(r,s,a)=>Value(table));
        BindDeclared(rt,"forge/game/spellability/SpellAbility","getPreventMap","()Lforge/game/card/CardDamageTable;",(r,s,a)=>Value(prevention));
        BindDeclared(rt,"forge/game/spellability/SpellAbility","getCounterTable","()Lforge/game/GameEntityCounterTable;",(r,s,a)=>Value(counters));
        BindDeclared(rt,Effect,"getTargetEntities","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",(r,s,a)=>Value(r.ListOf(new[]{target})));
        BindDeclared(rt,"forge/game/card/CardUtil","getRadiance","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;",(r,s,a)=>
        {if(rule.Parameters.ContainsKey("Radiance"))throw new PortGap("Radiance cannot be discarded.");return Value(r.ListOf(Array.Empty<JValue>(),"forge/game/card/CardCollection"));});
        var effect=Construct(rt,Effect);
        Run(rt,Find(Program,Effect,"resolve","(Lforge/game/spellability/SpellAbility;)V"),effect,new[]{sa});
        var dataMap=rt.GetField(table,"forge/game/card/CardDamageTable","dataMap","Lcom/google/common/collect/Table;");
        int damage=0;
        foreach(var entry in rt.TableRows(dataMap))
        {if(!ReferenceEquals(entry.Column.Reference,target.Reference))throw new InvalidOperationException("Damage target was changed unexpectedly.");damage=checked(damage+rt.UnboxInt(entry.Value));}
        if(rt.ExecutedBindings.Any(n=>n.StartsWith(Effect+".resolve",StringComparison.Ordinal)))throw new InvalidOperationException("The original damage resolver must not be overridden.");
        if(!rt.ExecutedMethods.Contains(Effect+".resolve(Lforge/game/spellability/SpellAbility;)V"))throw new InvalidOperationException("Original Forge resolver did not execute.");
        return new DamageExecution(damage,rt.ExecutedMethods.Order().ToArray(),rt.ExecutedBindings.Order().ToArray());
    }
    private sealed record TargetPlayer(int Seat):JRuntime.IJavaIdentity {public string JavaIdentity=>"player:"+Seat;}
}
