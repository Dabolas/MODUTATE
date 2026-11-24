// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C504{
internal static JClass Build(){var c=new JClass("forge/game/card/sticker/StickerSheet","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("KEYWORD","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"StickerSheet:"));
c.Add(new JField("PUBLIC_ZONES","Ljava/util/EnumSet;",true,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JMethod(5942,"forge/game/card/sticker/StickerSheet","<init>","()V",2,1,1,new JHandler[]{},M5942));
c.Add(new JMethod(5943,"forge/game/card/sticker/StickerSheet","isSheet","(Lforge/game/card/Card;)Z",9,1,1,new JHandler[]{},M5943));
c.Add(new JMethod(5944,"forge/game/card/sticker/StickerSheet","getAvailableStickers","(Lforge/game/player/Player;)Ljava/util/List;",9,1,3,new JHandler[]{},M5944));
c.Add(new JMethod(5945,"forge/game/card/sticker/StickerSheet","getAvailableStickers","(Lforge/game/player/Player;I)Ljava/util/List;",9,3,3,new JHandler[]{},M5945));
c.Add(new JMethod(5946,"forge/game/card/sticker/StickerSheet","hasAvailableSticker","(Lforge/game/player/Player;)Z",9,1,3,new JHandler[]{},M5946));
c.Add(new JMethod(5947,"forge/game/card/sticker/StickerSheet","collectAvailable","(Lforge/game/player/Player;ILjava/util/List;)Z",10,9,2,new JHandler[]{},M5947));
c.Add(new JMethod(5948,"forge/game/card/sticker/StickerSheet","describe","(Lforge/game/card/Card;)Ljava/lang/String;",9,7,3,new JHandler[]{},M5948));
c.Add(new JMethod(5949,"forge/game/card/sticker/StickerSheet","identity","(Lforge/game/card/sticker/Sticker;)Ljava/lang/String;",10,1,2,new JHandler[]{},M5949));
c.Add(new JMethod(5950,"forge/game/card/sticker/StickerSheet","getStickers","(Lforge/game/card/Card;)Ljava/util/List;",9,2,2,new JHandler[]{},M5950));
c.Add(new JMethod(5951,"forge/game/card/sticker/StickerSheet","readStickers","(Lforge/game/card/Card;)Ljava/util/List;",10,11,3,new JHandler[]{},M5951));
c.Add(new JMethod(5952,"forge/game/card/sticker/StickerSheet","lambda$describe$1","(Lforge/game/card/sticker/Sticker;Lforge/game/card/sticker/Sticker;)Z",4106,2,2,new JHandler[]{},M5952));
c.Add(new JMethod(5953,"forge/game/card/sticker/StickerSheet","lambda$static$0","(Lforge/game/zone/ZoneType;)Z",4106,1,1,new JHandler[]{},M5953));
c.Add(new JMethod(5954,"forge/game/card/sticker/StickerSheet","<clinit>","()V",8,0,2,new JHandler[]{},M5954));
}

