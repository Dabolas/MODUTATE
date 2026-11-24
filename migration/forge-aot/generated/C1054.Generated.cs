// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1054{
internal static JClass Build(){var c=new JClass("forge/item/BoosterPack","forge/item/SealedProduct",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("artIndex","I",false,JValue.Default("I"),null));
c.Add(new JField("hash","I",false,JValue.Default("I"),null));
c.Add(new JMethod(11181,"forge/item/BoosterPack","fromSet","(Lforge/card/CardEdition;)Lforge/item/BoosterPack;",9,4,4,new JHandler[]{},M11181));
c.Add(new JMethod(11182,"forge/item/BoosterPack","fromColor","(Ljava/lang/String;)Lforge/item/BoosterPack;",9,1,11,new JHandler[]{},M11182));
c.Add(new JMethod(11183,"forge/item/BoosterPack","<init>","(Ljava/lang/String;Lforge/item/SealedTemplate;)V",1,4,3,new JHandler[]{},M11183));
c.Add(new JMethod(11184,"forge/item/BoosterPack","getArtIndex","()I",17,1,1,new JHandler[]{},M11184));
c.Add(new JMethod(11185,"forge/item/BoosterPack","getItemType","()Ljava/lang/String;",17,1,1,new JHandler[]{},M11185));
c.Add(new JMethod(11186,"forge/item/BoosterPack","getDescription","()Ljava/lang/String;",1,2,4,new JHandler[]{},M11186));
c.Add(new JMethod(11187,"forge/item/BoosterPack","clone","()Ljava/lang/Object;",17,1,4,new JHandler[]{},M11187));
c.Add(new JMethod(11188,"forge/item/BoosterPack","getBoosterData","()Lforge/item/SealedTemplate;",1,1,1,new JHandler[]{},M11188));
c.Add(new JMethod(11189,"forge/item/BoosterPack","equals","(Ljava/lang/Object;)Z",1,3,2,new JHandler[]{},M11189));
c.Add(new JMethod(11190,"forge/item/BoosterPack","hashCode","()I",17,1,1,new JHandler[]{},M11190));
c.Add(new JMethod(11191,"forge/item/BoosterPack","getImageKey","(Z)Ljava/lang/String;",1,5,4,new JHandler[]{},M11191));
}

