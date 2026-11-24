// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C21{
internal static JClass Build(){var c=new JClass("forge/card/CardEdition$Collection$1","forge/util/storage/StorageReaderBase",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("this$0","Lforge/card/CardEdition$Collection;",false,JValue.Default("Lforge/card/CardEdition$Collection;"),null));
c.Add(new JMethod(449,"forge/card/CardEdition$Collection$1","<init>","(Lforge/card/CardEdition$Collection;Ljava/util/function/Function;)V",0,3,2,new JHandler[]{},M449));
c.Add(new JMethod(450,"forge/card/CardEdition$Collection$1","readAll","()Ljava/util/Map;",1,8,4,new JHandler[]{},M450));
c.Add(new JMethod(451,"forge/card/CardEdition$Collection$1","getItemKey","(Lforge/item/SealedTemplate;)Ljava/lang/String;",1,2,1,new JHandler[]{},M451));
c.Add(new JMethod(452,"forge/card/CardEdition$Collection$1","getFullPath","()Ljava/lang/String;",1,1,1,new JHandler[]{},M452));
c.Add(new JMethod(453,"forge/card/CardEdition$Collection$1","getItemKey","(Ljava/lang/Object;)Ljava/lang/String;",4161,2,2,new JHandler[]{},M453));
}

internal static JStep M449(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardEdition$Collection$1","this$0","Lforge/card/CardEdition$Collection;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/util/storage/StorageReaderBase","<init>","(Ljava/util/function/Function;)V","invokespecial",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M450(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/TreeMap","<init>","(Ljava/util/Comparator;)V","invokespecial",10);}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/card/CardEdition$Collection$1","this$0","Lforge/card/CardEdition$Collection;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardEdition$Collection","iterator","()Ljava/util/Iterator;","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?127:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/card/CardEdition","getAvailableBoosterTypes","()Ljava/util/Set;","invokevirtual",42);}
case 42:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",45);}
case 45:{f.Locals[4]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",54);}
case 54:{f.Locals[5]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",63);}
case 63:{f.Pc=f.Pop().Int==0?124:66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",73);}
case 73:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=76;continue;}
case 76:{f.Locals[6]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[6]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("Draft")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?93:88;continue;}
case 88:{f.Push(JValue.R(rt.String("")));f.Pc=90;continue;}
case 90:{f.Pc=95;continue;}
case 93:{f.Push(f.Locals[6]);f.Pc=95;continue;}
case 95:{f.Locals[7]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",102);}
case 102:{f.Push(f.Locals[7]);f.Pc=104;continue;}
case 104:{return rt.DynamicCall(f,"forge/card/CardEdition$Collection$1:450:104:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",109);}
case 109:{f.Push(f.Locals[3]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[6]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/card/CardEdition","getBoosterTemplate","(Ljava/lang/String;)Lforge/item/SealedTemplate;","invokevirtual",115);}
case 115:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",120);}
case 120:{f.StackOp("pop");f.Pc=121;continue;}
case 121:{f.Pc=56;continue;}
case 124:{f.Pc=19;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M451(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/SealedTemplate","getEdition","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M452(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M453(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/SealedTemplate"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardEdition$Collection$1","getItemKey","(Lforge/item/SealedTemplate;)Ljava/lang/String;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
