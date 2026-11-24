// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C305{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/FightEffect","forge/game/ability/effects/DamageBaseEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3398,"forge/game/ability/effects/FightEffect","<init>","()V",1,1,1,new JHandler[]{},M3398));
c.Add(new JMethod(3399,"forge/game/ability/effects/FightEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,5,4,new JHandler[]{},M3399));
c.Add(new JMethod(3400,"forge/game/ability/effects/FightEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,11,10,new JHandler[]{},M3400));
c.Add(new JMethod(3401,"forge/game/ability/effects/FightEffect","getFighters","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",10,12,3,new JHandler[]{},M3401));
c.Add(new JMethod(3402,"forge/game/ability/effects/FightEffect","dealDamage","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/Card;)V",2,10,6,new JHandler[]{},M3402));
}

internal static JStep M3398(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/DamageBaseEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3399(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/FightEffect","getFighters","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",19);}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?58:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",31);}
case 31:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",34);}
case 34:{f.Push(JValue.R(rt.String(" fights ")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",39);}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",46);}
case 46:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",49);}
case 49:{f.Push(JValue.R(rt.String(".")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{f.Pc=85;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",64);}
case 64:{f.Push(JValue.I(1));f.Pc=65;continue;}
case 65:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?85:68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{f.Push(JValue.I(0));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",76);}
case 76:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",79);}
case 79:{f.Push(JValue.R(rt.String(" fights.")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("ReplaceDyingDefined")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?143:94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",98);}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("ReplaceDyingDefined")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",104);}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",108);}
case 108:{f.Locals[4]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[4]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",115);}
case 115:{f.Pc=f.Pop().Int!=0?143:118;continue;}
case 118:{f.Push(f.Locals[2]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String(" If ")));f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",124);}
case 124:{f.Push(f.Locals[4]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(null));f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("or")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",132);}
case 132:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",135);}
case 135:{f.StackOp("pop");f.Pc=136;continue;}
case 136:{f.Push(f.Locals[2]);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String(" would die this turn, exile it instead.")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",142);}
case 142:{f.StackOp("pop");f.Pc=143;continue;}
case 143:{f.Push(f.Locals[2]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",147);}
case 147:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3400(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/effects/FightEffect","getFighters","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",22);}
case 22:{f.Push(JValue.I(2));f.Pc=23;continue;}
case 23:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?27:26;continue;}
case 26:{return JStep.ReturnVoid;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",31);}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("Optional")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",39);}
case 39:{f.Locals[6]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Locals[7]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{f.Pc=f.Pop().Int==0?111:58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",63);}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(null));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",68);}
case 68:{f.Push(JValue.R(rt.String("lblWouldYouLikeFight")));f.Pc=70;continue;}
case 70:{f.Push(JValue.I(2));f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[7]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",81);}
case 81:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=82;continue;}
case 82:{f.StackOp("dup");f.Pc=83;continue;}
case 83:{f.Push(JValue.I(1));f.Pc=84;continue;}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{f.Push(JValue.I(1));f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",91);}
case 91:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",97);}
case 97:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",101);}
case 101:{f.Push(f.Locals[7]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(null));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int!=0?111:110;continue;}
case 110:{return JStep.ReturnVoid;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[3]);f.Pc=114;continue;}
case 114:{f.Push(JValue.I(0));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",120);}
case 120:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[3]);f.Pc=124;continue;}
case 124:{f.Push(JValue.I(1));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",130);}
case 130:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/ability/effects/FightEffect","dealDamage","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",136);}
case 136:{f.Push(f.Locals[3]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",142);}
case 142:{f.Locals[8]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[8]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",151);}
case 151:{f.Pc=f.Pop().Int==0?201:154;continue;}
case 154:{f.Push(f.Locals[8]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",161);}
case 161:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=164;continue;}
case 164:{f.Locals[9]=f.Pop();f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",169);}
case 169:{f.Locals[10]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[10]);f.Pc=173;continue;}
case 173:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Fighter","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Fighter","Lforge/game/ability/AbilityKey;"));f.Pc=176;continue;}
case 176:{f.Push(f.Locals[9]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",183);}
case 183:{f.StackOp("pop");f.Pc=184;continue;}
case 184:{f.Push(f.Locals[4]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",189);}
case 189:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Fight","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Fight","Lforge/game/trigger/TriggerType;"));f.Pc=192;continue;}
case 192:{f.Push(f.Locals[10]);f.Pc=194;continue;}
case 194:{f.Push(JValue.I(0));f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",198);}
case 198:{f.Pc=144;continue;}
case 201:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",204);}
case 204:{f.Locals[8]=f.Pop();f.Pc=206;continue;}
case 206:{f.Push(f.Locals[8]);f.Pc=208;continue;}
case 208:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Fighters","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Fighters","Lforge/game/ability/AbilityKey;"));f.Pc=211;continue;}
case 211:{f.Push(f.Locals[3]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",217);}
case 217:{f.StackOp("pop");f.Pc=218;continue;}
case 218:{f.Push(f.Locals[4]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",223);}
case 223:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","FightOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","FightOnce","Lforge/game/trigger/TriggerType;"));f.Pc=226;continue;}
case 226:{f.Push(f.Locals[8]);f.Pc=228;continue;}
case 228:{f.Push(JValue.I(0));f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",232);}
case 232:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3401(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",12);}
case 12:{f.Locals[4]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",19);}
case 19:{f.Locals[5]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(JValue.R(null));f.Pc=22;continue;}
case 22:{f.Locals[6]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?62:31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",35);}
case 35:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",38);}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",47);}
case 47:{f.Pc=f.Pop().Int!=0?62:50;continue;}
case 50:{f.Push(f.Locals[6]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{f.Locals[2]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("Defined")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int==0?254:71;continue;}
case 71:{f.Push(JValue.I(1));f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("Defined")));f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/ability/effects/FightEffect","getTargetCardsWithDuplicates","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",78);}
case 78:{f.Locals[7]=f.Pop();f.Pc=80;continue;}
case 80:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",83);}
case 83:{f.Locals[8]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[7]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",92);}
case 92:{f.Locals[9]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[9]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",101);}
case 101:{f.Pc=f.Pop().Int==0?181:104;continue;}
case 104:{f.Push(f.Locals[9]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",111);}
case 111:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=114;continue;}
case 114:{f.Locals[10]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[5]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[10]);f.Pc=120;continue;}
case 120:{f.Push(JValue.R(null));f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",124);}
case 124:{f.Locals[11]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[11]);f.Pc=128;continue;}
case 128:{f.Pc=f.Pop().Reference==null?94:131;continue;}
case 131:{f.Push(f.Locals[11]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[10]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",138);}
case 138:{f.Pc=f.Pop().Int==0?94:141;continue;}
case 141:{f.Push(f.Locals[10]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",146);}
case 146:{f.Pc=f.Pop().Int==0?94:149;continue;}
case 149:{f.Push(f.Locals[10]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",154);}
case 154:{f.Pc=f.Pop().Int!=0?94:157;continue;}
case 157:{f.Push(f.Locals[10]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",162);}
case 162:{f.Pc=f.Pop().Int!=0?168:165;continue;}
case 165:{f.Pc=94;continue;}
case 168:{f.Push(f.Locals[8]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[11]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",177);}
case 177:{f.StackOp("pop");f.Pc=178;continue;}
case 178:{f.Pc=94;continue;}
case 181:{f.Push(f.Locals[8]);f.Pc=183;continue;}
case 183:{f.Locals[7]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[7]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",192);}
case 192:{f.Pc=f.Pop().Int!=0?251:195;continue;}
case 195:{f.Push(f.Locals[7]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",202);}
case 202:{f.Push(JValue.I(1));f.Pc=203;continue;}
case 203:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?237:206;continue;}
case 206:{f.Push(f.Locals[2]);f.Pc=207;continue;}
case 207:{f.Pc=f.Pop().Reference!=null?237:210;continue;}
case 210:{f.Push(f.Locals[7]);f.Pc=212;continue;}
case 212:{f.Push(JValue.I(0));f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",218);}
case 218:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=221;continue;}
case 221:{f.Locals[2]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(f.Locals[7]);f.Pc=224;continue;}
case 224:{f.Push(JValue.I(1));f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",230);}
case 230:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=233;continue;}
case 233:{f.Locals[3]=f.Pop();f.Pc=234;continue;}
case 234:{f.Pc=251;continue;}
case 237:{f.Push(f.Locals[2]);f.Pc=238;continue;}
case 238:{f.Locals[3]=f.Pop();f.Pc=239;continue;}
case 239:{f.Push(f.Locals[7]);f.Pc=241;continue;}
case 241:{f.Push(JValue.I(0));f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",247);}
case 247:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=250;continue;}
case 250:{f.Locals[2]=f.Pop();f.Pc=251;continue;}
case 251:{f.Pc=277;continue;}
case 254:{f.Push(f.Locals[6]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",261);}
case 261:{f.Push(JValue.I(1));f.Pc=262;continue;}
case 262:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?277:265;continue;}
case 265:{f.Push(f.Locals[6]);f.Pc=267;continue;}
case 267:{f.Push(JValue.I(1));f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",273);}
case 273:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=276;continue;}
case 276:{f.Locals[3]=f.Pop();f.Pc=277;continue;}
case 277:{f.Push(f.Locals[2]);f.Pc=278;continue;}
case 278:{f.Pc=f.Pop().Reference==null?289:281;continue;}
case 281:{f.Push(f.Locals[1]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[2]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",288);}
case 288:{f.StackOp("pop");f.Pc=289;continue;}
case 289:{f.Push(f.Locals[3]);f.Pc=290;continue;}
case 290:{f.Pc=f.Pop().Reference==null?301:293;continue;}
case 293:{f.Push(f.Locals[1]);f.Pc=294;continue;}
case 294:{f.Push(f.Locals[3]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",300);}
case 300:{f.StackOp("pop");f.Pc=301;continue;}
case 301:{f.Push(f.Locals[1]);f.Pc=302;continue;}
case 302:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3402(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDamageMap","()Lforge/game/card/CardDamageTable;","invokevirtual",7);}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPreventMap","()Lforge/game/card/CardDamageTable;","invokevirtual",13);}
case 13:{f.Locals[6]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCounterTable","()Lforge/game/GameEntityCounterTable;","invokevirtual",19);}
case 19:{f.Locals[7]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[5]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Reference!=null?56:26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","()V","invokespecial",33);}
case 33:{f.Locals[5]=f.Pop();f.Pc=35;continue;}
case 35:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","()V","invokespecial",42);}
case 42:{f.Locals[6]=f.Pop();f.Pc=44;continue;}
case 44:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=47;continue;}
case 47:{f.StackOp("dup");f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",51);}
case 51:{f.Locals[7]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{f.Locals[4]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",60);}
case 60:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",63);}
case 63:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","AssignDealDamage","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","AssignDealDamage","Lforge/game/replacement/ReplacementType;"));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",70);}
case 70:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",73);}
case 73:{f.StackOp("pop");f.Pc=74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",78);}
case 78:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",81);}
case 81:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","AssignDealDamage","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","AssignDealDamage","Lforge/game/replacement/ReplacementType;"));f.Pc=84;continue;}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",88);}
case 88:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",91);}
case 91:{f.StackOp("pop");f.Pc=92;continue;}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",96);}
case 96:{f.Locals[8]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",103);}
case 103:{f.Pc=f.Pop().Int==0?124:106;continue;}
case 106:{f.Push(f.Locals[5]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[2]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[8]);f.Pc=112;continue;}
case 112:{f.Push(JValue.I(2));f.Pc=113;continue;}
case 113:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",117);}
case 117:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",120);}
case 120:{f.StackOp("pop");f.Pc=121;continue;}
case 121:{f.Pc=161;continue;}
case 124:{f.Push(f.Locals[3]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",128);}
case 128:{f.Locals[9]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[5]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[2]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[3]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[8]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",139);}
case 139:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",142);}
case 142:{f.StackOp("pop");f.Pc=143;continue;}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[3]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[2]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[9]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",152);}
case 152:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",155);}
case 155:{f.StackOp("pop");f.Pc=156;continue;}
case 156:{f.Push(f.Locals[3]);f.Pc=157;continue;}
case 157:{f.Push(JValue.I(1));f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/card/Card","setFoughtThisTurn","(Z)V","invokevirtual",161);}
case 161:{f.Push(f.Locals[2]);f.Pc=162;continue;}
case 162:{f.Push(JValue.I(1));f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/card/Card","setFoughtThisTurn","(Z)V","invokevirtual",166);}
case 166:{f.Push(f.Locals[4]);f.Pc=168;continue;}
case 168:{f.Pc=f.Pop().Int!=0?192:171;continue;}
case 171:{f.Push(f.Locals[1]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",175);}
case 175:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",178);}
case 178:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",181);}
case 181:{f.Push(JValue.I(0));f.Pc=182;continue;}
case 182:{f.Push(f.Locals[5]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[6]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[7]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[1]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/GameAction","dealDamage","(ZLforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;Lforge/game/GameEntityCounterTable;Lforge/game/spellability/SpellAbility;)V","invokevirtual",192);}
case 192:{f.Push(f.Locals[1]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/ability/effects/FightEffect","replaceDying","(Lforge/game/spellability/SpellAbility;)V","invokestatic",196);}
case 196:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
