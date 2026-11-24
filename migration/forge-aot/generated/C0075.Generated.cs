// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C75{
internal static JClass Build(){var c=new JClass("forge/card/WordChangedType","java/lang/Record",new string[]{"forge/card/ICardChangedType"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("oldWord","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("newWord","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(1186,"forge/card/WordChangedType","<init>","(Ljava/lang/String;Ljava/lang/String;)V",1,3,2,new JHandler[]{},M1186));
c.Add(new JMethod(1187,"forge/card/WordChangedType","applyChanges","(Lforge/card/CardType;)Lforge/card/CardType;",1,2,2,new JHandler[]{},M1187));
c.Add(new JMethod(1188,"forge/card/WordChangedType","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M1188));
c.Add(new JMethod(1189,"forge/card/WordChangedType","hashCode","()I",17,1,1,new JHandler[]{},M1189));
c.Add(new JMethod(1190,"forge/card/WordChangedType","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M1190));
c.Add(new JMethod(1191,"forge/card/WordChangedType","oldWord","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1191));
c.Add(new JMethod(1192,"forge/card/WordChangedType","newWord","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1192));
}

internal static JStep M1186(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/WordChangedType","oldWord","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/WordChangedType","newWord","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1187(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/card/WordChangedType","oldWord","Ljava/lang/String;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","hasStringType","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?39:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/card/WordChangedType","oldWord","Ljava/lang/String;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/card/WordChangedType","newWord","Ljava/lang/String;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",38);}
case 38:{f.StackOp("pop");f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1188(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/card/WordChangedType:1188:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/card/WordChangedType;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1189(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/card/WordChangedType:1189:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/card/WordChangedType;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1190(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/card/WordChangedType:1190:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/card/WordChangedType;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1191(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/WordChangedType","oldWord","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1192(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/WordChangedType","newWord","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
