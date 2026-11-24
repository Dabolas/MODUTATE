// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C380{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ReplaceManaEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3648,"forge/game/ability/effects/ReplaceManaEffect","<init>","()V",1,1,1,new JHandler[]{},M3648));
c.Add(new JMethod(3649,"forge/game/ability/effects/ReplaceManaEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,4,new JHandler[]{},M3649));
}

internal static JStep M3648(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3649(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
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
case 31:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[5]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("ReplaceMana")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?94:51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("ReplaceMana")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",57);}
case 57:{f.Locals[5]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("Any")));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?368:69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",73);}
case 73:{f.Push(JValue.R(rt.String("Choose a color")));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{if(!rt.StaticReady(f,"forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/player/PlayerController","chooseColor","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/card/ColorSet;)B","invokevirtual",82);}
case 82:{f.Locals[6]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[6]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",89);}
case 89:{f.Locals[5]=f.Pop();f.Pc=91;continue;}
case 91:{f.Pc=368;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("ReplaceType")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int==0?207:103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("ReplaceType")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",109);}
case 109:{f.Locals[6]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String("Any")));f.Pc=113;continue;}
case 113:{f.Push(f.Locals[6]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int==0?146:121;continue;}
case 121:{f.Push(f.Locals[3]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",125);}
case 125:{f.Push(JValue.R(rt.String("Choose a color")));f.Pc=127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{if(!rt.StaticReady(f,"forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"));f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/player/PlayerController","chooseColor","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/card/ColorSet;)B","invokevirtual",134);}
case 134:{f.Locals[7]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[7]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",141);}
case 141:{f.Locals[6]=f.Pop();f.Pc=143;continue;}
case 143:{f.Pc=153;continue;}
case 146:{f.Push(f.Locals[6]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",151);}
case 151:{f.Locals[6]=f.Pop();f.Pc=153;continue;}
case 153:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRGC","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRGC","[B"));f.Pc=156;continue;}
case 156:{f.Locals[7]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[7]);f.Pc=160;continue;}
case 160:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=161;continue;}
case 161:{f.Locals[8]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(JValue.I(0));f.Pc=164;continue;}
case 164:{f.Locals[9]=f.Pop();f.Pc=166;continue;}
case 166:{f.Push(f.Locals[9]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[8]);f.Pc=170;continue;}
case 170:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?204:173;continue;}
case 173:{f.Push(f.Locals[7]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[9]);f.Pc=177;continue;}
case 177:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=178;continue;}
case 178:{f.Locals[10]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[10]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",185);}
case 185:{f.Locals[11]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[5]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[11]);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[6]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",196);}
case 196:{f.Locals[5]=f.Pop();f.Pc=198;continue;}
case 198:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=201;continue;}
case 201:{f.Pc=166;continue;}
case 204:{f.Pc=368;continue;}
case 207:{f.Push(f.Locals[1]);f.Pc=208;continue;}
case 208:{f.Push(JValue.R(rt.String("ReplaceColor")));f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",213);}
case 213:{f.Pc=f.Pop().Int==0?341:216;continue;}
case 216:{f.Push(f.Locals[1]);f.Pc=217;continue;}
case 217:{f.Push(JValue.R(rt.String("ReplaceColor")));f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",222);}
case 222:{f.Locals[6]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(JValue.R(rt.String("Chosen")));f.Pc=226;continue;}
case 226:{f.Push(f.Locals[6]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",231);}
case 231:{f.Pc=f.Pop().Int==0?253:234;continue;}
case 234:{f.Push(f.Locals[2]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","()Z","invokevirtual",238);}
case 238:{f.Pc=f.Pop().Int==0?260:241;continue;}
case 241:{f.Push(f.Locals[2]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/card/Card","getChosenColor","()Ljava/lang/String;","invokevirtual",245);}
case 245:{return rt.Call(f,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",248);}
case 248:{f.Locals[6]=f.Pop();f.Pc=250;continue;}
case 250:{f.Pc=260;continue;}
case 253:{f.Push(f.Locals[6]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",258);}
case 258:{f.Locals[6]=f.Pop();f.Pc=260;continue;}
case 260:{f.Push(f.Locals[1]);f.Pc=261;continue;}
case 261:{f.Push(JValue.R(rt.String("ReplaceOnly")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",266);}
case 266:{f.Pc=f.Pop().Int==0?287:269;continue;}
case 269:{f.Push(f.Locals[5]);f.Pc=271;continue;}
case 271:{f.Push(f.Locals[1]);f.Pc=272;continue;}
case 272:{f.Push(JValue.R(rt.String("ReplaceOnly")));f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",277);}
case 277:{f.Push(f.Locals[6]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",282);}
case 282:{f.Locals[5]=f.Pop();f.Pc=284;continue;}
case 284:{f.Pc=338;continue;}
case 287:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=290;continue;}
case 290:{f.Locals[7]=f.Pop();f.Pc=292;continue;}
case 292:{f.Push(f.Locals[7]);f.Pc=294;continue;}
case 294:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=295;continue;}
case 295:{f.Locals[8]=f.Pop();f.Pc=297;continue;}
case 297:{f.Push(JValue.I(0));f.Pc=298;continue;}
case 298:{f.Locals[9]=f.Pop();f.Pc=300;continue;}
case 300:{f.Push(f.Locals[9]);f.Pc=302;continue;}
case 302:{f.Push(f.Locals[8]);f.Pc=304;continue;}
case 304:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?338:307;continue;}
case 307:{f.Push(f.Locals[7]);f.Pc=309;continue;}
case 309:{f.Push(f.Locals[9]);f.Pc=311;continue;}
case 311:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=312;continue;}
case 312:{f.Locals[10]=f.Pop();f.Pc=314;continue;}
case 314:{f.Push(f.Locals[10]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",319);}
case 319:{f.Locals[11]=f.Pop();f.Pc=321;continue;}
case 321:{f.Push(f.Locals[5]);f.Pc=323;continue;}
case 323:{f.Push(f.Locals[11]);f.Pc=325;continue;}
case 325:{f.Push(f.Locals[6]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",330);}
case 330:{f.Locals[5]=f.Pop();f.Pc=332;continue;}
case 332:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=335;continue;}
case 335:{f.Pc=300;continue;}
case 338:{f.Pc=368;continue;}
case 341:{f.Push(f.Locals[1]);f.Pc=342;continue;}
case 342:{f.Push(JValue.R(rt.String("ReplaceAmount")));f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",347);}
case 347:{f.Pc=f.Pop().Int==0?368:350;continue;}
case 350:{f.Push(f.Locals[5]);f.Pc=352;continue;}
case 352:{f.Push(JValue.R(rt.String(" ")));f.Pc=354;continue;}
case 354:{f.Push(f.Locals[1]);f.Pc=355;continue;}
case 355:{f.Push(JValue.R(rt.String("ReplaceAmount")));f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",360);}
case 360:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",363);}
case 363:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","repeat","(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;","invokestatic",366);}
case 366:{f.Locals[5]=f.Pop();f.Pc=368;continue;}
case 368:{f.Push(f.Locals[4]);f.Pc=370;continue;}
case 370:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"));f.Pc=373;continue;}
case 373:{f.Push(f.Locals[5]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",380);}
case 380:{f.StackOp("pop");f.Pc=381;continue;}
case 381:{f.Push(f.Locals[4]);f.Pc=383;continue;}
case 383:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"));f.Pc=386;continue;}
case 386:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"));f.Pc=389;continue;}
case 389:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",394);}
case 394:{f.StackOp("pop");f.Pc=395;continue;}
case 395:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
