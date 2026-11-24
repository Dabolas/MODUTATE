// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C317{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/IncubateEffect","forge/game/ability/effects/TokenEffectBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3444,"forge/game/ability/effects/IncubateEffect","<init>","()V",1,1,1,new JHandler[]{},M3444));
c.Add(new JMethod(3445,"forge/game/ability/effects/IncubateEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,4,new JHandler[]{},M3445));
c.Add(new JMethod(3446,"forge/game/ability/effects/IncubateEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,10,6,new JHandler[]{},M3446));
}

internal static JStep M3444(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3445(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Amount")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",6);}
case 6:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",9);}
case 9:{f.Pc=f.Pop().Int!=0?48:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("Please add SpellDescription for non-numeric")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("(")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",27);}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Pc=f.Pop().Int<=0?46:32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("(")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",40);}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Locals[2]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return JStep.Return(f.Pop());}
case 48:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=51;continue;}
case 51:{f.StackOp("dup");f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("Incubate ")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",57);}
case 57:{f.Locals[2]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",62);}
case 62:{f.Locals[3]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("Amount")));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("1")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",72);}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",76);}
case 76:{f.Locals[4]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("Times")));f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("1")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",87);}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",91);}
case 91:{f.Locals[5]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[4]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",99);}
case 99:{f.StackOp("pop");f.Pc=100;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{f.Push(JValue.I(1));f.Pc=103;continue;}
case 103:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?134:106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String(" ")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",112);}
case 112:{f.Push(f.Locals[5]);f.Pc=114;continue;}
case 114:{f.Push(JValue.I(2));f.Pc=115;continue;}
case 115:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?123:118;continue;}
case 118:{f.Push(JValue.R(rt.String("twice")));f.Pc=120;continue;}
case 120:{f.Pc=130;continue;}
case 123:{f.Push(f.Locals[4]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("times")));f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/util/Lang","nounWithNumeral","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",130);}
case 130:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",133);}
case 133:{f.StackOp("pop");f.Pc=134;continue;}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.String(".")));f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",140);}
case 140:{f.StackOp("pop");f.Pc=141;continue;}
case 141:{f.Push(f.Locals[2]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",145);}
case 145:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3446(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("Times")));f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("1")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("P1P1")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("WithCountersAmount")));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("Amount")));f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("1")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/ability/effects/IncubateEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",53);}
case 53:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",56);}
case 56:{f.Locals[5]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int==0?180:68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",75);}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{f.Locals[6]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(JValue.I(0));f.Pc=81;continue;}
case 81:{f.Locals[7]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[7]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[4]);f.Pc=87;continue;}
case 87:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?177:90;continue;}
case 90:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=93;continue;}
case 93:{f.StackOp("dup");f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",97);}
case 97:{f.Locals[8]=f.Pop();f.Pc=99;continue;}
case 99:{if(!rt.EnsureInitialized(f,"org/apache/commons/lang3/mutable/MutableBoolean"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("org/apache/commons/lang3/mutable/MutableBoolean")));f.Pc=102;continue;}
case 102:{f.StackOp("dup");f.Pc=103;continue;}
case 103:{f.Push(JValue.I(0));f.Pc=104;continue;}
case 104:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","<init>","(Z)V","invokespecial",107);}
case 107:{f.Locals[9]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[6]);f.Pc=113;continue;}
case 113:{f.Push(JValue.R(rt.String("incubator_c_0_0_a_phyrexian")));f.Pc=115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/ability/effects/IncubateEffect","makeTokenTableInternal","(Lforge/game/player/Player;Ljava/lang/String;ILforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;","invokevirtual",120);}
case 120:{f.Push(JValue.I(0));f.Pc=121;continue;}
case 121:{f.Push(f.Locals[8]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[9]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/ability/effects/IncubateEffect","makeTokenTable","(Lforge/game/card/TokenCreateTable;ZLforge/game/card/CardZoneTable;Lorg/apache/commons/lang3/mutable/MutableBoolean;Lforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;","invokevirtual",129);}
case 129:{f.StackOp("pop");f.Pc=130;continue;}
case 130:{f.Push(f.Locals[8]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[3]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",137);}
case 137:{f.Push(f.Locals[3]);f.Pc=138;continue;}
case 138:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventTokenCreated"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventTokenCreated")));f.Pc=141;continue;}
case 141:{f.StackOp("dup");f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/event/GameEventTokenCreated","<init>","()V","invokespecial",145);}
case 145:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",148);}
case 148:{f.Push(f.Locals[9]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","isTrue","()Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int==0?171:156;continue;}
case 156:{f.Push(f.Locals[3]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",160);}
case 160:{f.Push(f.Locals[3]);f.Pc=161;continue;}
case 161:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=164;continue;}
case 164:{f.StackOp("dup");f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",168);}
case 168:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",171);}
case 171:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=174;continue;}
case 174:{f.Pc=83;continue;}
case 177:{f.Pc=58;continue;}
case 180:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
