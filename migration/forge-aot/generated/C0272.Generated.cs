// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C272{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/CountersRemoveEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3279,"forge/game/ability/effects/CountersRemoveEffect","<init>","()V",1,1,1,new JHandler[]{},M3279));
c.Add(new JMethod(3280,"forge/game/ability/effects/CountersRemoveEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,3,new JHandler[]{},M3280));
c.Add(new JMethod(3281,"forge/game/ability/effects/CountersRemoveEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,20,8,new JHandler[]{new JHandler(96,103,106,"java/lang/Exception")},M3281));
c.Add(new JMethod(3282,"forge/game/ability/effects/CountersRemoveEffect","removeAnyType","(Lforge/game/GameEntity;ILforge/game/spellability/SpellAbility;)I",4,20,6,new JHandler[]{},M3282));
c.Add(new JMethod(3283,"forge/game/ability/effects/CountersRemoveEffect","lambda$resolve$0","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M3283));
}

internal static JStep M3279(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3280(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("1")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{f.Locals[5]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("All")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int!=0?60:38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("Any")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int!=0?60:48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",52);}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",58);}
case 58:{f.Locals[5]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Remove ")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("UpTo")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int==0?83:76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("up to ")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("All")));f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int==0?102:92;continue;}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("all counter")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",98);}
case 98:{f.StackOp("pop");f.Pc=99;continue;}
case 99:{f.Pc=176;continue;}
case 102:{f.Push(JValue.R(rt.String("Any")));f.Pc=104;continue;}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int==0?147:111;continue;}
case 111:{f.Push(f.Locals[5]);f.Pc=113;continue;}
case 113:{f.Push(JValue.I(1));f.Pc=114;continue;}
case 114:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?127:117;continue;}
case 117:{f.Push(f.Locals[2]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("a counter")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",123);}
case 123:{f.StackOp("pop");f.Pc=124;continue;}
case 124:{f.Pc=176;continue;}
case 127:{f.Push(f.Locals[2]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[5]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",133);}
case 133:{f.Push(JValue.R(rt.String(" ")));f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",138);}
case 138:{f.Push(JValue.R(rt.String(" counter")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",143);}
case 143:{f.StackOp("pop");f.Pc=144;continue;}
case 144:{f.Pc=176;continue;}
case 147:{f.Push(f.Locals[2]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[5]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",153);}
case 153:{f.Push(JValue.R(rt.String(" ")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",158);}
case 158:{f.Push(f.Locals[3]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",162);}
case 162:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",167);}
case 167:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",170);}
case 170:{f.Push(JValue.R(rt.String(" counter")));f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",175);}
case 175:{f.StackOp("pop");f.Pc=176;continue;}
case 176:{f.Push(f.Locals[5]);f.Pc=178;continue;}
case 178:{f.Push(JValue.I(1));f.Pc=179;continue;}
case 179:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?189:182;continue;}
case 182:{f.Push(f.Locals[2]);f.Pc=183;continue;}
case 183:{f.Push(JValue.R(rt.String("s")));f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",188);}
case 188:{f.StackOp("pop");f.Pc=189;continue;}
case 189:{f.Push(f.Locals[2]);f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.String(" from ")));f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",195);}
case 195:{f.StackOp("pop");f.Pc=196;continue;}
case 196:{f.Push(f.Locals[2]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[1]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/ability/effects/CountersRemoveEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",201);}
case 201:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",204);}
case 204:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",207);}
case 207:{f.StackOp("pop");f.Pc=208;continue;}
case 208:{f.Push(f.Locals[2]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[1]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/ability/effects/CountersRemoveEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",213);}
case 213:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",216);}
case 216:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",219);}
case 219:{f.StackOp("pop");f.Pc=220;continue;}
case 220:{f.Push(f.Locals[2]);f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String(".")));f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",226);}
case 226:{f.StackOp("pop");f.Pc=227;continue;}
case 227:{f.Push(f.Locals[2]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",231);}
case 231:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3281(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",21);}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",29);}
case 29:{f.Locals[6]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("1")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",39);}
case 39:{f.Locals[7]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{f.Locals[8]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[7]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("All")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int!=0?73:54;continue;}
case 54:{f.Push(f.Locals[7]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("Any")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?73:64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[7]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",71);}
case 71:{f.Locals[8]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(JValue.R(null));f.Pc=74;continue;}
case 74:{f.Locals[9]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[6]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("Any")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Int!=0?117:86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("All")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int!=0?117:96;continue;}
case 96:{f.Push(f.Locals[6]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",101);}
case 101:{f.Locals[9]=f.Pop();f.Pc=103;continue;}
case 103:{f.Pc=117;continue;}
case 106:{f.Locals[10]=f.Pop();f.Pc=108;continue;}
case 108:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String("Counter type doesn't match, nor does an SVar exist with the type name.")));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",116);}
case 116:{return JStep.ReturnVoid;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("RememberRemoved")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",123);}
case 123:{f.Locals[10]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("RememberAmount")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",131);}
case 131:{f.Locals[11]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(JValue.I(0));f.Pc=134;continue;}
case 134:{f.Locals[12]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String("Choices")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",142);}
case 142:{f.Pc=f.Pop().Int==0?195:145;continue;}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",151);}
case 151:{f.Pc=f.Pop().Int==0?166:154;continue;}
case 154:{f.Push(f.Locals[1]);f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",160);}
case 160:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",163);}
case 163:{f.Pc=169;continue;}
case 166:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=169;continue;}
case 169:{f.Locals[14]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[3]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[14]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",177);}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("Choices")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",183);}
case 183:{f.Push(f.Locals[4]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[2]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[1]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",190);}
case 190:{f.Locals[13]=f.Pop();f.Pc=192;continue;}
case 192:{f.Pc=201;continue;}
case 195:{f.Push(f.Locals[1]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/ability/effects/CountersRemoveEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",199);}
case 199:{f.Locals[13]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[1]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",205);}
case 205:{f.Pc=f.Pop().Int==0?241:208;continue;}
case 208:{f.Push(f.Locals[1]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacementEffect","()Lforge/game/replacement/ReplacementEffect;","invokevirtual",212);}
case 212:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getMode","()Lforge/game/replacement/ReplacementType;","invokevirtual",215);}
case 215:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"));f.Pc=218;continue;}
case 218:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?241:221;continue;}
case 221:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=224;continue;}
case 224:{f.StackOp("dup");f.Pc=225;continue;}
case 225:{f.Push(f.Locals[13]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",230);}
case 230:{f.Push(f.Locals[1]);f.Pc=231;continue;}
case 231:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersRemoveEffect:3281:231:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;",236);}
case 236:{return rt.Call(f,"forge/game/card/CardCollection","filter","(Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokevirtual",239);}
case 239:{f.Locals[13]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[1]);f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.String("Optional")));f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",247);}
case 247:{f.Pc=f.Pop().Int==0?371:250;continue;}
case 250:{f.Push(f.Locals[8]);f.Pc=252;continue;}
case 252:{f.Push(JValue.I(1));f.Pc=253;continue;}
case 253:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?271:256;continue;}
case 256:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",259);}
case 259:{f.Push(JValue.R(rt.String("lblCounters")));f.Pc=261;continue;}
case 261:{f.Push(JValue.I(0));f.Pc=262;continue;}
case 262:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",268);}
case 268:{f.Pc=308;continue;}
case 271:{f.Push(f.Locals[7]);f.Pc=273;continue;}
case 273:{f.Push(JValue.R(rt.String("All")));f.Pc=275;continue;}
case 275:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",278);}
case 278:{f.Pc=f.Pop().Int==0?296:281;continue;}
case 281:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",284);}
case 284:{f.Push(JValue.R(rt.String("lblAllCounters")));f.Pc=286;continue;}
case 286:{f.Push(JValue.I(0));f.Pc=287;continue;}
case 287:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",293);}
case 293:{f.Pc=308;continue;}
case 296:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",299);}
case 299:{f.Push(JValue.R(rt.String("lblACounters")));f.Pc=301;continue;}
case 301:{f.Push(JValue.I(0));f.Pc=302;continue;}
case 302:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",308);}
case 308:{f.Locals[14]=f.Pop();f.Pc=310;continue;}
case 310:{f.Push(f.Locals[13]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",317);}
case 317:{f.Push(JValue.I(1));f.Pc=318;continue;}
case 318:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?335:321;continue;}
case 321:{f.Push(f.Locals[13]);f.Pc=323;continue;}
case 323:{f.Push(JValue.I(0));f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",329);}
case 329:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=332;continue;}
case 332:{f.Pc=336;continue;}
case 335:{f.Push(JValue.R(null));f.Pc=336;continue;}
case 336:{f.Locals[15]=f.Pop();f.Pc=338;continue;}
case 338:{f.Push(f.Locals[5]);f.Pc=340;continue;}
case 340:{f.Push(f.Locals[1]);f.Pc=341;continue;}
case 341:{f.Push(JValue.R(null));f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",345);}
case 345:{f.Push(JValue.R(rt.String("lblRemove")));f.Pc=347;continue;}
case 347:{f.Push(JValue.I(0));f.Pc=348;continue;}
case 348:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",354);}
case 354:{f.Push(f.Locals[14]);f.Pc=356;continue;}
case 356:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersRemoveEffect:3281:356:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",361);}
case 361:{f.Push(f.Locals[15]);f.Pc=363;continue;}
case 363:{f.Push(JValue.R(null));f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",367);}
case 367:{f.Pc=f.Pop().Int!=0?371:370;continue;}
case 370:{return JStep.ReturnVoid;}
case 371:{f.Push(f.Locals[1]);f.Pc=372;continue;}
case 372:{f.Push(JValue.R(rt.String("Choices")));f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",377);}
case 377:{f.Pc=f.Pop().Int==0?542:380;continue;}
case 380:{f.Push(JValue.I(1));f.Pc=381;continue;}
case 381:{f.Locals[14]=f.Pop();f.Pc=383;continue;}
case 383:{f.Push(JValue.I(1));f.Pc=384;continue;}
case 384:{f.Locals[15]=f.Pop();f.Pc=386;continue;}
case 386:{f.Push(f.Locals[1]);f.Pc=387;continue;}
case 387:{f.Push(JValue.R(rt.String("ChoiceOptional")));f.Pc=389;continue;}
case 389:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",392);}
case 392:{f.Pc=f.Pop().Int==0?407:395;continue;}
case 395:{f.Push(JValue.I(0));f.Pc=396;continue;}
case 396:{f.Locals[14]=f.Pop();f.Pc=398;continue;}
case 398:{f.Push(f.Locals[13]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",405);}
case 405:{f.Locals[15]=f.Pop();f.Pc=407;continue;}
case 407:{f.Push(f.Locals[1]);f.Pc=408;continue;}
case 408:{f.Push(JValue.R(rt.String("ChoiceNum")));f.Pc=410;continue;}
case 410:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",413);}
case 413:{f.Pc=f.Pop().Int==0?432:416;continue;}
case 416:{f.Push(f.Locals[2]);f.Pc=417;continue;}
case 417:{f.Push(f.Locals[1]);f.Pc=418;continue;}
case 418:{f.Push(JValue.R(rt.String("ChoiceNum")));f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",423);}
case 423:{f.Push(f.Locals[1]);f.Pc=424;continue;}
case 424:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",427);}
case 427:{f.StackOp("dup");f.Pc=428;continue;}
case 428:{f.Locals[15]=f.Pop();f.Pc=430;continue;}
case 430:{f.Locals[14]=f.Pop();f.Pc=432;continue;}
case 432:{f.Push(f.Locals[13]);f.Pc=434;continue;}
case 434:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",439);}
case 439:{f.Push(f.Locals[14]);f.Pc=441;continue;}
case 441:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?445:444;continue;}
case 444:{return JStep.ReturnVoid;}
case 445:{f.Push(f.Locals[9]);f.Pc=447;continue;}
case 447:{f.Pc=f.Pop().Reference!=null?455:450;continue;}
case 450:{f.Push(JValue.R(rt.String("")));f.Pc=452;continue;}
case 452:{f.Pc=462;continue;}
case 455:{f.Push(f.Locals[9]);f.Pc=457;continue;}
case 457:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",462);}
case 462:{f.Locals[16]=f.Pop();f.Pc=464;continue;}
case 464:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",467);}
case 467:{f.Push(JValue.R(rt.String("lblChooseCardsToTakeTargetCounters")));f.Pc=469;continue;}
case 469:{f.Push(JValue.I(1));f.Pc=470;continue;}
case 470:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=473;continue;}
case 473:{f.StackOp("dup");f.Pc=474;continue;}
case 474:{f.Push(JValue.I(0));f.Pc=475;continue;}
case 475:{f.Push(f.Locals[16]);f.Pc=477;continue;}
case 477:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=478;continue;}
case 478:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",481);}
case 481:{f.Locals[17]=f.Pop();f.Pc=483;continue;}
case 483:{f.Push(f.Locals[17]);f.Pc=485;continue;}
case 485:{f.Push(JValue.R(rt.String("  ")));f.Pc=487;continue;}
case 487:{f.Push(JValue.R(rt.String(" ")));f.Pc=489;continue;}
case 489:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",492);}
case 492:{f.Locals[17]=f.Pop();f.Pc=494;continue;}
case 494:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",497);}
case 497:{f.Locals[18]=f.Pop();f.Pc=499;continue;}
case 499:{f.Push(f.Locals[18]);f.Pc=501;continue;}
case 501:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=503;continue;}
case 503:{f.Push(f.Locals[9]);f.Pc=505;continue;}
case 505:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",510);}
case 510:{f.StackOp("pop");f.Pc=511;continue;}
case 511:{f.Push(f.Locals[5]);f.Pc=513;continue;}
case 513:{f.Push(f.Locals[13]);f.Pc=515;continue;}
case 515:{f.Push(f.Locals[1]);f.Pc=516;continue;}
case 516:{f.Push(f.Locals[17]);f.Pc=518;continue;}
case 518:{f.Push(f.Locals[14]);f.Pc=520;continue;}
case 520:{f.Push(f.Locals[15]);f.Pc=522;continue;}
case 522:{f.Push(f.Locals[14]);f.Pc=524;continue;}
case 524:{f.Pc=f.Pop().Int!=0?531:527;continue;}
case 527:{f.Push(JValue.I(1));f.Pc=528;continue;}
case 528:{f.Pc=532;continue;}
case 531:{f.Push(JValue.I(0));f.Pc=532;continue;}
case 532:{f.Push(f.Locals[18]);f.Pc=534;continue;}
case 534:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",537);}
case 537:{f.Locals[13]=f.Pop();f.Pc=539;continue;}
case 539:{f.Pc=734;continue;}
case 542:{f.Push(f.Locals[1]);f.Pc=543;continue;}
case 543:{return rt.Call(f,"forge/game/ability/effects/CountersRemoveEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",546);}
case 546:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",549);}
case 549:{f.Locals[14]=f.Pop();f.Pc=551;continue;}
case 551:{f.Push(f.Locals[14]);f.Pc=553;continue;}
case 553:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",558);}
case 558:{f.Pc=f.Pop().Int==0?734:561;continue;}
case 561:{f.Push(f.Locals[14]);f.Pc=563;continue;}
case 563:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",568);}
case 568:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=571;continue;}
case 571:{f.Locals[15]=f.Pop();f.Pc=573;continue;}
case 573:{f.Push(f.Locals[15]);f.Pc=575;continue;}
case 575:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",578);}
case 578:{f.Pc=f.Pop().Int!=0?584:581;continue;}
case 581:{f.Pc=551;continue;}
case 584:{f.Push(f.Locals[6]);f.Pc=586;continue;}
case 586:{f.Push(JValue.R(rt.String("All")));f.Pc=588;continue;}
case 588:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",591);}
case 591:{f.Pc=f.Pop().Int==0?669:594;continue;}
case 594:{f.Push(f.Locals[15]);f.Pc=596;continue;}
case 596:{return rt.Call(f,"forge/game/player/Player","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",599);}
case 599:{return rt.Call(f,"com/google/common/collect/Multiset","entrySet","()Ljava/util/Set;","invokeinterface",604);}
case 604:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",607);}
case 607:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",610);}
case 610:{f.Locals[16]=f.Pop();f.Pc=612;continue;}
case 612:{f.Push(f.Locals[16]);f.Pc=614;continue;}
case 614:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",619);}
case 619:{f.Pc=f.Pop().Int==0?666:622;continue;}
case 622:{f.Push(f.Locals[16]);f.Pc=624;continue;}
case 624:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",629);}
case 629:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=632;continue;}
case 632:{f.Locals[17]=f.Pop();f.Pc=634;continue;}
case 634:{f.Push(f.Locals[12]);f.Pc=636;continue;}
case 636:{f.Push(f.Locals[15]);f.Pc=638;continue;}
case 638:{f.Push(f.Locals[17]);f.Pc=640;continue;}
case 640:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",645);}
case 645:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=648;continue;}
case 648:{f.Push(f.Locals[17]);f.Pc=650;continue;}
case 650:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",655);}
case 655:{f.Push(f.Locals[4]);f.Pc=657;continue;}
case 657:{return rt.Call(f,"forge/game/player/Player","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",660);}
case 660:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=661;continue;}
case 661:{f.Locals[12]=f.Pop();f.Pc=663;continue;}
case 663:{f.Pc=612;continue;}
case 666:{f.Pc=731;continue;}
case 669:{f.Push(f.Locals[7]);f.Pc=671;continue;}
case 671:{f.Push(JValue.R(rt.String("All")));f.Pc=673;continue;}
case 673:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",676);}
case 676:{f.Pc=f.Pop().Int==0?688:679;continue;}
case 679:{f.Push(f.Locals[15]);f.Pc=681;continue;}
case 681:{f.Push(f.Locals[9]);f.Pc=683;continue;}
case 683:{return rt.Call(f,"forge/game/player/Player","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",686);}
case 686:{f.Locals[8]=f.Pop();f.Pc=688;continue;}
case 688:{f.Push(f.Locals[6]);f.Pc=690;continue;}
case 690:{f.Push(JValue.R(rt.String("Any")));f.Pc=692;continue;}
case 692:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",695);}
case 695:{f.Pc=f.Pop().Int==0?715:698;continue;}
case 698:{f.Push(f.Locals[12]);f.Pc=700;continue;}
case 700:{f.Push(f.Locals[0]);f.Pc=701;continue;}
case 701:{f.Push(f.Locals[15]);f.Pc=703;continue;}
case 703:{f.Push(f.Locals[8]);f.Pc=705;continue;}
case 705:{f.Push(f.Locals[1]);f.Pc=706;continue;}
case 706:{return rt.Call(f,"forge/game/ability/effects/CountersRemoveEffect","removeAnyType","(Lforge/game/GameEntity;ILforge/game/spellability/SpellAbility;)I","invokevirtual",709);}
case 709:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=710;continue;}
case 710:{f.Locals[12]=f.Pop();f.Pc=712;continue;}
case 712:{f.Pc=731;continue;}
case 715:{f.Push(f.Locals[12]);f.Pc=717;continue;}
case 717:{f.Push(f.Locals[15]);f.Pc=719;continue;}
case 719:{f.Push(f.Locals[9]);f.Pc=721;continue;}
case 721:{f.Push(f.Locals[8]);f.Pc=723;continue;}
case 723:{f.Push(f.Locals[4]);f.Pc=725;continue;}
case 725:{return rt.Call(f,"forge/game/player/Player","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",728);}
case 728:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=729;continue;}
case 729:{f.Locals[12]=f.Pop();f.Pc=731;continue;}
case 731:{f.Pc=551;continue;}
case 734:{f.Push(f.Locals[13]);f.Pc=736;continue;}
case 736:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",741);}
case 741:{f.Locals[14]=f.Pop();f.Pc=743;continue;}
case 743:{f.Push(f.Locals[14]);f.Pc=745;continue;}
case 745:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",750);}
case 750:{f.Pc=f.Pop().Int==0?1177:753;continue;}
case 753:{f.Push(f.Locals[14]);f.Pc=755;continue;}
case 755:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",760);}
case 760:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=763;continue;}
case 763:{f.Locals[15]=f.Pop();f.Pc=765;continue;}
case 765:{f.Push(f.Locals[3]);f.Pc=766;continue;}
case 766:{f.Push(f.Locals[15]);f.Pc=768;continue;}
case 768:{f.Push(JValue.R(null));f.Pc=769;continue;}
case 769:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",772);}
case 772:{f.Locals[16]=f.Pop();f.Pc=774;continue;}
case 774:{f.Push(f.Locals[16]);f.Pc=776;continue;}
case 776:{f.Pc=f.Pop().Reference==null?743:779;continue;}
case 779:{f.Push(f.Locals[15]);f.Pc=781;continue;}
case 781:{f.Push(f.Locals[16]);f.Pc=783;continue;}
case 783:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",786);}
case 786:{f.Pc=f.Pop().Int!=0?792:789;continue;}
case 789:{f.Pc=743;continue;}
case 792:{f.Push(f.Locals[3]);f.Pc=793;continue;}
case 793:{f.Push(f.Locals[16]);f.Pc=795;continue;}
case 795:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",798);}
case 798:{f.Locals[17]=f.Pop();f.Pc=800;continue;}
case 800:{f.Push(f.Locals[6]);f.Pc=802;continue;}
case 802:{f.Push(JValue.R(rt.String("All")));f.Pc=804;continue;}
case 804:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",807);}
case 807:{f.Pc=f.Pop().Int==0?891:810;continue;}
case 810:{f.Push(f.Locals[16]);f.Pc=812;continue;}
case 812:{return rt.Call(f,"forge/game/card/Card","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",815);}
case 815:{return rt.Call(f,"com/google/common/collect/Multiset","entrySet","()Ljava/util/Set;","invokeinterface",820);}
case 820:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",823);}
case 823:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",826);}
case 826:{f.Locals[18]=f.Pop();f.Pc=828;continue;}
case 828:{f.Push(f.Locals[18]);f.Pc=830;continue;}
case 830:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",835);}
case 835:{f.Pc=f.Pop().Int==0?882:838;continue;}
case 838:{f.Push(f.Locals[18]);f.Pc=840;continue;}
case 840:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",845);}
case 845:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=848;continue;}
case 848:{f.Locals[19]=f.Pop();f.Pc=850;continue;}
case 850:{f.Push(f.Locals[12]);f.Pc=852;continue;}
case 852:{f.Push(f.Locals[16]);f.Pc=854;continue;}
case 854:{f.Push(f.Locals[19]);f.Pc=856;continue;}
case 856:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",861);}
case 861:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=864;continue;}
case 864:{f.Push(f.Locals[19]);f.Pc=866;continue;}
case 866:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",871);}
case 871:{f.Push(f.Locals[4]);f.Pc=873;continue;}
case 873:{return rt.Call(f,"forge/game/card/Card","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",876);}
case 876:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=877;continue;}
case 877:{f.Locals[12]=f.Pop();f.Pc=879;continue;}
case 879:{f.Pc=828;continue;}
case 882:{f.Push(f.Locals[3]);f.Pc=883;continue;}
case 883:{f.Push(f.Locals[16]);f.Pc=885;continue;}
case 885:{return rt.Call(f,"forge/game/Game","updateLastStateForCard","(Lforge/game/card/Card;)V","invokevirtual",888);}
case 888:{f.Pc=1174;continue;}
case 891:{f.Push(f.Locals[6]);f.Pc=893;continue;}
case 893:{f.Push(JValue.R(rt.String("Any")));f.Pc=895;continue;}
case 895:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",898);}
case 898:{f.Pc=f.Pop().Int==0?918:901;continue;}
case 901:{f.Push(f.Locals[12]);f.Pc=903;continue;}
case 903:{f.Push(f.Locals[0]);f.Pc=904;continue;}
case 904:{f.Push(f.Locals[16]);f.Pc=906;continue;}
case 906:{f.Push(f.Locals[8]);f.Pc=908;continue;}
case 908:{f.Push(f.Locals[1]);f.Pc=909;continue;}
case 909:{return rt.Call(f,"forge/game/ability/effects/CountersRemoveEffect","removeAnyType","(Lforge/game/GameEntity;ILforge/game/spellability/SpellAbility;)I","invokevirtual",912);}
case 912:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=913;continue;}
case 913:{f.Locals[12]=f.Pop();f.Pc=915;continue;}
case 915:{f.Pc=1174;continue;}
case 918:{f.Push(f.Locals[16]);f.Pc=920;continue;}
case 920:{f.Push(f.Locals[9]);f.Pc=922;continue;}
case 922:{return rt.Call(f,"forge/game/card/Card","canRemoveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",925);}
case 925:{f.Pc=f.Pop().Int!=0?931:928;continue;}
case 928:{f.Pc=743;continue;}
case 931:{f.Push(f.Locals[8]);f.Pc=933;continue;}
case 933:{f.Locals[18]=f.Pop();f.Pc=935;continue;}
case 935:{f.Push(f.Locals[7]);f.Pc=937;continue;}
case 937:{f.Push(JValue.R(rt.String("All")));f.Pc=939;continue;}
case 939:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",942);}
case 942:{f.Pc=f.Pop().Int!=0?955:945;continue;}
case 945:{f.Push(f.Locals[7]);f.Pc=947;continue;}
case 947:{f.Push(JValue.R(rt.String("Any")));f.Pc=949;continue;}
case 949:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",952);}
case 952:{f.Pc=f.Pop().Int==0?967:955;continue;}
case 955:{f.Push(f.Locals[16]);f.Pc=957;continue;}
case 957:{f.Push(f.Locals[9]);f.Pc=959;continue;}
case 959:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",962);}
case 962:{f.Locals[18]=f.Pop();f.Pc=964;continue;}
case 964:{f.Pc=1007;continue;}
case 967:{f.Push(f.Locals[1]);f.Pc=968;continue;}
case 968:{f.Push(JValue.R(rt.String("CounterNumShared")));f.Pc=971;continue;}
case 971:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",974);}
case 974:{f.Pc=f.Pop().Int==0?993:977;continue;}
case 977:{f.Push(f.Locals[18]);f.Pc=979;continue;}
case 979:{f.Push(f.Locals[12]);f.Pc=981;continue;}
case 981:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=982;continue;}
case 982:{f.Locals[18]=f.Pop();f.Pc=984;continue;}
case 984:{f.Push(f.Locals[18]);f.Pc=986;continue;}
case 986:{f.Push(JValue.I(1));f.Pc=987;continue;}
case 987:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?993:990;continue;}
case 990:{f.Pc=1177;continue;}
case 993:{f.Push(f.Locals[18]);f.Pc=995;continue;}
case 995:{f.Push(f.Locals[16]);f.Pc=997;continue;}
case 997:{f.Push(f.Locals[9]);f.Pc=999;continue;}
case 999:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",1002);}
case 1002:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",1005);}
case 1005:{f.Locals[18]=f.Pop();f.Pc=1007;continue;}
case 1007:{f.Push(f.Locals[17]);f.Pc=1009;continue;}
case 1009:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1012;continue;}
case 1012:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",1015);}
case 1015:{f.Pc=f.Pop().Int!=0?1029:1018;continue;}
case 1018:{f.Push(f.Locals[17]);f.Pc=1020;continue;}
case 1020:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=1023;continue;}
case 1023:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",1026);}
case 1026:{f.Pc=f.Pop().Int==0?1109:1029;continue;}
case 1029:{f.Push(f.Locals[1]);f.Pc=1030;continue;}
case 1030:{f.Push(JValue.R(rt.String("UpTo")));f.Pc=1032;continue;}
case 1032:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1035);}
case 1035:{f.Pc=f.Pop().Int!=0?1048:1038;continue;}
case 1038:{f.Push(f.Locals[7]);f.Pc=1040;continue;}
case 1040:{f.Push(JValue.R(rt.String("Any")));f.Pc=1042;continue;}
case 1042:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1045);}
case 1045:{f.Pc=f.Pop().Int==0?1109:1048;continue;}
case 1048:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",1051);}
case 1051:{f.Locals[19]=f.Pop();f.Pc=1053;continue;}
case 1053:{f.Push(f.Locals[19]);f.Pc=1055;continue;}
case 1055:{f.Push(JValue.R(rt.String("Target")));f.Pc=1058;continue;}
case 1058:{f.Push(f.Locals[16]);f.Pc=1060;continue;}
case 1060:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1065);}
case 1065:{f.StackOp("pop");f.Pc=1066;continue;}
case 1066:{f.Push(f.Locals[19]);f.Pc=1068;continue;}
case 1068:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=1070;continue;}
case 1070:{f.Push(f.Locals[9]);f.Pc=1072;continue;}
case 1072:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1077);}
case 1077:{f.StackOp("pop");f.Pc=1078;continue;}
case 1078:{f.Push(f.Locals[5]);f.Pc=1080;continue;}
case 1080:{f.Push(f.Locals[1]);f.Pc=1081;continue;}
case 1081:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1084);}
case 1084:{f.Push(JValue.R(rt.String("lblSelectRemoveCountersNumberOfTarget")));f.Pc=1087;continue;}
case 1087:{f.Push(JValue.I(1));f.Pc=1088;continue;}
case 1088:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1091;continue;}
case 1091:{f.StackOp("dup");f.Pc=1092;continue;}
case 1092:{f.Push(JValue.I(0));f.Pc=1093;continue;}
case 1093:{f.Push(f.Locals[6]);f.Pc=1095;continue;}
case 1095:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1096;continue;}
case 1096:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1099);}
case 1099:{f.Push(JValue.I(0));f.Pc=1100;continue;}
case 1100:{f.Push(f.Locals[18]);f.Pc=1102;continue;}
case 1102:{f.Push(f.Locals[19]);f.Pc=1104;continue;}
case 1104:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;IILjava/util/Map;)I","invokevirtual",1107);}
case 1107:{f.Locals[18]=f.Pop();f.Pc=1109;continue;}
case 1109:{f.Push(f.Locals[18]);f.Pc=1111;continue;}
case 1111:{f.Pc=f.Pop().Int<=0?1174:1114;continue;}
case 1114:{f.Push(f.Locals[16]);f.Pc=1116;continue;}
case 1116:{f.Push(f.Locals[9]);f.Pc=1118;continue;}
case 1118:{f.Push(f.Locals[18]);f.Pc=1120;continue;}
case 1120:{f.Push(f.Locals[4]);f.Pc=1122;continue;}
case 1122:{return rt.Call(f,"forge/game/card/Card","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",1125);}
case 1125:{f.StackOp("pop");f.Pc=1126;continue;}
case 1126:{f.Push(f.Locals[10]);f.Pc=1128;continue;}
case 1128:{f.Pc=f.Pop().Int==0?1161:1131;continue;}
case 1131:{f.Push(JValue.I(0));f.Pc=1132;continue;}
case 1132:{f.Locals[19]=f.Pop();f.Pc=1134;continue;}
case 1134:{f.Push(f.Locals[19]);f.Pc=1136;continue;}
case 1136:{f.Push(f.Locals[18]);f.Pc=1138;continue;}
case 1138:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1161:1141;continue;}
case 1141:{f.Push(f.Locals[2]);f.Pc=1142;continue;}
case 1142:{f.Push(f.Locals[9]);f.Pc=1144;continue;}
case 1144:{f.Push(f.Locals[19]);f.Pc=1146;continue;}
case 1146:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1149);}
case 1149:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",1152);}
case 1152:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1155);}
case 1155:{f.Locals[19]=JValue.I(unchecked(f.Locals[19].Int+(1)));f.Pc=1158;continue;}
case 1158:{f.Pc=1134;continue;}
case 1161:{f.Push(f.Locals[3]);f.Pc=1162;continue;}
case 1162:{f.Push(f.Locals[16]);f.Pc=1164;continue;}
case 1164:{return rt.Call(f,"forge/game/Game","updateLastStateForCard","(Lforge/game/card/Card;)V","invokevirtual",1167);}
case 1167:{f.Push(f.Locals[12]);f.Pc=1169;continue;}
case 1169:{f.Push(f.Locals[18]);f.Pc=1171;continue;}
case 1171:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1172;continue;}
case 1172:{f.Locals[12]=f.Pop();f.Pc=1174;continue;}
case 1174:{f.Pc=743;continue;}
case 1177:{f.Push(f.Locals[12]);f.Pc=1179;continue;}
case 1179:{f.Pc=f.Pop().Int<=0?1196:1182;continue;}
case 1182:{f.Push(f.Locals[11]);f.Pc=1184;continue;}
case 1184:{f.Pc=f.Pop().Int==0?1196:1187;continue;}
case 1187:{f.Push(f.Locals[2]);f.Pc=1188;continue;}
case 1188:{f.Push(f.Locals[12]);f.Pc=1190;continue;}
case 1190:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1193);}
case 1193:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1196);}
case 1196:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3282(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("RememberRemoved")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[5]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("UpTo")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",17);}
case 17:{f.Locals[6]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Any")));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?40:33;continue;}
case 33:{f.Push(JValue.I(2147483647));f.Pc=36;continue;}
case 36:{f.Locals[2]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",44);}
case 44:{f.Locals[7]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[7]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",51);}
case 51:{f.Locals[8]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",57);}
case 57:{f.Locals[9]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[9]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",64);}
case 64:{f.Locals[10]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/GameEntity","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",70);}
case 70:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","(Ljava/lang/Iterable;)Lcom/google/common/collect/HashMultiset;","invokestatic",73);}
case 73:{f.Locals[11]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[11]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"com/google/common/collect/Multiset","elementSet","()Ljava/util/Set;","invokeinterface",82);}
case 82:{return rt.Call(f,"com/google/common/collect/ImmutableList","copyOf","(Ljava/util/Collection;)Lcom/google/common/collect/ImmutableList;","invokestatic",85);}
case 85:{return rt.Call(f,"com/google/common/collect/ImmutableList","iterator","()Lcom/google/common/collect/UnmodifiableIterator;","invokevirtual",88);}
case 88:{f.Locals[12]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[12]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",97);}
case 97:{f.Pc=f.Pop().Int==0?134:100;continue;}
case 100:{f.Push(f.Locals[12]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",107);}
case 107:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=110;continue;}
case 110:{f.Locals[13]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[13]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/GameEntity","canRemoveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int!=0?131:121;continue;}
case 121:{f.Push(f.Locals[11]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[13]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"com/google/common/collect/Multiset","remove","(Ljava/lang/Object;)Z","invokeinterface",130);}
case 130:{f.StackOp("pop");f.Pc=131;continue;}
case 131:{f.Pc=90;continue;}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{f.Pc=f.Pop().Int<=0?424:138;continue;}
case 138:{f.Push(f.Locals[11]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"com/google/common/collect/Multiset","isEmpty","()Z","invokeinterface",145);}
case 145:{f.Pc=f.Pop().Int!=0?424:148;continue;}
case 148:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",151);}
case 151:{f.Locals[12]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[12]);f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.String("Target")));f.Pc=158;continue;}
case 158:{f.Push(f.Locals[1]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",164);}
case 164:{f.StackOp("pop");f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",168);}
case 168:{f.Push(JValue.R(rt.String("lblSelectCountersTypeToRemove")));f.Pc=171;continue;}
case 171:{f.Push(JValue.I(0));f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",178);}
case 178:{f.Locals[13]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[10]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[11]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"com/google/common/collect/Multiset","elementSet","()Ljava/util/Set;","invokeinterface",189);}
case 189:{return rt.Call(f,"com/google/common/collect/ImmutableList","copyOf","(Ljava/util/Collection;)Lcom/google/common/collect/ImmutableList;","invokestatic",192);}
case 192:{f.Push(f.Locals[3]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[13]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[12]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/player/PlayerController","chooseCounterType","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/card/CounterType;","invokevirtual",200);}
case 200:{f.Locals[14]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[2]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[11]);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[14]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"com/google/common/collect/Multiset","count","(Ljava/lang/Object;)I","invokeinterface",212);}
case 212:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",215);}
case 215:{f.Locals[15]=f.Pop();f.Pc=217;continue;}
case 217:{f.Push(f.Locals[11]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[14]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"com/google/common/collect/Multiset","remove","(Ljava/lang/Object;)Z","invokeinterface",226);}
case 226:{f.StackOp("pop");f.Pc=227;continue;}
case 227:{f.Push(f.Locals[11]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"com/google/common/collect/Multiset","size","()I","invokeinterface",234);}
case 234:{f.Locals[16]=f.Pop();f.Pc=236;continue;}
case 236:{f.Push(f.Locals[6]);f.Pc=238;continue;}
case 238:{f.Pc=f.Pop().Int==0?245:241;continue;}
case 241:{f.Push(JValue.I(0));f.Pc=242;continue;}
case 242:{f.Pc=254;continue;}
case 245:{f.Push(JValue.I(1));f.Pc=246;continue;}
case 246:{f.Push(f.Locals[15]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[16]);f.Pc=250;continue;}
case 250:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=251;continue;}
case 251:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",254);}
case 254:{f.Locals[17]=f.Pop();f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",259);}
case 259:{f.Push(JValue.R(rt.String("lblSelectRemoveCountersNumberOfTarget")));f.Pc=262;continue;}
case 262:{f.Push(JValue.I(1));f.Pc=263;continue;}
case 263:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=266;continue;}
case 266:{f.StackOp("dup");f.Pc=267;continue;}
case 267:{f.Push(JValue.I(0));f.Pc=268;continue;}
case 268:{f.Push(f.Locals[14]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",275);}
case 275:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",279);}
case 279:{f.Locals[13]=f.Pop();f.Pc=281;continue;}
case 281:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",284);}
case 284:{f.Locals[12]=f.Pop();f.Pc=286;continue;}
case 286:{f.Push(f.Locals[12]);f.Pc=288;continue;}
case 288:{f.Push(JValue.R(rt.String("Target")));f.Pc=291;continue;}
case 291:{f.Push(f.Locals[1]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",297);}
case 297:{f.StackOp("pop");f.Pc=298;continue;}
case 298:{f.Push(f.Locals[12]);f.Pc=300;continue;}
case 300:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=302;continue;}
case 302:{f.Push(f.Locals[14]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",309);}
case 309:{f.StackOp("pop");f.Pc=310;continue;}
case 310:{f.Push(f.Locals[10]);f.Pc=312;continue;}
case 312:{f.Push(f.Locals[3]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[13]);f.Pc=315;continue;}
case 315:{f.Push(f.Locals[17]);f.Pc=317;continue;}
case 317:{f.Push(f.Locals[15]);f.Pc=319;continue;}
case 319:{f.Push(f.Locals[12]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;IILjava/util/Map;)I","invokevirtual",324);}
case 324:{f.Locals[18]=f.Pop();f.Pc=326;continue;}
case 326:{f.Push(f.Locals[18]);f.Pc=328;continue;}
case 328:{f.Pc=f.Pop().Int<=0?413:331;continue;}
case 331:{f.Push(f.Locals[5]);f.Pc=333;continue;}
case 333:{f.Push(f.Locals[18]);f.Pc=335;continue;}
case 335:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=336;continue;}
case 336:{f.Locals[5]=f.Pop();f.Pc=338;continue;}
case 338:{f.Push(f.Locals[1]);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[14]);f.Pc=341;continue;}
case 341:{f.Push(f.Locals[18]);f.Pc=343;continue;}
case 343:{f.Push(f.Locals[9]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/GameEntity","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",348);}
case 348:{f.StackOp("pop");f.Pc=349;continue;}
case 349:{f.Push(f.Locals[1]);f.Pc=350;continue;}
case 350:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=353;continue;}
case 353:{f.Pc=f.Pop().Int==0?369:356;continue;}
case 356:{f.Push(f.Locals[1]);f.Pc=357;continue;}
case 357:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=360;continue;}
case 360:{f.Locals[19]=f.Pop();f.Pc=362;continue;}
case 362:{f.Push(f.Locals[8]);f.Pc=364;continue;}
case 364:{f.Push(f.Locals[19]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/Game","updateLastStateForCard","(Lforge/game/card/Card;)V","invokevirtual",369);}
case 369:{f.Push(f.Locals[4]);f.Pc=371;continue;}
case 371:{f.Pc=f.Pop().Int==0?405:374;continue;}
case 374:{f.Push(JValue.I(0));f.Pc=375;continue;}
case 375:{f.Locals[19]=f.Pop();f.Pc=377;continue;}
case 377:{f.Push(f.Locals[19]);f.Pc=379;continue;}
case 379:{f.Push(f.Locals[18]);f.Pc=381;continue;}
case 381:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?405:384;continue;}
case 384:{f.Push(f.Locals[7]);f.Pc=386;continue;}
case 386:{f.Push(f.Locals[14]);f.Pc=388;continue;}
case 388:{f.Push(f.Locals[19]);f.Pc=390;continue;}
case 390:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",393);}
case 393:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",396);}
case 396:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",399);}
case 399:{f.Locals[19]=JValue.I(unchecked(f.Locals[19].Int+(1)));f.Pc=402;continue;}
case 402:{f.Pc=377;continue;}
case 405:{f.Push(f.Locals[2]);f.Pc=406;continue;}
case 406:{f.Push(f.Locals[18]);f.Pc=408;continue;}
case 408:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=409;continue;}
case 409:{f.Locals[2]=f.Pop();f.Pc=410;continue;}
case 410:{f.Pc=421;continue;}
case 413:{f.Push(f.Locals[6]);f.Pc=415;continue;}
case 415:{f.Pc=f.Pop().Int==0?421:418;continue;}
case 418:{f.Pc=424;continue;}
case 421:{f.Pc=134;continue;}
case 424:{f.Push(f.Locals[5]);f.Pc=426;continue;}
case 426:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3283(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateBattlefield","()Lforge/game/card/CardCollection;","invokevirtual",11);}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?22:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
