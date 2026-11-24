// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C77{
internal static JClass Build(){var c=new JClass("forge/card/mana/ManaAtom","java/lang/Object",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("WHITE","I",true,JValue.I(1),null));
c.Add(new JField("BLUE","I",true,JValue.I(2),null));
c.Add(new JField("BLACK","I",true,JValue.I(4),null));
c.Add(new JField("RED","I",true,JValue.I(8),null));
c.Add(new JField("GREEN","I",true,JValue.I(16),null));
c.Add(new JField("COLORLESS","I",true,JValue.I(32),null));
c.Add(new JField("MANACOLORS","[B",true,JValue.Default("[B"),null));
c.Add(new JField("MANATYPES","[B",true,JValue.Default("[B"),null));
c.Add(new JField("ALL_MANA_COLORS","B",true,JValue.I(31),null));
c.Add(new JField("ALL_MANA_TYPES","B",true,JValue.I(63),null));
c.Add(new JField("GENERIC","I",true,JValue.I(64),null));
c.Add(new JField("IS_X","I",true,JValue.I(256),null));
c.Add(new JField("OR_2_GENERIC","I",true,JValue.I(512),null));
c.Add(new JField("OR_2_LIFE","I",true,JValue.I(1024),null));
c.Add(new JField("IS_SNOW","I",true,JValue.I(2048),null));
c.Add(new JMethod(1194,"forge/card/mana/ManaAtom","<init>","()V",1,1,1,new JHandler[]{},M1194));
c.Add(new JMethod(1195,"forge/card/mana/ManaAtom","fromName","(C)B",9,1,1,new JHandler[]{},M1195));
c.Add(new JMethod(1196,"forge/card/mana/ManaAtom","fromName","(Ljava/lang/String;)B",9,3,3,new JHandler[]{},M1196));
c.Add(new JMethod(1197,"forge/card/mana/ManaAtom","fromConversion","(Ljava/lang/String;)B",9,6,2,new JHandler[]{},M1197));
c.Add(new JMethod(1198,"forge/card/mana/ManaAtom","getIndexOfFirstManaType","(B)I",9,2,3,new JHandler[]{},M1198));
c.Add(new JMethod(1199,"forge/card/mana/ManaAtom","getIndexFromName","(Ljava/lang/String;)I",9,1,1,new JHandler[]{},M1199));
c.Add(new JMethod(1200,"forge/card/mana/ManaAtom","<clinit>","()V",8,0,4,new JHandler[]{},M1200));
}

