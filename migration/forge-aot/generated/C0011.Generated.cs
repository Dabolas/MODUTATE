// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C11{
internal static JClass Build(){var c=new JClass("forge/card/CardAiHints","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("isRemovedFromAIDecks","Z",false,JValue.Default("Z"),null));
c.Add(new JField("isRemovedFromRandomDecks","Z",false,JValue.Default("Z"),null));
c.Add(new JField("isRemovedFromNonCommanderDecks","Z",false,JValue.Default("Z"),null));
c.Add(new JField("deckHints","Lforge/card/DeckHints;",false,JValue.Default("Lforge/card/DeckHints;"),null));
c.Add(new JField("deckNeeds","Lforge/card/DeckHints;",false,JValue.Default("Lforge/card/DeckHints;"),null));
c.Add(new JField("deckHas","Lforge/card/DeckHints;",false,JValue.Default("Lforge/card/DeckHints;"),null));
c.Add(new JField("keptForFlatMc","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JMethod(178,"forge/card/CardAiHints","<init>","(ZZZLforge/card/DeckHints;Lforge/card/DeckHints;Lforge/card/DeckHints;)V",1,7,2,new JHandler[]{},M178));
c.Add(new JMethod(179,"forge/card/CardAiHints","getRemAIDecks","()Z",1,1,1,new JHandler[]{},M179));
c.Add(new JMethod(180,"forge/card/CardAiHints","setKeptForFlatMc","(Ljava/util/function/Predicate;)V",9,1,1,new JHandler[]{},M180));
c.Add(new JMethod(181,"forge/card/CardAiHints","isRemovedFromRandomDecks","(Lforge/card/CardRules;)Z",9,1,2,new JHandler[]{},M181));
c.Add(new JMethod(182,"forge/card/CardAiHints","isRemovedFromAiDecks","(Lforge/card/CardRules;)Z",9,1,2,new JHandler[]{},M182));
c.Add(new JMethod(183,"forge/card/CardAiHints","getRemRandomDecks","()Z",1,1,1,new JHandler[]{},M183));
c.Add(new JMethod(184,"forge/card/CardAiHints","getRemNonCommanderDecks","()Z",1,1,1,new JHandler[]{},M184));
c.Add(new JMethod(185,"forge/card/CardAiHints","getDeckHints","()Lforge/card/DeckHints;",1,1,1,new JHandler[]{},M185));
c.Add(new JMethod(186,"forge/card/CardAiHints","getDeckNeeds","()Lforge/card/DeckHints;",1,1,1,new JHandler[]{},M186));
c.Add(new JMethod(187,"forge/card/CardAiHints","getDeckHas","()Lforge/card/DeckHints;",1,1,1,new JHandler[]{},M187));
c.Add(new JMethod(188,"forge/card/CardAiHints","getAiStatusComparable","()Ljava/lang/Integer;",1,1,1,new JHandler[]{},M188));
c.Add(new JMethod(189,"forge/card/CardAiHints","lambda$setKeptForFlatMc$1","(Ljava/lang/String;)Z",4106,1,1,new JHandler[]{},M189));
c.Add(new JMethod(190,"forge/card/CardAiHints","lambda$static$0","(Ljava/lang/String;)Z",4106,1,1,new JHandler[]{},M190));
c.Add(new JMethod(191,"forge/card/CardAiHints","<clinit>","()V",8,0,1,new JHandler[]{},M191));
}

internal static JStep M178(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardAiHints","isRemovedFromAIDecks","Z",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardAiHints","isRemovedFromRandomDecks","Z",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardAiHints","isRemovedFromNonCommanderDecks","Z",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardAiHints","deckHints","Lforge/card/DeckHints;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardAiHints","deckNeeds","Lforge/card/DeckHints;",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[6]);f.Pc=34;continue;}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardAiHints","deckHas","Lforge/card/DeckHints;",value);f.Pc=37;continue;}
case 37:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M179(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardAiHints","isRemovedFromAIDecks","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M180(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?12:4;continue;}
case 4:{return rt.DynamicCall(f,"forge/card/CardAiHints:180:4:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",9);}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/CardAiHints","keptForFlatMc","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardAiHints","keptForFlatMc","Ljava/util/function/Predicate;",f.Pop());f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M181(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getAiHints","()Lforge/card/CardAiHints;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardAiHints","getRemRandomDecks","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?29:10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/card/CardAiHints","keptForFlatMc","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardAiHints","keptForFlatMc","Ljava/util/function/Predicate;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",17);}
case 17:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int!=0?29:25;continue;}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{f.Pc=30;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M182(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getAiHints","()Lforge/card/CardAiHints;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardAiHints","getRemAIDecks","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?29:10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/card/CardAiHints","keptForFlatMc","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardAiHints","keptForFlatMc","Ljava/util/function/Predicate;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",17);}
case 17:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int!=0?29:25;continue;}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{f.Pc=30;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M183(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardAiHints","isRemovedFromRandomDecks","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M184(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardAiHints","isRemovedFromNonCommanderDecks","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M185(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardAiHints","deckHints","Lforge/card/DeckHints;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M186(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardAiHints","deckNeeds","Lforge/card/DeckHints;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M187(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardAiHints","deckHas","Lforge/card/DeckHints;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M188(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardAiHints","isRemovedFromAIDecks","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?19:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/card/CardAiHints","isRemovedFromRandomDecks","Z"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int==0?19:14;continue;}
case 14:{f.Push(JValue.I(3));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",18);}
case 18:{return JStep.Return(f.Pop());}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/card/CardAiHints","isRemovedFromAIDecks","Z"));f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Int==0?31:26;continue;}
case 26:{f.Push(JValue.I(4));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",30);}
case 30:{return JStep.Return(f.Pop());}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/card/CardAiHints","isRemovedFromRandomDecks","Z"));f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Int==0?43:38;continue;}
case 38:{f.Push(JValue.I(2));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",42);}
case 42:{return JStep.Return(f.Pop());}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",47);}
case 47:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M189(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M190(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M191(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/card/CardAiHints:191:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{if(!rt.StaticReady(f,"forge/card/CardAiHints","keptForFlatMc","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardAiHints","keptForFlatMc","Ljava/util/function/Predicate;",f.Pop());f.Pc=8;continue;}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
