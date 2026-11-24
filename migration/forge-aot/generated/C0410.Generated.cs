// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C410{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/TapOrUntapAllEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3761,"forge/game/ability/effects/TapOrUntapAllEffect","<init>","()V",1,1,1,new JHandler[]{},M3761));
c.Add(new JMethod(3762,"forge/game/ability/effects/TapOrUntapAllEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,3,new JHandler[]{},M3762));
c.Add(new JMethod(3763,"forge/game/ability/effects/TapOrUntapAllEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,5,new JHandler[]{},M3763));
}

internal static JStep M3761(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3762(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Tap or untap ")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("ValidMessage")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?38:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("ValidMessage")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",31);}
case 31:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",34);}
case 34:{f.StackOp("pop");f.Pc=35;continue;}
case 35:{f.Pc=50;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/ability/effects/TapOrUntapAllEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",43);}
case 43:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",46);}
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

internal static JStep M3763(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?41:19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",26);}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",36);}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Pc=47;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/ability/effects/TapOrUntapAllEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",45);}
case 45:{f.Locals[4]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int!=0?63:54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("Defined")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int==0?74:63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/ability/effects/TapOrUntapAllEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",69);}
case 69:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/util/collect/FCollectionView;)Lforge/game/card/CardCollection;","invokestatic",72);}
case 72:{f.Locals[4]=f.Pop();f.Pc=74;continue;}
case 74:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=77;continue;}
case 77:{f.StackOp("dup");f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",81);}
case 81:{f.Push(JValue.R(rt.String("lblTapOrUntapTarget")));f.Pc=83;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",90);}
case 90:{return rt.DynamicCall(f,"forge/game/ability/effects/TapOrUntapAllEffect:3763:90:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",95);}
case 95:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",98);}
case 98:{f.Locals[5]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("ValidMessage")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?124:109;continue;}
case 109:{f.Push(f.Locals[5]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("ValidMessage")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",117);}
case 117:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",120);}
case 120:{f.StackOp("pop");f.Pc=121;continue;}
case 121:{f.Pc=142;continue;}
case 124:{f.Push(f.Locals[5]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",129);}
case 129:{f.Push(JValue.R(rt.String("lblPermanents")));f.Pc=131;continue;}
case 131:{f.Push(JValue.I(0));f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",138);}
case 138:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",141);}
case 141:{f.StackOp("pop");f.Pc=142;continue;}
case 142:{f.Push(f.Locals[5]);f.Pc=144;continue;}
case 144:{f.Push(JValue.R(rt.String("?")));f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{f.Push(f.Locals[2]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",154);}
case 154:{f.Push(f.Locals[1]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[5]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",160);}
case 160:{if(!rt.StaticReady(f,"forge/game/player/PlayerController$BinaryChoiceType","TapOrUntap","Lforge/game/player/PlayerController$BinaryChoiceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerController$BinaryChoiceType","TapOrUntap","Lforge/game/player/PlayerController$BinaryChoiceType;"));f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/player/PlayerController","chooseBinary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;)Z","invokevirtual",166);}
case 166:{f.Locals[6]=f.Pop();f.Pc=168;continue;}
case 168:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=171;continue;}
case 171:{f.StackOp("dup");f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",175);}
case 175:{f.Locals[7]=f.Pop();f.Pc=177;continue;}
case 177:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=180;continue;}
case 180:{f.StackOp("dup");f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",184);}
case 184:{f.Locals[8]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[4]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",193);}
case 193:{f.Locals[9]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[9]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",202);}
case 202:{f.Pc=f.Pop().Int==0?300:205;continue;}
case 205:{f.Push(f.Locals[9]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",212);}
case 212:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=215;continue;}
case 215:{f.Locals[10]=f.Pop();f.Pc=217;continue;}
case 217:{f.Push(f.Locals[10]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",222);}
case 222:{f.Pc=f.Pop().Int!=0?228:225;continue;}
case 225:{f.Pc=195;continue;}
case 228:{f.Push(f.Locals[3]);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[10]);f.Pc=231;continue;}
case 231:{f.Push(JValue.R(null));f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",235);}
case 235:{f.Locals[11]=f.Pop();f.Pc=237;continue;}
case 237:{f.Push(f.Locals[11]);f.Pc=239;continue;}
case 239:{f.Pc=f.Pop().Reference==null?195:242;continue;}
case 242:{f.Push(f.Locals[10]);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[11]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",249);}
case 249:{f.Pc=f.Pop().Int!=0?255:252;continue;}
case 252:{f.Pc=195;continue;}
case 255:{f.Push(f.Locals[6]);f.Pc=257;continue;}
case 257:{f.Pc=f.Pop().Int==0?281:260;continue;}
case 260:{f.Push(f.Locals[11]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[1]);f.Pc=263;continue;}
case 263:{f.Push(f.Locals[2]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/card/Card","tap","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z","invokevirtual",267);}
case 267:{f.Pc=f.Pop().Int==0?297:270;continue;}
case 270:{f.Push(f.Locals[7]);f.Pc=272;continue;}
case 272:{f.Push(f.Locals[11]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",277);}
case 277:{f.StackOp("pop");f.Pc=278;continue;}
case 278:{f.Pc=297;continue;}
case 281:{f.Push(f.Locals[11]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/card/Card","untap","()Z","invokevirtual",286);}
case 286:{f.Pc=f.Pop().Int==0?297:289;continue;}
case 289:{f.Push(f.Locals[8]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[11]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",296);}
case 296:{f.StackOp("pop");f.Pc=297;continue;}
case 297:{f.Pc=195;continue;}
case 300:{f.Push(f.Locals[7]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",305);}
case 305:{f.Pc=f.Pop().Int!=0?339:308;continue;}
case 308:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",311);}
case 311:{f.Locals[9]=f.Pop();f.Pc=313;continue;}
case 313:{f.Push(f.Locals[9]);f.Pc=315;continue;}
case 315:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=318;continue;}
case 318:{f.Push(f.Locals[7]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",325);}
case 325:{f.StackOp("pop");f.Pc=326;continue;}
case 326:{f.Push(f.Locals[3]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",330);}
case 330:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"));f.Pc=333;continue;}
case 333:{f.Push(f.Locals[9]);f.Pc=335;continue;}
case 335:{f.Push(JValue.I(0));f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",339);}
case 339:{f.Push(f.Locals[8]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",344);}
case 344:{f.Pc=f.Pop().Int!=0?394:347;continue;}
case 347:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",350);}
case 350:{f.Locals[9]=f.Pop();f.Pc=352;continue;}
case 352:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",355);}
case 355:{f.Locals[10]=f.Pop();f.Pc=357;continue;}
case 357:{f.Push(f.Locals[10]);f.Pc=359;continue;}
case 359:{f.Push(f.Locals[2]);f.Pc=360;continue;}
case 360:{f.Push(f.Locals[8]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",367);}
case 367:{f.StackOp("pop");f.Pc=368;continue;}
case 368:{f.Push(f.Locals[9]);f.Pc=370;continue;}
case 370:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"));f.Pc=373;continue;}
case 373:{f.Push(f.Locals[10]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",380);}
case 380:{f.StackOp("pop");f.Pc=381;continue;}
case 381:{f.Push(f.Locals[3]);f.Pc=382;continue;}
case 382:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",385);}
case 385:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","UntapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","UntapAll","Lforge/game/trigger/TriggerType;"));f.Pc=388;continue;}
case 388:{f.Push(f.Locals[9]);f.Pc=390;continue;}
case 390:{f.Push(JValue.I(0));f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",394);}
case 394:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
