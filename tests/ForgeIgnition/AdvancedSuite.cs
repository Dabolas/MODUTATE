using System.Text.Json;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;

public static class AdvancedSuite
{
    public sealed record Case(string Group,string Name,Action<Context> Body,string[] Required);
    public sealed class Context
    {
        public readonly L3Game G;
        public readonly List<object> Snapshots=[];
        public readonly List<string> Evidence=[];
        private int sequence;
        public Context(L3Game game)
        {
            G=game;
            G.Rt.SynchronousInstructionLimit=10000000; // Bounded multi-effect/layer recomputation; no unbounded retries.
            G.Rt.MethodEntered=f=>{
                if(f.Method.Owner=="forge/game/staticability/StaticAbilityContinuous"&&f.Method.Name=="applyContinuousAbility")
                {var layer=f.Locals.FirstOrDefault(v=>v.Reference?.ClassName=="forge/game/staticability/StaticAbilityLayer");Mark("LAYER "+EnumName(layer));}
                if(f.Method.Owner=="forge/game/replacement/ReplacementHandler"&&(f.Method.Name=="getReplacementList"||f.Method.Name=="executeReplacement"))Mark("REPLACEMENT QUERY/EXECUTE "+f.Method.Name);
            };
            G.Rt.MethodReturned=(f,v)=>{
                if(f.Method.Owner=="forge/game/StaticEffect"&&f.Method.Name=="<init>")Mark("CONTINUOUS REGISTER");
                if(f.Method.Owner=="forge/game/StaticEffect"&&f.Method.Name=="remove")Mark("CONTINUOUS UNREGISTER");
                if(f.Method.Owner=="forge/game/replacement/ReplacementHandler"&&f.Method.ReturnType=="Lforge/game/replacement/ReplacementResult;")Mark("REPLACEMENT RESULT "+EnumName(v));
                if(f.Method.Owner.StartsWith("forge/game/ability/effects/")&&f.Method.Name=="resolve")Mark("EFFECT COMPLETE "+f.Method.Owner.Split('/')[^1]);
            };
        }
        public string EnumName(JValue value)=>G.Rt.InspectEnumName(value)??"null";
        public void Mark(string s){Evidence.Add(s);G.Trace.Add("MECHANISM "+s);}
        public void Snapshot(string label)
        {
            var players=Enumerable.Range(0,2).Select(seat=>new{seat,life=G.Life(seat),hand=G.Count(seat,"Hand"),library=G.Count(seat,"Library"),graveyard=G.Count(seat,"Graveyard"),exile=G.Count(seat,"Exile"),command=G.Count(seat,"Command"),battlefield=G.Rt.ListItems(G.Call(G.Zone(seat,"Battlefield"),"getCards","()Lforge/game/card/CardCollectionView;")).Select(c=>new{id=G.Call(c,"getId","()I").Int,name=G.Rt.StringValue(G.Call(c,"getName","()Ljava/lang/String;")),power=G.Call(c,"getNetPower","()I").Int,toughness=G.Call(c,"getNetToughness","()I").Int,types=G.Rt.StringValue(G.Call(G.Call(c,"getType","()Lforge/card/CardTypeView;"),"toString","()Ljava/lang/String;")),color=G.Call(G.Call(c,"getColor","()Lforge/card/ColorSet;"),"getColor","()B").Int,state=EnumName(G.Call(c,"getCurrentStateName","()Lforge/card/CardStateName;")),damage=G.Call(c,"getDamage","()I").Int,tapped=G.Call(c,"isTapped","()Z").Int!=0}).ToArray()}).ToArray();
            var snapshot=new{label,players,phase=EnumName(G.Call(G.Phase,"getPhase","()Lforge/game/phase/PhaseType;")),stack=G.Call(G.Stack,"size","()I").Int};Snapshots.Add(snapshot);G.Trace.Add("SNAPSHOT "+JsonSerializer.Serialize(snapshot));
        }
        public JValue Victim(int seat=0,string rules="",string types="Creature Bear")=>G.Fixture("Subject "+(++sequence),types,rules,seat,"Battlefield");
        public JValue Permanent(string rules,string types="Enchantment")
        {var c=G.Fixture("Rule source "+(++sequence),types,rules);Cast(c);return G.Current(c);}
        public JValue Spell(string parameters,params JValue[] targets)
        {var card=G.Fixture("Action "+(++sequence),"Instant","A:SP$ "+parameters+" | Cost$ 0");Cast(card,targets);return G.Current(card);}
        public JValue Pending(string parameters,params JValue[] targets)
        {var card=G.Fixture("Pending "+(++sequence),"Instant","A:SP$ "+parameters+" | Cost$ 0");var sa=G.Ability(card,0);if(targets.Length>0)G.Target(sa,targets);Snapshot("before pending cast");G.Check(G.Cast(card,sa,0),"pending cast accepted");return sa;}
        public void Cast(JValue card,params JValue[] targets)
        {var sa=G.Ability(card,0);if(targets.Length>0)G.Target(sa,targets);Snapshot("before action");G.Check(G.Cast(card,sa,0),"mechanism cast accepted");G.ResolveOne();G.Sba();Snapshot("after action");}
        public void Drain(){G.Drain();Snapshot("after drain");}
        public void Pt(JValue c,int p,int t)=>G.Check(G.Call(G.Current(c),"getNetPower","()I").Int==p&&G.Call(G.Current(c),"getNetToughness","()I").Int==t,$"computed P/T = {p}/{t}");
        public void HasType(JValue c,string type,bool yes=true)=>G.Check((G.Call(G.Call(G.Current(c),"getType","()Lforge/card/CardTypeView;"),"hasStringType","(Ljava/lang/String;)Z",G.S(type)).Int!=0)==yes,"type "+type+" = "+yes);
        public void Continuous(string data)=>Permanent("S:Mode$ Continuous | Affected$ Creature | "+data);
        public void Damage(JValue target,int amount=3)=>Spell("DealDamage | ValidTgts$ Any | NumDmg$ "+amount,target);
        public void Require(string fragment)=>G.Check(Evidence.Any(s=>s.Contains(fragment,StringComparison.Ordinal))||G.Trace.Any(s=>s.StartsWith("return ",StringComparison.Ordinal)&&s.Contains(fragment,StringComparison.Ordinal)),"actual completed path: "+fragment);
    }
    private const string ExileRule="R:Event$ Moved | ActiveZones$ Battlefield | Destination$ Graveyard | ValidCard$ Card | ReplaceWith$ Exile\nSVar:Exile:DB$ ChangeZone | Hidden$ True | Origin$ All | Destination$ Exile | Defined$ ReplacedCard";
    private const string DoubleDamage="R:Event$ DamageDone | ActiveZones$ Battlefield | ValidSource$ Card | ValidTarget$ Permanent,Player | ReplaceWith$ Twice\nSVar:Twice:DB$ ReplaceEffect | VarName$ DamageAmount | VarValue$ X\nSVar:X:ReplaceCount$DamageAmount/Twice";
    public static List<Case> Cases()=>[
        new("Layers","type-and-ability",c=>{var v=c.Victim();c.Continuous("AddType$ Artifact | AddKeyword$ Flying");c.HasType(v,"Artifact");c.G.Check(c.G.Call(v,"hasKeyword","(Ljava/lang/String;)Z",c.G.S("Flying")).Int!=0,"granted Flying present");},["LAYER TYPE","LAYER ABILITIES","CONTINUOUS REGISTER"]),
        new("Layers","color",c=>{var v=c.Victim();c.Continuous("SetColor$ Blue");c.G.Check(c.G.Call(v,"isBlue","()Z").Int!=0,"computed color is blue");},["LAYER COLOR","CONTINUOUS REGISTER"]),
        new("Layers","set-before-boost",c=>{var v=c.Victim();c.Continuous("AddPower$ 2 | AddToughness$ 2");c.Continuous("SetPower$ 4 | SetToughness$ 4");c.Pt(v,6,6);int set=c.Evidence.FindLastIndex(s=>s=="LAYER SETPT"),boost=c.Evidence.FindLastIndex(s=>s=="LAYER MODIFYPT");c.G.Check(set>=0&&boost>set,"observed SETPT before MODIFYPT despite source creation order");},["LAYER SETPT","LAYER MODIFYPT"]),
        new("Layers","timestamp-wins",c=>{var v=c.Victim();c.Continuous("SetPower$ 4 | SetToughness$ 4");c.Continuous("SetPower$ 7 | SetToughness$ 7");c.Pt(v,7,7);},["LAYER SETPT","CONTINUOUS REGISTER"]),
        new("Layers","characteristic-defining",c=>{c.Victim();var source=c.Permanent("S:Mode$ Continuous | CharacteristicDefining$ True | Affected$ Card.Self | SetPower$ X | SetToughness$ X\nSVar:X:Count$Valid Creature","Creature Shapeshifter");c.Pt(source,2,2);c.Victim();c.G.Sba();c.Pt(source,3,3);},["LAYER CHARACTERISTIC"]),
        new("Layers","type-dependency",c=>{var v=c.Victim();c.Permanent("S:Mode$ Continuous | Affected$ Artifact | AddType$ Enchantment");c.Permanent("S:Mode$ Continuous | Affected$ Creature | AddType$ Artifact");c.HasType(v,"Artifact");c.HasType(v,"Enchantment");},["LAYER TYPE"]),
        new("Layers","source-removal",c=>{var v=c.Victim();var source=c.Permanent("S:Mode$ Continuous | Affected$ Creature | AddPower$ 2 | AddToughness$ 2");c.Pt(v,4,5);c.Spell("ChangeZone | ValidTgts$ Permanent | Origin$ Battlefield | Destination$ Hand",source);c.Pt(v,2,3);},["CONTINUOUS UNREGISTER"]),
        new("Layers","dependency-cycle",c=>{var a=c.Victim();var b=c.G.Fixture("Artifact subject","Artifact","",0,"Battlefield",extra:"PT:2/3");c.Permanent("S:Mode$ Continuous | Affected$ Creature | RemoveType$ Creature | AddType$ Artifact");c.Permanent("S:Mode$ Continuous | Affected$ Artifact | RemoveType$ Artifact | AddType$ Creature");c.HasType(a,"Creature");c.HasType(a,"Artifact",false);c.HasType(b,"Creature");c.HasType(b,"Artifact",false);c.G.Check(c.G.Trace.Any(s=>s.StartsWith("DEPENDENCY CYCLES ")&&int.Parse(s[18..])>0),"dependency cycle detection executed");},["LAYER TYPE","GameAction.findStaticAbilityToApply"]),
        new("Layers","control",c=>{var v=c.Victim(1);c.Continuous("GainControl$ You");c.G.Check(ReferenceEquals(c.G.Call(c.G.Current(v),"getController","()Lforge/game/player/Player;").Reference,c.G.Players[0].Reference),"controller changed to caster");},["LAYER CONTROL"]),
        new("Layers","copy-values",c=>{var source=c.Victim(0,"","Creature Giant");var target=c.G.Card("Eager Cadet",0,"Battlefield");c.Spell("Clone | Choices$ Creature.Giant | ValidTgts$ Creature | Duration$ UntilEndOfTurn",target);c.Pt(target,2,3);c.HasType(target,"Giant");},["CloneEffect","CardCopyService"]),
        new("Layers","text-change",c=>{var v=c.Victim(0,"K:Protection from red");c.Spell("ChangeText | ValidTgts$ Permanent | ChangeColorWord$ Red Blue | Duration$ Permanent",v);c.G.Check(c.G.Call(v,"hasKeyword","(Ljava/lang/String;)Z",c.G.S("Protection from blue")).Int!=0,"protection text replaced");c.G.Check(c.G.Call(v,"hasKeyword","(Ljava/lang/String;)Z",c.G.S("Protection from red")).Int==0,"original protection text absent");},["ChangeTextEffect"]),
        new("Replacement","graveyard-to-exile",c=>{var v=c.Victim(1);c.Permanent(ExileRule);int grave=c.G.Count(1,"Graveyard"),exile=c.G.Count(1,"Exile");c.Damage(v);c.G.Check(c.G.Count(1,"Graveyard")==grave&&c.G.Count(1,"Exile")==exile+1&&c.G.In(v,"Exile"),"original death destination suppressed; exile occurred");},["REPLACEMENT RESULT Replaced"]),
        new("Replacement","draw-denied",c=>{c.Permanent("R:Event$ Draw | ActiveZones$ Battlefield | ValidPlayer$ You | Skip$ True");int h=c.G.Count(0,"Hand"),l=c.G.Count(0,"Library");c.Spell("Draw | Defined$ You | NumCards$ 2");c.G.Check(c.G.Count(0,"Hand")==h&&c.G.Count(0,"Library")==l,"draw event suppressed, no cards moved");},["REPLACEMENT RESULT Skipped"]),
        new("Replacement","prevention-shield",c=>{c.Spell("PreventDamage | ValidTgts$ Player | Amount$ 3",c.G.Players[1]);int life=c.G.Life(1);c.Damage(c.G.Players[1]);c.G.Check(c.G.Life(1)==life,"three damage prevented");c.Damage(c.G.Players[1],1);c.G.Check(c.G.Life(1)==life-1,"consumed shield does not prevent later damage");},["DamagePreventEffect","REPLACEMENT QUERY/EXECUTE executeReplacement"]),
        new("Replacement","damage-double",c=>{c.Permanent(DoubleDamage);int life=c.G.Life(1);c.Damage(c.G.Players[1]);c.G.Check(c.G.Life(1)==life-6,"replacement doubles exactly once, no recursive doubling");},["REPLACEMENT RESULT Updated"]),
        new("Replacement","source-leaves",c=>{var source=c.Permanent(DoubleDamage);c.Spell("ChangeZone | ValidTgts$ Permanent | Origin$ Battlefield | Destination$ Hand",source);int life=c.G.Life(1);c.Damage(c.G.Players[1]);c.G.Check(c.G.Life(1)==life-3,"removed source no longer replaces damage");},["ReplacementHandler.getReplacementList"]),
        new("Replacement","enter-tapped",c=>{var card=c.G.Fixture("Tapped entrant","Creature Human","R:Event$ Moved | ValidCard$ Card.Self | Destination$ Battlefield | ReplacementResult$ Updated | ReplaceWith$ Tap\nSVar:Tap:DB$ Tap | Defined$ Self | ETB$ True");c.Cast(card);c.G.Check(c.G.In(card,"Battlefield")&&c.G.Call(c.G.Current(card),"isTapped","()Z").Int!=0,"entered tapped, not untapped");},["REPLACEMENT QUERY/EXECUTE executeReplacement","TapEffect"]),
        new("Stack","copy-spell",c=>{int l=c.G.Count(0,"Library");var pending=c.Pending("Draw | Defined$ You | NumCards$ 1");c.Spell("CopySpellAbility | ValidTgts$ Instant,Sorcery | TargetType$ Spell",pending);c.Drain();c.G.Check(c.G.Count(0,"Library")==l-2,"copy and original each draw one");},["CopySpellAbilityEffect"]),
        new("Stack","redirect-target",c=>{var v=c.Victim(1);int life=c.G.Life(1);var pending=c.Pending("DealDamage | ValidTgts$ Any | NumDmg$ 1",c.G.Players[1]);var source=c.G.Fixture("Redirector","Instant","A:SP$ ChangeTargets | Cost$ 0 | TargetType$ Spell | ValidTgts$ Card | DefinedMagnet$ Remembered");c.G.Call(source,"addRemembered","(Ljava/lang/Object;)V",v);c.Cast(source,pending);c.Drain();c.G.Check(c.G.Life(1)==life&&c.G.Call(v,"getDamage","()I").Int==1,"old target untouched; new target damaged");},["ChangeTargetsEffect"]),
        new("Stack","counter-exile",c=>{int l=c.G.Count(0,"Library");var pending=c.Pending("Draw | Defined$ You | NumCards$ 1");var original=c.G.Call(pending,"getHostCard","()Lforge/game/card/Card;");c.Spell("Counter | TargetType$ Spell | ValidTgts$ Card | Destination$ Exile",pending);c.G.Check(c.G.In(original,"Exile")&&c.G.Count(0,"Library")==l,"countered spell exiled, effect never executed");},["CounterEffect"]),
        new("Stack","cast-from-exile",c=>{var card=c.G.Fixture("Exiled draw","Instant","A:SP$ Draw | Cost$ 0 | Defined$ You | NumCards$ 1",0,"Exile");int l=c.G.Count(0,"Library");c.Spell("Play | Valid$ Card.YouOwn | ValidZone$ Exile | Amount$ All | WithoutManaCost$ True");c.Drain();c.G.Check(c.G.Count(0,"Library")==l-1&&c.G.In(card,"Graveyard"),"exiled card was cast and resolved");},["PlayEffect"]),
        new("Stack","storm",c=>{c.Spell("GainLife | Defined$ You | LifeAmount$ 1");int life=c.G.Life(0);var card=c.G.Fixture("Storm fixture","Instant","A:SP$ GainLife | Cost$ 0 | Defined$ You | LifeAmount$ 1\nK:Storm");c.Cast(card);c.Drain();c.G.Check(c.G.Life(0)==life+2,"storm produces one copy for preceding spell");},["CopySpellAbilityEffect","TriggerHandler"]),
        new("Stack","cascade",c=>{var bottom=c.G.Fixture("Cascade hit","Instant","A:SP$ GainLife | Cost$ 0 | Defined$ You | LifeAmount$ 3",0,"Library");var lib=c.G.Zone(0,"Library");c.G.Call(lib,"remove","(Lforge/game/card/Card;)V",bottom);c.G.Call(lib,"add","(Lforge/game/card/Card;Ljava/lang/Integer;)V",bottom,c.G.Rt.BoxInt(0));var card=c.G.Fixture("Cascade source","Instant","A:SP$ GainLife | Cost$ 0 | Defined$ You | LifeAmount$ 1\nK:Cascade",extra:"ManaCost:1");c.G.Fund(0,"W");int life=c.G.Life(0);c.Cast(card);c.Drain();c.G.Check(c.G.Life(0)==life+4,"cascade found and cast zero-cost spell");},["DigUntilEffect","PlayEffect"]),
        new("Turn","extra-turn",c=>{c.Spell("AddTurn | ValidTgts$ Player | NumTurns$ 1",c.G.Players[0]);c.G.Check(ReferenceEquals(c.G.Call(c.G.Phase,"getNextTurn","()Lforge/game/player/Player;").Reference,c.G.Players[0].Reference),"next turn belongs to extra-turn recipient");},["AddTurnEffect","PhaseHandler.addExtraTurn"]),
        new("Turn","extra-turn-order",c=>{c.Spell("AddTurn | ValidTgts$ Player | NumTurns$ 1",c.G.Players[0]);c.Spell("AddTurn | ValidTgts$ Player | NumTurns$ 1",c.G.Players[1]);c.G.Check(ReferenceEquals(c.G.Call(c.G.Phase,"getNextTurn","()Lforge/game/player/Player;").Reference,c.G.Players[1].Reference),"most recently created extra turn is first");},["PhaseHandler.addExtraTurn"]),
        new("Turn","skip-draw",c=>{c.Spell("SkipPhase | ValidTgts$ Player | Step$ Draw",c.G.Players[0]);var replacement=c.G.Call(c.G.Game,"getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;");c.G.Check(c.G.Call(replacement,"wouldPhaseBeSkipped","(Lforge/game/player/Player;Lforge/game/phase/PhaseType;)Z",c.G.Players[0],c.G.Enum("forge/game/phase/PhaseType","DRAW")).Int!=0,"draw step skip registered");c.G.Check(c.G.Call(replacement,"wouldPhaseBeSkipped","(Lforge/game/player/Player;Lforge/game/phase/PhaseType;)Z",c.G.Players[1],c.G.Enum("forge/game/phase/PhaseType","DRAW")).Int==0,"opponent draw not skipped");int hand=c.G.Count(0,"Hand"),library=c.G.Count(0,"Library");c.G.Call(c.G.Phase,"devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;I)V",c.G.Enum("forge/game/phase/PhaseType","UPKEEP"),c.G.Players[0],JValue.I(2));c.G.Call(c.G.Phase,"advanceToNextPhase","()V");c.G.Check(c.EnumName(c.G.Call(c.G.Phase,"getPhase","()Lforge/game/phase/PhaseType;"))=="MAIN1","original phase advancement bypassed DRAW");c.G.Check(c.G.Count(0,"Hand")==hand&&c.G.Count(0,"Library")==library,"skipped draw moved no card");c.G.Check(c.G.Call(replacement,"wouldPhaseBeSkipped","(Lforge/game/player/Player;Lforge/game/phase/PhaseType;)Z",c.G.Players[0],c.G.Enum("forge/game/phase/PhaseType","DRAW")).Int==0,"one-shot skip consumed");},["SkipPhaseEffect","ReplacementHandler.getReplacementList","REPLACEMENT RESULT Replaced","PhaseHandler.advanceToNextPhase"]),
        new("Turn","face-down-up",c=>{var v=c.Victim();c.Spell("SetState | ValidTgts$ Creature | Mode$ TurnFaceDown",v);c.G.Check(c.G.Call(v,"isFaceDown","()Z").Int!=0,"face-down state active");c.Pt(v,2,2);c.Spell("SetState | ValidTgts$ Creature | Mode$ TurnFaceUp",v);c.G.Check(c.G.Call(v,"isFaceDown","()Z").Int==0,"face-up state restored");c.Pt(v,2,3);},["SetStateEffect"]),
        new("Turn","transform",c=>{var v=c.G.Fixture("Front fixture","Creature Human","",0,"Battlefield","AlternateMode:DoubleFaced\nALTERNATE\nName:Back fixture\nTypes:Creature Werewolf\nPT:5/5\nOracle:Back.");c.Spell("SetState | ValidTgts$ Creature | Mode$ Transform",v);c.Pt(v,5,5);c.HasType(v,"Werewolf");},["SetStateEffect","Card.changeCardState"]),
        new("Turn","phase-out-in",c=>{var v=c.Victim();c.Spell("Phases | ValidTgts$ Creature",v);c.G.Check(c.G.Call(v,"isPhasedOut","()Z").Int!=0,"permanent phased out");c.Spell("Phases | AllValid$ Creature | PhaseInOrOut$ True");c.G.Check(c.G.Call(v,"isPhasedOut","()Z").Int==0&&c.G.In(v,"Battlefield"),"same permanent phases back in");},["PhasesEffect"])
    ];
    public static int Run(string root)
    {
        string dir=BatchPaths.Output(root,"release/forge-advanced");Directory.CreateDirectory(dir);var program=ForgeProgram.BuildForDevelopment();Taxonomy(root,program,dir);var db=CardDatabase.Load(Path.Combine(root,"data/forge"));var results=new List<object>();int passed=0;
        foreach(var test in Cases())
        {
            Console.WriteLine("ADVANCED "+test.Group+" / "+test.Name);Context? c=null;Exception? error=null;
            try{c=new(new(root,program,db));c.G.Initialize();c.Snapshot("initial");test.Body(c);c.G.Sba();c.Snapshot("final");foreach(string path in test.Required)c.Require(path);c.G.Check(c.G.Enqueued>0&&c.G.Resolved>0&&c.G.SbaChecks>0,"stack resolution and SBA executed");c.G.Check(c.Snapshots.Count>=2,"before/after snapshots recorded");passed++;}catch(Exception ex){error=ex;}
            string failure=error is JavaFault jf?jf.Value.ClassName+": "+error:error?.ToString()??"";string prefix=test.Group+"-"+test.Name;
            var trace=c?.G.Trace??[];if(error!=null)trace.Add("FAILURE "+failure);File.WriteAllLines(Path.Combine(dir,prefix+".trace.log"),trace.Select((line,i)=>$"{i:D7} {line}"));
            File.WriteAllText(Path.Combine(dir,prefix+".snapshots.json"),JsonSerializer.Serialize(c?.Snapshots??[],new JsonSerializerOptions{WriteIndented=true}));
            results.Add(new{test.Group,test.Name,passed=error==null,required=test.Required,enqueued=c?.G.Enqueued??0,resolved=c?.G.Resolved??0,sba=c?.G.SbaChecks??0,assertions=c?.G.Assertions??[],evidence=c?.Evidence??[],error=failure,trace=prefix+".trace.log",snapshots=prefix+".snapshots.json"});Console.WriteLine(error==null?"PASS":"FAIL "+failure.Split('\n')[0]);
        }
        File.WriteAllText(Path.Combine(dir,"matrix.json"),JsonSerializer.Serialize(new{finishedUtc=DateTimeOffset.UtcNow,passed,total=results.Count,allPassed=passed==results.Count,gameOrUiStarted=false,scope="mechanism fixtures, not all-rule equivalence certification",cases=results},new JsonSerializerOptions{WriteIndented=true}));L3Suite.Audit(root,program);return passed==results.Count?0:2;
    }
    private static void Taxonomy(string root,JProgram program,string dir)
    {
        string source=Path.Combine(root,"external/forge/forge-game/src/main/java/forge/game");var modules=new[]{"ability/effects","replacement","staticability","trigger","phase","keyword"};var rows=new List<object>();
        foreach(string module in modules)foreach(string file in Directory.EnumerateFiles(Path.Combine(source,module),"*.java",SearchOption.AllDirectories))
        {string text=File.ReadAllText(file),relative=Path.GetRelativePath(source,file).Replace('\\','/'),type="forge/game/"+relative[..^5];rows.Add(new{module,file=relative,sha256=Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(text))).ToLowerInvariant(),generated=program.Classes.ContainsKey(type),methods=program.Classes.TryGetValue(type,out var cls)?cls.Methods.Count:0,declares=Regex.Matches(text,@"(?:class|enum|interface)\s+(\w+)").Select(m=>m.Groups[1].Value).ToArray()});}
        File.WriteAllText(Path.Combine(dir,"taxonomy.json"),JsonSerializer.Serialize(new{pinnedForge="f818e4b2751a8237c5e1ba35248f6373745217aa",systems=new[]{"Layers 1 copy / 2 control / 3 text / 4 type / 5 color / 6 abilities / 7a CDA / 7b set / 7c modify / rules","Replacement query, ordering, reentrancy prevention, damage prevention, zone interception","Stack copies, new targets, counter destinations, play effects, storm, cascade","Extra turns, phase skips, face-down, transform, phasing"},files=rows,note="Generated presence is inventory, not behavioral coverage. Assertions and trace evidence are required separately."},new JsonSerializerOptions{WriteIndented=true}));
    }
}
