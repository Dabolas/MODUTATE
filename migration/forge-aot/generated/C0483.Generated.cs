// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C483{
internal static JClass Build(){var c=new JClass("forge/game/card/CounterKeywordType","java/lang/Record",new string[]{"forge/game/card/CounterType"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("keyword","Lforge/game/keyword/KeywordView;",false,JValue.Default("Lforge/game/keyword/KeywordView;"),null));
c.Add(new JField("keywordCounter","Lcom/google/common/collect/ImmutableList;",true,JValue.Default("Lcom/google/common/collect/ImmutableList;"),null));
c.Add(new JField("sMap","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(5786,"forge/game/card/CounterKeywordType","<init>","(Lforge/game/keyword/KeywordView;)V",1,2,2,new JHandler[]{},M5786));
c.Add(new JMethod(5787,"forge/game/card/CounterKeywordType","get","(Ljava/lang/String;)Lforge/game/card/CounterKeywordType;",9,1,5,new JHandler[]{},M5787));
c.Add(new JMethod(5788,"forge/game/card/CounterKeywordType","getValues","()Ljava/util/Set;",9,1,2,new JHandler[]{},M5788));
c.Add(new JMethod(5789,"forge/game/card/CounterKeywordType","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5789));
c.Add(new JMethod(5790,"forge/game/card/CounterKeywordType","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5790));
c.Add(new JMethod(5791,"forge/game/card/CounterKeywordType","getCounterOnCardDisplayName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5791));
c.Add(new JMethod(5792,"forge/game/card/CounterKeywordType","isKeywordCounter","()Z",1,1,1,new JHandler[]{},M5792));
c.Add(new JMethod(5793,"forge/game/card/CounterKeywordType","isKeywordCounter","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M5793));
c.Add(new JMethod(5794,"forge/game/card/CounterKeywordType","getAiCategory","()Lforge/game/card/CounterAiCategory;",1,1,2,new JHandler[]{},M5794));
c.Add(new JMethod(5795,"forge/game/card/CounterKeywordType","hashCode","()I",17,1,1,new JHandler[]{},M5795));
c.Add(new JMethod(5796,"forge/game/card/CounterKeywordType","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M5796));
c.Add(new JMethod(5797,"forge/game/card/CounterKeywordType","keyword","()Lforge/game/keyword/KeywordView;",1,1,1,new JHandler[]{},M5797));
c.Add(new JMethod(5798,"forge/game/card/CounterKeywordType","<clinit>","()V",8,0,16,new JHandler[]{},M5798));
}

internal static JStep M5786(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CounterKeywordType","keyword","Lforge/game/keyword/KeywordView;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5787(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/card/CounterKeywordType","sMap","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterKeywordType","sMap","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int!=0?38:12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/card/CounterKeywordType","sMap","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterKeywordType","sMap","Ljava/util/Map;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"forge/game/card/CounterKeywordType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CounterKeywordType")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/keyword/Keyword","getInstance","(Ljava/lang/String;)Lforge/game/keyword/KeywordInterface;","invokestatic",24);}
case 24:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getView","()Lforge/game/keyword/KeywordView;","invokeinterface",29);}
case 29:{return rt.Call(f,"forge/game/card/CounterKeywordType","<init>","(Lforge/game/keyword/KeywordView;)V","invokespecial",32);}
case 32:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/game/card/CounterKeywordType","sMap","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterKeywordType","sMap","Ljava/util/Map;"));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterKeywordType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5788(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/card/CounterKeywordType","keywordCounter","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterKeywordType","keywordCounter","Lcom/google/common/collect/ImmutableList;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"com/google/common/collect/ImmutableList","stream","()Ljava/util/stream/Stream;","invokevirtual",6);}
case 6:{return rt.DynamicCall(f,"forge/game/card/CounterKeywordType:5788:6:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",11);}
case 11:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",16);}
case 16:{return rt.DynamicCall(f,"forge/game/card/CounterKeywordType:5788:16:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Supplier;",21);}
case 21:{return rt.Call(f,"java/util/stream/Collectors","toCollection","(Ljava/util/function/Supplier;)Ljava/util/stream/Collector;","invokestatic",24);}
case 24:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[0]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/game/card/CounterKeywordType","sMap","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterKeywordType","sMap","Ljava/util/Map;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",42);}
case 42:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5789(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CounterKeywordType","keyword","Lforge/game/keyword/KeywordView;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/keyword/KeywordView","original","()Ljava/lang/String;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5790(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CounterKeywordType","keyword","Lforge/game/keyword/KeywordView;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/keyword/KeywordView","title","()Ljava/lang/String;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5791(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CounterKeywordType","keyword","Lforge/game/keyword/KeywordView;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/keyword/KeywordView","title","()Ljava/lang/String;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5792(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5793(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Hexproof:")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?11:9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("Trample:")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?22:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{if(!rt.StaticReady(f,"forge/game/card/CounterKeywordType","keywordCounter","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterKeywordType","keywordCounter","Lcom/google/common/collect/ImmutableList;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"com/google/common/collect/ImmutableList","contains","(Ljava/lang/Object;)Z","invokevirtual",29);}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5794(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","DECAYED","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","DECAYED","Lforge/game/keyword/Keyword;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CounterKeywordType","keyword","Lforge/game/keyword/KeywordView;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/keyword/KeywordView","keyword","()Lforge/game/keyword/Keyword;","invokeinterface",12);}
case 12:{return rt.Call(f,"forge/game/keyword/Keyword","equals","(Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?22:18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/game/card/CounterAiCategory","Negative","Lforge/game/card/CounterAiCategory;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterAiCategory","Negative","Lforge/game/card/CounterAiCategory;"));f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
case 22:{if(!rt.StaticReady(f,"forge/game/card/CounterAiCategory","Positive","Lforge/game/card/CounterAiCategory;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterAiCategory","Positive","Lforge/game/card/CounterAiCategory;"));f.Pc=25;continue;}
case 25:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5795(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CounterKeywordType:5795:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/CounterKeywordType;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5796(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/CounterKeywordType:5796:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/CounterKeywordType;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5797(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CounterKeywordType","keyword","Lforge/game/keyword/KeywordView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5798(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Flying")));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String("First Strike")));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Double Strike")));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Deathtouch")));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("Decayed")));f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("Exalted")));f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("Haste")));f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Hexproof")));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Indestructible")));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("Lifelink")));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("Menace")));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Reach")));f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("Shadow")));f.Pc=32;continue;}
case 32:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("Trample")));f.Pc=37;continue;}
case 37:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{f.Push(JValue.I(2));f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("Vigilance")));f.Pc=42;continue;}
case 42:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=43;continue;}
case 43:{return rt.Call(f,"com/google/common/collect/ImmutableList","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList;","invokestatic",46);}
case 46:{if(!rt.StaticReady(f,"forge/game/card/CounterKeywordType","keywordCounter","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;rt.PutStatic("forge/game/card/CounterKeywordType","keywordCounter","Lcom/google/common/collect/ImmutableList;",f.Pop());f.Pc=49;continue;}
case 49:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",52);}
case 52:{if(!rt.StaticReady(f,"forge/game/card/CounterKeywordType","sMap","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/game/card/CounterKeywordType","sMap","Ljava/util/Map;",f.Pop());f.Pc=55;continue;}
case 55:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
