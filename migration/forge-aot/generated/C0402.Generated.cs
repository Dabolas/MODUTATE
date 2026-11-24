// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C402{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/SkipTurnEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3733,"forge/game/ability/effects/SkipTurnEffect","<init>","()V",1,1,1,new JHandler[]{},M3733));
c.Add(new JMethod(3734,"forge/game/ability/effects/SkipTurnEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,3,new JHandler[]{},M3734));
c.Add(new JMethod(3735,"forge/game/ability/effects/SkipTurnEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,15,4,new JHandler[]{},M3735));
}

internal static JStep M3733(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3734(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("NumTurns")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/ability/effects/SkipTurnEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",27);}
case 27:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",30);}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",39);}
case 39:{f.Pc=f.Pop().Int==0?69:42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[5]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",60);}
case 60:{f.Push(JValue.R(rt.String(" ")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Pc=32;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("skips his/her next ")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",75);}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",79);}
case 79:{f.Push(JValue.R(rt.String(" turn(s).")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",89);}
case 89:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3735(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",14);}
case 14:{return rt.DynamicCall(f,"forge/game/ability/effects/SkipTurnEffect:3735:14:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("NumTurns")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",38);}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?59:46;continue;}
case 46:{f.Push(f.Locals[6]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",51);}
case 51:{return rt.DynamicCall(f,"forge/game/ability/effects/SkipTurnEffect:3735:51:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",56);}
case 56:{f.Pc=61;continue;}
case 59:{f.Push(JValue.R(rt.String("turn.")));f.Pc=61;continue;}
case 61:{return rt.DynamicCall(f,"forge/game/ability/effects/SkipTurnEffect:3735:61:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",66);}
case 66:{f.Locals[7]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("DB$ StoreSVar | SVar$ NumTurns | Type$ CountSVar | Expression$ NumTurns/Minus.1")));f.Pc=70;continue;}
case 70:{f.Locals[8]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self | Origin$ Command | Destination$ Exile | ConditionCheckSVar$ NumTurns | ConditionSVarCompare$ EQ0")));f.Pc=74;continue;}
case 74:{f.Locals[9]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/ability/effects/SkipTurnEffect","getTargetPlayersOnePerTeam","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",80);}
case 80:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",83);}
case 83:{f.Locals[10]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[10]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",92);}
case 92:{f.Pc=f.Pop().Int==0?203:95;continue;}
case 95:{f.Push(f.Locals[10]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",102);}
case 102:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=105;continue;}
case 105:{f.Locals[11]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[11]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[4]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[5]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/ability/effects/SkipTurnEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;","invokestatic",117);}
case 117:{f.Locals[12]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[12]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("NumTurns")));f.Pc=123;continue;}
case 123:{f.Push(f.Locals[6]);f.Pc=125;continue;}
case 125:{return rt.DynamicCall(f,"forge/game/ability/effects/SkipTurnEffect:3735:125:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",130);}
case 130:{return rt.Call(f,"forge/game/card/Card","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",133);}
case 133:{f.Push(f.Locals[8]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[12]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",140);}
case 140:{f.Locals[13]=f.Pop();f.Pc=142;continue;}
case 142:{f.Push(f.Locals[13]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[9]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[12]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",151);}
case 151:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",157);}
case 157:{f.Push(f.Locals[7]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[12]);f.Pc=161;continue;}
case 161:{f.Push(JValue.I(1));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",165);}
case 165:{f.Locals[14]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[14]);f.Pc=169;continue;}
case 169:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Control","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Control","Lforge/game/replacement/ReplacementLayer;"));f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setLayer","(Lforge/game/replacement/ReplacementLayer;)V","invokevirtual",175);}
case 175:{f.Push(f.Locals[14]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[13]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",182);}
case 182:{f.Push(f.Locals[12]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[14]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/card/Card","addReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",189);}
case 189:{f.StackOp("pop");f.Pc=190;continue;}
case 190:{f.Push(f.Locals[3]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",194);}
case 194:{f.Push(f.Locals[12]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[1]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",200);}
case 200:{f.Pc=85;continue;}
case 203:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
