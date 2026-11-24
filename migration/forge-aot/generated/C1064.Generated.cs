// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1064{
internal static JClass Build(){var c=new JClass("forge/item/PaperCard$PaperCardFlags","java/lang/Object",new string[]{"java/io/Serializable"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-3924720485840169336L),null));
c.Add(new JField("markedColors","Lforge/card/ColorSet;",false,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("noSellValue","Z",false,JValue.Default("Z"),null));
c.Add(new JField("IDENTITY_FLAGS","Lforge/item/PaperCard$PaperCardFlags;",true,JValue.Default("Lforge/item/PaperCard$PaperCardFlags;"),null));
c.Add(new JField("asMap","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(11301,"forge/item/PaperCard$PaperCardFlags","<init>","(Ljava/util/Map;)V",4,2,3,new JHandler[]{},M11301));
c.Add(new JMethod(11302,"forge/item/PaperCard$PaperCardFlags","<init>","(Lforge/item/PaperCard$PaperCardFlags;Lforge/card/ColorSet;Ljava/lang/Boolean;)V",2,4,2,new JHandler[]{},M11302));
c.Add(new JMethod(11303,"forge/item/PaperCard$PaperCardFlags","withMarkedColors","(Lforge/card/ColorSet;)Lforge/item/PaperCard$PaperCardFlags;",1,2,5,new JHandler[]{},M11303));
c.Add(new JMethod(11304,"forge/item/PaperCard$PaperCardFlags","withNoSellValueFlag","(Z)Lforge/item/PaperCard$PaperCardFlags;",1,2,5,new JHandler[]{},M11304));
c.Add(new JMethod(11305,"forge/item/PaperCard$PaperCardFlags","toMap","()Ljava/util/Map;",1,2,3,new JHandler[]{},M11305));
c.Add(new JMethod(11306,"forge/item/PaperCard$PaperCardFlags","toString","()Ljava/lang/String;",1,1,2,new JHandler[]{},M11306));
c.Add(new JMethod(11307,"forge/item/PaperCard$PaperCardFlags","equals","(Ljava/lang/Object;)Z",1,3,2,new JHandler[]{},M11307));
c.Add(new JMethod(11308,"forge/item/PaperCard$PaperCardFlags","hashCode","()I",1,1,4,new JHandler[]{},M11308));
c.Add(new JMethod(11309,"forge/item/PaperCard$PaperCardFlags","lambda$toString$0","(Ljava/util/Map$Entry;)Ljava/lang/String;",4106,1,2,new JHandler[]{},M11309));
c.Add(new JMethod(11310,"forge/item/PaperCard$PaperCardFlags","<clinit>","()V",8,0,3,new JHandler[]{},M11310));
}

internal static JStep M11301(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("markedColors")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{f.Pc=f.Pop().Int==0?41:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("markedColors")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",32);}
case 32:{return rt.Call(f,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",35);}
case 35:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","markedColors","Lforge/card/ColorSet;",value);f.Pc=38;continue;}
case 38:{f.Pc=46;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(null));f.Pc=43;continue;}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","markedColors","Lforge/card/ColorSet;",value);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("noSellValue")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",55);}
case 55:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","noSellValue","Z",value);f.Pc=58;continue;}
case 58:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11302(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference!=null?16:8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","markedColors","Lforge/card/ColorSet;"));f.Pc=12;continue;}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Pc=25;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?25:23;continue;}
case 23:{f.Push(JValue.R(null));f.Pc=24;continue;}
case 24:{f.Locals[2]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","markedColors","Lforge/card/ColorSet;",value);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Reference==null?42:35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",39);}
case 39:{f.Pc=46;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","noSellValue","Z"));f.Pc=46;continue;}
case 46:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","noSellValue","Z",value);f.Pc=49;continue;}
case 49:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11303(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?8:4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/ColorSet","C","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","C","Lforge/card/ColorSet;"));f.Pc=7;continue;}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard$PaperCardFlags"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard$PaperCardFlags")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(null));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/item/PaperCard$PaperCardFlags","<init>","(Lforge/item/PaperCard$PaperCardFlags;Lforge/card/ColorSet;Ljava/lang/Boolean;)V","invokespecial",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11304(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard$PaperCardFlags"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard$PaperCardFlags")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",10);}
case 10:{return rt.Call(f,"forge/item/PaperCard$PaperCardFlags","<init>","(Lforge/item/PaperCard$PaperCardFlags;Lforge/card/ColorSet;Ljava/lang/Boolean;)V","invokespecial",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11305(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","asMap","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","asMap","Ljava/util/Map;"));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",19);}
case 19:{f.Locals[1]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","markedColors","Lforge/card/ColorSet;"));f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Reference==null?53:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","markedColors","Lforge/card/ColorSet;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int!=0?53:37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("markedColors")));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","markedColors","Lforge/card/ColorSet;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/card/ColorSet","toString","()Ljava/lang/String;","invokevirtual",47);}
case 47:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","noSellValue","Z"));f.Pc=57;continue;}
case 57:{f.Pc=f.Pop().Int==0?71:60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("noSellValue")));f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("true")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","asMap","Ljava/util/Map;",value);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11306(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard$PaperCardFlags","toMap","()Ljava/util/Map;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",14);}
case 14:{return rt.DynamicCall(f,"forge/item/PaperCard$PaperCardFlags:11306:14:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",19);}
case 19:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",24);}
case 24:{f.Push(JValue.R(rt.String("\t")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/stream/Collectors","joining","(Ljava/lang/CharSequence;)Ljava/util/stream/Collector;","invokestatic",29);}
case 29:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11307(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/item/PaperCard$PaperCardFlags")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?15:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard$PaperCardFlags"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Pc=17;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","noSellValue","Z"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","noSellValue","Z"));f.Pc=25;continue;}
case 25:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?46:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","markedColors","Lforge/card/ColorSet;"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","markedColors","Lforge/card/ColorSet;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Objects","equals","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",39);}
case 39:{f.Pc=f.Pop().Int==0?46:42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{f.Pc=47;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11308(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(2));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","markedColors","Lforge/card/ColorSet;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperCard$PaperCardFlags","noSellValue","Z"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",20);}
case 20:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Objects","hash","([Ljava/lang/Object;)I","invokestatic",24);}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11309(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{return rt.DynamicCall(f,"forge/item/PaperCard$PaperCardFlags:11309:18:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",23);}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11310(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard$PaperCardFlags"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard$PaperCardFlags")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","of","()Ljava/util/Map;","invokestatic",7);}
case 7:{return rt.Call(f,"forge/item/PaperCard$PaperCardFlags","<init>","(Ljava/util/Map;)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/item/PaperCard$PaperCardFlags","IDENTITY_FLAGS","Lforge/item/PaperCard$PaperCardFlags;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCard$PaperCardFlags","IDENTITY_FLAGS","Lforge/item/PaperCard$PaperCardFlags;",f.Pop());f.Pc=13;continue;}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
