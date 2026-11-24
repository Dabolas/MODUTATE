// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C16{
internal static JClass Build(){var c=new JClass("forge/card/CardDb$Editor","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("immediateReindex","Z",false,JValue.Default("Z"),null));
c.Add(new JField("this$0","Lforge/card/CardDb;",false,JValue.Default("Lforge/card/CardDb;"),null));
c.Add(new JMethod(357,"forge/card/CardDb$Editor","<init>","(Lforge/card/CardDb;)V",1,2,2,new JHandler[]{},M357));
c.Add(new JMethod(358,"forge/card/CardDb$Editor","putCard","(Lforge/card/CardRules;)Lforge/card/CardRules;",1,2,3,new JHandler[]{},M358));
c.Add(new JMethod(359,"forge/card/CardDb$Editor","putCard","(Lforge/card/CardRules;Ljava/util/List;)Lforge/card/CardRules;",1,14,11,new JHandler[]{},M359));
c.Add(new JMethod(360,"forge/card/CardDb$Editor","isImmediateReindex","()Z",1,1,1,new JHandler[]{},M360));
c.Add(new JMethod(361,"forge/card/CardDb$Editor","setImmediateReindex","(Z)V",1,2,2,new JHandler[]{},M361));
}

internal static JStep M357(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb$Editor","this$0","Lforge/card/CardDb;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb$Editor","immediateReindex","Z",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M358(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardDb$Editor","putCard","(Lforge/card/CardRules;Ljava/util/List;)Lforge/card/CardRules;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M359(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$Editor","this$0","Lforge/card/CardDb;"));f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","rulesByPrimaryName","Ljava/util/Map;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",18);}
case 18:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=21;continue;}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Reference==null?49:28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",33);}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?49:40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/card/CardRules","reinitializeFromRules","(Lforge/card/CardRules;)V","invokevirtual",46);}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{return JStep.Return(f.Pop());}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$Editor","this$0","Lforge/card/CardDb;"));f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","rulesByPrimaryName","Ljava/util/Map;"));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{f.Locals[4]=f.Pop();f.Pc=68;continue;}
case 68:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=71;continue;}
case 71:{f.StackOp("dup");f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",75);}
case 75:{f.Locals[5]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(JValue.R(null));f.Pc=78;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?91:82;continue;}
case 82:{f.Push(f.Locals[2]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",88);}
case 88:{f.Pc=f.Pop().Int==0?224:91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$Editor","this$0","Lforge/card/CardDb;"));f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/card/CardEdition$Collection","getOrderedEditions","()Ljava/lang/Iterable;","invokevirtual",101);}
case 101:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",106);}
case 106:{f.Locals[6]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[6]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",115);}
case 115:{f.Pc=f.Pop().Int==0?221:118;continue;}
case 118:{f.Push(f.Locals[6]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",125);}
case 125:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=128;continue;}
case 128:{f.Locals[7]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(JValue.I(1));f.Pc=131;continue;}
case 131:{f.Locals[8]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[7]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[3]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/card/CardEdition","getCardInSet","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",139);}
case 139:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",144);}
case 144:{f.Locals[9]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[9]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",153);}
case 153:{f.Pc=f.Pop().Int==0?218:156;continue;}
case 156:{f.Push(f.Locals[9]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",163);}
case 163:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=166;continue;}
case 166:{f.Locals[10]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[5]);f.Pc=170;continue;}
case 170:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard")));f.Pc=173;continue;}
case 173:{f.StackOp("dup");f.Pc=174;continue;}
case 174:{f.Push(f.Locals[1]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[7]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",180);}
case 180:{f.Push(f.Locals[10]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","rarity","()Lforge/card/CardRarity;","invokevirtual",185);}
case 185:{f.Push(f.Locals[8]);f.Pc=187;continue;}
case 187:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=190;continue;}
case 190:{f.Push(JValue.I(0));f.Pc=191;continue;}
case 191:{f.Push(f.Locals[10]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","collectorNumber","()Ljava/lang/String;","invokevirtual",196);}
case 196:{f.Push(f.Locals[10]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","artistName","()Ljava/lang/String;","invokevirtual",201);}
case 201:{f.Push(f.Locals[10]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","getFunctionalVariantName","()Ljava/lang/String;","invokevirtual",206);}
case 206:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;IZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",209);}
case 209:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",214);}
case 214:{f.StackOp("pop");f.Pc=215;continue;}
case 215:{f.Pc=146;continue;}
case 218:{f.Pc=108;continue;}
case 221:{f.Pc=406;continue;}
case 224:{f.Push(JValue.R(null));f.Pc=225;continue;}
case 225:{f.Locals[6]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(JValue.I(0));f.Pc=228;continue;}
case 228:{f.Locals[7]=f.Pop();f.Pc=230;continue;}
case 230:{f.Push(f.Locals[2]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",236);}
case 236:{f.Locals[8]=f.Pop();f.Pc=238;continue;}
case 238:{f.Push(f.Locals[8]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",245);}
case 245:{f.Pc=f.Pop().Int==0?406:248;continue;}
case 248:{f.Push(f.Locals[8]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",255);}
case 255:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=258;continue;}
case 258:{f.Locals[9]=f.Pop();f.Pc=260;continue;}
case 260:{f.Push(f.Locals[9]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getKey","()Ljava/lang/Object;","invokevirtual",265);}
case 265:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[6]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",273);}
case 273:{f.Pc=f.Pop().Int!=0?289:276;continue;}
case 276:{f.Push(JValue.I(1));f.Pc=277;continue;}
case 277:{f.Locals[7]=f.Pop();f.Pc=279;continue;}
case 279:{f.Push(f.Locals[9]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getKey","()Ljava/lang/Object;","invokevirtual",284);}
case 284:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=287;continue;}
case 287:{f.Locals[6]=f.Pop();f.Pc=289;continue;}
case 289:{f.Push(f.Locals[0]);f.Pc=290;continue;}
case 290:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$Editor","this$0","Lforge/card/CardDb;"));f.Pc=293;continue;}
case 293:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=296;continue;}
case 296:{f.Push(f.Locals[6]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",301);}
case 301:{f.Locals[10]=f.Pop();f.Pc=303;continue;}
case 303:{f.Push(f.Locals[10]);f.Pc=305;continue;}
case 305:{f.Pc=f.Pop().Reference!=null?311:308;continue;}
case 308:{f.Pc=238;continue;}
case 311:{f.Push(f.Locals[10]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[3]);f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/card/CardEdition","getCardInSet","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",317);}
case 317:{f.Locals[11]=f.Pop();f.Pc=319;continue;}
case 319:{f.Push(f.Locals[11]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",326);}
case 326:{f.Pc=f.Pop().Int==0?332:329;continue;}
case 329:{f.Pc=238;continue;}
case 332:{f.Push(f.Locals[7]);f.Pc=334;continue;}
case 334:{f.Push(JValue.I(1));f.Pc=335;continue;}
case 335:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=336;continue;}
case 336:{f.Push(JValue.I(0));f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",340);}
case 340:{f.Locals[12]=f.Pop();f.Pc=342;continue;}
case 342:{f.Push(f.Locals[11]);f.Pc=344;continue;}
case 344:{f.Push(f.Locals[12]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",351);}
case 351:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=354;continue;}
case 354:{f.Locals[13]=f.Pop();f.Pc=356;continue;}
case 356:{f.Push(f.Locals[5]);f.Pc=358;continue;}
case 358:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard")));f.Pc=361;continue;}
case 361:{f.StackOp("dup");f.Pc=362;continue;}
case 362:{f.Push(f.Locals[1]);f.Pc=363;continue;}
case 363:{f.Push(f.Locals[6]);f.Pc=365;continue;}
case 365:{f.Push(f.Locals[9]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getValue","()Ljava/lang/Object;","invokevirtual",370);}
case 370:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRarity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=373;continue;}
case 373:{f.Push(f.Locals[7]);f.Pc=375;continue;}
case 375:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=378;continue;}
case 378:{f.Push(JValue.I(0));f.Pc=379;continue;}
case 379:{f.Push(f.Locals[13]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","collectorNumber","()Ljava/lang/String;","invokevirtual",384);}
case 384:{f.Push(f.Locals[13]);f.Pc=386;continue;}
case 386:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","artistName","()Ljava/lang/String;","invokevirtual",389);}
case 389:{f.Push(f.Locals[13]);f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","getFunctionalVariantName","()Ljava/lang/String;","invokevirtual",394);}
case 394:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;IZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",397);}
case 397:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",402);}
case 402:{f.StackOp("pop");f.Pc=403;continue;}
case 403:{f.Pc=238;continue;}
case 406:{f.Push(f.Locals[5]);f.Pc=408;continue;}
case 408:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",413);}
case 413:{f.Pc=f.Pop().Int==0?437:416;continue;}
case 416:{f.Push(f.Locals[5]);f.Pc=418;continue;}
case 418:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard")));f.Pc=421;continue;}
case 421:{f.StackOp("dup");f.Pc=422;continue;}
case 422:{f.Push(f.Locals[1]);f.Pc=423;continue;}
case 423:{f.Push(JValue.R(rt.String("???")));f.Pc=425;continue;}
case 425:{if(!rt.StaticReady(f,"forge/card/CardRarity","Special","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Special","Lforge/card/CardRarity;"));f.Pc=428;continue;}
case 428:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;)V","invokespecial",431);}
case 431:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",436);}
case 436:{f.StackOp("pop");f.Pc=437;continue;}
case 437:{f.Push(f.Locals[5]);f.Pc=439;continue;}
case 439:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",444);}
case 444:{f.Locals[6]=f.Pop();f.Pc=446;continue;}
case 446:{f.Push(f.Locals[6]);f.Pc=448;continue;}
case 448:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",453);}
case 453:{f.Pc=f.Pop().Int==0?480:456;continue;}
case 456:{f.Push(f.Locals[6]);f.Pc=458;continue;}
case 458:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",463);}
case 463:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=466;continue;}
case 466:{f.Locals[7]=f.Pop();f.Pc=468;continue;}
case 468:{f.Push(f.Locals[0]);f.Pc=469;continue;}
case 469:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$Editor","this$0","Lforge/card/CardDb;"));f.Pc=472;continue;}
case 472:{f.Push(f.Locals[7]);f.Pc=474;continue;}
case 474:{return rt.Call(f,"forge/card/CardDb","addCard","(Lforge/item/PaperCard;)V","invokevirtual",477);}
case 477:{f.Pc=446;continue;}
case 480:{f.Push(f.Locals[0]);f.Pc=481;continue;}
case 481:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$Editor","immediateReindex","Z"));f.Pc=484;continue;}
case 484:{f.Pc=f.Pop().Int==0?494:487;continue;}
case 487:{f.Push(f.Locals[0]);f.Pc=488;continue;}
case 488:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$Editor","this$0","Lforge/card/CardDb;"));f.Pc=491;continue;}
case 491:{return rt.Call(f,"forge/card/CardDb","reIndex","()V","invokevirtual",494);}
case 494:{f.Push(f.Locals[4]);f.Pc=496;continue;}
case 496:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M360(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$Editor","immediateReindex","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M361(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb$Editor","immediateReindex","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
