// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C376{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RepeatEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3638,"forge/game/ability/effects/RepeatEffect","<init>","()V",1,1,1,new JHandler[]{},M3638));
c.Add(new JMethod(3639,"forge/game/ability/effects/RepeatEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,1,new JHandler[]{},M3639));
c.Add(new JMethod(3640,"forge/game/ability/effects/RepeatEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,7,3,new JHandler[]{},M3640));
c.Add(new JMethod(3641,"forge/game/ability/effects/RepeatEffect","checkRepeatConditions","(Lforge/game/spellability/SpellAbility;)Z",10,9,6,new JHandler[]{},M3641));
}

internal static JStep M3638(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3639(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Repeat something. Somebody should really write a better StackDescription!")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3640(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("RepeatSubAbility")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("MaxRepeat")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?49:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("MaxRepeat")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",35);}
case 35:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",38);}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int!=0?49:48;continue;}
case 48:{return JStep.ReturnVoid;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{f.Locals[5]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",56);}
case 56:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Reference==null?137:64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",69);}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?137:74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",78);}
case 78:{f.Push(JValue.R(rt.String("Helm of Obedience")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Int==0?144:86;continue;}
case 86:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=89;continue;}
case 89:{f.StackOp("dup");f.Pc=90;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",94);}
case 94:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",97);}
case 97:{f.Locals[6]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[6]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String(" - To avoid an infinite loop, this repeat has been broken ")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",106);}
case 106:{f.StackOp("pop");f.Pc=107;continue;}
case 107:{f.Push(f.Locals[6]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String(" and the game will now continue in the current state, ending the loop early. ")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Push(f.Locals[6]);f.Pc=117;continue;}
case 117:{f.Push(JValue.R(rt.String("Once Draws are available this probably should change to a Draw.")));f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",122);}
case 122:{f.StackOp("pop");f.Pc=123;continue;}
case 123:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=126;continue;}
case 126:{f.Push(f.Locals[6]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",131);}
case 131:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",134);}
case 134:{f.Pc=144;continue;}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/ability/effects/RepeatEffect","checkRepeatConditions","(Lforge/game/spellability/SpellAbility;)Z","invokestatic",141);}
case 141:{f.Pc=f.Pop().Int!=0?52:144;continue;}
case 144:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3641(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?19:17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("RepeatPresent")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?139:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("RepeatPresent")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("RepeatCompare")));f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("GE1")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",43);}
case 43:{f.Locals[4]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("RepeatDefined")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?73:54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",58);}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("RepeatDefined")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",64);}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",68);}
case 68:{f.Locals[5]=f.Pop();f.Pc=70;continue;}
case 70:{f.Pc=82;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",80);}
case 80:{f.Locals[5]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",90);}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",94);}
case 94:{f.Locals[5]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[4]);f.Pc=98;continue;}
case 98:{f.Push(JValue.I(2));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",102);}
case 102:{f.Locals[6]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",108);}
case 108:{f.Push(f.Locals[6]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",114);}
case 114:{f.Locals[7]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[5]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",123);}
case 123:{f.Locals[8]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[8]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[4]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[7]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",134);}
case 134:{f.Pc=f.Pop().Int!=0?139:137;continue;}
case 137:{f.Push(JValue.I(0));f.Pc=138;continue;}
case 138:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.String("RepeatCheckSVar")));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",145);}
case 145:{f.Pc=f.Pop().Int==0?229:148;continue;}
case 148:{f.Push(JValue.R(rt.String("GE")));f.Pc=150;continue;}
case 150:{f.Locals[3]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("1")));f.Pc=153;continue;}
case 153:{f.Locals[4]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String("RepeatSVarCompare")));f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",161);}
case 161:{f.Pc=f.Pop().Int==0?188:164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("RepeatSVarCompare")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",170);}
case 170:{f.Push(JValue.I(0));f.Pc=171;continue;}
case 171:{f.Push(JValue.I(2));f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",175);}
case 175:{f.Locals[3]=f.Pop();f.Pc=176;continue;}
case 176:{f.Push(f.Locals[0]);f.Pc=177;continue;}
case 177:{f.Push(JValue.R(rt.String("RepeatSVarCompare")));f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",182);}
case 182:{f.Push(JValue.I(2));f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",186);}
case 186:{f.Locals[4]=f.Pop();f.Pc=188;continue;}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",192);}
case 192:{f.Push(f.Locals[0]);f.Pc=193;continue;}
case 193:{f.Push(JValue.R(rt.String("RepeatCheckSVar")));f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",198);}
case 198:{f.Push(f.Locals[0]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",202);}
case 202:{f.Locals[5]=f.Pop();f.Pc=204;continue;}
case 204:{f.Push(f.Locals[0]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",208);}
case 208:{f.Push(f.Locals[4]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[0]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",214);}
case 214:{f.Locals[6]=f.Pop();f.Pc=216;continue;}
case 216:{f.Push(f.Locals[5]);f.Pc=218;continue;}
case 218:{f.Push(f.Locals[3]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[6]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",224);}
case 224:{f.Pc=f.Pop().Int!=0?229:227;continue;}
case 227:{f.Push(JValue.I(0));f.Pc=228;continue;}
case 228:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 229:{f.Push(f.Locals[0]);f.Pc=230;continue;}
case 230:{f.Push(JValue.R(rt.String("RepeatOptional")));f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",235);}
case 235:{f.Pc=f.Pop().Int==0?296:238;continue;}
case 238:{f.Push(f.Locals[0]);f.Pc=239;continue;}
case 239:{f.Push(JValue.R(rt.String("RepeatOptionalDecider")));f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",244);}
case 244:{f.Pc=f.Pop().Int==0?271:247;continue;}
case 247:{f.Push(f.Locals[0]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",251);}
case 251:{f.Push(f.Locals[0]);f.Pc=252;continue;}
case 252:{f.Push(JValue.R(rt.String("RepeatOptionalDecider")));f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",257);}
case 257:{f.Push(f.Locals[0]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",261);}
case 261:{f.Push(JValue.I(0));f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",265);}
case 265:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=268;continue;}
case 268:{f.Pc=272;continue;}
case 271:{f.Push(f.Locals[1]);f.Pc=272;continue;}
case 272:{f.Locals[3]=f.Pop();f.Pc=273;continue;}
case 273:{f.Push(f.Locals[3]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",277);}
case 277:{f.Push(f.Locals[0]);f.Pc=278;continue;}
case 278:{f.Push(JValue.R(null));f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",282);}
case 282:{f.Push(JValue.R(rt.String("lblDoYouWantRepeatProcessAgain")));f.Pc=284;continue;}
case 284:{f.Push(JValue.I(0));f.Pc=285;continue;}
case 285:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",291);}
case 291:{f.Push(JValue.R(null));f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",295);}
case 295:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 296:{f.Push(JValue.I(1));f.Pc=297;continue;}
case 297:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
