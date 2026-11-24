// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C186{
internal static JClass Build(){var c=new JClass("forge/game/ability/IllegalAbilityException","java/lang/RuntimeException",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-8638474348184716635L),null));
c.Add(new JField("fromCustom","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(2898,"forge/game/ability/IllegalAbilityException","<init>","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M2898));
c.Add(new JMethod(2899,"forge/game/ability/IllegalAbilityException","<init>","(Lforge/game/spellability/SpellAbility;Lforge/game/ability/SpellAbilityEffect;)V",1,3,5,new JHandler[]{},M2899));
c.Add(new JMethod(2900,"forge/game/ability/IllegalAbilityException","<init>","(Ljava/lang/String;Ljava/lang/Throwable;Z)V",1,4,3,new JHandler[]{},M2900));
c.Add(new JMethod(2901,"forge/game/ability/IllegalAbilityException","isCustom","()Z",1,1,1,new JHandler[]{},M2901));
}

internal static JStep M2898(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","toString","()Ljava/lang/String;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/IllegalAbilityException","fromCustom","Z",value);f.Pc=13;continue;}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2899(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(2));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","toString","()Ljava/lang/String;","invokevirtual",11);}
case 11:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",18);}
case 18:{return rt.Call(f,"java/lang/Class","getName","()Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.DynamicCall(f,"forge/game/ability/IllegalAbilityException:2899:21:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",26);}
case 26:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",30);}
case 30:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",33);}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/IllegalAbilityException","fromCustom","Z",value);f.Pc=38;continue;}
case 38:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2900(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/IllegalAbilityException","fromCustom","Z",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/IllegalAbilityException","fromCustom","Z",value);f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2901(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/IllegalAbilityException","fromCustom","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
