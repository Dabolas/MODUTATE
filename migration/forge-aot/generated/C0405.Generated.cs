// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C405{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/SurveilEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3744,"forge/game/ability/effects/SurveilEffect","<init>","()V",1,1,1,new JHandler[]{},M3744));
c.Add(new JMethod(3745,"forge/game/ability/effects/SurveilEffect","movesCardToOrFromLibrary","(Lforge/game/spellability/SpellAbility;)Z",1,2,1,new JHandler[]{},M3745));
c.Add(new JMethod(3746,"forge/game/ability/effects/SurveilEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,3,new JHandler[]{},M3746));
c.Add(new JMethod(3747,"forge/game/ability/effects/SurveilEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,8,6,new JHandler[]{},M3747));
}

internal static JStep M3744(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3745(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3746(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/effects/SurveilEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",16);}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Amount")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?46:31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",35);}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("Amount")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",41);}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",45);}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String(" surveils (")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",52);}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",56);}
case 56:{f.Push(JValue.R(rt.String(").")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",66);}
case 66:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3747(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("Amount")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?26:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",15);}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Amount")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Int!=0?31:30;continue;}
case 30:{return JStep.ReturnVoid;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("Optional")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",37);}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",41);}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",49);}
case 49:{f.Locals[5]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/ability/effects/SurveilEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",55);}
case 55:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",58);}
case 58:{f.Locals[6]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[6]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",67);}
case 67:{f.Pc=f.Pop().Int==0?138:70;continue;}
case 70:{f.Push(f.Locals[6]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",77);}
case 77:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=80;continue;}
case 80:{f.Locals[7]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[7]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int!=0?93:90;continue;}
case 90:{f.Pc=60;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{f.Pc=f.Pop().Int==0?126:97;continue;}
case 97:{f.Push(f.Locals[7]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",102);}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(null));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",107);}
case 107:{f.Push(JValue.R(rt.String("lblDoYouWantSurveil")));f.Pc=109;continue;}
case 109:{f.Push(JValue.I(0));f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",116);}
case 116:{f.Push(JValue.R(null));f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int!=0?126:123;continue;}
case 123:{f.Pc=60;continue;}
case 126:{f.Push(f.Locals[7]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[2]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[4]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/player/Player","surveil","(ILforge/game/spellability/SpellAbility;Ljava/util/Map;)V","invokevirtual",135);}
case 135:{f.Pc=60;continue;}
case 138:{f.Push(f.Locals[5]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[1]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",144);}
case 144:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",147);}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",151);}
case 151:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
