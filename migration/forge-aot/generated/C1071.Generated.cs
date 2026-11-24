// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1071{
internal static JClass Build(){var c=new JClass("forge/item/PaperCardPredicates$PredicateRarities","java/lang/Object",new string[]{"java/util/function/Predicate"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("operand","Ljava/util/HashSet;",false,JValue.Default("Ljava/util/HashSet;"),null));
c.Add(new JMethod(11355,"forge/item/PaperCardPredicates$PredicateRarities","test","(Lforge/item/PaperCard;)Z",1,2,2,new JHandler[]{},M11355));
c.Add(new JMethod(11356,"forge/item/PaperCardPredicates$PredicateRarities","<init>","([Lforge/card/CardRarity;)V",129,2,4,new JHandler[]{},M11356));
c.Add(new JMethod(11357,"forge/item/PaperCardPredicates$PredicateRarities","test","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M11357));
}

internal static JStep M11355(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCardPredicates$PredicateRarities","operand","Ljava/util/HashSet;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCard","getRarity","()Lforge/card/CardRarity;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/util/HashSet","contains","(Ljava/lang/Object;)Z","invokevirtual",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11356(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/HashSet","<init>","(Ljava/util/Collection;)V","invokespecial",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCardPredicates$PredicateRarities","operand","Ljava/util/HashSet;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11357(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateRarities","test","(Lforge/item/PaperCard;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
