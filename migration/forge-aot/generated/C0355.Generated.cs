// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C355{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ProtectAllEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3568,"forge/game/ability/effects/ProtectAllEffect","<init>","()V",1,1,1,new JHandler[]{},M3568));
c.Add(new JMethod(3569,"forge/game/ability/effects/ProtectAllEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,3,new JHandler[]{},M3569));
c.Add(new JMethod(3570,"forge/game/ability/effects/ProtectAllEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,16,8,new JHandler[]{},M3570));
}

internal static JStep M3568(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3569(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/ProtectAllEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int<=0?57:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Valid card gain protection")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("Duration")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",37);}
case 37:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int!=0?50:43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String(" until end of turn")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String(".")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",61);}
case 61:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3570(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("Gains")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Push(JValue.R(rt.String("Choice")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",30);}
case 30:{f.Locals[6]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/effects/ProtectEffect","getProtectionList","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",36);}
case 36:{f.Locals[7]=f.Pop();f.Pc=38;continue;}
case 38:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",45);}
case 45:{f.Locals[8]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[6]);f.Pc=49;continue;}
case 49:{f.Pc=f.Pop().Int==0?108:52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",56);}
case 56:{f.Locals[9]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[9]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",63);}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[7]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/player/PlayerController","chooseProtectionType","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Ljava/lang/String;","invokevirtual",69);}
case 69:{f.Locals[10]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(JValue.R(null));f.Pc=72;continue;}
case 72:{f.Push(f.Locals[10]);f.Pc=74;continue;}
case 74:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?78:77;continue;}
case 77:{return JStep.ReturnVoid;}
case 78:{f.Push(f.Locals[8]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[10]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",87);}
case 87:{f.StackOp("pop");f.Pc=88;continue;}
case 88:{f.Push(f.Locals[3]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",92);}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[9]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[8]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",100);}
case 100:{f.Push(f.Locals[9]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",105);}
case 105:{f.Pc=309;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("Gains")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",114);}
case 114:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",119);}
case 119:{f.Pc=f.Pop().Int==0?174:122;continue;}
case 122:{f.Push(f.Locals[2]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/card/Card","getChosenColors","()Ljava/lang/Iterable;","invokevirtual",126);}
case 126:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",131);}
case 131:{f.Locals[9]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[9]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",140);}
case 140:{f.Pc=f.Pop().Int==0?171:143;continue;}
case 143:{f.Push(f.Locals[9]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",150);}
case 150:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=153;continue;}
case 153:{f.Locals[10]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[8]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[10]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",162);}
case 162:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",167);}
case 167:{f.StackOp("pop");f.Pc=168;continue;}
case 168:{f.Pc=133;continue;}
case 171:{f.Pc=309;continue;}
case 174:{f.Push(f.Locals[1]);f.Pc=175;continue;}
case 175:{f.Push(JValue.R(rt.String("Gains")));f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",180);}
case 180:{f.Push(JValue.R(rt.String("TargetedCardColor")));f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",185);}
case 185:{f.Pc=f.Pop().Int==0?299:188;continue;}
case 188:{f.Push(f.Locals[1]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSATargetingCard","()Lforge/game/spellability/SpellAbility;","invokevirtual",192);}
case 192:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",195);}
case 195:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",198);}
case 198:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",203);}
case 203:{f.Locals[9]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[9]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",212);}
case 212:{f.Pc=f.Pop().Int==0?296:215;continue;}
case 215:{f.Push(f.Locals[9]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",222);}
case 222:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=225;continue;}
case 225:{f.Locals[10]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[10]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",232);}
case 232:{f.Locals[11]=f.Pop();f.Pc=234;continue;}
case 234:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=237;continue;}
case 237:{f.Locals[12]=f.Pop();f.Pc=239;continue;}
case 239:{f.Push(f.Locals[12]);f.Pc=241;continue;}
case 241:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=242;continue;}
case 242:{f.Locals[13]=f.Pop();f.Pc=244;continue;}
case 244:{f.Push(JValue.I(0));f.Pc=245;continue;}
case 245:{f.Locals[14]=f.Pop();f.Pc=247;continue;}
case 247:{f.Push(f.Locals[14]);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[13]);f.Pc=251;continue;}
case 251:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?293:254;continue;}
case 254:{f.Push(f.Locals[12]);f.Pc=256;continue;}
case 256:{f.Push(f.Locals[14]);f.Pc=258;continue;}
case 258:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=259;continue;}
case 259:{f.Locals[15]=f.Pop();f.Pc=261;continue;}
case 261:{f.Push(f.Locals[11]);f.Pc=263;continue;}
case 263:{f.Push(f.Locals[15]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",268);}
case 268:{f.Pc=f.Pop().Int==0?287:271;continue;}
case 271:{f.Push(f.Locals[8]);f.Pc=273;continue;}
case 273:{f.Push(f.Locals[15]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/card/MagicColor","toLongString","(B)Ljava/lang/String;","invokestatic",278);}
case 278:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",281);}
case 281:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",286);}
case 286:{f.StackOp("pop");f.Pc=287;continue;}
case 287:{f.Locals[14]=JValue.I(unchecked(f.Locals[14].Int+(1)));f.Pc=290;continue;}
case 290:{f.Pc=247;continue;}
case 293:{f.Pc=205;continue;}
case 296:{f.Pc=309;continue;}
case 299:{f.Push(f.Locals[8]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[7]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",308);}
case 308:{f.StackOp("pop");f.Pc=309;continue;}
case 309:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",312);}
case 312:{f.Locals[9]=f.Pop();f.Pc=314;continue;}
case 314:{f.Push(f.Locals[8]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",321);}
case 321:{f.Locals[10]=f.Pop();f.Pc=323;continue;}
case 323:{f.Push(f.Locals[10]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",330);}
case 330:{f.Pc=f.Pop().Int==0?373:333;continue;}
case 333:{f.Push(f.Locals[10]);f.Pc=335;continue;}
case 335:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",340);}
case 340:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=343;continue;}
case 343:{f.Locals[11]=f.Pop();f.Pc=345;continue;}
case 345:{f.Push(f.Locals[9]);f.Pc=347;continue;}
case 347:{f.Push(JValue.I(2));f.Pc=348;continue;}
case 348:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=351;continue;}
case 351:{f.StackOp("dup");f.Pc=352;continue;}
case 352:{f.Push(JValue.I(0));f.Pc=353;continue;}
case 353:{f.Push(JValue.R(rt.String("Protection from")));f.Pc=355;continue;}
case 355:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=356;continue;}
case 356:{f.StackOp("dup");f.Pc=357;continue;}
case 357:{f.Push(JValue.I(1));f.Pc=358;continue;}
case 358:{f.Push(f.Locals[11]);f.Pc=360;continue;}
case 360:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=361;continue;}
case 361:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",364);}
case 364:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",369);}
case 369:{f.StackOp("pop");f.Pc=370;continue;}
case 370:{f.Pc=323;continue;}
case 373:{f.Push(f.Locals[1]);f.Pc=374;continue;}
case 374:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=376;continue;}
case 376:{f.Push(JValue.R(rt.String("")));f.Pc=378;continue;}
case 378:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",381);}
case 381:{f.Locals[10]=f.Pop();f.Pc=383;continue;}
case 383:{f.Push(f.Locals[10]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",388);}
case 388:{f.Pc=f.Pop().Int!=0?506:391;continue;}
case 391:{f.Push(f.Locals[3]);f.Pc=392;continue;}
case 392:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",398);}
case 398:{f.Push(f.Locals[10]);f.Pc=400;continue;}
case 400:{f.Push(f.Locals[1]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",404);}
case 404:{f.Push(f.Locals[2]);f.Pc=405;continue;}
case 405:{f.Push(f.Locals[1]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",409);}
case 409:{f.Locals[11]=f.Pop();f.Pc=411;continue;}
case 411:{f.Push(f.Locals[11]);f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",418);}
case 418:{f.Locals[12]=f.Pop();f.Pc=420;continue;}
case 420:{f.Push(f.Locals[12]);f.Pc=422;continue;}
case 422:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",427);}
case 427:{f.Pc=f.Pop().Int==0?506:430;continue;}
case 430:{f.Push(f.Locals[12]);f.Pc=432;continue;}
case 432:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",437);}
case 437:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=440;continue;}
case 440:{f.Locals[13]=f.Pop();f.Pc=442;continue;}
case 442:{f.Push(f.Locals[13]);f.Pc=444;continue;}
case 444:{f.Push(f.Locals[9]);f.Pc=446;continue;}
case 446:{f.Push(JValue.R(null));f.Pc=447;continue;}
case 447:{f.Push(JValue.I(0));f.Pc=448;continue;}
case 448:{f.Push(f.Locals[4]);f.Pc=450;continue;}
case 450:{f.Push(JValue.R(null));f.Pc=451;continue;}
case 451:{f.Push(JValue.I(1));f.Pc=452;continue;}
case 452:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywords","(Ljava/util/List;Ljava/util/List;ZJLforge/game/staticability/StaticAbility;Z)V","invokevirtual",455);}
case 455:{f.Push(f.Locals[3]);f.Pc=456;continue;}
case 456:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=459;continue;}
case 459:{f.StackOp("dup");f.Pc=460;continue;}
case 460:{f.Push(f.Locals[13]);f.Pc=462;continue;}
case 462:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",465);}
case 465:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",468);}
case 468:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=470;continue;}
case 470:{f.Push(f.Locals[1]);f.Pc=471;continue;}
case 471:{f.Push(JValue.R(rt.String("Duration")));f.Pc=473;continue;}
case 473:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",476);}
case 476:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",479);}
case 479:{f.Pc=f.Pop().Int!=0?503:482;continue;}
case 482:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/ProtectAllEffect$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/ProtectAllEffect$1")));f.Pc=485;continue;}
case 485:{f.StackOp("dup");f.Pc=486;continue;}
case 486:{f.Push(f.Locals[0]);f.Pc=487;continue;}
case 487:{f.Push(f.Locals[13]);f.Pc=489;continue;}
case 489:{f.Push(f.Locals[4]);f.Pc=491;continue;}
case 491:{f.Push(f.Locals[3]);f.Pc=492;continue;}
case 492:{return rt.Call(f,"forge/game/ability/effects/ProtectAllEffect$1","<init>","(Lforge/game/ability/effects/ProtectAllEffect;Lforge/game/card/Card;JLforge/game/Game;)V","invokespecial",495);}
case 495:{f.Locals[14]=f.Pop();f.Pc=497;continue;}
case 497:{f.Push(f.Locals[1]);f.Pc=498;continue;}
case 498:{f.Push(f.Locals[14]);f.Pc=500;continue;}
case 500:{return rt.Call(f,"forge/game/ability/effects/ProtectAllEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;)V","invokestatic",503);}
case 503:{f.Pc=420;continue;}
case 506:{f.Push(f.Locals[1]);f.Pc=507;continue;}
case 507:{f.Push(JValue.R(rt.String("ValidPlayers")));f.Pc=509;continue;}
case 509:{f.Push(JValue.R(rt.String("")));f.Pc=511;continue;}
case 511:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",514);}
case 514:{f.Locals[11]=f.Pop();f.Pc=516;continue;}
case 516:{f.Push(f.Locals[11]);f.Pc=518;continue;}
case 518:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",521);}
case 521:{f.Pc=f.Pop().Int!=0?611:524;continue;}
case 524:{f.Push(f.Locals[2]);f.Pc=525;continue;}
case 525:{f.Push(f.Locals[11]);f.Pc=527;continue;}
case 527:{f.Push(f.Locals[1]);f.Pc=528;continue;}
case 528:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",531);}
case 531:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",534);}
case 534:{f.Locals[12]=f.Pop();f.Pc=536;continue;}
case 536:{f.Push(f.Locals[12]);f.Pc=538;continue;}
case 538:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",543);}
case 543:{f.Pc=f.Pop().Int==0?611:546;continue;}
case 546:{f.Push(f.Locals[12]);f.Pc=548;continue;}
case 548:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",553);}
case 553:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=556;continue;}
case 556:{f.Locals[13]=f.Pop();f.Pc=558;continue;}
case 558:{f.Push(f.Locals[13]);f.Pc=560;continue;}
case 560:{f.Push(f.Locals[9]);f.Pc=562;continue;}
case 562:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",565);}
case 565:{f.Push(f.Locals[4]);f.Pc=567;continue;}
case 567:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",570);}
case 570:{f.Push(JValue.L(0));f.Pc=571;continue;}
case 571:{return rt.Call(f,"forge/game/player/Player","addChangedKeywords","(Ljava/util/List;Ljava/util/List;Ljava/lang/Long;J)V","invokevirtual",574);}
case 574:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=576;continue;}
case 576:{f.Push(f.Locals[1]);f.Pc=577;continue;}
case 577:{f.Push(JValue.R(rt.String("Duration")));f.Pc=579;continue;}
case 579:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",582);}
case 582:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",585);}
case 585:{f.Pc=f.Pop().Int!=0?608:588;continue;}
case 588:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/ProtectAllEffect$2"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/ProtectAllEffect$2")));f.Pc=591;continue;}
case 591:{f.StackOp("dup");f.Pc=592;continue;}
case 592:{f.Push(f.Locals[0]);f.Pc=593;continue;}
case 593:{f.Push(f.Locals[13]);f.Pc=595;continue;}
case 595:{f.Push(f.Locals[4]);f.Pc=597;continue;}
case 597:{return rt.Call(f,"forge/game/ability/effects/ProtectAllEffect$2","<init>","(Lforge/game/ability/effects/ProtectAllEffect;Lforge/game/player/Player;J)V","invokespecial",600);}
case 600:{f.Locals[14]=f.Pop();f.Pc=602;continue;}
case 602:{f.Push(f.Locals[1]);f.Pc=603;continue;}
case 603:{f.Push(f.Locals[14]);f.Pc=605;continue;}
case 605:{return rt.Call(f,"forge/game/ability/effects/ProtectAllEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;)V","invokestatic",608);}
case 608:{f.Pc=536;continue;}
case 611:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
