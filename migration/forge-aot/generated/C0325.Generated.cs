// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C325{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/LifeLoseEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3468,"forge/game/ability/effects/LifeLoseEffect","<init>","()V",1,1,1,new JHandler[]{},M3468));
c.Add(new JMethod(3469,"forge/game/ability/effects/LifeLoseEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,7,4,new JHandler[]{},M3469));
c.Add(new JMethod(3470,"forge/game/ability/effects/LifeLoseEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,8,5,new JHandler[]{},M3470));
}

internal static JStep M3468(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3469(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("LifeAmount")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",19);}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Locals[5]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/ability/effects/LifeLoseEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",38);}
case 38:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",41);}
case 41:{f.Locals[6]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/ability/effects/LifeLoseEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",49);}
case 49:{f.Push(JValue.R(rt.String("Defined")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/ability/effects/LifeLoseEffect","playersOrDescribed","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;","invokestatic",54);}
case 54:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",57);}
case 57:{f.StackOp("pop");f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[6]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(1));f.Pc=62;continue;}
case 62:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?70:65;continue;}
case 65:{f.Push(JValue.R(rt.String(" each lose ")));f.Pc=67;continue;}
case 67:{f.Pc=72;continue;}
case 70:{f.Push(JValue.R(rt.String(" loses ")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",80);}
case 80:{f.Pc=f.Pop().Int!=0?118:83;continue;}
case 83:{f.Push(f.Locals[5]);f.Pc=85;continue;}
case 85:{f.Pc=f.Pop().Reference==null?118:88;continue;}
case 88:{f.Push(f.Locals[5]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("life equal to")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int==0?118:98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[5]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[5]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("life equal to")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",108);}
case 108:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",111);}
case 111:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Pc=130;continue;}
case 118:{f.Push(f.Locals[2]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[4]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",124);}
case 124:{f.Push(JValue.R(rt.String(" life.")));f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",129);}
case 129:{f.StackOp("pop");f.Pc=130;continue;}
case 130:{f.Push(f.Locals[2]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",134);}
case 134:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3470(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("LifeAmount")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",20);}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/ability/effects/LifeLoseEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",26);}
case 26:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",29);}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int==0?103:41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Locals[6]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int!=0?64:61;continue;}
case 61:{f.Pc=31;continue;}
case 64:{f.Push(f.Locals[6]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{f.Push(JValue.I(0));f.Pc=68;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/player/Player","loseLife","(IZZLforge/game/spellability/SpellAbility;)I","invokevirtual",73);}
case 73:{f.Locals[7]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[7]);f.Pc=77;continue;}
case 77:{f.Pc=f.Pop().Int<=0?95:80;continue;}
case 80:{f.Push(f.Locals[4]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[6]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[7]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",89);}
case 89:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",94);}
case 94:{f.StackOp("pop");f.Pc=95;continue;}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[7]);f.Pc=98;continue;}
case 98:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=99;continue;}
case 99:{f.Locals[2]=f.Pop();f.Pc=100;continue;}
case 100:{f.Pc=31;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("AFLifeLost")));f.Pc=106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{return rt.DynamicCall(f,"forge/game/ability/effects/LifeLoseEffect:3470:107:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",112);}
case 112:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",115);}
case 115:{f.Push(f.Locals[4]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",122);}
case 122:{f.Pc=f.Pop().Int!=0?151:125;continue;}
case 125:{f.Push(f.Locals[4]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPIMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",130);}
case 130:{f.Locals[5]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[1]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",136);}
case 136:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",139);}
case 139:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",142);}
case 142:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","LifeLostAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","LifeLostAll","Lforge/game/trigger/TriggerType;"));f.Pc=145;continue;}
case 145:{f.Push(f.Locals[5]);f.Pc=147;continue;}
case 147:{f.Push(JValue.I(0));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",151);}
case 151:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
