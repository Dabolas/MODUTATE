// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C396{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ScryEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3711,"forge/game/ability/effects/ScryEffect","<init>","()V",1,1,1,new JHandler[]{},M3711));
c.Add(new JMethod(3712,"forge/game/ability/effects/ScryEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,5,3,new JHandler[]{},M3712));
c.Add(new JMethod(3713,"forge/game/ability/effects/ScryEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,7,6,new JHandler[]{},M3713));
}

internal static JStep M3711(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3712(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/ScryEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",18);}
case 18:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",21);}
case 21:{f.Push(JValue.R(rt.String(" ")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("ScryNum")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int==0?55:39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",43);}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("ScryNum")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",49);}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",53);}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",62);}
case 62:{f.Push(JValue.I(1));f.Pc=63;continue;}
case 63:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?71:66;continue;}
case 66:{f.Push(JValue.R(rt.String("scries ")));f.Pc=68;continue;}
case 68:{f.Pc=73;continue;}
case 71:{f.Push(JValue.R(rt.String("scry ")));f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",76);}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",81);}
case 81:{f.Push(JValue.R(rt.String(".")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",86);}
case 86:{f.StackOp("pop");f.Pc=87;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",91);}
case 91:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3713(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("ScryNum")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?26:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",15);}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("ScryNum")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Optional")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",32);}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",36);}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/ability/effects/ScryEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",42);}
case 42:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",45);}
case 45:{f.Locals[5]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Int==0?123:57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",64);}
case 64:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=67;continue;}
case 67:{f.Locals[6]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[6]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int!=0?80:77;continue;}
case 77:{f.Pc=47;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{f.Pc=f.Pop().Int==0?110:84;continue;}
case 84:{f.Push(f.Locals[6]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",89);}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(null));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",94);}
case 94:{f.Push(JValue.R(rt.String("lblDoYouWanttoScry")));f.Pc=96;continue;}
case 96:{f.Push(JValue.I(0));f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",103);}
case 103:{f.Push(JValue.R(null));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int==0?120:110;continue;}
case 110:{f.Push(f.Locals[4]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[6]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",119);}
case 119:{f.StackOp("pop");f.Pc=120;continue;}
case 120:{f.Pc=47;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",127);}
case 127:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",130);}
case 130:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",133);}
case 133:{f.Push(f.Locals[4]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[2]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/GameAction","scry","(Ljava/util/List;ILforge/game/spellability/SpellAbility;)V","invokevirtual",140);}
case 140:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
