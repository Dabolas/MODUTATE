// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C98{
internal static JClass Build(){var c=new JClass("forge/deck/DeckRecognizer$LimitedCardType","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("BANNED","Lforge/deck/DeckRecognizer$LimitedCardType;",true,JValue.Default("Lforge/deck/DeckRecognizer$LimitedCardType;"),null));
c.Add(new JField("RESTRICTED","Lforge/deck/DeckRecognizer$LimitedCardType;",true,JValue.Default("Lforge/deck/DeckRecognizer$LimitedCardType;"),null));
c.Add(new JField("$VALUES","[Lforge/deck/DeckRecognizer$LimitedCardType;",true,JValue.Default("[Lforge/deck/DeckRecognizer$LimitedCardType;"),null));
c.Add(new JMethod(1562,"forge/deck/DeckRecognizer$LimitedCardType","values","()[Lforge/deck/DeckRecognizer$LimitedCardType;",9,0,1,new JHandler[]{},M1562));
c.Add(new JMethod(1563,"forge/deck/DeckRecognizer$LimitedCardType","valueOf","(Ljava/lang/String;)Lforge/deck/DeckRecognizer$LimitedCardType;",9,1,2,new JHandler[]{},M1563));
c.Add(new JMethod(1564,"forge/deck/DeckRecognizer$LimitedCardType","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M1564));
c.Add(new JMethod(1565,"forge/deck/DeckRecognizer$LimitedCardType","$values","()[Lforge/deck/DeckRecognizer$LimitedCardType;",4106,0,4,new JHandler[]{},M1565));
c.Add(new JMethod(1566,"forge/deck/DeckRecognizer$LimitedCardType","<clinit>","()V",8,0,4,new JHandler[]{},M1566));
}

internal static JStep M1562(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$LimitedCardType","$VALUES","[Lforge/deck/DeckRecognizer$LimitedCardType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$LimitedCardType","$VALUES","[Lforge/deck/DeckRecognizer$LimitedCardType;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/deck/DeckRecognizer$LimitedCardType;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/deck/DeckRecognizer$LimitedCardType;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1563(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/deck/DeckRecognizer$LimitedCardType")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckRecognizer$LimitedCardType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1564(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1565(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(2));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Lforge/deck/DeckRecognizer$LimitedCardType;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$LimitedCardType","BANNED","Lforge/deck/DeckRecognizer$LimitedCardType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$LimitedCardType","BANNED","Lforge/deck/DeckRecognizer$LimitedCardType;"));f.Pc=9;continue;}
case 9:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$LimitedCardType","RESTRICTED","Lforge/deck/DeckRecognizer$LimitedCardType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$LimitedCardType","RESTRICTED","Lforge/deck/DeckRecognizer$LimitedCardType;"));f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1566(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$LimitedCardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$LimitedCardType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("BANNED")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/deck/DeckRecognizer$LimitedCardType","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$LimitedCardType","BANNED","Lforge/deck/DeckRecognizer$LimitedCardType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$LimitedCardType","BANNED","Lforge/deck/DeckRecognizer$LimitedCardType;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$LimitedCardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$LimitedCardType")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("RESTRICTED")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/deck/DeckRecognizer$LimitedCardType","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$LimitedCardType","RESTRICTED","Lforge/deck/DeckRecognizer$LimitedCardType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$LimitedCardType","RESTRICTED","Lforge/deck/DeckRecognizer$LimitedCardType;",f.Pop());f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/deck/DeckRecognizer$LimitedCardType","$values","()[Lforge/deck/DeckRecognizer$LimitedCardType;","invokestatic",29);}
case 29:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$LimitedCardType","$VALUES","[Lforge/deck/DeckRecognizer$LimitedCardType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$LimitedCardType","$VALUES","[Lforge/deck/DeckRecognizer$LimitedCardType;",f.Pop());f.Pc=32;continue;}
case 32:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
