// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C22{
internal static JClass Build(){var c=new JClass("forge/card/CardEdition$DraftType","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("Normal","Lforge/card/CardEdition$DraftType;",true,JValue.Default("Lforge/card/CardEdition$DraftType;"),null));
c.Add(new JField("Commander","Lforge/card/CardEdition$DraftType;",true,JValue.Default("Lforge/card/CardEdition$DraftType;"),null));
c.Add(new JField("$VALUES","[Lforge/card/CardEdition$DraftType;",true,JValue.Default("[Lforge/card/CardEdition$DraftType;"),null));
c.Add(new JMethod(454,"forge/card/CardEdition$DraftType","values","()[Lforge/card/CardEdition$DraftType;",9,0,1,new JHandler[]{},M454));
c.Add(new JMethod(455,"forge/card/CardEdition$DraftType","valueOf","(Ljava/lang/String;)Lforge/card/CardEdition$DraftType;",9,1,2,new JHandler[]{},M455));
c.Add(new JMethod(456,"forge/card/CardEdition$DraftType","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M456));
c.Add(new JMethod(457,"forge/card/CardEdition$DraftType","fromString","(Ljava/lang/String;)Lforge/card/CardEdition$DraftType;",9,2,1,new JHandler[]{new JHandler(15,19,20,"java/lang/IllegalArgumentException")},M457));
c.Add(new JMethod(458,"forge/card/CardEdition$DraftType","$values","()[Lforge/card/CardEdition$DraftType;",4106,0,4,new JHandler[]{},M458));
c.Add(new JMethod(459,"forge/card/CardEdition$DraftType","<clinit>","()V",8,0,4,new JHandler[]{},M459));
}

internal static JStep M454(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardEdition$DraftType","$VALUES","[Lforge/card/CardEdition$DraftType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$DraftType","$VALUES","[Lforge/card/CardEdition$DraftType;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/CardEdition$DraftType;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/CardEdition$DraftType;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M455(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/CardEdition$DraftType")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$DraftType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M456(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M457(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?11:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?15:11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/card/CardEdition$DraftType","Normal","Lforge/card/CardEdition$DraftType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$DraftType","Normal","Lforge/card/CardEdition$DraftType;"));f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/CardEdition$DraftType","valueOf","(Ljava/lang/String;)Lforge/card/CardEdition$DraftType;","invokestatic",19);}
case 19:{return JStep.Return(f.Pop());}
case 20:{f.Locals[1]=f.Pop();f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/card/CardEdition$DraftType","Normal","Lforge/card/CardEdition$DraftType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$DraftType","Normal","Lforge/card/CardEdition$DraftType;"));f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M458(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(2));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Lforge/card/CardEdition$DraftType;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/card/CardEdition$DraftType","Normal","Lforge/card/CardEdition$DraftType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$DraftType","Normal","Lforge/card/CardEdition$DraftType;"));f.Pc=9;continue;}
case 9:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/card/CardEdition$DraftType","Commander","Lforge/card/CardEdition$DraftType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$DraftType","Commander","Lforge/card/CardEdition$DraftType;"));f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M459(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$DraftType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$DraftType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Normal")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardEdition$DraftType","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/card/CardEdition$DraftType","Normal","Lforge/card/CardEdition$DraftType;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$DraftType","Normal","Lforge/card/CardEdition$DraftType;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$DraftType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$DraftType")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Commander")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardEdition$DraftType","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/card/CardEdition$DraftType","Commander","Lforge/card/CardEdition$DraftType;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$DraftType","Commander","Lforge/card/CardEdition$DraftType;",f.Pop());f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/card/CardEdition$DraftType","$values","()[Lforge/card/CardEdition$DraftType;","invokestatic",29);}
case 29:{if(!rt.StaticReady(f,"forge/card/CardEdition$DraftType","$VALUES","[Lforge/card/CardEdition$DraftType;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$DraftType","$VALUES","[Lforge/card/CardEdition$DraftType;",f.Pop());f.Pc=32;continue;}
case 32:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
