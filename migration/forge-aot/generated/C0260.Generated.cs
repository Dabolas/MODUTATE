// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C260{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/CopySpellAbilityEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3229,"forge/game/ability/effects/CopySpellAbilityEffect","<init>","()V",1,1,1,new JHandler[]{},M3229));
c.Add(new JMethod(3230,"forge/game/ability/effects/CopySpellAbilityEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M3230));
c.Add(new JMethod(3231,"forge/game/ability/effects/CopySpellAbilityEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,3,new JHandler[]{},M3231));
c.Add(new JMethod(3232,"forge/game/ability/effects/CopySpellAbilityEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,21,9,new JHandler[]{},M3232));
c.Add(new JMethod(3233,"forge/game/ability/effects/CopySpellAbilityEffect","changeToLegalTarget","(Lforge/game/spellability/SpellAbility;Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)Z",2,5,4,new JHandler[]{},M3233));
c.Add(new JMethod(3234,"forge/game/ability/effects/CopySpellAbilityEffect","resetFirstTargetOnCopy","(Lforge/game/spellability/SpellAbility;Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)V",2,5,3,new JHandler[]{},M3234));
c.Add(new JMethod(3235,"forge/game/ability/effects/CopySpellAbilityEffect","getTargetedSA","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbility;",2,2,1,new JHandler[]{},M3235));
}

internal static JStep M3229(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3230(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?22:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",16);}
case 16:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",22);}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3231(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/CopySpellAbilityEffect","getTargetSpells","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Copy ")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",26);}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?76:38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",52);}
case 52:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",63);}
case 63:{f.Pc=f.Pop().Int==0?28:66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String(", ")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",72);}
case 72:{f.StackOp("pop");f.Pc=73;continue;}
case 73:{f.Pc=28;continue;}
case 76:{f.Push(JValue.I(1));f.Pc=77;continue;}
case 77:{f.Locals[5]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("Amount")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?104:88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",92);}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("Amount")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",98);}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",102);}
case 102:{f.Locals[5]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[5]);f.Pc=106;continue;}
case 106:{f.Push(JValue.I(1));f.Pc=107;continue;}
case 107:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?130:110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String(" ")));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",116);}
case 116:{f.Push(f.Locals[5]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",121);}
case 121:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",124);}
case 124:{f.Push(JValue.R(rt.String(" times")));f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",129);}
case 129:{f.StackOp("pop");f.Pc=130;continue;}
case 130:{f.Push(f.Locals[2]);f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.String(".")));f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",136);}
case 136:{f.StackOp("pop");f.Pc=137;continue;}
case 137:{f.Push(f.Locals[2]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",141);}
case 141:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3232(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Amount")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?35:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Amount")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",33);}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/ability/effects/CopySpellAbilityEffect","getTargetSpells","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",39);}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{return rt.DynamicCall(f,"forge/game/ability/effects/CopySpellAbilityEffect:3232:43:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",48);}
case 48:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Push(f.Locals[5]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",61);}
case 61:{f.Pc=f.Pop().Int!=0?69:64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Int!=0?70:69;continue;}
case 69:{return JStep.ReturnVoid;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("Controller")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",77);}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",81);}
case 81:{f.Locals[6]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[6]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/ability/effects/CopySpellAbilityEffect","sortAPNAP","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)V","invokestatic",89);}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("Optional")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",95);}
case 95:{f.Locals[7]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[6]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",104);}
case 104:{f.Locals[8]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[8]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",113);}
case 113:{f.Pc=f.Pop().Int==0?1029:116;continue;}
case 116:{f.Push(f.Locals[8]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",123);}
case 123:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=126;continue;}
case 126:{f.Locals[9]=f.Pop();f.Pc=128;continue;}
case 128:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",131);}
case 131:{f.Locals[10]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[5]);f.Pc=135;continue;}
case 135:{f.Locals[11]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("SingleChoice")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",143);}
case 143:{f.Pc=f.Pop().Int==0?188:146;continue;}
case 146:{f.Push(f.Locals[9]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",151);}
case 151:{f.Push(f.Locals[5]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",157);}
case 157:{f.Push(JValue.R(rt.String("lblSelectASpellCopy")));f.Pc=159;continue;}
case 159:{f.Push(JValue.I(0));f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",166);}
case 166:{return rt.Call(f,"com/google/common/collect/ImmutableMap","of","()Lcom/google/common/collect/ImmutableMap;","invokestatic",169);}
case 169:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleSpellForEffect","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/spellability/SpellAbility;","invokevirtual",172);}
case 172:{f.Locals[12]=f.Pop();f.Pc=174;continue;}
case 174:{f.Push(JValue.I(1));f.Pc=175;continue;}
case 175:{f.Push(JValue.R(rt.NewArray("Lforge/game/spellability/SpellAbility;",f.Pop().Int)));f.Pc=178;continue;}
case 178:{f.StackOp("dup");f.Pc=179;continue;}
case 179:{f.Push(JValue.I(0));f.Pc=180;continue;}
case 180:{f.Push(f.Locals[12]);f.Pc=182;continue;}
case 182:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=183;continue;}
case 183:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",186);}
case 186:{f.Locals[11]=f.Pop();f.Pc=188;continue;}
case 188:{f.Push(f.Locals[11]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",195);}
case 195:{f.Locals[12]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[12]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",204);}
case 204:{f.Pc=f.Pop().Int==0?1000:207;continue;}
case 207:{f.Push(f.Locals[12]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",214);}
case 214:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=217;continue;}
case 217:{f.Locals[13]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[7]);f.Pc=221;continue;}
case 221:{f.Pc=f.Pop().Int==0?269:224;continue;}
case 224:{f.Push(f.Locals[9]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",229);}
case 229:{f.Push(f.Locals[1]);f.Pc=230;continue;}
case 230:{f.Push(JValue.R(null));f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",234);}
case 234:{f.Push(JValue.R(rt.String("lblDoyouWantCopyTheSpell")));f.Pc=236;continue;}
case 236:{f.Push(JValue.I(1));f.Pc=237;continue;}
case 237:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=240;continue;}
case 240:{f.StackOp("dup");f.Pc=241;continue;}
case 241:{f.Push(JValue.I(0));f.Pc=242;continue;}
case 242:{f.Push(f.Locals[13]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",247);}
case 247:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",250);}
case 250:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",254);}
case 254:{f.Push(f.Locals[13]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",259);}
case 259:{f.Push(JValue.R(null));f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",263);}
case 263:{f.Pc=f.Pop().Int!=0?269:266;continue;}
case 266:{f.Pc=197;continue;}
case 269:{f.Push(f.Locals[1]);f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("CopyForEachCanTarget")));f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",275);}
case 275:{f.Pc=f.Pop().Int==0?488:278;continue;}
case 278:{f.Push(f.Locals[0]);f.Pc=279;continue;}
case 279:{f.Push(f.Locals[13]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/ability/effects/CopySpellAbilityEffect","getTargetedSA","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbility;","invokevirtual",284);}
case 284:{f.Locals[14]=f.Pop();f.Pc=286;continue;}
case 286:{f.Push(f.Locals[14]);f.Pc=288;continue;}
case 288:{f.Pc=f.Pop().Reference!=null?294:291;continue;}
case 291:{f.Pc=197;continue;}
case 294:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=297;continue;}
case 297:{f.StackOp("dup");f.Pc=298;continue;}
case 298:{f.Push(f.Locals[14]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",303);}
case 303:{f.Push(f.Locals[14]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getAllCandidates","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokevirtual",308);}
case 308:{f.Push(f.Locals[1]);f.Pc=309;continue;}
case 309:{f.Push(JValue.R(rt.String("CopyForEachCanTarget")));f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",314);}
case 314:{f.Push(JValue.R(rt.String(",")));f.Pc=316;continue;}
case 316:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",319);}
case 319:{f.Push(f.Locals[1]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",323);}
case 323:{f.Push(f.Locals[2]);f.Pc=324;continue;}
case 324:{f.Push(f.Locals[1]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/game/GameObjectPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",328);}
case 328:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/util/Collection;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",331);}
case 331:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",334);}
case 334:{f.Locals[15]=f.Pop();f.Pc=336;continue;}
case 336:{f.Push(f.Locals[15]);f.Pc=338;continue;}
case 338:{f.Push(f.Locals[14]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/game/ability/effects/CopySpellAbilityEffect","getTargetEntities","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",343);}
case 343:{return rt.Call(f,"forge/util/collect/FCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",346);}
case 346:{f.StackOp("pop");f.Pc=347;continue;}
case 347:{f.Push(f.Locals[1]);f.Pc=348;continue;}
case 348:{f.Push(JValue.R(rt.String("ChooseOnlyOne")));f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",353);}
case 353:{f.Pc=f.Pop().Int==0?423:356;continue;}
case 356:{f.Push(f.Locals[9]);f.Pc=358;continue;}
case 358:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",361);}
case 361:{f.Push(f.Locals[15]);f.Pc=363;continue;}
case 363:{f.Push(f.Locals[1]);f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",367);}
case 367:{f.Push(JValue.R(rt.String("lblChooseOne")));f.Pc=369;continue;}
case 369:{f.Push(JValue.I(0));f.Pc=370;continue;}
case 370:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",376);}
case 376:{f.Push(JValue.R(null));f.Pc=377;continue;}
case 377:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",380);}
case 380:{f.Locals[16]=f.Pop();f.Pc=382;continue;}
case 382:{f.Push(f.Locals[16]);f.Pc=384;continue;}
case 384:{f.Pc=f.Pop().Reference==null?420:387;continue;}
case 387:{f.Push(f.Locals[1]);f.Pc=388;continue;}
case 388:{f.Push(f.Locals[13]);f.Pc=390;continue;}
case 390:{f.Push(f.Locals[9]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/card/CardFactory","copySpellAbilityAndPossiblyHost","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokestatic",395);}
case 395:{f.Locals[17]=f.Pop();f.Pc=397;continue;}
case 397:{f.Push(f.Locals[0]);f.Pc=398;continue;}
case 398:{f.Push(f.Locals[17]);f.Pc=400;continue;}
case 400:{f.Push(f.Locals[16]);f.Pc=402;continue;}
case 402:{f.Push(f.Locals[14]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/ability/effects/CopySpellAbilityEffect","changeToLegalTarget","(Lforge/game/spellability/SpellAbility;Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",407);}
case 407:{f.Pc=f.Pop().Int==0?420:410;continue;}
case 410:{f.Push(f.Locals[10]);f.Pc=412;continue;}
case 412:{f.Push(f.Locals[17]);f.Pc=414;continue;}
case 414:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",419);}
case 419:{f.StackOp("pop");f.Pc=420;continue;}
case 420:{f.Pc=485;continue;}
case 423:{f.Push(f.Locals[15]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",428);}
case 428:{f.Locals[16]=f.Pop();f.Pc=430;continue;}
case 430:{f.Push(f.Locals[16]);f.Pc=432;continue;}
case 432:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",437);}
case 437:{f.Pc=f.Pop().Int==0?485:440;continue;}
case 440:{f.Push(f.Locals[16]);f.Pc=442;continue;}
case 442:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",447);}
case 447:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=450;continue;}
case 450:{f.Locals[17]=f.Pop();f.Pc=452;continue;}
case 452:{f.Push(f.Locals[1]);f.Pc=453;continue;}
case 453:{f.Push(f.Locals[13]);f.Pc=455;continue;}
case 455:{f.Push(f.Locals[9]);f.Pc=457;continue;}
case 457:{return rt.Call(f,"forge/game/card/CardFactory","copySpellAbilityAndPossiblyHost","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokestatic",460);}
case 460:{f.Locals[18]=f.Pop();f.Pc=462;continue;}
case 462:{f.Push(f.Locals[0]);f.Pc=463;continue;}
case 463:{f.Push(f.Locals[18]);f.Pc=465;continue;}
case 465:{f.Push(f.Locals[17]);f.Pc=467;continue;}
case 467:{f.Push(f.Locals[14]);f.Pc=469;continue;}
case 469:{return rt.Call(f,"forge/game/ability/effects/CopySpellAbilityEffect","resetFirstTargetOnCopy","(Lforge/game/spellability/SpellAbility;Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)V","invokevirtual",472);}
case 472:{f.Push(f.Locals[10]);f.Pc=474;continue;}
case 474:{f.Push(f.Locals[18]);f.Pc=476;continue;}
case 476:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",481);}
case 481:{f.StackOp("pop");f.Pc=482;continue;}
case 482:{f.Pc=430;continue;}
case 485:{f.Pc=806;continue;}
case 488:{f.Push(f.Locals[1]);f.Pc=489;continue;}
case 489:{f.Push(JValue.R(rt.String("DefinedTarget")));f.Pc=492;continue;}
case 492:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",495);}
case 495:{f.Pc=f.Pop().Int==0?733:498;continue;}
case 498:{f.Push(f.Locals[2]);f.Pc=499;continue;}
case 499:{f.Push(f.Locals[1]);f.Pc=500;continue;}
case 500:{f.Push(JValue.R(rt.String("DefinedTarget")));f.Pc=503;continue;}
case 503:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",506);}
case 506:{f.Push(f.Locals[1]);f.Pc=507;continue;}
case 507:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",510);}
case 510:{f.Locals[14]=f.Pop();f.Pc=512;continue;}
case 512:{f.Push(f.Locals[14]);f.Pc=514;continue;}
case 514:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",519);}
case 519:{f.Pc=f.Pop().Int==0?525:522;continue;}
case 522:{f.Pc=197;continue;}
case 525:{f.Push(f.Locals[0]);f.Pc=526;continue;}
case 526:{f.Push(f.Locals[13]);f.Pc=528;continue;}
case 528:{return rt.Call(f,"forge/game/ability/effects/CopySpellAbilityEffect","getTargetedSA","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbility;","invokevirtual",531);}
case 531:{f.Locals[15]=f.Pop();f.Pc=533;continue;}
case 533:{f.Push(f.Locals[15]);f.Pc=535;continue;}
case 535:{f.Pc=f.Pop().Reference!=null?541:538;continue;}
case 538:{f.Pc=197;continue;}
case 541:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=544;continue;}
case 544:{f.StackOp("dup");f.Pc=545;continue;}
case 545:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",548);}
case 548:{f.Locals[16]=f.Pop();f.Pc=550;continue;}
case 550:{f.Push(f.Locals[14]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",557);}
case 557:{f.Locals[17]=f.Pop();f.Pc=559;continue;}
case 559:{f.Push(f.Locals[17]);f.Pc=561;continue;}
case 561:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",566);}
case 566:{f.Pc=f.Pop().Int==0?665:569;continue;}
case 569:{f.Push(f.Locals[17]);f.Pc=571;continue;}
case 571:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",576);}
case 576:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=579;continue;}
case 579:{f.Locals[18]=f.Pop();f.Pc=581;continue;}
case 581:{f.Push(f.Locals[18]);f.Pc=583;continue;}
case 583:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=586;continue;}
case 586:{f.Pc=f.Pop().Int==0?654:589;continue;}
case 589:{f.Push(f.Locals[18]);f.Pc=591;continue;}
case 591:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=594;continue;}
case 594:{f.Locals[19]=f.Pop();f.Pc=596;continue;}
case 596:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=599;continue;}
case 599:{f.StackOp("dup");f.Pc=600;continue;}
case 600:{f.Push(f.Locals[18]);f.Pc=602;continue;}
case 602:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Object;)V","invokespecial",605);}
case 605:{f.Locals[20]=f.Pop();f.Pc=607;continue;}
case 607:{f.Push(f.Locals[20]);f.Pc=609;continue;}
case 609:{f.Push(f.Locals[19]);f.Pc=611;continue;}
case 611:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=614;continue;}
case 614:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",617);}
case 617:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",620);}
case 620:{f.StackOp("pop");f.Pc=621;continue;}
case 621:{f.Push(f.Locals[16]);f.Pc=623;continue;}
case 623:{f.Push(f.Locals[9]);f.Pc=625;continue;}
case 625:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",628);}
case 628:{f.Push(f.Locals[20]);f.Pc=630;continue;}
case 630:{f.Push(f.Locals[1]);f.Pc=631;continue;}
case 631:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",634);}
case 634:{f.Push(JValue.R(rt.String("lblChooseOne")));f.Pc=636;continue;}
case 636:{f.Push(JValue.I(0));f.Pc=637;continue;}
case 637:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=640;continue;}
case 640:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",643);}
case 643:{f.Push(JValue.R(null));f.Pc=644;continue;}
case 644:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",647);}
case 647:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",650);}
case 650:{f.StackOp("pop");f.Pc=651;continue;}
case 651:{f.Pc=662;continue;}
case 654:{f.Push(f.Locals[16]);f.Pc=656;continue;}
case 656:{f.Push(f.Locals[18]);f.Pc=658;continue;}
case 658:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",661);}
case 661:{f.StackOp("pop");f.Pc=662;continue;}
case 662:{f.Pc=559;continue;}
case 665:{f.Push(f.Locals[16]);f.Pc=667;continue;}
case 667:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",670);}
case 670:{f.Locals[17]=f.Pop();f.Pc=672;continue;}
case 672:{f.Push(f.Locals[17]);f.Pc=674;continue;}
case 674:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",679);}
case 679:{f.Pc=f.Pop().Int==0?730:682;continue;}
case 682:{f.Push(f.Locals[17]);f.Pc=684;continue;}
case 684:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",689);}
case 689:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=692;continue;}
case 692:{f.Locals[18]=f.Pop();f.Pc=694;continue;}
case 694:{f.Push(f.Locals[1]);f.Pc=695;continue;}
case 695:{f.Push(f.Locals[13]);f.Pc=697;continue;}
case 697:{f.Push(f.Locals[9]);f.Pc=699;continue;}
case 699:{return rt.Call(f,"forge/game/card/CardFactory","copySpellAbilityAndPossiblyHost","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokestatic",702);}
case 702:{f.Locals[19]=f.Pop();f.Pc=704;continue;}
case 704:{f.Push(f.Locals[0]);f.Pc=705;continue;}
case 705:{f.Push(f.Locals[19]);f.Pc=707;continue;}
case 707:{f.Push(f.Locals[18]);f.Pc=709;continue;}
case 709:{f.Push(f.Locals[15]);f.Pc=711;continue;}
case 711:{return rt.Call(f,"forge/game/ability/effects/CopySpellAbilityEffect","changeToLegalTarget","(Lforge/game/spellability/SpellAbility;Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",714);}
case 714:{f.Pc=f.Pop().Int==0?727:717;continue;}
case 717:{f.Push(f.Locals[10]);f.Pc=719;continue;}
case 719:{f.Push(f.Locals[19]);f.Pc=721;continue;}
case 721:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",726);}
case 726:{f.StackOp("pop");f.Pc=727;continue;}
case 727:{f.Pc=672;continue;}
case 730:{f.Pc=806;continue;}
case 733:{f.Push(JValue.I(0));f.Pc=734;continue;}
case 734:{f.Locals[14]=f.Pop();f.Pc=736;continue;}
case 736:{f.Push(f.Locals[14]);f.Pc=738;continue;}
case 738:{f.Push(f.Locals[4]);f.Pc=740;continue;}
case 740:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?806:743;continue;}
case 743:{f.Push(f.Locals[1]);f.Pc=744;continue;}
case 744:{f.Push(f.Locals[13]);f.Pc=746;continue;}
case 746:{f.Push(f.Locals[9]);f.Pc=748;continue;}
case 748:{return rt.Call(f,"forge/game/card/CardFactory","copySpellAbilityAndPossiblyHost","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokestatic",751);}
case 751:{f.Locals[15]=f.Pop();f.Pc=753;continue;}
case 753:{f.Push(f.Locals[1]);f.Pc=754;continue;}
case 754:{f.Push(JValue.R(rt.String("MayChooseTarget")));f.Pc=757;continue;}
case 757:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",760);}
case 760:{f.Pc=f.Pop().Int==0?769:763;continue;}
case 763:{f.Push(f.Locals[15]);f.Pc=765;continue;}
case 765:{f.Push(JValue.I(1));f.Pc=766;continue;}
case 766:{return rt.Call(f,"forge/game/spellability/SpellAbility","setMayChooseNewTargets","(Z)V","invokevirtual",769);}
case 769:{f.Push(f.Locals[1]);f.Pc=770;continue;}
case 770:{f.Push(JValue.R(rt.String("Epic")));f.Pc=773;continue;}
case 773:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",776);}
case 776:{f.Pc=f.Pop().Int==0?790:779;continue;}
case 779:{f.Push(f.Locals[15]);f.Pc=781;continue;}
case 781:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",784);}
case 784:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","EPIC","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","EPIC","Lforge/game/keyword/Keyword;"));f.Pc=787;continue;}
case 787:{return rt.Call(f,"forge/game/card/Card","removeIntrinsicKeyword","(Lforge/game/keyword/Keyword;)V","invokevirtual",790);}
case 790:{f.Push(f.Locals[10]);f.Pc=792;continue;}
case 792:{f.Push(f.Locals[15]);f.Pc=794;continue;}
case 794:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",799);}
case 799:{f.StackOp("pop");f.Pc=800;continue;}
case 800:{f.Locals[14]=JValue.I(unchecked(f.Locals[14].Int+(1)));f.Pc=803;continue;}
case 803:{f.Pc=736;continue;}
case 806:{f.Push(f.Locals[10]);f.Pc=808;continue;}
case 808:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",813);}
case 813:{f.Pc=f.Pop().Int==0?819:816;continue;}
case 816:{f.Pc=197;continue;}
case 819:{f.Push(f.Locals[10]);f.Pc=821;continue;}
case 821:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",826);}
case 826:{f.Locals[14]=f.Pop();f.Pc=828;continue;}
case 828:{f.Push(f.Locals[9]);f.Pc=830;continue;}
case 830:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",833);}
case 833:{f.Locals[15]=f.Pop();f.Pc=835;continue;}
case 835:{f.Push(f.Locals[15]);f.Pc=837;continue;}
case 837:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"));f.Pc=840;continue;}
case 840:{f.Push(f.Locals[13]);f.Pc=842;continue;}
case 842:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",847);}
case 847:{f.StackOp("pop");f.Pc=848;continue;}
case 848:{f.Push(f.Locals[15]);f.Pc=850;continue;}
case 850:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Amount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Amount","Lforge/game/ability/AbilityKey;"));f.Pc=853;continue;}
case 853:{f.Push(f.Locals[14]);f.Pc=855;continue;}
case 855:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",858);}
case 858:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",863);}
case 863:{f.StackOp("pop");f.Pc=864;continue;}
case 864:{if(!rt.StaticReady(f,"forge/game/ability/effects/CopySpellAbilityEffect$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/effects/CopySpellAbilityEffect$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=867;continue;}
case 867:{f.Push(f.Locals[3]);f.Pc=868;continue;}
case 868:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",871);}
case 871:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","CopySpell","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","CopySpell","Lforge/game/replacement/ReplacementType;"));f.Pc=874;continue;}
case 874:{f.Push(f.Locals[15]);f.Pc=876;continue;}
case 876:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",879);}
case 879:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",882);}
case 882:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=883;continue;}
case 883:{switch(f.Pop().Int){case 1:f.Pc=908;break;case 2:f.Pc=911;break;default:f.Pc=932;break;}continue;}
case 908:{f.Pc=935;continue;}
case 911:{f.Push(f.Locals[15]);f.Pc=913;continue;}
case 913:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Amount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Amount","Lforge/game/ability/AbilityKey;"));f.Pc=916;continue;}
case 916:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",921);}
case 921:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=924;continue;}
case 924:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",927);}
case 927:{f.Locals[14]=f.Pop();f.Pc=929;continue;}
case 929:{f.Pc=935;continue;}
case 932:{f.Push(JValue.I(0));f.Pc=933;continue;}
case 933:{f.Locals[14]=f.Pop();f.Pc=935;continue;}
case 935:{f.Push(f.Locals[14]);f.Pc=937;continue;}
case 937:{f.Pc=f.Pop().Int>0?943:940;continue;}
case 940:{f.Pc=197;continue;}
case 943:{f.Push(f.Locals[14]);f.Pc=945;continue;}
case 945:{f.Push(f.Locals[10]);f.Pc=947;continue;}
case 947:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",952);}
case 952:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=953;continue;}
case 953:{f.Locals[16]=f.Pop();f.Pc=955;continue;}
case 955:{f.Push(JValue.I(0));f.Pc=956;continue;}
case 956:{f.Locals[17]=f.Pop();f.Pc=958;continue;}
case 958:{f.Push(f.Locals[17]);f.Pc=960;continue;}
case 960:{f.Push(f.Locals[16]);f.Pc=962;continue;}
case 962:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?997:965;continue;}
case 965:{f.Push(f.Locals[1]);f.Pc=966;continue;}
case 966:{f.Push(f.Locals[13]);f.Pc=968;continue;}
case 968:{f.Push(f.Locals[9]);f.Pc=970;continue;}
case 970:{return rt.Call(f,"forge/game/card/CardFactory","copySpellAbilityAndPossiblyHost","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokestatic",973);}
case 973:{f.Locals[18]=f.Pop();f.Pc=975;continue;}
case 975:{f.Push(f.Locals[18]);f.Pc=977;continue;}
case 977:{f.Push(JValue.I(1));f.Pc=978;continue;}
case 978:{return rt.Call(f,"forge/game/spellability/SpellAbility","setMayChooseNewTargets","(Z)V","invokevirtual",981);}
case 981:{f.Push(f.Locals[10]);f.Pc=983;continue;}
case 983:{f.Push(f.Locals[18]);f.Pc=985;continue;}
case 985:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",990);}
case 990:{f.StackOp("pop");f.Pc=991;continue;}
case 991:{f.Locals[17]=JValue.I(unchecked(f.Locals[17].Int+(1)));f.Pc=994;continue;}
case 994:{f.Pc=958;continue;}
case 997:{f.Pc=197;continue;}
case 1000:{f.Push(f.Locals[9]);f.Pc=1002;continue;}
case 1002:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1005);}
case 1005:{f.Push(f.Locals[10]);f.Pc=1007;continue;}
case 1007:{return rt.Call(f,"forge/game/player/PlayerController","orderAndPlaySimultaneousSa","(Ljava/util/List;)V","invokevirtual",1010);}
case 1010:{f.Push(f.Locals[1]);f.Pc=1011;continue;}
case 1011:{f.Push(JValue.R(rt.String("RememberCopies")));f.Pc=1014;continue;}
case 1014:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1017);}
case 1017:{f.Pc=f.Pop().Int==0?1026:1020;continue;}
case 1020:{f.Push(f.Locals[2]);f.Pc=1021;continue;}
case 1021:{f.Push(f.Locals[10]);f.Pc=1023;continue;}
case 1023:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1026);}
case 1026:{f.Pc=106;continue;}
case 1029:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3233(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/effects/CopySpellAbilityEffect","getTargetedSA","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbility;","invokevirtual",5);}
case 5:{f.Locals[4]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[4]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference!=null?14:12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","canTarget","(Lforge/game/GameObject;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int!=0?25:23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/ability/effects/CopySpellAbilityEffect","resetFirstTargetOnCopy","(Lforge/game/spellability/SpellAbility;Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)V","invokevirtual",33);}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3234(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[4]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference==null?25:8;continue;}
case 8:{f.Push(f.Locals[4]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetFirstTarget","(Lforge/game/GameObject;Lforge/game/spellability/SpellAbility;)V","invokevirtual",15);}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",20);}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Pc=3;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3235(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?32:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?24:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/game/spellability/TargetChoices","isEmpty","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int!=0?24:21;continue;}
case 21:{f.Pc=32;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",28);}
case 28:{f.Locals[1]=f.Pop();f.Pc=29;continue;}
case 29:{f.Pc=0;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
