// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C193{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ActivateAbilityEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(2993,"forge/game/ability/effects/ActivateAbilityEffect","<init>","()V",1,1,1,new JHandler[]{},M2993));
c.Add(new JMethod(2994,"forge/game/ability/effects/ActivateAbilityEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,4,new JHandler[]{},M2994));
c.Add(new JMethod(2995,"forge/game/ability/effects/ActivateAbilityEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,10,6,new JHandler[]{},M2995));
}

internal static JStep M2993(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2994(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/ActivateAbilityEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String(", ")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",20);}
case 20:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String(" activates ")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("ManaAbility")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int==0?47:42;continue;}
case 42:{f.Push(JValue.R(rt.String("mana ability")));f.Pc=44;continue;}
case 44:{f.Pc=49;continue;}
case 47:{f.Push(JValue.R(rt.String("ability")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/util/Lang","nounWithAmount","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",52);}
case 52:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String(" of each ")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",62);}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("Type")));f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("Card")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",70);}
case 70:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",73);}
case 73:{f.StackOp("pop");f.Pc=74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String(" they control.")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",80);}
case 80:{f.StackOp("pop");f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",85);}
case 85:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2995(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ManaAbility")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/ability/effects/ActivateAbilityEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?183:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int!=0?46:43;continue;}
case 43:{f.Pc=15;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",54);}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("Type")));f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("Card")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",65);}
case 65:{f.Locals[5]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[5]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",74);}
case 74:{f.Locals[6]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[6]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",83);}
case 83:{f.Pc=f.Pop().Int==0?180:86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",93);}
case 93:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=96;continue;}
case 96:{f.Locals[7]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[7]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[4]);f.Pc=102;continue;}
case 102:{f.Push(JValue.I(1));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/Card","getAllPossibleAbilities","(Lforge/game/player/Player;Z)Ljava/util/List;","invokevirtual",106);}
case 106:{f.Locals[8]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[2]);f.Pc=109;continue;}
case 109:{f.Pc=f.Pop().Int==0?125:112;continue;}
case 112:{f.Push(f.Locals[8]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[7]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/card/Card","getManaAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",119);}
case 119:{return rt.Call(f,"java/util/List","retainAll","(Ljava/util/Collection;)Z","invokeinterface",124);}
case 124:{f.StackOp("pop");f.Pc=125;continue;}
case 125:{f.Push(f.Locals[8]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",132);}
case 132:{f.Pc=f.Pop().Int==0?138:135;continue;}
case 135:{f.Pc=76;continue;}
case 138:{f.Push(f.Locals[4]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",143);}
case 143:{f.Push(f.Locals[8]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",149);}
case 149:{f.Push(JValue.R(rt.String("lblChooseManaAbility")));f.Pc=151;continue;}
case 151:{f.Push(JValue.I(0));f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",158);}
case 158:{return rt.Call(f,"com/google/common/collect/ImmutableMap","of","()Lcom/google/common/collect/ImmutableMap;","invokestatic",161);}
case 161:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleSpellForEffect","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/spellability/SpellAbility;","invokevirtual",164);}
case 164:{f.Locals[9]=f.Pop();f.Pc=166;continue;}
case 166:{f.Push(f.Locals[4]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",171);}
case 171:{f.Push(f.Locals[9]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/player/PlayerController","playChosenSpellAbility","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",176);}
case 176:{f.StackOp("pop");f.Pc=177;continue;}
case 177:{f.Pc=76;continue;}
case 180:{f.Pc=15;continue;}
case 183:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
