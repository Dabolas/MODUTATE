// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C397{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/SeekEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3714,"forge/game/ability/effects/SeekEffect","<init>","()V",1,1,1,new JHandler[]{},M3714));
c.Add(new JMethod(3715,"forge/game/ability/effects/SeekEffect","movesCardToOrFromLibrary","(Lforge/game/spellability/SpellAbility;)Z",1,2,1,new JHandler[]{},M3715));
c.Add(new JMethod(3716,"forge/game/ability/effects/SeekEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,1,new JHandler[]{},M3716));
c.Add(new JMethod(3717,"forge/game/ability/effects/SeekEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,21,7,new JHandler[]{},M3717));
}

internal static JStep M3714(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3715(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3716(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3717(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",13);}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Types")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?49:24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Types")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Push(JValue.R(rt.String(",")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",37);}
case 37:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",40);}
case 40:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",45);}
case 45:{f.StackOp("pop");f.Pc=46;continue;}
case 46:{f.Pc=65;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("Type")));f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("Card")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",59);}
case 59:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("Num")));f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("1")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",74);}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",78);}
case 78:{f.Locals[5]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{f.Pc=f.Pop().Int>0?86:85;continue;}
case 85:{return JStep.ReturnVoid;}
case 86:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=89;continue;}
case 89:{f.StackOp("dup");f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",93);}
case 93:{f.Locals[6]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[3]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/Game","copyLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",99);}
case 99:{f.Locals[7]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/Game","copyLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",105);}
case 105:{f.Locals[8]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/ability/effects/SeekEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",111);}
case 111:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",114);}
case 114:{f.Locals[9]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[9]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",123);}
case 123:{f.Pc=f.Pop().Int==0?558:126;continue;}
case 126:{f.Push(f.Locals[9]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",133);}
case 133:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=136;continue;}
case 136:{f.Locals[10]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[10]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",143);}
case 143:{f.Pc=f.Pop().Int!=0?149:146;continue;}
case 146:{f.Pc=116;continue;}
case 149:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=152;continue;}
case 152:{f.StackOp("dup");f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",156);}
case 156:{f.Locals[11]=f.Pop();f.Pc=158;continue;}
case 158:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=161;continue;}
case 161:{f.StackOp("dup");f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",165);}
case 165:{f.Locals[12]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[4]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",174);}
case 174:{f.Locals[13]=f.Pop();f.Pc=176;continue;}
case 176:{f.Push(f.Locals[13]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",183);}
case 183:{f.Pc=f.Pop().Int==0?461:186;continue;}
case 186:{f.Push(f.Locals[13]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",193);}
case 193:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=196;continue;}
case 196:{f.Locals[14]=f.Pop();f.Pc=198;continue;}
case 198:{f.Push(f.Locals[1]);f.Pc=199;continue;}
case 199:{f.Push(JValue.R(rt.String("DefinedCards")));f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",204);}
case 204:{f.Pc=f.Pop().Int==0?223:207;continue;}
case 207:{f.Push(f.Locals[2]);f.Pc=208;continue;}
case 208:{f.Push(f.Locals[1]);f.Pc=209;continue;}
case 209:{f.Push(JValue.R(rt.String("DefinedCards")));f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",214);}
case 214:{f.Push(f.Locals[1]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",218);}
case 218:{f.Locals[15]=f.Pop();f.Pc=220;continue;}
case 220:{f.Pc=240;continue;}
case 223:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=226;continue;}
case 226:{f.StackOp("dup");f.Pc=227;continue;}
case 227:{f.Push(f.Locals[10]);f.Pc=229;continue;}
case 229:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",235);}
case 235:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",238);}
case 238:{f.Locals[15]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(f.Locals[14]);f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.String("Card")));f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",247);}
case 247:{f.Pc=f.Pop().Int!=0?265:250;continue;}
case 250:{f.Push(f.Locals[15]);f.Pc=252;continue;}
case 252:{f.Push(f.Locals[14]);f.Pc=254;continue;}
case 254:{f.Push(f.Locals[2]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",258);}
case 258:{f.Push(f.Locals[2]);f.Pc=259;continue;}
case 259:{f.Push(f.Locals[1]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",263);}
case 263:{f.Locals[15]=f.Pop();f.Pc=265;continue;}
case 265:{f.Push(f.Locals[15]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",270);}
case 270:{f.Pc=f.Pop().Int==0?315:273;continue;}
case 273:{f.Push(f.Locals[12]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",278);}
case 278:{f.Pc=f.Pop().Int==0?289:281;continue;}
case 281:{f.Push(f.Locals[12]);f.Pc=283;continue;}
case 283:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=285;continue;}
case 285:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",288);}
case 288:{f.StackOp("pop");f.Pc=289;continue;}
case 289:{f.Push(f.Locals[12]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",294);}
case 294:{f.Push(JValue.R(rt.String("lblSeekFailed")));f.Pc=296;continue;}
case 296:{f.Push(JValue.I(1));f.Pc=297;continue;}
case 297:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=300;continue;}
case 300:{f.StackOp("dup");f.Pc=301;continue;}
case 301:{f.Push(JValue.I(0));f.Pc=302;continue;}
case 302:{f.Push(f.Locals[14]);f.Pc=304;continue;}
case 304:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",308);}
case 308:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",311);}
case 311:{f.StackOp("pop");f.Pc=312;continue;}
case 312:{f.Pc=176;continue;}
case 315:{f.Push(f.Locals[15]);f.Pc=317;continue;}
case 317:{f.Push(f.Locals[5]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",322);}
case 322:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",327);}
case 327:{f.Locals[16]=f.Pop();f.Pc=329;continue;}
case 329:{f.Push(f.Locals[16]);f.Pc=331;continue;}
case 331:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",336);}
case 336:{f.Pc=f.Pop().Int==0?458:339;continue;}
case 339:{f.Push(f.Locals[16]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",346);}
case 346:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=349;continue;}
case 349:{f.Locals[17]=f.Pop();f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",354);}
case 354:{f.Locals[18]=f.Pop();f.Pc=356;continue;}
case 356:{f.Push(f.Locals[18]);f.Pc=358;continue;}
case 358:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=361;continue;}
case 361:{f.Push(f.Locals[7]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",368);}
case 368:{f.StackOp("pop");f.Pc=369;continue;}
case 369:{f.Push(f.Locals[18]);f.Pc=371;continue;}
case 371:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=374;continue;}
case 374:{f.Push(f.Locals[8]);f.Pc=376;continue;}
case 376:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",381);}
case 381:{f.StackOp("pop");f.Pc=382;continue;}
case 382:{f.Push(f.Locals[3]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",386);}
case 386:{f.Push(f.Locals[17]);f.Pc=388;continue;}
case 388:{f.Push(f.Locals[1]);f.Pc=389;continue;}
case 389:{f.Push(f.Locals[18]);f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/GameAction","moveToHand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",394);}
case 394:{f.Locals[19]=f.Pop();f.Pc=396;continue;}
case 396:{f.Push(f.Locals[19]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",401);}
case 401:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",404);}
case 404:{f.Locals[20]=f.Pop();f.Pc=406;continue;}
case 406:{f.Push(f.Locals[20]);f.Pc=408;continue;}
case 408:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",414);}
case 414:{f.Pc=f.Pop().Int!=0?436:417;continue;}
case 417:{f.Push(f.Locals[6]);f.Pc=419;continue;}
case 419:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=422;continue;}
case 422:{f.Push(f.Locals[19]);f.Pc=424;continue;}
case 424:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",427);}
case 427:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",430);}
case 430:{f.Push(f.Locals[19]);f.Pc=432;continue;}
case 432:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",435);}
case 435:{f.StackOp("pop");f.Pc=436;continue;}
case 436:{f.Push(f.Locals[20]);f.Pc=438;continue;}
case 438:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=441;continue;}
case 441:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",444);}
case 444:{f.Pc=f.Pop().Int==0?455:447;continue;}
case 447:{f.Push(f.Locals[11]);f.Pc=449;continue;}
case 449:{f.Push(f.Locals[19]);f.Pc=451;continue;}
case 451:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",454);}
case 454:{f.StackOp("pop");f.Pc=455;continue;}
case 455:{f.Pc=329;continue;}
case 458:{f.Pc=176;continue;}
case 461:{f.Push(f.Locals[12]);f.Pc=463;continue;}
case 463:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",466);}
case 466:{f.Pc=f.Pop().Int==0?484:469;continue;}
case 469:{f.Push(f.Locals[3]);f.Pc=470;continue;}
case 470:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",473);}
case 473:{f.Push(f.Locals[1]);f.Pc=474;continue;}
case 474:{f.Push(f.Locals[2]);f.Pc=475;continue;}
case 475:{f.Push(f.Locals[12]);f.Pc=477;continue;}
case 477:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",480);}
case 480:{f.Push(JValue.R(null));f.Pc=481;continue;}
case 481:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",484);}
case 484:{f.Push(f.Locals[11]);f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",489);}
case 489:{f.Pc=f.Pop().Int!=0?555:492;continue;}
case 492:{f.Push(f.Locals[1]);f.Pc=493;continue;}
case 493:{f.Push(JValue.R(rt.String("RememberFound")));f.Pc=495;continue;}
case 495:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",498);}
case 498:{f.Pc=f.Pop().Int==0?507:501;continue;}
case 501:{f.Push(f.Locals[2]);f.Pc=502;continue;}
case 502:{f.Push(f.Locals[11]);f.Pc=504;continue;}
case 504:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",507);}
case 507:{f.Push(f.Locals[1]);f.Pc=508;continue;}
case 508:{f.Push(JValue.R(rt.String("ImprintFound")));f.Pc=510;continue;}
case 510:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",513);}
case 513:{f.Pc=f.Pop().Int==0?522:516;continue;}
case 516:{f.Push(f.Locals[2]);f.Pc=517;continue;}
case 517:{f.Push(f.Locals[11]);f.Pc=519;continue;}
case 519:{return rt.Call(f,"forge/game/card/Card","addImprintedCards","(Ljava/lang/Iterable;)V","invokevirtual",522);}
case 522:{f.Push(f.Locals[10]);f.Pc=524;continue;}
case 524:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",527);}
case 527:{f.Locals[13]=f.Pop();f.Pc=529;continue;}
case 529:{f.Push(f.Locals[13]);f.Pc=531;continue;}
case 531:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=534;continue;}
case 534:{f.Push(f.Locals[11]);f.Pc=536;continue;}
case 536:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",541);}
case 541:{f.StackOp("pop");f.Pc=542;continue;}
case 542:{f.Push(f.Locals[3]);f.Pc=543;continue;}
case 543:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",546);}
case 546:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","SeekAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","SeekAll","Lforge/game/trigger/TriggerType;"));f.Pc=549;continue;}
case 549:{f.Push(f.Locals[13]);f.Pc=551;continue;}
case 551:{f.Push(JValue.I(0));f.Pc=552;continue;}
case 552:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",555);}
case 555:{f.Pc=116;continue;}
case 558:{f.Push(f.Locals[6]);f.Pc=560;continue;}
case 560:{f.Push(f.Locals[3]);f.Pc=561;continue;}
case 561:{f.Push(f.Locals[1]);f.Pc=562;continue;}
case 562:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",565);}
case 565:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
