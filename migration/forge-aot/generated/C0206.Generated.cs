// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C206{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/AssignGroupEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3038,"forge/game/ability/effects/AssignGroupEffect","<init>","()V",1,1,1,new JHandler[]{},M3038));
c.Add(new JMethod(3039,"forge/game/ability/effects/AssignGroupEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,1,new JHandler[]{},M3039));
c.Add(new JMethod(3040,"forge/game/ability/effects/AssignGroupEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,6,new JHandler[]{},M3040));
}

internal static JStep M3038(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3039(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3040(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Defined")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/ability/effects/AssignGroupEffect","getDefinedOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/util/List;","invokestatic",16);}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Choices")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbilityList","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",24);}
case 24:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",27);}
case 27:{f.Locals[5]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",33);}
case 33:{f.Locals[6]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?68:44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",50);}
case 50:{f.Locals[7]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[7]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",59);}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{f.Locals[6]=f.Pop();f.Pc=68;continue;}
case 68:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",71);}
case 71:{f.Locals[7]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[4]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",80);}
case 80:{f.Locals[8]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[8]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",89);}
case 89:{f.Pc=f.Pop().Int==0?171:92;continue;}
case 92:{f.Push(f.Locals[8]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",99);}
case 99:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=102;continue;}
case 102:{f.Locals[9]=f.Pop();f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",107);}
case 107:{f.Push(JValue.R(rt.String("lblChooseAbilityForObject")));f.Pc=109;continue;}
case 109:{f.Push(JValue.I(1));f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=113;continue;}
case 113:{f.StackOp("dup");f.Pc=114;continue;}
case 114:{f.Push(JValue.I(0));f.Pc=115;continue;}
case 115:{f.Push(f.Locals[9]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",120);}
case 120:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",124);}
case 124:{f.Locals[10]=f.Pop();f.Pc=126;continue;}
case 126:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",129);}
case 129:{f.Locals[11]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[11]);f.Pc=133;continue;}
case 133:{f.Push(JValue.R(rt.String("Affected")));f.Pc=135;continue;}
case 135:{f.Push(f.Locals[9]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",142);}
case 142:{f.StackOp("pop");f.Pc=143;continue;}
case 143:{f.Push(f.Locals[7]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[6]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",150);}
case 150:{f.Push(f.Locals[5]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[1]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[10]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[11]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleSpellForEffect","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/spellability/SpellAbility;","invokevirtual",160);}
case 160:{f.Push(f.Locals[9]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",167);}
case 167:{f.StackOp("pop");f.Pc=168;continue;}
case 168:{f.Pc=82;continue;}
case 171:{f.Push(f.Locals[5]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",178);}
case 178:{f.Locals[8]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[8]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",187);}
case 187:{f.Pc=f.Pop().Int==0?260:190;continue;}
case 190:{f.Push(f.Locals[8]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",197);}
case 197:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=200;continue;}
case 200:{f.Locals[9]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[7]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[9]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",211);}
case 211:{f.Locals[10]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[10]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",220);}
case 220:{f.Pc=f.Pop().Int==0?226:223;continue;}
case 223:{f.Pc=180;continue;}
case 226:{f.Push(f.Locals[2]);f.Pc=227;continue;}
case 227:{f.Push(f.Locals[10]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",232);}
case 232:{f.Push(f.Locals[9]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",237);}
case 237:{f.Push(f.Locals[2]);f.Pc=238;continue;}
case 238:{f.Push(f.Locals[10]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",243);}
case 243:{f.Push(f.Locals[3]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",247);}
case 247:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","()V","invokevirtual",250);}
case 250:{f.Push(f.Locals[3]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",254);}
case 254:{return rt.Call(f,"forge/game/trigger/TriggerHandler","resetActiveTriggers","()V","invokevirtual",257);}
case 257:{f.Pc=180;continue;}
case 260:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
