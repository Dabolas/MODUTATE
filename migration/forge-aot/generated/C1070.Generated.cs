// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1070{
internal static JClass Build(){var c=new JClass("forge/item/PaperCardPredicates$PredicatePrintedWithRarity","java/lang/Object",new string[]{"java/util/function/Predicate"},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("matchingRarity","Lforge/card/CardRarity;",false,JValue.Default("Lforge/card/CardRarity;"),null));
c.Add(new JMethod(11350,"forge/item/PaperCardPredicates$PredicatePrintedWithRarity","test","(Lforge/item/PaperCard;)Z",1,2,3,new JHandler[]{},M11350));
c.Add(new JMethod(11351,"forge/item/PaperCardPredicates$PredicatePrintedWithRarity","<init>","(Lforge/card/CardRarity;)V",2,2,2,new JHandler[]{},M11351));
c.Add(new JMethod(11352,"forge/item/PaperCardPredicates$PredicatePrintedWithRarity","test","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M11352));
c.Add(new JMethod(11353,"forge/item/PaperCardPredicates$PredicatePrintedWithRarity","lambda$test$1","(Lforge/item/PaperCard;Lforge/card/CardEdition;)Z",4098,4,2,new JHandler[]{},M11353));
c.Add(new JMethod(11354,"forge/item/PaperCardPredicates$PredicatePrintedWithRarity","lambda$test$0","(Lforge/card/CardEdition$EditionEntry;)Z",4098,2,2,new JHandler[]{},M11354));
}

internal static JStep M11350(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/card/CardEdition$Collection","stream","()Ljava/util/stream/Stream;","invokevirtual",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates$PredicatePrintedWithRarity:11350:11:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/item/PaperCardPredicates$PredicatePrintedWithRarity;Lforge/item/PaperCard;)Ljava/util/function/Predicate;",16);}
case 16:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",21);}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11351(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCardPredicates$PredicatePrintedWithRarity","matchingRarity","Lforge/card/CardRarity;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11352(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicatePrintedWithRarity","test","(Lforge/item/PaperCard;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11353(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/card/CardEdition","getCardInSet","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference==null?37:13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates$PredicatePrintedWithRarity:11353:20:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/item/PaperCardPredicates$PredicatePrintedWithRarity;)Ljava/util/function/Predicate;",25);}
case 25:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?37:33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{f.Pc=38;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11354(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","rarity","()Lforge/card/CardRarity;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCardPredicates$PredicatePrintedWithRarity","matchingRarity","Lforge/card/CardRarity;"));f.Pc=8;continue;}
case 8:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?15:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{f.Pc=16;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
