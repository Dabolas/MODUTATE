// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C56{
internal static JClass Build(){var c=new JClass("forge/card/ColorSet","java/lang/Enum",new string[]{"java/lang/Iterable","java/io/Serializable"},16433);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("C","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("W","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("U","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("WU","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("B","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("WB","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("UB","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("WUB","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("R","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("RW","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("UR","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("URW","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("BR","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("RWB","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("UBR","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("WUBR","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("G","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("GW","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("GU","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("GWU","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("BG","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("WBG","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("BGU","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("GWUB","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("RG","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("RGW","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("GUR","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("RGWU","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("BRG","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("BRGW","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("UBRG","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("WUBRG","Lforge/card/ColorSet;",true,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("serialVersionUID","J",true,JValue.L(794691267379929080L),null));
c.Add(new JField("orderedShards","Ljava/util/Collection;",false,JValue.Default("Ljava/util/Collection;"),null));
c.Add(new JField("orderWeight","F",false,JValue.Default("F"),null));
c.Add(new JField("symbolString","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("$VALUES","[Lforge/card/ColorSet;",true,JValue.Default("[Lforge/card/ColorSet;"),null));
c.Add(new JMethod(972,"forge/card/ColorSet","values","()[Lforge/card/ColorSet;",9,0,1,new JHandler[]{},M972));
c.Add(new JMethod(973,"forge/card/ColorSet","valueOf","(Ljava/lang/String;)Lforge/card/ColorSet;",9,1,2,new JHandler[]{},M973));
c.Add(new JMethod(974,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V",130,4,3,new JHandler[]{},M974));
c.Add(new JMethod(975,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;",9,2,2,new JHandler[]{},M975));
c.Add(new JMethod(976,"forge/card/ColorSet","fromEnums","([Lforge/card/MagicColor$Color;)Lforge/card/ColorSet;",137,6,2,new JHandler[]{},M976));
c.Add(new JMethod(977,"forge/card/ColorSet","fromEnums","(Ljava/lang/Iterable;)Lforge/card/ColorSet;",9,4,2,new JHandler[]{},M977));
c.Add(new JMethod(978,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;",137,6,2,new JHandler[]{},M978));
c.Add(new JMethod(979,"forge/card/ColorSet","fromNames","(Ljava/lang/Iterable;)Lforge/card/ColorSet;",9,4,2,new JHandler[]{},M979));
c.Add(new JMethod(980,"forge/card/ColorSet","fromNames","([C)Lforge/card/ColorSet;",9,6,2,new JHandler[]{},M980));
c.Add(new JMethod(981,"forge/card/ColorSet","fromManaCost","(Lforge/card/mana/ManaCost;)Lforge/card/ColorSet;",9,1,1,new JHandler[]{},M981));
c.Add(new JMethod(982,"forge/card/ColorSet","combine","([Lforge/card/ColorSet;)Lforge/card/ColorSet;",137,6,2,new JHandler[]{},M982));
c.Add(new JMethod(983,"forge/card/ColorSet","hasAnyColor","(I)Z",1,2,2,new JHandler[]{},M983));
c.Add(new JMethod(984,"forge/card/ColorSet","hasAnyColor","(Lforge/card/MagicColor$Color;)Z",1,2,2,new JHandler[]{},M984));
c.Add(new JMethod(985,"forge/card/ColorSet","hasAllColors","(I)Z",1,2,2,new JHandler[]{},M985));
c.Add(new JMethod(986,"forge/card/ColorSet","hasExactlyColor","(I)Z",1,2,2,new JHandler[]{},M986));
c.Add(new JMethod(987,"forge/card/ColorSet","hasNoColorsExcept","(Lforge/card/ColorSet;)Z",1,2,2,new JHandler[]{},M987));
c.Add(new JMethod(988,"forge/card/ColorSet","hasNoColorsExcept","(I)Z",1,2,3,new JHandler[]{},M988));
c.Add(new JMethod(989,"forge/card/ColorSet","getMissingColors","(B)Lforge/card/ColorSet;",1,2,3,new JHandler[]{},M989));
c.Add(new JMethod(990,"forge/card/ColorSet","containsAllColorsFrom","(I)Z",1,2,2,new JHandler[]{},M990));
c.Add(new JMethod(991,"forge/card/ColorSet","countColors","()I",1,1,1,new JHandler[]{},M991));
c.Add(new JMethod(992,"forge/card/ColorSet","calcOrderWeight","()F",2,2,2,new JHandler[]{},M992));
c.Add(new JMethod(993,"forge/card/ColorSet","getOrderWeight","()F",1,1,1,new JHandler[]{},M993));
c.Add(new JMethod(994,"forge/card/ColorSet","isColorless","()Z",1,1,2,new JHandler[]{},M994));
c.Add(new JMethod(995,"forge/card/ColorSet","isMulticolor","()Z",1,1,2,new JHandler[]{},M995));
c.Add(new JMethod(996,"forge/card/ColorSet","isAllColors","()Z",1,1,2,new JHandler[]{},M996));
c.Add(new JMethod(997,"forge/card/ColorSet","isMonoColor","()Z",1,1,2,new JHandler[]{},M997));
c.Add(new JMethod(998,"forge/card/ColorSet","isEqual","(B)Z",1,2,2,new JHandler[]{},M998));
}

private static void Add1(JClass c){
c.Add(new JMethod(999,"forge/card/ColorSet","hasWhite","()Z",1,1,2,new JHandler[]{},M999));
c.Add(new JMethod(1000,"forge/card/ColorSet","hasBlue","()Z",1,1,2,new JHandler[]{},M1000));
c.Add(new JMethod(1001,"forge/card/ColorSet","hasBlack","()Z",1,1,2,new JHandler[]{},M1001));
c.Add(new JMethod(1002,"forge/card/ColorSet","hasRed","()Z",1,1,2,new JHandler[]{},M1002));
c.Add(new JMethod(1003,"forge/card/ColorSet","hasGreen","()Z",1,1,2,new JHandler[]{},M1003));
c.Add(new JMethod(1004,"forge/card/ColorSet","inverse","()Lforge/card/ColorSet;",1,2,2,new JHandler[]{},M1004));
c.Add(new JMethod(1005,"forge/card/ColorSet","getColor","()B",1,1,1,new JHandler[]{},M1005));
c.Add(new JMethod(1006,"forge/card/ColorSet","sharesColorWith","(Lforge/card/ColorSet;)Z",1,2,2,new JHandler[]{},M1006));
c.Add(new JMethod(1007,"forge/card/ColorSet","getSharedColors","(Lforge/card/ColorSet;)Lforge/card/ColorSet;",1,2,2,new JHandler[]{},M1007));
c.Add(new JMethod(1008,"forge/card/ColorSet","getOffColors","(Lforge/card/ColorSet;)Lforge/card/ColorSet;",1,2,2,new JHandler[]{},M1008));
c.Add(new JMethod(1009,"forge/card/ColorSet","toEnumSet","()Ljava/util/Set;",1,1,1,new JHandler[]{},M1009));
c.Add(new JMethod(1010,"forge/card/ColorSet","iterator","()Ljava/util/Iterator;",1,1,1,new JHandler[]{},M1010));
c.Add(new JMethod(1011,"forge/card/ColorSet","stream","()Ljava/util/stream/Stream;",1,1,1,new JHandler[]{},M1011));
c.Add(new JMethod(1012,"forge/card/ColorSet","getOrderedColors","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M1012));
c.Add(new JMethod(1013,"forge/card/ColorSet","getSymbolsString","()Ljava/lang/String;",1,4,3,new JHandler[]{},M1013));
c.Add(new JMethod(1014,"forge/card/ColorSet","$values","()[Lforge/card/ColorSet;",4106,0,4,new JHandler[]{},M1014));
c.Add(new JMethod(1015,"forge/card/ColorSet","<clinit>","()V",8,0,8,new JHandler[]{},M1015));
}

internal static JStep M972(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/ColorSet","$VALUES","[Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","$VALUES","[Lforge/card/ColorSet;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/ColorSet;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/ColorSet;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M973(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/ColorSet")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ColorSet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M974(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/ColorSet","symbolString","Ljava/lang/String;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/ColorSet","orderedShards","Ljava/util/Collection;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/card/ColorSet","calcOrderWeight","()F","invokevirtual",24);}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/ColorSet","orderWeight","F",value);f.Pc=27;continue;}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M975(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(31));f.Pc=3;continue;}
case 3:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/ColorSet","values","()[Lforge/card/ColorSet;","invokestatic",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M976(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?37:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=20;continue;}
case 20:{f.Locals[5]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/card/MagicColor$Color","getColorMask","()B","invokevirtual",28);}
case 28:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=29;continue;}
case 29:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=30;continue;}
case 30:{f.Locals[1]=f.Pop();f.Pc=31;continue;}
case 31:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=34;continue;}
case 34:{f.Pc=10;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",41);}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M977(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?39:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/MagicColor$Color"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/MagicColor$Color","getColorMask","()B","invokevirtual",33);}
case 33:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=34;continue;}
case 34:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=35;continue;}
case 35:{f.Locals[1]=f.Pop();f.Pc=36;continue;}
case 36:{f.Pc=9;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",43);}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M978(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?37:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=20;continue;}
case 20:{f.Locals[5]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",28);}
case 28:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=29;continue;}
case 29:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=30;continue;}
case 30:{f.Locals[1]=f.Pop();f.Pc=31;continue;}
case 31:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=34;continue;}
case 34:{f.Pc=10;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",41);}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M979(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?39:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",33);}
case 33:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=34;continue;}
case 34:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=35;continue;}
case 35:{f.Locals[1]=f.Pop();f.Pc=36;continue;}
case 36:{f.Pc=9;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",43);}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M980(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?37:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=20;continue;}
case 20:{f.Locals[5]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/card/MagicColor","fromName","(C)B","invokestatic",28);}
case 28:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=29;continue;}
case 29:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=30;continue;}
case 30:{f.Locals[1]=f.Pop();f.Pc=31;continue;}
case 31:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=34;continue;}
case 34:{f.Pc=10;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",41);}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M981(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/mana/ManaCost","getColorProfile","()B","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M982(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?37:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=20;continue;}
case 20:{f.Locals[5]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",28);}
case 28:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=29;continue;}
case 29:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=30;continue;}
case 30:{f.Locals[1]=f.Pop();f.Pc=31;continue;}
case 31:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=34;continue;}
case 34:{f.Pc=10;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",41);}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M983(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ColorSet","ordinal","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Int==0?13:9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{f.Pc=14;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M984(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/ColorSet","orderedShards","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Collection","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M985(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ColorSet","ordinal","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?14:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M986(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ColorSet","ordinal","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M987(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/card/ColorSet","hasNoColorsExcept","(I)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M988(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ColorSet","ordinal","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(-1));f.Pc=6;continue;}
case 6:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ixor",a,b));f.Pc=7;continue;}
case 7:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int!=0?15:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{f.Pc=16;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M989(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ColorSet","ordinal","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(-1));f.Pc=6;continue;}
case 6:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ixor",a,b));f.Pc=7;continue;}
case 7:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M990(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ColorSet","ordinal","()I","invokevirtual",4);}
case 4:{f.Push(JValue.I(-1));f.Pc=5;continue;}
case 5:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ixor",a,b));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int!=0?15:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{f.Pc=16;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M991(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ColorSet","ordinal","()I","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/util/BinaryUtil","bitCount","(I)I","invokestatic",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M992(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",4);}
case 4:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=5;continue;}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/ColorSet","hasWhite","()Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?18:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.F(0.0005000000237487257f));f.Pc=16;continue;}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fadd",a,b));f.Pc=17;continue;}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/ColorSet","hasBlue","()Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?30:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.F(0.0020000000949949026f));f.Pc=28;continue;}
case 28:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fadd",a,b));f.Pc=29;continue;}
case 29:{f.Locals[1]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/card/ColorSet","hasBlack","()Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?42:37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(JValue.F(0.00800000037997961f));f.Pc=40;continue;}
case 40:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fadd",a,b));f.Pc=41;continue;}
case 41:{f.Locals[1]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/card/ColorSet","hasRed","()Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?54:49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(JValue.F(0.03200000151991844f));f.Pc=52;continue;}
case 52:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fadd",a,b));f.Pc=53;continue;}
case 53:{f.Locals[1]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/card/ColorSet","hasGreen","()Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?66:61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.Push(JValue.F(0.12800000607967377f));f.Pc=64;continue;}
case 64:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fadd",a,b));f.Pc=65;continue;}
case 65:{f.Locals[1]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M993(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/ColorSet","orderWeight","F"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M994(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/card/ColorSet","C","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","C","Lforge/card/ColorSet;"));f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M995(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",4);}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M996(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"));f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M997(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",4);}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M998(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/ColorSet","ordinal","()I","invokevirtual",5);}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M999(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1000(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(2));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1001(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(4));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1002(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(8));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1003(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(16));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1004(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ColorSet","ordinal","()I","invokevirtual",4);}
case 4:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=5;continue;}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(31));f.Pc=9;continue;}
case 9:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ixor",a,b));f.Pc=10;continue;}
case 10:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=11;continue;}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1005(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ColorSet","ordinal","()I","invokevirtual",4);}
case 4:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1006(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ColorSet","ordinal","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/ColorSet","ordinal","()I","invokevirtual",8);}
case 8:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Int==0?16:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Pc=17;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1007(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",8);}
case 8:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1008(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ColorSet","ordinal","()I","invokevirtual",4);}
case 4:{f.Push(JValue.I(-1));f.Pc=5;continue;}
case 5:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ixor",a,b));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/ColorSet","ordinal","()I","invokevirtual",10);}
case 10:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1009(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/ColorSet","orderedShards","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/EnumSet","copyOf","(Ljava/util/Collection;)Ljava/util/EnumSet;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1010(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/ColorSet","orderedShards","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1011(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/ColorSet","orderedShards","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1012(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/ColorSet","orderedShards","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1013(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/ColorSet","symbolString","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?70:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(32));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/StringBuilder","<init>","(I)V","invokespecial",16);}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/card/ColorSet","orderedShards","Ljava/util/Collection;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?62:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/MagicColor$Color"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Pc=f.Pop().Reference==null?59:50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/card/MagicColor$Color","getSymbol","()Ljava/lang/String;","invokevirtual",55);}
case 55:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",58);}
case 58:{f.StackOp("pop");f.Pc=59;continue;}
case 59:{f.Pc=27;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",67);}
case 67:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/ColorSet","symbolString","Ljava/lang/String;",value);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/card/ColorSet","symbolString","Ljava/lang/String;"));f.Pc=74;continue;}
case 74:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1014(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(32));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/card/ColorSet;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/ColorSet","C","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","C","Lforge/card/ColorSet;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/ColorSet","W","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","W","Lforge/card/ColorSet;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/ColorSet","U","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","U","Lforge/card/ColorSet;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/ColorSet","WU","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","WU","Lforge/card/ColorSet;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/card/ColorSet","B","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","B","Lforge/card/ColorSet;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/ColorSet","WB","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","WB","Lforge/card/ColorSet;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/card/ColorSet","UB","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","UB","Lforge/card/ColorSet;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/card/ColorSet","WUB","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","WUB","Lforge/card/ColorSet;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/card/ColorSet","R","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","R","Lforge/card/ColorSet;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/card/ColorSet","RW","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","RW","Lforge/card/ColorSet;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/card/ColorSet","UR","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","UR","Lforge/card/ColorSet;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(11));f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/card/ColorSet","URW","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","URW","Lforge/card/ColorSet;"));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(12));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/card/ColorSet","BR","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","BR","Lforge/card/ColorSet;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(13));f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/card/ColorSet","RWB","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","RWB","Lforge/card/ColorSet;"));f.Pc=96;continue;}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(14));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/card/ColorSet","UBR","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","UBR","Lforge/card/ColorSet;"));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{f.StackOp("dup");f.Pc=105;continue;}
case 105:{f.Push(JValue.I(15));f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/card/ColorSet","WUBR","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","WUBR","Lforge/card/ColorSet;"));f.Pc=110;continue;}
case 110:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{f.Push(JValue.I(16));f.Pc=114;continue;}
case 114:{if(!rt.StaticReady(f,"forge/card/ColorSet","G","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","G","Lforge/card/ColorSet;"));f.Pc=117;continue;}
case 117:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(JValue.I(17));f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/card/ColorSet","GW","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","GW","Lforge/card/ColorSet;"));f.Pc=124;continue;}
case 124:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{f.Push(JValue.I(18));f.Pc=128;continue;}
case 128:{if(!rt.StaticReady(f,"forge/card/ColorSet","GU","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","GU","Lforge/card/ColorSet;"));f.Pc=131;continue;}
case 131:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=132;continue;}
case 132:{f.StackOp("dup");f.Pc=133;continue;}
case 133:{f.Push(JValue.I(19));f.Pc=135;continue;}
case 135:{if(!rt.StaticReady(f,"forge/card/ColorSet","GWU","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","GWU","Lforge/card/ColorSet;"));f.Pc=138;continue;}
case 138:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=139;continue;}
case 139:{f.StackOp("dup");f.Pc=140;continue;}
case 140:{f.Push(JValue.I(20));f.Pc=142;continue;}
case 142:{if(!rt.StaticReady(f,"forge/card/ColorSet","BG","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","BG","Lforge/card/ColorSet;"));f.Pc=145;continue;}
case 145:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=146;continue;}
case 146:{f.StackOp("dup");f.Pc=147;continue;}
case 147:{f.Push(JValue.I(21));f.Pc=149;continue;}
case 149:{if(!rt.StaticReady(f,"forge/card/ColorSet","WBG","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","WBG","Lforge/card/ColorSet;"));f.Pc=152;continue;}
case 152:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=153;continue;}
case 153:{f.StackOp("dup");f.Pc=154;continue;}
case 154:{f.Push(JValue.I(22));f.Pc=156;continue;}
case 156:{if(!rt.StaticReady(f,"forge/card/ColorSet","BGU","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","BGU","Lforge/card/ColorSet;"));f.Pc=159;continue;}
case 159:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=160;continue;}
case 160:{f.StackOp("dup");f.Pc=161;continue;}
case 161:{f.Push(JValue.I(23));f.Pc=163;continue;}
case 163:{if(!rt.StaticReady(f,"forge/card/ColorSet","GWUB","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","GWUB","Lforge/card/ColorSet;"));f.Pc=166;continue;}
case 166:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=167;continue;}
case 167:{f.StackOp("dup");f.Pc=168;continue;}
case 168:{f.Push(JValue.I(24));f.Pc=170;continue;}
case 170:{if(!rt.StaticReady(f,"forge/card/ColorSet","RG","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","RG","Lforge/card/ColorSet;"));f.Pc=173;continue;}
case 173:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=174;continue;}
case 174:{f.StackOp("dup");f.Pc=175;continue;}
case 175:{f.Push(JValue.I(25));f.Pc=177;continue;}
case 177:{if(!rt.StaticReady(f,"forge/card/ColorSet","RGW","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","RGW","Lforge/card/ColorSet;"));f.Pc=180;continue;}
case 180:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=181;continue;}
case 181:{f.StackOp("dup");f.Pc=182;continue;}
case 182:{f.Push(JValue.I(26));f.Pc=184;continue;}
case 184:{if(!rt.StaticReady(f,"forge/card/ColorSet","GUR","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","GUR","Lforge/card/ColorSet;"));f.Pc=187;continue;}
case 187:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=188;continue;}
case 188:{f.StackOp("dup");f.Pc=189;continue;}
case 189:{f.Push(JValue.I(27));f.Pc=191;continue;}
case 191:{if(!rt.StaticReady(f,"forge/card/ColorSet","RGWU","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","RGWU","Lforge/card/ColorSet;"));f.Pc=194;continue;}
case 194:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=195;continue;}
case 195:{f.StackOp("dup");f.Pc=196;continue;}
case 196:{f.Push(JValue.I(28));f.Pc=198;continue;}
case 198:{if(!rt.StaticReady(f,"forge/card/ColorSet","BRG","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","BRG","Lforge/card/ColorSet;"));f.Pc=201;continue;}
case 201:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=202;continue;}
case 202:{f.StackOp("dup");f.Pc=203;continue;}
case 203:{f.Push(JValue.I(29));f.Pc=205;continue;}
case 205:{if(!rt.StaticReady(f,"forge/card/ColorSet","BRGW","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","BRGW","Lforge/card/ColorSet;"));f.Pc=208;continue;}
case 208:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=209;continue;}
case 209:{f.StackOp("dup");f.Pc=210;continue;}
case 210:{f.Push(JValue.I(30));f.Pc=212;continue;}
case 212:{if(!rt.StaticReady(f,"forge/card/ColorSet","UBRG","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","UBRG","Lforge/card/ColorSet;"));f.Pc=215;continue;}
case 215:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=216;continue;}
case 216:{f.StackOp("dup");f.Pc=217;continue;}
case 217:{f.Push(JValue.I(31));f.Pc=219;continue;}
case 219:{if(!rt.StaticReady(f,"forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"));f.Pc=222;continue;}
case 222:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=223;continue;}
case 223:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1015(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("C")));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","COLORLESS","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","COLORLESS","Lforge/card/MagicColor$Color;"));f.Pc=17;continue;}
case 17:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",21);}
case 21:{if(!rt.StaticReady(f,"forge/card/ColorSet","C","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","C","Lforge/card/ColorSet;",f.Pop());f.Pc=24;continue;}
case 24:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("W")));f.Pc=31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=41;continue;}
case 41:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",45);}
case 45:{if(!rt.StaticReady(f,"forge/card/ColorSet","W","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","W","Lforge/card/ColorSet;",f.Pop());f.Pc=48;continue;}
case 48:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=51;continue;}
case 51:{f.StackOp("dup");f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("U")));f.Pc=55;continue;}
case 55:{f.Push(JValue.I(2));f.Pc=56;continue;}
case 56:{f.Push(JValue.I(1));f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=60;continue;}
case 60:{f.StackOp("dup");f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=65;continue;}
case 65:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",69);}
case 69:{if(!rt.StaticReady(f,"forge/card/ColorSet","U","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","U","Lforge/card/ColorSet;",f.Pop());f.Pc=72;continue;}
case 72:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("WU")));f.Pc=79;continue;}
case 79:{f.Push(JValue.I(3));f.Pc=80;continue;}
case 80:{f.Push(JValue.I(2));f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{f.Push(JValue.I(0));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(1));f.Pc=92;continue;}
case 92:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=95;continue;}
case 95:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",99);}
case 99:{if(!rt.StaticReady(f,"forge/card/ColorSet","WU","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","WU","Lforge/card/ColorSet;",f.Pop());f.Pc=102;continue;}
case 102:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=105;continue;}
case 105:{f.StackOp("dup");f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("B")));f.Pc=109;continue;}
case 109:{f.Push(JValue.I(4));f.Pc=110;continue;}
case 110:{f.Push(JValue.I(1));f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=114;continue;}
case 114:{f.StackOp("dup");f.Pc=115;continue;}
case 115:{f.Push(JValue.I(0));f.Pc=116;continue;}
case 116:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=119;continue;}
case 119:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",123);}
case 123:{if(!rt.StaticReady(f,"forge/card/ColorSet","B","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","B","Lforge/card/ColorSet;",f.Pop());f.Pc=126;continue;}
case 126:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=129;continue;}
case 129:{f.StackOp("dup");f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("WB")));f.Pc=133;continue;}
case 133:{f.Push(JValue.I(5));f.Pc=134;continue;}
case 134:{f.Push(JValue.I(2));f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=138;continue;}
case 138:{f.StackOp("dup");f.Pc=139;continue;}
case 139:{f.Push(JValue.I(0));f.Pc=140;continue;}
case 140:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=143;continue;}
case 143:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=144;continue;}
case 144:{f.StackOp("dup");f.Pc=145;continue;}
case 145:{f.Push(JValue.I(1));f.Pc=146;continue;}
case 146:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=149;continue;}
case 149:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",153);}
case 153:{if(!rt.StaticReady(f,"forge/card/ColorSet","WB","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","WB","Lforge/card/ColorSet;",f.Pop());f.Pc=156;continue;}
case 156:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=159;continue;}
case 159:{f.StackOp("dup");f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("UB")));f.Pc=163;continue;}
case 163:{f.Push(JValue.I(6));f.Pc=165;continue;}
case 165:{f.Push(JValue.I(2));f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=169;continue;}
case 169:{f.StackOp("dup");f.Pc=170;continue;}
case 170:{f.Push(JValue.I(0));f.Pc=171;continue;}
case 171:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=174;continue;}
case 174:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=175;continue;}
case 175:{f.StackOp("dup");f.Pc=176;continue;}
case 176:{f.Push(JValue.I(1));f.Pc=177;continue;}
case 177:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=180;continue;}
case 180:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",184);}
case 184:{if(!rt.StaticReady(f,"forge/card/ColorSet","UB","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","UB","Lforge/card/ColorSet;",f.Pop());f.Pc=187;continue;}
case 187:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=190;continue;}
case 190:{f.StackOp("dup");f.Pc=191;continue;}
case 191:{f.Push(JValue.R(rt.String("WUB")));f.Pc=194;continue;}
case 194:{f.Push(JValue.I(7));f.Pc=196;continue;}
case 196:{f.Push(JValue.I(3));f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=200;continue;}
case 200:{f.StackOp("dup");f.Pc=201;continue;}
case 201:{f.Push(JValue.I(0));f.Pc=202;continue;}
case 202:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=205;continue;}
case 205:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=206;continue;}
case 206:{f.StackOp("dup");f.Pc=207;continue;}
case 207:{f.Push(JValue.I(1));f.Pc=208;continue;}
case 208:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=211;continue;}
case 211:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=212;continue;}
case 212:{f.StackOp("dup");f.Pc=213;continue;}
case 213:{f.Push(JValue.I(2));f.Pc=214;continue;}
case 214:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=217;continue;}
case 217:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",221);}
case 221:{if(!rt.StaticReady(f,"forge/card/ColorSet","WUB","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","WUB","Lforge/card/ColorSet;",f.Pop());f.Pc=224;continue;}
case 224:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=227;continue;}
case 227:{f.StackOp("dup");f.Pc=228;continue;}
case 228:{f.Push(JValue.R(rt.String("R")));f.Pc=231;continue;}
case 231:{f.Push(JValue.I(8));f.Pc=233;continue;}
case 233:{f.Push(JValue.I(1));f.Pc=234;continue;}
case 234:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=237;continue;}
case 237:{f.StackOp("dup");f.Pc=238;continue;}
case 238:{f.Push(JValue.I(0));f.Pc=239;continue;}
case 239:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=242;continue;}
case 242:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",246);}
case 246:{if(!rt.StaticReady(f,"forge/card/ColorSet","R","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","R","Lforge/card/ColorSet;",f.Pop());f.Pc=249;continue;}
case 249:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=252;continue;}
case 252:{f.StackOp("dup");f.Pc=253;continue;}
case 253:{f.Push(JValue.R(rt.String("RW")));f.Pc=256;continue;}
case 256:{f.Push(JValue.I(9));f.Pc=258;continue;}
case 258:{f.Push(JValue.I(2));f.Pc=259;continue;}
case 259:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=262;continue;}
case 262:{f.StackOp("dup");f.Pc=263;continue;}
case 263:{f.Push(JValue.I(0));f.Pc=264;continue;}
case 264:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=267;continue;}
case 267:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=268;continue;}
case 268:{f.StackOp("dup");f.Pc=269;continue;}
case 269:{f.Push(JValue.I(1));f.Pc=270;continue;}
case 270:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=273;continue;}
case 273:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",277);}
case 277:{if(!rt.StaticReady(f,"forge/card/ColorSet","RW","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","RW","Lforge/card/ColorSet;",f.Pop());f.Pc=280;continue;}
case 280:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=283;continue;}
case 283:{f.StackOp("dup");f.Pc=284;continue;}
case 284:{f.Push(JValue.R(rt.String("UR")));f.Pc=287;continue;}
case 287:{f.Push(JValue.I(10));f.Pc=289;continue;}
case 289:{f.Push(JValue.I(2));f.Pc=290;continue;}
case 290:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=293;continue;}
case 293:{f.StackOp("dup");f.Pc=294;continue;}
case 294:{f.Push(JValue.I(0));f.Pc=295;continue;}
case 295:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=298;continue;}
case 298:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=299;continue;}
case 299:{f.StackOp("dup");f.Pc=300;continue;}
case 300:{f.Push(JValue.I(1));f.Pc=301;continue;}
case 301:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=304;continue;}
case 304:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",308);}
case 308:{if(!rt.StaticReady(f,"forge/card/ColorSet","UR","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","UR","Lforge/card/ColorSet;",f.Pop());f.Pc=311;continue;}
case 311:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=314;continue;}
case 314:{f.StackOp("dup");f.Pc=315;continue;}
case 315:{f.Push(JValue.R(rt.String("URW")));f.Pc=318;continue;}
case 318:{f.Push(JValue.I(11));f.Pc=320;continue;}
case 320:{f.Push(JValue.I(3));f.Pc=321;continue;}
case 321:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=324;continue;}
case 324:{f.StackOp("dup");f.Pc=325;continue;}
case 325:{f.Push(JValue.I(0));f.Pc=326;continue;}
case 326:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=329;continue;}
case 329:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=330;continue;}
case 330:{f.StackOp("dup");f.Pc=331;continue;}
case 331:{f.Push(JValue.I(1));f.Pc=332;continue;}
case 332:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=335;continue;}
case 335:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=336;continue;}
case 336:{f.StackOp("dup");f.Pc=337;continue;}
case 337:{f.Push(JValue.I(2));f.Pc=338;continue;}
case 338:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=341;continue;}
case 341:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",345);}
case 345:{if(!rt.StaticReady(f,"forge/card/ColorSet","URW","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","URW","Lforge/card/ColorSet;",f.Pop());f.Pc=348;continue;}
case 348:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=351;continue;}
case 351:{f.StackOp("dup");f.Pc=352;continue;}
case 352:{f.Push(JValue.R(rt.String("BR")));f.Pc=355;continue;}
case 355:{f.Push(JValue.I(12));f.Pc=357;continue;}
case 357:{f.Push(JValue.I(2));f.Pc=358;continue;}
case 358:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=361;continue;}
case 361:{f.StackOp("dup");f.Pc=362;continue;}
case 362:{f.Push(JValue.I(0));f.Pc=363;continue;}
case 363:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=366;continue;}
case 366:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=367;continue;}
case 367:{f.StackOp("dup");f.Pc=368;continue;}
case 368:{f.Push(JValue.I(1));f.Pc=369;continue;}
case 369:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=372;continue;}
case 372:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",376);}
case 376:{if(!rt.StaticReady(f,"forge/card/ColorSet","BR","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","BR","Lforge/card/ColorSet;",f.Pop());f.Pc=379;continue;}
case 379:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=382;continue;}
case 382:{f.StackOp("dup");f.Pc=383;continue;}
case 383:{f.Push(JValue.R(rt.String("RWB")));f.Pc=386;continue;}
case 386:{f.Push(JValue.I(13));f.Pc=388;continue;}
case 388:{f.Push(JValue.I(3));f.Pc=389;continue;}
case 389:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=392;continue;}
case 392:{f.StackOp("dup");f.Pc=393;continue;}
case 393:{f.Push(JValue.I(0));f.Pc=394;continue;}
case 394:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=397;continue;}
case 397:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=398;continue;}
case 398:{f.StackOp("dup");f.Pc=399;continue;}
case 399:{f.Push(JValue.I(1));f.Pc=400;continue;}
case 400:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=403;continue;}
case 403:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=404;continue;}
case 404:{f.StackOp("dup");f.Pc=405;continue;}
case 405:{f.Push(JValue.I(2));f.Pc=406;continue;}
case 406:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=409;continue;}
case 409:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=410;continue;}
case 410:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",413);}
case 413:{if(!rt.StaticReady(f,"forge/card/ColorSet","RWB","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","RWB","Lforge/card/ColorSet;",f.Pop());f.Pc=416;continue;}
case 416:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=419;continue;}
case 419:{f.StackOp("dup");f.Pc=420;continue;}
case 420:{f.Push(JValue.R(rt.String("UBR")));f.Pc=423;continue;}
case 423:{f.Push(JValue.I(14));f.Pc=425;continue;}
case 425:{f.Push(JValue.I(3));f.Pc=426;continue;}
case 426:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=429;continue;}
case 429:{f.StackOp("dup");f.Pc=430;continue;}
case 430:{f.Push(JValue.I(0));f.Pc=431;continue;}
case 431:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=434;continue;}
case 434:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=435;continue;}
case 435:{f.StackOp("dup");f.Pc=436;continue;}
case 436:{f.Push(JValue.I(1));f.Pc=437;continue;}
case 437:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=440;continue;}
case 440:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=441;continue;}
case 441:{f.StackOp("dup");f.Pc=442;continue;}
case 442:{f.Push(JValue.I(2));f.Pc=443;continue;}
case 443:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=446;continue;}
case 446:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=447;continue;}
case 447:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",450);}
case 450:{if(!rt.StaticReady(f,"forge/card/ColorSet","UBR","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","UBR","Lforge/card/ColorSet;",f.Pop());f.Pc=453;continue;}
case 453:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=456;continue;}
case 456:{f.StackOp("dup");f.Pc=457;continue;}
case 457:{f.Push(JValue.R(rt.String("WUBR")));f.Pc=460;continue;}
case 460:{f.Push(JValue.I(15));f.Pc=462;continue;}
case 462:{f.Push(JValue.I(4));f.Pc=463;continue;}
case 463:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=466;continue;}
case 466:{f.StackOp("dup");f.Pc=467;continue;}
case 467:{f.Push(JValue.I(0));f.Pc=468;continue;}
case 468:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=471;continue;}
case 471:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=472;continue;}
case 472:{f.StackOp("dup");f.Pc=473;continue;}
case 473:{f.Push(JValue.I(1));f.Pc=474;continue;}
case 474:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=477;continue;}
case 477:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=478;continue;}
case 478:{f.StackOp("dup");f.Pc=479;continue;}
case 479:{f.Push(JValue.I(2));f.Pc=480;continue;}
case 480:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=483;continue;}
case 483:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=484;continue;}
case 484:{f.StackOp("dup");f.Pc=485;continue;}
case 485:{f.Push(JValue.I(3));f.Pc=486;continue;}
case 486:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=489;continue;}
case 489:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=490;continue;}
case 490:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",493);}
case 493:{if(!rt.StaticReady(f,"forge/card/ColorSet","WUBR","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","WUBR","Lforge/card/ColorSet;",f.Pop());f.Pc=496;continue;}
case 496:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=499;continue;}
case 499:{f.StackOp("dup");f.Pc=500;continue;}
case 500:{f.Push(JValue.R(rt.String("G")));f.Pc=503;continue;}
case 503:{f.Push(JValue.I(16));f.Pc=505;continue;}
case 505:{f.Push(JValue.I(1));f.Pc=506;continue;}
case 506:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=509;continue;}
case 509:{f.StackOp("dup");f.Pc=510;continue;}
case 510:{f.Push(JValue.I(0));f.Pc=511;continue;}
case 511:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=514;continue;}
case 514:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=515;continue;}
case 515:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",518);}
case 518:{if(!rt.StaticReady(f,"forge/card/ColorSet","G","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","G","Lforge/card/ColorSet;",f.Pop());f.Pc=521;continue;}
case 521:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=524;continue;}
case 524:{f.StackOp("dup");f.Pc=525;continue;}
case 525:{f.Push(JValue.R(rt.String("GW")));f.Pc=528;continue;}
case 528:{f.Push(JValue.I(17));f.Pc=530;continue;}
case 530:{f.Push(JValue.I(2));f.Pc=531;continue;}
case 531:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=534;continue;}
case 534:{f.StackOp("dup");f.Pc=535;continue;}
case 535:{f.Push(JValue.I(0));f.Pc=536;continue;}
case 536:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=539;continue;}
case 539:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=540;continue;}
case 540:{f.StackOp("dup");f.Pc=541;continue;}
case 541:{f.Push(JValue.I(1));f.Pc=542;continue;}
case 542:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=545;continue;}
case 545:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=546;continue;}
case 546:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",549);}
case 549:{if(!rt.StaticReady(f,"forge/card/ColorSet","GW","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","GW","Lforge/card/ColorSet;",f.Pop());f.Pc=552;continue;}
case 552:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=555;continue;}
case 555:{f.StackOp("dup");f.Pc=556;continue;}
case 556:{f.Push(JValue.R(rt.String("GU")));f.Pc=559;continue;}
case 559:{f.Push(JValue.I(18));f.Pc=561;continue;}
case 561:{f.Push(JValue.I(2));f.Pc=562;continue;}
case 562:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=565;continue;}
case 565:{f.StackOp("dup");f.Pc=566;continue;}
case 566:{f.Push(JValue.I(0));f.Pc=567;continue;}
case 567:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=570;continue;}
case 570:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=571;continue;}
case 571:{f.StackOp("dup");f.Pc=572;continue;}
case 572:{f.Push(JValue.I(1));f.Pc=573;continue;}
case 573:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=576;continue;}
case 576:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=577;continue;}
case 577:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",580);}
case 580:{if(!rt.StaticReady(f,"forge/card/ColorSet","GU","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","GU","Lforge/card/ColorSet;",f.Pop());f.Pc=583;continue;}
case 583:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=586;continue;}
case 586:{f.StackOp("dup");f.Pc=587;continue;}
case 587:{f.Push(JValue.R(rt.String("GWU")));f.Pc=590;continue;}
case 590:{f.Push(JValue.I(19));f.Pc=592;continue;}
case 592:{f.Push(JValue.I(3));f.Pc=593;continue;}
case 593:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=596;continue;}
case 596:{f.StackOp("dup");f.Pc=597;continue;}
case 597:{f.Push(JValue.I(0));f.Pc=598;continue;}
case 598:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=601;continue;}
case 601:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=602;continue;}
case 602:{f.StackOp("dup");f.Pc=603;continue;}
case 603:{f.Push(JValue.I(1));f.Pc=604;continue;}
case 604:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=607;continue;}
case 607:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=608;continue;}
case 608:{f.StackOp("dup");f.Pc=609;continue;}
case 609:{f.Push(JValue.I(2));f.Pc=610;continue;}
case 610:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=613;continue;}
case 613:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=614;continue;}
case 614:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",617);}
case 617:{if(!rt.StaticReady(f,"forge/card/ColorSet","GWU","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","GWU","Lforge/card/ColorSet;",f.Pop());f.Pc=620;continue;}
case 620:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=623;continue;}
case 623:{f.StackOp("dup");f.Pc=624;continue;}
case 624:{f.Push(JValue.R(rt.String("BG")));f.Pc=627;continue;}
case 627:{f.Push(JValue.I(20));f.Pc=629;continue;}
case 629:{f.Push(JValue.I(2));f.Pc=630;continue;}
case 630:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=633;continue;}
case 633:{f.StackOp("dup");f.Pc=634;continue;}
case 634:{f.Push(JValue.I(0));f.Pc=635;continue;}
case 635:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=638;continue;}
case 638:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=639;continue;}
case 639:{f.StackOp("dup");f.Pc=640;continue;}
case 640:{f.Push(JValue.I(1));f.Pc=641;continue;}
case 641:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=644;continue;}
case 644:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=645;continue;}
case 645:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",648);}
case 648:{if(!rt.StaticReady(f,"forge/card/ColorSet","BG","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","BG","Lforge/card/ColorSet;",f.Pop());f.Pc=651;continue;}
case 651:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=654;continue;}
case 654:{f.StackOp("dup");f.Pc=655;continue;}
case 655:{f.Push(JValue.R(rt.String("WBG")));f.Pc=658;continue;}
case 658:{f.Push(JValue.I(21));f.Pc=660;continue;}
case 660:{f.Push(JValue.I(3));f.Pc=661;continue;}
case 661:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=664;continue;}
case 664:{f.StackOp("dup");f.Pc=665;continue;}
case 665:{f.Push(JValue.I(0));f.Pc=666;continue;}
case 666:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=669;continue;}
case 669:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=670;continue;}
case 670:{f.StackOp("dup");f.Pc=671;continue;}
case 671:{f.Push(JValue.I(1));f.Pc=672;continue;}
case 672:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=675;continue;}
case 675:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=676;continue;}
case 676:{f.StackOp("dup");f.Pc=677;continue;}
case 677:{f.Push(JValue.I(2));f.Pc=678;continue;}
case 678:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=681;continue;}
case 681:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=682;continue;}
case 682:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",685);}
case 685:{if(!rt.StaticReady(f,"forge/card/ColorSet","WBG","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","WBG","Lforge/card/ColorSet;",f.Pop());f.Pc=688;continue;}
case 688:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=691;continue;}
case 691:{f.StackOp("dup");f.Pc=692;continue;}
case 692:{f.Push(JValue.R(rt.String("BGU")));f.Pc=695;continue;}
case 695:{f.Push(JValue.I(22));f.Pc=697;continue;}
case 697:{f.Push(JValue.I(3));f.Pc=698;continue;}
case 698:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=701;continue;}
case 701:{f.StackOp("dup");f.Pc=702;continue;}
case 702:{f.Push(JValue.I(0));f.Pc=703;continue;}
case 703:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=706;continue;}
case 706:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=707;continue;}
case 707:{f.StackOp("dup");f.Pc=708;continue;}
case 708:{f.Push(JValue.I(1));f.Pc=709;continue;}
case 709:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=712;continue;}
case 712:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=713;continue;}
case 713:{f.StackOp("dup");f.Pc=714;continue;}
case 714:{f.Push(JValue.I(2));f.Pc=715;continue;}
case 715:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=718;continue;}
case 718:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=719;continue;}
case 719:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",722);}
case 722:{if(!rt.StaticReady(f,"forge/card/ColorSet","BGU","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","BGU","Lforge/card/ColorSet;",f.Pop());f.Pc=725;continue;}
case 725:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=728;continue;}
case 728:{f.StackOp("dup");f.Pc=729;continue;}
case 729:{f.Push(JValue.R(rt.String("GWUB")));f.Pc=732;continue;}
case 732:{f.Push(JValue.I(23));f.Pc=734;continue;}
case 734:{f.Push(JValue.I(4));f.Pc=735;continue;}
case 735:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=738;continue;}
case 738:{f.StackOp("dup");f.Pc=739;continue;}
case 739:{f.Push(JValue.I(0));f.Pc=740;continue;}
case 740:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=743;continue;}
case 743:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=744;continue;}
case 744:{f.StackOp("dup");f.Pc=745;continue;}
case 745:{f.Push(JValue.I(1));f.Pc=746;continue;}
case 746:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=749;continue;}
case 749:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=750;continue;}
case 750:{f.StackOp("dup");f.Pc=751;continue;}
case 751:{f.Push(JValue.I(2));f.Pc=752;continue;}
case 752:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=755;continue;}
case 755:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=756;continue;}
case 756:{f.StackOp("dup");f.Pc=757;continue;}
case 757:{f.Push(JValue.I(3));f.Pc=758;continue;}
case 758:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=761;continue;}
case 761:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=762;continue;}
case 762:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",765);}
case 765:{if(!rt.StaticReady(f,"forge/card/ColorSet","GWUB","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","GWUB","Lforge/card/ColorSet;",f.Pop());f.Pc=768;continue;}
case 768:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=771;continue;}
case 771:{f.StackOp("dup");f.Pc=772;continue;}
case 772:{f.Push(JValue.R(rt.String("RG")));f.Pc=775;continue;}
case 775:{f.Push(JValue.I(24));f.Pc=777;continue;}
case 777:{f.Push(JValue.I(2));f.Pc=778;continue;}
case 778:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=781;continue;}
case 781:{f.StackOp("dup");f.Pc=782;continue;}
case 782:{f.Push(JValue.I(0));f.Pc=783;continue;}
case 783:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=786;continue;}
case 786:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=787;continue;}
case 787:{f.StackOp("dup");f.Pc=788;continue;}
case 788:{f.Push(JValue.I(1));f.Pc=789;continue;}
case 789:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=792;continue;}
case 792:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=793;continue;}
case 793:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",796);}
case 796:{if(!rt.StaticReady(f,"forge/card/ColorSet","RG","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","RG","Lforge/card/ColorSet;",f.Pop());f.Pc=799;continue;}
case 799:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=802;continue;}
case 802:{f.StackOp("dup");f.Pc=803;continue;}
case 803:{f.Push(JValue.R(rt.String("RGW")));f.Pc=806;continue;}
case 806:{f.Push(JValue.I(25));f.Pc=808;continue;}
case 808:{f.Push(JValue.I(3));f.Pc=809;continue;}
case 809:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=812;continue;}
case 812:{f.StackOp("dup");f.Pc=813;continue;}
case 813:{f.Push(JValue.I(0));f.Pc=814;continue;}
case 814:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=817;continue;}
case 817:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=818;continue;}
case 818:{f.StackOp("dup");f.Pc=819;continue;}
case 819:{f.Push(JValue.I(1));f.Pc=820;continue;}
case 820:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=823;continue;}
case 823:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=824;continue;}
case 824:{f.StackOp("dup");f.Pc=825;continue;}
case 825:{f.Push(JValue.I(2));f.Pc=826;continue;}
case 826:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=829;continue;}
case 829:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=830;continue;}
case 830:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",833);}
case 833:{if(!rt.StaticReady(f,"forge/card/ColorSet","RGW","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","RGW","Lforge/card/ColorSet;",f.Pop());f.Pc=836;continue;}
case 836:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=839;continue;}
case 839:{f.StackOp("dup");f.Pc=840;continue;}
case 840:{f.Push(JValue.R(rt.String("GUR")));f.Pc=843;continue;}
case 843:{f.Push(JValue.I(26));f.Pc=845;continue;}
case 845:{f.Push(JValue.I(3));f.Pc=846;continue;}
case 846:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=849;continue;}
case 849:{f.StackOp("dup");f.Pc=850;continue;}
case 850:{f.Push(JValue.I(0));f.Pc=851;continue;}
case 851:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=854;continue;}
case 854:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=855;continue;}
case 855:{f.StackOp("dup");f.Pc=856;continue;}
case 856:{f.Push(JValue.I(1));f.Pc=857;continue;}
case 857:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=860;continue;}
case 860:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=861;continue;}
case 861:{f.StackOp("dup");f.Pc=862;continue;}
case 862:{f.Push(JValue.I(2));f.Pc=863;continue;}
case 863:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=866;continue;}
case 866:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=867;continue;}
case 867:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",870);}
case 870:{if(!rt.StaticReady(f,"forge/card/ColorSet","GUR","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","GUR","Lforge/card/ColorSet;",f.Pop());f.Pc=873;continue;}
case 873:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=876;continue;}
case 876:{f.StackOp("dup");f.Pc=877;continue;}
case 877:{f.Push(JValue.R(rt.String("RGWU")));f.Pc=880;continue;}
case 880:{f.Push(JValue.I(27));f.Pc=882;continue;}
case 882:{f.Push(JValue.I(4));f.Pc=883;continue;}
case 883:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=886;continue;}
case 886:{f.StackOp("dup");f.Pc=887;continue;}
case 887:{f.Push(JValue.I(0));f.Pc=888;continue;}
case 888:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=891;continue;}
case 891:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=892;continue;}
case 892:{f.StackOp("dup");f.Pc=893;continue;}
case 893:{f.Push(JValue.I(1));f.Pc=894;continue;}
case 894:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=897;continue;}
case 897:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=898;continue;}
case 898:{f.StackOp("dup");f.Pc=899;continue;}
case 899:{f.Push(JValue.I(2));f.Pc=900;continue;}
case 900:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=903;continue;}
case 903:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=904;continue;}
case 904:{f.StackOp("dup");f.Pc=905;continue;}
case 905:{f.Push(JValue.I(3));f.Pc=906;continue;}
case 906:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=909;continue;}
case 909:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=910;continue;}
case 910:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",913);}
case 913:{if(!rt.StaticReady(f,"forge/card/ColorSet","RGWU","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","RGWU","Lforge/card/ColorSet;",f.Pop());f.Pc=916;continue;}
case 916:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=919;continue;}
case 919:{f.StackOp("dup");f.Pc=920;continue;}
case 920:{f.Push(JValue.R(rt.String("BRG")));f.Pc=923;continue;}
case 923:{f.Push(JValue.I(28));f.Pc=925;continue;}
case 925:{f.Push(JValue.I(3));f.Pc=926;continue;}
case 926:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=929;continue;}
case 929:{f.StackOp("dup");f.Pc=930;continue;}
case 930:{f.Push(JValue.I(0));f.Pc=931;continue;}
case 931:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=934;continue;}
case 934:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=935;continue;}
case 935:{f.StackOp("dup");f.Pc=936;continue;}
case 936:{f.Push(JValue.I(1));f.Pc=937;continue;}
case 937:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=940;continue;}
case 940:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=941;continue;}
case 941:{f.StackOp("dup");f.Pc=942;continue;}
case 942:{f.Push(JValue.I(2));f.Pc=943;continue;}
case 943:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=946;continue;}
case 946:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=947;continue;}
case 947:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",950);}
case 950:{if(!rt.StaticReady(f,"forge/card/ColorSet","BRG","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","BRG","Lforge/card/ColorSet;",f.Pop());f.Pc=953;continue;}
case 953:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=956;continue;}
case 956:{f.StackOp("dup");f.Pc=957;continue;}
case 957:{f.Push(JValue.R(rt.String("BRGW")));f.Pc=960;continue;}
case 960:{f.Push(JValue.I(29));f.Pc=962;continue;}
case 962:{f.Push(JValue.I(4));f.Pc=963;continue;}
case 963:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=966;continue;}
case 966:{f.StackOp("dup");f.Pc=967;continue;}
case 967:{f.Push(JValue.I(0));f.Pc=968;continue;}
case 968:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=971;continue;}
case 971:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=972;continue;}
case 972:{f.StackOp("dup");f.Pc=973;continue;}
case 973:{f.Push(JValue.I(1));f.Pc=974;continue;}
case 974:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=977;continue;}
case 977:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=978;continue;}
case 978:{f.StackOp("dup");f.Pc=979;continue;}
case 979:{f.Push(JValue.I(2));f.Pc=980;continue;}
case 980:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=983;continue;}
case 983:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=984;continue;}
case 984:{f.StackOp("dup");f.Pc=985;continue;}
case 985:{f.Push(JValue.I(3));f.Pc=986;continue;}
case 986:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=989;continue;}
case 989:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=990;continue;}
case 990:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",993);}
case 993:{if(!rt.StaticReady(f,"forge/card/ColorSet","BRGW","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","BRGW","Lforge/card/ColorSet;",f.Pop());f.Pc=996;continue;}
case 996:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=999;continue;}
case 999:{f.StackOp("dup");f.Pc=1000;continue;}
case 1000:{f.Push(JValue.R(rt.String("UBRG")));f.Pc=1003;continue;}
case 1003:{f.Push(JValue.I(30));f.Pc=1005;continue;}
case 1005:{f.Push(JValue.I(4));f.Pc=1006;continue;}
case 1006:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=1009;continue;}
case 1009:{f.StackOp("dup");f.Pc=1010;continue;}
case 1010:{f.Push(JValue.I(0));f.Pc=1011;continue;}
case 1011:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=1014;continue;}
case 1014:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1015;continue;}
case 1015:{f.StackOp("dup");f.Pc=1016;continue;}
case 1016:{f.Push(JValue.I(1));f.Pc=1017;continue;}
case 1017:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=1020;continue;}
case 1020:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1021;continue;}
case 1021:{f.StackOp("dup");f.Pc=1022;continue;}
case 1022:{f.Push(JValue.I(2));f.Pc=1023;continue;}
case 1023:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=1026;continue;}
case 1026:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1027;continue;}
case 1027:{f.StackOp("dup");f.Pc=1028;continue;}
case 1028:{f.Push(JValue.I(3));f.Pc=1029;continue;}
case 1029:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=1032;continue;}
case 1032:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1033;continue;}
case 1033:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",1036);}
case 1036:{if(!rt.StaticReady(f,"forge/card/ColorSet","UBRG","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","UBRG","Lforge/card/ColorSet;",f.Pop());f.Pc=1039;continue;}
case 1039:{if(!rt.EnsureInitialized(f,"forge/card/ColorSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/ColorSet")));f.Pc=1042;continue;}
case 1042:{f.StackOp("dup");f.Pc=1043;continue;}
case 1043:{f.Push(JValue.R(rt.String("WUBRG")));f.Pc=1046;continue;}
case 1046:{f.Push(JValue.I(31));f.Pc=1048;continue;}
case 1048:{f.Push(JValue.I(5));f.Pc=1049;continue;}
case 1049:{f.Push(JValue.R(rt.NewArray("Lforge/card/MagicColor$Color;",f.Pop().Int)));f.Pc=1052;continue;}
case 1052:{f.StackOp("dup");f.Pc=1053;continue;}
case 1053:{f.Push(JValue.I(0));f.Pc=1054;continue;}
case 1054:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=1057;continue;}
case 1057:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1058;continue;}
case 1058:{f.StackOp("dup");f.Pc=1059;continue;}
case 1059:{f.Push(JValue.I(1));f.Pc=1060;continue;}
case 1060:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=1063;continue;}
case 1063:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1064;continue;}
case 1064:{f.StackOp("dup");f.Pc=1065;continue;}
case 1065:{f.Push(JValue.I(2));f.Pc=1066;continue;}
case 1066:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=1069;continue;}
case 1069:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1070;continue;}
case 1070:{f.StackOp("dup");f.Pc=1071;continue;}
case 1071:{f.Push(JValue.I(3));f.Pc=1072;continue;}
case 1072:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=1075;continue;}
case 1075:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1076;continue;}
case 1076:{f.StackOp("dup");f.Pc=1077;continue;}
case 1077:{f.Push(JValue.I(4));f.Pc=1078;continue;}
case 1078:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=1081;continue;}
case 1081:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1082;continue;}
case 1082:{return rt.Call(f,"forge/card/ColorSet","<init>","(Ljava/lang/String;I[Lforge/card/MagicColor$Color;)V","invokespecial",1085);}
case 1085:{if(!rt.StaticReady(f,"forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;",f.Pop());f.Pc=1088;continue;}
case 1088:{return rt.Call(f,"forge/card/ColorSet","$values","()[Lforge/card/ColorSet;","invokestatic",1091);}
case 1091:{if(!rt.StaticReady(f,"forge/card/ColorSet","$VALUES","[Lforge/card/ColorSet;"))return JStep.Continue;rt.PutStatic("forge/card/ColorSet","$VALUES","[Lforge/card/ColorSet;",f.Pop());f.Pc=1094;continue;}
case 1094:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
