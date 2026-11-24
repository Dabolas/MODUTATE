// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C841{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityCantTarget","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9958,"forge/game/staticability/StaticAbilityCantTarget","<init>","()V",1,1,1,new JHandler[]{},M9958));
c.Add(new JMethod(9959,"forge/game/staticability/StaticAbilityCantTarget","cantTarget","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)Lforge/game/staticability/StaticAbility;",9,7,3,new JHandler[]{},M9959));
c.Add(new JMethod(9960,"forge/game/staticability/StaticAbilityCantTarget","applyCantTargetAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)Z",9,9,4,new JHandler[]{},M9960));
c.Add(new JMethod(9961,"forge/game/staticability/StaticAbilityCantTarget","lambda$applyCantTargetAbility$0","(Lforge/game/card/Card;Lforge/game/zone/ZoneType;)Z",4106,2,2,new JHandler[]{},M9961));
}

internal static JStep M9958(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9959(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntity","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?105:27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",48);}
case 48:{f.Locals[5]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",57);}
case 57:{f.Pc=f.Pop().Int==0?102:60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",67);}
case 67:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=70;continue;}
case 70:{f.Locals[6]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantTarget","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantTarget","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int!=0?86:83;continue;}
case 83:{f.Pc=50;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantTarget","applyCantTargetAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)Z","invokestatic",93);}
case 93:{f.Pc=f.Pop().Int==0?99:96;continue;}
case 96:{f.Push(f.Locals[6]);f.Pc=98;continue;}
case 98:{return JStep.Return(f.Pop());}
case 99:{f.Pc=50;continue;}
case 102:{f.Pc=18;continue;}
case 105:{f.Push(JValue.R(null));f.Pc=106;continue;}
case 106:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9960(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?106:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("AffectedZone")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?51:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("AffectedZone")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",30);}
case 30:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",35);}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityCantTarget:9960:36:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",41);}
case 41:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",46);}
case 46:{f.Pc=f.Pop().Int==0?60:49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int!=0?60:58;continue;}
case 58:{f.Push(JValue.I(0));f.Pc=59;continue;}
case 59:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/staticability/StaticAbility","getActiveZone","()Ljava/util/Set;","invokevirtual",64);}
case 64:{f.Locals[4]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{f.Pc=f.Pop().Reference==null?103:71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",81);}
case 81:{f.Pc=f.Pop().Int==0?103:84;continue;}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",88);}
case 88:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",91);}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",95);}
case 95:{return rt.Call(f,"forge/game/zone/MagicStack","getSpellMatchingHost","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Reference==null?103:101;continue;}
case 101:{f.Push(JValue.I(0));f.Pc=102;continue;}
case 102:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 103:{f.Pc=117;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("AffectedZone")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Int==0?117:115;continue;}
case 115:{f.Push(JValue.I(0));f.Pc=116;continue;}
case 116:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 117:{f.Push(f.Locals[2]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",121);}
case 121:{f.Locals[3]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[2]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",126);}
case 126:{f.Locals[4]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[0]);f.Pc=129;continue;}
case 129:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","HEXPROOF","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","HEXPROOF","Lforge/game/keyword/Keyword;"));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/staticability/StaticAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",135);}
case 135:{f.Pc=f.Pop().Int!=0?148:138;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","SHROUD","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","SHROUD","Lforge/game/keyword/Keyword;"));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/staticability/StaticAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",145);}
case 145:{f.Pc=f.Pop().Int==0?159:148;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[2]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/staticability/StaticAbilityIgnoreHexproofShroud","ignore","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;Lforge/game/staticability/StaticAbility;)Z","invokestatic",154);}
case 154:{f.Pc=f.Pop().Int==0?159:157;continue;}
case 157:{f.Push(JValue.I(0));f.Pc=158;continue;}
case 158:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=162;continue;}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",166);}
case 166:{f.Pc=f.Pop().Int!=0?171:169;continue;}
case 169:{f.Push(JValue.I(0));f.Pc=170;continue;}
case 170:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 171:{f.Push(f.Locals[0]);f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String("ValidSA")));f.Pc=174;continue;}
case 174:{f.Push(f.Locals[2]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",178);}
case 178:{f.Pc=f.Pop().Int!=0?183:181;continue;}
case 181:{f.Push(JValue.I(0));f.Pc=182;continue;}
case 182:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 183:{f.Push(f.Locals[0]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=186;continue;}
case 186:{f.Push(f.Locals[3]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",190);}
case 190:{f.Pc=f.Pop().Int!=0?195:193;continue;}
case 193:{f.Push(JValue.I(0));f.Pc=194;continue;}
case 194:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{f.Push(JValue.R(rt.String("Activator")));f.Pc=198;continue;}
case 198:{f.Push(f.Locals[4]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",203);}
case 203:{f.Pc=f.Pop().Int!=0?208:206;continue;}
case 206:{f.Push(JValue.I(0));f.Pc=207;continue;}
case 207:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 208:{f.Push(f.Locals[0]);f.Pc=209;continue;}
case 209:{f.Push(JValue.R(rt.String("SourceCanOnlyTarget")));f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",214);}
case 214:{f.Pc=f.Pop().Int==0?397:217;continue;}
case 217:{f.Push(f.Locals[2]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",221);}
case 221:{f.Locals[5]=f.Pop();f.Pc=223;continue;}
case 223:{f.Push(JValue.R(null));f.Pc=224;continue;}
case 224:{f.Locals[6]=f.Pop();f.Pc=226;continue;}
case 226:{f.Push(f.Locals[5]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",231);}
case 231:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"));f.Pc=234;continue;}
case 234:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?252:237;continue;}
case 237:{f.Push(f.Locals[5]);f.Pc=239;continue;}
case 239:{f.Push(JValue.R(rt.String("Choices")));f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbilityList","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",244);}
case 244:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",247);}
case 247:{f.Locals[6]=f.Pop();f.Pc=249;continue;}
case 249:{f.Pc=266;continue;}
case 252:{f.Push(JValue.I(1));f.Pc=253;continue;}
case 253:{f.Push(JValue.R(rt.NewArray("Lforge/game/spellability/SpellAbility;",f.Pop().Int)));f.Pc=256;continue;}
case 256:{f.StackOp("dup");f.Pc=257;continue;}
case 257:{f.Push(JValue.I(0));f.Pc=258;continue;}
case 258:{f.Push(f.Locals[5]);f.Pc=260;continue;}
case 260:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=261;continue;}
case 261:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",264);}
case 264:{f.Locals[6]=f.Pop();f.Pc=266;continue;}
case 266:{f.Push(f.Locals[6]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",273);}
case 273:{f.Locals[7]=f.Pop();f.Pc=275;continue;}
case 275:{f.Push(f.Locals[7]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",282);}
case 282:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=285;continue;}
case 285:{f.Locals[8]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[8]);f.Pc=289;continue;}
case 289:{f.Pc=f.Pop().Reference==null?397:292;continue;}
case 292:{f.Push(f.Locals[8]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",297);}
case 297:{f.Pc=f.Pop().Int==0?360:300;continue;}
case 300:{f.Push(f.Locals[8]);f.Pc=302;continue;}
case 302:{f.Push(JValue.R(rt.String("ValidTgts")));f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",307);}
case 307:{f.Push(f.Locals[0]);f.Pc=308;continue;}
case 308:{f.Push(JValue.R(rt.String("SourceCanOnlyTarget")));f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",313);}
case 313:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",316);}
case 316:{f.Pc=f.Pop().Int==0?358:319;continue;}
case 319:{f.Push(f.Locals[8]);f.Pc=321;continue;}
case 321:{f.Push(JValue.R(rt.String("ValidTgts")));f.Pc=323;continue;}
case 323:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",326);}
case 326:{f.Push(JValue.R(rt.String(",")));f.Pc=328;continue;}
case 328:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",331);}
case 331:{f.Pc=f.Pop().Int!=0?358:334;continue;}
case 334:{f.Push(f.Locals[8]);f.Pc=336;continue;}
case 336:{f.Push(JValue.R(rt.String("ValidTgts")));f.Pc=338;continue;}
case 338:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",341);}
case 341:{f.Push(f.Locals[0]);f.Pc=342;continue;}
case 342:{f.Push(JValue.R(rt.String("SourceCanOnlyTarget")));f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",347);}
case 347:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityCantTarget:9960:347:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",352);}
case 352:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",355);}
case 355:{f.Pc=f.Pop().Int==0?360:358;continue;}
case 358:{f.Push(JValue.I(0));f.Pc=359;continue;}
case 359:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 360:{f.Push(f.Locals[8]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",365);}
case 365:{f.Locals[8]=f.Pop();f.Pc=367;continue;}
case 367:{f.Push(f.Locals[8]);f.Pc=369;continue;}
case 369:{f.Pc=f.Pop().Reference!=null?287:372;continue;}
case 372:{f.Push(f.Locals[7]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",379);}
case 379:{f.Pc=f.Pop().Int==0?287:382;continue;}
case 382:{f.Push(f.Locals[7]);f.Pc=384;continue;}
case 384:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",389);}
case 389:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=392;continue;}
case 392:{f.Locals[8]=f.Pop();f.Pc=394;continue;}
case 394:{f.Pc=287;continue;}
case 397:{f.Push(JValue.I(1));f.Pc=398;continue;}
case 398:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9961(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
