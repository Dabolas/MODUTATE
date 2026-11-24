// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C78{
internal static JClass Build(){var c=new JClass("forge/card/mana/ManaCost","java/lang/Object",new string[]{"java/lang/Comparable","java/lang/Iterable","java/io/Serializable","java/lang/Cloneable"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-2477430496624149226L),null));
c.Add(new JField("DELIM","C",true,JValue.I(6),null));
c.Add(new JField("shards","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("genericCost","I",false,JValue.Default("I"),null));
c.Add(new JField("hasNoCost","Z",false,JValue.Default("Z"),null));
c.Add(new JField("stringValue","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("compareWeight","Ljava/lang/Float;",false,JValue.Default("Ljava/lang/Float;"),null));
c.Add(new JField("NO_COST","Lforge/card/mana/ManaCost;",true,JValue.Default("Lforge/card/mana/ManaCost;"),null));
c.Add(new JField("ZERO","Lforge/card/mana/ManaCost;",true,JValue.Default("Lforge/card/mana/ManaCost;"),null));
c.Add(new JField("ONE","Lforge/card/mana/ManaCost;",true,JValue.Default("Lforge/card/mana/ManaCost;"),null));
c.Add(new JField("TWO","Lforge/card/mana/ManaCost;",true,JValue.Default("Lforge/card/mana/ManaCost;"),null));
c.Add(new JField("THREE","Lforge/card/mana/ManaCost;",true,JValue.Default("Lforge/card/mana/ManaCost;"),null));
c.Add(new JField("FOUR","Lforge/card/mana/ManaCost;",true,JValue.Default("Lforge/card/mana/ManaCost;"),null));
c.Add(new JMethod(1201,"forge/card/mana/ManaCost","get","(I)Lforge/card/mana/ManaCost;",9,1,3,new JHandler[]{},M1201));
c.Add(new JMethod(1202,"forge/card/mana/ManaCost","<init>","(I)V",2,2,2,new JHandler[]{},M1202));
c.Add(new JMethod(1203,"forge/card/mana/ManaCost","<init>","(ILjava/util/List;)V",2,3,2,new JHandler[]{},M1203));
c.Add(new JMethod(1204,"forge/card/mana/ManaCost","sealClass","(Ljava/util/List;)V",2,2,2,new JHandler[]{},M1204));
c.Add(new JMethod(1205,"forge/card/mana/ManaCost","<init>","(Lforge/card/mana/IParserManaCost;)V",1,5,3,new JHandler[]{},M1205));
c.Add(new JMethod(1206,"forge/card/mana/ManaCost","<init>","(Ljava/lang/String;)V",1,2,4,new JHandler[]{},M1206));
c.Add(new JMethod(1207,"forge/card/mana/ManaCost","getSimpleString","()Ljava/lang/String;",1,4,3,new JHandler[]{},M1207));
c.Add(new JMethod(1208,"forge/card/mana/ManaCost","getCMC","()I",1,4,2,new JHandler[]{},M1208));
c.Add(new JMethod(1209,"forge/card/mana/ManaCost","getColorProfile","()B",1,4,2,new JHandler[]{},M1209));
c.Add(new JMethod(1210,"forge/card/mana/ManaCost","getShardCount","(Lforge/card/mana/ManaCostShard;)I",1,5,2,new JHandler[]{},M1210));
c.Add(new JMethod(1211,"forge/card/mana/ManaCost","getColorShardCounts","()[I",1,4,4,new JHandler[]{},M1211));
c.Add(new JMethod(1212,"forge/card/mana/ManaCost","getGenericCost","()I",1,1,1,new JHandler[]{},M1212));
c.Add(new JMethod(1213,"forge/card/mana/ManaCost","isNoCost","()Z",1,1,1,new JHandler[]{},M1213));
c.Add(new JMethod(1214,"forge/card/mana/ManaCost","isPureGeneric","()Z",1,1,1,new JHandler[]{},M1214));
c.Add(new JMethod(1215,"forge/card/mana/ManaCost","isZero","()Z",1,1,1,new JHandler[]{},M1215));
c.Add(new JMethod(1216,"forge/card/mana/ManaCost","compareTo","(Lforge/card/mana/ManaCost;)I",1,2,2,new JHandler[]{},M1216));
c.Add(new JMethod(1217,"forge/card/mana/ManaCost","getCompareWeight","()Ljava/lang/Float;",2,4,2,new JHandler[]{},M1217));
c.Add(new JMethod(1218,"forge/card/mana/ManaCost","serialize","(Lforge/card/mana/ManaCost;)Ljava/lang/String;",9,4,2,new JHandler[]{},M1218));
c.Add(new JMethod(1219,"forge/card/mana/ManaCost","deserialize","(Ljava/lang/String;)Lforge/card/mana/ManaCost;",9,5,4,new JHandler[]{},M1219));
c.Add(new JMethod(1220,"forge/card/mana/ManaCost","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1220));
c.Add(new JMethod(1221,"forge/card/mana/ManaCost","getShortString","()Ljava/lang/String;",1,5,2,new JHandler[]{},M1221));
c.Add(new JMethod(1222,"forge/card/mana/ManaCost","hasPhyrexian","()Z",1,3,1,new JHandler[]{},M1222));
c.Add(new JMethod(1223,"forge/card/mana/ManaCost","getPhyrexianCount","()I",1,4,1,new JHandler[]{},M1223));
c.Add(new JMethod(1224,"forge/card/mana/ManaCost","hasMultiColor","()Z",1,3,1,new JHandler[]{},M1224));
c.Add(new JMethod(1225,"forge/card/mana/ManaCost","hasHybrid","()Z",1,3,1,new JHandler[]{},M1225));
c.Add(new JMethod(1226,"forge/card/mana/ManaCost","getNormalizedMana","()Lforge/card/mana/ManaCost;",1,4,4,new JHandler[]{},M1226));
c.Add(new JMethod(1227,"forge/card/mana/ManaCost","countX","()I",1,1,2,new JHandler[]{},M1227));
c.Add(new JMethod(1228,"forge/card/mana/ManaCost","canBePaidWithAvailable","(B)Z",1,4,2,new JHandler[]{},M1228));
c.Add(new JMethod(1229,"forge/card/mana/ManaCost","combine","(Lforge/card/mana/ManaCost;Lforge/card/mana/ManaCost;)Lforge/card/mana/ManaCost;",9,4,4,new JHandler[]{},M1229));
c.Add(new JMethod(1230,"forge/card/mana/ManaCost","iterator","()Ljava/util/Iterator;",1,1,1,new JHandler[]{},M1230));
c.Add(new JMethod(1231,"forge/card/mana/ManaCost","getGlyphCount","()I",1,2,1,new JHandler[]{},M1231));
c.Add(new JMethod(1232,"forge/card/mana/ManaCost","compareTo","(Ljava/lang/Object;)I",4161,2,2,new JHandler[]{},M1232));
c.Add(new JMethod(1233,"forge/card/mana/ManaCost","<clinit>","()V",8,0,3,new JHandler[]{},M1233));
}

internal static JStep M1201(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{switch(f.Pop().Int){case 0:f.Pc=36;break;case 1:f.Pc=40;break;case 2:f.Pc=44;break;case 3:f.Pc=48;break;case 4:f.Pc=52;break;default:f.Pc=56;break;}continue;}
case 36:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"));f.Pc=39;continue;}
case 39:{return JStep.Return(f.Pop());}
case 40:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","ONE","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","ONE","Lforge/card/mana/ManaCost;"));f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
case 44:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","TWO","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","TWO","Lforge/card/mana/ManaCost;"));f.Pc=47;continue;}
case 47:{return JStep.Return(f.Pop());}
case 48:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","THREE","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","THREE","Lforge/card/mana/ManaCost;"));f.Pc=51;continue;}
case 51:{return JStep.Return(f.Pop());}
case 52:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","FOUR","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","FOUR","Lforge/card/mana/ManaCost;"));f.Pc=55;continue;}
case 55:{return JStep.Return(f.Pop());}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Pc=f.Pop().Int<=0?71:60;continue;}
case 60:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(I)V","invokespecial",68);}
case 68:{f.Pc=74;continue;}
case 71:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","NO_COST","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","NO_COST","Lforge/card/mana/ManaCost;"));f.Pc=74;continue;}
case 74:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1202(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCost","compareWeight","Ljava/lang/Float;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int>=0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCost","hasNoCost","Z",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Int>=0?31:27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{f.Pc=32;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I",value);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",39);}
case 39:{return rt.Call(f,"forge/card/mana/ManaCost","sealClass","(Ljava/util/List;)V","invokevirtual",42);}
case 42:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1203(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCost","compareWeight","Ljava/lang/Float;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int>=0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCost","hasNoCost","Z",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Int>=0?31:27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{f.Pc=32;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I",value);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/mana/ManaCost","sealClass","(Ljava/util/List;)V","invokevirtual",40);}
case 40:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1204(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;","invokestatic",5);}
case 5:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;",value);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/card/mana/ManaCost","getSimpleString","()Ljava/lang/String;","invokevirtual",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCost","stringValue","Ljava/lang/String;",value);f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1205(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCost","compareWeight","Ljava/lang/Float;",value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/mana/IParserManaCost","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?70:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/card/mana/IParserManaCost","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Pc=f.Pop().Reference==null?67:40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=45;continue;}
case 45:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?67:48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"));f.Pc=53;continue;}
case 53:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?58:56;continue;}
case 56:{f.Push(JValue.I(1));f.Pc=57;continue;}
case 57:{f.Locals[3]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{f.Pc=15;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/card/mana/IParserManaCost","getTotalGenericCost","()I","invokeinterface",76);}
case 76:{f.Locals[4]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{f.Pc=f.Pop().Int!=0?93:83;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{f.Push(JValue.I(-1));f.Pc=86;continue;}
case 86:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?93:89;continue;}
case 89:{f.Push(JValue.I(1));f.Pc=90;continue;}
case 90:{f.Pc=94;continue;}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCost","hasNoCost","Z",value);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","hasNoCost","Z"));f.Pc=102;continue;}
case 102:{f.Pc=f.Pop().Int==0?109:105;continue;}
case 105:{f.Push(JValue.I(0));f.Pc=106;continue;}
case 106:{f.Pc=111;continue;}
case 109:{f.Push(f.Locals[4]);f.Pc=111;continue;}
case 111:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I",value);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[2]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/card/mana/ManaCost","sealClass","(Ljava/util/List;)V","invokevirtual",119);}
case 119:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1206(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCostParser"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCostParser")));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/mana/ManaCostParser","<init>","(Ljava/lang/String;)V","invokespecial",9);}
case 9:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Lforge/card/mana/IParserManaCost;)V","invokespecial",12);}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1207(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","hasNoCost","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?10:7;continue;}
case 7:{f.Push(JValue.R(rt.String("no cost")));f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?32:22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=26;continue;}
case 26:{return rt.DynamicCall(f,"forge/card/mana/ManaCost:1207:26:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",31);}
case 31:{return JStep.Return(f.Pop());}
case 32:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",39);}
case 39:{f.Locals[1]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Int<=0?66:47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("{")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",53);}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",60);}
case 60:{f.Push(JValue.R(rt.String("}")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",75);}
case 75:{f.Locals[2]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",82);}
case 82:{f.Pc=f.Pop().Int==0?124:85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",91);}
case 91:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=94;continue;}
case 94:{f.Locals[3]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[3]);f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"));f.Pc=99;continue;}
case 99:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?112:102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{f.Push(JValue.I(0));f.Pc=104;continue;}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/StringBuilder","insert","(ILjava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",108);}
case 108:{f.StackOp("pop");f.Pc=109;continue;}
case 109:{f.Pc=121;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[3]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/card/mana/ManaCostShard","toString","()Ljava/lang/String;","invokevirtual",117);}
case 117:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",120);}
case 120:{f.StackOp("pop");f.Pc=121;continue;}
case 121:{f.Pc=76;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=128;continue;}
case 128:{f.Pc=f.Pop().Int>=0?145:131;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{f.Push(JValue.I(32));f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",137);}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",144);}
case 144:{f.StackOp("pop");f.Pc=145;continue;}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",149);}
case 149:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1208(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?41:21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/mana/ManaCostShard","getCmc","()I","invokevirtual",36);}
case 36:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=37;continue;}
case 37:{f.Locals[1]=f.Pop();f.Pc=38;continue;}
case 38:{f.Pc=12;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=46;continue;}
case 46:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=47;continue;}
case 47:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1209(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?42:21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/mana/ManaCostShard","getColorMask","()B","invokevirtual",36);}
case 36:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=37;continue;}
case 37:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=38;continue;}
case 38:{f.Locals[1]=f.Pop();f.Pc=39;continue;}
case 39:{f.Pc=12;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1210(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",23);}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?56:33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[4]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?53:50;continue;}
case 50:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=53;continue;}
case 53:{f.Pc=24;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1211(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(6));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","stringValue","Ljava/lang/String;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",15);}
case 15:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?107:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","stringValue","Ljava/lang/String;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{switch(f.Pop().Int){case 66:f.Pc=88;break;case 67:f.Pc=88;break;case 71:f.Pc=88;break;case 82:f.Pc=88;break;case 85:f.Pc=88;break;case 87:f.Pc=88;break;default:f.Pc=101;break;}continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(C)B","invokestatic",93);}
case 93:{return rt.Call(f,"forge/card/mana/ManaAtom","getIndexOfFirstManaType","(B)I","invokestatic",96);}
case 96:{f.StackOp("dup2");f.Pc=97;continue;}
case 97:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=98;continue;}
case 98:{f.Push(JValue.I(1));f.Pc=99;continue;}
case 99:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=100;continue;}
case 100:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=101;continue;}
case 101:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=104;continue;}
case 104:{f.Pc=7;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1212(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1213(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","hasNoCost","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1214(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int==0?23:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/mana/ManaCost","isNoCost","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int!=0?23:19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1215(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/mana/ManaCost","isPureGeneric","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1216(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/mana/ManaCost","getCompareWeight","()Ljava/lang/Float;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/mana/ManaCost","getCompareWeight","()Ljava/lang/Float;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Float","compareTo","(Ljava/lang/Float;)I","invokevirtual",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1217(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","compareWeight","Ljava/lang/Float;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?70:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=11;continue;}
case 11:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=12;continue;}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?52:32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/card/mana/ManaCostShard","getCmpc","()F","invokevirtual",47);}
case 47:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fadd",a,b));f.Pc=48;continue;}
case 48:{f.Locals[1]=f.Pop();f.Pc=49;continue;}
case 49:{f.Pc=23;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","hasNoCost","Z"));f.Pc=56;continue;}
case 56:{f.Pc=f.Pop().Int==0?62:59;continue;}
case 59:{f.Push(JValue.F(-1.0f));f.Pc=61;continue;}
case 61:{f.Locals[1]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/Float","valueOf","(F)Ljava/lang/Float;","invokestatic",67);}
case 67:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCost","compareWeight","Ljava/lang/Float;",value);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","compareWeight","Ljava/lang/Float;"));f.Pc=74;continue;}
case 74:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1218(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","hasNoCost","Z"));f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Int==0?20:16;continue;}
case 16:{f.Push(JValue.I(-1));f.Pc=17;continue;}
case 17:{f.Pc=24;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",37);}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",44);}
case 44:{f.Pc=f.Pop().Int==0?74:47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{f.Locals[3]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(JValue.I(6));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",63);}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/card/mana/ManaCostShard","name","()Ljava/lang/String;","invokevirtual",67);}
case 67:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Pc=38;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",78);}
case 78:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1219(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(6));f.Pc=3;continue;}
case 3:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","split","(Ljava/lang/String;C)[Ljava/lang/String;","invokestatic",6);}
case 6:{f.Locals[1]=f.Pop();f.Pc=7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",17);}
case 17:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(I)V","invokespecial",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",24);}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=32;continue;}
case 32:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?55:35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/card/mana/ManaCostShard","valueOf","(Ljava/lang/String;)Lforge/card/mana/ManaCostShard;","invokestatic",43);}
case 43:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=52;continue;}
case 52:{f.Pc=28;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/card/mana/ManaCost","sealClass","(Ljava/util/List;)V","invokevirtual",60);}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1220(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","stringValue","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1221(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/mana/ManaCost","isNoCost","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?10:7;continue;}
case 7:{f.Push(JValue.R(rt.String("-1")));f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
case 10:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",17);}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/mana/ManaCost","getGenericCost","()I","invokevirtual",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/card/mana/ManaCost","isZero","()Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?37:30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(48));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Pc=f.Pop().Int<=0?47:41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",56);}
case 56:{f.Locals[3]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",63);}
case 63:{f.Pc=f.Pop().Int==0?94:66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{f.Locals[4]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(JValue.I(32));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[4]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",90);}
case 90:{f.StackOp("pop");f.Pc=91;continue;}
case 91:{f.Pc=57;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{f.Pc=f.Pop().Int>=0?109:98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{f.Push(JValue.I(32));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",104);}
case 104:{f.Push(f.Locals[2]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",108);}
case 108:{f.StackOp("pop");f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",113);}
case 113:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",116);}
case 116:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1222(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?41:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/mana/ManaCostShard","isPhyrexian","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?38:36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 38:{f.Pc=10;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1223(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?44:21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/card/mana/ManaCostShard","isPhyrexian","()Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?41:38;continue;}
case 38:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=41;continue;}
case 41:{f.Pc=12;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1224(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?41:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/mana/ManaCostShard","isMultiColor","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?38:36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 38:{f.Pc=10;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1225(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?41:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/mana/ManaCostShard","isHybrid","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?38:36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 38:{f.Pc=10;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1226(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?50:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/card/mana/ManaCostShard","getColorMask","()B","invokevirtual",38);}
case 38:{return rt.Call(f,"forge/card/mana/ManaCostShard","valueOf","(I)Lforge/card/mana/ManaCostShard;","invokestatic",41);}
case 41:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{f.Pc=14;continue;}
case 50:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=53;continue;}
case 53:{f.StackOp("dup");f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(ILjava/util/List;)V","invokespecial",62);}
case 62:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1227(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/mana/ManaCost","getShardCount","(Lforge/card/mana/ManaCostShard;)I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1228(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?49:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/mana/ManaCostShard","isPhyrexian","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int!=0?46:36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/card/mana/ManaCostShard","canBePaidWithManaOfColor","(B)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int!=0?46:44;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 46:{f.Pc=10;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1229(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=12;continue;}
case 12:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(I)V","invokespecial",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",20);}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",31);}
case 31:{f.StackOp("pop");f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/card/mana/ManaCost","sealClass","(Ljava/util/List;)V","invokevirtual",48);}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1230(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1231(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","shards","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Int>0?28:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Int!=0?31:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Int!=0?31:28;continue;}
case 28:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCost","genericCost","I"));f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Int>=0?48:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/card/mana/ManaCost","countX","()I","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int<=0?48:45;continue;}
case 45:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1232(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCost"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/mana/ManaCost","compareTo","(Lforge/card/mana/ManaCost;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1233(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.I(-1));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(I)V","invokespecial",8);}
case 8:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","NO_COST","Lforge/card/mana/ManaCost;"))return JStep.Continue;rt.PutStatic("forge/card/mana/ManaCost","NO_COST","Lforge/card/mana/ManaCost;",f.Pop());f.Pc=11;continue;}
case 11:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(I)V","invokespecial",19);}
case 19:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"))return JStep.Continue;rt.PutStatic("forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;",f.Pop());f.Pc=22;continue;}
case 22:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(I)V","invokespecial",30);}
case 30:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","ONE","Lforge/card/mana/ManaCost;"))return JStep.Continue;rt.PutStatic("forge/card/mana/ManaCost","ONE","Lforge/card/mana/ManaCost;",f.Pop());f.Pc=33;continue;}
case 33:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(JValue.I(2));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(I)V","invokespecial",41);}
case 41:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","TWO","Lforge/card/mana/ManaCost;"))return JStep.Continue;rt.PutStatic("forge/card/mana/ManaCost","TWO","Lforge/card/mana/ManaCost;",f.Pop());f.Pc=44;continue;}
case 44:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=47;continue;}
case 47:{f.StackOp("dup");f.Pc=48;continue;}
case 48:{f.Push(JValue.I(3));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(I)V","invokespecial",52);}
case 52:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","THREE","Lforge/card/mana/ManaCost;"))return JStep.Continue;rt.PutStatic("forge/card/mana/ManaCost","THREE","Lforge/card/mana/ManaCost;",f.Pop());f.Pc=55;continue;}
case 55:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{f.Push(JValue.I(4));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(I)V","invokespecial",63);}
case 63:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","FOUR","Lforge/card/mana/ManaCost;"))return JStep.Continue;rt.PutStatic("forge/card/mana/ManaCost","FOUR","Lforge/card/mana/ManaCost;",f.Pop());f.Pc=66;continue;}
case 66:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
