// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C244{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ClashEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3174,"forge/game/ability/effects/ClashEffect","<init>","()V",1,1,1,new JHandler[]{},M3174));
c.Add(new JMethod(3175,"forge/game/ability/effects/ClashEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,1,new JHandler[]{},M3175));
c.Add(new JMethod(3176,"forge/game/ability/effects/ClashEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,8,6,new JHandler[]{},M3176));
c.Add(new JMethod(3177,"forge/game/ability/effects/ClashEffect","clashWithOpponent","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/player/Player;",10,14,5,new JHandler[]{},M3177));
c.Add(new JMethod(3178,"forge/game/ability/effects/ClashEffect","clashMoveToTopOrBottom","(Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V",10,7,5,new JHandler[]{},M3178));
}

internal static JStep M3174(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3175(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return rt.DynamicCall(f,"forge/game/ability/effects/ClashEffect:3175:7:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3176(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Defined")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?39:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("Defined")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",30);}
case 30:{return rt.Call(f,"forge/game/player/PlayerCollection","getFirst","()Ljava/lang/Object;","invokevirtual",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Pc=70;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",46);}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/player/Player","getOpponents","()Lforge/game/player/PlayerCollection;","invokevirtual",50);}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",54);}
case 54:{f.Push(JValue.R(rt.String("lblChooseOpponent")));f.Pc=56;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",63);}
case 63:{f.Push(JValue.R(null));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",67);}
case 67:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=70;continue;}
case 70:{f.Locals[4]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[4]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/ability/effects/ClashEffect","clashWithOpponent","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/player/Player;","invokestatic",78);}
case 78:{f.Locals[5]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[5]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int==0?110:89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("WinSubAbility")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",95);}
case 95:{f.Locals[6]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[6]);f.Pc=99;continue;}
case 99:{f.Pc=f.Pop().Reference==null?107:102;continue;}
case 102:{f.Push(f.Locals[6]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",107);}
case 107:{f.Pc=128;continue;}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String("OtherwiseSubAbility")));f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",116);}
case 116:{f.Locals[6]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[6]);f.Pc=120;continue;}
case 120:{f.Pc=f.Pop().Reference==null?128:123;continue;}
case 123:{f.Push(f.Locals[6]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",128);}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",132);}
case 132:{f.Locals[6]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[6]);f.Pc=136;continue;}
case 136:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Won","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Won","Lforge/game/ability/AbilityKey;"));f.Pc=139;continue;}
case 139:{f.Push(f.Locals[3]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[5]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",145);}
case 145:{f.Pc=f.Pop().Int==0?153:148;continue;}
case 148:{f.Push(JValue.R(rt.String("True")));f.Pc=150;continue;}
case 150:{f.Pc=155;continue;}
case 153:{f.Push(JValue.R(rt.String("False")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",160);}
case 160:{f.StackOp("pop");f.Pc=161;continue;}
case 161:{f.Push(f.Locals[2]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",165);}
case 165:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",168);}
case 168:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Clashed","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Clashed","Lforge/game/trigger/TriggerType;"));f.Pc=171;continue;}
case 171:{f.Push(f.Locals[6]);f.Pc=173;continue;}
case 173:{f.Push(JValue.I(0));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",177);}
case 177:{f.Push(f.Locals[4]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",182);}
case 182:{f.Locals[7]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(f.Locals[7]);f.Pc=186;continue;}
case 186:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Won","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Won","Lforge/game/ability/AbilityKey;"));f.Pc=189;continue;}
case 189:{f.Push(f.Locals[4]);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[5]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",196);}
case 196:{f.Pc=f.Pop().Int==0?204:199;continue;}
case 199:{f.Push(JValue.R(rt.String("True")));f.Pc=201;continue;}
case 201:{f.Pc=206;continue;}
case 204:{f.Push(JValue.R(rt.String("False")));f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",211);}
case 211:{f.StackOp("pop");f.Pc=212;continue;}
case 212:{f.Push(f.Locals[2]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",216);}
case 216:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",219);}
case 219:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Clashed","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Clashed","Lforge/game/trigger/TriggerType;"));f.Pc=222;continue;}
case 222:{f.Push(f.Locals[7]);f.Pc=224;continue;}
case 224:{f.Push(JValue.I(0));f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",228);}
case 228:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3177(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=13;continue;}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("RememberClasher")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?29:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",29);}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",35);}
case 35:{f.Locals[5]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",43);}
case 43:{f.Locals[6]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/zone/PlayerZone","isEmpty","()Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?63:53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/zone/PlayerZone","isEmpty","()Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?63:61;continue;}
case 61:{f.Push(JValue.R(null));f.Pc=62;continue;}
case 62:{return JStep.Return(f.Pop());}
case 63:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=66;continue;}
case 66:{f.StackOp("dup");f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",70);}
case 70:{f.Locals[7]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(JValue.R(null));f.Pc=73;continue;}
case 73:{f.Locals[8]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(JValue.R(null));f.Pc=76;continue;}
case 76:{f.Locals[9]=f.Pop();f.Pc=78;continue;}
case 78:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",85);}
case 85:{f.Locals[10]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(JValue.I(-1));f.Pc=88;continue;}
case 88:{f.Locals[11]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(JValue.I(-1));f.Pc=91;continue;}
case 91:{f.Locals[12]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[5]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/zone/PlayerZone","isEmpty","()Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int!=0?192:101;continue;}
case 101:{f.Push(f.Locals[5]);f.Pc=103;continue;}
case 103:{f.Push(JValue.I(0));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/zone/PlayerZone","get","(I)Lforge/game/card/Card;","invokevirtual",107);}
case 107:{f.Locals[8]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[8]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",114);}
case 114:{f.Locals[11]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[10]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[8]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",123);}
case 123:{f.StackOp("pop");f.Pc=124;continue;}
case 124:{f.Push(f.Locals[7]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",130);}
case 130:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",133);}
case 133:{f.Push(JValue.R(rt.String("lblReveals")));f.Pc=135;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",142);}
case 142:{return rt.DynamicCall(f,"forge/game/ability/effects/ClashEffect:3177:142:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",147);}
case 147:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",150);}
case 150:{f.Push(f.Locals[8]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",155);}
case 155:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",158);}
case 158:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",161);}
case 161:{f.Push(JValue.R(rt.String("lblCMC")));f.Pc=163;continue;}
case 163:{f.Push(JValue.I(0));f.Pc=164;continue;}
case 164:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",170);}
case 170:{return rt.DynamicCall(f,"forge/game/ability/effects/ClashEffect:3177:170:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",175);}
case 175:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",178);}
case 178:{f.Push(f.Locals[11]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",183);}
case 183:{f.StackOp("pop");f.Pc=184;continue;}
case 184:{f.Push(f.Locals[7]);f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String("\n")));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",191);}
case 191:{f.StackOp("pop");f.Pc=192;continue;}
case 192:{f.Push(f.Locals[6]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/zone/PlayerZone","isEmpty","()Z","invokevirtual",197);}
case 197:{f.Pc=f.Pop().Int!=0?291:200;continue;}
case 200:{f.Push(f.Locals[6]);f.Pc=202;continue;}
case 202:{f.Push(JValue.I(0));f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/zone/PlayerZone","get","(I)Lforge/game/card/Card;","invokevirtual",206);}
case 206:{f.Locals[9]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[9]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",213);}
case 213:{f.Locals[12]=f.Pop();f.Pc=215;continue;}
case 215:{f.Push(f.Locals[10]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[9]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",222);}
case 222:{f.StackOp("pop");f.Pc=223;continue;}
case 223:{f.Push(f.Locals[7]);f.Pc=225;continue;}
case 225:{f.Push(f.Locals[1]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",229);}
case 229:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",232);}
case 232:{f.Push(JValue.R(rt.String("lblReveals")));f.Pc=234;continue;}
case 234:{f.Push(JValue.I(0));f.Pc=235;continue;}
case 235:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",241);}
case 241:{return rt.DynamicCall(f,"forge/game/ability/effects/ClashEffect:3177:241:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",246);}
case 246:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",249);}
case 249:{f.Push(f.Locals[9]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",254);}
case 254:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",257);}
case 257:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",260);}
case 260:{f.Push(JValue.R(rt.String("lblCMC")));f.Pc=262;continue;}
case 262:{f.Push(JValue.I(0));f.Pc=263;continue;}
case 263:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=266;continue;}
case 266:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",269);}
case 269:{return rt.DynamicCall(f,"forge/game/ability/effects/ClashEffect:3177:269:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",274);}
case 274:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",277);}
case 277:{f.Push(f.Locals[12]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",282);}
case 282:{f.StackOp("pop");f.Pc=283;continue;}
case 283:{f.Push(f.Locals[7]);f.Pc=285;continue;}
case 285:{f.Push(JValue.R(rt.String("\n")));f.Pc=287;continue;}
case 287:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",290);}
case 290:{f.StackOp("pop");f.Pc=291;continue;}
case 291:{f.Push(JValue.R(null));f.Pc=292;continue;}
case 292:{f.Locals[13]=f.Pop();f.Pc=294;continue;}
case 294:{f.Push(f.Locals[11]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[12]);f.Pc=298;continue;}
case 298:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?322:301;continue;}
case 301:{f.Push(f.Locals[7]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",306);}
case 306:{f.Push(JValue.R(rt.String("lblNoWinner")));f.Pc=308;continue;}
case 308:{f.Push(JValue.I(0));f.Pc=309;continue;}
case 309:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",315);}
case 315:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",318);}
case 318:{f.StackOp("pop");f.Pc=319;continue;}
case 319:{f.Pc=364;continue;}
case 322:{f.Push(f.Locals[11]);f.Pc=324;continue;}
case 324:{f.Push(f.Locals[12]);f.Pc=326;continue;}
case 326:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?333:329;continue;}
case 329:{f.Push(f.Locals[3]);f.Pc=330;continue;}
case 330:{f.Pc=334;continue;}
case 333:{f.Push(f.Locals[1]);f.Pc=334;continue;}
case 334:{f.Locals[13]=f.Pop();f.Pc=336;continue;}
case 336:{f.Push(f.Locals[7]);f.Pc=338;continue;}
case 338:{f.Push(f.Locals[13]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",343);}
case 343:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",346);}
case 346:{f.Push(JValue.R(rt.String("lblWinsClash")));f.Pc=348;continue;}
case 348:{f.Push(JValue.I(0));f.Pc=349;continue;}
case 349:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",355);}
case 355:{return rt.DynamicCall(f,"forge/game/ability/effects/ClashEffect:3177:355:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",360);}
case 360:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",363);}
case 363:{f.StackOp("pop");f.Pc=364;continue;}
case 364:{f.Push(f.Locals[3]);f.Pc=365;continue;}
case 365:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",368);}
case 368:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",371);}
case 371:{f.Push(f.Locals[10]);f.Pc=373;continue;}
case 373:{f.Push(f.Locals[3]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",377);}
case 377:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",380);}
case 380:{f.Push(f.Locals[7]);f.Pc=382;continue;}
case 382:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",385);}
case 385:{f.Push(JValue.I(0));f.Pc=386;continue;}
case 386:{return rt.Call(f,"forge/game/GameAction","revealTo","(Lforge/game/card/CardCollectionView;Ljava/lang/Iterable;Ljava/lang/String;Z)V","invokevirtual",389);}
case 389:{f.Push(f.Locals[3]);f.Pc=390;continue;}
case 390:{f.Push(f.Locals[8]);f.Pc=392;continue;}
case 392:{f.Push(f.Locals[0]);f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/ability/effects/ClashEffect","clashMoveToTopOrBottom","(Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",396);}
case 396:{f.Push(f.Locals[1]);f.Pc=397;continue;}
case 397:{f.Push(f.Locals[9]);f.Pc=399;continue;}
case 399:{f.Push(f.Locals[0]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"forge/game/ability/effects/ClashEffect","clashMoveToTopOrBottom","(Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",403);}
case 403:{f.Push(f.Locals[13]);f.Pc=405;continue;}
case 405:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3178(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?5:4;continue;}
case 4:{return JStep.ReturnVoid;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",17);}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/player/PlayerController","willPutCardOnTop","(Lforge/game/card/Card;)Z","invokevirtual",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Int==0?33:28;continue;}
case 28:{f.Push(JValue.R(rt.String("top")));f.Pc=30;continue;}
case 30:{f.Pc=35;continue;}
case 33:{f.Push(JValue.R(rt.String("bottom")));f.Pc=35;continue;}
case 35:{f.Locals[5]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",41);}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{return rt.DynamicCall(f,"forge/game/ability/effects/ClashEffect:3178:47:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",52);}
case 52:{f.Locals[6]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{f.Pc=f.Pop().Int==0?69:59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Pc=76;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/GameAction","moveToBottomOfLibrary","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",80);}
case 80:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[6]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",92);}
case 92:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",95);}
case 95:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
