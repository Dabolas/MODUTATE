// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C26{
internal static JClass Build(){var c=new JClass("forge/card/CardEdition$Predicates","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("CAN_MAKE_BOOSTER","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("HAS_TOURNAMENT_PACK","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("HAS_FAT_PACK","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("HAS_BOOSTER_BOX","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("hasBasicLands","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JMethod(486,"forge/card/CardEdition$Predicates","<init>","()V",1,1,1,new JHandler[]{},M486));
c.Add(new JMethod(487,"forge/card/CardEdition$Predicates","getRandomSetWithAllBasicLands","(Ljava/lang/Iterable;)Lforge/card/CardEdition;",9,1,2,new JHandler[]{},M487));
c.Add(new JMethod(488,"forge/card/CardEdition$Predicates","getPreferredArtEditionWithAllBasicLands","()Lforge/card/CardEdition;",9,5,4,new JHandler[]{},M488));
c.Add(new JMethod(489,"forge/card/CardEdition$Predicates","lambda$static$3","(Lforge/card/CardEdition;)Z",4106,1,1,new JHandler[]{},M489));
c.Add(new JMethod(490,"forge/card/CardEdition$Predicates","lambda$static$2","(Lforge/card/CardEdition;)Z",4106,1,1,new JHandler[]{},M490));
c.Add(new JMethod(491,"forge/card/CardEdition$Predicates","lambda$static$1","(Lforge/card/CardEdition;)Z",4106,1,1,new JHandler[]{},M491));
c.Add(new JMethod(492,"forge/card/CardEdition$Predicates","lambda$static$0","(Lforge/card/CardEdition;)Z",4106,1,2,new JHandler[]{},M492));
c.Add(new JMethod(493,"forge/card/CardEdition$Predicates","<clinit>","()V",8,0,1,new JHandler[]{},M493));
}

internal static JStep M486(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M487(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/card/CardEdition$Predicates","hasBasicLands","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Predicates","hasBasicLands","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",7);}
case 7:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M488(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokevirtual",6);}
case 6:{f.Locals[0]=f.Pop();f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",10);}
case 10:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/card/CardEdition$Collection","getOrderedEditions","()Ljava/lang/Iterable;","invokevirtual",16);}
case 16:{if(!rt.StaticReady(f,"forge/card/CardEdition$Predicates","hasBasicLands","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Predicates","hasBasicLands","Ljava/util/function/Predicate;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{return rt.DynamicCall(f,"forge/card/CardEdition$Predicates:488:25:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardDb$CardArtPreference;)Ljava/util/function/Predicate;",30);}
case 30:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",35);}
case 35:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",38);}
case 38:{f.Locals[1]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",45);}
case 45:{f.Locals[2]=f.Pop();f.Pc=46;continue;}
case 46:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",53);}
case 53:{f.Locals[3]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",60);}
case 60:{f.Pc=f.Pop().Int==0?82:63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Pc=54;continue;}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",88);}
case 88:{f.Pc=f.Pop().Int==0?93:91;continue;}
case 91:{f.Push(JValue.R(null));f.Pc=92;continue;}
case 92:{return JStep.Return(f.Pop());}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","latestFirst","Z"));f.Pc=97;continue;}
case 97:{f.Pc=f.Pop().Int==0?104:100;continue;}
case 100:{f.Push(JValue.I(0));f.Pc=101;continue;}
case 101:{f.Pc=112;continue;}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",110);}
case 110:{f.Push(JValue.I(1));f.Pc=111;continue;}
case 111:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=112;continue;}
case 112:{f.Locals[4]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[3]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[4]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",122);}
case 122:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=125;continue;}
case 125:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M489(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardEdition","hasBasicLands","()Z","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M490(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardEdition","getBoosterBoxCount","()I","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int<=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M491(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardEdition","getFatPackCount","()I","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int<=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M492(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getTournamentPacks","()Lforge/util/storage/IStorage;","invokevirtual",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/util/storage/IStorage","contains","(Ljava/lang/String;)Z","invokeinterface",15);}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M493(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/card/CardEdition$Predicates:493:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{if(!rt.StaticReady(f,"forge/card/CardEdition$Predicates","CAN_MAKE_BOOSTER","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Predicates","CAN_MAKE_BOOSTER","Ljava/util/function/Predicate;",f.Pop());f.Pc=8;continue;}
case 8:{return rt.DynamicCall(f,"forge/card/CardEdition$Predicates:493:8:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",13);}
case 13:{if(!rt.StaticReady(f,"forge/card/CardEdition$Predicates","HAS_TOURNAMENT_PACK","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Predicates","HAS_TOURNAMENT_PACK","Ljava/util/function/Predicate;",f.Pop());f.Pc=16;continue;}
case 16:{return rt.DynamicCall(f,"forge/card/CardEdition$Predicates:493:16:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",21);}
case 21:{if(!rt.StaticReady(f,"forge/card/CardEdition$Predicates","HAS_FAT_PACK","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Predicates","HAS_FAT_PACK","Ljava/util/function/Predicate;",f.Pop());f.Pc=24;continue;}
case 24:{return rt.DynamicCall(f,"forge/card/CardEdition$Predicates:493:24:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",29);}
case 29:{if(!rt.StaticReady(f,"forge/card/CardEdition$Predicates","HAS_BOOSTER_BOX","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Predicates","HAS_BOOSTER_BOX","Ljava/util/function/Predicate;",f.Pop());f.Pc=32;continue;}
case 32:{return rt.DynamicCall(f,"forge/card/CardEdition$Predicates:493:32:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",37);}
case 37:{if(!rt.StaticReady(f,"forge/card/CardEdition$Predicates","hasBasicLands","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Predicates","hasBasicLands","Ljava/util/function/Predicate;",f.Pop());f.Pc=40;continue;}
case 40:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
