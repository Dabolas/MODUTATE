// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1057{
internal static JClass Build(){var c=new JClass("forge/item/FatPack","forge/item/BoxedProduct",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("fpData","Lforge/item/FatPack$Template;",false,JValue.Default("Lforge/item/FatPack$Template;"),null));
c.Add(new JMethod(11203,"forge/item/FatPack","fromSet","(Lforge/card/CardEdition;)Lforge/item/FatPack;",9,3,5,new JHandler[]{},M11203));
c.Add(new JMethod(11204,"forge/item/FatPack","<init>","(Ljava/lang/String;Lforge/item/FatPack$Template;I)V",1,4,4,new JHandler[]{},M11204));
c.Add(new JMethod(11205,"forge/item/FatPack","getDescription","()Ljava/lang/String;",1,1,2,new JHandler[]{},M11205));
c.Add(new JMethod(11206,"forge/item/FatPack","getItemType","()Ljava/lang/String;",17,2,4,new JHandler[]{},M11206));
c.Add(new JMethod(11207,"forge/item/FatPack","getExtraCards","()Ljava/util/List;",1,1,1,new JHandler[]{},M11207));
c.Add(new JMethod(11208,"forge/item/FatPack","clone","()Ljava/lang/Object;",17,1,5,new JHandler[]{},M11208));
c.Add(new JMethod(11209,"forge/item/FatPack","getTotalCards","()I",1,1,2,new JHandler[]{},M11209));
c.Add(new JMethod(11210,"forge/item/FatPack","getImageKey","(Z)Ljava/lang/String;",1,2,1,new JHandler[]{},M11210));
}

internal static JStep M11203(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardEdition","getFatPackCount","()I","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Int>0?11:9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
case 11:{if(!rt.EnsureInitialized(f,"forge/item/FatPack$Template"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/FatPack$Template")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/item/FatPack$Template","<init>","(Lforge/card/CardEdition;)V","invokespecial",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(JValue.R(null));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",24);}
case 24:{return rt.Call(f,"forge/StaticData","getBoosters","()Lforge/util/storage/IStorage;","invokevirtual",27);}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/item/FatPack$Template","getEdition","()Ljava/lang/String;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/util/storage/IStorage","get","(Ljava/lang/String;)Ljava/lang/Object;","invokeinterface",36);}
case 36:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?41:39;continue;}
case 39:{f.Push(JValue.R(null));f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
case 41:{if(!rt.EnsureInitialized(f,"forge/item/FatPack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/FatPack")));f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/card/CardEdition","getName","()Ljava/lang/String;","invokevirtual",49);}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/item/FatPack$Template","cntBoosters","I"));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/item/FatPack","<init>","(Ljava/lang/String;Lforge/item/FatPack$Template;I)V","invokespecial",57);}
case 57:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11204(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/StaticData","getBoosters","()Lforge/util/storage/IStorage;","invokevirtual",8);}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/item/FatPack$Template","getEdition","()Ljava/lang/String;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/util/storage/IStorage","get","(Ljava/lang/String;)Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/SealedTemplate"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/item/BoxedProduct","<init>","(Ljava/lang/String;Lforge/item/SealedTemplate;I)V","invokespecial",24);}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/FatPack","fpData","Lforge/item/FatPack$Template;",value);f.Pc=29;continue;}
case 29:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11205(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/FatPack","fpData","Lforge/item/FatPack$Template;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/item/FatPack$Template","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/item/FatPack","contents","Lforge/item/SealedTemplate;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/item/SealedTemplate","toString","()Ljava/lang/String;","invokevirtual",14);}
case 14:{return rt.DynamicCall(f,"forge/item/FatPack:11205:14:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11206(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/item/FatPack","fpData","Lforge/item/FatPack$Template;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/item/FatPack$Template","getEdition","()Ljava/lang/String;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",19);}
case 19:{return rt.Call(f,"java/util/Date","getTime","()J","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",25);}
case 25:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",28);}
case 28:{f.Push(JValue.R(rt.String("KLD")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",36);}
case 36:{return rt.Call(f,"java/util/Date","getTime","()J","invokevirtual",39);}
case 39:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Int<0?47:43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{f.Pc=48;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{f.Locals[1]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Pc=f.Pop().Int==0?58:53;continue;}
case 53:{f.Push(JValue.R(rt.String("Bundle")));f.Pc=55;continue;}
case 55:{f.Pc=60;continue;}
case 58:{f.Push(JValue.R(rt.String("Fat Pack")));f.Pc=60;continue;}
case 60:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11207(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/FatPack","fpData","Lforge/item/FatPack$Template;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/item/generation/BoosterGenerator","getBoosterPack","(Lforge/item/SealedTemplate;)Ljava/util/List;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11208(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/item/FatPack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/FatPack")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/item/FatPack","name","Ljava/lang/String;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/item/FatPack","fpData","Lforge/item/FatPack$Template;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/item/FatPack","fpData","Lforge/item/FatPack$Template;"));f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/item/FatPack$Template","cntBoosters","I"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/item/FatPack","<init>","(Ljava/lang/String;Lforge/item/FatPack$Template;I)V","invokespecial",22);}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11209(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/BoxedProduct","getTotalCards","()I","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/item/FatPack","fpData","Lforge/item/FatPack$Template;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/item/FatPack$Template","getCntBoosters","()I","invokevirtual",11);}
case 11:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/item/FatPack","fpData","Lforge/item/FatPack$Template;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/item/FatPack$Template","getNumberOfCardsExpected","()I","invokevirtual",19);}
case 19:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11210(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/FatPack","getEdition","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.DynamicCall(f,"forge/item/FatPack:11210:4:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
