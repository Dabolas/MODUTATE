// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1163{
internal static JClass Build(){var c=new JClass("forge/util/TextUtil$PhraseCase","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("Title","Lforge/util/TextUtil$PhraseCase;",true,JValue.Default("Lforge/util/TextUtil$PhraseCase;"),null));
c.Add(new JField("Sentence","Lforge/util/TextUtil$PhraseCase;",true,JValue.Default("Lforge/util/TextUtil$PhraseCase;"),null));
c.Add(new JField("Lower","Lforge/util/TextUtil$PhraseCase;",true,JValue.Default("Lforge/util/TextUtil$PhraseCase;"),null));
c.Add(new JField("$VALUES","[Lforge/util/TextUtil$PhraseCase;",true,JValue.Default("[Lforge/util/TextUtil$PhraseCase;"),null));
c.Add(new JMethod(12075,"forge/util/TextUtil$PhraseCase","values","()[Lforge/util/TextUtil$PhraseCase;",9,0,1,new JHandler[]{},M12075));
c.Add(new JMethod(12076,"forge/util/TextUtil$PhraseCase","valueOf","(Ljava/lang/String;)Lforge/util/TextUtil$PhraseCase;",9,1,2,new JHandler[]{},M12076));
c.Add(new JMethod(12077,"forge/util/TextUtil$PhraseCase","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M12077));
c.Add(new JMethod(12078,"forge/util/TextUtil$PhraseCase","$values","()[Lforge/util/TextUtil$PhraseCase;",4106,0,4,new JHandler[]{},M12078));
c.Add(new JMethod(12079,"forge/util/TextUtil$PhraseCase","<clinit>","()V",8,0,4,new JHandler[]{},M12079));
}

internal static JStep M12075(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/TextUtil$PhraseCase","$VALUES","[Lforge/util/TextUtil$PhraseCase;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil$PhraseCase","$VALUES","[Lforge/util/TextUtil$PhraseCase;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/util/TextUtil$PhraseCase;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/util/TextUtil$PhraseCase;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12076(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/util/TextUtil$PhraseCase")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/TextUtil$PhraseCase"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12077(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12078(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(3));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Lforge/util/TextUtil$PhraseCase;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/util/TextUtil$PhraseCase","Title","Lforge/util/TextUtil$PhraseCase;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil$PhraseCase","Title","Lforge/util/TextUtil$PhraseCase;"));f.Pc=9;continue;}
case 9:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/util/TextUtil$PhraseCase","Sentence","Lforge/util/TextUtil$PhraseCase;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil$PhraseCase","Sentence","Lforge/util/TextUtil$PhraseCase;"));f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/util/TextUtil$PhraseCase","Lower","Lforge/util/TextUtil$PhraseCase;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil$PhraseCase","Lower","Lforge/util/TextUtil$PhraseCase;"));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12079(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/TextUtil$PhraseCase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/TextUtil$PhraseCase")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Title")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/util/TextUtil$PhraseCase","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/util/TextUtil$PhraseCase","Title","Lforge/util/TextUtil$PhraseCase;"))return JStep.Continue;rt.PutStatic("forge/util/TextUtil$PhraseCase","Title","Lforge/util/TextUtil$PhraseCase;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/util/TextUtil$PhraseCase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/TextUtil$PhraseCase")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Sentence")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/util/TextUtil$PhraseCase","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/util/TextUtil$PhraseCase","Sentence","Lforge/util/TextUtil$PhraseCase;"))return JStep.Continue;rt.PutStatic("forge/util/TextUtil$PhraseCase","Sentence","Lforge/util/TextUtil$PhraseCase;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/util/TextUtil$PhraseCase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/TextUtil$PhraseCase")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("Lower")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/util/TextUtil$PhraseCase","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/util/TextUtil$PhraseCase","Lower","Lforge/util/TextUtil$PhraseCase;"))return JStep.Continue;rt.PutStatic("forge/util/TextUtil$PhraseCase","Lower","Lforge/util/TextUtil$PhraseCase;",f.Pop());f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/util/TextUtil$PhraseCase","$values","()[Lforge/util/TextUtil$PhraseCase;","invokestatic",42);}
case 42:{if(!rt.StaticReady(f,"forge/util/TextUtil$PhraseCase","$VALUES","[Lforge/util/TextUtil$PhraseCase;"))return JStep.Continue;rt.PutStatic("forge/util/TextUtil$PhraseCase","$VALUES","[Lforge/util/TextUtil$PhraseCase;",f.Pop());f.Pc=45;continue;}
case 45:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
