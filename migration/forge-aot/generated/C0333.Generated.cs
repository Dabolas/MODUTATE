// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C333{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ManifestDreadEffect","forge/game/ability/effects/ManifestEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3500,"forge/game/ability/effects/ManifestDreadEffect","<init>","()V",1,1,1,new JHandler[]{},M3500));
c.Add(new JMethod(3501,"forge/game/ability/effects/ManifestDreadEffect","manifestLoop","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;I)V",4,13,5,new JHandler[]{},M3501));
}

internal static JStep M3500(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/ManifestEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3501(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[5]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?206:15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(2));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/player/Player","getTopXCardsFromLibrary","(I)Lforge/game/card/CardCollection;","invokevirtual",20);}
case 20:{f.Locals[6]=f.Pop();f.Pc=22;continue;}
case 22:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",29);}
case 29:{f.Locals[7]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[6]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int!=0?167:39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",43);}
case 43:{f.Push(f.Locals[6]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/ability/effects/ManifestDreadEffect","getDefaultMessage","()Ljava/lang/String;","invokevirtual",50);}
case 50:{f.Push(JValue.R(null));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{f.Locals[8]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[6]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[8]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",70);}
case 70:{f.Locals[9]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[9]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",78);}
case 78:{f.Locals[10]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[8]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[9]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/ability/effects/ManifestDreadEffect","internalEffect","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",90);}
case 90:{f.Locals[8]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[8]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/card/Card","isManifested","()Z","invokevirtual",97);}
case 97:{f.Pc=f.Pop().Int!=0?108:100;continue;}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[8]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",107);}
case 107:{f.StackOp("pop");f.Pc=108;continue;}
case 108:{f.Push(f.Locals[6]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",113);}
case 113:{f.Locals[11]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[11]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",122);}
case 122:{f.Pc=f.Pop().Int==0?159:125;continue;}
case 125:{f.Push(f.Locals[11]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",132);}
case 132:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=135;continue;}
case 135:{f.Locals[12]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[7]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[4]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",144);}
case 144:{f.Push(f.Locals[12]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[9]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/GameAction","moveToGraveyard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",152);}
case 152:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",155);}
case 155:{f.StackOp("pop");f.Pc=156;continue;}
case 156:{f.Pc=115;continue;}
case 159:{f.Push(f.Locals[10]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[4]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[1]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",167);}
case 167:{f.Push(f.Locals[2]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",171);}
case 171:{f.Locals[8]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[8]);f.Pc=175;continue;}
case 175:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=178;continue;}
case 178:{f.Push(f.Locals[7]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",185);}
case 185:{f.StackOp("pop");f.Pc=186;continue;}
case 186:{f.Push(f.Locals[4]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",191);}
case 191:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ManifestDread","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ManifestDread","Lforge/game/trigger/TriggerType;"));f.Pc=194;continue;}
case 194:{f.Push(f.Locals[8]);f.Pc=196;continue;}
case 196:{f.Push(JValue.I(1));f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",200);}
case 200:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=203;continue;}
case 203:{f.Pc=9;continue;}
case 206:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
