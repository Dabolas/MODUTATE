// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C408{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/TapAllEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3755,"forge/game/ability/effects/TapAllEffect","<init>","()V",1,1,1,new JHandler[]{},M3755));
c.Add(new JMethod(3756,"forge/game/ability/effects/TapAllEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,2,new JHandler[]{},M3756));
c.Add(new JMethod(3757,"forge/game/ability/effects/TapAllEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,11,4,new JHandler[]{},M3757));
}

internal static JStep M3755(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3756(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilitySub")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?10:7;continue;}
case 7:{f.Push(JValue.R(rt.String("Tap all valid cards.")));f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3757(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("RememberTapped")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Locals[5]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{f.Pc=f.Pop().Int==0?34:29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",34);}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int!=0?62:41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("Defined")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int!=0?62:50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",57);}
case 57:{f.Locals[6]=f.Pop();f.Pc=59;continue;}
case 59:{f.Pc=74;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/ability/effects/TapAllEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",66);}
case 66:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/player/PlayerCollection","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollection;","invokevirtual",72);}
case 72:{f.Locals[6]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",82);}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",86);}
case 86:{f.Locals[6]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{f.Locals[7]=f.Pop();f.Pc=91;continue;}
case 91:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=94;continue;}
case 94:{f.StackOp("dup");f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",98);}
case 98:{f.Locals[8]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",107);}
case 107:{f.Locals[9]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[9]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",116);}
case 116:{f.Pc=f.Pop().Int==0?181:119;continue;}
case 119:{f.Push(f.Locals[9]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",126);}
case 126:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=129;continue;}
case 129:{f.Locals[10]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[5]);f.Pc=133;continue;}
case 133:{f.Pc=f.Pop().Int==0?143:136;continue;}
case 136:{f.Push(f.Locals[4]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[10]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",143);}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{f.Push(JValue.R(rt.String("TapperController")));f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",149);}
case 149:{f.Pc=f.Pop().Int==0?159:152;continue;}
case 152:{f.Push(f.Locals[10]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",157);}
case 157:{f.Locals[7]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[10]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[1]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[7]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/card/Card","tap","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z","invokevirtual",167);}
case 167:{f.Pc=f.Pop().Int==0?178:170;continue;}
case 170:{f.Push(f.Locals[8]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[10]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",177);}
case 177:{f.StackOp("pop");f.Pc=178;continue;}
case 178:{f.Pc=109;continue;}
case 181:{f.Push(f.Locals[8]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",186);}
case 186:{f.Pc=f.Pop().Int!=0?220:189;continue;}
case 189:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",192);}
case 192:{f.Locals[9]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[9]);f.Pc=196;continue;}
case 196:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=199;continue;}
case 199:{f.Push(f.Locals[8]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",206);}
case 206:{f.StackOp("pop");f.Pc=207;continue;}
case 207:{f.Push(f.Locals[3]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",211);}
case 211:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"));f.Pc=214;continue;}
case 214:{f.Push(f.Locals[9]);f.Pc=216;continue;}
case 216:{f.Push(JValue.I(0));f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",220);}
case 220:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
