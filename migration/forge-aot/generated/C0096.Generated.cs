// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C96{
internal static JClass Build(){var c=new JClass("forge/deck/DeckManaBase","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("REAL_COLOR_COPIES","I",true,JValue.I(5),null));
c.Add(new JField("REAL_COLOR_BASICS","I",true,JValue.I(4),null));
c.Add(new JField("MAX_LANDS_WHEN_REFILLING","I",true,JValue.I(25),null));
c.Add(new JField("MIN_BASICS_KEPT","I",true,JValue.I(5),null));
c.Add(new JField("ADD_MANA","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JMethod(1500,"forge/deck/DeckManaBase","<init>","()V",2,1,1,new JHandler[]{},M1500));
c.Add(new JMethod(1501,"forge/deck/DeckManaBase","landColors","(Lforge/deck/CardPool;)B",9,8,3,new JHandler[]{},M1501));
c.Add(new JMethod(1502,"forge/deck/DeckManaBase","availableColors","(Lforge/deck/CardPool;)B",9,7,3,new JHandler[]{},M1502));
c.Add(new JMethod(1503,"forge/deck/DeckManaBase","uncastable","(Lforge/deck/CardPool;)Ljava/util/List;",9,6,2,new JHandler[]{},M1503));
c.Add(new JMethod(1504,"forge/deck/DeckManaBase","fix","(Lforge/deck/Deck;)I",9,11,5,new JHandler[]{},M1504));
c.Add(new JMethod(1505,"forge/deck/DeckManaBase","isUnplayableByAi","(Lforge/card/CardRules;)Z",8,1,1,new JHandler[]{},M1505));
c.Add(new JMethod(1506,"forge/deck/DeckManaBase","isFetchLand","(Lforge/card/CardRules;)Z",10,2,2,new JHandler[]{},M1506));
c.Add(new JMethod(1507,"forge/deck/DeckManaBase","hasLandOfType","(Lforge/deck/CardPool;Ljava/lang/String;)Z",10,5,2,new JHandler[]{},M1507));
c.Add(new JMethod(1508,"forge/deck/DeckManaBase","producedColors","(Lforge/card/CardRules;)B",8,6,3,new JHandler[]{},M1508));
c.Add(new JMethod(1509,"forge/deck/DeckManaBase","addBasicsFor","(Lforge/deck/CardPool;I)I",10,6,3,new JHandler[]{},M1509));
c.Add(new JMethod(1510,"forge/deck/DeckManaBase","mostPlentifulBasic","(Lforge/deck/CardPool;I)Lforge/item/PaperCard;",10,8,3,new JHandler[]{},M1510));
c.Add(new JMethod(1511,"forge/deck/DeckManaBase","basicLand","(Lforge/deck/CardPool;I)Lforge/item/PaperCard;",10,6,3,new JHandler[]{},M1511));
c.Add(new JMethod(1512,"forge/deck/DeckManaBase","refillCard","(Lforge/deck/CardPool;)Lforge/item/PaperCard;",10,10,2,new JHandler[]{},M1512));
c.Add(new JMethod(1513,"forge/deck/DeckManaBase","shortestBasic","(Lforge/deck/CardPool;B)Lforge/item/PaperCard;",10,11,6,new JHandler[]{},M1513));
c.Add(new JMethod(1514,"forge/deck/DeckManaBase","lambda$refillCard$0","(Lforge/item/PaperCard;)Z",4106,1,1,new JHandler[]{},M1514));
c.Add(new JMethod(1515,"forge/deck/DeckManaBase","<clinit>","()V",8,0,1,new JHandler[]{},M1515));
}

internal static JStep M1500(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1501(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?116:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",48);}
case 48:{f.Locals[5]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/card/CardType","isLand","()Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int!=0?64:61;continue;}
case 61:{f.Pc=15;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/deck/DeckManaBase","isFetchLand","(Lforge/card/CardRules;)Z","invokestatic",69);}
case 69:{f.Pc=f.Pop().Int==0?92:72;continue;}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[4]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",80);}
case 80:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",88);}
case 88:{f.StackOp("pop");f.Pc=89;continue;}
case 89:{f.Pc=113;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[5]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/card/CardRules","getDeckbuildingColors","()Lforge/card/ColorSet;","invokevirtual",98);}
case 98:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",101);}
case 101:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=102;continue;}
case 102:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=103;continue;}
case 103:{f.Locals[1]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[5]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/deck/DeckManaBase","producedColors","(Lforge/card/CardRules;)B","invokestatic",110);}
case 110:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=111;continue;}
case 111:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=112;continue;}
case 112:{f.Locals[1]=f.Pop();f.Pc=113;continue;}
case 113:{f.Pc=15;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",122);}
case 122:{f.Locals[3]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[3]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",129);}
case 129:{f.Pc=f.Pop().Int==0?233:132;continue;}
case 132:{f.Push(f.Locals[3]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",138);}
case 138:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=141;continue;}
case 141:{f.Locals[4]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(f.Locals[4]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",148);}
case 148:{return rt.Call(f,"forge/card/CardRules","getDeckbuildingColors","()Lforge/card/ColorSet;","invokevirtual",151);}
case 151:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",154);}
case 154:{f.Locals[5]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(JValue.I(0));f.Pc=157;continue;}
case 157:{f.Locals[6]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[6]);f.Pc=161;continue;}
case 161:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"));f.Pc=164;continue;}
case 164:{return rt.Call(f,"com/google/common/collect/ImmutableList","size","()I","invokevirtual",167);}
case 167:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?230:170;continue;}
case 170:{f.Push(JValue.I(1));f.Pc=171;continue;}
case 171:{f.Push(f.Locals[6]);f.Pc=173;continue;}
case 173:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=174;continue;}
case 174:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=175;continue;}
case 175:{f.Locals[7]=f.Pop();f.Pc=177;continue;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[7]);f.Pc=180;continue;}
case 180:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=181;continue;}
case 181:{f.Pc=f.Pop().Int!=0?224:184;continue;}
case 184:{f.Push(f.Locals[5]);f.Pc=186;continue;}
case 186:{f.Pc=f.Pop().Int==0?200:189;continue;}
case 189:{f.Push(f.Locals[5]);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[7]);f.Pc=193;continue;}
case 193:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=194;continue;}
case 194:{f.Pc=f.Pop().Int!=0?200:197;continue;}
case 197:{f.Pc=224;continue;}
case 200:{f.Push(f.Locals[0]);f.Pc=201;continue;}
case 201:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"));f.Pc=204;continue;}
case 204:{f.Push(f.Locals[6]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"com/google/common/collect/ImmutableList","get","(I)Ljava/lang/Object;","invokevirtual",209);}
case 209:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/deck/DeckManaBase","hasLandOfType","(Lforge/deck/CardPool;Ljava/lang/String;)Z","invokestatic",215);}
case 215:{f.Pc=f.Pop().Int==0?224:218;continue;}
case 218:{f.Push(f.Locals[1]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[7]);f.Pc=221;continue;}
case 221:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=222;continue;}
case 222:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=223;continue;}
case 223:{f.Locals[1]=f.Pop();f.Pc=224;continue;}
case 224:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=227;continue;}
case 227:{f.Pc=159;continue;}
case 230:{f.Pc=123;continue;}
case 233:{f.Push(f.Locals[1]);f.Pc=234;continue;}
case 234:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1502(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckManaBase","landColors","(Lforge/deck/CardPool;)B","invokestatic",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int==0?114:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?111:27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",45);}
case 45:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",51);}
case 51:{f.Locals[5]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",58);}
case 58:{return rt.Call(f,"forge/card/CardType","isLand","()Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int==0?67:64;continue;}
case 64:{f.Pc=18;continue;}
case 67:{f.Push(f.Locals[5]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/deck/DeckManaBase","producedColors","(Lforge/card/CardRules;)B","invokestatic",72);}
case 72:{f.Locals[6]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{f.Push(JValue.I(-1));f.Pc=78;continue;}
case 78:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ixor",a,b));f.Pc=79;continue;}
case 79:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=80;continue;}
case 80:{f.Pc=f.Pop().Int==0?108:83;continue;}
case 83:{f.Push(f.Locals[5]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/deck/DeckManaBase","isUnplayableByAi","(Lforge/card/CardRules;)Z","invokestatic",88);}
case 88:{f.Pc=f.Pop().Int!=0?108:91;continue;}
case 91:{f.Push(f.Locals[5]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/card/CardRules","canCastWithAvailable","(B)Z","invokevirtual",97);}
case 97:{f.Pc=f.Pop().Int==0?108:100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[6]);f.Pc=103;continue;}
case 103:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=104;continue;}
case 104:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=105;continue;}
case 105:{f.Locals[1]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(JValue.I(1));f.Pc=107;continue;}
case 107:{f.Locals[2]=f.Pop();f.Pc=108;continue;}
case 108:{f.Pc=18;continue;}
case 111:{f.Pc=7;continue;}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1503(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckManaBase","availableColors","(Lforge/deck/CardPool;)B","invokestatic",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?101:27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",45);}
case 45:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",51);}
case 51:{f.Locals[5]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",58);}
case 58:{return rt.Call(f,"forge/card/CardType","isLand","()Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?98:64;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/deck/DeckManaBase","isUnplayableByAi","(Lforge/card/CardRules;)Z","invokestatic",69);}
case 69:{f.Pc=f.Pop().Int!=0?81:72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/card/CardRules","canCastWithAvailable","(B)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int!=0?98:81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",89);}
case 89:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",97);}
case 97:{f.StackOp("pop");f.Pc=98;continue;}
case 98:{f.Pc=18;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1504(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?212:21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/deck/DeckManaBase","availableColors","(Lforge/deck/CardPool;)B","invokestatic",25);}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(JValue.I(5));f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=30;continue;}
case 30:{f.Locals[6]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/deck/DeckManaBase","uncastable","(Lforge/deck/CardPool;)Ljava/util/List;","invokestatic",36);}
case 36:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",41);}
case 41:{f.Locals[7]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[7]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",50);}
case 50:{f.Pc=f.Pop().Int==0?140:53;continue;}
case 53:{f.Push(f.Locals[7]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",60);}
case 60:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=63;continue;}
case 63:{f.Locals[8]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[8]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",70);}
case 70:{return rt.Call(f,"forge/deck/DeckManaBase","isUnplayableByAi","(Lforge/card/CardRules;)Z","invokestatic",73);}
case 73:{f.Pc=f.Pop().Int==0?79:76;continue;}
case 76:{f.Pc=43;continue;}
case 79:{f.Push(f.Locals[8]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",84);}
case 84:{return rt.Call(f,"forge/card/CardRules","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",87);}
case 87:{return rt.Call(f,"forge/card/mana/ManaCost","getColorProfile","()B","invokevirtual",90);}
case 90:{f.Push(f.Locals[5]);f.Pc=92;continue;}
case 92:{f.Push(JValue.I(-1));f.Pc=93;continue;}
case 93:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ixor",a,b));f.Pc=94;continue;}
case 94:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=95;continue;}
case 95:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=96;continue;}
case 96:{f.Locals[9]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{f.Locals[10]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[10]);f.Pc=103;continue;}
case 103:{f.Push(JValue.I(5));f.Pc=104;continue;}
case 104:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?137:107;continue;}
case 107:{f.Push(f.Locals[9]);f.Pc=109;continue;}
case 109:{f.Push(JValue.I(1));f.Pc=110;continue;}
case 110:{f.Push(f.Locals[10]);f.Pc=112;continue;}
case 112:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=113;continue;}
case 113:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=114;continue;}
case 114:{f.Pc=f.Pop().Int==0?131:117;continue;}
case 117:{f.Push(f.Locals[6]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[10]);f.Pc=121;continue;}
case 121:{f.StackOp("dup2");f.Pc=122;continue;}
case 122:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[8]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/deck/CardPool","count","(Lforge/item/InventoryItem;)I","invokevirtual",129);}
case 129:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=130;continue;}
case 130:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=131;continue;}
case 131:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=134;continue;}
case 134:{f.Pc=101;continue;}
case 137:{f.Pc=43;continue;}
case 140:{f.Push(JValue.I(-1));f.Pc=141;continue;}
case 141:{f.Locals[7]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(JValue.I(0));f.Pc=144;continue;}
case 144:{f.Locals[8]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[8]);f.Pc=148;continue;}
case 148:{f.Push(JValue.I(5));f.Pc=149;continue;}
case 149:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?189:152;continue;}
case 152:{f.Push(f.Locals[6]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[8]);f.Pc=156;continue;}
case 156:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=157;continue;}
case 157:{f.Push(JValue.I(5));f.Pc=158;continue;}
case 158:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?183:161;continue;}
case 161:{f.Push(f.Locals[7]);f.Pc=163;continue;}
case 163:{f.Pc=f.Pop().Int<0?179:166;continue;}
case 166:{f.Push(f.Locals[6]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[8]);f.Pc=170;continue;}
case 170:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=171;continue;}
case 171:{f.Push(f.Locals[6]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[7]);f.Pc=175;continue;}
case 175:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=176;continue;}
case 176:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?183:179;continue;}
case 179:{f.Push(f.Locals[8]);f.Pc=181;continue;}
case 181:{f.Locals[7]=f.Pop();f.Pc=183;continue;}
case 183:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=186;continue;}
case 186:{f.Pc=146;continue;}
case 189:{f.Push(f.Locals[7]);f.Pc=191;continue;}
case 191:{f.Pc=f.Pop().Int>=0?197:194;continue;}
case 194:{f.Pc=212;continue;}
case 197:{f.Push(f.Locals[3]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[1]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[7]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/deck/DeckManaBase","addBasicsFor","(Lforge/deck/CardPool;I)I","invokestatic",204);}
case 204:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=205;continue;}
case 205:{f.Locals[3]=f.Pop();f.Pc=206;continue;}
case 206:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=209;continue;}
case 209:{f.Pc=15;continue;}
case 212:{f.Push(f.Locals[1]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/deck/DeckManaBase","uncastable","(Lforge/deck/CardPool;)Ljava/util/List;","invokestatic",216);}
case 216:{f.Locals[4]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[4]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",225);}
case 225:{f.Pc=f.Pop().Int!=0?302:228;continue;}
case 228:{f.Push(f.Locals[0]);f.Pc=229;continue;}
case 229:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/deck/Deck","getOrCreate","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",235);}
case 235:{f.Locals[5]=f.Pop();f.Pc=237;continue;}
case 237:{f.Push(f.Locals[4]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",244);}
case 244:{f.Locals[6]=f.Pop();f.Pc=246;continue;}
case 246:{f.Push(f.Locals[6]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",253);}
case 253:{f.Pc=f.Pop().Int==0?302:256;continue;}
case 256:{f.Push(f.Locals[6]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",263);}
case 263:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=266;continue;}
case 266:{f.Locals[7]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[1]);f.Pc=269;continue;}
case 269:{f.Push(f.Locals[7]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/deck/CardPool","count","(Lforge/item/InventoryItem;)I","invokevirtual",274);}
case 274:{f.Locals[8]=f.Pop();f.Pc=276;continue;}
case 276:{f.Push(f.Locals[1]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[7]);f.Pc=279;continue;}
case 279:{f.Push(f.Locals[8]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/deck/CardPool","remove","(Lforge/item/InventoryItem;I)Z","invokevirtual",284);}
case 284:{f.StackOp("pop");f.Pc=285;continue;}
case 285:{f.Push(f.Locals[5]);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[7]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[8]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",294);}
case 294:{f.Push(f.Locals[3]);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[8]);f.Pc=297;continue;}
case 297:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=298;continue;}
case 298:{f.Locals[3]=f.Pop();f.Pc=299;continue;}
case 299:{f.Pc=246;continue;}
case 302:{f.Push(f.Locals[2]);f.Pc=303;continue;}
case 303:{f.Push(f.Locals[1]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",307);}
case 307:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=308;continue;}
case 308:{f.Locals[5]=f.Pop();f.Pc=310;continue;}
case 310:{f.Push(f.Locals[5]);f.Pc=312;continue;}
case 312:{f.Pc=f.Pop().Int<=0?344:315;continue;}
case 315:{f.Push(f.Locals[1]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/deck/DeckManaBase","refillCard","(Lforge/deck/CardPool;)Lforge/item/PaperCard;","invokestatic",319);}
case 319:{f.Locals[6]=f.Pop();f.Pc=321;continue;}
case 321:{f.Push(f.Locals[6]);f.Pc=323;continue;}
case 323:{f.Pc=f.Pop().Reference!=null?329:326;continue;}
case 326:{f.Pc=344;continue;}
case 329:{f.Push(f.Locals[1]);f.Pc=330;continue;}
case 330:{f.Push(f.Locals[6]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;)V","invokevirtual",335);}
case 335:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=338;continue;}
case 338:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(-1)));f.Pc=341;continue;}
case 341:{f.Pc=310;continue;}
case 344:{f.Push(f.Locals[3]);f.Pc=345;continue;}
case 345:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1505(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardAiHints","isRemovedFromAiDecks","(Lforge/card/CardRules;)Z","invokestatic",4);}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1506(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference==null?27:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("Search your library")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?27:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Pc=28;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1507(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",11);}
case 11:{f.Pc=f.Pop().Int==0?74:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",20);}
case 20:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=23;continue;}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",36);}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/card/CardType","isLand","()Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?71:49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/deck/DeckManaBase","isFetchLand","(Lforge/card/CardRules;)Z","invokestatic",54);}
case 54:{f.Pc=f.Pop().Int!=0?71:57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",62);}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?71:69;continue;}
case 69:{f.Push(JValue.I(1));f.Pc=70;continue;}
case 70:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 71:{f.Pc=5;continue;}
case 74:{f.Push(JValue.I(0));f.Pc=75;continue;}
case 75:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1508(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference==null?23:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("Add ")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int!=0?25:23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/deck/DeckManaBase","ADD_MANA","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckManaBase","ADD_MANA","Ljava/util/regex/Pattern;"));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",34);}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int==0?159:42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",47);}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"java/util/Locale","ROOT","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ROOT","Ljava/util/Locale;"));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","toLowerCase","(Ljava/util/Locale;)Ljava/lang/String;","invokevirtual",57);}
case 57:{f.Push(JValue.R(rt.String("any color")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int!=0?81:65;continue;}
case 65:{f.Push(f.Locals[4]);f.Pc=67;continue;}
case 67:{if(!rt.StaticReady(f,"java/util/Locale","ROOT","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ROOT","Ljava/util/Locale;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/String","toLowerCase","(Ljava/util/Locale;)Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Push(JValue.R(rt.String("any one color")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int==0?84:81;continue;}
case 81:{f.Push(JValue.I(31));f.Pc=83;continue;}
case 83:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 84:{f.Push(JValue.I(0));f.Pc=85;continue;}
case 85:{f.Locals[5]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=92;continue;}
case 92:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=93;continue;}
case 93:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?140:96;continue;}
case 96:{f.Push(f.Locals[4]);f.Pc=98;continue;}
case 98:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=101;continue;}
case 101:{f.Push(f.Locals[5]);f.Pc=103;continue;}
case 103:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",107);}
case 107:{if(!rt.StaticReady(f,"java/util/Locale","ROOT","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ROOT","Ljava/util/Locale;"));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/String","toUpperCase","(Ljava/util/Locale;)Ljava/lang/String;","invokevirtual",113);}
case 113:{return rt.DynamicCall(f,"forge/deck/DeckManaBase:1508:113:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",118);}
case 118:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int==0?134:124;continue;}
case 124:{f.Push(f.Locals[2]);f.Pc=125;continue;}
case 125:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=128;continue;}
case 128:{f.Push(f.Locals[5]);f.Pc=130;continue;}
case 130:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=131;continue;}
case 131:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=132;continue;}
case 132:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=133;continue;}
case 133:{f.Locals[2]=f.Pop();f.Pc=134;continue;}
case 134:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=137;continue;}
case 137:{f.Pc=87;continue;}
case 140:{f.Push(f.Locals[4]);f.Pc=142;continue;}
case 142:{f.Push(JValue.R(rt.String("{C}")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int==0?156:150;continue;}
case 150:{f.Push(f.Locals[2]);f.Pc=151;continue;}
case 151:{f.Push(JValue.I(32));f.Pc=153;continue;}
case 153:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=154;continue;}
case 154:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=155;continue;}
case 155:{f.Locals[2]=f.Pop();f.Pc=156;continue;}
case 156:{f.Pc=35;continue;}
case 159:{f.Push(f.Locals[2]);f.Pc=160;continue;}
case 160:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1509(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/DeckManaBase","basicLand","(Lforge/deck/CardPool;I)Lforge/item/PaperCard;","invokestatic",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference!=null?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Locals[4]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(4));f.Pc=20;continue;}
case 20:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?61:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/deck/DeckManaBase","mostPlentifulBasic","(Lforge/deck/CardPool;I)Lforge/item/PaperCard;","invokestatic",28);}
case 28:{f.Locals[5]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Reference!=null?38:35;continue;}
case 35:{f.Pc=61;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/deck/CardPool","remove","(Lforge/item/InventoryItem;I)Z","invokevirtual",45);}
case 45:{f.StackOp("pop");f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",52);}
case 52:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(2)));f.Pc=55;continue;}
case 55:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=58;continue;}
case 58:{f.Pc=17;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1510(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.I(5));f.Pc=3;continue;}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",8);}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?121:20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",45);}
case 45:{f.Locals[6]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[6]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",52);}
case 52:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int==0?10:58;continue;}
case 58:{f.Push(f.Locals[6]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",63);}
case 63:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"com/google/common/collect/ImmutableList","get","(I)Ljava/lang/Object;","invokevirtual",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int==0?82:79;continue;}
case 79:{f.Pc=10;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[5]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/deck/CardPool","countByName","(Lforge/item/PaperCard;)I","invokevirtual",96);}
case 96:{f.Locals[7]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[7]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[3]);f.Pc=101;continue;}
case 101:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?118:104;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{f.Locals[3]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[5]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",114);}
case 114:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=117;continue;}
case 117:{f.Locals[2]=f.Pop();f.Pc=118;continue;}
case 118:{f.Pc=10;continue;}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1511(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/ImmutableList","get","(I)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?70:25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",49);}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?67:56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{return JStep.Return(f.Pop());}
case 67:{f.Pc=16;continue;}
case 70:{f.Push(JValue.R(null));f.Pc=71;continue;}
case 71:{f.Locals[3]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",76);}
case 76:{f.Locals[4]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[4]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",85);}
case 85:{f.Pc=f.Pop().Int==0?142:88;continue;}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",95);}
case 95:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=98;continue;}
case 98:{f.Locals[5]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",107);}
case 107:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",113);}
case 113:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",116);}
case 116:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",119);}
case 119:{f.Pc=f.Pop().Int==0?139:122;continue;}
case 122:{f.Push(f.Locals[5]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",129);}
case 129:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",135);}
case 135:{f.Locals[3]=f.Pop();f.Pc=136;continue;}
case 136:{f.Pc=142;continue;}
case 139:{f.Pc=78;continue;}
case 142:{f.Push(f.Locals[3]);f.Pc=143;continue;}
case 143:{f.Pc=f.Pop().Reference!=null?150:146;continue;}
case 146:{f.Push(JValue.R(null));f.Pc=147;continue;}
case 147:{f.Pc=161;continue;}
case 150:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",153);}
case 153:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",156);}
case 156:{f.Push(f.Locals[2]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[3]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",161);}
case 161:{f.Locals[4]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[4]);f.Pc=165;continue;}
case 165:{f.Pc=f.Pop().Reference!=null?180:168;continue;}
case 168:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",171);}
case 171:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",174);}
case 174:{f.Push(f.Locals[2]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/card/CardDb","getUniqueByName","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",178);}
case 178:{f.Locals[4]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[4]);f.Pc=182;continue;}
case 182:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1512(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckManaBase","availableColors","(Lforge/deck/CardPool;)B","invokestatic",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.DynamicCall(f,"forge/deck/DeckManaBase:1512:6:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",11);}
case 11:{return rt.Call(f,"forge/deck/CardPool","countAll","(Ljava/util/function/Predicate;)I","invokevirtual",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(25));f.Pc=18;continue;}
case 18:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?33:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/deck/DeckManaBase","shortestBasic","(Lforge/deck/CardPool;B)Lforge/item/PaperCard;","invokestatic",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{f.Pc=f.Pop().Reference==null?33:31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
case 33:{f.Push(JValue.R(null));f.Pc=34;continue;}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",42);}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",51);}
case 51:{f.Pc=f.Pop().Int==0?189:54;continue;}
case 54:{f.Push(f.Locals[5]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{f.Locals[6]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[6]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",73);}
case 73:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",79);}
case 79:{f.Locals[7]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[7]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",86);}
case 86:{return rt.Call(f,"forge/card/CardType","isLand","()Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int!=0?44:92;continue;}
case 92:{f.Push(f.Locals[7]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/deck/DeckManaBase","isUnplayableByAi","(Lforge/card/CardRules;)Z","invokestatic",97);}
case 97:{f.Pc=f.Pop().Int!=0?44:100;continue;}
case 100:{f.Push(f.Locals[7]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/card/CardRules","canCastWithAvailable","(B)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int!=0?112:109;continue;}
case 109:{f.Pc=44;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[6]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",120);}
case 120:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/deck/CardPool","countByName","(Lforge/item/PaperCard;)I","invokevirtual",126);}
case 126:{f.Locals[8]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[7]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",133);}
case 133:{return rt.Call(f,"forge/card/CardType","isLegendary","()Z","invokevirtual",136);}
case 136:{f.Pc=f.Pop().Int!=0?150:139;continue;}
case 139:{f.Push(f.Locals[7]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",144);}
case 144:{return rt.Call(f,"forge/card/CardType","isPlaneswalker","()Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int==0?154:150;continue;}
case 150:{f.Push(JValue.I(1));f.Pc=151;continue;}
case 151:{f.Pc=155;continue;}
case 154:{f.Push(JValue.I(4));f.Pc=155;continue;}
case 155:{f.Locals[9]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[8]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[9]);f.Pc=161;continue;}
case 161:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?186:164;continue;}
case 164:{f.Push(f.Locals[8]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[4]);f.Pc=168;continue;}
case 168:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?186:171;continue;}
case 171:{f.Push(f.Locals[8]);f.Pc=173;continue;}
case 173:{f.Locals[4]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[6]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",182);}
case 182:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=185;continue;}
case 185:{f.Locals[3]=f.Pop();f.Pc=186;continue;}
case 186:{f.Pc=44;continue;}
case 189:{f.Push(f.Locals[3]);f.Pc=190;continue;}
case 190:{f.Pc=f.Pop().Reference==null?195:193;continue;}
case 193:{f.Push(f.Locals[3]);f.Pc=194;continue;}
case 194:{return JStep.Return(f.Pop());}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[1]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/deck/DeckManaBase","shortestBasic","(Lforge/deck/CardPool;B)Lforge/item/PaperCard;","invokestatic",200);}
case 200:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1513(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(5));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("D",f.Pop().Int)));f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(JValue.I(5));f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=7;continue;}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",12);}
case 12:{f.Locals[4]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?172:24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[5]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[5]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",49);}
case 49:{f.Locals[6]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",64);}
case 64:{f.Locals[7]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[6]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",71);}
case 71:{return rt.Call(f,"forge/card/CardType","isLand","()Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int==0?124:77;continue;}
case 77:{f.Push(f.Locals[6]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/card/CardRules","getDeckbuildingColors","()Lforge/card/ColorSet;","invokevirtual",82);}
case 82:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",85);}
case 85:{f.Locals[8]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(JValue.I(0));f.Pc=88;continue;}
case 88:{f.Locals[9]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[9]);f.Pc=92;continue;}
case 92:{f.Push(JValue.I(5));f.Pc=93;continue;}
case 93:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?121:96;continue;}
case 96:{f.Push(f.Locals[8]);f.Pc=98;continue;}
case 98:{f.Push(JValue.I(1));f.Pc=99;continue;}
case 99:{f.Push(f.Locals[9]);f.Pc=101;continue;}
case 101:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=102;continue;}
case 102:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=103;continue;}
case 103:{f.Pc=f.Pop().Int==0?115:106;continue;}
case 106:{f.Push(f.Locals[3]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[9]);f.Pc=109;continue;}
case 109:{f.StackOp("dup2");f.Pc=110;continue;}
case 110:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=111;continue;}
case 111:{f.Push(f.Locals[7]);f.Pc=113;continue;}
case 113:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=114;continue;}
case 114:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=115;continue;}
case 115:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=118;continue;}
case 118:{f.Pc=90;continue;}
case 121:{f.Pc=169;continue;}
case 124:{f.Push(f.Locals[6]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/card/CardRules","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",129);}
case 129:{f.Locals[8]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[8]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/card/mana/ManaCost","getColorShardCounts","()[I","invokevirtual",136);}
case 136:{f.Locals[9]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(JValue.I(0));f.Pc=139;continue;}
case 139:{f.Locals[10]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[10]);f.Pc=143;continue;}
case 143:{f.Push(JValue.I(5));f.Pc=144;continue;}
case 144:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?169:147;continue;}
case 147:{f.Push(f.Locals[2]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[10]);f.Pc=150;continue;}
case 150:{f.StackOp("dup2");f.Pc=151;continue;}
case 151:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=152;continue;}
case 152:{f.Push(f.Locals[9]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[10]);f.Pc=156;continue;}
case 156:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=157;continue;}
case 157:{f.Push(f.Locals[7]);f.Pc=159;continue;}
case 159:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=160;continue;}
case 160:{f.Push(JNumbers.Unary("i2d",f.Pop()));f.Pc=161;continue;}
case 161:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"dadd",a,b));f.Pc=162;continue;}
case 162:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=163;continue;}
case 163:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=166;continue;}
case 166:{f.Pc=141;continue;}
case 169:{f.Pc=14;continue;}
case 172:{f.Push(JValue.I(-1));f.Pc=173;continue;}
case 173:{f.Locals[4]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(JValue.D(-1.0d));f.Pc=178;continue;}
case 178:{f.Locals[5]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(JValue.I(0));f.Pc=181;continue;}
case 181:{f.Locals[7]=f.Pop();f.Pc=183;continue;}
case 183:{f.Push(f.Locals[7]);f.Pc=185;continue;}
case 185:{f.Push(JValue.I(5));f.Pc=186;continue;}
case 186:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?246:189;continue;}
case 189:{f.Push(f.Locals[1]);f.Pc=190;continue;}
case 190:{f.Push(JValue.I(1));f.Pc=191;continue;}
case 191:{f.Push(f.Locals[7]);f.Pc=193;continue;}
case 193:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=194;continue;}
case 194:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=195;continue;}
case 195:{f.Pc=f.Pop().Int==0?240:198;continue;}
case 198:{f.Push(f.Locals[2]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[7]);f.Pc=201;continue;}
case 201:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=202;continue;}
case 202:{f.Push(JValue.D(0));f.Pc=203;continue;}
case 203:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"dcmpg",a,b));f.Pc=204;continue;}
case 204:{f.Pc=f.Pop().Int>0?210:207;continue;}
case 207:{f.Pc=240;continue;}
case 210:{f.Push(f.Locals[2]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[7]);f.Pc=213;continue;}
case 213:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=214;continue;}
case 214:{f.Push(f.Locals[3]);f.Pc=215;continue;}
case 215:{f.Push(f.Locals[7]);f.Pc=217;continue;}
case 217:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=218;continue;}
case 218:{f.Push(JValue.I(1));f.Pc=219;continue;}
case 219:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=220;continue;}
case 220:{f.Push(JNumbers.Unary("i2d",f.Pop()));f.Pc=221;continue;}
case 221:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ddiv",a,b));f.Pc=222;continue;}
case 222:{f.Locals[8]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(f.Locals[8]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[5]);f.Pc=228;continue;}
case 228:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"dcmpl",a,b));f.Pc=229;continue;}
case 229:{f.Pc=f.Pop().Int<=0?240:232;continue;}
case 232:{f.Push(f.Locals[8]);f.Pc=234;continue;}
case 234:{f.Locals[5]=f.Pop();f.Pc=236;continue;}
case 236:{f.Push(f.Locals[7]);f.Pc=238;continue;}
case 238:{f.Locals[4]=f.Pop();f.Pc=240;continue;}
case 240:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=243;continue;}
case 243:{f.Pc=183;continue;}
case 246:{f.Push(f.Locals[4]);f.Pc=248;continue;}
case 248:{f.Pc=f.Pop().Int>=0?255:251;continue;}
case 251:{f.Push(JValue.R(null));f.Pc=252;continue;}
case 252:{f.Pc=261;continue;}
case 255:{f.Push(f.Locals[0]);f.Pc=256;continue;}
case 256:{f.Push(f.Locals[4]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/deck/DeckManaBase","basicLand","(Lforge/deck/CardPool;I)Lforge/item/PaperCard;","invokestatic",261);}
case 261:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1514(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/card/CardType","isLand","()Z","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1515(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Add ([^.]*)")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",6);}
case 6:{if(!rt.StaticReady(f,"forge/deck/DeckManaBase","ADD_MANA","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckManaBase","ADD_MANA","Ljava/util/regex/Pattern;",f.Pop());f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
