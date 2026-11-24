// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C681{
internal static JClass Build(){var c=new JClass("forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","java/lang/Object",new string[]{"forge/card/mana/IParserManaCost"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("mch","Ljava/util/Iterator;",false,JValue.Default("Ljava/util/Iterator;"),null));
c.Add(new JField("nextShard","Lforge/card/mana/ManaCostShard;",false,JValue.Default("Lforge/card/mana/ManaCostShard;"),null));
c.Add(new JField("remainingShards","I",false,JValue.Default("I"),null));
c.Add(new JField("hasSentX","Z",false,JValue.Default("Z"),null));
c.Add(new JField("this$0","Lforge/game/mana/ManaCostBeingPaid;",false,JValue.Default("Lforge/game/mana/ManaCostBeingPaid;"),null));
c.Add(new JMethod(7763,"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","<init>","(Lforge/game/mana/ManaCostBeingPaid;)V",1,2,2,new JHandler[]{},M7763));
c.Add(new JMethod(7764,"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","remove","()V",1,1,2,new JHandler[]{},M7764));
c.Add(new JMethod(7765,"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","next","()Lforge/card/mana/ManaCostShard;",1,1,3,new JHandler[]{},M7765));
c.Add(new JMethod(7766,"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","hasNext","()Z",1,1,3,new JHandler[]{},M7766));
c.Add(new JMethod(7767,"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","getTotalGenericCost","()I",1,2,2,new JHandler[]{},M7767));
c.Add(new JMethod(7768,"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","next","()Ljava/lang/Object;",4161,1,1,new JHandler[]{},M7768));
}

internal static JStep M7763(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","this$0","Lforge/game/mana/ManaCostBeingPaid;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","nextShard","Lforge/card/mana/ManaCostShard;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","remainingShards","I",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","hasSentX","Z",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",34);}
case 34:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",39);}
case 39:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","mch","Ljava/util/Iterator;",value);f.Pc=42;continue;}
case 42:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7764(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/UnsupportedOperationException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/UnsupportedOperationException")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/UnsupportedOperationException","<init>","()V","invokespecial",7);}
case 7:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7765(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","remainingShards","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?17:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/lang/UnsupportedOperationException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/UnsupportedOperationException")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("All shards were depleted, call hasNext()")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/UnsupportedOperationException","<init>","(Ljava/lang/String;)V","invokespecial",16);}
case 16:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","remainingShards","I"));f.Pc=22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","remainingShards","I",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","nextShard","Lforge/card/mana/ManaCostShard;"));f.Pc=31;continue;}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7766(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","remainingShards","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int<=0?9:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","hasSentX","Z"));f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Int!=0?61:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","nextShard","Lforge/card/mana/ManaCostShard;"));f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"));f.Pc=23;continue;}
case 23:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?56:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","this$0","Lforge/game/mana/ManaCostBeingPaid;"));f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I"));f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Int<=0?56:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","nextShard","Lforge/card/mana/ManaCostShard;",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","this$0","Lforge/game/mana/ManaCostBeingPaid;"));f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I"));f.Pc=51;continue;}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","remainingShards","I",value);f.Pc=54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","hasSentX","Z",value);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","mch","Ljava/util/Iterator;"));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",70);}
case 70:{f.Pc=f.Pop().Int!=0?75:73;continue;}
case 73:{f.Push(JValue.I(0));f.Pc=74;continue;}
case 74:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","mch","Ljava/util/Iterator;"));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",85);}
case 85:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=88;continue;}
case 88:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","nextShard","Lforge/card/mana/ManaCostShard;",value);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","nextShard","Lforge/card/mana/ManaCostShard;"));f.Pc=95;continue;}
case 95:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=98;continue;}
case 98:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?106:101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","hasNext","()Z","invokevirtual",105);}
case 105:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","this$0","Lforge/game/mana/ManaCostBeingPaid;"));f.Pc=111;continue;}
case 111:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","nextShard","Lforge/card/mana/ManaCostShard;"));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",123);}
case 123:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=126;continue;}
case 126:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=129;continue;}
case 129:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","remainingShards","I",value);f.Pc=132;continue;}
case 132:{f.Push(JValue.I(1));f.Pc=133;continue;}
case 133:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7767(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","this$0","Lforge/game/mana/ManaCostBeingPaid;"));f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{f.Locals[1]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference!=null?54:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","this$0","Lforge/game/mana/ManaCostBeingPaid;"));f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?52:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","this$0","Lforge/game/mana/ManaCostBeingPaid;"));f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I"));f.Pc=45;continue;}
case 45:{f.Pc=f.Pop().Int!=0?52:48;continue;}
case 48:{f.Push(JValue.I(-1));f.Pc=49;continue;}
case 49:{f.Pc=53;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=58;continue;}
case 58:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7768(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","next","()Lforge/card/mana/ManaCostShard;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
