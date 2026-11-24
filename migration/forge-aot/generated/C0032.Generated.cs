// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C32{
internal static JClass Build(){var c=new JClass("forge/card/CardFacePredicates$PredicateSuperType","java/lang/Object",new string[]{"java/util/function/Predicate"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("operand","Lforge/card/CardType$Supertype;",false,JValue.Default("Lforge/card/CardType$Supertype;"),null));
c.Add(new JField("shouldBeEqual","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(578,"forge/card/CardFacePredicates$PredicateSuperType","test","(Lforge/card/ICardFace;)Z",1,2,3,new JHandler[]{},M578));
c.Add(new JMethod(579,"forge/card/CardFacePredicates$PredicateSuperType","<init>","(Lforge/card/CardType$Supertype;Z)V",1,3,2,new JHandler[]{},M579));
c.Add(new JMethod(580,"forge/card/CardFacePredicates$PredicateSuperType","test","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M580));
}

internal static JStep M578(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFacePredicates$PredicateSuperType","shouldBeEqual","Z"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFacePredicates$PredicateSuperType","operand","Lforge/card/CardType$Supertype;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardType","hasSupertype","(Lforge/card/CardType$Supertype;)Z","invokevirtual",17);}
case 17:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M579(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFacePredicates$PredicateSuperType","operand","Lforge/card/CardType$Supertype;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFacePredicates$PredicateSuperType","shouldBeEqual","Z",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M580(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardFacePredicates$PredicateSuperType","test","(Lforge/card/ICardFace;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
