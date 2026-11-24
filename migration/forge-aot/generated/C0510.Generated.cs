// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C510{
internal static JClass Build(){var c=new JClass("forge/game/combat/AttackRestrictionType","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;",true,JValue.Default("Lforge/game/combat/AttackRestrictionType;"),null));
c.Add(new JField("NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;",true,JValue.Default("Lforge/game/combat/AttackRestrictionType;"),null));
c.Add(new JField("NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;",true,JValue.Default("Lforge/game/combat/AttackRestrictionType;"),null));
c.Add(new JField("NOT_ALONE","Lforge/game/combat/AttackRestrictionType;",true,JValue.Default("Lforge/game/combat/AttackRestrictionType;"),null));
c.Add(new JField("NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;",true,JValue.Default("Lforge/game/combat/AttackRestrictionType;"),null));
c.Add(new JField("NEVER","Lforge/game/combat/AttackRestrictionType;",true,JValue.Default("Lforge/game/combat/AttackRestrictionType;"),null));
c.Add(new JField("$VALUES","[Lforge/game/combat/AttackRestrictionType;",true,JValue.Default("[Lforge/game/combat/AttackRestrictionType;"),null));
c.Add(new JMethod(6007,"forge/game/combat/AttackRestrictionType","values","()[Lforge/game/combat/AttackRestrictionType;",9,0,1,new JHandler[]{},M6007));
c.Add(new JMethod(6008,"forge/game/combat/AttackRestrictionType","valueOf","(Ljava/lang/String;)Lforge/game/combat/AttackRestrictionType;",9,1,2,new JHandler[]{},M6008));
c.Add(new JMethod(6009,"forge/game/combat/AttackRestrictionType","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M6009));
c.Add(new JMethod(6010,"forge/game/combat/AttackRestrictionType","getPredicate","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",1,2,3,new JHandler[]{},M6010));
c.Add(new JMethod(6011,"forge/game/combat/AttackRestrictionType","lambda$getPredicate$0","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M6011));
c.Add(new JMethod(6012,"forge/game/combat/AttackRestrictionType","$values","()[Lforge/game/combat/AttackRestrictionType;",4106,0,4,new JHandler[]{},M6012));
c.Add(new JMethod(6013,"forge/game/combat/AttackRestrictionType","<clinit>","()V",8,0,4,new JHandler[]{},M6013));
}

internal static JStep M6007(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","$VALUES","[Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","$VALUES","[Lforge/game/combat/AttackRestrictionType;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/combat/AttackRestrictionType;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/combat/AttackRestrictionType;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6008(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/combat/AttackRestrictionType")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackRestrictionType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6009(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6010(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType$1","$SwitchMap$forge$game$combat$AttackRestrictionType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType$1","$SwitchMap$forge$game$combat$AttackRestrictionType","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/combat/AttackRestrictionType","ordinal","()I","invokevirtual",7);}
case 7:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8;continue;}
case 8:{switch(f.Pop().Int){case 1:f.Pc=36;break;case 2:f.Pc=44;break;case 3:f.Pc=69;break;default:f.Pc=75;break;}continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",40);}
case 40:{return rt.Call(f,"forge/game/card/CardPredicates","hasGreaterPowerThan","(I)Ljava/util/function/Predicate;","invokestatic",43);}
case 43:{return JStep.Return(f.Pop());}
case 44:{f.Push(JValue.I(20));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/CardPredicates","isColor","(B)Ljava/util/function/Predicate;","invokestatic",49);}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.StackOp("dup");f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{return rt.DynamicCall(f,"forge/game/combat/AttackRestrictionType:6010:55:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",60);}
case 60:{return rt.Call(f,"java/util/function/Predicate","not","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",63);}
case 63:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",68);}
case 68:{return JStep.Return(f.Pop());}
case 69:{return rt.DynamicCall(f,"forge/game/combat/AttackRestrictionType:6010:69:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",74);}
case 74:{return JStep.Return(f.Pop());}
case 75:{f.Push(JValue.R(null));f.Pc=76;continue;}
case 76:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6011(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6012(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(6));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/game/combat/AttackRestrictionType;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NOT_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NOT_ALONE","Lforge/game/combat/AttackRestrictionType;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEVER","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEVER","Lforge/game/combat/AttackRestrictionType;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6013(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/combat/AttackRestrictionType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/AttackRestrictionType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("ONLY_ALONE")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/combat/AttackRestrictionType","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;rt.PutStatic("forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/game/combat/AttackRestrictionType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/AttackRestrictionType")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("NEED_GREATER_POWER")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/combat/AttackRestrictionType","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;rt.PutStatic("forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/game/combat/AttackRestrictionType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/AttackRestrictionType")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("NEED_BLACK_OR_GREEN")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/combat/AttackRestrictionType","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;rt.PutStatic("forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/game/combat/AttackRestrictionType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/AttackRestrictionType")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("NOT_ALONE")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/combat/AttackRestrictionType","<init>","(Ljava/lang/String;I)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NOT_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;rt.PutStatic("forge/game/combat/AttackRestrictionType","NOT_ALONE","Lforge/game/combat/AttackRestrictionType;",f.Pop());f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/game/combat/AttackRestrictionType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/AttackRestrictionType")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("NEED_TWO_OTHERS")));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(4));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/combat/AttackRestrictionType","<init>","(Ljava/lang/String;I)V","invokespecial",62);}
case 62:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;rt.PutStatic("forge/game/combat/AttackRestrictionType","NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;",f.Pop());f.Pc=65;continue;}
case 65:{if(!rt.EnsureInitialized(f,"forge/game/combat/AttackRestrictionType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/AttackRestrictionType")));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("NEVER")));f.Pc=71;continue;}
case 71:{f.Push(JValue.I(5));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/combat/AttackRestrictionType","<init>","(Ljava/lang/String;I)V","invokespecial",75);}
case 75:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEVER","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;rt.PutStatic("forge/game/combat/AttackRestrictionType","NEVER","Lforge/game/combat/AttackRestrictionType;",f.Pop());f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/combat/AttackRestrictionType","$values","()[Lforge/game/combat/AttackRestrictionType;","invokestatic",81);}
case 81:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","$VALUES","[Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;rt.PutStatic("forge/game/combat/AttackRestrictionType","$VALUES","[Lforge/game/combat/AttackRestrictionType;",f.Pop());f.Pc=84;continue;}
case 84:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
