// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C653{
internal static JClass Build(){var c=new JClass("forge/game/keyword/KeywordCollectionView","java/lang/Object",new string[]{"java/lang/Iterable","java/io/Serializable"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("EMPTY","Lforge/game/keyword/KeywordCollectionView;",true,JValue.Default("Lforge/game/keyword/KeywordCollectionView;"),null));
c.Add(new JField("map","Lcom/google/common/collect/Multimap;",false,JValue.Default("Lcom/google/common/collect/Multimap;"),null));
c.Add(new JMethod(7483,"forge/game/keyword/KeywordCollectionView","<init>","(Ljava/lang/Iterable;)V",1,4,3,new JHandler[]{},M7483));
c.Add(new JMethod(7484,"forge/game/keyword/KeywordCollectionView","contains","(Lforge/game/keyword/Keyword;)Z",1,2,2,new JHandler[]{},M7484));
c.Add(new JMethod(7485,"forge/game/keyword/KeywordCollectionView","isEmpty","()Z",1,1,1,new JHandler[]{},M7485));
c.Add(new JMethod(7486,"forge/game/keyword/KeywordCollectionView","size","()I",1,1,1,new JHandler[]{},M7486));
c.Add(new JMethod(7487,"forge/game/keyword/KeywordCollectionView","getValues","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M7487));
c.Add(new JMethod(7488,"forge/game/keyword/KeywordCollectionView","getValues","(Lforge/game/keyword/Keyword;)Ljava/util/Collection;",1,2,2,new JHandler[]{},M7488));
c.Add(new JMethod(7489,"forge/game/keyword/KeywordCollectionView","iterator","()Ljava/util/Iterator;",1,1,1,new JHandler[]{},M7489));
c.Add(new JMethod(7490,"forge/game/keyword/KeywordCollectionView","equals","(Ljava/lang/Object;)Z",1,3,2,new JHandler[]{},M7490));
c.Add(new JMethod(7491,"forge/game/keyword/KeywordCollectionView","hashCode","()I",1,1,1,new JHandler[]{},M7491));
c.Add(new JMethod(7492,"forge/game/keyword/KeywordCollectionView","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7492));
c.Add(new JMethod(7493,"forge/game/keyword/KeywordCollectionView","<clinit>","()V",8,0,3,new JHandler[]{},M7493));
}

internal static JStep M7483(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/MultimapBuilder","hashKeys","()Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys;","invokestatic",8);}
case 8:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys","linkedHashSetValues","()Lcom/google/common/collect/MultimapBuilder$SetMultimapBuilder;","invokevirtual",11);}
case 11:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$SetMultimapBuilder","build","()Lcom/google/common/collect/SetMultimap;","invokevirtual",14);}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordCollectionView","map","Lcom/google/common/collect/Multimap;",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?63:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[3]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordCollectionView","map","Lcom/google/common/collect/Multimap;"));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/keyword/KeywordView","keyword","()Lforge/game/keyword/Keyword;","invokeinterface",53);}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Pc=24;continue;}
case 63:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7484(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordCollectionView","map","Lcom/google/common/collect/Multimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Multimap","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7485(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordCollectionView","map","Lcom/google/common/collect/Multimap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Multimap","isEmpty","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7486(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordCollectionView","map","Lcom/google/common/collect/Multimap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",14);}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7487(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordCollectionView","map","Lcom/google/common/collect/Multimap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7488(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordCollectionView","map","Lcom/google/common/collect/Multimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7489(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordCollectionView","map","Lcom/google/common/collect/Multimap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7490(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?7:5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/KeywordCollectionView")?1:0));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int==0?39:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordCollectionView","map","Lcom/google/common/collect/Multimap;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordCollectionView","map","Lcom/google/common/collect/Multimap;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"com/google/common/collect/Multimap","equals","(Ljava/lang/Object;)Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?39:35;continue;}
case 35:{f.Push(JValue.I(1));f.Pc=36;continue;}
case 36:{f.Pc=40;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7491(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordCollectionView","map","Lcom/google/common/collect/Multimap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Multimap","hashCode","()I","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7492(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordCollectionView","getValues","()Ljava/util/Collection;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7493(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/keyword/KeywordCollectionView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/keyword/KeywordCollectionView")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",7);}
case 7:{return rt.Call(f,"forge/game/keyword/KeywordCollectionView","<init>","(Ljava/lang/Iterable;)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/game/keyword/KeywordCollectionView","EMPTY","Lforge/game/keyword/KeywordCollectionView;"))return JStep.Continue;rt.PutStatic("forge/game/keyword/KeywordCollectionView","EMPTY","Lforge/game/keyword/KeywordCollectionView;",f.Pop());f.Pc=13;continue;}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
