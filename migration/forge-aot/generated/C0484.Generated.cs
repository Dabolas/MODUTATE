// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C484{
internal static JClass Build(){var c=new JClass("forge/game/card/CounterType","java/lang/Object",new string[]{"java/io/Serializable","forge/util/ITranslatable"},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(5799,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;",9,2,2,new JHandler[]{new JHandler(23,27,28,"java/lang/IllegalArgumentException")},M5799));
c.Add(new JMethod(5800,"forge/game/card/CounterType","getValues","()Ljava/util/List;",9,1,2,new JHandler[]{},M5800));
c.Add(new JMethod(5801,"forge/game/card/CounterType","getName","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(5802,"forge/game/card/CounterType","getCounterOnCardDisplayName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5802));
c.Add(new JMethod(5803,"forge/game/card/CounterType","is","(Lforge/game/card/CounterEnumType;)Z",1,2,1,new JHandler[]{},M5803));
c.Add(new JMethod(5804,"forge/game/card/CounterType","isKeywordCounter","()Z",1,1,1,new JHandler[]{},M5804));
c.Add(new JMethod(5805,"forge/game/card/CounterType","getRed","()I",1,1,1,new JHandler[]{},M5805));
c.Add(new JMethod(5806,"forge/game/card/CounterType","getGreen","()I",1,1,1,new JHandler[]{},M5806));
c.Add(new JMethod(5807,"forge/game/card/CounterType","getBlue","()I",1,1,1,new JHandler[]{},M5807));
c.Add(new JMethod(5808,"forge/game/card/CounterType","getAiCategory","()Lforge/game/card/CounterAiCategory;",1,1,1,new JHandler[]{},M5808));
c.Add(new JMethod(5809,"forge/game/card/CounterType","getTranslationKey","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5809));
c.Add(new JMethod(5810,"forge/game/card/CounterType","getUntranslatedName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5810));
}

internal static JStep M5799(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Any")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?11:9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CounterKeywordType","isKeywordCounter","(Ljava/lang/String;)Z","invokestatic",15);}
case 15:{f.Pc=f.Pop().Int==0?23:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CounterKeywordType","get","(Ljava/lang/String;)Lforge/game/card/CounterKeywordType;","invokestatic",22);}
case 22:{return JStep.Return(f.Pop());}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/CounterEnumType","getType","(Ljava/lang/String;)Lforge/game/card/CounterEnumType;","invokestatic",27);}
case 27:{return JStep.Return(f.Pop());}
case 28:{f.Locals[1]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/CounterCustomType","get","(Ljava/lang/String;)Lforge/game/card/CounterCustomType;","invokestatic",33);}
case 33:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5800(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[0]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CounterEnumType","values","()[Lforge/game/card/CounterEnumType;","invokestatic",8);}
case 8:{return rt.Call(f,"java/util/List","of","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",11);}
case 11:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",16);}
case 16:{f.StackOp("pop");f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/CounterKeywordType","getValues","()Ljava/util/Set;","invokestatic",21);}
case 21:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/CounterCustomType","getValues","()Ljava/util/Set;","invokestatic",31);}
case 31:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5802(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5803(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5804(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5805(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(255));f.Pc=3;continue;}
case 3:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5806(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(255));f.Pc=3;continue;}
case 3:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5807(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(255));f.Pc=3;continue;}
case 3:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5808(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/card/CounterAiCategory","Positive","Lforge/game/card/CounterAiCategory;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterAiCategory","Positive","Lforge/game/card/CounterAiCategory;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5809(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5810(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
