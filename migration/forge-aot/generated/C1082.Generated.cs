// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1082{
internal static JClass Build(){var c=new JClass("forge/item/TournamentPack","forge/item/SealedProduct",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11442,"forge/item/TournamentPack","fromSet","(Lforge/card/CardEdition;)Lforge/item/TournamentPack;",9,2,4,new JHandler[]{},M11442));
c.Add(new JMethod(11443,"forge/item/TournamentPack","<init>","(Ljava/lang/String;Lforge/item/SealedTemplate;)V",1,3,3,new JHandler[]{},M11443));
c.Add(new JMethod(11444,"forge/item/TournamentPack","isStarterDeck","()Z",17,1,2,new JHandler[]{},M11444));
c.Add(new JMethod(11445,"forge/item/TournamentPack","getItemType","()Ljava/lang/String;",17,1,1,new JHandler[]{},M11445));
c.Add(new JMethod(11446,"forge/item/TournamentPack","generate","()Ljava/util/List;",4,1,1,new JHandler[]{},M11446));
c.Add(new JMethod(11447,"forge/item/TournamentPack","clone","()Ljava/lang/Object;",17,1,4,new JHandler[]{},M11447));
c.Add(new JMethod(11448,"forge/item/TournamentPack","getImageKey","(Z)Ljava/lang/String;",1,2,1,new JHandler[]{},M11448));
}

internal static JStep M11442(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getTournamentPacks","()Lforge/util/storage/IStorage;","invokevirtual",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/util/storage/IStorage","get","(Ljava/lang/String;)Ljava/lang/Object;","invokeinterface",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/SealedTemplate"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{f.Locals[1]=f.Pop();f.Pc=19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"forge/item/TournamentPack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/TournamentPack")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/card/CardEdition","getName","()Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/item/TournamentPack","<init>","(Ljava/lang/String;Lforge/item/SealedTemplate;)V","invokespecial",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11443(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/item/SealedProduct","<init>","(Ljava/lang/String;Lforge/item/SealedTemplate;)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11444(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/TournamentPack","contents","Lforge/item/SealedTemplate;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/item/SealedTemplate","getSlots","()Ljava/util/List;","invokevirtual",7);}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",13);}
case 13:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=16;continue;}
case 16:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",19);}
case 19:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",25);}
case 25:{f.Push(JValue.I(30));f.Pc=27;continue;}
case 27:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?34:30;continue;}
case 30:{f.Push(JValue.I(1));f.Pc=31;continue;}
case 31:{f.Pc=35;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11445(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/TournamentPack","isStarterDeck","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?12:7;continue;}
case 7:{f.Push(JValue.R(rt.String("Tournament Pack")));f.Pc=9;continue;}
case 9:{f.Pc=14;continue;}
case 12:{f.Push(JValue.R(rt.String("Starter Deck")));f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11446(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/TournamentPack","contents","Lforge/item/SealedTemplate;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/item/generation/BoosterGenerator","getBoosterPack","(Lforge/item/SealedTemplate;)Ljava/util/List;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11447(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/item/TournamentPack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/TournamentPack")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/item/TournamentPack","name","Ljava/lang/String;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/item/TournamentPack","contents","Lforge/item/SealedTemplate;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/item/TournamentPack","<init>","(Ljava/lang/String;Lforge/item/SealedTemplate;)V","invokespecial",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11448(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/TournamentPack","getEdition","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.DynamicCall(f,"forge/item/TournamentPack:11448:4:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
