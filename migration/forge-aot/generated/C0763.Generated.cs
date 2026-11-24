// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C763{
internal static JClass Build(){var c=new JClass("forge/game/replacement/ReplaceMoved","forge/game/replacement/ReplacementEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(8943,"forge/game/replacement/ReplaceMoved","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M8943));
c.Add(new JMethod(8944,"forge/game/replacement/ReplaceMoved","canReplace","(Ljava/util/Map;)Z",1,3,4,new JHandler[]{},M8944));
c.Add(new JMethod(8945,"forge/game/replacement/ReplaceMoved","setReplacingObjects","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)V",1,3,6,new JHandler[]{},M8945));
}

internal static JStep M8943(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8944(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Destination")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?42:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",18);}
case 18:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=21;continue;}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Destination")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",31);}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int!=0?42:40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("Origin")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","hasParam","(Ljava/lang/String;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?84:51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",60);}
case 60:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=63;continue;}
case 63:{f.Locals[2]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("Origin")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",70);}
case 70:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",73);}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",79);}
case 79:{f.Pc=f.Pop().Int!=0?84:82;continue;}
case 82:{f.Push(JValue.I(0));f.Pc=83;continue;}
case 83:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",96);}
case 96:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int!=0?104:102;continue;}
case 102:{f.Push(JValue.I(0));f.Pc=103;continue;}
case 103:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String("ValidLKI")));f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",116);}
case 116:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",119);}
case 119:{f.Pc=f.Pop().Int!=0?124:122;continue;}
case 122:{f.Push(JValue.I(0));f.Pc=123;continue;}
case 123:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("ValidStackSa")));f.Pc=127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","StackSa","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","StackSa","Lforge/game/ability/AbilityKey;"));f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",136);}
case 136:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",139);}
case 139:{f.Pc=f.Pop().Int!=0?144:142;continue;}
case 142:{f.Push(JValue.I(0));f.Pc=143;continue;}
case 143:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.String("ValidCause")));f.Pc=147;continue;}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",156);}
case 156:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",159);}
case 159:{f.Pc=f.Pop().Int!=0?164:162;continue;}
case 162:{f.Push(JValue.I(0));f.Pc=163;continue;}
case 163:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("ExcludeDestination")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","hasParam","(Ljava/lang/String;)Z","invokevirtual",170);}
case 170:{f.Pc=f.Pop().Int==0?206:173;continue;}
case 173:{f.Push(f.Locals[1]);f.Pc=174;continue;}
case 174:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",182);}
case 182:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=185;continue;}
case 185:{f.Locals[2]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{f.Push(JValue.R(rt.String("ExcludeDestination")));f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",192);}
case 192:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",195);}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",201);}
case 201:{f.Pc=f.Pop().Int==0?206:204;continue;}
case 204:{f.Push(JValue.I(0));f.Pc=205;continue;}
case 205:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 206:{f.Push(f.Locals[0]);f.Pc=207;continue;}
case 207:{f.Push(JValue.R(rt.String("Fizzle")));f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","hasParam","(Ljava/lang/String;)Z","invokevirtual",212);}
case 212:{f.Pc=f.Pop().Int==0?262:215;continue;}
case 215:{f.Push(f.Locals[1]);f.Pc=216;continue;}
case 216:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Fizzle","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Fizzle","Lforge/game/ability/AbilityKey;"));f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",224);}
case 224:{f.Pc=f.Pop().Int!=0?229:227;continue;}
case 227:{f.Push(JValue.I(0));f.Pc=228;continue;}
case 228:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 229:{f.Push(f.Locals[1]);f.Pc=230;continue;}
case 230:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Fizzle","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Fizzle","Lforge/game/ability/AbilityKey;"));f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",238);}
case 238:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=241;continue;}
case 241:{f.Locals[2]=f.Pop();f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.String("True")));f.Pc=244;continue;}
case 244:{f.Push(f.Locals[0]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String("Fizzle")));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",250);}
case 250:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",253);}
case 253:{f.Push(f.Locals[2]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",257);}
case 257:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?262:260;continue;}
case 260:{f.Push(JValue.I(0));f.Pc=261;continue;}
case 261:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 262:{f.Push(f.Locals[0]);f.Pc=263;continue;}
case 263:{f.Push(JValue.R(rt.String("Cycling")));f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","hasParam","(Ljava/lang/String;)Z","invokevirtual",268);}
case 268:{f.Pc=f.Pop().Int==0?296:271;continue;}
case 271:{f.Push(f.Locals[0]);f.Pc=272;continue;}
case 272:{f.Push(JValue.R(rt.String("Cycling")));f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",277);}
case 277:{f.Push(JValue.R(rt.String("True")));f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",282);}
case 282:{f.Push(f.Locals[1]);f.Pc=283;continue;}
case 283:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cycling","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cycling","Lforge/game/ability/AbilityKey;"));f.Pc=286;continue;}
case 286:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",291);}
case 291:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?296:294;continue;}
case 294:{f.Push(JValue.I(0));f.Pc=295;continue;}
case 295:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 296:{f.Push(f.Locals[0]);f.Pc=297;continue;}
case 297:{f.Push(JValue.R(rt.String("Discard")));f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","hasParam","(Ljava/lang/String;)Z","invokevirtual",302);}
case 302:{f.Pc=f.Pop().Int==0?330:305;continue;}
case 305:{f.Push(f.Locals[0]);f.Pc=306;continue;}
case 306:{f.Push(JValue.R(rt.String("Discard")));f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",311);}
case 311:{f.Push(JValue.R(rt.String("True")));f.Pc=313;continue;}
case 313:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",316);}
case 316:{f.Push(f.Locals[1]);f.Pc=317;continue;}
case 317:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Discard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Discard","Lforge/game/ability/AbilityKey;"));f.Pc=320;continue;}
case 320:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",325);}
case 325:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?330:328;continue;}
case 328:{f.Push(JValue.I(0));f.Pc=329;continue;}
case 329:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 330:{f.Push(f.Locals[0]);f.Pc=331;continue;}
case 331:{f.Push(JValue.R(rt.String("EffectOnly")));f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","hasParam","(Ljava/lang/String;)Z","invokevirtual",336);}
case 336:{f.Pc=f.Pop().Int==0?361:339;continue;}
case 339:{f.Push(f.Locals[1]);f.Pc=340;continue;}
case 340:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","EffectOnly","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","EffectOnly","Lforge/game/ability/AbilityKey;"));f.Pc=343;continue;}
case 343:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",348);}
case 348:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=351;continue;}
case 351:{f.Locals[2]=f.Pop();f.Pc=352;continue;}
case 352:{f.Push(f.Locals[2]);f.Pc=353;continue;}
case 353:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",356);}
case 356:{f.Pc=f.Pop().Int!=0?361:359;continue;}
case 359:{f.Push(JValue.I(0));f.Pc=360;continue;}
case 360:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 361:{f.Push(f.Locals[0]);f.Pc=362;continue;}
case 362:{f.Push(JValue.R(rt.String("FoundSearchingLibrary")));f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","hasParam","(Ljava/lang/String;)Z","invokevirtual",367);}
case 367:{f.Pc=f.Pop().Int==0?406:370;continue;}
case 370:{f.Push(f.Locals[1]);f.Pc=371;continue;}
case 371:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","FoundSearchingLibrary","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","FoundSearchingLibrary","Lforge/game/ability/AbilityKey;"));f.Pc=374;continue;}
case 374:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",379);}
case 379:{f.Pc=f.Pop().Int!=0?384:382;continue;}
case 382:{f.Push(JValue.I(0));f.Pc=383;continue;}
case 383:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 384:{f.Push(f.Locals[1]);f.Pc=385;continue;}
case 385:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","FoundSearchingLibrary","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","FoundSearchingLibrary","Lforge/game/ability/AbilityKey;"));f.Pc=388;continue;}
case 388:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",393);}
case 393:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=396;continue;}
case 396:{f.Locals[2]=f.Pop();f.Pc=397;continue;}
case 397:{f.Push(f.Locals[2]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",401);}
case 401:{f.Pc=f.Pop().Int!=0?406:404;continue;}
case 404:{f.Push(JValue.I(0));f.Pc=405;continue;}
case 405:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 406:{f.Push(f.Locals[1]);f.Pc=407;continue;}
case 407:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=410;continue;}
case 410:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",415);}
case 415:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=418;continue;}
case 418:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?431:421;continue;}
case 421:{f.Push(f.Locals[0]);f.Pc=422;continue;}
case 422:{f.Push(f.Locals[1]);f.Pc=423;continue;}
case 423:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","canReplaceETB","(Ljava/util/Map;)Z","invokevirtual",426);}
case 426:{f.Pc=f.Pop().Int!=0?431:429;continue;}
case 429:{f.Push(JValue.I(0));f.Pc=430;continue;}
case 430:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 431:{f.Push(f.Locals[0]);f.Pc=432;continue;}
case 432:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","COMPLEATED","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","COMPLEATED","Lforge/game/keyword/Keyword;"));f.Pc=435;continue;}
case 435:{return rt.Call(f,"forge/game/replacement/ReplaceMoved","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",438);}
case 438:{f.Pc=f.Pop().Int==0?491:441;continue;}
case 441:{f.Push(f.Locals[1]);f.Pc=442;continue;}
case 442:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=445;continue;}
case 445:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",450);}
case 450:{f.Pc=f.Pop().Int!=0?455:453;continue;}
case 453:{f.Push(JValue.I(0));f.Pc=454;continue;}
case 454:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 455:{f.Push(f.Locals[1]);f.Pc=456;continue;}
case 456:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=459;continue;}
case 459:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",464);}
case 464:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntityCounterTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=467;continue;}
case 467:{f.Locals[2]=f.Pop();f.Pc=468;continue;}
case 468:{f.Push(f.Locals[2]);f.Pc=469;continue;}
case 469:{f.Push(f.Locals[0]);f.Pc=470;continue;}
case 470:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplaceMoved","hostCard","Lforge/game/card/Card;"));f.Pc=473;continue;}
case 473:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",476);}
case 476:{f.Push(f.Locals[0]);f.Pc=477;continue;}
case 477:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplaceMoved","hostCard","Lforge/game/card/Card;"));f.Pc=480;continue;}
case 480:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"));f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/game/GameEntityCounterTable","get","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;)I","invokevirtual",486);}
case 486:{f.Pc=f.Pop().Int>0?491:489;continue;}
case 489:{f.Push(JValue.I(0));f.Pc=490;continue;}
case 490:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 491:{f.Push(JValue.I(1));f.Pc=492;continue;}
case 492:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8945(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",13);}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(7));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.NewArray("Lforge/game/ability/AbilityKey;",f.Pop().Int)));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","NewCard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","NewCard","Lforge/game/ability/AbilityKey;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(1));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(2));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(3));f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=46;continue;}
case 46:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=47;continue;}
case 47:{f.StackOp("dup");f.Pc=48;continue;}
case 48:{f.Push(JValue.I(4));f.Pc=49;continue;}
case 49:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=52;continue;}
case 52:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=53;continue;}
case 53:{f.StackOp("dup");f.Pc=54;continue;}
case 54:{f.Push(JValue.I(5));f.Pc=55;continue;}
case 55:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=58;continue;}
case 58:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=59;continue;}
case 59:{f.StackOp("dup");f.Pc=60;continue;}
case 60:{f.Push(JValue.I(6));f.Pc=62;continue;}
case 62:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterMap","Lforge/game/ability/AbilityKey;"));f.Pc=65;continue;}
case 65:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObjectsFrom","(Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V","invokevirtual",69);}
case 69:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
