// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C409{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/TapEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3758,"forge/game/ability/effects/TapEffect","<init>","()V",1,1,1,new JHandler[]{},M3758));
c.Add(new JMethod(3759,"forge/game/ability/effects/TapEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,9,new JHandler[]{},M3759));
c.Add(new JMethod(3760,"forge/game/ability/effects/TapEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,2,new JHandler[]{},M3760));
}

internal static JStep M3758(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3759(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("RememberTapped")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Locals[5]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("CardChoices")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?156:33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",37);}
case 37:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",43);}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("CardChoices")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",49);}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",55);}
case 55:{f.Locals[7]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("ChoiceAmount")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?80:66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("ChoiceAmount")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",77);}
case 77:{f.Pc=81;continue;}
case 80:{f.Push(JValue.I(1));f.Pc=81;continue;}
case 81:{f.Locals[8]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("AnyNumber")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int==0?96:92;continue;}
case 92:{f.Push(JValue.I(0));f.Pc=93;continue;}
case 93:{f.Pc=98;continue;}
case 96:{f.Push(f.Locals[8]);f.Pc=98;continue;}
case 98:{f.Locals[9]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("ChoicePrompt")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?118:109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("ChoicePrompt")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",115);}
case 115:{f.Pc=130;continue;}
case 118:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",121);}
case 121:{f.Push(JValue.R(rt.String("lblChoosePermanentstoTap")));f.Pc=123;continue;}
case 123:{f.Push(JValue.I(0));f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",130);}
case 130:{f.Locals[10]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[2]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",136);}
case 136:{f.Push(f.Locals[7]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[9]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[8]);f.Pc=142;continue;}
case 142:{f.Push(JValue.R(null));f.Pc=143;continue;}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[10]);f.Pc=146;continue;}
case 146:{f.Push(JValue.R(null));f.Pc=147;continue;}
case 147:{f.Push(JValue.R(null));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/player/PlayerController","chooseEntitiesForEffect","(Lforge/util/collect/FCollectionView;IILforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/Player;Ljava/util/Map;)Ljava/util/List;","invokevirtual",151);}
case 151:{f.Locals[6]=f.Pop();f.Pc=153;continue;}
case 153:{f.Pc=162;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/ability/effects/TapEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",160);}
case 160:{f.Locals[6]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[2]);f.Pc=163;continue;}
case 163:{f.Locals[7]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[1]);f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("Tapper")));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",171);}
case 171:{f.Pc=f.Pop().Int==0?193:174;continue;}
case 174:{f.Push(f.Locals[3]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[1]);f.Pc=176;continue;}
case 176:{f.Push(JValue.R(rt.String("Tapper")));f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",181);}
case 181:{f.Push(f.Locals[1]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",185);}
case 185:{return rt.Call(f,"forge/game/player/PlayerCollection","getFirst","()Ljava/lang/Object;","invokevirtual",188);}
case 188:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=191;continue;}
case 191:{f.Locals[7]=f.Pop();f.Pc=193;continue;}
case 193:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=196;continue;}
case 196:{f.StackOp("dup");f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",200);}
case 200:{f.Locals[8]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[6]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",209);}
case 209:{f.Locals[9]=f.Pop();f.Pc=211;continue;}
case 211:{f.Push(f.Locals[9]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",218);}
case 218:{f.Pc=f.Pop().Int==0?336:221;continue;}
case 221:{f.Push(f.Locals[9]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",228);}
case 228:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=231;continue;}
case 231:{f.Locals[10]=f.Pop();f.Pc=233;continue;}
case 233:{f.Push(f.Locals[10]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",238);}
case 238:{f.Pc=f.Pop().Int==0?244:241;continue;}
case 241:{f.Pc=211;continue;}
case 244:{f.Push(f.Locals[4]);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[10]);f.Pc=248;continue;}
case 248:{f.Push(JValue.R(null));f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",252);}
case 252:{f.Locals[11]=f.Pop();f.Pc=254;continue;}
case 254:{f.Push(f.Locals[11]);f.Pc=256;continue;}
case 256:{f.Pc=f.Pop().Reference==null?211:259;continue;}
case 259:{f.Push(f.Locals[10]);f.Pc=261;continue;}
case 261:{f.Push(f.Locals[11]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",266);}
case 266:{f.Pc=f.Pop().Int!=0?272:269;continue;}
case 269:{f.Pc=211;continue;}
case 272:{f.Push(f.Locals[11]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",277);}
case 277:{f.Pc=f.Pop().Int==0?318:280;continue;}
case 280:{f.Push(f.Locals[11]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/card/Card","isUntapped","()Z","invokevirtual",285);}
case 285:{f.Pc=f.Pop().Int==0?299:288;continue;}
case 288:{f.Push(f.Locals[5]);f.Pc=290;continue;}
case 290:{f.Pc=f.Pop().Int==0?299:293;continue;}
case 293:{f.Push(f.Locals[3]);f.Pc=294;continue;}
case 294:{f.Push(f.Locals[11]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",299);}
case 299:{f.Push(f.Locals[11]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[1]);f.Pc=302;continue;}
case 302:{f.Push(f.Locals[7]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/card/Card","tap","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z","invokevirtual",307);}
case 307:{f.Pc=f.Pop().Int==0?318:310;continue;}
case 310:{f.Push(f.Locals[8]);f.Pc=312;continue;}
case 312:{f.Push(f.Locals[11]);f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",317);}
case 317:{f.StackOp("pop");f.Pc=318;continue;}
case 318:{f.Push(f.Locals[1]);f.Pc=319;continue;}
case 319:{f.Push(JValue.R(rt.String("ETB")));f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",324);}
case 324:{f.Pc=f.Pop().Int==0?333:327;continue;}
case 327:{f.Push(f.Locals[10]);f.Pc=329;continue;}
case 329:{f.Push(JValue.I(1));f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",333);}
case 333:{f.Pc=211;continue;}
case 336:{f.Push(f.Locals[8]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",341);}
case 341:{f.Pc=f.Pop().Int!=0?378:344;continue;}
case 344:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",347);}
case 347:{f.Locals[9]=f.Pop();f.Pc=349;continue;}
case 349:{f.Push(f.Locals[9]);f.Pc=351;continue;}
case 351:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=354;continue;}
case 354:{f.Push(f.Locals[8]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",361);}
case 361:{f.StackOp("pop");f.Pc=362;continue;}
case 362:{f.Push(f.Locals[2]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",366);}
case 366:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",369);}
case 369:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"));f.Pc=372;continue;}
case 372:{f.Push(f.Locals[9]);f.Pc=374;continue;}
case 374:{f.Push(JValue.I(0));f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",378);}
case 378:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3760(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Tap ")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/ability/effects/TapEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",20);}
case 20:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",23);}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String(".")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",38);}
case 38:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
