// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C858{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityIgnoreHexproofShroud","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10027,"forge/game/staticability/StaticAbilityIgnoreHexproofShroud","<init>","()V",1,1,1,new JHandler[]{},M10027));
c.Add(new JMethod(10028,"forge/game/staticability/StaticAbilityIgnoreHexproofShroud","ignore","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;Lforge/game/staticability/StaticAbility;)Z",9,8,3,new JHandler[]{},M10028));
c.Add(new JMethod(10029,"forge/game/staticability/StaticAbilityIgnoreHexproofShroud","commonAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)Z",12,4,3,new JHandler[]{},M10029));
}

internal static JStep M10027(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10028(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntity","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?141:29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",51);}
case 51:{f.Locals[6]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",60);}
case 60:{f.Pc=f.Pop().Int==0?138:63;continue;}
case 63:{f.Push(f.Locals[6]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{f.Locals[7]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","HEXPROOF","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","HEXPROOF","Lforge/game/keyword/Keyword;"));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/staticability/StaticAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Int==0?99:85;continue;}
case 85:{f.Push(f.Locals[7]);f.Pc=87;continue;}
case 87:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","IgnoreHexproof","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","IgnoreHexproof","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int!=0?99:96;continue;}
case 96:{f.Pc=53;continue;}
case 99:{f.Push(f.Locals[2]);f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","SHROUD","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","SHROUD","Lforge/game/keyword/Keyword;"));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/staticability/StaticAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?123:109;continue;}
case 109:{f.Push(f.Locals[7]);f.Pc=111;continue;}
case 111:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","IgnoreShroud","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","IgnoreShroud","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",117);}
case 117:{f.Pc=f.Pop().Int!=0?123:120;continue;}
case 120:{f.Pc=53;continue;}
case 123:{f.Push(f.Locals[7]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[1]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/staticability/StaticAbilityIgnoreHexproofShroud","commonAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)Z","invokestatic",130);}
case 130:{f.Pc=f.Pop().Int==0?135:133;continue;}
case 133:{f.Push(JValue.I(1));f.Pc=134;continue;}
case 134:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 135:{f.Pc=53;continue;}
case 138:{f.Pc=19;continue;}
case 141:{f.Push(JValue.I(0));f.Pc=142;continue;}
case 142:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10029(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Activator")));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int!=0?17:15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("ValidEntity")));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?29:27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
