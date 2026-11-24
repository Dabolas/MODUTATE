// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C160{
internal static JClass Build(){var c=new JClass("forge/game/GameRules","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("gameType","Lforge/game/GameType;",false,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("manaBurn","Z",false,JValue.Default("Z"),null));
c.Add(new JField("orderCombatants","Z",false,JValue.Default("Z"),null));
c.Add(new JField("poisonCountersToLose","I",false,JValue.Default("I"),null));
c.Add(new JField("gamesPerMatch","I",false,JValue.Default("I"),null));
c.Add(new JField("gamesToWinMatch","I",false,JValue.Default("I"),null));
c.Add(new JField("playForAnte","Z",false,JValue.Default("Z"),null));
c.Add(new JField("matchAnteRarity","Z",false,JValue.Default("Z"),null));
c.Add(new JField("anteIncludeBasicLands","Z",false,JValue.Default("Z"),null));
c.Add(new JField("AISideboardingEnabled","Z",false,JValue.Default("Z"),null));
c.Add(new JField("sideboardForAI","Z",false,JValue.Default("Z"),null));
c.Add(new JField("allowCheatShuffle","Z",false,JValue.Default("Z"),null));
c.Add(new JField("appliedVariants","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("simTimeout","I",false,JValue.Default("I"),null));
c.Add(new JField("useGrayText","Z",false,JValue.Default("Z"),null));
c.Add(new JField("warnAboutAICards","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(2503,"forge/game/GameRules","<init>","(Lforge/game/GameType;)V",1,2,2,new JHandler[]{},M2503));
c.Add(new JMethod(2504,"forge/game/GameRules","getGameType","()Lforge/game/GameType;",1,1,1,new JHandler[]{},M2504));
c.Add(new JMethod(2505,"forge/game/GameRules","hasManaBurn","()Z",1,1,1,new JHandler[]{},M2505));
c.Add(new JMethod(2506,"forge/game/GameRules","setManaBurn","(Z)V",1,2,2,new JHandler[]{},M2506));
c.Add(new JMethod(2507,"forge/game/GameRules","hasOrderCombatants","()Z",1,1,1,new JHandler[]{},M2507));
c.Add(new JMethod(2508,"forge/game/GameRules","setOrderCombatants","(Z)V",1,2,2,new JHandler[]{},M2508));
c.Add(new JMethod(2509,"forge/game/GameRules","getPoisonCountersToLose","()I",1,1,2,new JHandler[]{},M2509));
c.Add(new JMethod(2510,"forge/game/GameRules","setPoisonCountersToLose","(I)V",1,2,2,new JHandler[]{},M2510));
c.Add(new JMethod(2511,"forge/game/GameRules","getGamesPerMatch","()I",1,1,1,new JHandler[]{},M2511));
c.Add(new JMethod(2512,"forge/game/GameRules","setGamesPerMatch","(I)V",1,2,3,new JHandler[]{},M2512));
c.Add(new JMethod(2513,"forge/game/GameRules","useAnte","()Z",1,1,1,new JHandler[]{},M2513));
c.Add(new JMethod(2514,"forge/game/GameRules","setPlayForAnte","(Z)V",1,2,2,new JHandler[]{},M2514));
c.Add(new JMethod(2515,"forge/game/GameRules","getMatchAnteRarity","()Z",1,1,1,new JHandler[]{},M2515));
c.Add(new JMethod(2516,"forge/game/GameRules","setMatchAnteRarity","(Z)V",1,2,2,new JHandler[]{},M2516));
c.Add(new JMethod(2517,"forge/game/GameRules","getAnteIncludeBasicLands","()Z",1,1,1,new JHandler[]{},M2517));
c.Add(new JMethod(2518,"forge/game/GameRules","setAnteIncludeBasicLands","(Z)V",1,2,2,new JHandler[]{},M2518));
c.Add(new JMethod(2519,"forge/game/GameRules","getSideboardForAI","()Z",1,1,1,new JHandler[]{},M2519));
c.Add(new JMethod(2520,"forge/game/GameRules","setSideboardForAI","(Z)V",1,2,2,new JHandler[]{},M2520));
c.Add(new JMethod(2521,"forge/game/GameRules","getAISideboardingEnabled","()Z",1,1,1,new JHandler[]{},M2521));
c.Add(new JMethod(2522,"forge/game/GameRules","setAISideboardingEnabled","(Z)V",1,2,2,new JHandler[]{},M2522));
c.Add(new JMethod(2523,"forge/game/GameRules","isAllowCheatShuffle","()Z",1,1,1,new JHandler[]{},M2523));
c.Add(new JMethod(2524,"forge/game/GameRules","setAllowCheatShuffle","(Z)V",1,2,2,new JHandler[]{},M2524));
c.Add(new JMethod(2525,"forge/game/GameRules","getGamesToWinMatch","()I",1,1,1,new JHandler[]{},M2525));
c.Add(new JMethod(2526,"forge/game/GameRules","setAppliedVariants","(Ljava/util/Set;)V",1,2,2,new JHandler[]{},M2526));
c.Add(new JMethod(2527,"forge/game/GameRules","addAppliedVariant","(Lforge/game/GameType;)V",1,2,2,new JHandler[]{},M2527));
c.Add(new JMethod(2528,"forge/game/GameRules","hasAppliedVariant","(Lforge/game/GameType;)Z",1,2,2,new JHandler[]{},M2528));
c.Add(new JMethod(2529,"forge/game/GameRules","hasCommander","()Z",1,1,2,new JHandler[]{},M2529));
c.Add(new JMethod(2530,"forge/game/GameRules","hasSharedTeamTurns","()Z",1,1,2,new JHandler[]{},M2530));
c.Add(new JMethod(2531,"forge/game/GameRules","useGrayText","()Z",1,1,1,new JHandler[]{},M2531));
c.Add(new JMethod(2532,"forge/game/GameRules","setUseGrayText","(Z)V",1,2,2,new JHandler[]{},M2532));
c.Add(new JMethod(2533,"forge/game/GameRules","warnAboutAICards","()Z",1,1,1,new JHandler[]{},M2533));
c.Add(new JMethod(2534,"forge/game/GameRules","setWarnAboutAICards","(Z)V",1,2,2,new JHandler[]{},M2534));
c.Add(new JMethod(2535,"forge/game/GameRules","getSimTimeout","()I",1,1,1,new JHandler[]{},M2535));
c.Add(new JMethod(2536,"forge/game/GameRules","setSimTimeout","(I)V",1,2,2,new JHandler[]{},M2536));
}

internal static JStep M2503(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(10));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","poisonCountersToLose","I",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.I(3));f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","gamesPerMatch","I",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(2));f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","gamesToWinMatch","I",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","playForAnte","Z",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","matchAnteRarity","Z",value);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","anteIncludeBasicLands","Z",value);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","AISideboardingEnabled","Z",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","sideboardForAI","Z",value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","allowCheatShuffle","Z",value);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.ClassObject("forge/game/GameType")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",56);}
case 56:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","appliedVariants","Ljava/util/Set;",value);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(JValue.I(120));f.Pc=62;continue;}
case 62:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","simTimeout","I",value);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","warnAboutAICards","Z",value);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","gameType","Lforge/game/GameType;",value);f.Pc=75;continue;}
case 75:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2504(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","gameType","Lforge/game/GameType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2505(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","manaBurn","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2506(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","manaBurn","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2507(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","orderCombatants","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2508(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","orderCombatants","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2509(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/GameType","TwoHeadedGiant","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","TwoHeadedGiant","Lforge/game/GameType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameRules","hasAppliedVariant","(Lforge/game/GameType;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?15:10;continue;}
case 10:{f.Push(JValue.I(15));f.Pc=12;continue;}
case 12:{f.Pc=19;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","poisonCountersToLose","I"));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2510(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","poisonCountersToLose","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2511(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","gamesPerMatch","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2512(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","gamesPerMatch","I",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(2));f.Pc=8;continue;}
case 8:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","gamesToWinMatch","I",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2513(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","playForAnte","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2514(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","playForAnte","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2515(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","matchAnteRarity","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2516(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","matchAnteRarity","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2517(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","anteIncludeBasicLands","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2518(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","anteIncludeBasicLands","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2519(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","sideboardForAI","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2520(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","sideboardForAI","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2521(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","AISideboardingEnabled","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2522(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","AISideboardingEnabled","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2523(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","allowCheatShuffle","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2524(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","allowCheatShuffle","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2525(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","gamesToWinMatch","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2526(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?24:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int!=0?24:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","appliedVariants","Ljava/util/Set;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2527(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","appliedVariants","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2528(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","appliedVariants","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2529(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","appliedVariants","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/GameType","Commander","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Commander","Lforge/game/GameType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{f.Pc=f.Pop().Int!=0?60:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","appliedVariants","Ljava/util/Set;"));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/GameType","Oathbreaker","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Oathbreaker","Lforge/game/GameType;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int!=0?60:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","appliedVariants","Ljava/util/Set;"));f.Pc=34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/game/GameType","TinyLeaders","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","TinyLeaders","Lforge/game/GameType;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int!=0?60:45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","appliedVariants","Ljava/util/Set;"));f.Pc=49;continue;}
case 49:{if(!rt.StaticReady(f,"forge/game/GameType","Brawl","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Brawl","Lforge/game/GameType;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",57);}
case 57:{f.Pc=f.Pop().Int==0?64:60;continue;}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{f.Pc=65;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2530(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","appliedVariants","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/GameType","TwoHeadedGiant","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","TwoHeadedGiant","Lforge/game/GameType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2531(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","useGrayText","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2532(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","useGrayText","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2533(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","warnAboutAICards","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2534(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","warnAboutAICards","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2535(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameRules","simTimeout","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2536(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameRules","simTimeout","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
