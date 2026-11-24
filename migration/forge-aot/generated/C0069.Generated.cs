// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C69{
internal static JClass Build(){var c=new JClass("forge/card/MagicColor$Color","java/lang/Enum",new string[]{"forge/util/ITranslatable"},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("WHITE","Lforge/card/MagicColor$Color;",true,JValue.Default("Lforge/card/MagicColor$Color;"),null));
c.Add(new JField("BLUE","Lforge/card/MagicColor$Color;",true,JValue.Default("Lforge/card/MagicColor$Color;"),null));
c.Add(new JField("BLACK","Lforge/card/MagicColor$Color;",true,JValue.Default("Lforge/card/MagicColor$Color;"),null));
c.Add(new JField("RED","Lforge/card/MagicColor$Color;",true,JValue.Default("Lforge/card/MagicColor$Color;"),null));
c.Add(new JField("GREEN","Lforge/card/MagicColor$Color;",true,JValue.Default("Lforge/card/MagicColor$Color;"),null));
c.Add(new JField("COLORLESS","Lforge/card/MagicColor$Color;",true,JValue.Default("Lforge/card/MagicColor$Color;"),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("shortName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("symbol","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("basicLandType","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("label","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("colormask","B",false,JValue.Default("B"),null));
c.Add(new JField("$VALUES","[Lforge/card/MagicColor$Color;",true,JValue.Default("[Lforge/card/MagicColor$Color;"),null));
c.Add(new JMethod(1140,"forge/card/MagicColor$Color","values","()[Lforge/card/MagicColor$Color;",9,0,1,new JHandler[]{},M1140));
c.Add(new JMethod(1141,"forge/card/MagicColor$Color","valueOf","(Ljava/lang/String;)Lforge/card/MagicColor$Color;",9,1,2,new JHandler[]{},M1141));
c.Add(new JMethod(1142,"forge/card/MagicColor$Color","<init>","(Ljava/lang/String;ILjava/lang/String;BLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",2,8,3,new JHandler[]{},M1142));
c.Add(new JMethod(1143,"forge/card/MagicColor$Color","fromByte","(B)Lforge/card/MagicColor$Color;",9,1,1,new JHandler[]{},M1143));
c.Add(new JMethod(1144,"forge/card/MagicColor$Color","fromName","(Ljava/lang/String;)Lforge/card/MagicColor$Color;",9,3,2,new JHandler[]{},M1144));
c.Add(new JMethod(1145,"forge/card/MagicColor$Color","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1145));
c.Add(new JMethod(1146,"forge/card/MagicColor$Color","getShortName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1146));
c.Add(new JMethod(1147,"forge/card/MagicColor$Color","getBasicLandType","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1147));
c.Add(new JMethod(1148,"forge/card/MagicColor$Color","getTranslatedName","()Ljava/lang/String;",1,1,3,new JHandler[]{},M1148));
c.Add(new JMethod(1149,"forge/card/MagicColor$Color","getColorMask","()B",1,1,1,new JHandler[]{},M1149));
c.Add(new JMethod(1150,"forge/card/MagicColor$Color","getSymbol","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1150));
c.Add(new JMethod(1151,"forge/card/MagicColor$Color","$values","()[Lforge/card/MagicColor$Color;",4106,0,4,new JHandler[]{},M1151));
c.Add(new JMethod(1152,"forge/card/MagicColor$Color","<clinit>","()V",8,0,9,new JHandler[]{},M1152));
}

internal static JStep M1140(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","$VALUES","[Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","$VALUES","[Lforge/card/MagicColor$Color;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/MagicColor$Color;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/MagicColor$Color;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1141(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/MagicColor$Color")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/MagicColor$Color"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1142(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/MagicColor$Color","name","Ljava/lang/String;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/MagicColor$Color","colormask","B",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/MagicColor$Color","shortName","Ljava/lang/String;",value);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{return rt.DynamicCall(f,"forge/card/MagicColor$Color:1142:26:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",31);}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/MagicColor$Color","symbol","Ljava/lang/String;",value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/MagicColor$Color","basicLandType","Ljava/lang/String;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[7]);f.Pc=43;continue;}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/MagicColor$Color","label","Ljava/lang/String;",value);f.Pc=46;continue;}
case 46:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1143(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{switch(f.Pop().Int){case 1:f.Pc=52;break;case 2:f.Pc=58;break;case 4:f.Pc=64;break;case 8:f.Pc=70;break;case 16:f.Pc=76;break;default:f.Pc=82;break;}continue;}
case 52:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=55;continue;}
case 55:{f.Pc=85;continue;}
case 58:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=61;continue;}
case 61:{f.Pc=85;continue;}
case 64:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=67;continue;}
case 67:{f.Pc=85;continue;}
case 70:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=73;continue;}
case 73:{f.Pc=85;continue;}
case 76:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=79;continue;}
case 79:{f.Pc=85;continue;}
case 82:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","COLORLESS","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","COLORLESS","Lforge/card/MagicColor$Color;"));f.Pc=85;continue;}
case 85:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1144(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"java/util/Locale","ROOT","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ROOT","Ljava/util/Locale;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/String","toLowerCase","(Ljava/util/Locale;)Ljava/lang/String;","invokevirtual",13);}
case 13:{f.Locals[1]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(JValue.I(-1));f.Pc=15;continue;}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",20);}
case 20:{switch(f.Pop().Int){case 112785:f.Pc=122;break;case 3027034:f.Pc=94;break;case 93818879:f.Pc=108;break;case 98619139:f.Pc=136;break;case 113101865:f.Pc=80;break;case 1981638524:f.Pc=150;break;default:f.Pc=161;break;}continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.String("white")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int==0?161:89;continue;}
case 89:{f.Push(JValue.I(0));f.Pc=90;continue;}
case 90:{f.Locals[2]=f.Pop();f.Pc=91;continue;}
case 91:{f.Pc=161;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("blue")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int==0?161:103;continue;}
case 103:{f.Push(JValue.I(1));f.Pc=104;continue;}
case 104:{f.Locals[2]=f.Pop();f.Pc=105;continue;}
case 105:{f.Pc=161;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("black")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?161:117;continue;}
case 117:{f.Push(JValue.I(2));f.Pc=118;continue;}
case 118:{f.Locals[2]=f.Pop();f.Pc=119;continue;}
case 119:{f.Pc=161;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.String("red")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int==0?161:131;continue;}
case 131:{f.Push(JValue.I(3));f.Pc=132;continue;}
case 132:{f.Locals[2]=f.Pop();f.Pc=133;continue;}
case 133:{f.Pc=161;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String("green")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",142);}
case 142:{f.Pc=f.Pop().Int==0?161:145;continue;}
case 145:{f.Push(JValue.I(4));f.Pc=146;continue;}
case 146:{f.Locals[2]=f.Pop();f.Pc=147;continue;}
case 147:{f.Pc=161;continue;}
case 150:{f.Push(f.Locals[1]);f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("colorless")));f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",156);}
case 156:{f.Pc=f.Pop().Int==0?161:159;continue;}
case 159:{f.Push(JValue.I(5));f.Pc=160;continue;}
case 160:{f.Locals[2]=f.Pop();f.Pc=161;continue;}
case 161:{f.Push(f.Locals[2]);f.Pc=162;continue;}
case 162:{switch(f.Pop().Int){case 0:f.Pc=200;break;case 1:f.Pc=206;break;case 2:f.Pc=212;break;case 3:f.Pc=218;break;case 4:f.Pc=224;break;case 5:f.Pc=230;break;default:f.Pc=236;break;}continue;}
case 200:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=203;continue;}
case 203:{f.Pc=237;continue;}
case 206:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=209;continue;}
case 209:{f.Pc=237;continue;}
case 212:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=215;continue;}
case 215:{f.Pc=237;continue;}
case 218:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=221;continue;}
case 221:{f.Pc=237;continue;}
case 224:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=227;continue;}
case 227:{f.Pc=237;continue;}
case 230:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","COLORLESS","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","COLORLESS","Lforge/card/MagicColor$Color;"));f.Pc=233;continue;}
case 233:{f.Pc=237;continue;}
case 236:{f.Push(JValue.R(null));f.Pc=237;continue;}
case 237:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1145(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/MagicColor$Color","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1146(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/MagicColor$Color","shortName","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1147(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/MagicColor$Color","basicLandType","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1148(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/card/MagicColor$Color","label","Ljava/lang/String;"));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1149(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/MagicColor$Color","colormask","B"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1150(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/MagicColor$Color","symbol","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1151(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(6));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","COLORLESS","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","COLORLESS","Lforge/card/MagicColor$Color;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1152(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/MagicColor$Color"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/MagicColor$Color")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("WHITE")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("white")));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("W")));f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("Plains")));f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("lblWhite")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/MagicColor$Color","<init>","(Ljava/lang/String;ILjava/lang/String;BLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",19);}
case 19:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;rt.PutStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;",f.Pop());f.Pc=22;continue;}
case 22:{if(!rt.EnsureInitialized(f,"forge/card/MagicColor$Color"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/MagicColor$Color")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("BLUE")));f.Pc=28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("blue")));f.Pc=31;continue;}
case 31:{f.Push(JValue.I(2));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("U")));f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("Island")));f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("lblBlue")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/card/MagicColor$Color","<init>","(Ljava/lang/String;ILjava/lang/String;BLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",41);}
case 41:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;rt.PutStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;",f.Pop());f.Pc=44;continue;}
case 44:{if(!rt.EnsureInitialized(f,"forge/card/MagicColor$Color"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/MagicColor$Color")));f.Pc=47;continue;}
case 47:{f.StackOp("dup");f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("BLACK")));f.Pc=50;continue;}
case 50:{f.Push(JValue.I(2));f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("black")));f.Pc=53;continue;}
case 53:{f.Push(JValue.I(4));f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("B")));f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("Swamp")));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("lblBlack")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/card/MagicColor$Color","<init>","(Ljava/lang/String;ILjava/lang/String;BLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",63);}
case 63:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;rt.PutStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;",f.Pop());f.Pc=66;continue;}
case 66:{if(!rt.EnsureInitialized(f,"forge/card/MagicColor$Color"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/MagicColor$Color")));f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("RED")));f.Pc=72;continue;}
case 72:{f.Push(JValue.I(3));f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("red")));f.Pc=75;continue;}
case 75:{f.Push(JValue.I(8));f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("R")));f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("Mountain")));f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.String("lblRed")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/card/MagicColor$Color","<init>","(Ljava/lang/String;ILjava/lang/String;BLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",86);}
case 86:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;rt.PutStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;",f.Pop());f.Pc=89;continue;}
case 89:{if(!rt.EnsureInitialized(f,"forge/card/MagicColor$Color"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/MagicColor$Color")));f.Pc=92;continue;}
case 92:{f.StackOp("dup");f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("GREEN")));f.Pc=95;continue;}
case 95:{f.Push(JValue.I(4));f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("green")));f.Pc=98;continue;}
case 98:{f.Push(JValue.I(16));f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.String("G")));f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("Forest")));f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("lblGreen")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/card/MagicColor$Color","<init>","(Ljava/lang/String;ILjava/lang/String;BLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",109);}
case 109:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;rt.PutStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;",f.Pop());f.Pc=112;continue;}
case 112:{if(!rt.EnsureInitialized(f,"forge/card/MagicColor$Color"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/MagicColor$Color")));f.Pc=115;continue;}
case 115:{f.StackOp("dup");f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("COLORLESS")));f.Pc=118;continue;}
case 118:{f.Push(JValue.I(5));f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("colorless")));f.Pc=121;continue;}
case 121:{f.Push(JValue.I(0));f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("C")));f.Pc=124;continue;}
case 124:{f.Push(JValue.R(null));f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("lblColorless")));f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/card/MagicColor$Color","<init>","(Ljava/lang/String;ILjava/lang/String;BLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",130);}
case 130:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","COLORLESS","Lforge/card/MagicColor$Color;"))return JStep.Continue;rt.PutStatic("forge/card/MagicColor$Color","COLORLESS","Lforge/card/MagicColor$Color;",f.Pop());f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/card/MagicColor$Color","$values","()[Lforge/card/MagicColor$Color;","invokestatic",136);}
case 136:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","$VALUES","[Lforge/card/MagicColor$Color;"))return JStep.Continue;rt.PutStatic("forge/card/MagicColor$Color","$VALUES","[Lforge/card/MagicColor$Color;",f.Pop());f.Pc=139;continue;}
case 139:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
