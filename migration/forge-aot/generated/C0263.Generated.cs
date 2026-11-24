// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C263{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/CountersMoveEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3244,"forge/game/ability/effects/CountersMoveEffect","<init>","()V",1,1,1,new JHandler[]{},M3244));
c.Add(new JMethod(3245,"forge/game/ability/effects/CountersMoveEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,9,5,new JHandler[]{new JHandler(268,280,283,"java/lang/IndexOutOfBoundsException")},M3245));
c.Add(new JMethod(3246,"forge/game/ability/effects/CountersMoveEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,21,9,new JHandler[]{new JHandler(62,68,71,"java/lang/Exception")},M3246));
c.Add(new JMethod(3247,"forge/game/ability/effects/CountersMoveEffect","removeCounter","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/card/CounterType;Ljava/lang/String;Lcom/google/common/collect/Multiset;)V",4,15,8,new JHandler[]{},M3247));
}

internal static JStep M3244(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3245(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/CountersMoveEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.R(null));f.Pc=14;continue;}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?59:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMinTargets","()I","invokevirtual",27);}
case 27:{f.Push(JValue.I(2));f.Pc=28;continue;}
case 28:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?59:31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",37);}
case 37:{f.Push(JValue.I(2));f.Pc=38;continue;}
case 38:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?44:41;continue;}
case 41:{f.Push(JValue.R(rt.String("")));f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/List","remove","(I)Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[4]=f.Pop();f.Pc=56;continue;}
case 56:{f.Pc=90;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("Source")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/ability/effects/CountersMoveEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",65);}
case 65:{f.Locals[5]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[5]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",74);}
case 74:{f.Pc=f.Pop().Int<=0?90:77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{f.Push(JValue.I(0));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",85);}
case 85:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=88;continue;}
case 88:{f.Locals[4]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",96);}
case 96:{f.Locals[5]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("1")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",106);}
case 106:{f.Locals[6]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(JValue.I(0));f.Pc=109;continue;}
case 109:{f.Locals[7]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String("Any")));f.Pc=113;continue;}
case 113:{f.Push(f.Locals[6]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int!=0?143:121;continue;}
case 121:{f.Push(JValue.R(rt.String("All")));f.Pc=123;continue;}
case 123:{f.Push(f.Locals[6]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int!=0?143:131;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",135);}
case 135:{f.Push(f.Locals[6]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",141);}
case 141:{f.Locals[7]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(f.Locals[2]);f.Pc=144;continue;}
case 144:{f.Push(JValue.R(rt.String("Move ")));f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{f.Push(JValue.R(rt.String("Any")));f.Pc=152;continue;}
case 152:{f.Push(f.Locals[5]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",157);}
case 157:{f.Pc=f.Pop().Int==0?196:160;continue;}
case 160:{f.Push(f.Locals[7]);f.Pc=162;continue;}
case 162:{f.Push(JValue.I(1));f.Pc=163;continue;}
case 163:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?176:166;continue;}
case 166:{f.Push(f.Locals[2]);f.Pc=167;continue;}
case 167:{f.Push(JValue.R(rt.String("a counter")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",172);}
case 172:{f.StackOp("pop");f.Pc=173;continue;}
case 173:{f.Pc=238;continue;}
case 176:{f.Push(f.Locals[2]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[7]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",182);}
case 182:{f.Push(JValue.R(rt.String(" ")));f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",187);}
case 187:{f.Push(JValue.R(rt.String(" counter")));f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",192);}
case 192:{f.StackOp("pop");f.Pc=193;continue;}
case 193:{f.Pc=238;continue;}
case 196:{f.Push(JValue.R(rt.String("All")));f.Pc=198;continue;}
case 198:{f.Push(f.Locals[5]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",203);}
case 203:{f.Pc=f.Pop().Int==0?216:206;continue;}
case 206:{f.Push(f.Locals[2]);f.Pc=207;continue;}
case 207:{f.Push(JValue.R(rt.String("all counter")));f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",212);}
case 212:{f.StackOp("pop");f.Pc=213;continue;}
case 213:{f.Pc=238;continue;}
case 216:{f.Push(f.Locals[2]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[7]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",222);}
case 222:{f.Push(JValue.R(rt.String(" ")));f.Pc=224;continue;}
case 224:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",227);}
case 227:{f.Push(f.Locals[5]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",232);}
case 232:{f.Push(JValue.R(rt.String(" counter")));f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",237);}
case 237:{f.StackOp("pop");f.Pc=238;continue;}
case 238:{f.Push(f.Locals[7]);f.Pc=240;continue;}
case 240:{f.Push(JValue.I(1));f.Pc=241;continue;}
case 241:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?251:244;continue;}
case 244:{f.Push(f.Locals[2]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String("s")));f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",250);}
case 250:{f.StackOp("pop");f.Pc=251;continue;}
case 251:{f.Push(f.Locals[2]);f.Pc=252;continue;}
case 252:{f.Push(JValue.R(rt.String(" from ")));f.Pc=254;continue;}
case 254:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",257);}
case 257:{f.Push(f.Locals[4]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",262);}
case 262:{f.Push(JValue.R(rt.String(" to ")));f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",267);}
case 267:{f.StackOp("pop");f.Pc=268;continue;}
case 268:{f.Push(f.Locals[2]);f.Pc=269;continue;}
case 269:{f.Push(f.Locals[3]);f.Pc=270;continue;}
case 270:{f.Push(JValue.I(0));f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",276);}
case 276:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",279);}
case 279:{f.StackOp("pop");f.Pc=280;continue;}
case 280:{f.Pc=311;continue;}
case 283:{f.Locals[8]=f.Pop();f.Pc=285;continue;}
case 285:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=288;continue;}
case 288:{f.Push(JValue.I(2));f.Pc=289;continue;}
case 289:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=292;continue;}
case 292:{f.StackOp("dup");f.Pc=293;continue;}
case 293:{f.Push(JValue.I(0));f.Pc=294;continue;}
case 294:{f.Push(JValue.R(rt.String("Somehow this is missing targets?")));f.Pc=296;continue;}
case 296:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=297;continue;}
case 297:{f.StackOp("dup");f.Pc=298;continue;}
case 298:{f.Push(JValue.I(1));f.Pc=299;continue;}
case 299:{f.Push(f.Locals[4]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",304);}
case 304:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",308);}
case 308:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",311);}
case 311:{f.Push(f.Locals[2]);f.Pc=312;continue;}
case 312:{f.Push(JValue.R(rt.String(".")));f.Pc=314;continue;}
case 314:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",317);}
case 317:{f.StackOp("pop");f.Pc=318;continue;}
case 318:{f.Push(f.Locals[2]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",322);}
case 322:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3246(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("1")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",20);}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",26);}
case 26:{f.Locals[5]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[5]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",33);}
case 33:{f.Locals[6]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",39);}
case 39:{f.Locals[7]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(JValue.R(null));f.Pc=42;continue;}
case 42:{f.Locals[8]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("Any")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int!=0?82:53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("All")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int!=0?82:62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",66);}
case 66:{f.Locals[8]=f.Pop();f.Pc=68;continue;}
case 68:{f.Pc=82;continue;}
case 71:{f.Locals[9]=f.Pop();f.Pc=73;continue;}
case 73:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("Counter type doesn't match, nor does an SVar exist with the type name.")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",81);}
case 81:{return JStep.ReturnVoid;}
case 82:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=85;continue;}
case 85:{f.StackOp("dup");f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",89);}
case 89:{f.Locals[9]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",97);}
case 97:{f.Pc=f.Pop().Int==0?577:100;continue;}
case 100:{f.Push(f.Locals[7]);f.Pc=102;continue;}
case 102:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",108);}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",114);}
case 114:{f.Push(f.Locals[5]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",121);}
case 121:{f.Locals[10]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/ability/effects/CountersMoveEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",127);}
case 127:{f.Locals[11]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[11]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",136);}
case 136:{f.Pc=f.Pop().Int==0?140:139;continue;}
case 139:{return JStep.ReturnVoid;}
case 140:{f.Push(f.Locals[11]);f.Pc=142;continue;}
case 142:{f.Push(JValue.I(0));f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",148);}
case 148:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=151;continue;}
case 151:{f.Locals[12]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[7]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[12]);f.Pc=157;continue;}
case 157:{f.Push(JValue.R(null));f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",161);}
case 161:{f.Locals[13]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[13]);f.Pc=165;continue;}
case 165:{f.Pc=f.Pop().Reference==null?178:168;continue;}
case 168:{f.Push(f.Locals[13]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[12]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",175);}
case 175:{f.Pc=f.Pop().Int!=0?179:178;continue;}
case 178:{return JStep.ReturnVoid;}
case 179:{f.Push(f.Locals[13]);f.Pc=181;continue;}
case 181:{f.Locals[12]=f.Pop();f.Pc=183;continue;}
case 183:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",186);}
case 186:{f.Locals[14]=f.Pop();f.Pc=188;continue;}
case 188:{f.Push(f.Locals[14]);f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.String("Target")));f.Pc=192;continue;}
case 192:{f.Push(f.Locals[12]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",199);}
case 199:{f.StackOp("pop");f.Pc=200;continue;}
case 200:{f.Push(JValue.R(rt.String("All")));f.Pc=202;continue;}
case 202:{f.Push(f.Locals[3]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",206);}
case 206:{f.Pc=f.Pop().Int==0?273:209;continue;}
case 209:{f.Push(f.Locals[4]);f.Pc=211;continue;}
case 211:{f.Push(JValue.R(rt.String("Any")));f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",216);}
case 216:{f.Pc=f.Pop().Int==0?364:219;continue;}
case 219:{f.Push(f.Locals[10]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"forge/game/card/CardPredicates","hasCounters","()Ljava/util/function/Predicate;","invokestatic",224);}
case 224:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",227);}
case 227:{f.Locals[10]=f.Pop();f.Pc=229;continue;}
case 229:{f.Push(f.Locals[5]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",234);}
case 234:{f.Push(f.Locals[10]);f.Pc=236;continue;}
case 236:{f.Push(f.Locals[1]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",240);}
case 240:{f.Push(JValue.R(rt.String("lblChooseTakeCountersCard")));f.Pc=242;continue;}
case 242:{f.Push(JValue.I(1));f.Pc=243;continue;}
case 243:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=246;continue;}
case 246:{f.StackOp("dup");f.Pc=247;continue;}
case 247:{f.Push(JValue.I(0));f.Pc=248;continue;}
case 248:{f.Push(JValue.R(rt.String("any")));f.Pc=250;continue;}
case 250:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",254);}
case 254:{f.Push(JValue.I(0));f.Pc=255;continue;}
case 255:{f.Push(f.Locals[10]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",262);}
case 262:{f.Push(JValue.I(1));f.Pc=263;continue;}
case 263:{f.Push(f.Locals[14]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",268);}
case 268:{f.Locals[10]=f.Pop();f.Pc=270;continue;}
case 270:{f.Pc=364;continue;}
case 273:{f.Push(f.Locals[12]);f.Pc=275;continue;}
case 275:{f.Push(f.Locals[8]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/card/Card","canReceiveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",280);}
case 280:{f.Pc=f.Pop().Int!=0?284:283;continue;}
case 283:{return JStep.ReturnVoid;}
case 284:{f.Push(f.Locals[10]);f.Pc=286;continue;}
case 286:{f.Push(f.Locals[8]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/card/CardPredicates","hasCounter","(Lforge/game/card/CounterType;)Ljava/util/function/Predicate;","invokestatic",291);}
case 291:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",294);}
case 294:{f.Locals[10]=f.Pop();f.Pc=296;continue;}
case 296:{f.Push(f.Locals[4]);f.Pc=298;continue;}
case 298:{f.Push(JValue.R(rt.String("Any")));f.Pc=300;continue;}
case 300:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",303);}
case 303:{f.Pc=f.Pop().Int==0?364:306;continue;}
case 306:{f.Push(f.Locals[14]);f.Pc=308;continue;}
case 308:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=310;continue;}
case 310:{f.Push(f.Locals[8]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",317);}
case 317:{f.StackOp("pop");f.Pc=318;continue;}
case 318:{f.Push(f.Locals[5]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",323);}
case 323:{f.Push(f.Locals[10]);f.Pc=325;continue;}
case 325:{f.Push(f.Locals[1]);f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",329);}
case 329:{f.Push(JValue.R(rt.String("lblChooseTakeCountersCard")));f.Pc=331;continue;}
case 331:{f.Push(JValue.I(1));f.Pc=332;continue;}
case 332:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=335;continue;}
case 335:{f.StackOp("dup");f.Pc=336;continue;}
case 336:{f.Push(JValue.I(0));f.Pc=337;continue;}
case 337:{f.Push(f.Locals[8]);f.Pc=339;continue;}
case 339:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",344);}
case 344:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",348);}
case 348:{f.Push(JValue.I(0));f.Pc=349;continue;}
case 349:{f.Push(f.Locals[10]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",356);}
case 356:{f.Push(JValue.I(1));f.Pc=357;continue;}
case 357:{f.Push(f.Locals[14]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",362);}
case 362:{f.Locals[10]=f.Pop();f.Pc=364;continue;}
case 364:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","()Lcom/google/common/collect/HashMultiset;","invokestatic",367);}
case 367:{f.Locals[15]=f.Pop();f.Pc=369;continue;}
case 369:{f.Push(f.Locals[10]);f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",376);}
case 376:{f.Locals[16]=f.Pop();f.Pc=378;continue;}
case 378:{f.Push(f.Locals[16]);f.Pc=380;continue;}
case 380:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",385);}
case 385:{f.Pc=f.Pop().Int==0?502:388;continue;}
case 388:{f.Push(f.Locals[16]);f.Pc=390;continue;}
case 390:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",395);}
case 395:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=398;continue;}
case 398:{f.Locals[17]=f.Pop();f.Pc=400;continue;}
case 400:{f.Push(JValue.R(rt.String("All")));f.Pc=402;continue;}
case 402:{f.Push(f.Locals[3]);f.Pc=403;continue;}
case 403:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",406);}
case 406:{f.Pc=f.Pop().Int==0?484:409;continue;}
case 409:{f.Push(f.Locals[17]);f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/game/card/Card","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",414);}
case 414:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","(Ljava/lang/Iterable;)Lcom/google/common/collect/HashMultiset;","invokestatic",417);}
case 417:{f.Locals[18]=f.Pop();f.Pc=419;continue;}
case 419:{f.Push(f.Locals[18]);f.Pc=421;continue;}
case 421:{return rt.Call(f,"com/google/common/collect/Multiset","entrySet","()Ljava/util/Set;","invokeinterface",426);}
case 426:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",431);}
case 431:{f.Locals[19]=f.Pop();f.Pc=433;continue;}
case 433:{f.Push(f.Locals[19]);f.Pc=435;continue;}
case 435:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",440);}
case 440:{f.Pc=f.Pop().Int==0?481:443;continue;}
case 443:{f.Push(f.Locals[19]);f.Pc=445;continue;}
case 445:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",450);}
case 450:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=453;continue;}
case 453:{f.Locals[20]=f.Pop();f.Pc=455;continue;}
case 455:{f.Push(f.Locals[0]);f.Pc=456;continue;}
case 456:{f.Push(f.Locals[1]);f.Pc=457;continue;}
case 457:{f.Push(f.Locals[17]);f.Pc=459;continue;}
case 459:{f.Push(f.Locals[12]);f.Pc=461;continue;}
case 461:{f.Push(f.Locals[20]);f.Pc=463;continue;}
case 463:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",468);}
case 468:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=471;continue;}
case 471:{f.Push(f.Locals[4]);f.Pc=473;continue;}
case 473:{f.Push(f.Locals[15]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/game/ability/effects/CountersMoveEffect","removeCounter","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/card/CounterType;Ljava/lang/String;Lcom/google/common/collect/Multiset;)V","invokevirtual",478);}
case 478:{f.Pc=433;continue;}
case 481:{f.Pc=499;continue;}
case 484:{f.Push(f.Locals[0]);f.Pc=485;continue;}
case 485:{f.Push(f.Locals[1]);f.Pc=486;continue;}
case 486:{f.Push(f.Locals[17]);f.Pc=488;continue;}
case 488:{f.Push(f.Locals[12]);f.Pc=490;continue;}
case 490:{f.Push(f.Locals[8]);f.Pc=492;continue;}
case 492:{f.Push(f.Locals[4]);f.Pc=494;continue;}
case 494:{f.Push(f.Locals[15]);f.Pc=496;continue;}
case 496:{return rt.Call(f,"forge/game/ability/effects/CountersMoveEffect","removeCounter","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/card/CounterType;Ljava/lang/String;Lcom/google/common/collect/Multiset;)V","invokevirtual",499);}
case 499:{f.Pc=378;continue;}
case 502:{f.Push(f.Locals[15]);f.Pc=504;continue;}
case 504:{return rt.Call(f,"com/google/common/collect/Multiset","entrySet","()Ljava/util/Set;","invokeinterface",509);}
case 509:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",514);}
case 514:{f.Locals[16]=f.Pop();f.Pc=516;continue;}
case 516:{f.Push(f.Locals[16]);f.Pc=518;continue;}
case 518:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",523);}
case 523:{f.Pc=f.Pop().Int==0?567:526;continue;}
case 526:{f.Push(f.Locals[16]);f.Pc=528;continue;}
case 528:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",533);}
case 533:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=536;continue;}
case 536:{f.Locals[17]=f.Pop();f.Pc=538;continue;}
case 538:{f.Push(f.Locals[12]);f.Pc=540;continue;}
case 540:{f.Push(f.Locals[17]);f.Pc=542;continue;}
case 542:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",547);}
case 547:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=550;continue;}
case 550:{f.Push(f.Locals[17]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",557);}
case 557:{f.Push(f.Locals[5]);f.Pc=559;continue;}
case 559:{f.Push(f.Locals[9]);f.Pc=561;continue;}
case 561:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",564);}
case 564:{f.Pc=516;continue;}
case 567:{f.Push(f.Locals[7]);f.Pc=569;continue;}
case 569:{f.Push(f.Locals[12]);f.Pc=571;continue;}
case 571:{return rt.Call(f,"forge/game/Game","updateLastStateForCard","(Lforge/game/card/Card;)V","invokevirtual",574);}
case 574:{f.Pc=1650;continue;}
case 577:{f.Push(f.Locals[1]);f.Pc=578;continue;}
case 578:{f.Push(JValue.R(rt.String("ValidDefined")));f.Pc=581;continue;}
case 581:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",584);}
case 584:{f.Pc=f.Pop().Int==0?1000:587;continue;}
case 587:{f.Push(f.Locals[1]);f.Pc=588;continue;}
case 588:{f.Push(JValue.R(rt.String("Source")));f.Pc=590;continue;}
case 590:{return rt.Call(f,"forge/game/ability/effects/CountersMoveEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",593);}
case 593:{f.Locals[10]=f.Pop();f.Pc=595;continue;}
case 595:{f.Push(f.Locals[10]);f.Pc=597;continue;}
case 597:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",602);}
case 602:{f.Pc=f.Pop().Int==0?606:605;continue;}
case 605:{return JStep.ReturnVoid;}
case 606:{f.Push(f.Locals[10]);f.Pc=608;continue;}
case 608:{f.Push(JValue.I(0));f.Pc=609;continue;}
case 609:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",614);}
case 614:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=617;continue;}
case 617:{f.Locals[11]=f.Pop();f.Pc=619;continue;}
case 619:{f.Push(f.Locals[11]);f.Pc=621;continue;}
case 621:{f.Push(f.Locals[8]);f.Pc=623;continue;}
case 623:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",626);}
case 626:{f.Pc=f.Pop().Int>0?630:629;continue;}
case 629:{return JStep.ReturnVoid;}
case 630:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",633);}
case 633:{f.Locals[12]=f.Pop();f.Pc=635;continue;}
case 635:{f.Push(f.Locals[12]);f.Pc=637;continue;}
case 637:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=639;continue;}
case 639:{f.Push(f.Locals[8]);f.Pc=641;continue;}
case 641:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",646);}
case 646:{f.StackOp("pop");f.Pc=647;continue;}
case 647:{f.Push(f.Locals[12]);f.Pc=649;continue;}
case 649:{f.Push(JValue.R(rt.String("Source")));f.Pc=651;continue;}
case 651:{f.Push(f.Locals[11]);f.Pc=653;continue;}
case 653:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",658);}
case 658:{f.StackOp("pop");f.Pc=659;continue;}
case 659:{f.Push(f.Locals[7]);f.Pc=661;continue;}
case 661:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=664;continue;}
case 664:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",667);}
case 667:{f.Push(f.Locals[1]);f.Pc=668;continue;}
case 668:{f.Push(JValue.R(rt.String("ValidDefined")));f.Pc=671;continue;}
case 671:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",674);}
case 674:{f.Push(f.Locals[5]);f.Pc=676;continue;}
case 676:{f.Push(f.Locals[2]);f.Pc=677;continue;}
case 677:{f.Push(f.Locals[1]);f.Pc=678;continue;}
case 678:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",681);}
case 681:{f.Locals[13]=f.Pop();f.Pc=683;continue;}
case 683:{f.Push(f.Locals[4]);f.Pc=685;continue;}
case 685:{f.Push(JValue.R(rt.String("Any")));f.Pc=687;continue;}
case 687:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",690);}
case 690:{f.Pc=f.Pop().Int==0?748:693;continue;}
case 693:{f.Push(f.Locals[5]);f.Pc=695;continue;}
case 695:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",698);}
case 698:{f.Push(f.Locals[13]);f.Pc=700;continue;}
case 700:{f.Push(f.Locals[1]);f.Pc=701;continue;}
case 701:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",704);}
case 704:{f.Push(JValue.R(rt.String("lblChooseCardToGetCountersFrom")));f.Pc=707;continue;}
case 707:{f.Push(JValue.I(2));f.Pc=708;continue;}
case 708:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=711;continue;}
case 711:{f.StackOp("dup");f.Pc=712;continue;}
case 712:{f.Push(JValue.I(0));f.Pc=713;continue;}
case 713:{f.Push(f.Locals[8]);f.Pc=715;continue;}
case 715:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",720);}
case 720:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=721;continue;}
case 721:{f.StackOp("dup");f.Pc=722;continue;}
case 722:{f.Push(JValue.I(1));f.Pc=723;continue;}
case 723:{f.Push(f.Locals[11]);f.Pc=725;continue;}
case 725:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",728);}
case 728:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=729;continue;}
case 729:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",732);}
case 732:{f.Push(JValue.I(0));f.Pc=733;continue;}
case 733:{f.Push(f.Locals[13]);f.Pc=735;continue;}
case 735:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",740);}
case 740:{f.Push(JValue.I(1));f.Pc=741;continue;}
case 741:{f.Push(f.Locals[12]);f.Pc=743;continue;}
case 743:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",746);}
case 746:{f.Locals[13]=f.Pop();f.Pc=748;continue;}
case 748:{f.Push(JValue.I(0));f.Pc=749;continue;}
case 749:{f.Locals[14]=f.Pop();f.Pc=751;continue;}
case 751:{f.Push(f.Locals[13]);f.Pc=753;continue;}
case 753:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",758);}
case 758:{f.Locals[15]=f.Pop();f.Pc=760;continue;}
case 760:{f.Push(f.Locals[15]);f.Pc=762;continue;}
case 762:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",767);}
case 767:{f.Pc=f.Pop().Int==0?985:770;continue;}
case 770:{f.Push(f.Locals[15]);f.Pc=772;continue;}
case 772:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",777);}
case 777:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=780;continue;}
case 780:{f.Locals[16]=f.Pop();f.Pc=782;continue;}
case 782:{f.Push(f.Locals[11]);f.Pc=784;continue;}
case 784:{f.Push(f.Locals[16]);f.Pc=786;continue;}
case 786:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",789);}
case 789:{f.Pc=f.Pop().Int==0?795:792;continue;}
case 792:{f.Pc=760;continue;}
case 795:{f.Push(f.Locals[16]);f.Pc=797;continue;}
case 797:{f.Push(f.Locals[8]);f.Pc=799;continue;}
case 799:{return rt.Call(f,"forge/game/card/Card","canReceiveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",802);}
case 802:{f.Pc=f.Pop().Int!=0?808:805;continue;}
case 805:{f.Pc=760;continue;}
case 808:{f.Push(f.Locals[11]);f.Pc=810;continue;}
case 810:{f.Push(f.Locals[8]);f.Pc=812;continue;}
case 812:{return rt.Call(f,"forge/game/card/Card","canRemoveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",815);}
case 815:{f.Pc=f.Pop().Int!=0?821:818;continue;}
case 818:{f.Pc=760;continue;}
case 821:{f.Push(f.Locals[7]);f.Pc=823;continue;}
case 823:{f.Push(f.Locals[16]);f.Pc=825;continue;}
case 825:{f.Push(JValue.R(null));f.Pc=826;continue;}
case 826:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",829);}
case 829:{f.Locals[17]=f.Pop();f.Pc=831;continue;}
case 831:{f.Push(f.Locals[17]);f.Pc=833;continue;}
case 833:{f.Pc=f.Pop().Reference==null?760:836;continue;}
case 836:{f.Push(f.Locals[17]);f.Pc=838;continue;}
case 838:{f.Push(f.Locals[16]);f.Pc=840;continue;}
case 840:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",843);}
case 843:{f.Pc=f.Pop().Int!=0?849:846;continue;}
case 846:{f.Pc=760;continue;}
case 849:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",852);}
case 852:{f.Locals[12]=f.Pop();f.Pc=854;continue;}
case 854:{f.Push(f.Locals[12]);f.Pc=856;continue;}
case 856:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=858;continue;}
case 858:{f.Push(f.Locals[8]);f.Pc=860;continue;}
case 860:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",865);}
case 865:{f.StackOp("pop");f.Pc=866;continue;}
case 866:{f.Push(f.Locals[12]);f.Pc=868;continue;}
case 868:{f.Push(JValue.R(rt.String("Source")));f.Pc=870;continue;}
case 870:{f.Push(f.Locals[11]);f.Pc=872;continue;}
case 872:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",877);}
case 877:{f.StackOp("pop");f.Pc=878;continue;}
case 878:{f.Push(f.Locals[12]);f.Pc=880;continue;}
case 880:{f.Push(JValue.R(rt.String("Target")));f.Pc=882;continue;}
case 882:{f.Push(f.Locals[17]);f.Pc=884;continue;}
case 884:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",889);}
case 889:{f.StackOp("pop");f.Pc=890;continue;}
case 890:{f.Push(f.Locals[5]);f.Pc=892;continue;}
case 892:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",895);}
case 895:{f.Push(f.Locals[1]);f.Pc=896;continue;}
case 896:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",899);}
case 899:{f.Push(JValue.R(rt.String("lblPutHowManyTargetCounterOnCard")));f.Pc=902;continue;}
case 902:{f.Push(JValue.I(2));f.Pc=903;continue;}
case 903:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=906;continue;}
case 906:{f.StackOp("dup");f.Pc=907;continue;}
case 907:{f.Push(JValue.I(0));f.Pc=908;continue;}
case 908:{f.Push(f.Locals[8]);f.Pc=910;continue;}
case 910:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",915);}
case 915:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=916;continue;}
case 916:{f.StackOp("dup");f.Pc=917;continue;}
case 917:{f.Push(JValue.I(1));f.Pc=918;continue;}
case 918:{f.Push(f.Locals[17]);f.Pc=920;continue;}
case 920:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",923);}
case 923:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=924;continue;}
case 924:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",927);}
case 927:{f.Push(JValue.I(0));f.Pc=928;continue;}
case 928:{f.Push(f.Locals[11]);f.Pc=930;continue;}
case 930:{f.Push(f.Locals[8]);f.Pc=932;continue;}
case 932:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",935);}
case 935:{f.Push(f.Locals[12]);f.Pc=937;continue;}
case 937:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;IILjava/util/Map;)I","invokevirtual",940);}
case 940:{f.Locals[18]=f.Pop();f.Pc=942;continue;}
case 942:{f.Push(f.Locals[18]);f.Pc=944;continue;}
case 944:{f.Pc=f.Pop().Int<=0?982:947;continue;}
case 947:{f.Push(f.Locals[11]);f.Pc=949;continue;}
case 949:{f.Push(f.Locals[8]);f.Pc=951;continue;}
case 951:{f.Push(f.Locals[18]);f.Pc=953;continue;}
case 953:{f.Push(f.Locals[5]);f.Pc=955;continue;}
case 955:{return rt.Call(f,"forge/game/card/Card","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",958);}
case 958:{f.StackOp("pop");f.Pc=959;continue;}
case 959:{f.Push(f.Locals[17]);f.Pc=961;continue;}
case 961:{f.Push(f.Locals[8]);f.Pc=963;continue;}
case 963:{f.Push(f.Locals[18]);f.Pc=965;continue;}
case 965:{f.Push(f.Locals[5]);f.Pc=967;continue;}
case 967:{f.Push(f.Locals[9]);f.Pc=969;continue;}
case 969:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",972);}
case 972:{f.Push(f.Locals[7]);f.Pc=974;continue;}
case 974:{f.Push(f.Locals[17]);f.Pc=976;continue;}
case 976:{return rt.Call(f,"forge/game/Game","updateLastStateForCard","(Lforge/game/card/Card;)V","invokevirtual",979);}
case 979:{f.Push(JValue.I(1));f.Pc=980;continue;}
case 980:{f.Locals[14]=f.Pop();f.Pc=982;continue;}
case 982:{f.Pc=760;continue;}
case 985:{f.Push(f.Locals[14]);f.Pc=987;continue;}
case 987:{f.Pc=f.Pop().Int==0?997:990;continue;}
case 990:{f.Push(f.Locals[7]);f.Pc=992;continue;}
case 992:{f.Push(f.Locals[11]);f.Pc=994;continue;}
case 994:{return rt.Call(f,"forge/game/Game","updateLastStateForCard","(Lforge/game/card/Card;)V","invokevirtual",997);}
case 997:{f.Pc=1650;continue;}
case 1000:{f.Push(JValue.R(null));f.Pc=1001;continue;}
case 1001:{f.Locals[10]=f.Pop();f.Pc=1003;continue;}
case 1003:{f.Push(f.Locals[1]);f.Pc=1004;continue;}
case 1004:{return rt.Call(f,"forge/game/ability/effects/CountersMoveEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",1007);}
case 1007:{f.Locals[11]=f.Pop();f.Pc=1009;continue;}
case 1009:{f.Push(f.Locals[1]);f.Pc=1010;continue;}
case 1010:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",1013);}
case 1013:{f.Pc=f.Pop().Int==0?1052:1016;continue;}
case 1016:{f.Push(f.Locals[1]);f.Pc=1017;continue;}
case 1017:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMinTargets","()I","invokevirtual",1020);}
case 1020:{f.Push(JValue.I(2));f.Pc=1021;continue;}
case 1021:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1052:1024;continue;}
case 1024:{f.Push(f.Locals[11]);f.Pc=1026;continue;}
case 1026:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1031);}
case 1031:{f.Push(JValue.I(2));f.Pc=1032;continue;}
case 1032:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1036:1035;continue;}
case 1035:{return JStep.ReturnVoid;}
case 1036:{f.Push(f.Locals[11]);f.Pc=1038;continue;}
case 1038:{f.Push(JValue.I(0));f.Pc=1039;continue;}
case 1039:{return rt.Call(f,"java/util/List","remove","(I)Ljava/lang/Object;","invokeinterface",1044);}
case 1044:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1047;continue;}
case 1047:{f.Locals[10]=f.Pop();f.Pc=1049;continue;}
case 1049:{f.Pc=1083;continue;}
case 1052:{f.Push(f.Locals[1]);f.Pc=1053;continue;}
case 1053:{f.Push(JValue.R(rt.String("Source")));f.Pc=1055;continue;}
case 1055:{return rt.Call(f,"forge/game/ability/effects/CountersMoveEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",1058);}
case 1058:{f.Locals[12]=f.Pop();f.Pc=1060;continue;}
case 1060:{f.Push(f.Locals[12]);f.Pc=1062;continue;}
case 1062:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1067);}
case 1067:{f.Pc=f.Pop().Int<=0?1083:1070;continue;}
case 1070:{f.Push(f.Locals[12]);f.Pc=1072;continue;}
case 1072:{f.Push(JValue.I(0));f.Pc=1073;continue;}
case 1073:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",1078);}
case 1078:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1081;continue;}
case 1081:{f.Locals[10]=f.Pop();f.Pc=1083;continue;}
case 1083:{f.Push(f.Locals[10]);f.Pc=1085;continue;}
case 1085:{f.Pc=f.Pop().Reference!=null?1089:1088;continue;}
case 1088:{return JStep.ReturnVoid;}
case 1089:{f.Push(f.Locals[10]);f.Pc=1091;continue;}
case 1091:{return rt.Call(f,"forge/game/card/Card","hasCounters","()Z","invokevirtual",1094);}
case 1094:{f.Pc=f.Pop().Int!=0?1098:1097;continue;}
case 1097:{return JStep.ReturnVoid;}
case 1098:{f.Push(f.Locals[11]);f.Pc=1100;continue;}
case 1100:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1105);}
case 1105:{f.Locals[12]=f.Pop();f.Pc=1107;continue;}
case 1107:{f.Push(f.Locals[12]);f.Pc=1109;continue;}
case 1109:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1114);}
case 1114:{f.Pc=f.Pop().Int==0?1643:1117;continue;}
case 1117:{f.Push(f.Locals[12]);f.Pc=1119;continue;}
case 1119:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1124);}
case 1124:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1127;continue;}
case 1127:{f.Locals[13]=f.Pop();f.Pc=1129;continue;}
case 1129:{f.Push(JValue.R(null));f.Pc=1130;continue;}
case 1130:{f.Push(f.Locals[13]);f.Pc=1132;continue;}
case 1132:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1640:1135;continue;}
case 1135:{f.Push(f.Locals[10]);f.Pc=1137;continue;}
case 1137:{f.Push(f.Locals[13]);f.Pc=1139;continue;}
case 1139:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",1142);}
case 1142:{f.Pc=f.Pop().Int==0?1148:1145;continue;}
case 1145:{f.Pc=1107;continue;}
case 1148:{f.Push(f.Locals[7]);f.Pc=1150;continue;}
case 1150:{f.Push(f.Locals[13]);f.Pc=1152;continue;}
case 1152:{f.Push(JValue.R(null));f.Pc=1153;continue;}
case 1153:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",1156);}
case 1156:{f.Locals[14]=f.Pop();f.Pc=1158;continue;}
case 1158:{f.Push(f.Locals[14]);f.Pc=1160;continue;}
case 1160:{f.Pc=f.Pop().Reference==null?1107:1163;continue;}
case 1163:{f.Push(f.Locals[14]);f.Pc=1165;continue;}
case 1165:{f.Push(f.Locals[13]);f.Pc=1167;continue;}
case 1167:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",1170);}
case 1170:{f.Pc=f.Pop().Int!=0?1176:1173;continue;}
case 1173:{f.Pc=1107;continue;}
case 1176:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","()Lcom/google/common/collect/HashMultiset;","invokestatic",1179);}
case 1179:{f.Locals[15]=f.Pop();f.Pc=1181;continue;}
case 1181:{f.Push(JValue.R(rt.String("All")));f.Pc=1183;continue;}
case 1183:{f.Push(f.Locals[3]);f.Pc=1184;continue;}
case 1184:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1187);}
case 1187:{f.Pc=f.Pop().Int==0?1257:1190;continue;}
case 1190:{f.Push(f.Locals[10]);f.Pc=1192;continue;}
case 1192:{return rt.Call(f,"forge/game/card/Card","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",1195);}
case 1195:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","(Ljava/lang/Iterable;)Lcom/google/common/collect/HashMultiset;","invokestatic",1198);}
case 1198:{f.Locals[16]=f.Pop();f.Pc=1200;continue;}
case 1200:{f.Push(f.Locals[16]);f.Pc=1202;continue;}
case 1202:{return rt.Call(f,"com/google/common/collect/Multiset","elementSet","()Ljava/util/Set;","invokeinterface",1207);}
case 1207:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",1212);}
case 1212:{f.Locals[17]=f.Pop();f.Pc=1214;continue;}
case 1214:{f.Push(f.Locals[17]);f.Pc=1216;continue;}
case 1216:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1221);}
case 1221:{f.Pc=f.Pop().Int==0?1254:1224;continue;}
case 1224:{f.Push(f.Locals[17]);f.Pc=1226;continue;}
case 1226:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1231);}
case 1231:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1234;continue;}
case 1234:{f.Locals[18]=f.Pop();f.Pc=1236;continue;}
case 1236:{f.Push(f.Locals[0]);f.Pc=1237;continue;}
case 1237:{f.Push(f.Locals[1]);f.Pc=1238;continue;}
case 1238:{f.Push(f.Locals[10]);f.Pc=1240;continue;}
case 1240:{f.Push(f.Locals[14]);f.Pc=1242;continue;}
case 1242:{f.Push(f.Locals[18]);f.Pc=1244;continue;}
case 1244:{f.Push(f.Locals[4]);f.Pc=1246;continue;}
case 1246:{f.Push(f.Locals[15]);f.Pc=1248;continue;}
case 1248:{return rt.Call(f,"forge/game/ability/effects/CountersMoveEffect","removeCounter","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/card/CounterType;Ljava/lang/String;Lcom/google/common/collect/Multiset;)V","invokevirtual",1251);}
case 1251:{f.Pc=1214;continue;}
case 1254:{f.Pc=1575;continue;}
case 1257:{f.Push(JValue.R(rt.String("EachNotOn")));f.Pc=1260;continue;}
case 1260:{f.Push(f.Locals[3]);f.Pc=1261;continue;}
case 1261:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1264);}
case 1264:{f.Pc=f.Pop().Int==0?1347:1267;continue;}
case 1267:{f.Push(f.Locals[10]);f.Pc=1269;continue;}
case 1269:{return rt.Call(f,"forge/game/card/Card","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",1272);}
case 1272:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","(Ljava/lang/Iterable;)Lcom/google/common/collect/HashMultiset;","invokestatic",1275);}
case 1275:{f.Locals[16]=f.Pop();f.Pc=1277;continue;}
case 1277:{f.Push(f.Locals[16]);f.Pc=1279;continue;}
case 1279:{return rt.Call(f,"com/google/common/collect/Multiset","elementSet","()Ljava/util/Set;","invokeinterface",1284);}
case 1284:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",1289);}
case 1289:{f.Locals[17]=f.Pop();f.Pc=1291;continue;}
case 1291:{f.Push(f.Locals[17]);f.Pc=1293;continue;}
case 1293:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1298);}
case 1298:{f.Pc=f.Pop().Int==0?1344:1301;continue;}
case 1301:{f.Push(f.Locals[17]);f.Pc=1303;continue;}
case 1303:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1308);}
case 1308:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1311;continue;}
case 1311:{f.Locals[18]=f.Pop();f.Pc=1313;continue;}
case 1313:{f.Push(f.Locals[14]);f.Pc=1315;continue;}
case 1315:{f.Push(f.Locals[18]);f.Pc=1317;continue;}
case 1317:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",1320);}
case 1320:{f.Pc=f.Pop().Int<=0?1326:1323;continue;}
case 1323:{f.Pc=1291;continue;}
case 1326:{f.Push(f.Locals[0]);f.Pc=1327;continue;}
case 1327:{f.Push(f.Locals[1]);f.Pc=1328;continue;}
case 1328:{f.Push(f.Locals[10]);f.Pc=1330;continue;}
case 1330:{f.Push(f.Locals[14]);f.Pc=1332;continue;}
case 1332:{f.Push(f.Locals[18]);f.Pc=1334;continue;}
case 1334:{f.Push(f.Locals[4]);f.Pc=1336;continue;}
case 1336:{f.Push(f.Locals[15]);f.Pc=1338;continue;}
case 1338:{return rt.Call(f,"forge/game/ability/effects/CountersMoveEffect","removeCounter","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/card/CounterType;Ljava/lang/String;Lcom/google/common/collect/Multiset;)V","invokevirtual",1341);}
case 1341:{f.Pc=1291;continue;}
case 1344:{f.Pc=1575;continue;}
case 1347:{f.Push(JValue.R(rt.String("Any")));f.Pc=1349;continue;}
case 1349:{f.Push(f.Locals[3]);f.Pc=1350;continue;}
case 1350:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1353);}
case 1353:{f.Pc=f.Pop().Int==0?1560:1356;continue;}
case 1356:{f.Push(f.Locals[10]);f.Pc=1358;continue;}
case 1358:{return rt.Call(f,"forge/game/card/Card","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",1361);}
case 1361:{f.Locals[16]=f.Pop();f.Pc=1363;continue;}
case 1363:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",1366);}
case 1366:{f.Locals[17]=f.Pop();f.Pc=1368;continue;}
case 1368:{f.Push(f.Locals[16]);f.Pc=1370;continue;}
case 1370:{return rt.Call(f,"com/google/common/collect/Multiset","elementSet","()Ljava/util/Set;","invokeinterface",1375);}
case 1375:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",1380);}
case 1380:{f.Locals[18]=f.Pop();f.Pc=1382;continue;}
case 1382:{f.Push(f.Locals[18]);f.Pc=1384;continue;}
case 1384:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1389);}
case 1389:{f.Pc=f.Pop().Int==0?1437:1392;continue;}
case 1392:{f.Push(f.Locals[18]);f.Pc=1394;continue;}
case 1394:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1399);}
case 1399:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1402;continue;}
case 1402:{f.Locals[19]=f.Pop();f.Pc=1404;continue;}
case 1404:{f.Push(f.Locals[13]);f.Pc=1406;continue;}
case 1406:{f.Push(f.Locals[19]);f.Pc=1408;continue;}
case 1408:{return rt.Call(f,"forge/game/card/Card","canReceiveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",1411);}
case 1411:{f.Pc=f.Pop().Int==0?1434:1414;continue;}
case 1414:{f.Push(f.Locals[10]);f.Pc=1416;continue;}
case 1416:{f.Push(f.Locals[19]);f.Pc=1418;continue;}
case 1418:{return rt.Call(f,"forge/game/card/Card","canRemoveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",1421);}
case 1421:{f.Pc=f.Pop().Int==0?1434:1424;continue;}
case 1424:{f.Push(f.Locals[17]);f.Pc=1426;continue;}
case 1426:{f.Push(f.Locals[19]);f.Pc=1428;continue;}
case 1428:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1433);}
case 1433:{f.StackOp("pop");f.Pc=1434;continue;}
case 1434:{f.Pc=1382;continue;}
case 1437:{f.Push(f.Locals[17]);f.Pc=1439;continue;}
case 1439:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1444);}
case 1444:{f.Pc=f.Pop().Int==0?1448:1447;continue;}
case 1447:{return JStep.ReturnVoid;}
case 1448:{f.Push(f.Locals[17]);f.Pc=1450;continue;}
case 1450:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1455);}
case 1455:{f.Pc=f.Pop().Int!=0?1557:1458;continue;}
case 1458:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",1461);}
case 1461:{f.Locals[18]=f.Pop();f.Pc=1463;continue;}
case 1463:{f.Push(f.Locals[18]);f.Pc=1465;continue;}
case 1465:{f.Push(JValue.R(rt.String("Source")));f.Pc=1467;continue;}
case 1467:{f.Push(f.Locals[10]);f.Pc=1469;continue;}
case 1469:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1474);}
case 1474:{f.StackOp("pop");f.Pc=1475;continue;}
case 1475:{f.Push(f.Locals[18]);f.Pc=1477;continue;}
case 1477:{f.Push(JValue.R(rt.String("Target")));f.Pc=1479;continue;}
case 1479:{f.Push(f.Locals[13]);f.Pc=1481;continue;}
case 1481:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1486);}
case 1486:{f.StackOp("pop");f.Pc=1487;continue;}
case 1487:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1490);}
case 1490:{f.Push(JValue.R(rt.String("lblSelectRemoveCounterType")));f.Pc=1493;continue;}
case 1493:{f.Push(JValue.I(0));f.Pc=1494;continue;}
case 1494:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1497;continue;}
case 1497:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1500);}
case 1500:{f.Locals[19]=f.Pop();f.Pc=1502;continue;}
case 1502:{f.Push(f.Locals[6]);f.Pc=1504;continue;}
case 1504:{f.Push(f.Locals[17]);f.Pc=1506;continue;}
case 1506:{f.Push(f.Locals[1]);f.Pc=1507;continue;}
case 1507:{f.Push(f.Locals[19]);f.Pc=1509;continue;}
case 1509:{f.Push(f.Locals[18]);f.Pc=1511;continue;}
case 1511:{return rt.Call(f,"forge/game/player/PlayerController","chooseCounterType","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/card/CounterType;","invokevirtual",1514);}
case 1514:{f.Locals[20]=f.Pop();f.Pc=1516;continue;}
case 1516:{f.Push(f.Locals[0]);f.Pc=1517;continue;}
case 1517:{f.Push(f.Locals[1]);f.Pc=1518;continue;}
case 1518:{f.Push(f.Locals[10]);f.Pc=1520;continue;}
case 1520:{f.Push(f.Locals[14]);f.Pc=1522;continue;}
case 1522:{f.Push(f.Locals[20]);f.Pc=1524;continue;}
case 1524:{f.Push(f.Locals[4]);f.Pc=1526;continue;}
case 1526:{f.Push(f.Locals[15]);f.Pc=1528;continue;}
case 1528:{return rt.Call(f,"forge/game/ability/effects/CountersMoveEffect","removeCounter","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/card/CounterType;Ljava/lang/String;Lcom/google/common/collect/Multiset;)V","invokevirtual",1531);}
case 1531:{f.Push(f.Locals[4]);f.Pc=1533;continue;}
case 1533:{f.Push(JValue.R(rt.String("Any")));f.Pc=1535;continue;}
case 1535:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1538);}
case 1538:{f.Pc=f.Pop().Int!=0?1544:1541;continue;}
case 1541:{f.Pc=1557;continue;}
case 1544:{f.Push(f.Locals[17]);f.Pc=1546;continue;}
case 1546:{f.Push(f.Locals[20]);f.Pc=1548;continue;}
case 1548:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",1553);}
case 1553:{f.StackOp("pop");f.Pc=1554;continue;}
case 1554:{f.Pc=1448;continue;}
case 1557:{f.Pc=1575;continue;}
case 1560:{f.Push(f.Locals[0]);f.Pc=1561;continue;}
case 1561:{f.Push(f.Locals[1]);f.Pc=1562;continue;}
case 1562:{f.Push(f.Locals[10]);f.Pc=1564;continue;}
case 1564:{f.Push(f.Locals[14]);f.Pc=1566;continue;}
case 1566:{f.Push(f.Locals[8]);f.Pc=1568;continue;}
case 1568:{f.Push(f.Locals[4]);f.Pc=1570;continue;}
case 1570:{f.Push(f.Locals[15]);f.Pc=1572;continue;}
case 1572:{return rt.Call(f,"forge/game/ability/effects/CountersMoveEffect","removeCounter","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/card/CounterType;Ljava/lang/String;Lcom/google/common/collect/Multiset;)V","invokevirtual",1575);}
case 1575:{f.Push(f.Locals[15]);f.Pc=1577;continue;}
case 1577:{return rt.Call(f,"com/google/common/collect/Multiset","entrySet","()Ljava/util/Set;","invokeinterface",1582);}
case 1582:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",1587);}
case 1587:{f.Locals[16]=f.Pop();f.Pc=1589;continue;}
case 1589:{f.Push(f.Locals[16]);f.Pc=1591;continue;}
case 1591:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1596);}
case 1596:{f.Pc=f.Pop().Int==0?1640:1599;continue;}
case 1599:{f.Push(f.Locals[16]);f.Pc=1601;continue;}
case 1601:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1606);}
case 1606:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1609;continue;}
case 1609:{f.Locals[17]=f.Pop();f.Pc=1611;continue;}
case 1611:{f.Push(f.Locals[14]);f.Pc=1613;continue;}
case 1613:{f.Push(f.Locals[17]);f.Pc=1615;continue;}
case 1615:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",1620);}
case 1620:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1623;continue;}
case 1623:{f.Push(f.Locals[17]);f.Pc=1625;continue;}
case 1625:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",1630);}
case 1630:{f.Push(f.Locals[5]);f.Pc=1632;continue;}
case 1632:{f.Push(f.Locals[9]);f.Pc=1634;continue;}
case 1634:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",1637);}
case 1637:{f.Pc=1589;continue;}
case 1640:{f.Pc=1107;continue;}
case 1643:{f.Push(f.Locals[7]);f.Pc=1645;continue;}
case 1645:{f.Push(f.Locals[10]);f.Pc=1647;continue;}
case 1647:{return rt.Call(f,"forge/game/Game","updateLastStateForCard","(Lforge/game/card/Card;)V","invokevirtual",1650);}
case 1650:{f.Push(f.Locals[9]);f.Pc=1652;continue;}
case 1652:{f.Push(f.Locals[7]);f.Pc=1654;continue;}
case 1654:{f.Push(f.Locals[1]);f.Pc=1655;continue;}
case 1655:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1658);}
case 1658:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3247(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[7]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",10);}
case 10:{f.Locals[8]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[8]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",17);}
case 17:{f.Locals[9]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[7]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",24);}
case 24:{f.Locals[10]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?35:34;continue;}
case 34:{return JStep.ReturnVoid;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/Card","canReceiveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int!=0?45:44;continue;}
case 44:{return JStep.ReturnVoid;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/Card","canRemoveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int!=0?55:54;continue;}
case 54:{return JStep.ReturnVoid;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",61);}
case 61:{f.Locals[11]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[11]);f.Pc=65;continue;}
case 65:{f.Pc=f.Pop().Int>0?69:68;continue;}
case 68:{return JStep.ReturnVoid;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{f.Locals[12]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("All")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?89:82;continue;}
case 82:{f.Push(f.Locals[11]);f.Pc=84;continue;}
case 84:{f.Locals[12]=f.Pop();f.Pc=86;continue;}
case 86:{f.Pc=227;continue;}
case 89:{f.Push(f.Locals[5]);f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("Any")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int==0?212:99;continue;}
case 99:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",102);}
case 102:{f.Locals[13]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[13]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=108;continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",115);}
case 115:{f.StackOp("pop");f.Pc=116;continue;}
case 116:{f.Push(f.Locals[13]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("Source")));f.Pc=120;continue;}
case 120:{f.Push(f.Locals[2]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",126);}
case 126:{f.StackOp("pop");f.Pc=127;continue;}
case 127:{f.Push(f.Locals[13]);f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.String("Target")));f.Pc=131;continue;}
case 131:{f.Push(f.Locals[3]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",137);}
case 137:{f.StackOp("pop");f.Pc=138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("NonZero")));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",145);}
case 145:{f.Pc=f.Pop().Int==0?162:148;continue;}
case 148:{f.Push(f.Locals[6]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"com/google/common/collect/Multiset","isEmpty","()Z","invokeinterface",155);}
case 155:{f.Pc=f.Pop().Int==0?162:158;continue;}
case 158:{f.Push(JValue.I(1));f.Pc=159;continue;}
case 159:{f.Pc=163;continue;}
case 162:{f.Push(JValue.I(0));f.Pc=163;continue;}
case 163:{f.Locals[14]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[9]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[1]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",171);}
case 171:{f.Push(JValue.R(rt.String("lblTakeHowManyTargetCounterFromCard")));f.Pc=174;continue;}
case 174:{f.Push(JValue.I(2));f.Pc=175;continue;}
case 175:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=178;continue;}
case 178:{f.StackOp("dup");f.Pc=179;continue;}
case 179:{f.Push(JValue.I(0));f.Pc=180;continue;}
case 180:{f.Push(f.Locals[4]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",187);}
case 187:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=188;continue;}
case 188:{f.StackOp("dup");f.Pc=189;continue;}
case 189:{f.Push(JValue.I(1));f.Pc=190;continue;}
case 190:{f.Push(f.Locals[2]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",194);}
case 194:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",198);}
case 198:{f.Push(f.Locals[14]);f.Pc=200;continue;}
case 200:{f.Push(f.Locals[11]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[13]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;IILjava/util/Map;)I","invokevirtual",207);}
case 207:{f.Locals[12]=f.Pop();f.Pc=209;continue;}
case 209:{f.Pc=227;continue;}
case 212:{f.Push(f.Locals[11]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[7]);f.Pc=216;continue;}
case 216:{f.Push(f.Locals[5]);f.Pc=218;continue;}
case 218:{f.Push(f.Locals[1]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",222);}
case 222:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",225);}
case 225:{f.Locals[12]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[12]);f.Pc=229;continue;}
case 229:{f.Pc=f.Pop().Int<=0?261:232;continue;}
case 232:{f.Push(f.Locals[2]);f.Pc=233;continue;}
case 233:{f.Push(f.Locals[4]);f.Pc=235;continue;}
case 235:{f.Push(f.Locals[12]);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[8]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/game/card/Card","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",242);}
case 242:{f.StackOp("pop");f.Pc=243;continue;}
case 243:{f.Push(f.Locals[10]);f.Pc=245;continue;}
case 245:{f.Push(f.Locals[2]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/Game","updateLastStateForCard","(Lforge/game/card/Card;)V","invokevirtual",249);}
case 249:{f.Push(f.Locals[6]);f.Pc=251;continue;}
case 251:{f.Push(f.Locals[4]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[12]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"com/google/common/collect/Multiset","add","(Ljava/lang/Object;I)I","invokeinterface",260);}
case 260:{f.StackOp("pop");f.Pc=261;continue;}
case 261:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
