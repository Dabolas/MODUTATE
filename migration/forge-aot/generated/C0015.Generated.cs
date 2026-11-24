// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C15{
internal static JClass Build(){var c=new JClass("forge/card/CardDb$CardRequest","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cardName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("edition","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("artIndex","I",false,JValue.Default("I"),null));
c.Add(new JField("isFoil","Z",false,JValue.Default("Z"),null));
c.Add(new JField("collectorNumber","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("flags","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(333,"forge/card/CardDb$CardRequest","<init>","(Ljava/lang/String;Ljava/lang/String;IZLjava/lang/String;Ljava/util/Map;)V",2,7,2,new JHandler[]{},M333));
c.Add(new JMethod(334,"forge/card/CardDb$CardRequest","isFoilCardName","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M334));
c.Add(new JMethod(335,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Z)Ljava/lang/String;",9,2,4,new JHandler[]{},M335));
c.Add(new JMethod(336,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,2,2,new JHandler[]{},M336));
c.Add(new JMethod(337,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;",9,4,2,new JHandler[]{},M337));
c.Add(new JMethod(338,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,4,2,new JHandler[]{},M338));
c.Add(new JMethod(339,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;ILjava/util/Map;)Ljava/lang/String;",9,5,3,new JHandler[]{},M339));
c.Add(new JMethod(340,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;",9,5,3,new JHandler[]{},M340));
c.Add(new JMethod(341,"forge/card/CardDb$CardRequest","compose","(Lforge/item/PaperCard;)Ljava/lang/String;",9,2,4,new JHandler[]{},M341));
c.Add(new JMethod(342,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)Ljava/lang/String;",9,5,3,new JHandler[]{},M342));
c.Add(new JMethod(343,"forge/card/CardDb$CardRequest","preprocessCollectorNumber","(Ljava/lang/String;)Ljava/lang/String;",10,1,2,new JHandler[]{},M343));
c.Add(new JMethod(344,"forge/card/CardDb$CardRequest","getFlagSegment","(Ljava/util/Map;)Ljava/lang/String;",10,2,2,new JHandler[]{},M344));
c.Add(new JMethod(345,"forge/card/CardDb$CardRequest","isCollectorNumber","(Ljava/lang/String;)Z",10,1,2,new JHandler[]{},M345));
c.Add(new JMethod(346,"forge/card/CardDb$CardRequest","isFlagSegment","(Ljava/lang/String;)Z",10,1,2,new JHandler[]{},M346));
c.Add(new JMethod(347,"forge/card/CardDb$CardRequest","isArtIndex","(Ljava/lang/String;)Z",10,1,2,new JHandler[]{},M347));
c.Add(new JMethod(348,"forge/card/CardDb$CardRequest","isSetCode","(Ljava/lang/String;)Z",10,1,1,new JHandler[]{},M348));
c.Add(new JMethod(349,"forge/card/CardDb$CardRequest","fromPreferredArtEntry","(Ljava/lang/String;Z)Lforge/card/CardDb$CardRequest;",10,6,8,new JHandler[]{new JHandler(15,48,49,"java/lang/NumberFormatException")},M349));
c.Add(new JMethod(350,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;",9,11,8,new JHandler[]{},M350));
c.Add(new JMethod(351,"forge/card/CardDb$CardRequest","parseRequestFlags","(Ljava/lang/String;)Ljava/util/Map;",10,3,7,new JHandler[]{},M351));
c.Add(new JMethod(352,"forge/card/CardDb$CardRequest","lambda$parseRequestFlags$4","([Ljava/lang/String;)Ljava/lang/String;",4106,1,2,new JHandler[]{},M352));
c.Add(new JMethod(353,"forge/card/CardDb$CardRequest","lambda$parseRequestFlags$3","([Ljava/lang/String;)Ljava/lang/String;",4106,1,2,new JHandler[]{},M353));
c.Add(new JMethod(354,"forge/card/CardDb$CardRequest","lambda$parseRequestFlags$2","([Ljava/lang/String;)Z",4106,1,1,new JHandler[]{},M354));
c.Add(new JMethod(355,"forge/card/CardDb$CardRequest","lambda$parseRequestFlags$1","(Ljava/lang/String;)[Ljava/lang/String;",4106,1,3,new JHandler[]{},M355));
c.Add(new JMethod(356,"forge/card/CardDb$CardRequest","lambda$getFlagSegment$0","(Ljava/util/Map$Entry;)Ljava/lang/String;",4106,1,2,new JHandler[]{},M356));
}

internal static JStep M333(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb$CardRequest","edition","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb$CardRequest","artIndex","I",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb$CardRequest","isFoil","Z",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb$CardRequest","collectorNumber","Ljava/lang/String;",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[6]);f.Pc=34;continue;}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb$CardRequest","flags","Ljava/util/Map;",value);f.Pc=37;continue;}
case 37:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M334(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("+")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M335(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int==0?22:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardDb$CardRequest","isFoilCardName","(Ljava/lang/String;)Z","invokestatic",8);}
case 8:{f.Pc=f.Pop().Int==0?15:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Pc=21;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:335:16:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",21);}
case 21:{return JStep.Return(f.Pop());}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/card/CardDb$CardRequest","isFoilCardName","(Ljava/lang/String;)Z","invokestatic",26);}
case 26:{f.Pc=f.Pop().Int==0?47:29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",35);}
case 35:{f.Push(JValue.R(rt.String("+")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",40);}
case 40:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Pc=48;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M336(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?20:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",8);}
case 8:{f.Pc=f.Pop().Int!=0?20:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("???")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?23:20;continue;}
case 20:{f.Push(JValue.R(rt.String("")));f.Pc=22;continue;}
case 22:{f.Locals[1]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Reference==null?31:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Pc=33;continue;}
case 31:{f.Push(JValue.R(rt.String("")));f.Pc=33;continue;}
case 33:{f.Locals[0]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(JValue.I(124));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",40);}
case 40:{f.Push(JValue.I(-1));f.Pc=41;continue;}
case 41:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?52:44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",48);}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=51;continue;}
case 51:{f.Locals[0]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:336:54:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",59);}
case 59:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M337(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",5);}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:337:14:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M338(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",5);}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardDb$CardRequest","preprocessCollectorNumber","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:338:13:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M339(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",5);}
case 5:{f.Locals[4]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Reference!=null?26:17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:339:20:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",25);}
case 25:{return JStep.Return(f.Pop());}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardDb$CardRequest","getFlagSegment","(Ljava/util/Map;)Ljava/lang/String;","invokestatic",33);}
case 33:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:339:33:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;ILjava/lang/String;)Ljava/lang/String;",38);}
case 38:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M340(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",5);}
case 5:{f.Locals[4]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardDb$CardRequest","preprocessCollectorNumber","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference==null?25:16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?34:25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:340:28:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",33);}
case 33:{return JStep.Return(f.Pop());}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/card/CardDb$CardRequest","getFlagSegment","(Ljava/util/Map;)Ljava/lang/String;","invokestatic",41);}
case 41:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:340:41:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",46);}
case 46:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M341(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCard","isFoil","()Z","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Z)Ljava/lang/String;","invokestatic",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/item/PaperCard","getMarkedFlags","()Lforge/item/PaperCard$PaperCardFlags;","invokevirtual",25);}
case 25:{return rt.Call(f,"forge/item/PaperCard$PaperCardFlags","toMap","()Ljava/util/Map;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;","invokestatic",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M342(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;","invokestatic",6);}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardDb$CardRequest","preprocessCollectorNumber","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:342:16:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M343(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?7:4;continue;}
case 4:{f.Push(JValue.R(rt.String("")));f.Pc=6;continue;}
case 6:{return JStep.Return(f.Pop());}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[0]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("[")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int!=0?28:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:343:22:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",27);}
case 27:{f.Locals[0]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("]")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int!=0?44:37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:343:38:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",43);}
case 43:{f.Locals[0]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M344(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?7:4;continue;}
case 4:{f.Push(JValue.R(rt.String("")));f.Pc=6;continue;}
case 6:{return JStep.Return(f.Pop());}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",13);}
case 13:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",18);}
case 18:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:344:18:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",23);}
case 23:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",28);}
case 28:{f.Push(JValue.R(rt.String("\t")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/stream/Collectors","joining","(Ljava/lang/CharSequence;)Ljava/util/stream/Collector;","invokestatic",33);}
case 33:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[1]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:344:43:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",48);}
case 48:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M345(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("[")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?22:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("]")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?22:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M346(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("#")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M347(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int==0?19:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",11);}
case 11:{f.Push(JValue.I(2));f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?19:15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Pc=20;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M348(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M349(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(124));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(3));f.Pc=10;continue;}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?15:13;continue;}
case 13:{f.Push(JValue.R(null));f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=18;continue;}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=22;continue;}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(JValue.I(2));f.Pc=26;continue;}
case 26:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",30);}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{if(!rt.EnsureInitialized(f,"forge/card/CardDb$CardRequest"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardDb$CardRequest")));f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("N.A.")));f.Pc=44;continue;}
case 44:{f.Push(JValue.R(null));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/card/CardDb$CardRequest","<init>","(Ljava/lang/String;Ljava/lang/String;IZLjava/lang/String;Ljava/util/Map;)V","invokespecial",48);}
case 48:{return JStep.Return(f.Pop());}
case 49:{f.Locals[3]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(JValue.R(null));f.Pc=51;continue;}
case 51:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M350(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(124));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=18;continue;}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(JValue.I(-1));f.Pc=23;continue;}
case 23:{f.Locals[5]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(JValue.R(null));f.Pc=26;continue;}
case 26:{f.Locals[6]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("N.A.")));f.Pc=30;continue;}
case 30:{f.Locals[7]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(JValue.R(null));f.Pc=33;continue;}
case 33:{f.Locals[8]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/card/CardDb$CardRequest","isFoilCardName","(Ljava/lang/String;)Z","invokestatic",39);}
case 39:{f.Pc=f.Pop().Int==0?61:42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",48);}
case 48:{f.Push(JValue.R(rt.String("+")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",53);}
case 53:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",57);}
case 57:{f.Locals[3]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(JValue.I(1));f.Pc=59;continue;}
case 59:{f.Locals[4]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?84:67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/card/CardDb$CardRequest","isSetCode","(Ljava/lang/String;)Z","invokestatic",73);}
case 73:{f.Pc=f.Pop().Int==0?84:76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=79;continue;}
case 79:{f.Locals[6]=f.Pop();f.Pc=81;continue;}
case 81:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?124:90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("$alt")));f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",100);}
case 100:{return rt.Call(f,"forge/card/CardDb$CardRequest","isArtIndex","(Ljava/lang/String;)Z","invokestatic",103);}
case 103:{f.Pc=f.Pop().Int==0?124:106;continue;}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[2]);f.Pc=108;continue;}
case 108:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("$alt")));f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String("")));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",116);}
case 116:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",119);}
case 119:{f.Locals[5]=f.Pop();f.Pc=121;continue;}
case 121:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=124;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?159:130;continue;}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/card/CardDb$CardRequest","isCollectorNumber","(Ljava/lang/String;)Z","invokestatic",136);}
case 136:{f.Pc=f.Pop().Int==0?159:139;continue;}
case 139:{f.Push(f.Locals[1]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[2]);f.Pc=141;continue;}
case 141:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=142;continue;}
case 142:{f.Push(JValue.I(1));f.Pc=143;continue;}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[2]);f.Pc=145;continue;}
case 145:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",149);}
case 149:{f.Push(JValue.I(1));f.Pc=150;continue;}
case 150:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",154);}
case 154:{f.Locals[7]=f.Pop();f.Pc=156;continue;}
case 156:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=161;continue;}
case 161:{f.Push(f.Locals[2]);f.Pc=162;continue;}
case 162:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?194:165;continue;}
case 165:{f.Push(f.Locals[1]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[2]);f.Pc=167;continue;}
case 167:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/card/CardDb$CardRequest","isFlagSegment","(Ljava/lang/String;)Z","invokestatic",171);}
case 171:{f.Pc=f.Pop().Int==0?194:174;continue;}
case 174:{f.Push(f.Locals[1]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[2]);f.Pc=176;continue;}
case 176:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=177;continue;}
case 177:{f.Push(JValue.R(rt.String("#")));f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",182);}
case 182:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",185);}
case 185:{f.Locals[9]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[9]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/card/CardDb$CardRequest","parseRequestFlags","(Ljava/lang/String;)Ljava/util/Map;","invokestatic",192);}
case 192:{f.Locals[8]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("???")));f.Pc=196;continue;}
case 196:{f.Push(f.Locals[6]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",201);}
case 201:{f.Pc=f.Pop().Int==0?207:204;continue;}
case 204:{f.Push(JValue.R(null));f.Pc=205;continue;}
case 205:{f.Locals[6]=f.Pop();f.Pc=207;continue;}
case 207:{f.Push(f.Locals[6]);f.Pc=209;continue;}
case 209:{f.Pc=f.Pop().Reference!=null?266:212;continue;}
case 212:{if(!rt.StaticReady(f,"forge/card/CardDb","artPrefs","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb","artPrefs","Ljava/util/Map;"));f.Pc=215;continue;}
case 215:{f.Push(f.Locals[3]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",221);}
case 221:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=224;continue;}
case 224:{f.Locals[9]=f.Pop();f.Pc=226;continue;}
case 226:{f.Push(f.Locals[9]);f.Pc=228;continue;}
case 228:{f.Pc=f.Pop().Reference==null?266:231;continue;}
case 231:{f.Push(f.Locals[9]);f.Pc=233;continue;}
case 233:{f.Push(f.Locals[4]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromPreferredArtEntry","(Ljava/lang/String;Z)Lforge/card/CardDb$CardRequest;","invokestatic",238);}
case 238:{f.Locals[10]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(f.Locals[10]);f.Pc=242;continue;}
case 242:{f.Pc=f.Pop().Reference==null?248:245;continue;}
case 245:{f.Push(f.Locals[10]);f.Pc=247;continue;}
case 247:{return JStep.Return(f.Pop());}
case 248:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=251;continue;}
case 251:{f.Push(JValue.R(rt.String("[LOG]: Faulty Entry in Preferred Art for Card %s - Please check!%n")));f.Pc=254;continue;}
case 254:{f.Push(JValue.I(1));f.Pc=255;continue;}
case 255:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=258;continue;}
case 258:{f.StackOp("dup");f.Pc=259;continue;}
case 259:{f.Push(JValue.I(0));f.Pc=260;continue;}
case 260:{f.Push(f.Locals[3]);f.Pc=261;continue;}
case 261:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/io/PrintStream","printf","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;","invokevirtual",265);}
case 265:{f.StackOp("pop");f.Pc=266;continue;}
case 266:{f.Push(f.Locals[7]);f.Pc=268;continue;}
case 268:{f.Push(JValue.R(rt.String("N.A.")));f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",273);}
case 273:{f.Pc=f.Pop().Int==0?285:276;continue;}
case 276:{f.Push(f.Locals[5]);f.Pc=278;continue;}
case 278:{f.Push(JValue.I(-1));f.Pc=279;continue;}
case 279:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?285:282;continue;}
case 282:{f.Push(JValue.I(1));f.Pc=283;continue;}
case 283:{f.Locals[5]=f.Pop();f.Pc=285;continue;}
case 285:{if(!rt.EnsureInitialized(f,"forge/card/CardDb$CardRequest"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardDb$CardRequest")));f.Pc=288;continue;}
case 288:{f.StackOp("dup");f.Pc=289;continue;}
case 289:{f.Push(f.Locals[3]);f.Pc=290;continue;}
case 290:{f.Push(f.Locals[6]);f.Pc=292;continue;}
case 292:{f.Push(f.Locals[5]);f.Pc=294;continue;}
case 294:{f.Push(f.Locals[4]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[7]);f.Pc=298;continue;}
case 298:{f.Push(f.Locals[8]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/card/CardDb$CardRequest","<init>","(Ljava/lang/String;Ljava/lang/String;IZLjava/lang/String;Ljava/util/Map;)V","invokespecial",303);}
case 303:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M351(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[0]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?14:12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("{")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int!=0?70:24;continue;}
case 24:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",31);}
case 31:{f.Locals[1]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("#")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",38);}
case 38:{return rt.Call(f,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",41);}
case 41:{return rt.Call(f,"forge/card/ColorSet","toString","()Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Locals[2]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("markedColors")));f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("")));f.Pc=51;continue;}
case 51:{f.Push(JValue.I(1));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.NewArray("Ljava/lang/CharSequence;",f.Pop().Int)));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/String","join","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;","invokestatic",62);}
case 62:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",67);}
case 67:{f.StackOp("pop");f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{return JStep.Return(f.Pop());}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(JValue.I(1));f.Pc=72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",76);}
case 76:{f.Push(JValue.I(1));f.Pc=77;continue;}
case 77:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",81);}
case 81:{f.Locals[0]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("\t")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",88);}
case 88:{return rt.Call(f,"java/util/Arrays","stream","([Ljava/lang/Object;)Ljava/util/stream/Stream;","invokestatic",91);}
case 91:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:351:91:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",96);}
case 96:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",101);}
case 101:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:351:101:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",106);}
case 106:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",111);}
case 111:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:351:111:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",116);}
case 116:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:351:116:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",121);}
case 121:{return rt.Call(f,"java/util/stream/Collectors","toMap","(Ljava/util/function/Function;Ljava/util/function/Function;)Ljava/util/stream/Collector;","invokestatic",124);}
case 124:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",129);}
case 129:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=132;continue;}
case 132:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M352(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?12:6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=9;continue;}
case 9:{f.Pc=15;continue;}
case 12:{f.Push(JValue.R(rt.String("true")));f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M353(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M354(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Int<=0?9:5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{f.Pc=10;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M355(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("=")));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(2));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M356(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{return rt.DynamicCall(f,"forge/card/CardDb$CardRequest:356:18:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",23);}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
