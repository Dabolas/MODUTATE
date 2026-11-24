// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C714{
internal static JClass Build(){var c=new JClass("forge/game/player/PlayerFactoryUtil","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(8621,"forge/game/player/PlayerFactoryUtil","<init>","()V",1,1,1,new JHandler[]{},M8621));
c.Add(new JMethod(8622,"forge/game/player/PlayerFactoryUtil","addStaticAbility","(Lforge/game/keyword/KeywordInterface;Lforge/game/player/Player;)V",9,8,5,new JHandler[]{},M8622));
c.Add(new JMethod(8623,"forge/game/player/PlayerFactoryUtil","addTriggerAbility","(Lforge/game/keyword/KeywordInterface;Lforge/game/player/Player;)V",9,2,0,new JHandler[]{},M8623));
c.Add(new JMethod(8624,"forge/game/player/PlayerFactoryUtil","addReplacementEffect","(Lforge/game/keyword/KeywordInterface;Lforge/game/player/Player;)V",9,6,4,new JHandler[]{},M8624));
c.Add(new JMethod(8625,"forge/game/player/PlayerFactoryUtil","addSpellAbility","(Lforge/game/keyword/KeywordInterface;Lforge/game/player/Player;)V",9,2,0,new JHandler[]{},M8625));
}

internal static JStep M8621(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8622(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("Hexproof")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?114:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/Hexproof")?1:0));f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Int==0?114:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/Hexproof"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",35);}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/keyword/Hexproof","getValidType","()Ljava/lang/String;","invokevirtual",41);}
case 41:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int!=0?62:47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("| ValidSource$ ")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",54);}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/keyword/Hexproof","getValidType","()Ljava/lang/String;","invokevirtual",58);}
case 58:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",67);}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getTitle","()Ljava/lang/String;","invokeinterface",73);}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",79);}
case 79:{return rt.DynamicCall(f,"forge/game/player/PlayerFactoryUtil:8622:79:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",84);}
case 84:{f.Locals[5]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/player/Player","getKeywordCard","()Lforge/game/card/Card;","invokevirtual",90);}
case 90:{f.Locals[6]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[5]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[6]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[6]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",102);}
case 102:{f.Push(JValue.I(0));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",106);}
case 106:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",111);}
case 111:{f.Pc=307;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("Shroud")));f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int==0?164:123;continue;}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",129);}
case 129:{return rt.DynamicCall(f,"forge/game/player/PlayerFactoryUtil:8622:129:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",134);}
case 134:{f.Locals[4]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/player/Player","getKeywordCard","()Lforge/game/card/Card;","invokevirtual",140);}
case 140:{f.Locals[5]=f.Pop();f.Pc=142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[4]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[5]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[5]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",152);}
case 152:{f.Push(JValue.I(0));f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",156);}
case 156:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",161);}
case 161:{f.Pc=307;continue;}
case 164:{f.Push(f.Locals[2]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("Protection")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",170);}
case 170:{f.Pc=f.Pop().Int==0?307:173;continue;}
case 173:{f.Push(f.Locals[2]);f.Pc=174;continue;}
case 174:{f.Push(JValue.I(0));f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/keyword/Protection","getProtectionValid","(Ljava/lang/String;Z)Ljava/lang/String;","invokestatic",178);}
case 178:{f.Locals[4]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("Mode$ CantTarget | ValidTarget$ Player.You | EffectZone$ Command | Secondary$ True ")));f.Pc=182;continue;}
case 182:{f.Locals[5]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(f.Locals[4]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",189);}
case 189:{f.Pc=f.Pop().Int!=0?203:192;continue;}
case 192:{f.Push(f.Locals[5]);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[4]);f.Pc=196;continue;}
case 196:{return rt.DynamicCall(f,"forge/game/player/PlayerFactoryUtil:8622:196:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",201);}
case 201:{f.Locals[5]=f.Pop();f.Pc=203;continue;}
case 203:{f.Push(f.Locals[1]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/player/Player","getKeywordCard","()Lforge/game/card/Card;","invokevirtual",207);}
case 207:{f.Locals[6]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[0]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[5]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[6]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[6]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",219);}
case 219:{f.Push(JValue.I(0));f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",223);}
case 223:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",228);}
case 228:{f.Push(JValue.R(rt.String("Mode$ CantAttach | Target$ Player.You | EffectZone$ Command | Secondary$ True ")));f.Pc=230;continue;}
case 230:{f.Locals[5]=f.Pop();f.Pc=232;continue;}
case 232:{f.Push(f.Locals[4]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",237);}
case 237:{f.Pc=f.Pop().Int!=0?251:240;continue;}
case 240:{f.Push(f.Locals[5]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[4]);f.Pc=244;continue;}
case 244:{return rt.DynamicCall(f,"forge/game/player/PlayerFactoryUtil:8622:244:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",249);}
case 249:{f.Locals[5]=f.Pop();f.Pc=251;continue;}
case 251:{f.Push(f.Locals[2]);f.Pc=252;continue;}
case 252:{f.Push(JValue.R(rt.String("Protection:")));f.Pc=254;continue;}
case 254:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",257);}
case 257:{f.Pc=f.Pop().Int==0?288:260;continue;}
case 260:{f.Push(f.Locals[2]);f.Pc=261;continue;}
case 261:{f.Push(JValue.R(rt.String(":")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",266);}
case 266:{f.Locals[7]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[7]);f.Pc=270;continue;}
case 270:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=271;continue;}
case 271:{f.Push(JValue.I(3));f.Pc=272;continue;}
case 272:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?288:275;continue;}
case 275:{f.Push(f.Locals[5]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[7]);f.Pc=279;continue;}
case 279:{f.Push(JValue.I(3));f.Pc=280;continue;}
case 280:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=281;continue;}
case 281:{return rt.DynamicCall(f,"forge/game/player/PlayerFactoryUtil:8622:281:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",286);}
case 286:{f.Locals[5]=f.Pop();f.Pc=288;continue;}
case 288:{f.Push(f.Locals[0]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[5]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[6]);f.Pc=293;continue;}
case 293:{f.Push(f.Locals[6]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",298);}
case 298:{f.Push(JValue.I(0));f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",302);}
case 302:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V","invokeinterface",307);}
case 307:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8623(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8624(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("Protection")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?53:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/keyword/Protection","getProtectionValid","(Ljava/lang/String;Z)Ljava/lang/String;","invokestatic",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("Event$ DamageDone | Prevent$ True | ActiveZones$ Command | ValidTarget$ You")));f.Pc=27;continue;}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int!=0?45:36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{return rt.DynamicCall(f,"forge/game/player/PlayerFactoryUtil:8624:39:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",44);}
case 44:{f.Locals[3]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return rt.DynamicCall(f,"forge/game/player/PlayerFactoryUtil:8624:47:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",52);}
case 52:{f.Locals[3]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{f.Pc=f.Pop().Reference==null?85:57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/player/Player","getKeywordCard","()Lforge/game/card/Card;","invokevirtual",61);}
case 61:{f.Locals[4]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{f.Push(JValue.I(0));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",72);}
case 72:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",75);}
case 75:{f.Locals[5]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[5]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V","invokeinterface",85);}
case 85:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8625(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
