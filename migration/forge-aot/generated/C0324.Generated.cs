// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C324{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/LifeGainEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3465,"forge/game/ability/effects/LifeGainEffect","<init>","()V",1,1,1,new JHandler[]{},M3465));
c.Add(new JMethod(3466,"forge/game/ability/effects/LifeGainEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,4,new JHandler[]{},M3466));
c.Add(new JMethod(3467,"forge/game/ability/effects/LifeGainEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,6,4,new JHandler[]{},M3467));
}

internal static JStep M3465(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3466(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("LifeAmount")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/ability/effects/LifeGainEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",29);}
case 29:{f.Push(JValue.R(rt.String("Defined")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/ability/effects/LifeGainEffect","playersOrDescribed","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;","invokestatic",34);}
case 34:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/ability/effects/LifeGainEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",43);}
case 43:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",46);}
case 46:{f.Push(JValue.I(1));f.Pc=47;continue;}
case 47:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?55:50;continue;}
case 50:{f.Push(JValue.R(rt.String(" gain ")));f.Pc=52;continue;}
case 52:{f.Pc=57;continue;}
case 55:{f.Push(JValue.R(rt.String(" gains ")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",65);}
case 65:{f.Pc=f.Pop().Int!=0?103:68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{f.Pc=f.Pop().Reference==null?103:73;continue;}
case 73:{f.Push(f.Locals[4]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("life equal to")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int==0?103:83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[4]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[4]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("life equal to")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",93);}
case 93:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",96);}
case 96:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",99);}
case 99:{f.StackOp("pop");f.Pc=100;continue;}
case 100:{f.Pc=184;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/ability/effects/LifeGainEffect","isAmountDeferred","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z","invokestatic",108);}
case 108:{f.Pc=f.Pop().Int==0?134:111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("gains? (\\S+ life (?:for each|equal to)[^.]*\\.)")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/ability/effects/LifeGainEffect","amountTextFromCard","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/lang/String;","invokestatic",117);}
case 117:{f.Pc=f.Pop().Reference==null?134:120;continue;}
case 120:{f.Push(f.Locals[2]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("gains? (\\S+ life (?:for each|equal to)[^.]*\\.)")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/ability/effects/LifeGainEffect","amountTextFromCard","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/lang/String;","invokestatic",127);}
case 127:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",130);}
case 130:{f.StackOp("pop");f.Pc=131;continue;}
case 131:{f.Pc=184;continue;}
case 134:{f.Push(f.Locals[3]);f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.String("AFLifeLost")));f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",140);}
case 140:{f.Pc=f.Pop().Int==0?151:143;continue;}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[3]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasSVar","(Ljava/lang/String;)Z","invokevirtual",148);}
case 148:{f.Pc=f.Pop().Int==0?177:151;continue;}
case 151:{f.Push(f.Locals[1]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",155);}
case 155:{f.Push(f.Locals[3]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",160);}
case 160:{f.Locals[5]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[2]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[5]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",168);}
case 168:{f.Push(JValue.R(rt.String(" life.")));f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",173);}
case 173:{f.StackOp("pop");f.Pc=174;continue;}
case 174:{f.Pc=184;continue;}
case 177:{f.Push(f.Locals[2]);f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("life equal to the life lost this way.")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",183);}
case 183:{f.StackOp("pop");f.Pc=184;continue;}
case 184:{f.Push(f.Locals[2]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",188);}
case 188:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3467(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("LifeAmount")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Defined")));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/ability/effects/LifeGainEffect","getTargetPlayersWithDuplicates","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","(Ljava/lang/Iterable;)Ljava/util/HashSet;","invokestatic",27);}
case 27:{return rt.Call(f,"java/util/HashSet","iterator","()Ljava/util/Iterator;","invokevirtual",30);}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",39);}
case 39:{f.Pc=f.Pop().Int==0?87:42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[5]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[5]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int!=0?65:62;continue;}
case 62:{f.Pc=32;continue;}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Collections","frequency","(Ljava/util/Collection;Ljava/lang/Object;)I","invokestatic",74);}
case 74:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",79);}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/player/Player","gainLife","(ILforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{f.Pc=32;continue;}
case 87:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
