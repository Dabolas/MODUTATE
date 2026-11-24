// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1056{
internal static JClass Build(){var c=new JClass("forge/item/BoxedProduct","forge/item/SealedProduct",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("boosterPacks","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("currentPack","I",false,JValue.Default("I"),null));
c.Add(new JField("numberOfPacks","I",false,JValue.Default("I"),null));
c.Add(new JMethod(11197,"forge/item/BoxedProduct","<init>","(Ljava/lang/String;Lforge/item/SealedTemplate;I)V",1,4,3,new JHandler[]{},M11197));
c.Add(new JMethod(11198,"forge/item/BoxedProduct","boosterPacksRemaining","()I",1,1,2,new JHandler[]{},M11198));
c.Add(new JMethod(11199,"forge/item/BoxedProduct","getNextBoosterPack","()Ljava/util/List;",17,2,5,new JHandler[]{},M11199));
c.Add(new JMethod(11200,"forge/item/BoxedProduct","getCards","()Ljava/util/List;",1,2,3,new JHandler[]{},M11200));
c.Add(new JMethod(11201,"forge/item/BoxedProduct","getExtraCards","()Ljava/util/List;",1,1,2,new JHandler[]{},M11201));
c.Add(new JMethod(11202,"forge/item/BoxedProduct","getTotalCards","()I",1,1,2,new JHandler[]{},M11202));
}

internal static JStep M11197(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/item/SealedProduct","<init>","(Ljava/lang/String;Lforge/item/SealedTemplate;)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",14);}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/BoxedProduct","boosterPacks","Ljava/util/List;",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/BoxedProduct","numberOfPacks","I",value);f.Pc=22;continue;}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11198(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","numberOfPacks","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","currentPack","I"));f.Pc=8;continue;}
case 8:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11199(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","boosterPacks","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int!=0?76:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",20);}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/BoxedProduct","cards","Ljava/util/List;",value);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Locals[1]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","numberOfPacks","I"));f.Pc=30;continue;}
case 30:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?76:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","boosterPacks","Ljava/util/List;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/item/BoxedProduct","generate","()Ljava/util/List;","invokevirtual",41);}
case 41:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","cards","Ljava/util/List;"));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","boosterPacks","Ljava/util/List;"));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=73;continue;}
case 73:{f.Pc=25;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","boosterPacks","Ljava/util/List;"));f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","currentPack","I"));f.Pc=85;continue;}
case 85:{f.StackOp("dup_x1");f.Pc=86;continue;}
case 86:{f.Push(JValue.I(1));f.Pc=87;continue;}
case 87:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=88;continue;}
case 88:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/BoxedProduct","currentPack","I",value);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",96);}
case 96:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=99;continue;}
case 99:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11200(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","boosterPacks","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int!=0?76:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",20);}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/BoxedProduct","cards","Ljava/util/List;",value);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Locals[1]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","numberOfPacks","I"));f.Pc=30;continue;}
case 30:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?76:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","boosterPacks","Ljava/util/List;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/item/BoxedProduct","generate","()Ljava/util/List;","invokevirtual",41);}
case 41:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","cards","Ljava/util/List;"));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","boosterPacks","Ljava/util/List;"));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=73;continue;}
case 73:{f.Pc=25;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","cards","Ljava/util/List;"));f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/item/BoxedProduct","getExtraCards","()Ljava/util/List;","invokevirtual",84);}
case 84:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",89);}
case 89:{f.StackOp("pop");f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","cards","Ljava/util/List;"));f.Pc=94;continue;}
case 94:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11201(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11202(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","contents","Lforge/item/SealedTemplate;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/item/SealedTemplate","getNumberOfCardsExpected","()I","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/item/BoxedProduct","numberOfPacks","I"));f.Pc=11;continue;}
case 11:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
