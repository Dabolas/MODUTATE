// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C82{
internal static JClass Build(){var c=new JClass("forge/deck/CommanderOptions","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(1309,"forge/deck/CommanderOptions","<init>","()V",2,1,1,new JHandler[]{},M1309));
c.Add(new JMethod(1310,"forge/deck/CommanderOptions","withCommanders","(Lforge/deck/Deck;Ljava/util/List;)Lforge/deck/Deck;",9,7,3,new JHandler[]{},M1310));
c.Add(new JMethod(1311,"forge/deck/CommanderOptions","getOptions","(Lforge/deck/Deck;Lforge/deck/DeckFormat;)Ljava/util/List;",9,8,5,new JHandler[]{},M1311));
c.Add(new JMethod(1312,"forge/deck/CommanderOptions","getPartnerOptions","(Lforge/deck/Deck;Lforge/item/PaperCard;Lforge/deck/DeckFormat;)Ljava/util/List;",9,9,4,new JHandler[]{},M1312));
c.Add(new JMethod(1313,"forge/deck/CommanderOptions","canLeadAlone","(Lforge/deck/Deck;Lforge/item/PaperCard;Lforge/deck/DeckFormat;)Z",9,4,3,new JHandler[]{},M1313));
c.Add(new JMethod(1314,"forge/deck/CommanderOptions","isCandidate","(Lforge/deck/Deck;Lforge/item/PaperCard;Lforge/deck/DeckFormat;)Z",10,4,3,new JHandler[]{},M1314));
c.Add(new JMethod(1315,"forge/deck/CommanderOptions","distinctByName","(Lforge/deck/CardPool;)Ljava/util/Map;",10,4,3,new JHandler[]{},M1315));
}

internal static JStep M1309(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1310(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/Deck"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/Deck")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/Deck","<init>","(Lforge/deck/Deck;)V","invokespecial",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/deck/Deck","getCommanders","()Ljava/util/List;","invokevirtual",18);}
case 18:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?56:35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[5]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;)V","invokevirtual",53);}
case 53:{f.Pc=25;continue;}
case 56:{if(!rt.EnsureInitialized(f,"forge/deck/CardPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CardPool")));f.Pc=59;continue;}
case 59:{f.StackOp("dup");f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/deck/CardPool","<init>","()V","invokespecial",63);}
case 63:{f.Locals[4]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",71);}
case 71:{f.Locals[5]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[5]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",80);}
case 80:{f.Pc=f.Pop().Int==0?112:83;continue;}
case 83:{f.Push(f.Locals[5]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{f.Locals[6]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[3]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[6]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/deck/CardPool","remove","(Lforge/item/InventoryItem;)Z","invokevirtual",101);}
case 101:{f.StackOp("pop");f.Pc=102;continue;}
case 102:{f.Push(f.Locals[4]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[6]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;)V","invokevirtual",109);}
case 109:{f.Pc=73;continue;}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=116;continue;}
case 116:{f.Push(f.Locals[4]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/deck/Deck","putSection","(Lforge/deck/DeckSection;Lforge/deck/CardPool;)V","invokevirtual",121);}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1311(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/deck/Deck","getCommanders","()Ljava/util/List;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int!=0?40:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{if(!rt.EnsureInitialized(f,"forge/deck/CommanderOptions$Option"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CommanderOptions$Option")));f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{if(!rt.StaticReady(f,"forge/deck/CommanderOptions$Kind","DEFAULT","Lforge/deck/CommanderOptions$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/CommanderOptions$Kind","DEFAULT","Lforge/deck/CommanderOptions$Kind;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/deck/CommanderOptions$Option","<init>","(Ljava/util/List;Lforge/deck/CommanderOptions$Kind;)V","invokespecial",34);}
case 34:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",46);}
case 46:{f.Push(JValue.I(1));f.Pc=47;continue;}
case 47:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?141:50;continue;}
case 50:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=53;continue;}
case 53:{f.StackOp("dup");f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",58);}
case 58:{f.Locals[4]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{return rt.DynamicCall(f,"forge/deck/CommanderOptions:1311:62:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",67);}
case 67:{return rt.Call(f,"java/util/Comparator","comparing","(Ljava/util/function/Function;)Ljava/util/Comparator;","invokestatic",70);}
case 70:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",75);}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",82);}
case 82:{f.Locals[5]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",91);}
case 91:{f.Pc=f.Pop().Int==0?141:94;continue;}
case 94:{f.Push(f.Locals[5]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",101);}
case 101:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=104;continue;}
case 104:{f.Locals[6]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[6]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/deck/CommanderOptions","isCandidate","(Lforge/deck/Deck;Lforge/item/PaperCard;Lforge/deck/DeckFormat;)Z","invokestatic",113);}
case 113:{f.Pc=f.Pop().Int==0?138:116;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{if(!rt.EnsureInitialized(f,"forge/deck/CommanderOptions$Option"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CommanderOptions$Option")));f.Pc=120;continue;}
case 120:{f.StackOp("dup");f.Pc=121;continue;}
case 121:{f.Push(f.Locals[6]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/Collections","singletonList","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",126);}
case 126:{if(!rt.StaticReady(f,"forge/deck/CommanderOptions$Kind","OTHER","Lforge/deck/CommanderOptions$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/CommanderOptions$Kind","OTHER","Lforge/deck/CommanderOptions$Kind;"));f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/deck/CommanderOptions$Option","<init>","(Ljava/util/List;Lforge/deck/CommanderOptions$Kind;)V","invokespecial",132);}
case 132:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",137);}
case 137:{f.StackOp("pop");f.Pc=138;continue;}
case 138:{f.Pc=84;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",145);}
case 145:{return rt.Call(f,"forge/deck/CommanderOptions","distinctByName","(Lforge/deck/CardPool;)Ljava/util/Map;","invokestatic",148);}
case 148:{f.Locals[4]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[3]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",156);}
case 156:{f.Locals[5]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[5]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",165);}
case 165:{f.Pc=f.Pop().Int==0?199:168;continue;}
case 168:{f.Push(f.Locals[5]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",175);}
case 175:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=178;continue;}
case 178:{f.Locals[6]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[4]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[6]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",187);}
case 187:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",190);}
case 190:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",195);}
case 195:{f.StackOp("pop");f.Pc=196;continue;}
case 196:{f.Pc=158;continue;}
case 199:{f.Push(f.Locals[0]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/deck/Deck","getAltCommanders","()Ljava/util/List;","invokevirtual",203);}
case 203:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",208);}
case 208:{f.Locals[5]=f.Pop();f.Pc=210;continue;}
case 210:{f.Push(f.Locals[5]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",217);}
case 217:{f.Pc=f.Pop().Int==0?289:220;continue;}
case 220:{f.Push(f.Locals[5]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",227);}
case 227:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=230;continue;}
case 230:{f.Locals[6]=f.Pop();f.Pc=232;continue;}
case 232:{f.Push(f.Locals[4]);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[6]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",239);}
case 239:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",244);}
case 244:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=247;continue;}
case 247:{f.Locals[7]=f.Pop();f.Pc=249;continue;}
case 249:{f.Push(f.Locals[7]);f.Pc=251;continue;}
case 251:{f.Pc=f.Pop().Reference==null?286:254;continue;}
case 254:{f.Push(f.Locals[0]);f.Pc=255;continue;}
case 255:{f.Push(f.Locals[7]);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[1]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/deck/CommanderOptions","isCandidate","(Lforge/deck/Deck;Lforge/item/PaperCard;Lforge/deck/DeckFormat;)Z","invokestatic",261);}
case 261:{f.Pc=f.Pop().Int==0?286:264;continue;}
case 264:{f.Push(f.Locals[2]);f.Pc=265;continue;}
case 265:{if(!rt.EnsureInitialized(f,"forge/deck/CommanderOptions$Option"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CommanderOptions$Option")));f.Pc=268;continue;}
case 268:{f.StackOp("dup");f.Pc=269;continue;}
case 269:{f.Push(f.Locals[7]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/util/Collections","singletonList","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",274);}
case 274:{if(!rt.StaticReady(f,"forge/deck/CommanderOptions$Kind","SUGGESTED","Lforge/deck/CommanderOptions$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/CommanderOptions$Kind","SUGGESTED","Lforge/deck/CommanderOptions$Kind;"));f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/deck/CommanderOptions$Option","<init>","(Ljava/util/List;Lforge/deck/CommanderOptions$Kind;)V","invokespecial",280);}
case 280:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",285);}
case 285:{f.StackOp("pop");f.Pc=286;continue;}
case 286:{f.Pc=210;continue;}
case 289:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=292;continue;}
case 292:{f.StackOp("dup");f.Pc=293;continue;}
case 293:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",296);}
case 296:{f.Locals[5]=f.Pop();f.Pc=298;continue;}
case 298:{f.Push(f.Locals[4]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",305);}
case 305:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",310);}
case 310:{f.Locals[6]=f.Pop();f.Pc=312;continue;}
case 312:{f.Push(f.Locals[6]);f.Pc=314;continue;}
case 314:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",319);}
case 319:{f.Pc=f.Pop().Int==0?357:322;continue;}
case 322:{f.Push(f.Locals[6]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",329);}
case 329:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=332;continue;}
case 332:{f.Locals[7]=f.Pop();f.Pc=334;continue;}
case 334:{f.Push(f.Locals[0]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[7]);f.Pc=337;continue;}
case 337:{f.Push(f.Locals[1]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"forge/deck/CommanderOptions","isCandidate","(Lforge/deck/Deck;Lforge/item/PaperCard;Lforge/deck/DeckFormat;)Z","invokestatic",341);}
case 341:{f.Pc=f.Pop().Int==0?354:344;continue;}
case 344:{f.Push(f.Locals[5]);f.Pc=346;continue;}
case 346:{f.Push(f.Locals[7]);f.Pc=348;continue;}
case 348:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",353);}
case 353:{f.StackOp("pop");f.Pc=354;continue;}
case 354:{f.Pc=312;continue;}
case 357:{f.Push(f.Locals[5]);f.Pc=359;continue;}
case 359:{return rt.DynamicCall(f,"forge/deck/CommanderOptions:1311:359:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",364);}
case 364:{return rt.Call(f,"java/util/Comparator","comparing","(Ljava/util/function/Function;)Ljava/util/Comparator;","invokestatic",367);}
case 367:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",372);}
case 372:{f.Push(f.Locals[5]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",379);}
case 379:{f.Locals[6]=f.Pop();f.Pc=381;continue;}
case 381:{f.Push(f.Locals[6]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",388);}
case 388:{f.Pc=f.Pop().Int==0?428:391;continue;}
case 391:{f.Push(f.Locals[6]);f.Pc=393;continue;}
case 393:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",398);}
case 398:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=401;continue;}
case 401:{f.Locals[7]=f.Pop();f.Pc=403;continue;}
case 403:{f.Push(f.Locals[2]);f.Pc=404;continue;}
case 404:{if(!rt.EnsureInitialized(f,"forge/deck/CommanderOptions$Option"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CommanderOptions$Option")));f.Pc=407;continue;}
case 407:{f.StackOp("dup");f.Pc=408;continue;}
case 408:{f.Push(f.Locals[7]);f.Pc=410;continue;}
case 410:{return rt.Call(f,"java/util/Collections","singletonList","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",413);}
case 413:{if(!rt.StaticReady(f,"forge/deck/CommanderOptions$Kind","OTHER","Lforge/deck/CommanderOptions$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/CommanderOptions$Kind","OTHER","Lforge/deck/CommanderOptions$Kind;"));f.Pc=416;continue;}
case 416:{return rt.Call(f,"forge/deck/CommanderOptions$Option","<init>","(Ljava/util/List;Lforge/deck/CommanderOptions$Kind;)V","invokespecial",419);}
case 419:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",424);}
case 424:{f.StackOp("pop");f.Pc=425;continue;}
case 425:{f.Pc=381;continue;}
case 428:{f.Push(f.Locals[2]);f.Pc=429;continue;}
case 429:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1312(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",12);}
case 12:{f.Locals[4]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/CardRules","canBePartnerCommander","()Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int!=0?24:22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Collections","singletonList","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",29);}
case 29:{return rt.Call(f,"forge/deck/CommanderOptions","withCommanders","(Lforge/deck/Deck;Ljava/util/List;)Lforge/deck/Deck;","invokestatic",32);}
case 32:{f.Locals[5]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[5]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/deck/CommanderOptions","distinctByName","(Lforge/deck/CardPool;)Ljava/util/Map;","invokestatic",42);}
case 42:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",47);}
case 47:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",52);}
case 52:{f.Locals[6]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",61);}
case 61:{f.Pc=f.Pop().Int==0?135:64;continue;}
case 64:{f.Push(f.Locals[6]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",71);}
case 71:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=74;continue;}
case 74:{f.Locals[7]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[7]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",83);}
case 83:{return rt.Call(f,"forge/card/CardRules","canBePartnerCommanders","(Lforge/card/CardRules;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int!=0?92:89;continue;}
case 89:{f.Pc=54;continue;}
case 92:{f.Push(JValue.I(2));f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.NewArray("Lforge/item/PaperCard;",f.Pop().Int)));f.Pc=96;continue;}
case 96:{f.StackOp("dup");f.Pc=97;continue;}
case 97:{f.Push(JValue.I(0));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=100;continue;}
case 100:{f.StackOp("dup");f.Pc=101;continue;}
case 101:{f.Push(JValue.I(1));f.Pc=102;continue;}
case 102:{f.Push(f.Locals[7]);f.Pc=104;continue;}
case 104:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",108);}
case 108:{f.Locals[8]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[8]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/deck/CommanderOptions","withCommanders","(Lforge/deck/Deck;Ljava/util/List;)Lforge/deck/Deck;","invokestatic",117);}
case 117:{return rt.Call(f,"forge/deck/DeckFormat","getCommanderConformanceProblem","(Lforge/deck/Deck;)Ljava/lang/String;","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Reference!=null?132:123;continue;}
case 123:{f.Push(f.Locals[3]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[7]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",131);}
case 131:{f.StackOp("pop");f.Pc=132;continue;}
case 132:{f.Pc=54;continue;}
case 135:{f.Push(f.Locals[3]);f.Pc=136;continue;}
case 136:{return rt.DynamicCall(f,"forge/deck/CommanderOptions:1312:136:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",141);}
case 141:{return rt.Call(f,"java/util/Comparator","comparing","(Ljava/util/function/Function;)Ljava/util/Comparator;","invokestatic",144);}
case 144:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",149);}
case 149:{f.Push(f.Locals[3]);f.Pc=150;continue;}
case 150:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1313(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/deck/DeckFormat","isLegalCommander","(Lforge/card/CardRules;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?20:13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardRules","canBeBackground","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?22:20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Collections","singletonList","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",28);}
case 28:{return rt.Call(f,"forge/deck/CommanderOptions","withCommanders","(Lforge/deck/Deck;Ljava/util/List;)Lforge/deck/Deck;","invokestatic",31);}
case 31:{return rt.Call(f,"forge/deck/DeckFormat","getCommanderConformanceProblem","(Lforge/deck/Deck;)Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Reference!=null?41:37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{f.Pc=42;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1314(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/deck/CommanderOptions","canLeadAlone","(Lforge/deck/Deck;Lforge/item/PaperCard;Lforge/deck/DeckFormat;)Z","invokestatic",6);}
case 6:{f.Pc=f.Pop().Int==0?11:9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/deck/DeckFormat","isLegalCommander","(Lforge/card/CardRules;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?49:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/card/CardRules","canBeBackground","()Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int!=0?49:31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/deck/CommanderOptions","getPartnerOptions","(Lforge/deck/Deck;Lforge/item/PaperCard;Lforge/deck/DeckFormat;)Ljava/util/List;","invokestatic",37);}
case 37:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int!=0?49:45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{f.Pc=50;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1315(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/LinkedHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/LinkedHashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/LinkedHashMap","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?66:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",45);}
case 45:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Map","putIfAbsent","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{f.Pc=13;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
