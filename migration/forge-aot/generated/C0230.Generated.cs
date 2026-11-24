// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C230{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChaosEnsuesEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3123,"forge/game/ability/effects/ChaosEnsuesEffect","<init>","()V",1,1,1,new JHandler[]{},M3123));
c.Add(new JMethod(3124,"forge/game/ability/effects/ChaosEnsuesEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,15,4,new JHandler[]{},M3124));
}

internal static JStep M3123(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3124(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/Game","getActivePlanes","()Ljava/util/List;","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Reference!=null?25:24;continue;}
case 24:{return JStep.ReturnVoid;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",29);}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",38);}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",43);}
case 43:{f.Locals[7]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("Defined")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?232:54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("Defined")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",61);}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",65);}
case 65:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",68);}
case 68:{f.Locals[8]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[8]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",77);}
case 77:{f.Pc=f.Pop().Int==0?208:80;continue;}
case 80:{f.Push(f.Locals[8]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",87);}
case 87:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=90;continue;}
case 90:{f.Locals[9]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[9]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/card/Card","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",97);}
case 97:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",102);}
case 102:{f.Locals[10]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[10]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",111);}
case 111:{f.Pc=f.Pop().Int==0?205:114;continue;}
case 114:{f.Push(f.Locals[10]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",121);}
case 121:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=124;continue;}
case 124:{f.Locals[11]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[11]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",131);}
case 131:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChaosEnsues","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChaosEnsues","Lforge/game/trigger/TriggerType;"));f.Pc=134;continue;}
case 134:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?202:137;continue;}
case 137:{f.Push(f.Locals[11]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/trigger/Trigger","getActiveZone","()Ljava/util/Set;","invokevirtual",142);}
case 142:{f.Locals[12]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[6]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[11]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/trigger/Trigger","getId","()I","invokevirtual",151);}
case 151:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",154);}
case 154:{f.Push(f.Locals[12]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/util/EnumSet","copyOf","(Ljava/util/Collection;)Ljava/util/EnumSet;","invokestatic",159);}
case 159:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",164);}
case 164:{f.StackOp("pop");f.Pc=165;continue;}
case 165:{f.Push(f.Locals[12]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[9]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",172);}
case 172:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",175);}
case 175:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",180);}
case 180:{f.StackOp("pop");f.Pc=181;continue;}
case 181:{f.Push(f.Locals[7]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[9]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",190);}
case 190:{f.StackOp("pop");f.Pc=191;continue;}
case 191:{f.Push(f.Locals[4]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",196);}
case 196:{f.Push(f.Locals[11]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerOneTrigger","(Lforge/game/trigger/Trigger;)Z","invokevirtual",201);}
case 201:{f.StackOp("pop");f.Pc=202;continue;}
case 202:{f.Pc=104;continue;}
case 205:{f.Pc=70;continue;}
case 208:{f.Push(f.Locals[5]);f.Pc=210;continue;}
case 210:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=213;continue;}
case 213:{f.Push(f.Locals[7]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",220);}
case 220:{f.StackOp("pop");f.Pc=221;continue;}
case 221:{f.Push(f.Locals[7]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",228);}
case 228:{f.Pc=f.Pop().Int==0?232:231;continue;}
case 231:{return JStep.ReturnVoid;}
case 232:{f.Push(f.Locals[4]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",237);}
case 237:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChaosEnsues","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChaosEnsues","Lforge/game/trigger/TriggerType;"));f.Pc=240;continue;}
case 240:{f.Push(f.Locals[5]);f.Pc=242;continue;}
case 242:{f.Push(JValue.I(0));f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",246);}
case 246:{f.Push(f.Locals[6]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",253);}
case 253:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",258);}
case 258:{f.Locals[8]=f.Pop();f.Pc=260;continue;}
case 260:{f.Push(f.Locals[8]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",267);}
case 267:{f.Pc=f.Pop().Int==0?396:270;continue;}
case 270:{f.Push(f.Locals[8]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",277);}
case 277:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=280;continue;}
case 280:{f.Locals[9]=f.Pop();f.Pc=282;continue;}
case 282:{f.Push(f.Locals[7]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",289);}
case 289:{f.Locals[10]=f.Pop();f.Pc=291;continue;}
case 291:{f.Push(f.Locals[10]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",298);}
case 298:{f.Pc=f.Pop().Int==0?393:301;continue;}
case 301:{f.Push(f.Locals[10]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",308);}
case 308:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=311;continue;}
case 311:{f.Locals[11]=f.Pop();f.Pc=313;continue;}
case 313:{f.Push(f.Locals[11]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/card/Card","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",318);}
case 318:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",323);}
case 323:{f.Locals[12]=f.Pop();f.Pc=325;continue;}
case 325:{f.Push(f.Locals[12]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",332);}
case 332:{f.Pc=f.Pop().Int==0?390:335;continue;}
case 335:{f.Push(f.Locals[12]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",342);}
case 342:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=345;continue;}
case 345:{f.Locals[13]=f.Pop();f.Pc=347;continue;}
case 347:{f.Push(f.Locals[13]);f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/trigger/Trigger","getId","()I","invokevirtual",352);}
case 352:{f.Push(f.Locals[9]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",359);}
case 359:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=362;continue;}
case 362:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",365);}
case 365:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?387:368;continue;}
case 368:{f.Push(f.Locals[9]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",375);}
case 375:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/EnumSet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=378;continue;}
case 378:{f.Locals[14]=f.Pop();f.Pc=380;continue;}
case 380:{f.Push(f.Locals[13]);f.Pc=382;continue;}
case 382:{f.Push(f.Locals[14]);f.Pc=384;continue;}
case 384:{return rt.Call(f,"forge/game/trigger/Trigger","setActiveZone","(Ljava/util/EnumSet;)V","invokevirtual",387);}
case 387:{f.Pc=325;continue;}
case 390:{f.Pc=291;continue;}
case 393:{f.Pc=260;continue;}
case 396:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
