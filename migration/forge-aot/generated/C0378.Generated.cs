// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C378{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ReplaceDamageEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3644,"forge/game/ability/effects/ReplaceDamageEffect","<init>","()V",1,1,1,new JHandler[]{},M3644));
c.Add(new JMethod(3645,"forge/game/ability/effects/ReplaceDamageEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,9,3,new JHandler[]{},M3645));
}

internal static JStep M3644(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3645(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?18:17;continue;}
case 17:{return JStep.ReturnVoid;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OriginalParams","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OriginalParams","Lforge/game/ability/AbilityKey;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[5]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("Amount")));f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("1")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",50);}
case 50:{f.Locals[6]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",59);}
case 59:{f.Locals[7]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[7]);f.Pc=63;continue;}
case 63:{f.Pc=f.Pop().Int<=0?210:66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",71);}
case 71:{f.Push(f.Locals[7]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",76);}
case 76:{f.Locals[8]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[4]);f.Pc=80;continue;}
case 80:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DividedShieldAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DividedShieldAmount","Lforge/game/ability/AbilityKey;"));f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",88);}
case 88:{f.Pc=f.Pop().Reference==null?114:91;continue;}
case 91:{f.Push(f.Locals[8]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DividedShieldAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DividedShieldAmount","Lforge/game/ability/AbilityKey;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",103);}
case 103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",109);}
case 109:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",112);}
case 112:{f.Locals[8]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[5]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",119);}
case 119:{f.Push(f.Locals[8]);f.Pc=121;continue;}
case 121:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",125);}
case 125:{f.Locals[5]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[7]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[8]);f.Pc=131;continue;}
case 131:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=132;continue;}
case 132:{f.Locals[7]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[6]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",139);}
case 139:{f.Pc=f.Pop().Int!=0?197:142;continue;}
case 142:{f.Push(f.Locals[2]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[6]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",148);}
case 148:{f.Push(JValue.R(rt.String("Number$")));f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int==0?197:156;continue;}
case 156:{f.Push(f.Locals[2]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",160);}
case 160:{f.Pc=f.Pop().Int==0?180:163;continue;}
case 163:{f.Push(f.Locals[7]);f.Pc=165;continue;}
case 165:{f.Pc=f.Pop().Int>0?180:168;continue;}
case 168:{f.Push(f.Locals[3]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",172);}
case 172:{f.Push(f.Locals[2]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/GameAction","exileEffect","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",176);}
case 176:{f.StackOp("pop");f.Pc=177;continue;}
case 177:{f.Pc=197;continue;}
case 180:{f.Push(f.Locals[2]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[6]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[7]);f.Pc=185;continue;}
case 185:{return rt.DynamicCall(f,"forge/game/ability/effects/ReplaceDamageEffect:3645:185:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",190);}
case 190:{return rt.Call(f,"forge/game/card/Card","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",193);}
case 193:{f.Push(f.Locals[2]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/card/Card","updateAbilityTextForView","()V","invokevirtual",197);}
case 197:{f.Push(f.Locals[2]);f.Pc=198;continue;}
case 198:{f.Push(JValue.R(rt.String("PreventedDamage")));f.Pc=200;continue;}
case 200:{f.Push(f.Locals[8]);f.Pc=202;continue;}
case 202:{return rt.DynamicCall(f,"forge/game/ability/effects/ReplaceDamageEffect:3645:202:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",207);}
case 207:{return rt.Call(f,"forge/game/card/Card","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",210);}
case 210:{f.Push(f.Locals[5]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",215);}
case 215:{f.Pc=f.Pop().Int>0?233:218;continue;}
case 218:{f.Push(f.Locals[4]);f.Pc=220;continue;}
case 220:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"));f.Pc=223;continue;}
case 223:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Replaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Replaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",231);}
case 231:{f.StackOp("pop");f.Pc=232;continue;}
case 232:{return JStep.ReturnVoid;}
case 233:{f.Push(f.Locals[4]);f.Pc=235;continue;}
case 235:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=238;continue;}
case 238:{f.Push(f.Locals[5]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",245);}
case 245:{f.StackOp("pop");f.Pc=246;continue;}
case 246:{f.Push(f.Locals[4]);f.Pc=248;continue;}
case 248:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"));f.Pc=251;continue;}
case 251:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"));f.Pc=254;continue;}
case 254:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",259);}
case 259:{f.StackOp("pop");f.Pc=260;continue;}
case 260:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
