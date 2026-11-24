// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1081{
internal static JClass Build(){var c=new JClass("forge/item/SealedTemplateWithSlots","forge/item/SealedTemplate",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("boosterSlots","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(11440,"forge/item/SealedTemplateWithSlots","<init>","(Ljava/lang/String;Ljava/lang/Iterable;Ljava/util/List;)V",1,4,3,new JHandler[]{},M11440));
c.Add(new JMethod(11441,"forge/item/SealedTemplateWithSlots","getNamedSlots","()Ljava/util/Map;",1,1,3,new JHandler[]{},M11441));
}

internal static JStep M11440(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/item/SealedTemplate","<init>","(Ljava/lang/String;Ljava/lang/Iterable;)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/SealedTemplateWithSlots","boosterSlots","Ljava/util/List;",value);f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11441(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedTemplateWithSlots","boosterSlots","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",9);}
case 9:{return rt.DynamicCall(f,"forge/item/SealedTemplateWithSlots:11441:9:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",14);}
case 14:{return rt.Call(f,"java/util/function/Function","identity","()Ljava/util/function/Function;","invokestatic",17);}
case 17:{return rt.Call(f,"java/util/stream/Collectors","toMap","(Ljava/util/function/Function;Ljava/util/function/Function;)Ljava/util/stream/Collector;","invokestatic",20);}
case 20:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
