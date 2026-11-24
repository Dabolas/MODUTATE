// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C19{
internal static JClass Build(){var c=new JClass("forge/card/CardEdition$BorderColor","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("WHITE","Lforge/card/CardEdition$BorderColor;",true,JValue.Default("Lforge/card/CardEdition$BorderColor;"),null));
c.Add(new JField("BLACK","Lforge/card/CardEdition$BorderColor;",true,JValue.Default("Lforge/card/CardEdition$BorderColor;"),null));
c.Add(new JField("SILVER","Lforge/card/CardEdition$BorderColor;",true,JValue.Default("Lforge/card/CardEdition$BorderColor;"),null));
c.Add(new JField("GOLD","Lforge/card/CardEdition$BorderColor;",true,JValue.Default("Lforge/card/CardEdition$BorderColor;"),null));
c.Add(new JField("$VALUES","[Lforge/card/CardEdition$BorderColor;",true,JValue.Default("[Lforge/card/CardEdition$BorderColor;"),null));
c.Add(new JMethod(429,"forge/card/CardEdition$BorderColor","values","()[Lforge/card/CardEdition$BorderColor;",9,0,1,new JHandler[]{},M429));
c.Add(new JMethod(430,"forge/card/CardEdition$BorderColor","valueOf","(Ljava/lang/String;)Lforge/card/CardEdition$BorderColor;",9,1,2,new JHandler[]{},M430));
c.Add(new JMethod(431,"forge/card/CardEdition$BorderColor","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M431));
c.Add(new JMethod(432,"forge/card/CardEdition$BorderColor","$values","()[Lforge/card/CardEdition$BorderColor;",4106,0,4,new JHandler[]{},M432));
c.Add(new JMethod(433,"forge/card/CardEdition$BorderColor","<clinit>","()V",8,0,4,new JHandler[]{},M433));
}

internal static JStep M429(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","$VALUES","[Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","$VALUES","[Lforge/card/CardEdition$BorderColor;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/CardEdition$BorderColor;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/CardEdition$BorderColor;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M430(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/CardEdition$BorderColor")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$BorderColor"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M431(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M432(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(4));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Lforge/card/CardEdition$BorderColor;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","WHITE","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","WHITE","Lforge/card/CardEdition$BorderColor;"));f.Pc=9;continue;}
case 9:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"));f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","SILVER","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","SILVER","Lforge/card/CardEdition$BorderColor;"));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.I(3));f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","GOLD","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","GOLD","Lforge/card/CardEdition$BorderColor;"));f.Pc=27;continue;}
case 27:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M433(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$BorderColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$BorderColor")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("WHITE")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardEdition$BorderColor","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","WHITE","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$BorderColor","WHITE","Lforge/card/CardEdition$BorderColor;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$BorderColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$BorderColor")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("BLACK")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardEdition$BorderColor","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$BorderColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$BorderColor")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("SILVER")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/CardEdition$BorderColor","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","SILVER","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$BorderColor","SILVER","Lforge/card/CardEdition$BorderColor;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$BorderColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$BorderColor")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("GOLD")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/card/CardEdition$BorderColor","<init>","(Ljava/lang/String;I)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","GOLD","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$BorderColor","GOLD","Lforge/card/CardEdition$BorderColor;",f.Pop());f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/card/CardEdition$BorderColor","$values","()[Lforge/card/CardEdition$BorderColor;","invokestatic",55);}
case 55:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","$VALUES","[Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$BorderColor","$VALUES","[Lforge/card/CardEdition$BorderColor;",f.Pop());f.Pc=58;continue;}
case 58:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
