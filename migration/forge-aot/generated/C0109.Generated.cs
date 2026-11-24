// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C109{
internal static JClass Build(){var c=new JClass("forge/deck/generation/DeckGenPool","java/lang/Object",new string[]{"forge/deck/generation/IDeckGenPool"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cards","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("RANKER","Lforge/card/CardDb$CardArtPreference;",true,JValue.Default("Lforge/card/CardDb$CardArtPreference;"),null));
c.Add(new JMethod(1643,"forge/deck/generation/DeckGenPool","<init>","()V",1,1,3,new JHandler[]{},M1643));
c.Add(new JMethod(1644,"forge/deck/generation/DeckGenPool","<init>","(Ljava/lang/Iterable;)V",1,2,3,new JHandler[]{},M1644));
c.Add(new JMethod(1645,"forge/deck/generation/DeckGenPool","add","(Lforge/item/PaperCard;)V",1,3,3,new JHandler[]{},M1645));
c.Add(new JMethod(1646,"forge/deck/generation/DeckGenPool","isPreferred","(Lforge/item/PaperCard;Lforge/item/PaperCard;)Z",10,11,3,new JHandler[]{},M1646));
c.Add(new JMethod(1647,"forge/deck/generation/DeckGenPool","addAll","(Ljava/lang/Iterable;)V",1,4,2,new JHandler[]{},M1647));
c.Add(new JMethod(1648,"forge/deck/generation/DeckGenPool","size","()I",1,1,1,new JHandler[]{},M1648));
c.Add(new JMethod(1649,"forge/deck/generation/DeckGenPool","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;",1,2,2,new JHandler[]{},M1649));
c.Add(new JMethod(1650,"forge/deck/generation/DeckGenPool","getCard","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;",1,4,3,new JHandler[]{},M1650));
c.Add(new JMethod(1651,"forge/deck/generation/DeckGenPool","getCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperCard;",1,4,3,new JHandler[]{},M1651));
c.Add(new JMethod(1652,"forge/deck/generation/DeckGenPool","contains","(Lforge/item/PaperCard;)Z",1,2,2,new JHandler[]{},M1652));
c.Add(new JMethod(1653,"forge/deck/generation/DeckGenPool","contains","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M1653));
c.Add(new JMethod(1654,"forge/deck/generation/DeckGenPool","getAllCards","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M1654));
c.Add(new JMethod(1655,"forge/deck/generation/DeckGenPool","getAllCards","(Ljava/util/function/Predicate;)Ljava/lang/Iterable;",1,2,2,new JHandler[]{},M1655));
c.Add(new JMethod(1656,"forge/deck/generation/DeckGenPool","lambda$getCard$0","(Ljava/lang/String;)Lforge/item/PaperCard;",4098,2,2,new JHandler[]{},M1656));
c.Add(new JMethod(1657,"forge/deck/generation/DeckGenPool","<clinit>","()V",8,0,1,new JHandler[]{},M1657));
}

internal static JStep M1643(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGenPool","cards","Ljava/util/Map;",value);f.Pc=15;continue;}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1644(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGenPool","cards","Ljava/util/Map;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/deck/generation/DeckGenPool","addAll","(Ljava/lang/Iterable;)V","invokevirtual",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1645(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenPool","cards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",13);}
case 13:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=16;continue;}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Reference==null?29:21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/deck/generation/DeckGenPool","isPreferred","(Lforge/item/PaperCard;Lforge/item/PaperCard;)Z","invokestatic",26);}
case 26:{f.Pc=f.Pop().Int==0?44:29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenPool","cards","Ljava/util/Map;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",43);}
case 43:{f.StackOp("pop");f.Pc=44;continue;}
case 44:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1646(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference==null?36:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",16);}
case 16:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?38:22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",30);}
case 30:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?38:36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",46);}
case 46:{f.Locals[3]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",52);}
case 52:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",55);}
case 55:{f.Locals[4]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{f.Pc=f.Pop().Reference==null?66:61;continue;}
case 61:{f.Push(f.Locals[4]);f.Pc=63;continue;}
case 63:{f.Pc=f.Pop().Reference!=null?76:66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{f.Pc=f.Pop().Reference==null?74:70;continue;}
case 70:{f.Push(JValue.I(1));f.Pc=71;continue;}
case 71:{f.Pc=75;continue;}
case 74:{f.Push(JValue.I(0));f.Pc=75;continue;}
case 75:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/StaticData","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokevirtual",80);}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[4]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","compare","(Lforge/card/CardEdition;Lforge/card/CardEdition;)I","invokevirtual",86);}
case 86:{f.Locals[5]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[5]);f.Pc=90;continue;}
case 90:{f.Pc=f.Pop().Int==0?104:93;continue;}
case 93:{f.Push(f.Locals[5]);f.Pc=95;continue;}
case 95:{f.Pc=f.Pop().Int>=0?102:98;continue;}
case 98:{f.Push(JValue.I(1));f.Pc=99;continue;}
case 99:{f.Pc=103;continue;}
case 102:{f.Push(JValue.I(0));f.Pc=103;continue;}
case 103:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 104:{if(!rt.StaticReady(f,"forge/deck/generation/DeckGenPool","RANKER","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/generation/DeckGenPool","RANKER","Lforge/card/CardDb$CardArtPreference;"));f.Pc=107;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","getEditionRank","(Lforge/card/CardEdition;)I","invokevirtual",111);}
case 111:{if(!rt.StaticReady(f,"forge/deck/generation/DeckGenPool","RANKER","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/generation/DeckGenPool","RANKER","Lforge/card/CardDb$CardArtPreference;"));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","getEditionRank","(Lforge/card/CardEdition;)I","invokevirtual",119);}
case 119:{return rt.Call(f,"java/lang/Integer","compare","(II)I","invokestatic",122);}
case 122:{f.Locals[6]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[6]);f.Pc=126;continue;}
case 126:{f.Pc=f.Pop().Int==0?140:129;continue;}
case 129:{f.Push(f.Locals[6]);f.Pc=131;continue;}
case 131:{f.Pc=f.Pop().Int>=0?138:134;continue;}
case 134:{f.Push(JValue.I(1));f.Pc=135;continue;}
case 135:{f.Pc=139;continue;}
case 138:{f.Push(JValue.I(0));f.Pc=139;continue;}
case 139:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 140:{f.Push(f.Locals[2]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",144);}
case 144:{f.Locals[7]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[7]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/card/CardDb","isTraditionalFramePrint","(Lforge/item/PaperCard;)Z","invokevirtual",152);}
case 152:{f.Locals[8]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[7]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/card/CardDb","isTraditionalFramePrint","(Lforge/item/PaperCard;)Z","invokevirtual",160);}
case 160:{f.Locals[9]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[8]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[9]);f.Pc=166;continue;}
case 166:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?172:169;continue;}
case 169:{f.Push(f.Locals[8]);f.Pc=171;continue;}
case 171:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",176);}
case 176:{f.Push(f.Locals[1]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",180);}
case 180:{return rt.Call(f,"java/lang/String","compareToIgnoreCase","(Ljava/lang/String;)I","invokevirtual",183);}
case 183:{f.Locals[10]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[10]);f.Pc=187;continue;}
case 187:{f.Pc=f.Pop().Int==0?201:190;continue;}
case 190:{f.Push(f.Locals[10]);f.Pc=192;continue;}
case 192:{f.Pc=f.Pop().Int>=0?199:195;continue;}
case 195:{f.Push(JValue.I(1));f.Pc=196;continue;}
case 196:{f.Pc=200;continue;}
case 199:{f.Push(JValue.I(0));f.Pc=200;continue;}
case 200:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 201:{f.Push(f.Locals[0]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",205);}
case 205:{f.Push(f.Locals[1]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",209);}
case 209:{return rt.Call(f,"java/lang/String","compareToIgnoreCase","(Ljava/lang/String;)I","invokevirtual",212);}
case 212:{f.Pc=f.Pop().Int>=0?219:215;continue;}
case 215:{f.Push(JValue.I(1));f.Pc=216;continue;}
case 216:{f.Pc=220;continue;}
case 219:{f.Push(JValue.I(0));f.Pc=220;continue;}
case 220:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1647(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?34:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/deck/generation/DeckGenPool","add","(Lforge/item/PaperCard;)V","invokevirtual",31);}
case 31:{f.Pc=7;continue;}
case 34:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1648(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenPool","cards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","size","()I","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1649(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenPool","cards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1650(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCardPredicates","printedInSet","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCardPredicates","name","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",8);}
case 8:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenPool","cards","Ljava/util/Map;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",23);}
case 23:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",28);}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",34);}
case 34:{return rt.Call(f,"java/util/stream/Stream","findFirst","()Ljava/util/Optional;","invokeinterface",39);}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.DynamicCall(f,"forge/deck/generation/DeckGenPool:1650:41:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/deck/generation/DeckGenPool;Ljava/lang/String;)Ljava/util/function/Supplier;",46);}
case 46:{return rt.Call(f,"java/util/Optional","orElseGet","(Ljava/util/function/Supplier;)Ljava/lang/Object;","invokevirtual",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1651(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/deck/generation/DeckGenPool","getCard","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1652(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/deck/generation/DeckGenPool","contains","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1653(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenPool","cards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1654(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenPool","cards","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1655(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/generation/DeckGenPool","getAllCards","()Ljava/lang/Iterable;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1656(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/generation/DeckGenPool","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1657(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ORIGINAL_ART_BLACK_BORDER_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ORIGINAL_ART_BLACK_BORDER_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"));f.Pc=3;continue;}
case 3:{if(!rt.StaticReady(f,"forge/deck/generation/DeckGenPool","RANKER","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;rt.PutStatic("forge/deck/generation/DeckGenPool","RANKER","Lforge/card/CardDb$CardArtPreference;",f.Pop());f.Pc=6;continue;}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
