// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C322{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/LifeExchangeEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3459,"forge/game/ability/effects/LifeExchangeEffect","<init>","()V",1,1,1,new JHandler[]{},M3459));
c.Add(new JMethod(3460,"forge/game/ability/effects/LifeExchangeEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,5,3,new JHandler[]{},M3460));
c.Add(new JMethod(3461,"forge/game/ability/effects/LifeExchangeEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,5,new JHandler[]{},M3461));
}

internal static JStep M3459(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3460(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/ability/effects/LifeExchangeEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",26);}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?57:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",35);}
case 35:{f.Push(JValue.R(rt.String(" exchanges life totals with ")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",40);}
case 40:{f.StackOp("pop");f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",50);}
case 50:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Pc=99;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",64);}
case 64:{f.Push(JValue.I(1));f.Pc=65;continue;}
case 65:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?99:68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",77);}
case 77:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",80);}
case 80:{f.Push(JValue.R(rt.String(" exchanges life totals with ")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",85);}
case 85:{f.StackOp("pop");f.Pc=86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{f.Push(JValue.I(1));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",95);}
case 95:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",98);}
case 98:{f.StackOp("pop");f.Pc=99;continue;}
case 99:{f.Push(f.Locals[2]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.String(".")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",105);}
case 105:{f.StackOp("pop");f.Pc=106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",110);}
case 110:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3461(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/effects/LifeExchangeEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",9);}
case 9:{f.Locals[5]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[5]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",18);}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?43:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[5]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Pc=68;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[3]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{f.Locals[4]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",72);}
case 72:{f.Locals[6]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[4]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",79);}
case 79:{f.Locals[7]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[6]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[7]);f.Pc=85;continue;}
case 85:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/Math","abs","(I)I","invokestatic",89);}
case 89:{f.Locals[8]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[6]);f.Pc=95;continue;}
case 95:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?108:98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{f.Locals[9]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{f.Locals[4]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[9]);f.Pc=107;continue;}
case 107:{f.Locals[3]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[8]);f.Pc=110;continue;}
case 110:{f.Pc=f.Pop().Int<=0?225:113;continue;}
case 113:{f.Push(f.Locals[3]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/player/Player","canLoseLife","()Z","invokevirtual",117);}
case 117:{f.Pc=f.Pop().Int==0?225:120;continue;}
case 120:{f.Push(f.Locals[4]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/player/Player","canGainLife","()Z","invokevirtual",125);}
case 125:{f.Pc=f.Pop().Int==0?225:128;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[8]);f.Pc=131;continue;}
case 131:{f.Push(JValue.I(0));f.Pc=132;continue;}
case 132:{f.Push(JValue.I(0));f.Pc=133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/player/Player","loseLife","(IZZLforge/game/spellability/SpellAbility;)I","invokevirtual",137);}
case 137:{f.Locals[9]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[4]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[8]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[2]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[1]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/player/Player","gainLife","(ILforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",148);}
case 148:{f.StackOp("pop");f.Pc=149;continue;}
case 149:{f.Push(f.Locals[9]);f.Pc=151;continue;}
case 151:{f.Pc=f.Pop().Int<=0?225:154;continue;}
case 154:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",157);}
case 157:{f.Locals[10]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[10]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[9]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",167);}
case 167:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",172);}
case 172:{f.StackOp("pop");f.Pc=173;continue;}
case 173:{f.Push(f.Locals[10]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPIMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",178);}
case 178:{f.Locals[11]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[2]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",184);}
case 184:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",187);}
case 187:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","LifeLostAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","LifeLostAll","Lforge/game/trigger/TriggerType;"));f.Pc=190;continue;}
case 190:{f.Push(f.Locals[11]);f.Pc=192;continue;}
case 192:{f.Push(JValue.I(0));f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",196);}
case 196:{f.Push(f.Locals[1]);f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.String("RememberOwnLoss")));f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",202);}
case 202:{f.Pc=f.Pop().Int==0?225:205;continue;}
case 205:{f.Push(f.Locals[3]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[1]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",210);}
case 210:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",213);}
case 213:{f.Pc=f.Pop().Int==0?225:216;continue;}
case 216:{f.Push(f.Locals[2]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[9]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",222);}
case 222:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",225);}
case 225:{f.Push(f.Locals[1]);f.Pc=226;continue;}
case 226:{f.Push(JValue.R(rt.String("RememberDifference")));f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",231);}
case 231:{f.Pc=f.Pop().Int==0?251:234;continue;}
case 234:{f.Push(f.Locals[2]);f.Pc=235;continue;}
case 235:{f.Push(f.Locals[3]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",239);}
case 239:{f.Push(f.Locals[4]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",244);}
case 244:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=245;continue;}
case 245:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",248);}
case 248:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",251);}
case 251:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
