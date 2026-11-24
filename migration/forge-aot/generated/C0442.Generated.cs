// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C442{
internal static JClass Build(){var c=new JClass("forge/game/card/CardChangedWords","com/google/common/collect/ForwardingMap",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("map","Lcom/google/common/collect/Table;",false,JValue.Default("Lcom/google/common/collect/Table;"),null));
c.Add(new JField("isDirty","Z",false,JValue.Default("Z"),null));
c.Add(new JField("resultCache","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(4887,"forge/game/card/CardChangedWords","<init>","()V",1,1,2,new JHandler[]{},M4887));
c.Add(new JMethod(4888,"forge/game/card/CardChangedWords","addEmpty","(JJ)Ljava/lang/Long;",1,6,6,new JHandler[]{},M4888));
c.Add(new JMethod(4889,"forge/game/card/CardChangedWords","add","(JJLjava/lang/String;Ljava/lang/String;)Ljava/lang/Long;",1,8,8,new JHandler[]{},M4889));
c.Add(new JMethod(4890,"forge/game/card/CardChangedWords","remove","(Ljava/lang/Long;J)Z",1,4,4,new JHandler[]{},M4890));
c.Add(new JMethod(4891,"forge/game/card/CardChangedWords","clear","()V",1,1,2,new JHandler[]{},M4891));
c.Add(new JMethod(4892,"forge/game/card/CardChangedWords","copyFrom","(Lforge/game/card/CardChangedWords;)V",0,2,2,new JHandler[]{},M4892));
c.Add(new JMethod(4893,"forge/game/card/CardChangedWords","delegate","()Ljava/util/Map;",4,1,1,new JHandler[]{},M4893));
c.Add(new JMethod(4894,"forge/game/card/CardChangedWords","refreshCache","()V",2,6,3,new JHandler[]{},M4894));
c.Add(new JMethod(4895,"forge/game/card/CardChangedWords","delegate","()Ljava/lang/Object;",4164,1,1,new JHandler[]{},M4895));
}

internal static JStep M4887(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/ForwardingMap","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/TreeBasedTable","create","()Lcom/google/common/collect/TreeBasedTable;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardChangedWords","map","Lcom/google/common/collect/Table;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardChangedWords","isDirty","Z",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",20);}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardChangedWords","resultCache","Ljava/util/Map;",value);f.Pc=23;continue;}
case 23:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4888(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords","map","Lcom/google/common/collect/Table;"));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[5]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",16);}
case 16:{if(!rt.EnsureInitialized(f,"forge/game/card/CardChangedWords$WordHolder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardChangedWords$WordHolder")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/CardChangedWords$WordHolder","<init>","(Lforge/game/card/CardChangedWords;)V","invokespecial",24);}
case 24:{return rt.Call(f,"com/google/common/collect/Table","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardChangedWords","isDirty","Z",value);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4889(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",4);}
case 4:{f.Locals[7]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords","map","Lcom/google/common/collect/Table;"));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[7]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",16);}
case 16:{if(!rt.EnsureInitialized(f,"forge/game/card/CardChangedWords$WordHolder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardChangedWords$WordHolder")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[5]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[6]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/CardChangedWords$WordHolder","<init>","(Lforge/game/card/CardChangedWords;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",28);}
case 28:{return rt.Call(f,"com/google/common/collect/Table","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(JValue.I(1));f.Pc=36;continue;}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardChangedWords","isDirty","Z",value);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[7]);f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4890(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardChangedWords","isDirty","Z",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords","map","Lcom/google/common/collect/Table;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",14);}
case 14:{return rt.Call(f,"com/google/common/collect/Table","remove","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Reference==null?26:22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{f.Pc=27;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4891(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/ForwardingMap","clear","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords","map","Lcom/google/common/collect/Table;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"com/google/common/collect/Table","clear","()V","invokeinterface",13);}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardChangedWords","isDirty","Z",value);f.Pc=18;continue;}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4892(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords","map","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Table","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords","map","Lcom/google/common/collect/Table;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords","map","Lcom/google/common/collect/Table;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"com/google/common/collect/Table","putAll","(Lcom/google/common/collect/Table;)V","invokeinterface",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardChangedWords","isDirty","Z",value);f.Pc=27;continue;}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4893(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardChangedWords","refreshCache","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords","resultCache","Ljava/util/Map;"));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4894(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords","isDirty","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?191:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords","resultCache","Ljava/util/Map;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords","map","Lcom/google/common/collect/Table;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"com/google/common/collect/Table","values","()Ljava/util/Collection;","invokeinterface",25);}
case 25:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",30);}
case 30:{f.Locals[1]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?186:40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardChangedWords$WordHolder"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[2]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords$WordHolder","clear","Z"));f.Pc=54;continue;}
case 54:{f.Pc=f.Pop().Int==0?69:57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords","resultCache","Ljava/util/Map;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",66);}
case 66:{f.Pc=31;continue;}
case 69:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",72);}
case 72:{f.Locals[3]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords","resultCache","Ljava/util/Map;"));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",82);}
case 82:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",87);}
case 87:{f.Locals[4]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",96);}
case 96:{f.Pc=f.Pop().Int==0?155:99;continue;}
case 99:{f.Push(f.Locals[4]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",106);}
case 106:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=109;continue;}
case 109:{f.Locals[5]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[5]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",118);}
case 118:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords$WordHolder","oldWord","Ljava/lang/String;"));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int==0?152:131;continue;}
case 131:{f.Push(f.Locals[3]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[5]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",139);}
case 139:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[2]);f.Pc=143;continue;}
case 143:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords$WordHolder","newWord","Ljava/lang/String;"));f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",151);}
case 151:{f.StackOp("pop");f.Pc=152;continue;}
case 152:{f.Pc=89;continue;}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords","resultCache","Ljava/util/Map;"));f.Pc=159;continue;}
case 159:{f.Push(f.Locals[3]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",165);}
case 165:{f.Push(f.Locals[0]);f.Pc=166;continue;}
case 166:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords","resultCache","Ljava/util/Map;"));f.Pc=169;continue;}
case 169:{f.Push(f.Locals[2]);f.Pc=170;continue;}
case 170:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords$WordHolder","oldWord","Ljava/lang/String;"));f.Pc=173;continue;}
case 173:{f.Push(f.Locals[2]);f.Pc=174;continue;}
case 174:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardChangedWords$WordHolder","newWord","Ljava/lang/String;"));f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",182);}
case 182:{f.StackOp("pop");f.Pc=183;continue;}
case 183:{f.Pc=31;continue;}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{f.Push(JValue.I(0));f.Pc=188;continue;}
case 188:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardChangedWords","isDirty","Z",value);f.Pc=191;continue;}
case 191:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4895(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardChangedWords","delegate","()Ljava/util/Map;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
