// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C330{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ManaEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3485,"forge/game/ability/effects/ManaEffect","<init>","()V",1,1,1,new JHandler[]{},M3485));
c.Add(new JMethod(3486,"forge/game/ability/effects/ManaEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V",1,2,5,new JHandler[]{},M3486));
c.Add(new JMethod(3487,"forge/game/ability/effects/ManaEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,29,6,new JHandler[]{},M3487));
c.Add(new JMethod(3488,"forge/game/ability/effects/ManaEffect","handleSpecialMana","(Lforge/game/player/Player;Lforge/game/spellability/AbilityManaPart;Lforge/game/spellability/SpellAbility;Z)V",9,14,7,new JHandler[]{},M3488));
c.Add(new JMethod(3489,"forge/game/ability/effects/ManaEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,8,6,new JHandler[]{},M3489));
}

internal static JStep M3485(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3486(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AbilityManaPart"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AbilityManaPart")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","<init>","(Lforge/game/spellability/SpellAbility;Ljava/util/Map;)V","invokespecial",18);}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","setManaPart","(Lforge/game/spellability/AbilityManaPart;)V","invokevirtual",21);}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Reference!=null?33:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","setUndoable","(Z)V","invokevirtual",33);}
case 33:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3487(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getManaPart","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/ability/effects/ManaEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",20);}
case 20:{f.Locals[5]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",26);}
case 26:{f.Locals[6]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?67:36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","isUndoable","()Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?67:43;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",50);}
case 50:{f.Push(JValue.I(2));f.Pc=51;continue;}
case 51:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?67:54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("ActivationLimit")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int!=0?67:63;continue;}
case 63:{f.Push(JValue.I(1));f.Pc=64;continue;}
case 64:{f.Pc=68;continue;}
case 67:{f.Push(JValue.I(0));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/spellability/SpellAbility","setUndoable","(Z)V","invokevirtual",71);}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("Optional")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int==0?107:80;continue;}
case 80:{f.Push(f.Locals[6]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",85);}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(null));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",90);}
case 90:{f.Push(JValue.R(rt.String("lblDoYouWantAddMana")));f.Pc=92;continue;}
case 92:{f.Push(JValue.I(0));f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",99);}
case 99:{f.Push(JValue.R(null));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",103);}
case 103:{f.Pc=f.Pop().Int!=0?107:106;continue;}
case 106:{return JStep.ReturnVoid;}
case 107:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=110;continue;}
case 110:{f.StackOp("dup");f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",114);}
case 114:{f.Locals[7]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[5]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",123);}
case 123:{f.Locals[8]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[8]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",132);}
case 132:{f.Pc=f.Pop().Int==0?1104:135;continue;}
case 135:{f.Push(f.Locals[8]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",142);}
case 142:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=145;continue;}
case 145:{f.Locals[9]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[9]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",152);}
case 152:{f.Pc=f.Pop().Int!=0?158:155;continue;}
case 155:{f.Pc=125;continue;}
case 158:{f.Push(f.Locals[1]);f.Pc=159;continue;}
case 159:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Int==0?190:167;continue;}
case 167:{f.Push(f.Locals[2]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[1]);f.Pc=169;continue;}
case 169:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",174);}
case 174:{f.Push(f.Locals[1]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",178);}
case 178:{f.Push(JValue.I(0));f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",182);}
case 182:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=185;continue;}
case 185:{f.Locals[10]=f.Pop();f.Pc=187;continue;}
case 187:{f.Pc=194;continue;}
case 190:{f.Push(f.Locals[9]);f.Pc=192;continue;}
case 192:{f.Locals[10]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[4]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isComboMana","()Z","invokevirtual",199);}
case 199:{f.Pc=f.Pop().Int==0?852:202;continue;}
case 202:{f.Push(f.Locals[1]);f.Pc=203;continue;}
case 203:{f.Push(JValue.R(rt.String("Amount")));f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",208);}
case 208:{f.Pc=f.Pop().Int==0?225:211;continue;}
case 211:{f.Push(f.Locals[2]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[1]);f.Pc=213;continue;}
case 213:{f.Push(JValue.R(rt.String("Amount")));f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",218);}
case 218:{f.Push(f.Locals[1]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",222);}
case 222:{f.Pc=226;continue;}
case 225:{f.Push(JValue.I(1));f.Pc=226;continue;}
case 226:{f.Locals[11]=f.Pop();f.Pc=228;continue;}
case 228:{f.Push(f.Locals[1]);f.Pc=229;continue;}
case 229:{f.Push(JValue.R(rt.String("Each")));f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",234);}
case 234:{f.Pc=f.Pop().Int==0?251:237;continue;}
case 237:{f.Push(f.Locals[2]);f.Pc=238;continue;}
case 238:{f.Push(f.Locals[1]);f.Pc=239;continue;}
case 239:{f.Push(JValue.R(rt.String("Each")));f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",244);}
case 244:{f.Push(f.Locals[1]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",248);}
case 248:{f.Pc=252;continue;}
case 251:{f.Push(JValue.I(1));f.Pc=252;continue;}
case 252:{f.Locals[12]=f.Pop();f.Pc=254;continue;}
case 254:{f.Push(f.Locals[11]);f.Pc=256;continue;}
case 256:{f.Pc=f.Pop().Int<=0?125:259;continue;}
case 259:{f.Push(f.Locals[12]);f.Pc=261;continue;}
case 261:{f.Pc=f.Pop().Int>0?267:264;continue;}
case 264:{f.Pc=125;continue;}
case 267:{f.Push(f.Locals[4]);f.Pc=269;continue;}
case 269:{f.Push(f.Locals[1]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getComboColors","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",273);}
case 273:{f.Locals[13]=f.Pop();f.Pc=275;continue;}
case 275:{f.Push(f.Locals[13]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"java/lang/String","isBlank","()Z","invokevirtual",280);}
case 280:{f.Pc=f.Pop().Int==0?284:283;continue;}
case 283:{return JStep.ReturnVoid;}
case 284:{f.Push(f.Locals[13]);f.Pc=286;continue;}
case 286:{f.Push(JValue.R(rt.String(" ")));f.Pc=288;continue;}
case 288:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",291);}
case 291:{f.Locals[14]=f.Pop();f.Pc=293;continue;}
case 293:{f.Push(f.Locals[14]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",298);}
case 298:{f.Locals[15]=f.Pop();f.Pc=300;continue;}
case 300:{f.Push(f.Locals[4]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getExpressChoice","()Ljava/lang/String;","invokevirtual",305);}
case 305:{f.Locals[16]=f.Pop();f.Pc=307;continue;}
case 307:{f.Push(f.Locals[16]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",312);}
case 312:{f.Pc=f.Pop().Int==0?319:315;continue;}
case 315:{f.Push(JValue.R(null));f.Pc=316;continue;}
case 316:{f.Pc=326;continue;}
case 319:{f.Push(f.Locals[16]);f.Pc=321;continue;}
case 321:{f.Push(JValue.R(rt.String(" ")));f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",326);}
case 326:{f.Locals[17]=f.Pop();f.Pc=328;continue;}
case 328:{f.Push(f.Locals[4]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getOrigProduced","()Ljava/lang/String;","invokevirtual",333);}
case 333:{f.Push(JValue.R(rt.String("Different")));f.Pc=335;continue;}
case 335:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",338);}
case 338:{f.Locals[18]=f.Pop();f.Pc=340;continue;}
case 340:{f.Push(f.Locals[15]);f.Pc=342;continue;}
case 342:{f.Locals[19]=f.Pop();f.Pc=344;continue;}
case 344:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=347;continue;}
case 347:{f.StackOp("dup");f.Pc=348;continue;}
case 348:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",351);}
case 351:{f.Locals[20]=f.Pop();f.Pc=353;continue;}
case 353:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=356;continue;}
case 356:{f.StackOp("dup");f.Pc=357;continue;}
case 357:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",360);}
case 360:{f.Locals[21]=f.Pop();f.Pc=362;continue;}
case 362:{f.Push(f.Locals[17]);f.Pc=364;continue;}
case 364:{f.Pc=f.Pop().Reference!=null?540:367;continue;}
case 367:{f.Push(f.Locals[11]);f.Pc=369;continue;}
case 369:{f.Push(JValue.I(1));f.Pc=370;continue;}
case 370:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?540:373;continue;}
case 373:{f.Push(f.Locals[1]);f.Pc=374;continue;}
case 374:{f.Push(JValue.R(rt.String("Each")));f.Pc=376;continue;}
case 376:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",379);}
case 379:{f.Pc=f.Pop().Int!=0?540:382;continue;}
case 382:{f.Push(f.Locals[10]);f.Pc=384;continue;}
case 384:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",387);}
case 387:{f.Push(f.Locals[1]);f.Pc=388;continue;}
case 388:{f.Push(f.Locals[15]);f.Pc=390;continue;}
case 390:{f.Push(f.Locals[11]);f.Pc=392;continue;}
case 392:{f.Push(f.Locals[18]);f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/game/player/PlayerController","specifyManaCombo","(Lforge/game/spellability/SpellAbility;Lforge/card/ColorSet;IZ)Ljava/util/Map;","invokevirtual",397);}
case 397:{f.Locals[22]=f.Pop();f.Pc=399;continue;}
case 399:{f.Push(f.Locals[22]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",406);}
case 406:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",411);}
case 411:{f.Locals[23]=f.Pop();f.Pc=413;continue;}
case 413:{f.Push(f.Locals[23]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",420);}
case 420:{f.Pc=f.Pop().Int==0?537:423;continue;}
case 423:{f.Push(f.Locals[23]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",430);}
case 430:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=433;continue;}
case 433:{f.Locals[24]=f.Pop();f.Pc=435;continue;}
case 435:{f.Push(f.Locals[24]);f.Pc=437;continue;}
case 437:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",442);}
case 442:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Byte"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=445;continue;}
case 445:{f.Locals[25]=f.Pop();f.Pc=447;continue;}
case 447:{f.Push(f.Locals[25]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"java/lang/Byte","byteValue","()B","invokevirtual",452);}
case 452:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",455);}
case 455:{f.Locals[26]=f.Pop();f.Pc=457;continue;}
case 457:{f.Push(f.Locals[25]);f.Pc=459;continue;}
case 459:{return rt.Call(f,"java/lang/Byte","byteValue","()B","invokevirtual",462);}
case 462:{return rt.Call(f,"forge/card/MagicColor","toSymbol","(B)Ljava/lang/String;","invokestatic",465);}
case 465:{f.Locals[27]=f.Pop();f.Pc=467;continue;}
case 467:{f.Push(f.Locals[24]);f.Pc=469;continue;}
case 469:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",474);}
case 474:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=477;continue;}
case 477:{f.Locals[28]=f.Pop();f.Pc=479;continue;}
case 479:{f.Push(f.Locals[28]);f.Pc=481;continue;}
case 481:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",484);}
case 484:{f.Pc=f.Pop().Int<=0?534:487;continue;}
case 487:{f.Push(f.Locals[20]);f.Pc=489;continue;}
case 489:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",492);}
case 492:{f.Pc=f.Pop().Int<=0?503:495;continue;}
case 495:{f.Push(f.Locals[20]);f.Pc=497;continue;}
case 497:{f.Push(JValue.R(rt.String(" ")));f.Pc=499;continue;}
case 499:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",502);}
case 502:{f.StackOp("pop");f.Pc=503;continue;}
case 503:{f.Push(f.Locals[20]);f.Pc=505;continue;}
case 505:{f.Push(f.Locals[26]);f.Pc=507;continue;}
case 507:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",510);}
case 510:{f.StackOp("pop");f.Pc=511;continue;}
case 511:{f.Push(f.Locals[21]);f.Pc=513;continue;}
case 513:{f.Push(f.Locals[27]);f.Pc=515;continue;}
case 515:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",518);}
case 518:{f.StackOp("pop");f.Pc=519;continue;}
case 519:{f.Push(f.Locals[28]);f.Pc=521;continue;}
case 521:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",524);}
case 524:{f.Push(JValue.I(1));f.Pc=525;continue;}
case 525:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=526;continue;}
case 526:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",529);}
case 529:{f.Locals[28]=f.Pop();f.Pc=531;continue;}
case 531:{f.Pc=479;continue;}
case 534:{f.Pc=413;continue;}
case 537:{f.Pc=780;continue;}
case 540:{f.Push(JValue.I(0));f.Pc=541;continue;}
case 541:{f.Locals[22]=f.Pop();f.Pc=543;continue;}
case 543:{f.Push(f.Locals[22]);f.Pc=545;continue;}
case 545:{f.Push(f.Locals[11]);f.Pc=547;continue;}
case 547:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?780:550;continue;}
case 550:{f.Push(JValue.R(rt.String("")));f.Pc=552;continue;}
case 552:{f.Locals[23]=f.Pop();f.Pc=554;continue;}
case 554:{f.Push(f.Locals[17]);f.Pc=556;continue;}
case 556:{f.Pc=f.Pop().Reference==null?586:559;continue;}
case 559:{f.Push(f.Locals[17]);f.Pc=561;continue;}
case 561:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=562;continue;}
case 562:{f.Push(f.Locals[22]);f.Pc=564;continue;}
case 564:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?586:567;continue;}
case 567:{f.Push(f.Locals[19]);f.Pc=569;continue;}
case 569:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",572);}
case 572:{f.Push(f.Locals[17]);f.Pc=574;continue;}
case 574:{f.Push(f.Locals[22]);f.Pc=576;continue;}
case 576:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=577;continue;}
case 577:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(Ljava/lang/String;)B","invokestatic",580);}
case 580:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=581;continue;}
case 581:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",584);}
case 584:{f.Locals[15]=f.Pop();f.Pc=586;continue;}
case 586:{f.Push(f.Locals[15]);f.Pc=588;continue;}
case 588:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",591);}
case 591:{f.Pc=f.Pop().Int==0?619:594;continue;}
case 594:{f.Push(f.Locals[14]);f.Pc=596;continue;}
case 596:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=597;continue;}
case 597:{f.Pc=f.Pop().Int<=0?619:600;continue;}
case 600:{f.Push(f.Locals[14]);f.Pc=602;continue;}
case 602:{f.Push(f.Locals[18]);f.Pc=604;continue;}
case 604:{f.Pc=f.Pop().Int==0?612:607;continue;}
case 607:{f.Push(f.Locals[22]);f.Pc=609;continue;}
case 609:{f.Pc=613;continue;}
case 612:{f.Push(JValue.I(0));f.Pc=613;continue;}
case 613:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=614;continue;}
case 614:{f.Locals[23]=f.Pop();f.Pc=616;continue;}
case 616:{f.Pc=720;continue;}
case 619:{f.Push(f.Locals[10]);f.Pc=621;continue;}
case 621:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",624);}
case 624:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",627);}
case 627:{f.Push(JValue.R(rt.String("lblSelectManaProduce")));f.Pc=630;continue;}
case 630:{f.Push(JValue.I(0));f.Pc=631;continue;}
case 631:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=634;continue;}
case 634:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",637);}
case 637:{f.Push(f.Locals[1]);f.Pc=638;continue;}
case 638:{f.Push(f.Locals[18]);f.Pc=640;continue;}
case 640:{f.Pc=f.Pop().Int==0?661:643;continue;}
case 643:{f.Push(f.Locals[17]);f.Pc=645;continue;}
case 645:{f.Pc=f.Pop().Reference==null?656:648;continue;}
case 648:{f.Push(f.Locals[17]);f.Pc=650;continue;}
case 650:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=651;continue;}
case 651:{f.Push(f.Locals[22]);f.Pc=653;continue;}
case 653:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?661:656;continue;}
case 656:{f.Push(f.Locals[19]);f.Pc=658;continue;}
case 658:{f.Pc=663;continue;}
case 661:{f.Push(f.Locals[15]);f.Pc=663;continue;}
case 663:{return rt.Call(f,"forge/game/player/PlayerController","chooseColor","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/card/ColorSet;)B","invokevirtual",666);}
case 666:{f.Locals[24]=f.Pop();f.Pc=668;continue;}
case 668:{f.Push(f.Locals[24]);f.Pc=670;continue;}
case 670:{f.Pc=f.Pop().Int!=0?695:673;continue;}
case 673:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=676;continue;}
case 676:{f.StackOp("dup");f.Pc=677;continue;}
case 677:{f.Push(f.Locals[9]);f.Pc=679;continue;}
case 679:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",682);}
case 682:{f.Push(f.Locals[2]);f.Pc=683;continue;}
case 683:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",686);}
case 686:{return rt.DynamicCall(f,"forge/game/ability/effects/ManaEffect:3487:686:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",691);}
case 691:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",694);}
case 694:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 695:{f.Push(f.Locals[18]);f.Pc=697;continue;}
case 697:{f.Pc=f.Pop().Int==0?713:700;continue;}
case 700:{f.Push(f.Locals[19]);f.Pc=702;continue;}
case 702:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",705);}
case 705:{f.Push(f.Locals[24]);f.Pc=707;continue;}
case 707:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=708;continue;}
case 708:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",711);}
case 711:{f.Locals[19]=f.Pop();f.Pc=713;continue;}
case 713:{f.Push(f.Locals[24]);f.Pc=715;continue;}
case 715:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",718);}
case 718:{f.Locals[23]=f.Pop();f.Pc=720;continue;}
case 720:{f.Push(f.Locals[23]);f.Pc=722;continue;}
case 722:{return rt.Call(f,"forge/card/MagicColor","toSymbol","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",725);}
case 725:{f.Locals[24]=f.Pop();f.Pc=727;continue;}
case 727:{f.Push(f.Locals[12]);f.Pc=729;continue;}
case 729:{f.Locals[25]=f.Pop();f.Pc=731;continue;}
case 731:{f.Push(f.Locals[25]);f.Pc=733;continue;}
case 733:{f.Pc=f.Pop().Int<=0?774:736;continue;}
case 736:{f.Push(f.Locals[20]);f.Pc=738;continue;}
case 738:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",741);}
case 741:{f.Pc=f.Pop().Int<=0?752:744;continue;}
case 744:{f.Push(f.Locals[20]);f.Pc=746;continue;}
case 746:{f.Push(JValue.R(rt.String(" ")));f.Pc=748;continue;}
case 748:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",751);}
case 751:{f.StackOp("pop");f.Pc=752;continue;}
case 752:{f.Push(f.Locals[20]);f.Pc=754;continue;}
case 754:{f.Push(f.Locals[23]);f.Pc=756;continue;}
case 756:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",759);}
case 759:{f.StackOp("pop");f.Pc=760;continue;}
case 760:{f.Push(f.Locals[21]);f.Pc=762;continue;}
case 762:{f.Push(f.Locals[24]);f.Pc=764;continue;}
case 764:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",767);}
case 767:{f.StackOp("pop");f.Pc=768;continue;}
case 768:{f.Locals[25]=JValue.I(unchecked(f.Locals[25].Int+(-1)));f.Pc=771;continue;}
case 771:{f.Pc=731;continue;}
case 774:{f.Locals[22]=JValue.I(unchecked(f.Locals[22].Int+(1)));f.Pc=777;continue;}
case 777:{f.Pc=543;continue;}
case 780:{f.Push(f.Locals[20]);f.Pc=782;continue;}
case 782:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",785);}
case 785:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",788);}
case 788:{f.Pc=f.Pop().Int==0?822:791;continue;}
case 791:{f.Push(JValue.R(rt.String("Combo ColorIdentity")));f.Pc=794;continue;}
case 794:{f.Push(f.Locals[4]);f.Pc=796;continue;}
case 796:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getOrigProduced","()Ljava/lang/String;","invokevirtual",799);}
case 799:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",802);}
case 802:{f.Pc=f.Pop().Int!=0?125:805;continue;}
case 805:{f.Push(JValue.R(rt.String("Combo Spire")));f.Pc=808;continue;}
case 808:{f.Push(f.Locals[4]);f.Pc=810;continue;}
case 810:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getOrigProduced","()Ljava/lang/String;","invokevirtual",813);}
case 813:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",816);}
case 816:{f.Pc=f.Pop().Int==0?822:819;continue;}
case 819:{f.Pc=125;continue;}
case 822:{f.Push(f.Locals[3]);f.Pc=823;continue;}
case 823:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",826);}
case 826:{f.Push(f.Locals[1]);f.Pc=827;continue;}
case 827:{f.Push(f.Locals[9]);f.Pc=829;continue;}
case 829:{f.Push(f.Locals[21]);f.Pc=831;continue;}
case 831:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",834);}
case 834:{f.Push(f.Locals[9]);f.Pc=836;continue;}
case 836:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",839);}
case 839:{f.Push(f.Locals[4]);f.Pc=841;continue;}
case 841:{f.Push(f.Locals[20]);f.Pc=843;continue;}
case 843:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",846);}
case 846:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","setExpressChoice","(Ljava/lang/String;)V","invokevirtual",849);}
case 849:{f.Pc=1023;continue;}
case 852:{f.Push(f.Locals[4]);f.Pc=854;continue;}
case 854:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isAnyMana","()Z","invokevirtual",857);}
case 857:{f.Pc=f.Pop().Int==0?1006:860;continue;}
case 860:{f.Push(f.Locals[4]);f.Pc=862;continue;}
case 862:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getExpressChoice","()Ljava/lang/String;","invokevirtual",865);}
case 865:{f.Locals[11]=f.Pop();f.Pc=867;continue;}
case 867:{f.Push(JValue.I(0));f.Pc=868;continue;}
case 868:{f.Locals[12]=f.Pop();f.Pc=870;continue;}
case 870:{f.Push(JValue.I(0));f.Pc=871;continue;}
case 871:{f.Locals[13]=f.Pop();f.Pc=873;continue;}
case 873:{f.Push(f.Locals[13]);f.Pc=875;continue;}
case 875:{f.Push(f.Locals[11]);f.Pc=877;continue;}
case 877:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",880);}
case 880:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?905:883;continue;}
case 883:{f.Push(f.Locals[12]);f.Pc=885;continue;}
case 885:{f.Push(f.Locals[11]);f.Pc=887;continue;}
case 887:{f.Push(f.Locals[13]);f.Pc=889;continue;}
case 889:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",892);}
case 892:{return rt.Call(f,"forge/card/MagicColor","fromName","(C)B","invokestatic",895);}
case 895:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=896;continue;}
case 896:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=897;continue;}
case 897:{f.Locals[12]=f.Pop();f.Pc=899;continue;}
case 899:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(1)));f.Pc=902;continue;}
case 902:{f.Pc=873;continue;}
case 905:{f.Push(f.Locals[12]);f.Pc=907;continue;}
case 907:{f.Pc=f.Pop().Int!=0?916:910;continue;}
case 910:{if(!rt.StaticReady(f,"forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"));f.Pc=913;continue;}
case 913:{f.Pc=921;continue;}
case 916:{f.Push(f.Locals[12]);f.Pc=918;continue;}
case 918:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",921);}
case 921:{f.Locals[13]=f.Pop();f.Pc=923;continue;}
case 923:{f.Push(f.Locals[10]);f.Pc=925;continue;}
case 925:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",928);}
case 928:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",931);}
case 931:{f.Push(JValue.R(rt.String("lblSelectManaProduce")));f.Pc=934;continue;}
case 934:{f.Push(JValue.I(0));f.Pc=935;continue;}
case 935:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=938;continue;}
case 938:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",941);}
case 941:{f.Push(f.Locals[1]);f.Pc=942;continue;}
case 942:{f.Push(f.Locals[13]);f.Pc=944;continue;}
case 944:{return rt.Call(f,"forge/game/player/PlayerController","chooseColor","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/card/ColorSet;)B","invokevirtual",947);}
case 947:{f.Locals[14]=f.Pop();f.Pc=949;continue;}
case 949:{f.Push(JValue.I(0));f.Pc=950;continue;}
case 950:{f.Push(f.Locals[14]);f.Pc=952;continue;}
case 952:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?977:955;continue;}
case 955:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=958;continue;}
case 958:{f.StackOp("dup");f.Pc=959;continue;}
case 959:{f.Push(f.Locals[9]);f.Pc=961;continue;}
case 961:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",964);}
case 964:{f.Push(f.Locals[2]);f.Pc=965;continue;}
case 965:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",968);}
case 968:{return rt.DynamicCall(f,"forge/game/ability/effects/ManaEffect:3487:968:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",973);}
case 973:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",976);}
case 976:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 977:{f.Push(f.Locals[3]);f.Pc=978;continue;}
case 978:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",981);}
case 981:{f.Push(f.Locals[1]);f.Pc=982;continue;}
case 982:{f.Push(f.Locals[2]);f.Pc=983;continue;}
case 983:{f.Push(f.Locals[14]);f.Pc=985;continue;}
case 985:{return rt.Call(f,"forge/card/MagicColor","toSymbol","(B)Ljava/lang/String;","invokestatic",988);}
case 988:{f.Push(f.Locals[9]);f.Pc=990;continue;}
case 990:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",993);}
case 993:{f.Push(f.Locals[4]);f.Pc=995;continue;}
case 995:{f.Push(f.Locals[14]);f.Pc=997;continue;}
case 997:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",1000);}
case 1000:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","setExpressChoice","(Ljava/lang/String;)V","invokevirtual",1003);}
case 1003:{f.Pc=1023;continue;}
case 1006:{f.Push(f.Locals[4]);f.Pc=1008;continue;}
case 1008:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isSpecialMana","()Z","invokevirtual",1011);}
case 1011:{f.Pc=f.Pop().Int==0?1023:1014;continue;}
case 1014:{f.Push(f.Locals[10]);f.Pc=1016;continue;}
case 1016:{f.Push(f.Locals[4]);f.Pc=1018;continue;}
case 1018:{f.Push(f.Locals[1]);f.Pc=1019;continue;}
case 1019:{f.Push(JValue.I(1));f.Pc=1020;continue;}
case 1020:{return rt.Call(f,"forge/game/ability/effects/ManaEffect","handleSpecialMana","(Lforge/game/player/Player;Lforge/game/spellability/AbilityManaPart;Lforge/game/spellability/SpellAbility;Z)V","invokestatic",1023);}
case 1023:{f.Push(f.Locals[1]);f.Pc=1024;continue;}
case 1024:{return rt.Call(f,"forge/game/GameActionUtil","generatedMana","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokestatic",1027);}
case 1027:{f.Locals[11]=f.Pop();f.Pc=1029;continue;}
case 1029:{f.Push(f.Locals[11]);f.Pc=1031;continue;}
case 1031:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1034);}
case 1034:{f.Pc=f.Pop().Int==0?1085:1037;continue;}
case 1037:{f.Push(JValue.R(rt.String("AbilityFactoryMana::manaResolve() - special mana effect is empty for")));f.Pc=1040;continue;}
case 1040:{f.Locals[12]=f.Pop();f.Pc=1042;continue;}
case 1042:{if(!rt.EnsureInitialized(f,"io/sentry/Breadcrumb"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("io/sentry/Breadcrumb")));f.Pc=1045;continue;}
case 1045:{f.StackOp("dup");f.Pc=1046;continue;}
case 1046:{f.Push(f.Locals[12]);f.Pc=1048;continue;}
case 1048:{return rt.Call(f,"io/sentry/Breadcrumb","<init>","(Ljava/lang/String;)V","invokespecial",1051);}
case 1051:{f.Locals[13]=f.Pop();f.Pc=1053;continue;}
case 1053:{f.Push(f.Locals[13]);f.Pc=1055;continue;}
case 1055:{f.Push(JValue.R(rt.String("Card")));f.Pc=1058;continue;}
case 1058:{f.Push(f.Locals[2]);f.Pc=1059;continue;}
case 1059:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",1062);}
case 1062:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",1065);}
case 1065:{f.Push(f.Locals[13]);f.Pc=1067;continue;}
case 1067:{f.Push(JValue.R(rt.String("SA")));f.Pc=1070;continue;}
case 1070:{f.Push(f.Locals[1]);f.Pc=1071;continue;}
case 1071:{return rt.Call(f,"forge/game/spellability/SpellAbility","toString","()Ljava/lang/String;","invokevirtual",1074);}
case 1074:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",1077);}
case 1077:{f.Push(f.Locals[13]);f.Pc=1079;continue;}
case 1079:{return rt.Call(f,"io/sentry/Sentry","addBreadcrumb","(Lio/sentry/Breadcrumb;)V","invokestatic",1082);}
case 1082:{f.Pc=125;continue;}
case 1085:{f.Push(f.Locals[7]);f.Pc=1087;continue;}
case 1087:{f.Push(f.Locals[4]);f.Pc=1089;continue;}
case 1089:{f.Push(f.Locals[11]);f.Pc=1091;continue;}
case 1091:{f.Push(f.Locals[9]);f.Pc=1093;continue;}
case 1093:{f.Push(f.Locals[1]);f.Pc=1094;continue;}
case 1094:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","produceMana","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",1097);}
case 1097:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1100);}
case 1100:{f.StackOp("pop");f.Pc=1101;continue;}
case 1101:{f.Pc=125;continue;}
case 1104:{f.Push(f.Locals[4]);f.Pc=1106;continue;}
case 1106:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","clearExpressChoice","()V","invokevirtual",1109);}
case 1109:{f.Push(f.Locals[4]);f.Pc=1111;continue;}
case 1111:{f.Push(f.Locals[1]);f.Pc=1112;continue;}
case 1112:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1115);}
case 1115:{f.Push(f.Locals[7]);f.Pc=1117;continue;}
case 1117:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1120);}
case 1120:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","tapsForMana","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)V","invokevirtual",1123);}
case 1123:{f.Push(f.Locals[1]);f.Pc=1124;continue;}
case 1124:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","FIREBENDING","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","FIREBENDING","Lforge/game/keyword/Keyword;"));f.Pc=1127;continue;}
case 1127:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",1130);}
case 1130:{f.Pc=f.Pop().Int==0?1141:1133;continue;}
case 1133:{f.Push(f.Locals[6]);f.Pc=1135;continue;}
case 1135:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Firebend","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Firebend","Lforge/game/trigger/TriggerType;"));f.Pc=1138;continue;}
case 1138:{return rt.Call(f,"forge/game/player/Player","triggerElementalBend","(Lforge/game/trigger/TriggerType;)V","invokevirtual",1141);}
case 1141:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3488(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getOrigProduced","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("Special ")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=12;continue;}
case 12:{f.Locals[4]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",18);}
case 18:{f.Locals[5]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Int==0?588:24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("EnchantedManaCost")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?274:35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","getEnchantingCard","()Lforge/game/card/Card;","invokevirtual",40);}
case 40:{f.Locals[6]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[6]);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Reference!=null?48:47;continue;}
case 47:{return JStep.ReturnVoid;}
case 48:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=51;continue;}
case 51:{f.StackOp("dup");f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",55);}
case 55:{f.Locals[7]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/card/mana/ManaCost","getGenericCost","()I","invokevirtual",65);}
case 65:{f.Locals[8]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",72);}
case 72:{return rt.Call(f,"forge/card/mana/ManaCost","iterator","()Ljava/util/Iterator;","invokevirtual",75);}
case 75:{f.Locals[9]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[9]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",84);}
case 84:{f.Pc=f.Pop().Int==0?246:87;continue;}
case 87:{f.Push(f.Locals[9]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",94);}
case 94:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=97;continue;}
case 97:{f.Locals[10]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[10]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/card/mana/ManaCostShard","getColorMask","()B","invokevirtual",104);}
case 104:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",107);}
case 107:{f.Locals[11]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[11]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?120:117;continue;}
case 117:{f.Pc=77;continue;}
case 120:{f.Push(f.Locals[10]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/card/mana/ManaCostShard","isOr2Generic","()Z","invokevirtual",125);}
case 125:{f.Pc=f.Pop().Int==0?173:128;continue;}
case 128:{f.Push(f.Locals[0]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",132);}
case 132:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",135);}
case 135:{f.Push(JValue.R(rt.String("lblChooseSingleColorFromTarget")));f.Pc=138;continue;}
case 138:{f.Push(JValue.I(1));f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=142;continue;}
case 142:{f.StackOp("dup");f.Pc=143;continue;}
case 143:{f.Push(JValue.I(0));f.Pc=144;continue;}
case 144:{f.Push(f.Locals[10]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/card/mana/ManaCostShard","toString","()Ljava/lang/String;","invokevirtual",149);}
case 149:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",153);}
case 153:{f.Push(f.Locals[5]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[11]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/player/PlayerController","chooseColorAllowColorless","(Ljava/lang/String;Lforge/game/card/Card;Lforge/card/ColorSet;)B","invokevirtual",160);}
case 160:{f.Locals[12]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[12]);f.Pc=164;continue;}
case 164:{f.Pc=f.Pop().Int!=0?224:167;continue;}
case 167:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(2)));f.Pc=170;continue;}
case 170:{f.Pc=77;continue;}
case 173:{f.Push(f.Locals[11]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/card/ColorSet","isMonoColor","()Z","invokevirtual",178);}
case 178:{f.Pc=f.Pop().Int==0?191:181;continue;}
case 181:{f.Push(f.Locals[10]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/card/mana/ManaCostShard","getColorMask","()B","invokevirtual",186);}
case 186:{f.Locals[12]=f.Pop();f.Pc=188;continue;}
case 188:{f.Pc=224;continue;}
case 191:{f.Push(f.Locals[0]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",195);}
case 195:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",198);}
case 198:{f.Push(JValue.R(rt.String("lblChooseSingleColorFromTarget")));f.Pc=201;continue;}
case 201:{f.Push(JValue.I(1));f.Pc=202;continue;}
case 202:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=205;continue;}
case 205:{f.StackOp("dup");f.Pc=206;continue;}
case 206:{f.Push(JValue.I(0));f.Pc=207;continue;}
case 207:{f.Push(f.Locals[10]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/card/mana/ManaCostShard","toString","()Ljava/lang/String;","invokevirtual",212);}
case 212:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",216);}
case 216:{f.Push(f.Locals[2]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[11]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/player/PlayerController","chooseColor","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/card/ColorSet;)B","invokevirtual",222);}
case 222:{f.Locals[12]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(f.Locals[7]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[12]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",231);}
case 231:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",234);}
case 234:{f.StackOp("pop");f.Pc=235;continue;}
case 235:{f.Push(f.Locals[7]);f.Pc=237;continue;}
case 237:{f.Push(JValue.I(32));f.Pc=239;continue;}
case 239:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",242);}
case 242:{f.StackOp("pop");f.Pc=243;continue;}
case 243:{f.Pc=77;continue;}
case 246:{f.Push(f.Locals[8]);f.Pc=248;continue;}
case 248:{f.Pc=f.Pop().Int<=0?259:251;continue;}
case 251:{f.Push(f.Locals[7]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[8]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",258);}
case 258:{f.StackOp("pop");f.Pc=259;continue;}
case 259:{f.Push(f.Locals[1]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[7]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",265);}
case 265:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",268);}
case 268:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","setExpressChoice","(Ljava/lang/String;)V","invokevirtual",271);}
case 271:{f.Pc=734;continue;}
case 274:{f.Push(f.Locals[4]);f.Pc=276;continue;}
case 276:{f.Push(JValue.R(rt.String("EachColoredManaSymbol")));f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",282);}
case 282:{f.Pc=f.Pop().Int==0?492:285;continue;}
case 285:{f.Push(f.Locals[4]);f.Pc=287;continue;}
case 287:{f.Push(JValue.R(rt.String("_")));f.Pc=290;continue;}
case 290:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",293);}
case 293:{f.Push(JValue.I(1));f.Pc=294;continue;}
case 294:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=295;continue;}
case 295:{f.Locals[6]=f.Pop();f.Pc=297;continue;}
case 297:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=300;continue;}
case 300:{f.StackOp("dup");f.Pc=301;continue;}
case 301:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",304);}
case 304:{f.Locals[7]=f.Pop();f.Pc=306;continue;}
case 306:{f.Push(f.Locals[5]);f.Pc=308;continue;}
case 308:{f.Push(f.Locals[6]);f.Pc=310;continue;}
case 310:{f.Push(f.Locals[2]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",314);}
case 314:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",317);}
case 317:{f.Locals[8]=f.Pop();f.Pc=319;continue;}
case 319:{f.Push(f.Locals[8]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",326);}
case 326:{f.Pc=f.Pop().Int==0?477:329;continue;}
case 329:{f.Push(f.Locals[8]);f.Pc=331;continue;}
case 331:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",336);}
case 336:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=339;continue;}
case 339:{f.Locals[9]=f.Pop();f.Pc=341;continue;}
case 341:{f.Push(f.Locals[9]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",346);}
case 346:{return rt.Call(f,"forge/card/mana/ManaCost","iterator","()Ljava/util/Iterator;","invokevirtual",349);}
case 349:{f.Locals[10]=f.Pop();f.Pc=351;continue;}
case 351:{f.Push(f.Locals[10]);f.Pc=353;continue;}
case 353:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",358);}
case 358:{f.Pc=f.Pop().Int==0?474:361;continue;}
case 361:{f.Push(f.Locals[10]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",368);}
case 368:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=371;continue;}
case 371:{f.Locals[11]=f.Pop();f.Pc=373;continue;}
case 373:{f.Push(f.Locals[11]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/card/mana/ManaCostShard","getColorMask","()B","invokevirtual",378);}
case 378:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",381);}
case 381:{f.Locals[12]=f.Pop();f.Pc=383;continue;}
case 383:{f.Push(f.Locals[12]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",388);}
case 388:{f.Pc=f.Pop().Int==0?394:391;continue;}
case 391:{f.Pc=351;continue;}
case 394:{f.Push(f.Locals[7]);f.Pc=396;continue;}
case 396:{f.Push(JValue.I(32));f.Pc=398;continue;}
case 398:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",401);}
case 401:{f.StackOp("pop");f.Pc=402;continue;}
case 402:{f.Push(f.Locals[12]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/card/ColorSet","isMonoColor","()Z","invokevirtual",407);}
case 407:{f.Pc=f.Pop().Int==0?427:410;continue;}
case 410:{f.Push(f.Locals[7]);f.Pc=412;continue;}
case 412:{f.Push(f.Locals[11]);f.Pc=414;continue;}
case 414:{return rt.Call(f,"forge/card/mana/ManaCostShard","getColorMask","()B","invokevirtual",417);}
case 417:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",420);}
case 420:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",423);}
case 423:{f.StackOp("pop");f.Pc=424;continue;}
case 424:{f.Pc=471;continue;}
case 427:{f.Push(f.Locals[0]);f.Pc=428;continue;}
case 428:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",431);}
case 431:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",434);}
case 434:{f.Push(JValue.R(rt.String("lblChooseSingleColorFromTarget")));f.Pc=437;continue;}
case 437:{f.Push(JValue.I(1));f.Pc=438;continue;}
case 438:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=441;continue;}
case 441:{f.StackOp("dup");f.Pc=442;continue;}
case 442:{f.Push(JValue.I(0));f.Pc=443;continue;}
case 443:{f.Push(f.Locals[11]);f.Pc=445;continue;}
case 445:{return rt.Call(f,"forge/card/mana/ManaCostShard","toString","()Ljava/lang/String;","invokevirtual",448);}
case 448:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",452);}
case 452:{f.Push(f.Locals[2]);f.Pc=453;continue;}
case 453:{f.Push(f.Locals[12]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/player/PlayerController","chooseColor","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/card/ColorSet;)B","invokevirtual",458);}
case 458:{f.Locals[13]=f.Pop();f.Pc=460;continue;}
case 460:{f.Push(f.Locals[7]);f.Pc=462;continue;}
case 462:{f.Push(f.Locals[13]);f.Pc=464;continue;}
case 464:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",467);}
case 467:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",470);}
case 470:{f.StackOp("pop");f.Pc=471;continue;}
case 471:{f.Pc=351;continue;}
case 474:{f.Pc=319;continue;}
case 477:{f.Push(f.Locals[1]);f.Pc=478;continue;}
case 478:{f.Push(f.Locals[7]);f.Pc=480;continue;}
case 480:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",483);}
case 483:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",486);}
case 486:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","setExpressChoice","(Ljava/lang/String;)V","invokevirtual",489);}
case 489:{f.Pc=734;continue;}
case 492:{f.Push(f.Locals[4]);f.Pc=494;continue;}
case 494:{f.Push(JValue.R(rt.String("DoubleManaInPool")));f.Pc=497;continue;}
case 497:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",500);}
case 500:{f.Pc=f.Pop().Int==0?734:503;continue;}
case 503:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=506;continue;}
case 506:{f.StackOp("dup");f.Pc=507;continue;}
case 507:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",510);}
case 510:{f.Locals[6]=f.Pop();f.Pc=512;continue;}
case 512:{if(!rt.StaticReady(f,"forge/card/mana/ManaAtom","MANATYPES","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaAtom","MANATYPES","[B"));f.Pc=515;continue;}
case 515:{f.Locals[7]=f.Pop();f.Pc=517;continue;}
case 517:{f.Push(f.Locals[7]);f.Pc=519;continue;}
case 519:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=520;continue;}
case 520:{f.Locals[8]=f.Pop();f.Pc=522;continue;}
case 522:{f.Push(JValue.I(0));f.Pc=523;continue;}
case 523:{f.Locals[9]=f.Pop();f.Pc=525;continue;}
case 525:{f.Push(f.Locals[9]);f.Pc=527;continue;}
case 527:{f.Push(f.Locals[8]);f.Pc=529;continue;}
case 529:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?573:532;continue;}
case 532:{f.Push(f.Locals[7]);f.Pc=534;continue;}
case 534:{f.Push(f.Locals[9]);f.Pc=536;continue;}
case 536:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=537;continue;}
case 537:{f.Locals[10]=f.Pop();f.Pc=539;continue;}
case 539:{f.Push(f.Locals[6]);f.Pc=541;continue;}
case 541:{f.Push(f.Locals[10]);f.Pc=543;continue;}
case 543:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",546);}
case 546:{return rt.DynamicCall(f,"forge/game/ability/effects/ManaEffect:3488:546:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",551);}
case 551:{f.Push(f.Locals[0]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",555);}
case 555:{f.Push(f.Locals[10]);f.Pc=557;continue;}
case 557:{return rt.Call(f,"forge/game/mana/ManaPool","getAmountOfColor","(B)I","invokevirtual",560);}
case 560:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","repeat","(Ljava/lang/String;I)Ljava/lang/String;","invokestatic",563);}
case 563:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",566);}
case 566:{f.StackOp("pop");f.Pc=567;continue;}
case 567:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=570;continue;}
case 570:{f.Pc=525;continue;}
case 573:{f.Push(f.Locals[1]);f.Pc=574;continue;}
case 574:{f.Push(f.Locals[6]);f.Pc=576;continue;}
case 576:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",579);}
case 579:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",582);}
case 582:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","setExpressChoice","(Ljava/lang/String;)V","invokevirtual",585);}
case 585:{f.Pc=734;continue;}
case 588:{f.Push(f.Locals[4]);f.Pc=590;continue;}
case 590:{f.Push(JValue.R(rt.String("LastNotedType")));f.Pc=593;continue;}
case 593:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",596);}
case 596:{f.Pc=f.Pop().Int==0?683:599;continue;}
case 599:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=602;continue;}
case 602:{f.StackOp("dup");f.Pc=603;continue;}
case 603:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",606);}
case 606:{f.Locals[6]=f.Pop();f.Pc=608;continue;}
case 608:{f.Push(f.Locals[5]);f.Pc=610;continue;}
case 610:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",613);}
case 613:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",618);}
case 618:{f.Locals[7]=f.Pop();f.Pc=620;continue;}
case 620:{f.Push(f.Locals[7]);f.Pc=622;continue;}
case 622:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",627);}
case 627:{f.Pc=f.Pop().Int==0?658:630;continue;}
case 630:{f.Push(f.Locals[7]);f.Pc=632;continue;}
case 632:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",637);}
case 637:{f.Locals[8]=f.Pop();f.Pc=639;continue;}
case 639:{f.Push(f.Locals[8]);f.Pc=641;continue;}
case 641:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/lang/String")?1:0));f.Pc=644;continue;}
case 644:{f.Pc=f.Pop().Int==0?655:647;continue;}
case 647:{f.Push(f.Locals[6]);f.Pc=649;continue;}
case 649:{f.Push(f.Locals[8]);f.Pc=651;continue;}
case 651:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",654);}
case 654:{f.StackOp("pop");f.Pc=655;continue;}
case 655:{f.Pc=620;continue;}
case 658:{f.Push(f.Locals[6]);f.Pc=660;continue;}
case 660:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",663);}
case 663:{f.Locals[7]=f.Pop();f.Pc=665;continue;}
case 665:{f.Push(f.Locals[7]);f.Pc=667;continue;}
case 667:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",670);}
case 670:{f.Pc=f.Pop().Int==0?674:673;continue;}
case 673:{return JStep.ReturnVoid;}
case 674:{f.Push(f.Locals[1]);f.Pc=675;continue;}
case 675:{f.Push(f.Locals[7]);f.Pc=677;continue;}
case 677:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","setExpressChoice","(Ljava/lang/String;)V","invokevirtual",680);}
case 680:{f.Pc=734;continue;}
case 683:{f.Push(f.Locals[4]);f.Pc=685;continue;}
case 685:{f.Push(JValue.R(rt.String("EachColorAmong")));f.Pc=688;continue;}
case 688:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",691);}
case 691:{f.Pc=f.Pop().Int==0?734:694;continue;}
case 694:{f.Push(f.Locals[4]);f.Pc=696;continue;}
case 696:{f.Push(JValue.R(rt.String("_")));f.Pc=699;continue;}
case 699:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",702);}
case 702:{f.Push(JValue.I(1));f.Pc=703;continue;}
case 703:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=704;continue;}
case 704:{f.Locals[6]=f.Pop();f.Pc=706;continue;}
case 706:{f.Push(f.Locals[5]);f.Pc=708;continue;}
case 708:{f.Push(f.Locals[6]);f.Pc=710;continue;}
case 710:{f.Push(f.Locals[2]);f.Pc=711;continue;}
case 711:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",714);}
case 714:{return rt.Call(f,"forge/game/card/CardUtil","getColorsFromCards","(Ljava/lang/Iterable;)Lforge/card/ColorSet;","invokestatic",717);}
case 717:{f.Locals[7]=f.Pop();f.Pc=719;continue;}
case 719:{f.Push(f.Locals[7]);f.Pc=721;continue;}
case 721:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",724);}
case 724:{f.Pc=f.Pop().Int==0?728:727;continue;}
case 727:{return JStep.ReturnVoid;}
case 728:{f.Push(f.Locals[1]);f.Pc=729;continue;}
case 729:{f.Push(f.Locals[7]);f.Pc=731;continue;}
case 731:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","setExpressChoice","(Lforge/card/ColorSet;)V","invokevirtual",734);}
case 734:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3489(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/ManaEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Amount")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?34:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Amount")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",28);}
case 28:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",31);}
case 31:{f.Pc=f.Pop().Int==0?41:34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/GameActionUtil","generatedMana","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokestatic",38);}
case 38:{f.Pc=44;continue;}
case 41:{f.Push(JValue.R(rt.String("mana")));f.Pc=44;continue;}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("")));f.Pc=48;continue;}
case 48:{f.Locals[5]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("mana")));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?99:61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.String("Produced")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int==0?99:71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("AmountDesc")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int==0?99:81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("Produced")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",88);}
case 88:{f.Locals[4]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("AmountDesc")));f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",97);}
case 97:{f.Locals[5]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[2]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("Defined")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/ability/effects/ManaEffect","playersOrDescribed","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;","invokestatic",108);}
case 108:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",111);}
case 111:{f.Push(f.Locals[3]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",117);}
case 117:{f.Push(JValue.I(1));f.Pc=118;continue;}
case 118:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?127:121;continue;}
case 121:{f.Push(JValue.R(rt.String(" add ")));f.Pc=124;continue;}
case 124:{f.Pc=130;continue;}
case 127:{f.Push(JValue.R(rt.String(" adds ")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",133);}
case 133:{f.StackOp("pop");f.Pc=134;continue;}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[4]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/util/TextUtil","toManaString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",140);}
case 140:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",143);}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",148);}
case 148:{f.Push(JValue.R(rt.String(".")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",154);}
case 154:{f.StackOp("pop");f.Pc=155;continue;}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String("RestrictValid")));f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",162);}
case 162:{f.Pc=f.Pop().Int==0?290:165;continue;}
case 165:{f.Push(f.Locals[1]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",169);}
case 169:{f.Locals[6]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[6]);f.Pc=173;continue;}
case 173:{f.Push(JValue.R(rt.String("Spend this")));f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",179);}
case 179:{f.Pc=f.Pop().Int==0?232:182;continue;}
case 182:{f.Push(f.Locals[6]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String(".")));f.Pc=187;continue;}
case 187:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",190);}
case 190:{f.Pc=f.Pop().Int==0?232:193;continue;}
case 193:{f.Push(f.Locals[6]);f.Pc=195;continue;}
case 195:{f.Push(JValue.R(rt.String("Spend this")));f.Pc=198;continue;}
case 198:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",201);}
case 201:{f.Locals[7]=f.Pop();f.Pc=203;continue;}
case 203:{f.Push(f.Locals[2]);f.Pc=204;continue;}
case 204:{f.Push(JValue.R(rt.String(" ")));f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",209);}
case 209:{f.Push(f.Locals[6]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[7]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[6]);f.Pc=215;continue;}
case 215:{f.Push(JValue.R(rt.String(".")));f.Pc=218;continue;}
case 218:{f.Push(f.Locals[7]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;I)I","invokevirtual",223);}
case 223:{f.Push(JValue.I(1));f.Pc=224;continue;}
case 224:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;","invokevirtual",228);}
case 228:{f.StackOp("pop");f.Pc=229;continue;}
case 229:{f.Pc=290;continue;}
case 232:{f.Push(f.Locals[6]);f.Pc=234;continue;}
case 234:{f.Push(JValue.R(rt.String("This mana can't")));f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",240);}
case 240:{f.Pc=f.Pop().Int==0?290:243;continue;}
case 243:{f.Push(f.Locals[6]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String(".")));f.Pc=248;continue;}
case 248:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",251);}
case 251:{f.Pc=f.Pop().Int==0?290:254;continue;}
case 254:{f.Push(f.Locals[6]);f.Pc=256;continue;}
case 256:{f.Push(JValue.R(rt.String("This mana can't")));f.Pc=259;continue;}
case 259:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",262);}
case 262:{f.Locals[7]=f.Pop();f.Pc=264;continue;}
case 264:{f.Push(f.Locals[2]);f.Pc=265;continue;}
case 265:{f.Push(JValue.R(rt.String(" ")));f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",270);}
case 270:{f.Push(f.Locals[6]);f.Pc=272;continue;}
case 272:{f.Push(f.Locals[7]);f.Pc=274;continue;}
case 274:{f.Push(f.Locals[6]);f.Pc=276;continue;}
case 276:{f.Push(JValue.R(rt.String(".")));f.Pc=279;continue;}
case 279:{f.Push(f.Locals[7]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;I)I","invokevirtual",284);}
case 284:{f.Push(JValue.I(1));f.Pc=285;continue;}
case 285:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=286;continue;}
case 286:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;","invokevirtual",289);}
case 289:{f.StackOp("pop");f.Pc=290;continue;}
case 290:{f.Push(f.Locals[2]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",294);}
case 294:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
