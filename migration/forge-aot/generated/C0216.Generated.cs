// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C216{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/BondEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3068,"forge/game/ability/effects/BondEffect","<init>","()V",1,1,1,new JHandler[]{},M3068));
c.Add(new JMethod(3069,"forge/game/ability/effects/BondEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,11,6,new JHandler[]{},M3069));
c.Add(new JMethod(3070,"forge/game/ability/effects/BondEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,2,new JHandler[]{},M3070));
}

internal static JStep M3068(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3069(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/ability/effects/BondEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",20);}
case 20:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",23);}
case 23:{f.Locals[5]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[5]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?211:35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[6]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[6]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(null));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",55);}
case 55:{f.Locals[7]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[7]);f.Pc=59;continue;}
case 59:{f.Pc=f.Pop().Reference==null?25:62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[7]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int!=0?75:72;continue;}
case 72:{f.Pc=25;continue;}
case 75:{f.Push(f.Locals[7]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/Card","isPaired","()Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int!=0?25:83;continue;}
case 83:{f.Push(f.Locals[7]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int==0?25:91;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int==0?25:99;continue;}
case 99:{f.Push(f.Locals[7]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",104);}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?111:108;continue;}
case 108:{f.Pc=25;continue;}
case 111:{f.Push(f.Locals[3]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",115);}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",121);}
case 121:{f.Push(f.Locals[3]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[2]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",127);}
case 127:{f.Locals[8]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[8]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",136);}
case 136:{f.Pc=f.Pop().Int==0?142:139;continue;}
case 139:{f.Pc=25;continue;}
case 142:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",145);}
case 145:{f.Locals[9]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[9]);f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String("Partner")));f.Pc=151;continue;}
case 151:{f.Push(f.Locals[7]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",158);}
case 158:{f.StackOp("pop");f.Pc=159;continue;}
case 159:{f.Push(f.Locals[3]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",163);}
case 163:{f.Push(f.Locals[8]);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[1]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",169);}
case 169:{f.Push(JValue.R(rt.String("lblSelectACardPair")));f.Pc=171;continue;}
case 171:{f.Push(JValue.I(0));f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",178);}
case 178:{f.Push(JValue.I(1));f.Pc=179;continue;}
case 179:{f.Push(f.Locals[9]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",184);}
case 184:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=187;continue;}
case 187:{f.Locals[10]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[10]);f.Pc=191;continue;}
case 191:{f.Pc=f.Pop().Reference==null?208:194;continue;}
case 194:{f.Push(f.Locals[7]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[10]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/card/Card","setPairedWith","(Lforge/game/card/Card;)V","invokevirtual",201);}
case 201:{f.Push(f.Locals[10]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[7]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/card/Card","setPairedWith","(Lforge/game/card/Card;)V","invokevirtual",208);}
case 208:{f.Pc=25;continue;}
case 211:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3070(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/effects/BondEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",16);}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String(" pairs with another unpaired creature you control.")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
