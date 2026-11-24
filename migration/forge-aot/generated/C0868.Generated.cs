// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C868{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityMustAttack","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10063,"forge/game/staticability/StaticAbilityMustAttack","<init>","()V",1,1,1,new JHandler[]{},M10063));
c.Add(new JMethod(10064,"forge/game/staticability/StaticAbilityMustAttack","entitiesMustAttack","(Lforge/game/card/Card;)Ljava/util/List;",9,12,3,new JHandler[]{},M10064));
c.Add(new JMethod(10065,"forge/game/staticability/StaticAbilityMustAttack","mustAttackSpecific","(Lforge/game/player/Player;Lforge/util/collect/FCollectionView;)Lcom/google/common/collect/Multimap;",9,9,3,new JHandler[]{},M10065));
c.Add(new JMethod(10066,"forge/game/staticability/StaticAbilityMustAttack","getAttackRequirements","(Lforge/game/card/Card;Ljava/lang/Iterable;)Lcom/google/common/collect/Multimap;",9,9,3,new JHandler[]{},M10066));
}

internal static JStep M10063(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10064(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?254:35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",56);}
case 56:{f.Locals[5]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int==0?251:68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",75);}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{f.Locals[6]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[6]);f.Pc=82;continue;}
case 82:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","MustAttack","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","MustAttack","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int!=0?94:91;continue;}
case 91:{f.Pc=58;continue;}
case 94:{f.Push(f.Locals[6]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("ValidCreature")));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int==0?248:105;continue;}
case 105:{f.Push(f.Locals[6]);f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("MustAttack")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Int==0?240:115;continue;}
case 115:{f.Push(f.Locals[6]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",120);}
case 120:{f.Push(f.Locals[6]);f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("MustAttack")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",127);}
case 127:{f.Push(f.Locals[6]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",132);}
case 132:{f.Locals[7]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[7]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",141);}
case 141:{f.Locals[8]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(f.Locals[8]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",150);}
case 150:{f.Pc=f.Pop().Int==0?237:153;continue;}
case 153:{f.Push(f.Locals[8]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",160);}
case 160:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=163;continue;}
case 163:{f.Locals[9]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[9]);f.Pc=167;continue;}
case 167:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=170;continue;}
case 170:{f.Pc=f.Pop().Int==0?192:173;continue;}
case 173:{f.Push(f.Locals[9]);f.Pc=175;continue;}
case 175:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=178;continue;}
case 178:{f.Locals[10]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[2]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",184);}
case 184:{f.Push(f.Locals[10]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",189);}
case 189:{f.Pc=f.Pop().Int!=0?143:192;continue;}
case 192:{f.Push(f.Locals[9]);f.Pc=194;continue;}
case 194:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=197;continue;}
case 197:{f.Pc=f.Pop().Int==0?225:200;continue;}
case 200:{f.Push(f.Locals[9]);f.Pc=202;continue;}
case 202:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=205;continue;}
case 205:{f.Locals[11]=f.Pop();f.Pc=207;continue;}
case 207:{f.Push(f.Locals[2]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",211);}
case 211:{f.Push(f.Locals[11]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",216);}
case 216:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",219);}
case 219:{f.Pc=f.Pop().Int==0?225:222;continue;}
case 222:{f.Pc=143;continue;}
case 225:{f.Push(f.Locals[1]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[9]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",233);}
case 233:{f.StackOp("pop");f.Pc=234;continue;}
case 234:{f.Pc=143;continue;}
case 237:{f.Pc=248;continue;}
case 240:{f.Push(f.Locals[1]);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[0]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",247);}
case 247:{f.StackOp("pop");f.Pc=248;continue;}
case 248:{f.Pc=58;continue;}
case 251:{f.Pc=26;continue;}
case 254:{f.Push(f.Locals[1]);f.Pc=255;continue;}
case 255:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10065(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FCollectionView","size","()I","invokeinterface",6);}
case 6:{return rt.Call(f,"com/google/common/collect/MultimapBuilder","hashKeys","(I)Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys;","invokestatic",9);}
case 9:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys","arrayListValues","()Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder;","invokevirtual",12);}
case 12:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$ListMultimapBuilder","build","()Lcom/google/common/collect/ListMultimap;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",20);}
case 20:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",31);}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int==0?176:41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{f.Locals[4]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",57);}
case 57:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",62);}
case 62:{f.Locals[5]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",71);}
case 71:{f.Pc=f.Pop().Int==0?173:74;continue;}
case 74:{f.Push(f.Locals[5]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",81);}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{f.Locals[6]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","PlayerMustAttack","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","PlayerMustAttack","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int!=0?100:97;continue;}
case 97:{f.Pc=64;continue;}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int!=0?114:111;continue;}
case 111:{f.Pc=64;continue;}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",120);}
case 120:{f.Locals[7]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[7]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",129);}
case 129:{f.Pc=f.Pop().Int==0?170:132;continue;}
case 132:{f.Push(f.Locals[7]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",139);}
case 139:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=142;continue;}
case 142:{f.Locals[8]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[6]);f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.String("MustAttack")));f.Pc=148;continue;}
case 148:{f.Push(f.Locals[8]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int==0?167:156;continue;}
case 156:{f.Push(f.Locals[2]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[8]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[6]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",166);}
case 166:{f.StackOp("pop");f.Pc=167;continue;}
case 167:{f.Pc=122;continue;}
case 170:{f.Pc=64;continue;}
case 173:{f.Pc=32;continue;}
case 176:{f.Push(f.Locals[2]);f.Pc=177;continue;}
case 177:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10066(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/MultimapBuilder","hashKeys","()Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys;","invokestatic",3);}
case 3:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys","arrayListValues","()Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder;","invokevirtual",6);}
case 6:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$ListMultimapBuilder","build","()Lcom/google/common/collect/ListMultimap;","invokevirtual",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?170:35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",56);}
case 56:{f.Locals[5]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int==0?167:68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",75);}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{f.Locals[6]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[6]);f.Pc=82;continue;}
case 82:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","AttackRequirement","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","AttackRequirement","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int!=0?94:91;continue;}
case 91:{f.Pc=58;continue;}
case 94:{f.Push(f.Locals[6]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int!=0?108:105;continue;}
case 105:{f.Pc=58;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",114);}
case 114:{f.Locals[7]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[7]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",123);}
case 123:{f.Pc=f.Pop().Int==0?164:126;continue;}
case 126:{f.Push(f.Locals[7]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",133);}
case 133:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=136;continue;}
case 136:{f.Locals[8]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[6]);f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.String("ValidAttacker")));f.Pc=142;continue;}
case 142:{f.Push(f.Locals[8]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int==0?161:150;continue;}
case 150:{f.Push(f.Locals[2]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[8]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[6]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",160);}
case 160:{f.StackOp("pop");f.Pc=161;continue;}
case 161:{f.Pc=116;continue;}
case 164:{f.Pc=58;continue;}
case 167:{f.Pc=26;continue;}
case 170:{f.Push(f.Locals[2]);f.Pc=171;continue;}
case 171:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
