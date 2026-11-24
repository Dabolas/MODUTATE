// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C41{
internal static JClass Build(){var c=new JClass("forge/card/CardRulesPredicates$LeafColor$ColorOperator","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("CountColors","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",true,JValue.Default("Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"),null));
c.Add(new JField("CountColorsGreaterOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",true,JValue.Default("Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"),null));
c.Add(new JField("CountColorsGreater","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",true,JValue.Default("Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"),null));
c.Add(new JField("CountColorsSmallerOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",true,JValue.Default("Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"),null));
c.Add(new JField("CountColorsSmaller","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",true,JValue.Default("Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"),null));
c.Add(new JField("HasAnyOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",true,JValue.Default("Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"),null));
c.Add(new JField("HasAllOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",true,JValue.Default("Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"),null));
c.Add(new JField("Equals","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",true,JValue.Default("Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"),null));
c.Add(new JField("CanCast","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",true,JValue.Default("Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"),null));
c.Add(new JField("$VALUES","[Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",true,JValue.Default("[Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"),null));
c.Add(new JMethod(744,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","values","()[Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",9,0,1,new JHandler[]{},M744));
c.Add(new JMethod(745,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","valueOf","(Ljava/lang/String;)Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",9,1,2,new JHandler[]{},M745));
c.Add(new JMethod(746,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M746));
c.Add(new JMethod(747,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","$values","()[Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",4106,0,4,new JHandler[]{},M747));
c.Add(new JMethod(748,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","<clinit>","()V",8,0,4,new JHandler[]{},M748));
}

internal static JStep M744(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","$VALUES","[Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","$VALUES","[Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M745(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/CardRulesPredicates$LeafColor$ColorOperator")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRulesPredicates$LeafColor$ColorOperator"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M746(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M747(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(9));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColors","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColors","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsGreaterOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsGreaterOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsGreater","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsGreater","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsSmallerOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsSmallerOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsSmaller","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsSmaller","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","HasAnyOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","HasAnyOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","HasAllOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","HasAllOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","Equals","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","Equals","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CanCast","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CanCast","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M748(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor$ColorOperator")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("CountColors")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColors","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColors","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor$ColorOperator")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("CountColorsGreaterOrEqual")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsGreaterOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsGreaterOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor$ColorOperator")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("CountColorsGreater")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsGreater","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsGreater","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor$ColorOperator")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("CountColorsSmallerOrEqual")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","<init>","(Ljava/lang/String;I)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsSmallerOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsSmallerOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",f.Pop());f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor$ColorOperator")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("CountColorsSmaller")));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(4));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","<init>","(Ljava/lang/String;I)V","invokespecial",62);}
case 62:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsSmaller","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsSmaller","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",f.Pop());f.Pc=65;continue;}
case 65:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor$ColorOperator")));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("HasAnyOf")));f.Pc=71;continue;}
case 71:{f.Push(JValue.I(5));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","<init>","(Ljava/lang/String;I)V","invokespecial",75);}
case 75:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","HasAnyOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","HasAnyOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",f.Pop());f.Pc=78;continue;}
case 78:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor$ColorOperator")));f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("HasAllOf")));f.Pc=84;continue;}
case 84:{f.Push(JValue.I(6));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","<init>","(Ljava/lang/String;I)V","invokespecial",89);}
case 89:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","HasAllOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","HasAllOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",f.Pop());f.Pc=92;continue;}
case 92:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor$ColorOperator")));f.Pc=95;continue;}
case 95:{f.StackOp("dup");f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("Equals")));f.Pc=98;continue;}
case 98:{f.Push(JValue.I(7));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","<init>","(Ljava/lang/String;I)V","invokespecial",103);}
case 103:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","Equals","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","Equals","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",f.Pop());f.Pc=106;continue;}
case 106:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor$ColorOperator")));f.Pc=109;continue;}
case 109:{f.StackOp("dup");f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("CanCast")));f.Pc=112;continue;}
case 112:{f.Push(JValue.I(8));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","<init>","(Ljava/lang/String;I)V","invokespecial",117);}
case 117:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CanCast","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CanCast","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",f.Pop());f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","$values","()[Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;","invokestatic",123);}
case 123:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","$VALUES","[Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","$VALUES","[Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",f.Pop());f.Pc=126;continue;}
case 126:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
