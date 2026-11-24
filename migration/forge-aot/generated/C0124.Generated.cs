// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C124{
internal static JClass Build(){var c=new JClass("forge/game/CardTraitPredicates","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(1837,"forge/game/CardTraitPredicates","<init>","()V",1,1,1,new JHandler[]{},M1837));
c.Add(new JMethod(1838,"forge/game/CardTraitPredicates","isHostCard","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",25,1,1,new JHandler[]{},M1838));
c.Add(new JMethod(1839,"forge/game/CardTraitPredicates","isKeyword","(Lforge/game/keyword/Keyword;)Ljava/util/function/Predicate;",25,1,1,new JHandler[]{},M1839));
c.Add(new JMethod(1840,"forge/game/CardTraitPredicates","hasParam","(Ljava/lang/String;)Ljava/util/function/Predicate;",25,1,1,new JHandler[]{},M1840));
c.Add(new JMethod(1841,"forge/game/CardTraitPredicates","hasParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/util/function/Predicate;",25,2,2,new JHandler[]{},M1841));
c.Add(new JMethod(1842,"forge/game/CardTraitPredicates","lambda$hasParam$3","(Ljava/lang/String;Ljava/lang/String;Lforge/game/CardTraitBase;)Z",4106,3,3,new JHandler[]{},M1842));
c.Add(new JMethod(1843,"forge/game/CardTraitPredicates","lambda$hasParam$2","(Ljava/lang/String;Lforge/game/CardTraitBase;)Z",4106,2,2,new JHandler[]{},M1843));
c.Add(new JMethod(1844,"forge/game/CardTraitPredicates","lambda$isKeyword$1","(Lforge/game/keyword/Keyword;Lforge/game/CardTraitBase;)Z",4106,2,2,new JHandler[]{},M1844));
c.Add(new JMethod(1845,"forge/game/CardTraitPredicates","lambda$isHostCard$0","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z",4106,2,2,new JHandler[]{},M1845));
}

internal static JStep M1837(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1838(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/CardTraitPredicates:1838:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1839(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/CardTraitPredicates:1839:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/keyword/Keyword;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1840(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/CardTraitPredicates:1840:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1841(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/CardTraitPredicates:1841:2:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;Ljava/lang/String;)Ljava/util/function/Predicate;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1842(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int!=0?10:8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",16);}
case 16:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",19);}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1843(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1844(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/CardTraitBase","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1845(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
