using System.Text.Json;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;

string root=Path.GetFullPath(args.FirstOrDefault(a=>!a.StartsWith("--"))??Directory.GetCurrentDirectory());
if(args.Any(a=>a.StartsWith("--directed-pack=",StringComparison.Ordinal))){
    Environment.ExitCode=DirectedSeeds.Run(root,args);return;
}
if(args.Any(a=>a.StartsWith("--batch-job=",StringComparison.Ordinal))) {
    Environment.ExitCode=ParallelBatch.RunWorker(root,args.Single(a=>a.StartsWith("--batch-job=",StringComparison.Ordinal))[12..]);
    return;
}
if(args.Contains("--parallel-verify")||args.Contains("--parallel-checks")) { Environment.ExitCode=ParallelBatch.Verify(root,args);return; }
var regressions=new Dictionary<string,Action<string,Action<bool,string>>>(StringComparer.Ordinal)
{
    ["fixed-ten"]=HeadlessMatch.RepresentativeMatrix,
    ["craft-paid-list"]=HeadlessMatch.CraftPaidListRegression,
    ["outcome-boundaries"]=(project,check)=>HeadlessMatch.OutcomeRegression(project,check,
        args.SingleOrDefault(s=>s.StartsWith("--outcome-seed=",StringComparison.Ordinal)) is string option
            ?long.Parse(option["--outcome-seed=".Length..]):null),
    ["casting-delve"]=HeadlessMatch.CastingDelveRegression,
    ["casting-modes"]=HeadlessMatch.CastingModesRegression,
    ["assist-payment"]=HeadlessMatch.AssistPaymentRegression,
    ["spree-payment"]=HeadlessMatch.SpreePaymentRegression,
    ["return-cost"]=HeadlessMatch.ReturnCostRegression,
    ["activation-limit"]=HeadlessMatch.ActivationLimitRegression,
    ["energy-payment"]=HeadlessMatch.EnergyPaymentRegression,
    ["adventure-cost"]=HeadlessMatch.AdventureCostRegression,
    ["divided-damage"]=HeadlessMatch.DividedDamageRegression,
    ["catalogue-name"]=HeadlessMatch.CatalogueNameRegression,
    ["meld-catalogue"]=HeadlessMatch.MeldCatalogueRegression,
    ["venture-catalogue"]=HeadlessMatch.VentureCatalogueRegression,
    ["skip-turn-pump"]=HeadlessMatch.SkipPumpRegression,
    ["self-untap-choice"]=HeadlessMatch.SelfUntapChoiceRegression,
    ["mill-cost"]=HeadlessMatch.MillCostRegression,
    ["possessive-regex"]=HeadlessMatch.PossessiveRegexRegression,
    ["effect-abilities"]=HeadlessMatch.EffectAbilitiesRegression,
    ["printf"]=HeadlessMatch.PrintfRegression,
    ["combat-cost"]=HeadlessMatch.CombatCostRegression,
    ["collection-failures"]=HeadlessMatch.CollectionRegressions,
    ["sentence-keywords"]=HeadlessMatch.SentenceKeywordRegression,
    ["directed-day-night"]=HeadlessMatch.DirectedDayNight,
    ["directed-team-day-night"]=HeadlessMatch.DirectedTeamDayNight,
    ["directed-cast-history"]=HeadlessMatch.DirectedCastHistory,
    ["directed-celestus-loot"]=HeadlessMatch.DirectedCelestusLoot,
    ["directed-damage-prevention"]=HeadlessMatch.DirectedDamagePrevention,
    ["directed-cast-costs"]=HeadlessMatch.DirectedCastCosts,
    ["directed-controller-choices"]=HeadlessMatch.DirectedControllerChoices,
    ["directed-dungeon"]=HeadlessMatch.DirectedDungeon,
    ["drained-batch"]=HeadlessMatch.DrainedBatchRegressions,
    ["damage-cost"]=HeadlessMatch.DamageCostRegression,
    ["collector"]=HeadlessMatch.CollectorEffectRegression,
    ["apache-keyword"]=ApacheKeywordRegression.Run,
    ["pay-cost-to-prevent-effect"]=HeadlessMatch.PreventEffectRegression,
    ["hidden-zone"]=HeadlessMatch.HiddenZoneRegression,
    ["zone-cards"]=HeadlessMatch.ZoneCardsRegression,
    ["effect-cards"]=HeadlessMatch.EffectCardsRegression,
    ["put-counter-cost"]=HeadlessMatch.PutCounterRegression,
    ["tap-type-cost"]=HeadlessMatch.TapTypeRegression,
    ["surveil"]=HeadlessMatch.SurveilRegression,
    ["card-name"]=HeadlessMatch.CardNameRegression,
    ["delve"]=HeadlessMatch.DelveRegression,
    ["keyword-cost"]=HeadlessMatch.KeywordCostRegression,
    ["mana-combo"]=HeadlessMatch.ManaComboRegression,
    ["colors"]=HeadlessMatch.ColorsRegression
};
var regressionArgs=args.Where(a=>a=="--regression"||a.StartsWith("--regression=",StringComparison.Ordinal)).ToArray();
if(regressionArgs.Length>0)
{
    string name=regressionArgs[0].StartsWith("--regression=")?regressionArgs[0][13..]:"";
    if(regressionArgs.Length!=1||!regressions.TryGetValue(name,out var run))
    {Console.Error.WriteLine("Expected one known --regression=<name>. Registered: "+string.Join(", ",regressions.Keys));Environment.ExitCode=2;return;}
    const string outputFlag="--regression-output=";
    var output=args.SingleOrDefault(a=>a.StartsWith(outputFlag,StringComparison.Ordinal));
    if(output!=null)BatchPaths.WorkerRoot=Path.GetFullPath(output[outputFlag.Length..]);
    int checks=0;
    run(root,(ok,message)=>{if(!ok)throw new InvalidOperationException(message);checks++;});
    Console.WriteLine($"Regression {name}: {checks} checks passed.");return;
}
if(args.Contains("--fuzz-discover")||args.Contains("--fuzz-discover-worker")){Environment.ExitCode=DiscoverySuite.Run(root,args);return;}
if(args.Any(a=>a.StartsWith("--discover-report="))){DiscoverySuite.Aggregate(root,args.First(a=>a.StartsWith("--discover-report="))[18..]);return;}
if(args.Contains("--collector-regression")){HeadlessMatch.CollectorEffectRegression(root,(ok,message)=>{if(!ok)throw new InvalidOperationException(message);});return;}
if(args.Contains("--fuzz-report")){HeadlessFailureAudit.Run(root);return;}
if(args.Any(a=>a.StartsWith("--decode-trace="))){string directory=args.First(a=>a.StartsWith("--decode-trace="))[15..];TraceJournal.Decode(directory,Path.Combine(directory,"decoded.trace.log"));return;}
if(args.Any(a=>a=="--headless-smoke"||a=="--fuzz-matches"||a=="--corpus-regressions"||a.StartsWith("--replay="))){Environment.ExitCode=HeadlessSuite.Run(root,args);return;}
if(args.Contains("--minimum-turn")){Environment.ExitCode=MinimumTurn.Run(root);return;}
if(args.Contains("--advanced-matrix")){Environment.ExitCode=AdvancedSuite.Run(root);return;}
if(args.Contains("--l3-matrix")){Environment.ExitCode=L3Suite.RunMatrix(root);return;}
if(args.Contains("--followup")){Followup.Run(root);return;}
if(args.Contains("--l3-probe")){L3Probe.Run(root);return;}
if(args.Contains("--native-checks")){NativeChecks.Run(root);return;}
if(args.Contains("--l3-cases")){L3Suite.Run(root);return;}
if(args.Contains("--l3-one")){L3Suite.Run(root,true);return;}
if(args.Contains("--reference-audit")){L3Suite.Audit(root);return;}
if(args.Contains("--package")){SourceBundle.Create(root,Path.Combine(root,"release/forge-console"));return;}
string reportDir=Path.Combine(root,"release/forge-console");Directory.CreateDirectory(reportDir);
var jsonOptions=new JsonSerializerOptions{WriteIndented=true};
void Save(string file,object data)=>File.WriteAllText(Path.Combine(reportDir,file),JsonSerializer.Serialize(data,jsonOptions));
void Check(bool condition,string message){if(!condition)throw new InvalidOperationException(message);}
Save("summary.json",new{status="running",startedUtc=DateTimeOffset.UtcNow,allRequirementsCompleted=false,gameOrUiStarted=false});
Console.WriteLine("STEP 1: managed standard-library adapters and Host Adapter API");
var program=ForgeProgram.BuildForDevelopment();var runtime=new JRuntime(program);
Check(runtime.ListItems(runtime.ListOf([JValue.I(2),JValue.I(7)])).Select(v=>v.Int).SequenceEqual(new[]{2,7}),"List mapping failed.");
Check(ReferenceEquals(runtime.BoxInt(3).Reference,runtime.BoxInt(3).Reference),"Java Integer cache failed.");
var contractChecks=ContractChecks.Run(program);Save("contract-checks.json",new{passed=true,checks=contractChecks});
Save("library-linkage.json",LinkageAudit.Inspect(Path.Combine(root,"migration/forge-aot/linkage-gaps.json"),runtime));
var hostMethods=program.Classes["forge/game/player/PlayerController"].Methods.Values.Where(m=>(m.Access&0x400)!=0).Select(m=>new{m.Name,m.Descriptor,kind=Classify(m.Name),implementedByFullGameHost=false}).OrderBy(m=>m.Name).ToArray();
var inventory=new List<JavaHostMethod>();string contractCache=Path.Combine(root,"migration/forge-aot/host-contracts.json");
var specs=new[]{("forge-game","forge/game/player/PlayerController","engine-to-host"),("forge-gui","forge/gui/interfaces/IGuiGame","engine-to-host"),("forge-gui","forge/interfaces/IGameController","host-to-engine")};
if(specs.All(spec=>File.Exists(Path.Combine(root,"external/forge",spec.Item1,"target/classes",spec.Item2+".class"))))
{
    foreach(var spec in specs)inventory.AddRange(HostContractInventory.Read(Path.Combine(root,"external/forge",spec.Item1,"target/classes",spec.Item2+".class"),spec.Item3));
    File.WriteAllText(contractCache,JsonSerializer.Serialize(inventory,jsonOptions));
}
else inventory.AddRange(JsonSerializer.Deserialize<JavaHostMethod[]>(File.ReadAllText(contractCache))??throw new InvalidDataException("Host contract cache is empty."));
File.WriteAllText(Path.Combine(reportDir,"IForgeUiCallbacks.Generated.cs"),HostContractInventory.GenerateInterface(inventory));
Save("host-api.json",new{contract="IGameHostAdapter / HostDecision / HostAnswer",pendingEvent="DecisionRequested",reply="TryReply + TryTakeReply / JRuntime.Resume",fixtureDecisions=new[]{"ChooseTargets","PayCosts","Priority"},abstractPlayerControllerMethods=hostMethods,allDeclaredUiMethods=inventory,abstractMethodsWithSuspensionTransport=hostMethods.Length,typedAotCallbackCodecs=new[]{"PlayerController.chooseNumber(SpellAbility,String,int,int)"},allTypedCallbacksImplemented=false,boundSignatures=runtime.BindingNames.Order().ToArray(),allJavaStandardLibrariesMapped=false});
Console.WriteLine($"Installed {runtime.BindingNames.Count} binding signatures; {hostMethods.Length} abstract PlayerController methods inventoried.");
Console.WriteLine("STEP 2: mount the complete C# CardDatabase");
var db=CardDatabase.Load(Path.Combine(root,"data/forge"));
var bolt=db.Create("Lightning Bolt",0);Check(bolt.Definition.Name=="Lightning Bolt","Lookup failed.");
Save("database.json",new{cards=db.Cards.Count,tokens=db.Tokens.Count,example=new{bolt.InstanceId,bolt.Owner,bolt.Definition.Name,fields=bolt.Definition.Fields},scope="Data-backed C# CardInstance; not a complete Forge Game/CardFactory object"});
Console.WriteLine($"Loaded {db.Cards.Count} cards + {db.Tokens.Count} tokens. Created {bolt.Definition.Name} #{bolt.InstanceId}.");
var aotReader=new AotCardReader(program,Path.Combine(root,"src/Forge.ConsoleHost/Data/TypeLists.txt"),db);
var boltReader=aotReader.Attempt(bolt.Definition);Save("lightning-bolt-aot-reader.json",boltReader);
if(args.Contains("--probe-reader")){foreach(string name in new[]{"Lightning Bolt","\"Ach! Hans, Run!\"","Cavern of Souls","Plains"})Console.WriteLine(JsonSerializer.Serialize(new{name,attempt=aotReader.Attempt(db.Create(name).Definition)},jsonOptions));return;}
Console.WriteLine("STEP 3: controlled AOT effect ignition, no UI / no Java process");
var log=new List<string>();var host=new HostMailbox();host.Message+=message=>{log.Add(message);Console.WriteLine(message);};
host.DecisionRequested+=request=>
{
    string text=$"HOST request #{request.Id}: seat={request.Seat}, {request.Kind}, {request.Message}";log.Add(text);Console.WriteLine(text);
    if(request.Kind==HostDecisionKind.ChooseTargets)
        Check(!host.TryReply(new HostAnswer(request.Id,request.Revision,request.Seat,[999999]),out _),"Invalid target was accepted.");
    long option=request.Kind==HostDecisionKind.ChooseTargets?1:request.Options[0].Id;
    var answer=new HostAnswer(request.Id,request.Revision,request.Seat,[option]);Check(host.TryReply(answer,out string error),error);
    Check(!host.TryReply(answer,out _),"Duplicate response was accepted.");
};
var bridge=new AotDamageBridge(program);var match=new ConsoleMatch(db,host,bridge);
match.LoadFortyLands();match.BeginTurn(0);var land=match.PlayLand(0);match.TapForMana(land);
match.BeginTurn(1);match.BeginTurn(0);Check(!land.Tapped,"Untap step failed.");Check(match.Players[0].Hand.Count==8,"Forced turn draw count is wrong.");
var cast=match.AddIgnitionSpell("Lightning Bolt",0);match.TapForMana(land);match.BeginCast(cast);
for(int n=0;n<8&&host.Pending!=null;n++)match.Advance();
Check(match.Players[1].Life==17,"Opponent did not take 3 damage.");Check(cast.Zone=="Graveyard","Spell did not leave stack.");Check(match.Players[0].Mana.Count==0,"Mana was not consumed.");
Check(match.LastExecution!.Methods.Any(m=>m.StartsWith("forge/game/card/CardDamageTable.put")),"Original damage-table put did not execute.");
var negativeHost=new HostMailbox();negativeHost.DecisionRequested+=request=>Check(negativeHost.TryReply(new(request.Id,request.Revision,request.Seat,[request.Options[0].Id]),out _),"Fixture answer rejected");
var noMana=new ConsoleMatch(db,negativeHost,bridge);noMana.LoadFortyLands();noMana.BeginTurn(0);var unpaid=noMana.AddIgnitionSpell("Lightning Bolt",0);noMana.BeginCast(unpaid);noMana.Advance();
bool paymentRejected=false;try{noMana.Advance();}catch(InvalidOperationException ex)when(ex.Message.StartsWith("Insufficient mana")){paymentRejected=true;}
Check(paymentRejected&&unpaid.Zone=="Hand"&&noMana.Players[0].Hand.Contains(unpaid)&&noMana.Players[1].Life==20&&noMana.Players[0].Mana.Count==0,"Insufficient mana changed game state.");
// A rejected cast releases its pending state and can be tried again later.
noMana.BeginCast(unpaid);Check(negativeHost.Pending!=null,"Rejected cast left match stuck.");
Save("negative-cast.json",new{passed=true,insufficientManaRejected=true,cardRemainedInHand=true,noDamage=true,noManaSpent=true,canRetry=true});
Save("ignition.json",new{passed=true,engine="controlled managed host + original AOT DamageDealEffect.resolve and CardDamageTable.put",fullForgeGameInitialized=false,playerLife=match.Players.Select(p=>p.Life),manaConsumed=true,landUntapped=true,spellZone=cast.Zone,originalMethods=match.LastExecution.Methods,bindings=match.LastExecution.Bindings,trace=log,scope="Empty battlefield, player target, no replacement/trigger/protection effects; not full-rule conformance"});
File.WriteAllLines(Path.Combine(reportDir,"ignition.log"),log);
Console.WriteLine("STEP 4: enumerate all records; instantiate metadata; attempt the declared execution scenario");
int metadata=0,executed=0,landRuns=0,damageRuns=0,failed=0,readerPassed=0,readerAttempted=0;var errors=new Dictionary<string,int>();var readerErrors=new Dictionary<string,int>();
using(var failures=new StreamWriter(Path.Combine(reportDir,"card-failures.jsonl")))
using(var readerFailures=new StreamWriter(Path.Combine(reportDir,"aot-reader-failures.jsonl")))
foreach(var definition in db.Cards.OrderBy(d=>d.Name,StringComparer.Ordinal))
{
    string stage="metadata";
    CardInstance instance;try{instance=db.Create(definition.Name);metadata++;}catch(Exception ex){failures.WriteLine(JsonSerializer.Serialize(new{name=definition.Name,id=definition.Id,stage,errorType=ex.GetType().Name,message=ex.Message}));failed++;continue;}
    var readerAttempt=aotReader.Attempt(definition);readerAttempted++;
    if(readerAttempt.Passed)readerPassed++;
    else
    {
        string key=readerAttempt.ErrorType+": "+readerAttempt.Error;readerErrors[key]=readerErrors.GetValueOrDefault(key)+1;
        readerFailures.WriteLine(JsonSerializer.Serialize(new{name=definition.Name,id=definition.Id,stage="original-AOT-CardRules.Reader",readerAttempt.ErrorType,readerAttempt.Error,methodTrace=readerAttempt.Methods}));
    }
    try
    {
        stage="rule-admission";var rule=FixtureCompiler.Compile(definition);
        stage="execution";
        if(rule.Land){var lm=new ConsoleMatch(db,new HostMailbox(),bridge);lm.LoadFortyLands();lm.BeginTurn(0);var sample=lm.AddIgnitionSpell(definition.Name,0);lm.PlayLand(0,sample);lm.TapForMana(sample);Check(sample.Tapped&&sample.Zone=="Battlefield"&&lm.Players[0].Mana.GetValueOrDefault(rule.ManaColor)==1,"Land scenario failed.");landRuns++;}
        else{var result=bridge.Execute(instance,rule,1);Check(result.Damage==rule.Damage,"Damage differs from card script.");damageRuns++;}
        executed++;
        if(!readerAttempt.Passed)failures.WriteLine(JsonSerializer.Serialize(new{name=definition.Name,id=definition.Id,stage="original-AOT-CardRules.Reader",errorType=readerAttempt.ErrorType,message=readerAttempt.Error,controlledScenarioPassed=true}));
    }
    catch(Exception ex)
    {
        failed++;string code=ex is RuleGapException gap?gap.Code:ex.GetType().Name+":"+ex.Message;
        errors[code]=errors.GetValueOrDefault(code)+1;
        failures.WriteLine(JsonSerializer.Serialize(new{name=definition.Name,id=definition.Id,stage,errorType=ex.GetType().Name,code,message=ex.Message,aotReaderPassed=readerAttempt.Passed,aotReaderError=readerAttempt.Error,controlledScenarioPassed=false}));
    }
    if(readerAttempted%5000==0)Console.WriteLine($"SCAN {readerAttempted}/{db.Cards.Count}; original Reader passed={readerPassed}; controlled scenario passed={executed}");
}
int tokenCreated=0,tokenReaderPassed=0;var tokenReaderErrors=new Dictionary<string,int>();
using(var tokenFailures=new StreamWriter(Path.Combine(reportDir,"token-failures.jsonl")))
foreach(var token in db.Tokens){db.CreateToken(token.TokenId);tokenCreated++;var attempt=aotReader.Attempt(token);if(attempt.Passed)tokenReaderPassed++;else{string key=attempt.ErrorType+": "+attempt.Error;tokenReaderErrors[key]=tokenReaderErrors.GetValueOrDefault(key)+1;tokenFailures.WriteLine(JsonSerializer.Serialize(new{token.Name,token.TokenId,attempt.ErrorType,attempt.Error}));}}
var report=new{schema=2,cards=db.Cards.Count,tokens=db.Tokens.Count,metadataCreated=metadata,tokenMetadataCreated=tokenCreated,metadataRate=100.0*metadata/db.Cards.Count,aotReaderAttempted=readerAttempted,aotReaderPassed=readerPassed,aotReaderRate=100.0*readerPassed/db.Cards.Count,tokenAotReaderPassed=tokenReaderPassed,readerErrors=readerErrors.OrderByDescending(p=>p.Value).ToDictionary(p=>p.Key,p=>p.Value),tokenReaderErrors,scenarioExecuted=executed,scenarioExecutionRate=100.0*executed/db.Cards.Count,landRuns,damageRuns,failed,failuresByCode=errors.OrderByDescending(p=>p.Value).ToDictionary(p=>p.Key,p=>p.Value),fullRuleRunnableRate=(double?)null,fullForgeGameInitialized=false,fullRulesMigrated=false,gameOrUiStarted=false,javaEngineStarted=false,rateDefinition="Metadata rate is data-only. AOT Reader rate is original rules-definition parsing only, not CardFactory/game instantiation. Scenario rate counts only basic lands and unconditional any-target damage in a controlled empty-board host. No measure here certifies the full Forge rule playable rate."};
Save("scan.json",report);Console.WriteLine(JsonSerializer.Serialize(report,jsonOptions));
Save("summary.json",new{status="completed-with-gaps",finishedUtc=DateTimeOffset.UtcNow,allFourStepsAttempted=true,allRequirementsCompleted=false,step1AllStandardLibrariesMapped=false,step2FullDataMounted=true,step3ControlledIgnitionPassed=true,step3FullForgeGamePassed=false,step4AllCardsAttempted=readerAttempted==34468,fullRulesMigrated=false,gameOrUiStarted=false});
ReportWriter.Write(reportDir);
SourceBundle.Create(root,reportDir);
if(args.Contains("--require-full"))Environment.ExitCode=2;

static string Classify(string name)
{
    if(name.Contains("Target",StringComparison.OrdinalIgnoreCase))return "ChooseTargets";
    if(name.Contains("Pay",StringComparison.OrdinalIgnoreCase)||name.Contains("Mana",StringComparison.OrdinalIgnoreCase))return "PayCosts";
    if(name.Contains("Confirm",StringComparison.OrdinalIgnoreCase))return "Confirm";
    if(name.Contains("Damage",StringComparison.OrdinalIgnoreCase))return "AssignDamage";
    if(name.Contains("Order",StringComparison.OrdinalIgnoreCase))return "OrderCardsOrTriggers";
    return "Other:"+name;
}
