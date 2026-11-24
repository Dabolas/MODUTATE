// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1003{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerSpellAbilityCastOrCopy","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10702,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10702));
c.Add(new JMethod(10703,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","performTest","(Ljava/util/Map;)Z",17,15,5,new JHandler[]{},M10703));
c.Add(new JMethod(10704,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",17,8,6,new JHandler[]{},M10704));
c.Add(new JMethod(10705,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,3,4,new JHandler[]{},M10705));
}

internal static JStep M10702(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10703(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Reference!=null?34:17;continue;}
case 17:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",24);}
case 24:{return rt.DynamicCall(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy:10703:24:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",29);}
case 29:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",32);}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",38);}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("ValidActivatingPlayer")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","hasParam","(Ljava/lang/String;)Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?328:48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{f.Locals[4]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("ValidActivatingPlayer")));f.Pc=65;continue;}
case 65:{f.Push(f.Locals[4]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int!=0?75:73;continue;}
case 73:{f.Push(JValue.I(0));f.Pc=74;continue;}
case 74:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("ActivatorThisTurnCast")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","hasParam","(Ljava/lang/String;)Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int==0?164:84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("ActivatorThisTurnCast")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",90);}
case 90:{f.Locals[5]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("Card")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",100);}
case 100:{f.Locals[6]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[6]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","getHostCard","()Lforge/game/card/Card;","invokevirtual",108);}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","getHostCard","()Lforge/game/card/Card;","invokevirtual",113);}
case 113:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",116);}
case 116:{return rt.Call(f,"forge/game/card/CardUtil","getThisTurnCast","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",119);}
case 119:{f.Locals[7]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[7]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[4]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/CardLists","filterControlledByAsList","(Ljava/lang/Iterable;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",128);}
case 128:{f.Locals[7]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[7]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",137);}
case 137:{f.Locals[8]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[5]);f.Pc=141;continue;}
case 141:{f.Push(JValue.I(2));f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",145);}
case 145:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",148);}
case 148:{f.Locals[9]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[8]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[5]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[9]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",159);}
case 159:{f.Pc=f.Pop().Int!=0?164:162;continue;}
case 162:{f.Push(JValue.I(0));f.Pc=163;continue;}
case 163:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("ActivatorThisTurnCastEach")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","hasParam","(Ljava/lang/String;)Z","invokevirtual",170);}
case 170:{f.Pc=f.Pop().Int==0?328:173;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("ActivatorThisTurnCastEach")));f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",179);}
case 179:{f.Locals[5]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[0]);f.Pc=182;continue;}
case 182:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("Card")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",189);}
case 189:{f.Locals[6]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(JValue.I(0));f.Pc=192;continue;}
case 192:{f.Locals[7]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[5]);f.Pc=196;continue;}
case 196:{f.Push(JValue.I(2));f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",200);}
case 200:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",203);}
case 203:{f.Locals[8]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[6]);f.Pc=207;continue;}
case 207:{f.Push(JValue.R(rt.String(",")));f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",212);}
case 212:{f.Locals[9]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(f.Locals[9]);f.Pc=216;continue;}
case 216:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=217;continue;}
case 217:{f.Locals[10]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(JValue.I(0));f.Pc=220;continue;}
case 220:{f.Locals[11]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(f.Locals[11]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[10]);f.Pc=226;continue;}
case 226:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?321:229;continue;}
case 229:{f.Push(f.Locals[9]);f.Pc=231;continue;}
case 231:{f.Push(f.Locals[11]);f.Pc=233;continue;}
case 233:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=234;continue;}
case 234:{f.Locals[12]=f.Pop();f.Pc=236;continue;}
case 236:{f.Push(f.Locals[3]);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[12]);f.Pc=239;continue;}
case 239:{f.Push(f.Locals[0]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","getHostCard","()Lforge/game/card/Card;","invokevirtual",243);}
case 243:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",246);}
case 246:{f.Push(f.Locals[0]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","getHostCard","()Lforge/game/card/Card;","invokevirtual",250);}
case 250:{f.Push(f.Locals[0]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",254);}
case 254:{f.Pc=f.Pop().Int!=0?260:257;continue;}
case 257:{f.Pc=315;continue;}
case 260:{f.Push(f.Locals[12]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[0]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","getHostCard","()Lforge/game/card/Card;","invokevirtual",266);}
case 266:{f.Push(f.Locals[0]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[0]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","getHostCard","()Lforge/game/card/Card;","invokevirtual",271);}
case 271:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",274);}
case 274:{return rt.Call(f,"forge/game/card/CardUtil","getThisTurnCast","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",277);}
case 277:{f.Locals[13]=f.Pop();f.Pc=279;continue;}
case 279:{f.Push(f.Locals[13]);f.Pc=281;continue;}
case 281:{f.Push(f.Locals[4]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/card/CardLists","filterControlledByAsList","(Ljava/lang/Iterable;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",286);}
case 286:{f.Locals[13]=f.Pop();f.Pc=288;continue;}
case 288:{f.Push(f.Locals[13]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",295);}
case 295:{f.Locals[14]=f.Pop();f.Pc=297;continue;}
case 297:{f.Push(f.Locals[14]);f.Pc=299;continue;}
case 299:{f.Push(f.Locals[5]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[8]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",306);}
case 306:{f.Pc=f.Pop().Int==0?315:309;continue;}
case 309:{f.Push(JValue.I(1));f.Pc=310;continue;}
case 310:{f.Locals[7]=f.Pop();f.Pc=312;continue;}
case 312:{f.Pc=321;continue;}
case 315:{f.Locals[11]=JValue.I(unchecked(f.Locals[11].Int+(1)));f.Pc=318;continue;}
case 318:{f.Pc=222;continue;}
case 321:{f.Push(f.Locals[7]);f.Pc=323;continue;}
case 323:{f.Pc=f.Pop().Int!=0?328:326;continue;}
case 326:{f.Push(JValue.I(0));f.Pc=327;continue;}
case 327:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 328:{f.Push(f.Locals[0]);f.Pc=329;continue;}
case 329:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=331;continue;}
case 331:{f.Push(f.Locals[3]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",335);}
case 335:{f.Pc=f.Pop().Int!=0?340:338;continue;}
case 338:{f.Push(JValue.I(0));f.Pc=339;continue;}
case 339:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 340:{f.Push(f.Locals[0]);f.Pc=341;continue;}
case 341:{f.Push(JValue.R(rt.String("ValidSA")));f.Pc=343;continue;}
case 343:{f.Push(f.Locals[2]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",347);}
case 347:{f.Pc=f.Pop().Int!=0?352:350;continue;}
case 350:{f.Push(JValue.I(0));f.Pc=351;continue;}
case 351:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 352:{f.Push(f.Locals[0]);f.Pc=353;continue;}
case 353:{f.Push(JValue.R(rt.String("ValidSAonCard")));f.Pc=355;continue;}
case 355:{f.Push(f.Locals[2]);f.Pc=356;continue;}
case 356:{f.Push(f.Locals[3]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;Lforge/game/card/Card;)Z","invokevirtual",360);}
case 360:{f.Pc=f.Pop().Int!=0?365:363;continue;}
case 363:{f.Push(JValue.I(0));f.Pc=364;continue;}
case 364:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 365:{f.Push(f.Locals[0]);f.Pc=366;continue;}
case 366:{f.Push(JValue.R(rt.String("TargetsValid")));f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","hasParam","(Ljava/lang/String;)Z","invokevirtual",371);}
case 371:{f.Pc=f.Pop().Int==0?464:374;continue;}
case 374:{f.Push(f.Locals[2]);f.Pc=375;continue;}
case 375:{f.Locals[4]=f.Pop();f.Pc=377;continue;}
case 377:{f.Push(JValue.I(0));f.Pc=378;continue;}
case 378:{f.Locals[5]=f.Pop();f.Pc=380;continue;}
case 380:{f.Push(f.Locals[4]);f.Pc=382;continue;}
case 382:{f.Pc=f.Pop().Reference==null?457:385;continue;}
case 385:{f.Push(f.Locals[5]);f.Pc=387;continue;}
case 387:{f.Pc=f.Pop().Int!=0?457:390;continue;}
case 390:{f.Push(f.Locals[4]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",395);}
case 395:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetEntities","()Ljava/lang/Iterable;","invokevirtual",398);}
case 398:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",403);}
case 403:{f.Locals[6]=f.Pop();f.Pc=405;continue;}
case 405:{f.Push(f.Locals[6]);f.Pc=407;continue;}
case 407:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",412);}
case 412:{f.Pc=f.Pop().Int==0?447:415;continue;}
case 415:{f.Push(f.Locals[6]);f.Pc=417;continue;}
case 417:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",422);}
case 422:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=425;continue;}
case 425:{f.Locals[7]=f.Pop();f.Pc=427;continue;}
case 427:{f.Push(f.Locals[0]);f.Pc=428;continue;}
case 428:{f.Push(JValue.R(rt.String("TargetsValid")));f.Pc=430;continue;}
case 430:{f.Push(f.Locals[7]);f.Pc=432;continue;}
case 432:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",435);}
case 435:{f.Pc=f.Pop().Int==0?444:438;continue;}
case 438:{f.Push(JValue.I(1));f.Pc=439;continue;}
case 439:{f.Locals[5]=f.Pop();f.Pc=441;continue;}
case 441:{f.Pc=447;continue;}
case 444:{f.Pc=405;continue;}
case 447:{f.Push(f.Locals[4]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",452);}
case 452:{f.Locals[4]=f.Pop();f.Pc=454;continue;}
case 454:{f.Pc=380;continue;}
case 457:{f.Push(f.Locals[5]);f.Pc=459;continue;}
case 459:{f.Pc=f.Pop().Int!=0?464:462;continue;}
case 462:{f.Push(JValue.I(0));f.Pc=463;continue;}
case 463:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 464:{f.Push(f.Locals[0]);f.Pc=465;continue;}
case 465:{f.Push(JValue.R(rt.String("CanTargetOtherCondition")));f.Pc=467;continue;}
case 467:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","hasParam","(Ljava/lang/String;)Z","invokevirtual",470);}
case 470:{f.Pc=f.Pop().Int==0?640:473;continue;}
case 473:{f.Push(f.Locals[2]);f.Pc=474;continue;}
case 474:{f.Locals[4]=f.Pop();f.Pc=476;continue;}
case 476:{f.Push(f.Locals[4]);f.Pc=478;continue;}
case 478:{f.Pc=f.Pop().Reference==null?513:481;continue;}
case 481:{f.Push(f.Locals[4]);f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",486);}
case 486:{f.Pc=f.Pop().Int==0?503:489;continue;}
case 489:{f.Push(f.Locals[4]);f.Pc=491;continue;}
case 491:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",494);}
case 494:{return rt.Call(f,"forge/game/spellability/TargetChoices","size","()I","invokevirtual",497);}
case 497:{f.Pc=f.Pop().Int==0?503:500;continue;}
case 500:{f.Pc=513;continue;}
case 503:{f.Push(f.Locals[4]);f.Pc=505;continue;}
case 505:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",508);}
case 508:{f.Locals[4]=f.Pop();f.Pc=510;continue;}
case 510:{f.Pc=476;continue;}
case 513:{f.Push(f.Locals[4]);f.Pc=515;continue;}
case 515:{f.Pc=f.Pop().Reference!=null?520:518;continue;}
case 518:{f.Push(JValue.I(0));f.Pc=519;continue;}
case 519:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 520:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=523;continue;}
case 523:{f.StackOp("dup");f.Pc=524;continue;}
case 524:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",527);}
case 527:{f.Locals[5]=f.Pop();f.Pc=529;continue;}
case 529:{f.Push(f.Locals[4]);f.Pc=531;continue;}
case 531:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",534);}
case 534:{f.Push(f.Locals[4]);f.Pc=536;continue;}
case 536:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getAllCandidates","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokevirtual",539);}
case 539:{f.Locals[6]=f.Pop();f.Pc=541;continue;}
case 541:{f.Push(f.Locals[6]);f.Pc=543;continue;}
case 543:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",548);}
case 548:{f.Locals[7]=f.Pop();f.Pc=550;continue;}
case 550:{f.Push(f.Locals[7]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",557);}
case 557:{f.Pc=f.Pop().Int==0?598:560;continue;}
case 560:{f.Push(f.Locals[7]);f.Pc=562;continue;}
case 562:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",567);}
case 567:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=570;continue;}
case 570:{f.Locals[8]=f.Pop();f.Pc=572;continue;}
case 572:{f.Push(f.Locals[8]);f.Pc=574;continue;}
case 574:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=577;continue;}
case 577:{f.Pc=f.Pop().Int==0?595:580;continue;}
case 580:{f.Push(f.Locals[8]);f.Pc=582;continue;}
case 582:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=585;continue;}
case 585:{f.Locals[9]=f.Pop();f.Pc=587;continue;}
case 587:{f.Push(f.Locals[5]);f.Pc=589;continue;}
case 589:{f.Push(f.Locals[9]);f.Pc=591;continue;}
case 591:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",594);}
case 594:{f.StackOp("pop");f.Pc=595;continue;}
case 595:{f.Pc=550;continue;}
case 598:{f.Push(f.Locals[5]);f.Pc=600;continue;}
case 600:{f.Push(f.Locals[4]);f.Pc=602;continue;}
case 602:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",605);}
case 605:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",608);}
case 608:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",611);}
case 611:{f.StackOp("pop");f.Pc=612;continue;}
case 612:{f.Push(f.Locals[5]);f.Pc=614;continue;}
case 614:{f.Push(f.Locals[0]);f.Pc=615;continue;}
case 615:{f.Push(JValue.R(rt.String("CanTargetOtherCondition")));f.Pc=617;continue;}
case 617:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",620);}
case 620:{f.Push(f.Locals[2]);f.Pc=621;continue;}
case 621:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",624);}
case 624:{f.Push(f.Locals[2]);f.Pc=625;continue;}
case 625:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",628);}
case 628:{f.Push(f.Locals[2]);f.Pc=629;continue;}
case 629:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",632);}
case 632:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",635);}
case 635:{f.Pc=f.Pop().Int==0?640:638;continue;}
case 638:{f.Push(JValue.I(0));f.Pc=639;continue;}
case 639:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 640:{f.Push(f.Locals[0]);f.Pc=641;continue;}
case 641:{f.Push(JValue.R(rt.String("HasXManaCost")));f.Pc=643;continue;}
case 643:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","hasParam","(Ljava/lang/String;)Z","invokevirtual",646);}
case 646:{f.Pc=f.Pop().Int==0?701:649;continue;}
case 649:{f.Push(f.Locals[2]);f.Pc=650;continue;}
case 650:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",653);}
case 653:{f.Pc=f.Pop().Int==0?685:656;continue;}
case 656:{f.Push(f.Locals[2]);f.Pc=657;continue;}
case 657:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",660);}
case 660:{return rt.Call(f,"forge/game/cost/Cost","hasManaCost","()Z","invokevirtual",663);}
case 663:{f.Pc=f.Pop().Int==0?679:666;continue;}
case 666:{f.Push(f.Locals[2]);f.Pc=667;continue;}
case 667:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",670);}
case 670:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",673);}
case 673:{return rt.Call(f,"forge/game/cost/CostPartMana","getAmountOfX","()I","invokevirtual",676);}
case 676:{f.Pc=680;continue;}
case 679:{f.Push(JValue.I(0));f.Pc=680;continue;}
case 680:{f.Locals[4]=f.Pop();f.Pc=682;continue;}
case 682:{f.Pc=694;continue;}
case 685:{f.Push(f.Locals[3]);f.Pc=686;continue;}
case 686:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",689);}
case 689:{return rt.Call(f,"forge/card/mana/ManaCost","countX","()I","invokevirtual",692);}
case 692:{f.Locals[4]=f.Pop();f.Pc=694;continue;}
case 694:{f.Push(f.Locals[4]);f.Pc=696;continue;}
case 696:{f.Pc=f.Pop().Int!=0?701:699;continue;}
case 699:{f.Push(JValue.I(0));f.Pc=700;continue;}
case 700:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 701:{f.Push(f.Locals[0]);f.Pc=702;continue;}
case 702:{f.Push(JValue.R(rt.String("IsSingleTarget")));f.Pc=704;continue;}
case 704:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","hasParam","(Ljava/lang/String;)Z","invokevirtual",707);}
case 707:{f.Pc=f.Pop().Int==0?787:710;continue;}
case 710:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",713);}
case 713:{f.Locals[4]=f.Pop();f.Pc=715;continue;}
case 715:{f.Push(f.Locals[2]);f.Pc=716;continue;}
case 716:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAllTargetChoices","()Ljava/util/List;","invokevirtual",719);}
case 719:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",724);}
case 724:{f.Locals[5]=f.Pop();f.Pc=726;continue;}
case 726:{f.Push(f.Locals[5]);f.Pc=728;continue;}
case 728:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",733);}
case 733:{f.Pc=f.Pop().Int==0?774:736;continue;}
case 736:{f.Push(f.Locals[5]);f.Pc=738;continue;}
case 738:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",743);}
case 743:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/TargetChoices"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=746;continue;}
case 746:{f.Locals[6]=f.Pop();f.Pc=748;continue;}
case 748:{f.Push(f.Locals[4]);f.Pc=750;continue;}
case 750:{f.Push(f.Locals[6]);f.Pc=752;continue;}
case 752:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",757);}
case 757:{f.StackOp("pop");f.Pc=758;continue;}
case 758:{f.Push(f.Locals[4]);f.Pc=760;continue;}
case 760:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",765);}
case 765:{f.Push(JValue.I(1));f.Pc=766;continue;}
case 766:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?771:769;continue;}
case 769:{f.Push(JValue.I(0));f.Pc=770;continue;}
case 770:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 771:{f.Pc=726;continue;}
case 774:{f.Push(f.Locals[4]);f.Pc=776;continue;}
case 776:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",781);}
case 781:{f.Push(JValue.I(1));f.Pc=782;continue;}
case 782:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?787:785;continue;}
case 785:{f.Push(JValue.I(0));f.Pc=786;continue;}
case 786:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 787:{f.Push(f.Locals[0]);f.Pc=788;continue;}
case 788:{f.Push(JValue.R(rt.String("NoColoredMana")));f.Pc=791;continue;}
case 791:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","hasParam","(Ljava/lang/String;)Z","invokevirtual",794);}
case 794:{f.Pc=f.Pop().Int==0?843:797;continue;}
case 797:{f.Push(f.Locals[2]);f.Pc=798;continue;}
case 798:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",801);}
case 801:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",806);}
case 806:{f.Locals[4]=f.Pop();f.Pc=808;continue;}
case 808:{f.Push(f.Locals[4]);f.Pc=810;continue;}
case 810:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",815);}
case 815:{f.Pc=f.Pop().Int==0?843:818;continue;}
case 818:{f.Push(f.Locals[4]);f.Pc=820;continue;}
case 820:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",825);}
case 825:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=828;continue;}
case 828:{f.Locals[5]=f.Pop();f.Pc=830;continue;}
case 830:{f.Push(f.Locals[5]);f.Pc=832;continue;}
case 832:{return rt.Call(f,"forge/game/mana/Mana","isColorless","()Z","invokevirtual",835);}
case 835:{f.Pc=f.Pop().Int!=0?840:838;continue;}
case 838:{f.Push(JValue.I(0));f.Pc=839;continue;}
case 839:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 840:{f.Pc=808;continue;}
case 843:{f.Push(f.Locals[0]);f.Pc=844;continue;}
case 844:{f.Push(JValue.R(rt.String("SnowSpentForCardsColor")));f.Pc=847;continue;}
case 847:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","hasParam","(Ljava/lang/String;)Z","invokevirtual",850);}
case 850:{f.Pc=f.Pop().Int==0?934:853;continue;}
case 853:{f.Push(JValue.I(0));f.Pc=854;continue;}
case 854:{f.Locals[4]=f.Pop();f.Pc=856;continue;}
case 856:{f.Push(f.Locals[2]);f.Pc=857;continue;}
case 857:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",860);}
case 860:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",865);}
case 865:{f.Locals[5]=f.Pop();f.Pc=867;continue;}
case 867:{f.Push(f.Locals[5]);f.Pc=869;continue;}
case 869:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",874);}
case 874:{f.Pc=f.Pop().Int==0?927:877;continue;}
case 877:{f.Push(f.Locals[5]);f.Pc=879;continue;}
case 879:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",884);}
case 884:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=887;continue;}
case 887:{f.Locals[6]=f.Pop();f.Pc=889;continue;}
case 889:{f.Push(f.Locals[6]);f.Pc=891;continue;}
case 891:{return rt.Call(f,"forge/game/mana/Mana","isSnow","()Z","invokevirtual",894);}
case 894:{f.Pc=f.Pop().Int!=0?900:897;continue;}
case 897:{f.Pc=867;continue;}
case 900:{f.Push(f.Locals[3]);f.Pc=901;continue;}
case 901:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",904);}
case 904:{f.Push(f.Locals[6]);f.Pc=906;continue;}
case 906:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",909);}
case 909:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",912);}
case 912:{return rt.Call(f,"forge/card/ColorSet","sharesColorWith","(Lforge/card/ColorSet;)Z","invokevirtual",915);}
case 915:{f.Pc=f.Pop().Int==0?924:918;continue;}
case 918:{f.Push(JValue.I(1));f.Pc=919;continue;}
case 919:{f.Locals[4]=f.Pop();f.Pc=921;continue;}
case 921:{f.Pc=927;continue;}
case 924:{f.Pc=867;continue;}
case 927:{f.Push(f.Locals[4]);f.Pc=929;continue;}
case 929:{f.Pc=f.Pop().Int!=0?934:932;continue;}
case 932:{f.Push(JValue.I(0));f.Pc=933;continue;}
case 933:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 934:{f.Push(f.Locals[0]);f.Pc=935;continue;}
case 935:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","getSpawningAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",938);}
case 938:{f.Pc=f.Pop().Reference==null?969:941;continue;}
case 941:{f.Push(f.Locals[0]);f.Pc=942;continue;}
case 942:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","getSpawningAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",945);}
case 945:{f.Push(JValue.R(rt.String("TriggersWhenSpent")));f.Pc=948;continue;}
case 948:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",951);}
case 951:{f.Pc=f.Pop().Int==0?969:954;continue;}
case 954:{f.Push(f.Locals[0]);f.Pc=955;continue;}
case 955:{return rt.Call(f,"forge/game/trigger/TriggerSpellAbilityCastOrCopy","getTriggerRemembered","()Ljava/util/List;","invokevirtual",958);}
case 958:{f.Push(f.Locals[2]);f.Pc=959;continue;}
case 959:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",964);}
case 964:{f.Pc=f.Pop().Int!=0?969:967;continue;}
case 967:{f.Push(JValue.I(0));f.Pc=968;continue;}
case 968:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 969:{f.Push(JValue.I(1));f.Pc=970;continue;}
case 970:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10704(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAllTargetChoices","()Ljava/util/List;","invokevirtual",42);}
case 42:{f.Locals[4]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",51);}
case 51:{f.Pc=f.Pop().Int!=0?120:54;continue;}
case 54:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",61);}
case 61:{f.Locals[5]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",70);}
case 70:{f.Locals[6]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",79);}
case 79:{f.Pc=f.Pop().Int==0?108:82;continue;}
case 82:{f.Push(f.Locals[6]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",89);}
case 89:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/TargetChoices"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=92;continue;}
case 92:{f.Locals[7]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[5]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[7]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetEntities","()Ljava/lang/Iterable;","invokevirtual",101);}
case 101:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/lang/Iterable;)Z","invokevirtual",104);}
case 104:{f.StackOp("pop");f.Pc=105;continue;}
case 105:{f.Pc=72;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbilityTargets","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbilityTargets","Lforge/game/ability/AbilityKey;"));f.Pc=112;continue;}
case 112:{f.Push(f.Locals[5]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",119);}
case 119:{f.StackOp("pop");f.Pc=120;continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LifeAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LifeAmount","Lforge/game/ability/AbilityKey;"));f.Pc=124;continue;}
case 124:{f.Push(f.Locals[3]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAmountLifePaid","()I","invokevirtual",128);}
case 128:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",131);}
case 131:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",136);}
case 136:{f.StackOp("pop");f.Pc=137;continue;}
case 137:{f.Push(f.Locals[2]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Push(JValue.I(4));f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.NewArray("Lforge/game/ability/AbilityKey;",f.Pop().Int)));f.Pc=143;continue;}
case 143:{f.StackOp("dup");f.Pc=144;continue;}
case 144:{f.Push(JValue.I(0));f.Pc=145;continue;}
case 145:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=148;continue;}
case 148:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=149;continue;}
case 149:{f.StackOp("dup");f.Pc=150;continue;}
case 150:{f.Push(JValue.I(1));f.Pc=151;continue;}
case 151:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"));f.Pc=154;continue;}
case 154:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=155;continue;}
case 155:{f.StackOp("dup");f.Pc=156;continue;}
case 156:{f.Push(JValue.I(2));f.Pc=157;continue;}
case 157:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CurrentStormCount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CurrentStormCount","Lforge/game/ability/AbilityKey;"));f.Pc=160;continue;}
case 160:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=161;continue;}
case 161:{f.StackOp("dup");f.Pc=162;continue;}
case 162:{f.Push(JValue.I(3));f.Pc=163;continue;}
case 163:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CurrentCastSpells","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CurrentCastSpells","Lforge/game/ability/AbilityKey;"));f.Pc=166;continue;}
case 166:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/ability/AbilityKey","copyKeys","(Ljava/util/Map;Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V","invokestatic",170);}
case 170:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10705(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",12);}
case 12:{f.Push(JValue.R(rt.String("lblCard")));f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",22);}
case 22:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",25);}
case 25:{f.Push(JValue.R(rt.String(": ")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",38);}
case 38:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",41);}
case 41:{f.Push(JValue.R(rt.String(", ")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",52);}
case 52:{f.Push(JValue.R(rt.String("lblActivator")));f.Pc=55;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",62);}
case 62:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",65);}
case 65:{f.Push(JValue.R(rt.String(": ")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",71);}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",78);}
case 78:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",81);}
case 81:{f.Push(JValue.R(rt.String(", ")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",87);}
case 87:{f.StackOp("pop");f.Pc=88;continue;}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",92);}
case 92:{f.Push(JValue.R(rt.String("lblSpellAbility")));f.Pc=95;continue;}
case 95:{f.Push(JValue.I(0));f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",102);}
case 102:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",105);}
case 105:{f.Push(JValue.R(rt.String(": ")));f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",111);}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"));f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",118);}
case 118:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",121);}
case 121:{f.StackOp("pop");f.Pc=122;continue;}
case 122:{f.Push(f.Locals[2]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",126);}
case 126:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
