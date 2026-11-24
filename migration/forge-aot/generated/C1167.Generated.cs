// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1167{
internal static JClass Build(){var c=new JClass("forge/util/collect/FCollection","java/lang/Object",new string[]{"java/util/List","forge/util/collect/FCollectionView","java/lang/Cloneable","java/io/Serializable"},33);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-1664555336364294106L),null));
c.Add(new JField("EMPTY","Lforge/util/collect/FCollection;",true,JValue.Default("Lforge/util/collect/FCollection;"),null));
c.Add(new JField("EMPTY_OBJECT_ARRAY","[Ljava/lang/Object;",true,JValue.Default("[Ljava/lang/Object;"),null));
c.Add(new JField("LAZY_HASH_THRESHOLD","I",true,JValue.I(64),null));
c.Add(new JField("AUTO_HASH_THRESHOLD","I",true,JValue.I(8),null));
c.Add(new JField("MIN_HASH_CAPACITY","I",true,JValue.I(32),null));
c.Add(new JField("TO_STRING_COMPARATOR","Ljava/util/Comparator;",true,JValue.Default("Ljava/util/Comparator;"),null));
c.Add(new JField("list","Ljava/util/ArrayList;",false,JValue.Default("Ljava/util/ArrayList;"),null));
c.Add(new JField("hashTable","[Ljava/lang/Object;",false,JValue.Default("[Ljava/lang/Object;"),null));
c.Add(new JField("hashSize","I",false,JValue.Default("I"),null));
c.Add(new JField("hashMask","I",false,JValue.Default("I"),null));
c.Add(new JField("setView","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("sharedList","Z",false,JValue.Default("Z"),null));
c.Add(new JField("modCount","I",false,JValue.Default("I"),null));
c.Add(new JField("liveIterators","I",false,JValue.Default("I"),null));
c.Add(new JField("contentVersion","I",false,JValue.Default("I"),null));
c.Add(new JMethod(12099,"forge/util/collect/FCollection","<init>","(Ljava/util/ArrayList;Z)V",2,3,2,new JHandler[]{},M12099));
c.Add(new JMethod(12100,"forge/util/collect/FCollection","shareCopy","()Lforge/util/collect/FCollection;",17,1,4,new JHandler[]{},M12100));
c.Add(new JMethod(12101,"forge/util/collect/FCollection","version","()I",17,1,2,new JHandler[]{},M12101));
c.Add(new JMethod(12102,"forge/util/collect/FCollection","ownList","()V",2,1,4,new JHandler[]{},M12102));
c.Add(new JMethod(12103,"forge/util/collect/FCollection","withCapacity","(I)Lforge/util/collect/FCollection;",9,1,3,new JHandler[]{},M12103));
c.Add(new JMethod(12104,"forge/util/collect/FCollection","getEmpty","()Lforge/util/collect/FCollection;",9,0,1,new JHandler[]{},M12104));
c.Add(new JMethod(12105,"forge/util/collect/FCollection","hasElements","(Ljava/lang/Iterable;)Z",9,1,1,new JHandler[]{},M12105));
c.Add(new JMethod(12106,"forge/util/collect/FCollection","hasElement","(Ljava/util/Collection;Ljava/lang/Object;)Z",9,2,2,new JHandler[]{},M12106));
c.Add(new JMethod(12107,"forge/util/collect/FCollection","equals","(Ljava/lang/Object;)Z",1,2,2,new JHandler[]{},M12107));
c.Add(new JMethod(12108,"forge/util/collect/FCollection","hashCode","()I",1,1,1,new JHandler[]{},M12108));
c.Add(new JMethod(12109,"forge/util/collect/FCollection","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M12109));
c.Add(new JMethod(12110,"forge/util/collect/FCollection","clone","()Lforge/util/collect/FCollection;",17,1,3,new JHandler[]{},M12110));
c.Add(new JMethod(12111,"forge/util/collect/FCollection","getFirst","()Ljava/lang/Object;",1,1,2,new JHandler[]{},M12111));
c.Add(new JMethod(12112,"forge/util/collect/FCollection","getLast","()Ljava/lang/Object;",1,1,3,new JHandler[]{},M12112));
c.Add(new JMethod(12113,"forge/util/collect/FCollection","size","()I",1,1,1,new JHandler[]{},M12113));
c.Add(new JMethod(12114,"forge/util/collect/FCollection","isEmpty","()Z",1,1,1,new JHandler[]{},M12114));
c.Add(new JMethod(12115,"forge/util/collect/FCollection","asSet","()Ljava/util/Set;",1,1,4,new JHandler[]{},M12115));
c.Add(new JMethod(12116,"forge/util/collect/FCollection","contains","(Ljava/lang/Object;)Z",1,2,2,new JHandler[]{},M12116));
c.Add(new JMethod(12117,"forge/util/collect/FCollection","get","(Ljava/lang/Object;)Ljava/lang/Object;",1,5,2,new JHandler[]{},M12117));
c.Add(new JMethod(12118,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;",1,1,3,new JHandler[]{},M12118));
c.Add(new JMethod(12119,"forge/util/collect/FCollection","toArray","()[Ljava/lang/Object;",1,1,1,new JHandler[]{},M12119));
c.Add(new JMethod(12120,"forge/util/collect/FCollection","toArray","([Ljava/lang/Object;)[Ljava/lang/Object;",1,2,2,new JHandler[]{},M12120));
c.Add(new JMethod(12121,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z",1,2,3,new JHandler[]{},M12121));
c.Add(new JMethod(12122,"forge/util/collect/FCollection","remove","(Ljava/lang/Object;)Z",1,5,3,new JHandler[]{},M12122));
c.Add(new JMethod(12123,"forge/util/collect/FCollection","removeIf","(Ljava/util/function/Predicate;)Z",1,7,8,new JHandler[]{},M12123));
c.Add(new JMethod(12124,"forge/util/collect/FCollection","containsAll","(Ljava/util/Collection;)Z",1,4,3,new JHandler[]{},M12124));
c.Add(new JMethod(12125,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z",1,3,3,new JHandler[]{},M12125));
c.Add(new JMethod(12126,"forge/util/collect/FCollection","addAllUnique","(Ljava/util/Collection;)Z",1,6,4,new JHandler[]{},M12126));
c.Add(new JMethod(12127,"forge/util/collect/FCollection","appendUnchecked","(Ljava/lang/Object;)Z",2,2,4,new JHandler[]{},M12127));
c.Add(new JMethod(12128,"forge/util/collect/FCollection","addAllInternal","(Ljava/util/Collection;)Z",2,7,2,new JHandler[]{},M12128));
c.Add(new JMethod(12129,"forge/util/collect/FCollection","addIfAbsent","(Ljava/lang/Object;)Z",2,2,2,new JHandler[]{},M12129));
c.Add(new JMethod(12130,"forge/util/collect/FCollection","addAll","(Ljava/lang/Iterable;)Z",1,5,2,new JHandler[]{},M12130));
c.Add(new JMethod(12131,"forge/util/collect/FCollection","addAll","([Ljava/lang/Object;)Z",1,8,3,new JHandler[]{},M12131));
c.Add(new JMethod(12132,"forge/util/collect/FCollection","addAll","(ILjava/util/Collection;)Z",1,7,5,new JHandler[]{},M12132));
c.Add(new JMethod(12133,"forge/util/collect/FCollection","removeAll","(Ljava/util/Collection;)Z",1,7,3,new JHandler[]{},M12133));
c.Add(new JMethod(12134,"forge/util/collect/FCollection","removeAll","(Ljava/lang/Iterable;)Z",1,5,3,new JHandler[]{},M12134));
c.Add(new JMethod(12135,"forge/util/collect/FCollection","retainAll","(Ljava/util/Collection;)Z",1,7,3,new JHandler[]{},M12135));
c.Add(new JMethod(12136,"forge/util/collect/FCollection","clear","()V",1,1,3,new JHandler[]{},M12136));
c.Add(new JMethod(12137,"forge/util/collect/FCollection","get","(I)Ljava/lang/Object;",1,2,2,new JHandler[]{},M12137));
c.Add(new JMethod(12138,"forge/util/collect/FCollection","set","(ILjava/lang/Object;)Ljava/lang/Object;",1,4,3,new JHandler[]{},M12138));
c.Add(new JMethod(12139,"forge/util/collect/FCollection","replace","(ILjava/lang/Object;)Ljava/lang/Object;",1,4,3,new JHandler[]{},M12139));
c.Add(new JMethod(12140,"forge/util/collect/FCollection","add","(ILjava/lang/Object;)V",1,3,3,new JHandler[]{},M12140));
c.Add(new JMethod(12141,"forge/util/collect/FCollection","insert","(ILjava/lang/Object;)Z",2,7,4,new JHandler[]{},M12141));
c.Add(new JMethod(12142,"forge/util/collect/FCollection","remove","(I)Ljava/lang/Object;",1,3,3,new JHandler[]{},M12142));
c.Add(new JMethod(12143,"forge/util/collect/FCollection","indexOf","(Ljava/lang/Object;)I",1,2,2,new JHandler[]{},M12143));
c.Add(new JMethod(12144,"forge/util/collect/FCollection","lastIndexOf","(Ljava/lang/Object;)I",1,2,2,new JHandler[]{},M12144));
c.Add(new JMethod(12145,"forge/util/collect/FCollection","listIterator","()Ljava/util/ListIterator;",1,1,3,new JHandler[]{},M12145));
c.Add(new JMethod(12146,"forge/util/collect/FCollection","listIterator","(I)Ljava/util/ListIterator;",1,2,3,new JHandler[]{},M12146));
}

private static void Add1(JClass c){
c.Add(new JMethod(12147,"forge/util/collect/FCollection","threadSafeIterable","()Ljava/lang/Iterable;",1,1,3,new JHandler[]{},M12147));
c.Add(new JMethod(12148,"forge/util/collect/FCollection","subList","(II)Ljava/util/List;",1,3,5,new JHandler[]{},M12148));
c.Add(new JMethod(12149,"forge/util/collect/FCollection","sort","()V",1,2,2,new JHandler[]{},M12149));
c.Add(new JMethod(12150,"forge/util/collect/FCollection","sort","(Ljava/util/Comparator;)V",1,3,3,new JHandler[]{new JHandler(14,22,25,"java/lang/Exception")},M12150));
c.Add(new JMethod(12151,"forge/util/collect/FCollection","stream","()Ljava/util/stream/Stream;",1,1,1,new JHandler[]{},M12151));
c.Add(new JMethod(12152,"forge/util/collect/FCollection","anyMatch","(Ljava/util/function/Predicate;)Z",1,3,3,new JHandler[]{},M12152));
c.Add(new JMethod(12153,"forge/util/collect/FCollection","allMatch","(Ljava/util/function/Predicate;)Z",1,3,3,new JHandler[]{},M12153));
c.Add(new JMethod(12154,"forge/util/collect/FCollection","spreadHash","(Ljava/lang/Object;)I",10,2,3,new JHandler[]{},M12154));
c.Add(new JMethod(12155,"forge/util/collect/FCollection","nextPowerOfTwo","(I)I",10,2,2,new JHandler[]{},M12155));
c.Add(new JMethod(12156,"forge/util/collect/FCollection","buildHashTable","(I)V",2,8,4,new JHandler[]{},M12156));
c.Add(new JMethod(12157,"forge/util/collect/FCollection","rebuildHashTable","()V",2,5,3,new JHandler[]{},M12157));
c.Add(new JMethod(12158,"forge/util/collect/FCollection","clearHashTable","()V",2,1,2,new JHandler[]{},M12158));
c.Add(new JMethod(12159,"forge/util/collect/FCollection","hashContains","(Ljava/lang/Object;)Z",2,2,2,new JHandler[]{},M12159));
c.Add(new JMethod(12160,"forge/util/collect/FCollection","findHashIndex","(Ljava/lang/Object;)I",2,6,2,new JHandler[]{},M12160));
c.Add(new JMethod(12161,"forge/util/collect/FCollection","addToHashTable","(Ljava/lang/Object;)Z",2,2,4,new JHandler[]{},M12161));
c.Add(new JMethod(12162,"forge/util/collect/FCollection","insertHashNoResize","(Ljava/lang/Object;[Ljava/lang/Object;)V",2,5,3,new JHandler[]{},M12162));
c.Add(new JMethod(12163,"forge/util/collect/FCollection","resizeHashTable","(I)V",2,7,3,new JHandler[]{},M12163));
c.Add(new JMethod(12164,"forge/util/collect/FCollection","removeFromHashTable","(Ljava/lang/Object;)Z",2,3,2,new JHandler[]{},M12164));
c.Add(new JMethod(12165,"forge/util/collect/FCollection","removeHashEntryAt","(I)V",2,5,3,new JHandler[]{},M12165));
c.Add(new JMethod(12166,"forge/util/collect/FCollection","<init>","()V",1,1,3,new JHandler[]{},M12166));
c.Add(new JMethod(12167,"forge/util/collect/FCollection","<init>","(I)V",4,2,4,new JHandler[]{},M12167));
c.Add(new JMethod(12168,"forge/util/collect/FCollection","<init>","(Ljava/lang/Object;)V",1,2,4,new JHandler[]{},M12168));
c.Add(new JMethod(12169,"forge/util/collect/FCollection","<init>","([Ljava/lang/Object;)V",1,2,4,new JHandler[]{},M12169));
c.Add(new JMethod(12170,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V",1,3,4,new JHandler[]{},M12170));
c.Add(new JMethod(12171,"forge/util/collect/FCollection","<init>","(Lforge/util/collect/FCollectionReader;)V",1,2,3,new JHandler[]{},M12171));
c.Add(new JMethod(12172,"forge/util/collect/FCollection","ensureCapacity","(I)V",1,2,2,new JHandler[]{},M12172));
c.Add(new JMethod(12173,"forge/util/collect/FCollection","clone","()Ljava/lang/Object;",4161,1,1,new JHandler[]{},M12173));
c.Add(new JMethod(12174,"forge/util/collect/FCollection","<clinit>","()V",8,0,2,new JHandler[]{},M12174));
}

internal static JStep M12099(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","sharedList","Z",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12100(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","sharedList","Z",value);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/util/ArrayList;Z)V","invokespecial",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12101(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","contentVersion","I"));f.Pc=8;continue;}
case 8:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12102(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","sharedList","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","liveIterators","I"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int<=0?39:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",26);}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","sharedList","Z",value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","liveIterators","I",value);f.Pc=39;continue;}
case 39:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12103(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(I)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12104(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/collect/FCollection","EMPTY","Lforge/util/collect/FCollection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/collect/FCollection","EMPTY","Lforge/util/collect/FCollection;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12105(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/Collection")?1:0));f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Int==0?31:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int!=0?29:25;continue;}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{f.Pc=30;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",37);}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12106(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?18:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Collection","contains","(Ljava/lang/Object;)Z","invokeinterface",11);}
case 11:{f.Pc=f.Pop().Int==0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12107(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?23:5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/List")?1:0));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Int==0?27:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/ArrayList","equals","(Ljava/lang/Object;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?27:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Pc=28;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12108(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","hashCode","()I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12109(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12110(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12111(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?12:10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",20);}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12112(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?12:10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",23);}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",28);}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12113(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12114(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","isEmpty","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12115(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","setView","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?19:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection$SetView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection$SetView")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/util/collect/FCollection$SetView","<init>","(Lforge/util/collect/FCollection;)V","invokespecial",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","setView","Ljava/util/Set;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","setView","Ljava/util/Set;"));f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12116(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference!=null?36:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",20);}
case 20:{f.Push(JValue.I(64));f.Pc=22;continue;}
case 22:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?36:25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/util/collect/FCollection","buildHashTable","(I)V","invokevirtual",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Reference==null?57:43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/util/collect/FCollection","findHashIndex","(Ljava/lang/Object;)I","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int<0?55:51;continue;}
case 51:{f.Push(JValue.I(1));f.Pc=52;continue;}
case 52:{f.Pc=56;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/ArrayList","contains","(Ljava/lang/Object;)Z","invokevirtual",65);}
case 65:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12117(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference!=null?36:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",20);}
case 20:{f.Push(JValue.I(64));f.Pc=22;continue;}
case 22:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?36:25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/util/collect/FCollection","buildHashTable","(I)V","invokevirtual",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Reference==null?62:43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/util/collect/FCollection","findHashIndex","(Ljava/lang/Object;)I","invokevirtual",48);}
case 48:{f.Locals[2]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Pc=f.Pop().Int<0?60:53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=59;continue;}
case 59:{return JStep.Return(f.Pop());}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{return JStep.Return(f.Pop());}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",69);}
case 69:{f.Locals[2]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(JValue.I(0));f.Pc=71;continue;}
case 71:{f.Locals[3]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?110:77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=81;continue;}
case 81:{f.Push(f.Locals[3]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",85);}
case 85:{f.Locals[4]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{f.Pc=f.Pop().Reference==null?104:92;continue;}
case 92:{f.Push(f.Locals[4]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?104:101;continue;}
case 101:{f.Push(f.Locals[4]);f.Pc=103;continue;}
case 103:{return JStep.Return(f.Pop());}
case 104:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=107;continue;}
case 107:{f.Pc=72;continue;}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12118(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?14:10;continue;}
case 10:{return rt.Call(f,"java/util/Collections","emptyIterator","()Ljava/util/Iterator;","invokestatic",13);}
case 13:{return JStep.Return(f.Pop());}
case 14:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection$Itr"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection$Itr")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/util/collect/FCollection$Itr","<init>","(Lforge/util/collect/FCollection;)V","invokespecial",22);}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12119(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","toArray","()[Ljava/lang/Object;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12120(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/ArrayList","toArray","([Ljava/lang/Object;)[Ljava/lang/Object;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12121(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Reference!=null?74:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/ArrayList","contains","(Ljava/lang/Object;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?30:28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",38);}
case 38:{f.StackOp("pop");f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.StackOp("dup");f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=44;continue;}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=46;continue;}
case 46:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",56);}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?72:61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",69);}
case 69:{return rt.Call(f,"forge/util/collect/FCollection","buildHashTable","(I)V","invokevirtual",72);}
case 72:{f.Push(JValue.I(1));f.Pc=73;continue;}
case 73:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/util/collect/FCollection","addToHashTable","(Ljava/lang/Object;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int!=0?84:82;continue;}
case 82:{f.Push(JValue.I(0));f.Pc=83;continue;}
case 83:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",92);}
case 92:{f.StackOp("pop");f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.StackOp("dup");f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=98;continue;}
case 98:{f.Push(JValue.I(1));f.Pc=99;continue;}
case 99:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=100;continue;}
case 100:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=103;continue;}
case 103:{f.Push(JValue.I(1));f.Pc=104;continue;}
case 104:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12122(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Reference!=null?53:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/ArrayList","indexOf","(Ljava/lang/Object;)I","invokevirtual",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Int>=0?32:30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/ArrayList","remove","(I)Ljava/lang/Object;","invokevirtual",40);}
case 40:{f.StackOp("pop");f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=46;continue;}
case 46:{f.Push(JValue.I(1));f.Pc=47;continue;}
case 47:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=48;continue;}
case 48:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=51;continue;}
case 51:{f.Push(JValue.I(1));f.Pc=52;continue;}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/util/collect/FCollection","findHashIndex","(Ljava/lang/Object;)I","invokevirtual",58);}
case 58:{f.Locals[2]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{f.Pc=f.Pop().Int>=0?65:63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=71;continue;}
case 71:{f.Locals[3]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/util/collect/FCollection","removeHashEntryAt","(I)V","invokevirtual",77);}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.StackOp("dup");f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=82;continue;}
case 82:{f.Push(JValue.I(1));f.Pc=83;continue;}
case 83:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=84;continue;}
case 84:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=91;continue;}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/ArrayList","indexOf","(Ljava/lang/Object;)I","invokevirtual",95);}
case 95:{f.Locals[4]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{f.Pc=f.Pop().Int<0?112:102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=106;continue;}
case 106:{f.Push(f.Locals[4]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/ArrayList","remove","(I)Ljava/lang/Object;","invokevirtual",111);}
case 111:{f.StackOp("pop");f.Pc=112;continue;}
case 112:{f.Push(JValue.I(1));f.Pc=113;continue;}
case 113:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12123(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?14:4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"java/lang/NullPointerException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/NullPointerException")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("filter")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/NullPointerException","<init>","(Ljava/lang/String;)V","invokespecial",13);}
case 13:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Int!=0?28:26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 28:{f.Push(JValue.R(null));f.Pc=29;continue;}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(JValue.I(-1));f.Pc=31;continue;}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{f.Locals[5]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[5]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?102:42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",52);}
case 52:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",57);}
case 57:{f.Pc=f.Pop().Int==0?96:60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Reference!=null?79:64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(JValue.I(1));f.Pc=66;continue;}
case 66:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=67;continue;}
case 67:{f.Push(JValue.I(6));f.Pc=69;continue;}
case 69:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishr",a,b));f.Pc=70;continue;}
case 70:{f.Push(JValue.I(1));f.Pc=71;continue;}
case 71:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.NewArray("J",f.Pop().Int)));f.Pc=74;continue;}
case 74:{f.Locals[3]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[5]);f.Pc=77;continue;}
case 77:{f.Locals[4]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{f.Push(JValue.I(6));f.Pc=84;continue;}
case 84:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishr",a,b));f.Pc=85;continue;}
case 85:{f.StackOp("dup2");f.Pc=86;continue;}
case 86:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=87;continue;}
case 87:{f.Push(JValue.L(1));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[5]);f.Pc=90;continue;}
case 90:{f.Push(JValue.I(63));f.Pc=92;continue;}
case 92:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=93;continue;}
case 93:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lshl",a,b));f.Pc=94;continue;}
case 94:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lor",a,b));f.Pc=95;continue;}
case 95:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=96;continue;}
case 96:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=99;continue;}
case 99:{f.Pc=36;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{f.Pc=f.Pop().Reference!=null?108:106;continue;}
case 106:{f.Push(JValue.I(0));f.Pc=107;continue;}
case 107:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",112);}
case 112:{f.Push(f.Locals[4]);f.Pc=114;continue;}
case 114:{f.Locals[5]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[4]);f.Pc=118;continue;}
case 118:{f.Push(JValue.I(1));f.Pc=119;continue;}
case 119:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=120;continue;}
case 120:{f.Locals[6]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[6]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[2]);f.Pc=125;continue;}
case 125:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?176:128;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[6]);f.Pc=131;continue;}
case 131:{f.Push(JValue.I(6));f.Pc=133;continue;}
case 133:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishr",a,b));f.Pc=134;continue;}
case 134:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=135;continue;}
case 135:{f.Push(JValue.L(1));f.Pc=136;continue;}
case 136:{f.Push(f.Locals[6]);f.Pc=138;continue;}
case 138:{f.Push(JValue.I(63));f.Pc=140;continue;}
case 140:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=141;continue;}
case 141:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lshl",a,b));f.Pc=142;continue;}
case 142:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"land",a,b));f.Pc=143;continue;}
case 143:{f.Push(JValue.L(0));f.Pc=144;continue;}
case 144:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=145;continue;}
case 145:{f.Pc=f.Pop().Int!=0?170:148;continue;}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=152;continue;}
case 152:{f.Push(f.Locals[5]);f.Pc=154;continue;}
case 154:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=157;continue;}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=161;continue;}
case 161:{f.Push(f.Locals[6]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",166);}
case 166:{return rt.Call(f,"java/util/ArrayList","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokevirtual",169);}
case 169:{f.StackOp("pop");f.Pc=170;continue;}
case 170:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=173;continue;}
case 173:{f.Pc=122;continue;}
case 176:{f.Push(f.Locals[2]);f.Pc=177;continue;}
case 177:{f.Push(JValue.I(1));f.Pc=178;continue;}
case 178:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=179;continue;}
case 179:{f.Locals[6]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[6]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[5]);f.Pc=185;continue;}
case 185:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?204:188;continue;}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=192;continue;}
case 192:{f.Push(f.Locals[6]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/util/ArrayList","remove","(I)Ljava/lang/Object;","invokevirtual",197);}
case 197:{f.StackOp("pop");f.Pc=198;continue;}
case 198:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(-1)));f.Pc=201;continue;}
case 201:{f.Pc=181;continue;}
case 204:{f.Push(f.Locals[0]);f.Pc=205;continue;}
case 205:{f.StackOp("dup");f.Pc=206;continue;}
case 206:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=209;continue;}
case 209:{f.Push(JValue.I(1));f.Pc=210;continue;}
case 210:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=211;continue;}
case 211:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[0]);f.Pc=215;continue;}
case 215:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=218;continue;}
case 218:{f.Pc=f.Pop().Reference==null?225:221;continue;}
case 221:{f.Push(f.Locals[0]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/util/collect/FCollection","rebuildHashTable","()V","invokevirtual",225);}
case 225:{f.Push(JValue.I(1));f.Pc=226;continue;}
case 226:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12124(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?14:4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"java/lang/NullPointerException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/NullPointerException")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("collection")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/NullPointerException","<init>","(Ljava/lang/String;)V","invokespecial",13);}
case 13:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?25:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?32:30;continue;}
case 30:{f.Push(JValue.I(1));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/util/collect/FCollection")?1:0));f.Pc=36;continue;}
case 36:{f.Pc=f.Pop().Int!=0?53:39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/RandomAccess")?1:0));f.Pc=43;continue;}
case 43:{f.Pc=f.Pop().Int==0?94:46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/List")?1:0));f.Pc=50;continue;}
case 50:{f.Pc=f.Pop().Int==0?94:53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{f.Locals[2]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(JValue.I(0));f.Pc=59;continue;}
case 59:{f.Locals[3]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",67);}
case 67:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?92:70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",78);}
case 78:{return rt.Call(f,"forge/util/collect/FCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int!=0?86:84;continue;}
case 84:{f.Push(JValue.I(0));f.Pc=85;continue;}
case 85:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 86:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=89;continue;}
case 89:{f.Pc=60;continue;}
case 92:{f.Push(JValue.I(1));f.Pc=93;continue;}
case 93:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",100);}
case 100:{f.Locals[2]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",107);}
case 107:{f.Pc=f.Pop().Int==0?130:110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",116);}
case 116:{f.Locals[3]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/util/collect/FCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",122);}
case 122:{f.Pc=f.Pop().Int!=0?127:125;continue;}
case 125:{f.Push(JValue.I(0));f.Pc=126;continue;}
case 126:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 127:{f.Pc=101;continue;}
case 130:{f.Push(JValue.I(1));f.Pc=131;continue;}
case 131:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12125(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/collect/FCollection","addAllInternal","(Ljava/util/Collection;)Z","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Int==0?20:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12126(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?18:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int!=0?18:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?20:18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",24);}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",35);}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",41);}
case 41:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/ArrayList","ensureCapacity","(I)V","invokevirtual",45);}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{f.Locals[2]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/util/collect/FCollection")?1:0));f.Pc=51;continue;}
case 51:{f.Pc=f.Pop().Int!=0?68:54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/RandomAccess")?1:0));f.Pc=58;continue;}
case 58:{f.Pc=f.Pop().Int==0?115:61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/List")?1:0));f.Pc=65;continue;}
case 65:{f.Pc=f.Pop().Int==0?115:68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=72;continue;}
case 72:{f.Locals[3]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(JValue.I(0));f.Pc=74;continue;}
case 74:{f.Locals[4]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",82);}
case 82:{f.Locals[5]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[4]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[5]);f.Pc=88;continue;}
case 88:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?112:91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[4]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",101);}
case 101:{return rt.Call(f,"forge/util/collect/FCollection","appendUnchecked","(Ljava/lang/Object;)Z","invokevirtual",104);}
case 104:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=105;continue;}
case 105:{f.Locals[2]=f.Pop();f.Pc=106;continue;}
case 106:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=109;continue;}
case 109:{f.Pc=84;continue;}
case 112:{f.Pc=151;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",121);}
case 121:{f.Locals[3]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",128);}
case 128:{f.Pc=f.Pop().Int==0?151:131;continue;}
case 131:{f.Push(f.Locals[3]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",137);}
case 137:{f.Locals[4]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[0]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[4]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/util/collect/FCollection","appendUnchecked","(Ljava/lang/Object;)Z","invokevirtual",146);}
case 146:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=147;continue;}
case 147:{f.Locals[2]=f.Pop();f.Pc=148;continue;}
case 148:{f.Pc=122;continue;}
case 151:{f.Push(f.Locals[2]);f.Pc=152;continue;}
case 152:{f.Pc=f.Pop().Int==0?165:155;continue;}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{f.StackOp("dup");f.Pc=157;continue;}
case 157:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=160;continue;}
case 160:{f.Push(JValue.I(1));f.Pc=161;continue;}
case 161:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=162;continue;}
case 162:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[2]);f.Pc=166;continue;}
case 166:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12127(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Reference==null?64:22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashSize","I"));f.Pc=26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=37;continue;}
case 37:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=38;continue;}
case 38:{f.Push(JValue.I(2));f.Pc=39;continue;}
case 39:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iushr",a,b));f.Pc=40;continue;}
case 40:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=41;continue;}
case 41:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?55:44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=49;continue;}
case 49:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/util/collect/FCollection","resizeHashTable","(I)V","invokevirtual",55);}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/util/collect/FCollection","insertHashNoResize","(Ljava/lang/Object;[Ljava/lang/Object;)V","invokevirtual",64);}
case 64:{f.Push(JValue.I(1));f.Pc=65;continue;}
case 65:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12128(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?13:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?15:13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",26);}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",32);}
case 32:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=33;continue;}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/ArrayList","ensureCapacity","(I)V","invokevirtual",42);}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/util/collect/FCollection")?1:0));f.Pc=46;continue;}
case 46:{f.Pc=f.Pop().Int!=0?63:49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/RandomAccess")?1:0));f.Pc=53;continue;}
case 53:{f.Pc=f.Pop().Int==0?214:56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/List")?1:0));f.Pc=60;continue;}
case 60:{f.Pc=f.Pop().Int==0?214:63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=67;continue;}
case 67:{f.Locals[3]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{f.Locals[4]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/util/collect/FCollection")?1:0));f.Pc=75;continue;}
case 75:{f.Pc=f.Pop().Int==0?146:78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/ArrayList","isEmpty","()Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?146:88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=92;continue;}
case 92:{f.Pc=f.Pop().Reference!=null?146:95;continue;}
case 95:{f.Push(JValue.I(0));f.Pc=96;continue;}
case 96:{f.Locals[5]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[5]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[3]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",106);}
case 106:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?143:109;continue;}
case 109:{f.Push(f.Locals[3]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[5]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",117);}
case 117:{f.Locals[6]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[6]);f.Pc=121;continue;}
case 121:{f.Pc=f.Pop().Reference==null?137:124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=128;continue;}
case 128:{f.Push(f.Locals[6]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",133);}
case 133:{f.StackOp("pop");f.Pc=134;continue;}
case 134:{f.Push(JValue.I(1));f.Pc=135;continue;}
case 135:{f.Locals[4]=f.Pop();f.Pc=137;continue;}
case 137:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=140;continue;}
case 140:{f.Pc=98;continue;}
case 143:{f.Push(f.Locals[4]);f.Pc=145;continue;}
case 145:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=150;continue;}
case 150:{f.Pc=f.Pop().Reference!=null?164:153;continue;}
case 153:{f.Push(f.Locals[2]);f.Pc=154;continue;}
case 154:{f.Push(JValue.I(8));f.Pc=156;continue;}
case 156:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?164:159;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[2]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/util/collect/FCollection","buildHashTable","(I)V","invokevirtual",164);}
case 164:{f.Push(JValue.I(0));f.Pc=165;continue;}
case 165:{f.Locals[5]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[5]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[3]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",175);}
case 175:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?211:178;continue;}
case 178:{f.Push(f.Locals[3]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[5]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",186);}
case 186:{f.Locals[6]=f.Pop();f.Pc=188;continue;}
case 188:{f.Push(f.Locals[6]);f.Pc=190;continue;}
case 190:{f.Pc=f.Pop().Reference==null?205:193;continue;}
case 193:{f.Push(f.Locals[0]);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[6]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/util/collect/FCollection","addIfAbsent","(Ljava/lang/Object;)Z","invokevirtual",199);}
case 199:{f.Pc=f.Pop().Int==0?205:202;continue;}
case 202:{f.Push(JValue.I(1));f.Pc=203;continue;}
case 203:{f.Locals[4]=f.Pop();f.Pc=205;continue;}
case 205:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=208;continue;}
case 208:{f.Pc=167;continue;}
case 211:{f.Push(f.Locals[4]);f.Pc=213;continue;}
case 213:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 214:{f.Push(f.Locals[0]);f.Pc=215;continue;}
case 215:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=218;continue;}
case 218:{f.Pc=f.Pop().Reference!=null?232:221;continue;}
case 221:{f.Push(f.Locals[2]);f.Pc=222;continue;}
case 222:{f.Push(JValue.I(8));f.Pc=224;continue;}
case 224:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?232:227;continue;}
case 227:{f.Push(f.Locals[0]);f.Pc=228;continue;}
case 228:{f.Push(f.Locals[2]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/util/collect/FCollection","buildHashTable","(I)V","invokevirtual",232);}
case 232:{f.Push(JValue.I(0));f.Pc=233;continue;}
case 233:{f.Locals[3]=f.Pop();f.Pc=234;continue;}
case 234:{f.Push(f.Locals[1]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",240);}
case 240:{f.Locals[4]=f.Pop();f.Pc=242;continue;}
case 242:{f.Push(f.Locals[4]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",249);}
case 249:{f.Pc=f.Pop().Int==0?280:252;continue;}
case 252:{f.Push(f.Locals[4]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",259);}
case 259:{f.Locals[5]=f.Pop();f.Pc=261;continue;}
case 261:{f.Push(f.Locals[5]);f.Pc=263;continue;}
case 263:{f.Pc=f.Pop().Reference==null?277:266;continue;}
case 266:{f.Push(f.Locals[0]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[5]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/util/collect/FCollection","addIfAbsent","(Ljava/lang/Object;)Z","invokevirtual",272);}
case 272:{f.Pc=f.Pop().Int==0?277:275;continue;}
case 275:{f.Push(JValue.I(1));f.Pc=276;continue;}
case 276:{f.Locals[3]=f.Pop();f.Pc=277;continue;}
case 277:{f.Pc=242;continue;}
case 280:{f.Push(f.Locals[3]);f.Pc=281;continue;}
case 281:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12129(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?28:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/collect/FCollection","addToHashTable","(Ljava/lang/Object;)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?26:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/ArrayList","contains","(Ljava/lang/Object;)Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int!=0?50:39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12130(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/Collection")?1:0));f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Int==0?24:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",23);}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",32);}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",39);}
case 39:{f.Pc=f.Pop().Int==0?64:42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",48);}
case 48:{f.Locals[4]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?61:59;continue;}
case 59:{f.Push(JValue.I(1));f.Pc=60;continue;}
case 60:{f.Locals[2]=f.Pop();f.Pc=61;continue;}
case 61:{f.Pc=33;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12131(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?9:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Int!=0?11:9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",22);}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=24;continue;}
case 24:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=25;continue;}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/ArrayList","ensureCapacity","(I)V","invokevirtual",34);}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=38;continue;}
case 38:{f.Pc=f.Pop().Reference!=null?52:41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(8));f.Pc=44;continue;}
case 44:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?52:47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/util/collect/FCollection","buildHashTable","(I)V","invokevirtual",52);}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{f.Locals[3]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Locals[4]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=60;continue;}
case 60:{f.Locals[5]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{f.Locals[6]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[6]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[5]);f.Pc=69;continue;}
case 69:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?148:72;continue;}
case 72:{f.Push(f.Locals[4]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=77;continue;}
case 77:{f.Locals[7]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[7]);f.Pc=81;continue;}
case 81:{f.Pc=f.Pop().Reference!=null?87:84;continue;}
case 84:{f.Pc=142;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=91;continue;}
case 91:{f.Pc=f.Pop().Reference==null?118:94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/util/collect/FCollection","addToHashTable","(Ljava/lang/Object;)Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int==0?142:103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=107;continue;}
case 107:{f.Push(f.Locals[7]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",112);}
case 112:{f.StackOp("pop");f.Pc=113;continue;}
case 113:{f.Push(JValue.I(1));f.Pc=114;continue;}
case 114:{f.Locals[3]=f.Pop();f.Pc=115;continue;}
case 115:{f.Pc=142;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=122;continue;}
case 122:{f.Push(f.Locals[7]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/ArrayList","contains","(Ljava/lang/Object;)Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int!=0?142:130;continue;}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=134;continue;}
case 134:{f.Push(f.Locals[7]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",139);}
case 139:{f.StackOp("pop");f.Pc=140;continue;}
case 140:{f.Push(JValue.I(1));f.Pc=141;continue;}
case 141:{f.Locals[3]=f.Pop();f.Pc=142;continue;}
case 142:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=145;continue;}
case 145:{f.Pc=65;continue;}
case 148:{f.Push(f.Locals[3]);f.Pc=149;continue;}
case 149:{f.Pc=f.Pop().Int==0?162:152;continue;}
case 152:{f.Push(f.Locals[0]);f.Pc=153;continue;}
case 153:{f.StackOp("dup");f.Pc=154;continue;}
case 154:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=157;continue;}
case 157:{f.Push(JValue.I(1));f.Pc=158;continue;}
case 158:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=159;continue;}
case 159:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[3]);f.Pc=163;continue;}
case 163:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12132(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?13:4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?15:13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Int<0?30:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",27);}
case 27:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?51:30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"java/lang/IndexOutOfBoundsException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IndexOutOfBoundsException")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",42);}
case 42:{return rt.DynamicCall(f,"forge/util/collect/FCollection:12132:42:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(II)Ljava/lang/String;",47);}
case 47:{return rt.Call(f,"java/lang/IndexOutOfBoundsException","<init>","(Ljava/lang/String;)V","invokespecial",50);}
case 50:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/List")?1:0));f.Pc=55;continue;}
case 55:{f.Pc=f.Pop().Int==0?108:58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=62;continue;}
case 62:{f.Locals[3]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{f.Locals[4]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",72);}
case 72:{f.Push(JValue.I(1));f.Pc=73;continue;}
case 73:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=74;continue;}
case 74:{f.Locals[5]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{f.Pc=f.Pop().Int<0?105:81;continue;}
case 81:{f.Push(f.Locals[4]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[5]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",93);}
case 93:{return rt.Call(f,"forge/util/collect/FCollection","insert","(ILjava/lang/Object;)Z","invokevirtual",96);}
case 96:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=97;continue;}
case 97:{f.Locals[4]=f.Pop();f.Pc=99;continue;}
case 99:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(-1)));f.Pc=102;continue;}
case 102:{f.Pc=76;continue;}
case 105:{f.Push(f.Locals[4]);f.Pc=107;continue;}
case 107:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 108:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",118);}
case 118:{return rt.Call(f,"java/util/ArrayList","<init>","(I)V","invokespecial",121);}
case 121:{f.Locals[3]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[2]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",128);}
case 128:{f.Locals[4]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[4]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",137);}
case 137:{f.Pc=f.Pop().Int==0?163:140;continue;}
case 140:{f.Push(f.Locals[4]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",147);}
case 147:{f.Locals[5]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[5]);f.Pc=151;continue;}
case 151:{f.Locals[6]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[3]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[6]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",159);}
case 159:{f.StackOp("pop");f.Pc=160;continue;}
case 160:{f.Pc=130;continue;}
case 163:{f.Push(JValue.I(0));f.Pc=164;continue;}
case 164:{f.Locals[4]=f.Pop();f.Pc=166;continue;}
case 166:{f.Push(f.Locals[3]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",170);}
case 170:{f.Push(JValue.I(1));f.Pc=171;continue;}
case 171:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=172;continue;}
case 172:{f.Locals[5]=f.Pop();f.Pc=174;continue;}
case 174:{f.Push(f.Locals[5]);f.Pc=176;continue;}
case 176:{f.Pc=f.Pop().Int<0?201:179;continue;}
case 179:{f.Push(f.Locals[4]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[0]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[3]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[5]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",189);}
case 189:{return rt.Call(f,"forge/util/collect/FCollection","insert","(ILjava/lang/Object;)Z","invokevirtual",192);}
case 192:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=193;continue;}
case 193:{f.Locals[4]=f.Pop();f.Pc=195;continue;}
case 195:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(-1)));f.Pc=198;continue;}
case 198:{f.Pc=174;continue;}
case 201:{f.Push(f.Locals[4]);f.Pc=203;continue;}
case 203:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12133(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?23:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int!=0?23:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/ArrayList","isEmpty","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?25:23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?36:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/util/collect/FCollection","clear","()V","invokevirtual",34);}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",40);}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",47);}
case 47:{f.Locals[2]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{f.Locals[3]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{f.Locals[4]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{f.Locals[5]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?116:62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",71);}
case 71:{f.Locals[6]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Collection","contains","(Ljava/lang/Object;)Z","invokeinterface",81);}
case 81:{f.Pc=f.Pop().Int==0?90:84;continue;}
case 84:{f.Push(JValue.I(1));f.Pc=85;continue;}
case 85:{f.Locals[4]=f.Pop();f.Pc=87;continue;}
case 87:{f.Pc=110;continue;}
case 90:{f.Push(f.Locals[3]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[5]);f.Pc=93;continue;}
case 93:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?107:96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=100;continue;}
case 100:{f.Push(f.Locals[3]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[6]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/util/ArrayList","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokevirtual",106);}
case 106:{f.StackOp("pop");f.Pc=107;continue;}
case 107:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=110;continue;}
case 110:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=113;continue;}
case 113:{f.Pc=56;continue;}
case 116:{f.Push(f.Locals[4]);f.Pc=118;continue;}
case 118:{f.Pc=f.Pop().Int!=0?123:121;continue;}
case 121:{f.Push(JValue.I(0));f.Pc=122;continue;}
case 122:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{f.Push(JValue.I(1));f.Pc=125;continue;}
case 125:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=126;continue;}
case 126:{f.Locals[5]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[5]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[3]);f.Pc=131;continue;}
case 131:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?150:134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=138;continue;}
case 138:{f.Push(f.Locals[5]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/ArrayList","remove","(I)Ljava/lang/Object;","invokevirtual",143);}
case 143:{f.StackOp("pop");f.Pc=144;continue;}
case 144:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(-1)));f.Pc=147;continue;}
case 147:{f.Pc=128;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{f.StackOp("dup");f.Pc=152;continue;}
case 152:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=155;continue;}
case 155:{f.Push(JValue.I(1));f.Pc=156;continue;}
case 156:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=157;continue;}
case 157:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=164;continue;}
case 164:{f.Pc=f.Pop().Reference==null?171:167;continue;}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/util/collect/FCollection","rebuildHashTable","()V","invokevirtual",171);}
case 171:{f.Push(JValue.I(1));f.Pc=172;continue;}
case 172:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12134(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?14:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/ArrayList","isEmpty","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/Collection")?1:0));f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Int==0?32:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/util/collect/FCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",31);}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",40);}
case 40:{f.Locals[3]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",47);}
case 47:{f.Pc=f.Pop().Int==0?70:50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",56);}
case 56:{f.Locals[4]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/util/collect/FCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",65);}
case 65:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=66;continue;}
case 66:{f.Locals[2]=f.Pop();f.Pc=67;continue;}
case 67:{f.Pc=41;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12135(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?14:4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"java/lang/NullPointerException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/NullPointerException")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("collection")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/NullPointerException","<init>","(Ljava/lang/String;)V","invokespecial",13);}
case 13:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?29:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/ArrayList","isEmpty","()Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int==0?31:29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",35);}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",42);}
case 42:{f.Locals[2]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{f.Locals[3]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{f.Locals[4]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{f.Locals[5]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?111:57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",66);}
case 66:{f.Locals[6]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[6]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Collection","contains","(Ljava/lang/Object;)Z","invokeinterface",76);}
case 76:{f.Pc=f.Pop().Int==0?102:79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?96:85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/ArrayList","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokevirtual",95);}
case 95:{f.StackOp("pop");f.Pc=96;continue;}
case 96:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=99;continue;}
case 99:{f.Pc=105;continue;}
case 102:{f.Push(JValue.I(1));f.Pc=103;continue;}
case 103:{f.Locals[4]=f.Pop();f.Pc=105;continue;}
case 105:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=108;continue;}
case 108:{f.Pc=51;continue;}
case 111:{f.Push(f.Locals[4]);f.Pc=113;continue;}
case 113:{f.Pc=f.Pop().Int!=0?118:116;continue;}
case 116:{f.Push(JValue.I(0));f.Pc=117;continue;}
case 117:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 118:{f.Push(f.Locals[2]);f.Pc=119;continue;}
case 119:{f.Push(JValue.I(1));f.Pc=120;continue;}
case 120:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=121;continue;}
case 121:{f.Locals[5]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[5]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[3]);f.Pc=126;continue;}
case 126:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?145:129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=133;continue;}
case 133:{f.Push(f.Locals[5]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/ArrayList","remove","(I)Ljava/lang/Object;","invokevirtual",138);}
case 138:{f.StackOp("pop");f.Pc=139;continue;}
case 139:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(-1)));f.Pc=142;continue;}
case 142:{f.Pc=123;continue;}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{f.StackOp("dup");f.Pc=147;continue;}
case 147:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=150;continue;}
case 150:{f.Push(JValue.I(1));f.Pc=151;continue;}
case 151:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=152;continue;}
case 152:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=159;continue;}
case 159:{f.Pc=f.Pop().Reference==null?166:162;continue;}
case 162:{f.Push(f.Locals[0]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/util/collect/FCollection","rebuildHashTable","()V","invokevirtual",166);}
case 166:{f.Push(JValue.I(1));f.Pc=167;continue;}
case 167:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12136(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?11:10;continue;}
case 10:{return JStep.ReturnVoid;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","sharedList","Z"));f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Int!=0?25:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","liveIterators","I"));f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Int<=0?49:25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",33);}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;",value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","sharedList","Z",value);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","liveIterators","I",value);f.Pc=46;continue;}
case 46:{f.Pc=56;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/ArrayList","clear","()V","invokevirtual",56);}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=61;continue;}
case 61:{f.Push(JValue.I(1));f.Pc=62;continue;}
case 62:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=63;continue;}
case 63:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/util/collect/FCollection","clearHashTable","()V","invokevirtual",70);}
case 70:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12137(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12138(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/ArrayList","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokevirtual",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","contentVersion","I"));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","contentVersion","I",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=28;continue;}
case 28:{f.Pc=f.Pop().Reference==null?40:31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?40:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/util/collect/FCollection","clearHashTable","()V","invokevirtual",40);}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12139(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?14:4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"java/lang/NullPointerException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/NullPointerException")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("FCollection does not allow null elements")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/NullPointerException","<init>","(Ljava/lang/String;)V","invokespecial",13);}
case 13:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/ArrayList","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokevirtual",27);}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","contentVersion","I"));f.Pc=33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=35;continue;}
case 35:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","contentVersion","I",value);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?62:43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=47;continue;}
case 47:{f.Pc=f.Pop().Reference==null?62:50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/util/collect/FCollection","removeFromHashTable","(Ljava/lang/Object;)Z","invokevirtual",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/util/collect/FCollection","addToHashTable","(Ljava/lang/Object;)Z","invokevirtual",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12140(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/collect/FCollection","insert","(ILjava/lang/Object;)Z","invokevirtual",6);}
case 6:{f.StackOp("pop");f.Pc=7;continue;}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12141(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Int<0?21:10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",18);}
case 18:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?42:21;continue;}
case 21:{if(!rt.EnsureInitialized(f,"java/lang/IndexOutOfBoundsException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IndexOutOfBoundsException")));f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",33);}
case 33:{return rt.DynamicCall(f,"forge/util/collect/FCollection:12141:33:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(II)Ljava/lang/String;",38);}
case 38:{return rt.Call(f,"java/lang/IndexOutOfBoundsException","<init>","(Ljava/lang/String;)V","invokespecial",41);}
case 41:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",46);}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=50;continue;}
case 50:{f.Pc=f.Pop().Reference!=null?65:53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/ArrayList","contains","(Ljava/lang/Object;)Z","invokevirtual",61);}
case 61:{f.Locals[3]=f.Pop();f.Pc=62;continue;}
case 62:{f.Pc=79;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/util/collect/FCollection","findHashIndex","(Ljava/lang/Object;)I","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int<0?77:73;continue;}
case 73:{f.Push(JValue.I(1));f.Pc=74;continue;}
case 74:{f.Pc=78;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{f.Locals[3]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{f.Pc=f.Pop().Int!=0?150:83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/ArrayList","add","(ILjava/lang/Object;)V","invokevirtual",92);}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.StackOp("dup");f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=97;continue;}
case 97:{f.Push(JValue.I(1));f.Pc=98;continue;}
case 98:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=99;continue;}
case 99:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=106;continue;}
case 106:{f.Pc=f.Pop().Reference!=null?135:109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",116);}
case 116:{f.Push(JValue.I(8));f.Pc=118;continue;}
case 118:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?135:121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",129);}
case 129:{return rt.Call(f,"forge/util/collect/FCollection","buildHashTable","(I)V","invokevirtual",132);}
case 132:{f.Pc=148;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=139;continue;}
case 139:{f.Pc=f.Pop().Reference==null?148:142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[2]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/util/collect/FCollection","addToHashTable","(Ljava/lang/Object;)Z","invokevirtual",147);}
case 147:{f.StackOp("pop");f.Pc=148;continue;}
case 148:{f.Push(JValue.I(1));f.Pc=149;continue;}
case 149:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=154;continue;}
case 154:{f.Push(f.Locals[2]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/util/ArrayList","indexOf","(Ljava/lang/Object;)I","invokevirtual",158);}
case 158:{f.Locals[4]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[4]);f.Pc=163;continue;}
case 163:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?168:166;continue;}
case 166:{f.Push(JValue.I(0));f.Pc=167;continue;}
case 167:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 168:{f.Push(f.Locals[1]);f.Pc=169;continue;}
case 169:{f.Locals[5]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[5]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[4]);f.Pc=175;continue;}
case 175:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?181:178;continue;}
case 178:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(-1)));f.Pc=181;continue;}
case 181:{f.Push(f.Locals[0]);f.Pc=182;continue;}
case 182:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=185;continue;}
case 185:{f.Push(f.Locals[4]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"java/util/ArrayList","remove","(I)Ljava/lang/Object;","invokevirtual",190);}
case 190:{f.Locals[6]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[0]);f.Pc=193;continue;}
case 193:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=196;continue;}
case 196:{f.Push(f.Locals[5]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[2]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/util/ArrayList","add","(ILjava/lang/Object;)V","invokevirtual",202);}
case 202:{f.Push(f.Locals[0]);f.Pc=203;continue;}
case 203:{f.StackOp("dup");f.Pc=204;continue;}
case 204:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=207;continue;}
case 207:{f.Push(JValue.I(1));f.Pc=208;continue;}
case 208:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=209;continue;}
case 209:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=216;continue;}
case 216:{f.Pc=f.Pop().Reference==null?238:219;continue;}
case 219:{f.Push(f.Locals[6]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[2]);f.Pc=222;continue;}
case 222:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?238:225;continue;}
case 225:{f.Push(f.Locals[0]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[6]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/util/collect/FCollection","removeFromHashTable","(Ljava/lang/Object;)Z","invokevirtual",231);}
case 231:{f.StackOp("pop");f.Pc=232;continue;}
case 232:{f.Push(f.Locals[0]);f.Pc=233;continue;}
case 233:{f.Push(f.Locals[2]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/util/collect/FCollection","addToHashTable","(Ljava/lang/Object;)Z","invokevirtual",237);}
case 237:{f.StackOp("pop");f.Pc=238;continue;}
case 238:{f.Push(JValue.I(1));f.Pc=239;continue;}
case 239:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12142(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/ArrayList","remove","(I)Ljava/lang/Object;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Reference==null?40:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=31;continue;}
case 31:{f.Pc=f.Pop().Reference==null?40:34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/util/collect/FCollection","removeFromHashTable","(Ljava/lang/Object;)Z","invokevirtual",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12143(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/ArrayList","indexOf","(Ljava/lang/Object;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12144(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/ArrayList","lastIndexOf","(Ljava/lang/Object;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12145(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollection","clearHashTable","()V","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/ArrayList","listIterator","()Ljava/util/ListIterator;","invokevirtual",25);}
case 25:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12146(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollection","clearHashTable","()V","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/ArrayList","listIterator","(I)Ljava/util/ListIterator;","invokevirtual",26);}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12147(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",11);}
case 11:{return rt.Call(f,"java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;","invokestatic",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12148(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/ArrayList","subList","(II)Ljava/util/List;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",16);}
case 16:{return rt.Call(f,"java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;","invokestatic",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12149(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/collect/FCollection","TO_STRING_COMPARATOR","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/collect/FCollection","TO_STRING_COMPARATOR","Ljava/util/Comparator;"));f.Pc=3;continue;}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/collect/FCollection","sort","(Ljava/util/Comparator;)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12150(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","contentVersion","I"));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","contentVersion","I",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/ArrayList","sort","(Ljava/util/Comparator;)V","invokevirtual",22);}
case 22:{f.Pc=45;continue;}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",33);}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/Exception","getMessage","()Ljava/lang/String;","invokevirtual",37);}
case 37:{return rt.DynamicCall(f,"forge/util/collect/FCollection:12150:37:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",42);}
case 42:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",45);}
case 45:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12151(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","stream","()Ljava/util/stream/Stream;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12152(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",10);}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?38:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",22);}
case 22:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?32:30;continue;}
case 30:{f.Push(JValue.I(1));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 32:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=35;continue;}
case 35:{f.Pc=2;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12153(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",10);}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?38:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",22);}
case 22:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int!=0?32:30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 32:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=35;continue;}
case 35:{f.Pc=2;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12154(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","hashCode","()I","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(16));f.Pc=9;continue;}
case 9:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iushr",a,b));f.Pc=10;continue;}
case 10:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ixor",a,b));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12155(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(32));f.Pc=2;continue;}
case 2:{f.Locals[1]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?22:8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.I(1073741824));f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?22:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=18;continue;}
case 18:{f.Locals[1]=f.Pop();f.Pc=19;continue;}
case 19:{f.Pc=3;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12156(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(32));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iushr",a,b));f.Pc=6;continue;}
case 6:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/util/collect/FCollection","nextPowerOfTwo","(I)I","invokestatic",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=22;continue;}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;",value);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=34;continue;}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","hashMask","I",value);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","hashSize","I",value);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{f.Locals[5]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",52);}
case 52:{f.Locals[6]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[5]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[6]);f.Pc=58;continue;}
case 58:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?91:61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=65;continue;}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",70);}
case 70:{f.Locals[7]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[7]);f.Pc=74;continue;}
case 74:{f.Pc=f.Pop().Reference==null?85:77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[7]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[4]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/util/collect/FCollection","insertHashNoResize","(Ljava/lang/Object;[Ljava/lang/Object;)V","invokevirtual",85);}
case 85:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=88;continue;}
case 88:{f.Pc=54;continue;}
case 91:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12157(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=12;continue;}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(null));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Arrays","fill","([Ljava/lang/Object;Ljava/lang/Object;)V","invokestatic",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","hashSize","I",value);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Locals[2]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",32);}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?66:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",46);}
case 46:{f.Locals[4]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{f.Pc=f.Pop().Reference==null?60:53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/util/collect/FCollection","insertHashNoResize","(Ljava/lang/Object;[Ljava/lang/Object;)V","invokevirtual",60);}
case 60:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=63;continue;}
case 63:{f.Pc=33;continue;}
case 66:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12158(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","hashSize","I",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","hashMask","I",value);f.Pc=15;continue;}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12159(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/collect/FCollection","findHashIndex","(Ljava/lang/Object;)I","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int<0?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12160(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference!=null?13:11;continue;}
case 11:{f.Push(JValue.I(-1));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=17;continue;}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashMask","I"));f.Pc=22;continue;}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/util/collect/FCollection","spreadHash","(Ljava/lang/Object;)I","invokestatic",27);}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=29;continue;}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=35;continue;}
case 35:{f.Locals[5]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[5]);f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Reference!=null?44:42;continue;}
case 42:{f.Push(JValue.I(-1));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?59:50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?62:59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{f.Push(JValue.I(1));f.Pc=65;continue;}
case 65:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=68;continue;}
case 68:{f.Locals[4]=f.Pop();f.Pc=70;continue;}
case 70:{f.Pc=31;continue;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12161(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference!=null?31:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",21);}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=23;continue;}
case 23:{f.Push(JValue.I(65));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",28);}
case 28:{return rt.Call(f,"forge/util/collect/FCollection","buildHashTable","(I)V","invokevirtual",31);}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/util/collect/FCollection","hashContains","(Ljava/lang/Object;)Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int==0?41:39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashSize","I"));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=51;continue;}
case 51:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=56;continue;}
case 56:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=57;continue;}
case 57:{f.Push(JValue.I(2));f.Pc=58;continue;}
case 58:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iushr",a,b));f.Pc=59;continue;}
case 59:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=60;continue;}
case 60:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?74:63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=68;continue;}
case 68:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=69;continue;}
case 69:{f.Push(JValue.I(1));f.Pc=70;continue;}
case 70:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/util/collect/FCollection","resizeHashTable","(I)V","invokevirtual",74);}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/util/collect/FCollection","insertHashNoResize","(Ljava/lang/Object;[Ljava/lang/Object;)V","invokevirtual",83);}
case 83:{f.Push(JValue.I(1));f.Pc=84;continue;}
case 84:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12162(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=4;continue;}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/collect/FCollection","spreadHash","(Ljava/lang/Object;)I","invokestatic",9);}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=11;continue;}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Reference==null?31:20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=26;continue;}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Pc=13;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashSize","I"));f.Pc=41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=43;continue;}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","hashSize","I",value);f.Pc=46;continue;}
case 46:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12163(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(32));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",6);}
case 6:{return rt.Call(f,"forge/util/collect/FCollection","nextPowerOfTwo","(I)I","invokestatic",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=14;continue;}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=19;continue;}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=31;continue;}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","hashMask","I",value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","hashSize","I",value);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Reference==null?78:43;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{f.Locals[5]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=50;continue;}
case 50:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?78:53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[5]);f.Pc=56;continue;}
case 56:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=57;continue;}
case 57:{f.Locals[6]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[6]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Reference==null?72:64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[6]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/util/collect/FCollection","insertHashNoResize","(Ljava/lang/Object;[Ljava/lang/Object;)V","invokevirtual",72);}
case 72:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=75;continue;}
case 75:{f.Pc=46;continue;}
case 78:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12164(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference!=null?13:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/util/collect/FCollection","findHashIndex","(Ljava/lang/Object;)I","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Int>=0?25:23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/util/collect/FCollection","removeHashEntryAt","(I)V","invokevirtual",30);}
case 30:{f.Push(JValue.I(1));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12165(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=4;continue;}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashSize","I"));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","hashSize","I",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashMask","I"));f.Pc=26;continue;}
case 26:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=27;continue;}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=31;continue;}
case 31:{f.Pc=f.Pop().Reference==null?72:34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=37;continue;}
case 37:{f.Locals[4]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(null));f.Pc=42;continue;}
case 42:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashSize","I"));f.Pc=48;continue;}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=50;continue;}
case 50:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","hashSize","I",value);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/util/collect/FCollection","insertHashNoResize","(Ljava/lang/Object;[Ljava/lang/Object;)V","invokevirtual",60);}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(1));f.Pc=62;continue;}
case 62:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashMask","I"));f.Pc=67;continue;}
case 67:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=68;continue;}
case 68:{f.Locals[3]=f.Pop();f.Pc=69;continue;}
case 69:{f.Pc=28;continue;}
case 72:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12166(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;",value);f.Pc=15;continue;}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12167(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/ArrayList","<init>","(I)V","invokespecial",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;",value);f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12168(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/ArrayList","<init>","(I)V","invokespecial",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12169(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference==null?18:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=15;continue;}
case 15:{f.Pc=20;continue;}
case 18:{f.Push(JValue.I(10));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/ArrayList","<init>","(I)V","invokespecial",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/util/collect/FCollection","addAll","([Ljava/lang/Object;)Z","invokevirtual",31);}
case 31:{f.StackOp("pop");f.Pc=32;continue;}
case 32:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12170(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/util/collect/FCollection")?1:0));f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int==0?32:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",28);}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;",value);f.Pc=31;continue;}
case 31:{return JStep.ReturnVoid;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/Collection")?1:0));f.Pc=36;continue;}
case 36:{f.Pc=f.Pop().Int==0?68:39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[2]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",55);}
case 55:{return rt.Call(f,"java/util/ArrayList","<init>","(I)V","invokespecial",58);}
case 58:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;",value);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/lang/Iterable;)Z","invokevirtual",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{return JStep.ReturnVoid;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=72;continue;}
case 72:{f.StackOp("dup");f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",76);}
case 76:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;",value);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/lang/Iterable;)Z","invokevirtual",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12171(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/util/collect/FCollectionReader","readAll","(Lforge/util/collect/FCollection;)V","invokevirtual",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12172(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/ArrayList","ensureCapacity","(I)V","invokevirtual",12);}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12173(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FCollection","clone","()Lforge/util/collect/FCollection;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12174(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection$EmptyFCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection$EmptyFCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollection$EmptyFCollection","<init>","()V","invokespecial",7);}
case 7:{if(!rt.StaticReady(f,"forge/util/collect/FCollection","EMPTY","Lforge/util/collect/FCollection;"))return JStep.Continue;rt.PutStatic("forge/util/collect/FCollection","EMPTY","Lforge/util/collect/FCollection;",f.Pop());f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/util/collect/FCollection","EMPTY_OBJECT_ARRAY","[Ljava/lang/Object;"))return JStep.Continue;rt.PutStatic("forge/util/collect/FCollection","EMPTY_OBJECT_ARRAY","[Ljava/lang/Object;",f.Pop());f.Pc=17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection$1")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/util/collect/FCollection$1","<init>","()V","invokespecial",24);}
case 24:{if(!rt.StaticReady(f,"forge/util/collect/FCollection","TO_STRING_COMPARATOR","Ljava/util/Comparator;"))return JStep.Continue;rt.PutStatic("forge/util/collect/FCollection","TO_STRING_COMPARATOR","Ljava/util/Comparator;",f.Pop());f.Pc=27;continue;}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
