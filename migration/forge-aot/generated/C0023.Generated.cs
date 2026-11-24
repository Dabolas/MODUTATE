// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C23{
internal static JClass Build(){var c=new JClass("forge/card/CardEdition$EditionEntry","java/lang/Record",new string[]{"java/lang/Comparable"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("collectorNumber","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("rarity","Lforge/card/CardRarity;",false,JValue.Default("Lforge/card/CardRarity;"),null));
c.Add(new JField("artistName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("extraParams","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(460,"forge/card/CardEdition$EditionEntry","<init>","(Ljava/lang/String;Ljava/lang/String;Lforge/card/CardRarity;Ljava/lang/String;Ljava/util/Map;)V",1,6,2,new JHandler[]{},M460));
c.Add(new JMethod(461,"forge/card/CardEdition$EditionEntry","toString","()Ljava/lang/String;",1,2,3,new JHandler[]{},M461));
c.Add(new JMethod(462,"forge/card/CardEdition$EditionEntry","compareTo","(Lforge/card/CardEdition$EditionEntry;)I",1,6,2,new JHandler[]{},M462));
c.Add(new JMethod(463,"forge/card/CardEdition$EditionEntry","getFlavorName","()Ljava/lang/String;",1,1,2,new JHandler[]{},M463));
c.Add(new JMethod(464,"forge/card/CardEdition$EditionEntry","getFunctionalVariantName","()Ljava/lang/String;",1,1,2,new JHandler[]{},M464));
c.Add(new JMethod(465,"forge/card/CardEdition$EditionEntry","hashCode","()I",17,1,1,new JHandler[]{},M465));
c.Add(new JMethod(466,"forge/card/CardEdition$EditionEntry","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M466));
c.Add(new JMethod(467,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;",1,1,1,new JHandler[]{},M467));
c.Add(new JMethod(468,"forge/card/CardEdition$EditionEntry","collectorNumber","()Ljava/lang/String;",1,1,1,new JHandler[]{},M468));
c.Add(new JMethod(469,"forge/card/CardEdition$EditionEntry","rarity","()Lforge/card/CardRarity;",1,1,1,new JHandler[]{},M469));
c.Add(new JMethod(470,"forge/card/CardEdition$EditionEntry","artistName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M470));
c.Add(new JMethod(471,"forge/card/CardEdition$EditionEntry","extraParams","()Ljava/util/Map;",1,1,1,new JHandler[]{},M471));
c.Add(new JMethod(472,"forge/card/CardEdition$EditionEntry","compareTo","(Ljava/lang/Object;)I",4161,2,2,new JHandler[]{},M472));
c.Add(new JMethod(473,"forge/card/CardEdition$EditionEntry","lambda$toString$0","(Ljava/util/Map$Entry;)Ljava/lang/String;",4106,1,5,new JHandler[]{},M473));
}

internal static JStep M460(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition$EditionEntry","name","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition$EditionEntry","collectorNumber","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition$EditionEntry","rarity","Lforge/card/CardRarity;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition$EditionEntry","artistName","Ljava/lang/String;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition$EditionEntry","extraParams","Ljava/util/Map;",value);f.Pc=31;continue;}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M461(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","collectorNumber","Ljava/lang/String;"));f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference==null?31:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","collectorNumber","Ljava/lang/String;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(JValue.I(32));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","rarity","Lforge/card/CardRarity;"));f.Pc=35;continue;}
case 35:{if(!rt.StaticReady(f,"forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"));f.Pc=38;continue;}
case 38:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?67:41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","rarity","Lforge/card/CardRarity;"));f.Pc=45;continue;}
case 45:{if(!rt.StaticReady(f,"forge/card/CardRarity","Token","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Token","Lforge/card/CardRarity;"));f.Pc=48;continue;}
case 48:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?67:51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","rarity","Lforge/card/CardRarity;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(32));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","name","Ljava/lang/String;"));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","artistName","Ljava/lang/String;"));f.Pc=80;continue;}
case 80:{f.Pc=f.Pop().Reference==null?99:83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String(" @")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",89);}
case 89:{f.StackOp("pop");f.Pc=90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","artistName","Ljava/lang/String;"));f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",98);}
case 98:{f.StackOp("pop");f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","extraParams","Ljava/util/Map;"));f.Pc=103;continue;}
case 103:{f.Pc=f.Pop().Reference==null?155:106;continue;}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String(" $")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",112);}
case 112:{f.StackOp("pop");f.Pc=113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","extraParams","Ljava/util/Map;"));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",123);}
case 123:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",128);}
case 128:{return rt.DynamicCall(f,"forge/card/CardEdition$EditionEntry:461:128:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",133);}
case 133:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",138);}
case 138:{f.Push(JValue.R(rt.String(", ")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/stream/Collectors","joining","(Ljava/lang/CharSequence;)Ljava/util/stream/Collector;","invokestatic",143);}
case 143:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",148);}
case 148:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",154);}
case 154:{f.StackOp("pop");f.Pc=155;continue;}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",159);}
case 159:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M462(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","name","Ljava/lang/String;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","compareToIgnoreCase","(Ljava/lang/String;)I","invokevirtual",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?19:17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","collectorNumber","Ljava/lang/String;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/card/CardEdition","getSortableCollectorNumber","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","collectorNumber","Ljava/lang/String;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/card/CardEdition","getSortableCollectorNumber","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",34);}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","compareTo","(Ljava/lang/String;)I","invokevirtual",42);}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?53:50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","rarity","Lforge/card/CardRarity;"));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","rarity","Lforge/card/CardRarity;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/card/CardRarity","compareTo","(Ljava/lang/Enum;)I","invokevirtual",64);}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M463(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","extraParams","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","extraParams","Ljava/util/Map;"));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("flavorname")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",20);}
case 20:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M464(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","extraParams","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","extraParams","Ljava/util/Map;"));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("variant")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",20);}
case 20:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M465(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/card/CardEdition$EditionEntry:465:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/card/CardEdition$EditionEntry;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M466(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/card/CardEdition$EditionEntry:466:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/card/CardEdition$EditionEntry;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M467(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M468(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","collectorNumber","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M469(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","rarity","Lforge/card/CardRarity;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M470(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","artistName","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M471(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$EditionEntry","extraParams","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M472(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","compareTo","(Lforge/card/CardEdition$EditionEntry;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M473(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("\"%s\"=\"%s\"")));f.Pc=2;continue;}
case 2:{f.Push(JValue.I(2));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=6;continue;}
case 6:{f.StackOp("dup");f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",14);}
case 14:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",27);}
case 27:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
