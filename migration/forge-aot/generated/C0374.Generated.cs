// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C374{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ReorderZoneEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3630,"forge/game/ability/effects/ReorderZoneEffect","<init>","()V",1,1,1,new JHandler[]{},M3630));
c.Add(new JMethod(3631,"forge/game/ability/effects/ReorderZoneEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,5,3,new JHandler[]{},M3631));
c.Add(new JMethod(3632,"forge/game/ability/effects/ReorderZoneEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,8,4,new JHandler[]{},M3632));
}

internal static JStep M3630(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3631(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Zone")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/ability/effects/ReorderZoneEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Random")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",27);}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/zone/ZoneType","toString","()Ljava/lang/String;","invokevirtual",31);}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Int==0?41:36;continue;}
case 36:{f.Push(JValue.R(rt.String("at random.")));f.Pc=38;continue;}
case 38:{f.Pc=43;continue;}
case 41:{f.Push(JValue.R(rt.String("as your choose.")));f.Pc=43;continue;}
case 43:{return rt.DynamicCall(f,"forge/game/ability/effects/ReorderZoneEffect:3631:43:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",48);}
case 48:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3632(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Zone")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Random")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/ability/effects/ReorderZoneEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",21);}
case 21:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?128:36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{f.Locals[5]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int!=0?59:56;continue;}
case 56:{f.Pc=26;continue;}
case 59:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",69);}
case 69:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",72);}
case 72:{f.Locals[6]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{f.Pc=f.Pop().Int==0?100:78;continue;}
case 78:{f.Push(f.Locals[6]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",83);}
case 83:{return rt.Call(f,"java/util/Collections","shuffle","(Ljava/util/List;Ljava/util/Random;)V","invokestatic",86);}
case 86:{f.Push(f.Locals[5]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",92);}
case 92:{f.Push(f.Locals[6]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/zone/PlayerZone","setCards","(Ljava/lang/Iterable;)V","invokevirtual",97);}
case 97:{f.Pc=125;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",105);}
case 105:{f.Push(f.Locals[6]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[2]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/player/PlayerController","orderMoveToZoneList","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokevirtual",112);}
case 112:{f.Locals[7]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[5]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",120);}
case 120:{f.Push(f.Locals[7]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/zone/PlayerZone","setCards","(Ljava/lang/Iterable;)V","invokevirtual",125);}
case 125:{f.Pc=26;continue;}
case 128:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
