// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1140{
internal static JClass Build(){var c=new JClass("forge/util/MessageUtil","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11945,"forge/util/MessageUtil","<init>","()V",2,1,1,new JHandler[]{},M11945));
c.Add(new JMethod(11946,"forge/util/MessageUtil","formatMessage","(Ljava/lang/String;Lforge/game/player/Player;Ljava/lang/Object;)Ljava/lang/String;",9,4,4,new JHandler[]{},M11946));
c.Add(new JMethod(11947,"forge/util/MessageUtil","formatMessage","(Ljava/lang/String;Lforge/game/player/PlayerView;Ljava/lang/Object;)Ljava/lang/String;",9,4,4,new JHandler[]{},M11947));
c.Add(new JMethod(11948,"forge/util/MessageUtil","formatNotificationMessage","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/GameObject;Ljava/lang/String;)Ljava/lang/String;",9,7,7,new JHandler[]{},M11948));
c.Add(new JMethod(11949,"forge/util/MessageUtil","mayBeYou","(Lforge/game/player/Player;Ljava/lang/Object;)Ljava/lang/String;",9,2,3,new JHandler[]{},M11949));
c.Add(new JMethod(11950,"forge/util/MessageUtil","mayBeYou","(Lforge/game/player/PlayerView;Ljava/lang/Object;)Ljava/lang/String;",9,2,3,new JHandler[]{},M11950));
}

internal static JStep M11945(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11946(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?42:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("{player")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?42:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/MessageUtil","mayBeYou","(Lforge/game/player/Player;Ljava/lang/Object;)Ljava/lang/String;","invokestatic",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("{player}")));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",29);}
case 29:{f.Push(JValue.R(rt.String("{player's}")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",34);}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/util/Lang","getPossesive","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",38);}
case 38:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",41);}
case 41:{f.Locals[0]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11947(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/PlayerView")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?42:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("{player")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?42:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/MessageUtil","mayBeYou","(Lforge/game/player/PlayerView;Ljava/lang/Object;)Ljava/lang/String;","invokestatic",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("{player}")));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",29);}
case 29:{f.Push(JValue.R(rt.String("{player's}")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",34);}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/util/Lang","getPossesive","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",38);}
case 38:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",41);}
case 41:{f.Locals[0]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11948(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?18:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Reference==null?18:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Reference!=null?23:18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",22);}
case 22:{return JStep.Return(f.Pop());}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/util/MessageUtil","mayBeYou","(Lforge/game/player/Player;Ljava/lang/Object;)Ljava/lang/String;","invokestatic",28);}
case 28:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{if(!rt.StaticReady(f,"forge/util/MessageUtil$1","$SwitchMap$forge$game$ability$ApiType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/MessageUtil$1","$SwitchMap$forge$game$ability$ApiType","[I"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",40);}
case 40:{return rt.Call(f,"forge/game/ability/ApiType","ordinal","()I","invokevirtual",43);}
case 43:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=44;continue;}
case 44:{switch(f.Pop().Int){case 1:f.Pc=124;break;case 2:f.Pc=124;break;case 3:f.Pc=124;break;case 4:f.Pc=124;break;case 5:f.Pc=124;break;case 6:f.Pc=126;break;case 7:f.Pc=126;break;case 8:f.Pc=176;break;case 9:f.Pc=248;break;case 10:f.Pc=298;break;case 11:f.Pc=374;break;case 12:f.Pc=408;break;case 13:f.Pc=430;break;case 14:f.Pc=430;break;case 15:f.Pc=430;break;case 16:f.Pc=432;break;default:f.Pc=475;break;}continue;}
case 124:{f.Push(f.Locals[3]);f.Pc=125;continue;}
case 125:{return JStep.Return(f.Pop());}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("Random")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",132);}
case 132:{f.Pc=f.Pop().Int==0?154:135;continue;}
case 135:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",138);}
case 138:{f.Push(JValue.R(rt.String("lblRandomColorChosen")));f.Pc=140;continue;}
case 140:{f.Push(JValue.I(1));f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=144;continue;}
case 144:{f.StackOp("dup");f.Pc=145;continue;}
case 145:{f.Push(JValue.I(0));f.Pc=146;continue;}
case 146:{f.Push(f.Locals[3]);f.Pc=147;continue;}
case 147:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",151);}
case 151:{f.Pc=175;continue;}
case 154:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",157);}
case 157:{f.Push(JValue.R(rt.String("lblPlayerPickedChosen")));f.Pc=159;continue;}
case 159:{f.Push(JValue.I(2));f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=163;continue;}
case 163:{f.StackOp("dup");f.Pc=164;continue;}
case 164:{f.Push(JValue.I(0));f.Pc=165;continue;}
case 165:{f.Push(f.Locals[4]);f.Pc=167;continue;}
case 167:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=168;continue;}
case 168:{f.StackOp("dup");f.Pc=169;continue;}
case 169:{f.Push(JValue.I(1));f.Pc=170;continue;}
case 170:{f.Push(f.Locals[3]);f.Pc=171;continue;}
case 171:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",175);}
case 175:{return JStep.Return(f.Pop());}
case 176:{f.Push(f.Locals[0]);f.Pc=177;continue;}
case 177:{f.Push(JValue.R(rt.String("Secretly")));f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",182);}
case 182:{f.Pc=f.Pop().Int==0?187:185;continue;}
case 185:{f.Push(f.Locals[3]);f.Pc=186;continue;}
case 186:{return JStep.Return(f.Pop());}
case 187:{f.Push(f.Locals[0]);f.Pc=188;continue;}
case 188:{f.Push(JValue.R(rt.String("Random")));f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",193);}
case 193:{f.Pc=f.Pop().Int==0?223:196;continue;}
case 196:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",199);}
case 199:{f.Push(JValue.R(rt.String("lblPlayerRandomChosenNumberIs")));f.Pc=201;continue;}
case 201:{f.Push(JValue.I(2));f.Pc=202;continue;}
case 202:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=205;continue;}
case 205:{f.StackOp("dup");f.Pc=206;continue;}
case 206:{f.Push(JValue.I(0));f.Pc=207;continue;}
case 207:{f.Push(f.Locals[1]);f.Pc=208;continue;}
case 208:{f.Push(f.Locals[2]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/util/MessageUtil","mayBeYou","(Lforge/game/player/Player;Ljava/lang/Object;)Ljava/lang/String;","invokestatic",212);}
case 212:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=213;continue;}
case 213:{f.StackOp("dup");f.Pc=214;continue;}
case 214:{f.Push(JValue.I(1));f.Pc=215;continue;}
case 215:{f.Push(f.Locals[3]);f.Pc=216;continue;}
case 216:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",220);}
case 220:{f.Pc=247;continue;}
case 223:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",226);}
case 226:{f.Push(JValue.R(rt.String("lblPlayerChoosesNumberIs")));f.Pc=228;continue;}
case 228:{f.Push(JValue.I(2));f.Pc=229;continue;}
case 229:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=232;continue;}
case 232:{f.StackOp("dup");f.Pc=233;continue;}
case 233:{f.Push(JValue.I(0));f.Pc=234;continue;}
case 234:{f.Push(f.Locals[1]);f.Pc=235;continue;}
case 235:{f.Push(f.Locals[2]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/util/MessageUtil","mayBeYou","(Lforge/game/player/Player;Ljava/lang/Object;)Ljava/lang/String;","invokestatic",239);}
case 239:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=240;continue;}
case 240:{f.StackOp("dup");f.Pc=241;continue;}
case 241:{f.Push(JValue.I(1));f.Pc=242;continue;}
case 242:{f.Push(f.Locals[3]);f.Pc=243;continue;}
case 243:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",247);}
case 247:{return JStep.Return(f.Pop());}
case 248:{f.Push(f.Locals[0]);f.Pc=249;continue;}
case 249:{f.Push(JValue.R(rt.String("AtRandom")));f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",254);}
case 254:{f.Pc=f.Pop().Int==0?276:257;continue;}
case 257:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",260);}
case 260:{f.Push(JValue.R(rt.String("lblRandomTypeChosen")));f.Pc=262;continue;}
case 262:{f.Push(JValue.I(1));f.Pc=263;continue;}
case 263:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=266;continue;}
case 266:{f.StackOp("dup");f.Pc=267;continue;}
case 267:{f.Push(JValue.I(0));f.Pc=268;continue;}
case 268:{f.Push(f.Locals[3]);f.Pc=269;continue;}
case 269:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",273);}
case 273:{f.Pc=297;continue;}
case 276:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",279);}
case 279:{f.Push(JValue.R(rt.String("lblPlayerPickedChosen")));f.Pc=281;continue;}
case 281:{f.Push(JValue.I(2));f.Pc=282;continue;}
case 282:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=285;continue;}
case 285:{f.StackOp("dup");f.Pc=286;continue;}
case 286:{f.Push(JValue.I(0));f.Pc=287;continue;}
case 287:{f.Push(f.Locals[4]);f.Pc=289;continue;}
case 289:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=290;continue;}
case 290:{f.StackOp("dup");f.Pc=291;continue;}
case 291:{f.Push(JValue.I(1));f.Pc=292;continue;}
case 292:{f.Push(f.Locals[3]);f.Pc=293;continue;}
case 293:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",297);}
case 297:{return JStep.Return(f.Pop());}
case 298:{f.Push(f.Locals[1]);f.Pc=299;continue;}
case 299:{f.Push(f.Locals[2]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/util/MessageUtil","mayBeYou","(Lforge/game/player/Player;Ljava/lang/Object;)Ljava/lang/String;","invokestatic",303);}
case 303:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",306);}
case 306:{f.Locals[5]=f.Pop();f.Pc=308;continue;}
case 308:{f.Push(f.Locals[0]);f.Pc=309;continue;}
case 309:{f.Push(JValue.R(rt.String("NoCall")));f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",314);}
case 314:{f.Pc=f.Pop().Int==0?347:317;continue;}
case 317:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",320);}
case 320:{f.Push(JValue.R(rt.String("lblPlayerFlipComesUpValue")));f.Pc=322;continue;}
case 322:{f.Push(JValue.I(2));f.Pc=323;continue;}
case 323:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=326;continue;}
case 326:{f.StackOp("dup");f.Pc=327;continue;}
case 327:{f.Push(JValue.I(0));f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",331);}
case 331:{f.Push(f.Locals[5]);f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/util/Lang","getPossesive","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",336);}
case 336:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=337;continue;}
case 337:{f.StackOp("dup");f.Pc=338;continue;}
case 338:{f.Push(JValue.I(1));f.Pc=339;continue;}
case 339:{f.Push(f.Locals[3]);f.Pc=340;continue;}
case 340:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=341;continue;}
case 341:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",344);}
case 344:{f.Pc=373;continue;}
case 347:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",350);}
case 350:{f.Push(JValue.R(rt.String("lblPlayerActionFlip")));f.Pc=352;continue;}
case 352:{f.Push(JValue.I(2));f.Pc=353;continue;}
case 353:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=356;continue;}
case 356:{f.StackOp("dup");f.Pc=357;continue;}
case 357:{f.Push(JValue.I(0));f.Pc=358;continue;}
case 358:{f.Push(f.Locals[5]);f.Pc=360;continue;}
case 360:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=361;continue;}
case 361:{f.StackOp("dup");f.Pc=362;continue;}
case 362:{f.Push(JValue.I(1));f.Pc=363;continue;}
case 363:{f.Push(f.Locals[5]);f.Pc=365;continue;}
case 365:{f.Push(f.Locals[3]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/util/Lang","joinVerb","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",369);}
case 369:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",373);}
case 373:{return JStep.Return(f.Pop());}
case 374:{f.Push(f.Locals[0]);f.Pc=375;continue;}
case 375:{f.Push(JValue.R(rt.String("Secretly")));f.Pc=377;continue;}
case 377:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",380);}
case 380:{f.Pc=f.Pop().Int!=0?406:383;continue;}
case 383:{f.Push(f.Locals[0]);f.Pc=384;continue;}
case 384:{f.Push(JValue.R(rt.String("ShowChoice")));f.Pc=386;continue;}
case 386:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",389);}
case 389:{f.Pc=f.Pop().Int==0?408:392;continue;}
case 392:{f.Push(f.Locals[0]);f.Pc=393;continue;}
case 393:{f.Push(JValue.R(rt.String("ShowChoice")));f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",398);}
case 398:{f.Push(JValue.R(rt.String("Description")));f.Pc=400;continue;}
case 400:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",403);}
case 403:{f.Pc=f.Pop().Int==0?408:406;continue;}
case 406:{f.Push(f.Locals[3]);f.Pc=407;continue;}
case 407:{return JStep.Return(f.Pop());}
case 408:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",411);}
case 411:{f.Push(JValue.R(rt.String("lblPlayerChooseValue")));f.Pc=413;continue;}
case 413:{f.Push(JValue.I(2));f.Pc=414;continue;}
case 414:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=417;continue;}
case 417:{f.StackOp("dup");f.Pc=418;continue;}
case 418:{f.Push(JValue.I(0));f.Pc=419;continue;}
case 419:{f.Push(f.Locals[4]);f.Pc=421;continue;}
case 421:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=422;continue;}
case 422:{f.StackOp("dup");f.Pc=423;continue;}
case 423:{f.Push(JValue.I(1));f.Pc=424;continue;}
case 424:{f.Push(f.Locals[3]);f.Pc=425;continue;}
case 425:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=426;continue;}
case 426:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",429);}
case 429:{return JStep.Return(f.Pop());}
case 430:{f.Push(f.Locals[3]);f.Pc=431;continue;}
case 431:{return JStep.Return(f.Pop());}
case 432:{f.Push(f.Locals[0]);f.Pc=433;continue;}
case 433:{f.Push(JValue.R(rt.String("Secretly")));f.Pc=435;continue;}
case 435:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",438);}
case 438:{f.Pc=f.Pop().Int==0?443:441;continue;}
case 441:{f.Push(f.Locals[3]);f.Pc=442;continue;}
case 442:{return JStep.Return(f.Pop());}
case 443:{f.Push(f.Locals[1]);f.Pc=444;continue;}
case 444:{f.Push(f.Locals[2]);f.Pc=445;continue;}
case 445:{return rt.Call(f,"forge/util/MessageUtil","mayBeYou","(Lforge/game/player/Player;Ljava/lang/Object;)Ljava/lang/String;","invokestatic",448);}
case 448:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",451);}
case 451:{f.Locals[6]=f.Pop();f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",456);}
case 456:{f.Push(JValue.R(rt.String("lblPlayerVoteValue")));f.Pc=458;continue;}
case 458:{f.Push(JValue.I(2));f.Pc=459;continue;}
case 459:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=462;continue;}
case 462:{f.StackOp("dup");f.Pc=463;continue;}
case 463:{f.Push(JValue.I(0));f.Pc=464;continue;}
case 464:{f.Push(f.Locals[6]);f.Pc=466;continue;}
case 466:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=467;continue;}
case 467:{f.StackOp("dup");f.Pc=468;continue;}
case 468:{f.Push(JValue.I(1));f.Pc=469;continue;}
case 469:{f.Push(f.Locals[3]);f.Pc=470;continue;}
case 470:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=471;continue;}
case 471:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",474);}
case 474:{return JStep.Return(f.Pop());}
case 475:{f.Push(f.Locals[1]);f.Pc=476;continue;}
case 476:{f.Push(f.Locals[2]);f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/util/MessageUtil","mayBeYou","(Lforge/game/player/Player;Ljava/lang/Object;)Ljava/lang/String;","invokestatic",480);}
case 480:{f.Locals[6]=f.Pop();f.Pc=482;continue;}
case 482:{f.Push(f.Locals[6]);f.Pc=484;continue;}
case 484:{f.Push(JValue.R(rt.String("(null)")));f.Pc=486;continue;}
case 486:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",489);}
case 489:{f.Pc=f.Pop().Int==0?519:492;continue;}
case 492:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",495);}
case 495:{f.Push(JValue.R(rt.String("lblCardEffectValueIs")));f.Pc=497;continue;}
case 497:{f.Push(JValue.I(2));f.Pc=498;continue;}
case 498:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=501;continue;}
case 501:{f.StackOp("dup");f.Pc=502;continue;}
case 502:{f.Push(JValue.I(0));f.Pc=503;continue;}
case 503:{f.Push(f.Locals[0]);f.Pc=504;continue;}
case 504:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",507);}
case 507:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",510);}
case 510:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=511;continue;}
case 511:{f.StackOp("dup");f.Pc=512;continue;}
case 512:{f.Push(JValue.I(1));f.Pc=513;continue;}
case 513:{f.Push(f.Locals[3]);f.Pc=514;continue;}
case 514:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=515;continue;}
case 515:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",518);}
case 518:{return JStep.Return(f.Pop());}
case 519:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",522);}
case 522:{f.Push(JValue.R(rt.String("lblCardEffectToTargetValueIs")));f.Pc=524;continue;}
case 524:{f.Push(JValue.I(3));f.Pc=525;continue;}
case 525:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=528;continue;}
case 528:{f.StackOp("dup");f.Pc=529;continue;}
case 529:{f.Push(JValue.I(0));f.Pc=530;continue;}
case 530:{f.Push(f.Locals[0]);f.Pc=531;continue;}
case 531:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",534);}
case 534:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",537);}
case 537:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=538;continue;}
case 538:{f.StackOp("dup");f.Pc=539;continue;}
case 539:{f.Push(JValue.I(1));f.Pc=540;continue;}
case 540:{f.Push(f.Locals[6]);f.Pc=542;continue;}
case 542:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=543;continue;}
case 543:{f.StackOp("dup");f.Pc=544;continue;}
case 544:{f.Push(JValue.I(2));f.Pc=545;continue;}
case 545:{f.Push(f.Locals[3]);f.Pc=546;continue;}
case 546:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=547;continue;}
case 547:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",550);}
case 550:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11949(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?9:4;continue;}
case 4:{f.Push(JValue.R(rt.String("(null)")));f.Pc=6;continue;}
case 6:{f.Pc=33;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?29:14;continue;}
case 14:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",17);}
case 17:{f.Push(JValue.R(rt.String("lblYou")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Pc=33;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",33);}
case 33:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11950(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?9:4;continue;}
case 4:{f.Push(JValue.R(rt.String("(null)")));f.Pc=6;continue;}
case 6:{f.Pc=33;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?29:14;continue;}
case 14:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",17);}
case 17:{f.Push(JValue.R(rt.String("lblYou")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Pc=33;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",33);}
case 33:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
