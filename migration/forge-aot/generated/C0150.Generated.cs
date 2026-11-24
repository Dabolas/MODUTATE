// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C150{
internal static JClass Build(){var c=new JClass("forge/game/GameFormat$Reader$CardPoolFormat","java/lang/Record",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cardPool","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("title","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("date","Ljava/util/Date;",false,JValue.Default("Ljava/util/Date;"),null));
c.Add(new JField("bannedCards","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("restrictedCards","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("restrictedLegendary","Z",false,JValue.Default("Z"),null));
c.Add(new JField("additionalCards","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("index","I",false,JValue.Default("I"),null));
c.Add(new JField("formatType","Lforge/game/GameFormat$FormatType;",false,JValue.Default("Lforge/game/GameFormat$FormatType;"),null));
c.Add(new JField("formatSubType","Lforge/game/GameFormat$FormatSubType;",false,JValue.Default("Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JField("deckRules","Lforge/game/GameFormat$DeckRules;",false,JValue.Default("Lforge/game/GameFormat$DeckRules;"),null));
c.Add(new JField("folder","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(2367,"forge/game/GameFormat$Reader$CardPoolFormat","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;Ljava/util/List;Ljava/util/List;ZLjava/util/List;ILforge/game/GameFormat$FormatType;Lforge/game/GameFormat$FormatSubType;Lforge/game/GameFormat$DeckRules;Ljava/lang/String;)V",2,13,2,new JHandler[]{},M2367));
c.Add(new JMethod(2368,"forge/game/GameFormat$Reader$CardPoolFormat","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M2368));
c.Add(new JMethod(2369,"forge/game/GameFormat$Reader$CardPoolFormat","hashCode","()I",17,1,1,new JHandler[]{},M2369));
c.Add(new JMethod(2370,"forge/game/GameFormat$Reader$CardPoolFormat","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M2370));
c.Add(new JMethod(2371,"forge/game/GameFormat$Reader$CardPoolFormat","cardPool","()Ljava/lang/String;",1,1,1,new JHandler[]{},M2371));
c.Add(new JMethod(2372,"forge/game/GameFormat$Reader$CardPoolFormat","title","()Ljava/lang/String;",1,1,1,new JHandler[]{},M2372));
c.Add(new JMethod(2373,"forge/game/GameFormat$Reader$CardPoolFormat","date","()Ljava/util/Date;",1,1,1,new JHandler[]{},M2373));
c.Add(new JMethod(2374,"forge/game/GameFormat$Reader$CardPoolFormat","bannedCards","()Ljava/util/List;",1,1,1,new JHandler[]{},M2374));
c.Add(new JMethod(2375,"forge/game/GameFormat$Reader$CardPoolFormat","restrictedCards","()Ljava/util/List;",1,1,1,new JHandler[]{},M2375));
c.Add(new JMethod(2376,"forge/game/GameFormat$Reader$CardPoolFormat","restrictedLegendary","()Z",1,1,1,new JHandler[]{},M2376));
c.Add(new JMethod(2377,"forge/game/GameFormat$Reader$CardPoolFormat","additionalCards","()Ljava/util/List;",1,1,1,new JHandler[]{},M2377));
c.Add(new JMethod(2378,"forge/game/GameFormat$Reader$CardPoolFormat","index","()I",1,1,1,new JHandler[]{},M2378));
c.Add(new JMethod(2379,"forge/game/GameFormat$Reader$CardPoolFormat","formatType","()Lforge/game/GameFormat$FormatType;",1,1,1,new JHandler[]{},M2379));
c.Add(new JMethod(2380,"forge/game/GameFormat$Reader$CardPoolFormat","formatSubType","()Lforge/game/GameFormat$FormatSubType;",1,1,1,new JHandler[]{},M2380));
c.Add(new JMethod(2381,"forge/game/GameFormat$Reader$CardPoolFormat","deckRules","()Lforge/game/GameFormat$DeckRules;",1,1,1,new JHandler[]{},M2381));
c.Add(new JMethod(2382,"forge/game/GameFormat$Reader$CardPoolFormat","folder","()Ljava/lang/String;",1,1,1,new JHandler[]{},M2382));
}

internal static JStep M2367(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","cardPool","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","title","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","date","Ljava/util/Date;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","bannedCards","Ljava/util/List;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","restrictedCards","Ljava/util/List;",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[6]);f.Pc=34;continue;}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","restrictedLegendary","Z",value);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[7]);f.Pc=40;continue;}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","additionalCards","Ljava/util/List;",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[8]);f.Pc=46;continue;}
case 46:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","index","I",value);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[9]);f.Pc=52;continue;}
case 52:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","formatType","Lforge/game/GameFormat$FormatType;",value);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[10]);f.Pc=58;continue;}
case 58:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","formatSubType","Lforge/game/GameFormat$FormatSubType;",value);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[11]);f.Pc=64;continue;}
case 64:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","deckRules","Lforge/game/GameFormat$DeckRules;",value);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[12]);f.Pc=70;continue;}
case 70:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","folder","Ljava/lang/String;",value);f.Pc=73;continue;}
case 73:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2368(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/GameFormat$Reader$CardPoolFormat:2368:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/GameFormat$Reader$CardPoolFormat;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2369(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/GameFormat$Reader$CardPoolFormat:2369:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/GameFormat$Reader$CardPoolFormat;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2370(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/GameFormat$Reader$CardPoolFormat:2370:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/GameFormat$Reader$CardPoolFormat;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2371(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","cardPool","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2372(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","title","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2373(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","date","Ljava/util/Date;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2374(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","bannedCards","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2375(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","restrictedCards","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2376(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","restrictedLegendary","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2377(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","additionalCards","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2378(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","index","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2379(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","formatType","Lforge/game/GameFormat$FormatType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2380(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","formatSubType","Lforge/game/GameFormat$FormatSubType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2381(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","deckRules","Lforge/game/GameFormat$DeckRules;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2382(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader$CardPoolFormat","folder","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
