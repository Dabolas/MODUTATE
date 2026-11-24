// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C95{
internal static JClass Build(){var c=new JClass("forge/deck/DeckGroup","forge/deck/DeckBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-1628725522049635829L),null));
c.Add(new JField("humanDeck","Lforge/deck/Deck;",false,JValue.Default("Lforge/deck/Deck;"),null));
c.Add(new JField("aiDecks","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(1487,"forge/deck/DeckGroup","<init>","()V",1,1,2,new JHandler[]{},M1487));
c.Add(new JMethod(1488,"forge/deck/DeckGroup","<init>","(Ljava/lang/String;)V",1,2,3,new JHandler[]{},M1488));
c.Add(new JMethod(1489,"forge/deck/DeckGroup","getHumanDeck","()Lforge/deck/Deck;",1,1,1,new JHandler[]{},M1489));
c.Add(new JMethod(1490,"forge/deck/DeckGroup","getAiDecks","()Ljava/util/List;",17,1,1,new JHandler[]{},M1490));
c.Add(new JMethod(1491,"forge/deck/DeckGroup","setHumanDeck","(Lforge/deck/Deck;)V",17,2,2,new JHandler[]{},M1491));
c.Add(new JMethod(1492,"forge/deck/DeckGroup","rankAiDecks","(Ljava/util/Comparator;)V",17,2,2,new JHandler[]{},M1492));
c.Add(new JMethod(1493,"forge/deck/DeckGroup","getItemType","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1493));
c.Add(new JMethod(1494,"forge/deck/DeckGroup","cloneFieldsTo","(Lforge/deck/DeckBase;)V",4,5,3,new JHandler[]{},M1494));
c.Add(new JMethod(1495,"forge/deck/DeckGroup","addAiDeck","(Lforge/deck/Deck;)V",17,2,2,new JHandler[]{},M1495));
c.Add(new JMethod(1496,"forge/deck/DeckGroup","addAiDecks","([Lforge/deck/Deck;)V",1,2,2,new JHandler[]{},M1496));
c.Add(new JMethod(1497,"forge/deck/DeckGroup","newInstance","(Ljava/lang/String;)Lforge/deck/DeckBase;",4,2,3,new JHandler[]{},M1497));
c.Add(new JMethod(1498,"forge/deck/DeckGroup","isEmpty","()Z",1,1,1,new JHandler[]{},M1498));
c.Add(new JMethod(1499,"forge/deck/DeckGroup","getImageKey","(Z)Ljava/lang/String;",1,2,1,new JHandler[]{},M1499));
}

internal static JStep M1487(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/deck/DeckGroup","<init>","(Ljava/lang/String;)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1488(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/DeckBase","<init>","(Ljava/lang/String;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckGroup","aiDecks","Ljava/util/List;",value);f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1489(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckGroup","humanDeck","Lforge/deck/Deck;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1490(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckGroup","aiDecks","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1491(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckGroup","humanDeck","Lforge/deck/Deck;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckGroup","humanDeck","Lforge/deck/Deck;"));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?23:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckGroup","humanDeck","Lforge/deck/Deck;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/deck/DeckGroup","getDirectory","()Ljava/lang/String;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/deck/Deck","setDirectory","(Ljava/lang/String;)V","invokevirtual",23);}
case 23:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1492(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckGroup","aiDecks","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",9);}
case 9:{f.Push(JValue.I(2));f.Pc=10;continue;}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?14:13;continue;}
case 13:{return JStep.ReturnVoid;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckGroup","aiDecks","Ljava/util/List;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",24);}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1493(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Group of decks")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1494(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/DeckBase","cloneFieldsTo","(Lforge/deck/DeckBase;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckGroup"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckGroup","humanDeck","Lforge/deck/Deck;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/deck/DeckGroup","getName","()Ljava/lang/String;","invokevirtual",19);}
case 19:{return rt.Call(f,"forge/deck/Deck","copyTo","(Ljava/lang/String;)Lforge/deck/DeckBase;","invokevirtual",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/deck/DeckGroup","setHumanDeck","(Lforge/deck/Deck;)V","invokevirtual",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckGroup","aiDecks","Ljava/util/List;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",37);}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",44);}
case 44:{f.Pc=f.Pop().Int==0?78:47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{f.Locals[4]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[4]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/deck/Deck","getName","()Ljava/lang/String;","invokevirtual",66);}
case 66:{return rt.Call(f,"forge/deck/Deck","copyTo","(Ljava/lang/String;)Lforge/deck/DeckBase;","invokevirtual",69);}
case 69:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/deck/DeckGroup","addAiDeck","(Lforge/deck/Deck;)V","invokevirtual",75);}
case 75:{f.Pc=38;continue;}
case 78:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1495(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?5:4;continue;}
case 4:{return JStep.ReturnVoid;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/deck/DeckGroup","getDirectory","()Ljava/lang/String;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/deck/Deck","setDirectory","(Ljava/lang/String;)V","invokevirtual",13);}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckGroup","aiDecks","Ljava/util/List;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1496(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckGroup","aiDecks","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",8);}
case 8:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",13);}
case 13:{f.StackOp("pop");f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1497(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/DeckGroup"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckGroup")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/DeckGroup","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1498(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckGroup","humanDeck","Lforge/deck/Deck;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?17:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckGroup","humanDeck","Lforge/deck/Deck;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/deck/Deck","isEmpty","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1499(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
