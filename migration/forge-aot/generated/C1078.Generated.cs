// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1078{
internal static JClass Build(){var c=new JClass("forge/item/SealedProduct","java/lang/Object",new string[]{"forge/item/InventoryItemFromSet"},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("specialSets","Ljava/util/List;",true,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("contents","Lforge/item/SealedTemplate;",false,JValue.Default("Lforge/item/SealedTemplate;"),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("hash","I",false,JValue.Default("I"),null));
c.Add(new JField("cards","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(11410,"forge/item/SealedProduct","<init>","(Ljava/lang/String;Lforge/item/SealedTemplate;)V",1,3,3,new JHandler[]{},M11410));
c.Add(new JMethod(11411,"forge/item/SealedProduct","getName","()Ljava/lang/String;",17,1,2,new JHandler[]{},M11411));
c.Add(new JMethod(11412,"forge/item/SealedProduct","getDescription","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11412));
c.Add(new JMethod(11413,"forge/item/SealedProduct","getEdition","()Ljava/lang/String;",17,1,1,new JHandler[]{},M11413));
c.Add(new JMethod(11414,"forge/item/SealedProduct","getSealedTemplate","()Lforge/item/SealedTemplate;",1,1,1,new JHandler[]{},M11414));
c.Add(new JMethod(11415,"forge/item/SealedProduct","getCards","()Ljava/util/List;",1,1,2,new JHandler[]{},M11415));
c.Add(new JMethod(11416,"forge/item/SealedProduct","getTotalCards","()I",1,1,1,new JHandler[]{},M11416));
c.Add(new JMethod(11417,"forge/item/SealedProduct","equals","(Ljava/lang/Object;)Z",1,3,2,new JHandler[]{},M11417));
c.Add(new JMethod(11418,"forge/item/SealedProduct","hashCode","()I",1,1,1,new JHandler[]{},M11418));
c.Add(new JMethod(11419,"forge/item/SealedProduct","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11419));
c.Add(new JMethod(11420,"forge/item/SealedProduct","generate","()Ljava/util/List;",4,1,1,new JHandler[]{},M11420));
c.Add(new JMethod(11421,"forge/item/SealedProduct","getRandomBasicLand","(Ljava/lang/String;)Lforge/item/PaperCard;",4,2,3,new JHandler[]{},M11421));
c.Add(new JMethod(11422,"forge/item/SealedProduct","getRandomBasicLands","(Ljava/lang/String;I)Ljava/util/List;",4,3,2,new JHandler[]{},M11422));
c.Add(new JMethod(11423,"forge/item/SealedProduct","<clinit>","()V",8,0,2,new JHandler[]{},M11423));
}

internal static JStep M11410(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/SealedProduct","cards","Ljava/util/List;",value);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?24:14;continue;}
case 14:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("name0 must not be null")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",23);}
case 23:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 24:{f.Push(JValue.R(null));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?43:29;continue;}
case 29:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.DynamicCall(f,"forge/item/SealedProduct:11410:34:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",39);}
case 39:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",42);}
case 42:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/SealedProduct","contents","Lforge/item/SealedTemplate;",value);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/SealedProduct","name","Ljava/lang/String;",value);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedProduct","name","Ljava/lang/String;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",61);}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",65);}
case 65:{return rt.Call(f,"java/lang/Object","hashCode","()I","invokevirtual",68);}
case 68:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ixor",a,b));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedProduct","contents","Lforge/item/SealedTemplate;"));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/item/SealedTemplate","hashCode","()I","invokevirtual",76);}
case 76:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ixor",a,b));f.Pc=77;continue;}
case 77:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/SealedProduct","hash","I",value);f.Pc=80;continue;}
case 80:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11411(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedProduct","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/SealedProduct","getItemType","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.DynamicCall(f,"forge/item/SealedProduct:11411:8:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11412(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedProduct","contents","Lforge/item/SealedTemplate;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/item/SealedTemplate","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11413(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedProduct","contents","Lforge/item/SealedTemplate;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/item/SealedTemplate","getEdition","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11414(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedProduct","contents","Lforge/item/SealedTemplate;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11415(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedProduct","cards","Ljava/util/List;"));f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?16:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/item/SealedProduct","generate","()Ljava/util/List;","invokevirtual",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/SealedProduct","cards","Ljava/util/List;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedProduct","cards","Ljava/util/List;"));f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11416(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedProduct","contents","Lforge/item/SealedTemplate;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/item/SealedTemplate","getNumberOfCardsExpected","()I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11417(JRuntime rt,JFrame f)
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
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/SealedProduct"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedProduct","contents","Lforge/item/SealedTemplate;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedProduct","contents","Lforge/item/SealedTemplate;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/item/SealedTemplate","equals","(Ljava/lang/Object;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?61:43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedProduct","name","Ljava/lang/String;"));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedProduct","name","Ljava/lang/String;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?61:57;continue;}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{f.Pc=62;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11418(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedProduct","hash","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11419(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/SealedProduct","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11420(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedProduct","contents","Lforge/item/SealedTemplate;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/item/generation/BoosterGenerator","getBoosterPack","(Lforge/item/SealedTemplate;)Ljava/util/List;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11421(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/item/SealedProduct","getRandomBasicLands","(Ljava/lang/String;I)Ljava/util/List;","invokevirtual",6);}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",12);}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11422(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/card/CardDb","streamAllCards","()Ljava/util/stream/Stream;","invokevirtual",9);}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/item/PaperCardPredicates","printedInSet","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",18);}
case 18:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_BASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_BASIC_LAND","Ljava/util/function/Predicate;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",26);}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/util/StreamUtil","random","(I)Ljava/util/stream/Collector;","invokestatic",30);}
case 30:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11423(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{if(!rt.StaticReady(f,"forge/item/SealedProduct","specialSets","Ljava/util/List;"))return JStep.Continue;rt.PutStatic("forge/item/SealedProduct","specialSets","Ljava/util/List;",f.Pop());f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/item/SealedProduct","specialSets","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/SealedProduct","specialSets","Ljava/util/List;"));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("Black")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",20);}
case 20:{f.StackOp("pop");f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/item/SealedProduct","specialSets","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/SealedProduct","specialSets","Ljava/util/List;"));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Blue")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",31);}
case 31:{f.StackOp("pop");f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/item/SealedProduct","specialSets","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/SealedProduct","specialSets","Ljava/util/List;"));f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("Green")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/item/SealedProduct","specialSets","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/SealedProduct","specialSets","Ljava/util/List;"));f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("Red")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{if(!rt.StaticReady(f,"forge/item/SealedProduct","specialSets","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/SealedProduct","specialSets","Ljava/util/List;"));f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("White")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/item/SealedProduct","specialSets","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/SealedProduct","specialSets","Ljava/util/List;"));f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("Colorless")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
