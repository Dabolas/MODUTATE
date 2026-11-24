// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C501{
internal static JClass Build(){var c=new JClass("forge/game/card/sticker/Sticker","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("VOWELS","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"AEIOUY"));
c.Add(new JField("sheet","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("slot","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("kind","Lforge/game/card/sticker/StickerKind;",false,JValue.Default("Lforge/game/card/sticker/StickerKind;"),null));
c.Add(new JField("tickets","I",false,JValue.Default("I"),null));
c.Add(new JField("word","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("text","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("abilitySVar","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("keywords","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("triggers","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("statics","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("power","I",false,JValue.Default("I"),null));
c.Add(new JField("toughness","I",false,JValue.Default("I"),null));
c.Add(new JMethod(5915,"forge/game/card/sticker/Sticker","parse","(Lforge/game/card/Card;Ljava/lang/String;Ljava/util/Map;)Lforge/game/card/sticker/Sticker;",9,4,6,new JHandler[]{},M5915));
c.Add(new JMethod(5916,"forge/game/card/sticker/Sticker","<init>","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/card/sticker/StickerKind;Ljava/util/Map;)V",2,5,4,new JHandler[]{},M5916));
c.Add(new JMethod(5917,"forge/game/card/sticker/Sticker","intParam","(Ljava/util/Map;Ljava/lang/String;I)I",10,5,2,new JHandler[]{new JHandler(17,24,25,"java/lang/NumberFormatException")},M5917));
c.Add(new JMethod(5918,"forge/game/card/sticker/Sticker","getSheet","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M5918));
c.Add(new JMethod(5919,"forge/game/card/sticker/Sticker","getSlot","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5919));
c.Add(new JMethod(5920,"forge/game/card/sticker/Sticker","getKind","()Lforge/game/card/sticker/StickerKind;",1,1,1,new JHandler[]{},M5920));
c.Add(new JMethod(5921,"forge/game/card/sticker/Sticker","getTickets","()I",1,1,1,new JHandler[]{},M5921));
c.Add(new JMethod(5922,"forge/game/card/sticker/Sticker","getWord","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5922));
c.Add(new JMethod(5923,"forge/game/card/sticker/Sticker","getLetters","()Ljava/lang/String;",1,1,3,new JHandler[]{},M5923));
c.Add(new JMethod(5924,"forge/game/card/sticker/Sticker","getUniqueVowelCount","()I",1,7,2,new JHandler[]{},M5924));
c.Add(new JMethod(5925,"forge/game/card/sticker/Sticker","getText","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5925));
c.Add(new JMethod(5926,"forge/game/card/sticker/Sticker","getAbilitySVar","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5926));
c.Add(new JMethod(5927,"forge/game/card/sticker/Sticker","getKeywords","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5927));
c.Add(new JMethod(5928,"forge/game/card/sticker/Sticker","getTriggers","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5928));
c.Add(new JMethod(5929,"forge/game/card/sticker/Sticker","getStatics","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5929));
c.Add(new JMethod(5930,"forge/game/card/sticker/Sticker","getPower","()I",1,1,1,new JHandler[]{},M5930));
c.Add(new JMethod(5931,"forge/game/card/sticker/Sticker","getToughness","()I",1,1,1,new JHandler[]{},M5931));
c.Add(new JMethod(5932,"forge/game/card/sticker/Sticker","isImplemented","()Z",1,1,2,new JHandler[]{},M5932));
c.Add(new JMethod(5933,"forge/game/card/sticker/Sticker","getDescription","()Ljava/lang/String;",1,1,3,new JHandler[]{},M5933));
c.Add(new JMethod(5934,"forge/game/card/sticker/Sticker","toString","()Ljava/lang/String;",1,1,3,new JHandler[]{},M5934));
}

internal static JStep M5915(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Kind")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/sticker/StickerKind","smartValueOf","(Ljava/lang/String;)Lforge/game/card/sticker/StickerKind;","invokestatic",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Reference!=null?21:19;continue;}
case 19:{f.Push(JValue.R(null));f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
case 21:{if(!rt.EnsureInitialized(f,"forge/game/card/sticker/Sticker"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/sticker/Sticker")));f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/sticker/Sticker","<init>","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/card/sticker/StickerKind;Ljava/util/Map;)V","invokespecial",32);}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5916(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/sticker/Sticker","sheet","Lforge/game/card/Card;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/sticker/Sticker","slot","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/sticker/Sticker","kind","Lforge/game/card/sticker/StickerKind;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Tickets")));f.Pc=24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/sticker/Sticker","intParam","(Ljava/util/Map;Ljava/lang/String;I)I","invokestatic",28);}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/sticker/Sticker","tickets","I",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("Word")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/sticker/Sticker","word","Ljava/lang/String;",value);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("Text")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/sticker/Sticker","text","Ljava/lang/String;",value);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("Ability")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",73);}
case 73:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=76;continue;}
case 76:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/sticker/Sticker","abilitySVar","Ljava/lang/String;",value);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[4]);f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("Keywords")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",89);}
case 89:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=92;continue;}
case 92:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/sticker/Sticker","keywords","Ljava/lang/String;",value);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[4]);f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("Triggers")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",105);}
case 105:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=108;continue;}
case 108:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/sticker/Sticker","triggers","Ljava/lang/String;",value);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[4]);f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("Statics")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",121);}
case 121:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=124;continue;}
case 124:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/sticker/Sticker","statics","Ljava/lang/String;",value);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[4]);f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("Power")));f.Pc=132;continue;}
case 132:{f.Push(JValue.I(0));f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/card/sticker/Sticker","intParam","(Ljava/util/Map;Ljava/lang/String;I)I","invokestatic",136);}
case 136:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/sticker/Sticker","power","I",value);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[4]);f.Pc=142;continue;}
case 142:{f.Push(JValue.R(rt.String("Toughness")));f.Pc=144;continue;}
case 144:{f.Push(JValue.I(0));f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/card/sticker/Sticker","intParam","(Ljava/util/Map;Ljava/lang/String;I)I","invokestatic",148);}
case 148:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/sticker/Sticker","toughness","I",value);f.Pc=151;continue;}
case 151:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5917(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference!=null?17:15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",24);}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5918(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","sheet","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5919(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","slot","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5920(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","kind","Lforge/game/card/sticker/StickerKind;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5921(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","tickets","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5922(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","word","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5923(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","word","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?12:7;continue;}
case 7:{f.Push(JValue.R(rt.String("")));f.Pc=9;continue;}
case 9:{f.Pc=23;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","word","Ljava/lang/String;"));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("[^A-Za-z]")));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",23);}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5924(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/sticker/Sticker","getLetters","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/lang/String","toUpperCase","()Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("AEIOUY")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","toCharArray","()[C","invokevirtual",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=18;continue;}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?54:30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=34;continue;}
case 34:{f.Locals[6]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[6]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int<0?48:45;continue;}
case 45:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=48;continue;}
case 48:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=51;continue;}
case 51:{f.Pc=23;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5925(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","text","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5926(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","abilitySVar","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5927(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","keywords","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5928(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","triggers","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5929(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","statics","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5930(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","power","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5931(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","toughness","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5932(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","kind","Lforge/game/card/sticker/StickerKind;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/card/sticker/StickerKind","ABILITY","Lforge/game/card/sticker/StickerKind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/sticker/StickerKind","ABILITY","Lforge/game/card/sticker/StickerKind;"));f.Pc=7;continue;}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?38:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","abilitySVar","Ljava/lang/String;"));f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Reference!=null?38:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","keywords","Ljava/lang/String;"));f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Reference!=null?38:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","triggers","Ljava/lang/String;"));f.Pc=28;continue;}
case 28:{f.Pc=f.Pop().Reference!=null?38:31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","statics","Ljava/lang/String;"));f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Reference==null?42:38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{f.Pc=43;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5933(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/card/sticker/Sticker$1","$SwitchMap$forge$game$card$sticker$StickerKind","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/sticker/Sticker$1","$SwitchMap$forge$game$card$sticker$StickerKind","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","kind","Lforge/game/card/sticker/StickerKind;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/sticker/StickerKind","ordinal","()I","invokevirtual",10);}
case 10:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=11;continue;}
case 11:{switch(f.Pop().Int){case 1:f.Pc=48;break;case 2:f.Pc=55;break;case 3:f.Pc=74;break;case 4:f.Pc=93;break;default:f.Pc=40;break;}continue;}
case 40:{if(!rt.EnsureInitialized(f,"java/lang/IncompatibleClassChangeError"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IncompatibleClassChangeError")));f.Pc=43;continue;}
case 43:{f.StackOp("dup");f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/IncompatibleClassChangeError","<init>","()V","invokespecial",47);}
case 47:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","word","Ljava/lang/String;"));f.Pc=52;continue;}
case 52:{f.Pc=106;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","slot","Ljava/lang/String;"));f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("[^0-9]")));f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",66);}
case 66:{return rt.DynamicCall(f,"forge/game/card/sticker/Sticker:5933:66:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",71);}
case 71:{f.Pc=106;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","text","Ljava/lang/String;"));f.Pc=78;continue;}
case 78:{f.Pc=f.Pop().Reference==null?88:81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","text","Ljava/lang/String;"));f.Pc=85;continue;}
case 85:{f.Pc=106;continue;}
case 88:{f.Push(JValue.R(rt.String("(ability)")));f.Pc=90;continue;}
case 90:{f.Pc=106;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","power","I"));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","toughness","I"));f.Pc=101;continue;}
case 101:{return rt.DynamicCall(f,"forge/game/card/sticker/Sticker:5933:101:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(II)Ljava/lang/String;",106);}
case 106:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5934(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","sheet","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/Sticker","slot","Ljava/lang/String;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/sticker/Sticker","getDescription","()Ljava/lang/String;","invokevirtual",15);}
case 15:{return rt.DynamicCall(f,"forge/game/card/sticker/Sticker:5934:15:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",20);}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
