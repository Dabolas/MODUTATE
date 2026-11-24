// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C28{
internal static JClass Build(){var c=new JClass("forge/card/CardEdition$Type","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("UNKNOWN","Lforge/card/CardEdition$Type;",true,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("CORE","Lforge/card/CardEdition$Type;",true,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("EXPANSION","Lforge/card/CardEdition$Type;",true,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("STARTER","Lforge/card/CardEdition$Type;",true,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("REPRINT","Lforge/card/CardEdition$Type;",true,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("BOXED_SET","Lforge/card/CardEdition$Type;",true,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("COLLECTOR_EDITION","Lforge/card/CardEdition$Type;",true,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("DUEL_DECK","Lforge/card/CardEdition$Type;",true,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("PROMO","Lforge/card/CardEdition$Type;",true,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("ONLINE","Lforge/card/CardEdition$Type;",true,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("DRAFT","Lforge/card/CardEdition$Type;",true,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("COMMANDER","Lforge/card/CardEdition$Type;",true,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("MULTIPLAYER","Lforge/card/CardEdition$Type;",true,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("FUNNY","Lforge/card/CardEdition$Type;",true,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("OTHER","Lforge/card/CardEdition$Type;",true,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("CUSTOM_SET","Lforge/card/CardEdition$Type;",true,JValue.Default("Lforge/card/CardEdition$Type;"),null));
c.Add(new JField("REPRINT_SET_TYPES","Ljava/util/EnumSet;",true,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JField("$VALUES","[Lforge/card/CardEdition$Type;",true,JValue.Default("[Lforge/card/CardEdition$Type;"),null));
c.Add(new JMethod(502,"forge/card/CardEdition$Type","values","()[Lforge/card/CardEdition$Type;",9,0,1,new JHandler[]{},M502));
c.Add(new JMethod(503,"forge/card/CardEdition$Type","valueOf","(Ljava/lang/String;)Lforge/card/CardEdition$Type;",9,1,2,new JHandler[]{},M503));
c.Add(new JMethod(504,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M504));
c.Add(new JMethod(505,"forge/card/CardEdition$Type","getBoosterBoxDefault","()Ljava/lang/String;",1,1,2,new JHandler[]{},M505));
c.Add(new JMethod(506,"forge/card/CardEdition$Type","getFatPackDefault","()Ljava/lang/String;",1,1,2,new JHandler[]{},M506));
c.Add(new JMethod(507,"forge/card/CardEdition$Type","toString","()Ljava/lang/String;",1,3,4,new JHandler[]{},M507));
c.Add(new JMethod(508,"forge/card/CardEdition$Type","fromString","(Ljava/lang/String;)Lforge/card/CardEdition$Type;",9,3,2,new JHandler[]{},M508));
c.Add(new JMethod(509,"forge/card/CardEdition$Type","$values","()[Lforge/card/CardEdition$Type;",4106,0,4,new JHandler[]{},M509));
c.Add(new JMethod(510,"forge/card/CardEdition$Type","<clinit>","()V",8,0,4,new JHandler[]{},M510));
}

internal static JStep M502(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","$VALUES","[Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","$VALUES","[Lforge/card/CardEdition$Type;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/CardEdition$Type;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/CardEdition$Type;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M503(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/CardEdition$Type")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$Type"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M504(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M505(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardEdition$1","$SwitchMap$forge$card$CardEdition$Type","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$1","$SwitchMap$forge$card$CardEdition$Type","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardEdition$Type","ordinal","()I","invokevirtual",7);}
case 7:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8;continue;}
case 8:{switch(f.Pop().Int){case 1:f.Pc=36;break;case 2:f.Pc=36;break;default:f.Pc=41;break;}continue;}
case 36:{f.Push(JValue.R(rt.String("36")));f.Pc=38;continue;}
case 38:{f.Pc=43;continue;}
case 41:{f.Push(JValue.R(rt.String("0")));f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M506(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardEdition$1","$SwitchMap$forge$card$CardEdition$Type","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$1","$SwitchMap$forge$card$CardEdition$Type","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardEdition$Type","ordinal","()I","invokevirtual",7);}
case 7:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8;continue;}
case 8:{switch(f.Pop().Int){case 1:f.Pc=36;break;case 2:f.Pc=36;break;default:f.Pc=41;break;}continue;}
case 36:{f.Push(JValue.R(rt.String("10")));f.Pc=38;continue;}
case 38:{f.Pc=43;continue;}
case 41:{f.Push(JValue.R(rt.String("0")));f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M507(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardEdition$Type","name","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Push(JValue.I(95));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=18;continue;}
case 18:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?36:21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/util/TextUtil","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",29);}
case 29:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=30;continue;}
case 30:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=33;continue;}
case 33:{f.Pc=15;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",40);}
case 40:{f.Push(JValue.R(rt.String(" ")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/util/TextUtil","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",45);}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M508(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","toUpperCase","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.I(32));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",9);}
case 9:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("_")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/util/TextUtil","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/card/CardEdition$Type","valueOf","(Ljava/lang/String;)Lforge/card/CardEdition$Type;","invokestatic",24);}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M509(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(16));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/card/CardEdition$Type;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","UNKNOWN","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","UNKNOWN","Lforge/card/CardEdition$Type;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","CORE","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","CORE","Lforge/card/CardEdition$Type;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","STARTER","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","STARTER","Lforge/card/CardEdition$Type;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","REPRINT","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","REPRINT","Lforge/card/CardEdition$Type;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","BOXED_SET","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","BOXED_SET","Lforge/card/CardEdition$Type;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","COLLECTOR_EDITION","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","COLLECTOR_EDITION","Lforge/card/CardEdition$Type;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","DUEL_DECK","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","DUEL_DECK","Lforge/card/CardEdition$Type;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","PROMO","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","PROMO","Lforge/card/CardEdition$Type;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","ONLINE","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","ONLINE","Lforge/card/CardEdition$Type;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","DRAFT","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","DRAFT","Lforge/card/CardEdition$Type;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(11));f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","COMMANDER","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","COMMANDER","Lforge/card/CardEdition$Type;"));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(12));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","MULTIPLAYER","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","MULTIPLAYER","Lforge/card/CardEdition$Type;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(13));f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","FUNNY","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","FUNNY","Lforge/card/CardEdition$Type;"));f.Pc=96;continue;}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(14));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","OTHER","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","OTHER","Lforge/card/CardEdition$Type;"));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{f.StackOp("dup");f.Pc=105;continue;}
case 105:{f.Push(JValue.I(15));f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","CUSTOM_SET","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","CUSTOM_SET","Lforge/card/CardEdition$Type;"));f.Pc=110;continue;}
case 110:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=111;continue;}
case 111:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M510(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Type"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Type")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("UNKNOWN")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","UNKNOWN","Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","UNKNOWN","Lforge/card/CardEdition$Type;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Type"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Type")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("CORE")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","CORE","Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","CORE","Lforge/card/CardEdition$Type;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Type"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Type")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("EXPANSION")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Type"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Type")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("STARTER")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","STARTER","Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","STARTER","Lforge/card/CardEdition$Type;",f.Pop());f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Type"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Type")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("REPRINT")));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(4));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V","invokespecial",62);}
case 62:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","REPRINT","Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","REPRINT","Lforge/card/CardEdition$Type;",f.Pop());f.Pc=65;continue;}
case 65:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Type"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Type")));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("BOXED_SET")));f.Pc=71;continue;}
case 71:{f.Push(JValue.I(5));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V","invokespecial",75);}
case 75:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","BOXED_SET","Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","BOXED_SET","Lforge/card/CardEdition$Type;",f.Pop());f.Pc=78;continue;}
case 78:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Type"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Type")));f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("COLLECTOR_EDITION")));f.Pc=84;continue;}
case 84:{f.Push(JValue.I(6));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V","invokespecial",89);}
case 89:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","COLLECTOR_EDITION","Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","COLLECTOR_EDITION","Lforge/card/CardEdition$Type;",f.Pop());f.Pc=92;continue;}
case 92:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Type"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Type")));f.Pc=95;continue;}
case 95:{f.StackOp("dup");f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("DUEL_DECK")));f.Pc=98;continue;}
case 98:{f.Push(JValue.I(7));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V","invokespecial",103);}
case 103:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","DUEL_DECK","Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","DUEL_DECK","Lforge/card/CardEdition$Type;",f.Pop());f.Pc=106;continue;}
case 106:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Type"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Type")));f.Pc=109;continue;}
case 109:{f.StackOp("dup");f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("PROMO")));f.Pc=112;continue;}
case 112:{f.Push(JValue.I(8));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V","invokespecial",117);}
case 117:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","PROMO","Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","PROMO","Lforge/card/CardEdition$Type;",f.Pop());f.Pc=120;continue;}
case 120:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Type"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Type")));f.Pc=123;continue;}
case 123:{f.StackOp("dup");f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("ONLINE")));f.Pc=126;continue;}
case 126:{f.Push(JValue.I(9));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V","invokespecial",131);}
case 131:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","ONLINE","Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","ONLINE","Lforge/card/CardEdition$Type;",f.Pop());f.Pc=134;continue;}
case 134:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Type"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Type")));f.Pc=137;continue;}
case 137:{f.StackOp("dup");f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("DRAFT")));f.Pc=140;continue;}
case 140:{f.Push(JValue.I(10));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V","invokespecial",145);}
case 145:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","DRAFT","Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","DRAFT","Lforge/card/CardEdition$Type;",f.Pop());f.Pc=148;continue;}
case 148:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Type"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Type")));f.Pc=151;continue;}
case 151:{f.StackOp("dup");f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("COMMANDER")));f.Pc=154;continue;}
case 154:{f.Push(JValue.I(11));f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V","invokespecial",159);}
case 159:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","COMMANDER","Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","COMMANDER","Lforge/card/CardEdition$Type;",f.Pop());f.Pc=162;continue;}
case 162:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Type"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Type")));f.Pc=165;continue;}
case 165:{f.StackOp("dup");f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("MULTIPLAYER")));f.Pc=168;continue;}
case 168:{f.Push(JValue.I(12));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V","invokespecial",173);}
case 173:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","MULTIPLAYER","Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","MULTIPLAYER","Lforge/card/CardEdition$Type;",f.Pop());f.Pc=176;continue;}
case 176:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Type"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Type")));f.Pc=179;continue;}
case 179:{f.StackOp("dup");f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("FUNNY")));f.Pc=182;continue;}
case 182:{f.Push(JValue.I(13));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V","invokespecial",187);}
case 187:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","FUNNY","Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","FUNNY","Lforge/card/CardEdition$Type;",f.Pop());f.Pc=190;continue;}
case 190:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Type"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Type")));f.Pc=193;continue;}
case 193:{f.StackOp("dup");f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("OTHER")));f.Pc=196;continue;}
case 196:{f.Push(JValue.I(14));f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V","invokespecial",201);}
case 201:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","OTHER","Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","OTHER","Lforge/card/CardEdition$Type;",f.Pop());f.Pc=204;continue;}
case 204:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Type"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Type")));f.Pc=207;continue;}
case 207:{f.StackOp("dup");f.Pc=208;continue;}
case 208:{f.Push(JValue.R(rt.String("CUSTOM_SET")));f.Pc=210;continue;}
case 210:{f.Push(JValue.I(15));f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/card/CardEdition$Type","<init>","(Ljava/lang/String;I)V","invokespecial",215);}
case 215:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","CUSTOM_SET","Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","CUSTOM_SET","Lforge/card/CardEdition$Type;",f.Pop());f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/card/CardEdition$Type","$values","()[Lforge/card/CardEdition$Type;","invokestatic",221);}
case 221:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","$VALUES","[Lforge/card/CardEdition$Type;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","$VALUES","[Lforge/card/CardEdition$Type;",f.Pop());f.Pc=224;continue;}
case 224:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","REPRINT","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","REPRINT","Lforge/card/CardEdition$Type;"));f.Pc=227;continue;}
case 227:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","PROMO","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","PROMO","Lforge/card/CardEdition$Type;"));f.Pc=230;continue;}
case 230:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","COLLECTOR_EDITION","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","COLLECTOR_EDITION","Lforge/card/CardEdition$Type;"));f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",236);}
case 236:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","REPRINT_SET_TYPES","Ljava/util/EnumSet;"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$Type","REPRINT_SET_TYPES","Ljava/util/EnumSet;",f.Pop());f.Pc=239;continue;}
case 239:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
