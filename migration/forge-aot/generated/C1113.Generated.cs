// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1113{
internal static JClass Build(){var c=new JClass("forge/util/ComparableOp","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("EQUALS","Lforge/util/ComparableOp;",true,JValue.Default("Lforge/util/ComparableOp;"),null));
c.Add(new JField("NOT_EQUALS","Lforge/util/ComparableOp;",true,JValue.Default("Lforge/util/ComparableOp;"),null));
c.Add(new JField("GREATER_THAN","Lforge/util/ComparableOp;",true,JValue.Default("Lforge/util/ComparableOp;"),null));
c.Add(new JField("LESS_THAN","Lforge/util/ComparableOp;",true,JValue.Default("Lforge/util/ComparableOp;"),null));
c.Add(new JField("GT_OR_EQUAL","Lforge/util/ComparableOp;",true,JValue.Default("Lforge/util/ComparableOp;"),null));
c.Add(new JField("LT_OR_EQUAL","Lforge/util/ComparableOp;",true,JValue.Default("Lforge/util/ComparableOp;"),null));
c.Add(new JField("caption","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("$VALUES","[Lforge/util/ComparableOp;",true,JValue.Default("[Lforge/util/ComparableOp;"),null));
c.Add(new JMethod(11710,"forge/util/ComparableOp","values","()[Lforge/util/ComparableOp;",9,0,1,new JHandler[]{},M11710));
c.Add(new JMethod(11711,"forge/util/ComparableOp","valueOf","(Ljava/lang/String;)Lforge/util/ComparableOp;",9,1,2,new JHandler[]{},M11711));
c.Add(new JMethod(11712,"forge/util/ComparableOp","<init>","(Ljava/lang/String;ILjava/lang/String;)V",2,4,3,new JHandler[]{},M11712));
c.Add(new JMethod(11713,"forge/util/ComparableOp","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11713));
c.Add(new JMethod(11714,"forge/util/ComparableOp","apply","(Ljava/lang/Integer;Ljava/lang/Integer;)Z",1,3,2,new JHandler[]{},M11714));
c.Add(new JMethod(11715,"forge/util/ComparableOp","$values","()[Lforge/util/ComparableOp;",4106,0,4,new JHandler[]{},M11715));
c.Add(new JMethod(11716,"forge/util/ComparableOp","<clinit>","()V",8,0,5,new JHandler[]{},M11716));
}

internal static JStep M11710(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/ComparableOp","$VALUES","[Lforge/util/ComparableOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ComparableOp","$VALUES","[Lforge/util/ComparableOp;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/util/ComparableOp;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/util/ComparableOp;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11711(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/util/ComparableOp")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/ComparableOp"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11712(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/ComparableOp","caption","Ljava/lang/String;",value);f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11713(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/ComparableOp","caption","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11714(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?8:4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference!=null?10:8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10:{if(!rt.StaticReady(f,"forge/util/ComparableOp$1","$SwitchMap$forge$util$ComparableOp","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ComparableOp$1","$SwitchMap$forge$util$ComparableOp","[I"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/util/ComparableOp","ordinal","()I","invokevirtual",17);}
case 17:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=18;continue;}
case 18:{switch(f.Pop().Int){case 1:f.Pc=56;break;case 2:f.Pc=67;break;case 3:f.Pc=84;break;case 4:f.Pc=101;break;case 5:f.Pc=118;break;case 6:f.Pc=135;break;default:f.Pc=146;break;}continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?65:61;continue;}
case 61:{f.Push(JValue.I(1));f.Pc=62;continue;}
case 62:{f.Pc=66;continue;}
case 65:{f.Push(JValue.I(0));f.Pc=66;continue;}
case 66:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",71);}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",75);}
case 75:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?82:78;continue;}
case 78:{f.Push(JValue.I(1));f.Pc=79;continue;}
case 79:{f.Pc=83;continue;}
case 82:{f.Push(JValue.I(0));f.Pc=83;continue;}
case 83:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",88);}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",92);}
case 92:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?99:95;continue;}
case 95:{f.Push(JValue.I(1));f.Pc=96;continue;}
case 96:{f.Pc=100;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",105);}
case 105:{f.Push(f.Locals[2]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",109);}
case 109:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?116:112;continue;}
case 112:{f.Push(JValue.I(1));f.Pc=113;continue;}
case 113:{f.Pc=117;continue;}
case 116:{f.Push(JValue.I(0));f.Pc=117;continue;}
case 117:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",122);}
case 122:{f.Push(f.Locals[2]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",126);}
case 126:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?133:129;continue;}
case 129:{f.Push(JValue.I(1));f.Pc=130;continue;}
case 130:{f.Pc=134;continue;}
case 133:{f.Push(JValue.I(0));f.Pc=134;continue;}
case 134:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[2]);f.Pc=137;continue;}
case 137:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?144:140;continue;}
case 140:{f.Push(JValue.I(1));f.Pc=141;continue;}
case 141:{f.Pc=145;continue;}
case 144:{f.Push(JValue.I(0));f.Pc=145;continue;}
case 145:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 146:{f.Push(JValue.I(0));f.Pc=147;continue;}
case 147:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11715(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(6));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/util/ComparableOp;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/util/ComparableOp","EQUALS","Lforge/util/ComparableOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ComparableOp","EQUALS","Lforge/util/ComparableOp;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/util/ComparableOp","NOT_EQUALS","Lforge/util/ComparableOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ComparableOp","NOT_EQUALS","Lforge/util/ComparableOp;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/util/ComparableOp","GREATER_THAN","Lforge/util/ComparableOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ComparableOp","GREATER_THAN","Lforge/util/ComparableOp;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/util/ComparableOp","LESS_THAN","Lforge/util/ComparableOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ComparableOp","LESS_THAN","Lforge/util/ComparableOp;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/util/ComparableOp","GT_OR_EQUAL","Lforge/util/ComparableOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ComparableOp","GT_OR_EQUAL","Lforge/util/ComparableOp;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/util/ComparableOp","LT_OR_EQUAL","Lforge/util/ComparableOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ComparableOp","LT_OR_EQUAL","Lforge/util/ComparableOp;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11716(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/ComparableOp"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/ComparableOp")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("EQUALS")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("==")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/ComparableOp","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",12);}
case 12:{if(!rt.StaticReady(f,"forge/util/ComparableOp","EQUALS","Lforge/util/ComparableOp;"))return JStep.Continue;rt.PutStatic("forge/util/ComparableOp","EQUALS","Lforge/util/ComparableOp;",f.Pop());f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"forge/util/ComparableOp"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/ComparableOp")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("NOT_EQUALS")));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("!=")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/util/ComparableOp","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",27);}
case 27:{if(!rt.StaticReady(f,"forge/util/ComparableOp","NOT_EQUALS","Lforge/util/ComparableOp;"))return JStep.Continue;rt.PutStatic("forge/util/ComparableOp","NOT_EQUALS","Lforge/util/ComparableOp;",f.Pop());f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"forge/util/ComparableOp"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/ComparableOp")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("GREATER_THAN")));f.Pc=36;continue;}
case 36:{f.Push(JValue.I(2));f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String(">")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/util/ComparableOp","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",42);}
case 42:{if(!rt.StaticReady(f,"forge/util/ComparableOp","GREATER_THAN","Lforge/util/ComparableOp;"))return JStep.Continue;rt.PutStatic("forge/util/ComparableOp","GREATER_THAN","Lforge/util/ComparableOp;",f.Pop());f.Pc=45;continue;}
case 45:{if(!rt.EnsureInitialized(f,"forge/util/ComparableOp"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/ComparableOp")));f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("LESS_THAN")));f.Pc=51;continue;}
case 51:{f.Push(JValue.I(3));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("<")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/util/ComparableOp","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",57);}
case 57:{if(!rt.StaticReady(f,"forge/util/ComparableOp","LESS_THAN","Lforge/util/ComparableOp;"))return JStep.Continue;rt.PutStatic("forge/util/ComparableOp","LESS_THAN","Lforge/util/ComparableOp;",f.Pop());f.Pc=60;continue;}
case 60:{if(!rt.EnsureInitialized(f,"forge/util/ComparableOp"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/ComparableOp")));f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("GT_OR_EQUAL")));f.Pc=66;continue;}
case 66:{f.Push(JValue.I(4));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String(">=")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/util/ComparableOp","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",72);}
case 72:{if(!rt.StaticReady(f,"forge/util/ComparableOp","GT_OR_EQUAL","Lforge/util/ComparableOp;"))return JStep.Continue;rt.PutStatic("forge/util/ComparableOp","GT_OR_EQUAL","Lforge/util/ComparableOp;",f.Pop());f.Pc=75;continue;}
case 75:{if(!rt.EnsureInitialized(f,"forge/util/ComparableOp"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/ComparableOp")));f.Pc=78;continue;}
case 78:{f.StackOp("dup");f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("LT_OR_EQUAL")));f.Pc=81;continue;}
case 81:{f.Push(JValue.I(5));f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("<=")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/util/ComparableOp","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",87);}
case 87:{if(!rt.StaticReady(f,"forge/util/ComparableOp","LT_OR_EQUAL","Lforge/util/ComparableOp;"))return JStep.Continue;rt.PutStatic("forge/util/ComparableOp","LT_OR_EQUAL","Lforge/util/ComparableOp;",f.Pop());f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/util/ComparableOp","$values","()[Lforge/util/ComparableOp;","invokestatic",93);}
case 93:{if(!rt.StaticReady(f,"forge/util/ComparableOp","$VALUES","[Lforge/util/ComparableOp;"))return JStep.Continue;rt.PutStatic("forge/util/ComparableOp","$VALUES","[Lforge/util/ComparableOp;",f.Pop());f.Pc=96;continue;}
case 96:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