internal static JStep M5942(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5943(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?20:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/card/CardTypeView","isStickers","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?20:16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{f.Pc=21;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5944(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","TICKET","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","TICKET","Lforge/game/card/CounterEnumType;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/Player","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/sticker/StickerSheet","getAvailableStickers","(Lforge/game/player/Player;I)Ljava/util/List;","invokestatic",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5945(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/sticker/StickerSheet","collectAvailable","(Lforge/game/player/Player;ILjava/util/List;)Z","invokestatic",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5946(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","TICKET","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","TICKET","Lforge/game/card/CounterEnumType;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/Player","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",8);}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/sticker/StickerSheet","collectAvailable","(Lforge/game/player/Player;ILjava/util/List;)Z","invokestatic",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5947(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/card/sticker/StickerSheet","PUBLIC_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/sticker/StickerSheet","PUBLIC_ZONES","Ljava/util/EnumSet;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",20);}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?99:32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/Card","getStickers","()Ljava/util/List;","invokevirtual",49);}
case 49:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",54);}
case 54:{f.Locals[6]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[6]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",63);}
case 63:{f.Pc=f.Pop().Int==0?96:66;continue;}
case 66:{f.Push(f.Locals[6]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",73);}
case 73:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/sticker/AppliedSticker"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=76;continue;}
case 76:{f.Locals[7]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[7]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/sticker/AppliedSticker","getSticker","()Lforge/game/card/sticker/Sticker;","invokevirtual",84);}
case 84:{return rt.Call(f,"forge/game/card/sticker/StickerSheet","identity","(Lforge/game/card/sticker/Sticker;)Ljava/lang/String;","invokestatic",87);}
case 87:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",92);}
case 92:{f.StackOp("pop");f.Pc=93;continue;}
case 93:{f.Pc=56;continue;}
case 96:{f.Pc=22;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{f.Locals[4]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","StickerSheets","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","StickerSheets","Lforge/game/zone/ZoneType;"));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",109);}
case 109:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",114);}
case 114:{f.Locals[5]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[5]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",123);}
case 123:{f.Pc=f.Pop().Int==0?230:126;continue;}
case 126:{f.Push(f.Locals[5]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",133);}
case 133:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=136;continue;}
case 136:{f.Locals[6]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[6]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/card/sticker/StickerSheet","getStickers","(Lforge/game/card/Card;)Ljava/util/List;","invokestatic",143);}
case 143:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",148);}
case 148:{f.Locals[7]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[7]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",157);}
case 157:{f.Pc=f.Pop().Int==0?227:160;continue;}
case 160:{f.Push(f.Locals[7]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",167);}
case 167:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/sticker/Sticker"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=170;continue;}
case 170:{f.Locals[8]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[3]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[8]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/card/sticker/StickerSheet","identity","(Lforge/game/card/sticker/Sticker;)Ljava/lang/String;","invokestatic",178);}
case 178:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",183);}
case 183:{f.Pc=f.Pop().Int!=0?150:186;continue;}
case 186:{f.Push(f.Locals[8]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/card/sticker/Sticker","isImplemented","()Z","invokevirtual",191);}
case 191:{f.Pc=f.Pop().Int==0?150:194;continue;}
case 194:{f.Push(f.Locals[8]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/card/sticker/Sticker","getTickets","()I","invokevirtual",199);}
case 199:{f.Push(f.Locals[1]);f.Pc=200;continue;}
case 200:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?206:203;continue;}
case 203:{f.Pc=150;continue;}
case 206:{f.Push(f.Locals[2]);f.Pc=207;continue;}
case 207:{f.Pc=f.Pop().Reference!=null?212:210;continue;}
case 210:{f.Push(JValue.I(1));f.Pc=211;continue;}
case 211:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 212:{f.Push(f.Locals[2]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[8]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",220);}
case 220:{f.StackOp("pop");f.Pc=221;continue;}
case 221:{f.Push(JValue.I(1));f.Pc=222;continue;}
case 222:{f.Locals[4]=f.Pop();f.Pc=224;continue;}
case 224:{f.Pc=150;continue;}
case 227:{f.Pc=116;continue;}
case 230:{f.Push(f.Locals[4]);f.Pc=232;continue;}
case 232:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5948(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/sticker/StickerSheet","isSheet","(Lforge/game/card/Card;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int==0?175:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/sticker/StickerSheet","getStickers","(Lforge/game/card/Card;)Ljava/util/List;","invokestatic",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?24:21;continue;}
case 21:{f.Push(JValue.R(rt.String("")));f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Reference!=null?37:31;continue;}
case 31:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",34);}
case 34:{f.Pc=46;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",41);}
case 41:{f.Push(JValue.I(2147483647));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/sticker/StickerSheet","getAvailableStickers","(Lforge/game/player/Player;I)Ljava/util/List;","invokestatic",46);}
case 46:{f.Locals[2]=f.Pop();f.Pc=47;continue;}
case 47:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=50;continue;}
case 50:{f.StackOp("dup");f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("Stickers on this sheet:")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",56);}
case 56:{f.Locals[3]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",63);}
case 63:{f.Locals[4]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[4]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",72);}
case 72:{f.Pc=f.Pop().Int==0?170:75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",82);}
case 82:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/sticker/Sticker"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=85;continue;}
case 85:{f.Locals[5]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",93);}
case 93:{f.Push(f.Locals[5]);f.Pc=95;continue;}
case 95:{return rt.DynamicCall(f,"forge/game/card/sticker/StickerSheet:5948:95:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/sticker/Sticker;)Ljava/util/function/Predicate;",100);}
case 100:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",105);}
case 105:{f.Locals[6]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("\r\n  ")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",113);}
case 113:{f.Push(f.Locals[5]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/card/sticker/Sticker","getDescription","()Ljava/lang/String;","invokevirtual",118);}
case 118:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",121);}
case 121:{f.StackOp("pop");f.Pc=122;continue;}
case 122:{f.Push(f.Locals[5]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/card/sticker/Sticker","getTickets","()I","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int<=0?155:130;continue;}
case 130:{f.Push(f.Locals[3]);f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.String(" (")));f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",136);}
case 136:{f.Push(JValue.R(rt.String("{TK}")));f.Pc=138;continue;}
case 138:{f.Push(f.Locals[5]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/card/sticker/Sticker","getTickets","()I","invokevirtual",143);}
case 143:{return rt.Call(f,"java/lang/String","repeat","(I)Ljava/lang/String;","invokevirtual",146);}
case 146:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",149);}
case 149:{f.Push(JValue.R(rt.String(")")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",154);}
case 154:{f.StackOp("pop");f.Pc=155;continue;}
case 155:{f.Push(f.Locals[6]);f.Pc=157;continue;}
case 157:{f.Pc=f.Pop().Int==0?167:160;continue;}
case 160:{f.Push(f.Locals[3]);f.Pc=161;continue;}
case 161:{f.Push(JValue.R(rt.String(" - used")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",166);}
case 166:{f.StackOp("pop");f.Pc=167;continue;}
case 167:{f.Pc=65;continue;}
case 170:{f.Push(f.Locals[3]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",174);}
case 174:{return JStep.Return(f.Pop());}
case 175:{f.Push(f.Locals[0]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/card/Card","isStickered","()Z","invokevirtual",179);}
case 179:{f.Pc=f.Pop().Int!=0?185:182;continue;}
case 182:{f.Push(JValue.R(rt.String("")));f.Pc=184;continue;}
case 184:{return JStep.Return(f.Pop());}
case 185:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=188;continue;}
case 188:{f.StackOp("dup");f.Pc=189;continue;}
case 189:{f.Push(JValue.R(rt.String("Stickers:")));f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",194);}
case 194:{f.Locals[1]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/card/Card","getStickers","()Ljava/util/List;","invokevirtual",199);}
case 199:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",204);}
case 204:{f.Locals[2]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[2]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",211);}
case 211:{f.Pc=f.Pop().Int==0?267:214;continue;}
case 214:{f.Push(f.Locals[2]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",220);}
case 220:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/sticker/AppliedSticker"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=223;continue;}
case 223:{f.Locals[3]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(f.Locals[1]);f.Pc=225;continue;}
case 225:{f.Push(JValue.R(rt.String("\r\n  ")));f.Pc=227;continue;}
case 227:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",230);}
case 230:{f.Push(f.Locals[3]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/card/sticker/AppliedSticker","getSticker","()Lforge/game/card/sticker/Sticker;","invokevirtual",234);}
case 234:{return rt.Call(f,"forge/game/card/sticker/Sticker","getDescription","()Ljava/lang/String;","invokevirtual",237);}
case 237:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",240);}
case 240:{f.Push(JValue.R(rt.String(" (")));f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",245);}
case 245:{f.Push(f.Locals[3]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/card/sticker/AppliedSticker","getKind","()Lforge/game/card/sticker/StickerKind;","invokevirtual",249);}
case 249:{return rt.Call(f,"forge/game/card/sticker/StickerKind","name","()Ljava/lang/String;","invokevirtual",252);}
case 252:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",255);}
case 255:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",258);}
case 258:{f.Push(JValue.R(rt.String(")")));f.Pc=260;continue;}
case 260:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",263);}
case 263:{f.StackOp("pop");f.Pc=264;continue;}
case 264:{f.Pc=205;continue;}
case 267:{f.Push(f.Locals[1]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",271);}
case 271:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5949(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/sticker/Sticker","getSheet","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/sticker/Sticker","getSlot","()Ljava/lang/String;","invokevirtual",11);}
case 11:{return rt.DynamicCall(f,"forge/game/card/sticker/StickerSheet:5949:11:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(ILjava/lang/String;)Ljava/lang/String;",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5950(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/sticker/StickerSheet","isSheet","(Lforge/game/card/Card;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/Card","getSheetStickers","()Ljava/util/List;","invokevirtual",15);}
case 15:{f.Locals[1]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Reference!=null?30:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/sticker/StickerSheet","readStickers","(Lforge/game/card/Card;)Ljava/util/List;","invokestatic",24);}
case 24:{f.Locals[1]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/Card","setSheetStickers","(Ljava/util/List;)V","invokevirtual",30);}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5951(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","getKeywords","()Ljava/util/List;","invokevirtual",12);}
case 12:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?169:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",43);}
case 43:{f.Locals[4]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Pc=f.Pop().Reference==null?18:50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("StickerSheet:")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int!=0?63:60;continue;}
case 60:{f.Pc=18;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("StickerSheet:")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",70);}
case 70:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Push(JValue.R(rt.String(",")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",78);}
case 78:{f.Locals[5]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=83;continue;}
case 83:{f.Locals[6]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(JValue.I(0));f.Pc=86;continue;}
case 86:{f.Locals[7]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[7]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?166:95;continue;}
case 95:{f.Push(f.Locals[5]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[7]);f.Pc=99;continue;}
case 99:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=100;continue;}
case 100:{f.Locals[8]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[8]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",107);}
case 107:{f.Locals[8]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[8]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",115);}
case 115:{f.Locals[9]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[9]);f.Pc=119;continue;}
case 119:{f.Pc=f.Pop().Reference==null?160:122;continue;}
case 122:{f.Push(f.Locals[9]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int==0?133:130;continue;}
case 130:{f.Pc=160;continue;}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[8]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[9]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/ability/AbilityFactory","getMapParams","(Ljava/lang/String;)Ljava/util/Map;","invokestatic",141);}
case 141:{return rt.Call(f,"forge/game/card/sticker/Sticker","parse","(Lforge/game/card/Card;Ljava/lang/String;Ljava/util/Map;)Lforge/game/card/sticker/Sticker;","invokestatic",144);}
case 144:{f.Locals[10]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[10]);f.Pc=148;continue;}
case 148:{f.Pc=f.Pop().Reference==null?160:151;continue;}
case 151:{f.Push(f.Locals[1]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[10]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",159);}
case 159:{f.StackOp("pop");f.Pc=160;continue;}
case 160:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=163;continue;}
case 163:{f.Pc=88;continue;}
case 166:{f.Pc=18;continue;}
case 169:{f.Push(f.Locals[1]);f.Pc=170;continue;}
case 170:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5952(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/sticker/StickerSheet","identity","(Lforge/game/card/sticker/Sticker;)Ljava/lang/String;","invokestatic",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/sticker/StickerSheet","identity","(Lforge/game/card/sticker/Sticker;)Ljava/lang/String;","invokestatic",8);}
case 8:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5953(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/zone/ZoneType","isHidden","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5954(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/zone/ZoneType","values","()[Lforge/game/zone/ZoneType;","invokestatic",3);}
case 3:{return rt.Call(f,"java/util/Arrays","stream","([Ljava/lang/Object;)Ljava/util/stream/Stream;","invokestatic",6);}
case 6:{return rt.DynamicCall(f,"forge/game/card/sticker/StickerSheet:5954:6:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",11);}
case 11:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",16);}
case 16:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",19);}
case 19:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/EnumSet","copyOf","(Ljava/util/Collection;)Ljava/util/EnumSet;","invokestatic",30);}
case 30:{if(!rt.StaticReady(f,"forge/game/card/sticker/StickerSheet","PUBLIC_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;rt.PutStatic("forge/game/card/sticker/StickerSheet","PUBLIC_ZONES","Ljava/util/EnumSet;",f.Pop());f.Pc=33;continue;}
case 33:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
