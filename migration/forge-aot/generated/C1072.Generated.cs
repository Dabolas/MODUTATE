// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1072{
internal static JClass Build(){var c=new JClass("forge/item/PaperCardPredicates$PredicateRarity","java/lang/Object",new string[]{"java/util/function/Predicate"},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("operand","Lforge/card/CardRarity;",false,JValue.Default("Lforge/card/CardRarity;"),null));
c.Add(new JMethod(11358,"forge/item/PaperCardPredicates$PredicateRarity","test","(Lforge/item/PaperCard;)Z",1,2,2,new JHandler[]{},M11358));
c.Add(new JMethod(11359,"forge/item/PaperCardPredicates$PredicateRarity","<init>","(Lforge/card/CardRarity;)V",2,2,2,new JHandler[]{},M11359));
c.Add(new JMethod(11360,"forge/item/PaperCardPredicates$PredicateRarity","test","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M11360));
}

internal static JStep M11358(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getRarity","()Lforge/card/CardRarity;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCardPredicates$PredicateRarity","operand","Lforge/card/CardRarity;"));f.Pc=8;continue;}
case 8:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?15:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{f.Pc=16;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11359(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCardPredicates$PredicateRarity","operand","Lforge/card/CardRarity;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11360(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateRarity","test","(Lforge/item/PaperCard;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
