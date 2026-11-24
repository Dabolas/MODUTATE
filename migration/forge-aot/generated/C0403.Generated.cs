// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C403{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/StoreSVarEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3736,"forge/game/ability/effects/StoreSVarEffect","<init>","()V",1,1,1,new JHandler[]{},M3736));
c.Add(new JMethod(3737,"forge/game/ability/effects/StoreSVarEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,9,4,new JHandler[]{},M3737));
}

internal static JStep M3736(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3737(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{f.Locals[5]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("SVar")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?63:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("SVar")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",28);}
case 28:{f.Push(JValue.R(rt.String("EachPlayer")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?56:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("Remembered")));f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",43);}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/player/Player","toString","()Ljava/lang/String;","invokevirtual",53);}
case 53:{f.Pc=62;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("SVar")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",62);}
case 62:{f.Locals[3]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("Type")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?80:72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("Type")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",78);}
case 78:{f.Locals[4]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.String("Expression")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int==0?97:89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("Expression")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",95);}
case 95:{f.Locals[5]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{f.Pc=f.Pop().Reference==null?111:101;continue;}
case 101:{f.Push(f.Locals[4]);f.Pc=103;continue;}
case 103:{f.Pc=f.Pop().Reference==null?111:106;continue;}
case 106:{f.Push(f.Locals[5]);f.Pc=108;continue;}
case 108:{f.Pc=f.Pop().Reference!=null?127:111;continue;}
case 111:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",118);}
case 118:{return rt.DynamicCall(f,"forge/game/ability/effects/StoreSVarEffect:3737:118:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",123);}
case 123:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",126);}
case 126:{return JStep.ReturnVoid;}
case 127:{f.Push(JValue.I(0));f.Pc=128;continue;}
case 128:{f.Locals[6]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[4]);f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.String("Count")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",137);}
case 137:{f.Pc=f.Pop().Int==0?152:140;continue;}
case 140:{f.Push(f.Locals[2]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[5]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/ability/AbilityUtils","xCount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",147);}
case 147:{f.Locals[6]=f.Pop();f.Pc=149;continue;}
case 149:{f.Pc=383;continue;}
case 152:{f.Push(f.Locals[4]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("Number")));f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",159);}
case 159:{f.Pc=f.Pop().Int==0?172:162;continue;}
case 162:{f.Push(f.Locals[5]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",167);}
case 167:{f.Locals[6]=f.Pop();f.Pc=169;continue;}
case 169:{f.Pc=383;continue;}
case 172:{f.Push(f.Locals[4]);f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("CountSVar")));f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",179);}
case 179:{f.Pc=f.Pop().Int==0?250:182;continue;}
case 182:{f.Push(f.Locals[5]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("/")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",189);}
case 189:{f.Pc=f.Pop().Int==0?233:192;continue;}
case 192:{f.Push(f.Locals[5]);f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("\\/")));f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",199);}
case 199:{f.Push(JValue.I(1));f.Pc=200;continue;}
case 200:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=201;continue;}
case 201:{f.Push(JValue.R(rt.String("\\.")));f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",206);}
case 206:{f.Push(JValue.I(1));f.Pc=207;continue;}
case 207:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=208;continue;}
case 208:{f.Locals[7]=f.Pop();f.Pc=210;continue;}
case 210:{f.Push(f.Locals[2]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[7]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[1]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",217);}
case 217:{f.Locals[8]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[5]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[7]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[8]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",228);}
case 228:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",231);}
case 231:{f.Locals[5]=f.Pop();f.Pc=233;continue;}
case 233:{f.Push(f.Locals[2]);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[5]);f.Pc=236;continue;}
case 236:{return rt.DynamicCall(f,"forge/game/ability/effects/StoreSVarEffect:3737:236:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",241);}
case 241:{f.Push(f.Locals[1]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/ability/AbilityUtils","xCount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",245);}
case 245:{f.Locals[6]=f.Pop();f.Pc=247;continue;}
case 247:{f.Pc=383;continue;}
case 250:{f.Push(f.Locals[4]);f.Pc=252;continue;}
case 252:{f.Push(JValue.R(rt.String("Targeted")));f.Pc=254;continue;}
case 254:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",257);}
case 257:{f.Pc=f.Pop().Int==0?276:260;continue;}
case 260:{f.Push(f.Locals[1]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/spellability/SpellAbility","findTargetedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",264);}
case 264:{f.Push(f.Locals[5]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[2]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[1]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/ability/AbilityUtils","handlePaid","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;)I","invokestatic",271);}
case 271:{f.Locals[6]=f.Pop();f.Pc=273;continue;}
case 273:{f.Pc=383;continue;}
case 276:{f.Push(f.Locals[4]);f.Pc=278;continue;}
case 278:{f.Push(JValue.R(rt.String("Triggered")));f.Pc=280;continue;}
case 280:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",283);}
case 283:{f.Pc=f.Pop().Int==0?311:286;continue;}
case 286:{f.Push(f.Locals[1]);f.Pc=287;continue;}
case 287:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",293);}
case 293:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=296;continue;}
case 296:{f.Locals[7]=f.Pop();f.Pc=298;continue;}
case 298:{f.Push(f.Locals[7]);f.Pc=300;continue;}
case 300:{f.Push(f.Locals[5]);f.Pc=302;continue;}
case 302:{f.Push(f.Locals[1]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/ability/AbilityUtils","xCount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",306);}
case 306:{f.Locals[6]=f.Pop();f.Pc=308;continue;}
case 308:{f.Pc=383;continue;}
case 311:{f.Push(f.Locals[4]);f.Pc=313;continue;}
case 313:{f.Push(JValue.R(rt.String("Calculate")));f.Pc=315;continue;}
case 315:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",318);}
case 318:{f.Pc=f.Pop().Int==0?333:321;continue;}
case 321:{f.Push(f.Locals[2]);f.Pc=322;continue;}
case 322:{f.Push(f.Locals[5]);f.Pc=324;continue;}
case 324:{f.Push(f.Locals[1]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",328);}
case 328:{f.Locals[6]=f.Pop();f.Pc=330;continue;}
case 330:{f.Pc=383;continue;}
case 333:{f.Push(f.Locals[4]);f.Pc=335;continue;}
case 335:{f.Push(JValue.R(rt.String("AdditiveForEach")));f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",340);}
case 340:{f.Pc=f.Pop().Int==0?383:343;continue;}
case 343:{f.Push(f.Locals[2]);f.Pc=344;continue;}
case 344:{f.Push(f.Locals[3]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/card/Card","hasSVar","(Ljava/lang/String;)Z","invokevirtual",348);}
case 348:{f.Pc=f.Pop().Int==0?364:351;continue;}
case 351:{f.Push(f.Locals[2]);f.Pc=352;continue;}
case 352:{f.Push(f.Locals[2]);f.Pc=353;continue;}
case 353:{f.Push(f.Locals[3]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",357);}
case 357:{f.Push(f.Locals[1]);f.Pc=358;continue;}
case 358:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",361);}
case 361:{f.Pc=365;continue;}
case 364:{f.Push(JValue.I(0));f.Pc=365;continue;}
case 365:{f.Locals[7]=f.Pop();f.Pc=367;continue;}
case 367:{f.Push(f.Locals[2]);f.Pc=368;continue;}
case 368:{f.Push(f.Locals[5]);f.Pc=370;continue;}
case 370:{f.Push(f.Locals[1]);f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",374);}
case 374:{f.Locals[8]=f.Pop();f.Pc=376;continue;}
case 376:{f.Push(f.Locals[7]);f.Pc=378;continue;}
case 378:{f.Push(f.Locals[8]);f.Pc=380;continue;}
case 380:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=381;continue;}
case 381:{f.Locals[6]=f.Pop();f.Pc=383;continue;}
case 383:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=386;continue;}
case 386:{f.StackOp("dup");f.Pc=387;continue;}
case 387:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",390);}
case 390:{f.Locals[7]=f.Pop();f.Pc=392;continue;}
case 392:{f.Push(f.Locals[7]);f.Pc=394;continue;}
case 394:{f.Push(JValue.R(rt.String("Number$")));f.Pc=396;continue;}
case 396:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",399);}
case 399:{f.StackOp("pop");f.Pc=400;continue;}
case 400:{f.Push(f.Locals[7]);f.Pc=402;continue;}
case 402:{f.Push(f.Locals[6]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",407);}
case 407:{f.StackOp("pop");f.Pc=408;continue;}
case 408:{f.Push(f.Locals[2]);f.Pc=409;continue;}
case 409:{f.Push(f.Locals[3]);f.Pc=410;continue;}
case 410:{f.Push(f.Locals[7]);f.Pc=412;continue;}
case 412:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",415);}
case 415:{return rt.Call(f,"forge/game/card/Card","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",418);}
case 418:{f.Push(f.Locals[1]);f.Pc=419;continue;}
case 419:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",422);}
case 422:{f.Locals[8]=f.Pop();f.Pc=424;continue;}
case 424:{f.Push(f.Locals[8]);f.Pc=426;continue;}
case 426:{f.Pc=f.Pop().Reference==null?450:429;continue;}
case 429:{f.Push(f.Locals[8]);f.Pc=431;continue;}
case 431:{f.Push(f.Locals[3]);f.Pc=432;continue;}
case 432:{f.Push(f.Locals[7]);f.Pc=434;continue;}
case 434:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",437);}
case 437:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",440);}
case 440:{f.Push(f.Locals[8]);f.Pc=442;continue;}
case 442:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",445);}
case 445:{f.Locals[8]=f.Pop();f.Pc=447;continue;}
case 447:{f.Pc=424;continue;}
case 450:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