internal static JStep M11181(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardEdition","getRandomBoosterKind","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?11:9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/CardEdition","getBoosterTemplate","(Ljava/lang/String;)Lforge/item/SealedTemplate;","invokevirtual",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/card/CardEdition","getName","()Ljava/lang/String;","invokevirtual",25);}
case 25:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",28);}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String(" ")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",35);}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{if(!rt.EnsureInitialized(f,"forge/item/BoosterPack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/BoosterPack")));f.Pc=43;continue;}
case 43:{f.StackOp("dup");f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/item/BoosterPack","<init>","(Ljava/lang/String;Lforge/item/SealedTemplate;)V","invokespecial",52);}
case 52:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11182(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/item/BoosterPack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/BoosterPack")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/item/SealedTemplate"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/SealedTemplate")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("?")));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.DynamicCall(f,"forge/item/BoosterPack:11182:12:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",17);}
case 17:{f.Push(JValue.I(11));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",22);}
case 22:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",25);}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.DynamicCall(f,"forge/item/BoosterPack:11182:26:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",31);}
case 31:{f.Push(JValue.I(3));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",35);}
case 35:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",38);}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{return rt.DynamicCall(f,"forge/item/BoosterPack:11182:39:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",44);}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",48);}
case 48:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",51);}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.DynamicCall(f,"forge/item/BoosterPack:11182:52:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",57);}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",61);}
case 61:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",64);}
case 64:{return rt.Call(f,"com/google/common/collect/ImmutableList","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList;","invokestatic",67);}
case 67:{return rt.Call(f,"forge/item/SealedTemplate","<init>","(Ljava/lang/String;Ljava/lang/Iterable;)V","invokespecial",70);}
case 70:{return rt.Call(f,"forge/item/BoosterPack","<init>","(Ljava/lang/String;Lforge/item/SealedTemplate;)V","invokespecial",73);}
case 73:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11183(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/item/SealedProduct","<init>","(Ljava/lang/String;Lforge/item/SealedTemplate;)V","invokespecial",6);}
case 6:{if(!rt.StaticReady(f,"forge/item/BoosterPack","specialSets","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/BoosterPack","specialSets","Ljava/util/List;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/item/SealedTemplate","getEdition","()Ljava/lang/String;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int!=0?33:21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/item/SealedTemplate","getEdition","()Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Push(JValue.R(rt.String("?")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?41:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/BoosterPack","artIndex","I",value);f.Pc=38;continue;}
case 38:{f.Pc=71;continue;}
case 41:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",44);}
case 44:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",47);}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/item/SealedTemplate","getEdition","()Ljava/lang/String;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",54);}
case 54:{return rt.Call(f,"forge/card/CardEdition","getCntBoosterPictures","()I","invokevirtual",57);}
case 57:{f.Locals[3]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",62);}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",66);}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=68;continue;}
case 68:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/BoosterPack","artIndex","I",value);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/item/SealedProduct","hashCode","()I","invokespecial",76);}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterPack","artIndex","I"));f.Pc=80;continue;}
case 80:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ixor",a,b));f.Pc=81;continue;}
case 81:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/BoosterPack","hash","I",value);f.Pc=84;continue;}
case 84:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11184(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterPack","artIndex","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11185(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Booster Pack")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11186(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/item/BoosterPack","specialSets","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/BoosterPack","specialSets","Ljava/util/List;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/item/BoosterPack","getEdition","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{f.Pc=f.Pop().Int!=0?27:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/item/BoosterPack","getEdition","()Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(JValue.R(rt.String("?")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?62:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/item/BoosterPack","getName","()Ljava/lang/String;","invokevirtual",31);}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/item/BoosterPack","getName","()Ljava/lang/String;","invokevirtual",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/item/BoosterPack","getItemType","()Ljava/lang/String;","invokevirtual",40);}
case 40:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",43);}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",48);}
case 48:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",51);}
case 51:{f.Locals[1]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.DynamicCall(f,"forge/item/BoosterPack:11186:56:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",61);}
case 61:{return JStep.Return(f.Pop());}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/item/SealedProduct","getDescription","()Ljava/lang/String;","invokespecial",66);}
case 66:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11187(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/item/BoosterPack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/BoosterPack")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterPack","name","Ljava/lang/String;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterPack","contents","Lforge/item/SealedTemplate;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/item/BoosterPack","<init>","(Ljava/lang/String;Lforge/item/SealedTemplate;)V","invokespecial",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11188(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterPack","contents","Lforge/item/SealedTemplate;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11189(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?7:5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference==null?22:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",15);}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",19);}
case 19:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?24:22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/item/SealedProduct","equals","(Ljava/lang/Object;)Z","invokespecial",29);}
case 29:{f.Pc=f.Pop().Int!=0?34:32;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/BoosterPack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[2]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterPack","artIndex","I"));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterPack","artIndex","I"));f.Pc=47;continue;}
case 47:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?54:50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{f.Pc=55;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11190(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterPack","hash","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11191(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/BoosterPack","getEdition","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/item/SealedProduct","specialSets","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/SealedProduct","specialSets","Ljava/util/List;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int!=0?26:17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("?")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?53:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/item/BoosterPack","getName","()Ljava/lang/String;","invokevirtual",30);}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/item/BoosterPack","getName","()Ljava/lang/String;","invokevirtual",35);}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/item/BoosterPack","getItemType","()Ljava/lang/String;","invokevirtual",39);}
case 39:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",42);}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",47);}
case 47:{return rt.DynamicCall(f,"forge/item/BoosterPack:11191:47:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",52);}
case 52:{return JStep.Return(f.Pop());}
case 53:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",56);}
case 56:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",59);}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",63);}
case 63:{return rt.Call(f,"forge/card/CardEdition","getCntBoosterPictures","()I","invokevirtual",66);}
case 66:{f.Locals[3]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(JValue.I(1));f.Pc=68;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?77:72;continue;}
case 72:{f.Push(JValue.R(rt.String("")));f.Pc=74;continue;}
case 74:{f.Pc=86;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterPack","artIndex","I"));f.Pc=81;continue;}
case 81:{return rt.DynamicCall(f,"forge/item/BoosterPack:11191:81:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",86);}
case 86:{f.Locals[4]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{return rt.DynamicCall(f,"forge/item/BoosterPack:11191:91:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",96);}
case 96:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
