// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C68{
internal static JClass Build(){var c=new JClass("forge/card/MagicColor","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("WHITE","B",true,JValue.I(1),null));
c.Add(new JField("BLUE","B",true,JValue.I(2),null));
c.Add(new JField("BLACK","B",true,JValue.I(4),null));
c.Add(new JField("RED","B",true,JValue.I(8),null));
c.Add(new JField("GREEN","B",true,JValue.I(16),null));
c.Add(new JField("COLORLESS","B",true,JValue.I(0),null));
c.Add(new JField("ALL_COLORS","B",true,JValue.I(31),null));
c.Add(new JField("NUMBER_OR_COLORS","I",true,JValue.I(5),null));
c.Add(new JField("WUBRG","[B",true,JValue.Default("[B"),null));
c.Add(new JField("WUBRGC","[B",true,JValue.Default("[B"),null));
c.Add(new JField("COLORPAIR","[B",true,JValue.Default("[B"),null));
c.Add(new JMethod(1131,"forge/card/MagicColor","<init>","()V",2,1,1,new JHandler[]{},M1131));
c.Add(new JMethod(1132,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B",9,3,3,new JHandler[]{},M1132));
c.Add(new JMethod(1133,"forge/card/MagicColor","fromName","(C)B",9,1,1,new JHandler[]{},M1133));
c.Add(new JMethod(1134,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;",9,1,2,new JHandler[]{},M1134));
c.Add(new JMethod(1135,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;",9,1,1,new JHandler[]{},M1135));
c.Add(new JMethod(1136,"forge/card/MagicColor","toLongString","(B)Ljava/lang/String;",9,1,1,new JHandler[]{},M1136));
c.Add(new JMethod(1137,"forge/card/MagicColor","toSymbol","(B)Ljava/lang/String;",9,1,1,new JHandler[]{},M1137));
c.Add(new JMethod(1138,"forge/card/MagicColor","toSymbol","(Ljava/lang/String;)Ljava/lang/String;",9,1,1,new JHandler[]{},M1138));
c.Add(new JMethod(1139,"forge/card/MagicColor","<clinit>","()V",8,0,4,new JHandler[]{},M1139));
}

internal static JStep M1131(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1132(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("all")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?18:15;continue;}
case 15:{f.Push(JValue.I(31));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",22);}
case 22:{f.Push(JValue.I(2));f.Pc=23;continue;}
case 23:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?45:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/card/MagicColor","fromName","(C)B","invokestatic",34);}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(JValue.I(1));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/card/MagicColor","fromName","(C)B","invokestatic",42);}
case 42:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=43;continue;}
case 43:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=44;continue;}
case 44:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",49);}
case 49:{f.Locals[0]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",54);}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?261:58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Locals[1]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(JValue.I(-1));f.Pc=61;continue;}
case 61:{f.Locals[2]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",66);}
case 66:{switch(f.Pop().Int){case 98:f.Pc=152;break;case 99:f.Pc=194;break;case 103:f.Pc=180;break;case 114:f.Pc=166;break;case 117:f.Pc=138;break;case 119:f.Pc=124;break;default:f.Pc=205;break;}continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("w")));f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",130);}
case 130:{f.Pc=f.Pop().Int==0?205:133;continue;}
case 133:{f.Push(JValue.I(0));f.Pc=134;continue;}
case 134:{f.Locals[2]=f.Pop();f.Pc=135;continue;}
case 135:{f.Pc=205;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("u")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Int==0?205:147;continue;}
case 147:{f.Push(JValue.I(1));f.Pc=148;continue;}
case 148:{f.Locals[2]=f.Pop();f.Pc=149;continue;}
case 149:{f.Pc=205;continue;}
case 152:{f.Push(f.Locals[1]);f.Pc=153;continue;}
case 153:{f.Push(JValue.R(rt.String("b")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",158);}
case 158:{f.Pc=f.Pop().Int==0?205:161;continue;}
case 161:{f.Push(JValue.I(2));f.Pc=162;continue;}
case 162:{f.Locals[2]=f.Pop();f.Pc=163;continue;}
case 163:{f.Pc=205;continue;}
case 166:{f.Push(f.Locals[1]);f.Pc=167;continue;}
case 167:{f.Push(JValue.R(rt.String("r")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",172);}
case 172:{f.Pc=f.Pop().Int==0?205:175;continue;}
case 175:{f.Push(JValue.I(3));f.Pc=176;continue;}
case 176:{f.Locals[2]=f.Pop();f.Pc=177;continue;}
case 177:{f.Pc=205;continue;}
case 180:{f.Push(f.Locals[1]);f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.String("g")));f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",186);}
case 186:{f.Pc=f.Pop().Int==0?205:189;continue;}
case 189:{f.Push(JValue.I(4));f.Pc=190;continue;}
case 190:{f.Locals[2]=f.Pop();f.Pc=191;continue;}
case 191:{f.Pc=205;continue;}
case 194:{f.Push(f.Locals[1]);f.Pc=195;continue;}
case 195:{f.Push(JValue.R(rt.String("c")));f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",200);}
case 200:{f.Pc=f.Pop().Int==0?205:203;continue;}
case 203:{f.Push(JValue.I(5));f.Pc=204;continue;}
case 204:{f.Locals[2]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[2]);f.Pc=206;continue;}
case 206:{switch(f.Pop().Int){case 0:f.Pc=244;break;case 1:f.Pc=246;break;case 2:f.Pc=248;break;case 3:f.Pc=250;break;case 4:f.Pc=253;break;case 5:f.Pc=256;break;default:f.Pc=258;break;}continue;}
case 244:{f.Push(JValue.I(1));f.Pc=245;continue;}
case 245:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 246:{f.Push(JValue.I(2));f.Pc=247;continue;}
case 247:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 248:{f.Push(JValue.I(4));f.Pc=249;continue;}
case 249:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 250:{f.Push(JValue.I(8));f.Pc=252;continue;}
case 252:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 253:{f.Push(JValue.I(16));f.Pc=255;continue;}
case 255:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 256:{f.Push(JValue.I(0));f.Pc=257;continue;}
case 257:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 258:{f.Pc=462;continue;}
case 261:{f.Push(f.Locals[0]);f.Pc=262;continue;}
case 262:{f.Locals[1]=f.Pop();f.Pc=263;continue;}
case 263:{f.Push(JValue.I(-1));f.Pc=264;continue;}
case 264:{f.Locals[2]=f.Pop();f.Pc=265;continue;}
case 265:{f.Push(f.Locals[1]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",269);}
case 269:{switch(f.Pop().Int){case 112785:f.Pc=370;break;case 3027034:f.Pc=342;break;case 93818879:f.Pc=356;break;case 98619139:f.Pc=384;break;case 113101865:f.Pc=328;break;case 1981638524:f.Pc=398;break;default:f.Pc=409;break;}continue;}
case 328:{f.Push(f.Locals[1]);f.Pc=329;continue;}
case 329:{f.Push(JValue.R(rt.String("white")));f.Pc=331;continue;}
case 331:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",334);}
case 334:{f.Pc=f.Pop().Int==0?409:337;continue;}
case 337:{f.Push(JValue.I(0));f.Pc=338;continue;}
case 338:{f.Locals[2]=f.Pop();f.Pc=339;continue;}
case 339:{f.Pc=409;continue;}
case 342:{f.Push(f.Locals[1]);f.Pc=343;continue;}
case 343:{f.Push(JValue.R(rt.String("blue")));f.Pc=345;continue;}
case 345:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",348);}
case 348:{f.Pc=f.Pop().Int==0?409:351;continue;}
case 351:{f.Push(JValue.I(1));f.Pc=352;continue;}
case 352:{f.Locals[2]=f.Pop();f.Pc=353;continue;}
case 353:{f.Pc=409;continue;}
case 356:{f.Push(f.Locals[1]);f.Pc=357;continue;}
case 357:{f.Push(JValue.R(rt.String("black")));f.Pc=359;continue;}
case 359:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",362);}
case 362:{f.Pc=f.Pop().Int==0?409:365;continue;}
case 365:{f.Push(JValue.I(2));f.Pc=366;continue;}
case 366:{f.Locals[2]=f.Pop();f.Pc=367;continue;}
case 367:{f.Pc=409;continue;}
case 370:{f.Push(f.Locals[1]);f.Pc=371;continue;}
case 371:{f.Push(JValue.R(rt.String("red")));f.Pc=373;continue;}
case 373:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",376);}
case 376:{f.Pc=f.Pop().Int==0?409:379;continue;}
case 379:{f.Push(JValue.I(3));f.Pc=380;continue;}
case 380:{f.Locals[2]=f.Pop();f.Pc=381;continue;}
case 381:{f.Pc=409;continue;}
case 384:{f.Push(f.Locals[1]);f.Pc=385;continue;}
case 385:{f.Push(JValue.R(rt.String("green")));f.Pc=387;continue;}
case 387:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",390);}
case 390:{f.Pc=f.Pop().Int==0?409:393;continue;}
case 393:{f.Push(JValue.I(4));f.Pc=394;continue;}
case 394:{f.Locals[2]=f.Pop();f.Pc=395;continue;}
case 395:{f.Pc=409;continue;}
case 398:{f.Push(f.Locals[1]);f.Pc=399;continue;}
case 399:{f.Push(JValue.R(rt.String("colorless")));f.Pc=401;continue;}
case 401:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",404);}
case 404:{f.Pc=f.Pop().Int==0?409:407;continue;}
case 407:{f.Push(JValue.I(5));f.Pc=408;continue;}
case 408:{f.Locals[2]=f.Pop();f.Pc=409;continue;}
case 409:{f.Push(f.Locals[2]);f.Pc=410;continue;}
case 410:{switch(f.Pop().Int){case 0:f.Pc=448;break;case 1:f.Pc=450;break;case 2:f.Pc=452;break;case 3:f.Pc=454;break;case 4:f.Pc=457;break;case 5:f.Pc=460;break;default:f.Pc=462;break;}continue;}
case 448:{f.Push(JValue.I(1));f.Pc=449;continue;}
case 449:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 450:{f.Push(JValue.I(2));f.Pc=451;continue;}
case 451:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 452:{f.Push(JValue.I(4));f.Pc=453;continue;}
case 453:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 454:{f.Push(JValue.I(8));f.Pc=456;continue;}
case 456:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 457:{f.Push(JValue.I(16));f.Pc=459;continue;}
case 459:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 460:{f.Push(JValue.I(0));f.Pc=461;continue;}
case 461:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 462:{f.Push(JValue.I(0));f.Pc=463;continue;}
case 463:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1133(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Character","toLowerCase","(C)C","invokestatic",4);}
case 4:{switch(f.Pop().Int){case 98:f.Pc=64;break;case 103:f.Pc=73;break;case 114:f.Pc=68;break;case 117:f.Pc=60;break;case 119:f.Pc=56;break;default:f.Pc=78;break;}continue;}
case 56:{f.Push(JValue.I(1));f.Pc=57;continue;}
case 57:{f.Pc=79;continue;}
case 60:{f.Push(JValue.I(2));f.Pc=61;continue;}
case 61:{f.Pc=79;continue;}
case 64:{f.Push(JValue.I(4));f.Pc=65;continue;}
case 65:{f.Pc=79;continue;}
case 68:{f.Push(JValue.I(8));f.Pc=70;continue;}
case 70:{f.Pc=79;continue;}
case 73:{f.Push(JValue.I(16));f.Pc=75;continue;}
case 75:{f.Pc=79;continue;}
case 78:{f.Push(JValue.I(0));f.Pc=79;continue;}
case 79:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1134(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("snow")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?12:9;continue;}
case 9:{f.Push(JValue.R(rt.String("S")));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",16);}
case 16:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1135(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/MagicColor$Color","fromByte","(B)Lforge/card/MagicColor$Color;","invokestatic",4);}
case 4:{return rt.Call(f,"forge/card/MagicColor$Color","getShortName","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1136(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/MagicColor$Color","fromByte","(B)Lforge/card/MagicColor$Color;","invokestatic",4);}
case 4:{return rt.Call(f,"forge/card/MagicColor$Color","getName","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1137(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/MagicColor$Color","fromByte","(B)Lforge/card/MagicColor$Color;","invokestatic",4);}
case 4:{return rt.Call(f,"forge/card/MagicColor$Color","getSymbol","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1138(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",4);}
case 4:{return rt.Call(f,"forge/card/MagicColor","toSymbol","(B)Ljava/lang/String;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1139(JRuntime rt,JFrame f)
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
case 25:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;rt.PutStatic("forge/card/MagicColor","WUBRG","[B",f.Pop());f.Pc=28;continue;}
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
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRGC","[B"))return JStep.Continue;rt.PutStatic("forge/card/MagicColor","WUBRGC","[B",f.Pop());f.Pc=61;continue;}
case 61:{f.Push(JValue.I(10));f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.NewArray("B",f.Pop().Int)));f.Pc=65;continue;}
case 65:{f.StackOp("dup");f.Pc=66;continue;}
case 66:{f.Push(JValue.I(0));f.Pc=67;continue;}
case 67:{f.Push(JValue.I(3));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(1));f.Pc=71;continue;}
case 71:{f.Push(JValue.I(6));f.Pc=73;continue;}
case 73:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{f.Push(JValue.I(2));f.Pc=76;continue;}
case 76:{f.Push(JValue.I(12));f.Pc=78;continue;}
case 78:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=79;continue;}
case 79:{f.StackOp("dup");f.Pc=80;continue;}
case 80:{f.Push(JValue.I(3));f.Pc=81;continue;}
case 81:{f.Push(JValue.I(24));f.Pc=83;continue;}
case 83:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{f.Push(JValue.I(4));f.Pc=86;continue;}
case 86:{f.Push(JValue.I(17));f.Pc=88;continue;}
case 88:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=89;continue;}
case 89:{f.StackOp("dup");f.Pc=90;continue;}
case 90:{f.Push(JValue.I(5));f.Pc=91;continue;}
case 91:{f.Push(JValue.I(5));f.Pc=92;continue;}
case 92:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=93;continue;}
case 93:{f.StackOp("dup");f.Pc=94;continue;}
case 94:{f.Push(JValue.I(6));f.Pc=96;continue;}
case 96:{f.Push(JValue.I(10));f.Pc=98;continue;}
case 98:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=99;continue;}
case 99:{f.StackOp("dup");f.Pc=100;continue;}
case 100:{f.Push(JValue.I(7));f.Pc=102;continue;}
case 102:{f.Push(JValue.I(20));f.Pc=104;continue;}
case 104:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=105;continue;}
case 105:{f.StackOp("dup");f.Pc=106;continue;}
case 106:{f.Push(JValue.I(8));f.Pc=108;continue;}
case 108:{f.Push(JValue.I(9));f.Pc=110;continue;}
case 110:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{f.Push(JValue.I(9));f.Pc=114;continue;}
case 114:{f.Push(JValue.I(18));f.Pc=116;continue;}
case 116:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=117;continue;}
case 117:{if(!rt.StaticReady(f,"forge/card/MagicColor","COLORPAIR","[B"))return JStep.Continue;rt.PutStatic("forge/card/MagicColor","COLORPAIR","[B",f.Pop());f.Pc=120;continue;}
case 120:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
