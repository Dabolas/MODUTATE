// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C88{
internal static JClass Build(){var c=new JClass("forge/deck/DeckBase","java/lang/Object",new string[]{"java/io/Serializable","java/lang/Comparable","forge/item/InventoryItem"},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-7538150536939660052L),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("directory","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("comment","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(1401,"forge/deck/DeckBase","<init>","(Ljava/lang/String;)V",1,2,4,new JHandler[]{},M1401));
c.Add(new JMethod(1402,"forge/deck/DeckBase","compareTo","(Lforge/deck/DeckBase;)I",1,2,2,new JHandler[]{},M1402));
c.Add(new JMethod(1403,"forge/deck/DeckBase","equals","(Ljava/lang/Object;)Z",1,3,2,new JHandler[]{},M1403));
c.Add(new JMethod(1404,"forge/deck/DeckBase","hashCode","()I",1,1,2,new JHandler[]{},M1404));
c.Add(new JMethod(1405,"forge/deck/DeckBase","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1405));
c.Add(new JMethod(1406,"forge/deck/DeckBase","setName","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M1406));
c.Add(new JMethod(1407,"forge/deck/DeckBase","hasName","()Z",1,1,1,new JHandler[]{},M1407));
c.Add(new JMethod(1408,"forge/deck/DeckBase","getDirectory","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1408));
c.Add(new JMethod(1409,"forge/deck/DeckBase","setDirectory","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M1409));
c.Add(new JMethod(1410,"forge/deck/DeckBase","getUniqueKey","()Ljava/lang/String;",1,1,2,new JHandler[]{},M1410));
c.Add(new JMethod(1411,"forge/deck/DeckBase","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1411));
c.Add(new JMethod(1412,"forge/deck/DeckBase","setComment","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M1412));
c.Add(new JMethod(1413,"forge/deck/DeckBase","getComment","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1413));
c.Add(new JMethod(1414,"forge/deck/DeckBase","newInstance","(Ljava/lang/String;)Lforge/deck/DeckBase;",1028,0,0,new JHandler[]{},null));
c.Add(new JMethod(1415,"forge/deck/DeckBase","cloneFieldsTo","(Lforge/deck/DeckBase;)V",4,2,2,new JHandler[]{},M1415));
c.Add(new JMethod(1416,"forge/deck/DeckBase","copyTo","(Ljava/lang/String;)Lforge/deck/DeckBase;",1,3,2,new JHandler[]{},M1416));
c.Add(new JMethod(1417,"forge/deck/DeckBase","getBestFileName","()Ljava/lang/String;",17,3,3,new JHandler[]{},M1417));
c.Add(new JMethod(1418,"forge/deck/DeckBase","isEmpty","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1419,"forge/deck/DeckBase","getHumanDeck","()Lforge/deck/Deck;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1420,"forge/deck/DeckBase","compareTo","(Ljava/lang/Object;)I",4161,2,2,new JHandler[]{},M1420));
}

internal static JStep M1401(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckBase","comment","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.I(47));f.Pc=13;continue;}
case 13:{f.Push(JValue.I(95));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","replace","(CC)Ljava/lang/String;","invokevirtual",18);}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckBase","name","Ljava/lang/String;",value);f.Pc=21;continue;}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1402(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","name","Ljava/lang/String;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","compareTo","(Ljava/lang/String;)I","invokevirtual",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1403(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/deck/DeckBase")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?24:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckBase"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","name","Ljava/lang/String;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","name","Ljava/lang/String;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",23);}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1404(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",7);}
case 7:{f.Push(JValue.I(17));f.Pc=9;continue;}
case 9:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","name","Ljava/lang/String;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",17);}
case 17:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1405(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1406(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckBase","name","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1407(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?14:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1408(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","directory","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1409(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckBase","directory","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1410(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","directory","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","name","Ljava/lang/String;"));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","directory","Ljava/lang/String;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","name","Ljava/lang/String;"));f.Pc=20;continue;}
case 20:{return rt.DynamicCall(f,"forge/deck/DeckBase:1410:20:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",25);}
case 25:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1411(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1412(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckBase","comment","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1413(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","comment","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1415(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","directory","Ljava/lang/String;"));f.Pc=5;continue;}
case 5:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckBase","directory","Ljava/lang/String;",value);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","comment","Ljava/lang/String;"));f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckBase","comment","Ljava/lang/String;",value);f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1416(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/DeckBase","newInstance","(Ljava/lang/String;)Lforge/deck/DeckBase;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/deck/DeckBase","cloneFieldsTo","(Lforge/deck/DeckBase;)V","invokevirtual",11);}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1417(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckBase","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("[\\/:*?\"<>|]")));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?33:19;continue;}
case 19:{return rt.Call(f,"java/time/LocalDateTime","now","()Ljava/time/LocalDateTime;","invokestatic",22);}
case 22:{f.Push(JValue.R(rt.String("yyyy-MM-dd-HH-mm")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/time/format/DateTimeFormatter","ofPattern","(Ljava/lang/String;)Ljava/time/format/DateTimeFormatter;","invokestatic",27);}
case 27:{return rt.Call(f,"java/time/LocalDateTime","format","(Ljava/time/format/DateTimeFormatter;)Ljava/lang/String;","invokevirtual",30);}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1420(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckBase"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/DeckBase","compareTo","(Lforge/deck/DeckBase;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
