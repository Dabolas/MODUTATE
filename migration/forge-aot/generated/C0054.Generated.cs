// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C54{
internal static JClass Build(){var c=new JClass("forge/card/CardType$Supertype","java/lang/Enum",new string[]{"forge/util/ITranslatable"},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("Basic","Lforge/card/CardType$Supertype;",true,JValue.Default("Lforge/card/CardType$Supertype;"),null));
c.Add(new JField("Elite","Lforge/card/CardType$Supertype;",true,JValue.Default("Lforge/card/CardType$Supertype;"),null));
c.Add(new JField("Host","Lforge/card/CardType$Supertype;",true,JValue.Default("Lforge/card/CardType$Supertype;"),null));
c.Add(new JField("Legendary","Lforge/card/CardType$Supertype;",true,JValue.Default("Lforge/card/CardType$Supertype;"),null));
c.Add(new JField("Snow","Lforge/card/CardType$Supertype;",true,JValue.Default("Lforge/card/CardType$Supertype;"),null));
c.Add(new JField("Ongoing","Lforge/card/CardType$Supertype;",true,JValue.Default("Lforge/card/CardType$Supertype;"),null));
c.Add(new JField("World","Lforge/card/CardType$Supertype;",true,JValue.Default("Lforge/card/CardType$Supertype;"),null));
c.Add(new JField("label","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("stringToSupertype","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("$VALUES","[Lforge/card/CardType$Supertype;",true,JValue.Default("[Lforge/card/CardType$Supertype;"),null));
c.Add(new JMethod(909,"forge/card/CardType$Supertype","values","()[Lforge/card/CardType$Supertype;",9,0,1,new JHandler[]{},M909));
c.Add(new JMethod(910,"forge/card/CardType$Supertype","valueOf","(Ljava/lang/String;)Lforge/card/CardType$Supertype;",9,1,2,new JHandler[]{},M910));
c.Add(new JMethod(911,"forge/card/CardType$Supertype","getEnum","(Ljava/lang/String;)Lforge/card/CardType$Supertype;",9,1,2,new JHandler[]{},M911));
c.Add(new JMethod(912,"forge/card/CardType$Supertype","isValidEnum","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M912));
c.Add(new JMethod(913,"forge/card/CardType$Supertype","<init>","(Ljava/lang/String;ILjava/lang/String;)V",2,4,3,new JHandler[]{},M913));
c.Add(new JMethod(914,"forge/card/CardType$Supertype","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M914));
c.Add(new JMethod(915,"forge/card/CardType$Supertype","getTranslatedName","()Ljava/lang/String;",1,1,3,new JHandler[]{},M915));
c.Add(new JMethod(916,"forge/card/CardType$Supertype","$values","()[Lforge/card/CardType$Supertype;",4106,0,4,new JHandler[]{},M916));
c.Add(new JMethod(917,"forge/card/CardType$Supertype","<clinit>","()V",8,0,5,new JHandler[]{},M917));
}

internal static JStep M909(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","$VALUES","[Lforge/card/CardType$Supertype;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","$VALUES","[Lforge/card/CardType$Supertype;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/CardType$Supertype;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/CardType$Supertype;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M910(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/CardType$Supertype")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$Supertype"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M911(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","stringToSupertype","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","stringToSupertype","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$Supertype"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M912(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","stringToSupertype","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","stringToSupertype","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M913(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType$Supertype","label","Ljava/lang/String;",value);f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M914(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType$Supertype","name","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M915(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType$Supertype","label","Ljava/lang/String;"));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M916(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(7));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/card/CardType$Supertype;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Basic","Lforge/card/CardType$Supertype;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","Basic","Lforge/card/CardType$Supertype;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Elite","Lforge/card/CardType$Supertype;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","Elite","Lforge/card/CardType$Supertype;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Host","Lforge/card/CardType$Supertype;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","Host","Lforge/card/CardType$Supertype;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Legendary","Lforge/card/CardType$Supertype;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","Legendary","Lforge/card/CardType$Supertype;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Snow","Lforge/card/CardType$Supertype;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","Snow","Lforge/card/CardType$Supertype;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Ongoing","Lforge/card/CardType$Supertype;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","Ongoing","Lforge/card/CardType$Supertype;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","World","Lforge/card/CardType$Supertype;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","World","Lforge/card/CardType$Supertype;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M917(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardType$Supertype"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$Supertype")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Basic")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("lblBasic")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardType$Supertype","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",12);}
case 12:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Basic","Lforge/card/CardType$Supertype;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Supertype","Basic","Lforge/card/CardType$Supertype;",f.Pop());f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"forge/card/CardType$Supertype"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$Supertype")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Elite")));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("lblElite")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/card/CardType$Supertype","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",27);}
case 27:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Elite","Lforge/card/CardType$Supertype;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Supertype","Elite","Lforge/card/CardType$Supertype;",f.Pop());f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"forge/card/CardType$Supertype"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$Supertype")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("Host")));f.Pc=36;continue;}
case 36:{f.Push(JValue.I(2));f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("lblHost")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/card/CardType$Supertype","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",42);}
case 42:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Host","Lforge/card/CardType$Supertype;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Supertype","Host","Lforge/card/CardType$Supertype;",f.Pop());f.Pc=45;continue;}
case 45:{if(!rt.EnsureInitialized(f,"forge/card/CardType$Supertype"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$Supertype")));f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("Legendary")));f.Pc=51;continue;}
case 51:{f.Push(JValue.I(3));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("lblLegendary")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/card/CardType$Supertype","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",57);}
case 57:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Legendary","Lforge/card/CardType$Supertype;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Supertype","Legendary","Lforge/card/CardType$Supertype;",f.Pop());f.Pc=60;continue;}
case 60:{if(!rt.EnsureInitialized(f,"forge/card/CardType$Supertype"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$Supertype")));f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("Snow")));f.Pc=66;continue;}
case 66:{f.Push(JValue.I(4));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("lblSnow")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/card/CardType$Supertype","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",72);}
case 72:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Snow","Lforge/card/CardType$Supertype;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Supertype","Snow","Lforge/card/CardType$Supertype;",f.Pop());f.Pc=75;continue;}
case 75:{if(!rt.EnsureInitialized(f,"forge/card/CardType$Supertype"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$Supertype")));f.Pc=78;continue;}
case 78:{f.StackOp("dup");f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("Ongoing")));f.Pc=81;continue;}
case 81:{f.Push(JValue.I(5));f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("lblOngoing")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/card/CardType$Supertype","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",87);}
case 87:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Ongoing","Lforge/card/CardType$Supertype;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Supertype","Ongoing","Lforge/card/CardType$Supertype;",f.Pop());f.Pc=90;continue;}
case 90:{if(!rt.EnsureInitialized(f,"forge/card/CardType$Supertype"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$Supertype")));f.Pc=93;continue;}
case 93:{f.StackOp("dup");f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("World")));f.Pc=96;continue;}
case 96:{f.Push(JValue.I(6));f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("lblWorld")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/card/CardType$Supertype","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",103);}
case 103:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","World","Lforge/card/CardType$Supertype;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Supertype","World","Lforge/card/CardType$Supertype;",f.Pop());f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/card/CardType$Supertype","$values","()[Lforge/card/CardType$Supertype;","invokestatic",109);}
case 109:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","$VALUES","[Lforge/card/CardType$Supertype;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Supertype","$VALUES","[Lforge/card/CardType$Supertype;",f.Pop());f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.ClassObject("forge/card/CardType$Supertype")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"org/apache/commons/lang3/EnumUtils","getEnumMap","(Ljava/lang/Class;)Ljava/util/Map;","invokestatic",117);}
case 117:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","stringToSupertype","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Supertype","stringToSupertype","Ljava/util/Map;",f.Pop());f.Pc=120;continue;}
case 120:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
