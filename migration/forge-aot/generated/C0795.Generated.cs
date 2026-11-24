// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C795{
internal static JClass Build(){var c=new JClass("forge/game/spellability/LandAbility","forge/game/spellability/AbilityStatic",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9150,"forge/game/spellability/LandAbility","<init>","(Lforge/game/card/Card;Lforge/game/card/CardState;)V",1,3,4,new JHandler[]{},M9150));
c.Add(new JMethod(9151,"forge/game/spellability/LandAbility","isLandAbility","()Z",1,1,1,new JHandler[]{},M9151));
c.Add(new JMethod(9152,"forge/game/spellability/LandAbility","isSecondary","()Z",1,1,1,new JHandler[]{},M9152));
c.Add(new JMethod(9153,"forge/game/spellability/LandAbility","canPlay","()Z",1,3,4,new JHandler[]{},M9153));
c.Add(new JMethod(9154,"forge/game/spellability/LandAbility","resolve","()V",1,2,3,new JHandler[]{},M9154));
c.Add(new JMethod(9155,"forge/game/spellability/LandAbility","toUnsuppressedString","()Ljava/lang/String;",1,5,5,new JHandler[]{},M9155));
c.Add(new JMethod(9156,"forge/game/spellability/LandAbility","getAlternateHost","(Lforge/game/card/Card;)Lforge/game/card/Card;",1,4,3,new JHandler[]{},M9156));
}

internal static JStep M9150(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","NO_COST","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","NO_COST","Lforge/card/mana/ManaCost;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/AbilityStatic","<init>","(Lforge/game/card/Card;Lforge/card/mana/ManaCost;Lforge/game/card/CardState;)V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/LandAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",13);}
case 13:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9151(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9152(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9153(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/LandAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/LandAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference==null?24:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?26:24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/LandAbility","getAlternateHost","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[1]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/player/Player","canPlayLand","(Lforge/game/card/Card;ZLforge/game/spellability/SpellAbility;)Z","invokevirtual",46);}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9154(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/LandAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","setSplitStateToPlayAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/LandAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",12);}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/LandAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/player/Player","playLand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",20);}
case 20:{f.Locals[1]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/LandAbility","getMayPlay","()Lforge/game/staticability/StaticAbility;","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Reference==null?35:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/LandAbility","getMayPlay","()Lforge/game/staticability/StaticAbility;","invokevirtual",32);}
case 32:{return rt.Call(f,"forge/game/staticability/StaticAbility","incMayPlayTurn","()V","invokevirtual",35);}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Pc=f.Pop().Reference==null?55:39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int!=0?55:46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9155(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("lblPlayLand")));f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",18);}
case 18:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",21);}
case 21:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",24);}
case 24:{f.Locals[2]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/LandAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/game/card/Card","isModal","()Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?60:35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String(" (")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",41);}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/LandAbility","getCardState","()Lforge/game/card/CardState;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",48);}
case 48:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",51);}
case 51:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",54);}
case 54:{f.Push(JValue.R(rt.String(")")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/LandAbility","getMayPlay","()Lforge/game/staticability/StaticAbility;","invokevirtual",64);}
case 64:{f.Locals[3]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Reference==null?160:69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",73);}
case 73:{f.Locals[4]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/spellability/LandAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",81);}
case 81:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int!=0?160:87;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String(" by ")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",93);}
case 93:{f.StackOp("pop");f.Pc=94;continue;}
case 94:{f.Push(f.Locals[4]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int==0?123:102;continue;}
case 102:{f.Push(f.Locals[4]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Reference==null?123:110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[4]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",116);}
case 116:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",119);}
case 119:{f.StackOp("pop");f.Pc=120;continue;}
case 120:{f.Pc=130;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[4]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",129);}
case 129:{f.StackOp("pop");f.Pc=130;continue;}
case 130:{f.Push(f.Locals[3]);f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.String("MayPlayText")));f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",136);}
case 136:{f.Pc=f.Pop().Int==0?160:139;continue;}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.String(" (")));f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",145);}
case 145:{f.Push(f.Locals[3]);f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.String("MayPlayText")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",151);}
case 151:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",154);}
case 154:{f.Push(JValue.R(rt.String(")")));f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",159);}
case 159:{f.StackOp("pop");f.Pc=160;continue;}
case 160:{f.Push(f.Locals[2]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",164);}
case 164:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9156(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?37:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?37:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/Card","isLKI","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?31:26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",30);}
case 30:{f.Locals[1]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","forceTurnFaceUp","()V","invokevirtual",35);}
case 35:{f.Push(JValue.I(1));f.Pc=36;continue;}
case 36:{f.Locals[2]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/LandAbility","getCardState","()Lforge/game/card/CardState;","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Reference==null?159:44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",48);}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/LandAbility","getCardStateName","()Lforge/card/CardStateName;","invokevirtual",52);}
case 52:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?159:55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/card/Card","isLKI","()Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int!=0?67:62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",66);}
case 66:{f.Locals[1]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/spellability/LandAbility","getCardState","()Lforge/game/card/CardState;","invokevirtual",71);}
case 71:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",74);}
case 74:{f.Locals[3]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int!=0?106:83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{f.Push(JValue.I(0));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/card/Card","addAlternateState","(Lforge/card/CardStateName;Z)V","invokevirtual",89);}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[3]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",94);}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/LandAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",98);}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",102);}
case 102:{f.Push(JValue.I(1));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",106);}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{f.Push(JValue.I(0));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",112);}
case 112:{f.StackOp("pop");f.Pc=113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/spellability/LandAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",117);}
case 117:{return rt.Call(f,"forge/game/card/Card","isDoubleFaced","()Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int==0?144:123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/spellability/LandAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",128);}
case 128:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",131);}
case 131:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",134);}
case 134:{return rt.Call(f,"forge/card/CardSplitType","getChangedStateName","()Lforge/card/CardStateName;","invokevirtual",137);}
case 137:{f.Push(f.Locals[3]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",141);}
case 141:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",144);}
case 144:{f.Push(f.Locals[1]);f.Pc=145;continue;}
case 145:{f.Push(JValue.I(-1));f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/card/Card","setLKICMC","(I)V","invokevirtual",149);}
case 149:{f.Push(f.Locals[1]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[1]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",154);}
case 154:{return rt.Call(f,"forge/game/card/Card","setLKICMC","(I)V","invokevirtual",157);}
case 157:{f.Push(JValue.I(1));f.Pc=158;continue;}
case 158:{f.Locals[2]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[2]);f.Pc=160;continue;}
case 160:{f.Pc=f.Pop().Int==0?167:163;continue;}
case 163:{f.Push(f.Locals[1]);f.Pc=164;continue;}
case 164:{f.Pc=168;continue;}
case 167:{f.Push(JValue.R(null));f.Pc=168;continue;}
case 168:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
