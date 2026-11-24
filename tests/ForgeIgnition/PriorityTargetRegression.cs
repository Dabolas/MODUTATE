using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
using System.Text.Json;

public sealed partial class HeadlessMatch
{
    public static void PriorityTargetRegression(string root,Action<bool,string> check)
    {
        string directory=BatchPaths.Output(root,"release/forge-headless/priority-target-regression");Directory.CreateDirectory(directory);
        string report=Path.Combine(directory,"result.json");File.WriteAllText(report,"{\"passed\":false,\"status\":\"running-or-interrupted\"}");
        using var trace=new TraceJournal(directory);using var state=new StreamWriter(Path.Combine(directory,"snapshots.jsonl"));using var choices=new StreamWriter(Path.Combine(directory,"decisions.jsonl"));
        var driver=new HeadlessMatch(root,ForgeProgram.BuildForDevelopment(),CardDatabase.Load(Path.Combine(root,"data/forge")),new(4,55,4,[[],[]],"priority-target-regression"),trace,state,new(55,choices));
        var g=driver.g;g.Initialize();
        // devModeSet positions the phase but does not grant priority. This initial
        // fixture starts at the same priority-ready boundary as a resolved stack.
        g.Call(g.Phase,"onStackResolved","()V");
        var troll=g.Card("Trolls of Tel-Jilad",0,"Battlefield");for(int i=0;i<10;i++)g.Card("Grizzly Bears",i%2,"Battlefield");g.Fund(0,new string('G',12));
        var ability=driver.Items(driver.C(troll,"getSpellAbilities","()Lforge/util/collect/FCollectionView;")).Single(a=>driver.B(a,"isActivatedAbility"));driver.C(ability,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);int actions=0;
        g.SetDecision("chooseSpellAbilityToPlay",(ctrl,a)=>{
            if(driver.ControllerSeat(ctrl)!=0||actions==6)return JHostResult.Complete(JValue.R(null));
            check(driver.B(ability,"canPlay"),"Repeated regeneration action "+actions+" satisfies engine timing");actions++;return JHostResult.Complete(g.Rt.ListOf([ability]));});
        g.Rt.InvokeSynchronousWithBudget("forge/game/phase/PhaseHandler","mainLoopStep","()V",g.Phase,[],500000000);
        check(actions==6&&driver.C(g.Stack,"size","()I").Int==6&&g.ManaCount(0)==0,$"One real priority window permits six paid activations before a voluntary pass: actions={actions}, stack={driver.C(g.Stack,"size","()I").Int}, mana={g.ManaCount(0)}");
        foreach(var instance in driver.Items(g.Stack))
        {var sa=driver.C(instance,"getSpellAbility","()Lforge/game/spellability/SpellAbility;");check(driver.Items(driver.C(sa,"getTargets","()Lforge/game/spellability/TargetChoices;")).All(t=>g.Rt.IsInstance(t.Reference!,"forge/game/card/Card")&&g.In(t,"Battlefield")),"Regeneration only targets battlefield cards, never another stack ability");}
        g.SetMain(0);var counter=g.Card("Counterspell",0,"Hand");var counterAbility=g.Ability(counter,0);
        check(!driver.SelectTargets(counterAbility),"Counterspell cannot target any of the six activated abilities");
        g.Fund(0,"UU");var draw=g.Card("Think Twice",0,"Hand");int library=g.Count(0,"Library");check(driver.Play(g.Ability(draw,0),0),"A real instant joins the activated abilities on stack");
        g.Fund(0,"UU");check(driver.SelectTargets(counterAbility),"Counterspell finds the actual spell via the stack-specific legality query");
        var selected=driver.Items(driver.C(counterAbility,"getTargets","()Lforge/game/spellability/TargetChoices;"));
        check(selected.Length==1&&g.Rt.IsInstance(selected[0].Reference!,"forge/game/spellability/SpellAbility")&&driver.B(selected[0],"isSpell"),"Selected stack target is the spell ability, not its physical card or another activation");
        check(driver.Play(counterAbility,0),"Counterspell pays and enters stack");g.ResolveOne();g.Sba();g.Drain();
        check(g.In(draw,"Graveyard")&&g.Count(0,"Library")==library,"Countered Think Twice never performs its draw effect");
        int shields=Enumerable.Range(0,2).SelectMany(seat=>driver.Zone(seat,"Battlefield")).Sum(c=>driver.C(c,"getShieldCount","()I").Int);
        check(shields==6&&driver.C(g.Stack,"size","()I").Int==0,"Six regeneration resolutions create exactly six real shields and leave an empty stack");
        driver.Snapshot("after busy window, counter and regeneration resolutions");
        File.WriteAllText(report,JsonSerializer.Serialize(new{passed=true,actions,shields,policyVersion=4,wholePriorityWindowBudget=500000000,nestedDecisionBudget=g.Rt.SynchronousInstructionLimit,driver.enqueued,driver.resolved,driver.sba,methods=g.Rt.ExecutedMethods.Order().ToArray()},new JsonSerializerOptions{WriteIndented=true}));
    }
}
