// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C427{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/VillainousChoiceEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3824,"forge/game/ability/effects/VillainousChoiceEffect","<init>","()V",1,1,1,new JHandler[]{},M3824));
c.Add(new JMethod(3825,"forge/game/ability/effects/VillainousChoiceEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,7,new JHandler[]{},M3825));
}

internal static JStep M3824(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3825(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Choices")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbilityList","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",6);}
case 6:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/ability/effects/VillainousChoiceEffect","extractAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("ChoicePrompt")));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",23);}
case 23:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",26);}
case 26:{return rt.DynamicCall(f,"forge/game/ability/effects/VillainousChoiceEffect:3825:26:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",31);}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",40);}
case 40:{f.Locals[5]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/ability/effects/VillainousChoiceEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",46);}
case 46:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",49);}
case 49:{f.Locals[6]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[6]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",58);}
case 58:{f.Pc=f.Pop().Int==0?183:61;continue;}
case 61:{f.Push(f.Locals[6]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",68);}
case 68:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=71;continue;}
case 71:{f.Locals[7]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[7]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/player/Player","getAdditionalVillainousChoices","()I","invokevirtual",78);}
case 78:{f.Push(JValue.I(1));f.Pc=79;continue;}
case 79:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=80;continue;}
case 80:{f.Locals[8]=f.Pop();f.Pc=82;continue;}
case 82:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",85);}
case 85:{f.Locals[9]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(JValue.I(0));f.Pc=88;continue;}
case 88:{f.Locals[10]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[10]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[8]);f.Pc=94;continue;}
case 94:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?127:97;continue;}
case 97:{f.Push(f.Locals[9]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[7]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",104);}
case 104:{f.Push(f.Locals[2]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[4]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"com/google/common/collect/ImmutableMap","of","()Lcom/google/common/collect/ImmutableMap;","invokestatic",112);}
case 112:{return rt.Call(f,"forge/game/player/PlayerController","chooseSpellAbilitiesForEffect","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ILjava/util/Map;)Ljava/util/List;","invokevirtual",115);}
case 115:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",120);}
case 120:{f.StackOp("pop");f.Pc=121;continue;}
case 121:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=124;continue;}
case 124:{f.Pc=90;continue;}
case 127:{f.Push(f.Locals[9]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",134);}
case 134:{f.Locals[10]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[10]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",143);}
case 143:{f.Pc=f.Pop().Int==0?180:146;continue;}
case 146:{f.Push(f.Locals[10]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",153);}
case 153:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=156;continue;}
case 156:{f.Locals[11]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[5]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[7]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",165);}
case 165:{f.Push(f.Locals[11]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",170);}
case 170:{f.Push(f.Locals[5]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[7]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",177);}
case 177:{f.Pc=136;continue;}
case 180:{f.Pc=51;continue;}
case 183:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
