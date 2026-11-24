public static class HeadlessContracts
{
    public static void Run(string root,Action<bool,string> check)
    {
        string dir=BatchPaths.Output(root,"release/forge-headless/contracts");Directory.CreateDirectory(dir);
        string[] lines=["enter A()V","native B()I","return A()V","enter A()V","RUNTIME FAILURE\nJAVA STACK\nC()V pc=7"];
        using(var trace=new TraceJournal(dir))foreach(string line in lines)trace.WriteLine(line);
        string decoded=Path.Combine(dir,"decoded.txt");TraceJournal.Decode(dir,decoded);
        check(File.ReadAllText(decoded)==string.Join(Environment.NewLine,lines)+Environment.NewLine,"Full trace dictionary encoding is lossless including repeated and multiline events");
        string buffered=Path.Combine(dir,"buffered");Directory.CreateDirectory(buffered);
        using(var trace=new TraceJournal(buffered))for(int i=0;i<40001;i++)trace.WriteLine(lines[i%lines.Length]);
        string expanded=Path.Combine(buffered,"decoded.txt");TraceJournal.Decode(buffered,expanded);
        check(File.ReadAllText(expanded)==string.Concat(Enumerable.Range(0,40001).Select(i=>lines[i%lines.Length]+Environment.NewLine)),"Buffered trace preserves every event across compression boundaries and final partial buffer");
        ReplayDecision[] decisions;
        using(var writer=new StreamWriter(Path.Combine(dir,"decisions.jsonl"))){var tape=new DecisionTape(42,writer);for(int n=0;n<64;n++)tape.Choose("legal decision "+n,["pass","act"]);decisions=tape.Records.ToArray();}
        check(decisions.Select(d=>d.Choice).Distinct().Count()==2,"Deterministic legal policy exercises both pass and action");
        using(var writer=new StreamWriter(Path.Combine(dir,"replay.jsonl"))){var tape=new DecisionTape(42,writer,decisions);bool same=true;for(int n=0;n<64;n++)same&=tape.Choose("legal decision "+n,["pass","act"])==decisions[n].Choice;check(same,"Replay preserves all 64 recorded decisions");}
        using(var writer=new StreamWriter(Path.Combine(dir,"divergence.jsonl"))){var tape=new DecisionTape(42,writer,decisions);try{tape.Choose("legal decision 0",["different"]);check(false,"Divergent legal options must fail replay");}catch(InvalidOperationException ex){check(ex.Message.StartsWith("Replay diverged"),"Replay rejects changed legal choices rather than silently choosing another action");}}
        ReplayDecision[] integers;
        using(var writer=new StreamWriter(Path.Combine(dir,"integers.jsonl"))){var tape=new DecisionTape(81,writer);for(int i=0;i<32;i++)tape.ChooseInteger("full integer range",int.MinValue,int.MaxValue);check(tape.ChooseInteger("singleton",7,7)==7,"Integer announcement respects singleton bounds");integers=tape.Records.ToArray();}
        using(var writer=new StreamWriter(Path.Combine(dir,"integers-replay.jsonl"))){var tape=new DecisionTape(81,writer,integers);bool same=true;for(int i=0;i<32;i++)same&=tape.ChooseInteger("full integer range",int.MinValue,int.MaxValue)==integers[i].Choice;tape.ChooseInteger("singleton",7,7);tape.VerifyReplayConsumed();check(same,"Full Int32 announcement ranges replay without overflow or materializing billions of options");}
        HeadlessMatch.CounterCostRegression(root,check);
        TokenRegression.Run(root,check);
        HeadlessMatch.BloodCostRegression(root,check);
        HeadlessMatch.ManaCounterRegression(root,check);
        HeadlessMatch.GoadRegression(root,check);
        HeadlessMatch.ScryRegression(root,check);
        HeadlessMatch.LevelRegression(root,check);
        HeadlessMatch.PriorityTargetRegression(root,check);
        HeadlessMatch.OptionalCostRegression(root,check);
        HeadlessMatch.ManifestRegression(root,check);
        HeadlessMatch.ExileCostRegression(root,check);
        HeadlessMatch.LegendRegression(root,check);
        HeadlessMatch.TapReductionRegression(root,check);
        HeadlessMatch.CollectorEffectRegression(root,check);
        DiscoveryContracts.Run(root,check);
        ApacheKeywordRegression.Run(root,check);
        HeadlessMatch.PreventEffectRegression(root,check);
        HeadlessMatch.HiddenZoneRegression(root,check);
        HeadlessMatch.ZoneCardsRegression(root,check);
        HeadlessMatch.EffectCardsRegression(root,check);
        HeadlessMatch.PutCounterRegression(root,check);
        HeadlessMatch.TapTypeRegression(root,check);
        HeadlessMatch.SurveilRegression(root,check);
        HeadlessMatch.CardNameRegression(root,check);
        HeadlessMatch.DelveRegression(root,check);
        HeadlessMatch.KeywordCostRegression(root,check);
        HeadlessMatch.ManaComboRegression(root,check);
        HeadlessMatch.ColorsRegression(root,check);
        HeadlessMatch.CastingDelveRegression(root,check);
        HeadlessMatch.CastingModesRegression(root,check);
        HeadlessMatch.AssistPaymentRegression(root,check);
        HeadlessMatch.SpreePaymentRegression(root,check);
        HeadlessMatch.ReturnCostRegression(root,check);
        HeadlessMatch.ActivationLimitRegression(root,check);
        HeadlessMatch.EnergyPaymentRegression(root,check);
        HeadlessMatch.AdventureCostRegression(root,check);
        HeadlessMatch.DividedDamageRegression(root,check);
        HeadlessMatch.CatalogueNameRegression(root,check);
        HeadlessMatch.MeldCatalogueRegression(root,check);
        HeadlessMatch.VentureCatalogueRegression(root,check);
        HeadlessMatch.SkipPumpRegression(root,check);
        HeadlessMatch.MillCostRegression(root,check);
        HeadlessMatch.PossessiveRegexRegression(root,check);
        HeadlessMatch.EffectAbilitiesRegression(root,check);
        HeadlessMatch.PrintfRegression(root,check);
        HeadlessMatch.CombatCostRegression(root,check);
        HeadlessMatch.CollectionRegressions(root,check);
        HeadlessMatch.SentenceKeywordRegression(root,check);
        HeadlessMatch.DrainedBatchRegressions(root,check);
        HeadlessMatch.DamageCostRegression(root,check);
        HeadlessMatch.DirectedTeamDayNight(root,check);
        HeadlessMatch.DirectedCastCosts(root,check);
        HeadlessMatch.DirectedControllerChoices(root,check);
        HeadlessMatch.SelfUntapChoiceRegression(root,check);
    }
}
