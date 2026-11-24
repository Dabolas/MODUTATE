// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C489{
internal static JClass Build(){var c=new JClass("forge/game/card/TokenCreateTable","com/google/common/collect/ForwardingTable",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("dataMap","Lcom/google/common/collect/Table;",false,JValue.Default("Lcom/google/common/collect/Table;"),null));
c.Add(new JMethod(5822,"forge/game/card/TokenCreateTable","<init>","()V",1,1,2,new JHandler[]{},M5822));
c.Add(new JMethod(5823,"forge/game/card/TokenCreateTable","delegate","()Lcom/google/common/collect/Table;",4,1,1,new JHandler[]{},M5823));
c.Add(new JMethod(5824,"forge/game/card/TokenCreateTable","add","(Lforge/game/player/Player;Lforge/game/card/Card;I)I",1,6,4,new JHandler[]{},M5824));
c.Add(new JMethod(5825,"forge/game/card/TokenCreateTable","getFilterAmount","(Ljava/lang/String;Ljava/lang/String;Lforge/game/CardTraitBase;)I",1,12,5,new JHandler[]{},M5825));
c.Add(new JMethod(5826,"forge/game/card/TokenCreateTable","delegate","()Ljava/lang/Object;",4164,1,1,new JHandler[]{},M5826));
}

