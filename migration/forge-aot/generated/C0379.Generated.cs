// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C379{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ReplaceEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3646,"forge/game/ability/effects/ReplaceEffect","<init>","()V",1,1,1,new JHandler[]{},M3646));
c.Add(new JMethod(3647,"forge/game/ability/effects/ReplaceEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,10,6,new JHandler[]{},M3647));
}

internal static JStep M3646(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3647(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("VarName")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/ability/AbilityKey","fromString","(Ljava/lang/String;)Lforge/game/ability/AbilityKey;","invokestatic",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("VarValue")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("VarType")));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("amount")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",31);}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OriginalParams","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OriginalParams","Lforge/game/ability/AbilityKey;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[6]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("Card")));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int==0?94:55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",62);}
case 62:{f.Locals[7]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[7]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",71);}
case 71:{f.Pc=f.Pop().Int<=0?91:74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[7]);f.Pc=79;continue;}
case 79:{f.Push(JValue.I(0));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",85);}
case 85:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",90);}
case 90:{f.StackOp("pop");f.Pc=91;continue;}
case 91:{f.Pc=410;continue;}
case 94:{f.Push(JValue.R(rt.String("Player")));f.Pc=96;continue;}
case 96:{f.Push(f.Locals[5]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",101);}
case 101:{f.Pc=f.Pop().Int==0?143:104;continue;}
case 104:{f.Push(f.Locals[2]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[4]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",111);}
case 111:{f.Locals[7]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[7]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",120);}
case 120:{f.Pc=f.Pop().Int<=0?140:123;continue;}
case 123:{f.Push(f.Locals[6]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[3]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[7]);f.Pc=128;continue;}
case 128:{f.Push(JValue.I(0));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",134);}
case 134:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",139);}
case 139:{f.StackOp("pop");f.Pc=140;continue;}
case 140:{f.Pc=410;continue;}
case 143:{f.Push(JValue.R(rt.String("GameEntity")));f.Pc=145;continue;}
case 145:{f.Push(f.Locals[5]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int==0?192:153;continue;}
case 153:{f.Push(f.Locals[2]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[4]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedObjects","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",160);}
case 160:{f.Locals[7]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[7]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",169);}
case 169:{f.Pc=f.Pop().Int<=0?189:172;continue;}
case 172:{f.Push(f.Locals[6]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[3]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[7]);f.Pc=177;continue;}
case 177:{f.Push(JValue.I(0));f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",183);}
case 183:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",188);}
case 188:{f.StackOp("pop");f.Pc=189;continue;}
case 189:{f.Pc=410;continue;}
case 192:{f.Push(JValue.R(rt.String("PlanarDice")));f.Pc=194;continue;}
case 194:{f.Push(f.Locals[5]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",199);}
case 199:{f.Pc=f.Pop().Int==0?219:202;continue;}
case 202:{f.Push(f.Locals[6]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[3]);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[4]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/PlanarDice","smartValueOf","(Ljava/lang/String;)Lforge/game/PlanarDice;","invokestatic",210);}
case 210:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",215);}
case 215:{f.StackOp("pop");f.Pc=216;continue;}
case 216:{f.Pc=410;continue;}
case 219:{f.Push(JValue.R(rt.String("Map")));f.Pc=221;continue;}
case 221:{f.Push(f.Locals[5]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",226);}
case 226:{f.Pc=f.Pop().Int==0?323:229;continue;}
case 229:{f.Push(f.Locals[1]);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[3]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",234);}
case 234:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=237;continue;}
case 237:{f.Locals[7]=f.Pop();f.Pc=239;continue;}
case 239:{f.Push(f.Locals[2]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[1]);f.Pc=241;continue;}
case 241:{f.Push(JValue.R(rt.String("VarKey")));f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",246);}
case 246:{f.Push(f.Locals[1]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",250);}
case 250:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",253);}
case 253:{f.Locals[8]=f.Pop();f.Pc=255;continue;}
case 255:{f.Push(f.Locals[8]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",262);}
case 262:{f.Pc=f.Pop().Int==0?320:265;continue;}
case 265:{f.Push(f.Locals[8]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",272);}
case 272:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=275;continue;}
case 275:{f.Locals[9]=f.Pop();f.Pc=277;continue;}
case 277:{f.Push(f.Locals[7]);f.Pc=279;continue;}
case 279:{f.Push(f.Locals[9]);f.Pc=281;continue;}
case 281:{f.Push(f.Locals[7]);f.Pc=283;continue;}
case 283:{f.Push(f.Locals[9]);f.Pc=285;continue;}
case 285:{f.Push(JValue.I(0));f.Pc=286;continue;}
case 286:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",289);}
case 289:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",294);}
case 294:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=297;continue;}
case 297:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",300);}
case 300:{f.Push(f.Locals[2]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[4]);f.Pc=303;continue;}
case 303:{f.Push(f.Locals[1]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",307);}
case 307:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=308;continue;}
case 308:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",311);}
case 311:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",316);}
case 316:{f.StackOp("pop");f.Pc=317;continue;}
case 317:{f.Pc=255;continue;}
case 320:{f.Pc=410;continue;}
case 323:{f.Push(JValue.R(rt.String("CardSet")));f.Pc=325;continue;}
case 325:{f.Push(f.Locals[5]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",330);}
case 330:{f.Pc=f.Pop().Int==0?387:333;continue;}
case 333:{f.Push(f.Locals[6]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[3]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",341);}
case 341:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=344;continue;}
case 344:{f.Locals[7]=f.Pop();f.Pc=346;continue;}
case 346:{f.Push(f.Locals[2]);f.Pc=347;continue;}
case 347:{f.Push(f.Locals[4]);f.Pc=349;continue;}
case 349:{f.Push(f.Locals[1]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",353);}
case 353:{f.Locals[8]=f.Pop();f.Pc=355;continue;}
case 355:{f.Push(f.Locals[8]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",362);}
case 362:{f.Pc=f.Pop().Int!=0?384:365;continue;}
case 365:{f.Push(f.Locals[7]);f.Pc=367;continue;}
case 367:{f.Push(f.Locals[8]);f.Pc=369;continue;}
case 369:{f.Push(JValue.I(0));f.Pc=370;continue;}
case 370:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",375);}
case 375:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=378;continue;}
case 378:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",383);}
case 383:{f.StackOp("pop");f.Pc=384;continue;}
case 384:{f.Pc=410;continue;}
case 387:{f.Push(f.Locals[3]);f.Pc=388;continue;}
case 388:{f.Pc=f.Pop().Reference==null?410:391;continue;}
case 391:{f.Push(f.Locals[6]);f.Pc=393;continue;}
case 393:{f.Push(f.Locals[3]);f.Pc=394;continue;}
case 394:{f.Push(f.Locals[2]);f.Pc=395;continue;}
case 395:{f.Push(f.Locals[4]);f.Pc=397;continue;}
case 397:{f.Push(f.Locals[1]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",401);}
case 401:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",404);}
case 404:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",409);}
case 409:{f.StackOp("pop");f.Pc=410;continue;}
case 410:{f.Push(f.Locals[6]);f.Pc=412;continue;}
case 412:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"));f.Pc=415;continue;}
case 415:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"));f.Pc=418;continue;}
case 418:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",423);}
case 423:{f.StackOp("pop");f.Pc=424;continue;}
case 424:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
