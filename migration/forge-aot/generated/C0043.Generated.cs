// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C43{
internal static JClass Build(){var c=new JClass("forge/card/CardRulesPredicates$LeafNumber$CardField","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("CMC","Lforge/card/CardRulesPredicates$LeafNumber$CardField;",true,JValue.Default("Lforge/card/CardRulesPredicates$LeafNumber$CardField;"),null));
c.Add(new JField("GENERIC_COST","Lforge/card/CardRulesPredicates$LeafNumber$CardField;",true,JValue.Default("Lforge/card/CardRulesPredicates$LeafNumber$CardField;"),null));
c.Add(new JField("POWER","Lforge/card/CardRulesPredicates$LeafNumber$CardField;",true,JValue.Default("Lforge/card/CardRulesPredicates$LeafNumber$CardField;"),null));
c.Add(new JField("TOUGHNESS","Lforge/card/CardRulesPredicates$LeafNumber$CardField;",true,JValue.Default("Lforge/card/CardRulesPredicates$LeafNumber$CardField;"),null));
c.Add(new JField("PT","Lforge/card/CardRulesPredicates$LeafNumber$CardField;",true,JValue.Default("Lforge/card/CardRulesPredicates$LeafNumber$CardField;"),null));
c.Add(new JField("LOYALTY","Lforge/card/CardRulesPredicates$LeafNumber$CardField;",true,JValue.Default("Lforge/card/CardRulesPredicates$LeafNumber$CardField;"),null));
c.Add(new JField("$VALUES","[Lforge/card/CardRulesPredicates$LeafNumber$CardField;",true,JValue.Default("[Lforge/card/CardRulesPredicates$LeafNumber$CardField;"),null));
c.Add(new JMethod(752,"forge/card/CardRulesPredicates$LeafNumber$CardField","values","()[Lforge/card/CardRulesPredicates$LeafNumber$CardField;",9,0,1,new JHandler[]{},M752));
c.Add(new JMethod(753,"forge/card/CardRulesPredicates$LeafNumber$CardField","valueOf","(Ljava/lang/String;)Lforge/card/CardRulesPredicates$LeafNumber$CardField;",9,1,2,new JHandler[]{},M753));
c.Add(new JMethod(754,"forge/card/CardRulesPredicates$LeafNumber$CardField","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M754));
c.Add(new JMethod(755,"forge/card/CardRulesPredicates$LeafNumber$CardField","$values","()[Lforge/card/CardRulesPredicates$LeafNumber$CardField;",4106,0,4,new JHandler[]{},M755));
c.Add(new JMethod(756,"forge/card/CardRulesPredicates$LeafNumber$CardField","<clinit>","()V",8,0,4,new JHandler[]{},M756));
}

internal static JStep M752(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","$VALUES","[Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","$VALUES","[Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/CardRulesPredicates$LeafNumber$CardField;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M753(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/CardRulesPredicates$LeafNumber$CardField")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRulesPredicates$LeafNumber$CardField"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M754(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M755(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(6));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/card/CardRulesPredicates$LeafNumber$CardField;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","CMC","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","CMC","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","GENERIC_COST","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","GENERIC_COST","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","POWER","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","POWER","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","TOUGHNESS","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","TOUGHNESS","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","PT","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","PT","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","LOYALTY","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","LOYALTY","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M756(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafNumber$CardField"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafNumber$CardField")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("CMC")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","CMC","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","CMC","Lforge/card/CardRulesPredicates$LeafNumber$CardField;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafNumber$CardField"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafNumber$CardField")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("GENERIC_COST")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","GENERIC_COST","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","GENERIC_COST","Lforge/card/CardRulesPredicates$LeafNumber$CardField;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafNumber$CardField"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafNumber$CardField")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("POWER")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","POWER","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","POWER","Lforge/card/CardRulesPredicates$LeafNumber$CardField;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafNumber$CardField"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafNumber$CardField")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("TOUGHNESS")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","<init>","(Ljava/lang/String;I)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","TOUGHNESS","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","TOUGHNESS","Lforge/card/CardRulesPredicates$LeafNumber$CardField;",f.Pop());f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafNumber$CardField"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafNumber$CardField")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("PT")));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(4));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","<init>","(Ljava/lang/String;I)V","invokespecial",62);}
case 62:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","PT","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","PT","Lforge/card/CardRulesPredicates$LeafNumber$CardField;",f.Pop());f.Pc=65;continue;}
case 65:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafNumber$CardField"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafNumber$CardField")));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("LOYALTY")));f.Pc=71;continue;}
case 71:{f.Push(JValue.I(5));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","<init>","(Ljava/lang/String;I)V","invokespecial",75);}
case 75:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","LOYALTY","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","LOYALTY","Lforge/card/CardRulesPredicates$LeafNumber$CardField;",f.Pop());f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","$values","()[Lforge/card/CardRulesPredicates$LeafNumber$CardField;","invokestatic",81);}
case 81:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","$VALUES","[Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","$VALUES","[Lforge/card/CardRulesPredicates$LeafNumber$CardField;",f.Pop());f.Pc=84;continue;}
case 84:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