internal static JStep M5822(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/ForwardingTable","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/TokenCreateTable","dataMap","Lcom/google/common/collect/Table;",value);f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5823(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/TokenCreateTable","dataMap","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5824(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/TokenCreateTable","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",22);}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=28;continue;}
case 28:{f.Locals[5]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",38);}
case 38:{return rt.Call(f,"forge/game/card/TokenCreateTable","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[5]);f.Pc=44;continue;}
case 44:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5825(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{f.Locals[6]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{f.Locals[7]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Reference!=null?72:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference!=null?72:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/TokenCreateTable","values","()Ljava/util/Collection;","invokevirtual",27);}
case 27:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",32);}
case 32:{f.Locals[8]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[8]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",41);}
case 41:{f.Pc=f.Pop().Int==0?69:44;continue;}
case 44:{f.Push(f.Locals[8]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[9]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[9]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",63);}
case 63:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=64;continue;}
case 64:{f.Locals[5]=f.Pop();f.Pc=66;continue;}
case 66:{f.Pc=34;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Pc=f.Pop().Reference==null?136:76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String(",")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",82);}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",87);}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/GameObjectPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",93);}
case 93:{f.Locals[8]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/card/TokenCreateTable","rowKeySet","()Ljava/util/Set;","invokevirtual",99);}
case 99:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",104);}
case 104:{f.Push(f.Locals[8]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",111);}
case 111:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",114);}
case 114:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",119);}
case 119:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=122;continue;}
case 122:{f.Locals[7]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[7]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",131);}
case 131:{f.Pc=f.Pop().Int==0?136:134;continue;}
case 134:{f.Push(JValue.I(0));f.Pc=135;continue;}
case 135:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 136:{f.Push(f.Locals[2]);f.Pc=137;continue;}
case 137:{f.Pc=f.Pop().Reference==null?170:140;continue;}
case 140:{f.Push(f.Locals[0]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/card/TokenCreateTable","columnKeySet","()Ljava/util/Set;","invokevirtual",144);}
case 144:{f.Push(f.Locals[2]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[4]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",150);}
case 150:{f.Push(f.Locals[4]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[3]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/card/CardLists","getValidCardsAsList","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/List;","invokestatic",156);}
case 156:{f.Locals[6]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[6]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",165);}
case 165:{f.Pc=f.Pop().Int==0?170:168;continue;}
case 168:{f.Push(JValue.I(0));f.Pc=169;continue;}
case 169:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 170:{f.Push(f.Locals[7]);f.Pc=172;continue;}
case 172:{f.Pc=f.Pop().Reference!=null?276:175;continue;}
case 175:{f.Push(f.Locals[0]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/card/TokenCreateTable","columnMap","()Ljava/util/Map;","invokevirtual",179);}
case 179:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",184);}
case 184:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",189);}
case 189:{f.Locals[8]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(f.Locals[8]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",198);}
case 198:{f.Pc=f.Pop().Int==0?273:201;continue;}
case 201:{f.Push(f.Locals[8]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",208);}
case 208:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=211;continue;}
case 211:{f.Locals[9]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[9]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",220);}
case 220:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",228);}
case 228:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",233);}
case 233:{f.Locals[10]=f.Pop();f.Pc=235;continue;}
case 235:{f.Push(f.Locals[10]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",242);}
case 242:{f.Pc=f.Pop().Int==0?270:245;continue;}
case 245:{f.Push(f.Locals[10]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",252);}
case 252:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=255;continue;}
case 255:{f.Locals[11]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[5]);f.Pc=259;continue;}
case 259:{f.Push(f.Locals[11]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",264);}
case 264:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=265;continue;}
case 265:{f.Locals[5]=f.Pop();f.Pc=267;continue;}
case 267:{f.Pc=235;continue;}
case 270:{f.Pc=191;continue;}
case 273:{f.Push(f.Locals[5]);f.Pc=275;continue;}
case 275:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 276:{f.Push(f.Locals[6]);f.Pc=278;continue;}
case 278:{f.Pc=f.Pop().Reference!=null?382:281;continue;}
case 281:{f.Push(f.Locals[0]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/card/TokenCreateTable","rowMap","()Ljava/util/Map;","invokevirtual",285);}
case 285:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",290);}
case 290:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",295);}
case 295:{f.Locals[8]=f.Pop();f.Pc=297;continue;}
case 297:{f.Push(f.Locals[8]);f.Pc=299;continue;}
case 299:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",304);}
case 304:{f.Pc=f.Pop().Int==0?379:307;continue;}
case 307:{f.Push(f.Locals[8]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",314);}
case 314:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=317;continue;}
case 317:{f.Locals[9]=f.Pop();f.Pc=319;continue;}
case 319:{f.Push(f.Locals[9]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",326);}
case 326:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=329;continue;}
case 329:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",334);}
case 334:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",339);}
case 339:{f.Locals[10]=f.Pop();f.Pc=341;continue;}
case 341:{f.Push(f.Locals[10]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",348);}
case 348:{f.Pc=f.Pop().Int==0?376:351;continue;}
case 351:{f.Push(f.Locals[10]);f.Pc=353;continue;}
case 353:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",358);}
case 358:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=361;continue;}
case 361:{f.Locals[11]=f.Pop();f.Pc=363;continue;}
case 363:{f.Push(f.Locals[5]);f.Pc=365;continue;}
case 365:{f.Push(f.Locals[11]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",370);}
case 370:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=371;continue;}
case 371:{f.Locals[5]=f.Pop();f.Pc=373;continue;}
case 373:{f.Pc=341;continue;}
case 376:{f.Pc=297;continue;}
case 379:{f.Push(f.Locals[5]);f.Pc=381;continue;}
case 381:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 382:{f.Push(f.Locals[0]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"forge/game/card/TokenCreateTable","cellSet","()Ljava/util/Set;","invokevirtual",386);}
case 386:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",391);}
case 391:{f.Locals[8]=f.Pop();f.Pc=393;continue;}
case 393:{f.Push(f.Locals[8]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",400);}
case 400:{f.Pc=f.Pop().Int==0?476:403;continue;}
case 403:{f.Push(f.Locals[8]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",410);}
case 410:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Table$Cell"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=413;continue;}
case 413:{f.Locals[9]=f.Pop();f.Pc=415;continue;}
case 415:{f.Push(f.Locals[7]);f.Pc=417;continue;}
case 417:{f.Push(f.Locals[9]);f.Pc=419;continue;}
case 419:{return rt.Call(f,"com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;","invokeinterface",424);}
case 424:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",429);}
case 429:{f.Pc=f.Pop().Int!=0?435:432;continue;}
case 432:{f.Pc=393;continue;}
case 435:{f.Push(f.Locals[6]);f.Pc=437;continue;}
case 437:{f.Push(f.Locals[9]);f.Pc=439;continue;}
case 439:{return rt.Call(f,"com/google/common/collect/Table$Cell","getColumnKey","()Ljava/lang/Object;","invokeinterface",444);}
case 444:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",449);}
case 449:{f.Pc=f.Pop().Int!=0?455:452;continue;}
case 452:{f.Pc=393;continue;}
case 455:{f.Push(f.Locals[5]);f.Pc=457;continue;}
case 457:{f.Push(f.Locals[9]);f.Pc=459;continue;}
case 459:{return rt.Call(f,"com/google/common/collect/Table$Cell","getValue","()Ljava/lang/Object;","invokeinterface",464);}
case 464:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=467;continue;}
case 467:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",470);}
case 470:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=471;continue;}
case 471:{f.Locals[5]=f.Pop();f.Pc=473;continue;}
case 473:{f.Pc=393;continue;}
case 476:{f.Push(f.Locals[5]);f.Pc=478;continue;}
case 478:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5826(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/TokenCreateTable","delegate","()Lcom/google/common/collect/Table;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
