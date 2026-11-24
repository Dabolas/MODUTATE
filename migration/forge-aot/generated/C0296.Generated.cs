// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C296{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/EarthbendEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3367,"forge/game/ability/effects/EarthbendEffect","<init>","()V",1,1,1,new JHandler[]{},M3367));
c.Add(new JMethod(3368,"forge/game/ability/effects/EarthbendEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,5,4,new JHandler[]{},M3368));
c.Add(new JMethod(3369,"forge/game/ability/effects/EarthbendEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V",1,3,6,new JHandler[]{},M3369));
c.Add(new JMethod(3370,"forge/game/ability/effects/EarthbendEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,14,11,new JHandler[]{},M3370));
c.Add(new JMethod(3371,"forge/game/ability/effects/EarthbendEffect","buildTrigger","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Ljava/lang/String;Ljava/lang/String;)V",4,10,4,new JHandler[]{},M3371));
}

internal static JStep M3367(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3368(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Earthbend ")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Num")));f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("1")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",28);}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",36);}
case 36:{f.Push(JValue.R(rt.String(". (Target land you control becomes a 0/0 creature with haste that's still a land. Put  ")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("+1/+1 counter")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/util/Lang","nounWithNumeral","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",50);}
case 50:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String(" on it. When it dies or is exiled, return it to the battlefield tapped under your control.)")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",65);}
case 65:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3369(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokespecial",5);}
case 5:{if(!rt.EnsureInitialized(f,"forge/game/spellability/TargetRestrictions"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/TargetRestrictions")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("ValidTgtsDesc")));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("land you control")));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("ValidTgts")));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("Land.YouCtrl")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Map","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;","invokestatic",20);}
case 20:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","<init>","(Ljava/util/Map;)V","invokespecial",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTargetRestrictions","(Lforge/game/spellability/TargetRestrictions;)V","invokevirtual",29);}
case 29:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3370(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("Num")));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("1")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",29);}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",35);}
case 35:{f.Locals[6]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("When it dies or is exiled, return it to the battlefield tapped.")));f.Pc=39;continue;}
case 39:{f.Locals[8]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[8]);f.Pc=43;continue;}
case 43:{return rt.DynamicCall(f,"forge/game/ability/effects/EarthbendEffect:3370:43:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",48);}
case 48:{f.Locals[9]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[8]);f.Pc=52;continue;}
case 52:{return rt.DynamicCall(f,"forge/game/ability/effects/EarthbendEffect:3370:52:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",57);}
case 57:{f.Locals[10]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/ability/effects/EarthbendEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",63);}
case 63:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",66);}
case 66:{f.Locals[11]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[11]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",75);}
case 75:{f.Pc=f.Pop().Int==0?206:78;continue;}
case 78:{f.Push(f.Locals[11]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",85);}
case 85:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=88;continue;}
case 88:{f.Locals[12]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[12]);f.Pc=92;continue;}
case 92:{f.Push(JValue.I(0));f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",96);}
case 96:{f.Push(JValue.I(0));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",100);}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{f.Push(JValue.L(0));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/Card","addNewPT","(Ljava/lang/Integer;Ljava/lang/Integer;JJ)V","invokevirtual",106);}
case 106:{f.Push(f.Locals[12]);f.Pc=108;continue;}
case 108:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("Creature")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",117);}
case 117:{f.Push(JValue.I(1));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/card/CardType","<init>","(Ljava/lang/Iterable;Z)V","invokespecial",121);}
case 121:{f.Push(JValue.R(null));f.Pc=122;continue;}
case 122:{f.Push(JValue.I(0));f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.ClassObject("forge/card/RemoveType")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",128);}
case 128:{f.Push(f.Locals[6]);f.Pc=130;continue;}
case 130:{f.Push(JValue.L(0));f.Pc=131;continue;}
case 131:{f.Push(JValue.I(1));f.Pc=132;continue;}
case 132:{f.Push(JValue.I(0));f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/card/Card","addChangedCardTypes","(Lforge/card/CardType;Lforge/card/CardType;ZLjava/util/Set;JJZZ)V","invokevirtual",136);}
case 136:{f.Push(f.Locals[12]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("Haste")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",143);}
case 143:{f.Push(JValue.R(null));f.Pc=144;continue;}
case 144:{f.Push(JValue.I(0));f.Pc=145;continue;}
case 145:{f.Push(f.Locals[6]);f.Pc=147;continue;}
case 147:{f.Push(JValue.R(null));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywords","(Ljava/util/List;Ljava/util/List;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",151);}
case 151:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=154;continue;}
case 154:{f.StackOp("dup");f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",158);}
case 158:{f.Locals[13]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[12]);f.Pc=162;continue;}
case 162:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"));f.Pc=165;continue;}
case 165:{f.Push(f.Locals[5]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[4]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[13]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",174);}
case 174:{f.Push(f.Locals[13]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[3]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",181);}
case 181:{f.Push(f.Locals[0]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[12]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[9]);f.Pc=187;continue;}
case 187:{f.Push(JValue.R(rt.String("Graveyard")));f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/ability/effects/EarthbendEffect","buildTrigger","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",192);}
case 192:{f.Push(f.Locals[0]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[1]);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[12]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[10]);f.Pc=198;continue;}
case 198:{f.Push(JValue.R(rt.String("Exile")));f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/ability/effects/EarthbendEffect","buildTrigger","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",203);}
case 203:{f.Pc=68;continue;}
case 206:{f.Push(f.Locals[4]);f.Pc=208;continue;}
case 208:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Earthbend","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Earthbend","Lforge/game/trigger/TriggerType;"));f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/player/Player","triggerElementalBend","(Lforge/game/trigger/TriggerType;)V","invokevirtual",214);}
case 214:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3371(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",11);}
case 11:{f.Locals[6]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{return rt.DynamicCall(f,"forge/game/ability/effects/EarthbendEffect:3371:15:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",20);}
case 20:{f.Locals[7]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",32);}
case 32:{f.Locals[8]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[7]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",40);}
case 40:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",43);}
case 43:{f.Locals[9]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[9]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",54);}
case 54:{f.Push(f.Locals[8]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/trigger/Trigger","addRemembered","(Ljava/lang/Object;)V","invokevirtual",60);}
case 60:{f.Push(f.Locals[8]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[9]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",67);}
case 67:{f.Push(f.Locals[8]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",74);}
case 74:{f.Push(JValue.I(1));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",78);}
case 78:{return rt.Call(f,"forge/game/trigger/Trigger","setSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",81);}
case 81:{f.Push(f.Locals[8]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[8]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/trigger/Trigger","getSpawningAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",88);}
case 88:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",91);}
case 91:{return rt.Call(f,"forge/game/trigger/Trigger","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",94);}
case 94:{f.Push(f.Locals[6]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",99);}
case 99:{f.Push(f.Locals[8]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerDelayedTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",104);}
case 104:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
