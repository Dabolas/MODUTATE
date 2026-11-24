// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C122{
internal static JClass Build(){var c=new JClass("forge/deck/io/DeckStorage","forge/util/storage/StorageReaderFolder",new string[]{"forge/util/IItemSerializer"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("FILE_EXTENSION","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),".dck"));
c.Add(new JField("rootDir","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("moveWronglyNamedDecks","Z",false,JValue.Default("Z"),null));
c.Add(new JField("DCK_FILE_FILTER","Ljava/io/FilenameFilter;",true,JValue.Default("Ljava/io/FilenameFilter;"),null));
c.Add(new JMethod(1764,"forge/deck/io/DeckStorage","<init>","(Ljava/io/File;Ljava/lang/String;)V",1,3,4,new JHandler[]{},M1764));
c.Add(new JMethod(1765,"forge/deck/io/DeckStorage","<init>","(Ljava/io/File;Ljava/lang/String;Z)V",1,4,3,new JHandler[]{},M1765));
c.Add(new JMethod(1766,"forge/deck/io/DeckStorage","getReaderForFolder","(Ljava/io/File;)Lforge/util/IItemReader;",1,2,5,new JHandler[]{},M1766));
c.Add(new JMethod(1767,"forge/deck/io/DeckStorage","save","(Lforge/deck/Deck;)V",1,2,3,new JHandler[]{},M1767));
c.Add(new JMethod(1768,"forge/deck/io/DeckStorage","erase","(Lforge/deck/Deck;)V",1,2,2,new JHandler[]{},M1768));
c.Add(new JMethod(1769,"forge/deck/io/DeckStorage","makeFileFor","(Lforge/deck/Deck;)Ljava/io/File;",1,2,4,new JHandler[]{},M1769));
c.Add(new JMethod(1770,"forge/deck/io/DeckStorage","read","(Ljava/io/File;)Lforge/deck/Deck;",4,4,3,new JHandler[]{},M1770));
c.Add(new JMethod(1771,"forge/deck/io/DeckStorage","adjustFileLocation","(Ljava/io/File;Lforge/deck/Deck;)V",10,3,5,new JHandler[]{},M1771));
c.Add(new JMethod(1772,"forge/deck/io/DeckStorage","getFileFilter","()Ljava/io/FilenameFilter;",4,1,1,new JHandler[]{},M1772));
c.Add(new JMethod(1773,"forge/deck/io/DeckStorage","read","(Ljava/io/File;)Ljava/lang/Object;",4164,2,2,new JHandler[]{},M1773));
c.Add(new JMethod(1774,"forge/deck/io/DeckStorage","erase","(Ljava/lang/Object;)V",4161,2,2,new JHandler[]{},M1774));
c.Add(new JMethod(1775,"forge/deck/io/DeckStorage","save","(Ljava/lang/Object;)V",4161,2,2,new JHandler[]{},M1775));
c.Add(new JMethod(1776,"forge/deck/io/DeckStorage","lambda$static$0","(Ljava/io/File;Ljava/lang/String;)Z",4106,2,2,new JHandler[]{},M1776));
c.Add(new JMethod(1777,"forge/deck/io/DeckStorage","<clinit>","()V",8,0,1,new JHandler[]{},M1777));
}

internal static JStep M1764(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/io/DeckStorage","<init>","(Ljava/io/File;Ljava/lang/String;Z)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1765(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/deck/io/DeckStorage:1765:2:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",7);}
case 7:{return rt.Call(f,"forge/util/storage/StorageReaderFolder","<init>","(Ljava/io/File;Ljava/util/function/Function;)V","invokespecial",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/io/DeckStorage","rootDir","Ljava/lang/String;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/io/DeckStorage","moveWronglyNamedDecks","Z",value);f.Pc=20;continue;}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1766(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/io/File","getParentFile","()Ljava/io/File;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckStorage","directory","Ljava/io/File;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/io/File","equals","(Ljava/lang/Object;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?34:14;continue;}
case 14:{if(!rt.EnsureInitialized(f,"java/lang/UnsupportedOperationException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/UnsupportedOperationException")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckStorage","directory","Ljava/io/File;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",25);}
case 25:{return rt.DynamicCall(f,"forge/deck/io/DeckStorage:1766:25:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",30);}
case 30:{return rt.Call(f,"java/lang/UnsupportedOperationException","<init>","(Ljava/lang/String;)V","invokespecial",33);}
case 33:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 34:{if(!rt.EnsureInitialized(f,"forge/deck/io/DeckStorage"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/io/DeckStorage")));f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckStorage","rootDir","Ljava/lang/String;"));f.Pc=43;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/deck/io/DeckStorage","<init>","(Ljava/io/File;Ljava/lang/String;Z)V","invokespecial",47);}
case 47:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1767(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/deck/io/DeckStorage","makeFileFor","(Lforge/deck/Deck;)Ljava/io/File;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/deck/io/DeckSerializer","writeDeck","(Lforge/deck/Deck;Ljava/io/File;)V","invokestatic",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1768(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/io/DeckStorage","makeFileFor","(Lforge/deck/Deck;)Ljava/io/File;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/io/File","delete","()Z","invokevirtual",8);}
case 8:{f.StackOp("pop");f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1769(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckStorage","directory","Ljava/io/File;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/deck/Deck","getBestFileName","()Ljava/lang/String;","invokevirtual",12);}
case 12:{return rt.DynamicCall(f,"forge/deck/io/DeckStorage:1769:12:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",17);}
case 17:{return rt.Call(f,"java/io/File","<init>","(Ljava/io/File;Ljava/lang/String;)V","invokespecial",20);}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1770(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/FileUtil","readFile","(Ljava/io/File;)Ljava/util/List;","invokestatic",4);}
case 4:{return rt.Call(f,"forge/util/FileSection","parseSections","(Ljava/util/List;)Ljava/util/Map;","invokestatic",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/deck/io/DeckSerializer","fromSections","(Ljava/util/Map;)Lforge/deck/Deck;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckStorage","moveWronglyNamedDecks","Z"));f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Int==0?25:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/deck/io/DeckStorage","adjustFileLocation","(Ljava/io/File;Lforge/deck/Deck;)V","invokestatic",25);}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Pc=f.Pop().Reference==null?47:29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/io/File","getParent","()Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/deck/io/DeckStorage","rootDir","Ljava/lang/String;"));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",41);}
case 41:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/deck/Deck","setDirectory","(Ljava/lang/String;)V","invokevirtual",47);}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1771(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?12:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/io/File","delete","()Z","invokevirtual",8);}
case 8:{f.StackOp("pop");f.Pc=9;continue;}
case 9:{f.Pc=53;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/deck/Deck","getBestFileName","()Ljava/lang/String;","invokevirtual",16);}
case 16:{return rt.DynamicCall(f,"forge/deck/io/DeckStorage:1771:16:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/io/File","getName","()Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int!=0?53:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/io/File","getParentFile","()Ljava/io/File;","invokevirtual",42);}
case 42:{return rt.Call(f,"java/io/File","getParentFile","()Ljava/io/File;","invokevirtual",45);}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/io/File","<init>","(Ljava/io/File;Ljava/lang/String;)V","invokespecial",49);}
case 49:{return rt.Call(f,"java/io/File","renameTo","(Ljava/io/File;)Z","invokevirtual",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1772(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/deck/io/DeckStorage","DCK_FILE_FILTER","Ljava/io/FilenameFilter;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/io/DeckStorage","DCK_FILE_FILTER","Ljava/io/FilenameFilter;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1773(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/io/DeckStorage","read","(Ljava/io/File;)Lforge/deck/Deck;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1774(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/io/DeckStorage","erase","(Lforge/deck/Deck;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1775(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/io/DeckStorage","save","(Lforge/deck/Deck;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1776(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(".dck")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1777(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/deck/io/DeckStorage:1777:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/io/FilenameFilter;",5);}
case 5:{if(!rt.StaticReady(f,"forge/deck/io/DeckStorage","DCK_FILE_FILTER","Ljava/io/FilenameFilter;"))return JStep.Continue;rt.PutStatic("forge/deck/io/DeckStorage","DCK_FILE_FILTER","Ljava/io/FilenameFilter;",f.Pop());f.Pc=8;continue;}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
