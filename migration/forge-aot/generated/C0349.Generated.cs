// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C349{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/PlaneswalkEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3542,"forge/game/ability/effects/PlaneswalkEffect","<init>","()V",1,1,1,new JHandler[]{},M3542));
c.Add(new JMethod(3543,"forge/game/ability/effects/PlaneswalkEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,8,6,new JHandler[]{},M3543));
}

internal static JStep M3542(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3543(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/Game","getActivePlanes","()Ljava/util/List;","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Reference!=null?18:17;continue;}
case 17:{return JStep.ReturnVoid;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Optional")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?53:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(null));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",36);}
case 36:{f.Push(JValue.R(rt.String("lblWouldYouLikeToPlaneswalk")));f.Pc=38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Push(JValue.R(null));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int!=0?53:52;continue;}
case 52:{return JStep.ReturnVoid;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",57);}
case 57:{f.Locals[4]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("Cause")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?77:68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("Cause")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",74);}
case 74:{f.Pc=78;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Locals[5]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[4]);f.Pc=82;continue;}
case 82:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=85;continue;}
case 85:{f.Push(f.Locals[5]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",92);}
case 92:{f.StackOp("pop");f.Pc=93;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",97);}
case 97:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Planeswalk","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Planeswalk","Lforge/game/replacement/ReplacementType;"));f.Pc=100;continue;}
case 100:{f.Push(f.Locals[4]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",105);}
case 105:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Replaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Replaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=108;continue;}
case 108:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?112:111;continue;}
case 111:{return JStep.ReturnVoid;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{f.Push(JValue.R(rt.String("DontPlaneswalkAway")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int!=0?160:121;continue;}
case 121:{f.Push(f.Locals[3]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",125);}
case 125:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",128);}
case 128:{f.Locals[6]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[6]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",137);}
case 137:{f.Pc=f.Pop().Int==0?160:140;continue;}
case 140:{f.Push(f.Locals[6]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",147);}
case 147:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=150;continue;}
case 150:{f.Locals[7]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[7]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/player/Player","leaveCurrentPlane","()V","invokevirtual",157);}
case 157:{f.Pc=130;continue;}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{f.Push(JValue.R(rt.String("Defined")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",166);}
case 166:{f.Pc=f.Pop().Int==0?195:169;continue;}
case 169:{f.Push(f.Locals[1]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",173);}
case 173:{f.Push(f.Locals[1]);f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("Defined")));f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",179);}
case 179:{f.Push(f.Locals[1]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",183);}
case 183:{f.Locals[6]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[2]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[1]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[6]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/player/Player","planeswalkTo","(Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;)V","invokevirtual",192);}
case 192:{f.Pc=200;continue;}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[1]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/player/Player","planeswalk","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",200);}
case 200:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
