// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1076{
internal static JClass Build(){var c=new JClass("forge/item/PreconDeck","java/lang/Object",new string[]{"forge/item/InventoryItemFromSet"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("deck","Lforge/deck/Deck;",false,JValue.Default("Lforge/deck/Deck;"),null));
c.Add(new JField("set","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("description","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("imageFilename","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(11396,"forge/item/PreconDeck","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11396));
c.Add(new JMethod(11397,"forge/item/PreconDeck","getItemType","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11397));
c.Add(new JMethod(11398,"forge/item/PreconDeck","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11398));
c.Add(new JMethod(11399,"forge/item/PreconDeck","<init>","(Lforge/deck/Deck;Ljava/lang/String;Ljava/lang/String;)V",1,4,2,new JHandler[]{},M11399));
c.Add(new JMethod(11400,"forge/item/PreconDeck","getDeck","()Lforge/deck/Deck;",17,1,1,new JHandler[]{},M11400));
c.Add(new JMethod(11401,"forge/item/PreconDeck","getImageFilename","()Ljava/lang/String;",17,1,1,new JHandler[]{},M11401));
c.Add(new JMethod(11402,"forge/item/PreconDeck","getEdition","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11402));
c.Add(new JMethod(11403,"forge/item/PreconDeck","getDescription","()Ljava/lang/String;",17,1,1,new JHandler[]{},M11403));
c.Add(new JMethod(11404,"forge/item/PreconDeck","getImageKey","(Z)Ljava/lang/String;",1,2,1,new JHandler[]{},M11404));
}

internal static JStep M11396(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PreconDeck","deck","Lforge/deck/Deck;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/Deck","getName","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11397(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Prebuilt Deck")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11398(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PreconDeck","deck","Lforge/deck/Deck;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/Deck","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11399(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PreconDeck","deck","Lforge/deck/Deck;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PreconDeck","set","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PreconDeck","description","Ljava/lang/String;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11400(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PreconDeck","deck","Lforge/deck/Deck;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11401(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PreconDeck","imageFilename","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11402(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PreconDeck","set","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11403(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PreconDeck","description","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11404(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PreconDeck","imageFilename","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.DynamicCall(f,"forge/item/PreconDeck:11404:4:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