internal static JStep M1194(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1195(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Character","toLowerCase","(C)C","invokestatic",4);}
case 4:{switch(f.Pop().Int){case 98:f.Pc=68;break;case 99:f.Pc=76;break;case 103:f.Pc=73;break;case 114:f.Pc=70;break;case 117:f.Pc=66;break;case 119:f.Pc=64;break;default:f.Pc=79;break;}continue;}
case 64:{f.Push(JValue.I(1));f.Pc=65;continue;}
case 65:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 66:{f.Push(JValue.I(2));f.Pc=67;continue;}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 68:{f.Push(JValue.I(4));f.Pc=69;continue;}
case 69:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 70:{f.Push(JValue.I(8));f.Pc=72;continue;}
case 72:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 73:{f.Push(JValue.I(16));f.Pc=75;continue;}
case 75:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 76:{f.Push(JValue.I(32));f.Pc=78;continue;}
case 78:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 79:{f.Push(JValue.I(0));f.Pc=80;continue;}
case 80:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1196(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",10);}
case 10:{f.Push(JValue.I(2));f.Pc=11;continue;}
case 11:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?33:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",19);}
case 19:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(C)B","invokestatic",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(C)B","invokestatic",30);}
case 30:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=31;continue;}
case 31:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=32;continue;}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",37);}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?50:41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(C)B","invokestatic",49);}
case 49:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Locals[0]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Locals[1]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(JValue.I(-1));f.Pc=58;continue;}
case 58:{f.Locals[2]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",63);}
case 63:{switch(f.Pop().Int){case 112785:f.Pc=162;break;case 3027034:f.Pc=134;break;case 93818879:f.Pc=148;break;case 98619139:f.Pc=176;break;case 113101865:f.Pc=120;break;case 1981638524:f.Pc=190;break;default:f.Pc=201;break;}continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("white")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int==0?201:129;continue;}
case 129:{f.Push(JValue.I(0));f.Pc=130;continue;}
case 130:{f.Locals[2]=f.Pop();f.Pc=131;continue;}
case 131:{f.Pc=201;continue;}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.String("blue")));f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",140);}
case 140:{f.Pc=f.Pop().Int==0?201:143;continue;}
case 143:{f.Push(JValue.I(1));f.Pc=144;continue;}
case 144:{f.Locals[2]=f.Pop();f.Pc=145;continue;}
case 145:{f.Pc=201;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String("black")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",154);}
case 154:{f.Pc=f.Pop().Int==0?201:157;continue;}
case 157:{f.Push(JValue.I(2));f.Pc=158;continue;}
case 158:{f.Locals[2]=f.Pop();f.Pc=159;continue;}
case 159:{f.Pc=201;continue;}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.String("red")));f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",168);}
case 168:{f.Pc=f.Pop().Int==0?201:171;continue;}
case 171:{f.Push(JValue.I(3));f.Pc=172;continue;}
case 172:{f.Locals[2]=f.Pop();f.Pc=173;continue;}
case 173:{f.Pc=201;continue;}
case 176:{f.Push(f.Locals[1]);f.Pc=177;continue;}
case 177:{f.Push(JValue.R(rt.String("green")));f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",182);}
case 182:{f.Pc=f.Pop().Int==0?201:185;continue;}
case 185:{f.Push(JValue.I(4));f.Pc=186;continue;}
case 186:{f.Locals[2]=f.Pop();f.Pc=187;continue;}
case 187:{f.Pc=201;continue;}
case 190:{f.Push(f.Locals[1]);f.Pc=191;continue;}
case 191:{f.Push(JValue.R(rt.String("colorless")));f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",196);}
case 196:{f.Pc=f.Pop().Int==0?201:199;continue;}
case 199:{f.Push(JValue.I(5));f.Pc=200;continue;}
case 200:{f.Locals[2]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[2]);f.Pc=202;continue;}
case 202:{switch(f.Pop().Int){case 0:f.Pc=240;break;case 1:f.Pc=242;break;case 2:f.Pc=244;break;case 3:f.Pc=246;break;case 4:f.Pc=249;break;case 5:f.Pc=252;break;default:f.Pc=255;break;}continue;}
case 240:{f.Push(JValue.I(1));f.Pc=241;continue;}
case 241:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 242:{f.Push(JValue.I(2));f.Pc=243;continue;}
case 243:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 244:{f.Push(JValue.I(4));f.Pc=245;continue;}
case 245:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 246:{f.Push(JValue.I(8));f.Pc=248;continue;}
case 248:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 249:{f.Push(JValue.I(16));f.Pc=251;continue;}
case 251:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 252:{f.Push(JValue.I(32));f.Pc=254;continue;}
case 254:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 255:{f.Push(JValue.I(0));f.Pc=256;continue;}
case 256:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1197(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.I(-1));f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",8);}
case 8:{switch(f.Pop().Int){case -310870793:f.Pc=36;break;case 821772070:f.Pc=50;break;default:f.Pc=61;break;}continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("AnyColor")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?61:45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{f.Locals[2]=f.Pop();f.Pc=47;continue;}
case 47:{f.Pc=61;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("AnyType")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?61:59;continue;}
case 59:{f.Push(JValue.I(1));f.Pc=60;continue;}
case 60:{f.Locals[2]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{switch(f.Pop().Int){case 0:f.Pc=88;break;case 1:f.Pc=91;break;default:f.Pc=94;break;}continue;}
case 88:{f.Push(JValue.I(31));f.Pc=90;continue;}
case 90:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 91:{f.Push(JValue.I(63));f.Pc=93;continue;}
case 93:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("non")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int==0?116:103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(JValue.I(3));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",108);}
case 108:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(Ljava/lang/String;)B","invokestatic",111);}
case 111:{f.Push(JValue.I(63));f.Pc=113;continue;}
case 113:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ixor",a,b));f.Pc=114;continue;}
case 114:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=115;continue;}
case 115:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 116:{f.Push(JValue.I(0));f.Pc=117;continue;}
case 117:{f.Locals[1]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",122);}
case 122:{f.Push(JValue.I(2));f.Pc=123;continue;}
case 123:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?131:126;continue;}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(Ljava/lang/String;)B","invokestatic",130);}
case 130:{f.Locals[1]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{f.Pc=f.Pop().Int!=0?173:135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/String","toCharArray","()[C","invokevirtual",139);}
case 139:{f.Locals[2]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[2]);f.Pc=141;continue;}
case 141:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=142;continue;}
case 142:{f.Locals[3]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(JValue.I(0));f.Pc=144;continue;}
case 144:{f.Locals[4]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[3]);f.Pc=149;continue;}
case 149:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?173:152;continue;}
case 152:{f.Push(f.Locals[2]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[4]);f.Pc=155;continue;}
case 155:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=156;continue;}
case 156:{f.Locals[5]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[1]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[5]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(C)B","invokestatic",164);}
case 164:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=165;continue;}
case 165:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=166;continue;}
case 166:{f.Locals[1]=f.Pop();f.Pc=167;continue;}
case 167:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=170;continue;}
case 170:{f.Pc=146;continue;}
case 173:{f.Push(f.Locals[1]);f.Pc=174;continue;}
case 174:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1198(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{if(!rt.StaticReady(f,"forge/card/mana/ManaAtom","MANATYPES","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaAtom","MANATYPES","[B"));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=7;continue;}
case 7:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?28:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/card/mana/ManaAtom","MANATYPES","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaAtom","MANATYPES","[B"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=16;continue;}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Int==0?22:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=25;continue;}
case 25:{f.Pc=2;continue;}
case 28:{f.Push(JValue.I(-1));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1199(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(Ljava/lang/String;)B","invokestatic",4);}
case 4:{return rt.Call(f,"forge/card/mana/ManaAtom","getIndexOfFirstManaType","(B)I","invokestatic",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1200(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(5));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("B",f.Pop().Int)));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(2));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(2));f.Pc=13;continue;}
case 13:{f.Push(JValue.I(4));f.Pc=14;continue;}
case 14:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(JValue.I(3));f.Pc=17;continue;}
case 17:{f.Push(JValue.I(8));f.Pc=19;continue;}
case 19:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(JValue.I(4));f.Pc=22;continue;}
case 22:{f.Push(JValue.I(16));f.Pc=24;continue;}
case 24:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/mana/ManaAtom","MANACOLORS","[B"))return JStep.Continue;rt.PutStatic("forge/card/mana/ManaAtom","MANACOLORS","[B",f.Pop());f.Pc=28;continue;}
case 28:{f.Push(JValue.I(6));f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.NewArray("B",f.Pop().Int)));f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{f.Push(JValue.I(2));f.Pc=39;continue;}
case 39:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=40;continue;}
case 40:{f.StackOp("dup");f.Pc=41;continue;}
case 41:{f.Push(JValue.I(2));f.Pc=42;continue;}
case 42:{f.Push(JValue.I(4));f.Pc=43;continue;}
case 43:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{f.Push(JValue.I(8));f.Pc=48;continue;}
case 48:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{f.Push(JValue.I(4));f.Pc=51;continue;}
case 51:{f.Push(JValue.I(16));f.Pc=53;continue;}
case 53:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=54;continue;}
case 54:{f.StackOp("dup");f.Pc=55;continue;}
case 55:{f.Push(JValue.I(5));f.Pc=56;continue;}
case 56:{f.Push(JValue.I(32));f.Pc=58;continue;}
case 58:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=59;continue;}
case 59:{if(!rt.StaticReady(f,"forge/card/mana/ManaAtom","MANATYPES","[B"))return JStep.Continue;rt.PutStatic("forge/card/mana/ManaAtom","MANATYPES","[B",f.Pop());f.Pc=62;continue;}
case 62:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
