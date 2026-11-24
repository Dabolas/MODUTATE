// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1079{
internal static JClass Build(){var c=new JClass("forge/item/SealedTemplate","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("genericDraftBooster","Lforge/item/SealedTemplate;",true,JValue.Default("Lforge/item/SealedTemplate;"),null));
c.Add(new JField("genericNoSlotBooster","Lforge/item/SealedTemplate;",true,JValue.Default("Lforge/item/SealedTemplate;"),null));
c.Add(new JField("slots","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(11424,"forge/item/SealedTemplate","getName","()Ljava/lang/String;",17,1,1,new JHandler[]{},M11424));
c.Add(new JMethod(11425,"forge/item/SealedTemplate","getSlots","()Ljava/util/List;",17,1,1,new JHandler[]{},M11425));
c.Add(new JMethod(11426,"forge/item/SealedTemplate","hasSlot","(Ljava/lang/String;)Z",1,5,2,new JHandler[]{},M11426));
c.Add(new JMethod(11427,"forge/item/SealedTemplate","getEdition","()Ljava/lang/String;",17,1,1,new JHandler[]{},M11427));
c.Add(new JMethod(11428,"forge/item/SealedTemplate","<init>","(Ljava/lang/Iterable;)V",1,2,3,new JHandler[]{},M11428));
c.Add(new JMethod(11429,"forge/item/SealedTemplate","<init>","(Ljava/lang/String;Ljava/lang/Iterable;)V",1,3,2,new JHandler[]{},M11429));
c.Add(new JMethod(11430,"forge/item/SealedTemplate","<init>","(Ljava/lang/String;Ljava/lang/String;)V",1,3,3,new JHandler[]{},M11430));
c.Add(new JMethod(11431,"forge/item/SealedTemplate","getNumberOfCardsExpected","()I",1,4,2,new JHandler[]{},M11431));
c.Add(new JMethod(11432,"forge/item/SealedTemplate","toString","()Ljava/lang/String;",1,4,4,new JHandler[]{},M11432));
c.Add(new JMethod(11433,"forge/item/SealedTemplate","equals","(Ljava/lang/Object;)Z",1,3,2,new JHandler[]{},M11433));
c.Add(new JMethod(11434,"forge/item/SealedTemplate","hashCode","()I",1,2,2,new JHandler[]{},M11434));
c.Add(new JMethod(11435,"forge/item/SealedTemplate","<clinit>","()V",8,0,8,new JHandler[]{},M11435));
}

internal static JStep M11424(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedTemplate","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11425(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedTemplate","slots","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11426(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/SealedTemplate","getSlots","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?59:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("[ :!]")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?56:54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 56:{f.Pc=10;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11427(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedTemplate","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11428(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/item/SealedTemplate","<init>","(Ljava/lang/String;Ljava/lang/Iterable;)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11429(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",9);}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/SealedTemplate","slots","Ljava/util/List;",value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/SealedTemplate","name","Ljava/lang/String;",value);f.Pc=17;continue;}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11430(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/item/SealedTemplate$Reader","parseSlots","(Ljava/lang/String;)Ljava/util/List;","invokestatic",6);}
case 6:{return rt.Call(f,"forge/item/SealedTemplate","<init>","(Ljava/lang/String;Ljava/lang/Iterable;)V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11431(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedTemplate","slots","Ljava/util/List;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?47:21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",42);}
case 42:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=43;continue;}
case 43:{f.Locals[1]=f.Pop();f.Pc=44;continue;}
case 44:{f.Pc=12;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11432(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("consisting of ")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedTemplate","slots","Ljava/util/List;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",24);}
case 24:{f.Locals[2]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",31);}
case 31:{f.Pc=f.Pop().Int==0?76:34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",49);}
case 49:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",52);}
case 52:{f.Push(JValue.R(rt.String(" ")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",57);}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",67);}
case 67:{f.Push(JValue.R(rt.String(", ")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",72);}
case 72:{f.StackOp("pop");f.Pc=73;continue;}
case 73:{f.Pc=25;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",81);}
case 81:{f.Push(JValue.I(2));f.Pc=82;continue;}
case 82:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",87);}
case 87:{f.Push(JValue.R(rt.String("")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/StringBuilder","replace","(IILjava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",92);}
case 92:{f.StackOp("pop");f.Pc=93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String(",")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/StringBuilder","lastIndexOf","(Ljava/lang/String;)I","invokevirtual",99);}
case 99:{f.Locals[2]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(JValue.I(0));f.Pc=101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?118:105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{f.Push(JValue.I(1));f.Pc=108;continue;}
case 108:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{f.Push(JValue.I(1));f.Pc=111;continue;}
case 111:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String(" and")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/StringBuilder","replace","(IILjava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",117);}
case 117:{f.StackOp("pop");f.Pc=118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",122);}
case 122:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11433(JRuntime rt,JFrame f)
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
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/SealedTemplate"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedTemplate","slots","Ljava/util/List;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedTemplate","slots","Ljava/util/List;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/List","equals","(Ljava/lang/Object;)Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?63:45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedTemplate","name","Ljava/lang/String;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedTemplate","name","Ljava/lang/String;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?63:59;continue;}
case 59:{f.Push(JValue.I(1));f.Pc=60;continue;}
case 60:{f.Pc=64;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11434(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedTemplate","slots","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","hashCode","()I","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.I(31));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/item/SealedTemplate","name","Ljava/lang/String;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",21);}
case 21:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=22;continue;}
case 22:{f.Locals[1]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11435(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/item/SealedTemplate"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/SealedTemplate")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(4));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.NewArray("Lorg/apache/commons/lang3/tuple/Pair;",f.Pop().Int)));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Common")));f.Pc=13;continue;}
case 13:{f.Push(JValue.I(10));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",18);}
case 18:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",21);}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Uncommon")));f.Pc=26;continue;}
case 26:{f.Push(JValue.I(3));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",30);}
case 30:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",33);}
case 33:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{f.Push(JValue.I(2));f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("RareMythic")));f.Pc=38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",42);}
case 42:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",45);}
case 45:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=46;continue;}
case 46:{f.StackOp("dup");f.Pc=47;continue;}
case 47:{f.Push(JValue.I(3));f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("BasicLand")));f.Pc=50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",54);}
case 54:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",57);}
case 57:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=58;continue;}
case 58:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",61);}
case 61:{return rt.Call(f,"forge/item/SealedTemplate","<init>","(Ljava/lang/String;Ljava/lang/Iterable;)V","invokespecial",64);}
case 64:{if(!rt.StaticReady(f,"forge/item/SealedTemplate","genericDraftBooster","Lforge/item/SealedTemplate;"))return JStep.Continue;rt.PutStatic("forge/item/SealedTemplate","genericDraftBooster","Lforge/item/SealedTemplate;",f.Pop());f.Pc=67;continue;}
case 67:{if(!rt.EnsureInitialized(f,"forge/item/SealedTemplate"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/SealedTemplate")));f.Pc=70;continue;}
case 70:{f.StackOp("dup");f.Pc=71;continue;}
case 71:{f.Push(JValue.R(null));f.Pc=72;continue;}
case 72:{f.Push(JValue.I(1));f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.NewArray("Lorg/apache/commons/lang3/tuple/Pair;",f.Pop().Int)));f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("Any")));f.Pc=80;continue;}
case 80:{f.Push(JValue.I(15));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",85);}
case 85:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",88);}
case 88:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=89;continue;}
case 89:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",92);}
case 92:{return rt.Call(f,"forge/item/SealedTemplate","<init>","(Ljava/lang/String;Ljava/lang/Iterable;)V","invokespecial",95);}
case 95:{if(!rt.StaticReady(f,"forge/item/SealedTemplate","genericNoSlotBooster","Lforge/item/SealedTemplate;"))return JStep.Continue;rt.PutStatic("forge/item/SealedTemplate","genericNoSlotBooster","Lforge/item/SealedTemplate;",f.Pop());f.Pc=98;continue;}
case 98:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
