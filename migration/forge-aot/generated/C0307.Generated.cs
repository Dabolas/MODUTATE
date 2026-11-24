// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C307{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/FlipOntoBattlefieldEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("boardDecidesHits","Z",true,JValue.Default("Z"),null));
c.Add(new JMethod(3409,"forge/game/ability/effects/FlipOntoBattlefieldEffect","<init>","()V",1,1,1,new JHandler[]{},M3409));
c.Add(new JMethod(3410,"forge/game/ability/effects/FlipOntoBattlefieldEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,26,9,new JHandler[]{},M3410));
c.Add(new JMethod(3411,"forge/game/ability/effects/FlipOntoBattlefieldEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,2,new JHandler[]{},M3411));
c.Add(new JMethod(3412,"forge/game/ability/effects/FlipOntoBattlefieldEffect","getNeighboringCard","(Lforge/game/card/Card;I)Lforge/game/card/Card;",2,8,3,new JHandler[]{},M3412));
c.Add(new JMethod(3413,"forge/game/ability/effects/FlipOntoBattlefieldEffect","lambda$getNeighboringCard$1","(Lforge/game/card/Card;Ljava/util/ArrayList;Lforge/game/card/Card;)Z",4106,3,2,new JHandler[]{},M3413));
c.Add(new JMethod(3414,"forge/game/ability/effects/FlipOntoBattlefieldEffect","lambda$resolve$0","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M3414));
c.Add(new JMethod(3415,"forge/game/ability/effects/FlipOntoBattlefieldEffect","<clinit>","()V",8,0,1,new JHandler[]{},M3415));
}

internal static JStep M3409(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3410(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.F(0.8500000238418579f));f.Pc=2;continue;}
case 2:{f.Locals[2]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(JValue.I(2));f.Pc=4;continue;}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/ability/effects/FlipOntoBattlefieldEffect","boardDecidesHits","Z"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/effects/FlipOntoBattlefieldEffect","boardDecidesHits","Z"));f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int==0?16:11;continue;}
case 11:{f.Push(JValue.F(0.05999999865889549f));f.Pc=13;continue;}
case 13:{f.Pc=17;continue;}
case 16:{f.Push(JValue.F(0));f.Pc=17;continue;}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(JValue.F(0.20000000298023224f));f.Pc=21;continue;}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",27);}
case 27:{f.Locals[6]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",33);}
case 33:{f.Locals[7]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",40);}
case 40:{f.Locals[8]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[7]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",47);}
case 47:{f.Push(f.Locals[8]);f.Pc=49;continue;}
case 49:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",55);}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",59);}
case 59:{f.Push(JValue.R(rt.String("lblChooseDesiredLocation")));f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",68);}
case 68:{f.Push(JValue.I(1));f.Pc=69;continue;}
case 69:{f.Push(JValue.I(1));f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("AllowRandom")));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",76);}
case 76:{f.Push(JValue.R(null));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",80);}
case 80:{f.Locals[9]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[9]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/card/CardCollectionView","getFirst","()Ljava/lang/Object;","invokeinterface",89);}
case 89:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=92;continue;}
case 92:{f.Locals[10]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[10]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",99);}
case 99:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",105);}
case 105:{f.Push(f.Locals[10]);f.Pc=107;continue;}
case 107:{return rt.DynamicCall(f,"forge/game/ability/effects/FlipOntoBattlefieldEffect:3410:107:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",112);}
case 112:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",115);}
case 115:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",118);}
case 118:{f.Locals[11]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(JValue.F(1));f.Pc=121;continue;}
case 121:{f.Push(JValue.F(0.44999998807907104f));f.Pc=123;continue;}
case 123:{f.Push(JValue.F(0.07000000029802322f));f.Pc=125;continue;}
case 125:{f.Push(f.Locals[11]);f.Pc=127;continue;}
case 127:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=128;continue;}
case 128:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fmul",a,b));f.Pc=129;continue;}
case 129:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fadd",a,b));f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/lang/Math","min","(FF)F","invokestatic",133);}
case 133:{f.Locals[12]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[10]);f.Pc=138;continue;}
case 138:{f.Push(JValue.I(-1));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/ability/effects/FlipOntoBattlefieldEffect","getNeighboringCard","(Lforge/game/card/Card;I)Lforge/game/card/Card;","invokevirtual",142);}
case 142:{f.Locals[13]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[10]);f.Pc=147;continue;}
case 147:{f.Push(JValue.I(1));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/ability/effects/FlipOntoBattlefieldEffect","getNeighboringCard","(Lforge/game/card/Card;I)Lforge/game/card/Card;","invokevirtual",151);}
case 151:{f.Locals[14]=f.Pop();f.Pc=153;continue;}
case 153:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=156;continue;}
case 156:{f.StackOp("dup");f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",160);}
case 160:{f.Locals[15]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[15]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[10]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",169);}
case 169:{f.StackOp("pop");f.Pc=170;continue;}
case 170:{f.Push(f.Locals[13]);f.Pc=172;continue;}
case 172:{f.Pc=f.Pop().Reference==null?190:175;continue;}
case 175:{f.Push(f.Locals[13]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[10]);f.Pc=179;continue;}
case 179:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?190:182;continue;}
case 182:{f.Push(f.Locals[15]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[13]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",189);}
case 189:{f.StackOp("pop");f.Pc=190;continue;}
case 190:{f.Push(f.Locals[14]);f.Pc=192;continue;}
case 192:{f.Pc=f.Pop().Reference==null?210:195;continue;}
case 195:{f.Push(f.Locals[14]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[10]);f.Pc=199;continue;}
case 199:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?210:202;continue;}
case 202:{f.Push(f.Locals[15]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[14]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",209);}
case 209:{f.StackOp("pop");f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",213);}
case 213:{return rt.Call(f,"java/util/Random","nextFloat","()F","invokevirtual",216);}
case 216:{f.Push(JValue.F(0.8500000238418579f));f.Pc=218;continue;}
case 218:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fcmpg",a,b));f.Pc=219;continue;}
case 219:{f.Pc=f.Pop().Int>0?226:222;continue;}
case 222:{f.Push(JValue.I(1));f.Pc=223;continue;}
case 223:{f.Pc=227;continue;}
case 226:{f.Push(JValue.I(0));f.Pc=227;continue;}
case 227:{f.Locals[16]=f.Pop();f.Pc=229;continue;}
case 229:{f.Push(f.Locals[16]);f.Pc=231;continue;}
case 231:{f.Pc=f.Pop().Int==0?246:234;continue;}
case 234:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",237);}
case 237:{f.Push(JValue.I(2));f.Pc=238;continue;}
case 238:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",241);}
case 241:{f.Push(JValue.I(1));f.Pc=242;continue;}
case 242:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=243;continue;}
case 243:{f.Pc=247;continue;}
case 246:{f.Push(JValue.I(0));f.Pc=247;continue;}
case 247:{f.Locals[17]=f.Pop();f.Pc=249;continue;}
case 249:{f.Push(f.Locals[1]);f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.String("TimesFlipped")));f.Pc=252;continue;}
case 252:{f.Push(f.Locals[17]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",257);}
case 257:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",260);}
case 260:{f.Push(JValue.I(0));f.Pc=261;continue;}
case 261:{f.Locals[18]=f.Pop();f.Pc=263;continue;}
case 263:{f.Push(f.Locals[16]);f.Pc=265;continue;}
case 265:{f.Pc=f.Pop().Int==0?323:268;continue;}
case 268:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",271);}
case 271:{return rt.Call(f,"java/util/Random","nextFloat","()F","invokevirtual",274);}
case 274:{f.Locals[19]=f.Pop();f.Pc=276;continue;}
case 276:{f.Push(f.Locals[19]);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[4]);f.Pc=280;continue;}
case 280:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fcmpg",a,b));f.Pc=281;continue;}
case 281:{f.Pc=f.Pop().Int>0?298:284;continue;}
case 284:{f.Push(JValue.I(3));f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",288);}
case 288:{f.Push(JValue.I(2));f.Pc=289;continue;}
case 289:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",292);}
case 292:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=293;continue;}
case 293:{f.Locals[18]=f.Pop();f.Pc=295;continue;}
case 295:{f.Pc=323;continue;}
case 298:{f.Push(f.Locals[19]);f.Pc=300;continue;}
case 300:{f.Push(JValue.F(0.20000000298023224f));f.Pc=302;continue;}
case 302:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fcmpg",a,b));f.Pc=303;continue;}
case 303:{f.Pc=f.Pop().Int>0?312:306;continue;}
case 306:{f.Push(JValue.I(2));f.Pc=307;continue;}
case 307:{f.Locals[18]=f.Pop();f.Pc=309;continue;}
case 309:{f.Pc=323;continue;}
case 312:{f.Push(f.Locals[19]);f.Pc=314;continue;}
case 314:{f.Push(f.Locals[12]);f.Pc=316;continue;}
case 316:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fcmpg",a,b));f.Pc=317;continue;}
case 317:{f.Pc=f.Pop().Int>0?323:320;continue;}
case 320:{f.Push(JValue.I(1));f.Pc=321;continue;}
case 321:{f.Locals[18]=f.Pop();f.Pc=323;continue;}
case 323:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=326;continue;}
case 326:{f.StackOp("dup");f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",330);}
case 330:{f.Locals[19]=f.Pop();f.Pc=332;continue;}
case 332:{f.Push(f.Locals[18]);f.Pc=334;continue;}
case 334:{f.Push(JValue.I(1));f.Pc=335;continue;}
case 335:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?355:338;continue;}
case 338:{f.Push(f.Locals[19]);f.Pc=340;continue;}
case 340:{f.Push(f.Locals[15]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",345);}
case 345:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=348;continue;}
case 348:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",351);}
case 351:{f.StackOp("pop");f.Pc=352;continue;}
case 352:{f.Pc=500;continue;}
case 355:{f.Push(f.Locals[18]);f.Pc=357;continue;}
case 357:{f.Push(JValue.I(1));f.Pc=358;continue;}
case 358:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?500:361;continue;}
case 361:{f.Push(f.Locals[19]);f.Pc=363;continue;}
case 363:{f.Push(f.Locals[10]);f.Pc=365;continue;}
case 365:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",368);}
case 368:{f.StackOp("pop");f.Pc=369;continue;}
case 369:{f.Push(f.Locals[15]);f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",374);}
case 374:{f.Locals[20]=f.Pop();f.Pc=376;continue;}
case 376:{f.Push(f.Locals[20]);f.Pc=378;continue;}
case 378:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",383);}
case 383:{f.Pc=f.Pop().Int==0?429:386;continue;}
case 386:{f.Push(f.Locals[20]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",393);}
case 393:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=396;continue;}
case 396:{f.Locals[21]=f.Pop();f.Pc=398;continue;}
case 398:{f.Push(f.Locals[19]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",403);}
case 403:{f.Push(f.Locals[18]);f.Pc=405;continue;}
case 405:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?426:408;continue;}
case 408:{f.Push(f.Locals[19]);f.Pc=410;continue;}
case 410:{f.Push(f.Locals[21]);f.Pc=412;continue;}
case 412:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",415);}
case 415:{f.Pc=f.Pop().Int!=0?426:418;continue;}
case 418:{f.Push(f.Locals[19]);f.Pc=420;continue;}
case 420:{f.Push(f.Locals[21]);f.Pc=422;continue;}
case 422:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",425);}
case 425:{f.StackOp("pop");f.Pc=426;continue;}
case 426:{f.Pc=376;continue;}
case 429:{f.Push(f.Locals[10]);f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",434);}
case 434:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=437;continue;}
case 437:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",440);}
case 440:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",445);}
case 445:{f.Locals[20]=f.Pop();f.Pc=447;continue;}
case 447:{f.Push(f.Locals[20]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",454);}
case 454:{f.Pc=f.Pop().Int==0?500:457;continue;}
case 457:{f.Push(f.Locals[20]);f.Pc=459;continue;}
case 459:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",464);}
case 464:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=467;continue;}
case 467:{f.Locals[21]=f.Pop();f.Pc=469;continue;}
case 469:{f.Push(f.Locals[19]);f.Pc=471;continue;}
case 471:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",474);}
case 474:{f.Push(f.Locals[18]);f.Pc=476;continue;}
case 476:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?497:479;continue;}
case 479:{f.Push(f.Locals[19]);f.Pc=481;continue;}
case 481:{f.Push(f.Locals[21]);f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",486);}
case 486:{f.Pc=f.Pop().Int!=0?497:489;continue;}
case 489:{f.Push(f.Locals[19]);f.Pc=491;continue;}
case 491:{f.Push(f.Locals[21]);f.Pc=493;continue;}
case 493:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",496);}
case 496:{f.StackOp("pop");f.Pc=497;continue;}
case 497:{f.Pc=447;continue;}
case 500:{f.Push(f.Locals[6]);f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",505);}
case 505:{f.Locals[20]=f.Pop();f.Pc=507;continue;}
case 507:{f.Push(f.Locals[10]);f.Pc=509;continue;}
case 509:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",512);}
case 512:{f.Locals[21]=f.Pop();f.Pc=514;continue;}
case 514:{if(!rt.EnsureInitialized(f,"java/util/concurrent/CopyOnWriteArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/CopyOnWriteArrayList")));f.Pc=517;continue;}
case 517:{f.StackOp("dup");f.Pc=518;continue;}
case 518:{return rt.Call(f,"java/util/concurrent/CopyOnWriteArrayList","<init>","()V","invokespecial",521);}
case 521:{f.Locals[22]=f.Pop();f.Pc=523;continue;}
case 523:{f.Push(f.Locals[19]);f.Pc=525;continue;}
case 525:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",528);}
case 528:{f.Locals[23]=f.Pop();f.Pc=530;continue;}
case 530:{f.Push(f.Locals[23]);f.Pc=532;continue;}
case 532:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",537);}
case 537:{f.Pc=f.Pop().Int==0?568:540;continue;}
case 540:{f.Push(f.Locals[23]);f.Pc=542;continue;}
case 542:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",547);}
case 547:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=550;continue;}
case 550:{f.Locals[24]=f.Pop();f.Pc=552;continue;}
case 552:{f.Push(f.Locals[22]);f.Pc=554;continue;}
case 554:{f.Push(f.Locals[24]);f.Pc=556;continue;}
case 556:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",559);}
case 559:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",564);}
case 564:{f.StackOp("pop");f.Pc=565;continue;}
case 565:{f.Pc=530;continue;}
case 568:{f.Push(f.Locals[8]);f.Pc=570;continue;}
case 570:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventFlipOntoBattlefield"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventFlipOntoBattlefield")));f.Pc=573;continue;}
case 573:{f.StackOp("dup");f.Pc=574;continue;}
case 574:{f.Push(f.Locals[20]);f.Pc=576;continue;}
case 576:{f.Push(f.Locals[21]);f.Pc=578;continue;}
case 578:{f.Push(f.Locals[22]);f.Pc=580;continue;}
case 580:{f.Push(f.Locals[17]);f.Pc=582;continue;}
case 582:{f.Push(JValue.I(0));f.Pc=583;continue;}
case 583:{return rt.Call(f,"forge/game/event/GameEventFlipOntoBattlefield","<init>","(Lforge/game/card/CardView;Lforge/game/card/CardView;Ljava/util/List;IZ)V","invokespecial",586);}
case 586:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",589);}
case 589:{f.Push(f.Locals[16]);f.Pc=591;continue;}
case 591:{f.Pc=f.Pop().Int==0?670:594;continue;}
case 594:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=597;continue;}
case 597:{f.StackOp("dup");f.Pc=598;continue;}
case 598:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",601);}
case 601:{f.Locals[19]=f.Pop();f.Pc=603;continue;}
case 603:{f.Push(f.Locals[22]);f.Pc=605;continue;}
case 605:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",610);}
case 610:{f.Locals[23]=f.Pop();f.Pc=612;continue;}
case 612:{f.Push(f.Locals[23]);f.Pc=614;continue;}
case 614:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",619);}
case 619:{f.Pc=f.Pop().Int==0?670:622;continue;}
case 622:{f.Push(f.Locals[23]);f.Pc=624;continue;}
case 624:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",629);}
case 629:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=632;continue;}
case 632:{f.Locals[24]=f.Pop();f.Pc=634;continue;}
case 634:{f.Push(f.Locals[8]);f.Pc=636;continue;}
case 636:{f.Push(f.Locals[24]);f.Pc=638;continue;}
case 638:{return rt.Call(f,"forge/game/card/CardView","getId","()I","invokevirtual",641);}
case 641:{return rt.Call(f,"forge/game/Game","findById","(I)Lforge/game/card/Card;","invokevirtual",644);}
case 644:{f.Locals[25]=f.Pop();f.Pc=646;continue;}
case 646:{f.Push(f.Locals[25]);f.Pc=648;continue;}
case 648:{f.Pc=f.Pop().Reference==null?667:651;continue;}
case 651:{f.Push(f.Locals[25]);f.Pc=653;continue;}
case 653:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",656);}
case 656:{f.Pc=f.Pop().Int==0?667:659;continue;}
case 659:{f.Push(f.Locals[19]);f.Pc=661;continue;}
case 661:{f.Push(f.Locals[25]);f.Pc=663;continue;}
case 663:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",666);}
case 666:{f.StackOp("pop");f.Pc=667;continue;}
case 667:{f.Pc=612;continue;}
case 670:{f.Push(f.Locals[16]);f.Pc=672;continue;}
case 672:{f.Pc=f.Pop().Int!=0?720:675;continue;}
case 675:{f.Push(f.Locals[8]);f.Pc=677;continue;}
case 677:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",680);}
case 680:{f.Push(f.Locals[1]);f.Pc=681;continue;}
case 681:{f.Push(f.Locals[6]);f.Pc=683;continue;}
case 683:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",686);}
case 686:{f.Push(JValue.R(rt.String("lblDidNotFlipOver")));f.Pc=688;continue;}
case 688:{f.Push(JValue.I(0));f.Pc=689;continue;}
case 689:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=692;continue;}
case 692:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",695);}
case 695:{f.Push(JValue.R(null));f.Pc=696;continue;}
case 696:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",699);}
case 699:{f.Push(f.Locals[8]);f.Pc=701;continue;}
case 701:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventFlipOntoBattlefield"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventFlipOntoBattlefield")));f.Pc=704;continue;}
case 704:{f.StackOp("dup");f.Pc=705;continue;}
case 705:{f.Push(f.Locals[20]);f.Pc=707;continue;}
case 707:{f.Push(f.Locals[21]);f.Pc=709;continue;}
case 709:{f.Push(f.Locals[22]);f.Pc=711;continue;}
case 711:{f.Push(JValue.I(0));f.Pc=712;continue;}
case 712:{f.Push(JValue.I(1));f.Pc=713;continue;}
case 713:{return rt.Call(f,"forge/game/event/GameEventFlipOntoBattlefield","<init>","(Lforge/game/card/CardView;Lforge/game/card/CardView;Ljava/util/List;IZ)V","invokespecial",716);}
case 716:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",719);}
case 719:{return JStep.ReturnVoid;}
case 720:{f.Push(f.Locals[8]);f.Pc=722;continue;}
case 722:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",725);}
case 725:{f.Push(f.Locals[1]);f.Pc=726;continue;}
case 726:{f.Push(f.Locals[6]);f.Pc=728;continue;}
case 728:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",731);}
case 731:{f.Push(JValue.R(rt.String("lblFlippedOver")));f.Pc=733;continue;}
case 733:{f.Push(JValue.I(1));f.Pc=734;continue;}
case 734:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=737;continue;}
case 737:{f.StackOp("dup");f.Pc=738;continue;}
case 738:{f.Push(JValue.I(0));f.Pc=739;continue;}
case 739:{f.Push(f.Locals[17]);f.Pc=741;continue;}
case 741:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",744);}
case 744:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=745;continue;}
case 745:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",748);}
case 748:{f.Push(JValue.R(null));f.Pc=749;continue;}
case 749:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",752);}
case 752:{f.Push(f.Locals[19]);f.Pc=754;continue;}
case 754:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",757);}
case 757:{f.Push(JValue.I(3));f.Pc=758;continue;}
case 758:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?796:761;continue;}
case 761:{f.Push(f.Locals[8]);f.Pc=763;continue;}
case 763:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",766);}
case 766:{f.Push(f.Locals[1]);f.Pc=767;continue;}
case 767:{f.Push(f.Locals[6]);f.Pc=769;continue;}
case 769:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",772);}
case 772:{f.Push(JValue.R(rt.String("lblLandedOnOneCard")));f.Pc=774;continue;}
case 774:{f.Push(JValue.I(1));f.Pc=775;continue;}
case 775:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=778;continue;}
case 778:{f.StackOp("dup");f.Pc=779;continue;}
case 779:{f.Push(JValue.I(0));f.Pc=780;continue;}
case 780:{f.Push(f.Locals[19]);f.Pc=782;continue;}
case 782:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",785);}
case 785:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=786;continue;}
case 786:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",789);}
case 789:{f.Push(JValue.R(null));f.Pc=790;continue;}
case 790:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",793);}
case 793:{f.Pc=916;continue;}
case 796:{f.Push(f.Locals[19]);f.Pc=798;continue;}
case 798:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",801);}
case 801:{f.Push(JValue.I(2));f.Pc=802;continue;}
case 802:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?848:805;continue;}
case 805:{f.Push(f.Locals[8]);f.Pc=807;continue;}
case 807:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",810);}
case 810:{f.Push(f.Locals[1]);f.Pc=811;continue;}
case 811:{f.Push(f.Locals[6]);f.Pc=813;continue;}
case 813:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",816);}
case 816:{f.Push(JValue.R(rt.String("lblLandedOnTwoCards")));f.Pc=818;continue;}
case 818:{f.Push(JValue.I(2));f.Pc=819;continue;}
case 819:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=822;continue;}
case 822:{f.StackOp("dup");f.Pc=823;continue;}
case 823:{f.Push(JValue.I(0));f.Pc=824;continue;}
case 824:{f.Push(f.Locals[19]);f.Pc=826;continue;}
case 826:{return rt.Call(f,"forge/game/card/CardCollection","getFirst","()Ljava/lang/Object;","invokevirtual",829);}
case 829:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=830;continue;}
case 830:{f.StackOp("dup");f.Pc=831;continue;}
case 831:{f.Push(JValue.I(1));f.Pc=832;continue;}
case 832:{f.Push(f.Locals[19]);f.Pc=834;continue;}
case 834:{return rt.Call(f,"forge/game/card/CardCollection","getLast","()Ljava/lang/Object;","invokevirtual",837);}
case 837:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=838;continue;}
case 838:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",841);}
case 841:{f.Push(JValue.R(null));f.Pc=842;continue;}
case 842:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",845);}
case 845:{f.Pc=916;continue;}
case 848:{f.Push(f.Locals[19]);f.Pc=850;continue;}
case 850:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",853);}
case 853:{f.Push(JValue.I(1));f.Pc=854;continue;}
case 854:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?892:857;continue;}
case 857:{f.Push(f.Locals[8]);f.Pc=859;continue;}
case 859:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",862);}
case 862:{f.Push(f.Locals[1]);f.Pc=863;continue;}
case 863:{f.Push(f.Locals[6]);f.Pc=865;continue;}
case 865:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",868);}
case 868:{f.Push(JValue.R(rt.String("lblLandedOnOneCard")));f.Pc=870;continue;}
case 870:{f.Push(JValue.I(1));f.Pc=871;continue;}
case 871:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=874;continue;}
case 874:{f.StackOp("dup");f.Pc=875;continue;}
case 875:{f.Push(JValue.I(0));f.Pc=876;continue;}
case 876:{f.Push(f.Locals[19]);f.Pc=878;continue;}
case 878:{return rt.Call(f,"forge/game/card/CardCollection","getFirst","()Ljava/lang/Object;","invokevirtual",881);}
case 881:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=882;continue;}
case 882:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",885);}
case 885:{f.Push(JValue.R(null));f.Pc=886;continue;}
case 886:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",889);}
case 889:{f.Pc=916;continue;}
case 892:{f.Push(f.Locals[8]);f.Pc=894;continue;}
case 894:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",897);}
case 897:{f.Push(f.Locals[1]);f.Pc=898;continue;}
case 898:{f.Push(f.Locals[6]);f.Pc=900;continue;}
case 900:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",903);}
case 903:{f.Push(JValue.R(rt.String("lblDidNotLandOnCards")));f.Pc=905;continue;}
case 905:{f.Push(JValue.I(0));f.Pc=906;continue;}
case 906:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=909;continue;}
case 909:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",912);}
case 912:{f.Push(JValue.R(null));f.Pc=913;continue;}
case 913:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",916);}
case 916:{f.Push(f.Locals[6]);f.Pc=918;continue;}
case 918:{f.Push(f.Locals[19]);f.Pc=920;continue;}
case 920:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",923);}
case 923:{f.Push(f.Locals[8]);f.Pc=925;continue;}
case 925:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventFlipOntoBattlefield"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventFlipOntoBattlefield")));f.Pc=928;continue;}
case 928:{f.StackOp("dup");f.Pc=929;continue;}
case 929:{f.Push(f.Locals[20]);f.Pc=931;continue;}
case 931:{f.Push(f.Locals[21]);f.Pc=933;continue;}
case 933:{f.Push(f.Locals[22]);f.Pc=935;continue;}
case 935:{f.Push(f.Locals[17]);f.Pc=937;continue;}
case 937:{f.Push(JValue.I(1));f.Pc=938;continue;}
case 938:{return rt.Call(f,"forge/game/event/GameEventFlipOntoBattlefield","<init>","(Lforge/game/card/CardView;Lforge/game/card/CardView;Ljava/util/List;IZ)V","invokespecial",941);}
case 941:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",944);}
case 944:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3411(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Flip ")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",25);}
case 25:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String(" onto the battlefield from a height of at least one foot.")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",40);}
case 40:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3412(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",8);}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",17);}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{return rt.DynamicCall(f,"forge/game/ability/effects/FlipOntoBattlefieldEffect:3412:20:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;Ljava/util/ArrayList;)Ljava/util/function/Predicate;",25);}
case 25:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",28);}
case 28:{f.Locals[5]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(JValue.F(0.5f));f.Pc=33;continue;}
case 33:{f.Locals[6]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/ArrayList","isEmpty","()Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int!=0?68:43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Int>=0?68:47;continue;}
case 47:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",50);}
case 50:{return rt.Call(f,"java/util/Random","nextFloat","()F","invokevirtual",53);}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fcmpg",a,b));f.Pc=56;continue;}
case 56:{f.Pc=f.Pop().Int>0?68:59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",64);}
case 64:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=67;continue;}
case 67:{return JStep.Return(f.Pop());}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/CardCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",74);}
case 74:{f.Locals[7]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{f.Pc=f.Pop().Int>=0?98:80;continue;}
case 80:{f.Push(f.Locals[7]);f.Pc=82;continue;}
case 82:{f.Pc=f.Pop().Int<=0?123:85;continue;}
case 85:{f.Push(f.Locals[5]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[7]);f.Pc=89;continue;}
case 89:{f.Push(JValue.I(1));f.Pc=90;continue;}
case 90:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",94);}
case 94:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=97;continue;}
case 97:{return JStep.Return(f.Pop());}
case 98:{f.Push(f.Locals[7]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",105);}
case 105:{f.Push(JValue.I(1));f.Pc=106;continue;}
case 106:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=107;continue;}
case 107:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?123:110;continue;}
case 110:{f.Push(f.Locals[5]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[7]);f.Pc=114;continue;}
case 114:{f.Push(JValue.I(1));f.Pc=115;continue;}
case 115:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",119);}
case 119:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=122;continue;}
case 122:{return JStep.Return(f.Pop());}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3413(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","isAttachedToEntity","(Lforge/game/GameEntity;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?16:8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",13);}
case 13:{f.StackOp("pop");f.Pc=14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?28:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",27);}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/Card","isPlaneswalker","()Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int!=0?56:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","isArtifact","()Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int!=0?56:42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","isEnchantment","()Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?90:49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/card/Card","isAura","()Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int!=0?90:56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/Card","isPlaneswalker","()Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int!=0?84:63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/Card","isArtifact","()Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int!=0?84:70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/Card","isEnchantment","()Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int==0?88:77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/card/Card","isAura","()Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int!=0?88:84;continue;}
case 84:{f.Push(JValue.I(1));f.Pc=85;continue;}
case 85:{f.Pc=89;continue;}
case 88:{f.Push(JValue.I(0));f.Pc=89;continue;}
case 89:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/Card","isLand","()Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?102:97;continue;}
case 97:{f.Push(f.Locals[2]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/card/Card","isLand","()Z","invokevirtual",101);}
case 101:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/Card","isAttachedToEntity","()Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?137:109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",114);}
case 114:{return rt.Call(f,"forge/game/card/Card","isAttachedToEntity","(Lforge/game/GameEntity;)Z","invokevirtual",117);}
case 117:{f.Pc=f.Pop().Int!=0?131:120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/card/Card","getAttachedTo","()Lforge/game/card/Card;","invokevirtual",125);}
case 125:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int==0?135:131;continue;}
case 131:{f.Push(JValue.I(1));f.Pc=132;continue;}
case 132:{f.Pc=136;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 137:{f.Push(f.Locals[2]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/card/Card","sharesCardTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",142);}
case 142:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3414(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","sharesCardTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3415(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/effects/FlipOntoBattlefieldEffect","boardDecidesHits","Z"))return JStep.Continue;rt.PutStatic("forge/game/ability/effects/FlipOntoBattlefieldEffect","boardDecidesHits","Z",f.Pop());f.Pc=4;continue;}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
