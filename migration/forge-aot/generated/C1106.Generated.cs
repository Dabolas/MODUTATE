// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1106{
internal static JClass Build(){var c=new JClass("forge/util/Aggregates","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11625,"forge/util/Aggregates","<init>","()V",1,1,1,new JHandler[]{},M11625));
c.Add(new JMethod(11626,"forge/util/Aggregates","max","(Ljava/lang/Iterable;Ljava/util/function/Function;)Ljava/lang/Integer;",25,6,2,new JHandler[]{},M11626));
c.Add(new JMethod(11627,"forge/util/Aggregates","max","(Ljava/lang/Iterable;)Ljava/lang/Integer;",9,4,2,new JHandler[]{},M11627));
c.Add(new JMethod(11628,"forge/util/Aggregates","min","(Ljava/lang/Iterable;Ljava/util/function/Function;)Ljava/lang/Integer;",25,6,2,new JHandler[]{},M11628));
c.Add(new JMethod(11629,"forge/util/Aggregates","min","(Ljava/lang/Iterable;)Ljava/lang/Integer;",9,4,2,new JHandler[]{},M11629));
c.Add(new JMethod(11630,"forge/util/Aggregates","itemWithMax","(Ljava/lang/Iterable;Ljava/util/function/Function;)Ljava/lang/Object;",25,7,2,new JHandler[]{},M11630));
c.Add(new JMethod(11631,"forge/util/Aggregates","listWithMin","(Ljava/lang/Iterable;Ljava/util/function/Function;)Ljava/util/List;",25,7,2,new JHandler[]{},M11631));
c.Add(new JMethod(11632,"forge/util/Aggregates","sum","(Ljava/lang/Iterable;Ljava/util/function/Function;)I",25,5,3,new JHandler[]{},M11632));
c.Add(new JMethod(11633,"forge/util/Aggregates","sum","(Ljava/lang/Iterable;)I",9,4,2,new JHandler[]{},M11633));
c.Add(new JMethod(11634,"forge/util/Aggregates","random","([Ljava/lang/Object;)Ljava/lang/Object;",25,1,3,new JHandler[]{},M11634));
c.Add(new JMethod(11635,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;",25,6,3,new JHandler[]{},M11635));
c.Add(new JMethod(11636,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;",25,2,4,new JHandler[]{},M11636));
c.Add(new JMethod(11637,"forge/util/Aggregates","random","(Ljava/lang/Iterable;ILjava/util/List;)Ljava/util/List;",25,7,3,new JHandler[]{},M11637));
c.Add(new JMethod(11638,"forge/util/Aggregates","removeRandom","(Ljava/util/List;)Ljava/lang/Object;",25,2,2,new JHandler[]{},M11638));
c.Add(new JMethod(11639,"forge/util/Aggregates","randomInt","(II)I",9,2,3,new JHandler[]{},M11639));
c.Add(new JMethod(11640,"forge/util/Aggregates","uniqueByLast","(Ljava/lang/Iterable;Ljava/util/function/Function;)Ljava/lang/Iterable;",25,5,3,new JHandler[]{},M11640));
c.Add(new JMethod(11641,"forge/util/Aggregates","itemWithMin","(Ljava/lang/Iterable;Ljava/util/function/Function;)Ljava/lang/Object;",9,7,2,new JHandler[]{},M11641));
c.Add(new JMethod(11642,"forge/util/Aggregates","firstFieldEquals","(Ljava/util/List;Ljava/util/function/Function;Ljava/lang/Object;)Ljava/lang/Object;",9,5,3,new JHandler[]{},M11642));
c.Add(new JMethod(11643,"forge/util/Aggregates","groupSumBy","(Ljava/lang/Iterable;Ljava/util/function/Function;)Ljava/lang/Iterable;",9,2,3,new JHandler[]{},M11643));
c.Add(new JMethod(11644,"forge/util/Aggregates","lambda$groupSumBy$1","(Ljava/util/Map$Entry;)I",4106,1,1,new JHandler[]{},M11644));
c.Add(new JMethod(11645,"forge/util/Aggregates","lambda$groupSumBy$0","(Ljava/util/function/Function;Ljava/util/Map$Entry;)Ljava/lang/Object;",4106,2,2,new JHandler[]{},M11645));
}

internal static JStep M11625(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11626(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(JValue.I(int.MinValue));f.Pc=8;continue;}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?61:25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",47);}
case 47:{f.Locals[5]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?58:55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{f.Locals[2]=f.Pop();f.Pc=58;continue;}
case 58:{f.Pc=16;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",65);}
case 65:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11627(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(JValue.I(int.MinValue));f.Pc=8;continue;}
case 8:{f.Locals[1]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?48:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",37);}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?45:43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{f.Locals[1]=f.Pop();f.Pc=45;continue;}
case 45:{f.Pc=16;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",52);}
case 52:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11628(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(JValue.I(2147483647));f.Pc=8;continue;}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?61:25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",47);}
case 47:{f.Locals[5]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?58:55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{f.Locals[2]=f.Pop();f.Pc=58;continue;}
case 58:{f.Pc=16;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",65);}
case 65:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11629(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(JValue.I(2147483647));f.Pc=8;continue;}
case 8:{f.Locals[1]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?48:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",37);}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?45:43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{f.Locals[1]=f.Pop();f.Pc=45;continue;}
case 45:{f.Pc=16;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",52);}
case 52:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11630(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(JValue.I(int.MinValue));f.Pc=8;continue;}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?69:29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",36);}
case 36:{f.Locals[5]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",52);}
case 52:{f.Locals[6]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?66:60;continue;}
case 60:{f.Push(f.Locals[6]);f.Pc=62;continue;}
case 62:{f.Locals[2]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{f.Locals[3]=f.Pop();f.Pc=66;continue;}
case 66:{f.Pc=19;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11631(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(JValue.I(2147483647));f.Pc=8;continue;}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?98:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{f.Locals[5]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",54);}
case 54:{f.Locals[6]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[6]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?71:62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Push(f.Locals[6]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?95:77;continue;}
case 77:{f.Push(f.Locals[6]);f.Pc=79;continue;}
case 79:{f.Locals[2]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",86);}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",94);}
case 94:{f.StackOp("pop");f.Pc=95;continue;}
case 95:{f.Pc=21;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11632(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference==null?50:6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?50:22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",45);}
case 45:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=46;continue;}
case 46:{f.Locals[2]=f.Pop();f.Pc=47;continue;}
case 47:{f.Pc=13;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11633(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference==null?42:6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?42:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",37);}
case 37:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=38;continue;}
case 38:{f.Locals[1]=f.Pop();f.Pc=39;continue;}
case 39:{f.Pc=13;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11634(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=8;continue;}
case 8:{switch(f.Pop().Int){case 0:f.Pc=36;break;case 1:f.Pc=38;break;default:f.Pc=42;break;}continue;}
case 36:{f.Push(JValue.R(null));f.Pc=37;continue;}
case 37:{return JStep.Return(f.Pop());}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",46);}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",51);}
case 51:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=52;continue;}
case 52:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11635(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/List")?1:0));f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Int==0?76:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",24);}
case 24:{f.Locals[2]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{switch(f.Pop().Int){case 0:f.Pc=52;break;case 1:f.Pc=54;break;default:f.Pc=62;break;}continue;}
case 52:{f.Push(JValue.R(null));f.Pc=53;continue;}
case 53:{return JStep.Return(f.Pop());}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",61);}
case 61:{return JStep.Return(f.Pop());}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",66);}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",70);}
case 70:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",75);}
case 75:{return JStep.Return(f.Pop());}
case 76:{f.Push(JValue.R(null));f.Pc=77;continue;}
case 77:{f.Locals[1]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(JValue.I(2147483647));f.Pc=80;continue;}
case 80:{f.Locals[2]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",87);}
case 87:{f.Locals[3]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[3]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",94);}
case 94:{f.Pc=f.Pop().Int==0?128:97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",103);}
case 103:{f.Locals[4]=f.Pop();f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",108);}
case 108:{return rt.Call(f,"java/util/Random","nextInt","()I","invokevirtual",111);}
case 111:{f.Locals[5]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[5]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[2]);f.Pc=116;continue;}
case 116:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?125:119;continue;}
case 119:{f.Push(f.Locals[5]);f.Pc=121;continue;}
case 121:{f.Locals[2]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[4]);f.Pc=124;continue;}
case 124:{f.Locals[1]=f.Pop();f.Pc=125;continue;}
case 125:{f.Pc=88;continue;}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11636(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",9);}
case 9:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;ILjava/util/List;)Ljava/util/List;","invokestatic",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11637(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",8);}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?78:20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{f.Locals[5]=f.Pop();f.Pc=29;continue;}
case 29:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?49:37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",45);}
case 45:{f.StackOp("pop");f.Pc=46;continue;}
case 46:{f.Pc=75;continue;}
case 49:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",52);}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",56);}
case 56:{f.Locals[6]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[6]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?75:64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[6]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[5]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/List","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokeinterface",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Pc=10;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11638(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?13:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?15:13;continue;}
case 13:{f.Push(JValue.R(null));f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",21);}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?41:25;continue;}
case 25:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",34);}
case 34:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",37);}
case 37:{f.Locals[1]=f.Pop();f.Pc=38;continue;}
case 38:{f.Pc=43;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{f.Locals[1]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/List","remove","(I)Ljava/lang/Object;","invokeinterface",50);}
case 50:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11639(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",3);}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11640(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/Hashtable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Hashtable")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Hashtable","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?52:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",41);}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Pc=15;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",58);}
case 58:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11641(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(JValue.I(2147483647));f.Pc=8;continue;}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?69:29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",36);}
case 36:{f.Locals[5]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",52);}
case 52:{f.Locals[6]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?66:60;continue;}
case 60:{f.Push(f.Locals[6]);f.Pc=62;continue;}
case 62:{f.Locals[2]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{f.Locals[3]=f.Pop();f.Pc=66;continue;}
case 66:{f.Pc=19;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11642(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference!=null?55:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?52:26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",32);}
case 32:{f.Locals[4]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(JValue.R(null));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",43);}
case 43:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?49:46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{return JStep.Return(f.Pop());}
case 49:{f.Pc=17;continue;}
case 52:{f.Pc=100;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",61);}
case 61:{f.Locals[3]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",68);}
case 68:{f.Pc=f.Pop().Int==0?100:71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",77);}
case 77:{f.Locals[4]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[4]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",88);}
case 88:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?97:94;continue;}
case 94:{f.Push(f.Locals[4]);f.Pc=96;continue;}
case 96:{return JStep.Return(f.Pop());}
case 97:{f.Pc=62;continue;}
case 100:{f.Push(JValue.R(null));f.Pc=101;continue;}
case 101:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11643(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/StreamUtil","stream","(Ljava/lang/Iterable;)Ljava/util/stream/Stream;","invokestatic",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.DynamicCall(f,"forge/util/Aggregates:11643:5:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/function/Function;)Ljava/util/function/Function;",10);}
case 10:{return rt.DynamicCall(f,"forge/util/Aggregates:11643:10:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",15);}
case 15:{return rt.Call(f,"java/util/stream/Collectors","summingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;","invokestatic",18);}
case 18:{return rt.Call(f,"java/util/stream/Collectors","groupingBy","(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;","invokestatic",21);}
case 21:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",34);}
case 34:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11644(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11645(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",7);}
case 7:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
