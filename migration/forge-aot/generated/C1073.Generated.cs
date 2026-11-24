// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1073{
internal static JClass Build(){var c=new JClass("forge/item/PaperCardPredicates$PredicateSearchableName","forge/util/PredicateString",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("operand","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(11361,"forge/item/PaperCardPredicates$PredicateSearchableName","<init>","(Lforge/util/PredicateString$StringOp;Ljava/lang/String;)V",0,3,2,new JHandler[]{},M11361));
c.Add(new JMethod(11362,"forge/item/PaperCardPredicates$PredicateSearchableName","test","(Lforge/item/PaperCard;)Z",1,2,2,new JHandler[]{},M11362));
c.Add(new JMethod(11363,"forge/item/PaperCardPredicates$PredicateSearchableName","test","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M11363));
c.Add(new JMethod(11364,"forge/item/PaperCardPredicates$PredicateSearchableName","lambda$test$0","(Ljava/lang/String;)Z",4098,2,3,new JHandler[]{},M11364));
}

internal static JStep M11361(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/PredicateString","<init>","(Lforge/util/PredicateString$StringOp;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCardPredicates$PredicateSearchableName","operand","Ljava/lang/String;",value);f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11362(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getAllSearchableNames","()Ljava/util/Set;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates$PredicateSearchableName:11362:10:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/item/PaperCardPredicates$PredicateSearchableName;)Ljava/util/function/Predicate;",15);}
case 15:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",20);}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11363(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateSearchableName","test","(Lforge/item/PaperCard;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11364(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCardPredicates$PredicateSearchableName","operand","Ljava/lang/String;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateSearchableName","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
