// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C271{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/CountersRemoveAllEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3276,"forge/game/ability/effects/CountersRemoveAllEffect","<init>","()V",1,1,1,new JHandler[]{},M3276));
c.Add(new JMethod(3277,"forge/game/ability/effects/CountersRemoveAllEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,7,3,new JHandler[]{},M3277));
c.Add(new JMethod(3278,"forge/game/ability/effects/CountersRemoveAllEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,13,5,new JHandler[]{},M3278));
}

internal static JStep M3276(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3277(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",22);}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",28);}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",32);}
case 32:{f.Locals[4]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("ValidZone")));f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",49);}
case 49:{f.Locals[6]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("AllCounters")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?64:60;continue;}
case 60:{f.Push(JValue.R(rt.String("all")));f.Pc=62;continue;}
case 62:{f.Locals[6]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("Remove ")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",70);}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",75);}
case 75:{f.Push(JValue.R(rt.String(" ")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",80);}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",86);}
case 86:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",89);}
case 89:{f.Push(JValue.R(rt.String(" counter")));f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",94);}
case 94:{f.StackOp("pop");f.Pc=95;continue;}
case 95:{f.Push(f.Locals[6]);f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.String("1")));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int!=0?112:105;continue;}
case 105:{f.Push(f.Locals[2]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("s")));f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",111);}
case 111:{f.StackOp("pop");f.Pc=112;continue;}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{f.Push(JValue.R(rt.String(" from each valid ")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",118);}
case 118:{f.StackOp("pop");f.Pc=119;continue;}
case 119:{f.Push(f.Locals[5]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int==0?139:129;continue;}
case 129:{f.Push(f.Locals[2]);f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("permanent.")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",135);}
case 135:{f.StackOp("pop");f.Pc=136;continue;}
case 136:{f.Pc=156;continue;}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.String("card in ")));f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",145);}
case 145:{f.Push(f.Locals[5]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",150);}
case 150:{f.Push(JValue.R(rt.String(".")));f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",155);}
case 155:{f.StackOp("pop");f.Pc=156;continue;}
case 156:{f.Push(f.Locals[2]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",160);}
case 160:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3278(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",11);}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",28);}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("ValidZone")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int==0?51:39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("ValidZone")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",48);}
case 48:{f.Pc=54;continue;}
case 51:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=54;continue;}
case 54:{f.Locals[5]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",60);}
case 60:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",63);}
case 63:{f.Locals[6]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[6]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[5]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",72);}
case 72:{f.Locals[7]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[7]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",82);}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",86);}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",90);}
case 90:{f.Locals[7]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int==0?117:99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",103);}
case 103:{return rt.Call(f,"forge/game/spellability/TargetChoices","getFirstTargetedPlayer","()Lforge/game/player/Player;","invokevirtual",106);}
case 106:{f.Locals[8]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[7]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[8]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",115);}
case 115:{f.Locals[7]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(JValue.I(0));f.Pc=118;continue;}
case 118:{f.Locals[8]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[7]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",127);}
case 127:{f.Locals[9]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[9]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",136);}
case 136:{f.Pc=f.Pop().Int==0?289:139;continue;}
case 139:{f.Push(f.Locals[9]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",146);}
case 146:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=149;continue;}
case 149:{f.Locals[10]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[1]);f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("AllCounterTypes")));f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",157);}
case 157:{f.Pc=f.Pop().Int==0?237:160;continue;}
case 160:{f.Push(f.Locals[10]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/card/Card","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",165);}
case 165:{return rt.Call(f,"com/google/common/collect/Multiset","entrySet","()Ljava/util/Set;","invokeinterface",170);}
case 170:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",173);}
case 173:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",176);}
case 176:{f.Locals[11]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[11]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",185);}
case 185:{f.Pc=f.Pop().Int==0?234:188;continue;}
case 188:{f.Push(f.Locals[11]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",195);}
case 195:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=198;continue;}
case 198:{f.Locals[12]=f.Pop();f.Pc=200;continue;}
case 200:{f.Push(f.Locals[8]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[10]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[12]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",211);}
case 211:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[12]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",221);}
case 221:{f.Push(f.Locals[1]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",225);}
case 225:{return rt.Call(f,"forge/game/card/Card","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",228);}
case 228:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=229;continue;}
case 229:{f.Locals[8]=f.Pop();f.Pc=231;continue;}
case 231:{f.Pc=178;continue;}
case 234:{f.Pc=129;continue;}
case 237:{f.Push(f.Locals[1]);f.Pc=238;continue;}
case 238:{f.Push(JValue.R(rt.String("AllCounters")));f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",243);}
case 243:{f.Pc=f.Pop().Int==0?256:246;continue;}
case 246:{f.Push(f.Locals[10]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[2]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",252);}
case 252:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",255);}
case 255:{f.Locals[3]=f.Pop();f.Pc=256;continue;}
case 256:{f.Push(f.Locals[3]);f.Pc=257;continue;}
case 257:{f.Pc=f.Pop().Int<=0?286:260;continue;}
case 260:{f.Push(f.Locals[8]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[10]);f.Pc=264;continue;}
case 264:{f.Push(f.Locals[2]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",268);}
case 268:{f.Push(f.Locals[3]);f.Pc=269;continue;}
case 269:{f.Push(f.Locals[1]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",273);}
case 273:{return rt.Call(f,"forge/game/card/Card","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",276);}
case 276:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=277;continue;}
case 277:{f.Locals[8]=f.Pop();f.Pc=279;continue;}
case 279:{f.Push(f.Locals[6]);f.Pc=281;continue;}
case 281:{f.Push(f.Locals[10]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/Game","updateLastStateForCard","(Lforge/game/card/Card;)V","invokevirtual",286);}
case 286:{f.Pc=129;continue;}
case 289:{f.Push(f.Locals[1]);f.Pc=290;continue;}
case 290:{f.Push(JValue.R(rt.String("RememberAmount")));f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",295);}
case 295:{f.Pc=f.Pop().Int==0?310:298;continue;}
case 298:{f.Push(f.Locals[1]);f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",302);}
case 302:{f.Push(f.Locals[8]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",307);}
case 307:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",310);}
case 310:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
