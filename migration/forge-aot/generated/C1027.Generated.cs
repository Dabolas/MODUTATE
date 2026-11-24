// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1027{
internal static JClass Build(){var c=new JClass("forge/game/undo/GameMemento$ClassInfo","java/lang/Object",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("fields","[Ljava/lang/reflect/Field;",false,JValue.Default("[Ljava/lang/reflect/Field;"),null));
c.Add(new JField("pk","[I",false,JValue.Default("[I"),null));
c.Add(new JField("stored","[Z",false,JValue.Default("[Z"),null));
c.Add(new JField("nRefs","I",false,JValue.Default("I"),null));
c.Add(new JField("nPrims","I",false,JValue.Default("I"),null));
c.Add(new JMethod(10914,"forge/game/undo/GameMemento$ClassInfo","<init>","(Ljava/lang/Class;)V",0,8,4,new JHandler[]{},M10914));
}

internal static JStep M10914(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference==null?101:18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/Class","getName","()Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Push(JValue.R(rt.String("forge.")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?101:30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/Class","getDeclaredFields","()[Ljava/lang/reflect/Field;","invokevirtual",34);}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=39;continue;}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{f.Locals[6]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[6]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?93:51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=56;continue;}
case 56:{f.Locals[7]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[7]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/reflect/Field","getModifiers","()I","invokevirtual",63);}
case 63:{return rt.Call(f,"java/lang/reflect/Modifier","isStatic","(I)Z","invokestatic",66);}
case 66:{f.Pc=f.Pop().Int==0?72:69;continue;}
case 69:{f.Pc=87;continue;}
case 72:{f.Push(f.Locals[7]);f.Pc=74;continue;}
case 74:{f.Push(JValue.I(1));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/reflect/Field","setAccessible","(Z)V","invokevirtual",78);}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[7]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",86);}
case 86:{f.StackOp("pop");f.Pc=87;continue;}
case 87:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=90;continue;}
case 90:{f.Pc=44;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/Class","getSuperclass","()Ljava/lang/Class;","invokevirtual",97);}
case 97:{f.Locals[3]=f.Pop();f.Pc=98;continue;}
case 98:{f.Pc=14;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{f.Push(JValue.I(0));f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.NewArray("Ljava/lang/reflect/Field;",f.Pop().Int)));f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/List","toArray","([Ljava/lang/Object;)[Ljava/lang/Object;","invokeinterface",112);}
case 112:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/lang/reflect/Field;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=115;continue;}
case 115:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","fields","[Ljava/lang/reflect/Field;",value);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","fields","[Ljava/lang/reflect/Field;"));f.Pc=123;continue;}
case 123:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=126;continue;}
case 126:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","pk","[I",value);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","fields","[Ljava/lang/reflect/Field;"));f.Pc=134;continue;}
case 134:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.NewArray("Z",f.Pop().Int)));f.Pc=137;continue;}
case 137:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","stored","[Z",value);f.Pc=140;continue;}
case 140:{f.Push(JValue.I(0));f.Pc=141;continue;}
case 141:{f.Locals[3]=f.Pop();f.Pc=142;continue;}
case 142:{f.Push(JValue.I(0));f.Pc=143;continue;}
case 143:{f.Locals[4]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(JValue.I(0));f.Pc=146;continue;}
case 146:{f.Locals[5]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[5]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","fields","[Ljava/lang/reflect/Field;"));f.Pc=154;continue;}
case 154:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=155;continue;}
case 155:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?241:158;continue;}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","pk","[I"));f.Pc=162;continue;}
case 162:{f.Push(f.Locals[5]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","fields","[Ljava/lang/reflect/Field;"));f.Pc=168;continue;}
case 168:{f.Push(f.Locals[5]);f.Pc=170;continue;}
case 170:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/lang/reflect/Field","getType","()Ljava/lang/Class;","invokevirtual",174);}
case 174:{return rt.Call(f,"forge/game/undo/GameMemento","primKind","(Ljava/lang/Class;)I","invokestatic",177);}
case 177:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[0]);f.Pc=179;continue;}
case 179:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","stored","[Z"));f.Pc=182;continue;}
case 182:{f.Push(f.Locals[5]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","fields","[Ljava/lang/reflect/Field;"));f.Pc=188;continue;}
case 188:{f.Push(f.Locals[5]);f.Pc=190;continue;}
case 190:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/lang/reflect/Field","getModifiers","()I","invokevirtual",194);}
case 194:{return rt.Call(f,"java/lang/reflect/Modifier","isFinal","(I)Z","invokestatic",197);}
case 197:{f.Pc=f.Pop().Int!=0?204:200;continue;}
case 200:{f.Push(JValue.I(1));f.Pc=201;continue;}
case 201:{f.Pc=205;continue;}
case 204:{f.Push(JValue.I(0));f.Pc=205;continue;}
case 205:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[0]);f.Pc=207;continue;}
case 207:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","stored","[Z"));f.Pc=210;continue;}
case 210:{f.Push(f.Locals[5]);f.Pc=212;continue;}
case 212:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=213;continue;}
case 213:{f.Pc=f.Pop().Int==0?235:216;continue;}
case 216:{f.Push(f.Locals[0]);f.Pc=217;continue;}
case 217:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","pk","[I"));f.Pc=220;continue;}
case 220:{f.Push(f.Locals[5]);f.Pc=222;continue;}
case 222:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=223;continue;}
case 223:{f.Pc=f.Pop().Int!=0?232:226;continue;}
case 226:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=229;continue;}
case 229:{f.Pc=235;continue;}
case 232:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=235;continue;}
case 235:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=238;continue;}
case 238:{f.Pc=148;continue;}
case 241:{f.Push(f.Locals[0]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[3]);f.Pc=243;continue;}
case 243:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","nRefs","I",value);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[0]);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[4]);f.Pc=249;continue;}
case 249:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","nPrims","I",value);f.Pc=252;continue;}
case 252:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
