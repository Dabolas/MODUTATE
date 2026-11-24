// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C385{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RevealHandEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3663,"forge/game/ability/effects/RevealHandEffect","<init>","()V",1,1,1,new JHandler[]{},M3663));
c.Add(new JMethod(3664,"forge/game/ability/effects/RevealHandEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,5,3,new JHandler[]{},M3664));
c.Add(new JMethod(3665,"forge/game/ability/effects/RevealHandEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,7,6,new JHandler[]{},M3665));
}

internal static JStep M3663(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3664(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/RevealHandEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Int>0?36:26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Error - no target players for RevealHand.")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",32);}
case 32:{f.StackOp("pop");f.Pc=33;continue;}
case 33:{f.Pc=140;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("Look")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?92:45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",50);}
case 50:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",53);}
case 53:{f.Push(JValue.R(rt.String(" looks at ")));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",58);}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",62);}
case 62:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("'s ")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",72);}
case 72:{f.Push(f.Locals[4]);f.Pc=74;continue;}
case 74:{f.Push(JValue.I(1));f.Pc=75;continue;}
case 75:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?83:78;continue;}
case 78:{f.Push(JValue.R(rt.String("hand.")));f.Pc=80;continue;}
case 80:{f.Pc=85;continue;}
case 83:{f.Push(JValue.R(rt.String("hands.")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",88);}
case 88:{f.StackOp("pop");f.Pc=89;continue;}
case 89:{f.Pc=140;continue;}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",97);}
case 97:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",100);}
case 100:{f.Push(f.Locals[4]);f.Pc=102;continue;}
case 102:{f.Push(JValue.I(1));f.Pc=103;continue;}
case 103:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?111:106;continue;}
case 106:{f.Push(JValue.R(rt.String(" reveals")));f.Pc=108;continue;}
case 108:{f.Pc=113;continue;}
case 111:{f.Push(JValue.R(rt.String(" reveal")));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",116);}
case 116:{f.StackOp("pop");f.Pc=117;continue;}
case 117:{f.Push(f.Locals[2]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String(" their ")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",123);}
case 123:{f.Push(f.Locals[4]);f.Pc=125;continue;}
case 125:{f.Push(JValue.I(1));f.Pc=126;continue;}
case 126:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?134:129;continue;}
case 129:{f.Push(JValue.R(rt.String("hand.")));f.Pc=131;continue;}
case 131:{f.Pc=136;continue;}
case 134:{f.Push(JValue.R(rt.String("hands.")));f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",139);}
case 139:{f.StackOp("pop");f.Pc=140;continue;}
case 140:{f.Push(f.Locals[2]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",144);}
case 144:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3665(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Optional")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/ability/effects/RevealHandEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",16);}
case 16:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?210:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[5]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int!=0?54:51;continue;}
case 51:{f.Pc=21;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{f.Pc=f.Pop().Int==0?87:58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",63);}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(null));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",68);}
case 68:{f.Push(JValue.R(rt.String("lblDoYouWantRevealYourHand")));f.Pc=70;continue;}
case 70:{f.Push(JValue.I(0));f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",77);}
case 77:{f.Push(JValue.R(null));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int!=0?87:84;continue;}
case 84:{f.Pc=21;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",95);}
case 95:{f.Locals[6]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("RevealType")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",103);}
case 103:{f.Pc=f.Pop().Int==0?119:106;continue;}
case 106:{f.Push(f.Locals[6]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("RevealType")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",114);}
case 114:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",117);}
case 117:{f.Locals[6]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{f.Push(JValue.R(rt.String("Look")));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",125);}
case 125:{f.Pc=f.Pop().Int==0?148:128;continue;}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",132);}
case 132:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",135);}
case 135:{f.Push(f.Locals[6]);f.Pc=137;continue;}
case 137:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=140;continue;}
case 140:{f.Push(f.Locals[5]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/player/PlayerController","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;)V","invokevirtual",145);}
case 145:{f.Pc=162;continue;}
case 148:{f.Push(f.Locals[2]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",152);}
case 152:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",155);}
case 155:{f.Push(f.Locals[6]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[5]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;)V","invokevirtual",162);}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.String("RememberRevealed")));f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",168);}
case 168:{f.Pc=f.Pop().Int==0?177:171;continue;}
case 171:{f.Push(f.Locals[2]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[6]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",177);}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("ImprintRevealed")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",183);}
case 183:{f.Pc=f.Pop().Int==0?192:186;continue;}
case 186:{f.Push(f.Locals[2]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[6]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/card/Card","addImprintedCards","(Ljava/lang/Iterable;)V","invokevirtual",192);}
case 192:{f.Push(f.Locals[1]);f.Pc=193;continue;}
case 193:{f.Push(JValue.R(rt.String("RememberRevealedPlayer")));f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",198);}
case 198:{f.Pc=f.Pop().Int==0?207:201;continue;}
case 201:{f.Push(f.Locals[2]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[5]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",207);}
case 207:{f.Pc=21;continue;}
case 210:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
