// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C316{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ImmediateTriggerEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3441,"forge/game/ability/effects/ImmediateTriggerEffect","<init>","()V",1,1,1,new JHandler[]{},M3441));
c.Add(new JMethod(3442,"forge/game/ability/effects/ImmediateTriggerEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,5,5,new JHandler[]{},M3442));
c.Add(new JMethod(3443,"forge/game/ability/effects/ImmediateTriggerEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,10,5,new JHandler[]{},M3443));
}

internal static JStep M3441(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3442(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("TriggerDescription")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?85:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("TriggerDescription")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("ABILITY")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?76:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("Execute")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",31);}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Reference!=null?41:36;continue;}
case 36:{f.Push(JValue.R(rt.String("")));f.Pc=38;continue;}
case 38:{f.Pc=45;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbility","getStackDescription","()Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Locals[4]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{f.Pc=f.Pop().Reference==null?76:52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int!=0?76:60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("ABILITY")));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("^.*? \\(\\d+\\) - ")));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",72);}
case 72:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",75);}
case 75:{f.Locals[2]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("\\s*\\(NumTimes=\\d+\\)")));f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",84);}
case 84:{return JStep.Return(f.Pop());}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?101:94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",100);}
case 100:{return JStep.Return(f.Pop());}
case 101:{f.Push(JValue.R(rt.String("")));f.Pc=103;continue;}
case 103:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3443(JRuntime rt,JFrame f)
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
case 12:{f.Push(JValue.R(rt.String("TriggerAmount")));f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("1")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Int>0?31:30;continue;}
case 30:{return JStep.ReturnVoid;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",35);}
case 35:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","(Ljava/util/Map;)Ljava/util/HashMap;","invokestatic",38);}
case 38:{f.Locals[5]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("Mode")));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Immediate","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Immediate","Lforge/game/trigger/TriggerType;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/trigger/TriggerType","name","()Ljava/lang/String;","invokevirtual",50);}
case 50:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int==0?102:68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("TriggerDescription")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",77);}
case 77:{f.Pc=f.Pop().Int!=0?102:80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("TriggerDescription")));f.Pc=84;continue;}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",93);}
case 93:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",101);}
case 101:{f.StackOp("pop");f.Pc=102;continue;}
case 102:{f.Push(f.Locals[5]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",111);}
case 111:{f.StackOp("pop");f.Pc=112;continue;}
case 112:{f.Push(f.Locals[5]);f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("Cost")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",121);}
case 121:{f.StackOp("pop");f.Pc=122;continue;}
case 122:{f.Push(JValue.R(null));f.Pc=123;continue;}
case 123:{f.Locals[6]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("Execute")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasAdditionalAbility","(Ljava/lang/String;)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int==0?168:134;continue;}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.String("Execute")));f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",140);}
case 140:{f.Push(f.Locals[2]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[1]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",145);}
case 145:{f.Push(JValue.I(0));f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",149);}
case 149:{f.Locals[6]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[6]);f.Pc=153;continue;}
case 153:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilitySub")?1:0));f.Pc=156;continue;}
case 156:{f.Pc=f.Pop().Int==0?168:159;continue;}
case 159:{f.Push(f.Locals[6]);f.Pc=161;continue;}
case 161:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=164;continue;}
case 164:{f.Push(JValue.R(null));f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/spellability/AbilitySub","setParent","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",168);}
case 168:{f.Push(JValue.R(null));f.Pc=169;continue;}
case 169:{f.Locals[7]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[1]);f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String("RememberObjects")));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int==0?198:180;continue;}
case 180:{f.Push(f.Locals[2]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[1]);f.Pc=182;continue;}
case 182:{f.Push(JValue.R(rt.String("RememberObjects")));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",187);}
case 187:{f.Push(JValue.R(rt.String(" & ")));f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",192);}
case 192:{f.Push(f.Locals[1]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;[Ljava/lang/String;Lforge/game/CardTraitBase;)Ljava/util/List;","invokestatic",196);}
case 196:{f.Locals[7]=f.Pop();f.Pc=198;continue;}
case 198:{f.Push(JValue.I(0));f.Pc=199;continue;}
case 199:{f.Locals[8]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[8]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[4]);f.Pc=205;continue;}
case 205:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?330:208;continue;}
case 208:{f.Push(f.Locals[5]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[2]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[1]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",215);}
case 215:{f.Push(JValue.R(null));f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/util/Map;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/trigger/Trigger;","invokestatic",219);}
case 219:{f.Locals[9]=f.Pop();f.Pc=221;continue;}
case 221:{f.Push(f.Locals[9]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[1]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[2]);f.Pc=225;continue;}
case 225:{f.Push(JValue.I(1));f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",229);}
case 229:{return rt.Call(f,"forge/game/trigger/Trigger","setSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",232);}
case 232:{f.Push(f.Locals[6]);f.Pc=234;continue;}
case 234:{f.Pc=f.Pop().Reference==null?244:237;continue;}
case 237:{f.Push(f.Locals[9]);f.Pc=239;continue;}
case 239:{f.Push(f.Locals[6]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",244);}
case 244:{f.Push(f.Locals[7]);f.Pc=246;continue;}
case 246:{f.Pc=f.Pop().Reference==null?283:249;continue;}
case 249:{f.Push(f.Locals[9]);f.Pc=251;continue;}
case 251:{f.Push(f.Locals[1]);f.Pc=252;continue;}
case 252:{f.Push(JValue.R(rt.String("RememberEach")));f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",257);}
case 257:{f.Pc=f.Pop().Int==0?278:260;continue;}
case 260:{f.Push(f.Locals[7]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[8]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",269);}
case 269:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",275);}
case 275:{f.Pc=280;continue;}
case 278:{f.Push(f.Locals[7]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/trigger/Trigger","addRemembered","(Ljava/util/Collection;)V","invokevirtual",283);}
case 283:{f.Push(f.Locals[1]);f.Pc=284;continue;}
case 284:{f.Push(JValue.R(rt.String("RememberSVarAmount")));f.Pc=286;continue;}
case 286:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",289);}
case 289:{f.Pc=f.Pop().Int==0?315:292;continue;}
case 292:{f.Push(f.Locals[9]);f.Pc=294;continue;}
case 294:{f.Push(f.Locals[2]);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[1]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[1]);f.Pc=297;continue;}
case 297:{f.Push(JValue.R(rt.String("RememberSVarAmount")));f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",302);}
case 302:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",305);}
case 305:{f.Push(f.Locals[1]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",309);}
case 309:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",312);}
case 312:{return rt.Call(f,"forge/game/trigger/Trigger","addRemembered","(Ljava/lang/Object;)V","invokevirtual",315);}
case 315:{f.Push(f.Locals[3]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",319);}
case 319:{f.Push(f.Locals[9]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerDelayedTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",324);}
case 324:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=327;continue;}
case 327:{f.Pc=201;continue;}
case 330:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
