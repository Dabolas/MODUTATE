// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C108{
internal static JClass Build(){var c=new JClass("forge/deck/DeckSection$Validators","java/lang/Object",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("DECK_AND_SIDE_VALIDATOR","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("COMMANDER_VALIDATOR","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JMethod(1639,"forge/deck/DeckSection$Validators","<init>","()V",2,1,1,new JHandler[]{},M1639));
c.Add(new JMethod(1640,"forge/deck/DeckSection$Validators","lambda$static$1","(Lforge/item/PaperCard;)Z",4106,2,1,new JHandler[]{},M1640));
c.Add(new JMethod(1641,"forge/deck/DeckSection$Validators","lambda$static$0","(Lforge/item/PaperCard;)Z",4106,2,1,new JHandler[]{},M1641));
c.Add(new JMethod(1642,"forge/deck/DeckSection$Validators","<clinit>","()V",8,0,1,new JHandler[]{},M1642));
}

internal static JStep M1639(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1640(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/card/CardRules","canBeCommander","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?45:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/CardType","isPlaneswalker","()Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int!=0?45:25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/card/CardRules","canBeOathbreaker","()Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int!=0?45:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/card/CardRules","canBeSignatureSpell","()Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?49:45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{f.Pc=50;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1641(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardType","isConspiracy","()Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int!=0?54:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/CardType","isDungeon","()Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int!=0?54:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/card/CardType","isPhenomenon","()Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int!=0?54:29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardType","isPlane","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int!=0?54:36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/CardType","isScheme","()Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int!=0?54:43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/card/CardType","isVanguard","()Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int!=0?54:50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{f.Pc=55;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1642(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/deck/DeckSection$Validators:1642:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{if(!rt.StaticReady(f,"forge/deck/DeckSection$Validators","DECK_AND_SIDE_VALIDATOR","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckSection$Validators","DECK_AND_SIDE_VALIDATOR","Ljava/util/function/Predicate;",f.Pop());f.Pc=8;continue;}
case 8:{return rt.DynamicCall(f,"forge/deck/DeckSection$Validators:1642:8:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",13);}
case 13:{if(!rt.StaticReady(f,"forge/deck/DeckSection$Validators","COMMANDER_VALIDATOR","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckSection$Validators","COMMANDER_VALIDATOR","Ljava/util/function/Predicate;",f.Pop());f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
