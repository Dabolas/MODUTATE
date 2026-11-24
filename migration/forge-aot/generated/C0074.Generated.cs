// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C74{
internal static JClass Build(){var c=new JClass("forge/card/StateChangedType","java/lang/Record",new string[]{"forge/card/ICardChangedType"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("type","Lforge/card/CardTypeView;",false,JValue.Default("Lforge/card/CardTypeView;"),null));
c.Add(new JMethod(1180,"forge/card/StateChangedType","<init>","(Lforge/card/CardTypeView;)V",1,2,2,new JHandler[]{},M1180));
c.Add(new JMethod(1181,"forge/card/StateChangedType","applyChanges","(Lforge/card/CardType;)Lforge/card/CardType;",1,2,3,new JHandler[]{},M1181));
c.Add(new JMethod(1182,"forge/card/StateChangedType","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M1182));
c.Add(new JMethod(1183,"forge/card/StateChangedType","hashCode","()I",17,1,1,new JHandler[]{},M1183));
c.Add(new JMethod(1184,"forge/card/StateChangedType","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M1184));
c.Add(new JMethod(1185,"forge/card/StateChangedType","type","()Lforge/card/CardTypeView;",1,1,1,new JHandler[]{},M1185));
}

internal static JStep M1180(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/StateChangedType","type","Lforge/card/CardTypeView;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1181(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/card/StateChangedType","type","Lforge/card/CardTypeView;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardType","<init>","(Lforge/card/CardTypeView;)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1182(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/card/StateChangedType:1182:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/card/StateChangedType;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1183(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/card/StateChangedType:1183:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/card/StateChangedType;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1184(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/card/StateChangedType:1184:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/card/StateChangedType;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1185(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/StateChangedType","type","Lforge/card/CardTypeView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
