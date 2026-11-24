// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C348{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/PhasesEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3538,"forge/game/ability/effects/PhasesEffect","<init>","()V",1,1,1,new JHandler[]{},M3538));
c.Add(new JMethod(3539,"forge/game/ability/effects/PhasesEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,4,new JHandler[]{},M3539));
c.Add(new JMethod(3540,"forge/game/ability/effects/PhasesEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,13,8,new JHandler[]{},M3540));
c.Add(new JMethod(3541,"forge/game/ability/effects/PhasesEffect","lambda$getStackDescription$0","(Ljava/lang/String;)Ljava/lang/String;",4106,1,4,new JHandler[]{},M3541));
}

internal static JStep M3538(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3539(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/PhasesEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?75:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("AllValid")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?64:32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("AllValid")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",38);}
case 38:{f.Push(JValue.R(rt.String(",")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",43);}
case 43:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",46);}
case 46:{return rt.DynamicCall(f,"forge/game/ability/effects/PhasesEffect:3539:46:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",51);}
case 51:{f.Push(JValue.R(rt.String("and")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",56);}
case 56:{return rt.DynamicCall(f,"forge/game/ability/effects/PhasesEffect:3539:56:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",61);}
case 61:{f.Pc=66;continue;}
case 64:{f.Push(JValue.R(rt.String("It phases out.")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",74);}
case 74:{return JStep.Return(f.Pop());}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",80);}
case 80:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",91);}
case 91:{f.Push(JValue.I(1));f.Pc=92;continue;}
case 92:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?100:95;continue;}
case 95:{f.Push(JValue.R(rt.String(" phases out.")));f.Pc=97;continue;}
case 97:{f.Pc=102;continue;}
case 100:{f.Push(JValue.R(rt.String(" phase out.")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",105);}
case 105:{f.StackOp("pop");f.Pc=106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",110);}
case 110:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3540(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",15);}
case 15:{f.Locals[5]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("PhaseInOrOut")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",23);}
case 23:{f.Locals[6]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("WontPhaseInNormal")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",31);}
case 31:{f.Locals[7]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("AllValid")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int==0?83:42;continue;}
case 42:{f.Push(f.Locals[6]);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Int==0?59:47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/Game","getCardsIncludePhasingIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",55);}
case 55:{f.Locals[2]=f.Pop();f.Pc=56;continue;}
case 56:{f.Pc=68;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",67);}
case 67:{f.Locals[2]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("AllValid")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",75);}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",79);}
case 79:{f.Locals[2]=f.Pop();f.Pc=80;continue;}
case 80:{f.Pc=88;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/ability/effects/PhasesEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",87);}
case 87:{f.Locals[2]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("AnyNumber")));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?128:97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",101);}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",106);}
case 106:{f.Push(JValue.R(rt.String("lblChooseAnyNumberToPhase")));f.Pc=108;continue;}
case 108:{f.Push(JValue.I(0));f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",115);}
case 115:{f.Push(JValue.I(0));f.Pc=116;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",122);}
case 122:{f.Push(JValue.I(1));f.Pc=123;continue;}
case 123:{f.Push(JValue.R(null));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",127);}
case 127:{f.Locals[2]=f.Pop();f.Pc=128;continue;}
case 128:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=131;continue;}
case 131:{f.StackOp("dup");f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",135);}
case 135:{f.Locals[8]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[6]);f.Pc=139;continue;}
case 139:{f.Pc=f.Pop().Int==0?364:142;continue;}
case 142:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=145;continue;}
case 145:{f.StackOp("dup");f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",149);}
case 149:{f.Locals[9]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[2]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",157);}
case 157:{f.Locals[10]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[10]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",166);}
case 166:{f.Pc=f.Pop().Int==0?230:169;continue;}
case 169:{f.Push(f.Locals[10]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",176);}
case 176:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=179;continue;}
case 179:{f.Locals[11]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[11]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",186);}
case 186:{f.Pc=f.Pop().Int==0?200:189;continue;}
case 189:{f.Push(f.Locals[11]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantPhase","cantPhaseIn","(Lforge/game/card/Card;)Z","invokestatic",194);}
case 194:{f.Pc=f.Pop().Int==0?200:197;continue;}
case 197:{f.Pc=159;continue;}
case 200:{f.Push(f.Locals[11]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",205);}
case 205:{f.Pc=f.Pop().Int!=0?219:208;continue;}
case 208:{f.Push(f.Locals[11]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantPhase","cantPhaseOut","(Lforge/game/card/Card;)Z","invokestatic",213);}
case 213:{f.Pc=f.Pop().Int==0?219:216;continue;}
case 216:{f.Pc=159;continue;}
case 219:{f.Push(f.Locals[9]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[11]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",226);}
case 226:{f.StackOp("pop");f.Pc=227;continue;}
case 227:{f.Pc=159;continue;}
case 230:{f.Push(f.Locals[9]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",235);}
case 235:{f.Locals[10]=f.Pop();f.Pc=237;continue;}
case 237:{f.Push(f.Locals[10]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",244);}
case 244:{f.Pc=f.Pop().Int==0?361:247;continue;}
case 247:{f.Push(f.Locals[10]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",254);}
case 254:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=257;continue;}
case 257:{f.Locals[11]=f.Pop();f.Pc=259;continue;}
case 259:{f.Push(f.Locals[4]);f.Pc=261;continue;}
case 261:{f.Push(f.Locals[11]);f.Pc=263;continue;}
case 263:{f.Push(JValue.R(null));f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",267);}
case 267:{f.Locals[12]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(f.Locals[12]);f.Pc=271;continue;}
case 271:{f.Pc=f.Pop().Reference==null?237:274;continue;}
case 274:{f.Push(f.Locals[11]);f.Pc=276;continue;}
case 276:{f.Push(f.Locals[12]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",281);}
case 281:{f.Pc=f.Pop().Int!=0?287:284;continue;}
case 284:{f.Pc=237;continue;}
case 287:{f.Push(f.Locals[12]);f.Pc=289;continue;}
case 289:{f.Push(JValue.I(0));f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/card/Card","phase","(Z)V","invokevirtual",293);}
case 293:{f.Push(f.Locals[12]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",298);}
case 298:{f.Pc=f.Pop().Int==0?319:301;continue;}
case 301:{f.Push(f.Locals[8]);f.Pc=303;continue;}
case 303:{f.Push(f.Locals[12]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",308);}
case 308:{f.StackOp("pop");f.Pc=309;continue;}
case 309:{f.Push(f.Locals[12]);f.Pc=311;continue;}
case 311:{f.Push(f.Locals[7]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/game/card/Card","setWontPhaseInNormal","(Z)V","invokevirtual",316);}
case 316:{f.Pc=358;continue;}
case 319:{f.Push(f.Locals[1]);f.Pc=320;continue;}
case 320:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=322;continue;}
case 322:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",325);}
case 325:{f.Pc=f.Pop().Int==0?337:328;continue;}
case 328:{f.Push(f.Locals[12]);f.Pc=330;continue;}
case 330:{f.Push(JValue.I(1));f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",334);}
case 334:{f.Pc=352;continue;}
case 337:{f.Push(f.Locals[1]);f.Pc=338;continue;}
case 338:{f.Push(JValue.R(rt.String("Untapped")));f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",343);}
case 343:{f.Pc=f.Pop().Int==0?352:346;continue;}
case 346:{f.Push(f.Locals[12]);f.Pc=348;continue;}
case 348:{f.Push(JValue.I(0));f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",352);}
case 352:{f.Push(f.Locals[12]);f.Pc=354;continue;}
case 354:{f.Push(JValue.I(0));f.Pc=355;continue;}
case 355:{return rt.Call(f,"forge/game/card/Card","setWontPhaseInNormal","(Z)V","invokevirtual",358);}
case 358:{f.Pc=237;continue;}
case 361:{f.Pc=486;continue;}
case 364:{f.Push(f.Locals[2]);f.Pc=365;continue;}
case 365:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",370);}
case 370:{f.Locals[9]=f.Pop();f.Pc=372;continue;}
case 372:{f.Push(f.Locals[9]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",379);}
case 379:{f.Pc=f.Pop().Int==0?486:382;continue;}
case 382:{f.Push(f.Locals[9]);f.Pc=384;continue;}
case 384:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",389);}
case 389:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=392;continue;}
case 392:{f.Locals[10]=f.Pop();f.Pc=394;continue;}
case 394:{f.Push(f.Locals[4]);f.Pc=396;continue;}
case 396:{f.Push(f.Locals[10]);f.Pc=398;continue;}
case 398:{f.Push(JValue.R(null));f.Pc=399;continue;}
case 399:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",402);}
case 402:{f.Locals[11]=f.Pop();f.Pc=404;continue;}
case 404:{f.Push(f.Locals[11]);f.Pc=406;continue;}
case 406:{f.Pc=f.Pop().Reference==null?372:409;continue;}
case 409:{f.Push(f.Locals[10]);f.Pc=411;continue;}
case 411:{f.Push(f.Locals[11]);f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",416);}
case 416:{f.Pc=f.Pop().Int!=0?422:419;continue;}
case 419:{f.Pc=372;continue;}
case 422:{f.Push(f.Locals[11]);f.Pc=424;continue;}
case 424:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",427);}
case 427:{f.Pc=f.Pop().Int!=0?483:430;continue;}
case 430:{f.Push(f.Locals[11]);f.Pc=432;continue;}
case 432:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantPhase","cantPhaseOut","(Lforge/game/card/Card;)Z","invokestatic",435);}
case 435:{f.Pc=f.Pop().Int!=0?483:438;continue;}
case 438:{f.Push(f.Locals[11]);f.Pc=440;continue;}
case 440:{f.Push(JValue.I(0));f.Pc=441;continue;}
case 441:{return rt.Call(f,"forge/game/card/Card","phase","(Z)V","invokevirtual",444);}
case 444:{f.Push(f.Locals[11]);f.Pc=446;continue;}
case 446:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",449);}
case 449:{f.Pc=f.Pop().Int==0?483:452;continue;}
case 452:{f.Push(f.Locals[1]);f.Pc=453;continue;}
case 453:{f.Push(JValue.R(rt.String("RememberAffected")));f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",458);}
case 458:{f.Pc=f.Pop().Int==0?468:461;continue;}
case 461:{f.Push(f.Locals[5]);f.Pc=463;continue;}
case 463:{f.Push(f.Locals[11]);f.Pc=465;continue;}
case 465:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",468);}
case 468:{f.Push(f.Locals[8]);f.Pc=470;continue;}
case 470:{f.Push(f.Locals[11]);f.Pc=472;continue;}
case 472:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",475);}
case 475:{f.StackOp("pop");f.Pc=476;continue;}
case 476:{f.Push(f.Locals[11]);f.Pc=478;continue;}
case 478:{f.Push(f.Locals[7]);f.Pc=480;continue;}
case 480:{return rt.Call(f,"forge/game/card/Card","setWontPhaseInNormal","(Z)V","invokevirtual",483);}
case 483:{f.Pc=372;continue;}
case 486:{f.Push(f.Locals[1]);f.Pc=487;continue;}
case 487:{f.Push(JValue.R(rt.String("RememberValids")));f.Pc=489;continue;}
case 489:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",492);}
case 492:{f.Pc=f.Pop().Int==0?501:495;continue;}
case 495:{f.Push(f.Locals[5]);f.Pc=497;continue;}
case 497:{f.Push(f.Locals[2]);f.Pc=498;continue;}
case 498:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",501);}
case 501:{f.Push(f.Locals[8]);f.Pc=503;continue;}
case 503:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",506);}
case 506:{f.Pc=f.Pop().Int!=0?541:509;continue;}
case 509:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",512);}
case 512:{f.Locals[9]=f.Pop();f.Pc=514;continue;}
case 514:{f.Push(f.Locals[9]);f.Pc=516;continue;}
case 516:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=519;continue;}
case 519:{f.Push(f.Locals[8]);f.Pc=521;continue;}
case 521:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",526);}
case 526:{f.StackOp("pop");f.Pc=527;continue;}
case 527:{f.Push(f.Locals[4]);f.Pc=529;continue;}
case 529:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",532);}
case 532:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","PhaseOutAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","PhaseOutAll","Lforge/game/trigger/TriggerType;"));f.Pc=535;continue;}
case 535:{f.Push(f.Locals[9]);f.Pc=537;continue;}
case 537:{f.Push(JValue.I(0));f.Pc=538;continue;}
case 538:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",541);}
case 541:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3541(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;ZZ)Ljava/lang/String;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
