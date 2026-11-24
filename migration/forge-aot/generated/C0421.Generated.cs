// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C421{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/TwoPilesEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3798,"forge/game/ability/effects/TwoPilesEffect","<init>","()V",1,1,1,new JHandler[]{},M3798));
c.Add(new JMethod(3799,"forge/game/ability/effects/TwoPilesEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,4,new JHandler[]{},M3799));
c.Add(new JMethod(3800,"forge/game/ability/effects/TwoPilesEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,19,8,new JHandler[]{},M3800));
}

internal static JStep M3798(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3799(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("Separate all ")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",23);}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?35:30;continue;}
case 30:{f.Push(JValue.R(rt.String("")));f.Pc=32;continue;}
case 32:{f.Pc=54;continue;}
case 35:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",38);}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/util/Lang","describeValidList","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Push(JValue.R(rt.String(" card$")));f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",49);}
case 49:{return rt.DynamicCall(f,"forge/game/ability/effects/TwoPilesEffect:3799:49:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",54);}
case 54:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",57);}
case 57:{f.Push(JValue.R(rt.String("cards ")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/ability/effects/TwoPilesEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",68);}
case 68:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",71);}
case 71:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String(" controls into two piles.")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",81);}
case 81:{f.StackOp("pop");f.Pc=82;continue;}
case 82:{f.Push(f.Locals[2]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",86);}
case 86:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3800(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("LeftRightPile")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Zone")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?37:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("Zone")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",36);}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("Card")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Locals[6]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/ability/effects/TwoPilesEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",51);}
case 51:{f.Locals[7]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",57);}
case 57:{f.Locals[8]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("Separator")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?130:68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("Separator")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",75);}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",79);}
case 79:{f.Locals[9]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[9]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/util/collect/FCollectionView","isEmpty","()Z","invokeinterface",88);}
case 88:{f.Pc=f.Pop().Int!=0?130:91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",95);}
case 95:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",98);}
case 98:{f.Push(f.Locals[9]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(null));f.Pc=101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",105);}
case 105:{f.Push(JValue.R(rt.String("lblChooser")));f.Pc=107;continue;}
case 107:{f.Push(JValue.I(0));f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",114);}
case 114:{return rt.DynamicCall(f,"forge/game/ability/effects/TwoPilesEffect:3800:114:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",119);}
case 119:{f.Push(JValue.I(0));f.Pc=120;continue;}
case 120:{f.Push(JValue.R(null));f.Pc=121;continue;}
case 121:{f.Push(JValue.R(null));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLforge/game/player/Player;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",125);}
case 125:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=128;continue;}
case 128:{f.Locals[8]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[7]);f.Pc=132;continue;}
case 132:{f.Push(JValue.I(0));f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",138);}
case 138:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=141;continue;}
case 141:{f.Locals[9]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",149);}
case 149:{f.Pc=f.Pop().Int==0?214:152;continue;}
case 152:{f.Push(f.Locals[2]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",159);}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",163);}
case 163:{f.Locals[10]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[10]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/util/collect/FCollectionView","isEmpty","()Z","invokeinterface",172);}
case 172:{f.Pc=f.Pop().Int!=0?214:175;continue;}
case 175:{f.Push(f.Locals[1]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",179);}
case 179:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",182);}
case 182:{f.Push(f.Locals[10]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(null));f.Pc=185;continue;}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",189);}
case 189:{f.Push(JValue.R(rt.String("lblChooser")));f.Pc=191;continue;}
case 191:{f.Push(JValue.I(0));f.Pc=192;continue;}
case 192:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",198);}
case 198:{return rt.DynamicCall(f,"forge/game/ability/effects/TwoPilesEffect:3800:198:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",203);}
case 203:{f.Push(JValue.I(0));f.Pc=204;continue;}
case 204:{f.Push(JValue.R(null));f.Pc=205;continue;}
case 205:{f.Push(JValue.R(null));f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLforge/game/player/Player;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",209);}
case 209:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=212;continue;}
case 212:{f.Locals[9]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(f.Locals[7]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",221);}
case 221:{f.Locals[10]=f.Pop();f.Pc=223;continue;}
case 223:{f.Push(f.Locals[10]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",230);}
case 230:{f.Pc=f.Pop().Int==0?1128:233;continue;}
case 233:{f.Push(f.Locals[10]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",240);}
case 240:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=243;continue;}
case 243:{f.Locals[11]=f.Pop();f.Pc=245;continue;}
case 245:{f.Push(f.Locals[11]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",250);}
case 250:{f.Pc=f.Pop().Int!=0?256:253;continue;}
case 253:{f.Pc=223;continue;}
case 256:{f.Push(f.Locals[1]);f.Pc=257;continue;}
case 257:{f.Push(JValue.R(rt.String("DefinedPiles")));f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",262);}
case 262:{f.Pc=f.Pop().Int==0?304:265;continue;}
case 265:{f.Push(f.Locals[1]);f.Pc=266;continue;}
case 266:{f.Push(JValue.R(rt.String("DefinedPiles")));f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",271);}
case 271:{f.Push(JValue.R(rt.String(",")));f.Pc=273;continue;}
case 273:{f.Push(JValue.I(2));f.Pc=274;continue;}
case 274:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",277);}
case 277:{f.Locals[14]=f.Pop();f.Pc=279;continue;}
case 279:{f.Push(f.Locals[2]);f.Pc=280;continue;}
case 280:{f.Push(f.Locals[14]);f.Pc=282;continue;}
case 282:{f.Push(JValue.I(0));f.Pc=283;continue;}
case 283:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=284;continue;}
case 284:{f.Push(f.Locals[1]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",288);}
case 288:{f.Locals[12]=f.Pop();f.Pc=290;continue;}
case 290:{f.Push(f.Locals[2]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[14]);f.Pc=293;continue;}
case 293:{f.Push(JValue.I(1));f.Pc=294;continue;}
case 294:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=295;continue;}
case 295:{f.Push(f.Locals[1]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",299);}
case 299:{f.Locals[13]=f.Pop();f.Pc=301;continue;}
case 301:{f.Pc=473;continue;}
case 304:{f.Push(f.Locals[1]);f.Pc=305;continue;}
case 305:{f.Push(JValue.R(rt.String("DefinedCards")));f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",310);}
case 310:{f.Pc=f.Pop().Int==0?329:313;continue;}
case 313:{f.Push(f.Locals[2]);f.Pc=314;continue;}
case 314:{f.Push(f.Locals[1]);f.Pc=315;continue;}
case 315:{f.Push(JValue.R(rt.String("DefinedCards")));f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",320);}
case 320:{f.Push(f.Locals[1]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",324);}
case 324:{f.Locals[14]=f.Pop();f.Pc=326;continue;}
case 326:{f.Pc=337;continue;}
case 329:{f.Push(f.Locals[11]);f.Pc=331;continue;}
case 331:{f.Push(f.Locals[3]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",335);}
case 335:{f.Locals[14]=f.Pop();f.Pc=337;continue;}
case 337:{f.Push(f.Locals[14]);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[6]);f.Pc=341;continue;}
case 341:{f.Push(f.Locals[2]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",345);}
case 345:{f.Push(f.Locals[2]);f.Pc=346;continue;}
case 346:{f.Push(f.Locals[1]);f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",350);}
case 350:{f.Locals[15]=f.Pop();f.Pc=352;continue;}
case 352:{f.Push(f.Locals[15]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",357);}
case 357:{f.Locals[16]=f.Pop();f.Pc=359;continue;}
case 359:{f.Push(f.Locals[16]);f.Pc=361;continue;}
case 361:{f.Pc=f.Pop().Int!=0?365:364;continue;}
case 364:{return JStep.ReturnVoid;}
case 365:{f.Push(JValue.R(rt.String("One")));f.Pc=367;continue;}
case 367:{f.Push(f.Locals[1]);f.Pc=368;continue;}
case 368:{f.Push(JValue.R(rt.String("FaceDown")));f.Pc=370;continue;}
case 370:{f.Push(JValue.R(rt.String("False")));f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",375);}
case 375:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",378);}
case 378:{f.Pc=f.Pop().Int==0?398:381;continue;}
case 381:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",384);}
case 384:{f.Push(JValue.R(rt.String("lblSelectCardForFaceDownPile")));f.Pc=386;continue;}
case 386:{f.Push(JValue.I(0));f.Pc=387;continue;}
case 387:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=390;continue;}
case 390:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",393);}
case 393:{f.Locals[17]=f.Pop();f.Pc=395;continue;}
case 395:{f.Pc=434;continue;}
case 398:{f.Push(f.Locals[5]);f.Pc=400;continue;}
case 400:{f.Pc=f.Pop().Int==0?420:403;continue;}
case 403:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",406);}
case 406:{f.Push(JValue.R(rt.String("lblSelectCardForLeftPile")));f.Pc=408;continue;}
case 408:{f.Push(JValue.I(0));f.Pc=409;continue;}
case 409:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=412;continue;}
case 412:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",415);}
case 415:{f.Locals[17]=f.Pop();f.Pc=417;continue;}
case 417:{f.Pc=434;continue;}
case 420:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",423);}
case 423:{f.Push(JValue.R(rt.String("lblDivideCardIntoTwoPiles")));f.Pc=425;continue;}
case 425:{f.Push(JValue.I(0));f.Pc=426;continue;}
case 426:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=429;continue;}
case 429:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",432);}
case 432:{f.Locals[17]=f.Pop();f.Pc=434;continue;}
case 434:{f.Push(f.Locals[8]);f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",439);}
case 439:{f.Push(f.Locals[15]);f.Pc=441;continue;}
case 441:{f.Push(f.Locals[1]);f.Pc=442;continue;}
case 442:{f.Push(f.Locals[17]);f.Pc=444;continue;}
case 444:{f.Push(JValue.I(0));f.Pc=445;continue;}
case 445:{f.Push(f.Locals[16]);f.Pc=447;continue;}
case 447:{f.Push(JValue.I(0));f.Pc=448;continue;}
case 448:{f.Push(JValue.R(null));f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",452);}
case 452:{f.Locals[12]=f.Pop();f.Pc=454;continue;}
case 454:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=457;continue;}
case 457:{f.StackOp("dup");f.Pc=458;continue;}
case 458:{f.Push(f.Locals[15]);f.Pc=460;continue;}
case 460:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",463);}
case 463:{f.Locals[13]=f.Pop();f.Pc=465;continue;}
case 465:{f.Push(f.Locals[13]);f.Pc=467;continue;}
case 467:{f.Push(f.Locals[12]);f.Pc=469;continue;}
case 469:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",472);}
case 472:{f.StackOp("pop");f.Pc=473;continue;}
case 473:{f.Push(f.Locals[5]);f.Pc=475;continue;}
case 475:{f.Pc=f.Pop().Int==0?484:478;continue;}
case 478:{f.Push(JValue.I(1));f.Pc=479;continue;}
case 479:{f.Locals[4]=f.Pop();f.Pc=481;continue;}
case 481:{f.Pc=507;continue;}
case 484:{f.Push(f.Locals[9]);f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",489);}
case 489:{f.Push(f.Locals[1]);f.Pc=490;continue;}
case 490:{f.Push(f.Locals[12]);f.Pc=492;continue;}
case 492:{f.Push(f.Locals[13]);f.Pc=494;continue;}
case 494:{f.Push(f.Locals[1]);f.Pc=495;continue;}
case 495:{f.Push(JValue.R(rt.String("FaceDown")));f.Pc=497;continue;}
case 497:{f.Push(JValue.R(rt.String("False")));f.Pc=499;continue;}
case 499:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",502);}
case 502:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsPile","(Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;Ljava/lang/String;)Z","invokevirtual",505);}
case 505:{f.Locals[4]=f.Pop();f.Pc=507;continue;}
case 507:{f.Push(f.Locals[4]);f.Pc=509;continue;}
case 509:{f.Pc=f.Pop().Int==0?517:512;continue;}
case 512:{f.Push(f.Locals[12]);f.Pc=514;continue;}
case 514:{f.Pc=519;continue;}
case 517:{f.Push(f.Locals[13]);f.Pc=519;continue;}
case 519:{f.Locals[14]=f.Pop();f.Pc=521;continue;}
case 521:{f.Push(f.Locals[4]);f.Pc=523;continue;}
case 523:{f.Pc=f.Pop().Int!=0?531:526;continue;}
case 526:{f.Push(f.Locals[12]);f.Pc=528;continue;}
case 528:{f.Pc=533;continue;}
case 531:{f.Push(f.Locals[13]);f.Pc=533;continue;}
case 533:{f.Locals[15]=f.Pop();f.Pc=535;continue;}
case 535:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=538;continue;}
case 538:{f.StackOp("dup");f.Pc=539;continue;}
case 539:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",542);}
case 542:{f.Locals[16]=f.Pop();f.Pc=544;continue;}
case 544:{f.Push(f.Locals[5]);f.Pc=546;continue;}
case 546:{f.Pc=f.Pop().Int==0?835:549;continue;}
case 549:{f.Push(f.Locals[16]);f.Pc=551;continue;}
case 551:{f.Push(JValue.R(rt.String("\n")));f.Pc=553;continue;}
case 553:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",556);}
case 556:{f.StackOp("pop");f.Pc=557;continue;}
case 557:{f.Push(f.Locals[16]);f.Pc=559;continue;}
case 559:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",562);}
case 562:{f.Push(f.Locals[8]);f.Pc=564;continue;}
case 564:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",567);}
case 567:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",570);}
case 570:{f.Push(JValue.R(rt.String("lblLeftPile")));f.Pc=572;continue;}
case 572:{f.Push(JValue.I(0));f.Pc=573;continue;}
case 573:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=576;continue;}
case 576:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",579);}
case 579:{return rt.Call(f,"forge/util/Lang","getPossessedObject","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",582);}
case 582:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",585);}
case 585:{f.StackOp("pop");f.Pc=586;continue;}
case 586:{f.Push(f.Locals[16]);f.Pc=588;continue;}
case 588:{f.Push(JValue.R(rt.String("\n--------------------\n")));f.Pc=590;continue;}
case 590:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",593);}
case 593:{f.StackOp("pop");f.Pc=594;continue;}
case 594:{f.Push(f.Locals[14]);f.Pc=596;continue;}
case 596:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",601);}
case 601:{f.Pc=f.Pop().Int!=0?657:604;continue;}
case 604:{f.Push(f.Locals[14]);f.Pc=606;continue;}
case 606:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",611);}
case 611:{f.Locals[17]=f.Pop();f.Pc=613;continue;}
case 613:{f.Push(f.Locals[17]);f.Pc=615;continue;}
case 615:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",620);}
case 620:{f.Pc=f.Pop().Int==0?654:623;continue;}
case 623:{f.Push(f.Locals[17]);f.Pc=625;continue;}
case 625:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",630);}
case 630:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=633;continue;}
case 633:{f.Locals[18]=f.Pop();f.Pc=635;continue;}
case 635:{f.Push(f.Locals[16]);f.Pc=637;continue;}
case 637:{f.Push(f.Locals[18]);f.Pc=639;continue;}
case 639:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",642);}
case 642:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",645);}
case 645:{f.Push(JValue.R(rt.String("\n")));f.Pc=647;continue;}
case 647:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",650);}
case 650:{f.StackOp("pop");f.Pc=651;continue;}
case 651:{f.Pc=613;continue;}
case 654:{f.Pc=680;continue;}
case 657:{f.Push(f.Locals[16]);f.Pc=659;continue;}
case 659:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",662);}
case 662:{f.Push(JValue.R(rt.String("lblEmptyPile")));f.Pc=664;continue;}
case 664:{f.Push(JValue.I(0));f.Pc=665;continue;}
case 665:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=668;continue;}
case 668:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",671);}
case 671:{return rt.DynamicCall(f,"forge/game/ability/effects/TwoPilesEffect:3800:671:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",676);}
case 676:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",679);}
case 679:{f.StackOp("pop");f.Pc=680;continue;}
case 680:{f.Push(f.Locals[16]);f.Pc=682;continue;}
case 682:{f.Push(JValue.R(rt.String("\n")));f.Pc=684;continue;}
case 684:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",687);}
case 687:{f.StackOp("pop");f.Pc=688;continue;}
case 688:{f.Push(f.Locals[16]);f.Pc=690;continue;}
case 690:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",693);}
case 693:{f.Push(f.Locals[8]);f.Pc=695;continue;}
case 695:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",698);}
case 698:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",701);}
case 701:{f.Push(JValue.R(rt.String("lblRightPile")));f.Pc=703;continue;}
case 703:{f.Push(JValue.I(0));f.Pc=704;continue;}
case 704:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=707;continue;}
case 707:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",710);}
case 710:{return rt.Call(f,"forge/util/Lang","getPossessedObject","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",713);}
case 713:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",716);}
case 716:{f.StackOp("pop");f.Pc=717;continue;}
case 717:{f.Push(f.Locals[16]);f.Pc=719;continue;}
case 719:{f.Push(JValue.R(rt.String("\n--------------------\n")));f.Pc=721;continue;}
case 721:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",724);}
case 724:{f.StackOp("pop");f.Pc=725;continue;}
case 725:{f.Push(f.Locals[15]);f.Pc=727;continue;}
case 727:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",732);}
case 732:{f.Pc=f.Pop().Int!=0?788:735;continue;}
case 735:{f.Push(f.Locals[15]);f.Pc=737;continue;}
case 737:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",742);}
case 742:{f.Locals[17]=f.Pop();f.Pc=744;continue;}
case 744:{f.Push(f.Locals[17]);f.Pc=746;continue;}
case 746:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",751);}
case 751:{f.Pc=f.Pop().Int==0?785:754;continue;}
case 754:{f.Push(f.Locals[17]);f.Pc=756;continue;}
case 756:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",761);}
case 761:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=764;continue;}
case 764:{f.Locals[18]=f.Pop();f.Pc=766;continue;}
case 766:{f.Push(f.Locals[16]);f.Pc=768;continue;}
case 768:{f.Push(f.Locals[18]);f.Pc=770;continue;}
case 770:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",773);}
case 773:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",776);}
case 776:{f.Push(JValue.R(rt.String("\n")));f.Pc=778;continue;}
case 778:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",781);}
case 781:{f.StackOp("pop");f.Pc=782;continue;}
case 782:{f.Pc=744;continue;}
case 785:{f.Pc=811;continue;}
case 788:{f.Push(f.Locals[16]);f.Pc=790;continue;}
case 790:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",793);}
case 793:{f.Push(JValue.R(rt.String("lblEmptyPile")));f.Pc=795;continue;}
case 795:{f.Push(JValue.I(0));f.Pc=796;continue;}
case 796:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=799;continue;}
case 799:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",802);}
case 802:{return rt.DynamicCall(f,"forge/game/ability/effects/TwoPilesEffect:3800:802:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",807);}
case 807:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",810);}
case 810:{f.StackOp("pop");f.Pc=811;continue;}
case 811:{f.Push(f.Locals[11]);f.Pc=813;continue;}
case 813:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",816);}
case 816:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",819);}
case 819:{f.Push(f.Locals[1]);f.Pc=820;continue;}
case 820:{f.Push(f.Locals[8]);f.Pc=822;continue;}
case 822:{f.Push(f.Locals[16]);f.Pc=824;continue;}
case 824:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",827);}
case 827:{f.Push(f.Locals[8]);f.Pc=829;continue;}
case 829:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",832);}
case 832:{f.Pc=985;continue;}
case 835:{f.Push(f.Locals[16]);f.Pc=837;continue;}
case 837:{f.Push(f.Locals[9]);f.Pc=839;continue;}
case 839:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",842);}
case 842:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",845);}
case 845:{f.Push(JValue.R(rt.String("lblChoosesPile")));f.Pc=848;continue;}
case 848:{f.Push(JValue.I(0));f.Pc=849;continue;}
case 849:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=852;continue;}
case 852:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",855);}
case 855:{f.Push(f.Locals[4]);f.Pc=857;continue;}
case 857:{f.Pc=f.Pop().Int==0?866:860;continue;}
case 860:{f.Push(JValue.R(rt.String("1")));f.Pc=863;continue;}
case 863:{f.Pc=869;continue;}
case 866:{f.Push(JValue.R(rt.String("2")));f.Pc=869;continue;}
case 869:{return rt.DynamicCall(f,"forge/game/ability/effects/TwoPilesEffect:3800:869:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",874);}
case 874:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",877);}
case 877:{f.StackOp("pop");f.Pc=878;continue;}
case 878:{f.Push(f.Locals[14]);f.Pc=880;continue;}
case 880:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",885);}
case 885:{f.Pc=f.Pop().Int!=0?941:888;continue;}
case 888:{f.Push(f.Locals[14]);f.Pc=890;continue;}
case 890:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",895);}
case 895:{f.Locals[17]=f.Pop();f.Pc=897;continue;}
case 897:{f.Push(f.Locals[17]);f.Pc=899;continue;}
case 899:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",904);}
case 904:{f.Pc=f.Pop().Int==0?938:907;continue;}
case 907:{f.Push(f.Locals[17]);f.Pc=909;continue;}
case 909:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",914);}
case 914:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=917;continue;}
case 917:{f.Locals[18]=f.Pop();f.Pc=919;continue;}
case 919:{f.Push(f.Locals[16]);f.Pc=921;continue;}
case 921:{f.Push(f.Locals[18]);f.Pc=923;continue;}
case 923:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",926);}
case 926:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",929);}
case 929:{f.Push(JValue.R(rt.String("\n")));f.Pc=931;continue;}
case 931:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",934);}
case 934:{f.StackOp("pop");f.Pc=935;continue;}
case 935:{f.Pc=897;continue;}
case 938:{f.Pc=964;continue;}
case 941:{f.Push(f.Locals[16]);f.Pc=943;continue;}
case 943:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",946);}
case 946:{f.Push(JValue.R(rt.String("lblEmptyPile")));f.Pc=948;continue;}
case 948:{f.Push(JValue.I(0));f.Pc=949;continue;}
case 949:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=952;continue;}
case 952:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",955);}
case 955:{return rt.DynamicCall(f,"forge/game/ability/effects/TwoPilesEffect:3800:955:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",960);}
case 960:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",963);}
case 963:{f.StackOp("pop");f.Pc=964;continue;}
case 964:{f.Push(f.Locals[11]);f.Pc=966;continue;}
case 966:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",969);}
case 969:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",972);}
case 972:{f.Push(f.Locals[1]);f.Pc=973;continue;}
case 973:{f.Push(f.Locals[9]);f.Pc=975;continue;}
case 975:{f.Push(f.Locals[16]);f.Pc=977;continue;}
case 977:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",980);}
case 980:{f.Push(f.Locals[9]);f.Pc=982;continue;}
case 982:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",985);}
case 985:{f.Push(f.Locals[1]);f.Pc=986;continue;}
case 986:{f.Push(JValue.R(rt.String("RememberChosen")));f.Pc=989;continue;}
case 989:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",992);}
case 992:{f.Pc=f.Pop().Int==0?1001:995;continue;}
case 995:{f.Push(f.Locals[2]);f.Pc=996;continue;}
case 996:{f.Push(f.Locals[14]);f.Pc=998;continue;}
case 998:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1001);}
case 1001:{f.Push(f.Locals[1]);f.Pc=1002;continue;}
case 1002:{f.Push(JValue.R(rt.String("ChosenPile")));f.Pc=1005;continue;}
case 1005:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1008);}
case 1008:{f.Pc=f.Pop().Int==0?1063:1011;continue;}
case 1011:{f.Push(f.Locals[2]);f.Pc=1012;continue;}
case 1012:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",1015);}
case 1015:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",1018);}
case 1018:{f.Locals[17]=f.Pop();f.Pc=1020;continue;}
case 1020:{f.Push(f.Locals[2]);f.Pc=1021;continue;}
case 1021:{f.Push(f.Locals[17]);f.Pc=1023;continue;}
case 1023:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1026);}
case 1026:{f.Push(f.Locals[2]);f.Pc=1027;continue;}
case 1027:{f.Push(f.Locals[14]);f.Pc=1029;continue;}
case 1029:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1032);}
case 1032:{f.Push(f.Locals[1]);f.Pc=1033;continue;}
case 1033:{f.Push(JValue.R(rt.String("ChosenPile")));f.Pc=1036;continue;}
case 1036:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",1039);}
case 1039:{f.Locals[18]=f.Pop();f.Pc=1041;continue;}
case 1041:{f.Push(f.Locals[18]);f.Pc=1043;continue;}
case 1043:{f.Pc=f.Pop().Reference==null?1051:1046;continue;}
case 1046:{f.Push(f.Locals[18]);f.Pc=1048;continue;}
case 1048:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",1051);}
case 1051:{f.Push(f.Locals[2]);f.Pc=1052;continue;}
case 1052:{f.Push(f.Locals[14]);f.Pc=1054;continue;}
case 1054:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1057);}
case 1057:{f.Push(f.Locals[2]);f.Pc=1058;continue;}
case 1058:{f.Push(f.Locals[17]);f.Pc=1060;continue;}
case 1060:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1063);}
case 1063:{f.Push(f.Locals[1]);f.Pc=1064;continue;}
case 1064:{f.Push(JValue.R(rt.String("UnchosenPile")));f.Pc=1067;continue;}
case 1067:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1070);}
case 1070:{f.Pc=f.Pop().Int==0?1125:1073;continue;}
case 1073:{f.Push(f.Locals[2]);f.Pc=1074;continue;}
case 1074:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",1077);}
case 1077:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",1080);}
case 1080:{f.Locals[17]=f.Pop();f.Pc=1082;continue;}
case 1082:{f.Push(f.Locals[2]);f.Pc=1083;continue;}
case 1083:{f.Push(f.Locals[17]);f.Pc=1085;continue;}
case 1085:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1088);}
case 1088:{f.Push(f.Locals[2]);f.Pc=1089;continue;}
case 1089:{f.Push(f.Locals[15]);f.Pc=1091;continue;}
case 1091:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1094);}
case 1094:{f.Push(f.Locals[1]);f.Pc=1095;continue;}
case 1095:{f.Push(JValue.R(rt.String("UnchosenPile")));f.Pc=1098;continue;}
case 1098:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",1101);}
case 1101:{f.Locals[18]=f.Pop();f.Pc=1103;continue;}
case 1103:{f.Push(f.Locals[18]);f.Pc=1105;continue;}
case 1105:{f.Pc=f.Pop().Reference==null?1113:1108;continue;}
case 1108:{f.Push(f.Locals[18]);f.Pc=1110;continue;}
case 1110:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",1113);}
case 1113:{f.Push(f.Locals[2]);f.Pc=1114;continue;}
case 1114:{f.Push(f.Locals[15]);f.Pc=1116;continue;}
case 1116:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1119);}
case 1119:{f.Push(f.Locals[2]);f.Pc=1120;continue;}
case 1120:{f.Push(f.Locals[17]);f.Pc=1122;continue;}
case 1122:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1125);}
case 1125:{f.Pc=223;continue;}
case 1128:{f.Push(f.Locals[1]);f.Pc=1129;continue;}
case 1129:{f.Push(JValue.R(rt.String("KeepRemembered")));f.Pc=1132;continue;}
case 1132:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1135);}
case 1135:{f.Pc=f.Pop().Int!=0?1152:1138;continue;}
case 1138:{f.Push(f.Locals[1]);f.Pc=1139;continue;}
case 1139:{f.Push(JValue.R(rt.String("RememberChosen")));f.Pc=1142;continue;}
case 1142:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1145);}
case 1145:{f.Pc=f.Pop().Int!=0?1152:1148;continue;}
case 1148:{f.Push(f.Locals[2]);f.Pc=1149;continue;}
case 1149:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",1152);}
case 1152:{f.Push(f.Locals[2]);f.Pc=1153;continue;}
case 1153:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",1156);}
case 1156:{return rt.Call(f,"forge/game/Game","incPiledGuessedSA","()V","invokevirtual",1159);}
case 1159:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
