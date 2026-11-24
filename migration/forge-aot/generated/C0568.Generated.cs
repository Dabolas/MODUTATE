// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C568{
internal static JClass Build(){var c=new JClass("forge/game/cost/ICostVisitor$Base","java/lang/Object",new string[]{"forge/game/cost/ICostVisitor"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(6689,"forge/game/cost/ICostVisitor$Base","<init>","()V",1,1,1,new JHandler[]{},M6689));
c.Add(new JMethod(6690,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostGainControl;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6690));
c.Add(new JMethod(6691,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostChooseColor;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6691));
c.Add(new JMethod(6692,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostChooseCreatureType;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6692));
c.Add(new JMethod(6693,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostCollectEvidence;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6693));
c.Add(new JMethod(6694,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostDiscard;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6694));
c.Add(new JMethod(6695,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostBehold;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6695));
c.Add(new JMethod(6696,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostBeholdExile;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6696));
c.Add(new JMethod(6697,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostDamage;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6697));
c.Add(new JMethod(6698,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostDraw;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6698));
c.Add(new JMethod(6699,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostExile;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6699));
c.Add(new JMethod(6700,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostExileFromStack;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6700));
c.Add(new JMethod(6701,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostExiledMoveToGrave;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6701));
c.Add(new JMethod(6702,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostExert;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6702));
c.Add(new JMethod(6703,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostEnlist;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6703));
c.Add(new JMethod(6704,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostFlipCoin;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6704));
c.Add(new JMethod(6705,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostForage;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6705));
c.Add(new JMethod(6706,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostRollDice;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6706));
c.Add(new JMethod(6707,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostMill;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6707));
c.Add(new JMethod(6708,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostAddMana;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6708));
c.Add(new JMethod(6709,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostPayLife;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6709));
c.Add(new JMethod(6710,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostPayEnergy;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6710));
c.Add(new JMethod(6711,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostGainLife;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6711));
c.Add(new JMethod(6712,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostPartMana;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6712));
c.Add(new JMethod(6713,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostPromiseGift;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6713));
c.Add(new JMethod(6714,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostPutCardToLib;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6714));
c.Add(new JMethod(6715,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostTap;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6715));
c.Add(new JMethod(6716,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostSacrifice;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6716));
c.Add(new JMethod(6717,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostReturn;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6717));
c.Add(new JMethod(6718,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostReveal;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6718));
c.Add(new JMethod(6719,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostRevealChosen;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6719));
c.Add(new JMethod(6720,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostRemoveAnyCounter;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6720));
c.Add(new JMethod(6721,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostRemoveCounter;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6721));
c.Add(new JMethod(6722,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostPutCounter;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6722));
c.Add(new JMethod(6723,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostPutCounterYou;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6723));
c.Add(new JMethod(6724,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostUntapType;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6724));
c.Add(new JMethod(6725,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostUntap;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6725));
c.Add(new JMethod(6726,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostUnattach;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6726));
c.Add(new JMethod(6727,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostTapType;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6727));
c.Add(new JMethod(6728,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostPayShards;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6728));
c.Add(new JMethod(6729,"forge/game/cost/ICostVisitor$Base","visit","(Lforge/game/cost/CostBlight;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M6729));
}

internal static JStep M6689(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6690(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6691(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6692(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6693(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6694(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6695(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6696(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6697(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6698(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6699(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6700(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6701(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6702(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6703(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6704(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6705(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6706(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6707(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6708(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6709(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6710(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6711(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6712(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6713(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6714(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6715(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6716(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6717(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6718(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6719(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6720(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6721(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6722(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6723(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6724(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6725(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6726(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6727(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6728(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6729(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
