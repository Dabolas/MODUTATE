// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C120{
internal static JClass Build(){var c=new JClass("forge/deck/io/DeckGroupSerializer","forge/util/storage/StorageReaderFolder",new string[]{"forge/util/IItemSerializer"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("humanDeckFile","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"human.dck"));
c.Add(new JField("rootDir","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("MAX_DRAFT_PLAYERS","I",true,JValue.I(8),null));
c.Add(new JMethod(1746,"forge/deck/io/DeckGroupSerializer","<init>","(Ljava/io/File;Ljava/lang/String;)V",1,3,3,new JHandler[]{},M1746));
c.Add(new JMethod(1747,"forge/deck/io/DeckGroupSerializer","save","(Lforge/deck/DeckGroup;)V",1,5,5,new JHandler[]{},M1747));
c.Add(new JMethod(1748,"forge/deck/io/DeckGroupSerializer","read","(Ljava/io/File;)Lforge/deck/DeckGroup;",20,6,4,new JHandler[]{},M1748));
c.Add(new JMethod(1749,"forge/deck/io/DeckGroupSerializer","erase","(Lforge/deck/DeckGroup;)V",1,8,2,new JHandler[]{},M1749));
c.Add(new JMethod(1750,"forge/deck/io/DeckGroupSerializer","makeFileFor","(Lforge/deck/DeckGroup;)Ljava/io/File;",1,2,4,new JHandler[]{},M1750));
c.Add(new JMethod(1751,"forge/deck/io/DeckGroupSerializer","getFileFilter","()Ljava/io/FilenameFilter;",4,1,1,new JHandler[]{},M1751));
c.Add(new JMethod(1752,"forge/deck/io/DeckGroupSerializer","getSubFolders","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M1752));
c.Add(new JMethod(1753,"forge/deck/io/DeckGroupSerializer","read","(Ljava/io/File;)Ljava/lang/Object;",4164,2,2,new JHandler[]{},M1753));
c.Add(new JMethod(1754,"forge/deck/io/DeckGroupSerializer","erase","(Ljava/lang/Object;)V",4161,2,2,new JHandler[]{},M1754));
c.Add(new JMethod(1755,"forge/deck/io/DeckGroupSerializer","save","(Ljava/lang/Object;)V",4161,2,2,new JHandler[]{},M1755));
c.Add(new JMethod(1756,"forge/deck/io/DeckGroupSerializer","lambda$getFileFilter$0","(Ljava/io/File;Ljava/lang/String;)Z",4106,6,4,new JHandler[]{},M1756));
}

internal static JStep M1746(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/deck/io/DeckGroupSerializer:1746:2:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",7);}
case 7:{return rt.Call(f,"forge/util/storage/StorageReaderFolder","<init>","(Ljava/io/File;Ljava/util/function/Function;)V","invokespecial",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/io/DeckGroupSerializer","rootDir","Ljava/lang/String;",value);f.Pc=15;continue;}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1747(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/io/DeckGroupSerializer","makeFileFor","(Lforge/deck/DeckGroup;)Ljava/io/File;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/io/File","mkdir","()Z","invokevirtual",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/deck/DeckGroup","getHumanDeck","()Lforge/deck/Deck;","invokevirtual",15);}
case 15:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("human.dck")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/io/File","<init>","(Ljava/io/File;Ljava/lang/String;)V","invokespecial",25);}
case 25:{return rt.Call(f,"forge/deck/io/DeckSerializer","writeDeck","(Lforge/deck/Deck;Ljava/io/File;)V","invokestatic",28);}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/deck/DeckGroup","getAiDecks","()Ljava/util/List;","invokevirtual",32);}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",44);}
case 44:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?84:47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[4]);f.Pc=67;continue;}
case 67:{return rt.DynamicCall(f,"forge/deck/io/DeckGroupSerializer:1747:67:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",72);}
case 72:{return rt.Call(f,"java/io/File","<init>","(Ljava/io/File;Ljava/lang/String;)V","invokespecial",75);}
case 75:{return rt.Call(f,"forge/deck/io/DeckSerializer","writeDeck","(Lforge/deck/Deck;Ljava/io/File;)V","invokestatic",78);}
case 78:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=81;continue;}
case 81:{f.Pc=36;continue;}
case 84:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1748(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("human.dck")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/io/File","<init>","(Ljava/io/File;Ljava/lang/String;)V","invokespecial",10);}
case 10:{return rt.Call(f,"forge/deck/io/DeckSerializer","fromFile","(Ljava/io/File;)Lforge/deck/Deck;","invokestatic",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference!=null?20:18;continue;}
case 18:{f.Push(JValue.R(null));f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
case 20:{if(!rt.EnsureInitialized(f,"forge/deck/DeckGroup"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckGroup")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/deck/Deck","getName","()Ljava/lang/String;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/deck/DeckGroup","<init>","(Ljava/lang/String;)V","invokespecial",31);}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/io/File","getParent","()Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckGroupSerializer","rootDir","Ljava/lang/String;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",44);}
case 44:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/deck/DeckGroup","setDirectory","(Ljava/lang/String;)V","invokevirtual",50);}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/deck/DeckGroup","setHumanDeck","(Lforge/deck/Deck;)V","invokevirtual",55);}
case 55:{f.Push(JValue.I(1));f.Pc=56;continue;}
case 56:{f.Locals[4]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{f.Push(JValue.I(8));f.Pc=62;continue;}
case 62:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?108:65;continue;}
case 65:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{return rt.DynamicCall(f,"forge/deck/io/DeckGroupSerializer:1748:72:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",77);}
case 77:{return rt.Call(f,"java/io/File","<init>","(Ljava/io/File;Ljava/lang/String;)V","invokespecial",80);}
case 80:{f.Locals[5]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/io/File","exists","()Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int!=0?93:90;continue;}
case 90:{f.Pc=108;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[5]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/deck/io/DeckSerializer","fromFile","(Ljava/io/File;)Lforge/deck/Deck;","invokestatic",99);}
case 99:{return rt.Call(f,"forge/deck/DeckGroup","addAiDeck","(Lforge/deck/Deck;)V","invokevirtual",102);}
case 102:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=105;continue;}
case 105:{f.Pc=58;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1749(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/io/DeckGroupSerializer","makeFileFor","(Lforge/deck/DeckGroup;)Ljava/io/File;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/io/File","listFiles","()[Ljava/io/File;","invokevirtual",10);}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{f.Locals[4]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=17;continue;}
case 17:{f.Locals[5]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Locals[6]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[6]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?48:29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[6]);f.Pc=33;continue;}
case 33:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=34;continue;}
case 34:{f.Locals[7]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[7]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/io/File","delete","()Z","invokevirtual",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=45;continue;}
case 45:{f.Pc=22;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/io/File","delete","()Z","invokevirtual",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1750(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckGroupSerializer","directory","Ljava/io/File;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/deck/DeckGroup","getBestFileName","()Ljava/lang/String;","invokevirtual",12);}
case 12:{return rt.Call(f,"java/io/File","<init>","(Ljava/io/File;Ljava/lang/String;)V","invokespecial",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1751(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/deck/io/DeckGroupSerializer:1751:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/io/FilenameFilter;",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1752(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/ImmutableList","of","()Lcom/google/common/collect/ImmutableList;","invokestatic",3);}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1753(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/io/DeckGroupSerializer","read","(Ljava/io/File;)Lforge/deck/DeckGroup;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1754(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckGroup"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/io/DeckGroupSerializer","erase","(Lforge/deck/DeckGroup;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1755(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckGroup"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/io/DeckGroupSerializer","save","(Lforge/deck/DeckGroup;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1756(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/io/File","<init>","(Ljava/io/File;Ljava/lang/String;)V","invokespecial",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/io/File","isDirectory","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?28:17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/io/File","isHidden","()Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int!=0?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",34);}
case 34:{f.Pc=f.Pop().Int==0?50:37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String(".")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int!=0?50:46;continue;}
case 46:{f.Push(JValue.I(1));f.Pc=47;continue;}
case 47:{f.Pc=51;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{f.Locals[4]=f.Pop();f.Pc=53;continue;}
case 53:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("human.dck")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/io/File","<init>","(Ljava/io/File;Ljava/lang/String;)V","invokespecial",63);}
case 63:{f.Locals[5]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Int==0?86:69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Pc=f.Pop().Int==0?86:74;continue;}
case 74:{f.Push(f.Locals[5]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/io/File","exists","()Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?86:82;continue;}
case 82:{f.Push(JValue.I(1));f.Pc=83;continue;}
case 83:{f.Pc=87;continue;}
case 86:{f.Push(JValue.I(0));f.Pc=87;continue;}
case 87:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
