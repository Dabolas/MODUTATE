// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C145{
internal static JClass Build(){var c=new JClass("forge/game/GameFormat$DeckRules","java/lang/Record",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("singleton","Z",false,JValue.Default("Z"),null));
c.Add(new JField("minMainDeckSize","I",false,JValue.Default("I"),null));
c.Add(new JField("maxPoints","I",false,JValue.Default("I"),null));
c.Add(new JField("cardPoints","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("NONE","Lforge/game/GameFormat$DeckRules;",true,JValue.Default("Lforge/game/GameFormat$DeckRules;"),null));
c.Add(new JMethod(2335,"forge/game/GameFormat$DeckRules","<init>","(ZIILjava/util/Map;)V",1,5,2,new JHandler[]{},M2335));
c.Add(new JMethod(2336,"forge/game/GameFormat$DeckRules","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M2336));
c.Add(new JMethod(2337,"forge/game/GameFormat$DeckRules","hashCode","()I",17,1,1,new JHandler[]{},M2337));
c.Add(new JMethod(2338,"forge/game/GameFormat$DeckRules","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M2338));
c.Add(new JMethod(2339,"forge/game/GameFormat$DeckRules","singleton","()Z",1,1,1,new JHandler[]{},M2339));
c.Add(new JMethod(2340,"forge/game/GameFormat$DeckRules","minMainDeckSize","()I",1,1,1,new JHandler[]{},M2340));
c.Add(new JMethod(2341,"forge/game/GameFormat$DeckRules","maxPoints","()I",1,1,1,new JHandler[]{},M2341));
c.Add(new JMethod(2342,"forge/game/GameFormat$DeckRules","cardPoints","()Ljava/util/Map;",1,1,1,new JHandler[]{},M2342));
c.Add(new JMethod(2343,"forge/game/GameFormat$DeckRules","<clinit>","()V",8,0,6,new JHandler[]{},M2343));
}

internal static JStep M2335(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$DeckRules","singleton","Z",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$DeckRules","minMainDeckSize","I",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$DeckRules","maxPoints","I",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$DeckRules","cardPoints","Ljava/util/Map;",value);f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2336(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/GameFormat$DeckRules:2336:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/GameFormat$DeckRules;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2337(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/GameFormat$DeckRules:2337:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/GameFormat$DeckRules;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2338(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/GameFormat$DeckRules:2338:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/GameFormat$DeckRules;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2339(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$DeckRules","singleton","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2340(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$DeckRules","minMainDeckSize","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2341(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$DeckRules","maxPoints","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2342(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$DeckRules","cardPoints","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2343(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$DeckRules"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$DeckRules")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","of","()Ljava/util/Map;","invokestatic",10);}
case 10:{return rt.Call(f,"forge/game/GameFormat$DeckRules","<init>","(ZIILjava/util/Map;)V","invokespecial",13);}
case 13:{if(!rt.StaticReady(f,"forge/game/GameFormat$DeckRules","NONE","Lforge/game/GameFormat$DeckRules;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat$DeckRules","NONE","Lforge/game/GameFormat$DeckRules;",f.Pop());f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
