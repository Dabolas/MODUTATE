// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1088{
internal static JClass Build(){var c=new JClass("forge/item/generation/UnOpenedProduct","java/lang/Object",new string[]{"forge/item/generation/IUnOpenedProduct"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("tpl","Lforge/item/SealedTemplate;",false,JValue.Default("Lforge/item/SealedTemplate;"),null));
c.Add(new JField("sheets","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("excludedNames","Ljava/util/Collection;",false,JValue.Default("Ljava/util/Collection;"),null));
c.Add(new JField("poolLimited","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(11480,"forge/item/generation/UnOpenedProduct","isPoolLimited","()Z",17,1,1,new JHandler[]{},M11480));
c.Add(new JMethod(11481,"forge/item/generation/UnOpenedProduct","setLimitedPool","(Z)V",17,2,2,new JHandler[]{},M11481));
c.Add(new JMethod(11482,"forge/item/generation/UnOpenedProduct","<init>","(Lforge/item/SealedTemplate;)V",1,2,3,new JHandler[]{},M11482));
c.Add(new JMethod(11483,"forge/item/generation/UnOpenedProduct","<init>","(Lforge/item/SealedTemplate;Ljava/util/Collection;)V",1,3,2,new JHandler[]{},M11483));
c.Add(new JMethod(11484,"forge/item/generation/UnOpenedProduct","<init>","(Lforge/item/SealedTemplate;Lforge/util/ItemPool;)V",1,3,3,new JHandler[]{},M11484));
c.Add(new JMethod(11485,"forge/item/generation/UnOpenedProduct","<init>","(Lforge/item/SealedTemplate;Ljava/lang/Iterable;)V",1,3,3,new JHandler[]{},M11485));
c.Add(new JMethod(11486,"forge/item/generation/UnOpenedProduct","<init>","(Lforge/item/SealedTemplate;Ljava/util/function/Predicate;)V",1,3,4,new JHandler[]{},M11486));
c.Add(new JMethod(11487,"forge/item/generation/UnOpenedProduct","prebuildSheets","(Ljava/lang/Iterable;)V",2,4,4,new JHandler[]{},M11487));
c.Add(new JMethod(11488,"forge/item/generation/UnOpenedProduct","get","()Ljava/util/List;",1,1,2,new JHandler[]{},M11488));
c.Add(new JMethod(11489,"forge/item/generation/UnOpenedProduct","getBoosterPack","()Ljava/util/List;",2,6,3,new JHandler[]{},M11489));
c.Add(new JMethod(11490,"forge/item/generation/UnOpenedProduct","get","()Ljava/lang/Object;",4161,1,1,new JHandler[]{},M11490));
}

internal static JStep M11480(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/generation/UnOpenedProduct","poolLimited","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11481(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/generation/UnOpenedProduct","poolLimited","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11482(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/item/generation/UnOpenedProduct","<init>","(Lforge/item/SealedTemplate;Ljava/util/Collection;)V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11483(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/generation/UnOpenedProduct","poolLimited","Z",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/generation/UnOpenedProduct","tpl","Lforge/item/SealedTemplate;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/generation/UnOpenedProduct","sheets","Ljava/util/Map;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/generation/UnOpenedProduct","excludedNames","Ljava/util/Collection;",value);f.Pc=24;continue;}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11484(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/ItemPool","toFlatList","()Ljava/util/List;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/item/generation/UnOpenedProduct","<init>","(Lforge/item/SealedTemplate;Ljava/lang/Iterable;)V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11485(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/generation/UnOpenedProduct","poolLimited","Z",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/generation/UnOpenedProduct","tpl","Lforge/item/SealedTemplate;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/TreeMap","<init>","()V","invokespecial",22);}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/generation/UnOpenedProduct","sheets","Ljava/util/Map;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(null));f.Pc=27;continue;}
case 27:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/generation/UnOpenedProduct","excludedNames","Ljava/util/Collection;",value);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/item/generation/UnOpenedProduct","prebuildSheets","(Ljava/lang/Iterable;)V","invokevirtual",35);}
case 35:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11486(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/card/CardDb","getAllCards","()Ljava/util/Collection;","invokevirtual",11);}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/util/Collection;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",15);}
case 15:{return rt.Call(f,"forge/item/generation/UnOpenedProduct","<init>","(Lforge/item/SealedTemplate;Ljava/lang/Iterable;)V","invokespecial",18);}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11487(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/generation/UnOpenedProduct","tpl","Lforge/item/SealedTemplate;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/item/SealedTemplate","getSlots","()Ljava/util/List;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?63:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/item/generation/UnOpenedProduct","sheets","Ljava/util/Map;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getKey","()Ljava/lang/Object;","invokevirtual",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getKey","()Ljava/lang/Object;","invokevirtual",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/item/generation/BoosterGenerator","makeSheet","(Ljava/lang/String;Ljava/lang/Iterable;)Lforge/card/PrintSheet;","invokestatic",54);}
case 54:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Pc=13;continue;}
case 63:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11488(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/generation/UnOpenedProduct","sheets","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/item/generation/UnOpenedProduct","getBoosterPack","()Ljava/util/List;","invokevirtual",11);}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/item/generation/UnOpenedProduct","tpl","Lforge/item/SealedTemplate;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/item/generation/UnOpenedProduct","excludedNames","Ljava/util/Collection;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/item/generation/BoosterGenerator","getBoosterPack","(Lforge/item/SealedTemplate;Ljava/util/Collection;)Ljava/util/List;","invokestatic",23);}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11489(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/item/generation/UnOpenedProduct","tpl","Lforge/item/SealedTemplate;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/item/SealedTemplate","getSlots","()Ljava/util/List;","invokevirtual",15);}
case 15:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?137:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[3]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/item/generation/UnOpenedProduct","sheets","Ljava/util/Map;"));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",48);}
case 48:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/PrintSheet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{f.Locals[4]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/card/PrintSheet","isEmpty","()Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?93:66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/item/generation/UnOpenedProduct","poolLimited","Z"));f.Pc=70;continue;}
case 70:{f.Pc=f.Pop().Int==0?93:73;continue;}
case 73:{if(!rt.EnsureInitialized(f,"java/lang/IllegalStateException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalStateException")));f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(f.Locals[3]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getKey","()Ljava/lang/Object;","invokevirtual",81);}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{return rt.DynamicCall(f,"forge/item/generation/UnOpenedProduct:11489:84:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",89);}
case 89:{return rt.Call(f,"java/lang/IllegalStateException","<init>","(Ljava/lang/String;)V","invokespecial",92);}
case 92:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[3]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",99);}
case 99:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",105);}
case 105:{f.Push(JValue.I(1));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/card/PrintSheet","random","(IZ)Ljava/util/List;","invokevirtual",109);}
case 109:{f.Locals[5]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(rt.GetField(f.Pop(),"forge/item/generation/UnOpenedProduct","poolLimited","Z"));f.Pc=115;continue;}
case 115:{f.Pc=f.Pop().Int==0?125:118;continue;}
case 118:{f.Push(f.Locals[4]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[5]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/card/PrintSheet","removeAll","(Ljava/lang/Iterable;)V","invokevirtual",125);}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[5]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",133);}
case 133:{f.StackOp("pop");f.Pc=134;continue;}
case 134:{f.Pc=21;continue;}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11490(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/generation/UnOpenedProduct","get","()Ljava/util/List;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
