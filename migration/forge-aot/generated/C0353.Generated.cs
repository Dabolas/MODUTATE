// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C353{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/PowerExchangeEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3563,"forge/game/ability/effects/PowerExchangeEffect","<init>","()V",1,1,1,new JHandler[]{},M3563));
c.Add(new JMethod(3564,"forge/game/ability/effects/PowerExchangeEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,3,new JHandler[]{},M3564));
c.Add(new JMethod(3565,"forge/game/ability/effects/PowerExchangeEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,14,8,new JHandler[]{},M3565));
}

internal static JStep M3563(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3564(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/PowerExchangeEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",19);}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?52:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",28);}
case 28:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",31);}
case 31:{f.Push(JValue.R(rt.String(" exchanges power with ")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",45);}
case 45:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Pc=91;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",58);}
case 58:{f.Push(JValue.I(1));f.Pc=59;continue;}
case 59:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?91:62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",70);}
case 70:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",73);}
case 73:{f.Push(JValue.R(rt.String(" exchanges power with ")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{f.Push(JValue.I(1));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",87);}
case 87:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",90);}
case 90:{f.StackOp("pop");f.Pc=91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String(".")));f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",97);}
case 97:{f.StackOp("pop");f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",102);}
case 102:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3565(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Perpetual")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("Duration")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/ability/effects/PowerExchangeEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",27);}
case 27:{f.Locals[7]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[7]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",36);}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?59:40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Locals[5]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[7]);f.Pc=45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[6]=f.Pop();f.Pc=56;continue;}
case 56:{f.Pc=85;continue;}
case 59:{f.Push(f.Locals[7]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",67);}
case 67:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=70;continue;}
case 70:{f.Locals[5]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[7]);f.Pc=74;continue;}
case 74:{f.Push(JValue.I(1));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",80);}
case 80:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=83;continue;}
case 83:{f.Locals[6]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[5]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?101:93;continue;}
case 93:{f.Push(f.Locals[6]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int!=0?102:101;continue;}
case 101:{return JStep.ReturnVoid;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("BasePower")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",108);}
case 108:{f.Locals[8]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[8]);f.Pc=112;continue;}
case 112:{f.Pc=f.Pop().Int==0?123:115;continue;}
case 115:{f.Push(f.Locals[5]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/card/Card","getCurrentPower","()I","invokevirtual",120);}
case 120:{f.Pc=128;continue;}
case 123:{f.Push(f.Locals[5]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",128);}
case 128:{f.Locals[9]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[8]);f.Pc=132;continue;}
case 132:{f.Pc=f.Pop().Int==0?143:135;continue;}
case 135:{f.Push(f.Locals[6]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/card/Card","getCurrentPower","()I","invokevirtual",140);}
case 140:{f.Pc=148;continue;}
case 143:{f.Push(f.Locals[6]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",148);}
case 148:{f.Locals[10]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[4]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",155);}
case 155:{f.Locals[11]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[2]);f.Pc=158;continue;}
case 158:{f.Pc=f.Pop().Int==0?201:161;continue;}
case 161:{f.Push(f.Locals[5]);f.Pc=163;continue;}
case 163:{if(!rt.EnsureInitialized(f,"forge/game/card/perpetual/PerpetualNewPT"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/perpetual/PerpetualNewPT")));f.Pc=166;continue;}
case 166:{f.StackOp("dup");f.Pc=167;continue;}
case 167:{f.Push(f.Locals[11]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[10]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",174);}
case 174:{f.Push(JValue.R(null));f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/card/perpetual/PerpetualNewPT","<init>","(JLjava/lang/Integer;Ljava/lang/Integer;)V","invokespecial",178);}
case 178:{return rt.Call(f,"forge/game/card/Card","addPerpetual","(Lforge/game/card/perpetual/PerpetualInterface;)V","invokevirtual",181);}
case 181:{f.Push(f.Locals[6]);f.Pc=183;continue;}
case 183:{if(!rt.EnsureInitialized(f,"forge/game/card/perpetual/PerpetualNewPT"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/perpetual/PerpetualNewPT")));f.Pc=186;continue;}
case 186:{f.StackOp("dup");f.Pc=187;continue;}
case 187:{f.Push(f.Locals[11]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[9]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",194);}
case 194:{f.Push(JValue.R(null));f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/card/perpetual/PerpetualNewPT","<init>","(JLjava/lang/Integer;Ljava/lang/Integer;)V","invokespecial",198);}
case 198:{return rt.Call(f,"forge/game/card/Card","addPerpetual","(Lforge/game/card/perpetual/PerpetualInterface;)V","invokevirtual",201);}
case 201:{f.Push(f.Locals[5]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[10]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",208);}
case 208:{f.Push(JValue.R(null));f.Pc=209;continue;}
case 209:{f.Push(f.Locals[11]);f.Pc=211;continue;}
case 211:{f.Push(JValue.L(0));f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/card/Card","addNewPT","(Ljava/lang/Integer;Ljava/lang/Integer;JJ)V","invokevirtual",215);}
case 215:{f.Push(f.Locals[6]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[9]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",222);}
case 222:{f.Push(JValue.R(null));f.Pc=223;continue;}
case 223:{f.Push(f.Locals[11]);f.Pc=225;continue;}
case 225:{f.Push(JValue.L(0));f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/card/Card","addNewPT","(Ljava/lang/Integer;Ljava/lang/Integer;JJ)V","invokevirtual",229);}
case 229:{f.Push(f.Locals[4]);f.Pc=231;continue;}
case 231:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=234;continue;}
case 234:{f.StackOp("dup");f.Pc=235;continue;}
case 235:{f.Push(f.Locals[5]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",240);}
case 240:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",243);}
case 243:{f.Push(f.Locals[4]);f.Pc=245;continue;}
case 245:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=248;continue;}
case 248:{f.StackOp("dup");f.Pc=249;continue;}
case 249:{f.Push(f.Locals[6]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",254);}
case 254:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",257);}
case 257:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=259;continue;}
case 259:{f.Push(f.Locals[1]);f.Pc=260;continue;}
case 260:{f.Push(JValue.R(rt.String("Duration")));f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",265);}
case 265:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",268);}
case 268:{f.Pc=f.Pop().Int!=0?299:271;continue;}
case 271:{f.Push(f.Locals[2]);f.Pc=272;continue;}
case 272:{f.Pc=f.Pop().Int!=0?299:275;continue;}
case 275:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/PowerExchangeEffect$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/PowerExchangeEffect$1")));f.Pc=278;continue;}
case 278:{f.StackOp("dup");f.Pc=279;continue;}
case 279:{f.Push(f.Locals[0]);f.Pc=280;continue;}
case 280:{f.Push(f.Locals[5]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[11]);f.Pc=284;continue;}
case 284:{f.Push(f.Locals[6]);f.Pc=286;continue;}
case 286:{f.Push(f.Locals[4]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/ability/effects/PowerExchangeEffect$1","<init>","(Lforge/game/ability/effects/PowerExchangeEffect;Lforge/game/card/Card;JLforge/game/card/Card;Lforge/game/Game;)V","invokespecial",291);}
case 291:{f.Locals[13]=f.Pop();f.Pc=293;continue;}
case 293:{f.Push(f.Locals[1]);f.Pc=294;continue;}
case 294:{f.Push(f.Locals[13]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"forge/game/ability/effects/PowerExchangeEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;)V","invokestatic",299);}
case 299:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
