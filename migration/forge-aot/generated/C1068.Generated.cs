// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1068{
internal static JClass Build(){var c=new JClass("forge/item/PaperCardPredicates$PredicateName","forge/util/PredicateString",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("operand","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(11344,"forge/item/PaperCardPredicates$PredicateName","test","(Lforge/item/PaperCard;)Z",1,2,3,new JHandler[]{},M11344));
c.Add(new JMethod(11345,"forge/item/PaperCardPredicates$PredicateName","<init>","(Ljava/lang/String;)V",2,2,2,new JHandler[]{},M11345));
c.Add(new JMethod(11346,"forge/item/PaperCardPredicates$PredicateName","test","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M11346));
}

internal static JStep M11344(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCardPredicates$PredicateName","operand","Ljava/lang/String;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateName","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11345(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","EQUALS_IC","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/PredicateString$StringOp","EQUALS_IC","Lforge/util/PredicateString$StringOp;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/PredicateString","<init>","(Lforge/util/PredicateString$StringOp;)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCardPredicates$PredicateName","operand","Ljava/lang/String;",value);f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11346(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateName","test","(Lforge/item/PaperCard;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
