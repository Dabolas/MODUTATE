// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C680{
internal static JClass Build(){var c=new JClass("forge/game/mana/ManaCostBeingPaid","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("unpaidShards","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("xManaCostPaidByColor","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("sunburstMap","B",false,JValue.Default("B"),null));
c.Add(new JField("cntX","I",false,JValue.Default("I"),null));
c.Add(new JMethod(7719,"forge/game/mana/ManaCostBeingPaid","<init>","(Lforge/game/mana/ManaCostBeingPaid;)V",1,4,6,new JHandler[]{},M7719));
c.Add(new JMethod(7720,"forge/game/mana/ManaCostBeingPaid","<init>","(Lforge/card/mana/ManaCost;)V",1,4,4,new JHandler[]{},M7720));
c.Add(new JMethod(7721,"forge/game/mana/ManaCostBeingPaid","getXManaCostPaidByColor","()Ljava/util/Map;",1,1,1,new JHandler[]{},M7721));
c.Add(new JMethod(7722,"forge/game/mana/ManaCostBeingPaid","getSunburst","()I",17,1,1,new JHandler[]{},M7722));
c.Add(new JMethod(7723,"forge/game/mana/ManaCostBeingPaid","getColorsPaid","()B",17,1,1,new JHandler[]{},M7723));
c.Add(new JMethod(7724,"forge/game/mana/ManaCostBeingPaid","containsPhyrexianMana","()Z",17,3,1,new JHandler[]{},M7724));
c.Add(new JMethod(7725,"forge/game/mana/ManaCostBeingPaid","containsOnlyPhyrexianMana","()Z",17,3,1,new JHandler[]{},M7725));
c.Add(new JMethod(7726,"forge/game/mana/ManaCostBeingPaid","payPhyrexian","()Z",17,4,3,new JHandler[]{},M7726));
c.Add(new JMethod(7727,"forge/game/mana/ManaCostBeingPaid","needsColor","(BLforge/game/mana/ManaPool;)Z",17,5,3,new JHandler[]{},M7727));
c.Add(new JMethod(7728,"forge/game/mana/ManaCostBeingPaid","isAnyPartPayableWith","(BLforge/game/mana/ManaPool;)Z",17,5,3,new JHandler[]{},M7728));
c.Add(new JMethod(7729,"forge/game/mana/ManaCostBeingPaid","isNeeded","(Lforge/game/mana/Mana;Lforge/game/mana/ManaPool;)Z",17,5,4,new JHandler[]{},M7729));
c.Add(new JMethod(7730,"forge/game/mana/ManaCostBeingPaid","isPaid","()Z",17,1,1,new JHandler[]{},M7730));
c.Add(new JMethod(7731,"forge/game/mana/ManaCostBeingPaid","setXManaCostPaid","(ILjava/lang/String;)V",17,5,4,new JHandler[]{},M7731));
c.Add(new JMethod(7732,"forge/game/mana/ManaCostBeingPaid","increaseGenericMana","(I)V",17,2,4,new JHandler[]{},M7732));
c.Add(new JMethod(7733,"forge/game/mana/ManaCostBeingPaid","increaseShard","(Lforge/card/mana/ManaCostShard;I)V",17,3,4,new JHandler[]{},M7733));
c.Add(new JMethod(7734,"forge/game/mana/ManaCostBeingPaid","increaseShard","(Lforge/card/mana/ManaCostShard;IZ)V",2,5,3,new JHandler[]{},M7734));
c.Add(new JMethod(7735,"forge/game/mana/ManaCostBeingPaid","decreaseGenericMana","(I)V",17,2,3,new JHandler[]{},M7735));
c.Add(new JMethod(7736,"forge/game/mana/ManaCostBeingPaid","decreaseShard","(Lforge/card/mana/ManaCostShard;I)V",17,10,4,new JHandler[]{},M7736));
c.Add(new JMethod(7737,"forge/game/mana/ManaCostBeingPaid","getGenericManaAmount","()I",17,2,2,new JHandler[]{},M7737));
c.Add(new JMethod(7738,"forge/game/mana/ManaCostBeingPaid","ai_payMana","(Ljava/lang/String;Lforge/game/mana/ManaPool;)Z",17,5,5,new JHandler[]{},M7738));
c.Add(new JMethod(7739,"forge/game/mana/ManaCostBeingPaid","payMana","(Lforge/game/mana/Mana;Lforge/game/mana/ManaPool;)Z",17,6,4,new JHandler[]{},M7739));
c.Add(new JMethod(7740,"forge/game/mana/ManaCostBeingPaid","payManaViaConvoke","(B)Lforge/card/mana/ManaCostShard;",17,3,4,new JHandler[]{},M7740));
c.Add(new JMethod(7741,"forge/game/mana/ManaCostBeingPaid","getShardToPayByPriority","(Ljava/lang/Iterable;B)Lforge/card/mana/ManaCostShard;",1,8,2,new JHandler[]{},M7741));
c.Add(new JMethod(7742,"forge/game/mana/ManaCostBeingPaid","tryPayMana","(BLjava/lang/Iterable;B)Lforge/card/mana/ManaCostShard;",2,7,4,new JHandler[]{},M7742));
c.Add(new JMethod(7743,"forge/game/mana/ManaCostBeingPaid","getPayPriority","(Lforge/card/mana/ManaCostShard;B)I",10,2,2,new JHandler[]{},M7743));
c.Add(new JMethod(7744,"forge/game/mana/ManaCostBeingPaid","canColoredXShardBePaidByColor","(Ljava/lang/String;Ljava/util/Map;)Z",9,2,2,new JHandler[]{},M7744));
c.Add(new JMethod(7745,"forge/game/mana/ManaCostBeingPaid","canBePaidWith","(Lforge/card/mana/ManaCostShard;Lforge/game/mana/Mana;Lforge/game/mana/ManaPool;Ljava/util/Map;)Z",10,5,3,new JHandler[]{},M7745));
c.Add(new JMethod(7746,"forge/game/mana/ManaCostBeingPaid","addManaCost","(Lforge/card/mana/ManaCost;)V",17,4,4,new JHandler[]{},M7746));
c.Add(new JMethod(7747,"forge/game/mana/ManaCostBeingPaid","subtractManaCost","(Lforge/card/mana/ManaCost;)V",17,4,3,new JHandler[]{},M7747));
c.Add(new JMethod(7748,"forge/game/mana/ManaCostBeingPaid","toString","(ZLforge/game/mana/ManaPool;)Ljava/lang/String;",17,11,3,new JHandler[]{},M7748));
c.Add(new JMethod(7749,"forge/game/mana/ManaCostBeingPaid","toString","()Ljava/lang/String;",17,1,3,new JHandler[]{},M7749));
c.Add(new JMethod(7750,"forge/game/mana/ManaCostBeingPaid","getConvertedManaCost","()I",17,4,3,new JHandler[]{},M7750));
c.Add(new JMethod(7751,"forge/game/mana/ManaCostBeingPaid","toManaCost","()Lforge/card/mana/ManaCost;",1,1,5,new JHandler[]{},M7751));
c.Add(new JMethod(7752,"forge/game/mana/ManaCostBeingPaid","getXcounter","()I",17,1,1,new JHandler[]{},M7752));
c.Add(new JMethod(7753,"forge/game/mana/ManaCostBeingPaid","getUnpaidShards","()Ljava/util/List;",17,5,2,new JHandler[]{},M7753));
c.Add(new JMethod(7754,"forge/game/mana/ManaCostBeingPaid","removeGenericMana","()V",17,1,2,new JHandler[]{},M7754));
c.Add(new JMethod(7755,"forge/game/mana/ManaCostBeingPaid","getDistinctShards","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M7755));
c.Add(new JMethod(7756,"forge/game/mana/ManaCostBeingPaid","getUnpaidShards","(Lforge/card/mana/ManaCostShard;)I",1,3,2,new JHandler[]{},M7756));
c.Add(new JMethod(7757,"forge/game/mana/ManaCostBeingPaid","getUnpaidColors","()B",17,4,2,new JHandler[]{},M7757));
c.Add(new JMethod(7758,"forge/game/mana/ManaCostBeingPaid","hasAnyKind","(I)Z",1,4,2,new JHandler[]{},M7758));
c.Add(new JMethod(7759,"forge/game/mana/ManaCostBeingPaid","lambda$payManaViaConvoke$3","(BLforge/card/mana/ManaCostShard;)Z",4106,2,2,new JHandler[]{},M7759));
c.Add(new JMethod(7760,"forge/game/mana/ManaCostBeingPaid","lambda$payMana$2","(Lforge/game/mana/Mana;Lforge/game/mana/ManaPool;Lforge/card/mana/ManaCostShard;)Z",4098,4,4,new JHandler[]{},M7760));
c.Add(new JMethod(7761,"forge/game/mana/ManaCostBeingPaid","lambda$ai_payMana$1","(BLforge/game/mana/ManaPool;Lforge/card/mana/ManaCostShard;)Z",4098,4,3,new JHandler[]{},M7761));
c.Add(new JMethod(7762,"forge/game/mana/ManaCostBeingPaid","lambda$increaseShard$0","(Lforge/card/mana/ManaCostShard;)Lforge/game/mana/ManaCostBeingPaid$ShardCount;",4098,2,3,new JHandler[]{},M7762));
}

internal static JStep M7719(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/EnumMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/EnumMap")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.ClassObject("forge/card/mana/ManaCostShard")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/EnumMap","<init>","(Ljava/lang/Class;)V","invokespecial",14);}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","sunburstMap","B",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",36);}
case 36:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",41);}
case 41:{f.Locals[2]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",48);}
case 48:{f.Pc=f.Pop().Int==0?100:51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{f.Locals[3]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",71);}
case 71:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=74;continue;}
case 74:{if(!rt.EnsureInitialized(f,"forge/game/mana/ManaCostBeingPaid$ShardCount"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/ManaCostBeingPaid$ShardCount")));f.Pc=77;continue;}
case 77:{f.StackOp("dup");f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",85);}
case 85:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid$ShardCount","<init>","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/mana/ManaCostBeingPaid$ShardCount;)V","invokespecial",91);}
case 91:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",96);}
case 96:{f.StackOp("pop");f.Pc=97;continue;}
case 97:{f.Pc=42;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","xManaCostPaidByColor","Ljava/util/Map;"));f.Pc=104;continue;}
case 104:{f.Pc=f.Pop().Reference==null?118:107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","xManaCostPaidByColor","Ljava/util/Map;"));f.Pc=112;continue;}
case 112:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","(Ljava/util/Map;)Ljava/util/HashMap;","invokestatic",115);}
case 115:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","xManaCostPaidByColor","Ljava/util/Map;",value);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","sunburstMap","B"));f.Pc=123;continue;}
case 123:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","sunburstMap","B",value);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I"));f.Pc=131;continue;}
case 131:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I",value);f.Pc=134;continue;}
case 134:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7720(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/EnumMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/EnumMap")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.ClassObject("forge/card/mana/ManaCostShard")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/EnumMap","<init>","(Ljava/lang/Class;)V","invokespecial",14);}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","sunburstMap","B",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Pc=f.Pop().Reference!=null?32:31;continue;}
case 31:{return JStep.ReturnVoid;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/mana/ManaCost","iterator","()Ljava/util/Iterator;","invokevirtual",36);}
case 36:{f.Locals[2]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",43);}
case 43:{f.Pc=f.Pop().Int==0?86:46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Locals[3]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"));f.Pc=60;continue;}
case 60:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?76:63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.StackOp("dup");f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I"));f.Pc=68;continue;}
case 68:{f.Push(JValue.I(1));f.Pc=69;continue;}
case 69:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=70;continue;}
case 70:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I",value);f.Pc=73;continue;}
case 73:{f.Pc=83;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[3]);f.Pc=78;continue;}
case 78:{f.Push(JValue.I(1));f.Pc=79;continue;}
case 79:{f.Push(JValue.I(0));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","increaseShard","(Lforge/card/mana/ManaCostShard;IZ)V","invokevirtual",83);}
case 83:{f.Pc=37;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/card/mana/ManaCost","getGenericCost","()I","invokevirtual",91);}
case 91:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","increaseGenericMana","(I)V","invokevirtual",94);}
case 94:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7721(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","xManaCostPaidByColor","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7722(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","sunburstMap","B"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",7);}
case 7:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7723(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","sunburstMap","B"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7724(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?46:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/card/mana/ManaCostShard","isPhyrexian","()Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?43:41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 43:{f.Pc=15;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7725(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?46:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/card/mana/ManaCostShard","isPhyrexian","()Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int!=0?43:41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 43:{f.Pc=15;continue;}
case 46:{f.Push(JValue.I(1));f.Pc=47;continue;}
case 47:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7726(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",11);}
case 11:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?51:26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/mana/ManaCostShard","isPhyrexian","()Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?48:43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{f.Locals[1]=f.Pop();f.Pc=45;continue;}
case 45:{f.Pc=51;continue;}
case 48:{f.Pc=17;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Pc=f.Pop().Reference!=null?57:55;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(JValue.I(1));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","decreaseShard","(Lforge/card/mana/ManaCostShard;I)V","invokevirtual",63);}
case 63:{f.Push(JValue.I(1));f.Pc=64;continue;}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7727(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?81:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=40;continue;}
case 40:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?46:43;continue;}
case 43:{f.Pc=15;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/card/mana/ManaCostShard","isOr2Generic","()Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?66:54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/card/mana/ManaCostShard","getColorMask","()B","invokevirtual",59);}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Int==0?78:64;continue;}
case 64:{f.Push(JValue.I(1));f.Pc=65;continue;}
case 65:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/mana/ManaPool","canPayForShardWithColor","(Lforge/card/mana/ManaCostShard;B)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int==0?78:76;continue;}
case 76:{f.Push(JValue.I(1));f.Pc=77;continue;}
case 77:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 78:{f.Pc=15;continue;}
case 81:{f.Push(JValue.I(0));f.Pc=82;continue;}
case 82:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7728(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?50:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/mana/ManaPool","canPayForShardWithColor","(Lforge/card/mana/ManaCostShard;B)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?47:45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 47:{f.Pc=15;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7729(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?54:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","xManaCostPaidByColor","Ljava/util/Map;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","canBePaidWith","(Lforge/card/mana/ManaCostShard;Lforge/game/mana/Mana;Lforge/game/mana/ManaPool;Ljava/util/Map;)Z","invokestatic",46);}
case 46:{f.Pc=f.Pop().Int==0?51:49;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 51:{f.Pc=15;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7730(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7731(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I"));f.Pc=5;continue;}
case 5:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I",value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",16);}
case 16:{f.Pc=f.Pop().Int==0?27:19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=22;continue;}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Pc=33;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/card/mana/ManaCostShard","parseNonGeneric","(Ljava/lang/String;)Lforge/card/mana/ManaCostShard;","invokestatic",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","increaseShard","(Lforge/card/mana/ManaCostShard;IZ)V","invokevirtual",41);}
case 41:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7732(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","increaseShard","(Lforge/card/mana/ManaCostShard;IZ)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7733(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","increaseShard","(Lforge/card/mana/ManaCostShard;IZ)V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7734(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int>0?5:4;continue;}
case 4:{return JStep.ReturnVoid;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.DynamicCall(f,"forge/game/mana/ManaCostBeingPaid:7734:11:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/mana/ManaCostBeingPaid;)Ljava/util/function/Function;",16);}
case 16:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",21);}
case 21:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=24;continue;}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Int==0?41:30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=38;continue;}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{f.StackOp("dup");f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=49;continue;}
case 49:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I",value);f.Pc=52;continue;}
case 52:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7735(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","decreaseShard","(Lforge/card/mana/ManaCostShard;I)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7736(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int>0?5:4;continue;}
case 4:{return JStep.ReturnVoid;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference!=null?972:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/card/mana/ManaCostShard","isMonoColor","()Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int!=0?38:30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=34;continue;}
case 34:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?38:37;continue;}
case 37:{return JStep.ReturnVoid;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",44);}
case 44:{f.Locals[5]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/card/mana/ManaCostShard","isMonoColor","()Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?696:53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",62);}
case 62:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",67);}
case 67:{f.Locals[6]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[6]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",76);}
case 76:{f.Pc=f.Pop().Int==0?219:79;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",86);}
case 86:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=89;continue;}
case 89:{f.Locals[7]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",98);}
case 98:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=101;continue;}
case 101:{f.Locals[8]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[7]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",110);}
case 110:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=113;continue;}
case 113:{f.Locals[3]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[8]);f.Pc=116;continue;}
case 116:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","COLORED_X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","COLORED_X","Lforge/card/mana/ManaCostShard;"));f.Pc=119;continue;}
case 119:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?216:122;continue;}
case 122:{f.Push(f.Locals[8]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/card/mana/ManaCostShard","getShard","()I","invokevirtual",128);}
case 128:{return rt.Call(f,"forge/card/mana/ManaCostShard","isOfKind","(I)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int==0?216:134;continue;}
case 134:{f.Push(f.Locals[8]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/card/mana/ManaCostShard","isMultiColor","()Z","invokevirtual",139);}
case 139:{f.Pc=f.Pop().Int==0?216:142;continue;}
case 142:{f.Push(f.Locals[4]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[3]);f.Pc=145;continue;}
case 145:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=148;continue;}
case 148:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?183:151;continue;}
case 151:{f.Push(f.Locals[4]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[3]);f.Pc=154;continue;}
case 154:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=157;continue;}
case 157:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=158;continue;}
case 158:{f.Locals[4]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[3]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{f.Push(JValue.I(0));f.Pc=163;continue;}
case 163:{f.StackOp("dup_x1");f.Pc=164;continue;}
case 164:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I",value);f.Pc=167;continue;}
case 167:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[5]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[8]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",179);}
case 179:{f.StackOp("pop");f.Pc=180;continue;}
case 180:{f.Pc=216;continue;}
case 183:{f.Push(f.Locals[3]);f.Pc=184;continue;}
case 184:{f.StackOp("dup");f.Pc=185;continue;}
case 185:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=188;continue;}
case 188:{f.Push(f.Locals[4]);f.Pc=190;continue;}
case 190:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=191;continue;}
case 191:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I",value);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[3]);f.Pc=195;continue;}
case 195:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=198;continue;}
case 198:{f.Push(f.Locals[3]);f.Pc=199;continue;}
case 199:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=202;continue;}
case 202:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?219:205;continue;}
case 205:{f.Push(f.Locals[3]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[3]);f.Pc=207;continue;}
case 207:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=210;continue;}
case 210:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=213;continue;}
case 213:{f.Pc=219;continue;}
case 216:{f.Pc=69;continue;}
case 219:{f.Push(f.Locals[0]);f.Pc=220;continue;}
case 220:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",228);}
case 228:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",233);}
case 233:{f.Locals[6]=f.Pop();f.Pc=235;continue;}
case 235:{f.Push(f.Locals[6]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",242);}
case 242:{f.Pc=f.Pop().Int==0?377:245;continue;}
case 245:{f.Push(f.Locals[6]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",252);}
case 252:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=255;continue;}
case 255:{f.Locals[7]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[7]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",264);}
case 264:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=267;continue;}
case 267:{f.Locals[8]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(f.Locals[7]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",276);}
case 276:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=279;continue;}
case 279:{f.Locals[3]=f.Pop();f.Pc=280;continue;}
case 280:{f.Push(f.Locals[8]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[1]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/card/mana/ManaCostShard","getShard","()I","invokevirtual",286);}
case 286:{return rt.Call(f,"forge/card/mana/ManaCostShard","isOfKind","(I)Z","invokevirtual",289);}
case 289:{f.Pc=f.Pop().Int==0?374:292;continue;}
case 292:{f.Push(f.Locals[8]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/card/mana/ManaCostShard","isOr2Generic","()Z","invokevirtual",297);}
case 297:{f.Pc=f.Pop().Int==0?374:300;continue;}
case 300:{f.Push(f.Locals[4]);f.Pc=302;continue;}
case 302:{f.Push(f.Locals[3]);f.Pc=303;continue;}
case 303:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=306;continue;}
case 306:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?341:309;continue;}
case 309:{f.Push(f.Locals[4]);f.Pc=311;continue;}
case 311:{f.Push(f.Locals[3]);f.Pc=312;continue;}
case 312:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=315;continue;}
case 315:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=316;continue;}
case 316:{f.Locals[4]=f.Pop();f.Pc=318;continue;}
case 318:{f.Push(f.Locals[3]);f.Pc=319;continue;}
case 319:{f.Push(f.Locals[3]);f.Pc=320;continue;}
case 320:{f.Push(JValue.I(0));f.Pc=321;continue;}
case 321:{f.StackOp("dup_x1");f.Pc=322;continue;}
case 322:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I",value);f.Pc=325;continue;}
case 325:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=328;continue;}
case 328:{f.Push(f.Locals[5]);f.Pc=330;continue;}
case 330:{f.Push(f.Locals[8]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",337);}
case 337:{f.StackOp("pop");f.Pc=338;continue;}
case 338:{f.Pc=374;continue;}
case 341:{f.Push(f.Locals[3]);f.Pc=342;continue;}
case 342:{f.StackOp("dup");f.Pc=343;continue;}
case 343:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=346;continue;}
case 346:{f.Push(f.Locals[4]);f.Pc=348;continue;}
case 348:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=349;continue;}
case 349:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I",value);f.Pc=352;continue;}
case 352:{f.Push(f.Locals[3]);f.Pc=353;continue;}
case 353:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=356;continue;}
case 356:{f.Push(f.Locals[3]);f.Pc=357;continue;}
case 357:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=360;continue;}
case 360:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?377:363;continue;}
case 363:{f.Push(f.Locals[3]);f.Pc=364;continue;}
case 364:{f.Push(f.Locals[3]);f.Pc=365;continue;}
case 365:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=368;continue;}
case 368:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=371;continue;}
case 371:{f.Pc=377;continue;}
case 374:{f.Pc=235;continue;}
case 377:{f.Push(f.Locals[0]);f.Pc=378;continue;}
case 378:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=381;continue;}
case 381:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",386);}
case 386:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",391);}
case 391:{f.Locals[6]=f.Pop();f.Pc=393;continue;}
case 393:{f.Push(f.Locals[6]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",400);}
case 400:{f.Pc=f.Pop().Int==0?535:403;continue;}
case 403:{f.Push(f.Locals[6]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",410);}
case 410:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=413;continue;}
case 413:{f.Locals[7]=f.Pop();f.Pc=415;continue;}
case 415:{f.Push(f.Locals[7]);f.Pc=417;continue;}
case 417:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",422);}
case 422:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=425;continue;}
case 425:{f.Locals[8]=f.Pop();f.Pc=427;continue;}
case 427:{f.Push(f.Locals[7]);f.Pc=429;continue;}
case 429:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",434);}
case 434:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=437;continue;}
case 437:{f.Locals[3]=f.Pop();f.Pc=438;continue;}
case 438:{f.Push(f.Locals[8]);f.Pc=440;continue;}
case 440:{f.Push(f.Locals[1]);f.Pc=441;continue;}
case 441:{return rt.Call(f,"forge/card/mana/ManaCostShard","getShard","()I","invokevirtual",444);}
case 444:{return rt.Call(f,"forge/card/mana/ManaCostShard","isOfKind","(I)Z","invokevirtual",447);}
case 447:{f.Pc=f.Pop().Int==0?532:450;continue;}
case 450:{f.Push(f.Locals[8]);f.Pc=452;continue;}
case 452:{return rt.Call(f,"forge/card/mana/ManaCostShard","isColorless","()Z","invokevirtual",455);}
case 455:{f.Pc=f.Pop().Int==0?532:458;continue;}
case 458:{f.Push(f.Locals[4]);f.Pc=460;continue;}
case 460:{f.Push(f.Locals[3]);f.Pc=461;continue;}
case 461:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=464;continue;}
case 464:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?499:467;continue;}
case 467:{f.Push(f.Locals[4]);f.Pc=469;continue;}
case 469:{f.Push(f.Locals[3]);f.Pc=470;continue;}
case 470:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=473;continue;}
case 473:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=474;continue;}
case 474:{f.Locals[4]=f.Pop();f.Pc=476;continue;}
case 476:{f.Push(f.Locals[3]);f.Pc=477;continue;}
case 477:{f.Push(f.Locals[3]);f.Pc=478;continue;}
case 478:{f.Push(JValue.I(0));f.Pc=479;continue;}
case 479:{f.StackOp("dup_x1");f.Pc=480;continue;}
case 480:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I",value);f.Pc=483;continue;}
case 483:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=486;continue;}
case 486:{f.Push(f.Locals[5]);f.Pc=488;continue;}
case 488:{f.Push(f.Locals[8]);f.Pc=490;continue;}
case 490:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",495);}
case 495:{f.StackOp("pop");f.Pc=496;continue;}
case 496:{f.Pc=532;continue;}
case 499:{f.Push(f.Locals[3]);f.Pc=500;continue;}
case 500:{f.StackOp("dup");f.Pc=501;continue;}
case 501:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=504;continue;}
case 504:{f.Push(f.Locals[4]);f.Pc=506;continue;}
case 506:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=507;continue;}
case 507:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I",value);f.Pc=510;continue;}
case 510:{f.Push(f.Locals[3]);f.Pc=511;continue;}
case 511:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=514;continue;}
case 514:{f.Push(f.Locals[3]);f.Pc=515;continue;}
case 515:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=518;continue;}
case 518:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?535:521;continue;}
case 521:{f.Push(f.Locals[3]);f.Pc=522;continue;}
case 522:{f.Push(f.Locals[3]);f.Pc=523;continue;}
case 523:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=526;continue;}
case 526:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=529;continue;}
case 529:{f.Pc=535;continue;}
case 532:{f.Pc=393;continue;}
case 535:{f.Push(f.Locals[0]);f.Pc=536;continue;}
case 536:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=539;continue;}
case 539:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",544);}
case 544:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",549);}
case 549:{f.Locals[6]=f.Pop();f.Pc=551;continue;}
case 551:{f.Push(f.Locals[6]);f.Pc=553;continue;}
case 553:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",558);}
case 558:{f.Pc=f.Pop().Int==0?693:561;continue;}
case 561:{f.Push(f.Locals[6]);f.Pc=563;continue;}
case 563:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",568);}
case 568:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=571;continue;}
case 571:{f.Locals[7]=f.Pop();f.Pc=573;continue;}
case 573:{f.Push(f.Locals[7]);f.Pc=575;continue;}
case 575:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",580);}
case 580:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=583;continue;}
case 583:{f.Locals[8]=f.Pop();f.Pc=585;continue;}
case 585:{f.Push(f.Locals[7]);f.Pc=587;continue;}
case 587:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",592);}
case 592:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=595;continue;}
case 595:{f.Locals[3]=f.Pop();f.Pc=596;continue;}
case 596:{f.Push(f.Locals[8]);f.Pc=598;continue;}
case 598:{f.Push(f.Locals[1]);f.Pc=599;continue;}
case 599:{return rt.Call(f,"forge/card/mana/ManaCostShard","getShard","()I","invokevirtual",602);}
case 602:{return rt.Call(f,"forge/card/mana/ManaCostShard","isOfKind","(I)Z","invokevirtual",605);}
case 605:{f.Pc=f.Pop().Int==0?690:608;continue;}
case 608:{f.Push(f.Locals[8]);f.Pc=610;continue;}
case 610:{return rt.Call(f,"forge/card/mana/ManaCostShard","isPhyrexian","()Z","invokevirtual",613);}
case 613:{f.Pc=f.Pop().Int==0?690:616;continue;}
case 616:{f.Push(f.Locals[4]);f.Pc=618;continue;}
case 618:{f.Push(f.Locals[3]);f.Pc=619;continue;}
case 619:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=622;continue;}
case 622:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?657:625;continue;}
case 625:{f.Push(f.Locals[4]);f.Pc=627;continue;}
case 627:{f.Push(f.Locals[3]);f.Pc=628;continue;}
case 628:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=631;continue;}
case 631:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=632;continue;}
case 632:{f.Locals[4]=f.Pop();f.Pc=634;continue;}
case 634:{f.Push(f.Locals[3]);f.Pc=635;continue;}
case 635:{f.Push(f.Locals[3]);f.Pc=636;continue;}
case 636:{f.Push(JValue.I(0));f.Pc=637;continue;}
case 637:{f.StackOp("dup_x1");f.Pc=638;continue;}
case 638:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I",value);f.Pc=641;continue;}
case 641:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=644;continue;}
case 644:{f.Push(f.Locals[5]);f.Pc=646;continue;}
case 646:{f.Push(f.Locals[8]);f.Pc=648;continue;}
case 648:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",653);}
case 653:{f.StackOp("pop");f.Pc=654;continue;}
case 654:{f.Pc=690;continue;}
case 657:{f.Push(f.Locals[3]);f.Pc=658;continue;}
case 658:{f.StackOp("dup");f.Pc=659;continue;}
case 659:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=662;continue;}
case 662:{f.Push(f.Locals[4]);f.Pc=664;continue;}
case 664:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=665;continue;}
case 665:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I",value);f.Pc=668;continue;}
case 668:{f.Push(f.Locals[3]);f.Pc=669;continue;}
case 669:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=672;continue;}
case 672:{f.Push(f.Locals[3]);f.Pc=673;continue;}
case 673:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=676;continue;}
case 676:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?693:679;continue;}
case 679:{f.Push(f.Locals[3]);f.Pc=680;continue;}
case 680:{f.Push(f.Locals[3]);f.Pc=681;continue;}
case 681:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=684;continue;}
case 684:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=687;continue;}
case 687:{f.Pc=693;continue;}
case 690:{f.Pc=551;continue;}
case 693:{f.Pc=954;continue;}
case 696:{f.Push(f.Locals[1]);f.Pc=697;continue;}
case 697:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=700;continue;}
case 700:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?954:703;continue;}
case 703:{f.Push(f.Locals[4]);f.Pc=705;continue;}
case 705:{f.Push(JValue.I(2));f.Pc=706;continue;}
case 706:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=707;continue;}
case 707:{f.Locals[6]=f.Pop();f.Pc=709;continue;}
case 709:{f.Push(f.Locals[0]);f.Pc=710;continue;}
case 710:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=713;continue;}
case 713:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",718);}
case 718:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",723);}
case 723:{f.Locals[7]=f.Pop();f.Pc=725;continue;}
case 725:{f.Push(f.Locals[7]);f.Pc=727;continue;}
case 727:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",732);}
case 732:{f.Pc=f.Pop().Int==0?954:735;continue;}
case 735:{f.Push(f.Locals[7]);f.Pc=737;continue;}
case 737:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",742);}
case 742:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=745;continue;}
case 745:{f.Locals[8]=f.Pop();f.Pc=747;continue;}
case 747:{f.Push(f.Locals[8]);f.Pc=749;continue;}
case 749:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",754);}
case 754:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=757;continue;}
case 757:{f.Locals[9]=f.Pop();f.Pc=759;continue;}
case 759:{f.Push(f.Locals[8]);f.Pc=761;continue;}
case 761:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",766);}
case 766:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=769;continue;}
case 769:{f.Locals[3]=f.Pop();f.Pc=770;continue;}
case 770:{f.Push(f.Locals[9]);f.Pc=772;continue;}
case 772:{return rt.Call(f,"forge/card/mana/ManaCostShard","isOr2Generic","()Z","invokevirtual",775);}
case 775:{f.Pc=f.Pop().Int==0?863:778;continue;}
case 778:{f.Push(f.Locals[6]);f.Pc=780;continue;}
case 780:{f.Push(f.Locals[3]);f.Pc=781;continue;}
case 781:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=784;continue;}
case 784:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?830:787;continue;}
case 787:{f.Push(f.Locals[6]);f.Pc=789;continue;}
case 789:{f.Push(f.Locals[3]);f.Pc=790;continue;}
case 790:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=793;continue;}
case 793:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=794;continue;}
case 794:{f.Locals[6]=f.Pop();f.Pc=796;continue;}
case 796:{f.Push(f.Locals[4]);f.Pc=798;continue;}
case 798:{f.Push(f.Locals[3]);f.Pc=799;continue;}
case 799:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=802;continue;}
case 802:{f.Push(JValue.I(2));f.Pc=803;continue;}
case 803:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=804;continue;}
case 804:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=805;continue;}
case 805:{f.Locals[4]=f.Pop();f.Pc=807;continue;}
case 807:{f.Push(f.Locals[3]);f.Pc=808;continue;}
case 808:{f.Push(f.Locals[3]);f.Pc=809;continue;}
case 809:{f.Push(JValue.I(0));f.Pc=810;continue;}
case 810:{f.StackOp("dup_x1");f.Pc=811;continue;}
case 811:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I",value);f.Pc=814;continue;}
case 814:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=817;continue;}
case 817:{f.Push(f.Locals[5]);f.Pc=819;continue;}
case 819:{f.Push(f.Locals[9]);f.Pc=821;continue;}
case 821:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",826);}
case 826:{f.StackOp("pop");f.Pc=827;continue;}
case 827:{f.Pc=951;continue;}
case 830:{f.Push(f.Locals[3]);f.Pc=831;continue;}
case 831:{f.StackOp("dup");f.Pc=832;continue;}
case 832:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=835;continue;}
case 835:{f.Push(f.Locals[6]);f.Pc=837;continue;}
case 837:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=838;continue;}
case 838:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I",value);f.Pc=841;continue;}
case 841:{f.Push(f.Locals[3]);f.Pc=842;continue;}
case 842:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=845;continue;}
case 845:{f.Push(f.Locals[3]);f.Pc=846;continue;}
case 846:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=849;continue;}
case 849:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?954:852;continue;}
case 852:{f.Push(f.Locals[3]);f.Pc=853;continue;}
case 853:{f.Push(f.Locals[3]);f.Pc=854;continue;}
case 854:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=857;continue;}
case 857:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=860;continue;}
case 860:{f.Pc=954;continue;}
case 863:{f.Push(f.Locals[3]);f.Pc=864;continue;}
case 864:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=867;continue;}
case 867:{f.Pc=f.Pop().Int<=0?951:870;continue;}
case 870:{f.Push(f.Locals[4]);f.Pc=872;continue;}
case 872:{f.Push(f.Locals[3]);f.Pc=873;continue;}
case 873:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=876;continue;}
case 876:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?926:879;continue;}
case 879:{f.Push(f.Locals[4]);f.Pc=881;continue;}
case 881:{f.Push(f.Locals[3]);f.Pc=882;continue;}
case 882:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=885;continue;}
case 885:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=886;continue;}
case 886:{f.Locals[4]=f.Pop();f.Pc=888;continue;}
case 888:{f.Push(f.Locals[3]);f.Pc=889;continue;}
case 889:{f.StackOp("dup");f.Pc=890;continue;}
case 890:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=893;continue;}
case 893:{f.Push(f.Locals[3]);f.Pc=894;continue;}
case 894:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=897;continue;}
case 897:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=898;continue;}
case 898:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I",value);f.Pc=901;continue;}
case 901:{f.Push(f.Locals[3]);f.Pc=902;continue;}
case 902:{f.Push(JValue.I(0));f.Pc=903;continue;}
case 903:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=906;continue;}
case 906:{f.Push(f.Locals[3]);f.Pc=907;continue;}
case 907:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=910;continue;}
case 910:{f.Pc=f.Pop().Int!=0?951:913;continue;}
case 913:{f.Push(f.Locals[5]);f.Pc=915;continue;}
case 915:{f.Push(f.Locals[9]);f.Pc=917;continue;}
case 917:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",922);}
case 922:{f.StackOp("pop");f.Pc=923;continue;}
case 923:{f.Pc=951;continue;}
case 926:{f.Push(f.Locals[3]);f.Pc=927;continue;}
case 927:{f.StackOp("dup");f.Pc=928;continue;}
case 928:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=931;continue;}
case 931:{f.Push(f.Locals[4]);f.Pc=933;continue;}
case 933:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=934;continue;}
case 934:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I",value);f.Pc=937;continue;}
case 937:{f.Push(f.Locals[3]);f.Pc=938;continue;}
case 938:{f.StackOp("dup");f.Pc=939;continue;}
case 939:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=942;continue;}
case 942:{f.Push(f.Locals[4]);f.Pc=944;continue;}
case 944:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=945;continue;}
case 945:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=948;continue;}
case 948:{f.Pc=954;continue;}
case 951:{f.Pc=725;continue;}
case 954:{f.Push(f.Locals[0]);f.Pc=955;continue;}
case 955:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=958;continue;}
case 958:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",963);}
case 963:{f.Push(f.Locals[5]);f.Pc=965;continue;}
case 965:{return rt.Call(f,"java/util/Set","removeAll","(Ljava/util/Collection;)Z","invokeinterface",970);}
case 970:{f.StackOp("pop");f.Pc=971;continue;}
case 971:{return JStep.ReturnVoid;}
case 972:{f.Push(f.Locals[2]);f.Pc=973;continue;}
case 973:{f.Push(f.Locals[3]);f.Pc=974;continue;}
case 974:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=977;continue;}
case 977:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=978;continue;}
case 978:{f.Locals[4]=f.Pop();f.Pc=980;continue;}
case 980:{f.Push(f.Locals[2]);f.Pc=981;continue;}
case 981:{f.Push(f.Locals[3]);f.Pc=982;continue;}
case 982:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=985;continue;}
case 985:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?1017:988;continue;}
case 988:{f.Push(f.Locals[3]);f.Pc=989;continue;}
case 989:{f.Push(JValue.I(0));f.Pc=990;continue;}
case 990:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=993;continue;}
case 993:{f.Push(f.Locals[3]);f.Pc=994;continue;}
case 994:{f.Push(JValue.I(0));f.Pc=995;continue;}
case 995:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I",value);f.Pc=998;continue;}
case 998:{f.Push(f.Locals[0]);f.Pc=999;continue;}
case 999:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=1002;continue;}
case 1002:{f.Push(f.Locals[1]);f.Pc=1003;continue;}
case 1003:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1008);}
case 1008:{f.StackOp("pop");f.Pc=1009;continue;}
case 1009:{f.Push(f.Locals[0]);f.Pc=1010;continue;}
case 1010:{f.Push(f.Locals[1]);f.Pc=1011;continue;}
case 1011:{f.Push(f.Locals[4]);f.Pc=1013;continue;}
case 1013:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","decreaseShard","(Lforge/card/mana/ManaCostShard;I)V","invokevirtual",1016);}
case 1016:{return JStep.ReturnVoid;}
case 1017:{f.Push(f.Locals[3]);f.Pc=1018;continue;}
case 1018:{f.StackOp("dup");f.Pc=1019;continue;}
case 1019:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=1022;continue;}
case 1022:{f.Push(f.Locals[2]);f.Pc=1023;continue;}
case 1023:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=1024;continue;}
case 1024:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I",value);f.Pc=1027;continue;}
case 1027:{f.Push(f.Locals[3]);f.Pc=1028;continue;}
case 1028:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=1031;continue;}
case 1031:{f.Push(f.Locals[3]);f.Pc=1032;continue;}
case 1032:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=1035;continue;}
case 1035:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1046:1038;continue;}
case 1038:{f.Push(f.Locals[3]);f.Pc=1039;continue;}
case 1039:{f.Push(f.Locals[3]);f.Pc=1040;continue;}
case 1040:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=1043;continue;}
case 1043:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=1046;continue;}
case 1046:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7737(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{f.Locals[1]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Reference==null?25:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7738(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(Ljava/lang/String;)B","invokestatic",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","isAnyPartPayableWith","(BLforge/game/mana/ManaPool;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.DynamicCall(f,"forge/game/mana/ManaCostBeingPaid:7738:19:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/mana/ManaCostBeingPaid;BLforge/game/mana/ManaPool;)Ljava/util/function/Predicate;",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",37);}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/util/Collection;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",42);}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/mana/ManaPool","getPossibleColorUses","(B)B","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","tryPayMana","(BLjava/lang/Iterable;B)Lforge/card/mana/ManaCostShard;","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Reference==null?57:53;continue;}
case 53:{f.Push(JValue.I(1));f.Pc=54;continue;}
case 54:{f.Pc=58;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7739(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","isNeeded","(Lforge/game/mana/Mana;Lforge/game/mana/ManaPool;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int!=0?26:9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",17);}
case 17:{return rt.DynamicCall(f,"forge/game/mana/ManaCostBeingPaid:7739:17:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",22);}
case 22:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",25);}
case 25:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.DynamicCall(f,"forge/game/mana/ManaCostBeingPaid:7739:29:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/mana/Mana;Lforge/game/mana/ManaPool;)Ljava/util/function/Predicate;",34);}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",39);}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/mana/ManaPool","getPossibleColorUses","(B)B","invokevirtual",47);}
case 47:{f.Locals[5]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",61);}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/util/Collection;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",65);}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","tryPayMana","(BLjava/lang/Iterable;B)Lforge/card/mana/ManaCostShard;","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Reference==null?77:73;continue;}
case 73:{f.Push(JValue.I(1));f.Pc=74;continue;}
case 74:{f.Pc=78;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7740(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/mana/ManaCostBeingPaid:7740:1:java/lang/invoke/LambdaMetafactory.metafactory","(B)Ljava/util/function/Predicate;",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",18);}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/util/Collection;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",22);}
case 22:{f.Push(JValue.I(-1));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","tryPayMana","(BLjava/lang/Iterable;B)Lforge/card/mana/ManaCostShard;","invokevirtual",26);}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7741(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(JValue.I(int.MinValue));f.Pc=7;continue;}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[5]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[5]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?83:27;continue;}
case 27:{f.Push(f.Locals[5]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[6]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[6]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","getPayPriority","(Lforge/card/mana/ManaCostShard;B)I","invokestatic",45);}
case 45:{f.Locals[7]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[7]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?64:54;continue;}
case 54:{f.Push(f.Locals[7]);f.Pc=56;continue;}
case 56:{f.Locals[4]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",64);}
case 64:{f.Push(f.Locals[7]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?80:71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{f.Pc=17;continue;}
case 83:{f.Push(f.Locals[3]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",89);}
case 89:{f.Pc=f.Pop().Int==0?94:92;continue;}
case 92:{f.Push(JValue.R(null));f.Pc=93;continue;}
case 93:{return JStep.Return(f.Pop());}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(null));f.Pc=96;continue;}
case 96:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",99);}
case 99:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=102;continue;}
case 102:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7742(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","getShardToPayByPriority","(Ljava/lang/Iterable;B)Lforge/card/mana/ManaCostShard;","invokevirtual",6);}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[4]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference!=null?15:13;continue;}
case 13:{f.Push(JValue.R(null));f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Reference==null?96:36;continue;}
case 36:{f.Push(f.Locals[5]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=41;continue;}
case 41:{f.Pc=f.Pop().Int<=0?96:44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{f.StackOp("dup");f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=52;continue;}
case 52:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",59);}
case 59:{f.Locals[6]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","xManaCostPaidByColor","Ljava/util/Map;"));f.Pc=65;continue;}
case 65:{f.Pc=f.Pop().Reference!=null?75:68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",72);}
case 72:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","xManaCostPaidByColor","Ljava/util/Map;",value);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","xManaCostPaidByColor","Ljava/util/Map;"));f.Pc=79;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{f.Push(JValue.I(1));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",85);}
case 85:{return rt.DynamicCall(f,"forge/game/mana/ManaCostBeingPaid:7742:85:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BiFunction;",90);}
case 90:{return rt.Call(f,"java/util/Map","merge","(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;","invokeinterface",95);}
case 95:{f.StackOp("pop");f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{f.Push(JValue.I(1));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","decreaseShard","(Lforge/card/mana/ManaCostShard;I)V","invokevirtual",103);}
case 103:{f.Push(f.Locals[4]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/card/mana/ManaCostShard","isOr2Generic","()Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int==0?127:111;continue;}
case 111:{f.Push(JValue.I(0));f.Pc=112;continue;}
case 112:{f.Push(f.Locals[4]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/card/mana/ManaCostShard","getColorMask","()B","invokevirtual",117);}
case 117:{f.Push(f.Locals[3]);f.Pc=118;continue;}
case 118:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=119;continue;}
case 119:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?127:122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{f.Push(JValue.I(1));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","increaseGenericMana","(I)V","invokevirtual",127);}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{f.StackOp("dup");f.Pc=129;continue;}
case 129:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","sunburstMap","B"));f.Pc=132;continue;}
case 132:{f.Push(f.Locals[1]);f.Pc=133;continue;}
case 133:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=134;continue;}
case 134:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=135;continue;}
case 135:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","sunburstMap","B",value);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[4]);f.Pc=140;continue;}
case 140:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7743(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?9:7;continue;}
case 7:{f.Push(JValue.I(2));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/card/mana/ManaCostShard","isMonoColor","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?58:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/card/mana/ManaCostShard","isOr2Generic","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?45:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/card/mana/ManaCostShard","getColorMask","()B","invokevirtual",27);}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",32);}
case 32:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int!=0?43:38;continue;}
case 38:{f.Push(JValue.I(9));f.Pc=40;continue;}
case 40:{f.Pc=44;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/card/mana/ManaCostShard","isPhyrexian","()Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int==0?55:52;continue;}
case 52:{f.Push(JValue.I(8));f.Pc=54;continue;}
case 54:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 55:{f.Push(JValue.I(10));f.Pc=57;continue;}
case 57:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 58:{f.Push(JValue.I(5));f.Pc=59;continue;}
case 59:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7744(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?16:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{f.Pc=f.Pop().Reference==null?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7745(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/mana/ManaCostShard","isSnow","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?16:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/mana/Mana","isSnow","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/mana/Mana","isRestricted","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?40:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/mana/Mana","getManaAbility","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",32);}
case 32:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","meetsManaShardRestrictions","(Lforge/card/mana/ManaCostShard;B)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int!=0?40:38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/card/mana/ManaCostShard","getColorMask","()B","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?63:47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/mana/Mana","isSnow","()Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?63:54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/mana/ManaPool","isSnowForColor","()Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?63:61;continue;}
case 61:{f.Push(JValue.I(1));f.Pc=62;continue;}
case 62:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","COLORED_X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","COLORED_X","Lforge/card/mana/ManaCostShard;"));f.Pc=67;continue;}
case 67:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?86:70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",74);}
case 74:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",77);}
case 77:{f.Push(f.Locals[3]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","canColoredXShardBePaidByColor","(Ljava/lang/String;Ljava/util/Map;)Z","invokestatic",81);}
case 81:{f.Pc=f.Pop().Int!=0?86:84;continue;}
case 84:{f.Push(JValue.I(0));f.Pc=85;continue;}
case 85:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",90);}
case 90:{f.Locals[4]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[4]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/mana/ManaPool","canPayForShardWithColor","(Lforge/card/mana/ManaCostShard;B)Z","invokevirtual",99);}
case 99:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7746(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/mana/ManaCost","iterator","()Ljava/util/Iterator;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",11);}
case 11:{f.Pc=f.Pop().Int==0?54:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",20);}
case 20:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=23;continue;}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"));f.Pc=28;continue;}
case 28:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?44:31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I"));f.Pc=36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=38;continue;}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I",value);f.Pc=41;continue;}
case 41:{f.Pc=51;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(1));f.Pc=47;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","increaseShard","(Lforge/card/mana/ManaCostShard;IZ)V","invokevirtual",51);}
case 51:{f.Pc=5;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/card/mana/ManaCost","getGenericCost","()I","invokevirtual",59);}
case 59:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","increaseGenericMana","(I)V","invokevirtual",62);}
case 62:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7747(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/mana/ManaCost","iterator","()Ljava/util/Iterator;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",11);}
case 11:{f.Pc=f.Pop().Int==0?77:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",20);}
case 20:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=23;continue;}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"));f.Pc=28;continue;}
case 28:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?44:31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I"));f.Pc=36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=38;continue;}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I",value);f.Pc=41;continue;}
case 41:{f.Pc=74;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Int==0?66:57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{f.Push(JValue.I(1));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","decreaseShard","(Lforge/card/mana/ManaCostShard;I)V","invokevirtual",63);}
case 63:{f.Pc=74;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/card/mana/ManaCostShard","getCmc","()I","invokevirtual",71);}
case 71:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","decreaseGenericMana","(I)V","invokevirtual",74);}
case 74:{f.Pc=5;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/card/mana/ManaCost","getGenericCost","()I","invokevirtual",82);}
case 82:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","decreaseGenericMana","(I)V","invokevirtual",85);}
case 85:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7748(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Int==0?38:12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","getXcounter","()I","invokevirtual",21);}
case 21:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?38:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("{X}")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",31);}
case 31:{f.StackOp("pop");f.Pc=32;continue;}
case 32:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=35;continue;}
case 35:{f.Pc=15;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","getGenericManaAmount","()I","invokevirtual",42);}
case 42:{f.Locals[4]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",53);}
case 53:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",56);}
case 56:{f.Locals[5]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{f.Pc=f.Pop().Int<=0?142:63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{f.Push(JValue.I(20));f.Pc=67;continue;}
case 67:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?92:70;continue;}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("{")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",77);}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",82);}
case 82:{f.Push(JValue.R(rt.String("}")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",88);}
case 88:{f.StackOp("pop");f.Pc=89;continue;}
case 89:{f.Pc=142;continue;}
case 92:{f.Push(f.Locals[4]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",97);}
case 97:{f.Locals[6]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{f.Locals[7]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[7]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[6]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",109);}
case 109:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?142:112;continue;}
case 112:{f.Push(f.Locals[3]);f.Pc=113;continue;}
case 113:{f.Push(JValue.R(rt.String("{")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",119);}
case 119:{f.Push(f.Locals[6]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[7]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",126);}
case 126:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",129);}
case 129:{f.Push(JValue.R(rt.String("}")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",135);}
case 135:{f.StackOp("pop");f.Pc=136;continue;}
case 136:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=139;continue;}
case 139:{f.Pc=102;continue;}
case 142:{f.Push(f.Locals[5]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Collections","sort","(Ljava/util/List;)V","invokestatic",147);}
case 147:{f.Push(f.Locals[5]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",154);}
case 154:{f.Locals[6]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[6]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",163);}
case 163:{f.Pc=f.Pop().Int==0?241:166;continue;}
case 166:{f.Push(f.Locals[6]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",173);}
case 173:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=176;continue;}
case 176:{f.Locals[7]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[7]);f.Pc=180;continue;}
case 180:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=183;continue;}
case 183:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?189:186;continue;}
case 186:{f.Pc=156;continue;}
case 189:{f.Push(f.Locals[7]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/card/mana/ManaCostShard","toString","()Ljava/lang/String;","invokevirtual",194);}
case 194:{f.Locals[8]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=200;continue;}
case 200:{f.Push(f.Locals[7]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",207);}
case 207:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=210;continue;}
case 210:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=213;continue;}
case 213:{f.Locals[9]=f.Pop();f.Pc=215;continue;}
case 215:{f.Push(JValue.I(0));f.Pc=216;continue;}
case 216:{f.Locals[10]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[10]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[9]);f.Pc=222;continue;}
case 222:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?238:225;continue;}
case 225:{f.Push(f.Locals[3]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[8]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",231);}
case 231:{f.StackOp("pop");f.Pc=232;continue;}
case 232:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=235;continue;}
case 235:{f.Pc=218;continue;}
case 238:{f.Pc=156;continue;}
case 241:{f.Push(f.Locals[3]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",245);}
case 245:{f.Pc=f.Pop().Int!=0?254:248;continue;}
case 248:{f.Push(JValue.R(rt.String("0")));f.Pc=251;continue;}
case 251:{f.Pc=258;continue;}
case 254:{f.Push(f.Locals[3]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",258);}
case 258:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7749(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","toString","(ZLforge/game/mana/ManaPool;)Ljava/lang/String;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7750(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",11);}
case 11:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?67:26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/card/mana/ManaCostShard","getCmc","()I","invokevirtual",49);}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",55);}
case 55:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=61;continue;}
case 61:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=62;continue;}
case 62:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=63;continue;}
case 63:{f.Locals[1]=f.Pop();f.Pc=64;continue;}
case 64:{f.Pc=17;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7751(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid$ManaCostBeingPaidIterator","<init>","(Lforge/game/mana/ManaCostBeingPaid;)V","invokespecial",12);}
case 12:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Lforge/card/mana/IParserManaCost;)V","invokespecial",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7752(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7753(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",17);}
case 17:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?86:32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=54;continue;}
case 54:{f.Locals[4]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{f.Pc=f.Pop().Int<=0?83:61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",68);}
case 68:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",76);}
case 76:{f.StackOp("pop");f.Pc=77;continue;}
case 77:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(-1)));f.Pc=80;continue;}
case 80:{f.Pc=56;continue;}
case 83:{f.Pc=23;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","cntX","I"));f.Pc=90;continue;}
case 90:{f.Locals[2]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{f.Pc=f.Pop().Int<=0?111:95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",104);}
case 104:{f.StackOp("pop");f.Pc=105;continue;}
case 105:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(-1)));f.Pc=108;continue;}
case 108:{f.Pc=91;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7754(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{f.StackOp("pop");f.Pc=13;continue;}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7755(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7756(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference==null?23:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7757(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",11);}
case 11:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?47:26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/card/mana/ManaCostShard","getColorMask","()B","invokevirtual",41);}
case 41:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=42;continue;}
case 42:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=43;continue;}
case 43:{f.Locals[1]=f.Pop();f.Pc=44;continue;}
case 44:{f.Pc=17;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7758(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","unpaidShards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?82:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/card/mana/ManaCostShard","isOfKind","(I)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?79:50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",68);}
case 68:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/ManaCostBeingPaid$ShardCount"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=74;continue;}
case 74:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?79:77;continue;}
case 77:{f.Push(JValue.I(1));f.Pc=78;continue;}
case 78:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 79:{f.Pc=15;continue;}
case 82:{f.Push(JValue.I(0));f.Pc=83;continue;}
case 83:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7759(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/mana/ManaCostShard","isSnow","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?26:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/mana/ManaCostShard","isColorless","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?26:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/mana/ManaCostShard","canBePaidWithManaOfColor","(B)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?26:22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{f.Pc=27;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7760(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","xManaCostPaidByColor","Ljava/util/Map;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","canBePaidWith","(Lforge/card/mana/ManaCostShard;Lforge/game/mana/Mana;Lforge/game/mana/ManaPool;Ljava/util/Map;)Z","invokestatic",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7761(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","COLORED_X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","COLORED_X","Lforge/card/mana/ManaCostShard;"));f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?23:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid","xManaCostPaidByColor","Ljava/util/Map;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","canColoredXShardBePaidByColor","(Ljava/lang/String;Ljava/util/Map;)Z","invokestatic",18);}
case 18:{f.Pc=f.Pop().Int!=0?23:21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/mana/ManaPool","canPayForShardWithColor","(Lforge/card/mana/ManaCostShard;B)Z","invokevirtual",29);}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7762(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/mana/ManaCostBeingPaid$ShardCount"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/ManaCostBeingPaid$ShardCount")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid$ShardCount","<init>","(Lforge/game/mana/ManaCostBeingPaid;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
