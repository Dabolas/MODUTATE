// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C381{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ReplaceSplitDamageEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3650,"forge/game/ability/effects/ReplaceSplitDamageEffect","<init>","()V",1,1,1,new JHandler[]{},M3650));
c.Add(new JMethod(3651,"forge/game/ability/effects/ReplaceSplitDamageEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,11,3,new JHandler[]{},M3651));
}

internal static JStep M3650(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3651(JRuntime rt,JFrame f)
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
case 19:{f.Push(JValue.R(rt.String("VarName")));f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("1")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OriginalParams","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OriginalParams","Lforge/game/ability/AbilityKey;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[5]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{f.Locals[6]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[4]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",59);}
case 59:{f.Locals[7]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("DamageTarget")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",68);}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedObjects","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",72);}
case 72:{f.Locals[8]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[7]);f.Pc=76;continue;}
case 76:{f.Pc=f.Pop().Int<=0?262:79;continue;}
case 79:{f.Push(f.Locals[8]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",86);}
case 86:{f.Pc=f.Pop().Int<=0?262:89;continue;}
case 89:{f.Push(f.Locals[8]);f.Pc=91;continue;}
case 91:{f.Push(JValue.I(0));f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",97);}
case 97:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/GameEntity")?1:0));f.Pc=100;continue;}
case 100:{f.Pc=f.Pop().Int==0?262:103;continue;}
case 103:{f.Push(f.Locals[6]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",108);}
case 108:{f.Push(f.Locals[7]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",113);}
case 113:{f.Locals[9]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[5]);f.Pc=117;continue;}
case 117:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DividedShieldAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DividedShieldAmount","Lforge/game/ability/AbilityKey;"));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",125);}
case 125:{f.Pc=f.Pop().Reference==null?151:128;continue;}
case 128:{f.Push(f.Locals[9]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[5]);f.Pc=132;continue;}
case 132:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DividedShieldAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DividedShieldAmount","Lforge/game/ability/AbilityKey;"));f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",140);}
case 140:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",146);}
case 146:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",149);}
case 149:{f.Locals[9]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[6]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",156);}
case 156:{f.Push(f.Locals[9]);f.Pc=158;continue;}
case 158:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",162);}
case 162:{f.Locals[6]=f.Pop();f.Pc=164;continue;}
case 164:{f.Push(f.Locals[7]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[9]);f.Pc=168;continue;}
case 168:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=169;continue;}
case 169:{f.Locals[7]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[2]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",175);}
case 175:{f.Pc=f.Pop().Int==0?195:178;continue;}
case 178:{f.Push(f.Locals[7]);f.Pc=180;continue;}
case 180:{f.Pc=f.Pop().Int>0?195:183;continue;}
case 183:{f.Push(f.Locals[3]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",187);}
case 187:{f.Push(f.Locals[2]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/GameAction","exileEffect","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",191);}
case 191:{f.StackOp("pop");f.Pc=192;continue;}
case 192:{f.Pc=220;continue;}
case 195:{f.Push(f.Locals[4]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",200);}
case 200:{f.Pc=f.Pop().Int!=0?220:203;continue;}
case 203:{f.Push(f.Locals[1]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[4]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[7]);f.Pc=208;continue;}
case 208:{return rt.DynamicCall(f,"forge/game/ability/effects/ReplaceSplitDamageEffect:3651:208:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",213);}
case 213:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",216);}
case 216:{f.Push(f.Locals[2]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/card/Card","updateAbilityTextForView","()V","invokevirtual",220);}
case 220:{f.Push(f.Locals[8]);f.Pc=222;continue;}
case 222:{f.Push(JValue.I(0));f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",228);}
case 228:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=231;continue;}
case 231:{f.Locals[10]=f.Pop();f.Pc=233;continue;}
case 233:{f.Push(f.Locals[5]);f.Pc=235;continue;}
case 235:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=238;continue;}
case 238:{f.Push(f.Locals[10]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",245);}
case 245:{f.StackOp("pop");f.Pc=246;continue;}
case 246:{f.Push(f.Locals[5]);f.Pc=248;continue;}
case 248:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=251;continue;}
case 251:{f.Push(f.Locals[9]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",256);}
case 256:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",261);}
case 261:{f.StackOp("pop");f.Pc=262;continue;}
case 262:{f.Push(f.Locals[6]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",267);}
case 267:{f.Pc=f.Pop().Int>0?285:270;continue;}
case 270:{f.Push(f.Locals[5]);f.Pc=272;continue;}
case 272:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"));f.Pc=275;continue;}
case 275:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Replaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Replaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=278;continue;}
case 278:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",283);}
case 283:{f.StackOp("pop");f.Pc=284;continue;}
case 284:{return JStep.ReturnVoid;}
case 285:{f.Push(f.Locals[5]);f.Pc=287;continue;}
case 287:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"));f.Pc=290;continue;}
case 290:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"));f.Pc=293;continue;}
case 293:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",298);}
case 298:{f.StackOp("pop");f.Pc=299;continue;}
case 299:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
